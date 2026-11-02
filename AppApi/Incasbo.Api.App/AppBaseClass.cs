using System;
using System.Diagnostics;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public abstract class AppBaseClass
{
	protected DBConnection _DbConn;

	protected IncasTranslator _Translator;

	protected IboAppCallStackHandling _CallStackHandler;

	protected IboAppLogHandling _LogHandler;

	protected IboWebParam _Parametrica;

	protected string _User;

	protected string _Group;

	protected string _Organization;

	protected string _OrganizationType;

	protected string _OrganizationInternalExternal;

	protected AppApiContext _ApiContext;

	protected string _LogFileName;

	protected bool _AlwaysInsert;

	public virtual bool IsInDebugMode => _ApiContext.IsInDebugMode;

	public DBConnection DbConn
	{
		get
		{
			return _DbConn;
		}
		set
		{
			_DbConn = value;
		}
	}

	public IncasTranslator Translator
	{
		get
		{
			return _Translator;
		}
		set
		{
			_Translator = value;
		}
	}

	public IboAppCallStackHandling CallStackHandler
	{
		get
		{
			return _CallStackHandler;
		}
		set
		{
			_CallStackHandler = value;
		}
	}

	public IboAppLogHandling LogHandler
	{
		get
		{
			return _LogHandler;
		}
		set
		{
			_LogHandler = value;
		}
	}

	public IboWebParam Parametrica
	{
		get
		{
			return _Parametrica;
		}
		set
		{
			_Parametrica = value;
		}
	}

	protected string CallStack => _CallStackHandler.CallStack;

	public AppBaseClass(AppApiContext objApiContext)
	{
		_DbConn = null;
		_Translator = null;
		_CallStackHandler = null;
		_LogHandler = null;
		_Parametrica = null;
		_User = "";
		_Group = "";
		_Organization = "";
		_OrganizationType = "";
		_OrganizationInternalExternal = "";
		_ApiContext = new AppApiContext();
		_LogFileName = "GenericAppApi_%USER%.log";
		_AlwaysInsert = false;
		Init(objApiContext);
	}

	protected AppBaseClass()
	{
		_DbConn = null;
		_Translator = null;
		_CallStackHandler = null;
		_LogHandler = null;
		_Parametrica = null;
		_User = "";
		_Group = "";
		_Organization = "";
		_OrganizationType = "";
		_OrganizationInternalExternal = "";
		_ApiContext = new AppApiContext();
		_LogFileName = "GenericAppApi_%USER%.log";
		_AlwaysInsert = false;
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		sMessaggioLog = GetType().FullName.PadRight(60) + sMessaggioLog;
		_ApiContext.PerformanceLogAppend(sMessaggioLog);
	}

	public void PerformanceLogFlush(string sMessaggioLog)
	{
		_ApiContext.PerformanceLogFlush(sMessaggioLog);
	}

	public void PerformanceLogStopWatch()
	{
		_ApiContext.PerformanceLogStopWatch();
	}

	public virtual void Init(AppApiContext objApiContext)
	{
		DBConnection objDbConn = objApiContext.DbConn;
		IncasTranslator objTranslator = objApiContext.Translator;
		IboAppCallStackHandling objCallStackHandler = objApiContext.CallStackHandler;
		IboAppLogHandling objLogHandler = objApiContext.LogHandler;
		IboWebParam objParametrica = objApiContext.Parametrica;
		Init(ref objDbConn, ref objTranslator, ref objCallStackHandler, ref objLogHandler, ref objParametrica, objApiContext.User, objApiContext.Group, objApiContext.Organization, objApiContext.OrganizationType, objApiContext.OrganizationInternalExternal);
		objApiContext.Parametrica = objParametrica;
		objApiContext.LogHandler = objLogHandler;
		objApiContext.CallStackHandler = objCallStackHandler;
		objApiContext.Translator = objTranslator;
		objApiContext.DbConn = objDbConn;
		_ApiContext = objApiContext;
	}

	public virtual void Init(ref DBConnection objDbConn, ref IncasTranslator objTranslator, ref IboAppCallStackHandling objCallStackHandler, ref IboAppLogHandling objLogHandler, ref IboWebParam objParametrica, string sAppUser, string sAppGroup, string sAppOrganization, string sAppOrganizationType, string sAppOrganizationInternalExternal)
	{
		_ApiContext.DbConn = objDbConn;
		_ApiContext.Translator = objTranslator;
		_ApiContext.CallStackHandler = objCallStackHandler;
		_ApiContext.LogHandler = objLogHandler;
		_ApiContext.Parametrica = objParametrica;
		_ApiContext.User = sAppUser;
		_ApiContext.Group = sAppGroup;
		_DbConn = objDbConn;
		_Translator = objTranslator;
		_CallStackHandler = objCallStackHandler;
		_LogHandler = objLogHandler;
		_Parametrica = objParametrica;
		_User = sAppUser;
		_Group = sAppGroup;
		_Organization = sAppOrganization;
		_OrganizationType = sAppOrganizationType;
		_OrganizationInternalExternal = sAppOrganizationInternalExternal;
	}

	protected string TranslateMessage(string vsID, string vsDefault, params string[] vParametri)
	{
		return _Translator.TranslateMessage(vsID, vsDefault, vParametri);
	}

	protected string TranslateMessage(string vsID, string vsDefault)
	{
		return _Translator.TranslateMessage(vsID, vsDefault);
	}

	protected void CallStackAdd()
	{
		_CallStackHandler.CallStackAdd();
	}

	protected void CallStackReset()
	{
		_CallStackHandler.CallStackReset();
	}

	protected void CallStackRemove()
	{
		_CallStackHandler.CallStackRemove();
	}

	protected modGeneral.FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		return _LogHandler.HandleError(ref objEx, ref rsMess);
	}

	protected modGeneral.FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		return _LogHandler.HandleError(ref objEx, vsMessage, ref rsMess);
	}

	protected virtual void WriteLog(string Descrizione)
	{
		checked
		{
			try
			{
				if (_AlwaysInsert | (_ApiContext.IsDebug & ((Operators.CompareString(_ApiContext.DebugUser, "", false) == 0) | (Operators.CompareString(_ApiContext.DebugUser.ToUpper(), _User.ToUpper(), false) == 0))))
				{
					string text = "";
					StackTrace stackTrace = new StackTrace();
					int num = stackTrace.FrameCount - 1;
					int i;
					for (i = 0; i <= num && Operators.CompareString(stackTrace.GetFrame(i).GetMethod().Name.ToUpper(), "WriteLog".ToUpper(), false) == 0; i++)
					{
					}
					text = GetType().ToString() + "." + stackTrace.GetFrame(i).GetMethod().Name;
					stackTrace = null;
					string vsMessage = "|" + _User + "|" + text + "|" + Descrizione;
					string vsLogFileName = (_ApiContext.ApplicationRootDir + _ApiContext.LogDir + _LogFileName).Replace("%USER%", _User);
					LogFile logFile = new LogFile(vsLogFileName, 2097152, vbConData: true, vbUcase: false);
					logFile.Write(vsMessage);
					logFile = null;
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
