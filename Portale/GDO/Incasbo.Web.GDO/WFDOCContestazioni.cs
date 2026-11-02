using System;
using System.Data;
using System.Diagnostics;
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

namespace Incasbo.Web.GDO;

public class WFDOCContestazioni : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optStato")]
	private IboWebRadioButtonList _optStato;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCheckSpedizione")]
	private IboWebButton _btnCheckSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVediSpedizione")]
	private IboWebButton _btnVediSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoSoggetto")]
	private IboDropDownList _cmbTipoSoggetto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Soggetto_Codice")]
	private IboWebComboTlk _Soggetto_Codice;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
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

	[field: AccessedThroughProperty("pnlTestataBody")]
	protected virtual Panel pnlTestataBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title")]
	protected virtual Panel cpTestata_Title
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

	[field: AccessedThroughProperty("cpTestata_Body")]
	protected virtual Panel cpTestata_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTestataBodyLeft")]
	protected virtual Panel pnlTestataBodyLeft
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlEstremiSpedizioneTitle")]
	protected virtual Panel pnlEstremiSpedizioneTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEstremiSpedizioneTitle")]
	protected virtual IboWebLabel lblEstremiSpedizioneTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_EstremiSpedizione")]
	protected virtual UpdatePanel up_EstremiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlEstremiSpedizioneBody")]
	protected virtual Panel pnlEstremiSpedizioneBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblId")]
	protected virtual IboWebLabel lblId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebTextBox txtId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStato")]
	protected virtual IboWebLabel lblStato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optStato
	{
		[CompilerGenerated]
		get
		{
			return _optStato;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optStato_SelectedIndexChanged;
			IboWebRadioButtonList val = _optStato;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optStato = value;
			val = _optStato;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDataApertura")]
	protected virtual IboWebLabel lblDataApertura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataApertura")]
	protected virtual IboWebLabel DataApertura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataChiusura")]
	protected virtual IboWebLabel lblDataChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataChiusura")]
	protected virtual IboWebLabel DataChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoContestazione")]
	protected virtual IboWebLabel lblTipoContestazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoContestazione")]
	protected virtual IboWebComboTlk cmbTipoContestazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibol")]
	protected virtual IboWebLabel lblUnibol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnibol")]
	protected virtual IboWebTextBox txtUnibol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnCheckSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _btnCheckSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCheckSpedizione_Click;
			IboWebButton val = _btnCheckSpedizione;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCheckSpedizione = value;
			val = _btnCheckSpedizione;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnVediSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _btnVediSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVediSpedizione_Click;
			IboWebButton val = _btnVediSpedizione;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVediSpedizione = value;
			val = _btnVediSpedizione;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblRiferimento1")]
	protected virtual IboWebLabel lblRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento1")]
	protected virtual IboWebTextBox txtRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRiferimento1")]
	protected virtual IboWebLabel lblDataRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRiferimento1")]
	protected virtual IboWebDate2 txtDataRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRiferimento1")]
	protected virtual IboWebLabel lblNoteRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteRiferimento1")]
	protected virtual IboWebTextBox txtNoteRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimento2")]
	protected virtual IboWebLabel lblRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento2")]
	protected virtual IboWebTextBox txtRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRiferimento2")]
	protected virtual IboWebLabel lblDataRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRiferimento2")]
	protected virtual IboWebDate2 txtDataRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRiferimento2")]
	protected virtual IboWebLabel lblNoteRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteRiferimento2")]
	protected virtual IboWebTextBox txtNoteRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSoggettoBody")]
	protected virtual Panel pnlSoggettoBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSoggettoBodyInternal")]
	protected virtual Panel pnlSoggettoBodyInternal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiSoggettoTitle")]
	protected virtual Panel pnlDatiSoggettoTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatiSoggetto")]
	protected virtual IboWebLabel lblDatiSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_DatiSoggetto")]
	protected virtual UpdatePanel up_DatiSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiMittenteBody")]
	protected virtual Panel pnlDatiMittenteBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSoggetto")]
	protected virtual IboWebLabel lblTipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbTipoSoggetto
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoSoggetto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmbTipoSoggetto_SelectedIndexChanged;
			IboDropDownList val = _cmbTipoSoggetto;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbTipoSoggetto = value;
			val = _cmbTipoSoggetto;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblSoggetto_Codice")]
	protected virtual IboWebLabel lblSoggetto_Codice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnSoggetto_Codice")]
	protected virtual IboWebHidden hdnSoggetto_Codice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk Soggetto_Codice
	{
		[CompilerGenerated]
		get
		{
			return _Soggetto_Codice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(Soggetto_Codice_SelectedIndexChanged);
			IboWebComboTlk soggetto_Codice = _Soggetto_Codice;
			if (soggetto_Codice != null)
			{
				((RadComboBox)soggetto_Codice).SelectedIndexChanged -= val;
			}
			_Soggetto_Codice = value;
			soggetto_Codice = _Soggetto_Codice;
			if (soggetto_Codice != null)
			{
				((RadComboBox)soggetto_Codice).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("IboWebComboTlk1")]
	protected virtual IboWebComboTlk IboWebComboTlk1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggetto_RagioneSociale")]
	protected virtual IboWebLabel lblSoggetto_RagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_RagioneSociale")]
	protected virtual IboWebTextBox txtSoggetto_RagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSoggetto_Indirizzo")]
	protected virtual IboWebLabel lblSoggetto_Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_Indirizzo")]
	protected virtual IboWebTextBox txtSoggetto_Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_Cap")]
	protected virtual IboWebTextBox txtSoggetto_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_Localita")]
	protected virtual IboWebTextBox txtSoggetto_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_Provincia")]
	protected virtual IboWebTextBox txtSoggetto_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSoggetto_Nazione")]
	protected virtual IboWebTextBox txtSoggetto_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNoteBodyInternal")]
	protected virtual Panel pnlNoteBodyInternal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiNoteTitle")]
	protected virtual Panel pnlDatiNoteTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatiNote")]
	protected virtual IboWebLabel lblDatiNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiNoteBody")]
	protected virtual Panel pnlDatiNoteBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote1")]
	protected virtual IboWebLabel lblNote1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtnote1")]
	protected virtual IboWebTextBox txtnote1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote2")]
	protected virtual IboWebLabel lblNote2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote2")]
	protected virtual IboWebTextBox txtNote2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote3")]
	protected virtual IboWebLabel lblNote3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote3")]
	protected virtual IboWebTextBox txtNote3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpNote")]
	protected virtual TabPanel TpNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpRicaviCaption")]
	protected virtual IboWebLabel TpRicaviCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEventi_Title")]
	protected virtual Panel cpEventi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEventi_Title_Caption")]
	protected virtual IboWebLabel cpEventi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEventi_Body")]
	protected virtual Panel cpEventi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpEventi_Body")]
	protected virtual UpdatePanel up_cpEventi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdEventiDiv")]
	protected virtual Panel tlbgrdEventiDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdEventi")]
	protected virtual IboWebToolbar tlbgrdEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlEventi")]
	protected virtual IboWebPanel pnlEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdEventi")]
	protected virtual IboGridView grdEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDocumenti")]
	protected virtual TabPanel tpDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDocumentiCaption")]
	protected virtual IboWebLabel tpDocumentiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDocumenti_Title")]
	protected virtual Panel cpDocumenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDocumenti_Title_Caption")]
	protected virtual IboWebLabel cpDocumenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Documenti")]
	protected virtual UpdatePanel up_Documenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdDocumentiDiv")]
	protected virtual Panel tlbgrdDocumentiDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdDocumenti")]
	protected virtual IboWebToolbar tlbgrdDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDocumenti")]
	protected virtual IboWebPanel pnlDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdDocumenti")]
	protected virtual IboGridView grdDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpNotePratica")]
	protected virtual TabPanel tpNotePratica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpNotePraticaCaption")]
	protected virtual IboWebLabel tpNotePraticaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNotePratica_Title")]
	protected virtual Panel cpNotePratica_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNotePratica_Title_Caption")]
	protected virtual IboWebLabel cpNotePratica_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_NotePratica")]
	protected virtual UpdatePanel up_NotePratica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdNotePraticaDiv")]
	protected virtual Panel tlbgrdNotePraticaDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdNotePratica")]
	protected virtual IboWebToolbar tlbgrdNotePratica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNotePratica")]
	protected virtual IboWebPanel pnlNotePratica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdNotePratica")]
	protected virtual IboGridView grdNotePratica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.CONTESTAZIONI";
		_Title = base.Translator.Translate("XXX", "Contestazioni", new string[0]);
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
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.InitializeInternalGrid(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
				StateBag myViewState = base.MyViewState;
				IboGridView objGridView = grdEventi;
				iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
				grdEventi = objGridView;
				iboInternalGridConfig.Build("DM.DOC.CONTESTAZIONI.EVENTI", "SELECT * FROM GRD_CONTESTAZIONI_EVENTI WHERE IDCONTESTAZIONE='<%ID%>'", "", "", ((Control)grdEventi).ID, ((Control)tlbgrdEventi).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdDocumenti;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdDocumenti = objGridView;
				iboInternalGridConfig.Build("DM.DOC.CONTESTAZIONI.DOCUMENTI", "SELECT * FROM GRD_CONTESTAZIONI_DOCUMENTI WHERE IDCONTESTAZIONE='<%ID%>'", "", "", ((Control)grdDocumenti).ID, ((Control)tlbgrdDocumenti).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
				StateBag myViewState3 = base.MyViewState;
				objGridView = grdNotePratica;
				iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
				grdNotePratica = objGridView;
				iboInternalGridConfig.Build("DM.DOC.CONTESTAZIONI.NOTE", "SELECT * FROM GRD_CONTESTAZIONI_NOTE WHERE IDCONTESTAZIONE='<%ID%>'", "", "", ((Control)grdNotePratica).ID, ((Control)tlbgrdNotePratica).ID);
				GridConfigList.Add(iboInternalGridConfig);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if ((Operators.CompareString(txtUnibol.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtRiferimento1.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtRiferimento2.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire nella pratica di contestazione almeno un riferimento ad un documento");
			}
			else if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0 && Conversions.ToInteger(optStato.ObjValue.ToString()) != 10)
			{
				rsMess = TranslateMessage("XXX", "La pratica risulta in uno stato in cui non è possibile procedere alla cancellazione");
			}
			else if (Conversions.ToInteger(optStato.ObjValue) == 20 && Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "X", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Il soggetto controparte non è ancora stato definito. Impossibile chiudere la pratica di contestazione");
			}
			else
			{
				val2 = CheckSpedizione(ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Invalid comparison between Unknown and I4
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Invalid comparison between Unknown and I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0 || !((Conversions.ToInteger(optStato.ObjValue) == 20) | (Conversions.ToInteger(optStato.ObjValue) == 99)))
			{
				goto IL_00b7;
			}
			_objFunctionArguments.Name = "VISUALIZZAZIONE";
			Soggetto_Codice.ReadOnly = true;
			val2 = SetControlsEnabledProperty((IIncasTableLink)(object)this, ref _objFunctionArguments, ref rsMess);
			if ((int)val2 <= 0)
			{
				WriteInfoMessage("La contestazione risulta terminata o annullata. Impossibile modificare.", ShowAsNotification: true);
				goto IL_00b7;
			}
			val = val2;
			goto end_IL_000b;
			IL_00b7:
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
			{
				optStato.Visible = true;
				lblStato.Visible = true;
				lblDataChiusura.Visible = true;
				goto IL_02c6;
			}
			optStato.ObjValue = 10;
			optStato.Visible = false;
			lblStato.Visible = false;
			DataApertura.ObjValue = DateAndTime.Now;
			lblDataChiusura.Visible = false;
			cmbTipoSoggetto.ObjValue = "";
			cmbTipoContestazione.ObjValue = base.SessionEnvironment.ApplicationDefault.TipoContestazione_Default();
			if (Operators.CompareString(Conversions.ToString(_objFunctionArguments.Argomento1) ?? "", "", false) == 0)
			{
				goto IL_02c6;
			}
			txtUnibol.ObjValue = _objFunctionArguments.Argomento1.ToString();
			txtUnibol.Enabled = false;
			string text2 = "SELECT * FROM SPEDIZIONI WHERE Unibol=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString());
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (dataTable.Rows.Count > 0)
				{
					txtRiferimento1.ObjValue = dataTable.Rows[0]["NumeroBolla"].ToString();
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["DataBolla"])))
					{
						txtDataRiferimento1.ObjValue = Conversions.ToDate(dataTable.Rows[0]["DataBolla"]);
					}
				}
				goto IL_02c6;
			}
			val = val2;
			goto end_IL_000b;
			IL_02c6:
			lblSoggetto_Codice.Visible = true;
			txtSoggetto_Cap.ReadOnly = true;
			txtSoggetto_Indirizzo.ReadOnly = true;
			txtSoggetto_Localita.ReadOnly = true;
			txtSoggetto_Nazione.ReadOnly = true;
			txtSoggetto_Provincia.ReadOnly = true;
			txtSoggetto_RagioneSociale.ReadOnly = true;
			if (!((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
			{
				goto IL_0537;
			}
			if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "*", false) == 0)
			{
				Soggetto_Codice.Visible = false;
				lblSoggetto_Codice.Visible = false;
				if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0)
				{
					txtSoggetto_Cap.ReadOnly = false;
					txtSoggetto_Indirizzo.ReadOnly = false;
					txtSoggetto_Localita.ReadOnly = false;
					txtSoggetto_Nazione.ReadOnly = false;
					txtSoggetto_Provincia.ReadOnly = false;
					txtSoggetto_RagioneSociale.ReadOnly = false;
				}
				goto IL_0537;
			}
			if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "X", false) == 0)
			{
				Soggetto_Codice.Visible = false;
				lblSoggetto_Codice.Visible = false;
				txtSoggetto_Cap.ReadOnly = true;
				txtSoggetto_Indirizzo.ReadOnly = true;
				txtSoggetto_Localita.ReadOnly = true;
				txtSoggetto_Nazione.ReadOnly = true;
				txtSoggetto_Provincia.ReadOnly = true;
				txtSoggetto_RagioneSociale.ReadOnly = true;
				goto IL_0537;
			}
			string sItemValue = hdnSoggetto_Codice.ObjValue.ToString();
			Soggetto_Codice.Visible = true;
			lblSoggetto_Codice.Visible = true;
			val2 = ComboSetQueryAndFilter((IIboDropdownList)(object)Soggetto_Codice, "SELECT * FROM CBO_ANA_CONTESTAZIONI_SOGGETTI WHERE TipoSoggetto=" + base.DbConn.SQLFormatString(cmbTipoSoggetto.ObjValue.ToString()), "", sItemValue, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0537;
			}
			val = val2;
			goto end_IL_000b;
			IL_0537:
			if (Conversions.ToInteger(optStato.ObjValue) == 20)
			{
				lblDataChiusura.ObjValue = TranslateMessage("XXX", "Data chiusura");
			}
			else if (Conversions.ToInteger(optStato.ObjValue) == 99)
			{
				lblDataChiusura.ObjValue = TranslateMessage("XXX", "Data annullamento");
			}
			if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
			{
				btnCheckSpedizione.Visible = false;
			}
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
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

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objRet.ToString(), "ANNULLA", false) != 0)
			{
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdEventi).ID];
				string rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				getParentUpdatePanel((Control)(object)grdEventi).Update();
				objInternalGridConfig = GridConfigList[((Control)grdDocumenti).ID];
				rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				getParentUpdatePanel((Control)(object)grdDocumenti).Update();
				objInternalGridConfig = GridConfigList[((Control)grdNotePratica).ID];
				rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				getParentUpdatePanel((Control)(object)grdNotePratica).Update();
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

	private void optStato_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Conversions.ToInteger(optStato.ObjValue) == 20)
			{
				DataChiusura.ObjValue = DateAndTime.Now;
				lblDataChiusura.ObjValue = TranslateMessage("XXX", "Data chiusura");
			}
			else if (Conversions.ToInteger(optStato.ObjValue) == 10)
			{
				DataChiusura.ObjValue = "";
			}
			else if (Conversions.ToInteger(optStato.ObjValue) == 99)
			{
				lblDataChiusura.ObjValue = TranslateMessage("XXX", "Data annullamento");
				DataChiusura.ObjValue = DateAndTime.Now;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void cmbTipoSoggetto_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "*", false) == 0)
			{
				Soggetto_Codice.Visible = false;
				lblSoggetto_Codice.Visible = false;
				txtSoggetto_RagioneSociale.Required = true;
				Soggetto_Codice.Required = false;
				IboWebComboTlk soggetto_Codice = Soggetto_Codice;
				string rsMess2 = "";
				ComboSetQueryAndFilter((IIboDropdownList)(object)soggetto_Codice, "SELECT * FROM CBO_ANA_CONTESTAZIONI_SOGGETTI WHERE 1=2", "", "", ref rsMess2);
				txtSoggetto_Cap.ReadOnly = false;
				txtSoggetto_Indirizzo.ReadOnly = false;
				txtSoggetto_Localita.ReadOnly = false;
				txtSoggetto_Nazione.ReadOnly = false;
				txtSoggetto_Provincia.ReadOnly = false;
				txtSoggetto_RagioneSociale.ReadOnly = false;
			}
			else if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "X", false) == 0)
			{
				Soggetto_Codice.Visible = false;
				lblSoggetto_Codice.Visible = false;
				txtSoggetto_RagioneSociale.Required = false;
				Soggetto_Codice.Required = false;
				IboWebComboTlk soggetto_Codice2 = Soggetto_Codice;
				string rsMess2 = "";
				ComboSetQueryAndFilter((IIboDropdownList)(object)soggetto_Codice2, "SELECT * FROM CBO_ANA_CONTESTAZIONI_SOGGETTI WHERE 1=2", "", "", ref rsMess2);
				txtSoggetto_Cap.ReadOnly = true;
				txtSoggetto_Indirizzo.ReadOnly = true;
				txtSoggetto_Localita.ReadOnly = true;
				txtSoggetto_Nazione.ReadOnly = true;
				txtSoggetto_Provincia.ReadOnly = true;
				txtSoggetto_RagioneSociale.ReadOnly = true;
			}
			else
			{
				Soggetto_Codice.Visible = true;
				lblSoggetto_Codice.Visible = true;
				txtSoggetto_RagioneSociale.Required = false;
				Soggetto_Codice.Required = true;
				IboWebComboTlk soggetto_Codice3 = Soggetto_Codice;
				string sQuery = "SELECT * FROM CBO_ANA_CONTESTAZIONI_SOGGETTI WHERE TipoSoggetto=" + base.DbConn.SQLFormatString(cmbTipoSoggetto.ObjValue.ToString());
				string rsMess2 = "";
				ComboSetQueryAndFilter((IIboDropdownList)(object)soggetto_Codice3, sQuery, "", "", ref rsMess2);
				txtSoggetto_Cap.ReadOnly = true;
				txtSoggetto_Indirizzo.ReadOnly = true;
				txtSoggetto_Localita.ReadOnly = true;
				txtSoggetto_Nazione.ReadOnly = true;
				txtSoggetto_Provincia.ReadOnly = true;
				txtSoggetto_RagioneSociale.ReadOnly = true;
			}
			hdnSoggetto_Codice.ObjValue = "";
			txtSoggetto_Cap.ObjValue = "";
			txtSoggetto_Indirizzo.ObjValue = "";
			txtSoggetto_Localita.ObjValue = "";
			txtSoggetto_Nazione.ObjValue = "";
			txtSoggetto_Provincia.ObjValue = "";
			txtSoggetto_RagioneSociale.ObjValue = "";
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void Soggetto_Codice_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Invalid comparison between Unknown and I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			txtSoggetto_Cap.ObjValue = "";
			txtSoggetto_Indirizzo.ObjValue = "";
			txtSoggetto_Localita.ObjValue = "";
			txtSoggetto_Nazione.ObjValue = "";
			txtSoggetto_Provincia.ObjValue = "";
			txtSoggetto_RagioneSociale.ObjValue = "";
			if (Operators.CompareString(Soggetto_Codice.ObjValue.ToString(), "", false) != 0)
			{
				string text = "SELECT * FROM %ANAGRAFICA% WHERE CODICE=" + base.DbConn.SQLFormatString(Soggetto_Codice.ObjValue.ToString());
				if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "C", false) == 0)
				{
					text = Strings.Replace(text, "%ANAGRAFICA%", "Clienti", 1, -1, (CompareMethod)0);
				}
				else if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "H", false) == 0)
				{
					text = Strings.Replace(text, "%ANAGRAFICA%", "Corrispondenti", 1, -1, (CompareMethod)0);
				}
				else if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "V", false) == 0)
				{
					text = Strings.Replace(text, "%ANAGRAFICA%", "Trasportatori", 1, -1, (CompareMethod)0);
				}
				else if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "D", false) == 0)
				{
					text = Strings.Replace(text, "%ANAGRAFICA%", "Destinatari", 1, -1, (CompareMethod)0);
				}
				else if (Operators.CompareString(cmbTipoSoggetto.ObjValue.ToString(), "M", false) == 0)
				{
					text = Strings.Replace(text, "%ANAGRAFICA%", "Caricatori", 1, -1, (CompareMethod)0);
				}
				DataTable dataTable = null;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				if (dataTable.Rows.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Impossibile trovare il soggetto controparte nelle anagrafiche di Delsy");
					IboWebComboTlk soggetto_Codice = Soggetto_Codice;
					string rsMess2 = "";
					ComboSelectedItem((IIboDropdownList)(object)soggetto_Codice, "", ref rsMess2);
					return;
				}
				txtSoggetto_Cap.ObjValue = dataTable.Rows[0]["Cap"].ToString();
				txtSoggetto_Indirizzo.ObjValue = dataTable.Rows[0]["Indirizzo"].ToString();
				txtSoggetto_Localita.ObjValue = dataTable.Rows[0]["Localita"].ToString();
				txtSoggetto_Nazione.ObjValue = dataTable.Rows[0]["Nazione"].ToString();
				txtSoggetto_Provincia.ObjValue = dataTable.Rows[0]["Provincia"].ToString();
				txtSoggetto_RagioneSociale.ObjValue = dataTable.Rows[0]["RagioneSociale"].ToString();
			}
			hdnSoggetto_Codice.ObjValue = Soggetto_Codice.ObjValue.ToString();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnCheckSpedizione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(txtUnibol.ObjValue.ToString(), "", false) != 0)
			{
				val2 = CheckSpedizione(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				WriteInfoMessage(TranslateMessage("XXX", "La spedizione esiste"), ShowAsNotification: true);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnVediSpedizione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(txtUnibol.ObjValue.ToString(), "", false) != 0)
			{
				val2 = CheckSpedizione(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				string[] CampiChiave = new string[1] { "Unibol" };
				object[] ValoriCampiChiave = new object[1] { txtUnibol.ObjValue.ToString() };
				SetIframeHeightAutoResize();
				val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "DM.DOC.SPEDIZIONI", "Spedizione", WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, "VisualizzaSpedizioneDimensions", "DM.DOC.SPEDIZIONI", "VISUALIZZAZIONE", ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
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
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.WFIPage = this;
			val2 = base.InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: false, ref rsMess);
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

	protected override FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.WFIPage = this;
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIDContestazione", "Text", ref PropertyValue);
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
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (funcArg.Data.Count != 1)
			{
				rsMess = TranslateMessage("XXX", "Selezionare un record da modificare");
			}
			else
			{
				funcArg.WFIPage = this;
				val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: false, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (funcArg.Data.Count != 1)
			{
				rsMess = TranslateMessage("XXX", "Selezionare un record da eliminare");
			}
			else
			{
				val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.WFIPage = this;
			val2 = base.InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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
			val2 = base.InternalGridAggiorna(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected FXRETURN CheckSpedizione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(txtUnibol.ObjValue.ToString(), "", false) == 0)
			{
				goto IL_00ce;
			}
			object obj = null;
			string text = "SELECT COUNT(*) FROM SPEDIZIONI WHERE UNIBOL=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Conversions.ToInteger(obj) != 0)
				{
					goto IL_00ce;
				}
				rsMess = TranslateMessage("XXX", "La spedizione con id {0} non esiste.", txtUnibol.ObjValue.ToString());
				((Control)txtUnibol).Focus();
			}
			goto end_IL_0005;
			IL_00ce:
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
}
