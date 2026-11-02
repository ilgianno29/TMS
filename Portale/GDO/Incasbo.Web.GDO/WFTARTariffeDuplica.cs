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

public class WFTARTariffeDuplica : WFIDBPage
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

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCopiaTutto")]
	private IboWebButton _btnCopiaTutto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSvuota")]
	private IboWebButton _btnSvuota;

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

	[field: AccessedThroughProperty("lblSorgente")]
	protected virtual IboWebLabel lblSorgente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazione")]
	protected virtual IboWebLabel lblDestinazione
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

	[field: AccessedThroughProperty("Contratto")]
	protected virtual IboWebComboTlk Contratto
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

	[field: AccessedThroughProperty("lblTipoSpedizioneValue")]
	protected virtual IboWebLabel lblTipoSpedizioneValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoSpedizione")]
	protected virtual IboWebComboTlk TipoSpedizione
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

	[field: AccessedThroughProperty("lblTipoMerceValue")]
	protected virtual IboWebLabel lblTipoMerceValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoMerce")]
	protected virtual IboWebComboTlk TipoMerce
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

	[field: AccessedThroughProperty("lblTipoMezzoValue")]
	protected virtual IboWebLabel lblTipoMezzoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoMezzo")]
	protected virtual IboWebComboTlk TipoMezzo
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

	[field: AccessedThroughProperty("lblClienteValue")]
	protected virtual IboWebLabel lblClienteValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cliente")]
	protected virtual IboWebComboTlk Cliente
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

	[field: AccessedThroughProperty("lblGruppoTariffarioPartenzaValue")]
	protected virtual IboWebLabel lblGruppoTariffarioPartenzaValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GruppoTariffarioPartenza")]
	protected virtual IboWebComboTlk GruppoTariffarioPartenza
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

	[field: AccessedThroughProperty("lblPCSPartenzaValue")]
	protected virtual IboWebLabel lblPCSPartenzaValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSPartenza")]
	protected virtual IboWebComboTlk PCSPartenza
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

	[field: AccessedThroughProperty("lblMacroZonaArrivoValue")]
	protected virtual IboWebLabel lblMacroZonaArrivoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MacroZonaArrivo")]
	protected virtual IboWebComboTlk MacroZonaArrivo
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

	[field: AccessedThroughProperty("lblZonaArrivoValue")]
	protected virtual IboWebLabel lblZonaArrivoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZonaArrivo")]
	protected virtual IboWebComboTlk ZonaArrivo
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

	[field: AccessedThroughProperty("lblGruppoTariffarioArrivoValue")]
	protected virtual IboWebLabel lblGruppoTariffarioArrivoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GruppoTariffarioArrivo")]
	protected virtual IboWebComboTlk GruppoTariffarioArrivo
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

	[field: AccessedThroughProperty("lblPCSArrivoValue")]
	protected virtual IboWebLabel lblPCSArrivoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSArrivo")]
	protected virtual IboWebComboTlk PCSArrivo
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

	[field: AccessedThroughProperty("txtTipoDocumento")]
	protected virtual IboWebTextBox txtTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoSpedizione")]
	protected virtual IboWebTextBox txtTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoMerce")]
	protected virtual IboWebTextBox txtTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoMezzo")]
	protected virtual IboWebTextBox txtTipoMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCliente")]
	protected virtual IboWebTextBox txtCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGruppoTariffarioPartenza")]
	protected virtual IboWebTextBox txtGruppoTariffarioPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenza")]
	protected virtual IboWebTextBox txtPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMacroZonaArrivo")]
	protected virtual IboWebTextBox txtMacroZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtZonaArrivo")]
	protected virtual IboWebTextBox txtZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGruppoTariffarioArrivo")]
	protected virtual IboWebTextBox txtGruppoTariffarioArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSArrivo")]
	protected virtual IboWebTextBox txtPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnCopiaTutto
	{
		[CompilerGenerated]
		get
		{
			return _btnCopiaTutto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCopiaTutto_Click;
			IboWebButton val = _btnCopiaTutto;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCopiaTutto = value;
			val = _btnCopiaTutto;
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

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = "DM.TAR.TARIFFE#DUPLICA";
			_Title = base.Translator.Translate("XXX", "Duplica Tariffe", new string[0]);
			val2 = base.InitializedPage(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
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
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_027d;
				}
				text = "SELECT ATTIVAPASSIVA FROM TARIFFECONTRATTI WHERE CODICE = " + base.DbConn.SQLFormatString(txtContratto.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(Conversions.ToString(obj), "A", false) == 0)
					{
						((Control)ClienteModifica).Visible = false;
						Contratto.SqlQueryFilter = "ATTIVAPASSIVA = 'A' AND DATAFINEVALIDITA > " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now);
						ZonaArrivo.SqlQueryFilter = "ZONATARIFFAATTIVA = 'S'";
						((CheckBox)SelCliente).Checked = false;
					}
					else
					{
						((Control)ClienteModifica).Visible = true;
						Contratto.SqlQueryFilter = "ATTIVAPASSIVA = 'P' AND DATAFINEVALIDITA > " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now);
						ZonaArrivo.SqlQueryFilter = "ZONATARIFFAPASSIVA = 'S'";
					}
					Contratto.ObjValue = txtContratto.ObjValue.ToString();
					TipoSpedizione.ObjValue = txtTipoSpedizione.ObjValue.ToString();
					TipoMerce.ObjValue = txtTipoMerce.ObjValue.ToString();
					TipoMezzo.ObjValue = txtTipoMezzo.ObjValue.ToString();
					Cliente.ObjValue = txtCliente.ObjValue.ToString();
					GruppoTariffarioPartenza.ObjValue = txtGruppoTariffarioPartenza.ObjValue.ToString();
					PCSPartenza.ObjValue = txtPCSPartenza.ObjValue.ToString();
					MacroZonaArrivo.ObjValue = txtMacroZonaArrivo.ObjValue.ToString();
					ZonaArrivo.ObjValue = txtZonaArrivo.ObjValue.ToString();
					GruppoTariffarioArrivo.ObjValue = txtGruppoTariffarioArrivo.ObjValue.ToString();
					PCSArrivo.ObjValue = txtPCSArrivo.ObjValue.ToString();
					goto IL_027d;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_027d:
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
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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
			else if (Operators.CompareString(Contratto.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Contratto di duplicazione");
			}
			else if (((CheckBox)SelTipoSpedizione).Checked & (Operators.CompareString(TipoSpedizione.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Spedizione di duplicazione");
			}
			else if (((CheckBox)SelTipoMerce).Checked & (Operators.CompareString(TipoMerce.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Merce di duplicazione");
			}
			else if (((CheckBox)SelTipoMezzo).Checked & (Operators.CompareString(TipoMezzo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Tipo Mezzo di duplicazione");
			}
			else if (((CheckBox)SelCliente).Checked & (Operators.CompareString(Cliente.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Cliente di duplicazione");
			}
			else if (((CheckBox)SelGruppoTariffarioPartenza).Checked & (Operators.CompareString(GruppoTariffarioPartenza.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Gruppo Tariffario Partenza di duplicazione");
			}
			else if (((CheckBox)SelPCSPartenza).Checked & (Operators.CompareString(PCSPartenza.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il PCS Partenza di duplicazione");
			}
			else if (((CheckBox)SelMacroZonaArrivo).Checked & (Operators.CompareString(MacroZonaArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare la Macro Zona Arrivo di duplicazione");
			}
			else if (((CheckBox)SelZonaArrivo).Checked & (Operators.CompareString(ZonaArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare la  Zona Arrivo di duplicazione");
			}
			else if (((CheckBox)SelGruppoTariffarioArrivo).Checked & (Operators.CompareString(GruppoTariffarioArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il Gruppo Tariffario Arrivo di duplicazione");
			}
			else if (((CheckBox)SelPCSArrivo).Checked & (Operators.CompareString(PCSArrivo.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Selezionare il PCS Arrivo di duplicazione");
			}
			else if ((Operators.CompareString(Contratto.ObjValue.ToString(), txtContratto.ObjValue.ToString(), false) == 0) & (Operators.CompareString(TipoSpedizione.ObjValue.ToString(), txtTipoSpedizione.ObjValue.ToString(), false) == 0) & (Operators.CompareString(TipoMerce.ObjValue.ToString(), txtTipoMerce.ObjValue.ToString(), false) == 0) & (Operators.CompareString(TipoMezzo.ObjValue.ToString(), txtTipoMezzo.ObjValue.ToString(), false) == 0) & (Operators.CompareString(Cliente.ObjValue.ToString(), txtCliente.ObjValue.ToString(), false) == 0) & (Operators.CompareString(GruppoTariffarioPartenza.ObjValue.ToString(), txtGruppoTariffarioPartenza.ObjValue.ToString(), false) == 0) & (Operators.CompareString(PCSPartenza.ObjValue.ToString(), txtPCSPartenza.ObjValue.ToString(), false) == 0) & (Operators.CompareString(MacroZonaArrivo.ObjValue.ToString(), txtMacroZonaArrivo.ObjValue.ToString(), false) == 0) & (Operators.CompareString(ZonaArrivo.ObjValue.ToString(), txtZonaArrivo.ObjValue.ToString(), false) == 0) & (Operators.CompareString(GruppoTariffarioArrivo.ObjValue.ToString(), txtGruppoTariffarioArrivo.ObjValue.ToString(), false) == 0) & (Operators.CompareString(PCSArrivo.ObjValue.ToString(), txtPCSArrivo.ObjValue.ToString(), false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Impossibile duplicare tutti i parametri di partenza e arrivono corrispondono");
			}
			else
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Invalid comparison between Unknown and I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = Tariffe_Duplica.RunProc(CreateApiContext(), txtContratto.ObjValue.ToString(), txtTipoDocumento.ObjValue.ToString(), ((CheckBox)SelTipoSpedizione).Checked ? txtTipoSpedizione.ObjValue.ToString() : "", ((CheckBox)SelTipoMerce).Checked ? txtTipoMerce.ObjValue.ToString() : "", ((CheckBox)SelTipoMezzo).Checked ? txtTipoMezzo.ObjValue.ToString() : "", ((CheckBox)SelCliente).Checked ? txtCliente.ObjValue.ToString() : "", ((CheckBox)SelGruppoTariffarioPartenza).Checked ? txtGruppoTariffarioPartenza.ObjValue.ToString() : "", ((CheckBox)SelPCSPartenza).Checked ? txtPCSPartenza.ObjValue.ToString() : "", ((CheckBox)SelMacroZonaArrivo).Checked ? txtMacroZonaArrivo.ObjValue.ToString() : "", ((CheckBox)SelZonaArrivo).Checked ? txtZonaArrivo.ObjValue.ToString() : "", ((CheckBox)SelGruppoTariffarioArrivo).Checked ? txtGruppoTariffarioArrivo.ObjValue.ToString() : "", ((CheckBox)SelPCSArrivo).Checked ? txtPCSArrivo.ObjValue.ToString() : "", Contratto.ObjValue.ToString(), ((CheckBox)SelTipoSpedizione).Checked ? TipoSpedizione.ObjValue.ToString() : "", ((CheckBox)SelTipoMerce).Checked ? TipoMerce.ObjValue.ToString() : "", ((CheckBox)SelTipoMezzo).Checked ? TipoMezzo.ObjValue.ToString() : "", ((CheckBox)SelCliente).Checked ? Cliente.ObjValue.ToString() : "", ((CheckBox)SelGruppoTariffarioPartenza).Checked ? GruppoTariffarioPartenza.ObjValue.ToString() : "", ((CheckBox)SelPCSPartenza).Checked ? PCSPartenza.ObjValue.ToString() : "", ((CheckBox)SelMacroZonaArrivo).Checked ? MacroZonaArrivo.ObjValue.ToString() : "", ((CheckBox)SelZonaArrivo).Checked ? ZonaArrivo.ObjValue.ToString() : "", ((CheckBox)SelGruppoTariffarioArrivo).Checked ? GruppoTariffarioArrivo.ObjValue.ToString() : "", ((CheckBox)SelPCSArrivo).Checked ? PCSArrivo.ObjValue.ToString() : "", ref rsMess);
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(_objFunctionArguments.Context.ToUpper(), "DM.DOC.TARIFFE.ATTIVE", false) == 0) | (Operators.CompareString(_objFunctionArguments.Context.ToUpper(), "DM.DOC.TARIFFE.PASSIVE", false) == 0)) && !((Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], "DM.TAR.TRA_ATTIVETESTATA", false) == 0) | (Operators.CompareString(Strings.Split(_objFunctionArguments.Context.ToUpper(), "#", -1, (CompareMethod)0)[0], "DM.TAR.TRA_PASSIVETESTATA", false) == 0)))
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
				TipoSpedizione.Enabled = true;
			}
			else
			{
				TipoSpedizione.Enabled = false;
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
				TipoMerce.Enabled = true;
			}
			else
			{
				TipoMerce.Enabled = false;
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
				TipoMezzo.Enabled = true;
			}
			else
			{
				TipoMezzo.Enabled = false;
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
				Cliente.Enabled = true;
			}
			else
			{
				Cliente.Enabled = false;
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
				GruppoTariffarioPartenza.Enabled = true;
			}
			else
			{
				GruppoTariffarioPartenza.Enabled = false;
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
				PCSPartenza.Enabled = true;
			}
			else
			{
				PCSPartenza.Enabled = false;
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
				MacroZonaArrivo.Enabled = true;
			}
			else
			{
				MacroZonaArrivo.Enabled = false;
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
				ZonaArrivo.Enabled = true;
			}
			else
			{
				ZonaArrivo.Enabled = false;
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
				GruppoTariffarioArrivo.Enabled = true;
			}
			else
			{
				GruppoTariffarioArrivo.Enabled = false;
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
				PCSArrivo.Enabled = true;
			}
			else
			{
				PCSArrivo.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btnCopiaTutto_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			IboWebComboTlk contratto = Contratto;
			string? sItemValue = txtContratto.ObjValue.ToString();
			string rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)contratto, sItemValue, ref rsMess2);
			IboWebComboTlk tipoSpedizione = TipoSpedizione;
			string? sItemValue2 = txtTipoSpedizione.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoSpedizione, sItemValue2, ref rsMess2);
			IboWebComboTlk tipoMerce = TipoMerce;
			string? sItemValue3 = txtTipoMerce.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoMerce, sItemValue3, ref rsMess2);
			IboWebComboTlk tipoMezzo = TipoMezzo;
			string? sItemValue4 = txtTipoMezzo.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoMezzo, sItemValue4, ref rsMess2);
			IboWebComboTlk cliente = Cliente;
			string? sItemValue5 = txtCliente.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)cliente, sItemValue5, ref rsMess2);
			IboWebComboTlk gruppoTariffarioPartenza = GruppoTariffarioPartenza;
			string? sItemValue6 = txtGruppoTariffarioPartenza.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)gruppoTariffarioPartenza, sItemValue6, ref rsMess2);
			IboWebComboTlk pCSPartenza = PCSPartenza;
			string? sItemValue7 = txtPCSPartenza.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)pCSPartenza, sItemValue7, ref rsMess2);
			IboWebComboTlk macroZonaArrivo = MacroZonaArrivo;
			string? sItemValue8 = txtMacroZonaArrivo.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)macroZonaArrivo, sItemValue8, ref rsMess2);
			IboWebComboTlk zonaArrivo = ZonaArrivo;
			string? sItemValue9 = txtZonaArrivo.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)zonaArrivo, sItemValue9, ref rsMess2);
			IboWebComboTlk gruppoTariffarioArrivo = GruppoTariffarioArrivo;
			string? sItemValue10 = txtGruppoTariffarioArrivo.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)gruppoTariffarioArrivo, sItemValue10, ref rsMess2);
			IboWebComboTlk pCSArrivo = PCSArrivo;
			string? sItemValue11 = txtPCSArrivo.ObjValue.ToString();
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)pCSArrivo, sItemValue11, ref rsMess2);
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnSvuota_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			IboWebComboTlk contratto = Contratto;
			string rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)contratto, "", ref rsMess2);
			IboWebComboTlk tipoSpedizione = TipoSpedizione;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoSpedizione, "", ref rsMess2);
			IboWebComboTlk tipoMerce = TipoMerce;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoMerce, "", ref rsMess2);
			IboWebComboTlk tipoMezzo = TipoMezzo;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)tipoMezzo, "", ref rsMess2);
			IboWebComboTlk cliente = Cliente;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)cliente, "", ref rsMess2);
			IboWebComboTlk gruppoTariffarioPartenza = GruppoTariffarioPartenza;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)gruppoTariffarioPartenza, "", ref rsMess2);
			IboWebComboTlk pCSPartenza = PCSPartenza;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)pCSPartenza, "", ref rsMess2);
			IboWebComboTlk macroZonaArrivo = MacroZonaArrivo;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)macroZonaArrivo, "", ref rsMess2);
			IboWebComboTlk zonaArrivo = ZonaArrivo;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)zonaArrivo, "", ref rsMess2);
			IboWebComboTlk gruppoTariffarioArrivo = GruppoTariffarioArrivo;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)gruppoTariffarioArrivo, "", ref rsMess2);
			IboWebComboTlk pCSArrivo = PCSArrivo;
			rsMess2 = "";
			ComboSelectedItem((IIboDropdownList)(object)pCSArrivo, "", ref rsMess2);
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}
}
