using System;
using System.Data;
using System.IO;
using System.Reflection;
#if NETFRAMEWORK
using System.ServiceModel;
using System.ServiceModel.Channels;
#else
// Su .NET 8 i servizi girano in CoreWCF: il contesto della richiesta e' CoreWCF.OperationContext
using CoreWCF;
using CoreWCF.Channels;
#endif
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Incasbo.Web.WSC;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSCWCF;

public abstract class IncasWCF : IDisposable
{
	protected string _EmbeddedUser;

	protected string _EmbeddedPassword;

	protected int _iErrFileMaxLength;

	protected int _iLogFileMaxLength;

	protected bool _ServiceInitialized;

	protected bool _isAuthenticate;

	protected WSCWCF_SessionEnvironment _Session;

	protected string _WSDBConfigFile;

	protected string _WSAppConfigFile;

	private bool disposedValue;

	protected string WSApplicationRoot => Incasbo.Web.Hosting.WscHosting.ApplicationRoot;

	protected string WSApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	protected virtual string WSApplicationLog => WSApplicationLogDir + WSApplicationName + "_WCF.LOG";

	protected string WSApplicationLogDir => WSApplicationRoot + "Log\\";

	protected string WSApplicationIniConfigDir => WSApplicationRoot + "IniConfig\\";

	public virtual string WSDBConfigFile
	{
		get
		{
			return WSApplicationIniConfigDir + _WSDBConfigFile;
		}
		set
		{
			_WSDBConfigFile = value;
		}
	}

	public virtual string WSAppConfigFile
	{
		get
		{
			return WSApplicationIniConfigDir + _WSAppConfigFile;
		}
		set
		{
			_WSAppConfigFile = value;
		}
	}

	protected string WSApplicationErr => WSApplicationLogDir + WSApplicationName + "_WCF.ERR";

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

	public WSCWCF_SessionEnvironment SessionEnvironment => _Session;

	public string ClientIp => getClientIP();

	public string ClientHostname => getClientIP();

	public ApplicationDefault ApplicationDefault => SessionEnvironment.ApplicationDefault;

	public ApplicationParams ApplicationParams => SessionEnvironment.ApplicationParams;

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

	public IncasWCF()
	{
		_EmbeddedUser = "EU_INCAS";
		_EmbeddedPassword = "74incasbo04";
		_iErrFileMaxLength = 10485760;
		_iLogFileMaxLength = 10485760;
		_ServiceInitialized = false;
		_isAuthenticate = false;
		_WSDBConfigFile = "WCFDBConfig.ini";
		_WSAppConfigFile = "WSCWCFConfig.ini";
		_Session = new WSCWCF_SessionEnvironment();
		_Session.SessionVariable.Add("WSC.SqlToApply", "");
	}

	private string getClientIP()
	{
		string result;
		try
		{
			OperationContext current = OperationContext.Current;
			MessageProperties incomingMessageProperties = current.IncomingMessageProperties;
			object obj = incomingMessageProperties[RemoteEndpointMessageProperty.Name];
			RemoteEndpointMessageProperty val = (RemoteEndpointMessageProperty)((obj is RemoteEndpointMessageProperty) ? obj : null);
			result = val.Address;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected string getSessionId()
	{
		string result;
		try
		{
			OperationContext current = OperationContext.Current;
			result = ((current.SessionId != null) ? current.SessionId : Guid.NewGuid().ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = Guid.NewGuid().ToString();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected abstract FXRETURN AutenticazioneUtente(string sUtente, string sPassword, ref string rsmess);

	protected abstract FXRETURN LoginComplete(ref string rsMess);

	protected abstract FXRETURN LogoutComplete(ref string rsMess);

	protected abstract string ServiceName();

	public abstract bool LogIn(string User, string Password, ref string rsMess);

	public abstract bool LogOut(ref string rsmess);

	public abstract bool isAuthenticate();

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

	public virtual string GetVersion()
	{
		return Assembly.GetAssembly(GetType()).GetName().Version.ToString();
	}

	public virtual string TestPing(string sStringa)
	{
		return "RISPOSTA: " + sStringa + " - " + DateTime.Now;
	}

	protected virtual FXRETURN LogoutBegin(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
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
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		FXRETURN result;
		try
		{
			rsmess = "";
			if (_ServiceInitialized)
			{
				goto IL_012b;
			}
			_Session.SessionID = getSessionId();
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
					text = ClientHostname;
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
					text = ClientIp;
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
					SessionEnvironment.Init();
					goto IL_012b;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_012b:
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

	protected int getIncomingBytes()
	{
		int result;
		try
		{
			OperationContext current = OperationContext.Current;
			MessageProperties incomingMessageProperties = current.IncomingMessageProperties;
			current.RequestContext.RequestMessage.ToString();
			object obj = incomingMessageProperties["httpRequest"];
			HttpRequestMessageProperty val = (HttpRequestMessageProperty)((obj is HttpRequestMessageProperty) ? obj : null);
			result = Conversions.ToInteger(val.Headers["Content-Length"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected string getIncomingMessage()
	{
		string result;
		try
		{
			OperationContext current = OperationContext.Current;
			result = current.RequestContext.RequestMessage.ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected FXRETURN EliminaFileVecchi(string sDir, DateTime sDataDiRiferimento, string sPattern, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				if (Directory.Exists(sDir))
				{
					string[] files = Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories);
					if (files.Length != 0)
					{
						int num = files.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (DateTime.Compare(File.GetLastWriteTime(files[i]), sDataDiRiferimento) >= 0)
							{
								continue;
							}
							try
							{
								if (!files[i].ToUpper().EndsWith("IDLE.TXT"))
								{
									File.Delete(files[i]);
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				rsMess = ex4.Message;
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
			}
			return result;
		}
	}

	protected FXRETURN EliminaDirVecchie(string sDir, DateTime sDataDiRiferimento, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				string[] directories = Directory.GetDirectories(sDir, "*", SearchOption.TopDirectoryOnly);
				if (directories.Length != 0)
				{
					int num = directories.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(new DirectoryInfo(directories[i]).Name, Strings.Format((object)sDataDiRiferimento, "yyyyMMdd"), false) < 0)
						{
							try
							{
								Directory.Delete(directories[i], recursive: true);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
					}
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				rsMess = ex4.Message;
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
			}
			return result;
		}
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

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_Session.Destroy();
			try
			{
				_Session.DbConn.Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				_Session.DbLog.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
