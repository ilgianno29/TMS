using System;
using System.Data;
using Incasbo.CustomApi.Gdo;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFICustom;

public class CustomProxyApiFunctions : IIboProxyApiFunctions
{
	public FXRETURN CallApiFunction(string sFunctionName, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref bool rbReturnToCaller, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Invalid comparison between Unknown and I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Invalid comparison between Unknown and I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Invalid comparison between Unknown and I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Invalid comparison between Unknown and I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Invalid comparison between Unknown and I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			rsMess = "";
			rsWarning = "";
			rbReturnToCaller = true;
			if (Operators.CompareString(sFunctionName, "Example".ToUpper(), false) != 0)
			{
				switch (sFunctionName)
				{
				case "VIAGGI.CALCOLOPALLETSAGOME":
				{
					int num7 = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
					int num8 = 0;
					while (num8 <= num7)
					{
						string idViaggio2 = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(num8).ToString();
						val2 = Viaggio_WMSCalcolaPalletESagome.RunProc(rObjPage.CreateApiContext(), idViaggio2, ref rsMess);
						if ((int)val2 <= 0)
						{
							num8 = checked(num8 + 1);
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					break;
				}
				case "ANNULLATESI":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = CancellaInvioTesi(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0005;
				case "ANNULLATRANSPOREON":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = CancellaInvioTransporeon(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0005;
				case "BESTCARRIERTRANSPOREON":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						val2 = BestCarrierTransporeon(ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0005;
				case "SPEDATT":
				{
					int num3 = checked(robjFunctionArguments.Data.Item("UniBol").FieldValuesCount - 1);
					int num4 = 0;
					while (num4 <= num3)
					{
						string unibol = robjFunctionArguments.Data.Item("UniBol").get_FieldValues(num4).ToString();
						val2 = Spedizione_Attenziona.RunProc(rObjPage.CreateApiContext(), unibol, ref rsMess);
						if ((int)val2 <= 0)
						{
							num4 = checked(num4 + 1);
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					break;
				}
				case "ANNULLASPUNTA":
				{
					int num5 = checked(robjFunctionArguments.Data.Item("ID").FieldValuesCount - 1);
					int num6 = 0;
					while (num6 <= num5)
					{
						int idDett = Conversions.ToInteger(robjFunctionArguments.Data.Item("ID").get_FieldValues(num6));
						val2 = AnnullaSpunta.RunProc(rObjPage.CreateApiContext(), idDett, ref rsMess);
						if ((int)val2 <= 0)
						{
							num6 = checked(num6 + 1);
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					break;
				}
				case "CHECKDETCONT":
					if (robjFunctionArguments.Data.Count == 0)
					{
						rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Nessun record selezionato", new string[0]);
					}
					else
					{
						string unibol2 = robjFunctionArguments.Data.Item("UniBol").get_FieldValues(0).ToString();
						string tipologia = robjFunctionArguments.Data.Item("Tipologia").get_FieldValues(0).ToString();
						string voce = robjFunctionArguments.Data.Item("Voce").get_FieldValues(0).ToString();
						val2 = Determinazione_Contabile.RunProc(rObjPage.CreateApiContext(), unibol2, "", "", "", "", voce, tipologia, "I", ref rsWarning, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
					}
					goto end_IL_0005;
				case "VIAGGI.PARTENZA_PARZIALE":
				{
					int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
					int num2 = 0;
					while (num2 <= num)
					{
						string idViaggio = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(num2).ToString();
						val2 = Viaggio_PartenzaPaziale.RunProc(rObjPage.CreateApiContext(), idViaggio, ref rsMess);
						if ((int)val2 <= 0)
						{
							num2 = checked(num2 + 1);
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					break;
				}
				default:
					rsMess = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Funzione non riconosciuta", new string[1] { rsMess });
					goto end_IL_0005;
				}
			}
			val = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	FXRETURN IIboProxyApiFunctions.CallApiFunction(string sFunctionName, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref bool rbReturnToCaller, ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CallApiFunction
		return this.CallApiFunction(sFunctionName, ref robjFunctionArguments, ref rObjSessionEnvironment, ref rObjPage, ref rsWarning, ref rbReturnToCaller, ref rsMess);
	}

	private FXRETURN CancellaInvioTransporeon(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Invalid comparison between Unknown and I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					text = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(num2).ToString();
					string text3 = "";
					DataTable dataTable = null;
					text3 = "SELECT * FROM CST_VIAGGI_TRANSPOREON WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text);
					val2 = rObjSessionEnvironment.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					if (dataTable.Rows.Count == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Viaggio {0} non ancora inviato a Transporeon", new string[1] { text }) + "\r\n";
					}
					else if (Operators.CompareString(dataTable.Rows[0]["STATOTRASMISSIONE"].ToString(), "N", false) == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Trasmissione per il Viaggio {0} non ancora completata", new string[1] { text }) + "\r\n";
					}
					else if (Operators.CompareString(dataTable.Rows[0]["STATOTRANSPOREON"].ToString(), "D", false) == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Cancellazione per il Viaggio {0} già trasmessa a Transporeon", new string[1] { text }) + "\r\n";
					}
					else
					{
						text3 = "UPDATE  CST_VIAGGI_TRANSPOREON SET STATOTRASMISSIONE = 'N',STATOTRANSPOREON = 'D', DATARICHIESTA = GETDATE(), DATATRASMISSIONE = NULL,";
						text3 = text3 + "UTEAGG= " + rObjSessionEnvironment.DbConn.SQLFormatString(rObjSessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
						text3 += "DATAGG = GETDATE() ";
						text3 = text3 + "WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text) + ";";
						text3 = text3 + "DELETE FROM CST_SPEDIZIONI_TRANSPOREON WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text) + ";";
						rObjSessionEnvironment.DbConn.BeginTransaction();
						val2 = rObjSessionEnvironment.DbConn.SqlExec(text3, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						rObjSessionEnvironment.DbConn.CommitTransaction();
					}
					num2 = checked(num2 + 1);
					continue;
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					rsWarning = text2;
				}
				else
				{
					rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Annullamento effettuato correttamente", new string[0]);
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.DbConn.RollbackTransaction();
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN BestCarrierTransporeon(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Invalid comparison between Unknown and I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Invalid comparison between Unknown and I4
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Invalid comparison between Unknown and I4
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			string text3 = rObjSessionEnvironment.ApplicationDefault.Custom.Trasportatore_Dummy_Default();
			string text4 = rObjSessionEnvironment.ApplicationDefault.Custom.Voce_BestCarrier_Default();
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					string text5 = "";
					text = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(num2).ToString();
					string text6 = "";
					object obj = null;
					text5 = "SELECT VETTORE FROM VIAGGI WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatString(text);
					val2 = rObjSessionEnvironment.DbConn.DoSql(text5, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					text6 = obj.ToString();
					if (Operators.CompareString(text6, text3, false) != 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Viaggio {0} non assegnato con modalità Best Carrier", new string[1] { text }) + "\r\n";
					}
					else
					{
						DataTable dataTable = null;
						text5 = "SELECT * FROM CST_VIAGGI_TRANSPOREON WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text);
						val2 = rObjSessionEnvironment.DbConn.OpenDataTable(text5, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						string text7 = "";
						if (dataTable.Rows.Count == 0)
						{
							text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Viaggio {0} non ancora inviato a Transporeon", new string[1] { text }) + "\r\n";
						}
						else
						{
							text7 = dataTable.Rows[0]["SELECTEDCARRIER"].ToString();
							if (Operators.CompareString(dataTable.Rows[0]["STATOACCETTAZIONE"].ToString(), "A", false) != 0)
							{
								text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Esito accettazione per il Viaggio {0} non ricevuto da Transporeon", new string[1] { text }) + "\r\n";
							}
							else if (Operators.CompareString(dataTable.Rows[0]["PRICE"].ToString(), "", false) == 0)
							{
								text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Prezzo per il Viaggio {0} non valorizzato", new string[1] { text }) + "\r\n";
							}
							else if (decimal.Compare(Conversions.ToDecimal(dataTable.Rows[0]["PRICE"].ToString()), 0m) == 0)
							{
								text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Prezzo per il Viaggio {0} valorizzato a 0", new string[1] { text }) + "\r\n";
							}
							else if (Operators.CompareString(text7, "", false) == 0)
							{
								text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Trasportatore per il Viaggio {0} non valorizzato", new string[1] { text }) + "\r\n";
							}
							else
							{
								text5 = "SELECT COUNT(*) FROM TRASPORTATORI WHERE CODICE = " + rObjSessionEnvironment.DbConn.SQLFormatString(text7);
								val2 = rObjSessionEnvironment.DbConn.DoSql(text5, ref obj, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
									break;
								}
								if (Conversions.ToInteger(obj) == 0)
								{
									text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Trasportatore {0} per il Viaggio {1} non presente in anagrafica", new string[2] { text7, text }) + "\r\n";
								}
								else
								{
									text5 = "DELETE FROM VIAGGI_COSTI WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatString(text) + " ";
									text5 = text5 + "AND TRASPORTATORE = " + rObjSessionEnvironment.DbConn.SQLFormatString(text6) + ";";
									text5 = text5 + "UPDATE VIAGGI SET VETTORE = " + rObjSessionEnvironment.DbConn.SQLFormatString(text7) + ", BLOCCACOSTI = 'S' ";
									text5 = text5 + " WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatString(text) + ";";
									text5 += "INSERT INTO VIAGGI_COSTI (IdViaggio,IdRaggruppamento, Voce, Trasportatore, TipoCalcolo, CampoCalcolo, UtenteForzatura, ";
									text5 += "QuantitaOriginale, QuantitaArrotondata, QuantitaTassata,ImportoOriginale,ImportoArrotondato, ImportoUnitario) VALUES (";
									text5 = text5 + rObjSessionEnvironment.DbConn.SQLFormatString(text) + ",";
									text5 = text5 + rObjSessionEnvironment.DbConn.SQLFormatString(text) + ",";
									text5 = text5 + rObjSessionEnvironment.DbConn.SQLFormatString(text4) + ",";
									text5 = text5 + rObjSessionEnvironment.DbConn.SQLFormatString(text7) + ",";
									text5 += "'MAN','FORFAIT','TRANSPOREON',1,1,1,";
									string text8 = text5;
									DBConnection dbConn = rObjSessionEnvironment.DbConn;
									string text9 = dataTable.Rows[0]["PRICE"].ToString();
									text5 = text8 + dbConn.SQLFormatNumber(ref text9) + ",";
									string text10 = text5;
									DBConnection dbConn2 = rObjSessionEnvironment.DbConn;
									text9 = dataTable.Rows[0]["PRICE"].ToString();
									text5 = text10 + dbConn2.SQLFormatNumber(ref text9) + ",";
									string text11 = text5;
									DBConnection dbConn3 = rObjSessionEnvironment.DbConn;
									text9 = dataTable.Rows[0]["PRICE"].ToString();
									text5 = text11 + dbConn3.SQLFormatNumber(ref text9) + ");";
									rObjSessionEnvironment.DbConn.BeginTransaction();
									val2 = rObjSessionEnvironment.DbConn.SqlExec(text5, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
										break;
									}
									rObjSessionEnvironment.DbConn.CommitTransaction();
								}
							}
						}
					}
					num2 = checked(num2 + 1);
					continue;
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					rsWarning = text2;
				}
				else
				{
					rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Annullamento effettuato correttamente", new string[0]);
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.DbConn.RollbackTransaction();
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN CancellaInvioTesi(ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage rObjPage, ref string rsWarning, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Invalid comparison between Unknown and I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			rsWarning = "";
			rObjSessionEnvironment.CallStackHandler.CallStackAdd();
			int num = checked(robjFunctionArguments.Data.Item("IdViaggio").FieldValuesCount - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					text = robjFunctionArguments.Data.Item("IdViaggio").get_FieldValues(num2).ToString();
					string text3 = "";
					DataTable dataTable = null;
					text3 = "SELECT * FROM CST_VIAGGI_TESI WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text);
					val2 = rObjSessionEnvironment.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					if (dataTable.Rows.Count == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Viaggio {0} non ancora inviato a Tesi", new string[1] { text }) + "\r\n";
					}
					else if (Operators.CompareString(dataTable.Rows[0]["STATOTRASMISSIONE"].ToString(), "N", false) == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Trasmissione per il Viaggio {0} non ancora completata", new string[1] { text }) + "\r\n";
					}
					else if (Operators.CompareString(dataTable.Rows[0]["STATOTESI"].ToString(), "D", false) == 0)
					{
						text2 = text2 + rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Cancellazione per il Viaggio {0} già trasmessa a Tesi", new string[1] { text }) + "\r\n";
					}
					else
					{
						text3 = "UPDATE  CST_VIAGGI_TESI SET STATOTRASMISSIONE = 'N', STATOTESI = 'D', DATARICHIESTA = GETDATE(), DATATRASMISSIONE = NULL,";
						text3 = text3 + "UTEAGG= " + rObjSessionEnvironment.DbConn.SQLFormatString(rObjSessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
						text3 += "DATAGG = GETDATE() ";
						text3 = text3 + "WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text) + ";";
						text3 = text3 + "DELETE FROM CST_SPEDIZIONI_TESI WHERE IDVIAGGIO = " + rObjSessionEnvironment.DbConn.SQLFormatNumber(ref text) + ";";
						rObjSessionEnvironment.DbConn.BeginTransaction();
						val2 = rObjSessionEnvironment.DbConn.SqlExec(text3, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						rObjSessionEnvironment.DbConn.CommitTransaction();
					}
					num2 = checked(num2 + 1);
					continue;
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					rsWarning = text2;
				}
				else
				{
					rsWarning = rObjSessionEnvironment.Translator.TranslateMessage("XXX", "Annullamento effettuato correttamente", new string[0]);
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = rObjSessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			rObjSessionEnvironment.DbConn.RollbackTransaction();
			rObjSessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
