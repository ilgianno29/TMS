using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIMultiViewPage : WFIPage
{
	protected FunctionArguments _objFunctionArguments;

	protected Dictionary<string, Dictionary<string, object>> _objFormState;

	protected string _Context;

	protected MultiViewConfig _MultiViewConfig;

	protected bool _ActiveViewChanged;

	protected string _Tabella;

	protected MultiviewInternalGridConfigList GridConfigList;

	protected QueryCache _ComboQueryCache;

	protected bool _PersistComboQueryCacheOnPostback;

	[field: AccessedThroughProperty("lblDataAccessMode")]
	protected virtual IboWebLabel lblDataAccessMode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public override string ResourceName => "SYSTEM." + base.SessionEnvironment.WebApplicationName.ToUpper() + ".FORMS." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0)) + ((Control)ActiveView).ID + "." + _objFunctionArguments.Name.ToUpper();

	protected View ActiveView => _MultiViewConfig.MultiView.Views[_MultiViewConfig.MultiView.ActiveViewIndex];

	public WFIMultiViewPage()
	{
		((Control)this).Load += Page_Load;
		((Page)this).PreInit += Page_PreInit;
		_objFunctionArguments = null;
		_objFormState = null;
		_Context = "NO_CONTEXT";
		_MultiViewConfig = null;
		_ActiveViewChanged = false;
		_Tabella = "";
		_PersistComboQueryCacheOnPostback = false;
	}

	protected virtual FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Invalid comparison between Unknown and I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
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
				GridConfigList = new MultiviewInternalGridConfigList();
				_SessionVariable.Add("GridConfigList", GridConfigList);
				base.SessionEnvironment.SessionVariables.Add(EntryPoint.ToUpper(), _SessionVariable);
				_ComboQueryCache = new QueryCache();
				_SessionVariable.Add("ComboQueryCache", _ComboQueryCache);
			}
			else
			{
				GridConfigList = (MultiviewInternalGridConfigList)_SessionVariable["GridConfigList"];
				_ComboQueryCache = (QueryCache)_SessionVariable["ComboQueryCache"];
				if (!_PersistComboQueryCacheOnPostback)
				{
					_ComboQueryCache = new QueryCache();
					_SessionVariable["ComboQueryCache"] = (object)_ComboQueryCache;
				}
			}
			if (((Control)this).Page.IsPostBack)
			{
				goto IL_0165;
			}
			val = InitializeInternalGrid(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_0165;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0165:
			foreach (MultiviewInternalGridConfig gridConfig in GridConfigList)
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
					((GridView)objGridView).EmptyDataTemplate = (ITemplate)(object)new IboEmptyDataTemplate(((Control)objGridView).ID);
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
						goto IL_02df;
					}
					IboGridInfoList gridInfoList = base.SessionEnvironment.GridInfoList;
					string nomRif = gridConfig.NomRif;
					MultiviewInternalGridConfig multiviewInternalGridConfig;
					IboGridInfo robjGridInfo = (multiviewInternalGridConfig = gridConfig).GridInfo;
					FXRETURN val4 = gridInfoList.Add(nomRif, ref robjGridInfo, ref rsMess);
					multiviewInternalGridConfig.GridInfo = robjGridInfo;
					val = val4;
					if ((int)val <= 0)
					{
						goto IL_02df;
					}
					val2 = val;
					goto end_IL_0005;
					IL_02df:
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
							rObjWebToolbar.ToolbarClick += tlbgrd_ToolbarClick;
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

	protected virtual FXRETURN PreInitPage(ref string rsMess)
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

	protected virtual FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Invalid comparison between Unknown and I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Invalid comparison between Unknown and I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Invalid comparison between Unknown and I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Invalid comparison between Unknown and I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Invalid comparison between Unknown and I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Invalid comparison between Unknown and I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Invalid comparison between Unknown and I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Invalid comparison between Unknown and I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Invalid comparison between Unknown and I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Invalid comparison between Unknown and I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("BEGIN LOADPAGE");
			val = BeforeLoadPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ContextGet(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = InitializedPage(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						checked
						{
							if (!((Page)this).IsPostBack)
							{
								int num = _MultiViewConfig.Tabella.Count() - 1;
								int num2 = 0;
								string[][] array = default(string[][]);
								string[] array2 = default(string[]);
								while (true)
								{
									if (num2 > num)
									{
										_MultiViewConfig.Keys = array;
										break;
									}
									val = base.DbConn.SqlKeyTable(_MultiViewConfig.Tabella[num2], ref array2, ref rsMess);
									if (unchecked((int)val) <= 0)
									{
										array = (string[][])Utils.CopyArray((Array)array, (Array)new string[num2 + 1][]);
										array[num2] = array2;
										num2++;
										continue;
									}
									val2 = val;
									goto end_IL_000b;
								}
							}
							val = ContextCheck(ref rsMess);
						}
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = LoadInterfaceFeatures(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								Control controlByName = GetControlByName((Control)(object)ActiveView, "btnConferma_" + ((Control)ActiveView).ID);
								IboWebButton val3 = (IboWebButton)(object)((controlByName is IboWebButton) ? controlByName : null);
								if (val3 != null)
								{
									val3.Visible = Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0;
									((Button)val3).Click += btnConferma_Click;
								}
								Control controlByName2 = GetControlByName((Control)(object)ActiveView, "btnAnnulla_" + ((Control)ActiveView).ID);
								IboWebButton val4 = (IboWebButton)(object)((controlByName2 is IboWebButton) ? controlByName2 : null);
								if (val4 != null)
								{
									val4.Visible = true;
									((Button)val4).Click += btnAnnulla_Click;
								}
								if (!(_ActiveViewChanged | !((Page)this).IsPostBack))
								{
									goto IL_0349;
								}
								Control controlByName3 = GetControlByName((Control)(object)ActiveView, "lblDataAccessMode_" + ((Control)ActiveView).ID);
								IboWebLabel val5 = (IboWebLabel)(object)((controlByName3 is IboWebLabel) ? controlByName3 : null);
								if (val5 != null)
								{
									val5.Text = TranslateMessage("XXX", _objFunctionArguments.Name);
								}
								try
								{
									Control controlByName4 = GetControlByName((Control)(object)this, "imgModalita_" + ((Control)ActiveView).ID);
									Image val6 = (Image)(object)((controlByName4 is Image) ? controlByName4 : null);
									if (val6 != null)
									{
										if (File.Exists(base.SessionEnvironment.WebApplicationRoot + "\\images\\Toolbar\\ModalitaForm\\" + _objFunctionArguments.Name + ".png"))
										{
											val6.ImageUrl = "~/images/Toolbar/ModalitaForm/" + _objFunctionArguments.Name + ".png";
											((Control)val6).Visible = true;
										}
										else
										{
											((Control)val6).Visible = false;
										}
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
								val = iboResourceManager.Resource_Check(this, ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = LoadCombo(ref rsMess);
									if ((int)val <= 0)
									{
										goto IL_0349;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000b;
			IL_0349:
			if (((Control)this).Page.IsPostBack)
			{
				goto IL_03ad;
			}
			val = BeforeLoadData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LoadData(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AfterLoadData(ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_03ad;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_0443:
			val = LoadDataSourceComboLoadOnDemand(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LoadEventsForComboUpdatePanel(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AfterLoadPage(ref rsMess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
			goto end_IL_000b;
			IL_03ad:
			if (!(_ActiveViewChanged | !((Page)this).IsPostBack))
			{
				goto IL_0443;
			}
			val = BeforeLoadDataView(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LoadDataView(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AfterLoadDataView(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = ReloadCombo(ref rsMess);
						if ((int)val <= 0)
						{
							View activeView = ActiveView;
							string rsMess2 = "";
							SetFocusOnFirstControl((Control)(object)activeView, ref rsMess2);
							goto IL_0443;
						}
						val2 = val;
					}
				}
			}
			end_IL_000b:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("END LOADPAGE");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN Reload(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = BeforeLoadData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LoadData(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AfterLoadData(ref rsMess);
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

	protected virtual FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Page)this).IsPostBack && Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], _Context.ToUpper(), false) != 0)
			{
				rsMess = TranslateMessage("XXX", "Il contesto della chiamata non è corretto. Chiamata non consentita.");
			}
			else
			{
				val2 = (FXRETURN)0;
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

	protected virtual FXRETURN LoadInterfaceFeatures(ref string rsMess)
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
			val = LoadControlsInitialValues(ref rsMess);
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

	protected virtual FXRETURN LoadControlsInitialValues(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Page)this).IsPostBack)
			{
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)this))
				{
					Control val3 = iIboWebComponentControl;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					val4.InitialValue = RuntimeHelpers.GetObjectValue(val4.ObjValue);
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ContextGet(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_SessionVariable = base.SessionEnvironment.SessionVariables[EntryPoint];
			if (_SessionVariable == null)
			{
				_SessionVariable = new IboDictionaryCollection<string, object>();
			}
			base.SessionEnvironment.SessionVariables.Add(EntryPoint, _SessionVariable);
			if (!((Page)this).IsPostBack)
			{
				_MultiViewConfig = new MultiViewConfig();
				MultiViewConfig multiViewConfig = _MultiViewConfig;
				Control controlByName = GetControlByName((Control)(object)this, "MultiViewContainer");
				multiViewConfig.MultiView = (MultiView)(object)((controlByName is MultiView) ? controlByName : null);
				if (_MultiViewConfig.MultiView != null)
				{
					_MultiViewConfig.Where[0] = "";
					_SessionVariable.Add("MultiViewConfig", _MultiViewConfig);
					goto IL_0189;
				}
				rsMess = base.Translator.TranslateMessage("XXX", "Non è stato possibile determinare il controllo MultiView sulla pagina", new string[0]);
			}
			else
			{
				_MultiViewConfig = (MultiViewConfig)_SessionVariable["MultiViewConfig"];
				MultiViewConfig multiViewConfig2 = _MultiViewConfig;
				Control controlByName2 = GetControlByName((Control)(object)this, "MultiViewContainer");
				multiViewConfig2.MultiView = (MultiView)(object)((controlByName2 is MultiView) ? controlByName2 : null);
				if (_MultiViewConfig.MultiView != null)
				{
					_ActiveViewChanged = _MultiViewConfig.ActiveViewChanged;
					goto IL_0189;
				}
				rsMess = base.Translator.TranslateMessage("XXX", "Non è stato possibile determinare il controllo MultiView sulla pagina", new string[0]);
			}
			goto end_IL_0005;
			IL_0189:
			if (!((Page)this).IsPostBack)
			{
				_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				_MultiViewConfig.objFunctionArguments[0] = _objFunctionArguments;
			}
			else if (_ActiveViewChanged)
			{
				if (_MultiViewConfig.ActiveView == 0)
				{
					_objFunctionArguments = _MultiViewConfig.objFunctionArguments[0];
				}
				else
				{
					_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
					_MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView] = _objFunctionArguments;
				}
			}
			else
			{
				_objFunctionArguments = _MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView];
			}
			try
			{
				_Context = _MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].ObjectManager.ObjectManagerName;
				_Tabella = _MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].ObjectManager.ObjectTableName;
				_MultiViewConfig.Tabella[0] = _Tabella;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			val = RememberCaller(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_objFormState = (Dictionary<string, Dictionary<string, object>>)_SessionVariable["FormState"];
				val2 = (FXRETURN)0;
			}
			end_IL_0005:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	protected virtual FXRETURN LoadCombo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("LoadCombo -1");
			foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val3 = allIIboWebComponentControl;
				IIboDropdownList objCombo = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
				if (objCombo == null)
				{
					continue;
				}
				PerformanceLogAppend("LoadCombo -2");
				int sqlQueryTop = objCombo.SqlQueryTop;
				objCombo.SqlQueryTop = 0;
				val = LoadSingleCombo(ref objCombo, ref rsMess);
				if ((int)val <= 0)
				{
					objCombo.SqlQueryTop = sqlQueryTop;
					PerformanceLogAppend("LoadCombo -3");
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			val2 = (FXRETURN)0;
			end_IL_000b:;
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

	protected virtual FXRETURN LoadDataSourceComboLoadOnDemand(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).IsPostBack)
			{
				foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
				{
					Control val3 = allIIboWebComponentControl;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					IIboDropdownList val5 = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
					if (val5 != null && (val5.LoadOnDemand | val5.AutoLoadOnDemand))
					{
						try
						{
							val5.DataSource = RuntimeHelpers.GetObjectValue(_SessionVariable["ComboDataSource." + ((Control)(WebControl)val5).ID]);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	protected virtual FXRETURN ReloadCombo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("BEGIN ReloadCombo");
			foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val3 = allIIboWebComponentControl;
				IIboDropdownList val4 = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
				if (val4 == null)
				{
					continue;
				}
				val = ComboSelectedItem(val4, val4.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			val2 = (FXRETURN)0;
			end_IL_000b:;
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
			PerformanceLogAppend("END ReloadCombo");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ComboSelectedItem(IIboDropdownList objCombo, string sItemValue, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((objCombo.SqlQueryTop == 0) | objCombo.AutoLoadOnDemand | objCombo.LoadOnDemand) && !(objCombo is IboDropDownList))
			{
				IboWebComboTlk val3 = (IboWebComboTlk)(object)((objCombo is IboWebComboTlk) ? objCombo : null);
				if (val3 != null)
				{
					((RadComboBox)val3).EnableAutomaticLoadOnDemand = false;
					((RadComboBox)val3).EnableLoadOnDemand = false;
					val3.Text = "";
				}
				objCombo.DataBind();
				objCombo.ObjValue = sItemValue;
				string key = "ComboDataSourceTop50." + ((Control)objCombo).ID;
				if (_SessionVariable.ContainsKey(key))
				{
					objCombo.DataSource = RuntimeHelpers.GetObjectValue(_SessionVariable[key]);
					objCombo.DataBind();
				}
				objCombo.HtmlDecodedSpaces();
				if (!objCombo.ItemExist(""))
				{
					objCombo.ItemInsert(0, "");
				}
				goto IL_0156;
			}
			int sqlQueryTop = objCombo.SqlQueryTop;
			objCombo.SqlQueryTop = 0;
			val = LoadSingleCombo(ref objCombo, ref rsMess);
			if ((int)val > 0)
			{
				objCombo.SqlQueryTop = sqlQueryTop;
				val2 = val;
			}
			else
			{
				objCombo.SqlQueryTop = sqlQueryTop;
				objCombo.ObjValue = sItemValue;
				val = LoadSingleCombo(ref objCombo, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0156;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0156:
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

	protected virtual FXRETURN ComboSetFilter(IIboDropdownList objCombo, string sFilter, ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return ComboSetFilter(objCombo, sFilter, "", ref rsMess);
	}

	protected virtual FXRETURN ComboSetFilter(IIboDropdownList objCombo, string sFilter, string sItemValue, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			objCombo.SqlQueryWhere = sFilter;
			val = LoadSingleCombo(ref objCombo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = ComboSelectedItem(objCombo, sItemValue, ref rsMess);
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LoadDropDownList(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
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
			val2 = base.DbConn.OpenDataTable(vsSelect, ref dataSource, ref rsMess);
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

	protected virtual FXRETURN LoadDropDownList(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, string vsFilter, string vsOrderByField, ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Invalid comparison between Unknown and I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Invalid comparison between Unknown and I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtDestination = null;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(vsSelect.Trim(), "", false) == 0)
			{
				goto IL_05b0;
			}
			if ((int)base.DbConn.ServerTypeConnection == 0)
			{
				text = "SELECT TOP 100 PERCENT * FROM (" + vsSelect + ") T WHERE 1=1 ";
				text3 = "SELECT TOP 25 * FROM (" + vsSelect + ") T WHERE 1=1 ";
			}
			else
			{
				text = "SELECT * FROM (" + vsSelect + ") T WHERE 1=1 ";
				text3 = "SELECT * FROM (" + vsSelect + ") T WHERE 1=1 AND ROWNUM<=25 ";
			}
			if (Operators.CompareString(vsFilter, "", false) != 0)
			{
				text4 = "AND (" + vsFilter + ") ";
				text += text4;
				text3 += text4;
			}
			if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
			{
				text4 = "AND (" + robjDropDownList.SqlQueryWhere + ") ";
				text += text4;
				text3 += text4;
			}
			if ((int)base.DbConn.ServerTypeConnection == 0 && Operators.CompareString(vsOrderByField, "", false) != 0)
			{
				text4 = " ORDER BY " + vsOrderByField + " ";
				text += text4;
				text3 += text4;
			}
			if (robjDropDownList.ObjValue != null && Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) != 0)
			{
				if ((int)base.DbConn.ServerTypeConnection == 0)
				{
					text4 = " UNION SELECT TOP 1 * FROM (SELECT * FROM (" + vsSelect + ") T2 WHERE " + vsValueFieldAlias + "=" + base.DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
					if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
					{
						text4 = text4 + " AND (" + robjDropDownList.SqlQueryWhere + ")";
					}
					text4 += ") T ";
				}
				else if ((int)base.DbConn.ServerTypeConnection == 1)
				{
					text4 = " UNION SELECT * FROM (SELECT * FROM (" + vsSelect + ") T2 WHERE " + vsValueFieldAlias + "=" + base.DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
					if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
					{
						text4 = text4 + " AND (" + robjDropDownList.SqlQueryWhere + ")";
					}
					text4 += ") T WHERE ROWNUM<=1 ";
				}
				else
				{
					text4 = " UNION SELECT TOP 1 * FROM (SELECT * FROM (" + vsSelect + ") T2 WHERE " + vsValueFieldAlias + "=" + base.DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
					if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
					{
						text4 = text4 + " AND (" + robjDropDownList.SqlQueryWhere + ")) T ";
					}
				}
				text += text4;
				text3 += text4;
			}
			text = "SELECT * FROM (" + text + ") T1";
			text3 = "SELECT * FROM (" + text3 + ") T1";
			if (Operators.CompareString(vsOrderByField, "", false) != 0)
			{
				text4 = " ORDER BY " + vsOrderByField + " ";
				text += text4;
				text3 += text4;
			}
			if (_ComboQueryCache.Contains(text))
			{
				PerformanceLogAppend("BEGIN FROM CACHE - " + text);
				DataTable dtSource = (DataTable)_ComboQueryCache.Item(text).SqlQueryResult;
				base.BaseFunctions.CloneDataTable(dtSource, ref dtDestination);
				PerformanceLogAppend("END FROM CACHE");
				goto IL_04cf;
			}
			PerformanceLogAppend("BEGIN FROM DB - " + text);
			val2 = base.DbConn.OpenDataTable(text, ref dtDestination, ref rsMess);
			if ((int)val2 <= 0)
			{
				_ComboQueryCache.Add(new QueryCacheItem(text, dtDestination));
				PerformanceLogAppend("END FROM DB");
				goto IL_04cf;
			}
			goto end_IL_0023;
			IL_05b0:
			val = (FXRETURN)0;
			goto end_IL_0023;
			IL_04cf:
			text4 = "";
			if (robjDropDownList.ObjValue != null && Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) != 0)
			{
				text4 = robjDropDownList.ObjValue.ToString();
			}
			robjDropDownList.ItemClear();
			robjDropDownList.DataTextField = vsTextFieldAlias;
			robjDropDownList.DataValueField = vsValueFieldAlias;
			robjDropDownList.DataSource = dtDestination;
			try
			{
				robjDropDownList.DataBind();
				robjDropDownList.ObjValue = text4;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			PerformanceLogAppend("END DATABIND");
			robjDropDownList.HtmlDecodedSpaces();
			if (!robjDropDownList.ItemExist("") && vbBlankItem)
			{
				robjDropDownList.ItemInsert(0, "");
			}
			goto IL_05b0;
			end_IL_0023:;
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

	protected virtual FXRETURN LoadDropDownList(ref IIboDropdownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
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

	protected virtual FXRETURN LoadDropDownList(ref IboDropDownList robjDropDownList, ref string rsMess, bool vbBlankItem = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList robjDropDownList2 = (IIboDropdownList)(object)robjDropDownList;
		return LoadDropDownList(ref robjDropDownList2, ref rsMess);
	}

	protected virtual FXRETURN LoadEventsForComboUpdatePanel(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		IboWebUpdatePanelForDropDownList val3 = null;
		Button val4 = null;
		TextBox val5 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (Control childControl in GetChildControls((Control)(object)this))
			{
				Control val6 = childControl;
				if (val6 is IboWebUpdatePanelForDropDownList)
				{
					val3 = (IboWebUpdatePanelForDropDownList)val6;
					val4 = (Button)GetControlByName((Control)(object)val3, val3.ButtonId);
					val4.Click += ApplicaFiltroAllaCombo;
					val5 = (TextBox)GetControlByName((Control)(object)val3, val3.TextBoxId);
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LoadSingleCombo(ref IIboDropdownList objCombo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objCombo.SqlQuery, "", false) == 0)
			{
				goto IL_01f7;
			}
			int sqlQueryTop = 0;
			if (objCombo.AutoLoadOnDemand)
			{
				sqlQueryTop = objCombo.SqlQueryTop;
				objCombo.SqlQueryTop = 0;
			}
			if ((int)LoadDropDownList(ref objCombo, ref rsMess) <= 0)
			{
				objCombo.SqlQueryTop = sqlQueryTop;
				if (objCombo.LoadOnDemand | objCombo.AutoLoadOnDemand)
				{
					string iD = ((Control)(WebControl)objCombo).ID;
					string key = "ComboDataSource." + iD;
					DataTable dataTable = (DataTable)objCombo.DataSource;
					if (_SessionVariable.ContainsKey(key))
					{
						try
						{
							((DataTable)_SessionVariable[key]).Dispose();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					_SessionVariable.Remove(key);
					_SessionVariable.Add(key, dataTable);
					key = "ComboDataSourceTop50." + iD;
					if (_SessionVariable.ContainsKey(key))
					{
						try
						{
							((DataTable)_SessionVariable[key]).Dispose();
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
					_SessionVariable.Remove(key);
					DataTable dataTable2 = dataTable.Clone();
					int num = 1;
					foreach (DataRow row in dataTable.Rows)
					{
						dataTable2.ImportRow(row);
						if (num == 50)
						{
							break;
						}
						num = checked(num + 1);
					}
					_SessionVariable.Add(key, dataTable2);
				}
				goto IL_01f7;
			}
			goto end_IL_0005;
			IL_01f7:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
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

	protected virtual FXRETURN LoadSingleCombo(ref IboDropDownList objCombo, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList objCombo2 = (IIboDropdownList)(object)objCombo;
		return LoadSingleCombo(ref objCombo2, ref rsMess);
	}

	protected virtual FXRETURN LoadSingleCombo(ref IboWebComboTlk objCombo, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList objCombo2 = (IIboDropdownList)(object)objCombo;
		return LoadSingleCombo(ref objCombo2, ref rsMess);
	}

	protected virtual FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Invalid comparison between Unknown and I4
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Invalid comparison between Unknown and I4
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Invalid comparison between Unknown and I4
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Invalid comparison between Unknown and I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		DataTable dataTable = null;
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			switch (_objFunctionArguments.Name)
			{
			case "DUPLICAZIONE":
			case "MODIFICA":
			case "CANCELLAZIONE":
			case "VISUALIZZAZIONE":
				if (_objFunctionArguments.Data == null)
				{
					rsMess = TranslateMessage("XXX", "Dati incompleti o mancanti.");
				}
				else if (_objFunctionArguments.Data.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Chiave non specificata.");
				}
				else
				{
					text3 = _MultiViewConfig.Tabella[0];
					text4 = _MultiViewConfig.Where[0];
					if (Operators.CompareString(text3, "", false) == 0)
					{
						text2 = "SELECT 'PIER' IDLE " + base.DbConn.FromDual();
					}
					else
					{
						text2 = "SELECT * FROM " + text3 + " WHERE 1=1 ";
						if (Operators.CompareString(text4, "", false) != 0)
						{
							text2 = text2 + " AND " + text4 + " ";
						}
						text2 += _objFunctionArguments.Data.GetFirstElementSqlWhere();
					}
					val = base.SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
					if ((int)val <= 0)
					{
						if (dataTable.Rows.Count != 0)
						{
							dataTable.Columns.Add("_ROWSTATE", typeof(string));
							dataTable.Columns.Add("_ROWID", typeof(string));
							foreach (DataRow row in dataTable.Rows)
							{
								row["_ROWSTATE"] = "U";
								row["_ROWID"] = Guid.NewGuid().ToString();
							}
							dataTable.TableName = _MultiViewConfig.Tabella[0];
							if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
							{
								_MultiViewConfig.DataTableBeforeImage[0] = dataTable;
								base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[0]);
								_MultiViewConfig.DataTableBeforeImage[0].Clear();
								foreach (DataRow row2 in _MultiViewConfig.DataTable[0].Rows)
								{
									row2["_ROWSTATE"] = "I";
								}
							}
							else
							{
								_MultiViewConfig.DataTableBeforeImage[0] = dataTable;
								base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[0]);
							}
							int num2 = checked(((ControlCollection)_MultiViewConfig.MultiView.Views).Count - 1);
							Hashtable sRetColl = default(Hashtable);
							for (int j = 1; j <= num2; j = checked(j + 1))
							{
								text3 = _MultiViewConfig.Tabella[j];
								text4 = _MultiViewConfig.Where[j];
								if (Operators.CompareString(text3, "", false) == 0)
								{
									continue;
								}
								string text5 = "";
								text2 = "";
								text5 = "SELECT * FROM " + text3 + " WHERE 1=1 ";
								if (Operators.CompareString(text4, "", false) != 0)
								{
									text5 = text5 + " AND " + text4 + " ";
								}
								val = base.BaseFunctions.StandardVariableFinder(text5, ref sRetColl, ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									IDictionaryEnumerator enumerator3 = sRetColl.GetEnumerator();
									while (true)
									{
										if (enumerator3.MoveNext())
										{
											object current = enumerator3.Current;
											DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry));
											string[] array = Strings.Split(dictionaryEntry.Key.ToString(), ".", -1, (CompareMethod)0);
											string sId = array[0];
											string text6 = array[1];
											int num3 = _MultiViewConfig.get_GetIndexViewByID(sId);
											if (!_MultiViewConfig.DataTable[num3].Columns.Contains(text6))
											{
												rsMess = base.Translator.TranslateMessage("XXX", "Impossibile identificare il campo di legame tra MASTER VIEW e DETAILS VIEW {0}", new string[1] { _MultiViewConfig.Tabella[j] });
												break;
											}
											string text7 = "";
											foreach (DataRow row3 in _MultiViewConfig.DataTable[num3].Rows)
											{
												text7 = "";
												try
												{
													text7 = row3[text6].ToString();
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													ProjectData.ClearProjectError();
												}
												if (Operators.CompareString(text7, "", false) == 0)
												{
													text7 = "***";
												}
												text2 = ((Operators.CompareString(text2, "", false) != 0) ? (text2 + " UNION " + text5) : text5);
												text2 = Strings.Replace(text2, dictionaryEntry.Value.ToString(), base.DbConn.SQLFormatString(text7), 1, -1, (CompareMethod)0);
											}
											if (Operators.CompareString(text2, "", false) == 0)
											{
												text2 = text5;
												text7 = ((!(_MultiViewConfig.DataTable[num3].Columns[text6].DataType == typeof(string))) ? "-1" : "");
												text2 = Strings.Replace(text2, dictionaryEntry.Value.ToString(), base.DbConn.SQLFormatString(text7), 1, -1, (CompareMethod)0);
											}
											continue;
										}
										dataTable = null;
										val = base.SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
										if ((int)val > 0)
										{
											val2 = val;
											break;
										}
										dataTable.Columns.Add("_ROWSTATE", typeof(string));
										dataTable.Columns.Add("_ROWID", typeof(string));
										foreach (DataRow row4 in dataTable.Rows)
										{
											row4["_ROWSTATE"] = "U";
											row4["_ROWID"] = Guid.NewGuid().ToString();
										}
										dataTable.TableName = _MultiViewConfig.Tabella[j];
										if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
										{
											_MultiViewConfig.DataTableBeforeImage[j] = dataTable;
											base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[j]);
											_MultiViewConfig.DataTableBeforeImage[j].Clear();
											foreach (DataRow row5 in _MultiViewConfig.DataTable[j].Rows)
											{
												row5["_ROWSTATE"] = "I";
											}
										}
										else
										{
											_MultiViewConfig.DataTableBeforeImage[j] = dataTable;
											base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[j]);
										}
										goto IL_08b9;
									}
								}
								goto end_IL_0026;
								IL_08b9:;
							}
							break;
						}
						rsMess = TranslateMessage("XXX", "Nessun record trovato.");
					}
				}
				goto end_IL_0026;
			case "INSERIMENTO":
				text3 = _MultiViewConfig.Tabella[0];
				text4 = _MultiViewConfig.Where[0];
				text2 = ((Operators.CompareString(text3, "", false) != 0) ? ("SELECT * FROM " + text3 + " WHERE 1=2 ") : ("SELECT 'PIER' IDLE " + base.DbConn.FromDual()));
				val = base.SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
				if ((int)val <= 0)
				{
					dataTable.Columns.Add("_ROWSTATE", typeof(string));
					dataTable.Columns.Add("_ROWID", typeof(string));
					dataTable.TableName = _MultiViewConfig.Tabella[0];
					_MultiViewConfig.DataTableBeforeImage[0] = dataTable;
					base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[0]);
					DataRow activeDataRow = _MultiViewConfig.DataTable[0].NewRow();
					_MultiViewConfig.ActiveDataRow = activeDataRow;
					int num = checked(((ControlCollection)_MultiViewConfig.MultiView.Views).Count - 1);
					for (int i = 1; i <= num; i = checked(i + 1))
					{
						text3 = _MultiViewConfig.Tabella[i];
						text4 = _MultiViewConfig.Where[i];
						if (Operators.CompareString(text3, "", false) == 0)
						{
							continue;
						}
						text2 = "SELECT * FROM " + text3 + " WHERE 1=2 ";
						dataTable = null;
						val = base.SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
						if ((int)val <= 0)
						{
							dataTable.Columns.Add("_ROWSTATE", typeof(string));
							dataTable.Columns.Add("_ROWID", typeof(string));
							dataTable.TableName = _MultiViewConfig.Tabella[i];
							_MultiViewConfig.DataTableBeforeImage[i] = dataTable;
							base.BaseFunctions.CloneDataTable(dataTable, ref _MultiViewConfig.DataTable[i]);
							continue;
						}
						val2 = val;
						goto end_IL_0026;
					}
					break;
				}
				goto end_IL_0026;
			default:
				rsMess = TranslateMessage("XXX", "Modalità/funzionalità non gestita.");
				goto end_IL_0026;
			}
			val2 = (FXRETURN)0;
			end_IL_0026:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	protected virtual FXRETURN LoadDataInCheckList(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
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

	protected virtual FXRETURN SaveDataInCheckList(ref IboWebCheckBoxList checkList, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Invalid comparison between Unknown and I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Invalid comparison between Unknown and I4
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Invalid comparison between Unknown and I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(checkList.TableName, "", false) != 0) & (Operators.CompareString(checkList.FieldName1, "", false) != 0) & (Operators.CompareString(checkList.FieldName2, "", false) != 0)) || !((Operators.CompareString(checkList.BeforeImage, checkList.ObjValue.ToString(), false) != 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
			{
				goto IL_03b9;
			}
			text = "DELETE FROM <%TABLE%> WHERE <%FIELD1%> = <%VALUE1%>";
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)this))
			{
				Control val3 = iIboWebComponentControl;
				IIboWebComponent val4 = (IIboWebComponent)val3;
				if (val4.IsKey)
				{
					obj = RuntimeHelpers.GetObjectValue(val4.ObjValue);
					break;
				}
			}
			text = Strings.Replace(text, "<%TABLE%>", checkList.TableName, 1, -1, (CompareMethod)0);
			text = Strings.Replace(text, "<%FIELD1%>", checkList.FieldName1, 1, -1, (CompareMethod)0);
			text = Strings.Replace(text, "<%VALUE1%>", base.DbConn.SQLFormatString(obj.ToString()), 1, -1, (CompareMethod)0);
			val = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val <= 0)
			{
				foreach (ListItem item in ((ListControl)checkList).Items)
				{
					ListItem val5 = item;
					text = "";
					if ((int)checkList.CheckBoxListMode == 0)
					{
						if (val5.Selected)
						{
							text = "INSERT INTO <%TABLE%> (<%FIELD1%>, <%FIELD2%>) VALUES (<%VALUE1%>, <%VALUE2%>)";
							text = Strings.Replace(text, "<%TABLE%>", checkList.TableName, 1, -1, (CompareMethod)0);
							text = Strings.Replace(text, "<%FIELD1%>", checkList.FieldName1, 1, -1, (CompareMethod)0);
							text = Strings.Replace(text, "<%FIELD2%>", checkList.FieldName2, 1, -1, (CompareMethod)0);
							text = Strings.Replace(text, "<%VALUE1%>", base.DbConn.SQLFormatString(obj.ToString()), 1, -1, (CompareMethod)0);
							text = Strings.Replace(text, "<%VALUE2%>", base.DbConn.SQLFormatString(val5.Value), 1, -1, (CompareMethod)0);
						}
					}
					else if ((int)checkList.CheckBoxListMode == 1)
					{
						text = "INSERT INTO <%TABLE%> (<%FIELD1%>, <%FIELD2%>, <%SELECTEDFIELD%>) VALUES (<%VALUE1%>, <%VALUE2%>, <%SELECTEDVALUE%>)";
						text = Strings.Replace(text, "<%TABLE%>", checkList.TableName, 1, -1, (CompareMethod)0);
						text2 = ((!val5.Selected) ? "N" : "S");
						text = Strings.Replace(text, "<%FIELD1%>", checkList.FieldName1, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "<%FIELD2%>", checkList.FieldName2, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "<%SELECTEDFIELD%>", checkList.FieldSelectedName, 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "<%VALUE1%>", base.DbConn.SQLFormatString(obj.ToString()), 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "<%VALUE2%>", base.DbConn.SQLFormatString(val5.Value), 1, -1, (CompareMethod)0);
						text = Strings.Replace(text, "<%SELECTEDVALUE%>", base.DbConn.SQLFormatString(text2), 1, -1, (CompareMethod)0);
					}
					if (Operators.CompareString(text, "", false) == 0)
					{
						continue;
					}
					val = base.DbConn.SqlExec(text, ref rsMess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_0015;
				}
				goto IL_03b9;
			}
			val2 = val;
			goto end_IL_0015;
			IL_03b9:
			val2 = (FXRETURN)0;
			end_IL_0015:;
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

	protected virtual FXRETURN BeforeLoadData(ref string rsMess)
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

	protected virtual FXRETURN AfterLoadData(ref string rsMess)
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

	protected virtual FXRETURN BeforeLoadPage(ref string rsMess)
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

	protected virtual FXRETURN AfterLoadPage(ref string rsMess)
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

	protected virtual FXRETURN BeforeLoadDataView(ref string rsMess)
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

	protected virtual FXRETURN LoadDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Invalid comparison between Unknown and I4
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Invalid comparison between Unknown and I4
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Invalid comparison between Unknown and I4
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		DataRow dataRow = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("BEGIN LoadDataView");
			if (_MultiViewConfig.ActiveView == 0 && _MultiViewConfig.DataTable[0].Rows.Count > 0)
			{
				_MultiViewConfig.ActiveDataRow = _MultiViewConfig.DataTable[0].Rows[0];
			}
			dataRow = _MultiViewConfig.ActiveDataRow;
			switch (_objFunctionArguments.Name)
			{
			case "DUPLICAZIONE":
			case "MODIFICA":
			case "CANCELLAZIONE":
			case "VISUALIZZAZIONE":
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)ActiveView))
				{
					Control val5 = iIboWebComponentControl;
					IIboWebComponent obj2 = (IIboWebComponent)val5;
					if (Operators.CompareString(obj2.FieldName, "", false) == 0)
					{
						continue;
					}
					text = obj2.FieldName;
					try
					{
						obj = RuntimeHelpers.GetObjectValue(dataRow[text]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						rsMess = TranslateMessage("XXX", "Il campo {0} non appartiene alla tabella {1}", text, _MultiViewConfig.ActiveViewTabella);
						ProjectData.ClearProjectError();
						goto end_IL_0026;
					}
					if (obj2 is IboWebImage)
					{
						obj2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
						IboWebImage iboWebImage = (IboWebImage)(object)obj2;
						iboWebImage.OriginalImageUrl = iboWebImage.ImageUrl;
						string fieldNameExtension = iboWebImage.FieldNameExtension;
						try
						{
							if (Operators.CompareString(fieldNameExtension, "", false) != 0)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(dataRow[fieldNameExtension]);
								if (!modGeneral.ExistsFieldInDatarow(ref dataRow, objectValue.ToString()))
								{
									throw new NotImplementedException("Implementare campo ValoreCampoExtension!!!");
								}
								iboWebImage.FileExtension = objectValue.ToString();
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							rsMess = TranslateMessage("XXX", "Il campo {0} non appartiene alla tabella {1}", fieldNameExtension, _MultiViewConfig.ActiveViewTabella);
							ProjectData.ClearProjectError();
							goto end_IL_0026;
						}
					}
					else
					{
						obj2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
					}
					if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
					{
						if (IsWfiIdentity(ref obj2))
						{
							obj2.ObjValue = "";
						}
						else if (IsDBIdentity(ref obj2))
						{
							obj2.ObjValue = "";
						}
					}
				}
				break;
			case "INSERIMENTO":
			{
				foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls((Control)(object)ActiveView))
				{
					Control val3 = iIboWebComponentControl2;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					if (Operators.CompareString(val4.FieldName, "", false) != 0)
					{
						val4.ToInitialValue();
					}
				}
				if (_MultiViewConfig.ActiveView <= 0)
				{
					break;
				}
				DataRow dataRow2 = _MultiViewConfig.ActiveDataRowArray[_MultiViewConfig.ParentView[_MultiViewConfig.ActiveView]];
				foreach (MultiViewForeignKey item in _MultiViewConfig.ForeignKey[_MultiViewConfig.ActiveView])
				{
					IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName((Control)(object)ActiveView, item.FieldName1);
					if (iIboWebComponentByFieldName != null && modGeneral.ExistsFieldInDatarow(ref dataRow2, item.FieldName2))
					{
						iIboWebComponentByFieldName.ObjValue = RuntimeHelpers.GetObjectValue(dataRow2[item.FieldName2]);
						iIboWebComponentByFieldName.ReadOnly = true;
					}
				}
				break;
			}
			default:
				rsMess = TranslateMessage("XXX", "Modalità/funzionalità non gestita.");
				goto end_IL_0026;
			}
			foreach (Control iIboWebComponentControl3 in GetIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val6 = iIboWebComponentControl3;
				if (val6 is IboWebCheckBoxList)
				{
					IboWebCheckBoxList val7 = (IboWebCheckBoxList)val6;
					val7.ReadOnly = !((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & val7.Enabled);
				}
				else if (val6 is IboWebToolbar)
				{
					IboWebToolbar iboWebToolbar = (IboWebToolbar)(object)val6;
					iboWebToolbar.Enabled = (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & iboWebToolbar.Enabled;
				}
				else if (val6 is IboGridView)
				{
					IboGridView val8 = (IboGridView)val6;
					val8.ReadOnly = !((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & ((WebControl)val8).Enabled & !val8.ReadOnly);
				}
				else
				{
					if (!(val6 is IIboWebComponent))
					{
						continue;
					}
					IIboWebComponent obj3 = (IIboWebComponent)val6;
					if (Operators.CompareString(obj3.FieldName, "", false) != 0)
					{
						obj3.ReadOnly = !((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & obj3.Enabled & !obj3.ReadOnly);
						if (IsDBIdentity(ref obj3))
						{
							obj3.ReadOnly = true;
						}
						else if (IsWfiIdentity(ref obj3))
						{
							obj3.ReadOnly = true;
						}
					}
				}
			}
			checked
			{
				if (_objFunctionArguments.Keys != null)
				{
					int num = _objFunctionArguments.Keys.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						foreach (Control iIboWebComponentControl4 in GetIIboWebComponentControls((Control)(object)ActiveView))
						{
							Control val9 = iIboWebComponentControl4;
							IIboWebComponent val10 = (IIboWebComponent)val9;
							if (Operators.CompareString(val10.FieldName.ToUpper(), _objFunctionArguments.Keys[i].FieldName.ToUpper(), false) == 0)
							{
								((IIboWebComponent)val9).IsKey = true;
								((IIboWebComponent)val9).AutoTrim = true;
								if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
								{
									((IIboWebComponent)val9).ReadOnly = true;
								}
								else if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0 && (_ActiveViewChanged | !((Page)this).IsPostBack))
								{
									((IIboWebComponent)val9).Clear();
								}
							}
						}
					}
				}
				val = LoadDataInCheckList(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) != 0)
				{
					goto IL_083a;
				}
				val = SaveDataView(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_083a;
				}
				val2 = val;
			}
			goto end_IL_0026;
			IL_083a:
			val = LoadDataViewGrid(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			end_IL_0026:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("END LoadDataView");
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LoadDataViewGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (MultiviewInternalGridConfig gridConfig in GridConfigList)
			{
				MultiviewInternalGridConfig objInternalGrid = gridConfig;
				if (!((GetControlByName((Control)(object)ActiveView, ((Control)objInternalGrid.GridView).ID) != null) | !((Page)this).IsPostBack))
				{
					continue;
				}
				if (Operators.CompareString(objInternalGrid.IdViewDataTable, "", false) != 0)
				{
					goto IL_00cb;
				}
				IboGridInfo robjGridInfo = null;
				val = base.SessionEnvironment.GridInfoList.Add(objInternalGrid.NomRif, ref robjGridInfo, ref rsMess);
				if ((int)val <= 0)
				{
					objInternalGrid.IdViewDataTable = base.SessionEnvironment.ObjManagerFactory.GetManager(robjGridInfo.ObjectManagerName).RedirectTo;
					goto IL_00cb;
				}
				val2 = val;
				goto end_IL_0005;
				IL_00cb:
				val = InternalGridSqlSet(ref objInternalGrid, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					BaseFunctions baseFunctions = base.BaseFunctions;
					IboInternalGridConfig ObjInternalGridConfig = objInternalGrid;
					if ((int)baseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
					{
						if (Operators.CompareString(((Control)objInternalGrid.GridView).ID, "", false) == 0)
						{
							continue;
						}
						ContextMenuControlTarget val3 = new ContextMenuControlTarget();
						val3.ControlID = ((Control)objInternalGrid.GridView).ID;
						if (Operators.CompareString(objInternalGrid.ToolbarId, "", false) != 0)
						{
							IboWebToolbar iboWebToolbar = (IboWebToolbar)(object)GetControlByName((Control)(object)this, objInternalGrid.ToolbarId);
							if (iboWebToolbar != null)
							{
								((StateManagedCollection)iboWebToolbar.ContextMenuTlk.Targets).Clear();
								iboWebToolbar.ContextMenuTlk.Targets.Add((ContextMenuTarget)(object)val3);
							}
						}
						continue;
					}
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

	protected virtual FXRETURN AfterLoadDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).IsPostBack)
			{
				goto IL_0039;
			}
			val = RestoreFormState(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_0039;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0039:
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

	protected virtual FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Invalid comparison between Unknown and I4
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Invalid comparison between Unknown and I4
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Invalid comparison between Unknown and I4
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Invalid comparison between Unknown and I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Invalid comparison between Unknown and I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string[] array = new string[1] { "" };
		int num = 0;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				int num2 = _MultiViewConfig.DataTable.Count() - 1;
				int num3 = 0;
				while (true)
				{
					if (num3 <= num2)
					{
						DataTable dataTable = _MultiViewConfig.DataTable[num3];
						DataTable dataTable2 = _MultiViewConfig.DataTableBeforeImage[num3];
						string[] array2 = _MultiViewConfig.Keys[num3];
						int num4 = dataTable.Rows.Count - 1;
						int num5 = 0;
						while (true)
						{
							if (num5 <= num4)
							{
								DataRow dataRow = dataTable.Rows[num5];
								DataRow dataRow2 = null;
								array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
								array[num] = "";
								unchecked
								{
									if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "I", false) == 0)
									{
										string text = "INSERT INTO " + _MultiViewConfig.Tabella[num3] + "(";
										foreach (DataColumn column in dataTable.Columns)
										{
											if ((Operators.CompareString(column.ColumnName.ToUpper(), "_ROWID", false) != 0) & (Operators.CompareString(column.ColumnName.ToUpper(), "_ROWSTATE", false) != 0) & (Operators.CompareString(column.ColumnName.ToUpper(), "DATINS", false) != 0) & (Operators.CompareString(column.ColumnName.ToUpper(), "DATAGG", false) != 0) & (Operators.CompareString(column.ColumnName.ToUpper(), "UTEINS", false) != 0) & (Operators.CompareString(column.ColumnName.ToUpper(), "UTEAGG", false) != 0))
											{
												text = text + column.ColumnName + ",";
											}
										}
										text += "DATAGG,DATINS,UTEAGG,UTEINS) VALUES (";
										foreach (DataColumn column2 in dataTable.Columns)
										{
											if (!((Operators.CompareString(column2.ColumnName.ToUpper(), "_ROWID", false) != 0) & (Operators.CompareString(column2.ColumnName.ToUpper(), "_ROWSTATE", false) != 0) & (Operators.CompareString(column2.ColumnName.ToUpper(), "DATINS", false) != 0) & (Operators.CompareString(column2.ColumnName.ToUpper(), "DATAGG", false) != 0) & (Operators.CompareString(column2.ColumnName.ToUpper(), "UTEINS", false) != 0) & (Operators.CompareString(column2.ColumnName.ToUpper(), "UTEAGG", false) != 0)))
											{
												continue;
											}
											if ((object)column2.DataType == typeof(byte[]))
											{
												text = (((int)base.DbConn.ServerTypeConnection != 1) ? (((int)base.DbConn.ServerTypeConnection != 0) ? (text + "CONVERT(VARBINARY(MAX), '0x" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column2.ColumnName]) + "',1),") : (text + "CONVERT(VARBINARY(MAX), '0x" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column2.ColumnName]) + "',1),")) : (text + "CONVERT(VARBINARY(MAX), '" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column2.ColumnName]) + "',1),"));
											}
											else if (((object)column2.DataType == typeof(string)) | ((object)column2.DataType == typeof(char)))
											{
												text = text + base.DbConn.SQLFormatString(dataRow[column2.ColumnName].ToString()) + ",";
											}
											else if (((object)column2.DataType == typeof(int)) | ((object)column2.DataType == typeof(double)) | ((object)column2.DataType == typeof(float)) | ((object)column2.DataType == typeof(decimal)) | ((object)column2.DataType == typeof(long)) | ((object)column2.DataType == typeof(short)) | ((object)column2.DataType == typeof(byte)))
											{
												if (Operators.CompareString(dataRow[column2.ColumnName].ToString(), "", false) == 0)
												{
													text += "NULL,";
													continue;
												}
												string text2 = text;
												DBConnection dbConn = base.DbConn;
												double num6 = Conversions.ToDouble(dataRow[column2.ColumnName]);
												text = text2 + dbConn.SQLFormatNumber(ref num6) + ",";
											}
											else
											{
												text = (((object)column2.DataType != typeof(DateTime)) ? (text + base.DbConn.SQLFormatString(dataRow[column2.ColumnName].ToString()) + ",") : ((Operators.CompareString(dataRow[column2.ColumnName].ToString(), "", false) != 0) ? (text + base.DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(dataRow[column2.ColumnName])) + ",") : (text + base.DbConn.SQLFormatDate((eTipoData)2, dataRow[column2.ColumnName].ToString()) + ",")));
											}
										}
										text = text + base.DbConn.GetDate() + ",";
										text = text + base.DbConn.GetDate() + ",";
										text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
										text = text + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ") ";
										array[num] = text;
									}
									else if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "M", false) == 0)
									{
										try
										{
											dataRow2 = dataTable2.Select("_ROWID='" + dataRow["_ROWID"].ToString() + "'")[0];
										}
										catch (Exception ex)
										{
											ProjectData.SetProjectError(ex);
											Exception ex2 = ex;
											rsMess = base.Translator.TranslateMessage("XXX", "Impossibile determinare la before image della riga da salvare", new string[0]);
											ProjectData.ClearProjectError();
											goto end_IL_0f78;
										}
										string text3 = "";
										foreach (DataColumn column3 in dataTable.Columns)
										{
											if (!((Operators.CompareString(column3.ColumnName, "_ROWID", false) != 0) & (Operators.CompareString(column3.ColumnName, "_ROWSTATE", false) != 0)))
											{
												continue;
											}
											if ((object)column3.DataType == typeof(byte[]))
											{
												text3 = (((int)base.DbConn.ServerTypeConnection != 1) ? (((int)base.DbConn.ServerTypeConnection != 0) ? (text3 + column3.ColumnName + "=CONVERT(VARBINARY(MAX), '0x" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column3.ColumnName]) + "',1),") : (text3 + column3.ColumnName + "=CONVERT(VARBINARY(MAX), '0x" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column3.ColumnName]) + "',1),")) : (text3 + column3.ColumnName + "=CONVERT(VARBINARY(MAX), '" + base.BaseFunctions.ByteArrayToString((byte[])dataRow[column3.ColumnName]) + "',1),"));
											}
											else
											{
												if (Operators.CompareString(dataRow[column3.ColumnName].ToString(), dataRow2[column3.ColumnName].ToString(), false) == 0)
												{
													continue;
												}
												if (((object)column3.DataType == typeof(string)) | ((object)column3.DataType == typeof(char)))
												{
													text3 = text3 + column3.ColumnName + "=" + base.DbConn.SQLFormatString(dataRow[column3.ColumnName].ToString()) + ",";
												}
												else if (((object)column3.DataType == typeof(int)) | ((object)column3.DataType == typeof(double)) | ((object)column3.DataType == typeof(float)) | ((object)column3.DataType == typeof(decimal)) | ((object)column3.DataType == typeof(long)) | ((object)column3.DataType == typeof(short)) | ((object)column3.DataType == typeof(byte)))
												{
													if ((Operators.CompareString(dataRow2[column3.ColumnName].ToString(), "", false) == 0) & (Operators.CompareString(dataRow[column3.ColumnName].ToString(), "", false) != 0))
													{
														string[] obj = new string[5] { text3, column3.ColumnName, "=", null, null };
														DBConnection dbConn2 = base.DbConn;
														double num6 = Conversions.ToDouble(dataRow[column3.ColumnName]);
														obj[3] = dbConn2.SQLFormatNumber(ref num6);
														obj[4] = ",";
														text3 = string.Concat(obj);
													}
													else if ((Operators.CompareString(dataRow2[column3.ColumnName].ToString(), "", false) != 0) & (Operators.CompareString(dataRow[column3.ColumnName].ToString(), "", false) == 0))
													{
														string[] obj2 = new string[5] { text3, column3.ColumnName, "=", null, null };
														DBConnection dbConn3 = base.DbConn;
														string text4 = dataRow[column3.ColumnName].ToString();
														obj2[3] = dbConn3.SQLFormatNumber(ref text4);
														obj2[4] = ",";
														text3 = string.Concat(obj2);
													}
													else if (Operators.CompareString(dataRow2[column3.ColumnName].ToString(), "", false) != 0 && Conversions.ToDouble(dataRow[column3.ColumnName].ToString()) != Conversions.ToDouble(dataRow2[column3.ColumnName].ToString()))
													{
														string[] obj3 = new string[5] { text3, column3.ColumnName, "=", null, null };
														DBConnection dbConn4 = base.DbConn;
														double num6 = Conversions.ToDouble(dataRow[column3.ColumnName]);
														obj3[3] = dbConn4.SQLFormatNumber(ref num6);
														obj3[4] = ",";
														text3 = string.Concat(obj3);
													}
												}
												else
												{
													text3 = (((object)column3.DataType != typeof(DateTime)) ? (text3 + column3.ColumnName + "=" + base.DbConn.SQLFormatString(dataRow[column3.ColumnName].ToString()) + ",") : ((Operators.CompareString(dataRow[column3.ColumnName].ToString(), "", false) != 0) ? (text3 + column3.ColumnName + "=" + base.DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(dataRow[column3.ColumnName])) + ",") : (text3 + column3.ColumnName + "=" + base.DbConn.SQLFormatDate((eTipoData)2, dataRow[column3.ColumnName].ToString()) + ",")));
												}
											}
										}
										if (Operators.CompareString(text3, "", false) != 0)
										{
											text3 = "UPDATE " + _MultiViewConfig.Tabella[num3] + " SET " + text3;
											text3 = text3 + "DATAGG=" + base.DbConn.GetDate() + ",";
											text3 = text3 + "UTEAGG=" + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
											text3 += "WHERE 1=1 ";
											string[] array3 = array2;
											foreach (string text5 in array3)
											{
												text3 = text3 + " AND " + text5 + "=" + base.DbConn.SQLFormatString(dataRow2[text5].ToString());
											}
											array[num] = text3;
										}
									}
									else if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "D", false) == 0)
									{
										string text6 = "DELETE FROM " + _MultiViewConfig.Tabella[num3] + " WHERE 1=1 ";
										string[] array4 = array2;
										foreach (string text7 in array4)
										{
											text6 = text6 + " AND " + text7 + "=" + base.DbConn.SQLFormatString(dataRow[text7].ToString());
										}
										array[num] = text6;
									}
								}
								num++;
								num5++;
								continue;
							}
							num3++;
							break;
						}
						continue;
					}
					string[] array5 = array;
					int num7 = 0;
					while (true)
					{
						if (num7 < array5.Length)
						{
							string text8 = array5[num7];
							unchecked
							{
								if (text8 != null && Operators.CompareString(text8, "", false) != 0)
								{
									val = base.DbConn.SqlExec(text8, ref rsMess);
									if ((int)val > 0)
									{
										val2 = val;
										break;
									}
									val = LogRisorseAzioneInserisci("", "", text8, "", ref rsMess);
									if ((int)val > 0)
									{
										val2 = val;
										break;
									}
								}
							}
							num7++;
							continue;
						}
						val2 = (FXRETURN)0;
						break;
					}
					break;
					continue;
					end_IL_0f78:
					break;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception objEx = ex3;
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
	}

	protected virtual FXRETURN SaveIsDefault(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataRow dataRow = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			dataRow = _MultiViewConfig.ActiveDataRow;
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val3 = iIboWebComponentControl;
				IboWebCheckBox val4 = (IboWebCheckBox)(object)((val3 is IboWebCheckBox) ? val3 : null);
				if (val4 == null)
				{
					continue;
				}
				string sWhere = "";
				if (Operators.CompareString(val4.FieldName, "", false) == 0)
				{
					continue;
				}
				IIboWebComponent obj = (IIboWebComponent)(object)val4;
				if (!IsDefault(ref obj, ref sWhere) || Operators.CompareString(val4.ValueIfChecked, val4.Value, false) != 0)
				{
					continue;
				}
				foreach (DataRow row in _MultiViewConfig.DataTable[_MultiViewConfig.ActiveView].Rows)
				{
					dataRow[val4.FieldName] = val4.ValueIfNotChecked;
				}
				dataRow[val4.FieldName] = val4.ValueIfChecked;
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

	protected virtual FXRETURN SavingProcess(bool bToDB, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((int)BeforeCheckData(ref rsMess) <= 0 && (int)CheckData(ref rsMess) <= 0 && (int)AfterCheckData(ref rsMess) <= 0)
			{
				val = BeforeSaveDataView(ref rsMess);
				if ((int)val <= 0)
				{
					val = SaveDataView(ref rsMess);
					if ((int)val <= 0)
					{
						val = AfterSaveDataView(ref rsMess);
						if ((int)val <= 0)
						{
							if (!bToDB)
							{
								goto IL_0114;
							}
							val = WFIBeginTransaction(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = BeforeSaveData(ref rsMess);
								if ((int)val <= 0)
								{
									val = SaveData(ref rsMess);
									if ((int)val <= 0)
									{
										val = AfterSaveData(ref rsMess);
										if ((int)val <= 0)
										{
											val = WFICommitTransaction(ref rsMess);
											if ((int)val <= 0)
											{
												goto IL_0114;
											}
											val2 = val;
										}
									}
								}
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_0114:
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

	protected virtual bool IsDBIdentity(ref IIboWebComponent obj)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Hashtable sRetColl = null;
		bool result = default(bool);
		try
		{
			if (Operators.CompareString(obj.IncasTag, "", false) != 0)
			{
				BaseFunctions baseFunctions = base.BaseFunctions;
				string sComando = obj.IncasTag.ToString();
				string rsMess = "";
				baseFunctions.StandardParser(sComando, ref sRetColl, ref rsMess);
				if (sRetColl.ContainsKey("IsIdentity"))
				{
					result = Operators.CompareString(sRetColl["IsIdentity"].ToString(), "S", false) == 0;
					return result;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected virtual bool IsDefault(ref IIboWebComponent obj, ref string sWhere)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		Hashtable sRetColl = null;
		bool flag = false;
		bool result;
		try
		{
			sWhere = "";
			if (Operators.CompareString(obj.IncasTag, "", false) != 0)
			{
				BaseFunctions baseFunctions = base.BaseFunctions;
				string sComando = obj.IncasTag.ToString();
				string rsMess = "";
				baseFunctions.StandardParser(sComando, ref sRetColl, ref rsMess);
				if (sRetColl.ContainsKey("IsDefault"))
				{
					string text = sRetColl["IsDefault"].ToString();
					flag = Operators.CompareString(text.ToUpper(), "S", false) == 0;
					if (sRetColl.ContainsKey("IsDefault_Where"))
					{
						sWhere = sRetColl["IsDefault_Where"].ToString();
						sWhere = sWhere.Replace("%eq%", "=");
						BaseFunctions baseFunctions2 = base.BaseFunctions;
						string sComando2 = sWhere;
						rsMess = "";
						Hashtable sRetColl2 = default(Hashtable);
						baseFunctions2.StandardVariableFinder(sComando2, ref sRetColl2, ref rsMess);
						IDictionaryEnumerator enumerator = sRetColl2.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object current = enumerator.Current;
							DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry));
							IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName((Control)(object)this, dictionaryEntry.Key.ToString());
							if (iIboWebComponentByFieldName != null)
							{
								sWhere = sWhere.Replace(dictionaryEntry.Value.ToString(), base.DbConn.SQLFormatString(iIboWebComponentByFieldName.ObjValue.ToString()));
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			flag = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = flag;
		}
		return result;
	}

	protected virtual bool IsWfiIdentity(ref IIboWebComponent obj)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Hashtable sRetColl = null;
		bool result = false;
		try
		{
			if (Operators.CompareString(obj.IncasTag, "", false) != 0)
			{
				BaseFunctions baseFunctions = base.BaseFunctions;
				string sComando = obj.IncasTag.ToString();
				string rsMess = "";
				baseFunctions.StandardParser(sComando, ref sRetColl, ref rsMess);
				if (sRetColl.ContainsKey("IdentityCounterName"))
				{
					result = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected virtual string GetIdentityCounterName(ref IIboWebComponent obj)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Hashtable sRetColl = null;
		string result = "";
		try
		{
			if (Operators.CompareString(obj.IncasTag, "", false) != 0)
			{
				BaseFunctions baseFunctions = base.BaseFunctions;
				string sComando = obj.IncasTag.ToString();
				string rsMess = "";
				baseFunctions.StandardParser(sComando, ref sRetColl, ref rsMess);
				if (sRetColl.ContainsKey("IdentityCounterName"))
				{
					result = sRetColl["IdentityCounterName"].ToString();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected virtual FXRETURN WFIBeginTransaction(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_MultiViewConfig.ActiveView == 0)
			{
				base.DbConn.BeginTransaction();
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

	protected virtual FXRETURN WFICommitTransaction(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_MultiViewConfig.ActiveView == 0)
			{
				base.DbConn.CommitTransaction();
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

	protected virtual FXRETURN WFIRollbackTransaction(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_MultiViewConfig.ActiveView == 0 && base.DbConn.TransactionOpen)
			{
				base.DbConn.RollbackTransaction();
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

	protected virtual FXRETURN BeforeSaveData(ref string rsMess)
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

	protected virtual FXRETURN AfterSaveData(ref string rsMess)
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

	protected virtual FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Invalid comparison between Unknown and I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			decimal dRet = default(decimal);
			int iRet = default(int);
			foreach (Control childControl in GetChildControls((Control)(object)ActiveView))
			{
				Control val3 = childControl;
				if (!(val3 is IIboWebComponent))
				{
					continue;
				}
				IIboWebComponent val4 = (IIboWebComponent)val3;
				text2 = val4.FieldDescription;
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = val4.FieldName;
				}
				if (!val4.Required)
				{
					goto IL_00eb;
				}
				text = val4.Text.Trim();
				if (Operators.CompareString(text, "", false) != 0)
				{
					goto IL_00eb;
				}
				rsMess = TranslateMessage("XXX", "E' obbligatorio specificare un valore per il campo '{0}'", text2);
				SetIncasFocusToControl((Control)val4);
				goto end_IL_0013;
				IL_0572:
				if (!(val3 is IboWebNumericTlk))
				{
					continue;
				}
				IboWebNumericTlk val5 = (IboWebNumericTlk)val3;
				double wFIMaxValue = val5.WFIMaxValue;
				double? value = ((RadNumericTextBox)val5).Value;
				if ((value.HasValue ? new bool?(wFIMaxValue < value.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore inferiore a {1}", text2, val5.WFIMaxValue.ToString());
					SetIncasFocusToControl(val3);
				}
				else
				{
					wFIMaxValue = val5.WFIMinValue;
					value = ((RadNumericTextBox)val5).Value;
					if (!(value.HasValue ? new bool?(wFIMaxValue > value.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						continue;
					}
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore superiore a {1}", text2, val5.WFIMinValue.ToString());
					SetIncasFocusToControl(val3);
				}
				goto end_IL_0013;
				IL_03fa:
				if (!(val3 is IboWebNumeric))
				{
					goto IL_0572;
				}
				IboWebNumeric iboWebNumeric = (IboWebNumeric)(object)val3;
				wFIMaxValue = iboWebNumeric.MaxValue;
				decimal? value2 = iboWebNumeric.Value;
				value = (value2.HasValue ? new double?(Convert.ToDouble(value2.GetValueOrDefault())) : null);
				if ((value.HasValue ? new bool?(wFIMaxValue < value.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore inferiore a {1}", text2, iboWebNumeric.MaxValue.ToString());
					SetIncasFocusToControl(val3);
				}
				else
				{
					wFIMaxValue = iboWebNumeric.MinValue;
					value2 = iboWebNumeric.Value;
					value = (value2.HasValue ? new double?(Convert.ToDouble(value2.GetValueOrDefault())) : null);
					if (!(value.HasValue ? new bool?(wFIMaxValue > value.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						goto IL_0572;
					}
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore superiore a {1}", text2, iboWebNumeric.MinValue.ToString());
					SetIncasFocusToControl(val3);
				}
				goto end_IL_0013;
				IL_035a:
				if (!(val3 is IboWebTextBox))
				{
					goto IL_03fa;
				}
				IboWebTextBox val6 = (IboWebTextBox)val3;
				if (!((val6.MinLength > 0) & (Operators.CompareString(val6.Text, "", false) != 0)) || val6.Text.Length >= val6.MinLength)
				{
					goto IL_03fa;
				}
				rsMess = TranslateMessage("XXX", "Il campo '{0}' deve essere lungo almeno {1} caratteri", text2, val6.MinLength.ToString());
				SetIncasFocusToControl(val3);
				goto end_IL_0013;
				IL_00eb:
				if (!(val3 is IboWebTextBox))
				{
					goto IL_035a;
				}
				if ((int)val4.ValidationRules == 1)
				{
					if (val4.Text.Trim().Length <= 0)
					{
						goto IL_035a;
					}
					val2 = base.BaseFunctions.IsValidEmail(val4.Text, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_035a;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. ", text2) + rsMess;
					SetIncasFocusToControl((Control)val4);
					val = val2;
				}
				else if ((int)val4.ValidationRules == 3)
				{
					if (val4.Text.Trim().Length <= 0)
					{
						goto IL_035a;
					}
					if (BaseFunctions.IsDecimal(val4.Text, ref dRet))
					{
						val4.Text = dRet.ToString();
						val4.Text = Strings.Replace(val4.Text, ",", ".", 1, -1, (CompareMethod)0);
						goto IL_035a;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere un numero decimale.", text2);
					SetIncasFocusToControl((Control)val4);
					val = val2;
				}
				else if ((int)val4.ValidationRules == 2)
				{
					if (val4.Text.Trim().Length <= 0)
					{
						goto IL_035a;
					}
					if (BaseFunctions.IsInteger(val4.Text, ref iRet))
					{
						val4.Text = iRet.ToString();
						val4.Text = Strings.Replace(val4.Text, ",", ".", 1, -1, (CompareMethod)0);
						goto IL_035a;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere un numero intero.", text2);
					SetIncasFocusToControl((Control)val4);
					val = val2;
				}
				else
				{
					if ((int)val4.ValidationRules != 4 || val4.Text.Trim().Length <= 0)
					{
						goto IL_035a;
					}
					Regex regex = new Regex("[a-zA-Z]+");
					if (regex.IsMatch(val4.Text.Trim()))
					{
						goto IL_035a;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere composto solo da caratteri alfabetici.", text2);
					SetIncasFocusToControl((Control)val4);
					val = val2;
				}
				goto end_IL_0013;
			}
			val = (FXRETURN)0;
			end_IL_0013:;
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

	protected virtual FXRETURN BeforeCheckData(ref string rsMess)
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
			val2 = AssegnaWfiIdentity(ref rsMess);
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

	protected virtual FXRETURN AssegnaWfiIdentity(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val3 = iIboWebComponentControl;
				IIboWebComponent obj = (IIboWebComponent)val3;
				if (!IsWfiIdentity(ref obj) || Operators.CompareString(obj.ObjValue.ToString(), "", false) != 0)
				{
					continue;
				}
				string identityCounterName = GetIdentityCounterName(ref obj);
				if (Operators.CompareString(identityCounterName, "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Il contatore per il campo {0} non è stato definito", obj.FieldName);
				}
				else
				{
					long num = 0L;
					val2 = base.Parametrica.LeggiContatore(identityCounterName, false, ref num, ref rsMess);
					if ((int)val2 <= 0)
					{
						obj.ObjValue = num;
						continue;
					}
					val = val2;
				}
				goto end_IL_0005;
			}
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN AfterCheckData(ref string rsMess)
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN BeforeSaveDataView(ref string rsMess)
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

	protected virtual FXRETURN SaveDataView(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Invalid comparison between Unknown and I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Invalid comparison between Unknown and I4
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		DataRow dataRow = null;
		string text3 = "U";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			dataRow = _MultiViewConfig.ActiveDataRow;
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)ActiveView))
			{
				Control val3 = iIboWebComponentControl;
				IIboWebComponent obj2 = (IIboWebComponent)val3;
				if (IsDBIdentity(ref obj2) || Operators.CompareString(obj2.FieldName, "", false) == 0)
				{
					continue;
				}
				text = obj2.FieldName;
				if (!modGeneral.ExistsFieldInDatarow(ref dataRow, text))
				{
					continue;
				}
				switch (_objFunctionArguments.Name)
				{
				case "INSERIMENTO":
				case "DUPLICAZIONE":
					dataRow["_ROWSTATE"] = "I";
					if (dataRow["_ROWID"] == null)
					{
						dataRow["_ROWID"] = Guid.NewGuid().ToString();
					}
					if (val3 is IboWebImage)
					{
						IboWebImage iboWebImage2 = (IboWebImage)(object)val3;
						if (Operators.CompareString(iboWebImage2.ImageUrl, iboWebImage2.OriginalImageUrl, false) != 0)
						{
							byte[] array2 = (byte[])iboWebImage2.ObjValue;
							if (array2 == null)
							{
								dataRow[text] = null;
							}
							else
							{
								dataRow[text] = array2;
							}
							if (Operators.CompareString(iboWebImage2.FieldNameExtension, "", false) != 0 && modGeneral.ExistsFieldInDatarow(ref dataRow, iboWebImage2.FieldNameExtension))
							{
								dataRow[iboWebImage2.FieldNameExtension] = iboWebImage2.FileExtension;
							}
						}
					}
					else if (dataRow.Table.Columns[text].DataType == typeof(DateTime))
					{
						if (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0)
						{
							dataRow[text] = DBNull.Value;
						}
						else
						{
							dataRow[text] = RuntimeHelpers.GetObjectValue(obj2.ObjValue);
						}
					}
					else if (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0)
					{
						dataRow[text] = DBNull.Value;
					}
					else
					{
						dataRow[text] = RuntimeHelpers.GetObjectValue(obj2.ObjValue);
					}
					break;
				case "MODIFICA":
					if (Operators.CompareString(dataRow["_ROWSTATE"].ToString(), "U", false) == 0)
					{
						dataRow["_ROWSTATE"] = "M";
					}
					if (val3 is IboWebImage)
					{
						IboWebImage iboWebImage = (IboWebImage)(object)val3;
						if (Operators.CompareString(iboWebImage.ImageUrl, iboWebImage.OriginalImageUrl, false) != 0)
						{
							byte[] array = (byte[])iboWebImage.ObjValue;
							if (array == null)
							{
								dataRow[text] = null;
							}
							else
							{
								dataRow[text] = array;
							}
							if (Operators.CompareString(iboWebImage.FieldNameExtension, "", false) != 0 && modGeneral.ExistsFieldInDatarow(ref dataRow, iboWebImage.FieldNameExtension))
							{
								dataRow[iboWebImage.FieldNameExtension] = iboWebImage.FileExtension;
							}
						}
					}
					else if (dataRow.Table.Columns[text].DataType == typeof(DateTime))
					{
						if (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0)
						{
							dataRow[text] = DBNull.Value;
						}
						else
						{
							dataRow[text] = RuntimeHelpers.GetObjectValue(obj2.ObjValue);
						}
					}
					else if (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0)
					{
						dataRow[text] = DBNull.Value;
					}
					else
					{
						dataRow[text] = RuntimeHelpers.GetObjectValue(obj2.ObjValue);
					}
					break;
				}
			}
			val = UpdateForeignKeyValues(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (!(((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) & (_MultiViewConfig.ActiveView != 0)))
				{
					goto IL_0752;
				}
				checked
				{
					int num = _objFunctionArguments.Keys.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls((Control)(object)ActiveView))
						{
							Control val4 = iIboWebComponentControl2;
							IIboWebComponent obj3 = (IIboWebComponent)val4;
							if (Operators.CompareString(obj3.FieldName.ToUpper(), _objFunctionArguments.Keys[i].FieldName.ToUpper(), false) == 0 && !IsDBIdentity(ref obj3) && obj3.IsKey)
							{
								if (Operators.CompareString(text2, "", false) != 0)
								{
									text2 += " AND ";
								}
								text2 = ((!(val4 is IboWebDate)) ? (text2 + obj3.FieldName + "=" + base.DbConn.SQLFormatString(obj3.Text)) : ((((IboWebDate)(object)val4).ControlType != IboWebDateType.TimeOnly) ? (text2 + obj3.FieldName + "=" + base.DbConn.SQLFormatDate((eTipoData)1, obj3.Text)) : (text2 + obj3.FieldName + "=" + base.DbConn.SQLFormatString(obj3.Text))));
							}
						}
					}
					if (Operators.CompareString(text2, "", false) == 0)
					{
						goto IL_0752;
					}
					DataTable activeDataTable = _MultiViewConfig.ActiveDataTable;
					if (activeDataTable == null || activeDataTable.Select(text2).Count() <= 0)
					{
						goto IL_0752;
					}
					rsMess = TranslateMessage("XXX", "Chiave duplicata. Il record che si sta cercando di inserire esiste già.");
				}
			}
			goto end_IL_001f;
			IL_0752:
			val = SaveIsDefault(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
				{
					_MultiViewConfig.DataTable[_MultiViewConfig.ActiveView].Rows.Add(dataRow);
					if (_MultiViewConfig.ActiveView == 0)
					{
						_objFunctionArguments.Name = "MODIFICA";
					}
				}
				val2 = (FXRETURN)0;
			}
			end_IL_001f:;
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

	protected virtual FXRETURN UpdateForeignKeyValues(ref string rsMess)
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

	protected virtual FXRETURN AfterSaveDataView(ref string rsMess)
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
			val = WFICommitTransaction(ref rsMess);
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

	protected virtual FXRETURN StandardFilterDropDownList(string sNomeControlloListBox, string sNomeControlloTesto, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			TextBox val3 = (TextBox)GetControlByName((Control)(object)this, sNomeControlloTesto);
			IboDropDownList objCombo = (IboDropDownList)GetControlByName((Control)(object)this, sNomeControlloListBox);
			if (((ListControl)objCombo).SelectedItem != null)
			{
				text = ((ListControl)objCombo).SelectedItem.Text;
				text2 = ((ListControl)objCombo).SelectedItem.Value;
			}
			if (Operators.CompareString(val3.Text, "", false) == 0)
			{
				objCombo.SqlQueryFilter = "";
				((WebControl)val3).ToolTip = base.Translator.TranslateMessage("XXX", "Nessun filtro impostato", new string[0]);
			}
			else
			{
				objCombo.SqlQueryFilter = " " + objCombo.CampoDescrizione + " LIKE '%" + val3.Text + "%' ";
				((WebControl)val3).ToolTip = base.Translator.TranslateMessage("XXX", "Filtro impostato: {0}", new string[1] { " " + objCombo.CampoDescrizione + " LIKE '%" + val3.Text + "%' " });
			}
			string rsMess2 = "";
			LoadSingleCombo(ref objCombo, ref rsMess2);
			if (Operators.CompareString(text, "", false) != 0)
			{
				if (!((ListControl)objCombo).Items.Contains(new ListItem(text, text2)))
				{
					((ListControl)objCombo).Items.Add(new ListItem(text, text2));
				}
				objCombo.Text = text2;
			}
			val3.Text = "";
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

	protected virtual void ApplicaFiltroAllaCombo(object sender, EventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IboWebUpdatePanelForDropDownList val = default(IboWebUpdatePanelForDropDownList);
			if (((Control)(Button)sender).Parent.Parent is IboWebUpdatePanelForDropDownList)
			{
				val = (IboWebUpdatePanelForDropDownList)((Control)(Button)sender).Parent.Parent;
			}
			else if (((Control)(Button)sender).Parent.Parent.Parent is IboWebUpdatePanelForDropDownList)
			{
				val = (IboWebUpdatePanelForDropDownList)((Control)(Button)sender).Parent.Parent.Parent;
			}
			if (val != null)
			{
				IboWebUpdatePanelForDropDownList val2 = val;
				string dropDownListId = val2.DropDownListId;
				string textBoxId = val2.TextBoxId;
				string rsMess = "";
				StandardFilterDropDownList(dropDownListId, textBoxId, ref rsMess);
				GetControlByName((Control)(object)val2, val2.DropDownListId).Focus();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual FXRETURN RestoreFormState(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_objFormState != null)
			{
				foreach (KeyValuePair<string, Dictionary<string, object>> item in _objFormState)
				{
					object objInstance = GetControlByName((Control)(object)this, item.Key);
					foreach (KeyValuePair<string, object> item2 in item.Value)
					{
						base.BaseFunctions.SetPropertyValue(ref objInstance, item2.Key, RuntimeHelpers.GetObjectValue(item2.Value));
					}
				}
				_objFormState = null;
				_SessionVariable["FormState"] = (object)null;
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

	protected virtual void SetFormState(string PageName, string objectInstanceName, string PropertyName, ref object PropertyValue)
	{
		IboDictionaryCollection<string, object> iboDictionaryCollection = base.SessionEnvironment.SessionVariables[PageName];
		if (iboDictionaryCollection == null)
		{
			iboDictionaryCollection = new IboDictionaryCollection<string, object>();
		}
		base.SessionEnvironment.SessionVariables.Add(PageName, iboDictionaryCollection);
		Dictionary<string, Dictionary<string, object>> dictionary = default(Dictionary<string, Dictionary<string, object>>);
		if (iboDictionaryCollection != null && iboDictionaryCollection["FormState"] != null)
		{
			dictionary = (Dictionary<string, Dictionary<string, object>>)iboDictionaryCollection["FormState"];
		}
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, Dictionary<string, object>>();
		}
		Dictionary<string, object> dictionary2 = ((!dictionary.ContainsKey(objectInstanceName)) ? new Dictionary<string, object>() : dictionary[objectInstanceName]);
		dictionary2.Remove(PropertyName);
		dictionary2.Add(PropertyName, RuntimeHelpers.GetObjectValue(PropertyValue));
		if (!dictionary.ContainsKey(objectInstanceName))
		{
			dictionary.Add(objectInstanceName, dictionary2);
		}
		if (iboDictionaryCollection != null && iboDictionaryCollection["FormState"] == null)
		{
			iboDictionaryCollection.Add("FormState", dictionary);
		}
	}

	protected virtual void btnAnnulla_Click(object sender, EventArgs e)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (_MultiViewConfig.ActiveView == 0)
		{
			ReturnToCaller();
			return;
		}
		if (_MultiViewConfig.ActiveView == _MultiViewConfig.ParentView[_MultiViewConfig.ActiveView])
		{
			_MultiViewConfig.ActiveView = 0;
		}
		else
		{
			_MultiViewConfig.ActiveView = _MultiViewConfig.ParentView[_MultiViewConfig.ActiveView];
			_MultiViewConfig.ActiveDataRow = _MultiViewConfig.ActiveDataRowArray[_MultiViewConfig.ActiveView];
			((Page)this).Session["FunctionArgs"] = _MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView];
			if (Operators.CompareString(_MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].Name, "INSERIMENTO", false) == 0)
			{
				_MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].Name = "MODIFICA";
			}
		}
		string rsMess = "";
		LoadPage(ref rsMess);
	}

	protected virtual void btnConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = SavingProcess(_MultiViewConfig.ActiveView == 0, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (_MultiViewConfig.ActiveView == 0)
			{
				ReturnToCaller();
			}
			else
			{
				_MultiViewConfig.ActiveView = _MultiViewConfig.ParentView[_MultiViewConfig.ActiveView];
				_MultiViewConfig.ActiveDataRow = _MultiViewConfig.ActiveDataRowArray[_MultiViewConfig.ActiveView];
				((Page)this).Session["FunctionArgs"] = _MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView];
				if (Operators.CompareString(_MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].Name, "INSERIMENTO", false) == 0)
				{
					_MultiViewConfig.objFunctionArguments[_MultiViewConfig.ActiveView].Name = "MODIFICA";
				}
				val2 = LoadPage(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
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
			if ((int)val > 0)
			{
				string rsMess2 = "";
				val2 = WFIRollbackTransaction(ref rsMess2);
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	protected virtual void Page_Load(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = LoadPage(ref rsMess);
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
			if ((int)val > 0)
			{
				ErroreCaricamento(bWithReturnToCaller: true, rsMess);
			}
			CallStackRemove();
		}
	}

	private void Page_PreInit(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = PreInitPage(ref rsMess);
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
			if ((int)val > 0)
			{
				ErroreCaricamento(bWithReturnToCaller: true, rsMess);
			}
			CallStackRemove();
		}
	}

	protected virtual FXRETURN LogRisorseAzioneInserisci([Optional][DefaultParameterValue("")] string sAzione, [Optional][DefaultParameterValue("")] string sModulo, [Optional][DefaultParameterValue("")] string sInfo1, [Optional][DefaultParameterValue("")] string sInfo2, [Optional][DefaultParameterValue("")] ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		LogRisorseAzioni logRisorseAzioni = new LogRisorseAzioni();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(sAzione, "", false) == 0)
			{
				sAzione = _objFunctionArguments.Name.ToUpper();
			}
			if (Operators.CompareString(sModulo, "", false) == 0)
			{
				sModulo = "UI";
			}
			val = logRisorseAzioni.Inserisci(this, sAzione, sModulo, sInfo1, sInfo2, ref rsMess);
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

	protected virtual FXRETURN RememberCaller(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Page)this).IsPostBack)
			{
				string text = "";
				string text2 = "";
				try
				{
					text = _objFunctionArguments.CallerPath;
					if (_objFunctionArguments.CallerQueryString.Length > 0)
					{
						text2 = "?" + _objFunctionArguments.CallerQueryString;
					}
					if (Operators.CompareString(_objFunctionArguments.QueryStringToAddWhenReturning, "", false) != 0 && Strings.InStr(text2, _objFunctionArguments.QueryStringToAddWhenReturning, (CompareMethod)0) <= 0)
					{
						text2 = ((Operators.CompareString(text2, "", false) == 0) ? (text2 + "?" + _objFunctionArguments.QueryStringToAddWhenReturning) : (text2 + "&" + _objFunctionArguments.QueryStringToAddWhenReturning));
					}
					text += text2;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					text = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
					ProjectData.ClearProjectError();
				}
				_SessionVariable.Add("CallerPage", text);
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	protected override void ReturnToCaller()
	{
		string text = "";
		try
		{
			text = _SessionVariable["CallerPage"].ToString();
			if (_SessionVariable != null)
			{
				base.SessionEnvironment.SessionVariables.Remove(EntryPoint);
			}
			IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
			IboResponseRedirect(ref robjCallStackHandler, ref text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
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
		MultiviewInternalGridConfig objInternalGridConfig = null;
		try
		{
			CallStackAdd();
			IboWebToolbar tlb = (IboWebToolbar)sender;
			foreach (MultiviewInternalGridConfig gridConfig in GridConfigList)
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

	private FXRETURN _AnyToolbarClick(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
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
				val = SavingProcess(bToDB: false, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					MultiviewInternalGridConfig multiviewInternalGridConfig;
					IboGridView grdGriglia = (multiviewInternalGridConfig = objInternalGridConfig).GridView;
					MultiviewInternalGridConfig multiviewInternalGridConfig2;
					IboGridInfo objGridInfo = (multiviewInternalGridConfig2 = objInternalGridConfig).GridInfo;
					DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
					FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
					multiviewInternalGridConfig2.GridInfo = objGridInfo;
					multiviewInternalGridConfig.GridView = grdGriglia;
					val = keyDataFromGrid;
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						FunctionArguments funcArg = new FunctionArguments(robjData);
						funcArg.Keys = robjKey;
						val = AnyToolbarClick(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
					}
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

	protected virtual FXRETURN AnyToolbarClick(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Invalid comparison between Unknown and I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Invalid comparison between Unknown and I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Invalid comparison between Unknown and I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between Unknown and I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Invalid comparison between Unknown and I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Invalid comparison between Unknown and I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Invalid comparison between Unknown and I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_04ce;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(e.CommandName, IboWebToolbar.Ricerca, false) == 0)
				{
					goto IL_04ce;
				}
				if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaFiltri, false) == 0)
				{
					val = InternalGridAnnullaFiltri(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_04ce;
					}
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(e.CommandName, IboWebToolbar.AnnullaPrefiltri, false) == 0)
					{
						goto IL_04ce;
					}
					if (Operators.CompareString(e.CommandName, IboWebToolbar.Visualizza, false) == 0)
					{
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
								val = InternalGridAfterVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04ce;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Inserisci, false) == 0)
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
						{
							val = (FXRETURN)0;
							goto IL_04ce;
						}
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
								val = InternalGridAfterInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04ce;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Modifica, false) == 0)
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
						{
							val = (FXRETURN)0;
							goto IL_04ce;
						}
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
								val = InternalGridAfterModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04ce;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Cancella, false) == 0)
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
						{
							val = (FXRETURN)0;
							goto IL_04ce;
						}
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
								val = InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04ce;
								}
								val2 = val;
							}
						}
					}
					else if (Operators.CompareString(e.CommandName, IboWebToolbar.Duplica, false) == 0)
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
						{
							val = (FXRETURN)0;
							goto IL_04ce;
						}
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
								val = InternalGridAfterDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
								if ((int)val <= 0)
								{
									goto IL_04ce;
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
							goto IL_04ce;
						}
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(e.CommandName, IboWebToolbar.StampaVeloce, false) == 0 || Operators.CompareString(e.CommandName, IboWebToolbar.EsportazioneDati, false) == 0)
						{
							goto IL_04ce;
						}
						if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
						{
							val = (FXRETURN)0;
							goto IL_04ce;
						}
						val = InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
						if ((int)val <= 0)
						{
							goto IL_04ce;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0005;
			IL_04ce:
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected virtual FXRETURN InternalGridSqlSet(ref MultiviewInternalGridConfig objInternalGrid, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected I4, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			objInternalGrid.SqlStatement = objInternalGrid.SqlOriginalStatement;
			Hashtable sRetColl = null;
			val = base.BaseFunctions.StandardVariableFinder(objInternalGrid.SqlOriginalStatement, ref sRetColl, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				objInternalGrid.SqlStatementVariables = sRetColl;
				int num = 0;
				IDictionaryEnumerator enumerator = sRetColl.GetEnumerator();
				checked
				{
					while (true)
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
							else
							{
								text2 = "MASTER_RECORD";
								text = dictionaryEntry.Key.ToString().ToUpper();
							}
							switch (text2)
							{
							case "MASTER_RECORD":
								if (_MultiViewConfig.DataTable[_MultiViewConfig.get_GetIndexViewByID(objInternalGrid.IdView)].Equals(_MultiViewConfig.ActiveDataRow.Table))
								{
									if (_MultiViewConfig.DataTable[_MultiViewConfig.get_GetIndexViewByID(objInternalGrid.IdView)].Rows.Count > 0)
									{
										DataRow activeDataRow;
										try
										{
											activeDataRow = _MultiViewConfig.ActiveDataRow;
										}
										catch (Exception ex)
										{
											ProjectData.SetProjectError(ex);
											Exception ex2 = ex;
											rsMess = TranslateMessage("XXX", "Before image della MASTER VIEW non caricato correttamente. Impossibile proseguire.");
											ProjectData.ClearProjectError();
											goto end_IL_0579;
										}
										try
										{
											if (activeDataRow.Table.Columns[text].DataType == typeof(string))
											{
												objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), activeDataRow[text].ToString());
											}
											else if (Operators.CompareString(activeDataRow[text].ToString(), "", false) != 0)
											{
												objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), activeDataRow[text].ToString());
											}
											else
											{
												objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), "-1");
											}
										}
										catch (Exception ex3)
										{
											ProjectData.SetProjectError(ex3);
											Exception ex4 = ex3;
											rsMess = TranslateMessage("XXX", "Il campo {0} non è presente nella MASTER VIEW", text);
											ProjectData.ClearProjectError();
											goto end_IL_0579;
										}
									}
									else
									{
										objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), "");
									}
								}
								else
								{
									num++;
								}
								break;
							case "CONTROLS_RECORD":
							{
								Control controlByName = GetControlByName((Control)(object)this, text);
								if (controlByName != null && controlByName is IIboWebComponent)
								{
									objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), ((IIboWebComponent)controlByName).ObjValue.ToString());
								}
								break;
							}
							case "GRID_RECORD":
							{
								string text3 = text.ToString().Split(new char[1] { '.' })[0];
								string text4 = text.ToString().Split(new char[1] { '.' })[1];
								MultiviewInternalGridConfig multiviewInternalGridConfig = GridConfigList[text3];
								string newValue = "";
								if (multiviewInternalGridConfig == null)
								{
									rsMess = TranslateMessage("XXX", "{0} non esiste nella lista delle griglie configurate.", text3);
									val2 = (FXRETURN)5;
									goto end_IL_0579;
								}
								if (multiviewInternalGridConfig.GridView.GetSelectedIndices().Length > 0)
								{
									newValue = multiviewInternalGridConfig.DataTable.Rows[multiviewInternalGridConfig.GridView.GetSelectedIndices()[0]][text4].ToString();
								}
								else
								{
									num++;
									eTipoDati val3 = modGeneral.DataTypeToBaseType(multiviewInternalGridConfig.DataTable.Columns[text4].DataType);
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
											newValue = "0";
											break;
										case 0:
											newValue = "";
											break;
										case 3:
										case 4:
											break;
										}
									}
								}
								objInternalGrid.SqlStatement = objInternalGrid.SqlStatement.Replace(dictionaryEntry.Value.ToString(), newValue);
								break;
							}
							}
							continue;
						}
						if (num > 0)
						{
							objInternalGrid.SqlStatement = "'A' = 'B'";
						}
						int num2 = _MultiViewConfig.get_GetIndexViewByID(objInternalGrid.IdViewDataTable);
						DataTable dataTable = null;
						dataTable = _MultiViewConfig.DataTable[num2].Clone();
						string sort = "";
						if (Operators.CompareString(objInternalGrid.OrderByField, "", false) != 0)
						{
							sort = objInternalGrid.OrderByField + " " + objInternalGrid.OrderByDirection;
						}
						DataRow[] array = _MultiViewConfig.DataTable[num2].Select(objInternalGrid.SqlStatement + " AND _ROWSTATE <> 'D'", sort);
						DataRow[] array2 = array;
						foreach (DataRow row in array2)
						{
							dataTable.ImportRow(row);
						}
						objInternalGrid.DataTable = dataTable;
						val2 = (FXRETURN)0;
						break;
						continue;
						end_IL_0579:
						break;
					}
				}
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
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

	protected virtual FXRETURN InternalGridAggiornaSingola(ref MultiviewInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = InternalGridSqlSet(ref objInternalGridConfig, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InternalGridAggiornaTutte(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (MultiviewInternalGridConfig gridConfig in GridConfigList)
			{
				MultiviewInternalGridConfig objInternalGrid = gridConfig;
				val = InternalGridSqlSet(ref objInternalGrid, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = _InternalGridAggiorna(ref objInternalGrid, ref rsMess);
					if ((int)val <= 0)
					{
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

	protected virtual FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected FXRETURN _InternalGridAggiorna(ref MultiviewInternalGridConfig objInternalGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			BaseFunctions baseFunctions = base.BaseFunctions;
			IboInternalGridConfig ObjInternalGridConfig = objInternalGridConfig;
			if ((int)baseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
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

	protected virtual FXRETURN InternalGridAnnullaFiltri(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
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
				funcArg.QueryStringToAddWhenReturning = "Returning=S";
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Visualizza(ref funcArg, ref rsMess) <= 0)
				{
					_MultiViewConfig.ParentView[_MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString())] = _MultiViewConfig.ActiveView;
					_MultiViewConfig.ActiveView = _MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString());
					string filterExpression = " 1=1 " + funcArg.Data.GetFirstElementSqlWhere();
					DataRow[] array = _MultiViewConfig.DataTable[_MultiViewConfig.ActiveView].Select(filterExpression);
					if (array.Count() == 0)
					{
						rsMess = base.Translator.TranslateMessage("XXX", "Nessun record trovato", new string[0]);
					}
					else
					{
						_MultiViewConfig.ActiveDataRow = array[0];
						val2 = LoadPage(ref rsMess);
						val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN InternalGridBeforeVisualizza(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridAfterVisualizza(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridInserisciDelegate(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_00cc;
			}
			IboWebToolbar tlb = (IboWebToolbar)(object)GetControlByName((Control)(object)this, _SessionVariable["Delegate_ToolbarId"].ToString());
			MultiviewInternalGridConfig objInternalGridConfig = (MultiviewInternalGridConfig)_SessionVariable["Delegate_InternalGridConfig"];
			FunctionArguments funcArg = (FunctionArguments)_SessionVariable["Delegate_FunctionArguments"];
			IboWebToolbarEventArgs e = null;
			val2 = InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_00cc;
			}
			val = val2;
			goto end_IL_0005;
			IL_00cc:
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

	protected virtual FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataRow activeDataRow = _MultiViewConfig.ActiveDataRow;
			funcArg.QueryStringToAddWhenReturning = "Returning=S";
			if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Inserisci(ref funcArg, ref rsMess) <= 0)
			{
				_MultiViewConfig.ParentView[_MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString())] = _MultiViewConfig.ActiveView;
				_MultiViewConfig.ActiveView = _MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString());
				DataRow activeDataRow2 = _MultiViewConfig.DataTable[_MultiViewConfig.ActiveView].NewRow();
				_MultiViewConfig.ActiveDataRow = activeDataRow2;
				val2 = LoadPage(ref rsMess);
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

	protected virtual FXRETURN InternalGridBeforeInserisci(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridAfterInserisci(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
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
				funcArg.QueryStringToAddWhenReturning = "Returning=S";
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Modifica(ref funcArg, ref rsMess) <= 0)
				{
					_MultiViewConfig.ParentView[_MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString())] = _MultiViewConfig.ActiveView;
					_MultiViewConfig.ActiveView = _MultiViewConfig.get_GetIndexViewByID(funcArg.Argomento1.ToString());
					string filterExpression = " 1=1 " + funcArg.Data.GetFirstElementSqlWhere();
					DataRow[] array = _MultiViewConfig.DataTable[_MultiViewConfig.ActiveView].Select(filterExpression);
					if (array.Count() == 0)
					{
						rsMess = base.Translator.TranslateMessage("XXX", "Nessun record trovato", new string[0]);
					}
					else
					{
						_MultiViewConfig.ActiveDataRow = array[0];
						val2 = LoadPage(ref rsMess);
						val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN InternalGridBeforeModifica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridAfterModifica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
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
				int num = _MultiViewConfig.get_GetIndexViewByID(objInternalGridConfig.IdViewDataTable);
				string filterExpression = " 1=1 " + funcArg.Data.GetFirstElementSqlWhere();
				DataRow[] array = _MultiViewConfig.DataTable[num].Select(filterExpression);
				if (array.Count() == 0)
				{
					rsMess = base.Translator.TranslateMessage("XXX", "Nessun record trovato", new string[0]);
				}
				else
				{
					if (Operators.CompareString(array[0]["_ROWSTATE"].ToString(), "I", false) == 0)
					{
						array[0].Delete();
					}
					else
					{
						array[0]["_ROWSTATE"] = "D";
					}
					_MultiViewConfig.ActiveView = _MultiViewConfig.ActiveView;
					val2 = LoadPage(ref rsMess);
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN InternalGridBeforeCancella(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
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
				funcArg.QueryStringToAddWhenReturning = "Returning=S";
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(objInternalGridConfig.GridInfo.ObjectManagerName).Duplica(ref funcArg, ref rsMess) <= 0)
				{
					val = (FXRETURN)0;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN InternalGridBeforeDuplica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridAfterDuplica(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridStampa(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
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

	protected virtual FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref MultiviewInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			objInternalGridConfig.DataTable = null;
			BaseFunctions baseFunctions = base.BaseFunctions;
			IboInternalGridConfig ObjInternalGridConfig = objInternalGridConfig;
			if ((int)baseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
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

	protected virtual void grd_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		try
		{
			GridView val2 = (GridView)sender;
			MultiviewInternalGridConfig multiviewInternalGridConfig = GridConfigList[((Control)val2).ID];
			dataTable = multiviewInternalGridConfig.DataTable.Clone();
			if (Operators.CompareString(multiviewInternalGridConfig.OrderByDirection, "ASC", false) == 0)
			{
				multiviewInternalGridConfig.OrderByDirection = "DESC";
			}
			else
			{
				multiviewInternalGridConfig.OrderByDirection = "ASC";
			}
			string sort = "";
			if (Operators.CompareString(multiviewInternalGridConfig.OrderByField, "", false) != 0)
			{
				sort = multiviewInternalGridConfig.OrderByField + " " + multiviewInternalGridConfig.OrderByDirection;
			}
			DataRow[] array = multiviewInternalGridConfig.DataTable.Select(multiviewInternalGridConfig.SqlStatement, sort);
			DataRow[] array2 = array;
			foreach (DataRow row in array2)
			{
				dataTable.ImportRow(row);
			}
			multiviewInternalGridConfig.DataTable = dataTable;
			val2.PageIndex = 0;
			BaseFunctions baseFunctions = base.BaseFunctions;
			IboInternalGridConfig ObjInternalGridConfig = multiviewInternalGridConfig;
			if ((int)baseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
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

	protected virtual void grd_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			GridView val2 = (GridView)sender;
			MultiviewInternalGridConfig multiviewInternalGridConfig = GridConfigList[((Control)val2).ID];
			val2.PageIndex = e.NewPageIndex;
			BaseFunctions baseFunctions = base.BaseFunctions;
			IboInternalGridConfig ObjInternalGridConfig = multiviewInternalGridConfig;
			if ((int)baseFunctions.LoadGrid(ref ObjInternalGridConfig, ref rsMess) <= 0)
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

	private void grd_PreRender(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			IboGridView val2 = (IboGridView)sender;
			MultiviewInternalGridConfig multiviewInternalGridConfig = GridConfigList[((Control)val2).ID];
			if (multiviewInternalGridConfig.GridInfo.AllGrdStylesetTable != null && multiviewInternalGridConfig.GridInfo.AllGrdStylesetTable.Rows.Count > 0)
			{
				foreach (GridViewRow row in ((GridView)val2).Rows)
				{
					GridViewRow val3 = row;
					string text2 = ((DataRowView)val3.DataItem)["Styleset"].ToString();
					if (Operators.CompareString(text2, "", false) != 0)
					{
						TableItemStyle val4 = (TableItemStyle)multiviewInternalGridConfig.GridConfig.AllgrdStylesets[text2];
						((WebControl)val3).BackColor = ((Style)val4).BackColor;
						((WebControl)val3).ForeColor = ((Style)val4).ForeColor;
						((WebControl)val3).Font.Bold = ((Style)val4).Font.Bold;
						((WebControl)val3).Font.Italic = ((Style)val4).Font.Italic;
						((WebControl)val3).Font.Name = ((Style)val4).Font.Name;
						((WebControl)val3).Font.Underline = ((Style)val4).Font.Underline;
						((WebControl)val3).Font.Size = ((Style)val4).Font.Size;
						val3.RowState = (DataControlRowState)0;
					}
				}
			}
			foreach (GridViewRow row2 in ((GridView)val2).Rows)
			{
				GridViewRow val5 = row2;
				int num = 0;
				if (Operators.CompareString(multiviewInternalGridConfig.GridInfo.AllGrd["CANSEL"].ToString(), "N", false) != 0)
				{
					num = 1;
				}
				foreach (DataControlField item in (StateManagedCollection)((GridView)val2).Columns)
				{
					DataControlField val6 = item;
					BoundField val7 = (BoundField)(object)((val6 is BoundField) ? val6 : null);
					if (val7 == null)
					{
						continue;
					}
					foreach (DataRow item2 in multiviewInternalGridConfig.GridInfo.TabGrd)
					{
						if (Operators.CompareString(item2["NOMCAM"].ToString().ToUpper(), val7.DataField.ToUpper(), false) != 0)
						{
							continue;
						}
						if (Operators.CompareString(item2["VISIBILE"].ToString(), "S", false) != 0 || Operators.CompareString(item2["NOMCAMTOOLTIP"].ToString(), "", false) == 0)
						{
							break;
						}
						try
						{
							string text3 = item2["NOMCAMTOOLTIP"].ToString();
							string text4 = Strings.Trim(((DataTable)((BaseDataBoundControl)val2).DataSource).Rows[val5.DataItemIndex][text3].ToString());
							if (Operators.CompareString(text4, "", false) != 0 && !((TableRow)val5).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
							{
								((WebControl)((TableRow)val5).Cells[num]).ToolTip = ((TableRow)val5).Cells[num].Text;
								((TableRow)val5).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
								((TableRow)val5).Cells[num].Text = Strings.Replace(((TableRow)val5).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val5).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
								((TableRow)val5).Cells[num].Text = Strings.Replace(((TableRow)val5).Cells[num].Text, "<%TITLE%>", text4, 1, -1, (CompareMethod)0);
								((TableRow)val5).Cells[num].Text = Strings.Replace(((TableRow)val5).Cells[num].Text, "<%CSSSTYLE%>", text3, 1, -1, (CompareMethod)0);
								((WebControl)((TableRow)val5).Cells[num]).ToolTip = "";
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						break;
					}
					num = checked(num + 1);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			text = ex4.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val <= 0)
			{
			}
		}
	}

	protected virtual void grd_RowDataBound(object sender, GridViewRowEventArgs e)
	{
	}
}
