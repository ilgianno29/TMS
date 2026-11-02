using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.CFG;

public class WFAllGrd2 : WFIDBPageMasterDetail2
{
	public struct Cfg_Campi
	{
		public string Name;

		public string Caption;

		public string Align;

		public int Width;

		public string Formattazione;

		public string Visible;
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optCanPage")]
	private IboWebRadioButtonList _optCanPage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtTimerUpdate")]
	private IboWebNumericTlk _txtTimerUpdate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ButtonFilterConferma")]
	private IboWebButton _ButtonFilterConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ButtonFilterReset")]
	private IboWebButton _ButtonFilterReset;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbNomCam")]
	private IboWebComboTlk _cmbNomCam;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbOrdCam")]
	private IboDropDownList _cmbOrdCam;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdTabgrdForSortingDD")]
	private IboGridView _grdTabgrdForSortingDD;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TcMain")]
	protected virtual TabContainer TcMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGen")]
	protected virtual TabPanel tpGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpGenCaption")]
	protected virtual IboWebLabel tpGenCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNomRif")]
	protected virtual IboWebLabel lblNomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNomRif")]
	protected virtual IboWebTextBox txtNomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUtente")]
	protected virtual IboWebLabel lblUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUtente")]
	protected virtual IboWebTextBox txtUtente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDesTab")]
	protected virtual IboWebLabel lblDesTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDesTab")]
	protected virtual IboWebTextBox txtDesTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNomTab")]
	protected virtual IboWebLabel lblNomTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbNomTab")]
	protected virtual IboWebComboTlk cmbNomTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltro")]
	protected virtual IboWebLabel lblFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltro")]
	protected virtual IboWebTextBox txtFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCansel")]
	protected virtual IboWebLabel lblCansel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optCanSel")]
	protected virtual IboWebRadioButtonList optCanSel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_CanPage")]
	protected virtual UpdatePanel up_CanPage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCanPage")]
	protected virtual IboWebLabel lblCanPage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optCanPage
	{
		[CompilerGenerated]
		get
		{
			return _optCanPage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optCanPage_SelectedIndexChanged;
			IboWebRadioButtonList val = _optCanPage;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optCanPage = value;
			val = _optCanPage;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblRowsPerPage")]
	protected virtual IboWebLabel lblRowsPerPage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRowsPerPage")]
	protected virtual IboWebNumericTlk txtRowsPerPage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCanSort")]
	protected virtual IboWebLabel lblCanSort
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optCanSort")]
	protected virtual IboWebRadioButtonList optCanSort
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSelColVisible")]
	protected virtual IboWebLabel lblSelColVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optSelColVisible")]
	protected virtual IboWebRadioButtonList optSelColVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFastFilterType")]
	protected virtual IboWebLabel lblFastFilterType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optFastFilterType")]
	protected virtual IboWebRadioButtonList optFastFilterType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFontSize")]
	protected virtual IboWebLabel lblFontSize
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFontSize")]
	protected virtual IboWebNumericTlk txtFontSize
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBold")]
	protected virtual IboWebLabel lblBold
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBold")]
	protected virtual IboWebCheckBox chkBold
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblItalic")]
	protected virtual IboWebLabel lblItalic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkItalic")]
	protected virtual IboWebCheckBox chkItalic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTimerUpdate")]
	protected virtual IboWebLabel lblTimerUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebNumericTlk txtTimerUpdate
	{
		[CompilerGenerated]
		get
		{
			return _txtTimerUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtTimerUpdate_TextChanged;
			IboWebNumericTlk val = _txtTimerUpdate;
			if (val != null)
			{
				((RadInputControl)val).TextChanged -= eventHandler;
			}
			_txtTimerUpdate = value;
			val = _txtTimerUpdate;
			if (val != null)
			{
				((RadInputControl)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblAutoUpdateVisible")]
	protected virtual IboWebLabel lblAutoUpdateVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAutoUpdateVisible")]
	protected virtual IboWebCheckBox chkAutoUpdateVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblWidth")]
	protected virtual IboWebLabel lblWidth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWidth")]
	protected virtual IboWebNumericTlk txtWidth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblScrollHeight")]
	protected virtual IboWebLabel lblScrollHeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtScrollHeight")]
	protected virtual IboWebNumericTlk txtScrollHeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFixedLayout")]
	protected virtual IboWebLabel lblFixedLayout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFixedLayout")]
	protected virtual IboWebCheckBox chkFixedLayout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMaxRecord")]
	protected virtual IboWebLabel lblMaxRecord
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMaxRecord")]
	protected virtual IboDropDownList cmbMaxRecord
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMaxRecordVisible")]
	protected virtual IboWebLabel lblMaxRecordVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkMaxRecordVisible")]
	protected virtual IboWebCheckBox chkMaxRecordVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblShowFooter")]
	protected virtual IboWebLabel lblShowFooter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShowFooter")]
	protected virtual IboWebCheckBox chkShowFooter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDoc")]
	protected virtual TabPanel tpDoc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDocCaption")]
	protected virtual IboWebLabel tpDocCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabgrd_Title")]
	protected virtual Panel cpTabgrd_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabgrd_Title_Caption")]
	protected virtual IboWebLabel cpTabgrd_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabgrd_Body")]
	protected virtual Panel cpTabgrd_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPTreeViewContent")]
	protected virtual UpdatePanel UPTreeViewContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabgrd_Body_Grid")]
	protected virtual Panel cpTabgrd_Body_Grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTabgrd")]
	protected virtual IboWebToolbar tlbgrdTabgrd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTabgrd")]
	protected virtual IboWebPanel pnlTabgrd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTabgrd")]
	protected virtual IboGridView grdTabgrd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpButtons")]
	protected virtual TabPanel tpButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel2")]
	protected virtual IboWebLabel IboWebLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot_Title")]
	protected virtual Panel cpTabbot_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot_Title_Caption")]
	protected virtual IboWebLabel cpTabbot_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot_Body")]
	protected virtual Panel cpTabbot_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upTabbot")]
	protected virtual UpdatePanel upTabbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot_Body_Grid")]
	protected virtual Panel cpTabbot_Body_Grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTabbot")]
	protected virtual IboWebToolbar tlbgrdTabbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTabbot")]
	protected virtual IboWebPanel pnlTabbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTabbot")]
	protected virtual IboGridView grdTabbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot2_Title")]
	protected virtual Panel cpTabbot2_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot2_Title_Caption")]
	protected virtual IboWebLabel cpTabbot2_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot2_Body")]
	protected virtual Panel cpTabbot2_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upTabbot2")]
	protected virtual UpdatePanel upTabbot2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot2_Body_Grid")]
	protected virtual Panel cpTabbot2_Body_Grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTabbot2")]
	protected virtual IboWebToolbar tlbgrdTabbot2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlButtonFilter")]
	protected virtual Panel pnlButtonFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ButtonFilterText")]
	protected virtual IboWebTextBox ButtonFilterText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton ButtonFilterConferma
	{
		[CompilerGenerated]
		get
		{
			return _ButtonFilterConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ButtonFilterConferma_Click;
			IboWebButton buttonFilterConferma = _ButtonFilterConferma;
			if (buttonFilterConferma != null)
			{
				((Button)buttonFilterConferma).Click -= eventHandler;
			}
			_ButtonFilterConferma = value;
			buttonFilterConferma = _ButtonFilterConferma;
			if (buttonFilterConferma != null)
			{
				((Button)buttonFilterConferma).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton ButtonFilterReset
	{
		[CompilerGenerated]
		get
		{
			return _ButtonFilterReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ButtonFilterReset_Click;
			IboWebButton buttonFilterReset = _ButtonFilterReset;
			if (buttonFilterReset != null)
			{
				((Button)buttonFilterReset).Click -= eventHandler;
			}
			_ButtonFilterReset = value;
			buttonFilterReset = _ButtonFilterReset;
			if (buttonFilterReset != null)
			{
				((Button)buttonFilterReset).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlTabbot2")]
	protected virtual IboWebPanel pnlTabbot2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTabbot2")]
	protected virtual IboGridView grdTabbot2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormGlobalContainer")]
	protected virtual Panel PopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormContainer")]
	protected virtual Panel PopupFormContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormTitleBar")]
	protected virtual Panel PopupFormTitleBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormCaption")]
	protected virtual IboWebLabel PopupFormCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPPopupForm")]
	protected virtual UpdatePanel UPPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormBody")]
	protected virtual Panel PopupFormBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabgrd_Body_Detail")]
	protected virtual IboWebDetailPanel cpTabgrd_Body_Detail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNomCam")]
	protected virtual IboWebLabel lblNomCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbNomCam
	{
		[CompilerGenerated]
		get
		{
			return _cmbNomCam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbNomCam_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbNomCam;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbNomCam = value;
			val2 = _cmbNomCam;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblDettCanSort")]
	protected virtual IboWebLabel lblDettCanSort
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optDetCanSort")]
	protected virtual IboWebRadioButtonList optDetCanSort
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHtmlEncode")]
	protected virtual IboWebLabel lblHtmlEncode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkHtmlEncode")]
	protected virtual IboWebCheckBox chkHtmlEncode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDesCam")]
	protected virtual IboWebLabel lblDesCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDesCam")]
	protected virtual IboWebTextBox txtDesCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisible")]
	protected virtual IboWebLabel lblVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFieldVisibile")]
	protected virtual IboDropDownList cmbFieldVisibile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisibleInFilter")]
	protected virtual IboWebLabel lblVisibleInFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkVisibleInFilter")]
	protected virtual IboWebCheckBox chkVisibleInFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblExtendedDesCam")]
	protected virtual IboWebLabel lblExtendedDesCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtExtendedDesCam")]
	protected virtual IboWebTextBox txtExtendedDesCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisibleInExp")]
	protected virtual IboWebLabel lblVisibleInExp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFieldVisibileInExp")]
	protected virtual IboDropDownList cmbFieldVisibileInExp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProRig")]
	protected virtual IboWebLabel lblProRig
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtProrig")]
	protected virtual IboWebNumericTlk txtProrig
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tabgrd_NomRif")]
	protected virtual IboWebHidden Tabgrd_NomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tabgrd_Utente")]
	protected virtual IboWebHidden Tabgrd_Utente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tabgrd_NomTab")]
	protected virtual IboWebHidden Tabgrd_NomTab
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLarCam")]
	protected virtual IboWebLabel lblLarCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLarCam")]
	protected virtual IboWebNumericTlk txtLarCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIsKey")]
	protected virtual IboWebLabel lblIsKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkIsKey")]
	protected virtual IboWebCheckBox chkIsKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHorizontalAlign")]
	protected virtual IboWebLabel lblHorizontalAlign
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbHorizontalAlign")]
	protected virtual IboWebComboTlk cmbHorizontalAlign
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblForCam")]
	protected virtual IboWebLabel lblForCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FormattazioneDatetime")]
	protected virtual IboWebComboTlk FormattazioneDatetime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Formattazione")]
	protected virtual IboWebTextBox Formattazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumeroDecimali")]
	protected virtual IboWebNumericTlk NumeroDecimali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tabgrd_verticalAlign")]
	protected virtual IboWebHidden tabgrd_verticalAlign
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrdCam")]
	protected virtual IboWebLabel lblOrdCam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbOrdCam
	{
		[CompilerGenerated]
		get
		{
			return _cmbOrdCam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmbOrdCam_SelectedIndexChanged;
			IboDropDownList val = _cmbOrdCam;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbOrdCam = value;
			val = _cmbOrdCam;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblOrdDir")]
	protected virtual IboWebLabel lblOrdDir
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optOrdDir")]
	protected virtual IboWebRadioButtonList optOrdDir
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblWrapCol")]
	protected virtual IboWebLabel lblWrapCol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optWrapCol")]
	protected virtual IboWebRadioButtonList optWrapCol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMaxChar")]
	protected virtual IboWebLabel lblMaxChar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMaxChar")]
	protected virtual IboWebNumericTlk txtMaxChar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCssClass")]
	protected virtual IboWebLabel lblCssClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCssClass")]
	protected virtual IboWebTextBox txtCssClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFunzioneRaggruppamento")]
	protected virtual IboWebLabel lblFunzioneRaggruppamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAggregateFunc")]
	protected virtual IboDropDownList cmbAggregateFunc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProRigOriginale")]
	protected virtual IboWebTextBox ProRigOriginale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FormattazioneNum")]
	protected virtual IboWebTextBox FormattazioneNum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTabbot_Body_Detail")]
	protected virtual IboWebDetailPanel cpTabbot_Body_Detail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizione")]
	protected virtual IboWebLabel lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DescrizionePulsante")]
	protected virtual IboWebTextBox DescrizionePulsante
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPesBot")]
	protected virtual IboWebLabel lblPesBot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPesbot")]
	protected virtual IboWebNumericTlk txtPesbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrdinamento")]
	protected virtual IboWebLabel lblOrdinamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOrdinamento")]
	protected virtual IboWebNumericTlk txtOrdinamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblShowCaption")]
	protected virtual IboWebLabel lblShowCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShowCaption")]
	protected virtual IboWebCheckBox chkShowCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblShowImage")]
	protected virtual IboWebLabel lblShowImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShowImage")]
	protected virtual IboWebCheckBox chkShowImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisibile2")]
	protected virtual IboWebLabel lblVisibile2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkVisibile2")]
	protected virtual IboWebCheckBox chkVisibile2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Utente")]
	protected virtual IboWebTextBox Utente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NomRif")]
	protected virtual IboWebTextBox NomRif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Numbot")]
	protected virtual IboWebTextBox Numbot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormButtons")]
	protected virtual Panel PopupFormButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdAnnulla")]
	protected virtual IboWebButton PopupForm_cmdAnnulla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdOk")]
	protected virtual IboWebButton PopupForm_cmdOk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForPopupForm")]
	protected virtual Button hiddenTargetControlForPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm")]
	protected virtual ModalPopupExtender PopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTabgrdForSorting")]
	protected virtual Panel pnlTabgrdForSorting
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTabgrdForSortingDD")]
	protected virtual Panel pnlTabgrdForSortingDD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdTabgrdForSortingDD
	{
		[CompilerGenerated]
		get
		{
			return _grdTabgrdForSortingDD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.RowSortedByDragAndDropEventHandler val = new IboGridView.RowSortedByDragAndDropEventHandler(grdTabgrdForSortingDD_RowSortedByDragAndDrop);
			IboGridView val2 = _grdTabgrdForSortingDD;
			if (val2 != null)
			{
				val2.RowSortedByDragAndDrop -= val;
			}
			_grdTabgrdForSortingDD = value;
			val2 = _grdTabgrdForSortingDD;
			if (val2 != null)
			{
				val2.RowSortedByDragAndDrop += val;
			}
		}
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.ALLGRD";
		_Title = base.Translator.Translate("XXX", "Configurazione Griglia", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig2 iboInternalGridConfig = new IboInternalGridConfig2();
			IboInternalGridConfig2 iboInternalGridConfig2 = iboInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdTabgrd;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdTabgrd = objGridView;
			iboInternalGridConfig.Build("WFI.CFG.TABGRD", "SELECT * FROM GRD_WFI_TABGRD WHERE 1=1 AND NOMRIF='<%NOMRIF%>' AND UTENTE='<%UTENTE%>'", "", "", ((Control)grdTabgrd).ID, ((Control)tlbgrdTabgrd).ID, "", "", ((Control)cpTabgrd_Body_Detail).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig2();
			IboInternalGridConfig2 iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdTabbot;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdTabbot = objGridView;
			iboInternalGridConfig.Build("WFI.CFG.TABBOT", "SELECT * FROM GRD_WFI_TABBOT WHERE 1=1 AND NOMRIF='<%NOMRIF%>' AND UTENTE='<%UTENTE%>'", "", "", ((Control)grdTabbot).ID, ((Control)tlbgrdTabbot).ID, "", "", ((Control)cpTabbot_Body_Detail).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig2();
			IboInternalGridConfig2 iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdTabbot2;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdTabbot2 = objGridView;
			string sqlForDispButton = GetSqlForDispButton("");
			iboInternalGridConfig.Build("WFI.CFG.ALLBTN_DISP", sqlForDispButton, "", "", ((Control)grdTabbot2).ID, ((Control)tlbgrdTabbot2).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig2();
			IboInternalGridConfig2 iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdTabgrdForSortingDD;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdTabgrdForSortingDD = objGridView;
			iboInternalGridConfig.Build("WFI.CFG.TABGRD", "SELECT G.* FROM GRD_WFI_TABGRD G WHERE 1=1 AND NOMRIF='<%NOMRIF%>' AND UTENTE='<%UTENTE%>'", "", "", ((Control)grdTabgrdForSortingDD).ID, "");
			GridConfigList.Add(iboInternalGridConfig);
			grdTabgrdForSortingDD.RowSortable = true;
			val = base.InitializeInternalGrid(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected override FXRETURN DetailResetControlli(ref IboWebDetailPanel pnlDetail, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_LoadControlsInitialValuesInSession && _SessionVariable.ContainsKey("InitialValues"))
			{
				Hashtable hashtable = (Hashtable)_SessionVariable["InitialValues"];
				foreach (IIboWebComponent iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)pnlDetail))
				{
					IIboWebComponent val3 = iIboWebComponentControl;
					if (hashtable.Contains(((Control)val3).ID))
					{
						val3.ObjValue = RuntimeHelpers.GetObjectValue(((InitialControl)hashtable[((Control)val3).ID]).ObjValue);
						if (val3 is IIboDropdownList)
						{
							IIboDropdownList val4 = (IIboDropdownList)val3;
							string rsMess2 = "";
							ComboSelectedItem(val4, "", ref rsMess2);
						}
						val3.ReadOnly = ((InitialControl)hashtable[((Control)val3).ID]).ReadOnly;
						val3.Enabled = ((InitialControl)hashtable[((Control)val3).ID]).Enabled;
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

	protected override FXRETURN BeforeCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeCheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(txtScrollHeight.Text, "", false) == 0)
				{
					txtScrollHeight.ObjValue = 0;
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(optCanPage.ObjValue.ToString(), "S", false) == 0)
				{
					txtRowsPerPage.Visible = true;
					lblRowsPerPage.Visible = true;
				}
				else
				{
					txtRowsPerPage.Visible = false;
					lblRowsPerPage.Visible = false;
				}
				if (Conversions.ToInteger(txtTimerUpdate.ObjValue) > 0)
				{
					lblAutoUpdateVisible.Visible = true;
					chkAutoUpdateVisible.Visible = true;
				}
				else
				{
					lblAutoUpdateVisible.Visible = false;
					chkAutoUpdateVisible.Visible = false;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 <= 0)
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeSaveData(ref rsMess);
			if ((int)val2 <= 0)
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeLoadData(ref rsMess);
			if ((int)val2 <= 0)
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadPage(ref rsMess);
			if ((int)val2 <= 0)
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN DetailBeforeLoadData(IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.DetailBeforeLoadData(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val <= 0)
			{
				val2 = (FXRETURN)0;
			}
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

	protected override FXRETURN DetailAfterCheckData(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.DetailAfterCheckData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val <= 0)
			{
				val2 = (FXRETURN)0;
			}
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

	protected override FXRETURN DetailAfterLoadData(IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between Unknown and I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objFunctionArguments.Name, "INSERIMENTO", false) == 0)
			{
				cmbNomCam.ReadOnly = false;
				lblForCam.Visible = false;
				FormattazioneDatetime.Visible = false;
				Formattazione.Visible = false;
				NumeroDecimali.Visible = false;
			}
			else
			{
				lblForCam.Visible = true;
			}
			if (Operators.CompareString(cmbOrdCam.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(cmbOrdCam.ObjValue) == 0)
			{
				lblOrdDir.Visible = false;
				optOrdDir.Visible = false;
			}
			else
			{
				lblOrdDir.Visible = true;
				optOrdDir.Visible = true;
			}
			string text2 = "SELECT NomTab FROM Wfi_AllGrd WHERE Nomrif = " + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString());
			object obj = null;
			val = base.DbConn.DoSql(text2, ref obj, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				cmbNomCam.SqlQueryWhere = "NomeTabella=" + base.DbConn.SQLFormatString(obj.ToString());
				IboWebComboTlk objCombo = cmbNomCam;
				FXRETURN val3 = LoadSingleCombo(ref objCombo, ref rsMess);
				cmbNomCam = objCombo;
				val = val3;
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = base.DetailAfterLoadData(pnlDetail, ref objFunctionArguments, ref rsMess);
					if ((int)val <= 0)
					{
						txtProrig.ReadOnly = false;
						ProRigOriginale.Text = txtProrig.Text;
						if (Operators.CompareString(FormattazioneNum.FieldName, "FORCAM", false) == 0)
						{
							lblForCam.ObjValue = TranslateMessage("XXX", "Numero Decimali:");
						}
						else
						{
							lblForCam.ObjValue = TranslateMessage("XXX", "Formattazione:");
						}
						if ((Operators.CompareString(FormattazioneNum.FieldName, "FORCAM", false) == 0) & (Operators.CompareString(FormattazioneNum.Text, "", false) != 0))
						{
							text = FormattazioneNum.Text.Substring(4, 1);
							NumeroDecimali.ObjValue = Conversions.ToDouble(text);
						}
						else
						{
							NumeroDecimali.ObjValue = "";
						}
						val2 = (FXRETURN)0;
					}
				}
			}
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

	protected override FXRETURN DetailBeforeSaveData(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.DetailBeforeSaveData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (!((Operators.CompareString(objFunctionArguments.Name, "INSERIMENTO", false) == 0) & (Operators.CompareString(txtProrig.ObjValue.ToString(), "", false) == 0)))
				{
					goto IL_0113;
				}
				text2 = "SELECT ISNULL(MAX(PRORIG),0) FROM WFI_TABGRD ";
				text2 = text2 + "WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.Text) + " ";
				text2 = text2 + "AND UTENTE = " + base.DbConn.SQLFormatString(txtUtente.Text) + " ";
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					txtProrig.Text = Conversions.ToString(checked(Conversions.ToInteger(obj) + 10));
					goto IL_0113;
				}
				val = val2;
			}
			goto end_IL_0015;
			IL_0113:
			if (Operators.CompareString(FormattazioneNum.FieldName, "FORCAM", false) == 0)
			{
				if (Operators.CompareString(NumeroDecimali.ObjValue.ToString(), "", false) != 0)
				{
					text = "{0:F" + NumeroDecimali.ObjValue.ToString() + "}";
					FormattazioneNum.ObjValue = text;
				}
				else
				{
					FormattazioneNum.ObjValue = "";
				}
			}
			val = (FXRETURN)0;
			end_IL_0015:;
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

	protected override FXRETURN DetailBeforeConfermaClick(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.DetailBeforeConfermaClick(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "SELECT COUNT(*) FROM WFI_TABGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.Text) + " ";
				text = text + "AND UTENTE = " + base.DbConn.SQLFormatString(txtUtente.Text) + " ";
				string text2 = text;
				DBConnection dbConn = base.DbConn;
				IboWebNumericTlk val3;
				string text3 = (val3 = txtProrig).Text;
				string text4 = dbConn.SQLFormatNumber(ref text3);
				val3.Text = text3;
				text = text2 + "AND PRORIG = " + text4 + " ";
				string text5 = text;
				DBConnection dbConn2 = base.DbConn;
				IboWebTextBox proRigOriginale;
				text3 = (proRigOriginale = ProRigOriginale).Text;
				string text6 = dbConn2.SQLFormatNumber(ref text3);
				proRigOriginale.Text = text3;
				text = text5 + "AND PRORIG <> " + text6;
				val = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (Conversions.ToInteger(obj) > 0)
				{
					rsMess = TranslateMessage("XXX", "Impossibile salvare, sequenza {0} già presente", txtProrig.Text);
				}
				else
				{
					val2 = (FXRETURN)0;
				}
			}
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

	protected override FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				switch (e.CommandName.ToString())
				{
				case "AGGIORNACAMPI":
					val2 = AggiornaCampi(ref rsMess);
					if ((int)val2 <= 0)
					{
						break;
					}
					val = val2;
					goto end_IL_000b;
				case "VISIBILE":
				{
					if (funcArg.Data.Count <= 0)
					{
						break;
					}
					string text2 = "UPDATE WFI_TABGRD SET VISIBILE='S' WHERE 1=1 " + funcArg.Data.GetAllElementSqlWhere();
					val2 = base.DbConn.SqlExec(text2, ref rsMess);
					if ((int)val2 <= 0)
					{
						break;
					}
					val = val2;
					goto end_IL_000b;
				}
				case "NONVISIBILE":
				{
					string text3 = "UPDATE WFI_TABGRD SET VISIBILE='N' WHERE 1=1 " + funcArg.Data.GetAllElementSqlWhere();
					val2 = base.DbConn.SqlExec(text3, ref rsMess);
					if ((int)val2 <= 0)
					{
						break;
					}
					val = val2;
					goto end_IL_000b;
				}
				case "ORDINA":
					val2 = NormalizzaProrig(ref rsMess);
					if ((int)val2 <= 0)
					{
						MasterPopupFormOpen(TranslateMessage("XXX", "Gestione ordinamento campi"), (Control)(object)pnlTabgrdForSorting, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: false, e.CommandName.ToUpper());
						break;
					}
					val = val2;
					goto end_IL_000b;
				}
				val = (FXRETURN)0;
			}
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Invalid comparison between Unknown and I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Invalid comparison between Unknown and I4
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Invalid comparison between Unknown and I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Invalid comparison between Unknown and I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(((Control)tlb).ID.ToUpper(), ((Control)tlbgrdTabbot2).ID.ToUpper(), false) == 0)
			{
				if (funcArg.Data.Count <= 0)
				{
					goto IL_068e;
				}
				text3 = "SELECT NUMBOT, <%OTHERS%> FROM WFI_ALLBTN ";
				text3 += "WHERE ";
				int fieldValuesCount = funcArg.Data[0].FieldValuesCount;
				int count = funcArg.Data.Count;
				int num = default(int);
				while (true)
				{
					string text5;
					checked
					{
						if (num < fieldValuesCount)
						{
							if (num > 0)
							{
								text3 += " OR ";
							}
							int num2 = 0;
							while (true)
							{
								if (num2 < count)
								{
									if (num2 > 0)
									{
										text3 += " AND ";
									}
									text3 = text3 + funcArg.Data[num2].FieldName + " = ";
									switch (funcArg.Data[num2].FieldType)
									{
									case "String":
										text3 += base.DbConn.SQLFormatString(funcArg.Data[num2].get_FieldValues(num).ToString());
										goto IL_0345;
									case "Int16":
									case "Int32":
									case "Int64":
									case "Numeric":
									case "Decimal":
									case "Single":
									{
										string text4 = text3;
										DBConnection dbConn = base.DbConn;
										text5 = funcArg.Data[num2].get_FieldValues(num).ToString();
										text3 = text4 + dbConn.SQLFormatNumber(ref text5);
										goto IL_0345;
									}
									case "DateTime":
										text3 += base.DbConn.SQLFormatDate((eTipoData)2, funcArg.Data[num2].get_FieldValues(num).ToString());
										goto IL_0345;
									default:
										rsMess = TranslateMessage("XXX", "Tipo dato {0} non gestito per la colonna {1}.", funcArg.Data[num2].FieldType, funcArg.Data[num2].FieldName);
										break;
									}
									goto end_IL_0363;
								}
								num++;
								break;
								IL_0345:
								num2++;
							}
							continue;
						}
						text2 = "INSERT INTO WFI_TABBOT(NUMBOT,NOMRIF,UTENTE,PESBOT,ShowCaption,ShowImage,Ordinamento,Visibile,UTEINS,UTEAGG) ";
						text2 += text3;
						text3 = base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString()) + ", ";
						text3 = text3 + base.DbConn.SQLFormatString(txtUtente.ObjValue.ToString()) + ", ";
						text3 += "5,'S','S',0,'S',";
						text3 = text3 + base.DbConn.SQLFormatString(base.WFIUser) + ", ";
						text3 += base.DbConn.SQLFormatString(base.WFIUser);
						text2 = text2.Replace("<%OTHERS%>", text3);
					}
					if ((int)base.DbConn.SqlExec(text2, ref rsMess) > 0)
					{
						break;
					}
					IboInternalGridConfig objInternalGridConfig2 = GridConfigList.get_GetItemByToolbarId(((Control)tlbgrdTabbot).ID);
					text5 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig2, ref text5);
					objInternalGridConfig2 = GridConfigList.get_GetItemByToolbarId(((Control)tlbgrdTabbot2).ID);
					text5 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig2, ref text5);
					upTabbot.Update();
					upTabbot2.Update();
					goto IL_068e;
					continue;
					end_IL_0363:
					break;
				}
			}
			else if (Operators.CompareString(((Control)tlb).ID.ToUpper(), ((Control)tlbgrdTabgrd).ID.ToUpper(), false) == 0)
			{
				Formattazione.FieldName = "FORCAM";
				FormattazioneDatetime.FieldName = "";
				FormattazioneNum.FieldName = "";
				val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					Tabgrd_NomRif.ObjValue = txtNomRif.ObjValue.ToString();
					Tabgrd_Utente.ObjValue = txtUtente.ObjValue.ToString();
					Tabgrd_NomTab.ObjValue = cmbNomTab.ObjValue.ToString();
					object obj = null;
					text3 = "SELECT ISNULL(MAX(PRORIG),0) FROM WFI_TABGRD ";
					text3 = text3 + "WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.Text) + " ";
					text3 = text3 + "AND UTENTE = " + base.DbConn.SQLFormatString(txtUtente.Text) + " ";
					val2 = base.DbConn.DoSql(text3, ref obj, ref rsMess);
					if ((int)val2 <= 0)
					{
						txtProrig.Text = Conversions.ToString(checked(Conversions.ToInteger(obj) + 10));
						cmbHorizontalAlign.ObjValue = "Left";
						cmbOrdCam.ObjValue = "0";
						cmbFieldVisibile.ObjValue = "S";
						((RadComboBox)cmbNomCam).Focus();
						goto IL_068e;
					}
					val = val2;
				}
			}
			else
			{
				val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_068e;
				}
				val = val2;
			}
			goto end_IL_0019;
			IL_068e:
			val = (FXRETURN)0;
			end_IL_0019:;
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(((Control)tlb).ID.ToUpper(), ((Control)tlbgrdTabbot).ID.ToUpper(), false) == 0)
				{
					IboInternalGridConfig objInternalGridConfig2 = GridConfigList.get_GetItemByToolbarId(((Control)tlbgrdTabbot).ID);
					string rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsMess2);
					objInternalGridConfig2 = GridConfigList.get_GetItemByToolbarId(((Control)tlbgrdTabbot2).ID);
					rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsMess2);
					upTabbot.Update();
					upTabbot2.Update();
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else if (Operators.CompareString(((Control)tlbgrdTabgrd).ID, ((Control)tlb).ID, false) == 0)
			{
				string text = funcArg.Data.Item(0).get_FieldValues(0).ToString();
				string text2 = funcArg.Data.Item(1).get_FieldValues(0).ToString();
				string text3 = funcArg.Data.Item(2).get_FieldValues(0).ToString();
				DataTable dataTable = null;
				string text4 = "SELECT * FROM WFI_TABGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(text) + " ";
				text4 = text4 + "AND PRORIG = " + base.DbConn.SQLFormatNumber(ref text2) + " ";
				text4 = text4 + "AND UTENTE = " + base.DbConn.SQLFormatString(text3);
				val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = FindFieldDataType(dataTable.Rows[0]["NomCam"].ToString(), ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_021d;
						}
						val = val2;
					}
				}
			}
			else
			{
				if (Operators.CompareString(((Control)tlbgrdTabbot).ID, ((Control)tlb).ID, false) != 0)
				{
					goto IL_021d;
				}
				string text5 = funcArg.Data.Item(0).get_FieldValues(0).ToString();
				string text6 = funcArg.Data.Item(1).get_FieldValues(0).ToString();
				string text7 = funcArg.Data.Item(2).get_FieldValues(0).ToString();
				val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_021d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_021d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	private void optCanPage_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(optCanPage.ObjValue.ToString(), "S", false) == 0)
			{
				txtRowsPerPage.Visible = true;
				lblRowsPerPage.Visible = true;
			}
			else
			{
				txtRowsPerPage.Visible = false;
				lblRowsPerPage.Visible = false;
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
			CallStackRemove();
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void grdTabgrdForSortingDD_RowSortedByDragAndDrop(object sender, RowSortedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Invalid comparison between Unknown and I4
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Invalid comparison between Unknown and I4
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string[] array = e.Stop_Rowkey.Split(new char[1] { ';' });
			string text = array[0];
			int num = Conversions.ToInteger(array[1]);
			string text2 = array[2];
			string[] array2 = new string[0];
			string text3 = "";
			int num2 = -1;
			string text4 = "";
			if (Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0)
			{
				array2 = e.Stop_RowkeyAfter.Split(new char[1] { ';' });
				text3 = array2[0];
				num2 = Conversions.ToInteger(array2[1]);
				text4 = array[2];
			}
			string[] array3 = new string[0];
			string text5 = "";
			int num3 = -1;
			string text6 = "";
			if (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0)
			{
				array3 = e.Stop_RowkeyPrevious.Split(new char[1] { ';' });
				text5 = array3[0];
				num3 = Conversions.ToInteger(array3[1]);
				text6 = array[2];
			}
			if (!((Operators.CompareString(e.Start_RowkeyAfter, e.Stop_RowkeyAfter, false) == 0) | (Operators.CompareString(e.Start_RowkeyPrevious, e.Stop_RowkeyPrevious, false) == 0)))
			{
				string text7 = "";
				if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0))
				{
					if (num > num2)
					{
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=-1 WHERE PRORIG=" + base.DbConn.SQLFormatNumber(ref num) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=PRORIG+10 WHERE PRORIG<" + base.DbConn.SQLFormatNumber(ref num) + " AND PRORIG>" + base.DbConn.SQLFormatNumber(ref num3) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text3) + " AND UTENTE=" + base.DbConn.SQLFormatString(text4) + ";";
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=" + base.DbConn.SQLFormatNumber(ref num2) + " WHERE PRORIG=-1 AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
					}
					else
					{
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=-1 WHERE PRORIG=" + base.DbConn.SQLFormatNumber(ref num) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=PRORIG-10 WHERE PRORIG>" + base.DbConn.SQLFormatNumber(ref num) + " AND PRORIG<" + base.DbConn.SQLFormatNumber(ref num2) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text3) + " AND UTENTE=" + base.DbConn.SQLFormatString(text4) + ";";
						text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=" + base.DbConn.SQLFormatNumber(ref num3) + " WHERE PRORIG=-1 AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
					}
				}
				else if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) == 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0))
				{
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=-1 WHERE PRORIG=" + base.DbConn.SQLFormatNumber(ref num) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=PRORIG-10 WHERE PRORIG>" + base.DbConn.SQLFormatNumber(ref num) + " AND PRORIG<=" + base.DbConn.SQLFormatNumber(ref num3) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text5) + " AND UTENTE=" + base.DbConn.SQLFormatString(text6) + ";";
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=" + base.DbConn.SQLFormatNumber(ref num3) + " WHERE PRORIG=-1 AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
				}
				else if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) == 0))
				{
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=-1 WHERE PRORIG=" + base.DbConn.SQLFormatNumber(ref num) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=PRORIG+10 WHERE PRORIG<" + base.DbConn.SQLFormatNumber(ref num) + " AND PRORIG>=" + base.DbConn.SQLFormatNumber(ref num2) + " AND NOMRIF=" + base.DbConn.SQLFormatString(text3) + " AND UTENTE=" + base.DbConn.SQLFormatString(text4) + ";";
					text7 = text7 + "UPDATE WFI_TABGRD SET PRORIG=" + base.DbConn.SQLFormatNumber(ref num2) + " WHERE PRORIG=-1 AND NOMRIF=" + base.DbConn.SQLFormatString(text) + " AND UTENTE=" + base.DbConn.SQLFormatString(text2) + ";";
				}
				base.DbConn.BeginTransaction();
				val2 = base.DbConn.SqlExec(text7, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				base.DbConn.CommitTransaction();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdTabgrdForSortingDD).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
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
			base.DbConn.RollbackTransaction();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void txtTimerUpdate_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Conversions.ToInteger(txtTimerUpdate.ObjValue) > 0)
			{
				lblAutoUpdateVisible.Visible = true;
				chkAutoUpdateVisible.Visible = true;
			}
			else
			{
				lblAutoUpdateVisible.Visible = false;
				chkAutoUpdateVisible.Visible = false;
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
			base.DbConn.RollbackTransaction();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void cmbNomCam_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			val2 = FindFieldDataType(cmbNomCam.ObjValue.ToString(), ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			((Control)txtDesCam).Focus();
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
			base.DbConn.RollbackTransaction();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void cmbOrdCam_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Operators.CompareString(cmbOrdCam.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(cmbOrdCam.ObjValue) == 0)
			{
				lblOrdDir.Visible = false;
				optOrdDir.Visible = false;
				((Control)optWrapCol).Focus();
			}
			else
			{
				lblOrdDir.Visible = true;
				optOrdDir.Visible = true;
				((Control)optOrdDir).Focus();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void ButtonFilterConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(ButtonFilterText.ObjValue.ToString().Trim(), "", false) != 0)
			{
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdTabbot2).ID];
				string sqlForDispButton = GetSqlForDispButton(ButtonFilterText.ObjValue.ToString().Trim());
				objInternalGridConfig.SqlOriginalStatement = sqlForDispButton;
				ButtonFilterText.ObjValue = "";
				ButtonFilterText.ToolTip = TranslateMessage("XXX", "RiCerca simile a " + ButtonFilterText.ObjValue.ToString().Trim());
				string rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				getParentUpdatePanel((Control)(object)grdTabbot2).Update();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void ButtonFilterReset_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdTabbot2).ID];
			string sqlForDispButton = GetSqlForDispButton("");
			ButtonFilterText.ObjValue = "";
			ButtonFilterText.ToolTip = "";
			objInternalGridConfig.SqlOriginalStatement = sqlForDispButton;
			string rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			getParentUpdatePanel((Control)(object)grdTabbot2).Update();
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
			CallStackRemove();
		}
	}

	private FXRETURN AggiornaCampi(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Invalid comparison between Unknown and I4
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Invalid comparison between Unknown and I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Invalid comparison between Unknown and I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Invalid comparison between Unknown and I4
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Invalid comparison between Unknown and I4
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		Cfg_Campi[] array = null;
		object obj = null;
		string[] array2 = null;
		int num = 0;
		StringCollection stringCollection = new StringCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM ElencoCampiTabella WHERE TABLE_NAME=" + base.DbConn.SQLFormatString(cmbNomTab.ObjValue.ToString()) + " AND COLUMN_NAME  ";
			text = text + "NOT IN (SELECT NOMCAM FROM WFI_TABGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.Text) + " ";
			text = text + "AND UTENTE = " + base.DbConn.SQLFormatString(txtUtente.Text) + ") ";
			text += "ORDER BY ORDINAL_POSITION";
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count > 0)
			{
				text = "SELECT ISNULL(MAX(PRORIG),0) MAXPRORIG FROM WFI_TABGRD WHERE NOMRIF = " + base.DbConn.SQLFormatString(txtNomRif.Text) + " ";
				text = text + "AND UTENTE = " + base.DbConn.SQLFormatString(txtUtente.Text);
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					num = Conversions.ToInteger(obj);
					checked
					{
						int num2 = dataTable.Rows.Count - 1;
						int num3 = 0;
						while (true)
						{
							if (num3 <= num2)
							{
								array = (Cfg_Campi[])Utils.CopyArray((Array)array, (Array)new Cfg_Campi[num3 + 1]);
								array[num3].Name = dataTable.Rows[num3]["COLUMN_NAME"].ToString();
								unchecked
								{
									if (Operators.CompareString(array[num3].Name, "WFI_Keys", false) == 0)
									{
										text = "SELECT WFI_Keys FROM " + cmbNomTab.ObjValue.ToString();
										val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
										if ((int)val2 > 0)
										{
											val = val2;
											break;
										}
										array2 = Conversions.ToString(obj).Split(new char[1] { ',' });
									}
									array[num3].Caption = base.BaseFunctions.StandardNameFilter(dataTable.Rows[num3]["COLUMN_NAME"].ToString());
									array[num3].Formattazione = "";
									array[num3].Visible = "N";
									array[num3].Width = 0;
									if (Operators.CompareString(dataTable.Rows[num3]["WFI_DATA_TYPE"].ToString(), "NUMERIC", false) == 0)
									{
										array[num3].Align = "Right";
										array[num3].Width = 10;
										if (Operators.CompareString(dataTable.Rows[num3]["NUMERIC_SCALE"].ToString(), "2", false) == 0)
										{
											array[num3].Formattazione = "{0:F2}";
										}
										else if (Operators.CompareString(dataTable.Rows[num3]["NUMERIC_SCALE"].ToString(), "5", false) == 0)
										{
											array[num3].Formattazione = "{0:F5}";
										}
									}
									else if (Operators.CompareString(dataTable.Rows[num3]["WFI_DATA_TYPE"].ToString(), "DATETIME", false) == 0)
									{
										array[num3].Align = "Left";
										text = "SELECT ISNULL(MAX(RIGHT(" + array[num3].Name + ",2)),0) FROM " + cmbNomTab.ObjValue.ToString().ToUpper() + " WHERE " + array[num3].Name + " IS NOT NULL";
										val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
										if ((int)val2 > 0)
										{
											break;
										}
										if (Operators.CompareString(obj.ToString(), "00", false) == 0)
										{
											array[num3].Width = 10;
										}
										else
										{
											array[num3].Width = 90;
										}
										array[num3].Formattazione = "{0:dd/MM/yyyy}";
									}
									else
									{
										array[num3].Align = "Left";
										text = "SELECT ISNULL(MAX(LEN(" + array[num3].Name + ")),0) FROM " + cmbNomTab.ObjValue.ToString().ToUpper();
										val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
										if ((int)val2 > 0)
										{
											break;
										}
										int num4 = Conversions.ToInteger(obj);
										array[num3].Width = checked(num4 * 7);
										if (array[num3].Width > 350)
										{
											array[num3].Width = 350;
										}
									}
									if (Operators.CompareString(array[num3].Name.ToUpper(), "STYLESET", false) == 0)
									{
										array[num3].Visible = "N";
										array[num3].Width = 0;
									}
								}
								num3++;
								continue;
							}
							int num5 = array.Count() - 1;
							for (int i = 0; i <= num5; i++)
							{
								text = "INSERT INTO WFI_TABGRD (NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,";
								text += "HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,";
								text += "WRAPCOL,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP) VALUES (";
								text = text + base.DbConn.SQLFormatString(txtNomRif.Text.ToUpper()) + ", ";
								string text2 = text;
								DBConnection dbConn = base.DbConn;
								int num6 = (i + 1) * 10 + num;
								text = text2 + dbConn.SQLFormatNumber(ref num6) + ", ";
								text = text + base.DbConn.SQLFormatString("XXX") + ", ";
								text = text + base.DbConn.SQLFormatString(cmbNomTab.ObjValue.ToString()) + ", ";
								text = text + base.DbConn.SQLFormatString(array[i].Name) + ", ";
								text = text + base.DbConn.SQLFormatString(array[i].Caption) + ", ";
								text = text + base.DbConn.SQLFormatNumber(ref array[i].Width) + ", ";
								text = text + base.DbConn.SQLFormatString(array[i].Align) + ", ";
								text = text + base.DbConn.SQLFormatString("Middle") + ", ";
								text = text + base.DbConn.SQLFormatString(array[i].Formattazione) + ", ";
								text += "0, ";
								text += "NULL, ";
								text = text + base.DbConn.SQLFormatString(array[i].Visible) + ", ";
								text = (Information.IsNothing((object)array2) ? (text + "'N', ") : ((!array2.Contains<string>(array[i].Name, StringComparer.OrdinalIgnoreCase)) ? (text + "'N', ") : (text + "'S', ")));
								text += "NULL, ";
								text = text + base.DbConn.GetDate() + ", ";
								text = text + base.DbConn.GetDate() + ", ";
								text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
								text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
								text += "'S', ";
								text += "NULL ";
								text += ");\r\n";
								if (Operators.CompareString(array[i].Name.ToUpper(), "WFI_KEYS", false) != 0)
								{
									stringCollection.Add(text);
								}
							}
							StringEnumerator enumerator = stringCollection.GetEnumerator();
							while (true)
							{
								if (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									val2 = base.DbConn.SqlExec(current, ref rsMess);
									if (unchecked((int)val2) > 0)
									{
										val = val2;
										break;
									}
									continue;
								}
								val = (FXRETURN)0;
								break;
							}
							break;
						}
					}
				}
			}
			else
			{
				rsMess = TranslateMessage("XXX", "Nessun nuovo campo da aggiungere");
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
			AggiornaGriglia();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN NormalizzaProrig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			DataTable dataTable = null;
			string text = "SELECT * FROM WFI_TABGRD WHERE NOMRIF=" + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString()) + " AND UTENTE=" + base.DbConn.SQLFormatString(txtUtente.ObjValue.ToString()) + " ORDER BY PRORIG";
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text = "UPDATE WFI_TABGRD SET PRORIG=-PRORIG WHERE NOMRIF=" + base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString()) + " AND UTENTE=" + base.DbConn.SQLFormatString(txtUtente.ObjValue.ToString()) + ";";
				int num = 10;
				DataRow[] array = dataTable.Select("", "PRORIG ASC");
				checked
				{
					foreach (DataRow dataRow in array)
					{
						string[] obj = new string[10]
						{
							text,
							"UPDATE WFI_TABGRD SET PRORIG=",
							base.DbConn.SQLFormatNumber(ref num),
							" WHERE PRORIG=",
							null,
							null,
							null,
							null,
							null,
							null
						};
						DBConnection dbConn = base.DbConn;
						int num2 = -Conversions.ToInteger(dataRow["PRORIG"]);
						obj[4] = dbConn.SQLFormatNumber(ref num2);
						obj[5] = " AND NOMRIF=";
						obj[6] = base.DbConn.SQLFormatString(txtNomRif.ObjValue.ToString());
						obj[7] = " AND UTENTE=";
						obj[8] = base.DbConn.SQLFormatString(txtUtente.ObjValue.ToString());
						obj[9] = ";";
						text = string.Concat(obj);
						num += 10;
					}
					base.DbConn.BeginTransaction();
					val2 = base.DbConn.SqlExec(text, ref rsMess);
				}
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					base.DbConn.CommitTransaction();
					IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdTabgrd).ID];
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
					objInternalGridConfig = GridConfigList[((Control)grdTabgrdForSortingDD).ID];
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
					val = (FXRETURN)0;
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
			base.DbConn.RollbackTransaction();
			result = val;
		}
		return result;
	}

	private FXRETURN FindFieldDataType(string NomeCampo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			string text = "SELECT * FROM ElencoCampiTabella WHERE UPPER(TABLE_NAME)=" + base.DbConn.SQLFormatString(cmbNomTab.ObjValue.ToString().ToUpper()) + " ";
			text = text + "AND UPPER(COLUMN_NAME) = " + base.DbConn.SQLFormatString(NomeCampo.ToUpper()) + " ORDER BY ORDINAL_POSITION";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				lblForCam.Visible = true;
				if (dataTable.Rows.Count != 1)
				{
					NumeroDecimali.Visible = false;
					FormattazioneDatetime.Visible = false;
					Formattazione.Visible = true;
					Formattazione.ReadOnly = false;
					FormattazioneNum.FieldName = "";
					FormattazioneDatetime.FieldName = "";
					Formattazione.FieldName = "FORCAM";
					lblForCam.ObjValue = TranslateMessage("XXX", "Formattazione:");
				}
				else
				{
					string text2 = dataTable.Rows[0]["WFI_DATA_TYPE"].ToString();
					if (Operators.CompareString(text2, "NUMERIC", false) != 0)
					{
						if (Operators.CompareString(text2, "DATETIME", false) == 0)
						{
							NumeroDecimali.Visible = false;
							FormattazioneDatetime.Visible = true;
							Formattazione.Visible = false;
							FormattazioneNum.FieldName = "";
							FormattazioneDatetime.FieldName = "FORCAM";
							Formattazione.FieldName = "";
							lblForCam.ObjValue = TranslateMessage("XXX", "Formattazione:");
						}
						else
						{
							NumeroDecimali.Visible = false;
							FormattazioneDatetime.Visible = false;
							Formattazione.Visible = true;
							Formattazione.ReadOnly = false;
							FormattazioneNum.FieldName = "";
							FormattazioneDatetime.FieldName = "";
							Formattazione.FieldName = "FORCAM";
							lblForCam.ObjValue = TranslateMessage("XXX", "Formattazione:");
						}
					}
					else
					{
						NumeroDecimali.Visible = true;
						Formattazione.Visible = false;
						FormattazioneDatetime.Visible = false;
						FormattazioneNum.FieldName = "FORCAM";
						FormattazioneNum.Text = "";
						FormattazioneDatetime.FieldName = "";
						Formattazione.FieldName = "";
						lblForCam.ObjValue = TranslateMessage("XXX", "Numero Decimali:");
					}
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
			base.DbConn.RollbackTransaction();
			result = val;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormOkClick(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "ORDINA", false) == 0)
				{
					iboInternalGridConfig = GridConfigList[((Control)grdTabgrd).ID];
					InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
					UPTreeViewContent.Update();
				}
				val2 = (FXRETURN)0;
			}
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void AggiornaGriglia()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text2 = "";
		try
		{
			IboInternalGridConfig objInternalGridConfig = GridConfigList["grdTabgrd"];
			objInternalGridConfig.SqlOriginalStatement = "SELECT * FROM GRD_WFI_TABGRD WHERE 1=1 AND NOMRIF= '<%NOMRIF%>' AND UTENTE= '<%UTENTE%>'";
			string rsMess = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private string GetSqlForDispButton(string Filter)
	{
		string text = "SELECT * FROM GRD_WFI_ALLBTN_DISP WHERE 1=1 AND NUMBOT NOT IN (SELECT NUMBOT FROM GRD_WFI_TABBOT WHERE 1=1 AND NOMRIF='<%NOMRIF%>' AND UTENTE='<%UTENTE%>') ";
		if (Operators.CompareString(Filter, "", false) != 0)
		{
			text = text + " AND (DESBOT LIKE '%" + Strings.Replace(Filter, "'", "''", 1, -1, (CompareMethod)0) + "%' OR CAPTIONBOT LIKE '%" + Strings.Replace(Filter, "'", "''", 1, -1, (CompareMethod)0) + "%' OR TOOLTIPBOT LIKE '%" + Strings.Replace(Filter, "'", "''", 1, -1, (CompareMethod)0) + "%')";
		}
		return text;
	}
}
