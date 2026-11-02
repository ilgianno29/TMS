using System;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Params;

public class ApplicationCustomParams : AppParams
{
	protected string _MiocUrl;

	protected string _MiocUrlNew;

	protected string _DirXML_Out;

	protected string _DirXML_In;

	protected string _InvioTransporeonPartenzaViaggio;

	protected string _InvioTesiPartenzaViaggio;

	protected string _CorrispondentiViaggiPiattaforma;

	protected string _TipoViaggioPiattaforma;

	protected StringCollection _ElencoUtentiEscludiRipCosti;

	protected string _ElencoTipoServiziExtraSistema;

	public ApplicationCustomParams(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_MiocUrl = null;
		_MiocUrlNew = null;
		_DirXML_Out = null;
		_DirXML_In = null;
		_InvioTransporeonPartenzaViaggio = null;
		_InvioTesiPartenzaViaggio = null;
		_CorrispondentiViaggiPiattaforma = null;
		_TipoViaggioPiattaforma = null;
		_ElencoUtentiEscludiRipCosti = null;
		_ElencoTipoServiziExtraSistema = null;
	}

	public string MiocUrl()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "http://www.mioc.it/Nusoapserver/wsserver";
		string result;
		try
		{
			if (_MiocUrl == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.MIOCURL", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_MiocUrl = text2;
			}
			result = _MiocUrl;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string MiocUrlNew()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_MiocUrlNew == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.MIOCURLNEW", ref nRes, ref rsMess);
				if (Operators.CompareString(text2, "", false) == 0)
				{
					text2 = "https://lucart.tesisquare-platform.net/webservices/prenotazionioutbound.cfc?wsdl";
				}
				_MiocUrlNew = text2;
			}
			result = _MiocUrlNew;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string DirXML_Out()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "C:\\temp\\Out\\";
		string result;
		try
		{
			if (_DirXML_Out == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.DIRXML.OUT", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_DirXML_Out = text2;
			}
			result = _DirXML_Out;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string DirXML_In()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "C:\\temp\\In\\";
		string result;
		try
		{
			if (_DirXML_In == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.DIRXML.IN", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_DirXML_In = text2;
			}
			result = _DirXML_In;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string InvioTransporeonPartenzaViaggio()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		string result;
		try
		{
			if (_InvioTransporeonPartenzaViaggio == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.INVIOTRANSP_PARTVIA", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_InvioTransporeonPartenzaViaggio = text2;
			}
			result = _InvioTransporeonPartenzaViaggio;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string CorrispondentiViaggiPiattaforma()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "''";
		string result;
		try
		{
			if (_CorrispondentiViaggiPiattaforma == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.CODICI.PIATTAFORMA", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_CorrispondentiViaggiPiattaforma = text2;
			}
			result = _CorrispondentiViaggiPiattaforma;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoViaggioPiattaforma()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "''";
		string result;
		try
		{
			if (_TipoViaggioPiattaforma == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.VIAGGIO.PIATTAFORMA", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_TipoViaggioPiattaforma = text2;
			}
			result = _TipoViaggioPiattaforma;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ElencoTipoServiziExtraSistema()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "";
		string result;
		try
		{
			if (_ElencoTipoServiziExtraSistema == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.TIPISERVIZI.VIAMAN", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_ElencoTipoServiziExtraSistema = text2;
			}
			result = _ElencoTipoServiziExtraSistema;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public StringCollection ElencoUtentiEscludiRipCosti()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		StringCollection stringCollection = new StringCollection();
		StringCollection result;
		try
		{
			if (_ElencoUtentiEscludiRipCosti == null)
			{
				string text2 = "";
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.UTENTI.ESCRIPCOSTI", ref nRes, ref rsMess);
				if ((int)nRes <= 0)
				{
					string[] array = text2.Split(new char[1] { ';' });
					string[] array2 = array;
					foreach (string value in array2)
					{
						if (!stringCollection.Contains(value))
						{
							stringCollection.Add(value);
						}
					}
				}
				_ElencoUtentiEscludiRipCosti = stringCollection;
			}
			result = _ElencoUtentiEscludiRipCosti;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = stringCollection;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string InvioTesiPartenzaViaggio()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		string text = "";
		FXRETURN nRes = (FXRETURN)3;
		string text2 = "N";
		string result;
		try
		{
			if (_InvioTesiPartenzaViaggio == null)
			{
				IboWebParam parametrica = this._Parametrica;
				string rsMess = "";
				text2 = parametrica.ValoreParametro("CST.PARAMS.INVIOTESI_PARTVIA", ref nRes, ref rsMess);
				if ((int)nRes > 0)
				{
				}
				_InvioTesiPartenzaViaggio = text2;
			}
			result = _InvioTesiPartenzaViaggio;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref text);
			result = text2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void ResetParams()
	{
		_MiocUrl = null;
		_MiocUrlNew = null;
		_DirXML_Out = null;
		_DirXML_In = null;
		_InvioTransporeonPartenzaViaggio = null;
		_InvioTesiPartenzaViaggio = null;
		_CorrispondentiViaggiPiattaforma = null;
		_TipoViaggioPiattaforma = null;
		_ElencoUtentiEscludiRipCosti = null;
		_ElencoTipoServiziExtraSistema = null;
	}
}
