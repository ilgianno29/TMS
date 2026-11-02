using System;
using System.Data;
using System.Web.UI.WebControls;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class IboMenuManagerV2 : IboMenuManagerAbstract
{
	public IboMenuManagerV2(ref WebSessionEnvironment rObjSessionEnvironment)
		: base(ref rObjSessionEnvironment)
	{
	}

	public override FXRETURN LoadFromDatabase(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Invalid comparison between Unknown and I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Invalid comparison between Unknown and I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Invalid comparison between Unknown and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			text2 = _objWebUserInfo.MenuProfileID;
			text3 = _objWebUserInfo.DesktopProfileID;
			text = "SELECT VV.VOCE AS MNUCODICE, UU.ID AS MNUID, UU.PARENTID AS MNUPARENT, UU.ORDINE, ";
			text += "VV.DESCRIZIONE, %ISNULL%(UU.TEXT,VV.TEXT) TEXT, VV.FUNZIONE, VV.TIPONODO, ";
			text += "VV.IMMAGINE, %ISNULL%(UU.TOOLTIP,VV.TOOLTIP) TOOLTIP, VV.ACTIONCODE, UU.SEPARA, VV.CSSCLASS, UU.Peso PESO ";
			text += "FROM WFI_MENU_TREE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
			text += "WHERE UU.VISIBILE='S' ";
			text += "AND VV.VISIBILE='S' ";
			text = text + "AND UU.ConfigProfileId=" + _objDbConnection.SQLFormatString(text2) + " ";
			text = _objDbConnection.SqlConvertForServer(text);
			val2 = _objDbConnection.OpenDataTable(text, ref _dt, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = TranslateMenuItems(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					text = "SELECT VV.VOCE AS MNUCODICE, UU.ID AS MNUID, ";
					text = (((int)_objDbConnection.ServerType == 0) ? (text + "CAST(UU.PARENTID AS VARCHAR(15)) AS MNUPARENT, ") : (((int)_objDbConnection.ServerType != 1) ? (text + "CAST(UU.PARENTID AS VARCHAR(15)) AS MNUPARENT, ") : (text + "CAST(UU.PARENTID AS VARCHAR2(15)) AS MNUPARENT, ")));
					text += "UU.ORDINE, VV.DESCRIZIONE, ";
					text += "%ISNULL%(UU.TEXT,VV.TEXT) TEXT, VV.FUNZIONE, ";
					text += "VV.TIPONODO, VV.IMMAGINE, ";
					text += "%ISNULL%(UU.TOOLTIP,VV.TOOLTIP) TOOLTIP, %ISNULL%(UU.AdditionalText,VV.AdditionalText) AdditionalText, ";
					text += "VV.DesktopImage, VV.ACTIONCODE, ";
					text += "UU.SEPARA, UU.AdditionalTextFormula, ";
					text += "UU.Id, UU.ConfigProfileId, UU.PESO ";
					text += "FROM WFI_DESKTOP_TREE UU INNER JOIN WFI_MENU_VOCI VV ON UU.VOCE = VV.VOCE ";
					text += "WHERE UU.VISIBILE='S' ";
					text += "AND VV.VISIBILE='S' ";
					text = text + "AND UU.ConfigProfileId=" + _objDbConnection.SQLFormatString(text3) + " ";
					text = _objDbConnection.SqlConvertForServer(text);
					val2 = _objDbConnection.OpenDataTable(text, ref _dtDeskTop, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = TranslateDesktopItems(ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							text = "SELECT * ";
							text += "FROM WFI_FUNCTIONLIST_V2 ";
							text += "WHERE 1=1 ";
							text = text + "AND ConfigProfileId=" + _objDbConnection.SQLFormatString(text2);
							val2 = _objDbConnection.OpenDataTable(text, ref _dtFunctionList, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								val2 = TranslateFunctionListItems(ref rsMess);
								val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN LoadMenuItems(ref MenuItem objMenuItem, ref DataRow drParent, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		MenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array = _dt.Select("MNUPARENT='" + drParent["MNUID"].ToString() + "'", "ORDINE ASC");
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					text = array[num]["SEPARA"].ToString();
					if (Operators.CompareString(text, "S", false) == 0)
					{
						val3 = new MenuItem();
						val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
						if ((int)val2 > 0)
						{
							break;
						}
						objMenuItem.ChildItems.Add(val3);
					}
					val3 = new MenuItem();
					array[num]["SEPARA"] = "N";
					array[num].AcceptChanges();
					val2 = MenuItemFromDataRow(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					objMenuItem.ChildItems.Add(val3);
					array[num]["SEPARA"] = text;
					array[num].AcceptChanges();
					val2 = LoadMenuItems(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN LoadMenuItemsTlk(ref RadMenuItem objMenuItem, ref DataRow drParent, ref WFIMenuNodeTree Node, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		RadMenuItem val3 = null;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			DataRow[] array;
			if (_MenuTree.Initialized)
			{
				array = Node.ChildsDataRow;
			}
			else
			{
				array = _dt.Select("MNUPARENT='" + drParent["MNUID"].ToString() + "'", "ORDINE ASC");
				Node.ChildsDataRow = array;
			}
			if (array.Length == 0)
			{
				objMenuItem.PostBack = true;
			}
			else
			{
				objMenuItem.PostBack = false;
			}
			int num = default(int);
			while (true)
			{
				if (num < array.Length)
				{
					WFIMenuNodeTree Node2;
					if (!_MenuTree.Initialized)
					{
						Node2 = new WFIMenuNodeTree();
						Node2.NodeDataRow = array[num];
						Node.Childs.Add(Node2);
					}
					else
					{
						Node2 = Node.Childs[num];
					}
					text = array[num]["SEPARA"].ToString();
					if (Operators.CompareString(text, "S", false) == 0)
					{
						val3 = new RadMenuItem();
						val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
							break;
						}
						objMenuItem.Items.Add(val3);
					}
					val3 = new RadMenuItem();
					array[num]["SEPARA"] = "N";
					val2 = MenuItemFromDataRowTlk(ref val3, ref array[num], ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						break;
					}
					if (_ViewShortcut)
					{
						string text2 = "<span class=\"Shortcut\"><%Text%></span>";
						text2 = Strings.Replace(text2, "<%Text%>", array[num]["ACTIONCODE"].ToString(), 1, -1, (CompareMethod)0);
						RadMenuItem val4;
						(val4 = val3).Text = val4.Text + text2;
					}
					objMenuItem.Items.Add(val3);
					array[num]["SEPARA"] = text;
					val2 = LoadMenuItemsTlk(ref val3, ref array[num], ref Node2, ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			val3 = null;
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
