using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFGDoQuery : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGo")]
	private IboWebButton _btnGo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSvuota")]
	private IboWebButton _btnSvuota;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdDati1")]
	private GridView _grdDati1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdDati2")]
	private GridView _grdDati2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdDati3")]
	private GridView _grdDati3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdDati4")]
	private GridView _grdDati4;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Image")]
	protected virtual Image cpInfoGen_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQuery")]
	protected virtual Panel pnlQuery
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuery")]
	protected virtual IboWebLabel lblQuery
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Query")]
	protected virtual IboWebTextBox Query
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGo
	{
		[CompilerGenerated]
		get
		{
			return _btnGo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGo_Click;
			IboWebButton val = _btnGo;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGo = value;
			val = _btnGo;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnSvuota
	{
		[CompilerGenerated]
		get
		{
			return _btnSvuota;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSvuota_Click;
			IboWebButton val = _btnSvuota;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSvuota = value;
			val = _btnSvuota;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlResultContainer")]
	protected virtual Panel pnlResultContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upDati1")]
	protected virtual UpdatePanel upDati1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDati1")]
	protected virtual IboWebPanel pnlDati1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual GridView grdDati1
	{
		[CompilerGenerated]
		get
		{
			return _grdDati1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			GridViewPageEventHandler val = new GridViewPageEventHandler(grdDati_PageIndexChanging);
			GridView val2 = _grdDati1;
			if (val2 != null)
			{
				val2.PageIndexChanging -= val;
			}
			_grdDati1 = value;
			val2 = _grdDati1;
			if (val2 != null)
			{
				val2.PageIndexChanging += val;
			}
		}
	}

	[field: AccessedThroughProperty("upDati2")]
	protected virtual UpdatePanel upDati2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDati2")]
	protected virtual Panel pnlDati2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual GridView grdDati2
	{
		[CompilerGenerated]
		get
		{
			return _grdDati2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			GridViewPageEventHandler val = new GridViewPageEventHandler(grdDati_PageIndexChanging);
			GridView val2 = _grdDati2;
			if (val2 != null)
			{
				val2.PageIndexChanging -= val;
			}
			_grdDati2 = value;
			val2 = _grdDati2;
			if (val2 != null)
			{
				val2.PageIndexChanging += val;
			}
		}
	}

	[field: AccessedThroughProperty("upDati3")]
	protected virtual UpdatePanel upDati3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDati3")]
	protected virtual Panel pnlDati3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual GridView grdDati3
	{
		[CompilerGenerated]
		get
		{
			return _grdDati3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			GridViewPageEventHandler val = new GridViewPageEventHandler(grdDati_PageIndexChanging);
			GridView val2 = _grdDati3;
			if (val2 != null)
			{
				val2.PageIndexChanging -= val;
			}
			_grdDati3 = value;
			val2 = _grdDati3;
			if (val2 != null)
			{
				val2.PageIndexChanging += val;
			}
		}
	}

	[field: AccessedThroughProperty("upDati4")]
	protected virtual UpdatePanel upDati4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDati4")]
	protected virtual Panel pnlDati4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual GridView grdDati4
	{
		[CompilerGenerated]
		get
		{
			return _grdDati4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			GridViewPageEventHandler val = new GridViewPageEventHandler(grdDati_PageIndexChanging);
			GridView val2 = _grdDati4;
			if (val2 != null)
			{
				val2.PageIndexChanging -= val;
			}
			_grdDati4 = value;
			val2 = _grdDati4;
			if (val2 != null)
			{
				val2.PageIndexChanging += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpInfoGen")]
	protected virtual CollapsiblePanelExtender cpInfoGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.CFG.DOQUERY";
		_Title = base.Translator.Translate("XXX", "Query manager", new string[0]);
		if (!_SessionVariable.ContainsKey("dt1"))
		{
			_SessionVariable.Add("dt1", null);
		}
		else
		{
			DataTable dataSource = (DataTable)_SessionVariable["dt1"];
			((BaseDataBoundControl)grdDati1).DataSource = dataSource;
		}
		if (!_SessionVariable.ContainsKey("dt2"))
		{
			_SessionVariable.Add("dt2", null);
		}
		else
		{
			DataTable dataSource2 = (DataTable)_SessionVariable["dt2"];
			((BaseDataBoundControl)grdDati2).DataSource = dataSource2;
		}
		if (!_SessionVariable.ContainsKey("dt3"))
		{
			_SessionVariable.Add("dt3", null);
		}
		else
		{
			DataTable dataSource3 = (DataTable)_SessionVariable["dt3"];
			((BaseDataBoundControl)grdDati3).DataSource = dataSource3;
		}
		if (!_SessionVariable.ContainsKey("dt4"))
		{
			_SessionVariable.Add("dt4", null);
		}
		else
		{
			DataTable dataSource4 = (DataTable)_SessionVariable["dt4"];
			((BaseDataBoundControl)grdDati4).DataSource = dataSource4;
		}
		((WebControl)pnlMain).Width = (System.Web.UI.WebControls.Unit)(checked(base.SessionEnvironment.WindowWidth - 20));
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
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

	private void btnGo_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Invalid comparison between Unknown and I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			checked
			{
				if (Operators.CompareString(Query.ObjValue.ToString().Trim(), "", false) != 0)
				{
					string[] array = Query.ObjValue.ToString().Trim().Split(new char[1] { ';' });
					((BaseDataBoundControl)grdDati1).DataSource = null;
					((BaseDataBoundControl)grdDati2).DataSource = null;
					((BaseDataBoundControl)grdDati3).DataSource = null;
					((BaseDataBoundControl)grdDati4).DataSource = null;
					grdDati1.DataBind();
					grdDati2.DataBind();
					grdDati3.DataBind();
					grdDati4.DataBind();
					((Control)grdDati1).Visible = false;
					((Control)grdDati2).Visible = false;
					((Control)grdDati3).Visible = false;
					((Control)grdDati4).Visible = false;
					((Control)pnlDati1).Visible = false;
					((Control)pnlDati2).Visible = false;
					((Control)pnlDati3).Visible = false;
					((Control)pnlDati4).Visible = false;
					int num = array.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						DataTable dataTable = null;
						string text = array[i].Trim();
						if (Operators.CompareString(text, "", false) != 0)
						{
							val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
							if (unchecked((int)val2) > 0)
							{
								val = val2;
								return;
							}
							_SessionVariable["dt" + Conversions.ToString(i + 1)] = (object)dataTable;
							GridView val3 = (GridView)GetControlByName((Control)(object)this, "grdDati" + Conversions.ToString(i + 1));
							Panel val4 = (Panel)GetControlByName((Control)(object)this, "pnlDati" + Conversions.ToString(i + 1));
							((BaseDataBoundControl)val3).DataSource = dataTable;
							val3.PageIndex = 0;
							val3.DataBind();
							((Control)val3).Visible = true;
							((Control)val4).Visible = true;
						}
						if (i == 3)
						{
							break;
						}
					}
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void grdDati_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		((GridView)sender).PageIndex = e.NewPageIndex;
		((GridView)sender).DataBind();
	}

	private void btnSvuota_Click(object sender, EventArgs e)
	{
		Query.Text = "";
		((Control)Query).Focus();
		((Control)pnlDati1).Visible = false;
		((Control)pnlDati2).Visible = false;
		((Control)pnlDati3).Visible = false;
		((Control)pnlDati4).Visible = false;
	}
}
