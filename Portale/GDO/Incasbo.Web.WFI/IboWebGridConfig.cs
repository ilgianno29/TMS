using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebGridConfig : IDisposable
{
	protected bool disposedValue;

	protected IboGridInfo _GridInfo;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected IboGridView _objGridView;

	protected IboWebLabel _objTitleLabel;

	protected IboWebLabel _objFilterLabel;

	protected IboWebLabel _objNumeroRecordTotali;

	protected IboWebUserInfo _objWebUserInfo;

	protected Collection _AllgrdStylesets;

	protected DataTable _DataTableSource;

	protected DataTable _LastDataTable;

	protected DateTime _LastUsage;

	public DateTime LastUsage => _LastUsage;

	public Collection AllgrdStylesets => _AllgrdStylesets;

	public DataTable DataTableSource
	{
		get
		{
			return _DataTableSource;
		}
		set
		{
			_DataTableSource = value;
		}
	}

	public DataTable LastDataTableSource => _LastDataTable;

	public IboWebGridConfig(ref IboGridInfo rObjGridInfo, ref IboGridView rObjGridView, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		disposedValue = false;
		_LastUsage = DateTime.Now;
		_GridInfo = rObjGridInfo;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_Translator = rObjTranslator;
		_dbMain = rObjDbMain;
		_objGridView = rObjGridView;
		_objTitleLabel = rObjGridTitleLabel;
		_objFilterLabel = rObjGridFilterLabel;
		_objNumeroRecordTotali = rObjNumeroRecordTotali;
		_objWebUserInfo = rObjWebUserInfo;
		_GridInfo.GridConfig = this;
	}

	public virtual void Reinit(ref IboGridInfo rObjGridInfo, ref IboGridView rObjGridView, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali)
	{
		_GridInfo = rObjGridInfo;
		_objGridView = rObjGridView;
		_objTitleLabel = rObjGridTitleLabel;
		_objFilterLabel = rObjGridFilterLabel;
		_objNumeroRecordTotali = rObjNumeroRecordTotali;
		_GridInfo.GridConfig = this;
	}

	public virtual FXRETURN Aggiorna(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = Carica_Dati(ref rsMess);
			if ((int)val2 <= 0)
			{
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
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN AnnullaFiltri(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = _GridInfo.Reset_SqlSelect(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = Carica_Dati(ForceRequery: true, ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
				}
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
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN AnnullaPrefiltri(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = _GridInfo.Reset_SqlPrefilterOnly(ref rsMess);
			if ((int)val2 <= 0)
			{
				val2 = Carica_Dati(ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
				}
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
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN Carica_Dati(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Invalid comparison between Unknown and I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
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
			if (DataTableSource != null)
			{
				((BaseDataBoundControl)_objGridView).DataSource = null;
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
				((BaseDataBoundControl)_objGridView).DataSource = null;
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
					((GridView)_objGridView).DataKeyNames = text2.Split(new char[1] { ';' });
				}
				if (Operators.CompareString(_objGridView.FieldSorting, "", false) == 0)
				{
					_objGridView.FieldSorting = Interaction.IIf(Operators.CompareString(_GridInfo.CampiOrdinantiAttuali, "", false) == 0, (object)_GridInfo.CampiOrdinantiIniziali, (object)_GridInfo.CampiOrdinantiAttuali).ToString();
				}
				if (Operators.CompareString(_objGridView.FieldSortingDirection, "", false) == 0)
				{
					_objGridView.FieldSortingDirection = Interaction.IIf(Operators.CompareString(_GridInfo.CampiOrdinantiAttualiDirezione, "", false) == 0, (object)_GridInfo.CampiOrdinantiInizialiDirezione, (object)_GridInfo.CampiOrdinantiAttualiDirezione).ToString();
				}
				val2 = Carica_LookUp(ref dtTemp, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					((BaseDataBoundControl)_objGridView).DataSource = dtTemp;
					((GridView)_objGridView).DataBind();
					if (_objFilterLabel != null)
					{
						_objFilterLabel.Text = _GridInfo.SqlStatement.WhereClauseReadableExpression;
						_objFilterLabel.Visible = false;
					}
					if (_objNumeroRecordTotali != null)
					{
						if (Operators.CompareString(_objFilterLabel.Text, "", false) != 0)
						{
							_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0}{2}{1} Elementi in {0}{3}{1} pagine (*)", new string[4]
							{
								"<strong>",
								"</strong>",
								dtTemp.Rows.Count.ToString(),
								((GridView)_objGridView).PageCount.ToString()
							});
							_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "{0}Filtro Attivo{1} {2}", new string[3]
							{
								"<strong>",
								"</strong><br />",
								_GridInfo.SqlStatement.get_WhereClauseReadableExpression("<br />")
							});
						}
						else
						{
							_objNumeroRecordTotali.Text = _Translator.TranslateMessage("XXX", "{0}{2}{1} Elementi in {0}{3}{1}  pagine", new string[4]
							{
								"<strong>",
								"</strong>",
								dtTemp.Rows.Count.ToString(),
								((GridView)_objGridView).PageCount.ToString()
							});
							_objNumeroRecordTotali.ToolTip = _Translator.TranslateMessage("XXX", "Nessun filtro attivo", new string[0]);
						}
					}
					val = (FXRETURN)0;
				}
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

	public virtual FXRETURN Carica_Dati(bool ForceRequery, ref string rsMess)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!ForceRequery)
		{
			DataTableSource = LastDataTableSource;
		}
		else
		{
			DataTableSource = null;
		}
		return Carica_Dati(ref rsMess);
	}

	public virtual FXRETURN Carica_LookUp(ref DataTable dtTemp, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		QueryCache queryCache = null;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			foreach (DataRow row in _GridInfo.TabGrdTable.Rows)
			{
				if (Operators.CompareString(row["INNERSQL"].ToString().Trim(), "", false) == 0)
				{
					continue;
				}
				queryCache = new QueryCache();
				string[] array = Strings.Split(row["INNERSQL"].ToString().Trim(), ";", -1, (CompareMethod)0);
				text = array[0];
				string text2 = array[1];
				object obj = null;
				foreach (DataRow row2 in dtTemp.Rows)
				{
					DataRow dataRow2 = row2;
					object obj2 = "";
					if (modGeneral.ExistsFieldInDatarow(ref dataRow2, text2))
					{
						obj2 = RuntimeHelpers.GetObjectValue(dataRow2[text2]);
					}
					string text3 = Strings.Replace(text, "<%FieldName%>", _dbMain.SQLFormatString(obj2.ToString()), 1, -1, (CompareMethod)0);
					if (queryCache.Contains(text3))
					{
						obj = RuntimeHelpers.GetObjectValue(queryCache.Item(text3).SqlQueryResult);
						goto IL_0184;
					}
					val2 = _dbMain.DoSql(text3, (object)"", ref obj, ref rsMess);
					if ((int)val2 <= 0)
					{
						queryCache.Add(new QueryCacheItem(text3, RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0184;
					}
					val = val2;
					goto end_IL_000e;
					IL_0184:
					if (!modGeneral.ExistsFieldInDatarow(ref dataRow2, row["NOMCAM"].ToString()))
					{
						dtTemp.Columns.Add(row["NOMCAM"].ToString(), obj.GetType());
					}
					dataRow2[row["NOMCAM"].ToString()] = RuntimeHelpers.GetObjectValue(obj);
				}
			}
			val = (FXRETURN)0;
			end_IL_000e:;
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
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN ApplyConfig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = ApplyGridConfig(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = ApplyColumnConfig(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = Carica_Dati(ref rsMess);
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
				}
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

	public virtual FXRETURN ApplyConfig(bool ForceRequery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (ForceRequery)
			{
				DataTableSource = null;
				val2 = ApplyConfig(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0059;
				}
				val = val2;
			}
			else
			{
				val2 = ApplyConfig(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0059;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_0059:
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

	public virtual FXRETURN ChangeToEditMode(ref IboGridView objGridview, int iIndexRow, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_objGridView = objGridview;
			((GridView)_objGridView).EditIndex = iIndexRow;
			foreach (DataRow item in _GridInfo.TabGrd)
			{
				if (Operators.CompareString(item["CANEDIT"].ToString(), "S", false) != 0)
				{
					continue;
				}
				foreach (object item2 in (StateManagedCollection)((GridView)_objGridView).Columns)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(item2);
					BoundField val3 = (BoundField)((objectValue is BoundField) ? objectValue : null);
					if (val3 != null && Operators.CompareString(item["NOMCAM"].ToString().ToUpper(), val3.DataField.ToUpper(), false) == 0)
					{
						val3.ReadOnly = false;
						val3.ApplyFormatInEditMode = true;
						if (Conversions.ToInteger(item["LARCAMEDIT"]) > 0)
						{
							((DataControlField)val3).ControlStyle.Width = new Unit(Conversions.ToInteger(item["LARCAMEDIT"]));
						}
						if (((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(decimal)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(double)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(float)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(long)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(short)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(byte)))
						{
							((DataControlField)val3).ControlStyle.CssClass = "IboGridView_EditField_Numeric";
						}
						else
						{
							((DataControlField)val3).ControlStyle.CssClass = "IboGridView_EditField_String";
						}
					}
				}
			}
			((BaseDataBoundControl)_objGridView).DataSource = LastDataTableSource;
			((GridView)_objGridView).DataBind();
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

	public virtual FXRETURN GenerateUpdateQuery(ref IboGridView objGridview, string sTabella, int iIndexRow, ref IOrderedDictionary NewValues, ref IOrderedDictionary OldValues, ref string sSqlUpdate, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				sSqlUpdate = "";
				_objGridView = objGridview;
				((GridView)_objGridView).EditIndex = iIndexRow;
				int num = ((NewValues[0].GetType() == typeof(bool)) ? 1 : 0);
				DataRow[] array = _GridInfo.TabGrdTable.Select("CANEDIT='S'", "ORDCAM ASC");
				foreach (DataRow dataRow in array)
				{
					int num2 = 0;
					foreach (object item in (StateManagedCollection)((GridView)_objGridView).Columns)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(item);
						BoundField val3 = (BoundField)((objectValue is BoundField) ? objectValue : null);
						if (val3 != null && Operators.CompareString(dataRow["NOMCAM"].ToString().ToUpper(), val3.DataField.ToUpper(), false) == 0)
						{
							if (((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(decimal)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(double)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(float)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(long)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(short)) | ((object)LastDataTableSource.Columns[val3.DataField].DataType == typeof(byte)))
							{
								if (Conversions.ToDouble(NewValues[num]) != Conversions.ToDouble(LastDataTableSource.Rows[iIndexRow][val3.DataField.ToUpper()]))
								{
									if (Operators.CompareString(text, "", false) != 0)
									{
										text += ", ";
									}
									string text3 = text;
									string dataField = val3.DataField;
									DBConnection dbMain = _dbMain;
									double num3 = Conversions.ToDouble(NewValues[num].ToString());
									text = text3 + dataField + "=" + dbMain.SQLFormatNumber(ref num3);
								}
							}
							else if (Operators.CompareString(Conversions.ToString(NewValues[num]), Conversions.ToString(LastDataTableSource.Rows[iIndexRow][val3.DataField.ToUpper()]), false) != 0)
							{
								if (Operators.CompareString(text, "", false) != 0)
								{
									text += ", ";
								}
								text = text + val3.DataField + "=" + _dbMain.SQLFormatString(NewValues[num].ToString());
							}
							break;
						}
						num2++;
					}
					num++;
				}
				text = "UPDATE " + sTabella + " SET " + text + " WHERE ";
				text2 = "";
				if (NewValues[0].GetType() == typeof(bool))
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				DataRow[] array2 = _GridInfo.TabGrdTable.Select("ISKEY='S'", "ORDCAM ASC");
				foreach (DataRow dataRow2 in array2)
				{
					int num4 = 0;
					foreach (object item2 in (StateManagedCollection)((GridView)_objGridView).Columns)
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(item2);
						BoundField val4 = (BoundField)((objectValue2 is BoundField) ? objectValue2 : null);
						if (val4 != null && Operators.CompareString(dataRow2["NOMCAM"].ToString().ToUpper(), val4.DataField.ToUpper(), false) == 0)
						{
							if (((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(decimal)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(double)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(float)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(long)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(int)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(short)) | ((object)LastDataTableSource.Columns[val4.DataField].DataType == typeof(byte)))
							{
								if (Operators.CompareString(text2, "", false) != 0)
								{
									text2 += " AND ";
								}
								string text4 = text2;
								string dataField2 = val4.DataField;
								DBConnection dbMain2 = _dbMain;
								double num3 = Conversions.ToDouble(LastDataTableSource.Rows[iIndexRow][val4.DataField.ToUpper()]);
								text2 = text4 + dataField2 + "=" + dbMain2.SQLFormatNumber(ref num3);
							}
							else
							{
								if (Operators.CompareString(text2, "", false) != 0)
								{
									text2 += " AND ";
								}
								text2 = text2 + val4.DataField + "=" + _dbMain.SQLFormatString(Conversions.ToString(LastDataTableSource.Rows[iIndexRow][val4.DataField.ToUpper()]));
							}
							break;
						}
						num4++;
					}
				}
				text += text2;
				sSqlUpdate = text;
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

	public virtual FXRETURN ChangeToreadOnlyMode(ref IboGridView objGridview, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_objGridView = objGridview;
			((GridView)_objGridView).EditIndex = -1;
			((BaseDataBoundControl)_objGridView).DataSource = LastDataTableSource;
			((GridView)_objGridView).DataBind();
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

	public virtual FXRETURN ApplyColumnConfig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				((StateManagedCollection)((GridView)_objGridView).Columns).Clear();
				if (Operators.CompareString(_GridInfo.AllGrd["CANEDIT"].ToString(), "S", false) == 0)
				{
					CommandField val3 = new CommandField();
					((ButtonFieldBase)val3).ButtonType = (ButtonType)2;
					val3.ShowEditButton = true;
					val3.ShowInsertButton = true;
					val3.EditText = "Edit";
					val3.InsertText = "Insert";
					((Style)((DataControlField)val3).ItemStyle).Width = (System.Web.UI.WebControls.Unit)(1);
					if (Operators.CompareString(_GridInfo.AllGrd["BORDERCOLOR"].ToString(), "", false) != 0)
					{
						((Style)((DataControlField)val3).ItemStyle).BorderColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BORDERCOLOR"].ToString());
					}
					((Style)((DataControlField)val3).HeaderStyle).BorderColor = ((Style)((DataControlField)val3).ItemStyle).BorderColor;
					((DataControlField)val3).HeaderText = _Translator.Translate("XXX", "Comandi", new string[0]);
					((GridView)_objGridView).Columns.Add((DataControlField)(object)val3);
					_objGridView.CanEdit = true;
				}
				else
				{
					_objGridView.CanEdit = false;
				}
				int num = _GridInfo.TabGrd.Count - 1;
				HorizontalAlign val6 = default(HorizontalAlign);
				for (int i = 0; i <= num; i++)
				{
					BoundField val4 = new BoundField();
					((GridView)_objGridView).Columns.Add((DataControlField)(object)val4);
					val4.ReadOnly = true;
					((DataControlField)val4).ShowHeader = true;
					((Style)((DataControlField)val4).ItemStyle).CssClass = "BoundField";
					if (Operators.CompareString(_GridInfo.TabGrd[i]["ISKEY"].ToString(), "S", false) == 0)
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((DataControlField)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " KeyField";
					}
					val4.DataField = _GridInfo.TabGrd[i]["NOMCAM"].ToString();
					if ((Operators.CompareString(_GridInfo.TabGrd[i]["CANSORT"].ToString(), "S", false) == 0) & (Operators.CompareString(_GridInfo.AllGrd["CANSORT"].ToString(), "S", false) == 0))
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((DataControlField)val4).HeaderStyle)).CssClass = ((Style)itemStyle).CssClass + " sortableColumn";
						((DataControlField)val4).SortExpression = _GridInfo.TabGrd[i]["NOMCAMEXP"].ToString();
						if (Operators.CompareString(((DataControlField)val4).SortExpression, "", false) == 0)
						{
							((DataControlField)val4).SortExpression = _GridInfo.TabGrd[i]["NOMCAM"].ToString();
						}
					}
					else
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((DataControlField)val4).HeaderStyle)).CssClass = ((Style)itemStyle).CssClass + " unsortableColumn";
						((DataControlField)val4).SortExpression = "";
					}
					val4.HeaderText = _Translator.TranslateMessage("GRID.CAPTION." + _GridInfo.NomRif, _GridInfo.TabGrd[i]["DESCAM"].ToString(), new string[0]);
					string text = "";
					if (Operators.CompareString(_GridInfo.TabGrd[i]["ExtendedDesCam"].ToString(), "", false) != 0)
					{
						text = _Translator.TranslateMessage("GRID.CAPTION." + _GridInfo.NomRif, _GridInfo.TabGrd[i]["ExtendedDesCam"].ToString(), new string[0]);
					}
					else if (((_GridInfo.FixedLayout | (_GridInfo.ScrollHeight > 0)) & (_GridInfo.ScrollHeight != 9999)) && Operators.CompareString(text, "", false) == 0)
					{
						text = val4.HeaderText;
					}
					BoundField val5;
					(val5 = val4).HeaderText = val5.HeaderText + "§" + text;
					((DataControlField)val4).Visible = Operators.CompareString(_GridInfo.TabGrd[i]["VISIBILE"].ToString(), "N", false) != 0;
					if (Operators.CompareString(_GridInfo.TabGrd[i]["VISIBILE"].ToString(), "H", false) == 0)
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((DataControlField)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " hidden";
						((Style)((DataControlField)val4).HeaderStyle).CssClass = "hidden";
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_GridInfo.TabGrd[i]["LARCAM"])))
					{
						if (Conversions.ToInteger(_GridInfo.TabGrd[i]["LARCAM"]) > 0)
						{
							((Style)((DataControlField)val4).HeaderStyle).Width = new Unit(Conversions.ToDouble(_GridInfo.TabGrd[i]["LARCAM"]));
							((Style)((DataControlField)val4).ItemStyle).Width = new Unit(Conversions.ToDouble(_GridInfo.TabGrd[i]["LARCAM"]));
						}
						else if (_GridInfo.FixedLayout)
						{
							((Style)((DataControlField)val4).HeaderStyle).Width = new Unit(90.0, (UnitType)7);
							((Style)((DataControlField)val4).ItemStyle).Width = new Unit(90.0, (UnitType)7);
						}
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["WRAPCOL"].ToString(), "", false) != 0)
					{
						((DataControlField)val4).ItemStyle.Wrap = Operators.CompareString(_GridInfo.TabGrd[i]["WRAPCOL"].ToString(), "S", false) == 0;
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString(), "", false) != 0 && Operators.CompareString(_GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString().ToUpper(), "LEFT", false) != 0)
					{
						val6 = (HorizontalAlign)(object)modGeneral.String2Enum(((object)val6).GetType(), _GridInfo.TabGrd[i]["HORIZONTALALIGN"].ToString());
						((DataControlField)val4).ItemStyle.HorizontalAlign = val6;
					}
					if (Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString(), "", false) != 0 && ((Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString().ToUpper(), "NOTSET", false) != 0) & (Operators.CompareString(_GridInfo.TabGrd[i]["VERTICALALIGN"].ToString().ToUpper(), "MIDDLE", false) != 0)))
					{
						TableItemStyle itemStyle;
						((Style)(itemStyle = ((DataControlField)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " " + _GridInfo.TabGrd[i]["VERTICALALIGN"].ToString().ToUpper() + "_VA";
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
						((Style)(itemStyle = ((DataControlField)val4).ItemStyle)).CssClass = ((Style)itemStyle).CssClass + " " + _GridInfo.TabGrd[i]["CssClass"].ToString();
						((Style)((DataControlField)val4).ItemStyle).CssClass.Trim();
					}
					((DataControlField)val4).FooterText = _GridInfo.TabGrd[i]["FooterText"].ToString();
					if (Operators.CompareString(_GridInfo.TabGrd[i]["AGGREGATEFUNC"].ToString(), "", false) != 0)
					{
						((DataControlField)val4).FooterText = _GridInfo.TabGrd[i]["AGGREGATEFUNC"].ToString().ToUpper() + ";" + ((DataControlField)val4).FooterText;
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

	public virtual FXRETURN ApplyGridConfig(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Invalid comparison between Unknown and I4
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Invalid comparison between Unknown and I4
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Invalid comparison between Unknown and I4
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Invalid comparison between Unknown and I4
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Invalid comparison between Unknown and I4
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Invalid comparison between Unknown and I4
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Invalid comparison between Unknown and I4
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			((GridView)_objGridView).AllowPaging = _GridInfo.AllowPaging;
			if (((GridView)_objGridView).AllowPaging)
			{
				((GridView)_objGridView).PageSize = Conversions.ToInteger(_GridInfo.AllGrd["ROWSPERPAGE"]);
			}
			((GridView)_objGridView).GridLines = (GridLines)0;
			_objGridView.AutoGenerateCheckBoxColumn = _GridInfo.AutoGenerateCheckBoxColumn;
			((GridView)_objGridView).AllowSorting = _GridInfo.AllowSorting;
			if (_GridInfo.Width > 0)
			{
				((WebControl)_objGridView).Width = new Unit((double)_GridInfo.Width, (UnitType)1);
			}
			else if (_GridInfo.Width == 0)
			{
				((WebControl)_objGridView).Width = new Unit(99.99, (UnitType)7);
			}
			else if (_GridInfo.Width < 0)
			{
				((WebControl)_objGridView).Width = default(Unit);
			}
			if (_objTitleLabel != null)
			{
				_objTitleLabel.Text = _GridInfo.AllGrd["DESTAB"].ToString();
				if (_objTitleLabel.Text.Contains("<%WhereAggiuntivaReadable%>"))
				{
					_objTitleLabel.ToolTip = _objTitleLabel.Text.Replace("<%WhereAggiuntivaReadable%>", _GridInfo.WhereAggiuntivaReadable);
					_objTitleLabel.Text = _objTitleLabel.Text.Replace("<%WhereAggiuntivaReadable%>", "").Trim();
				}
				if (_objWebUserInfo.Peso >= 100)
				{
					_objTitleLabel.ToolTip = "Id Configurazione griglia=" + _GridInfo.NomRif + "-" + _GridInfo.Utente;
				}
			}
			((WebControl)_objGridView).CssClass = Strings.Replace(_GridInfo.NomRif, ".", "_", 1, -1, (CompareMethod)0).Replace("#", "_") + " " + ((Control)_objGridView).ID;
			if (Operators.CompareString(_GridInfo.AllGrd["BACKCOLOR"].ToString(), "", false) != 0)
			{
				((WebControl)_objGridView).BackColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BACKCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["CAPTIONBACKCOLOR"].ToString(), "", false) != 0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).BackColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["CAPTIONBACKCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["FORCOLOR"].ToString(), "", false) != 0)
			{
				((WebControl)_objGridView).ForeColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["FORCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["CAPTIONFORCOLOR"].ToString(), "", false) != 0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).ForeColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["CAPTIONFORCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["BORDERCOLOR"].ToString(), "", false) != 0)
			{
				((WebControl)_objGridView).BorderColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BORDERCOLOR"].ToString());
			}
			if (Operators.CompareString(_GridInfo.AllGrd["FONTNAME"].ToString(), "", false) != 0)
			{
				((WebControl)_objGridView).Font.Name = _GridInfo.AllGrd["FONTNAME"].ToString();
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
				((WebControl)_objGridView).Font.Size = new FontUnit(Convert.ToDouble(_GridInfo.FontSize));
			}
			if (Convert.ToDouble(_GridInfo.CaptionFontSize) > 0.0 && _objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Size = new FontUnit(Convert.ToDouble(_GridInfo.CaptionFontSize));
			}
			((WebControl)_objGridView).Font.Bold = Operators.CompareString(_GridInfo.AllGrd["BOLD"].ToString(), "S", false) == 0;
			if (_objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Bold = Operators.CompareString(_GridInfo.AllGrd["CAPTIONBOLD"].ToString(), "S", false) == 0;
			}
			((WebControl)_objGridView).Font.Italic = Operators.CompareString(_GridInfo.AllGrd["ITALIC"].ToString(), "S", false) == 0;
			if (_objTitleLabel != null)
			{
				((WebControl)_objTitleLabel).Font.Italic = Operators.CompareString(_GridInfo.AllGrd["CAPTIONITALIC"].ToString(), "S", false) == 0;
			}
			((Style)((GridView)_objGridView).HeaderStyle).BorderColor = ((WebControl)_objGridView).BorderColor;
			val2 = ApplyStyleset(_GridInfo.HeaderStyle, ((GridView)_objGridView).HeaderStyle, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = ApplyStyleset(_GridInfo.PagerStyle, ((GridView)_objGridView).PagerStyle, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = ApplyStyleset(_GridInfo.RowStyle, ((GridView)_objGridView).RowStyle, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = ApplyStyleset(_GridInfo.SelectedRowStyle, ((GridView)_objGridView).SelectedRowStyle, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = ApplyStyleset(_GridInfo.AlternatingRowStyle, ((GridView)_objGridView).AlternatingRowStyle, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								if (_GridInfo.HighLightStyle == null)
								{
									_objGridView.HighLightedRowStyleActivated = false;
									goto IL_08b0;
								}
								val2 = ApplyStyleset(_GridInfo.HighLightStyle, _objGridView.HighLightedRowStyle, ref rsMess);
								if ((int)val2 <= 0)
								{
									_objGridView.HighLightedRowStyleActivated = true;
									goto IL_08b0;
								}
								val = val2;
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_08b0:
			if (_GridInfo.AllGrdStylesetTable == null)
			{
				goto IL_08f4;
			}
			DataTable dtStyle = _GridInfo.AllGrdStylesetTable;
			val2 = AllgrdStylesetConfig(ref dtStyle, ref _AllgrdStylesets, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_08f4;
			}
			val = val2;
			goto end_IL_0005;
			IL_08f4:
			_objGridView.EnableMultiSelection = _GridInfo.EnableMultiSelection;
			if (_GridInfo.EnableMultiSelection)
			{
				_objGridView.MultiSelectionType = _GridInfo.MultiSelectionType;
			}
			_objGridView.SelectionColumnVisible = _GridInfo.SelectionColumnVisible;
			((GridView)_objGridView).ShowHeaderWhenEmpty = true;
			((GridView)_objGridView).ShowFooter = _GridInfo.ShowFooter;
			if (_GridInfo.FixedLayout)
			{
				((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " StdGridClip";
				string wFIUserAgent = ((WFIPage)(object)((Control)_objGridView).Page).SessionEnvironment.WFIUserAgent;
				if (wFIUserAgent.Contains("MSIE"))
				{
					((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " StdGridClip_IEOnly";
				}
				if (wFIUserAgent.Contains("CHROME"))
				{
					((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " StdGridClip_ChromeOnly";
				}
			}
			if (_GridInfo.ColumnResize)
			{
				((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " StdGrdColRisizable";
			}
			if (_GridInfo.ScrollHeight > 0)
			{
				((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " stdGrdScrollable";
				((WebControl)_objGridView).Height = new Unit((double)_GridInfo.ScrollHeight, (UnitType)1);
				((WebControl)_objGridView).Style.Add("visibility", "hidden");
			}
			((WebControl)_objGridView).CssClass = ((WebControl)_objGridView).CssClass + " TipoGriglia_" + _GridInfo.TipoGriglia;
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

	protected virtual FXRETURN ApplyStyleset(DataRow drStyle, TableItemStyle Style, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (drStyle != null)
			{
				((Style)Style).BorderWidth = new Unit(1.0);
				((Style)Style).BorderStyle = (BorderStyle)4;
				if (Operators.CompareString(_GridInfo.AllGrd["BORDERCOLOR"].ToString(), "", false) != 0)
				{
					((Style)Style).BorderColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BORDERCOLOR"].ToString());
				}
				if (Operators.CompareString(drStyle["BACKCOLOR"].ToString(), "", false) != 0)
				{
					((Style)Style).BackColor = modGeneral.HTMLColorToSystemColor("#" + drStyle["BACKCOLOR"].ToString());
				}
				if (Operators.CompareString(drStyle["BORDERCOLOR"].ToString(), "", false) != 0)
				{
					((Style)Style).BorderColor = modGeneral.HTMLColorToSystemColor("#" + drStyle["BORDERCOLOR"].ToString());
				}
				if (Operators.CompareString(drStyle["CSSCLASS"].ToString(), "", false) != 0)
				{
					((Style)Style).CssClass = drStyle["CSSCLASS"].ToString();
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(drStyle["BORDERWIDTH"])))
				{
					((Style)Style).BorderWidth = new Unit(Conversions.ToDouble(drStyle["BORDERWIDTH"]));
				}
				if (Operators.CompareString(drStyle["FONTBOLD"].ToString(), "", false) != 0)
				{
					((Style)Style).Font.Bold = Operators.CompareString(drStyle["FONTBOLD"].ToString(), "S", false) == 0;
				}
				if (Operators.CompareString(drStyle["FONTITALIC"].ToString(), "", false) != 0)
				{
					((Style)Style).Font.Italic = Operators.CompareString(drStyle["FONTITALIC"].ToString(), "S", false) == 0;
				}
				if (Operators.CompareString(drStyle["FONTNAME"].ToString(), "", false) != 0)
				{
					((Style)Style).Font.Name = drStyle["FONTNAME"].ToString();
				}
				if (Operators.CompareString(drStyle["FONTUNDERLINE"].ToString(), "", false) != 0)
				{
					((Style)Style).Font.Underline = Operators.CompareString(drStyle["FONTUNDERLINE"].ToString(), "S", false) == 0;
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(drStyle["FONTSIZE"])))
				{
					((Style)Style).Font.Size = new FontUnit(Conversions.ToDouble(drStyle["FONTSIZE"]));
				}
				if (Operators.CompareString(drStyle["FORCOLOR"].ToString(), "", false) != 0)
				{
					((Style)Style).ForeColor = modGeneral.HTMLColorToSystemColor("#" + drStyle["FORCOLOR"].ToString());
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(drStyle["HEIGHT"])))
				{
					((Style)Style).Height = new Unit(Conversions.ToDouble(drStyle["HEIGHT"]));
				}
				if (Operators.CompareString(drStyle["HORIZONTALALIGN"].ToString(), "", false) != 0)
				{
					HorizontalAlign val3 = (HorizontalAlign)(object)modGeneral.String2Enum(typeof(HorizontalAlign), drStyle["HORIZONTALALIGN"].ToString());
					Style.HorizontalAlign = val3;
				}
				if (Operators.CompareString(drStyle["VERTICALALIGN"].ToString(), "", false) != 0)
				{
					VerticalAlign val4 = (VerticalAlign)(object)modGeneral.String2Enum(typeof(VerticalAlign), drStyle["VERTICALALIGN"].ToString());
					Style.VerticalAlign = val4;
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(drStyle["WIDTH"])))
				{
					((Style)Style).Width = new Unit(Conversions.ToDouble(drStyle["WIDTH"]));
				}
				if (Operators.CompareString(drStyle["WRAP"].ToString(), "", false) != 0)
				{
					Style.Wrap = Operators.CompareString(drStyle["WRAP"].ToString(), "S", false) == 0;
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

	protected virtual FXRETURN AllgrdStylesetConfig(ref DataTable dtStyle, ref Collection ret, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			ret = new Collection();
			if (dtStyle != null)
			{
				HorizontalAlign val4 = default(HorizontalAlign);
				VerticalAlign val6 = default(VerticalAlign);
				foreach (DataRow row in dtStyle.Rows)
				{
					TableItemStyle val3 = new TableItemStyle();
					((Style)val3).BorderWidth = new Unit(1.0);
					((Style)val3).BorderStyle = (BorderStyle)4;
					((Style)val3).BorderColor = modGeneral.HTMLColorToSystemColor("#" + _GridInfo.AllGrd["BORDERCOLOR"].ToString());
					if (Operators.CompareString(row["BACKCOLOR"].ToString(), "", false) != 0)
					{
						((Style)val3).BackColor = modGeneral.HTMLColorToSystemColor("#" + row["BACKCOLOR"].ToString());
					}
					if (Operators.CompareString(row["FORCOLOR"].ToString(), "", false) != 0)
					{
						((Style)val3).ForeColor = modGeneral.HTMLColorToSystemColor("#" + row["FORCOLOR"].ToString());
					}
					if (Operators.CompareString(row["BORDERCOLOR"].ToString(), "", false) != 0)
					{
						((Style)val3).BorderColor = modGeneral.HTMLColorToSystemColor("#" + row["BORDERCOLOR"].ToString());
					}
					if (Operators.CompareString(row["CSSCLASS"].ToString(), "", false) != 0)
					{
						((Style)val3).CssClass = ((Style)val3).CssClass + " " + row["CSSCLASS"].ToString();
						((Style)val3).CssClass = ((Style)val3).CssClass.Trim();
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["BORDERWIDTH"])))
					{
						((Style)val3).BorderWidth = new Unit(Conversions.ToDouble(row["BORDERWIDTH"]));
					}
					if (Operators.CompareString(row["FONTBOLD"].ToString(), "", false) != 0)
					{
						((Style)val3).Font.Bold = Operators.CompareString(row["FONTBOLD"].ToString(), "S", false) == 0;
					}
					if (Operators.CompareString(row["FONTITALIC"].ToString(), "", false) != 0)
					{
						((Style)val3).Font.Italic = Operators.CompareString(row["FONTITALIC"].ToString(), "S", false) == 0;
					}
					if (Operators.CompareString(row["FONTNAME"].ToString(), "", false) != 0)
					{
						((Style)val3).Font.Name = row["FONTNAME"].ToString();
					}
					if (Operators.CompareString(row["FONTUNDERLINE"].ToString(), "", false) != 0)
					{
						((Style)val3).Font.Underline = Operators.CompareString(row["FONTUNDERLINE"].ToString(), "S", false) == 0;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["FONTSIZE"])))
					{
						((Style)val3).Font.Size = new FontUnit(Conversions.ToDouble(row["FONTSIZE"]));
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["HEIGHT"])))
					{
						((Style)val3).Height = new Unit(Conversions.ToDouble(row["HEIGHT"]));
					}
					if (Operators.CompareString(row["HORIZONTALALIGN"].ToString(), "", false) != 0)
					{
						val4 = (val3.HorizontalAlign = (HorizontalAlign)(object)modGeneral.String2Enum(typeof(VerticalAlign), row["HORIZONTALALIGN"].ToString()));
					}
					if (Operators.CompareString(row["VERTICALALIGN"].ToString(), "", false) != 0)
					{
						val6 = (val3.VerticalAlign = (VerticalAlign)(object)modGeneral.String2Enum(((object)val6).GetType(), row["VERTICALALIGN"].ToString()));
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["WIDTH"])))
					{
						((Style)val3).Width = new Unit(Conversions.ToDouble(row["WIDTH"]));
					}
					if (Operators.CompareString(row["WRAP"].ToString(), "", false) != 0)
					{
						val3.Wrap = Operators.CompareString(row["WRAP"].ToString(), "S", false) == 0;
					}
					ret.Add((object)val3, row["STYLENAME"].ToString(), (object)null, (object)null);
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

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_ObjCallStackHandler = null;
			_ObjIboAppLogHandling = null;
			_dbMain = null;
			_Translator = null;
			_objWebUserInfo = null;
		}
		disposedValue = true;
	}
}
