using System;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAPCSOrariVisita : WFIDBPage
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

	[field: AccessedThroughProperty("lblCodiceSoggettoCaption")]
	protected virtual IboWebLabel lblCodiceSoggettoCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoSoggetto")]
	protected virtual HiddenField TipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceSoggettoValue")]
	protected virtual IboWebLabel lblCodiceSoggettoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneSoggettoCaption")]
	protected virtual IboWebLabel lblDescrizioneSoggettoCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneSoggettoValue")]
	protected virtual IboWebLabel lblDescrizioneSoggettoValue
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

	[field: AccessedThroughProperty("lblTempoCaricoScarico")]
	protected virtual IboWebLabel lblTempoCaricoScarico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTempoCaricoScarico")]
	protected virtual IboWebComboTlk cmbTempoCaricoScarico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrarioVisita1")]
	protected virtual IboWebLabel lblOrarioVisita1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbOrarioVisita1")]
	protected virtual IboWebComboTlk cmbOrarioVisita1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniValidita1")]
	protected virtual IboWebLabel lblGiorniValidita1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniValidita1")]
	protected virtual IboWebTextBox txtGiorniValidita1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniValidita1")]
	protected virtual ListBox GiorniValidita1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrarioVisita2")]
	protected virtual IboWebLabel lblOrarioVisita2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbOrarioVisita2")]
	protected virtual IboWebComboTlk cmbOrarioVisita2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniValidita2")]
	protected virtual IboWebLabel lblGiorniValidita2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniValidita2")]
	protected virtual IboWebTextBox txtGiorniValidita2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniValidita2")]
	protected virtual ListBox GiorniValidita2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrarioVisita3")]
	protected virtual IboWebLabel lblOrarioVisita3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbOrarioVisita3")]
	protected virtual IboWebComboTlk cmbOrarioVisita3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniValidita3")]
	protected virtual IboWebLabel lblGiorniValidita3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniValidita3")]
	protected virtual IboWebTextBox txtGiorniValidita3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniValidita3")]
	protected virtual ListBox GiorniValidita3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrarioVisita4")]
	protected virtual IboWebLabel lblOrarioVisita4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbOrarioVisita4")]
	protected virtual IboWebComboTlk cmbOrarioVisita4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniValidita4")]
	protected virtual IboWebLabel lblGiorniValidita4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniValidita4")]
	protected virtual IboWebTextBox txtGiorniValidita4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniValidita4")]
	protected virtual ListBox GiorniValidita4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOrarioVisita5")]
	protected virtual IboWebLabel lblOrarioVisita5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbOrarioVisita5")]
	protected virtual IboWebComboTlk cmbOrarioVisita5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniValidita5")]
	protected virtual IboWebLabel lblGiorniValidita5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGiorniValidita5")]
	protected virtual IboWebTextBox txtGiorniValidita5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniValidita5")]
	protected virtual ListBox GiorniValidita5
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

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.ANA.PCS.ORARIVISITA";
		_Title = base.Translator.Translate("XXX", "Tipo Merce - Orario Visita", new string[0]);
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			ListBox lst = GiorniValidita1;
			StringToListBox(ref lst, ",", txtGiorniValidita1.ObjValue.ToString());
			GiorniValidita1 = lst;
			lst = GiorniValidita2;
			StringToListBox(ref lst, ",", txtGiorniValidita2.ObjValue.ToString());
			GiorniValidita2 = lst;
			lst = GiorniValidita3;
			StringToListBox(ref lst, ",", txtGiorniValidita3.ObjValue.ToString());
			GiorniValidita3 = lst;
			lst = GiorniValidita4;
			StringToListBox(ref lst, ",", txtGiorniValidita4.ObjValue.ToString());
			GiorniValidita4 = lst;
			lst = GiorniValidita5;
			StringToListBox(ref lst, ",", txtGiorniValidita5.ObjValue.ToString());
			GiorniValidita5 = lst;
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if ((Operators.CompareString(cmbOrarioVisita1.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtGiorniValidita1.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire i giorni di validità relativi agli orari di visita");
			}
			else if ((Operators.CompareString(cmbOrarioVisita2.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtGiorniValidita2.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire i giorni di validità relativi agli orari di visita");
			}
			else if ((Operators.CompareString(cmbOrarioVisita3.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtGiorniValidita3.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire i giorni di validità relativi agli orari di visita");
			}
			else if ((Operators.CompareString(cmbOrarioVisita4.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtGiorniValidita4.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire i giorni di validità relativi agli orari di visita");
			}
			else if ((Operators.CompareString(cmbOrarioVisita5.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtGiorniValidita5.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire i giorni di validità relativi agli orari di visita");
			}
			else if ((Operators.CompareString(cmbOrarioVisita1.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtGiorniValidita1.ObjValue.ToString(), "", false) != 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire gli orari di visita relativi ai giorni di validità selezionati");
			}
			else if ((Operators.CompareString(cmbOrarioVisita2.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtGiorniValidita2.ObjValue.ToString(), "", false) != 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire gli orari di visita relativi ai giorni di validità selezionati");
			}
			else if ((Operators.CompareString(cmbOrarioVisita3.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtGiorniValidita3.ObjValue.ToString(), "", false) != 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire gli orari di visita relativi ai giorni di validità selezionati");
			}
			else if ((Operators.CompareString(cmbOrarioVisita4.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtGiorniValidita4.ObjValue.ToString(), "", false) != 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire gli orari di visita relativi ai giorni di validità selezionati");
			}
			else if ((Operators.CompareString(cmbOrarioVisita5.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(txtGiorniValidita5.ObjValue.ToString(), "", false) != 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire gli orari di visita relativi ai giorni di validità selezionati");
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

	protected override FXRETURN BeforeCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
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
				ListBox lst = GiorniValidita1;
				string text2 = ListBoxToString(ref lst, ",");
				GiorniValidita1 = lst;
				string objValue = text2;
				txtGiorniValidita1.ObjValue = objValue;
				lst = GiorniValidita2;
				string text3 = ListBoxToString(ref lst, ",");
				GiorniValidita2 = lst;
				objValue = text3;
				txtGiorniValidita2.ObjValue = objValue;
				lst = GiorniValidita3;
				string text4 = ListBoxToString(ref lst, ",");
				GiorniValidita3 = lst;
				objValue = text4;
				txtGiorniValidita3.ObjValue = objValue;
				lst = GiorniValidita4;
				string text5 = ListBoxToString(ref lst, ",");
				GiorniValidita4 = lst;
				objValue = text5;
				txtGiorniValidita4.ObjValue = objValue;
				lst = GiorniValidita5;
				string text6 = ListBoxToString(ref lst, ",");
				GiorniValidita5 = lst;
				objValue = text6;
				txtGiorniValidita5.ObjValue = objValue;
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

	protected void StringToListBox(ref ListBox lst, string separator, string values)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		string[] array = values.Split(new char[1] { Conversions.ToChar(separator) });
		foreach (ListItem item in ((ListControl)lst).Items)
		{
			ListItem val = item;
			val.Selected = false;
		}
		string[] array2 = array;
		foreach (string text in array2)
		{
			foreach (ListItem item2 in ((ListControl)lst).Items)
			{
				ListItem val2 = item2;
				if (Operators.CompareString(val2.Value.ToUpper(), text.ToUpper(), false) == 0)
				{
					val2.Selected = true;
				}
			}
		}
	}

	protected string ListBoxToString(ref ListBox lst, string separator)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		string text = "";
		if (Operators.CompareString(separator, "", false) == 0)
		{
			separator = ",";
		}
		foreach (ListItem item in ((ListControl)lst).Items)
		{
			ListItem val = item;
			if (val.Selected)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += ",";
				}
				text += val.Value;
			}
		}
		return text;
	}
}
