using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class IboWebGridConfigTlk : IboWebGridConfig
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("_objGridViewTlk")]
	private RadGrid __objGridViewTlk;

	protected new string _objGridView;

	protected string _PagerTextFormat;

	protected bool _ImpostaFiltro;

	protected virtual RadGrid _objGridViewTlk
	{
		[CompilerGenerated]
		get
		{
			return __objGridViewTlk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = _objGridViewTlk_DataBound;
			RadGrid val = __objGridViewTlk;
			if (val != null)
			{
				((BaseDataBoundControl)val).DataBound -= eventHandler;
			}
			__objGridViewTlk = value;
			val = __objGridViewTlk;
			if (val != null)
			{
				((BaseDataBoundControl)val).DataBound += eventHandler;
			}
		}
	}

	public IboWebGridConfigTlk(ref IboGridInfo rObjGridInfo, ref RadGrid rObjGridViewTlk, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
		: base(ref rObjGridInfo, ref Incasbo.Compat.RefBox.Of<IboGridView>(null), ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo)
	{
		_objGridView = "";
		_PagerTextFormat = "{4}<span id=\"TotaleElementiTlk\" Title=\"<%TOOLTIP%>\"><strong>{5}</strong> Elementi in <strong>{1}</strong> pagine <%ASTERISCO%></span>";
		_ImpostaFiltro = false;
		_objGridViewTlk = rObjGridViewTlk;
	}

	public override FXRETURN AnnullaFiltri(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = base.AnnullaFiltri(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_objGridViewTlk.Rebind();
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public override FXRETURN Aggiorna(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			base.DataTableSource = null;
			val2 = base.Aggiorna(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_objGridViewTlk.Rebind();
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public void Reinit(ref IboGridInfo rObjGridInfo, ref RadGrid rObjGridViewTlk, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali)
	{
		IboGridView rObjGridView = null;
		base.Reinit(ref rObjGridInfo, ref rObjGridView, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali);
		_objGridViewTlk = rObjGridViewTlk;
	}

	public override FXRETURN Carica_Dati(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Invalid comparison between Unknown and I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtTemp = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (base.DataTableSource != null)
			{
				_objGridViewTlk.DataSource = null;
				dtTemp = _DataTableSource;
				goto IL_00e5;
			}
			_GridInfo.SqlStatement.SqlTopClause = _GridInfo.TopClause;
			text = _GridInfo.SqlStatement.ToString();
			if (Operators.CompareString(text, "", false) == 0)
			{
				rsMess = _Translator.TranslateMessage("XXX", "Comando sql vuoto", new string[0]);
			}
			else
			{
				_objGridViewTlk.DataSource = null;
				if ((int)_dbMain.OpenDataTable(text, ref dtTemp, ref rsMess) <= 0)
				{
					goto IL_00e5;
				}
			}
			goto end_IL_0015;
			IL_00e5:
			val2 = _GridInfo.Complete_Init_TabGrd(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (_LastDataTable != null)
				{
					try
					{
						_LastDataTable.Dispose();
						_LastDataTable = null;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				_LastDataTable = dtTemp;
				_LastUsage = DateTime.Now;
				((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).LastGridDataTable = dtTemp;
				for (int i = 0; i < _GridInfo.TabGrdTable.Rows.Count; i = checked(i + 1))
				{
					if ((Operators.CompareString(_GridInfo.TabGrdTable.Rows[i]["ISKEY"].ToString(), "S", false) == 0) | (Operators.CompareString(_GridInfo.TabGrdTable.Rows[i]["ISKEY"].ToString(), "X", false) == 0))
					{
						if (text2.Length > 0)
						{
							text2 += ";";
						}
						text2 += _GridInfo.TabGrdTable.Rows[i]["NOMCAM"].ToString();
					}
				}
				if (text2.Length > 0)
				{
					_objGridViewTlk.MasterTableView.DataKeyNames = text2.Split(new char[1] { ';' });
				}
				_ImpostaFiltro = true;
				val2 = Carica_LookUp(ref dtTemp, ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
			end_IL_0015:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			val = _ObjIboAppLogHandling.HandleError(ref ex4, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public override FXRETURN ApplyColumnConfig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected O, but got Unknown
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				_objGridViewTlk.Columns.Clear();
				if (_GridInfo.SelectionColumnVisible)
				{
					GridClientSelectColumn val3 = new GridClientSelectColumn();
					((GridColumn)val3).UniqueName = _GridInfo.NomRif + "_ClientSelectColumn";
					_objGridViewTlk.Columns.Add((GridColumn)(object)val3);
				}
				if (Operators.CompareString(_GridInfo.AllGrd["CANEDIT"].ToString(), "S", false) == 0)
				{
				}
				int num = _GridInfo.TabGrd.Count - 1;
				HorizontalAlign val5 = default(HorizontalAlign);
				VerticalAlign val6 = default(VerticalAlign);
				for (int i = 0; i <= num; i++)
				{
					GridBoundColumn val4 = new GridBoundColumn();
					_objGridViewTlk.Columns.Add((GridColumn)(object)val4);
					((GridEditableColumn)val4).ReadOnly = true;
					((Style)((GridColumn)val4).ItemStyle).CssClass = "BoundField";
					if (Operators.CompareString(_GridInfo.TabGrd[i]["ISKEY"].ToString(), "S", false) == 0)
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((GridColumn)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " KeyField";
					}
					val4.DataField = _GridInfo.TabGrd[i]["NOMCAM"].ToString();
					if (Operators.CompareString(_GridInfo.TabGrd[i]["CANSORT"].ToString(), "S", false) == 0)
					{
						((GridColumn)val4).SortExpression = _GridInfo.TabGrd[i]["NOMCAMEXP"].ToString();
						if (Operators.CompareString(((GridColumn)val4).SortExpression, "", false) == 0)
						{
							((GridColumn)val4).SortExpression = _GridInfo.TabGrd[i]["NOMCAM"].ToString();
						}
					}
					else
					{
						((GridColumn)val4).SortExpression = "";
					}
					((GridColumn)val4).UniqueName = val4.DataField;
					((GridColumn)val4).HeaderText = _Translator.TranslateMessage("GRID.CAPTION." + _GridInfo.NomRif, _GridInfo.TabGrd[i]["DESCAM"].ToString(), new string[0]);
					string text = "";
					if (Operators.CompareString(_GridInfo.TabGrd[i]["ExtendedDesCam"].ToString(), "", false) != 0)
					{
						text = _Translator.TranslateMessage("GRID.CAPTION." + _GridInfo.NomRif, _GridInfo.TabGrd[i]["ExtendedDesCam"].ToString(), new string[0]);
					}
					else if ((_GridInfo.FixedLayout | (_GridInfo.ScrollHeight > 0)) && Operators.CompareString(text, "", false) == 0)
					{
						text = ((GridColumn)val4).HeaderText;
					}
					((GridColumn)val4).HeaderTooltip = text;
					((GridColumn)val4).Visible = Operators.CompareString(_GridInfo.TabGrd[i]["VISIBILE"].ToString(), "N", false) != 0;
					if (Operators.CompareString(_GridInfo.TabGrd[i]["VISIBILE"].ToString(), "H", false) == 0)
					{
						((GridColumn)val4).Display = false;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_GridInfo.TabGrd[i]["LARCAM"])))
					{
						if (Conversions.ToInteger(_GridInfo.TabGrd[i]["LARCAM"]) > 0)
						{
							((Style)((GridColumn)val4).HeaderStyle).Width = new Unit(Conversions.ToDouble(_GridInfo.TabGrd[i]["LARCAM"]));
							((Style)((GridColumn)val4).ItemStyle).Width = new Unit(Conversions.ToDouble(_GridInfo.TabGrd[i]["LARCAM"]));
						}
						else if (_GridInfo.FixedLayout)
						{
							((Style)((GridColumn)val4).HeaderStyle).Width = new Unit(90.0, (UnitType)7);
							((Style)((GridColumn)val4).ItemStyle).Width = new Unit(90.0, (UnitType)7);
						}
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["WRAPCOL"].ToString(), "", false) != 0)
					{
						((GridColumn)val4).ItemStyle.Wrap = Operators.CompareString(_GridInfo.TabGrd[i]["WRAPCOL"].ToString(), "S", false) == 0;
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString(), "", false) != 0 && Operators.CompareString(_GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString().ToUpper(), "LEFT", false) != 0)
					{
						val5 = (HorizontalAlign)(object)modGeneral.String2Enum(((object)val5).GetType(), _GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString());
						((GridColumn)val4).ItemStyle.HorizontalAlign = val5;
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString(), "", false) != 0 && ((Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString().ToUpper(), "NOTSET", false) != 0) & (Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString().ToUpper(), "MIDDLE", false) != 0)))
					{
						val6 = (VerticalAlign)(object)modGeneral.String2Enum(((object)val6).GetType(), _GridInfo.TabGrd[i]["VERTICALALIGN"].ToString());
						((GridColumn)val4).ItemStyle.VerticalAlign = val6;
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["HTMLENCODE"].ToString(), "N", false) == 0)
					{
						val4.HtmlEncode = false;
					}
					val4.DataFormatString = _GridInfo.TabGrd[i]["FORCAM"].ToString();
					DataRow dataRow = _GridInfo.TabGrd[i];
					if (modGeneral.ExistsFieldInDatarow(ref dataRow, "CssClass") && Operators.CompareString(_GridInfo.TabGrd[i]["CssClass"].ToString(), "", false) != 0)
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((GridColumn)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " " + _GridInfo.TabGrd[i]["CssClass"].ToString();
						((Style)((GridColumn)val4).ItemStyle).CssClass.Trim();
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["GROUPFIELD"].ToString(), "S", false) == 0)
					{
						GridGroupByExpression val7 = new GridGroupByExpression();
						GridGroupByField val8 = new GridGroupByField();
						val8.FieldName = _GridInfo.TabGrd[i]["NOMCAM"].ToString();
						val8.FormatString = _GridInfo.TabGrd[i]["FORCAM"].ToString();
						val8.HeaderText = _GridInfo.TabGrd[i]["DESCAM"].ToString();
						val7.GroupByFields.Add(val8);
						val7.SelectFields.Add(val8);
						_objGridViewTlk.MasterTableView.GroupByExpressions.Add(val7);
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["FooterText"].ToString(), "", false) == 0)
					{
						((GridColumn)val4).FooterText = " ";
					}
					else
					{
						((GridColumn)val4).FooterText = _GridInfo.TabGrd[i]["FooterText"].ToString();
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["AggregateFunc"].ToString(), "", false) != 0)
					{
						val4.Aggregate = (GridAggregateFunction)(object)modGeneral.String2Enum(typeof(GridAggregateFunction), _GridInfo.TabGrd[i]["AggregateFunc"].ToString());
						val4.FooterAggregateFormatString = _GridInfo.TabGrd[i]["FORCAM"].ToString();
						((GridColumn)val4).FooterStyle.HorizontalAlign = ((GridColumn)val4).ItemStyle.HorizontalAlign;
						((Style)((GridColumn)val4).FooterStyle).CssClass = "FooterCell";
					}
					else
					{
						val4.Aggregate = (GridAggregateFunction)0;
					}
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				_ObjCallStackHandler.CallStackRemove();
				result = val;
			}
			return result;
		}
	}

	public override FXRETURN ApplyGridConfig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Invalid comparison between Unknown and I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Invalid comparison between Unknown and I4
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Invalid comparison between Unknown and I4
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Invalid comparison between Unknown and I4
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Invalid comparison between Unknown and I4
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Invalid comparison between Unknown and I4
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_objGridViewTlk.AllowPaging = _GridInfo.AllowPaging;
			if (_objGridViewTlk.AllowPaging)
			{
				_objGridViewTlk.PageSize = Conversions.ToInteger(_GridInfo.AllGrd["ROWSPERPAGE"]);
			}
			((GridBaseDataList)_objGridViewTlk).GridLines = (GridLines)0;
			_objGridViewTlk.ClientSettings.Selecting.AllowRowSelect = _GridInfo.CanSelect;
			_objGridViewTlk.AllowSorting = _GridInfo.AllowSorting;
			_objGridViewTlk.MasterTableView.AllowCustomSorting = true;
			if (_GridInfo.Width > 0)
			{
				_objGridViewTlk.Width = new Unit((double)_GridInfo.Width, (UnitType)1);
			}
			else if (_GridInfo.Width == 0)
			{
				_objGridViewTlk.Width = new Unit(99.99, (UnitType)7);
			}
			else if (_GridInfo.Width < 0)
			{
				_objGridViewTlk.Width = default(Unit);
			}
			if (_objTitleLabel != null)
			{
				_objTitleLabel.Text = _GridInfo.AllGrd["DESTAB"].ToString();
				if (_objWebUserInfo.Peso >= 100)
				{
					_objTitleLabel.ToolTip = "Id Configurazione griglia=" + _GridInfo.NomRif + "-" + _GridInfo.Utente;
				}
			}
			((RadCompositeDataBoundControl)_objGridViewTlk).CssClass = "GVTlk GVTlk_" + Strings.Replace(_GridInfo.NomRif, ".", "_", 1, -1, (CompareMethod)0).Replace("#", "_") + " " + ((Control)_objGridViewTlk).ID;
			if (Operators.CompareString(_GridInfo.AllGrd["BACKCOLOR"].ToString(), "", false) != 0)
			{
				((RadCompositeDataBoundControl)_objGridViewTlk).BackColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BACKCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["CAPTIONBACKCOLOR"].ToString(), "", false) != 0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).BackColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["CAPTIONBACKCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["FORCOLOR"].ToString(), "", false) != 0)
			{
				((RadCompositeDataBoundControl)_objGridViewTlk).ForeColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["FORCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["CAPTIONFORCOLOR"].ToString(), "", false) != 0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).ForeColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["CAPTIONFORCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["BORDERCOLOR"].ToString(), "", false) != 0)
			{
				((RadCompositeDataBoundControl)_objGridViewTlk).BorderColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BORDERCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["FONTNAME"].ToString(), "", false) != 0)
			{
				((RadCompositeDataBoundControl)_objGridViewTlk).Font.Name = _GridInfo.AllGrd["FONTNAME"].ToString();
				if (_objTitleLabel != null)
				{
					((WebControl)_objTitleLabel).Font.Name = _GridInfo.AllGrd["FONTNAME"].ToString();
				}
			}
			if (Operators.CompareString(_GridInfo.AllGrd["CAPTIONFONTNAME"].ToString(), "", false) != 0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Name = _GridInfo.AllGrd["CAPTIONFONTNAME"].ToString();
			}
			if (Convert.ToDouble(_GridInfo.FontSize) > 0.0)
			{
				((RadCompositeDataBoundControl)_objGridViewTlk).Font.Size = new FontUnit(Convert.ToDouble(_GridInfo.FontSize));
			}
			if (Convert.ToDouble(_GridInfo.CaptionFontSize) > 0.0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Size = new FontUnit(Convert.ToDouble(_GridInfo.CaptionFontSize));
			}
			((RadCompositeDataBoundControl)_objGridViewTlk).Font.Bold = Operators.CompareString(_GridInfo.AllGrd["BOLD"].ToString(), "S", false) == 0;
			if (_objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Bold = Operators.CompareString(_GridInfo.AllGrd["CAPTIONBOLD"].ToString(), "S", false) == 0;
			}
			((RadCompositeDataBoundControl)_objGridViewTlk).Font.Italic = Operators.CompareString(_GridInfo.AllGrd["ITALIC"].ToString(), "S", false) == 0;
			if (_objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Italic = Operators.CompareString(_GridInfo.AllGrd["CAPTIONITALIC"].ToString(), "S", false) == 0;
			}
			((Style)_objGridViewTlk.HeaderStyle).BorderColor = ((RadCompositeDataBoundControl)_objGridViewTlk).BorderColor;
			val2 = ApplyStyleset(_GridInfo.HeaderStyle, (TableItemStyle)(object)_objGridViewTlk.HeaderStyle, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = ApplyStyleset(_GridInfo.PagerStyle, (TableItemStyle)(object)_objGridViewTlk.PagerStyle, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = ApplyStyleset(_GridInfo.RowStyle, (TableItemStyle)(object)_objGridViewTlk.ItemStyle, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = ApplyStyleset(_GridInfo.AlternatingRowStyle, (TableItemStyle)(object)_objGridViewTlk.AlternatingItemStyle, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (_GridInfo.HighLightStyle != null)
							{
								_objGridViewTlk.ClientSettings.EnableRowHoverStyle = true;
							}
							else
							{
								_objGridViewTlk.ClientSettings.EnableRowHoverStyle = false;
							}
							if (_GridInfo.AllGrdStylesetTable == null)
							{
								goto IL_0848;
							}
							DataTable dtStyle = _GridInfo.AllGrdStylesetTable;
							val2 = AllgrdStylesetConfig(ref dtStyle, ref _AllgrdStylesets, ref rsMess);
							if ((int)val2 <= 0)
							{
								goto IL_0848;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_0848:
			_objGridViewTlk.ClientSettings.Selecting.EnableDragToSelectRows = false;
			_objGridViewTlk.AllowMultiRowSelection = _GridInfo.EnableMultiSelection;
			if (_GridInfo.GroupHeaderItemStyle == null)
			{
				((Style)_objGridViewTlk.GroupHeaderItemStyle).CssClass = "GVTlkGroupHeader " + Strings.Replace("GVTlkGroupHeader_" + _GridInfo.NomRif, ".", "_", 1, -1, (CompareMethod)0);
				goto IL_0902;
			}
			val2 = ApplyStyleset(_GridInfo.GroupHeaderItemStyle, (TableItemStyle)(object)_objGridViewTlk.GroupHeaderItemStyle, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0902;
			}
			val = val2;
			goto end_IL_0005;
			IL_0902:
			_objGridViewTlk.GroupingEnabled = _GridInfo.AllowGrouping;
			if (Operators.CompareString(_GridInfo.GroupType, "S", false) == 0)
			{
				_objGridViewTlk.ShowGroupPanel = false;
				_objGridViewTlk.GroupingSettings.ShowUnGroupButton = false;
				_objGridViewTlk.ClientSettings.AllowDragToGroup = false;
				_objGridViewTlk.ClientSettings.AllowGroupExpandCollapse = true;
				_objGridViewTlk.MasterTableView.GroupLoadMode = (GridGroupLoadMode)1;
			}
			else if (Operators.CompareString(_GridInfo.GroupType, "A", false) == 0)
			{
				_objGridViewTlk.ShowGroupPanel = true;
				_objGridViewTlk.GroupingSettings.ShowUnGroupButton = true;
				_objGridViewTlk.ClientSettings.AllowDragToGroup = true;
				_objGridViewTlk.ClientSettings.AllowGroupExpandCollapse = true;
				_objGridViewTlk.MasterTableView.GroupLoadMode = (GridGroupLoadMode)0;
			}
			else
			{
				_objGridViewTlk.ShowGroupPanel = false;
				_objGridViewTlk.GroupingSettings.ShowUnGroupButton = false;
				_objGridViewTlk.ClientSettings.AllowDragToGroup = false;
			}
			if (_objGridViewTlk.GroupingEnabled)
			{
				_objGridViewTlk.MasterTableView.GroupsDefaultExpanded = _GridInfo.GroupExpanded;
				_objGridViewTlk.MasterTableView.ShowGroupFooter = _GridInfo.ShowGroupFooter;
				_objGridViewTlk.GroupingSettings.RetainGroupFootersVisibility = _GridInfo.GroupFooterAlwaysVisible;
			}
			_objGridViewTlk.ShowFooter = _GridInfo.ShowFooter;
			_objGridViewTlk.PagerStyle.PagerTextFormat = _PagerTextFormat.Replace("<%TOOLTIP%>", "").Replace("<%ASTERISCO%>", "");
			_objGridViewTlk.PagerStyle.AlwaysVisible = true;
			if (_GridInfo.FixedLayout)
			{
				_objGridViewTlk.MasterTableView.TableLayout = (GridTableLayout)1;
			}
			if (_GridInfo.ColumnResize)
			{
				_objGridViewTlk.ClientSettings.Resizing.AllowColumnResize = true;
				_objGridViewTlk.ClientSettings.Resizing.AllowResizeToFit = true;
				_objGridViewTlk.ClientSettings.Resizing.EnableRealTimeResize = true;
			}
			if (_GridInfo.ScrollHeight > 0)
			{
				_objGridViewTlk.ClientSettings.Scrolling.AllowScroll = true;
				_objGridViewTlk.ClientSettings.Scrolling.UseStaticHeaders = true;
				_objGridViewTlk.ClientSettings.Scrolling.SaveScrollPosition = true;
				_objGridViewTlk.ClientSettings.Scrolling.ScrollHeight = new Unit((double)_GridInfo.ScrollHeight, (UnitType)1);
			}
			val = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	private void _objGridViewTlk_DataBound(object sender, EventArgs e)
	{
		try
		{
			if (!_ImpostaFiltro)
			{
				return;
			}
			_ImpostaFiltro = false;
			if (_objFilterLabel != null)
			{
				_objFilterLabel.Text = _GridInfo.SqlStatement.WhereClauseReadableExpression;
				_objFilterLabel.Visible = false;
			}
			if (_objNumeroRecordTotali == null)
			{
				return;
			}
			if (_objGridViewTlk.MasterTableView.PagerTemplate != null)
			{
				if (Operators.CompareString(_objFilterLabel.Text, "", false) != 0)
				{
					_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0}{2}{1} Elementi in {0}{3}{1} pagine (*)", new string[4]
					{
						"</strong>",
						"</strong>",
						_LastDataTable.Rows.Count.ToString(),
						_objGridViewTlk.MasterTableView.PageCount.ToString()
					});
					_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "Filtro Attivo:", new string[0]) + " \r\n" + _GridInfo.SqlStatement.get_WhereClauseReadableExpression("\r\n");
				}
				else
				{
					_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0}{2}{1} Elementi in {0}{3}{1} pagine", new string[4]
					{
						"</strong>",
						"</strong>",
						_LastDataTable.Rows.Count.ToString(),
						_objGridViewTlk.MasterTableView.PageCount.ToString()
					});
					_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "Nessun filtro attivo", new string[0]);
				}
			}
			else if (Operators.CompareString(_objFilterLabel.Text, "", false) != 0)
			{
				_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0} Elementi (*)", new string[1] { _LastDataTable.Rows.Count.ToString() });
				_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "Filtro Attivo:", new string[0]) + " \r\n" + _GridInfo.SqlStatement.get_WhereClauseReadableExpression("\r\n");
				_objGridViewTlk.PagerStyle.PagerTextFormat = _PagerTextFormat.Replace("<%ASTERISCO%>", "(*)");
				_objGridViewTlk.PagerStyle.PagerTextFormat = _objGridViewTlk.PagerStyle.PagerTextFormat.Replace("<%TOOLTIP%>", _objNumeroRecordTotali.ToolTip);
			}
			else
			{
				_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0} Elementi", new string[1] { _LastDataTable.Rows.Count.ToString() });
				_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "Nessun filtro attivo", new string[0]);
				_objGridViewTlk.PagerStyle.PagerTextFormat = _PagerTextFormat.Replace("<%ASTERISCO%>", "");
				_objGridViewTlk.PagerStyle.PagerTextFormat = _objGridViewTlk.PagerStyle.PagerTextFormat.Replace("<%TOOLTIP%>", _objNumeroRecordTotali.ToolTip);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
