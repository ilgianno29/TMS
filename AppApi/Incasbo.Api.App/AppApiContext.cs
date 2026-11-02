using System;
using System.Collections.Generic;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class AppApiContext
{
	public DBConnection DbConn { get; set; }

	public IncasTranslator Translator { get; set; }

	public IboAppCallStackHandling CallStackHandler { get; set; }

	public IboAppLogHandling LogHandler { get; set; }

	public IboWebParam Parametrica { get; set; }

	public string User { get; set; }

	public string Group { get; set; }

	public string Organization { get; set; }

	public string OrganizationType { get; set; }

	public string OrganizationInternalExternal { get; set; }

	public string ApplicationRootDir { get; set; }

	public AppDefault AppDefault { get; set; }

	public AppParams AppParams { get; set; }

	public string AppName { get; set; }

	public string AppSessionId { get; set; }

	public bool IsDebug { get; set; }

	public string DebugUser { get; set; }

	public Dictionary<string, object> ContextVariables { get; set; }

	public PerformanceLog PerformanceLog { get; set; }

	public string DownloadDir { get; set; }

	public string LogDir { get; set; }

	public CRWConfiguration CRWConfig { get; set; }

	public virtual bool IsInDebugMode
	{
		get
		{
			bool result = false;
			try
			{
				if (IsDebug & ((Operators.CompareString(DebugUser.ToUpper().Trim(), User.ToUpper(), false) == 0) | (Operators.CompareString(DebugUser.ToUpper().Trim(), "", false) == 0)))
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

	public AppApiContext()
	{
		string user = "";
		User = user;
		user = "";
		Group = user;
		user = "";
		Organization = user;
		user = "";
		OrganizationType = user;
		user = "";
		OrganizationInternalExternal = user;
		user = "";
		ApplicationRootDir = user;
		user = "XXX";
		AppName = user;
		user = "";
		AppSessionId = user;
		bool isDebug = false;
		IsDebug = isDebug;
		user = "";
		DebugUser = user;
		user = "Download\\";
		DownloadDir = user;
		user = "Log\\";
		LogDir = user;
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		try
		{
			if (IsInDebugMode)
			{
				PerformanceLog.Write(sMessaggioLog);
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
				PerformanceLog.Flush();
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
			PerformanceLog.StopWatch();
		}
	}
}
