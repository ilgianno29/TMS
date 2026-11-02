using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Api.Locate;
using Incasbo.My;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAPCSGeocodifica : WFIDBPage
{
	public enum DescrizioneClassificazione
	{
		MANUAL_POSITION = 9,
		EXACT = 7,
		PARTIALLY_EXACT = 6,
		HIGH = 5,
		MEDIUM = 4,
		LOW = 3,
		NO_INPUT = 2,
		NO_RESULT = 1,
		NOT_CLASSIFIED = 0
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnReverseGeocoding")]
	private IboWebButton _btnReverseGeocoding;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGeocodifica")]
	private IboWebButton _btnGeocodifica;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConfermaPosizione")]
	private IboWebButton _btnConfermaPosizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGeocodificaPopup")]
	private IboWebButton _btnGeocodificaPopup;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdElencoLocalitaMappa")]
	private GridView _grdElencoLocalitaMappa;

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

	[field: AccessedThroughProperty("cpIndOrig_Title")]
	protected virtual Panel cpIndOrig_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIndOrig_Title_Caption")]
	protected virtual Label cpIndOrig_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIndOrig_Body")]
	protected virtual Panel cpIndOrig_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodice")]
	protected virtual IboWebTextBox txtCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RagioneSociale")]
	protected virtual IboWebTextBox RagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Indirizzo")]
	protected virtual IboWebTextBox Indirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cap")]
	protected virtual IboWebTextBox Cap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Localita")]
	protected virtual IboWebTextBox Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Provincia")]
	protected virtual IboWebTextBox Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Nazione")]
	protected virtual IboWebTextBox Nazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoSoggetto")]
	protected virtual HiddenField TipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpMap_Title")]
	protected virtual Panel cpMap_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpMap_Title_Caption")]
	protected virtual Label cpMap_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpMap_Body")]
	protected virtual Panel cpMap_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upMap")]
	protected virtual UpdatePanel upMap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mapContainer")]
	protected virtual Panel mapContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NoGeocodingExist")]
	protected virtual Panel NoGeocodingExist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNoGeocodingExist")]
	protected virtual Label lblNoGeocodingExist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIndNorm_Title")]
	protected virtual Panel cpIndNorm_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIndNorm_Title_Caption")]
	protected virtual Label cpIndNorm_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upIndNorm")]
	protected virtual UpdatePanel upIndNorm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpIndNorm_Body")]
	protected virtual Panel cpIndNorm_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFLatitudine")]
	protected virtual HiddenField HFLatitudine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFLongitudine")]
	protected virtual HiddenField HFLongitudine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFReverseGeocodingNeeded")]
	protected virtual HiddenField HFReverseGeocodingNeeded
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnReverseGeocoding
	{
		[CompilerGenerated]
		get
		{
			return _btnReverseGeocoding;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnReverseGeocoding_Click;
			IboWebButton val = _btnReverseGeocoding;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnReverseGeocoding = value;
			val = _btnReverseGeocoding;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("txtIndirizzoNormalizzato")]
	protected virtual IboWebTextBox txtIndirizzoNormalizzato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumeroCivicoNormalizzato")]
	protected virtual IboWebTextBox txtNumeroCivicoNormalizzato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalitaNormalizzata")]
	protected virtual IboWebTextBox txtLocalitaNormalizzata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtQuartiereNormalizzato")]
	protected virtual IboWebTextBox txtQuartiereNormalizzato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCapNormalizzato")]
	protected virtual IboWebTextBox txtCapNormalizzato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtProvinciaNormalizzata")]
	protected virtual IboWebTextBox txtProvinciaNormalizzata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNazioneNormalizzata")]
	protected virtual IboWebTextBox txtNazioneNormalizzata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFormatoCoordinate")]
	protected virtual IboWebTextBox txtFormatoCoordinate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLatitudine")]
	protected virtual IboWebTextBox txtLatitudine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLongitudine")]
	protected virtual IboWebTextBox txtLongitudine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DescrizioneTipoGeocodifica")]
	protected virtual IboWebTextBox DescrizioneTipoGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnConfigId")]
	protected virtual IboWebHidden hdnConfigId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnIdRicerca")]
	protected virtual IboWebHidden hdnIdRicerca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRate_Title")]
	protected virtual Panel cpRate_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRate_Title_Caption")]
	protected virtual Label cpRate_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upRate")]
	protected virtual UpdatePanel upRate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpRate_Body")]
	protected virtual Panel cpRate_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzo")]
	protected virtual IboWebLabel lblIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIndirizzoRicerca")]
	protected virtual IboWebTextBox txtIndirizzoRicerca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCap")]
	protected virtual IboWebLabel lblCap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCapRicerca")]
	protected virtual IboWebTextBox txtCapRicerca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLocalita")]
	protected virtual IboWebLabel lblLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalitaRicerca")]
	protected virtual IboWebTextBox txtLocalitaRicerca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNazione")]
	protected virtual IboWebLabel lblNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNazioneRicerca")]
	protected virtual IboWebTextBox txtNazioneRicerca
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPunteggioTotale")]
	protected virtual IboWebLabel lblPunteggioTotale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPunteggioTotale")]
	protected virtual IboWebTextBox txtPunteggioTotale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneIndirizzo")]
	protected virtual IboWebTextBox txtClassificazioneIndirizzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneIndDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneIndDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassificazione")]
	protected virtual IboWebLabel lblClassificazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazione")]
	protected virtual IboWebTextBox txtClassificazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLivelloDettaglio")]
	protected virtual IboWebLabel lblLivelloDettaglio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLivelloDettaglio")]
	protected virtual IboWebTextBox txtLivelloDettaglio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLivelloDettaglioDescrizione")]
	protected virtual IboWebTextBox txtLivelloDettaglioDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassificazioneVia")]
	protected virtual IboWebLabel lblClassificazioneVia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneVia")]
	protected virtual IboWebTextBox txtClassificazioneVia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneViaDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneViaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassificazioneCivico")]
	protected virtual IboWebLabel lblClassificazioneCivico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneCivico")]
	protected virtual IboWebTextBox txtClassificazioneCivico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneCivicoDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneCivicoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassificazioneLocalita")]
	protected virtual IboWebLabel lblClassificazioneLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneLocalita")]
	protected virtual IboWebTextBox txtClassificazioneLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneLocalitaDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneLocalitaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassificazioneCAP")]
	protected virtual IboWebLabel lblClassificazioneCAP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneCAP")]
	protected virtual IboWebTextBox txtClassificazioneCAP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtClassificazioneCAPDescrizione")]
	protected virtual IboWebTextBox txtClassificazioneCAPDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upButtonGeocodifica")]
	protected virtual UpdatePanel upButtonGeocodifica
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGeocodifica
	{
		[CompilerGenerated]
		get
		{
			return _btnGeocodifica;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGeocodifica_Click;
			IboWebButton val = _btnGeocodifica;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGeocodifica = value;
			val = _btnGeocodifica;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnConfermaPosizione
	{
		[CompilerGenerated]
		get
		{
			return _btnConfermaPosizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnConfermaPosizione_Click;
			IboWebButton val = _btnConfermaPosizione;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnConfermaPosizione = value;
			val = _btnConfermaPosizione;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("UPPopupFormGlobalContainer")]
	protected virtual UpdatePanel UPPopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormGlobalContainer")]
	protected virtual Panel PopupFormGlobalContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormContainer")]
	protected virtual Panel PopupFormContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormTitleBar")]
	protected virtual Panel PopupFormTitleBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormCaption")]
	protected virtual IboWebLabel PopupFormCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPPopupForm")]
	protected virtual UpdatePanel UPPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupFormBody")]
	protected virtual Panel PopupFormBody
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoLocalitaMappa")]
	protected virtual Panel ElencoLocalitaMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzoMappa")]
	protected virtual IboWebLabel lblIndirizzoMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIndirizzoMappa")]
	protected virtual IboWebTextBox txtIndirizzoMappa
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

	[field: AccessedThroughProperty("lblCapMappa")]
	protected virtual IboWebLabel lblCapMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCapMappa")]
	protected virtual IboWebTextBox txtCapMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnConfigIdMappa")]
	protected virtual IboWebHidden hdnConfigIdMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnIdRicercaMappa")]
	protected virtual IboWebHidden hdnIdRicercaMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLocalitaMappa")]
	protected virtual IboWebLabel lblLocalitaMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalitaMappa")]
	protected virtual IboWebTextBox txtLocalitaMappa
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

	[field: AccessedThroughProperty("lblNazioneMappa")]
	protected virtual IboWebLabel lblNazioneMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNazioneMappa")]
	protected virtual IboWebTextBox txtNazioneMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGeocodificaPopup
	{
		[CompilerGenerated]
		get
		{
			return _btnGeocodificaPopup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGeocodificaPopup_Click;
			IboWebButton val = _btnGeocodificaPopup;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGeocodificaPopup = value;
			val = _btnGeocodificaPopup;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual GridView grdElencoLocalitaMappa
	{
		[CompilerGenerated]
		get
		{
			return _grdElencoLocalitaMappa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = grdElencoLocalitaMappa_SelectedIndexChanged;
			GridView val = _grdElencoLocalitaMappa;
			if (val != null)
			{
				val.SelectedIndexChanged -= eventHandler;
			}
			_grdElencoLocalitaMappa = value;
			val = _grdElencoLocalitaMappa;
			if (val != null)
			{
				val.SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("PopupFormButtons")]
	protected virtual Panel PopupFormButtons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdAnnulla")]
	protected virtual IboWebButton PopupForm_cmdAnnulla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm_cmdOk")]
	protected virtual IboWebButton PopupForm_cmdOk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForPopupForm")]
	protected virtual Button hiddenTargetControlForPopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupForm")]
	protected virtual ModalPopupExtender PopupForm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string xMap_Server => Incasbo.My.MySettingsProperty.Settings.xMap_Server;

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_Title = base.Translator.Translate("XXX", "Geocodifica PCS", new string[0]);
		ToolTipManagerDisable();
		_Tabella = "PCS_Geocodifica";
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadPage(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (((Page)this).IsPostBack)
				{
					goto IL_0211;
				}
				if (Operators.CompareString(base.SessionEnvironment.ApplicationParams.LocalizzaDestinatari(), "S", false) == 0)
				{
					HtmlGenericControl val3 = new HtmlGenericControl("script");
					((HtmlControl)val3).Attributes.Add("type", "text/javascript");
					((HtmlControl)val3).Attributes.Add("src", Incasbo.My.MySettingsProperty.Settings.xMap_Server + "/ajaxmaps/webcomponent/script/excanvas.js");
					((Control)((Control)this).Page.Header).Controls.Add((Control)(object)val3);
					HtmlGenericControl val4 = new HtmlGenericControl("script");
					((HtmlControl)val4).Attributes.Add("type", "text/javascript");
					((HtmlControl)val4).Attributes.Add("src", Incasbo.My.MySettingsProperty.Settings.xMap_Server + "/ajaxmaps/webcomponent/script/qooxdoo/script/qx-transport.js");
					((Control)((Control)this).Page.Header).Controls.Add((Control)(object)val4);
					HtmlGenericControl val5 = new HtmlGenericControl("script");
					((HtmlControl)val5).Attributes.Add("type", "text/javascript");
					((HtmlControl)val5).Attributes.Add("src", Incasbo.My.MySettingsProperty.Settings.xMap_Server + "/ajaxmaps/.qxrpc");
					((Control)((Control)this).Page.Header).Controls.Add((Control)(object)val5);
					HtmlGenericControl val6 = new HtmlGenericControl("script");
					((HtmlControl)val6).Attributes.Add("type", "text/javascript");
					((HtmlControl)val6).Attributes.Add("src", Incasbo.My.MySettingsProperty.Settings.xMap_Server + "/ajaxmaps/webcomponent/script/map.js");
					((Control)((Control)this).Page.Header).Controls.Add((Control)(object)val6);
					HFReverseGeocodingNeeded.Value = "N";
					goto IL_0211;
				}
				rsMess = TranslateMessage("XXX", "Localizzazione non abilitata in questo sistema.");
			}
			goto end_IL_0005;
			IL_0211:
			val = (FXRETURN)0;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
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
				text = "SELECT RAGIONESOCIALE,INDIRIZZO,LOCALITA,CAP,PROVINCIA,NAZIONE FROM PCS ";
				text = text + "WHERE CODICE = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (dataTable.Rows.Count > 0)
					{
						RagioneSociale.ObjValue = dataTable.Rows[0]["RAGIONESOCIALE"].ToString();
						Indirizzo.ObjValue = dataTable.Rows[0]["INDIRIZZO"].ToString();
						Localita.ObjValue = dataTable.Rows[0]["LOCALITA"].ToString();
						Cap.ObjValue = dataTable.Rows[0]["CAP"].ToString();
						Provincia.ObjValue = dataTable.Rows[0]["PROVINCIA"].ToString();
						Nazione.ObjValue = dataTable.Rows[0]["NAZIONE"].ToString();
					}
					string text2 = txtClassificazioneCAP.Text;
					string text3 = txtClassificazioneLocalita.Text;
					string text4 = txtClassificazioneVia.Text;
					string text5 = txtClassificazioneCivico.Text;
					IboWebTextBox val3;
					string ClassificazioneCAPDescrizione = (val3 = txtClassificazioneCAPDescrizione).Text;
					IboWebTextBox val4;
					string ClassificazioneLocalitaDescrizione = (val4 = txtClassificazioneLocalitaDescrizione).Text;
					IboWebTextBox val5;
					string ClassificazioneViaDescrizione = (val5 = txtClassificazioneViaDescrizione).Text;
					IboWebTextBox val6;
					string ClassificazioneCivicoDescrizione = (val6 = txtClassificazioneCivicoDescrizione).Text;
					FXRETURN descriptions = GetDescriptions(text2, text3, text4, text5, ref ClassificazioneCAPDescrizione, ref ClassificazioneLocalitaDescrizione, ref ClassificazioneViaDescrizione, ref ClassificazioneCivicoDescrizione, ref rsMess);
					val6.Text = ClassificazioneCivicoDescrizione;
					val5.Text = ClassificazioneViaDescrizione;
					val4.Text = ClassificazioneLocalitaDescrizione;
					val3.Text = ClassificazioneCAPDescrizione;
					val2 = descriptions;
					val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
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
			else if ((Operators.CompareString(txtLatitudine.ObjValue.ToString(), "", false) == 0) | (Operators.CompareString(txtLongitudine.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Per salvare i dati è necessario effettuare una geocodifica.");
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(HFReverseGeocodingNeeded.Value, "S", false) != 0)
			{
				goto IL_0049;
			}
			val2 = ReverseGeocoding(ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0049;
			}
			val = val2;
			goto end_IL_0005;
			IL_0049:
			val = (FXRETURN)0;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private void btnGeocodifica_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		LocateLocation locateLocation = new LocateLocation();
		try
		{
			if ((Operators.CompareString(Localita.Text, "", false) == 0) & (Operators.CompareString(Cap.Text, "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Valorizzare il Cap o la località");
				return;
			}
			locateLocation.Via = Indirizzo.Text;
			locateLocation.Cap = Cap.Text;
			locateLocation.Localita = Localita.Text;
			locateLocation.Nazione = Nazione.Text;
			LocateManager locateManager = new LocateManager(CreateApiContext());
			locateManager.objLocation = locateLocation;
			val2 = ((AppAbstractApi)locateManager).Run(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			List<LocateLocation> locationsList = locateManager.LocationsList;
			_SessionVariable.Add("ElencoLocalitaMappa", locationsList);
			((HiddenField)hdnConfigId).Value = locateManager.ConfigId;
			((HiddenField)hdnIdRicerca).Value = locateManager.IdRicerca.ToString();
			((HiddenField)hdnConfigIdMappa).Value = locateManager.ConfigId;
			((HiddenField)hdnIdRicercaMappa).Value = locateManager.IdRicerca.ToString();
			((BaseDataBoundControl)grdElencoLocalitaMappa).DataSource = locationsList;
			grdElencoLocalitaMappa.DataBind();
			grdElencoLocalitaMappa.SelectedIndex = -1;
			txtIndirizzoMappa.Text = Indirizzo.Text;
			txtCapMappa.Text = Cap.Text;
			txtLocalitaMappa.Text = Localita.Text;
			txtNazioneMappa.Text = Nazione.Text;
			SetIncasFocusToControl((Control)(object)txtIndirizzoMappa);
			OpenPopupForm("Cerca", (Control)(object)ElencoLocalitaMappa, ButtonsVisible: true, ButtonsOkVisible: false, ButtonsAnnullaVisible: true, "RICERCAXLOCATE");
			upButtonGeocodifica.Update();
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

	private void btnReverseGeocoding_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			val2 = ReverseGeocoding(ref rsMess);
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
			upIndNorm.Update();
			upRate.Update();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnConfermaPosizione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			txtClassificazioneCAP.ObjValue = "9";
			txtClassificazioneLocalita.ObjValue = "9";
			txtClassificazioneCivico.ObjValue = "9";
			txtClassificazioneIndirizzo.ObjValue = "9";
			txtClassificazioneVia.ObjValue = "9";
			txtClassificazione.Text = "100";
			txtClassificazioneDescrizione.Text = "MANUAL POSITION";
			txtPunteggioTotale.ObjValue = "100";
			string? classificazioneCAP = txtClassificazioneCAP.ObjValue.ToString();
			string? classificazioneLocalita = txtClassificazioneLocalita.ObjValue.ToString();
			string? classificazioneVia = txtClassificazioneVia.ObjValue.ToString();
			string? classificazioneCivico = txtClassificazioneCivico.ObjValue.ToString();
			IboWebTextBox val3;
			string ClassificazioneCAPDescrizione = (val3 = txtClassificazioneCAPDescrizione).Text;
			IboWebTextBox val4;
			string ClassificazioneLocalitaDescrizione = (val4 = txtClassificazioneLocalitaDescrizione).Text;
			IboWebTextBox val5;
			string ClassificazioneViaDescrizione = (val5 = txtClassificazioneViaDescrizione).Text;
			IboWebTextBox val6;
			string ClassificazioneCivicoDescrizione = (val6 = txtClassificazioneCivicoDescrizione).Text;
			FXRETURN descriptions = GetDescriptions(classificazioneCAP, classificazioneLocalita, classificazioneVia, classificazioneCivico, ref ClassificazioneCAPDescrizione, ref ClassificazioneLocalitaDescrizione, ref ClassificazioneViaDescrizione, ref ClassificazioneCivicoDescrizione, ref rsMess);
			val6.Text = ClassificazioneCivicoDescrizione;
			val5.Text = ClassificazioneViaDescrizione;
			val4.Text = ClassificazioneLocalitaDescrizione;
			val3.Text = ClassificazioneCAPDescrizione;
			val2 = descriptions;
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			upRate.Update();
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

	private FXRETURN recuperaRisultatoDaPopup(ref string rsIndirizzo, ref string rsNumCivico, ref string rsCap, ref string rsLocalita, ref string rsQuartiere, ref string rsNazione, ref string rsLatitudine, ref string rsLongitudine, ref string rsPunteggioTotale, ref string rsClassificazione, ref string rsClassificazioneDescrizione, ref string rsLivelloDettaglio, ref string rsLivelloDettaglioDescrizione, ref string rsClassificazioneIndirizzo, ref string rsClassificazioneIndirizzoDescrizione, ref string rsClassificazioneCAP, ref string rsClassificazioneLocalita, ref string rsClassificazioneVia, ref string rsClassificazioneCivico, ref string rsConfigId, ref string rsConfigIdDescrizione, ref string rsIdRicerca, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsIndirizzo = "";
			rsNumCivico = "";
			rsCap = "";
			rsLocalita = "";
			rsQuartiere = "";
			rsNazione = "";
			rsLatitudine = "";
			rsLongitudine = "";
			rsPunteggioTotale = "";
			rsClassificazione = "";
			rsClassificazioneDescrizione = "";
			rsLivelloDettaglio = "";
			rsLivelloDettaglioDescrizione = "";
			rsClassificazioneIndirizzo = "";
			rsClassificazioneIndirizzoDescrizione = "";
			rsClassificazioneCAP = "";
			rsClassificazioneLocalita = "";
			rsClassificazioneVia = "";
			rsClassificazioneCivico = "";
			rsConfigId = "";
			rsConfigIdDescrizione = "";
			rsIdRicerca = "";
			rsMess = "";
			List<LocateLocation> list = (List<LocateLocation>)_SessionVariable["ElencoLocalitaMappa"];
			if (list.Count <= 0 || grdElencoLocalitaMappa.SelectedIndex < 0)
			{
				goto IL_0277;
			}
			LocateLocation locateLocation = list[grdElencoLocalitaMappa.SelectedIndex];
			rsIndirizzo = locateLocation.Via;
			rsNumCivico = locateLocation.Civico;
			rsCap = locateLocation.Cap;
			rsLocalita = locateLocation.Localita;
			rsQuartiere = locateLocation.Localita2;
			rsNazione = locateLocation.Nazione;
			rsLatitudine = locateLocation.Latitudine;
			rsLongitudine = locateLocation.Longitudine;
			rsPunteggioTotale = locateLocation.PunteggioTotale;
			rsClassificazione = locateLocation.Classificazione;
			rsClassificazioneDescrizione = locateLocation.ClassificazioneDescrizione;
			rsLivelloDettaglio = locateLocation.LivelloDettaglio;
			rsLivelloDettaglioDescrizione = locateLocation.LivelloDettaglioDescrizione;
			rsClassificazioneIndirizzo = locateLocation.ClassificazioneIndirizzo;
			rsClassificazioneIndirizzoDescrizione = locateLocation.ClassificazioneIndirizzoDescrizione;
			rsClassificazioneCAP = locateLocation.ClassificazioneCAP;
			rsClassificazioneLocalita = locateLocation.ClassificazioneLocalita;
			rsClassificazioneVia = locateLocation.ClassificazioneVia;
			rsClassificazioneCivico = locateLocation.ClassificazioneCivico;
			rsConfigId = hdnConfigIdMappa.ObjValue.ToString();
			string text = "";
			text = "SELECT Descrizione ";
			text += "FROM TipiGeocodifica ";
			text = text + "WHERE Codice=" + base.DbConn.SQLFormatString(hdnConfigIdMappa.ObjValue.ToString());
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			val = base.DbConn.DoSql(text, ref objectValue, ref rsMess);
			if ((int)val <= 0)
			{
				rsConfigIdDescrizione = objectValue.ToString();
				rsIdRicerca = hdnIdRicercaMappa.ObjValue.ToString();
				goto IL_0277;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0277:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void InserisciValoriNormalizzati(string sIndirizzo, string sNumCivico, string sCap, string sLocalita, string sQuartiere, string sNazione, string sLatitudine, string sLongitudine, string sPunteggioTotale, string sClassificazione, string sClassificazioneDescrizione, string sLivelloDettaglio, string sLivelloDettaglioDescrizione, string sClassificazioneIndirizzo, string sClassificazioneIndirizzoDescrizione, string sClassificazioneCAP, string sClassificazioneLocalita, string sClassificazioneVia, string sClassificazioneCivico, string sConfigId, string sConfigIdDescrizione, string sIdRicerca)
	{
		txtIndirizzoNormalizzato.Text = sIndirizzo;
		txtNumeroCivicoNormalizzato.Text = sNumCivico;
		txtCapNormalizzato.Text = sCap;
		txtLocalitaNormalizzata.Text = sLocalita;
		txtQuartiereNormalizzato.Text = sQuartiere;
		txtNazioneNormalizzata.Text = sNazione;
		txtLatitudine.Text = sLatitudine;
		txtLongitudine.Text = sLongitudine;
		txtPunteggioTotale.Text = sPunteggioTotale;
		txtClassificazione.Text = sClassificazione;
		txtClassificazioneDescrizione.Text = sClassificazioneDescrizione;
		txtLivelloDettaglio.Text = sLivelloDettaglio;
		txtLivelloDettaglioDescrizione.Text = sLivelloDettaglioDescrizione;
		txtClassificazioneIndirizzo.Text = sClassificazioneIndirizzo;
		txtClassificazioneIndDescrizione.Text = sClassificazioneIndirizzoDescrizione;
		txtClassificazioneCAP.Text = sClassificazioneCAP;
		txtClassificazioneLocalita.Text = sClassificazioneLocalita;
		txtClassificazioneVia.Text = sClassificazioneVia;
		txtClassificazioneCivico.Text = sClassificazioneCivico;
		hdnConfigId.ObjValue = sConfigId;
		hdnIdRicerca.ObjValue = sIdRicerca;
		txtFormatoCoordinate.Text = "OG_GEODECIMAL";
	}

	private void btnGeocodificaPopup_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		LocateLocation locateLocation = new LocateLocation();
		try
		{
			locateLocation.Via = txtIndirizzoMappa.Text;
			locateLocation.Cap = txtCapMappa.Text;
			locateLocation.Localita = txtLocalitaMappa.Text;
			locateLocation.Nazione = txtNazioneMappa.Text;
			LocateManager locateManager = new LocateManager(CreateApiContext());
			locateManager.objLocation = locateLocation;
			val2 = ((AppAbstractApi)locateManager).Run(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			List<LocateLocation> locationsList = locateManager.LocationsList;
			((HiddenField)hdnConfigIdMappa).Value = locateManager.ConfigId;
			((HiddenField)hdnIdRicercaMappa).Value = locateManager.IdRicerca.ToString();
			_SessionVariable.Add("ElencoLocalitaMappa", locationsList);
			((BaseDataBoundControl)grdElencoLocalitaMappa).DataSource = locationsList;
			grdElencoLocalitaMappa.DataBind();
			grdElencoLocalitaMappa.SelectedIndex = -1;
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

	protected override FXRETURN PopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsIndirizzo = "";
		string rsNumCivico = "";
		string rsCap = "";
		string rsLocalita = "";
		string rsQuartiere = "";
		string text = "";
		string rsNazione = "";
		string rsLatitudine = "";
		string rsLongitudine = "";
		string rsPunteggioTotale = "";
		string rsClassificazione = "";
		string rsClassificazioneDescrizione = "";
		string rsLivelloDettaglio = "";
		string rsLivelloDettaglioDescrizione = "";
		string rsClassificazioneIndirizzo = "";
		string rsClassificazioneIndirizzoDescrizione = "";
		string rsClassificazioneCAP = "";
		string rsClassificazioneLocalita = "";
		string rsClassificazioneVia = "";
		string rsClassificazioneCivico = "";
		string rsConfigId = "";
		string rsConfigIdDescrizione = "";
		string rsIdRicerca = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			if (Operators.CompareString(objPopupInfo.Tag, "RICERCAXLOCATE", false) == 0)
			{
				val = recuperaRisultatoDaPopup(ref rsIndirizzo, ref rsNumCivico, ref rsCap, ref rsLocalita, ref rsQuartiere, ref rsNazione, ref rsLatitudine, ref rsLongitudine, ref rsPunteggioTotale, ref rsClassificazione, ref rsClassificazioneDescrizione, ref rsLivelloDettaglio, ref rsLivelloDettaglioDescrizione, ref rsClassificazioneIndirizzo, ref rsClassificazioneIndirizzoDescrizione, ref rsClassificazioneCAP, ref rsClassificazioneLocalita, ref rsClassificazioneVia, ref rsClassificazioneCivico, ref rsConfigId, ref rsConfigIdDescrizione, ref rsIdRicerca, ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				InserisciValoriNormalizzati(rsIndirizzo, rsNumCivico, rsCap, rsLocalita, rsQuartiere, rsNazione, rsLatitudine, rsLongitudine, rsPunteggioTotale, rsClassificazione, rsClassificazioneDescrizione, rsLivelloDettaglio, rsLivelloDettaglioDescrizione, rsClassificazioneIndirizzo, rsClassificazioneIndirizzoDescrizione, rsClassificazioneCAP, rsClassificazioneLocalita, rsClassificazioneVia, rsClassificazioneCivico, rsConfigId, rsConfigIdDescrizione, rsIdRicerca);
				string classificazioneCAP = rsClassificazioneCAP;
				string classificazioneLocalita = rsClassificazioneLocalita;
				string classificazioneVia = rsClassificazioneVia;
				string classificazioneCivico = rsClassificazioneCivico;
				IboWebTextBox val3;
				string ClassificazioneCAPDescrizione = (val3 = txtClassificazioneCAPDescrizione).Text;
				IboWebTextBox val4;
				string ClassificazioneLocalitaDescrizione = (val4 = txtClassificazioneLocalitaDescrizione).Text;
				IboWebTextBox val5;
				string ClassificazioneViaDescrizione = (val5 = txtClassificazioneViaDescrizione).Text;
				IboWebTextBox val6;
				string ClassificazioneCivicoDescrizione = (val6 = txtClassificazioneCivicoDescrizione).Text;
				FXRETURN descriptions = GetDescriptions(classificazioneCAP, classificazioneLocalita, classificazioneVia, classificazioneCivico, ref ClassificazioneCAPDescrizione, ref ClassificazioneLocalitaDescrizione, ref ClassificazioneViaDescrizione, ref ClassificazioneCivicoDescrizione, ref rsMess);
				val6.Text = ClassificazioneCivicoDescrizione;
				val5.Text = ClassificazioneViaDescrizione;
				val4.Text = ClassificazioneLocalitaDescrizione;
				val3.Text = ClassificazioneCAPDescrizione;
				val = descriptions;
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					HFLatitudine.Value = "";
					HFLongitudine.Value = "";
					txtIndirizzoRicerca.Text = txtIndirizzoMappa.Text;
					txtCapRicerca.Text = txtCapMappa.Text;
					txtLocalitaRicerca.Text = txtLocalitaMappa.Text;
					txtNazioneRicerca.Text = txtNazioneMappa.Text;
					val = base.PopupFormOkClick(ref objPopupInfo, ref rsMess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN PopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.PopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void grdElencoLocalitaMappa_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (grdElencoLocalitaMappa.SelectedIndex >= 0)
			{
				PopupForm_cmdOk_Click(RuntimeHelpers.GetObjectValue(sender), e);
				upIndNorm.Update();
				upRate.Update();
				UPPopupFormGlobalContainer.Update();
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
		}
	}

	private FXRETURN GetDescriptions(string ClassificazioneCAP, string ClassificazioneLocalita, string ClassificazioneVia, string ClassificazioneCivico, ref string ClassificazioneCAPDescrizione, ref string ClassificazioneLocalitaDescrizione, ref string ClassificazioneViaDescrizione, ref string ClassificazioneCivicoDescrizione, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			ClassificazioneCAPDescrizione = "";
			ClassificazioneLocalitaDescrizione = "";
			ClassificazioneViaDescrizione = "";
			ClassificazioneCivicoDescrizione = "";
			if (Versioned.IsNumeric((object)ClassificazioneCAP))
			{
				switch (Conversions.ToInteger(ClassificazioneCAP))
				{
				case 7:
					ClassificazioneCAPDescrizione = DescrizioneClassificazione.EXACT.ToString();
					break;
				case 6:
					ClassificazioneCAPDescrizione = "PARTIALLY EXACT";
					break;
				case 5:
					ClassificazioneCAPDescrizione = DescrizioneClassificazione.HIGH.ToString();
					break;
				case 4:
					ClassificazioneCAPDescrizione = DescrizioneClassificazione.MEDIUM.ToString();
					break;
				case 3:
					ClassificazioneCAPDescrizione = DescrizioneClassificazione.LOW.ToString();
					break;
				case 2:
					ClassificazioneCAPDescrizione = "NO INPUT";
					break;
				case 1:
					ClassificazioneCAPDescrizione = "NO RESULT";
					break;
				case 0:
					ClassificazioneCAPDescrizione = "NOT CLASSIFIED";
					break;
				case 9:
					ClassificazioneCAPDescrizione = "MANUAL POSITION";
					break;
				}
			}
			if (Versioned.IsNumeric((object)ClassificazioneLocalita))
			{
				switch (Conversions.ToInteger(ClassificazioneLocalita))
				{
				case 7:
					ClassificazioneLocalitaDescrizione = DescrizioneClassificazione.EXACT.ToString();
					break;
				case 6:
					ClassificazioneLocalitaDescrizione = "PARTIALLY EXACT";
					break;
				case 5:
					ClassificazioneLocalitaDescrizione = DescrizioneClassificazione.HIGH.ToString();
					break;
				case 4:
					ClassificazioneLocalitaDescrizione = DescrizioneClassificazione.MEDIUM.ToString();
					break;
				case 3:
					ClassificazioneLocalitaDescrizione = DescrizioneClassificazione.LOW.ToString();
					break;
				case 2:
					ClassificazioneLocalitaDescrizione = "NO INPUT";
					break;
				case 1:
					ClassificazioneLocalitaDescrizione = "NO RESULT";
					break;
				case 0:
					ClassificazioneLocalitaDescrizione = "NOT CLASSIFIED";
					break;
				case 9:
					ClassificazioneLocalitaDescrizione = "MANUAL POSITION";
					break;
				}
			}
			if (Versioned.IsNumeric((object)ClassificazioneVia))
			{
				switch (Conversions.ToInteger(ClassificazioneVia))
				{
				case 7:
					ClassificazioneViaDescrizione = DescrizioneClassificazione.EXACT.ToString();
					break;
				case 6:
					ClassificazioneViaDescrizione = "PARTIALLY EXACT";
					break;
				case 5:
					ClassificazioneViaDescrizione = DescrizioneClassificazione.HIGH.ToString();
					break;
				case 4:
					ClassificazioneViaDescrizione = DescrizioneClassificazione.MEDIUM.ToString();
					break;
				case 3:
					ClassificazioneViaDescrizione = DescrizioneClassificazione.LOW.ToString();
					break;
				case 2:
					ClassificazioneViaDescrizione = "NO INPUT";
					break;
				case 1:
					ClassificazioneViaDescrizione = "NO RESULT";
					break;
				case 0:
					ClassificazioneViaDescrizione = "NOT CLASSIFIED";
					break;
				case 9:
					ClassificazioneViaDescrizione = "MANUAL POSITION";
					break;
				}
			}
			if (Versioned.IsNumeric((object)ClassificazioneCivico))
			{
				switch (Conversions.ToInteger(ClassificazioneCivico))
				{
				case 7:
					ClassificazioneCivicoDescrizione = DescrizioneClassificazione.EXACT.ToString();
					break;
				case 6:
					ClassificazioneCivicoDescrizione = "PARTIALLY EXACT";
					break;
				case 5:
					ClassificazioneCivicoDescrizione = DescrizioneClassificazione.HIGH.ToString();
					break;
				case 4:
					ClassificazioneCivicoDescrizione = DescrizioneClassificazione.MEDIUM.ToString();
					break;
				case 3:
					ClassificazioneCivicoDescrizione = DescrizioneClassificazione.LOW.ToString();
					break;
				case 2:
					ClassificazioneCivicoDescrizione = "NO INPUT";
					break;
				case 1:
					ClassificazioneCivicoDescrizione = "NO RESULT";
					break;
				case 0:
					ClassificazioneCivicoDescrizione = "NOT CLASSIFIED";
					break;
				case 9:
					ClassificazioneCivicoDescrizione = "MANUAL POSITION";
					break;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN ReverseGeocoding(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Invalid comparison between Unknown and I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			string longitude = HFLongitudine.Value.ToString();
			string text = HFLatitudine.Value.ToString();
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_03e7;
			}
			ReverseGeocodingManager reverseGeocodingManager = new ReverseGeocodingManager(CreateApiContext());
			reverseGeocodingManager.Latitude = text;
			reverseGeocodingManager.Longitude = longitude;
			val2 = ((AppAbstractApi)reverseGeocodingManager).Run(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				List<LocateLocation> locationsList = reverseGeocodingManager.LocationsList;
				if (locationsList.Count <= 0)
				{
					goto IL_03d4;
				}
				LocateLocation locateLocation = locationsList[0];
				string text2 = "";
				text2 = "SELECT Descrizione ";
				text2 += "FROM TipiGeocodifica ";
				text2 = text2 + "WHERE Codice=" + base.DbConn.SQLFormatString(reverseGeocodingManager.ConfigId);
				object objectValue = RuntimeHelpers.GetObjectValue(new object());
				val2 = base.DbConn.DoSql(text2, ref objectValue, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					string sConfigIdDescrizione = objectValue.ToString();
					LocateLocation locateLocation2 = locateLocation;
					InserisciValoriNormalizzati(locateLocation2.Via, locateLocation2.Civico, locateLocation2.Cap, locateLocation2.Localita, locateLocation2.Localita2, locateLocation2.Nazione, locateLocation2.Latitudine, locateLocation2.Longitudine, locateLocation2.PunteggioTotale, locateLocation2.Classificazione, locateLocation2.ClassificazioneDescrizione, locateLocation2.LivelloDettaglio, locateLocation2.LivelloDettaglioDescrizione, locateLocation2.ClassificazioneIndirizzo, locateLocation2.ClassificazioneIndirizzoDescrizione, locateLocation2.ClassificazioneCAP, locateLocation2.ClassificazioneLocalita, locateLocation2.ClassificazioneVia, locateLocation2.ClassificazioneCivico, reverseGeocodingManager.ConfigId, sConfigIdDescrizione, reverseGeocodingManager.IdRicerca.ToString());
					if (Operators.CompareString(txtClassificazioneCAP.ObjValue.ToString(), "", false) == 0)
					{
						txtClassificazioneCAP.ObjValue = "9";
					}
					if (Operators.CompareString(txtClassificazioneLocalita.ObjValue.ToString(), "", false) == 0)
					{
						txtClassificazioneLocalita.ObjValue = "9";
					}
					if (Operators.CompareString(txtClassificazioneCivico.ObjValue.ToString(), "", false) == 0)
					{
						txtClassificazioneCivico.ObjValue = "9";
					}
					if (Operators.CompareString(txtClassificazioneIndirizzo.ObjValue.ToString(), "", false) == 0)
					{
						txtClassificazioneIndirizzo.ObjValue = "9";
					}
					if (Operators.CompareString(txtClassificazioneVia.ObjValue.ToString(), "", false) == 0)
					{
						txtClassificazioneVia.ObjValue = "9";
					}
					txtClassificazione.Text = "9";
					txtClassificazioneDescrizione.Text = "MANUAL POSITION";
					txtPunteggioTotale.ObjValue = "100";
					string? classificazioneCAP = txtClassificazioneCAP.ObjValue.ToString();
					string? classificazioneLocalita = txtClassificazioneLocalita.ObjValue.ToString();
					string? classificazioneVia = txtClassificazioneVia.ObjValue.ToString();
					string? classificazioneCivico = txtClassificazioneCivico.ObjValue.ToString();
					IboWebTextBox val3;
					string ClassificazioneCAPDescrizione = (val3 = txtClassificazioneCAPDescrizione).Text;
					IboWebTextBox val4;
					string ClassificazioneLocalitaDescrizione = (val4 = txtClassificazioneLocalitaDescrizione).Text;
					IboWebTextBox val5;
					string ClassificazioneViaDescrizione = (val5 = txtClassificazioneViaDescrizione).Text;
					IboWebTextBox val6;
					string ClassificazioneCivicoDescrizione = (val6 = txtClassificazioneCivicoDescrizione).Text;
					FXRETURN descriptions = GetDescriptions(classificazioneCAP, classificazioneLocalita, classificazioneVia, classificazioneCivico, ref ClassificazioneCAPDescrizione, ref ClassificazioneLocalitaDescrizione, ref ClassificazioneViaDescrizione, ref ClassificazioneCivicoDescrizione, ref rsMess);
					val6.Text = ClassificazioneCivicoDescrizione;
					val5.Text = ClassificazioneViaDescrizione;
					val4.Text = ClassificazioneLocalitaDescrizione;
					val3.Text = ClassificazioneCAPDescrizione;
					val2 = descriptions;
					if ((int)val2 <= 0)
					{
						locateLocation2 = null;
						goto IL_03d4;
					}
					val = val2;
				}
			}
			goto end_IL_0005;
			IL_03e7:
			val = (FXRETURN)0;
			goto end_IL_0005;
			IL_03d4:
			HFReverseGeocodingNeeded.Value = "N";
			goto IL_03e7;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}
}
