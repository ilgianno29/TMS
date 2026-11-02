using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.SessionState;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIHttpApplicationEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tmrApplication")]
	private System.Timers.Timer _tmrApplication;

	protected bool BackgroundProcessStarted;

	protected string _WSApplicationRoot;

	protected HttpApplication _GlobaAsax;

	protected object _objSync;

	protected virtual System.Timers.Timer tmrApplication
	{
		[CompilerGenerated]
		get
		{
			return _tmrApplication;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ElapsedEventHandler value2 = tmrApplication_Elapsed;
			System.Timers.Timer timer = _tmrApplication;
			if (timer != null)
			{
				timer.Elapsed -= value2;
			}
			_tmrApplication = value;
			timer = _tmrApplication;
			if (timer != null)
			{
				timer.Elapsed += value2;
			}
		}
	}

	protected HttpSessionState Session
	{
		get
		{
			HttpSessionState val = null;
			if (HttpContext.Current != null && HttpContext.Current.Session != null)
			{
				val = HttpContext.Current.Session;
			}
			if (val == null)
			{
				val = _GlobaAsax.Session;
			}
			return val;
		}
	}

	protected HttpRequest Request => HttpContext.Current.Request;

	protected IboSessionEnvironment SessionEnv
	{
		get
		{
			IboSessionEnvironment result;
			try
			{
				result = (IboSessionEnvironment)Session["SessionEnvironment"];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public WFIHttpApplicationEventHandler()
	{
		BackgroundProcessStarted = false;
		_WSApplicationRoot = "";
		_objSync = RuntimeHelpers.GetObjectValue(new object());
	}

	public void Init(HttpApplication _HttpApplication)
	{
		_GlobaAsax = _HttpApplication;
	}

	public void Application_Start(object sender, EventArgs e)
	{
	}

	public void Session_Start(object sender, EventArgs e)
	{
		WebSessionEnvironment webSessionEnvironment = new IboSessionEnvironment();
		webSessionEnvironment.Session = Session;
		webSessionEnvironment.Application = _GlobaAsax.Application;
		Session["SessionEnvironment"] = webSessionEnvironment;
		Session["Session.Abandon"] = false;
		string text = "";
		try
		{
			text = Request.UserHostName;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			text = Request.ServerVariables["REMOTE_ADDR"];
		}
		Session["Session.REMOTE_ADDR"] = text;
		Session["Session.REMOTE_HOSTNAME"] = "";
		checked
		{
			GlobalModule.StartedSessions++;
			GlobalModule.CurrentSessions++;
			object objSync = _objSync;
			ObjectFlowControl.CheckForSyncLockOnValueType(objSync);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(objSync, ref lockTaken);
				if (!BackgroundProcessStarted)
				{
					_WSApplicationRoot = HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"].ToString();
					BackgroundProcessStarted = true;
					tmrApplication = new System.Timers.Timer(1000.0);
					tmrApplication.AutoReset = false;
					tmrApplication.Enabled = true;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(objSync);
				}
			}
		}
	}

	public void Application_BeginRequest(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		checked
		{
			GlobalModule.RequestCount++;
			if (Request.QueryString["ck"] != null)
			{
				string text = Request.QueryString["ck"];
				IboCrypt val = new IboCrypt();
				string text2 = val.DecryptString128Bit(text);
				HttpContext.Current.RewritePath(Request.Path + "?" + text2);
				val = null;
			}
		}
	}

	public void Application_PreRequestHandlerExecute(object sender, EventArgs e)
	{
		if (SessionEnv != null && SessionEnv.WebLoginUser != null)
		{
			SessionEnv.PerformanceLogAppend("BEGIN REQUEST - USER:" + SessionEnv.WebLoginUser.WebUserInfo.Codice + " SESSION ID: " + SessionEnv.WebSessionId + "-------------------------------------");
		}
	}

	public void Application_PostRequestHandlerExecute(object sender, EventArgs e)
	{
		if (SessionEnv != null && SessionEnv.WebLoginUser != null)
		{
			SessionEnv.PerformanceLogFlush("END REQUEST - USER:" + SessionEnv.WebLoginUser.WebUserInfo.Codice + " SESSION ID: " + SessionEnv.WebSessionId + "-------------------------------------");
			SessionEnv.PerformanceLogReset();
		}
	}

	public void Application_EndRequest(object sender, EventArgs e)
	{
	}

	public void Application_AuthenticateRequest(object sender, EventArgs e)
	{
	}

	public void Application_Error(object sender, EventArgs e)
	{
	}

	public void Session_End(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RemoveLogonUser(SessionEnv.WebUser.WebUserInfo.Codice);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Conversions.ToBoolean(Session["Session.Abandon"]))
			{
				DBConnection dbConn = SessionEnv.DbConn;
				string text = "";
				dbConn.OpenConnection(ref text);
				IboSessionEnvironment SessionEnvironment = SessionEnv;
				string sRisorsa = SessionEnv.WebApplicationName.ToUpper();
				text = "";
				InserisciLog(ref SessionEnvironment, sRisorsa, "LOGOUT", "UI", "SESSION TIMEOUT", "", ref text);
				DBConnection dbConn2 = SessionEnv.DbConn;
				text = "";
				dbConn2.CloseConnection(ref text);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			IboSessionEnvironment sessionEnv = SessionEnv;
			string text = "";
			sessionEnv.ClearTemporaryFiles(ref text);
			SessionEnv.Dispose();
			Session["SessionEnvironment"] = null;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			SessionEnv.SessionVariables.Clear();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			string text2 = "";
			ProjectData.ClearProjectError();
		}
		try
		{
			GC.Collect();
			GC.Collect();
			GC.Collect();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		checked
		{
			GlobalModule.EndedSessions++;
			GlobalModule.CurrentSessions--;
		}
	}

	public void Application_End(object sender, EventArgs e)
	{
		try
		{
			tmrApplication.Enabled = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private FXRETURN InserisciLog(ref IboSessionEnvironment SessionEnvironment, string sRisorsa, string sAzione, string sModulo, string sInfo1, string sInfo2, ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN result;
		try
		{
			LogRisorseAzioni logRisorseAzioni = new LogRisorseAzioni(_GlobaAsax.Session);
			result = logRisorseAzioni.Inserisci(sRisorsa, sAzione, sModulo, sInfo1, sInfo2, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = (FXRETURN)3;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void tmrApplication_Elapsed(object sender, ElapsedEventArgs e)
	{
		Thread thread = new Thread(BackgroundEventApplication);
		thread.IsBackground = true;
		thread.Start();
	}

	public void BackgroundEventApplication()
	{
		try
		{
			WFIBackgroundActivity wFIBackgroundActivity = new WFIBackgroundActivity();
			wFIBackgroundActivity.Start(_GlobaAsax);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void RemoveLogonUser(string sUser)
	{
		checked
		{
			try
			{
				Dictionary<string, int> dictionary = (Dictionary<string, int>)AppApplicationVariables()["LOGGEDUSERS"];
				if (dictionary.ContainsKey(sUser))
				{
					_GlobaAsax.Application.Lock();
					dictionary[sUser]--;
					if (dictionary[sUser] == 0)
					{
						dictionary.Remove(sUser);
					}
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
				_GlobaAsax.Application.UnLock();
			}
		}
	}

	private IboApplicationVariables ApplicationVariables()
	{
		return (IboApplicationVariables)_GlobaAsax.Application["WFIApplicationVariables"];
	}

	private IboDictionaryCollection<string, object> AppApplicationVariables()
	{
		if (ApplicationVariables().ContainsKey("WFIAPP"))
		{
			return ApplicationVariables()["WFIAPP"];
		}
		return null;
	}
}
