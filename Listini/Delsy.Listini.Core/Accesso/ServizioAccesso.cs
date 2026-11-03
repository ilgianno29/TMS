using Delsy.Listini.Dati;
using Incasbo.Security;

namespace Delsy.Listini.Accesso;

public sealed record UtenteDelsy(string Codice, string Nome, string Gruppo);

/// <summary>
/// Accesso con gli utenti del portale Delsy (WFI_UTENTI), con le stesse regole sulle password:
/// hash PBKDF2, oppure vecchio formato (convertito in hash al primo accesso riuscito).
/// </summary>
public sealed class ServizioAccesso
{
	private readonly Db _db;
	private readonly bool _cryptographyEnable;

	public ServizioAccesso(Db db, bool cryptographyEnable)
	{
		_db = db;
		_cryptographyEnable = cryptographyEnable;
	}

	/// <summary>L'utente se codice e password sono giusti e l'utente è attivo, altrimenti null (senza dire cosa non va).</summary>
	public UtenteDelsy? Verifica(string codice, string password)
	{
		if (string.IsNullOrWhiteSpace(codice) || string.IsNullOrEmpty(password))
		{
			return null;
		}
		Dictionary<string, object?>? u = _db.Righe(
			"SELECT CODICE, DESCRIZIONE, NOME, COGNOME, GRUPPO, PASSWORD FROM WFI_UTENTI WHERE CODICE = @c AND ATTIVO = 'S' AND TIPO = 'U'",
			("@c", codice.Trim().ToUpperInvariant())).FirstOrDefault();
		if (u == null || !UserPasswords.Verify(password, u.Testo("PASSWORD"), _cryptographyEnable, out bool daConvertire))
		{
			return null;
		}
		if (daConvertire)
		{
			try
			{
				_db.Esegui("UPDATE WFI_UTENTI SET PASSWORD = @p WHERE CODICE = @c", ("@p", UserPasswords.ForStorage(password)), ("@c", u.Testo("CODICE")));
			}
			catch (Exception)
			{
				// colonna PASSWORD non ancora allargata (script 2026-11_01): si riprova al prossimo accesso
			}
		}
		string nome = $"{u.Testo("NOME")} {u.Testo("COGNOME")}".Trim();
		return new UtenteDelsy(u.Testo("CODICE"), nome == "" ? u.Testo("DESCRIZIONE") : nome, u.Testo("GRUPPO"));
	}
}
