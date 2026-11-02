using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Web;
using Incasbo.Web.Library;
using Incasbo.Web.WSC;
using Incasbo.Web.WSCWCF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class Global_asax : HttpApplication
{
	[AccessedThroughProperty("tmrApplication")]
	private System.Timers.Timer _tmrApplication;

	protected int _iErrFileMaxLength;

	protected int _iLogFileMaxLength;

	protected static bool BackgroundProcessCanStart = false;

	protected static bool BackgroundProcessStarted = false;

	protected static string _WSApplicationRoot = "";

	protected static object BackgroundProcessSem = RuntimeHelpers.GetObjectValue(new object());

	protected Thread BackgroundThread;

	protected bool BackgroundThreadExit;

	protected long BackgroundThreadCicleNumber;

	protected virtual System.Timers.Timer tmrApplication
	{
		get
		{
			return _tmrApplication;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ElapsedEventHandler value2 = tmrApplication_Elapsed;
			if (_tmrApplication != null)
			{
				_tmrApplication.Elapsed -= value2;
			}
			_tmrApplication = value;
			if (_tmrApplication != null)
			{
				_tmrApplication.Elapsed += value2;
			}
		}
	}

	public string WSApplicationRoot
	{
		get
		{
			if (Operators.CompareString(_WSApplicationRoot, "", false) != 0)
			{
				return _WSApplicationRoot;
			}
			string result = default(string);
			try
			{
				result = HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"].ToString();
				return result;
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

	public string WSApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

	public string WSApplicationLog => WSApplicationRoot + "Log\\" + WSApplicationName + "_Background.LOG";

	public string WSApplicationLogDir => WSApplicationRoot + "Log\\";

	public string WSApplicationIniConfigDir => WSApplicationRoot + "IniConfig\\";

	public string WSDBConfigFile => WSApplicationIniConfigDir + "DBConfig.ini";

	public string WSAppConfigFile => WSApplicationIniConfigDir + "WSCConfig.ini";

	public string WSApplicationErr => WSApplicationRoot + "Log\\" + WSApplicationName + "_Background.ERR";

	public WSC_SessionEnvironment SessionEnv { get; set; }

	public Global_asax()
	{
		_iErrFileMaxLength = 10485760;
		_iLogFileMaxLength = 10485760;
		BackgroundThread = null;
		BackgroundThreadExit = false;
		BackgroundThreadCicleNumber = 0L;
	}

	public void Application_Start(object sender, EventArgs e)
	{
		try
		{
			BackgroundEventApplicationLog("APPLICATION START");
			tmrApplication = new System.Timers.Timer(5000.0);
			tmrApplication.AutoReset = true;
			tmrApplication.Enabled = true;
			BackgroundProcessCanStart = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Session_Start(object sender, EventArgs e)
	{
		try
		{
			((HttpApplication)this).Session["SessionEnvironment"] = new WSC_SessionEnvironment();
			if (!BackgroundProcessCanStart)
			{
				_WSApplicationRoot = HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"].ToString();
				BackgroundProcessCanStart = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Application_BeginRequest(object sender, EventArgs e)
	{
		try
		{
			WSC_SessionEnvironment wSC_SessionEnvironment = (WSC_SessionEnvironment)((HttpApplication)this).Session["SessionEnvironment"];
			wSC_SessionEnvironment.PerformanceLogAppend("BEGIN REQUEST - Session ID: " + wSC_SessionEnvironment.WebSessionId);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Application_EndRequest(object sender, EventArgs e)
	{
		try
		{
			WSC_SessionEnvironment wSC_SessionEnvironment = (WSC_SessionEnvironment)((HttpApplication)this).Session["SessionEnvironment"];
			wSC_SessionEnvironment.PerformanceLogFlush("END REQUEST - Session ID: " + wSC_SessionEnvironment.WebSessionId);
			wSC_SessionEnvironment.PerformanceLogStopWatch();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Application_AuthenticateRequest(object sender, EventArgs e)
	{
	}

	public void Application_Error(object sender, EventArgs e)
	{
	}

	public void Session_End(object sender, EventArgs e)
	{
		try
		{
			WSC_SessionEnvironment wSC_SessionEnvironment = (WSC_SessionEnvironment)((HttpApplication)this).Session["SessionEnvironment"];
			wSC_SessionEnvironment.Destroy();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			((HttpApplication)this).Session["SessionEnvironment"] = null;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	public void Application_End(object sender, EventArgs e)
	{
		try
		{
			BackgroundThreadExit = true;
			BackgroundEventApplicationLog("APPLICATION END");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void tmrApplication_Elapsed(object sender, ElapsedEventArgs e)
	{
		try
		{
			object backgroundProcessSem = BackgroundProcessSem;
			ObjectFlowControl.CheckForSyncLockOnValueType(backgroundProcessSem);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(backgroundProcessSem, ref lockTaken);
				if (BackgroundProcessCanStart && !BackgroundProcessStarted)
				{
					BackgroundProcessStarted = true;
					tmrApplication.AutoReset = false;
					BackgroundThread = new Thread(BackgroundEventApplication);
					BackgroundThread.IsBackground = true;
					BackgroundThread.Start();
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(backgroundProcessSem);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void BackgroundEventApplication_()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Invalid comparison between Unknown and I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Invalid comparison between Unknown and I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Invalid comparison between Unknown and I4
		try
		{
			string vsSQLClause = "";
			int num = 14;
			string rsMess = "";
			FXRETURN val = (FXRETURN)3;
			FXRETURN val2 = (FXRETURN)3;
			Thread.Sleep(10000);
			SessionEnv = new WSC_SessionEnvironment();
			IboAppLogHandling logHandling = SessionEnv.LogHandling;
			string wSApplicationName = WSApplicationName;
			string wSApplicationLog = WSApplicationLog;
			string wSApplicationErr = WSApplicationErr;
			long num2 = _iLogFileMaxLength;
			long num3 = _iErrFileMaxLength;
			IboAppCallStackHandling callStackHandler = SessionEnv.CallStackHandler;
			val2 = logHandling.Init(wSApplicationName, "BKGEVNT", wSApplicationLog, wSApplicationErr, num2, num3, true, ref callStackHandler, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
				return;
			}
			SessionEnv.WSCConfig.Init(WSAppConfigFile, WSDBConfigFile);
			num = SessionEnv.WSCConfig.LogConfig.DayOfPermanenceInLog;
			val2 = SessionEnv.InitDBConnection(ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
				return;
			}
			if (File.Exists(WSApplicationLog) && new FileInfo(WSApplicationLog).Length > 2097152)
			{
				File.Delete(WSApplicationLog);
			}
			if (File.Exists(WSApplicationErr) && new FileInfo(WSApplicationErr).Length > 2097152)
			{
				File.Delete(WSApplicationErr);
			}
			checked
			{
				while (true)
				{
					try
					{
						BackgroundThreadCicleNumber++;
						BackgroundEventApplicationLog("HEART BEAT");
						string wSApplicationLogDir;
						string rsMess2;
						unchecked
						{
							if ((int)SessionEnv.DbMain.OpenConnection(ref rsMess) == 0)
							{
								if (SessionEnv.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
								{
									vsSQLClause = "DELETE FROM " + SessionEnv.WSCConfig.TablesConfig.SessionTable + " WHERE DataInizio <= GETDATE()-" + num + " AND ROWNUM<=100";
								}
								else if (SessionEnv.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
								{
									vsSQLClause = "DELETE TOP(100) FROM " + SessionEnv.WSCConfig.TablesConfig.SessionTable + " WHERE DataInizio <= GETDATE()-" + num;
								}
								if ((int)SessionEnv.DbMain.SqlExec(vsSQLClause, ref rsMess) != 0)
								{
									BackgroundEventApplicationErr(rsMess);
								}
								if (SessionEnv.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
								{
									vsSQLClause = "DELETE FROM " + SessionEnv.WSCConfig.TablesConfig.EventLogTable + " WHERE Data <= GETDATE()-" + num + " AND ROWNUM<=1000";
								}
								else if (SessionEnv.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
								{
									vsSQLClause = "DELETE TOP(1000) FROM " + SessionEnv.WSCConfig.TablesConfig.EventLogTable + " WHERE Data <= GETDATE()-" + num;
								}
								if ((int)SessionEnv.DbMain.SqlExec(vsSQLClause, ref rsMess) != 0)
								{
									BackgroundEventApplicationErr(rsMess);
								}
								if (SessionEnv.WSCConfig.LogConfig.DayOfPermanenceOfFile > 0 && (int)EliminaFileVecchi(WSApplicationLogDir, DateAndTime.DateAdd((DateInterval)4, (double)checked(-SessionEnv.WSCConfig.LogConfig.DayOfPermanenceOfFile), DateAndTime.Now), "*.*", ref rsMess) != 0)
								{
									BackgroundEventApplicationErr(rsMess);
								}
								DBConnection dbMain = SessionEnv.DbMain;
								rsMess2 = "";
								dbMain.CloseConnection(ref rsMess2);
							}
							else
							{
								BackgroundEventApplicationErr(rsMess);
							}
							wSApplicationLogDir = WSApplicationLogDir;
						}
						DateTime sDataDiRiferimento = DateAndTime.DateAdd((DateInterval)4, (double)(-SessionEnv.WSCConfig.LogConfig.DayOfPermanenceOfFile), DateAndTime.Now);
						rsMess2 = "";
						EliminaDirVecchie(wSApplicationLogDir, sDataDiRiferimento, ref rsMess2);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						BackgroundEventApplicationErr(ex2.Message);
						ProjectData.ClearProjectError();
					}
					string backgroundActivityTypeName = SessionEnv.WSCConfig.BackgroundActivityConfig.BackgroundActivityTypeName;
					if (Operators.CompareString(backgroundActivityTypeName.Trim(), "", false) != 0)
					{
						IWSCBackgroundActivity iWSCBackgroundActivity = null;
						try
						{
							string rsMess2 = "";
							iWSCBackgroundActivity = (IWSCBackgroundActivity)IncasReflection.InstantiateClass(backgroundActivityTypeName, ref rsMess2);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						if (iWSCBackgroundActivity != null)
						{
							try
							{
								iWSCBackgroundActivity.Start((HttpApplication)(object)this);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								ProjectData.ClearProjectError();
							}
						}
					}
					int num4 = 1;
					do
					{
						if (BackgroundThreadExit)
						{
							return;
						}
						Thread.Sleep(500);
						num4++;
					}
					while (num4 <= 120);
				}
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			BackgroundEventApplicationErr(ex8.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			BackgroundEventApplicationLog("STOP THREAD");
		}
	}

	public void BackgroundEventApplication()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			while (true)
			{
				num = checked(num + 1);
				if (!Debugger.IsAttached)
				{
					try
					{
						IncasWCFInternal incasWCFInternal = new IncasWCFInternal();
						int backgroundThreadCicleNumber = num;
						string rsMess = "";
						incasWCFInternal.Manutenzione("TMSServiceForWMS", backgroundThreadCicleNumber, ref rsMess);
						incasWCFInternal.Dispose();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					try
					{
						IncasWCFInternal incasWCFInternal2 = new IncasWCFInternal();
						incasWCFInternal2.WSDBConfigFile = "WCFDBConfig_Api.ini";
						incasWCFInternal2.WSAppConfigFile = "WSCWCFConfig_Api.ini";
						int backgroundThreadCicleNumber2 = num;
						string rsMess = "";
						incasWCFInternal2.Manutenzione("TMSApiService", backgroundThreadCicleNumber2, ref rsMess);
						incasWCFInternal2.Dispose();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					try
					{
						IncasWCFInternal incasWCFInternal3 = new IncasWCFInternal();
						incasWCFInternal3.WSDBConfigFile = "WCFDBConfig_TMSServiceMap.ini";
						incasWCFInternal3.WSAppConfigFile = "WSCWCFConfig_TMSServiceMap.ini";
						int backgroundThreadCicleNumber3 = num;
						string rsMess = "";
						incasWCFInternal3.Manutenzione("TMSServiceMap", backgroundThreadCicleNumber3, ref rsMess);
						incasWCFInternal3.Dispose();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
				}
				Thread.Sleep(60000);
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	public void BackgroundEventApplicationLog(string sMessaggio)
	{
		try
		{
			if (BackgroundThreadCicleNumber == 1)
			{
				string contents = Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH.mm.ss") + ": " + BackgroundThreadCicleNumber + " - INIZIO THREAD\r\n";
				File.AppendAllText(WSApplicationLog, contents);
			}
			string contents2 = Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH.mm.ss") + ": " + BackgroundThreadCicleNumber + " - " + sMessaggio + "\r\n";
			File.AppendAllText(WSApplicationLog, contents2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void BackgroundEventApplicationErr(string sMessaggio)
	{
		try
		{
			string contents = Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH.mm.ss") + ": " + BackgroundThreadCicleNumber + " - " + sMessaggio + "\r\n";
			File.AppendAllText(WSApplicationErr, contents);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
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
}
