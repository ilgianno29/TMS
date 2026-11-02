using System;
using System.Collections.Generic;
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

public class WFANAClienti : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkEsportazioneEsiti")]
	private IboWebCheckBox _chkEsportazioneEsiti;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTuttiClassi")]
	private IboWebButton _btnTuttiClassi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNessunoClassi")]
	private IboWebButton _btnNessunoClassi;

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

	[field: AccessedThroughProperty("lblCodice")]
	protected virtual IboWebLabel lblCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodice")]
	protected virtual IboWebTextBox txtCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceContabile")]
	protected virtual IboWebLabel lblCodiceContabile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceContabile")]
	protected virtual IboWebTextBox txtCodiceContabile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteMittente")]
	protected virtual IboWebLabel lblClienteMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optClienteMittente")]
	protected virtual IboWebRadioButtonList optClienteMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttivo")]
	protected virtual IboWebLabel lblAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAttivo")]
	protected virtual IboWebCheckBox chkAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRagioneSociale")]
	protected virtual IboWebLabel lblRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRagioneSociale")]
	protected virtual IboWebTextBox txtRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTelefono")]
	protected virtual IboWebLabel lblTelefono
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTelefono")]
	protected virtual IboWebTextBox txtTelefono
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFax")]
	protected virtual IboWebLabel lblFax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFax")]
	protected virtual IboWebTextBox txtFax
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzo")]
	protected virtual IboWebLabel lblIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIndirizzo")]
	protected virtual IboWebTextBox txtIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceFiscale")]
	protected virtual IboWebLabel lblCodiceFiscale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceFiscale")]
	protected virtual IboWebTextBox txtCodiceFiscale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartitaIva")]
	protected virtual IboWebLabel lblPartitaIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPartitaIva")]
	protected virtual IboWebTextBox txtPartitaIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCap")]
	protected virtual IboWebTextBox txtCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalita")]
	protected virtual IboWebTextBox txtLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtProvincia")]
	protected virtual IboWebTextBox txtProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNazione")]
	protected virtual IboWebTextBox txtNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEmail")]
	protected virtual IboWebLabel lblEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEmail")]
	protected virtual IboWebTextBox txtEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimento")]
	protected virtual IboWebLabel lblRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento")]
	protected virtual IboWebTextBox txtRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote")]
	protected virtual IboWebLabel lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	protected virtual IboWebTextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAmministrazione_Title")]
	protected virtual Panel cpAmministrazione_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAmministrazione_Title_Caption")]
	protected virtual IboWebLabel cpAmministrazione_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAmministrazione_Body")]
	protected virtual Panel cpAmministrazione_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFatturaA")]
	protected virtual IboWebLabel lblFatturaA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFatturaA")]
	protected virtual IboWebComboTlk cmbFatturaA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblConMagazzino")]
	protected virtual IboWebLabel lblConMagazzino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optConMagazzino")]
	protected virtual IboWebRadioButtonList optConMagazzino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFlgTra")]
	protected virtual IboWebLabel lblFlgTra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optFlgTra")]
	protected virtual IboWebRadioButtonList optFlgTra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceIva")]
	protected virtual IboWebLabel lblCodiceIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCodiceIva")]
	protected virtual IboWebComboTlk cmbCodiceIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImportazione")]
	protected virtual IboWebLabel lblImportazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optImportazione")]
	protected virtual IboWebRadioButtonList optImportazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStampaBolla")]
	protected virtual IboWebLabel lblStampaBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optStampaBolla")]
	protected virtual IboWebRadioButtonList optStampaBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodicePagamento")]
	protected virtual IboWebLabel lblCodicePagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCodicePagamento")]
	protected virtual IboWebComboTlk cmbCodicePagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEsportazioneBolle")]
	protected virtual IboWebLabel lblEsportazioneBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optEsportazioneBolle")]
	protected virtual IboWebRadioButtonList optEsportazioneBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReportFatture")]
	protected virtual IboWebLabel lblReportFatture
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReportFatture")]
	protected virtual IboWebTextBox txtReportFatture
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReportBolle")]
	protected virtual IboWebLabel lblReportBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReportBolle")]
	protected virtual IboWebTextBox txtReportBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeratoreBolle")]
	protected virtual IboWebLabel lblNumeratoreBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeratoreBolle")]
	protected virtual IboWebNumericTlk txtNumeratoreBolle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatFat")]
	protected virtual IboWebLabel lblDatFat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbDatFat")]
	protected virtual IboDropDownList cmbDatFat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatoMinimoSpedizioniFatt")]
	protected virtual IboWebLabel lblStatoMinimoSpedizioniFatt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbStatoMinimoSpedizioniFatt")]
	protected virtual IboDropDownList cmbStatoMinimoSpedizioniFatt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatoMinimoViaggiFatt")]
	protected virtual IboWebLabel lblStatoMinimoViaggiFatt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbStatoMinimoViaggiFatt")]
	protected virtual IboDropDownList cmbStatoMinimoViaggiFatt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpEventi")]
	protected virtual TabPanel tpEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpEventiCaption")]
	protected virtual IboWebLabel tpEventiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Eventi")]
	protected virtual UpdatePanel up_Eventi
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

	[field: AccessedThroughProperty("lblEsportazioneEsiti")]
	protected virtual IboWebLabel lblEsportazioneEsiti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox chkEsportazioneEsiti
	{
		[CompilerGenerated]
		get
		{
			return _chkEsportazioneEsiti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkEsportazioneEsiti_CheckedChanged;
			IboWebCheckBox val = _chkEsportazioneEsiti;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged -= eventHandler;
			}
			_chkEsportazioneEsiti = value;
			val = _chkEsportazioneEsiti;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("tlbgrdClientiEventiTipi")]
	protected virtual IboWebToolbar tlbgrdClientiEventiTipi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiEventiTipi")]
	protected virtual Panel pnlClientiEventiTipi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiEventiTipi")]
	protected virtual IboGridView grdClientiEventiTipi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	protected virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClientiEventi")]
	protected virtual IboWebToolbar tlbgrdClientiEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiEventi")]
	protected virtual Panel pnlClientiEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiEventi")]
	protected virtual IboGridView grdClientiEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpContatti")]
	protected virtual TabPanel tpContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpContattiCaption")]
	protected virtual IboWebLabel tpContattiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Title")]
	protected virtual Panel cpContatti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Title_Caption")]
	protected virtual IboWebLabel cpContatti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpContatti_Body")]
	protected virtual Panel cpContatti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClientiContatti")]
	protected virtual IboWebToolbar tlbgrdClientiContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiContatti")]
	protected virtual Panel pnlClientiContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiContatti")]
	protected virtual IboGridView grdClientiContatti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassi")]
	protected virtual TabPanel tpClassi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpClassiCaption")]
	protected virtual IboWebLabel tpClassiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Title")]
	protected virtual Panel cpClassi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Title_Caption")]
	protected virtual IboWebLabel cpClassi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpClassi_Body")]
	protected virtual Panel cpClassi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpClassi_Body")]
	protected virtual UpdatePanel up_cpClassi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClientiClassi")]
	protected virtual IboWebCheckBoxList ClientiClassi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnTuttiClassi
	{
		[CompilerGenerated]
		get
		{
			return _btnTuttiClassi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTuttiClassi_Click;
			IboWebButton val = _btnTuttiClassi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTuttiClassi = value;
			val = _btnTuttiClassi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnNessunoClassi
	{
		[CompilerGenerated]
		get
		{
			return _btnNessunoClassi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnNessunoClassi_Click;
			IboWebButton val = _btnNessunoClassi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnNessunoClassi = value;
			val = _btnNessunoClassi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("tpInfoAgg")]
	protected virtual TabPanel tpInfoAgg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpInfoAggCaption")]
	protected virtual IboWebLabel tpInfoAggCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Title")]
	protected virtual Panel cpInfoAgg_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Title_Caption")]
	protected virtual IboWebLabel cpInfoAgg_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoAgg_Body")]
	protected virtual Panel cpInfoAgg_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClientiInfoAggiuntive")]
	protected virtual IboWebToolbar tlbgrdClientiInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiInfoAggiuntive")]
	protected virtual Panel pnlClientiInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiInfoAggiuntive")]
	protected virtual IboGridView grdClientiInfoAggiuntive
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

	[field: AccessedThroughProperty("cpDocumenti_Body")]
	protected virtual Panel cpDocumenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClientiDocumenti")]
	protected virtual IboWebToolbar tlbgrdClientiDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiDocumenti")]
	protected virtual Panel pnlClientiDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiDocumenti")]
	protected virtual IboGridView grdClientiDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpTipiSpedizione")]
	protected virtual TabPanel tpTipiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpTipiSpedizioneCaption")]
	protected virtual IboWebLabel tpTipiSpedizioneCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTipiSpedizione_Title")]
	protected virtual Panel cpTipiSpedizione_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTipiSpedizione_Title_Caption")]
	protected virtual IboWebLabel cpTipiSpedizione_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTipiSpedizione_Body")]
	protected virtual Panel cpTipiSpedizione_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdClientiTipiSpedizione")]
	protected virtual IboWebToolbar tlbgrdClientiTipiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiTipiSpedizione")]
	protected virtual Panel pnlClientiTipiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdClientiTipiSpedizione")]
	protected virtual IboGridView grdClientiTipiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.ANA.CLIENTI";
		_AutoCodeKeyField = "Codice";
		_Tabella = "CLIENTI";
		_Title = base.Translator.Translate("XXX", "Cliente", new string[0]);
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
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdClientiContatti;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdClientiContatti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.CONTATTI#CLIENTI", "SELECT * FROM GRD_ANA_Clienti_Contatti WHERE CODICECLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiContatti).ID, ((Control)tlbgrdClientiContatti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdClientiInfoAggiuntive;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdClientiInfoAggiuntive = objGridView;
			iboInternalGridConfig.Build("DM.ANA.INFOAGGANAGRAFICHE#CLI", "SELECT * FROM GRD_ANA_Clienti_InfoAgg WHERE CODICECLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiInfoAggiuntive).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdClientiDocumenti;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdClientiDocumenti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.DOCUMENTIANA#CLIENTI", "SELECT * FROM GRD_ANA_Clienti_Documenti WHERE CODICECLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiDocumenti).ID, ((Control)tlbgrdClientiDocumenti).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdClientiEventi;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdClientiEventi = objGridView;
			iboInternalGridConfig.Build("DM.ANA.CLIENTIEVENTI", "SELECT * FROM GRD_ANA_Clienti_Eventi WHERE CLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiEventi).ID, ((Control)tlbgrdClientiEventi).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
			StateBag myViewState5 = base.MyViewState;
			objGridView = grdClientiEventiTipi;
			iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
			grdClientiEventiTipi = objGridView;
			iboInternalGridConfig.Build("DM.ANA.CLIENTIEVENTITIPI", "SELECT * FROM GRD_ANA_Clienti_EventiTipi WHERE CLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiEventiTipi).ID, ((Control)tlbgrdClientiEventiTipi).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig7 = iboInternalGridConfig;
			StateBag myViewState6 = base.MyViewState;
			objGridView = grdClientiTipiSpedizione;
			iboInternalGridConfig7.InitUi(myViewState6, ref objGridView);
			grdClientiTipiSpedizione = objGridView;
			iboInternalGridConfig.Build("DM.ANA.CLIENTITIPISPEDIZIONE", "SELECT * FROM GRD_ANA_Clienti_TipiSped WHERE CLIENTE='<%CODICE%>'", "", "", ((Control)grdClientiTipiSpedizione).ID, ((Control)tlbgrdClientiTipiSpedizione).ID);
			GridConfigList.Add(iboInternalGridConfig);
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

	protected override FXRETURN InitializeDupInfo(ref WFIDupInfoCollection DupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			WFIDupInfo wFIDupInfo = new WFIDupInfo("ClientiTipiSpedizione", "Cliente=" + base.DbConn.SQLFormatString(this.BeforeImage["Codice"].FieldValue.ToString()));
			((Dictionary<string, string>)(object)wFIDupInfo.CampiDaSostituire).Add("Cliente", base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()));
			DupInfo.Add(wFIDupInfo);
			wFIDupInfo = new WFIDupInfo("ClientiTipiSpedizioneTipiMerce", "Cliente=" + base.DbConn.SQLFormatString(this.BeforeImage["Codice"].FieldValue.ToString()));
			((Dictionary<string, string>)(object)wFIDupInfo.CampiDaSostituire).Add("Cliente", base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()));
			DupInfo.Add(wFIDupInfo);
			wFIDupInfo = new WFIDupInfo("ClientiClassi", "Cliente=" + base.DbConn.SQLFormatString(this.BeforeImage["Codice"].FieldValue.ToString()));
			((Dictionary<string, string>)(object)wFIDupInfo.CampiDaSostituire).Add("Cliente", base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()));
			DupInfo.Add(wFIDupInfo);
			wFIDupInfo = new WFIDupInfo("ClientiEventi", "Cliente=" + base.DbConn.SQLFormatString(this.BeforeImage["Codice"].FieldValue.ToString()));
			((Dictionary<string, string>)(object)wFIDupInfo.CampiDaSostituire).Add("Cliente", base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()));
			DupInfo.Add(wFIDupInfo);
			val = base.InitializeDupInfo(ref DupInfo, ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
			{
				txtNazione.Text = base.SessionEnvironment.ApplicationDefault.NazioneDefault();
				cmbDatFat.ObjValue = "DATABOLLA";
			}
			if (!((CheckBox)chkEsportazioneEsiti).Checked)
			{
				tlbgrdClientiEventiTipi.Enabled = false;
				goto IL_00e2;
			}
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0)
			{
				goto IL_00e2;
			}
			tlbgrdClientiEventiTipi.Enabled = true;
			val2 = InserimentoEventiCliente(ref rsMess);
			if ((int)val2 <= 0)
			{
				getParentUpdatePanel((Control)(object)chkEsportazioneEsiti).Update();
				goto IL_00e2;
			}
			val = val2;
			goto end_IL_000b;
			IL_00e2:
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((CheckBox)chkEsportazioneEsiti).Checked)
			{
				tlbgrdClientiEventiTipi.Enabled = false;
				goto IL_00ae;
			}
			if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
			{
				goto IL_00ae;
			}
			tlbgrdClientiEventiTipi.Enabled = true;
			val2 = InserimentoEventiCliente(ref rsMess);
			if ((int)val2 <= 0)
			{
				getParentUpdatePanel((Control)(object)chkEsportazioneEsiti).Update();
				goto IL_00ae;
			}
			val = val2;
			goto end_IL_000b;
			IL_00ae:
			val2 = base.AfterSaveData(ref rsMess);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = CheckInserimentoFatturaA(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if ((Operators.CompareString(optFlgTra.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(optConMagazzino.ObjValue.ToString(), "N", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Il cliente deve aver valorizzato almeno 1 tra deposito o transito");
			}
			else
			{
				val2 = base.CheckData(ref rsMess);
				if ((int)val2 <= 0)
				{
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private void btnTuttiClassi_Click(object sender, EventArgs e)
	{
		ClientiClassi.SelectAll();
	}

	private void btnNessunoClassi_Click(object sender, EventArgs e)
	{
		ClientiClassi.UnselectAll();
	}

	private void chkEsportazioneEsiti_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (((CheckBox)chkEsportazioneEsiti).Checked)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					tlbgrdClientiEventiTipi.Enabled = true;
					val = InserimentoEventiCliente(ref rsMess);
					if ((int)val > 0)
					{
						return;
					}
					IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdClientiEventiTipi).ID];
					string rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				}
			}
			else
			{
				tlbgrdClientiEventiTipi.Enabled = false;
			}
			getParentUpdatePanel((Control)(object)chkEsportazioneEsiti).Update();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
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

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "CLIENTI";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
			val2 = base.InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = txtCodice.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			PropertyValue = txtRagioneSociale.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "CLIENTI";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "CLIENTI";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiContatti).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiInfoAggiuntive).ID, false) == 0))
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
				PropertyValue = RuntimeHelpers.GetObjectValue(txtRagioneSociale.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			}
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "CLIENTI";
			SetFormState(redirectToOnlyAspxPageName, "TipoSoggetto", "Value", ref PropertyValue2);
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
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Invalid comparison between Unknown and I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdClientiEventiTipi).ID, false) != 0)
				{
					goto IL_02a4;
				}
				if (funcArg.Data.Count != 0)
				{
					int num = checked(funcArg.Data[0].FieldValuesCount - 1);
					for (int i = 0; i <= num; i = checked(i + 1))
					{
						string text2 = funcArg.Data.Item("TipoEvento").get_FieldValues(i).ToString();
						if (Operators.CompareString(e.CommandName.ToUpper(), "ABILITA", false) == 0)
						{
							text = "UPDATE ClientiEventiTipi SET ESPORTAZIONE = 'S', UTEAGG = " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",DATAGG =" + base.DbConn.GetDate() + " ";
							text = text + "WHERE CLIENTE = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + " And TipoEvento = " + base.DbConn.SQLFormatString(text2);
						}
						else if (Operators.CompareString(e.CommandName.ToUpper(), "DISABILITA", false) == 0)
						{
							text = "UPDATE ClientiEventiTipi SET ESPORTAZIONE = 'N', UTEAGG = " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",DATAGG =" + base.DbConn.GetDate() + " ";
							text = text + "WHERE CLIENTE = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + " And TipoEvento = " + base.DbConn.SQLFormatString(text2);
						}
						if (Operators.CompareString(text, "", false) == 0)
						{
							continue;
						}
						val2 = base.DbConn.SqlExec(text, ref rsMess);
						if ((int)val2 <= 0)
						{
							continue;
						}
						val = val2;
						goto end_IL_000b;
					}
					goto IL_02a4;
				}
				rsMess = TranslateMessage("XXX", "Selezionare un record da abilitare \\ disabilitare");
			}
			goto end_IL_000b;
			IL_02a4:
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

	private FXRETURN CheckInserimentoFatturaA(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(optClienteMittente.ObjValue.ToString(), "M", false) == 0)
			{
				cmbFatturaA.Required = false;
			}
			else
			{
				cmbFatturaA.Required = true;
				if ((Operators.CompareString(cmbFatturaA.SelectedValue.ToString(), "", false) == 0) & (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0))
				{
					text = Strings.LSet(txtCodice.Text, 16) + txtRagioneSociale.Text;
					text = Strings.Replace(text, " ", base.BaseFunctions.HtmlDecodedSpaces(1), 1, -1, (CompareMethod)0);
					RadComboBoxItem val3 = null;
					val3 = new RadComboBoxItem(text, txtCodice.Text);
					((RadComboBox)cmbFatturaA).Items.Add(val3);
					cmbFatturaA.SelectedValue = txtCodice.Text;
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
			result = val;
		}
		return result;
	}

	private FXRETURN InserimentoEventiCliente(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			text = "INSERT INTO ClientiEventiTipi (Cliente, TipoEvento, Esportazione) SELECT " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ",CODICE,'N' FROM Eventi_Tipi ";
			text += "WHERE ESPORTAZIONE = 'S' AND CODICE NOT IN ";
			text = text + "(SELECT TIPOEVENTO FROM ClientiEventiTipi WHERE CLIENTE = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + " )";
			val2 = base.DbConn.SqlExec(text, ref rsMess);
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
}
