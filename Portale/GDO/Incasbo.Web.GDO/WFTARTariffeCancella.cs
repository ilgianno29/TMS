using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFTARTariffeCancella : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelTipoSpedizione")]
	private IboWebCheckBox _SelTipoSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelTipoMerce")]
	private IboWebCheckBox _SelTipoMerce;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelTipoMezzo")]
	private IboWebCheckBox _SelTipoMezzo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelCliente")]
	private IboWebCheckBox _SelCliente;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelGruppoTariffarioPartenza")]
	private IboWebCheckBox _SelGruppoTariffarioPartenza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelPCSPartenza")]
	private IboWebCheckBox _SelPCSPartenza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelMacroZonaArrivo")]
	private IboWebCheckBox _SelMacroZonaArrivo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelZonaArrivo")]
	private IboWebCheckBox _SelZonaArrivo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelGruppoTariffarioArrivo")]
	private IboWebCheckBox _SelGruppoTariffarioArrivo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelPCSArrivo")]
	private IboWebCheckBox _SelPCSArrivo;

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

	[field: AccessedThroughProperty("cpEstremi_Title")]
	protected virtual Panel cpEstremi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEstremi_Title_Caption")]
	protected virtual IboWebLabel cpEstremi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEstremi_Body")]
	protected virtual Panel cpEstremi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContratto")]
	protected virtual IboWebLabel lblContratto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContrattoValue")]
	protected virtual IboWebLabel lblContrattoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumento")]
	protected virtual IboWebLabel lblTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumentoValue")]
	protected virtual IboWebLabel lblTipoDocumentoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelTipoSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _SelTipoSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelTipoSpedizione_CheckedChanged;
			IboWebCheckBox selTipoSpedizione = _SelTipoSpedizione;
			if (selTipoSpedizione != null)
			{
				((CheckBox)selTipoSpedizione).CheckedChanged -= eventHandler;
			}
			_SelTipoSpedizione = value;
			selTipoSpedizione = _SelTipoSpedizione;
			if (selTipoSpedizione != null)
			{
				((CheckBox)selTipoSpedizione).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblTipoSpedizione")]
	protected virtual IboWebLabel lblTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoSpedizione")]
	protected virtual IboWebComboTlk cmbTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelTipoMerce
	{
		[CompilerGenerated]
		get
		{
			return _SelTipoMerce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelTipoMerce_CheckedChanged;
			IboWebCheckBox selTipoMerce = _SelTipoMerce;
			if (selTipoMerce != null)
			{
				((CheckBox)selTipoMerce).CheckedChanged -= eventHandler;
			}
			_SelTipoMerce = value;
			selTipoMerce = _SelTipoMerce;
			if (selTipoMerce != null)
			{
				((CheckBox)selTipoMerce).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblTipoMerce")]
	protected virtual IboWebLabel lblTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoMerce")]
	protected virtual IboWebComboTlk cmbTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelTipoMezzo
	{
		[CompilerGenerated]
		get
		{
			return _SelTipoMezzo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelTipoMezzo_CheckedChanged;
			IboWebCheckBox selTipoMezzo = _SelTipoMezzo;
			if (selTipoMezzo != null)
			{
				((CheckBox)selTipoMezzo).CheckedChanged -= eventHandler;
			}
			_SelTipoMezzo = value;
			selTipoMezzo = _SelTipoMezzo;
			if (selTipoMezzo != null)
			{
				((CheckBox)selTipoMezzo).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblTipoMezzo")]
	protected virtual IboWebLabel lblTipoMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoMezzo")]
	protected virtual IboWebComboTlk cmbTipoMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClienteModifica")]
	protected virtual Table ClienteModifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelCliente
	{
		[CompilerGenerated]
		get
		{
			return _SelCliente;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelCliente_CheckedChanged;
			IboWebCheckBox selCliente = _SelCliente;
			if (selCliente != null)
			{
				((CheckBox)selCliente).CheckedChanged -= eventHandler;
			}
			_SelCliente = value;
			selCliente = _SelCliente;
			if (selCliente != null)
			{
				((CheckBox)selCliente).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblCliente")]
	protected virtual IboWebLabel lblCliente
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

	protected virtual IboWebCheckBox SelGruppoTariffarioPartenza
	{
		[CompilerGenerated]
		get
		{
			return _SelGruppoTariffarioPartenza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelGruppoTariffarioPartenza_CheckedChanged;
			IboWebCheckBox selGruppoTariffarioPartenza = _SelGruppoTariffarioPartenza;
			if (selGruppoTariffarioPartenza != null)
			{
				((CheckBox)selGruppoTariffarioPartenza).CheckedChanged -= eventHandler;
			}
			_SelGruppoTariffarioPartenza = value;
			selGruppoTariffarioPartenza = _SelGruppoTariffarioPartenza;
			if (selGruppoTariffarioPartenza != null)
			{
				((CheckBox)selGruppoTariffarioPartenza).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioPartenza")]
	protected virtual IboWebLabel lblGruppoTariffarioPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGruppoTariffarioPartenza")]
	protected virtual IboWebComboTlk cmbGruppoTariffarioPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelPCSPartenza
	{
		[CompilerGenerated]
		get
		{
			return _SelPCSPartenza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelPCSPartenza_CheckedChanged;
			IboWebCheckBox selPCSPartenza = _SelPCSPartenza;
			if (selPCSPartenza != null)
			{
				((CheckBox)selPCSPartenza).CheckedChanged -= eventHandler;
			}
			_SelPCSPartenza = value;
			selPCSPartenza = _SelPCSPartenza;
			if (selPCSPartenza != null)
			{
				((CheckBox)selPCSPartenza).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSPartenza")]
	protected virtual IboWebLabel lblPCSPartenza
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

	protected virtual IboWebCheckBox SelMacroZonaArrivo
	{
		[CompilerGenerated]
		get
		{
			return _SelMacroZonaArrivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelMacroZonaArrivo_CheckedChanged;
			IboWebCheckBox selMacroZonaArrivo = _SelMacroZonaArrivo;
			if (selMacroZonaArrivo != null)
			{
				((CheckBox)selMacroZonaArrivo).CheckedChanged -= eventHandler;
			}
			_SelMacroZonaArrivo = value;
			selMacroZonaArrivo = _SelMacroZonaArrivo;
			if (selMacroZonaArrivo != null)
			{
				((CheckBox)selMacroZonaArrivo).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblMacroZonaArrivo")]
	protected virtual IboWebLabel lblMacroZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMacroZonaArrivo")]
	protected virtual IboWebComboTlk cmbMacroZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelZonaArrivo
	{
		[CompilerGenerated]
		get
		{
			return _SelZonaArrivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelZonaArrivo_CheckedChanged;
			IboWebCheckBox selZonaArrivo = _SelZonaArrivo;
			if (selZonaArrivo != null)
			{
				((CheckBox)selZonaArrivo).CheckedChanged -= eventHandler;
			}
			_SelZonaArrivo = value;
			selZonaArrivo = _SelZonaArrivo;
			if (selZonaArrivo != null)
			{
				((CheckBox)selZonaArrivo).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblZonaArrivo")]
	protected virtual IboWebLabel lblZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivo")]
	protected virtual IboWebComboTlk cmbZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelGruppoTariffarioArrivo
	{
		[CompilerGenerated]
		get
		{
			return _SelGruppoTariffarioArrivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelGruppoTariffarioArrivo_CheckedChanged;
			IboWebCheckBox selGruppoTariffarioArrivo = _SelGruppoTariffarioArrivo;
			if (selGruppoTariffarioArrivo != null)
			{
				((CheckBox)selGruppoTariffarioArrivo).CheckedChanged -= eventHandler;
			}
			_SelGruppoTariffarioArrivo = value;
			selGruppoTariffarioArrivo = _SelGruppoTariffarioArrivo;
			if (selGruppoTariffarioArrivo != null)
			{
				((CheckBox)selGruppoTariffarioArrivo).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblGruppoTariffarioArrivo")]
	protected virtual IboWebLabel lblGruppoTariffarioArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGruppoTariffarioArrivo")]
	protected virtual IboWebComboTlk cmbGruppoTariffarioArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebCheckBox SelPCSArrivo
	{
		[CompilerGenerated]
		get
		{
			return _SelPCSArrivo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SelPCSArrivo_CheckedChanged;
			IboWebCheckBox selPCSArrivo = _SelPCSArrivo;
			if (selPCSArrivo != null)
			{
				((CheckBox)selPCSArrivo).CheckedChanged -= eventHandler;
			}
			_SelPCSArrivo = value;
			selPCSArrivo = _SelPCSArrivo;
			if (selPCSArrivo != null)
			{
				((CheckBox)selPCSArrivo).CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSArrivo")]
	protected virtual IboWebLabel lblPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSArrivo")]
	protected virtual IboWebComboTlk cmbPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtContratto")]
	protected virtual IboWebTextBox txtContratto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtTipoDocumento")]
	protected virtual IboWebTextBox TxtTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = "DM.TAR.TARIFFE#CANCELLA";
			_Title = base.Translator.Translate("XXX", "Cancella Tariffe", new string[0]);
			val2 = base.InitializedPage(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_objFunctionArguments.Name = "MODIFICA";
				base.btnAnnulla = btnAnnulla;
				base.btnConferma = btnConferma;
				base.lblDataAccessMode = lblDataAccessMode;
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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = base.BeforeLoadData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (((Page)this).IsPostBack)
				{
					goto IL_00ee;
				}
				text = "SELECT ATTIVAPASSIVA FROM TARIFFECONTRATTI WHERE CODICE = " + base.DbConn.SQLFormatString(txtContratto.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(Conversions.ToString(obj), "A", false) == 0)
					{
						((Control)ClienteModifica).Visible = false;
						cmbZonaArrivo.SqlQueryFilter = "ZONATARIFFAATTIVA = 'S'";
					}
					else
					{
						((Control)ClienteModifica).Visible = true;
						cmbZonaArrivo.SqlQueryFilter = "ZONATARIFFAPASSIVA = 'S'";
					}
					goto IL_00ee;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_00ee:
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Invalid comparison between Unknown and I4
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int count = 0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (((CheckBox)SelTipoSpedizione).Checked & (Operators.CompareString(cmbTipoSpedizione.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Spedizione");
			}
			else if (((CheckBox)SelTipoMerce).Checked & (Operators.CompareString(cmbTipoMerce.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Merce");
			}
			else if (((CheckBox)SelTipoMezzo).Checked & (Operators.CompareString(cmbTipoMezzo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Mezzo");
			}
			else if (((CheckBox)SelCliente).Checked & (Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Cliente");
			}
			else if (((CheckBox)SelGruppoTariffarioPartenza).Checked & (Operators.CompareString(cmbGruppoTariffarioPartenza.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Gruppo Tariffario Partenza");
			}
			else if (((CheckBox)SelPCSPartenza).Checked & (Operators.CompareString(cmbPCSPartenza.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il PCS Partenza");
			}
			else if (((CheckBox)SelMacroZonaArrivo).Checked & (Operators.CompareString(cmbMacroZonaArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare la Macro Zona Arrivo");
			}
			else if (((CheckBox)SelZonaArrivo).Checked & (Operators.CompareString(cmbZonaArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare la  Zona Arrivo");
			}
			else if (((CheckBox)SelGruppoTariffarioArrivo).Checked & (Operators.CompareString(cmbGruppoTariffarioArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Gruppo Tariffario Arrivo");
			}
			else if (((CheckBox)SelPCSArrivo).Checked & (Operators.CompareString(cmbPCSArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il PCS Arrivo");
			}
			else
			{
				val2 = SearchTariffe(ref count, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					_AreYouSureBlockedMessageTitle = TranslateMessage("XXX", "Cancellazione Tariffe");
					_AreYouSureBlockedMessage = TranslateMessage("XXX", "Verranno cancellate {0} tariffe", count.ToString());
					_AreYouSureBlockedMessageType = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = Tariffe_Cancella.RunProc(CreateApiContext(), txtContratto.ObjValue.ToString(), TxtTipoDocumento.ObjValue.ToString(), cmbTipoSpedizione.ObjValue.ToString(), cmbTipoMerce.ObjValue.ToString(), cmbTipoMezzo.ObjValue.ToString(), cmbCliente.ObjValue.ToString(), cmbGruppoTariffarioPartenza.ObjValue.ToString(), cmbPCSPartenza.ObjValue.ToString(), cmbMacroZonaArrivo.ObjValue.ToString(), cmbZonaArrivo.ObjValue.ToString(), cmbGruppoTariffarioArrivo.ObjValue.ToString(), cmbPCSArrivo.ObjValue.ToString(), ref rsMess);
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

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], "DM.TAR.TRA_ATTIVETESTATA", false) == 0) | (Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], "DM.TAR.TRA_PASSIVETESTATA", false) == 0)))
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

	private void SelTipoSpedizione_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelTipoSpedizione).Checked)
			{
				cmbTipoSpedizione.Enabled = true;
			}
			else
			{
				cmbTipoSpedizione.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelTipoMerce_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelTipoMerce).Checked)
			{
				cmbTipoMerce.Enabled = true;
			}
			else
			{
				cmbTipoMerce.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelTipoMezzo_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelTipoMezzo).Checked)
			{
				cmbTipoMezzo.Enabled = true;
			}
			else
			{
				cmbTipoMezzo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelCliente_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelCliente).Checked)
			{
				cmbCliente.Enabled = true;
			}
			else
			{
				cmbCliente.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelGruppoTariffarioPartenza_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelGruppoTariffarioPartenza).Checked)
			{
				cmbGruppoTariffarioPartenza.Enabled = true;
			}
			else
			{
				cmbGruppoTariffarioPartenza.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelPCSPartenza_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelPCSPartenza).Checked)
			{
				cmbPCSPartenza.Enabled = true;
			}
			else
			{
				cmbPCSPartenza.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelMacroZonaArrivo_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelMacroZonaArrivo).Checked)
			{
				cmbMacroZonaArrivo.Enabled = true;
			}
			else
			{
				cmbMacroZonaArrivo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelZonaArrivo_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelZonaArrivo).Checked)
			{
				cmbZonaArrivo.Enabled = true;
			}
			else
			{
				cmbZonaArrivo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelGruppoTariffarioArrivo_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelGruppoTariffarioArrivo).Checked)
			{
				cmbGruppoTariffarioArrivo.Enabled = true;
			}
			else
			{
				cmbGruppoTariffarioArrivo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelPCSArrivo_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (((CheckBox)SelPCSArrivo).Checked)
			{
				cmbPCSArrivo.Enabled = true;
			}
			else
			{
				cmbPCSArrivo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private FXRETURN SearchTariffe(ref int count, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Invalid comparison between Unknown and I4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
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
			count = 0;
			text = "SELECT ATTIVAPASSIVA FROM TARIFFECONTRATTI WHERE CODICE = " + base.DbConn.SQLFormatString(txtContratto.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text2 = ((Operators.CompareString(Conversions.ToString(obj), "A", false) != 0) ? "TariffePassiveTestata" : "TariffeAttiveTestata");
				text = "SELECT COUNT(*) FROM " + text2 + " WHERE Contratto=" + base.DbConn.SQLFormatString(txtContratto.ObjValue.ToString()) + " ";
				if (((CheckBox)SelTipoSpedizione).Checked)
				{
					text = text + " AND TipoSpedizione=" + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelTipoMerce).Checked)
				{
					text = text + " AND TipoMerce=" + base.DbConn.SQLFormatString(cmbTipoMerce.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelTipoMezzo).Checked)
				{
					text = text + " AND TipoMezzo=" + base.DbConn.SQLFormatString(cmbTipoMezzo.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelCliente).Checked)
				{
					text = text + " AND Cliente=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelGruppoTariffarioPartenza).Checked)
				{
					text = text + " AND GruppoTariffarioPartenza=" + base.DbConn.SQLFormatString(cmbGruppoTariffarioPartenza.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelPCSPartenza).Checked)
				{
					text = text + " AND PCSPartenza=" + base.DbConn.SQLFormatString(cmbPCSPartenza.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelMacroZonaArrivo).Checked)
				{
					text = text + " AND MacroZonaArrivo=" + base.DbConn.SQLFormatString(cmbMacroZonaArrivo.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelZonaArrivo).Checked)
				{
					text = text + " AND ZonaArrivo=" + base.DbConn.SQLFormatString(cmbZonaArrivo.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelGruppoTariffarioArrivo).Checked)
				{
					text = text + " AND GruppoTariffarioArrivo=" + base.DbConn.SQLFormatString(cmbGruppoTariffarioArrivo.ObjValue.ToString()) + " ";
				}
				if (((CheckBox)SelPCSArrivo).Checked)
				{
					text = text + " AND PCSArrivo =" + base.DbConn.SQLFormatString(cmbPCSArrivo.ObjValue.ToString()) + " ";
				}
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					count = Conversions.ToInteger(obj);
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
}
