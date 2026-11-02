using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Statistics;

public class StatisticsManager : AppBaseClass
{
	protected Statistics _Statistics;

	protected bool _initialized;

	protected CRWConfiguration _Config;

	public Statistics Statistics => _Statistics;

	public bool Initialized => _initialized;

	public StatisticsManager(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Statistics = new Statistics();
		_initialized = false;
	}

	protected new void Init(AppApiContext objApiContext)
	{
		base.Init(objApiContext);
	}

	protected new void Init(ref DBConnection objDbConn, ref IncasTranslator objTranslator, ref IboAppCallStackHandling objCallStackHandler, ref IboAppLogHandling objLogHandler, ref IboWebParam objParametrica, string sAppUser, string sAppGroup, string sAppOrganization, string sAppOrganizationType, string sAppOrganizationInternalExternal)
	{
		base.Init(ref objDbConn, ref objTranslator, ref objCallStackHandler, ref objLogHandler, ref objParametrica, sAppUser, sAppGroup, sAppOrganization, sAppOrganizationType, sAppOrganizationInternalExternal);
	}

	public void ChangeApiContext(AppApiContext objApiContext)
	{
		Init(objApiContext);
	}

	public virtual modGeneral.FXRETURN Init(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			if (_initialized)
			{
				goto IL_0703;
			}
			DataTable rObjDataTable = null;
			DataTable rObjDataTable2 = null;
			string text = "";
			text = "SELECT S.*, R.NOMTAB FROM WFI_STATISTICHE S INNER JOIN WFI_TABREP R ON R.NOMREP=S.NOMREP";
			fXRETURN2 = DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if (fXRETURN2 == modGeneral.FXRETURN.OK)
			{
				IEnumerator enumerator2 = default(IEnumerator);
				Dictionary<string, string> sRetColl = default(Dictionary<string, string>);
				foreach (DataRow row in rObjDataTable.Rows)
				{
					Statistic statistic = new Statistic();
					statistic.Codice = row["Codice"].ToString();
					statistic.Descrizione = row["Descrizione"].ToString();
					statistic.Titolo = row["Titolo"].ToString();
					statistic.Sottotitolo = row["Sottotitolo"].ToString();
					if (Operators.CompareString(row["TipoStatistica"].ToString().ToUpper(), "PDF", false) == 0)
					{
						statistic.TipoStatistica = StatisticType.PDF;
					}
					else if (Operators.CompareString(row["TipoStatistica"].ToString().ToUpper(), "CSV", false) == 0)
					{
						statistic.TipoStatistica = StatisticType.CSV;
					}
					else if (Operators.CompareString(row["TipoStatistica"].ToString().ToUpper(), "XLS", false) == 0)
					{
						statistic.TipoStatistica = StatisticType.XLS;
					}
					else
					{
						statistic.TipoStatistica = StatisticType.PDF;
					}
					statistic.Asincrona = Operators.CompareString(row["Asincrona"].ToString(), "S", false) == 0;
					statistic.Utente = row["Utente"].ToString();
					statistic.NomRep = row["NomRep"].ToString();
					statistic.NomTab = row["NomTab"].ToString();
					statistic.Param1 = row["Param1"].ToString();
					statistic.Param2 = row["Param2"].ToString();
					statistic.Param3 = row["Param3"].ToString();
					statistic.Param4 = row["Param4"].ToString();
					statistic.Param5 = row["Param5"].ToString();
					statistic.Attivo = Operators.CompareString(row["Attivo"].ToString(), "S", false) == 0;
					statistic.Visibile = Operators.CompareString(row["Visibile"].ToString(), "S", false) == 0;
					statistic.PreprocessingClassName = row["Preprocessing_ClassName"].ToString();
					text = "SELECT F.* FROM WFI_STATISTICHE_FILTRI F WHERE CodiceStatistica=" + DbConn.SQLFormatString(statistic.Codice);
					fXRETURN2 = DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
					if (fXRETURN2 == modGeneral.FXRETURN.OK)
					{
						{
							enumerator2 = rObjDataTable2.Rows.GetEnumerator();
							try
							{
								DataRow dataRow2;
								StatisticFilter statisticFilter;
								for (; enumerator2.MoveNext(); statisticFilter.Attivo = Operators.CompareString(dataRow2["Attivo"].ToString(), "S", false) == 0, statisticFilter.Enabled = Operators.CompareString(dataRow2["Enabled"].ToString(), "S", false) == 0, statisticFilter.Visibile = Operators.CompareString(dataRow2["Visibile"].ToString(), "S", false) == 0, statisticFilter.Tooltip = dataRow2["Tooltip"].ToString(), statisticFilter.Required = Operators.CompareString(dataRow2["Required"].ToString(), "S", false) == 0, statistic.Filtri.Add(statisticFilter))
								{
									dataRow2 = (DataRow)enumerator2.Current;
									statisticFilter = new StatisticFilter();
									statisticFilter.Id = Conversions.ToLong(dataRow2["Id"]);
									statisticFilter.CodiceStatistica = dataRow2["CodiceStatistica"].ToString();
									statisticFilter.NomeCampo = dataRow2["NomeCampo"].ToString();
									if (Operators.CompareString(dataRow2["TipoCampo"].ToString(), "N", false) == 0)
									{
										statisticFilter.TipoCampo = StatisticFieldType.Numero;
									}
									else if (Operators.CompareString(dataRow2["TipoCampo"].ToString(), "D", false) == 0)
									{
										statisticFilter.TipoCampo = StatisticFieldType.Data;
									}
									else
									{
										statisticFilter.TipoCampo = StatisticFieldType.Stringa;
									}
									statisticFilter.DescrizioneCampo = dataRow2["DescrizioneCampo"].ToString();
									if (Operators.CompareString(statisticFilter.DescrizioneCampo, "", false) == 0)
									{
										statisticFilter.DescrizioneCampo = StandardNameFilter(statisticFilter.NomeCampo);
									}
									if (Operators.CompareString(dataRow2["Operatore"].ToString(), "=", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.Uguale;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString(), ">", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.Maggiore;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString(), ">=", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.MaggioreUguale;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString(), "<", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.Minore;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString(), "<=", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.MinoreUguale;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString().ToUpper(), "LIKE", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.Simile;
									}
									else if (Operators.CompareString(dataRow2["Operatore"].ToString().ToUpper(), "<>", false) == 0)
									{
										statisticFilter.Operatore = StatisticOperatore.Diverso;
									}
									statisticFilter.ValoreCampo = dataRow2["ValoreCampo"].ToString();
									statisticFilter.Caption = dataRow2["Caption"].ToString();
									if (Operators.CompareString(statisticFilter.Caption, "", false) == 0)
									{
										statisticFilter.Caption = StandardNameFilter(statisticFilter.NomeCampo);
									}
									statisticFilter.IdControlloUI = dataRow2["IdControlloUI"].ToString();
									statisticFilter.ProprietaControlloUI = dataRow2["ProprietaControlloUI"].ToString();
									if (Operators.CompareString(statisticFilter.ProprietaControlloUI, "", false) == 0)
									{
										continue;
									}
									fXRETURN2 = StandardParser(statisticFilter.ProprietaControlloUI, ref sRetColl, ref rsmess);
									if (fXRETURN2 == modGeneral.FXRETURN.OK)
									{
										statisticFilter.ProprietaControlloUIList = sRetColl;
										continue;
									}
									fXRETURN = fXRETURN2;
									goto end_IL_0004;
								}
							}
							finally
							{
								IDisposable disposable = enumerator2 as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						_Statistics.Add(statistic);
						continue;
					}
					fXRETURN = fXRETURN2;
					goto end_IL_0004;
				}
				_initialized = true;
				goto IL_0703;
			}
			fXRETURN = fXRETURN2;
			goto end_IL_0004;
			IL_0703:
			fXRETURN = modGeneral.FXRETURN.OK;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	public virtual modGeneral.FXRETURN ReInit(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			_initialized = false;
			fXRETURN2 = Init(ref rsmess);
			fXRETURN = ((fXRETURN2 != 0) ? fXRETURN2 : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	public virtual modGeneral.FXRETURN Run(string CodiceStatistica, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, bool ForceImmediateRun, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			if (!_initialized)
			{
				rsmess = TranslateMessage("XXX", "L'engine statistico non è stato inizializzato");
			}
			else
			{
				IEnumerable<Statistic> source = _Statistics.Where([SpecialName] (Statistic stat) => Operators.CompareString(stat.Codice, CodiceStatistica, false) == 0);
				if (source.Count() == 0)
				{
					rsmess = TranslateMessage("XXX", "La statistica {0} non esiste", CodiceStatistica);
				}
				else
				{
					Statistic statistic = source.First();
					if (!statistic.Attivo)
					{
						rsmess = TranslateMessage("XXX", "La statistica {0} non è attiva", CodiceStatistica);
					}
					else if (!statistic.Asincrona || ForceImmediateRun)
					{
						fXRETURN2 = ExecuteStatistic(statistic, FilterToApply, ref FileNameOutput, ref rsmess);
						if (fXRETURN2 == modGeneral.FXRETURN.OK)
						{
							goto IL_0109;
						}
						fXRETURN = fXRETURN2;
					}
					else
					{
						fXRETURN2 = EnqueueStatistic(statistic, FilterToApply, ref rsmess);
						if (fXRETURN2 == modGeneral.FXRETURN.OK)
						{
							goto IL_0109;
						}
						fXRETURN = fXRETURN2;
					}
				}
			}
			goto end_IL_0011;
			IL_0109:
			fXRETURN = modGeneral.FXRETURN.OK;
			end_IL_0011:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	public virtual modGeneral.FXRETURN Run(string CodiceStatistica, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		return Run(CodiceStatistica, FilterToApply, ref FileNameOutput, ForceImmediateRun: false, ref rsmess);
	}

	protected virtual modGeneral.FXRETURN ExecuteStatistic(Statistic MyStat, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			if (!_initialized)
			{
				rsmess = TranslateMessage("XXX", "L'engine statistico non è stato inizializzato");
			}
			else
			{
				fXRETURN2 = RunPreprocessing(MyStat, ref FilterToApply, ref FileNameOutput, ref rsmess);
				if (fXRETURN2 != 0)
				{
					fXRETURN = fXRETURN2;
				}
				else
				{
					if (Operators.CompareString(FileNameOutput, "", false) != 0)
					{
						goto IL_00ba;
					}
					if (MyStat.TipoStatistica == StatisticType.CSV)
					{
						fXRETURN2 = RunCsv(MyStat, FilterToApply, ref FileNameOutput, ref rsmess);
						if (fXRETURN2 == modGeneral.FXRETURN.OK)
						{
							goto IL_00ba;
						}
						fXRETURN = fXRETURN2;
					}
					else if (MyStat.TipoStatistica == StatisticType.PDF)
					{
						fXRETURN2 = RunPDF(MyStat, FilterToApply, ref FileNameOutput, ref rsmess);
						if (fXRETURN2 == modGeneral.FXRETURN.OK)
						{
							goto IL_00ba;
						}
						fXRETURN = fXRETURN2;
					}
					else
					{
						if (MyStat.TipoStatistica != StatisticType.XLS)
						{
							goto IL_00ba;
						}
						fXRETURN2 = RunXls(MyStat, FilterToApply, ref FileNameOutput, ref rsmess);
						if (fXRETURN2 == modGeneral.FXRETURN.OK)
						{
							goto IL_00ba;
						}
						fXRETURN = fXRETURN2;
					}
				}
			}
			goto end_IL_0004;
			IL_00ba:
			fXRETURN = modGeneral.FXRETURN.OK;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN EnqueueStatistic(Statistic MyStat, List<StatisticRunningFilter> FilterToApply, ref string rsmess)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			if (!_initialized)
			{
				rsmess = TranslateMessage("XXX", "L'engine statistico non è stato inizializzato");
			}
			else
			{
				JavaScriptSerializer val = new JavaScriptSerializer();
				string vsStringa = val.Serialize((object)FilterToApply);
				string text = "INSERT INTO WFI_Statistiche_Queue(CodiceStatistica, Utente, SelectionFormula, StatisticFilename, StatisticContentExtension, UteIns, UteAgg) VALUES (";
				text = text + DbConn.SQLFormatString(MyStat.Codice) + ", ";
				text = text + DbConn.SQLFormatString(_User + ";" + _Group + ";" + _Organization + ";" + _OrganizationType + ";" + _OrganizationInternalExternal + ";") + ", ";
				text = text + DbConn.SQLFormatString(vsStringa) + ", ";
				text = text + DbConn.SQLFormatString(MyStat.Codice + "_" + _User + "_*") + ", ";
				text = text + DbConn.SQLFormatString(MyStat.TipoStatistica.ToString().ToUpper()) + ", ";
				text = text + DbConn.SQLFormatString(_User) + ", ";
				text = text + DbConn.SQLFormatString(_User) + ") ";
				fXRETURN2 = DbConn.SqlExec(text, ref rsmess);
				fXRETURN = ((fXRETURN2 != 0) ? fXRETURN2 : modGeneral.FXRETURN.OK);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN RunPreprocessing(Statistic stat, ref List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			StatisticPreprocessing instance = StatisticPreprocessingFactory.GetInstance(stat.PreprocessingClassName, _ApiContext);
			if (instance == null)
			{
				rsmess = TranslateMessage("XXX", "Impossibile istanziare la classe di preprocesso configurata ({0})", stat.PreprocessingClassName);
			}
			else
			{
				fXRETURN2 = instance.StartPreProcessing(stat, ref FilterToApply, ref FileNameOutput, ref rsmess);
				fXRETURN = ((fXRETURN2 != 0) ? fXRETURN2 : modGeneral.FXRETURN.OK);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN RunCsv(Statistic stat, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			string text = "";
			string text2 = "";
			foreach (StatisticRunningFilter item in FilterToApply)
			{
				if (item.ValoreCampo != null)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						text += " AND ";
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						text2 += " e ";
					}
					text += item.NomeCampo;
					text2 += item.DescrizioneCampo;
					if (item.Operatore == StatisticOperatore.Uguale)
					{
						text += " = <%CAMPO%>";
						text2 += " uguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Maggiore)
					{
						text += " > <%CAMPO%>";
						text2 += " maggiore '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Minore)
					{
						text += " < <%CAMPO%>";
						text2 += " minore '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.MaggioreUguale)
					{
						text += " >= <%CAMPO%>";
						text2 += " maggiore o uguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.MinoreUguale)
					{
						text += " <= <%CAMPO%>";
						text2 += " minore o oguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Simile)
					{
						text += " like '%<%CAMPO_NON_FORMATTATO%>%'";
						text2 += " simile '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Diverso)
					{
						text += " <> <%CAMPO%>";
						text2 += " diverso da '<%CAMPO%>'";
					}
					if ((item.ValoreCampo is int) | (item.ValoreCampo is decimal) | (item.ValoreCampo is double) | (item.ValoreCampo is float) | (item.ValoreCampo is long))
					{
						string text3 = text;
						DBConnection dbConn = DbConn;
						decimal pNumero = Conversions.ToDecimal(item.ValoreCampo);
						text = text3.Replace("<%CAMPO%>", dbConn.SQLFormatNumber(ref pNumero));
					}
					else if (item.ValoreCampo is string)
					{
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
					}
					else if (item.ValoreCampo is DateTime)
					{
						DateTime dateTime = Conversions.ToDate(item.ValoreCampo);
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatDate(modGeneral.eTipoData.Data, Conversions.ToDate(item.ValoreCampo)));
					}
					else
					{
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
					}
					text = text.Replace("<%CAMPO_NON_FORMATTATO%>", item.ValoreCampo.ToString());
					text2 = text2.Replace("<%CAMPO%>", item.ValoreCampo.ToString());
				}
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessun filtro valido passato al modulo statistico. Impossibile lanciare la statistica");
			}
			else
			{
				IboCRW iboCRW = new IboCRW(ref _ApiContext);
				string vsNomeFileExport = stat.Codice + "_" + _User + "_*.csv";
				string rsNomeFileCompletoGenerato = (FileNameOutput = "");
				fXRETURN2 = iboCRW.ViewToCsvFile(stat.NomRep, vsNomeFileExport, text, text2, stat.Titolo, stat.Sottotitolo, IncludeColumnsName: true, ref rsNomeFileCompletoGenerato, ref rsmess);
				if (fXRETURN2 != 0)
				{
					fXRETURN = fXRETURN2;
				}
				else
				{
					FileNameOutput = rsNomeFileCompletoGenerato;
					fXRETURN = modGeneral.FXRETURN.OK;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN RunXls(Statistic stat, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			string text = "";
			string text2 = "";
			foreach (StatisticRunningFilter item in FilterToApply)
			{
				if (item.ValoreCampo != null)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						text += " AND ";
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						text2 += " e ";
					}
					text += item.NomeCampo;
					text2 += item.DescrizioneCampo;
					if (item.Operatore == StatisticOperatore.Uguale)
					{
						text += " = <%CAMPO%>";
						text2 += " uguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Maggiore)
					{
						text += " > <%CAMPO%>";
						text2 += " maggiore '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Minore)
					{
						text += " < <%CAMPO%>";
						text2 += " minore '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.MaggioreUguale)
					{
						text += " >= <%CAMPO%>";
						text2 += " maggiore o uguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.MinoreUguale)
					{
						text += " <= <%CAMPO%>";
						text2 += " minore o oguale '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Simile)
					{
						text += " like '%<%CAMPO_NON_FORMATTATO%>%'";
						text2 += " simile '<%CAMPO%>'";
					}
					else if (item.Operatore == StatisticOperatore.Diverso)
					{
						text += " <> <%CAMPO%>";
						text2 += " diverso da '<%CAMPO%>'";
					}
					if ((item.ValoreCampo is int) | (item.ValoreCampo is decimal) | (item.ValoreCampo is double) | (item.ValoreCampo is float) | (item.ValoreCampo is long))
					{
						string text3 = text;
						DBConnection dbConn = DbConn;
						decimal pNumero = Conversions.ToDecimal(item.ValoreCampo);
						text = text3.Replace("<%CAMPO%>", dbConn.SQLFormatNumber(ref pNumero));
					}
					else if (item.ValoreCampo is string)
					{
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
					}
					else if (item.ValoreCampo is DateTime)
					{
						DateTime dateTime = Conversions.ToDate(item.ValoreCampo);
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatDate(modGeneral.eTipoData.Data, Conversions.ToDate(item.ValoreCampo)));
					}
					else
					{
						text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
					}
					text = text.Replace("<%CAMPO_NON_FORMATTATO%>", item.ValoreCampo.ToString());
					text2 = text2.Replace("<%CAMPO%>", item.ValoreCampo.ToString());
				}
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessun filtro valido passato al modulo statistico. Impossibile lanciare la statistica");
			}
			else
			{
				IboCRW iboCRW = new IboCRW(ref _ApiContext);
				string vsNomeFileExport = stat.Codice + "_" + _User + "_*.html";
				string rsNomeFileCompletoGenerato = (FileNameOutput = "");
				fXRETURN2 = iboCRW.ViewToHtmlFile(stat.NomRep, vsNomeFileExport, text, text2, stat.Titolo, stat.Sottotitolo, IncludeColumnsName: true, ref rsNomeFileCompletoGenerato, ref rsmess);
				if (fXRETURN2 != 0)
				{
					fXRETURN = fXRETURN2;
				}
				else
				{
					FileNameOutput = rsNomeFileCompletoGenerato;
					fXRETURN = modGeneral.FXRETURN.OK;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN RunPDF(Statistic stat, List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			string text = "";
			string text2 = "";
			foreach (StatisticRunningFilter item in FilterToApply)
			{
				if (item.ValoreCampo == null)
				{
					continue;
				}
				if (!((item.ValoreCampo is int) | (item.ValoreCampo is decimal) | (item.ValoreCampo is double) | (item.ValoreCampo is float) | (item.ValoreCampo is long)))
				{
					if (item.ValoreCampo is string)
					{
						if (Operators.CompareString(item.ValoreCampo.ToString(), "", false) == 0)
						{
							continue;
						}
					}
					else if (item.ValoreCampo is DateTime)
					{
						if (Operators.CompareString(item.ValoreCampo.ToString(), "", false) == 0)
						{
							continue;
						}
					}
					else if (Operators.CompareString(item.ValoreCampo.ToString(), "", false) == 0)
					{
						continue;
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " AND ";
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 += " e ";
				}
				text = text + "{" + stat.NomTab + "." + item.NomeCampo + "}";
				text2 += item.DescrizioneCampo;
				if (item.Operatore == StatisticOperatore.Uguale)
				{
					text += " = <%CAMPO%>";
					text2 += " uguale '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.Maggiore)
				{
					text += " > <%CAMPO%>";
					text2 += " maggiore '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.Minore)
				{
					text += " < <%CAMPO%>";
					text2 += " minore '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.MaggioreUguale)
				{
					text += " >= <%CAMPO%>";
					text2 += " maggiore o uguale '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.MinoreUguale)
				{
					text += " <= <%CAMPO%>";
					text2 += " minore o oguale '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.Simile)
				{
					text += " like '%<%CAMPO_NON_FORMATTATO%>%'";
					text2 += " simile '<%CAMPO%>'";
				}
				else if (item.Operatore == StatisticOperatore.Diverso)
				{
					text += " <> <%CAMPO%>";
					text2 += " diverso da '<%CAMPO%>'";
				}
				if ((item.ValoreCampo is int) | (item.ValoreCampo is decimal) | (item.ValoreCampo is double) | (item.ValoreCampo is float) | (item.ValoreCampo is long))
				{
					string text3 = text;
					DBConnection dbConn = DbConn;
					decimal pNumero = Conversions.ToDecimal(item.ValoreCampo);
					text = text3.Replace("<%CAMPO%>", dbConn.SQLFormatNumber(ref pNumero));
				}
				else if (item.ValoreCampo is string)
				{
					text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
				}
				else if (item.ValoreCampo is DateTime)
				{
					DateTime dateTime = Conversions.ToDate(item.ValoreCampo);
					text = text.Replace("<%CAMPO%>", "Date(" + DateAndTime.Year(dateTime) + "," + DateAndTime.Month(dateTime) + "," + DateAndTime.Day(dateTime) + ")");
				}
				else
				{
					text = text.Replace("<%CAMPO%>", DbConn.SQLFormatString(item.ValoreCampo.ToString()));
				}
				text = text.Replace("<%CAMPO_NON_FORMATTATO%>", item.ValoreCampo.ToString());
				text2 = text2.Replace("<%CAMPO%>", item.ValoreCampo.ToString());
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessun filtro valido passato al modulo statistico. Impossibile lanciare la statistica");
			}
			else
			{
				IboCRW iboCRW = new IboCRW(ref _ApiContext);
				string vsNomeFileExport = stat.Codice + "_" + _User + "_*.PDF";
				string rsNomeFileCompletoGenerato = "";
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("ReportParams_CodiceStatistica", stat.Codice);
				dictionary.Add("ReportParams_Title", stat.Titolo);
				dictionary.Add("ReportParams_SubTitle", stat.Sottotitolo);
				string nomRep = stat.NomRep;
				string vsSelectionFormula = text;
				string vsHumanReadableSelectionFormula = text2;
				bool StampaAsincrona = false;
				fXRETURN2 = iboCRW.CrystalReportToPDF(nomRep, vsNomeFileExport, vsSelectionFormula, vsHumanReadableSelectionFormula, dictionary, ref rsNomeFileCompletoGenerato, ref StampaAsincrona, ref rsmess);
				if (fXRETURN2 != 0)
				{
					fXRETURN = fXRETURN2;
				}
				else
				{
					FileNameOutput = rsNomeFileCompletoGenerato;
					fXRETURN = modGeneral.FXRETURN.OK;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}

	protected modGeneral.FXRETURN StandardParser(string sComando, ref Dictionary<string, string> sRetColl, ref string rsMess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		modGeneral.FXRETURN result;
		try
		{
			string[] array = Strings.Split(sComando, ";", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					string[] array3 = Strings.Split(text, "=", -1, (CompareMethod)0);
					dictionary.Add(array3[0], array3[1]);
				}
			}
			fXRETURN = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsMess);
			dictionary = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			sRetColl = dictionary;
			result = fXRETURN;
		}
		return result;
	}

	protected string StandardNameFilter(string sNomeCampo)
	{
		string text = "";
		int[] array = null;
		text = sNomeCampo;
		text = Strings.Replace(text, "_", " ", 1, -1, (CompareMethod)0);
		checked
		{
			int num = text.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if (i > 0 && ((Operators.CompareString(Conversions.ToString(text[i]), "A", false) >= 0) & (Operators.CompareString(Conversions.ToString(text[i]), "Z", false) <= 0)) && !((Operators.CompareString(Conversions.ToString(text[i - 1]), "A", false) >= 0) & (Operators.CompareString(Conversions.ToString(text[i - 1]), "Z", false) <= 0)))
				{
					array = (int[])Utils.CopyArray((Array)array, (Array)new int[num2 + 1]);
					array[num2] = i;
					num2++;
				}
			}
			if (num2 > 0)
			{
				int upperBound = array.GetUpperBound(0);
				for (int j = 0; j <= upperBound; j++)
				{
					text = text.Insert(array[j] + j, " ");
				}
			}
			return text;
		}
	}
}
