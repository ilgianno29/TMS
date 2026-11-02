using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Api.Gdo.Track;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCViaggi : ViaggiUI
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoViaggio")]
	private IboWebComboTlk _cmbTipoViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSPartenza")]
	private IboWebComboTlk _cmbPCSPartenza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSArrivo")]
	private IboWebComboTlk _cmbPCSArrivo;

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
	[AccessedThroughProperty("btnChiudi")]
	private IboWebButton _btnChiudi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnChiudiEPartiViaggio")]
	private IboWebButton _btnChiudiEPartiViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcola")]
	private IboWebButton _btnCalcola;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVettoreMigliore")]
	private IboWebButton _btnVettoreMigliore;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCalcolaKmETempi")]
	private IboWebButton _btnCalcolaKmETempi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOttimizzazione")]
	private IboWebButton _btnOttimizzazione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPCSPiuLontano")]
	private IboWebButton _btnPCSPiuLontano;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkCalcolaKmETempi")]
	private IboWebLinkButton _lnkCalcolaKmETempi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkOttimizzazione")]
	private IboWebLinkButton _lnkOttimizzazione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkPCSPiuLontano")]
	private IboWebLinkButton _lnkPCSPiuLontano;

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

	protected virtual IboWebComboTlk cmbTipoViaggio
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTipoViaggio_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTipoViaggio;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTipoViaggio = value;
			val2 = _cmbTipoViaggio;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblDataPartenzaPianificata")]
	protected virtual IboWebLabel lblDataPartenzaPianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataPartenzaPianificata")]
	protected virtual IboWebDate2 txtDataPartenzaPianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("htxtDataPartenzaPianificataSave")]
	protected virtual IboWebDate2 htxtDataPartenzaPianificataSave
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataArrivoPrevista")]
	protected virtual IboWebLabel lblDataArrivoPrevista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataArrivoPianificata")]
	protected virtual IboWebDate2 txtDataArrivoPianificata
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

	[field: AccessedThroughProperty("lblTipoMErce")]
	protected virtual IboWebLabel lblTipoMErce
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

	[field: AccessedThroughProperty("lblMotricePianificata")]
	protected virtual IboWebLabel lblMotricePianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMotricePianificata")]
	protected virtual IboWebComboTlk cmbMotricePianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("htxtMotricePianificataSave")]
	protected virtual IboWebTextBox htxtMotricePianificataSave
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista1Pianificato")]
	protected virtual IboWebLabel lblAutista1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAutista1Pianificato")]
	protected virtual IboWebComboTlk cmbAutista1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAutista2Pianificato")]
	protected virtual IboWebComboTlk cmbAutista2Pianificato
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

	[field: AccessedThroughProperty("lblRimorchioPianificato1")]
	protected virtual IboWebLabel lblRimorchioPianificato1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbRimorchio1Pianificato")]
	protected virtual IboWebComboTlk cmbRimorchio1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContenitore1Pianificato")]
	protected virtual IboWebLabel lblContenitore1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbContenitore1Pianificato")]
	protected virtual IboWebComboTlk cmbContenitore1Pianificato
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

	[field: AccessedThroughProperty("lblRimorchio2Pianificato")]
	protected virtual IboWebLabel lblRimorchio2Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbRimorchio2Pianificato")]
	protected virtual IboWebComboTlk cmbRimorchio2Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContenitore2Pianificato")]
	protected virtual IboWebLabel lblContenitore2Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbContenitore2Pianificato")]
	protected virtual IboWebComboTlk cmbContenitore2Pianificato
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

	[field: AccessedThroughProperty("lblPCSPartenza")]
	protected virtual IboWebLabel lblPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbPCSPartenza
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSPartenza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSPartenza_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSPartenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSPartenza = value;
			val2 = _cmbPCSPartenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSArrivo")]
	protected virtual IboWebLabel lblPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbPCSArrivo
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSArrivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSArrivo_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSArrivo;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSArrivo = value;
			val2 = _cmbPCSArrivo;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
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

	[field: AccessedThroughProperty("lblKmPrevisti")]
	protected virtual IboWebLabel lblKmPrevisti
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

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebCheckBox1")]
	protected virtual IboWebCheckBox IboWebCheckBox1
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

	[field: AccessedThroughProperty("IboWebTextBox2")]
	protected virtual IboWebTextBox IboWebTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("up_tp_Ricavi_InfoTestata")]
	protected virtual UpdatePanel up_tp_Ricavi_InfoTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRicavi_Header")]
	protected virtual Panel cpRicavi_Header
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_Cliente")]
	protected virtual IboWebLabel lblRicavi_Cliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_Cliente_Descrizione")]
	protected virtual IboWebLabel lblRicavi_Cliente_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_TipoSpedizione")]
	protected virtual IboWebLabel lblRicavi_TipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_TipoSpedizione_Descrizione")]
	protected virtual IboWebLabel lblRicavi_TipoSpedizione_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_TipoMerce")]
	protected virtual IboWebLabel lblRicavi_TipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_TipoMerce_Descrizione")]
	protected virtual IboWebLabel lblRicavi_TipoMerce_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_PCSPartenza")]
	protected virtual IboWebLabel lblRicavi_PCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_PCSPartenza_Descrizione")]
	protected virtual IboWebLabel lblRicavi_PCSPartenza_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_PCSArrivo")]
	protected virtual IboWebLabel lblRicavi_PCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_PCSArrivo_Descrizione")]
	protected virtual IboWebLabel lblRicavi_PCSArrivo_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_ZonaArrivo")]
	protected virtual IboWebLabel lblRicavi_ZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicavi_ZonaArrivo_Descrizione")]
	protected virtual IboWebLabel lblRicavi_ZonaArrivo_Descrizione
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

	[field: AccessedThroughProperty("cpRicavi")]
	protected virtual CollapsiblePanelExtender cpRicavi
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

	[field: AccessedThroughProperty("up_DetailFormCommandsDivCollapsiblePanel")]
	protected virtual UpdatePanel up_DetailFormCommandsDivCollapsiblePanel
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

	protected virtual IboWebButton btnChiudi
	{
		[CompilerGenerated]
		get
		{
			return _btnChiudi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnChiudi_Click;
			IboWebButton val = _btnChiudi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnChiudi = value;
			val = _btnChiudi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnChiudiEPartiViaggio
	{
		[CompilerGenerated]
		get
		{
			return _btnChiudiEPartiViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkChiudiEParti_Click;
			IboWebButton val = _btnChiudiEPartiViaggio;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnChiudiEPartiViaggio = value;
			val = _btnChiudiEPartiViaggio;
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

	protected virtual IboWebButton btnVettoreMigliore
	{
		[CompilerGenerated]
		get
		{
			return _btnVettoreMigliore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVettoreMigliore_Click;
			IboWebButton val = _btnVettoreMigliore;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVettoreMigliore = value;
			val = _btnVettoreMigliore;
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

	protected virtual IboWebButton btnPCSPiuLontano
	{
		[CompilerGenerated]
		get
		{
			return _btnPCSPiuLontano;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnPCSPiuLontano_Click;
			IboWebButton val = _btnPCSPiuLontano;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnPCSPiuLontano = value;
			val = _btnPCSPiuLontano;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("btnAltro")]
	protected virtual IboWebButton btnAltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnMapFunctions")]
	protected virtual IboWebButton btnMapFunctions
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkCalcolaKmETempi
	{
		[CompilerGenerated]
		get
		{
			return _lnkCalcolaKmETempi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCalcolaKmETempi_Click;
			IboWebLinkButton val = _lnkCalcolaKmETempi;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkCalcolaKmETempi = value;
			val = _lnkCalcolaKmETempi;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblCalcolaKmETempi")]
	protected virtual IboWebLabel lblCalcolaKmETempi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkOttimizzazione
	{
		[CompilerGenerated]
		get
		{
			return _lnkOttimizzazione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnOttimizzazione_Click;
			IboWebLinkButton val = _lnkOttimizzazione;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkOttimizzazione = value;
			val = _lnkOttimizzazione;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblOttimizzazione")]
	protected virtual IboWebLabel lblOttimizzazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkPCSPiuLontano
	{
		[CompilerGenerated]
		get
		{
			return _lnkPCSPiuLontano;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnPCSPiuLontano_Click;
			IboWebLinkButton val = _lnkPCSPiuLontano;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkPCSPiuLontano = value;
			val = _lnkPCSPiuLontano;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSPiuLontano")]
	protected virtual IboWebLabel lblPCSPiuLontano
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCorrispondente")]
	protected virtual Panel pnlCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispIstruzioni")]
	protected virtual IboWebLabel lblCorrispIstruzioni
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

	[field: AccessedThroughProperty("pnlVettoreMigliore")]
	protected virtual Panel pnlVettoreMigliore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlVettoriMigliori")]
	protected virtual Panel pnlVettoriMigliori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoVettoriMigliori")]
	protected virtual ListBox ElencoVettoriMigliori
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.VIAGGI";
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
			((Control)TpRicavi).Visible = !base.SessionEnvironment.ApplicationParams.ACTMode();
		}
		if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "M", false) == 0)
		{
			((RadComboBox)cmbMotricePianificata).AutoPostBack = true;
			((RadComboBox)cmbAutista1Pianificato).AutoPostBack = false;
			((RadComboBox)cmbMotricePianificata).SelectedIndexChanged += new RadComboBoxSelectedIndexChangedEventHandler(cmbMotricePianificata_SelectedIndexChanged);
		}
		else if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.ViaggiDipendenzaTrasportatore(), "A", false) == 0)
		{
			((RadComboBox)cmbMotricePianificata).AutoPostBack = false;
			((RadComboBox)cmbAutista1Pianificato).AutoPostBack = true;
			((RadComboBox)cmbAutista1Pianificato).SelectedIndexChanged += new RadComboBoxSelectedIndexChangedEventHandler(cmbAutista1Pianificato_SelectedIndexChanged);
		}
		else
		{
			((RadComboBox)cmbMotricePianificata).AutoPostBack = false;
			((RadComboBox)cmbAutista1Pianificato).AutoPostBack = false;
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
				val = CheckVettoreMotrice(cmbMotricePianificata.ObjValue.ToString(), ref Vettore, ref rsMess);
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
				val = CheckVettoreAutista(cmbAutista1Pianificato.ObjValue.ToString(), ref Vettore2, ref rsMess);
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
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
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
			IboGridView objGridView = grdViaggiSpedizioni;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdViaggiSpedizioni = objGridView;
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#VIAGGI", "SELECT * FROM GRD_DOC_Viaggi_Spedizioni WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiSpedizioni).ID, ((Control)tlbgrdViaggiSpedizioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdViaggiSpedizioniRaggru;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdViaggiSpedizioniRaggru = objGridView;
			string sSqlStatement = CreateQueryForSpedizioniRaggru("<%IDVIAGGIO%>");
			iboInternalGridConfig.Build("DM.DOC.CONSEGNE#VIAGGI", sSqlStatement, "", "", ((Control)grdViaggiSpedizioniRaggru).ID, ((Control)tlbgrdViaggiSpedizioniRaggru).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdViaggiIstruzioni;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdViaggiIstruzioni = objGridView;
			iboInternalGridConfig.Build("DM.DOC.VIAGGI.ISTRUZIONI", "SELECT * FROM GRD_DOC_Viaggi_Istruzioni WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiIstruzioni).ID, ((Control)tlbgrdViaggiIstruzioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdRicavi;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdRicavi = objGridView;
			iboInternalGridConfig.Build("DM.DOC.VIAGGI.RICAVI", "SELECT * FROM GRD_VIAGGI_RICAVI WHERE IDVIAGGIO='<%IDVIAGGIO%>'", "", "", ((Control)grdRicavi).ID, ((Control)tlbgrdRicavi).ID);
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Invalid comparison between Unknown and I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Invalid comparison between Unknown and I4
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Invalid comparison between Unknown and I4
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Invalid comparison between Unknown and I4
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Invalid comparison between Unknown and I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Invalid comparison between Unknown and I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Invalid comparison between Unknown and I4
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Invalid comparison between Unknown and I4
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Invalid comparison between Unknown and I4
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Invalid comparison between Unknown and I4
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Invalid comparison between Unknown and I4
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Invalid comparison between Unknown and I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Invalid comparison between Unknown and I4
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Invalid comparison between Unknown and I4
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Invalid comparison between Unknown and I4
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Invalid comparison between Unknown and I4
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		int num = 0;
		DateTime minValue = DateTime.MinValue;
		string text2 = "";
		string text3 = "N";
		DataTable dataTable = null;
		string text4 = "";
		string text5 = "";
		decimal num2 = default(decimal);
		int num3 = 0;
		string text6 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0))
			{
				Viaggio Viaggio = new Viaggio();
				Viaggio viaggio = Viaggio;
				viaggio.IdViaggio = txtIdViaggio.ObjValue.ToString();
				viaggio.TipoViaggio = cmbTipoViaggio.ObjValue.ToString();
				if (Operators.CompareString(txtDataPartenzaPianificata.ObjValue.ToString(), "", false) != 0)
				{
					viaggio.DataPartenzaPianificata = txtDataPartenzaPianificata.getDateValue;
				}
				if (Operators.CompareString(txtDataArrivoPianificata.ObjValue.ToString(), "", false) != 0)
				{
					viaggio.DataArrivoPianificata = txtDataArrivoPianificata.getDateValue;
				}
				viaggio.Autista1Pianificato = cmbAutista1Pianificato.ObjValue.ToString();
				viaggio.Autista2Pianificato = cmbAutista2Pianificato.ObjValue.ToString();
				viaggio.MotricePianificata = cmbMotricePianificata.ObjValue.ToString();
				viaggio.Rimorchio1Pianificato = cmbRimorchio1Pianificato.ObjValue.ToString();
				viaggio.Contenitore1Pianificato = cmbContenitore1Pianificato.ObjValue.ToString();
				viaggio.Rimorchio2Pianificato = cmbRimorchio2Pianificato.ObjValue.ToString();
				viaggio.Contenitore2Pianificato = cmbContenitore2Pianificato.ObjValue.ToString();
				viaggio.Cliente = cmbCliente.ObjValue.ToString();
				viaggio.TipoSpedizione = cmbTipoSpedizione.ObjValue.ToString();
				viaggio.TipoMerce = cmbTipoMerce.ObjValue.ToString();
				viaggio.Vettore = cmbVettore.ObjValue.ToString();
				viaggio.PCSPartenza = cmbPCSPartenza.ObjValue.ToString();
				viaggio.PCSArrivo = cmbPCSArrivo.ObjValue.ToString();
				viaggio.Note1 = txtNote1.ObjValue.ToString();
				viaggio.Note2 = txtNote2.ObjValue.ToString();
				viaggio.FillerAlfa9 = txtFillerAlfa9.ObjValue.ToString();
				viaggio = null;
				val2 = Viaggio_Inserisci_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					lblStatoValue.ObjValue = "10";
					up_tpGen.Update();
					if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0 || Operators.CompareString(txtDataPartenzaPianificata.ObjValue.ToString(), "", false) == 0)
					{
						goto IL_0d12;
					}
					text4 = "SELECT C.RAGIONESOCIALE FROM VIAGGI V INNER JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO INNER JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
					text4 = text4 + "WHERE V.IDVIAGGIO = " + base.DbConn.SQLFormatString(Viaggio.IdViaggio);
					val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (dataTable.Rows.Count > 0)
						{
							text5 = dataTable.Rows[0]["RAGIONESOCIALE"].ToString();
						}
						dataTable = null;
						text4 = "";
						text4 = "SELECT PORTATAPALLET FROM MEZZI WHERE CODICE = " + base.DbConn.SQLFormatString(Viaggio.MotricePianificata);
						val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (dataTable.Rows.Count > 0)
							{
								num2 = Conversions.ToDecimal(dataTable.Rows[0]["PORTATAPALLET"]);
							}
							dataTable = null;
							text2 = "";
							text4 = "";
							text4 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + " ORDER BY HST_DATAINSERIMENTO DESC";
							val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else if (dataTable.Rows.Count > 0)
							{
								minValue = Conversions.ToDate(dataTable.Rows[0]["HST_DATAINSERIMENTO"]);
								text2 = Conversions.ToString(dataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
								num = Conversions.ToInteger(dataTable.Rows[0]["HSt_Id"]);
								DateTime now = DateAndTime.Now;
								if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now, minValue, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
								{
									text6 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
									text6 = text6 + "VALUES (" + base.DbConn.SQLFormatString(text3) + ", " + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue)) + ", ";
									string[] obj = new string[7] { text6, null, null, null, null, null, null };
									DBConnection dbConn = base.DbConn;
									string text7 = txtIdViaggio.ObjValue.ToString();
									obj[1] = dbConn.SQLFormatNumber(ref text7);
									obj[2] = ", ";
									obj[3] = base.DbConn.SQLFormatString(text5);
									obj[4] = ",";
									obj[5] = base.DbConn.SQLFormatNumber(ref num2);
									obj[6] = ") ";
									text6 = string.Concat(obj);
									val2 = base.DbConn.SqlExec(text6, ref rsMess);
									if ((int)val2 <= 0)
									{
										goto IL_0d12;
									}
									val = val2;
								}
								else
								{
									if (Operators.CompareString(text3, text2, false) == 0)
									{
										goto IL_0d12;
									}
									text6 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + base.DbConn.SQLFormatString(text3) + ", Hst_Tag = '' ";
									text6 = text6 + "WHERE HSt_Id = " + base.DbConn.SQLFormatNumber(ref num);
									val2 = base.DbConn.SqlExec(text6, ref rsMess);
									if ((int)val2 <= 0)
									{
										goto IL_0d12;
									}
									val = val2;
								}
							}
							else
							{
								text6 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
								text6 = text6 + "VALUES (" + base.DbConn.SQLFormatString(text3) + ", " + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue)) + ", ";
								string[] obj2 = new string[7] { text6, null, null, null, null, null, null };
								DBConnection dbConn2 = base.DbConn;
								string text7 = txtIdViaggio.ObjValue.ToString();
								obj2[1] = dbConn2.SQLFormatNumber(ref text7);
								obj2[2] = ", ";
								obj2[3] = base.DbConn.SQLFormatString(text5);
								obj2[4] = ",";
								obj2[5] = base.DbConn.SQLFormatNumber(ref num2);
								obj2[6] = ") ";
								text6 = string.Concat(obj2);
								val2 = base.DbConn.SqlExec(text6, ref rsMess);
								if ((int)val2 <= 0)
								{
									goto IL_0d12;
								}
								val = val2;
							}
						}
					}
				}
			}
			else if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0)
			{
				val2 = Viaggio_Cancella_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0cfa;
				}
				val = val2;
			}
			else
			{
				val2 = base.SaveData(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (!((Operators.CompareString(txtDataPartenzaPianificata.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(cmbMotricePianificata.ObjValue.ToString(), "", false) != 0)))
					{
						goto IL_0cfa;
					}
					text4 = "SELECT C.RAGIONESOCIALE, V.STATO FROM VIAGGI V LEFT JOIN SPEDIZIONI S ON V.IDVIAGGIO = S.IDVIAGGIO LEFT JOIN CORRISPONDENTI C ON C.CODICE = S.CORRISPONDENTE ";
					text4 = text4 + "WHERE V.IDVIAGGIO = " + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString());
					val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (dataTable.Rows.Count > 0)
						{
							text5 = dataTable.Rows[0]["RAGIONESOCIALE"].ToString();
							num3 = Conversions.ToInteger(dataTable.Rows[0]["STATO"].ToString());
							if (num3 > 10)
							{
								text3 = "Y";
							}
						}
						dataTable = null;
						text4 = "";
						text4 = "SELECT PORTATAPALLET FROM VIAGGI V INNER JOIN MEZZI M ON V.MOTRICEPIANIFICATA = M.CODICE WHERE V.IDVIAGGIO = " + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString());
						val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (dataTable.Rows.Count > 0)
							{
								num2 = Conversions.ToDecimal(dataTable.Rows[0]["PORTATAPALLET"]);
							}
							text4 = "";
							text4 = "SELECT * FROM CST_LUC_HSTSTATOVIAGGITX WHERE HStaVia_Luc_NumViaggio = " + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + " ORDER BY HST_DATAINSERIMENTO DESC";
							val2 = base.DbConn.OpenDataTable(text4, ref dataTable, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else if (dataTable.Rows.Count > 0)
							{
								minValue = Conversions.ToDate(dataTable.Rows[0]["HST_DATAINSERIMENTO"]);
								text2 = Conversions.ToString(dataTable.Rows[0]["HStaVia_Luc_StatoViaggioDelsy"]);
								num = Conversions.ToInteger(dataTable.Rows[0]["HSt_Id"]);
								DateTime now2 = DateAndTime.Now;
								if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, now2, minValue, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 5)
								{
									text6 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
									text6 = text6 + "VALUES (" + base.DbConn.SQLFormatString(text3) + ", " + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue)) + ", ";
									string[] obj3 = new string[7] { text6, null, null, null, null, null, null };
									DBConnection dbConn3 = base.DbConn;
									string text7 = txtIdViaggio.ObjValue.ToString();
									obj3[1] = dbConn3.SQLFormatNumber(ref text7);
									obj3[2] = ", ";
									obj3[3] = base.DbConn.SQLFormatString(text5);
									obj3[4] = ",";
									obj3[5] = base.DbConn.SQLFormatNumber(ref num2);
									obj3[6] = ") ";
									text6 = string.Concat(obj3);
									val2 = base.DbConn.SqlExec(text6, ref rsMess);
									if ((int)val2 <= 0)
									{
										goto IL_0cfa;
									}
									val = val2;
								}
								else
								{
									if (Operators.CompareString(text3, text2, false) == 0)
									{
										goto IL_0cfa;
									}
									text6 = "UPDATE CST_LUC_HSTSTATOVIAGGITX SET HStaVia_Luc_StatoViaggioDelsy = " + base.DbConn.SQLFormatString(text3) + ", Hst_Tag = '' ";
									text6 = text6 + "WHERE HSt_Id = " + base.DbConn.SQLFormatNumber(ref num);
									val2 = base.DbConn.SqlExec(text6, ref rsMess);
									if ((int)val2 <= 0)
									{
										goto IL_0cfa;
									}
									val = val2;
								}
							}
							else
							{
								text6 = "INSERT INTO CST_LUC_HSTSTATOVIAGGITX (HStaVia_Luc_StatoViaggioDelsy, HStaVia_Luc_DataPartenza, HStaVia_Luc_NumViaggio, HStaVia_Luc_TransitPoint, HStaVia_Luc_PortataColonne) ";
								text6 = text6 + "VALUES (" + base.DbConn.SQLFormatString(text3) + ", " + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue)) + ", ";
								string[] obj4 = new string[7] { text6, null, null, null, null, null, null };
								DBConnection dbConn4 = base.DbConn;
								string text7 = txtIdViaggio.ObjValue.ToString();
								obj4[1] = dbConn4.SQLFormatNumber(ref text7);
								obj4[2] = ", ";
								obj4[3] = base.DbConn.SQLFormatString(text5);
								obj4[4] = ",";
								obj4[5] = base.DbConn.SQLFormatNumber(ref num2);
								obj4[6] = ") ";
								text6 = string.Concat(obj4);
								val2 = base.DbConn.SqlExec(text6, ref rsMess);
								if ((int)val2 <= 0)
								{
									goto IL_0cfa;
								}
								val = val2;
							}
						}
					}
				}
			}
			goto end_IL_0046;
			IL_0cfa:
			val2 = WMSSave(ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0d12;
			}
			val = val2;
			goto end_IL_0046;
			IL_0d12:
			val = (FXRETURN)0;
			end_IL_0046:;
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
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
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
				cmbTipoViaggio.ReadOnly = true;
				((RadComboBox)cmbTipoViaggio).AutoPostBack = false;
				if ((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0))
				{
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
							if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
							{
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(cmbMotricePianificata.ObjValue)))
								{
									htxtMotricePianificataSave.ObjValue = RuntimeHelpers.GetObjectValue(cmbMotricePianificata.ObjValue);
								}
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue)))
								{
									htxtDataPartenzaPianificataSave.ObjValue = RuntimeHelpers.GetObjectValue(txtDataPartenzaPianificata.ObjValue);
								}
							}
							goto IL_0215;
						}
						val = val2;
					}
				}
				else
				{
					if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
					{
						goto IL_0215;
					}
					cmbTipoViaggio.ReadOnly = false;
					if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
					{
						goto IL_0215;
					}
					((RadComboBox)cmbTipoViaggio).AutoPostBack = true;
					val2 = GestisciDefaultDiTipoViaggio(ForceValue: false, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = CheckPCS(Partenza: true, arrivo: true, ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_0215;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0019;
			IL_0215:
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
			{
				btnCalcola.Visible = true;
				btnChiudiEPartiViaggio.Visible = true;
				btnVettoreMigliore.Visible = true;
				btnChiudi.Visible = true;
				btnMapFunctions.Visible = true;
			}
			else
			{
				btnCalcola.Visible = false;
				btnChiudiEPartiViaggio.Visible = false;
				btnVettoreMigliore.Visible = false;
				btnChiudi.Visible = false;
				btnMapFunctions.Visible = false;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0 || Operators.CompareString(cmbVettore.ObjValue.ToString(), "", false) != 0)
			{
				goto IL_00a2;
			}
			string text = "DELETE FROM Viaggi_Costi WHERE IDViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + " AND UtenteForzatura IS NULL";
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_00a2;
			}
			val = val2;
			goto end_IL_0005;
			IL_00a2:
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
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

	protected override FXRETURN BeforeLoadDataInGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Viaggio_DeterminaSequenzaSpedizioni_Invoker instance = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string? idViaggio = txtIdViaggio.ObjValue.ToString();
			string RetQueryToApply = "";
			string rsmess = "";
			instance.RunProc(objApiContext, idViaggio, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			val2 = base.BeforeLoadDataInGrid(ref rsMess);
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

	protected FXRETURN GestisciDefaultDiTipoViaggio(bool ForceValue, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
			{
				goto IL_03c9;
			}
			if (!((Page)this).IsPostBack && Operators.CompareString(cmbTipoViaggio.ObjValue.ToString(), "", false) == 0)
			{
				cmbTipoViaggio.ObjValue = base.ApplicationDefault.TipoViaggio_Default();
			}
			if (Operators.CompareString(cmbTipoViaggio.ObjValue.ToString(), "", false) == 0)
			{
				goto IL_03c9;
			}
			Dictionary<string, string> DictionaryDefault = null;
			val2 = Viaggio_TipoViaggio_Default.RunProc(CreateApiContext(), cmbTipoViaggio.ObjValue.ToString(), ref DictionaryDefault, ref rsMess);
			if ((int)val2 <= 0)
			{
				foreach (string key in DictionaryDefault.Keys)
				{
					IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName((Control)(object)this, key);
					if (iIboWebComponentByFieldName == null || !(Operators.CompareString(iIboWebComponentByFieldName.ObjValue.ToString(), "", false) == 0 || ForceValue))
					{
						continue;
					}
					if ((int)iIboWebComponentByFieldName.FieldDataType == 0)
					{
						if (!((Page)this).IsPostBack)
						{
							iIboWebComponentByFieldName.ObjValue = DictionaryDefault[key];
						}
						else if (iIboWebComponentByFieldName is IIboDropdownList)
						{
							IIboDropdownList val3 = (IIboDropdownList)iIboWebComponentByFieldName;
							string sItemValue = DictionaryDefault[key];
							string rsMess2 = "";
							ComboSelectedItem(val3, sItemValue, ref rsMess2);
						}
					}
					else if ((int)iIboWebComponentByFieldName.FieldDataType == 1)
					{
						iIboWebComponentByFieldName.ObjValue = Conversions.ToDecimal(DictionaryDefault[key]);
					}
					else if ((int)iIboWebComponentByFieldName.FieldDataType == 2)
					{
						if (Operators.CompareString(DictionaryDefault[key].ToUpper(), "GETDATE", false) == 0)
						{
							iIboWebComponentByFieldName.ObjValue = DateAndTime.Now.Date;
						}
						else if (Operators.CompareString(DictionaryDefault[key].ToUpper().Trim().Replace(" ", ""), "GETDATE+1", false) == 0)
						{
							iIboWebComponentByFieldName.ObjValue = DateAndTime.DateAdd((DateInterval)4, 1.0, DateAndTime.Now.Date);
						}
						else if (Operators.CompareString(DictionaryDefault[key].ToUpper().Trim().Replace(" ", ""), "GETDATE+2", false) == 0)
						{
							iIboWebComponentByFieldName.ObjValue = DateAndTime.DateAdd((DateInterval)4, 2.0, DateAndTime.Now.Date);
						}
						else if (Operators.CompareString(DictionaryDefault[key].ToUpper().Trim().Replace(" ", ""), "GETDATE+3", false) == 0)
						{
							iIboWebComponentByFieldName.ObjValue = DateAndTime.DateAdd((DateInterval)4, 3.0, DateAndTime.Now.Date);
						}
						else if (Operators.CompareString(DictionaryDefault[key].ToUpper().Trim().Replace(" ", ""), "", false) == 0)
						{
							iIboWebComponentByFieldName.ObjValue = "";
						}
					}
				}
				goto IL_03c9;
			}
			val = val2;
			goto end_IL_0005;
			IL_03c9:
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

	private FXRETURN CheckPCS(bool Partenza, bool arrivo, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			string text = cmbPCSPartenza.ObjValue.ToString();
			string text2 = cmbPCSArrivo.ObjValue.ToString();
			string ZonaTariffaPassiva = "";
			string ZonaTariffaAttiva = "";
			string ZonaTariffaPassiva2 = "";
			string ZonaTariffaAttiva2 = "";
			if (!Partenza || !((Operators.CompareString(cmbZonaPartenza.ObjValue.ToString(), "", false) == 0) | (Operators.CompareString(cmbZonaPartenzaTariffaAttiva.ObjValue.ToString(), "", false) == 0)) || Operators.CompareString(text, "", false) == 0)
			{
				goto IL_01e2;
			}
			AppApiContext objApiContext = CreateApiContext();
			string? tipoMerce = cmbTipoMerce.ObjValue.ToString();
			string ZonaSpedizione = "";
			val = PCS_DeterminaZone.RunProc(objApiContext, text, tipoMerce, ref ZonaSpedizione, ref ZonaTariffaAttiva, ref ZonaTariffaPassiva, ref rsmess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(cmbZonaPartenza.ObjValue.ToString(), "", false) == 0)
				{
					if (!((Page)this).IsPostBack)
					{
						cmbZonaPartenza.ObjValue = ZonaTariffaPassiva;
					}
					else
					{
						IboWebComboTlk objCombo = cmbZonaPartenza;
						string sItemValue = ZonaTariffaPassiva;
						ZonaSpedizione = "";
						ComboSelectedItem((IIboDropdownList)(object)objCombo, sItemValue, ref ZonaSpedizione);
						getParentUpdatePanel((Control)(object)cmbZonaPartenza).Update();
					}
				}
				if (Operators.CompareString(cmbZonaPartenzaTariffaAttiva.ObjValue.ToString(), "", false) == 0)
				{
					if (!((Page)this).IsPostBack)
					{
						cmbZonaPartenzaTariffaAttiva.ObjValue = ZonaTariffaAttiva;
					}
					else
					{
						IboWebComboTlk objCombo2 = cmbZonaPartenzaTariffaAttiva;
						string sItemValue2 = ZonaTariffaAttiva;
						ZonaSpedizione = "";
						ComboSelectedItem((IIboDropdownList)(object)objCombo2, sItemValue2, ref ZonaSpedizione);
						getParentUpdatePanel((Control)(object)cmbZonaPartenzaTariffaAttiva).Update();
					}
				}
				goto IL_01e2;
			}
			val2 = val;
			goto end_IL_0005;
			IL_01e2:
			if (!arrivo || !((Operators.CompareString(cmbZonaArrivo.ObjValue.ToString(), "", false) == 0) | (Operators.CompareString(cmbZonaArrivoTariffaAttiva.ObjValue.ToString(), "", false) == 0)) || Operators.CompareString(text2, "", false) == 0)
			{
				goto IL_0374;
			}
			AppApiContext objApiContext2 = CreateApiContext();
			string? tipoMerce2 = cmbTipoMerce.ObjValue.ToString();
			ZonaSpedizione = "";
			val = PCS_DeterminaZone.RunProc(objApiContext2, text2, tipoMerce2, ref ZonaSpedizione, ref ZonaTariffaAttiva2, ref ZonaTariffaPassiva2, ref rsmess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(cmbZonaArrivo.ObjValue.ToString(), "", false) == 0)
				{
					if (!((Page)this).IsPostBack)
					{
						cmbZonaArrivo.ObjValue = ZonaTariffaPassiva2;
					}
					else
					{
						IboWebComboTlk objCombo3 = cmbZonaArrivo;
						string sItemValue3 = ZonaTariffaPassiva2;
						ZonaSpedizione = "";
						ComboSelectedItem((IIboDropdownList)(object)objCombo3, sItemValue3, ref ZonaSpedizione);
						getParentUpdatePanel((Control)(object)cmbZonaArrivo).Update();
					}
				}
				if (Operators.CompareString(cmbZonaArrivoTariffaAttiva.ObjValue.ToString(), "", false) == 0)
				{
					if (!((Page)this).IsPostBack)
					{
						cmbZonaArrivoTariffaAttiva.ObjValue = ZonaTariffaAttiva2;
					}
					else
					{
						IboWebComboTlk objCombo4 = cmbZonaArrivoTariffaAttiva;
						string sItemValue4 = ZonaTariffaAttiva2;
						ZonaSpedizione = "";
						ComboSelectedItem((IIboDropdownList)(object)objCombo4, sItemValue4, ref ZonaSpedizione);
						getParentUpdatePanel((Control)(object)cmbZonaArrivoTariffaAttiva).Update();
					}
				}
				goto IL_0374;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0374:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	private void cmbMotricePianificata_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
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
			if (Operators.CompareString(cmbMotricePianificata.ObjValue.ToString(), "", false) == 0)
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
				cmbVettore.ReadOnly = false;
			}
			else
			{
				string text = "SELECT Trasportatore FROM Mezzi WHERE Codice=" + base.DbConn.SQLFormatString(cmbMotricePianificata.ObjValue.ToString());
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

	private void cmbAutista1Pianificato_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
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
			if (Operators.CompareString(cmbAutista1Pianificato.ObjValue.ToString(), "", false) == 0)
			{
				ComboSelectedItem((IIboDropdownList)(object)cmbVettore, "", ref rsMess);
				cmbVettore.ReadOnly = false;
			}
			else
			{
				string text = "SELECT Trasportatore FROM Autisti WHERE Codice=" + base.DbConn.SQLFormatString(cmbAutista1Pianificato.ObjValue.ToString());
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

	private void btnChiudi_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			object objParams = null;
			val2 = ChiusuraViaggio(ref objParams, ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void lnkChiudiEParti_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			object objParams = null;
			val2 = ChiusuraEPartenzaViaggio(ref objParams, ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void cpSpedizioni_Title_Caption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			cpSpedizioni_Title_Caption.Enabled = false;
			cpSpedizioni_Title_Caption_Raggru.Enabled = true;
			((Control)cpSpedizioni_Body).Visible = true;
			((Control)cpSpedizioni_Body_Raggru).Visible = false;
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
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			cpSpedizioni_Title_Caption.Enabled = true;
			cpSpedizioni_Title_Caption_Raggru.Enabled = false;
			((Control)cpSpedizioni_Body).Visible = false;
			((Control)cpSpedizioni_Body_Raggru).Visible = true;
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
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
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
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
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
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdRicavi).ID];
			string rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			IboInternalGridConfig objInternalGridConfig2 = GridConfigList[((Control)grdCosti).ID];
			rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsMess2);
			IboInternalGridConfig objInternalGridConfig3 = GridConfigList[((Control)grdViaggiSpedizioni).ID];
			rsMess2 = "";
			InternalGridAggiornaSingola(ref objInternalGridConfig3, ref rsMess2);
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

	private void cmbTipoViaggio_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
			{
				val2 = GestisciDefaultDiTipoViaggio(ForceValue: true, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				val2 = CheckPCS(Partenza: true, arrivo: true, ref rsMess);
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

	private void cmbPCSPartenza_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
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
		string rsmess = "";
		try
		{
			CallStackAdd();
			val2 = CheckPCS(Partenza: true, arrivo: false, ref rsmess);
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

	private void cmbPCSArrivo_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
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
		string rsmess = "";
		try
		{
			CallStackAdd();
			val2 = CheckPCS(Partenza: false, arrivo: true, ref rsmess);
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

	private void btnVettoreMigliore_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
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
			StringCollection ListOfVettori = new StringCollection();
			val2 = Viaggi_DeterminaElencoVettoriDaViaggio_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), ref ListOfVettori, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string VettoreMigliore = "";
			List<Simulation_Result> VettoriMigliori = null;
			val2 = Viaggi_DeterminaVettoreMigliore_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), ListOfVettori, ref VettoreMigliore, ref VettoriMigliori, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (VettoriMigliori.Count == 1)
			{
				string text = "UPDATE Viaggi SET Vettore=" + base.DbConn.SQLFormatString(VettoreMigliore) + ", ";
				text = text + "DatAgg=" + base.DbConn.GetDate() + ", ";
				text = text + "UteAgg=" + base.DbConn.SQLFormatString(base.WFIUser) + " ";
				text = text + "WHERE IDViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + " ";
				val2 = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				ViaggiAgganciaTariffaPassiva_Invoker instance = ViaggiAgganciaTariffaPassiva_Invoker.Instance;
				AppApiContext objApiContext = CreateApiContext();
				string? idViaggio = txtIdViaggio.ObjValue.ToString();
				string Warning = "";
				string rsmess = "";
				instance.RunProc(objApiContext, idViaggio, ref Warning, ref rsmess);
				val2 = Reload(ref rsMess);
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdRicavi).ID];
				rsmess = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsmess);
				IboInternalGridConfig objInternalGridConfig2 = GridConfigList[((Control)grdCosti).ID];
				rsmess = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsmess);
				object obj = null;
				base.DbConn.DoSql("SELECT RagioneSociale FROM Trasportatori WHERE CODICE=" + base.DbConn.SQLFormatString(VettoreMigliore), ref obj, ref rsMess);
				WriteInfoMessage(TranslateMessage("XXX", "Il vettore migliore per questo viaggio è {0} - {1}", VettoreMigliore, obj.ToString()), ShowAsNotification: true);
				base.MasterPage.ContentUpdatePanel.Update();
			}
			else
			{
				if (VettoriMigliori.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Non è stato possibile recuperare nessun vettore per il viaggio in oggetto");
					return;
				}
				if (VettoriMigliori.Count > 1)
				{
					((ListControl)ElencoVettoriMigliori).Items.Clear();
					foreach (Simulation_Result item in VettoriMigliori)
					{
						if (decimal.Compare(item.TotaleCosto, 0m) > 0)
						{
							object obj2 = null;
							base.DbConn.DoSql("SELECT RagioneSociale FROM Trasportatori WHERE CODICE=" + base.DbConn.SQLFormatString(item.Vettore), ref obj2, ref rsMess);
							ListItem val3 = new ListItem();
							val3.Value = item.Vettore;
							val3.Text = Strings.Mid(obj2.ToString(), 1, 40).PadRight(40, ' ') + " (" + item.TotaleCosto.ToString("0.00") + ")";
							((ListControl)ElencoVettoriMigliori).Items.Add(val3);
						}
					}
					MasterPopupFormOpen(TranslateMessage("XXX", "Risultati della ricerca dei vettori migliori"), (Control)(object)pnlVettoreMigliore, "VETTOREMIGLIORE");
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

	private void TcMain_ActiveTabChangedUpdate()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
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
			if (Operators.CompareString(lblCosti_PCSPartenza_Descrizione.ObjValue.ToString(), cmbPCSPartenza.Text, false) != 0)
			{
				lblCosti_PCSPartenza_Descrizione.ObjValue = cmbPCSPartenza.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_PCSArrivo_Descrizione.ObjValue.ToString(), cmbPCSArrivo.Text, false) != 0)
			{
				lblCosti_PCSArrivo_Descrizione.ObjValue = cmbPCSArrivo.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblCosti_ZonaArrivo_Descrizione.ObjValue.ToString(), cmbZonaArrivo.Text, false) != 0)
			{
				lblCosti_ZonaArrivo_Descrizione.ObjValue = cmbZonaArrivo.Text;
				up_tp_Costi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_Cliente_Descrizione.ObjValue.ToString(), cmbCliente.Text, false) != 0)
			{
				lblRicavi_Cliente_Descrizione.ObjValue = cmbCliente.Text;
				up_tp_Ricavi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_TipoSpedizione_Descrizione.ObjValue.ToString(), cmbTipoSpedizione.Text, false) != 0)
			{
				lblRicavi_TipoSpedizione_Descrizione.ObjValue = cmbTipoSpedizione.Text;
				up_tp_Ricavi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_TipoMerce_Descrizione.ObjValue.ToString(), cmbTipoMerce.Text, false) != 0)
			{
				lblRicavi_TipoMerce_Descrizione.ObjValue = cmbTipoMerce.Text;
				up_tp_Ricavi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_PCSPartenza_Descrizione.ObjValue.ToString(), cmbPCSPartenza.Text, false) != 0)
			{
				lblRicavi_PCSPartenza_Descrizione.ObjValue = cmbPCSPartenza.Text;
				up_tp_Ricavi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_PCSArrivo_Descrizione.ObjValue.ToString(), cmbPCSArrivo.Text, false) != 0)
			{
				lblRicavi_PCSArrivo_Descrizione.ObjValue = cmbPCSArrivo.Text;
				up_tp_Ricavi_InfoTestata.Update();
			}
			if (Operators.CompareString(lblRicavi_ZonaArrivo_Descrizione.ObjValue.ToString(), cmbZonaArrivoTariffaAttiva.Text, false) != 0)
			{
				lblRicavi_ZonaArrivo_Descrizione.ObjValue = cmbZonaArrivoTariffaAttiva.Text;
				up_tp_Ricavi_InfoTestata.Update();
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

	private void btnPCSPiuLontano_Click(object sender, EventArgs e)
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = Viaggio_DeterminaPCSPiuLontano_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), base.SessionEnvironment.WebUser.WebUserInfo.Codice, base.SessionEnvironment.WebUser.WebUserInfo.DecryptedPassword(), ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string rsMess2 = "";
			Reload(ref rsMess2);
			base.MasterPage.ContentUpdatePanel.Update();
			WriteInfoMessage("Aggiornamento del punto di arrivo del viaggio con il PCS più lontano eseguito correttamente", ShowAsNotification: true);
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
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtIdViaggio.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "IdViaggio", "Text", ref PropertyValue);
			if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckInserimentoCostiRicavi(txtIdViaggio.ObjValue.ToString(), "C", ref rsMess);
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
				val2 = CheckInserimentoCostiRicavi(txtIdViaggio.ObjValue.ToString(), "R", ref rsMess);
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
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((object)tlb).Equals((object?)tlbgrdCosti))
			{
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "C", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00e3;
				}
				val = val2;
			}
			else
			{
				if (!((object)tlb).Equals((object?)tlbgrdRicavi))
				{
					goto IL_00e3;
				}
				val2 = CheckModificaCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00e3;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00e3:
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
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
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
					goto IL_0114;
				}
				val = val2;
			}
			else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdRicavi).ID, false) == 0)
			{
				val2 = CheckCancellazioneCostiRicavi(funcArg.Data.Item("Id").get_FieldValues(0).ToString(), "R", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0114;
				}
				val = val2;
			}
			else if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Cancella(ref funcArg, ref rsMess) <= 0)
			{
				goto IL_0114;
			}
			goto end_IL_0012;
			IL_0114:
			val = (FXRETURN)0;
			end_IL_0012:;
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
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Invalid comparison between Unknown and I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Invalid comparison between Unknown and I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Invalid comparison between Unknown and I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
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
			else if (Operators.CompareString(e.CommandName.ToUpper(), "ASSOCIA", false) == 0)
			{
				if (Conversions.ToInteger(lblStatoValue.ObjValue) > 20)
				{
					rsMess = TranslateMessage("XXX", "Lo stato del viaggio non consente l'operazione richiesta.");
				}
				else
				{
					if (Operators.CompareString(txtIdViaggioOBC.ObjValue.ToString(), "", false) == 0)
					{
						NumeroBolla.ObjValue = "";
						DataBolla.ObjValue = "";
						NumeroOrdine.ObjValue = "";
						DataOrdine.ObjValue = "";
						DataConsegna.ObjValue = "";
						IboWebComboTlk cliente = Cliente;
						string? sItemValue = cmbCliente.ObjValue.ToString();
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)cliente, sItemValue, ref rsMess2);
						IboWebComboTlk zonaSpedizione = ZonaSpedizione;
						rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)zonaSpedizione, "", ref rsMess2);
						MasterPopupFormOpen(TranslateMessage("XXX", "Filtro Ricerca Spedizioni"), (Control)(object)pnlFiltro, "FILTROSPEDIZIONI");
						goto IL_0454;
					}
					rsMess = TranslateMessage("XXX", "Impossibile associare spedizioni a un viaggio creato dal terminale.");
				}
			}
			else if (Operators.CompareString(e.CommandName.ToUpper(), "ASSOCIABC", false) == 0)
			{
				if (Conversions.ToInteger(lblStatoValue.ObjValue) > 20)
				{
					rsMess = TranslateMessage("XXX", "Lo stato del viaggio non consente l'operazione richiesta.");
				}
				else
				{
					if (Operators.CompareString(txtIdViaggioOBC.ObjValue.ToString(), "", false) == 0)
					{
						SetIframeHeightAutoResize();
						OpenIframe("WFDOCViaggiAssociaBC.aspx", "ASSOCIABC", TranslateMessage("XXX", "Associazione spedizioni per barcode"), "WFDOCViaggiAssociaBC_Iframe");
						goto IL_0454;
					}
					rsMess = TranslateMessage("XXX", "Impossibile associare spedizioni a un viaggio creato dal terminale.");
				}
			}
			else if (Operators.CompareString(e.CommandName.ToUpper(), "DISASSOCIA", false) == 0)
			{
				val2 = DisassociaSpedizione(funcArg.Data, objInternalGridConfig.Id, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0454;
				}
				val = val2;
			}
			else if (Operators.CompareString(e.CommandName.ToUpper(), "CORRISPONDENTE", false) == 0)
			{
				if (funcArg.Data.Count != 0)
				{
					_SessionVariable["CORRISPONDENTE_UNIBOLS"] = (object)funcArg.Data;
					_SessionVariable["CORRISPONDENTE_GRD_ID"] = (object)objInternalGridConfig.Id;
					IboWebComboTlk corrispondente = Corrispondente;
					string rsMess2 = "";
					ComboSelectedItem((IIboDropdownList)(object)corrispondente, "", ref rsMess2);
					MasterPopupFormOpen("Diretta / TP", (Control)(object)pnlCorrispondente, "CORRISPONDENTE");
					goto IL_0454;
				}
				rsMess = TranslateMessage("XXX", "Selezionare almeno 1 record");
			}
			else
			{
				if (Operators.CompareString(e.CommandName.ToUpper(), "GESTISCISEQUENZA", false) != 0)
				{
					goto IL_0454;
				}
				Viaggio_DeterminaSequenzaSpedizioni_Invoker instance = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance;
				AppApiContext objApiContext = CreateApiContext();
				string? idViaggio = txtIdViaggio.ObjValue.ToString();
				string rsMess2 = "";
				val2 = instance.RunProc(objApiContext, idViaggio, ApplyQuery: true, ref rsMess2, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					string[] CampiChiave = new string[1] { "IdViaggio" };
					object[] ValoriCampiChiave = new object[1] { txtIdViaggio.ObjValue.ToString() };
					val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "GESTISCISEQUENZA", base.Translator.Translate("XXX", "Gestione della sequenza delle spedizioni (Viaggio: " + txtIdViaggio.ObjValue.ToString() + ")", new string[0]), WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, "IFrameDimension_GestioneSequenza", "DM.DOC.GESTIONE_SEQUENZA", "MODIFICA", ref rsMess);
					if ((int)val2 <= 0)
					{
						SetIframeHeightAutoResize();
						goto IL_0454;
					}
					val = val2;
				}
			}
			goto end_IL_0005;
			IL_0454:
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
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Invalid comparison between Unknown and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_02a4;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "FILTROSPEDIZIONI", false) != 0)
				{
					if (Operators.CompareString(objPopupInfo.Tag, "VETTOREMIGLIORE", false) == 0)
					{
						foreach (ListItem item in ((ListControl)ElencoVettoriMigliori).Items)
						{
							ListItem val3 = item;
							if (!val3.Selected)
							{
								continue;
							}
							string text = "UPDATE Viaggi SET Vettore=" + base.DbConn.SQLFormatString(val3.Value) + ", ";
							text = text + "DatAgg=" + base.DbConn.GetDate() + ", ";
							text = text + "UteAgg=" + base.DbConn.SQLFormatString(base.WFIUser) + " ";
							text = text + "WHERE IDViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + " ";
							val = base.DbConn.SqlExec(text, ref rsMess);
							if ((int)val <= 0)
							{
								ViaggiAgganciaTariffaPassiva_Invoker instance = ViaggiAgganciaTariffaPassiva_Invoker.Instance;
								AppApiContext objApiContext = CreateApiContext();
								string? idViaggio = txtIdViaggio.ObjValue.ToString();
								string Warning = "";
								string rsmess = "";
								instance.RunProc(objApiContext, idViaggio, ref Warning, ref rsmess);
								val = Reload(ref rsMess);
								IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdRicavi).ID];
								rsmess = "";
								InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsmess);
								IboInternalGridConfig objInternalGridConfig2 = GridConfigList[((Control)grdCosti).ID];
								rsmess = "";
								InternalGridAggiornaSingola(ref objInternalGridConfig2, ref rsmess);
								WriteInfoMessage(TranslateMessage("XXX", "Il viaggio è stato aggiornato con il vettore selezionato"), ShowAsNotification: true);
								base.MasterPage.ContentUpdatePanel.Update();
								continue;
							}
							val2 = val;
							goto end_IL_0007;
						}
					}
					goto IL_02a4;
				}
				val = RicercaSpedizioniFiltro(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_02a4;
				}
				val2 = val;
			}
			goto end_IL_0007;
			IL_02a4:
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

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			switch (Tag)
			{
			case "FILTROSPEDIZIONI":
			{
				DataKeyFieldCollection objData = (DataKeyFieldCollection)objRet;
				if (objData.Count <= 0)
				{
					break;
				}
				string Warning = "";
				val = AssociaSpedizioni(ref objData, ref Warning, ref rsMess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						WriteInfoMessage(Warning, ShowAsNotification: true);
					}
					break;
				}
				val2 = val;
				goto end_IL_0005;
			}
			case "ASSOCIABC":
			{
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
				string rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
				rsMess2 = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
				up_cpspedizioni.Update();
				break;
			}
			case "GESTISCISEQUENZA":
			{
				IboInternalGridConfig iboInternalGridConfig = null;
				iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
				iboInternalGridConfig.Attivo = true;
				InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
				iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
				iboInternalGridConfig.Attivo = true;
				InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
				up_cpspedizioni.Update();
				break;
			}
			default:
				val = base.IFrameClosed(Tag, RuntimeHelpers.GetObjectValue(objRet), ref rsMess);
				if ((int)val <= 0)
				{
					break;
				}
				val2 = val;
				goto end_IL_0005;
			}
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
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_0187;
			}
			list = new List<string>();
			int num = checked(objData[0].FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				text = objData.Item(0).get_FieldValues(i).ToString();
				list.Add(text);
				string rsmess = "";
				val = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsmess);
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
			val = AggiornaTotaliDiViaggio(ref rsMess);
			if ((int)val <= 0)
			{
				base.MasterPage.ContentUpdatePanel.Update();
				goto IL_0187;
			}
			val2 = val;
			goto end_IL_0011;
			IL_0187:
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
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
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
			val = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsMess);
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
				rsMess = TranslateMessage("XXX", "Nessuna spedizione trovata per i filtri indicati oppure spedizione già associata ad un altro viaggio");
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
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
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
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[_SessionVariable["CORRISPONDENTE_GRD_ID"].ToString()];
			dataKeyFieldCollection = (DataKeyFieldCollection)_SessionVariable["CORRISPONDENTE_UNIBOLS"];
			if (dataKeyFieldCollection.Count <= 0)
			{
				goto IL_01ed;
			}
			list = new List<string>();
			checked
			{
				if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdViaggiSpedizioni).ID, false) == 0)
				{
					int num2 = dataKeyFieldCollection[0].FieldValuesCount - 1;
					for (num = 0; num <= num2; num++)
					{
						list.Add(dataKeyFieldCollection.Item(0).get_FieldValues(num).ToString());
					}
					goto IL_0125;
				}
				if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdViaggiSpedizioniRaggru).ID, false) != 0)
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
			IL_01ed:
			val2 = (FXRETURN)0;
			goto end_IL_0026;
			IL_0184:
			iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
			InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
			getParentUpdatePanel((Control)(object)grdViaggiSpedizioni).Update();
			iboInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggru).ID];
			InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
			getParentUpdatePanel((Control)(object)grdViaggiSpedizioniRaggru).Update();
			goto IL_01ed;
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

	protected FXRETURN ChiusuraViaggio(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between Unknown and I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Chiusura Viaggio");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi la chiusura del viaggio?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "ChiusuraViaggio";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_01a5;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_01a5;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_01a5;
			}
			base.SessionEnvironment.UserMessage.Reset();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = Viaggio_Chiudi_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsMess);
				if ((int)val2 <= 0)
				{
					btnConferma_Click(btnConferma, null);
					goto IL_01a5;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_01a5:
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

	protected FXRETURN ChiusuraEPartenzaViaggio(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between Unknown and I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Chiusura e partenza Viaggio");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi la chiusura e la partenza del viaggio? L'operazione sarà irreversibile.");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "ChiusuraEPartenzaViaggio";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_01a5;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_01a5;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_01a5;
			}
			base.SessionEnvironment.UserMessage.Reset();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = Viaggio_Chiudi_E_Parti_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsMess);
				if ((int)val2 <= 0)
				{
					btnConferma_Click(btnConferma, null);
					goto IL_01a5;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_01a5:
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

	protected FXRETURN WMSSave(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!_MasterRecordSaved)
			{
				goto IL_00cb;
			}
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
			{
				val2 = WMS_Viaggio_Crea_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00cb;
				}
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) != 0)
				{
					goto IL_00cb;
				}
				val2 = WMS_Viaggio_Cancella_Invoker.Instance.RunProc(CreateApiContext(), txtIdViaggio.ObjValue.ToString(), ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00cb;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00cb:
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
