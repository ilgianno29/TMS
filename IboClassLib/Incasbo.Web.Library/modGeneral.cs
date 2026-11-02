using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

[StandardModule]
public sealed class modGeneral
{
	public enum FXRETURN
	{
		OK,
		DatabaseFail,
		DatabaseError,
		GenericError,
		UserError,
		ProgramError,
		HardwareError,
		DeviceError,
		PrimaryKeyViolation,
		ForeignKeyViolation,
		CheckViolation,
		ProcessDeadLock,
		ProcessTimeOut,
		TransactionFail,
		NoDataFound,
		ToManyRow,
		ConfigurationError,
		ContinueWithError,
		NotImplemented
	}

	public enum eTipoDati
	{
		TDString = 0,
		TDInteger = 1,
		TDDecimal = 2,
		TDDateTime = 3,
		TDBoolean = 4,
		TDUnknown = 99
	}

	public enum eTipoData
	{
		Data = 1,
		DataOra,
		Ora,
		DataOraMillesimiSecondo
	}

	[SpecialName]
	private static Random _0024STATIC_0024GetRandomInteger_002402888_0024Generator;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init = new StaticLocalInitFlag();

	public static bool BaseTypeCheck(string vsValore, eTipoDati vTipo)
	{
		bool result = true;
		try
		{
			switch (vTipo)
			{
			case eTipoDati.TDDateTime:
			{
				DateTime dateTime = Conversions.ToDate(vsValore);
				break;
			}
			case eTipoDati.TDDecimal:
			{
				double num2 = Conversions.ToDouble(vsValore);
				break;
			}
			case eTipoDati.TDInteger:
			{
				float num = Conversions.ToInteger(vsValore);
				break;
			}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static eTipoDati DataTypeToBaseType(Type vtDataType)
	{
		switch (vtDataType.Name)
		{
		case "String":
		case "Char":
			return eTipoDati.TDString;
		case "DateTime":
		case "TimeSpan":
			return eTipoDati.TDDateTime;
		case "Byte":
		case "SByte":
		case "Int16":
		case "Int32":
		case "Int64":
		case "UInt16":
		case "UInt32":
		case "UInt64":
			return eTipoDati.TDInteger;
		case "Decimal":
		case "Double":
		case "Single":
			return eTipoDati.TDDecimal;
		default:
			return eTipoDati.TDUnknown;
		}
	}

	public static Enum String2Enum(Type TypeEnum, string Name)
	{
		return (Enum)NewLateBinding.LateIndexGet((object)Enum.GetValues(TypeEnum), new object[1] { Array.IndexOf(Enum.GetNames(TypeEnum), Name) }, (string[])null);
	}

	public static bool StringToFile(string vsFileName, string vsContent, ref string rsMess)
	{
		StreamWriter streamWriter = null;
		bool flag = false;
		bool flag2 = default(bool);
		bool result;
		try
		{
			rsMess = "";
			streamWriter = File.AppendText(vsFileName);
			flag2 = true;
			streamWriter.WriteLine(vsContent);
			flag = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag2)
			{
				streamWriter.Close();
				flag2 = false;
			}
			streamWriter = null;
			result = flag;
		}
		return result;
	}

	public static bool StringFromFile(string vsFileName, ref string rsContent, ref string rsMess)
	{
		StreamReader streamReader = null;
		bool flag = false;
		bool flag2 = default(bool);
		bool result;
		try
		{
			rsMess = "";
			streamReader = new StreamReader(vsFileName);
			flag2 = true;
			rsContent = streamReader.ReadToEnd();
			flag = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag2)
			{
				streamReader.Close();
				flag2 = false;
			}
			streamReader = null;
			result = flag;
		}
		return result;
	}

	public static Color HTMLColorToSystemColor(string vsHTMLColor)
	{
		ColorConverter colorConverter = new ColorConverter();
		Color result = (Color)colorConverter.ConvertFromString(vsHTMLColor);
		colorConverter = null;
		return result;
	}

	public static bool ExistsFieldInDatarow(ref DataRow dr, string Field)
	{
		bool flag = false;
		if (dr.Table == null)
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(dr[Field]);
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				flag = false;
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			flag = dr.Table.Columns.Contains(Field);
		}
		return flag;
	}

	public static bool ExistsFieldInDatarow2(ref DataRow dr, string Field)
	{
		DataTable dt = dr.Table;
		return ExistsFieldInDatatable(ref dt, Field);
	}

	public static bool ExistsFieldInDatatable(ref DataTable dt, string Field)
	{
		bool flag = false;
		return dt.Columns.Contains(Field);
	}

	public static void CloneDataTable(DataTable dtSource, ref DataTable dtDestination)
	{
		dtDestination = dtSource.Clone();
		foreach (DataRow row in dtSource.Rows)
		{
			dtDestination.ImportRow(row);
		}
	}

	public static void CloneDataTable(DataTable dtSource, string FilterExpression, string sort, ref DataTable dtDestination)
	{
		dtDestination = dtSource.Clone();
		DataRow[] array = dtSource.Select(FilterExpression, sort);
		DataRow[] array2 = array;
		foreach (DataRow row in array2)
		{
			dtDestination.ImportRow(row);
		}
	}

	public static void ConvertDataTableToList<t>(DataTable d, ref List<t> l)
	{
		foreach (DataRow row in d.Rows)
		{
			t val = Conversions.ToGenericParameter<t>(RuntimeHelpers.GetObjectValue(typeof(t).GetConstructor(new Type[0]).Invoke(new object[0])));
			PropertyInfo[] properties = val.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (d.Columns.Contains(propertyInfo.Name) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[propertyInfo.Name])))
				{
					IncasReflection.SetPropertyValue(val, propertyInfo.Name, RuntimeHelpers.GetObjectValue(row[propertyInfo.Name]));
				}
			}
			l.Add(val);
		}
	}

	public static DataTable ConvertListToDataTable<t>(IList<t> list)
	{
		DataTable dataTable = new DataTable();
		DataTable result;
		try
		{
			PropertyInfo[] properties = typeof(t).GetProperties(BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				DataColumn dataColumn;
				if (propertyInfo.PropertyType.FullName.StartsWith("System.Nullable"))
				{
					string text = Strings.Mid(propertyInfo.PropertyType.FullName, checked(Strings.InStr(propertyInfo.PropertyType.FullName, "[[", (CompareMethod)1) + 2));
					text = text.Split(new char[1] { ',' })[0];
					dataColumn = new DataColumn(propertyInfo.Name, Type.GetType(text));
					dataColumn.AllowDBNull = true;
				}
				else
				{
					dataColumn = new DataColumn(propertyInfo.Name, propertyInfo.PropertyType);
				}
				dataTable.Columns.Add(dataColumn);
			}
			foreach (t item in list)
			{
				DataRow dataRow = dataTable.NewRow();
				PropertyInfo[] array2 = properties;
				foreach (PropertyInfo propertyInfo2 in array2)
				{
					PropertyInfo property = item.GetType().GetProperty(propertyInfo2.Name);
					if (property.GetValue(item, null) != null)
					{
						dataRow[propertyInfo2.Name] = RuntimeHelpers.GetObjectValue(property.GetValue(item, null));
					}
				}
				dataTable.Rows.Add(dataRow);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = dataTable;
		}
		return result;
	}

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static string TrimDoubleSpace(string str)
	{
		Regex regex = new Regex(" +");
		return regex.Replace(str, " ");
	}

	public static int IncasDayOfWeek(DateTime dte)
	{
		if (dte.DayOfWeek == DayOfWeek.Monday)
		{
			return 1;
		}
		if (dte.DayOfWeek == DayOfWeek.Tuesday)
		{
			return 2;
		}
		if (dte.DayOfWeek == DayOfWeek.Wednesday)
		{
			return 3;
		}
		if (dte.DayOfWeek == DayOfWeek.Thursday)
		{
			return 4;
		}
		if (dte.DayOfWeek == DayOfWeek.Friday)
		{
			return 5;
		}
		if (dte.DayOfWeek == DayOfWeek.Saturday)
		{
			return 6;
		}
		if (dte.DayOfWeek == DayOfWeek.Sunday)
		{
			return 7;
		}
		int result = default(int);
		return result;
	}

	public static decimal EnsureIsDecimal(object obj)
	{
		if ((object)obj.GetType() == typeof(string))
		{
			string text = obj.ToString().Replace(",", ".");
			string[] array = text.Split(new char[1] { '.' });
			if (array.Length == 1)
			{
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[2]);
				array[1] = "0";
			}
			return decimal.Add(Conversions.ToDecimal(array[0]), decimal.Divide(Conversions.ToDecimal(array[1]), new decimal(Math.Pow(10.0, array[1].Length))));
		}
		return Conversions.ToDecimal(obj);
	}

	public static int IncasWeekOfYear(DateTime data, string CultureInfo)
	{
		CultureInfo cultureInfo = new CultureInfo(CultureInfo);
		DateTimeFormatInfo dateTimeFormat = cultureInfo.DateTimeFormat;
		Calendar calendar = cultureInfo.Calendar;
		dateTimeFormat.CalendarWeekRule = CalendarWeekRule.FirstFourDayWeek;
		return calendar.GetWeekOfYear(data, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
	}

	public static int IncasWeekOfYear(DateTime data)
	{
		return IncasWeekOfYear(data, "it-IT");
	}

	public static int IncasWeekOfYear(int yearVal)
	{
		DateTime data = new DateTime(yearVal, 12, 31);
		return IncasWeekOfYear(data, "it-IT");
	}

	public static DateTime IncasFirstDateOfWeek(int yearVal, int WeekNumber)
	{
		DateTime dateTime = new DateTime(yearVal, 1, 1);
		byte b = 0;
		DateTime dateTime2 = default(DateTime);
		checked
		{
			b = (byte)dateTime.DayOfWeek;
			byte b2 = b;
			switch (b2)
			{
			case 0:
				dateTime2 = dateTime.AddDays(-6.0);
				break;
			case 1:
				dateTime2 = dateTime;
				break;
			default:
				if (unchecked((uint)b2) > 1u)
				{
					dateTime2 = dateTime.AddDays(-(b - 1));
				}
				break;
			}
			return dateTime2.AddDays(7 * (WeekNumber - 1));
		}
	}

	public static int GetRandomInteger(int Min, int Max)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init, ref lockTaken);
			if (_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init.State == 0)
			{
				_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init.State = 2;
				_0024STATIC_0024GetRandomInteger_002402888_0024Generator = new Random();
			}
			else if (_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GetRandomInteger_002402888_0024Generator_0024Init);
			}
		}
		return _0024STATIC_0024GetRandomInteger_002402888_0024Generator.Next(Min, Max);
	}

	public static Stream StringToStream(string input, Encoding enc)
	{
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream, enc);
		streamWriter.Write(input);
		streamWriter.Flush();
		memoryStream.Position = 0L;
		return memoryStream;
	}
}
