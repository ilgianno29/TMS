using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFGSqlInsert : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TcMain")]
	private TabContainer _TcMain;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro")]
	private IboWebButton _btnFiltro;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiungi")]
	private IboWebButton _btnAggiungi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTogli")]
	private IboWebButton _btnTogli;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSpostaSu")]
	private IboWebButton _btnSpostaSu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSpostaGiu")]
	private IboWebButton _btnSpostaGiu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGo")]
	private IboWebButton _btnGo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiungiQuery")]
	private IboWebButton _btnAggiungiQuery;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTogliQuery")]
	private IboWebButton _btnTogliQuery;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSpostaSuQuery")]
	private IboWebButton _btnSpostaSuQuery;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSpostaGiuQuery")]
	private IboWebButton _btnSpostaGiuQuery;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnQueryGo")]
	private IboWebButton _btnQueryGo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnEsportaWFI")]
	private IboWebButton _btnEsportaWFI;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnEsportaTutto")]
	private IboWebButton _btnEsportaTutto;

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

	protected virtual TabContainer TcMain
	{
		[CompilerGenerated]
		get
		{
			return _TcMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = TcMain_ActiveTabChanged;
			TabContainer tcMain = _TcMain;
			if (tcMain != null)
			{
				tcMain.ActiveTabChanged -= eventHandler;
			}
			_TcMain = value;
			tcMain = _TcMain;
			if (tcMain != null)
			{
				tcMain.ActiveTabChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("tpTabella")]
	protected virtual TabPanel tpTabella
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpTabellaCaption")]
	protected virtual IboWebLabel tpTabellaCaption
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

	[field: AccessedThroughProperty("pnlTables")]
	protected virtual Panel pnlTables
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoTabelleDisponibili")]
	protected virtual Panel pnlElencoTabelleDisponibili
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblElencoTabelleDisponibili")]
	protected virtual IboWebLabel lblElencoTabelleDisponibili
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoTabelleFiltro")]
	protected virtual IboWebTextBox ElencoTabelleFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Click;
			IboWebButton val = _btnFiltro;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro = value;
			val = _btnFiltro;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("ElencoTabelle")]
	protected virtual ListBox ElencoTabelle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSposta")]
	protected virtual Panel pnlSposta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiungi
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiungi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiungi_Click;
			IboWebButton val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiungi = value;
			val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnTogli
	{
		[CompilerGenerated]
		get
		{
			return _btnTogli;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTogli_Click;
			IboWebButton val = _btnTogli;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTogli = value;
			val = _btnTogli;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnSpostaSu
	{
		[CompilerGenerated]
		get
		{
			return _btnSpostaSu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSpostaSu_Click;
			IboWebButton val = _btnSpostaSu;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSpostaSu = value;
			val = _btnSpostaSu;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnSpostaGiu
	{
		[CompilerGenerated]
		get
		{
			return _btnSpostaGiu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSpostaGiu_Click;
			IboWebButton val = _btnSpostaGiu;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSpostaGiu = value;
			val = _btnSpostaGiu;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlServerType")]
	protected virtual Panel pnlServerType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ServerType")]
	protected virtual IboWebRadioButtonList ServerType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoTabelleDaEsportare")]
	protected virtual Panel pnlElencoTabelleDaEsportare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblElencoTabelleSelezionate")]
	protected virtual IboWebLabel lblElencoTabelleSelezionate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoTabelleDaEsportare")]
	protected virtual ListBox ElencoTabelleDaEsportare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlComandi")]
	protected virtual Panel pnlComandi
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

	[field: AccessedThroughProperty("tpQuery")]
	protected virtual TabPanel tpQuery
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tpQueryCaption")]
	protected virtual IboWebLabel tpQueryCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Title")]
	protected virtual Panel cpByQuery_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Title_Caption")]
	protected virtual Label cpByQuery_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Title_Image")]
	protected virtual Image cpByQuery_Title_Image
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Body")]
	protected virtual Panel cpByQuery_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQueryText")]
	protected virtual Panel pnlQueryText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QueryText")]
	protected virtual IboWebTextBox QueryText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQueryServerType")]
	protected virtual Panel pnlQueryServerType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QueryServerType")]
	protected virtual IboWebRadioButtonList QueryServerType
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

	[field: AccessedThroughProperty("pnlElencoQueryDisponibili")]
	protected virtual Panel pnlElencoQueryDisponibili
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoQuery")]
	protected virtual ListBox ElencoQuery
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlQuerySposta")]
	protected virtual Panel pnlQuerySposta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiungiQuery
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiungiQuery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiungiQuery_Click;
			IboWebButton val = _btnAggiungiQuery;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiungiQuery = value;
			val = _btnAggiungiQuery;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnTogliQuery
	{
		[CompilerGenerated]
		get
		{
			return _btnTogliQuery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTogliQuery_Click;
			IboWebButton val = _btnTogliQuery;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTogliQuery = value;
			val = _btnTogliQuery;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnSpostaSuQuery
	{
		[CompilerGenerated]
		get
		{
			return _btnSpostaSuQuery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSpostaSuQuery_Click;
			IboWebButton val = _btnSpostaSuQuery;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSpostaSuQuery = value;
			val = _btnSpostaSuQuery;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnSpostaGiuQuery
	{
		[CompilerGenerated]
		get
		{
			return _btnSpostaGiuQuery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSpostaGiuQuery_Click;
			IboWebButton val = _btnSpostaGiuQuery;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSpostaGiuQuery = value;
			val = _btnSpostaGiuQuery;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlQueryComandi")]
	protected virtual Panel pnlQueryComandi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnQueryGo
	{
		[CompilerGenerated]
		get
		{
			return _btnQueryGo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnQueryGo_Click;
			IboWebButton val = _btnQueryGo;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnQueryGo = value;
			val = _btnQueryGo;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnEsportaWFI
	{
		[CompilerGenerated]
		get
		{
			return _btnEsportaWFI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnEsportaWFI_Click;
			IboWebButton val = _btnEsportaWFI;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnEsportaWFI = value;
			val = _btnEsportaWFI;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnEsportaTutto
	{
		[CompilerGenerated]
		get
		{
			return _btnEsportaTutto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnEsportaTutto_Click;
			IboWebButton val = _btnEsportaTutto;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnEsportaTutto = value;
			val = _btnEsportaTutto;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.CFG.SQLINSERTS";
		_Title = base.Translator.Translate("XXX", "Insert generator", new string[0]);
		try
		{
			base.MasterPage.ScriptManager.RegisterPostBackControl((Control)(object)btnGo);
			base.MasterPage.ScriptManager.RegisterPostBackControl((Control)(object)btnEsportaWFI);
			base.MasterPage.ScriptManager.RegisterPostBackControl((Control)(object)btnEsportaTutto);
			base.MasterPage.ScriptManager.RegisterPostBackControl((Control)(object)btnQueryGo);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
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

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LoadTables("", ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if ((int)base.DbConn.ServerType == 0)
				{
					((ListControl)ServerType).SelectedValue = "SQL";
					((ListControl)QueryServerType).SelectedValue = "SQL";
				}
				else
				{
					((ListControl)ServerType).SelectedValue = "ORACLE";
					((ListControl)QueryServerType).SelectedValue = "ORACLE";
				}
				val2 = base.LoadData(ref rsMess);
				if ((int)val2 <= 0)
				{
					btnConferma.Visible = false;
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

	protected FXRETURN LoadTables(string Filtro, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "SELECT * FROM ElencoTabelle WHERE TABLE_TYPE LIKE '%TABLE%' AND TABLE_NAME NOT LIKE 'BIN$%' ";
			if (Operators.CompareString(Filtro, "", false) != 0)
			{
				text = text + " AND TABLE_NAME LIKE '%" + Filtro.Replace("'", "''") + "%'";
			}
			if (((ListControl)ElencoTabelleDaEsportare).Items.Count > 0)
			{
				text += " AND TABLE_NAME NOT IN (";
			}
			foreach (ListItem item in ((ListControl)ElencoTabelleDaEsportare).Items)
			{
				ListItem val3 = item;
				text = text + base.DbConn.SQLFormatString(val3.Value) + ",";
			}
			if (((ListControl)ElencoTabelleDaEsportare).Items.Count > 0)
			{
				text = Strings.Left(text, checked(Strings.Len(text) - 1));
				text += ")";
			}
			text += " ORDER BY TABLE_NAME";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				((ListControl)ElencoTabelle).Items.Clear();
				foreach (DataRow row in dataTable.Rows)
				{
					((ListControl)ElencoTabelle).Items.Add(new ListItem(row["TABLE_NAME"].ToString(), row["TABLE_NAME"].ToString()));
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private void btnGo_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Invalid comparison between Unknown and I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		StringBuilder stringBuilder3 = new StringBuilder();
		StringCollection stringCollection = new StringCollection();
		StringCollection stringCollection2 = new StringCollection();
		StringCollection stringCollection3 = new StringCollection();
		try
		{
			CallStackAdd();
			foreach (ListItem item in ((ListControl)ElencoTabelleDaEsportare).Items)
			{
				ListItem val3 = item;
				DataTable dataTable = null;
				string text = "SELECT * FROM " + val3.Value;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				if ((Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) == 0) | (Operators.CompareString(((ListControl)ServerType).SelectedValue, "ORACLE", false) == 0))
				{
					StringCollection stringCollection4 = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), val3.Value, val3.Value, dataTable, true, (eServerType)((Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) != 0) ? 1 : 0), ref stringCollection4, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringEnumerator enumerator2 = stringCollection4.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current = enumerator2.Current;
						stringCollection.Add(current + "\r\n");
					}
					stringCollection.Add("\r\n");
					continue;
				}
				StringCollection stringCollection5 = null;
				StringCollection stringCollection6 = null;
				val2 = GenerateInserts.RunProc(CreateApiContext(), val3.Value, val3.Value, dataTable, true, (eServerType)0, ref stringCollection5, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				StringEnumerator enumerator3 = stringCollection5.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string current2 = enumerator3.Current;
					stringCollection2.Add(current2 + "\r\n");
				}
				stringCollection2.Add("\r\n");
				val2 = GenerateInserts.RunProc(CreateApiContext(), val3.Value, val3.Value, dataTable, true, (eServerType)1, ref stringCollection6, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				StringEnumerator enumerator4 = stringCollection6.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					string current3 = enumerator4.Current;
					stringCollection3.Add(current3 + "\r\n");
				}
				stringCollection3.Add("\r\n");
			}
			if ((Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) == 0) | (Operators.CompareString(((ListControl)ServerType).SelectedValue, "ORACLE", false) == 0))
			{
				if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) == 0)
				{
					stringBuilder.Append("-- **********************************************************************************\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- S Q L   S E R V E R\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- **********************************************************************************\r\n");
				}
				else if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "ORACLE", false) == 0)
				{
					stringBuilder.Append("-- **********************************************************************************\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- O R A C L E\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- **********************************************************************************\r\n");
				}
				StringEnumerator enumerator5 = stringCollection.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					string current4 = enumerator5.Current;
					stringBuilder.Append(current4);
				}
				stringBuilder.Append("\r\n");
			}
			else
			{
				stringBuilder.Append("-- **********************************************************************************\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- S Q L   S E R V E R\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				StringEnumerator enumerator6 = stringCollection2.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					string current5 = enumerator6.Current;
					stringBuilder.Append(current5);
				}
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- O R A C L E\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				StringEnumerator enumerator7 = stringCollection3.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					string current6 = enumerator7.Current;
					stringBuilder.Append(current6);
				}
				stringBuilder.Append("\r\n");
			}
			if (stringBuilder.Length > 0)
			{
				string text2 = GenerateTempFileName("SqlInserts_*.txt");
				string ZipFileName = "";
				File.WriteAllText(text2, stringBuilder.ToString());
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string rsMess2 = "";
				sessionEnvironment.AddFileToDelete(text2, ref rsMess2);
				val2 = ZipFile(text2, ref ZipFileName, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
				string sNomeFile = ZipFileName;
				rsMess2 = "";
				sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess2);
				string sNomeFile2 = ZipFileName;
				rsMess2 = "";
				SendZIPFileToClient(sNomeFile2, "", bSegnaFileComeDaCancellare: true, ref rsMess2);
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
			CallStackRemove();
		}
	}

	private void btnFiltro_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = LoadTables(ElencoTabelleFiltro.ObjValue.ToString(), ref rsMess);
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

	private void btnAggiungi_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			foreach (ListItem item in ((ListControl)ElencoTabelle).Items)
			{
				ListItem val3 = item;
				if (val3.Selected && !((ListControl)ElencoTabelleDaEsportare).Items.Contains(val3))
				{
					((ListControl)ElencoTabelleDaEsportare).Items.Add(new ListItem(val3.Text, val3.Value));
				}
			}
			val2 = LoadTables(ElencoTabelleFiltro.ObjValue.ToString(), ref rsMess);
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

	private void btnTogli_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			foreach (ListItem item in ((ListControl)ElencoTabelleDaEsportare).Items)
			{
				ListItem val3 = item;
				if (val3.Selected)
				{
					stringCollection.Add(val3.Value);
				}
			}
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string current = enumerator2.Current;
				((ListControl)ElencoTabelleDaEsportare).Items.Remove(current);
			}
			val2 = LoadTables(ElencoTabelleFiltro.ObjValue.ToString(), ref rsMess);
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

	private void btnEsportaTutto_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Invalid comparison between Unknown and I4
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Invalid comparison between Unknown and I4
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Invalid comparison between Unknown and I4
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Invalid comparison between Unknown and I4
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		StringBuilder stringBuilder = new StringBuilder();
		List<DataTable> list = new List<DataTable>();
		DataTable dataTable = null;
		string[] array = new string[54]
		{
			"-- ", "-- CANCELLO TUTTA LA CONFIGURAZIONE", "--", "DELETE FROM WFI_Etichette;", "DELETE FROM WFI_EtichetteStampantiElenco;", "DELETE FROM WFI_ALLGRD;", "DELETE FROM WFI_ALLBTN;", "DELETE FROM WFI_OBJECTMANAGER;", "DELETE FROM WFI_TABREP;", "DELETE FROM WFI_TabRep_StampeAutomatiche;",
			"DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Desktop_Tree);", "DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Desktop_Tree);", "DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NULL;", "DELETE FROM WFI_Desktop_Tree;", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL); ", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL); ", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NULL;", "DELETE FROM WFI_Menu_Tree;", "DELETE FROM WFI_MENU_VOCI;", "DELETE FROM WFI_UTENTI;",
			"DELETE FROM WFI_Config_Profiles;", "DELETE FROM WFI_TABSTYLESET;", "SELECT * FROM WFI_ALLBTN", "SELECT * FROM WFI_OBJECTMANAGER", "SELECT * FROM WFI_OBJECTMANAGER_CONDITIONS", "SELECT * FROM WFI_TABSTYLESET", "SELECT * FROM WFI_CONFIG_PROFILES", "SELECT * FROM WFI_UTENTI WHERE TIPO='T'", "SELECT * FROM WFI_UTENTI WHERE TIPO='O'", "SELECT * FROM WFI_UTENTI WHERE TIPO='G'",
			"SELECT * FROM WFI_UTENTI WHERE TIPO='U'", "SELECT NOMRIF,UTENTE,NOMTAB,DESTAB,OBJECTMANAGERNAME,MINFIL,CANSEL,ROWSPERPAGE,BACKCOLOR,FORCOLOR,BORDERCOLOR,HORIZONTALALIGN,BOLD,ITALIC,FONTSIZE,FONTNAME,FILTRO,FILTROUTENTEOBBLIGATORIO,HEADERSTYLE,PAGERSTYLE,ROWSTYLE,ALTERNATINGROWSTYLE,SELECTEDROWSTYLE,HIGHLIGHTEDROWSTYLE,WHEREAGGIUNTIVA,PREFILTRO,CANPAGE,CANSORT,CANEDIT,DATINS,DATAGG,UTEINS,UTEAGG,TIMERUPDATE,CAPTIONBACKCOLOR,CAPTIONFORCOLOR,CAPTIONBOLD,CAPTIONITALIC,CAPTIONFONTSIZE,CAPTIONFONTNAME,WIDTH,AUTOUPDATEVISIBLE,TIPOGRIGLIA,SELCOLVISIBLE,SHOWFOOTER,CANGROUP,GROUPHEADERITEMSTYLE,GROUPEXPANDED,SHOWGROUPFOOTER,MAXRECORD,MAXRECORDVISIBLE,FIXEDLAYOUT,SCROLLHEIGHT,COLUMNRESIZE,FastFilterType FROM WFI_ALLGRD", "SELECT * FROM WFI_ALLGRD_STYLESET", "SELECT NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,WRAPCOL,CANSORT,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP,NOMCAMTOOLTIP,CANEDIT,LARCAMEDIT,INNERSQL,GROUPFIELD,FOOTERTEXT,AGGREGATEFUNC,MAXCHAR,ExtendedDesCam,CssClass FROM WFI_TABGRD", "SELECT * FROM WFI_TABBOT", "SELECT * FROM WFI_MENU_VOCI", "SELECT * FROM WFI_UTENTIFILIALI", "SET IDENTITY_INSERT WFI_Menu_Tree ON;", "SELECT * FROM WFI_MENU_TREE WHERE PARENTID IS NULL", "SELECT * FROM WFI_MENU_TREE WHERE PARENTID IN (SELECT ID FROM WFI_MENU_TREE WHERE PARENTID IS NULL)",
			"SELECT * FROM WFI_MENU_TREE WHERE PARENTID IS NOT NULL AND PARENTID NOT IN (SELECT ID FROM WFI_MENU_TREE WHERE PARENTID IS NULL)", "SET IDENTITY_INSERT WFI_Menu_Tree OFF;", "SET IDENTITY_INSERT WFI_Desktop_Tree ON;", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IN (SELECT ID FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL)", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IS NOT NULL AND PARENTID NOT IN (SELECT ID FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL)", "SET IDENTITY_INSERT WFI_Desktop_Tree OFF;", "SELECT * FROM WFI_TABREP", "SELECT * FROM WFI_ALLGRD_TABREP", "SELECT * FROM WFI_EtichetteStampantiElenco",
			"SELECT * FROM WFI_Etichette", "SELECT * FROM WFI_EtichetteStampanti", "SELECT * FROM WFI_EtichetteFile", "SELECT * FROM WFI_EtichetteCampi"
		};
		string[] array2 = new string[54]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "WFI_ALLBTN", "WFI_OBJECTMANAGER", "WFI_OBJECTMANAGER_CONDITIONS", "WFI_TABSTYLESET", "WFI_CONFIG_PROFILES", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI",
			"WFI_UTENTI", "WFI_ALLGRD", "WFI_ALLGRD_STYLESET", "WFI_TABGRD", "WFI_TABBOT", "WFI_MENU_VOCI", "WFI_UTENTIFILIALI", "", "WFI_MENU_TREE", "WFI_MENU_TREE",
			"WFI_MENU_TREE", "", "", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", "", "WFI_TABREP", "WFI_ALLGRD_TABREP", "WFI_EtichetteStampantiElenco",
			"WFI_Etichette", "WFI_EtichetteStampanti", "WFI_EtichetteFile", "WFI_EtichetteCampi"
		};
		string[] array3 = new string[54]
		{
			"-- ", "-- CANCELLO TUTTA LA CONFIGURAZIONE", "--", "DELETE FROM WFI_Etichette;", "DELETE FROM WFI_EtichetteStampantiElenco;", "DELETE FROM WFI_ALLGRD;", "DELETE FROM WFI_ALLBTN;", "DELETE FROM WFI_OBJECTMANAGER;", "DELETE FROM WFI_TABREP;", "DELETE FROM WFI_TabRep_StampeAutomatiche;",
			"DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Desktop_Tree);", "DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Desktop_Tree);", "DELETE FROM WFI_Desktop_Tree WHERE ParentId IS NULL;", "DELETE FROM WFI_Desktop_Tree;", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL); ", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL AND Id NOT IN (SELECT ParentId FROM WFI_Menu_Tree WHERE ParentId IS NOT NULL); ", "DELETE FROM WFI_Menu_Tree WHERE ParentId IS NULL;", "DELETE FROM WFI_Menu_Tree;", "DELETE FROM WFI_MENU_VOCI;", "DELETE FROM WFI_UTENTI;",
			"DELETE FROM WFI_Config_Profiles;", "DELETE FROM WFI_TABSTYLESET;", "SELECT * FROM WFI_ALLBTN", "SELECT * FROM WFI_OBJECTMANAGER", "SELECT * FROM WFI_OBJECTMANAGER_CONDITIONS", "SELECT * FROM WFI_TABSTYLESET", "SELECT * FROM WFI_CONFIG_PROFILES", "SELECT * FROM WFI_UTENTI WHERE TIPO='T'", "SELECT * FROM WFI_UTENTI WHERE TIPO='O'", "SELECT * FROM WFI_UTENTI WHERE TIPO='G'",
			"SELECT * FROM WFI_UTENTI WHERE TIPO='U'", "SELECT NOMRIF,UTENTE,NOMTAB,DESTAB,OBJECTMANAGERNAME,MINFIL,CANSEL,ROWSPERPAGE,BACKCOLOR,FORCOLOR,BORDERCOLOR,HORIZONTALALIGN,BOLD,ITALIC,FONTSIZE,FONTNAME,FILTRO,FILTROUTENTEOBBLIGATORIO,HEADERSTYLE,PAGERSTYLE,ROWSTYLE,ALTERNATINGROWSTYLE,SELECTEDROWSTYLE,HIGHLIGHTEDROWSTYLE,WHEREAGGIUNTIVA,PREFILTRO,CANPAGE,CANSORT,CANEDIT,DATINS,DATAGG,UTEINS,UTEAGG,TIMERUPDATE,CAPTIONBACKCOLOR,CAPTIONFORCOLOR,CAPTIONBOLD,CAPTIONITALIC,CAPTIONFONTSIZE,CAPTIONFONTNAME,WIDTH,AUTOUPDATEVISIBLE,TIPOGRIGLIA,SELCOLVISIBLE,SHOWFOOTER,CANGROUP,GROUPHEADERITEMSTYLE,GROUPEXPANDED,SHOWGROUPFOOTER,MAXRECORD,MAXRECORDVISIBLE,FIXEDLAYOUT,SCROLLHEIGHT,COLUMNRESIZE,FastFilterType FROM WFI_ALLGRD", "SELECT * FROM WFI_ALLGRD_STYLESET", "SELECT NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,WRAPCOL,CANSORT,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP,NOMCAMTOOLTIP,CANEDIT,LARCAMEDIT,INNERSQL,GROUPFIELD,FOOTERTEXT,AGGREGATEFUNC,MAXCHAR,ExtendedDesCam,CssClass FROM WFI_TABGRD", "SELECT * FROM WFI_TABBOT", "SELECT * FROM WFI_MENU_VOCI", "SELECT * FROM WFI_UTENTIFILIALI", "ALTER TRIGGER TR_S_WFI_Menu_Tree DISABLE;", "SELECT * FROM WFI_MENU_TREE WHERE PARENTID IS NULL", "SELECT * FROM WFI_MENU_TREE WHERE PARENTID IN (SELECT ID FROM WFI_MENU_TREE WHERE PARENTID IS NULL)",
			"SELECT * FROM WFI_MENU_TREE WHERE PARENTID IS NOT NULL AND PARENTID NOT IN (SELECT ID FROM WFI_MENU_TREE WHERE PARENTID IS NULL)", "ALTER TRIGGER TR_S_WFI_Menu_Tree DISABLE;", "ALTER TRIGGER TR_S_WFI_Menu_Desktop DISABLE;", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IN (SELECT ID FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL)", "SELECT * FROM WFI_DESKTOP_TREE WHERE PARENTID IS NOT NULL AND PARENTID NOT IN (SELECT ID FROM WFI_DESKTOP_TREE WHERE PARENTID IS NULL)", "ALTER TRIGGER TR_S_WFI_Menu_Desktop ENABLE;", "SELECT * FROM WFI_TABREP", "SELECT * FROM WFI_ALLGRD_TABREP", "SELECT * FROM WFI_EtichetteStampantiElenco",
			"SELECT * FROM WFI_Etichette", "SELECT * FROM WFI_EtichetteStampanti", "SELECT * FROM WFI_EtichetteFile", "SELECT * FROM WFI_EtichetteCampi"
		};
		string[] array4 = new string[54]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "WFI_ALLBTN", "WFI_OBJECTMANAGER", "WFI_OBJECTMANAGER_CONDITIONS", "WFI_TABSTYLESET", "WFI_CONFIG_PROFILES", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI",
			"WFI_UTENTI", "WFI_ALLGRD", "WFI_ALLGRD_STYLESET", "WFI_TABGRD", "WFI_TABBOT", "WFI_MENU_VOCI", "WFI_UTENTIFILIALI", "", "WFI_MENU_TREE", "WFI_MENU_TREE",
			"WFI_MENU_TREE", "", "", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", "", "WFI_TABREP", "WFI_ALLGRD_TABREP", "WFI_EtichetteStampantiElenco",
			"WFI_Etichette", "WFI_EtichetteStampanti", "WFI_EtichetteFile", "WFI_EtichetteCampi"
		};
		try
		{
			CallStackAdd();
			int num = 0;
			string[] array5 = default(string[]);
			string[] array6 = default(string[]);
			if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) == 0)
			{
				array5 = array;
				array6 = array2;
			}
			else if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "ORACLE", false) == 0)
			{
				array5 = array3;
				array6 = array4;
			}
			else if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "BOTH", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "L'esportazione di tutta la configurazione non è possibile per entrambi i server. Selezionare SQL Server o Oracle.");
				return;
			}
			string[] array7 = array5;
			foreach (string text in array7)
			{
				dataTable = null;
				if (text.Trim().ToUpper().StartsWith("SELECT"))
				{
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringCollection stringCollection = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), array6[num], text, dataTable, false, (eServerType)((Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) != 0) ? 1 : 0), ref stringCollection, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringEnumerator enumerator = stringCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						stringBuilder.Append(current + "\r\n");
					}
				}
				else
				{
					stringBuilder.Append(text);
				}
				stringBuilder.Append("\r\n");
				num = checked(num + 1);
			}
			if (stringBuilder.Length > 0)
			{
				string text2 = GenerateTempFileName("AllScript_*.txt");
				string ZipFileName = "";
				File.WriteAllText(text2, stringBuilder.ToString());
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string rsMess2 = "";
				sessionEnvironment.AddFileToDelete(text2, ref rsMess2);
				val2 = ZipFile(text2, ref ZipFileName, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
				string sNomeFile = ZipFileName;
				rsMess2 = "";
				sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess2);
				string sNomeFile2 = ZipFileName;
				rsMess2 = "";
				SendZIPFileToClient(sNomeFile2, "", bSegnaFileComeDaCancellare: true, ref rsMess2);
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
			CallStackRemove();
		}
	}

	private void btnAggiungiQuery_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			string[] array = QueryText.ObjValue.ToString().Split(new char[1] { ';' });
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i = checked(i + 1))
			{
				string text = array2[i];
				text = text.Trim();
				text = text.Replace("\r\n", " ");
				text = text.Replace("\r", " ");
				text = text.Replace("\n", " ");
				if (Operators.CompareString(text, "", false) != 0 && ((ListControl)ElencoQuery).Items.FindByText(text) == null)
				{
					((ListControl)ElencoQuery).Items.Add(text);
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
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnTogliQuery_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			while (((ListControl)ElencoQuery).SelectedItem != null)
			{
				((ListControl)ElencoQuery).Items.Remove(((ListControl)ElencoQuery).SelectedValue);
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
			CallStackRemove();
		}
	}

	private void btnQueryGo_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Invalid comparison between Unknown and I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Invalid comparison between Unknown and I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		StringBuilder stringBuilder3 = new StringBuilder();
		StringCollection stringCollection = new StringCollection();
		StringCollection stringCollection2 = new StringCollection();
		StringCollection stringCollection3 = new StringCollection();
		try
		{
			CallStackAdd();
			foreach (ListItem item in ((ListControl)ElencoQuery).Items)
			{
				ListItem val3 = item;
				DataTable dataTable = null;
				string value = val3.Value;
				val2 = base.DbConn.OpenDataTable(value, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				string text = "";
				if (val3.Value.Contains("FROM"))
				{
					text = val3.Value.Substring(checked(val3.Value.IndexOf("FROM") + 4)).Trim().Split(new char[1] { ' ' })[0];
				}
				if ((Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "SQL", false) == 0) | (Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "ORACLE", false) == 0))
				{
					StringCollection stringCollection4 = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), text, val3.Value, dataTable, false, (eServerType)((Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "SQL", false) != 0) ? 1 : 0), ref stringCollection4, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringEnumerator enumerator2 = stringCollection4.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string current = enumerator2.Current;
						stringCollection.Add(current + "\r\n");
					}
					stringCollection.Add("\r\n");
					continue;
				}
				StringCollection stringCollection5 = null;
				StringCollection stringCollection6 = null;
				val2 = GenerateInserts.RunProc(CreateApiContext(), text, val3.Value, dataTable, false, (eServerType)0, ref stringCollection5, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				StringEnumerator enumerator3 = stringCollection5.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string current2 = enumerator3.Current;
					stringCollection2.Add(current2 + "\r\n");
				}
				stringCollection2.Add("\r\n");
				val2 = GenerateInserts.RunProc(CreateApiContext(), text, val3.Value, dataTable, false, (eServerType)1, ref stringCollection6, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				StringEnumerator enumerator4 = stringCollection6.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					string current3 = enumerator4.Current;
					stringCollection3.Add(current3 + "\r\n");
				}
				stringCollection3.Add("\r\n");
			}
			if ((Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "SQL", false) == 0) | (Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "ORACLE", false) == 0))
			{
				if (Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "SQL", false) == 0)
				{
					stringBuilder.Append("-- **********************************************************************************\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- S Q L   S E R V E R\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- **********************************************************************************\r\n");
				}
				else if (Operators.CompareString(((ListControl)QueryServerType).SelectedValue, "ORACLE", false) == 0)
				{
					stringBuilder.Append("-- **********************************************************************************\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- O R A C L E\r\n");
					stringBuilder.Append("--\r\n");
					stringBuilder.Append("-- **********************************************************************************\r\n");
				}
				StringEnumerator enumerator5 = stringCollection.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					string current4 = enumerator5.Current;
					stringBuilder.Append(current4);
				}
				stringBuilder.Append("\r\n");
			}
			else
			{
				stringBuilder.Append("-- **********************************************************************************\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- S Q L   S E R V E R\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				StringEnumerator enumerator6 = stringCollection2.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					string current5 = enumerator6.Current;
					stringBuilder.Append(current5);
				}
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- O R A C L E\r\n");
				stringBuilder.Append("--\r\n");
				stringBuilder.Append("-- **********************************************************************************\r\n");
				StringEnumerator enumerator7 = stringCollection3.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					string current6 = enumerator7.Current;
					stringBuilder.Append(current6);
				}
				stringBuilder.Append("\r\n");
			}
			if (stringBuilder.Length > 0)
			{
				string text2 = GenerateTempFileName("SqlInserts_*.txt");
				string ZipFileName = "";
				File.WriteAllText(text2, stringBuilder.ToString());
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string rsMess2 = "";
				sessionEnvironment.AddFileToDelete(text2, ref rsMess2);
				val2 = ZipFile(text2, ref ZipFileName, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
				string sNomeFile = ZipFileName;
				rsMess2 = "";
				sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess2);
				string sNomeFile2 = ZipFileName;
				rsMess2 = "";
				SendZIPFileToClient(sNomeFile2, "", bSegnaFileComeDaCancellare: true, ref rsMess2);
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
			CallStackRemove();
		}
	}

	private void btnEsportaWFI_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Invalid comparison between Unknown and I4
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Invalid comparison between Unknown and I4
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Invalid comparison between Unknown and I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Invalid comparison between Unknown and I4
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		StringBuilder stringBuilder = new StringBuilder();
		List<DataTable> list = new List<DataTable>();
		DataTable dataTable = null;
		string[] array = new string[40]
		{
			"SELECT * INTO T_WFI_TABBOT FROM WFI_TABBOT WHERE NUMBOT IN (SELECT NUMBOT FROM WFI_ALLBTN WHERE NUMBOT<=1000);", "DELETE FROM WFI_ALLBTN WHERE NUMBOT<=1000;", "SELECT * FROM WFI_ALLBTN WHERE NUMBOT<=1000", "INSERT INTO WFI_TABBOT SELECT * FROM T_WFI_TABBOT;", "DROP TABLE T_WFI_TABBOT;", "DELETE FROM WFI_ALLGRD WHERE NOMRIF LIKE '%WFI%';", "DELETE FROM WFI_OBJECTMANAGER WHERE CODICE LIKE '%WFI%';", "DELETE FROM WFI_TABSTYLESET WHERE STYLENAME NOT LIKE 'CST%';", "SELECT * FROM WFI_TABSTYLESET WHERE STYLENAME NOT LIKE 'CST%'", "SELECT * FROM WFI_OBJECTMANAGER WHERE CODICE LIKE '%WFI%'",
			"SELECT * FROM WFI_OBJECTMANAGER_CONDITIONS WHERE CODICE LIKE '%WFI%'", "SELECT * FROM WFI_CONFIG_PROFILES", "DELETE FROM WFI_UTENTI WHERE CODICE='INCAS';", "DELETE FROM WFI_UTENTI WHERE CODICE='CFGUSR';", "DELETE FROM WFI_UTENTI WHERE CODICE LIKE 'GRP.WFI%';", "DELETE FROM WFI_UTENTI WHERE CODICE='ORG.WFI';", "SELECT * FROM WFI_UTENTI WHERE CODICE='ORG.WFI'", "SELECT * FROM WFI_UTENTI WHERE CODICE LIKE 'GRP.WFI%'", "SELECT * FROM WFI_UTENTI WHERE CODICE='CFGUSR'", "SELECT * FROM WFI_UTENTI WHERE CODICE='INCAS'",
			"SELECT NOMRIF,UTENTE,NOMTAB,DESTAB,OBJECTMANAGERNAME,MINFIL,CANSEL,ROWSPERPAGE,BACKCOLOR,FORCOLOR,BORDERCOLOR,HORIZONTALALIGN,BOLD,ITALIC,FONTSIZE,FONTNAME,FILTRO,FILTROUTENTEOBBLIGATORIO,HEADERSTYLE,PAGERSTYLE,ROWSTYLE,ALTERNATINGROWSTYLE,SELECTEDROWSTYLE,HIGHLIGHTEDROWSTYLE,WHEREAGGIUNTIVA,PREFILTRO,CANPAGE,CANSORT,CANEDIT,DATINS,DATAGG,UTEINS,UTEAGG,TIMERUPDATE,CAPTIONBACKCOLOR,CAPTIONFORCOLOR,CAPTIONBOLD,CAPTIONITALIC,CAPTIONFONTSIZE,CAPTIONFONTNAME,WIDTH,AUTOUPDATEVISIBLE,TIPOGRIGLIA,SELCOLVISIBLE,SHOWFOOTER,CANGROUP,GROUPHEADERITEMSTYLE,GROUPEXPANDED,SHOWGROUPFOOTER,MAXRECORD,MAXRECORDVISIBLE,FIXEDLAYOUT,SCROLLHEIGHT,COLUMNRESIZE,FastFilterType FROM WFI_ALLGRD WHERE NOMRIF LIKE '%WFI%'", "SELECT * FROM WFI_ALLGRD_STYLESET WHERE NOMRIF LIKE '%WFI%'", "SELECT NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,WRAPCOL,CANSORT,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP,NOMCAMTOOLTIP,CANEDIT,LARCAMEDIT,INNERSQL,GROUPFIELD,FOOTERTEXT,AGGREGATEFUNC,MAXCHAR,ExtendedDesCam,CssClass FROM WFI_TABGRD WHERE NOMRIF LIKE '%WFI%'", "SELECT * FROM WFI_TABBOT WHERE NOMRIF LIKE '%WFI%'", "DELETE FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "DELETE FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "DELETE FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "DELETE FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "DELETE FROM WFI_MENU_VOCI WHERE VOCE LIKE '%WFI%'", "SELECT * FROM WFI_MENU_VOCI WHERE VOCE LIKE '%WFI%'",
			"DELETE FROM WFI_UTENTIFILIALI WHERE UTENTE IN ('CFGUSR', 'INCAS');", "SELECT * FROM WFI_UTENTIFILIALI WHERE UTENTE IN ('CFGUSR', 'INCAS')", "SET IDENTITY_INSERT WFI_Menu_Tree ON;", "SELECT * FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "SELECT * FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "SET IDENTITY_INSERT WFI_Menu_Tree OFF;", "SET IDENTITY_INSERT WFI_DeskTop_Tree ON;", "SELECT * FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "SELECT * FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "SET IDENTITY_INSERT WFI_Desktop_Tree OFF;"
		};
		string[] array2 = new string[40]
		{
			"", "", "WFI_ALLBTN", "", "", "", "", "", "WFI_TABSTYLESET", "WFI_OBJECTMANAGER",
			"WFI_OBJECTMANAGER_CONDITIONS", "WFI_CONFIG_PROFILES", "", "", "", "", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI",
			"WFI_ALLGRD", "WFI_ALLGRD_STYLESET", "WFI_TABGRD", "WFI_TABBOT", "", "", "", "", "", "WFI_MENU_VOCI",
			"", "WFI_UTENTIFILIALI", "", "WFI_MENU_TREE", "WFI_MENU_TREE", "", "", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", ""
		};
		string[] array3 = new string[40]
		{
			"CREATE TABLE T_WFI_TABBOT AS SELECT * FROM WFI_TABBOT WHERE NUMBOT IN (SELECT NUMBOT FROM WFI_ALLBTN WHERE NUMBOT<=1000);", "DELETE FROM WFI_ALLBTN WHERE NUMBOT<=1000;", "SELECT * FROM WFI_ALLBTN WHERE NUMBOT<=1000", "INSERT INTO WFI_TABBOT SELECT * FROM T_WFI_TABBOT;", "DROP TABLE T_WFI_TABBOT;", "DELETE FROM WFI_ALLGRD WHERE NOMRIF LIKE '%WFI%';", "DELETE FROM WFI_OBJECTMANAGER WHERE CODICE LIKE '%WFI%';", "DELETE FROM WFI_TABSTYLESET WHERE STYLENAME NOT LIKE 'CST%';", "SELECT * FROM WFI_TABSTYLESET WHERE STYLENAME NOT LIKE 'CST%'", "SELECT * FROM WFI_OBJECTMANAGER WHERE CODICE LIKE '%WFI%'",
			"SELECT * FROM WFI_OBJECTMANAGER_CONDITIONS WHERE CODICE LIKE '%WFI%'", "SELECT * FROM WFI_CONFIG_PROFILES", "DELETE FROM WFI_UTENTI WHERE CODICE='INCAS';", "DELETE FROM WFI_UTENTI WHERE CODICE='CFGUSR';", "DELETE FROM WFI_UTENTI WHERE CODICE LIKE 'GRP.WFI%';", "DELETE FROM WFI_UTENTI WHERE CODICE='ORG.WFI';", "SELECT * FROM WFI_UTENTI WHERE CODICE='ORG.WFI'", "SELECT * FROM WFI_UTENTI WHERE CODICE LIKE 'GRP.WFI%'", "SELECT * FROM WFI_UTENTI WHERE CODICE='CFGUSR'", "SELECT * FROM WFI_UTENTI WHERE CODICE='INCAS'",
			"SELECT NOMRIF,UTENTE,NOMTAB,DESTAB,OBJECTMANAGERNAME,MINFIL,CANSEL,ROWSPERPAGE,BACKCOLOR,FORCOLOR,BORDERCOLOR,HORIZONTALALIGN,BOLD,ITALIC,FONTSIZE,FONTNAME,FILTRO,FILTROUTENTEOBBLIGATORIO,HEADERSTYLE,PAGERSTYLE,ROWSTYLE,ALTERNATINGROWSTYLE,SELECTEDROWSTYLE,HIGHLIGHTEDROWSTYLE,WHEREAGGIUNTIVA,PREFILTRO,CANPAGE,CANSORT,CANEDIT,DATINS,DATAGG,UTEINS,UTEAGG,TIMERUPDATE,CAPTIONBACKCOLOR,CAPTIONFORCOLOR,CAPTIONBOLD,CAPTIONITALIC,CAPTIONFONTSIZE,CAPTIONFONTNAME,WIDTH,AUTOUPDATEVISIBLE,TIPOGRIGLIA,SELCOLVISIBLE,SHOWFOOTER,CANGROUP,GROUPHEADERITEMSTYLE,GROUPEXPANDED,SHOWGROUPFOOTER,MAXRECORD,MAXRECORDVISIBLE,FIXEDLAYOUT,SCROLLHEIGHT,COLUMNRESIZE,FastFilterType FROM WFI_ALLGRD WHERE NOMRIF LIKE '%WFI%'", "SELECT * FROM WFI_ALLGRD_STYLESET WHERE NOMRIF LIKE '%WFI%'", "SELECT NOMRIF,PRORIG,UTENTE,NOMTAB,NOMCAM,DESCAM,LARCAM,HORIZONTALALIGN,VERTICALALIGN,FORCAM,ORDCAM,ORDDIR,VISIBILE,ISKEY,WRAPCOL,CANSORT,DATINS,DATAGG,UTEINS,UTEAGG,HTMLENCODE,NOMCAMEXP,NOMCAMTOOLTIP,CANEDIT,LARCAMEDIT,INNERSQL,GROUPFIELD,FOOTERTEXT,AGGREGATEFUNC,MAXCHAR,ExtendedDesCam,CssClass FROM WFI_TABGRD WHERE NOMRIF LIKE '%WFI%'", "SELECT * FROM WFI_TABBOT WHERE NOMRIF LIKE '%WFI%'", "DELETE FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "DELETE FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "DELETE FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "DELETE FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "DELETE FROM WFI_MENU_VOCI WHERE VOCE LIKE '%WFI%'", "SELECT * FROM WFI_MENU_VOCI WHERE VOCE LIKE '%WFI%'",
			"DELETE FROM WFI_UTENTIFILIALI WHERE UTENTE IN ('CFGUSR', 'INCAS');", "SELECT * FROM WFI_UTENTIFILIALI WHERE UTENTE IN ('CFGUSR', 'INCAS')", "ALTER TRIGGER TR_S_WFI_Menu_Tree DISABLE;", "SELECT * FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "SELECT * FROM WFI_MENU_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "ALTER TRIGGER TR_S_WFI_Menu_Tree ENABLE;", "ALTER TRIGGER TR_S_WFI_Desktop_Tree DISABLE;", "SELECT * FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NULL", "SELECT * FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID LIKE '%WFI%' AND PARENTID IS NOT NULL", "ALTER TRIGGER TR_S_WFI_Desktop_Tree ENABLE;"
		};
		string[] array4 = new string[40]
		{
			"", "", "WFI_ALLBTN", "", "", "", "", "", "WFI_TABSTYLESET", "WFI_OBJECTMANAGER",
			"WFI_OBJECTMANAGER_CONDITIONS", "WFI_CONFIG_PROFILES", "", "", "", "", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI", "WFI_UTENTI",
			"WFI_ALLGRD", "WFI_ALLGRD_STYLESET", "WFI_TABGRD", "WFI_TABBOT", "", "", "", "", "", "WFI_MENU_VOCI",
			"", "WFI_UTENTIFILIALI", "", "WFI_MENU_TREE", "WFI_MENU_TREE", "", "", "WFI_DESKTOP_TREE", "WFI_DESKTOP_TREE", ""
		};
		try
		{
			CallStackAdd();
			int num = 0;
			string[] array5 = default(string[]);
			string[] array6 = default(string[]);
			if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) == 0)
			{
				array5 = array;
				array6 = array2;
			}
			else if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "ORACLE", false) == 0)
			{
				array5 = array3;
				array6 = array4;
			}
			else if (Operators.CompareString(((ListControl)ServerType).SelectedValue, "BOTH", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "L'esportazione di tutto il WFI non è possibile per entrambi i server. Selezionare SQL Server o Oracle.");
				return;
			}
			string[] array7 = array5;
			foreach (string text in array7)
			{
				if (text.Trim().ToUpper().StartsWith("SELECT") & !text.Trim().ToUpper().StartsWith("SELECT * INTO"))
				{
					dataTable = null;
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringCollection stringCollection = null;
					val2 = GenerateInserts.RunProc(CreateApiContext(), array6[num], text, dataTable, false, (eServerType)((Operators.CompareString(((ListControl)ServerType).SelectedValue, "SQL", false) != 0) ? 1 : 0), ref stringCollection, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					StringEnumerator enumerator = stringCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						stringBuilder.Append(current + "\r\n");
					}
				}
				else
				{
					stringBuilder.Append(text);
				}
				stringBuilder.Append("\r\n");
				num = checked(num + 1);
			}
			if (stringBuilder.Length > 0)
			{
				string text2 = GenerateTempFileName("WFIScript_*.txt");
				string ZipFileName = "";
				File.WriteAllText(text2, stringBuilder.ToString());
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string rsMess2 = "";
				sessionEnvironment.AddFileToDelete(text2, ref rsMess2);
				val2 = ZipFile(text2, ref ZipFileName, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
				string sNomeFile = ZipFileName;
				rsMess2 = "";
				sessionEnvironment2.AddFileToDelete(sNomeFile, ref rsMess2);
				string sNomeFile2 = ZipFileName;
				rsMess2 = "";
				SendZIPFileToClient(sNomeFile2, "", bSegnaFileComeDaCancellare: true, ref rsMess2);
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
			CallStackRemove();
		}
	}

	private void TcMain_ActiveTabChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(((Control)TcMain.ActiveTab).ID, ((Control)tpTabella).ID, false) == 0)
			{
				btnEsportaWFI.Visible = true;
				btnEsportaTutto.Visible = true;
			}
			else if (Operators.CompareString(((Control)TcMain.ActiveTab).ID, ((Control)tpQuery).ID, false) == 0)
			{
				btnEsportaWFI.Visible = false;
				btnEsportaTutto.Visible = false;
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
			CallStackRemove();
		}
	}

	private void btnSpostaSu_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			int[] selectedIndices = ElencoTabelleDaEsportare.GetSelectedIndices();
			checked
			{
				if ((selectedIndices.Count() > 0) & (selectedIndices.Count() < ((ListControl)ElencoTabelleDaEsportare).Items.Count))
				{
					int[] array = selectedIndices;
					foreach (int num in array)
					{
						if (num > 0)
						{
							ListItem val3 = new ListItem(((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Text, ((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Value, ((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Enabled);
							val3.Selected = ((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Text = ((ListControl)ElencoTabelleDaEsportare).Items[num].Text;
							((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Value = ((ListControl)ElencoTabelleDaEsportare).Items[num].Value;
							((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Selected = ((ListControl)ElencoTabelleDaEsportare).Items[num].Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num - 1].Enabled = ((ListControl)ElencoTabelleDaEsportare).Items[num].Enabled;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Text = val3.Text;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Value = val3.Value;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Selected = val3.Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Enabled = val3.Enabled;
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

	private void btnSpostaGiu_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Invalid comparison between Unknown and I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			int[] selectedIndices = ElencoTabelleDaEsportare.GetSelectedIndices();
			Array.Reverse((Array)selectedIndices);
			checked
			{
				if ((selectedIndices.Count() > 0) & (selectedIndices.Count() < ((ListControl)ElencoTabelleDaEsportare).Items.Count))
				{
					int[] array = selectedIndices;
					foreach (int num in array)
					{
						if (num < ((ListControl)ElencoTabelleDaEsportare).Items.Count - 1)
						{
							ListItem val3 = new ListItem(((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Text, ((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Value, ((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Enabled);
							val3.Selected = ((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Text = ((ListControl)ElencoTabelleDaEsportare).Items[num].Text;
							((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Value = ((ListControl)ElencoTabelleDaEsportare).Items[num].Value;
							((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Selected = ((ListControl)ElencoTabelleDaEsportare).Items[num].Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num + 1].Enabled = ((ListControl)ElencoTabelleDaEsportare).Items[num].Enabled;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Text = val3.Text;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Value = val3.Value;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Selected = val3.Selected;
							((ListControl)ElencoTabelleDaEsportare).Items[num].Enabled = val3.Enabled;
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

	private void btnSpostaSuQuery_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			int[] selectedIndices = ElencoQuery.GetSelectedIndices();
			checked
			{
				if ((selectedIndices.Count() > 0) & (selectedIndices.Count() < ((ListControl)ElencoQuery).Items.Count))
				{
					int[] array = selectedIndices;
					foreach (int num in array)
					{
						if (num > 0)
						{
							ListItem val3 = new ListItem(((ListControl)ElencoQuery).Items[num - 1].Text, ((ListControl)ElencoQuery).Items[num - 1].Value, ((ListControl)ElencoQuery).Items[num - 1].Enabled);
							val3.Selected = ((ListControl)ElencoQuery).Items[num - 1].Selected;
							((ListControl)ElencoQuery).Items[num - 1].Text = ((ListControl)ElencoQuery).Items[num].Text;
							((ListControl)ElencoQuery).Items[num - 1].Value = ((ListControl)ElencoQuery).Items[num].Value;
							((ListControl)ElencoQuery).Items[num - 1].Selected = ((ListControl)ElencoQuery).Items[num].Selected;
							((ListControl)ElencoQuery).Items[num - 1].Enabled = ((ListControl)ElencoQuery).Items[num].Enabled;
							((ListControl)ElencoQuery).Items[num].Text = val3.Text;
							((ListControl)ElencoQuery).Items[num].Value = val3.Value;
							((ListControl)ElencoQuery).Items[num].Selected = val3.Selected;
							((ListControl)ElencoQuery).Items[num].Enabled = val3.Enabled;
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

	private void btnSpostaGiuQuery_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Invalid comparison between Unknown and I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			int[] selectedIndices = ElencoQuery.GetSelectedIndices();
			Array.Reverse((Array)selectedIndices);
			checked
			{
				if ((selectedIndices.Count() > 0) & (selectedIndices.Count() < ((ListControl)ElencoQuery).Items.Count))
				{
					int[] array = selectedIndices;
					foreach (int num in array)
					{
						if (num < ((ListControl)ElencoQuery).Items.Count - 1)
						{
							ListItem val3 = new ListItem(((ListControl)ElencoQuery).Items[num + 1].Text, ((ListControl)ElencoQuery).Items[num + 1].Value, ((ListControl)ElencoQuery).Items[num + 1].Enabled);
							val3.Selected = ((ListControl)ElencoQuery).Items[num + 1].Selected;
							((ListControl)ElencoQuery).Items[num + 1].Text = ((ListControl)ElencoQuery).Items[num].Text;
							((ListControl)ElencoQuery).Items[num + 1].Value = ((ListControl)ElencoQuery).Items[num].Value;
							((ListControl)ElencoQuery).Items[num + 1].Selected = ((ListControl)ElencoQuery).Items[num].Selected;
							((ListControl)ElencoQuery).Items[num + 1].Enabled = ((ListControl)ElencoQuery).Items[num].Enabled;
							((ListControl)ElencoQuery).Items[num].Text = val3.Text;
							((ListControl)ElencoQuery).Items[num].Value = val3.Value;
							((ListControl)ElencoQuery).Items[num].Selected = val3.Selected;
							((ListControl)ElencoQuery).Items[num].Enabled = val3.Enabled;
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
}
