using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFCSTViaggi_Transporeon : WFIDBPage
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

	[field: AccessedThroughProperty("lblInfo")]
	protected virtual IboWebLabel lblInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdViaggio")]
	protected virtual IboWebTextBox txtIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMotricePianificata")]
	protected virtual IboWebTextBox txtMotricePianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtVettore")]
	protected virtual IboWebTextBox txtVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza")]
	protected virtual IboWebTextBox txtPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataPartenzaPianificata")]
	protected virtual IboWebTextBox txtDataPartenzaPianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Aggiorna")]
	protected new virtual IboWebTextBox Aggiorna
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
		_Context = "DM.DOC.VIAGGI";
		_objFunctionArguments.Name = "MODIFICA";
		_Title = base.Translator.Translate("XXX", "Conferma Ritrasmissione", new string[0]);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(txtVettore.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Vettore non valorizzato");
				}
				else if (Operators.CompareString(txtMotricePianificata.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Motrice non valorizzato");
				}
				else if (Operators.CompareString(txtPCSPartenza.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "PCS Partenza non valorizzato");
				}
				else if (Operators.CompareString(txtDataPartenzaPianificata.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Data Partenza non valorizzato");
				}
				else
				{
					string text2 = "";
					DataTable dataTable = null;
					DBConnection dbConn = base.DbConn;
					string text3 = txtIdViaggio.ObjValue.ToString();
					text2 = "SELECT * FROM CST_VIAGGI_TRANSPOREON WHERE IDVIAGGIO = " + dbConn.SQLFormatNumber(ref text3);
					val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (dataTable.Rows.Count <= 0)
						{
							btnConferma_Click(btnConferma, new EventArgs());
							goto IL_0219;
						}
						if (Operators.CompareString(dataTable.Rows[0]["STATOTRASMISSIONE"].ToString(), "N", false) != 0)
						{
							lblInfo.ObjValue = TranslateMessage("XXX", "Confermare invio a Transporeon?");
							Aggiorna.Text = "S";
							goto IL_0219;
						}
						rsMess = TranslateMessage("XXX", "Trasmissione precedente non completata");
					}
				}
			}
			goto end_IL_000b;
			IL_0219:
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Invalid comparison between Unknown and I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text2 = "";
			if (Operators.CompareString(Aggiorna.Text, "S", false) == 0)
			{
				text2 = "UPDATE  CST_VIAGGI_TRANSPOREON SET STATOTRASMISSIONE = 'N',";
				text2 += "STATOTRANSPOREON = (CASE WHEN STATOTRANSPOREON = 'D' THEN 'N' ELSE 'M' end) ,";
				text2 += "STATOACCETTAZIONE = (CASE WHEN STATOACCETTAZIONE = 'A' THEN 'A' ELSE 'X' END),";
				text2 += "DATARICHIESTA = GETDATE(),DATATRASMISSIONE = NULL,ERRORETRASMISSIONE = NULL, ERRORERICEZIONE = NULL, ";
				text2 += "DECLINEREASON = NULL, SELECTEDCARRIER = NULL,PRICE = NULL, CURRENCY= NULL,";
				text2 += "BOOKING_SLOTS = NULL, BOOKING_FROM = NULL, BOOKING_TO = NULL, ";
				text2 += "AUTISTANOME = NULL, AUTISTATELEFONO = NULL,TARGA = NULL, COMMENTI = NULL, ";
				text2 = text2 + "UTEAGG= " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 += "DATAGG = GETDATE() ";
				string text3 = text2;
				DBConnection dbConn = base.DbConn;
				string text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text3 + "WHERE IDVIAGGIO = " + dbConn.SQLFormatNumber(ref text4) + ";";
				text2 += "UPDATE CST_SPEDIZIONI_TRANSPOREON SET DATARICHIESTA = GETDATE(), ";
				text2 += "STATOTRANSPOREON = (CASE WHEN STATOTRANSPOREON = 'D' THEN 'N' ELSE 'M' END) ,";
				text2 += "DATATRASMISSIONE = NULL,ERRORETRASMISSIONE = NULL, ERRORERICEZIONE = NULL, ";
				text2 = text2 + "UTEAGG= " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 += "DATAGG = GETDATE() ";
				string text5 = text2;
				DBConnection dbConn2 = base.DbConn;
				text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text5 + "WHERE IDVIAGGIO = " + dbConn2.SQLFormatNumber(ref text4) + ";";
				text2 += "INSERT INTO CST_SPEDIZIONI_TRANSPOREON (IDVIAGGIO,UNIBOL,UTEINS,UTEAGG) SELECT IDVIAGGIO,UNIBOL,";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
				string text6 = text2;
				DBConnection dbConn3 = base.DbConn;
				text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text6 + "FROM SPEDIZIONI  WHERE IDVIAGGIO = " + dbConn3.SQLFormatNumber(ref text4) + " ";
				string text7 = text2;
				DBConnection dbConn4 = base.DbConn;
				text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text7 + "AND NOT EXISTS (SELECT UNIBOL FROM CST_SPEDIZIONI_TRANSPOREON WHERE IDVIAGGIO = " + dbConn4.SQLFormatNumber(ref text4) + ");";
			}
			else
			{
				text2 = "INSERT INTO CST_VIAGGI_TRANSPOREON (IDVIAGGIO,UTEINS,UTEAGG) VALUES (";
				string text8 = text2;
				DBConnection dbConn5 = base.DbConn;
				string text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text8 + dbConn5.SQLFormatNumber(ref text4) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ");";
				text2 += "INSERT INTO CST_SPEDIZIONI_TRANSPOREON (IDVIAGGIO,UNIBOL,UTEINS,UTEAGG) SELECT IDVIAGGIO,UNIBOL,";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
				text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
				string text9 = text2;
				DBConnection dbConn6 = base.DbConn;
				text4 = txtIdViaggio.ObjValue.ToString();
				text2 = text9 + "FROM SPEDIZIONI WHERE IDVIAGGIO = " + dbConn6.SQLFormatNumber(ref text4) + ";";
			}
			base.DbConn.BeginTransaction();
			val2 = base.DbConn.SqlExec(text2, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				base.DbConn.CommitTransaction();
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
			base.DbConn.RollbackTransaction();
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

	protected override void ErroreCaricamento(bool bWithReturnToCaller, string sMess)
	{
		string text = "";
		text = TranslateMessage("XXX", "ATTENZIONE!");
		if (bWithReturnToCaller)
		{
			WriteErrorMessageWithReturnToCaller("", text, sMess);
		}
		else
		{
			WriteErrorMessage(text + "<br /><br />" + sMess);
		}
	}
}
