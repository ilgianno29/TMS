using System;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI.HtmlControls;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class UpdateTest : WFIAspxRemoteService
{
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

	protected override FXRETURN ElabRequest(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				StringCollection stringCollection = new StringCollection();
				byte[] bytes = Encoding.UTF8.GetBytes(_InputCommand);
				MemoryStream stream = new MemoryStream(bytes);
				DataSet dataSet = new DataSet();
				dataSet.ReadXml((Stream?)stream);
				if (dataSet.Tables.Count > 0)
				{
					foreach (DataRow row in dataSet.Tables[0].Rows)
					{
						string text = "INSERT INTO PIER (";
						int num = dataSet.Tables[0].Columns.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							text += dataSet.Tables[0].Columns[i].ColumnName;
							if (i < dataSet.Tables[0].Columns.Count - 1)
							{
								text += ",";
							}
						}
						text += ") VALUES (";
						int num2 = row.ItemArray.Count() - 1;
						for (int j = 0; j <= num2; j++)
						{
							text += base.DbConn.SQLFormatString(row[j].ToString());
							if (j < row.ItemArray.Count() - 1)
							{
								text += ",";
							}
						}
						text += ");";
						stringCollection.Add(text);
					}
				}
				StringEnumerator enumerator2 = stringCollection.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					DBConnection dbConn = base.DbConn;
					string text2 = "";
					dbConn.SqlExec(current, ref text2);
				}
				_OutputResponse = "<result><code>0</code><ErrorMessage></ErrorMessage></result>";
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
	}
}
