using System;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IboAppLogHandling
{
	private string LogFileName;

	private string ErrorFileName;

	private long LogFileMaxLengthInByte;

	private long ErrorFileMaxLengthInByte;

	private string ApplicationName;

	private string ApplicationUser;

	private bool bStackTrace;

	private Exception _LastExceptionOccurred;

	private string sUserDesc;

	private string sAppDesc;

	private string sFuncDesc;

	private string sDescDesc;

	private string sDateDesc;

	private string sStackTraceDesc;

	private bool pbInitialized;

	private LogFile objLogFile;

	private LogFile objErrFile;

	private LogFile _objLogFileForUser;

	private LogFile _objErrFileForUser;

	private bool _LogForSingleUsers;

	private IboAppCallStackHandling _ObjCallStack;

	private const string sAppFuncDesc = "App.Func.: ";

	private const string sDBErrorDesc = "DB Error: ";

	public IncasTranslator Translator { get; set; }

	public Exception LastExceptionOccurred => _LastExceptionOccurred;

	public IboAppLogHandling()
	{
		LogFileName = "C:\\IboApp.log";
		ErrorFileName = "C:\\IboApp.err";
		LogFileMaxLengthInByte = 4096L;
		ErrorFileMaxLengthInByte = 4096L;
		ApplicationName = "IBOAPP";
		ApplicationUser = "USER";
		_LastExceptionOccurred = null;
		sUserDesc = "Application/User".PadRight(16) + ": ";
		sAppDesc = "App. Path".PadRight(16) + ": ";
		sFuncDesc = "Function".PadRight(16) + ": ";
		sDescDesc = "Description".PadRight(16) + ": ";
		sDateDesc = "Date".PadRight(16) + ": ";
		sStackTraceDesc = "Debug Info".PadRight(16) + ": ";
		_objLogFileForUser = null;
		_objErrFileForUser = null;
		_LogForSingleUsers = false;
		IncasTranslator translator = null;
		Translator = translator;
	}

	public modGeneral.FXRETURN Init(string sApplicationName, string sApplicationUser, string sLogFileName, string sErrorFileName, long lLogFileMaxLengthInByte, long lErrorFileMaxLengthInByte, bool vbStackTrace, ref IboAppCallStackHandling rObjCallStack, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		rsMess = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				LogFileName = sLogFileName;
				ErrorFileName = sErrorFileName;
				LogFileMaxLengthInByte = lLogFileMaxLengthInByte;
				ErrorFileMaxLengthInByte = lErrorFileMaxLengthInByte;
				ApplicationName = sApplicationName;
				ApplicationUser = sApplicationUser;
				bStackTrace = vbStackTrace;
				_ObjCallStack = rObjCallStack;
				objLogFile = new LogFile(LogFileName, (int)LogFileMaxLengthInByte, vbConData: false, vbUcase: false);
				objErrFile = new LogFile(ErrorFileName, (int)ErrorFileMaxLengthInByte, vbConData: false, vbUcase: false);
				pbInitialized = true;
				fXRETURN = modGeneral.FXRETURN.OK;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN = HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = fXRETURN;
			}
			return result;
		}
	}

	protected string LogFileNameForUser()
	{
		string result = "";
		int num = Strings.InStrRev(LogFileName, ".", -1, (CompareMethod)0);
		if (num > 0)
		{
			result = Strings.Left(LogFileName, checked(num - 1)) + "_" + ApplicationUser + Strings.Mid(LogFileName, num);
		}
		return result;
	}

	protected string ErrorFileNameForUser()
	{
		string result = "";
		int num = Strings.InStrRev(ErrorFileName, ".", -1, (CompareMethod)0);
		if (num > 0)
		{
			result = Strings.Left(ErrorFileName, checked(num - 1)) + "_" + ApplicationUser + Strings.Mid(ErrorFileName, num);
		}
		return result;
	}

	public modGeneral.FXRETURN Init(string sApplicationName, string sApplicationUser, string sLogFileName, string sErrorFileName, long lLogFileMaxLengthInByte, long lErrorFileMaxLengthInByte, bool vbStackTrace, bool bLogForSingleUsers, ref IboAppCallStackHandling rObjCallStack, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		rsMess = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				LogFileName = sLogFileName;
				ErrorFileName = sErrorFileName;
				LogFileMaxLengthInByte = lLogFileMaxLengthInByte;
				ErrorFileMaxLengthInByte = lErrorFileMaxLengthInByte;
				ApplicationName = sApplicationName;
				ApplicationUser = sApplicationUser;
				bStackTrace = vbStackTrace;
				_LogForSingleUsers = bLogForSingleUsers;
				_ObjCallStack = rObjCallStack;
				objLogFile = new LogFile(LogFileName, (int)LogFileMaxLengthInByte, vbConData: false, vbUcase: false);
				objErrFile = new LogFile(ErrorFileName, (int)ErrorFileMaxLengthInByte, vbConData: false, vbUcase: false);
				if (_LogForSingleUsers)
				{
					_objLogFileForUser = new LogFile(LogFileNameForUser(), (int)LogFileMaxLengthInByte, vbConData: false, vbUcase: false);
					_objErrFileForUser = new LogFile(ErrorFileNameForUser(), (int)ErrorFileMaxLengthInByte, vbConData: false, vbUcase: false);
				}
				pbInitialized = true;
				fXRETURN = modGeneral.FXRETURN.OK;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN = HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = fXRETURN;
			}
			return result;
		}
	}

	public void LogMessage(string vsMessage, bool vbError = false, string vsUser = "APP")
	{
		CheckInit();
		string text = Conversions.ToString(Interaction.IIf(vbError, (object)"ERR", (object)"MSG"));
		string vsMessage2 = "[" + Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH:mm:ss") + "] [" + text + "] [" + vsUser.PadRight(8) + "] - " + vsMessage;
		objLogFile.Write(vsMessage2);
		if (_objLogFileForUser != null)
		{
			_objLogFileForUser.Write(vsMessage2);
		}
	}

	public void LogToFile(string vsFileName, string vsMessage)
	{
		LogFile logFile = new LogFile(vsFileName, checked((int)LogFileMaxLengthInByte), vbConData: false, vbUcase: false);
		logFile.Write(vsMessage);
		logFile = null;
	}

	public void LogToFile(string vsFileName, string vsMessage, long vlMaxLenInByte)
	{
		LogFile logFile = new LogFile(vsFileName, checked((int)vlMaxLenInByte), vbConData: false, vbUcase: false);
		logFile.Write(vsMessage);
		logFile = null;
	}

	public void LogToFile(string vsFileName, string vsMessage, long vlMaxLenInByte, bool bConData)
	{
		LogFile logFile = new LogFile(vsFileName, checked((int)vlMaxLenInByte), bConData, vbUcase: false);
		logFile.Write(vsMessage);
		logFile = null;
	}

	public void LogToFile(string vsFileName, string vsMessage, long vlMaxLenInByte, bool bConData, bool bUpperCase)
	{
		LogFile logFile = new LogFile(vsFileName, checked((int)vlMaxLenInByte), bConData, bUpperCase);
		logFile.Write(vsMessage);
		logFile = null;
	}

	public void LogError(string vsFunctionOrCommand, string vsErrorMessage, string vsDebugInfo)
	{
		try
		{
			CheckInit();
			string text = sDateDesc + "[" + Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH:mm:ss") + "]\r\n";
			text = text + sUserDesc + "[" + ApplicationName + "] [" + ApplicationUser + "]\r\n";
			text = text + sAppDesc + "[" + _ObjCallStack.CallStack + "]\r\n";
			text = text + sFuncDesc + "[" + vsFunctionOrCommand + "]\r\n";
			text = text + sDescDesc + "[" + vsErrorMessage + "]\r\n";
			if (bStackTrace & (Operators.CompareString(vsDebugInfo, "", false) != 0))
			{
				text = text + sStackTraceDesc + "[" + vsDebugInfo + "]\r\n";
			}
			objErrFile.Write(text);
			if (_objErrFileForUser != null)
			{
				_objErrFileForUser.Write(text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void LogError(string vsFunctionOrCommand, string vsErrorMessage)
	{
		LogError(vsFunctionOrCommand, vsErrorMessage, "");
	}

	private void CheckInit()
	{
		if (!pbInitialized)
		{
			string message = "Class IboAppLogHandling not initialized";
			throw new Exception(message);
		}
	}

	public modGeneral.FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		return HandleError(ref objEx, "", ref rsMess);
	}

	public modGeneral.FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		StackTrace stackTrace = new StackTrace();
		bool bWriteLog = true;
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				string name = objEx.GetType().Name;
				int num = stackTrace.FrameCount - 1;
				int i;
				for (i = 0; i <= num && Operators.CompareString(stackTrace.GetFrame(i).GetMethod().Name.ToUpper(), "CALLSTACKADD", false) == 0; i++)
				{
				}
				string text = stackTrace.GetFrame(i).GetMethod().Name.ToUpper();
				stackTrace = null;
				int j = default(int);
				string text2;
				if (objEx is SqlException sqlEx)
				{
					// SQL Server (Microsoft.Data.SqlClient): un messaggio per ogni errore restituito dal server
					for (j = 0; j < sqlEx.Errors.Count; j++)
					{
						if (rsMess.Length > 0)
						{
							rsMess += "\r\n";
						}
						if (sqlEx.Errors[j].State != 0)
						{
							rsMess = rsMess + sqlEx.Errors[j].State + " - " + sqlEx.Errors[j].Message;
						}
						else
						{
							rsMess += sqlEx.Errors[j].Message;
						}
						rsMess = TranslateSqlMessage(rsMess, ref bWriteLog);
					}
					if (rsMess.Length == 0)
					{
						rsMess = objEx.Message;
					}
					fXRETURN = modGeneral.FXRETURN.DatabaseError;
					text2 = "DB Error: ";
				}
				else if (objEx is DbException)
				{
					// Qualsiasi altro errore di un provider ADO.NET
					rsMess += objEx.Message;
					rsMess = TranslateSqlMessage(rsMess, ref bWriteLog);
					fXRETURN = modGeneral.FXRETURN.DatabaseError;
					text2 = "DB Error: ";
				}
				else
				{
					rsMess = "GENERIC ERROR: " + objEx.Message;
					fXRETURN = modGeneral.FXRETURN.ProgramError;
					text2 = "App.Func.: ";
				}
				text2 = text2 + "'" + vsMessage + "' on " + text;
				if ((object)objEx.GetType() != typeof(ThreadAbortException) && bWriteLog)
				{
					if (objEx.InnerException != null)
					{
						rsMess = rsMess + " - InnerException: " + objEx.InnerException.Message + "";
					}
					LogError(text2, rsMess, objEx.StackTrace);
					_LastExceptionOccurred = objEx;
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
				if (Operators.CompareString(rsMess, "", false) == 0)
				{
					rsMess = "Unknown Generic Error";
				}
				result = fXRETURN;
			}
			return result;
		}
	}

	protected string TranslateSqlMessage(string rsMess, ref bool bWriteLog)
	{
		checked
		{
			if (rsMess.Contains("%BEGIN_INCAS_ERROR%"))
			{
				string text = "";
				text = Strings.Mid(rsMess, Strings.InStr(rsMess, "%BEGIN_INCAS_ERROR%", (CompareMethod)0) + Strings.Len("%BEGIN_INCAS_ERROR%"));
				text = Strings.Left(text, Strings.InStr(text, "%END_INCAS_ERROR%", (CompareMethod)0) - 1);
				string[] array = Strings.Split(text, "#", -1, (CompareMethod)0);
				string[] array2 = new string[0];
				int num = array.Count() - 1;
				for (int i = 1; i <= num; i++)
				{
					array2 = (string[])Utils.CopyArray((Array)array2, (Array)new string[i - 1 + 1]);
					array2[i - 1] = array[i];
				}
				rsMess = ((Translator == null) ? string.Format(array[0], array2) : Translator.TranslateMessage("XXX", array[0], array2));
				bWriteLog = false;
			}
			return rsMess;
		}
	}
}
