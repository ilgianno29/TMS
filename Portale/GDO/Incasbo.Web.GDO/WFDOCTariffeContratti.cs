using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCTariffeContratti : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbAttivaPassiva")]
	private IboDropDownList _cmbAttivaPassiva;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTrasportatore")]
	private IboWebComboTlk _cmbTrasportatore;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkRaggruppamento")]
	private IboWebCheckBox _chkRaggruppamento;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RepeaterVoci")]
	private Repeater _RepeaterVoci;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTuttiVoci")]
	private IboWebButton _btnTuttiVoci;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNessunoVoci")]
	private IboWebButton _btnNessunoVoci;

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

	[field: AccessedThroughProperty("lblContrattoTrasporto")]
	protected virtual IboWebLabel lblContrattoTrasporto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkContrattoTrasporto")]
	protected virtual IboWebCheckBox chkContrattoTrasporto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrattoGiacenza")]
	protected virtual IboWebLabel lblContrattoGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkContrattoGiacenza")]
	protected virtual IboWebCheckBox chkContrattoGiacenza
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

	[field: AccessedThroughProperty("lblAttivaPassiva")]
	protected virtual IboWebLabel lblAttivaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbAttivaPassiva
	{
		[CompilerGenerated]
		get
		{
			return _cmbAttivaPassiva;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmbAttivaPassiva_SelectedIndexChanged;
			IboDropDownList val = _cmbAttivaPassiva;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbAttivaPassiva = value;
			val = _cmbAttivaPassiva;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblClienteTrasportatore")]
	protected virtual IboWebLabel lblClienteTrasportatore
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

	protected virtual IboWebComboTlk cmbTrasportatore
	{
		[CompilerGenerated]
		get
		{
			return _cmbTrasportatore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxItemEventHandler val = new RadComboBoxItemEventHandler(cmbTrasportatore_ItemDataBound);
			IboWebComboTlk val2 = _cmbTrasportatore;
			if (val2 != null)
			{
				((RadComboBox)val2).ItemDataBound -= val;
			}
			_cmbTrasportatore = value;
			val2 = _cmbTrasportatore;
			if (val2 != null)
			{
				((RadComboBox)val2).ItemDataBound += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblDataInizioValidita")]
	protected virtual IboWebLabel lblDataInizioValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataInizioValidita")]
	protected virtual IboWebDate txtDataInizioValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFineValidita")]
	protected virtual IboWebLabel lblDataFineValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataFineValidita")]
	protected virtual IboWebDate txtDataFineValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTassazioneRiconsegne")]
	protected virtual IboWebLabel lblTassazioneRiconsegne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTassazioneRiconsegne")]
	protected virtual IboWebCheckBox chkTassazioneRiconsegne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPercentualeRiconsegne")]
	protected virtual IboWebLabel lblPercentualeRiconsegne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPercentualeRiconsegne")]
	protected virtual IboWebNumericTlk txtPercentualeRiconsegne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRapportoPV")]
	protected virtual IboWebLabel lblRapportoPV
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

	[field: AccessedThroughProperty("lblTassazioneResi")]
	protected virtual IboWebLabel lblTassazioneResi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTassazioneResi")]
	protected virtual IboWebCheckBox chkTassazioneResi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPercentualeResi")]
	protected virtual IboWebLabel lblPercentualeResi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPercentualeResi")]
	protected virtual IboWebNumericTlk txtPercentualeResi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblArrotondamentoImporti")]
	protected virtual IboWebLabel lblArrotondamentoImporti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtArrotondamentoImporti")]
	protected virtual IboWebNumericTlk txtArrotondamentoImporti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRaggruppamenti_Title")]
	protected virtual Panel cpRaggruppamenti_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRaggruppamenti_Title_Caption")]
	protected virtual Label cpRaggruppamenti_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRaggruppamenti_Body")]
	protected virtual Panel cpRaggruppamenti_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RaggruppamentoSpedizione")]
	protected virtual Table RaggruppamentoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRaggruppamento")]
	protected virtual IboWebLabel lblRaggruppamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox chkRaggruppamento
	{
		[CompilerGenerated]
		get
		{
			return _chkRaggruppamento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkRaggruppamento_CheckedChanged;
			IboWebCheckBox val = _chkRaggruppamento;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged -= eventHandler;
			}
			_chkRaggruppamento = value;
			val = _chkRaggruppamento;
			if (val != null)
			{
				((CheckBox)val).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("labelIncludiMittente")]
	protected virtual TableCell labelIncludiMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIncludiMittente")]
	protected virtual IboWebLabel lblIncludiMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkIncludiMittente")]
	protected virtual TableCell checkIncludiMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkIncludiMittente")]
	protected virtual IboWebCheckBox chkIncludiMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labelIncludiCliente")]
	protected virtual TableCell labelIncludiCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIncludiCliente")]
	protected virtual IboWebLabel lblIncludiCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkIncludiCliente")]
	protected virtual TableCell checkIncludiCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkIncludiCliente")]
	protected virtual IboWebCheckBox chkIncludiCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labelIncludiPCSPartenza")]
	protected virtual TableCell labelIncludiPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIncludiPCSPartenza")]
	protected virtual IboWebLabel lblIncludiPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkIncludiPCSPartenza")]
	protected virtual TableCell checkIncludiPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkIncludiPCSPartenza")]
	protected virtual IboWebCheckBox chkIncludiPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title")]
	protected virtual Panel cpVoci_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Title_Caption")]
	protected virtual Label cpVoci_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpVoci_Body")]
	protected virtual Panel cpVoci_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlVociContainer")]
	protected virtual IboWebPanel pnlVociContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneVoce")]
	protected virtual IboWebLabel lblDescrizioneVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRaggruppaVoce")]
	protected virtual IboWebLabel lblRaggruppaVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoRipartizione")]
	protected virtual IboWebLabel lblTipoRipartizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater RepeaterVoci
	{
		[CompilerGenerated]
		get
		{
			return _RepeaterVoci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(RepeaterVoci_ItemDataBound);
			Repeater repeaterVoci = _RepeaterVoci;
			if (repeaterVoci != null)
			{
				repeaterVoci.ItemDataBound -= val;
			}
			_RepeaterVoci = value;
			repeaterVoci = _RepeaterVoci;
			if (repeaterVoci != null)
			{
				repeaterVoci.ItemDataBound += val;
			}
		}
	}

	[field: AccessedThroughProperty("pnlVociCommands")]
	protected virtual IboWebPanel pnlVociCommands
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnTuttiVoci
	{
		[CompilerGenerated]
		get
		{
			return _btnTuttiVoci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTuttiVoci_Click;
			IboWebButton val = _btnTuttiVoci;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTuttiVoci = value;
			val = _btnTuttiVoci;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnNessunoVoci
	{
		[CompilerGenerated]
		get
		{
			return _btnNessunoVoci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnNessunoVoci_Click;
			IboWebButton val = _btnNessunoVoci;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnNessunoVoci = value;
			val = _btnNessunoVoci;
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
		_Context = "DM.DOC.TARIFFE.CONTRATTI";
		_Title = base.Translator.Translate("XXX", "Gestione Contratto", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) != 0)
			{
				cmbAttivaPassiva.ReadOnly = true;
			}
			else if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
			{
				cmbAttivaPassiva.ObjValue = "A";
			}
			CambiaRaggruppamento();
			CambioTipologiaTariffa();
			val2 = PopolaRepeaterVoci(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
				{
					txtCodice.InitialValue = txtCodice.Text;
				}
				val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = SalvaVoci(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) != 0)
				{
					goto IL_0068;
				}
				val2 = DuplicazioneContratto(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0068;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0068:
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = ControlloValiditaContratto(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = CheckVoci(ref rsMess);
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (!((CheckBox)chkRaggruppamento).Checked)
				{
					chkIncludiCliente.ObjValue = "N";
					chkIncludiMittente.ObjValue = "N";
					chkIncludiPCSPartenza.ObjValue = "N";
				}
				else if (Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) == 0)
				{
					chkIncludiCliente.ObjValue = "N";
				}
				else
				{
					chkIncludiMittente.ObjValue = "N";
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

	private void cmbAttivaPassiva_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CambioTipologiaTariffa();
			CambiaRaggruppamento();
			cmbTrasportatore.Clear();
			cmbCliente.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CambioTipologiaTariffa()
	{
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) == 0)
		{
			cmbCliente.Visible = true;
			cmbTrasportatore.Visible = false;
			lblClienteTrasportatore.Text = "Cliente";
			if (((CheckBox)chkRaggruppamento).Checked)
			{
				((Control)labelIncludiMittente).Visible = true;
				((WebControl)labelIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(80);
				((Control)checkIncludiMittente).Visible = true;
				((WebControl)checkIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(30);
				lblIncludiMittente.Visible = true;
				chkIncludiMittente.Visible = true;
				((Control)labelIncludiPCSPartenza).Visible = true;
				((WebControl)labelIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(80);
				((Control)checkIncludiPCSPartenza).Visible = true;
				((WebControl)checkIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(30);
				lblIncludiPCSPartenza.Visible = true;
				chkIncludiPCSPartenza.Visible = true;
			}
			else
			{
				((Control)labelIncludiMittente).Visible = false;
				((WebControl)labelIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(0);
				((Control)checkIncludiMittente).Visible = false;
				((WebControl)checkIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(0);
				lblIncludiMittente.Visible = false;
				chkIncludiMittente.Visible = false;
				((Control)labelIncludiPCSPartenza).Visible = false;
				((WebControl)labelIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(0);
				((Control)checkIncludiPCSPartenza).Visible = false;
				((WebControl)checkIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(0);
				lblIncludiPCSPartenza.Visible = false;
				chkIncludiPCSPartenza.Visible = false;
			}
			((Control)labelIncludiCliente).Visible = false;
			((WebControl)labelIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(0);
			((Control)checkIncludiCliente).Visible = false;
			((WebControl)checkIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(0);
			lblIncludiCliente.Visible = false;
			chkIncludiCliente.Visible = false;
		}
		else
		{
			cmbCliente.Visible = false;
			cmbTrasportatore.Visible = true;
			lblClienteTrasportatore.Text = "Trasportatore";
			if (((CheckBox)chkRaggruppamento).Checked)
			{
				((Control)labelIncludiCliente).Visible = true;
				((WebControl)labelIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(80);
				((Control)checkIncludiCliente).Visible = true;
				((WebControl)checkIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(30);
				lblIncludiCliente.Visible = true;
				chkIncludiCliente.Visible = true;
				((Control)labelIncludiPCSPartenza).Visible = true;
				((WebControl)labelIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(80);
				((Control)checkIncludiPCSPartenza).Visible = true;
				((WebControl)checkIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(30);
				lblIncludiPCSPartenza.Visible = true;
				chkIncludiPCSPartenza.Visible = true;
			}
			else
			{
				((Control)labelIncludiCliente).Visible = false;
				((WebControl)labelIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(0);
				((Control)checkIncludiCliente).Visible = false;
				((WebControl)checkIncludiCliente).Width = (System.Web.UI.WebControls.Unit)(0);
				lblIncludiCliente.Visible = false;
				chkIncludiCliente.Visible = false;
				((Control)labelIncludiPCSPartenza).Visible = false;
				((WebControl)labelIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(0);
				((Control)checkIncludiPCSPartenza).Visible = false;
				((WebControl)checkIncludiPCSPartenza).Width = (System.Web.UI.WebControls.Unit)(0);
				lblIncludiPCSPartenza.Visible = false;
				chkIncludiPCSPartenza.Visible = false;
			}
			((Control)labelIncludiMittente).Visible = false;
			((WebControl)labelIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(0);
			((Control)checkIncludiMittente).Visible = false;
			((WebControl)checkIncludiMittente).Width = (System.Web.UI.WebControls.Unit)(0);
			lblIncludiMittente.Visible = false;
			chkIncludiMittente.Visible = false;
		}
	}

	private void cmbTrasportatore_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
	{
		try
		{
			if (((RadComboBox)cmbTrasportatore).Items.FindItemByValue(e.Item.Value) == null)
			{
				((RadComboBox)cmbTrasportatore).Items.Add(e.Item);
			}
			base.MasterPage.MasterUpdatePanel.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btnNessunoVoci_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		DeSelezionaTutteLeVoci(ref rsMess);
	}

	private void btnTuttiVoci_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		SelezionaTutteLeVoci(ref rsMess);
	}

	private void chkRaggruppamento_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CambiaRaggruppamento();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CambiaRaggruppamento()
	{
		if (((CheckBox)chkRaggruppamento).Checked)
		{
			if (Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) == 0)
			{
				((Control)labelIncludiMittente).Visible = true;
				lblIncludiMittente.Visible = true;
				((Control)checkIncludiMittente).Visible = true;
				chkIncludiMittente.Visible = true;
				((Control)labelIncludiCliente).Visible = false;
				lblIncludiCliente.Visible = false;
				((Control)checkIncludiCliente).Visible = false;
				chkIncludiCliente.Visible = false;
			}
			else
			{
				((Control)labelIncludiMittente).Visible = false;
				lblIncludiMittente.Visible = false;
				((Control)checkIncludiMittente).Visible = false;
				chkIncludiMittente.Visible = false;
				((Control)labelIncludiCliente).Visible = true;
				lblIncludiCliente.Visible = true;
				((Control)checkIncludiCliente).Visible = true;
				chkIncludiCliente.Visible = true;
			}
			((Control)labelIncludiPCSPartenza).Visible = true;
			lblIncludiPCSPartenza.Visible = true;
			((Control)checkIncludiPCSPartenza).Visible = true;
			chkIncludiPCSPartenza.Visible = true;
		}
		else
		{
			((Control)labelIncludiCliente).Visible = false;
			lblIncludiCliente.Visible = false;
			((Control)checkIncludiCliente).Visible = false;
			chkIncludiCliente.Visible = false;
			((Control)labelIncludiMittente).Visible = false;
			lblIncludiMittente.Visible = false;
			((Control)checkIncludiMittente).Visible = false;
			chkIncludiMittente.Visible = false;
			((Control)labelIncludiPCSPartenza).Visible = false;
			lblIncludiPCSPartenza.Visible = false;
			((Control)checkIncludiPCSPartenza).Visible = false;
			chkIncludiPCSPartenza.Visible = false;
		}
	}

	private FXRETURN ControlloValiditaContratto(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Invalid comparison between Unknown and I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) == 0) & (Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire il Cliente");
			}
			else if ((Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) != 0) & (Operators.CompareString(cmbTrasportatore.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire il Trasportatore");
			}
			else if (((Operators.CompareString(txtDataInizioValidita.Text, "", false) != 0) & (Operators.CompareString(txtDataFineValidita.Text, "", false) != 0)) && DateTime.Compare(txtDataFineValidita.DateValue, txtDataInizioValidita.DateValue) < 0)
			{
				rsMess = TranslateMessage("XXX", "La data di fine validità deve essere successiva a quella di inizio validità");
			}
			else
			{
				text = "SELECT * FROM TARIFFECONTRATTI WHERE (";
				text = text + " (DATAINIZIOVALIDITA <= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataInizioValidita.Text);
				text = text + " AND DATAFINEVALIDITA >= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataInizioValidita.Text) + ") OR";
				text = text + " (DATAINIZIOVALIDITA <= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataFineValidita.Text);
				text = text + " AND DATAFINEVALIDITA >= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataFineValidita.Text) + ") OR";
				text = text + " (DATAINIZIOVALIDITA >= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataInizioValidita.Text);
				text = text + " AND DATAFINEVALIDITA <= " + base.DbConn.SQLFormatDate((eTipoData)1, txtDataFineValidita.Text) + "))";
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					text = text + " AND CODICE <> " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				}
				text = ((Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) != 0) ? (text + " AND TRASPORTATORE = " + base.DbConn.SQLFormatString(cmbTrasportatore.ObjValue.ToString())) : (text + " AND CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString())));
				if ((Operators.CompareString(chkContrattoTrasporto.ObjValue.ToString(), "S", false) == 0) & (Operators.CompareString(chkContrattoGiacenza.ObjValue.ToString(), "S", false) == 0))
				{
					text += " AND (CONTRATTOTRASPORTO = 'S' OR CONTRATTOGIACENZA = 'S') ";
					goto IL_03fe;
				}
				if ((Operators.CompareString(chkContrattoTrasporto.ObjValue.ToString(), "S", false) == 0) & (Operators.CompareString(chkContrattoGiacenza.ObjValue.ToString(), "N", false) == 0))
				{
					text += " AND CONTRATTOTRASPORTO = 'S' ";
					goto IL_03fe;
				}
				if ((Operators.CompareString(chkContrattoTrasporto.ObjValue.ToString(), "N", false) == 0) & (Operators.CompareString(chkContrattoGiacenza.ObjValue.ToString(), "S", false) == 0))
				{
					text += " AND CONTRATTOGIACENZA = 'S' ";
					goto IL_03fe;
				}
				rsMess = TranslateMessage("XXX", "Non è stato definito l'ambito di  validità del contratto (Trasporto, Giacenza o entrambi)");
			}
			goto end_IL_000b;
			IL_03fe:
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count >= 1)
			{
				if (Operators.CompareString(cmbAttivaPassiva.ObjValue.ToString(), "A", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "E' già presente il contratto '{0}' valido da {1} a {2} per il cliente {3} nell'intervallo di tempo specificato", dataTable.Rows[0]["Codice"].ToString(), Conversions.ToDate(dataTable.Rows[0]["DataInizioValidita"]).ToString("dd/MM/yyyy"), Conversions.ToDate(dataTable.Rows[0]["DataFineValidita"]).ToString("dd/MM/yyyy"), cmbCliente.ObjValue.ToString());
				}
				else
				{
					rsMess = TranslateMessage("XXX", "E' già presente il contratto '{0}' valido da {1} a {2} per il trasportatore {3} nell'intervallo di tempo specificato", dataTable.Rows[0]["Codice"].ToString(), Conversions.ToDate(dataTable.Rows[0]["DataInizioValidita"]).ToString("dd/MM/yyyy"), Conversions.ToDate(dataTable.Rows[0]["DataFineValidita"]).ToString("dd/MM/yyyy"), cmbTrasportatore.ObjValue.ToString());
				}
			}
			else
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

	private FXRETURN PopolaRepeaterVoci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "SELECT CV.Voce, CV.TipoRipartizione, V.Descrizione DescrizioneVoce, 'S' RaggruppaVoce ";
			text += "FROM TariffeContrattiVoci CV ";
			text += "LEFT JOIN Voci V ON V.Codice=CV.Voce ";
			text = text + "WHERE CONTRATTO=" + base.DbConn.SQLFormatString(txtCodice.Text) + " ORDER BY Voce";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_SessionVariable.Remove("dtRepeaterVociRaggruppate");
				_SessionVariable.Add("dtRepeaterVociRaggruppate", dataTable);
				DataTable dtDestination = null;
				base.BaseFunctions.CloneDataTable(dataTable, ref dtDestination);
				text = "SELECT Codice Voce, Descrizione DescrizioneVoce, 'P' TipoRipartizione, 'N' RaggruppaVoce ";
				text += "FROM Voci ";
				DataTable dataTable2 = null;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable2, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					foreach (DataRow row in dataTable2.Rows)
					{
						if (dtDestination.Select("Voce=" + base.DbConn.SQLFormatString(row["Voce"].ToString())).Count() == 0)
						{
							DataRow dataRow2 = dtDestination.Rows.Add();
							dataRow2["Voce"] = row["Voce"].ToString();
							dataRow2["DescrizioneVoce"] = row["DescrizioneVoce"].ToString();
							dataRow2["TipoRipartizione"] = "";
							dataRow2["RaggruppaVoce"] = row["RaggruppaVoce"].ToString();
							dataRow2.AcceptChanges();
						}
					}
					dtDestination.AcceptChanges();
					RepeaterVoci.DataSource = dtDestination;
					RepeaterVoci.DataBind();
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

	private void RepeaterVoci_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		try
		{
			DataRow row = ((DataRowView)e.Item.DataItem).Row;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "VoceCodice")).ObjValue = row["Voce"].ToString();
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "VoceDescrizione")).ObjValue = row["DescrizioneVoce"].ToString();
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "RaggruppaVoce")).ObjValue = row["RaggruppaVoce"].ToString();
			IIboDropdownList objCombo = (IIboDropdownList)GetControlByName((Control)(object)e.Item, "TipoRipartizione");
			string rsMess = "";
			LoadSingleCombo(ref objCombo, ref rsMess);
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipoRipartizione")).ObjValue = row["TipoRipartizione"].ToString();
			IIboWebComponent VoceCodice = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "VoceCodice");
			IIboWebComponent VoceDescrizione = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "VoceDescrizione");
			IIboWebComponent RaggruppaVoce = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "RaggruppaVoce");
			IIboWebComponent TipoRipartizione = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipoRipartizione");
			GestisciVisibilitaControlliVoci(ref VoceCodice, ref VoceDescrizione, ref RaggruppaVoce, ref TipoRipartizione);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void GestisciVisibilitaControlliVoci(ref IIboWebComponent VoceCodice, ref IIboWebComponent VoceDescrizione, ref IIboWebComponent RaggruppaVoce, ref IIboWebComponent TipoRipartizione)
	{
		if (Operators.CompareString(RaggruppaVoce.ObjValue.ToString(), "S", false) == 0)
		{
			TipoRipartizione.Visible = true;
			if (Operators.CompareString(TipoRipartizione.ObjValue.ToString(), "", false) == 0)
			{
				TipoRipartizione.ObjValue = "P";
			}
		}
		else
		{
			TipoRipartizione.Visible = false;
		}
	}

	public void RaggruppaVoce_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		try
		{
			IIboWebComponent VoceCodice = (IIboWebComponent)GetControlByName(((Control)sender).Parent, "VoceCodice");
			IIboWebComponent VoceDescrizione = (IIboWebComponent)GetControlByName(((Control)sender).Parent, "VoceDescrizione");
			IIboWebComponent RaggruppaVoce = (IIboWebComponent)GetControlByName(((Control)sender).Parent, "RaggruppaVoce");
			IIboWebComponent TipoRipartizione = (IIboWebComponent)GetControlByName(((Control)sender).Parent, "TipoRipartizione");
			GestisciVisibilitaControlliVoci(ref VoceCodice, ref VoceDescrizione, ref RaggruppaVoce, ref TipoRipartizione);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private FXRETURN SalvaVoci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Invalid comparison between Unknown and I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringCollection stringCollection = new StringCollection();
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			dataTable = (DataTable)_SessionVariable["dtRepeaterVociRaggruppate"];
			foreach (RepeaterItem item in RepeaterVoci.Items)
			{
				RepeaterItem parent = item;
				string text2 = txtCodice.Text;
				string text3 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "VoceCodice")).ObjValue.ToString();
				string text4 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "RaggruppaVoce")).ObjValue.ToString();
				string text5 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoRipartizione")).ObjValue.ToString();
				if (Operators.CompareString(text4, "N", false) == 0)
				{
					text = "DELETE FROM TariffeContrattiVoci ";
					text = text + "WHERE Contratto=" + base.DbConn.SQLFormatString(text2) + " ";
					text = text + "AND Voce=" + base.DbConn.SQLFormatString(text3);
				}
				else
				{
					DataRow[] array = new DataRow[0];
					if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) != 0)
					{
						array = dataTable.Select("Voce=" + base.DbConn.SQLFormatString(text3));
					}
					if (array.Count() == 0)
					{
						text = "INSERT INTO TariffeContrattiVoci (Contratto,Voce,TipoRipartizione,UteAgg,UteIns) VALUES (";
						text = text + base.DbConn.SQLFormatString(text2) + ", ";
						text = text + base.DbConn.SQLFormatString(text3) + ", ";
						text = text + base.DbConn.SQLFormatString(text5) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
						text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ") ";
					}
					else
					{
						text = "";
						if (Operators.CompareString(array[0]["TipoRipartizione"].ToString(), text5, false) != 0)
						{
							text = text + "TipoRipartizione=" + base.DbConn.SQLFormatString(text5) + ", ";
						}
						if (Operators.CompareString(text, "", false) != 0)
						{
							text += "DatAgg=GETDATE(), ";
							text = text + "UteAgg=" + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
							text = "UPDATE TariffeContrattiVoci SET " + text;
							text = text + "WHERE Contratto=" + base.DbConn.SQLFormatString(text2) + " ";
							text = text + "AND Voce=" + base.DbConn.SQLFormatString(text3);
						}
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					stringCollection.Add(text);
				}
			}
			string text6 = "";
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string current = enumerator2.Current;
				text6 = text6 + current + ";";
			}
			if (Operators.CompareString(text6, "", false) == 0)
			{
				goto IL_03ec;
			}
			val2 = base.DbConn.SqlExec(text6, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_03ec;
			}
			val = val2;
			goto end_IL_0015;
			IL_03ec:
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

	private FXRETURN CheckVoci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (RepeaterItem item in RepeaterVoci.Items)
			{
				RepeaterItem parent = item;
				string text = txtCodice.Text;
				string text2 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "VoceDescrizione")).ObjValue.ToString();
				string text3 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "RaggruppaVoce")).ObjValue.ToString();
				string text4 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoRipartizione")).ObjValue.ToString();
				if (Operators.CompareString(text3, "S", false) != 0 || Operators.CompareString(text4, "", false) != 0)
				{
					continue;
				}
				rsMess = TranslateMessage("XXX", "Specificare il Tipo di ripartizione per la voce {0}", text2);
				goto end_IL_0005;
			}
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

	private FXRETURN SelezionaTutteLeVoci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (RepeaterItem item in RepeaterVoci.Items)
			{
				RepeaterItem parent = item;
				IIboWebComponent RaggruppaVoce = (IIboWebComponent)GetControlByName((Control)(object)parent, "RaggruppaVoce");
				IIboWebComponent VoceCodice = (IIboWebComponent)GetControlByName((Control)(object)parent, "VoceCodice");
				IIboWebComponent VoceDescrizione = (IIboWebComponent)GetControlByName((Control)(object)parent, "VoceDescrizione");
				IIboWebComponent TipoRipartizione = (IIboWebComponent)GetControlByName((Control)(object)parent, "TipoRipartizione");
				RaggruppaVoce.ObjValue = "S";
				GestisciVisibilitaControlliVoci(ref VoceCodice, ref VoceDescrizione, ref RaggruppaVoce, ref TipoRipartizione);
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

	private FXRETURN DeSelezionaTutteLeVoci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (RepeaterItem item in RepeaterVoci.Items)
			{
				RepeaterItem parent = item;
				IIboWebComponent RaggruppaVoce = (IIboWebComponent)GetControlByName((Control)(object)parent, "RaggruppaVoce");
				IIboWebComponent VoceCodice = (IIboWebComponent)GetControlByName((Control)(object)parent, "VoceCodice");
				IIboWebComponent VoceDescrizione = (IIboWebComponent)GetControlByName((Control)(object)parent, "VoceDescrizione");
				IIboWebComponent TipoRipartizione = (IIboWebComponent)GetControlByName((Control)(object)parent, "TipoRipartizione");
				RaggruppaVoce.ObjValue = "N";
				GestisciVisibilitaControlliVoci(ref VoceCodice, ref VoceDescrizione, ref RaggruppaVoce, ref TipoRipartizione);
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

	private FXRETURN DuplicazioneContratto(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string contratto = txtCodice.InitialValue.ToString();
			string contrattoDuplica = txtCodice.ObjValue.ToString();
			val2 = Tariffe_Duplica.RunProc(CreateApiContext(), contratto, contrattoDuplica, ref rsMess);
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
