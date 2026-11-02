using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Incasbo.Web.Library;
using Incasbo.Windows.Library.PDF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class GridExporter : IGridExporter
{
	protected IboSessionEnvironment _objSessionEnvironment;

	protected IboAppCallStackHandling _objCallStackHandler;

	protected IboAppLogHandling _objIboAppLogHandling;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected IboWebUserInfo _objWebUserInfo;

	protected IboGridInfo _objGridInfo;

	protected string _TmpPath;

	protected string _TmpFileName;

	protected string _TmpFileExt;

	protected string _Title;

	public virtual string GetExportFileCompletePath => _TmpPath + _TmpFileName + ".zip";

	public virtual string GetExportFileName => _TmpFileName;

	public GridExporter()
	{
		_TmpPath = "";
		_TmpFileName = "";
		_TmpFileExt = "";
		_Title = "";
	}

	public virtual void Init(ref IboSessionEnvironment robjSessionEnv, ref IboGridInfo rObjDataGrid)
	{
		_objSessionEnvironment = robjSessionEnv;
		_objCallStackHandler = robjSessionEnv.CallStackHandler;
		_objIboAppLogHandling = robjSessionEnv.LogHandling;
		_Translator = robjSessionEnv.Translator;
		_dbMain = robjSessionEnv.DbConn;
		_objWebUserInfo = robjSessionEnv.WebUser.WebUserInfo;
		_objGridInfo = rObjDataGrid;
		_TmpPath = _objSessionEnvironment.WebApplicationDownloadDir;
	}

	void IGridExporter.Init(ref IboSessionEnvironment robjSessionEnv, ref IboGridInfo rObjDataGrid)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Init
		this.Init(ref robjSessionEnv, ref rObjDataGrid);
	}

	public virtual eGridExporterOutputFormat ConvertStringToOutputFormat(string vsStringValue)
	{
		return vsStringValue switch
		{
			"0" => eGridExporterOutputFormat.XML, 
			"1" => eGridExporterOutputFormat.TXT, 
			"2" => eGridExporterOutputFormat.CSV, 
			"3" => eGridExporterOutputFormat.DIFF, 
			"4" => eGridExporterOutputFormat.PDF, 
			"5" => eGridExporterOutputFormat.HTML, 
			"6" => eGridExporterOutputFormat.XLS, 
			"7" => eGridExporterOutputFormat.DOC, 
			_ => eGridExporterOutputFormat.TXT, 
		};
	}

	eGridExporterOutputFormat IGridExporter.ConvertStringToOutputFormat(string vsStringValue)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ConvertStringToOutputFormat
		return this.ConvertStringToOutputFormat(vsStringValue);
	}

	public virtual FXRETURN Execute(eGridExporterOutputFormat veOutputFormat, string Title, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between Unknown and I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_Title = Title;
			if (Operators.CompareString(_Title, "", false) == 0)
			{
				_Title = _objGridInfo.AllGrd["DesTab"].ToString();
			}
			DateTime now = DateAndTime.Now;
			_TmpFileName = _objGridInfo.NomRif + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond;
			switch (veOutputFormat)
			{
			case eGridExporterOutputFormat.XML:
				val = ExportXML(ref rsMess);
				break;
			case eGridExporterOutputFormat.TXT:
				val = ExportTXT(ref rsMess);
				break;
			case eGridExporterOutputFormat.CSV:
				val = ExportCSV(ref rsMess);
				break;
			case eGridExporterOutputFormat.HTML:
				val = ExportHTML(ref rsMess);
				break;
			case eGridExporterOutputFormat.XLS:
				val = ExportXLS(ref rsMess);
				break;
			case eGridExporterOutputFormat.DIFF:
				val = ExportDIFF(ref rsMess);
				break;
			case eGridExporterOutputFormat.PDF:
				val = ExportPDF(ref rsMess);
				break;
			case eGridExporterOutputFormat.DOC:
				val = ExportDOC(ref rsMess);
				break;
			}
			if ((int)val <= 0 && (int)ZipFile(ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			val = (FXRETURN)5;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	FXRETURN IGridExporter.Execute(eGridExporterOutputFormat veOutputFormat, string Title, ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Execute
		return this.Execute(veOutputFormat, Title, ref rsMess);
	}

	protected virtual FXRETURN ExportXML(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string[] array = new string[0];
		StreamWriter streamWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".xml";
			streamWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				int count = default(int);
				if (dataTable.Rows.Count > 0)
				{
					count = _objGridInfo.TabGrdTable.Rows.Count;
				}
				checked
				{
					int i = default(int);
					for (; i < dataTable.Rows.Count; i++)
					{
						int j = 0;
						StringBuilder stringBuilder = new StringBuilder();
						array = (string[])Utils.CopyArray((Array)array, (Array)new string[i + 1]);
						stringBuilder.Append("<record>");
						stringBuilder.Append("\r\n");
						for (; j < count; j++)
						{
							string text = "";
							string sValore = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[j]["NOMCAM"].ToString());
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[i][text])))
								{
									sValore = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[i][text].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[j]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[i][text])));
								}
								stringBuilder.Append("<" + text + ">");
								stringBuilder.Append(XMLEncode(sValore));
								stringBuilder.Append("</" + text + ">");
								stringBuilder.Append("\r\n");
							}
						}
						stringBuilder.Append("</record>");
						stringBuilder.Append("\r\n");
						array[i] = stringBuilder.ToString();
					}
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<" + _objGridInfo.NomRif.Replace(".", "_").Replace("#", "_") + ">");
					stringBuilder2.Append("\r\n");
					string[] array2 = array;
					foreach (string value in array2)
					{
						stringBuilder2.Append(value);
					}
					stringBuilder2.Append("</" + _objGridInfo.NomRif.Replace(".", "_").Replace("#", "_") + ">");
					stringBuilder2.Append("\r\n");
					streamWriter.WriteLine(stringBuilder2.ToString());
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual string XMLEncode(string sValore)
	{
		sValore = sValore.Replace("&", "&amp;");
		sValore = sValore.Replace("<", "&lt;");
		sValore = sValore.Replace(">", "&gt;");
		sValore = sValore.Replace("\"", "&quot;");
		sValore = sValore.Replace("'", "&apos;");
		return sValore;
	}

	protected virtual FXRETURN ExportPDF(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected O, but got Unknown
		//IL_0711: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0769: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_07c0: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataTable dataTable = null;
		DataTable dataTable2 = new DataTable();
		int[] array = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				DataColumn[] array2 = new DataColumn[0];
				string[] array3 = new string[0];
				ContentAlignment[] array4 = (ContentAlignment[])(object)new ContentAlignment[0];
				checked
				{
					int num = _objGridInfo.TabGrdTable.Rows.Count - 1;
					int num2 = default(int);
					for (int i = 0; i <= num; i++)
					{
						string text = "";
						string text2 = "";
						if (!((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0))))
						{
							continue;
						}
						text = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString());
						DataColumn dataColumn = dataTable.Columns[text];
						dataColumn.Caption = _objGridInfo.TabGrdTable.Rows[i]["DESCAM"].ToString();
						array2 = (DataColumn[])Utils.CopyArray((Array)array2, (Array)new DataColumn[num2 + 1]);
						array2[num2] = dataColumn;
						array3 = (string[])Utils.CopyArray((Array)array3, (Array)new string[num2 + 1]);
						array3[num2] = _objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString();
						array4 = (ContentAlignment[])Utils.CopyArray((Array)array4, (Array)new ContentAlignment[num2 + 1]);
						string text3 = _objGridInfo.TabGrdTable.Rows[i]["HORIZONTALALIGN"].ToString();
						if (text3.Contains("Center"))
						{
							array4[num2] = (ContentAlignment)2;
						}
						else if (text3.Contains("Left"))
						{
							array4[num2] = (ContentAlignment)1;
						}
						else if (text3.Contains("Right"))
						{
							array4[num2] = (ContentAlignment)4;
						}
						else
						{
							array4[num2] = (ContentAlignment)1;
						}
						array = (int[])Utils.CopyArray((Array)array, (Array)new int[num2 + 1]);
						if ((Operators.CompareString(dataColumn.DataType.Name, "DateTime", false) == 0) | (Operators.CompareString(dataColumn.DataType.Name, "Date", false) == 0))
						{
							array[num2] = 85;
						}
						else
						{
							int length = dataColumn.Caption.Length;
							length = 0;
							int num3 = dataTable.Rows.Count - 1;
							for (int j = 0; j <= num3; j++)
							{
								if (length < dataTable.Rows[j][text].ToString().Length)
								{
									length = dataTable.Rows[j][text].ToString().Length;
								}
							}
							array[num2] = length * 9;
						}
						if (array[num2] > 360)
						{
							array[num2] = 360;
						}
						if (array[num2] < 55)
						{
							array[num2] = 55;
						}
						num2++;
					}
					while (true)
					{
						IL_04a1:
						int num4 = dataTable.Columns.Count - 1;
						int i = 0;
						while (true)
						{
							if (i <= num4)
							{
								if (!array2.Contains(dataTable.Columns[i]))
								{
									dataTable.Columns.Remove(dataTable.Columns[i]);
									goto IL_04a1;
								}
								i++;
								continue;
							}
							PdfDocument val2 = new PdfDocument(PdfDocumentFormat.InCentimeters(29.7, 21.0));
							val2.FlateCompression = true;
							PdfTable val3 = val2.NewTable(new Font("Arial", 5f, (GraphicsUnit)3), dataTable.Rows.Count, dataTable.Columns.Count, 1.0);
							val3.ImportDataTable(dataTable);
							((PdfCellRange)val3.HeadersRow).SetFont(new Font("Arial", 6f, (FontStyle)1));
							((PdfCellRange)val3.HeadersRow).SetColors(Color.Red, Color.WhiteSmoke);
							((PdfCellRange)val3.HeadersRow).SetCellPadding(2.0);
							((PdfCellRange)val3).SetColors(Color.Black, Color.White, Color.White);
							val3.SetBorders(Color.DarkGray, 0.5, (BorderType)6);
							((PdfCellRange)val3).SetCellPadding(2.0);
							((PdfCellRange)val3).SetContentAlignment((ContentAlignment)1);
							((PdfCellRange)val3.HeadersRow).SetContentAlignment((ContentAlignment)1);
							val3.SetRowHeight(22.0);
							val3.SetColumnsWidth(array);
							int num5 = val3.Columns.Count() - 1;
							for (i = 0; i <= num5; i++)
							{
								if (Operators.CompareString(array3[i], "", false) != 0)
								{
									((PdfCellRange)val3.Columns[i]).SetContentFormat(array3[i]);
								}
								((PdfCellRange)val3.Columns[i]).SetContentAlignment(array4[i]);
							}
							i = 1;
							while (!val3.AllTablePagesCreated)
							{
								PdfPage val4 = val2.NewPage();
								PdfTablePage val5 = val3.CreateTablePage(new PdfArea(20.0, 45.0, 800.0, 520.0));
								PdfTextArea val6 = new PdfTextArea(new Font("Arial", 12f, (FontStyle)1), Color.Black, new PdfArea(20.0, 20.0, 200.0, 50.0), (ContentAlignment)1, _Title);
								PdfTextArea val7 = new PdfTextArea(new Font("Arial", 6f, (FontStyle)0), Color.Black, new PdfArea(720.0, 20.0, 100.0, 17.0), (ContentAlignment)1024, DateAndTime.Now.ToString());
								PdfTextArea val8 = new PdfTextArea(new Font("Arial", 6f, (FontStyle)0), Color.Black, new PdfArea(20.0, 570.0, 800.0, 30.0), (ContentAlignment)1, "Pag. " + Conversions.ToString(i));
								val4.Add((PdfStreamElement)(object)val5);
								val4.Add((PdfStreamElement)(object)val6);
								val4.Add((PdfStreamElement)(object)val7);
								val4.Add((PdfStreamElement)(object)val8);
								val4.SaveToDocument();
								i++;
							}
							_TmpFileExt = ".pdf";
							val2.SaveToFile(_TmpPath + _TmpFileName + _TmpFileExt);
							val = (FXRETURN)0;
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportCSV(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		StreamWriter streamWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".csv";
			streamWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				checked
				{
					int count = default(int);
					if (dataTable.Rows.Count > 0)
					{
						int i = default(int);
						for (count = _objGridInfo.TabGrdTable.Rows.Count; i < count; i++)
						{
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text = text + "\"" + _objGridInfo.TabGrdTable.Rows[i]["DESCAM"].ToString() + "\";";
							}
						}
						streamWriter.WriteLine(text);
					}
					int j = default(int);
					for (; j < dataTable.Rows.Count; j++)
					{
						int i = 0;
						text = "";
						for (; i < count; i++)
						{
							string text2 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text2 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString());
								text += "\"";
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])))
								{
									string text3 = "";
									text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[j][text2].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])));
									text += text3;
								}
								text += "\"";
								text += ";";
							}
						}
						streamWriter.WriteLine(text);
					}
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportHTML(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		TextWriter textWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".html";
			textWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				text = "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><title>" + _Title + "</title><style>\r\n@media print {\r\ntable {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nfont-size: 8pt;\r\n}\r\ntable tr.Header td {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nbackground-color: #E1E1E1;\r\nfont-weight: bold;\r\nfont-size: 8pt;\r\n}\r\ntable tr.Data td {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nbackground-color: #ffffff;\r\n}\r\np.Intestazione {\r\nfont-size:12pt;\r\nfont-weight:bold;\r\n}\r\n}\r\n@media screen {\r\ntable {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nfont-size: 8pt;\r\n}\r\ntable tr.Header td {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nbackground-color: #E1E1E1;\r\nfont-weight: bold;\r\nfont-size: 8pt;\r\n}\r\ntable tr.Data td {\r\nborder: 1px solid #aaaaaa;\r\nborder-collapse: collapse;\r\nbackground-color: #ffffff;\r\n}\r\np.Intestazione {\r\nfont-size:12pt;\r\nfont-weight:bold;\r\n}\r\n}\r\n</style>\r\n</head><body style=\"font-family:Verdana;\">\r\n<p class=\"Intestazione\">" + _Title + "</p>\r\n<table border=\"0\" cellpadding=\"3\" cellspacing=\"1\" bgcolor=#A0A0A0 style='font-size:8pt'>\r\n";
				textWriter.WriteLine(text);
				text = "";
				checked
				{
					int count = default(int);
					if (dataTable.Rows.Count > 0)
					{
						text = "<tr class=\"Header\">";
						int i = default(int);
						for (count = _objGridInfo.TabGrdTable.Rows.Count; i < count; i++)
						{
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text = text + "<td>" + _objGridInfo.TabGrdTable.Rows[i]["DESCAM"].ToString() + "</td>";
							}
						}
						text += "</tr>";
						textWriter.WriteLine(text);
					}
					int j = default(int);
					for (; j < dataTable.Rows.Count; j++)
					{
						int i = 0;
						text = "<tr class=\"Data\">";
						for (; i < count; i++)
						{
							string text2 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text2 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString());
								string text3 = "";
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])))
								{
									text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[j][text2].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])));
								}
								text = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Center", false) == 0) ? (text + "<td Align = \"center\">") : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Right", false) != 0) ? (text + "<td>") : (text + "<td Align = \"right\">")));
								text = text + Interaction.IIf(Operators.CompareString(text3, "", false) != 0, (object)text3, (object)"&nbsp;").ToString() + "</td>";
							}
						}
						text += "</tr>\r\n";
						textWriter.WriteLine(text);
					}
					text = "</table></body></html>";
					textWriter.WriteLine(text);
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			textWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportXLS(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		TextWriter textWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".xls";
			textWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				text = "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><title>" + _Title + "</title></head><body style=\"font-family:Verdana;\">\r\n<p style=\"font-size:12pt;font-weight:bold;\">" + _Title + "</p>\r\n<table border=\"1\" cellpadding=\"3\" cellspacing=\"0\" bgcolor=#A0A0A0 style='font-size:8pt'>\r\n";
				textWriter.WriteLine(text);
				text = "";
				checked
				{
					int count = default(int);
					if (dataTable.Rows.Count > 0)
					{
						text = "<tr>";
						int i = default(int);
						for (count = _objGridInfo.TabGrdTable.Rows.Count; i < count; i++)
						{
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text = text + "<td bgcolor=\"#E1E1E1\"><b>" + _objGridInfo.TabGrdTable.Rows[i]["DESCAM"].ToString() + "</b></td>";
							}
						}
						text += "</tr>";
						textWriter.WriteLine(text);
					}
					int j = default(int);
					for (; j < dataTable.Rows.Count; j++)
					{
						int i = 0;
						text = "<tr>";
						for (; i < count; i++)
						{
							string text2 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text2 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString());
								string text3 = "";
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])))
								{
									text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[j][text2].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])));
								}
								text = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Center", false) == 0) ? (text + "<td bgcolor=\"#FFFFFF\" Align = \"center\">") : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Right", false) != 0) ? (text + "<td bgcolor=\"#FFFFFF\">") : (text + "<td bgcolor=\"#FFFFFF\" Align = \"right\">")));
								text = text + Interaction.IIf(Operators.CompareString(text3, "", false) != 0, (object)text3, (object)"&nbsp;").ToString() + "</td>";
							}
						}
						text += "</tr>\r\n";
						textWriter.WriteLine(text);
					}
					text = "</table></body></html>";
					textWriter.WriteLine(text);
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			textWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportTXT(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		string text2 = "";
		StreamWriter streamWriter = null;
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".txt";
			streamWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			val = _dbMain.SqlSchemaTable(ref dataTable, _objGridInfo.SqlStatement.ToString(), ref rsMess);
			if ((int)val <= 0 && (int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable2, ref rsMess) <= 0)
			{
				int count = dataTable2.Rows.Count;
				int count2 = _objGridInfo.TabGrdTable.Rows.Count;
				checked
				{
					int i = default(int);
					for (; i < count; i++)
					{
						int j = 0;
						text = "";
						for (; j < count2; j++)
						{
							text2 = "";
							string text3 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[j]["NOMCAM"].ToString());
								foreach (DataRow row in dataTable.Rows)
								{
									if (Operators.CompareString(row["ColumnName"].ToString().ToUpper(), text3.ToUpper(), false) == 0)
									{
										switch (((Type)row["DataType"]).Name)
										{
										case "String":
										case "Char":
											text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows[i][j])).PadRight(Convert.ToInt16(RuntimeHelpers.GetObjectValue(row["ColumnSize"])));
											break;
										case "DateTime":
										case "TimeSpan":
											text2 = ((Operators.CompareString(dataTable2.Rows[i][j].ToString(), "", false) != 0) ? Strings.Format(RuntimeHelpers.GetObjectValue(dataTable2.Rows[i][j]), "dd/MM/yyyy hh:mm:ss") : "".PadRight(19, ' '));
											break;
										case "Byte":
										case "SByte":
										case "Int16":
										case "Int32":
										case "Int64":
										case "Single":
										case "UInt16":
										case "UInt32":
										case "UInt64":
											text2 = Strings.Format(RuntimeHelpers.GetObjectValue(dataTable2.Rows[i][j]), "0000000000");
											break;
										case "Decimal":
										case "Double":
											text2 = Strings.Format(RuntimeHelpers.GetObjectValue(dataTable2.Rows[i][j]), "0000000000.00000").Remove(10, 1);
											break;
										default:
											text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows[i][j])).PadRight(30);
											break;
										}
										break;
									}
								}
							}
							text += text2;
						}
						streamWriter.WriteLine(text);
					}
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			if (dataTable2 != null)
			{
				dataTable2.Dispose();
				dataTable2 = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportDIFF(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		StreamWriter streamWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".dif";
			streamWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				int count = _objGridInfo.TabGrdTable.Rows.Count;
				checked
				{
					int num = default(int);
					int j = default(int);
					for (int i = 1; i <= count; i++)
					{
						if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0)))
						{
							num++;
						}
					}
					streamWriter.WriteLine("Table");
					streamWriter.WriteLine("0,1");
					streamWriter.WriteLine("EXCEL");
					streamWriter.WriteLine("VECTORS");
					streamWriter.WriteLine("0," + Conversions.ToString(dataTable.Rows.Count));
					streamWriter.WriteLine("");
					streamWriter.WriteLine("TUPLES");
					streamWriter.WriteLine("0," + Conversions.ToString(num));
					streamWriter.WriteLine("");
					streamWriter.WriteLine("Data");
					streamWriter.WriteLine("0,0");
					streamWriter.WriteLine("");
					streamWriter.WriteLine("-1,0");
					streamWriter.WriteLine("BOT");
					int count2;
					for (count2 = _objGridInfo.TabGrdTable.Rows.Count; j < count2; j++)
					{
						if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0)))
						{
							streamWriter.WriteLine("1,0");
							streamWriter.WriteLine("\"" + _objGridInfo.TabGrdTable.Rows[j]["DESCAM"].ToString() + "\"");
						}
					}
					int k = default(int);
					for (int count3 = dataTable.Rows.Count; k < count3; k++)
					{
						j = 0;
						streamWriter.WriteLine("-1,0");
						streamWriter.WriteLine("BOT");
						for (; j < count2; j++)
						{
							string text2 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text2 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[j]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[j]["NOMCAM"].ToString());
								streamWriter.WriteLine("1,0");
								string text3 = "";
								text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[j]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[k][text2].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[j]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[k][text2])));
								streamWriter.WriteLine("\"" + text3 + "\"");
							}
						}
					}
					streamWriter.WriteLine("-1,0\r\nEOD\r\n");
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ExportDOC(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		TextWriter textWriter = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_TmpFileExt = ".doc";
			textWriter = new StreamWriter(_TmpPath + _TmpFileName + _TmpFileExt, append: true, Encoding.Default);
			if ((int)_dbMain.OpenDataTable(_objGridInfo.SqlStatement.ToString(), ref dataTable, ref rsMess) <= 0)
			{
				text = "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><title>" + _Title + "</title></head><body style=\"font-family:Verdana;\">\r\n<p style=\"font-size:12pt;font-weight:bold;\">" + _Title + "</p>\r\n<table border=\"1\" cellpadding=\"3\" cellspacing=\"0\" bgcolor=#A0A0A0 style='font-size:8pt'>\r\n";
				textWriter.WriteLine(text);
				text = "";
				checked
				{
					int count = default(int);
					if (dataTable.Rows.Count > 0)
					{
						text = "<tr>";
						int i = default(int);
						for (count = _objGridInfo.TabGrdTable.Rows.Count; i < count; i++)
						{
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text = text + "<td bgcolor=\"#E1E1E1\"><b>" + _objGridInfo.TabGrdTable.Rows[i]["DESCAM"].ToString() + "</b></td>";
							}
						}
						text += "</tr>";
						textWriter.WriteLine(text);
					}
					int j = default(int);
					for (; j < dataTable.Rows.Count; j++)
					{
						int i = 0;
						text = "<tr>";
						for (; i < count; i++)
						{
							string text2 = "";
							if ((!_objGridInfo.TabGrdTable.Columns.Contains("VISIBLEINEXP")) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0) : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "X", false) != 0) ? (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBLEINEXP"].ToString(), "S", false) == 0) : (Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["VISIBILE"].ToString(), "S", false) == 0)))
							{
								text2 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString(), "", false) != 0) ? _objGridInfo.TabGrdTable.Rows[i]["NOMCAMEXP"].ToString() : _objGridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString());
								string text3 = "";
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])))
								{
									text3 = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), "", false) == 0) ? dataTable.Rows[j][text2].ToString() : string.Format(_objGridInfo.TabGrdTable.Rows[i]["FORCAM"].ToString(), RuntimeHelpers.GetObjectValue(dataTable.Rows[j][text2])));
								}
								text = ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Center", false) == 0) ? (text + "<td bgcolor=\"#FFFFFF\" Align = \"center\">") : ((Operators.CompareString(_objGridInfo.TabGrdTable.Rows[i]["HorizontalAlign"].ToString(), "Right", false) != 0) ? (text + "<td bgcolor=\"#FFFFFF\">") : (text + "<td bgcolor=\"#FFFFFF\" Align = \"right\">")));
								text = text + Interaction.IIf(Operators.CompareString(text3, "", false) != 0, (object)text3, (object)"&nbsp;").ToString() + "</td>";
							}
						}
						text += "</tr>\r\n";
						textWriter.WriteLine(text);
					}
					text = "</table></body></html>";
					textWriter.WriteLine(text);
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			textWriter?.Close();
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ZipFile(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		ZipOutputStream val2 = null;
		ZipEntry val3 = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			fileStream = new FileStream(_TmpPath + _TmpFileName + _TmpFileExt, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[checked((int)fileStream.Length - 1 + 1)];
			int num = fileStream.Read(array, 0, array.Length);
			if (num != array.Length)
			{
				rsMess = _Translator.TranslateMessage("XXX", "Errore nella lettura del file.", new string[0]);
			}
			else
			{
				fileStream.Close();
				fileStream = new FileStream(_TmpPath + _TmpFileName + ".zip", FileMode.CreateNew, FileAccess.Write);
				val2 = new ZipOutputStream((Stream)fileStream);
				val3 = new ZipEntry(_TmpFileName + _TmpFileExt);
				val2.PutNextEntry(val3);
				val2.Write(array, 0, array.Length);
				val2.Finish();
				((DeflaterOutputStream)val2).Close();
				fileStream.Close();
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			if (val2 != null)
			{
				((DeflaterOutputStream)val2).Close();
				((Stream)(object)val2).Dispose();
				val2 = null;
			}
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
				fileStream = null;
			}
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN SendFile(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			HttpContext.Current.Response.Clear();
			HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
			HttpContext.Current.Response.Buffer = true;
			HttpContext.Current.Response.Cache.SetCacheability((HttpCacheability)1);
			HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + _TmpFileName + ".zip");
			HttpContext.Current.Response.WriteFile(_TmpPath + _TmpFileName + ".zip");
			IboSessionEnvironment objSessionEnvironment = _objSessionEnvironment;
			string sNomeFile = _TmpPath + _TmpFileName + ".zip";
			string rsMess2 = "";
			objSessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess2);
			IboSessionEnvironment objSessionEnvironment2 = _objSessionEnvironment;
			string sNomeFile2 = _TmpPath + _TmpFileName + _TmpFileExt;
			rsMess2 = "";
			objSessionEnvironment2.AddFileToDelete(sNomeFile2, ref rsMess2);
			HttpContext.Current.Response.End();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_objCallStackHandler.CallStackRemove();
		}
		return result;
	}
}
