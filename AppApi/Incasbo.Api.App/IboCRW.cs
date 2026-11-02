using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class IboCRW
{
	public enum IboExportFormatType
	{
		Default,
		PDF,
		XLS,
		HTML,
		DOC
	}

	protected string _PercorsoStampe;

	protected string _PercorsoStampeCustom;

	protected string _PercorsoStampeConfigurato;

	protected IboAppCallStackHandling _objCallStackHandler;

	protected IboAppLogHandling _objLogHandling;

	protected DBConnection _dbMain;

	protected IboWebParam _objParam;

	protected IncasTranslator _ObjTranslator;

	protected Dictionary<string, object> _ReportParameters;

	protected AppApiContext _ApiContext;

	protected CRWConfiguration _CRWConfig;

	public IboCRW(ref AppApiContext ApiContext)
	{
		_PercorsoStampe = "\\Stampe\\";
		_PercorsoStampeCustom = "\\Custom\\Stampe\\";
		_PercorsoStampeConfigurato = "";
		_ApiContext = ApiContext;
		_objCallStackHandler = _ApiContext.CallStackHandler;
		_objLogHandling = _ApiContext.LogHandler;
		_objParam = _ApiContext.Parametrica;
		_dbMain = _ApiContext.DbConn;
		_ObjTranslator = _ApiContext.Translator;
		if (_dbMain.ServerType == DBFormatFunctions.eServerType.Oracle)
		{
			_PercorsoStampe += "ORCL\\";
		}
		else if (_dbMain.ServerType == DBFormatFunctions.eServerType.SQL)
		{
			_PercorsoStampe += "SQL\\";
		}
		_ReportParameters = new Dictionary<string, object>();
		_CRWConfig = ApiContext.CRWConfig;
	}

	public virtual modGeneral.FXRETURN CrystalReportToFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, IboExportFormatType Formato, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		string text = "";
		ReportDocument rpt = null;
		string text2 = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				_objCallStackHandler.CallStackAdd();
				rsMess = "";
				text = "SELECT * FROM WFI_TABREP ";
				text += "WHERE ";
				text = text + "NOMREP = " + _dbMain.SQLFormatString(vsNomeReport);
				fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = _ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", vsNomeReport);
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						_PercorsoStampeConfigurato = rObjDataTable.Rows[0]["Percorso"].ToString();
					}
					text = "SELECT * ";
					text += "FROM VW_WFI_StampeAutomatiche ";
					text += "WHERE NomRep IN (<%NomeReport%>, '*ALL') ";
					text += "AND Utente IN (<%Utente%>, <%Gruppo%>, <%Organizzazione%>, <%TipoOrganizzazione%>, <%XXX%>) ";
					text += "ORDER BY PESO DESC";
					text = text.Replace("<%NomeReport%>", _dbMain.SQLFormatString(vsNomeReport));
					text = text.Replace("<%Utente%>", _dbMain.SQLFormatString(_ApiContext.User));
					text = text.Replace("<%Gruppo%>", _dbMain.SQLFormatString(_ApiContext.Group));
					text = text.Replace("<%Organizzazione%>", _dbMain.SQLFormatString(_ApiContext.Organization));
					text = text.Replace("<%TipoOrganizzazione%>", _dbMain.SQLFormatString(_ApiContext.OrganizationType));
					text = ((Operators.CompareString(_ApiContext.OrganizationInternalExternal, "I", false) != 0) ? text.Replace("<%XXX%>", "'YYY'") : text.Replace("<%XXX%>", "'XXX'"));
					if (_dbMain.OpenDataTable(text, ref rObjDataTable2, ref rsMess) == modGeneral.FXRETURN.OK)
					{
						string text3 = "";
						if (Operators.CompareString(_PercorsoStampeConfigurato, "", false) != 0)
						{
							text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
						}
						else
						{
							text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
							if (!File.Exists(text3))
							{
								text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
							}
						}
						if (!File.Exists(text3))
						{
							rsMess = _ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", vsNomeReport);
						}
						else
						{
							rpt = new ReportDocument();
							rpt.FileName = text3;
							if (_dbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
							{
								rpt.SetDatabaseLogon(_CRWConfig.DB_Username, _CRWConfig.DB_Password, _CRWConfig.DB_Server, _CRWConfig.DB_Database);
							}
							else
							{
								rpt.SetDatabaseLogon(_CRWConfig.DB_Username, _CRWConfig.DB_Password, _CRWConfig.DB_Server, "");
							}
							foreach (Table item in (SCRCollection)rpt.Database.Tables)
							{
								Table val = item;
								if (_dbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
								{
									val.LogOnInfo.ConnectionInfo.DatabaseName = _CRWConfig.DB_Database;
								}
								else
								{
									val.LogOnInfo.ConnectionInfo.DatabaseName = "";
								}
								val.LogOnInfo.ConnectionInfo.ServerName = _CRWConfig.DB_Server;
								val.LogOnInfo.ConnectionInfo.Password = _CRWConfig.DB_Password;
								val.LogOnInfo.ConnectionInfo.UserID = _CRWConfig.DB_Username;
								val.LogOnInfo.ConnectionInfo.IntegratedSecurity = _CRWConfig.DB_UseIntegratedSecurity;
								val.ApplyLogOnInfo(val.LogOnInfo);
								if (val.Location.LastIndexOf(".") >= 0)
								{
									val.Location = val.Location.Substring(val.Location.LastIndexOf(".") + 1);
								}
							}
							rpt.ReportOptions.EnableSaveDataWithReport = false;
							foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)rpt.Subreports)
							{
								ReportDocument val2 = item2;
								val2.SetDatabaseLogon(_CRWConfig.DB_Username, _CRWConfig.DB_Password, _CRWConfig.DB_Server, _CRWConfig.DB_Database);
								foreach (Table item3 in (SCRCollection)val2.Database.Tables)
								{
									Table val3 = item3;
									if (_dbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
									{
										val3.LogOnInfo.ConnectionInfo.DatabaseName = _CRWConfig.DB_Database;
									}
									else
									{
										val3.LogOnInfo.ConnectionInfo.DatabaseName = "";
									}
									val3.LogOnInfo.ConnectionInfo.ServerName = _CRWConfig.DB_Server;
									val3.LogOnInfo.ConnectionInfo.Password = _CRWConfig.DB_Password;
									val3.LogOnInfo.ConnectionInfo.UserID = _CRWConfig.DB_Username;
									val3.LogOnInfo.ConnectionInfo.IntegratedSecurity = _CRWConfig.DB_UseIntegratedSecurity;
									val3.ApplyLogOnInfo(val3.LogOnInfo);
									if (val3.Location.LastIndexOf(".") >= 0)
									{
										val3.Location = val3.Location.Substring(val3.Location.LastIndexOf(".") + 1);
									}
								}
							}
							if (ReportParams != null)
							{
								_ReportParameters = ReportParams;
							}
							SetReportParam(ref rpt, "ReportParams_Caption", rObjDataTable.Rows[0]["CapRep"].ToString());
							SetReportParam(ref rpt, "ReportParams_HumanReadable", vsHumanReadableSelectionFormula);
							SetReportParam(ref rpt, "ReportParams_Sistema", _CRWConfig.DB_Sistema);
							SetReportParam(ref rpt, "ReportParams_User", _ApiContext.User);
							if (_ReportParameters.Count > 0)
							{
								foreach (KeyValuePair<string, object> reportParameter in _ReportParameters)
								{
									SetReportParam(ref rpt, reportParameter.Key, reportParameter.Value.ToString());
								}
							}
							rpt.RecordSelectionFormula = vsSelectionFormula;
							string text4 = "";
							DateTime now = DateAndTime.Now;
							text4 = _ApiContext.ApplicationRootDir + _ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
							switch (Formato)
							{
							case IboExportFormatType.PDF:
								rpt.ExportToDisk((ExportFormatType)5, text4);
								break;
							case IboExportFormatType.XLS:
								rpt.ExportToDisk((ExportFormatType)4, text4);
								break;
							case IboExportFormatType.HTML:
								rpt.ExportToDisk((ExportFormatType)7, text4);
								break;
							case IboExportFormatType.DOC:
								rpt.ExportToDisk((ExportFormatType)3, text4);
								break;
							default:
								rpt.ExportToDisk((ExportFormatType)5, text4);
								break;
							}
							rsNomeFileCompletoGenerato = text4;
							fXRETURN2 = modGeneral.FXRETURN.OK;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = _objLogHandling.HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (rpt != null)
				{
					rpt.Close();
					((Component)(object)rpt).Dispose();
				}
				if (rObjDataTable != null)
				{
					rObjDataTable.Dispose();
					rObjDataTable = null;
				}
				if (rObjDataTable2 != null)
				{
					rObjDataTable2.Dispose();
					rObjDataTable2 = null;
				}
				_objCallStackHandler.CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	public virtual modGeneral.FXRETURN CrystalReportToPDF(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, ref string rsNomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
	{
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		string text = "";
		ReportDocument rpt = null;
		string text2 = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				_objCallStackHandler.CallStackAdd();
				rsMess = "";
				StampaAsincrona = false;
				text = "SELECT * FROM WFI_TABREP ";
				text += "WHERE ";
				text = text + "NOMREP = " + _dbMain.SQLFormatString(vsNomeReport);
				fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				string text4;
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = _ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", vsNomeReport);
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						_PercorsoStampeConfigurato = rObjDataTable.Rows[0]["Percorso"].ToString();
					}
					text = "SELECT * ";
					text += "FROM VW_WFI_StampeAutomatiche ";
					text += "WHERE NomRep IN (<%NomeReport%>, '*ALL') ";
					text += "AND Utente IN (<%Utente%>, <%Gruppo%>, <%Organizzazione%>, <%TipoOrganizzazione%>, <%XXX%>) ";
					text += "ORDER BY PESO DESC";
					text = text.Replace("<%NomeReport%>", _dbMain.SQLFormatString(vsNomeReport));
					text = text.Replace("<%Utente%>", _dbMain.SQLFormatString(_ApiContext.User));
					text = text.Replace("<%Gruppo%>", _dbMain.SQLFormatString(_ApiContext.Group));
					text = text.Replace("<%Organizzazione%>", _dbMain.SQLFormatString(_ApiContext.Organization));
					text = text.Replace("<%TipoOrganizzazione%>", _dbMain.SQLFormatString(_ApiContext.OrganizationType));
					text = ((Operators.CompareString(_ApiContext.OrganizationInternalExternal, "I", false) != 0) ? text.Replace("<%XXX%>", "'YYY'") : text.Replace("<%XXX%>", "'XXX'"));
					if (_dbMain.OpenDataTable(text, ref rObjDataTable2, ref rsMess) == modGeneral.FXRETURN.OK)
					{
						if (rObjDataTable2.Rows.Count > 0 && Operators.CompareString(rObjDataTable2.Rows[0]["StampaAsincrona"].ToString(), "S", false) == 0)
						{
							StampaAsincrona = true;
						}
						string text3 = "";
						if (Operators.CompareString(_PercorsoStampeConfigurato, "", false) != 0)
						{
							text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
						}
						else
						{
							text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
							if (!File.Exists(text3))
							{
								text3 = (_ApiContext.ApplicationRootDir + _PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
							}
						}
						if (!File.Exists(text3))
						{
							rsMess = _ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", vsNomeReport);
						}
						else
						{
							rpt = new ReportDocument();
							rpt.FileName = text3;
							rpt.SetDatabaseLogon(_CRWConfig.DB_Username, _CRWConfig.DB_Password, _CRWConfig.DB_Server, _CRWConfig.DB_Database);
							foreach (Table item in (SCRCollection)rpt.Database.Tables)
							{
								Table val = item;
								if (_dbMain.ServerType == DBFormatFunctions.eServerType.Oracle)
								{
									val.LogOnInfo.ConnectionInfo.DatabaseName = "";
								}
								else
								{
									val.LogOnInfo.ConnectionInfo.DatabaseName = _CRWConfig.DB_Database;
								}
								val.LogOnInfo.ConnectionInfo.ServerName = _CRWConfig.DB_Server;
								val.LogOnInfo.ConnectionInfo.Password = _CRWConfig.DB_Password;
								val.LogOnInfo.ConnectionInfo.UserID = _CRWConfig.DB_Username;
								val.LogOnInfo.ConnectionInfo.IntegratedSecurity = _CRWConfig.DB_UseIntegratedSecurity;
								val.ApplyLogOnInfo(val.LogOnInfo);
								if (val.Location.LastIndexOf(".") >= 0)
								{
									val.Location = val.Location.Substring(val.Location.LastIndexOf(".") + 1);
								}
							}
							rpt.ReportOptions.EnableSaveDataWithReport = false;
							foreach (ReportDocument item2 in (ReadOnlyCollectionBase)(object)rpt.Subreports)
							{
								ReportDocument val2 = item2;
								val2.SetDatabaseLogon(_CRWConfig.DB_Username, _CRWConfig.DB_Password, _CRWConfig.DB_Server, _CRWConfig.DB_Database);
								foreach (Table item3 in (SCRCollection)val2.Database.Tables)
								{
									Table val3 = item3;
									if (_dbMain.ServerType == DBFormatFunctions.eServerType.Oracle)
									{
										val3.LogOnInfo.ConnectionInfo.DatabaseName = "";
									}
									else
									{
										val3.LogOnInfo.ConnectionInfo.DatabaseName = _CRWConfig.DB_Database;
									}
									val3.LogOnInfo.ConnectionInfo.ServerName = _CRWConfig.DB_Server;
									val3.LogOnInfo.ConnectionInfo.Password = _CRWConfig.DB_Password;
									val3.LogOnInfo.ConnectionInfo.UserID = _CRWConfig.DB_Username;
									val3.LogOnInfo.ConnectionInfo.IntegratedSecurity = _CRWConfig.DB_UseIntegratedSecurity;
									val3.ApplyLogOnInfo(val3.LogOnInfo);
									if (val3.Location.LastIndexOf(".") >= 0)
									{
										val3.Location = val3.Location.Substring(val3.Location.LastIndexOf(".") + 1);
									}
								}
							}
							if (ReportParams != null)
							{
								_ReportParameters = ReportParams;
							}
							SetReportParam(ref rpt, "ReportParams_Caption", rObjDataTable.Rows[0]["CapRep"].ToString());
							SetReportParam(ref rpt, "ReportParams_HumanReadable", vsHumanReadableSelectionFormula);
							SetReportParam(ref rpt, "ReportParams_Sistema", _CRWConfig.DB_Sistema);
							SetReportParam(ref rpt, "ReportParams_User", _ApiContext.User);
							if (_ReportParameters.Count > 0)
							{
								foreach (KeyValuePair<string, object> reportParameter in _ReportParameters)
								{
									SetReportParam(ref rpt, reportParameter.Key, reportParameter.Value.ToString());
								}
							}
							rpt.RecordSelectionFormula = vsSelectionFormula;
							text4 = "";
							DateTime now = DateAndTime.Now;
							text4 = _ApiContext.ApplicationRootDir + _ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
							rpt.ExportToDisk((ExportFormatType)5, text4);
							if (!StampaAsincrona)
							{
								goto IL_0a02;
							}
							text = "INSERT INTO WFI_PrintQueue (NomRep,Utente,SelectionFormula,HumanSelectionFormula,ContentToPrint,ContentExtension,Printer,ContentCreationDate,UteIns,UteAgg) VALUES ( ";
							text = text + _dbMain.SQLFormatString(vsNomeReport) + ", ";
							text = text + _dbMain.SQLFormatString(_ApiContext.User) + ", ";
							text = text + _dbMain.SQLFormatString(vsSelectionFormula) + ", ";
							text = text + _dbMain.SQLFormatString(vsHumanReadableSelectionFormula) + ", ";
							byte[] ba = File.ReadAllBytes(text4);
							text = text + _dbMain.ConvertToVarbinary(modGeneral.ByteArrayToString(ba)) + ", ";
							text = text + _dbMain.SQLFormatString("PDF") + ", ";
							text = text + _dbMain.SQLFormatString(rObjDataTable2.Rows[0]["Stampante"].ToString()) + ", ";
							text = text + _dbMain.GetDate() + ", ";
							text = text + _dbMain.SQLFormatString(_ApiContext.User) + ", ";
							text = text + _dbMain.SQLFormatString(_ApiContext.User) + ") ";
							fXRETURN = _dbMain.SqlExec(text, ref rsMess);
							if (fXRETURN == modGeneral.FXRETURN.OK)
							{
								goto IL_0a02;
							}
							fXRETURN2 = fXRETURN;
						}
					}
				}
				goto end_IL_001a;
				IL_0a02:
				rsNomeFileCompletoGenerato = text4;
				fXRETURN2 = modGeneral.FXRETURN.OK;
				end_IL_001a:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = _objLogHandling.HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (rpt != null)
				{
					rpt.Close();
					((Component)(object)rpt).Dispose();
				}
				if (rObjDataTable != null)
				{
					rObjDataTable.Dispose();
					rObjDataTable = null;
				}
				if (rObjDataTable2 != null)
				{
					rObjDataTable2.Dispose();
					rObjDataTable2 = null;
				}
				_objCallStackHandler.CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	public virtual modGeneral.FXRETURN ViewToCsvFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, string Title, string SubTitle, bool IncludeColumnsName, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DataTable rObjDataTable = null;
		string text = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				_objCallStackHandler.CallStackAdd();
				rsMess = "";
				text = "SELECT * FROM WFI_TABREP ";
				text = text + "WHERE NOMREP = " + _dbMain.SQLFormatString(vsNomeReport);
				fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = _ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", vsNomeReport);
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						_PercorsoStampeConfigurato = rObjDataTable.Rows[0]["Percorso"].ToString();
					}
					string text2 = "";
					if (Operators.CompareString(_PercorsoStampeConfigurato, "", false) != 0)
					{
						text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
					}
					else
					{
						text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
						if (!File.Exists(text2))
						{
							text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
						}
					}
					if (!File.Exists(text2))
					{
						rsMess = _ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", vsNomeReport);
					}
					else
					{
						string text3 = File.ReadAllText(text2);
						DataTable rObjDataTable2 = null;
						StringBuilder stringBuilder = new StringBuilder();
						text = "SELECT T.* FROM (" + text3 + ") T WHERE (1=1) AND (" + vsSelectionFormula + ")";
						fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable2, ref rsMess);
						if (fXRETURN != 0)
						{
							fXRETURN2 = fXRETURN;
						}
						else
						{
							stringBuilder.Append(ToCsvFormat("Report: " + vsNomeReport));
							stringBuilder.Append("\r\n");
							if (Operators.CompareString(Title, "", false) != 0)
							{
								stringBuilder.Append(ToCsvFormat(Title));
								stringBuilder.Append("\r\n");
							}
							if (Operators.CompareString(SubTitle, "", false) != 0)
							{
								stringBuilder.Append(ToCsvFormat(SubTitle));
								stringBuilder.Append("\r\n");
							}
							if (Operators.CompareString(vsHumanReadableSelectionFormula, "", false) != 0)
							{
								stringBuilder.Append(ToCsvFormat("Filtro: " + vsHumanReadableSelectionFormula));
								stringBuilder.Append("\r\n");
							}
							if (IncludeColumnsName)
							{
								foreach (DataColumn column in rObjDataTable2.Columns)
								{
									stringBuilder.Append(ToCsvFormat(column.ColumnName));
								}
								stringBuilder.Append("\r\n");
							}
							foreach (DataRow row in rObjDataTable2.Rows)
							{
								int num = rObjDataTable2.Columns.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									if (row[i] is DateTime)
									{
										DateTime dateTime = Conversions.ToDate(row[i]);
										if ((dateTime.Hour != 0) & (dateTime.Minute != 0) & (dateTime.Second != 0))
										{
											stringBuilder.Append(ToCsvFormat(Conversions.ToDate(row[i]).ToString("dd/MM/yyyy HH:mm:ss")));
										}
										else
										{
											stringBuilder.Append(ToCsvFormat(Conversions.ToDate(row[i]).ToString("dd/MM/yyyy")));
										}
									}
									else
									{
										stringBuilder.Append(ToCsvFormat(row[i].ToString()));
									}
								}
								stringBuilder.Append("\r\n");
							}
							string text4 = "";
							DateTime now = DateAndTime.Now;
							text4 = _ApiContext.ApplicationRootDir + _ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
							File.WriteAllText(text4, stringBuilder.ToString());
							rsNomeFileCompletoGenerato = text4;
							fXRETURN2 = modGeneral.FXRETURN.OK;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = _objLogHandling.HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				_objCallStackHandler.CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	public virtual modGeneral.FXRETURN ViewToHtmlFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, string Title, string SubTitle, bool IncludeColumnsName, ref string rsNomeFileCompletoGenerato, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DataTable rObjDataTable = null;
		string text = "";
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				_objCallStackHandler.CallStackAdd();
				rsMess = "";
				text = "SELECT * FROM WFI_TABREP ";
				text = text + "WHERE NOMREP = " + _dbMain.SQLFormatString(vsNomeReport);
				fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable, ref rsMess);
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsMess = _ObjTranslator.TranslateMessage("XXX", "Il report {0} non esiste nella tabella WFI_TABREP.", vsNomeReport);
				}
				else
				{
					if (Operators.CompareString(rObjDataTable.Rows[0]["Percorso"].ToString(), "", false) != 0)
					{
						_PercorsoStampeConfigurato = rObjDataTable.Rows[0]["Percorso"].ToString();
					}
					string text2 = "";
					if (Operators.CompareString(_PercorsoStampeConfigurato, "", false) != 0)
					{
						text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampeConfigurato + vsNomeReport).Replace("\\\\", "\\");
					}
					else
					{
						text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampeCustom + vsNomeReport).Replace("\\\\", "\\");
						if (!File.Exists(text2))
						{
							text2 = (_ApiContext.ApplicationRootDir + _PercorsoStampe + vsNomeReport).Replace("\\\\", "\\");
						}
					}
					if (!File.Exists(text2))
					{
						rsMess = _ObjTranslator.TranslateMessage("XXX", "Il file del report {0} non esiste", vsNomeReport);
					}
					else
					{
						string text3 = File.ReadAllText(text2);
						DataTable rObjDataTable2 = null;
						text = "SELECT T.* FROM (" + text3 + ") T WHERE (1=1) AND (" + vsSelectionFormula + ")";
						fXRETURN = _dbMain.OpenDataTable(text, ref rObjDataTable2, ref rsMess);
						if (fXRETURN != 0)
						{
							fXRETURN2 = fXRETURN;
						}
						else
						{
							StringBuilder stringBuilder = new StringBuilder();
							string value = "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head>";
							stringBuilder.Append(value);
							if (Operators.CompareString(Title, "", false) != 0)
							{
								value = "<title>" + Title + "</title>";
								stringBuilder.Append(value);
							}
							value = "</head><body style=\"font-family:Verdana;\">\r\n";
							stringBuilder.Append(value);
							value = "<p style=\"font-size:10pt;font-weight:bold;\">Nome report: " + vsNomeReport + "</p>\r\n";
							stringBuilder.Append(value);
							if (Operators.CompareString(Title, "", false) != 0)
							{
								value = "<p style=\"font-size:14pt;font-weight:bold;\">" + Title + "</p>\r\n";
								stringBuilder.Append(value);
							}
							if (Operators.CompareString(SubTitle, "", false) != 0)
							{
								value = "<p style=\"font-size:12pt;font-weight:bold;\">" + SubTitle + "</p>\r\n";
								stringBuilder.Append(value);
							}
							if (Operators.CompareString(vsHumanReadableSelectionFormula, "", false) != 0)
							{
								value = "<p style=\"font-size:12pt;font-weight:bold;\">Filtro: " + vsHumanReadableSelectionFormula + "</p>\r\n";
								stringBuilder.Append(value);
							}
							value = "<table border=\"1\" cellpadding=\"3\" cellspacing=\"0\" bgcolor=#A0A0A0 style='font-size:8pt'>\r\n";
							stringBuilder.Append(value);
							if (IncludeColumnsName)
							{
								stringBuilder.Append("<tr>");
								foreach (DataColumn column in rObjDataTable2.Columns)
								{
									value = "<td bgcolor=\"#E1E1E1\"><b>" + column.ColumnName + "</b></td>";
									stringBuilder.Append(value);
								}
								stringBuilder.Append("</tr>");
							}
							foreach (DataRow row in rObjDataTable2.Rows)
							{
								stringBuilder.Append("<tr>");
								int num = rObjDataTable2.Columns.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									if (row[i] is DateTime)
									{
										DateTime dateTime = Conversions.ToDate(row[i]);
										value = ((!((dateTime.Hour != 0) & (dateTime.Minute != 0) & (dateTime.Second != 0))) ? ("<td bgcolor=\"#FFFFFF\">" + Conversions.ToDate(row[i]).ToString("dd/MM/yyyy") + "</td>") : ("<td bgcolor=\"#FFFFFF\">" + Conversions.ToDate(row[i]).ToString("dd/MM/yyyy HH:mm:ss") + "</td>"));
										stringBuilder.Append(value);
									}
									else
									{
										value = "<td bgcolor=\"#FFFFFF\">" + row[i].ToString() + "</td>";
										stringBuilder.Append(value);
									}
								}
								stringBuilder.Append("</tr>");
							}
							string text4 = "";
							DateTime now = DateAndTime.Now;
							text4 = _ApiContext.ApplicationRootDir + _ApiContext.DownloadDir + vsNomeFileExport.Replace("*", now.Year + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0') + now.Millisecond.ToString().PadLeft(3, '0'));
							File.WriteAllText(text4, stringBuilder.ToString());
							rsNomeFileCompletoGenerato = text4;
							fXRETURN2 = modGeneral.FXRETURN.OK;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = _objLogHandling.HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				_objCallStackHandler.CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	protected string ToCsvFormat(string s)
	{
		return "\"" + s.Replace("\"", "\"\"") + "\";";
	}

	protected void SetReportParam(ref ReportDocument rpt, string ParamName, string Value)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		ParameterFieldDefinition val = CrystalReportGetParamDefinition(ParamName, ref rpt);
		if (val != null)
		{
			ParameterValues val2 = new ParameterValues();
			ParameterDiscreteValue val3 = new ParameterDiscreteValue();
			val3.Value = Value;
			val2 = val.CurrentValues;
			val2.Clear();
			val2.Add((ParameterValue)(object)val3);
			val.ApplyCurrentValues(val2);
		}
		FormulaFieldDefinition val4 = CrystalReportGetFormulaDefinition(ParamName, ref rpt);
		if (val4 != null)
		{
			val4.Text = "\"" + Value + "\"";
		}
	}

	protected ParameterFieldDefinition CrystalReportGetParamDefinition(string vsParamName, ref ReportDocument objRpt)
	{
		ParameterFieldDefinition result = null;
		int i = default(int);
		for (ParameterFieldDefinitions parameterFields = objRpt.DataDefinition.ParameterFields; i < ((FieldDefinitions)parameterFields).Count; i = checked(i + 1))
		{
			if (Operators.CompareString(((FieldDefinition)parameterFields[i]).Name.ToUpper(), vsParamName.ToUpper(), false) == 0)
			{
				result = parameterFields[i];
				i = ((FieldDefinitions)parameterFields).Count;
			}
		}
		return result;
	}

	protected FormulaFieldDefinition CrystalReportGetFormulaDefinition(string vsParamName, ref ReportDocument objRpt)
	{
		FormulaFieldDefinition result = null;
		int i = default(int);
		for (FormulaFieldDefinitions formulaFields = objRpt.DataDefinition.FormulaFields; i < ((FieldDefinitions)formulaFields).Count; i = checked(i + 1))
		{
			if (Operators.CompareString(((FieldDefinition)formulaFields[i]).Name.ToUpper(), vsParamName.ToUpper(), false) == 0)
			{
				result = formulaFields[i];
				i = ((FieldDefinitions)formulaFields).Count;
			}
		}
		return result;
	}
}
