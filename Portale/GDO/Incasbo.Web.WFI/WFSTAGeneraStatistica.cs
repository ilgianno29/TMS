using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Statistics;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFSTAGeneraStatistica : WFIDialogPageMasterDetail
{
	protected class ResetPropertiesListCollection : List<ResetProperties>
	{
	}

	protected class ResetProperties
	{
		public string Id { get; set; }

		public Dictionary<string, string> Properties { get; set; }

		public ResetProperties(string vsId, Dictionary<string, string> Prop)
		{
			Id = "";
			Id = vsId;
			Properties = Prop;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__387_002D0
	{
		public DataKeyFieldCollection _0024VB_0024Local_objData;

		public _Closure_0024__387_002D0(_Closure_0024__387_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_objData = arg0._0024VB_0024Local_objData;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(Statistic stat)
		{
			return Operators.CompareString(stat.Codice, _0024VB_0024Local_objData.Item(0).get_FieldValues(0).ToString(), false) == 0;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdStatistiche")]
	private IboGridView _grdStatistiche;

	protected Statistic _Statistic;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
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

	[field: AccessedThroughProperty("pnlElencoStatistiche")]
	protected virtual Panel pnlElencoStatistiche
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoStatistiche_Title")]
	protected virtual Panel cpElencoStatistiche_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoStatistiche_Caption")]
	protected virtual IboWebLabel cpElencoStatistiche_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoStatistiche_Body")]
	protected virtual Panel cpElencoStatistiche_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_ElencoStatistiche")]
	protected virtual UpdatePanel up_ElencoStatistiche
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdStatistiche")]
	protected virtual IboWebToolbar tlbgrdStatistiche
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlGridStatistiche")]
	protected virtual Panel pnlGridStatistiche
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdStatistiche
	{
		[CompilerGenerated]
		get
		{
			return _grdStatistiche;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdStatistiche_MultiSelectChanged);
			IboGridView val2 = _grdStatistiche;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdStatistiche = value;
			val2 = _grdStatistiche;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("pnlElencoFiltri")]
	protected virtual Panel pnlElencoFiltri
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpElencoFiltri_Title")]
	protected virtual Panel cpElencoFiltri_Title
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

	[field: AccessedThroughProperty("cpElencoFiltri_Body")]
	protected virtual Panel cpElencoFiltri_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_ElencoFiltri")]
	protected virtual UpdatePanel up_ElencoFiltri
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Filtri")]
	protected virtual Table Filtri
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtDaData")]
	protected virtual TableRow row_txtDaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtDaData")]
	protected virtual IboWebLabel lbltxtDaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDaData")]
	protected virtual IboWebDate2 txtDaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtAData")]
	protected virtual TableRow row_txtAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtAData")]
	protected virtual IboWebLabel lbltxtAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAData")]
	protected virtual IboWebDate2 txtAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtInData")]
	protected virtual TableRow row_txtInData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtInData")]
	protected virtual IboWebLabel lbltxtInData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtInData")]
	protected virtual IboWebDate2 txtInData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbCliente")]
	protected virtual TableRow row_cmbCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbCliente")]
	protected virtual IboWebLabel lblcmbCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCliente")]
	protected virtual IboWebComboTlk cmbCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbPCSPartenza")]
	protected virtual TableRow row_cmbPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbPCSPartenza")]
	protected virtual IboWebLabel lblcmbPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSPartenza")]
	protected virtual IboWebComboTlk cmbPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbPCSDestinazione")]
	protected virtual TableRow row_cmbPCSDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbPCSDestinazione")]
	protected virtual IboWebLabel lblcmbPCSDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSDestinazione")]
	protected virtual IboWebComboTlk cmbPCSDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbMittente")]
	protected virtual TableRow row_cmbMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbMittente")]
	protected virtual IboWebLabel lblcmbMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMittente")]
	protected virtual IboWebComboTlk cmbMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbVettore")]
	protected virtual TableRow row_cmbVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbVettore")]
	protected virtual IboWebLabel lblcmbVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbVettore")]
	protected virtual IboWebComboTlk cmbVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbCorrispondente")]
	protected virtual TableRow row_cmbCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbCorrispondente")]
	protected virtual IboWebLabel lblcmbCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCorrispondente")]
	protected virtual IboWebComboTlk cmbCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbMacroZona")]
	protected virtual TableRow row_cmbMacroZona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbMacroZona")]
	protected virtual IboWebLabel lblcmbMacroZona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMacroZona")]
	protected virtual IboWebComboTlk cmbMacroZona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbZonaSpedizione")]
	protected virtual TableRow row_cmbZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbZonaSpedizione")]
	protected virtual IboWebLabel lblcmbZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaSpedizione")]
	protected virtual IboWebComboTlk cmbZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbZonaArrivoTariffaPassiva")]
	protected virtual TableRow row_cmbZonaArrivoTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbZonaArrivoTariffaPassiva")]
	protected virtual IboWebLabel lblcmbZonaArrivoTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivoTariffaPassiva")]
	protected virtual IboWebComboTlk cmbZonaArrivoTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbNazione")]
	protected virtual TableRow row_cmbNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbNazione")]
	protected virtual IboWebLabel lblcmbNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbNazione")]
	protected virtual IboWebComboTlk cmbNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbRegione")]
	protected virtual TableRow row_cmbRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbRegione")]
	protected virtual IboWebLabel lblcmbRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbRegione")]
	protected virtual IboWebComboTlk cmbRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbProvincia")]
	protected virtual TableRow row_cmbProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbProvincia")]
	protected virtual IboWebLabel lblcmbProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbProvincia")]
	protected virtual IboWebComboTlk cmbProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbFree1")]
	protected virtual TableRow row_cmbFree1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbFree1")]
	protected virtual IboWebLabel lblcmbFree1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFree1")]
	protected virtual IboWebComboTlk cmbFree1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbFree2")]
	protected virtual TableRow row_cmbFree2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbFree2")]
	protected virtual IboWebLabel lblcmbFree2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFree2")]
	protected virtual IboWebComboTlk cmbFree2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_cmbFree3")]
	protected virtual TableRow row_cmbFree3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblcmbFree3")]
	protected virtual IboWebLabel lblcmbFree3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFree3")]
	protected virtual IboWebComboTlk cmbFree3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtTesto1")]
	protected virtual TableRow row_txtTesto1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtTesto1")]
	protected virtual IboWebLabel lbltxtTesto1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTesto1")]
	protected virtual IboWebTextBox txtTesto1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtTesto2")]
	protected virtual TableRow row_txtTesto2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtTesto2")]
	protected virtual IboWebLabel lbltxtTesto2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTesto2")]
	protected virtual IboWebTextBox txtTesto2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtTesto3")]
	protected virtual TableRow row_txtTesto3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtTesto3")]
	protected virtual IboWebLabel lbltxtTesto3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTesto3")]
	protected virtual IboWebTextBox txtTesto3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtNumero1")]
	protected virtual TableRow row_txtNumero1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtNumero1")]
	protected virtual IboWebLabel lbltxtNumero1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumero1")]
	protected virtual IboWebNumericTlk txtNumero1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtNumero2")]
	protected virtual TableRow row_txtNumero2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtNumero2")]
	protected virtual IboWebLabel lbltxtNumero2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumero2")]
	protected virtual IboWebNumericTlk txtNumero2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("row_txtNumero3")]
	protected virtual TableRow row_txtNumero3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltxtNumero3")]
	protected virtual IboWebLabel lbltxtNumero3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumero3")]
	protected virtual IboWebNumericTlk txtNumero3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HiddenField1")]
	protected virtual IboWebHidden HiddenField1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HiddenField2")]
	protected virtual IboWebHidden HiddenField2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HiddenField3")]
	protected virtual IboWebHidden HiddenField3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HiddenField4")]
	protected virtual IboWebHidden HiddenField4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_btnConferma")]
	protected virtual UpdatePanel up_btnConferma
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFSTAGeneraStatistica()
	{
		_Statistic = null;
	}

	protected override bool IsWfiIdentity(ref IIboWebComponent obj)
	{
		return false;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.STA.GENERA";
		_ReturnToCallerAfterConfirm = false;
		_Title = base.Translator.Translate("XXX", "Elenco Filtri", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdStatistiche;
			iboInternalGridConfig.InitUi(myViewState, ref objGridView);
			grdStatistiche = objGridView;
			string text2 = "";
			if (((Page)this).Request.QueryString["CodiceStatistica"] != null)
			{
				text2 = ((Page)this).Request.QueryString["CodiceStatistica"];
			}
			text = "SELECT * FROM GRD_WFI_Statistiche WHERE (ATTIVO = 'S') AND (VISIBILE = 'S') AND ";
			text = text + "(UTENTE = " + base.DbConn.SQLFormatString(base.WFIUser) + " ";
			text = text + "OR UTENTE = " + base.DbConn.SQLFormatString(base.WFIGroup) + " ";
			text = text + "OR UTENTE = " + base.DbConn.SQLFormatString(base.WFIOrganization) + " ";
			text = text + "OR UTENTE = " + base.DbConn.SQLFormatString(base.WFIOrganizationType) + ") ";
			if (Operators.CompareString(text2, "", false) != 0)
			{
				text = text + " AND (Codice=" + base.DbConn.SQLFormatString(text2) + ") ";
			}
			iboInternalGridConfig.Build("WFI.STA.STATISTICHE", text, "", "", ((Control)grdStatistiche).ID, ((Control)tlbgrdStatistiche).ID);
			GridConfigList.Add(iboInternalGridConfig);
			val = base.InitializeInternalGrid(ref rsMess);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (!((Page)this).IsPostBack)
				{
					grdStatistiche.SelectFirstRow();
					grdStatistiche_MultiSelectChanged(grdStatistiche, new EventArgs());
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

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DisabilitaFiltri();
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		DataKeyFieldValues[] array = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.SaveData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (!_SessionVariable.ContainsKey("STATISTICA"))
			{
				rsMess = TranslateMessage("XXX", "Nessuna statistica selezionata");
			}
			else
			{
				_Statistic = (Statistic)_SessionVariable["STATISTICA"];
				List<StatisticRunningFilter> list = new List<StatisticRunningFilter>();
				foreach (StatisticFilter item in _Statistic.Filtri)
				{
					IIboWebComponent val3 = (IIboWebComponent)GetControlByName((Control)(object)this, item.IdControlloUI);
					StatisticRunningFilter val4 = new StatisticRunningFilter();
					val4.ValoreCampo = null;
					if ((int)val3.FieldDataType == 0)
					{
						if (Operators.CompareString(val3.ObjValue.ToString(), "", false) != 0)
						{
							val4.ValoreCampo = val3.ObjValue.ToString();
						}
					}
					else if ((int)val3.FieldDataType == 1)
					{
						if (Operators.CompareString(val3.ObjValue.ToString(), "", false) != 0)
						{
							val4.ValoreCampo = Conversions.ToDecimal(val3.ObjValue);
						}
					}
					else if ((int)val3.FieldDataType == 2 && Operators.CompareString(val3.ObjValue.ToString(), "", false) != 0)
					{
						val4.ValoreCampo = ((IboWebDate2)(object)val3).getDateValue;
					}
					val4.NomeCampo = item.NomeCampo;
					val4.DescrizioneCampo = item.DescrizioneCampo;
					switch (val3.IncasTag)
					{
					case "UGUALE":
						val4.Operatore = (StatisticOperatore)0;
						break;
					case "MAGGIORE_UGUALE":
						val4.Operatore = (StatisticOperatore)2;
						break;
					case "MINORE_UGUALE":
						val4.Operatore = (StatisticOperatore)4;
						break;
					case "MAGGIORE":
						val4.Operatore = (StatisticOperatore)1;
						break;
					case "MINORE":
						val4.Operatore = (StatisticOperatore)3;
						break;
					case "LIKE":
						val4.Operatore = (StatisticOperatore)5;
						break;
					case "DIVERSO":
						val4.Operatore = (StatisticOperatore)6;
						break;
					}
					list.Add(val4);
				}
				string text = "";
				val2 = base.SessionEnvironment.StatisticManager.Run(_Statistic.Codice, list, ref text, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if ((Operators.CompareString(text, "", false) != 0) & !_Statistic.Asincrona)
					{
						IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
						string sNomeFile = text;
						string rsMess2 = "";
						sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess2);
						FunctionArguments functionArguments = new FunctionArguments("", "");
						((Page)this).Session["FunctionArgsReportPage"] = functionArguments;
						functionArguments.Argomento1 = "#SHOWMODE";
						functionArguments.Argomento2 = text;
						functionArguments.Argomento3 = "PDF";
						IboAppCallStackHandling robjCallStackHandler = base.CallStackHandler;
						rsMess2 = "~/WFI/Form/WFStandardReport.aspx";
						BaseFunctions.IboResponseRedirect(ref robjCallStackHandler, ref rsMess2);
						goto IL_047e;
					}
					if (_Statistic.Asincrona)
					{
						_ReturnToCallerAfterConfirm = true;
						_WarningMessageNotification = TranslateMessage("La richiesta di creazione della statistica è stata effettuata. Andare nel centro di consultazione delle statistiche per vedere il risultato");
						goto IL_047e;
					}
					rsMess = TranslateMessage("La statistica è stata lanciata ma l'engine statistico non ha prodotto nessun risultato");
				}
			}
			goto end_IL_000e;
			IL_047e:
			val = (FXRETURN)0;
			end_IL_000e:;
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

	private void grdStatistiche_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Invalid comparison between Unknown and I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Invalid comparison between Unknown and I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Invalid comparison between Unknown and I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Invalid comparison between Unknown and I4
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Invalid comparison between Unknown and I4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		_Closure_0024__387_002D0 arg = default(_Closure_0024__387_002D0);
		_Closure_0024__387_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__387_002D0(arg);
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		CS_0024_003C_003E8__locals0._0024VB_0024Local_objData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		try
		{
			DisabilitaFiltri();
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdStatistiche).ID];
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref CS_0024_003C_003E8__locals0._0024VB_0024Local_objData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			if (_SessionVariable.ContainsKey("resetPropsListCollection"))
			{
				ResetPropertiesListCollection resetPropertiesListCollection = (ResetPropertiesListCollection)_SessionVariable["resetPropsListCollection"];
				foreach (ResetProperties item in resetPropertiesListCollection)
				{
					Control controlByName = GetControlByName((Control)(object)this, item.Id);
					if (controlByName is IboWebComboTlk)
					{
						IboWebComboTlk val3 = (IboWebComboTlk)controlByName;
						bool flag = false;
						if (item.Properties.ContainsKey("SqlQuery"))
						{
							val3.SqlQuery = item.Properties["SqlQuery"];
							flag = true;
						}
						if (item.Properties.ContainsKey("SqlQueryWhere"))
						{
							val3.SqlQueryWhere = item.Properties["SqlQueryWhere"];
							flag = true;
						}
						if (item.Properties.ContainsKey("Width"))
						{
							((RadDataBoundControl)val3).Width = new Unit(Conversions.ToDouble(item.Properties["Width"]), (UnitType)1);
							flag = true;
						}
						if (flag && ((Page)this).IsPostBack)
						{
							string sqlQueryWhere = val3.SqlQueryWhere;
							string rsMess2 = "";
							ComboSetFilter((IIboDropdownList)(object)val3, sqlQueryWhere, ref rsMess2);
						}
					}
					else if (controlByName is IboWebTextBox)
					{
						IboWebTextBox val4 = (IboWebTextBox)controlByName;
						if (item.Properties.ContainsKey("Width"))
						{
							((WebControl)val4).Width = new Unit(Conversions.ToDouble(item.Properties["Width"]), (UnitType)1);
						}
						if (item.Properties.ContainsKey("MaxLength"))
						{
							((TextBox)val4).MaxLength = Conversions.ToInteger(item.Properties["MaxLength"]);
						}
					}
					else if (!(controlByName is IboWebHidden) && controlByName is IboWebNumericTlk)
					{
						IboWebNumericTlk val5 = (IboWebNumericTlk)controlByName;
						if (item.Properties.ContainsKey("Width"))
						{
							((RadInputControl)val5).Width = new Unit(Conversions.ToDouble(item.Properties["Width"]), (UnitType)1);
						}
						if (item.Properties.ContainsKey("MaxValue"))
						{
							((RadNumericTextBox)val5).MaxValue = Conversions.ToDouble(item.Properties["MaxValue"]);
							val5.WFIMaxValue = Conversions.ToDouble(item.Properties["MaxValue"]);
						}
						if (item.Properties.ContainsKey("MinValue"))
						{
							((RadNumericTextBox)val5).MinValue = Conversions.ToDouble(item.Properties["MinValue"]);
							val5.WFIMinValue = Conversions.ToDouble(item.Properties["MinValue"]);
						}
						if (item.Properties.ContainsKey("DecimalDigits"))
						{
							val5.DecimalDigits = Conversions.ToInteger(item.Properties["DecimalDigits"]);
						}
					}
				}
				_SessionVariable.Remove("resetPropsListCollection");
			}
			ResetPropertiesListCollection resetPropertiesListCollection2 = new ResetPropertiesListCollection();
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_objData.Count > 0)
			{
				IEnumerable<Statistic> source = ((IEnumerable<Statistic>)base.SessionEnvironment.StatisticManager.Statistics).Where([SpecialName] (Statistic stat) => Operators.CompareString(stat.Codice, CS_0024_003C_003E8__locals0._0024VB_0024Local_objData.Item(0).get_FieldValues(0).ToString(), false) == 0);
				if (source.Count() == 0)
				{
					rsMess = TranslateMessage("XXX", "La statistica selezionata non risulta configurata correttamente sul gestore statistico");
					return;
				}
				Statistic val6 = source.FirstOrDefault();
				_SessionVariable["STATISTICA"] = (object)val6;
				foreach (StatisticFilter item2 in val6.Filtri)
				{
					if (!item2.Attivo)
					{
						continue;
					}
					IIboWebComponent val7 = (IIboWebComponent)GetControlByName((Control)(object)this, item2.IdControlloUI);
					if (val7 == null)
					{
						rsMess = TranslateMessage("XXX", "Controllo {0} non trovato in interfaccia", item2.IdControlloUI);
						_SessionVariable.Remove("STATISTICA");
						DisabilitaFiltri();
						return;
					}
					val7.Visible = item2.Visibile;
					val7.Enabled = item2.Enabled;
					val7.FieldName = item2.NomeCampo;
					val7.FieldDescription = item2.DescrizioneCampo;
					val7.ObjValue = item2.ValoreCampo;
					val7.Tooltip = item2.Tooltip;
					val7.Required = item2.Required;
					if ((int)item2.Operatore == 0)
					{
						val7.IncasTag = "UGUALE";
					}
					else if ((int)item2.Operatore == 1)
					{
						val7.IncasTag = "MAGGIORE";
					}
					else if ((int)item2.Operatore == 2)
					{
						val7.IncasTag = "MAGGIORE_UGUALE";
					}
					else if ((int)item2.Operatore == 3)
					{
						val7.IncasTag = "MINORE";
					}
					else if ((int)item2.Operatore == 4)
					{
						val7.IncasTag = "MINORE_UGUALE";
					}
					else if ((int)item2.Operatore == 5)
					{
						val7.IncasTag = "LIKE";
					}
					else if ((int)item2.Operatore == 6)
					{
						val7.IncasTag = "DIVERSO";
					}
					if (Operators.CompareString(item2.Caption, "", false) != 0)
					{
						IIboWebComponent val8 = (IIboWebComponent)GetControlByName((Control)(object)this, "lbl" + item2.IdControlloUI);
						if (val8 != null)
						{
							val8.Text = item2.Caption;
						}
					}
					TableRow val9 = (TableRow)GetControlByName((Control)(object)this, "row_" + item2.IdControlloUI);
					if (val9 != null)
					{
						((Control)val9).Visible = item2.Visibile;
					}
					if (item2.ProprietaControlloUIList.Count <= 0)
					{
						continue;
					}
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					string vsId = "";
					Unit width;
					if (val7 is IboWebComboTlk)
					{
						IboWebComboTlk val10 = (IboWebComboTlk)val7;
						vsId = val10.ID;
						bool flag2 = false;
						if (item2.ProprietaControlloUIList.ContainsKey("SqlQuery"))
						{
							dictionary.Add("SqlQuery", val10.SqlQuery);
							string text2 = item2.ProprietaControlloUIList["SqlQuery"];
							text2 = text2.Replace("%eq%", "=");
							text2 = text2.Replace("%Eq%", "=");
							text2 = text2.Replace("%EQ%", "=");
							val10.SqlQuery = text2;
							flag2 = true;
						}
						if (item2.ProprietaControlloUIList.ContainsKey("SqlQueryWhere"))
						{
							dictionary.Add("SqlQueryWhere", val10.SqlQueryWhere);
							string text3 = item2.ProprietaControlloUIList["SqlQueryWhere"];
							text3 = text3.Replace("%eq%", "=");
							text3 = text3.Replace("%Eq%", "=");
							text3 = text3.Replace("%EQ%", "=");
							val10.SqlQueryWhere = text3;
							flag2 = true;
						}
						if (item2.ProprietaControlloUIList.ContainsKey("Width"))
						{
							width = ((RadDataBoundControl)val10).Width;
							dictionary.Add("Width", width.Value.ToString());
							((RadDataBoundControl)val10).Width = new Unit(Conversions.ToDouble(item2.ProprietaControlloUIList["Width"]), (UnitType)1);
						}
						if (flag2 && ((Page)this).IsPostBack)
						{
							string sqlQueryWhere2 = val10.SqlQueryWhere;
							string rsMess2 = "";
							ComboSetFilter((IIboDropdownList)(object)val10, sqlQueryWhere2, ref rsMess2);
						}
					}
					else if (val7 is IboWebTextBox)
					{
						IboWebTextBox val11 = (IboWebTextBox)val7;
						vsId = ((Control)val11).ID;
						if (item2.ProprietaControlloUIList.ContainsKey("Width"))
						{
							width = ((WebControl)val11).Width;
							dictionary.Add("Width", width.Value.ToString());
							((WebControl)val11).Width = new Unit(Conversions.ToDouble(item2.ProprietaControlloUIList["Width"]), (UnitType)1);
						}
						if (item2.ProprietaControlloUIList.ContainsKey("MaxLength"))
						{
							dictionary.Add("MaxLength", ((TextBox)val11).MaxLength.ToString());
							((TextBox)val11).MaxLength = Conversions.ToInteger(item2.ProprietaControlloUIList["MaxLength"]);
						}
					}
					else if (val7 is IboWebNumericTlk)
					{
						IboWebNumericTlk val12 = (IboWebNumericTlk)val7;
						vsId = ((Control)val12).ID;
						if (item2.ProprietaControlloUIList.ContainsKey("Width"))
						{
							width = ((RadInputControl)val12).Width;
							dictionary.Add("Width", width.Value.ToString());
							((RadInputControl)val12).Width = new Unit(Conversions.ToDouble(item2.ProprietaControlloUIList["Width"]), (UnitType)1);
						}
						if (item2.ProprietaControlloUIList.ContainsKey("MaxValue"))
						{
							dictionary.Add("MaxValue", ((RadNumericTextBox)val12).MaxValue.ToString());
							((RadNumericTextBox)val12).MaxValue = Conversions.ToDouble(item2.ProprietaControlloUIList["MaxValue"]);
							val12.WFIMaxValue = Conversions.ToDouble(item2.ProprietaControlloUIList["MaxValue"]);
						}
						if (item2.ProprietaControlloUIList.ContainsKey("MinValue"))
						{
							dictionary.Add("MinValue", ((RadNumericTextBox)val12).MinValue.ToString());
							((RadNumericTextBox)val12).MinValue = Conversions.ToDouble(item2.ProprietaControlloUIList["MinValue"]);
							val12.WFIMinValue = Conversions.ToDouble(item2.ProprietaControlloUIList["MinValue"]);
						}
						if (item2.ProprietaControlloUIList.ContainsKey("DecimalDigits"))
						{
							dictionary.Add("DecimalDigits", val12.DecimalDigits.ToString());
							val12.DecimalDigits = Conversions.ToInteger(item2.ProprietaControlloUIList["DecimalDigits"]);
						}
					}
					if (dictionary.Count > 0)
					{
						resetPropertiesListCollection2.Add(new ResetProperties(vsId, dictionary));
					}
				}
			}
			else
			{
				_SessionVariable.Remove("STATISTICA");
			}
			if (resetPropertiesListCollection2.Count > 0)
			{
				_SessionVariable.Add("resetPropsListCollection", resetPropertiesListCollection2);
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
			up_ElencoFiltri.Update();
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected virtual void DisabilitaFiltri()
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Invalid comparison between Unknown and I4
		List<IIboWebComponent> list = new List<IIboWebComponent>();
		list.Add((IIboWebComponent)(object)txtDaData);
		list.Add((IIboWebComponent)(object)txtAData);
		list.Add((IIboWebComponent)(object)txtInData);
		list.Add((IIboWebComponent)(object)cmbCliente);
		list.Add((IIboWebComponent)(object)cmbCorrispondente);
		list.Add((IIboWebComponent)(object)cmbMacroZona);
		list.Add((IIboWebComponent)(object)cmbMittente);
		list.Add((IIboWebComponent)(object)cmbNazione);
		list.Add((IIboWebComponent)(object)cmbPCSDestinazione);
		list.Add((IIboWebComponent)(object)cmbPCSPartenza);
		list.Add((IIboWebComponent)(object)cmbProvincia);
		list.Add((IIboWebComponent)(object)cmbRegione);
		list.Add((IIboWebComponent)(object)cmbVettore);
		list.Add((IIboWebComponent)(object)cmbZonaSpedizione);
		list.Add((IIboWebComponent)(object)cmbZonaArrivoTariffaPassiva);
		list.Add((IIboWebComponent)(object)cmbFree1);
		list.Add((IIboWebComponent)(object)cmbFree2);
		list.Add((IIboWebComponent)(object)cmbFree3);
		list.Add((IIboWebComponent)(object)txtNumero1);
		list.Add((IIboWebComponent)(object)txtNumero2);
		list.Add((IIboWebComponent)(object)txtNumero3);
		list.Add((IIboWebComponent)(object)txtTesto1);
		list.Add((IIboWebComponent)(object)txtTesto2);
		list.Add((IIboWebComponent)(object)txtTesto3);
		foreach (IIboWebComponent item in list)
		{
			item.Visible = false;
			item.Enabled = true;
			item.FieldName = "";
			if ((int)item.FieldDataType == 0)
			{
				item.ObjValue = "";
			}
			else if ((int)item.FieldDataType == 2)
			{
				item.ObjValue = "";
			}
			else if ((int)item.FieldDataType == 1)
			{
				item.ObjValue = "";
			}
			item.Tooltip = "";
			item.Required = false;
		}
		((Control)row_txtDaData).Visible = false;
		((Control)row_txtAData).Visible = false;
		((Control)row_txtInData).Visible = false;
		((Control)row_cmbCliente).Visible = false;
		((Control)row_cmbCorrispondente).Visible = false;
		((Control)row_cmbMacroZona).Visible = false;
		((Control)row_cmbMittente).Visible = false;
		((Control)row_cmbNazione).Visible = false;
		((Control)row_cmbPCSDestinazione).Visible = false;
		((Control)row_cmbPCSPartenza).Visible = false;
		((Control)row_cmbProvincia).Visible = false;
		((Control)row_cmbRegione).Visible = false;
		((Control)row_cmbVettore).Visible = false;
		((Control)row_cmbZonaSpedizione).Visible = false;
		((Control)row_cmbZonaArrivoTariffaPassiva).Visible = false;
		((Control)row_cmbFree1).Visible = false;
		((Control)row_cmbFree2).Visible = false;
		((Control)row_cmbFree3).Visible = false;
		((Control)row_txtNumero1).Visible = false;
		((Control)row_txtNumero2).Visible = false;
		((Control)row_txtNumero3).Visible = false;
		((Control)row_txtTesto1).Visible = false;
		((Control)row_txtTesto2).Visible = false;
		((Control)row_txtTesto3).Visible = false;
	}
}
