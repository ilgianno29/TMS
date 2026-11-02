using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Web;
using System.Web.SessionState;

namespace Incasbo.Web.WFI;

/// <summary>
/// Query dei tooltip AJAX delle griglie (colonne "AJAX:..." in NOMCAMTOOLTIP).
/// <para>
/// Prima la query SQL veniva cifrata con la chiave fissa di IboCrypt e messa nella pagina; il metodo
/// getWFIAjaxTooltipContent la decifrava ed eseguiva qualsiasi testo contenente "SELECT ".
/// Poiche' la chiave e' nota, qualunque utente collegato poteva far eseguire SQL arbitrario.
/// </para>
/// Ora la query resta in sessione sul server e la pagina riceve solo un identificativo casuale:
/// il browser puo' chiedere soltanto query registrate dal server per la propria sessione.
/// </summary>
public static class TooltipQueryStore
{
	private const string SessionKey = "WFI.TooltipQueryStore";

	private const int MaxEntries = 20000;

	private sealed class Store
	{
		public readonly Dictionary<string, string> ById = new Dictionary<string, string>(StringComparer.Ordinal);

		public readonly Dictionary<string, string> BySql = new Dictionary<string, string>(StringComparer.Ordinal);
	}

	/// <summary>Registra la query per la sessione corrente e restituisce l'identificativo da mettere nella pagina.</summary>
	public static string Register(string sql)
	{
		Store store = GetStore(HttpContext.Current?.Session, create: true);
		if (store == null || string.IsNullOrEmpty(sql))
		{
			return "";
		}
		lock (store)
		{
			if (store.BySql.TryGetValue(sql, out string existing))
			{
				return existing;
			}
			if (store.ById.Count >= MaxEntries)
			{
				store.ById.Clear();
				store.BySql.Clear();
			}
			string id = NewId();
			store.ById[id] = sql;
			store.BySql[sql] = id;
			return id;
		}
	}

	/// <summary>Restituisce la query registrata con questo identificativo, oppure null.</summary>
	public static string Resolve(string id)
	{
		Store store = GetStore(HttpContext.Current?.Session, create: false);
		if (store == null || string.IsNullOrEmpty(id))
		{
			return null;
		}
		lock (store)
		{
			return store.ById.TryGetValue(id, out string sql) ? sql : null;
		}
	}

	private static Store GetStore(HttpSessionState session, bool create)
	{
		if (session == null)
		{
			return null;
		}
		if (session[SessionKey] is Store store)
		{
			return store;
		}
		if (!create)
		{
			return null;
		}
		store = new Store();
		session[SessionKey] = store;
		return store;
	}

	private static string NewId()
	{
		byte[] bytes = new byte[18];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(bytes);
		}
		return "tq_" + Convert.ToBase64String(bytes).Replace('+', '-').Replace('/', '_');
	}
}
