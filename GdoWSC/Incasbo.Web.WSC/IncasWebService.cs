using System;
using System.Data;
using System.Reflection;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;
#if NETFRAMEWORK
using System.Web;
using System.Web.Services;
#else
using Incasbo.Web.Compat;
#endif

namespace Incasbo.Web.WSC;

public abstract class IncasWebService : WebService
{
	protected string _EmbeddedUser;

	protected string _EmbeddedPassword;

	protected int _iErrFileMaxLength;

	protected int _iLogFileMaxLength;

	protected bool _ServiceInitialized;

	protected string WSApplicationRoot => HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"].ToString();

	protected string WSApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	protected string WSApplicationLog => WSApplicationLogDir + WSApplicationName + ".LOG";

	protected string WSApplicationLogDir => WSApplicationRoot + "Log\\";

	protected string WSApplicationIniConfigDir => WSApplicationRoot + "IniConfig\\";

	protected string WSDBConfigFile => WSApplicationIniConfigDir + "DBConfig.ini";

	protected string WSAppConfigFile => WSApplicationIniConfigDir + "WSCConfig.ini";

	protected string WSApplicationErr => WSApplicationLogDir + WSApplicationName + ".ERR";

	protected virtual string Username
	{
		get
		{
			return SessionEnvironment.User;
		}
		set
		{
			SessionEnvironment.User = value;
		}
	}

	protected virtual string Group
	{
		get
		{
			return SessionEnvironment.Group;
		}
		set
		{
			SessionEnvironment.Group = value;
		}
	}

	protected virtual string Organizzazione
	{
		get
		{
			return SessionEnvironment.Organizzazione;
		}
		set
		{
			SessionEnvironment.Organizzazione = value;
		}
	}

	protected virtual string UserDescription
	{
		get
		{
			return SessionEnvironment.UserDescription;
		}
		set
		{
			SessionEnvironment.UserDescription = value;
		}
	}

	protected virtual string Password
	{
		get
		{
			return SessionEnvironment.Password;
		}
		set
		{
			SessionEnvironment.Password = value;
		}
	}

	public WSC_SessionEnvironment SessionEnvironment => (WSC_SessionEnvironment)((WebService)this).Session["SessionEnvironment"];

	public string ClientIp
	{
		get
		{
			if (((WebService)this).Session["CLIENT.IP"] != null)
			{
				return ((WebService)this).Session["CLIENT.IP"].ToString();
			}
			return "";
		}
	}

	public string ClientHostname
	{
		get
		{
			if (((WebService)this).Session["CLIENT.HOSTNAME"] != null)
			{
				return ((WebService)this).Session["CLIENT.HOSTNAME"].ToString();
			}
			return "";
		}
	}

	protected Exception LastExceptionOccurred
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.LogHandling.LastExceptionOccurred;
			}
			return null;
		}
	}

	protected string CallStack
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.CallStackHandler.CallStack;
			}
			return "";
		}
	}

	protected IboAppCallStackHandling CallStackHandler
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.CallStackHandler;
			}
			return null;
		}
	}

	public virtual IboAppLogHandling LogHandling => SessionEnvironment.LogHandling;

	public virtual IboWebParam Parametrica => SessionEnvironment.Parametrica;

	protected IncasWebService()
	{
		_EmbeddedUser = "EU_INCAS";
		_EmbeddedPassword = "74incasbo04";
		_iErrFileMaxLength = 10485760;
		_iLogFileMaxLength = 10485760;
		_ServiceInitialized = false;
	}

	protected abstract FXRETURN AutenticazioneUtente(string sUtente, string sPassword, ref string rsmess);

	protected abstract FXRETURN LoginComplete(ref string rsMess);

	protected abstract FXRETURN LogoutComplete(ref string rsMess);

	protected abstract string ServiceName();

	[WebMethod(Description = "Autentica l'utente", EnableSession = true)]
	public abstract bool LogIn(string User, string Password, ref string rsMess);

	[WebMethod(Description = "Log out dell'utente", EnableSession = true)]
	public abstract bool LogOut(ref string rsmess);

	[WebMethod(Description = "Dice se l'utente è autenticato", EnableSession = true)]
	public abstract bool isAuthenticate();

	[WebMethod(Description = "Restituisce la data attuale", EnableSession = true)]
	public virtual bool GetDateTime(ref DateTime sReturnValue, ref string rsMess)
	{
		bool result = false;
		sReturnValue = DateTime.MinValue;
		if (!isAuthenticate())
		{
			rsMess = "Utente non autenticato";
		}
		else
		{
			result = true;
			sReturnValue = DateTime.Now;
		}
		return result;
	}

	[WebMethod(Description = "Testa la connettività al database", EnableSession = true)]
	public virtual bool TestDBConnection(ref string rsMess)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		bool result = false;
		if (!isAuthenticate())
		{
			rsMess = "Utente non autenticato";
		}
		else if ((int)MyTestDBConnection(ref rsMess) == 0)
		{
			result = true;
		}
		return result;
	}

	[WebMethod(Description = "Restituisce la versione del prodotto", EnableSession = true)]
	public virtual string GetVersion()
	{
		return Assembly.GetAssembly(((object)this).GetType()).GetName().Version.ToString();
	}

	[WebMethod(Description = "Ping Test", EnableSession = true)]
	public virtual string TestPing(string sStringa)
	{
		return "RISPOSTA: " + sStringa + " - " + DateTime.Now;
	}

	protected virtual FXRETURN LogoutBegin(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (SessionEnvironment.DbMain != null)
			{
				DBConnection dbMain = SessionEnvironment.DbMain;
				string rsMess = "";
				dbMain.CloseConnection(ref rsMess);
				SessionEnvironment.DbMain.Dispose();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN InitWebService(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		FXRETURN result;
		try
		{
			rsmess = "";
			if (_ServiceInitialized)
			{
				goto IL_0121;
			}
			IboAppLogHandling logHandling = SessionEnvironment.LogHandling;
			string wSApplicationName = WSApplicationName;
			string username = Username;
			string wSApplicationLog = WSApplicationLog;
			string wSApplicationErr = WSApplicationErr;
			long num = _iLogFileMaxLength;
			long num2 = _iErrFileMaxLength;
			IboAppCallStackHandling callStackHandler = SessionEnvironment.CallStackHandler;
			val2 = logHandling.Init(wSApplicationName, username, wSApplicationLog, wSApplicationErr, num, num2, true, ref callStackHandler, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				string text = "";
				try
				{
					text = HttpContext.Current.Request.UserHostName;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					text = "";
					ProjectData.ClearProjectError();
				}
				SessionEnvironment.SessionVariable.Add("CLIENT.HOSTNAME", text);
				try
				{
					text = HttpContext.Current.Request.UserHostAddress;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					text = "";
					ProjectData.ClearProjectError();
				}
				SessionEnvironment.SessionVariable.Add("CLIENT.IP", text);
				_ServiceInitialized = true;
				SessionEnvironment.WSCConfig.Init(WSAppConfigFile, WSDBConfigFile);
				val2 = SessionEnvironment.InitDBConnection(ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_0121;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_0121:
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN MyTestDBConnection(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			rsmess = "";
			text = "SELECT * FROM WFI_UTENTI";
			val2 = SessionEnvironment.DbMain.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	protected string TranslateMessage(string Context, string vsDefault, params string[] vParametri)
	{
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.Translator.TranslateMessage(Context, vsDefault, vParametri);
		}
		return "";
	}

	protected string TranslateMessage(string Context, string vsDefault)
	{
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.Translator.TranslateMessage(Context, vsDefault, new string[0]);
		}
		return "";
	}

	protected void CallStackAdd()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackAdd();
		}
	}

	protected void CallStackReset()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackReset();
		}
	}

	protected void CallStackRemove()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackRemove();
		}
	}

	protected FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.LogHandling.HandleError(ref objEx, ref rsMess);
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	protected FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.LogHandling.HandleError(ref objEx, vsMessage, ref rsMess);
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (SessionEnvironment.DebugMode)
		{
			if (SessionEnvironment.Performance == null)
			{
				SessionEnvironment.Performance = new PerformanceLog(WSApplicationLogDir + "PerformanceLog.txt", 2097152);
			}
			sMessaggioLog = ServiceName().PadRight(50) + sMessaggioLog;
			((LogFileFlushed)SessionEnvironment.Performance).Write(sMessaggioLog);
		}
	}

	public void PerformanceLogFlush(string sMessaggioLog)
	{
		PerformanceLogAppend(sMessaggioLog);
		if (SessionEnvironment.DebugMode && SessionEnvironment.Performance != null)
		{
			((LogFileFlushed)SessionEnvironment.Performance).Flush();
		}
	}

	public void PerformanceLogStopWatch()
	{
		SessionEnvironment.Performance.StopWatch();
	}

	public virtual void WriteDebugInfo(string Contesto, string Messaggio1, string Messaggio2)
	{
		WriteDebugInfo("", Contesto, Messaggio1, Messaggio2, "", AlwaysInsert: false, "");
	}

	public virtual void WriteDebugInfo(string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser)
	{
		SessionEnvironment.WriteDebugInfo(Applicazione, Contesto, Messaggio1, Messaggio2, IdSessione, AlwaysInsert, DebugUser);
	}

	public virtual AppApiContext CreateApiContext(bool WithCloneConnection = false)
	{
		return SessionEnvironment.CreateApiContext(WithCloneConnection);
	}
}
