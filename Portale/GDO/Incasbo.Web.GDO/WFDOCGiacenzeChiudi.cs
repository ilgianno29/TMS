using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCGiacenzeChiudi : WFIDialogPage
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

	[field: AccessedThroughProperty("lblCausaleChisura")]
	protected virtual IboWebLabel lblCausaleChisura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CausaleChisura")]
	protected virtual IboWebComboTlk CausaleChisura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataChiusura")]
	protected virtual IboWebLabel lblDataChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataChiusura")]
	protected virtual IboWebDate2 DataChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGiorniGiacenza")]
	protected virtual IboWebLabel lblGiorniGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiorniGiacenza")]
	protected virtual IboWebNumericTlk GiorniGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteChisura")]
	protected virtual IboWebLabel lblNoteChisura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NoteChiusura")]
	protected virtual IboWebTextBox NoteChiusura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.GIACENZE.CHIUDI";
		_RaiseIFrameCloseOnDiscard = true;
		_Title = base.Translator.Translate("XXX", "Chiusura Giacenze", new string[0]);
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
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!_SessionVariable.ContainsKey("PARAMS_FUNCARGS"))
			{
				goto IL_0296;
			}
			if (((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				val2 = base.AfterLoadData(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					List<string> list = new List<string>();
					checked
					{
						int num = ((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Id").FieldValuesCount - 1;
						for (int i = 0; i <= num; i++)
						{
							list.Add(((FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"]).Data.Item("Id").get_FieldValues(i).ToString());
						}
						_SessionVariable["Ids"] = (object)list;
					}
					if (list.Count == 0)
					{
						rsMess = TranslateMessage("XXX", "Non è stata selezionata nessuna pratica di giacenza");
					}
					else
					{
						if (list.Count > 1)
						{
							lblGiorniGiacenza.Visible = false;
							GiorniGiacenza.Visible = false;
						}
						string text2 = "SELECT * FROM Giacenze WHERE ID IN (";
						foreach (string item in list)
						{
							text2 = text2 + item + ",";
						}
						text2 += "-1) ";
						DataTable dataTable = null;
						val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
						if ((int)val2 <= 0)
						{
							foreach (DataRow row in dataTable.Rows)
							{
								if (Conversions.ToInteger(row["Stato"]) <= 10)
								{
									continue;
								}
								rsMess = TranslateMessage("XXX", "La giacenza con id {0} risulta già chiusa", row["Id"].ToString());
								goto end_IL_000b;
							}
							CausaleChisura.ObjValue = base.ApplicationDefault.Giacenza_CausaleChiusura_Default();
							goto IL_0296;
						}
						val = val2;
					}
				}
			}
			goto end_IL_000b;
			IL_0296:
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
			result = val;
		}
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			int? num = null;
			if (((RadNumericTextBox)GiorniGiacenza).Value.HasValue)
			{
				num = Conversions.ToInteger(GiorniGiacenza.ObjValue);
			}
			List<string> list = (List<string>)_SessionVariable["Ids"];
			string text2 = "";
			foreach (string item in list)
			{
				Giacenza_Chiudi_Invoker instance = Giacenza_Chiudi_Invoker.Instance;
				AppApiContext objApiContext = CreateApiContext();
				int idGiacenza = Conversions.ToInteger(item);
				DateTime? dataChiusura = DataChiusura.getDateValue;
				string? causaleChiusura = CausaleChisura.ObjValue.ToString();
				string? noteChiusura = NoteChiusura.ObjValue.ToString();
				int? giorniGiacenza = num;
				string RetQueryToApply = "";
				val2 = instance.RunProc(objApiContext, idGiacenza, "", dataChiusura, causaleChiusura, noteChiusura, giorniGiacenza, ApplyQuery: true, ref RetQueryToApply, ref rsMess);
				if ((int)val2 > 0)
				{
					text2 = text2 + TranslateMessage("XXX", "Id giacenza {0} in errore: {1}", item, rsMess) + "\r\n";
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				ShowNotificationMessage("Chiusura pratiche di giacenza", text2);
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
}
