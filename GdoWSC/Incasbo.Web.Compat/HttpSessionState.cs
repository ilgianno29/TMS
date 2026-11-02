#if !NETFRAMEWORK
using System;
using System.Collections.Concurrent;

namespace Incasbo.Web.Compat;

/// <summary>
/// Sessione "InProc" come in ASP.NET classico: contiene oggetti .NET (non solo stringhe)
/// e vive in memoria finche' non scade.
/// </summary>
public sealed class HttpSessionState
{
	private readonly ConcurrentDictionary<string, object> _items = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase);

	public HttpSessionState(string sessionId)
	{
		SessionID = sessionId;
	}

	public string SessionID { get; }

	/// <summary>Come ASP.NET: una chiave assente restituisce null; assegnare null rimuove la chiave.</summary>
	public object this[string name]
	{
		get => _items.TryGetValue(name, out object value) ? value : null;
		set
		{
			if (value == null)
			{
				_items.TryRemove(name, out _);
			}
			else
			{
				_items[name] = value;
			}
		}
	}

	public int Count => _items.Count;
}
#endif
