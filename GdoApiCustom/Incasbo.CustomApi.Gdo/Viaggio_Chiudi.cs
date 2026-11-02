using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.Gdo;

public class Viaggio_Chiudi : Incasbo.Api.Gdo.Viaggio_Chiudi
{
	public Viaggio_Chiudi(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN AfterRun(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = this.AfterRun(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ExportXML(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN ExportXML(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN rnRes = (FXRETURN)3;
		StreamWriter streamWriter = null;
		DataTable rObjDataTable = null;
		string text = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = ((AppBaseClass)this).Parametrica.LeggiParametro("CST.VIA.CHI.EXPXML.FILEPATH", ref rnRes, ref rsMess);
			if ((int)rnRes <= 0)
			{
				if (!text.EndsWith(Conversions.ToString(Path.DirectorySeparatorChar)))
				{
					text += Conversions.ToString(Path.DirectorySeparatorChar);
				}
				text2 = ((AppBaseClass)this).Parametrica.LeggiParametro("CST.VIA.CHI.EXPXML.FILENAME", ref rnRes, ref rsMess);
				if ((int)rnRes <= 0)
				{
					text2 = text2.Replace("*", _IdViaggio + "_" + DateAndTime.Now.ToString("yyyyMMddHHmmssfff"));
					text3 = DateAndTime.Now.ToString("yyyyMMddHHmmssfff") + ".tmp";
					string vsSQLClause = "SELECT * FROM CST_GRD_VIAGGI_CHIUSI_EXPORT_XML WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdViaggio);
					if ((int)((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsMess) <= 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<Viaggio>");
						stringBuilder.Append("\r\n");
						checked
						{
							int i = default(int);
							for (; i < rObjDataTable.Rows.Count; i++)
							{
								int j = 0;
								stringBuilder.Append("<record>");
								stringBuilder.Append("\r\n");
								for (; j < rObjDataTable.Columns.Count; j++)
								{
									if (!rObjDataTable.Columns[j].ColumnName.StartsWith("DNE_") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(rObjDataTable.Rows[i][j])))
									{
										stringBuilder.Append("<" + rObjDataTable.Columns[j].ColumnName + ">");
										stringBuilder.Append(XMLEncode(rObjDataTable.Rows[i][j].ToString()));
										stringBuilder.Append("</" + rObjDataTable.Columns[j].ColumnName + ">");
										stringBuilder.Append("\r\n");
									}
								}
								stringBuilder.Append("</record>");
								stringBuilder.Append("\r\n");
							}
							stringBuilder.Append("</Viaggio>");
							stringBuilder.Append("\r\n");
							streamWriter = new StreamWriter(text + text3, append: true, Encoding.Default);
							streamWriter.Write(stringBuilder.ToString());
							streamWriter.Close();
							streamWriter = null;
							File.Move(text + text3, text + text2);
							val = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (rObjDataTable != null)
			{
				rObjDataTable.Dispose();
				rObjDataTable = null;
			}
			result = val;
			this.CallStackRemove();
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
}
