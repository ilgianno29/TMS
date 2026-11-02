using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.Statistics;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public abstract class AppSessionEnvironment : IDisposable
{
	protected bool disposedValue;

	protected IboAppCallStackHandling _objCallStackHandler;

	protected string _AppUser;

	protected string _AppUserGroup;

	protected string _AppFiliale;

	protected string _AppLanguage;

	protected DBConnection _objDbConnection;

	protected IboAppLogHandling _objLogHandling;

	protected bool _Initialized;

	protected IncasTranslator _Translator;

	protected IboWebParam _objParametrica;

	protected bool _DebugMode;

	protected string _DebugUser;

	protected PerformanceLog _PerformanceLog;

	protected IboLabel _objLabel;

	protected WFIDbConnectionConfig _DbConnectionConfig;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjTag1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjTag2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjTag3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjTag4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ObjTag5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _IFrameObjTag;

	protected StatisticsManager _StatisticManager;

	public virtual IboLabel ObjLabel
	{
		get
		{
			return _objLabel;
		}
		set
		{
			_objLabel = value;
		}
	}

	public virtual IboAppLogHandling LogHandling => _objLogHandling;

	public virtual string AppUser => _AppUser;

	public virtual string AppUserGroup => _AppUserGroup;

	public virtual string AppFiliale
	{
		get
		{
			return _AppFiliale;
		}
		set
		{
			_AppFiliale = value;
		}
	}

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

	public virtual DBConnection DbConn => _objDbConnection;

	public virtual IncasTranslator Translator => _Translator;

	public virtual IboWebParam Parametrica => _objParametrica;

	public virtual bool DebugMode => _DebugMode;

	public virtual string DebugUser => _DebugUser;

	public virtual string Filiale
	{
		get
		{
			return _AppFiliale;
		}
		set
		{
			_AppFiliale = value;
		}
	}

	public object ObjTag1
	{
		[CompilerGenerated]
		get
		{
			return _ObjTag1;
		}
		[CompilerGenerated]
		set
		{
			_ObjTag1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag2
	{
		[CompilerGenerated]
		get
		{
			return _ObjTag2;
		}
		[CompilerGenerated]
		set
		{
			_ObjTag2 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag3
	{
		[CompilerGenerated]
		get
		{
			return _ObjTag3;
		}
		[CompilerGenerated]
		set
		{
			_ObjTag3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag4
	{
		[CompilerGenerated]
		get
		{
			return _ObjTag4;
		}
		[CompilerGenerated]
		set
		{
			_ObjTag4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjTag5
	{
		[CompilerGenerated]
		get
		{
			return _ObjTag5;
		}
		[CompilerGenerated]
		set
		{
			_ObjTag5 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string IFrameTag { get; set; }

	public object IFrameObjTag
	{
		[CompilerGenerated]
		get
		{
			return _IFrameObjTag;
		}
		[CompilerGenerated]
		set
		{
			_IFrameObjTag = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public IframeInfoList IframeInfoList { get; set; }

	public DateTime LastActivity { get; set; }

	public PerformanceLog PerformanceLog
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			if (_PerformanceLog == null)
			{
				_PerformanceLog = new PerformanceLog(AppApplicationLogDir + "PerformanceLog.txt", 2097152);
			}
			return _PerformanceLog;
		}
	}

	public StatisticsManager StatisticManager => _StatisticManager;

	public abstract string AppApplicationRoot { get; }

	public abstract string AppApplicationServerName { get; }

	public abstract string AppApplicationTitle { get; }

	public virtual string AppApplicationDownloadDir => AppApplicationRoot + "Download\\";

	public virtual string AppApplicationIniConfigDir => AppApplicationRoot + "IniConfig\\";

	public virtual string AppApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	public virtual Version AppApplicationVersion => Assembly.GetExecutingAssembly().GetName().Version;

	public virtual string AppApplicationLog => AppApplicationRoot + "Log\\" + AppApplicationName + ".LOG";

	public virtual string AppApplicationLabelCustomDir => AppApplicationRoot + "Custom\\Labels\\";

	public virtual string AppApplicationLabelDir => AppApplicationRoot + "Labels\\";

	public virtual string AppApplicationLogDir => AppApplicationRoot + "Log\\";

	public virtual string AppApplicationErr => AppApplicationRoot + "Log\\" + AppApplicationName + ".ERR";

	public AppSessionEnvironment()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		disposedValue = false;
		_Initialized = false;
		_DebugMode = false;
		_DebugUser = "";
		ObjTag1 = null;
		ObjTag2 = null;
		ObjTag3 = null;
		ObjTag4 = null;
		ObjTag5 = null;
		IFrameTag = "";
		IFrameObjTag = null;
		IframeInfoList = new IframeInfoList();
		LastActivity = DateAndTime.Now;
		_objCallStackHandler = new IboAppCallStackHandling();
		_objLogHandling = new IboAppLogHandling();
		_Translator = new IncasTranslator("IT");
	}

	protected virtual FXRETURN InitDBConnection(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			if (_objDbConnection != null)
			{
				goto IL_0235;
			}
			eServerType val3 = ((Operators.CompareString(_DbConnectionConfig.DB_ServerType, "SQL", false) == 0) ? ((eServerType)0) : ((Operators.CompareString(_DbConnectionConfig.DB_ServerType, "ORCL", false) == 0) ? ((eServerType)1) : ((Operators.CompareString(_DbConnectionConfig.DB_ServerType, "SQLITE", false) != 0) ? ((eServerType)99) : ((eServerType)3))));
			eProviderType val4;
			if (Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "ODBC", false) == 0)
			{
				val4 = (eProviderType)1;
			}
			else if (Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "OLEDB", false) == 0)
			{
				val4 = (eProviderType)0;
			}
			else if (Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "SQLCLIENT", false) == 0)
			{
				val4 = (eProviderType)2;
			}
			else if (Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "SQLITECLIENT", false) != 0)
			{
				val4 = ((Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "MSORACLECLIENT", false) == 0) ? ((eProviderType)3) : ((Operators.CompareString(_DbConnectionConfig.DB_ProviderType, "ORACLECLIENT", false) != 0) ? ((eProviderType)0) : ((eProviderType)4)));
			}
			else
			{
				val4 = (eProviderType)5;
				_DbConnectionConfig.DB_Database = _DbConnectionConfig.DB_Database.Replace("%HOME%", AppApplicationRoot);
			}
			_objDbConnection = new DBConnection(val4, _DbConnectionConfig.DB_Provider, _DbConnectionConfig.DB_Server, val3, _DbConnectionConfig.DB_Database, _DbConnectionConfig.DB_Username, _DbConnectionConfig.DB_Password, _DbConnectionConfig.DB_UseIntegratedSecurity, _DbConnectionConfig.DB_TimeOut, _objCallStackHandler, ref _objLogHandling, ref _Translator);
			if ((int)_objDbConnection.OpenConnection(ref rsMess) <= 0)
			{
				goto IL_0235;
			}
			goto end_IL_0005;
			IL_0235:
			val = (FXRETURN)0;
			end_IL_0005:;
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			if ((int)_objDbConnection.CloseConnection(ref rsMess) <= 0)
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

	protected virtual FXRETURN InitTranslator(string sLinguaUtente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			_Translator.Language = sLinguaUtente;
			_Translator.ClearTranslatableItem();
			if ((Operators.CompareString(sLinguaUtente, "IT", false) == 0) | (Operators.CompareString(sLinguaUtente, "ITA", false) == 0))
			{
				goto IL_012f;
			}
			text = "SELECT * FROM WFI_TranslatorDictionary WHERE Attivo='S' AND Lingua='" + sLinguaUtente + "'";
			val2 = DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 <= 0)
			{
				foreach (DataRow row in dataTable.Rows)
				{
					_Translator.AddTranslatableItem(row["Lingua"].ToString(), row["Contesto"].ToString(), row["Testo"].ToString(), row["TestoTradotto"].ToString());
				}
				goto IL_012f;
			}
			val = val2;
			goto end_IL_000e;
			IL_012f:
			_Translator.Debug = _DebugMode;
			val = (FXRETURN)0;
			end_IL_000e:;
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
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected abstract FXRETURN InitUser(string sUsername, string sPassword, string sIdentityUser, ref string rsMess);

	protected virtual FXRETURN InitParam(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			IncasTranslator translator = Translator;
			_objParametrica = new IboWebParam(ref objDbConnection, ref objCallStackHandler, ref objLogHandling, ref translator);
			if ((int)_objParametrica.CaricaParametri(ref rsMess) <= 0)
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

	protected virtual FXRETURN _Init(string sUsername, string sPassword, string sIdentityUser, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			val2 = _objLogHandling.Init(AppApplicationName, sUsername, AppApplicationLog, AppApplicationErr, 2097152L, 2097152L, true, true, ref _objCallStackHandler, ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = InitDBConnection(ref rsMess);
				if ((int)val2 <= 0)
				{
					// Utente gia' autenticato dal cookie: le pagine di login passano TrustedLogin.Token,
					// che IboGenericWebUser.Check riconosce (prima: parola magica fissa + lettura della password)
					val2 = InitUser(sUsername, sPassword, sIdentityUser, ref rsMess);
					if ((int)val2 <= 0)
					{
						val2 = InitParam(ref rsMess);
						if ((int)val2 <= 0)
						{
							val = (FXRETURN)0;
						}
					}
				}
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
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN _AfterInit(string sUsername, string sPassword, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			val2 = LogRisorseAzioneInserisci(AppApplicationName.ToUpper(), "LOGIN", "UI", "", "", ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_Initialized = true;
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
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Init(string sUsername, string sPassword, string sUserIdentity, string ConfigFile, string DBConfigFile, string DBConfigSection, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			if (Operators.CompareString(sUsername, "", false) == 0)
			{
				rsMess = Translator.TranslateMessage("XXX", "Inserire Utente", new string[0]);
			}
			else if (Operators.CompareString(sPassword, "", false) == 0)
			{
				rsMess = Translator.TranslateMessage("XXX", "Inserire Password utente", new string[0]);
			}
			else
			{
				val2 = _Init(sUsername, sPassword, sUserIdentity, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = _AfterInit(sUsername, sPassword, ref rsMess);
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
				}
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
			result = val;
		}
		return result;
	}

	public virtual FXRETURN LogRisorseAzioneInserisci(string sRisorsa, string sAzione, string sModulo, string sInfo1, string sInfo2, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		LogRisorseAzioni logRisorseAzioni = new LogRisorseAzioni();
		FXRETURN result;
		try
		{
			CallStackHandler.CallStackAdd();
			rsMess = "";
			val = logRisorseAzioni.Inserisci(sRisorsa, sAzione, sModulo, sInfo1, sInfo2, ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackHandler.CallStackRemove();
			logRisorseAzioni = null;
		}
		return result;
	}

	public virtual FXRETURN StopEnvironment(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val = (FXRETURN)0;
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

	public virtual FXRETURN StartEnvironment(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val = (FXRETURN)0;
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

	protected virtual void Dispose(bool disposing)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (!disposedValue && disposing)
		{
			_objParametrica = null;
			_objCallStackHandler = null;
			_objLogHandling = null;
			_Translator = null;
			try
			{
				DBConnection objDbConnection = _objDbConnection;
				string text = "";
				objDbConnection.CloseConnection(ref text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				_objDbConnection.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			_objDbConnection = null;
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
