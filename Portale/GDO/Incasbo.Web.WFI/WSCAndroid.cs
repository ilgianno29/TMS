using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WSCAndroid : WFIAspxRemoteService
{
	protected string _WSCCommand;

	protected Dictionary<string, string> _ParametersIN;

	protected Dictionary<string, string> _ParametersOUT;

	protected string _prefisso;

	[field: AccessedThroughProperty("Head1")]
	protected virtual HtmlHead Head1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("form1")]
	protected virtual HtmlForm form1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WSCAndroid()
	{
		_WSCCommand = "";
		_ParametersIN = new Dictionary<string, string>();
		_ParametersOUT = new Dictionary<string, string>();
		_prefisso = "##WSC##";
	}

	protected override FXRETURN ElabRequest(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = "";
			string inputCommand = _InputCommand;
			StringReader stringReader = new StringReader(_InputCommand);
			text = stringReader.ReadLine();
			if (text.StartsWith("##WSC##"))
			{
				_WSCCommand = text.Replace("##WSC##", "").ToUpper();
			}
			string text2 = "";
			string text3 = "";
			bool flag = false;
			while (true)
			{
				string text4 = stringReader.ReadLine();
				if (text4 == null)
				{
					break;
				}
				if (text4.StartsWith("##WSC##"))
				{
					if (Operators.CompareString(text2, "", false) != 0)
					{
						_ParametersIN.Add(text2, text3);
					}
					text2 = text4.Replace("##WSC##", "");
					text3 = "";
					flag = true;
				}
				else
				{
					if (!flag)
					{
						text3 += "\r\n";
					}
					flag = false;
					text3 += text4;
				}
			}
			if (Operators.CompareString(text2, "", false) != 0)
			{
				_ParametersIN.Add(text2, text3);
			}
			val2 = CommandElab(ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN PingCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			_ParametersOUT.Add("MESSAGE_RESPONSE", "OK - " + DateAndTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + _ParametersIN["MESSAGE"].ToString());
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN GetDateCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			_ParametersOUT.Add("GETDATE_RESPONSE", DateAndTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN DownloadFileCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["FILE_NAME"].ToString();
			string text2 = "";
			byte[] array = new byte[0];
			text2 = base.SessionEnvironment.WebApplicationRoot + "\\" + text;
			text2 = text2.Replace("/", "\\").Replace("\\\\", "\\");
			if (File.Exists(text2))
			{
				array = File.ReadAllBytes(text2);
				_ParametersOUT.Add("FILE_NAME", text);
				string value = Convert.ToBase64String(array);
				_ParametersOUT.Add("FILE_CONTENT", value);
				val = (FXRETURN)0;
			}
			else
			{
				rsmess = "FILE " + text + " DOESN'T EXISTS";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN ListFileCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = "";
			string text2 = _ParametersIN["DIR_NAME"].ToString();
			string text3 = base.SessionEnvironment.WebApplicationRoot + "\\" + text2;
			text3 = text3.Replace("/", "\\").Replace("\\\\", "\\");
			if (Directory.Exists(text3))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text3);
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				FileInfo[] files = directoryInfo.GetFiles();
				DirectoryInfo[] array = directories;
				foreach (DirectoryInfo directoryInfo2 in array)
				{
					text = text + directoryInfo2.Name + ";D;" + directoryInfo2.CreationTime.ToString("dd/MM/yyyy HH:mm:ss") + ";;\r\n";
				}
				FileInfo[] array2 = files;
				foreach (FileInfo fileInfo in array2)
				{
					text = text + fileInfo.Name + ";F;" + fileInfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss") + ";" + fileInfo.Length + ";\r\n";
				}
				_ParametersOUT.Add("DIR_NAME", text2);
				_ParametersOUT.Add("DIR_CONTENT", text);
				val = (FXRETURN)0;
			}
			else
			{
				rsmess = "DIRECTORY " + text2 + " DOESN'T EXISTS";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN DeleteFileCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["FILE_NAME"].ToString();
			string text2 = "";
			string text3 = "";
			text2 = base.SessionEnvironment.WebApplicationRoot + "\\" + text;
			text2 = text2.Replace("/", "\\").Replace("\\\\", "\\");
			text3 = "OK";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			_ParametersOUT.Add("FILE_NAME", text);
			_ParametersOUT.Add("FILE_RESULT", text3);
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN RenameFileCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["FILENAME_FROM"].ToString();
			string text2 = "";
			string text3 = _ParametersIN["FILENAME_TO"].ToString();
			string text4 = "";
			string text5 = "";
			text2 = base.SessionEnvironment.WebApplicationRoot + "\\" + text;
			text2 = text2.Replace("/", "\\").Replace("\\\\", "\\");
			text4 = base.SessionEnvironment.WebApplicationRoot + "\\" + text3;
			text4 = text4.Replace("/", "\\").Replace("\\\\", "\\");
			if (File.Exists(text2))
			{
				text5 = "OK";
				File.Move(text2, text4);
				_ParametersOUT.Add("FILENAME_NAME", text);
				_ParametersOUT.Add("FILENAME_RESULT", text5);
				val = (FXRETURN)0;
			}
			else
			{
				rsmess = "FILE NOT EXISTS";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN UploadFileCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["FILE_NAME"].ToString();
			string text2 = "";
			string s = _ParametersIN["FILE_CONTENT"].ToString();
			string text3 = "";
			text2 = base.SessionEnvironment.WebApplicationRoot + "\\" + text;
			text2 = text2.Replace("/", "\\").Replace("\\\\", "\\");
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			byte[] bytes = Convert.FromBase64String(s);
			File.WriteAllBytes(text2, bytes);
			text3 = "OK";
			_ParametersOUT.Add("FILE_NAME", text);
			_ParametersOUT.Add("FILE_RESULT", text3);
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN SqlExecCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["SSQL"].ToString();
			val2 = base.DbConn.SqlExec(text, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_ParametersOUT.Add("SSQL", "OK");
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN DoSqlCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["SSQL"].ToString();
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string value = "";
				if (dataTable.Rows.Count > 0)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0][0]);
					value = (((object)objectValue.GetType() != typeof(DateTime)) ? objectValue.ToString() : Conversions.ToDate(objectValue).ToString("dd/MM/yyyy HH:mm:ss"));
				}
				_ParametersOUT.Add("SSQL_RESULT", value);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN SqlSelectCommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			string text = _ParametersIN["SSQL"].ToString();
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string text2 = "";
				string text3 = "";
				string text4 = "";
				foreach (DataColumn column in dataTable.Columns)
				{
					text2 = (((object)column.DataType != typeof(DateTime)) ? ((!(((object)column.DataType == typeof(short)) | ((object)column.DataType == typeof(int)) | ((object)column.DataType == typeof(long)) | ((object)column.DataType == typeof(byte)) | ((object)column.DataType == typeof(double)) | ((object)column.DataType == typeof(float)) | ((object)column.DataType == typeof(decimal)) | ((object)column.DataType == typeof(uint)) | ((object)column.DataType == typeof(ushort)) | ((object)column.DataType == typeof(ulong)))) ? (text2 + "STRING;") : (text2 + "NUMBER;")) : (text2 + "DATETIME;"));
					text3 = text3 + column.ColumnName.ToUpper() + ";";
				}
				foreach (DataRow row in dataTable.Rows)
				{
					string text5 = "";
					foreach (DataColumn column2 in dataTable.Columns)
					{
						text5 = (((object)column2.DataType != typeof(DateTime)) ? ((!(((object)column2.DataType == typeof(short)) | ((object)column2.DataType == typeof(int)) | ((object)column2.DataType == typeof(long)) | ((object)column2.DataType == typeof(byte)) | ((object)column2.DataType == typeof(double)) | ((object)column2.DataType == typeof(float)) | ((object)column2.DataType == typeof(decimal)) | ((object)column2.DataType == typeof(uint)) | ((object)column2.DataType == typeof(ushort)) | ((object)column2.DataType == typeof(ulong)))) ? ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[column2.ColumnName]))) ? (text5 + Strings.Replace(Strings.Replace(row[column2.ColumnName].ToString(), ";", "%.,%", 1, -1, (CompareMethod)0), "\r\n", "%CRLF%", 1, -1, (CompareMethod)0)) : (text5 + "%NULL%")) : (text5 + row[column2.ColumnName].ToString())) : ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[column2.ColumnName]))) ? (text5 + Conversions.ToDate(row[column2.ColumnName]).ToString("dd/MM/yyyy HH:mm:ss")) : (text5 + "%NULL%")));
						text5 += ";";
					}
					text4 = text4 + text5 + "\r\n";
				}
				_ParametersOUT.Add("SSQL_RESULT_COLUMNS_TYPE", Convert.ToBase64String(Encoding.ASCII.GetBytes(text2)));
				_ParametersOUT.Add("SSQL_RESULT_COLUMNS_NAME", Convert.ToBase64String(Encoding.ASCII.GetBytes(text3)));
				_ParametersOUT.Add("SSQL_RESULT_COLUMNS_VALUE", Convert.ToBase64String(Encoding.ASCII.GetBytes(text4)));
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN CommandElab(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Invalid comparison between Unknown and I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			if (Operators.CompareString(_WSCCommand, "PING", false) == 0)
			{
				val2 = PingCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "GETDATE", false) == 0)
			{
				val2 = GetDateCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "DOWNLOADFILE", false) == 0)
			{
				val2 = DownloadFileCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "UPLOADFILE", false) == 0)
			{
				val2 = UploadFileCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "LISTFILE", false) == 0)
			{
				val2 = ListFileCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "DELETEFILE", false) == 0)
			{
				val2 = DeleteFileCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "RENAMEFILE", false) == 0)
			{
				val2 = RenameFileCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "SQLEXEC", false) == 0)
			{
				val2 = SqlExecCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else if (Operators.CompareString(_WSCCommand, "DOSQL", false) == 0)
			{
				val2 = DoSqlCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_WSCCommand, "SQLSELECT", false) != 0)
				{
					goto IL_0245;
				}
				val2 = SqlSelectCommandElab(ref rsmess);
				if ((int)val2 <= 0)
				{
					goto IL_0245;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_0245:
			_OutputResponse = GenerateResponseToClient();
			val = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual string GenerateResponseToClient()
	{
		string text = "";
		try
		{
			text = _prefisso + _WSCCommand + "\r\n";
			foreach (KeyValuePair<string, string> item in _ParametersOUT)
			{
				text = text + _prefisso + item.Key + "\r\n";
				text = text + item.Value + "\r\n";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = "";
			ProjectData.ClearProjectError();
		}
		return text;
	}

	protected override void SendErrorToClient()
	{
		try
		{
			((Page)this).Response.Clear();
			((Page)this).Response.ContentType = "text/plain";
			((Page)this).Response.ContentEncoding = Encoding.UTF8;
			((Page)this).Response.Write(_prefisso + "ERROR\r\n" + _prefisso + "ERROR_CODE\r\n" + _ErrorCode + "\r\n" + _prefisso + "ERROR_MESSAGE\r\n" + _ErrorMessage + "\r\n");
			((Page)this).Response.End();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
