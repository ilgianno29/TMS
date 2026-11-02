using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public abstract class AppDBObjectAbstractApi : AppAbstractApi
{
	protected string _DBObject;

	protected DataTable _BeforeImage;

	protected string[] _KeyFields;

	protected object[] _KeyValues;

	protected Dictionary<string, object> _FieldValues;

	protected string _SqlWhere;

	public AppDBObjectAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DBObject = "";
		_BeforeImage = null;
		_KeyFields = new string[0];
		_KeyValues = new object[0];
		_SqlWhere = "";
	}

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		DataTable dataTable = null;
		string text = "";
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (!ParametersIn.ContainsKey("DBObject"))
			{
				rsmess = "Obbligatorio inserire l'identificativo dell'oggetto DB";
			}
			else
			{
				_DBObject = ParametersIn["DBObject"].ToString();
				if (!ParametersIn.ContainsKey("KeyValues"))
				{
					rsmess = "Obbligatorio inserire la chiave dell'oggetto gestito";
				}
				else
				{
					_KeyValues = (object[])ParametersIn["KeyValues"];
					if (!ParametersIn.ContainsKey("KeyFields"))
					{
						rsmess = "Obbligatorio inserire i campi chiave dell'oggetto gestito";
					}
					else
					{
						_KeyFields = (string[])ParametersIn["KeyFields"];
						if (ParametersIn.ContainsKey("FieldValues"))
						{
							_FieldValues = (Dictionary<string, object>)ParametersIn["FieldValues"];
						}
						else
						{
							_FieldValues = new Dictionary<string, object>();
						}
						text = "SELECT * FROM " + _DBObject + " WHERE ";
						int num = 0;
						_SqlWhere = "";
						object[] keyValues = _KeyValues;
						for (int i = 0; i < keyValues.Length; i = checked(i + 1))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(keyValues[i]);
							_SqlWhere = _SqlWhere + _KeyFields[num] + "=";
							if (((object)objectValue.GetType() == typeof(short)) | ((object)objectValue.GetType() == typeof(int)) | ((object)objectValue.GetType() == typeof(long)) | ((object)objectValue.GetType() == typeof(decimal)) | ((object)objectValue.GetType() == typeof(double)) | ((object)objectValue.GetType() == typeof(float)))
							{
								string sqlWhere = _SqlWhere;
								DBConnection dbConn = DbConn;
								decimal pNumero = Conversions.ToDecimal(objectValue);
								_SqlWhere = sqlWhere + dbConn.SQLFormatNumber(ref pNumero);
							}
							else if (((object)objectValue.GetType() == typeof(DateTime)) | ((object)objectValue.GetType() == typeof(DateTime)))
							{
								_SqlWhere += DbConn.SQLFormatDate(modGeneral.eTipoData.DataOra, Conversions.ToDate(objectValue));
							}
							else
							{
								_SqlWhere += DbConn.SQLFormatString(objectValue.ToString());
							}
						}
						text += _SqlWhere;
						fXRETURN = DbConn.OpenDataTable(text, ref _BeforeImage, ref rsmess);
						if (fXRETURN != 0)
						{
							fXRETURN2 = fXRETURN;
						}
						else
						{
							if (_BeforeImage.Columns.Contains("UteIns") && !_FieldValues.ContainsKey("UteIns"))
							{
								_FieldValues.Add("UteIns", _User);
							}
							if (_BeforeImage.Columns.Contains("UteAgg") && !_FieldValues.ContainsKey("UteAgg"))
							{
								_FieldValues.Add("UteAgg", _User);
							}
							if (_BeforeImage.Columns.Contains("DatIns") && !_FieldValues.ContainsKey("DatIns"))
							{
								_FieldValues.Add("DatIns", DateAndTime.Now);
							}
							if (_BeforeImage.Columns.Contains("DatAgg") && !_FieldValues.ContainsKey("DatAgg"))
							{
								_FieldValues.Add("DatAgg", DateAndTime.Now);
							}
							if (_BeforeImage.Rows.Count > 0)
							{
								if (_FieldValues.ContainsKey("UteIns"))
								{
									_FieldValues.Remove("uteIns");
								}
								if (_FieldValues.ContainsKey("DatIns"))
								{
									_FieldValues.Remove("DatIns");
								}
							}
							fXRETURN2 = modGeneral.FXRETURN.OK;
						}
					}
				}
			}
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
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (_BeforeImage.Rows.Count > 0)
			{
				foreach (string key in _FieldValues.Keys)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(_FieldValues[key]);
					if (((object)objectValue.GetType() == typeof(short)) | ((object)objectValue.GetType() == typeof(int)) | ((object)objectValue.GetType() == typeof(long)) | ((object)objectValue.GetType() == typeof(decimal)) | ((object)objectValue.GetType() == typeof(double)) | ((object)objectValue.GetType() == typeof(float)))
					{
						if (decimal.Compare(Conversions.ToDecimal(objectValue), Conversions.ToDecimal(_BeforeImage.Rows[0][key])) != 0)
						{
							if (Operators.CompareString(text, "", false) != 0)
							{
								text += ",";
							}
							string text5 = text;
							DBConnection dbConn = DbConn;
							decimal pNumero = Conversions.ToDecimal(objectValue);
							text = text5 + key + "=" + dbConn.SQLFormatNumber(ref pNumero);
						}
					}
					else if (((object)objectValue.GetType() == typeof(DateTime)) | ((object)objectValue.GetType() == typeof(DateTime)))
					{
						if (DateTime.Compare(Conversions.ToDate(objectValue), Conversions.ToDate(_BeforeImage.Rows[0][key])) != 0)
						{
							if (Operators.CompareString(text, "", false) != 0)
							{
								text += ",";
							}
							text = text + key + "=" + DbConn.SQLFormatDate(modGeneral.eTipoData.DataOra, Conversions.ToDate(objectValue));
						}
					}
					else if (Operators.CompareString(objectValue.ToString(), _BeforeImage.Rows[0][key].ToString(), false) != 0)
					{
						if (Operators.CompareString(text, "", false) != 0)
						{
							text += ",";
						}
						text = text + key + "=" + DbConn.SQLFormatString(objectValue.ToString());
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					text4 = "UPDATE " + _DBObject + " SET " + text + " WHERE " + _SqlWhere;
				}
			}
			else
			{
				foreach (string key2 in _FieldValues.Keys)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(_FieldValues[key2]);
					if (Operators.CompareString(text2, "", false) != 0)
					{
						text2 += ",";
					}
					text2 += key2;
					if (Operators.CompareString(text3, "", false) != 0)
					{
						text3 += ",";
					}
					if (((object)objectValue2.GetType() == typeof(short)) | ((object)objectValue2.GetType() == typeof(int)) | ((object)objectValue2.GetType() == typeof(long)) | ((object)objectValue2.GetType() == typeof(decimal)) | ((object)objectValue2.GetType() == typeof(double)) | ((object)objectValue2.GetType() == typeof(float)))
					{
						string text6 = text3;
						DBConnection dbConn2 = DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue2);
						text3 = text6 + dbConn2.SQLFormatNumber(ref pNumero);
					}
					else
					{
						text3 = ((!(((object)objectValue2.GetType() == typeof(DateTime)) | ((object)objectValue2.GetType() == typeof(DateTime)))) ? (text3 + DbConn.SQLFormatString(objectValue2.ToString().Trim())) : (text3 + DbConn.SQLFormatDate(modGeneral.eTipoData.DataOra, Conversions.ToDate(objectValue2))));
					}
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text4 = "INSERT INTO " + _DBObject + "(" + text2 + ") VALUES (" + text3 + ")";
				}
			}
			if (Operators.CompareString(text4, "", false) == 0)
			{
				goto IL_04ff;
			}
			fXRETURN = DbConn.SqlExec(text4, ref rsmess);
			if (fXRETURN == modGeneral.FXRETURN.OK)
			{
				goto IL_04ff;
			}
			fXRETURN2 = fXRETURN;
			goto end_IL_001f;
			IL_04ff:
			fXRETURN2 = modGeneral.FXRETURN.OK;
			end_IL_001f:;
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
