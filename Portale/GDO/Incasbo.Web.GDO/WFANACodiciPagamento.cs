using System;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFANACodiciPagamento : WFIDBPage
{
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

	[field: AccessedThroughProperty("lblCodiceContabile")]
	protected virtual IboWebLabel lblCodiceContabile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodiceContabile")]
	protected virtual IboWebTextBox txtCodiceContabile
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

	[field: AccessedThroughProperty("cmbTipoPagamento")]
	protected virtual IboDropDownList cmbTipoPagamento
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

	[field: AccessedThroughProperty("lblGiorni1")]
	protected virtual IboWebLabel lblGiorni1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorni1")]
	protected virtual IboWebNumericTlk txtGiorni1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorni2")]
	protected virtual IboWebNumericTlk txtGiorni2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorni3")]
	protected virtual IboWebNumericTlk txtGiorni3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFineMese")]
	protected virtual IboWebLabel lblFineMese
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFineMese")]
	protected virtual IboWebCheckBox chkFineMese
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IblGiorniOffset")]
	protected virtual IboWebLabel IblGiorniOffset
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniOffset")]
	protected virtual IboWebNumericTlk txtGiorniOffset
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
		_Context = "DM.ANA.CODICIPAGAMENTO";
		_AutoCodeKeyField = "Codice";
		_Title = base.Translator.Translate("XXX", "Codice Pagamento", new string[0]);
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0 && checkGiorni(ref rsMess) && checkSlittamento(ref rsMess))
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

	private bool checkSlittamento(ref string rsMess)
	{
		rsMess = "";
		double? value = ((RadNumericTextBox)txtGiorniOffset).Value;
		if ((value.HasValue ? new bool?(value.GetValueOrDefault() > 30.0) : null).GetValueOrDefault())
		{
			rsMess = TranslateMessage("XXX", "Impostare uno slittamento minore o uguale a 30gg");
			bool flag = false;
		}
		return true;
	}

	private bool checkGiorni(ref string rsMess)
	{
		rsMess = "";
		double? value = ((RadNumericTextBox)txtGiorni2).Value;
		double? value2 = ((RadNumericTextBox)txtGiorni1).Value;
		bool? flag = ((value.HasValue & value2.HasValue) ? new bool?(value.GetValueOrDefault() <= value2.GetValueOrDefault()) : null);
		value2 = ((RadNumericTextBox)txtGiorni2).Value;
		bool? flag2 = (value2.HasValue ? new bool?(value2.GetValueOrDefault() > 0.0) : null);
		bool? flag3 = (((!flag) ?? false) ? new bool?(false) : ((!flag2.HasValue) ? null : (flag2.GetValueOrDefault() & flag)));
		value2 = ((RadNumericTextBox)txtGiorni3).Value;
		value = ((RadNumericTextBox)txtGiorni2).Value;
		flag2 = ((value2.HasValue & value.HasValue) ? new bool?(value2.GetValueOrDefault() <= value.GetValueOrDefault()) : null);
		value = ((RadNumericTextBox)txtGiorni3).Value;
		flag = (value.HasValue ? new bool?(value.GetValueOrDefault() > 0.0) : null);
		bool? flag4 = (((!flag2) ?? false) ? new bool?(false) : ((!flag.HasValue) ? null : (flag.GetValueOrDefault() & flag2)));
		bool? flag5 = ((flag3 ?? false) ? new bool?(true) : ((!flag4.HasValue) ? null : (flag4.GetValueOrDefault() | flag3)));
		value = ((RadNumericTextBox)txtGiorni3).Value;
		value2 = ((RadNumericTextBox)txtGiorni1).Value;
		flag4 = ((value.HasValue & value2.HasValue) ? new bool?(value.GetValueOrDefault() <= value2.GetValueOrDefault()) : null);
		value2 = ((RadNumericTextBox)txtGiorni3).Value;
		flag3 = (value2.HasValue ? new bool?(value2.GetValueOrDefault() > 0.0) : null);
		bool? flag6 = (((!flag4) ?? false) ? new bool?(false) : ((!flag3.HasValue) ? null : (flag3.GetValueOrDefault() & flag4)));
		bool? flag7 = ((flag5 ?? false) ? new bool?(true) : ((!flag6.HasValue) ? null : (flag6.GetValueOrDefault() | flag5)));
		value2 = ((RadNumericTextBox)txtGiorni2).Value;
		value = ((RadNumericTextBox)txtGiorni3).Value;
		flag6 = ((value2.HasValue & value.HasValue) ? new bool?(value2.GetValueOrDefault() < value.GetValueOrDefault()) : null);
		value = ((RadNumericTextBox)txtGiorni2).Value;
		flag5 = (value.HasValue ? new bool?(value.GetValueOrDefault() == 0.0) : null);
		bool? flag8 = (((!flag6) ?? false) ? new bool?(false) : ((!flag5.HasValue) ? null : (flag5.GetValueOrDefault() & flag6)));
		bool? flag9 = ((flag7 ?? false) ? new bool?(true) : ((!flag8.HasValue) ? null : (flag8.GetValueOrDefault() | flag7)));
		value = ((RadNumericTextBox)txtGiorni1).Value;
		flag8 = (value.HasValue ? new bool?(value.GetValueOrDefault() == 0.0) : null);
		value = ((RadNumericTextBox)txtGiorni2).Value;
		flag5 = (value.HasValue ? new bool?(value.GetValueOrDefault() > 0.0) : null);
		value = ((RadNumericTextBox)txtGiorni3).Value;
		flag6 = (value.HasValue ? new bool?(value.GetValueOrDefault() > 0.0) : null);
		flag7 = ((flag5 ?? false) ? new bool?(true) : ((!flag6.HasValue) ? null : (flag6.GetValueOrDefault() | flag5)));
		bool? flag10 = (((!flag8) ?? false) ? new bool?(false) : ((!flag7.HasValue) ? null : (flag7.GetValueOrDefault() & flag8)));
		if (((flag9 ?? false) ? new bool?(true) : ((!flag10.HasValue) ? null : (flag10.GetValueOrDefault() | flag9))).GetValueOrDefault())
		{
			rsMess = TranslateMessage("XXX", "Scadenze non consecutive");
			return false;
		}
		return true;
	}
}
