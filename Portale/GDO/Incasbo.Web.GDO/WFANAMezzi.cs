using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAMezzi : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkDiProprieta")]
	private IboWebCheckBox _chkDiProprieta;

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

	[field: AccessedThroughProperty("up_tpGen")]
	protected virtual UpdatePanel up_tpGen
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

	[field: AccessedThroughProperty("lblMatricola")]
	protected virtual IboWebLabel lblMatricola
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMatricola")]
	protected virtual IboWebTextBox txtMatricola
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDiProprieta")]
	protected virtual IboWebLabel lblDiProprieta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox chkDiProprieta
	{
		[CompilerGenerated]
		get
		{
			return _chkDiProprieta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkDiProprieta_CheckedChanged;
			IboWebCheckBox val = _chkDiProprieta;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged -= eventHandler;
			}
			_chkDiProprieta = value;
			val = _chkDiProprieta;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDispDalleOre")]
	protected virtual IboWebLabel lblDispDalleOre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDispDalleOre")]
	protected virtual IboWebDate2 txtDispDalleOre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDispAlleOre")]
	protected virtual IboWebLabel lblDispAlleOre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDispAlleOre")]
	protected virtual IboWebDate2 txtDispAlleOre
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

	[field: AccessedThroughProperty("lblDescrizione")]
	protected virtual IboWebLabel lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescrizione")]
	protected virtual IboWebTextBox txtDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMarca")]
	protected virtual IboWebLabel lblMarca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMarca")]
	protected virtual IboWebTextBox txtMarca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTarga")]
	protected virtual IboWebLabel lblTarga
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTarga")]
	protected virtual IboWebTextBox txtTarga
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

	[field: AccessedThroughProperty("lblAutista")]
	protected virtual IboWebLabel lblAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbAutista")]
	protected virtual IboWebComboTlk cmbAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPortate_Title")]
	protected virtual Panel cpPortate_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPortate_Title_Caption")]
	protected virtual Label cpPortate_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPortate_Body")]
	protected virtual Panel cpPortate_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataPeso")]
	protected virtual IboWebLabel lblPortataPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataPeso")]
	protected virtual IboWebNumericTlk txtPortataPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazionePeso")]
	protected virtual IboWebLabel lblGradoSaturazionePeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazionePeso")]
	protected virtual IboWebNumericTlk txtGradoSaturazionePeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataVolume")]
	protected virtual IboWebLabel lblPortataVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataVolume")]
	protected virtual IboWebNumericTlk txtPortataVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneVolume")]
	protected virtual IboWebLabel lblGradoSaturazioneVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneVolume")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataMetriLineari")]
	protected virtual IboWebLabel lblPortataMetriLineari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataMetriLineari")]
	protected virtual IboWebNumericTlk txtPortataMetriLineari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneML")]
	protected virtual IboWebLabel lblGradoSaturazioneML
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneML")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneML
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataColli")]
	protected virtual IboWebLabel lblPortataColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataColli")]
	protected virtual IboWebNumericTlk txtPortataColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneColli")]
	protected virtual IboWebLabel lblGradoSaturazioneColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneColli")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataPallet")]
	protected virtual IboWebLabel lblPortataPallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataPallet")]
	protected virtual IboWebNumericTlk txtPortataPallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazionePallet")]
	protected virtual IboWebLabel lblGradoSaturazionePallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazionePallet")]
	protected virtual IboWebNumericTlk txtGradoSaturazionePallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataRoll")]
	protected virtual IboWebLabel lblPortataRoll
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataRoll")]
	protected virtual IboWebNumericTlk txtPortataRoll
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneRoll")]
	protected virtual IboWebLabel lblGradoSaturazioneRoll
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneRoll")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneRoll
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataQ1")]
	protected virtual IboWebLabel lblPortataQ1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataQ1")]
	protected virtual IboWebNumericTlk txtPortataQ1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneQ1")]
	protected virtual IboWebLabel lblGradoSaturazioneQ1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneQ1")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneQ1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataQ2")]
	protected virtual IboWebLabel lblPortataQ2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataQ2")]
	protected virtual IboWebNumericTlk txtPortataQ2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneQ2")]
	protected virtual IboWebLabel lblGradoSaturazioneQ2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneQ2")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneQ2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPortataQ3")]
	protected virtual IboWebLabel lblPortataQ3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPortataQ3")]
	protected virtual IboWebNumericTlk txtPortataQ3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGradoSaturazioneQ3")]
	protected virtual IboWebLabel lblGradoSaturazioneQ3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGradoSaturazioneQ3")]
	protected virtual IboWebNumericTlk txtGradoSaturazioneQ3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDimensioni_Title")]
	protected virtual Panel cpDimensioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDimensioni_Title_Caption")]
	protected virtual Label cpDimensioni_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDimensioni_Body")]
	protected virtual Panel cpDimensioni_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClasseDiGrandezza")]
	protected virtual IboWebLabel lblClasseDiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbClasseDiGrandezza")]
	protected virtual IboWebComboTlk cmbClasseDiGrandezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLunghezzaPianale")]
	protected virtual IboWebLabel lblLunghezzaPianale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLunghezzaPianale")]
	protected virtual IboWebNumericTlk txtLunghezzaPianale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLunghezza")]
	protected virtual IboWebLabel lblLunghezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLunghezza")]
	protected virtual IboWebNumericTlk txtLunghezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLarghezza")]
	protected virtual IboWebLabel lblLarghezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLarghezza")]
	protected virtual IboWebNumericTlk txtLarghezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAltezza")]
	protected virtual IboWebLabel lblAltezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAltezza")]
	protected virtual IboWebNumericTlk txtAltezza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTara")]
	protected virtual IboWebLabel lblTara
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTara")]
	protected virtual IboWebNumericTlk txtTara
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAssi")]
	protected virtual IboWebLabel lblAssi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAssi")]
	protected virtual IboWebNumericTlk txtAssi
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

	[field: AccessedThroughProperty("lblNumMaxReimpieghi")]
	protected virtual IboWebLabel lblNumMaxReimpieghi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumMaxReimpieghi")]
	protected virtual IboWebNumericTlk txtNumMaxReimpieghi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTempoReimpiego")]
	protected virtual IboWebLabel lblTempoReimpiego
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTempoReimpiego")]
	protected virtual IboWebDate2 txtTempoReimpiego
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoPartenza")]
	protected virtual IboWebLabel lblPuntoPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPuntoPartenza")]
	protected virtual IboWebComboTlk cmbPuntoPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPuntoArrivo")]
	protected virtual IboWebLabel lblPuntoArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPuntoArrivo")]
	protected virtual IboWebComboTlk cmbPuntoArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltriDati_Title")]
	protected virtual Panel cpAltriDati_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamento_Title_Caption")]
	protected virtual IboWebLabel cpEquipaggiamento_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAltriDati_Body")]
	protected virtual Panel cpAltriDati_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTelaio")]
	protected virtual IboWebLabel lblTelaio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTelaio")]
	protected virtual IboWebTextBox txtTelaio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAnnoImmatr")]
	protected virtual IboWebLabel lblAnnoImmatr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAnnoImmatr")]
	protected virtual IboWebNumericTlk txtAnnoImmatr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmInizio")]
	protected virtual IboWebLabel lblKmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmInizio")]
	protected virtual IboWebNumericTlk txtKmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmAttuali")]
	protected virtual IboWebLabel lblKmAttuali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKmAttuali")]
	protected virtual IboWebNumericTlk txtKmAttuali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataAcquisto")]
	protected virtual IboWebLabel lblDataAcquisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataAcquisto")]
	protected virtual IboWebDate2 txtDataAcquisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblValoreAcquisto")]
	protected virtual IboWebLabel lblValoreAcquisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtValoreAcquisto")]
	protected virtual IboWebNumericTlk txtValoreAcquisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataAlienazione")]
	protected virtual IboWebLabel lblDataAlienazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataAlienazione")]
	protected virtual IboWebDate2 txtDataAlienazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCapacitaSerbatoio")]
	protected virtual IboWebLabel lblCapacitaSerbatoio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCapacitaSerbatoio")]
	protected virtual IboWebNumericTlk txtCapacitaSerbatoio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCavalliFiscali")]
	protected virtual IboWebLabel lblCavalliFiscali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCavalliFiscali")]
	protected virtual IboWebNumericTlk txtCavalliFiscali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblConsumoStandard")]
	protected virtual IboWebLabel lblConsumoStandard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtConsumoStandard")]
	protected virtual IboWebNumericTlk txtConsumoStandard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEmissioneCO2")]
	protected virtual IboWebLabel lblEmissioneCO2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEmissioneCO2")]
	protected virtual IboWebNumericTlk txtEmissioneCO2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optNuovoUsato")]
	protected virtual IboWebRadioButtonList optNuovoUsato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDimensionePneumatici")]
	protected virtual IboWebLabel lblDimensionePneumatici
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDimensionePneumatici")]
	protected virtual IboWebTextBox txtDimensionePneumatici
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoCerchione")]
	protected virtual IboWebLabel lblTipoCerchione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optTipoCerchione")]
	protected virtual IboWebRadioButtonList optTipoCerchione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMaterialeCerchione")]
	protected virtual IboWebLabel lblMaterialeCerchione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optMaterialeCerchione")]
	protected virtual IboWebRadioButtonList optMaterialeCerchione
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

	[field: AccessedThroughProperty("tpImmagini")]
	protected virtual TabPanel tpImmagini
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpImmaginiCaption")]
	protected virtual IboWebLabel tpImmaginiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title")]
	protected virtual Panel cpFoto_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title_Caption")]
	protected virtual IboWebLabel cpFoto_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Body")]
	protected virtual Panel cpFoto_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine1")]
	protected virtual IboWebImage imgImmagine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine2")]
	protected virtual IboWebImage imgImmagine2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine3")]
	protected virtual IboWebImage imgImmagine3
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

	[field: AccessedThroughProperty("up_tpDocumenti")]
	protected virtual UpdatePanel up_tpDocumenti
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

	[field: AccessedThroughProperty("tlbgrdMezziDocumenti")]
	protected virtual IboWebToolbar tlbgrdMezziDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMezziDocumenti")]
	protected virtual Panel pnlMezziDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdMezziDocumenti")]
	protected virtual IboGridView grdMezziDocumenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("up_tpInfoAgg")]
	protected virtual UpdatePanel up_tpInfoAgg
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

	[field: AccessedThroughProperty("tlbgrdMezziInfoAggiuntive")]
	protected virtual IboWebToolbar tlbgrdMezziInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMezziInfoAggiuntive")]
	protected virtual Panel pnlMezziInfoAggiuntive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdMezziInfoAggiuntive")]
	protected virtual IboGridView grdMezziInfoAggiuntive
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

	[field: AccessedThroughProperty("MezziClassi")]
	protected virtual IboWebCheckBoxList MezziClassi
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

	[field: AccessedThroughProperty("Button1_idle")]
	protected virtual Button Button1_idle
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
		_Context = "DM.ANA.MEZZI";
		_AutoCodeKeyField = "Codice";
		_Tabella = "MEZZI";
		_Title = base.Translator.Translate("XXX", "Mezzo", new string[0]);
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
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
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
			IboGridView objGridView = grdMezziInfoAggiuntive;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdMezziInfoAggiuntive = objGridView;
			iboInternalGridConfig.Build("DM.ANA.INFOAGGANAGRAFICHE#MEZ", "SELECT * FROM GRD_ANA_Mezzi_InfoAgg WHERE CodiceMezzo='<%CODICE%>'", "", "", ((Control)grdMezziInfoAggiuntive).ID, ((Control)tlbgrdMezziInfoAggiuntive).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdMezziDocumenti;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdMezziDocumenti = objGridView;
			iboInternalGridConfig.Build("DM.ANA.DOCUMENTIANA#MEZZI", "SELECT * FROM GRD_ANA_Mezzi_Documenti WHERE CodiceMezzo='<%CODICE%>'", "", "", ((Control)grdMezziDocumenti).ID, ((Control)tlbgrdMezziDocumenti).ID);
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

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadPage(ref rsMess);
			if ((int)val2 <= 0)
			{
				string text = "";
				string text2 = "";
				string text3 = "";
				text = base.Parametrica.LeggiParametro("PORTATA.Q1", ref val2, ref rsMess);
				text2 = base.Parametrica.LeggiParametro("PORTATA.Q2", ref val2, ref rsMess);
				text3 = base.Parametrica.LeggiParametro("PORTATA.Q3", ref val2, ref rsMess);
				if (Operators.CompareString(text, "", false) != 0)
				{
					lblPortataQ1.ObjValue = (text.EndsWith(":") ? text : (text + ":"));
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					lblPortataQ2.ObjValue = (text2.EndsWith(":") ? text2 : (text2 + ":"));
				}
				if (Operators.CompareString(text3, "", false) != 0)
				{
					lblPortataQ3.ObjValue = (text3.EndsWith(":") ? text3 : (text3 + ":"));
				}
				checked
				{
					lblGradoSaturazioneQ1.ObjValue = "Satur. " + lblPortataQ1.ObjValue.ToString().Substring(0, lblPortataQ1.ObjValue.ToString().Length - 1) + "(%):";
					lblGradoSaturazioneQ2.ObjValue = "Satur. " + lblPortataQ2.ObjValue.ToString().Substring(0, lblPortataQ2.ObjValue.ToString().Length - 1) + "(%):";
					lblGradoSaturazioneQ3.ObjValue = "Satur. " + lblPortataQ3.ObjValue.ToString().Substring(0, lblPortataQ3.ObjValue.ToString().Length - 1) + "(%):";
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
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
				if (((CheckBox)chkDiProprieta).Checked)
				{
					IboWebComboTlk objCombo = cmbTrasportatore;
					string sItemValue = base.SessionEnvironment.ApplicationDefault.Trasportatore_Default();
					string rsMess2 = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo, sItemValue, ref rsMess2);
					cmbTrasportatore.ReadOnly = true;
					cmbTrasportatore.Required = false;
				}
				else
				{
					cmbTrasportatore.ReadOnly = false;
					cmbTrasportatore.Required = true;
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

	protected override FXRETURN BeforeCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
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
				if (Operators.CompareString(txtMatricola.ObjValue.ToString(), "", false) == 0)
				{
					txtMatricola.ObjValue = RuntimeHelpers.GetObjectValue(txtCodice.ObjValue);
				}
				text = "Select Count(*) as N  From Mezzi Where Attivo='S'";
				text = text + " And Matricola = " + base.DbConn.SQLFormatString(txtMatricola.ObjValue.ToString());
				text = text + " And Codice <> " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Conversions.ToInteger(obj) > 0)
				{
					rsMess = "La matricola è assegnata ad un altro Codice mezzo";
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

	private void btnTuttiClassi_Click(object sender, EventArgs e)
	{
		MezziClassi.SelectAll();
	}

	private void btnNessunoClassi_Click(object sender, EventArgs e)
	{
		MezziClassi.UnselectAll();
	}

	private void chkDiProprieta_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (((CheckBox)chkDiProprieta).Checked)
			{
				IboWebComboTlk objCombo = cmbTrasportatore;
				string sItemValue = base.SessionEnvironment.ApplicationDefault.Trasportatore_Default();
				string rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, sItemValue, ref rsMess2);
				cmbTrasportatore.ReadOnly = true;
				cmbTrasportatore.Required = false;
			}
			else
			{
				IboWebComboTlk objCombo2 = cmbTrasportatore;
				string rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo2, "", ref rsMess2);
				cmbTrasportatore.ReadOnly = false;
				cmbTrasportatore.Required = true;
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
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = txtCodice.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			PropertyValue = txtDescrizione.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "MEZZI";
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
			PropertyValue = txtDescrizione.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "MEZZI";
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
			PropertyValue = txtDescrizione.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "MEZZI";
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
			PropertyValue = txtDescrizione.Text;
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblDescrizioneSoggettoValue", "Text", ref PropertyValue);
			string redirectToOnlyAspxPageName = objInternalGridConfig.RedirectToOnlyAspxPageName;
			object PropertyValue2 = "MEZZI";
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
}
