using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class PlanGridFilter
{
	protected DBConnection _DbConn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _FieldValue;

	public string Id { get; set; }

	public string FieldName { get; set; }

	public object FieldValue
	{
		[CompilerGenerated]
		get
		{
			return _FieldValue;
		}
		[CompilerGenerated]
		set
		{
			_FieldValue = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string FieldDescription { get; set; }

	public string FieldType { get; set; }

	public string FilterExpression { get; set; }

	public string FilterExpressionHR { get; set; }

	public PlanGridFilter(DBConnection dbConn)
	{
		Id = "";
		FieldName = "";
		FieldValue = null;
		FieldDescription = "";
		FieldType = "";
		FilterExpression = "";
		FilterExpressionHR = "";
		_DbConn = dbConn;
	}

	public void Reset()
	{
		FilterExpression = "";
		FilterExpressionHR = "";
	}

	public void AddFilter(string FieldOperator, object FieldValue)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		switch (FieldOperator)
		{
		case "LIKE":
			text = " LIKE '%<VALUE>%'";
			text2 = " contiene '<VALUE>'";
			break;
		case "=":
			text = " = <VALUE>";
			text2 = " uguale a <VALUE>";
			break;
		case "!=":
			text = " <> <VALUE>";
			text2 = " diverso da <VALUE>";
			break;
		case "gt=":
			text = " >= <VALUE>";
			text2 = " maggiore o uguale a <VALUE>";
			break;
		case "gt":
			text = " > <VALUE>";
			text2 = " maggiore di <VALUE>";
			break;
		case "lt=":
			text = " <= <VALUE>";
			text2 = " minore o uguale di <VALUE>";
			break;
		case "lt":
			text = " < <VALUE>";
			text2 = " minore di <VALUE>";
			break;
		case "ISNULL":
			text = " IS NULL ";
			text2 = " è vuoto ";
			break;
		case "ISNOTNULL":
			text = " IS NOT NULL ";
			text2 = " non è vuoto ";
			break;
		case "BEGIN":
			text = " LIKE '<VALUE>%'";
			text2 = " inizia per <VALUE>";
			break;
		case "NOTBEGIN":
			text = " NOT LIKE '<VALUE>%'";
			text2 = " non inizia per <VALUE>";
			break;
		case "END":
			text = " LIKE '%<VALUE>'";
			text2 = " finisce per <VALUE>";
			break;
		case "NOTEND":
			text = " NOT LIKE '%<VALUE>'";
			text2 = " non finisce per <VALUE>";
			break;
		case "IN":
			text = " IN (<VALUE>)";
			break;
		}
		if (text.Contains("LIKE"))
		{
			text3 = FieldValue.ToString().Replace("'", "''");
			text4 = FieldValue.ToString();
		}
		else if ((Operators.CompareString(FieldType, typeof(int).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(long).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(short).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(double).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(float).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(decimal).ToString(), false) == 0))
		{
			DBConnection dbConn = _DbConn;
			decimal num = Conversions.ToDecimal(FieldValue);
			text3 = dbConn.SQLFormatNumber(ref num);
			text4 = FieldValue.ToString();
		}
		else if ((Operators.CompareString(FieldType, typeof(DateTime).ToString(), false) == 0) | (Operators.CompareString(FieldType, typeof(DateTime).ToString(), false) == 0))
		{
			text3 = _DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(FieldValue));
			text4 = FieldValue.ToString();
		}
		else
		{
			text3 = ((Operators.CompareString(FieldOperator, "IN", false) == 0) ? FieldValue.ToString() : _DbConn.SQLFormatString(FieldValue.ToString()));
			text4 = "\"" + FieldValue.ToString() + "\"";
		}
		text5 = "(" + FieldName + text.Replace("<VALUE>", text3) + ")";
		text6 = "(" + FieldDescription + text2.Replace("<VALUE>", text4) + ")";
		if (Operators.CompareString(FilterExpression, "", false) != 0)
		{
			FilterExpression += " AND ";
			FilterExpressionHR += " e ";
		}
		FilterExpression += text5;
		FilterExpressionHR += text6;
	}

	public void SaveContext(string FieldName, string FieldDescription, string _type)
	{
		this.FieldName = FieldName;
		this.FieldDescription = FieldDescription;
		if (!_type.ToUpper().Contains("SYSTEM"))
		{
			_type = "System." + _type;
		}
		FieldType = _type;
	}
}
