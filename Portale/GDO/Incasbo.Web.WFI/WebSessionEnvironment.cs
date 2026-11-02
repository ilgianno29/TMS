using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.SessionState;
using Incasbo.Api.App;
using Incasbo.Api.Statistics;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI.ObjectManager;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public abstract class WebSessionEnvironment : AppSessionEnvironment
{
	protected IboWebUser _objWebUser;

	protected IboWebUser _objWebLoginUser;

	protected IboMenuManagerAbstract _objMenuManager;

	protected IboGridInfoList _GridInfoList;

	protected IboGridConfigList _GridConfigList;

	protected IboWebToolbarInfoList _ToolbarInfoList;

	protected ObjectManagerFactory _ObjectManagerFactory;

	protected StringCollection _FileToDelete;

	protected WFIUserMessage _UserMessage;

	protected WFIUserSelect _UserSelect;

	protected WFIPopupFormInfo _PopupFormInfo;

	protected WFIProgressbarMessage _ProgressbarMessage;

	protected InternalPageDetailViewMessage _UserInternalPageDetailViewMessage;

	protected int _ScreenResolutionX;

	protected int _ScreenResolutionY;

	protected int _WindowWidth;

	protected int _WindowHeight;

	protected IboSessionVariables _SessionVariables;

	protected DataTable _LastGridDataTable;

	protected AppDefault _AppDefault;

	protected AppParams _AppParams;

	protected Hashtable _PersistentSessionVariables;

	protected string _AppApplicationRoot;

	protected string _WebApplicationPath;

	protected string _AppApplicationServerName;

	protected string _AppApplicationRootUrl;

	public IboWebToolbarInfoList ToolbarInfoList => _ToolbarInfoList;

	public IboGridInfoList GridInfoList => _GridInfoList;

	public IboGridConfigList GridConfigList => _GridConfigList;

	public IboWebUser WebUser
	{
		get
		{
			if (_objWebUser == null)
			{
				return _objWebLoginUser;
			}
			return _objWebUser;
		}
	}

	public IboWebUser WebLoginUser => _objWebLoginUser;

	public ObjectManagerFactory ObjManagerFactory => _ObjectManagerFactory;

	public WFIUserMessage UserMessage => _UserMessage;

	public InternalPageDetailViewMessage UserInternalPageDetailViewMessage => _UserInternalPageDetailViewMessage;

	public WFIUserSelect UserSelect => _UserSelect;

	public WFIPopupFormInfo PopupFormInfo
	{
		get
		{
			return _PopupFormInfo;
		}
		set
		{
			_PopupFormInfo = value;
		}
	}

	public WFIProgressbarMessage ProgressbarInfo
	{
		get
		{
			return _ProgressbarMessage;
		}
		set
		{
			_ProgressbarMessage = value;
		}
	}

	public int ScreenResolutionX
	{
		get
		{
			return _ScreenResolutionX;
		}
		set
		{
			_ScreenResolutionX = value;
		}
	}

	public int ScreenResolutionY
	{
		get
		{
			return _ScreenResolutionY;
		}
		set
		{
			_ScreenResolutionY = value;
		}
	}

	public int WindowHeight
	{
		get
		{
			return _WindowHeight;
		}
		set
		{
			_WindowHeight = value;
		}
	}

	public int WindowWidth
	{
		get
		{
			return _WindowWidth;
		}
		set
		{
			_WindowWidth = value;
		}
	}

	public IboSessionVariables SessionVariables => _SessionVariables;

	public Hashtable PersistentSessionVariables => _PersistentSessionVariables;

	public DataTable LastGridDataTable
	{
		get
		{
			return _LastGridDataTable;
		}
		set
		{
			_LastGridDataTable = value;
		}
	}

	public AppDefault AppDefault => _AppDefault;

	public AppParams AppParams => _AppParams;

	public string ErrorMessage { get; set; }

	public string ErrorMessageTitle { get; set; }

	public string ErrorMessageCallerPage { get; set; }

	public WFIPage ActualWfiPageObject { get; set; }

	public WFIConfig WFIConfig { get; set; }

	public Queue<string> LastWfiPages => (Queue<string>)HttpContext.Current.Session["LastWfiPages"];

	public string WFIUserAgent
	{
		get
		{
			string text = HttpContext.Current.Request.UserAgent.ToUpper();
			string text2 = "";
			string text3 = "";
			checked
			{
				if (text.Contains("MSIE"))
				{
					text3 = "MSIE";
					text2 = Strings.Mid(text, text.IndexOf("MSIE") + 6).Split(new char[1] { ' ' })[0].Replace(";", "");
				}
				else if (text.Contains("EDGE"))
				{
					text3 = "EDGE";
					text2 = Strings.Mid(text, text.IndexOf("EDGE") + 6).Split(new char[1] { ' ' })[0];
				}
				else if (text.Contains("OPR"))
				{
					text3 = "OPERA";
					text2 = Strings.Mid(text, text.IndexOf("OPR") + 5).Split(new char[1] { ' ' })[0];
				}
				else if (text.Contains("CHROME"))
				{
					text3 = "CHROME";
					text2 = Strings.Mid(text, text.IndexOf("CHROME") + 8).Split(new char[1] { ' ' })[0];
				}
				else if (text.Contains("FIREFOX"))
				{
					text3 = "FIREFOX";
					text2 = Strings.Mid(text, text.IndexOf("FIREFOX") + 9).Split(new char[1] { ' ' })[0];
				}
				else if (text.Contains("SAFARI"))
				{
					text3 = "SAFARI";
					text2 = Strings.Mid(text, text.IndexOf("SAFARI") + 8).Split(new char[1] { ' ' })[0];
				}
				else if (text.Contains("Trident/7.0; rv:11.0".ToUpper()))
				{
					text3 = "MSIE";
					text2 = Strings.Mid(text, text.IndexOf("RV:") + 4).Split(new char[1] { ' ' })[0].Replace(")", "");
				}
				else
				{
					text3 = "UNKNOW";
					text2 = "0";
				}
				return text3 + " " + text2;
			}
		}
	}

	public string WFIUserAgentType
	{
		get
		{
			string text = HttpContext.Current.Request.UserAgent.ToUpper();
			string text2 = "";
			if (text.Contains("MSIE"))
			{
				return "MSIE";
			}
			if (text.Contains("EDGE"))
			{
				return "EDGE";
			}
			if (text.Contains("OPR"))
			{
				return "OPERA";
			}
			if (text.Contains("CHROME"))
			{
				return "CHROME";
			}
			if (text.Contains("FIREFOX"))
			{
				return "FIREFOX";
			}
			if (text.Contains("SAFARI"))
			{
				return "SAFARI";
			}
			if (text.Contains("Trident/7.0; rv:11.0".ToUpper()))
			{
				return "MSIE";
			}
			return "UNKNOW";
		}
	}

	public HttpSessionState Session { get; set; }

	public HttpApplicationState Application { get; set; }

	public virtual bool IsInDebugMode
	{
		get
		{
			bool result = false;
			try
			{
				if (WFIConfig.DebugConfig.DebugMode & ((Operators.CompareString(WFIConfig.DebugConfig.UserDebug.ToUpper().Trim(), WebUser.WebUserInfo.Codice.ToUpper(), false) == 0) | (Operators.CompareString(WFIConfig.DebugConfig.UserDebug.ToUpper().Trim(), "", false) == 0)))
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public override string AppApplicationRoot
	{
		get
		{
			if (_AppApplicationRoot == null)
			{
				_AppApplicationRoot = HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"].ToString();
			}
			return _AppApplicationRoot;
		}
	}

	public virtual string WebApplicationPath
	{
		get
		{
			if (_WebApplicationPath == null)
			{
				_WebApplicationPath = HttpContext.Current.Request.ApplicationPath;
			}
			return _WebApplicationPath;
		}
	}

	public override string AppApplicationServerName
	{
		get
		{
			if (_AppApplicationServerName == null)
			{
				_AppApplicationServerName = HttpContext.Current.Request.ServerVariables["SERVER_NAME"].ToString();
			}
			return _AppApplicationServerName;
		}
	}

	public string AppApplicationRootUrl
	{
		get
		{
			if (_AppApplicationRootUrl == null)
			{
				string originalString = HttpContext.Current.Request.Url.OriginalString;
				string localPath = HttpContext.Current.Request.Url.LocalPath;
				string query = HttpContext.Current.Request.Url.Query;
				string text = Strings.Replace(Strings.Replace(originalString, localPath, "", 1, -1, (CompareMethod)0), query, "", 1, -1, (CompareMethod)0) + WebApplicationPath;
				if (Operators.CompareString(Strings.Right(text, 1), "/", false) != 0)
				{
					text += "/";
				}
				_AppApplicationRootUrl = text;
			}
			return _AppApplicationRootUrl;
		}
	}

	public override string AppApplicationTitle => WFIConfig.ApplicationConfig.TitoloApplicazione;

	public string WebApplicationRoot => AppApplicationRoot;

	public string WebApplicationWFIRoot => AppApplicationRoot + "WFI\\";

	public string WebApplicationServerName => AppApplicationServerName;

	public string WebApplicationDownloadDir => WebApplicationRoot + "Download\\";

	public string WebApplicationIniConfigDir => WebApplicationRoot + "IniConfig\\";

	public string WebApplicationIniConfigFile { get; set; }

	public string WebApplicationDBConfigFile { get; set; }

	public string WebApplicationWFIIniConfigDir => WebApplicationWFIRoot + "IniConfig\\";

	public string WebApplicationCustomDir => WebApplicationWFIRoot + "Custom\\";

	public string WebSessionId
	{
		get
		{
			string result;
			try
			{
				result = HttpContext.Current.Session.SessionID;
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

	public string WebApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	public string WebApplicationTitle => AppApplicationTitle;

	public string WebSoftwareModuleTitle => WFIConfig.ApplicationConfig.TitoloModuloSoftware;

	public string WebSoftwareModuleTitleAcronym => WFIConfig.ApplicationConfig.TitoloModuloSoftwareAcronimo;

	public Version WebApplicationVersion => Assembly.GetExecutingAssembly().GetName().Version;

	public string WebApplicationLog => WebApplicationLogDir + WebApplicationName + ".LOG";

	public string WebApplicationLogDir => WebApplicationRoot + "Log\\";

	public string WebApplicationLabelDir => AppApplicationLabelDir;

	public string WebApplicationLabelCustomDir => AppApplicationLabelCustomDir;

	public string WebApplicationErr => WebApplicationRoot + "Log\\" + WebApplicationName + ".ERR";

	public DataTable FunctionListDatatable => _objMenuManager.FunctionListDatatable;

	public WebSessionEnvironment()
	{
		_GridInfoList = null;
		_GridConfigList = null;
		_ToolbarInfoList = null;
		_ObjectManagerFactory = null;
		_SessionVariables = new IboSessionVariables();
		_LastGridDataTable = null;
		_AppDefault = null;
		_AppParams = null;
		_PersistentSessionVariables = new Hashtable(StringComparer.OrdinalIgnoreCase);
		_AppApplicationRoot = null;
		_WebApplicationPath = null;
		_AppApplicationServerName = null;
		_AppApplicationRootUrl = null;
		ErrorMessage = "";
		ErrorMessageTitle = "";
		ErrorMessageCallerPage = "";
		ActualWfiPageObject = null;
		WFIConfig = new WFIConfig();
		WebApplicationIniConfigFile = "WFIConfig<%CFG%>.ini";
		WebApplicationDBConfigFile = "DBConfig<%CFG%>.ini";
		_FileToDelete = new StringCollection();
		_UserMessage = new WFIUserMessage();
		_UserSelect = new WFIUserSelect();
		_PopupFormInfo = new WFIPopupFormInfo();
		_ProgressbarMessage = new WFIProgressbarMessage();
		_UserInternalPageDetailViewMessage = new InternalPageDetailViewMessage();
	}

	protected override FXRETURN InitTranslator(string sLinguaUtente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val2 = base.InitTranslator(sLinguaUtente, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_Translator.Attivo = WFIConfig.TranslationConfig.TranslationIsActive;
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

	protected override FXRETURN InitUser(string sUsername, string sPassword, string sIdentityUser, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Invalid comparison between Unknown and I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			WFIConfig wfiConfigTmp = WFIConfig; // VB passava la proprieta' ByRef con copia di ritorno
			_objWebLoginUser = new IboWebUser(sUsername, ref _objCallStackHandler, ref _objLogHandling, ref _objDbConnection, ref _objParametrica, ref wfiConfigTmp);
			WFIConfig = wfiConfigTmp;
			if ((int)WebLoginUser.Load(ref rsMess) <= 0)
			{
				AppLanguage = WebUser.WebUserInfo.Lingua;
				if (Operators.CompareString(AppLanguage, "", false) == 0)
				{
					AppLanguage = "IT";
				}
				val2 = InitTranslator(AppLanguage, ref rsMess);
				if ((int)val2 <= 0 && (int)WebLoginUser.Check(sPassword, ref rsMess) <= 0)
				{
					if (WebLoginUser.WebUserInfo.Authenticated != 0 && WebLoginUser.WebUserInfo.Authenticated != IboWebUserInfo.AuthenticationState.PasswordExpired)
					{
						rsMess = Translator.TranslateMessage("XXX", "Impossibile autenticate l'Utente {0}. {1}.", new string[2]
						{
							sUsername,
							WebLoginUser.WebUserInfo.AuthenticationError
						});
					}
					else
					{
						if (!((Operators.CompareString(sIdentityUser, "", false) != 0) & (Operators.CompareString(sIdentityUser, sUsername, false) != 0)))
						{
							goto IL_02a7;
						}
						if (!WFIConfig.LoginManagerConfig.EnableIdentityChange)
						{
							rsMess = _Translator.TranslateMessage("XXX", "Il Sistema di cambiamento dell'identità non è attivo", new string[0]);
						}
						else if (!WFIConfig.LoginManagerConfig.IdentityChangeUserList.Contains(sUsername))
						{
							rsMess = _Translator.TranslateMessage("XXX", "Il Sistema di cambiamento dell'identità non è attivo per l'utente {0}", new string[1] { sUsername });
						}
						else
						{
							WFIConfig wfiConfigTmp2 = WFIConfig; // VB passava la proprieta' ByRef con copia di ritorno
							_objWebUser = new IboWebUser(sIdentityUser, ref _objCallStackHandler, ref _objLogHandling, ref _objDbConnection, ref _objParametrica, ref wfiConfigTmp2);
							WFIConfig = wfiConfigTmp2;
							if ((int)_objWebUser.Load(ref rsMess) <= 0)
							{
								_objWebUser.WebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.Authenticated;
								AppLanguage = WebUser.WebUserInfo.Lingua;
								if (Operators.CompareString(AppLanguage, "", false) == 0)
								{
									AppLanguage = "IT";
								}
								val2 = InitTranslator(AppLanguage, ref rsMess);
								if ((int)val2 <= 0)
								{
									goto IL_02a7;
								}
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_02a7:
			_AppUser = WebUser.WebUserInfo.Codice;
			_AppUserGroup = WebUser.WebUserInfo.Gruppo;
			_AppFiliale = WebUser.WebUserInfo.Filiale;
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

	protected FXRETURN InitMenu(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			WebSessionEnvironment rObjSessionEnvironment = this;
			_objMenuManager = IboMenuManagerAbstract.GetMenuManagerInstance(ref rObjSessionEnvironment);
			if ((int)_objMenuManager.LoadFromDatabase(ref rsMess) <= 0)
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

	protected FXRETURN InitGridInfoList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfoList.IboGridInfoListMode iboGridInfoListMode = IboGridInfoList.IboGridInfoListMode.Standard;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			iboGridInfoListMode = IboGridInfoList.IboGridInfoListMode.Standard;
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IncasTranslator translator = ref _Translator;
			IboWebUserInfo rObjWebUserInfo = WebUser.WebUserInfo;
			_GridInfoList = new IboGridInfoList(ref objCallStackHandler, ref objLogHandling, ref objDbConnection, ref translator, ref rObjWebUserInfo, iboGridInfoListMode);
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

	protected FXRETURN InitGridConfigList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IncasTranslator translator = ref _Translator;
			IboWebUserInfo rObjWebUserInfo = WebUser.WebUserInfo;
			_GridConfigList = new IboGridConfigList(ref objCallStackHandler, ref objLogHandling, ref objDbConnection, ref translator, ref rObjWebUserInfo);
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

	protected FXRETURN InitToolbarInfoList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IncasTranslator translator = ref _Translator;
			IboWebUserInfo rObjWebUserInfo = WebUser.WebUserInfo;
			_ToolbarInfoList = new IboWebToolbarInfoList(ref objCallStackHandler, ref objLogHandling, ref objDbConnection, ref translator, ref rObjWebUserInfo, WFIConfig.DebugConfig.ConfigMode, WFIConfig.DebugConfig.ConfigUser);
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

	protected FXRETURN InitObjectManagerFactory(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			ref IboAppCallStackHandling objCallStackHandler = ref _objCallStackHandler;
			ref IboAppLogHandling objLogHandling = ref _objLogHandling;
			ref DBConnection objDbConnection = ref _objDbConnection;
			ref IncasTranslator translator = ref _Translator;
			IboWebUserInfo rObjWebUserInfo = WebUser.WebUserInfo;
			_ObjectManagerFactory = new ObjectManagerFactory(ref objCallStackHandler, ref objLogHandling, ref objDbConnection, ref translator, ref rObjWebUserInfo);
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

	protected FXRETURN InitUserApplicationVariables(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			HttpContext.Current.Application.Lock();
			if (!ApplicationVariables().ContainsKey(AppUser))
			{
				ApplicationVariables().Add(AppUser, new IboDictionaryCollection<string, object>());
			}
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
			HttpContext.Current.Application.UnLock();
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN InitApplicationVariables(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			HttpContext.Current.Application.Lock();
			if (!ApplicationVariables().ContainsKey("WFIAPP"))
			{
				ApplicationVariables().Add("WFIAPP", new IboDictionaryCollection<string, object>());
				AppApplicationVariables().Add("LOGGEDUSERS", new Dictionary<string, int>());
				AppApplicationVariables().Add("ASYNCQUERY", new StringCollection());
				AppApplicationVariables().Add("DBCONN", (object)(DBConnection)DbConn.Clone());
			}
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
			HttpContext.Current.Application.UnLock();
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public IboApplicationVariables ApplicationVariables()
	{
		if (HttpContext.Current != null)
		{
			return (IboApplicationVariables)HttpContext.Current.Application["WFIApplicationVariables"];
		}
		return (IboApplicationVariables)Application["WFIApplicationVariables"];
	}

	protected abstract void CreateAppDefault();

	protected abstract void CreateAppParams();

	public override FXRETURN Init(string sUsername, string sPassword, string sUserIdentity, string ConfigFile, string DBConfigFile, string DBConfigSection, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between Unknown and I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Invalid comparison between Unknown and I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Invalid comparison between Unknown and I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			WFIConfig = new WFIConfig();
			WebApplicationIniConfigFile = WebApplicationIniConfigFile.Replace("<%CFG%>", ConfigFile);
			WebApplicationDBConfigFile = WebApplicationDBConfigFile.Replace("<%CFG%>", DBConfigFile);
			WFIConfig.Init(WebApplicationWFIIniConfigDir + WebApplicationIniConfigFile, WebApplicationIniConfigDir + WebApplicationIniConfigFile, WebApplicationWFIIniConfigDir + WebApplicationDBConfigFile, WebApplicationIniConfigDir + WebApplicationDBConfigFile);
			_DebugMode = WFIConfig.DebugConfig.DebugMode;
			_DebugUser = WFIConfig.DebugConfig.UserDebug;
			if (Operators.CompareString(DBConfigSection, "", false) != 0 && WFIConfig.DBConnectionListConfig.ContainsKey(DBConfigSection))
			{
				WFIConfig.DefaultDBConnectionConfig = WFIConfig.DBConnectionListConfig[DBConfigSection];
			}
			_DbConnectionConfig = WFIConfig.DefaultDBConnectionConfig;
			val2 = base.Init(sUsername, sPassword, sUserIdentity, ConfigFile, DBConfigFile, DBConfigSection, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = InitMenu(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = InitGridInfoList(ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = InitGridConfigList(ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = InitToolbarInfoList(ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								val2 = InitObjectManagerFactory(ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									val2 = InitApplicationVariables(ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										val2 = InitUserApplicationVariables(ref rsMess);
										if ((int)val2 > 0)
										{
											val = val2;
										}
										else
										{
											checked
											{
												try
												{
													Dictionary<string, int> dictionary = (Dictionary<string, int>)AppApplicationVariables()["LOGGEDUSERS"];
													HttpContext.Current.Application.Lock();
													if (dictionary.ContainsKey(sUsername))
													{
														dictionary[sUsername]++;
													}
													else
													{
														dictionary.Add(sUsername, 1);
													}
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													ProjectData.ClearProjectError();
												}
												finally
												{
													HttpContext.Current.Application.UnLock();
												}
												CreateAppDefault();
												CreateAppParams();
												_objLabel = new IboLabel(CreateApiContext());
												_objLabel.LoadConfig(WebApplicationLabelDir, WebApplicationLabelCustomDir, ref rsMess);
											}
											if ((int)val2 > 0)
											{
												val = val2;
											}
											else
											{
												_StatisticManager = new StatisticsManager(CreateApiContext());
												val2 = _StatisticManager.Init(ref rsMess);
												if ((int)val2 > 0)
												{
													val = val2;
												}
												else
												{
													string appApplicationRootUrl = AppApplicationRootUrl;
													val = (FXRETURN)0;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			val = _objLogHandling.HandleError(ref ex4, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	public virtual AppApiContext CreateApiContext(bool WithCloneConnection = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		AppApiContext val = new AppApiContext();
		if (WithCloneConnection)
		{
			val.DbConn = (DBConnection)DbConn.Clone();
			DBConnection dbConn = val.DbConn;
			string text = "";
			dbConn.OpenConnection(ref text);
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
		val.User = WebUser.WebUserInfo.Codice;
		val.Group = WebUser.WebUserInfo.Gruppo;
		val.Organization = WebUser.WebUserInfo.Organizzazione;
		val.AppDefault = AppDefault;
		val.AppParams = AppParams;
		val.AppName = WebApplicationName;
		val.AppSessionId = WebSessionId;
		val.ContextVariables = new Dictionary<string, object>();
		val.IsDebug = DebugMode;
		val.DebugUser = DebugUser;
		val.OrganizationType = WebUser.WebUserInfo.OrganizzazioneTipoSoggetto;
		val.OrganizationInternalExternal = WebUser.WebUserInfo.OrganizzazioneInternaEsterna;
		val.ApplicationRootDir = WebApplicationRoot;
		val.DownloadDir = "Download\\";
		val.LogDir = "Log\\";
		if (IsInDebugMode)
		{
			val.PerformanceLog = base.PerformanceLog;
		}
		CRWConfiguration val2 = new CRWConfiguration();
		val2.DB_Database = WFIConfig.DefaultDBConnectionConfig.DB_Database;
		val2.DB_Password = WFIConfig.DefaultDBConnectionConfig.DB_Password;
		val2.DB_Provider = WFIConfig.DefaultDBConnectionConfig.DB_Provider;
		val2.DB_Server = WFIConfig.DefaultDBConnectionConfig.DB_Server;
		if (Operators.CompareString(WFIConfig.DefaultDBConnectionConfig.DB_ServerType, "ORCL", false) == 0)
		{
			val2.DB_ServerType = (eServerType)1;
		}
		else if (Operators.CompareString(WFIConfig.DefaultDBConnectionConfig.DB_ServerType, "SQL", false) == 0)
		{
			val2.DB_ServerType = (eServerType)0;
		}
		val2.DB_TimeOut = WFIConfig.DefaultDBConnectionConfig.DB_TimeOut;
		val2.DB_UseIntegratedSecurity = WFIConfig.DefaultDBConnectionConfig.DB_UseIntegratedSecurity;
		val2.DB_Username = WFIConfig.DefaultDBConnectionConfig.DB_Username;
		val2.DB_Sistema = WFIConfig.DefaultDBConnectionConfig.DB_Description;
		val.CRWConfig = val2;
		return val;
	}

	public FXRETURN ClearTemporaryFiles(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			StringEnumerator enumerator = _FileToDelete.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					File.Delete(current);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			val = _objLogHandling.HandleError(ref ex4, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN AddFileToDelete(string sNomeFile, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			_FileToDelete.Add(sNomeFile);
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

	public override FXRETURN StopEnvironment(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val2 = base.StopEnvironment(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = CloseDBConnection(ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
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
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public override FXRETURN StartEnvironment(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val2 = base.StartEnvironment(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = InitDBConnection(ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
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
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN StartEnvironment(ref IboWebMenu objMenu, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val2 = StartEnvironment(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = _objMenuManager.BuildMenu(ref objMenu, ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
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
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN StartEnvironment(ref IboWebMenuTlk objMenu, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			val2 = StartEnvironment(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = _objMenuManager.BuildMenu(ref objMenu, ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
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
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN BuildMenu(ref IboWebMenu objMenu, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return _objMenuManager.BuildMenu(ref objMenu, ref rsMess);
	}

	public FXRETURN BuildMenu(ref IboWebMenuTlk objMenu, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return _objMenuManager.BuildMenu(ref objMenu, ref rsMess);
	}

	public FXRETURN BuildDesktop(string sParent, ref DataTable dtDesktopItem, ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return _objMenuManager.BuildDesktop(sParent, ref dtDesktopItem, ref rsMess);
	}

	public FXRETURN UpdateMenuUsage(string sVoceMenu, ref string rsMess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return _objMenuManager.UpdateMenuUsage(sVoceMenu, WebUser.WebUserInfo.Codice, ref rsMess);
	}

	public IboDictionaryCollection<string, object> UserApplicationVariables()
	{
		if (ApplicationVariables().ContainsKey(AppUser))
		{
			return ApplicationVariables()[AppUser];
		}
		return null;
	}

	public IboDictionaryCollection<string, object> AppApplicationVariables()
	{
		if (ApplicationVariables().ContainsKey("WFIAPP"))
		{
			return ApplicationVariables()["WFIAPP"];
		}
		return null;
	}

	public void AddAsyncQueryToApply(string sQuery)
	{
		if (AppApplicationVariables()["ASYNCQUERY"] is StringCollection stringCollection)
		{
			HttpContext.Current.Application.Lock();
			if (!stringCollection.Contains(sQuery))
			{
				stringCollection.Add(sQuery);
			}
			HttpContext.Current.Application.UnLock();
		}
	}

	public FXRETURN ReInitTranslator(string sLanguage, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_objCallStackHandler.CallStackAdd();
			AppLanguage = sLanguage;
			if (Operators.CompareString(AppLanguage, "", false) == 0)
			{
				AppLanguage = WebUser.WebUserInfo.Lingua;
			}
			val2 = InitTranslator(AppLanguage, ref rsMess);
			if ((int)val2 <= 0)
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

	protected override void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_objMenuManager = null;
			_objWebUser = null;
			_objWebLoginUser = null;
			_ToolbarInfoList = null;
			_GridInfoList = null;
			Session = null;
			Application = null;
			base.Dispose(disposing);
		}
		disposedValue = true;
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		try
		{
			if (IsInDebugMode)
			{
				((LogFileFlushed)base.PerformanceLog).Write(sMessaggioLog);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PerformanceLogFlush(string sMessaggioLog)
	{
		try
		{
			PerformanceLogAppend(sMessaggioLog);
			if (IsInDebugMode)
			{
				((LogFileFlushed)base.PerformanceLog).Flush();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PerformanceLogStopWatch()
	{
		if (IsInDebugMode)
		{
			base.PerformanceLog.StopWatch();
		}
	}

	public void PerformanceLogReset()
	{
		if (IsInDebugMode)
		{
			PerformanceLogStopWatch();
			_PerformanceLog = null;
		}
	}
}
