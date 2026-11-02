using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioni_Corrispondente : WFIDialogPage
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
	protected virtual IboWebLabel cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCorrispondente")]
	protected virtual Panel pnlCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispIstruzioni")]
	protected virtual IboWebLabel lblCorrispIstruzioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondente")]
	protected virtual IboWebLabel lblCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Corrispondente")]
	protected virtual IboWebComboTlk Corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = "DM.DOC.SPEDIZIONI#CORRISP";
			_Title = base.Translator.Translate("XXX", "Diretta/TP", new string[0]);
			val2 = base.InitializedPage(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				base.btnAnnulla = btnAnnulla;
				base.btnConferma = btnConferma;
				base.lblDataAccessMode = lblDataAccessMode;
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
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
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
			if (((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				checked
				{
					int num = ((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Unibol").FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						text2 = text2 + base.DbConn.SQLFormatString(((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Unibol").get_FieldValues(i).ToString()) + ", ";
					}
					if (text2.Length > 0)
					{
						text2 = text2.Substring(0, text2.Length - 2);
					}
					text = "SELECT DISTINCT(Corrispondente) FROM Spedizioni WHERE Unibol IN (";
					text += text2;
					text += ")";
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				}
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if ((dataTable.Rows.Count == 0) | (dataTable.Rows.Count > 1))
					{
						IboWebComboTlk corrispondente = Corrispondente;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)corrispondente, "", ref rsMess2);
					}
					else
					{
						IboWebComboTlk corrispondente2 = Corrispondente;
						string? sItemValue = dataTable.Rows[0]["Corrispondente"].ToString();
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)corrispondente2, sItemValue, ref rsMess2);
					}
					val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Invalid comparison between Unknown and I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			checked
			{
				int num = ((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Unibol").FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					text = text + base.DbConn.SQLFormatString(((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Unibol").get_FieldValues(i).ToString()) + ", ";
				}
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 2);
				}
				text2 = "UPDATE Spedizioni SET Corrispondente=";
				text2 += ((Operators.CompareString(Corrispondente.ObjValue.ToString(), "", false) == 0) ? "NULL " : (base.DbConn.SQLFormatString(Corrispondente.ObjValue.ToString()) + " "));
				text2 += "WHERE Unibol IN (";
				text2 += text;
				text2 += "); ";
				val2 = base.DbConn.SqlExec(text2, ref rsMess);
			}
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
