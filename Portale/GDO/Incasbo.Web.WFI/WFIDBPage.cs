using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIDBPage : WFIPage, IIncasTableLink
{
	protected class ComboQueryCacheItem
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _SqlQueryResult;

		public string SqlQuery { get; set; }

		public object SqlQueryResult
		{
			[CompilerGenerated]
			get
			{
				return _SqlQueryResult;
			}
			[CompilerGenerated]
			set
			{
				_SqlQueryResult = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public int ID { get; set; }

		public StringCollection ComboId { get; set; }

		public bool LazyLoad { get; set; }

		public ComboQueryCacheItem()
		{
			SqlQuery = "";
			ComboId = new StringCollection();
			LazyLoad = false;
		}

		public ComboQueryCacheItem(string _sqlQuery)
		{
			SqlQuery = "";
			ComboId = new StringCollection();
			LazyLoad = false;
			SqlQuery = _sqlQuery;
		}

		public ComboQueryCacheItem(string _sqlQuery, object _sqlQueryResult)
		{
			SqlQuery = "";
			ComboId = new StringCollection();
			LazyLoad = false;
			SqlQuery = _sqlQuery;
			SqlQueryResult = RuntimeHelpers.GetObjectValue(_sqlQueryResult);
		}
	}

	protected class ComboQueryCache : KeyedCollection<string, ComboQueryCacheItem>
	{
		protected int IdCount;

		public DateTime LastUsage { get; set; }

		public ComboQueryCache()
		{
			IdCount = 0;
			LastUsage = DateTime.Now;
		}

		protected override void ClearItems()
		{
			using (IEnumerator<ComboQueryCacheItem> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ComboQueryCacheItem current = enumerator.Current;
					if (current.SqlQueryResult != null)
					{
						try
						{
							((IDisposable)current.SqlQueryResult).Dispose();
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
			base.ClearItems();
		}

		protected override void InsertItem(int index, ComboQueryCacheItem item)
		{
			checked
			{
				IdCount++;
				item.ID = IdCount;
				base.InsertItem(index, item);
			}
		}

		public ComboQueryCacheItem Item(string Key)
		{
			LastUsage = DateTime.Now;
			return base[Key];
		}

		protected override string GetKeyForItem(ComboQueryCacheItem item)
		{
			return item.SqlQuery;
		}

		public ComboQueryCacheItem GetItemByIdCombo(string IDCombo)
		{
			ComboQueryCacheItem result = null;
			using (IEnumerator<ComboQueryCacheItem> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ComboQueryCacheItem current = enumerator.Current;
					if (current.ComboId.Contains(IDCombo))
					{
						result = current;
						break;
					}
				}
			}
			return result;
		}

		public void RemoveIdCombo(string IDCombo)
		{
			using IEnumerator<ComboQueryCacheItem> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				ComboQueryCacheItem current = enumerator.Current;
				if (current.ComboId.Contains(IDCombo))
				{
					current.ComboId.Remove(IDCombo);
				}
			}
		}

		public void Clean()
		{
			StringCollection stringCollection = new StringCollection();
			using (IEnumerator<ComboQueryCacheItem> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ComboQueryCacheItem current = enumerator.Current;
					if (current.ComboId.Count == 0)
					{
						stringCollection.Add(current.SqlQuery);
					}
				}
			}
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string current2 = enumerator2.Current;
				try
				{
					((IDisposable)Item(current2).SqlQueryResult).Dispose();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Remove(current2);
			}
		}

		public ComboQueryCacheItem GetItemById(int Id)
		{
			ComboQueryCacheItem result = null;
			using (IEnumerator<ComboQueryCacheItem> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ComboQueryCacheItem current = enumerator.Current;
					if (current.ID == Id)
					{
						result = current;
						break;
					}
				}
			}
			return result;
		}
	}

	protected FunctionArguments _objFunctionArguments;

	protected Dictionary<string, Dictionary<string, object>> _objFormState;

	protected string _Context;

	protected string _Tabella;

	protected string _TabellaLoad;

	protected string _TabellaSave;

	protected string _Title;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConferma")]
	private IboWebButton _btnConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAnnulla")]
	private IboWebButton _btnAnnulla;

	protected bool _LoadControlsInitialValues;

	protected bool _LoadControlsInitialValuesInSession;

	protected bool _DisableMenu;

	protected bool _ReturnToCallerAfterConfirm;

	protected string _AutoCodeKeyField;

	protected ComboQueryCache _ComboQueryCache;

	protected ComboQueryCache _ComboQueryCacheTop50;

	protected StringCollection _SQLQueryToApply;

	protected WFIDupInfoCollection _DupInfo;

	protected int _ComboLoadMode;

	protected string _WarningMessageNotification;

	protected string _WarningBlockedMessage;

	protected string _AreYouSureBlockedMessage;

	protected string _AreYouSureBlockedMessageTitle;

	protected WFIUserMessage.TipoMessageBox _AreYouSureBlockedMessageType;

	protected bool _AutoReleaseMemoryOnCancel;

	protected bool _AutoReleaseMemoryOnConfirm;

	protected bool _RaiseIFrameCloseOnDiscard;

	protected bool _MasterRecordSaved;

	protected IIboWebComponent _DBIdentityControl;

	[field: AccessedThroughProperty("lblDataAccessMode")]
	protected virtual IboWebLabel lblDataAccessMode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnConferma_Click;
			IboWebButton val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnConferma = value;
			val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAnnulla_Click;
			IboWebButton val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAnnulla = value;
			val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	public bool TransactionManage { get; set; }

	// In VB queste proprieta' protette implementavano IIncasTableLink: in C# serve l'implementazione esplicita
	string Incasbo.Web.Components.IIncasTableLink.TableName { get => TableName; set => TableName = value; }

	string Incasbo.Web.Components.IIncasTableLink.TableNameLoad { get => TableNameLoad; set => TableNameLoad = value; }

	string Incasbo.Web.Components.IIncasTableLink.TableNameSave { get => TableNameSave; set => TableNameSave = value; }

	protected string TableName
	{
		get
		{
			return _Tabella;
		}
		set
		{
			_Tabella = value;
		}
	}

	protected string TableNameLoad
	{
		get
		{
			if (Operators.CompareString(_TabellaLoad, "", false) == 0)
			{
				return _Tabella;
			}
			return _TabellaLoad;
		}
		set
		{
			_TabellaLoad = value;
		}
	}

	protected string TableNameSave
	{
		get
		{
			if (Operators.CompareString(_TabellaSave, "", false) == 0)
			{
				return _Tabella;
			}
			return _TabellaSave;
		}
		set
		{
			_TabellaSave = value;
		}
	}

	protected BeforeImageFieldsCollection BeforeImage
	{
		get
		{
			return get_BeforeImage((IIncasTableLink)(object)this);
		}
		set
		{
			set_BeforeImage((IIncasTableLink)(object)this, value);
		}
	}

// Proprieta' VB con parametro, convertita in metodi
	protected BeforeImageFieldsCollection get_BeforeImage(Incasbo.Web.Components.IIncasTableLink objDetailPanel)
	{
		return _SessionVariable["BeforeImage." + objDetailPanel.TableName] as BeforeImageFieldsCollection;
	}

	protected void set_BeforeImage(Incasbo.Web.Components.IIncasTableLink objDetailPanel, BeforeImageFieldsCollection value)
	{
		_SessionVariable["BeforeImage." + objDetailPanel.TableName] = (object)value;
	}


// Proprieta' VB con parametro, convertita in metodi
	protected DataTable get_TableData(Incasbo.Web.Components.IIncasTableLink objDetailPanel)
	{
		return _SessionVariable["TableData." + objDetailPanel.TableName] as DataTable;
	}

	protected void set_TableData(Incasbo.Web.Components.IIncasTableLink objDetailPanel, DataTable value)
	{
		_SessionVariable["TableData." + objDetailPanel.TableName] = (object)value;
	}


	protected DataTable TableData
	{
		get
		{
			return get_TableData((IIncasTableLink)(object)this);
		}
		set
		{
			set_TableData((IIncasTableLink)(object)this, value);
		}
	}

	public override string ResourceName => "SYSTEM." + base.SessionEnvironment.WebApplicationName.ToUpper() + ".FORMS." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0)) + "." + _objFunctionArguments.Name.ToUpper();

	public WFIDBPage()
	{
		((Control)this).Load += Page_Load;
		((Control)this).PreRender += Page_PreRender1;
		((Control)this).Unload += Page_Unload1;
		_objFunctionArguments = null;
		_objFormState = null;
		_Context = "NO_CONTEXT";
		_Tabella = "NO_TABLE";
		_TabellaLoad = "";
		_TabellaSave = "";
		_Title = "";
		_LoadControlsInitialValues = false;
		_LoadControlsInitialValuesInSession = false;
		_DisableMenu = true;
		_ReturnToCallerAfterConfirm = true;
		_AutoCodeKeyField = "";
		_SQLQueryToApply = new StringCollection();
		_DupInfo = new WFIDupInfoCollection();
		_ComboLoadMode = 1;
		_WarningMessageNotification = "";
		_WarningBlockedMessage = "";
		_AreYouSureBlockedMessage = "";
		_AreYouSureBlockedMessageTitle = "";
		_AreYouSureBlockedMessageType = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
		_AutoReleaseMemoryOnCancel = true;
		_AutoReleaseMemoryOnConfirm = true;
		_RaiseIFrameCloseOnDiscard = false;
		_MasterRecordSaved = false;
		TransactionManage = true;
	}

	protected virtual FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Invalid comparison between Unknown and I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Invalid comparison between Unknown and I4
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between Unknown and I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Invalid comparison between Unknown and I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Invalid comparison between Unknown and I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Invalid comparison between Unknown and I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Invalid comparison between Unknown and I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboResourceManager iboResourceManager = new IboResourceManager();
		PerformanceLog val3 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("DBPage BeforeLoadPage");
			val = BeforeLoadPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage ContextGet");
				val = ContextGet(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("DBPage InitializedPage");
					val = InitializedPage(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						PerformanceLogAppend("DBPage ContextCheck");
						val = ContextCheck(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							PerformanceLogAppend("DBPage LoadInterfaceFeatures");
							val = LoadInterfaceFeatures(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (lblDataAccessMode != null)
								{
									lblDataAccessMode.Text = TranslateMessage("XXX", _objFunctionArguments.Name);
								}
								if (Operators.CompareString(_Title, "", false) != 0)
								{
									Control controlByName = GetControlByName((Control)(object)this, "lblTitle");
									Label val4 = (Label)(object)((controlByName is Label) ? controlByName : null);
									if (val4 != null)
									{
										val4.Text = _Title;
									}
									((Page)this).Title = _Title;
								}
								try
								{
									Control controlByName2 = GetControlByName((Control)(object)this, "imgModalita");
									Image val5 = (Image)(object)((controlByName2 is Image) ? controlByName2 : null);
									if (val5 != null)
									{
										if (File.Exists(base.SessionEnvironment.WebApplicationRoot + "\\images\\Toolbar\\ModalitaForm\\" + _objFunctionArguments.Name + ".png"))
										{
											val5.ImageUrl = "~/images/Toolbar/ModalitaForm/" + _objFunctionArguments.Name + ".png";
											((Control)val5).Visible = true;
										}
										else
										{
											((Control)val5).Visible = false;
										}
										((WebControl)val5).ToolTip = "Modalità: " + _objFunctionArguments.Name;
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
								if (((Control)this).Page.IsPostBack)
								{
									goto IL_0371;
								}
								val = iboResourceManager.Resource_Check(this, ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									if (_ComboLoadMode != 0)
									{
										goto IL_028a;
									}
									PerformanceLogAppend("DBPage LoadCombo");
									val = LoadCombo(ref rsMess);
									if ((int)val <= 0)
									{
										goto IL_028a;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_028a:
			PerformanceLogAppend("DBPage BeforeLoadData");
			val = BeforeLoadData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage LoadData");
				val = LoadData(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("DBPage AfterLoadData");
					val = AfterLoadData(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (_ComboLoadMode != 1)
						{
							goto IL_0327;
						}
						val = LoadCombo(ref rsMess);
						if ((int)val <= 0)
						{
							goto IL_0327;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_000e;
			IL_0327:
			if (_ComboLoadMode != 0)
			{
				goto IL_035e;
			}
			PerformanceLogAppend("DBPage ReloadCombo");
			val = ReloadCombo(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_035e;
			}
			val2 = val;
			goto end_IL_000e;
			IL_043b:
			val2 = (FXRETURN)0;
			goto end_IL_000e;
			IL_035e:
			string rsMess2 = "";
			SetFocusOnFirstControl((Control)(object)this, ref rsMess2);
			goto IL_0371;
			IL_0371:
			PerformanceLogAppend("DBPage LoadDataSourceComboLoadOnDemand");
			val = LoadDataSourceComboLoadOnDemand(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage LoadEventsForComboUpdatePanel");
				val = LoadEventsForComboUpdatePanel(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (_DisableMenu)
					{
						((RadDataBoundControl)base.MasterPage.MasterMenuItemTlk).Enabled = false;
					}
					PerformanceLogAppend("DBPage AfterLoadPage");
					val = AfterLoadPage(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) != 0)
						{
							goto IL_043b;
						}
						val = ConfermaClick(ref rsMess);
						if ((int)val <= 0)
						{
							goto IL_043b;
						}
						val2 = val;
					}
				}
			}
			end_IL_000e:;
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
			PerformanceLogAppend("DBPage End LoadPage");
			if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0 && (int)val2 == 0)
			{
				ReturnToCaller();
			}
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN UnloadPage(ref string rsMess)
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

	protected virtual FXRETURN PreRenderPage(ref string rsMess)
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
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], _Context.ToUpper(), false) != 0 && Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], Strings.Split(_Context.ToUpper(), "#", -1, (CompareMethod)0)[0], false) != 0)
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (btnConferma == null)
			{
				btnConferma = (IboWebButton)GetControlByName((Control)(object)this, "btnConferma");
			}
			if (btnAnnulla == null)
			{
				btnAnnulla = (IboWebButton)GetControlByName((Control)(object)this, "btnAnnulla");
			}
			if (lblDataAccessMode == null)
			{
				lblDataAccessMode = (IboWebLabel)GetControlByName((Control)(object)this, "lblDataAccessMode");
			}
			Panel val3 = (Panel)GetControlByName((Control)(object)this, "pnlMain");
			if (val3 != null && btnConferma != null && Operators.CompareString(val3.DefaultButton, "", false) == 0)
			{
				val3.DefaultButton = ((Control)btnConferma).ID;
			}
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
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		Hashtable hashtable = new Hashtable();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Page)this).IsPostBack)
			{
				if (_LoadControlsInitialValues | _LoadControlsInitialValuesInSession)
				{
					foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
					{
						Control val3 = allIIboWebComponentControl;
						IIboWebComponent val4 = (IIboWebComponent)val3;
						if (_LoadControlsInitialValues)
						{
							val4.InitialValue = RuntimeHelpers.GetObjectValue(val4.ObjValue);
						}
						if (_LoadControlsInitialValuesInSession)
						{
							InitialControl initialControl = new InitialControl();
							initialControl.Id = val3.ID;
							initialControl.ObjValue = RuntimeHelpers.GetObjectValue(val4.ObjValue);
							initialControl.Enabled = val4.Enabled;
							initialControl.ReadOnly = val4.ReadOnly;
							initialControl.Visible = val4.Visible;
							try
							{
								hashtable.Add(val3.ID, initialControl);
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
				_SessionVariable.Remove("InitialValues");
				_SessionVariable.Add("InitialValues", hashtable);
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

	protected virtual FXRETURN ContextGet(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).Request.QueryString["Returning"] != null && Operators.CompareString(((Page)this).Request.QueryString["Returning"].ToUpper(), "S", false) == 0)
			{
				_objFunctionArguments = (FunctionArguments)_SessionVariable["FunctionArgs"];
				goto IL_0152;
			}
			if (((Page)this).Session["FunctionArgs"] != null)
			{
				_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				if (!_objFunctionArguments.Target.ToUpper().Contains(EntryPoint.ToUpper()) && _SessionVariable["FunctionArgs"] != null)
				{
					_objFunctionArguments = (FunctionArguments)_SessionVariable["FunctionArgs"];
				}
				_SessionVariable.Remove("FunctionArgs");
				_SessionVariable.Add("FunctionArgs", _objFunctionArguments);
				goto IL_0152;
			}
			rsMess = TranslateMessage("XXX", "Errore nella lettura dei dati di funzione. Chiamata non consentita.");
			goto end_IL_0005;
			IL_0152:
			_objFormState = (Dictionary<string, Dictionary<string, object>>)_SessionVariable["FormState"];
			try
			{
				if (_objFunctionArguments.ObjectManager != null)
				{
					_Context = _objFunctionArguments.ObjectManager.ObjectManagerName;
					_Tabella = _objFunctionArguments.ObjectManager.ObjectTableName;
					if (_Tabella.Contains(";"))
					{
						string[] array = _Tabella.Split(new char[1] { ';' });
						_TabellaLoad = array[0];
						_TabellaSave = array[1];
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (!((Page)this).IsPostBack)
			{
				_ComboQueryCache = new ComboQueryCache();
				_SessionVariable.Add("ComboQueryCache", _ComboQueryCache);
				_ComboQueryCacheTop50 = new ComboQueryCache();
				_SessionVariable.Add("ComboQueryCacheTop50", _ComboQueryCacheTop50);
			}
			else
			{
				_ComboQueryCache = (ComboQueryCache)_SessionVariable["ComboQueryCache"];
				_ComboQueryCacheTop50 = (ComboQueryCache)_SessionVariable["ComboQueryCacheTop50"];
			}
			val2 = (FXRETURN)0;
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

	protected virtual FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Page)this).IsPostBack)
			{
				_SessionVariable["_AreYouSureBlockedMessageState"] = (object)"0";
			}
			bool flag = false;
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO_O_MODIFICA", false) != 0)
			{
				goto IL_0160;
			}
			flag = true;
			if (Operators.CompareString(TableNameLoad, "", false) == 0)
			{
				goto IL_0160;
			}
			string text = "";
			if (_objFunctionArguments.Data == null)
			{
				goto IL_0160;
			}
			text = ((!TableNameLoad.StartsWith("SELECT ")) ? ("SELECT COUNT(*) FROM " + TableNameLoad + " WHERE 1=1 ") : ("SELECT COUNT(*) FROM (" + TableNameLoad + ") T WHERE 1=1 "));
			text += _objFunctionArguments.Data.GetFirstElementSqlWhere();
			object obj = null;
			val = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val <= 0)
			{
				if (Conversions.ToInteger(obj) == 0)
				{
					_objFunctionArguments.Name = "INSERIMENTO";
				}
				else
				{
					_objFunctionArguments.Name = "MODIFICA";
				}
				goto IL_0160;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0160:
			if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO_O_MODIFICA", false) == 0)
			{
				_objFunctionArguments.Name = "INSERIMENTO";
			}
			checked
			{
				if (flag & (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0))
				{
					int num = _objFunctionArguments.Data.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						GetIIboWebComponentByFieldName((Control)(object)this, _objFunctionArguments.Data.Item(i).FieldName).ObjValue = RuntimeHelpers.GetObjectValue(_objFunctionArguments.Data.Item(i).get_FieldValues(0));
					}
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

	protected virtual FXRETURN LoadCombo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between Unknown and I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_ComboLoadMode == 0)
			{
				PerformanceLogAppend("DBPage LoadCombo -1");
				foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
				{
					Control val3 = allIIboWebComponentControl;
					IIboDropdownList objCombo = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
					if (objCombo == null)
					{
						continue;
					}
					PerformanceLogAppend("DBPage LoadCombo -2 " + objCombo.Id);
					int sqlQueryTop = objCombo.SqlQueryTop;
					objCombo.SqlQueryTop = 0;
					val = LoadSingleCombo(ref objCombo, ref rsMess);
					if ((int)val <= 0)
					{
						objCombo.SqlQueryTop = sqlQueryTop;
						PerformanceLogAppend("DBPage LoadCombo -3 " + objCombo.Id);
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
				goto IL_014b;
			}
			val = LoadCombo_Prefetch(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = LoadCombo_LoadData(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = LoadCombo_DataBind(ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_014b;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_014b:
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

	protected virtual FXRETURN LoadCombo_Prefetch(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("DBPage Begin LoadCombo_Prefetch");
			foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
			{
				Control val3 = allIIboWebComponentControl;
				IIboDropdownList objCombo = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
				if (objCombo == null)
				{
					continue;
				}
				val = LoadSingleCombo_Prefetch(ref objCombo, ref rsMess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			PerformanceLogAppend("DBPage End LoadCombo_Prefetch");
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

	protected virtual FXRETURN LoadCombo_LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("DBPage Begin LoadCombo_LoadData ");
			DataSet dataSet = null;
			foreach (ComboQueryCacheItem item in _ComboQueryCache)
			{
				if (!item.LazyLoad)
				{
					text = text + item.SqlQuery + ";";
				}
			}
			foreach (ComboQueryCacheItem item2 in _ComboQueryCacheTop50)
			{
				text = text + item2.SqlQuery + ";";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_0104;
			}
			val = base.DbConn.OpenDataSet(text, ref dataSet, ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_0104;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0104:
			int num = 0;
			checked
			{
				int num2 = _ComboQueryCache.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (_ComboQueryCache.GetItemById(i + 1).LazyLoad)
					{
						continue;
					}
					_ComboQueryCache.GetItemById(i + 1).SqlQueryResult = dataSet.Tables[num];
					num++;
					if (dataSet.Tables[num].Rows.Count <= 0 || Operators.CompareString(dataSet.Tables[num].Rows[0][0].ToString(), "", false) == 0)
					{
						continue;
					}
					DataRow dataRow = dataSet.Tables[num].NewRow();
					int num3 = dataRow.ItemArray.Count() - 1;
					for (int j = 0; j <= num3; j++)
					{
						if ((object)dataRow.Table.Columns[j].DataType == typeof(string))
						{
							dataRow[j] = "";
						}
					}
					dataSet.Tables[num].Rows.InsertAt(dataRow, 0);
				}
				int num4 = 0;
				int num5 = num;
				int num6 = _ComboQueryCacheTop50.Count + num - 1;
				for (int k = num5; k <= num6; k++)
				{
					_ComboQueryCacheTop50.GetItemById(num4 + 1).SqlQueryResult = dataSet.Tables[k];
					num4++;
				}
				PerformanceLogAppend("DBPage End LoadCombo_LoadData ");
				val2 = (FXRETURN)0;
			}
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

	protected virtual FXRETURN LoadCombo_DataBind(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("DBPage Begin LoadCombo_DataBind ");
			foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
			{
				Control val3 = allIIboWebComponentControl;
				IIboDropdownList objCombo = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
				if (objCombo == null)
				{
					continue;
				}
				if (objCombo.AutoLoadOnDemand)
				{
					val = LoadSingleCombo_DataBind(ref objCombo, _ComboQueryCacheTop50, ref rsMess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
				}
				else
				{
					val = LoadSingleCombo_DataBind(ref objCombo, _ComboQueryCache, ref rsMess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
				}
				goto end_IL_000b;
			}
			PerformanceLogAppend("DBPage End LoadCombo_DataBind ");
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
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).IsCallback | ((Page)this).IsPostBack)
			{
				foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
				{
					Control val3 = allIIboWebComponentControl;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					IIboDropdownList val5 = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
					if (val5 == null || !(val5.LoadOnDemand | val5.AutoLoadOnDemand))
					{
						continue;
					}
					try
					{
						ComboQueryCacheItem itemByIdCombo = _ComboQueryCache.GetItemByIdCombo(val5.Id);
						if (itemByIdCombo.SqlQueryResult != null || !((Page)this).IsCallback)
						{
							goto IL_01b5;
						}
						DataTable dataTable = null;
						val = base.DbConn.OpenDataTable(itemByIdCombo.SqlQuery, ref dataTable, ref rsMess);
						if ((int)val <= 0)
						{
							checked
							{
								if (dataTable.Rows.Count > 0 && Operators.CompareString(dataTable.Rows[0][0].ToString(), "", false) != 0)
								{
									DataRow dataRow = dataTable.NewRow();
									int num = dataRow.ItemArray.Count() - 1;
									for (int i = 0; i <= num; i++)
									{
										if ((object)dataRow.Table.Columns[i].DataType == typeof(string))
										{
											dataRow[i] = "";
										}
									}
									dataTable.Rows.InsertAt(dataRow, 0);
								}
								itemByIdCombo.SqlQueryResult = dataTable;
								goto IL_01b5;
							}
						}
						val2 = val;
						goto end_IL_000b;
						IL_01b5:
						val5.DataSource = RuntimeHelpers.GetObjectValue(itemByIdCombo.SqlQueryResult);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
			val2 = (FXRETURN)0;
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ReloadCombo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (Control allIIboWebComponentControl in GetAllIIboWebComponentControls((Control)(object)this))
			{
				Control val3 = allIIboWebComponentControl;
				IIboDropdownList objCombo = (IIboDropdownList)(object)((val3 is IIboDropdownList) ? val3 : null);
				if (objCombo == null)
				{
					continue;
				}
				if (!((objCombo.SqlQueryTop > 0) & !objCombo.AutoLoadOnDemand))
				{
					if ((objCombo.AutoLoadOnDemand | objCombo.LoadOnDemand) && ((objCombo.AutoLoadOnDemand & (((DataTable)objCombo.DataSource).Rows.Count > 100)) | objCombo.LoadOnDemand))
					{
						ComboQueryCacheItem itemByIdCombo = _ComboQueryCacheTop50.GetItemByIdCombo(val3.ID);
						if (itemByIdCombo != null)
						{
							objCombo.DataSource = RuntimeHelpers.GetObjectValue(itemByIdCombo.SqlQueryResult);
							objCombo.DataBind();
						}
					}
					continue;
				}
				val = LoadSingleCombo(ref objCombo, ref rsMess);
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN ComboSelectedItem(IIboDropdownList objCombo, string sItemValue, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((int)objCombo.DropDownListType != 1)
			{
				ComboQueryCacheItem itemByIdCombo = _ComboQueryCache.GetItemByIdCombo(objCombo.Id);
				if (itemByIdCombo != null)
				{
					objCombo.DataSource = RuntimeHelpers.GetObjectValue(itemByIdCombo.SqlQueryResult);
					objCombo.DataBind();
					objCombo.ObjValue = sItemValue;
				}
				goto IL_019a;
			}
			IboWebComboTlk val3 = (IboWebComboTlk)(object)((objCombo is IboWebComboTlk) ? objCombo : null);
			if (val3 != null)
			{
				((RadComboBox)val3).EnableAutomaticLoadOnDemand = false;
				((RadComboBox)val3).EnableLoadOnDemand = false;
				val3.Text = "";
				val3.UIRenderFlag = false;
			}
			ComboQueryCacheItem itemByIdCombo2 = _ComboQueryCache.GetItemByIdCombo(val3.ID);
			if (itemByIdCombo2 == null)
			{
				goto IL_00ea;
			}
			if (itemByIdCombo2.SqlQueryResult != null)
			{
				goto IL_00d9;
			}
			DataTable sqlQueryResult = null;
			val = base.DbConn.OpenDataTable(itemByIdCombo2.SqlQuery, ref sqlQueryResult, ref rsMess);
			if ((int)val <= 0)
			{
				itemByIdCombo2.SqlQueryResult = sqlQueryResult;
				objCombo.DataSource = RuntimeHelpers.GetObjectValue(itemByIdCombo2.SqlQueryResult);
				goto IL_00d9;
			}
			val2 = val;
			goto end_IL_0005;
			IL_019a:
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_00ea:
			itemByIdCombo2 = null;
			itemByIdCombo2 = _ComboQueryCacheTop50.GetItemByIdCombo(val3.ID);
			if (itemByIdCombo2 != null)
			{
				objCombo.DataSource = RuntimeHelpers.GetObjectValue(itemByIdCombo2.SqlQueryResult);
				objCombo.DataBind();
			}
			objCombo.HtmlDecodedSpaces();
			if (!objCombo.ItemExist(""))
			{
				objCombo.ItemInsert(0, "");
			}
			goto IL_019a;
			IL_00d9:
			objCombo.DataBind();
			objCombo.ObjValue = sItemValue;
			goto IL_00ea;
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((int)objCombo.DropDownListType == 1)
			{
				IboWebComboTlk val3 = (IboWebComboTlk)(object)((objCombo is IboWebComboTlk) ? objCombo : null);
				if (val3 != null)
				{
					val3.UIRenderFlag = false;
				}
			}
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

	protected virtual FXRETURN ComboSetQueryAndFilter(IIboDropdownList objCombo, string sQuery, string sFilter, string sItemValue, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((int)objCombo.DropDownListType == 1)
			{
				IboWebComboTlk val3 = (IboWebComboTlk)(object)((objCombo is IboWebComboTlk) ? objCombo : null);
				if (val3 != null)
				{
					val3.UIRenderFlag = false;
				}
			}
			objCombo.SqlQuery = sQuery;
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

	protected virtual FXRETURN LoadEventsForComboUpdatePanel(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
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
			if (Conversions.ToBoolean(base.SessionEnvironment.PersistentSessionVariables[PageName + ".HasComboUpdatePanel"]))
			{
				bool flag = false;
				foreach (Control childControl in GetChildControls((Control)(object)this))
				{
					Control val6 = childControl;
					if (val6 is IboWebUpdatePanelForDropDownList)
					{
						flag = true;
						val3 = (IboWebUpdatePanelForDropDownList)val6;
						val4 = (Button)GetControlByName((Control)(object)val3, val3.ButtonId);
						val4.Click += ApplicaFiltroAllaCombo;
						val5 = (TextBox)GetControlByName((Control)(object)val3, val3.TextBoxId);
					}
				}
				base.SessionEnvironment.PersistentSessionVariables[PageName + ".HasComboUpdatePanel"] = flag;
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objCombo.SqlQuery, "", false) == 0 || (int)LoadDropDownList(ref objCombo, UseCache: true, ref rsMess, vbBlankItem: true) <= 0)
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

	protected virtual FXRETURN LoadSingleCombo_Prefetch(ref IIboDropdownList objCombo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Invalid comparison between Unknown and I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Invalid comparison between Unknown and I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objCombo.SqlQuery, "", false) != 0)
			{
				string sqlQuery = objCombo.SqlQuery;
				string campoCodice = objCombo.CampoCodice;
				string sqlQueryOrderBy = objCombo.SqlQueryOrderBy;
				string campoDescrizione = objCombo.CampoDescrizione;
				objCombo.DataTextField = campoDescrizione;
				objCombo.DataValueField = campoCodice;
				text3 = "SELECT * FROM (" + sqlQuery + ") T WHERE 1=1 ";
				if (Operators.CompareString(objCombo.SqlQueryFilter, "", false) != 0)
				{
					text3 = text3 + "AND (" + objCombo.SqlQueryFilter + ") ";
				}
				if (Operators.CompareString(objCombo.SqlQueryWhere, "", false) != 0)
				{
					text3 = text3 + "AND (" + objCombo.SqlQueryWhere + ") ";
				}
				text4 = "";
				if (Operators.CompareString(sqlQueryOrderBy, "", false) != 0)
				{
					text4 = "ORDER BY " + sqlQueryOrderBy + " ";
				}
				if ((int)base.DbConn.ServerTypeConnection == 0)
				{
					text = "SELECT TOP 100 PERCENT * FROM (" + text3 + ") T1 " + text4;
					text2 = "SELECT TOP <%TOP%> * FROM (" + text3 + ") T1 " + text4;
				}
				else if ((int)base.DbConn.ServerTypeConnection == 3)
				{
					text = "SELECT * FROM (SELECT * FROM (" + text3 + ") T1 " + text4 + ") TT";
					text2 = "SELECT * FROM (SELECT * FROM (" + text3 + ") T1 " + text4 + " LIMIT <%TOP%>) TT1";
				}
				else
				{
					text3 = text3 + " " + text4;
					text = "SELECT * FROM (" + text3 + ") T1 ";
					text2 = "SELECT * FROM (" + text3 + ") T1 WHERE ROWNUM<=<%TOP%> ";
				}
				if (objCombo.ObjValue != null && Operators.CompareString(objCombo.ObjValue.ToString(), "", false) != 0)
				{
					if ((int)base.DbConn.ServerTypeConnection == 0)
					{
						text4 = " UNION SELECT TOP 1 * FROM (SELECT * FROM (" + sqlQuery + ") T2 WHERE " + campoCodice + "=" + base.DbConn.SQLFormatString(objCombo.ObjValue.ToString());
						if (Operators.CompareString(objCombo.SqlQueryWhere, "", false) != 0)
						{
							text4 = text4 + " AND (" + objCombo.SqlQueryWhere + ")";
						}
						text4 += ") T ";
					}
					else if ((int)base.DbConn.ServerTypeConnection == 1)
					{
						text4 = " UNION SELECT * FROM (SELECT * FROM (" + sqlQuery + ") T2 WHERE " + campoCodice + "=" + base.DbConn.SQLFormatString(objCombo.ObjValue.ToString());
						if (Operators.CompareString(objCombo.SqlQueryWhere, "", false) != 0)
						{
							text4 = text4 + " AND (" + objCombo.SqlQueryWhere + ")";
						}
						text4 += ") T WHERE ROWNUM<=1 ";
					}
					else if ((int)base.DbConn.ServerTypeConnection == 3)
					{
						text4 = " UNION SELECT * FROM (SELECT * FROM (SELECT * FROM (" + sqlQuery + ") T2 WHERE " + campoCodice + "=" + base.DbConn.SQLFormatString(objCombo.ObjValue.ToString());
						if (Operators.CompareString(objCombo.SqlQueryWhere, "", false) != 0)
						{
							text4 = text4 + " AND (" + objCombo.SqlQueryWhere + ")";
						}
						text4 += ") T LIMIT 1) TT2";
					}
					else
					{
						text4 = " UNION SELECT TOP 1 * FROM (SELECT * FROM (" + sqlQuery + ") T2 WHERE " + campoCodice + "=" + base.DbConn.SQLFormatString(objCombo.ObjValue.ToString());
						if (Operators.CompareString(objCombo.SqlQueryWhere, "", false) != 0)
						{
							text4 = text4 + " AND (" + objCombo.SqlQueryWhere + ")";
						}
						text4 += ") T ";
					}
					text += text4;
					text2 += text4;
				}
				text = "SELECT * FROM (" + text + ") T3";
				text2 = "SELECT * FROM (" + text2 + ") T3";
				if (Operators.CompareString(sqlQueryOrderBy, "", false) != 0)
				{
					text4 = " ORDER BY " + sqlQueryOrderBy + " ";
					text += text4;
					text2 += text4;
				}
				text2 = text2.Replace("<%TOP%>", objCombo.SqlQueryTop.ToString());
				_ComboQueryCache.RemoveIdCombo(objCombo.Id);
				ComboQueryCacheItem comboQueryCacheItem;
				if (!_ComboQueryCache.Contains(text))
				{
					comboQueryCacheItem = new ComboQueryCacheItem(text);
					if (objCombo.AutoLoadOnDemand)
					{
						comboQueryCacheItem.LazyLoad = true;
					}
					_ComboQueryCache.Add(comboQueryCacheItem);
				}
				else
				{
					comboQueryCacheItem = _ComboQueryCache.Item(text);
				}
				comboQueryCacheItem.ComboId.Add(objCombo.Id);
				_ComboQueryCacheTop50.RemoveIdCombo(objCombo.Id);
				ComboQueryCacheItem comboQueryCacheItem2;
				if (!_ComboQueryCacheTop50.Contains(text2))
				{
					comboQueryCacheItem2 = new ComboQueryCacheItem(text2);
					_ComboQueryCacheTop50.Add(comboQueryCacheItem2);
				}
				else
				{
					comboQueryCacheItem2 = _ComboQueryCacheTop50.Item(text2);
				}
				comboQueryCacheItem2.ComboId.Add(objCombo.Id);
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

	protected virtual FXRETURN LoadSingleCombo_DataBind(ref IIboDropdownList objCombo, ComboQueryCache Cache, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			IIboDropdownList val3 = objCombo;
			if (val3 != null)
			{
				string objValue = "";
				if (val3.ObjValue != null && Operators.CompareString(val3.ObjValue.ToString(), "", false) != 0)
				{
					objValue = val3.ObjValue.ToString();
				}
				ComboQueryCacheItem itemByIdCombo = Cache.GetItemByIdCombo(val3.Id);
				if (itemByIdCombo != null)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(itemByIdCombo.SqlQueryResult);
					val3.ItemClear();
					val3.DataSource = RuntimeHelpers.GetObjectValue(objectValue);
					try
					{
						val3.DataBind();
						val3.ObjValue = objValue;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					val3.HtmlDecodedSpaces();
					if (!val3.ItemExist(""))
					{
						val3.ItemInsert(0, "");
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

	protected virtual FXRETURN LoadDropDownList(string vsSelect, string vsTextFieldAlias, string vsValueFieldAlias, string vsFilter, string vsOrderByField, ref IIboDropdownList robjDropDownList, bool UseCache, ref string rsMess, bool vbBlankItem)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Invalid comparison between Unknown and I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Invalid comparison between Unknown and I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Invalid comparison between Unknown and I4
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Invalid comparison between Unknown and I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(vsSelect.Trim(), "", false) == 0)
			{
				goto IL_08f3;
			}
			text3 = "SELECT * FROM (" + vsSelect + ") T WHERE 1=1 ";
			if (Operators.CompareString(vsFilter, "", false) != 0)
			{
				text3 = text3 + "AND (" + vsFilter + ") ";
			}
			if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
			{
				text3 = text3 + "AND (" + robjDropDownList.SqlQueryWhere + ") ";
			}
			text4 = "";
			if (Operators.CompareString(vsOrderByField, "", false) != 0)
			{
				text4 = "ORDER BY " + vsOrderByField + " ";
			}
			if ((int)base.DbConn.ServerTypeConnection == 0)
			{
				text = "SELECT TOP 100 PERCENT * FROM (" + text3 + ") T1 " + text4;
				text2 = "SELECT TOP <%TOP%> * FROM (" + text3 + ") T1 " + text4;
			}
			else if ((int)base.DbConn.ServerTypeConnection == 3)
			{
				text = "SELECT * FROM (SELECT * FROM (" + text3 + ") T1 " + text4 + ") TT";
				text2 = "SELECT * FROM (SELECT * FROM (" + text3 + ") T1 " + text4 + " LIMIT <%TOP%>) TT1";
			}
			else
			{
				text3 = text3 + " " + text4;
				text = "SELECT * FROM (" + text3 + ") T1 ";
				text2 = "SELECT * FROM (" + text3 + ") T1 WHERE ROWNUM<=<%TOP%> ";
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
				else if ((int)base.DbConn.ServerTypeConnection == 3)
				{
					text4 = " UNION SELECT * FROM (SELECT * FROM (SELECT * FROM (" + vsSelect + ") T2 WHERE " + vsValueFieldAlias + "=" + base.DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
					if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
					{
						text4 = text4 + " AND (" + robjDropDownList.SqlQueryWhere + ")";
					}
					text4 += ") T LIMIT 1) TT2";
				}
				else
				{
					text4 = " UNION SELECT TOP 1 * FROM (SELECT * FROM (" + vsSelect + ") T2 WHERE " + vsValueFieldAlias + "=" + base.DbConn.SQLFormatString(robjDropDownList.ObjValue.ToString());
					if (Operators.CompareString(robjDropDownList.SqlQueryWhere, "", false) != 0)
					{
						text4 = text4 + " AND (" + robjDropDownList.SqlQueryWhere + ")";
					}
					text4 += ") T ";
				}
				text += text4;
				text2 += text4;
			}
			text = "SELECT * FROM (" + text + ") T3";
			text2 = "SELECT * FROM (" + text2 + ") T3";
			if (Operators.CompareString(vsOrderByField, "", false) != 0)
			{
				text4 = " ORDER BY " + vsOrderByField + " ";
				text += text4;
				text2 += text4;
			}
			text2 = text2.Replace("<%TOP%>", robjDropDownList.SqlQueryTop.ToString());
			_ComboQueryCache.RemoveIdCombo(robjDropDownList.Id);
			ComboQueryCacheItem comboQueryCacheItem;
			if (!_ComboQueryCache.Contains(text))
			{
				comboQueryCacheItem = new ComboQueryCacheItem(text);
				_ComboQueryCache.Add(comboQueryCacheItem);
			}
			else
			{
				comboQueryCacheItem = _ComboQueryCache.Item(text);
				dataTable = (DataTable)comboQueryCacheItem.SqlQueryResult;
				if (!UseCache)
				{
					dataTable?.Dispose();
					comboQueryCacheItem.SqlQueryResult = null;
					dataTable = null;
				}
			}
			comboQueryCacheItem.ComboId.Add(robjDropDownList.Id);
			_ComboQueryCacheTop50.RemoveIdCombo(robjDropDownList.Id);
			ComboQueryCacheItem comboQueryCacheItem2;
			if (!_ComboQueryCacheTop50.Contains(text2))
			{
				comboQueryCacheItem2 = new ComboQueryCacheItem(text2);
				_ComboQueryCacheTop50.Add(comboQueryCacheItem2);
			}
			else
			{
				comboQueryCacheItem2 = _ComboQueryCacheTop50.Item(text2);
				dataTable2 = (DataTable)comboQueryCacheItem2.SqlQueryResult;
				if (!UseCache)
				{
					dataTable2?.Dispose();
					comboQueryCacheItem.SqlQueryResult = null;
					dataTable2 = null;
				}
			}
			comboQueryCacheItem2.ComboId.Add(robjDropDownList.Id);
			if (dataTable != null)
			{
				goto IL_07fc;
			}
			DataSet dataSet = null;
			text = text + ";" + text2;
			val2 = base.DbConn.OpenDataSet(text, ref dataSet, ref rsMess);
			if ((int)val2 <= 0)
			{
				dataTable = dataSet.Tables[0];
				checked
				{
					if (dataSet.Tables[0].Rows.Count > 0 && Operators.CompareString(dataSet.Tables[0].Rows[0][0].ToString(), "", false) != 0)
					{
						DataRow dataRow = dataSet.Tables[0].NewRow();
						int num = dataRow.ItemArray.Count() - 1;
						for (int i = 0; i <= num; i++)
						{
							if ((object)dataRow.Table.Columns[i].DataType == typeof(string))
							{
								dataRow[i] = "";
							}
						}
						dataSet.Tables[0].Rows.InsertAt(dataRow, 0);
					}
					dataTable2 = dataSet.Tables[1];
					comboQueryCacheItem.SqlQueryResult = dataTable;
					comboQueryCacheItem2.SqlQueryResult = dataTable2;
					goto IL_07fc;
				}
			}
			val = val2;
			goto end_IL_0026;
			IL_07fc:
			text4 = "";
			if (robjDropDownList.ObjValue != null && Operators.CompareString(robjDropDownList.ObjValue.ToString(), "", false) != 0)
			{
				text4 = robjDropDownList.ObjValue.ToString();
			}
			robjDropDownList.ItemClear();
			robjDropDownList.DataTextField = vsTextFieldAlias;
			robjDropDownList.DataValueField = vsValueFieldAlias;
			if (robjDropDownList.AutoLoadOnDemand)
			{
				robjDropDownList.DataSource = dataTable2;
			}
			else
			{
				robjDropDownList.DataSource = dataTable;
			}
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
			robjDropDownList.HtmlDecodedSpaces();
			if (!robjDropDownList.ItemExist("") && vbBlankItem)
			{
				robjDropDownList.ItemInsert(0, "");
			}
			goto IL_08f3;
			IL_08f3:
			val = (FXRETURN)0;
			end_IL_0026:;
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

	protected virtual FXRETURN LoadDropDownList(ref IIboDropdownList robjDropDownList, bool UseCache, ref string rsMess, bool vbBlankItem)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LoadDropDownList(robjDropDownList.SqlQuery, robjDropDownList.CampoDescrizione, robjDropDownList.CampoCodice, robjDropDownList.SqlQueryFilter, robjDropDownList.SqlQueryOrderBy, ref robjDropDownList, UseCache, ref rsMess, vbBlankItem);
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

	protected virtual FXRETURN LoadDropDownList(ref IboDropDownList robjDropDownList, bool UseCache, ref string rsMess, bool vbBlankItem)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList robjDropDownList2 = (IIboDropdownList)(object)robjDropDownList;
		return LoadDropDownList(ref robjDropDownList2, UseCache, ref rsMess, vbBlankItem);
	}

	protected virtual FXRETURN ReloadSingleCombo(ref IIboDropdownList objCombo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objCombo.SqlQuery, "", false) == 0 || (int)LoadDropDownList(ref objCombo, UseCache: false, ref rsMess, vbBlankItem: true) <= 0)
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

	protected virtual FXRETURN ReloadSingleCombo(ref IboWebComboTlk objCombo, ref string rsMess)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		objCombo.UIRenderFlag = false;
		IIboDropdownList objCombo2 = (IIboDropdownList)(object)objCombo;
		return ReloadSingleCombo(ref objCombo2, ref rsMess);
	}

	protected virtual FXRETURN ReloadSingleCombo(ref IboDropDownList objCombo, ref string rsMess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		IIboDropdownList objCombo2 = (IIboDropdownList)(object)objCombo;
		return ReloadSingleCombo(ref objCombo2, ref rsMess);
	}

	protected virtual FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = LoadData((IIncasTableLink)(object)this, ref _objFunctionArguments, ref rsMess);
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

	protected virtual FXRETURN LoadData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = _LoadData(pnlDetail, ref objFunctionArguments, ref rsMess);
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

	private FXRETURN _LoadData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Invalid comparison between Unknown and I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Invalid comparison between Unknown and I4
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Invalid comparison between Unknown and I4
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Invalid comparison between Unknown and I4
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Invalid comparison between Unknown and I4
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Invalid comparison between Unknown and I4
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		DataTable dataTable = null;
		bool flag = false;
		List<IIboWebComponent> list = new List<IIboWebComponent>();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			switch (objFunctionArguments.Name)
			{
			case "DUPLICAZIONE":
			case "MODIFICA":
			case "CANCELLAZIONE":
			case "VISUALIZZAZIONE":
				if (objFunctionArguments.Data == null)
				{
					rsMess = TranslateMessage("XXX", "Dati incompleti o mancanti.");
				}
				else if (objFunctionArguments.Data.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Chiave non specificata.");
				}
				else
				{
					if (Operators.CompareString(pnlDetail.TableNameLoad, "", false) == 0)
					{
						text2 = "SELECT 'PIER' IDLE " + base.DbConn.FromDual();
					}
					else
					{
						text2 = ((!pnlDetail.TableNameLoad.StartsWith("SELECT ")) ? ("SELECT * FROM " + pnlDetail.TableNameLoad + " WHERE 1=1 ") : ("SELECT * FROM (" + pnlDetail.TableNameLoad + ") T WHERE 1=1 "));
						text2 += objFunctionArguments.Data.GetFirstElementSqlWhere();
					}
					PerformanceLogAppend("DBPage Before Select Query");
					val = base.SessionEnvironment.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
					if ((int)val <= 0)
					{
						if (dataTable.Rows.Count != 0)
						{
							PerformanceLogAppend("DBPage After Select Query");
							set_BeforeImage(pnlDetail, new BeforeImageFieldsCollection());
							BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
							foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
							{
								Control val5 = iIboWebComponentControl;
								IIboWebComponent obj2 = (IIboWebComponent)val5;
								if (Operators.CompareString(obj2.SqlQueryLookup.Trim(), "", false) != 0)
								{
									list.Add(obj2);
								}
								if (Operators.CompareString(obj2.FieldName, "", false) == 0)
								{
									continue;
								}
								text = obj2.FieldName;
								try
								{
									obj = RuntimeHelpers.GetObjectValue(dataTable.Rows[0][text]);
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									rsMess = TranslateMessage("XXX", "Il campo '{0}' non appartiene alla tabella '{1}'", text, pnlDetail.TableNameLoad);
									ProjectData.ClearProjectError();
									goto end_IL_0022;
								}
								if (obj2 is IboWebImage)
								{
									IboWebImage iboWebImage2 = (IboWebImage)(object)obj2;
									string fieldNameExtension = iboWebImage2.FieldNameExtension;
									try
									{
										if (Operators.CompareString(fieldNameExtension, "", false) != 0)
										{
											object objectValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0][fieldNameExtension]);
											iboWebImage2.FileExtension = objectValue.ToString();
										}
									}
									catch (Exception ex3)
									{
										ProjectData.SetProjectError(ex3);
										Exception ex4 = ex3;
										rsMess = TranslateMessage("XXX", "Il campo '{0}' non appartiene alla tabella '{1}'", text, pnlDetail.TableNameLoad);
										ProjectData.ClearProjectError();
										goto end_IL_0022;
									}
									iboWebImage2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
									iboWebImage2.OriginalImageUrl = iboWebImage2.ImageUrl;
								}
								else if (obj2 is IboWebComboTlk)
								{
									if (!((Page)this).IsPostBack)
									{
										obj2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
									}
									else
									{
										IIboDropdownList val6 = (IIboDropdownList)obj2;
										string? sItemValue = obj.ToString();
										string rsMess2 = "";
										ComboSelectedItem(val6, sItemValue, ref rsMess2);
									}
								}
								else
								{
									obj2.ObjValue = RuntimeHelpers.GetObjectValue(obj);
								}
								if (!beforeImageFieldsCollection.ContainsKey(text))
								{
									beforeImageFieldsCollection.Add(text, new BeforeImageField(text, obj.ToString(), RuntimeHelpers.GetObjectValue(obj)));
								}
								if (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
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
						}
						rsMess = TranslateMessage("XXX", "Nessun record trovato.");
					}
				}
				goto end_IL_0022;
			case "INSERIMENTO":
			{
				set_BeforeImage(pnlDetail, new BeforeImageFieldsCollection());
				BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
				foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl2;
					IIboWebComponent val4 = (IIboWebComponent)val3;
					if (Operators.CompareString(val4.SqlQueryLookup.Trim(), "", false) != 0)
					{
						list.Add(val4);
					}
					if (Operators.CompareString(val4.FieldName, "", false) == 0)
					{
						continue;
					}
					text = val4.FieldName;
					if ((int)val4.FieldDataType == 1)
					{
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, Conversions.ToString(-999999), -999999));
					}
					else if (val4 is IboWebImage)
					{
						IboWebImage iboWebImage = (IboWebImage)(object)val4;
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, "", ""));
						if (Operators.CompareString(iboWebImage.FieldNameExtension, "", false) != 0)
						{
							beforeImageFieldsCollection.Add(iboWebImage.FieldNameExtension, new BeforeImageField(text, "", ""));
						}
					}
					else if (!beforeImageFieldsCollection.ContainsKey(text))
					{
						beforeImageFieldsCollection.Add(text, new BeforeImageField(text, "", ""));
					}
				}
				break;
			}
			default:
				rsMess = TranslateMessage("XXX", "Modalità/funzionalità non gestita.");
				goto end_IL_0022;
			}
			PerformanceLogAppend("DBPage After BeforeImage");
			val = SetIsKeyPropertyToControls(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("DBPage After SetIsKeyPropertyToControls");
				val = LoadDataInCheckList(pnlDetail, ref objFunctionArguments, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("DBPage After LoadDataInCheckList");
					val = RestoreFormState(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						PerformanceLogAppend("DBPage After RestoreFormState");
						val = LookupQueryDecode(list, pnlDetail, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							PerformanceLogAppend("DBPage After LookupQueryDecode");
							val = SetControlsEnabledProperty(pnlDetail, ref objFunctionArguments, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								PerformanceLogAppend("DBPage After Disable controls");
								val2 = (FXRETURN)0;
							}
						}
					}
				}
			}
			end_IL_0022:;
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

	protected virtual FXRETURN SetControlsEnabledProperty(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			if (btnConferma != null)
			{
				btnConferma.Visible = Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0;
			}
			if (btnAnnulla != null)
			{
				btnAnnulla.Visible = true;
			}
			foreach (Control allIboWebComponentControl in GetAllIboWebComponentControls(parent))
			{
				Control val3 = allIboWebComponentControl;
				if (val3 is IboWebCheckBoxList)
				{
					IboWebCheckBoxList val4 = (IboWebCheckBoxList)val3;
					val4.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & val4.Enabled);
				}
				else if (val3 is IboWebToolbar)
				{
					IboWebToolbar iboWebToolbar = (IboWebToolbar)(object)val3;
					iboWebToolbar.Enabled = (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & iboWebToolbar.Enabled;
				}
				else if (val3 is IboGridView)
				{
					IboGridView val5 = (IboGridView)val3;
					val5.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & ((WebControl)val5).Enabled & !val5.ReadOnly);
				}
				else
				{
					if (!(val3 is IIboWebComponent))
					{
						continue;
					}
					IIboWebComponent obj = (IIboWebComponent)val3;
					if (Operators.CompareString(obj.FieldName, "", false) != 0)
					{
						obj.ReadOnly = !((Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0) & obj.Enabled & !obj.ReadOnly);
						if (IsDBIdentity(ref obj))
						{
							obj.ReadOnly = true;
						}
						else if (IsWfiIdentity(ref obj))
						{
							obj.ReadOnly = true;
						}
					}
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

	protected virtual FXRETURN SetIsKeyPropertyToControls(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				Control parent = (Control)pnlDetail;
				StringCollection stringCollection = new StringCollection();
				if (objFunctionArguments.Data != null && objFunctionArguments.Data.Count > 0)
				{
					int num = objFunctionArguments.Data.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						stringCollection.Add(objFunctionArguments.Data.Item(i).FieldName.ToUpper());
					}
				}
				if (stringCollection.Count == 0 && objFunctionArguments.Keys != null)
				{
					int num2 = objFunctionArguments.Keys.Count() - 1;
					for (int j = 0; j <= num2; j++)
					{
						stringCollection.Add(objFunctionArguments.Keys[j].FieldName.ToUpper());
					}
				}
				StringEnumerator enumerator = stringCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName(parent, current);
					if (iIboWebComponentByFieldName != null)
					{
						iIboWebComponentByFieldName.IsKey = true;
						iIboWebComponentByFieldName.AutoTrim = true;
						if (Operators.CompareString(objFunctionArguments.Name, "MODIFICA", false) == 0)
						{
							iIboWebComponentByFieldName.ReadOnly = true;
						}
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
	}

	protected virtual FXRETURN LoadDataInCheckList(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Conversions.ToBoolean(base.SessionEnvironment.PersistentSessionVariables[PageName + ".HasIboWebCheckBoxList"]))
			{
				bool flag = false;
				Control parent = (Control)pnlDetail;
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl;
					IboWebCheckBoxList val4 = (IboWebCheckBoxList)(object)((val3 is IboWebCheckBoxList) ? val3 : null);
					if (val4 == null)
					{
						continue;
					}
					flag = true;
					string Query = val4.SqlQuery + " WHERE " + val4.SqlQueryFilter;
					val = ReplaceVariableInCheckList(ref Query, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = base.DbConn.OpenDataTable(Query, ref dataTable, ref rsMess);
						if ((int)val <= 0)
						{
							((BaseDataBoundControl)val4).DataSource = dataTable;
							((ListControl)val4).DataTextField = val4.CampoDescrizione;
							((ListControl)val4).DataValueField = val4.CampoCodice;
							((BaseDataBoundControl)val4).DataBind();
							string text = "";
							foreach (DataRow row in dataTable.Rows)
							{
								if (Operators.CompareString(row[val4.FieldSelectedName].ToString(), "S", false) == 0)
								{
									if (Operators.CompareString(text, "", false) != 0)
									{
										text += ";";
									}
									text += row[val4.CampoCodice].ToString();
								}
							}
							val4.ObjValue = text;
							val4.BeforeImage = text;
							continue;
						}
						val2 = val;
					}
					goto end_IL_0007;
				}
				base.SessionEnvironment.PersistentSessionVariables[PageName + ".HasIboWebCheckBoxList"] = flag;
			}
			val2 = (FXRETURN)0;
			end_IL_0007:;
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

	protected virtual FXRETURN ReplaceVariableInCheckList(ref string Query, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = Query;
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_040f;
			}
			text = Strings.Replace(Strings.Replace(text, "<#", "<%", 1, -1, (CompareMethod)0), "#>", "%>", 1, -1, (CompareMethod)0);
			Hashtable sRetColl = null;
			val = base.BaseFunctions.StandardVariableFinder(text, ref sRetColl, ref rsMess);
			if ((int)val <= 0)
			{
				IDictionaryEnumerator enumerator = sRetColl.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					DictionaryEntry dictionaryEntry = ((current != null) ? ((DictionaryEntry)current) : default(DictionaryEntry));
					string text2 = "";
					string text3 = "";
					if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("MASTER_RECORD."))
					{
						text3 = "MASTER_RECORD";
						text2 = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
					}
					else if (dictionaryEntry.Key.ToString().ToUpper().StartsWith("CONTROLS_RECORD."))
					{
						text3 = "CONTROLS_RECORD";
						text2 = Strings.Split(dictionaryEntry.Key.ToString().ToUpper(), ".", -1, (CompareMethod)0)[1];
					}
					else if (!dictionaryEntry.Key.ToString().ToUpper().StartsWith("GRID_RECORD."))
					{
						text3 = "MASTER_RECORD";
						text2 = dictionaryEntry.Key.ToString().ToUpper();
					}
					switch (text3)
					{
					case "MASTER_RECORD":
					{
						BeforeImageFieldsCollection beforeImage = this.BeforeImage;
						foreach (string key in beforeImage.Keys)
						{
							if (Operators.CompareString(key.ToUpper(), text2, false) == 0)
							{
								if (Operators.CompareString(beforeImage[key].FieldValue.ToString(), "", false) != 0)
								{
									text = text.Replace(dictionaryEntry.Value.ToString(), beforeImage[key].FieldValue.ToString().Replace("'", "''"));
									break;
								}
								string text5 = dictionaryEntry.Value.ToString().Replace("= ", "=");
								text5 = text5.Replace("=  ", "=");
								text = text.Replace("='" + text5 + "'", " IS NULL");
								text = text.Replace("=" + text5, " IS NULL");
								break;
							}
						}
						break;
					}
					case "CONTROLS_RECORD":
					{
						Control controlByName = GetControlByName((Control)(object)this, text2);
						if (controlByName != null && controlByName is IIboWebComponent)
						{
							if (Operators.CompareString(((IIboWebComponent)controlByName).ObjValue.ToString(), "", false) != 0)
							{
								text = text.Replace(dictionaryEntry.Value.ToString(), ((IIboWebComponent)controlByName).ObjValue.ToString().Replace("'", "''"));
								break;
							}
							string text4 = dictionaryEntry.Value.ToString().Replace("= ", "=");
							text4 = text4.Replace("=  ", "=");
							text = text.Replace("='" + text4 + "'", " IS NULL");
							text = text.Replace("=" + text4, " IS NULL");
						}
						break;
					}
					}
				}
				goto IL_040f;
			}
			val2 = val;
			goto end_IL_0005;
			IL_040f:
			Query = text;
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

	protected virtual FXRETURN SaveDataInCheckList(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref IboWebCheckBoxList checkList, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Invalid comparison between Unknown and I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Invalid comparison between Unknown and I4
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Invalid comparison between Unknown and I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Invalid comparison between Unknown and I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Invalid comparison between Unknown and I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Invalid comparison between Unknown and I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Invalid comparison between Unknown and I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		string text2 = "";
		FXRETURN result;
		try
		{
			Control parent = (Control)pnlDetail;
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0 || !(((Operators.CompareString(checkList.TableName, "", false) != 0) & (Operators.CompareString(checkList.FieldName1, "", false) != 0) & (Operators.CompareString(checkList.FieldName2, "", false) != 0)) | ((Operators.CompareString(checkList.SqlQueryDelete, "", false) != 0) & (Operators.CompareString(checkList.SqlQueryInsert, "", false) != 0))) || !((Operators.CompareString(checkList.BeforeImage, checkList.ObjValue.ToString(), false) != 0) | (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
			{
				goto IL_05f1;
			}
			if ((Operators.CompareString(checkList.SqlQueryDelete, "", false) == 0) & (Operators.CompareString(checkList.SqlQueryInsert, "", false) == 0))
			{
				text = "DELETE FROM <%TABLE%> WHERE <%FIELD1%> = <%VALUE1%>";
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
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
					goto IL_05f1;
				}
				val2 = val;
			}
			else
			{
				string text3 = checkList.SqlQueryDelete;
				if (Operators.CompareString(text3, "", false) != 0)
				{
					text3 += ";";
				}
				text = "";
				if (Operators.CompareString(checkList.SqlQueryInsert, "", false) != 0)
				{
					foreach (ListItem item2 in ((ListControl)checkList).Items)
					{
						ListItem val6 = item2;
						text2 = ((!val6.Selected) ? "N" : "S");
						string sqlQueryInsert = checkList.SqlQueryInsert;
						sqlQueryInsert = sqlQueryInsert.Replace("<#VALUE#>", val6.Value);
						sqlQueryInsert = sqlQueryInsert.Replace("<#SELECTEDVALUE#>", text2);
						sqlQueryInsert += ";";
						if ((int)checkList.CheckBoxListMode == 0)
						{
							if (Operators.CompareString(text2, "S", false) == 0)
							{
								text += sqlQueryInsert;
							}
						}
						else if ((int)checkList.CheckBoxListMode == 1)
						{
							text += sqlQueryInsert;
						}
					}
				}
				text3 += text;
				val = ReplaceVariableInCheckList(ref text3, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(text3, "", false) == 0)
					{
						goto IL_05f1;
					}
					val = base.DbConn.SqlExec(text3, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_05f1;
					}
					val2 = val;
				}
			}
			goto end_IL_0015;
			IL_05f1:
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
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string key = PageName + ".HasComboUpdatePanel";
			if (!base.SessionEnvironment.PersistentSessionVariables.ContainsKey(key))
			{
				base.SessionEnvironment.PersistentSessionVariables.Add(key, true);
			}
			key = PageName + ".HasIboWebCheckBoxList";
			if (!base.SessionEnvironment.PersistentSessionVariables.ContainsKey(key))
			{
				base.SessionEnvironment.PersistentSessionVariables.Add(key, true);
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

	protected virtual FXRETURN ConfermaClick(ref string rsMess)
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
			val = BeforeConfermaClick(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = SavingProcess(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AfterConfermaClick(ref rsMess);
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

	protected virtual FXRETURN AnnullaClick(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_AutoReleaseMemoryOnCancel)
			{
				string rsMess2 = "";
				ReleaseMemory(ref rsMess2);
			}
			ReturnToCaller(bAnnulla: true);
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

	protected virtual FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = SaveData((IIncasTableLink)(object)this, ref _objFunctionArguments, ref rsMess);
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

	protected virtual FXRETURN SaveData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Invalid comparison between Unknown and I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Invalid comparison between Unknown and I4
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Invalid comparison between Unknown and I4
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Invalid comparison between Unknown and I4
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Invalid comparison between Unknown and I4
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Invalid comparison between Unknown and I4
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Invalid comparison between Unknown and I4
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected O, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected O, but got Unknown
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Invalid comparison between Unknown and I4
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Invalid comparison between Unknown and I4
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Invalid comparison between Unknown and I4
		//IL_1035: Unknown result type (might be due to invalid IL or missing references)
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Invalid comparison between Unknown and I4
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		object obj = null;
		string text7 = "";
		List<byte[]> list = new List<byte[]>();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			if (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) != 0 || !((object)pnlDetail).Equals((object?)this))
			{
				goto IL_00a1;
			}
			val = SaveDetailData(ref _SQLQueryToApply, ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_00a1;
			}
			val2 = val;
			goto end_IL_003f;
			IL_110e:
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
			{
				Control val3 = iIboWebComponentControl;
				IboWebCheckBoxList checkList = (IboWebCheckBoxList)(object)((val3 is IboWebCheckBoxList) ? val3 : null);
				if (checkList == null)
				{
					continue;
				}
				val = SaveDataInCheckList(pnlDetail, ref objFunctionArguments, ref checkList, ref rsMess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_003f;
			}
			val2 = (FXRETURN)0;
			goto end_IL_003f;
			IL_0f32:
			val = SaveIsDefault(pnlDetail, ref objFunctionArguments, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (list.Count == 0)
			{
				val = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0fa6;
				}
				val2 = val;
			}
			else
			{
				val = base.DbConn.SqlExecBlobHelper(text, list, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0fa6;
				}
				val2 = val;
			}
			goto end_IL_003f;
			IL_00a1:
			DataTable dataTable = null;
			text = "SELECT UteIns, UteAgg, DatIns, DatAgg FROM " + TableNameSave + " WHERE 1=2";
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			bool flag = true;
			if ((int)val > 0)
			{
				flag = false;
			}
			switch (objFunctionArguments.Name)
			{
			case "INSERIMENTO":
			case "DUPLICAZIONE":
				text = ((!flag) ? "INSERT INTO <<TABELLA>> (<<ELENCOCAMPI>>) VALUES (<<ELENCOVALORI>>) " : "INSERT INTO <<TABELLA>> (<<ELENCOCAMPI>>, UTEINS, UTEAGG) VALUES (<<ELENCOVALORI>>, <<UTEINS>>, <<UTEAGG>>) ");
				text3 = "SELECT COUNT(*) FROM <<TABELLA>> WHERE 1=1 ";
				break;
			case "MODIFICA":
				text = ((!flag) ? "UPDATE <<TABELLA>> SET <<ELENCOCAMPI>> WHERE 1=1 " : ("UPDATE <<TABELLA>> SET <<ELENCOCAMPI>>, DATAGG=" + base.DbConn.GetDate() + ", UTEAGG=<<UTEAGG>> WHERE 1=1 "));
				text += objFunctionArguments.Data.GetFirstElementSqlWhere();
				break;
			case "CANCELLAZIONE":
				text = "DELETE FROM <<TABELLA>> WHERE 1=1 ";
				text += objFunctionArguments.Data.GetAllElementSqlWhere();
				break;
			}
			BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
			if (beforeImageFieldsCollection == null)
			{
				rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
			}
			else
			{
				foreach (Control iIboWebComponentControl2 in GetIIboWebComponentControls(parent))
				{
					Control val4 = iIboWebComponentControl2;
					IIboWebComponent obj2 = (IIboWebComponent)val4;
					if (IsDBIdentity(ref obj2) || Operators.CompareString(obj2.FieldName, "", false) == 0)
					{
						continue;
					}
					text4 = obj2.FieldName;
					if (!beforeImageFieldsCollection.ContainsKey(text4))
					{
						continue;
					}
					switch (objFunctionArguments.Name)
					{
					case "INSERIMENTO":
					case "DUPLICAZIONE":
						if ((int)obj2.FieldDataType == 1)
						{
							text5 = text5 + text4 + ",";
							string text13 = text6;
							DBConnection dbConn4 = base.DbConn;
							string text10 = obj2.ObjValue.ToString();
							text6 = text13 + dbConn4.SQLFormatNumber(ref text10) + ",";
						}
						else if ((int)obj2.FieldDataType == 2)
						{
							text5 = text5 + text4 + ",";
							text6 = ((!(val4 is IboWebDate)) ? ((!(val4 is IboWebDate2)) ? (text6 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : (((val4 as IboWebDate2).ControlType != IboWebDateType.TimeOnly) ? (text6 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : (text6 + base.DbConn.SQLFormatDate((eTipoData)3, obj2.ObjValue.ToString()) + ","))) : (((val4 as IboWebDate).ControlType != IboWebDateType.TimeOnly) ? (text6 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : (text6 + base.DbConn.SQLFormatDate((eTipoData)3, obj2.ObjValue.ToString()) + ",")));
						}
						else if (val4 is IboWebImage)
						{
							text5 = text5 + text4 + ",";
							IboWebImage iboWebImage2 = (IboWebImage)(object)val4;
							if (iboWebImage2.ObjValue == null)
							{
								text6 += "NULL,";
							}
							else
							{
								text6 = text6 + " :" + checked(list.Count + 1) + " ,";
								list.Add((byte[])iboWebImage2.ObjValue);
							}
							if (Operators.CompareString(iboWebImage2.FieldNameExtension, "", false) != 0)
							{
								text5 = text5 + iboWebImage2.FieldNameExtension + ",";
								text6 = ((iboWebImage2.ObjValue != null) ? (text6 + base.DbConn.SQLFormatString(iboWebImage2.FileExtension) + ",") : (text6 + "NULL,"));
							}
						}
						else
						{
							text5 = text5 + text4 + ",";
							text6 = text6 + base.DbConn.SQLFormatString(obj2.ObjValue.ToString()) + ",";
						}
						break;
					case "MODIFICA":
						if ((int)obj2.FieldDataType == 1)
						{
							if ((Operators.CompareString(beforeImageFieldsCollection[text4].FieldValue.ToString(), "", false) == 0) & (Operators.CompareString(obj2.ObjValue.ToString(), "", false) != 0))
							{
								text5 = text5 + text4 + "=";
								string text8 = text5;
								DBConnection dbConn = base.DbConn;
								double num = Conversions.ToDouble(obj2.ObjValue);
								text5 = text8 + dbConn.SQLFormatNumber(ref num) + ",";
							}
							else if ((Operators.CompareString(beforeImageFieldsCollection[text4].FieldValue.ToString(), "", false) != 0) & (Operators.CompareString(obj2.ObjValue.ToString(), "", false) == 0))
							{
								text5 = text5 + text4 + "=";
								string text9 = text5;
								DBConnection dbConn2 = base.DbConn;
								string text10 = obj2.ObjValue.ToString();
								text5 = text9 + dbConn2.SQLFormatNumber(ref text10) + ",";
							}
							else if (Operators.CompareString(beforeImageFieldsCollection[text4].FieldValue.ToString(), "", false) != 0 && Conversions.ToDouble(obj2.ObjValue) != Conversions.ToDouble(beforeImageFieldsCollection[text4].FieldValue))
							{
								text5 = text5 + text4 + "=";
								string text11 = text5;
								DBConnection dbConn3 = base.DbConn;
								double num = Conversions.ToDouble(obj2.ObjValue);
								text5 = text11 + dbConn3.SQLFormatNumber(ref num) + ",";
							}
						}
						else if ((int)obj2.FieldDataType == 2)
						{
							string text12 = obj2.ObjValue.ToString();
							string fieldText = beforeImageFieldsCollection[text4].FieldText;
							bool flag2 = false;
							if (((Operators.CompareString(text12, "", false) == 0) | (Operators.CompareString(fieldText, "", false) == 0)) & (Operators.CompareString(text12, fieldText, false) != 0))
							{
								flag2 = true;
							}
							else if (((Operators.CompareString(text12, "", false) != 0) & (Operators.CompareString(fieldText, "", false) != 0)) && DateTime.Compare(Conversions.ToDate(text12), Conversions.ToDate(fieldText)) != 0)
							{
								flag2 = true;
							}
							if (flag2 && Operators.CompareString(obj2.ObjValue.ToString(), beforeImageFieldsCollection[text4].FieldText, false) != 0)
							{
								text5 = text5 + text4 + "=";
								text5 = ((!(val4 is IboWebDate)) ? ((!(val4 is IboWebDate2)) ? (text5 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : ((((IboWebDate2)(object)val4).ControlType != IboWebDateType.TimeOnly) ? (text5 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : (text5 + base.DbConn.SQLFormatDate((eTipoData)3, obj2.ObjValue.ToString()) + ","))) : (((val4 as IboWebDate).ControlType != IboWebDateType.TimeOnly) ? (text5 + base.DbConn.SQLFormatDate((eTipoData)2, obj2.ObjValue.ToString()) + ",") : (text5 + base.DbConn.SQLFormatDate((eTipoData)3, obj2.ObjValue.ToString()) + ",")));
							}
						}
						else if (val4 is IboWebImage)
						{
							IboWebImage iboWebImage = (IboWebImage)(object)val4;
							if (Operators.CompareString(iboWebImage.ImageUrl, iboWebImage.OriginalImageUrl, false) != 0)
							{
								text5 = text5 + text4 + "=";
								byte[] array = (byte[])iboWebImage.ObjValue;
								if (array == null)
								{
									text5 += "NULL,";
								}
								else
								{
									text5 = text5 + " :" + checked(list.Count + 1) + " ,";
									list.Add(array);
								}
								if (Operators.CompareString(iboWebImage.FieldNameExtension, "", false) != 0)
								{
									text5 = text5 + iboWebImage.FieldNameExtension + "=";
									text5 = ((array != null) ? (text5 + base.DbConn.SQLFormatString(iboWebImage.FileExtension) + ",") : (text5 + "NULL,"));
								}
							}
						}
						else if (Operators.CompareString(obj2.ObjValue.ToString(), beforeImageFieldsCollection[text4].FieldText, false) != 0)
						{
							text5 = text5 + text4 + "=";
							text5 = text5 + base.DbConn.SQLFormatString(obj2.ObjValue.ToString()) + ",";
						}
						break;
					}
				}
				int num2;
				checked
				{
					if (Operators.CompareString(text5, "", false) != 0)
					{
						text5 = Strings.Left(text5, Strings.Len(text5) - 1);
					}
					if (Operators.CompareString(text6, "", false) != 0)
					{
						text6 = Strings.Left(text6, Strings.Len(text6) - 1);
					}
					if (!((Operators.CompareString(text5, "", false) != 0) | (Operators.CompareString(objFunctionArguments.Name, "CANCELLAZIONE", false) == 0)))
					{
						goto IL_110e;
					}
					text = Strings.Replace(text, "<<ELENCOCAMPI>>", text5, 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, "<<ELENCOVALORI>>", text6, 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, "<<TABELLA>>", pnlDetail.TableNameSave, 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, "<<UTEINS>>", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice), 1, -1, (CompareMethod)0);
					text = Strings.Replace(text, "<<UTEAGG>>", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice), 1, -1, (CompareMethod)0);
					text3 = Strings.Replace(text3, "<<ELENCOCAMPI>>", text5, 1, -1, (CompareMethod)0);
					text3 = Strings.Replace(text3, "<<ELENCOVALORI>>", text6, 1, -1, (CompareMethod)0);
					text3 = Strings.Replace(text3, "<<TABELLA>>", pnlDetail.TableNameSave, 1, -1, (CompareMethod)0);
					text3 = Strings.Replace(text3, "<<UTEINS>>", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice), 1, -1, (CompareMethod)0);
					text3 = Strings.Replace(text3, "<<UTEAGG>>", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice), 1, -1, (CompareMethod)0);
					if (!((Operators.CompareString(objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
					{
						goto IL_0f32;
					}
					num2 = objFunctionArguments.Keys.Count() - 1;
				}
				for (int i = 0; i <= num2; i = checked(i + 1))
				{
					foreach (Control iIboWebComponentControl3 in GetIIboWebComponentControls(parent))
					{
						Control val5 = iIboWebComponentControl3;
						IIboWebComponent obj3 = (IIboWebComponent)val5;
						if (Operators.CompareString(obj3.FieldName.ToUpper(), objFunctionArguments.Keys[i].FieldName.ToUpper(), false) == 0 && !IsDBIdentity(ref obj3) && obj3.IsKey)
						{
							if (Operators.CompareString(text7, "", false) != 0)
							{
								text7 += " AND ";
							}
							if ((int)obj3.FieldDataType == 2)
							{
								text7 = text7 + obj3.FieldName + "=" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(obj3.ObjValue));
							}
							else if ((int)obj3.FieldDataType == 1)
							{
								string text14 = text7;
								string fieldName = obj3.FieldName;
								DBConnection dbConn5 = base.DbConn;
								decimal num3 = Conversions.ToDecimal(obj3.ObjValue);
								text7 = text14 + fieldName + "=" + dbConn5.SQLFormatNumber(ref num3);
							}
							else
							{
								text7 = text7 + obj3.FieldName + "=" + base.DbConn.SQLFormatString(obj3.ObjValue.ToString());
							}
						}
					}
				}
				if (Operators.CompareString(text7, "", false) == 0)
				{
					goto IL_0f32;
				}
				text3 = text3 + " AND (" + text7 + ")";
				val = base.SessionEnvironment.DbConn.DoSql(text3, ref obj, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(obj) <= 0)
					{
						goto IL_0f32;
					}
					rsMess = TranslateMessage("XXX", "Chiave duplicata sul database. Il record che si sta cercando di inserire esiste già.");
				}
			}
			goto end_IL_003f;
			IL_0fa6:
			_MasterRecordSaved = true;
			if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) || _DBIdentityControl == null || Operators.CompareString(_DBIdentityControl.ObjValue.ToString(), "", false) != 0)
			{
				goto IL_106d;
			}
			decimal? num4 = default(decimal?);
			val = base.DbConn.GetLastIdentity(ref num4, ref rsMess);
			if ((int)val <= 0)
			{
				if (num4.HasValue)
				{
					_DBIdentityControl.ObjValue = num4.Value.ToString();
				}
				goto IL_106d;
			}
			val2 = val;
			goto end_IL_003f;
			IL_106d:
			if (_SQLQueryToApply.Count <= 0)
			{
				goto IL_10e1;
			}
			string text15 = "";
			StringEnumerator enumerator4 = _SQLQueryToApply.GetEnumerator();
			while (enumerator4.MoveNext())
			{
				string current = enumerator4.Current;
				text15 = text15 + current + ";";
			}
			val = base.DbConn.SqlExec(text15, ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_10e1;
			}
			val2 = val;
			goto end_IL_003f;
			IL_10e1:
			val = LogRisorseAzioneInserisci("", "", text, "", ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_110e;
			}
			val2 = val;
			end_IL_003f:;
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

	protected virtual FXRETURN InitializeDupInfo(ref WFIDupInfoCollection DupInfo, ref string rsMess)
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

	protected virtual FXRETURN SaveDetailData(ref StringCollection SqlQuery, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (SqlQuery == null)
			{
				SqlQuery = new StringCollection();
			}
			val = InitializeDupInfo(ref _DupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (WFIDupInfo item in _DupInfo)
				{
					string detailTable = item.DetailTable;
					string sqlWhereForeignKey = item.SqlWhereForeignKey;
					FieldsDictionary campiDaSostituire = item.CampiDaSostituire;
					StringCollection campiDaEscludere = item.CampiDaEscludere;
					if (!((Dictionary<string, string>)(object)campiDaSostituire).ContainsKey("UteIns"))
					{
						((Dictionary<string, string>)(object)campiDaSostituire).Add("UteIns", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice));
					}
					if (!((Dictionary<string, string>)(object)campiDaSostituire).ContainsKey("UteAgg"))
					{
						((Dictionary<string, string>)(object)campiDaSostituire).Add("UteAgg", base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice));
					}
					if (!campiDaEscludere.Contains("DatIns"))
					{
						campiDaEscludere.Add("DatIns");
					}
					if (!campiDaEscludere.Contains("DatAgg"))
					{
						campiDaEscludere.Add("DatAgg");
					}
					val = CopiaRecord.RunProc(CreateApiContext(), detailTable, detailTable, sqlWhereForeignKey, ref campiDaSostituire, ref campiDaEscludere, false, false, ref text, ref rsMess);
					if ((int)val <= 0)
					{
						if (Operators.CompareString(text, "", false) != 0)
						{
							SqlQuery.Add(text);
						}
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
				val2 = (FXRETURN)0;
			}
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

	protected virtual FXRETURN SaveIsDefault(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			if (Operators.CompareString(objFunctionArguments.Name, "VISUALIZZAZIONE", false) != 0)
			{
				foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(parent))
				{
					Control val3 = iIboWebComponentControl;
					IboWebCheckBox val4 = (IboWebCheckBox)(object)((val3 is IboWebCheckBox) ? val3 : null);
					if (val4 == null)
					{
						continue;
					}
					string sWhere = "";
					IIboWebComponent obj = (IIboWebComponent)(object)val4;
					if (!IsDefault(ref obj, ref sWhere) || Operators.CompareString(val4.ValueIfChecked, val4.Value, false) != 0)
					{
						continue;
					}
					text = "UPDATE " + pnlDetail.TableNameSave + " SET " + val4.FieldName + "=" + base.DbConn.SQLFormatString(val4.ValueIfNotChecked);
					if (Operators.CompareString(sWhere, "", false) != 0)
					{
						text = text + " WHERE " + sWhere;
					}
					val = base.SessionEnvironment.DbConn.SqlExec(text, ref rsMess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
			}
			else if (Operators.CompareString(objFunctionArguments.Name, "CANCELLAZIONE", false) == 0)
			{
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

	protected virtual FXRETURN SavingProcess(ref string rsMess)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return SavingProcess(vbReload: false, ref rsMess);
	}

	protected virtual FXRETURN AskForConfirmation(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				string text = ((object[])objParams)[0].ToString();
				string text2 = ((object[])objParams)[1].ToString();
				WFIUserMessage.TipoMessageBox tipo = (WFIUserMessage.TipoMessageBox)((object[])objParams)[2];
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = TranslateMessage("XXX", "Conferma di salvataggio");
				}
				base.SessionEnvironment.UserMessage.Message1 = text2;
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = TranslateMessage("XXX", "Verranno apportate delle modifiche al record corrente. Proseguire?");
				}
				base.SessionEnvironment.UserMessage.Message2 = text;
				base.SessionEnvironment.UserMessage.NeedToRefresh = false;
				base.SessionEnvironment.UserMessage.Tipo = tipo;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "AskForConfirmation";
				base.SessionEnvironment.UserMessage.CallBackCancelFunctionName = "AskForConfirmationCancel";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
			}
			else if ((base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma) | (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Yes))
			{
				base.SessionEnvironment.UserMessage.Reset();
				_SessionVariable["_AreYouSureBlockedMessageState"] = (object)"2";
				btnConferma_Click(btnConferma, new EventArgs());
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
			dataKeyFieldCollection = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN AskForConfirmationCancel(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_SessionVariable["_AreYouSureBlockedMessageState"] = (object)"0";
			base.SessionEnvironment.UserMessage.Reset();
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
			dataKeyFieldCollection = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN SavingProcess(bool vbReload, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Invalid comparison between Unknown and I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Invalid comparison between Unknown and I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Invalid comparison between Unknown and I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Invalid comparison between Unknown and I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Invalid comparison between Unknown and I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)
			{
				goto IL_043a;
			}
			PerformanceLogAppend("Before BeforeCheckData");
			if ((int)BeforeCheckData(ref rsMess) <= 0)
			{
				PerformanceLogAppend("After BeforeCheckData");
				PerformanceLogAppend("Before CheckData");
				if ((int)CheckData(ref rsMess) <= 0)
				{
					PerformanceLogAppend("After CheckData");
					PerformanceLogAppend("Before AfterCheckData");
					if ((int)AfterCheckData(ref rsMess) <= 0)
					{
						PerformanceLogAppend("After AfterCheckData");
						if (Operators.CompareString(_AreYouSureBlockedMessage, "", false) == 0)
						{
							goto IL_018c;
						}
						if (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "0", false) != 0)
						{
							if (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "2", false) != 0)
							{
							}
							goto IL_018c;
						}
						object objParams = new object[3] { _AreYouSureBlockedMessage, _AreYouSureBlockedMessageTitle, _AreYouSureBlockedMessageType };
						val = AskForConfirmation(ref objParams, ref rsMess);
						if ((int)val <= 0)
						{
							_SessionVariable["_AreYouSureBlockedMessageState"] = (object)"1";
							goto IL_018c;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0005;
			IL_043a:
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_018c:
			if (!((Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "2", false) == 0) | (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "0", false) == 0)))
			{
				goto IL_043a;
			}
			PerformanceLogAppend("Before BeforeSaveDataBeforeBeginTransaction");
			val = BeforeSaveDataBeforeBeginTransaction(ref rsMess);
			if ((int)val <= 0)
			{
				PerformanceLogAppend("After BeforeSaveDataBeforeBeginTransaction");
				val = WFIBeginTransaction(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("Before BeforeSaveData");
					val = BeforeSaveData(ref rsMess);
					if ((int)val <= 0)
					{
						PerformanceLogAppend("After BeforeSaveData");
						PerformanceLogAppend("Before SaveData");
						val = SaveData(ref rsMess);
						if ((int)val <= 0)
						{
							PerformanceLogAppend("After SaveData");
							PerformanceLogAppend("Before AfterSaveData");
							val = AfterSaveData(ref rsMess);
							if ((int)val <= 0)
							{
								PerformanceLogAppend("After AfterSaveData");
								val = WFICommitTransaction(ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									PerformanceLogAppend("Before AfterSaveDataAfterCommit");
									val = AfterSaveDataAfterCommit(ref rsMess);
									if ((int)val > 0)
									{
										val2 = val;
									}
									else
									{
										PerformanceLogAppend("After AfterSaveDataAfterCommit");
										if (!vbReload)
										{
											goto IL_043a;
										}
										_objFunctionArguments.Name = "MODIFICA";
										if (_objFunctionArguments.Keys.Length == 0)
										{
											val2 = (FXRETURN)5;
											rsMess = TranslateMessage("XXX", "No key field...");
										}
										DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
										int i = default(int);
										for (; i < _objFunctionArguments.Keys.Length; i = checked(i + 1))
										{
											DataKeyFieldValues dataKeyFieldValues = new DataKeyFieldValues(_objFunctionArguments.Keys[i].FieldName, _objFunctionArguments.Keys[i].FieldType);
											IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName((Control)(object)this, _objFunctionArguments.Keys[i].FieldName);
											dataKeyFieldValues.FieldValuesAdd(RuntimeHelpers.GetObjectValue(iIboWebComponentByFieldName.ObjValue));
											dataKeyFieldCollection.Add(dataKeyFieldValues);
										}
										_objFunctionArguments.Data = dataKeyFieldCollection;
										if (((Page)this).Session["FunctionArgs"] != null)
										{
											((Page)this).Session["FunctionArgs"] = _objFunctionArguments;
										}
										val = Reload(ref rsMess);
										if ((int)val <= 0)
										{
											goto IL_043a;
										}
										val2 = val;
									}
								}
							}
						}
					}
				}
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
			if ((int)val2 > 0)
			{
				string rsMess2 = "";
				WFIRollbackTransaction(ref rsMess2);
				if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && _DBIdentityControl != null && Operators.CompareString(_DBIdentityControl.ObjValue.ToString(), "", false) != 0)
				{
					_DBIdentityControl.ObjValue = "";
				}
			}
			if ((Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "2", false) == 0) | (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "3", false) == 0))
			{
				_SessionVariable["_AreYouSureBlockedMessageState"] = (object)"0";
			}
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual bool IsDBIdentity(ref IIboWebComponent obj)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		Hashtable sRetColl = null;
		bool flag = false;
		try
		{
			if (Operators.CompareString(obj.IncasTag, "", false) != 0)
			{
				if (_DBIdentityControl != null && Operators.CompareString(((Control)obj).ID.ToUpper(), ((Control)_DBIdentityControl).ID.ToUpper(), false) == 0)
				{
					flag = true;
				}
				else
				{
					BaseFunctions baseFunctions = base.BaseFunctions;
					string sComando = obj.IncasTag.ToString();
					string rsMess = "";
					baseFunctions.StandardParser(sComando, ref sRetColl, ref rsMess);
					if (sRetColl.ContainsKey("IsIdentity"))
					{
						flag = Operators.CompareString(sRetColl["IsIdentity"].ToString(), "S", false) == 0;
						if (flag)
						{
							_DBIdentityControl = obj;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return flag;
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (TransactionManage)
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (TransactionManage)
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (TransactionManage && base.DbConn.TransactionOpen)
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

	protected virtual FXRETURN BeforeSaveDataBeforeBeginTransaction(ref string rsMess)
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

	protected virtual FXRETURN AfterSaveDataAfterCommit(ref string rsMess)
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
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) && Operators.CompareString(_AutoCodeKeyField, "", false) != 0)
			{
				IIboWebComponent iIboWebComponentByFieldName = GetIIboWebComponentByFieldName((Control)(object)this, _AutoCodeKeyField);
				IboWebTextBox val3 = (IboWebTextBox)(object)((iIboWebComponentByFieldName is IboWebTextBox) ? iIboWebComponentByFieldName : null);
				if (val3 != null && Operators.CompareString(val3.Text, "", false) == 0)
				{
					string text = "";
					text = ((((TextBox)val3).MaxLength != 6) ? "COUNTERS.ANAGRAFICHE.ID15CHAR" : "COUNTERS.ANAGRAFICHE.ID6CHAR");
					long CounterValue = default(long);
					val2 = GetCounterValue(text, ref CounterValue, ref rsMess);
					if ((int)val2 == 0)
					{
						val3.Text = CounterValue.ToString();
					}
					UpdatePanel parentUpdatePanel = getParentUpdatePanel((Control)(object)val3);
					if (parentUpdatePanel != null)
					{
						parentUpdatePanel.Update();
					}
				}
			}
			val2 = CheckData((IIncasTableLink)(object)this, ref _objFunctionArguments, ref rsMess);
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

	protected virtual FXRETURN CheckData(IIncasTableLink pnlDetail, ref FunctionArguments objFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Control parent = (Control)pnlDetail;
			bool flag = pnlDetail is IboWebDetailPanel;
			foreach (Control childControl in GetChildControls(parent))
			{
				Control val3 = childControl;
				if (!(val3 is IIboWebComponent))
				{
					continue;
				}
				IIboWebComponent val4 = (IIboWebComponent)val3;
				if (!(Operators.CompareString(val4.DetailPanelId, "", false) == 0 || flag))
				{
					continue;
				}
				val2 = CheckControlData(val3, ref rsMess);
				if ((int)val2 <= 0)
				{
					continue;
				}
				val = val2;
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

	protected virtual FXRETURN CheckData(Control Container, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (Control childControl in GetChildControls(Container))
			{
				Control c = childControl;
				val2 = CheckControlData(c, ref rsMess);
				if ((int)val2 <= 0)
				{
					continue;
				}
				val = val2;
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

	protected virtual FXRETURN CheckControlData(Control c, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Invalid comparison between Unknown and I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Invalid comparison between Unknown and I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Invalid comparison between Unknown and I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Invalid comparison between Unknown and I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IIboWebComponent val3 = (IIboWebComponent)(object)((c is IIboWebComponent) ? c : null);
			if (val3 == null)
			{
				goto IL_08ff;
			}
			text2 = val3.FieldDescription;
			if (Operators.CompareString(text2, "", false) == 0)
			{
				text2 = val3.FieldName;
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 = base.BaseFunctions.StandardNameFilter(text2);
				}
			}
			if (Operators.CompareString(text2, "", false) == 0)
			{
				text2 = ((Control)val3).ID;
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 = base.BaseFunctions.StandardNameFilter(text2);
				}
			}
			if (!val3.Required)
			{
				goto IL_0174;
			}
			text = ((!(val3 is IboWebImage)) ? val3.ObjValue.ToString().Trim() : ((val3.ObjValue == null) ? "" : "OK"));
			if (Operators.CompareString(text, "", false) != 0)
			{
				goto IL_0174;
			}
			rsMess = TranslateMessage("XXX", "E' obbligatorio specificare un valore per il campo '{0}'", text2);
			SetIncasFocusToControl((Control)val3);
			goto end_IL_0012;
			IL_0174:
			IboWebTextBox val4;
			if (c is IboWebTextBox)
			{
				val4 = (IboWebTextBox)c;
				if ((int)val3.ValidationRules == 1)
				{
					if (val3.Text.Trim().Length <= 0)
					{
						goto IL_053d;
					}
					val2 = base.BaseFunctions.IsValidEmail(val3.Text, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_053d;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. ", text2) + rsMess;
					SetIncasFocusToControl((Control)val3);
					val = val2;
				}
				else if ((int)val3.ValidationRules == 3)
				{
					if (val3.Text.Trim().Length <= 0)
					{
						goto IL_053d;
					}
					decimal dRet = default(decimal);
					if (BaseFunctions.IsDecimal(val3.Text, ref dRet))
					{
						val3.Text = dRet.ToString();
						val3.Text = Strings.Replace(val3.Text, ",", ".", 1, -1, (CompareMethod)0);
						goto IL_053d;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere un numero decimale.", text2);
					SetIncasFocusToControl((Control)val3);
					val = val2;
				}
				else if ((int)val3.ValidationRules == 2)
				{
					if (val3.Text.Trim().Length <= 0)
					{
						goto IL_053d;
					}
					int iRet = default(int);
					if (BaseFunctions.IsInteger(val3.Text, ref iRet))
					{
						val3.Text = iRet.ToString();
						val3.Text = Strings.Replace(val3.Text, ",", ".", 1, -1, (CompareMethod)0);
						goto IL_053d;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere un numero intero.", text2);
					SetIncasFocusToControl((Control)val3);
					val = val2;
				}
				else if ((int)val3.ValidationRules == 4)
				{
					if (val3.Text.Trim().Length <= 0)
					{
						goto IL_053d;
					}
					Regex regex = new Regex("[a-zA-Z]+");
					if (regex.IsMatch(val3.Text.Trim()))
					{
						goto IL_053d;
					}
					rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere composto solo da caratteri alfabetici.", text2);
					SetIncasFocusToControl((Control)val3);
					val = val2;
				}
				else
				{
					if ((int)val3.ValidationRules != 5 || val3.Text.Length <= 0)
					{
						goto IL_053d;
					}
					val3.Text = val3.Text.Trim().Replace(" ", "").Replace("-", "")
						.Replace("/", "")
						.Replace("\\", "");
					string text3 = val3.Text;
					if (Operators.CompareString(Strings.Left(text3, 1), "+", false) == 0)
					{
						text3 = Strings.Mid(text3, 2);
					}
					bool flag = true;
					checked
					{
						int num = text3.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (!char.IsDigit(text3[i]))
							{
								flag = false;
								break;
							}
						}
						if (!(!flag | (val3.Text.Length < 6)))
						{
							goto IL_053d;
						}
						rsMess = TranslateMessage("XXX", "Errore di validazione del campo '{0}'. Il campo deve essere un numero di telefono", text2);
						SetIncasFocusToControl((Control)val3);
						val = val2;
					}
				}
			}
			else if (c is IboWebNumeric)
			{
				IboWebNumeric iboWebNumeric = (IboWebNumeric)(object)c;
				double maxValue = iboWebNumeric.MaxValue;
				decimal? value = iboWebNumeric.Value;
				double? num2 = (value.HasValue ? new double?(Convert.ToDouble(value.GetValueOrDefault())) : null);
				if ((num2.HasValue ? new bool?(maxValue < num2.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore inferiore a {1}", text2, iboWebNumeric.MaxValue.ToString());
					SetIncasFocusToControl(c);
				}
				else
				{
					maxValue = iboWebNumeric.MinValue;
					value = iboWebNumeric.Value;
					num2 = (value.HasValue ? new double?(Convert.ToDouble(value.GetValueOrDefault())) : null);
					if (!(num2.HasValue ? new bool?(maxValue > num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						goto IL_08ff;
					}
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore superiore a {1}", text2, iboWebNumeric.MinValue.ToString());
					SetIncasFocusToControl(c);
				}
			}
			else if (c is IboWebNumericTlk)
			{
				IboWebNumericTlk val5 = (IboWebNumericTlk)c;
				double maxValue = val5.WFIMaxValue;
				double? num2 = ((RadNumericTextBox)val5).Value;
				if ((num2.HasValue ? new bool?(maxValue < num2.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore inferiore a {1}", text2, val5.WFIMaxValue.ToString());
					SetIncasFocusToControl(c);
				}
				else
				{
					maxValue = val5.WFIMinValue;
					num2 = ((RadNumericTextBox)val5).Value;
					if (!(num2.HasValue ? new bool?(maxValue > num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						goto IL_08ff;
					}
					rsMess = TranslateMessage("XXX", "Il campo '{0}' deve avere valore superiore a {1}", text2, val5.WFIMinValue.ToString());
					SetIncasFocusToControl(c);
				}
			}
			else if (c is IboWebDate2)
			{
				if (((IboWebDate2)(object)c).IsValid)
				{
					goto IL_08ff;
				}
				rsMess = TranslateMessage("XXX", "Il campo '{0}' deve contenere una data valida", text2);
				SetIncasFocusToControl(c);
			}
			else
			{
				if (!(c is IboWebDate) || ((IboWebDate)(object)c).IsValid)
				{
					goto IL_08ff;
				}
				rsMess = TranslateMessage("XXX", "Il campo '{0}' deve contenere una data valida", text2);
				SetIncasFocusToControl(c);
			}
			goto end_IL_0012;
			IL_08ff:
			val = (FXRETURN)0;
			goto end_IL_0012;
			IL_053d:
			if (!((val4.MinLength > 0) & (Operators.CompareString(val4.Text, "", false) != 0)) || val4.Text.Length >= val4.MinLength)
			{
				goto IL_08ff;
			}
			rsMess = TranslateMessage("XXX", "Il campo '{0}' deve essere lungo almeno {1} caratteri", text2, val4.MinLength.ToString());
			SetIncasFocusToControl(c);
			end_IL_0012:;
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = AssegnaWfiIdentity((Control)(object)this, ref rsMess);
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

	protected virtual FXRETURN AssegnaWfiIdentity(Control Parent, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (Control iIboWebComponentControl in GetIIboWebComponentControls(Parent))
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
						UpdatePanel parentUpdatePanel = getParentUpdatePanel((Control)obj);
						if (parentUpdatePanel != null)
						{
							parentUpdatePanel.Update();
						}
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = BeforeAnnullaClick(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = AnnullaClick(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			val2 = AfterAnnullaClick(ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	protected virtual void btnConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			CallStackAdd();
			val2 = ConfermaClick(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			text = _SessionVariable["_AreYouSureBlockedMessageState"].ToString();
			if (_AutoReleaseMemoryOnConfirm & _ReturnToCallerAfterConfirm)
			{
				string rsMess2 = "";
				ReleaseMemory(ref rsMess2);
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
			else
			{
				if (Operators.CompareString(_WarningMessageNotification, "", false) != 0)
				{
					ShowNotificationMessage(TranslateMessage("XXX", "Attenzione"), _WarningMessageNotification);
				}
				if (_ReturnToCallerAfterConfirm & (Operators.CompareString(_WarningBlockedMessage, "", false) == 0) & (Operators.CompareString(text, "0", false) == 0))
				{
					ReturnToCaller();
				}
				if (Operators.CompareString(_WarningBlockedMessage, "", false) != 0)
				{
					WriteInfoMessage(_WarningBlockedMessage);
					_SessionVariable["_WarningBlockedMessage"] = (object)_WarningBlockedMessage;
					_WarningBlockedMessage = "";
				}
			}
			CallStackRemove();
		}
	}

	protected virtual FXRETURN BeforeConfermaClick(ref string rsMess)
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

	protected virtual FXRETURN AfterConfermaClick(ref string rsMess)
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

	protected virtual FXRETURN BeforeAnnullaClick(ref string rsMess)
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

	protected virtual FXRETURN AfterAnnullaClick(ref string rsMess)
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

	protected override void Page_Init(object sender, EventArgs e)
	{
		_PersistedSessionVariableEnabled = true;
		base.Page_Init(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Page_PreRender1(object sender, EventArgs e)
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
			val2 = PreRenderPage(ref rsMess);
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

	protected virtual void Page_Unload1(object sender, EventArgs e)
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
			val2 = UnloadPage(ref rsMess);
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

	protected override void ReturnToCaller()
	{
		ReturnToCaller(bAnnulla: false);
	}

	protected override void ErroreCaricamento(bool bWithReturnToCaller, string sMess)
	{
		try
		{
			string text = "";
			text = ((Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) != 0) ? TranslateMessage("XXX", "Si è verificato un errore in fase di caricamento Form.") : TranslateMessage("XXX", "Si è verificato un errore in fase di cancellazione."));
			if (bWithReturnToCaller)
			{
				WriteErrorMessageWithReturnToCaller("", text, sMess);
			}
			else
			{
				WriteErrorMessage(text + "<br /><br />" + sMess);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual void ReturnToCaller(bool bAnnulla)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		string text3 = "";
		try
		{
			if (!base.SessionEnvironment.PersistentSessionVariables.ContainsKey("_WFIDBPAGE.LASTPAGECOUNT"))
			{
				base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGE"] = "";
			}
			if (!base.SessionEnvironment.PersistentSessionVariables.ContainsKey("_WFIDBPAGE.LASTPAGECOUNT"))
			{
				base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGECOUNT"] = 0;
			}
			text3 = base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGE"].ToString();
			int num = Conversions.ToInteger(base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGECOUNT"]);
			IboAppCallStackHandling robjCallStackHandler;
			string rsMess;
			if (!_IsInIFrame)
			{
				if (num > 5)
				{
					text = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
				}
				else
				{
					if (Operators.CompareString(_objFunctionArguments.CallerPath, "", false) == 0)
					{
						_objFunctionArguments.CallerPath = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
					}
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
				rsMess = "";
				ReleaseMemory(ref rsMess);
				num = (text3.Contains(PageName) ? ((Operators.CompareString(text3, text, false) == 0) ? checked(num + 1) : 0) : 0);
				text3 = text;
				base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGE"] = text3;
				base.SessionEnvironment.PersistentSessionVariables["_WFIDBPAGE.LASTPAGECOUNT"] = num;
				robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref text);
				return;
			}
			if (!bAnnulla)
			{
				if (base.SessionEnvironment.IFrameObjTag == null)
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					foreach (IIboWebComponent iIboWebComponentControl in GetIIboWebComponentControls((Control)(object)this))
					{
						IIboWebComponent val = iIboWebComponentControl;
						if (val.IsKey & (Operators.CompareString(val.FieldName, "", false) != 0))
						{
							dictionary.Add(val.FieldName, RuntimeHelpers.GetObjectValue(val.ObjValue));
						}
					}
					if (dictionary.Count > 0)
					{
						ReturnFromIFrame(dictionary);
					}
					else
					{
						ReturnFromIFrame("CONFERMA");
					}
				}
				else
				{
					ReturnFromIFrame(RuntimeHelpers.GetObjectValue(base.SessionEnvironment.IFrameObjTag));
				}
			}
			else if (_RaiseIFrameCloseOnDiscard)
			{
				ReturnFromIFrame("ANNULLA");
			}
			else
			{
				ReturnFromIFrame(null);
			}
			rsMess = "";
			ReleaseMemory(ref rsMess);
			robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
			rsMess = "~/WFI/Form/IdlePage.aspx";
			IboResponseRedirect(ref robjCallStackHandler, ref rsMess, RegisterPageInQueue: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected virtual FXRETURN GetCounterValue(string sContatore, ref long CounterValue, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(sContatore, "", false) == 0)
			{
				sContatore = "COUNTERS.GENERIC";
			}
			if (!base.DbConn.TransactionOpen)
			{
				flag = true;
			}
			long num = default(long);
			val = base.Parametrica.LeggiContatore(sContatore, flag, ref num, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				CounterValue = num;
				val2 = (FXRETURN)0;
			}
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN GetCounterValue(ref long CounterValue, ref string rsmess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return GetCounterValue("", ref CounterValue, ref rsmess);
	}

	protected override FXRETURN ReleaseMemory(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_SessionVariable == null || !((Operators.CompareString(_WarningBlockedMessage, "", false) == 0) & (Operators.CompareString(_SessionVariable["_AreYouSureBlockedMessageState"].ToString(), "0", false) == 0)))
			{
				goto IL_00b6;
			}
			if (_ComboQueryCache != null)
			{
				_ComboQueryCache.Clear();
			}
			if (_ComboQueryCacheTop50 != null)
			{
				_ComboQueryCacheTop50.Clear();
			}
			val = base.ReleaseMemory(ref rsMess);
			if ((int)val <= 0)
			{
				goto IL_00b6;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00b6:
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

	protected virtual bool ReturningFromDetailPage()
	{
		if (((Page)this).Request.QueryString["Returning"] != null && Operators.CompareString(((Page)this).Request.QueryString["Returning"].ToUpper(), "S", false) == 0)
		{
			return true;
		}
		return false;
	}

	protected override FXRETURN PopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = base.PopupFormCheckData(ref objPopupInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = CheckData(objPopupInfo.ContentObject, ref rsMess);
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

	public override FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = base.MasterPopupFormCheckData(ref objPopupInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = CheckData(objPopupInfo.ContentObject, ref rsMess);
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

	public override void IboMessageBox_cmdOkOnly_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		bool needToRefresh = base.SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		try
		{
			base.IboMessageBox_cmdOkOnly_Click(RuntimeHelpers.GetObjectValue(sender), e);
			if (Operators.CompareString(base.SessionEnvironment.UserMessage.Funzione.ToUpper(), "ConfirmOnInfo".ToUpper(), false) == 0 && _SessionVariable["_WarningBlockedMessage"] != null && Operators.CompareString(_SessionVariable["_WarningBlockedMessage"].ToString(), "", false) != 0)
			{
				_SessionVariable["_WarningBlockedMessage"] = (object)"";
				if (_AutoReleaseMemoryOnCancel)
				{
					string rsMess2 = "";
					ReleaseMemory(ref rsMess2);
				}
				ReturnToCaller();
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
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected virtual FXRETURN LookupQueryDecode(List<IIboWebComponent> LookupControls, IIncasTableLink pnlDetail, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Invalid comparison between Unknown and I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		Dictionary<string, DataTable> dictionary = new Dictionary<string, DataTable>();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IIboWebComponent LookupControl in LookupControls)
			{
				if (Operators.CompareString(LookupControl.SqlQueryLookup.Trim(), "", false) == 0)
				{
					continue;
				}
				string sqlQueryLookup = LookupControl.SqlQueryLookup;
				sqlQueryLookup = base.DbConn.SqlConvertForServer(sqlQueryLookup);
				sqlQueryLookup = sqlQueryLookup.Replace("  ", " ").Replace("  ", " ").Replace("  ", " ");
				Hashtable sRetColl = null;
				val = base.BaseFunctions.StandardVariableFinder("<#", "#>", sqlQueryLookup, ref sRetColl, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					IDictionaryEnumerator enumerator2 = sRetColl.GetEnumerator();
					while (true)
					{
						if (enumerator2.MoveNext())
						{
							object current2 = enumerator2.Current;
							DictionaryEntry dictionaryEntry = ((current2 != null) ? ((DictionaryEntry)current2) : default(DictionaryEntry));
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
								if (beforeImageFieldsCollection2 == null)
								{
									rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
									goto end_IL_04c6;
								}
								foreach (string key in beforeImageFieldsCollection2.Keys)
								{
									if (Operators.CompareString(key.ToUpper(), text, false) == 0)
									{
										sqlQueryLookup = sqlQueryLookup.Replace(dictionaryEntry.Value.ToString(), beforeImageFieldsCollection2[key].FieldValue.ToString());
										break;
									}
								}
								break;
							}
							case "DETAIL_RECORD":
							{
								BeforeImageFieldsCollection beforeImageFieldsCollection = get_BeforeImage(pnlDetail);
								if (beforeImageFieldsCollection == null)
								{
									rsMess = TranslateMessage("XXX", "Before image del contesto non caricato correttamente. Impossibile proseguire.");
									goto end_IL_04c6;
								}
								foreach (string key2 in beforeImageFieldsCollection.Keys)
								{
									if (Operators.CompareString(key2.ToUpper(), text, false) == 0)
									{
										sqlQueryLookup = sqlQueryLookup.Replace(dictionaryEntry.Value.ToString(), beforeImageFieldsCollection[key2].FieldValue.ToString());
										break;
									}
								}
								break;
							}
							case "CONTROLS_RECORD":
							{
								Control controlByName = GetControlByName((Control)(object)this, text);
								if (controlByName != null && controlByName is IIboWebComponent)
								{
									sqlQueryLookup = sqlQueryLookup.Replace(dictionaryEntry.Value.ToString(), ((IIboWebComponent)controlByName).ObjValue.ToString());
								}
								break;
							}
							case "SESSION_VARIABLE":
								if (!_SessionVariable.ContainsKey(text))
								{
									rsMess = TranslateMessage("XXX", "La variabile {0} non è stata trovata in sessione", text);
									goto end_IL_04c6;
								}
								sqlQueryLookup = sqlQueryLookup.Replace(dictionaryEntry.Value.ToString(), _SessionVariable[text].ToString());
								break;
							}
							continue;
						}
						DataTable dataTable = null;
						if (dictionary.ContainsKey(sqlQueryLookup))
						{
							dataTable = dictionary[sqlQueryLookup];
						}
						else
						{
							val = base.DbConn.OpenDataTable(sqlQueryLookup, ref dataTable, ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
							dictionary.Add(sqlQueryLookup, dataTable);
						}
						if (dataTable.Rows.Count > 0)
						{
							if (Operators.CompareString(LookupControl.SqlQueryLookupField, "", false) == 0)
							{
								LookupControl.ObjValue = dataTable.Rows[0][0].ToString();
							}
							else
							{
								LookupControl.ObjValue = dataTable.Rows[0][LookupControl.SqlQueryLookupField].ToString();
							}
						}
						goto IL_05a4;
						continue;
						end_IL_04c6:
						break;
					}
				}
				goto end_IL_000b;
				IL_05a4:;
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
			dictionary.Clear();
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LookupQueryDecode(IIboWebComponent LookupControl, IIncasTableLink pnlDetail, ref string rsMess)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		List<IIboWebComponent> list = new List<IIboWebComponent>();
		list.Add(LookupControl);
		return LookupQueryDecode(list, pnlDetail, ref rsMess);
	}

	protected virtual FXRETURN LookupQueryDecode(IIboWebComponent LookupControl, ref string rsMess)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		List<IIboWebComponent> list = new List<IIboWebComponent>();
		list.Add(LookupControl);
		return LookupQueryDecode(list, (IIncasTableLink)(object)this, ref rsMess);
	}

	protected virtual FXRETURN LookupQueryDecode(Control MyContainer, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (IIboWebComponent allIIboWebComponentControl in GetAllIIboWebComponentControls(MyContainer))
			{
				IIboWebComponent lookupControl = allIIboWebComponentControl;
				val = LookupQueryDecode(lookupControl, ref rsMess);
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

	protected virtual int GetActiveTabIndex(ref IboWebToolbar tlb)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		Control val = (Control)(object)tlb;
		bool flag = false;
		int result = 0;
		string text = "AjaxControlToolkit.TabPanel".ToUpper();
		while (Operators.CompareString(((object)val).GetType().ToString().ToUpper(), text, false) != 0 && !flag)
		{
			if (val.Parent == null)
			{
				flag = true;
			}
			else
			{
				val = val.Parent;
			}
		}
		if (Operators.CompareString(((object)val).GetType().ToString().ToUpper(), text, false) == 0)
		{
			result = ((ControlCollection)((TabContainer)val.Parent).Tabs).IndexOf((Control)(TabPanel)val);
		}
		return result;
	}

	protected virtual TabContainer GetActiveTabContainer(ref IboWebToolbar tlb)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		Control val = (Control)(object)tlb;
		bool flag = false;
		string text = "AjaxControlToolkit.TabPanel".ToUpper();
		while (Operators.CompareString(((object)val).GetType().ToString().ToUpper(), text, false) != 0 && !flag)
		{
			if (val.Parent == null)
			{
				flag = true;
			}
			else
			{
				val = val.Parent;
			}
		}
		if (Operators.CompareString(((object)val).GetType().ToString().ToUpper(), text, false) == 0)
		{
			return (TabContainer)val.Parent;
		}
		return null;
	}

	protected virtual void ImpostaStatoPagina(ref IboWebToolbar tlb)
	{
		try
		{
			TabContainer activeTabContainer = GetActiveTabContainer(ref tlb);
			if (activeTabContainer != null)
			{
				string pageName = PageName;
				string iD = ((Control)activeTabContainer).ID;
				object PropertyValue = GetActiveTabIndex(ref tlb);
				SetFormState(pageName, iD, "ActiveTabIndex", ref PropertyValue);
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
