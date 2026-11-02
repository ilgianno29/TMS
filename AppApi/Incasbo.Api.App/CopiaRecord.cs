using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class CopiaRecord : AppAbstractApi
{
	protected string _TabellaOrigine;

	protected string _TabellaDestinazione;

	protected string _SqlWhere;

	protected FieldsDictionary _ElencoCampiDaSostituire;

	protected FieldsDictionary _ElencoCampiDaAggiungere;

	protected StringCollection _ElencoCampiDaEscludere;

	protected bool _DeleteAfterInsert;

	protected bool _DoUpdate;

	protected string _QueryToApply;

	public CopiaRecord(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TabellaOrigine = "";
		_TabellaDestinazione = "";
		_SqlWhere = "";
		_DeleteAfterInsert = false;
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
			if (ParametersIn.ContainsKey("SqlWhere"))
			{
				_SqlWhere = ParametersIn["SqlWhere"].ToString();
			}
			if (ParametersIn.ContainsKey("ElencoCampiDaSostituire"))
			{
				_ElencoCampiDaSostituire = (FieldsDictionary)ParametersIn["ElencoCampiDaSostituire"];
			}
			else
			{
				_ElencoCampiDaSostituire = new FieldsDictionary();
			}
			if (ParametersIn.ContainsKey("ElencoCampiDaAggiungere"))
			{
				_ElencoCampiDaAggiungere = (FieldsDictionary)ParametersIn["ElencoCampiDaAggiungere"];
			}
			else
			{
				_ElencoCampiDaAggiungere = new FieldsDictionary();
			}
			if (ParametersIn.ContainsKey("ElencoCampiDaEscludere"))
			{
				_ElencoCampiDaEscludere = (StringCollection)ParametersIn["ElencoCampiDaEscludere"];
			}
			else
			{
				_ElencoCampiDaEscludere = new StringCollection();
			}
			if (ParametersIn.ContainsKey("DeleteAfterInsert"))
			{
				_DeleteAfterInsert = Conversions.ToBoolean(ParametersIn["DeleteAfterInsert"]);
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
		string text4 = "";
		string text5 = "";
		DataTable rObjDataTable = null;
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
						text4 = text4 + DbConn.SQLFormatString(current.ToUpper()) + ", ";
					}
				}
				text = "SELECT C1.COLUMN_NAME " + DbConn.StringConcatenateOperator() + " ', '  AS CAMPO  ";
				text += "FROM ELENCOCAMPITABELLA C1, ELENCOCAMPITABELLA C2 ";
				text = text + "WHERE UPPER(C1.TABLE_NAME)=" + DbConn.SQLFormatString(_TabellaOrigine) + " ";
				text = text + "AND UPPER(C2.TABLE_NAME)=" + DbConn.SQLFormatString(_TabellaDestinazione) + " ";
				text += "AND C2.IsIDentity=0 ";
				text += "AND UPPER(C1.COLUMN_NAME)=UPPER(C2.COLUMN_NAME) ";
				if (Operators.CompareString(text4, "", false) != 0)
				{
					text4 = Strings.Mid(text4, 1, Strings.Len(text4) - 2);
					text = text + " AND UPPER(C1.COLUMN_NAME) NOT IN(" + text4 + ")";
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
						text5 = Strings.Mid(row["CAMPO"].ToString(), 1, Strings.Len(row["CAMPO"].ToString()) - 2);
						if (_ElencoCampiDaSostituire.ContainsKey(text5))
						{
							text2 += row["CAMPO"].ToString();
							text3 = text3 + _ElencoCampiDaSostituire[text5] + ", ";
						}
						else
						{
							text2 += row["CAMPO"].ToString();
							text3 += row["CAMPO"].ToString();
						}
					}
					foreach (KeyValuePair<string, string> item in _ElencoCampiDaAggiungere)
					{
						text2 = text2 + item.Key + ", ";
						text3 = text3 + item.Value + ", ";
					}
					text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 2);
					text3 = Strings.Mid(text3, 1, Strings.Len(text3) - 2);
					text = "INSERT INTO " + _TabellaDestinazione;
					text = text + "(" + text2 + ") ";
					text = text + "SELECT " + text3 + " ";
					text = text + "FROM " + _TabellaOrigine + " ";
					if (Operators.CompareString(_SqlWhere, "", false) != 0)
					{
						text = text + "WHERE " + _SqlWhere;
					}
					text += "; ";
					if (_DeleteAfterInsert)
					{
						text = text + "DELETE FROM " + _TabellaOrigine + " ";
						if (Operators.CompareString(_SqlWhere, "", false) != 0)
						{
							text = text + "WHERE " + _SqlWhere;
						}
						text += "; ";
					}
					if (!_DoUpdate)
					{
						ParametersOut["QueryToApply"] = text;
						goto IL_0406;
					}
					fXRETURN = DbConn.SqlExec(text, ref rsmess);
					if (fXRETURN == modGeneral.FXRETURN.OK)
					{
						goto IL_0406;
					}
					fXRETURN2 = fXRETURN;
				}
				goto end_IL_0029;
				IL_0406:
				fXRETURN2 = modGeneral.FXRETURN.OK;
				end_IL_0029:;
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

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TabellaOrigine, string TabellaDestinazione, string SqlWhere, ref FieldsDictionary ElencoCampiDaSostituire, ref StringCollection ElencoCampiDaEscludere, bool DeleteAfterInsert, ref string rsmess)
	{
		CopiaRecord copiaRecord = new CopiaRecord(objApiContext);
		copiaRecord.ParametersIn.Add("TabellaOrigine", TabellaOrigine);
		copiaRecord.ParametersIn.Add("TabellaDestinazione", TabellaDestinazione);
		copiaRecord.ParametersIn.Add("SqlWhere", SqlWhere);
		copiaRecord.ParametersIn.Add("ElencoCampiDaSostituire", ElencoCampiDaSostituire);
		copiaRecord.ParametersIn.Add("ElencoCampiDaEscludere", ElencoCampiDaEscludere);
		copiaRecord.ParametersIn.Add("DeleteAfterInsert", DeleteAfterInsert);
		return copiaRecord.Run(ref rsmess);
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TabellaOrigine, string TabellaDestinazione, string SqlWhere, ref FieldsDictionary ElencoCampiDaSostituire, ref StringCollection ElencoCampiDaEscludere, bool DeleteAfterInsert, bool DoUpdate, ref string QueryToApply, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		CopiaRecord copiaRecord = new CopiaRecord(objApiContext);
		copiaRecord.ParametersIn.Add("TabellaOrigine", TabellaOrigine);
		copiaRecord.ParametersIn.Add("TabellaDestinazione", TabellaDestinazione);
		copiaRecord.ParametersIn.Add("SqlWhere", SqlWhere);
		copiaRecord.ParametersIn.Add("ElencoCampiDaSostituire", ElencoCampiDaSostituire);
		copiaRecord.ParametersIn.Add("ElencoCampiDaEscludere", ElencoCampiDaEscludere);
		copiaRecord.ParametersIn.Add("DeleteAfterInsert", DeleteAfterInsert);
		copiaRecord.ParametersIn.Add("DoUpdate", DoUpdate);
		fXRETURN = copiaRecord.Run(ref rsmess);
		QueryToApply = copiaRecord.ParametersOut["QueryToApply"].ToString();
		return fXRETURN;
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TabellaOrigine, string TabellaDestinazione, string SqlWhere, ref FieldsDictionary ElencoCampiDaSostituire, ref StringCollection ElencoCampiDaEscludere, ref FieldsDictionary ElencoCampiDaAggiungere, bool DeleteAfterInsert, bool DoUpdate, ref string QueryToApply, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		CopiaRecord copiaRecord = new CopiaRecord(objApiContext);
		copiaRecord.ParametersIn.Add("TabellaOrigine", TabellaOrigine);
		copiaRecord.ParametersIn.Add("TabellaDestinazione", TabellaDestinazione);
		copiaRecord.ParametersIn.Add("SqlWhere", SqlWhere);
		copiaRecord.ParametersIn.Add("ElencoCampiDaSostituire", ElencoCampiDaSostituire);
		copiaRecord.ParametersIn.Add("ElencoCampiDaEscludere", ElencoCampiDaEscludere);
		copiaRecord.ParametersIn.Add("ElencoCampiDaAggiungere", ElencoCampiDaAggiungere);
		copiaRecord.ParametersIn.Add("DeleteAfterInsert", DeleteAfterInsert);
		copiaRecord.ParametersIn.Add("DoUpdate", DoUpdate);
		fXRETURN = copiaRecord.Run(ref rsmess);
		QueryToApply = copiaRecord.ParametersOut["QueryToApply"].ToString();
		return fXRETURN;
	}
}
