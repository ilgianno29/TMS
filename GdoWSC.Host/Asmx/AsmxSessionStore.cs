using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Incasbo.Web.Compat;
using Incasbo.Web.WSC;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Incasbo.Web.Host.Asmx;

/// <summary>
/// Sessioni "InProc" come in ASP.NET classico:
/// - all'avvio di una sessione viene creato WSC_SessionEnvironment (Global.asax Session_Start);
/// - alla scadenza viene distrutto (Global.asax Session_End);
/// - le richieste della stessa sessione vengono eseguite una alla volta, come faceva ASP.NET
///   (WSC_SessionEnvironment contiene la connessione al database e non e' thread-safe).
/// </summary>
public sealed class AsmxSessionStore : IDisposable
{
	public sealed class Entry
	{
		internal Entry(HttpSessionState state)
		{
			State = state;
			Touch();
		}

		public HttpSessionState State { get; }

		internal SemaphoreSlim Lock { get; } = new SemaphoreSlim(1, 1);

		internal long LastAccessTicks;

		internal void Touch() => Interlocked.Exchange(ref LastAccessTicks, DateTime.UtcNow.Ticks);
	}

	private readonly ConcurrentDictionary<string, Entry> _sessions = new ConcurrentDictionary<string, Entry>(StringComparer.Ordinal);
	private readonly AsmxOptions _options;
	private readonly ILogger<AsmxSessionStore> _logger;

	public AsmxSessionStore(IOptions<AsmxOptions> options, ILogger<AsmxSessionStore> logger)
	{
		_options = options.Value;
		_logger = logger;
	}

	public int Count => _sessions.Count;

	/// <summary>Restituisce la sessione indicata dal cookie, oppure ne crea una nuova.</summary>
	public Entry GetOrCreate(string sessionId, out bool created)
	{
		if (!string.IsNullOrEmpty(sessionId) && _sessions.TryGetValue(sessionId, out Entry existing) && !IsExpired(existing))
		{
			existing.Touch();
			created = false;
			return existing;
		}
		// Id sconosciuto o scaduto: nuova sessione con nuovo id (evita di riusare id forniti dal client)
		Entry entry = new Entry(new HttpSessionState(NewSessionId()));
		_sessions[entry.State.SessionID] = entry;
		OnSessionStart(entry.State);
		created = true;
		return entry;
	}

	public bool TryGet(string sessionId, out Entry entry)
	{
		entry = null;
		return !string.IsNullOrEmpty(sessionId) && _sessions.TryGetValue(sessionId, out entry) && !IsExpired(entry);
	}

	/// <summary>Elimina le sessioni scadute (chiamato periodicamente).</summary>
	public int RemoveExpired()
	{
		int removed = 0;
		foreach (var pair in _sessions)
		{
			if (IsExpired(pair.Value) && _sessions.TryRemove(pair.Key, out Entry entry))
			{
				EndSession(entry);
				removed++;
			}
		}
		return removed;
	}

	private bool IsExpired(Entry entry) =>
		DateTime.UtcNow - new DateTime(Interlocked.Read(ref entry.LastAccessTicks), DateTimeKind.Utc) > _options.SessionTimeout;

	private void OnSessionStart(HttpSessionState session)
	{
		try
		{
			session["SessionEnvironment"] = new WSC_SessionEnvironment();
		}
		catch (Exception ex)
		{
			// Come Global.asax: l'errore non blocca la sessione, ma ora viene registrato
			_logger.LogError(ex, "Errore nella creazione dell'ambiente di sessione {SessionId}", session.SessionID);
		}
	}

	private void EndSession(Entry entry)
	{
		// Attende l'eventuale richiesta in corso, come ASP.NET che non termina una sessione bloccata
		entry.Lock.Wait(TimeSpan.FromMinutes(1));
		try
		{
			(entry.State["SessionEnvironment"] as WSC_SessionEnvironment)?.Destroy();
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Errore nella chiusura della sessione {SessionId}", entry.State.SessionID);
		}
		finally
		{
			entry.State["SessionEnvironment"] = null;
			entry.Lock.Release();
		}
	}

	/// <summary>Id di 24 caratteri a-z0-5, nello stesso formato di ASP.NET.</summary>
	private static string NewSessionId()
	{
		const string alphabet = "abcdefghijklmnopqrstuvwxyz012345";
		Span<byte> bytes = stackalloc byte[24];
		RandomNumberGenerator.Fill(bytes);
		char[] chars = new char[24];
		for (int i = 0; i < chars.Length; i++)
		{
			chars[i] = alphabet[bytes[i] & 31];
		}
		return new string(chars);
	}

	public void Dispose()
	{
		foreach (var pair in _sessions)
		{
			if (_sessions.TryRemove(pair.Key, out Entry entry))
			{
				EndSession(entry);
			}
		}
	}
}

/// <summary>Elimina periodicamente le sessioni scadute (Session_End).</summary>
public sealed class AsmxSessionCleanupService : BackgroundService
{
	private readonly AsmxSessionStore _store;

	public AsmxSessionCleanupService(AsmxSessionStore store)
	{
		_store = store;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (!stoppingToken.IsCancellationRequested)
		{
			await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
			_store.RemoveExpired();
		}
	}
}
