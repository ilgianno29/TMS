using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
#if NETFRAMEWORK
using System.Web;
#endif
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSC;

public class WSC_SessionEnvironment : WSC_AbstractSessionEnvironment
{
	protected IboAppCallStackHandling _objCallStackHandler;

	protected string _AppLanguage;

	protected DBConnection _objDbConnection;

	protected DBConnection _objDbConnectionLog;

	protected IboAppLogHandling _objLogHandling;

	protected bool _Initialized;

	protected IncasTranslator _Translator;

	protected IboWebParam _objParametrica;

	protected bool _DebugMode;

	protected string _DebugUser;

	protected Dictionary<string, object> _SessionVariable;

	protected WSCConfig _WSCConfig;

	protected AppDefault _AppDefault;

	protected AppParams _AppParams;

	protected PerformanceLog _Performance;

	[CompilerGenerated]
	private object _ObjTag1;

	[CompilerGenerated]
	private object _ObjTag2;

	[CompilerGenerated]
	private object _ObjTag3;

	[CompilerGenerated]
	private object _ObjTag4;

	[CompilerGenerated]
	private object _ObjTag5;

	public virtual IboAppLogHandling LogHandling => _objLogHandling;

	public virtual string AppLanguage
	{
		get
		{
			return _AppLanguage;
		}
		set
		{
			_AppLanguage = value;
		}
	}

	public virtual bool Initialized => _Initialized;

	public virtual IboAppCallStackHandling CallStackHandler => _objCallStackHandler;

	public virtual IncasTranslator Translator => _Translator;

	public virtual IboWebParam Parametrica => _objParametrica;

	public virtual AppDefault AppDefault => _AppDefault;

	public virtual AppParams AppParams => _AppParams;

	public ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)AppDefault;

	public ApplicationParams ApplicationParams => (ApplicationParams)(object)AppParams;

	public virtual bool DebugMode => _DebugMode;

	public virtual string DebugUser => _DebugUser;

	public object ObjTag1
	{
		get
		{
			return _ObjTag1;
		}
		set
		{
			_ObjTag1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag2
	{
		get
		{
			return _ObjTag2;
		}
		set
		{
			_ObjTag2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag3
	{
		get
		{
			return _ObjTag3;
		}
		set
		{
			_ObjTag3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag4
	{
		get
		{
			return _ObjTag4;
		}
		set
		{
			_ObjTag4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag5
	{
		get
		{
			return _ObjTag5;
		}
		set
		{
			_ObjTag5 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public DateTime LastActivity { get; set; }

	public Dictionary<string, object> SessionVariable => _SessionVariable;

	public WSCConfig WSCConfig => _WSCConfig;

	public string WebSessionId
	{
		get
		{
			string result;
			try
			{
#if NETFRAMEWORK
				result = HttpContext.Current.Session.SessionID;
#else
				// Nei servizi WCF HttpContext.Current era null: il valore era sempre "" (comportamento invariato)
				result = "";
#endif
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
	}

	protected string WSApplicationRoot => Incasbo.Web.Hosting.WscHosting.ApplicationRoot;

	protected string WSApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	protected string WSApplicationLog => WSApplicationLogDir + WSApplicationName + ".LOG";

	protected string WSApplicationLogDir => WSApplicationRoot + "Log\\";

	protected string WSApplicationIniConfigDir => WSApplicationRoot + "IniConfig\\";

	protected string WSDBConfigFile => WSApplicationIniConfigDir + "DBConfig.ini";

	protected string WSAppConfigFile => WSApplicationIniConfigDir + "WSCConfig.ini";

	protected string WSApplicationErr => WSApplicationLogDir + WSApplicationName + ".ERR";

	public virtual DBConnection DbMain
	{
		get
		{
			return _objDbConnection;
		}
		set
		{
			_objDbConnection = value;
		}
	}

	public virtual DBConnection DbLog
	{
		get
		{
			return _objDbConnectionLog;
		}
		set
		{
			_objDbConnectionLog = value;
		}
	}

	public virtual DBConnection DbConn
	{
		get
		{
			return _objDbConnection;
		}
		set
		{
			_objDbConnection = value;
		}
	}

	public PerformanceLog Performance
	{
		get
		{
			return _Performance;
		}
		set
		{
			_Performance = value;
		}
	}

	public WSC_SessionEnvironment()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		_Initialized = false;
		_DebugMode = false;
		_DebugUser = "";
		_AppDefault = null;
		_AppParams = null;
		_Performance = null;
		object obj = null;
		ObjTag1 = RuntimeHelpers.GetObjectValue(obj);
		obj = null;
		ObjTag2 = RuntimeHelpers.GetObjectValue(obj);
		obj = null;
		ObjTag3 = RuntimeHelpers.GetObjectValue(obj);
		obj = null;
		ObjTag4 = RuntimeHelpers.GetObjectValue(obj);
		obj = null;
		ObjTag5 = RuntimeHelpers.GetObjectValue(obj);
		DateTime now = DateAndTime.Now;
		LastActivity = now;
		_objCallStackHandler = new IboAppCallStackHandling();
		_objLogHandling = new IboAppLogHandling();
		_Translator = new IncasTranslator("IT");
		_SessionVariable = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
		_WSCConfig = new WSCConfig();
	}

	protected virtual void CreateAppDefault()
	{
		if (_AppDefault == null)
		{
			_AppDefault = (AppDefault)(object)new ApplicationDefault(CreateApiContext());
		}
	}

	protected virtual void CreateAppParams()
	{
		if (_AppParams == null)
		{
			_AppParams = (AppParams)(object)new ApplicationParams(CreateApiContext());
		}
	}

	public void Destroy()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		CloseDBConnection(ref rsMess);
		try
		{
			_objDbConnection.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			_objDbConnectionLog.Dispose();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		_objDbConnection = null;
		_objDbConnectionLog = null;
	}

	public void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		InitParam(ref rsMess);
		CreateAppParams();
		CreateAppDefault();
		_DebugMode = WSCConfig.DebugConfig.DebugMode;
		_DebugUser = WSCConfig.DebugConfig.UserDebug;
		_Initialized = true;
	}

	protected virtual FXRETURN InitParam(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			IncasTranslator robjTranslator = Translator;
			_objParametrica = new IboWebParam(ref objDbConnection, ref objCallStackHandler, ref objLogHandling, ref robjTranslator);
			if ((int)_objParametrica.CaricaParametri(ref rsMess) == 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN InitDBConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			WSCDbConnectionConfig defaultDBConnectionConfig = WSCConfig.DefaultDBConnectionConfig;
			if (_objDbConnection != null)
			{
				goto IL_0155;
			}
			DBFormatFunctions.eServerType veServerType = ((Operators.CompareString(defaultDBConnectionConfig.DB_ServerType, "SQL", false) != 0) ? ((Operators.CompareString(defaultDBConnectionConfig.DB_ServerType, "ORCL", false) == 0) ? DBFormatFunctions.eServerType.Oracle : DBFormatFunctions.eServerType.UnKnown) : DBFormatFunctions.eServerType.SQL);
			DBFormatFunctions.eProviderType veProviderType = ((Operators.CompareString(defaultDBConnectionConfig.DB_ProviderType, "ODBC", false) == 0) ? DBFormatFunctions.eProviderType.Odbc : ((Operators.CompareString(defaultDBConnectionConfig.DB_ProviderType, "OLEDB", false) != 0) ? ((Operators.CompareString(defaultDBConnectionConfig.DB_ProviderType, "SQLCLIENT", false) == 0) ? DBFormatFunctions.eProviderType.SqlClient : ((Operators.CompareString(defaultDBConnectionConfig.DB_ProviderType, "MSORACLECLIENT", false) == 0) ? DBFormatFunctions.eProviderType.MSOracleClient : DBFormatFunctions.eProviderType.OleDb)) : DBFormatFunctions.eProviderType.OleDb));
			_objDbConnection = new DBConnection(veProviderType, defaultDBConnectionConfig.DB_Provider, defaultDBConnectionConfig.DB_Server, veServerType, defaultDBConnectionConfig.DB_Database, defaultDBConnectionConfig.DB_Username, defaultDBConnectionConfig.DB_Password, defaultDBConnectionConfig.DB_UseIntegratedSecurity, defaultDBConnectionConfig.DB_TimeOut, _objCallStackHandler, ref _objLogHandling, ref _Translator);
			if ((int)_objDbConnection.OpenConnection(ref rsMess) == 0)
			{
				_objDbConnectionLog = (DBConnection)_objDbConnection.Clone();
				if ((int)_objDbConnectionLog.OpenConnection(ref rsMess) == 0)
				{
					goto IL_0155;
				}
			}
			goto end_IL_0004;
			IL_0155:
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN CloseDBConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			try
			{
				DBConnection objDbConnection = _objDbConnection;
				string rsMess2 = "";
				objDbConnection.CloseConnection(ref rsMess2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				DBConnection objDbConnectionLog = _objDbConnectionLog;
				string rsMess2 = "";
				objDbConnectionLog.CloseConnection(ref rsMess2);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			val = _objLogHandling.HandleError(ref ex6, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual AppApiContext CreateApiContext(bool WithCloneConnection = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		AppApiContext val = new AppApiContext();
		if (WithCloneConnection)
		{
			val.DbConn = (DBConnection)DbConn.Clone();
			DBConnection dbConn = val.DbConn;
			string rsMess = "";
			dbConn.OpenConnection(ref rsMess);
		}
		else
		{
			val.DbConn = DbConn;
		}
		val.CallStackHandler = CallStackHandler;
		val.LogHandler = LogHandling;
		if (WithCloneConnection)
		{
			val.Parametrica = Parametrica.Clone(val.DbConn);
		}
		else
		{
			val.Parametrica = Parametrica;
		}
		val.Translator = Translator;
		val.User = User;
		val.Group = Group;
		val.Organization = Organizzazione;
		val.AppDefault = AppDefault;
		val.AppParams = AppParams;
		val.AppName = WSApplicationName;
		val.AppSessionId = WebSessionId;
		val.IsDebug = DebugMode;
		val.DebugUser = DebugUser;
		val.ApplicationRootDir = WSApplicationRoot;
		val.DownloadDir = "Download\\";
		val.LogDir = "Log\\";
		return val;
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (DebugMode)
		{
			if (_Performance == null)
			{
				_Performance = new PerformanceLog(WSApplicationLogDir + "PerformanceLog.txt", 2097152);
			}
			sMessaggioLog = "IncasWebService".PadRight(50) + sMessaggioLog;
			((LogFileFlushed)_Performance).Write(sMessaggioLog);
		}
	}

	public void PerformanceLogFlush(string sMessaggioLog)
	{
		PerformanceLogAppend(sMessaggioLog);
		if (DebugMode && _Performance != null)
		{
			((LogFileFlushed)_Performance).Flush();
		}
	}

	public void PerformanceLogStopWatch()
	{
		_Performance.StopWatch();
	}

	public virtual void WriteDebugInfo(string Contesto, string Messaggio1, string Messaggio2)
	{
		WriteDebugInfo("", Contesto, Messaggio1, Messaggio2, "", AlwaysInsert: false, "");
	}

	public virtual void WriteDebugInfo(string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (WSCConfig.DebugConfig.DebugMode)
		{
			if (Operators.CompareString(Applicazione, "", false) == 0)
			{
				Applicazione = WSApplicationName;
			}
			if (Operators.CompareString(Contesto, "", false) == 0)
			{
				Contesto = "NO_CONTEXT";
			}
			if (Operators.CompareString(IdSessione, "", false) == 0)
			{
				IdSessione = WebSessionId;
			}
			if (Operators.CompareString(DebugUser, "", false) == 0)
			{
				DebugUser = WSCConfig.DebugConfig.UserDebug;
			}
			AppApiContext obj = CreateApiContext();
			string text = Applicazione;
			string text2 = Contesto;
			string text3 = IdSessione;
			string text4 = DebugUser;
			string text5 = "";
			Incasbo.Api.App.WriteDebugInfo.RunProc(obj, text, text2, Messaggio1, Messaggio2, text3, AlwaysInsert, text4, ref text5);
		}
	}
}
