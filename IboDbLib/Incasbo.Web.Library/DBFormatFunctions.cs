using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using static Incasbo.Web.Library.modGeneral;
namespace Incasbo.Web.Library;

[StandardModule]
public sealed class DBFormatFunctions
{
	public enum eServerType
	{
		SQL = 0,
		Oracle = 1,
		AS400 = 2,
		SQLite = 3,
		UnKnown = 99
	}

	public enum eProviderType
	{
		OleDb = 0,
		Odbc = 1,
		SqlClient = 2,
		MSOracleClient = 3,
		OracleClient = 4,
		SQLiteClient = 5,
		UnKnown = 99
	}

	public static string SQLFormat(eServerType veServerType, string vsValore, eTipoDati vTipo)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		string result = "";
		if (modGeneral.BaseTypeCheck(vsValore, vTipo))
		{
			if ((int)vTipo == 3)
			{
				result = SQLFormatDate(veServerType, (eTipoData)1, vsValore);
			}
			else if ((int)vTipo == 2 || (int)vTipo == 1)
			{
				result = SQLFormatNumber(veServerType, vsValore);
			}
			else if ((int)vTipo == 0)
			{
				result = SQLFormatString(veServerType, vsValore);
			}
			else if ((int)vTipo == 99)
			{
				result = "";
			}
		}
		return result;
	}

	public static string SQLFormat(eServerType veServerType, object objValore)
	{
		string text = "";
		if (((object)objValore.GetType() == typeof(int)) | ((object)objValore.GetType() == typeof(long)) | ((object)objValore.GetType() == typeof(short)) | ((object)objValore.GetType() == typeof(double)) | ((object)objValore.GetType() == typeof(float)) | ((object)objValore.GetType() == typeof(decimal)))
		{
			return SQLFormatNumber(veServerType, Conversions.ToDecimal(objValore));
		}
		if (((object)objValore.GetType() == typeof(DateTime)) | ((object)objValore.GetType() == typeof(DateTime)))
		{
			if (Operators.CompareString(objValore.ToString(), "", false) == 0)
			{
				return SQLFormatDate(veServerType, (eTipoData)2, objValore.ToString());
			}
			return SQLFormatDate(veServerType, (eTipoData)2, Conversions.ToDate(objValore));
		}
		return SQLFormatString(veServerType, objValore.ToString());
	}

	public static string SQLFormatDate(eServerType veServerType, eTipoData vTipoData, string vsData)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		string result = "NULL";
		if (Operators.CompareString(vsData, "", false) != 0)
		{
			DateTime vData = Convert.ToDateTime(vsData);
			result = SQLFormatDate(veServerType, vTipoData, vData);
		}
		return result;
	}

	public static string SQLFormatDate(eServerType veServerType, eTipoData vTipoData, DateTime vData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected I4, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected I4, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected I4, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected I4, but got Unknown
		string result = "NULL";
		DateTime dateTime = vData;
		if ((int)vTipoData != 3 && dateTime.Year < 1900)
		{
			dateTime = Convert.ToDateTime(dateTime.Day + "/" + dateTime.Month + "/" + DateTime.Now.Year);
		}
		switch (veServerType)
		{
		case eServerType.SQL:
			switch ((int)vTipoData - 1)
			{
			case 0:
				result = "'" + Strings.Format((object)dateTime, "MM/dd/yyyy") + "'";
				break;
			case 1:
				result = "'" + Strings.Replace(Strings.Format((object)dateTime, "MM/dd/yyyy HH:mm:ss"), ".", ":", 1, -1, (CompareMethod)0) + "'";
				break;
			case 3:
				result = "'" + Strings.Replace(Strings.Format((object)dateTime, "MM/dd/yyyy HH:mm:ss.fff"), ".", ":", 1, -1, (CompareMethod)0) + "'";
				break;
			case 2:
				result = "'" + Strings.Format((object)dateTime, "HH:mm:ss") + "'";
				break;
			}
			break;
		case eServerType.Oracle:
			switch ((int)vTipoData - 1)
			{
			case 0:
				result = "'" + Strings.Format((object)dateTime, "yyyy-MM-dd 00:00:00") + "'";
				break;
			case 1:
				result = "'" + Strings.Replace(Strings.Format((object)dateTime, "yyyy-MM-dd HH:mm:ss"), ".", ":", 1, -1, (CompareMethod)0) + "'";
				break;
			case 3:
				result = "'" + Strings.Format((object)dateTime, "yyyy-MM-dd HH:mm:ss.fff") + "'";
				result = "TO_TIMESTAMP(" + result + ", 'YYYY-MM-DD HH24:MI:SS.FF')";
				break;
			case 2:
				result = "TO_DATE('" + Strings.Format((object)dateTime, "HH:mm:ss") + "','HH24:MI:SS')";
				break;
			}
			break;
		case eServerType.AS400:
			switch ((int)vTipoData - 1)
			{
			case 0:
				result = "'" + Strings.Format((object)dateTime, "yyyy-MM-dd") + "'";
				break;
			case 1:
				result = "'" + Strings.Replace(Strings.Format((object)dateTime, "yyyy-MM-dd-HH:mm:ss"), ":", ".", 1, -1, (CompareMethod)0) + "'";
				break;
			case 3:
				result = "'" + Strings.Replace(Strings.Format((object)dateTime, "yyyy-MM-dd-HH:mm:ss.fff"), ":", ".", 1, -1, (CompareMethod)0) + "'";
				break;
			case 2:
				result = "'" + Strings.Format((object)dateTime, "HH:mm:ss") + "'";
				break;
			}
			break;
		case eServerType.SQLite:
			switch ((int)vTipoData - 1)
			{
			case 0:
				result = "datetime('" + Strings.Format((object)dateTime, "yyyy-MM-dd") + "')";
				break;
			case 1:
				result = "datetime('" + Strings.Format((object)dateTime, "yyyy-MM-dd HH:mm:ss") + "')";
				break;
			case 3:
				result = "datetime('" + Strings.Format((object)dateTime, "yyyy-MM-dd HH:mm:ss.fff") + "')";
				break;
			case 2:
				result = "datetime('" + Strings.Format((object)dateTime, "HH:mm:ss") + "')";
				break;
			}
			break;
		}
		return result;
	}

	public static string SQLFormatDate(eServerType veServerType, eTipoData vTipoData, DateTime? vData)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (vData.HasValue)
		{
			return SQLFormatDate(veServerType, vTipoData, vData.Value);
		}
		return "NULL";
	}

	public static string SQLFormatString(eServerType veServerType, string vsStringa)
	{
		if (vsStringa == null)
		{
			vsStringa = "";
		}
		if (Operators.CompareString(vsStringa, "", false) == 0)
		{
			return "NULL";
		}
		return "'" + vsStringa.Replace("'", "''") + "'";
	}

	public static string SQLFormatNumber(eServerType veServerType, string vsNumber)
	{
		string text = vsNumber;
		int num = Strings.InStr(text, ",", (CompareMethod)0);
		if (num > 0)
		{
			text = Strings.Replace(text, ",", ".", 1, -1, (CompareMethod)0);
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			return "NULL";
		}
		return text;
	}

	public static string SQLFormatNumber(eServerType veServerType, int viNumber)
	{
		return SQLFormatNumber(veServerType, viNumber.ToString());
	}

	public static string SQLFormatNumber(eServerType veServerType, long vlNumber)
	{
		return SQLFormatNumber(veServerType, vlNumber.ToString());
	}

	public static string SQLFormatNumber(eServerType veServerType, float vsNumber)
	{
		return SQLFormatNumber(veServerType, vsNumber.ToString());
	}

	public static string SQLFormatNumber(eServerType veServerType, double vdNumber)
	{
		return SQLFormatNumber(veServerType, vdNumber.ToString());
	}

	public static string SQLFormatNumber(eServerType veServerType, decimal vdNumber)
	{
		return SQLFormatNumber(veServerType, vdNumber.ToString());
	}
}
