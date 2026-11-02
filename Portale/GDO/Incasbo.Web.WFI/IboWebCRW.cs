using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebCRW : IboCRW
{
	protected IboSessionEnvironment _SessionEnv;

	public IboWebCRW(ref IboSessionEnvironment robjSessionEnv)
		: base(ref Incasbo.Compat.RefBox.Of(robjSessionEnv.CreateApiContext()))
	{
		IboSessionEnvironment sessionEnv = robjSessionEnv;
		_SessionEnv = sessionEnv;
	}

	public override FXRETURN CrystalReportToFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, IboExportFormatType Formato, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			base._objCallStackHandler.CallStackAdd();
			rsMess = "";
			val = ((IboCRW)this).CrystalReportToFile(vsNomeReport, vsNomeFileExport, vsSelectionFormula, vsHumanReadableSelectionFormula, ReportParams, Formato, ref rsNomeFileCompletoGenerato, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if ((int)_SessionEnv.AddFileToDelete(rsNomeFileCompletoGenerato, ref rsMess) <= 0)
			{
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = base._objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			base._objCallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN CrystalReportToPDF(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, ref string rsNomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			base._objCallStackHandler.CallStackAdd();
			rsMess = "";
			val = ((IboCRW)this).CrystalReportToPDF(vsNomeReport, vsNomeFileExport, vsSelectionFormula, vsHumanReadableSelectionFormula, ReportParams, ref rsNomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if ((int)_SessionEnv.AddFileToDelete(rsNomeFileCompletoGenerato, ref rsMess) <= 0)
			{
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = base._objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			base._objCallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN ViewToCsvFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, string Title, string SubTitle, bool IncludeColumnsName, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			base._objCallStackHandler.CallStackAdd();
			rsMess = "";
			val = ((IboCRW)this).ViewToCsvFile(vsNomeReport, vsNomeFileExport, vsSelectionFormula, vsHumanReadableSelectionFormula, Title, SubTitle, IncludeColumnsName, ref rsNomeFileCompletoGenerato, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if ((int)_SessionEnv.AddFileToDelete(rsNomeFileCompletoGenerato, ref rsMess) <= 0)
			{
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = base._objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			base._objCallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public FXRETURN CrystalReportToFile(string sNomRif, string sUtente, FunctionArguments objFunctionArguments, DataTable dtDati, string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string sHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, IboExportFormatType Formato, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between Unknown and I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Invalid comparison between Unknown and I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Invalid comparison between Unknown and I4
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff0: Invalid comparison between Unknown and I4
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Invalid comparison between Unknown and I4
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Invalid comparison between Unknown and I4
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Invalid comparison between Unknown and I4
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Invalid comparison between Unknown and I4
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		string text = "";
		ReportDocument val3 = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			base._objCallStackHandler.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(sNomRif, "", false) != 0)
			{
				text = "SELECT T2.*, T1.ReportSelectionFormula ReportSelectionFormula2 FROM WFI_ALLGRD_TABREP T1 INNER JOIN WFI_TABREP T2 ";
				text += "ON T1.NOMREP=T2.NOMREP ";
				text += "WHERE ";
				text = text + "T1.NomRif = " + base._dbMain.SQLFormatString(sNomRif) + " ";
				text = text + "AND T1.Utente = " + base._dbMain.SQLFormatString(sUtente) + " ";
				text = text + "AND T2.NOMREP = " + base._dbMain.SQLFormatString(vsNomeReport);
			}
			else
			{
				text = "SELECT * FROM WFI_TABREP ";
				text += "WHERE ";
				text = text + "NOMREP = " + base._dbMain.SQLFormatString(vsNomeReport);
			}
			val = base._dbMain.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (dataTable.Rows.Count == 0)
				{
					rsMess = base._ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", new string[1] { vsNomeReport });
				}
				else
				{
					if (Operators.CompareString(dataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						base._PercorsoStampeConfigurato = dataTable.Rows[0]["Percorso"].ToString();
					}
					if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "S", false) == 0)
					{
						if (objFunctionArguments.FieldValuesCount == 1)
						{
							goto IL_0272;
						}
						rsMess = base._ObjTranslator.TranslateMessage("XXX", "E' necessario selezionare un solo record", new string[0]);
					}
					else
					{
						if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "M", false) != 0 || objFunctionArguments.FieldValuesCount != 0)
						{
							goto IL_0272;
						}
						rsMess = base._ObjTranslator.TranslateMessage("XXX", "E' necessario selezionare almeno un record", new string[0]);
					}
				}
			}
			goto end_IL_001b;
			IL_0272:
			text = "SELECT * ";
			text += "FROM VW_WFI_StampeAutomatiche ";
			text += "WHERE NomRep IN (<%NomeReport%>, '*ALL') ";
			text += "AND Utente IN (<%Utente%>, <%Gruppo%>, <%Organizzazione%>, 'XXX') ";
			text += "ORDER BY PESO DESC";
			text = text.Replace("<%NomeReport%>", base._dbMain.SQLFormatString(vsNomeReport));
			text = text.Replace("<%Utente%>", base._dbMain.SQLFormatString(base._ApiContext.User));
			text = text.Replace("<%Gruppo%>", base._dbMain.SQLFormatString(base._ApiContext.Group));
			text = text.Replace("<%Organizzazione%>", base._dbMain.SQLFormatString(base._ApiContext.Organization));
			val = base._dbMain.OpenDataTable(text, ref dataTable2, ref rsMess);
			if ((int)val <= 0)
			{
				string text3 = "";
				if (Operators.CompareString(base._PercorsoStampeConfigurato, "", false) != 0)
				{
					text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
				}
				else
				{
					text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
					if (!File.Exists(text3))
					{
						text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
					}
				}
				if (!File.Exists(text3))
				{
					rsMess = base._ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", new string[1] { vsNomeReport });
				}
				else
				{
					val3 = new ReportDocument();
					val3.FileName = text3;
					val3.SetDatabaseLogon(base._CRWConfig.DB_Username, base._CRWConfig.DB_Password, base._CRWConfig.DB_Server, base._CRWConfig.DB_Database);
					foreach (Table item in (SCRCollection)val3.Database.Tables)
					{
						Table val4 = item;
						if ((int)base._dbMain.ServerType == 1)
						{
							val4.LogOnInfo.ConnectionInfo.DatabaseName = "";
						}
						else
						{
							val4.LogOnInfo.ConnectionInfo.DatabaseName = base._CRWConfig.DB_Database;
						}
						val4.LogOnInfo.ConnectionInfo.ServerName = base._CRWConfig.DB_Server;
						val4.LogOnInfo.ConnectionInfo.Password = base._CRWConfig.DB_Password;
						val4.LogOnInfo.ConnectionInfo.UserID = base._CRWConfig.DB_Username;
						val4.LogOnInfo.ConnectionInfo.IntegratedSecurity = base._CRWConfig.DB_UseIntegratedSecurity;
						val4.ApplyLogOnInfo(val4.LogOnInfo);
						if (val4.Location.LastIndexOf(".") >= 0)
						{
							val4.Location = val4.Location.Substring(checked(val4.Location.LastIndexOf(".") + 1));
						}
					}
					val3.ReportOptions.EnableSaveDataWithReport = false;
					foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)val3.Subreports)
					{
						ReportDocument val5 = item2;
						val5.SetDatabaseLogon(base._CRWConfig.DB_Username, base._CRWConfig.DB_Password, base._CRWConfig.DB_Server, base._CRWConfig.DB_Database);
						foreach (Table item3 in (SCRCollection)val5.Database.Tables)
						{
							Table val6 = item3;
							if ((int)base._dbMain.ServerType == 1)
							{
								val6.LogOnInfo.ConnectionInfo.DatabaseName = "";
							}
							else
							{
								val6.LogOnInfo.ConnectionInfo.DatabaseName = base._CRWConfig.DB_Database;
							}
							val6.LogOnInfo.ConnectionInfo.ServerName = base._CRWConfig.DB_Server;
							val6.LogOnInfo.ConnectionInfo.Password = base._CRWConfig.DB_Password;
							val6.LogOnInfo.ConnectionInfo.UserID = base._CRWConfig.DB_Username;
							val6.LogOnInfo.ConnectionInfo.IntegratedSecurity = base._CRWConfig.DB_UseIntegratedSecurity;
							val6.ApplyLogOnInfo(val6.LogOnInfo);
							if (val6.Location.LastIndexOf(".") >= 0)
							{
								val6.Location = val6.Location.Substring(checked(val6.Location.LastIndexOf(".") + 1));
							}
						}
					}
					if (ReportParams != null)
					{
						base._ReportParameters = ReportParams;
					}
					this.SetReportParam(ref val3, "ReportParams_Caption", dataTable.Rows[0]["CapRep"].ToString());
					this.SetReportParam(ref val3, "ReportParams_HumanReadable", sHumanReadableSelectionFormula);
					this.SetReportParam(ref val3, "ReportParams_Sistema", base._CRWConfig.DB_Sistema);
					this.SetReportParam(ref val3, "ReportParams_User", base._ApiContext.User);
					if (base._ReportParameters.Count > 0)
					{
						foreach (KeyValuePair<string, object> reportParameter in base._ReportParameters)
						{
							this.SetReportParam(ref val3, reportParameter.Key, reportParameter.Value.ToString());
						}
					}
					string text7;
					checked
					{
						if (Operators.CompareString(vsSelectionFormula, "", false) == 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ReportSelectionFormula"])))
						{
							int fieldValuesCount = objFunctionArguments.Data[0].FieldValuesCount;
							int count = objFunctionArguments.Data.Count;
							vsSelectionFormula = "(";
							int i = default(int);
							for (; i < fieldValuesCount; i++)
							{
								if (i > 0)
								{
									vsSelectionFormula += " OR ";
								}
								vsSelectionFormula += "(";
								vsSelectionFormula = ((Operators.CompareString(dataTable.Rows[0]["ReportSelectionFormula2"].ToString(), "", false) == 0) ? (vsSelectionFormula + dataTable.Rows[0]["ReportSelectionFormula"].ToString().ToUpper()) : (vsSelectionFormula + dataTable.Rows[0]["ReportSelectionFormula2"].ToString().ToUpper()));
								int j = 0;
								string text4 = "";
								for (; j < count; j++)
								{
									if (Operators.CompareString(text4, "", false) != 0)
									{
										text4 += " AND ";
									}
									text4 = text4 + objFunctionArguments.Data[j].FieldName.ToUpper() + " = ";
									text2 = objFunctionArguments.Data[j].FieldName.ToUpper();
									switch (objFunctionArguments.Data[j].FieldType)
									{
									case "String":
										text2 = "\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\"";
										text4 += base._dbMain.SQLFormatString(objFunctionArguments.Data[j].get_FieldValues(i).ToString());
										break;
									case "Int16":
									case "Int32":
									case "Int64":
									case "Numeric":
									case "Decimal":
									case "Single":
									case "Double":
									{
										text2 = "tonumber(\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\")";
										string text5 = text4;
										DBConnection dbMain = base._dbMain;
										string text6 = objFunctionArguments.Data[j].get_FieldValues(i).ToString();
										text4 = text5 + dbMain.SQLFormatNumber(ref text6);
										break;
									}
									case "DateTime":
										text2 = "";
										break;
									}
									vsSelectionFormula = vsSelectionFormula.Replace("<%" + objFunctionArguments.Data[j].FieldName.ToUpper() + "%>", text2);
									if (dtDati == null)
									{
										continue;
									}
									DataRow[] array = dtDati.Select(text4);
									if (array.Count() != 1)
									{
										continue;
									}
									foreach (DataColumn column in dtDati.Columns)
									{
										Type dataType = column.DataType;
										if (dataType == typeof(string))
										{
											text2 = "\"" + array[0][column.ColumnName].ToString() + "\"";
										}
										else if (dataType == typeof(short) || dataType == typeof(int) || dataType == typeof(long) || dataType == typeof(decimal) || dataType == typeof(float) || dataType == typeof(double))
										{
											text2 = "tonumber(\"" + array[0][column.ColumnName].ToString() + "\")";
										}
										else if (dataType == typeof(DateTime) || dataType == typeof(DateTime))
										{
											text2 = "";
										}
										vsSelectionFormula = vsSelectionFormula.Replace("<%" + column.ColumnName.ToUpper() + "%>", text2);
									}
								}
								vsSelectionFormula += ")";
							}
							vsSelectionFormula += ")";
						}
						val3.RecordSelectionFormula = vsSelectionFormula;
						text7 = "";
						DateTime now = DateAndTime.Now;
						text7 = base._ApiContext.ApplicationRootDir + base._ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
					}
					if ((int)Formato == 1)
					{
						val3.ExportToDisk((ExportFormatType)5, text7);
					}
					else if ((int)Formato == 2)
					{
						val3.ExportToDisk((ExportFormatType)4, text7);
					}
					else if ((int)Formato == 3)
					{
						val3.ExportToDisk((ExportFormatType)7, text7);
					}
					else if ((int)Formato == 4)
					{
						val3.ExportToDisk((ExportFormatType)3, text7);
					}
					else
					{
						val3.ExportToDisk((ExportFormatType)5, text7);
					}
					if ((int)_SessionEnv.AddFileToDelete(text7, ref rsMess) <= 0)
					{
						rsNomeFileCompletoGenerato = text7;
						val2 = (FXRETURN)0;
					}
				}
			}
			end_IL_001b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = base._objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			dtDati = null;
			if (val3 != null)
			{
				val3.Close();
				((Component)(object)val3).Dispose();
			}
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			if (dataTable2 != null)
			{
				dataTable2.Dispose();
				dataTable2 = null;
			}
			base._objCallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public FXRETURN CrystalReportToPDF(string sNomRif, string sUtente, FunctionArguments objFunctionArguments, DataTable dtDati, string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string sHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, string ForzaStampaAsincrona, ref string rsNomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_142c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Invalid comparison between Unknown and I4
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Invalid comparison between Unknown and I4
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Invalid comparison between Unknown and I4
		//IL_138f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1395: Invalid comparison between Unknown and I4
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Invalid comparison between Unknown and I4
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		string text = "";
		ReportDocument val3 = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			base._objCallStackHandler.CallStackAdd();
			rsMess = "";
			StampaAsincrona = false;
			if (Operators.CompareString(sNomRif, "", false) != 0)
			{
				text = "SELECT T2.*, T1.ReportSelectionFormula ReportSelectionFormula2 FROM WFI_ALLGRD_TABREP T1 INNER JOIN WFI_TABREP T2 ";
				text += "ON T1.NOMREP=T2.NOMREP ";
				text += "WHERE ";
				text = text + "T1.NomRif = " + base._dbMain.SQLFormatString(sNomRif) + " ";
				text = text + "AND T1.Utente = " + base._dbMain.SQLFormatString(sUtente) + " ";
				text = text + "AND T2.NOMREP = " + base._dbMain.SQLFormatString(vsNomeReport);
			}
			else
			{
				text = "SELECT * FROM WFI_TABREP ";
				text += "WHERE ";
				text = text + "NOMREP = " + base._dbMain.SQLFormatString(vsNomeReport);
			}
			val = base._dbMain.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (dataTable.Rows.Count == 0)
				{
					rsMess = base._ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", new string[1] { vsNomeReport });
				}
				else
				{
					if (Operators.CompareString(dataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						base._PercorsoStampeConfigurato = dataTable.Rows[0]["Percorso"].ToString();
					}
					if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "S", false) == 0)
					{
						if (objFunctionArguments.FieldValuesCount == 1)
						{
							goto IL_0276;
						}
						rsMess = base._ObjTranslator.TranslateMessage("XXX", "E' necessario selezionare un solo record", new string[0]);
					}
					else
					{
						if (Operators.CompareString(dataTable.Rows[0]["FiltroGriglia"].ToString(), "M", false) != 0 || objFunctionArguments.FieldValuesCount != 0)
						{
							goto IL_0276;
						}
						rsMess = base._ObjTranslator.TranslateMessage("XXX", "E' necessario selezionare almeno un record", new string[0]);
					}
				}
			}
			goto end_IL_001b;
			IL_0276:
			text = "SELECT * ";
			text += "FROM VW_WFI_StampeAutomatiche ";
			text += "WHERE NomRep IN (<%NomeReport%>, '*ALL') ";
			text += "AND Utente IN (<%Utente%>, <%Gruppo%>, <%Organizzazione%>, 'XXX') ";
			text += "ORDER BY PESO DESC";
			text = text.Replace("<%NomeReport%>", base._dbMain.SQLFormatString(vsNomeReport));
			text = text.Replace("<%Utente%>", base._dbMain.SQLFormatString(base._ApiContext.User));
			text = text.Replace("<%Gruppo%>", base._dbMain.SQLFormatString(base._ApiContext.Group));
			text = text.Replace("<%Organizzazione%>", base._dbMain.SQLFormatString(base._ApiContext.Organization));
			val = base._dbMain.OpenDataTable(text, ref dataTable2, ref rsMess);
			string text7;
			if ((int)val <= 0)
			{
				if (Operators.CompareString(ForzaStampaAsincrona, "S", false) == 0)
				{
					StampaAsincrona = true;
				}
				else if (Operators.CompareString(ForzaStampaAsincrona, "N", false) == 0)
				{
					StampaAsincrona = false;
				}
				else if (dataTable2.Rows.Count > 0 && Operators.CompareString(dataTable2.Rows[0]["StampaAsincrona"].ToString(), "S", false) == 0)
				{
					StampaAsincrona = true;
				}
				string text3 = "";
				if (Operators.CompareString(base._PercorsoStampeConfigurato, "", false) != 0)
				{
					text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
				}
				else
				{
					text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
					if (!File.Exists(text3))
					{
						text3 = (base._ApiContext.ApplicationRootDir + base._PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
					}
				}
				if (!File.Exists(text3))
				{
					rsMess = base._ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", new string[1] { vsNomeReport });
				}
				else
				{
					val3 = new ReportDocument();
					val3.FileName = text3;
					val3.SetDatabaseLogon(base._CRWConfig.DB_Username, base._CRWConfig.DB_Password, base._CRWConfig.DB_Server, base._CRWConfig.DB_Database);
					foreach (Table item in (SCRCollection)val3.Database.Tables)
					{
						Table val4 = item;
						if ((int)base._dbMain.ServerType == 1)
						{
							val4.LogOnInfo.ConnectionInfo.DatabaseName = "";
						}
						else
						{
							val4.LogOnInfo.ConnectionInfo.DatabaseName = base._CRWConfig.DB_Database;
						}
						val4.LogOnInfo.ConnectionInfo.ServerName = base._CRWConfig.DB_Server;
						val4.LogOnInfo.ConnectionInfo.Password = base._CRWConfig.DB_Password;
						val4.LogOnInfo.ConnectionInfo.UserID = base._CRWConfig.DB_Username;
						val4.LogOnInfo.ConnectionInfo.IntegratedSecurity = base._CRWConfig.DB_UseIntegratedSecurity;
						val4.ApplyLogOnInfo(val4.LogOnInfo);
						if (val4.Location.LastIndexOf(".") >= 0)
						{
							val4.Location = val4.Location.Substring(checked(val4.Location.LastIndexOf(".") + 1));
						}
					}
					val3.ReportOptions.EnableSaveDataWithReport = false;
					foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)val3.Subreports)
					{
						ReportDocument val5 = item2;
						val5.SetDatabaseLogon(base._CRWConfig.DB_Username, base._CRWConfig.DB_Password, base._CRWConfig.DB_Server, base._CRWConfig.DB_Database);
						foreach (Table item3 in (SCRCollection)val5.Database.Tables)
						{
							Table val6 = item3;
							if ((int)base._dbMain.ServerType == 1)
							{
								val6.LogOnInfo.ConnectionInfo.DatabaseName = "";
							}
							else
							{
								val6.LogOnInfo.ConnectionInfo.DatabaseName = base._CRWConfig.DB_Database;
							}
							val6.LogOnInfo.ConnectionInfo.ServerName = base._CRWConfig.DB_Server;
							val6.LogOnInfo.ConnectionInfo.Password = base._CRWConfig.DB_Password;
							val6.LogOnInfo.ConnectionInfo.UserID = base._CRWConfig.DB_Username;
							val6.LogOnInfo.ConnectionInfo.IntegratedSecurity = base._CRWConfig.DB_UseIntegratedSecurity;
							val6.ApplyLogOnInfo(val6.LogOnInfo);
							if (val6.Location.LastIndexOf(".") >= 0)
							{
								val6.Location = val6.Location.Substring(checked(val6.Location.LastIndexOf(".") + 1));
							}
						}
					}
					if (ReportParams != null)
					{
						base._ReportParameters = ReportParams;
					}
					this.SetReportParam(ref val3, "ReportParams_Caption", dataTable.Rows[0]["CapRep"].ToString());
					this.SetReportParam(ref val3, "ReportParams_HumanReadable", sHumanReadableSelectionFormula);
					this.SetReportParam(ref val3, "ReportParams_Sistema", base._CRWConfig.DB_Sistema);
					this.SetReportParam(ref val3, "ReportParams_User", base._ApiContext.User);
					if (base._ReportParameters.Count > 0)
					{
						foreach (KeyValuePair<string, object> reportParameter in base._ReportParameters)
						{
							this.SetReportParam(ref val3, reportParameter.Key, reportParameter.Value.ToString());
						}
					}
					checked
					{
						if (Operators.CompareString(vsSelectionFormula, "", false) == 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ReportSelectionFormula"])))
						{
							int fieldValuesCount = objFunctionArguments.Data[0].FieldValuesCount;
							int count = objFunctionArguments.Data.Count;
							vsSelectionFormula = "(";
							int i = default(int);
							for (; i < fieldValuesCount; i++)
							{
								if (i > 0)
								{
									vsSelectionFormula += " OR ";
								}
								vsSelectionFormula += "(";
								vsSelectionFormula = ((Operators.CompareString(dataTable.Rows[0]["ReportSelectionFormula2"].ToString(), "", false) == 0) ? (vsSelectionFormula + dataTable.Rows[0]["ReportSelectionFormula"].ToString().ToUpper()) : (vsSelectionFormula + dataTable.Rows[0]["ReportSelectionFormula2"].ToString().ToUpper()));
								int j = 0;
								string text4 = "";
								for (; j < count; j++)
								{
									if (Operators.CompareString(text4, "", false) != 0)
									{
										text4 += " AND ";
									}
									text4 = text4 + objFunctionArguments.Data[j].FieldName.ToUpper() + " = ";
									text2 = objFunctionArguments.Data[j].FieldName.ToUpper();
									switch (objFunctionArguments.Data[j].FieldType.ToUpper())
									{
									case "STRING":
										text2 = "\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\"";
										text4 += base._dbMain.SQLFormatString(objFunctionArguments.Data[j].get_FieldValues(i).ToString());
										break;
									case "INT16":
									case "INT32":
									case "INT64":
									case "NUMERIC":
									case "DECIMAL":
									case "SINGLE":
									case "DOUBLE":
									{
										text2 = "tonumber(\"" + objFunctionArguments.Data[j].get_FieldValues(i).ToString() + "\")";
										string text5 = text4;
										DBConnection dbMain = base._dbMain;
										string text6 = objFunctionArguments.Data[j].get_FieldValues(i).ToString();
										text4 = text5 + dbMain.SQLFormatNumber(ref text6);
										break;
									}
									case "DATETIME":
									case "DATE":
									{
										DateTime dateTime = Conversions.ToDate(objFunctionArguments.Data[j].get_FieldValues(i));
										text2 = "date(" + dateTime.Year + "," + dateTime.Month + "," + dateTime.Day + ")";
										text4 += string.Format("#{0}#", dateTime.ToString("MM-dd-yyyy"));
										break;
									}
									}
									vsSelectionFormula = vsSelectionFormula.Replace("<%" + objFunctionArguments.Data[j].FieldName.ToUpper() + "%>", text2);
								}
								if (dtDati != null)
								{
									DataRow[] array = dtDati.Select(text4);
									if (array.Count() == 1)
									{
										foreach (DataColumn column in dtDati.Columns)
										{
											text2 = "";
											Type dataType = column.DataType;
											if (dataType == typeof(string))
											{
												text2 = "\"" + array[0][column.ColumnName].ToString() + "\"";
											}
											else if (dataType == typeof(short) || dataType == typeof(int) || dataType == typeof(long) || dataType == typeof(decimal) || dataType == typeof(float) || dataType == typeof(double))
											{
												text2 = "tonumber(\"" + array[0][column.ColumnName].ToString() + "\")";
											}
											else if ((dataType == typeof(DateTime) || dataType == typeof(DateTime)) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(array[0][column.ColumnName])))
											{
												DateTime dateTime2 = Conversions.ToDate(array[0][column.ColumnName]);
												text2 = "date(" + dateTime2.Year + "," + dateTime2.Month + "," + dateTime2.Day + ")";
											}
											vsSelectionFormula = vsSelectionFormula.Replace("<%" + column.ColumnName.ToUpper() + "%>", text2);
										}
									}
								}
								vsSelectionFormula += ")";
							}
							vsSelectionFormula += ")";
						}
						val3.RecordSelectionFormula = vsSelectionFormula;
						text7 = "";
						DateTime now = DateAndTime.Now;
						text7 = base._ApiContext.ApplicationRootDir + base._ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
						val3.ExportToDisk((ExportFormatType)5, text7);
						if (!StampaAsincrona)
						{
							goto IL_1384;
						}
						text = "INSERT INTO WFI_PrintQueue (NomRep,Utente,SelectionFormula,HumanSelectionFormula,ContentToPrint,ContentExtension,Printer,ContentCreationDate,UteIns,UteAgg) VALUES ( ";
						text = text + base._dbMain.SQLFormatString(vsNomeReport) + ", ";
						text = text + base._dbMain.SQLFormatString(base._ApiContext.User) + ", ";
						text = text + base._dbMain.SQLFormatString(vsSelectionFormula) + ", ";
						text = text + base._dbMain.SQLFormatString(sHumanReadableSelectionFormula) + ", ";
						byte[] array2 = File.ReadAllBytes(text7);
						text = text + base._dbMain.ConvertToVarbinary(modGeneral.ByteArrayToString(array2)) + ", ";
						text = text + base._dbMain.SQLFormatString("PDF") + ", ";
						text = text + base._dbMain.SQLFormatString(dataTable2.Rows[0]["Stampante"].ToString()) + ", ";
						text = text + base._dbMain.GetDate() + ", ";
						text = text + base._dbMain.SQLFormatString(base._ApiContext.User) + ", ";
						text = text + base._dbMain.SQLFormatString(base._ApiContext.User) + ") ";
						val = base._dbMain.SqlExec(text, ref rsMess);
					}
					if ((int)val <= 0)
					{
						goto IL_1384;
					}
					val2 = val;
				}
			}
			goto end_IL_001b;
			IL_1384:
			if ((int)_SessionEnv.AddFileToDelete(text7, ref rsMess) <= 0)
			{
				rsNomeFileCompletoGenerato = text7;
				val2 = (FXRETURN)0;
			}
			end_IL_001b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = base._objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			dtDati = null;
			if (val3 != null)
			{
				val3.Close();
				((Component)(object)val3).Dispose();
			}
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			if (dataTable2 != null)
			{
				dataTable2.Dispose();
				dataTable2 = null;
			}
			base._objCallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
