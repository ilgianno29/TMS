using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Incasbo.Windows.Library.PDF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public abstract class WFIAspxRemoteService : Page
{
	protected IboDictionaryCollection<string, object> _SessionVariable;

	protected bool _SessionVariablePersistent;

	protected string _InputCommand;

	protected string _OutputResponse;

	protected string _ErrorCode;

	protected string _ErrorMessage;

	protected string _Username;

	protected string _Password;

	public IboSessionEnvironment SessionEnvironment => (IboSessionEnvironment)((Page)this).Session["SessionEnvironment"];

	public DBConnection DbConn
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.DbConn;
			}
			return null;
		}
	}

	public IncasTranslator Translator
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.Translator;
			}
			return null;
		}
	}

	public IboWebParam Parametrica => SessionEnvironment.Parametrica;

	public string WFIUser => SessionEnvironment.WebUser.WebUserInfo.Codice;

	public string WFIGroup => SessionEnvironment.WebUser.WebUserInfo.Gruppo;

	public string WFIOrganization => SessionEnvironment.WebUser.WebUserInfo.Organizzazione;

	public string WFIOrganizationType => SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneTipoSoggetto;

	protected IboDictionaryCollection<string, object> UserApplicationVariables => SessionEnvironment.UserApplicationVariables();

	public ApplicationDefault ApplicationDefault => (ApplicationDefault)SessionEnvironment.AppDefault;

	public ApplicationParams ApplicationParams => (ApplicationParams)SessionEnvironment.AppParams;

	public virtual string PageName => Strings.Replace(((TemplateControl)this).AppRelativeVirtualPath, ((Control)this).AppRelativeTemplateSourceDirectory, "", 1, -1, (CompareMethod)0);

	public virtual string EntryPoint => PageName.ToUpper();

	public Exception LastExceptionOccurred
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

	public string CallStack
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

	public IboAppCallStackHandling CallStackHandler
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

	public IboAppLogHandling LogHandler
	{
		get
		{
			if (SessionEnvironment.Initialized)
			{
				return SessionEnvironment.LogHandling;
			}
			return null;
		}
	}

	public PerformanceLog PerformanceLog => SessionEnvironment.PerformanceLog;

	public virtual bool IsInDebugMode
	{
		get
		{
			bool result = false;
			try
			{
				if (SessionEnvironment.WFIConfig.DebugConfig.DebugMode & ((Operators.CompareString(SessionEnvironment.WFIConfig.DebugConfig.UserDebug.ToUpper().Trim(), _Username.ToUpper(), false) == 0) | (Operators.CompareString(SessionEnvironment.WFIConfig.DebugConfig.UserDebug.ToUpper().Trim(), "", false) == 0)))
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

	protected WFIAspxRemoteService()
	{
		((Control)this).Init += Page_Init;
		((Control)this).Load += Page_Load;
		_SessionVariablePersistent = false;
		_InputCommand = "";
		_OutputResponse = "";
		_ErrorCode = "0";
		_ErrorMessage = "";
		_Username = "";
		_Password = "";
	}

	public string TranslateMessage(string vsID, string vsDefault, params string[] vParametri)
	{
		return Translator.TranslateMessage(vsID, vsDefault, vParametri);
	}

	public string TranslateMessage(string vsDefault, params string[] vParametri)
	{
		return Translator.TranslateMessage("XXX", vsDefault, vParametri);
	}

	public string TranslateMessage(string vsID, string vsDefault)
	{
		return Translator.TranslateMessage(vsID, vsDefault, new string[0]);
	}

	public void CallStackAdd()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackAdd();
		}
	}

	public void CallStackReset()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackReset();
		}
	}

	public void CallStackRemove()
	{
		if (SessionEnvironment.Initialized)
		{
			SessionEnvironment.CallStackHandler.CallStackRemove();
		}
	}

	public FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.LogHandling.HandleError(ref objEx, ref rsMess);
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	public FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.LogHandling.HandleError(ref objEx, vsMessage, ref rsMess);
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	private void Page_Init(object sender, EventArgs e)
	{
		try
		{
			if (!SessionEnvironment.WFIConfig.Initialized)
			{
				SessionEnvironment.Session["ConfigFile"] = "";
				SessionEnvironment.Session["DBConfigFile"] = "";
				if (Operators.CompareString(((Page)this).Request.QueryString["CF"], "", false) != 0)
				{
					SessionEnvironment.Session["ConfigFile"] = ((Page)this).Request.QueryString["CF"];
				}
				if (Operators.CompareString(((Page)this).Request.QueryString["DBCFG"], "", false) != 0)
				{
					SessionEnvironment.Session["DBConfigFile"] = ((Page)this).Request.QueryString["DBCFG"];
				}
				SessionEnvironment.WebApplicationIniConfigFile = SessionEnvironment.WebApplicationIniConfigFile.Replace("<%CFG%>", SessionEnvironment.Session["ConfigFile"].ToString());
				SessionEnvironment.WebApplicationDBConfigFile = SessionEnvironment.WebApplicationDBConfigFile.Replace("<%CFG%>", SessionEnvironment.Session["DBConfigFile"].ToString());
				SessionEnvironment.WFIConfig.Init(SessionEnvironment.WebApplicationWFIIniConfigDir + SessionEnvironment.WebApplicationIniConfigFile, SessionEnvironment.WebApplicationIniConfigDir + SessionEnvironment.WebApplicationIniConfigFile, SessionEnvironment.WebApplicationWFIIniConfigDir + SessionEnvironment.WebApplicationDBConfigFile, SessionEnvironment.WebApplicationIniConfigDir + SessionEnvironment.WebApplicationDBConfigFile);
				if (!((Page)this).Application.AllKeys.Contains("WFIConfig"))
				{
					((Page)this).Application.Add("WFIConfig", (object)SessionEnvironment.WFIConfig);
				}
			}
			_SessionVariable = SessionEnvironment.SessionVariables[EntryPoint];
			if (!((Page)this).IsPostBack && SessionEnvironment.PersistentSessionVariables.ContainsKey("ResetSessionVariableForActualPage"))
			{
				string text = SessionEnvironment.PersistentSessionVariables["ResetSessionVariableForActualPage"].ToString();
				SessionEnvironment.PersistentSessionVariables["ResetSessionVariableForActualPage"] = "";
				if ((_SessionVariable != null) & (Operators.CompareString(text, "S", false) == 0))
				{
					_SessionVariable = null;
					SessionEnvironment.SessionVariables.Remove(EntryPoint);
				}
			}
			if (_SessionVariable == null)
			{
				_SessionVariable = new IboDictionaryCollection<string, object>();
			}
			SessionEnvironment.SessionVariables.Add(EntryPoint, _SessionVariable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Page_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		string rsmess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			val2 = LoadPage(ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val = (FXRETURN)0;
			}
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
		}
	}

	protected virtual FXRETURN LoadPage(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Invalid comparison between Unknown and I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			_Username = ((Page)this).Request.Headers["Username"];
			_Password = ((Page)this).Request.Headers["Password"];
			PerformanceLogAppend("Begin Load WFIAspxRemoteService page");
			// La password resta in chiaro fino alla verifica (vedi UserPasswords)
			val2 = SessionEnvironment.Init(_Username, _Password, "", SessionEnvironment.Session["ConfigFile"].ToString(), SessionEnvironment.Session["DBConfigFile"].ToString(), "", ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				_ErrorCode = "1";
				_ErrorMessage = rsmess;
			}
			else
			{
				PerformanceLogAppend("Session Initialized");
				StreamReader streamReader = new StreamReader(((Page)this).Request.InputStream);
				_InputCommand = streamReader.ReadToEnd();
				val2 = PreElabRequest(ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					_ErrorCode = "2";
					_ErrorMessage = rsmess;
				}
				else
				{
					PerformanceLogAppend("PreElab Request done");
					val2 = ElabRequest(ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						_ErrorCode = "3";
						_ErrorMessage = rsmess;
					}
					else
					{
						PerformanceLogAppend("Elab Request done");
						val2 = PostElabRequest(ref rsmess);
						if ((int)val2 > 0)
						{
							val = val2;
							_ErrorCode = "4";
							_ErrorMessage = rsmess;
						}
						else
						{
							PerformanceLogAppend("PostElab Request done");
							SendResponse();
							val = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			if (Operators.CompareString(rsmess, "", false) == 0)
			{
				rsmess = objEx.Message;
			}
			if ((object)objEx.GetType() != typeof(ThreadAbortException))
			{
				_ErrorCode = "99";
				_ErrorMessage = rsmess;
			}
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (Operators.CompareString(_ErrorCode, "0", false) != 0)
			{
				SendErrorToClient();
			}
			if (SessionEnvironment.Initialized)
			{
				IboSessionEnvironment sessionEnvironment = SessionEnvironment;
				string rsMess = "";
				sessionEnvironment.StopEnvironment(ref rsMess);
			}
			((Page)this).Session.Abandon();
			FormsAuthentication.SignOut();
			((Page)this).Session["Session.Abandon"] = true;
			PerformanceLogFlush("End Load WFIAspxRemoteService page");
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN ElabRequest(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
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

	protected virtual FXRETURN PreElabRequest(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			((Page)this).Response.Clear();
			((Page)this).Response.ContentType = "text/plain";
			((Page)this).Response.ContentEncoding = Encoding.UTF8;
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

	protected virtual FXRETURN PostElabRequest(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
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

	protected virtual void SendResponse()
	{
		try
		{
			((Page)this).Response.Write(_OutputResponse);
			((Page)this).Response.End();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	protected virtual void SendErrorToClient()
	{
		try
		{
			((Page)this).Response.Clear();
			((Page)this).Response.ContentType = "text/plain";
			((Page)this).Response.ContentEncoding = Encoding.UTF8;
			((Page)this).Response.Write("<result><code>" + _ErrorCode + "</code><ErrorMessage>" + _ErrorMessage + "</ErrorMessage></result>");
			((Page)this).Response.End();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected FXRETURN SendPDFFileToClient(string sNomeFile, string sClientFileName, bool bSegnaFileComeDaCancellare, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (File.Exists(sNomeFile))
			{
				if (Operators.CompareString(sClientFileName, "", false) == 0)
				{
					FileInfo fileInfo = new FileInfo(sNomeFile);
					sClientFileName = fileInfo.Name;
				}
				HttpContext.Current.Response.Clear();
				HttpContext.Current.Response.ContentType = "application/pdf";
				HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + sClientFileName);
				HttpContext.Current.Response.WriteFile(sNomeFile);
				if (bSegnaFileComeDaCancellare)
				{
					IboSessionEnvironment sessionEnvironment = SessionEnvironment;
					string rsMess2 = "";
					sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess2);
				}
				HttpContext.Current.Response.End();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN SendXLSFileToClient(string sNomeFile, string sClientFileName, bool bSegnaFileComeDaCancellare, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (File.Exists(sNomeFile))
			{
				if (Operators.CompareString(sClientFileName, "", false) == 0)
				{
					FileInfo fileInfo = new FileInfo(sNomeFile);
					sClientFileName = fileInfo.Name;
				}
				HttpContext.Current.Response.Clear();
				HttpContext.Current.Response.ContentType = "application/xls";
				HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + sClientFileName);
				HttpContext.Current.Response.WriteFile(sNomeFile);
				if (bSegnaFileComeDaCancellare)
				{
					IboSessionEnvironment sessionEnvironment = SessionEnvironment;
					string rsMess2 = "";
					sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess2);
				}
				HttpContext.Current.Response.End();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN SendZIPFileToClient(string sNomeFile, string sClientFileName, bool bSegnaFileComeDaCancellare, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (File.Exists(sNomeFile))
			{
				if (Operators.CompareString(sClientFileName, "", false) == 0)
				{
					FileInfo fileInfo = new FileInfo(sNomeFile);
					sClientFileName = fileInfo.Name;
				}
				HttpContext.Current.Response.Clear();
				HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
				HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + sClientFileName);
				HttpContext.Current.Response.WriteFile(sNomeFile);
				if (bSegnaFileComeDaCancellare)
				{
					IboSessionEnvironment sessionEnvironment = SessionEnvironment;
					string rsMess2 = "";
					sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess2);
				}
				HttpContext.Current.Response.End();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN ZipFile(string sFile, ref string ZipFileName, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		ZipOutputStream val2 = null;
		ZipEntry val3 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!File.Exists(sFile))
			{
				goto IL_00f7;
			}
			fileStream = new FileStream(sFile, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[checked((int)fileStream.Length - 1 + 1)];
			int num = fileStream.Read(array, 0, array.Length);
			if (num == array.Length)
			{
				fileStream.Close();
				if (Operators.CompareString(ZipFileName, "", false) == 0)
				{
					ZipFileName = sFile + ".zip";
				}
				fileStream = new FileStream(ZipFileName, FileMode.CreateNew, FileAccess.Write);
				val2 = new ZipOutputStream((Stream)fileStream);
				val3 = new ZipEntry(new FileInfo(sFile).Name);
				val2.PutNextEntry(val3);
				val2.Write(array, 0, array.Length);
				val2.Finish();
				((DeflaterOutputStream)val2).Close();
				fileStream.Close();
				goto IL_00f7;
			}
			rsMess = TranslateMessage("XXX", "Errore nella lettura del file.");
			goto end_IL_000a;
			IL_00f7:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			if (val2 != null)
			{
				((DeflaterOutputStream)val2).Close();
				((Stream)(object)val2).Dispose();
				val2 = null;
			}
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
				fileStream = null;
			}
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected string GenerateTempFileName(string sNomeFile)
	{
		string text = SessionEnvironment.WebApplicationDownloadDir + sNomeFile;
		return text.Replace("*", Guid.NewGuid().ToString());
	}

	public virtual AppApiContext CreateApiContext(bool WithCloneConnection = false)
	{
		return SessionEnvironment.CreateApiContext(WithCloneConnection);
	}

	protected virtual FXRETURN ReleaseMemory(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_SessionVariable != null && !_SessionVariablePersistent)
			{
				foreach (KeyValuePair<string, object> item in _SessionVariable)
				{
					object obj = item;
					if (((KeyValuePair<string, object>)obj).Value is IDisposable)
					{
						((IDisposable)((KeyValuePair<string, object>)obj).Value).Dispose();
					}
				}
				SessionEnvironment.SessionVariables.Remove(EntryPoint);
				_SessionVariable = null;
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(string NomeReport, string SelectionFormula, string HumanReadableSelectionFormula, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FunctionArguments functionArguments = null;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			NomeReport = NomeReport.ToUpper();
			text = "SELECT * FROM WFI_TABREP ";
			text = text + "WHERE Nomrep=" + SessionEnvironment.DbConn.SQLFormatString(NomeReport) + " ";
			val2 = SessionEnvironment.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Il report {0} non risulta tra l'elenco dei report disponibili", NomeReport);
			}
			else
			{
				functionArguments = new FunctionArguments("", "");
				((Page)this).Session["FunctionArgsReportPage"] = functionArguments;
				functionArguments.Argomento1 = "";
				functionArguments.Argomento2 = NomeReport;
				functionArguments.Argomento3 = dataTable.Rows[0]["Tipo"].ToString();
				functionArguments.Argomento4 = SelectionFormula;
				functionArguments.Argomento5 = HumanReadableSelectionFormula;
				IboAppCallStackHandling robjCallStackHandler = CallStackHandler;
				string sUrl = "~/WFI/Form/WFStandardReport.aspx";
				BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(string NomeReport, string SelectionFormula, string HumanReadableSelectionFormula, Dictionary<string, object> ReportParams, bool VisualizzaStampa, ref string PdfFile, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			NomeReport = NomeReport.ToUpper();
			IboSessionEnvironment robjSessionEnv = SessionEnvironment;
			IboWebCRW iboWebCRW = new IboWebCRW(ref robjSessionEnv);
			string vsNomeFileExport = Guid.NewGuid().ToString() + ".pdf";
			string rsNomeFileCompletoGenerato = "";
			val2 = iboWebCRW.CrystalReportToPDF(NomeReport, vsNomeFileExport, SelectionFormula, HumanReadableSelectionFormula, ReportParams, ref rsNomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				PdfFile = rsNomeFileCompletoGenerato;
				if (VisualizzaStampa & !StampaAsincrona)
				{
					FunctionArguments functionArguments = new FunctionArguments("", "");
					((Page)this).Session["FunctionArgsReportPage"] = functionArguments;
					functionArguments.Argomento1 = "#SHOWMODE";
					functionArguments.Argomento2 = PdfFile;
					functionArguments.Argomento3 = "PDF";
					IboAppCallStackHandling robjCallStackHandler = CallStackHandler;
					string sUrl = "~/WFI/Form/WFStandardReport.aspx";
					BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(string NomeReport, string SelectionFormula, string HumanReadableSelectionFormula, bool VisualizzaStampa, ref string PdfFile, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = AvviaStampa(NomeReport, SelectionFormula, HumanReadableSelectionFormula, null, VisualizzaStampa, ref PdfFile, ref StampaAsincrona, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(ReportLaunchParametersCollection ReportsParameters, bool VisualizzaStampa, ref string PdfFile, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringCollection stringCollection = new StringCollection();
		bool StampaAsincrona = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboSessionEnvironment robjSessionEnv = SessionEnvironment;
			IboWebCRW iboWebCRW = new IboWebCRW(ref robjSessionEnv);
			foreach (ReportLaunchParameters item in (List<ReportLaunchParameters>)(object)ReportsParameters)
			{
				string vsNomeFileExport = Guid.NewGuid().ToString() + ".pdf";
				string rsNomeFileCompletoGenerato = "";
				item.NomeReport = item.NomeReport.ToUpper();
				val2 = iboWebCRW.CrystalReportToPDF(item.NomeReport, vsNomeFileExport, item.SelectionFormula, item.HumanReadableSelectionFormula, item.ReportParams, ref rsNomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
				if ((int)val2 <= 0)
				{
					stringCollection.Add(rsNomeFileCompletoGenerato);
					continue;
				}
				val = val2;
				goto end_IL_000e;
			}
			val2 = PdfMerge(stringCollection, SegnaFileComeDaCancellare: true, ref PdfFile, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (VisualizzaStampa)
				{
					FunctionArguments functionArguments = new FunctionArguments("", "");
					((Page)this).Session["FunctionArgsReportPage"] = functionArguments;
					functionArguments.Argomento1 = "#SHOWMODE";
					functionArguments.Argomento2 = PdfFile;
					functionArguments.Argomento3 = "PDF";
					IboAppCallStackHandling robjCallStackHandler = CallStackHandler;
					string sUrl = "~/WFI/Form/WFStandardReport.aspx";
					BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				}
				val = (FXRETURN)0;
			}
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN PdfMerge(StringCollection PdfFiles, ref byte[] PdfBytes, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			List<byte[]> list = new List<byte[]>();
			StringEnumerator enumerator = PdfFiles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (File.Exists(current))
				{
					list.Add(File.ReadAllBytes(current));
				}
			}
			PdfBytes = PdfMerger.MergeFiles(list);
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public virtual FXRETURN PdfMerge(StringCollection PdfFiles, bool SegnaFileComeDaCancellare, ref string PdfMergedFile, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		byte[] PdfBytes = new byte[0];
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val = PdfMerge(PdfFiles, ref PdfBytes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = SessionEnvironment.WebApplicationDownloadDir + Guid.NewGuid().ToString() + ".pdf";
				File.WriteAllBytes(text, PdfBytes);
				PdfMergedFile = text;
				if (SegnaFileComeDaCancellare)
				{
					IboSessionEnvironment sessionEnvironment = SessionEnvironment;
					string sNomeFile = PdfMergedFile;
					string rsMess = "";
					sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess);
				}
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(string sNomRif, string sUtente, FunctionArguments objFunctionArguments, DataTable dtDati, string NomeReport, string NomeFileExport, string SelectionFormula, string HumanReadableSelectionFormula, string ForzaStampaAsincrona, ref string NomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = AvviaStampa(sNomRif, sUtente, objFunctionArguments, dtDati, NomeReport, NomeFileExport, SelectionFormula, HumanReadableSelectionFormula, null, ForzaStampaAsincrona, ref NomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN AvviaStampa(string sNomRif, string sUtente, FunctionArguments objFunctionArguments, DataTable dtDati, string NomeReport, string NomeFileExport, string SelectionFormula, string HumanReadableSelectionFormula, Dictionary<string, object> ReportParams, string ForzaStampaAsincrona, ref string NomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			NomeReport = NomeReport.ToUpper();
			IboSessionEnvironment robjSessionEnv = SessionEnvironment;
			IboWebCRW iboWebCRW = new IboWebCRW(ref robjSessionEnv);
			if (Operators.CompareString(NomeFileExport, "", false) == 0)
			{
				NomeFileExport = Guid.NewGuid().ToString() + ".pdf";
			}
			if (Operators.CompareString(sUtente, "", false) == 0)
			{
				sUtente = WFIUser;
			}
			val2 = iboWebCRW.CrystalReportToPDF(sNomRif, sUtente, objFunctionArguments, dtDati, NomeReport, NomeFileExport, SelectionFormula, HumanReadableSelectionFormula, ReportParams, ForzaStampaAsincrona, ref NomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN StampaEtichetta(string Etichetta, string Filtro, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = SessionEnvironment.ObjLabel.Stampa(Etichetta, Filtro, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected void AddAsyncQueryToApply(string sQuery)
	{
		SessionEnvironment.AddAsyncQueryToApply(sQuery);
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		try
		{
			if (IsInDebugMode)
			{
				sMessaggioLog = PageName.PadRight(60) + sMessaggioLog;
				((LogFileFlushed)PerformanceLog).Write(sMessaggioLog);
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
				((LogFileFlushed)PerformanceLog).Flush();
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

	public virtual void WriteDebugInfo(string Contesto, string Messaggio1, string Messaggio2)
	{
		WriteDebugInfo("", Contesto, Messaggio1, Messaggio2, "", AlwaysInsert: false, "");
	}

	public virtual void WriteDebugInfoAsync(string Contesto, string Messaggio1, string Messaggio2)
	{
		WriteDebugInfoAsync("", Contesto, Messaggio1, Messaggio2, "", AlwaysInsert: false, "");
	}

	public virtual void WriteDebugInfo(string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.WFIConfig.DebugConfig.DebugMode)
		{
			if (Operators.CompareString(Applicazione, "", false) == 0)
			{
				Applicazione = SessionEnvironment.AppApplicationName;
			}
			if (Operators.CompareString(Contesto, "", false) == 0)
			{
				Contesto = "NO_CONTEXT";
			}
			if (Operators.CompareString(IdSessione, "", false) == 0)
			{
				IdSessione = ((Page)this).Session.SessionID;
			}
			if (Operators.CompareString(DebugUser, "", false) == 0)
			{
				DebugUser = SessionEnvironment.WFIConfig.DebugConfig.UserDebug;
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

	public virtual void WriteDebugInfoAsync(string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.WFIConfig.DebugConfig.DebugMode)
		{
			if (Operators.CompareString(Applicazione, "", false) == 0)
			{
				Applicazione = SessionEnvironment.AppApplicationName;
			}
			if (Operators.CompareString(Contesto, "", false) == 0)
			{
				Contesto = "NO_CONTEXT";
			}
			if (Operators.CompareString(IdSessione, "", false) == 0)
			{
				IdSessione = ((Page)this).Session.SessionID;
			}
			if (Operators.CompareString(DebugUser, "", false) == 0)
			{
				DebugUser = SessionEnvironment.WFIConfig.DebugConfig.UserDebug;
			}
			string sQuery = "";
			AppApiContext obj = CreateApiContext();
			string text = Applicazione;
			string text2 = Contesto;
			string text3 = IdSessione;
			string text4 = DebugUser;
			string text5 = "";
			Incasbo.Api.App.WriteDebugInfo.RunProc(obj, text, text2, Messaggio1, Messaggio2, text3, AlwaysInsert, text4, false, ref sQuery, ref text5);
			AddAsyncQueryToApply(sQuery);
		}
	}
}
