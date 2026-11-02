using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_CreaDaModello : GdoAbstractApi
{
	protected string _IdModello;

	protected DataTable _dtSpedizioneModello;

	protected DateTime _DataConsegnaPrevista;

	public Spedizione_CreaDaModello(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdModello = "";
		_dtSpedizioneModello = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdModello = ((AppAbstractApi)this).ParametersIn["IdModello"].ToString();
			_DataConsegnaPrevista = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DataConsegnaPrevista"]);
			val = CheckSpedizioneModello(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Invalid comparison between Unknown and I4
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdModello, "", false) == 0)
			{
				goto IL_0b3b;
			}
			Spedizione Spedizione = new Spedizione();
			Spedizione.NumeroOrdine = "%UNIBOL%";
			Spedizione.DataOrdine = _DataConsegnaPrevista;
			Spedizione.NumeroBolla = "%UNIBOL%";
			Spedizione.DataBolla = _DataConsegnaPrevista;
			Spedizione.NumeroOrdineCliente = _dtSpedizioneModello.Rows[0]["NumeroOrdineCliente"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["DataOrdineCliente"])))
			{
				Spedizione.DataOrdineCliente = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["DataOrdineCliente"]);
			}
			Spedizione.TipoServizio = _dtSpedizioneModello.Rows[0]["TipoServizio"].ToString();
			Spedizione.Cliente = _dtSpedizioneModello.Rows[0]["Cliente"].ToString();
			Spedizione.Mittente = _dtSpedizioneModello.Rows[0]["Mittente"].ToString();
			Spedizione.MittenteRagioneSociale = _dtSpedizioneModello.Rows[0]["MittenteRagioneSociale"].ToString();
			Spedizione.TipoSpedizione = _dtSpedizioneModello.Rows[0]["TipoSpedizione"].ToString();
			Spedizione.TipoSpedizionePassivo = _dtSpedizioneModello.Rows[0]["TipoSpedizionePassivo"].ToString();
			Spedizione.TipoMerce = _dtSpedizioneModello.Rows[0]["TipoMerce"].ToString();
			Spedizione.PCSPartenza = _dtSpedizioneModello.Rows[0]["PCSPartenza"].ToString();
			Spedizione.PCSDestinazione = _dtSpedizioneModello.Rows[0]["PCSDestinazione"].ToString();
			Spedizione.ZonaSpedizione = _dtSpedizioneModello.Rows[0]["ZonaSpedizione"].ToString();
			Spedizione.ZonaArrivoTariffaAttiva = _dtSpedizioneModello.Rows[0]["ZonaArrivoTariffaAttiva"].ToString();
			Spedizione.ZonaPartenzaTariffaPassiva = _dtSpedizioneModello.Rows[0]["ZonaPartenzaTariffaPassiva"].ToString();
			Spedizione.ZonaArrivoTariffaPassiva = _dtSpedizioneModello.Rows[0]["ZonaArrivoTariffaPassiva"].ToString();
			Spedizione.Corrispondente = _dtSpedizioneModello.Rows[0]["Corrispondente"].ToString();
			Spedizione.Trasportatore = _dtSpedizioneModello.Rows[0]["Trasportatore"].ToString();
			Spedizione.Peso = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["Peso"]);
			Spedizione.Colli = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["Colli"]);
			Spedizione.Pallet = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["Pallet"]);
			Spedizione.Volume = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["Volume"]);
			Spedizione.CampoCalcolo1 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo1"]);
			Spedizione.CampoCalcolo2 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo2"]);
			Spedizione.CampoCalcolo3 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo3"]);
			Spedizione.CampoCalcolo4 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo4"]);
			Spedizione.CampoCalcolo5 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo5"]);
			Spedizione.CampoCalcolo6 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo6"]);
			Spedizione.CampoCalcolo7 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo7"]);
			Spedizione.CampoCalcolo8 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo8"]);
			Spedizione.CampoCalcolo9 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo9"]);
			Spedizione.CampoCalcolo10 = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["CampoCalcolo10"]);
			Spedizione.Flag1 = _dtSpedizioneModello.Rows[0]["Flag1"].ToString();
			Spedizione.Flag2 = _dtSpedizioneModello.Rows[0]["Flag2"].ToString();
			Spedizione.Flag3 = _dtSpedizioneModello.Rows[0]["Flag3"].ToString();
			Spedizione.Flag4 = _dtSpedizioneModello.Rows[0]["Flag4"].ToString();
			Spedizione.Flag5 = _dtSpedizioneModello.Rows[0]["Flag5"].ToString();
			Spedizione.Flag6 = _dtSpedizioneModello.Rows[0]["Flag6"].ToString();
			Spedizione.Flag7 = _dtSpedizioneModello.Rows[0]["Flag7"].ToString();
			Spedizione.Flag8 = _dtSpedizioneModello.Rows[0]["Flag8"].ToString();
			Spedizione.Flag9 = _dtSpedizioneModello.Rows[0]["Flag9"].ToString();
			Spedizione.Flag10 = _dtSpedizioneModello.Rows[0]["Flag10"].ToString();
			Spedizione.Contrassegno = Conversions.ToDecimal(_dtSpedizioneModello.Rows[0]["Contrassegno"]);
			Spedizione.Note = _dtSpedizioneModello.Rows[0]["Note"].ToString();
			Spedizione.FillerAlfa1 = _dtSpedizioneModello.Rows[0]["FillerAlfa1"].ToString();
			Spedizione.FillerAlfa2 = _dtSpedizioneModello.Rows[0]["FillerAlfa2"].ToString();
			Spedizione.FillerAlfa3 = _dtSpedizioneModello.Rows[0]["FillerAlfa3"].ToString();
			Spedizione.FillerAlfa4 = _dtSpedizioneModello.Rows[0]["FillerAlfa4"].ToString();
			Spedizione.FillerAlfa5 = _dtSpedizioneModello.Rows[0]["FillerAlfa5"].ToString();
			Spedizione.FillerAlfa6 = _dtSpedizioneModello.Rows[0]["FillerAlfa6"].ToString();
			Spedizione.FillerAlfa7 = _dtSpedizioneModello.Rows[0]["FillerAlfa7"].ToString();
			Spedizione.FillerAlfa8 = _dtSpedizioneModello.Rows[0]["FillerAlfa8"].ToString();
			Spedizione.FillerAlfa9 = _dtSpedizioneModello.Rows[0]["FillerAlfa9"].ToString();
			Spedizione.FillerAlfa10 = _dtSpedizioneModello.Rows[0]["FillerAlfa10"].ToString();
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["FillerData1"])))
			{
				Spedizione.FillerData1 = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["FillerData1"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["FillerData2"])))
			{
				Spedizione.FillerData2 = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["FillerData2"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["FillerData3"])))
			{
				Spedizione.FillerData3 = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["FillerData3"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["FillerData4"])))
			{
				Spedizione.FillerData4 = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["FillerData4"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizioneModello.Rows[0]["FillerData5"])))
			{
				Spedizione.FillerData5 = Conversions.ToDate(_dtSpedizioneModello.Rows[0]["FillerData5"]);
			}
			val = Spedizione_Inserisci_Invoker.Instance.RunProc(this._ApiContext, ref Spedizione, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0b3b;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0b3b:
			val2 = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CheckSpedizioneModello(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdModello, "", false) == 0)
			{
				goto IL_00b1;
			}
			text = "SELECT * FROM Spedizioni_ModelloSettimanale WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdModello);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioneModello, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_dtSpedizioneModello.Rows.Count != 0)
				{
					goto IL_00b1;
				}
				rsmess = this.TranslateMessage("XXX", "Modello con Id {0} insesistente", new string[1] { _IdModello });
			}
			goto end_IL_000b;
			IL_00b1:
			val2 = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
