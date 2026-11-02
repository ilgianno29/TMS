using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCContrassegni : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcola")]
	private IboWebButton _btnCalcola;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnIncassato")]
	private IboWebButton _btnIncassato;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
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

	[field: AccessedThroughProperty("IdContrassegno")]
	protected virtual IboWebLabel IdContrassegno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataCreazione")]
	protected virtual IboWebLabel lblDataCreazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataCreazione")]
	protected virtual IboWebLabel DataCreazione
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

	[field: AccessedThroughProperty("txtStato")]
	protected virtual IboWebHidden txtStato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Stato")]
	protected virtual IboWebLabel Stato
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

	[field: AccessedThroughProperty("UnibolMAster")]
	protected virtual IboWebLabel UnibolMAster
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibolApertura")]
	protected virtual IboWebLabel lblUnibolApertura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UnibolApertura")]
	protected virtual IboWebLabel UnibolApertura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibolChiusura")]
	protected virtual IboWebLabel lblUnibolChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UnibolChiusura")]
	protected virtual IboWebLabel UnibolChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTestataBodyRight")]
	protected virtual Panel pnlTestataBodyRight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlImportoTitle")]
	protected virtual Panel pnlImportoTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImportoTitle")]
	protected virtual IboWebLabel lblImportoTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Importo")]
	protected virtual UpdatePanel up_Importo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlImportoBody")]
	protected virtual Panel pnlImportoBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrassegno")]
	protected virtual IboWebLabel lblContrassegno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtContrassegno")]
	protected virtual IboWebNumericTlk txtContrassegno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlIntestazioniBody")]
	protected virtual Panel pnlIntestazioniBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlIntestazioniBodyLeft")]
	protected virtual Panel pnlIntestazioniBodyLeft
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiMittenteTitle")]
	protected virtual Panel pnlDatiMittenteTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatiMittente")]
	protected virtual IboWebLabel lblDatiMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_DatiMittente")]
	protected virtual UpdatePanel up_DatiMittente
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

	[field: AccessedThroughProperty("lblCliente")]
	protected virtual IboWebLabel lblCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCliente")]
	protected virtual IboWebHidden txtCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	protected virtual IboWebLabel Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteFatturazione")]
	protected virtual IboWebLabel lblClienteFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClienteFatturazione")]
	protected virtual IboWebHidden txtClienteFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClienteFatturazione")]
	protected virtual IboWebLabel ClienteFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDestinazioneMerceTitle")]
	protected virtual Panel pnlDestinazioneMerceTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazioneMerceTitle")]
	protected virtual IboWebLabel lblDestinazioneMerceTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_DestinazioneMerce")]
	protected virtual UpdatePanel up_DestinazioneMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDestinazioneMerceBody")]
	protected virtual Panel pnlDestinazioneMerceBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDEstinazione")]
	protected virtual IboWebLabel lblPCSDEstinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDEstinazione_RagioneSociale")]
	protected virtual IboWebLabel PCSDEstinazione_RagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbPCSDestinazionelIndirizzo")]
	protected virtual IboWebLabel lbPCSDestinazionelIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_Indirizzo")]
	protected virtual IboWebLabel PCSDestinazione_Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_Cap")]
	protected virtual IboWebLabel PCSDestinazione_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_Localita")]
	protected virtual IboWebLabel PCSDestinazione_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_Provincia")]
	protected virtual IboWebLabel PCSDestinazione_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_Nazione")]
	protected virtual IboWebLabel PCSDestinazione_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlRiferimentiTrasportoTitle")]
	protected virtual Panel pnlRiferimentiTrasportoTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimentiTrasportoTitle")]
	protected virtual IboWebLabel lblRiferimentiTrasportoTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_corrispondente")]
	protected virtual UpdatePanel up_corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	protected virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondente")]
	protected virtual IboWebLabel lblCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCorrispondente")]
	protected virtual IboWebHidden txtCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Corrispondente")]
	protected virtual IboWebLabel Corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTrasportatore")]
	protected virtual IboWebLabel lblTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTrasportatore")]
	protected virtual IboWebHidden txtTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Trasportatore")]
	protected virtual IboWebLabel Trasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTrasportatoreFatturazione")]
	protected virtual IboWebLabel lblTrasportatoreFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTrasportatoreFatturazione")]
	protected virtual IboWebHidden txtTrasportatoreFatturazione
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

	[field: AccessedThroughProperty("pnlIntestazioniBodyRight")]
	protected virtual Panel pnlIntestazioniBodyRight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlGestioneOperativaTitle")]
	protected virtual Panel pnlGestioneOperativaTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGestioneOperativa")]
	protected virtual IboWebLabel lblGestioneOperativa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_GetioneOperativa")]
	protected virtual UpdatePanel up_GetioneOperativa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlGestioneOperativaBody")]
	protected virtual Panel pnlGestioneOperativaBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCausaleEsito")]
	protected virtual IboWebLabel lblCausaleEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCausaleEsito")]
	protected virtual IboWebHidden txtCausaleEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CausaleEsito")]
	protected virtual IboWebLabel CausaleEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataEsito")]
	protected virtual IboWebLabel lblDataEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEsito")]
	protected virtual IboWebLabel DataEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteEsito")]
	protected virtual IboWebLabel lblNoteEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteEsito")]
	protected virtual IboWebTextBox txtNoteEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataIncasso")]
	protected virtual IboWebLabel lblDataIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataIncasso")]
	protected virtual IboWebLabel DataIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteIncasso")]
	protected virtual IboWebLabel lblNoteIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteIncasso")]
	protected virtual IboWebTextBox txtNoteIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoIncasso")]
	protected virtual IboWebLabel lblTipoIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoIncasso")]
	protected virtual IboWebHidden txtTipoIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoIncasso")]
	protected virtual IboWebLabel TipoIncasso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpRicavi")]
	protected virtual TabPanel TpRicavi
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

	[field: AccessedThroughProperty("cpRicavi_Title")]
	protected virtual Panel cpRicavi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRicavi_Title_Caption")]
	protected virtual IboWebLabel cpRicavi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRicavi_Body")]
	protected virtual Panel cpRicavi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpRicavi_Body")]
	protected virtual UpdatePanel up_cpRicavi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdFatturaAttiva")]
	protected virtual IboWebLabel lblIdFatturaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdFatturaAttiva")]
	protected virtual IboWebTextBox txtIdFatturaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdRicaviDiv")]
	protected virtual Panel tlbgrdRicaviDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdRicavi")]
	protected virtual IboWebToolbar tlbgrdRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlChkBloccaRicavi")]
	protected virtual Panel pnlChkBloccaRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBloccaRicavi")]
	protected virtual IboWebLabel lblBloccaRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBloccaRicavi")]
	protected virtual IboWebCheckBox chkBloccaRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlRicavi")]
	protected virtual Panel pnlRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdRicavi")]
	protected virtual IboGridView grdRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpCosti")]
	protected virtual TabPanel TpCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpCostiCaption")]
	protected virtual IboWebLabel TpCostiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpCosti_Title")]
	protected virtual Panel cpCosti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpCosti_Title_Caption")]
	protected virtual IboWebLabel cpCosti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpCosti_Body")]
	protected virtual Panel cpCosti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpCosti_Body")]
	protected virtual UpdatePanel up_cpCosti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdFatturaPassiva")]
	protected virtual IboWebLabel lblIdFatturaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdFatturaPassiva")]
	protected virtual IboWebTextBox txtIdFatturaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdCostiDiv")]
	protected virtual Panel tlbgrdCostiDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdCosti")]
	protected virtual IboWebToolbar tlbgrdCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DivPnlChkBloccaCosti")]
	protected virtual Panel DivPnlChkBloccaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlChkBloccaCosti")]
	protected virtual Panel pnlChkBloccaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBloccaCosti")]
	protected virtual IboWebLabel lblBloccaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkBloccaCosti")]
	protected virtual IboWebCheckBox chkBloccaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCosti")]
	protected virtual Panel pnlCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdCosti")]
	protected virtual IboGridView grdCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDett")]
	protected virtual TabPanel tpDett
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpDettCaption")]
	protected virtual IboWebLabel tpDettCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltro_Title")]
	protected virtual Panel cpAltro_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltro_Title_Caption")]
	protected virtual Label cpAltro_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Altro")]
	protected virtual UpdatePanel up_Altro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltro_Body")]
	protected virtual Panel cpAltro_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa1")]
	protected virtual IboWebLabel lblFillerAlfa1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa1")]
	protected virtual IboWebTextBox txtFillerAlfa1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa6")]
	protected virtual IboWebLabel lblFillerAlfa6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa6")]
	protected virtual IboWebTextBox txtFillerAlfa6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa2")]
	protected virtual IboWebLabel lblFillerAlfa2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa2")]
	protected virtual IboWebTextBox txtFillerAlfa2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa7")]
	protected virtual IboWebLabel lblFillerAlfa7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa7")]
	protected virtual IboWebTextBox txtFillerAlfa7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa3")]
	protected virtual IboWebLabel lblFillerAlfa3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa3")]
	protected virtual IboWebTextBox txtFillerAlfa3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa8")]
	protected virtual IboWebLabel lblFillerAlfa8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa8")]
	protected virtual IboWebTextBox txtFillerAlfa8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa4")]
	protected virtual IboWebLabel lblFillerAlfa4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa4")]
	protected virtual IboWebTextBox txtFillerAlfa4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa9")]
	protected virtual IboWebLabel lblFillerAlfa9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa9")]
	protected virtual IboWebTextBox txtFillerAlfa9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa5")]
	protected virtual IboWebLabel lblFillerAlfa5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa5")]
	protected virtual IboWebTextBox txtFillerAlfa5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFillerAlfa10")]
	protected virtual IboWebLabel lblFillerAlfa10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFillerAlfa10")]
	protected virtual IboWebTextBox txtFillerAlfa10
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

	[field: AccessedThroughProperty("txtNote1")]
	protected virtual IboWebTextBox txtNote1
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

	[field: AccessedThroughProperty("lblDoc1")]
	protected virtual IboWebLabel lblDoc1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgDoc1")]
	protected virtual IboWebImage imgDoc1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDoc2")]
	protected virtual IboWebLabel lblDoc2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgDoc2")]
	protected virtual IboWebImage imgDoc2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDoc3")]
	protected virtual IboWebLabel lblDoc3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgDoc3")]
	protected virtual IboWebImage imgDoc3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnCalcola
	{
		[CompilerGenerated]
		get
		{
			return _btnCalcola;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCalcola_Click;
			IboWebButton val = _btnCalcola;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCalcola = value;
			val = _btnCalcola;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnIncassato
	{
		[CompilerGenerated]
		get
		{
			return _btnIncassato;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnIncassato_Click;
			IboWebButton val = _btnIncassato;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnIncassato = value;
			val = _btnIncassato;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
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
		_Context = "DM.DOC.CONTRASSEGNI";
		_Title = base.Translator.Translate("XXX", "Contrassegno", new string[0]);
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
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
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
				IboGridView objGridView = grdRicavi;
				iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
				grdRicavi = objGridView;
				iboInternalGridConfig.Build("DM.DOC.CONTRASSEGNI.RICAVI", "SELECT * FROM GRD_CONTRASSEGNI_RICAVI WHERE IDCONTRASSEGNO='<%ID%>'", "", "", ((Control)grdRicavi).ID, ((Control)tlbgrdRicavi).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdCosti;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdCosti = objGridView;
				iboInternalGridConfig.Build("DM.DOC.CONTRASSEGNI.COSTI", "SELECT * FROM GRD_CONTRASSEGNI_COSTI WHERE IDCONTRASSEGNO='<%ID%>'", "", "", ((Control)grdCosti).ID, ((Control)tlbgrdCosti).ID);
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

	protected override FXRETURN SetControlsEnabledProperty(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objFunctionArguments.Name, "MODIFICA", false) == 0 && ((Operators.CompareString(txtIdFatturaAttiva.ObjValue.ToString(), "", false) != 0) | (Operators.CompareString(txtIdFatturaPassiva.ObjValue.ToString(), "", false) != 0)))
			{
				objFunctionArguments.Name = "VISUALIZZAZIONE";
				WriteInfoMessage(TranslateMessage("XXX", "Il contrassegno risulta fatturato e quindi non è più possibile apportare delle modifiche. Il contrassegno è stata aperto in sola visualizzazione"), ShowAsNotification: true);
			}
			val = base.SetControlsEnabledProperty(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					btnCalcola.Visible = true;
				}
				else
				{
					btnCalcola.Visible = false;
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(txtStato.ObjValue.ToString(), "10", false) != 0)
				{
					txtContrassegno.ReadOnly = true;
				}
				if (Operators.CompareString(txtStato.ObjValue.ToString(), "20", false) == 0)
				{
					btnIncassato.Visible = true;
				}
				else
				{
					btnIncassato.Visible = false;
				}
				if (Operators.CompareString(txtIdFatturaAttiva.ObjValue.ToString(), "", false) != 0)
				{
					((Control)tlbgrdRicaviDiv).Visible = false;
				}
				if (Operators.CompareString(txtIdFatturaPassiva.ObjValue.ToString(), "", false) != 0)
				{
					((Control)tlbgrdCostiDiv).Visible = false;
				}
				if ((Operators.CompareString(txtStato.ObjValue.ToString(), "40", false) == 0) | (Operators.CompareString(txtStato.ObjValue.ToString(), "99", false) == 0))
				{
					txtNoteEsito.ReadOnly = true;
					txtNoteIncasso.ReadOnly = true;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
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
				DBConnection dbConn = base.DbConn;
				decimal num = Conversions.ToDecimal(txtContrassegno.ObjValue);
				string text2 = "UPDATE Spedizioni SET Contrassegno=" + dbConn.SQLFormatNumber(ref num) + " ";
				text2 = text2 + "WHERE UnibolMaster=" + base.DbConn.SQLFormatString(UnibolMAster.ObjValue.ToString());
				val2 = base.DbConn.SqlExec(text2, ref rsMess);
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

	private void btnCalcola_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string Warning = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = ContrassegniAgganciaTariffa_Invoker.Instance.RunProc(CreateApiContext(), IdContrassegno.ObjValue.ToString(), TariffaAttiva: true, Operators.CompareString(Trasportatore.ObjValue.ToString(), "", false) != 0, ref Warning, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string rsMess2 = "";
			Reload(ref rsMess2);
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdRicavi).ID];
			rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			IboInternalGridConfig objInternalGridConfig2 = GridConfigList[((Control)grdCosti).ID];
			rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsMess2);
			getParentUpdatePanel((Control)(object)grdRicavi).Update();
			getParentUpdatePanel((Control)(object)grdCosti).Update();
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
			else if (Operators.CompareString(Warning, "", false) != 0)
			{
				WriteErrorMessage(Warning);
			}
		}
	}

	private void btnIncassato_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			CallStackAdd();
			Contrassegno_Incasso_Invoker instance = Contrassegno_Incasso_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			int idContrassegno = Conversions.ToInteger(IdContrassegno.ObjValue);
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, idContrassegno, null, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			RetQueryToApply = "";
			Reload(ref RetQueryToApply);
			base.MasterPage.ContentUpdatePanel.Update();
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

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdRicavi).ID, false) == 0) | (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdCosti).ID, false) == 0))
			{
				obj = IdContrassegno.ObjValue.ToString();
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIDContrassegno", "Text", ref obj);
			}
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
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(IdContrassegno.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIDContrassegno", "Text", ref PropertyValue);
			if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckInserimentoCostiRicavi(IdContrassegno.ObjValue.ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c7;
				}
				val = val2;
			}
			else
			{
				if (!((object)tlb).Equals((object?)tlbgrdRicavi))
				{
					goto IL_00c7;
				}
				val2 = CheckInserimentoCostiRicavi(IdContrassegno.ObjValue.ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c7;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00c7:
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(IdContrassegno.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIDContrassegno", "Text", ref PropertyValue);
			if (funcArg.Data.Count != 1)
			{
				rsMess = TranslateMessage("XXX", "Selezionare un record da modificare");
			}
			else if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0113;
				}
				val = val2;
			}
			else
			{
				if (!((object)tlb).Equals((object?)tlbgrdRicavi))
				{
					goto IL_0113;
				}
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0113;
				}
				val = val2;
			}
			goto end_IL_0007;
			IL_0113:
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: false, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			end_IL_0007:;
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

	protected override FXRETURN _InternalGridCancellaAction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdCosti).ID, false) == 0)
			{
				val2 = CheckCancellazioneCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0105;
				}
				val = val2;
			}
			else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdRicavi).ID, false) == 0)
			{
				val2 = CheckCancellazioneCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0105;
				}
				val = val2;
			}
			else if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Cancella(ref funcArg, ref rsMess) <= 0)
			{
				goto IL_0105;
			}
			goto end_IL_0005;
			IL_0105:
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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

	private FXRETURN DecodificaDestinario(string vsCodice, ref string rsRagioneSociale, ref string rsIndirizzo, ref string rsLocalita, ref string rsCap, ref string rsNazione, ref string rsProvincia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		object obj = null;
		DataTable dataTable2 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsRagioneSociale = "";
			rsIndirizzo = "";
			rsCap = "";
			rsNazione = "";
			rsLocalita = "";
			rsProvincia = "";
			text2 = "SELECT RAGIONESOCIALE,INDIRIZZO,CAP,PROVINCIA,NAZIONE,LOCALITA FROM PCS WHERE CODICE = " + base.DbConn.SQLFormatString(vsCodice);
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = (((int)val2 != 14) ? val2 : ((FXRETURN)0));
			}
			else
			{
				if (dataTable.Rows.Count == 1)
				{
					rsRagioneSociale = dataTable.Rows[0]["RAGIONESOCIALE"].ToString();
					rsIndirizzo = dataTable.Rows[0]["INDIRIZZO"].ToString();
					rsCap = dataTable.Rows[0]["CAP"].ToString();
					rsNazione = dataTable.Rows[0]["NAZIONE"].ToString();
					rsLocalita = dataTable.Rows[0]["LOCALITA"].ToString();
					rsProvincia = dataTable.Rows[0]["PROVINCIA"].ToString();
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

	protected FXRETURN CheckModificaCostiRicavi(string Id, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT C.IDFATTURAPASSIVA,CC.TIPOCALCOLO FROM CONTRASSEGNI_COSTI CC INNER JOIN CONTRASSEGNI C ON C.ID = CC.IDCONTRASSEGNO ";
				text = text + "WHERE CC.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile modificare il costo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_024f;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_024f;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO FROM CONTRASSEGNI_RICAVI CR INNER JOIN CONTRASSEGNI C ON C.ID = CR.IDCONTRASSEGNO ";
				text = text + "WHERE CR.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile modificare il ricavo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_024f;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il ricavo");
				}
			}
			goto end_IL_000e;
			IL_024f:
			val = (FXRETURN)0;
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

	protected FXRETURN CheckCancellazioneCostiRicavi(string Id, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Invalid comparison between Unknown and I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Invalid comparison between Unknown and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		string text2 = "";
		string text3 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT C.IDFATTURAPASSIVA,CC.TIPOCALCOLO,CC.IDRAGGRUPPAMENTO FROM CONTRASSEGNI_COSTI CC INNER JOIN CONTRASSEGNI C ON C.ID = CC.IDCONTRASSEGNO ";
				text = text + "WHERE CC.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable.Rows.Count != 1)
				{
					rsMess = TranslateMessage("XXX", "Impossibile recuperare il record da eliminare.");
				}
				else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
				{
					if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) == 0)
					{
						text2 = "DELETE FROM CONTRASSEGNI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0428;
					}
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile cancellare il costo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM FROM CONTRASSEGNI_COSTI CC INNER JOIN CONTRASSEGNI C ON C.ID = CC.IDCONTRASSEGNO WHERE CC.IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
					text += "AND CC.IDFATTURAPASSIVA IS NOT NULL";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							text2 = "DELETE FROM CONTRASSEGNI_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
							goto IL_0428;
						}
						rsMess = TranslateMessage("XXX", "Impossibile cancellare il costo, presente costo già fatturato nel raggruppamento {0}", text3);
					}
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_0428;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM CONTRASSEGNI_RICAVI CR INNER JOIN CONTRASSEGNI C ON C.ID = CR.IDCONTRASSEGNO ";
				text = text + "WHERE CR.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
				{
					if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) == 0)
					{
						text2 = "DELETE FROM CONTRASSEGNI_RICAVI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0428;
					}
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile cancellare il ricavo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM CONTRASSEGNI_RICAVI CR ";
					text += "INNER JOIN CONTRASSEGNI C ON C.ID = CR.IDCONTRASSEGNO ";
					text = text + "WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
					text += "AND IDFATTURAATTIVA IS NOT NULL";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							text2 = "DELETE FROM CONTRASSEGNI_RICAVI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
							goto IL_0428;
						}
						rsMess = TranslateMessage("XXX", "Impossibile cancellare il ricavo, presente contrassegno già fatturato nel raggruppamento {0}", text3);
					}
				}
			}
			goto end_IL_001f;
			IL_045d:
			val = (FXRETURN)0;
			goto end_IL_001f;
			IL_0428:
			if (Operators.CompareString(text2, "", false) == 0)
			{
				goto IL_045d;
			}
			val2 = base.DbConn.SqlExec(text2, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_045d;
			}
			val = val2;
			end_IL_001f:;
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

	protected FXRETURN CheckInserimentoCostiRicavi(string Id, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object obj = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT IDFATTURAPASSIVA FROM CONTRASSEGNI WHERE ID = " + base.DbConn.SQLFormatString(Id);
				val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0)
					{
						goto IL_012c;
					}
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile inserire il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_012c;
				}
				text = "SELECT IDFATTURAATTIVA FROM CONTRASSEGNI WHERE ID = " + base.DbConn.SQLFormatString(Id);
				val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0)
					{
						goto IL_012c;
					}
					rsMess = TranslateMessage("XXX", "Il contrassegno è fatturato, non è possibile inserire il ricavo");
				}
			}
			goto end_IL_000e;
			IL_012c:
			val = (FXRETURN)0;
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
}
