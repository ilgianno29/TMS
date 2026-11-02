using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFCSTFiltroInvioMailFatPas : WFIDialogPage
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

	[field: AccessedThroughProperty("lblDaNumero")]
	protected virtual IboWebLabel lblDaNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DaNumero")]
	protected virtual IboWebNumericTlk DaNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblANumero")]
	protected virtual IboWebLabel lblANumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ANumero")]
	protected virtual IboWebNumericTlk ANumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFattura")]
	protected virtual IboWebLabel lblDataFattura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataFattura")]
	protected virtual IboWebDate2 DataFattura
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
		_Context = "CST.FILTROMAIL.FATPASS";
		_Title = base.Translator.Translate("XXX", "Filtro per Invio Mail Fatture Passive", new string[0]);
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
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
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
			else if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataFattura.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire almeno un filtro per la ricerca delle fatture");
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
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
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_005f;
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
		goto IL_005f;
		IL_005f:
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Invalid comparison between Unknown and I4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Invalid comparison between Unknown and I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text2 = "";
			DataTable dataTable = null;
			text2 = "SELECT IDFATTURA,TRASPORTATORE FROM Fatture_Passive_Testata WHERE 1=1 ";
			if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) == 0))
			{
				string text3 = text2;
				DBConnection dbConn = base.DbConn;
				string text4 = DaNumero.ObjValue.ToString();
				text2 = text3 + "AND IDFATTURA = " + dbConn.SQLFormatNumber(ref text4) + " ";
			}
			else if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) != 0))
			{
				string text5 = text2;
				DBConnection dbConn2 = base.DbConn;
				string text4 = DaNumero.ObjValue.ToString();
				text2 = text5 + "AND IDFATTURA >= " + dbConn2.SQLFormatNumber(ref text4) + " ";
				string text6 = text2;
				DBConnection dbConn3 = base.DbConn;
				text4 = ANumero.ObjValue.ToString();
				text2 = text6 + "AND IDFATTURA <= " + dbConn3.SQLFormatNumber(ref text4) + " ";
			}
			if (Operators.CompareString(DataFattura.ObjValue.ToString(), "", false) != 0)
			{
				text2 = text2 + "AND DATA = " + base.DbConn.SQLFormatDate((eTipoData)1, DataFattura.ObjValue.ToString()) + " ";
			}
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				StringCollection stringCollection = new StringCollection();
				string text7 = "";
				foreach (DataRow row in dataTable.Rows)
				{
					string text8 = row["TRASPORTATORE"].ToString();
					bool flag = false;
					if (!(!dictionary.ContainsKey(text8) & !stringCollection.Contains(text8)))
					{
						if (dictionary.ContainsKey(text8))
						{
							flag = true;
							goto IL_033c;
						}
						text7 = text7 + TranslateMessage("XXX", "IdFattura {0} del trasportatore {1} non inviata", row["IDFATTURA"].ToString(), row["TRASPORTATORE"].ToString()) + "\r\n";
						continue;
					}
					object obj = null;
					text2 = "SELECT EMAIL FROM TrasportatoriContatti TC INNER JOIN CONTATTI C ON C.ID = TC.IDCONTATTO ";
					text2 = text2 + "WHERE TRASPORTATORE = " + base.DbConn.SQLFormatString(text8) + " ";
					text2 += "AND TIPOCONTATTO = 'INVFAT' ";
					val2 = base.DbConn.DoSql(text2, (object)"", ref obj, ref rsMess);
					if ((int)val2 <= 0)
					{
						if (Operators.CompareString(obj.ToString(), "", false) != 0)
						{
							dictionary.Add(text8, obj.ToString());
							flag = true;
						}
						else
						{
							stringCollection.Add(text8);
						}
						goto IL_033c;
					}
					val = val2;
					goto end_IL_000b;
					IL_033c:
					if (!flag)
					{
						continue;
					}
					string text9 = "";
					text9 = "TIPOLOGIA=FP;MAILTO=" + dictionary[text8] + ";IDFATTURAPASSIVA=" + row["IDFATTURA"].ToString() + ";";
					text2 = "INSERT INTO  DelsyTasks_Triggers (Istanza, Task, Applicazione, Argomenti) VALUES (";
					text2 += "'MAIN','TASKMAILREP','DSI',";
					text2 = text2 + base.DbConn.SQLFormatString(text9) + ")";
					val2 = base.DbConn.SqlExec(text2, ref rsMess);
					if ((int)val2 <= 0)
					{
						continue;
					}
					val = val2;
					goto end_IL_000b;
				}
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
}
