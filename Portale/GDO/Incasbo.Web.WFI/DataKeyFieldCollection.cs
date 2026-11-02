using System;
using System.Collections.ObjectModel;
using System.Web;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class DataKeyFieldCollection : KeyedCollection<string, DataKeyFieldValues>
{
	public new int Count => base.Items.Count;

	protected override string GetKeyForItem(DataKeyFieldValues item)
	{
		return item.FieldName.ToUpper();
	}

	public DataKeyFieldValues Item(string sItem)
	{
		return base[sItem.ToUpper()];
	}

	public DataKeyFieldValues Item(int index)
	{
		return base[index];
	}

	public new void Add(DataKeyFieldValues item)
	{
		item.FieldName = item.FieldName.ToUpper();
		base.Add(item);
	}

	protected override void InsertItem(int index, DataKeyFieldValues item)
	{
		item.FieldName = item.FieldName.ToUpper();
		base.InsertItem(index, item);
	}

	public string GetFirstElementSqlWhere()
	{
		string text = "";
		checked
		{
			int num = Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = text + " AND " + Item(i).FieldName + "=";
				text = ((Operators.CompareString(Item(i).FieldType.ToUpper(), "DateTime".ToUpper(), false) != 0) ? (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatString(Item(i).get_FieldValues(0).ToString())) : (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatDate((eTipoData)2, Item(i).get_FieldValues(0).ToString())));
			}
			return text;
		}
	}

	public string GetFirstElementSqlWhereForDatatable()
	{
		string text = "";
		checked
		{
			int num = Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text = text + " AND " + Item(i).FieldName + " = ";
				text = ((Operators.CompareString(Item(i).FieldType.ToUpper(), "DateTime".ToUpper(), false) != 0) ? (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatString(Item(i).get_FieldValues(0).ToString())) : (text + "#" + Strings.Format((object)Item(i).get_FieldValues(0).ToString(), "MM/dd/yyyy") + "#"));
			}
			return text;
		}
	}

	public string GetAllElementSqlWhere()
	{
		string text = "";
		checked
		{
			try
			{
				int num = Item(0).FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					text = ((Operators.CompareString(text, "", false) == 0) ? (text + " ( ") : (text + ") OR ( "));
					int num2 = Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (j > 0)
						{
							text += " AND ";
						}
						text = text + Item(j).FieldName + "=";
						text = ((Operators.CompareString(Item(j).FieldType.ToUpper(), "DateTime".ToUpper(), false) != 0) ? (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatString(Item(j).get_FieldValues(i).ToString())) : (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatDate((eTipoData)2, Item(j).get_FieldValues(i).ToString())));
					}
				}
				text += " ) ";
				text = " AND (" + text + ") ";
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
	}

	public string GetAllElementSqlWhereForDatatable()
	{
		string text = "";
		checked
		{
			try
			{
				int num = Item(0).FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					text = ((Operators.CompareString(text, "", false) == 0) ? (text + " ( ") : (text + ") OR ( "));
					int num2 = Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (j > 0)
						{
							text += " AND ";
						}
						text = text + Item(j).FieldName + "=";
						text = ((Operators.CompareString(Item(j).FieldType.ToUpper(), "DateTime".ToUpper(), false) != 0) ? (text + ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).DbConn.SQLFormatString(Item(j).get_FieldValues(i).ToString())) : (text + "#" + Strings.Format((object)Item(j).get_FieldValues(i).ToString(), "MM/dd/yyyy") + "#"));
					}
				}
				text += " ) ";
				text = " AND (" + text + ") ";
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
	}
}
