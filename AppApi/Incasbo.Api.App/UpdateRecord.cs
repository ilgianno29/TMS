using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class UpdateRecord : AppAbstractApi
{
	protected string _TabellaOrigine;

	protected string _TabellaDestinazione;

	protected string _SqlWhere;

	protected StringCollection _ElencoCampiDaEscludere;

	protected StringCollection _ElencoCampiChiave;

	protected Dictionary<string, object> _ElencoCampiDaAggiungere;

	protected bool _DoUpdate;

	protected string _QueryToApply;

	public UpdateRecord(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TabellaOrigine = "";
		_TabellaDestinazione = "";
		_SqlWhere = "";
		_DoUpdate = true;
		_QueryToApply = "";
	}

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			ParametersOut.Add("QueryToApply", _QueryToApply);
			_TabellaOrigine = ParametersIn["TabellaOrigine"].ToString().ToUpper();
			_TabellaDestinazione = ParametersIn["TabellaDestinazione"].ToString().ToUpper();
			_ElencoCampiChiave = (StringCollection)ParametersIn["ElencoCampiChiave"];
			if (ParametersIn.ContainsKey("SqlWhere"))
			{
				_SqlWhere = ParametersIn["SqlWhere"].ToString();
			}
			if (ParametersIn.ContainsKey("ElencoCampiDaEscludere"))
			{
				_ElencoCampiDaEscludere = (StringCollection)ParametersIn["ElencoCampiDaEscludere"];
			}
			else
			{
				_ElencoCampiDaEscludere = new StringCollection();
			}
			if (ParametersIn.ContainsKey("ElencoCampiDaAggiungere"))
			{
				_ElencoCampiDaAggiungere = (Dictionary<string, object>)ParametersIn["ElencoCampiDaAggiungere"];
			}
			else
			{
				_ElencoCampiDaAggiungere = new Dictionary<string, object>();
			}
			if (ParametersIn.ContainsKey("DoUpdate"))
			{
				_DoUpdate = Conversions.ToBoolean(ParametersIn["DoUpdate"]);
			}
			fXRETURN2 = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected override modGeneral.FXRETURN Core(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		string text = "";
		string text2 = "";
		string text3 = "";
		StringCollection stringCollection = new StringCollection();
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				CallStackAdd();
				rsmess = "";
				StringEnumerator enumerator = _ElencoCampiDaEscludere.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (Operators.CompareString(current, "", false) != 0)
					{
						text2 = text2 + DbConn.SQLFormatString(current.ToUpper()) + ", ";
					}
				}
				text = "SELECT C1.COLUMN_NAME " + DbConn.StringConcatenateOperator() + " ', '  AS CAMPO  ";
				text += "FROM ELENCOCAMPITABELLA C1, ELENCOCAMPITABELLA C2 ";
				text = text + "WHERE UPPER(C1.TABLE_NAME)=" + DbConn.SQLFormatString(_TabellaOrigine) + " ";
				text = text + "AND UPPER(C2.TABLE_NAME)=" + DbConn.SQLFormatString(_TabellaDestinazione) + " ";
				text += "AND C2.IsIDentity=0 ";
				text += "AND UPPER(C1.COLUMN_NAME)=UPPER(C2.COLUMN_NAME) ";
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 2);
					text = text + " AND C1.COLUMN_NAME NOT IN(" + text2 + ")";
				}
				fXRETURN = DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = "Non esistono Campi Comuni nelle due Tabelle specificate.";
				}
				else
				{
					foreach (DataRow row in rObjDataTable.Rows)
					{
						text3 = Strings.Mid(row["CAMPO"].ToString(), 1, Strings.Len(row["CAMPO"].ToString()) - 2);
						stringCollection.Add(text3);
					}
					text = "SELECT * FROM " + _TabellaOrigine + " ";
					if (Operators.CompareString(_SqlWhere, "", false) != 0)
					{
						text = text + "WHERE " + _SqlWhere;
					}
					fXRETURN = DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
					if (fXRETURN != 0)
					{
						fXRETURN2 = fXRETURN;
					}
					else
					{
						text = "";
						foreach (DataRow row2 in rObjDataTable2.Rows)
						{
							text = text + "UPDATE " + _TabellaDestinazione + " SET ";
							StringEnumerator enumerator4 = stringCollection.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								string current2 = enumerator4.Current;
								text = text + current2 + "=" + DbConn.SQLFormat(RuntimeHelpers.GetObjectValue(row2[current2])) + ", ";
							}
							foreach (KeyValuePair<string, object> item in _ElencoCampiDaAggiungere)
							{
								text = text + item.Key + "=" + DbConn.SQLFormat(RuntimeHelpers.GetObjectValue(item.Value)) + ", ";
							}
							text = Strings.Mid(text, 1, Strings.Len(text) - 2);
							text += " WHERE 1=1 ";
							StringEnumerator enumerator6 = _ElencoCampiChiave.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								string current4 = enumerator6.Current;
								text = text + " AND " + current4 + "=" + DbConn.SQLFormatString(row2[current4].ToString()) + " ";
							}
							text += ";";
						}
						if (!_DoUpdate)
						{
							ParametersOut["QueryToApply"] = text;
							goto IL_0480;
						}
						fXRETURN = DbConn.SqlExec(text, ref rsmess);
						if (fXRETURN == modGeneral.FXRETURN.OK)
						{
							goto IL_0480;
						}
						fXRETURN2 = fXRETURN;
					}
				}
				goto end_IL_0025;
				IL_0480:
				fXRETURN2 = modGeneral.FXRETURN.OK;
				end_IL_0025:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				fXRETURN2 = HandleError(ref objEx, ref rsmess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				CallStackRemove();
				result = fXRETURN2;
			}
			return result;
		}
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TabellaOrigine, string TabellaDestinazione, string SqlWhere, ref StringCollection ElencoCampiChiave, ref StringCollection ElencoCampiDaEscludere, ref string rsmess)
	{
		UpdateRecord updateRecord = new UpdateRecord(objApiContext);
		updateRecord.ParametersIn.Add("TabellaOrigine", TabellaOrigine);
		updateRecord.ParametersIn.Add("TabellaDestinazione", TabellaDestinazione);
		updateRecord.ParametersIn.Add("SqlWhere", SqlWhere);
		updateRecord.ParametersIn.Add("ElencoCampiChiave", ElencoCampiChiave);
		updateRecord.ParametersIn.Add("ElencoCampiDaEscludere", ElencoCampiDaEscludere);
		return updateRecord.Run(ref rsmess);
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TabellaOrigine, string TabellaDestinazione, string SqlWhere, ref StringCollection ElencoCampiChiave, ref StringCollection ElencoCampiDaEscludere, ref Dictionary<string, object> ElencoCampiDaAggiungere, bool DoUpdate, ref string QueryToApply, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		UpdateRecord updateRecord = new UpdateRecord(objApiContext);
		updateRecord.ParametersIn.Add("TabellaOrigine", TabellaOrigine);
		updateRecord.ParametersIn.Add("TabellaDestinazione", TabellaDestinazione);
		updateRecord.ParametersIn.Add("SqlWhere", SqlWhere);
		updateRecord.ParametersIn.Add("ElencoCampiChiave", ElencoCampiChiave);
		updateRecord.ParametersIn.Add("ElencoCampiDaEscludere", ElencoCampiDaEscludere);
		updateRecord.ParametersIn.Add("ElencoCampiDaAggiungere", ElencoCampiDaAggiungere);
		updateRecord.ParametersIn.Add("DoUpdate", DoUpdate);
		fXRETURN = updateRecord.Run(ref rsmess);
		QueryToApply = updateRecord.ParametersOut["QueryToApply"].ToString();
		return fXRETURN;
	}
}
