using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIMaster : MasterPage
{
	public delegate void CollapserPressedEventHandler(object sender, EventArgs e);

	public delegate void HomeButtonPressedEventHandler(object sender, EventArgs e);

	public enum IFrameDimension
	{
		Standard,
		IFrameContainer100Percent,
		IFrameContainer95Percent,
		IFrameContainer90Percent,
		IFrameContainer80Percent,
		IFrameContainer70Percent,
		IFrameContainer60Percent,
		IFrameContainer50Percent,
		IFrameContainer800x600,
		IFrameContainer900x600,
		IFrameContainer1000x600,
		IFrameContainer1100x600,
		IFrameContainer1200x600,
		IFrameContainer600x400,
		IFrameContainer700x500,
		IFrameContainer800x500,
		IFrameContainer900x500,
		IFrameContainer900x450,
		IFrameContainer900x400,
		IFrameContainer1000x500,
		IFrameContainer1100x500,
		IFrameContainer1200x500,
		IFrameContainer800x700,
		IFrameContainer900x700,
		IFrameContainer1000x700,
		IFrameContainer1100x700,
		IFrameContainer1200x700,
		IFrameContainerCustomDefinition
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LogOFF")]
	private IboWebButton _LogOFF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Filiale")]
	private IboWebButton _Filiale;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ThinLogOff")]
	private IboWebButton _ThinLogOff;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ThinFiliale")]
	private IboWebButton _ThinFiliale;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Collapser")]
	private ImageButton _Collapser;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("imgGoToHomeLnk")]
	private ImageButton _imgGoToHomeLnk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mnuMain")]
	private IboWebMenu _mnuMain;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mnuMainTlk")]
	private IboWebMenuTlk _mnuMainTlk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MPGeneralSearchGo")]
	private Button _MPGeneralSearchGo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolbarMain")]
	private IboWebToolbar _ToolbarMain;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboMessageBox_cmdAnnulla01")]
	private IboWebButton _IboMessageBox_cmdAnnulla01;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboMessageBox_cmdNo")]
	private IboWebButton _IboMessageBox_cmdNo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboMessageBox_cmdOk01")]
	private IboWebButton _IboMessageBox_cmdOk01;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboMessageBox_cmdYes")]
	private IboWebButton _IboMessageBox_cmdYes;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboMessageBox_cmdOkOnly")]
	private IboWebButton _IboMessageBox_cmdOkOnly;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Progressbar_StopPolling")]
	private Button _Progressbar_StopPolling;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Progressbar_cmdAnnulla")]
	private IboWebButton _Progressbar_cmdAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnIboSelectBoxCancel")]
	private IboWebButton _btnIboSelectBoxCancel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnIboSelectBoxConfirm")]
	private IboWebButton _btnIboSelectBoxConfirm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IFrameManager_StopPolling")]
	private Button _IFrameManager_StopPolling;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IFrameCloseButton")]
	private ImageButton _IFrameCloseButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MasterPopupForm_cmdAnnulla")]
	private IboWebButton _MasterPopupForm_cmdAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MasterPopupForm_cmdOk")]
	private IboWebButton _MasterPopupForm_cmdOk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MasterPopupForm")]
	private ModalPopupExtender _MasterPopupForm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WFIPostbackRun")]
	private Button _WFIPostbackRun;

	[field: AccessedThroughProperty("Head1")]
	protected virtual HtmlHead Head1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("head")]
	protected virtual ContentPlaceHolder head
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPageBodyTag")]
	protected virtual HtmlGenericControl MasterPageBodyTag
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("frm")]
	protected virtual HtmlForm frm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_ScriptManager")]
	protected virtual UpdatePanel up_ScriptManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ScriptManager1")]
	protected virtual ScriptManager ScriptManager1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UpdProgressMaster")]
	protected virtual UpdateProgress UpdProgressMaster
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelGlobalContainer")]
	protected virtual UpdatePanel PanelGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ScreenDimensions")]
	protected virtual HiddenField ScreenDimensions
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BrowserDetect")]
	protected virtual HiddenField BrowserDetect
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KeepAlive_StartPolling")]
	protected virtual HiddenField KeepAlive_StartPolling
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_IncasFocus")]
	protected virtual UpdatePanel UP_IncasFocus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFIncasFocus")]
	protected virtual HiddenField HFIncasFocus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFIncasFocus2")]
	protected virtual HiddenField HFIncasFocus2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_JavascriptEval")]
	protected virtual UpdatePanel UP_JavascriptEval
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JavascriptEval")]
	protected virtual HiddenField JavascriptEval
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_TooltipManager")]
	protected virtual UpdatePanel UP_TooltipManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JqueryToolTipManagerEnable")]
	protected virtual HiddenField JqueryToolTipManagerEnable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JqueryToolTipManagerDuration")]
	protected virtual HiddenField JqueryToolTipManagerDuration
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JqueryToolTipManager_NotCloseIfHover")]
	protected virtual HiddenField JqueryToolTipManager_NotCloseIfHover
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JqueryToolTipManager_ShowDelay")]
	protected virtual HiddenField JqueryToolTipManager_ShowDelay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("JqueryToolTipManager_AnimationDuration")]
	protected virtual HiddenField JqueryToolTipManager_AnimationDuration
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_LastPostback")]
	protected virtual UpdatePanel up_LastPostback
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HF_LastPostBack")]
	protected virtual HiddenField HF_LastPostBack
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HF_IsPostBack")]
	protected virtual HiddenField HF_IsPostBack
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMainMaster")]
	protected virtual Panel pnlMainMaster
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_pnlMainMaster")]
	protected virtual UpdatePanel UP_pnlMainMaster
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelTopHeader")]
	protected virtual Panel PanelTopHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgMasterLogoCliente")]
	protected virtual Image imgMasterLogoCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgMasterLogoIncas")]
	protected virtual Image imgMasterLogoIncas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPanelTopTitle")]
	protected virtual IboWebLabel MasterPanelTopTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMasterTitoloModuloSoftware")]
	protected virtual Label lblMasterTitoloModuloSoftware
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelTopHeader3Table")]
	protected virtual Table PanelTopHeader3Table
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelTopHeader3Table_R1")]
	protected virtual TableRow PanelTopHeader3Table_R1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMasterUtenteApplicazione")]
	protected virtual Label lblMasterUtenteApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton LogOFF
	{
		[CompilerGenerated]
		get
		{
			return _LogOFF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = LogOFF_Click;
			IboWebButton logOFF = _LogOFF;
			if (logOFF != null)
			{
				((Button)logOFF).Click -= eventHandler;
			}
			_LogOFF = value;
			logOFF = _LogOFF;
			if (logOFF != null)
			{
				((Button)logOFF).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("PanelTopHeader3Table_R2")]
	protected virtual TableRow PanelTopHeader3Table_R2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMasterFilialeApplicazione")]
	protected virtual Label lblMasterFilialeApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton Filiale
	{
		[CompilerGenerated]
		get
		{
			return _Filiale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Filiale_Click;
			IboWebButton filiale = _Filiale;
			if (filiale != null)
			{
				((Button)filiale).Click -= eventHandler;
			}
			_Filiale = value;
			filiale = _Filiale;
			if (filiale != null)
			{
				((Button)filiale).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("PanelTopHeader3Table_R3")]
	protected virtual TableRow PanelTopHeader3Table_R3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMasterOrganizzazioneApplicazione")]
	protected virtual Label lblMasterOrganizzazioneApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ThinPanelTopHeader")]
	protected virtual Panel ThinPanelTopHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ThinImgMasterLogoCliente")]
	protected virtual Image ThinImgMasterLogoCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ThinImgMasterLogoIncas")]
	protected virtual Image ThinImgMasterLogoIncas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterThinPanelTopTitle")]
	protected virtual IboWebLabel MasterThinPanelTopTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ThinLblMasterTitoloModuloSoftware")]
	protected virtual Label ThinLblMasterTitoloModuloSoftware
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton ThinLogOff
	{
		[CompilerGenerated]
		get
		{
			return _ThinLogOff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = LogOFF_Click;
			IboWebButton thinLogOff = _ThinLogOff;
			if (thinLogOff != null)
			{
				((Button)thinLogOff).Click -= eventHandler;
			}
			_ThinLogOff = value;
			thinLogOff = _ThinLogOff;
			if (thinLogOff != null)
			{
				((Button)thinLogOff).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton ThinFiliale
	{
		[CompilerGenerated]
		get
		{
			return _ThinFiliale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Filiale_Click;
			IboWebButton thinFiliale = _ThinFiliale;
			if (thinFiliale != null)
			{
				((Button)thinFiliale).Click -= eventHandler;
			}
			_ThinFiliale = value;
			thinFiliale = _ThinFiliale;
			if (thinFiliale != null)
			{
				((Button)thinFiliale).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("CollapserContainer")]
	protected virtual Panel CollapserContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ImageButton Collapser
	{
		[CompilerGenerated]
		get
		{
			return _Collapser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(Collapser_Click);
			ImageButton collapser = _Collapser;
			if (collapser != null)
			{
				collapser.Click -= val;
			}
			_Collapser = value;
			collapser = _Collapser;
			if (collapser != null)
			{
				collapser.Click += val;
			}
		}
	}

	[field: AccessedThroughProperty("PanelHeader")]
	protected virtual Panel PanelHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelHeaderLeft")]
	protected virtual HtmlGenericControl PanelHeaderLeft
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ImageButton imgGoToHomeLnk
	{
		[CompilerGenerated]
		get
		{
			return _imgGoToHomeLnk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(imgGoToHomeLnk_Click);
			ImageButton val2 = _imgGoToHomeLnk;
			if (val2 != null)
			{
				val2.Click -= val;
			}
			_imgGoToHomeLnk = value;
			val2 = _imgGoToHomeLnk;
			if (val2 != null)
			{
				val2.Click += val;
			}
		}
	}

	protected virtual IboWebMenu mnuMain
	{
		[CompilerGenerated]
		get
		{
			return _mnuMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			MenuEventHandler val = new MenuEventHandler(mnuMain_MenuItemClick);
			IboWebMenu val2 = _mnuMain;
			if (val2 != null)
			{
				((Menu)val2).MenuItemClick -= val;
			}
			_mnuMain = value;
			val2 = _mnuMain;
			if (val2 != null)
			{
				((Menu)val2).MenuItemClick += val;
			}
		}
	}

	protected virtual IboWebMenuTlk mnuMainTlk
	{
		[CompilerGenerated]
		get
		{
			return _mnuMainTlk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadMenuEventHandler val = new RadMenuEventHandler(mnuMainTlk_MenuItemClick);
			IboWebMenuTlk val2 = _mnuMainTlk;
			if (val2 != null)
			{
				((RadMenu)val2).ItemClick -= val;
			}
			_mnuMainTlk = value;
			val2 = _mnuMainTlk;
			if (val2 != null)
			{
				((RadMenu)val2).ItemClick += val;
			}
		}
	}

	[field: AccessedThroughProperty("MPGeneralSearchContainer")]
	protected virtual Panel MPGeneralSearchContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MPGeneralSearchLabel")]
	protected virtual IboWebLabel MPGeneralSearchLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MPGeneralSearch")]
	protected virtual IboWebTextBox MPGeneralSearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Button MPGeneralSearchGo
	{
		[CompilerGenerated]
		get
		{
			return _MPGeneralSearchGo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = MPGeneralSearchGo_Click;
			Button mPGeneralSearchGo = _MPGeneralSearchGo;
			if (mPGeneralSearchGo != null)
			{
				mPGeneralSearchGo.Click -= eventHandler;
			}
			_MPGeneralSearchGo = value;
			mPGeneralSearchGo = _MPGeneralSearchGo;
			if (mPGeneralSearchGo != null)
			{
				mPGeneralSearchGo.Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("AutoCompleteExtender1")]
	protected virtual AutoCompleteExtender AutoCompleteExtender1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFMPGeneralSearch")]
	protected virtual HiddenField HFMPGeneralSearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgCloseApplication")]
	protected virtual Image imgCloseApplication
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelContent")]
	protected virtual Panel PanelContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelContentX")]
	protected virtual Panel PanelContentX
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_ToolbarContainer")]
	protected virtual UpdatePanel UP_ToolbarContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolbarContainer")]
	protected virtual Panel ToolbarContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebToolbar ToolbarMain
	{
		[CompilerGenerated]
		get
		{
			return _ToolbarMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			IboWebToolbar.ToolbarClickEventHandler obj = ToolbarMain_ToolbarClick;
			IboWebToolbar toolbarMain = _ToolbarMain;
			if (toolbarMain != null)
			{
				toolbarMain.ToolbarClick -= obj;
			}
			_ToolbarMain = value;
			toolbarMain = _ToolbarMain;
			if (toolbarMain != null)
			{
				toolbarMain.ToolbarClick += obj;
			}
		}
	}

	[field: AccessedThroughProperty("ToolbarPanelRight")]
	protected virtual Panel ToolbarPanelRight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPphPageContent")]
	protected virtual UpdatePanel UPphPageContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("phPageContent")]
	protected virtual ContentPlaceHolder phPageContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPIboMessageBox")]
	protected virtual UpdatePanel UPIboMessageBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NotificationMessage")]
	protected virtual RadNotification NotificationMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NM_Text1")]
	protected virtual Label NM_Text1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NM_Text2")]
	protected virtual Label NM_Text2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Notification_MessageBoxInfo")]
	protected virtual Image Notification_MessageBoxInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Notification_MessageBoxExclamation")]
	protected virtual Image Notification_MessageBoxExclamation
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Notification_MessageBoxCritical")]
	protected virtual Image Notification_MessageBoxCritical
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Notification_MessageBoxQuestion")]
	protected virtual Image Notification_MessageBoxQuestion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01Container")]
	protected virtual IboWebPanel pnlMessaggio01Container
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01")]
	protected virtual Panel pnlMessaggio01
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCaption01")]
	protected virtual Label lblCaption01
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggio01")]
	protected virtual Label lblMessaggio01
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01_MessageBoxInfo")]
	protected virtual Image pnlMessaggio01_MessageBoxInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01_MessageBoxExclamation")]
	protected virtual Image pnlMessaggio01_MessageBoxExclamation
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01_MessageBoxCritical")]
	protected virtual Image pnlMessaggio01_MessageBoxCritical
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggio01_MessageBoxQuestion")]
	protected virtual Image pnlMessaggio01_MessageBoxQuestion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggio02")]
	protected virtual Label lblMessaggio02
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton IboMessageBox_cmdAnnulla01
	{
		[CompilerGenerated]
		get
		{
			return _IboMessageBox_cmdAnnulla01;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboMessageBox_cmdAnnulla01_Click;
			IboWebButton iboMessageBox_cmdAnnulla = _IboMessageBox_cmdAnnulla01;
			if (iboMessageBox_cmdAnnulla != null)
			{
				((Button)iboMessageBox_cmdAnnulla).Click -= eventHandler;
			}
			_IboMessageBox_cmdAnnulla01 = value;
			iboMessageBox_cmdAnnulla = _IboMessageBox_cmdAnnulla01;
			if (iboMessageBox_cmdAnnulla != null)
			{
				((Button)iboMessageBox_cmdAnnulla).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton IboMessageBox_cmdNo
	{
		[CompilerGenerated]
		get
		{
			return _IboMessageBox_cmdNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboMessageBox_cmdNo_Click;
			IboWebButton iboMessageBox_cmdNo = _IboMessageBox_cmdNo;
			if (iboMessageBox_cmdNo != null)
			{
				((Button)iboMessageBox_cmdNo).Click -= eventHandler;
			}
			_IboMessageBox_cmdNo = value;
			iboMessageBox_cmdNo = _IboMessageBox_cmdNo;
			if (iboMessageBox_cmdNo != null)
			{
				((Button)iboMessageBox_cmdNo).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton IboMessageBox_cmdOk01
	{
		[CompilerGenerated]
		get
		{
			return _IboMessageBox_cmdOk01;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboMessageBox_cmdOk01_Click;
			IboWebButton iboMessageBox_cmdOk = _IboMessageBox_cmdOk01;
			if (iboMessageBox_cmdOk != null)
			{
				((Button)iboMessageBox_cmdOk).Click -= eventHandler;
			}
			_IboMessageBox_cmdOk01 = value;
			iboMessageBox_cmdOk = _IboMessageBox_cmdOk01;
			if (iboMessageBox_cmdOk != null)
			{
				((Button)iboMessageBox_cmdOk).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton IboMessageBox_cmdYes
	{
		[CompilerGenerated]
		get
		{
			return _IboMessageBox_cmdYes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboMessageBox_cmdYes_Click;
			IboWebButton iboMessageBox_cmdYes = _IboMessageBox_cmdYes;
			if (iboMessageBox_cmdYes != null)
			{
				((Button)iboMessageBox_cmdYes).Click -= eventHandler;
			}
			_IboMessageBox_cmdYes = value;
			iboMessageBox_cmdYes = _IboMessageBox_cmdYes;
			if (iboMessageBox_cmdYes != null)
			{
				((Button)iboMessageBox_cmdYes).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton IboMessageBox_cmdOkOnly
	{
		[CompilerGenerated]
		get
		{
			return _IboMessageBox_cmdOkOnly;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboMessageBox_cmdOkOnly_Click;
			IboWebButton iboMessageBox_cmdOkOnly = _IboMessageBox_cmdOkOnly;
			if (iboMessageBox_cmdOkOnly != null)
			{
				((Button)iboMessageBox_cmdOkOnly).Click -= eventHandler;
			}
			_IboMessageBox_cmdOkOnly = value;
			iboMessageBox_cmdOkOnly = _IboMessageBox_cmdOkOnly;
			if (iboMessageBox_cmdOkOnly != null)
			{
				((Button)iboMessageBox_cmdOkOnly).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("popMessaggioConferma")]
	protected virtual ModalPopupExtender popMessaggioConferma
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForMessageBoxPopup")]
	protected virtual Button hiddenTargetControlForMessageBoxPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPProgressbarGlobalContainer")]
	protected virtual UpdatePanel UPProgressbarGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarGlobalContainer")]
	protected virtual Panel ProgressbarGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarContainer")]
	protected virtual Panel ProgressbarContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarTitleBar")]
	protected virtual Panel ProgressbarTitleBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarCaption")]
	protected virtual IboWebLabel ProgressbarCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPProgressbar")]
	protected virtual UpdatePanel UPProgressbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarBody")]
	protected virtual Panel ProgressbarBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Progressbar_StartPolling")]
	protected virtual HiddenField Progressbar_StartPolling
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Button Progressbar_StopPolling
	{
		[CompilerGenerated]
		get
		{
			return _Progressbar_StopPolling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Progressbar_StopPolling_Click;
			Button progressbar_StopPolling = _Progressbar_StopPolling;
			if (progressbar_StopPolling != null)
			{
				progressbar_StopPolling.Click -= eventHandler;
			}
			_Progressbar_StopPolling = value;
			progressbar_StopPolling = _Progressbar_StopPolling;
			if (progressbar_StopPolling != null)
			{
				progressbar_StopPolling.Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("ProgressbarDescriptionPanel")]
	protected virtual Panel ProgressbarDescriptionPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarDescription")]
	protected virtual IboWebLabel ProgressbarDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarLayoutContainerPanel")]
	protected virtual Panel ProgressBarLayoutContainerPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarLayout")]
	protected virtual Panel ProgressBarLayout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProgressbarPercentuale")]
	protected virtual Label lblProgressbarPercentuale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarLayoutContainerPanel2")]
	protected virtual Panel ProgressBarLayoutContainerPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarLayoutStaticImage")]
	protected virtual Image ProgressBarLayoutStaticImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProgressbarTimeElapsed")]
	protected virtual Label lblProgressbarTimeElapsed
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarDetailPanel")]
	protected virtual Panel ProgressbarDetailPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarDetail")]
	protected virtual IboWebLabel ProgressbarDetail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressbarButtons")]
	protected virtual Panel ProgressbarButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton Progressbar_cmdAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _Progressbar_cmdAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Progressbar_cmdAnnulla_Click;
			IboWebButton progressbar_cmdAnnulla = _Progressbar_cmdAnnulla;
			if (progressbar_cmdAnnulla != null)
			{
				((Button)progressbar_cmdAnnulla).Click -= eventHandler;
			}
			_Progressbar_cmdAnnulla = value;
			progressbar_cmdAnnulla = _Progressbar_cmdAnnulla;
			if (progressbar_cmdAnnulla != null)
			{
				((Button)progressbar_cmdAnnulla).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("hiddenTargetControlForProgressbar")]
	protected virtual Button hiddenTargetControlForProgressbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Progressbar")]
	protected virtual ModalPopupExtender Progressbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_pnlSelectBoxContainer")]
	protected virtual UpdatePanel UP_pnlSelectBoxContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSelectBoxContainer")]
	protected virtual Panel pnlSelectBoxContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSelectBox")]
	protected virtual Panel pnlSelectBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSelectBoxTitle")]
	protected virtual Label lblSelectBoxTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSelectBoxSubtitle")]
	protected virtual Label lblSelectBoxSubtitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSelectBoxText")]
	protected virtual Label lblSelectBoxText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboSelectBoxRadioButtonList")]
	protected virtual IboWebRadioButtonList IboSelectBoxRadioButtonList
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboSelectBoxDropDownList")]
	protected virtual IboDropDownList IboSelectBoxDropDownList
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnIboSelectBoxCancel
	{
		[CompilerGenerated]
		get
		{
			return _btnIboSelectBoxCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboSelectBox_CancelButtonClick;
			IboWebButton val = _btnIboSelectBoxCancel;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnIboSelectBoxCancel = value;
			val = _btnIboSelectBoxCancel;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnIboSelectBoxConfirm
	{
		[CompilerGenerated]
		get
		{
			return _btnIboSelectBoxConfirm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboSelectBox_ConfirmButtonClick;
			IboWebButton val = _btnIboSelectBoxConfirm;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnIboSelectBoxConfirm = value;
			val = _btnIboSelectBoxConfirm;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("popSelectBox")]
	protected virtual ModalPopupExtender popSelectBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForSelectBoxPopup")]
	protected virtual Button hiddenTargetControlForSelectBoxPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPIFrame")]
	protected virtual UpdatePanel UPIFrame
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameManager_StartPolling")]
	protected virtual HiddenField IFrameManager_StartPolling
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameManager_AutoResize")]
	protected virtual HiddenField IFrameManager_AutoResize
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Button IFrameManager_StopPolling
	{
		[CompilerGenerated]
		get
		{
			return _IFrameManager_StopPolling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IFrameManager_StopPolling_Click;
			Button iFrameManager_StopPolling = _IFrameManager_StopPolling;
			if (iFrameManager_StopPolling != null)
			{
				iFrameManager_StopPolling.Click -= eventHandler;
			}
			_IFrameManager_StopPolling = value;
			iFrameManager_StopPolling = _IFrameManager_StopPolling;
			if (iFrameManager_StopPolling != null)
			{
				iFrameManager_StopPolling.Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("IFrameGlobalContainer")]
	protected virtual Panel IFrameGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFramePopupExtenderContainer")]
	protected virtual Panel IFramePopupExtenderContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameContainer")]
	protected virtual Panel IFrameContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameTitleDiv")]
	protected virtual Panel IFrameTitleDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IFrameTitle")]
	protected virtual Label IFrameTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ImageButton IFrameCloseButton
	{
		[CompilerGenerated]
		get
		{
			return _IFrameCloseButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(IFrameCloseButton_Click);
			ImageButton iFrameCloseButton = _IFrameCloseButton;
			if (iFrameCloseButton != null)
			{
				iFrameCloseButton.Click -= val;
			}
			_IFrameCloseButton = value;
			iFrameCloseButton = _IFrameCloseButton;
			if (iFrameCloseButton != null)
			{
				iFrameCloseButton.Click += val;
			}
		}
	}

	[field: AccessedThroughProperty("IFrameContainerDiv")]
	protected virtual Panel IFrameContainerDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterIFrame")]
	protected virtual HtmlGenericControl MasterIFrame
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MPEIFrameContainer")]
	protected virtual ModalPopupExtender MPEIFrameContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hTCForIFramePopup")]
	protected virtual Button hTCForIFramePopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPMasterPopupFormGlobalContainer")]
	protected virtual UpdatePanel UPMasterPopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormGlobalContainer")]
	protected virtual Panel MasterPopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormContainer")]
	protected virtual Panel MasterPopupFormContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormTitleBar")]
	protected virtual Panel MasterPopupFormTitleBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormCaption")]
	protected virtual IboWebLabel MasterPopupFormCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPMasterPopupForm")]
	protected virtual UpdatePanel UPMasterPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormBody")]
	protected virtual Panel MasterPopupFormBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("phMasterPopupForm")]
	protected virtual ContentPlaceHolder phMasterPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MasterPopupFormButtons")]
	protected virtual Panel MasterPopupFormButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton MasterPopupForm_cmdAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _MasterPopupForm_cmdAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = MasterPopupForm_cmdAnnulla_Click;
			IboWebButton masterPopupForm_cmdAnnulla = _MasterPopupForm_cmdAnnulla;
			if (masterPopupForm_cmdAnnulla != null)
			{
				((Button)masterPopupForm_cmdAnnulla).Click -= eventHandler;
			}
			_MasterPopupForm_cmdAnnulla = value;
			masterPopupForm_cmdAnnulla = _MasterPopupForm_cmdAnnulla;
			if (masterPopupForm_cmdAnnulla != null)
			{
				((Button)masterPopupForm_cmdAnnulla).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton MasterPopupForm_cmdOk
	{
		[CompilerGenerated]
		get
		{
			return _MasterPopupForm_cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = MasterPopupForm_cmdOk_Click;
			IboWebButton masterPopupForm_cmdOk = _MasterPopupForm_cmdOk;
			if (masterPopupForm_cmdOk != null)
			{
				((Button)masterPopupForm_cmdOk).Click -= eventHandler;
			}
			_MasterPopupForm_cmdOk = value;
			masterPopupForm_cmdOk = _MasterPopupForm_cmdOk;
			if (masterPopupForm_cmdOk != null)
			{
				((Button)masterPopupForm_cmdOk).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("hForMasterPopupForm")]
	protected virtual Button hForMasterPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ModalPopupExtender MasterPopupForm
	{
		[CompilerGenerated]
		get
		{
			return _MasterPopupForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = MasterPopupForm_PreRender;
			ModalPopupExtender masterPopupForm = _MasterPopupForm;
			if (masterPopupForm != null)
			{
				((Control)masterPopupForm).PreRender -= eventHandler;
			}
			_MasterPopupForm = value;
			masterPopupForm = _MasterPopupForm;
			if (masterPopupForm != null)
			{
				((Control)masterPopupForm).PreRender += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("up_WFIPostbackData")]
	protected virtual UpdatePanel up_WFIPostbackData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WFIPostbackArguments")]
	protected virtual HiddenField WFIPostbackArguments
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WFIPostbackCommand")]
	protected virtual HiddenField WFIPostbackCommand
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WFIPostbackAllowed")]
	protected virtual HiddenField WFIPostbackAllowed
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Button WFIPostbackRun
	{
		[CompilerGenerated]
		get
		{
			return _WFIPostbackRun;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = WFIPostbackRun_Click;
			Button wFIPostbackRun = _WFIPostbackRun;
			if (wFIPostbackRun != null)
			{
				wFIPostbackRun.Click -= eventHandler;
			}
			_WFIPostbackRun = value;
			wFIPostbackRun = _WFIPostbackRun;
			if (wFIPostbackRun != null)
			{
				wFIPostbackRun.Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("PanelFooter")]
	protected virtual Panel PanelFooter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelBottomL_Content")]
	protected virtual Literal PanelBottomL_Content
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TlkTooltipManager")]
	protected virtual RadToolTipManager TlkTooltipManager
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public IboSessionEnvironment SessionEnvironment => (IboSessionEnvironment)((UserControl)this).Session["SessionEnvironment"];

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

	public IboWebToolbar ToolBarObject => ToolbarMain;

	public Panel ToolBarContainerPanel => ToolbarContainer;

	public UpdatePanel UpdatePanelToolBar => UP_ToolbarContainer;

	public IboWebToolbar WebToolbar => ToolbarMain;

	public RadNotification NotificationMessageObject => NotificationMessage;

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

	public ScriptManager ScriptManager => ScriptManager1;

	public UpdatePanel UpdatePanelScriptManager => up_ScriptManager;

	public IboWebMenu MasterMenuItem
	{
		get
		{
			return mnuMain;
		}
		set
		{
			mnuMain = value;
		}
	}

	public IboWebMenuTlk MasterMenuItemTlk
	{
		get
		{
			return mnuMainTlk;
		}
		set
		{
			mnuMainTlk = value;
		}
	}

	public WFIPage WFIPage => (WFIPage)(object)((Control)this).Page;

	public HtmlGenericControl BodyTag => MasterPageBodyTag;

	public Panel PanelMainMaster => pnlMainMaster;

	public UpdatePanel UpdatePanelNotificationMessage => UPIboMessageBox;

	public UpdateProgress MasterUpdateProgress => UpdProgressMaster;

	public UpdatePanel MasterUpdatePanel => PanelGlobalContainer;

	public UpdatePanel ContentUpdatePanel => UPphPageContent;

	public Panel GetToolbarPanelRight => ToolbarPanelRight;

	public Panel GetToolbarMenu => PanelHeader;

	public PerformanceLog PerformanceLog => WFIPage.PerformanceLog;

	public RadToolTipManager ToolTipManager => TlkTooltipManager;

	public bool CanLogOff { get; set; }

	public bool CanCollapse { get; set; }

	public bool CanChangeFiliale { get; set; }

	public bool FullScreen { get; set; }

	public bool PanelTopHeaderVisible
	{
		get
		{
			if (((UserControl)this).Session["Masterpage.PanelTopHeaderVisible"] == null)
			{
				return true;
			}
			return Conversions.ToBoolean(((UserControl)this).Session["Masterpage.PanelTopHeaderVisible"]);
		}
		set
		{
			((UserControl)this).Session["Masterpage.PanelTopHeaderVisible"] = value;
		}
	}

	public string TitleInTopPanel
	{
		get
		{
			return MasterThinPanelTopTitle.ObjValue.ToString();
		}
		set
		{
			MasterThinPanelTopTitle.ObjValue = value;
			MasterPanelTopTitle.ObjValue = value;
		}
	}

	public virtual bool IsInDebugMode => SessionEnvironment.IsInDebugMode;

	public UpdatePanel UpdatePanelWFIPostbackData => up_WFIPostbackData;

	public bool WFIPostbackIsAllowed
	{
		get
		{
			return Operators.CompareString(WFIPostbackAllowed.Value, "S", false) == 0;
		}
		set
		{
			WFIPostbackAllowed.Value = (value ? "S" : "N");
			up_WFIPostbackData.Update();
		}
	}

	public event CollapserPressedEventHandler CollapserPressed;

	public event HomeButtonPressedEventHandler HomeButtonPressed;

	public WFIMaster()
	{
		((Control)this).Init += Page_Init;
		((Control)this).Load += Page_Load;
		((Control)this).PreRender += Page_PreRender;
		CanLogOff = true;
		CanCollapse = true;
		CanChangeFiliale = true;
		FullScreen = false;
	}

	public string TranslateMessage(string Context, string vsDefault, params string[] vParametri)
	{
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.Translator.TranslateMessage(Context, vsDefault, vParametri);
		}
		return "";
	}

	public string TranslateMessage(string Context, string vsDefault)
	{
		if (SessionEnvironment.Initialized)
		{
			return SessionEnvironment.Translator.TranslateMessage(Context, vsDefault, new string[0]);
		}
		return "";
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

	public void SetIncasFocusToControl(string sControlId)
	{
		if (Operators.CompareString(HFIncasFocus.Value, "", false) != 0)
		{
			HFIncasFocus2.Value = sControlId;
		}
		else
		{
			HFIncasFocus.Value = sControlId;
		}
		UP_IncasFocus.Update();
	}

	public void SetIncasFocusToControl(Control objControl)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (objControl is IIboWebComponent)
		{
			SetIncasFocusToControl(((IIboWebComponent)objControl).InternalClientID);
		}
		else
		{
			SetIncasFocusToControl(objControl.ClientID);
		}
	}

	protected void FaviconManager()
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		try
		{
			if (((UserControl)this).Session["MasterPage.Favicon"] == null)
			{
				string path = ((UserControl)this).Server.MapPath("~/images/ApplicationFavicon_" + SessionEnvironment.WebApplicationName + ".ico");
				if (File.Exists(path))
				{
					((UserControl)this).Session["MasterPage.Favicon"] = "~/images/ApplicationFavicon_" + SessionEnvironment.WebApplicationName + ".ico";
				}
				else
				{
					path = ((UserControl)this).Server.MapPath("~/images/ApplicationFavicon_" + SessionEnvironment.WebApplicationName + ".png");
					if (File.Exists(path))
					{
						((UserControl)this).Session["MasterPage.Favicon"] = "~/images/ApplicationFavicon_" + SessionEnvironment.WebApplicationName + ".png";
					}
					else
					{
						path = ((UserControl)this).Server.MapPath("~/images/ApplicationFavicon.ico");
						if (File.Exists(path))
						{
							((UserControl)this).Session["MasterPage.Favicon"] = "~/images/ApplicationFavicon.ico";
						}
					}
				}
			}
			if (((UserControl)this).Session["MasterPage.Favicon"] != null)
			{
				HtmlLink val = new HtmlLink();
				val.Href = ((UserControl)this).Session["MasterPage.Favicon"].ToString();
				((HtmlControl)val).Attributes["rel"] = "shortcut icon";
				((HtmlControl)val).Attributes["type"] = "image/x-icon";
				((Control)((Control)this).Page.Header).Controls.Add((Control)(object)val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void IboMessageBox(ref WFIUserMessage UserMess)
	{
		if (Operators.CompareString(UserMess.CssClass, "", false) != 0)
		{
			((WebControl)pnlMessaggio01Container).CssClass = UserMess.CssClass;
		}
		lblMessaggio01.Text = UserMess.Message1.Replace("\r\n", "<br />");
		lblMessaggio02.Text = UserMess.Message2.Replace("\r\n", "<br />");
		lblCaption01.Text = UserMess.Title;
		if (Operators.CompareString(lblCaption01.Text, "", false) == 0)
		{
			lblCaption01.Text = SessionEnvironment.WebApplicationTitle;
		}
		UserMess.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
		pnlMessaggio01Container.EscButtonId = "";
		if (UserMess.Tipo == WFIUserMessage.TipoMessageBox.ConfermaAnnulla)
		{
			IboMessageBox_cmdAnnulla01.Visible = true;
			IboMessageBox_cmdOk01.Visible = true;
			IboMessageBox_cmdNo.Visible = false;
			IboMessageBox_cmdYes.Visible = false;
			IboMessageBox_cmdOkOnly.Visible = false;
			pnlMessaggio01Container.EscButtonId = ((Control)IboMessageBox_cmdAnnulla01).ID;
			SetIncasFocusToControl((Control)(object)IboMessageBox_cmdAnnulla01);
		}
		else if (UserMess.Tipo == WFIUserMessage.TipoMessageBox.OkOnly)
		{
			IboMessageBox_cmdAnnulla01.Visible = false;
			IboMessageBox_cmdOk01.Visible = false;
			IboMessageBox_cmdNo.Visible = false;
			IboMessageBox_cmdYes.Visible = false;
			IboMessageBox_cmdOkOnly.Visible = true;
			pnlMessaggio01Container.EscButtonId = ((Control)IboMessageBox_cmdOkOnly).ID;
			SetIncasFocusToControl((Control)(object)IboMessageBox_cmdOkOnly);
		}
		else if (UserMess.Tipo == WFIUserMessage.TipoMessageBox.YesNo)
		{
			IboMessageBox_cmdAnnulla01.Visible = false;
			IboMessageBox_cmdOk01.Visible = false;
			IboMessageBox_cmdNo.Visible = true;
			IboMessageBox_cmdYes.Visible = true;
			IboMessageBox_cmdOkOnly.Visible = false;
			pnlMessaggio01Container.EscButtonId = ((Control)IboMessageBox_cmdNo).ID;
			SetIncasFocusToControl((Control)(object)IboMessageBox_cmdNo);
		}
		((Control)pnlMessaggio01_MessageBoxInfo).Visible = false;
		((Control)pnlMessaggio01_MessageBoxCritical).Visible = false;
		((Control)pnlMessaggio01_MessageBoxExclamation).Visible = false;
		((Control)pnlMessaggio01_MessageBoxQuestion).Visible = false;
		if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Critical)
		{
			((Control)pnlMessaggio01_MessageBoxCritical).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Exclamation)
		{
			((Control)pnlMessaggio01_MessageBoxExclamation).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Info)
		{
			((Control)pnlMessaggio01_MessageBoxInfo).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Question)
		{
			((Control)pnlMessaggio01_MessageBoxQuestion).Visible = true;
		}
		((Control)pnlMessaggio01).Visible = true;
		UserMess.State = WFIUserMessage.WFIMessageBoxState.Active;
		((Control)pnlMessaggio01Container).Visible = true;
		UPIboMessageBox.Update();
		popMessaggioConferma.Show();
	}

	public void ShowNotificationMessage(ref WFIUserMessage UserMess)
	{
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(UserMess.CssClass, "", false) != 0)
		{
			((RadWebControl)NotificationMessage).CssClass = ((RadWebControl)NotificationMessage).CssClass + " " + UserMess.CssClass;
		}
		NotificationMessage.Title = UserMess.Title;
		if (Operators.CompareString(NotificationMessage.Title, "", false) == 0)
		{
			NotificationMessage.Title = UserMess.Message1;
			NM_Text1.Text = "";
			NM_Text2.Text = UserMess.Message2;
		}
		else
		{
			NM_Text1.Text = "";
			if ((Operators.CompareString(UserMess.Message1, "", false) != 0) & (Operators.CompareString(UserMess.Message2, "", false) != 0))
			{
				NM_Text2.Text = UserMess.Message1 + "\r\n" + UserMess.Message2;
			}
			else if ((Operators.CompareString(UserMess.Message1, "", false) != 0) & (Operators.CompareString(UserMess.Message2, "", false) == 0))
			{
				NM_Text2.Text = UserMess.Message1;
			}
			else if ((Operators.CompareString(UserMess.Message1, "", false) == 0) & (Operators.CompareString(UserMess.Message2, "", false) != 0))
			{
				NM_Text2.Text = UserMess.Message2;
			}
		}
		NM_Text1.Text = NM_Text1.Text.Replace("\r\n", "<br />");
		NM_Text2.Text = NM_Text2.Text.Replace("\r\n", "<br />");
		UserMess.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
		NotificationMessage.TitleIcon = "none";
		NotificationMessage.ContentIcon = "none";
		((Control)Notification_MessageBoxInfo).Visible = false;
		((Control)Notification_MessageBoxCritical).Visible = false;
		((Control)Notification_MessageBoxExclamation).Visible = false;
		((Control)Notification_MessageBoxQuestion).Visible = false;
		if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Critical)
		{
			((Control)Notification_MessageBoxCritical).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Exclamation)
		{
			((Control)Notification_MessageBoxExclamation).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Info)
		{
			((Control)Notification_MessageBoxInfo).Visible = true;
		}
		else if (UserMess.MessageBoxImageType == WFIUserMessage.MessageBoxImage.Question)
		{
			((Control)Notification_MessageBoxQuestion).Visible = true;
		}
		((RadWebControl)NotificationMessage).Visible = true;
		UPIboMessageBox.Update();
		if (UserMess.Height != 0)
		{
			NotificationMessage.Height = new Unit((double)UserMess.Height, (UnitType)1);
		}
		if (UserMess.Width != 0)
		{
			NotificationMessage.Width = new Unit((double)UserMess.Width, (UnitType)1);
		}
		NotificationMessage.Show();
	}

	public void IboSelectBox(ref WFIUserSelect UserSel)
	{
		lblSelectBoxTitle.Text = UserSel.Title;
		lblSelectBoxSubtitle.Text = UserSel.Subtitle;
		lblSelectBoxText.Text = UserSel.Text;
		if (Operators.CompareString(lblSelectBoxTitle.Text, "", false) == 0)
		{
			lblSelectBoxTitle.Text = SessionEnvironment.WebApplicationTitle;
		}
		UserSel.UserDialogResult = WFIUserSelect.SelectUserDialogResult.Undefined;
		if (UserSel.Type == WFIUserSelect.SelectUserDialogType.DropDownList)
		{
			WFIUserSelect obj = UserSel;
			IboDropDownList robjDropDownList = IboSelectBoxDropDownList;
			obj.PopulateList(ref robjDropDownList);
			IboSelectBoxDropDownList = robjDropDownList;
			IboSelectBoxDropDownList.Visible = true;
			IboSelectBoxRadioButtonList.Visible = false;
		}
		else if (UserSel.Type == WFIUserSelect.SelectUserDialogType.RadioButtonList)
		{
			WFIUserSelect obj2 = UserSel;
			IboWebRadioButtonList robjRadioButtonList = IboSelectBoxRadioButtonList;
			obj2.PopulateList(ref robjRadioButtonList);
			IboSelectBoxRadioButtonList = robjRadioButtonList;
			IboSelectBoxDropDownList.Visible = false;
			IboSelectBoxRadioButtonList.Visible = true;
		}
		SetIncasFocusToControl((Control)(object)btnIboSelectBoxCancel);
		((Control)pnlSelectBoxContainer).Visible = true;
		UP_pnlSelectBoxContainer.Update();
		popSelectBox.Show();
	}

	protected virtual void IboMessageBox_cmdOk01_Click(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboMessageBox_cmdOk01_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboMessageBox_cmdAnnulla01_Click(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboMessageBox_cmdAnnulla01_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboMessageBox_cmdYes_Click(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboMessageBox_cmdYes_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboMessageBox_cmdNo_Click(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboMessageBox_cmdNo_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboMessageBox_cmdOkOnly_Click(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboMessageBox_cmdOkOnly_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboSelectBox_ConfirmButtonClick(object sender, EventArgs e)
	{
		if (SessionEnvironment.UserSelect.Type == WFIUserSelect.SelectUserDialogType.DropDownList)
		{
			SessionEnvironment.UserSelect.Selected = IboSelectBoxDropDownList.ObjValue.ToString();
		}
		else if (SessionEnvironment.UserSelect.Type == WFIUserSelect.SelectUserDialogType.RadioButtonList)
		{
			SessionEnvironment.UserSelect.Selected = IboSelectBoxRadioButtonList.ObjValue.ToString();
		}
		((WFIPage)(object)((Control)this).Page).IboSelectBox_ConfirmButtonClick(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected virtual void IboSelectBox_CancelButtonClick(object sender, EventArgs e)
	{
		((WFIPage)(object)((Control)this).Page).IboSelectBox_CancelButtonClick(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void ProgressbarShow(ref WFIProgressbarMessage progressbarMessage)
	{
		((Control)ProgressbarGlobalContainer).Visible = true;
		Progressbar_StartPolling.Value = progressbarMessage.RefreshInterval.ToString();
		progressbarMessage.Percentage = 0m;
		ProgressbarAggiorna(ref progressbarMessage);
		if (!progressbarMessage.PercentageVisible)
		{
			lblProgressbarPercentuale.Text = "";
		}
		if (progressbarMessage.ProgressbarType == WFIProgressbarType.ProgressbarWithPercentage)
		{
			((Control)ProgressBarLayoutContainerPanel).Visible = true;
			((Control)ProgressBarLayoutContainerPanel2).Visible = false;
		}
		else if (progressbarMessage.ProgressbarType == WFIProgressbarType.WaitingWithTimeElapsed)
		{
			((Control)ProgressBarLayoutContainerPanel).Visible = false;
			((Control)ProgressBarLayoutContainerPanel2).Visible = true;
		}
		UPProgressbar.Update();
		UPProgressbarGlobalContainer.Update();
		Progressbar.Show();
	}

	protected virtual void ProgressbarAggiorna(ref WFIProgressbarMessage progressbarMessage)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProgressbarCaption.Text = progressbarMessage.Title;
			ProgressbarDescription.Text = progressbarMessage.MainMessage.Replace("\r\n", "<br/>");
			ProgressbarDetail.Text = progressbarMessage.DetailMessage.Replace("\r\n", "<br/>");
			if (decimal.Compare(progressbarMessage.Percentage, 100m) > 0)
			{
				progressbarMessage.Percentage = 100m;
			}
			((WebControl)ProgressBarLayout).Width = new Unit(Convert.ToDouble(progressbarMessage.Percentage), (UnitType)7);
			lblProgressbarPercentuale.Text = progressbarMessage.Percentage + "%";
			if (decimal.Compare(progressbarMessage.Percentage, 100m) == 0)
			{
				WFIPage wFIPage = WFIPage;
				string rsMess = "";
				wFIPage.ProgressbarFine(ref rsMess);
				((Control)ProgressbarGlobalContainer).Visible = false;
				UPProgressbarGlobalContainer.Update();
				SessionEnvironment.ProgressbarInfo.Reset();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void Progressbar_cmdAnnulla_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		try
		{
			SessionEnvironment.ProgressbarInfo.StopTask = true;
			WFIPage wFIPage = WFIPage;
			string rsMess = "";
			FXRETURN val = wFIPage.ProgressbarAnnulla(ref rsMess);
			if ((int)val == 0)
			{
				((Control)ProgressbarGlobalContainer).Visible = false;
				UPProgressbarGlobalContainer.Update();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void Progressbar_StopPolling_Click(object sender, EventArgs e)
	{
		try
		{
			IboSessionEnvironment sessionEnvironment;
			WFIProgressbarMessage progressbarMessage = (sessionEnvironment = SessionEnvironment).ProgressbarInfo;
			ProgressbarAggiorna(ref progressbarMessage);
			sessionEnvironment.ProgressbarInfo = progressbarMessage;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void OpenIframe(string sUrl, string Tag)
	{
		OpenIframe(sUrl, Tag, "", IFrameDimension.Standard, "", CloseButton: false);
	}

	public void OpenIframe(string sUrl, string Tag, string Title, IFrameDimension IFrameCSSClass, string IFrameCustomCssClass, bool CloseButton)
	{
		try
		{
			IframeInfo iframeInfo = new IframeInfo();
			iframeInfo.IFrameUrl = sUrl;
			iframeInfo.IFrameTag = Tag;
			iframeInfo.IFrameTitle = Title;
			iframeInfo.IFrameDimension = IFrameCSSClass;
			iframeInfo.IFrameDimensionCustomCssClass = IFrameCustomCssClass;
			iframeInfo.IframeBodyClass = "";
			iframeInfo.IFrameCloseButtonVisible = CloseButton;
			iframeInfo.IFrameCaller = WFIPage.EntryPoint;
			OpenIframe(iframeInfo);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void OpenIframe(IframeInfo objIFrameInfo)
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		try
		{
			if (objIFrameInfo.AutomaticVerticalResizing)
			{
				SetIframeHeightAutoResize();
			}
			objIFrameInfo.IFrameObjectReturn = null;
			((Control)IFramePopupExtenderContainer).Visible = true;
			((Control)IFrameGlobalContainer).Visible = true;
			((Control)IFrameContainer).Visible = true;
			((Control)UPIFrame).Visible = true;
			UPIFrame.Update();
			((Control)MasterIFrame).Visible = true;
			if (Operators.CompareString(objIFrameInfo.IFrameTitle, "", false) == 0)
			{
				((Control)IFrameTitleDiv).Visible = false;
				((WebControl)IFrameContainerDiv).Style.Add("top", "0px");
			}
			else
			{
				((Control)IFrameTitleDiv).Visible = true;
				IFrameTitle.Text = objIFrameInfo.IFrameTitle;
			}
			if (objIFrameInfo.Draggable)
			{
				MPEIFrameContainer.PopupDragHandleControlID = "IFrameTitleDiv";
				((WebControl)IFrameTitleDiv).CssClass = "IFrameTitle draggable";
			}
			else
			{
				MPEIFrameContainer.PopupDragHandleControlID = "hTCForIFramePopup";
				((WebControl)IFrameTitleDiv).CssClass = "IFrameTitle";
			}
			string[] array = Strings.Split(objIFrameInfo.IFrameUrl, "?", -1, (CompareMethod)0);
			if (array.Count() == 2)
			{
				if (!array[1].Contains("IsInIFrame="))
				{
					objIFrameInfo.IFrameUrl += "&IsInIFrame=S";
				}
			}
			else
			{
				objIFrameInfo.IFrameUrl += "?IsInIFrame=S";
			}
			array = Strings.Split(objIFrameInfo.IFrameUrl, "?", -1, (CompareMethod)0);
			string text = array[1];
			IboCrypt val = new IboCrypt();
			objIFrameInfo.IFrameUrl = array[0] + "?ck=" + val.EncryptString128Bit(text);
			((HtmlControl)MasterIFrame).Attributes["src"] = Strings.Replace(objIFrameInfo.IFrameUrl, "\\", "/", 1, -1, (CompareMethod)0);
			objIFrameInfo.IFrameClosed = false;
			((WebControl)IFrameContainer).CssClass = "IFrameContainer";
			if (objIFrameInfo.IFrameDimension == IFrameDimension.IFrameContainerCustomDefinition)
			{
				Panel iFrameContainer;
				((WebControl)(iFrameContainer = IFrameContainer)).CssClass = ((WebControl)iFrameContainer).CssClass + " " + objIFrameInfo.IFrameDimensionCustomCssClass;
			}
			else if (objIFrameInfo.IFrameDimension != 0)
			{
				Panel iFrameContainer;
				((WebControl)(iFrameContainer = IFrameContainer)).CssClass = ((WebControl)iFrameContainer).CssClass + " " + objIFrameInfo.IFrameDimension;
			}
			((Control)IFrameCloseButton).Visible = objIFrameInfo.IFrameCloseButtonVisible;
			if (SessionEnvironment.IframeInfoList.ContainsKey(objIFrameInfo.IFrameCaller))
			{
				SessionEnvironment.IframeInfoList.Remove(objIFrameInfo.IFrameCaller);
			}
			SessionEnvironment.IframeInfoList.Add(objIFrameInfo.IFrameCaller, objIFrameInfo);
			MPEIFrameContainer.Show();
			IFrameManager_StartPolling.Value = "1";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void CloseIFrame()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IframeInfo iframeInfo = SessionEnvironment.IframeInfoList[WFIPage.EntryPoint];
			((Control)IFramePopupExtenderContainer).Visible = false;
			((Control)IFrameGlobalContainer).Visible = false;
			((Control)IFrameContainer).Visible = false;
			((Control)MasterIFrame).Visible = false;
			((HtmlControl)MasterIFrame).Attributes["src"] = "";
			MPEIFrameContainer.Hide();
			UPIFrame.Update();
			iframeInfo.IFrameObjectReturn = RuntimeHelpers.GetObjectValue(SessionEnvironment.IFrameObjTag);
			if (iframeInfo.IFrameObjectReturn != null)
			{
				WFIPage wFIPage = WFIPage;
				string iFrameTag = iframeInfo.IFrameTag;
				object? objectValue = RuntimeHelpers.GetObjectValue(iframeInfo.IFrameObjectReturn);
				string rsMess = "";
				wFIPage.IFrameClosed(iFrameTag, objectValue, ref rsMess);
			}
			else if (iframeInfo.IFrameAlwaysRaiseCloseEvent)
			{
				WFIPage wFIPage2 = WFIPage;
				string iFrameTag2 = iframeInfo.IFrameTag;
				string rsMess = "";
				wFIPage2.IFrameClosed(iFrameTag2, "ANNULLA", ref rsMess);
			}
			SessionEnvironment.IFrameTag = "";
			SessionEnvironment.IFrameObjTag = null;
			SessionEnvironment.IframeInfoList.Remove(WFIPage.EntryPoint);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ReturnFromIFrame(ref object objTag1)
	{
		try
		{
			IframeInfo iFrameInfoByUrl = SessionEnvironment.IframeInfoList.GetIFrameInfoByUrl(WFIPage.EntryPoint);
			if (iFrameInfoByUrl == null)
			{
				iFrameInfoByUrl = SessionEnvironment.IframeInfoList.GetIFrameInfoByUrl(WFIPage.PageName);
			}
			SessionEnvironment.IFrameObjTag = RuntimeHelpers.GetObjectValue(objTag1);
			iFrameInfoByUrl.IFrameObjectReturn = RuntimeHelpers.GetObjectValue(SessionEnvironment.IFrameObjTag);
			iFrameInfoByUrl.IFrameClosed = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void IFrameManager_StopPolling_Click(object sender, EventArgs e)
	{
		IFrameManager_StartPolling.Value = "";
		try
		{
			IframeInfo iframeInfo = SessionEnvironment.IframeInfoList[WFIPage.EntryPoint];
			if (iframeInfo.IFrameClosed)
			{
				CloseIFrame();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void IFrameCloseButton_Click(object sender, ImageClickEventArgs e)
	{
		CloseIFrame();
	}

	public void SetIframeHeightAutoResize()
	{
		IFrameManager_AutoResize.Value = "1";
	}

	public void MasterUpdateProgressConfig(bool Visibile, int DisplayAfter)
	{
		UpdProgressMaster.DisplayAfter = DisplayAfter;
		((Control)UpdProgressMaster).Visible = Visibile;
	}

	public void MasterUpdateProgressConfig(bool Visibile, int DisplayAfter, string Text)
	{
		UpdProgressMaster.DisplayAfter = DisplayAfter;
		((Control)UpdProgressMaster).Visible = Visibile;
		MasterUpdateProgressSetText(Text);
	}

	public void MasterUpdateProgressSetText(string Text)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Label)((Control)UpdProgressMaster).FindControl("lblWaitMessage");
		val.Text = Text;
		if (Operators.CompareString(Text, "", false) != 0)
		{
			((Control)val).Visible = true;
		}
		else
		{
			((Control)val).Visible = false;
		}
		((UpdatePanel)((Control)UpdProgressMaster).FindControl("up_UpdProgressMaster")).Update();
	}

	protected void mnuMain_MenuItemClick(object sender, MenuEventArgs e)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		try
		{
			string text = "";
			string text2 = "";
			text = Strings.Split(e.Item.Value, "ç", -1, (CompareMethod)0)[1];
			text2 = Strings.Split(e.Item.Value, "ç", -1, (CompareMethod)0)[0];
			((IIboMenuClickable)((Control)this).Page).mnuMainItemClick(RuntimeHelpers.GetObjectValue(sender), new IboMenuEventArgs(ref e, text, text2));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void mnuMainTlk_MenuItemClick(object sender, RadMenuEventArgs e)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		try
		{
			string text = "";
			string text2 = "";
			text = Strings.Split(e.Item.Value, "ç", -1, (CompareMethod)0)[1];
			text2 = Strings.Split(e.Item.Value, "ç", -1, (CompareMethod)0)[0];
			((IIboMenuClickable)((Control)this).Page).mnuMainItemClick(RuntimeHelpers.GetObjectValue(sender), new IboMenuEventArgsTlk(ref e, text, text2));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void ToolbarMain_ToolbarClick(object sender, IboWebToolbarEventArgs e)
	{
		try
		{
			((IIboToolbarClickable)((Control)this).Page).ToolbarItemClick(RuntimeHelpers.GetObjectValue(sender), e);
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
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		if (((UserControl)this).Request.UserAgent.Contains("AppleWebKit"))
		{
			((HttpCapabilitiesBase)((UserControl)this).Request.Browser).Adapters.Clear();
		}
		FaviconManager();
		string text = ((HtmlControl)BodyTag).Attributes["Class"] ?? "";
		((HtmlControl)BodyTag).Attributes["Class"] = text + " Browser_" + SessionEnvironment.WFIUserAgentType + " " + WFIPage.EntryPoint.Replace(".", "_").Replace("#", "-");
		((HtmlControl)BodyTag).Attributes["Class"] = ((HtmlControl)BodyTag).Attributes["Class"].Trim();
		BrowserDetect.Value = SessionEnvironment.WFIUserAgentType;
		if (!SessionEnvironment.WFIConfig.Initialized)
		{
			SessionEnvironment.Session["ConfigFile"] = "";
			SessionEnvironment.Session["DBConfigFile"] = "";
			if (Operators.CompareString(((UserControl)this).Request.QueryString["CF"], "", false) != 0)
			{
				SessionEnvironment.Session["ConfigFile"] = Incasbo.Security.ConfigNames.Sanitize(((UserControl)this).Request.QueryString["CF"]);
			}
			if (Operators.CompareString(((UserControl)this).Request.QueryString["DBCFG"], "", false) != 0)
			{
				SessionEnvironment.Session["DBConfigFile"] = Incasbo.Security.ConfigNames.Sanitize(((UserControl)this).Request.QueryString["DBCFG"]);
			}
			SessionEnvironment.WebApplicationIniConfigFile = SessionEnvironment.WebApplicationIniConfigFile.Replace("<%CFG%>", SessionEnvironment.Session["ConfigFile"].ToString());
			SessionEnvironment.WebApplicationDBConfigFile = SessionEnvironment.WebApplicationDBConfigFile.Replace("<%CFG%>", SessionEnvironment.Session["DBConfigFile"].ToString());
			SessionEnvironment.WFIConfig.Init(SessionEnvironment.WebApplicationWFIIniConfigDir + SessionEnvironment.WebApplicationIniConfigFile, SessionEnvironment.WebApplicationIniConfigDir + SessionEnvironment.WebApplicationIniConfigFile, SessionEnvironment.WebApplicationWFIIniConfigDir + SessionEnvironment.WebApplicationDBConfigFile, SessionEnvironment.WebApplicationIniConfigDir + SessionEnvironment.WebApplicationDBConfigFile);
			if (!((UserControl)this).Application.AllKeys.Contains("WFIConfig"))
			{
				((UserControl)this).Application.Add("WFIConfig", (object)SessionEnvironment.WFIConfig);
			}
		}
		if (((UserControl)this).IsPostBack)
		{
			return;
		}
		try
		{
			WFIConfig wFIConfig = SessionEnvironment.WFIConfig;
			if (wFIConfig.ExistsConfig)
			{
				if (Operators.CompareString(wFIConfig.AutoTooltipifyConfig.Type, "TELERIK", false) == 0)
				{
					((RadWebControl)ToolTipManager).Visible = wFIConfig.AutoTooltipifyConfig.Enable;
					((RadToolTipBase)ToolTipManager).Animation = (ToolTipAnimation)Enum.Parse(typeof(ToolTipAnimation), wFIConfig.AutoTooltipifyConfig.Animation);
					((RadToolTipBase)ToolTipManager).AnimationDuration = wFIConfig.AutoTooltipifyConfig.AnimationDuration;
					((RadToolTipBase)ToolTipManager).ContentScrolling = (ToolTipScrolling)Enum.Parse(typeof(ToolTipScrolling), wFIConfig.AutoTooltipifyConfig.ContentScrolling);
					if (wFIConfig.AutoTooltipifyConfig.Height != 0)
					{
						((RadToolTipBase)ToolTipManager).Height = (System.Web.UI.WebControls.Unit)(wFIConfig.AutoTooltipifyConfig.Height);
					}
					if (wFIConfig.AutoTooltipifyConfig.Width != 0)
					{
						((RadToolTipBase)ToolTipManager).Width = (System.Web.UI.WebControls.Unit)(wFIConfig.AutoTooltipifyConfig.Width);
					}
					((RadToolTipBase)ToolTipManager).Position = (ToolTipPosition)Enum.Parse(typeof(ToolTipPosition), wFIConfig.AutoTooltipifyConfig.Position);
					((RadToolTipBase)ToolTipManager).RelativeTo = (ToolTipRelativeDisplay)Enum.Parse(typeof(ToolTipRelativeDisplay), wFIConfig.AutoTooltipifyConfig.RelativeTo);
					((RadToolTipBase)ToolTipManager).ShowCallout = wFIConfig.AutoTooltipifyConfig.ShowCallout;
					((RadToolTipBase)ToolTipManager).AutoCloseDelay = wFIConfig.AutoTooltipifyConfig.AutoCloseDelay;
				}
				else if (wFIConfig.AutoTooltipifyConfig.Enable)
				{
					JqueryToolTipManagerEnable.Value = "1";
					JqueryToolTipManagerDuration.Value = wFIConfig.AutoTooltipifyConfig.AutoCloseDelay.ToString();
					JqueryToolTipManager_NotCloseIfHover.Value = (wFIConfig.AutoTooltipifyConfig.NotCloseIfHover ? "1" : "0");
					JqueryToolTipManager_AnimationDuration.Value = wFIConfig.AutoTooltipifyConfig.AnimationDuration.ToString();
					JqueryToolTipManager_ShowDelay.Value = wFIConfig.AutoTooltipifyConfig.ShowDelay.ToString();
				}
				else
				{
					JqueryToolTipManagerEnable.Value = "";
				}
			}
			wFIConfig = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void Page_Load(object sender, EventArgs e)
	{
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		PerformanceLogAppend("Begin Load WFI Master Page");
		if (Operators.CompareString(ScreenDimensions.Value, "", false) != 0)
		{
			try
			{
				string[] array = Strings.Split(ScreenDimensions.Value, ";", -1, (CompareMethod)0);
				SessionEnvironment.ScreenResolutionY = Conversions.ToInteger(array[0]);
				SessionEnvironment.ScreenResolutionX = Conversions.ToInteger(array[1]);
				SessionEnvironment.WindowHeight = Conversions.ToInteger(array[2]);
				SessionEnvironment.WindowWidth = Conversions.ToInteger(array[3]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (((UserControl)this).Session["Masterpage.PanelTopHeaderVisible"] == null)
		{
			((UserControl)this).Session["Masterpage.PanelTopHeaderVisible"] = SessionEnvironment.WFIConfig.MasterPageConfig.PanelTopHeaderVisible;
		}
		if (((UserControl)this).Session["LastWfiPages"] == null)
		{
			((UserControl)this).Session["LastWfiPages"] = new Queue<string>(21);
		}
		if ((Operators.CompareString(((UserControl)this).Request.QueryString["IsInIFrame"] ?? "", "S", false) == 0) | (Operators.CompareString(((UserControl)this).Request.QueryString["IsAllreadyInIFrame"] ?? "", "S", false) == 0))
		{
			((Control)Collapser).Visible = false;
			((Control)PanelTopHeader).Visible = true;
			((Control)ThinPanelTopHeader).Visible = false;
			((WebControl)PanelTopHeader).Attributes.Add("class", "WFIHidden");
			((WebControl)PanelHeader).Attributes.Add("class", "WFIHidden");
			((WebControl)PanelContent).CssClass = "PanelContentInFrame";
			((WebControl)PanelContentX).CssClass = "PanelContentXInFrame";
			((Control)PanelFooter).Visible = false;
		}
		else
		{
			((Control)PanelTopHeader).Visible = PanelTopHeaderVisible;
			((Control)ThinPanelTopHeader).Visible = !((Control)PanelTopHeader).Visible;
			((Control)Collapser).Visible = CanCollapse;
		}
		((UserControl)this).Response.ExpiresAbsolute = DateTime.Now.AddDays(-1.0);
		((UserControl)this).Response.Expires = -1500;
		((UserControl)this).Response.Cache.SetCacheability((HttpCacheability)1);
		((UserControl)this).Response.CacheControl = "no-cache";
		((UserControl)this).Response.AddHeader("Pragma", "no-cache");
		((UserControl)this).Response.AddHeader("cache-control", "no-store");
		((Control)ToolbarMain).Visible = true;
		if (Operators.CompareString(((Control)this).Page.Title, "", false) != 0)
		{
			((Control)this).Page.Title = SessionEnvironment.WebSoftwareModuleTitleAcronym + "-" + ((Control)this).Page.Title;
		}
		else
		{
			((Control)this).Page.Title = SessionEnvironment.WebSoftwareModuleTitleAcronym;
		}
		lblMasterTitoloModuloSoftware.Text = SessionEnvironment.WebSoftwareModuleTitle;
		ThinLblMasterTitoloModuloSoftware.Text = SessionEnvironment.WebSoftwareModuleTitle;
		if (!((UserControl)this).IsPostBack)
		{
			try
			{
				lblMasterUtenteApplicazione.Text = TranslateMessage("XXX", "{0}Utente:{1} {2}", "<strong>", "</strong>", SessionEnvironment.WebUser.WebUserInfo.Descrizione);
				LogOFF.Visible = CanLogOff;
				LogOFF.ToolTip = Translator.TranslateMessage("XXX", "{0}Utente:{1} {2}-{3}{4}%PlaceHolder%{4}{5}Sistema:{6} {7}{8}{9}<hr/>Disconnetti l'utente attualmente loggato al sistema{10}", new string[11]
				{
					"<strong>",
					"</strong>",
					SessionEnvironment.WebUser.WebUserInfo.Codice,
					SessionEnvironment.WebUser.WebUserInfo.Descrizione,
					"<br />",
					"<strong>",
					"</strong>",
					SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Description,
					"<br />",
					"<i>",
					"</i>"
				});
				ThinLogOff.Visible = CanLogOff;
				Filiale.Visible = CanChangeFiliale;
				Filiale.ToolTip = Translator.TranslateMessage("XXX", "{0}Filiale attiva:{1} {2}{3}{4}Cambia la filiale attiva{5}", new string[6]
				{
					"<strong>",
					"</strong>",
					SessionEnvironment.WebUser.WebUserInfo.FilialeDescrizione,
					"<br />",
					"<i>",
					"</i>"
				});
				ThinFiliale.ToolTip = Filiale.ToolTip;
				ThinFiliale.Visible = SessionEnvironment.WFIConfig.MasterPageConfig.StandardHeaderFilialeVisible & CanChangeFiliale;
				if (Operators.CompareString(SessionEnvironment.WebUser.WebUserInfo.Filiale, "", false) != 0)
				{
					lblMasterFilialeApplicazione.Text = TranslateMessage("XXX", "{0}Filiale:{1} {2}", "<strong>", "</strong>", SessionEnvironment.WebUser.WebUserInfo.FilialeDescrizione);
				}
				else
				{
					lblMasterFilialeApplicazione.Text = "";
				}
				lblMasterOrganizzazioneApplicazione.Text = TranslateMessage("XXX", "{0}Organizzazione:{1} {2}", "<strong>", "</strong>", SessionEnvironment.WebUser.Organization.WebUserInfo.Descrizione);
				MPGeneralSearchLabel.Visible = true;
				MPGeneralSearch.Visible = true;
				((Control)lblMasterTitoloModuloSoftware).Visible = true;
				((Control)ThinLblMasterTitoloModuloSoftware).Visible = true;
				if (!SessionEnvironment.WFIConfig.MasterPageConfig.StandardHeaderFilialeVisible)
				{
					((Control)PanelTopHeader3Table_R2).Visible = false;
					LogOFF.ToolTip = LogOFF.ToolTip.Replace("%PlaceHolder%", lblMasterOrganizzazioneApplicazione.Text);
				}
				if (!SessionEnvironment.WFIConfig.MasterPageConfig.StandardHeaderUserVisible)
				{
					((Control)PanelTopHeader3Table_R1).Visible = false;
				}
				if (!SessionEnvironment.WFIConfig.MasterPageConfig.StandardHeaderOrganizationVisible)
				{
					((Control)PanelTopHeader3Table_R3).Visible = false;
					LogOFF.ToolTip = LogOFF.ToolTip.Replace("%PlaceHolder%", lblMasterFilialeApplicazione.Text);
				}
				ThinLogOff.ToolTip = LogOFF.ToolTip;
				KeepAlive_StartPolling.Value = SessionEnvironment.WFIConfig.WFIPageConfig.KeepAliveFrequency.ToString();
				PanelBottomL_Content.Text = "<div class='sistema'><span class='sistemaDescr'>Sistema: </span><span class='sistemaValue'>" + SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Description + "</span></div><div class='sistema'><span class='utenteDescr'>Utente: </span><span class='utenteValue'>" + SessionEnvironment.WebUser.WebUserInfo.Descrizione + " (" + SessionEnvironment.WebUser.WebUserInfo.Codice + ")</span></div>";
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				lblMasterUtenteApplicazione.Text = "";
				lblMasterFilialeApplicazione.Text = "";
				MPGeneralSearchLabel.Visible = false;
				MPGeneralSearch.Visible = false;
				((Control)lblMasterTitoloModuloSoftware).Visible = false;
				((Control)ThinLblMasterTitoloModuloSoftware).Visible = false;
				ProjectData.ClearProjectError();
			}
		}
		if (!((UserControl)this).IsPostBack)
		{
			try
			{
				((Control)imgGoToHomeLnk).Visible = false;
				((HtmlControl)PanelHeaderLeft).Attributes["class"] = "GoToHomePanelNotVisible";
				if (SessionEnvironment.WebUser != null && SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.Authenticated)
				{
					((Control)imgGoToHomeLnk).Visible = true;
					((WebControl)imgGoToHomeLnk).ToolTip = TranslateMessage("XXX", "Vai alla pagina iniziale");
					((HtmlControl)PanelHeaderLeft).Attributes["class"] = "GoToHomePanelVisible";
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			try
			{
				WFIConfig wFIConfig = SessionEnvironment.WFIConfig;
				if (wFIConfig.ExistsConfig)
				{
					NotificationMessage.Width = (System.Web.UI.WebControls.Unit)(wFIConfig.NotificationMessageConfig.Width);
					if (wFIConfig.NotificationMessageConfig.Height.HasValue)
					{
						int? height = wFIConfig.NotificationMessageConfig.Height;
						if ((height.HasValue ? new bool?(height.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							NotificationMessage.Height = default(Unit);
							((RadWebControl)NotificationMessage).CssClass = "WFINotificationMessage FreeHeight";
						}
						else
						{
							NotificationMessage.Height = (System.Web.UI.WebControls.Unit)(wFIConfig.NotificationMessageConfig.Height.Value);
							((RadWebControl)NotificationMessage).CssClass = "WFINotificationMessage";
						}
					}
					else
					{
						NotificationMessage.Height = default(Unit);
						((RadWebControl)NotificationMessage).CssClass = "WFINotificationMessage AutoHeight";
					}
					NotificationMessage.Animation = (NotificationAnimation)Enum.Parse(typeof(NotificationAnimation), wFIConfig.NotificationMessageConfig.Animation);
					NotificationMessage.EnableRoundedCorners = wFIConfig.NotificationMessageConfig.EnableRoundedCorners;
					NotificationMessage.EnableShadow = wFIConfig.NotificationMessageConfig.EnableShadow;
					NotificationMessage.Position = (NotificationPosition)Enum.Parse(typeof(NotificationPosition), wFIConfig.NotificationMessageConfig.Position);
					NotificationMessage.AutoCloseDelay = wFIConfig.NotificationMessageConfig.AutoCloseDelay;
					NotificationMessage.ContentScrolling = (NotificationScrolling)Enum.Parse(typeof(NotificationScrolling), wFIConfig.NotificationMessageConfig.Position);
				}
				wFIConfig = null;
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (Operators.CompareString(SessionEnvironment.WFIConfig.ApplicationConfig.LogoIncas, "", false) != 0)
			{
				imgMasterLogoIncas.ImageUrl = SessionEnvironment.WFIConfig.ApplicationConfig.LogoIncas;
				ThinImgMasterLogoIncas.ImageUrl = SessionEnvironment.WFIConfig.ApplicationConfig.LogoIncas;
			}
			else
			{
				((Control)imgMasterLogoIncas).Visible = false;
				((Control)ThinImgMasterLogoIncas).Visible = false;
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Operators.CompareString(SessionEnvironment.WFIConfig.ApplicationConfig.LogoDitta, "", false) == 0)
			{
				((Control)imgMasterLogoCliente).Visible = false;
				((Control)ThinImgMasterLogoCliente).Visible = false;
			}
			else
			{
				imgMasterLogoCliente.ImageUrl = SessionEnvironment.WFIConfig.ApplicationConfig.LogoDitta;
				((Control)imgMasterLogoCliente).Visible = true;
				ThinImgMasterLogoCliente.ImageUrl = SessionEnvironment.WFIConfig.ApplicationConfig.LogoDitta;
				((Control)ThinImgMasterLogoCliente).Visible = true;
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			ProjectData.ClearProjectError();
		}
		if (!((Control)this).Page.IsPostBack)
		{
			try
			{
				string text = "";
				if (SessionEnvironment.WebUser != null)
				{
					PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties((object)SessionEnvironment.WFIConfig.CookiesConfig);
					PropertyInfo[] array2 = publicProperties;
					foreach (PropertyInfo propertyInfo in array2)
					{
						if (IncasReflection.GetPropertyValue((object)SessionEnvironment.WFIConfig.CookiesConfig, propertyInfo.Name) != null)
						{
							if (Operators.CompareString(text, "", false) != 0)
							{
								text += ",";
							}
							if ((object)propertyInfo.PropertyType == typeof(string))
							{
								text = text + "\"" + propertyInfo.Name + "\":\"" + IncasReflection.GetPropertyValue((object)SessionEnvironment.WFIConfig.CookiesConfig, propertyInfo.Name).ToString() + "\"";
							}
							else if ((object)propertyInfo.PropertyType == typeof(bool?))
							{
								text = text + "\"" + propertyInfo.Name + "\":" + (Conversions.ToBoolean(IncasReflection.GetPropertyValue((object)SessionEnvironment.WFIConfig.CookiesConfig, propertyInfo.Name)) ? "true" : "false");
							}
							else if ((object)propertyInfo.PropertyType == typeof(int?))
							{
								text = text + "\"" + propertyInfo.Name + "\":" + Conversions.ToInteger(IncasReflection.GetPropertyValue((object)SessionEnvironment.WFIConfig.CookiesConfig, propertyInfo.Name));
							}
							else if ((object)propertyInfo.PropertyType == typeof(bool))
							{
								text = text + "\"" + propertyInfo.Name + "\":" + (Conversions.ToBoolean(IncasReflection.GetPropertyValue((object)SessionEnvironment.WFIConfig.CookiesConfig, propertyInfo.Name)) ? "true" : "false");
							}
						}
					}
				}
				else
				{
					text = "\"Enabled\":false";
				}
				text = "var _WFICookiesBarConfig = {" + text + "};";
				((Control)this).Page.ClientScript.RegisterClientScriptBlock(((object)((Control)this).Page).GetType(), "WFICookiesBarConfig", text, true);
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				ProjectData.ClearProjectError();
			}
		}
		PerformanceLogAppend("End Load WFI Master Page");
	}

	protected virtual void Page_PreRender(object sender, EventArgs e)
	{
		try
		{
			if (((Control)ThinPanelTopHeader).Visible)
			{
				((WebControl)CollapserContainer).CssClass = "CollapserContainer2";
			}
			else
			{
				((WebControl)CollapserContainer).CssClass = "CollapserContainer";
			}
			if (Operators.CompareString(MasterPanelTopTitle.ObjValue.ToString(), "", false) == 0)
			{
				MasterPanelTopTitle.Visible = false;
				MasterThinPanelTopTitle.Visible = false;
			}
			if (Operators.CompareString(SessionEnvironment.ErrorMessageCallerPage, WFIPage.PageName, false) != 0 && Operators.CompareString(SessionEnvironment.ErrorMessage, "", false) != 0)
			{
				WFIPage.WriteErrorMessage(SessionEnvironment.ErrorMessageTitle, Strings.Replace(SessionEnvironment.ErrorMessage, "\r\n", "<br/>", 1, -1, (CompareMethod)0));
				SessionEnvironment.ErrorMessage = "";
				SessionEnvironment.ErrorMessageTitle = "";
				SessionEnvironment.ErrorMessageCallerPage = "";
			}
			HF_LastPostBack.Value = DateAndTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
			HF_IsPostBack.Value = (((UserControl)this).IsPostBack ? "1" : "0");
			up_LastPostback.Update();
			if (FullScreen)
			{
				string text = ((HtmlControl)BodyTag).Attributes["Class"] ?? "";
				((HtmlControl)BodyTag).Attributes["Class"] = text + " WFIFullScreen";
				((HtmlControl)BodyTag).Attributes["Class"] = ((HtmlControl)BodyTag).Attributes["Class"].Trim();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void Collapser_Click(object sender, ImageClickEventArgs e)
	{
		try
		{
			PanelTopHeaderVisible = !PanelTopHeaderVisible;
			((Control)PanelTopHeader).Visible = PanelTopHeaderVisible;
			((Control)ThinPanelTopHeader).Visible = !((Control)PanelTopHeader).Visible;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			CollapserPressed?.Invoke(this, new EventArgs());
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void imgGoToHomeLnk_Click(object sender, ImageClickEventArgs e)
	{
		try
		{
			HomeButtonPressed?.Invoke(this, new EventArgs());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	[ScriptMethod]
	[WebMethod(EnableSession = true)]
	public static List<string> GetSearchItems(string prefixText, int count)
	{
		List<string> list = new List<string>();
		List<string> result;
		try
		{
			if (Operators.CompareString(Strings.Left(prefixText, 1), ".", false) == 0)
			{
				prefixText = Strings.Mid(prefixText, 2);
				DataTable functionListDatatable = ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).FunctionListDatatable;
				DataRow[] array = functionListDatatable.Select("DESCRIZIONE LIKE '%" + prefixText + "%' or SEARCHTAG LIKE '%" + prefixText + "%'", "DESCRIZIONE");
				DataRow[] array2 = array;
				foreach (DataRow dataRow in array2)
				{
					list.Add(AutoCompleteExtender.CreateAutoCompleteItem(dataRow["Descrizione"].ToString(), dataRow["Codice"].ToString()));
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
			result = list;
		}
		return result;
	}

	protected virtual void MPGeneralSearchGo_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string rsmess = "";
			WFIPage wFIPage = WFIPage;
			if (Operators.CompareString(HFMPGeneralSearch.Value, "", false) != 0)
			{
				string value = HFMPGeneralSearch.Value;
				string rsmess2 = "";
				wFIPage.CallDirectFunction(value, bSearchByActionCode: false, ref rsmess2);
				return;
			}
			if (Operators.CompareString(Strings.Left(MPGeneralSearch.Text, 1), ".", false) == 0)
			{
				string sCodiceVoce = Strings.Mid(MPGeneralSearch.Text, 2);
				string rsmess2 = "";
				wFIPage.CallDirectFunction(sCodiceVoce, bSearchByActionCode: false, ref rsmess2);
				return;
			}
			wFIPage.CallDirectFunction(MPGeneralSearch.Text, bSearchByActionCode: true, ref rsmess);
			if (Operators.CompareString(rsmess, "", false) != 0)
			{
				wFIPage.WriteInfoMessage(rsmess, ShowAsNotification: true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public virtual void MasterPopupFormOpen(string Title, Control ContentObject, string Tag)
	{
		MasterPopupFormOpen(Title, ContentObject, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, Tag);
	}

	public virtual void MasterPopupFormOpen(string Title, Control ContentObject, bool ButtonsVisible, bool ButtonsOkVisible, bool ButtonsAnnullaVisible, string Tag, string CssClass)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
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
			popupFormInfo._AreInOpeningPhase = true;
			popupFormInfo.CssClass = CssClass;
			Control masterPopupFormBody = (Control)(object)MasterPopupFormBody;
			Control masterPopupFormButtons = (Control)(object)MasterPopupFormButtons;
			Button masterPopupForm_cmdOk = (Button)(object)MasterPopupForm_cmdOk;
			Button masterPopupForm_cmdAnnulla = (Button)(object)MasterPopupForm_cmdAnnulla;
			ModalPopupExtender masterPopupForm = MasterPopupForm;
			IIboWebComponent masterPopupFormCaption = (IIboWebComponent)(object)MasterPopupFormCaption;
			Panel masterPopupFormGlobalContainer = MasterPopupFormGlobalContainer;
			UpdatePanel uPMasterPopupForm = UPMasterPopupForm;
			Control parent = popupFormInfo.ContentObject.Parent;
			foreach (Control control in parent.Controls)
			{
				Control val = control;
				val.Visible = false;
			}
			popupFormInfo.ContentObject.Visible = true;
			masterPopupFormButtons.Visible = popupFormInfo.ButtonsVisible;
			((Control)masterPopupForm_cmdOk).Visible = popupFormInfo.ButtonsOkVisible;
			((Control)masterPopupForm_cmdAnnulla).Visible = popupFormInfo.ButtonsAnnullaVisible;
			masterPopupFormCaption.Text = popupFormInfo.Title;
			SessionEnvironment.PopupFormInfo = popupFormInfo;
			((Control)masterPopupFormGlobalContainer).Visible = true;
			if (Operators.CompareString(popupFormInfo.CssClass, "", false) != 0)
			{
				((WebControl)masterPopupFormGlobalContainer).CssClass = popupFormInfo.CssClass;
			}
			uPMasterPopupForm.Update();
			UPMasterPopupFormGlobalContainer.Update();
			masterPopupForm.Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public virtual void MasterPopupFormOpen(string Title, Control ContentObject, bool ButtonsVisible, bool ButtonsOkVisible, bool ButtonsAnnullaVisible, string Tag)
	{
		MasterPopupFormOpen(Title, ContentObject, ButtonsVisible, ButtonsOkVisible, ButtonsAnnullaVisible, Tag, "");
	}

	public void MasterPopupForm_cmdOk_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		WFIPopupFormInfo objPopupInfo = SessionEnvironment.PopupFormInfo;
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		ModalPopupExtender masterPopupForm = MasterPopupForm;
		val = MasterPopupFormCheckData(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WFIPage.WriteErrorMessage(rsMess);
			masterPopupForm.Show();
			return;
		}
		val = MasterPopupFormOkClick(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WFIPage.WriteErrorMessage(rsMess);
			masterPopupForm.Show();
		}
		else if (!objPopupInfo._AreInOpeningPhase)
		{
			if (objPopupInfo.CloseOnConfirm)
			{
				masterPopupForm.Hide();
			}
			else
			{
				masterPopupForm.Show();
			}
		}
		else
		{
			masterPopupForm.Show();
		}
	}

	public void MasterPopupForm_cmdAnnulla_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		WFIPopupFormInfo objPopupInfo = SessionEnvironment.PopupFormInfo;
		ModalPopupExtender masterPopupForm = MasterPopupForm;
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		val = MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
		if ((int)val > 0)
		{
			WFIPage.WriteErrorMessage(rsMess);
		}
		if (objPopupInfo.CloseOnExit)
		{
			masterPopupForm.Hide();
		}
		else
		{
			masterPopupForm.Show();
		}
	}

	protected virtual FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = WFIPage.MasterPopupFormOkClick(ref objPopupInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (objPopupInfo._AreInOpeningPhase && !objPopupInfo.CloseOnConfirm)
				{
					objPopupInfo.ContentObject.Visible = false;
					objPopupInfo.Visible = false;
					Control masterPopupFormGlobalContainer = (Control)(object)MasterPopupFormGlobalContainer;
					masterPopupFormGlobalContainer.Visible = false;
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

	protected virtual FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = WFIPage.MasterPopupFormCheckData(ref objPopupInfo, ref rsMess);
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

	protected virtual FXRETURN MasterPopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = WFIPage.MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				objPopupInfo.ContentObject.Visible = false;
				objPopupInfo.Visible = false;
				Control masterPopupFormGlobalContainer = (Control)(object)MasterPopupFormGlobalContainer;
				masterPopupFormGlobalContainer.Visible = false;
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

	protected virtual void MasterPopupForm_PreRender(object sender, EventArgs e)
	{
		try
		{
			WFIPopupFormInfo popupFormInfo = SessionEnvironment.PopupFormInfo;
			popupFormInfo._AreInOpeningPhase = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void MasterPopupFormUpdate()
	{
		UPMasterPopupForm.Update();
	}

	public void PerformanceLogAppend(string sMessaggioLog)
	{
		WFIPage.PerformanceLogAppend(sMessaggioLog);
	}

	public void PerformanceLogFlush(string sMessaggioLog)
	{
		WFIPage.PerformanceLogFlush(sMessaggioLog);
	}

	public void WriteJavascriptEval(string JavascriptCode)
	{
		JavascriptEval.Value = JavascriptCode;
		UP_JavascriptEval.Update();
	}

	public void OpenWindowOnClientLoadPage(WindowPopupProperties WindowProp)
	{
		string text = "window.open(\"<%indirizzo%>\",\"_blank\",\"toolbar=no, scrollbars=yes, resizable=yes, titlebar=no, menubar=no, location=no top=<%top%>, left=<%left%>, width=<%width%>, height=<%height%>\");";
		text = text.Replace("<%indirizzo%>", WindowProp.Address);
		text = text.Replace("<%top%>", WindowProp.Top.ToString());
		text = text.Replace("<%left%>", WindowProp.Left.ToString());
		text = text.Replace("<%width%>", WindowProp.Width.ToString());
		text = text.Replace("<%height%>", WindowProp.Height.ToString());
		if (Operators.CompareString(WindowProp.JavascriptVar, "", false) != 0)
		{
			text = WindowProp.JavascriptVar + " = " + text;
		}
		if (!WindowProp.MultipleInstance & (Operators.CompareString(WindowProp.JavascriptVar, "", false) != 0))
		{
			text = "if ( <%var%> != undefined) { if (<%var%>.closed) {<%var%> = undefined;} }; if ( <%var%> == undefined) { " + text + " };";
			text = text.Replace("<%var%>", WindowProp.JavascriptVar);
		}
		WriteJavascriptEval(text);
	}

	public void ToolTipManagerDisable()
	{
		if (Operators.CompareString(SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Type, "TELERIK", false) == 0)
		{
			((RadWebControl)ToolTipManager).Visible = false;
			return;
		}
		JqueryToolTipManagerEnable.Value = "";
		UP_TooltipManager.Update();
	}

	public void ToolTipManagerEnable()
	{
		if (Operators.CompareString(SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Type, "TELERIK", false) == 0)
		{
			((RadWebControl)ToolTipManager).Visible = true;
			return;
		}
		JqueryToolTipManagerEnable.Value = "1";
		UP_TooltipManager.Update();
	}

	public void ToolTipManagerDuration(int duration)
	{
		if (Operators.CompareString(SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Type, "TELERIK", false) == 0)
		{
			((RadToolTipBase)ToolTipManager).AutoCloseDelay = duration;
			return;
		}
		JqueryToolTipManagerDuration.Value = duration.ToString();
		UP_TooltipManager.Update();
	}

	public void LogoIncasVisible(bool bVisible)
	{
		((Control)imgMasterLogoIncas).Visible = bVisible;
		((Control)ThinImgMasterLogoIncas).Visible = bVisible;
	}

	protected void LogOFF_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
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
			IboSessionEnvironment sessionEnvironment = SessionEnvironment;
			string sRisorsa = SessionEnvironment.WebApplicationName.ToUpper();
			string rsMess2 = "";
			sessionEnvironment.LogRisorseAzioneInserisci(sRisorsa, "LOGOUT", "UI", "", "", ref rsMess2);
			((UserControl)this).Application.Add("SESSIONID." + SessionEnvironment.WebSessionId, (object)".");
			WFIPage.LogOff();
			IboAppCallStackHandling robjCallStackHandler = SessionEnvironment.CallStackHandler;
			BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
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
		}
	}

	protected void Filiale_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			SessionEnvironment.UserSelect.Reset();
			val2 = SelezionaFiliale(ref rsMess);
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
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	protected FXRETURN SelezionaFiliale(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Invalid comparison between Unknown and I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		DataTable dataTable = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		string text = "";
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				int j = default(int);
				while (true)
				{
					flag = false;
					flag3 = true;
					if (flag2)
					{
						SessionEnvironment.UserSelect.Reset();
						SessionEnvironment.UserSelect.Title = TranslateMessage("XXX", "ELENCO FILIALI");
						SessionEnvironment.UserSelect.Subtitle = TranslateMessage("XXX", "Selezionare filiale attiva utente {0}", SessionEnvironment.WebUser.WebUserInfo.Descrizione);
						SessionEnvironment.UserSelect.NeedToRefresh = true;
						SessionEnvironment.UserSelect.Type = WFIUserSelect.SelectUserDialogType.RadioButtonList;
						SessionEnvironment.UserSelect.DelegateCallBack = SelezionaFiliale;
						SessionEnvironment.UserSelect.Values = text;
						SessionEnvironment.UserSelect.DefaultSelected = SessionEnvironment.WebUser.WebUserInfo.Filiale;
						SessionEnvironment.UserSelect.Tag = "FILIALE_CHANGED";
						WFIUserSelect UserSel = SessionEnvironment.UserSelect;
						IboSelectBox(ref UserSel);
						flag3 = false;
						MasterUpdateProgress.DisplayAfter = 60000;
					}
					if (SessionEnvironment.UserSelect.UserDialogResult == WFIUserSelect.SelectUserDialogResult.Conferma)
					{
						string selected = SessionEnvironment.UserSelect.Selected;
						string[] array = Strings.Split(SessionEnvironment.UserSelect.Values, ";", -1, (CompareMethod)0);
						int num = array.Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Operators.CompareString(array[i].ToUpper(), selected.ToUpper(), false) == 0)
							{
								SessionEnvironment.WebUser.WebUserInfo.Filiale = array[i];
								SessionEnvironment.WebUser.WebUserInfo.FilialeDescrizione = array[i - 1];
								SessionEnvironment.AppFiliale = array[i];
								break;
							}
						}
						flag3 = false;
					}
					else if (SessionEnvironment.UserSelect.UserDialogResult == WFIUserSelect.SelectUserDialogResult.Annulla)
					{
						SessionEnvironment.UserSelect.Reset();
						flag3 = false;
					}
					if (flag3)
					{
						string text2 = "SELECT WFI.FILIALE,F.DESCRIZIONE FROM WFI_UTENTIFILIALI WFI ";
						text2 += "INNER JOIN FILIALI F ON F.CODICE = WFI.FILIALE ";
						text2 = text2 + "WHERE UTENTE = " + DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice);
						val2 = SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
						if (unchecked((int)val2) > 0)
						{
							break;
						}
						if (dataTable.Rows.Count == 0)
						{
							rsMess = TranslateMessage("XXX", "Non è disponibile nessuna filiale per l'utente {0}", SessionEnvironment.WebUser.WebUserInfo.Codice);
							break;
						}
						for (; j < dataTable.Rows.Count; j++)
						{
							if (text.Length > 0)
							{
								text += ";";
							}
							text = text + dataTable.Rows[j]["DESCRIZIONE"].ToString() + ";" + dataTable.Rows[j]["FILIALE"].ToString();
						}
						flag = true;
						flag2 = true;
					}
					if (!flag)
					{
						val = (FXRETURN)0;
						break;
					}
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
				if (dataTable != null)
				{
					dataTable.Dispose();
					dataTable = null;
				}
				dataKeyFieldCollection = null;
				result = val;
				CallStackRemove();
			}
			return result;
		}
	}

	private void WFIPostbackRun_Click(object sender, EventArgs e)
	{
		try
		{
			string value = WFIPostbackCommand.Value;
			string value2 = WFIPostbackArguments.Value;
			WFIPage.WFIPostbackRun_Click(value, value2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
