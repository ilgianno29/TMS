using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Windows.Library.PDF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class BaseFunctions
{
	private class ListItemComparer : IComparer<ListItem>
	{
		public int Compare(ListItem x, ListItem y)
		{
			CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
			return caseInsensitiveComparer.Compare(x.Text, y.Text);
		}

		int IComparer<ListItem>.Compare(ListItem x, ListItem y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(x, y);
		}
	}

	private class ListItemNumberedComparer : IComparer<ListItem>
	{
		public int Compare(ListItem x, ListItem y)
		{
			if (Versioned.IsNumeric((object)x.Text) & Versioned.IsNumeric((object)y.Text))
			{
				if (Conversions.ToInteger(x.Text) > Conversions.ToInteger(y.Text))
				{
					return 1;
				}
				if (Conversions.ToInteger(x.Text) < Conversions.ToInteger(y.Text))
				{
					return -1;
				}
				return 0;
			}
			CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
			return caseInsensitiveComparer.Compare(x.Text, y.Text);
		}

		int IComparer<ListItem>.Compare(ListItem x, ListItem y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(x, y);
		}
	}

	private WFIPage _StandardPage;

	private DBConnection DbConn => _StandardPage.DbConn;

	private string CallStack => _StandardPage.CallStack;

	public static IboSessionEnvironment SessionEnvironment
	{
		get
		{
			IboSessionEnvironment result;
			try
			{
				result = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public BaseFunctions(ref WFIPage objStandardPage)
	{
		_StandardPage = objStandardPage;
	}

	private string TranslateMessage(string vsID, string vsDefault, params string[] vParametri)
	{
		return _StandardPage.TranslateMessage(vsID, vsDefault, vParametri);
	}

	private string TranslateMessage(string vsID, string vsDefault)
	{
		return _StandardPage.TranslateMessage(vsID, vsDefault);
	}

	private void CallStackAdd()
	{
		_StandardPage.CallStackAdd();
	}

	private void CallStackReset()
	{
		_StandardPage.CallStackReset();
	}

	private void CallStackRemove()
	{
		_StandardPage.CallStackRemove();
	}

	private void WriteErrorMessage(string vsMessaggio)
	{
		_StandardPage.WriteErrorMessage(vsMessaggio);
	}

	private void WriteErrorMessage(string vsMessaggio, string sTitle)
	{
		_StandardPage.WriteErrorMessage(vsMessaggio, sTitle);
	}

	private FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return _StandardPage.HandleError(ref objEx, ref rsMess);
	}

	private FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return _StandardPage.HandleError(ref objEx, vsMessage, ref rsMess);
	}

	public FXRETURN LoadDropDownList(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataSource = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(vsSelect.Trim(), "", false) == 0)
			{
				goto IL_00be;
			}
			val2 = DbConn.OpenDataTable(vsSelect, ref dataSource, ref rsMess);
			if ((int)val2 <= 0)
			{
				robjDropDownList.ItemClear();
				robjDropDownList.DataSource = dataSource;
				robjDropDownList.DataTextField = vsTextFieldAlias;
				robjDropDownList.DataValueField = vsValueFieldAlias;
				robjDropDownList.DataBind();
				robjDropDownList.HtmlDecodedSpaces();
				if (!robjDropDownList.ItemExist("") && vbBlankItem)
				{
					robjDropDownList.ItemInsert(0, "");
				}
				goto IL_00be;
			}
			goto end_IL_0007;
			IL_00be:
			val = (FXRETURN)0;
			end_IL_0007:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN LoadDropDownList(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, string vsFilter, string vsOrderByField, ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataSource = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(vsSelect.Trim(), "", false) == 0)
			{
				goto IL_0375;
			}
			if ((int)DbConn.ServerTypeConnection == 0)
			{
				text2 = ((robjDropDownList.SqlQueryTop != 0) ? ("TOP " + robjDropDownList.SqlQueryTop) : "TOP 100 PERCENT");
			}
			else if ((int)DbConn.ServerTypeConnection == 1)
			{
				text2 = ((robjDropDownList.SqlQueryTop != 0) ? ("ROWNUM<=" + robjDropDownList.SqlQueryTop) : "");
			}
			if ((int)DbConn.ServerTypeConnection == 0)
			{
				text = "SELECT " + text2 + " * FROM (" + vsSelect + ") T WHERE 1=1 ";
			}
			else
			{
				text = "SELECT * FROM (" + vsSelect + ") T WHERE 1=1 ";
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text = text + "AND " + text2 + " ";
				}
			}
			if (Operators.CompareString(vsFilter, "", false) != 0)
			{
				text = text + "AND (" + vsFilter + ") ";
			}
			if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
			{
				text = text + "AND (" + robjDropDownList.SqlQueryWhere + ") ";
			}
			if (robjDropDownList.ObjValue != null && Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) != 0)
			{
				text = text + " UNION " + vsSelect + " WHERE " + vsValueFieldAlias + " = " + DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
			}
			if (Operators.CompareString(vsOrderByField, "", false) != 0)
			{
				text = text + " ORDER BY " + vsOrderByField + " ";
			}
			_StandardPage.PerformanceLogAppend(text);
			val2 = DbConn.OpenDataTable(text, ref dataSource, ref rsMess);
			if ((int)val2 <= 0)
			{
				string objValue = "";
				if (robjDropDownList.ObjValue != null && Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) != 0)
				{
					objValue = robjDropDownList.ObjValue.ToString();
				}
				robjDropDownList.ItemClear();
				robjDropDownList.DataTextField = vsTextFieldAlias;
				robjDropDownList.DataValueField = vsValueFieldAlias;
				robjDropDownList.DataSource = dataSource;
				try
				{
					robjDropDownList.DataBind();
					robjDropDownList.ObjValue = objValue;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				robjDropDownList.HtmlDecodedSpaces();
				if (!robjDropDownList.ItemExist("") && vbBlankItem)
				{
					robjDropDownList.ItemInsert(0, "");
				}
				goto IL_0375;
			}
			goto end_IL_0015;
			IL_0375:
			val = (FXRETURN)0;
			end_IL_0015:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN LoadDropDownList(ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LoadDropDownList(robjDropDownList.SqlQuery, robjDropDownList.CampoDescrizione, robjDropDownList.CampoCodice, robjDropDownList.SqlQueryFilter, robjDropDownList.SqlQueryOrderBy, ref robjDropDownList, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public FXRETURN LoadDropDownList(ref IboDropDownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList robjDropDownList2 = (IIboDropdownList)(object)robjDropDownList;
		return LoadDropDownList(ref robjDropDownList2, ref rsMess);
	}

	public FXRETURN LoadListBox(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, ref ListBox robjListBox, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataSource = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = DbConn.OpenDataTable(vsSelect, ref dataSource, ref rsMess);
			if ((int)val2 <= 0)
			{
				((ListControl)robjListBox).Items.Clear();
				((BaseDataBoundControl)robjListBox).DataSource = dataSource;
				((ListControl)robjListBox).DataTextField = vsTextFieldAlias;
				((ListControl)robjListBox).DataValueField = vsValueFieldAlias;
				((BaseDataBoundControl)robjListBox).DataBind();
				if (vbBlankItem)
				{
					((ListControl)robjListBox).Items.Insert(0, "");
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public void SortDropDownList(DropDownList cbo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		List<ListItem> list = new List<ListItem>();
		foreach (ListItem item2 in ((ListControl)cbo).Items)
		{
			ListItem item = item2;
			list.Add(item);
		}
		list.Sort(new ListItemComparer());
		((ListControl)cbo).Items.Clear();
		((ListControl)cbo).Items.AddRange(list.ToArray());
	}

	public void SortNumberedDropDownList(DropDownList cbo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		List<ListItem> list = new List<ListItem>();
		foreach (ListItem item2 in ((ListControl)cbo).Items)
		{
			ListItem item = item2;
			list.Add(item);
		}
		list.Sort(new ListItemNumberedComparer());
		((ListControl)cbo).Items.Clear();
		((ListControl)cbo).Items.AddRange(list.ToArray());
	}

	public void SortDropDownList(IIboDropdownList cbo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (cbo is IboDropDownList)
		{
			((IboDropDownList)cbo).Sort();
		}
		else if (cbo is IboWebComboTlk)
		{
			((RadComboBox)(IboWebComboTlk)cbo).SortItems((IComparer)new CaseInsensitiveComparer());
		}
	}

	public FXRETURN LoadGrid(string vsNomRif, ref IboGridView objGridView, ref DataTable objDataTable, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			IboGridInfo rObjGridInfo = null;
			IboWebGridConfig rObjGridConfig = null;
			val2 = LoadGrid(vsNomRif, ref objGridView, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(string vsNomRif, ref IboGridView objGridView, ref DataTable objDataTable, ref IboGridInfo rObjGridInfo, ref IboWebGridConfig rObjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo robjGridInfo = null;
		IboWebGridConfig robjGridConfig = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = _StandardPage.SessionEnvironment.GridInfoList.Add(vsNomRif, ref robjGridInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				IboGridConfigList gridConfigList = _StandardPage.SessionEnvironment.GridConfigList;
				IboWebLabel rObjGridTitleLabel = null;
				IboWebLabel rObjGridFilterLabel = null;
				IboWebLabel rObjNumeroRecordTotali = null;
				val2 = gridConfigList.Add(vsNomRif, ref robjGridInfo, ref objGridView, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref robjGridConfig, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (objDataTable != null)
					{
						robjGridConfig.DataTableSource = objDataTable;
					}
					if ((int)robjGridConfig.ApplyConfig(ref rsMess) <= 0)
					{
						rObjGridConfig = robjGridConfig;
						rObjGridInfo = robjGridInfo;
						val = (FXRETURN)0;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(string vsNomRif, ref IboGridView objGridView, ref string sSql, ref IboGridInfo rObjGridInfo, ref IboWebGridConfig rObjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable objDataTable = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = DbConn.OpenDataTable(sSql, ref objDataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = LoadGrid(vsNomRif, ref objGridView, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(string vsNomRif, ref RadGrid objGridViewTlk, ref DataTable objDataTable, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			IboGridInfo rObjGridInfo = null;
			IboWebGridConfigTlk rObjGridConfig = null;
			val2 = LoadGrid(vsNomRif, ref objGridViewTlk, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(string vsNomRif, ref RadGrid objGridViewTlk, ref DataTable objDataTable, ref IboGridInfo rObjGridInfo, ref IboWebGridConfigTlk rObjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo robjGridInfo = null;
		IboWebGridConfigTlk robjGridConfig = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = _StandardPage.SessionEnvironment.GridInfoList.Add(vsNomRif, ref robjGridInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				IboGridConfigList gridConfigList = _StandardPage.SessionEnvironment.GridConfigList;
				IboWebLabel rObjGridTitleLabel = null;
				IboWebLabel rObjGridFilterLabel = null;
				IboWebLabel rObjNumeroRecordTotali = null;
				val2 = gridConfigList.Add(vsNomRif, ref robjGridInfo, ref objGridViewTlk, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref robjGridConfig, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (objDataTable != null)
					{
						robjGridConfig.DataTableSource = objDataTable;
					}
					if ((int)robjGridConfig.ApplyConfig(ref rsMess) <= 0)
					{
						rObjGridConfig = robjGridConfig;
						rObjGridInfo = robjGridInfo;
						val = (FXRETURN)0;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(string vsNomRif, ref RadGrid objGridViewTlk, ref string sSql, ref IboGridInfo rObjGridInfo, ref IboWebGridConfigTlk rObjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable objDataTable = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = DbConn.OpenDataTable(sSql, ref objDataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = LoadGrid(vsNomRif, ref objGridViewTlk, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN LoadGridMS(ref IboInternalGridConfig ObjInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo rObjGridInfo = null;
		IboWebGridConfig rObjGridConfig = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			if (ObjInternalGridConfig.GridType != 0 || !ObjInternalGridConfig.Attivo)
			{
				goto IL_01a3;
			}
			if (ObjInternalGridConfig.DataTable == null)
			{
				if (Operators.CompareString(ObjInternalGridConfig.SqlStatement, "", false) == 0)
				{
					goto IL_012a;
				}
				string nomRif = ObjInternalGridConfig.NomRif;
				IboInternalGridConfig iboInternalGridConfig;
				IboGridView objGridView = (iboInternalGridConfig = ObjInternalGridConfig).GridView;
				IboInternalGridConfig iboInternalGridConfig2;
				string sSql = (iboInternalGridConfig2 = ObjInternalGridConfig).SqlStatement;
				FXRETURN val3 = LoadGrid(nomRif, ref objGridView, ref sSql, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				iboInternalGridConfig2.SqlStatement = sSql;
				iboInternalGridConfig.GridView = objGridView;
				val2 = val3;
				if ((int)val2 <= 0)
				{
					ObjInternalGridConfig.DataTable = rObjGridConfig.LastDataTableSource;
					goto IL_012a;
				}
				val = val2;
			}
			else
			{
				string nomRif2 = ObjInternalGridConfig.NomRif;
				IboInternalGridConfig iboInternalGridConfig2;
				IboGridView objGridView = (iboInternalGridConfig2 = ObjInternalGridConfig).GridView;
				IboInternalGridConfig iboInternalGridConfig;
				DataTable objDataTable = (iboInternalGridConfig = ObjInternalGridConfig).DataTable;
				FXRETURN val4 = LoadGrid(nomRif2, ref objGridView, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				iboInternalGridConfig.DataTable = objDataTable;
				iboInternalGridConfig2.GridView = objGridView;
				val2 = val4;
				if ((int)val2 <= 0)
				{
					goto IL_012a;
				}
				val = val2;
			}
			goto end_IL_000a;
			IL_012a:
			ObjInternalGridConfig.GridInfo = rObjGridInfo;
			ObjInternalGridConfig.GridConfig = rObjGridConfig;
			if (ObjInternalGridConfig.lblTitle != null)
			{
				try
				{
					ObjInternalGridConfig.lblTitle.Text = _StandardPage.SessionEnvironment.GridInfoList[ObjInternalGridConfig.NomRif].AllGrd["DesTab"].ToString();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			goto IL_01a3;
			IL_01a3:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN LoadGridTlk(ref IboInternalGridConfig ObjInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo rObjGridInfo = null;
		IboWebGridConfigTlk rObjGridConfig = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			if (ObjInternalGridConfig.GridType != IboInternalGridGridType.Telerik || !ObjInternalGridConfig.Attivo)
			{
				goto IL_01a3;
			}
			if (ObjInternalGridConfig.DataTable == null)
			{
				if (Operators.CompareString(ObjInternalGridConfig.SqlStatement, "", false) == 0)
				{
					goto IL_012a;
				}
				string nomRif = ObjInternalGridConfig.NomRif;
				IboInternalGridConfig iboInternalGridConfig;
				RadGrid objGridViewTlk = (iboInternalGridConfig = ObjInternalGridConfig).GridViewTlk;
				IboInternalGridConfig iboInternalGridConfig2;
				string sSql = (iboInternalGridConfig2 = ObjInternalGridConfig).SqlStatement;
				FXRETURN val3 = LoadGrid(nomRif, ref objGridViewTlk, ref sSql, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				iboInternalGridConfig2.SqlStatement = sSql;
				iboInternalGridConfig.GridViewTlk = objGridViewTlk;
				val2 = val3;
				if ((int)val2 <= 0)
				{
					ObjInternalGridConfig.DataTable = rObjGridConfig.LastDataTableSource;
					goto IL_012a;
				}
				val = val2;
			}
			else
			{
				string nomRif2 = ObjInternalGridConfig.NomRif;
				IboInternalGridConfig iboInternalGridConfig2;
				RadGrid objGridViewTlk = (iboInternalGridConfig2 = ObjInternalGridConfig).GridViewTlk;
				IboInternalGridConfig iboInternalGridConfig;
				DataTable objDataTable = (iboInternalGridConfig = ObjInternalGridConfig).DataTable;
				FXRETURN val4 = LoadGrid(nomRif2, ref objGridViewTlk, ref objDataTable, ref rObjGridInfo, ref rObjGridConfig, ref rsMess);
				iboInternalGridConfig.DataTable = objDataTable;
				iboInternalGridConfig2.GridViewTlk = objGridViewTlk;
				val2 = val4;
				if ((int)val2 <= 0)
				{
					goto IL_012a;
				}
				val = val2;
			}
			goto end_IL_000a;
			IL_012a:
			ObjInternalGridConfig.GridInfo = rObjGridInfo;
			ObjInternalGridConfig.GridConfig = rObjGridConfig;
			if (ObjInternalGridConfig.lblTitle != null)
			{
				try
				{
					ObjInternalGridConfig.lblTitle.Text = _StandardPage.SessionEnvironment.GridInfoList[ObjInternalGridConfig.NomRif].AllGrd["DesTab"].ToString();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			goto IL_01a3;
			IL_01a3:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LoadGrid(ref IboInternalGridConfig ObjInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo iboGridInfo = null;
		IboWebGridConfig iboWebGridConfig = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = LoadGridMS(ref ObjInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = LoadGridTlk(ref ObjInternalGridConfig, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN GetKeyDataFromGrid(string sNomRif, ref DataKeyFieldCollection robjData, bool bSelezioneObbligatoria, ref IboGridView grdGriglia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldValues dataKeyFieldValues = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				if (bSelezioneObbligatoria && grdGriglia.GetSelectedIndices().Length == 0)
				{
					rsMess = TranslateMessage("XXX", "E' Necessario selezionare almeno un record.");
					val = (FXRETURN)4;
				}
				else
				{
					if (robjData == null)
					{
						robjData = new DataKeyFieldCollection();
					}
					else
					{
						robjData.Clear();
					}
					if (_StandardPage.SessionEnvironment.GridInfoList.ContainsKey(sNomRif))
					{
						IboGridInfo iboGridInfo = _StandardPage.SessionEnvironment.GridInfoList[sNomRif];
						int i = default(int);
						for (; i < grdGriglia.GetSelectedIndices().Count(); i++)
						{
							((GridView)grdGriglia).SelectedIndex = grdGriglia.GetSelectedIndices()[i];
							for (int j = 0; j < ((GridView)grdGriglia).DataKeyNames.Length; j++)
							{
								if (i == 0)
								{
									dataKeyFieldValues = new DataKeyFieldValues(((GridView)grdGriglia).DataKeyNames[j], iboGridInfo.get_CampoTipo(((GridView)grdGriglia).DataKeyNames[j]));
									robjData.Add(dataKeyFieldValues);
								}
								robjData.Item(((GridView)grdGriglia).DataKeyNames[j]).FieldValuesAdd(RuntimeHelpers.GetObjectValue(((GridView)grdGriglia).DataKeys[((GridView)grdGriglia).SelectedIndex].Values[((GridView)grdGriglia).DataKeyNames[j]]));
							}
						}
						val = (FXRETURN)0;
					}
					else
					{
						rsMess = TranslateMessage("XXX", "La configurazione della griglia {0} non è stata caricata", sNomRif);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				val = HandleError(ref objEx, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
				CallStackRemove();
			}
			return result;
		}
	}

	public FXRETURN StandardParser(string sComando, ref Hashtable sRetColl, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Hashtable hashtable = new Hashtable();
		FXRETURN result;
		try
		{
			string[] array = Strings.Split(sComando, ";", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					string[] array3 = Strings.Split(text, "=", -1, (CompareMethod)0);
					hashtable.Add(array3[0], array3[1]);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			hashtable = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			sRetColl = hashtable;
			result = val;
		}
		return result;
	}

	public FXRETURN StandardVariableFinder(string sComando, ref Hashtable sRetColl, ref string rsMess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return StandardVariableFinder("<%", "%>", sComando, ref sRetColl, ref rsMess);
	}

	public FXRETURN StandardVariableFinder(string startChars, string EndChars, string sComando, ref Hashtable sRetColl, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Hashtable hashtable = new Hashtable();
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		checked
		{
			FXRETURN result;
			try
			{
				while (Operators.CompareString(sComando, "", false) != 0)
				{
					int num = Strings.InStr(sComando, startChars, (CompareMethod)0) - 1;
					int num2 = Strings.InStr(sComando, EndChars, (CompareMethod)0) + 2;
					if (unchecked(num < num2 && num > -1 && num2 > 2))
					{
						text = Strings.Left(sComando, num);
						text2 = Strings.Mid(sComando, num2);
						text3 = Strings.Mid(sComando, num + 1, num2 - num - 1);
						text4 = Strings.Mid(text3, 3, text3.Length - 4);
						if (!hashtable.ContainsKey(text4))
						{
							hashtable.Add(text4, text3);
						}
						sComando = text2;
					}
					else
					{
						sComando = "";
					}
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				val = HandleError(ref objEx, ref rsMess);
				hashtable = null;
				ProjectData.ClearProjectError();
			}
			finally
			{
				sRetColl = hashtable;
				result = val;
			}
			return result;
		}
	}

	public string StandardNameFilter(string sNomeCampo)
	{
		string text = "";
		int[] array = null;
		text = sNomeCampo;
		text = Strings.Replace(text, "_", " ", 1, -1, (CompareMethod)0);
		checked
		{
			int num = text.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if (i > 0 && ((Operators.CompareString(Conversions.ToString(text[i]), "A", false) >= 0) & (Operators.CompareString(Conversions.ToString(text[i]), "Z", false) <= 0)) && !((Operators.CompareString(Conversions.ToString(text[i - 1]), "A", false) >= 0) & (Operators.CompareString(Conversions.ToString(text[i - 1]), "Z", false) <= 0)))
				{
					array = (int[])Utils.CopyArray((Array)array, (Array)new int[num2 + 1]);
					array[num2] = i;
					num2++;
				}
			}
			if (num2 > 0)
			{
				int upperBound = array.GetUpperBound(0);
				for (int j = 0; j <= upperBound; j++)
				{
					text = text.Insert(array[j] + j, " ");
				}
			}
			return text;
		}
	}

	public string HtmlDecodedSpaces(int numberOfSpaces)
	{
		string text = "";
		checked
		{
			int num = numberOfSpaces - 1;
			for (int i = 0; i <= num; i++)
			{
				text += "&nbsp;";
			}
			return HttpUtility.HtmlDecode(text);
		}
	}

	public FXRETURN IsValidEmail(string strEmail, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return IboMailer.IsValidEmail(strEmail, ref rsMess);
	}

	public string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public void CloneDataTable(DataTable dtSource, ref DataTable dtDestination)
	{
		dtDestination = dtSource.Clone();
		foreach (DataRow row in dtSource.Rows)
		{
			dtDestination.ImportRow(row);
		}
	}

	public void CloneDataTable(DataTable dtSource, string FilterExpression, string sort, ref DataTable dtDestination)
	{
		dtDestination = dtSource.Clone();
		DataRow[] array = dtSource.Select(FilterExpression, sort);
		DataRow[] array2 = array;
		foreach (DataRow row in array2)
		{
			dtDestination.ImportRow(row);
		}
	}

	public FXRETURN PdfMerge(StringCollection PdfFiles, ref byte[] PdfBytes, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			List<byte[]> list = new List<byte[]>();
			StringEnumerator enumerator = PdfFiles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (File.Exists(current))
				{
					list.Add(File.ReadAllBytes(current));
				}
			}
			PdfBytes = PdfMerger.MergeFiles(list);
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public static Control IboFindControl(ref Control robjContainerControl, string vsControlId)
	{
		Control val = null;
		val = robjContainerControl.FindControl(vsControlId);
		if (val == null)
		{
			int i = default(int);
			for (; i < robjContainerControl.Controls.Count && val == null; i = checked(i + 1))
			{
				if (robjContainerControl.HasControls())
				{
					Control robjContainerControl2 = robjContainerControl.Controls[i];
					val = IboFindControl(ref robjContainerControl2, vsControlId);
					if (val != null && Operators.CompareString(val.ID, vsControlId, false) != 0)
					{
						val = null;
					}
				}
			}
		}
		return val;
	}

	public static Control IboFindControl(ref Page robjContainerControl, string vsControlId)
	{
		Control val = null;
		val = robjContainerControl.FindControl(vsControlId);
		if (val == null)
		{
			int i = default(int);
			for (; i < ((Control)robjContainerControl).Controls.Count && val == null; i = checked(i + 1))
			{
				if (((Control)robjContainerControl).HasControls())
				{
					Control robjContainerControl2 = ((Control)robjContainerControl).Controls[i];
					val = IboFindControl(ref robjContainerControl2, vsControlId);
				}
			}
		}
		return val;
	}

	public string FindFormDirMember(string url)
	{
		return FindFormDir(url);
	}

	public static string FindFormDir(string url)
	{
		if ((Operators.CompareString(Strings.Left(url, 1), "~", false) != 0) & (Operators.CompareString(url, "", false) != 0))
		{
			url = "~" + url;
		}
		string text = "";
		url = Strings.Replace(url, "/Form/", "/FORM/", 1, -1, (CompareMethod)0).Replace("/form/", "/FORM/");
		string text2 = url;
		string text3 = text2.Replace("~/" + Assembly.GetExecutingAssembly().GetName().Name.ToUpper() + "/", "~/CUSTOM/");
		text3 = text3.Replace("~\\" + Assembly.GetExecutingAssembly().GetName().Name.ToUpper() + "\\", "~\\CUSTOM\\");
		if (File.Exists(HttpContext.Current.Server.MapPath(text3.Split(new char[1] { '?' })[0])))
		{
			text = text3;
		}
		else if (File.Exists(HttpContext.Current.Server.MapPath(text2.Split(new char[1] { '?' })[0])))
		{
			text = text2;
		}
		else
		{
			string text4 = text2;
			text4 = Strings.Left(text4, Strings.InStrRev(text4, "/", -1, (CompareMethod)0));
			text4 = HttpContext.Current.Server.MapPath(text4);
			text = text2;
			if (text4.Contains("\\FORM\\"))
			{
				text4 = text4.Replace("\\FORM\\", "\\");
				string[] directories = Directory.GetDirectories(text4, "FORM_*");
				string[] array = directories;
				foreach (string text5 in array)
				{
					string text6 = text2;
					text6 = text6.Replace("/FORM/", "/" + text5.Replace(text4, "") + "/");
					if (File.Exists(HttpContext.Current.Server.MapPath(text6.Split(new char[1] { '?' })[0])))
					{
						text = text6;
						break;
					}
				}
			}
		}
		return text;
	}

	public static void IboResponseRedirect(ref IboAppCallStackHandling robjCallStackHandler, ref string sUrl, bool RegisterPageInQueue = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string text = "";
		IboCrypt val = new IboCrypt();
		try
		{
			robjCallStackHandler.CallStackReset();
			string[] source;
			if (!((Strings.InStr(sUrl, "&IdSessione=", (CompareMethod)0) > 0) | (Strings.InStr(sUrl, "?IdSessione=", (CompareMethod)0) > 0)))
			{
				source = Strings.Split(sUrl, "?", -1, (CompareMethod)0);
				if (source.Count() >= 2)
				{
					sUrl += "&";
				}
				else
				{
					sUrl += "?";
				}
				sUrl = sUrl + "IdSessione=" + HttpContext.Current.Session.SessionID;
			}
			if ((SessionEnvironment.ActualWfiPageObject.IsInFrame | SessionEnvironment.ActualWfiPageObject.IsAllreadyInIFrame) && !((Strings.InStr(sUrl, "&IsAllreadyInIFrame=", (CompareMethod)0) > 0) | (Strings.InStr(sUrl, "?IsAllreadyInIFrame=", (CompareMethod)0) > 0)))
			{
				sUrl += "&IsAllreadyInIFrame=S";
			}
			HttpContext.Current.Response.Clear();
			source = Strings.Split(sUrl, "?", -1, (CompareMethod)0);
			if (RegisterPageInQueue && HttpContext.Current.Handler is WFIPage)
			{
				Queue<string> queue = (Queue<string>)HttpContext.Current.Session["LastWfiPages"];
				if (queue != null)
				{
					queue.Enqueue(HttpContext.Current.Request.Url.PathAndQuery);
					if (queue.Count > 20)
					{
						queue.Dequeue();
					}
				}
			}
			if (HttpContext.Current.Handler is WFIPage wFIPage2)
			{
				((Page)wFIPage2).Visible = false;
			}
			if (source.Count() == 2)
			{
				text = source[1];
				HttpContext.Current.Response.Redirect(source[0] + "?ck=" + val.EncryptString128Bit(text), false);
			}
			else
			{
				HttpContext.Current.Response.Redirect(sUrl, false);
			}
			HttpContext.Current.ApplicationInstance.CompleteRequest();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string CryptQueryString(string sUrl)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string text = "";
		IboCrypt val = new IboCrypt();
		string result;
		try
		{
			string[] array = Strings.Split(sUrl, "?", -1, (CompareMethod)0);
			if (array.Count() == 2)
			{
				text = array[1];
				text = array[0] + "?ck=" + val.EncryptString128Bit(text);
			}
			else
			{
				text = array[0];
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
			result = text;
		}
		return result;
	}

	public static string OnlyAspxPageName(string Percorso)
	{
		string result;
		try
		{
			string text = Strings.Replace(Percorso, "/", "\\", 1, -1, (CompareMethod)0);
			if (Strings.InStrRev(text, "\\", -1, (CompareMethod)0) >= 0)
			{
				text = Strings.Mid(text, checked(Strings.InStrRev(text, "\\", -1, (CompareMethod)0) + 1));
			}
			result = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object InstantiateClass(string parameter, string ClassName)
	{
		Type type = Type.GetType(ClassName);
		ConstructorInfo constructor = type.GetConstructor(new Type[1] { typeof(string) });
		if ((object)constructor == null)
		{
			throw new Exception("Costruttore non trovato per la classe " + type.FullName);
		}
		object objectValue = RuntimeHelpers.GetObjectValue(constructor.Invoke(new object[1] { parameter }));
		if (objectValue == null)
		{
			throw new ArgumentException("Can't instantiate type " + type.FullName);
		}
		return objectValue;
	}

	public static object InstantiateClass(string ClassName)
	{
		Type type = Type.GetType(ClassName);
		if ((object)type == null)
		{
			throw new Exception("Class " + ClassName + " not found");
		}
		Type[] types = new Type[0];
		ConstructorInfo constructor = type.GetConstructor(types);
		if ((object)constructor == null)
		{
			throw new Exception("Costruttore non trovato per la classe " + type.FullName);
		}
		object objectValue = RuntimeHelpers.GetObjectValue(constructor.Invoke(new object[0]));
		if (objectValue == null)
		{
			throw new ArgumentException("Can't instantiate type " + type.FullName);
		}
		return objectValue;
	}

	public static bool IsDecimal(string Expression, ref decimal dRet)
	{
		Expression = Strings.Replace(Expression.ToString(), NumberFormatInfo.CurrentInfo.NumberGroupSeparator, NumberFormatInfo.CurrentInfo.NumberDecimalSeparator, 1, -1, (CompareMethod)0);
		decimal result;
		bool result2 = decimal.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out result);
		dRet = result;
		return result2;
	}

	public static bool IsDouble(string Expression, ref double dRet)
	{
		Expression = Strings.Replace(Expression.ToString(), NumberFormatInfo.CurrentInfo.NumberGroupSeparator, NumberFormatInfo.CurrentInfo.NumberDecimalSeparator, 1, -1, (CompareMethod)0);
		double result;
		bool result2 = double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out result);
		dRet = result;
		return result2;
	}

	public static bool IsInteger(object Expression, ref int iRet)
	{
		int result;
		bool result2 = int.TryParse(Convert.ToString(RuntimeHelpers.GetObjectValue(Expression)), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result);
		iRet = result;
		return result2;
	}

	public object GetPropertyValue(ref object objInstance, string sNomeCampo)
	{
		PropertyInfo property = objInstance.GetType().GetProperty(sNomeCampo);
		return property.GetValue(RuntimeHelpers.GetObjectValue(objInstance), null);
	}

	public void SetPropertyValue(ref object objInstance, string sNomeCampo, object objValore)
	{
		PropertyInfo property = objInstance.GetType().GetProperty(sNomeCampo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		property.SetValue(RuntimeHelpers.GetObjectValue(objInstance), RuntimeHelpers.GetObjectValue(objValore), null);
	}

	public void ResizeImage(string percorsoImmagine, int DimensioneLatoMaggiore, ref string PercorsImmagineRidimensionata)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		Bitmap val = new Bitmap(percorsoImmagine);
		string text = Path.GetExtension(percorsoImmagine).Replace(".", "");
		int width = ((System.Drawing.Image)val).Width;
		int height = ((System.Drawing.Image)val).Height;
		int num;
		int num2;
		if (width <= DimensioneLatoMaggiore && height <= DimensioneLatoMaggiore)
		{
			num = width;
			num2 = height;
		}
		else if (width > height)
		{
			num = DimensioneLatoMaggiore;
			num2 = checked((int)Math.Round((double)DimensioneLatoMaggiore * ((double)height / (double)width)));
		}
		else
		{
			num2 = DimensioneLatoMaggiore;
			num = checked((int)Math.Round((double)DimensioneLatoMaggiore * ((double)width / (double)height)));
		}
		Bitmap val2 = new Bitmap(num, num2);
		Graphics val3 = Graphics.FromImage((System.Drawing.Image)(object)val2);
		val3.InterpolationMode = (InterpolationMode)7;
		val3.DrawImage((System.Drawing.Image)(object)val, new Rectangle(0, 0, num, num2), new Rectangle(0, 0, ((System.Drawing.Image)val).Width, ((System.Drawing.Image)val).Height), (GraphicsUnit)2);
		string text2 = "thumb_" + Path.GetFileName(percorsoImmagine);
		string text3 = Path.GetDirectoryName(percorsoImmagine) + "\\";
		if ((Operators.CompareString(text.ToUpper(), "JPG", false) == 0) | (Operators.CompareString(text.ToUpper(), "JPEG", false) == 0))
		{
			((System.Drawing.Image)val2).Save(text3 + text2, ImageFormat.Jpeg);
		}
		else if (Operators.CompareString(text.ToUpper(), "PNG", false) == 0)
		{
			((System.Drawing.Image)val2).Save(text3 + text2, ImageFormat.Png);
		}
		PercorsImmagineRidimensionata = text3 + text2;
		val3.Dispose();
		((System.Drawing.Image)val).Dispose();
		((System.Drawing.Image)val2).Dispose();
	}

	public byte[] BitmapToByteArray(Bitmap bmp)
	{
		MemoryStream memoryStream = new MemoryStream();
		((System.Drawing.Image)bmp).Save((Stream)memoryStream, ImageFormat.Jpeg);
		byte[] result = memoryStream.ToArray();
		((System.Drawing.Image)bmp).Dispose();
		memoryStream.Close();
		memoryStream.Dispose();
		return result;
	}

	public System.Drawing.Image ByteArrayToImage(byte[] bmpBytes)
	{
		MemoryStream memoryStream = new MemoryStream(bmpBytes);
		return System.Drawing.Image.FromStream((Stream)memoryStream);
	}
}
