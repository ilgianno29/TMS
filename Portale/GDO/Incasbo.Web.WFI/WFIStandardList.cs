using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIStandardList : WFIPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnListViewFiltro")]
	private ImageButton _btnListViewFiltro;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnListViewAggiorna")]
	private ImageButton _btnListViewAggiorna;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lvContratti")]
	private ListView _lvContratti;

	protected string _ssqlMain;

	protected string _ssqlFiltro;

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SqlDataSource1")]
	protected virtual SqlDataSource SqlDataSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewContainer")]
	protected virtual Panel pnlListViewContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewTitle")]
	protected virtual Panel pnlListViewTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblListViewTitle")]
	protected virtual IboWebLabel lblListViewTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewFilter")]
	protected virtual Panel pnlListViewFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblListViewFilter")]
	protected virtual IboWebLabel lblListViewFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtListViewFiltro")]
	protected virtual IboWebTextBox txtListViewFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ImageButton btnListViewFiltro
	{
		[CompilerGenerated]
		get
		{
			return _btnListViewFiltro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(btnListViewFiltro_Click);
			ImageButton val2 = _btnListViewFiltro;
			if (val2 != null)
			{
				val2.Click -= val;
			}
			_btnListViewFiltro = value;
			val2 = _btnListViewFiltro;
			if (val2 != null)
			{
				val2.Click += val;
			}
		}
	}

	protected virtual ImageButton btnListViewAggiorna
	{
		[CompilerGenerated]
		get
		{
			return _btnListViewAggiorna;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(btnListViewAggiorna_Click);
			ImageButton val2 = _btnListViewAggiorna;
			if (val2 != null)
			{
				val2.Click -= val;
			}
			_btnListViewAggiorna = value;
			val2 = _btnListViewAggiorna;
			if (val2 != null)
			{
				val2.Click += val;
			}
		}
	}

	[field: AccessedThroughProperty("pnlListViewBody")]
	protected virtual Panel pnlListViewBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lvPanelUpdate")]
	protected virtual UpdatePanel lvPanelUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ListView lvContratti
	{
		[CompilerGenerated]
		get
		{
			return _lvContratti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lvContratti_SelectedIndexChanged;
			EventHandler<ListViewSelectEventArgs> eventHandler2 = lvContratti_SelectedIndexChanging;
			ListView val = _lvContratti;
			if (val != null)
			{
				val.SelectedIndexChanged -= eventHandler;
				val.SelectedIndexChanging -= eventHandler2;
			}
			_lvContratti = value;
			val = _lvContratti;
			if (val != null)
			{
				val.SelectedIndexChanged += eventHandler;
				val.SelectedIndexChanging += eventHandler2;
			}
		}
	}

	[field: AccessedThroughProperty("pnlListViewContent")]
	protected virtual Panel pnlListViewContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewContentTop")]
	protected virtual Panel pnlListViewContentTop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFilialiRiferimento")]
	protected virtual IboWebLabel lblFilialiRiferimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdTrasportatoriFiliali")]
	protected virtual IboWebToolbar tlbgrdTrasportatoriFiliali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTrasportatoriFiliali")]
	protected virtual Panel pnlTrasportatoriFiliali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdTrasportatoriFiliali")]
	protected virtual IboGridView grdTrasportatoriFiliali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewContentCenter")]
	protected virtual Panel pnlListViewContentCenter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebToolbar1")]
	protected virtual IboWebToolbar IboWebToolbar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	protected virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboGridView1")]
	protected virtual IboGridView IboGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlListViewContentBottom")]
	protected virtual Panel pnlListViewContentBottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel2")]
	protected virtual IboWebLabel IboWebLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebToolbar2")]
	protected virtual IboWebToolbar IboWebToolbar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	protected virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboGridView2")]
	protected virtual IboGridView IboGridView2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro")]
	protected virtual Panel pnlFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroTitolo")]
	protected virtual IboWebLabel lblFiltroTitolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroCampoDesc")]
	protected virtual IboWebLabel lblFiltroCampoDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroCampo")]
	protected virtual IboWebLabel lblFiltroCampo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroOperatore")]
	protected virtual IboWebLabel lblFiltroOperatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFiltroOperatore")]
	protected virtual DropDownList ddlFiltroOperatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroVal")]
	protected virtual IboWebLabel lblFiltroVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroNumericVal")]
	protected virtual IboWebNumericTlk txtFiltroNumericVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroDateVal")]
	protected virtual IboWebDate txtFiltroDateVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroStringVal")]
	protected virtual IboWebTextBox txtFiltroStringVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ibowebbutton1Idle")]
	protected virtual IboWebButton Ibowebbutton1Idle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFiltroConferma")]
	protected virtual IboWebButton btnFiltroConferma
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFiltroAnnulla")]
	protected virtual IboWebButton btnFiltroAnnulla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("popFiltro")]
	protected virtual ModalPopupExtender popFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForModalPopup")]
	protected virtual Button hiddenTargetControlForModalPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hidToolbarVisible")]
	protected virtual HiddenField hidToolbarVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFIStandardList()
	{
		((Control)this).Load += Page_Load;
		_ssqlMain = "SELECT * FROM GDOTariffeContratti";
		_ssqlFiltro = "";
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		string ssqlMain = _ssqlMain;
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		if (!((Control)this).Page.IsPostBack)
		{
			DBConnection dbConn = base.DbConn;
			string text = "";
			dbConn.OpenDataTable(ssqlMain, ref dataTable, ref text);
			((BaseDataBoundControl)lvContratti).DataSource = dataTable;
			((BaseDataBoundControl)lvContratti).DataBind();
			_SessionVariable.Remove("lvContratti.DataSource");
			_SessionVariable.Remove("lvContratti.SqlFilterRaw");
			_SessionVariable.Remove("lvContratti.SqlFilter");
			_SessionVariable.Add("lvContratti.DataSource", dataTable);
			DBConnection dbConn2 = base.DbConn;
			string text2 = ssqlMain + " Where 1=2";
			text = "";
			dbConn2.SqlSchemaTable(ref dataTable2, text2, ref text);
			_ssqlFiltro = "";
			foreach (DataRow row in dataTable2.Rows)
			{
				switch (((Type)row["DataType"]).Name)
				{
				case "String":
				case "Char":
				{
					ref string ssqlFiltro5 = ref _ssqlFiltro;
					ssqlFiltro5 = ssqlFiltro5 + " OR " + row["ColumnName"].ToString() + " LIKE '%<%FILTERVALUE%>%'";
					break;
				}
				case "DateTime":
				case "TimeSpan":
				{
					ref string ssqlFiltro4 = ref _ssqlFiltro;
					ssqlFiltro4 = ssqlFiltro4 + " OR (dbo.FORMATDATE(" + row["ColumnName"].ToString() + ", 'DDMMYYYY','/') LIKE '%<%FILTERVALUEDATE%>%') ";
					break;
				}
				case "Byte":
				case "SByte":
				case "Int16":
				case "Int32":
				case "Int64":
				case "Single":
				case "UInt16":
				case "UInt32":
				case "UInt64":
				{
					ref string ssqlFiltro3 = ref _ssqlFiltro;
					ssqlFiltro3 = ssqlFiltro3 + " OR " + row["ColumnName"].ToString() + " = '<%FILTERVALUENUMBER%>' ";
					break;
				}
				case "Decimal":
				case "Double":
				{
					ref string ssqlFiltro2 = ref _ssqlFiltro;
					ssqlFiltro2 = ssqlFiltro2 + " OR " + row["ColumnName"].ToString() + " = '<%FILTERVALUENUMBER%>' ";
					break;
				}
				default:
				{
					ref string ssqlFiltro = ref _ssqlFiltro;
					ssqlFiltro = ssqlFiltro + " OR " + row["ColumnName"].ToString() + " LIKE '%<%FILTERVALUE%>%'";
					break;
				}
				}
			}
			_ssqlFiltro = " (1=2 " + _ssqlFiltro + ") ";
			_SessionVariable.Add("lvContratti.SqlFilterRaw", _ssqlFiltro);
		}
		else
		{
			((BaseDataBoundControl)lvContratti).DataSource = (DataTable)_SessionVariable["lvContratti.DataSource"];
			lvContratti.SelectedIndex = -1;
			((BaseDataBoundControl)lvContratti).DataBind();
		}
	}

	private void lvContratti_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void lvContratti_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
	{
		((BaseDataBoundControl)lvContratti).DataSource = (DataTable)_SessionVariable["lvContratti.DataSource"];
		lvContratti.SelectedIndex = e.NewSelectedIndex;
		((BaseDataBoundControl)lvContratti).DataBind();
	}

	protected void btnListViewAggiorna_Click(object sender, ImageClickEventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		string text = _ssqlMain;
		_ssqlFiltro = _SessionVariable["lvContratti.SqlFilter"].ToString();
		if (Operators.CompareString(_ssqlFiltro, "", false) != 0)
		{
			text = text + " WHERE " + _ssqlFiltro;
		}
		DataTable dataSource = null;
		DBConnection dbConn = base.DbConn;
		string text2 = text;
		string text3 = "";
		dbConn.OpenDataTable(text2, ref dataSource, ref text3);
		((BaseDataBoundControl)lvContratti).DataSource = dataSource;
		((BaseDataBoundControl)lvContratti).DataBind();
	}

	protected void btnListViewFiltro_Click(object sender, ImageClickEventArgs e)
	{
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		string text = _ssqlMain;
		_ssqlFiltro = _SessionVariable["lvContratti.SqlFilterRaw"].ToString();
		txtListViewFiltro.Text = txtListViewFiltro.Text.Trim();
		if (Operators.CompareString(txtListViewFiltro.Text, "", false) == 0)
		{
			_SessionVariable["lvContratti.SqlFilter"] = (object)"";
			_ssqlFiltro = _SessionVariable["lvContratti.SqlFilter"].ToString();
		}
		else
		{
			_ssqlFiltro = _SessionVariable["lvContratti.SqlFilterRaw"].ToString();
			_ssqlFiltro = Strings.Replace(_ssqlFiltro, "<%FILTERVALUE%>", txtListViewFiltro.Text, 1, -1, (CompareMethod)0);
			if (Versioned.IsNumeric((object)txtListViewFiltro.Text))
			{
				_ssqlFiltro = Strings.Replace(_ssqlFiltro, "<%FILTERVALUENUMBER%>", Conversions.ToDecimal(txtListViewFiltro.Text).ToString(), 1, -1, (CompareMethod)0);
			}
			else
			{
				_ssqlFiltro = Strings.Replace(_ssqlFiltro, "<%FILTERVALUENUMBER%>", "-9999", 1, -1, (CompareMethod)0);
			}
			if (Information.IsDate((object)txtListViewFiltro.Text))
			{
				_ssqlFiltro = Strings.Replace(_ssqlFiltro, "<%FILTERVALUEDATE%>", Conversions.ToDate(txtListViewFiltro.Text).ToShortDateString(), 1, -1, (CompareMethod)0);
			}
			else
			{
				string ssqlFiltro = _ssqlFiltro;
				DateTime minValue = DateTime.MinValue;
				_ssqlFiltro = Strings.Replace(ssqlFiltro, "<%FILTERVALUEDATE%>", minValue.ToShortDateString(), 1, -1, (CompareMethod)0);
			}
		}
		if (Operators.CompareString(_ssqlFiltro, "", false) != 0)
		{
			text = text + " WHERE " + _ssqlFiltro;
		}
		DataTable dataSource = null;
		DBConnection dbConn = base.DbConn;
		string text2 = text;
		string text3 = "";
		dbConn.OpenDataTable(text2, ref dataSource, ref text3);
		((BaseDataBoundControl)lvContratti).DataSource = dataSource;
		((BaseDataBoundControl)lvContratti).DataBind();
	}
}
