using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioni_Wizard : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbCliente")]
	private IboWebComboTlk _cmbCliente;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoSpedizione")]
	private IboWebComboTlk _cmbTipoSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoMerce")]
	private IboWebComboTlk _cmbTipoMerce;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSPArtenza")]
	private IboWebComboTlk _cmbPCSPArtenza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPCSDestinazione")]
	private IboWebComboTlk _cmbPCSDestinazione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RepeaterSpedizioneQuantita")]
	private Repeater _RepeaterSpedizioneQuantita;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnIndietro")]
	private IboWebButton _btnIndietro;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAvanti")]
	private IboWebButton _btnAvanti;

	private DataTable _dtSpedizioni_Quantita;

	private StringDictionary _DecimalDigitCollection;

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

	[field: AccessedThroughProperty("lblDataAccessMode")]
	protected new virtual IboWebLabel lblDataAccessMode
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

	[field: AccessedThroughProperty("PanelFasiDiv")]
	protected virtual Panel PanelFasiDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PanelFasi")]
	protected virtual Panel PanelFasi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	protected virtual IboWebLabel Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel5")]
	protected virtual IboWebLabel IboWebLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	protected virtual IboWebLabel Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel8")]
	protected virtual IboWebLabel IboWebLabel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	protected virtual IboWebLabel Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel9")]
	protected virtual IboWebLabel IboWebLabel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	protected virtual IboWebLabel Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInserimentoSpedizione_Body")]
	protected virtual Panel cpInserimentoSpedizione_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WizardInserimentoSpedizione")]
	protected virtual MultiView WizardInserimentoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiferimentiSpedizione")]
	protected virtual View WSRiferimentiSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_1")]
	protected virtual UpdatePanel up_1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiferimentiSpedizioneContainerDiv")]
	protected virtual Panel WSRiferimentiSpedizioneContainerDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiferimentiSpedizioneTitleDiv")]
	protected virtual Panel WSRiferimentiSpedizioneTitleDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiferimentiSpedizioneTitle")]
	protected virtual IboWebLabel WSRiferimentiSpedizioneTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiferimentiSpedizioneBodyDiv")]
	protected virtual Panel WSRiferimentiSpedizioneBodyDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCliente")]
	protected virtual IboWebLabel lblCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbCliente
	{
		[CompilerGenerated]
		get
		{
			return _cmbCliente;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbCliente_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbCliente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbCliente = value;
			val2 = _cmbCliente;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblAttivazioneAutomatica")]
	protected virtual IboWebLabel lblAttivazioneAutomatica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAttivazioneAutomatica")]
	protected virtual IboWebCheckBox chkAttivazioneAutomatica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMittenteRagioneSociale")]
	protected virtual IboWebLabel lblMittenteRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMittenteRagioneSociale")]
	protected virtual IboWebTextBox txtMittenteRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoServizio")]
	protected virtual IboWebLabel lblTipoServizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoServizio")]
	protected virtual IboWebComboTlk cmbTipoServizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdine")]
	protected virtual IboWebLabel lblNumeroOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroOrdine")]
	protected virtual IboWebTextBox txtNumeroOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdine")]
	protected virtual IboWebLabel lblDataOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataOrdine")]
	protected virtual IboWebDate2 txtDataOrdine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBolla")]
	protected virtual IboWebLabel lblNumeroBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroBolla")]
	protected virtual IboWebTextBox txtNumeroBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataBolla")]
	protected virtual IboWebLabel lblDataBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataBolla")]
	protected virtual IboWebDate2 txtDataBolla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizione")]
	protected virtual IboWebLabel lblTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbTipoSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTipoSpedizione_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTipoSpedizione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTipoSpedizione = value;
			val2 = _cmbTipoSpedizione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblTipoMerce")]
	protected virtual IboWebLabel lblTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbTipoMerce
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoMerce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTipoMerce_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTipoMerce;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTipoMerce = value;
			val2 = _cmbTipoMerce;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblNote")]
	protected virtual IboWebLabel lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	protected virtual IboWebTextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSPCS")]
	protected virtual View WSPCS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_35")]
	protected virtual UpdatePanel up_35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSPCSContainerDiv")]
	protected virtual Panel WSPCSContainerDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSPCSTitleDiv")]
	protected virtual Panel WSPCSTitleDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSPCSTitle")]
	protected virtual IboWebLabel WSPCSTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSPCSBodyDiv")]
	protected virtual Panel WSPCSBodyDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenza")]
	protected virtual IboWebLabel lblPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbPCSPArtenza
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSPArtenza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSPartenza_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSPArtenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSPArtenza = value;
			val2 = _cmbPCSPArtenza;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSPartenzaZonaSpedizione")]
	protected virtual IboWebLabel lblPCSPartenzaZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaZonaSpedizione")]
	protected virtual IboWebTextBox txtPCSPartenzaZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSPartenzaZonaSpedizioneQL")]
	protected virtual IboWebTextBox PCSPartenzaZonaSpedizioneQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaIndirizzo")]
	protected virtual IboWebLabel lblPCSPartenzaIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaIndirizzo")]
	protected virtual IboWebTextBox txtPCSPartenzaIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaZonaTariffaAttiva")]
	protected virtual IboWebLabel lblPCSPartenzaZonaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaZonaTariffaAttiva")]
	protected virtual IboWebTextBox txtPCSPartenzaZonaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSPartenzaZonaTariffaAttivaQL")]
	protected virtual IboWebTextBox PCSPartenzaZonaTariffaAttivaQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaCap")]
	protected virtual IboWebTextBox txtPCSPartenzaCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaLocalita")]
	protected virtual IboWebTextBox txtPCSPartenzaLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaProvincia")]
	protected virtual IboWebTextBox txtPCSPartenzaProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaNazione")]
	protected virtual IboWebTextBox txtPCSPartenzaNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaZonaTariffaPassiva")]
	protected virtual IboWebLabel lblPCSPartenzaZonaTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSPartenzaZonaTariffaPassiva")]
	protected virtual IboWebTextBox txtPCSPartenzaZonaTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSPartenzaZonaTariffaPassivaQL")]
	protected virtual IboWebTextBox PCSPartenzaZonaTariffaPassivaQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazione")]
	protected virtual IboWebLabel lblPCSDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbPCSDestinazione
	{
		[CompilerGenerated]
		get
		{
			return _cmbPCSDestinazione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbPCSDestinazione_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbPCSDestinazione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbPCSDestinazione = value;
			val2 = _cmbPCSDestinazione;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneZonaSpedizione")]
	protected virtual IboWebLabel lblPCSDestinazioneZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneZonaSpedizione")]
	protected virtual IboWebTextBox txtPCSDestinazioneZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazioneZonaSpedizioneQL")]
	protected virtual IboWebTextBox PCSDestinazioneZonaSpedizioneQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneIndirizzo")]
	protected virtual IboWebLabel lblPCSDestinazioneIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneIndirizzo")]
	protected virtual IboWebTextBox txtPCSDestinazioneIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneZonaTariffaAttiva")]
	protected virtual IboWebLabel lblPCSDestinazioneZonaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneZonaTariffaAttiva")]
	protected virtual IboWebTextBox txtPCSDestinazioneZonaTariffaAttiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazioneZonaTariffaAttivaQL")]
	protected virtual IboWebTextBox PCSDestinazioneZonaTariffaAttivaQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneCap")]
	protected virtual IboWebTextBox txtPCSDestinazioneCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneLocalita")]
	protected virtual IboWebTextBox txtPCSDestinazioneLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneProvincia")]
	protected virtual IboWebTextBox txtPCSDestinazioneProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneNazione")]
	protected virtual IboWebTextBox txtPCSDestinazioneNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneZonaTariffaPassiva")]
	protected virtual IboWebLabel lblPCSDestinazioneZonaTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCSDestinazioneZonaTariffaPassiva")]
	protected virtual IboWebTextBox txtPCSDestinazioneZonaTariffaPassiva
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PCSDestinazioneZonaTariffaPassivaQL")]
	protected virtual IboWebTextBox PCSDestinazioneZonaTariffaPassivaQL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista1")]
	protected virtual IboWebLabel lblDataRitiroPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRitiroPrevista1")]
	protected virtual IboWebDate2 txtDataRitiroPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista2")]
	protected virtual IboWebLabel lblDataRitiroPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRitiroPrevista2")]
	protected virtual IboWebDate2 txtDataRitiroPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRitiroPrevisto")]
	protected virtual IboWebLabel lblNoteRitiroPrevisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteRitiroPrevisto")]
	protected virtual IboWebTextBox txtNoteRitiroPrevisto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista1")]
	protected virtual IboWebLabel lblDataConsegnaPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataConsegnaPrevista1")]
	protected virtual IboWebDate2 txtDataConsegnaPrevista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista2")]
	protected virtual IboWebLabel lblDataConsegnaPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataConsegnaPrevista2")]
	protected virtual IboWebDate2 txtDataConsegnaPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteConsegnaPrevista")]
	protected virtual IboWebLabel lblNoteConsegnaPrevista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNoteConsegnaPrevista")]
	protected virtual IboWebTextBox txtNoteConsegnaPrevista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondente")]
	protected virtual IboWebLabel lblCorrispondente
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

	[field: AccessedThroughProperty("WSSpedizioneQuantita")]
	protected virtual View WSSpedizioneQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_5")]
	protected virtual UpdatePanel up_5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSSpedizioneQuantitaContainerDiv")]
	protected virtual Panel WSSpedizioneQuantitaContainerDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSSpedizioneQuantitaDiv")]
	protected virtual Panel WSSpedizioneQuantitaDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSSpedizioneQuantitaTitle")]
	protected virtual IboWebLabel WSSpedizioneQuantitaTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSSpedizioneQuantitaBodyDiv")]
	protected virtual Panel WSSpedizioneQuantitaBodyDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoQuantita")]
	protected virtual IboWebLabel lblTipoQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantita")]
	protected virtual IboWebLabel lblQuantita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater RepeaterSpedizioneQuantita
	{
		[CompilerGenerated]
		get
		{
			return _RepeaterSpedizioneQuantita;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(RepeaterSpedizioneQuantita_ItemDataBound);
			Repeater repeaterSpedizioneQuantita = _RepeaterSpedizioneQuantita;
			if (repeaterSpedizioneQuantita != null)
			{
				repeaterSpedizioneQuantita.ItemDataBound -= val;
			}
			_RepeaterSpedizioneQuantita = value;
			repeaterSpedizioneQuantita = _RepeaterSpedizioneQuantita;
			if (repeaterSpedizioneQuantita != null)
			{
				repeaterSpedizioneQuantita.ItemDataBound += val;
			}
		}
	}

	[field: AccessedThroughProperty("WSRiepilogoSpedizione")]
	protected virtual View WSRiepilogoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_6")]
	protected virtual UpdatePanel up_6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiepilogoSpedizioneContainerDiv")]
	protected virtual Panel WSRiepilogoSpedizioneContainerDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiepilogoSpedizioneTitleDiv")]
	protected virtual Panel WSRiepilogoSpedizioneTitleDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiepilogoSpedizioneTitle")]
	protected virtual IboWebLabel WSRiepilogoSpedizioneTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WSRiepilogoSpedizioneBodyDiv")]
	protected virtual Panel WSRiepilogoSpedizioneBodyDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbClienteRiepilogo")]
	protected virtual IboWebLabel lbClienteRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteRiepilogoValue")]
	protected virtual IboWebLabel lblClienteRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMittenteRiepilogo")]
	protected virtual IboWebLabel lblMittenteRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMittenteRiepilogoValue")]
	protected virtual IboWebLabel lblMittenteRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoServizioRiepilogo")]
	protected virtual IboWebLabel lblTipoServizioRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoServizioRiepilogoValue")]
	protected virtual IboWebLabel lblTipoServizioRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineRiepilogo")]
	protected virtual IboWebLabel lblNumeroOrdineRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineRiepilogoValue")]
	protected virtual IboWebLabel lblNumeroOrdineRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdineRiepilogo")]
	protected virtual IboWebLabel lblDataOrdineRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdineRiepilogoValue")]
	protected virtual IboWebLabel lblDataOrdineRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBollaRiepilogo")]
	protected virtual IboWebLabel lblNumeroBollaRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBollaRiepilogoValue")]
	protected virtual IboWebLabel lblNumeroBollaRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataBollaRiepilogo")]
	protected virtual IboWebLabel lblDataBollaRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataBollaRiepilogoValue")]
	protected virtual IboWebLabel lblDataBollaRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneRiepilogo")]
	protected virtual IboWebLabel lblTipoSpedizioneRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneRiepilogoValue")]
	protected virtual IboWebLabel lblTipoSpedizioneRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceRiepilogo")]
	protected virtual IboWebLabel lblTipoMerceRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceRiepilogoValue")]
	protected virtual IboWebLabel lblTipoMerceRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRiepilogo")]
	protected virtual IboWebLabel lblNoteRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoteRiepilogoValue")]
	protected virtual IboWebLabel lblNoteRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaRiepilogo")]
	protected virtual IboWebLabel lblPCSPartenzaRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaRiepilogoValue")]
	protected virtual IboWebLabel lblPCSPartenzaRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneRiepilogo")]
	protected virtual IboWebLabel lblPCSDestinazioneRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazioneRiepilogoValue")]
	protected virtual IboWebLabel lblPCSDestinazioneRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista1Riepilogo")]
	protected virtual IboWebLabel lblDataRitiroPrevista1Riepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista1RiepilogoValue")]
	protected virtual IboWebLabel lblDataRitiroPrevista1RiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista2Riepilogo")]
	protected virtual IboWebLabel lblDataRitiroPrevista2Riepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRitiroPrevista2RiepilogoValue")]
	protected virtual IboWebLabel lblDataRitiroPrevista2RiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista1Riepilogo")]
	protected virtual IboWebLabel lblDataConsegnaPrevista1Riepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista1RiepilogoValue")]
	protected virtual IboWebLabel lblDataConsegnaPrevista1RiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista2Riepilogo")]
	protected virtual IboWebLabel lblDataConsegnaPrevista2Riepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaPrevista2RiepilogoValue")]
	protected virtual IboWebLabel lblDataConsegnaPrevista2RiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipiImballoRiepilogo")]
	protected virtual IboWebLabel lblTipiImballoRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipiImballoRiepilogoValue")]
	protected virtual IboWebLabel lblTipiImballoRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttivazioneAutomaticaRiepilogo")]
	protected virtual IboWebLabel lblAttivazioneAutomaticaRiepilogo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttivazioneAutomaticaRiepilogoValue")]
	protected virtual IboWebLabel lblAttivazioneAutomaticaRiepilogoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnAnnulla")]
	protected new virtual IboWebButton btnAnnulla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnIndietro
	{
		[CompilerGenerated]
		get
		{
			return _btnIndietro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnIndietro_Click;
			IboWebButton val = _btnIndietro;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnIndietro = value;
			val = _btnIndietro;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnAvanti
	{
		[CompilerGenerated]
		get
		{
			return _btnAvanti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAvanti_Click;
			IboWebButton val = _btnAvanti;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAvanti = value;
			val = _btnAvanti;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("btnConferma")]
	protected new virtual IboWebButton btnConferma
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFDOCSpedizioni_Wizard()
	{
		_dtSpedizioni_Quantita = null;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.SPEDIZIONI";
		_Title = base.Translator.Translate("XXX", "Documento di Spedizione", new string[0]);
		if (!_SessionVariable.ContainsKey("DecimalDigitCollection"))
		{
			_DecimalDigitCollection = new StringDictionary();
			_SessionVariable["DecimalDigitCollection"] = (object)_DecimalDigitCollection;
		}
		else
		{
			_DecimalDigitCollection = (StringDictionary)_SessionVariable["DecimalDigitCollection"];
		}
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN LoadInterfaceFeatures(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadInterfaceFeatures(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				pnlMain.DefaultButton = "";
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		string text3 = "";
		string text4 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if ((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) & !((Page)this).IsPostBack)
				{
					cmbTipoServizio.ObjValue = base.ApplicationDefault.TipoServizioDefault();
					cmbPCSPArtenza.ObjValue = base.ApplicationDefault.PCS_Partenza_Default();
				}
				val2 = CaricamentoSpedizioni_Quantita(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (!((Page)this).IsPostBack && ((Page)this).Request.QueryString["AA"] != null)
					{
						chkAttivazioneAutomatica.ObjValue = Operators.CompareString(((Page)this).Request.QueryString["AA"].ToString().ToUpper(), "S", false) == 0;
					}
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

	protected override FXRETURN PreRenderPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.PreRenderPage(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(((Control)WizardInserimentoSpedizione.GetActiveView()).ID, ((Control)WSSpedizioneQuantita).ID, false) == 0)
				{
					foreach (RepeaterItem item in RepeaterSpedizioneQuantita.Items)
					{
						RepeaterItem parent = item;
						string key = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoQuantitaCodice")).ObjValue.ToString();
						((IboWebNumericTlk)GetControlByName((Control)(object)parent, "Quantita")).DecimalDigits = Conversions.ToInteger(_DecimalDigitCollection[key]);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Invalid comparison between Unknown and I4
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		Spedizione Spedizione = new Spedizione();
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Spedizione spedizione = Spedizione;
			if (Operators.CompareString(cmbTipoServizio.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.TipoServizio = cmbTipoServizio.ObjValue.ToString();
			}
			if (Operators.CompareString(txtNumeroOrdine.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.NumeroOrdine = txtNumeroOrdine.ObjValue.ToString();
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataOrdine.ObjValue)))
			{
				spedizione.DataOrdine = txtDataOrdine.getDateValue;
			}
			if (Operators.CompareString(txtNumeroBolla.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.NumeroBolla = txtNumeroBolla.ObjValue.ToString();
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataBolla.ObjValue)))
			{
				spedizione.DataBolla = txtDataBolla.getDateValue;
			}
			if (Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.Cliente = cmbCliente.ObjValue.ToString();
			}
			if (Operators.CompareString(txtMittenteRagioneSociale.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.Mittente = txtMittenteRagioneSociale.ObjValue.ToString();
			}
			if (Operators.CompareString(cmbTipoSpedizione.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.TipoSpedizione = cmbTipoSpedizione.ObjValue.ToString();
			}
			if (Operators.CompareString(cmbTipoMerce.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.TipoMerce = cmbTipoMerce.ObjValue.ToString();
			}
			if (Operators.CompareString(cmbPCSPArtenza.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.PCSPartenza = cmbPCSPArtenza.ObjValue.ToString();
			}
			if (Operators.CompareString(cmbPCSDestinazione.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.PCSDestinazione = cmbPCSDestinazione.ObjValue.ToString();
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataRitiroPrevista1.ObjValue)))
			{
				spedizione.DataRitiroPrevista1 = txtDataRitiroPrevista1.getDateValue;
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataRitiroPrevista2.ObjValue)))
			{
				spedizione.DataRitiroPrevista2 = txtDataRitiroPrevista2.getDateValue;
			}
			if (Operators.CompareString(txtNoteRitiroPrevisto.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.NoteRitiroPrevisto = txtNoteRitiroPrevisto.ObjValue.ToString();
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataConsegnaPrevista1.ObjValue)))
			{
				spedizione.DataConsegnaPrevista1 = txtDataConsegnaPrevista1.getDateValue;
			}
			if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtDataConsegnaPrevista2.ObjValue)))
			{
				spedizione.DataConsegnaPrevista2 = txtDataConsegnaPrevista2.getDateValue;
			}
			if (Operators.CompareString(txtNoteConsegnaPrevista.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.NoteConsegnaPrevista = txtNoteConsegnaPrevista.ObjValue.ToString();
			}
			if (Operators.CompareString(txtNote.ObjValue.ToString(), "", false) != 0)
			{
				spedizione.Note = txtNote.ObjValue.ToString();
			}
			foreach (RepeaterItem item in RepeaterSpedizioneQuantita.Items)
			{
				RepeaterItem parent = item;
				string text3 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoQuantitaCodice")).ObjValue.ToString();
				object objectValue = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Quantita")).ObjValue);
				string text4 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoQuantitaDescrizione")).ObjValue.ToString();
				if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) && Conversions.ToDouble(objectValue) > 0.0)
				{
					switch (text3.ToUpper())
					{
					case "COLLI":
						spedizione.Colli = Conversions.ToDecimal(objectValue);
						break;
					case "PALLET":
						spedizione.Pallet = Conversions.ToDecimal(objectValue);
						break;
					case "PESO":
						spedizione.Peso = Conversions.ToDecimal(objectValue);
						break;
					case "VOLUME":
						spedizione.Volume = Conversions.ToDecimal(objectValue);
						break;
					case "CONTRASSEGNO":
						spedizione.Contrassegno = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO1":
						spedizione.CampoCalcolo1 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO2":
						spedizione.CampoCalcolo2 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO3":
						spedizione.CampoCalcolo3 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO4":
						spedizione.CampoCalcolo4 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO5":
						spedizione.CampoCalcolo5 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO6":
						spedizione.CampoCalcolo7 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO7":
						spedizione.CampoCalcolo7 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO8":
						spedizione.CampoCalcolo8 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO9":
						spedizione.CampoCalcolo9 = Conversions.ToDecimal(objectValue);
						break;
					case "CAMPOCALCOLO10":
						spedizione.CampoCalcolo10 = Conversions.ToDecimal(objectValue);
						break;
					}
					text2 = text2 + Conversions.ToString(objectValue) + " " + text4 + ";";
				}
			}
			spedizione = null;
			val = Spedizione_Inserisci_Invoker.Instance.RunProc(CreateApiContext(), ref Spedizione, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (((CheckBox)chkAttivazioneAutomatica).Checked)
				{
					string note = "";
					val = Spedizione_Attiva_Invoker.Instance.RunProc(CreateApiContext(), Spedizione.UniBol, note, ref rsMess);
					if ((int)val > 0)
					{
						WriteInfoMessage(TranslateMessage("XXX", "Problema nell'attivazione della spedizione {0}: " + rsMess, Spedizione.UniBol));
					}
				}
				WriteInfoMessage(TranslateMessage("XXX", "Spedizione {0} inserita con successo", Spedizione.UniBol), ShowAsNotification: true);
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

	protected override FXRETURN AfterSaveDataAfterCommit(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveDataAfterCommit(ref rsMess);
			if ((int)val2 <= 0)
			{
				_ReturnToCallerAfterConfirm = false;
				txtDataOrdine.ObjValue = "";
				txtNumeroOrdine.ObjValue = "";
				txtDataBolla.ObjValue = "";
				txtNumeroBolla.ObjValue = "";
				txtDataOrdine.ObjValue = "";
				txtMittenteRagioneSociale.ObjValue = "";
				IboWebComboTlk objCombo = cmbPCSDestinazione;
				string rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
				IboWebComboTlk objCombo2 = cmbPCSPArtenza;
				string sItemValue = base.ApplicationDefault.PCS_Partenza_Default();
				rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo2, sItemValue, ref rsMess2);
				IboWebComboTlk objCombo3 = cmbTipoServizio;
				string sItemValue2 = base.ApplicationDefault.TipoServizioDefault();
				rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo3, sItemValue2, ref rsMess2);
				txtNote.ObjValue = "";
				txtPCSPartenzaIndirizzo.ObjValue = "";
				txtPCSPartenzaLocalita.ObjValue = "";
				txtPCSPartenzaCap.ObjValue = "";
				txtPCSPartenzaNazione.ObjValue = "";
				txtPCSPartenzaProvincia.ObjValue = "";
				txtPCSPartenzaZonaSpedizione.ObjValue = "";
				txtPCSPartenzaZonaTariffaAttiva.ObjValue = "";
				txtPCSPartenzaZonaTariffaPassiva.ObjValue = "";
				PCSPartenzaZonaSpedizioneQL.ObjValue = "";
				PCSPartenzaZonaTariffaAttivaQL.ObjValue = "";
				PCSPartenzaZonaTariffaPassivaQL.ObjValue = "";
				txtPCSDestinazioneIndirizzo.ObjValue = "";
				txtPCSDestinazioneLocalita.ObjValue = "";
				txtPCSDestinazioneCap.ObjValue = "";
				txtPCSDestinazioneNazione.ObjValue = "";
				txtPCSDestinazioneProvincia.ObjValue = "";
				txtPCSDestinazioneZonaSpedizione.ObjValue = "";
				txtPCSDestinazioneZonaTariffaAttiva.ObjValue = "";
				txtPCSDestinazioneZonaTariffaPassiva.ObjValue = "";
				PCSDestinazioneZonaSpedizioneQL.ObjValue = "";
				PCSDestinazioneZonaTariffaAttivaQL.ObjValue = "";
				PCSDestinazioneZonaTariffaPassivaQL.ObjValue = "";
				txtDataConsegnaPrevista1.ObjValue = "";
				txtDataConsegnaPrevista2.ObjValue = "";
				txtDataRitiroPrevista1.ObjValue = "";
				txtDataRitiroPrevista2.ObjValue = "";
				txtNoteRitiroPrevisto.ObjValue = "";
				txtNoteConsegnaPrevista.ObjValue = "";
				val2 = CaricamentoSpedizioni_Quantita(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					WizardInserimentoSpedizione.ActiveViewIndex = 0;
					btnIndietro.CssClass = "hidden";
					btnAvanti.CssClass = "WizardForward";
					btnConferma.CssClass = "hidden";
					SetActiveViewLabel();
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

	private void btnAvanti_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			val2 = CheckInfo(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			MultiView wizardInserimentoSpedizione;
			(wizardInserimentoSpedizione = WizardInserimentoSpedizione).ActiveViewIndex = checked(wizardInserimentoSpedizione.ActiveViewIndex + 1);
			btnIndietro.CssClass = "WizardBack";
			if (WizardInserimentoSpedizione.ActiveViewIndex == checked(((ControlCollection)WizardInserimentoSpedizione.Views).Count - 1))
			{
				btnAvanti.CssClass = "hidden";
				btnConferma.CssClass = "DetailFormButton_Ok";
				val2 = SetRiepilogo(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
			else
			{
				btnAvanti.CssClass = "WizardForward";
				btnConferma.CssClass = "hidden";
			}
			val2 = SetInfoNextPanel(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			SetActiveViewLabel();
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
		}
	}

	private void btnIndietro_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			MultiView wizardInserimentoSpedizione;
			(wizardInserimentoSpedizione = WizardInserimentoSpedizione).ActiveViewIndex = checked(wizardInserimentoSpedizione.ActiveViewIndex - 1);
			if (WizardInserimentoSpedizione.ActiveViewIndex == 0)
			{
				btnIndietro.CssClass = "hidden";
			}
			else
			{
				btnAvanti.CssClass = "WizardForward";
				btnConferma.CssClass = "hidden";
			}
			SetActiveViewLabel();
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
		}
	}

	private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Invalid comparison between Unknown and I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Invalid comparison between Unknown and I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Invalid comparison between Unknown and I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Invalid comparison between Unknown and I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Invalid comparison between Unknown and I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboWebComboTlk objCombo = cmbTipoSpedizione;
			string rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			cmbTipoSpedizione.SqlQueryFilter = "CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
			IboWebComboTlk objCombo2 = cmbTipoSpedizione;
			FXRETURN val3 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoSpedizione = objCombo2;
			val2 = val3;
			if ((int)val2 > 0)
			{
				return;
			}
			text = "SELECT * FROM ClientiTipiSpedizione WHERE Cliente=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + " AND ISDefault='S' ";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			IboWebComboTlk objCombo3 = cmbTipoMerce;
			rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo3, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			cmbTipoMerce.SqlQueryFilter = "1=2";
			objCombo2 = cmbTipoMerce;
			FXRETURN val4 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoMerce = objCombo2;
			val2 = val4;
			if ((int)val2 > 0)
			{
				return;
			}
			if (dataTable.Rows.Count == 1)
			{
				IboWebComboTlk objCombo4 = cmbTipoSpedizione;
				string? sItemValue = dataTable.Rows[0]["TipoSpedizione"].ToString();
				rsMess2 = "";
				val = ComboSelectedItem((IIboDropdownList)(object)objCombo4, sItemValue, ref rsMess2);
				if ((int)val2 > 0)
				{
					return;
				}
				cmbTipoSpedizione_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else if (((StateManagedCollection)((RadComboBox)cmbTipoSpedizione).Items).Count == 2)
			{
				IboWebComboTlk objCombo5 = cmbTipoSpedizione;
				string sItemValue2 = ((RadComboBox)cmbTipoSpedizione).Items[1].Value.ToString();
				rsMess2 = "";
				val = ComboSelectedItem((IIboDropdownList)(object)objCombo5, sItemValue2, ref rsMess2);
				if ((int)val2 > 0)
				{
					return;
				}
				cmbTipoSpedizione_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			object obj = null;
			val2 = base.DbConn.DoSql("SELECT COUNT(*) FROM PCS WHERE PUNTODIDEPOSITO='S' AND PUNTODICARICO='S' AND CODICE IN (SELECT CODICEINTERNO FROM PCS_ACQUISITI WHERE CLIENTE=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Conversions.ToInteger(obj) > 0)
			{
				cmbPCSPArtenza.SqlQueryFilter = "CODICE IN (SELECT CODICEINTERNO FROM PCS_ACQUISITI WHERE CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ") ";
			}
			else
			{
				cmbPCSPArtenza.SqlQueryFilter = "";
			}
			objCombo2 = cmbPCSPArtenza;
			FXRETURN val5 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbPCSPArtenza = objCombo2;
			val2 = val5;
			if ((int)val2 > 0)
			{
				return;
			}
			obj = null;
			val2 = base.DbConn.DoSql("SELECT COUNT(*) FROM PCS WHERE PUNTODIDESTINO='S' AND CODICE IN (SELECT CODICEINTERNO FROM PCS_ACQUISITI WHERE CLIENTE=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ")", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Conversions.ToInteger(obj) > 0)
			{
				cmbPCSDestinazione.SqlQueryFilter = "CODICE IN (SELECT CODICEINTERNO FROM PCS_ACQUISITI WHERE CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ") ";
			}
			else
			{
				cmbPCSDestinazione.SqlQueryFilter = "";
			}
			objCombo2 = cmbPCSDestinazione;
			FXRETURN val6 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbPCSDestinazione = objCombo2;
			val2 = val6;
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void cmbTipoSpedizione_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Invalid comparison between Unknown and I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		try
		{
			IboWebComboTlk objCombo = cmbTipoMerce;
			string rsMess2 = "";
			val2 = ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			if ((int)val2 > 0)
			{
				return;
			}
			text = "TIPOSPEDIZIONE = " + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + " ";
			text = text + "AND CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
			cmbTipoMerce.SqlQueryFilter = text;
			IboWebComboTlk objCombo2 = cmbTipoMerce;
			FXRETURN val3 = LoadSingleCombo(ref objCombo2, ref rsMess);
			cmbTipoMerce = objCombo2;
			val = val3;
			if ((int)val2 > 0)
			{
				return;
			}
			text2 = "SELECT * FROM ClientiTipiSpedizioneTipiMerce WHERE Cliente=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + " AND TipoSpedizione=" + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + " AND ISDefault='S' ";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (dataTable.Rows.Count == 1)
			{
				IboWebComboTlk objCombo3 = cmbTipoMerce;
				string? sItemValue = dataTable.Rows[0]["TipoMerce"].ToString();
				rsMess2 = "";
				val = ComboSelectedItem((IIboDropdownList)(object)objCombo3, sItemValue, ref rsMess2);
				if ((int)val2 > 0)
				{
					return;
				}
			}
			else if (((StateManagedCollection)((RadComboBox)cmbTipoMerce).Items).Count == 2)
			{
				IboWebComboTlk objCombo4 = cmbTipoMerce;
				string sItemValue2 = ((RadComboBox)cmbTipoMerce).Items[1].Value.ToString();
				rsMess2 = "";
				val = ComboSelectedItem((IIboDropdownList)(object)objCombo4, sItemValue2, ref rsMess2);
				if ((int)val2 > 0)
				{
					return;
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void cmbTipoMerce_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Invalid comparison between Unknown and I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			if (Operators.CompareString(cmbPCSPArtenza.ObjValue.ToString(), "", false) != 0)
			{
				string? vsCodice = cmbPCSPArtenza.ObjValue.ToString();
				string? vsTipoMerce = cmbTipoMerce.ObjValue.ToString();
				IboWebTextBox val2;
				string rsIndirizzo = (val2 = txtPCSPartenzaIndirizzo).Text;
				IboWebTextBox val3;
				string rsLocalita = (val3 = txtPCSPartenzaLocalita).Text;
				IboWebTextBox val4;
				string rsCap = (val4 = txtPCSPartenzaCap).Text;
				IboWebTextBox val5;
				string rsNazione = (val5 = txtPCSPartenzaNazione).Text;
				IboWebTextBox val6;
				string rsProvincia = (val6 = txtPCSPartenzaProvincia).Text;
				IboWebTextBox val7;
				string rsZonaSpedizione = (val7 = txtPCSPartenzaZonaSpedizione).Text;
				IboWebTextBox val8;
				string rsZonaTariffaAttiva = (val8 = txtPCSPartenzaZonaTariffaAttiva).Text;
				IboWebTextBox val9;
				string rsZonaTariffaPassiva = (val9 = txtPCSPartenzaZonaTariffaPassiva).Text;
				string rsDescrizioneZonaTariffaAttiva = "";
				string rsDescrizioneZonaSpedizione = "";
				string rsDescrizioneZonaTariffaPassiva = "";
				FXRETURN val10 = DecodificaDestinario(vsCodice, vsTipoMerce, ref rsIndirizzo, ref rsLocalita, ref rsCap, ref rsNazione, ref rsProvincia, ref rsZonaSpedizione, ref rsZonaTariffaAttiva, ref rsZonaTariffaPassiva, ref rsDescrizioneZonaTariffaAttiva, ref rsDescrizioneZonaSpedizione, ref rsDescrizioneZonaTariffaPassiva, ref rsMess);
				val9.Text = rsZonaTariffaPassiva;
				val8.Text = rsZonaTariffaAttiva;
				val7.Text = rsZonaSpedizione;
				val6.Text = rsProvincia;
				val5.Text = rsNazione;
				val4.Text = rsCap;
				val3.Text = rsLocalita;
				val2.Text = rsIndirizzo;
				val = val10;
				if ((int)val > 0)
				{
					IboWebComboTlk objCombo = cmbPCSPArtenza;
					rsDescrizioneZonaTariffaPassiva = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsDescrizioneZonaTariffaPassiva);
					return;
				}
			}
			if (Operators.CompareString(cmbPCSDestinazione.ObjValue.ToString(), "", false) != 0)
			{
				string? vsCodice2 = cmbPCSDestinazione.ObjValue.ToString();
				string? vsTipoMerce2 = cmbTipoMerce.ObjValue.ToString();
				IboWebTextBox val9;
				string rsDescrizioneZonaTariffaPassiva = (val9 = txtPCSDestinazioneIndirizzo).Text;
				IboWebTextBox val8;
				string rsDescrizioneZonaSpedizione = (val8 = txtPCSDestinazioneLocalita).Text;
				IboWebTextBox val7;
				string rsDescrizioneZonaTariffaAttiva = (val7 = txtPCSDestinazioneCap).Text;
				IboWebTextBox val6;
				string rsZonaTariffaPassiva = (val6 = txtPCSDestinazioneNazione).Text;
				IboWebTextBox val5;
				string rsZonaTariffaAttiva = (val5 = txtPCSDestinazioneProvincia).Text;
				IboWebTextBox val4;
				string rsZonaSpedizione = (val4 = txtPCSDestinazioneZonaSpedizione).Text;
				IboWebTextBox val3;
				string rsProvincia = (val3 = txtPCSDestinazioneZonaTariffaAttiva).Text;
				IboWebTextBox val2;
				string rsNazione = (val2 = txtPCSDestinazioneZonaTariffaPassiva).Text;
				string rsCap = "";
				string rsLocalita = "";
				string rsIndirizzo = "";
				FXRETURN val11 = DecodificaDestinario(vsCodice2, vsTipoMerce2, ref rsDescrizioneZonaTariffaPassiva, ref rsDescrizioneZonaSpedizione, ref rsDescrizioneZonaTariffaAttiva, ref rsZonaTariffaPassiva, ref rsZonaTariffaAttiva, ref rsZonaSpedizione, ref rsProvincia, ref rsNazione, ref rsCap, ref rsLocalita, ref rsIndirizzo, ref rsMess);
				val2.Text = rsNazione;
				val3.Text = rsProvincia;
				val4.Text = rsZonaSpedizione;
				val5.Text = rsZonaTariffaAttiva;
				val6.Text = rsZonaTariffaPassiva;
				val7.Text = rsDescrizioneZonaTariffaAttiva;
				val8.Text = rsDescrizioneZonaSpedizione;
				val9.Text = rsDescrizioneZonaTariffaPassiva;
				val = val11;
				if ((int)val > 0)
				{
					IboWebComboTlk objCombo2 = cmbPCSDestinazione;
					rsIndirizzo = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo2, "", ref rsIndirizzo);
					return;
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void cmbPCSPartenza_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string? vsCodice = cmbPCSPArtenza.ObjValue.ToString();
			string? vsTipoMerce = cmbTipoMerce.ObjValue.ToString();
			IboWebTextBox val2;
			object Indirizzo = RuntimeHelpers.GetObjectValue((val2 = txtPCSPartenzaIndirizzo).ObjValue);
			IboWebTextBox val3;
			object Localita = RuntimeHelpers.GetObjectValue((val3 = txtPCSPartenzaLocalita).ObjValue);
			IboWebTextBox val4;
			object rsCap = RuntimeHelpers.GetObjectValue((val4 = txtPCSPartenzaCap).ObjValue);
			IboWebTextBox val5;
			object rsNazione = RuntimeHelpers.GetObjectValue((val5 = txtPCSPartenzaNazione).ObjValue);
			IboWebTextBox val6;
			object rsProvincia = RuntimeHelpers.GetObjectValue((val6 = txtPCSPartenzaProvincia).ObjValue);
			IboWebTextBox val7;
			object rsZonaSpedizione = RuntimeHelpers.GetObjectValue((val7 = txtPCSPartenzaZonaSpedizione).ObjValue);
			IboWebTextBox val8;
			object rsZonaTariffaAttiva = RuntimeHelpers.GetObjectValue((val8 = txtPCSPartenzaZonaTariffaAttiva).ObjValue);
			IboWebTextBox val9;
			object rsZonaTariffaPassiva = RuntimeHelpers.GetObjectValue((val9 = txtPCSPartenzaZonaTariffaPassiva).ObjValue);
			IboWebTextBox pCSPartenzaZonaSpedizioneQL;
			object rsDescrizioneZonaSpedizione = RuntimeHelpers.GetObjectValue((pCSPartenzaZonaSpedizioneQL = PCSPartenzaZonaSpedizioneQL).ObjValue);
			IboWebTextBox pCSPartenzaZonaTariffaAttivaQL;
			object rsDescrizioneZonaTariffaAttiva = RuntimeHelpers.GetObjectValue((pCSPartenzaZonaTariffaAttivaQL = PCSPartenzaZonaTariffaAttivaQL).ObjValue);
			IboWebTextBox pCSPartenzaZonaTariffaPassivaQL;
			object rsDescrizioneZonaTariffaPassiva = RuntimeHelpers.GetObjectValue((pCSPartenzaZonaTariffaPassivaQL = PCSPartenzaZonaTariffaPassivaQL).ObjValue);
			FXRETURN val10 = DecodificaDestinario2(vsCodice, vsTipoMerce, ref Indirizzo, ref Localita, ref rsCap, ref rsNazione, ref rsProvincia, ref rsZonaSpedizione, ref rsZonaTariffaAttiva, ref rsZonaTariffaPassiva, ref rsDescrizioneZonaSpedizione, ref rsDescrizioneZonaTariffaAttiva, ref rsDescrizioneZonaTariffaPassiva, ref rsMess);
			pCSPartenzaZonaTariffaPassivaQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaTariffaPassiva);
			pCSPartenzaZonaTariffaAttivaQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaTariffaAttiva);
			pCSPartenzaZonaSpedizioneQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaSpedizione);
			val9.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaTariffaPassiva);
			val8.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaTariffaAttiva);
			val7.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaSpedizione);
			val6.ObjValue = RuntimeHelpers.GetObjectValue(rsProvincia);
			val5.ObjValue = RuntimeHelpers.GetObjectValue(rsNazione);
			val4.ObjValue = RuntimeHelpers.GetObjectValue(rsCap);
			val3.ObjValue = RuntimeHelpers.GetObjectValue(Localita);
			val2.ObjValue = RuntimeHelpers.GetObjectValue(Indirizzo);
			val = val10;
			if ((int)val > 0)
			{
				IboWebComboTlk objCombo = cmbPCSPArtenza;
				string rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void cmbPCSDestinazione_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string? vsCodice = cmbPCSDestinazione.ObjValue.ToString();
			string? vsTipoMerce = cmbTipoMerce.ObjValue.ToString();
			IboWebTextBox val2;
			object Indirizzo = RuntimeHelpers.GetObjectValue((val2 = txtPCSDestinazioneIndirizzo).ObjValue);
			IboWebTextBox val3;
			object Localita = RuntimeHelpers.GetObjectValue((val3 = txtPCSDestinazioneLocalita).ObjValue);
			IboWebTextBox val4;
			object rsCap = RuntimeHelpers.GetObjectValue((val4 = txtPCSDestinazioneCap).ObjValue);
			IboWebTextBox val5;
			object rsNazione = RuntimeHelpers.GetObjectValue((val5 = txtPCSDestinazioneNazione).ObjValue);
			IboWebTextBox val6;
			object rsProvincia = RuntimeHelpers.GetObjectValue((val6 = txtPCSDestinazioneProvincia).ObjValue);
			IboWebTextBox val7;
			object rsZonaSpedizione = RuntimeHelpers.GetObjectValue((val7 = txtPCSDestinazioneZonaSpedizione).ObjValue);
			IboWebTextBox val8;
			object rsZonaTariffaAttiva = RuntimeHelpers.GetObjectValue((val8 = txtPCSDestinazioneZonaTariffaAttiva).ObjValue);
			IboWebTextBox val9;
			object rsZonaTariffaPassiva = RuntimeHelpers.GetObjectValue((val9 = txtPCSDestinazioneZonaTariffaPassiva).ObjValue);
			IboWebTextBox pCSDestinazioneZonaSpedizioneQL;
			object rsDescrizioneZonaSpedizione = RuntimeHelpers.GetObjectValue((pCSDestinazioneZonaSpedizioneQL = PCSDestinazioneZonaSpedizioneQL).ObjValue);
			IboWebTextBox pCSDestinazioneZonaTariffaAttivaQL;
			object rsDescrizioneZonaTariffaAttiva = RuntimeHelpers.GetObjectValue((pCSDestinazioneZonaTariffaAttivaQL = PCSDestinazioneZonaTariffaAttivaQL).ObjValue);
			IboWebTextBox pCSDestinazioneZonaTariffaPassivaQL;
			object rsDescrizioneZonaTariffaPassiva = RuntimeHelpers.GetObjectValue((pCSDestinazioneZonaTariffaPassivaQL = PCSDestinazioneZonaTariffaPassivaQL).ObjValue);
			FXRETURN val10 = DecodificaDestinario2(vsCodice, vsTipoMerce, ref Indirizzo, ref Localita, ref rsCap, ref rsNazione, ref rsProvincia, ref rsZonaSpedizione, ref rsZonaTariffaAttiva, ref rsZonaTariffaPassiva, ref rsDescrizioneZonaSpedizione, ref rsDescrizioneZonaTariffaAttiva, ref rsDescrizioneZonaTariffaPassiva, ref rsMess);
			pCSDestinazioneZonaTariffaPassivaQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaTariffaPassiva);
			pCSDestinazioneZonaTariffaAttivaQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaTariffaAttiva);
			pCSDestinazioneZonaSpedizioneQL.ObjValue = RuntimeHelpers.GetObjectValue(rsDescrizioneZonaSpedizione);
			val9.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaTariffaPassiva);
			val8.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaTariffaAttiva);
			val7.ObjValue = RuntimeHelpers.GetObjectValue(rsZonaSpedizione);
			val6.ObjValue = RuntimeHelpers.GetObjectValue(rsProvincia);
			val5.ObjValue = RuntimeHelpers.GetObjectValue(rsNazione);
			val4.ObjValue = RuntimeHelpers.GetObjectValue(rsCap);
			val3.ObjValue = RuntimeHelpers.GetObjectValue(Localita);
			val2.ObjValue = RuntimeHelpers.GetObjectValue(Indirizzo);
			val = val10;
			if ((int)val > 0)
			{
				IboWebComboTlk objCombo = cmbPCSDestinazione;
				string rsMess2 = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo, "", ref rsMess2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private FXRETURN SetRiepilogo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			lblTipoServizioRiepilogoValue.Text = cmbTipoServizio.Text;
			lblNumeroOrdineRiepilogoValue.Text = txtNumeroOrdine.ObjValue.ToString();
			lblDataOrdineRiepilogoValue.Text = txtDataOrdine.ObjValue.ToString();
			lblNumeroBollaRiepilogoValue.Text = txtNumeroBolla.ObjValue.ToString();
			lblDataBollaRiepilogoValue.Text = txtDataBolla.ObjValue.ToString();
			lblClienteRiepilogoValue.Text = cmbCliente.Text;
			lblMittenteRiepilogoValue.Text = txtMittenteRagioneSociale.ObjValue.ToString();
			lblTipoSpedizioneRiepilogoValue.Text = cmbTipoSpedizione.Text;
			lblTipoMerceRiepilogoValue.Text = cmbTipoMerce.Text;
			lblNoteRiepilogoValue.Text = txtNote.ObjValue.ToString();
			lblPCSPartenzaRiepilogoValue.Text = cmbPCSPArtenza.Text;
			lblPCSDestinazioneRiepilogoValue.Text = cmbPCSDestinazione.Text;
			lblDataConsegnaPrevista1RiepilogoValue.Text = txtDataConsegnaPrevista1.ObjValue.ToString();
			lblDataConsegnaPrevista2RiepilogoValue.Text = txtDataConsegnaPrevista2.ObjValue.ToString();
			lblDataRitiroPrevista1RiepilogoValue.Text = txtDataRitiroPrevista1.ObjValue.ToString();
			lblDataRitiroPrevista2RiepilogoValue.Text = txtDataRitiroPrevista2.ObjValue.ToString();
			foreach (RepeaterItem item in RepeaterSpedizioneQuantita.Items)
			{
				RepeaterItem parent = item;
				string text2 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoQuantitaCodice")).ObjValue.ToString();
				string text3 = ((IIboWebComponent)GetControlByName((Control)(object)parent, "TipoQuantitaDescrizione")).ObjValue.ToString();
				object objectValue = RuntimeHelpers.GetObjectValue(((IIboWebComponent)GetControlByName((Control)(object)parent, "Quantita")).ObjValue);
				if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) && decimal.Compare(Conversions.ToDecimal(objectValue), 0m) > 0)
				{
					text = text + text3 + ": " + Conversions.ToString(objectValue) + "</br>";
				}
			}
			lblTipiImballoRiepilogoValue.Text = text;
			lblAttivazioneAutomaticaRiepilogoValue.ObjValue = chkAttivazioneAutomatica.ObjValue.ToString();
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
			result = val;
		}
		return result;
	}

	private void SetActiveViewLabel()
	{
		try
		{
			Label1.CssClass = "LabelNonAttivo";
			Label2.CssClass = "LabelNonAttivo";
			Label4.CssClass = "LabelNonAttivo";
			Label5.CssClass = "LabelNonAttivo";
			switch (WizardInserimentoSpedizione.ActiveViewIndex)
			{
			case 0:
				Label1.CssClass = "LabelAttivo";
				break;
			case 1:
				Label2.CssClass = "LabelAttivo";
				break;
			case 2:
				Label4.CssClass = "LabelAttivo";
				break;
			case 3:
				Label5.CssClass = "LabelAttivo";
				break;
			case 4:
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private FXRETURN CheckInfo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string iD = ((Control)WizardInserimentoSpedizione.GetActiveView()).ID;
			val2 = ((Operators.CompareString(iD, ((Control)WSRiferimentiSpedizione).ID, false) == 0) ? CheckRiferimentiSpedizione(ref rsMess) : ((Operators.CompareString(iD, ((Control)WSPCS).ID, false) == 0) ? CheckPCS(ref rsMess) : ((Operators.CompareString(iD, ((Control)WSSpedizioneQuantita).ID, false) != 0) ? ((FXRETURN)0) : CheckQuantita(ref rsMess))));
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
			result = val;
		}
		return result;
	}

	private FXRETURN CheckRiferimentiSpedizione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			bool flag;
			bool flag2;
			if (Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire il Cliente");
			}
			else if (Operators.CompareString(cmbTipoServizio.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire il Tipo di Servizio");
			}
			else
			{
				string text = "SELECT flgTra,ConMagazzino FROM Clienti WHERE CODICE=" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
				DataTable dataTable = null;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					text = "SELECT * FROM TipiServizi WHERE CODICE=" + base.DbConn.SQLFormatString(cmbTipoServizio.ObjValue.ToString());
					DataTable dataTable2 = null;
					val2 = base.DbConn.OpenDataTable(text, ref dataTable2, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						flag = false;
						flag2 = false;
						if (Operators.CompareString(dataTable2.Rows[0]["Is_Consegna"].ToString(), "S", false) != 0)
						{
							goto IL_0332;
						}
						if (!((Operators.CompareString(dataTable.Rows[0]["flgTra"].ToString(), "S", false) == 0) & (Operators.CompareString(dataTable.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0)))
						{
							if ((Operators.CompareString(dataTable.Rows[0]["flgTra"].ToString(), "S", false) == 0) & (Operators.CompareString(dataTable.Rows[0]["ConMagazzino"].ToString(), "N", false) == 0))
							{
								flag = true;
								flag2 = false;
							}
							else if ((Operators.CompareString(dataTable.Rows[0]["flgTra"].ToString(), "N", false) == 0) & (Operators.CompareString(dataTable.Rows[0]["ConMagazzino"].ToString(), "S", false) == 0))
							{
								flag = false;
								flag2 = true;
							}
							goto IL_0332;
						}
						if (Operators.CompareString(dataTable2.Rows[0]["TransitoDeposito"].ToString(), "T", false) == 0)
						{
							flag = true;
							goto IL_0332;
						}
						if (Operators.CompareString(dataTable2.Rows[0]["TransitoDeposito"].ToString(), "D", false) == 0)
						{
							flag2 = true;
							goto IL_0332;
						}
						if (Operators.CompareString(dataTable2.Rows[0]["TransitoDeposito"].ToString(), "X", false) != 0)
						{
							goto IL_0332;
						}
						rsMess = TranslateMessage("XXX", "Impossibile determinare se la spedizione sia di transito o di deposito in quanto sia la configurazione del cliente sia quella del Tipo servizio prevedono entrambe le tipologie");
					}
				}
			}
			goto end_IL_0005;
			IL_0332:
			if (flag2 && Operators.CompareString(txtNumeroOrdine.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire numero ordine");
			}
			else if (flag && Operators.CompareString(txtNumeroBolla.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire numero bolla");
			}
			else if (Operators.CompareString(cmbTipoSpedizione.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire il Tipo di Spedizione");
			}
			else if (Operators.CompareString(cmbTipoMerce.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire il Tipo di Merce");
			}
			else
			{
				val = (FXRETURN)0;
			}
			end_IL_0005:;
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
			result = val;
		}
		return result;
	}

	private FXRETURN CheckPCS(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			if (Operators.CompareString(cmbPCSDestinazione.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire la Destinazione");
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
			result = val;
		}
		return result;
	}

	private FXRETURN CheckDate(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			if ((Operators.CompareString(txtDataRitiroPrevista2.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtDataRitiroPrevista1.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire Data iniziale Ritiro Prevista");
			}
			else if (((Operators.CompareString(txtDataRitiroPrevista2.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtDataRitiroPrevista1.ObjValue.ToString(), "", false) != 0)) && DateTime.Compare(Conversions.ToDate(txtDataRitiroPrevista2.ObjValue), Conversions.ToDate(txtDataRitiroPrevista1.ObjValue)) < 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire Data Finale Ritiro Prevista successiva alla Data Iniziale");
			}
			else if ((Operators.CompareString(txtDataConsegnaPrevista2.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtDataConsegnaPrevista1.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire Data iniziale Consegna Prevista");
			}
			else if (((Operators.CompareString(txtDataConsegnaPrevista2.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(txtDataConsegnaPrevista1.ObjValue.ToString(), "", false) != 0)) && DateTime.Compare(Conversions.ToDate(txtDataConsegnaPrevista2.ObjValue), Conversions.ToDate(txtDataConsegnaPrevista1.ObjValue)) < 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire Data Finale Consegna Prevista successiva alla Data Iniziale");
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
			result = val;
		}
		return result;
	}

	private FXRETURN CheckQuantita(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoNextPanel(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string iD = ((Control)WizardInserimentoSpedizione.GetActiveView()).ID;
			val2 = ((Operators.CompareString(iD, ((Control)WSRiferimentiSpedizione).ID, false) == 0) ? ((FXRETURN)0) : ((Operators.CompareString(iD, ((Control)WSPCS).ID, false) == 0) ? SetInfoPanelPCS(ref rsMess) : ((Operators.CompareString(iD, ((Control)WSSpedizioneQuantita).ID, false) != 0) ? ((FXRETURN)0) : SetInfoPanelQuantita(ref rsMess))));
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoPanelCliente(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoPanelTipoSpedizione(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			cmbTipoSpedizione.SqlQueryFilter = "CLIENTE = " + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
			IboWebComboTlk objCombo = cmbTipoSpedizione;
			FXRETURN val3 = LoadSingleCombo(ref objCombo, ref rsMess);
			cmbTipoSpedizione = objCombo;
			val2 = val3;
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoPanelPCS(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoPanelDate(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
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
			result = val;
		}
		return result;
	}

	private FXRETURN SetInfoPanelQuantita(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
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
			result = val;
		}
		return result;
	}

	private FXRETURN DecodificaDestinario(string vsCodice, string vsTipoMerce, ref string rsIndirizzo, ref string rsLocalita, ref string rsCap, ref string rsNazione, ref string rsProvincia, ref string rsZonaSpedizione, ref string rsZonaTariffaAttiva, ref string rsZonaTariffaPassiva, ref string rsDescrizioneZonaTariffaAttiva, ref string rsDescrizioneZonaSpedizione, ref string rsDescrizioneZonaTariffaPassiva, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		object obj = null;
		DataTable dataTable2 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			rsIndirizzo = "";
			rsCap = "";
			rsNazione = "";
			rsLocalita = "";
			rsProvincia = "";
			rsZonaSpedizione = "";
			rsZonaTariffaAttiva = "";
			rsZonaTariffaPassiva = "";
			text2 = "SELECT INDIRIZZO,CAP,PROVINCIA,NAZIONE,LOCALITA FROM PCS WHERE CODICE = " + base.DbConn.SQLFormatString(vsCodice);
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = (((int)val2 != 14) ? val2 : ((FXRETURN)0));
			}
			else
			{
				if (dataTable.Rows.Count != 1)
				{
					goto IL_02a2;
				}
				rsIndirizzo = dataTable.Rows[0]["INDIRIZZO"].ToString();
				rsCap = dataTable.Rows[0]["CAP"].ToString();
				rsNazione = dataTable.Rows[0]["NAZIONE"].ToString();
				rsLocalita = dataTable.Rows[0]["LOCALITA"].ToString();
				rsProvincia = dataTable.Rows[0]["PROVINCIA"].ToString();
				text2 = "SELECT Pcs,TipoMerce,ZonaSpedizione,ZonaTariffaAttiva,ZonaTariffaPassiva, Peso1 Peso FROM ( ";
				text2 += "SELECT PCS,Z.TIPOMERCE,ZonaSpedizione,ZonaTariffaAttiva,ZonaTariffaPassiva, ";
				text2 += "CASE WHEN TipoMerce<>'*ALL' THEN 100 ELSE 0 END Peso1 ";
				text2 += "FROM PCS_Zone Z INNER JOIN TIPIMERCE TM ON TM.CODICE = Z.TIPOMERCE ";
				text2 = text2 + "WHERE Z.TipoMerce IN ('*ALL', " + base.DbConn.SQLFormatString(vsTipoMerce) + ") AND ";
				text2 += "TM.Attivo='S' AND Z.ATTIVO = 'S') T ";
				text2 = text2 + "WHERE PCS = " + base.DbConn.SQLFormatString(vsCodice) + " ";
				text2 += "ORDER BY Peso DESC ";
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable2, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (dataTable2.Rows.Count > 0)
					{
						rsZonaSpedizione = dataTable2.Rows[0]["ZonaSpedizione"].ToString();
						rsZonaTariffaAttiva = dataTable2.Rows[0]["ZonaTariffaAttiva"].ToString();
						rsZonaTariffaPassiva = dataTable2.Rows[0]["ZonaTariffaPassiva"].ToString();
					}
					goto IL_02a2;
				}
				val = (((int)val2 != 14) ? val2 : ((FXRETURN)0));
			}
			goto end_IL_001b;
			IL_02a2:
			val = (FXRETURN)0;
			end_IL_001b:;
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

	private FXRETURN DecodificaDestinario2(string vsCodice, string vsTipoMerce, ref object Indirizzo, ref object Localita, ref object rsCap, ref object rsNazione, ref object rsProvincia, ref object rsZonaSpedizione, ref object rsZonaTariffaAttiva, ref object rsZonaTariffaPassiva, ref object rsDescrizioneZonaSpedizione, ref object rsDescrizioneZonaTariffaAttiva, ref object rsDescrizioneZonaTariffaPassiva, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Invalid comparison between Unknown and I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		object obj = null;
		DataTable dataTable2 = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Indirizzo = "";
			rsCap = "";
			rsNazione = "";
			Localita = "";
			rsProvincia = "";
			rsZonaSpedizione = "";
			rsZonaTariffaAttiva = "";
			rsZonaTariffaPassiva = "";
			rsDescrizioneZonaSpedizione = "";
			rsDescrizioneZonaTariffaAttiva = "";
			rsDescrizioneZonaTariffaPassiva = "";
			text2 = "SELECT INDIRIZZO,CAP,PROVINCIA,NAZIONE,LOCALITA FROM PCS WHERE CODICE = " + base.DbConn.SQLFormatString(vsCodice);
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = (((int)val2 != 14) ? val2 : ((FXRETURN)0));
			}
			else
			{
				if (dataTable.Rows.Count != 1)
				{
					goto IL_0360;
				}
				Indirizzo = dataTable.Rows[0]["INDIRIZZO"].ToString();
				rsCap = dataTable.Rows[0]["CAP"].ToString();
				rsNazione = dataTable.Rows[0]["NAZIONE"].ToString();
				Localita = dataTable.Rows[0]["LOCALITA"].ToString();
				rsProvincia = dataTable.Rows[0]["PROVINCIA"].ToString();
				text2 = "SELECT Pcs,TipoMerce,T.ZonaSpedizione,T.ZonaTariffaAttiva,T.ZonaTariffaPassiva, Peso1 Peso, ";
				text2 += "Z1.Descrizione as ZSDes, Z2.Descrizione as ZTADes,Z2.Descrizione as ZTPDes ";
				text2 += "FROM ( ";
				text2 += "SELECT PCS,Z.TIPOMERCE,ZonaSpedizione,ZonaTariffaAttiva,ZonaTariffaPassiva, ";
				text2 += "CASE WHEN TipoMerce<>'*ALL' THEN 100 ELSE 0 END Peso1 ";
				text2 += "FROM PCS_Zone Z INNER JOIN TIPIMERCE TM ON TM.CODICE = Z.TIPOMERCE ";
				text2 = text2 + "WHERE Z.TipoMerce IN ('*ALL', " + base.DbConn.SQLFormatString(vsTipoMerce) + ") AND ";
				text2 += "TM.Attivo='S' AND Z.ATTIVO = 'S') T ";
				text2 += "LEFT JOIN ZONE Z1 ON Z1.CODICE = T.ZonaSpedizione ";
				text2 += "LEFT JOIN ZONE Z2 ON Z2.CODICE = T.ZonaTariffaAttiva ";
				text2 += "LEFT JOIN ZONE Z3 ON Z3.CODICE = T. ZonaTariffaPassiva ";
				text2 = text2 + "WHERE PCS = " + base.DbConn.SQLFormatString(vsCodice) + " ";
				text2 += "ORDER BY Peso DESC ";
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable2, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (dataTable2.Rows.Count > 0)
					{
						rsZonaSpedizione = dataTable2.Rows[0]["ZonaSpedizione"].ToString();
						rsZonaTariffaAttiva = dataTable2.Rows[0]["ZonaTariffaAttiva"].ToString();
						rsZonaTariffaPassiva = dataTable2.Rows[0]["ZonaTariffaPassiva"].ToString();
						rsDescrizioneZonaSpedizione = dataTable2.Rows[0]["ZSDes"].ToString();
						rsDescrizioneZonaTariffaAttiva = dataTable2.Rows[0]["ZTADes"].ToString();
						rsDescrizioneZonaTariffaPassiva = dataTable2.Rows[0]["ZTPDes"].ToString();
					}
					goto IL_0360;
				}
				val = (((int)val2 != 14) ? val2 : ((FXRETURN)0));
			}
			goto end_IL_001b;
			IL_0360:
			val = (FXRETURN)0;
			end_IL_001b:;
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

	private FXRETURN CaricamentoSpedizioni_Quantita(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtSource = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text += "SELECT NOMECAMPO AS TipoQuantitaCodice,DESCRIZIONE AS TipoQuantitaDescrizione,2 as TipologiaDato ";
			text += "FROM TABCAMPICALCOLO ";
			text += "WHERE CAMPOSPEDIZIONE = 'S' AND ViewInInsertSpedizione > 0 AND NOMECAMPO IN (";
			text += "'COLLI','PALLET','PESO','VOLUME','CONTRASSEGNO',";
			text += "'CAMPOCALCOLO1','CAMPOCALCOLO2','CAMPOCALCOLO3','CAMPOCALCOLO4','CAMPOCALCOLO5',";
			text += "'CAMPOCALCOLO6','CAMPOCALCOLO7','CAMPOCALCOLO8','CAMPOCALCOLO9','CAMPOCALCOLO10') ";
			text += "ORDER BY ViewInInsertSpedizione";
			val2 = base.DbConn.OpenDataTable(text, ref dtSource, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				base.BaseFunctions.CloneDataTable(dtSource, ref _dtSpedizioni_Quantita);
				RepeaterDataRebind();
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

	private void RepeaterSpedizioneQuantita_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataRow row = ((DataRowView)e.Item.DataItem).Row;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipoQuantitaCodice")).ObjValue = row["TipoQuantitaCodice"].ToString();
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipoQuantitaDescrizione")).ObjValue = row["TipoQuantitaDescrizione"].ToString().ToUpper();
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Quantita")).ObjValue = 0;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Quantita")).FieldDescription = row["TipoQuantitaDescrizione"].ToString();
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipologiaDato")).ObjValue = RuntimeHelpers.GetObjectValue(row["TipologiaDato"]);
			_DecimalDigitCollection.Add(row["TipoQuantitaCodice"].ToString(), row["TipologiaDato"].ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void RepeaterDataRebind()
	{
		_DecimalDigitCollection.Clear();
		_dtSpedizioni_Quantita.AcceptChanges();
		RepeaterSpedizioneQuantita.DataSource = _dtSpedizioni_Quantita;
		RepeaterSpedizioneQuantita.DataBind();
	}
}
