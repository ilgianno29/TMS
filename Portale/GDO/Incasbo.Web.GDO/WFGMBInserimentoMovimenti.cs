using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFGMBInserimentoMovimenti : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rpDettaglioBancali")]
	private Repeater _rpDettaglioBancali;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataAccessMode1")]
	protected virtual IboWebLabel lblDataAccessMode1
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

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
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

	[field: AccessedThroughProperty("PanelDati")]
	protected virtual Panel PanelDati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGenerale")]
	protected virtual IboWebLabel lblGenerale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCausale")]
	protected virtual IboWebLabel lblCausale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCausale")]
	protected virtual IboWebTextBox txtCausale
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

	[field: AccessedThroughProperty("lblDataMovimento")]
	protected virtual IboWebLabel lblDataMovimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataMovimento")]
	protected virtual IboWebDate txtDataMovimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimento1")]
	protected virtual IboWebLabel lblRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento1")]
	protected virtual IboWebTextBox txtRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRiferimento1")]
	protected virtual IboWebLabel lblDataRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRiferimento1")]
	protected virtual IboWebDate txtDataRiferimento1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRifeimento2")]
	protected virtual IboWebLabel lblRifeimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRiferimento2")]
	protected virtual IboWebTextBox txtRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRiferimento2")]
	protected virtual IboWebLabel lblDataRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRiferimento2")]
	protected virtual IboWebDate txtDataRiferimento2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBuono")]
	protected virtual IboWebLabel lblBuono
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtBuono")]
	protected virtual IboWebTextBox txtBuono
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

	[field: AccessedThroughProperty("lblfiller1")]
	protected virtual IboWebLabel lblfiller1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiller1")]
	protected virtual IboWebTextBox txtFiller1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblfiller2")]
	protected virtual IboWebLabel lblfiller2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtfiller2")]
	protected virtual IboWebTextBox txtfiller2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblfiller3")]
	protected virtual IboWebLabel lblfiller3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtfiller3")]
	protected virtual IboWebTextBox txtfiller3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblfiller4")]
	protected virtual IboWebLabel lblfiller4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtfiller4")]
	protected virtual IboWebTextBox txtfiller4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblfiller5")]
	protected virtual IboWebLabel lblfiller5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtfiller5")]
	protected virtual IboWebTextBox txtfiller5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlPrimoSoggetto")]
	protected virtual Panel pnlPrimoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPrimoSoggetto")]
	protected virtual IboWebLabel lblPrimoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPrimoSoggetto")]
	protected virtual IboWebLabel lblTipoPrimoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoSoggetto1Descrizione")]
	protected virtual IboWebTextBox txtTipoSoggetto1Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoSoggetto1")]
	protected virtual IboWebTextBox txtTipoSoggetto1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSegno1")]
	protected virtual IboWebTextBox txtSegno1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgPlus")]
	protected virtual Image imgPlus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgMinus")]
	protected virtual Image imgMinus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPrimoSoggetto1")]
	protected virtual IboWebLabel lblPrimoSoggetto1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPrimoSoggetto")]
	protected virtual IboWebComboTlk cmbPrimoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSecondoSoggetto")]
	protected virtual Panel pnlSecondoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSecondoSoggetto")]
	protected virtual IboWebLabel lblSecondoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSecondoSoggetto")]
	protected virtual IboWebLabel lblTipoSecondoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoSoggetto2Descrizione")]
	protected virtual IboWebTextBox txtTipoSoggetto2Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoSoggetto2")]
	protected virtual IboWebTextBox txtTipoSoggetto2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSegno2")]
	protected virtual IboWebTextBox txtSegno2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgPlus1")]
	protected virtual Image imgPlus1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgMinus1")]
	protected virtual Image imgMinus1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSecondoSoggetto2")]
	protected virtual IboWebLabel lblSecondoSoggetto2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbSecondoSoggetto")]
	protected virtual IboWebComboTlk cmbSecondoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DettaglioBancali")]
	protected virtual Panel DettaglioBancali
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

	[field: AccessedThroughProperty("DettaglioBancaliContent")]
	protected virtual Panel DettaglioBancaliContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDettaglioBancaliCodice")]
	protected virtual IboWebLabel lblDettaglioBancaliCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDettaglioBancaliDescrizione")]
	protected virtual IboWebLabel lblDettaglioBancaliDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDettaglioBancaliQta")]
	protected virtual IboWebLabel lblDettaglioBancaliQta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater rpDettaglioBancali
	{
		[CompilerGenerated]
		get
		{
			return _rpDettaglioBancali;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(rpDettaglioBancali_ItemDataBound);
			Repeater val2 = _rpDettaglioBancali;
			if (val2 != null)
			{
				val2.ItemDataBound -= val;
			}
			_rpDettaglioBancali = value;
			val2 = _rpDettaglioBancali;
			if (val2 != null)
			{
				val2.ItemDataBound += val;
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
		_Context = "DM.GMB.INSERIMENTOMOVIMENTI";
		_Title = base.Translator.Translate("XXX", "Inserimento Movimento GMB", new string[0]);
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
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				goto IL_0153;
			}
			bool flag = false;
			WebControl val3 = null;
			foreach (RepeaterItem item in rpDettaglioBancali.Items)
			{
				RepeaterItem val4 = item;
				string text = ((IIboWebComponent)((Control)val4).FindControl("lblTipoBancaleCodice")).ObjValue.ToString();
				int num = Conversions.ToInteger(((IIboWebComponent)((Control)val4).FindControl("txtTipoBancaleQta")).ObjValue);
				if (val3 == null)
				{
					val3 = (WebControl)((Control)val4).FindControl("txtTipoBancaleQta");
				}
				if (num > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				rsMess = TranslateMessage("XXX", "Inserire le quantità dei tipi bancali movimentati");
				if (val3 != null)
				{
					((Control)val3).Focus();
				}
				goto IL_0153;
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
		result = base.AfterCheckData(ref rsMess);
		goto IL_0153;
		IL_0153:
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = MainLoadData(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = LoadRepeaterDettaglioBancali(ref rsMess);
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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeSaveData(ref rsMess);
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Invalid comparison between Unknown and I4
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.SaveData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				GMB_Documento Gmb_Documento = new GMB_Documento();
				Gmb_Documento.Causale = txtCausale.ObjValue.ToString();
				Gmb_Documento.Data = txtDataMovimento.getDateValue;
				Gmb_Documento.IdRiferimento1 = txtRiferimento1.ObjValue.ToString();
				Gmb_Documento.IdRiferimento2 = txtRiferimento2.ObjValue.ToString();
				if (Operators.CompareString(txtDataRiferimento1.ObjValue.ToString(), "", false) != 0)
				{
					Gmb_Documento.DataRiferimento1 = txtDataRiferimento1.getDateValue;
				}
				if (Operators.CompareString(txtDataRiferimento2.ObjValue.ToString(), "", false) != 0)
				{
					Gmb_Documento.DataRiferimento2 = txtDataRiferimento2.getDateValue;
				}
				Gmb_Documento.NumeroBuono = txtBuono.ObjValue.ToString();
				Gmb_Documento.Segno1 = ((Operators.CompareString(txtSegno1.ObjValue.ToString(), "+", false) != 0) ? GMB_Segno.Minus : GMB_Segno.Plus);
				GMB_TipoSoggetto tipoSoggetto = GMB_TipoSoggetto.NotDefined;
				if (Operators.CompareString(txtTipoSoggetto1.ObjValue.ToString(), "D", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Destinatario;
				}
				else if (Operators.CompareString(txtTipoSoggetto1.ObjValue.ToString(), "C", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Cliente;
				}
				else if (Operators.CompareString(txtTipoSoggetto1.ObjValue.ToString(), "F", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Filiale;
				}
				else if (Operators.CompareString(txtTipoSoggetto1.ObjValue.ToString(), "H", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Corrispondente;
				}
				else if (Operators.CompareString(txtTipoSoggetto1.ObjValue.ToString(), "V", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Vettore;
				}
				Gmb_Documento.TipoSoggetto1 = tipoSoggetto;
				Gmb_Documento.Soggetto1 = cmbPrimoSoggetto.ObjValue.ToString();
				Gmb_Documento.Segno2 = ((Operators.CompareString(txtSegno2.ObjValue.ToString(), "+", false) != 0) ? ((Operators.CompareString(txtSegno2.ObjValue.ToString(), "", false) != 0) ? GMB_Segno.Minus : GMB_Segno.NotDefined) : GMB_Segno.Plus);
				tipoSoggetto = GMB_TipoSoggetto.NotDefined;
				if (Operators.CompareString(txtTipoSoggetto2.ObjValue.ToString(), "D", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Destinatario;
				}
				else if (Operators.CompareString(txtTipoSoggetto2.ObjValue.ToString(), "C", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Cliente;
				}
				else if (Operators.CompareString(txtTipoSoggetto2.ObjValue.ToString(), "F", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Filiale;
				}
				else if (Operators.CompareString(txtTipoSoggetto2.ObjValue.ToString(), "H", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Corrispondente;
				}
				else if (Operators.CompareString(txtTipoSoggetto2.ObjValue.ToString(), "V", false) == 0)
				{
					tipoSoggetto = GMB_TipoSoggetto.Vettore;
				}
				Gmb_Documento.TipoSoggetto2 = tipoSoggetto;
				Gmb_Documento.Soggetto2 = cmbSecondoSoggetto.ObjValue.ToString();
				Gmb_Documento.Filler1 = txtFiller1.ObjValue.ToString();
				Gmb_Documento.Filler2 = txtFiller1.ObjValue.ToString();
				Gmb_Documento.Filler3 = txtFiller1.ObjValue.ToString();
				Gmb_Documento.Filler4 = txtFiller1.ObjValue.ToString();
				Gmb_Documento.Filler5 = txtFiller1.ObjValue.ToString();
				Gmb_Documento.Note = txtNote.ObjValue.ToString();
				foreach (RepeaterItem item in rpDettaglioBancali.Items)
				{
					RepeaterItem val3 = item;
					string tipoBancale = ((IIboWebComponent)((Control)val3).FindControl("lblTipoBancaleCodice")).ObjValue.ToString();
					int num = Conversions.ToInteger(((IIboWebComponent)((Control)val3).FindControl("txtTipoBancaleQta")).ObjValue);
					if (num > 0)
					{
						GMB_MovimentoBancale gMB_MovimentoBancale = new GMB_MovimentoBancale();
						gMB_MovimentoBancale.TipoBancale = tipoBancale;
						gMB_MovimentoBancale.Quantita = num;
						Gmb_Documento.Bancali.Add(gMB_MovimentoBancale);
					}
				}
				List<GMB_Movimento> GMB_Movimenti = null;
				val2 = GMB_MovimentoInserisci_Invoker.Instance.RunProc(CreateApiContext(), ref Gmb_Documento, ref GMB_Movimenti, ref rsMess);
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

	private void rpDettaglioBancali_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected FXRETURN MainLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
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
			if (Operators.CompareString(_SessionVariable["CausaleGmb"].ToString(), "", false) != 0)
			{
				text2 = _SessionVariable["CausaleGmb"].ToString();
				txtCausale.ObjValue = text2;
				string text3 = "SELECT * FROM BANCALICAUSALI WHERE CODICE = '" + text2 + "' ";
				val2 = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["DESCRIZIONE"].ToString(), "", false) != 0)
				{
					txtDescrizione.ObjValue = dataTable.Rows[0]["DESCRIZIONE"].ToString();
					if (Operators.CompareString(dataTable.Rows[0]["TIPOCAUSALE"].ToString(), "", false) != 0)
					{
						string text4 = dataTable.Rows[0]["TIPOCAUSALE"].ToString();
						if (Operators.CompareString(text4, "S", false) == 0)
						{
							((Control)pnlSecondoSoggetto).Visible = false;
						}
						else
						{
							((Control)pnlSecondoSoggetto).Visible = true;
						}
						if (Operators.CompareString(dataTable.Rows[0]["SEGNO1"].ToString(), "", false) != 0)
						{
							string text5 = dataTable.Rows[0]["SEGNO1"].ToString();
							txtSegno1.ObjValue = text5;
							if (Operators.CompareString(text5, "+", false) == 0)
							{
								((Control)imgPlus).Visible = true;
								((Control)imgMinus).Visible = false;
							}
							else
							{
								((Control)imgPlus).Visible = false;
								((Control)imgMinus).Visible = true;
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["SEGNO2"])))
							{
								string text6 = dataTable.Rows[0]["SEGNO2"].ToString();
								txtSegno2.ObjValue = text6;
								if (Operators.CompareString(text6, "+", false) == 0)
								{
									((Control)imgPlus1).Visible = true;
									((Control)imgMinus1).Visible = false;
								}
								else
								{
									((Control)imgPlus1).Visible = false;
									((Control)imgMinus1).Visible = true;
								}
							}
							else
							{
								cmbSecondoSoggetto.Required = false;
							}
							if (Operators.CompareString(dataTable.Rows[0]["TIPOSOGGETTO1"].ToString(), "", false) != 0)
							{
								string text7 = dataTable.Rows[0]["TIPOSOGGETTO1"].ToString();
								txtTipoSoggetto1.ObjValue = text7;
								switch (text7)
								{
								case "D":
									txtTipoSoggetto1Descrizione.ObjValue = "DESTINATARIO";
									break;
								case "F":
									txtTipoSoggetto1Descrizione.ObjValue = "DEPOSITO INTERNO (FILIALE)";
									break;
								case "H":
									txtTipoSoggetto1Descrizione.ObjValue = "DEPOSITO ESTERNO (CORRISPONDENTE)";
									break;
								case "C":
									txtTipoSoggetto1Descrizione.ObjValue = "CLIENTE";
									break;
								case "V":
									txtTipoSoggetto1Descrizione.ObjValue = "VETTORE";
									break;
								default:
									txtTipoSoggetto1Descrizione.ObjValue = "";
									break;
								}
								cmbPrimoSoggetto.SqlQueryFilter = "TIPOANAGRAFICA = '" + text7 + "' ";
								if (!Information.IsDBNull((object)dataTable.Rows[0]["TIPOSOGGETTO2"].ToString()))
								{
									string text8 = dataTable.Rows[0]["TIPOSOGGETTO2"].ToString();
									txtTipoSoggetto2.ObjValue = text8;
									switch (text8)
									{
									case "D":
										txtTipoSoggetto2Descrizione.ObjValue = "DESTINATAZIONE";
										break;
									case "F":
										txtTipoSoggetto2Descrizione.ObjValue = "DEPOSITO INTERNO (FILIALE)";
										break;
									case "H":
										txtTipoSoggetto2Descrizione.ObjValue = "DEPOSITO ESTERNO (CORRISPONDENTE)";
										break;
									case "C":
										txtTipoSoggetto2Descrizione.ObjValue = "CLIENTE";
										break;
									case "V":
										txtTipoSoggetto2Descrizione.ObjValue = "VETTORE";
										break;
									default:
										txtTipoSoggetto2Descrizione.ObjValue = "";
										break;
									}
									cmbSecondoSoggetto.SqlQueryFilter = "TIPOANAGRAFICA = '" + text8 + "' ";
								}
								if (!((Page)this).IsPostBack)
								{
									txtDataMovimento.ObjValue = DateAndTime.Now.Date;
								}
								val = (FXRETURN)0;
							}
							else
							{
								rsMess = TranslateMessage("XXX", "Tipo soggetto del secondo soggetto non valorizzato!");
							}
						}
						else
						{
							rsMess = TranslateMessage("XXX", "Segno del primo soggetto non valorizzato!");
						}
					}
					else
					{
						rsMess = TranslateMessage("XXX", "Descrizione della causale di movimentazione bancali non valorizzata!");
					}
				}
				else
				{
					rsMess = TranslateMessage("XXX", "Descrizione della causale di movimentazione bancali non valorizzata!");
				}
			}
			else
			{
				rsMess = TranslateMessage("XXX", "Causale di movimentazione bancali non valorizzata!");
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

	protected FXRETURN LoadRepeaterDettaglioBancali(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "SELECT B.* FROM BANCALITIPI B WHERE B.ATTIVO='S'";
			DataTable dataSource = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataSource, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				rpDettaglioBancali.DataSource = dataSource;
				rpDettaglioBancali.DataBind();
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
}
