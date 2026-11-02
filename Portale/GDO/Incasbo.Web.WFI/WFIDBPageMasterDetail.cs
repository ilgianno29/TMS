using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI.ObjectManager;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIDBPageMasterDetail : WFIDBPage
{
	protected IboInternalGridConfigList GridConfigList;

	protected bool _RunAfterEvent;

	private bool bFlagManageClickEventOnCollaptiblePanel;

	private bool bFlagManageClickEventOnCollaptiblePanelAlreadyDone;

	public WFIDBPageMasterDetail()
	{
		_RunAfterEvent = false;
		bFlagManageClickEventOnCollaptiblePanel = false;
		bFlagManageClickEventOnCollaptiblePanelAlreadyDone = false;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.InitializedPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = MasterDetailInitializedPage(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = InitGrid(ref rsMess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN MasterDetailInitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Control)this).Page.IsPostBack)
			{
				_SessionVariable = base.SessionEnvironment.SessionVariables[EntryPoint];
				if (_SessionVariable == null)
				{
					_SessionVariable = new IboDictionaryCollection<string, object>();
				}
				GridConfigList = new IboInternalGridConfigList();
				_SessionVariable.Add("GridConfigList", GridConfigList);
				base.SessionEnvironment.SessionVariables.Add(EntryPoint.ToUpper(), _SessionVariable);
			}
			else
			{
				GridConfigList = (IboInternalGridConfigList)_SessionVariable["GridConfigList"];
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InitGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Control)this).Page.IsPostBack)
			{
				goto IL_004a;
			}
			PerformanceLogAppend("DBPage InitializeInternalGrid");
			val = InitializeInternalGrid(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_004a;
			}
			val2 = val;
			goto end_IL_0005;
			IL_004a:
			PerformanceLogAppend("DBPage InitMSGrid");
			val = InitGridMS(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage InitTlkGrid");
				val = InitGridTlk(ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InitGridMS(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Invalid comparison between Unknown and I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IboInternalGridConfig gridConfig in GridConfigList)
			{
				foreach (Control childControl in GetChildControls((Control)(object)this))
				{
					Control val3 = childControl;
					IboGridView objGridView = (IboGridView)(object)((val3 is IboGridView) ? val3 : null);
					if (objGridView == null || Operators.CompareString(((Control)objGridView).ID.ToUpper(), gridConfig.Id.ToUpper(), false) != 0)
					{
						continue;
					}
					gridConfig.InitUi(this.ViewState, ref objGridView);
					if (((GridView)objGridView).EmptyDataTemplate == null)
					{
						((GridView)objGridView).EmptyDataTemplate = (ITemplate)(object)new IboEmptyDataTemplate(((Control)objGridView).ID);
					}
					((GridView)gridConfig.GridView).Sorting += new GridViewSortEventHandler(grd_Sorting);
					((GridView)gridConfig.GridView).PageIndexChanging += new GridViewPageEventHandler(grd_PageIndexChanging);
					((GridView)gridConfig.GridView).RowDataBound += new GridViewRowEventHandler(grd_RowDataBound);
					((Control)gridConfig.GridView).PreRender += grd_PreRender;
					if (Operators.CompareString(gridConfig.ToolbarId, "", false) == 0)
					{
						break;
					}
					if (gridConfig.GridInfo != null)
					{
						goto IL_019d;
					}
					IboGridInfoList gridInfoList = base.SessionEnvironment.GridInfoList;
					string nomRif = gridConfig.NomRif;
					IboInternalGridConfig iboInternalGridConfig;
					IboGridInfo robjGridInfo = (iboInternalGridConfig = gridConfig).GridInfo;
					FXRETURN val4 = gridInfoList.Add(nomRif, ref robjGridInfo, ref rsMess);
					iboInternalGridConfig.GridInfo = robjGridInfo;
					val = val4;
					if ((int)val <= 0)
					{
						goto IL_019d;
					}
					val2 = val;
					goto end_IL_0005;
					IL_019d:
					val = base.SessionEnvironment.ToolbarInfoList.Add(gridConfig.NomRif, gridConfig.GridInfo.Utente, ref gridConfig.ToolbarInfo, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						IboWebToolbar rObjWebToolbar = (IboWebToolbar)(object)GetControlByName((Control)(object)this, gridConfig.ToolbarId);
						ref IboWebToolbarInfo toolbarInfo = ref gridConfig.ToolbarInfo;
						IboAppCallStackHandling rObjCallStackHandler = base.SessionEnvironment.CallStackHandler;
						IboAppLogHandling rObjIboAppLogHandling = base.SessionEnvironment.LogHandling;
						DBConnection rObjDbMain = base.SessionEnvironment.DbConn;
						IncasTranslator rObjTranslator = base.SessionEnvironment.Translator;
						IboWebUserInfo rObjWebUserInfo = base.SessionEnvironment.WebUser.WebUserInfo;
						gridConfig.ToolbarConfig = new IboWebToolbarConfig(ref toolbarInfo, ref rObjWebToolbar, ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo, bOnlyEnabledButtons: true, bEnableSeparator: false, bEnableCaption: true);
						val = gridConfig.ToolbarConfig.LoadButtons(ref rsMess);
						if ((int)val <= 0)
						{
							if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0 && !gridConfig.VisibleInDupMode)
							{
								((Control)rObjWebToolbar).Visible = false;
							}
							if (((Control)rObjWebToolbar).Visible)
							{
								rObjWebToolbar.ToolbarClick += tlbgrd_ToolbarClick;
							}
							break;
						}
						val2 = val;
					}
					goto end_IL_0005;
				}
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InitGridTlk(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IboInternalGridConfig gridConfig in GridConfigList)
			{
				foreach (Control childControl in GetChildControls((Control)(object)this))
				{
					Control val3 = childControl;
					RadGrid objGridViewTlk = (RadGrid)(object)((val3 is RadGrid) ? val3 : null);
					if (objGridViewTlk == null || Operators.CompareString(((Control)objGridViewTlk).ID.ToUpper(), gridConfig.Id.ToUpper(), false) != 0)
					{
						continue;
					}
					gridConfig.InitUi(this.ViewState, ref objGridViewTlk);
					if (objGridViewTlk.MasterTableView.NoRecordsTemplate == null)
					{
						objGridViewTlk.MasterTableView.NoRecordsTemplate = (ITemplate)(object)new IboEmptyDataTemplate(((Control)objGridViewTlk).ID);
					}
					objGridViewTlk.SortCommand += new GridSortCommandEventHandler(grd_SortingTlk);
					objGridViewTlk.NeedDataSource += new GridNeedDataSourceEventHandler(grd_NeedDataSource);
					((Control)objGridViewTlk).PreRender += grd_PreRenderTlk;
					objGridViewTlk.ItemDataBound += new GridItemEventHandler(grd_ItemDataBoundTlk);
					if (Operators.CompareString(gridConfig.ToolbarId, "", false) == 0)
					{
						break;
					}
					if (gridConfig.GridInfo != null)
					{
						goto IL_0193;
					}
					IboGridInfoList gridInfoList = base.SessionEnvironment.GridInfoList;
					string nomRif = gridConfig.NomRif;
					IboInternalGridConfig iboInternalGridConfig;
					IboGridInfo robjGridInfo = (iboInternalGridConfig = gridConfig).GridInfo;
					FXRETURN val4 = gridInfoList.Add(nomRif, ref robjGridInfo, ref rsMess);
					iboInternalGridConfig.GridInfo = robjGridInfo;
					val = val4;
					if ((int)val <= 0)
					{
						goto IL_0193;
					}
					val2 = val;
					goto end_IL_0005;
					IL_0193:
					val = base.SessionEnvironment.ToolbarInfoList.Add(gridConfig.NomRif, gridConfig.GridInfo.Utente, ref gridConfig.ToolbarInfo, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						IboWebToolbar rObjWebToolbar = (IboWebToolbar)(object)GetControlByName((Control)(object)this, gridConfig.ToolbarId);
						ref IboWebToolbarInfo toolbarInfo = ref gridConfig.ToolbarInfo;
						IboAppCallStackHandling rObjCallStackHandler = base.SessionEnvironment.CallStackHandler;
						IboAppLogHandling rObjIboAppLogHandling = base.SessionEnvironment.LogHandling;
						DBConnection rObjDbMain = base.SessionEnvironment.DbConn;
						IncasTranslator rObjTranslator = base.SessionEnvironment.Translator;
						IboWebUserInfo rObjWebUserInfo = base.SessionEnvironment.WebUser.WebUserInfo;
						gridConfig.ToolbarConfig = new IboWebToolbarConfig(ref toolbarInfo, ref rObjWebToolbar, ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo, bOnlyEnabledButtons: true, bEnableSeparator: false, bEnableCaption: true);
						val = gridConfig.ToolbarConfig.LoadButtons(ref rsMess);
						if ((int)val <= 0)
						{
							if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0 && !gridConfig.VisibleInDupMode)
							{
								((Control)rObjWebToolbar).Visible = false;
							}
							if (((Control)rObjWebToolbar).Visible)
							{
								rObjWebToolbar.ToolbarClick += tlbgrd_ToolbarClick;
							}
							break;
						}
						val2 = val;
					}
					goto end_IL_0005;
				}
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.LoadData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = BeforeLoadDataInGrid(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = _LoadDataInGrid(ref rsMess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN BeforeLoadDataInGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN _LoadDataInGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IboInternalGridConfig gridConfig in GridConfigList)
			{
				IboInternalGridConfig objInternalGrid = gridConfig;
				if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0 && objInternalGrid.ForceEnableInVisMode)
				{
					if (objInternalGrid.GridType == IboInternalGridGridType.Microsoft)
					{
						objInternalGrid.GridView.ReadOnly = false;
					}
					((IboWebToolbar)(object)GetControlByName((Control)(object)this, objInternalGrid.ToolbarId)).Enabled = true;
				}
				val = InternalGridSqlSet(ref objInternalGrid, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if ((int)base.BaseFunctions.LoadGrid(ref objInternalGrid, ref rsMess) <= 0)
					{
						if (Operators.CompareString(objInternalGrid.Id, "", false) == 0)
						{
							continue;
						}
						ContextMenuControlTarget val3 = new ContextMenuControlTarget();
						val3.ControlID = objInternalGrid.Id;
						if (Operators.CompareString(objInternalGrid.ToolbarId, "", false) == 0)
						{
							continue;
						}
						IboWebToolbar iboWebToolbar = (IboWebToolbar)(object)GetControlByName((Control)(object)this, objInternalGrid.ToolbarId);
						if (iboWebToolbar == null)
						{
							continue;
						}
						((StateManagedCollection)iboWebToolbar.ContextMenuTlk.Targets).Clear();
						iboWebToolbar.ContextMenuTlk.Targets.Add((ContextMenuTarget)(object)val3);
						if (Operators.CompareString(objInternalGrid.ActionControlId, "", false) != 0)
						{
							WebControl val4 = (WebControl)GetControlByName((Control)(object)this, objInternalGrid.ActionControlId);
							if (val4 != null)
							{
								string clientID = ((Control)iboWebToolbar.ContextMenuTlk).ClientID;
								val4.Attributes.Add("onclick", "WFI.showMenuCtx(event, '" + clientID + "');");
							}
						}
						continue;
					}
					val2 = val;
				}
				goto end_IL_0005;
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterLoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.AfterLoadPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (IboInternalGridConfig gridConfig in GridConfigList)
				{
					IboInternalGridConfig ObjInternalGridConfig = gridConfig;
					if (ObjInternalGridConfig.DataTable == null || ObjInternalGridConfig.DataTable.Rows.Count != 0)
					{
						continue;
					}
					IDataSource val3 = null;
					val3 = ((ObjInternalGridConfig.GridType != 0) ? ((DataBoundControl)ObjInternalGridConfig.GridViewTlk).DataSourceObject : ((DataBoundControl)ObjInternalGridConfig.GridView).DataSourceObject);
					if (val3 != null || !((Control)this).Page.IsPostBack || (int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
					{
						continue;
					}
					goto end_IL_0005;
				}
				val2 = (FXRETURN)0;
			}
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.SaveData(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual void tlbgrd_ToolbarClick(object sender, IboWebToolbarEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		IboInternalGridConfig objInternalGridConfig = null;
		try
		{
			CallStackAdd();
			IboWebToolbar tlb = (IboWebToolbar)sender;
			foreach (IboInternalGridConfig gridConfig in GridConfigList)
			{
				if (Operators.CompareString(((Control)tlb).ID.ToUpper(), gridConfig.ToolbarId.ToUpper(), false) == 0)
				{
					objInternalGridConfig = gridConfig;
					break;
				}
			}
			if (objInternalGridConfig != null)
			{
				val = _AnyToolbarClick(ref tlb, ref objInternalGridConfig, ref e, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private FXRETURN _AnyToolbarClick(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			e.Managed = false;
			val = iboResourceManager.Resource_Check(ToolbarResourceName + objInternalGridConfig.ToolbarId.ToUpper() + e.CommandName.ToUpper(), ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
				if (objInternalGridConfig.GridType == IboInternalGridGridType.Microsoft)
				{
					IboInternalGridConfig iboInternalGridConfig;
					IboGridView grdGriglia = (iboInternalGridConfig = objInternalGridConfig).GridView;
					IboInternalGridConfig iboInternalGridConfig2;
					IboGridInfo objGridInfo = (iboInternalGridConfig2 = objInternalGridConfig).GridInfo;
					FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
					iboInternalGridConfig2.GridInfo = objGridInfo;
					iboInternalGridConfig.GridView = grdGriglia;
					val = keyDataFromGrid;
				}
				else
				{
					IboInternalGridConfig iboInternalGridConfig2;
					RadGrid grdGrigliaTlk = (iboInternalGridConfig2 = objInternalGridConfig).GridViewTlk;
					IboInternalGridConfig iboInternalGridConfig;
					IboGridInfo objGridInfo = (iboInternalGridConfig = objInternalGridConfig).GridInfo;
					FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref grdGrigliaTlk, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
					iboInternalGridConfig.GridInfo = objGridInfo;
					iboInternalGridConfig2.GridViewTlk = grdGrigliaTlk;
					val = keyDataFromGrid2;
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					FunctionArguments funcArg = new FunctionArguments(robjData);
					funcArg.Keys = robjKey;
					funcArg.Parameters["SilentAutoSave"] = "S";
					funcArg.Parameters["AutoSave"] = "N";
					if (Operators.CompareString(_Tabella, "", false) == 0)
					{
						funcArg.Parameters["DisableSave"] = "S";
					}
					else
					{
						funcArg.Parameters["DisableSave"] = "N";
					}
					val = AnyToolbarClick(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			e.Managed = false;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN AnyToolbarClick(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Invalid comparison between Unknown and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Invalid comparison between Unknown and I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Invalid comparison between Unknown and I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Invalid comparison between Unknown and I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Invalid comparison between Unknown and I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Invalid comparison between Unknown and I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Invalid comparison between Unknown and I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Invalid comparison between Unknown and I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Invalid comparison between Unknown and I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Invalid comparison between Unknown and I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Invalid comparison between Unknown and I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Invalid comparison between Unknown and I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Invalid comparison between Unknown and I4
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(e.CommandName, IboWebToolbar.Aggiorna, false) == 0)
			{
				val = InternalGridAggiorna(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_04e8;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(e.CommandName, IboWebToolbar.Ricerca, false) == 0)
				{
					goto IL_04e8;
				}
				if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaFiltri, false) == 0)
				{
					val = InternalGridAnnullaFiltri(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_04e8;
					}
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaPrefiltri, false) == 0)
					{
						goto IL_04e8;
					}
					if (Operators.CompareString(e.CommandName, IboWebToolbar.Visualizza, false) == 0)
					{
						funcArg.Name = "VISUALIZZAZIONE";
						val = InternalGridBeforeVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Inserisci, false) == 0)
					{
						funcArg.Name = "INSERIMENTO";
						val = InternalGridBeforeInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Modifica, false) == 0)
					{
						funcArg.Name = "MODIFICA";
						val = InternalGridBeforeModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Cancella, false) == 0)
					{
						funcArg.Name = "CANCELLAZIONE";
						val = InternalGridBeforeCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Duplica, false) == 0)
					{
						funcArg.Name = "DUPLICAZIONE";
						val = InternalGridBeforeDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Stampa, false) == 0)
					{
						val = InternalGridStampa(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val <= 0)
						{
							goto IL_04e8;
						}
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(e.CommandName, IboWebToolbar.StampaVeloce, false) == 0 || Operators.CompareString(e.CommandName, IboWebToolbar.EsportazioneDati, false) == 0)
						{
							goto IL_04e8;
						}
						val = InternalGridBeforeCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (!_RunAfterEvent)
								{
									goto IL_04e8;
								}
								val = InternalGridAfterCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04e8;
								}
								val2 = val;
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_04e8:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			e.Managed = false;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InternalGridSqlSet(ref IboInternalGridConfig objInternalGrid, ref string rsMess)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return InternalGridSqlSet(ref objInternalGrid, (IIncasTableLink)(object)this, ref rsMess);
	}

	protected virtual FXRETURN InternalGridSqlSet(ref IboInternalGridConfig objInternalGrid, IIncasTableLink objPanelDetail, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Invalid comparison between Unknown and I4
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Invalid comparison between Unknown and I4
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Invalid comparison between Unknown and I4
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Invalid comparison between Unknown and I4
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected I4, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected I4, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Invalid comparison between Unknown and I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((objInternalGrid.SourceType == IboInternalGridSourceType.FromSql) | (objInternalGrid.SourceType == IboInternalGridSourceType.FromStored)))
			{
				goto IL_0b10;
			}
			objInternalGrid.SqlStatement = objInternalGrid.SqlOriginalStatement;
			Hashtable sRetColl = null;
			val = base.BaseFunctions.StandardVariableFinder(objInternalGrid.SqlOriginalStatement, ref sRetColl, ref rsMess);
			if ((int)val <= 0)
			{
				objInternalGrid.SqlStatementVariables = sRetColl;
				int num = 0;
				IDictionaryEnumerator enumerator = sRetColl.GetEnumerator();
				while (true)
				{
					checked
					{
						if (enumerator.MoveNext())
						{
							object current = enumerator.Current;
							DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry));
							string text = "";
							string text2 = "";
							if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("MASTER_RECORD."))
							{
								text2 = "MASTER_RECORD";
								text = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
							}
							else if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("CONTROLS_RECORD."))
							{
								text2 = "CONTROLS_RECORD";
								text = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
							}
							else if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("GRID_RECORD."))
							{
								text2 = "GRID_RECORD";
								text = dictionaryEntry.Key.ToString().Remove(0, text2.Length + 1);
							}
							else if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("DETAIL_RECORD."))
							{
								text2 = "DETAIL_RECORD";
								text = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
							}
							else if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("SESSION_VARIABLE."))
							{
								text2 = "SESSION_VARIABLE";
								text = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
							}
							else
							{
								text2 = "MASTER_RECORD";
								text = dictionaryEntry.Key.ToString().ToUpper();
							}
							switch (text2)
							{
							case "MASTER_RECORD":
							{
								BeforeImageFieldsCollection beforeImageFieldsCollection2 = get_BeforeImage((IIncasTableLink)(object)this);
								if (beforeImageFieldsCollection2 != null)
								{
									foreach (string key in beforeImageFieldsCollection2.Keys)
									{
										if (Operators.CompareString(key.ToUpper(), text, false) == 0)
										{
											objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), beforeImageFieldsCollection2[key].FieldValue.ToString().Replace("'", "''"));
											break;
										}
									}
									break;
								}
								rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
								goto end_IL_0005;
							}
							case "DETAIL_RECORD":
							{
								BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(objPanelDetail);
								if (beforeImageFieldsCollection != null)
								{
									foreach (string key2 in beforeImageFieldsCollection.Keys)
									{
										if (Operators.CompareString(key2.ToUpper(), text, false) == 0)
										{
											objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), beforeImageFieldsCollection[key2].FieldValue.ToString().Replace("'", "''"));
											break;
										}
									}
									break;
								}
								rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
								goto end_IL_0005;
							}
							case "CONTROLS_RECORD":
							{
								Control controlByName = GetControlByName((Control)(object)this, text);
								if (controlByName != null && controlByName is IIboWebComponent)
								{
									objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), ((IIboWebComponent)controlByName).ObjValue.ToString().Replace("'", "''"));
								}
								break;
							}
							case "SESSION_VARIABLE":
								if (_SessionVariable.ContainsKey(text))
								{
									objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), _SessionVariable[text].ToString().Replace("'", "''"));
									break;
								}
								rsMess = TranslateMessage("XXX", "La variabile {0} non è stata trovata in sessione", text);
								goto end_IL_0005;
							case "GRID_RECORD":
							{
								string text3 = text.ToString().Split(new char[1] { '.' })[0];
								string text4 = text.ToString().Split(new char[1] { '.' })[1];
								IboInternalGridConfig iboInternalGridConfig = GridConfigList[text3];
								string text5 = "";
								if (iboInternalGridConfig != null)
								{
									if (iboInternalGridConfig.GridView != null)
									{
										if (iboInternalGridConfig.GridView.GetSelectedIndices().Length > 0)
										{
											text5 = ((((GridView)iboInternalGridConfig.GridView).PageCount <= 1) ? iboInternalGridConfig.DataTable.Rows[iboInternalGridConfig.GridView.GetSelectedIndices()[0]][text4].ToString() : iboInternalGridConfig.DataTable.Rows[iboInternalGridConfig.GridView.GetSelectedIndices()[0] + ((GridView)iboInternalGridConfig.GridView).PageIndex * ((GridView)iboInternalGridConfig.GridView).PageSize][text4].ToString());
										}
										else
										{
											num++;
											eTipoDati val3 = modGeneral.DataTypeToBaseType(iboInternalGridConfig.DataTable.Columns[text4].DataType);
											unchecked
											{
												switch ((int)val3)
												{
												default:
													if ((int)val3 == 99)
													{
													}
													break;
												case 1:
												case 2:
													text5 = "0";
													break;
												case 0:
													text5 = "";
													break;
												case 3:
												case 4:
													break;
												}
											}
										}
									}
									else if (iboInternalGridConfig.GridViewTlk != null)
									{
										if (iboInternalGridConfig.GridViewTlk.SelectedItems.Count > 0)
										{
											text5 = ((iboInternalGridConfig.GridViewTlk.PageCount <= 1) ? iboInternalGridConfig.DataTable.Rows[iboInternalGridConfig.GridView.GetSelectedIndices()[0]][text4].ToString() : iboInternalGridConfig.DataTable.Rows[iboInternalGridConfig.GridViewTlk.SelectedItems[0].RowIndex + iboInternalGridConfig.GridViewTlk.MasterTableView.CurrentPageIndex * iboInternalGridConfig.GridViewTlk.PageSize][text4].ToString());
										}
										else
										{
											num++;
											eTipoDati val4 = modGeneral.DataTypeToBaseType(iboInternalGridConfig.DataTable.Columns[text4].DataType);
											unchecked
											{
												switch ((int)val4)
												{
												default:
													if ((int)val4 == 99)
													{
													}
													break;
												case 1:
												case 2:
													text5 = "0";
													break;
												case 0:
													text5 = "";
													break;
												case 3:
												case 4:
													break;
												}
											}
										}
									}
									objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), text5.Replace("'", "''"));
									break;
								}
								rsMess = TranslateMessage("XXX", "{0} non esiste nella lista delle griglie configurate.", text3);
								val2 = (FXRETURN)5;
								goto end_IL_0005;
							}
							}
							continue;
						}
						if (Operators.CompareString(objInternalGrid.SqlStatement, "", false) == 0)
						{
							break;
						}
					}
					if (objInternalGrid.SourceType == IboInternalGridSourceType.FromSql)
					{
						if (num > 0)
						{
							objInternalGrid.SqlStatement = "SELECT * FROM (" + objInternalGrid.SqlStatement + ") T WHERE 'A' = 'B'";
							break;
						}
						if (Operators.CompareString(objInternalGrid.OrderByField, "", false) != 0)
						{
							objInternalGrid.SqlStatement = "SELECT <%TOP100PERCENT%> * FROM (" + objInternalGrid.SqlStatement + ") T ORDER BY " + objInternalGrid.OrderByField + " " + objInternalGrid.OrderByDirection;
							if ((int)base.DbConn.ServerTypeConnection == 0)
							{
								objInternalGrid.SqlStatement = Strings.Replace(objInternalGrid.SqlStatement, "<%TOP100PERCENT%>", "TOP 100 PERCENT", 1, -1, (CompareMethod)0);
							}
							else
							{
								objInternalGrid.SqlStatement = Strings.Replace(objInternalGrid.SqlStatement, "<%TOP100PERCENT%>", "", 1, -1, (CompareMethod)0);
							}
							break;
						}
						if (objInternalGrid.GridInfo != null)
						{
							goto IL_09ea;
						}
						IboGridInfoList gridInfoList = base.SessionEnvironment.GridInfoList;
						string nomRif = objInternalGrid.NomRif;
						IboInternalGridConfig iboInternalGridConfig2;
						IboGridInfo robjGridInfo = (iboInternalGridConfig2 = objInternalGrid).GridInfo;
						FXRETURN val5 = gridInfoList.Add(nomRif, ref robjGridInfo, ref rsMess);
						iboInternalGridConfig2.GridInfo = robjGridInfo;
						val = val5;
						if ((int)val <= 0)
						{
							goto IL_09ea;
						}
						val2 = val;
					}
					else
					{
						if (objInternalGrid.SourceType != IboInternalGridSourceType.FromStored)
						{
							break;
						}
						DataSet dataSet = null;
						string sqlStatement = objInternalGrid.SqlStatement;
						val = base.DbConn.OpenDataSet(sqlStatement, ref dataSet, ref rsMess);
						if ((int)val <= 0)
						{
							objInternalGrid.DataTable = dataSet.Tables[0];
							if (num > 0)
							{
								objInternalGrid.DataTable.Rows.Clear();
							}
							break;
						}
						val2 = val;
					}
					goto end_IL_0005;
					IL_09ea:
					if (Operators.CompareString(objInternalGrid.GridInfo.GetSortingSqlClause, "", false) != 0)
					{
						objInternalGrid.SqlStatement = "SELECT <%TOP100PERCENT%> * FROM (" + objInternalGrid.SqlStatement + ") T ORDER BY " + objInternalGrid.GridInfo.GetSortingSqlClause;
						if ((int)base.DbConn.ServerTypeConnection == 0)
						{
							objInternalGrid.SqlStatement = Strings.Replace(objInternalGrid.SqlStatement, "<%TOP100PERCENT%>", "TOP 100 PERCENT", 1, -1, (CompareMethod)0);
						}
						else
						{
							objInternalGrid.SqlStatement = Strings.Replace(objInternalGrid.SqlStatement, "<%TOP100PERCENT%>", "", 1, -1, (CompareMethod)0);
						}
					}
					break;
				}
				goto IL_0b10;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0b10:
			if (((objInternalGrid.SourceType == IboInternalGridSourceType.FromDataTable) | (objInternalGrid.SourceType == IboInternalGridSourceType.FromStored)) && ((Operators.CompareString(objInternalGrid.OrderByDirection, "", false) != 0) & (Operators.CompareString(objInternalGrid.OrderByField, "", false) != 0)))
			{
				string text6 = "";
				text6 = "<%FIELD%> <%ASCDESC%>";
				if (Operators.CompareString(objInternalGrid.OrderByDirection, "ASC", false) == 0)
				{
					text6 = Strings.Replace(text6, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0);
					objInternalGrid.OrderByDirection = "DESC";
				}
				else
				{
					text6 = Strings.Replace(text6, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0);
					objInternalGrid.OrderByDirection = "ASC";
				}
				text6 = Strings.Replace(text6, "<%FIELD%>", objInternalGrid.OrderByField, 1, -1, (CompareMethod)0);
				DataRow[] array = objInternalGrid.DataTable.Select("1=1", text6);
				DataTable dataTable = objInternalGrid.DataTable.Clone();
				DataRow[] array2 = array;
				foreach (DataRow row in array2)
				{
					dataTable.ImportRow(row);
				}
				objInternalGrid.DataTable = dataTable;
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InternalGridAggiornaSingola(ref IboInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("InternalGridAggiornaSingola BEGIN");
			val = InternalGridSqlSet(ref objInternalGridConfig, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("InternalGridAggiornaSingola 1");
				val = _InternalGridAggiornaPreserveSortOrder(ref objInternalGridConfig, ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("InternalGridAggiornaSingola END");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN _InternalGridAggiorna(ref IboInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (objInternalGridConfig.SourceType == IboInternalGridSourceType.FromSql)
			{
				objInternalGridConfig.DataTable = null;
			}
			if ((int)base.BaseFunctions.LoadGrid(ref objInternalGridConfig, ref rsMess) <= 0)
			{
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

	protected virtual FXRETURN InternalGridAggiornaTutte(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IboInternalGridConfig gridConfig in GridConfigList)
			{
				IboInternalGridConfig objInternalGridConfig = gridConfig;
				if (!objInternalGridConfig.Attivo)
				{
					continue;
				}
				val = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_0005;
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InternalGridAggiornaSingolaPreserveSortOrder(ref IboInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("InternalGridAggiornaSingolaPreserveSortOrder BEGIN");
			val = InternalGridSqlSet(ref objInternalGridConfig, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = _InternalGridAggiornaPreserveSortOrder(ref objInternalGridConfig, ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("InternalGridAggiornaSingolaPreserveSortOrder END");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected FXRETURN _InternalGridAggiornaPreserveSortOrder(ref IboInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (objInternalGridConfig.SourceType == IboInternalGridSourceType.FromSql)
			{
				objInternalGridConfig.DataTable = null;
			}
			string sqlStatement = objInternalGridConfig.SqlStatement;
			if (objInternalGridConfig.SourceType == IboInternalGridSourceType.FromSql && Operators.CompareString(objInternalGridConfig.GridInfo.CampiOrdinantiAttuali ?? "", "", false) != 0)
			{
				string text = "SELECT * FROM (" + objInternalGridConfig.SqlStatement + ") T ORDER BY <%FIELD%> <%ASCDESC%>";
				text = ((Operators.CompareString(objInternalGridConfig.GridInfo.CampiOrdinantiAttualiDirezione, "ASC", false) != 0) ? Strings.Replace(text, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0) : Strings.Replace(text, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0));
				text = Strings.Replace(text, "<%FIELD%>", objInternalGridConfig.GridInfo.CampiOrdinantiAttuali, 1, -1, (CompareMethod)0);
				objInternalGridConfig.LastSortedSqlStatement = text;
			}
			objInternalGridConfig.SqlStatement = objInternalGridConfig.LastSortedSqlStatement;
			if ((int)base.BaseFunctions.LoadGrid(ref objInternalGridConfig, ref rsMess) > 0)
			{
				objInternalGridConfig.SqlStatement = sqlStatement;
			}
			else
			{
				objInternalGridConfig.SqlStatement = sqlStatement;
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

	protected virtual FXRETURN InternalGridAggiornaRestoreSortOrder(ref IboInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("InternalGridAggiornaSingola BEGIN");
			val = InternalGridSqlSet(ref objInternalGridConfig, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("InternalGridAggiornaSingola 1");
				val = _InternalGridAggiorna(ref objInternalGridConfig, ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("InternalGridAggiornaSingola END");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = _InternalGridAggiorna(ref objInternalGridConfig, ref rsMess);
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

	protected virtual FXRETURN InternalGridAnnullaFiltri(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = objInternalGridConfig.GridConfig.AnnullaFiltri(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected virtual FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Invalid comparison between Unknown and I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (bSelezioneObbligatoria && funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && funcArg.Parameters.ContainsKey("AutoSave") && Operators.CompareString(funcArg.Parameters["AutoSave"].ToString(), "S", false) == 0)
				{
					funcArg.Parameters["SilentAutoSave"] = "N";
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
					{
						base.SessionEnvironment.UserMessage.Reset();
						base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
						base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
						base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare il salvataggio del record master?");
						base.SessionEnvironment.UserMessage.NeedToRefresh = true;
						base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
						_SessionVariable.Add("Delegate_ToolbarId", ((Control)tlb).ID);
						_SessionVariable.Add("Delegate_InternalGridConfig", objInternalGridConfig);
						_SessionVariable.Add("Delegate_FunctionArguments", funcArg);
						_SessionVariable.Add("Delegate_ToolbarEventArgs", e);
						base.SessionEnvironment.UserMessage.CallBackFunctionName = "InternalGridVisualizzaDelegate";
						WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
						IboMessageBox(ref UserMess);
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma)
					{
						flag = true;
						base.SessionEnvironment.UserMessage.Reset();
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
				}
				if (funcArg.Parameters.ContainsKey("SilentAutoSave") && Operators.CompareString(funcArg.Parameters["SilentAutoSave"].ToString(), "S", false) == 0)
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_030a;
				}
				if (Operators.CompareString(funcArg.Parameters["DisableSave"].ToString(), "S", false) == 0)
				{
					goto IL_0301;
				}
				val2 = SavingProcess(vbReload: true, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0301;
				}
				val = val2;
			}
			goto end_IL_0007;
			IL_030a:
			ImpostaStatoPagina(ref tlb);
			val = (FXRETURN)0;
			goto end_IL_0007;
			IL_0301:
			_RunAfterEvent = true;
			goto IL_030a;
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

	protected virtual FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: true, ref rsMess);
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

	protected virtual FXRETURN InternalGridBeforeVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.QueryStringToAddWhenReturning = "Returning=S";
			AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName);
			IboInternalGridConfig iboInternalGridConfig;
			IboGridInfo objGridInfo = (iboInternalGridConfig = objInternalGridConfig).GridInfo;
			FXRETURN val3 = manager.Visualizza(ref objGridInfo, ref funcArg, ref rsMess);
			iboInternalGridConfig.GridInfo = objGridInfo;
			if ((int)val3 <= 0)
			{
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

	public virtual FXRETURN InternalGridInserisciDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
				goto IL_016d;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
			val2 = InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
				objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
				funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
				e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
				val2 = InternalGridAfterInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_016d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_016d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	public virtual FXRETURN InternalGridModificaDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
				goto IL_016d;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
			val2 = InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
				objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
				funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
				e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
				val2 = InternalGridAfterModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_016d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_016d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	public virtual FXRETURN InternalGridVisualizzaDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
				goto IL_016d;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
			val2 = InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
				objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
				funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
				e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
				val2 = InternalGridAfterVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_016d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_016d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	public virtual FXRETURN InternalGridDuplicaDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
				goto IL_016d;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
			val2 = InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
				objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
				funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
				e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
				val2 = InternalGridAfterDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_016d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_016d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	protected virtual FXRETURN InternalGridCallFunctionDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
				goto IL_016d;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
			val2 = InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
				objInternalGridConfig = (IboInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
				funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
				e = (IboWebToolbarEventArgs)_SessionVariable["Delegate_ToolbarEventArgs"];
				val2 = InternalGridAfterCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_016d;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_016d:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	protected virtual FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: false, ref rsMess);
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

	protected virtual FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Invalid comparison between Unknown and I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_RunAfterEvent = false;
			if (bSelezioneObbligatoria && funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && funcArg.Parameters.ContainsKey("AutoSave") && Operators.CompareString(funcArg.Parameters["AutoSave"].ToString(), "S", false) == 0)
				{
					funcArg.Parameters["SilentAutoSave"] = "N";
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
					{
						base.SessionEnvironment.UserMessage.Reset();
						base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
						base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
						base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare il salvataggio del record master?");
						base.SessionEnvironment.UserMessage.NeedToRefresh = true;
						base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
						_SessionVariable.Add("Delegate_ToolbarId", ((Control)tlb).ID);
						_SessionVariable.Add("Delegate_InternalGridConfig", objInternalGridConfig);
						_SessionVariable.Add("Delegate_FunctionArguments", funcArg);
						_SessionVariable.Add("Delegate_ToolbarEventArgs", e);
						base.SessionEnvironment.UserMessage.CallBackFunctionName = "InternalGridInserisciDelegate";
						WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
						IboMessageBox(ref UserMess);
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma)
					{
						flag = true;
						base.SessionEnvironment.UserMessage.Reset();
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
				}
				if (funcArg.Parameters.ContainsKey("SilentAutoSave") && Operators.CompareString(funcArg.Parameters["SilentAutoSave"].ToString(), "S", false) == 0)
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_0311;
				}
				if (Operators.CompareString(funcArg.Parameters["DisableSave"].ToString(), "S", false) == 0)
				{
					goto IL_0308;
				}
				val2 = SavingProcess(vbReload: true, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0308;
				}
				val = val2;
			}
			goto end_IL_0007;
			IL_0311:
			ImpostaStatoPagina(ref tlb);
			val = (FXRETURN)0;
			goto end_IL_0007;
			IL_0308:
			_RunAfterEvent = true;
			goto IL_0311;
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

	protected virtual FXRETURN InternalGridBeforeInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.QueryStringToAddWhenReturning = "Returning=S";
			AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName);
			IboInternalGridConfig iboInternalGridConfig;
			IboGridInfo objGridInfo = (iboInternalGridConfig = objInternalGridConfig).GridInfo;
			FXRETURN val3 = manager.Inserisci(ref objGridInfo, ref funcArg, ref rsMess);
			iboInternalGridConfig.GridInfo = objGridInfo;
			if ((int)val3 <= 0)
			{
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

	protected virtual FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, bool bSelezioneObbligatoria, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Invalid comparison between Unknown and I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (bSelezioneObbligatoria && funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && funcArg.Parameters.ContainsKey("AutoSave") && Operators.CompareString(funcArg.Parameters["AutoSave"].ToString(), "S", false) == 0)
				{
					funcArg.Parameters["SilentAutoSave"] = "N";
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
					{
						base.SessionEnvironment.UserMessage.Reset();
						base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
						base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
						base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare il salvataggio del record master?");
						base.SessionEnvironment.UserMessage.NeedToRefresh = true;
						base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
						_SessionVariable.Add("Delegate_ToolbarId", ((Control)tlb).ID);
						_SessionVariable.Add("Delegate_InternalGridConfig", objInternalGridConfig);
						_SessionVariable.Add("Delegate_FunctionArguments", funcArg);
						_SessionVariable.Add("Delegate_ToolbarEventArgs", e);
						base.SessionEnvironment.UserMessage.CallBackFunctionName = "InternalGridModificaDelegate";
						WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
						IboMessageBox(ref UserMess);
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma)
					{
						flag = true;
						base.SessionEnvironment.UserMessage.Reset();
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
				}
				if (funcArg.Parameters.ContainsKey("SilentAutoSave") && Operators.CompareString(funcArg.Parameters["SilentAutoSave"].ToString(), "S", false) == 0)
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_030a;
				}
				if (Operators.CompareString(funcArg.Parameters["DisableSave"].ToString(), "S", false) == 0)
				{
					goto IL_0301;
				}
				val2 = SavingProcess(vbReload: true, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0301;
				}
				val = val2;
			}
			goto end_IL_0007;
			IL_030a:
			ImpostaStatoPagina(ref tlb);
			val = (FXRETURN)0;
			goto end_IL_0007;
			IL_0301:
			_RunAfterEvent = true;
			goto IL_030a;
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

	protected virtual FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, bSelezioneObbligatoria: true, ref rsMess);
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

	protected virtual FXRETURN InternalGridBeforeModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.QueryStringToAddWhenReturning = "Returning=S";
			AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName);
			IboInternalGridConfig iboInternalGridConfig;
			IboGridInfo objGridInfo = (iboInternalGridConfig = objInternalGridConfig).GridInfo;
			FXRETURN val3 = manager.Modifica(ref objGridInfo, ref funcArg, ref rsMess);
			iboInternalGridConfig.GridInfo = objGridInfo;
			if ((int)val3 <= 0)
			{
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

	protected virtual FXRETURN MyCancella(ref object objParam, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Invalid comparison between Unknown and I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FunctionArguments functionArguments = null;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_RunAfterEvent = false;
			functionArguments = (FunctionArguments)((object[])objParam)[3];
			iboInternalGridConfig = (IboInternalGridConfig)((object[])objParam)[2];
			IboWebToolbar tlb = (IboWebToolbar)((object[])objParam)[1];
			IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)((object[])objParam)[4];
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				functionArguments.QueryStringToAddWhenReturning = "Returning=S";
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare l'eliminazione dei record selezionati?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "MyCancella";
				base.SessionEnvironment.UserMessage.Parameters = RuntimeHelpers.GetObjectValue(objParam);
				WFIUserMessage userMessage;
				string Messaggio = (userMessage = base.SessionEnvironment.UserMessage).Message1;
				WFIUserMessage userMessage2;
				string Messaggio2 = (userMessage2 = base.SessionEnvironment.UserMessage).Message2;
				FXRETURN val3 = _InternalGridCancellaGetMessage(ref tlb, ref iboInternalGridConfig, ref functionArguments, ref e, ref Messaggio, ref Messaggio2, ref rsMess);
				userMessage2.Message2 = Messaggio2;
				userMessage.Message1 = Messaggio;
				val2 = val3;
				if ((int)val2 <= 0)
				{
					userMessage2 = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref userMessage2);
					goto IL_028b;
				}
				val = val2;
			}
			else
			{
				if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
				{
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
					goto IL_028b;
				}
				bool needToRefresh = base.SessionEnvironment.UserMessage.NeedToRefresh;
				object obj = RuntimeHelpers.GetObjectValue(base.SessionEnvironment.UserMessage.Parameters);
				base.SessionEnvironment.UserMessage.Reset();
				_RunAfterEvent = true;
				val2 = _InternalGridCancellaAction(ref tlb, ref iboInternalGridConfig, ref functionArguments, ref e, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (!needToRefresh)
					{
						goto IL_028b;
					}
					val2 = Aggiorna(ref obj, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_028b;
					}
					val = val2;
				}
			}
			goto end_IL_000a;
			IL_028b:
			val = (FXRETURN)0;
			end_IL_000a:;
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

	public override FXRETURN Aggiorna(ref object obj, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = Aggiorna(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				try
				{
					string text = (string)((object[])obj)[0];
					if (Operators.CompareString(text.ToUpper(), "DELSTD", false) != 0)
					{
						goto end_IL_0025;
					}
					IboWebToolbar tlb = (IboWebToolbar)((object[])obj)[1];
					IboWebToolbarEventArgs e = (IboWebToolbarEventArgs)((object[])obj)[4];
					FunctionArguments funcArg = (FunctionArguments)((object[])obj)[3];
					IboInternalGridConfig objInternalGridConfig = (IboInternalGridConfig)((object[])obj)[2];
					val2 = InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						base.MasterPage.ContentUpdatePanel.Update();
						objInternalGridConfig = GridConfigList[objInternalGridConfig.Id];
						if (objInternalGridConfig.GridType == IboInternalGridGridType.Microsoft)
						{
							objInternalGridConfig.GridView = (IboGridView)GetControlByName((Control)(object)this, objInternalGridConfig.Id);
						}
						else if (objInternalGridConfig.GridType == IboInternalGridGridType.Telerik)
						{
							objInternalGridConfig.GridViewTlk = (RadGrid)GetControlByName((Control)(object)this, objInternalGridConfig.Id);
						}
						objInternalGridConfig.DataTable = null;
						if ((int)base.BaseFunctions.LoadGrid(ref objInternalGridConfig, ref rsMess) <= 0)
						{
							if (objInternalGridConfig.GridType != 0 && objInternalGridConfig.GridType == IboInternalGridGridType.Telerik)
							{
								objInternalGridConfig.GridViewTlk.Rebind();
							}
							goto end_IL_0025;
						}
					}
					goto end_IL_0005;
					end_IL_0025:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				val = (FXRETURN)0;
			}
			end_IL_0005:;
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

	protected virtual FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				object objParam = new object[5] { "DELSTD", tlb, objInternalGridConfig, funcArg, e };
				val2 = MyCancella(ref objParam, ref rsMess);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN _InternalGridCancellaAction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Cancella(ref funcArg, ref rsMess) <= 0)
			{
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

	protected virtual FXRETURN _InternalGridCancellaGetMessage(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string Messaggio1, ref string Messaggio2, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridBeforeCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Invalid comparison between Unknown and I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_RunAfterEvent = false;
			if (funcArg.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun record selezionato");
			}
			else
			{
				if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && funcArg.Parameters.ContainsKey("AutoSave") && Operators.CompareString(funcArg.Parameters["AutoSave"].ToString(), "S", false) == 0)
				{
					funcArg.Parameters["SilentAutoSave"] = "N";
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
					{
						base.SessionEnvironment.UserMessage.Reset();
						base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
						base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
						base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare il salvataggio del record master?");
						base.SessionEnvironment.UserMessage.NeedToRefresh = true;
						base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
						_SessionVariable.Add("Delegate_ToolbarId", ((Control)tlb).ID);
						_SessionVariable.Add("Delegate_InternalGridConfig", objInternalGridConfig);
						_SessionVariable.Add("Delegate_FunctionArguments", funcArg);
						_SessionVariable.Add("Delegate_ToolbarEventArgs", e);
						base.SessionEnvironment.UserMessage.CallBackFunctionName = "InternalGridDuplicaDelegate";
						WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
						IboMessageBox(ref UserMess);
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma)
					{
						flag = true;
						base.SessionEnvironment.UserMessage.Reset();
					}
					else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
				}
				if (funcArg.Parameters.ContainsKey("SilentAutoSave") && Operators.CompareString(funcArg.Parameters["SilentAutoSave"].ToString(), "S", false) == 0)
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_0307;
				}
				if (Operators.CompareString(funcArg.Parameters["DisableSave"].ToString(), "S", false) == 0)
				{
					goto IL_02fe;
				}
				val2 = SavingProcess(vbReload: true, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_02fe;
				}
				val = val2;
			}
			goto end_IL_0007;
			IL_0307:
			ImpostaStatoPagina(ref tlb);
			val = (FXRETURN)0;
			goto end_IL_0007;
			IL_02fe:
			_RunAfterEvent = true;
			goto IL_0307;
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

	protected virtual FXRETURN InternalGridBeforeDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			funcArg.QueryStringToAddWhenReturning = "Returning=S";
			AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName);
			IboInternalGridConfig iboInternalGridConfig;
			IboGridInfo objGridInfo = (iboInternalGridConfig = objInternalGridConfig).GridInfo;
			FXRETURN val3 = manager.Duplica(ref objGridInfo, ref funcArg, ref rsMess);
			iboInternalGridConfig.GridInfo = objGridInfo;
			if ((int)val3 <= 0)
			{
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

	protected virtual FXRETURN InternalGridStampa(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Invalid comparison between Unknown and I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && funcArg.Parameters.ContainsKey("AutoSave") && Operators.CompareString(funcArg.Parameters["AutoSave"].ToString(), "S", false) == 0)
			{
				funcArg.Parameters["SilentAutoSave"] = "N";
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
				{
					base.SessionEnvironment.UserMessage.Reset();
					base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
					base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Attenzione!!!");
					base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermare il salvataggio del record master?");
					base.SessionEnvironment.UserMessage.NeedToRefresh = true;
					base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
					_SessionVariable.Add("Delegate_ToolbarId", ((Control)tlb).ID);
					_SessionVariable.Add("Delegate_InternalGridConfig", objInternalGridConfig);
					_SessionVariable.Add("Delegate_FunctionArguments", funcArg);
					_SessionVariable.Add("Delegate_ToolbarEventArgs", e);
					base.SessionEnvironment.UserMessage.CallBackFunctionName = "InternalGridCallFunctionDelegate";
					WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref UserMess);
				}
				else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma)
				{
					flag = true;
					base.SessionEnvironment.UserMessage.Reset();
				}
				else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
				}
			}
			if (funcArg.Parameters.ContainsKey("SilentAutoSave") && Operators.CompareString(funcArg.Parameters["SilentAutoSave"].ToString(), "S", false) == 0)
			{
				flag = true;
			}
			if (!flag)
			{
				goto IL_02f1;
			}
			if (Operators.CompareString(funcArg.Parameters["DisableSave"].ToString(), "S", false) == 0)
			{
				goto IL_02e8;
			}
			val2 = SavingProcess(vbReload: true, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_MasterRecordSaved)
				{
					base.MasterPage.ContentUpdatePanel.Update();
				}
				goto IL_02e8;
			}
			val = val2;
			goto end_IL_0007;
			IL_02e8:
			_RunAfterEvent = true;
			goto IL_02f1;
			IL_02f1:
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

	protected virtual FXRETURN InternalGridBeforeCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
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

	protected virtual FXRETURN InternalGridAfterCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			objInternalGridConfig.DataTable = null;
			if ((int)base.BaseFunctions.LoadGrid(ref objInternalGridConfig, ref rsMess) <= 0)
			{
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

	protected void grd_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		string vsMessaggio = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			RadGrid val2 = (RadGrid)sender;
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)val2).ID];
			val2.DataSource = iboInternalGridConfig.GridConfig.LastDataTableSource;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			vsMessaggio = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(vsMessaggio);
			}
		}
	}

	protected virtual void grd_ItemDataBoundTlk(object sender, GridItemEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			RadGrid val2 = (RadGrid)sender;
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)val2).ID];
			checked
			{
				if (e.Item is GridGroupFooterItem)
				{
					GridGroupFooterItem val3 = (GridGroupFooterItem)e.Item;
					((WebControl)val3).CssClass = "groupFooterRow";
				}
				else if (e.Item is GridDataItem)
				{
					try
					{
						GridDataItem val4 = (GridDataItem)e.Item;
						int num = ((TableRow)val4).Cells.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								GridColumn column = ((GridTableCell)((TableRow)val4).Cells[i]).Column;
								GridBoundColumn val5 = (GridBoundColumn)(object)((column is GridBoundColumn) ? column : null);
								if (val5 == null)
								{
									continue;
								}
								string dataField = val5.DataField;
								if (Operators.CompareString(dataField, "", false) == 0)
								{
									continue;
								}
								object objectValue = RuntimeHelpers.GetObjectValue(iboInternalGridConfig.GridConfig.LastDataTableSource.Rows[((GridItem)val4).DataSetIndex][dataField]);
								if ((object)objectValue.GetType() != typeof(byte[]))
								{
									continue;
								}
								GridTableCell val6 = (GridTableCell)((TableRow)val4).Cells[i];
								((TableCell)val6).Text = "Image not ready";
								byte[] array = (byte[])objectValue;
								if (array == null)
								{
									continue;
								}
								string text2 = iboInternalGridConfig.GridConfig.LastDataTableSource.Rows[((GridItem)val4).DataSetIndex][dataField + "Estensione"].ToString();
								string text3 = Guid.NewGuid().ToString() + "." + text2;
								string PercorsImmagineRidimensionata = "";
								File.WriteAllBytes(base.SessionEnvironment.WebApplicationDownloadDir + text3, array);
								IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
								string sNomeFile = base.SessionEnvironment.WebApplicationDownloadDir + text3;
								string rsMess = "";
								sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess);
								if (Operators.CompareString(text2.ToUpper(), "PDF", false) == 0)
								{
									((TableCell)val6).Text = "";
									System.Web.UI.WebControls.Image val7 = new System.Web.UI.WebControls.Image();
									((WebControl)val7).CssClass = "BlobField " + dataField;
									if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\PdfDocumentCustom.png")))
									{
										val7.ImageUrl = "~\\WFI\\Images\\PdfDocumentCustom.png";
									}
									else if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\Grid_PdfDocument.png")))
									{
										val7.ImageUrl = "~\\WFI\\Images\\Grid_PdfDocument.png";
									}
									else
									{
										val7.ImageUrl = "~\\WFI\\Images\\PdfDocument.jpg";
									}
									((Control)val7).Visible = true;
									((WebControl)val7).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
									HyperLink val8 = new HyperLink();
									((WebControl)val8).CssClass = "BlobFieldLink " + dataField;
									val8.NavigateUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text3);
									((Control)val8).Controls.Add((Control)(object)val7);
									val8.Target = "_blank";
									((Control)val6).Controls.Add((Control)(object)val8);
									continue;
								}
								if ((Operators.CompareString(text2.ToUpper(), "TIF", false) == 0) | (Operators.CompareString(text2.ToUpper(), "TIFF", false) == 0))
								{
									try
									{
										string text4 = base.SessionEnvironment.WebApplicationDownloadDir + text3;
										string text5 = Path.GetDirectoryName(text4) + "\\" + Path.GetFileNameWithoutExtension(text4) + ".jpg";
										Bitmap val9 = new Bitmap(text4);
										val9 = (Bitmap)System.Drawing.Image.FromFile(text4);
										((System.Drawing.Image)val9).Save(text5, ImageFormat.Jpeg);
										IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
										rsMess = "";
										sessionEnvironment2.AddFileToDelete(text5, ref rsMess);
										text2 = "jpg";
										text3 = Path.GetFileName(text5);
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										ProjectData.ClearProjectError();
									}
								}
								base.BaseFunctions.ResizeImage(base.SessionEnvironment.WebApplicationDownloadDir + text3, 100, ref PercorsImmagineRidimensionata);
								IboSessionEnvironment sessionEnvironment3 = base.SessionEnvironment;
								string sNomeFile2 = base.SessionEnvironment.WebApplicationDownloadDir + text3;
								rsMess = "";
								sessionEnvironment3.AddFileToDelete(sNomeFile2, ref rsMess);
								IboSessionEnvironment sessionEnvironment4 = base.SessionEnvironment;
								string sNomeFile3 = PercorsImmagineRidimensionata;
								rsMess = "";
								sessionEnvironment4.AddFileToDelete(sNomeFile3, ref rsMess);
								((TableCell)val6).Text = "";
								System.Web.UI.WebControls.Image val10 = new System.Web.UI.WebControls.Image();
								((WebControl)val10).CssClass = "BlobField " + dataField + " WFI-gallery-items";
								val10.ImageUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(PercorsImmagineRidimensionata);
								((Control)val10).Visible = true;
								((WebControl)val10).Attributes.Add("data-high-res-src", Strings.Replace("../../" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text3), "\\", "/", 1, -1, (CompareMethod)0));
								((WebControl)val10).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
								HyperLink val11 = new HyperLink();
								((WebControl)val11).CssClass = "BlobFieldLink " + dataField;
								val11.NavigateUrl = "#";
								((Control)val11).Controls.Add((Control)(object)val10);
								((Control)val6).Controls.Add((Control)(object)val11);
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			text = ex8.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val <= 0)
			{
			}
		}
	}

	protected virtual void grd_SortingTlk(object sender, GridSortCommandEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Invalid comparison between Unknown and I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		try
		{
			RadGrid val2 = (RadGrid)sender;
			IboInternalGridConfig ObjInternalGridConfig = GridConfigList[((Control)val2).ID];
			if (ObjInternalGridConfig.SourceType == IboInternalGridSourceType.FromSql)
			{
				text = "SELECT * FROM (" + ObjInternalGridConfig.SqlStatement + ") T ORDER BY <%FIELD%> <%ASCDESC%>";
				if (Operators.CompareString(ObjInternalGridConfig.OrderByDirection, "ASC", false) == 0)
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "DESC";
				}
				else
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "ASC";
				}
				text = Strings.Replace(text, "<%FIELD%>", e.SortExpression, 1, -1, (CompareMethod)0);
				if ((int)base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess) > 0)
				{
					return;
				}
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttuali = e.SortExpression;
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttualiDirezione = ObjInternalGridConfig.OrderByDirection;
				ObjInternalGridConfig.GridInfo.CampoAttivo = e.SortExpression;
				ObjInternalGridConfig.LastSortedSqlStatement = text;
				ObjInternalGridConfig.DataTable = dataTable;
				val2.CurrentPageIndex = 0;
				if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) > 0)
				{
					return;
				}
			}
			else
			{
				text = "<%FIELD%> <%ASCDESC%>";
				if (Operators.CompareString(ObjInternalGridConfig.OrderByDirection, "ASC", false) == 0)
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "DESC";
				}
				else
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "ASC";
				}
				text = Strings.Replace(text, "<%FIELD%>", e.SortExpression, 1, -1, (CompareMethod)0);
				ObjInternalGridConfig.OrderByField = e.SortExpression;
				DataRow[] array = ObjInternalGridConfig.DataTable.Select("1=1", text);
				dataTable = ObjInternalGridConfig.DataTable.Clone();
				DataRow[] array2 = array;
				foreach (DataRow row in array2)
				{
					dataTable.ImportRow(row);
				}
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttuali = e.SortExpression;
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttualiDirezione = ObjInternalGridConfig.OrderByDirection;
				ObjInternalGridConfig.GridInfo.CampoAttivo = e.SortExpression;
				ObjInternalGridConfig.DataTable = dataTable;
				val2.CurrentPageIndex = 0;
				if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) > 0)
				{
					return;
				}
			}
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected virtual void grd_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Invalid comparison between Unknown and I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Invalid comparison between Unknown and I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		try
		{
			IboGridView grdGriglia = (IboGridView)sender;
			IboInternalGridConfig ObjInternalGridConfig = GridConfigList[((Control)grdGriglia).ID];
			if (ObjInternalGridConfig.SourceType == IboInternalGridSourceType.FromSql)
			{
				text = "SELECT * FROM (" + ObjInternalGridConfig.SqlStatement + ") T ORDER BY <%FIELD%> <%ASCDESC%>";
				if (Operators.CompareString(ObjInternalGridConfig.OrderByDirection, "ASC", false) == 0)
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "DESC";
				}
				else
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "ASC";
				}
				text = Strings.Replace(text, "<%FIELD%>", e.SortExpression, 1, -1, (CompareMethod)0);
				if ((int)base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess) > 0)
				{
					return;
				}
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttuali = e.SortExpression;
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttualiDirezione = ObjInternalGridConfig.OrderByDirection;
				ObjInternalGridConfig.GridInfo.CampoAttivo = e.SortExpression;
				ObjInternalGridConfig.LastSortedSqlStatement = text;
				ObjInternalGridConfig.DataTable = dataTable;
				((GridView)grdGriglia).PageIndex = 0;
				string text2 = "";
				if (((GridView)grdGriglia).PageCount == 1)
				{
					DataKeyFieldCollection robjData = new DataKeyFieldCollection();
					DataKeyFieldValues[] robjKey = null;
					IboInternalGridConfig iboInternalGridConfig;
					IboGridInfo objGridInfo = (iboInternalGridConfig = ObjInternalGridConfig).GridInfo;
					FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
					iboInternalGridConfig.GridInfo = objGridInfo;
					val2 = keyDataFromGrid;
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					text2 = robjData.GetAllElementSqlWhereForDatatable();
				}
				if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) > 0)
				{
					return;
				}
				if (((GridView)grdGriglia).PageCount == 1 && Operators.CompareString(text2, "", false) != 0)
				{
					grdGriglia.UnselectAllRows();
					DataRow[] array = ObjInternalGridConfig.GridConfig.DataTableSource.Select("1=1 " + text2);
					DataRow[] array2 = array;
					foreach (DataRow row in array2)
					{
						grdGriglia.SelectRow(ObjInternalGridConfig.GridConfig.DataTableSource.Rows.IndexOf(row));
					}
				}
			}
			else
			{
				text = "<%FIELD%> <%ASCDESC%>";
				if (Operators.CompareString(ObjInternalGridConfig.OrderByDirection, "ASC", false) == 0)
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "DESC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "DESC";
				}
				else
				{
					text = Strings.Replace(text, "<%ASCDESC%>", "ASC", 1, -1, (CompareMethod)0);
					ObjInternalGridConfig.OrderByDirection = "ASC";
				}
				text = Strings.Replace(text, "<%FIELD%>", e.SortExpression, 1, -1, (CompareMethod)0);
				ObjInternalGridConfig.OrderByField = e.SortExpression;
				DataRow[] array3 = ObjInternalGridConfig.DataTable.Select("1=1", text);
				dataTable = ObjInternalGridConfig.DataTable.Clone();
				DataRow[] array4 = array3;
				foreach (DataRow row2 in array4)
				{
					dataTable.ImportRow(row2);
				}
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttuali = e.SortExpression;
				ObjInternalGridConfig.GridInfo.CampiOrdinantiAttualiDirezione = ObjInternalGridConfig.OrderByDirection;
				ObjInternalGridConfig.GridInfo.CampoAttivo = e.SortExpression;
				ObjInternalGridConfig.DataTable = dataTable;
				((GridView)grdGriglia).PageIndex = 0;
				DataKeyFieldCollection robjData2 = new DataKeyFieldCollection();
				DataKeyFieldValues[] robjKey2 = null;
				IboInternalGridConfig iboInternalGridConfig;
				IboGridInfo objGridInfo = (iboInternalGridConfig = ObjInternalGridConfig).GridInfo;
				FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData2, ref robjKey2, bSelezioneObbligatoria: false, ref rsMess);
				iboInternalGridConfig.GridInfo = objGridInfo;
				val2 = keyDataFromGrid2;
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				string allElementSqlWhereForDatatable = robjData2.GetAllElementSqlWhereForDatatable();
				if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) > 0)
				{
					return;
				}
			}
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected virtual void grd_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			GridView val2 = (GridView)sender;
			IboInternalGridConfig ObjInternalGridConfig = GridConfigList[((Control)val2).ID];
			val2.PageIndex = e.NewPageIndex;
			if ((int)base.BaseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
			}
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void grd_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			if ((int)e.Row.RowType == 2)
			{
				IboGridView val2 = (IboGridView)sender;
				IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)val2).ID];
				checked
				{
					if (iboInternalGridConfig.GridInfo.AllGrdStylesetTable != null && iboInternalGridConfig.GridInfo.AllGrdStylesetTable.Rows.Count > 0)
					{
						DataRowView dataRowView = (DataRowView)e.Row.DataItem;
						string text2 = dataRowView["Styleset"].ToString();
						GridViewRow row = e.Row;
						if (Operators.CompareString(text2, "", false) != 0)
						{
							DataRow[] array = iboInternalGridConfig.GridInfo.AllGrdStylesetTable.Select("StyleName='" + text2 + "'");
							if (array.Count() > 0)
							{
								TableItemStyle val3 = ((iboInternalGridConfig.GridConfig != null) ? ((TableItemStyle)iboInternalGridConfig.GridConfig.AllgrdStylesets[text2]) : ((TableItemStyle)base.SessionEnvironment.GridConfigList[iboInternalGridConfig.NomRif].AllgrdStylesets[text2]));
								if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "R", false) == 0)
								{
									((WebControl)row).BackColor = ((Style)val3).BackColor;
									((WebControl)row).ForeColor = ((Style)val3).ForeColor;
									((WebControl)row).Font.Bold = ((Style)val3).Font.Bold;
									((WebControl)row).Font.Italic = ((Style)val3).Font.Italic;
									((WebControl)row).Font.Name = ((Style)val3).Font.Name;
									((WebControl)row).Font.Underline = ((Style)val3).Font.Underline;
									((WebControl)row).Font.Size = ((Style)val3).Font.Size;
									((WebControl)row).BorderColor = ((Style)val3).BorderColor;
									((WebControl)row).BorderWidth = ((Style)val3).BorderWidth;
									row.RowState = (DataControlRowState)0;
									if (Operators.CompareString(((Style)val3).CssClass, "", false) != 0)
									{
										((WebControl)row).CssClass = ((WebControl)row).CssClass + " " + ((Style)val3).CssClass;
									}
									((WebControl)row).Attributes.Add("data-style-name", text2);
								}
								else if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "C", false) == 0)
								{
									int num = ((TableRow)row).Cells.Count - 1;
									for (int i = 0; i <= num; i++)
									{
										if (Operators.CompareString(((BoundField)((DataControlFieldCell)((TableRow)row).Cells[i]).ContainingField).DataField.ToUpper(), "STYLESET", false) != 0)
										{
											continue;
										}
										DataControlFieldCell val4 = (DataControlFieldCell)((TableRow)row).Cells[i];
										((WebControl)val4).BackColor = ((Style)val3).BackColor;
										((WebControl)val4).ForeColor = ((Style)val3).ForeColor;
										((WebControl)val4).Font.Bold = ((Style)val3).Font.Bold;
										((WebControl)val4).Font.Italic = ((Style)val3).Font.Italic;
										((WebControl)val4).Font.Name = ((Style)val3).Font.Name;
										((WebControl)val4).Font.Underline = ((Style)val3).Font.Underline;
										((WebControl)val4).Font.Size = ((Style)val3).Font.Size;
										((WebControl)val4).BorderColor = ((Style)val3).BorderColor;
										((WebControl)val4).BorderWidth = ((Style)val3).BorderWidth;
										if (Operators.CompareString(((Style)val3).CssClass, "", false) != 0)
										{
											((WebControl)val4).CssClass = ((Style)val3).CssClass;
										}
										((TableCell)val4).Text = "";
										((WebControl)val4).ToolTip = array[0]["DescrizioneStato"].ToString();
										((WebControl)val4).CssClass = "Styleset";
										if (Operators.CompareString(array[0]["Image"].ToString(), "", false) == 0)
										{
											continue;
										}
										Panel val5 = new Panel();
										((Control)val5).ID = "pnlImgStyleset";
										((WebControl)val5).CssClass = "pnlImgStyleset";
										System.Web.UI.WebControls.Image val6 = new System.Web.UI.WebControls.Image();
										((WebControl)val6).CssClass = "ImgStyleset";
										val6.ImageUrl = array[0]["Image"].ToString();
										((Control)val5).Controls.Add((Control)(object)val6);
										if (dataRowView.Row.Table.Columns.Contains("StylesetText"))
										{
											string text3 = dataRowView["StylesetText"].ToString();
											if (Operators.CompareString(text3, "", false) != 0)
											{
												Label val7 = new Label();
												((Control)val7).ID = "lblImgStyleset";
												((WebControl)val7).CssClass = "lblImgStyleset";
												val7.Text = text3;
												((Control)val5).Controls.Add((Control)(object)val7);
											}
										}
										((TableCell)val4).Text = "";
										((Control)val4).Controls.Add((Control)(object)val5);
									}
								}
							}
						}
					}
					int num2 = ((TableRow)e.Row).Cells.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						try
						{
							GridViewRow row2 = e.Row;
							string dataField = ((BoundField)((DataControlFieldCell)((TableRow)row2).Cells[j]).ContainingField).DataField;
							if (Operators.CompareString(dataField, "", false) == 0)
							{
								continue;
							}
							DataRow row3 = ((DataRowView)e.Row.DataItem).Row;
							object objectValue = RuntimeHelpers.GetObjectValue(row3[dataField]);
							if ((object)objectValue.GetType() != typeof(byte[]))
							{
								continue;
							}
							DataControlFieldCell val8 = (DataControlFieldCell)((TableRow)row2).Cells[j];
							((TableCell)val8).Text = "Image not ready";
							byte[] array2 = (byte[])objectValue;
							if (array2 == null)
							{
								continue;
							}
							string text4 = row3[dataField + "Estensione"].ToString();
							string text5 = Guid.NewGuid().ToString() + "." + text4;
							string PercorsImmagineRidimensionata = "";
							File.WriteAllBytes(base.SessionEnvironment.WebApplicationDownloadDir + text5, array2);
							IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
							string sNomeFile = base.SessionEnvironment.WebApplicationDownloadDir + text5;
							string rsMess = "";
							sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess);
							if (Operators.CompareString(text4.ToUpper(), "PDF", false) == 0)
							{
								((TableCell)val8).Text = "";
								System.Web.UI.WebControls.Image val9 = new System.Web.UI.WebControls.Image();
								((WebControl)val9).CssClass = "BlobField " + dataField;
								if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\PdfDocumentCustom.png")))
								{
									val9.ImageUrl = "~\\WFI\\Images\\PdfDocumentCustom.png";
								}
								else if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\Grid_PdfDocument.png")))
								{
									val9.ImageUrl = "~\\WFI\\Images\\Grid_PdfDocument.png";
								}
								else
								{
									val9.ImageUrl = "~\\WFI\\Images\\PdfDocument.jpg";
								}
								((Control)val9).Visible = true;
								((WebControl)val9).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
								HyperLink val10 = new HyperLink();
								((WebControl)val10).CssClass = "BlobFieldLink " + dataField;
								val10.NavigateUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text5);
								((Control)val10).Controls.Add((Control)(object)val9);
								val10.Target = "_blank";
								((Control)val8).Controls.Add((Control)(object)val10);
								continue;
							}
							if ((Operators.CompareString(text4.ToUpper(), "TIF", false) == 0) | (Operators.CompareString(text4.ToUpper(), "TIFF", false) == 0))
							{
								try
								{
									string text6 = base.SessionEnvironment.WebApplicationDownloadDir + text5;
									string text7 = Path.GetDirectoryName(text6) + "\\" + Path.GetFileNameWithoutExtension(text6) + ".jpg";
									Bitmap val11 = new Bitmap(text6);
									val11 = (Bitmap)System.Drawing.Image.FromFile(text6);
									((System.Drawing.Image)val11).Save(text7, ImageFormat.Jpeg);
									IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
									rsMess = "";
									sessionEnvironment2.AddFileToDelete(text7, ref rsMess);
									text4 = "jpg";
									text5 = Path.GetFileName(text7);
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
							base.BaseFunctions.ResizeImage(base.SessionEnvironment.WebApplicationDownloadDir + text5, 100, ref PercorsImmagineRidimensionata);
							IboSessionEnvironment sessionEnvironment3 = base.SessionEnvironment;
							string sNomeFile2 = PercorsImmagineRidimensionata;
							rsMess = "";
							sessionEnvironment3.AddFileToDelete(sNomeFile2, ref rsMess);
							((TableCell)val8).Text = "";
							System.Web.UI.WebControls.Image val12 = new System.Web.UI.WebControls.Image();
							((WebControl)val12).CssClass = "BlobField " + dataField + " WFI-gallery-items";
							val12.ImageUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(PercorsImmagineRidimensionata);
							((Control)val12).Visible = true;
							((WebControl)val12).Attributes.Add("data-high-res-src", Strings.Replace("../../" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text5), "\\", "/", 1, -1, (CompareMethod)0));
							((WebControl)val12).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
							HyperLink val13 = new HyperLink();
							((WebControl)val13).CssClass = "BlobFieldLink " + dataField;
							val13.NavigateUrl = "#";
							((Control)val13).Controls.Add((Control)(object)val12);
							((Control)val8).Controls.Add((Control)(object)val13);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = ex6.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val <= 0)
			{
			}
		}
	}

	protected void grd_PreRender(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		IboGridView val2 = null;
		try
		{
			CallStackAdd();
			val2 = (IboGridView)sender;
			PerformanceLogAppend("grd_PreRender " + ((Control)val2).ID + " BEGIN");
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)val2).ID];
			checked
			{
				foreach (GridViewRow row in ((GridView)val2).Rows)
				{
					GridViewRow val3 = row;
					int num = 0;
					if (Operators.CompareString(iboInternalGridConfig.GridInfo.AllGrd["CANSEL"].ToString(), "N", false) != 0)
					{
						num = 1;
					}
					if (val2.ReadOnly)
					{
						num = 0;
					}
					int num2 = 0;
					foreach (DataControlField item in (StateManagedCollection)((GridView)val2).Columns)
					{
						DataControlField val4 = item;
						BoundField val5 = (BoundField)(object)((val4 is BoundField) ? val4 : null);
						if (val5 == null)
						{
							continue;
						}
						int num3 = num2;
						int num4 = iboInternalGridConfig.GridInfo.TabGrd.Count - 1;
						for (int i = num3; i <= num4; i++)
						{
							DataRow dataRow = iboInternalGridConfig.GridInfo.TabGrd[i];
							if (Operators.CompareString(dataRow["NOMCAM"].ToString().ToUpper(), val5.DataField.ToUpper(), false) != 0)
							{
								continue;
							}
							num2++;
							if (Operators.CompareString(dataRow["VISIBILE"].ToString(), "S", false) != 0)
							{
								break;
							}
							int num5 = 0;
							if (Operators.CompareString(dataRow["MAXCHAR"].ToString(), "", false) != 0 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dataRow["MAXCHAR"])))
							{
								num5 = Conversions.ToInteger(dataRow["MAXCHAR"]);
							}
							if (Operators.CompareString(((TableRow)val3).Cells[num].Text, "", false) != 0)
							{
								((TableRow)val3).Cells[num].Text = modGeneral.TrimDoubleSpace(((TableRow)val3).Cells[num].Text);
							}
							if (unchecked(((TableRow)val3).Cells[num].Text.Length > num5 && num5 > 0))
							{
								try
								{
									if (!((TableRow)val3).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
									{
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = ((TableRow)val3).Cells[num].Text;
										((TableRow)val3).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip.Substring(0, num5).Trim() + "...", 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TITLE%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%CSSSTYLE%>", dataRow["NOMCAM"].ToString().ToUpper(), 1, -1, (CompareMethod)0);
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = "";
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									string text2 = "";
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								if (Operators.CompareString(dataRow["NOMCAMTOOLTIP"].ToString(), "", false) == 0)
								{
									break;
								}
								try
								{
									string text3 = dataRow["NOMCAMTOOLTIP"].ToString();
									string text4 = Strings.Trim(iboInternalGridConfig.DataTable.Rows[val3.DataItemIndex][text3].ToString());
									if (Operators.CompareString(text4, "", false) != 0)
									{
										if (!((TableRow)val3).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
										{
											((WebControl)((TableRow)val3).Cells[num]).ToolTip = ((TableRow)val3).Cells[num].Text;
											((TableRow)val3).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
											((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
											((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TITLE%>", text4, 1, -1, (CompareMethod)0);
											((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%CSSSTYLE%>", text3, 1, -1, (CompareMethod)0);
											((WebControl)((TableRow)val3).Cells[num]).ToolTip = "";
										}
										bFlagManageClickEventOnCollaptiblePanel = true;
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									string text5 = "";
									ProjectData.ClearProjectError();
								}
							}
							break;
						}
						num++;
					}
				}
				if (bFlagManageClickEventOnCollaptiblePanel & !bFlagManageClickEventOnCollaptiblePanelAlreadyDone)
				{
					foreach (Control childControl in GetChildControls((Control)(object)this))
					{
						Control val6 = childControl;
						if (val6 is CollapsiblePanelExtender)
						{
							val6.PreRender += cpCollapsiblePanelExtender_PreRender;
						}
					}
					bFlagManageClickEventOnCollaptiblePanelAlreadyDone = true;
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = ex6.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("grd_PreRender " + ((Control)val2).ID + " END");
			CallStackRemove();
			if ((int)val <= 0)
			{
			}
		}
	}

	private void grd_PreRenderTlk(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			RadGrid val2 = (RadGrid)sender;
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)val2).ID];
			if (iboInternalGridConfig.GridInfo.AllGrdStylesetTable != null && iboInternalGridConfig.GridInfo.AllGrdStylesetTable.Rows.Count > 0)
			{
				foreach (GridDataItem item in (GridItemCollection)val2.MasterTableView.Items)
				{
					GridDataItem val3 = item;
					string text2 = val3["Styleset"].Text;
					if (Operators.CompareString(text2, "", false) == 0)
					{
						continue;
					}
					DataRow[] array = iboInternalGridConfig.GridInfo.AllGrdStylesetTable.Select("StyleName='" + text2 + "'");
					if (array.Count() <= 0)
					{
						continue;
					}
					TableItemStyle val4 = (TableItemStyle)iboInternalGridConfig.GridConfig.AllgrdStylesets[text2];
					if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "R", false) == 0)
					{
						((WebControl)val3).BackColor = ((Style)val4).BackColor;
						((WebControl)val3).ForeColor = ((Style)val4).ForeColor;
						((WebControl)val3).Font.Bold = ((Style)val4).Font.Bold;
						((WebControl)val3).Font.Italic = ((Style)val4).Font.Italic;
						((WebControl)val3).Font.Name = ((Style)val4).Font.Name;
						((WebControl)val3).Font.Underline = ((Style)val4).Font.Underline;
						((WebControl)val3).Font.Size = ((Style)val4).Font.Size;
						((WebControl)val3).BorderColor = ((Style)val4).BorderColor;
						((WebControl)val3).BorderWidth = ((Style)val4).BorderWidth;
						if (Operators.CompareString(((Style)val4).CssClass, "", false) != 0)
						{
							((WebControl)val3).CssClass = ((WebControl)val3).CssClass + " " + ((Style)val4).CssClass;
						}
					}
					else
					{
						if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "C", false) != 0)
						{
							continue;
						}
						TableCell val5 = val3["Styleset"];
						((WebControl)val5).BackColor = ((Style)val4).BackColor;
						((WebControl)val5).ForeColor = ((Style)val4).ForeColor;
						((WebControl)val5).Font.Bold = ((Style)val4).Font.Bold;
						((WebControl)val5).Font.Italic = ((Style)val4).Font.Italic;
						((WebControl)val5).Font.Name = ((Style)val4).Font.Name;
						((WebControl)val5).Font.Underline = ((Style)val4).Font.Underline;
						((WebControl)val5).Font.Size = ((Style)val4).Font.Size;
						((WebControl)val5).BorderColor = ((Style)val4).BorderColor;
						((WebControl)val5).BorderWidth = ((Style)val4).BorderWidth;
						if (Operators.CompareString(((Style)val4).CssClass, "", false) != 0)
						{
							((WebControl)val5).CssClass = ((Style)val4).CssClass;
						}
						val5.Text = "";
						((WebControl)val5).ToolTip = array[0]["DescrizioneStato"].ToString();
						((WebControl)val5).CssClass = "Styleset";
						if (Operators.CompareString(array[0]["Image"].ToString(), "", false) == 0)
						{
							continue;
						}
						Panel val6 = new Panel();
						((Control)val6).ID = "pnlImgStyleset";
						((WebControl)val6).CssClass = "pnlImgStyleset";
						System.Web.UI.WebControls.Image val7 = new System.Web.UI.WebControls.Image();
						((WebControl)val7).CssClass = "ImgStyleset";
						val7.ImageUrl = array[0]["Image"].ToString();
						((Control)val6).Controls.Add((Control)(object)val7);
						if (((DataRowView)((GridItem)val3).DataItem).Row.Table.Columns.Contains("StylesetText"))
						{
							string text3 = ((DataRowView)((GridItem)val3).DataItem).Row["StylesetText"].ToString();
							if (Operators.CompareString(text3, "", false) != 0)
							{
								Label val8 = new Label();
								((Control)val8).ID = "lblImgStyleset";
								((WebControl)val8).CssClass = "lblImgStyleset";
								val8.Text = text3;
								((Control)val6).Controls.Add((Control)(object)val8);
							}
						}
						val5.Text = "";
						((Control)val5).Controls.Add((Control)(object)val6);
					}
				}
			}
			foreach (GridDataItem item2 in (GridItemCollection)val2.MasterTableView.Items)
			{
				GridDataItem val9 = item2;
				int num = 2;
				foreach (GridBoundColumn column in val2.Columns)
				{
					GridBoundColumn val10 = column;
					GridBoundColumn val11 = val10;
					if (val11 == null)
					{
						continue;
					}
					foreach (DataRow item3 in iboInternalGridConfig.GridInfo.TabGrd)
					{
						if (Operators.CompareString(item3["NOMCAM"].ToString().ToUpper(), val11.DataField.ToUpper(), false) != 0)
						{
							continue;
						}
						if (Operators.CompareString(item3["VISIBILE"].ToString(), "S", false) != 0)
						{
							break;
						}
						int num2 = 0;
						if (Operators.CompareString(item3["MAXCHAR"].ToString(), "", false) != 0 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(item3["MAXCHAR"])))
						{
							num2 = Conversions.ToInteger(item3["MAXCHAR"]);
						}
						if (Operators.CompareString(((TableRow)val9).Cells[num].Text, "", false) != 0)
						{
							((TableRow)val9).Cells[num].Text = modGeneral.TrimDoubleSpace(((TableRow)val9).Cells[num].Text);
						}
						if (((TableRow)val9).Cells[num].Text.Length > num2 && num2 > 0)
						{
							try
							{
								if (!((TableRow)val9).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
								{
									((WebControl)((TableRow)val9).Cells[num]).ToolTip = ((TableRow)val9).Cells[num].Text;
									((TableRow)val9).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
									((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val9).Cells[num]).ToolTip.Substring(0, num2).Trim() + "...", 1, -1, (CompareMethod)0);
									((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%TITLE%>", ((WebControl)((TableRow)val9).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
									((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%CSSSTYLE%>", item3["NOMCAM"].ToString().ToUpper(), 1, -1, (CompareMethod)0);
									((WebControl)((TableRow)val9).Cells[num]).ToolTip = "";
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							if (Operators.CompareString(item3["NOMCAMTOOLTIP"].ToString(), "", false) == 0)
							{
								break;
							}
							try
							{
								string text4 = item3["NOMCAMTOOLTIP"].ToString();
								string text5 = Strings.Trim(iboInternalGridConfig.DataTable.Rows[((GridItem)val9).DataSetIndex][text4].ToString());
								if (Operators.CompareString(text5, "", false) != 0)
								{
									if (!((TableRow)val9).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
									{
										((WebControl)((TableRow)val9).Cells[num]).ToolTip = ((TableRow)val9).Cells[num].Text;
										((TableRow)val9).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
										((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val9).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
										((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%TITLE%>", text5, 1, -1, (CompareMethod)0);
										((TableRow)val9).Cells[num].Text = Strings.Replace(((TableRow)val9).Cells[num].Text, "<%CSSSTYLE%>", text4, 1, -1, (CompareMethod)0);
										((WebControl)((TableRow)val9).Cells[num]).ToolTip = "";
									}
									bFlagManageClickEventOnCollaptiblePanel = true;
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
						break;
					}
					num = checked(num + 1);
				}
			}
			if (bFlagManageClickEventOnCollaptiblePanel & !bFlagManageClickEventOnCollaptiblePanelAlreadyDone)
			{
				foreach (Control childControl in GetChildControls((Control)(object)this))
				{
					Control val12 = childControl;
					if (val12 is CollapsiblePanelExtender)
					{
						val12.PreRender += cpCollapsiblePanelExtender_PreRender;
					}
				}
				bFlagManageClickEventOnCollaptiblePanelAlreadyDone = true;
			}
			if (val2.AllowPaging && val2.PageCount == 1)
			{
				val2.PagerStyle.Visible = false;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = ex6.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val <= 0)
			{
			}
		}
	}

	private void cpCollapsiblePanelExtender_PreRender(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			WebControl val = (WebControl)GetControlByName((Control)(object)this, ((CollapsiblePanelExtender)sender).ExpandControlID);
			val.Attributes.Add("onclick", "setTimeout(function(){try {htmltooltipFunc();} catch (e) { };},600);");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
