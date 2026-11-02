using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCGiacenze : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVediUnibolMaster")]
	private IboWebButton _btnVediUnibolMaster;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVediUnibolApertura")]
	private IboWebButton _btnVediUnibolApertura;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVediUnibolChiusura")]
	private IboWebButton _btnVediUnibolChiusura;

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

	[field: AccessedThroughProperty("pnlTestataBody2")]
	protected virtual Panel pnlTestataBody2
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

	[field: AccessedThroughProperty("IdGiacenza")]
	protected virtual IboWebLabel IdGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("lblStato")]
	protected virtual IboWebLabel lblStato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optStato")]
	protected virtual IboWebRadioButtonList optStato
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

	protected virtual IboWebButton btnVediUnibolMaster
	{
		[CompilerGenerated]
		get
		{
			return _btnVediUnibolMaster;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVediUnibol_Click;
			IboWebButton val = _btnVediUnibolMaster;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVediUnibolMaster = value;
			val = _btnVediUnibolMaster;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
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

	protected virtual IboWebButton btnVediUnibolApertura
	{
		[CompilerGenerated]
		get
		{
			return _btnVediUnibolApertura;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVediUnibol_Click;
			IboWebButton val = _btnVediUnibolApertura;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVediUnibolApertura = value;
			val = _btnVediUnibolApertura;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
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

	protected virtual IboWebButton btnVediUnibolChiusura
	{
		[CompilerGenerated]
		get
		{
			return _btnVediUnibolChiusura;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVediUnibol_Click;
			IboWebButton val = _btnVediUnibolChiusura;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVediUnibolChiusura = value;
			val = _btnVediUnibolChiusura;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblGiorniGiacenza")]
	protected virtual IboWebLabel lblGiorniGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniGiacenza")]
	protected virtual IboWebNumericTlk txtGiorniGiacenza
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
	protected virtual IboWebLabel txtCliente
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
	protected virtual IboWebLabel txtClienteFatturazione
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

	[field: AccessedThroughProperty("PCSDEstinazione")]
	protected virtual IboWebLabel PCSDEstinazione
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

	[field: AccessedThroughProperty("lblCausaleChiusura")]
	protected virtual IboWebLabel lblCausaleChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCausaleChiusura")]
	protected virtual IboWebHidden txtCausaleChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CausaleChiusura")]
	protected virtual IboWebLabel CausaleChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteChiusura")]
	protected virtual IboWebLabel lblNoteChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteChiusura")]
	protected virtual IboWebTextBox txtNoteChiusura
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

	[field: AccessedThroughProperty("pnlRiferimentiTrasportoBody")]
	protected virtual Panel pnlRiferimentiTrasportoBody
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
	protected virtual IboWebLabel txtCorrispondente
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
	protected virtual IboWebLabel txtTrasportatore
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
	protected virtual IboWebLabel txtTrasportatoreFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TrasportatoreFatturazione")]
	protected virtual IboWebLabel TrasportatoreFatturazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpQuantita")]
	protected virtual TabPanel tpQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpQuantitaCaption")]
	protected virtual IboWebLabel tpQuantitaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQuantitaTitle")]
	protected virtual Panel pnlQuantitaTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantita")]
	protected virtual IboWebLabel lblQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Quantita")]
	protected virtual UpdatePanel up_Quantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQuantitaBody")]
	protected virtual Panel pnlQuantitaBody
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

	[field: AccessedThroughProperty("lblPesoSpedizione")]
	protected virtual IboWebLabel lblPesoSpedizione
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

	[field: AccessedThroughProperty("lblColliSpedizione")]
	protected virtual IboWebLabel lblColliSpedizione
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

	[field: AccessedThroughProperty("lblPalletSpedizione")]
	protected virtual IboWebLabel lblPalletSpedizione
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

	[field: AccessedThroughProperty("lblVolumeSpedizione")]
	protected virtual IboWebLabel lblVolumeSpedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo1Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo1Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo2Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo2Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo3Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo3Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo4Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo4Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo5Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo5Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo6Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo6Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo7Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo7Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo8Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo8Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo9Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo9Spedizione
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

	[field: AccessedThroughProperty("lblCampoCalcolo10Spedizione")]
	protected virtual IboWebLabel lblCampoCalcolo10Spedizione
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.GIACENZE";
		_Title = base.Translator.Translate("XXX", "Giacenza", new string[0]);
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
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
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
				iboInternalGridConfig.Build("DM.DOC.GIACENZE.RICAVI", "SELECT * FROM GRD_GIACENZE_RICAVI WHERE IDGIACENZA='<%ID%>'", "", "", ((Control)grdRicavi).ID, ((Control)tlbgrdRicavi).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdCosti;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdCosti = objGridView;
				iboInternalGridConfig.Build("DM.DOC.GIACENZE.COSTI", "SELECT * FROM GRD_GIACENZE_COSTI WHERE IDGIACENZA='<%ID%>'", "", "", ((Control)grdCosti).ID, ((Control)tlbgrdCosti).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
				StateBag myViewState3 = base.MyViewState;
				objGridView = grdDocumenti;
				iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
				grdDocumenti = objGridView;
				iboInternalGridConfig.Build("DM.DOC.GIACENZE.DOCUMENTI", "SELECT * FROM GRD_GIACENZE_DOCUMENTI WHERE IDGIACENZA='<%ID%>'", "", "", ((Control)grdDocumenti).ID, ((Control)tlbgrdDocumenti).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
				StateBag myViewState4 = base.MyViewState;
				objGridView = grdNotePratica;
				iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
				grdNotePratica = objGridView;
				iboInternalGridConfig.Build("DM.DOC.GIACENZE.NOTE", "SELECT * FROM GRD_GIACENZE_NOTE WHERE IDGIACENZA='<%ID%>'", "", "", ((Control)grdNotePratica).ID, ((Control)tlbgrdNotePratica).ID);
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0 && Operators.CompareString(optStato.ObjValue.ToString(), "10", false) != 0)
			{
				rsMess = TranslateMessage("XXX", "La giacenza è chiusa, non è possibile eliminarla");
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN SetControlsEnabledProperty(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.SetControlsEnabledProperty(pnlDetail, ref objFunctionArguments, ref rsMess);
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
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
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
				val2 = QuantitaSpedizione(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(txtIdFatturaAttiva.ObjValue.ToString(), "", false) != 0)
					{
						((Control)tlbgrdRicaviDiv).Visible = false;
					}
					if (Operators.CompareString(txtIdFatturaPassiva.ObjValue.ToString(), "", false) != 0)
					{
						((Control)tlbgrdCostiDiv).Visible = false;
					}
					if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
					{
						if ((Conversions.ToInteger(optStato.ObjValue) == 20) & ((Operators.CompareString(txtIdFatturaAttiva.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtIdFatturaPassiva.ObjValue.ToString(), "", false) == 0)))
						{
							txtNoteChiusura.ReadOnly = false;
							txtGiorniGiacenza.ReadOnly = false;
							btnCalcola.Visible = true;
							((WebControl)pnlQuantitaBody).Enabled = true;
						}
						else
						{
							txtNoteChiusura.ReadOnly = true;
							txtGiorniGiacenza.ReadOnly = true;
							btnCalcola.Visible = false;
							((WebControl)pnlQuantitaBody).Enabled = false;
						}
					}
					else if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
					{
						btnCalcola.Visible = false;
					}
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
			val2 = GiacenzeAgganciaTariffa_Invoker.Instance.RunProc(CreateApiContext(), IdGiacenza.ObjValue.ToString(), TariffaAttiva: true, Operators.CompareString(Trasportatore.ObjValue.ToString(), "", false) != 0, ref Warning, ref rsMess);
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
				WriteErrorMessage("", Warning, TranslateMessage("XXX", "Calcolo Tariffe di giacenza"), ShowAsNotification: true);
			}
		}
	}

	private void btnVediUnibol_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			string text = ((IIboWebComponent)sender).ObjValue.ToString();
			if (Operators.CompareString(text, "", false) != 0)
			{
				val2 = CheckSpedizione(text, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				string[] CampiChiave = new string[1] { "Unibol" };
				object[] ValoriCampiChiave = new object[1] { text };
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
				obj = IdGiacenza.ObjValue.ToString();
				SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIDGiacenza", "Text", ref obj);
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
			object PropertyValue = RuntimeHelpers.GetObjectValue(IdGiacenza.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIdGiacenza", "Text", ref PropertyValue);
			if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckInserimentoCostiRicavi(IdGiacenza.ObjValue.ToString(), "C", ref rsMess);
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
				val2 = CheckInserimentoCostiRicavi(IdGiacenza.ObjValue.ToString(), "R", ref rsMess);
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
			object PropertyValue = RuntimeHelpers.GetObjectValue(IdGiacenza.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "txtIdGiacenza", "Text", ref PropertyValue);
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

	private FXRETURN QuantitaSpedizione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataTable dataTable2 = null;
			text2 = "SELECT Peso, Colli, Pallet, Volume, CampoCalcolo1, CampoCalcolo2,CampoCalcolo3, CampoCalcolo4, CampoCalcolo5,  ";
			text2 += "CampoCalcolo6, CampoCalcolo7, CampoCalcolo8, CampoCalcolo9, CampoCalcolo10 FROM SPEDIZIONI ";
			text2 = text2 + "WHERE UNIBOL = " + base.DbConn.SQLFormatString(UnibolApertura.ObjValue.ToString());
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable2, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				lblPesoSpedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Peso"]);
				lblColliSpedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Colli"]);
				lblPalletSpedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Pallet"]);
				lblVolumeSpedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Volume"]);
				lblCampoCalcolo1Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo1"]);
				lblCampoCalcolo2Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo2"]);
				lblCampoCalcolo3Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo3"]);
				lblCampoCalcolo4Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo4"]);
				lblCampoCalcolo5Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo5"]);
				lblCampoCalcolo6Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo6"]);
				lblCampoCalcolo7Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo7"]);
				lblCampoCalcolo8Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo8"]);
				lblCampoCalcolo9Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo9"]);
				lblCampoCalcolo10Spedizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CampoCalcolo10"]);
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
				text = "SELECT G.IDFATTURAPASSIVA,GC.TIPOCALCOLO FROM Giacenze_Costi GC INNER JOIN Giacenze G ON G.ID = GC.IDGiacenza ";
				text = text + "WHERE GC.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile modificare il costo");
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
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO FROM Giacenze_RICAVI GR INNER JOIN Giacenze G ON G.ID = GR.IDGiacenza ";
				text = text + "WHERE GR.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile modificare il ricavo");
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
				text = "SELECT G.IDFATTURAPASSIVA,GC.TIPOCALCOLO,GC.IDRAGGRUPPAMENTO FROM Giacenze_COSTI GC INNER JOIN Giacenze G ON G.ID = GC.IDGIACENZA ";
				text = text + "WHERE GC.ID = " + base.DbConn.SQLFormatNumber(ref Id);
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
						text2 = "DELETE FROM GIACENZE_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0428;
					}
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile cancellare il costo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM FROM GIACENZE_COSTI GC INNER JOIN GIACENZE G ON G.ID = GC.IDGIACENZA WHERE GC.IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
					text += "AND GC.IDFATTURAPASSIVA IS NOT NULL";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							text2 = "DELETE FROM GIACENZE_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
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
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM GIACENZE_RICAVI GR INNER JOIN GIACENZE G ON G.ID = GR.IDGIACENZA ";
				text = text + "WHERE GR.ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
				{
					if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) == 0)
					{
						text2 = "DELETE FROM GIACENZE_RICAVI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0428;
					}
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile cancellare il ricavo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM GIACENZE_RICAVI GR ";
					text += "INNER JOIN GIACENZE G ON G.ID = GR.IDGIACENZA ";
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
							text2 = "DELETE FROM GIACENZE_RICAVI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
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
				text = "SELECT IDFATTURAPASSIVA FROM GIACENZE WHERE ID = " + base.DbConn.SQLFormatString(Id);
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
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile inserire il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_012c;
				}
				text = "SELECT IDFATTURAATTIVA FROM GIACENZE WHERE ID = " + base.DbConn.SQLFormatString(Id);
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
					rsMess = TranslateMessage("XXX", "La giacenza è fatturata, non è possibile inserire il ricavo");
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

	protected FXRETURN CheckSpedizione(string Unibol, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Unibol, "", false) == 0)
			{
				goto IL_0092;
			}
			object obj = null;
			string text = "SELECT COUNT(*) FROM SPEDIZIONI WHERE UNIBOL=" + base.DbConn.SQLFormatString(Unibol);
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Conversions.ToInteger(obj) != 0)
				{
					goto IL_0092;
				}
				rsMess = TranslateMessage("XXX", "La spedizione con id {0} non esiste.", Unibol);
			}
			goto end_IL_0005;
			IL_0092:
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
