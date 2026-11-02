using System;
using System.Collections;
using System.Data;
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

public class WFANATipiMezzo : WFIDBPage
{
	public struct EquipaggiamentoMezzo
	{
		public string CodiceEquipaggiamento_0;

		public string Descrizione_0;

		public string Abilitato_0;

		public string CodiceEquipaggiamento_1;

		public string Descrizione_1;

		public string Abilitato_1;

		public string CodiceEquipaggiamento_2;

		public string Descrizione_2;

		public string Abilitato_2;
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RepeaterEquipMezzo")]
	private Repeater _RepeaterEquipMezzo;

	private ArrayList EquipaggiamentoMezzoList;

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

	[field: AccessedThroughProperty("lblCategoria")]
	protected virtual IboWebLabel lblCategoria
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCategoria")]
	protected virtual IboWebComboTlk cmbCategoria
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

	[field: AccessedThroughProperty("lblProfiloVelocita")]
	protected virtual IboWebLabel lblProfiloVelocita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbProfiloVelocita")]
	protected virtual IboWebComboTlk cmbProfiloVelocita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumMaxFermate")]
	protected virtual IboWebLabel lblNumMaxFermate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumMaxFermate")]
	protected virtual IboWebNumericTlk txtNumMaxFermate
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

	[field: AccessedThroughProperty("tpEquipaggiamenti")]
	protected virtual TabPanel tpEquipaggiamenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpEquipaggiamentiCaption")]
	protected virtual IboWebLabel tpEquipaggiamentiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEquipaggiamento_Title")]
	protected virtual Panel cpEquipaggiamento_Title
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

	[field: AccessedThroughProperty("cpEquipaggiamento_Body")]
	protected virtual Panel cpEquipaggiamento_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater RepeaterEquipMezzo
	{
		[CompilerGenerated]
		get
		{
			return _RepeaterEquipMezzo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(RepeaterEquipMezzo_ItemDataBound);
			RepeaterItemEventHandler val2 = new RepeaterItemEventHandler(RepeaterEquipMezzo_ItemCreated);
			Repeater repeaterEquipMezzo = _RepeaterEquipMezzo;
			if (repeaterEquipMezzo != null)
			{
				repeaterEquipMezzo.ItemDataBound -= val;
				repeaterEquipMezzo.ItemCreated -= val2;
			}
			_RepeaterEquipMezzo = value;
			repeaterEquipMezzo = _RepeaterEquipMezzo;
			if (repeaterEquipMezzo != null)
			{
				repeaterEquipMezzo.ItemDataBound += val;
				repeaterEquipMezzo.ItemCreated += val2;
			}
		}
	}

	[field: AccessedThroughProperty("lblNessunEquipaggiamento")]
	protected virtual IboWebLabel lblNessunEquipaggiamento
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

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.ANA.TIPIMEZZO";
		_Tabella = "TIPIMEZZO";
		_Title = base.Translator.Translate("XXX", "Tipo Mezzo", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
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
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Invalid comparison between Unknown and I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			EquipaggiamentoMezzoList = new ArrayList();
			text = "SELECT * FROM (SELECT E.Codice, E.Descrizione, 'S' Abilitato ";
			text += "FROM Equipaggiamenti E ";
			text += "LEFT JOIN TipiMezzoEquipaggiamenti TME ";
			text += "ON E.Codice = TME.Equipaggiamento ";
			text = text + "WHERE E.Attivo='S' AND TME.TipoMezzo = " + base.DbConn.SQLFormatString(txtCodice.Text);
			text += " UNION ";
			text += "SELECT E.Codice, E.Descrizione, 'N' Abilitato ";
			text += "FROM Equipaggiamenti E ";
			text += "WHERE E.Codice NOT IN (";
			text += "SELECT E.Codice ";
			text += "FROM Equipaggiamenti E ";
			text += "LEFT JOIN TipiMezzoEquipaggiamenti TME ";
			text += "ON E.Codice = TME.Equipaggiamento ";
			text = text + "WHERE E.Attivo='S' AND TME.TipoMezzo = " + base.DbConn.SQLFormatString(txtCodice.Text);
			text += ")) T ORDER BY T.Descrizione";
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count > 0)
				{
					int num = 0;
					EquipaggiamentoMezzo equipaggiamentoMezzo = default(EquipaggiamentoMezzo);
					foreach (DataRow row in dataTable.Rows)
					{
						if (num % 3 == 0)
						{
							equipaggiamentoMezzo = default(EquipaggiamentoMezzo);
							equipaggiamentoMezzo.CodiceEquipaggiamento_0 = row["Codice"].ToString();
							equipaggiamentoMezzo.Descrizione_0 = row["Descrizione"].ToString();
							equipaggiamentoMezzo.Abilitato_0 = row["Abilitato"].ToString();
							if (num == checked(dataTable.Rows.Count - 1))
							{
								equipaggiamentoMezzo.CodiceEquipaggiamento_1 = "";
								equipaggiamentoMezzo.Descrizione_1 = "";
								equipaggiamentoMezzo.Abilitato_1 = "";
								equipaggiamentoMezzo.CodiceEquipaggiamento_2 = "";
								equipaggiamentoMezzo.Descrizione_2 = "";
								equipaggiamentoMezzo.Abilitato_2 = "";
								EquipaggiamentoMezzoList.Add(equipaggiamentoMezzo);
							}
						}
						else if (num % 3 == 1)
						{
							equipaggiamentoMezzo.CodiceEquipaggiamento_1 = row["Codice"].ToString();
							equipaggiamentoMezzo.Descrizione_1 = row["Descrizione"].ToString();
							equipaggiamentoMezzo.Abilitato_1 = row["Abilitato"].ToString();
							if (num == checked(dataTable.Rows.Count - 1))
							{
								equipaggiamentoMezzo.CodiceEquipaggiamento_2 = "";
								equipaggiamentoMezzo.Descrizione_2 = "";
								equipaggiamentoMezzo.Abilitato_2 = "";
								EquipaggiamentoMezzoList.Add(equipaggiamentoMezzo);
							}
						}
						else if (num % 3 == 2)
						{
							equipaggiamentoMezzo.CodiceEquipaggiamento_2 = row["Codice"].ToString();
							equipaggiamentoMezzo.Descrizione_2 = row["Descrizione"].ToString();
							equipaggiamentoMezzo.Abilitato_2 = row["Abilitato"].ToString();
							EquipaggiamentoMezzoList.Add(equipaggiamentoMezzo);
						}
						num = checked(num + 1);
					}
					RepeaterEquipMezzo.DataSource = EquipaggiamentoMezzoList;
					RepeaterEquipMezzo.DataBind();
				}
				else
				{
					lblNessunEquipaggiamento.Visible = true;
				}
				val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Invalid comparison between Unknown and I4
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
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
				text = "DELETE FROM TipiMezzoEquipaggiamenti WHERE TipoMezzo=" + base.DbConn.SQLFormatString(txtCodice.Text) + ";";
				foreach (RepeaterItem item in RepeaterEquipMezzo.Items)
				{
					RepeaterItem val3 = item;
					IboWebCheckBox val4 = (IboWebCheckBox)((Control)val3).FindControl("chkEquipaggiamento_0");
					IboWebCheckBox val5 = (IboWebCheckBox)((Control)val3).FindControl("chkEquipaggiamento_1");
					IboWebCheckBox val6 = (IboWebCheckBox)((Control)val3).FindControl("chkEquipaggiamento_2");
					HiddenField val7 = (HiddenField)((Control)val3).FindControl("codEquipaggiamento_0");
					HiddenField val8 = (HiddenField)((Control)val3).FindControl("codEquipaggiamento_1");
					HiddenField val9 = (HiddenField)((Control)val3).FindControl("codEquipaggiamento_2");
					if (((CheckBox)val4).Checked)
					{
						text += "INSERT INTO TipiMezzoEquipaggiamenti(TipoMezzo,Equipaggiamento,UteIns,UteAgg) VALUES (";
						text = text + base.DbConn.SQLFormatString(txtCodice.Text) + ", ";
						text = text + base.DbConn.SQLFormatString(val7.Value) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");";
					}
					if (((CheckBox)val5).Checked)
					{
						text += "INSERT INTO TipiMezzoEquipaggiamenti(TipoMezzo,Equipaggiamento,UteIns,UteAgg) VALUES (";
						text = text + base.DbConn.SQLFormatString(txtCodice.Text) + ", ";
						text = text + base.DbConn.SQLFormatString(val8.Value) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");";
					}
					if (((CheckBox)val6).Checked)
					{
						text += "INSERT INTO TipiMezzoEquipaggiamenti(TipoMezzo,Equipaggiamento,UteIns,UteAgg) VALUES (";
						text = text + base.DbConn.SQLFormatString(txtCodice.Text) + ", ";
						text = text + base.DbConn.SQLFormatString(val9.Value) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");";
					}
				}
				val2 = base.DbConn.SqlExec(text, ref rsMess);
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

	private void RepeaterEquipMezzo_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			CallStackAdd();
			text = TranslateMessage("XXX", "Errore nel data bind degli equipaggiamenti");
			EquipaggiamentoMezzo equipaggiamentoMezzo = (EquipaggiamentoMezzo)e.Item.DataItem;
			((IboWebLabel)GetControlByName((Control)(object)e.Item, "lblEquipaggiamento_0")).Text = equipaggiamentoMezzo.Descrizione_0;
			((CheckBox)(IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_0")).Checked = Operators.CompareString(equipaggiamentoMezzo.Abilitato_0, "S", false) == 0;
			((IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_0")).Enabled = ((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) ? true : false);
			((HiddenField)GetControlByName((Control)(object)e.Item, "codEquipaggiamento_0")).Value = equipaggiamentoMezzo.CodiceEquipaggiamento_0;
			((IboWebLabel)GetControlByName((Control)(object)e.Item, "lblEquipaggiamento_1")).Text = equipaggiamentoMezzo.Descrizione_1;
			((CheckBox)(IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_1")).Checked = Operators.CompareString(equipaggiamentoMezzo.Abilitato_1, "S", false) == 0;
			((IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_1")).Visible = ((Operators.CompareString(equipaggiamentoMezzo.Descrizione_1, "", false) != 0) ? true : false);
			((IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_1")).Enabled = ((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) ? true : false);
			((HiddenField)GetControlByName((Control)(object)e.Item, "codEquipaggiamento_1")).Value = equipaggiamentoMezzo.CodiceEquipaggiamento_1;
			((IboWebLabel)GetControlByName((Control)(object)e.Item, "lblEquipaggiamento_2")).Text = equipaggiamentoMezzo.Descrizione_2;
			((CheckBox)(IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_2")).Checked = Operators.CompareString(equipaggiamentoMezzo.Abilitato_2, "S", false) == 0;
			((IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_2")).Visible = ((Operators.CompareString(equipaggiamentoMezzo.Descrizione_2, "", false) != 0) ? true : false);
			((IboWebCheckBox)GetControlByName((Control)(object)e.Item, "chkEquipaggiamento_2")).Enabled = ((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) ? true : false);
			((HiddenField)GetControlByName((Control)(object)e.Item, "codEquipaggiamento_2")).Value = equipaggiamentoMezzo.CodiceEquipaggiamento_2;
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
				WriteErrorMessage(rsMess + "-" + text);
			}
		}
	}

	private void RepeaterEquipMezzo_ItemCreated(object sender, RepeaterItemEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			rsMess = TranslateMessage("XXX", "Errore nella creazione degli item per gli equipaggiamenti");
			RepeaterItem item = e.Item;
			IboWebCheckBox val2 = (IboWebCheckBox)((Control)item).FindControl("chkEquipaggiamento_0");
			IboWebCheckBox val3 = (IboWebCheckBox)((Control)item).FindControl("chkEquipaggiamento_1");
			IboWebCheckBox val4 = (IboWebCheckBox)((Control)item).FindControl("chkEquipaggiamento_2");
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
}
