using System;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public class IboWebUserInfo
{
	public enum AuthenticationState
	{
		Authenticated,
		WaitingForAuthentication,
		PasswordNotCorrected,
		PasswordExpired,
		Unknown
	}

	protected string _Codice;

	protected string _Descrizione;

	protected string _Password;

	protected int _GiorniValidPwd;

	protected string _Filtro;

	protected string _FiltroSoggetto;

	protected string _AbilitazioneFiltroUtente;

	protected string _FiltroUtente;

	protected string _CampoFiltroSoggetto;

	protected string _CampoFiltroSoggetto2;

	protected string _CampoFiltroSoggetto3;

	protected string _Attivo;

	protected string _Tipo;

	protected string _Gruppo;

	protected string _PaginaIniziale;

	protected int _Peso;

	protected DateTime _ScadenzaPassword;

	protected string _Lingua;

	protected string _Nome;

	protected string _Cognome;

	protected string _Indirizzo;

	protected string _Localita;

	protected string _Provincia;

	protected string _CAP;

	protected string _Telefono;

	protected string _Cellulare;

	protected string _EMail;

	protected string _Cliente;

	protected string _FilialeDefault;

	protected string _Filiale;

	protected string _FilialeDescrizione;

	protected string[] _Filiali;

	protected string[] _FilialiDescrizione;

	protected StringCollection _CodiciSoggetti;

	protected internal DataTable dtUtente;

	protected AuthenticationState _Authenticated;

	protected string _AuthenticationError;

	public string Codice => _Codice;

	public virtual AuthenticationState Authenticated
	{
		get
		{
			return _Authenticated;
		}
		set
		{
			_Authenticated = value;
		}
	}

	public virtual string AuthenticationError
	{
		get
		{
			return _AuthenticationError;
		}
		set
		{
			_AuthenticationError = value;
		}
	}

	public virtual string Descrizione
	{
		get
		{
			return _Descrizione;
		}
		set
		{
			_Descrizione = value;
		}
	}

	public virtual string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
		}
	}

	public virtual int GiorniValidPwd
	{
		get
		{
			return _GiorniValidPwd;
		}
		set
		{
			_GiorniValidPwd = value;
		}
	}

	public virtual string Filtro
	{
		get
		{
			return _Filtro;
		}
		set
		{
			_Filtro = value;
		}
	}

	public virtual string FiltroSoggetto
	{
		get
		{
			return _FiltroSoggetto;
		}
		set
		{
			_FiltroSoggetto = value;
		}
	}

	public virtual string FiltroUtente
	{
		get
		{
			return _FiltroUtente;
		}
		set
		{
			_FiltroUtente = value;
		}
	}

	public virtual string AbilitazioneFiltroUtente
	{
		get
		{
			return _AbilitazioneFiltroUtente;
		}
		set
		{
			_AbilitazioneFiltroUtente = value;
		}
	}

	public virtual string CampoFiltroSoggetto
	{
		get
		{
			return _CampoFiltroSoggetto;
		}
		set
		{
			_CampoFiltroSoggetto = value;
		}
	}

	public virtual string CampoFiltroSoggetto2
	{
		get
		{
			return _CampoFiltroSoggetto2;
		}
		set
		{
			_CampoFiltroSoggetto2 = value;
		}
	}

	public virtual string CampoFiltroSoggetto3
	{
		get
		{
			return _CampoFiltroSoggetto3;
		}
		set
		{
			_CampoFiltroSoggetto3 = value;
		}
	}

	public virtual StringCollection CodiciSoggetti
	{
		get
		{
			return _CodiciSoggetti;
		}
		set
		{
			_CodiciSoggetti = value;
		}
	}

	public virtual string Gruppo
	{
		get
		{
			return _Gruppo;
		}
		set
		{
			_Gruppo = value;
		}
	}

	public virtual string Attivo
	{
		get
		{
			return _Attivo;
		}
		set
		{
			_Attivo = value;
		}
	}

	public virtual string Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			_Tipo = value;
		}
	}

	public virtual string PaginaIniziale
	{
		get
		{
			return _PaginaIniziale;
		}
		set
		{
			_PaginaIniziale = value;
		}
	}

	public virtual DateTime ScadenzaPassword
	{
		get
		{
			return _ScadenzaPassword;
		}
		set
		{
			_ScadenzaPassword = value;
		}
	}

	public virtual int Peso
	{
		get
		{
			return _Peso;
		}
		set
		{
			_Peso = value;
		}
	}

	public virtual string Lingua
	{
		get
		{
			return _Lingua;
		}
		set
		{
			_Lingua = value;
		}
	}

	public virtual string Nome
	{
		get
		{
			return _Nome;
		}
		set
		{
			_Nome = value;
		}
	}

	public virtual string Cognome
	{
		get
		{
			return _Cognome;
		}
		set
		{
			_Cognome = value;
		}
	}

	public virtual string Indirizzo
	{
		get
		{
			return _Indirizzo;
		}
		set
		{
			_Indirizzo = value;
		}
	}

	public virtual string Localita
	{
		get
		{
			return _Localita;
		}
		set
		{
			_Localita = value;
		}
	}

	public virtual string Provincia
	{
		get
		{
			return _Provincia;
		}
		set
		{
			_Provincia = value;
		}
	}

	public virtual string CAP
	{
		get
		{
			return _CAP;
		}
		set
		{
			_CAP = value;
		}
	}

	public virtual string Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			_Telefono = value;
		}
	}

	public virtual string Cellulare
	{
		get
		{
			return _Cellulare;
		}
		set
		{
			_Cellulare = value;
		}
	}

	public virtual string EMail
	{
		get
		{
			return _EMail;
		}
		set
		{
			_EMail = value;
		}
	}

	public virtual string Cliente
	{
		get
		{
			return _Cliente;
		}
		set
		{
			_Cliente = value;
		}
	}

	public virtual string FilialeDefault
	{
		get
		{
			return _FilialeDefault;
		}
		set
		{
			_FilialeDefault = value;
		}
	}

	public virtual string Filiale
	{
		get
		{
			return _Filiale;
		}
		set
		{
			_Filiale = value;
		}
	}

	public virtual string FilialeDescrizione
	{
		get
		{
			return _FilialeDescrizione;
		}
		set
		{
			_FilialeDescrizione = value;
		}
	}

	public virtual string[] Filiali
	{
		get
		{
			return _Filiali;
		}
		set
		{
			_Filiali = value;
		}
	}

	public virtual string[] FilialiDescrizione
	{
		get
		{
			return _FilialiDescrizione;
		}
		set
		{
			_FilialiDescrizione = value;
		}
	}

	public string Organizzazione { get; set; }

	public string OrganizzazioneInternaEsterna { get; set; }

	public string OrganizzazioneTipoSoggetto { get; set; }

	public string MenuProfileID { get; set; }

	public string DesktopProfileID { get; set; }

	public IboWebUserInfo(string sCodice)
	{
		_Codice = "";
		_Descrizione = "";
		_Password = "";
		_Filtro = "";
		_FiltroSoggetto = "";
		_AbilitazioneFiltroUtente = "";
		_FiltroUtente = "";
		_CampoFiltroSoggetto = "";
		_CampoFiltroSoggetto2 = "";
		_CampoFiltroSoggetto3 = "";
		_Attivo = "";
		_Tipo = "";
		_Gruppo = "";
		_PaginaIniziale = "";
		_Peso = 0;
		_Lingua = "IT";
		_Nome = "";
		_Cognome = "";
		_Indirizzo = "";
		_Localita = "";
		_Provincia = "";
		_CAP = "";
		_Telefono = "";
		_Cellulare = "";
		_EMail = "";
		_Cliente = "";
		_FilialeDefault = "";
		_Filiale = "";
		_FilialeDescrizione = "";
		_CodiciSoggetti = new StringCollection();
		_Authenticated = AuthenticationState.Unknown;
		_AuthenticationError = "";
		Organizzazione = "";
		OrganizzazioneInternaEsterna = "";
		OrganizzazioneTipoSoggetto = "";
		MenuProfileID = "";
		DesktopProfileID = "";
		_Codice = sCodice;
		_Authenticated = AuthenticationState.WaitingForAuthentication;
	}

	// DecryptedPassword() rimosso: le password sono salvate come hash e non sono piu' decifrabili.
	// Le chiamate ai servizi usano l'utente di servizio (WFIConfig.ServizioGdoWSCUtente/Password).
}
