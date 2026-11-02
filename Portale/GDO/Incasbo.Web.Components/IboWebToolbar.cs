using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Msdn;
using Telerik.Web.UI;

namespace Incasbo.Web.Components;

public class IboWebToolbar : UserControl
{
	public delegate void ToolbarClickEventHandler(object sender, IboWebToolbarEventArgs e);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolbarContextMenu")]
	private ContextMenu _ToolbarContextMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolbarContextMenuTlk")]
	private RadContextMenu _ToolbarContextMenuTlk;

	protected int _ButtonHeight;

	protected int _ButtonWidth;

	protected int _SeparatorHeight;

	protected int _SeparatorWidth;

	protected string _SeparatorImageUrl;

	protected string _CssClassPanel;

	protected string _CssClassButton;

	protected string _CssClassTable;

	public static readonly string Aggiorna = "AGGIORNA";

	public static readonly string Ricerca = "RICERCA";

	public static readonly string AnnullaFiltri = "ANNULLAFILTRI";

	public static readonly string AnnullaPrefiltri = "ANNULLAPREFILTRI";

	public static readonly string Visualizza = "VISUALIZZA";

	public static readonly string Inserisci = "INSERIMENTO";

	public static readonly string Modifica = "MODIFICA";

	public static readonly string Cancella = "CANCELLAZIONE";

	public static readonly string Duplica = "DUPLICAZIONE";

	public static readonly string Stampa = "STAMPA";

	public static readonly string StampaVeloce = "STAMPAVELOCE";

	public static readonly string EsportazioneDati = "EXPDATI";

	protected List<IboWebToolbarItem> _ToolbarItems;

	[field: AccessedThroughProperty("pnlToolbar")]
	protected virtual Panel pnlToolbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tblToolbar")]
	protected virtual Table tblToolbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ContextMenu ToolbarContextMenu
	{
		[CompilerGenerated]
		get
		{
			return _ToolbarContextMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			CommandEventHandler val = new CommandEventHandler(ToolbarContextMenu_ItemCommand);
			ContextMenu toolbarContextMenu = _ToolbarContextMenu;
			if (toolbarContextMenu != null)
			{
				toolbarContextMenu.ItemCommand -= val;
			}
			_ToolbarContextMenu = value;
			toolbarContextMenu = _ToolbarContextMenu;
			if (toolbarContextMenu != null)
			{
				toolbarContextMenu.ItemCommand += val;
			}
		}
	}

	protected virtual RadContextMenu ToolbarContextMenuTlk
	{
		[CompilerGenerated]
		get
		{
			return _ToolbarContextMenuTlk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadMenuEventHandler val = new RadMenuEventHandler(ToolbarContextMenuTlk_ItemClick);
			RadContextMenu toolbarContextMenuTlk = _ToolbarContextMenuTlk;
			if (toolbarContextMenuTlk != null)
			{
				((RadMenu)toolbarContextMenuTlk).ItemClick -= val;
			}
			_ToolbarContextMenuTlk = value;
			toolbarContextMenuTlk = _ToolbarContextMenuTlk;
			if (toolbarContextMenuTlk != null)
			{
				((RadMenu)toolbarContextMenuTlk).ItemClick += val;
			}
		}
	}

// Proprieta' VB con parametro, convertita in metodi
	public bool get_SetButtonVisible(string ProgId)
	{
		bool result = default(bool);
		try
		{
			Control controlByName = ((WFIPage)(object)((Control)this).Page).GetControlByName((Control)(object)this, Strings.Replace(ProgId, ".", "_", 1, -1, (CompareMethod)0));
			if (controlByName != null)
			{
				result = controlByName.Visible;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void set_SetButtonVisible(string ProgId, bool value)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			Control controlByName = ((WFIPage)(object)((Control)this).Page).GetControlByName((Control)(object)this, Strings.Replace(ProgId, ".", "_", 1, -1, (CompareMethod)0));
			if (controlByName != null)
			{
				controlByName.Visible = value;
			}
			foreach (RadMenuItem item in (StateManagedCollection)((RadMenu)ToolbarContextMenuTlk).Items)
			{
				RadMenuItem val = item;
				if (Operators.CompareString(val.Value.ToUpper(), ("cmi" + ProgId).ToUpper(), false) == 0)
				{
					((ControlItem)val).Visible = value;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}


// Proprieta' VB con parametro, convertita in metodi
	public bool get_SetButtonEnabled(string ProgId)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		bool result = default(bool);
		try
		{
			WebControl val = (WebControl)((WFIPage)(object)((Control)this).Page).GetControlByName((Control)(object)this, Strings.Replace(ProgId, ".", "_", 1, -1, (CompareMethod)0));
			if (val != null)
			{
				result = val.Enabled;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void set_SetButtonEnabled(string ProgId, bool value)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		try
		{
			WebControl val = (WebControl)((WFIPage)(object)((Control)this).Page).GetControlByName((Control)(object)this, Strings.Replace(ProgId, ".", "_", 1, -1, (CompareMethod)0));
			if (val != null)
			{
				val.Enabled = value;
			}
			foreach (RadMenuItem item in (StateManagedCollection)((RadMenu)ToolbarContextMenuTlk).Items)
			{
				RadMenuItem val2 = item;
				if (Operators.CompareString(val2.Value.ToUpper(), ("cmi" + ProgId).ToUpper(), false) == 0)
				{
					((ControlItem)val2).Enabled = value;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}


	public int ButtonHeight
	{
		get
		{
			if (_ButtonHeight == 0)
			{
				_ButtonHeight = 60;
			}
			return _ButtonHeight;
		}
		set
		{
			_ButtonHeight = value;
		}
	}

	public string CssClassPanel
	{
		get
		{
			return _CssClassPanel;
		}
		set
		{
			_CssClassPanel = value;
			((WebControl)pnlToolbar).CssClass = _CssClassPanel;
		}
	}

	public string CssClassTable
	{
		get
		{
			return _CssClassTable;
		}
		set
		{
			_CssClassTable = value;
			((WebControl)tblToolbar).CssClass = _CssClassTable;
		}
	}

	public string CssClassButton
	{
		get
		{
			return _CssClassButton;
		}
		set
		{
			_CssClassButton = value;
		}
	}

	public int ButtonWidth
	{
		get
		{
			if (_ButtonWidth == 0)
			{
				_ButtonWidth = 60;
			}
			return _ButtonWidth;
		}
		set
		{
			_ButtonWidth = value;
		}
	}

	public int SeparatorHeight
	{
		get
		{
			if (_SeparatorHeight == 0)
			{
				_SeparatorHeight = 60;
			}
			return _SeparatorHeight;
		}
		set
		{
			_SeparatorHeight = value;
		}
	}

	public int SeparatorWidth
	{
		get
		{
			if (_SeparatorWidth == 0)
			{
				_SeparatorWidth = 20;
			}
			return _SeparatorWidth;
		}
		set
		{
			_SeparatorWidth = value;
		}
	}

	public ContextMenu ContextMenu => ToolbarContextMenu;

	public RadContextMenu ContextMenuTlk => ToolbarContextMenuTlk;

	public virtual bool Enabled
	{
		get
		{
			return ((WebControl)pnlToolbar).Enabled;
		}
		set
		{
			((WebControl)pnlToolbar).Enabled = value;
			foreach (IboWebToolbarItem toolbarItem in _ToolbarItems)
			{
				((WebControl)toolbarItem.lnk).Enabled = value;
				toolbarItem.btn.Enabled = value;
				if (value)
				{
					((WebControl)toolbarItem.lnk).CssClass = ((WebControl)toolbarItem.lnk).CssClass.Replace("WFIEnabled", "");
					((WebControl)toolbarItem.lnk).CssClass = ((WebControl)toolbarItem.lnk).CssClass.Replace("WFIDisabled", "");
					LinkButton lnk;
					((WebControl)(lnk = toolbarItem.lnk)).CssClass = ((WebControl)lnk).CssClass + " WFIEnabled";
					((WebControl)toolbarItem.btn).CssClass = ((WebControl)toolbarItem.btn).CssClass.Replace("WFIEnabled", "");
					((WebControl)toolbarItem.btn).CssClass = ((WebControl)toolbarItem.btn).CssClass.Replace("WFIDisabled", "");
					ImageButton btn;
					((WebControl)(btn = toolbarItem.btn)).CssClass = ((WebControl)btn).CssClass + " WFIEnabled";
				}
				else
				{
					((WebControl)toolbarItem.lnk).CssClass = ((WebControl)toolbarItem.lnk).CssClass.Replace("WFIEnabled", "");
					((WebControl)toolbarItem.lnk).CssClass = ((WebControl)toolbarItem.lnk).CssClass.Replace("WFIDisabled", "");
					LinkButton lnk;
					((WebControl)(lnk = toolbarItem.lnk)).CssClass = ((WebControl)lnk).CssClass + " WFIDisabled";
					((WebControl)toolbarItem.btn).CssClass = ((WebControl)toolbarItem.btn).CssClass.Replace("WFIEnabled", "");
					((WebControl)toolbarItem.btn).CssClass = ((WebControl)toolbarItem.btn).CssClass.Replace("WFIDisabled", "");
					ImageButton btn;
					((WebControl)(btn = toolbarItem.btn)).CssClass = ((WebControl)btn).CssClass + " WFIDisabled";
				}
			}
		}
	}

	public string GetShortcutSHIFTInfo
	{
		get
		{
			string text = "";
			try
			{
				foreach (IboWebToolbarItem toolbarItem in _ToolbarItems)
				{
					if (!((Operators.CompareString(toolbarItem.ShortCut, "", false) != 0) & (Operators.CompareString(toolbarItem.ProgId, "", false) != 0)))
					{
						continue;
					}
					string[] array = toolbarItem.ShortCut.Split(new char[1] { '-' });
					if (array.GetUpperBound(0) > 0)
					{
						if (Operators.CompareString(array[0].ToUpper(), "S", false) == 0)
						{
							text = text + array[1] + "=" + toolbarItem.ProgId + ";";
						}
					}
					else
					{
						text = text + toolbarItem.ShortCut + "=" + toolbarItem.ProgId + ";";
					}
				}
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

	public string GetShortcutCTRLInfo
	{
		get
		{
			string text = "";
			try
			{
				foreach (IboWebToolbarItem toolbarItem in _ToolbarItems)
				{
					if ((Operators.CompareString(toolbarItem.ShortCut, "", false) != 0) & (Operators.CompareString(toolbarItem.ProgId, "", false) != 0))
					{
						string[] array = toolbarItem.ShortCut.Split(new char[1] { '-' });
						if (array.GetUpperBound(0) > 0 && Operators.CompareString(array[0].ToUpper(), "C", false) == 0)
						{
							text = text + array[1] + "=" + toolbarItem.ProgId + ";";
						}
					}
				}
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

	public string GetShortcutInfoHtml
	{
		get
		{
			string text = "";
			try
			{
				text += "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>SHIFT + S</strong></td><td style='padding:0px;margin:0px;'>Seleziona tutto (se griglia in multiselezione)</td></tr>";
				text += "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>SHIFT + D</strong></td><td style='padding:0px;margin:0px;'>Deseleziona tutto</td></tr>";
				text += "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>SHIFT + Q</strong></td><td style='padding:0px;margin:0px;'>Filtro veloce (se attivo)</td></tr>";
				text += "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>SHIFT + H</strong></td><td style='padding:0px;margin:0px;'>Mostra questa schermata di help</td></tr>";
				foreach (IboWebToolbarItem toolbarItem in _ToolbarItems)
				{
					if ((Operators.CompareString(toolbarItem.ShortCut, "", false) != 0) & (Operators.CompareString(toolbarItem.ProgId, "", false) != 0))
					{
						string[] array = toolbarItem.ShortCut.Split(new char[1] { '-' });
						text = ((array.GetUpperBound(0) <= 0) ? (text + "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>SHIFT + " + toolbarItem.ShortCut + "</strong></td><td style='padding:0px;margin:0px;'>" + ((WebControl)toolbarItem.btn).ToolTip + "</td></tr>") : (text + "<tr><td style='padding:0px;margin:0px;padding-right:20px;'><strong>" + ((Operators.CompareString(array[0], "C", false) == 0) ? "CTRL" : "SHIFT") + " + " + array[1] + "</strong></td><td style='padding:0px;margin:0px;'>" + ((WebControl)toolbarItem.btn).ToolTip + "</td></tr>"));
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = "<table style='border-collapse:collapse;padding:0px;margin:0px;'>" + text + "</table>";
				}
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

	public event ToolbarClickEventHandler ToolbarClick;

	public IboWebToolbar()
	{
		((Control)this).Init += Page_Init;
		_CssClassPanel = "";
		_CssClassButton = "";
		_CssClassTable = "";
		_ToolbarItems = new List<IboWebToolbarItem>();
		_ButtonHeight = 48;
		_ButtonWidth = 48;
		_SeparatorHeight = 48;
		_SeparatorWidth = 20;
	}

	public void Clear()
	{
		tblToolbar.Rows.Clear();
		((CollectionBase)(object)ContextMenu.ContextMenuItems).Clear();
		((StateManagedCollection)((RadMenu)ContextMenuTlk).Items).Clear();
	}

	public void AddItem(ref IboWebToolbarItem item)
	{
		_ToolbarItems.Add(item);
		IboWebToolbarItem iboWebToolbarItem;
		ImageButton rObjImageButton = (iboWebToolbarItem = item).btn;
		IboWebToolbarItem iboWebToolbarItem2;
		LinkButton lnk = (iboWebToolbarItem2 = item).lnk;
		_AddItem(ref item, ref rObjImageButton, ref lnk, item.ItemCssClass, item.SubItems);
		iboWebToolbarItem2.lnk = lnk;
		iboWebToolbarItem.btn = rObjImageButton;
	}

	protected void _AddItem(ref IboWebToolbarItem item, ref ImageButton rObjImageButton, ref LinkButton lnk, string ItemCssClass, List<IboWebToolbarItem> SubItems)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		if (tblToolbar.Rows.Count == 0)
		{
			tblToolbar.Rows.Add(new TableRow());
		}
		TableCell val = new TableCell();
		((WebControl)val).CssClass = _CssClassButton;
		Panel val2 = new Panel();
		((WebControl)val2).CssClass = ItemCssClass;
		if (Operators.CompareString(((WebControl)rObjImageButton).Attributes["ProgId"], "", false) != 0)
		{
			((Control)val2).ID = Strings.Replace(((WebControl)rObjImageButton).Attributes["ProgId"], ".", "_", 1, -1, (CompareMethod)0);
			item.ProgId = ((Control)val2).ID;
			Panel val3;
			((WebControl)(val3 = val2)).CssClass = ((WebControl)val3).CssClass + " WFIToolbarButton_" + Strings.Replace(((WebControl)rObjImageButton).Attributes["ProgId"], ".", "_", 1, -1, (CompareMethod)0);
		}
		HtmlGenericControl val4 = new HtmlGenericControl("div");
		((Control)val2).Controls.Add((Control)(object)val4);
		((WebControl)rObjImageButton).Height = (System.Web.UI.WebControls.Unit)(_ButtonHeight);
		((WebControl)rObjImageButton).Width = (System.Web.UI.WebControls.Unit)(_ButtonWidth);
		((Control)val4).Controls.Add((Control)(object)rObjImageButton);
		((Control)val).Controls.Add((Control)(object)val2);
		tblToolbar.Rows[0].Cells.Add(val);
		rObjImageButton.Click += new ImageClickEventHandler(ButtonClick);
		((Control)pnlToolbar).Visible = true;
		((Control)val4).Controls.Add((Control)(object)lnk);
		lnk.Click += LinkButtonClick;
		Panel val5 = null;
		HtmlGenericControl val6 = null;
		foreach (IboWebToolbarItem SubItem in SubItems)
		{
			item = SubItem;
			if (((Control)pnlToolbar).FindControl("jq-dropdown-" + ((Control)rObjImageButton).ID) == null)
			{
				if (val5 == null)
				{
					val5 = new Panel();
					val6 = new HtmlGenericControl();
					((Control)val5).ID = "jq-dropdown-" + ((Control)rObjImageButton).ID;
					((Control)val5).ClientIDMode = (ClientIDMode)3;
					((WebControl)val5).CssClass = "jq-dropdown jq-dropdown-tip";
					val6.TagName = "ul";
					((HtmlControl)val6).Attributes.Add("class", "jq-dropdown-menu");
					((Control)val5).Controls.Add((Control)(object)val6);
				}
				((Control)pnlToolbar).Controls.Add((Control)(object)val5);
			}
			HtmlGenericControl val7 = new HtmlGenericControl();
			val7.TagName = "li";
			((Control)val6).Controls.Add((Control)(object)val7);
			LinkButton val8 = new LinkButton();
			((Control)val8).ID = "jq-dropdown-lnk-" + ((Control)item.btn).ID;
			val8.CommandArgument = item.btn.CommandArgument;
			val8.CommandName = item.btn.CommandName;
			val8.Click += LinkSubItemButtonClick;
			((Control)val7).Controls.Add((Control)(object)val8);
			Panel val9 = new Panel();
			((Control)val8).Controls.Add((Control)(object)val9);
			Image val10 = new Image();
			val10.ImageUrl = ((Image)item.btn).ImageUrl;
			((Control)val9).Controls.Add((Control)(object)val10);
			Literal val11 = new Literal();
			val11.Text = ((Operators.CompareString(item.lnk.Text, "", false) != 0) ? item.lnk.Text : ((WebControl)item.btn).ToolTip);
			((Control)val9).Controls.Add((Control)(object)val11);
		}
		ContextMenuItem val12 = new ContextMenuItem(((WebControl)rObjImageButton).ToolTip, rObjImageButton.CommandName, rObjImageButton.CommandArgument);
		val12.Enabled = rObjImageButton.Enabled;
		ToolbarContextMenu.ContextMenuItems.Add(val12);
		IboWebRadMenuItem val13 = new IboWebRadMenuItem();
		if (Operators.CompareString(((WebControl)rObjImageButton).Attributes["ProgId"], "", false) != 0)
		{
			((RadMenuItem)val13).Value = "cmi" + Strings.Replace(((WebControl)rObjImageButton).Attributes["ProgId"], ".", "_", 1, -1, (CompareMethod)0);
			((WebControl)rObjImageButton).Attributes.Remove("ProgId");
			((WebControl)lnk).Attributes.Remove("ProgId");
		}
		else
		{
			((RadMenuItem)val13).Value = "";
		}
		if (Operators.CompareString(lnk.Text, "", false) != 0)
		{
			((RadMenuItem)val13).Text = lnk.Text;
			((WebControl)val13).ToolTip = ((WebControl)lnk).ToolTip;
		}
		else
		{
			((RadMenuItem)val13).Text = ((WebControl)rObjImageButton).ToolTip;
		}
		val13.CommandName = rObjImageButton.CommandName;
		val13.CommandArgument = rObjImageButton.CommandArgument;
		((ControlItem)val13).Enabled = rObjImageButton.Enabled;
		((RadMenuItem)val13).ImageUrl = ((Image)rObjImageButton).ImageUrl;
		if (SubItems.Count > 0)
		{
			((RadMenuItem)val13).PostBack = false;
			foreach (IboWebToolbarItem SubItem2 in SubItems)
			{
				item = SubItem2;
				IboWebRadMenuItem val14 = new IboWebRadMenuItem();
				if (Operators.CompareString(((WebControl)item.btn).Attributes["ProgId"], "", false) != 0)
				{
					((RadMenuItem)val14).Value = "cmi" + Strings.Replace(((WebControl)item.btn).Attributes["ProgId"], ".", "_", 1, -1, (CompareMethod)0);
					((WebControl)item.btn).Attributes.Remove("ProgId");
					((WebControl)item.lnk).Attributes.Remove("ProgId");
				}
				else
				{
					((RadMenuItem)val14).Value = "";
				}
				if (Operators.CompareString(item.lnk.Text, "", false) != 0)
				{
					((RadMenuItem)val14).Text = item.lnk.Text;
					((WebControl)val14).ToolTip = ((WebControl)item.lnk).ToolTip;
				}
				else
				{
					((RadMenuItem)val14).Text = ((WebControl)item.btn).ToolTip;
				}
				val14.CommandName = item.btn.CommandName;
				val14.CommandArgument = item.btn.CommandArgument;
				((ControlItem)val14).Enabled = item.btn.Enabled;
				((RadMenuItem)val14).ImageUrl = ((Image)item.btn).ImageUrl;
				((RadMenuItem)val13).Items.Add((RadMenuItem)(object)val14);
			}
		}
		((RadMenu)ToolbarContextMenuTlk).Items.Add((RadMenuItem)(object)val13);
	}

	protected void _AddSubItems(ref IboWebToolbarItem item)
	{
	}

	public void AddSeparator(string SeparatorImageUrl)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		Image val = new Image();
		if (tblToolbar.Rows.Count == 0)
		{
			tblToolbar.Rows.Add(new TableRow());
		}
		TableCell val2 = new TableCell();
		((WebControl)val2).CssClass = _CssClassButton;
		HtmlGenericControl val3 = new HtmlGenericControl("div");
		if (Operators.CompareString(SeparatorImageUrl, "", false) == 0)
		{
			((WebControl)val).Height = (System.Web.UI.WebControls.Unit)(0);
			((WebControl)val).Width = (System.Web.UI.WebControls.Unit)(0);
		}
		else
		{
			((WebControl)val).Height = (System.Web.UI.WebControls.Unit)(_SeparatorHeight);
			((WebControl)val).Width = (System.Web.UI.WebControls.Unit)(_SeparatorWidth);
		}
		((WebControl)val).CssClass = "";
		val.ImageUrl = SeparatorImageUrl;
		((WebControl)val2).CssClass = CssClassButton + "Separator";
		if (Operators.CompareString(SeparatorImageUrl, "", false) != 0)
		{
			((Control)val3).Controls.Add((Control)(object)val);
		}
		((Control)val2).Controls.Add((Control)(object)val3);
		tblToolbar.Rows[0].Cells.Add(val2);
		((Control)pnlToolbar).Visible = true;
		ToolbarContextMenu.ContextMenuItems.Add(new ContextMenuItem());
		if (((StateManagedCollection)((RadMenu)ToolbarContextMenuTlk).Items).Count <= 0 || !((RadMenu)ToolbarContextMenuTlk).Items[checked(((StateManagedCollection)((RadMenu)ToolbarContextMenuTlk).Items).Count - 1)].IsSeparator)
		{
			IboWebRadMenuItem val4 = new IboWebRadMenuItem();
			((RadMenuItem)val4).IsSeparator = true;
			((RadMenu)ToolbarContextMenuTlk).Items.Add((RadMenuItem)(object)val4);
		}
	}

	private void ButtonClick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		ImageButton val = (ImageButton)sender;
		ToolbarClick?.Invoke(this, new IboWebToolbarEventArgs(((Control)val).ID, val.CommandName, val.CommandArgument));
	}

	private void LinkButtonClick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		LinkButton val = (LinkButton)sender;
		ToolbarClick?.Invoke(this, new IboWebToolbarEventArgs(((Control)val).ID, val.CommandName, val.CommandArgument));
	}

	private void LinkSubItemButtonClick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		LinkButton val = (LinkButton)sender;
		ToolbarClick?.Invoke(this, new IboWebToolbarEventArgs(((Control)val).ID, val.CommandName, val.CommandArgument));
	}

	private void Page_Init(object sender, EventArgs e)
	{
		_SeparatorImageUrl = "images/toolbar/separatore.png";
	}

	protected void ToolbarContextMenu_ItemCommand(object sender, CommandEventArgs e)
	{
		ToolbarClick?.Invoke(this, new IboWebToolbarEventArgs("", e.CommandName, e.CommandArgument.ToString()));
	}

	private void ToolbarContextMenuTlk_ItemClick(object sender, RadMenuEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string commandName = ((IboWebRadMenuItem)e.Item).CommandName;
			string commandArgument = ((IboWebRadMenuItem)e.Item).CommandArgument;
			ToolbarClick?.Invoke(this, new IboWebToolbarEventArgs("", commandName, commandArgument));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
