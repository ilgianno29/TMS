using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFGDesktop_Tree : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdNodiPrimoLivello")]
	private IboGridView _grdNodiPrimoLivello;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdNodiSecondoLivello")]
	private IboGridView _grdNodiSecondoLivello;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdNodiTerzoLivello")]
	private IboGridView _grdNodiTerzoLivello;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiungiVoce")]
	private IboWebButton _btnAggiungiVoce;

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

	[field: AccessedThroughProperty("lblConfigProfileId")]
	protected virtual IboWebLabel lblConfigProfileId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ConfigProfileId")]
	protected virtual IboWebComboTlk ConfigProfileId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebTextBox txtId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen")]
	protected virtual CollapsiblePanelExtender cpInfoGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiPrimoLivello_Title")]
	protected virtual Panel cpNodiPrimoLivello_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiPrimoLivello_Title_Caption")]
	protected virtual Label cpNodiPrimoLivello_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiPrimoLivello_Body")]
	protected virtual Panel cpNodiPrimoLivello_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_cpNodiPrimoLivello_Body")]
	protected virtual UpdatePanel UP_cpNodiPrimoLivello_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("VertFirstLevel")]
	protected virtual IboWebLabel VertFirstLevel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdPrimoLivello")]
	protected virtual IboWebTextBox IdPrimoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdNodiPrimoLivello")]
	protected virtual IboWebToolbar tlbgrdNodiPrimoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNodiPrimoLivello")]
	protected virtual IboWebPanel pnlNodiPrimoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdNodiPrimoLivello
	{
		[CompilerGenerated]
		get
		{
			return _grdNodiPrimoLivello;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdNodiPrimoLivello_MultiSelectChanged);
			IboGridView val2 = _grdNodiPrimoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdNodiPrimoLivello = value;
			val2 = _grdNodiPrimoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpNodiPrimoLivello")]
	protected virtual CollapsiblePanelExtender cpNodiPrimoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiSecondoLivello_Title")]
	protected virtual Panel cpNodiSecondoLivello_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiSecondoLivello_Title_Caption")]
	protected virtual Label cpNodiSecondoLivello_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiSecondoLivello_Body")]
	protected virtual Panel cpNodiSecondoLivello_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_cpNodiSecondoLivello_Body")]
	protected virtual UpdatePanel UP_cpNodiSecondoLivello_Body
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

	[field: AccessedThroughProperty("IdSecondoLivello")]
	protected virtual IboWebTextBox IdSecondoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdNodiSecondoLivello")]
	protected virtual IboWebToolbar tlbgrdNodiSecondoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNodiSecondoLivello")]
	protected virtual IboWebPanel pnlNodiSecondoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdNodiSecondoLivello
	{
		[CompilerGenerated]
		get
		{
			return _grdNodiSecondoLivello;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdNodiSecondoLivello_MultiSelectChanged);
			IboGridView val2 = _grdNodiSecondoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdNodiSecondoLivello = value;
			val2 = _grdNodiSecondoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpNodiSecondoLivello")]
	protected virtual CollapsiblePanelExtender cpNodiSecondoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiTerzoLivello_Title")]
	protected virtual Panel cpNodiTerzoLivello_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiTerzoLivello_Title_Caption")]
	protected virtual Label cpNodiTerzoLivello_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpNodiTerzoLivello_Body")]
	protected virtual Panel cpNodiTerzoLivello_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPcpNodiTerzoLivello_Body")]
	protected virtual UpdatePanel UPcpNodiTerzoLivello_Body
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

	[field: AccessedThroughProperty("IdTerzoLivello")]
	protected virtual IboWebTextBox IdTerzoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdNodiTerzoLivello")]
	protected virtual IboWebToolbar tlbgrdNodiTerzoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNodiTerzoLivello")]
	protected virtual IboWebPanel pnlNodiTerzoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdNodiTerzoLivello
	{
		[CompilerGenerated]
		get
		{
			return _grdNodiTerzoLivello;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdNodiTerzoLivello_MultiSelectChanged);
			IboGridView val2 = _grdNodiTerzoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdNodiTerzoLivello = value;
			val2 = _grdNodiTerzoLivello;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpNodiTerzoLivello")]
	protected virtual CollapsiblePanelExtender cpNodiTerzoLivello
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiungiVoce
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiungiVoce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiungiVoce_Click;
			IboWebButton val = _btnAggiungiVoce;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiungiVoce = value;
			val = _btnAggiungiVoce;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlInserisci")]
	protected virtual Panel pnlInserisci
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

	[field: AccessedThroughProperty("Voce")]
	protected virtual IboWebComboTlk Voce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSepara")]
	protected virtual IboWebLabel lblSepara
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Separa")]
	protected virtual IboWebCheckBox Separa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisibile")]
	protected virtual IboWebLabel lblVisibile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Visibile")]
	protected virtual IboWebCheckBox Visibile
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

	[field: AccessedThroughProperty("Descrizione")]
	protected virtual IboWebTextBox Descrizione
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

	[field: AccessedThroughProperty("Peso")]
	protected virtual IboWebNumericTlk Peso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idMenuTree")]
	protected virtual IboWebTextBox idMenuTree
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlInserisciVoce")]
	protected virtual Panel pnlInserisciVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceVoce")]
	protected virtual IboWebLabel lblCodiceVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CodiceVoce")]
	protected virtual IboWebTextBox CodiceVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTestoVoce")]
	protected virtual IboWebLabel lblTestoVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TestoVoce")]
	protected virtual IboWebTextBox TestoVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.PROF.PROFILO_CONFIG#D";
		_Title = base.Translator.Translate("XXX", "Configurazione Desktop", new string[0]);
		_objFunctionArguments.Name = "MODIFICA";
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
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
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
				IboGridView objGridView = grdNodiPrimoLivello;
				iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
				grdNodiPrimoLivello = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.DESKTOP", "SELECT * FROM GRD_WFI_Desktop_Tree WHERE ConfigProfileId='<%Id%>' AND ParentId Is NULL", "", "", ((Control)grdNodiPrimoLivello).ID, ((Control)tlbgrdNodiPrimoLivello).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
				StateBag myViewState2 = base.MyViewState;
				objGridView = grdNodiSecondoLivello;
				iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
				grdNodiSecondoLivello = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.DESKTOP1", "SELECT * FROM GRD_WFI_Desktop_Tree WHERE ConfigProfileId='<%Id%>' AND ParentId='<%CONTROLS_RECORD.IdPrimoLivello%>'", "", "", ((Control)grdNodiSecondoLivello).ID, ((Control)tlbgrdNodiSecondoLivello).ID);
				GridConfigList.Add(iboInternalGridConfig);
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
				StateBag myViewState3 = base.MyViewState;
				objGridView = grdNodiTerzoLivello;
				iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
				grdNodiTerzoLivello = objGridView;
				iboInternalGridConfig.Build("WFI.PROF.DESKTOP2", "SELECT * FROM GRD_WFI_Desktop_Tree WHERE ConfigProfileId='<%Id%>' AND ParentId = '<%CONTROLS_RECORD.IdSecondoLivello%>'", "", "", ((Control)grdNodiTerzoLivello).ID, ((Control)tlbgrdNodiTerzoLivello).ID);
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
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
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
				ConfigProfileId.ObjValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
				ConfigProfileId.Enabled = false;
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
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

	private void grdNodiPrimoLivello_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiPrimoLivello).ID];
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
			if (functionArguments.Data.Count > 0)
			{
				IdPrimoLivello.ObjValue = functionArguments.Data.Item(0).get_FieldValues(0).ToString();
				IdSecondoLivello.ObjValue = "";
				IdTerzoLivello.ObjValue = "";
			}
			else
			{
				IdPrimoLivello.ObjValue = "";
				IdSecondoLivello.ObjValue = "";
				IdTerzoLivello.ObjValue = "";
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
			AggiornaNodiSecondoLivello();
			AggiornaNodiTerzoLivello();
		}
	}

	private void grdNodiSecondoLivello_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiSecondoLivello).ID];
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
			if (functionArguments.Data.Count > 0)
			{
				IdSecondoLivello.ObjValue = functionArguments.Data.Item(0).get_FieldValues(0).ToString();
				IdTerzoLivello.ObjValue = "";
			}
			else
			{
				IdSecondoLivello.ObjValue = "";
				IdTerzoLivello.ObjValue = "";
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
			AggiornaNodiTerzoLivello();
		}
	}

	private void grdNodiTerzoLivello_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiTerzoLivello).ID];
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
			if (functionArguments.Data.Count > 0)
			{
				IdTerzoLivello.ObjValue = functionArguments.Data.Item(0).get_FieldValues(0).ToString();
			}
			else
			{
				IdTerzoLivello.ObjValue = "";
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

	private void btnAggiungiVoce_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			CallStackAdd();
			string[] CampiChiave = new string[1] { "Voce" };
			object[] ValoriCampiChiave = new object[1] { "" };
			val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "VOCE", "Inserimento nuova voce di menù", WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, "IFrameDimensionVoci", "WFI.CFG.MENUVOCI", "INSERIMENTO", ref rsmess);
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

	private void AggiornaNodiPrimoLivello()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IboInternalGridConfig objInternalGrid = GridConfigList[((Control)grdNodiPrimoLivello).ID];
			string rsMess = "";
			InternalGridSqlSet(ref objInternalGrid, ref rsMess);
			rsMess = "";
			_InternalGridAggiorna(ref objInternalGrid, ref rsMess);
			UP_cpNodiPrimoLivello_Body.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void AggiornaNodiSecondoLivello()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IboInternalGridConfig objInternalGrid = GridConfigList[((Control)grdNodiSecondoLivello).ID];
			string rsMess = "";
			InternalGridSqlSet(ref objInternalGrid, ref rsMess);
			rsMess = "";
			_InternalGridAggiorna(ref objInternalGrid, ref rsMess);
			UP_cpNodiSecondoLivello_Body.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void AggiornaNodiTerzoLivello()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IboInternalGridConfig objInternalGrid = GridConfigList[((Control)grdNodiTerzoLivello).ID];
			string rsMess = "";
			InternalGridSqlSet(ref objInternalGrid, ref rsMess);
			rsMess = "";
			_InternalGridAggiorna(ref objInternalGrid, ref rsMess);
			UPcpNodiTerzoLivello_Body.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
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
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				((CheckBox)Separa).Checked = false;
				Separa.ReadOnly = false;
				Descrizione.ObjValue = "";
				Peso.ObjValue = 0;
				((CheckBox)Visibile).Checked = true;
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
				{
					ComboSetFilter((IIboDropdownList)(object)Voce, "", "", ref rsMess);
					Separa.ReadOnly = true;
					MasterPopupFormOpen("Inserisci Voce di Menù", (Control)(object)pnlInserisci, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "INSERISCI1");
					goto IL_0348;
				}
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
				{
					if (Operators.CompareString(IdPrimoLivello.ObjValue.ToString(), "", false) == 0)
					{
						rsMess = TranslateMessage("XXX", "Selezionare il nodo Padre");
					}
					else
					{
						text = "SELECT COUNT(*) FROM WFI_Desktop_Tree T INNER JOIN WFI_MENU_VOCI V ON V.VOCE = T.VOCE ";
						string text2 = text;
						DBConnection dbConn = base.DbConn;
						string text3 = IdPrimoLivello.ObjValue.ToString();
						text = text2 + "WHERE T.ID = " + dbConn.SQLFormatNumber(ref text3) + " ";
						text += "AND V.TIPONODO = 'P'";
						val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (Conversions.ToInteger(obj) != 0)
							{
								ComboSetFilter((IIboDropdownList)(object)Voce, "", "", ref rsMess);
								MasterPopupFormOpen("Inserisci Voce di Menù", (Control)(object)pnlInserisci, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "INSERISCI2");
								goto IL_0348;
							}
							rsMess = TranslateMessage("XXX", "Il nodo padre " + IdPrimoLivello.ObjValue.ToString() + " non prevede voci di sottomenù");
						}
					}
				}
				else if (Operators.CompareString(IdSecondoLivello.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Selezionare il nodo Padre");
				}
				else
				{
					text = "SELECT COUNT(*) FROM WFI_Desktop_Tree T INNER JOIN WFI_MENU_VOCI V ON V.VOCE = T.VOCE ";
					string text4 = text;
					DBConnection dbConn2 = base.DbConn;
					string text3 = IdSecondoLivello.ObjValue.ToString();
					text = text4 + "WHERE T.ID = " + dbConn2.SQLFormatNumber(ref text3) + " ";
					text += "AND V.TIPONODO = 'P'";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) != 0)
						{
							ComboSetFilter((IIboDropdownList)(object)Voce, "TIPONODO NOT IN ('P')", "", ref rsMess);
							MasterPopupFormOpen("Inserisci Voce di Menù", (Control)(object)pnlInserisci, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "INSERISCI3");
							goto IL_0348;
						}
						rsMess = TranslateMessage("XXX", "Il nodo padre " + IdSecondoLivello.ObjValue.ToString() + " non prevede voci di sottomenù");
					}
				}
			}
			goto end_IL_000e;
			IL_0348:
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string text = "";
				DBConnection dbConn = base.DbConn;
				string text2 = funcArg.Data.Item(0).get_FieldValues(0).ToString();
				text = "SELECT ID,VOCE,DESCRIZIONE,SEPARA,VISIBILE,PESO FROM WFI_Desktop_Tree WHERE ID = " + dbConn.SQLFormatNumber(ref text2);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
					{
						Separa.ReadOnly = true;
					}
					Descrizione.ObjValue = dataTable.Rows[0]["DESCRIZIONE"].ToString();
					Separa.ObjValue = dataTable.Rows[0]["SEPARA"].ToString();
					Visibile.ObjValue = dataTable.Rows[0]["VISIBILE"].ToString();
					idMenuTree.ObjValue = dataTable.Rows[0]["ID"].ToString();
					Peso.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["PESO"]);
					val2 = ComboSelectedItem((IIboDropdownList)(object)Voce, dataTable.Rows[0]["VOCE"].ToString(), ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						Voce.ReadOnly = true;
						MasterPopupFormOpen("Modifica Voce di Menù", (Control)(object)pnlInserisci, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "MODIFICA");
						val = (FXRETURN)0;
					}
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected override FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				AggiornaNodiPrimoLivello();
				AggiornaNodiSecondoLivello();
				AggiornaNodiTerzoLivello();
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
				{
					IdPrimoLivello.ObjValue = "";
					IdSecondoLivello.ObjValue = "";
					IdTerzoLivello.ObjValue = "";
				}
				else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
				{
					IdSecondoLivello.ObjValue = "";
					IdTerzoLivello.ObjValue = "";
					AggiornaSelezionePrimoLivello();
				}
				else
				{
					IdTerzoLivello.ObjValue = "";
					AggiornaSelezionePrimoLivello();
					AggiornaSelezioneSecondoLivello();
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.Parameters["DisableSave"] = "S";
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string objValue = IdPrimoLivello.ObjValue.ToString();
				string objValue2 = IdSecondoLivello.ObjValue.ToString();
				string objValue3 = IdTerzoLivello.ObjValue.ToString();
				if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
				{
					text2 = "1";
				}
				else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
				{
					text2 = "2";
				}
				else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiTerzoLivello).ID, false) == 0)
				{
					text2 = "3";
				}
				if (!((Operators.CompareString(e.CommandName.ToUpper(), "SU", false) == 0) | ((Operators.CompareString(e.CommandName.ToUpper(), "GIU", false) == 0) & (Operators.CompareString(text2, "", false) != 0))))
				{
					if (Operators.CompareString(e.CommandName.ToUpper(), "NUOVORAGGRUPPAMENTO", false) == 0)
					{
						CodiceVoce.ObjValue = "";
						TestoVoce.ObjValue = "";
						string tag = "";
						if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
						{
							tag = "NUOVORAGGRUPPAMENTO1";
						}
						else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
						{
							tag = "NUOVORAGGRUPPAMENTO2";
						}
						MasterPopupFormOpen("Inserisci nuovo nodo padre", (Control)(object)pnlInserisciVoce, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, tag);
					}
					goto IL_03ba;
				}
				val2 = AggiornaOrdineMenu(text2, e.CommandName.ToUpper(), funcArg.Data.Item(0).get_FieldValues(0).ToString(), ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
					{
						AggiornaNodiPrimoLivello();
					}
					else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
					{
						AggiornaNodiSecondoLivello();
					}
					else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiTerzoLivello).ID, false) == 0)
					{
						AggiornaNodiTerzoLivello();
					}
					IdPrimoLivello.ObjValue = objValue;
					IdSecondoLivello.ObjValue = objValue2;
					IdTerzoLivello.ObjValue = objValue3;
					if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiPrimoLivello).ID, false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						AggiornaSelezioneSecondoLivello();
						AggiornaSelezioneTerzoLivello();
					}
					else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiSecondoLivello).ID, false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						AggiornaSelezioneSecondoLivello();
						AggiornaSelezioneTerzoLivello();
					}
					else if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbgrdNodiTerzoLivello).ID, false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						AggiornaSelezioneSecondoLivello();
						AggiornaSelezioneTerzoLivello();
					}
					goto IL_03ba;
				}
				val = val2;
			}
			goto end_IL_0012;
			IL_03ba:
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

	protected override FXRETURN _InternalGridCancellaGetMessage(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string Messaggio1, ref string Messaggio2, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DBConnection dbConn = base.DbConn;
			string text2 = funcArg.Data.Item(0).get_FieldValues(0).ToString();
			text = "SELECT COUNT(*) FROM WFI_Desktop_Tree WHERE PARENTID = " + dbConn.SQLFormatNumber(ref text2) + " ";
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Conversions.ToInteger(obj) > 0)
				{
					Messaggio2 = TranslateMessage("XXX", "Confermare l'eliminazione del record selezionato? Verranno eliminate anche le sue sottovoci.");
				}
				else
				{
					Messaggio2 = TranslateMessage("XXX", "Confermare l'eliminazione dei record selezionato?");
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

	protected override FXRETURN _InternalGridCancellaAction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataTable dataTable = null;
			DataTable dataTable2 = null;
			string text2 = "";
			DBConnection dbConn = base.DbConn;
			string text3 = funcArg.Data.Item(0).get_FieldValues(0).ToString();
			text = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + dbConn.SQLFormatNumber(ref text3);
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				foreach (DataRow row in dataTable.Rows)
				{
					DBConnection dbConn2 = base.DbConn;
					text3 = row["ID"].ToString();
					text = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + dbConn2.SQLFormatNumber(ref text3);
					val2 = base.DbConn.OpenDataTable(text, ref dataTable2, ref rsMess);
					if ((int)val2 <= 0)
					{
						foreach (DataRow row2 in dataTable2.Rows)
						{
							string text4 = text2;
							DBConnection dbConn3 = base.DbConn;
							text3 = row2["ID"].ToString();
							text2 = text4 + "DELETE FROM WFI_Desktop_Tree WHERE ID = " + dbConn3.SQLFormatNumber(ref text3) + ";\r\n";
						}
						string text5 = text2;
						DBConnection dbConn4 = base.DbConn;
						text3 = row["ID"].ToString();
						text2 = text5 + "DELETE FROM WFI_Desktop_Tree WHERE ID = " + dbConn4.SQLFormatNumber(ref text3) + ";\r\n";
						continue;
					}
					val = val2;
					goto end_IL_000b;
				}
				string text6 = text2;
				DBConnection dbConn5 = base.DbConn;
				text3 = funcArg.Data.Item(0).get_FieldValues(0).ToString();
				text2 = text6 + "DELETE FROM WFI_Desktop_Tree WHERE ID = " + dbConn5.SQLFormatNumber(ref text3) + ";\r\n";
				val2 = base.DbConn.SqlExec(text2, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	public override FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Invalid comparison between Unknown and I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Invalid comparison between Unknown and I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Invalid comparison between Unknown and I4
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Invalid comparison between Unknown and I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Invalid comparison between Unknown and I4
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Invalid comparison between Unknown and I4
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Invalid comparison between Unknown and I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Invalid comparison between Unknown and I4
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Invalid comparison between Unknown and I4
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string rsValore = "";
		string rsValore2 = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text6;
			int num;
			if (Operators.CompareString(objPopupInfo.Tag, "MODIFICA", false) == 0)
			{
				text = "UPDATE WFI_Desktop_Tree SET Descrizione = " + base.DbConn.SQLFormatString(Descrizione.ObjValue.ToString()) + ",";
				text = text + "Separa = " + base.DbConn.SQLFormatString(Separa.ObjValue.ToString()) + ",";
				text = text + "Visibile = " + base.DbConn.SQLFormatString(Visibile.ObjValue.ToString()) + ",";
				string text4 = text;
				DBConnection dbConn = base.DbConn;
				num = Conversions.ToInteger(Peso.ObjValue);
				text = text4 + "Peso = " + dbConn.SQLFormatNumber(ref num) + ",";
				text = text + "UteAgg = " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text = text + "DatAgg = " + base.DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + " ";
				string text5 = text;
				DBConnection dbConn2 = base.DbConn;
				text6 = idMenuTree.ObjValue.ToString();
				text = text5 + "WHERE ID = " + dbConn2.SQLFormatNumber(ref text6);
				val = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val <= 0)
				{
					idMenuTree.ObjValue = "";
					Descrizione.ObjValue = "";
					Peso.ObjValue = 0;
					Voce.ReadOnly = false;
					((CheckBox)Separa).Checked = false;
					Separa.ReadOnly = false;
					goto IL_08c9;
				}
				val2 = val;
			}
			else if ((Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO1", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO2", false) == 0))
			{
				if (Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO1", false) == 0)
				{
					text2 = "NULL";
					val = GetMaxValueOrdine("1", "", ref rsValore, ref rsMess);
					if ((int)val <= 0)
					{
						text3 = base.DbConn.SQLFormatString(rsValore + ".000.000");
						goto IL_035e;
					}
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO2", false) != 0)
					{
						goto IL_035e;
					}
					DBConnection dbConn3 = base.DbConn;
					text6 = IdPrimoLivello.ObjValue.ToString();
					text2 = dbConn3.SQLFormatNumber(ref text6);
					val = GetMaxValueOrdine("2", IdPrimoLivello.ObjValue.ToString(), ref rsValore, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = GetValueOrdinePadre("1", IdPrimoLivello.ObjValue.ToString(), ref rsValore2, ref rsMess);
						if ((int)val <= 0)
						{
							text3 = base.DbConn.SQLFormatString(rsValore2 + rsValore + ".000");
							goto IL_035e;
						}
						val2 = val;
					}
				}
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI1", false) == 0)
			{
				text2 = "NULL";
				val = GetMaxValueOrdine("1", "", ref rsValore, ref rsMess);
				if ((int)val <= 0)
				{
					text3 = base.DbConn.SQLFormatString(rsValore + ".000.000");
					goto IL_0740;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI2", false) == 0)
			{
				DBConnection dbConn4 = base.DbConn;
				text6 = IdPrimoLivello.ObjValue.ToString();
				text2 = dbConn4.SQLFormatNumber(ref text6);
				val = GetMaxValueOrdine("2", IdPrimoLivello.ObjValue.ToString(), ref rsValore, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = GetValueOrdinePadre("1", IdPrimoLivello.ObjValue.ToString(), ref rsValore2, ref rsMess);
					if ((int)val <= 0)
					{
						text3 = base.DbConn.SQLFormatString(rsValore2 + rsValore + ".000");
						goto IL_0740;
					}
					val2 = val;
				}
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI3", false) != 0)
				{
					goto IL_0740;
				}
				DBConnection dbConn5 = base.DbConn;
				text6 = IdSecondoLivello.ObjValue.ToString();
				text2 = dbConn5.SQLFormatNumber(ref text6);
				val = GetMaxValueOrdine("3", IdSecondoLivello.ObjValue.ToString(), ref rsValore, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = GetValueOrdinePadre("2", IdSecondoLivello.ObjValue.ToString(), ref rsValore2, ref rsMess);
					if ((int)val <= 0)
					{
						text3 = base.DbConn.SQLFormatString(rsValore2 + rsValore);
						goto IL_0740;
					}
					val2 = val;
				}
			}
			goto end_IL_0027;
			IL_08c9:
			if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI1", false) == 0)
			{
				IdPrimoLivello.ObjValue = "";
				IdSecondoLivello.ObjValue = "";
				IdTerzoLivello.ObjValue = "";
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI2", false) == 0)
			{
				IdSecondoLivello.ObjValue = "";
				IdTerzoLivello.ObjValue = "";
				AggiornaSelezionePrimoLivello();
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI3", false) == 0)
			{
				IdTerzoLivello.ObjValue = "";
				AggiornaSelezionePrimoLivello();
				AggiornaSelezioneSecondoLivello();
			}
			AggiornaNodiPrimoLivello();
			AggiornaNodiSecondoLivello();
			AggiornaNodiTerzoLivello();
			IboWebComboTlk voce = Voce;
			text6 = "";
			ComboSelectedItem((IIboDropdownList)(object)voce, "", ref text6);
			val2 = (FXRETURN)0;
			goto end_IL_0027;
			IL_035e:
			text = "INSERT INTO WFI_MENU_VOCI (VOCE, DESCRIZIONE, TEXT, TIPONODO, VISIBILE, UTEINS,UTEAGG) VALUES (";
			text = text + base.DbConn.SQLFormatString(CodiceVoce.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(CodiceVoce.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(TestoVoce.ObjValue.ToString()) + ",";
			text += "'P','S',";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + "); ";
			text += "INSERT INTO WFI_Desktop_Tree (ConfigProfileId,Voce,ParentID,Ordine,Separa,Visibile,UteIns,UteAgg) VALUES (";
			text = text + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(CodiceVoce.ObjValue.ToString()) + ",";
			text = text + text2 + ",";
			text = text + text3 + ", 'N','S',";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ")";
			val = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IboWebComboTlk objCombo = Voce;
				FXRETURN val3 = ReloadSingleCombo(ref objCombo, ref rsMess);
				Voce = objCombo;
				val = val3;
				if ((int)val <= 0)
				{
					goto IL_08c9;
				}
				val2 = val;
			}
			goto end_IL_0027;
			IL_0740:
			text = "INSERT INTO WFI_Desktop_Tree (ConfigProfileId,Voce,Descrizione,ParentID,Ordine,Separa,Visibile,Peso,UteIns,UteAgg) VALUES (";
			text = text + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(Voce.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(Descrizione.ObjValue.ToString()) + ",";
			text = text + text2 + ",";
			text = text + text3 + ",";
			text = text + base.DbConn.SQLFormatString(Separa.ObjValue.ToString()) + ",";
			text = text + base.DbConn.SQLFormatString(Visibile.ObjValue.ToString()) + ",";
			string text7 = text;
			DBConnection dbConn6 = base.DbConn;
			num = Conversions.ToInteger(Peso.ObjValue);
			text = text7 + dbConn6.SQLFormatNumber(ref num) + ",";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
			text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ")";
			val = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_08c9;
			}
			val2 = val;
			end_IL_0027:;
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
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if ((Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO1", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO2", false) == 0))
				{
					CodiceVoce.ObjValue = "";
					TestoVoce.ObjValue = "";
				}
				else
				{
					AggiornaNodiPrimoLivello();
					AggiornaNodiTerzoLivello();
					AggiornaNodiSecondoLivello();
					if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI1", false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						if (Operators.CompareString(IdSecondoLivello.ObjValue.ToString(), "", false) != 0)
						{
							AggiornaSelezioneSecondoLivello();
						}
					}
					else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI2", false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						AggiornaSelezioneSecondoLivello();
					}
					else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCI3", false) == 0)
					{
						AggiornaSelezionePrimoLivello();
						AggiornaSelezioneSecondoLivello();
						AggiornaSelezioneTerzoLivello();
					}
					IboWebComboTlk voce = Voce;
					string rsMess2 = "";
					ComboSelectedItem((IIboDropdownList)(object)voce, "", ref rsMess2);
					idMenuTree.ObjValue = "";
					Descrizione.ObjValue = "";
					Peso.ObjValue = 0;
					((CheckBox)Separa).Checked = false;
					Voce.ReadOnly = false;
					Separa.ReadOnly = false;
				}
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

	public override FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			if ((Operators.CompareString(objPopupInfo.Tag, "INSERISCI1", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "INSERISCI2", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "INSERISCI3", false) == 0))
			{
				if (Operators.CompareString(Voce.ObjValue.ToString(), "", false) != 0)
				{
					if (Operators.CompareString(Peso.ObjValue.ToString(), "", false) == 0)
					{
						Peso.ObjValue = 0;
					}
					goto IL_0268;
				}
				rsMess = TranslateMessage("XXX", "Obbligatorio inserire la voce di menù");
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "MODIFICA", false) == 0)
				{
					if (Operators.CompareString(Peso.ObjValue.ToString(), "", false) == 0)
					{
						Peso.ObjValue = 0;
					}
					goto IL_0268;
				}
				if (!((Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO1", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "NUOVORAGGRUPPAMENTO2", false) == 0)))
				{
					goto IL_0268;
				}
				string text = "";
				object obj = null;
				if (Operators.CompareString(CodiceVoce.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Obbligatorio inserire il codice della voce di menù");
				}
				else if (Operators.CompareString(TestoVoce.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Obbligatorio inserire la descrizione della voce di menù");
				}
				else
				{
					text = "SELECT COUNT(*) FROM WFI_MENU_VOCI WHERE VOCE = " + base.DbConn.SQLFormatString(CodiceVoce.ObjValue.ToString());
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							goto IL_0268;
						}
						rsMess = TranslateMessage("XXX", "Già presente una voce di menù con codice {0}", CodiceVoce.ObjValue.ToString());
					}
				}
			}
			goto end_IL_0005;
			IL_0268:
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

	private FXRETURN GetMaxValueOrdine(string sLivello, string sParentId, ref string rsValore, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsValore = "";
			if (Operators.CompareString(sLivello, "1", false) == 0)
			{
				text = "SELECT TOP(1) SUBSTRING(Ordine,1,3) AS ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " AND PARENTID IS NULL ";
				text += "ORDER BY Ordine DESC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			else if (Operators.CompareString(sLivello, "2", false) == 0)
			{
				text = "SELECT TOP(1) SUBSTRING(Ordine,5,3) AS ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " ";
				text = text + "AND PARENTID = " + base.DbConn.SQLFormatString(sParentId) + " ";
				text += "ORDER BY Ordine DESC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			else
			{
				text = "SELECT TOP(1) SUBSTRING(Ordine,9,3) AS ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " ";
				text = text + "AND PARENTID = " + base.DbConn.SQLFormatString(sParentId) + " ";
				text += "ORDER BY Ordine DESC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(Conversions.ToString(obj), "", false) == 0)
				{
					rsValore = "001";
				}
				else
				{
					rsValore = Conversions.ToString(checked(Conversions.ToInteger(obj) + 1)).PadLeft(3, '0');
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

	private FXRETURN GetIdOrdinePrecedente(string sLivello, string sParentId, string sOrdine, ref string sIdPrecedente, ref string sOrdinePrecedente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			sIdPrecedente = "";
			sOrdinePrecedente = "";
			if (Operators.CompareString(sParentId, "", false) == 0)
			{
				text = "SELECT TOP(1) ID, ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " AND PARENTID IS NULL ";
				text = text + "AND ORDINE < " + base.DbConn.SQLFormatString(sOrdine) + " ";
				text += "ORDER BY Ordine DESC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			else
			{
				text = "SELECT TOP(1) ID,ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " ";
				text = text + "AND PARENTID = " + base.DbConn.SQLFormatString(sParentId) + " ";
				text = text + "AND ORDINE < " + base.DbConn.SQLFormatString(sOrdine) + " ";
				text += "ORDER BY Ordine DESC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count > 0)
				{
					sIdPrecedente = dataTable.Rows[0]["ID"].ToString();
					sOrdinePrecedente = dataTable.Rows[0]["ORDINE"].ToString();
				}
				else if (Operators.CompareString(sLivello, "1", false) == 0)
				{
					sOrdinePrecedente = "001.000.000";
				}
				else if (Operators.CompareString(sLivello, "2", false) == 0)
				{
					sOrdinePrecedente = sOrdine.Substring(0, 3) + ".001.000";
				}
				else
				{
					sOrdinePrecedente = sOrdine.Substring(0, 7) + ".001";
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

	private FXRETURN GetIdOrdineSuccessivo(string sParentId, string sOrdine, ref string sIdSuccessivo, ref string sOrdineSuccessivo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			sIdSuccessivo = "";
			sOrdineSuccessivo = "";
			if (Operators.CompareString(sParentId, "", false) == 0)
			{
				text = "SELECT TOP(1) ID, ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " AND PARENTID IS NULL ";
				text = text + "AND ORDINE > " + base.DbConn.SQLFormatString(sOrdine) + " ";
				text += "ORDER BY Ordine ASC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			else
			{
				text = "SELECT TOP(1) ID, ORDINE FROM WFI_Desktop_Tree ";
				text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " ";
				text = text + "AND PARENTID = " + base.DbConn.SQLFormatString(sParentId) + " ";
				text = text + "AND ORDINE > " + base.DbConn.SQLFormatString(sOrdine) + " ";
				text += "ORDER BY Ordine ASC";
				if ((int)base.DbConn.ServerType == 1)
				{
					text = text.Replace("TOP(1)", "");
					text = "SELECT * FROM (" + text + ") WHERE ROWNUM<=1";
				}
			}
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count > 0)
				{
					sIdSuccessivo = dataTable.Rows[0]["ID"].ToString();
					sOrdineSuccessivo = dataTable.Rows[0]["ORDINE"].ToString();
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

	private FXRETURN GetValueOrdinePadre(string sLivello, string sId, ref string rsValore, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsValore = "";
			if (Operators.CompareString(sLivello, "1", false) == 0)
			{
				text = "SELECT SUBSTRING(Ordine,1,4) ";
			}
			else if (Operators.CompareString(sLivello, "2", false) == 0)
			{
				text = "SELECT SUBSTRING(Ordine,1,8) ";
			}
			text += "AS ORDINE FROM WFI_Desktop_Tree ";
			text = text + "WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString()) + " ";
			text = text + "AND ID = " + base.DbConn.SQLFormatString(sId) + " ";
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				rsValore = Conversions.ToString(obj);
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

	private FXRETURN AggiornaOrdineMenu(string sLivello, string vsTasto, string sId, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Invalid comparison between Unknown and I4
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Invalid comparison between Unknown and I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Invalid comparison between Unknown and I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Invalid comparison between Unknown and I4
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Invalid comparison between Unknown and I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		string sIdSuccessivo = "";
		string sOrdineSuccessivo = "";
		string sIdPrecedente = "";
		string sOrdinePrecedente = "";
		string sParentId = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT ORDINE FROM WFI_Desktop_Tree ";
			text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sId);
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text2 = Conversions.ToString(obj);
				if (Operators.CompareString(sLivello, "1", false) != 0)
				{
					sParentId = ((Operators.CompareString(sLivello, "2", false) != 0) ? IdSecondoLivello.ObjValue.ToString() : IdPrimoLivello.ObjValue.ToString());
				}
				if (Operators.CompareString(vsTasto, "SU", false) == 0)
				{
					val2 = GetIdOrdinePrecedente(sLivello, sParentId, text2, ref sIdPrecedente, ref sOrdinePrecedente, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						text2 = checked((Operators.CompareString(sLivello, "1", false) == 0) ? (Conversions.ToString(Conversions.ToInteger(sOrdinePrecedente.Substring(0, 3)) + 1).PadLeft(3, '0') + sOrdinePrecedente.Substring(3)) : ((Operators.CompareString(sLivello, "2", false) != 0) ? (sOrdinePrecedente.Substring(0, 8) + Conversions.ToString(Conversions.ToInteger(sOrdinePrecedente.Substring(8, 3)) + 1).PadLeft(3, '0')) : (sOrdinePrecedente.Substring(0, 4) + Conversions.ToString(Conversions.ToInteger(sOrdinePrecedente.Substring(4, 3)) + 1).PadLeft(3, '0') + sOrdinePrecedente.Substring(7))));
						if (Operators.CompareString(sIdPrecedente, "", false) != 0)
						{
							text = "UPDATE WFI_Desktop_Tree SET ORDINE = " + base.DbConn.SQLFormatString(sOrdinePrecedente) + " ";
							text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
							text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = " + base.DbConn.SQLFormatString(text2);
							text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sIdPrecedente) + ";";
						}
						else
						{
							text = "UPDATE WFI_Desktop_Tree SET ORDINE = " + base.DbConn.SQLFormatString(sOrdinePrecedente) + " ";
							text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
						}
						if (Operators.CompareString(sLivello, "1", false) != 0)
						{
							if (Operators.CompareString(sLivello, "2", false) == 0)
							{
								text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdinePrecedente.Substring(0, 8) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,9,3) ";
								text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
								text = text + "UPDATE WFI_Desktop_Tree SET ORDINE  = '" + text2.Substring(0, 8) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,9,3) ";
								text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdPrecedente) + ";";
							}
							goto IL_0b58;
						}
						text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdinePrecedente.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
						text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
						text = text + "UPDATE WFI_Desktop_Tree SET ORDINE  = '" + text2.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
						text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdPrecedente) + ";";
						DataTable dataTable = null;
						string text3 = "";
						text3 = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId);
						val2 = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (dataTable.Rows.Count > 0)
							{
								foreach (DataRow row in dataTable.Rows)
								{
									text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdinePrecedente.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
									string text4 = text;
									DBConnection dbConn = base.DbConn;
									string text5 = row["ID"].ToString();
									text = text4 + "WHERE PARENTID = " + dbConn.SQLFormatNumber(ref text5) + ";";
								}
							}
							dataTable = null;
							text3 = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdPrecedente);
							val2 = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
							if ((int)val2 <= 0)
							{
								if (dataTable.Rows.Count > 0)
								{
									foreach (DataRow row2 in dataTable.Rows)
									{
										text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + text2.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
										string text6 = text;
										DBConnection dbConn2 = base.DbConn;
										string text5 = row2["ID"].ToString();
										text = text6 + "WHERE PARENTID = " + dbConn2.SQLFormatNumber(ref text5) + ";";
									}
								}
								goto IL_0b58;
							}
							val = val2;
						}
					}
				}
				else
				{
					if (Operators.CompareString(vsTasto, "GIU", false) != 0)
					{
						goto IL_0b58;
					}
					val2 = GetIdOrdineSuccessivo(sParentId, text2, ref sIdSuccessivo, ref sOrdineSuccessivo, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Operators.CompareString(sIdSuccessivo, "", false) == 0)
						{
							goto IL_0b58;
						}
						text = "UPDATE WFI_Desktop_Tree SET ORDINE = " + base.DbConn.SQLFormatString(sOrdineSuccessivo) + " ";
						text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
						text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = " + base.DbConn.SQLFormatString(text2);
						text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref sIdSuccessivo) + ";";
						if (Operators.CompareString(sLivello, "1", false) != 0)
						{
							if (Operators.CompareString(sLivello, "2", false) == 0)
							{
								text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdineSuccessivo.Substring(0, 8) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,9,3) ";
								text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
								text = text + "UPDATE WFI_Desktop_Tree SET ORDINE  = '" + text2.Substring(0, 8) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,9,3) ";
								text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdSuccessivo) + ";";
							}
							goto IL_0b58;
						}
						text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdineSuccessivo.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
						text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId) + ";";
						text = text + "UPDATE WFI_Desktop_Tree SET ORDINE  = '" + text2.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
						text = text + "WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdSuccessivo) + ";";
						DataTable dataTable2 = null;
						string text7 = "";
						text7 = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sId);
						val2 = base.DbConn.OpenDataTable(text7, ref dataTable2, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (dataTable2.Rows.Count > 0)
							{
								foreach (DataRow row3 in dataTable2.Rows)
								{
									text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + sOrdineSuccessivo.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
									string text8 = text;
									DBConnection dbConn3 = base.DbConn;
									string text5 = row3["ID"].ToString();
									text = text8 + "WHERE PARENTID = " + dbConn3.SQLFormatNumber(ref text5) + ";";
								}
							}
							dataTable2 = null;
							text7 = "SELECT ID FROM WFI_Desktop_Tree WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref sIdSuccessivo);
							val2 = base.DbConn.OpenDataTable(text7, ref dataTable2, ref rsMess);
							if ((int)val2 <= 0)
							{
								if (dataTable2.Rows.Count > 0)
								{
									foreach (DataRow row4 in dataTable2.Rows)
									{
										text = text + "UPDATE WFI_Desktop_Tree SET ORDINE = '" + text2.Substring(0, 4) + "' " + base.DbConn.StringConcatenateOperator() + " SUBSTRING(ORDINE,5,7) ";
										string text9 = text;
										DBConnection dbConn4 = base.DbConn;
										string text5 = row4["ID"].ToString();
										text = text9 + "WHERE PARENTID = " + dbConn4.SQLFormatNumber(ref text5) + ";";
									}
								}
								goto IL_0b58;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0038;
			IL_0b58:
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_0b8c;
			}
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0b8c;
			}
			val = val2;
			goto end_IL_0038;
			IL_0b8c:
			val = (FXRETURN)0;
			end_IL_0038:;
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

	private void AggiornaSelezionePrimoLivello()
	{
		IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiPrimoLivello).ID];
		DataTable dataTable = iboInternalGridConfig.DataTable;
		DBConnection dbConn = base.DbConn;
		string text = IdPrimoLivello.ObjValue.ToString();
		DataRow[] array = dataTable.Select(" 1=1 AND ID = " + dbConn.SQLFormatNumber(ref text));
		if (array.Count() > 0)
		{
			FieldInfo field = array[0].GetType().GetField("_rowID", BindingFlags.Instance | BindingFlags.NonPublic);
			int num = Conversions.ToInteger(field.GetValue(array[0]));
			int num2 = num % ((GridView)grdNodiPrimoLivello).PageSize;
			checked
			{
				((GridView)grdNodiPrimoLivello).SelectedIndex = num2 - 1;
				grdNodiPrimoLivello.SelectRow(num2 - 1);
			}
		}
	}

	private void AggiornaSelezioneSecondoLivello()
	{
		IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiSecondoLivello).ID];
		DataTable dataTable = iboInternalGridConfig.DataTable;
		DBConnection dbConn = base.DbConn;
		string text = IdSecondoLivello.ObjValue.ToString();
		DataRow[] array = dataTable.Select(" 1=1 AND ID = " + dbConn.SQLFormatNumber(ref text));
		if (array.Count() > 0)
		{
			FieldInfo field = array[0].GetType().GetField("_rowID", BindingFlags.Instance | BindingFlags.NonPublic);
			int num = Conversions.ToInteger(field.GetValue(array[0]));
			int num2 = num % ((GridView)grdNodiPrimoLivello).PageSize;
			checked
			{
				((GridView)grdNodiSecondoLivello).SelectedIndex = num2 - 1;
				grdNodiSecondoLivello.SelectRow(num2 - 1);
			}
		}
	}

	private void AggiornaSelezioneTerzoLivello()
	{
		IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdNodiTerzoLivello).ID];
		DataTable dataTable = iboInternalGridConfig.DataTable;
		DBConnection dbConn = base.DbConn;
		string text = IdTerzoLivello.ObjValue.ToString();
		DataRow[] array = dataTable.Select(" 1=1 AND ID = " + dbConn.SQLFormatNumber(ref text));
		if (array.Count() > 0)
		{
			FieldInfo field = array[0].GetType().GetField("_rowID", BindingFlags.Instance | BindingFlags.NonPublic);
			int num = Conversions.ToInteger(field.GetValue(array[0]));
			int num2 = num % ((GridView)grdNodiPrimoLivello).PageSize;
			checked
			{
				((GridView)grdNodiTerzoLivello).SelectedIndex = num2 - 1;
				grdNodiTerzoLivello.SelectRow(num2 - 1);
			}
		}
	}

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tag, "VOCE", false) != 0)
			{
				goto IL_0059;
			}
			IboWebComboTlk objCombo = Voce;
			FXRETURN val3 = ReloadSingleCombo(ref objCombo, ref rsMess);
			Voce = objCombo;
			val = val3;
			if ((int)val <= 0)
			{
				MasterPopupFormUpdate();
				goto IL_0059;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0059:
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
}
