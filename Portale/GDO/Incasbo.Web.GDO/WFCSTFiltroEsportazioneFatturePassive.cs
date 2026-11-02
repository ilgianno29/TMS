using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFCSTFiltroEsportazioneFatturePassive : WFIDialogPage
{
	protected string _Mode;

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

	[field: AccessedThroughProperty("lblVettore")]
	protected virtual IboWebLabel lblVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Vettore")]
	protected virtual IboWebComboTlk Vettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiesporta")]
	protected virtual IboWebLabel lblRiesporta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Riesporta")]
	protected virtual IboWebCheckBox Riesporta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFCSTFiltroEsportazioneFatturePassive()
	{
		_Mode = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		_Context = "CST.FILTROESPORTA.FATPASS";
		_Mode = ((Page)this).Request.QueryString["MODE"] ?? "";
		if (Operators.CompareString(_Mode, "INVIO", false) != 0)
		{
			_Title = base.Translator.Translate("XXX", "Filtro per Esportazione Fatture Passive", new string[0]);
		}
		else
		{
			_Title = base.Translator.Translate("XXX", "Filtro per invio Fatture Passive", new string[0]);
		}
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
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
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
			else if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataFattura.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(Vettore.ObjValue.ToString(), "", false) == 0))
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(_Mode, "INVIO", false) != 0)
				{
					Riesporta.Visible = true;
					lblRiesporta.Visible = true;
				}
				else
				{
					Riesporta.Visible = false;
					lblRiesporta.Visible = false;
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_Mode, "INVIO", false) != 0)
			{
				val2 = SaveData_EsportazioneFatture(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0067;
				}
				val = val2;
			}
			else
			{
				val2 = SaveData_InvioFatture(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0067;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0067:
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

	protected FXRETURN SaveData_EsportazioneFatture(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Invalid comparison between Unknown and I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Invalid comparison between Unknown and I4
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
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
			text2 = "SELECT IDFATTURA FROM Fatture_Passive_Testata WHERE Numero > 0  ";
			if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "0", false) != 0) & ((Operators.CompareString(ANumero.ObjValue.ToString(), "0", false) == 0) | (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) == 0)))
			{
				string text3 = text2;
				DBConnection dbConn = base.DbConn;
				string text4 = DaNumero.ObjValue.ToString();
				text2 = text3 + "AND IDFATTURA = " + dbConn.SQLFormatNumber(ref text4) + " ";
			}
			else if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "0", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "0", false) != 0) & (Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) != 0))
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
			if (Operators.CompareString(Vettore.ObjValue.ToString(), "", false) != 0)
			{
				text2 = text2 + "AND TRASPORTATORE = " + base.DbConn.SQLFormatString(Vettore.ObjValue.ToString()) + " ";
			}
			text2 = ((!((CheckBox)Riesporta).Checked) ? (text2 + "AND CONTABILIZZATA ='N'") : (text2 + "AND CONTABILIZZATA IN ('N','S')"));
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessuna fattura trovata per la ricerca");
			}
			else
			{
				text2 = "";
				foreach (DataRow row in dataTable.Rows)
				{
					text2 += "UPDATE Fatture_Passive_Testata SET CONTABILIZZATA = 'X', DataContabilizzazione = NULL, ErroreContabilizzazione = NULL ";
					string text7 = text2;
					DBConnection dbConn4 = base.DbConn;
					string text4 = row["IDFATTURA"].ToString();
					text2 = text7 + "WHERE IDFATTURA = " + dbConn4.SQLFormatNumber(ref text4) + ";";
				}
				text2 += "INSERT INTO  DelsyTasks_Triggers (Istanza, Task, Applicazione) VALUES ('FATT','EXPFATPAS','DSI')";
				val2 = base.DbConn.SqlExec(text2, ref rsMess);
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

	protected FXRETURN SaveData_InvioFatture(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Invalid comparison between Unknown and I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Invalid comparison between Unknown and I4
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "";
			DataTable dataTable = null;
			text = "SELECT IDFATTURA FROM Fatture_Passive_Testata WHERE Numero > 0  ";
			if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "0", false) != 0) & ((Operators.CompareString(ANumero.ObjValue.ToString(), "0", false) == 0) | (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) == 0)))
			{
				string text2 = text;
				DBConnection dbConn = base.DbConn;
				string text3 = DaNumero.ObjValue.ToString();
				text = text2 + "AND IDFATTURA = " + dbConn.SQLFormatNumber(ref text3) + " ";
			}
			else if ((Operators.CompareString(DaNumero.ObjValue.ToString(), "0", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "0", false) != 0) & (Operators.CompareString(DaNumero.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(ANumero.ObjValue.ToString(), "", false) != 0))
			{
				string text4 = text;
				DBConnection dbConn2 = base.DbConn;
				string text3 = DaNumero.ObjValue.ToString();
				text = text4 + "AND IDFATTURA >= " + dbConn2.SQLFormatNumber(ref text3) + " ";
				string text5 = text;
				DBConnection dbConn3 = base.DbConn;
				text3 = ANumero.ObjValue.ToString();
				text = text5 + "AND IDFATTURA <= " + dbConn3.SQLFormatNumber(ref text3) + " ";
			}
			if (Operators.CompareString(DataFattura.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND DATA = " + base.DbConn.SQLFormatDate((eTipoData)1, DataFattura.ObjValue.ToString()) + " ";
			}
			if (Operators.CompareString(Vettore.ObjValue.ToString(), "", false) != 0)
			{
				text = text + "AND TRASPORTATORE = " + base.DbConn.SQLFormatString(Vettore.ObjValue.ToString()) + " ";
			}
			text += "AND CONTABILIZZATA ='J'";
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (dataTable.Rows.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessuna fattura trovata per la ricerca");
			}
			else
			{
				text = "";
				foreach (DataRow row in dataTable.Rows)
				{
					text += "UPDATE CST_JDE_ESF4301Z1 SET HST_TAG = '' ";
					string text6 = text;
					DBConnection dbConn4 = base.DbConn;
					string text3 = row["IDFATTURA"].ToString();
					text = text6 + "WHERE IDFATTURA = " + dbConn4.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE CST_JDE_ESF4311Z1 SET HST_TAG = '' ";
					string text7 = text;
					DBConnection dbConn5 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text7 + "WHERE IDFATTURA = " + dbConn5.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE CST_JDE_ESF47071 SET HST_TAG = '' ";
					string text8 = text;
					DBConnection dbConn6 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text8 + "WHERE IDFATTURA = " + dbConn6.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE CST_JDE_ESF47072 SET HST_TAG = '' ";
					string text9 = text;
					DBConnection dbConn7 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text9 + "WHERE IDFATTURA = " + dbConn7.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE CST_JDE_ESF56DDT SET HST_TAG = '' ";
					string text10 = text;
					DBConnection dbConn8 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text10 + "WHERE IDFATTURA = " + dbConn8.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE CST_JDE_ESF56VIAGG SET HST_TAG = '' ";
					string text11 = text;
					DBConnection dbConn9 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text11 + "WHERE IDFATTURA = " + dbConn9.SQLFormatNumber(ref text3) + ";\r\n";
					text += "UPDATE Fatture_Passive_Testata SET Contabilizzata = 'S' ";
					string text12 = text;
					DBConnection dbConn10 = base.DbConn;
					text3 = row["IDFATTURA"].ToString();
					text = text12 + "WHERE IDFATTURA = " + dbConn10.SQLFormatNumber(ref text3) + ";\r\n";
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
}
