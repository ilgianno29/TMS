using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Locate;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCAutistiAttivitaGiorno : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RepeaterAttivita")]
	private Repeater _RepeaterAttivita;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGeocodificaInizio")]
	private IboWebButton _btnGeocodificaInizio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGeocodificaPopup")]
	private IboWebButton _btnGeocodificaPopup;

	private DataTable _dtAttivita;

	private List<AutistaAttivita> _ElencoAttivita;

	private StringCollection _ElencoAttivitaEliminate;

	private string AttivitaSosta;

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

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista")]
	protected virtual IboWebLabel lblAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAutista")]
	protected virtual IboWebTextBox txtAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AutistaDescrizione")]
	protected virtual IboWebTextBox AutistaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblData")]
	protected virtual IboWebLabel lblData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataStringa")]
	protected virtual IboWebTextBox txtDataStringa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtData")]
	protected virtual IboWebTextBox txtData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMotrice")]
	protected virtual IboWebLabel lblMotrice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMotrice")]
	protected virtual IboWebTextBox txtMotrice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MotriceDescrizione")]
	protected virtual IboWebTextBox MotriceDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRimorchio")]
	protected virtual IboWebLabel lblRimorchio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRimorchio1")]
	protected virtual IboWebTextBox txtRimorchio1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RimorchioDescrizione")]
	protected virtual IboWebTextBox RimorchioDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPartenza_Title")]
	protected virtual Panel cpPartenza_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPartenza_Title_Caption")]
	protected virtual Label cpPartenza_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpPartenza_Body")]
	protected virtual Panel cpPartenza_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzoInizio")]
	protected virtual IboWebLabel lblIndirizzoInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LocalitaInizio")]
	protected virtual IboWebTextBox LocalitaInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProvinciaInizio")]
	protected virtual IboWebTextBox ProvinciaInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmInizio")]
	protected virtual IboWebLabel lblKmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KmInizio")]
	protected virtual IboWebTextBox KmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataInizio")]
	protected virtual IboWebLabel lblDataInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataInizio")]
	protected virtual IboWebTextBox DataInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataInizio2")]
	protected virtual IboWebDate2 DataInizio2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAttivita_Title")]
	protected virtual Panel cpAttivita_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAttivita_Title_Caption")]
	protected virtual Label cpAttivita_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpAttivita_Body")]
	protected virtual Panel cpAttivita_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoAttivitaRA")]
	protected virtual IboWebLabel lblTipoAttivitaRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLocalitaInizioRA")]
	protected virtual IboWebLabel lblLocalitaInizioRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProvinciaInizioRA")]
	protected virtual IboWebLabel lblProvinciaInizioRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataInizioRA")]
	protected virtual IboWebLabel lblDataInizioRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmInizioRA")]
	protected virtual IboWebLabel lblKmInizioRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLocalitaFineRA")]
	protected virtual IboWebLabel lblLocalitaFineRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblProvinciaFineRA")]
	protected virtual IboWebLabel lblProvinciaFineRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFineRA")]
	protected virtual IboWebLabel lblDataFineRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmFineRA")]
	protected virtual IboWebLabel lblKmFineRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRagioneSocialeRA")]
	protected virtual IboWebLabel lblRagioneSocialeRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineRA")]
	protected virtual IboWebLabel lblNumeroOrdineRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantitaRA")]
	protected virtual IboWebLabel lblQuantitaRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmTotRA")]
	protected virtual IboWebLabel lblKmTotRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTempoTotRA")]
	protected virtual IboWebLabel lblTempoTotRA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater RepeaterAttivita
	{
		[CompilerGenerated]
		get
		{
			return _RepeaterAttivita;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(RepeaterAttivita_ItemDataBound);
			RepeaterCommandEventHandler val2 = new RepeaterCommandEventHandler(RepeaterAttivita_ItemCommand);
			Repeater repeaterAttivita = _RepeaterAttivita;
			if (repeaterAttivita != null)
			{
				repeaterAttivita.ItemDataBound -= val;
				repeaterAttivita.ItemCommand -= val2;
			}
			_RepeaterAttivita = value;
			repeaterAttivita = _RepeaterAttivita;
			if (repeaterAttivita != null)
			{
				repeaterAttivita.ItemDataBound += val;
				repeaterAttivita.ItemCommand += val2;
			}
		}
	}

	[field: AccessedThroughProperty("cpArrivo_Title")]
	protected virtual Panel cpArrivo_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpArrivo_Title_Caption")]
	protected virtual Label cpArrivo_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpArrivo_Body")]
	protected virtual Panel cpArrivo_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIndirizzoFine")]
	protected virtual IboWebLabel lblIndirizzoFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LocalitaFine")]
	protected virtual IboWebTextBox LocalitaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProvinciaFine")]
	protected virtual IboWebTextBox ProvinciaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmFine")]
	protected virtual IboWebLabel lblKmFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KmFine")]
	protected virtual IboWebTextBox KmFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFine")]
	protected virtual IboWebLabel lblDataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataFine")]
	protected virtual IboWebTextBox DataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataFine2")]
	protected virtual IboWebDate2 DataFine2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTotali_Title")]
	protected virtual Panel cpTotali_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTotali_Title_Caption")]
	protected virtual Label cpTotali_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTotali_Body")]
	protected virtual Panel cpTotali_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTempoTotaleGG")]
	protected virtual IboWebLabel lblTempoTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TempoTotaleGG")]
	protected virtual IboWebTextBox TempoTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblKmTotaleGG")]
	protected virtual IboWebLabel lblKmTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KmTotaleGG")]
	protected virtual IboWebNumericTlk KmTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCarichiScarichiTotaleGG")]
	protected virtual IboWebLabel lblCarichiScarichiTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CarichiScarichiTotaleGG")]
	protected virtual IboWebNumericTlk CarichiScarichiTotaleGG
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlModificaAttivita")]
	protected virtual Panel pnlModificaAttivita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaTipoAttivita")]
	protected virtual IboWebLabel lblNuovaTipoAttivita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaTipoAttivita")]
	protected virtual IboWebLabel NuovaTipoAttivita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaDatainizio")]
	protected virtual IboWebLabel lblNuovaDatainizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaDatainizio")]
	protected virtual IboWebDate2 NuovaDatainizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaKmInizio")]
	protected virtual IboWebLabel lblNuovaKmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaKmInizio")]
	protected virtual IboWebNumericTlk NuovaKmInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaDataFine")]
	protected virtual IboWebLabel lblNuovaDataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaDataFine")]
	protected virtual IboWebDate2 NuovaDataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaKmFine")]
	protected virtual IboWebLabel lblNuovaKmFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaKmFine")]
	protected virtual IboWebNumericTlk NuovaKmFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaLocalitaInizio")]
	protected virtual IboWebLabel lblNuovaLocalitaInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaLocalitaInizio")]
	protected virtual IboWebTextBox NuovaLocalitaInizio
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

	protected virtual IboWebButton btnGeocodificaInizio
	{
		[CompilerGenerated]
		get
		{
			return _btnGeocodificaInizio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGeocodificaInizio_Click;
			IboWebButton val = _btnGeocodificaInizio;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGeocodificaInizio = value;
			val = _btnGeocodificaInizio;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("NuovaCapInizio")]
	protected virtual IboWebTextBox NuovaCapInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaProvinciaInizio")]
	protected virtual IboWebTextBox NuovaProvinciaInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaIndirizzoInizio")]
	protected virtual IboWebTextBox NuovaIndirizzoInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaNazioneInizio")]
	protected virtual IboWebTextBox NuovaNazioneInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNuovaLocalitaFine")]
	protected virtual IboWebLabel lblNuovaLocalitaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaLocalitaFine")]
	protected virtual IboWebTextBox NuovaLocalitaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UpdatePanel1")]
	protected virtual UpdatePanel UpdatePanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnGeocodificaFine")]
	protected virtual IboWebButton btnGeocodificaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaCapFine")]
	protected virtual IboWebTextBox NuovaCapFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaProvinciaFine")]
	protected virtual IboWebTextBox NuovaProvinciaFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaIndirizzoFine")]
	protected virtual IboWebTextBox NuovaIndirizzoFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NuovaNazioneFine")]
	protected virtual IboWebTextBox NuovaNazioneFine
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

	[field: AccessedThroughProperty("grdElencoLocalitaMappa")]
	protected virtual GridView grdElencoLocalitaMappa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFDOCAutistiAttivitaGiorno()
	{
		_dtAttivita = null;
		_ElencoAttivita = null;
		_ElencoAttivitaEliminate = null;
		AttivitaSosta = "005";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.AUTISTI.ATTIVITA#GG";
		_Title = base.Translator.Translate("XXX", "Attività Giornaliera Autista", new string[0]);
		if (!_SessionVariable.ContainsKey("ElencoAttivita"))
		{
			_ElencoAttivita = new List<AutistaAttivita>();
			_ElencoAttivitaEliminate = new StringCollection();
			_SessionVariable["ElencoAttivita"] = (object)_ElencoAttivita;
			_SessionVariable["ElencoAttivitaEliminate"] = (object)_ElencoAttivitaEliminate;
		}
		else
		{
			_ElencoAttivita = (List<AutistaAttivita>)_SessionVariable["ElencoAttivita"];
			_ElencoAttivitaEliminate = (StringCollection)_SessionVariable["ElencoAttivitaEliminate"];
		}
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
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
				if (_ElencoAttivita.Count != 0)
				{
					goto IL_005b;
				}
				val2 = CaricamentoAttivita(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_005b;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_005b:
			RepeaterDataRebind();
			val2 = AggiornaTotali_PartenzaArrrivo(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			end_IL_000b:;
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Invalid comparison between Unknown and I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!_SessionVariable.ContainsKey("FORZATURA"))
			{
				goto IL_0641;
			}
			checked
			{
				if (_ElencoAttivitaEliminate.Count > 0)
				{
					text = "DELETE FROM AUTISTI_ATTIVITA WHERE ID IN (";
					int num2 = _ElencoAttivitaEliminate.Count - 1;
					for (num = 0; num <= num2; num++)
					{
						if (num < _ElencoAttivitaEliminate.Count - 1)
						{
							string text2 = text;
							DBConnection dbConn = base.DbConn;
							StringCollection elencoAttivitaEliminate;
							int index;
							string value = (elencoAttivitaEliminate = _ElencoAttivitaEliminate)[index = num];
							string text3 = dbConn.SQLFormatNumber(ref value);
							elencoAttivitaEliminate[index] = value;
							text = text2 + text3 + ",";
						}
						else
						{
							string text4 = text;
							DBConnection dbConn2 = base.DbConn;
							StringCollection elencoAttivitaEliminate;
							int index;
							string value = (elencoAttivitaEliminate = _ElencoAttivitaEliminate)[index = num];
							string text5 = dbConn2.SQLFormatNumber(ref value);
							elencoAttivitaEliminate[index] = value;
							text = text4 + text5 + ");";
						}
					}
					stringBuilder.Append(text);
				}
				foreach (AutistaAttivita elencoAttivitum in _ElencoAttivita)
				{
					if (!Information.IsNothing((object)elencoAttivitum.Id))
					{
						text = "UPDATE AUTISTI_ATTIVITA SET ";
						text = text + "DATAINIZIO = " + base.DbConn.SQLFormatDate((eTipoData)2, elencoAttivitum.DataInizio) + ",";
						text = text + "DATAFINE = " + base.DbConn.SQLFormatDate((eTipoData)2, elencoAttivitum.DataFine) + ",";
						text = text + "KMINIZIO = " + base.DbConn.SQLFormatNumber(ref elencoAttivitum.KmInizio) + ",";
						text = text + "KMFINE = " + base.DbConn.SQLFormatNumber(ref elencoAttivitum.KmFine) + ",";
						text = text + "TIPOATTIVITA = " + base.DbConn.SQLFormatString(elencoAttivitum.Tipo) + ",";
						text = text + "LOCALITAINIZIO = " + base.DbConn.SQLFormatString(elencoAttivitum.LocalitaInizio) + ",";
						text = text + "INDIRIZZOINIZIO = " + base.DbConn.SQLFormatString(elencoAttivitum.IndirizzoInizio) + ",";
						text = text + "CAPINIZIO = " + base.DbConn.SQLFormatString(elencoAttivitum.CapInizio) + ",";
						text = text + "NAZIONEINIZIO = " + base.DbConn.SQLFormatString(elencoAttivitum.NazioneInizio) + ",";
						text = text + "LOCALITAFINE = " + base.DbConn.SQLFormatString(elencoAttivitum.LocalitaFine) + ",";
						text = text + "INDIRIZZOFINE = " + base.DbConn.SQLFormatString(elencoAttivitum.IndirizzoFine) + ",";
						text = text + "CAPFINE = " + base.DbConn.SQLFormatString(elencoAttivitum.CapFine) + ",";
						text = text + "NAZIONEFINE = " + base.DbConn.SQLFormatString(elencoAttivitum.NazioneFine) + ",";
						text = text + "UTEAGG = " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
						text = text + "DATAGG = " + base.DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + ",";
						text = text + "UTENTEFORZATURA = " + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
						text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref elencoAttivitum.Id) + ";";
					}
					else
					{
						text = "INSERT INTO AUTISTI_ATTIVITA (Autista, TipoAttivita,  DataInizio, DataFine, KmInizio, KmFine, ";
						text += "LocalitaInizio, IndirizzoInizio,CapInizio, NazioneInizio, LocalitaFine, IndirizzoFine, CapFine, NazioneFine,";
						text += "Motrice, Rimorchio1) VALUES (";
						text = text + base.DbConn.SQLFormatString(txtAutista.ObjValue.ToString()) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.Tipo) + ",";
						text = text + base.DbConn.SQLFormatDate((eTipoData)2, elencoAttivitum.DataInizio) + ",";
						text = text + base.DbConn.SQLFormatDate((eTipoData)2, elencoAttivitum.DataFine) + ",";
						text = text + base.DbConn.SQLFormatNumber(ref elencoAttivitum.KmInizio) + ",";
						text = text + base.DbConn.SQLFormatNumber(ref elencoAttivitum.KmFine) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.LocalitaInizio) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.IndirizzoInizio) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.CapInizio) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.NazioneInizio) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.LocalitaFine) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.IndirizzoFine) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.CapFine) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.NazioneFine) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.Motrice) + ",";
						text = text + base.DbConn.SQLFormatString(elencoAttivitum.Rimorchio) + ");";
					}
					stringBuilder.Append(text);
				}
				if (Operators.CompareString(stringBuilder.ToString(), "", false) == 0)
				{
					goto IL_0641;
				}
				val2 = base.DbConn.SqlExec(stringBuilder.ToString(), ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_0641;
			}
			val = val2;
			goto end_IL_0015;
			IL_0641:
			val = (FXRETURN)0;
			end_IL_0015:;
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

	private void btnGeocodificaInizio_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		LocateLocation locateLocation = new LocateLocation();
		try
		{
			if ((Operators.CompareString(NuovaLocalitaInizio.Text, "", false) == 0) & (Operators.CompareString(NuovaCapInizio.Text, "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Valorizzare il Cap o la località");
				return;
			}
			locateLocation.Via = NuovaIndirizzoInizio.Text;
			locateLocation.Cap = NuovaCapInizio.Text;
			locateLocation.Localita = NuovaLocalitaInizio.Text;
			locateLocation.Nazione = NuovaNazioneInizio.Text;
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
			((HiddenField)hdnConfigIdMappa).Value = locateManager.ConfigId;
			((HiddenField)hdnIdRicercaMappa).Value = locateManager.IdRicerca.ToString();
			((BaseDataBoundControl)grdElencoLocalitaMappa).DataSource = locationsList;
			grdElencoLocalitaMappa.DataBind();
			grdElencoLocalitaMappa.SelectedIndex = -1;
			txtIndirizzoMappa.Text = NuovaIndirizzoInizio.Text;
			txtCapMappa.Text = NuovaCapInizio.Text;
			txtLocalitaMappa.Text = NuovaLocalitaInizio.Text;
			txtNazioneMappa.Text = NuovaNazioneInizio.Text;
			SetIncasFocusToControl((Control)(object)txtIndirizzoMappa);
			MasterPopupFormOpen("Elenco Localita trovate", (Control)(object)ElencoLocalitaMappa, ButtonsVisible: true, ButtonsOkVisible: false, ButtonsAnnullaVisible: true, "RICERCAXLOCATEINIZIO");
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

	private void btnGeocodificaPopup_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		LocateLocation locateLocation = new LocateLocation();
		try
		{
			if ((Operators.CompareString(NuovaLocalitaFine.Text, "", false) == 0) & (Operators.CompareString(NuovaCapFine.Text, "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Valorizzare il Cap o la località");
				return;
			}
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
			txtIndirizzoMappa.Text = NuovaIndirizzoFine.Text;
			txtCapMappa.Text = NuovaCapFine.Text;
			txtLocalitaMappa.Text = NuovaLocalitaFine.Text;
			txtNazioneMappa.Text = NuovaNazioneFine.Text;
			SetIncasFocusToControl((Control)(object)txtIndirizzoMappa);
			MasterPopupFormOpen("Elenco Localita trovate", (Control)(object)ElencoLocalitaMappa, ButtonsVisible: true, ButtonsOkVisible: false, ButtonsAnnullaVisible: true, "RICERCAXLOCATEFINE");
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

	private FXRETURN CaricamentoAttivita(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		AutistaAttivita autistaAttivita = null;
		string text2 = "";
		string text3 = "";
		int num = 0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text += "SELECT A.ID,A.MOTRICE,A.RIMORCHIO1,T.CODICE AS TIPO,T.DESCRIZIONE AS ATTIVITADESCRIZIONE, ";
			text += "A.DATAINIZIO, A.KMINIZIO, A.LOCALITAINIZIO,A.INDIRIZZOINIZIO,A.CAPINIZIO,A.PROVINCIAINIZIO, A.NAZIONEINIZIO, ";
			text += "A.DATAFINE, A.KMFINE, A.LOCALITAFINE,A.INDIRIZZOFINE,A.CAPFINE,A.PROVINCIAFINE, A.NAZIONEFINE,    ";
			text += "IV.DESCRIZIONE AS CAUSALEFINEATTIVITA, ";
			text += "S.UNIBOL,S.NUMEROORDINE,S.NUMEROBOLLA, ";
			text += "CASE WHEN S.TIPOSERVIZIO = 'C' THEN S.PCSDestinazione_RagSoc WHEN S.TIPOSERVIZIO = 'S' THEN S.PCSDestinazione_RagSoc ";
			text += "WHEN VS.ID IS NOT NULL THEN VTS.DESCRIZIONE ELSE '' END AS RAGIONESOCIALEPCS,";
			text += "CASE WHEN S.TIPOSERVIZIO = 'C' THEN S.PCSDestinazione_Localita WHEN S.TIPOSERVIZIO = 'S' THEN S.PCSDestinazione_Localita ELSE '' END AS LOCALITAPCS, ";
			text += "CASE WHEN S.UNIBOL IS NOT NULL THEN S.FILLERALFA10 ELSE VS.VALORE5 END AS QUANTITA ";
			text += "FROM AUTISTI_ATTIVITA A ";
			text += "INNER JOIN AUTISTI_TIPIATTIVITA T ON A.TIPOATTIVITA = T.CODICE ";
			text += "LEFT JOIN TSE_CausaliInterruzioneViaggio IV ON A.CAUSALEFINEATTIVITA = IV.CODICE ";
			text += "LEFT JOIN SPEDIZIONI S ON S.UNIBOL = A.UNIBOL ";
			text += "LEFT JOIN VIAGGI_SERVIZI VS ON VS.ID = A.IDSERVIZIO ";
			text += "LEFT JOIN VIAGGI_TIPISERVIZI VTS ON VS.TIPOSERVIZIO = VTS.CODICE ";
			text = text + "WHERE AUTISTA = " + base.DbConn.SQLFormatString(txtAutista.ObjValue.ToString()) + " ";
			text = text + "AND DBO.TRUNC(DATAINIZIO) = " + base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(txtData.ObjValue)) + " ";
			text += "ORDER BY DATAINIZIO ";
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				checked
				{
					int num2 = dataTable.Rows.Count - 1;
					for (num = 0; num <= num2; num++)
					{
						DataRow dataRow = dataTable.Rows[num];
						autistaAttivita = new AutistaAttivita();
						AutistaAttivita autistaAttivita2 = autistaAttivita;
						autistaAttivita2.Id = dataRow["ID"].ToString();
						autistaAttivita2.Tipo = dataRow["TIPO"].ToString();
						autistaAttivita2.TipoDescrizione = dataRow["ATTIVITADESCRIZIONE"].ToString();
						if (Operators.CompareString(autistaAttivita2.Tipo, AttivitaSosta, false) != 0)
						{
							autistaAttivita2.DataInizio = Conversions.ToDate(dataRow["DATAINIZIO"]);
							autistaAttivita2.KmInizio = dataRow["KMINIZIO"].ToString();
							autistaAttivita2.LocalitaInizio = dataRow["LOCALITAINIZIO"].ToString();
							autistaAttivita2.IndirizzoInizio = dataRow["INDIRIZZOINIZIO"].ToString();
							autistaAttivita2.CapInizio = dataRow["CAPINIZIO"].ToString();
							autistaAttivita2.ProvinciaInizio = dataRow["PROVINCIAINIZIO"].ToString();
							autistaAttivita2.NazioneInizio = dataRow["NAZIONEINIZIO"].ToString();
							if (Information.IsDate(RuntimeHelpers.GetObjectValue(dataRow["DATAFINE"])))
							{
								autistaAttivita2.DataFine = Conversions.ToDate(dataRow["DATAFINE"]);
							}
							autistaAttivita2.KmFine = dataRow["KMFINE"].ToString();
							autistaAttivita2.LocalitaFine = dataRow["LOCALITAFINE"].ToString();
							autistaAttivita2.IndirizzoFine = dataRow["INDIRIZZOFINE"].ToString();
							autistaAttivita2.CapFine = dataRow["CAPFINE"].ToString();
							autistaAttivita2.ProvinciaFine = dataRow["PROVINCIAFINE"].ToString();
							autistaAttivita2.NazioneFine = dataRow["NAZIONEFINE"].ToString();
							autistaAttivita2.Unibol = dataRow["UNIBOL"].ToString();
							autistaAttivita2.NumeroOrdine = dataRow["NUMEROORDINE"].ToString();
							autistaAttivita2.NumeroBolla = dataRow["NUMEROBOLLA"].ToString();
							autistaAttivita2.Quantita = dataRow["QUANTITA"].ToString();
							autistaAttivita2.RagioneSocialePCS = dataRow["RAGIONESOCIALEPCS"].ToString();
							autistaAttivita2.LocalitaPCS = dataRow["LOCALITAPCS"].ToString();
							autistaAttivita2.Motrice = dataRow["MOTRICE"].ToString();
							autistaAttivita2.Rimorchio = dataRow["RIMORCHIO1"].ToString();
							if (Operators.CompareString(text2, "", false) != 0)
							{
								autistaAttivita2.MotricePrecedente = text2;
							}
							else
							{
								autistaAttivita2.MotricePrecedente = dataRow["MOTRICE"].ToString();
							}
							text2 = dataRow["MOTRICE"].ToString();
							if (Operators.CompareString(text3, "", false) != 0)
							{
								autistaAttivita2.RimorchioPrecedente = text3;
							}
							else
							{
								autistaAttivita2.RimorchioPrecedente = dataRow["RIMORCHIO1"].ToString();
							}
							text3 = dataRow["RIMORCHIO1"].ToString();
						}
						else
						{
							autistaAttivita2.CausaleFineAttivita = dataRow["CAUSALEFINEATTIVITA"].ToString();
						}
						if (num == 0)
						{
							autistaAttivita2.ConsentiModifica = "S";
						}
						else if (num == dataTable.Rows.Count - 2)
						{
							if (Operators.CompareString(dataTable.Rows[num + 1]["TIPO"].ToString(), AttivitaSosta, false) == 0)
							{
								autistaAttivita2.ConsentiModifica = "S";
							}
						}
						else if ((num == dataTable.Rows.Count - 1) & (Operators.CompareString(dataTable.Rows[num]["TIPO"].ToString(), AttivitaSosta, false) != 0))
						{
							autistaAttivita2.ConsentiModifica = "S";
						}
						else
						{
							autistaAttivita2.ConsentiModifica = "N";
						}
						autistaAttivita2 = null;
						_ElencoAttivita.Add(autistaAttivita);
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

	private void RepeaterAttivita_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Invalid comparison between Unknown and I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = "";
			int num = 0;
			string text2 = "";
			string text3 = "";
			string text4 = "";
			AutistaAttivita autistaAttivita = (AutistaAttivita)e.Item.DataItem;
			((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TipoAttivita")).ObjValue = autistaAttivita.TipoDescrizione;
			if (Operators.CompareString(autistaAttivita.ConsentiModifica, "S", false) == 0)
			{
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "btnModificaAttivita")).Visible = true;
			}
			else
			{
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "btnModificaAttivita")).Visible = false;
			}
			if (Operators.CompareString(autistaAttivita.Tipo.ToString(), AttivitaSosta, false) != 0)
			{
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "DataInizio")).ObjValue = autistaAttivita.DataInizio;
				text2 = autistaAttivita.LocalitaInizio;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "LocalitaInizio")).ObjValue = text2;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "ProvinciaInizio")).ObjValue = autistaAttivita.ProvinciaInizio;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "KmInizio")).ObjValue = Conversions.ToDecimal(autistaAttivita.KmInizio);
				if (Information.IsDate((object)autistaAttivita.DataFine))
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "DataFine")).ObjValue = autistaAttivita.DataFine.Value;
					num = checked((int)DateAndTime.DateDiff((DateInterval)8, Conversions.ToDate(Strings.Format((object)autistaAttivita.DataInizio, "dd/MM/yyyy HH:mm")), Conversions.ToDate(Strings.Format((object)autistaAttivita.DataFine, "dd/MM/yyyy HH:mm")), (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1));
					text = ConvertMinute(num);
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TempoTot")).ObjValue = text;
				}
				else
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "DataFine")).ObjValue = "";
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "TempoTot")).ObjValue = "";
				}
				text3 = autistaAttivita.LocalitaFine;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "LocalitaFine")).ObjValue = text3;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "ProvinciaFine")).ObjValue = autistaAttivita.ProvinciaFine;
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "RagioneSociale")).ObjValue = autistaAttivita.RagioneSocialePCS;
				if (Operators.CompareString(autistaAttivita.NumeroBolla, "", false) != 0)
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "NumeroOrdine")).ObjValue = autistaAttivita.NumeroBolla;
				}
				else
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "NumeroOrdine")).ObjValue = autistaAttivita.NumeroOrdine;
				}
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "Quantita")).ObjValue = autistaAttivita.Quantita;
				if (Versioned.IsNumeric((object)autistaAttivita.KmFine))
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "KmFine")).ObjValue = Conversions.ToDecimal(autistaAttivita.KmFine);
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "KmTot")).ObjValue = decimal.Subtract(Conversions.ToDecimal(autistaAttivita.KmFine), Conversions.ToDecimal(autistaAttivita.KmInizio));
				}
				else
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "KmFine")).ObjValue = "";
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "KmTot")).ObjValue = "";
				}
				if (Operators.CompareString(autistaAttivita.Motrice, autistaAttivita.MotricePrecedente, false) != 0)
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "CambioMotrice")).ObjValue = autistaAttivita.Motrice;
					string text5 = "";
					object obj = null;
					text5 = "SELECT CODICE + ' - ' + TARGA + '  (' + Descrizione + ')' FROM Mezzi WHERE CODICE= " + base.DbConn.SQLFormatString(autistaAttivita.Motrice);
					DBConnection dbConn = base.DbConn;
					string text6 = text5;
					string text7 = "";
					if ((int)dbConn.DoSql(text6, (object)"", ref obj, ref text7) <= 0 && Operators.CompareString(Conversions.ToString(obj), "", false) != 0)
					{
						((IIboWebComponent)GetControlByName((Control)(object)e.Item, "CambioMotriceDescrizione")).ObjValue = TranslateMessage("XXX", "CAMBIO MOTRICE: {0}", Conversions.ToString(obj));
						((IIboWebComponent)GetControlByName((Control)(object)e.Item, "CambioMotriceDescrizione")).Visible = true;
					}
				}
				else
				{
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "CambioMotriceDescrizione")).Visible = false;
					((IIboWebComponent)GetControlByName((Control)(object)e.Item, "CambioMotrice")).ObjValue = "";
				}
			}
			else
			{
				((IIboWebComponent)GetControlByName((Control)(object)e.Item, "LocalitaInizio")).ObjValue = autistaAttivita.CausaleFineAttivita;
			}
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
		RepeaterAttivita.DataSource = _ElencoAttivita;
		RepeaterAttivita.DataBind();
	}

	protected void RepeaterAttivita_ItemCommand(object source, RepeaterCommandEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		string rsMess = "";
		try
		{
			autistaAttivita = _ElencoAttivita.ElementAt(e.Item.ItemIndex);
			text = ((Control)(IboWebButton)e.CommandSource).ID;
			if (Operators.CompareString(text, "btnModificaAttivita", false) == 0)
			{
				val2 = ApriInterfacciaModificaAttivita(e.Item.ItemIndex, ref rsMess);
			}
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
		}
	}

	private FXRETURN AggiornaTotali_PartenzaArrrivo(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				foreach (AutistaAttivita elencoAttivitum in _ElencoAttivita)
				{
					if (Information.IsDate((object)elencoAttivitum.DataFine))
					{
						num8 = (int)DateAndTime.DateDiff((DateInterval)8, elencoAttivitum.DataInizio, elencoAttivitum.DataFine.Value, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1);
						switch (elencoAttivitum.Tipo)
						{
						case "001":
							num += num8;
							break;
						case "002":
							num2 += num8;
							break;
						case "003":
							num3 += num8;
							num9++;
							break;
						case "004":
							num4 += num8;
							num9++;
							break;
						case "006":
							num5 += num8;
							break;
						}
						if (Versioned.IsNumeric((object)elencoAttivitum.KmInizio) & Versioned.IsNumeric((object)elencoAttivitum.KmFine))
						{
							num6 += Conversions.ToInteger(elencoAttivitum.KmFine) - Conversions.ToInteger(elencoAttivitum.KmInizio);
						}
					}
				}
				LocalitaInizio.ObjValue = _ElencoAttivita[0].LocalitaInizio;
				ProvinciaInizio.ObjValue = _ElencoAttivita[0].ProvinciaInizio;
				KmInizio.ObjValue = Conversions.ToInteger(_ElencoAttivita[0].KmInizio);
				DataInizio.ObjValue = _ElencoAttivita[0].DataInizio;
				DataInizio2.ObjValue = _ElencoAttivita[0].DataInizio;
				num7 = (Versioned.IsNumeric((object)_ElencoAttivita[_ElencoAttivita.Count - 1].KmFine) ? (_ElencoAttivita.Count - 1) : ((_ElencoAttivita.Count > 1) ? (_ElencoAttivita.Count - 2) : 0));
				LocalitaFine.ObjValue = _ElencoAttivita[num7].LocalitaFine;
				ProvinciaFine.ObjValue = _ElencoAttivita[num7].ProvinciaFine;
				if (Versioned.IsNumeric((object)_ElencoAttivita[num7].KmFine))
				{
					KmFine.ObjValue = Conversions.ToInteger(_ElencoAttivita[num7].KmFine);
					DataFine.ObjValue = _ElencoAttivita[num7].DataFine;
					DataFine2.ObjValue = _ElencoAttivita[num7].DataFine;
					num8 = (int)DateAndTime.DateDiff((DateInterval)8, DataInizio2.getDateValue, DataFine2.getDateValue, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1);
					TempoTotaleGG.ObjValue = ConvertMinute(num8);
					KmTotaleGG.ObjValue = Conversions.ToInteger(KmFine.ObjValue) - Conversions.ToInteger(KmInizio.ObjValue);
				}
				CarichiScarichiTotaleGG.ObjValue = num9;
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
				CallStackRemove();
			}
			return result;
		}
	}

	private string ConvertMinute(int minuti)
	{
		string text = "";
		string result;
		try
		{
			text = (minuti / 60).ToString().PadLeft(2, '0') + ":" + (minuti % 60).ToString().PadLeft(2, '0');
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	private FXRETURN ApriInterfacciaModificaAttivita(int indice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_SessionVariable["ATTIVITA"] = (object)indice;
			autistaAttivita = _ElencoAttivita.ElementAt(indice);
			NuovaTipoAttivita.ObjValue = autistaAttivita.TipoDescrizione;
			NuovaDatainizio.ObjValue = autistaAttivita.DataInizio;
			NuovaDataFine.ObjValue = autistaAttivita.DataFine;
			NuovaKmInizio.ObjValue = autistaAttivita.KmInizio;
			NuovaKmFine.ObjValue = autistaAttivita.KmFine;
			NuovaLocalitaInizio.ObjValue = autistaAttivita.LocalitaInizio;
			NuovaCapInizio.ObjValue = autistaAttivita.CapInizio;
			NuovaProvinciaInizio.ObjValue = autistaAttivita.ProvinciaInizio;
			NuovaIndirizzoInizio.ObjValue = autistaAttivita.IndirizzoInizio;
			NuovaNazioneInizio.ObjValue = autistaAttivita.NazioneInizio;
			NuovaLocalitaFine.ObjValue = autistaAttivita.LocalitaFine;
			NuovaCapFine.ObjValue = autistaAttivita.CapFine;
			NuovaProvinciaFine.ObjValue = autistaAttivita.ProvinciaFine;
			NuovaIndirizzoFine.ObjValue = autistaAttivita.IndirizzoFine;
			NuovaNazioneFine.ObjValue = autistaAttivita.NazioneFine;
			MasterPopupFormOpen("Modifica Attività", (Control)(object)pnlModificaAttivita, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "MODIFICAATTIVITA");
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

	private FXRETURN ModificaAttivita(int indice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				autistaAttivita = _ElencoAttivita.ElementAt(indice);
				autistaAttivita.KmInizio = NuovaKmInizio.ObjValue.ToString();
				autistaAttivita.KmFine = NuovaKmFine.ObjValue.ToString();
				autistaAttivita.DataInizio = NuovaDatainizio.getDateValue;
				autistaAttivita.DataFine = NuovaDataFine.getDateValue;
				autistaAttivita.LocalitaInizio = NuovaLocalitaInizio.ObjValue.ToString();
				autistaAttivita.CapInizio = NuovaCapInizio.ObjValue.ToString();
				autistaAttivita.IndirizzoInizio = NuovaIndirizzoInizio.ObjValue.ToString();
				autistaAttivita.NazioneInizio = NuovaNazioneInizio.ObjValue.ToString();
				autistaAttivita.LocalitaFine = NuovaLocalitaFine.ObjValue.ToString();
				autistaAttivita.CapFine = NuovaCapFine.ObjValue.ToString();
				autistaAttivita.IndirizzoFine = NuovaIndirizzoFine.ObjValue.ToString();
				autistaAttivita.NazioneFine = NuovaNazioneFine.ObjValue.ToString();
				if (indice > 0)
				{
					if (indice < _ElencoAttivita.Count - 1)
					{
						_ElencoAttivita[indice - 1].DataFine = NuovaDatainizio.getDateValue;
						_ElencoAttivita[indice - 1].KmFine = NuovaKmInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].LocalitaFine = NuovaLocalitaInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].CapFine = NuovaCapInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].IndirizzoFine = NuovaIndirizzoInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].NazioneFine = NuovaNazioneInizio.ObjValue.ToString();
						_ElencoAttivita[indice + 1].DataInizio = NuovaDataFine.getDateValue;
						_ElencoAttivita[indice + 1].KmInizio = NuovaKmFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].LocalitaInizio = NuovaLocalitaFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].CapInizio = NuovaCapFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].IndirizzoInizio = NuovaIndirizzoFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].NazioneInizio = NuovaNazioneFine.ObjValue.ToString();
					}
					else
					{
						_ElencoAttivita[indice - 1].DataFine = NuovaDatainizio.getDateValue;
						_ElencoAttivita[indice - 1].KmFine = NuovaKmInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].LocalitaFine = NuovaLocalitaInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].CapFine = NuovaCapInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].IndirizzoFine = NuovaIndirizzoInizio.ObjValue.ToString();
						_ElencoAttivita[indice - 1].NazioneFine = NuovaNazioneInizio.ObjValue.ToString();
						_SessionVariable["ULTIMATRATTA"] = (object)true;
					}
				}
				else
				{
					_ElencoAttivita[indice + 1].DataInizio = NuovaDataFine.getDateValue;
					_ElencoAttivita[indice + 1].KmInizio = NuovaKmFine.ObjValue.ToString();
					_ElencoAttivita[indice + 1].LocalitaInizio = NuovaLocalitaFine.ObjValue.ToString();
					_ElencoAttivita[indice + 1].CapInizio = NuovaCapFine.ObjValue.ToString();
					_ElencoAttivita[indice + 1].IndirizzoInizio = NuovaIndirizzoFine.ObjValue.ToString();
					_ElencoAttivita[indice + 1].NazioneInizio = NuovaNazioneFine.ObjValue.ToString();
					_SessionVariable["PRIMATRATTA"] = (object)true;
				}
				_SessionVariable["FORZATURA"] = (object)true;
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
	}

	private FXRETURN ApriInterfacciaInserisciAttivita(int indice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_SessionVariable["ATTIVITA"] = (object)indice;
			autistaAttivita = _ElencoAttivita.ElementAt(indice);
			NuovaDatainizio.ObjValue = autistaAttivita.DataInizio;
			NuovaDataFine.ObjValue = autistaAttivita.DataFine;
			NuovaKmInizio.ObjValue = autistaAttivita.KmInizio;
			NuovaKmFine.ObjValue = autistaAttivita.KmFine;
			NuovaLocalitaInizio.ObjValue = autistaAttivita.LocalitaInizio;
			NuovaCapInizio.ObjValue = autistaAttivita.CapInizio;
			NuovaIndirizzoInizio.ObjValue = autistaAttivita.IndirizzoInizio;
			NuovaNazioneInizio.ObjValue = autistaAttivita.NazioneInizio;
			NuovaLocalitaFine.ObjValue = autistaAttivita.LocalitaFine;
			NuovaCapFine.ObjValue = autistaAttivita.CapFine;
			NuovaIndirizzoFine.ObjValue = autistaAttivita.IndirizzoFine;
			NuovaNazioneFine.ObjValue = autistaAttivita.NazioneFine;
			MasterPopupFormOpen("Inserimento Attività", (Control)(object)pnlModificaAttivita, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "INSERISCIATTIVITA");
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

	private FXRETURN InserisciAttivita(int indice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsMess = "";
				autistaAttivita = new AutistaAttivita();
				AutistaAttivita autistaAttivita2 = autistaAttivita;
				autistaAttivita2.DataInizio = NuovaDatainizio.getDateValue;
				autistaAttivita2.DataFine = NuovaDataFine.getDateValue;
				autistaAttivita2.KmInizio = NuovaKmInizio.ObjValue.ToString();
				autistaAttivita2.KmFine = NuovaKmFine.ObjValue.ToString();
				autistaAttivita2.LocalitaInizio = NuovaLocalitaInizio.ObjValue.ToString();
				autistaAttivita2.IndirizzoInizio = NuovaIndirizzoInizio.ObjValue.ToString();
				autistaAttivita2.CapInizio = NuovaCapInizio.ObjValue.ToString();
				autistaAttivita2.NazioneInizio = NuovaNazioneInizio.ObjValue.ToString();
				autistaAttivita2.LocalitaFine = NuovaLocalitaFine.ObjValue.ToString();
				autistaAttivita2.IndirizzoFine = NuovaIndirizzoFine.ObjValue.ToString();
				autistaAttivita2.CapFine = NuovaCapFine.ObjValue.ToString();
				autistaAttivita2.NazioneFine = NuovaNazioneFine.ObjValue.ToString();
				autistaAttivita2.Motrice = _ElencoAttivita[indice].Motrice;
				autistaAttivita2.Rimorchio = _ElencoAttivita[indice].Rimorchio;
				autistaAttivita2.MotricePrecedente = _ElencoAttivita[indice].Motrice;
				autistaAttivita2.RimorchioPrecedente = _ElencoAttivita[indice].Rimorchio;
				autistaAttivita2.Tipo = NuovaTipoAttivita.ObjValue.ToString();
				autistaAttivita2.TipoDescrizione = NuovaTipoAttivita.Text;
				autistaAttivita2 = null;
				if (indice > 0)
				{
					if (indice < _ElencoAttivita.Count - 1)
					{
						_ElencoAttivita[indice].DataFine = NuovaDatainizio.getDateValue;
						_ElencoAttivita[indice].KmFine = NuovaKmInizio.ObjValue.ToString();
						_ElencoAttivita[indice].LocalitaFine = NuovaLocalitaInizio.ObjValue.ToString();
						_ElencoAttivita[indice].CapFine = NuovaCapInizio.ObjValue.ToString();
						_ElencoAttivita[indice].IndirizzoFine = NuovaIndirizzoInizio.ObjValue.ToString();
						_ElencoAttivita[indice].NazioneFine = NuovaNazioneInizio.ObjValue.ToString();
						_ElencoAttivita[indice + 1].DataInizio = NuovaDataFine.getDateValue;
						_ElencoAttivita[indice + 1].KmInizio = NuovaKmFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].LocalitaInizio = NuovaLocalitaFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].CapInizio = NuovaCapFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].IndirizzoInizio = NuovaIndirizzoFine.ObjValue.ToString();
						_ElencoAttivita[indice + 1].NazioneInizio = NuovaNazioneFine.ObjValue.ToString();
					}
					else
					{
						_SessionVariable["ULTIMATRATTA"] = (object)true;
					}
				}
				else
				{
					_SessionVariable["PRIMATRATTA"] = (object)true;
				}
				_ElencoAttivita.Insert(indice + 1, autistaAttivita);
				_SessionVariable["FORZATURA"] = (object)true;
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
	}

	public override FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormOkClick(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "MODIFICAATTIVITA", false) == 0)
			{
				val = ModificaAttivita(Conversions.ToInteger(_SessionVariable["ATTIVITA"].ToString()), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_014c;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "INSERISCIATTIVITA", false) == 0)
			{
				val = InserisciAttivita(Conversions.ToInteger(_SessionVariable["ATTIVITA"].ToString()), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_014c;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "RICERCAXLOCATEINIZIO", false) == 0)
			{
				val = recuperaRisultatoDaPopup("I", ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_014c;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "RICERCAXLOCATEFINE", false) != 0)
				{
					goto IL_014c;
				}
				val = recuperaRisultatoDaPopup("F", ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_014c;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_014c:
			if (!((Operators.CompareString(objPopupInfo.Tag, "MODIFICAATTIVITA", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "INSERISCIATTIVITA", false) == 0)))
			{
				goto IL_01be;
			}
			RepeaterDataRebind();
			val = AggiornaTotali_PartenzaArrrivo(ref rsMess);
			if ((int)val <= 0)
			{
				_SessionVariable.Remove("ATTIVITA");
				base.MasterPage.ContentUpdatePanel.Update();
				goto IL_01be;
			}
			val2 = val;
			goto end_IL_0005;
			IL_01be:
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if ((Operators.CompareString(objPopupInfo.Tag, "MODIFICAATTIVITA", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "INSERISCIATTIVITA", false) == 0))
				{
					_SessionVariable.Remove("ATTIVITA");
				}
				else if ((Operators.CompareString(objPopupInfo.Tag, "RICERCAXLOCATEINIZIO", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "RICERCAXLOCATEFINE", false) == 0))
				{
					MasterPopupFormOpen("Modifica Attività", (Control)(object)pnlModificaAttivita, ButtonsVisible: true, ButtonsOkVisible: true, ButtonsAnnullaVisible: true, "MODIFICAATTIVITA");
				}
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		AutistaAttivita autistaAttivita = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			val2 = base.MasterPopupFormCheckData(ref objPopupInfo, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (!((Operators.CompareString(objPopupInfo.Tag, "MODIFICAATTIVITA", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "INSERISCIATTIVITA", false) == 0)))
				{
					goto IL_0275;
				}
				if (!Information.IsDate(RuntimeHelpers.GetObjectValue(NuovaDatainizio.ObjValue)))
				{
					rsMess = TranslateMessage("XXX", "Inserire data inizio attività");
				}
				else if (!Information.IsDate(RuntimeHelpers.GetObjectValue(NuovaDataFine.ObjValue)))
				{
					rsMess = TranslateMessage("XXX", "Inserire data fine attività");
				}
				else if (DateTime.Compare(Conversions.ToDate(NuovaDataFine.ObjValue), Conversions.ToDate(NuovaDatainizio.ObjValue)) < 0)
				{
					rsMess = TranslateMessage("XXX", "Data fine attività deve essere maggiore data inizio attività");
				}
				else if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NuovaKmInizio.ObjValue)))
				{
					rsMess = TranslateMessage("XXX", "Inserire km inizio attività");
				}
				else if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NuovaKmFine.ObjValue)))
				{
					rsMess = TranslateMessage("XXX", "Inserire km fine attività");
				}
				else if (Conversions.ToInteger(NuovaKmFine.ObjValue) < Conversions.ToInteger(NuovaKmInizio.ObjValue))
				{
					rsMess = TranslateMessage("XXX", "Km fine attività deve essere maggiori km inizio attività");
				}
				else if (Operators.CompareString(NuovaTipoAttivita.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire tipo di attività");
				}
				else if (Operators.CompareString(NuovaLocalitaInizio.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire località di inizio attività");
				}
				else
				{
					if (Operators.CompareString(NuovaLocalitaFine.ObjValue.ToString(), "", false) != 0)
					{
						goto IL_0275;
					}
					rsMess = TranslateMessage("XXX", "Inserire località di fine attività");
				}
			}
			goto end_IL_0007;
			IL_03f6:
			val = (FXRETURN)0;
			goto end_IL_0007;
			IL_0275:
			if (Operators.CompareString(objPopupInfo.Tag, "INSERISCIATTIVITA", false) != 0)
			{
				goto IL_03f6;
			}
			autistaAttivita = _ElencoAttivita.ElementAt(Conversions.ToInteger(_SessionVariable["ATTIVITA"].ToString()));
			if (DateTime.Compare(Conversions.ToDate(NuovaDatainizio.ObjValue), autistaAttivita.DataInizio) < 0)
			{
				rsMess = TranslateMessage("XXX", "Data inizio attività deve essere maggiore di {0}", autistaAttivita.DataInizio.ToString());
			}
			else if (DateTime.Compare(Conversions.ToDate(NuovaDataFine.ObjValue), autistaAttivita.DataFine.Value) > 0)
			{
				rsMess = TranslateMessage("XXX", "Data Fine attività deve essere inferiore di {0}", autistaAttivita.DataFine.ToString());
			}
			else if (Conversions.ToInteger(NuovaKmInizio.ObjValue) < Conversions.ToInteger(autistaAttivita.KmInizio))
			{
				rsMess = TranslateMessage("XXX", "Km inizio attività deve essere maggiori di {0}", autistaAttivita.KmInizio);
			}
			else
			{
				if (Conversions.ToInteger(NuovaKmFine.ObjValue) <= Conversions.ToInteger(autistaAttivita.KmFine))
				{
					goto IL_03f6;
				}
				rsMess = TranslateMessage("XXX", "Km Fine attività deve essere inferiori di {0}", autistaAttivita.KmFine);
			}
			end_IL_0007:;
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
			result = val;
		}
		return result;
	}

	private FXRETURN recuperaRisultatoDaPopup(string tipo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string objValue = "";
		string objValue2 = "";
		string objValue3 = "";
		string text = "";
		string objValue4 = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			text2 = "";
			text3 = "";
			rsMess = "";
			List<LocateLocation> list = (List<LocateLocation>)_SessionVariable["ElencoLocalitaMappa"];
			if (list.Count > 0 && grdElencoLocalitaMappa.SelectedIndex >= 0)
			{
				LocateLocation locateLocation = list[grdElencoLocalitaMappa.SelectedIndex];
				objValue = locateLocation.Via;
				objValue2 = locateLocation.Cap;
				objValue3 = locateLocation.Localita.ToUpper();
				objValue4 = locateLocation.Nazione.ToUpper();
				text2 = locateLocation.Latitudine.ToUpper();
				text3 = locateLocation.Longitudine.ToUpper();
			}
			if (Operators.CompareString(tipo, "I", false) == 0)
			{
				NuovaIndirizzoInizio.ObjValue = objValue;
				NuovaIndirizzoInizio.ObjValue = objValue2;
				NuovaIndirizzoInizio.ObjValue = objValue3;
				NuovaIndirizzoInizio.ObjValue = objValue4;
			}
			else if (Operators.CompareString(tipo, "F", false) == 0)
			{
				NuovaIndirizzoFine.ObjValue = objValue;
				NuovaIndirizzoFine.ObjValue = objValue2;
				NuovaIndirizzoFine.ObjValue = objValue3;
				NuovaIndirizzoFine.ObjValue = objValue4;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}
}
