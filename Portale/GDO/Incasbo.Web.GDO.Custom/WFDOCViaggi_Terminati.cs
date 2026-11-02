using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Gdo.Track;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO.Custom;

public class WFDOCViaggi_Terminati : ViaggiUI
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnApriKm")]
	private IboWebButton _btnApriKm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOpenPopup")]
	private IboWebButton _btnOpenPopup;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cpSpedizioni_Title_Caption")]
	private IboWebLinkButton _cpSpedizioni_Title_Caption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cpSpedizioni_Title_Caption_Raggru")]
	private IboWebLinkButton _cpSpedizioni_Title_Caption_Raggru;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cpEventi_Title_Caption")]
	private IboWebLinkButton _cpEventi_Title_Caption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCertifica")]
	private IboWebButton _btnCertifica;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcola")]
	private IboWebButton _btnCalcola;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcolaKmETempi")]
	private IboWebButton _btnCalcolaKmETempi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOttimizzazione")]
	private IboWebButton _btnOttimizzazione;

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

	[field: AccessedThroughProperty("up_tpGen")]
	protected virtual UpdatePanel up_tpGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_ViaggioInfoGen")]
	protected virtual UpdatePanel up_ViaggioInfoGen
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

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
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

	[field: AccessedThroughProperty("lblTipoViaggio")]
	protected virtual IboWebLabel lblTipoViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoViaggio")]
	protected virtual IboWebComboTlk cmbTipoViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataPartenzaEffettiva")]
	protected virtual IboWebLabel lblDataPartenzaEffettiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataPartenzaEffettiva")]
	protected virtual IboWebDate2 txtDataPartenzaEffettiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataArrivoEffettiva")]
	protected virtual IboWebLabel lblDataArrivoEffettiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataArrivoEffettiva")]
	protected virtual IboWebDate2 txtDataArrivoEffettiva
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

	[field: AccessedThroughProperty("lblStatoDescrizione")]
	protected virtual IboWebLabel lblStatoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatoValue")]
	protected virtual IboWebLabel lblStatoValue
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

	[field: AccessedThroughProperty("cmbVettore")]
	protected virtual IboWebComboTlk cmbVettore
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

	[field: AccessedThroughProperty("cmbCliente")]
	protected virtual IboWebComboTlk cmbCliente
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

	[field: AccessedThroughProperty("lblRicavi")]
	protected virtual IboWebLabel lblRicavi
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

	[field: AccessedThroughProperty("cmbTipoSpedizione")]
	protected virtual IboWebComboTlk cmbTipoSpedizione
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

	[field: AccessedThroughProperty("lblColli")]
	protected virtual IboWebLabel lblColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCostiPrimari")]
	protected virtual IboWebLabel lblCostiPrimari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMotriceEffettiva")]
	protected virtual IboWebLabel lblMotriceEffettiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMotriceEffettiva")]
	protected virtual IboWebComboTlk cmbMotriceEffettiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista1Effettivo")]
	protected virtual IboWebLabel lblAutista1Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAutista1Effettivo")]
	protected virtual IboWebComboTlk cmbAutista1Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAutista2Effettivo")]
	protected virtual IboWebComboTlk cmbAutista2Effettivo
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

	[field: AccessedThroughProperty("lblCostiSecondari")]
	protected virtual IboWebLabel lblCostiSecondari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRimorchioEffettivo1")]
	protected virtual IboWebLabel lblRimorchioEffettivo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbRimorchio1Effettivo")]
	protected virtual IboWebComboTlk cmbRimorchio1Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContenitore1Effettivo")]
	protected virtual IboWebLabel lblContenitore1Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbContenitore1Effettivo")]
	protected virtual IboWebComboTlk cmbContenitore1Effettivo
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

	[field: AccessedThroughProperty("lblMargine")]
	protected virtual IboWebLabel lblMargine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRimorchio2Effettivo")]
	protected virtual IboWebLabel lblRimorchio2Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbRimorchio2Effettivo")]
	protected virtual IboWebComboTlk cmbRimorchio2Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContenitore2Effettivo")]
	protected virtual IboWebLabel lblContenitore2Effettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbContenitore2Effettivo")]
	protected virtual IboWebComboTlk cmbContenitore2Effettivo
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

	[field: AccessedThroughProperty("lblPCSPartenzaEff")]
	protected virtual IboWebLabel lblPCSPartenzaEff
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSPartenzaEffettivo")]
	protected virtual IboWebComboTlk cmbPCSPartenzaEffettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSArrivoEff")]
	protected virtual IboWebLabel lblPCSArrivoEff
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSArrivoEffettivo")]
	protected virtual IboWebComboTlk cmbPCSArrivoEffettivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumSpedizioni")]
	protected virtual IboWebLabel lblNumSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaPartenza")]
	protected virtual IboWebLabel lblZonaPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaPartenza")]
	protected virtual IboWebComboTlk cmbZonaPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaArrivo")]
	protected virtual IboWebLabel lblZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivo")]
	protected virtual IboWebComboTlk cmbZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKm")]
	protected virtual IboWebLabel lblKm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_btnApriKm")]
	protected virtual UpdatePanel up_btnApriKm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnApriKm
	{
		[CompilerGenerated]
		get
		{
			return _btnApriKm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnApriKm_Click;
			IboWebButton val = _btnApriKm;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnApriKm = value;
			val = _btnApriKm;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
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

	[field: AccessedThroughProperty("lblZonaArrivoTariffaAttiva")]
	protected virtual IboWebLabel lblZonaArrivoTariffaAttiva
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

	[field: AccessedThroughProperty("lblTempoGuidaPianif")]
	protected virtual IboWebLabel lblTempoGuidaPianif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTerminale")]
	protected virtual IboWebLabel lblTerminale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MinutiGuidaPianificati")]
	protected virtual IboWebTextBox MinutiGuidaPianificati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TempoGuidaPianif")]
	protected virtual IboWebTextBox TempoGuidaPianif
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTerminaleValue")]
	protected virtual IboWebLabel lblTerminaleValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOpenPopup")]
	protected virtual IboWebLabel lblOpenPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_btnOpenPopup")]
	protected virtual UpdatePanel up_btnOpenPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnOpenPopup
	{
		[CompilerGenerated]
		get
		{
			return _btnOpenPopup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnOpenPopup_Click;
			IboWebButton val = _btnOpenPopup;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnOpenPopup = value;
			val = _btnOpenPopup;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("txtIdViaggioOBC")]
	protected virtual IboWebLabel txtIdViaggioOBC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpspedizioni")]
	protected virtual UpdatePanel up_cpspedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSpedizioni_Title")]
	protected virtual Panel cpSpedizioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton cpSpedizioni_Title_Caption
	{
		[CompilerGenerated]
		get
		{
			return _cpSpedizioni_Title_Caption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cpSpedizioni_Title_Caption_Click;
			IboWebLinkButton val = _cpSpedizioni_Title_Caption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_cpSpedizioni_Title_Caption = value;
			val = _cpSpedizioni_Title_Caption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebLinkButton cpSpedizioni_Title_Caption_Raggru
	{
		[CompilerGenerated]
		get
		{
			return _cpSpedizioni_Title_Caption_Raggru;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cpSpedizioni_Title_Caption_Raggru_Click;
			IboWebLinkButton val = _cpSpedizioni_Title_Caption_Raggru;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_cpSpedizioni_Title_Caption_Raggru = value;
			val = _cpSpedizioni_Title_Caption_Raggru;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebLinkButton cpEventi_Title_Caption
	{
		[CompilerGenerated]
		get
		{
			return _cpEventi_Title_Caption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cpEventi_Title_Caption_Click;
			IboWebLinkButton val = _cpEventi_Title_Caption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_cpEventi_Title_Caption = value;
			val = _cpEventi_Title_Caption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("cpSpedizioni_Body")]
	protected virtual Panel cpSpedizioni_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdViaggiSpedizioni")]
	protected virtual IboWebToolbar tlbgrdViaggiSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiSpedizioni")]
	protected virtual Panel pnlViaggiSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdViaggiSpedizioni")]
	protected virtual IboGridView grdViaggiSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpSpedizioni_Body_Raggru")]
	protected virtual Panel cpSpedizioni_Body_Raggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdViaggiSpedizioniRaggru")]
	protected virtual IboWebToolbar tlbgrdViaggiSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiSpedizioniRaggru")]
	protected virtual Panel pnlViaggiSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdViaggiSpedizioniRaggru")]
	protected virtual IboGridView grdViaggiSpedizioniRaggru
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

	[field: AccessedThroughProperty("tlbgrdViaggiEventi")]
	protected virtual IboWebToolbar tlbgrdViaggiEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiEventi")]
	protected virtual Panel pnlViaggiEventi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdViaggiEventi")]
	protected virtual IboGridView grdViaggiEventi
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

	[field: AccessedThroughProperty("up_tp_Costi_InfoTestata")]
	protected virtual UpdatePanel up_tp_Costi_InfoTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpCosti_Header")]
	protected virtual Panel cpCosti_Header
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_Vettore")]
	protected virtual IboWebLabel lblCosti_Vettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_Vettore_Descrizione")]
	protected virtual IboWebLabel lblCosti_Vettore_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_TipoSpedizione")]
	protected virtual IboWebLabel lblCosti_TipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_TipoSpedizione_Descrizione")]
	protected virtual IboWebLabel lblCosti_TipoSpedizione_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_TipoMerce")]
	protected virtual IboWebLabel lblCosti_TipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_TipoMerce_Descrizione")]
	protected virtual IboWebLabel lblCosti_TipoMerce_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_PCSPartenza")]
	protected virtual IboWebLabel lblCosti_PCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_PCSPartenza_Descrizione")]
	protected virtual IboWebLabel lblCosti_PCSPartenza_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_PCSArrivo")]
	protected virtual IboWebLabel lblCosti_PCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_PCSArrivo_Descrizione")]
	protected virtual IboWebLabel lblCosti_PCSArrivo_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_ZonaArrivo")]
	protected virtual IboWebLabel lblCosti_ZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCosti_ZonaArrivo_Descrizione")]
	protected virtual IboWebLabel lblCosti_ZonaArrivo_Descrizione
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

	[field: AccessedThroughProperty("cpCosti")]
	protected virtual CollapsiblePanelExtender cpCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpIstruzioni")]
	protected virtual TabPanel tpIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpIstruzioniCaption")]
	protected virtual IboWebLabel tpIstruzioniCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_tpIstruzioni")]
	protected virtual UpdatePanel up_tpIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Title")]
	protected virtual Panel cpInfoExtra_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Title_Caption")]
	protected virtual Label cpInfoExtra_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoExtra_Body")]
	protected virtual Panel cpInfoExtra_Body
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

	[field: AccessedThroughProperty("cpIstruzioni_Title")]
	protected virtual Panel cpIstruzioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIstruzioni_Title_Caption")]
	protected virtual IboWebLabel cpIstruzioni_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIstruzioni_Body")]
	protected virtual Panel cpIstruzioni_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdViaggiIstruzioni")]
	protected virtual IboWebToolbar tlbgrdViaggiIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiIstruzioni")]
	protected virtual Panel pnlViaggiIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdViaggiIstruzioni")]
	protected virtual IboGridView grdViaggiIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1_idle")]
	protected virtual Button Button1_idle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnCertifica
	{
		[CompilerGenerated]
		get
		{
			return _btnCertifica;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCertifica_Click;
			IboWebButton val = _btnCertifica;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCertifica = value;
			val = _btnCertifica;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
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

	protected virtual IboWebButton btnCalcolaKmETempi
	{
		[CompilerGenerated]
		get
		{
			return _btnCalcolaKmETempi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCalcolaKmETempi_Click;
			IboWebButton val = _btnCalcolaKmETempi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCalcolaKmETempi = value;
			val = _btnCalcolaKmETempi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnOttimizzazione
	{
		[CompilerGenerated]
		get
		{
			return _btnOttimizzazione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnOttimizzazione_Click;
			IboWebButton val = _btnOttimizzazione;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnOttimizzazione = value;
			val = _btnOttimizzazione;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlCorrispondente")]
	protected virtual Panel pnlCorrispondente
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

	[field: AccessedThroughProperty("Corrispondente")]
	protected virtual IboWebComboTlk Corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro")]
	protected virtual Panel pnlFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteSpe")]
	protected virtual IboWebLabel lblClienteSpe
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	protected virtual IboWebComboTlk Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZona")]
	protected virtual IboWebLabel lblZona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZonaSpedizione")]
	protected virtual IboWebComboTlk ZonaSpedizione
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

	[field: AccessedThroughProperty("NumeroOrdine")]
	protected virtual IboWebTextBox NumeroOrdine
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

	[field: AccessedThroughProperty("DataOrdine")]
	protected virtual IboWebDate2 DataOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBolla")]
	protected virtual IboWebLabel lblBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumeroBolla")]
	protected virtual IboWebTextBox NumeroBolla
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

	[field: AccessedThroughProperty("DataBolla")]
	protected virtual IboWebDate2 DataBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegna")]
	protected virtual IboWebLabel lblDataConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataConsegna")]
	protected virtual IboWebDate2 DataConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQuantita")]
	protected virtual Panel pnlQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpQuantita_Body")]
	protected virtual Panel cpQuantita_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampiCalcoloSpedizioniTitle")]
	protected virtual IboWebLabel CampiCalcoloSpedizioniTitle
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

	[field: AccessedThroughProperty("lblCampoCalcolo2")]
	protected virtual IboWebLabel lblCampoCalcolo2
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

	[field: AccessedThroughProperty("lblCampoCalcolo4")]
	protected virtual IboWebLabel lblCampoCalcolo4
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

	[field: AccessedThroughProperty("lblCampoCalcolo6")]
	protected virtual IboWebLabel lblCampoCalcolo6
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

	[field: AccessedThroughProperty("lblCampoCalcolo8")]
	protected virtual IboWebLabel lblCampoCalcolo8
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

	[field: AccessedThroughProperty("lblCampoCalcolo10")]
	protected virtual IboWebLabel lblCampoCalcolo10
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

	[field: AccessedThroughProperty("CampiCalcoloAttiviTitle")]
	protected virtual IboWebLabel CampiCalcoloAttiviTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo1Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo1Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo1Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo1Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo2Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo2Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo2Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo2Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo3Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo3Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo3Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo3Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo4Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo4Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo4Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo4Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo5Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo5Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo5Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo5Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo6Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo6Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo6Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo6Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo7Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo7Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo7Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo7Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo8Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo8Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo8Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo8Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo9Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo9Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo9Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo9Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo10Attivo")]
	protected virtual IboWebLabel lblCampoCalcolo10Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo10Attivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo10Attivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampiCalcoloPassiviTitle")]
	protected virtual IboWebLabel CampiCalcoloPassiviTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo1Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo1Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo1Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo1Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo2Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo2Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo2Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo2Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo3Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo3Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo3Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo3Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo4Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo4Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo4Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo4Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo5Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo5Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo5Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo5Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo6Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo6Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo6Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo6Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo7Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo7Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo7Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo7Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo8Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo8Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo8Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo8Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo9Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo9Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo9Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo9Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo10Passivo")]
	protected virtual IboWebLabel lblCampoCalcolo10Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo10Passivo")]
	protected virtual IboWebNumericTlk txtCampoCalcolo10Passivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCampiChilometrici")]
	protected virtual Panel pnlCampiChilometrici
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpKm_Body")]
	protected virtual Panel cpKm_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmManuali")]
	protected virtual IboWebLabel lblKmManuali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmManuali")]
	protected virtual IboWebNumericTlk txtKmManuali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmCertificati")]
	protected virtual IboWebLabel lblKmCertificati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmCertificati")]
	protected virtual IboWebNumericTlk txtKmCertificati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmPianificati")]
	protected virtual IboWebLabel lblKmPianificati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmPianificati")]
	protected virtual IboWebNumericTlk txtKmPianificati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmGps")]
	protected virtual IboWebLabel lblKmGps
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmGps")]
	protected virtual IboWebNumericTlk txtKmGps
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmRicalcolati")]
	protected virtual IboWebLabel lblKmRicalcolati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmRicalcolati")]
	protected virtual IboWebNumericTlk txtKmRicalcolati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.VIAGGI.VETT";
		_Title = base.Translator.Translate("XXX", "Viaggio", new string[0]);
		if (!((Page)this).IsPostBack)
		{
			lblCampoCalcolo1.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO1", lblCampoCalcolo1.ObjValue.ToString());
			lblCampoCalcolo2.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO2", lblCampoCalcolo2.ObjValue.ToString());
			lblCampoCalcolo3.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO3", lblCampoCalcolo3.ObjValue.ToString());
			lblCampoCalcolo4.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO4", lblCampoCalcolo4.ObjValue.ToString());
			lblCampoCalcolo5.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO5", lblCampoCalcolo5.ObjValue.ToString());
			lblCampoCalcolo6.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO6", lblCampoCalcolo6.ObjValue.ToString());
			lblCampoCalcolo7.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO7", lblCampoCalcolo7.ObjValue.ToString());
			lblCampoCalcolo8.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO8", lblCampoCalcolo8.ObjValue.ToString());
			lblCampoCalcolo9.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO9", lblCampoCalcolo9.ObjValue.ToString());
			lblCampoCalcolo10.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO10", lblCampoCalcolo10.ObjValue.ToString());
			lblCampoCalcolo1Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO1ATTIVO", lblCampoCalcolo1Attivo.ObjValue.ToString());
			lblCampoCalcolo2Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO2ATTIVO", lblCampoCalcolo2Attivo.ObjValue.ToString());
			lblCampoCalcolo3Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO3ATTIVO", lblCampoCalcolo3Attivo.ObjValue.ToString());
			lblCampoCalcolo4Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO4ATTIVO", lblCampoCalcolo4Attivo.ObjValue.ToString());
			lblCampoCalcolo5Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO5ATTIVO", lblCampoCalcolo5Attivo.ObjValue.ToString());
			lblCampoCalcolo6Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO6ATTIVO", lblCampoCalcolo7Attivo.ObjValue.ToString());
			lblCampoCalcolo7Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO7ATTIVO", lblCampoCalcolo7Attivo.ObjValue.ToString());
			lblCampoCalcolo8Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO8ATTIVO", lblCampoCalcolo8Attivo.ObjValue.ToString());
			lblCampoCalcolo9Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO9ATTIVO", lblCampoCalcolo9Attivo.ObjValue.ToString());
			lblCampoCalcolo10Attivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO10ATTIVO", lblCampoCalcolo10Attivo.ObjValue.ToString());
			lblCampoCalcolo1Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO1PASSIVO", lblCampoCalcolo1Passivo.ObjValue.ToString());
			lblCampoCalcolo2Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO2PASSIVO", lblCampoCalcolo2Passivo.ObjValue.ToString());
			lblCampoCalcolo3Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO3PASSIVO", lblCampoCalcolo3Passivo.ObjValue.ToString());
			lblCampoCalcolo4Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO4PASSIVO", lblCampoCalcolo4Passivo.ObjValue.ToString());
			lblCampoCalcolo5Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO5PASSIVO", lblCampoCalcolo5Passivo.ObjValue.ToString());
			lblCampoCalcolo6Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO6PASSIVO", lblCampoCalcolo7Passivo.ObjValue.ToString());
			lblCampoCalcolo7Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO7PASSIVO", lblCampoCalcolo7Passivo.ObjValue.ToString());
			lblCampoCalcolo8Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO8PASSIVO", lblCampoCalcolo8Passivo.ObjValue.ToString());
			lblCampoCalcolo9Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO9PASSIVO", lblCampoCalcolo9Passivo.ObjValue.ToString());
			lblCampoCalcolo10Passivo.ObjValue = base.SessionEnvironment.ApplicationParams.Viaggi_GetFieldText("CAMPOCALCOLO10PASSIVO", lblCampoCalcolo10Passivo.ObjValue.ToString());
		}
		if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "M", false) == 0)
		{
			((RadComboBox)cmbMotriceEffettiva).AutoPostBack = true;
			((RadComboBox)cmbAutista1Effettivo).AutoPostBack = false;
			((RadComboBox)cmbMotriceEffettiva).SelectedIndexChanged += new RadComboBoxSelectedIndexChangedEventHandler(cmbMotriceEffettiva_SelectedIndexChanged);
		}
		else if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "A", false) == 0)
		{
			((RadComboBox)cmbMotriceEffettiva).AutoPostBack = false;
			((RadComboBox)cmbAutista1Effettivo).AutoPostBack = true;
			((RadComboBox)cmbAutista1Effettivo).SelectedIndexChanged += new RadComboBoxSelectedIndexChangedEventHandler(cmbAutista1Effettivo_SelectedIndexChanged);
		}
		else
		{
			((RadComboBox)cmbMotriceEffettiva).AutoPostBack = false;
			((RadComboBox)cmbAutista1Effettivo).AutoPostBack = false;
		}
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.CheckData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "M", false) == 0)
			{
				string Vettore = cmbVettore.ObjValue.ToString();
				val = CheckVettoreMotrice(cmbMotriceEffettiva.ObjValue.ToString(), ref Vettore, ref rsMess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(Vettore, cmbVettore.ObjValue.ToString(), false) != 0)
					{
						cmbVettore.ObjValue = Vettore;
					}
					goto IL_015a;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "A", false) != 0)
				{
					goto IL_015a;
				}
				string Vettore2 = cmbVettore.ObjValue.ToString();
				val = CheckVettoreAutista(cmbAutista1Effettivo.ObjValue.ToString(), ref Vettore2, ref rsMess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(Vettore2, cmbVettore.ObjValue.ToString(), false) != 0)
					{
						cmbVettore.ObjValue = Vettore2;
					}
					goto IL_015a;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_015a:
			val2 = (FXRETURN)0;
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

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Invalid comparison between Unknown and I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdViaggiIstruzioni;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdViaggiIstruzioni = objGridView;
			iboInternalGridConfig.Build("DM.DOC.VIAGGI.ISTRUZIONI#TER", "SELECT * FROM GRD_DOC_Viaggi_Chiusi_Istr WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiIstruzioni).ID, ((Control)tlbgrdViaggiIstruzioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdViaggiEventi;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdViaggiEventi = objGridView;
			iboInternalGridConfig.Build("DM.DOC.VIAGGI.EVENTI", "SELECT * FROM GRD_DOC_Viaggi_Eventi WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiEventi).ID, ((Control)tlbgrdViaggiEventi).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdViaggiSpedizioni;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdViaggiSpedizioni = objGridView;
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#VIAGGI_TER", "SELECT * FROM GRD_DOC_Viaggi_Terminati_Sped WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiSpedizioni).ID, ((Control)tlbgrdViaggiSpedizioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdViaggiSpedizioniRaggru;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdViaggiSpedizioniRaggru = objGridView;
			string sSqlStatement = CreateQueryForSpedizioniRaggru("<%IDVIAGGIO%>");
			iboInternalGridConfig.Build("DM.DOC.CONSEGNE#VIAGGI_TER", sSqlStatement, "", "", ((Control)grdViaggiSpedizioniRaggru).ID, ((Control)tlbgrdViaggiSpedizioniRaggru).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
			StateBag myViewState5 = base.MyViewState;
			objGridView = grdCosti;
			iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
			grdCosti = objGridView;
			iboInternalGridConfig.Build("DM.DOC.VIAGGI.COSTI", "SELECT * FROM GRD_VIAGGI_COSTI WHERE IDVIAGGIO='<%IDVIAGGIO%>'", "", "", ((Control)grdCosti).ID, ((Control)tlbgrdCosti).ID);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if ((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0))
				{
					rsMess = TranslateMessage("XXX", "Non è possibile l'inserimento, la duplicazione o la cancellazione di viaggi partiti");
				}
				else
				{
					cmbTipoViaggio.ReadOnly = true;
					((RadComboBox)cmbTipoViaggio).AutoPostBack = false;
					if (!((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)))
					{
						goto IL_0133;
					}
					val2 = AggiornaTotaliDiViaggio(ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = CalcolaTotaleCostiRicavi(ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_0133;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0019;
			IL_0133:
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
			{
				btnCalcola.Visible = true;
				btnCalcolaKmETempi.Visible = true;
				btnCertifica.Visible = true;
			}
			else
			{
				btnCalcola.Visible = false;
				btnCalcolaKmETempi.Visible = false;
				btnCertifica.Visible = false;
			}
			string text4 = "00";
			string text5 = "00";
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(MinutiGuidaPianificati.ObjValue.ToString(), "", false) != 0)
			{
				num = Conversions.ToInteger(MinutiGuidaPianificati.ObjValue) / 60;
				num2 = checked(Conversions.ToInteger(MinutiGuidaPianificati.ObjValue) - num * 60);
				text4 = num.ToString().PadLeft(2, '0');
				text5 = num2.ToString().PadLeft(2, '0');
			}
			TempoGuidaPianif.ObjValue = text4 + ":" + text5;
			up_ViaggioInfoGen.Update();
			cmbVettore.ReadOnly = true;
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

	protected override FXRETURN PreRenderPage(ref string rsMess)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			TcMain_ActiveTabChangedUpdate();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return base.PreRenderPage(ref rsMess);
	}

	protected override string CreateQueryForSpedizioniRaggru(string IdViaggio)
	{
		string text = "";
		text += "SELECT T.*, CAST(T.IdViaggio AS VARCHAR(10)) %+% ';' %+% T.Tipo %+% ';' %+% T.PCSDESTINAZIONE %+% ';' %+% CAST(T.SequenzaPianificata AS VARCHAR(10)) WFIKey, ";
		text += "CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
		text += "SELECT  S.IdViaggio,'D' Tipo,";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "CASE WHEN MAX(S.SequenzaEffettiva) > 0 THEN 0 ELSE 1 END AS Sequenza,  ";
		text += "MAX(S.SequenzaEffettiva) SequenzaEffettiva,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "S.PCSDESTINAZIONE PCSDESTINAZIONE,";
		text += "MAX(S.PCSDESTINAZIONE_RAGSOC) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(S.PCSDESTINAZIONE_INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(S.PCSDESTINAZIONE_CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(S.PCSDESTINAZIONE_LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(S.PCSDESTINAZIONE_PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(S.PCSDESTINAZIONE_NAZIONE) PCSDESTINAZIONE_NAZIONE,";
		text += "SUM(S.PESO) PESO,";
		text += "SUM(S.COLLI) COLLI,";
		text += "SUM(S.PALLET) PALLET,";
		text += "SUM(S.VOLUME) VOLUME,";
		text += "SUM(S.CAMPOCALCOLO1) CAMPOCALCOLO1,";
		text += "SUM(S.CAMPOCALCOLO2) CAMPOCALCOLO2,";
		text += "SUM(S.CAMPOCALCOLO3) CAMPOCALCOLO3,";
		text += "SUM(S.CAMPOCALCOLO4) CAMPOCALCOLO4,";
		text += "SUM(S.CAMPOCALCOLO5) CAMPOCALCOLO5,";
		text += "SUM(S.CAMPOCALCOLO6) CAMPOCALCOLO6,";
		text += "SUM(S.CAMPOCALCOLO7) CAMPOCALCOLO7,";
		text += "SUM(S.CAMPOCALCOLO8) CAMPOCALCOLO8,";
		text += "SUM(S.CAMPOCALCOLO9) CAMPOCALCOLO9,";
		text += "SUM(S.CAMPOCALCOLO10) CAMPOCALCOLO10,";
		text += "SUM(S.CONTRASSEGNO) CONTRASSEGNO ";
		text += "FROM SPEDIZIONI S ";
		text += "WHERE S.IDViaggio IS NOT NULL ";
		text = text + "AND S.IdViaggio='" + IdViaggio + "' ";
		text += "AND S.CORRISPONDENTE IS NULL ";
		text += "GROUP BY S.IdViaggio, S.PCSDESTINAZIONE ";
		text += " UNION ";
		text += "SELECT  S.IdViaggio,'C' Tipo,";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "CASE WHEN MAX(S.SequenzaEffettiva) > 0 THEN 0 ELSE 1 END AS Sequenza,  ";
		text += "MAX(S.SequenzaEffettiva) SequenzaEffettiva,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
		text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,        ";
		text += "SUM(S.PESO) PESO,";
		text += "SUM(S.COLLI) COLLI,";
		text += "SUM(S.PALLET) PALLET,";
		text += "SUM(S.VOLUME) VOLUME,";
		text += "SUM(S.CAMPOCALCOLO1) CAMPOCALCOLO1,";
		text += "SUM(S.CAMPOCALCOLO2) CAMPOCALCOLO2,";
		text += "SUM(S.CAMPOCALCOLO3) CAMPOCALCOLO3,";
		text += "SUM(S.CAMPOCALCOLO4) CAMPOCALCOLO4,";
		text += "SUM(S.CAMPOCALCOLO5) CAMPOCALCOLO5,";
		text += "SUM(S.CAMPOCALCOLO6) CAMPOCALCOLO6,";
		text += "SUM(S.CAMPOCALCOLO7) CAMPOCALCOLO7,";
		text += "SUM(S.CAMPOCALCOLO8) CAMPOCALCOLO8,";
		text += "SUM(S.CAMPOCALCOLO9) CAMPOCALCOLO9,";
		text += "SUM(S.CAMPOCALCOLO10) CAMPOCALCOLO10,";
		text += "SUM(S.CONTRASSEGNO) CONTRASSEGNO ";
		text += "FROM SPEDIZIONI S LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
		text += "WHERE S.IDViaggio IS NOT NULL ";
		text = text + "AND S.IdViaggio='" + IdViaggio + "' ";
		text += "AND S.CORRISPONDENTE IS NOT NULL ";
		text += "GROUP BY S.IdViaggio, S.CORRISPONDENTE ) T";
		return base.DbConn.SqlConvertForServer(text);
	}

	private void DisabilitazioneControlli()
	{
		btnOpenPopup.ReadOnly = true;
		txtDataPartenzaEffettiva.ReadOnly = true;
		txtDataArrivoEffettiva.ReadOnly = true;
		cmbCliente.ReadOnly = true;
		cmbVettore.ReadOnly = true;
		txtKmPianificati.ReadOnly = true;
		cmbTipoSpedizione.ReadOnly = true;
		cmbTipoMerce.ReadOnly = true;
		cmbMotriceEffettiva.ReadOnly = true;
		cmbAutista1Effettivo.ReadOnly = true;
		cmbAutista2Effettivo.ReadOnly = true;
		cmbRimorchio1Effettivo.ReadOnly = true;
		cmbContenitore1Effettivo.ReadOnly = true;
		cmbRimorchio2Effettivo.ReadOnly = true;
		cmbContenitore2Effettivo.ReadOnly = true;
		cmbPCSPartenzaEffettivo.ReadOnly = true;
		cmbPCSArrivoEffettivo.ReadOnly = true;
		cmbZonaPartenza.ReadOnly = true;
		cmbZonaPartenzaTariffaAttiva.ReadOnly = true;
		cmbZonaArrivo.ReadOnly = true;
		cmbZonaArrivoTariffaAttiva.ReadOnly = true;
	}

	private void cmbMotriceEffettiva_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(cmbMotriceEffettiva.ObjValue.ToString(), "", false) == 0)
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
				cmbVettore.ReadOnly = false;
			}
			else
			{
				string text = "SELECT Trasportatore FROM Mezzi WHERE Codice=" + base.DbConn.SQLFormatString(cmbMotriceEffettiva.ObjValue.ToString());
				object obj = null;
				val = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				if (Operators.CompareString(obj.ToString(), "", false) != 0)
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbVettore, obj.ToString(), ref rsMess);
					cmbVettore.ReadOnly = true;
				}
				else
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
					cmbVettore.ReadOnly = false;
				}
			}
			val2 = (FXRETURN)0;
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

	private void cmbAutista1Effettivo_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(cmbAutista1Effettivo.ObjValue.ToString(), "", false) == 0)
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
				cmbVettore.ReadOnly = false;
			}
			else
			{
				string text = "SELECT Trasportatore FROM Autisti WHERE Codice=" + base.DbConn.SQLFormatString(cmbAutista1Effettivo.ObjValue.ToString());
				object obj = null;
				val = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				if (Operators.CompareString(obj.ToString(), "", false) != 0)
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbVettore, obj.ToString(), ref rsMess);
					cmbVettore.ReadOnly = true;
				}
				else
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
					cmbVettore.ReadOnly = false;
				}
			}
			val2 = (FXRETURN)0;
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

	private void cpSpedizioni_Title_Caption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			cpSpedizioni_Title_Caption.Enabled = false;
			cpSpedizioni_Title_Caption_Raggru.Enabled = true;
			cpEventi_Title_Caption.Enabled = true;
			((Control)cpSpedizioni_Body).Visible = true;
			((Control)cpSpedizioni_Body_Raggru).Visible = false;
			((Control)cpEventi_Body).Visible = false;
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

	private void cpSpedizioni_Title_Caption_Raggru_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			cpSpedizioni_Title_Caption.Enabled = true;
			cpSpedizioni_Title_Caption_Raggru.Enabled = false;
			cpEventi_Title_Caption.Enabled = true;
			((Control)cpSpedizioni_Body).Visible = false;
			((Control)cpSpedizioni_Body_Raggru).Visible = true;
			((Control)cpEventi_Body).Visible = false;
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

	private void cpEventi_Title_Caption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			cpSpedizioni_Title_Caption.Enabled = true;
			cpSpedizioni_Title_Caption_Raggru.Enabled = true;
			cpEventi_Title_Caption.Enabled = false;
			((Control)cpSpedizioni_Body).Visible = false;
			((Control)cpSpedizioni_Body_Raggru).Visible = false;
			((Control)cpEventi_Body).Visible = true;
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

	private void btnCalcola_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string UserMessage = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = CalcolaTariffe(cmbCliente.ObjValue.ToString(), cmbVettore.ObjValue.ToString(), ref UserMessage, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = Reload(ref rsMess);
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdCosti).ID];
			string rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			IboInternalGridConfig objInternalGridConfig2 = GridConfigList[((Control)grdViaggiSpedizioni).ID];
			rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsMess2);
			base.MasterPage.ContentUpdatePanel.Update();
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
			else if (Operators.CompareString(UserMessage, "", false) != 0)
			{
				UserMessage = UserMessage.Replace("\r\n\r\n", "\r\n");
				UserMessage = UserMessage.Replace("\r\n \r\n", "\r\n");
				WriteInfoMessage(TranslateMessage("XXX", "Calcolo Costi e ricavi"), UserMessage, "", ShowAsNotification: true, "");
			}
		}
	}

	private void btnCalcolaKmETempi_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = ViaggioRicalcolaKmETempi_GDOWSC_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), null, base.SessionEnvironment.WebUser.WebUserInfo.Codice, base.SessionEnvironment.WebUser.WebUserInfo.DecryptedPassword(), ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string rsMess2 = "";
			Reload(ref rsMess2);
			base.MasterPage.ContentUpdatePanel.Update();
			WriteInfoMessage("Calcolo km/tempi per i viaggi eseguito correttamente");
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

	private void btnOpenPopup_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			MasterPopupFormOpen(TranslateMessage("XXX", "Campi Calcolo"), (Control)(object)pnlQuantita, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: false, "CAMPICALCOLO");
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

	private void TcMain_ActiveTabChangedUpdate()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Invalid comparison between Unknown and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(lblCosti_Vettore_Descrizione.ObjValue.ToString(), cmbVettore.Text, false) != 0)
			{
				lblCosti_Vettore_Descrizione.ObjValue = cmbVettore.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_TipoSpedizione_Descrizione.ObjValue.ToString(), cmbTipoSpedizione.Text, false) != 0)
			{
				lblCosti_TipoSpedizione_Descrizione.ObjValue = cmbTipoSpedizione.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_TipoMerce_Descrizione.ObjValue.ToString(), cmbTipoMerce.Text, false) != 0)
			{
				lblCosti_TipoMerce_Descrizione.ObjValue = cmbTipoMerce.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_PCSPartenza_Descrizione.ObjValue.ToString(), cmbPCSPartenzaEffettivo.Text, false) != 0)
			{
				lblCosti_PCSPartenza_Descrizione.ObjValue = cmbPCSPartenzaEffettivo.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_PCSArrivo_Descrizione.ObjValue.ToString(), cmbPCSArrivoEffettivo.Text, false) != 0)
			{
				lblCosti_PCSArrivo_Descrizione.ObjValue = cmbPCSArrivoEffettivo.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_ZonaArrivo_Descrizione.ObjValue.ToString(), cmbZonaArrivo.Text, false) != 0)
			{
				lblCosti_ZonaArrivo_Descrizione.ObjValue = cmbZonaArrivo.Text;
				up_tp_Costi_InfoTestata.Update();
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

	private void btnCertifica_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			Viaggio_Certifica_Invoker instance = Viaggio_Certifica_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string? idViaggio = txtIdViaggio.ObjValue.ToString();
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, idViaggio, null, ApplyQuery: true, ref RetQueryToApply, ref rsMess);
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
			else
			{
				ReturnToCaller();
			}
		}
	}

	private void btnApriKm_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			MasterPopupFormOpen(TranslateMessage("XXX", "Campi chilometrici"), (Control)(object)pnlCampiChilometrici, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: false, "CAMPIKM");
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

	private void btnOttimizzazione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), 0, base.SessionEnvironment.WebUser.WebUserInfo.Codice, base.SessionEnvironment.WebUser.WebUserInfo.DecryptedPassword(), ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string rsMess2 = "";
			Reload(ref rsMess2);
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			base.MasterPage.ContentUpdatePanel.Update();
			WriteInfoMessage("Calcolo km/tempi per i viaggi eseguito correttamente", ShowAsNotification: true);
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtIdViaggio.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "IdViaggio", "Text", ref PropertyValue);
			if (!((object)tlb).Equals((object?)tlbgrdCosti))
			{
				goto IL_0081;
			}
			val2 = CheckInserimentoCostiRicavi(txtIdViaggio.ObjValue.ToString(), "C", ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0081;
			}
			val = val2;
			goto end_IL_0005;
			IL_0081:
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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
				if (!((object)tlb).Equals((object?)tlbgrdCosti))
				{
					goto IL_0091;
				}
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0091;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_0091:
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_00a2;
				}
				val = val2;
			}
			else if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Cancella(ref funcArg, ref rsMess) <= 0)
			{
				goto IL_00a2;
			}
			goto end_IL_0005;
			IL_00a2:
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtIdViaggio.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "IdViaggio", "Text", ref PropertyValue);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
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

	public override FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormCheckData(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CORRISPONDENTE", false) != 0 && Operators.CompareString(objPopupInfo.Tag, "FILTROSPEDIZIONI", false) == 0 && ((Operators.CompareString(ZonaSpedizione.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(NumeroBolla.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(NumeroOrdine.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(Cliente.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataBolla.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataOrdine.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataConsegna.ObjValue.ToString(), "", false) == 0)))
			{
				rsMess = TranslateMessage("XXX", "Inserire almeno un filtro di ricerca");
			}
			else
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
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
			else if (Operators.CompareString(objPopupInfo.Tag, "CORRISPONDENTE", false) == 0)
			{
				val = ModificaCorrispondente(Corrispondente.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_011e;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "FILTROSPEDIZIONI", false) != 0)
				{
					if (Operators.CompareString(objPopupInfo.Tag, "GESTISCISEQUENZA", false) == 0)
					{
						iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
						InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
						iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
						InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
						up_cpspedizioni.Update();
					}
					goto IL_011e;
				}
				val = RicercaSpedizioniFiltro(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_011e;
				}
				val2 = val;
			}
			goto end_IL_0007;
			IL_011e:
			val2 = (FXRETURN)0;
			end_IL_0007:;
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tag, "FILTROSPEDIZIONI", false) == 0)
			{
				DataKeyFieldCollection objData = (DataKeyFieldCollection)objRet;
				if (objData.Count <= 0)
				{
					goto IL_0126;
				}
				string Warning = "";
				val = AssociaSpedizioni(ref objData, ref Warning, ref rsMess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						WriteInfoMessage(Warning, ShowAsNotification: true);
					}
					goto IL_0126;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(Tag, "ASSOCIABC", false) == 0)
				{
					IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
					string rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
					objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
					rsMess2 = "";
					InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
					up_cpspedizioni.Update();
					goto IL_0126;
				}
				val = base.IFrameClosed(Tag, RuntimeHelpers.GetObjectValue(objRet), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0126;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0126:
			val2 = (FXRETURN)0;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN GetFilterSpedizioniDaAssociare(ref string Filter, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			Filter = "";
			string text = "1=1 ";
			if (Operators.CompareString(NumeroOrdine.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND NUMEROORDINE = " + base.DbConn.SQLFormatString(NumeroOrdine.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataOrdine.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND DATAORDINE = " + base.DbConn.SQLFormatDate((eTipoData)1, DataOrdine.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(NumeroBolla.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND NUMEROBOLLA = " + base.DbConn.SQLFormatString(NumeroBolla.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataBolla.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND DATABOLLA = " + base.DbConn.SQLFormatDate((eTipoData)1, DataBolla.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(Cliente.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND CLIENTE = " + base.DbConn.SQLFormatString(Cliente.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(ZonaSpedizione.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(ZonaSpedizione.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataConsegna.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND %TRUNC%(%ISNULL%(DataConsegnaConcordata,DataConsegnaPrevista1))=" + base.DbConn.SQLFormatDate((eTipoData)1, DataConsegna.getDateValue) + " ";
			}
			Filter = base.DbConn.SqlConvertForServer(text);
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
		}
		return result;
	}

	private FXRETURN AssociaSpedizioni(ref DataKeyFieldCollection objData, ref string Warning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldValues[] array = null;
		string text = "";
		List<string> list = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Warning = "";
			if (objData.Count <= 0)
			{
				goto IL_01b2;
			}
			list = new List<string>();
			int num = checked(objData[0].FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = objData.Item(0).get_FieldValues(i).ToString();
				list.Add(text);
				string rsmess = "";
				val = Spedizione_AssociaAViaggioChiuso_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsmess);
				if ((int)val > 0)
				{
					Warning += TranslateMessage("XXX", "Spedizione {0}: {1}{2}", text, rsmess, "\r\n");
				}
				list.Clear();
			}
			IboInternalGridConfig iboInternalGridConfig = null;
			iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
			iboInternalGridConfig.Attivo = true;
			InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
			iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
			iboInternalGridConfig.Attivo = true;
			InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
			iboInternalGridConfig = GridConfigList[((Control)grdViaggiEventi).ID];
			iboInternalGridConfig.Attivo = true;
			InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
			val = AggiornaTotaliDiViaggio(ref rsMess);
			if ((int)val <= 0)
			{
				base.MasterPage.ContentUpdatePanel.Update();
				goto IL_01b2;
			}
			val2 = val;
			goto end_IL_0011;
			IL_01b2:
			val2 = (FXRETURN)0;
			end_IL_0011:;
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

	private FXRETURN AssociaSpedizioneSingola(string Unibol, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		List<string> list = new List<string>();
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			list.Add(Unibol);
			val = Spedizione_AssociaAViaggioChiuso_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				WriteInfoMessage(TranslateMessage("XXX", "Associata spedizione con unibol {0}", Unibol), ShowAsNotification: true);
				iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
				InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
				iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
				InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
				iboInternalGridConfig = GridConfigList[((Control)grdViaggiEventi).ID];
				InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
				val = AggiornaTotaliDiViaggio(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					base.MasterPage.ContentUpdatePanel.Update();
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN DisassociaSpedizione(DataKeyFieldCollection objData, string GridID, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		string text = "";
		string text2 = "";
		object obj = null;
		List<string> list = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (objData.Count > 0)
			{
				list = new List<string>();
				checked
				{
					if (Operators.CompareString(GridID, ((Control)grdViaggiSpedizioni).ID, false) == 0)
					{
						int num2 = objData[0].FieldValuesCount - 1;
						for (num = 0; num <= num2; num++)
						{
							text2 = objData.Item(0).get_FieldValues(num).ToString();
							list.Add(text2);
						}
						goto IL_00d5;
					}
					if (Operators.CompareString(GridID, ((Control)grdViaggiSpedizioniRaggru).ID, false) != 0)
					{
						goto IL_00d5;
					}
					val = FindUnibolFromGrdConsegne(objData, ref list, ref rsMess);
				}
				if ((int)val <= 0)
				{
					goto IL_00d5;
				}
				val2 = val;
			}
			else
			{
				rsMess = TranslateMessage("XXX", "E' Necessario selezionare almeno un record.");
			}
			goto end_IL_001b;
			IL_00d5:
			val = Spedizione_DisassociaDaViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
				string rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
				rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				val = AggiornaTotaliDiViaggio(ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
			end_IL_001b:;
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

	private FXRETURN RicercaSpedizioniFiltro(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Invalid comparison between Unknown and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Invalid comparison between Unknown and I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Invalid comparison between Unknown and I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT UNIBOL FROM SPEDIZIONI WHERE IDVIAGGIO IS NULL AND STATO=20 ";
			if (Operators.CompareString(NumeroOrdine.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND NUMEROORDINE=" + base.DbConn.SQLFormatString(NumeroOrdine.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataOrdine.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND DATAORDINE=" + base.DbConn.SQLFormatDate((eTipoData)1, DataOrdine.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(NumeroBolla.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND NUMEROBOLLA=" + base.DbConn.SQLFormatString(NumeroBolla.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataBolla.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND DATABOLLA=" + base.DbConn.SQLFormatDate((eTipoData)1, DataBolla.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(Cliente.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND CLIENTE=" + base.DbConn.SQLFormatString(Cliente.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(ZonaSpedizione.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND ZONASPEDIZIONE=" + base.DbConn.SQLFormatString(ZonaSpedizione.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(DataConsegna.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND %TRUNC%(%ISNULL%(DataConsegnaConcordata,DataConsegnaPrevista1))=" + base.DbConn.SQLFormatDate((eTipoData)1, DataConsegna.getDateValue) + " ";
			}
			text = base.DbConn.SqlConvertForServer(text);
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (dataTable.Rows.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessuna spedizione trovata per i filtri indicati");
			}
			else if (dataTable.Rows.Count == 1)
			{
				val = AssociaSpedizioneSingola(dataTable.Rows[0]["UNIBOL"].ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0343;
				}
				val2 = val;
			}
			else
			{
				val = GetFilterSpedizioniDaAssociare(ref text, ref rsMess);
				if ((int)val <= 0)
				{
					OpenGridInIFrame("DM.DOC.SPEDIZIONI#LIBERE", "FILTROSPEDIZIONI", TranslateMessage("XXX", "Spedizioni da Associare"), text, WFIMaster.IFrameDimension.IFrameContainer90Percent);
					goto IL_0343;
				}
				val2 = val;
			}
			goto end_IL_000e;
			IL_0343:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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

	private FXRETURN ModificaCorrispondente(string Corrispondente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Invalid comparison between Unknown and I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		int num = 0;
		string text = "";
		string text2 = "";
		string text3 = "";
		List<string> list = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig objInternalGridConfig = GridConfigList[_SessionVariable["CORRISPONDENTE_GRD_ID"].ToString()];
			dataKeyFieldCollection = (DataKeyFieldCollection)_SessionVariable["CORRISPONDENTE_UNIBOLS"];
			if (dataKeyFieldCollection.Count <= 0)
			{
				goto IL_0227;
			}
			list = new List<string>();
			checked
			{
				if (Operators.CompareString(objInternalGridConfig.Id, ((Control)grdViaggiSpedizioni).ID, false) == 0)
				{
					int num2 = dataKeyFieldCollection[0].FieldValuesCount - 1;
					for (num = 0; num <= num2; num++)
					{
						list.Add(dataKeyFieldCollection.Item(0).get_FieldValues(num).ToString());
					}
					goto IL_0125;
				}
				if (Operators.CompareString(objInternalGridConfig.Id, ((Control)grdViaggiSpedizioniRaggru).ID, false) != 0)
				{
					goto IL_0125;
				}
				val = FindUnibolFromGrdConsegne(dataKeyFieldCollection, ref list, ref rsMess);
			}
			if ((int)val <= 0)
			{
				goto IL_0125;
			}
			val2 = val;
			goto end_IL_0026;
			IL_0227:
			val2 = (FXRETURN)0;
			goto end_IL_0026;
			IL_0184:
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if (objInternalGridConfig.GridView != null)
			{
				getParentUpdatePanel((Control)(object)objInternalGridConfig.GridView).Update();
			}
			else
			{
				getParentUpdatePanel((Control)(object)objInternalGridConfig.GridViewTlk).Update();
			}
			objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if (objInternalGridConfig.GridView != null)
			{
				getParentUpdatePanel((Control)(object)objInternalGridConfig.GridView).Update();
			}
			else
			{
				getParentUpdatePanel((Control)(object)objInternalGridConfig.GridViewTlk).Update();
			}
			goto IL_0227;
			IL_0125:
			if (Operators.CompareString(Corrispondente, "", false) != 0)
			{
				val = Spedizione_AggiungiTransitPoint.RunProc(CreateApiContext(), list, Corrispondente, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0184;
				}
				val2 = val;
			}
			else
			{
				val = Spedizione_EliminaTransitPoint.RunProc(CreateApiContext(), list, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0184;
				}
				val2 = val;
			}
			end_IL_0026:;
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
			if ((int)val2 > 0)
			{
				string rsMess2 = "";
				WFIRollbackTransaction(ref rsMess2);
			}
			_SessionVariable["CORRISPONDENTE_UNIBOLS"] = (object)null;
			_SessionVariable["CORRISPONDENTE_GRD_ID"] = (object)null;
			CallStackRemove();
			result = val2;
		}
		return result;
	}
}
