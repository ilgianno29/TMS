using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANALocalita : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnInserimento")]
	private IboWebButton _btnInserimento;

	protected string _Mode;

	protected const string _kLOCALITA = "LOCALITA";

	protected const string _kPROVINCIA = "PROVINCIA";

	protected const string _kREGIONE = "REGIONE";

	protected const string _kNAZIONE = "NAZIONE";

	protected const string _kCAP = "CAP";

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

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebTextBox txtId
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

	[field: AccessedThroughProperty("cpInfoGen_Body_Localita")]
	protected virtual Panel cpInfoGen_Body_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loc_lblLocalita")]
	protected virtual IboWebLabel loc_lblLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_Localita")]
	protected virtual IboWebTextBox Loc_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_lblCap")]
	protected virtual IboWebLabel Loc_lblCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_Cap")]
	protected virtual IboWebTextBox Loc_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_lblRegione")]
	protected virtual IboWebLabel Loc_lblRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_Regione")]
	protected virtual IboWebTextBox Loc_Regione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_lblProvincia")]
	protected virtual IboWebLabel Loc_lblProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_Provincia")]
	protected virtual IboWebTextBox Loc_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_lblNazione")]
	protected virtual IboWebLabel Loc_lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Loc_Nazione")]
	protected virtual IboWebTextBox Loc_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body_Provincia")]
	protected virtual Panel cpInfoGen_Body_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_lblProvincia")]
	protected virtual IboWebLabel Prv_lblProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_Provincia")]
	protected virtual IboWebTextBox Prv_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_lblRegione")]
	protected virtual IboWebLabel Prv_lblRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_Regione")]
	protected virtual IboWebTextBox Prv_Regione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_lblNazione")]
	protected virtual IboWebLabel Prv_lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_Nazione")]
	protected virtual IboWebTextBox Prv_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prv_lblDescrizione")]
	protected virtual IboWebLabel prv_lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Prv_Descrizione")]
	protected virtual IboWebTextBox Prv_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body_Regione")]
	protected virtual Panel cpInfoGen_Body_Regione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_lblRegione")]
	protected virtual IboWebLabel Reg_lblRegione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_Regione")]
	protected virtual IboWebTextBox Reg_Regione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_lblNazione")]
	protected virtual IboWebLabel Reg_lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_Nazione")]
	protected virtual IboWebTextBox Reg_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_lblDescrizione")]
	protected virtual IboWebLabel Reg_lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reg_Descrizione")]
	protected virtual IboWebTextBox Reg_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body_Nazione")]
	protected virtual Panel cpInfoGen_Body_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Naz_lblNazione")]
	protected virtual IboWebLabel Naz_lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Naz_Nazione")]
	protected virtual IboWebTextBox Naz_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Naz_lblDescrizione")]
	protected virtual IboWebLabel Naz_lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Naz_Descrizione")]
	protected virtual IboWebTextBox Naz_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body_Cap")]
	protected virtual Panel cpInfoGen_Body_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_lblCap")]
	protected virtual IboWebLabel Cap_lblCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_Cap")]
	protected virtual IboWebTextBox Cap_Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_lblNazione")]
	protected virtual IboWebLabel Cap_lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_Nazione")]
	protected virtual IboWebTextBox Cap_Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_lblDescrizione")]
	protected virtual IboWebLabel Cap_lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap_Descrizione")]
	protected virtual IboWebTextBox Cap_Descrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpLocalitaZone_Title")]
	protected virtual Panel cpLocalitaZone_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpLocalitaZone_Title_Caption")]
	protected virtual IboWebLabel cpLocalitaZone_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpLocalitaZone_Body")]
	protected virtual Panel cpLocalitaZone_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbgrdLocalitaZone")]
	protected virtual IboWebToolbar tlbgrdLocalitaZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlLocalitaZone")]
	protected virtual Panel pnlLocalitaZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdLocalitaZone")]
	protected virtual IboGridView grdLocalitaZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnInserimento
	{
		[CompilerGenerated]
		get
		{
			return _btnInserimento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnInserimento_Click;
			IboWebButton val = _btnInserimento;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnInserimento = value;
			val = _btnInserimento;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	public WFANALocalita()
	{
		_Mode = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		_Mode = ((Page)this).Request.QueryString["Mode"] ?? "";
		if (Operators.CompareString(_Mode, "", false) == 0)
		{
			_Mode = "LOCALITA";
		}
		if (Operators.CompareString(_Mode, "LOCALITA", false) == 0)
		{
			_Context = "DM.ANA.LOCALITA";
		}
		else if (Operators.CompareString(_Mode, "PROVINCIA", false) == 0)
		{
			_Context = "DM.ANA.PROVINCE";
		}
		else if (Operators.CompareString(_Mode, "REGIONE", false) == 0)
		{
			_Context = "DM.ANA.REGIONI";
		}
		else if (Operators.CompareString(_Mode, "NAZIONE", false) == 0)
		{
			_Context = "DM.ANA.NAZIONI";
		}
		else if (Operators.CompareString(_Mode, "CAP", false) == 0)
		{
			_Context = "DM.ANA.CAP";
		}
		if (!((Page)this).IsPostBack)
		{
			if (Operators.CompareString(_Mode, "LOCALITA", false) == 0)
			{
				_Title = base.Translator.Translate("XXX", "Località", new string[0]);
				Loc_Cap.FieldName = "CAP";
				Loc_Cap.Required = true;
				Loc_Provincia.FieldName = "Provincia";
				Loc_Provincia.Required = true;
				Loc_Localita.FieldName = "Localita";
				Loc_Localita.Required = true;
				Loc_Nazione.FieldName = "Nazione";
				Loc_Nazione.Required = true;
				Loc_Regione.FieldName = "Regione";
				((Control)cpInfoGen_Body_Localita).Visible = true;
			}
			else if (Operators.CompareString(_Mode, "PROVINCIA", false) == 0)
			{
				_Title = base.Translator.Translate("XXX", "Provincia", new string[0]);
				Prv_Descrizione.FieldName = "Descrizione";
				Prv_Provincia.FieldName = "Provincia";
				Prv_Provincia.Required = true;
				Prv_Nazione.FieldName = "Nazione";
				Prv_Nazione.Required = true;
				Prv_Regione.FieldName = "Regione";
				Prv_Regione.Required = true;
				((Control)cpInfoGen_Body_Provincia).Visible = true;
			}
			else if (Operators.CompareString(_Mode, "REGIONE", false) == 0)
			{
				_Title = base.Translator.Translate("XXX", "Regione", new string[0]);
				Reg_Descrizione.FieldName = "Descrizione";
				Reg_Nazione.FieldName = "Nazione";
				Reg_Nazione.Required = true;
				Reg_Regione.FieldName = "Regione";
				Reg_Regione.Required = true;
				((Control)cpInfoGen_Body_Regione).Visible = true;
			}
			else if (Operators.CompareString(_Mode, "NAZIONE", false) == 0)
			{
				_Title = base.Translator.Translate("XXX", "Nazione", new string[0]);
				Naz_Descrizione.FieldName = "Descrizione";
				Naz_Nazione.FieldName = "Nazione";
				Naz_Nazione.Required = true;
				((Control)cpInfoGen_Body_Nazione).Visible = true;
			}
			else if (Operators.CompareString(_Mode, "CAP", false) == 0)
			{
				_Title = base.Translator.Translate("XXX", "Cap", new string[0]);
				Cap_Descrizione.FieldName = "Descrizione";
				Cap_Nazione.FieldName = "Nazione";
				Cap_Nazione.Required = true;
				Cap_Cap.FieldName = "Cap";
				Cap_Cap.Required = true;
				((Control)cpInfoGen_Body_Cap).Visible = true;
			}
		}
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdLocalitaZone;
			iboInternalGridConfig.InitUi(myViewState, ref objGridView);
			grdLocalitaZone = objGridView;
			iboInternalGridConfig.Build("DM.ANA.LOCALITAZONE", "SELECT * FROM GRD_ANA_LocalitaZone WHERE IdLocalita='<%ID%>'", "", "", ((Control)grdLocalitaZone).ID, ((Control)tlbgrdLocalitaZone).ID);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
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
			val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
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
			val2 = base.AfterSaveData(ref rsMess);
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
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
			val2 = base.BeforeSaveData(ref rsMess);
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

	protected override FXRETURN BeforeLoadData(ref string rsMess)
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
			val2 = base.BeforeLoadData(ref rsMess);
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

	protected override FXRETURN LoadPage(ref string rsMess)
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
			val2 = base.LoadPage(ref rsMess);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
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

	private void btnInserimento_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		bool needToRefresh = base.SessionEnvironment.UserMessage.NeedToRefresh;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string[] array = null;
		string text = "";
		try
		{
			StreamReader streamReader = new StreamReader("C:\\Users\\frovatti\\Desktop\\listacomuni.csv");
			string text2 = "";
			text2 = streamReader.ReadLine();
			string rsMess2 = "";
			WFIBeginTransaction(ref rsMess2);
			while (Operators.CompareString(text2, "", false) != 0)
			{
				array = text2.Split(new char[1] { ';' });
				long num = 0L;
				val2 = base.Parametrica.LeggiContatore("COUNTERS.LOCALITA", false, ref num, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				text = "";
				text += "INSERT INTO LOCALITA(ID,NAZIONE,LOCALITA,REGIONE,PROVINCIA,CAP) VALUES (";
				text = text + base.DbConn.SQLFormatNumber(ref num) + ",";
				text = text + base.DbConn.SQLFormatString("ITA") + ",";
				text = text + base.DbConn.SQLFormatString(array[0].ToUpper()) + ",";
				text = text + base.DbConn.SQLFormatString(array[1].ToUpper()) + ",";
				text = text + base.DbConn.SQLFormatString(array[2].ToUpper()) + ",";
				text = text + base.DbConn.SQLFormatString(array[3].ToUpper()) + ");";
				val = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val > 0)
				{
					return;
				}
				text2 = streamReader.ReadLine();
			}
			rsMess2 = "";
			WFICommitTransaction(ref rsMess2);
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
				WFIRollbackTransaction(ref rsMess2);
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			val2 = base.InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			object PropertyValue = RuntimeHelpers.GetObjectValue(txtId.ObjValue);
			SetFormState(objInternalGridConfig.RedirectToOnlyAspxPageName, "lblCodiceSoggettoValue", "Text", ref PropertyValue);
			val2 = base.InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAggiorna(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	[WebMethod(EnableSession = true)]
	public static string[] GetCountryNames(string keyword, string tag)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text = "SELECT NAZIONE %+% ' @@@ ' %+% %ISNULL%(DESCRIZIONE,NAZIONE) DESCRIZIONE FROM NAZIONI WHERE NAZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
		text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY NAZIONE";
		text = val.SqlConvertForServer(text);
		DataTable dataTable = null;
		string text2 = text;
		string text3 = "";
		val.OpenDataTable(text2, ref dataTable, ref text3);
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row["DESCRIZIONE"].ToString());
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	[WebMethod(EnableSession = true)]
	public static string[] GetRegionNames(string keyword, string tag)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text = "SELECT REGIONE %+% ' @@@ ' %+% %ISNULL%(DESCRIZIONE,REGIONE) DESCRIZIONE FROM REGIONI WHERE REGIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
		text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY REGIONE";
		text = val.SqlConvertForServer(text);
		DataTable dataTable = null;
		string text2 = text;
		string text3 = "";
		val.OpenDataTable(text2, ref dataTable, ref text3);
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row["DESCRIZIONE"].ToString());
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	[WebMethod(EnableSession = true)]
	public static string[] GetDepartmentNames(string keyword, string tag)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text = "SELECT PROVINCIA %+% ' @@@ ' %+% %ISNULL%(DESCRIZIONE,PROVINCIA) DESCRIZIONE FROM PROVINCE WHERE PROVINCIA LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
		text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY PROVINCIA";
		text = val.SqlConvertForServer(text);
		DataTable dataTable = null;
		string text2 = text;
		string text3 = "";
		val.OpenDataTable(text2, ref dataTable, ref text3);
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row["DESCRIZIONE"].ToString());
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	protected static string[] _GetCapNames(string keyword)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		string key = HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' })[checked(HttpContext.Current.Request.Url.LocalPath.Split(new char[1] { '/' }).Length - 2)];
		IboSessionEnvironment iboSessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
		IboDictionaryCollection<string, object> iboDictionaryCollection = iboSessionEnvironment.SessionVariables[key];
		List<string> list = new List<string>();
		DBConnection val = (DBConnection)iboSessionEnvironment.DbConn.Clone();
		string text = "SELECT CAP %+% ' @@@ ' %+% %ISNULL%(DESCRIZIONE,CAP) DESCRIZIONE FROM CAP WHERE CAP LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ";
		text = text + "OR DESCRIZIONE LIKE '%" + Strings.Replace(keyword, "'", "''", 1, -1, (CompareMethod)0) + "%' ORDER BY CAP";
		text = val.SqlConvertForServer(text);
		DataTable dataTable = null;
		string text2 = text;
		string text3 = "";
		val.OpenDataTable(text2, ref dataTable, ref text3);
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row["DESCRIZIONE"].ToString());
		}
		text3 = "";
		val.CloseConnection(ref text3);
		return list.ToArray();
	}

	[WebMethod(EnableSession = true)]
	public new static string[] GetAutocompleteItems(string keyword, string tag)
	{
		if (Operators.CompareString(tag.ToUpper(), "CAP", false) == 0)
		{
			return _GetCapNames(keyword);
		}
		if (Operators.CompareString(tag.ToUpper(), "REGIONI", false) == 0)
		{
			return GetRegionNames(keyword, tag);
		}
		if (Operators.CompareString(tag.ToUpper(), "NAZIONI", false) == 0)
		{
			return GetCountryNames(keyword, tag);
		}
		if (Operators.CompareString(tag.ToUpper(), "PROVINCE", false) == 0)
		{
			return GetDepartmentNames(keyword, tag);
		}
		return new List<string>().ToArray();
	}
}
