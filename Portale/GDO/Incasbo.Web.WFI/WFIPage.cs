using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI.ObjectManager;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIPage : Page, IIboResource, IIboMenuClickable, IIboToolbarClickable, ICallbackEventHandler
{
	protected enum ViewStateSaveMode
	{
		Default,
		InSession
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("_MasterPage")]
	private WFIMaster __MasterPage;

	protected BaseFunctions _BaseFunctions;

	protected string _PaginaChiamante;

	protected IboDictionaryCollection<string, object> _SessionVariable;

	protected bool _IsSessionVariablePersistent;

	protected IboDictionaryCollection<string, object> _PersistedSessionVariable;

	protected bool _PersistedSessionVariableEnabled;

	protected bool _IsInIFrame;

	protected bool _IsAllreadyInIFrame;

	protected object _IFrameReturnObjTag1;

	protected object _IFrameReturnObjTag2;

	protected object _IFrameReturnObjTag3;

	protected string _WFICallbackResult;

	protected bool _WFICallbackEnabled;

	protected string _UserMessage_CssClass;

	protected bool _EnableWFIPostbackData;

	protected bool _TooltipByIdEnabled;

	protected ViewStateSaveMode _ViewStateSaveMode;

	[SpecialName]
	private Dictionary<string, ArrayList> _0024STATIC_0024GetChildControls_00242011282D1282CD_0024result;

	protected virtual WFIMaster _MasterPage
	{
		[CompilerGenerated]
		get
		{
			return __MasterPage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			WFIMaster.CollapserPressedEventHandler obj = _MasterPage_CollapserPressed;
			WFIMaster.HomeButtonPressedEventHandler obj2 = _MasterPage_HomeButtonPressed;
			WFIMaster wFIMaster = __MasterPage;
			if (wFIMaster != null)
			{
				wFIMaster.CollapserPressed -= obj;
				wFIMaster.HomeButtonPressed -= obj2;
			}
			__MasterPage = value;
			wFIMaster = __MasterPage;
			if (wFIMaster != null)
			{
				wFIMaster.CollapserPressed += obj;
				wFIMaster.HomeButtonPressed += obj2;
			}
		}
	}

	public bool IsInFrame => _IsInIFrame;

	public bool IsAllreadyInIFrame => _IsAllreadyInIFrame;

	public WFIMaster MasterPage
	{
		get
		{
			if (_MasterPage == null)
			{
				_MasterPage = (WFIMaster)(object)((Page)this).Master;
			}
			return _MasterPage;
		}
	}

	public IboSessionEnvironment SessionEnvironment => MasterPage.SessionEnvironment;

	public DBConnection DbConn => MasterPage.DbConn;

	public IncasTranslator Translator => MasterPage.Translator;

	public IboWebParam Parametrica => SessionEnvironment.Parametrica;

	public BaseFunctions BaseFunctions
	{
		get
		{
			if (_BaseFunctions == null)
			{
				WFIPage objStandardPage = this;
				_BaseFunctions = new BaseFunctions(ref objStandardPage);
			}
			return _BaseFunctions;
		}
	}

	public string WFIUser => SessionEnvironment.WebUser.WebUserInfo.Codice;

	public string WFIGroup => SessionEnvironment.WebUser.WebUserInfo.Gruppo;

	public string WFIOrganization => SessionEnvironment.WebUser.WebUserInfo.Organizzazione;

	public string WFIOrganizationType => SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneTipoSoggetto;

	public bool ToolbarMenuVisible
	{
		get
		{
			return ((Control)MasterPage.GetToolbarMenu).Visible;
		}
		set
		{
			((Control)MasterPage.GetToolbarMenu).Visible = value;
		}
	}

	public string TitleInTopPanel
	{
		get
		{
			return MasterPage.TitleInTopPanel;
		}
		set
		{
			MasterPage.TitleInTopPanel = value;
		}
	}

	public bool PanelTopHeaderVisible
	{
		get
		{
			return MasterPage.PanelTopHeaderVisible;
		}
		set
		{
			MasterPage.PanelTopHeaderVisible = value;
		}
	}

	protected IboDictionaryCollection<string, object> UserApplicationVariables => SessionEnvironment.UserApplicationVariables();

	public bool CanLogOff
	{
		get
		{
			return MasterPage.CanLogOff;
		}
		set
		{
			MasterPage.CanLogOff = value;
		}
	}

	public bool CanCollapse
	{
		get
		{
			return MasterPage.CanCollapse;
		}
		set
		{
			MasterPage.CanCollapse = value;
		}
	}

	public bool CanChangeFiliale
	{
		get
		{
			return MasterPage.CanChangeFiliale;
		}
		set
		{
			MasterPage.CanChangeFiliale = value;
		}
	}

	public ApplicationDefault ApplicationDefault => (ApplicationDefault)SessionEnvironment.AppDefault;

	public ApplicationParams ApplicationParams => (ApplicationParams)SessionEnvironment.AppParams;

	protected bool FullScreen
	{
		get
		{
			return MasterPage.FullScreen;
		}
		set
		{
			MasterPage.FullScreen = value;
		}
	}

	public virtual string PageName => Strings.Replace(((TemplateControl)this).AppRelativeVirtualPath, ((Control)this).AppRelativeTemplateSourceDirectory, "", 1, -1, (CompareMethod)0);

	public virtual string EntryPoint => PageName.ToUpper();

	public string CallStack => MasterPage.CallStack;

	public IboAppCallStackHandling CallStackHandler => MasterPage.CallStackHandler;

	public IboAppLogHandling LogHandler => MasterPage.LogHandler;

	public Exception LastExceptionOccurred => MasterPage.LastExceptionOccurred;

	public StateBag MyViewState => this.ViewState;

// Proprieta' VB con parametro, convertita in metodi
	protected virtual string get_RedirectSelectCustomOrStandard(string sRedirect)
	{
		if (Operators.CompareString(sRedirect, "", false) != 0)
		{
			return BaseFunctions.FindFormDirMember(sRedirect);
		}
		return "";
	}


	protected bool ToolbarVisible
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			Control val = null;
			Control robjContainerControl = (Control)(object)((Page)this).Form;
			val = BaseFunctions.IboFindControl(ref robjContainerControl, "hidToolbarVisible");
			if (val != null)
			{
				return Operators.CompareString(((HiddenField)val).Value, "True", false) == 0;
			}
			return true;
		}
		set
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			Control val = null;
			Control robjContainerControl = (Control)(object)((Page)this).Form;
			val = BaseFunctions.IboFindControl(ref robjContainerControl, "hidToolbarVisible");
			if (val != null)
			{
				((HiddenField)val).Value = value.ToString();
			}
		}
	}

	public virtual string ResourceName => "SYSTEM." + SessionEnvironment.WebApplicationName.ToUpper() + ".FORMS." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0));

	public virtual string MenuResourceName => "SYSTEM." + SessionEnvironment.WebApplicationName.ToUpper() + ".MENU.";

	public virtual string ToolbarResourceName => "SYSTEM." + SessionEnvironment.WebApplicationName.ToUpper() + "." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0)) + ".TOOLBAR.";

	public PerformanceLog PerformanceLog => SessionEnvironment.PerformanceLog;

	public virtual bool IsInDebugMode => SessionEnvironment.IsInDebugMode;

	protected RadToolTipManager ToolTipManager => MasterPage.ToolTipManager;

	public WFIPage()
	{
		((Page)this).PreInit += Page_PreInit;
		((Control)this).Init += Page_Init;
		((Page)this).InitComplete += Page_InitComplete;
		((Control)this).Load += Page_Load;
		((Page)this).LoadComplete += Page_LoadComplete;
		((Page)this).PreRenderComplete += Page_PreRenderComplete;
		((Control)this).Unload += Page_Unload;
		((Control)this).PreRender += Page_PreRender;
		_PaginaChiamante = "";
		_IsSessionVariablePersistent = false;
		_PersistedSessionVariableEnabled = false;
		_IsInIFrame = false;
		_IsAllreadyInIFrame = false;
		_IFrameReturnObjTag1 = null;
		_IFrameReturnObjTag2 = null;
		_IFrameReturnObjTag3 = null;
		_WFICallbackResult = "";
		_WFICallbackEnabled = false;
		_UserMessage_CssClass = "";
		_EnableWFIPostbackData = false;
		_TooltipByIdEnabled = false;
		_ViewStateSaveMode = ViewStateSaveMode.Default;
	}

	public string TranslateMessage(string vsID, string vsDefault, params string[] vParametri)
	{
		return MasterPage.Translator.TranslateMessage(vsID, vsDefault, vParametri);
	}

	public string TranslateMessage(string vsDefault, params string[] vParametri)
	{
		return MasterPage.Translator.TranslateMessage("XXX", vsDefault, vParametri);
	}

	public string TranslateMessage(string vsID, string vsDefault)
	{
		return MasterPage.Translator.TranslateMessage(vsID, vsDefault, new string[0]);
	}

	public void CallStackAdd()
	{
		MasterPage.CallStackAdd();
	}

	public void CallStackReset()
	{
		MasterPage.CallStackReset();
	}

	public void CallStackRemove()
	{
		MasterPage.CallStackRemove();
	}

	protected void IboResponseRedirect(ref IboAppCallStackHandling robjCallStackHandler, ref string sUrl, bool RegisterPageInQueue = true)
	{
		BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl, RegisterPageInQueue);
	}

	protected void IboResponseRedirect(ref string sUrl)
	{
		IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
		BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
	}

	protected virtual void ReturnToCaller()
	{
		string text = "";
		try
		{
			if (Operators.CompareString(_PaginaChiamante, "", false) == 0)
			{
				_PaginaChiamante = SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
			}
			IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
			IboResponseRedirect(ref robjCallStackHandler, ref _PaginaChiamante);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void ReturnToCaller(string Message)
	{
		ShowNotificationMessage("", Message);
		ReturnToCaller();
	}

	protected virtual void ReturnToCaller(string Message1, string Message2)
	{
		ShowNotificationMessage(Message1, Message2);
		ReturnToCaller();
	}

	protected virtual void ErroreCaricamento(bool bWithReturnToCaller, string sMess)
	{
		string text = "";
		text = TranslateMessage("XXX", "Si è verificato un errore in fase di caricamento Form.");
		if (bWithReturnToCaller)
		{
			WriteErrorMessageWithReturnToCaller("", text, sMess);
		}
		else
		{
			WriteErrorMessage(text + "<br /><br />" + sMess);
		}
	}

	public virtual void WriteErrorMessageWithReturnToCaller(string vsTitle, string vsMessaggio1, string vsMessaggio2)
	{
		ReturnToCaller(vsMessaggio1, vsMessaggio2);
	}

	public virtual void WriteErrorMessageWithReturnToCaller(string vsMessaggio1, string vsMessaggio2)
	{
		WriteErrorMessageWithReturnToCaller("", vsMessaggio1, vsMessaggio2);
	}

	public FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return MasterPage.HandleError(ref objEx, ref rsMess);
	}

	public FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return MasterPage.HandleError(ref objEx, vsMessage, ref rsMess);
	}

	public void SetIncasFocusToControl(string sControlId)
	{
		MasterPage.SetIncasFocusToControl(sControlId);
	}

	public void SetIncasFocusToControl(Control objControl)
	{
		MasterPage.SetIncasFocusToControl(objControl);
	}

	public void IboSelectBox(ref WFIUserSelect UserSel)
	{
		MasterPage.IboSelectBox(ref UserSel);
	}

	protected virtual void MasterUpdateProgressConfig(bool Visibile, int DisplayAfter)
	{
		MasterPage.MasterUpdateProgressConfig(Visibile, DisplayAfter);
	}

	protected virtual void MasterUpdateProgressConfig(bool Visibile, int DisplayAfter, string text)
	{
		MasterPage.MasterUpdateProgressConfig(Visibile, DisplayAfter, text);
	}

	protected virtual void MasterUpdateProgressSetText(string Text)
	{
		MasterPage.MasterUpdateProgressSetText(Text);
	}

	public string RenderControlToHtml(Control ControlToRender)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (ControlToRender.Parent != null)
		{
			Control parent = ControlToRender.Parent;
			int num = ControlToRender.Parent.Controls.IndexOf(ControlToRender);
			ControlToRender.Parent.Controls.Remove(ControlToRender);
			StringBuilder stringBuilder = new StringBuilder();
			StringWriter stringWriter = new StringWriter(stringBuilder);
			HtmlTextWriter val = new HtmlTextWriter((TextWriter)stringWriter);
			ControlToRender.RenderControl(val);
			parent.Controls.AddAt(num, ControlToRender);
			return stringBuilder.ToString();
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		StringWriter stringWriter2 = new StringWriter(stringBuilder2);
		HtmlTextWriter val2 = new HtmlTextWriter((TextWriter)stringWriter2);
		ControlToRender.RenderControl(val2);
		return stringBuilder2.ToString();
	}

	public virtual void WriteErrorMessage(string vsMessaggio)
	{
		WriteErrorMessage(vsMessaggio, ShowAsNotification: true);
	}

	public virtual void WriteErrorMessage(string vsMessaggio, bool ShowAsNotification)
	{
		string text = "";
		if (SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
		{
			text = ((Translator == null) ? "An error has occurred." : Translator.TranslateMessage("XXX", "Si è verificato un errore.", new string[0]));
			WriteErrorMessage(text, vsMessaggio, "", ShowAsNotification);
		}
	}

	public virtual void WriteErrorMessage(string vsMessaggio1, string vsMessaggio2, bool ShowAsNotification)
	{
		WriteErrorMessage(vsMessaggio1, vsMessaggio2, "", ShowAsNotification);
	}

	public virtual void WriteErrorMessage(string vsMessaggio1, string vsMessaggio2)
	{
		WriteErrorMessage(vsMessaggio1, vsMessaggio2, "", ShowAsNotification: true);
	}

	public virtual void WriteErrorMessage(string vsMessaggio1, string vsMessaggio2, string sTitle)
	{
		WriteErrorMessage(vsMessaggio1, vsMessaggio2, sTitle, ShowAsNotification: true);
	}

	public virtual void WriteErrorMessage(string vsMessaggio1, string vsMessaggio2, string sTitle, bool ShowAsNotification, string CssClass)
	{
		if (!vsMessaggio2.ToUpper().Contains("THREAD INTERROTTO") && SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
		{
			SessionEnvironment.UserMessage.Reset();
			SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Critical;
			if ((Operators.CompareString(sTitle, "", false) == 0) & (Operators.CompareString(vsMessaggio1, "", false) == 0))
			{
				sTitle = SessionEnvironment.WebApplicationName;
			}
			SessionEnvironment.UserMessage.Title = sTitle;
			if (Operators.CompareString(CssClass, "", false) != 0)
			{
				SessionEnvironment.UserMessage.CssClass = CssClass;
			}
			else
			{
				SessionEnvironment.UserMessage.CssClass = _UserMessage_CssClass;
			}
			SessionEnvironment.UserMessage.CssClass += " WFIErrorMessage";
			SessionEnvironment.UserMessage.CssClass = SessionEnvironment.UserMessage.CssClass.Trim();
			SessionEnvironment.UserMessage.Message1 = vsMessaggio1;
			SessionEnvironment.UserMessage.Message2 = vsMessaggio2;
			SessionEnvironment.UserMessage.NeedToRefresh = false;
			SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.OkOnly;
			SessionEnvironment.UserMessage.Funzione = "ConfirmOnError";
			SessionEnvironment.UserMessage.DelegateCallBack = ConfirmOnErrorMessageBox;
			SessionEnvironment.UserMessage.ShowAsNotification = ShowAsNotification;
			if (!ShowAsNotification)
			{
				WFIUserMessage UserMess = SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
			}
			else
			{
				WFIUserMessage UserMess = SessionEnvironment.UserMessage;
				ShowNotificationMessage(ref UserMess);
			}
		}
	}

	public virtual void WriteErrorMessage(string vsMessaggio1, string vsMessaggio2, string sTitle, bool ShowAsNotification)
	{
		WriteErrorMessage(vsMessaggio1, vsMessaggio2, sTitle, ShowAsNotification, "");
	}

	public virtual void WriteInfoMessage(string vsMessaggio)
	{
		WriteInfoMessage("", vsMessaggio, "", ShowAsNotification: false);
	}

	public virtual void WriteInfoMessage(string vsMessaggio, bool ShowAsNotification)
	{
		if (SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
		{
			WriteInfoMessage("", vsMessaggio, "", ShowAsNotification);
		}
	}

	public virtual void WriteInfoMessage(string vsMessaggio1, string vsMessaggio2, bool ShowAsNotification)
	{
		WriteInfoMessage(vsMessaggio1, vsMessaggio2, "", ShowAsNotification);
	}

	public virtual void WriteInfoMessage(string vsMessaggio1, string vsMessaggio2)
	{
		WriteInfoMessage(vsMessaggio1, vsMessaggio2, "", ShowAsNotification: false);
	}

	public virtual void WriteInfoMessage(string vsMessaggio1, string vsMessaggio2, string sTitle)
	{
		WriteInfoMessage(vsMessaggio1, vsMessaggio2, sTitle, ShowAsNotification: false);
	}

	public virtual void WriteInfoMessage(string vsMessaggio1, string vsMessaggio2, string sTitle, bool ShowAsNotification)
	{
		WriteInfoMessage(vsMessaggio1, vsMessaggio2, sTitle, ShowAsNotification, "");
	}

	public virtual void WriteInfoMessage(string vsMessaggio1, string vsMessaggio2, string sTitle, bool ShowAsNotification, string CssClass)
	{
		if (SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
		{
			SessionEnvironment.UserMessage.Reset();
			SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Info;
			if ((Operators.CompareString(sTitle, "", false) == 0) & (Operators.CompareString(vsMessaggio1, "", false) == 0))
			{
				sTitle = SessionEnvironment.WebApplicationName;
			}
			SessionEnvironment.UserMessage.Title = sTitle;
			if (Operators.CompareString(CssClass, "", false) != 0)
			{
				SessionEnvironment.UserMessage.CssClass = CssClass;
			}
			else
			{
				SessionEnvironment.UserMessage.CssClass = _UserMessage_CssClass;
			}
			SessionEnvironment.UserMessage.CssClass += " WFIErrorMessage";
			SessionEnvironment.UserMessage.CssClass = SessionEnvironment.UserMessage.CssClass.Trim();
			SessionEnvironment.UserMessage.Message1 = vsMessaggio1;
			SessionEnvironment.UserMessage.Message2 = vsMessaggio2;
			SessionEnvironment.UserMessage.NeedToRefresh = false;
			SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.OkOnly;
			SessionEnvironment.UserMessage.Funzione = "ConfirmOnInfo";
			SessionEnvironment.UserMessage.DelegateCallBack = ConfirmOnErrorMessageBox;
			SessionEnvironment.UserMessage.ShowAsNotification = ShowAsNotification;
			if (!ShowAsNotification)
			{
				WFIUserMessage UserMess = SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
			}
			else
			{
				WFIUserMessage UserMess = SessionEnvironment.UserMessage;
				ShowNotificationMessage(ref UserMess);
			}
		}
	}

	protected virtual FXRETURN ConfirmOnErrorMessageBox(ref string rsmess)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Ok)
		{
			if (Operators.CompareString(SessionEnvironment.UserMessage.Funzione, "ConfirmOnErrorBackToCaller", false) == 0)
			{
				SessionEnvironment.UserMessage.Reset();
				ReturnToCaller();
			}
			else if (Operators.CompareString(SessionEnvironment.UserMessage.Funzione, "ConfirmOnError", false) != 0 && Operators.CompareString(SessionEnvironment.UserMessage.Funzione, "ConfirmOnInfo", false) != 0)
			{
			}
		}
		SessionEnvironment.UserMessage.Reset();
		FXRETURN result = default(FXRETURN);
		return result;
	}

	public void ShowNotificationMessage(ref WFIUserMessage UserMess)
	{
		MasterPage.ShowNotificationMessage(ref UserMess);
	}

	public void ShowNotificationMessage(string Title, string Message)
	{
		SessionEnvironment.ErrorMessage = Message;
		SessionEnvironment.ErrorMessageTitle = Title;
		SessionEnvironment.ErrorMessageCallerPage = PageName;
	}

	public virtual void IboMessageBox_cmdOk01_Click(object sender, EventArgs e)
	{
		SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Conferma;
		IboMessageBox_cmdConfermaYes_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public virtual void IboMessageBox_cmdAnnulla01_Click(object sender, EventArgs e)
	{
		SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Annulla;
		IboMessageBox_cmdAnnullaNo_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void IboMessageBox_cmdAnnullaNo_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		string rsMess = "";
		bool needToRefresh = SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		try
		{
			if (SessionEnvironment.UserMessage.CallBackType == WFIUserMessage.CallBackTypeEnum.CallByNameFunction && Operators.CompareString(SessionEnvironment.UserMessage.CallBackCancelFunctionName, "", false) != 0)
			{
				string callBackCancelFunctionName = SessionEnvironment.UserMessage.CallBackCancelFunctionName;
				object[] array = new object[2] { null, "" };
				array[0] = RuntimeHelpers.GetObjectValue(SessionEnvironment.UserMessage.Parameters);
				Type type = ((object)this).GetType();
				MethodInfo method = type.GetMethod(callBackCancelFunctionName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if ((int)(FXRETURN)method.Invoke(this, array) > 0)
				{
					rsMess = array[1].ToString();
					return;
				}
			}
			SessionEnvironment.UserMessage.Reset();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	public virtual void IboMessageBox_cmdYes_Click(object sender, EventArgs e)
	{
		SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Yes;
		IboMessageBox_cmdConfermaYes_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void IboMessageBox_cmdConfermaYes_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		string sMess = "";
		bool needToRefresh = SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		object obj = null;
		try
		{
			if (SessionEnvironment.UserMessage.CallBackType == WFIUserMessage.CallBackTypeEnum.StandardDelegate)
			{
				FuncToCallAfterConfirm delegateCallBack = SessionEnvironment.UserMessage.DelegateCallBack;
				if ((int)delegateCallBack(ref sMess) > 0 || (needToRefresh && (int)Aggiorna(ref sMess) > 0))
				{
					return;
				}
			}
			else if (SessionEnvironment.UserMessage.CallBackType == WFIUserMessage.CallBackTypeEnum.DelegateWithParameters)
			{
				FuncToCallAfterConfirmWithParameters delegateCallBackWithParameters = SessionEnvironment.UserMessage.DelegateCallBackWithParameters;
				obj = RuntimeHelpers.GetObjectValue(SessionEnvironment.UserMessage.Parameters);
				if ((int)delegateCallBackWithParameters(ref obj, ref sMess) > 0 || (needToRefresh && (int)Aggiorna(ref obj, ref sMess) > 0))
				{
					return;
				}
			}
			else if (SessionEnvironment.UserMessage.CallBackType == WFIUserMessage.CallBackTypeEnum.CallByNameFunction)
			{
				string callBackFunctionName = SessionEnvironment.UserMessage.CallBackFunctionName;
				object[] array = new object[2] { null, "" };
				array[0] = RuntimeHelpers.GetObjectValue(SessionEnvironment.UserMessage.Parameters);
				Type type = ((object)this).GetType();
				MethodInfo method = type.GetMethod(callBackFunctionName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if ((int)(FXRETURN)method.Invoke(this, array) > 0)
				{
					sMess = array[1].ToString();
					return;
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public virtual void IboMessageBox_cmdNo_Click(object sender, EventArgs e)
	{
		SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.No;
		IboMessageBox_cmdAnnullaNo_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public virtual void IboMessageBox_cmdOkOnly_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		string sMess = "";
		bool needToRefresh = SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		try
		{
			SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Ok;
			FuncToCallAfterConfirm delegateCallBack = SessionEnvironment.UserMessage.DelegateCallBack;
			if ((int)delegateCallBack(ref sMess) <= 0 && (!needToRefresh || (int)Aggiorna(ref sMess) <= 0))
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public void IboMessageBox(ref WFIUserMessage UserMess)
	{
		MasterPage.IboMessageBox(ref UserMess);
	}

	public virtual void IboInternalPageDetailView_cmdOkOnly_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		string sMess = "";
		bool needToRefresh = SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		try
		{
			SessionEnvironment.UserInternalPageDetailViewMessage.UserChoice = InternalPageDetailViewMessage.MessageUserChoice.Ok;
			FuncToCallAfterConfirm delegateCallBack = SessionEnvironment.UserInternalPageDetailViewMessage.DelegateCallBack;
			if ((int)delegateCallBack(ref sMess) <= 0 && (!needToRefresh || (int)Aggiorna(ref sMess) <= 0))
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public virtual void IboSelectBox_ConfirmButtonClick(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		string sMess = "";
		bool needToRefresh = SessionEnvironment.UserSelect.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		object obj = null;
		try
		{
			SessionEnvironment.UserSelect.UserDialogResult = WFIUserSelect.SelectUserDialogResult.Conferma;
			if (SessionEnvironment.UserSelect.CallBackType == WFIUserSelect.CallBackTypeEnum.StandardDelegate)
			{
				FuncToCallAfterSelectConfirm delegateCallBack = SessionEnvironment.UserSelect.DelegateCallBack;
				if ((int)delegateCallBack(ref sMess) > 0 || (needToRefresh && (int)AggiornaAfterSelectBoxAction(ref sMess) > 0))
				{
					return;
				}
			}
			else if (SessionEnvironment.UserSelect.CallBackType == WFIUserSelect.CallBackTypeEnum.DelegateWithParameters)
			{
				FuncToCallAfterSelectConfirmWithParameters delegateCallBackWithParameters = SessionEnvironment.UserSelect.DelegateCallBackWithParameters;
				obj = RuntimeHelpers.GetObjectValue(SessionEnvironment.UserSelect.Parameters);
				if ((int)delegateCallBackWithParameters(ref obj, ref sMess) > 0 || (needToRefresh && (int)AggiornaAfterSelectBoxAction(ref obj, ref sMess) > 0))
				{
					return;
				}
			}
			else if (SessionEnvironment.UserSelect.CallBackType == WFIUserSelect.CallBackTypeEnum.CallByNameFunction)
			{
				string callBackFunctionName = SessionEnvironment.UserSelect.CallBackFunctionName;
				object[] array = new object[2] { null, "" };
				array[0] = RuntimeHelpers.GetObjectValue(SessionEnvironment.UserSelect.Parameters);
				Type type = ((object)this).GetType();
				MethodInfo method = type.GetMethod(callBackFunctionName);
				if ((int)(FXRETURN)method.Invoke(this, array) > 0)
				{
					sMess = array[1].ToString();
					return;
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public virtual void IboSelectBox_CancelButtonClick(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		string sMess = "";
		bool needToRefresh = SessionEnvironment.UserSelect.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		try
		{
			SessionEnvironment.UserSelect.UserDialogResult = WFIUserSelect.SelectUserDialogResult.Annulla;
			FuncToCallAfterSelectConfirm delegateCallBack = SessionEnvironment.UserSelect.DelegateCallBack;
			if ((int)delegateCallBack(ref sMess) <= 0 && (!needToRefresh || (int)AggiornaAfterSelectBoxAction(ref sMess) <= 0))
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public virtual FXRETURN AggiornaAfterSelectBoxAction(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			if (Operators.CompareString(SessionEnvironment.UserSelect.Tag, "FILIALE_CHANGED", false) == 0)
			{
				Control controlByName = GetControlByName((Control)(object)this, "lblMasterFilialeApplicazione");
				Label val3 = (Label)(object)((controlByName is Label) ? controlByName : null);
				if (val3 != null)
				{
					val3.Text = "Filiale: " + SessionEnvironment.WebUser.WebUserInfo.FilialeDescrizione;
				}
				Control controlByName2 = GetControlByName((Control)(object)this, "Filiale");
				WebControl val4 = (WebControl)(object)((controlByName2 is WebControl) ? controlByName2 : null);
				string toolTip = (val4.ToolTip = Translator.TranslateMessage("XXX", "Filiale attiva: {0}{1}Cambia la filiale attiva", new string[2]
				{
					SessionEnvironment.WebUser.WebUserInfo.FilialeDescrizione,
					"\r\n"
				}));
				Control controlByName3 = GetControlByName((Control)(object)this, "ThinFiliale");
				WebControl val5 = (WebControl)(object)((controlByName3 is WebControl) ? controlByName3 : null);
				val5.ToolTip = toolTip;
				MasterPage.MasterUpdatePanel.Update();
			}
			MasterPage.ContentUpdatePanel.Update();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN AggiornaAfterSelectBoxAction(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = AggiornaAfterSelectBoxAction(ref rsMess);
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

	public virtual void OpenPopupForm(string Title, Control ContentObject, string Tag)
	{
		OpenPopupForm(Title, ContentObject, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, Tag);
	}

	protected virtual void OpenPopupForm(string Title, Control ContentObject, bool ButtonsVisible, bool ButtonsOkVisible, bool ButtonsAnnullaVisible, string Tag)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		try
		{
			WFIPopupFormInfo popupFormInfo = SessionEnvironment.PopupFormInfo;
			popupFormInfo.Reset();
			popupFormInfo.ButtonsVisible = ButtonsVisible;
			popupFormInfo.ButtonsOkVisible = ButtonsOkVisible;
			popupFormInfo.ButtonsAnnullaVisible = ButtonsAnnullaVisible;
			popupFormInfo.ContentObjectId = ContentObject.ID;
			popupFormInfo.ContentObject = ContentObject;
			popupFormInfo.Tag = Tag;
			popupFormInfo.Title = Title;
			popupFormInfo.Visible = true;
			Control controlByName = GetControlByName((Control)(object)this, "PopupFormBody");
			Control controlByName2 = GetControlByName((Control)(object)this, "PopupFormButtons");
			Button val = (Button)GetControlByName((Control)(object)this, "PopupForm_cmdOk");
			Button val2 = (Button)GetControlByName((Control)(object)this, "PopupForm_cmdAnnulla");
			ModalPopupExtender val3 = (ModalPopupExtender)GetControlByName((Control)(object)this, "PopupForm");
			IIboWebComponent val4 = (IIboWebComponent)GetControlByName((Control)(object)this, "PopupFormCaption");
			Control controlByName3 = GetControlByName((Control)(object)this, "PopupFormGlobalContainer");
			UpdatePanel val5 = (UpdatePanel)GetControlByName((Control)(object)this, "UPPopupForm");
			val.Click += PopupForm_cmdOk_Click;
			val2.Click += PopupForm_cmdAnnulla_Click;
			Control parent = popupFormInfo.ContentObject.Parent;
			foreach (Control control in parent.Controls)
			{
				Control val6 = control;
				val6.Visible = false;
			}
			popupFormInfo.ContentObject.Visible = true;
			controlByName2.Visible = popupFormInfo.ButtonsVisible;
			((Control)val).Visible = popupFormInfo.ButtonsOkVisible;
			((Control)val2).Visible = popupFormInfo.ButtonsAnnullaVisible;
			val4.Text = popupFormInfo.Title;
			SessionEnvironment.PopupFormInfo = popupFormInfo;
			controlByName3.Visible = true;
			val5.Update();
			Control controlByName4 = GetControlByName((Control)(object)this, "UPPopupFormGlobalContainer");
			UpdatePanel val7 = (UpdatePanel)(object)((controlByName4 is UpdatePanel) ? controlByName4 : null);
			if (val7 != null)
			{
				val7.Update();
			}
			else
			{
				MasterPage.ContentUpdatePanel.Update();
			}
			val3.Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void PopupFormReInit()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		try
		{
			WFIPopupFormInfo popupFormInfo = SessionEnvironment.PopupFormInfo;
			if (popupFormInfo.Visible)
			{
				Control controlByName = ((WFIPage)(object)((Control)this).Page).GetControlByName((Control)(object)((Control)this).Page, popupFormInfo.ContentObjectId);
				popupFormInfo.ContentObject = controlByName;
				Control controlByName2 = GetControlByName((Control)(object)this, "PopupFormBody");
				Control controlByName3 = GetControlByName((Control)(object)this, "PopupFormButtons");
				Button val = (Button)GetControlByName((Control)(object)this, "PopupForm_cmdOk");
				Button val2 = (Button)GetControlByName((Control)(object)this, "PopupForm_cmdAnnulla");
				Control controlByName4 = GetControlByName((Control)(object)this, "PopupFormGlobalContainer");
				val.Click += PopupForm_cmdOk_Click;
				val2.Click += PopupForm_cmdAnnulla_Click;
				controlByName3.Visible = popupFormInfo.ButtonsVisible;
				((Control)val).Visible = popupFormInfo.ButtonsOkVisible;
				((Control)val2).Visible = popupFormInfo.ButtonsAnnullaVisible;
				controlByName4.Visible = true;
				popupFormInfo.ContentObject.Visible = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public virtual void PopupForm_cmdOk_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		WFIPopupFormInfo objPopupInfo = SessionEnvironment.PopupFormInfo;
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		ModalPopupExtender val2 = (ModalPopupExtender)GetControlByName((Control)(object)this, "PopupForm");
		val = PopupFormCheckData(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WriteErrorMessage(rsMess);
			val2.Show();
			return;
		}
		val = PopupFormOkClick(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WriteErrorMessage(rsMess);
			val2.Show();
		}
		else if (objPopupInfo.CloseOnConfirm)
		{
			val2.Hide();
		}
		else
		{
			val2.Show();
		}
	}

	public virtual void PopupForm_cmdAnnulla_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		WFIPopupFormInfo objPopupInfo = SessionEnvironment.PopupFormInfo;
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		ModalPopupExtender val2 = (ModalPopupExtender)GetControlByName((Control)(object)this, "PopupForm");
		val = PopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WriteErrorMessage(rsMess);
		}
		if (objPopupInfo.CloseOnExit)
		{
			val2.Hide();
		}
		else
		{
			val2.Show();
		}
	}

	protected virtual FXRETURN PopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			if (objPopupInfo.CloseOnConfirm)
			{
				objPopupInfo.ContentObject.Visible = false;
				objPopupInfo.Visible = false;
				Control controlByName = GetControlByName((Control)(object)this, "PopupFormGlobalContainer");
				controlByName.Visible = false;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN PopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
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

	protected virtual FXRETURN PopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			if (objPopupInfo.CloseOnExit)
			{
				objPopupInfo.ContentObject.Visible = false;
				objPopupInfo.Visible = false;
				Control controlByName = GetControlByName((Control)(object)this, "PopupFormGlobalContainer");
				controlByName.Visible = false;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual void MasterPopupFormOpen(string Title, Control ContentObject, string Tag)
	{
		MasterPopupFormOpen(Title, ContentObject, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, Tag);
	}

	protected virtual void MasterPopupFormOpen(string Title, Control ContentObject, bool ButtonsVisible, bool ButtonsOkVisible, bool ButtonsAnnullaVisible, string Tag)
	{
		MasterPage.MasterPopupFormOpen(Title, ContentObject, ButtonsVisible, ButtonsOkVisible, ButtonsAnnullaVisible, Tag);
	}

	protected virtual void MasterPopupFormOpen(string Title, Control ContentObject, bool ButtonsVisible, bool ButtonsOkVisible, bool ButtonsAnnullaVisible, string Tag, string CssClass)
	{
		MasterPage.MasterPopupFormOpen(Title, ContentObject, ButtonsVisible, ButtonsOkVisible, ButtonsAnnullaVisible, Tag, CssClass);
	}

	public virtual FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
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

	public virtual FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
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

	public virtual FXRETURN MasterPopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
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

	protected void MasterPopupFormUpdate()
	{
		MasterPage.MasterPopupFormUpdate();
	}

	private void Page_PreInit(object sender, EventArgs e)
	{
		try
		{
			SessionEnvironment.ActualWfiPageObject = this;
			PerformanceLogAppend("WFIPage Page_PreInit Event");
			((Control)this).Page.EnableEventValidation = SessionEnvironment.WFIConfig.MasterPageConfig.EnableEventValidation;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void Page_Init(object sender, EventArgs e)
	{
		try
		{
			PerformanceLogAppend("BEgin WFIPage Page_Init Event");
			if (this.Context.Session != null && this.Session.IsNewSession)
			{
				string text = ((Page)this).Request.Headers["Cookie"];
				if (text != null && text.IndexOf("ASP.NET_SessionId") >= 0)
				{
					FormsAuthentication.SignOut();
					((Page)this).Session["Login.msg"] = "Timeout";
					HttpContext.Current.Response.Redirect("~/Default.aspx", true);
				}
			}
			_SessionVariable = SessionEnvironment.SessionVariables[EntryPoint];
			if (!((Page)this).IsPostBack && SessionEnvironment.PersistentSessionVariables.ContainsKey("ResetSessionVariableForActualPage"))
			{
				string text2 = SessionEnvironment.PersistentSessionVariables["ResetSessionVariableForActualPage"].ToString();
				SessionEnvironment.PersistentSessionVariables["ResetSessionVariableForActualPage"] = "";
				if ((_SessionVariable != null) & (Operators.CompareString(text2, "S", false) == 0))
				{
					_SessionVariable = null;
					SessionEnvironment.SessionVariables.Remove(EntryPoint);
				}
			}
			if (_SessionVariable == null)
			{
				_SessionVariable = new IboDictionaryCollection<string, object>();
			}
			SessionEnvironment.SessionVariables[EntryPoint] = _SessionVariable;
			if (_PersistedSessionVariableEnabled)
			{
				_PersistedSessionVariable = SessionEnvironment.SessionVariables["persisted." + EntryPoint];
				if (_PersistedSessionVariable == null)
				{
					_PersistedSessionVariable = new IboDictionaryCollection<string, object>();
					SessionEnvironment.SessionVariables["persisted." + EntryPoint] = _PersistedSessionVariable;
				}
			}
			if (Operators.CompareString(SessionEnvironment.WFIConfig.WFIPageConfig.ViewStateSaveMode, "1", false) == 0)
			{
				_ViewStateSaveMode = ViewStateSaveMode.InSession;
			}
			else if (SessionEnvironment.WFIConfig.WFIPageConfig.ViewStateSaveModePages.Contains(PageName.ToUpper()) & (Operators.CompareString(SessionEnvironment.WFIConfig.WFIPageConfig.ViewStateSaveMode, "2", false) == 0))
			{
				_ViewStateSaveMode = ViewStateSaveMode.InSession;
			}
			if (HttpContext.Current.IsDebuggingEnabled)
			{
				MasterPage.ScriptManager.AsyncPostBackTimeout = SessionEnvironment.WFIConfig.WFIPageConfig.DebugAsyncTimeout;
			}
			else
			{
				MasterPage.ScriptManager.AsyncPostBackTimeout = SessionEnvironment.WFIConfig.WFIPageConfig.ReleaseAsyncTimeout;
			}
			PerformanceLogAppend("End WFIPage Page_Init Event");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Page_InitComplete(object sender, EventArgs e)
	{
		PerformanceLogAppend("WFIPage Page_InitComplete Event");
	}

	private void Page_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Invalid comparison between Unknown and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Invalid comparison between Unknown and I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			PerformanceLogAppend("Begin Load WFI page");
			if ((Operators.CompareString(((Control)this).Page.Title.ToUpper(), "Login".ToUpper(), false) != 0) | ((Operators.CompareString(((Control)this).Page.Title.ToUpper(), "Login".ToUpper(), false) == 0) & SessionEnvironment.Initialized))
			{
				if (!SessionEnvironment.Initialized)
				{
					IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
					string sUrl = "~/WFI/Form/WFLogin2.aspx";
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				}
				else
				{
					val2 = SessionEnvironment.StartEnvironment(ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
				}
				_MasterPage = (WFIMaster)(object)((Page)this).Master;
				PerformanceLogAppend("Begin Load Menu");
				IboWebMenu objMenu = MasterPage.MasterMenuItem;
				if (objMenu != null && (((int)((Control)objMenu).ViewStateMode == 2) | (((int)((Control)objMenu).ViewStateMode != 2) & !((Control)this).Page.IsPostBack)) && ((Control)objMenu).Visible && (((int)((Control)objMenu).ViewStateMode == 2) | !((Page)this).IsPostBack))
				{
					val2 = SessionEnvironment.BuildMenu(ref objMenu, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
				}
				IboWebMenuTlk objMenu2 = MasterPage.MasterMenuItemTlk;
				if (objMenu2 != null && (((int)((Control)objMenu2).ViewStateMode == 2) | (((int)((Control)objMenu2).ViewStateMode != 2) & !((Control)this).Page.IsPostBack)) && ((RadDataBoundControl)objMenu2).Visible && (((int)((Control)objMenu2).ViewStateMode == 2) | !((Page)this).IsPostBack))
				{
					val2 = SessionEnvironment.BuildMenu(ref objMenu2, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
				}
				PerformanceLogAppend("End Load Menu");
				if (!((Control)this).Page.IsPostBack)
				{
					if ((object)((Page)this).Request.UrlReferrer != null)
					{
						_PaginaChiamante = ((Page)this).Request.UrlReferrer.ToString();
					}
					else
					{
						_PaginaChiamante = "";
					}
					SetDetailPanelIDOnIncasControl((Control)(object)this);
					string text = ((Page)this).Request.QueryString["IdSessione"] ?? "";
					if (Operators.CompareString(text, "", false) != 0 && Operators.CompareString(text, ((Page)this).Session.SessionID, false) != 0)
					{
						LogOff();
						HttpContext.Current.Response.Redirect("~/Default.aspx", true);
						throw new ApplicationException(TranslateMessage("XXX", "Sessione scaduta"));
					}
				}
			}
			WFIPage objStandardPage = this;
			_BaseFunctions = new BaseFunctions(ref objStandardPage);
			PopupFormReInit();
			((Page)this).MaintainScrollPositionOnPostBack = true;
			_IsInIFrame = Operators.CompareString(((Page)this).Request.QueryString["IsInIFrame"] ?? "", "S", false) == 0;
			_IsAllreadyInIFrame = Operators.CompareString(((Page)this).Request.QueryString["IsAllreadyInIFrame"] ?? "", "S", false) == 0;
			if (_IsInIFrame | _IsAllreadyInIFrame)
			{
				string text2 = ((HtmlControl)MasterPage.BodyTag).Attributes["Class"] ?? "";
				((HtmlControl)MasterPage.BodyTag).Attributes["Class"] = text2 + " IsInIframe";
				AttributeCollection attributes;
				(attributes = ((HtmlControl)MasterPage.BodyTag).Attributes)["Class"] = string.Concat(attributes["Class"], " " + ((Page)this).Request.QueryString["IsInIFrameBodyClass"]);
				((HtmlControl)MasterPage.BodyTag).Attributes["Class"] = ((HtmlControl)MasterPage.BodyTag).Attributes["Class"].Trim();
			}
			if (SessionEnvironment.WFIConfig.WFIPageConfig.LastActivityRealTime && !((Control)this).Page.IsPostBack && SessionEnvironment.WebUser != null && Math.Abs(DateAndTime.DateDiff((DateInterval)9, DateAndTime.Now, SessionEnvironment.LastActivity, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > SessionEnvironment.WFIConfig.WFIPageConfig.LastActivityRealTimeInterval)
			{
				SessionEnvironment.LastActivity = DateAndTime.Now;
				string text3 = "UPDATE WFI_UTENTI SET LastActivity=" + DbConn.SQLFormatDate((eTipoData)2, SessionEnvironment.LastActivity) + " WHERE CODICE=" + DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
				text3 = text3 + "AND LASTACTIVITY <= " + DbConn.SQLFormatDate((eTipoData)2, SessionEnvironment.LastActivity);
				AddAsyncQueryToApply(text3);
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
			PerformanceLogAppend("End Load WFI page");
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void Page_LoadComplete(object sender, EventArgs e)
	{
		try
		{
			if (_WFICallbackEnabled)
			{
				string callbackEventReference = ((Control)this).Page.ClientScript.GetCallbackEventReference((Control)(object)this, "arguments", "WFI.Callback_ReceiveServerData", "context");
				string text = "function _WFICallback_SendToServer(arguments, context) { " + callbackEventReference + "} ;";
				((Control)this).Page.ClientScript.RegisterClientScriptBlock(((object)this).GetType(), "_WFICallback_SendToServer", text, true);
			}
			if (_EnableWFIPostbackData)
			{
				((Control)MasterPage.UpdatePanelWFIPostbackData).Visible = true;
			}
			PerformanceLogAppend("WFIPage LoadComplete Event");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Page_PreRenderComplete(object sender, EventArgs e)
	{
		try
		{
			PerformanceLogAppend("WFIPage Page_PreRenderComplete Event");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Page_Unload(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			SessionEnvironment.ActualWfiPageObject = null;
			try
			{
				PerformanceLogAppend("Begin WFIPage Page_Unload Event");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (SessionEnvironment.Initialized)
			{
				val2 = SessionEnvironment.StopEnvironment(ref rsMess);
			}
			try
			{
				PerformanceLogAppend("End WFIPage Page_Unload Event");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			_BaseFunctions = null;
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
		}
	}

	private void Page_PreRender(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			CallStackAdd();
			PerformanceLogAppend("BEGIN WFI prerender event");
			if (Translator != null && SessionEnvironment.WFIConfig.TranslationConfig.TranslationIsActive)
			{
				if (!((Page)this).IsPostBack && (int)TranslateForm(ref rsMess) > 0)
				{
					return;
				}
				if (!SessionEnvironment.WFIConfig.TranslationConfig.FormTranslationSave || (int)MessageTranslationSave(ref rsMess) > 0)
				{
				}
				try
				{
					Translator.ClearUntranslatedItemDictionary();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				PerformanceLogAppend("Translator Activity TimeSpan: " + Translator.GetActivityTime());
			}
			if (Operators.CompareString(SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Type.ToUpper(), "JQUERY", false) == 0 && SessionEnvironment.WFIConfig.AutoTooltipifyConfig.TooltipByIdEnabled && _TooltipByIdEnabled)
			{
				Dictionary<string, string> dictionary = (((Page)this).IsPostBack ? ((Dictionary<string, string>)_SessionVariable["TooltipDictionary"]) : new Dictionary<string, string>());
				foreach (Control allIboWebComponentControl in GetAllIboWebComponentControls((Control)(object)this))
				{
					Control val2 = allIboWebComponentControl;
					IIboWebComponent val3 = (IIboWebComponent)(object)((val2 is IIboWebComponent) ? val2 : null);
					if (val3 != null && Operators.CompareString(val3.TitleId, "", false) != 0 && Operators.CompareString(val3.Tooltip, "", false) != 0)
					{
						if (dictionary.ContainsKey(val2.ClientID))
						{
							dictionary.Remove(val2.ClientID);
						}
						dictionary.Add(val2.ClientID, val3.Tooltip);
						val3.Tooltip = "";
					}
				}
				_SessionVariable["TooltipDictionary"] = (object)dictionary;
			}
			((Control)_MasterPage.WebToolbar).Visible = ToolbarVisible;
			val = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("END WFI prerender event");
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	protected override void RaisePostBackEvent(IPostBackEventHandler sourceControl, string eventArgument)
	{
		PerformanceLogAppend("BEGIN WFIPage RaisePostBackEvent");
		this.RaisePostBackEvent(sourceControl, eventArgument);
		PerformanceLogAppend("END WFIPage RaisePostBackEvent");
	}

	protected virtual UpdatePanel getParentUpdatePanel(Control ctrl)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (ctrl != null)
		{
			if (ctrl is UpdatePanel)
			{
				return (UpdatePanel)ctrl;
			}
			return getParentUpdatePanel(ctrl.Parent);
		}
		return null;
	}

	protected virtual void SetDetailPanelIDOnIncasControl(Control parent)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		foreach (Control childControl in GetChildControls(parent))
		{
			Control val = childControl;
			IboWebDetailPanel val2 = (IboWebDetailPanel)(object)((val is IboWebDetailPanel) ? val : null);
			if (val2 == null)
			{
				continue;
			}
			foreach (Control childControl2 in GetChildControls(val))
			{
				Control val3 = childControl2;
				IIboWebComponent val4 = (IIboWebComponent)(object)((val3 is IIboWebComponent) ? val3 : null);
				if (val4 != null)
				{
					val4.DetailPanelId = ((Control)val2).ID;
				}
			}
		}
	}

	public virtual ArrayList GetChildControls(Control parent)
	{
		if (_0024STATIC_0024GetChildControls_00242011282D1282CD_0024result == null)
		{
			_0024STATIC_0024GetChildControls_00242011282D1282CD_0024result = new Dictionary<string, ArrayList>();
		}
		if (!_0024STATIC_0024GetChildControls_00242011282D1282CD_0024result.ContainsKey(parent.ID))
		{
			ArrayList childControlsRecalculate = GetChildControlsRecalculate(parent);
			_0024STATIC_0024GetChildControls_00242011282D1282CD_0024result.Add(parent.ID, childControlsRecalculate);
			return childControlsRecalculate;
		}
		return _0024STATIC_0024GetChildControls_00242011282D1282CD_0024result[parent.ID];
	}

	protected virtual ArrayList GetChildControlsRecalculate(Control parent)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		foreach (Control control in parent.Controls)
		{
			Control val = control;
			arrayList.Add(val);
			arrayList.AddRange(GetChildControlsRecalculate(val));
		}
		return arrayList;
	}

	protected virtual ArrayList GetIIboWebComponentControls(Control parent)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		IboWebDetailPanel val = (IboWebDetailPanel)(object)((parent is IboWebDetailPanel) ? parent : null);
		if (val != null)
		{
			foreach (Control childControl in GetChildControls(parent))
			{
				Control val2 = childControl;
				IIboWebComponent val3 = (IIboWebComponent)(object)((val2 is IIboWebComponent) ? val2 : null);
				if (val3 != null && Operators.CompareString(val3.DetailPanelId.ToUpper(), ((Control)val).ID.ToUpper(), false) == 0)
				{
					arrayList.Add(val2);
				}
			}
		}
		else
		{
			foreach (Control childControl2 in GetChildControls(parent))
			{
				Control val4 = childControl2;
				IIboWebComponent val5 = (IIboWebComponent)(object)((val4 is IIboWebComponent) ? val4 : null);
				if (val5 != null && Operators.CompareString(val5.DetailPanelId, "", false) == 0)
				{
					arrayList.Add(val4);
				}
			}
		}
		return arrayList;
	}

	protected virtual ArrayList GetAllIIboWebComponentControls(Control parent)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		foreach (Control childControl in GetChildControls(parent))
		{
			Control val = childControl;
			IIboWebComponent val2 = (IIboWebComponent)(object)((val is IIboWebComponent) ? val : null);
			if (val2 != null)
			{
				arrayList.Add(val);
			}
		}
		return arrayList;
	}

	protected virtual IIboWebComponent GetIIboWebComponentByFieldName(Control parent, string FieldName)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		IIboWebComponent result = null;
		foreach (IIboWebComponent iIboWebComponentControl in GetIIboWebComponentControls(parent))
		{
			IIboWebComponent val = iIboWebComponentControl;
			if (Operators.CompareString(val.FieldName.ToUpper(), FieldName.ToUpper(), false) == 0)
			{
				result = val;
				break;
			}
		}
		return result;
	}

	protected virtual ArrayList GetAllIboWebComponentControls(Control parent)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		foreach (Control childControl in GetChildControls(parent))
		{
			Control val = childControl;
			if (val is IIboWebComponent)
			{
				arrayList.Add(val);
			}
			else if (val is IboWebToolbar)
			{
				arrayList.Add(val);
			}
			else if (val is IboGridView)
			{
				arrayList.Add(val);
			}
		}
		return arrayList;
	}

	public virtual Control GetControlByName(Control parent, string sName)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		Control val = null;
		foreach (Control control in parent.Controls)
		{
			Control val2 = control;
			val = ((val2.ID == null) ? GetControlByName(val2, sName) : ((Operators.CompareString(val2.ID.ToUpper(), sName.ToUpper(), false) != 0) ? GetControlByName(val2, sName) : val2));
			if (val != null)
			{
				break;
			}
		}
		return val;
	}

	protected virtual Control[] GetControlsByNameUsingLeftLike(Control parent, string sName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		checked
		{
			Control[] array = default(Control[]);
			int num = default(int);
			Control[] controlsByNameUsingLeftLike = default(Control[]);
			foreach (Control control in parent.Controls)
			{
				Control val = control;
				if (val.ID != null)
				{
					if (Operators.CompareString(Strings.Mid(val.ID.ToUpper(), 1, Strings.Len(sName)), sName.ToUpper(), false) == 0)
					{
						array = (Control[])Utils.CopyArray((Array)array, (Array)new Control[num + 1]);
						array[num] = val;
						num++;
					}
					else
					{
						controlsByNameUsingLeftLike = GetControlsByNameUsingLeftLike(val, sName);
					}
				}
				else
				{
					controlsByNameUsingLeftLike = GetControlsByNameUsingLeftLike(val, sName);
				}
				if (controlsByNameUsingLeftLike != null)
				{
					int upperBound = controlsByNameUsingLeftLike.GetUpperBound(0);
					for (int i = 0; i <= upperBound; i++)
					{
						array = (Control[])Utils.CopyArray((Array)array, (Array)new Control[num + 1]);
						array[num] = controlsByNameUsingLeftLike[i];
						num++;
					}
				}
			}
			return array;
		}
	}

	protected virtual Control[] GetControlsByNameUsingRightLike(Control parent, string sName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		checked
		{
			Control[] array = default(Control[]);
			int num = default(int);
			Control[] controlsByNameUsingRightLike = default(Control[]);
			foreach (Control control in parent.Controls)
			{
				Control val = control;
				if (val.ID != null)
				{
					if (Operators.CompareString(Strings.Right(val.ID.ToUpper(), Strings.Len(sName)), sName.ToUpper(), false) == 0)
					{
						array = (Control[])Utils.CopyArray((Array)array, (Array)new Control[num + 1]);
						array[num] = val;
						num++;
					}
					else
					{
						controlsByNameUsingRightLike = GetControlsByNameUsingRightLike(val, sName);
					}
				}
				else
				{
					controlsByNameUsingRightLike = GetControlsByNameUsingRightLike(val, sName);
				}
				if (controlsByNameUsingRightLike != null)
				{
					int upperBound = controlsByNameUsingRightLike.GetUpperBound(0);
					for (int i = 0; i <= upperBound; i++)
					{
						array = (Control[])Utils.CopyArray((Array)array, (Array)new Control[num + 1]);
						array[num] = controlsByNameUsingRightLike[i];
						num++;
					}
				}
			}
			return array;
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

	protected FXRETURN ZipFiles(string[] sFiles, ref string ZipFileName, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		ZipOutputStream val2 = null;
		ZipEntry val3 = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (Operators.CompareString(ZipFileName, "", false) == 0)
				{
					ZipFileName = sFiles[0] + ".zip";
				}
				fileStream = new FileStream(ZipFileName, FileMode.CreateNew, FileAccess.Write);
				val2 = new ZipOutputStream((Stream)fileStream);
				int num = 0;
				while (true)
				{
					if (num < sFiles.Length)
					{
						string text = sFiles[num];
						if (File.Exists(text))
						{
							fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
							byte[] array = new byte[(int)fileStream.Length - 1 + 1];
							int num2 = fileStream.Read(array, 0, array.Length);
							if (num2 != array.Length)
							{
								rsMess = TranslateMessage("XXX", "Errore nella lettura del file.");
								break;
							}
							fileStream.Close();
							val3 = new ZipEntry(new FileInfo(text).Name);
							val2.PutNextEntry(val3);
							val2.Write(array, 0, array.Length);
						}
						num++;
						continue;
					}
					val2.Finish();
					((DeflaterOutputStream)val2).Close();
					fileStream.Close();
					val = (FXRETURN)0;
					break;
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
	}

	protected string GenerateTempFileName(string sNomeFile)
	{
		string text = SessionEnvironment.WebApplicationDownloadDir + sNomeFile;
		return text.Replace("*", Guid.NewGuid().ToString());
	}

	public virtual FXRETURN PdfMerge(StringCollection PdfFiles, bool SegnaFileComeDaCancellare, ref string PdfMergedFile, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		byte[] PdfBytes = new byte[0];
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val = BaseFunctions.PdfMerge(PdfFiles, ref PdfBytes, ref rsmess);
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

	public virtual AppApiContext CreateApiContext(bool WithCloneConnection = false)
	{
		return SessionEnvironment.CreateApiContext(WithCloneConnection);
	}

	protected virtual FXRETURN ReleaseMemory(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_SessionVariable != null && !_IsSessionVariablePersistent)
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
			if (_PersistedSessionVariable != null && _PersistedSessionVariable.Count == 0)
			{
				SessionEnvironment.SessionVariables.Remove("persisted." + EntryPoint);
				_PersistedSessionVariable = null;
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

	protected virtual FXRETURN SetFocusOnFirstControl(Control ctrlParent, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IIboWebComponent iIboWebComponentControl in GetIIboWebComponentControls(ctrlParent))
			{
				IIboWebComponent val3 = iIboWebComponentControl;
				if ((Operators.CompareString(val3.FieldName, "", false) != 0) & !val3.ReadOnly & val3.Visible)
				{
					SetIncasFocusToControl((Control)val3);
					break;
				}
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

	public virtual void mnuMainItemClick(object sender, IboMenuEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			CallStackAdd();
			val2 = MainMenuItemClick(e.Funzione, e.CodiceVoce, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}

	void IIboMenuClickable.mnuMainItemClick(object sender, IboMenuEventArgs e)
	{
		//ILSpy generated this explicit interface implementation from .override directive in mnuMainItemClick
		this.mnuMainItemClick(sender, e);
	}

	public virtual void mnuMainItemClick(object sender, IboMenuEventArgsTlk e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			CallStackAdd();
			val2 = MainMenuItemClick(e.Funzione, e.CodiceVoce, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}

	void IIboMenuClickable.mnuMainItemClick(object sender, IboMenuEventArgsTlk e)
	{
		//ILSpy generated this explicit interface implementation from .override directive in mnuMainItemClick
		this.mnuMainItemClick(sender, e);
	}

	protected virtual FXRETURN MainMenuItemClick(string sFunzione, string sCodiceVoce, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Invalid comparison between Unknown and I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string sRedirect = "";
		IboResourceManager iboResourceManager = new IboResourceManager();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val2 = iboResourceManager.Resource_Check(MenuResourceName + sCodiceVoce, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				checked
				{
					switch (Strings.Left(sFunzione.ToUpper(), 6))
					{
					case "LOGOFF":
					{
						string sUrl = "";
						if (SessionEnvironment.Session["PageRedirectAfterLogOff"] != null)
						{
							sUrl = SessionEnvironment.Session["PageRedirectAfterLogOff"].ToString();
						}
						if (Operators.CompareString(sUrl, "", false) == 0)
						{
							sUrl = "~/WFI/Form/Redirector.aspx";
						}
						IboSessionEnvironment sessionEnvironment5 = SessionEnvironment;
						string sRisorsa = SessionEnvironment.WebApplicationName.ToUpper();
						string rsMess = "";
						sessionEnvironment5.LogRisorseAzioneInserisci(sRisorsa, "LOGOUT", "UI", "", "", ref rsMess);
						LogOff();
						IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
						break;
					}
					case "CALFUN":
					{
						string vsFunction = Strings.Left(Strings.Mid(sFunzione.ToUpper(), 8), 6);
						sRedirect = Strings.Mid(sFunzione.ToUpper(), 15);
						FunctionArguments functionArguments2 = new FunctionArguments("CALLFUNC", vsFunction);
						((Page)this).Session["FunctionArgs"] = functionArguments2;
						IboSessionEnvironment sessionEnvironment2 = SessionEnvironment;
						string rsMess = "";
						sessionEnvironment2.UpdateMenuUsage(sCodiceVoce, ref rsMess);
						IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
						break;
					}
					case "NEWGRD":
						text = sFunzione;
						val2 = NewGridParser(text, ref sRedirect, ref rsmess);
						if (unchecked((int)val2) <= 0)
						{
							IboSessionEnvironment sessionEnvironment6 = SessionEnvironment;
							string rsMess = "";
							sessionEnvironment6.UpdateMenuUsage(sCodiceVoce, ref rsMess);
							IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
							IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
							break;
						}
						goto end_IL_0020;
					case "GOTPAG":
					{
						IboSessionEnvironment sessionEnvironment4 = SessionEnvironment;
						string rsMess = "";
						sessionEnvironment4.UpdateMenuUsage(sCodiceVoce, ref rsMess);
						sRedirect = Strings.Mid(sFunzione.ToUpper(), 8);
						sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
						IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
						break;
					}
					case "GOTOSF":
					{
						text = Strings.Mid(sFunzione.ToUpper(), 8);
						string[] array = Strings.Split(text, ";", -1, (CompareMethod)0);
						string text4 = BaseFunctions.OnlyAspxPageName(array[array.Count() - 1].ToUpper()).ToUpper();
						text4 = text4.Split(new char[1] { '?' })[0];
						SessionEnvironment.SessionVariables.Remove(text4);
						SessionEnvironment.SessionVariables.Add(text4, new IboDictionaryCollection<string, object>());
						int num2 = array.Count() - 2;
						for (int j = 0; j <= num2; j++)
						{
							string[] array2 = Strings.Split(array[j], "=", -1, (CompareMethod)0);
							SessionEnvironment.SessionVariables[text4][array2[0].ToUpper()] = (object)array2[1];
						}
						FunctionArguments functionArguments3 = new FunctionArguments("", "");
						if (SessionEnvironment.SessionVariables[text4].ContainsKey("CONTEXT"))
						{
							functionArguments3.Context = SessionEnvironment.SessionVariables[text4]["CONTEXT"].ToString();
						}
						if (!SessionEnvironment.SessionVariables[text4].ContainsKey("FORMMODE"))
						{
							SessionEnvironment.SessionVariables[text4]["FORMMODE"] = (object)"";
						}
						sRedirect = array[array.Count() - 1];
						((Page)this).Session.Add("FunctionArgs", (object)functionArguments3);
						IboSessionEnvironment sessionEnvironment3 = SessionEnvironment;
						string rsMess = "";
						sessionEnvironment3.UpdateMenuUsage(sCodiceVoce, ref rsMess);
						sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
						IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
						break;
					}
					case "GOTOPF":
					{
						text = Strings.Mid(sFunzione.ToUpper(), 8);
						string[] array = Strings.Split(text, ";", -1, (CompareMethod)0);
						string text3 = BaseFunctions.OnlyAspxPageName(array[array.Count() - 1].ToUpper()).ToUpper();
						text3 = text3.Split(new char[1] { '?' })[0];
						SessionEnvironment.SessionVariables.Remove(text3);
						SessionEnvironment.SessionVariables.Add(text3, new IboDictionaryCollection<string, object>());
						int num = array.Count() - 2;
						for (int i = 0; i <= num; i++)
						{
							string[] array2 = Strings.Split(array[i], "=", -1, (CompareMethod)0);
							SessionEnvironment.SessionVariables[text3][array2[0].ToUpper()] = (object)array2[1];
						}
						FunctionArguments functionArguments = new FunctionArguments("", "");
						functionArguments.Context = "PRINTFILTER";
						if (SessionEnvironment.SessionVariables[text3].ContainsKey("CONTEXT"))
						{
							functionArguments.Context = SessionEnvironment.SessionVariables[text3]["CONTEXT"].ToString();
						}
						else
						{
							SessionEnvironment.SessionVariables[text3]["CONTEXT"] = (object)functionArguments.Context;
						}
						if (!SessionEnvironment.SessionVariables[text3].ContainsKey("FORMMODE"))
						{
							SessionEnvironment.SessionVariables[text3]["FORMMODE"] = (object)"";
						}
						sRedirect = array[array.Count() - 1];
						sRedirect = ((!sRedirect.Contains("?")) ? (sRedirect + "?NomRep=" + SessionEnvironment.SessionVariables[text3]["REPORT"].ToString()) : (sRedirect + "&NomRep=" + SessionEnvironment.SessionVariables[text3]["REPORT"].ToString()));
						((Page)this).Session.Add("FunctionArgs", (object)functionArguments);
						IboSessionEnvironment sessionEnvironment = SessionEnvironment;
						string rsMess = "";
						sessionEnvironment.UpdateMenuUsage(sCodiceVoce, ref rsMess);
						sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
						IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
						break;
					}
					}
					val = (FXRETURN)0;
				}
			}
			end_IL_0020:;
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

	protected void GotoDialogPage(string Pagina, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables)
	{
		if (Operators.CompareString(Pagina, "", false) == 0)
		{
			return;
		}
		if (Pagina.StartsWith("/"))
		{
			Pagina = "~" + Pagina;
		}
		SetDialogPageContext(Pagina, Context, Modalita, Params, ResetSessionVariables);
		string text = Strings.Replace(Pagina, "%APPNAME%", "Custom", 1, -1, (CompareMethod)0);
		string[] array = text.Split(new char[1] { '?' });
		text = array[0];
		try
		{
			if (!File.Exists(HttpContext.Current.Server.MapPath(text)))
			{
				text = Strings.Replace(Pagina, "%APPNAME%", SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = Strings.Replace(Pagina, "%APPNAME%", SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
			ProjectData.ClearProjectError();
		}
		if (array.GetUpperBound(0) >= 1)
		{
			text = text + "?" + array[1];
		}
		Pagina = BaseFunctions.FindFormDirMember(text);
		IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref Pagina);
	}

	public void OpenDialogPage(string Pagina, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables)
	{
		GotoDialogPage(Pagina, Context, Modalita, Params, ResetSessionVariables);
	}

	protected void SetDialogPageContext(string Pagina, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables)
	{
		if (Operators.CompareString(Pagina, "", false) == 0)
		{
			return;
		}
		string text = BaseFunctions.OnlyAspxPageName(Pagina.Split(new char[1] { '?' })[0]).ToUpper();
		if (ResetSessionVariables)
		{
			SessionEnvironment.SessionVariables.Remove(text);
			SessionEnvironment.SessionVariables.Add(text, new IboDictionaryCollection<string, object>());
		}
		else if (!SessionEnvironment.SessionVariables.ContainsKey(text))
		{
			SessionEnvironment.SessionVariables.Add(text, new IboDictionaryCollection<string, object>());
		}
		SessionEnvironment.SessionVariables[text]["CONTEXT"] = (object)Context;
		SessionEnvironment.SessionVariables[text]["FORMMODE"] = (object)Modalita;
		if (Params != null)
		{
			foreach (string key in Params.Keys)
			{
				SessionEnvironment.SessionVariables[text][key] = RuntimeHelpers.GetObjectValue(Params[key]);
			}
		}
		FunctionArguments functionArguments = new FunctionArguments(Context, Modalita);
		if (Operators.CompareString(text.ToUpper(), PageName.ToUpper(), false) == 0)
		{
			FunctionArguments functionArguments2 = (FunctionArguments)((Page)this).Session["FunctionArgs"];
			string callerQueryString = functionArguments2.CallerQueryString;
			string callerPath = functionArguments2.CallerPath;
			functionArguments.CallerPath = callerPath;
			functionArguments.CallerQueryString = callerQueryString;
		}
		((Page)this).Session.Add("FunctionArgs", (object)functionArguments);
	}

	public virtual FXRETURN OpenDbPage(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string ObjectManagerName, string ModalitaAccessoDati, string Argomento1, string Argomento2, string Argomento3, string Argomento4, string Argomento5, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ModalitaAccessoDati, "", false) == 0)
			{
				ModalitaAccessoDati = "MODIFICA";
			}
			if ((int)GetKeyDataFromArray(ref CampiChiave, ref ValoriCampiChiave, ref robjData, ref robjKey, ref rsmess) <= 0)
			{
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				robjFunctionArguments.Argomento1 = Argomento1;
				robjFunctionArguments.Argomento2 = Argomento2;
				robjFunctionArguments.Argomento3 = Argomento3;
				robjFunctionArguments.Argomento4 = Argomento4;
				robjFunctionArguments.Argomento5 = Argomento5;
				switch (ModalitaAccessoDati)
				{
				case "INSERIMENTO":
					if ((int)SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName).Inserisci(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "MODIFICA":
					if ((int)SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName).Modifica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "VISUALIZZAZIONE":
					if ((int)SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName).Visualizza(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "DUPLICAZIONE":
					if ((int)SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName).Duplica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				default:
					rsmess = TranslateMessage("XXX", "Modalità di accesso ai dati '{0}' non valida", ModalitaAccessoDati);
					goto end_IL_000e;
				}
				val = (FXRETURN)0;
			}
			end_IL_000e:;
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
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN NewGridParser(string sComando, ref string sRedirect, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Invalid comparison between Unknown and I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		try
		{
			CallStackAdd();
			string[] array = Strings.Split(sComando, ";", -1, (CompareMethod)0);
			if (Operators.CompareString(array[0].ToUpper(), "NEWGRDTLK", false) == 0)
			{
				sRedirect = "~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + array[1];
			}
			else
			{
				sRedirect = "~/WFI/Form/WFStandardGrid.aspx?NomRif=" + array[1];
			}
			if (array.GetUpperBound(0) > 1)
			{
				text = array[2];
				text = Strings.Replace(text, "%USER%", SessionEnvironment.WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%GROUP%", SessionEnvironment.WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%ORGANIZZAZIONE%", SessionEnvironment.WebUser.WebUserInfo.Organizzazione, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%FILIALE%", SessionEnvironment.WebUser.WebUserInfo.Filiale, 1, -1, (CompareMethod)0);
				sRedirect = sRedirect + "&WA=" + text;
			}
			if (array.GetUpperBound(0) > 2)
			{
				text = array[3];
				text = Strings.Replace(text, "%USER%", SessionEnvironment.WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%GROUP%", SessionEnvironment.WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%ORGANIZZAZIONE%", SessionEnvironment.WebUser.WebUserInfo.Organizzazione, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%FILIALE%", SessionEnvironment.WebUser.WebUserInfo.Filiale, 1, -1, (CompareMethod)0);
				sRedirect = sRedirect + "&DESC=" + text;
			}
			if (array.GetUpperBound(0) > 3)
			{
				text = array[4];
				text = Strings.Replace(text, "%USER%", SessionEnvironment.WebUser.WebUserInfo.Codice, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%GROUP%", SessionEnvironment.WebUser.WebUserInfo.Gruppo, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%ORGANIZZAZIONE%", SessionEnvironment.WebUser.WebUserInfo.Organizzazione, 1, -1, (CompareMethod)0);
				text = Strings.Replace(text, "%FILIALE%", SessionEnvironment.WebUser.WebUserInfo.Filiale, 1, -1, (CompareMethod)0);
				sRedirect = sRedirect + "&CAPT=" + Strings.Replace(text, "%", "%25", 1, -1, (CompareMethod)0);
			}
			if (array.GetUpperBound(0) > 4)
			{
				text = array[4];
				if (Operators.CompareString(text, "", false) != 0)
				{
					sRedirect = sRedirect + "&ForceResetFilter=" + text;
				}
			}
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	public void LogOff()
	{
		((Page)this).Session.Abandon();
		FormsAuthentication.SignOut();
		((Page)this).Session["Session.Abandon"] = true;
	}

	public virtual void ToolbarItemClick(object sender, IboWebToolbarEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		IboResourceManager iboResourceManager = new IboResourceManager();
		try
		{
			CallStackAdd();
			val2 = iboResourceManager.Resource_Check(ToolbarResourceName + "STANDARD." + e.CommandName.ToUpper(), ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			e.Managed = true;
			if (Operators.CompareString(e.CommandName, IboWebToolbar.Aggiorna, false) == 0)
			{
				val2 = Aggiorna(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Ricerca, false) == 0)
			{
				val2 = Ricerca(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaFiltri, false) == 0)
			{
				val2 = AnnullaFiltri(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaPrefiltri, false) == 0)
			{
				val2 = AnnullaPrefiltri(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Visualizza, false) == 0)
			{
				val2 = Visualizza(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Inserisci, false) == 0)
			{
				val2 = Inserisci(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Modifica, false) == 0)
			{
				val2 = Modifica(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Cancella, false) == 0)
			{
				val2 = Cancella(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Duplica, false) == 0)
			{
				val2 = Duplica(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.Stampa, false) == 0)
			{
				val2 = Stampa(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.StampaVeloce, false) == 0)
			{
				val2 = StampaVeloce(ref rsMess);
			}
			else if (Operators.CompareString(e.CommandName, IboWebToolbar.EsportazioneDati, false) == 0)
			{
				val2 = EsportazioneDati(ref rsMess);
			}
			else
			{
				val2 = CallFunction(e, ref rsMess);
				e.Managed = false;
			}
			MasterPage.ContentUpdatePanel.Update();
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			e.Managed = false;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	void IIboToolbarClickable.ToolbarItemClick(object sender, IboWebToolbarEventArgs e)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ToolbarItemClick
		this.ToolbarItemClick(sender, e);
	}

	public virtual FXRETURN Aggiorna(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			MasterPage.ContentUpdatePanel.Update();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Aggiorna(ref object obj, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = Aggiorna(ref rsMess);
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

	public virtual FXRETURN AnnullaFiltri(ref string rsMess)
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

	public virtual FXRETURN AnnullaPrefiltri(ref string rsMess)
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

	public virtual FXRETURN Ricerca(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Visualizza(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Inserisci(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Modifica(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN CallFunction(IboWebToolbarEventArgs e, ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Cancella(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Duplica(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Stampa(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN StampaVeloce(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN EsportazioneDati(ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN GetSQLWhereFromKeyData(ref DataKeyFieldCollection robjData, ref string rsSQLWhere, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsSQLWhere = "";
			rsSQLWhere = robjData.GetAllElementSqlWhere();
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

	public virtual FXRETURN GetKeyDataFromGrid(ref IboGridView grdGriglia, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
		return GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria, ref rsMess);
	}

	public virtual FXRETURN GetKeyDataFromArray(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataKeyFieldCollection robjData, ref DataKeyFieldValues[] robjKey, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldValues dataKeyFieldValues = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (robjData == null)
				{
					robjData = new DataKeyFieldCollection();
				}
				else
				{
					robjData.Clear();
				}
				for (int i = 0; i < CampiChiave.Count(); i++)
				{
					dataKeyFieldValues = new DataKeyFieldValues(CampiChiave[i], ValoriCampiChiave[i].GetType().ToString());
					robjData.Add(dataKeyFieldValues);
					robjData.Item(i).FieldValuesAdd(RuntimeHelpers.GetObjectValue(ValoriCampiChiave[i]));
				}
				for (int i = 0; i < CampiChiave.Count(); i++)
				{
					dataKeyFieldValues = new DataKeyFieldValues(CampiChiave[i], ValoriCampiChiave[i].GetType().ToString());
					robjKey = (DataKeyFieldValues[])Utils.CopyArray((Array)robjKey, (Array)new DataKeyFieldValues[i + 1]);
					robjKey[i] = dataKeyFieldValues;
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
	}

	public virtual FXRETURN GetKeyDataFromArray(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, ref DataKeyFieldCollection robjData, ref DataKeyFieldValues[] robjKey, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldValues dataKeyFieldValues = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (robjData == null)
				{
					robjData = new DataKeyFieldCollection();
				}
				else
				{
					robjData.Clear();
				}
				int num = 0;
				foreach (object[] item in ValoriCampiChiave)
				{
					for (int i = 0; i < CampiChiave.Count(); i++)
					{
						if (!robjData.Contains(CampiChiave[i].ToUpper()))
						{
							dataKeyFieldValues = new DataKeyFieldValues(CampiChiave[i], item[i].GetType().ToString());
							robjData.Add(dataKeyFieldValues);
						}
						object[] array = item;
						for (int j = 0; j < array.Length; j++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(array[j]);
							robjData.Item(i).FieldValuesAdd(RuntimeHelpers.GetObjectValue(objectValue));
						}
					}
					num++;
				}
				for (int i = 0; i < CampiChiave.Count(); i++)
				{
					dataKeyFieldValues = new DataKeyFieldValues(CampiChiave[i], ValoriCampiChiave[0][i].GetType().ToString());
					robjKey = (DataKeyFieldValues[])Utils.CopyArray((Array)robjKey, (Array)new DataKeyFieldValues[i + 1]);
					robjKey[i] = dataKeyFieldValues;
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
	}

	public virtual FXRETURN GetKeyDataFromGrid(ref IboGridView grdGriglia, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, ref DataKeyFieldValues[] robjKey, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldValues dataKeyFieldValues = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (bSelezioneObbligatoria && grdGriglia.GetSelectedIndices().Length == 0)
				{
					rsMess = TranslateMessage("XXX", "E' Necessario selezionare almeno un record.");
					val = (FXRETURN)4;
				}
				else
				{
					if (robjData == null)
					{
						robjData = new DataKeyFieldCollection();
					}
					else
					{
						robjData.Clear();
					}
					int i = default(int);
					int j;
					for (; i < grdGriglia.GetSelectedIndices().Count(); i++)
					{
						((GridView)grdGriglia).SelectedIndex = grdGriglia.GetSelectedIndices()[i];
						for (j = 0; j < ((GridView)grdGriglia).DataKeyNames.Length; j++)
						{
							if (i == 0)
							{
								dataKeyFieldValues = new DataKeyFieldValues(((GridView)grdGriglia).DataKeyNames[j], objGridInfo.get_CampoTipo(((GridView)grdGriglia).DataKeyNames[j]));
								robjData.Add(dataKeyFieldValues);
							}
							robjData.Item(((GridView)grdGriglia).DataKeyNames[j]).FieldValuesAdd(RuntimeHelpers.GetObjectValue(((GridView)grdGriglia).DataKeys[((GridView)grdGriglia).SelectedIndex].Values[((GridView)grdGriglia).DataKeyNames[j]]));
						}
					}
					j = 0;
					robjKey = null;
					for (; j < ((GridView)grdGriglia).DataKeyNames.Length; j++)
					{
						dataKeyFieldValues = new DataKeyFieldValues(((GridView)grdGriglia).DataKeyNames[j], objGridInfo.get_CampoTipo(((GridView)grdGriglia).DataKeyNames[j]));
						robjKey = (DataKeyFieldValues[])Utils.CopyArray((Array)robjKey, (Array)new DataKeyFieldValues[j + 1]);
						robjKey[j] = dataKeyFieldValues;
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
				result = val;
				CallStackRemove();
			}
			return result;
		}
	}

	public virtual FXRETURN GetKeyDataFromGrid(ref IboGridView grdGriglia, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, bSelezioneObbligatoria: true, ref rsMess);
	}

	public virtual FXRETURN GetKeyDataFromGrid(ref RadGrid grdGrigliaTlk, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
		return GetKeyDataFromGrid(ref grdGrigliaTlk, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria, ref rsMess);
	}

	public virtual FXRETURN GetKeyDataFromGrid(ref RadGrid grdGrigliaTlk, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, ref DataKeyFieldValues[] robjKey, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldValues dataKeyFieldValues = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (bSelezioneObbligatoria && grdGrigliaTlk.SelectedItems.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "E' Necessario selezionare almeno un record.");
					val = (FXRETURN)4;
				}
				else
				{
					if (robjData == null)
					{
						robjData = new DataKeyFieldCollection();
					}
					else
					{
						robjData.Clear();
					}
					int i = default(int);
					int j;
					for (; i < grdGrigliaTlk.SelectedItems.Count; i++)
					{
						for (j = 0; j < grdGrigliaTlk.MasterTableView.DataKeyNames.Length; j++)
						{
							if (i == 0)
							{
								dataKeyFieldValues = new DataKeyFieldValues(grdGrigliaTlk.MasterTableView.DataKeyNames[j], objGridInfo.get_CampoTipo(grdGrigliaTlk.MasterTableView.DataKeyNames[j]));
								robjData.Add(dataKeyFieldValues);
							}
							robjData.Item(grdGrigliaTlk.MasterTableView.DataKeyNames[j]).FieldValuesAdd(RuntimeHelpers.GetObjectValue(((GridEditableItem)(GridDataItem)grdGrigliaTlk.SelectedItems[i]).GetDataKeyValue(grdGrigliaTlk.MasterTableView.DataKeyNames[j])));
						}
					}
					j = 0;
					robjKey = null;
					for (; j < grdGrigliaTlk.MasterTableView.DataKeyNames.Length; j++)
					{
						dataKeyFieldValues = new DataKeyFieldValues(grdGrigliaTlk.MasterTableView.DataKeyNames[j], objGridInfo.get_CampoTipo(grdGrigliaTlk.MasterTableView.DataKeyNames[j]));
						robjKey = (DataKeyFieldValues[])Utils.CopyArray((Array)robjKey, (Array)new DataKeyFieldValues[j + 1]);
						robjKey[j] = dataKeyFieldValues;
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
				result = val;
				CallStackRemove();
			}
			return result;
		}
	}

	public virtual FXRETURN GetKeyDataFromGrid(ref RadGrid grdGrigliaTlk, ref IboGridInfo objGridInfo, ref DataKeyFieldCollection robjData, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return GetKeyDataFromGrid(ref grdGrigliaTlk, ref objGridInfo, ref robjData, bSelezioneObbligatoria: true, ref rsMess);
	}

	public void ProgressbarShow(ref WFIProgressbarMessage progressbarMessage)
	{
		MasterPage.ProgressbarShow(ref progressbarMessage);
	}

	public void ProgressbarShow()
	{
		WFIMaster masterPage = MasterPage;
		IboSessionEnvironment sessionEnvironment;
		WFIProgressbarMessage progressbarMessage = (sessionEnvironment = SessionEnvironment).ProgressbarInfo;
		masterPage.ProgressbarShow(ref progressbarMessage);
		sessionEnvironment.ProgressbarInfo = progressbarMessage;
	}

	public virtual FXRETURN ProgressbarAnnulla(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			MasterPage.ContentUpdatePanel.Update();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN ProgressbarFine(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			MasterPage.ContentUpdatePanel.Update();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static WFIProgressbarClientInfo WaitingForProgressbarResponse(string Param1)
	{
		WFIProgressbarClientInfo wFIProgressbarClientInfo = new WFIProgressbarClientInfo();
		checked
		{
			string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2];
			IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
			IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
			wFIProgressbarClientInfo.Title = iboSessionEnvironment.ProgressbarInfo.Title;
			wFIProgressbarClientInfo.MainMessage = iboSessionEnvironment.ProgressbarInfo.MainMessage.Replace("\r\n", "<br/>");
			wFIProgressbarClientInfo.DetailMessage = iboSessionEnvironment.ProgressbarInfo.DetailMessage.Replace("\r\n", "<br/>");
			if (decimal.Compare(iboSessionEnvironment.ProgressbarInfo.Percentage, 100m) > 0)
			{
				iboSessionEnvironment.ProgressbarInfo.Percentage = 100m;
			}
			wFIProgressbarClientInfo.Percentage = iboSessionEnvironment.ProgressbarInfo.Percentage;
			wFIProgressbarClientInfo.PercentageVisible = iboSessionEnvironment.ProgressbarInfo.PercentageVisible;
			wFIProgressbarClientInfo.ProgressbarType = iboSessionEnvironment.ProgressbarInfo.ProgressbarType;
			wFIProgressbarClientInfo.StartDateTime = iboSessionEnvironment.ProgressbarInfo.StartDateTime;
			wFIProgressbarClientInfo.TimeElapsed = (int)Math.Round((DateAndTime.Now - iboSessionEnvironment.ProgressbarInfo.StartDateTime).TotalSeconds);
			return wFIProgressbarClientInfo;
		}
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static WFIEventClientInfoList RealTimeEventPolling(string EventParam)
	{
		WFIEventClientInfoList wFIEventClientInfoList = new WFIEventClientInfoList();
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		if (Operators.CompareString(EventParam.ToUpper(), "KEEP_ALIVE", false) == 0)
		{
			WFIEventClientInfo wFIEventClientInfo = new WFIEventClientInfo();
			wFIEventClientInfo.Id = Guid.NewGuid().ToString();
			wFIEventClientInfo.Message1 = "OK";
			wFIEventClientInfo.EndDateTime = DateAndTime.Now;
			wFIEventClientInfoList.Add(wFIEventClientInfo);
		}
		else if (Operators.CompareString(EventParam.ToUpper(), "MY_COMMAND", false) == 0)
		{
			WFIEventClientInfo wFIEventClientInfo2 = new WFIEventClientInfo();
			wFIEventClientInfo2.Id = Guid.NewGuid().ToString();
			wFIEventClientInfo2.Message1 = "RISPOSTA 1";
			wFIEventClientInfo2.Message2 = "RISPOSTA 2";
			wFIEventClientInfo2.Message3 = "RISPOSTA 3";
			wFIEventClientInfo2.EndDateTime = DateAndTime.Now;
			wFIEventClientInfoList.Add(wFIEventClientInfo2);
		}
		return wFIEventClientInfoList;
	}

	[ScriptMethod]
	[WebMethod]
	public static List<string> GetSearchItems(string prefixText, int count)
	{
		return WFIMaster.GetSearchItems(prefixText, count);
	}

	public virtual FXRETURN CallDirectFunction(string sCodiceVoce, bool bSearchByActionCode, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Invalid comparison between Unknown and I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Invalid comparison between Unknown and I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			if (bSearchByActionCode)
			{
				if (Operators.CompareString(sCodiceVoce, "", false) == 0)
				{
					goto IL_0457;
				}
				DataRow[] array = SessionEnvironment.FunctionListDatatable.Select("ACTIONCODE='" + sCodiceVoce + "'");
				if (array.Count() > 0)
				{
					text = ((!((Operators.CompareString(Strings.Left(array[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) != 0) & (Operators.CompareString(Strings.Left(array[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTOSF", false) != 0))) ? array[0]["FUNZIONE"].ToString() : ("GOTPAG;" + array[0]["FUNZIONE"].ToString()));
					val2 = MainMenuItemClick(text, array[0]["Codice"].ToString(), ref rsmess);
					if ((int)val2 <= 0)
					{
						goto IL_0457;
					}
					val = val2;
				}
				else
				{
					rsmess = TranslateMessage("XXX", "Il codice azione richiesto ({0}) non esiste", sCodiceVoce);
				}
			}
			else
			{
				if (Operators.CompareString(sCodiceVoce.ToUpper(), "#TETRIS", false) == 0)
				{
					string sUrl = "~/WFI/Varie/Tetris.aspx";
					IboResponseRedirect(ref sUrl);
					goto IL_0457;
				}
				if (Operators.CompareString(sCodiceVoce.ToUpper(), "#CAMPOMINATO", false) == 0)
				{
					string sUrl2 = "~/WFI/Varie/campo_Minato/CampoMinato.aspx";
					IboResponseRedirect(ref sUrl2);
					goto IL_0457;
				}
				if (Operators.CompareString(sCodiceVoce.ToUpper(), "#SPACEINVADERS", false) == 0)
				{
					string sUrl3 = "~/WFI/Varie/SpaceInvaders/SpaceInvaders.aspx";
					IboResponseRedirect(ref sUrl3);
					goto IL_0457;
				}
				if (Operators.CompareString(sCodiceVoce.ToUpper(), "#FROGGER", false) == 0)
				{
					string sUrl4 = "~/WFI/Varie/Frogger/Frogger.aspx";
					IboResponseRedirect(ref sUrl4);
					goto IL_0457;
				}
				if (Operators.CompareString(sCodiceVoce.ToUpper(), "#RACER", false) == 0)
				{
					string sUrl5 = "~/WFI/Varie/Racer/Racer.aspx";
					IboResponseRedirect(ref sUrl5);
					goto IL_0457;
				}
				if (sCodiceVoce.StartsWith("MENU."))
				{
					string sCodiceVoce2 = sCodiceVoce.Substring(5);
					DataRow[] array2 = SessionEnvironment.FunctionListDatatable.Select("CODICE='" + sCodiceVoce + "'");
					text = ((!((Operators.CompareString(Strings.Left(array2[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) != 0) & (Operators.CompareString(Strings.Left(array2[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTOSF", false) != 0))) ? array2[0]["FUNZIONE"].ToString() : ("GOTPAG;" + array2[0]["FUNZIONE"].ToString()));
					val2 = MainMenuItemClick(text, sCodiceVoce2, ref rsmess);
					if ((int)val2 <= 0)
					{
						goto IL_0457;
					}
					val = val2;
				}
				else
				{
					DataRow[] array3 = SessionEnvironment.FunctionListDatatable.Select("DESCRIZIONE LIKE '%" + sCodiceVoce + "%' Or SearchTag Like '%" + sCodiceVoce + "%'", "Descrizione");
					if (array3.Count() <= 0)
					{
						goto IL_0457;
					}
					text = ((!((Operators.CompareString(Strings.Left(array3[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTPAG", false) != 0) & (Operators.CompareString(Strings.Left(array3[0]["FUNZIONE"].ToString(), 6).ToUpper(), "GOTOSF", false) != 0))) ? array3[0]["FUNZIONE"].ToString() : ("GOTPAG;" + array3[0]["FUNZIONE"].ToString()));
					val2 = MainMenuItemClick(text, sCodiceVoce, ref rsmess);
					if ((int)val2 <= 0)
					{
						goto IL_0457;
					}
					val = val2;
				}
			}
			goto end_IL_000b;
			IL_0457:
			val = (FXRETURN)0;
			end_IL_000b:;
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

	protected virtual FXRETURN TranslateForm(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (SessionEnvironment.Initialized)
			{
				text = SessionEnvironment.AppLanguage;
				text2 = ((TemplateControl)this).AppRelativeVirtualPath.Replace("~/", "");
				foreach (IIboWebComponent allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
				{
					IIboWebComponent val2 = allIIboWebComponentControl;
					if (!val2.Translate)
					{
						continue;
					}
					if ((((object)val2).GetType() == typeof(IboDropDownList)) | (((object)val2).GetType() == typeof(IboWebRadioButtonList)) | (((object)val2).GetType() == typeof(IboWebCheckBoxList)))
					{
						foreach (ListItem item in ((ListControl)val2).Items)
						{
							ListItem val3 = item;
							val3.Text = TranslateMessage(text2, val3.Text);
						}
					}
					else if (((object)val2).GetType() == typeof(IboWebComboTlk))
					{
						foreach (RadComboBoxItem item2 in (StateManagedCollection)((RadComboBox)(IboWebComboTlk)val2).Items)
						{
							RadComboBoxItem val4 = item2;
							val4.Text = TranslateMessage(text2, val4.Text);
						}
					}
					else if (!((((object)val2).GetType() == typeof(IboWebNumeric)) | (((object)val2).GetType() == typeof(IboWebNumericTlk)) | (((object)val2).GetType() == typeof(IboWebDate)) | (((object)val2).GetType() == typeof(IboWebTextBox)) | (((object)val2).GetType() == typeof(IboWebDate2))) && Operators.CompareString(val2.Text, "", false) != 0)
					{
						val2.Text = Translator.TranslateMessage(text2, val2.Text, new string[0]);
					}
					if (Operators.CompareString(val2.Tooltip, "", false) != 0)
					{
						val2.Tooltip = Translator.TranslateMessage(text2, val2.Tooltip, new string[0]);
					}
				}
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

	protected virtual FXRETURN MessageTranslationSave(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!SessionEnvironment.Initialized)
			{
				goto IL_01a0;
			}
			List<TranslatableItem> untranslatedItemDictionary = Translator.UntranslatedItemDictionary;
			foreach (TranslatableItem item in Translator.UntranslatedItemDictionary)
			{
				text += "INSERT INTO WFI_TranslatorDictionary (Lingua, Contesto, Testo) SELECT ";
				text = text + DbConn.SQLFormatString(item.Language) + ", ";
				text = text + DbConn.SQLFormatString(item.Contesto) + ", ";
				text = text + DbConn.SQLFormatString(item.Text) + " ";
				text = text + DbConn.FromDual() + " ";
				text += "WHERE NOT EXISTS (SELECT 1 FROM WFI_TranslatorDictionary T ";
				text = text + "WHERE T.Lingua=" + DbConn.SQLFormatString(item.Language) + " ";
				text = text + "AND T.Contesto=" + DbConn.SQLFormatString(item.Contesto) + " ";
				text = text + "AND T.Testo=" + DbConn.SQLFormatString(item.Text) + ");";
			}
			if (Operators.CompareString(text, "", false) == 0 || (int)DbConn.SqlExec(text, ref rsMess) <= 0)
			{
				goto IL_01a0;
			}
			goto end_IL_000b;
			IL_01a0:
			val = (FXRETURN)0;
			end_IL_000b:;
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

	public void OpenIframe(string sUrl, string Tag)
	{
		MasterPage.OpenIframe(sUrl, Tag);
	}

	public void OpenIframe(string sUrl, string Tag, string title, string IFrameCSSCustomClass)
	{
		MasterPage.OpenIframe(sUrl, Tag, title, WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, IFrameCSSCustomClass, CloseButton: false);
	}

	public void OpenIframe(string sUrl, string Tag, string title, WFIMaster.IFrameDimension IFrameCSSClass)
	{
		MasterPage.OpenIframe(sUrl, Tag, title, IFrameCSSClass, "", CloseButton: false);
	}

	public void OpenIframe(string sUrl, string Tag, string title, string IFrameCSSCustomClass, bool CloseButton)
	{
		MasterPage.OpenIframe(sUrl, Tag, title, WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, IFrameCSSCustomClass, CloseButton);
	}

	public void OpenIframe(string sUrl, string Tag, string title, WFIMaster.IFrameDimension IFrameCSSClass, bool CloseButton)
	{
		MasterPage.OpenIframe(sUrl, Tag, title, IFrameCSSClass, "", CloseButton);
	}

	public void OpenIframe(IframeInfo objIframeInfo)
	{
		MasterPage.OpenIframe(objIframeInfo);
	}

	public virtual void CloseIFrame()
	{
		MasterPage.CloseIFrame();
	}

	public virtual void ReturnFromIFrame(object objTag1)
	{
		MasterPage.ReturnFromIFrame(ref objTag1);
	}

	public virtual FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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

	public virtual void OpenGridInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva, string IFrameCSSCustomClass)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGrid.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		OpenIframe(text, Tag, title, IFrameCSSCustomClass);
	}

	public virtual void OpenGridInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva, WFIMaster.IFrameDimension IFrameCSSClass)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGrid.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		OpenIframe(text, Tag, title, IFrameCSSClass);
	}

	public virtual void OpenGridInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva)
	{
		OpenGridInIFrame(NomRif, Tag, title, WhereAggiuntiva, WFIMaster.IFrameDimension.Standard);
	}

	public virtual void OpenGridInIFrame(string NomRif, string Tag, string title)
	{
		OpenGridInIFrame(NomRif, Tag, title, "", WFIMaster.IFrameDimension.Standard);
	}

	public virtual void OpenGridInIFrame(string NomRif, string Tag)
	{
		OpenGridInIFrame(NomRif, Tag, "", "", WFIMaster.IFrameDimension.Standard);
	}

	public virtual void OpenGridTlkInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva, string IFrameCSSCustomClass)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGridTlk.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		OpenIframe(text, Tag, title, IFrameCSSCustomClass);
	}

	public virtual void OpenGridTlkInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva, WFIMaster.IFrameDimension IFrameCSSClass)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGridTlk.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=COMBO&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		OpenIframe(text, Tag, title, IFrameCSSClass);
	}

	public virtual void OpenGridTlkInIFrame(string NomRif, string Tag, string title, string WhereAggiuntiva)
	{
		OpenGridTlkInIFrame(NomRif, Tag, title, WhereAggiuntiva, WFIMaster.IFrameDimension.Standard);
	}

	public virtual void OpenGridTlkInIFrame(string NomRif, string Tag, string title)
	{
		OpenGridTlkInIFrame(NomRif, Tag, title, "", WFIMaster.IFrameDimension.Standard);
	}

	public virtual void OpenGridTlkInIFrame(string NomRif, string Tag)
	{
		OpenGridTlkInIFrame(NomRif, Tag, "", "", WFIMaster.IFrameDimension.Standard);
	}

	protected virtual void OpenGridOnlyForViewInIFrame(string NomRif, string title, string WhereAggiuntiva, string IFrameCSSCustomClass)
	{
		string sUrl = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=ONLYVIEW&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		OpenIframe(sUrl, "", title, IFrameCSSCustomClass, CloseButton: true);
	}

	protected virtual void OpenGridOnlyForViewInIFrame(string NomRif, string title, string WhereAggiuntiva, WFIMaster.IFrameDimension IFrameCSSClass)
	{
		string sUrl = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&GridMode=ONLYVIEW&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		OpenIframe(sUrl, "", title, IFrameCSSClass, CloseButton: true);
	}

	protected virtual void OpenGridOnlyForViewInIFrameTlk(string NomRif, string title, string WhereAggiuntiva, string IFrameCSSCustomClass)
	{
		string sUrl = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=ONLYVIEW&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		OpenIframe(sUrl, "", title, IFrameCSSCustomClass, CloseButton: true);
	}

	protected virtual void OpenGridOnlyForViewInIFrameTlk(string NomRif, string title, string WhereAggiuntiva, WFIMaster.IFrameDimension IFrameCSSClass)
	{
		string sUrl = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&GridMode=ONLYVIEW&IsInIFrame=S&IsInIFrameBodyClass=IsInIframeScrollable&ForceResetFilter=S&WA=" + WhereAggiuntiva, "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		OpenIframe(sUrl, "", title, IFrameCSSClass, CloseButton: true);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, ObjectManagerName, ModalitaAccessoDati, "", ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, string IframeBodyClass, ref string rsmess)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, ObjectManagerName, ModalitaAccessoDati, IframeBodyClass, null, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, string IframeBodyClass, Dictionary<string, object> Params, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			IframeInfo iframeInfo = new IframeInfo();
			iframeInfo.Params = Params;
			iframeInfo.IFrameTag = IFrameTag;
			iframeInfo.IFrameTitle = IFrameTitle;
			iframeInfo.IFrameDimension = IFrameDimension;
			iframeInfo.IFrameDimensionCustomCssClass = IFrameDimensionCustomCssClass;
			iframeInfo.IframeBodyClass = IframeBodyClass;
			if (iframeInfo.AutomaticVerticalResizing)
			{
				SetIframeHeightAutoResize();
			}
			iframeInfo.IFrameCaller = EntryPoint;
			val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ModalitaAccessoDati, ObjectManagerName, iframeInfo, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string ModalitaAccessoDati, string ObjectManagerName, IframeInfo IFramInfo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Invalid comparison between Unknown and I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Invalid comparison between Unknown and I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ModalitaAccessoDati, "", false) == 0)
			{
				ModalitaAccessoDati = "MODIFICA";
			}
			if ((int)GetKeyDataFromArray(ref CampiChiave, ref ValoriCampiChiave, ref robjData, ref robjKey, ref rsmess) <= 0)
			{
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				robjFunctionArguments.OpenInIFrame = true;
				robjFunctionArguments.IFrameTag = IFramInfo.IFrameTag;
				robjFunctionArguments.Argomento1 = IFramInfo.IFrameTitle;
				robjFunctionArguments.Argomento2 = IFramInfo.IFrameDimension;
				robjFunctionArguments.Argomento3 = IFramInfo.IFrameDimensionCustomCssClass;
				robjFunctionArguments.Argomento4 = IFramInfo.IframeBodyClass;
				if (IFramInfo.AutomaticVerticalResizing)
				{
					SetIframeHeightAutoResize();
				}
				AbstractObjectManager manager = SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName);
				string text = "";
				text = ModalitaAccessoDati switch
				{
					"INSERIMENTO" => manager.RedirectToIns, 
					"MODIFICA" => manager.RedirectToMod, 
					"VISUALIZZAZIONE" => manager.RedirectToVis, 
					"DUPLICAZIONE" => manager.RedirectToDup, 
					_ => manager.RedirectToDel, 
				};
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = manager.RedirectTo;
				}
				string key = BaseFunctions.OnlyAspxPageName(text.Split(new char[1] { '?' })[0]).ToUpper();
				SessionEnvironment.SessionVariables.Remove(key);
				SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
				if (IFramInfo.Params != null)
				{
					foreach (string key2 in IFramInfo.Params.Keys)
					{
						SessionEnvironment.SessionVariables[key][key2] = RuntimeHelpers.GetObjectValue(IFramInfo.Params[key2]);
					}
				}
				switch (ModalitaAccessoDati)
				{
				case "INSERIMENTO":
					if ((int)manager.Inserisci(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "MODIFICA":
					if ((int)manager.Modifica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "VISUALIZZAZIONE":
					if ((int)manager.Visualizza(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "DUPLICAZIONE":
					if ((int)manager.Duplica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				default:
					if ((int)manager.Cancella(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				}
				val = (FXRETURN)0;
			}
			end_IL_000e:;
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string IFrameTag, string IFrameTitle, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string IFrameTag, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "IFRAME", "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, ObjectManagerName, ModalitaAccessoDati, "", ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, string IframeBodyClass, ref string rsmess)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, ObjectManagerName, ModalitaAccessoDati, IframeBodyClass, null, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, string IframeBodyClass, Dictionary<string, object> Params, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			IframeInfo iframeInfo = new IframeInfo();
			iframeInfo.Params = Params;
			iframeInfo.IFrameTag = IFrameTag;
			iframeInfo.IFrameTitle = IFrameTitle;
			iframeInfo.IFrameDimension = IFrameDimension;
			iframeInfo.IFrameDimensionCustomCssClass = IFrameDimensionCustomCssClass;
			iframeInfo.IframeBodyClass = IframeBodyClass;
			if (iframeInfo.AutomaticVerticalResizing)
			{
				SetIframeHeightAutoResize();
			}
			iframeInfo.IFrameCaller = EntryPoint;
			val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ModalitaAccessoDati, ObjectManagerName, iframeInfo, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string ModalitaAccessoDati, string ObjectManagerName, IframeInfo IFramInfo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Invalid comparison between Unknown and I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Invalid comparison between Unknown and I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ModalitaAccessoDati, "", false) == 0)
			{
				ModalitaAccessoDati = "MODIFICA";
			}
			if ((int)GetKeyDataFromArray(ref CampiChiave, ref ValoriCampiChiave, ref robjData, ref robjKey, ref rsmess) <= 0)
			{
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				robjFunctionArguments.OpenInIFrame = true;
				robjFunctionArguments.IFrameTag = IFramInfo.IFrameTag;
				robjFunctionArguments.Argomento1 = IFramInfo.IFrameTitle;
				robjFunctionArguments.Argomento2 = IFramInfo.IFrameDimension;
				robjFunctionArguments.Argomento3 = IFramInfo.IFrameDimensionCustomCssClass;
				robjFunctionArguments.Argomento4 = IFramInfo.IframeBodyClass;
				if (IFramInfo.AutomaticVerticalResizing)
				{
					SetIframeHeightAutoResize();
				}
				AbstractObjectManager manager = SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName);
				string text = "";
				text = ModalitaAccessoDati switch
				{
					"INSERIMENTO" => manager.RedirectToIns, 
					"MODIFICA" => manager.RedirectToMod, 
					"VISUALIZZAZIONE" => manager.RedirectToVis, 
					"DUPLICAZIONE" => manager.RedirectToDup, 
					_ => manager.RedirectToDel, 
				};
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = manager.RedirectTo;
				}
				string key = BaseFunctions.OnlyAspxPageName(text.Split(new char[1] { '?' })[0]).ToUpper();
				SessionEnvironment.SessionVariables.Remove(key);
				SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
				if (IFramInfo.Params != null)
				{
					foreach (string key2 in IFramInfo.Params.Keys)
					{
						SessionEnvironment.SessionVariables[key][key2] = RuntimeHelpers.GetObjectValue(IFramInfo.Params[key2]);
					}
				}
				switch (ModalitaAccessoDati)
				{
				case "INSERIMENTO":
					if ((int)manager.Inserisci(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "MODIFICA":
					if ((int)manager.Modifica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "VISUALIZZAZIONE":
					if ((int)manager.Visualizza(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "DUPLICAZIONE":
					if ((int)manager.Duplica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				default:
					if ((int)manager.Cancella(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				}
				val = (FXRETURN)0;
			}
			end_IL_000e:;
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string IFrameTag, string IFrameTitle, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, IFrameTitle, WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string IFrameTag, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, IFrameTag, "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDbPageInIFrame(ref string[] CampiChiave, ref List<object[]> ValoriCampiChiave, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "IFRAME", "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return OpenDatatablePageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ref DataTableSource, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, ObjectManagerName, ModalitaAccessoDati, "", null, ref rsmess);
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string ObjectManagerName, string ModalitaAccessoDati, string IframeBodyClass, Dictionary<string, object> Params, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			IframeInfo iframeInfo = new IframeInfo();
			iframeInfo.Params = Params;
			iframeInfo.IFrameTag = IFrameTag;
			iframeInfo.IFrameTitle = IFrameTitle;
			iframeInfo.IFrameDimension = IFrameDimension;
			iframeInfo.IFrameDimensionCustomCssClass = IFrameDimensionCustomCssClass;
			iframeInfo.IframeBodyClass = IframeBodyClass;
			if (iframeInfo.AutomaticVerticalResizing)
			{
				SetIframeHeightAutoResize();
			}
			iframeInfo.IFrameCaller = EntryPoint;
			val2 = OpenDatatablePageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ref DataTableSource, ObjectManagerName, ModalitaAccessoDati, iframeInfo, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string ObjectManagerName, string ModalitaAccessoDati, IframeInfo IFrameInfo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Invalid comparison between Unknown and I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Invalid comparison between Unknown and I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ModalitaAccessoDati, "", false) == 0)
			{
				ModalitaAccessoDati = "MODIFICA";
			}
			if ((int)GetKeyDataFromArray(ref CampiChiave, ref ValoriCampiChiave, ref robjData, ref robjKey, ref rsmess) <= 0)
			{
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				robjFunctionArguments.OpenInIFrame = true;
				robjFunctionArguments.IFrameTag = IFrameInfo.IFrameTag;
				robjFunctionArguments.Argomento1 = IFrameInfo.IFrameTitle;
				robjFunctionArguments.Argomento2 = IFrameInfo.IFrameDimension;
				robjFunctionArguments.Argomento3 = IFrameInfo.IFrameDimensionCustomCssClass;
				robjFunctionArguments.Argomento4 = IFrameInfo.IframeBodyClass;
				if (IFrameInfo.AutomaticVerticalResizing)
				{
					SetIframeHeightAutoResize();
				}
				robjFunctionArguments.Parameters.Add("_datatable", DataTableSource);
				AbstractObjectManager manager = SessionEnvironment.ObjManagerFactory.GetManager(ObjectManagerName);
				string text = "";
				switch (ModalitaAccessoDati)
				{
				case "INSERIMENTO":
					text = manager.RedirectToIns;
					break;
				case "MODIFICA":
					text = manager.RedirectToMod;
					break;
				case "VISUALIZZAZIONE":
					text = manager.RedirectToVis;
					break;
				case "DUPLICAZIONE":
					text = manager.RedirectToDup;
					break;
				default:
					rsmess = TranslateMessage("XXX", "Modalità di accesso ai dati '{0}' non valida", ModalitaAccessoDati);
					goto end_IL_000e;
				}
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = manager.RedirectTo;
				}
				string key = BaseFunctions.OnlyAspxPageName(text.Split(new char[1] { '?' })[0]).ToUpper();
				SessionEnvironment.SessionVariables.Remove(key);
				SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
				if (IFrameInfo.Params != null)
				{
					foreach (string key2 in IFrameInfo.Params.Keys)
					{
						SessionEnvironment.SessionVariables[key][key2] = RuntimeHelpers.GetObjectValue(IFrameInfo.Params[key2]);
					}
				}
				switch (ModalitaAccessoDati)
				{
				case "INSERIMENTO":
					if ((int)manager.Inserisci(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "MODIFICA":
					if ((int)manager.Modifica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "VISUALIZZAZIONE":
					if ((int)manager.Visualizza(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				case "DUPLICAZIONE":
					if ((int)manager.Duplica(ref robjFunctionArguments, ref rsmess) <= 0)
					{
						break;
					}
					goto end_IL_000e;
				default:
					rsmess = TranslateMessage("XXX", "Modalità di accesso ai dati '{0}' non valida", ModalitaAccessoDati);
					goto end_IL_000e;
				}
				val = (FXRETURN)0;
			}
			end_IL_000e:;
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string IFrameTag, string IFrameTitle, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return OpenDatatablePageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ref DataTableSource, IFrameTag, IFrameTitle, WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string IFrameTag, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return OpenDatatablePageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ref DataTableSource, IFrameTag, "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	protected virtual FXRETURN OpenDatatablePageInIFrame(ref string[] CampiChiave, ref object[] ValoriCampiChiave, ref DataTable DataTableSource, string ObjectManagerName, string ModalitaAccessoDati, ref string rsmess)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		return OpenDatatablePageInIFrame(ref CampiChiave, ref ValoriCampiChiave, ref DataTableSource, "IFRAME", "", WFIMaster.IFrameDimension.Standard, "", ObjectManagerName, ModalitaAccessoDati, ref rsmess);
	}

	public virtual FXRETURN OpenDialogPageInIFrame(string Pagina, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string IframeBodyClass, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val2 = OpenDialogPageInIFrame(Pagina, Context, Modalita, Params, ResetSessionVariables, IFrameTag, IFrameTitle, IFrameDimension, IFrameDimensionCustomCssClass, IframeBodyClass, AutomaticVerticalResizing: false, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN OpenDialogPageInIFrame(string Pagina, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables, string IFrameTag, string IFrameTitle, WFIMaster.IFrameDimension IFrameDimension, string IFrameDimensionCustomCssClass, string IframeBodyClass, bool AutomaticVerticalResizing, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			IframeInfo iframeInfo = new IframeInfo();
			if (Pagina.StartsWith("/"))
			{
				Pagina = "~" + Pagina;
			}
			string text = Strings.Replace(Pagina, "%APPNAME%", "Custom", 1, -1, (CompareMethod)0);
			if (!File.Exists(HttpContext.Current.Server.MapPath(text)))
			{
				text = Strings.Replace(Pagina, "%APPNAME%", SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
				text = BaseFunctions.FindFormDirMember(text);
			}
			iframeInfo.IFrameUrl = text.Replace("~/", SessionEnvironment.AppApplicationRootUrl);
			iframeInfo.IFrameContext = Context;
			iframeInfo.IFrameModalita = Modalita;
			iframeInfo.Params = Params;
			iframeInfo.ResetSessionVariable = ResetSessionVariables;
			iframeInfo.IFrameTag = IFrameTag;
			iframeInfo.IFrameTitle = IFrameTitle;
			iframeInfo.IFrameDimension = IFrameDimension;
			iframeInfo.IFrameDimensionCustomCssClass = IFrameDimensionCustomCssClass;
			iframeInfo.IframeBodyClass = IframeBodyClass;
			iframeInfo.AutomaticVerticalResizing = AutomaticVerticalResizing;
			if (iframeInfo.AutomaticVerticalResizing)
			{
				SetIframeHeightAutoResize();
			}
			iframeInfo.IFrameCaller = EntryPoint;
			val2 = OpenDialogPageInIFrame(iframeInfo, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN OpenDialogPageInIFrame(IframeInfo objIFrameInfo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			SetDialogPageContext(objIFrameInfo.IFrameUrl, objIFrameInfo.IFrameContext, objIFrameInfo.IFrameModalita, objIFrameInfo.Params, objIFrameInfo.ResetSessionVariable);
			OpenIframe(objIFrameInfo);
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public virtual void OpenGridInPage(string NomRif, string title, string WhereAggiuntiva)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGrid.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?GridMode=DETAILS&NomRif=" + NomRif + "&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?GridMode=DETAILS&NomRif=" + NomRif + "&ForceResetFilter=S&WA=" + ((Page)this).Server.UrlEncode(WhereAggiuntiva), "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		if (Operators.CompareString(title, "", false) != 0)
		{
			text = text + "&CAPT=" + ((Page)this).Server.UrlEncode(title);
		}
		IboResponseRedirect(ref text);
	}

	public virtual void OpenGridMS(string NomRif, string title, string WhereAggiuntiva)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGrid.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGrid.aspx?NomRif=" + NomRif + "&ForceResetFilter=S&WA=" + ((Page)this).Server.UrlEncode(WhereAggiuntiva), "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		if (Operators.CompareString(title, "", false) != 0)
		{
			text = text + "&CAPT=" + ((Page)this).Server.UrlEncode(title);
		}
		IboResponseRedirect(ref text);
	}

	public virtual void OpenGrid(string TipoGriglia, string NomRif, string title, string WhereAggiuntiva)
	{
		if (Operators.CompareString(TipoGriglia.ToUpper(), "MS", false) == 0)
		{
			OpenGridMS(NomRif, title, WhereAggiuntiva);
		}
		else if (Operators.CompareString(TipoGriglia.ToUpper(), "TLK", false) == 0)
		{
			OpenGridTlk(NomRif, title, WhereAggiuntiva);
		}
	}

	public virtual void OpenGridTlk(string NomRif, string title, string WhereAggiuntiva)
	{
		string text = "";
		if (WhereAggiuntiva.Length > 2000)
		{
			string key = "WFStandardGridTlk.aspx".ToUpper() + "." + NomRif.ToUpper();
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&ForceResetFilter=S", "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
			SessionEnvironment.SessionVariables.Remove(key);
			SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
			SessionEnvironment.SessionVariables[key]["WA"] = (object)WhereAggiuntiva;
		}
		else
		{
			text = Strings.Replace("~/WFI/Form/WFStandardGridTlk.aspx?NomRif=" + NomRif + "&ForceResetFilter=S&WA=" + ((Page)this).Server.UrlEncode(WhereAggiuntiva), "~/", SessionEnvironment.AppApplicationRootUrl, 1, -1, (CompareMethod)0);
		}
		if (Operators.CompareString(title, "", false) != 0)
		{
			text = text + "&CAPT=" + ((Page)this).Server.UrlEncode(title);
		}
		IboResponseRedirect(ref text);
	}

	protected void SetIframeHeightAutoResize()
	{
		MasterPage.SetIframeHeightAutoResize();
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static int WaitingForIFrameResponse(string param1)
	{
		int result = 0;
		checked
		{
			string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2];
			IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
			IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
			int num = 1;
			do
			{
				try
				{
					if (iboSessionEnvironment.IframeInfoList[key].IFrameClosed)
					{
						result = 1;
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					break;
				}
				Thread.Sleep(50);
				num++;
			}
			while (num <= 10);
			return result;
		}
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

	public virtual FXRETURN VisualizzaStampa(string NomeFilePDF, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!File.Exists(NomeFilePDF))
			{
				rsMess = TranslateMessage("XXX", "Il file di stampa non esiste");
			}
			else
			{
				FunctionArguments functionArguments = new FunctionArguments("", "");
				((Page)this).Session["FunctionArgsReportPage"] = functionArguments;
				functionArguments.Argomento1 = "#SHOWMODE";
				functionArguments.Argomento2 = NomeFilePDF;
				functionArguments.Argomento3 = "PDF";
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

	public virtual FXRETURN StampaEtichetta(string Etichetta, DataTable dtDataToPrint, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = SessionEnvironment.ObjLabel.Stampa(Etichetta, dtDataToPrint, false, ref rsMess);
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

	protected virtual FXRETURN CollapserPressed(bool objPanelTopHeaderVisible, ref string rsMess)
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
			CallStackAdd();
			rsMess = "";
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN HomeButtonPressed(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string rsMess2 = "";
			ReleaseMemory(ref rsMess2);
			if (SessionEnvironment.WebUser != null)
			{
				string sUrl = SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
				if (Operators.CompareString(sUrl, "", false) == 0)
				{
					sUrl = "~\\WFI\\Form\\redirector.aspx";
				}
				IboResponseRedirect(ref sUrl);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private void _MasterPage_CollapserPressed(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		CollapserPressed(MasterPage.PanelTopHeaderVisible, ref rsMess);
	}

	private void _MasterPage_HomeButtonPressed(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		HomeButtonPressed(ref rsMess);
	}

	protected override void SavePageStateToPersistenceMedium(object viewState)
	{
		PerformanceLogAppend("BEGIN WFIPage SavePageStateToPersistenceMedium");
		if (_ViewStateSaveMode == ViewStateSaveMode.InSession)
		{
			if (_SessionVariable != null)
			{
				_SessionVariable["VIEWSTATE"] = RuntimeHelpers.GetObjectValue(viewState);
			}
		}
		else
		{
			this.SavePageStateToPersistenceMedium(RuntimeHelpers.GetObjectValue(viewState));
		}
		PerformanceLogAppend("END WFIPage SavePageStateToPersistenceMedium");
	}

	protected override object LoadPageStateFromPersistenceMedium()
	{
		PerformanceLogAppend("BEGIN WFIPage LoadPageStateFromPersistenceMedium");
		object obj = null;
		obj = ((_ViewStateSaveMode != ViewStateSaveMode.InSession) ? RuntimeHelpers.GetObjectValue(this.LoadPageStateFromPersistenceMedium()) : ((_SessionVariable == null) ? null : RuntimeHelpers.GetObjectValue(_SessionVariable["VIEWSTATE"])));
		PerformanceLogAppend("END WFIPage LoadPageStateFromPersistenceMedium");
		return obj;
	}

	protected override void OnSaveStateComplete(EventArgs e)
	{
		PerformanceLogAppend("BEGIN WFIPage OnSaveStateComplete");
		this.OnSaveStateComplete(e);
		PerformanceLogAppend("END WFIPage OnSaveStateComplete");
	}

	public override void RenderControl(HtmlTextWriter writer)
	{
		PerformanceLogAppend("BEGIN WFIPage RenderControl");
		((Control)this).RenderControl(writer);
		PerformanceLogAppend("END WFIPage RenderControl");
	}

	protected override void RenderChildren(HtmlTextWriter writer)
	{
		PerformanceLogAppend("BEGIN WFIPage RenderChildren");
		try
		{
			this.RenderChildren(writer);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		PerformanceLogAppend("END WFIPage RenderChildren");
	}

	protected override void LoadViewState(object savedState)
	{
		PerformanceLogAppend("BEGIN WFIPage LoadViewState");
		this.LoadViewState(RuntimeHelpers.GetObjectValue(savedState));
		PerformanceLogAppend("END WFIPage LoadViewState");
	}

	public void Client_JavascriptEval(string JavascriptCode)
	{
		MasterPage.WriteJavascriptEval(JavascriptCode);
	}

	public void Client_JavascriptEvalAfterTimeout(string JavascriptCode, int TimeOutMs)
	{
		JavascriptCode = "setTimeout(function(){" + JavascriptCode + "}," + TimeOutMs + ")";
		MasterPage.WriteJavascriptEval(JavascriptCode);
	}

	public void Client_OpenDialogPageOnANewWindow(WindowPopupProperties WindowProp, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables)
	{
		if (Operators.CompareString(Context, "", false) != 0 && Operators.CompareString(WindowProp.Address, "", false) != 0)
		{
			string address = WindowProp.Address;
			SetDialogPageContext(address, Context, Modalita, Params, ResetSessionVariables);
		}
		MasterPage.OpenWindowOnClientLoadPage(WindowProp);
	}

	public void Client_OpenWindowOnLoadPage(WindowPopupProperties WindowProp)
	{
		MasterPage.OpenWindowOnClientLoadPage(WindowProp);
	}

	[Obsolete("This method is deprecated, use Client_JavascriptEval instead.")]
	public void WriteJavascriptEval(string JavascriptCode)
	{
		MasterPage.WriteJavascriptEval(JavascriptCode);
	}

	[Obsolete("This method is deprecated, use Client_OpenDialogPageOnANewWindow instead.")]
	public void OpenDialogPageOnANewWindow(WindowPopupProperties WindowProp, string Context, string Modalita, Dictionary<string, object> Params, bool ResetSessionVariables)
	{
		if (Operators.CompareString(Context, "", false) != 0 && Operators.CompareString(WindowProp.Address, "", false) != 0)
		{
			string address = WindowProp.Address;
			SetDialogPageContext(address, Context, Modalita, Params, ResetSessionVariables);
		}
		MasterPage.OpenWindowOnClientLoadPage(WindowProp);
	}

	[Obsolete("This method is deprecated, use Client_OpenWindowOnLoadPage instead.")]
	public void OpenWindowOnClientLoadPage(WindowPopupProperties WindowProp)
	{
		MasterPage.OpenWindowOnClientLoadPage(WindowProp);
	}

	protected void AddAsyncQueryToApply(string sQuery)
	{
		SessionEnvironment.AddAsyncQueryToApply(sQuery);
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		try
		{
			if (SessionEnvironment.IsInDebugMode)
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
			if (SessionEnvironment.IsInDebugMode)
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
		if (SessionEnvironment.IsInDebugMode)
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

	protected void ToolTipManagerDisable()
	{
		MasterPage.ToolTipManagerDisable();
	}

	protected void ToolTipManagerEnable()
	{
		MasterPage.ToolTipManagerEnable();
	}

	public string GetCallbackResult()
	{
		return _WFICallbackResult;
	}

	public void RaiseCallbackEvent(string eventArgument)
	{
		if (Operators.CompareString(eventArgument.ToUpper(), "TEST", false) == 0)
		{
			_WFICallbackResult = "TEST;TEST EFFETTUATO CON SUCCESSO!";
		}
		else
		{
			_RaiseCallbackEvent(eventArgument);
		}
	}

	protected virtual void _RaiseCallbackEvent(string eventArgument)
	{
	}

	[WebMethod(EnableSession = true)]
	public static string[] GetAutocompleteItems(string keyword, string tag)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text3;
		if (Operators.CompareString(tag ?? "", "", false) != 0)
		{
			string text = "SELECT CODICE %+% ' @@@ ' %+% %ISNULL%(DESCRIZIONE,CODICE) DESCRIZIONE FROM " + tag + " WHERE CODICE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
			text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY DESCRIZIONE";
			text = val.SqlConvertForServer(text);
			DataTable dataTable = null;
			string text2 = text;
			text3 = "";
			val.OpenDataTable(text2, ref dataTable, ref text3);
			foreach (DataRow row in dataTable.Rows)
			{
				list.Add(row["DESCRIZIONE"].ToString());
			}
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	[WebMethod(EnableSession = true)]
	public static string[] GetAutocompleteItems2(string keyword, string tag)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text3;
		if (Operators.CompareString(tag ?? "", "", false) != 0)
		{
			string text = "SELECT CODICE %+% ' %%% ' %+% %ISNULL%(DESCRIZIONE,CODICE) DESCRIZIONE FROM " + tag + " WHERE CODICE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
			text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY DESCRIZIONE";
			text = val.SqlConvertForServer(text);
			DataTable dataTable = null;
			string text2 = text;
			text3 = "";
			val.OpenDataTable(text2, ref dataTable, ref text3);
			foreach (DataRow row in dataTable.Rows)
			{
				list.Add(row["DESCRIZIONE"].ToString());
			}
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	public virtual void WFIPostbackRun_Click(string CommandName, string CommandArgument)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = WFIPostbackRun_Elabora(CommandName, CommandArgument, ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected virtual FXRETURN WFIPostbackRun_Elabora(string CommandName, string CommandArgument, ref string rsMess)
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
			rsMess = "";
			CallStackAdd();
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static string getWFIAjaxTooltipContent(string Param1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		DBConnection val3 = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text2 = "";
		val = val3.OpenConnection(ref text2);
		if ((int)val > 0)
		{
			return "";
		}
		try
		{
			IboCrypt val4 = new IboCrypt();
			string text3 = val4.DecryptString128Bit(Param1);
			object obj = "";
			if (text3.ToUpper().Contains("SELECT "))
			{
				text2 = "";
				val = val3.DoSql(text3, ref obj, ref text2);
				if ((int)val <= 0)
				{
					text = obj.ToString();
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
			text2 = "";
			val3.CloseConnection(ref text2);
			val3.Dispose();
		}
		if (Operators.CompareString(text, "", false) != 0)
		{
			return "<div class=\"WFIAjaxHtmlTooltipContent\">" + text + "</div>";
		}
		return "<div class=\"WFIAjaxHtmlTooltipContent NoDataFound\">no data found ...</div>";
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static string getWFIAjaxTooltipContentById(string Param1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		try
		{
			text = "";
			if (iboDictionaryCollection.ContainsKey("TooltipDictionary"))
			{
				Dictionary<string, string> dictionary = (Dictionary<string, string>)iboDictionaryCollection["TooltipDictionary"];
				if (dictionary.ContainsKey(Param1))
				{
					text = dictionary[Param1];
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
		}
		if (Operators.CompareString(text, "", false) != 0)
		{
			return "<div class=\"WFIAjaxHtmlTooltipContent\">" + text + "</div>";
		}
		return "<div class=\"WFIAjaxHtmlTooltipContent NoDataFound\">no data found ...</div>";
	}
}
