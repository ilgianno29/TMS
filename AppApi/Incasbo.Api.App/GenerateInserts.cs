using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class GenerateInserts : AppAbstractApi
{
	protected DataTable _datatable;

	protected string _TableName;

	protected string _TableNameDescription;

	protected string _DeleteWhereCondition;

	protected bool _DeleteBefore;

	protected StringCollection _sqlInserts;

	protected DBFormatFunctions.eServerType _ServerType;

	public GenerateInserts(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TableName = "";
		_TableNameDescription = "";
		_DeleteWhereCondition = "";
		_DeleteBefore = false;
		_sqlInserts = new StringCollection();
		_ServerType = DBFormatFunctions.eServerType.SQL;
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
			_datatable = (DataTable)ParametersIn["DataTable"];
			_TableName = ParametersIn["TableName"].ToString();
			_TableNameDescription = ParametersIn["TableNameDescription"].ToString();
			_DeleteBefore = Conversions.ToBoolean(ParametersIn["DeleteBefore"]);
			_DeleteWhereCondition = ParametersIn["DeleteWhereCondition"].ToString();
			_ServerType = (DBFormatFunctions.eServerType)ParametersIn["ServerType"];
			ParametersOut.Add("SqlInserts", null);
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
		checked
		{
			modGeneral.FXRETURN result;
			try
			{
				CallStackAdd();
				rsmess = "";
				_sqlInserts.Add("--");
				_sqlInserts.Add("-- " + _TableNameDescription);
				_sqlInserts.Add("--");
				if (_ServerType == DBFormatFunctions.eServerType.SQL)
				{
					_sqlInserts.Add("SET LANGUAGE US_ENGLISH; SET DATEFORMAT mdy;");
					_sqlInserts.Add("BEGIN TRAN");
				}
				else if (_ServerType == DBFormatFunctions.eServerType.Oracle)
				{
					_sqlInserts.Add("ALTER SESSION SET NLS_NUMERIC_CHARACTERS = '.,' NLS_LANGUAGE='AMERICAN' NLS_TERRITORY='AMERICA' NLS_DATE_FORMAT='YYYY-MM-DD HH24:MI:SS' NLS_SORT='BINARY';");
				}
				if (_DeleteBefore)
				{
					string text2 = "DELETE FROM " + _TableName;
					if (Operators.CompareString(_DeleteWhereCondition, "", false) != 0)
					{
						text2 = text2 + " WHERE (" + _DeleteWhereCondition + ")";
					}
					_sqlInserts.Add(text2 + ";");
				}
				foreach (DataRow row in _datatable.Rows)
				{
					string text3 = "";
					string text4 = "";
					foreach (DataColumn column in _datatable.Columns)
					{
						if ((object)column.DataType == typeof(string))
						{
							text3 = text3 + column.ColumnName + ",";
							text4 = text4 + DBFormatFunctions.SQLFormatString(_ServerType, row[column.ColumnName].ToString()) + ",";
						}
						else if ((object)column.DataType == typeof(DateTime))
						{
							text3 = text3 + column.ColumnName + ",";
							text4 = ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[column.ColumnName]))) ? (text4 + DBFormatFunctions.SQLFormatDate(_ServerType, modGeneral.eTipoData.DataOra, (DateTime?)row[column.ColumnName]) + ",") : (text4 + "NULL,"));
						}
						else if (((object)column.DataType == typeof(decimal)) | ((object)column.DataType == typeof(double)) | ((object)column.DataType == typeof(int)) | ((object)column.DataType == typeof(float)) | ((object)column.DataType == typeof(long)) | ((object)column.DataType == typeof(int)) | ((object)column.DataType == typeof(short)) | ((object)column.DataType == typeof(byte)))
						{
							text3 = text3 + column.ColumnName + ",";
							text4 = ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[column.ColumnName]))) ? (text4 + DBFormatFunctions.SQLFormatNumber(_ServerType, Conversions.ToDecimal(row[column.ColumnName])) + ",") : (text4 + "NULL,"));
						}
						else if ((object)column.DataType != typeof(byte[]))
						{
							text3 = text3 + column.ColumnName + ",";
							text4 = text4 + DBFormatFunctions.SQLFormatString(_ServerType, row[column.ColumnName].ToString()) + ",";
						}
					}
					text3 = Strings.Left(text3, Strings.Len(text3) - 1);
					text4 = Strings.Left(text4, Strings.Len(text4) - 1);
					text = "INSERT INTO " + _TableName + " (" + text3 + ") VALUES (" + text4 + ");";
					_sqlInserts.Add(text);
				}
				_sqlInserts.Add("COMMIT;");
				ParametersOut["SqlInserts"] = _sqlInserts;
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
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TableName, string TableNameDescription, DataTable DataTable, bool DeleteBefore, DBFormatFunctions.eServerType ServerType, ref StringCollection SqlInserts, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			GenerateInserts generateInserts = new GenerateInserts(objApiContext);
			generateInserts.ParametersIn.Add("TableName", TableName);
			generateInserts.ParametersIn.Add("TableNameDescription", TableNameDescription);
			generateInserts.ParametersIn.Add("DataTable", DataTable);
			generateInserts.ParametersIn.Add("DeleteBefore", DeleteBefore);
			generateInserts.ParametersIn.Add("DeleteWhereCondition", "");
			generateInserts.ParametersIn.Add("ServerType", ServerType);
			fXRETURN = generateInserts.Run(ref rsmess);
			if (fXRETURN != 0)
			{
				fXRETURN2 = fXRETURN;
			}
			else
			{
				SqlInserts = (StringCollection)generateInserts.ParametersOut["SqlInserts"];
				fXRETURN2 = modGeneral.FXRETURN.OK;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN2;
		}
		return result;
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string TableName, string TableNameDescription, DataTable DataTable, bool DeleteBefore, string DeleteWhereCondition, DBFormatFunctions.eServerType ServerType, ref StringCollection SqlInserts, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			GenerateInserts generateInserts = new GenerateInserts(objApiContext);
			generateInserts.ParametersIn.Add("TableName", TableName);
			generateInserts.ParametersIn.Add("TableNameDescription", TableNameDescription);
			generateInserts.ParametersIn.Add("DataTable", DataTable);
			generateInserts.ParametersIn.Add("DeleteBefore", DeleteBefore);
			generateInserts.ParametersIn.Add("DeleteWhereCondition", DeleteWhereCondition);
			generateInserts.ParametersIn.Add("ServerType", ServerType);
			fXRETURN = generateInserts.Run(ref rsmess);
			if (fXRETURN != 0)
			{
				fXRETURN2 = fXRETURN;
			}
			else
			{
				SqlInserts = (StringCollection)generateInserts.ParametersOut["SqlInserts"];
				fXRETURN2 = modGeneral.FXRETURN.OK;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN2;
		}
		return result;
	}
}
