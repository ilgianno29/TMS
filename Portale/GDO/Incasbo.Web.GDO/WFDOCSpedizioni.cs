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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioni : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbCliente")]
	private IboWebComboTlk _cmbCliente;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSPArtenza")]
	private IboWebComboTlk _cmbPCSPArtenza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSDestinazione")]
	private IboWebComboTlk _cmbPCSDestinazione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoSpedizione")]
	private IboWebComboTlk _cmbTipoSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbCorrispondente")]
	private IboWebComboTlk _cmbCorrispondente;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcola")]
	private IboWebButton _btnCalcola;

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

	[field: AccessedThroughProperty("HFCountOfSubSpedizioni")]
	protected virtual IboWebHidden HFCountOfSubSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFSpedizioneMadre")]
	protected virtual IboWebHidden HFSpedizioneMadre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProgressivoConsegna")]
	protected virtual IboWebLabel lblProgressivoConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressivoConsegna")]
	protected virtual IboWebNumericTlk ProgressivoConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPreBolla")]
	protected virtual IboWebLabel lblPreBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optPreBolla")]
	protected virtual IboWebRadioButtonList optPreBolla
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

	[field: AccessedThroughProperty("cmbStato")]
	protected virtual IboDropDownList cmbStato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataSpedizione")]
	protected virtual IboWebLabel lblDataSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataSpedizione")]
	protected virtual IboWebDate2 txtDataSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBolla")]
	protected virtual IboWebLabel lblNumeroBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroBolla")]
	protected virtual IboWebTextBox txtNumeroBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataBolla")]
	protected virtual IboWebLabel lblDataBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataBolla")]
	protected virtual IboWebDate2 txtDataBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoServizio")]
	protected virtual IboWebLabel lblTipoServizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoServizio")]
	protected virtual IboDropDownList cmbTipoServizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineCliente")]
	protected virtual IboWebLabel lblNumeroOrdineCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroOrdineCliente")]
	protected virtual IboWebTextBox txtNumeroOrdineCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdine")]
	protected virtual IboWebLabel lblNumeroOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroOrdine")]
	protected virtual IboWebTextBox txtNumeroOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdine")]
	protected virtual IboWebLabel lblDataOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataOrdine")]
	protected virtual IboWebDate2 txtDataOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatoWMS")]
	protected virtual IboWebLabel lblStatoWMS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbStatoWMS")]
	protected virtual IboDropDownList cmbStatoWMS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdineCliente")]
	protected virtual IboWebLabel lblDataOrdineCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataOrdineCliente")]
	protected virtual IboWebDate2 txtDataOrdineCliente
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

	protected virtual IboWebComboTlk cmbCliente
	{
		[CompilerGenerated]
		get
		{
			return _cmbCliente;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbCliente_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbCliente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbCliente = value;
			val2 = _cmbCliente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblClienteFatturazione")]
	protected virtual IboWebLabel lblClienteFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbClienteFatturazione")]
	protected virtual IboWebComboTlk cmbClienteFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMittente")]
	protected virtual IboWebLabel lblMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMittente")]
	protected virtual IboWebComboTlk cmbMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMittenteRagioneSociale")]
	protected virtual IboWebTextBox txtMittenteRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPartenzaDellaMerceTitle")]
	protected virtual Panel pnlPartenzaDellaMerceTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaDellaMerce")]
	protected virtual IboWebLabel lblPartenzaDellaMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_PartenzaDellaMerce")]
	protected virtual UpdatePanel up_PartenzaDellaMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPartenzaDellaMerceBody")]
	protected virtual Panel pnlPartenzaDellaMerceBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPArtenza")]
	protected virtual IboWebLabel lblPCSPArtenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbPCSPArtenza
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSPArtenza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSPartenza_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSPArtenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSPArtenza = value;
			val2 = _cmbPCSPArtenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lbPCSPArtenzalIndirizzo")]
	protected virtual IboWebLabel lbPCSPArtenzalIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza_Indirizzo")]
	protected virtual IboWebTextBox txtPCSPartenza_Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza_Cap")]
	protected virtual IboWebTextBox txtPCSPartenza_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza_Localita")]
	protected virtual IboWebTextBox txtPCSPartenza_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza_Provincia")]
	protected virtual IboWebTextBox txtPCSPartenza_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza_Nazione")]
	protected virtual IboWebTextBox txtPCSPartenza_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista1")]
	protected virtual IboWebLabel lblDataRitiroPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRitiroPrevista1")]
	protected virtual IboWebDate2 txtDataRitiroPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista2")]
	protected virtual IboWebLabel lblDataRitiroPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRitiroPrevista2")]
	protected virtual IboWebDate2 txtDataRitiroPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRitiro")]
	protected virtual IboWebLabel lblNoteRitiro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteRitiroPrevisto")]
	protected virtual IboWebTextBox txtNoteRitiroPrevisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOraRitiroConcordata1")]
	protected virtual IboWebLabel lblOraRitiroConcordata1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOraRitiroConcordata1")]
	protected virtual IboWebDate2 txtOraRitiroConcordata1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOraRitiroConcordata2")]
	protected virtual IboWebLabel lblOraRitiroConcordata2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOraRitiroConcordata2")]
	protected virtual IboWebDate2 txtOraRitiroConcordata2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimentoRitiroConcordata")]
	protected virtual IboWebLabel lblRiferimentoRitiroConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimentoRitiroConcordata")]
	protected virtual IboWebTextBox txtRiferimentoRitiroConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRitiroConcordata")]
	protected virtual IboWebLabel lblNoteRitiroConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteRitiroConcordata")]
	protected virtual IboWebTextBox txtNoteRitiroConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSPartenza_RagSoc")]
	protected virtual IboWebTextBox PCSPartenza_RagSoc
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

	protected virtual IboWebComboTlk cmbPCSDestinazione
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSDestinazione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSDestinazione_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSDestinazione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSDestinazione = value;
			val2 = _cmbPCSDestinazione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lbPCSDestinazionelIndirizzo")]
	protected virtual IboWebLabel lbPCSDestinazionelIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazione_Indirizzo")]
	protected virtual IboWebTextBox txtPCSDestinazione_Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazione_Cap")]
	protected virtual IboWebTextBox txtPCSDestinazione_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazione_Localita")]
	protected virtual IboWebTextBox txtPCSDestinazione_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazione_Provincia")]
	protected virtual IboWebTextBox txtPCSDestinazione_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazione_Nazione")]
	protected virtual IboWebTextBox txtPCSDestinazione_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista1")]
	protected virtual IboWebLabel lblDataConsegnaPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataConsegnaPrevista1")]
	protected virtual IboWebDate2 txtDataConsegnaPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista2")]
	protected virtual IboWebLabel lblDataConsegnaPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataConsegnaPrevista2")]
	protected virtual IboWebDate2 txtDataConsegnaPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteConsegna")]
	protected virtual IboWebLabel lblNoteConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteConsegnaPrevista")]
	protected virtual IboWebTextBox txtNoteConsegnaPrevista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaConcordata")]
	protected virtual IboWebLabel lblDataConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataConsegnaConcordata")]
	protected virtual IboWebDate txtDataConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOraConsegnaConcordata1")]
	protected virtual IboWebLabel lblOraConsegnaConcordata1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOraConsegnaConcordata1")]
	protected virtual IboWebDate2 txtOraConsegnaConcordata1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOraConsegnaConcordata2")]
	protected virtual IboWebLabel lblOraConsegnaConcordata2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOraConsegnaConcordata2")]
	protected virtual IboWebDate2 txtOraConsegnaConcordata2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimentoConsegnaConcordata")]
	protected virtual IboWebLabel lblRiferimentoConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimentoConsegnaConcordata")]
	protected virtual IboWebTextBox txtRiferimentoConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteConsegnaConcordata")]
	protected virtual IboWebLabel lblNoteConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteConsegnaConcordata")]
	protected virtual IboWebTextBox txtNoteConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazione_RagSoc")]
	protected virtual IboWebTextBox PCSDestinazione_RagSoc
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

	[field: AccessedThroughProperty("lblTipoSpedizione")]
	protected virtual IboWebLabel lblTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbTipoSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTipoSpedizione_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTipoSpedizione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTipoSpedizione = value;
			val2 = _cmbTipoSpedizione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cmbTipoSpedizionePassivo")]
	protected virtual IboWebComboTlk cmbTipoSpedizionePassivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerce")]
	protected virtual IboWebLabel lblTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoMerce")]
	protected virtual IboWebComboTlk cmbTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaSpedizione")]
	protected virtual IboWebLabel lblZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaSpedizione")]
	protected virtual IboWebComboTlk cmbZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaPartenzaTariffaAttiva")]
	protected virtual IboWebLabel lblZonaPartenzaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaPartenzaTariffaAttiva")]
	protected virtual IboWebComboTlk cmbZonaPartenzaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivoTariffaAttiva")]
	protected virtual IboWebComboTlk cmbZonaArrivoTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaArrivoTariffaAttiva")]
	protected virtual IboWebLabel lblZonaArrivoTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaPartenzaTariffaPassiva")]
	protected virtual IboWebComboTlk cmbZonaPartenzaTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivoTariffaPassiva")]
	protected virtual IboWebComboTlk cmbZonaArrivoTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCaratteristicheDellaMerceTitle")]
	protected virtual Panel pnlCaratteristicheDellaMerceTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCaratteristicheDellaMerce")]
	protected virtual IboWebLabel lblCaratteristicheDellaMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_CaratteristicheDellaMerce")]
	protected virtual UpdatePanel up_CaratteristicheDellaMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCaratteristicheDellaMerceBody")]
	protected virtual Panel pnlCaratteristicheDellaMerceBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPeso")]
	protected virtual IboWebLabel lblPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPeso")]
	protected virtual IboWebNumericTlk txtPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblColli")]
	protected virtual IboWebLabel lblColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtColli")]
	protected virtual IboWebNumericTlk txtColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPallet")]
	protected virtual IboWebLabel lblPallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPallet")]
	protected virtual IboWebNumericTlk txtPallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVolume")]
	protected virtual IboWebLabel lblVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtVolume")]
	protected virtual IboWebNumericTlk txtVolume
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

	[field: AccessedThroughProperty("lblCampoCalcolo1")]
	protected virtual IboWebLabel lblCampoCalcolo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo1")]
	protected virtual IboWebNumericTlk txtCampoCalcolo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo2")]
	protected virtual IboWebLabel lblCampoCalcolo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo2")]
	protected virtual IboWebNumericTlk txtCampoCalcolo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo3")]
	protected virtual IboWebLabel lblCampoCalcolo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo3")]
	protected virtual IboWebNumericTlk txtCampoCalcolo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo4")]
	protected virtual IboWebLabel lblCampoCalcolo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo4")]
	protected virtual IboWebNumericTlk txtCampoCalcolo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo5")]
	protected virtual IboWebLabel lblCampoCalcolo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo5")]
	protected virtual IboWebNumericTlk txtCampoCalcolo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo6")]
	protected virtual IboWebLabel lblCampoCalcolo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo6")]
	protected virtual IboWebNumericTlk txtCampoCalcolo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo7")]
	protected virtual IboWebLabel lblCampoCalcolo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo7")]
	protected virtual IboWebNumericTlk txtCampoCalcolo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo8")]
	protected virtual IboWebLabel lblCampoCalcolo8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo8")]
	protected virtual IboWebNumericTlk txtCampoCalcolo8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo9")]
	protected virtual IboWebLabel lblCampoCalcolo9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo9")]
	protected virtual IboWebNumericTlk txtCampoCalcolo9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo10")]
	protected virtual IboWebLabel lblCampoCalcolo10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo10")]
	protected virtual IboWebNumericTlk txtCampoCalcolo10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTassatoAttivo")]
	protected virtual IboWebLabel lblTassatoAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTassatoAttivo")]
	protected virtual IboWebNumericTlk txtTassatoAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTassatoPassivo")]
	protected virtual IboWebLabel lblTassatoPassivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTassatoPassivo")]
	protected virtual IboWebNumericTlk txtTassatoPassivo
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

	protected virtual IboWebComboTlk cmbCorrispondente
	{
		[CompilerGenerated]
		get
		{
			return _cmbCorrispondente;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbCorrispondente_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbCorrispondente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbCorrispondente = value;
			val2 = _cmbCorrispondente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblTrasportatore")]
	protected virtual IboWebLabel lblTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTrasportatore")]
	protected virtual IboWebComboTlk cmbTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtVettore")]
	protected virtual IboWebHidden txtVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdViaggio")]
	protected virtual IboWebLabel lblIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdViaggio")]
	protected virtual IboWebTextBox txtIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVettore")]
	protected virtual IboWebLabel lblVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Vettore")]
	protected virtual IboWebTextBox Vettore
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

	[field: AccessedThroughProperty("lblDataCompetenzaAttiva")]
	protected virtual IboWebLabel lblDataCompetenzaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataCompetenzaAttiva")]
	protected virtual IboWebTextBox txtDataCompetenzaAttiva
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

	[field: AccessedThroughProperty("lblIdRaggruppamentoAttivo")]
	protected virtual IboWebLabel lblIdRaggruppamentoAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdRaggruppamentoAttivo")]
	protected virtual IboWebTextBox txtIdRaggruppamentoAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavoViaggioRipartito")]
	protected virtual IboWebLabel lblRicavoViaggioRipartito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebNumericTlk1")]
	protected virtual IboWebNumericTlk IboWebNumericTlk1
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

	[field: AccessedThroughProperty("lblDataCompetenzaPassiva")]
	protected virtual IboWebLabel lblDataCompetenzaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataCompetenzaPassiva")]
	protected virtual IboWebTextBox txtDataCompetenzaPassiva
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

	[field: AccessedThroughProperty("lblIdRaggruppamentoPassivo")]
	protected virtual IboWebLabel lblIdRaggruppamentoPassivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdRaggruppamentoPassivo")]
	protected virtual IboWebTextBox txtIdRaggruppamentoPassivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCostoViaggioRipartito")]
	protected virtual IboWebLabel lblCostoViaggioRipartito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCostoViaggioRipartito")]
	protected virtual IboWebNumericTlk txtCostoViaggioRipartito
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

	[field: AccessedThroughProperty("TpEventi")]
	protected virtual TabPanel TpEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpEventiCaption")]
	protected virtual IboWebLabel TpEventiCaption
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

	[field: AccessedThroughProperty("pnlEventi")]
	protected virtual Panel pnlEventi
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

	[field: AccessedThroughProperty("TpUds")]
	protected virtual TabPanel TpUds
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpUdsCaption")]
	protected virtual IboWebLabel TpUdsCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUds_Title")]
	protected virtual Panel cpUds_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUds_Title_Caption")]
	protected virtual IboWebLabel cpUds_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpUds_Body")]
	protected virtual Panel cpUds_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpUds_Body")]
	protected virtual UpdatePanel up_cpUds_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdUds")]
	protected virtual IboWebToolbar tlbgrdUds
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlUds")]
	protected virtual Panel pnlUds
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdUds")]
	protected virtual IboGridView grdUds
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpDoc")]
	protected virtual TabPanel TpDoc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TpDocCaption")]
	protected virtual IboWebLabel TpDocCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDoc_Title")]
	protected virtual Panel cpDoc_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDoc_Title_Caption")]
	protected virtual IboWebLabel cpDoc_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDoc_Body")]
	protected virtual Panel cpDoc_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpDoc_Body")]
	protected virtual UpdatePanel up_cpDoc_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdDoc")]
	protected virtual IboWebToolbar tlbgrdDoc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDoc")]
	protected virtual Panel pnlDoc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdDoc")]
	protected virtual IboGridView grdDoc
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

	[field: AccessedThroughProperty("lblDataEsportazioneCorrispondente")]
	protected virtual IboWebLabel lblDataEsportazioneCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEsportazioneCorrispondente")]
	protected virtual IboWebTextBox DataEsportazioneCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataEsportazioneVettore")]
	protected virtual IboWebLabel lblDataEsportazioneVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEsportazioneVettore")]
	protected virtual IboWebTextBox DataEsportazioneVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpSubSpedizioni")]
	protected virtual TabPanel tpSubSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpSubSpedizioniCaption")]
	protected virtual IboWebLabel tpSubSpedizioniCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSubSpedizioni_Title")]
	protected virtual Panel cpSubSpedizioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSubSpedizioni_Title_Caption")]
	protected virtual IboWebLabel cpSubSpedizioni_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_SubSpedizioni")]
	protected virtual UpdatePanel up_SubSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdSubSpedizioni")]
	protected virtual IboWebToolbar tlbgrdSubSpedizioni
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

	[field: AccessedThroughProperty("grdSubSpedizioni")]
	protected virtual IboGridView grdSubSpedizioni
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

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.SPEDIZIONI";
		_Title = base.Translator.Translate("XXX", "Documento di Spedizione", new string[0]);
		if (!((Page)this).IsPostBack)
		{
			lblCampoCalcolo1.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO1", lblCampoCalcolo1.ObjValue.ToString());
			lblCampoCalcolo2.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO2", lblCampoCalcolo2.ObjValue.ToString());
			lblCampoCalcolo3.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO3", lblCampoCalcolo3.ObjValue.ToString());
			lblCampoCalcolo4.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO4", lblCampoCalcolo4.ObjValue.ToString());
			lblCampoCalcolo5.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO5", lblCampoCalcolo5.ObjValue.ToString());
			lblCampoCalcolo6.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO6", lblCampoCalcolo6.ObjValue.ToString());
			lblCampoCalcolo7.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO7", lblCampoCalcolo7.ObjValue.ToString());
			lblCampoCalcolo8.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO8", lblCampoCalcolo8.ObjValue.ToString());
			lblCampoCalcolo9.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO9", lblCampoCalcolo9.ObjValue.ToString());
			lblCampoCalcolo10.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("CAMPOCALCOLO10", lblCampoCalcolo10.ObjValue.ToString());
			lblFillerAlfa1.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA1", lblFillerAlfa1.ObjValue.ToString());
			lblFillerAlfa2.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA2", lblFillerAlfa2.ObjValue.ToString());
			lblFillerAlfa3.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA3", lblFillerAlfa3.ObjValue.ToString());
			lblFillerAlfa4.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA4", lblFillerAlfa4.ObjValue.ToString());
			lblFillerAlfa5.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA5", lblFillerAlfa5.ObjValue.ToString());
			lblFillerAlfa6.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA6", lblFillerAlfa6.ObjValue.ToString());
			lblFillerAlfa7.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA7", lblFillerAlfa7.ObjValue.ToString());
			lblFillerAlfa8.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA8", lblFillerAlfa8.ObjValue.ToString());
			lblFillerAlfa9.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA9", lblFillerAlfa9.ObjValue.ToString());
			lblFillerAlfa10.ObjValue = base.SessionEnvironment.ApplicationParams.Spedizioni_GetFieldText("FILLERALFA10", lblFillerAlfa10.ObjValue.ToString());
			((Control)TpRicavi).Visible = !base.SessionEnvironment.ApplicationParams.ACTMode();
		}
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
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
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
				iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI.RICAVI", "SELECT * FROM GRD_SPEDIZIONI_RICAVI WHERE UNIBOL='<%UNIBOL%>'", "", "", ((Control)grdRicavi).ID, ((Control)tlbgrdRicavi).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdCosti;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdCosti = objGridView;
				iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI.COSTI", "SELECT * FROM GRD_SPEDIZIONI_COSTI WHERE UNIBOL='<%UNIBOL%>'", "", "", ((Control)grdCosti).ID, ((Control)tlbgrdCosti).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
				StateBag myViewState3 = base.MyViewState;
				objGridView = grdEventi;
				iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
				grdEventi = objGridView;
				iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI.EVENTI", "SELECT * FROM GRD_DOC_SPEDIZIONI_EVENTI WHERE UNIBOL='<%UNIBOL%>'", "", "", ((Control)grdEventi).ID, "");
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
				StateBag myViewState4 = base.MyViewState;
				objGridView = grdUds;
				iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
				grdUds = objGridView;
				iboInternalGridConfig.Build("DM.DOC.SPEDIZIONIUDS", "SELECT * FROM GRD_DOC_SPEDIZIONIUDS WHERE UNIBOL='<%UNIBOL%>'", "", "", ((Control)grdUds).ID, ((Control)tlbgrdUds).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
				StateBag myViewState5 = base.MyViewState;
				objGridView = grdSubSpedizioni;
				iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
				grdSubSpedizioni = objGridView;
				iboInternalGridConfig.Build("DM.DOC.SUBSPEDIZIONI", "SELECT S.*, SS.Sequenza SS_Sequenza FROM GRD_DOC_SPEDIZIONI S INNER JOIN Spedizioni_SubSpedizioni SS ON SS.Unibol_SubSpedizione=S.UNIBOL WHERE SS.Unibol_Spedizione='<%UNIBOL%>'", "SS_Sequenza", "ASC", ((Control)grdSubSpedizioni).ID, ((Control)tlbgrdSubSpedizioni).ID);
				iboInternalGridConfig.Attivo = false;
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig7 = iboInternalGridConfig;
				StateBag myViewState6 = base.MyViewState;
				objGridView = grdDoc;
				iboInternalGridConfig7.InitUi(myViewState6, ref objGridView);
				grdDoc = objGridView;
				iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI.DOCUMENTI", "SELECT * FROM GRD_Spedizioni_Documenti WHERE UNIBOL='<%UNIBOL%>'", "", "", ((Control)grdDoc).ID, ((Control)tlbgrdDoc).ID);
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
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			txtMittenteRagioneSociale.ObjValue = Strings.Left(cmbMittente.Text, 60);
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
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)))
			{
				goto IL_012b;
			}
			string text = "SELECT (SELECT COUNT(*) FROM Spedizioni_SubSpedizioni WHERE Unibol_Spedizione=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString()) + ") CountOfSubSpedizioni, ";
			text = text + "(SELECT Unibol_Spedizione FROM Spedizioni_SubSpedizioni WHERE Unibol_SubSpedizione=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString()) + ") Unibol_SpedizioneMadre ";
			text += base.DbConn.FromDual();
			DataTable dataTable = null;
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				HFSpedizioneMadre.ObjValue = dataTable.Rows[0]["Unibol_SpedizioneMadre"].ToString();
				HFCountOfSubSpedizioni.ObjValue = dataTable.Rows[0]["CountOfSubSpedizioni"].ToString();
				goto IL_012b;
			}
			val2 = val;
			goto end_IL_0005;
			IL_012b:
			if (Operators.CompareString(objFunctionArguments.Name, "MODIFICA", false) == 0)
			{
				if ((Operators.CompareString(txtIdFatturaAttiva.ObjValue.ToString(), "", false) != 0) | (Operators.CompareString(txtIdFatturaPassiva.ObjValue.ToString(), "", false) != 0))
				{
					objFunctionArguments.Name = "VISUALIZZAZIONE";
					WriteInfoMessage(TranslateMessage("XXX", "La spedizione risulta fatturata e quindi non è più possibile apportare delle modifiche. La spedizione è stata aperta in sola visualizzazione"), ShowAsNotification: true);
				}
				else if (Operators.CompareString(HFSpedizioneMadre.ObjValue.ToString(), "", false) == 0)
				{
				}
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
			end_IL_0005:;
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
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Invalid comparison between Unknown and I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
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
				if (Conversions.ToInteger(cmbStato.ObjValue) > 40)
				{
					txtContrassegno.ReadOnly = true;
				}
				else if ((Conversions.ToInteger(cmbStato.ObjValue) == 40) & (Conversions.ToInteger(txtContrassegno.ObjValue) > 0))
				{
					txtContrassegno.ReadOnly = true;
				}
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					if ((Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) != 0) & !((Page)this).IsPostBack)
					{
						string text2 = cmbTipoSpedizione.ObjValue.ToString();
						string text3 = cmbTipoMerce.ObjValue.ToString();
						if (Operators.CompareString(text2, "", false) != 0)
						{
							text = "CODICE IN (SELECT TipoSpedizione FROM clientitipispedizione WHERE CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")";
							cmbTipoSpedizione.SqlQueryFilter = text;
							text = "CODICE IN (SELECT TIPOMERCE FROM ClientiTipiSpedizioneTipiMerce WHERE TIPOSPEDIZIONE = " + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + " ";
							text = text + "AND CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")";
							cmbTipoMerce.SqlQueryFilter = text;
						}
					}
					if (Conversions.ToInteger(cmbStato.ObjValue) > 20)
					{
						txtDataSpedizione.ReadOnly = true;
					}
				}
				((Control)tpSubSpedizioni).Visible = false;
				if (!((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)))
				{
					goto IL_0396;
				}
				if (Operators.CompareString(HFCountOfSubSpedizioni.ObjValue.ToString(), "", false) != 0 && Conversions.ToInteger(HFCountOfSubSpedizioni.ObjValue) > 0)
				{
					((Control)tpSubSpedizioni).Visible = true;
				}
				if (((Control)tpSubSpedizioni).Visible)
				{
					goto IL_031b;
				}
				string text4 = "SELECT SubSpedizioni_TipiServizio FROM TipiServizi WHERE CODICE=" + base.DbConn.SQLFormatString(cmbTipoServizio.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text4, (object)"", ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(obj.ToString(), "", false) != 0)
					{
						((Control)tpSubSpedizioni).Visible = true;
					}
					goto IL_031b;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_031b:
			if (!((Control)tpSubSpedizioni).Visible)
			{
				goto IL_0396;
			}
			IboInternalGridConfig ObjInternalGridConfig = GridConfigList[((Control)grdSubSpedizioni).ID];
			ObjInternalGridConfig.Attivo = true;
			if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
			{
				if (Conversions.ToInteger(cmbStato.ObjValue) > 20)
				{
					tlbgrdSubSpedizioni.Enabled = false;
				}
				goto IL_0396;
			}
			val = val2;
			goto end_IL_000b;
			IL_0396:
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0)
			{
				string text = "SELECT UNIBOL FROM SPEDIZIONI WHERE 1=1 " + _objFunctionArguments.Data.GetAllElementSqlWhere();
				DataTable dataTable = null;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 <= 0)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						val2 = Spedizione_Annulla_Invoker.Instance.RunProc(CreateApiContext(), row["Unibol"].ToString(), TranslateMessage("XXX", "ANNULLAMENTO MANUALE DALLE SPEDIZIONI TEMPORANEE"), ref rsMess);
						if ((int)val2 <= 0)
						{
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					goto IL_011a;
				}
				val = val2;
			}
			else
			{
				val2 = base.SaveData(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_011a;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_011a:
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

	protected override FXRETURN BeforeLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Duplicazione delle spedizioni non consentita");
				}
				else
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Invalid comparison between Unknown and I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (!((Conversions.ToInteger(cmbStato.ObjValue) == 40) & (decimal.Compare(Conversions.ToDecimal(txtContrassegno.ObjValue), 0m) > 0) & (decimal.Compare(Conversions.ToDecimal(this.BeforeImage["Contrassegno"].FieldValue), 0m) == 0)))
				{
					goto IL_00ef;
				}
				Contrassegno_Crea_Invoker instance = Contrassegno_Crea_Invoker.Instance;
				AppApiContext objApiContext = CreateApiContext();
				string? unibol = txtUnibol.ObjValue.ToString();
				int? IdContrassegno = null;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, unibol, null, "", "", "", ApplyQuery: true, ref IdContrassegno, ref RetQueryToApply, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00ef;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_05cf:
			val = (FXRETURN)0;
			goto end_IL_0005;
			IL_00ef:
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0 || Operators.CompareString(HFCountOfSubSpedizioni.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(HFCountOfSubSpedizioni.ObjValue) <= 0)
			{
				goto IL_05cf;
			}
			string text = "UPDATE Spedizioni SET ";
			text = text + "NumeroBolla=" + base.DbConn.SQLFormatString(txtNumeroBolla.ObjValue.ToString()) + ", ";
			text = text + "DataBolla=" + base.DbConn.SQLFormatDate((eTipoData)1, txtDataBolla.getDateValue2) + ", ";
			text = text + "NumeroOrdine=" + base.DbConn.SQLFormatString(txtNumeroOrdine.ObjValue.ToString()) + ", ";
			text = text + "DataOrdine=" + base.DbConn.SQLFormatDate((eTipoData)1, txtDataOrdine.getDateValue2) + ", ";
			text = text + "NumeroOrdineCliente=" + base.DbConn.SQLFormatString(txtNumeroOrdineCliente.ObjValue.ToString()) + ", ";
			text = text + "DataOrdineCliente=" + base.DbConn.SQLFormatDate((eTipoData)1, txtDataOrdineCliente.getDateValue2) + ", ";
			string text2 = text;
			DBConnection dbConn = base.DbConn;
			decimal num = Conversions.ToDecimal(txtPeso.ObjValue);
			text = text2 + "Peso=" + dbConn.SQLFormatNumber(ref num) + ", ";
			string text3 = text;
			DBConnection dbConn2 = base.DbConn;
			num = Conversions.ToDecimal(txtColli.ObjValue);
			text = text3 + "Colli=" + dbConn2.SQLFormatNumber(ref num) + ", ";
			string text4 = text;
			DBConnection dbConn3 = base.DbConn;
			num = Conversions.ToDecimal(txtPallet.ObjValue);
			text = text4 + "Pallet=" + dbConn3.SQLFormatNumber(ref num) + ", ";
			string text5 = text;
			DBConnection dbConn4 = base.DbConn;
			num = Conversions.ToDecimal(txtVolume.ObjValue);
			text = text5 + "Volume=" + dbConn4.SQLFormatNumber(ref num) + ", ";
			string text6 = text;
			DBConnection dbConn5 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo1.ObjValue);
			text = text6 + "CampoCalcolo1=" + dbConn5.SQLFormatNumber(ref num) + ", ";
			string text7 = text;
			DBConnection dbConn6 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo2.ObjValue);
			text = text7 + "CampoCalcolo2=" + dbConn6.SQLFormatNumber(ref num) + ", ";
			string text8 = text;
			DBConnection dbConn7 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo3.ObjValue);
			text = text8 + "CampoCalcolo3=" + dbConn7.SQLFormatNumber(ref num) + ", ";
			string text9 = text;
			DBConnection dbConn8 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo4.ObjValue);
			text = text9 + "CampoCalcolo4=" + dbConn8.SQLFormatNumber(ref num) + ", ";
			string text10 = text;
			DBConnection dbConn9 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo5.ObjValue);
			text = text10 + "CampoCalcolo5=" + dbConn9.SQLFormatNumber(ref num) + ", ";
			string text11 = text;
			DBConnection dbConn10 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo6.ObjValue);
			text = text11 + "CampoCalcolo6=" + dbConn10.SQLFormatNumber(ref num) + ", ";
			string text12 = text;
			DBConnection dbConn11 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo7.ObjValue);
			text = text12 + "CampoCalcolo7=" + dbConn11.SQLFormatNumber(ref num) + ", ";
			string text13 = text;
			DBConnection dbConn12 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo8.ObjValue);
			text = text13 + "CampoCalcolo8=" + dbConn12.SQLFormatNumber(ref num) + ", ";
			string text14 = text;
			DBConnection dbConn13 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo9.ObjValue);
			text = text14 + "CampoCalcolo9=" + dbConn13.SQLFormatNumber(ref num) + ", ";
			string text15 = text;
			DBConnection dbConn14 = base.DbConn;
			num = Conversions.ToDecimal(txtCampoCalcolo10.ObjValue);
			text = text15 + "CampoCalcolo10=" + dbConn14.SQLFormatNumber(ref num) + ", ";
			text = text + "UteAgg=" + base.DbConn.SQLFormatString(base.WFIUser) + ", ";
			text = text + "DatAgg=" + base.DbConn.GetDate() + " ";
			text = text + "WHERE Unibol IN (SELECT Unibol_SubSpedizione FROM Spedizioni_SubSpedizioni WHERE Unibol_Spedizione=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString()) + ") ";
			text += "AND IdFatturaAttiva IS NULL ";
			text += "AND IdFatturaAttiva IS NULL";
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_05cf;
			}
			val = val2;
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

	private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			IboWebComboTlk objCombo = cmbTipoSpedizione;
			string rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			cmbTipoSpedizione.SqlQueryFilter = "codice in (Select TipoSpedizione FROM clientitipispedizione WHERE CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")";
			IboWebComboTlk objCombo2 = cmbTipoSpedizione;
			FXRETURN val3 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoSpedizione = objCombo2;
			val2 = val3;
			if ((int)val2 > 0)
			{
				return;
			}
			IboWebComboTlk objCombo3 = cmbTipoMerce;
			rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo3, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			cmbTipoMerce.SqlQueryFilter = "1=2";
			objCombo2 = cmbTipoMerce;
			FXRETURN val4 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoMerce = objCombo2;
			val2 = val4;
			if ((int)val2 > 0)
			{
				return;
			}
			getParentUpdatePanel((Control)(object)cmbTipoSpedizione).Update();
			getParentUpdatePanel((Control)(object)cmbTipoMerce).Update();
			object obj = null;
			string text = "SELECT FatturaA FROM Clienti WHERE Codice=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)) && Operators.CompareString(obj.ToString(), "", false) != 0)
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbClienteFatturazione, obj.ToString(), ref rsMess);
			}
			else
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbClienteFatturazione, "", ref rsMess);
			}
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

	private void cmbTipoSpedizione_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboWebComboTlk objCombo = cmbTipoMerce;
			string rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			text = "CODICE IN (SELECT TIPOMERCE FROM ClientiTipiSpedizioneTipiMerce WHERE TIPOSPEDIZIONE = " + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + " ";
			text = text + "AND CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")";
			cmbTipoMerce.SqlQueryFilter = text;
			IboWebComboTlk objCombo2 = cmbTipoMerce;
			FXRETURN val3 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoMerce = objCombo2;
			val = val3;
			if ((int)val2 > 0)
			{
				return;
			}
			if (((StateManagedCollection)((RadComboBox)cmbTipoMerce).Items).Count == 2)
			{
				IboWebComboTlk objCombo3 = cmbTipoMerce;
				string sItemValue = ((RadComboBox)cmbTipoMerce).Items[1].Value.ToString();
				rsMess2 = "";
				val = ComboSelectedItem((IIboDropdownList)(object)objCombo3, sItemValue, ref rsMess2);
				if ((int)val2 > 0)
				{
					return;
				}
			}
			getParentUpdatePanel((Control)(object)cmbTipoMerce).Update();
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

	protected void cmbPCSPartenza_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string? vsCodice = cmbPCSPArtenza.ObjValue.ToString();
			IboWebTextBox pCSPartenza_RagSoc;
			string rsRagioneSociale = (pCSPartenza_RagSoc = PCSPartenza_RagSoc).Text;
			IboWebTextBox val2;
			string rsIndirizzo = (val2 = txtPCSPartenza_Indirizzo).Text;
			IboWebTextBox val3;
			string rsLocalita = (val3 = txtPCSPartenza_Localita).Text;
			IboWebTextBox val4;
			string rsCap = (val4 = txtPCSPartenza_Cap).Text;
			IboWebTextBox val5;
			string rsNazione = (val5 = txtPCSPartenza_Nazione).Text;
			IboWebTextBox val6;
			string rsProvincia = (val6 = txtPCSPartenza_Provincia).Text;
			FXRETURN val7 = DecodificaDestinario(vsCodice, ref rsRagioneSociale, ref rsIndirizzo, ref rsLocalita, ref rsCap, ref rsNazione, ref rsProvincia, ref rsMess);
			val6.Text = rsProvincia;
			val5.Text = rsNazione;
			val4.Text = rsCap;
			val3.Text = rsLocalita;
			val2.Text = rsIndirizzo;
			pCSPartenza_RagSoc.Text = rsRagioneSociale;
			val = val7;
			if ((int)val > 0)
			{
				IboWebComboTlk objCombo = cmbPCSPArtenza;
				rsProvincia = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsProvincia);
			}
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

	protected void cmbPCSDestinazione_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string? vsCodice = cmbPCSDestinazione.ObjValue.ToString();
			IboWebTextBox pCSDestinazione_RagSoc;
			string rsRagioneSociale = (pCSDestinazione_RagSoc = PCSDestinazione_RagSoc).Text;
			IboWebTextBox val2;
			string rsIndirizzo = (val2 = txtPCSDestinazione_Indirizzo).Text;
			IboWebTextBox val3;
			string rsLocalita = (val3 = txtPCSDestinazione_Localita).Text;
			IboWebTextBox val4;
			string rsCap = (val4 = txtPCSDestinazione_Cap).Text;
			IboWebTextBox val5;
			string rsNazione = (val5 = txtPCSDestinazione_Nazione).Text;
			IboWebTextBox val6;
			string rsProvincia = (val6 = txtPCSDestinazione_Provincia).Text;
			FXRETURN val7 = DecodificaDestinario(vsCodice, ref rsRagioneSociale, ref rsIndirizzo, ref rsLocalita, ref rsCap, ref rsNazione, ref rsProvincia, ref rsMess);
			val6.Text = rsProvincia;
			val5.Text = rsNazione;
			val4.Text = rsCap;
			val3.Text = rsLocalita;
			val2.Text = rsIndirizzo;
			pCSDestinazione_RagSoc.Text = rsRagioneSociale;
			val = val7;
			if ((int)val > 0)
			{
				IboWebComboTlk objCombo = cmbPCSDestinazione;
				rsProvincia = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsProvincia);
			}
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

	private void btnCalcola_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = SpedizioniAgganciaTariffa_Invoker.Instance.RunProc(CreateApiContext(), txtUnibol.ObjValue.ToString(), Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) != 0, TariffaPassiva: true, Operators.CompareString(txtVettore.ObjValue.ToString(), "", false) != 0, ref Warning, ref rsMess);
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

	protected void cmbCorrispondente_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Operators.CompareString(cmbCorrispondente.ObjValue.ToString(), "", false) != 0)
			{
				string text = "SELECT CodiceTrasportatore FROM Corrispondenti WHERE Codice=" + base.DbConn.SQLFormatString(cmbCorrispondente.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)))
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbTrasportatore, obj.ToString(), ref rsMess);
				}
			}
			else
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbTrasportatore, "", ref rsMess);
			}
			getParentUpdatePanel((Control)(object)cmbTrasportatore).Update();
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
				obj = txtUnibol.ObjValue.ToString();
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtUnibol", "Text", ref obj);
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
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objInternalGridConfig.ToolbarId, ((Control)tlbgrdSubSpedizioni).ID, false) != 0)
			{
				object PropertyValue = RuntimeHelpers.GetObjectValue(txtUnibol.ObjValue);
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtUnibol", "Text", ref PropertyValue);
			}
			if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckInserimentoCostiRicavi(txtUnibol.ObjValue.ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0134;
				}
				val = val2;
			}
			else if (((object)tlb).Equals((object?)tlbgrdRicavi))
			{
				val2 = CheckInserimentoCostiRicavi(txtUnibol.ObjValue.ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0134;
				}
				val = val2;
			}
			else
			{
				if (!((object)tlb).Equals((object?)tlbgrdSubSpedizioni) || ((GridView)grdSubSpedizioni).Rows.Count <= 0)
				{
					goto IL_0134;
				}
				rsMess = TranslateMessage("XXX", "La spedizione possiede già delle sub-spedizioni");
			}
			goto end_IL_0005;
			IL_0134:
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
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objInternalGridConfig.ToolbarId, ((Control)tlbgrdSubSpedizioni).ID, false) == 0)
			{
				goto IL_0096;
			}
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtUnibol.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtUnibol", "Text", ref PropertyValue);
			if (funcArg.Data.Count == 1)
			{
				goto IL_0096;
			}
			rsMess = TranslateMessage("XXX", "Selezionare un record da modificare");
			goto end_IL_0007;
			IL_0181:
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: false, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			goto end_IL_0007;
			IL_0096:
			if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0181;
				}
				val = val2;
			}
			else if (((object)tlb).Equals((object?)tlbgrdRicavi))
			{
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0181;
				}
				val = val2;
			}
			else
			{
				if (!((object)tlb).Equals((object?)tlbgrdSubSpedizioni) || ((GridView)grdSubSpedizioni).Rows.Count != 0)
				{
					goto IL_0181;
				}
				rsMess = TranslateMessage("XXX", "La spedizione non ha sub-spedizioni");
			}
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

	protected override FXRETURN InternalGridAfterModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objInternalGridConfig.ToolbarId, ((Control)tlbgrdSubSpedizioni).ID, false) == 0)
			{
				string[] CampiChiave = new string[1] { "Unibol" };
				object[] ValoriCampiChiave = new object[1] { txtUnibol.ObjValue.ToString() };
				val2 = OpenDbPage(ref CampiChiave, ref ValoriCampiChiave, "DM.DOC.SPEDIZIONI#SUBSPED", "MODIFICA", "", "", "", "", "", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			else
			{
				val2 = base.InternalGridAfterModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00c0:
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

	protected override FXRETURN InternalGridAfterInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objInternalGridConfig.ToolbarId, ((Control)tlbgrdSubSpedizioni).ID, false) == 0)
			{
				string[] CampiChiave = new string[1] { "Unibol" };
				object[] ValoriCampiChiave = new object[1] { txtUnibol.ObjValue.ToString() };
				val2 = OpenDbPage(ref CampiChiave, ref ValoriCampiChiave, "DM.DOC.SPEDIZIONI#SUBSPED", "MODIFICA", "", "", "", "", "", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			else
			{
				val2 = base.InternalGridAfterInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c0;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00c0:
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objInternalGridConfig.ToolbarId, ((Control)tlbgrdSubSpedizioni).ID, false) == 0)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0 || Operators.CompareString(HFCountOfSubSpedizioni.ObjValue.ToString(), "", false) == 0)
				{
					goto IL_0196;
				}
				if (Conversions.ToInteger(HFCountOfSubSpedizioni.ObjValue) == 0)
				{
					rsMess = TranslateMessage("XXX", "La spedizione non contiente sub-spedizioni");
				}
				else
				{
					Spedizione_CancellaSubSpedizioni_Invoker instance = Spedizione_CancellaSubSpedizioni_Invoker.Instance;
					AppApiContext objApiContext = CreateApiContext();
					string Unibol = txtUnibol.ObjValue.ToString();
					val2 = instance.RunProc(objApiContext, ref Unibol, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if ((int)InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess) <= 0)
					{
						HFCountOfSubSpedizioni.ObjValue = "0";
						getParentUpdatePanel((Control)(object)grdSubSpedizioni).Update();
						getParentUpdatePanel((Control)(object)HFCountOfSubSpedizioni).Update();
						goto IL_0196;
					}
				}
			}
			else if (funcArg.Data.Count != 1)
			{
				rsMess = TranslateMessage("XXX", "Selezionare un record da eliminare");
			}
			else
			{
				val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0196;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0196:
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
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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
				if (Operators.CompareString(e.CommandName.ToUpper(), "RIGENERASUBSPEDIZIONI", false) != 0 || Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0 || Operators.CompareString(HFCountOfSubSpedizioni.ObjValue.ToString(), "", false) == 0)
				{
					goto IL_0184;
				}
				if (Conversions.ToInteger(HFCountOfSubSpedizioni.ObjValue) == 0)
				{
					rsMess = TranslateMessage("XXX", "La spedizione non contiente sub-spedizioni");
				}
				else
				{
					Spedizione_CancellaSubSpedizioni_Invoker instance = Spedizione_CancellaSubSpedizioni_Invoker.Instance;
					AppApiContext objApiContext = CreateApiContext();
					string Unibol = txtUnibol.ObjValue.ToString();
					val2 = instance.RunProc(objApiContext, ref Unibol, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						ImpostaStatoPagina(ref tlb);
						string[] CampiChiave = new string[1] { "Unibol" };
						object[] ValoriCampiChiave = new object[1] { txtUnibol.ObjValue.ToString() };
						val2 = OpenDbPage(ref CampiChiave, ref ValoriCampiChiave, "DM.DOC.SPEDIZIONI#SUBSPED", "MODIFICA", "", "", "", "", "", ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_0184;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0005;
			IL_0184:
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
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
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
				text = "SELECT IDFATTURAPASSIVA,TIPOCALCOLO FROM SPEDIZIONI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile modificare il costo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_023d;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_023d;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO FROM SPEDIZIONI_RICAVI SR INNER JOIN SPEDIZIONI S ON S.UNIBOL = SR.UNIBOL WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile modificare il ricavo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_023d;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il ricavo");
				}
			}
			goto end_IL_000e;
			IL_023d:
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
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Invalid comparison between Unknown and I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
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
				text = "SELECT IDFATTURAPASSIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM SPEDIZIONI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
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
						text2 = "DELETE FROM SPEDIZIONI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0416;
					}
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile cancellare il costo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM SPEDIZIONI_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
					text += "AND IDFATTURAPASSIVA IS NOT NULL";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							text2 = "DELETE FROM SPEDIZIONI_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
							goto IL_0416;
						}
						rsMess = TranslateMessage("XXX", "Impossibile cancellare il costo, presente costo già fatturato nel raggruppamento {0}", text3);
					}
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_0416;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM SPEDIZIONI_RICAVI SR INNER JOIN SPEDIZIONI S ON S.UNIBOL = SR.UNIBOL WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
				{
					if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) == 0)
					{
						text2 = "DELETE FROM SPEDIZIONI_RICAVI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0416;
					}
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile cancellare il ricavo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM SPEDIZIONI_RICAVI SR ";
					text += "INNER JOIN SPEDIZIONI S ON S.UNIBOL = SR.UNIBOL ";
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
							text2 = "DELETE FROM SPEDIZIONI_RICAVI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
							goto IL_0416;
						}
						rsMess = TranslateMessage("XXX", "Impossibile cancellare il ricavo, presente consegna già fatturata nel raggruppamento {0}", text3);
					}
				}
			}
			goto end_IL_001f;
			IL_044b:
			val = (FXRETURN)0;
			goto end_IL_001f;
			IL_0416:
			if (Operators.CompareString(text2, "", false) == 0)
			{
				goto IL_044b;
			}
			val2 = base.DbConn.SqlExec(text2, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_044b;
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

	protected FXRETURN CheckInserimentoCostiRicavi(string Unibol, string Tipologia, ref string rsMess)
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
				text = "SELECT IDFATTURAPASSIVA FROM SPEDIZIONI WHERE UNIBOL = " + base.DbConn.SQLFormatString(Unibol);
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
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile inserire il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_012c;
				}
				text = "SELECT IDFATTURAATTIVA FROM SPEDIZIONI WHERE UNIBOL = " + base.DbConn.SQLFormatString(Unibol);
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
					rsMess = TranslateMessage("XXX", "La spedizione è fatturata, non è possibile inserire il ricavo");
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
