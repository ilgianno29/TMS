using System;
using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Params;

public class ApplicationParams : AppParams
{
	protected string _UsexRoute;

	protected string _LocalizzaDestinatari;

	protected string _SpedizioniFormatoUnibol;

	protected string _SpedizioniCampoObbligatorioOBC;

	protected string _WmsEnabled;

	protected string _CampoRipartizioneCostiViaggio;

	protected string _CampoRipartizioneRicaviViaggio;

	protected bool? _RoutingUseTrackAttributes;

	protected string _GiriStandardPresenti;

	protected Dictionary<string, string> _WmsMethodEnabled;

	protected Dictionary<string, string> _WmsParams;

	protected Dictionary<string, string> _TMSServiceForWMSGetParams;

	protected Dictionary<string, string> _UI_LabelText;

	protected int? _MargineSogliaInferiore;

	protected int? _MargineSogliaSuperiore;

	protected ApplicationCustomParams _Custom;

	protected string _CampoDataRiferimentoPerTempiResa;

	protected bool? _EnabledRoadEditor;

	protected string _ViaggiDipendenzaTrasportatore;

	protected string _AbilitaTariffeDiSpedizioneSulVettore;

	protected bool? _ACTMode;

	protected int? _NumRisultatiVettoriMigliori;

	protected bool? _UsexTour;

	protected Dictionary<string, string> _UIComponentGetProperty;

	protected bool? _RaggruppaConPCSPartenza;

	protected bool? _CheckDateEsitoSpedizione;

	public ApplicationCustomParams Custom => _Custom;

	public ApplicationParams(AppApiContext objApiContext)
		: base(objApiContext)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		_UsexRoute = null;
		_LocalizzaDestinatari = null;
		_SpedizioniFormatoUnibol = null;
		_SpedizioniCampoObbligatorioOBC = null;
		_WmsEnabled = null;
		_CampoRipartizioneCostiViaggio = null;
		_CampoRipartizioneRicaviViaggio = null;
		_RoutingUseTrackAttributes = null;
		_GiriStandardPresenti = null;
		_WmsMethodEnabled = new Dictionary<string, string>();
		_WmsParams = new Dictionary<string, string>();
		_TMSServiceForWMSGetParams = new Dictionary<string, string>();
		_UI_LabelText = new Dictionary<string, string>();
		_MargineSogliaInferiore = null;
		_MargineSogliaSuperiore = null;
		_CampoDataRiferimentoPerTempiResa = null;
		_EnabledRoadEditor = null;
		_ViaggiDipendenzaTrasportatore = null;
		_AbilitaTariffeDiSpedizioneSulVettore = null;
		_ACTMode = null;
		_UsexTour = null;
		_UIComponentGetProperty = new Dictionary<string, string>();
		_RaggruppaConPCSPartenza = null;
		_CheckDateEsitoSpedizione = null;
		_Custom = new ApplicationCustomParams(objApiContext);
	}

	public string LocalizzaDestinatari()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_LocalizzaDestinatari == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.DESTINATARI.LOCALIZZAZIONE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_LocalizzaDestinatari = text2;
				}
			}
			else
			{
				text2 = _LocalizzaDestinatari;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string UsexRoute()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_UsexRoute == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.USEXROUTE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_UsexRoute = text2;
				}
			}
			else
			{
				text2 = _UsexRoute;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Spedizioni_FormatoUnibol()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_SpedizioniFormatoUnibol == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.SPEDIZIONI.FORMATO", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_SpedizioniFormatoUnibol = text2;
				}
			}
			else
			{
				text2 = _SpedizioniFormatoUnibol;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string SpedizioniCampoObbligatorioOBC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_SpedizioniCampoObbligatorioOBC == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.SPEDIZIONI.NUMERODDT", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_SpedizioniCampoObbligatorioOBC = text2;
				}
			}
			else
			{
				text2 = _SpedizioniCampoObbligatorioOBC;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string WmsEnabled()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_WmsEnabled == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.WMS.ENABLED", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_WmsEnabled = text2;
			}
			else
			{
				text2 = _WmsEnabled;
			}
			result = text2.ToUpper();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string WmsMethodEnabled(string Method)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (!_WmsMethodEnabled.ContainsKey(Method))
			{
				IboWebParam parametrica = this._Parametrica;
				string vsNome = "PARAMS.WMS." + Method;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(vsNome, ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = WmsEnabled();
				}
				_WmsMethodEnabled.Add(Method, text2);
			}
			else
			{
				text2 = _WmsMethodEnabled[Method];
			}
			result = text2.ToUpper();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string WmsGetParams(string Method)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (!_WmsParams.ContainsKey(Method))
			{
				IboWebParam parametrica = this._Parametrica;
				string vsNome = "PARAMS.WMS." + Method;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(vsNome, ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				_WmsParams.Add(Method, text2);
			}
			else
			{
				text2 = _WmsParams[Method];
			}
			result = text2.ToUpper();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TMSServiceForWMSGetParams(string Method)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (!_TMSServiceForWMSGetParams.ContainsKey(Method))
			{
				IboWebParam parametrica = this._Parametrica;
				string vsNome = "PARAMS.TMSForWMS." + Method;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(vsNome, ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				_TMSServiceForWMSGetParams.Add(Method, text2);
			}
			else
			{
				text2 = _TMSServiceForWMSGetParams[Method];
			}
			result = text2.ToUpper();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Spedizioni_GetFieldText(string Campo, string DefaultValue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = DefaultValue;
		string result;
		try
		{
			string text3 = "PARAMS.UI.SPEDIZIONI." + Campo.ToUpper();
			if (!_UI_LabelText.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(text3, ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = DefaultValue;
				}
				_UI_LabelText.Add(text3, text2);
			}
			else
			{
				text2 = _UI_LabelText[text3];
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string PCS_GetFieldText(string Campo, string DefaultValue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = DefaultValue;
		string result;
		try
		{
			string text3 = "PARAMS.UI.PCS." + Campo.ToUpper();
			if (!_UI_LabelText.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(text3, ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = DefaultValue;
				}
				_UI_LabelText.Add(text3, text2);
			}
			else
			{
				text2 = _UI_LabelText[text3];
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool ACTMode()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		bool result;
		try
		{
			if (!_ACTMode.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.UI.ACTMODE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_ACTMode = Operators.CompareString(text2, "N", false) != 0;
			}
			result = _ACTMode.Value;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Viaggi_GetFieldText(string Campo, string DefaultValue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = DefaultValue;
		string result;
		try
		{
			string text3 = "PARAMS.UI.VIAGGI." + Campo.ToUpper();
			if (!_UI_LabelText.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(text3, ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = DefaultValue;
				}
				_UI_LabelText.Add(text3, text2);
			}
			else
			{
				text2 = _UI_LabelText[text3];
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string UIComponentGetProperty(string sForm, string ComponentId, string sProperty)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string text3 = "";
		string result;
		try
		{
			text3 = "DM.UI." + sForm.ToUpper() + "." + ComponentId + "." + sProperty.ToUpper();
			if (!_UIComponentGetProperty.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string vsNome = text3;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(vsNome, ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				_UIComponentGetProperty.Add(text3, text2);
			}
			else
			{
				text2 = _UIComponentGetProperty[text3];
			}
			result = text2.ToUpper();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string UIComponentGetProperty(string sForm, string ComponentId, string sProperty, string DefaultValue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = DefaultValue;
		string text3 = "";
		string result;
		try
		{
			text3 = "DM.UI." + sForm.ToUpper() + "." + ComponentId + "." + sProperty.ToUpper();
			if (!_UIComponentGetProperty.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string vsNome = text3;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(vsNome, ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = DefaultValue;
				}
				_UIComponentGetProperty.Add(text3, text2);
			}
			else
			{
				text2 = _UIComponentGetProperty[text3];
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string GenericFormUI_GetFieldValue(string sForm, string Campo, string DefaultValue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = DefaultValue;
		string result;
		try
		{
			string text3 = "DM.PARAMS.UI." + sForm.ToUpper() + "." + Campo.ToUpper();
			if (!_UI_LabelText.ContainsKey(text3))
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro(text3, ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = DefaultValue;
				}
				_UI_LabelText.Add(text3, text2);
			}
			else
			{
				text2 = _UI_LabelText[text3];
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string CampoRipartizioneCostiViaggio()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_CampoRipartizioneCostiViaggio == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.VIAGGI.COSTI.CAMPORIPARTIZIONE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_CampoRipartizioneCostiViaggio = text2;
				}
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = "1";
				}
			}
			else
			{
				text2 = _CampoRipartizioneCostiViaggio;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string CampoDataRiferimentoPerTempiResa()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_CampoDataRiferimentoPerTempiResa == null)
			{
				text2 = "";
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.TEMPIRESA.DATARIFERIMENTO", ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = "DATINS";
				}
				_CampoDataRiferimentoPerTempiResa = text2;
			}
			else
			{
				text2 = _CampoDataRiferimentoPerTempiResa;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "DATINS";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string CampoRipartizioneRicaviViaggio()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_CampoRipartizioneRicaviViaggio == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.VIAGGI.RICAVI.CAMPORIPARTIZIONE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "";
				}
				else
				{
					_CampoRipartizioneRicaviViaggio = text2;
				}
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = "PESO";
				}
			}
			else
			{
				text2 = _CampoRipartizioneRicaviViaggio;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool RoutingUseTrackAttributes()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		bool result;
		try
		{
			if (!_RoutingUseTrackAttributes.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.ROUTING.USETRUCKATTRIBUTES", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_RoutingUseTrackAttributes = Operators.CompareString(text2.ToUpper(), "S", false) == 0;
				result = _RoutingUseTrackAttributes.Value;
			}
			else
			{
				result = _RoutingUseTrackAttributes.Value;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool EnabledRoadEditor()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		bool result;
		try
		{
			if (!_EnabledRoadEditor.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.ROUTING.ENABLEDROADEDITOR", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_EnabledRoadEditor = Operators.CompareString(text2.ToUpper(), "S", false) == 0;
				result = _EnabledRoadEditor.Value;
			}
			else
			{
				result = _EnabledRoadEditor.Value;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool GiriStandardPresenti()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN val = (FXRETURN)3;
		string text2 = "";
		bool result;
		try
		{
			if (_GiriStandardPresenti == null)
			{
				object objRes = 0;
				string sSql = "SELECT COUNT(*) FROM GIRISTANDARD_TESTATA WHERE ATTIVO='S'";
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				string rsMess = "";
				dbConn.DoSql(sSql, ref objRes, ref rsMess);
				if (Conversions.ToInteger(objRes) > 0)
				{
					_GiriStandardPresenti = "S";
				}
				else
				{
					_GiriStandardPresenti = "N";
				}
				text2 = _GiriStandardPresenti;
			}
			else
			{
				text2 = _GiriStandardPresenti;
			}
			result = Operators.CompareString(text2, "S", false) == 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int MargineSogliaInferiore()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		int result;
		try
		{
			if (!_MargineSogliaInferiore.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.VIAGGI.COSTIRICAVI.MARGINESOGLIE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "00";
				}
				if (!text2.Contains(";"))
				{
					text2 = "00";
				}
				else
				{
					string[] array = text2.Split(new char[1] { ';' });
					text2 = ((array.Length == 2) ? array[0] : "00");
				}
				_MargineSogliaInferiore = Conversions.ToInteger(text2);
			}
			else
			{
				text2 = _MargineSogliaInferiore.ToString();
			}
			result = Conversions.ToInteger(text2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int MargineSogliaSuperiore()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		int result;
		try
		{
			if (!_MargineSogliaSuperiore.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.VIAGGI.COSTIRICAVI.MARGINESOGLIE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "10";
				}
				if (!text2.Contains(";"))
				{
					text2 = "10";
				}
				else
				{
					string[] array = text2.Split(new char[1] { ';' });
					text2 = ((array.Length == 2) ? array[1] : "10");
				}
				_MargineSogliaSuperiore = Conversions.ToInteger(text2);
			}
			else
			{
				text2 = _MargineSogliaSuperiore.ToString();
			}
			result = Conversions.ToInteger(text2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = 10;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ViaggiDipendenzaTrasportatore()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_ViaggiDipendenzaTrasportatore == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.VIAGGI.DIPENDENZATRASPORTATORE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "M";
				}
				_ViaggiDipendenzaTrasportatore = text2;
			}
			else
			{
				text2 = _ViaggiDipendenzaTrasportatore;
			}
			result = text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = "M";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool AbilitaTariffeDiSpedizioneSulVettore()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		bool result;
		try
		{
			if (_AbilitaTariffeDiSpedizioneSulVettore == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.TARIFFE.TARSPED_SUVETTORE.ENABLED", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_AbilitaTariffeDiSpedizioneSulVettore = text2;
			}
			else
			{
				text2 = _AbilitaTariffeDiSpedizioneSulVettore;
			}
			result = Operators.CompareString(text2.ToUpper(), "S", false) == 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int NumRisultatiVettoriMigliori()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		int result;
		try
		{
			int num;
			if (!_NumRisultatiVettoriMigliori.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				num = Conversions.ToInteger(parametrica.ValoreParametro("PARAMS.VIAGGI.NUM_VETTORI_MIGLIORI", ref nRes, ref rsMess));
				if ((int)nRes != 0)
				{
					num = 1;
				}
				_NumRisultatiVettoriMigliori = num;
			}
			else
			{
				num = _NumRisultatiVettoriMigliori.Value;
			}
			result = num;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = 1;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool UsexTour()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		bool result;
		try
		{
			if (!_UsexTour.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.USEXTOUR", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_UsexTour = Operators.CompareString(text2.ToUpper(), "S", false) == 0;
				result = _UsexTour.Value;
			}
			else
			{
				result = _UsexTour.Value;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool RaggruppaConPCSPartenza()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		bool result;
		try
		{
			if (!_RaggruppaConPCSPartenza.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("DM.PARAMS.RAGGRUPPA_CON_PARTENZA", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_RaggruppaConPCSPartenza = Operators.CompareString(text2.ToUpper(), "S", false) == 0;
				result = _RaggruppaConPCSPartenza.Value;
			}
			else
			{
				result = _RaggruppaConPCSPartenza.Value;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool DoCheckDateEsitoSpedizione()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		bool result;
		try
		{
			if (!_CheckDateEsitoSpedizione.HasValue)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("PARAMS.ESITAZIONE.DOCHECKDATE", ref nRes, ref rsMess);
				if ((int)nRes != 0)
				{
					text2 = "N";
				}
				_CheckDateEsitoSpedizione = Operators.CompareString(text2, "S", false) == 0;
			}
			result = _CheckDateEsitoSpedizione.Value;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void ResetParams()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		_UsexRoute = null;
		_LocalizzaDestinatari = null;
		_SpedizioniFormatoUnibol = null;
		_SpedizioniCampoObbligatorioOBC = null;
		_WmsEnabled = null;
		_CampoRipartizioneRicaviViaggio = null;
		_CampoRipartizioneCostiViaggio = null;
		_GiriStandardPresenti = null;
		_WmsMethodEnabled = new Dictionary<string, string>();
		_WmsParams = new Dictionary<string, string>();
		_TMSServiceForWMSGetParams = new Dictionary<string, string>();
		_UI_LabelText = new Dictionary<string, string>();
		_MargineSogliaInferiore = null;
		_MargineSogliaSuperiore = null;
		_CampoDataRiferimentoPerTempiResa = null;
		_EnabledRoadEditor = null;
		_ViaggiDipendenzaTrasportatore = null;
		_AbilitaTariffeDiSpedizioneSulVettore = null;
		_NumRisultatiVettoriMigliori = 1;
		_UsexTour = null;
		_CheckDateEsitoSpedizione = null;
		_UIComponentGetProperty = new Dictionary<string, string>();
		_Custom.ResetParams();
		try
		{
			IboWebParam parametrica = this._Parametrica;
			string rsMess = "";
			parametrica.RicaricaParametri(ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
