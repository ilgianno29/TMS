using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFFATFatturePassiveManualiDettagli : WFIDBPageMasterDetail2
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdFatt_Pas_Dett")]
	private IboGridView _grdFatt_Pas_Dett;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("optTipoRiga")]
	private IboWebRadioButtonList _optTipoRiga;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtQuantitaTassata")]
	private IboWebNumericTlk _txtQuantitaTassata;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtImportoUnitario")]
	private IboWebNumericTlk _txtImportoUnitario;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtQuantitaOriginale")]
	private IboWebTextBox _txtQuantitaOriginale;

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

	[field: AccessedThroughProperty("lblIdFatturaCaption")]
	protected virtual IboWebLabel lblIdFatturaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdFattura")]
	protected virtual IboWebLabel lblIdFattura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblData")]
	protected virtual IboWebLabel lblData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelCliente")]
	protected virtual IboWebLabel lblLabelCliente
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

	[field: AccessedThroughProperty("lblTrasportatoreRagioneSociale")]
	protected virtual IboWebLabel lblTrasportatoreRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelTipoDocumento")]
	protected virtual IboWebLabel lblLabelTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumento")]
	protected virtual IboWebLabel lblTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumentoDescrizione")]
	protected virtual IboWebLabel lblTipoDocumentoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelTipoPagamento")]
	protected virtual IboWebLabel lblLabelTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPagamento")]
	protected virtual IboWebLabel lblTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPagamentoDescrizione")]
	protected virtual IboWebLabel lblTipoPagamentoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDettagli_Title")]
	protected virtual Panel cpDettagli_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDettagli_Title_Caption")]
	protected virtual Label cpDettagli_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpDettagli_Body")]
	protected virtual Panel cpDettagli_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPTreeViewContent")]
	protected virtual UpdatePanel UPTreeViewContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFatt_Pas_Dett_Body_Grid")]
	protected virtual Panel cpFatt_Pas_Dett_Body_Grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdFatt_Pas_Dett")]
	protected virtual IboWebToolbar tlbgrdFatt_Pas_Dett
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFatt_Pas_Dett")]
	protected virtual IboWebPanel pnlFatt_Pas_Dett
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdFatt_Pas_Dett
	{
		[CompilerGenerated]
		get
		{
			return _grdFatt_Pas_Dett;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdFatt_Pas_Dett_MultiSelectChanged);
			IboGridView val2 = _grdFatt_Pas_Dett;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdFatt_Pas_Dett = value;
			val2 = _grdFatt_Pas_Dett;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("pnlDettaglio")]
	protected virtual Panel pnlDettaglio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRigaview")]
	protected virtual IboWebLabel lblRigaview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRigaDescrizione")]
	protected virtual IboWebLabel lblRigaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoRigaView")]
	protected virtual IboWebLabel lblTipoRigaView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoRigaDescrizione")]
	protected virtual IboWebLabel lblTipoRigaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVoceView")]
	protected virtual IboWebLabel lblVoceView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVoceDescrizione")]
	protected virtual IboWebLabel lblVoceDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneView")]
	protected virtual IboWebLabel lblDescrizioneView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneDescrizione")]
	protected virtual IboWebLabel lblDescrizioneDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantitaView")]
	protected virtual IboWebLabel lblQuantitaView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantitaDescrizione")]
	protected virtual IboWebLabel lblQuantitaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnitarioView")]
	protected virtual IboWebLabel lblUnitarioView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnitarioDescrizione")]
	protected virtual IboWebLabel lblUnitarioDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotaleView")]
	protected virtual IboWebLabel lblTotaleView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotaleDescrizione")]
	protected virtual IboWebLabel lblTotaleDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceIvaView")]
	protected virtual IboWebLabel lblCodiceIvaView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceIVADescrizione")]
	protected virtual IboWebLabel lblCodiceIVADescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormGlobalContainer")]
	protected virtual Panel PopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormContainer")]
	protected virtual Panel PopupFormContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormTitleBar")]
	protected virtual Panel PopupFormTitleBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormCaption")]
	protected virtual IboWebLabel PopupFormCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPPopupForm")]
	protected virtual UpdatePanel UPPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormBody")]
	protected virtual Panel PopupFormBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFatt_Pas_Dett_Body_Detail")]
	protected virtual IboWebDetailPanel cpFatt_Pas_Dett_Body_Detail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiga")]
	protected virtual IboWebLabel lblRiga
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiga")]
	protected virtual IboWebNumericTlk txtRiga
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipo")]
	protected virtual IboWebLabel lblTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebRadioButtonList optTipoRiga
	{
		[CompilerGenerated]
		get
		{
			return _optTipoRiga;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optTipoRiga_SelectedIndexChanged;
			IboWebRadioButtonList val = _optTipoRiga;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_optTipoRiga = value;
			val = _optTipoRiga;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
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

	[field: AccessedThroughProperty("lblQuantita")]
	protected virtual IboWebLabel lblQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebNumericTlk txtQuantitaTassata
	{
		[CompilerGenerated]
		get
		{
			return _txtQuantitaTassata;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtQuantitaTassata_TextChanged;
			IboWebNumericTlk val = _txtQuantitaTassata;
			if (val != null)
			{
				((RadInputControl)val).TextChanged -= eventHandler;
			}
			_txtQuantitaTassata = value;
			val = _txtQuantitaTassata;
			if (val != null)
			{
				((RadInputControl)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblUnitario")]
	protected virtual IboWebLabel lblUnitario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebNumericTlk txtImportoUnitario
	{
		[CompilerGenerated]
		get
		{
			return _txtImportoUnitario;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtImportoUnitario_TextChanged;
			IboWebNumericTlk val = _txtImportoUnitario;
			if (val != null)
			{
				((RadInputControl)val).TextChanged -= eventHandler;
			}
			_txtImportoUnitario = value;
			val = _txtImportoUnitario;
			if (val != null)
			{
				((RadInputControl)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblTotale")]
	protected virtual IboWebLabel lblTotale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtImportoOriginale")]
	protected virtual IboWebNumericTlk txtImportoOriginale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceIva")]
	protected virtual IboWebTextBox txtCodiceIva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoCalcolo")]
	protected virtual IboWebTextBox txtTipoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtQuantitaArrotondata")]
	protected virtual IboWebTextBox txtQuantitaArrotondata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebTextBox txtQuantitaOriginale
	{
		[CompilerGenerated]
		get
		{
			return _txtQuantitaOriginale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtQuantitaOriginale_TextChanged;
			IboWebTextBox val = _txtQuantitaOriginale;
			if (val != null)
			{
				((TextBox)val).TextChanged -= eventHandler;
			}
			_txtQuantitaOriginale = value;
			val = _txtQuantitaOriginale;
			if (val != null)
			{
				((TextBox)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("txtImportoArrotondato")]
	protected virtual IboWebTextBox txtImportoArrotondato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo")]
	protected virtual IboWebTextBox txtCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdFatturaPopUP")]
	protected virtual IboWebTextBox txtIdFatturaPopUP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormButtons")]
	protected virtual Panel PopupFormButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdAnnulla")]
	protected virtual IboWebButton PopupForm_cmdAnnulla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdOk")]
	protected virtual IboWebButton PopupForm_cmdOk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForPopupForm")]
	protected virtual Button hiddenTargetControlForPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm")]
	protected virtual ModalPopupExtender PopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		object obj = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		_Context = "DM.FAT.FATTUREPASSIVE_TESTATA";
		_Title = base.Translator.Translate("XXX", "Dettaglio Fatture Passive Manuali", new string[0]);
		val2 = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return val2;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig2 iboInternalGridConfig = new IboInternalGridConfig2();
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdFatt_Pas_Dett;
			iboInternalGridConfig.InitUi(myViewState, ref objGridView);
			grdFatt_Pas_Dett = objGridView;
			iboInternalGridConfig.Build("DM.FAT.FATTUREPASSIVE.DETTMAN", "SELECT * FROM GRD_FAT_FattPassive_Dett WHERE IDFATTURA= '<%IDFATTURA%>' ", "", "", ((Control)grdFatt_Pas_Dett).ID, ((Control)tlbgrdFatt_Pas_Dett).ID, "", "", ((Control)cpFatt_Pas_Dett_Body_Detail).ID);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
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
			if (funcArg.Data.Count <= 0)
			{
				goto IL_0081;
			}
			val2 = TipoRiga(_objFunctionArguments.Data.GetFirstElementSqlWhere(), funcArg.Data[1].get_FieldValues(0).ToString(), "modificare", ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0081;
			}
			goto end_IL_0015;
			IL_0081:
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "N", false) == 0)
				{
					txtDescrizione.ReadOnly = false;
					((RadNumericTextBox)txtImportoUnitario).Value = 0.0;
					((RadNumericTextBox)txtQuantitaTassata).Value = 0.0;
					((RadNumericTextBox)txtImportoOriginale).Value = 0.0;
					txtImportoUnitario.Enabled = false;
					txtQuantitaTassata.Enabled = false;
					txtImportoOriginale.Enabled = false;
					txtImportoUnitario.ReadOnly = true;
					txtQuantitaTassata.ReadOnly = true;
					txtImportoOriginale.ReadOnly = true;
					lblDescrizione.ObjValue = TranslateMessage("XXX", "Descrizione:");
					cmbVoce.Clear();
					cmbVoce.Enabled = false;
					optTipoRiga.Enabled = false;
					optTipoRiga.ReadOnly = true;
				}
				val = (FXRETURN)0;
			}
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = TipoRiga(_objFunctionArguments.Data.GetFirstElementSqlWhere(), funcArg.Data[1].get_FieldValues(0).ToString(), "cancellare", ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "N", false) == 0)
					{
						txtDescrizione.ReadOnly = false;
						((RadNumericTextBox)txtImportoUnitario).Value = 0.0;
						((RadNumericTextBox)txtQuantitaTassata).Value = 0.0;
						((RadNumericTextBox)txtImportoOriginale).Value = 0.0;
						txtImportoUnitario.Enabled = false;
						txtQuantitaTassata.Enabled = false;
						txtImportoOriginale.Enabled = false;
						txtImportoUnitario.ReadOnly = true;
						txtQuantitaTassata.ReadOnly = true;
						txtImportoOriginale.ReadOnly = true;
						lblDescrizione.Text = "Descrizione:";
						IboWebComboTlk objCombo = cmbVoce;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
						cmbVoce.Enabled = false;
						optTipoRiga.Enabled = false;
						optTipoRiga.ReadOnly = true;
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

	protected override FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 <= 0)
			{
				((Control)pnlDettaglio).Visible = false;
				val2 = FatturePassiveCalcoloIva.RunProc(CreateApiContext(), Conversions.ToLong(lblIdFattura.ObjValue), ref rsMess);
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

	protected override FXRETURN DetailResetControlli(ref IboWebDetailPanel pnlDetail, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_LoadControlsInitialValuesInSession && _SessionVariable.ContainsKey("InitialValues"))
			{
				Hashtable hashtable = (Hashtable)_SessionVariable["InitialValues"];
				foreach (IIboWebComponent iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)pnlDetail))
				{
					IIboWebComponent val3 = iIboWebComponentControl;
					if (hashtable.Contains(((Control)val3).ID))
					{
						val3.ObjValue = RuntimeHelpers.GetObjectValue(((InitialControl)hashtable[((Control)val3).ID]).ObjValue);
						val3.ReadOnly = ((InitialControl)hashtable[((Control)val3).ID]).ReadOnly;
						val3.Enabled = ((InitialControl)hashtable[((Control)val3).ID]).Enabled;
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				text2 = "SELECT TD.Descrizione AS TipoDocumentoDescrizione, ";
				text2 += "T.RagioneSociale AS TrasportatoreRagioneSociale, ";
				text2 += "CP.Descrizione AS TipoPagamentoDescrizione ";
				text2 += "FROM Fatture_Passive_Testata F ";
				text2 += "INNER JOIN Trasportatori T ON T.Codice = F.Trasportatore ";
				text2 += "INNER JOIN CBO_FAT_FATTUREPASSIVE_TIPIDOC TD ON TD.Codice = F.TipoDocumento ";
				text2 += "INNER JOIN CodiciPagamento CP ON CP.Codice = F.TipoPagamento ";
				string text3 = text2;
				DBConnection dbConn = base.DbConn;
				string text4 = lblIdFattura.ObjValue.ToString();
				text2 = text3 + "WHERE IdFattura = " + dbConn.SQLFormatNumber(ref text4);
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					lblTrasportatoreRagioneSociale.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TrasportatoreRagioneSociale"]);
					lblTipoDocumentoDescrizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoDocumentoDescrizione"]);
					lblTipoPagamentoDescrizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoPagamentoDescrizione"]);
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
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

	protected override FXRETURN LoadPage(ref string rsMess)
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
			val2 = base.LoadPage(ref rsMess);
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

	protected override FXRETURN DetailCheckData(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(((ListControl)optTipoRiga).SelectedValue, "M", false) == 0)
			{
				if (Operators.CompareString(cmbVoce.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire il codice Voce");
				}
				else if (Conversions.ToDouble(txtQuantitaTassata.Text) == 0.0)
				{
					rsMess = TranslateMessage("XXX", "Specificare la quantità");
				}
				else if (Conversions.ToDouble(txtImportoUnitario.Text) == 0.0)
				{
					rsMess = TranslateMessage("XXX", "Specificare l'importo unitario");
				}
				else
				{
					if (Conversions.ToDouble(txtImportoOriginale.Text) != 0.0)
					{
						goto IL_0151;
					}
					rsMess = TranslateMessage("XXX", "Specificare l'importo totale");
				}
			}
			else
			{
				if (Operators.CompareString(txtDescrizione.Text, "", false) != 0)
				{
					goto IL_0151;
				}
				rsMess = TranslateMessage("XXX", "Inserire la la descrizione");
			}
			goto end_IL_0005;
			IL_0151:
			val = base.DetailCheckData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val <= 0)
			{
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

	protected override FXRETURN DetailBeforeSaveData(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
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
			txtCampoCalcolo.ObjValue = "FORFAIT";
			if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "N", false) == 0)
			{
				txtQuantitaTassata.ObjValue = "0";
				txtQuantitaArrotondata.ObjValue = "0";
				txtQuantitaOriginale.ObjValue = "0";
				txtImportoOriginale.ObjValue = "0";
				txtImportoArrotondato.ObjValue = "0";
				txtCodiceIva.ObjValue = "";
				goto IL_01e6;
			}
			txtQuantitaArrotondata.ObjValue = RuntimeHelpers.GetObjectValue(txtQuantitaTassata.ObjValue);
			txtQuantitaOriginale.ObjValue = RuntimeHelpers.GetObjectValue(txtQuantitaTassata.ObjValue);
			txtImportoArrotondato.ObjValue = RuntimeHelpers.GetObjectValue(txtImportoOriginale.ObjValue);
			text2 = "SELECT CODICEIVA FROM TRASPORTATORI WHERE CODICE= " + base.DbConn.SQLFormatString(lblTrasportatore.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text2, (object)"", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(obj.ToString(), "", false) != 0)
				{
					goto IL_01d1;
				}
				text2 = "SELECT CODICEIVA FROM VOCI WHERE CODICE= " + base.DbConn.SQLFormatString(cmbVoce.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text2, (object)"", ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_01d1;
				}
				val = val2;
			}
			goto end_IL_0015;
			IL_01d1:
			txtCodiceIva.ObjValue = obj.ToString();
			goto IL_01e6;
			IL_01e6:
			txtTipoCalcolo.ObjValue = "MAN";
			txtCampoCalcolo.ObjValue = "FORFAIT";
			val2 = base.DetailBeforeSaveData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
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

	protected override FXRETURN DetailBeforeLoadData(IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Invalid comparison between Unknown and I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
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
			if (Operators.CompareString(objFunctionArguments.Name, "INSERIMENTO", false) != 0)
			{
				goto IL_00a1;
			}
			DBConnection dbConn = base.DbConn;
			string text3 = lblIdFattura.ObjValue.ToString();
			text2 = "SELECT ISNULL(MAX(RIGA),0) + 10 FROM FATTURE_PASSIVE_DETTAGLIO WHERE IDFATTURA= " + dbConn.SQLFormatNumber(ref text3);
			val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
			if ((int)val2 <= 0)
			{
				txtRiga.Text = obj.ToString();
				goto IL_00a1;
			}
			val = val2;
			goto end_IL_0015;
			IL_00a1:
			if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "M", false) == 0)
			{
				cmbVoce.Enabled = true;
				txtDescrizione.ReadOnly = true;
				txtImportoUnitario.ReadOnly = false;
				txtQuantitaOriginale.ReadOnly = false;
			}
			else if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "N", false) == 0)
			{
				txtDescrizione.ReadOnly = false;
				cmbVoce.Enabled = false;
				txtImportoUnitario.ReadOnly = true;
				txtQuantitaOriginale.ReadOnly = true;
			}
			txtIdFatturaPopUP.Text = lblIdFattura.ObjValue.ToString();
			val2 = base.DetailBeforeLoadData(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
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

	protected override FXRETURN DetailBeforeConfermaClick(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.DetailBeforeConfermaClick(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				txtTipoCalcolo.Text = optTipoRiga.ObjValue.ToString();
				txtCampoCalcolo.Text = "FORFAIT";
				txtQuantitaArrotondata.Text = txtQuantitaTassata.Text;
				txtQuantitaOriginale.Text = txtQuantitaTassata.Text;
				txtImportoArrotondato.Text = txtImportoArrotondato.Text;
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

	private void grdFatt_Pas_Dett_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Invalid comparison between Unknown and I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		string text3 = "";
		DataTable dataTable = null;
		object obj = null;
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdFatt_Pas_Dett).ID];
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			FunctionArguments functionArguments = new FunctionArguments(robjData);
			functionArguments.Keys = robjKey;
			if (functionArguments.Data.Count <= 0)
			{
				return;
			}
			((Control)pnlDettaglio).Visible = true;
			text2 = functionArguments.Data.Item(0).get_FieldValues(0).ToString();
			text = functionArguments.Data.Item(1).get_FieldValues(0).ToString();
			text3 = "SELECT * FROM Fatture_Passive_Dettaglio WHERE IDFATTURA = " + base.DbConn.SQLFormatNumber(ref text2) + " ";
			text3 = text3 + " AND RIGA = " + base.DbConn.SQLFormatNumber(ref text) + " ";
			val = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (dataTable.Rows.Count == 1)
			{
				lblRigaDescrizione.Text = dataTable.Rows[0]["RIGA"].ToString();
				lblTipoRigaDescrizione.Text = ((Operators.CompareString(dataTable.Rows[0]["TipoRiga"].ToString(), "M", false) == 0) ? "MANUALE" : ((Operators.CompareString(dataTable.Rows[0]["TipoRiga"].ToString(), "N", false) == 0) ? "NOTA" : "AUTOMATICA"));
				lblVoceDescrizione.Text = dataTable.Rows[0]["VOCE"].ToString();
				lblDescrizioneDescrizione.Text = dataTable.Rows[0]["DESCRIZIONE"].ToString();
				lblQuantitaDescrizione.Text = dataTable.Rows[0]["QUANTITATASSATA"].ToString();
				lblUnitarioDescrizione.Text = dataTable.Rows[0]["IMPORTOUNITARIO"].ToString();
				lblTotaleDescrizione.Text = dataTable.Rows[0]["IMPORTOORIGINALE"].ToString();
				if (Operators.CompareString(dataTable.Rows[0]["CODICEIVA"].ToString(), "", false) != 0)
				{
					text3 = "SELECT Descrizione FROM CODICIIVA WHERE Codice = " + base.DbConn.SQLFormatString(dataTable.Rows[0]["CODICEIVA"].ToString());
					val = base.DbConn.DoSql(text3, (object)"", ref obj, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						lblCodiceIVADescrizione.Text = obj.ToString();
					}
				}
				else
				{
					lblCodiceIVADescrizione.Text = "";
				}
			}
			else
			{
				((Control)pnlDettaglio).Visible = false;
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
		}
	}

	protected void optTipoRiga_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		try
		{
			CambioTipoRiga(optTipoRiga.ObjValue.ToString());
			val = (FXRETURN)0;
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

	protected void txtQuantitaOriginale_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double rdTotale = 0.0;
		string rsMess = "";
		try
		{
			val2 = AggiornamentoImportoTotale(ref rdTotale, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			txtQuantitaOriginale.ObjValue = rdTotale;
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
		}
	}

	protected void txtQuantitaTassata_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double rdTotale = 0.0;
		string rsMess = "";
		try
		{
			val2 = AggiornamentoImportoTotale(ref rdTotale, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			txtImportoOriginale.ObjValue = rdTotale;
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
		}
	}

	protected void txtImportoUnitario_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double rdTotale = 0.0;
		string rsMess = "";
		try
		{
			val2 = AggiornamentoImportoTotale(ref rdTotale, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			txtImportoOriginale.ObjValue = rdTotale;
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
		}
	}

	protected override FXRETURN PopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double num = 0.0;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.PopupFormOkClick(ref objPopupInfo, ref rsMess);
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

	protected override FXRETURN DetailAfterSaveData(ref IboWebDetailPanel pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double num = 0.0;
		string text = "";
		FXRETURN result;
		try
		{
			val = base.DetailAfterSaveData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(((Control)pnlDetail).ID, ((Control)cpFatt_Pas_Dett_Body_Detail).ID, false) != 0)
				{
					goto IL_0080;
				}
				val = FatturePassiveCalcoloIva.RunProc(CreateApiContext(), Conversions.ToLong(lblIdFattura.ObjValue), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0080;
				}
				val2 = val;
			}
			goto end_IL_0016;
			IL_0080:
			val2 = (FXRETURN)0;
			goto IL_00ac;
			end_IL_0016:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
			goto IL_00ac;
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		goto IL_00b9;
		IL_00ac:
		result = base.DetailAfterSaveData(ref pnlDetail, ref objFunctionArguments, ref rsMess);
		goto IL_00b9;
		IL_00b9:
		return result;
	}

	private void CambioTipoRiga(string vsTipoRiga)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "M", false) == 0)
		{
			cmbVoce.Enabled = true;
			txtDescrizione.ReadOnly = true;
			txtDescrizione.Text = "";
			txtImportoUnitario.Enabled = true;
			txtQuantitaTassata.Enabled = true;
			txtImportoOriginale.Enabled = true;
			txtImportoUnitario.ReadOnly = false;
			txtQuantitaTassata.ReadOnly = false;
			txtImportoOriginale.ReadOnly = false;
			txtDescrizione.Text = "";
			IboWebComboTlk objCombo = cmbVoce;
			string rsMess = "";
			ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess);
		}
		else if (Operators.CompareString(optTipoRiga.ObjValue.ToString(), "N", false) == 0)
		{
			txtDescrizione.ReadOnly = false;
			((RadNumericTextBox)txtImportoUnitario).Value = 0.0;
			((RadNumericTextBox)txtQuantitaTassata).Value = 0.0;
			((RadNumericTextBox)txtImportoOriginale).Value = 0.0;
			txtImportoUnitario.Enabled = false;
			txtQuantitaTassata.Enabled = false;
			txtImportoOriginale.Enabled = false;
			txtImportoUnitario.ReadOnly = true;
			txtQuantitaTassata.ReadOnly = true;
			txtImportoOriginale.ReadOnly = true;
			txtDescrizione.Text = "";
			IboWebComboTlk objCombo2 = cmbVoce;
			string rsMess = "";
			ComboSelectedItem((IIboDropdownList)(object)objCombo2, "", ref rsMess);
			cmbVoce.Enabled = false;
		}
	}

	private FXRETURN TipoRiga(string vsSqlWhere, string vsNumRiga, string vsFrom, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
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
			text2 = "SELECT TipoRiga FROM FATTURE_ATTIVE_DETTAGLIO WHERE 1 = 1 " + _objFunctionArguments.Data.GetFirstElementSqlWhere();
			string text3 = text2;
			DBConnection dbConn = base.DbConn;
			int num = Conversions.ToInteger(vsNumRiga);
			text2 = text3 + " AND RIGA = " + dbConn.SQLFormatNumber(ref num);
			val2 = base.DbConn.DoSql(text2, (object)"", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if ((Operators.CompareString(obj.ToString(), "N", false) != 0) & (Operators.CompareString(obj.ToString(), "M", false) != 0))
			{
				rsMess = "E'possibile " + vsFrom + " solo le righe di tipo nota o manuali.";
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

	private FXRETURN AggiornamentoImportoTotale(ref double rdTotale, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		double num = 0.0;
		double num2 = 0.0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rdTotale = 0.0;
			rsMess = "";
			try
			{
				num2 = ((RadNumericTextBox)txtImportoUnitario).Value.Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				num = ((RadNumericTextBox)txtQuantitaTassata).Value.Value;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			rdTotale = num2 * num;
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
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
