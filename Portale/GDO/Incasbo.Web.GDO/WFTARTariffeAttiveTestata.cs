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

public class WFTARTariffeAttiveTestata : WFIMultiViewPage
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

	[field: AccessedThroughProperty("cmbContratto")]
	protected virtual IboWebComboTlk cmbContratto
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

	public WFTARTariffeAttiveTestata()
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
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
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
					cmbContratto.ReadOnly = true;
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
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
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
					goto IL_0335;
				}
				text3 = cmbContratto.ObjValue.ToString();
				text4 = cmbTipoSpedizione.ObjValue.ToString();
				text5 = cmbTipoMerce.ObjValue.ToString();
				text6 = cmbTipoMezzo.ObjValue.ToString();
				text7 = cmbGruppoTariffarioPartenza.ObjValue.ToString();
				text8 = cmbPCSPartenza.ObjValue.ToString();
				text9 = cmbMacroZonaArrivo.ObjValue.ToString();
				text10 = cmbZonaArrivo.SelectedValue.ToString();
				text11 = cmbGruppoTariffarioArrivo.ObjValue.ToString();
				text12 = cmbPCSArrivo.ObjValue.ToString();
				text13 = txtCliente.ObjValue.ToString();
				text2 = "SELECT COUNT(*) FROM TariffeAttiveTestata WHERE ";
				text2 = text2 + "CONTRATTO = " + base.DbConn.SQLFormatString(text3) + " AND ";
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
						goto IL_0335;
					}
					rsMess = base.Translator.TranslateMessage("XXX", "Tariffa già esistente", new string[0]);
				}
			}
			goto end_IL_0062;
			IL_0335:
			val = (FXRETURN)0;
			end_IL_0062:;
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
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Invalid comparison between Unknown and I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Invalid comparison between Unknown and I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Invalid comparison between Unknown and I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Invalid comparison between Unknown and I4
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Invalid comparison between Unknown and I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Invalid comparison between Unknown and I4
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Invalid comparison between Unknown and I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Invalid comparison between Unknown and I4
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = base.AfterLoadDataView(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_MultiViewConfig.ActiveView != 1)
				{
					if (!((Page)this).IsPostBack)
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
						{
							if (base.SessionEnvironment.PersistentSessionVariables.ContainsKey("CONTRATTO"))
							{
								IboWebComboTlk objCombo = cmbContratto;
								string? sItemValue = base.SessionEnvironment.PersistentSessionVariables["CONTRATTO"].ToString();
								string rsMess2 = "";
								ComboSelectedItem((IIboDropdownList)(object)objCombo, sItemValue, ref rsMess2);
								cmbContratto.ReadOnly = true;
							}
						}
						else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0 && Operators.CompareString(cmbContratto.ObjValue.ToString(), "", false) == 0)
						{
						}
					}
					if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
					{
						grdTestataVoci.SelectFirstRow();
						AggiornaGrigliaTestataFasce();
					}
					goto IL_0dc8;
				}
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
				DataTable dataTable2 = null;
				text2 = "SELECT C.Codice contrattoCodice,";
				text2 += "C.Descrizione\tContrattoDescrizione ";
				text2 += "FROM TariffeContratti C ";
				text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(_MultiViewConfig.DataTable[0].Rows[0]["Contratto"].ToString());
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable2, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable2.Rows.Count == 0)
				{
					rsMess = base.Translator.Translate("XXX", "Contratto non trovato", new string[0]);
				}
				else
				{
					DataTable dataTable3 = null;
					dataTable3 = _MultiViewConfig.DataTable[0];
					DataTable dataTable4 = null;
					text2 = "SELECT Codice, Descrizione ";
					text2 += "FROM TipiSpedizione ";
					text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["TipoSpedizione"].ToString());
					val2 = base.DbConn.OpenDataTable(text2, ref dataTable4, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if (dataTable4.Rows.Count == 0)
					{
						rsMess = base.Translator.Translate("XXX", "Tipo Spedizione non trovato", new string[0]);
					}
					else
					{
						DataTable dataTable5 = null;
						text2 = "SELECT Codice, Descrizione ";
						text2 += "FROM TipiMerce ";
						text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["TipoMerce"].ToString());
						val2 = base.DbConn.OpenDataTable(text2, ref dataTable5, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else if (dataTable5.Rows.Count == 0)
						{
							rsMess = base.Translator.Translate("XXX", "Tipo Merce non trovato", new string[0]);
						}
						else
						{
							DataTable dataTable6 = null;
							text2 = "SELECT Codice, Descrizione ";
							text2 += "FROM TipiMezzo ";
							text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["TipoMezzo"].ToString());
							val2 = base.DbConn.OpenDataTable(text2, ref dataTable6, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else if (dataTable6.Rows.Count == 0)
							{
								rsMess = base.Translator.Translate("XXX", "Tipo Mezzo non trovato", new string[0]);
							}
							else
							{
								DataTable dataTable7 = null;
								text2 = "SELECT Codice, Descrizione ";
								text2 += "FROM PCS_GruppiTariffari ";
								text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["GruppoTariffarioPartenza"].ToString());
								val2 = base.DbConn.OpenDataTable(text2, ref dataTable7, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else if (dataTable7.Rows.Count == 0)
								{
									rsMess = base.Translator.Translate("XXX", "Gruppo Tariffario Partenza non trovato", new string[0]);
								}
								else
								{
									DataTable dataTable8 = null;
									text2 = "SELECT Codice,RagioneSociale as  Descrizione ";
									text2 += "FROM PCS ";
									text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["PCSPartenza"].ToString());
									val2 = base.DbConn.OpenDataTable(text2, ref dataTable8, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else if (dataTable8.Rows.Count == 0)
									{
										rsMess = base.Translator.Translate("XXX", "PCS Partenza non trovato", new string[0]);
									}
									else
									{
										DataTable dataTable9 = null;
										text2 = "SELECT Codice, Descrizione ";
										text2 += "FROM ZoneMacro ";
										text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["MacroZonaArrivo"].ToString());
										val2 = base.DbConn.OpenDataTable(text2, ref dataTable9, ref rsMess);
										if ((int)val2 > 0)
										{
											val = val2;
										}
										else if (dataTable9.Rows.Count == 0)
										{
											rsMess = base.Translator.Translate("XXX", "Macro Zona Arrivo non trovata", new string[0]);
										}
										else
										{
											DataTable dataTable10 = null;
											text2 = "SELECT Codice, Descrizione ";
											text2 += "FROM Zone ";
											text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["ZonaArrivo"].ToString());
											val2 = base.DbConn.OpenDataTable(text2, ref dataTable10, ref rsMess);
											if ((int)val2 > 0)
											{
												val = val2;
											}
											else if (dataTable10.Rows.Count == 0)
											{
												rsMess = base.Translator.Translate("XXX", "Zona di arrivo non trovata", new string[0]);
											}
											else
											{
												DataTable dataTable11 = null;
												text2 = "SELECT Codice, Descrizione ";
												text2 += "FROM PCS_GruppiTariffari ";
												text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["GruppoTariffarioArrivo"].ToString());
												val2 = base.DbConn.OpenDataTable(text2, ref dataTable11, ref rsMess);
												if ((int)val2 > 0)
												{
													val = val2;
												}
												else if (dataTable11.Rows.Count == 0)
												{
													rsMess = base.Translator.Translate("XXX", "Gruppo Tariffario Arrivo non trovato", new string[0]);
												}
												else
												{
													DataTable dataTable12 = null;
													text2 = "SELECT Codice, RagioneSociale as Descrizione ";
													text2 += "FROM PCS ";
													text2 = text2 + "WHERE CODICE=" + base.DbConn.SQLFormatString(dataTable3.Rows[0]["PCSArrivo"].ToString());
													val2 = base.DbConn.OpenDataTable(text2, ref dataTable12, ref rsMess);
													if ((int)val2 > 0)
													{
														val = val2;
													}
													else
													{
														if (dataTable12.Rows.Count != 0)
														{
															lblContrattoTariffeAttiveTestataValue.Text = Strings.Left(dataTable2.Rows[0]["contrattoCodice"].ToString() + " - " + dataTable2.Rows[0]["ContrattoDescrizione"].ToString(), 60);
															lblTipoSpedizioneTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["TipoSpedizione"].ToString() + " - " + dataTable4.Rows[0]["Descrizione"].ToString(), 60);
															lblTipoMerceTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["TipoMerce"].ToString() + " - " + dataTable5.Rows[0]["Descrizione"].ToString(), 60);
															lblTipoMezzoTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["TipoMezzo"].ToString() + " - " + dataTable6.Rows[0]["Descrizione"].ToString(), 60);
															lblGruppoTariffarioPartenzaTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["GruppoTariffarioPartenza"].ToString() + " - " + dataTable7.Rows[0]["Descrizione"].ToString(), 60);
															lblPCSPartenzaTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["PCSPartenza"].ToString() + " - " + dataTable8.Rows[0]["Descrizione"].ToString(), 60);
															lblMacroZonaArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["MacroZonaArrivo"].ToString() + " - " + dataTable9.Rows[0]["Descrizione"].ToString(), 60);
															lblZonaArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["ZonaArrivo"].ToString() + " - " + dataTable10.Rows[0]["Descrizione"].ToString(), 60);
															lblGruppoTariffarioArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["GruppoTariffarioArrivo"].ToString() + " - " + dataTable11.Rows[0]["Descrizione"].ToString(), 60);
															lblPCSArrivoTariffeAttiveTestataValue.Text = Strings.Left(dataTable3.Rows[0]["PCSArrivo"].ToString() + " - " + dataTable12.Rows[0]["Descrizione"].ToString(), 60);
															string text3 = "";
															if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
															{
																IdVoceInserimento.Text = "-1";
																text3 = IdVoceInserimento.Text;
																DataRow dataRow = null;
																dataRow = _MultiViewConfig.DataTable[2].Rows.Add();
																dataRow["_ROWID"] = Guid.NewGuid().ToString();
																dataRow["_ROWSTATE"] = "I";
																dataRow["IdVoce"] = text3;
																IboWebParam parametrica = base.Parametrica;
																string rsMess2 = "";
																long num = default(long);
																parametrica.LeggiContatore("COUNTERS.TRA.TARIFFEATTIVE.FASCE", false, ref num, ref rsMess2);
																dataRow["IdFascia"] = num;
																dataRow["Fisso"] = 0;
																dataRow["Variabile"] = 0;
																dataRow["Percentuale"] = 0;
																dataRow["FasciaSuperiore"] = kMaxValueForFascia;
																dataRow["FasciaInferiore"] = 0;
															}
															else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
															{
																text3 = txtIdVoce.Text;
															}
															RepeaterDataRebind(text3);
															goto IL_0dc8;
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
			}
			goto end_IL_0015;
			IL_0dc8:
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
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_0091;
			}
			text = txtIdVoce.Text;
			if (SalvaFasce(text, ref rsMess) && ControllaFasce(text, ref rsMess))
			{
				goto IL_0091;
			}
			goto end_IL_000b;
			IL_0091:
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
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			checked
			{
				if (Operators.CompareString(((CommandEventArgs)e).CommandName.ToUpper(), "FasciaAggiungi".ToUpper(), false) == 0)
				{
					string text2 = ((IIboWebComponent)GetControlByName((Control)(object)e.Item, "_ROWID")).ObjValue.ToString();
					string text3 = "";
					DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text2 + "'")[0];
					if (!SalvaFasce(ref rsMess))
					{
						return;
					}
					DataRow dataRow2 = null;
					DataRow dataRow3 = null;
					if (RepeaterFasce.Items.Count > e.Item.ItemIndex + 1)
					{
						text3 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex + 1], "_ROWID")).ObjValue.ToString();
						dataRow3 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text3 + "'")[0];
					}
					dataRow2 = _MultiViewConfig.DataTable[2].Rows.Add();
					dataRow2["_ROWID"] = Guid.NewGuid().ToString();
					dataRow2["_ROWSTATE"] = "I";
					dataRow2["IdVoce"] = RuntimeHelpers.GetObjectValue(dataRow["IdVoce"]);
					IboWebParam parametrica = base.Parametrica;
					string text4 = "";
					long num = default(long);
					parametrica.LeggiContatore("COUNTERS.TRA.TARIFFEATTIVE.FASCE", false, ref num, ref text4);
					dataRow2["IdFascia"] = num;
					dataRow2["Fisso"] = 0;
					dataRow2["Variabile"] = 0;
					dataRow2["Percentuale"] = 0;
					dataRow2["FasciaSuperiore"] = 0;
					dataRow2["FasciaInferiore"] = 0;
					RepeaterDataRebind(dataRow["IdVoce"].ToString());
				}
				else if (Operators.CompareString(((CommandEventArgs)e).CommandName.ToUpper(), "FasciaTogli".ToUpper(), false) == 0)
				{
					string text5 = ((IIboWebComponent)GetControlByName((Control)(object)e.Item, "_ROWID")).ObjValue.ToString();
					string text6 = "";
					string text7 = "";
					DataRow dataRow4 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text5 + "'")[0];
					string sVoce = dataRow4["IdVoce"].ToString();
					if (!SalvaFasce(ref rsMess))
					{
						return;
					}
					DataRow dataRow5 = null;
					if (RepeaterFasce.Items.Count > e.Item.ItemIndex + 1)
					{
						text6 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex + 1], "_ROWID")).ObjValue.ToString();
						dataRow5 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text6 + "'")[0];
					}
					DataRow dataRow6 = null;
					if (e.Item.ItemIndex > 0)
					{
						text7 = ((IIboWebComponent)GetControlByName((Control)(object)RepeaterFasce.Items[e.Item.ItemIndex - 1], "_ROWID")).ObjValue.ToString();
						dataRow6 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text7 + "'")[0];
					}
					if (unchecked(dataRow6 == null && dataRow5 == null))
					{
						rsMess = base.Translator.TranslateMessage("XXX", "Impossibile cancellare la fascia in quanto deve esistere almeno una fascia per voce tariffaria", new string[0]);
						return;
					}
					if (Operators.CompareString(dataRow4["_ROWSTATE"].ToString(), "I", false) == 0)
					{
						dataRow4["_ROWSTATE"] = "FD";
					}
					else
					{
						dataRow4["_ROWSTATE"] = "D";
					}
					if (Operators.CompareString(dataRow4["_ROWSTATE"].ToString(), "FD", false) == 0)
					{
						dataRow4.Delete();
					}
					_MultiViewConfig.DataTable[2].AcceptChanges();
					RepeaterDataRebind(sVoce);
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
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
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
			string text = row["_ROWSTATE"].ToString();
			if ((Operators.CompareString(text, "IE", false) == 0) | (Operators.CompareString(text, "ME", false) == 0))
			{
				((IboWebLabel)GetControlByName((Control)(object)e.Item, "lblErrore")).Visible = true;
			}
			else
			{
				((IboWebLabel)GetControlByName((Control)(object)e.Item, "lblErrore")).Visible = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private bool SalvaFasce(ref string rsMess)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		bool result;
		try
		{
			rsMess = "";
			foreach (RepeaterItem item in RepeaterFasce.Items)
			{
				RepeaterItem parent = item;
				string text = ((IIboWebComponent)GetControlByName((Control)(object)parent, "_ROWID")).ObjValue.ToString();
				DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0];
				string text2 = "";
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per il Fisso");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per il Variabile");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per la Percentuale");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per la Fascia Superiore");
					flag2 = true;
				}
				if (!flag2)
				{
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
					continue;
				}
				goto end_IL_0005;
			}
			flag = true;
			end_IL_0005:;
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
			result = flag;
		}
		return result;
	}

	private bool SalvaFasce(string IdVoce, ref string rsMess)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		bool result;
		try
		{
			rsMess = "";
			foreach (RepeaterItem item in RepeaterFasce.Items)
			{
				RepeaterItem parent = item;
				string text = ((IIboWebComponent)GetControlByName((Control)(object)parent, "_ROWID")).ObjValue.ToString();
				DataRow dataRow = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0];
				string text2 = "";
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per il Fisso");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per il Variabile");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per la Percentuale");
					flag2 = true;
				}
				if (Operators.CompareString(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue.ToString(), "", false) == 0 && !flag2)
				{
					rsMess = TranslateMessage("XXX", "Inserire un valore per la Fascia Superiore");
					flag2 = true;
				}
				if (!flag2)
				{
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
					dataRow["IdVoce"] = IdVoce;
					if (Operators.CompareString(text2, "", false) != 0 && Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "I", false) != 0)
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
					continue;
				}
				goto end_IL_0005;
			}
			RepeaterDataRebind(IdVoce);
			flag = true;
			end_IL_0005:;
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
			result = flag;
		}
		return result;
	}

	private void RepeaterDataRebind(string sVoce)
	{
		_MultiViewConfig.DataTable[2].AcceptChanges();
		DataTable dataTable = _MultiViewConfig.DataTable[2].Clone();
		DataRow[] array = _MultiViewConfig.DataTable[2].Select("IdVoce='" + sVoce + "' AND _ROWSTATE<>'D'", "FasciaSuperiore");
		DataRow[] array2 = array;
		foreach (DataRow row in array2)
		{
			dataTable.ImportRow(row);
		}
		RepeaterFasce.DataSource = dataTable;
		RepeaterFasce.DataBind();
	}

	private bool ControllaFasce(string sIdVoce, ref string rsMess)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		double num = 0.0;
		double num2 = 0.0;
		bool flag2 = false;
		DataRow dataRow = null;
		RepeaterItem val = null;
		int num3 = 0;
		bool flag3 = true;
		string rsMess2 = "";
		int num4 = 0;
		bool result;
		try
		{
			rsMess = "";
			num4 = RepeaterFasce.Items.Count;
			_MultiViewConfig.DataTable[2].AcceptChanges();
			foreach (RepeaterItem item in RepeaterFasce.Items)
			{
				RepeaterItem parent = item;
				text = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "_ROWID")).ObjValue);
				DataRow[] array = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'");
				text2 = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Fisso")).ObjValue);
				text3 = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Variabile")).ObjValue);
				text4 = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "Percentuale")).ObjValue);
				text5 = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaInferiore")).ObjValue);
				text6 = Conversions.ToString(((IIboWebComponent)GetControlByName((Control)(object)parent, "FasciaSuperiore")).ObjValue);
				if (((Operators.CompareString(text2, "", false) == 0) | (Operators.CompareString(text2, "0", false) == 0)) & ((Operators.CompareString(text3, "", false) == 0) | (Operators.CompareString(text3, "0", false) == 0)) & ((Operators.CompareString(text4, "", false) == 0) | (Operators.CompareString(text4, "0", false) == 0)) & ((Operators.CompareString(text6, "", false) == 0) | (Operators.CompareString(text6, "0", false) == 0)))
				{
					_MultiViewConfig.DataTable[2].Select("_ROWID='" + text + "'")[0].Delete();
					continue;
				}
				if (!flag2)
				{
					if (!ControlloCampiValore(text2, text3, text4, ref rsMess))
					{
						text7 = text;
						flag2 = true;
						flag3 = false;
					}
					if (flag3)
					{
						if (Operators.CompareString(text6, "", false) != 0)
						{
							num2 = Conversions.ToDouble(text6);
							if (num2 == 0.0)
							{
								rsMess = TranslateMessage("XXX", "Fascia Superiore deve essere maggiore di 0");
								text7 = text;
								flag2 = true;
							}
							else if (!Information.IsNothing((object)dataRow) && num2 == Conversions.ToDouble(dataRow["FasciaSuperiore"].ToString()))
							{
								rsMess = TranslateMessage("XXX", "Non possono esserci 2 fasce superiori uguali");
								text7 = text;
								flag2 = true;
							}
						}
						else
						{
							text6 = "0";
							rsMess = TranslateMessage("XXX", "Obbligatorio inserire la fascia Superiore");
							text7 = text;
							flag2 = true;
						}
					}
				}
				if (!flag2)
				{
					if (Operators.CompareString(array[0]["_ROWSTATE"].ToString(), "IE", false) == 0)
					{
						array[0]["_ROWSTATE"] = "I";
					}
					else if (Operators.CompareString(array[0]["_ROWSTATE"].ToString(), "ME", false) == 0)
					{
						array[0]["_ROWSTATE"] = "M";
					}
					else if (Operators.CompareString(array[0]["_ROWSTATE"].ToString(), "U", false) == 0)
					{
						array[0]["_ROWSTATE"] = "M";
					}
				}
				array[0]["IdVoce"] = sIdVoce;
				array[0]["Fisso"] = text2;
				array[0]["Variabile"] = text3;
				array[0]["Percentuale"] = text4;
				array[0]["FasciaSuperiore"] = text6;
				if (!Information.IsNothing((object)dataRow))
				{
					array[0]["FasciaInferiore"] = RuntimeHelpers.GetObjectValue(dataRow["FasciaSuperiore"]);
				}
				else
				{
					array[0]["FasciaInferiore"] = 0;
				}
				dataRow = array[0];
			}
			if (!ControlloFasciaSuperioreMassima(sIdVoce, Conversions.ToDouble(text6), ref rsMess2))
			{
				if (!flag2)
				{
					rsMess = rsMess2;
				}
				flag2 = true;
			}
			if (!flag2)
			{
				flag = true;
			}
			else if (Operators.CompareString(text7, "", false) != 0)
			{
				DataRow[] array2 = _MultiViewConfig.DataTable[2].Select("_ROWID='" + text7 + "'");
				if (Operators.CompareString(array2[0]["_ROWSTATE"].ToString(), "I", false) == 0)
				{
					array2[0]["_ROWSTATE"] = "IE";
				}
				else if (Operators.CompareString(array2[0]["_ROWSTATE"].ToString(), "M", false) == 0)
				{
					array2[0]["_ROWSTATE"] = "ME";
				}
			}
			RepeaterDataRebind(sIdVoce);
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
			result = flag;
		}
		return result;
	}

	private bool ControlloCampiValore(string Fisso, string Variabile, string Percentuale, string FasciaInferiore, int NumeroFasce, ref string rsMess)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		bool flag = false;
		bool flag2 = false;
		bool result;
		try
		{
			rsMess = "";
			if (Operators.CompareString(Fisso, "", false) != 0)
			{
				num = Conversions.ToDouble(Fisso);
				if (num != 0.0)
				{
					flag2 = true;
				}
			}
			if (Operators.CompareString(Variabile, "", false) == 0)
			{
				goto IL_00bf;
			}
			num2 = Conversions.ToDouble(Variabile);
			if (num2 == 0.0)
			{
				goto IL_00bf;
			}
			if (!flag2)
			{
				flag2 = true;
				goto IL_00bf;
			}
			rsMess = TranslateMessage("XXX", "Solo 1 tra Fisso, Variabile e Percentuale può essere valorizzato");
			goto end_IL_0025;
			IL_0116:
			if (!flag2 && !((NumeroFasce > 1) & (Conversions.ToInteger(FasciaInferiore) == 0)))
			{
				rsMess = TranslateMessage("XXX", "Valorizzare 1 tra Fisso, Variabile e Percentuale");
			}
			else
			{
				flag = true;
			}
			goto end_IL_0025;
			IL_00bf:
			if (Operators.CompareString(Percentuale, "", false) == 0)
			{
				goto IL_0116;
			}
			num3 = Conversions.ToDouble(Percentuale);
			if (num3 == 0.0)
			{
				goto IL_0116;
			}
			if (!flag2)
			{
				flag2 = true;
				goto IL_0116;
			}
			rsMess = TranslateMessage("XXX", "Solo 1 tra Fisso, Variabile e Percentuale può essere valorizzato");
			end_IL_0025:;
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
			result = flag;
		}
		return result;
	}

	private bool ControlloCampiValore(string Fisso, string Variabile, string Percentuale, ref string rsMess)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		bool flag = false;
		bool flag2 = false;
		bool result;
		try
		{
			rsMess = "";
			if (Operators.CompareString(Fisso, "", false) != 0)
			{
				num = Conversions.ToDouble(Fisso);
				if (num != 0.0)
				{
					flag2 = true;
				}
			}
			if (Operators.CompareString(Variabile, "", false) == 0)
			{
				goto IL_00bf;
			}
			num2 = Conversions.ToDouble(Variabile);
			if (num2 == 0.0)
			{
				goto IL_00bf;
			}
			if (!flag2)
			{
				flag2 = true;
				goto IL_00bf;
			}
			rsMess = TranslateMessage("XXX", "Solo 1 tra Fisso, Variabile e Percentuale può essere valorizzato");
			goto end_IL_0025;
			IL_0116:
			if (!flag2)
			{
				rsMess = TranslateMessage("XXX", "Valorizzare 1 tra Fisso, Variabile e Percentuale");
			}
			else
			{
				flag = true;
			}
			goto end_IL_0025;
			IL_00bf:
			if (Operators.CompareString(Percentuale, "", false) == 0)
			{
				goto IL_0116;
			}
			num3 = Conversions.ToDouble(Percentuale);
			if (num3 == 0.0)
			{
				goto IL_0116;
			}
			if (!flag2)
			{
				flag2 = true;
				goto IL_0116;
			}
			rsMess = TranslateMessage("XXX", "Solo 1 tra Fisso, Variabile e Percentuale può essere valorizzato");
			end_IL_0025:;
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
			result = flag;
		}
		return result;
	}

	private bool ControlloFasciaSuperioreMassima(string IdVoce, double FasciaSuperiore, ref string rsMess)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		DataRow dataRow = null;
		bool result;
		try
		{
			rsMess = "";
			if (FasciaSuperiore != (double)kMaxValueForFascia)
			{
				rsMess = TranslateMessage("XXX", "Ultima Fascia deve avere valore massimo a 999999999");
				dataRow = _MultiViewConfig.DataTable[2].Rows.Add();
				dataRow["_ROWID"] = Guid.NewGuid().ToString();
				dataRow["_ROWSTATE"] = "I";
				dataRow["IdVoce"] = IdVoce;
				IboWebParam parametrica = base.Parametrica;
				string text = "";
				long num = default(long);
				parametrica.LeggiContatore("COUNTERS.TRA.TARIFFEATTIVE.FASCE", false, ref num, ref text);
				dataRow["IdFascia"] = num;
				dataRow["Fisso"] = 0;
				dataRow["Variabile"] = 0;
				dataRow["Percentuale"] = 0;
				dataRow["FasciaSuperiore"] = kMaxValueForFascia;
				dataRow["FasciaInferiore"] = 0;
			}
			else
			{
				flag = true;
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
			result = flag;
		}
		return result;
	}
}
