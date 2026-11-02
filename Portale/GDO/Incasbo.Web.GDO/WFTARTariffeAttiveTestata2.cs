using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFTARTariffeAttiveTestata2 : WFIMultiViewPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdTestataVoci")]
	private IboGridView _grdTestataVoci;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RepeaterFasce")]
	private Repeater _RepeaterFasce;

	private bool FissoEnabled;

	private bool VariabileEnabled;

	private bool PercentualeEnabled;

	private int kMaxValueForFascia;

	private DataTable _dtFasceVoce;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MultiViewContainer")]
	protected virtual MultiView MultiViewContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TariffeAttiveTestata")]
	protected virtual View TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle_TariffeAttiveTestata")]
	protected virtual IboWebLabel lblTitle_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataAccessMode_TariffeAttiveTestata")]
	protected virtual IboWebLabel lblDataAccessMode_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita_TariffeAttiveTestata")]
	protected virtual Image imgModalita_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain_TariffeAttiveTestata")]
	protected virtual Panel pnlMain_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title_TariffeAttiveTestata")]
	protected virtual Panel cpTestata_Title_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title_Caption_TariffeAttiveTestata")]
	protected virtual Label cpTestata_Title_Caption_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPcpTestata_Body_TariffeAttiveTestata")]
	protected virtual UpdatePanel UPcpTestata_Body_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Body_TariffeAttiveTestata")]
	protected virtual Panel cpTestata_Body_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrattoTestata")]
	protected virtual IboWebLabel lblContrattoTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Contratto")]
	protected virtual IboWebLabel Contratto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContrattoDescrizione")]
	protected virtual IboWebLabel ContrattoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContrattoTrasporto")]
	protected virtual IboWebLabel ContrattoTrasporto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContrattoGiacenza")]
	protected virtual IboWebLabel ContrattoGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoDocumento")]
	protected virtual IboWebLabel TipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoDocumento")]
	protected virtual IboWebComboTlk cmbTipoDocumento
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

	[field: AccessedThroughProperty("lblTipoMezzo")]
	protected virtual IboWebLabel lblTipoMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoMezzo")]
	protected virtual IboWebComboTlk cmbTipoMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioPartenza")]
	protected virtual IboWebLabel lblGruppoTariffarioPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGruppoTariffarioPartenza")]
	protected virtual IboWebComboTlk cmbGruppoTariffarioPartenza
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

	[field: AccessedThroughProperty("cmbPCSPartenza")]
	protected virtual IboWebComboTlk cmbPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMacroZonaArrivo")]
	protected virtual IboWebLabel lblMacroZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMacroZonaArrivo")]
	protected virtual IboWebComboTlk cmbMacroZonaArrivo
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

	[field: AccessedThroughProperty("lblGruppoTariffarioArrivo")]
	protected virtual IboWebLabel lblGruppoTariffarioArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGruppoTariffarioArrivo")]
	protected virtual IboWebComboTlk cmbGruppoTariffarioArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSArrivo")]
	protected virtual IboWebLabel lblPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSArrivo")]
	protected virtual IboWebComboTlk cmbPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRapportoPv")]
	protected virtual IboWebLabel lblRapportoPv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRapportoPV")]
	protected virtual IboWebNumericTlk txtRapportoPV
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdTariffa")]
	protected virtual IboWebTextBox txtIdTariffa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCliente")]
	protected virtual IboWebTextBox txtCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title_TariffeAttiveTestata")]
	protected virtual Panel cpVoci_Title_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title_Caption_TariffeAttiveTestata")]
	protected virtual IboWebLabel cpVoci_Title_Caption_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Body_TariffeAttiveTestata")]
	protected virtual Panel cpVoci_Body_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTestataVoci")]
	protected virtual IboWebToolbar tlbgrdTestataVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTestataVoci")]
	protected virtual Panel pnlTestataVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdTestataVoci
	{
		[CompilerGenerated]
		get
		{
			return _grdTestataVoci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdTestataVoci_MultiSelectChanged);
			IboGridView val2 = _grdTestataVoci;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdTestataVoci = value;
			val2 = _grdTestataVoci;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpFasce_Title_TariffeAttiveTestata")]
	protected virtual Panel cpFasce_Title_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFasce_Title_Caption_TariffeAttiveTestata")]
	protected virtual IboWebLabel cpFasce_Title_Caption_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFasce_Body_TariffeAttiveTestata")]
	protected virtual Panel cpFasce_Body_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTestataFasce")]
	protected virtual IboWebToolbar tlbgrdTestataFasce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTestataFasce")]
	protected virtual Panel pnlTestataFasce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTestataFasce")]
	protected virtual IboGridView grdTestataFasce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnAnnulla_TariffeAttiveTestata")]
	protected virtual IboWebButton btnAnnulla_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnConferma_TariffeAttiveTestata")]
	protected virtual IboWebButton btnConferma_TariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TariffeAttiveVoci")]
	protected virtual View TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle_TariffeAttiveVoci")]
	protected virtual IboWebLabel lblTitle_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataAccessMode_TariffeAttiveVoci")]
	protected virtual IboWebLabel lblDataAccessMode_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita_TariffeAttiveVoci")]
	protected virtual Image imgModalita_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain_TariffeAttiveVoci")]
	protected virtual Panel pnlMain_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title_TariffeAttiveVoci")]
	protected virtual Panel cpTestata_Title_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title_Caption_TariffeAttiveVoci")]
	protected virtual Label cpTestata_Title_Caption_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Body_TariffeAttiveVoci")]
	protected virtual Panel cpTestata_Body_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrattoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblContrattoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrattoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblContrattoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneTariffeAttiveTestata")]
	protected virtual IboWebLabel lblTipoSpedizioneTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblTipoSpedizioneTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceTariffeAttiveTestata")]
	protected virtual IboWebLabel lblTipoMerceTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblTipoMerceTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMezzoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblTipoMezzoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMezzoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblTipoMezzoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioPartenzaTariffeAttiveTestata")]
	protected virtual IboWebLabel lblGruppoTariffarioPartenzaTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioPartenzaTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblGruppoTariffarioPartenzaTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaTariffeAttiveTestata")]
	protected virtual IboWebLabel lblPCSPartenzaTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblPCSPartenzaTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMacroZonaArrivoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblMacroZonaArrivoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMacroZonaArrivoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblMacroZonaArrivoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaArrivoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblZonaArrivoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaArrivoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblZonaArrivoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioArrivoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblGruppoTariffarioArrivoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioArrivoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblGruppoTariffarioArrivoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSArrivoTariffeAttiveTestata")]
	protected virtual IboWebLabel lblPCSArrivoTariffeAttiveTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSArrivoTariffeAttiveTestataValue")]
	protected virtual IboWebLabel lblPCSArrivoTariffeAttiveTestataValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title_TariffeAttiveVoci")]
	protected virtual Panel cpVoci_Title_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title_Caption_TariffeAttiveVoci")]
	protected virtual Label cpVoci_Title_Caption_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Body_TariffeAttiveVoci")]
	protected virtual Panel cpVoci_Body_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVoce")]
	protected virtual IboWebLabel lblVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbVoce")]
	protected virtual IboWebComboTlk cmbVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCampoCalcolo")]
	protected virtual IboWebLabel lblCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCampoCalcolo")]
	protected virtual IboWebComboTlk cmbCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArrCampoCalcolo")]
	protected virtual IboWebLabel lblArrCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArrCampoCalcolo")]
	protected virtual IboWebNumericTlk txtArrCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArrCampoCalcoloLimite")]
	protected virtual IboWebLabel lblArrCampoCalcoloLimite
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArrCampoCalcoloLimite")]
	protected virtual IboWebNumericTlk txtArrCampoCalcoloLimite
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFranchigia")]
	protected virtual IboWebLabel lblFranchigia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFranchigia")]
	protected virtual IboWebNumericTlk txtFranchigia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblApplicabilita")]
	protected virtual IboWebLabel lblApplicabilita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbApplicabilita")]
	protected virtual IboWebComboTlk cmbApplicabilita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFlgEccedenza")]
	protected virtual IboWebLabel lblFlgEccedenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbflgEccedenza")]
	protected virtual IboDropDownList cmbflgEccedenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArrCampoCalcoloOltre")]
	protected virtual IboWebLabel lblArrCampoCalcoloOltre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArrCampoCalcoloOltre")]
	protected virtual IboWebNumericTlk txtArrCampoCalcoloOltre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArrImporto")]
	protected virtual IboWebLabel lblArrImporto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArrImporto")]
	protected virtual IboWebNumericTlk txtArrImporto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdVoce")]
	protected virtual IboWebTextBox txtIdVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdVoceInserimento")]
	protected virtual IboWebTextBox IdVoceInserimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdTariffaTestata")]
	protected virtual IboWebTextBox txtIdTariffaTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFasce_Title_TariffeAttiveVoci")]
	protected virtual Panel cpFasce_Title_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFasce_Title_Caption_TariffeAttiveVoci")]
	protected virtual IboWebLabel cpFasce_Title_Caption_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFasce_Body_TariffeAttiveVoci")]
	protected virtual Panel cpFasce_Body_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_cpFasce_Body_TariffeAttiveVoci")]
	protected virtual UpdatePanel up_cpFasce_Body_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFasciaInferiore")]
	protected virtual IboWebLabel lblFasciaInferiore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFasciaSuperiore")]
	protected virtual IboWebLabel lblFasciaSuperiore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFisso")]
	protected virtual IboWebLabel lblFisso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVariabile")]
	protected virtual IboWebLabel lblVariabile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPercentuale")]
	protected virtual IboWebLabel lblPercentuale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovoLimite")]
	protected virtual IboWebLabel lblNuovoLimite
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater RepeaterFasce
	{
		[CompilerGenerated]
		get
		{
			return _RepeaterFasce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			RepeaterCommandEventHandler val = new RepeaterCommandEventHandler(RepeaterFasce_ItemCommand);
			RepeaterItemEventHandler val2 = new RepeaterItemEventHandler(RepeaterFasce_ItemDataBound);
			Repeater repeaterFasce = _RepeaterFasce;
			if (repeaterFasce != null)
			{
				repeaterFasce.ItemCommand -= val;
				repeaterFasce.ItemDataBound -= val2;
			}
			_RepeaterFasce = value;
			repeaterFasce = _RepeaterFasce;
			if (repeaterFasce != null)
			{
				repeaterFasce.ItemCommand += val;
				repeaterFasce.ItemDataBound += val2;
			}
		}
	}

	[field: AccessedThroughProperty("btnAnnulla_TariffeAttiveVoci")]
	protected virtual IboWebButton btnAnnulla_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnConferma_TariffeAttiveVoci")]
	protected virtual IboWebButton btnConferma_TariffeAttiveVoci
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TariffeAttiveFasce")]
	protected virtual View TariffeAttiveFasce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFTARTariffeAttiveTestata2()
	{
		FissoEnabled = true;
		VariabileEnabled = true;
		PercentualeEnabled = true;
		kMaxValueForFascia = 999999999;
		_dtFasceVoce = null;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.TAR.TRA_ATTIVETESTATA";
		FXRETURN result = base.InitializedPage(ref rsMess);
		if (!((Page)this).IsPostBack)
		{
			_MultiViewConfig.Tabella[1] = "TARIFFEATTIVEVOCI";
			_MultiViewConfig.AddForeignKey(1, "IdTariffa", "IdTariffa", "TariffeAttiveTestata");
			_MultiViewConfig.Tabella[2] = "TARIFFEATTIVEFASCE";
			_MultiViewConfig.AddForeignKey(2, "IdVoce", "IdVoce", "TariffeAttiveVoci");
		}
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(_objFunctionArguments.Context.ToUpper(), "DM.DOC.TARIFFE.ATTIVE", false) == 0)
		{
			return (FXRETURN)0;
		}
		return base.ContextCheck(ref rsMess);
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			MultiviewInternalGridConfig multiviewInternalGridConfig = new MultiviewInternalGridConfig();
			MultiviewInternalGridConfig multiviewInternalGridConfig2 = multiviewInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdTestataVoci;
			multiviewInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdTestataVoci = objGridView;
			multiviewInternalGridConfig.Build("DM.TAR.TRA_ATTIVEVOCI", "IdTariffa='<%MASTER_RECORD.IdTariffa%>'", "", "", ((Control)grdTestataVoci).ID, ((Control)tlbgrdTestataVoci).ID, "");
			GridConfigList.Add(multiviewInternalGridConfig);
			multiviewInternalGridConfig = new MultiviewInternalGridConfig();
			MultiviewInternalGridConfig multiviewInternalGridConfig3 = multiviewInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdTestataFasce;
			multiviewInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdTestataFasce = objGridView;
			multiviewInternalGridConfig.Build("DM.TAR.TRA_ATTIVEFASCE", "IDVoce='<%GRID_RECORD.grdTestataVoci.IdVoce%>'", "FasciaInferiore", "ASC", ((Control)grdTestataFasce).ID, ((Control)tlbgrdTestataFasce).ID);
			GridConfigList.Add(multiviewInternalGridConfig);
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
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					cmbTipoSpedizione.ReadOnly = true;
					cmbTipoMezzo.ReadOnly = true;
					cmbTipoMerce.ReadOnly = true;
					cmbGruppoTariffarioPartenza.ReadOnly = true;
					cmbPCSPartenza.ReadOnly = true;
					cmbMacroZonaArrivo.ReadOnly = true;
					cmbZonaArrivo.ReadOnly = true;
					cmbGruppoTariffarioArrivo.ReadOnly = true;
					cmbPCSArrivo.ReadOnly = true;
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		string text11 = "";
		string text12 = "";
		string text13 = "";
		string text14 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_MultiViewConfig.ActiveView != 0 || !((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
				{
					goto IL_036e;
				}
				text3 = Contratto.ObjValue.ToString();
				text4 = cmbTipoSpedizione.ObjValue.ToString();
				text5 = cmbTipoMerce.ObjValue.ToString();
				text6 = cmbTipoMezzo.ObjValue.ToString();
				text7 = cmbGruppoTariffarioPartenza.ObjValue.ToString();
				text8 = cmbPCSPartenza.ObjValue.ToString();
				text9 = cmbMacroZonaArrivo.ObjValue.ToString();
				text10 = cmbZonaArrivo.SelectedValue.ToString();
				text11 = cmbGruppoTariffarioArrivo.ObjValue.ToString();
				text12 = cmbPCSArrivo.ObjValue.ToString();
				text14 = cmbTipoDocumento.ObjValue.ToString();
				text13 = txtCliente.ObjValue.ToString();
				text2 = "SELECT COUNT(*) FROM TariffeAttiveTestata WHERE ";
				text2 = text2 + "CONTRATTO = " + base.DbConn.SQLFormatString(text3) + " AND ";
				text2 = text2 + "TIPODOCUMENTO = " + base.DbConn.SQLFormatString(text14) + " AND ";
				text2 = text2 + "TIPOSPEDIZIONE = " + base.DbConn.SQLFormatString(text4) + " AND ";
				text2 = text2 + "TIPOMERCE = " + base.DbConn.SQLFormatString(text5) + " AND ";
				text2 = text2 + "TIPOMEZZO = " + base.DbConn.SQLFormatString(text6) + " AND ";
				text2 = text2 + "GRUPPOTARIFFARIOPARTENZA = " + base.DbConn.SQLFormatString(text7) + " AND ";
				text2 = text2 + "PCSPARTENZA = " + base.DbConn.SQLFormatString(text8) + " AND ";
				text2 = text2 + "MACROZONAARRIVO = " + base.DbConn.SQLFormatString(text9) + " AND ";
				text2 = text2 + "ZONAARRIVO = " + base.DbConn.SQLFormatString(text10) + " AND ";
				text2 = text2 + "GRUPPOTARIFFARIOARRIVO = " + base.DbConn.SQLFormatString(text11) + " AND ";
				text2 = text2 + "PCSARRIVO = " + base.DbConn.SQLFormatString(text12);
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Conversions.ToInteger(obj) != 1)
					{
						goto IL_036e;
					}
					rsMess = base.Translator.TranslateMessage("XXX", "Tariffa già esistente", new string[0]);
				}
			}
			goto end_IL_0069;
			IL_036e:
			val = (FXRETURN)0;
			end_IL_0069:;
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

	protected override FXRETURN AfterLoadDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Invalid comparison between Unknown and I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Invalid comparison between Unknown and I4
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Invalid comparison between Unknown and I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Invalid comparison between Unknown and I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_1131: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Invalid comparison between Unknown and I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Invalid comparison between Unknown and I4
		//IL_1141: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Invalid comparison between Unknown and I4
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Invalid comparison between Unknown and I4
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Invalid comparison between Unknown and I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Invalid comparison between Unknown and I4
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Invalid comparison between Unknown and I4
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Invalid comparison between Unknown and I4
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadDataView(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_MultiViewConfig.ActiveView == 1)
				{
					DataTable dataTable = null;
					text2 = "SELECT SPEDIZIONE,VIAGGIO,CONTRASSEGNO,GIACENZA FROM TARIFFETIPIDOCUMENTO WHERE CODICE = " + base.DbConn.SQLFormatString(cmbTipoDocumento.ObjValue.ToString());
					val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (dataTable.Rows.Count <= 0)
						{
							goto IL_0260;
						}
						string text3 = "1=1 ";
						string text4 = "1=1 ";
						if (Operators.CompareString(dataTable.Rows[0]["VIAGGIO"].ToString(), "S", false) == 0)
						{
							text3 += "AND VIAGGIO = 'S'";
							text4 += "AND CAMPOVIAGGIO = 'S'";
						}
						if (Operators.CompareString(dataTable.Rows[0]["SPEDIZIONE"].ToString(), "S", false) == 0)
						{
							text3 += "AND SPEDIZIONE = 'S'";
							text4 += "AND CAMPOSPEDIZIONE = 'S'";
						}
						if (Operators.CompareString(dataTable.Rows[0]["CONTRASSEGNO"].ToString(), "S", false) == 0)
						{
							text3 += "AND CONTRASSEGNO = 'S'";
							text4 += "AND CAMPOCONTRASSEGNO = 'S'";
						}
						if (Operators.CompareString(dataTable.Rows[0]["GIACENZA"].ToString(), "S", false) == 0)
						{
							text3 += "AND GIACENZA = 'S'";
							text4 += "AND CAMPOGIACENZA = 'S'";
						}
						val2 = ComboSetFilter((IIboDropdownList)(object)cmbVoce, text3, cmbVoce.ObjValue.ToString(), ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = ComboSetFilter((IIboDropdownList)(object)cmbCampoCalcolo, text4, cmbCampoCalcolo.ObjValue.ToString(), ref rsMess);
							if ((int)val2 <= 0)
							{
								goto IL_0260;
							}
							val = val2;
						}
					}
				}
				else
				{
					if (((Page)this).IsPostBack)
					{
						goto IL_122f;
					}
					if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
					{
						if (base.SessionEnvironment.PersistentSessionVariables.ContainsKey("CONTRATTO"))
						{
							Contratto.ObjValue = base.SessionEnvironment.PersistentSessionVariables["CONTRATTO"].ToString();
						}
					}
					else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0)
					{
					}
					DataTable dataTable2 = null;
					text2 = "SELECT * FROM TariffeContratti WHERE CODICE=" + base.DbConn.SQLFormatString(Contratto.ObjValue.ToString());
					val2 = base.DbConn.OpenDataTable(text2, ref dataTable2, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						ContrattoDescrizione.ObjValue = dataTable2.Rows[0]["Descrizione"].ToString();
						ContrattoGiacenza.ObjValue = dataTable2.Rows[0]["ContrattoGiacenza"].ToString();
						ContrattoTrasporto.ObjValue = dataTable2.Rows[0]["ContrattoTrasporto"].ToString();
						string text5 = "";
						text5 = ((Operators.CompareString(ContrattoTrasporto.ObjValue.ToString(), "S", false) != 0) ? (text5 + " (Spedizione='N' AND Contrassegno='N' AND Viaggio='N') ") : (text5 + " (Spedizione='S' OR Contrassegno='S' OR Viaggio='S') "));
						text5 = ((Operators.CompareString(ContrattoGiacenza.ObjValue.ToString(), "S", false) != 0) ? (text5 + " OR (Giacenza='N') ") : (text5 + " OR (Giacenza='S') "));
						cmbTipoDocumento.SqlQueryFilter = "ATTIVO='S' AND TARIFFAATTIVA='S' AND (" + text5 + ")";
						IboWebComboTlk objCombo = cmbTipoDocumento;
						string rsMess2 = "";
						LoadSingleCombo(ref objCombo, ref rsMess2);
						cmbTipoDocumento = objCombo;
						if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
						{
							goto IL_122f;
						}
						DataTable dataTable3 = null;
						text2 = "SELECT CODICE, IsDefaultAttiva FROM TARIFFETIPIDOCUMENTO WHERE TARIFFAATTIVA = 'S' AND ATTIVO = 'S' AND (";
						text2 = text2 + text5 + ")";
						val2 = base.DbConn.OpenDataTable(text2, ref dataTable3, ref rsMess);
						if ((int)val2 <= 0)
						{
							if (dataTable3.Rows.Count > 1)
							{
								foreach (DataRow row2 in dataTable3.Rows)
								{
									if (Operators.CompareString(row2["IsDefaultAttiva"].ToString(), "S", false) == 0)
									{
										cmbTipoDocumento.ObjValue = row2["CODICE"].ToString();
										break;
									}
								}
							}
							else if (dataTable3.Rows.Count == 1)
							{
								cmbTipoDocumento.ObjValue = dataTable3.Rows[0]["CODICE"].ToString();
							}
							goto IL_122f;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0012;
			IL_122f:
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
			{
				grdTestataVoci.SelectFirstRow();
				AggiornaGrigliaTestataFasce();
			}
			goto IL_1265;
			IL_0260:
			if (Operators.CompareString(txtIdVoce.Text, "", false) != 0 && !_SessionVariable.ContainsKey("FasceVoce"))
			{
				DataRow[] array = _MultiViewConfig.DataTable[2].Select("IdVoce='" + txtIdVoce.Text + "'");
				_dtFasceVoce = new DataTable();
				_dtFasceVoce = _MultiViewConfig.DataTable[2].Clone();
				DataRow[] array2 = array;
				foreach (DataRow row in array2)
				{
					_dtFasceVoce.ImportRow(row);
				}
				_SessionVariable.Add("FasceVoce", _dtFasceVoce);
			}
			DataTable dataTable4 = null;
			text2 = "SELECT C.Codice contrattoCodice, C.Descrizione ContrattoDescrizione ";
			text2 += "FROM TariffeContratti C ";
			text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(_MultiViewConfig.DataTable[0].Rows[0]["Contratto"].ToString());
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable4, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable4.Rows.Count == 0)
			{
				rsMess = base.Translator.Translate("XXX", "Contratto non trovato", new string[0]);
			}
			else
			{
				DataTable dataTable5 = null;
				dataTable5 = _MultiViewConfig.DataTable[0];
				DataTable dataTable6 = null;
				text2 = "SELECT Codice, Descrizione ";
				text2 += "FROM TipiSpedizione ";
				text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["TipoSpedizione"].ToString());
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable6, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable6.Rows.Count == 0)
				{
					rsMess = base.Translator.Translate("XXX", "Tipo Spedizione non trovato", new string[0]);
				}
				else
				{
					DataTable dataTable7 = null;
					text2 = "SELECT Codice, Descrizione ";
					text2 += "FROM TipiMerce ";
					text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["TipoMerce"].ToString());
					val2 = base.DbConn.OpenDataTable(text2, ref dataTable7, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if (dataTable7.Rows.Count == 0)
					{
						rsMess = base.Translator.Translate("XXX", "Tipo Merce non trovato", new string[0]);
					}
					else
					{
						DataTable dataTable8 = null;
						text2 = "SELECT Codice, Descrizione ";
						text2 += "FROM TipiMezzo ";
						text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["TipoMezzo"].ToString());
						val2 = base.DbConn.OpenDataTable(text2, ref dataTable8, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else if (dataTable8.Rows.Count == 0)
						{
							rsMess = base.Translator.Translate("XXX", "Tipo Mezzo non trovato", new string[0]);
						}
						else
						{
							DataTable dataTable9 = null;
							text2 = "SELECT Codice, Descrizione ";
							text2 += "FROM PCS_GruppiTariffari ";
							text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["GruppoTariffarioPartenza"].ToString());
							val2 = base.DbConn.OpenDataTable(text2, ref dataTable9, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else if (dataTable9.Rows.Count == 0)
							{
								rsMess = base.Translator.Translate("XXX", "Gruppo Tariffario Partenza non trovato", new string[0]);
							}
							else
							{
								DataTable dataTable10 = null;
								text2 = "SELECT Codice,RagioneSociale as  Descrizione ";
								text2 += "FROM PCS ";
								text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["PCSPartenza"].ToString());
								val2 = base.DbConn.OpenDataTable(text2, ref dataTable10, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else if (dataTable10.Rows.Count == 0)
								{
									rsMess = base.Translator.Translate("XXX", "PCS Partenza non trovato", new string[0]);
								}
								else
								{
									DataTable dataTable11 = null;
									text2 = "SELECT Codice, Descrizione ";
									text2 += "FROM ZoneMacro ";
									text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["MacroZonaArrivo"].ToString());
									val2 = base.DbConn.OpenDataTable(text2, ref dataTable11, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else if (dataTable11.Rows.Count == 0)
									{
										rsMess = base.Translator.Translate("XXX", "Macro Zona Arrivo non trovata", new string[0]);
									}
									else
									{
										DataTable dataTable12 = null;
										text2 = "SELECT Codice, Descrizione ";
										text2 += "FROM Zone ";
										text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["ZonaArrivo"].ToString());
										val2 = base.DbConn.OpenDataTable(text2, ref dataTable12, ref rsMess);
										if ((int)val2 > 0)
										{
											val = val2;
										}
										else if (dataTable12.Rows.Count == 0)
										{
											rsMess = base.Translator.Translate("XXX", "Zona di arrivo non trovata", new string[0]);
										}
										else
										{
											DataTable dataTable13 = null;
											text2 = "SELECT Codice, Descrizione ";
											text2 += "FROM PCS_GruppiTariffari ";
											text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["GruppoTariffarioArrivo"].ToString());
											val2 = base.DbConn.OpenDataTable(text2, ref dataTable13, ref rsMess);
											if ((int)val2 > 0)
											{
												val = val2;
											}
											else if (dataTable13.Rows.Count == 0)
											{
												rsMess = base.Translator.Translate("XXX", "Gruppo Tariffario Arrivo non trovato", new string[0]);
											}
											else
											{
												DataTable dataTable14 = null;
												text2 = "SELECT Codice, RagioneSociale as Descrizione ";
												text2 += "FROM PCS ";
												text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable5.Rows[0]["PCSArrivo"].ToString());
												val2 = base.DbConn.OpenDataTable(text2, ref dataTable14, ref rsMess);
												if ((int)val2 > 0)
												{
													val = val2;
												}
												else
												{
													if (dataTable14.Rows.Count != 0)
													{
														lblContrattoTariffeAttiveTestataValue.Text = Strings.Left(dataTable4.Rows[0]["contrattoCodice"].ToString() + " - " + dataTable4.Rows[0]["ContrattoDescrizione"].ToString(), 60);
														lblTipoSpedizioneTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["TipoSpedizione"].ToString() + " - " + dataTable6.Rows[0]["Descrizione"].ToString(), 60);
														lblTipoMerceTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["TipoMerce"].ToString() + " - " + dataTable7.Rows[0]["Descrizione"].ToString(), 60);
														lblTipoMezzoTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["TipoMezzo"].ToString() + " - " + dataTable8.Rows[0]["Descrizione"].ToString(), 60);
														lblGruppoTariffarioPartenzaTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["GruppoTariffarioPartenza"].ToString() + " - " + dataTable9.Rows[0]["Descrizione"].ToString(), 60);
														lblPCSPartenzaTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["PCSPartenza"].ToString() + " - " + dataTable10.Rows[0]["Descrizione"].ToString(), 60);
														lblMacroZonaArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["MacroZonaArrivo"].ToString() + " - " + dataTable11.Rows[0]["Descrizione"].ToString(), 60);
														lblZonaArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["ZonaArrivo"].ToString() + " - " + dataTable12.Rows[0]["Descrizione"].ToString(), 60);
														lblGruppoTariffarioArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["GruppoTariffarioArrivo"].ToString() + " - " + dataTable13.Rows[0]["Descrizione"].ToString(), 60);
														lblPCSArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable5.Rows[0]["PCSArrivo"].ToString() + " - " + dataTable14.Rows[0]["Descrizione"].ToString(), 60);
														string text6 = "";
														if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
														{
															IdVoceInserimento.Text = "-1";
															text6 = IdVoceInserimento.Text;
															DataRow dataRow2 = null;
															dataRow2 = _MultiViewConfig.DataTable[2].Rows.Add();
															dataRow2["_ROWID"] = Guid.NewGuid().ToString();
															dataRow2["_ROWSTATE"] = "I";
															dataRow2["IdVoce"] = text6;
															IboWebParam parametrica = base.Parametrica;
															string rsMess2 = "";
															long num = default(long);
															parametrica.LeggiContatore("COUNTERS.TRA.TARIFFEATTIVE.FASCE", false, ref num, ref rsMess2);
															dataRow2["IdFascia"] = num;
															dataRow2["Fisso"] = 0;
															dataRow2["Variabile"] = 0;
															dataRow2["Percentuale"] = 0;
															dataRow2["FasciaSuperiore"] = kMaxValueForFascia;
															dataRow2["FasciaInferiore"] = 0;
														}
														else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
														{
															text6 = txtIdVoce.Text;
														}
														RepeaterDataRebind(text6);
														goto IL_1265;
													}
													rsMess = base.Translator.Translate("XXX", "PCS Arrivo non trovato", new string[0]);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto end_IL_0012;
			IL_1265:
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

	protected override FXRETURN AfterSaveDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveDataView(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_MultiViewConfig.ActiveView == 1 && _SessionVariable.ContainsKey("FasceVoce"))
				{
					_SessionVariable.Remove("FasceVoce");
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

	protected override FXRETURN BeforeSaveDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_MultiViewConfig.ActiveView != 1)
			{
				if (_MultiViewConfig.ActiveView == 0)
				{
					txtCliente.ObjValue = "*ALL";
				}
				goto IL_007d;
			}
			text = txtIdVoce.Text;
			val2 = SalvaFasceControllo(ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_007d;
			}
			val = val2;
			goto end_IL_000b;
			IL_007d:
			if (_SessionVariable.ContainsKey("FasceVoce"))
			{
				_SessionVariable.Remove("FasceVoce");
			}
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			result = val;
		}
		return result;
	}

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected override void btnAnnulla_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_MultiViewConfig.ActiveView == 1)
			{
				text = ((Operators.CompareString(txtIdVoce.Text, "", false) == 0) ? "-1" : txtIdVoce.Text);
				DataRow[] array = _MultiViewConfig.DataTable[2].Select("IdVoce='-1' OR IdVoce='" + text + "'");
				DataRow[] array2 = array;
				foreach (DataRow dataRow in array2)
				{
					dataRow.Delete();
				}
				if (_SessionVariable.ContainsKey("FasceVoce"))
				{
					_dtFasceVoce = (DataTable)_SessionVariable["FasceVoce"];
					foreach (DataRow row in _dtFasceVoce.Rows)
					{
						DataRow dataRow3 = _MultiViewConfig.DataTable[2].Rows.Add();
						dataRow3["_ROWID"] = RuntimeHelpers.GetObjectValue(row["_ROWID"]);
						dataRow3["_ROWSTATE"] = RuntimeHelpers.GetObjectValue(row["_ROWSTATE"]);
						dataRow3["IdVoce"] = RuntimeHelpers.GetObjectValue(row["IdVoce"]);
						dataRow3["IdFascia"] = RuntimeHelpers.GetObjectValue(row["IdFascia"]);
						dataRow3["Fisso"] = RuntimeHelpers.GetObjectValue(row["Fisso"]);
						dataRow3["Variabile"] = RuntimeHelpers.GetObjectValue(row["Variabile"]);
						dataRow3["Percentuale"] = RuntimeHelpers.GetObjectValue(row["Percentuale"]);
						dataRow3["FasciaSuperiore"] = RuntimeHelpers.GetObjectValue(row["FasciaSuperiore"]);
						dataRow3["FasciaInferiore"] = RuntimeHelpers.GetObjectValue(row["FasciaInferiore"]);
					}
				}
				_MultiViewConfig.DataTable[2].AcceptChanges();
			}
			base.btnAnnulla_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
		}
	}

	protected override void ReturnToCaller()
	{
		try
		{
			base.ReturnToCaller();
			base.SessionEnvironment.PersistentSessionVariables.Remove("CONTRATTO");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void grdTestataVoci_MultiSelectChanged(object sender, EventArgs e)
	{
		AggiornaGrigliaTestataFasce();
	}

	private void AggiornaGrigliaTestataFasce()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MultiviewInternalGridConfig objInternalGrid = GridConfigList["grdTestataFasce"];
			string rsMess = "";
			InternalGridSqlSet(ref objInternalGrid, ref rsMess);
			rsMess = "";
			_InternalGridAggiorna(ref objInternalGrid, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void AggiornaGrigliaVociFasce()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MultiviewInternalGridConfig objInternalGrid = GridConfigList["grdVociFasce"];
			string rsMess = "";
			InternalGridSqlSet(ref objInternalGrid, ref rsMess);
			rsMess = "";
			_InternalGridAggiorna(ref objInternalGrid, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void RepeaterFasce_ItemCommand(object source, RepeaterCommandEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Invalid comparison between Unknown and I4
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			val2 = CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Operators.CompareString(((CommandEventArgs)e).CommandName.ToUpper(), "FasciaAggiungi".ToUpper(), false) == 0)
			{
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaAggiungi")).Enabled = false;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaTogli")).Enabled = false;
				GetControlByName((Control)(object)e.Item, "FasciaConferma").Visible = true;
				GetControlByName((Control)(object)e.Item, "NuovoLimite").Visible = true;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "NuovoLimite")).ToInitialValue();
				lblNuovoLimite.Visible = true;
				((Button)GetControlByName((Control)(object)e.Item, "FasciaConferma")).CommandArgument = "Aggiungi";
				SetIncasFocusToControl(GetControlByName((Control)(object)e.Item, "NuovoLimite"));
			}
			else if (Operators.CompareString(((CommandEventArgs)e).CommandName.ToUpper(), "FasciaTogli".ToUpper(), false) == 0)
			{
				SalvaFasce();
				string text = ((IIboWebComponent)GetControlByName((Control)(object)e.Item, "_ROWID")).ObjValue.ToString();
				string text2 = "";
				string text3 = "";
				DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0];
				DataRow dataRow2 = null;
				DataRow dataRow3;
				checked
				{
					if (RepeaterFasce.Items.Count > e.Item.ItemIndex + 1)
					{
						text2 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex + 1], "_ROWID")).ObjValue.ToString();
						dataRow2 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text2 + "'")[0];
					}
					dataRow3 = null;
					if (e.Item.ItemIndex > 0)
					{
						text3 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex - 1], "_ROWID")).ObjValue.ToString();
						dataRow3 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text3 + "'")[0];
					}
				}
				if (dataRow3 == null && dataRow2 == null)
				{
					rsMess = base.Translator.TranslateMessage("XXX", "Impossibile cancellare la fascia in quanto deve esistere almeno una fascia per voce tariffaria", new string[0]);
					return;
				}
				if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "I", false) == 0)
				{
					dataRow["_ROWSTATE"] = "FD";
				}
				else
				{
					dataRow["_ROWSTATE"] = "D";
				}
				if (dataRow3 != null)
				{
					decimal num = default(decimal);
					decimal num2 = default(decimal);
					if (dataRow2 != null)
					{
						num = Conversions.ToDecimal(dataRow3["FasciaSuperiore"]);
						num2 = num;
						dataRow2["FasciaInferiore"] = num2;
					}
					else
					{
						num = new decimal(kMaxValueForFascia);
					}
					dataRow3["FasciaSuperiore"] = num;
				}
				else if (dataRow2 != null)
				{
					dataRow2["FasciaInferiore"] = 0;
				}
				string sVoce = dataRow["IdVoce"].ToString();
				if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "FD", false) == 0)
				{
					dataRow.Delete();
				}
				_MultiViewConfig.DataTable[2].AcceptChanges();
				RepeaterDataRebind(sVoce);
			}
			else if (Operators.CompareString(((CommandEventArgs)e).CommandName.ToUpper(), "FasciaConferma".ToUpper(), false) == 0)
			{
				string commandArgument = ((Button)GetControlByName((Control)(object)e.Item, "FasciaConferma")).CommandArgument;
				if (Operators.CompareString(commandArgument, "Aggiungi", false) == 0)
				{
					SalvaFasce();
					IIboWebComponent val3 = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "NuovoLimite");
					if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(val3.ObjValue)))
					{
						if (decimal.Compare(Conversions.ToDecimal(val3.ObjValue), 0m) > 0)
						{
							if ((decimal.Compare(Conversions.ToDecimal(val3.ObjValue), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaSuperiore")).ObjValue)) >= 0) | (decimal.Compare(Conversions.ToDecimal(val3.ObjValue), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaInferiore")).ObjValue)) <= 0))
							{
								rsMess = base.Translator.TranslateMessage("XXX", "Il nuovo limite deve essere compreso tra {0} e {1}", new string[2]
								{
									((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaInferiore")).ObjValue.ToString(),
									((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaSuperiore")).ObjValue.ToString()
								});
								SetIncasFocusToControl((Control)val3);
								return;
							}
							((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaAggiungi")).Enabled = true;
							((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaTogli")).Enabled = true;
							GetControlByName((Control)(object)e.Item, "FasciaConferma").Visible = false;
							GetControlByName((Control)(object)e.Item, "NuovoLimite").Visible = false;
							lblNuovoLimite.Visible = false;
							((Button)GetControlByName((Control)(object)e.Item, "FasciaConferma")).CommandArgument = "";
							string text4 = ((IIboWebComponent)GetControlByName((Control)(object)e.Item, "_ROWID")).ObjValue.ToString();
							string text5 = "";
							DataRow dataRow4 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text4 + "'")[0];
							DataRow dataRow5 = null;
							DataRow dataRow6 = null;
							long num3 = default(long);
							checked
							{
								if (RepeaterFasce.Items.Count > e.Item.ItemIndex + 1)
								{
									text5 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex + 1], "_ROWID")).ObjValue.ToString();
									dataRow6 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text5 + "'")[0];
								}
								dataRow5 = _MultiViewConfig.DataTable[2].Rows.Add();
								dataRow5["_ROWID"] = Guid.NewGuid().ToString();
								dataRow5["_ROWSTATE"] = "I";
								dataRow5["IdVoce"] = RuntimeHelpers.GetObjectValue(dataRow4["IdVoce"]);
								IboWebParam parametrica = base.Parametrica;
								string text6 = "";
								val2 = parametrica.LeggiContatore("COUNTERS.TRA.TARIFFEATTIVE.FASCE", false, ref num3, ref text6);
							}
							if ((int)val2 > 0)
							{
								return;
							}
							dataRow5["IdFascia"] = num3;
							dataRow5["Fisso"] = 0;
							dataRow5["Variabile"] = 0;
							dataRow5["Percentuale"] = 0;
							object objectValue = RuntimeHelpers.GetObjectValue(dataRow4["FasciaSuperiore"]);
							if (dataRow6 != null)
							{
								objectValue = RuntimeHelpers.GetObjectValue(dataRow6["FasciaInferiore"]);
							}
							dataRow4["FasciaSuperiore"] = RuntimeHelpers.GetObjectValue(val3.ObjValue);
							if (Operators.CompareString(dataRow4["_ROWSTATE"].ToString(), "U", false) == 0)
							{
								dataRow4["_ROWSTATE"] = "M";
							}
							dataRow5["FasciaInferiore"] = RuntimeHelpers.GetObjectValue(val3.ObjValue);
							dataRow5["FasciaSuperiore"] = RuntimeHelpers.GetObjectValue(objectValue);
							RepeaterDataRebind(dataRow4["IdVoce"].ToString());
						}
						else
						{
							((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaAggiungi")).Enabled = true;
							((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaTogli")).Enabled = true;
							GetControlByName((Control)(object)e.Item, "FasciaConferma").Visible = false;
							GetControlByName((Control)(object)e.Item, "NuovoLimite").Visible = false;
							lblNuovoLimite.Visible = false;
							((Button)GetControlByName((Control)(object)e.Item, "FasciaConferma")).CommandArgument = "";
						}
					}
					else
					{
						((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaAggiungi")).Enabled = true;
						((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaTogli")).Enabled = true;
						GetControlByName((Control)(object)e.Item, "FasciaConferma").Visible = false;
						GetControlByName((Control)(object)e.Item, "NuovoLimite").Visible = false;
						lblNuovoLimite.Visible = false;
						((Button)GetControlByName((Control)(object)e.Item, "FasciaConferma")).CommandArgument = "";
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void RepeaterFasce_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataRow row = ((DataRowView)e.Item.DataItem).Row;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaInferiore")).ObjValue = RuntimeHelpers.GetObjectValue(row["FasciaInferiore"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "FasciaSuperiore")).ObjValue = RuntimeHelpers.GetObjectValue(row["FasciaSuperiore"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Fisso")).ObjValue = RuntimeHelpers.GetObjectValue(row["Fisso"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Fisso")).Enabled = FissoEnabled;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Variabile")).ObjValue = RuntimeHelpers.GetObjectValue(row["Variabile"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Variabile")).Enabled = VariabileEnabled;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Percentuale")).ObjValue = RuntimeHelpers.GetObjectValue(row["Percentuale"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Percentuale")).Enabled = PercentualeEnabled;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "IdFascia")).ObjValue = RuntimeHelpers.GetObjectValue(row["IdFascia"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "IdVoceFasce")).ObjValue = RuntimeHelpers.GetObjectValue(row["IdVoce"]);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "_ROWID")).ObjValue = RuntimeHelpers.GetObjectValue(row["_ROWID"]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SalvaFasce()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		foreach (RepeaterItem item in RepeaterFasce.Items)
		{
			RepeaterItem parent = item;
			string text = ((IIboWebComponent)GetControlByName((Control)(object)parent, "_ROWID")).ObjValue.ToString();
			DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0];
			string text2 = "";
			if (decimal.Compare(Conversions.ToDecimal(dataRow["Fisso"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue)) != 0)
			{
				text2 = "M";
				dataRow["Fisso"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue);
			}
			if (decimal.Compare(Conversions.ToDecimal(dataRow["Variabile"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue)) != 0)
			{
				text2 = "M";
				dataRow["Variabile"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue);
			}
			if (decimal.Compare(Conversions.ToDecimal(dataRow["Percentuale"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue)) != 0)
			{
				text2 = "M";
				dataRow["Percentuale"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue);
			}
			if (decimal.Compare(Conversions.ToDecimal(dataRow["FasciaSuperiore"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue)) != 0)
			{
				text2 = "M";
				dataRow["FasciaSuperiore"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue);
			}
			if (decimal.Compare(Conversions.ToDecimal(dataRow["FasciaInferiore"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue)) != 0)
			{
				text2 = "M";
				dataRow["FasciaInferiore"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue);
			}
			if (Operators.CompareString(text2, "", false) == 0)
			{
				continue;
			}
			if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "I", false) != 0)
			{
				if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "IE", false) == 0)
				{
					dataRow["_ROWSTATE"] = "I";
				}
				else if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "ME", false) == 0)
				{
					dataRow["_ROWSTATE"] = "M";
				}
				else
				{
					dataRow["_ROWSTATE"] = text2;
				}
			}
			dataRow.AcceptChanges();
		}
	}

	private FXRETURN SalvaFasceControllo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		decimal num = default(decimal);
		decimal num2 = default(decimal);
		decimal num3 = default(decimal);
		decimal num4 = default(decimal);
		decimal num5 = default(decimal);
		bool flag = false;
		FXRETURN result;
		try
		{
			rsMess = "";
			foreach (RepeaterItem item in RepeaterFasce.Items)
			{
				RepeaterItem parent = item;
				string text = ((IIboWebComponent)GetControlByName((Control)(object)parent, "_ROWID")).ObjValue.ToString();
				DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0];
				string text2 = "";
				if (decimal.Compare(Conversions.ToDecimal(dataRow["Fisso"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue)) != 0)
				{
					text2 = "M";
					dataRow["Fisso"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue);
				}
				if (decimal.Compare(Conversions.ToDecimal(dataRow["Variabile"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue)) != 0)
				{
					text2 = "M";
					dataRow["Variabile"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue);
				}
				if (decimal.Compare(Conversions.ToDecimal(dataRow["Percentuale"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue)) != 0)
				{
					text2 = "M";
					dataRow["Percentuale"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue);
				}
				if (decimal.Compare(Conversions.ToDecimal(dataRow["FasciaSuperiore"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue)) != 0)
				{
					text2 = "M";
					dataRow["FasciaSuperiore"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue);
				}
				if (decimal.Compare(Conversions.ToDecimal(dataRow["FasciaInferiore"]), Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue)) != 0)
				{
					text2 = "M";
					dataRow["FasciaInferiore"] = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue);
				}
				dataRow["IdVoce"] = txtIdVoce.ObjValue.ToString();
				if (Operators.CompareString(text2, "", false) != 0)
				{
					if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "I", false) != 0)
					{
						if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "IE", false) == 0)
						{
							dataRow["_ROWSTATE"] = "I";
						}
						else if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "ME", false) == 0)
						{
							dataRow["_ROWSTATE"] = "M";
						}
						else
						{
							dataRow["_ROWSTATE"] = text2;
						}
					}
					dataRow.AcceptChanges();
				}
				num = Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue);
				num3 = Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue);
				num2 = Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue);
				num4 = Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue);
				num5 = Conversions.ToDecimal(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue);
				if ((decimal.Compare(num2, 0m) == 0) & (decimal.Compare(num, 0m) == 0) & (decimal.Compare(num3, 0m) == 0) & (decimal.Compare(num4, 0m) > 0))
				{
					rsMess += TranslateMessage("XXX", "Inserire almeno un valore > 0 tra fisso, variabile, percentuale per la fascia {0}-{1}\r\n", num4.ToString(), num5.ToString());
					((IboWebLabel)GetControlByName((Control)(object)parent, "lblErrore")).Visible = true;
					flag = true;
				}
				else if ((decimal.Compare(num, 0m) > 0) & (decimal.Compare(num3, 0m) > 0))
				{
					rsMess += TranslateMessage("XXX", "Inserire solo un valore > 0 tra variabile e percentuale per la fascia {0}-{1}\r\n", num4.ToString(), num5.ToString());
					((IboWebLabel)GetControlByName((Control)(object)parent, "lblErrore")).Visible = true;
					flag = true;
				}
				else
				{
					((IboWebLabel)GetControlByName((Control)(object)parent, "lblErrore")).Visible = false;
				}
			}
			if (!flag)
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
			result = val;
		}
		return result;
	}

	private void RepeaterDataRebind(string sVoce)
	{
		_MultiViewConfig.DataTable[2].AcceptChanges();
		DataTable dataTable = _MultiViewConfig.DataTable[2].Clone();
		DataRow[] array = _MultiViewConfig.DataTable[2].Select("IdVoce='" + sVoce + "' AND _ROWSTATE<>'D'", "FasciaInferiore");
		DataRow[] array2 = array;
		foreach (DataRow row in array2)
		{
			dataTable.ImportRow(row);
		}
		RepeaterFasce.DataSource = dataTable;
		RepeaterFasce.DataBind();
	}
}
