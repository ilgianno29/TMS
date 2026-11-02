using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebToolbarConfig : IDisposable
{
	protected bool disposedValue;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected IboWebUserInfo _objWebUserInfo;

	protected IboWebToolbarInfo _objWebToolbarInfo;

	protected IboWebToolbar _objWebToolbar;

	protected bool _OnlyEnabledButtons;

	protected bool _EnableSeparator;

	protected bool _EnableLinkButton;

	public IboWebToolbar GetToolbarObject => _objWebToolbar;

	public IboWebToolbarConfig(ref IboWebToolbarInfo rObjWebToolbarInfo, ref IboWebToolbar rObjWebToolbar, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo, bool bOnlyEnabledButtons, bool bEnableSeparator, bool bEnableCaption)
	{
		disposedValue = false;
		_OnlyEnabledButtons = false;
		_EnableSeparator = true;
		_EnableLinkButton = true;
		_objWebToolbarInfo = rObjWebToolbarInfo;
		_objWebToolbar = rObjWebToolbar;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_Translator = rObjTranslator;
		_dbMain = rObjDbMain;
		_objWebUserInfo = rObjWebUserInfo;
		_OnlyEnabledButtons = bOnlyEnabledButtons;
		_EnableSeparator = bEnableSeparator;
		_EnableLinkButton = bEnableCaption;
	}

	public IboWebToolbarConfig(ref IboWebToolbarInfo rObjWebToolbarInfo, ref IboWebToolbar rObjWebToolbar, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		disposedValue = false;
		_OnlyEnabledButtons = false;
		_EnableSeparator = true;
		_EnableLinkButton = true;
		_objWebToolbarInfo = rObjWebToolbarInfo;
		_objWebToolbar = rObjWebToolbar;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_Translator = rObjTranslator;
		_dbMain = rObjDbMain;
		_objWebUserInfo = rObjWebUserInfo;
	}

	public FXRETURN LoadButtons(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Invalid comparison between Unknown and I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Invalid comparison between Unknown and I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Invalid comparison between Unknown and I4
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN nRes = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_objWebToolbar.Clear();
			int num = default(int);
			while (true)
			{
				if (num < _objWebToolbarInfo.BottoniFissiCount)
				{
					if (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_NumBot_Parent"].ToString(), "", false) == 0)
					{
						if (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["STYLEBOT"].ToString(), "0", false) == 0)
						{
							DataRow robjButtonDataRow = _objWebToolbarInfo.get_BottoneFisso(num);
							ImageButton val2 = _CreateButton(ref robjButtonDataRow, ref nRes, ref rsMess);
							if ((int)nRes > 0)
							{
								val = nRes;
								break;
							}
							if (val2 != null)
							{
								string shortcut = _objWebToolbarInfo.get_BottoneFisso(num)["Shortcut"].ToString();
								robjButtonDataRow = _objWebToolbarInfo.get_BottoneFisso(num);
								LinkButton objLnk = _CreateLinkButton(ref robjButtonDataRow, ref nRes, ref rsMess);
								if ((int)nRes > 0)
								{
									val = nRes;
									break;
								}
								if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowImage"].ToString(), "N", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowCaption"].ToString(), "S", false) == 0))
								{
									IboWebToolbar objWebToolbar = _objWebToolbar;
									IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellOnlyLink " + _objWebToolbarInfo.get_BottoneFisso(num)["CSSCLASS"].ToString(), shortcut);
									objWebToolbar.AddItem(ref item);
								}
								else if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowImage"].ToString(), "S", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowCaption"].ToString(), "S", false) == 0))
								{
									IboWebToolbar objWebToolbar2 = _objWebToolbar;
									IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellImageAndLink " + _objWebToolbarInfo.get_BottoneFisso(num)["CSSCLASS"].ToString(), shortcut);
									objWebToolbar2.AddItem(ref item);
								}
								else if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowImage"].ToString(), "S", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["TABBOT_ShowCaption"].ToString(), "N", false) == 0))
								{
									IboWebToolbar objWebToolbar3 = _objWebToolbar;
									IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellOnlyImage " + _objWebToolbarInfo.get_BottoneFisso(num)["CSSCLASS"].ToString(), shortcut);
									objWebToolbar3.AddItem(ref item);
								}
							}
						}
						else if (Operators.CompareString(_objWebToolbarInfo.get_BottoneFisso(num)["STYLEBOT"].ToString(), "1", false) == 0 && _EnableSeparator)
						{
							_objWebToolbar.AddSeparator(_objWebToolbarInfo.get_BottoneFisso(num)["IMAGEBOT"].ToString());
						}
					}
					num = checked(num + 1);
					continue;
				}
				num = 0;
				while (true)
				{
					if (num < _objWebToolbarInfo.BottoniDinamici.Rows.Count)
					{
						if (Operators.CompareString(_objWebToolbarInfo.BottoniDinamici.AsEnumerable().ElementAtOrDefault(num)["TABBOT_NumBot_Parent"].ToString(), "", false) == 0)
						{
							if (Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["STYLEBOT"].ToString(), "0", false) == 0)
							{
								DataRow robjButtonDataRow = _objWebToolbarInfo.get_BottoneDinamico(num);
								ImageButton val2 = _CreateButton(ref robjButtonDataRow, ref nRes, ref rsMess);
								if ((int)nRes > 0)
								{
									val = nRes;
									break;
								}
								if (val2 != null)
								{
									string text = "";
									robjButtonDataRow = _objWebToolbarInfo.get_BottoneDinamico(num);
									LinkButton objLnk = _CreateLinkButton(ref robjButtonDataRow, ref nRes, ref rsMess);
									if ((int)nRes > 0)
									{
										val = nRes;
										break;
									}
									List<IboWebToolbarItem> list = new List<IboWebToolbarItem>();
									DataRow[] array = _objWebToolbarInfo.BottoniDinamici.Select("TABBOT_NUMBOT_PARENT=" + _objWebToolbarInfo.BottoniDinamici.AsEnumerable().ElementAtOrDefault(num)["NUMBOT"].ToString(), "WFI_TABBot_Ordinamento ASC");
									DataRow[] array2 = array;
									int num2 = 0;
									while (true)
									{
										if (num2 < array2.Length)
										{
											DataRow robjButtonDataRow2 = array2[num2];
											ImageButton val3 = _CreateButton(ref robjButtonDataRow2, ref nRes, ref rsMess);
											if ((int)nRes > 0)
											{
												val = nRes;
												goto end_IL_07d1;
											}
											if (val3 != null)
											{
												LinkButton objLnk2 = _CreateLinkButton(ref robjButtonDataRow2, ref nRes, ref rsMess);
												if ((int)nRes > 0)
												{
													val = nRes;
													goto end_IL_07d1;
												}
												text = robjButtonDataRow2["Shortcut"].ToString();
												list.Add(new IboWebToolbarItem(val3, objLnk2, "ToolbarCellSubMenu " + _objWebToolbarInfo.get_BottoneDinamico(num)["CSSCLASS"].ToString(), text));
											}
											num2 = checked(num2 + 1);
											continue;
										}
										text = _objWebToolbarInfo.get_BottoneDinamico(num)["Shortcut"].ToString();
										if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowImage"].ToString(), "N", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowCaption"].ToString(), "S", false) == 0))
										{
											IboWebToolbar objWebToolbar4 = _objWebToolbar;
											IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellOnlyLink " + _objWebToolbarInfo.get_BottoneDinamico(num)["CSSCLASS"].ToString(), text, list);
											objWebToolbar4.AddItem(ref item);
										}
										else if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowImage"].ToString(), "S", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowCaption"].ToString(), "S", false) == 0))
										{
											IboWebToolbar objWebToolbar5 = _objWebToolbar;
											IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellImageAndLink " + _objWebToolbarInfo.get_BottoneDinamico(num)["CSSCLASS"].ToString(), text, list);
											objWebToolbar5.AddItem(ref item);
										}
										else if ((Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowImage"].ToString(), "S", false) == 0) & (Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["TABBOT_ShowCaption"].ToString(), "N", false) == 0))
										{
											IboWebToolbar objWebToolbar6 = _objWebToolbar;
											IboWebToolbarItem item = new IboWebToolbarItem(val2, objLnk, "ToolbarCellOnlyImage " + _objWebToolbarInfo.get_BottoneDinamico(num)["CSSCLASS"].ToString(), text, list);
											objWebToolbar6.AddItem(ref item);
										}
										break;
									}
								}
							}
							else if (Operators.CompareString(_objWebToolbarInfo.get_BottoneDinamico(num)["STYLEBOT"].ToString(), "1", false) == 0 && _EnableSeparator)
							{
								_objWebToolbar.AddSeparator(_objWebToolbarInfo.get_BottoneDinamico(num)["IMAGEBOT"].ToString());
							}
						}
						num = checked(num + 1);
						continue;
					}
					val = (FXRETURN)0;
					break;
					continue;
					end_IL_07d1:
					break;
				}
				break;
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

	private ImageButton _CreateButton(ref DataRow robjButtonDataRow, ref FXRETURN nRes, ref string rsMess)
	{
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected I4, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		ImageButton val = null;
		ImageButton result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			nRes = (FXRETURN)3;
			rsMess = "";
			val = new ImageButton();
			((Control)val).ID = "btn" + robjButtonDataRow["NUMBOT"].ToString();
			((Image)val).AlternateText = _Translator.TranslateMessage("TOOLBAR", robjButtonDataRow["CAPTIONBOT"].ToString(), new string[0]);
			val.CommandArgument = robjButtonDataRow["ARGUMENTS"].ToString();
			val.CommandName = robjButtonDataRow["KEYBOT"].ToString();
			if (Operators.CompareString(val.CommandName, "GROUPBUTTONS", false) == 0)
			{
				val.OnClientClick = "return false;";
				((WebControl)val).Attributes["Data-jq-dropdown"] = "#jq-dropdown-btn" + robjButtonDataRow["NUMBOT"].ToString();
			}
			((WebControl)val).CssClass = "ToolbarButtonControl";
			((WebControl)val).Attributes["ProgId"] = robjButtonDataRow["ProgId"].ToString();
			((WebControl)val).CssClass = "ToolbarButtonControl";
			((Image)val).ImageUrl = robjButtonDataRow["IMAGEBOT"].ToString();
			((WebControl)val).ToolTip = _Translator.TranslateMessage("TOOLBAR", (Operators.CompareString(robjButtonDataRow["TABBOT_TOOLTIPBOT"].ToString(), "", false) != 0) ? robjButtonDataRow["TABBOT_TOOLTIPBOT"].ToString() : robjButtonDataRow["TOOLTIPBOT"].ToString(), new string[0]);
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(robjButtonDataRow["TABBOT_PESBOT"])))
			{
				if (_OnlyEnabledButtons)
				{
					val = null;
				}
				else
				{
					val.Enabled = false;
					((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIDisabled", "");
					ImageButton val2;
					((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIDisabled";
				}
			}
			else if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(robjButtonDataRow["TABBOT_PESBOT"])) <= _objWebUserInfo.Peso)
			{
				val.Enabled = true;
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIEnabled", "");
				ImageButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIEnabled";
			}
			else
			{
				val.Enabled = false;
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIDisabled", "");
				ImageButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIDisabled";
			}
			if (Operators.CompareString(robjButtonDataRow["TABBOT_ShowImage"].ToString(), "N", false) == 0)
			{
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIHidden", "");
				ImageButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIHidden";
			}
			nRes = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			nRes = (FXRETURN)(int)_ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	private LinkButton _CreateLinkButton(ref DataRow robjButtonDataRow, ref FXRETURN nRes, ref string rsMess)
	{
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected I4, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		LinkButton val = null;
		LinkButton result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			nRes = (FXRETURN)3;
			rsMess = "";
			val = new LinkButton();
			((Control)val).ID = "lnk" + robjButtonDataRow["NUMBOT"].ToString();
			val.Text = _Translator.TranslateMessage("TOOLBAR", (Operators.CompareString(robjButtonDataRow["TABBOT_CAPTIONBOT"].ToString(), "", false) != 0) ? robjButtonDataRow["TABBOT_CAPTIONBOT"].ToString() : robjButtonDataRow["CAPTIONBOT"].ToString(), new string[0]);
			if (_EnableLinkButton & (Operators.CompareString(robjButtonDataRow["TABBOT_ShowCaption"].ToString(), "S", false) == 0))
			{
				val.Text = _Translator.TranslateMessage("TOOLBAR", (Operators.CompareString(robjButtonDataRow["TABBOT_CAPTIONBOT"].ToString(), "", false) != 0) ? robjButtonDataRow["TABBOT_CAPTIONBOT"].ToString() : robjButtonDataRow["CAPTIONBOT"].ToString(), new string[0]);
			}
			val.CommandArgument = robjButtonDataRow["ARGUMENTS"].ToString();
			val.CommandName = robjButtonDataRow["KEYBOT"].ToString();
			if (Operators.CompareString(val.CommandName, "GROUPBUTTONS", false) == 0)
			{
				val.OnClientClick = "return false;";
				((WebControl)val).Attributes["Data-jq-dropdown"] = "#jq-dropdown-btn" + robjButtonDataRow["NUMBOT"].ToString();
			}
			((WebControl)val).CssClass = "ToolbarLinkButtonControl";
			if (Operators.CompareString(robjButtonDataRow["ProgId"].ToString(), "", false) != 0)
			{
				((WebControl)val).Attributes.Add("ProgId", robjButtonDataRow["ProgId"].ToString());
			}
			if (Operators.CompareString(robjButtonDataRow["TOOLTIPBOT"].ToString().ToUpper(), robjButtonDataRow["CAPTIONBOT"].ToString().ToUpper(), false) != 0)
			{
				((WebControl)val).ToolTip = _Translator.TranslateMessage("TOOLBAR", (Operators.CompareString(robjButtonDataRow["TABBOT_TOOLTIPBOT"].ToString(), "", false) != 0) ? robjButtonDataRow["TABBOT_TOOLTIPBOT"].ToString() : robjButtonDataRow["TOOLTIPBOT"].ToString(), new string[0]);
			}
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(robjButtonDataRow["TABBOT_PESBOT"])))
			{
				((WebControl)val).Enabled = false;
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIDisabled", "");
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIEnabled", "");
				LinkButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIDisabled";
			}
			else if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(robjButtonDataRow["TABBOT_PESBOT"])) <= _objWebUserInfo.Peso)
			{
				((WebControl)val).Enabled = true;
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIEnabled", "");
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIDisabled", "");
				LinkButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIEnabled";
			}
			else
			{
				((WebControl)val).Enabled = false;
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIEnabled", "");
				((WebControl)val).CssClass = ((WebControl)val).CssClass.Replace("WFIDisabled", "");
				LinkButton val2;
				((WebControl)(val2 = val)).CssClass = ((WebControl)val2).CssClass + " WFIDisabled";
			}
			nRes = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			nRes = (FXRETURN)(int)_ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
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
			_objWebToolbarInfo = null;
			_objWebToolbar = null;
		}
		disposedValue = true;
	}
}
