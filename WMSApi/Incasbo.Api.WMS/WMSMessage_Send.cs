using System;
using System.Collections.Generic;
using System.ServiceModel;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.WMSService;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

public class WMSMessage_Send : WMSAbstractApi
{
	protected IwmsServiceForTMSClient _WMSService;

	protected WMSMessageType _WMSMessageType;

	protected Dictionary<string, object> _InputInfo;

	protected Dictionary<string, object> _OutputInfo;

	public ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)this._ApiContext.AppDefault;

	public ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public WMSMessage_Send(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_WMSMessageType = WMSMessageType.UnKnown;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string[] array = new string[0];
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_WMSMessageType = (WMSMessageType)this._ParametersIn["TipoMessaggio"];
			_InputInfo = (Dictionary<string, object>)this._ParametersIn["InputInfo"];
			_OutputInfo = new Dictionary<string, object>();
			((AppAbstractApi)this).ParametersOut.Add("OutputInfo", _OutputInfo);
			AppApiContext apiContext = this._ApiContext;
			AppParams appParams = apiContext.AppParams;
			WMSMessageConfig.Init(ref appParams);
			apiContext.AppParams = appParams;
			if (Operators.CompareString(ApplicationParams.WmsEnabled(), "S", false) == 0 && WMSMessageConfig.WmsMessageEnabled[_WMSMessageType])
			{
				switch (_WMSMessageType)
				{
				case WMSMessageType.CreazioneBatch:
					array = new string[5] { "BatchCodice", "BatchDataOraPreparazione", "BatchDescrizione", "BatchZonaSpedizione", "BatchZonaSpedizioneDescrizione" };
					break;
				case WMSMessageType.AssociaSpedizioneABatch:
					array = new string[4] { "BatchCodice", "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine" };
					break;
				case WMSMessageType.CreazioneViaggio:
					array = new string[4] { "ViaggioAltezzaMezzo", "ViaggioCodice", "ViaggioDataRiferimento", "ViaggioVettore" };
					break;
				case WMSMessageType.CancellazioneViaggio:
					array = new string[1] { "ViaggioCodice" };
					break;
				case WMSMessageType.RiapriViaggio:
					array = new string[1] { "ViaggioCodice" };
					break;
				case WMSMessageType.DisassociaSpedizioneAViaggio:
					array = new string[4] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine", "ViaggioCodice" };
					break;
				case WMSMessageType.DisassociaSpedizioneAViaggioChiuso:
					array = new string[4] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine", "ViaggioCodice" };
					break;
				case WMSMessageType.AssociaSpedizioneAViaggio:
					array = new string[3] { "SpedizioneCommittente", "SpedizioneOrdine", "ViaggioCodice" };
					break;
				case WMSMessageType.AssociaSpedizioneAViaggioChiuso:
					array = new string[3] { "SpedizioneCommittente", "SpedizioneOrdine", "ViaggioCodice" };
					break;
				case WMSMessageType.AssegnaSequenzaConsegnaOrdine:
					array = new string[4] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine", "SequenzaConsegna" };
					break;
				case WMSMessageType.CalcolaNumeroPalletSagomeViaggio:
					array = new string[1] { "ViaggioCodice" };
					break;
				case WMSMessageType.CalcolaNumeroPalletSagome:
					array = new string[1] { "BatchCodice" };
					break;
				case WMSMessageType.DisassociaSpedizioneABatch:
					array = new string[4] { "BatchCodice", "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine" };
					break;
				case WMSMessageType.AggiornaQuantitaSpedizione:
					array = new string[3] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine" };
					break;
				case WMSMessageType.AssociaSpedizioneALinea:
					array = new string[6] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine", "IdLinea", "Giro", "DataLinea" };
					break;
				case WMSMessageType.DisassociaSpedizioneALinea:
					array = new string[4] { "SpedizioneCommittente", "SpedizioneData", "SpedizioneOrdine", "Giro" };
					break;
				}
				string[] array2 = array;
				int num = 0;
				while (num < array2.Length)
				{
					string text2 = array2[num];
					if (_InputInfo.ContainsKey(text2))
					{
						num = checked(num + 1);
						continue;
					}
					rsmess = this.TranslateMessage("XXX", "Parametro obbligatorio {0} non specificato.", new string[1] { text2 });
					goto end_IL_0012;
				}
			}
			val2 = (FXRETURN)0;
			end_IL_0012:;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b45: Invalid comparison between Unknown and I4
		//IL_1ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result2;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ApplicationParams.WmsEnabled(), "S", false) == 0 && WMSMessageConfig.WmsMessageEnabled[_WMSMessageType])
			{
				Sender sender = new Sender();
				sender.Name = "GDO";
				if (Operators.CompareString(this._User, "DSI", false) == 0)
				{
					sender.Profile = ProfileEnum.batch;
				}
				else
				{
					sender.Profile = ProfileEnum.interactive;
				}
				_WMSService = new IwmsServiceForTMSClient();
				this.WriteLog("BEFORE " + _WMSMessageType);
				string text2 = "";
				switch (_WMSMessageType)
				{
				case WMSMessageType.AssegnaSequenzaConsegnaOrdine:
				{
					AssegnaSequenzaArgs assegnaSequenzaArgs = new AssegnaSequenzaArgs();
					assegnaSequenzaArgs.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine9 = assegnaSequenzaArgs.InOrdine;
					inOrdine9.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine9.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine9.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine9.InSequenzaConsegna = Conversions.ToInteger(_InputInfo["SequenzaConsegna"]);
					text2 = "COMMITTENTE=" + inOrdine9.Committente + ";DATA=" + inOrdine9.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + inOrdine9.Ordine;
					this.WriteLog(text2);
					inOrdine9 = null;
					Result result = _WMSService.AssegnaSequenzaConsegnaOrdine(sender, assegnaSequenzaArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.AssociaSpedizioneABatch:
				{
					AggregazioneOrdineBatchArgs aggregazioneOrdineBatchArgs = new AggregazioneOrdineBatchArgs();
					aggregazioneOrdineBatchArgs.ExtensionData = null;
					aggregazioneOrdineBatchArgs.InBatch = new Batch();
					Batch inBatch = aggregazioneOrdineBatchArgs.InBatch;
					inBatch.Codice = _InputInfo["BatchCodice"].ToString();
					inBatch.DataeOraPreparazione = Conversions.ToDate(_InputInfo["BatchDataOraPreparazione"]);
					inBatch = null;
					aggregazioneOrdineBatchArgs.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine2 = aggregazioneOrdineBatchArgs.InOrdine;
					inOrdine2.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine2.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine2.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					text2 = "COMMITTENTE=" + inOrdine2.Committente + ";DATA=" + inOrdine2.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + inOrdine2.Ordine + ";BATCHID=" + aggregazioneOrdineBatchArgs.InBatch.Codice;
					this.WriteLog(text2);
					inOrdine2 = null;
					Result result = _WMSService.AggregazioneOrdineBatch(sender, aggregazioneOrdineBatchArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CreazioneViaggio:
				{
					CreazioneSpedizioneArgs creazioneSpedizioneArgs = new CreazioneSpedizioneArgs();
					creazioneSpedizioneArgs.InSpedizione = new Spedizione();
					Spedizione inSpedizione7 = creazioneSpedizioneArgs.InSpedizione;
					inSpedizione7.AltezzaMezzo = Conversions.ToInteger(_InputInfo["ViaggioAltezzaMezzo"]);
					inSpedizione7.Codice = _InputInfo["ViaggioCodice"].ToString();
					inSpedizione7.DataRiferimento = Conversions.ToDate(_InputInfo["ViaggioDataRiferimento"]);
					inSpedizione7.Vettore = _InputInfo["ViaggioVettore"].ToString();
					text2 = "IDVIAGGIO=" + inSpedizione7.Codice + ";DATA=" + inSpedizione7.DataRiferimento.ToString("dd/MM/yyyy") + ";VETTORE=" + inSpedizione7.Vettore;
					this.WriteLog(text2);
					inSpedizione7 = null;
					Result result = _WMSService.CreazioneSpedizione(sender, creazioneSpedizioneArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CancellazioneViaggio:
				{
					EliminazioneSpedizioneArgs eliminazioneSpedizioneArgs = new EliminazioneSpedizioneArgs();
					eliminazioneSpedizioneArgs.InSpedizione = new Spedizione();
					Spedizione inSpedizione5 = eliminazioneSpedizioneArgs.InSpedizione;
					inSpedizione5.Codice = _InputInfo["ViaggioCodice"].ToString();
					text2 = "IDVIAGGIO=" + inSpedizione5.Codice;
					this.WriteLog(text2);
					inSpedizione5 = null;
					Result result = _WMSService.EliminazioneSpedizione(sender, eliminazioneSpedizioneArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.RiapriViaggio:
				{
					EliminazioneSpedizioneArgs eliminazioneSpedizioneArgs2 = new EliminazioneSpedizioneArgs();
					eliminazioneSpedizioneArgs2.InSpedizione = new Spedizione();
					Spedizione inSpedizione8 = eliminazioneSpedizioneArgs2.InSpedizione;
					inSpedizione8.Codice = _InputInfo["ViaggioCodice"].ToString();
					text2 = "IDVIAGGIO=" + inSpedizione8.Codice;
					this.WriteLog(text2);
					inSpedizione8 = null;
					Result result = _WMSService.EliminazioneSpedizione(sender, eliminazioneSpedizioneArgs2);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.AssociaSpedizioneAViaggio:
				{
					AssociaOrdineASpedizioneArgs associaOrdineASpedizioneArgs = new AssociaOrdineASpedizioneArgs();
					associaOrdineASpedizioneArgs.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine = associaOrdineASpedizioneArgs.InOrdine;
					inOrdine.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine = null;
					associaOrdineASpedizioneArgs.InSpedizione = new Spedizione();
					Spedizione inSpedizione = associaOrdineASpedizioneArgs.InSpedizione;
					inSpedizione.Codice = _InputInfo["ViaggioCodice"].ToString();
					inSpedizione = null;
					text2 = "COMMITTENTE=" + associaOrdineASpedizioneArgs.InOrdine.Committente + ";DATA=" + associaOrdineASpedizioneArgs.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + associaOrdineASpedizioneArgs.InOrdine.Ordine + ";IDVIAGGIO=" + associaOrdineASpedizioneArgs.InSpedizione.Codice;
					this.WriteLog(text2);
					Result result = _WMSService.AssociaOrdineASpedizione(sender, associaOrdineASpedizioneArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.AssociaSpedizioneAViaggioChiuso:
				{
					AssociaOrdineASpedizioneArgs associaOrdineASpedizioneArgs4 = new AssociaOrdineASpedizioneArgs();
					associaOrdineASpedizioneArgs4.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine8 = associaOrdineASpedizioneArgs4.InOrdine;
					inOrdine8.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine8.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine8.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine8 = null;
					associaOrdineASpedizioneArgs4.InSpedizione = new Spedizione();
					Spedizione inSpedizione6 = associaOrdineASpedizioneArgs4.InSpedizione;
					inSpedizione6.Codice = _InputInfo["ViaggioCodice"].ToString();
					inSpedizione6 = null;
					text2 = "COMMITTENTE=" + associaOrdineASpedizioneArgs4.InOrdine.Committente + ";DATA=" + associaOrdineASpedizioneArgs4.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + associaOrdineASpedizioneArgs4.InOrdine.Ordine + ";IDVIAGGIO=" + associaOrdineASpedizioneArgs4.InSpedizione.Codice;
					this.WriteLog(text2);
					Result result = _WMSService.AssociaOrdineASpedizione(sender, associaOrdineASpedizioneArgs4);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.DisassociaSpedizioneAViaggio:
				{
					AssociaOrdineASpedizioneArgs associaOrdineASpedizioneArgs3 = new AssociaOrdineASpedizioneArgs();
					associaOrdineASpedizioneArgs3.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine4 = associaOrdineASpedizioneArgs3.InOrdine;
					inOrdine4.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine4.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine4.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine4 = null;
					associaOrdineASpedizioneArgs3.InSpedizione = new Spedizione();
					Spedizione inSpedizione4 = associaOrdineASpedizioneArgs3.InSpedizione;
					inSpedizione4.Codice = _InputInfo["ViaggioCodice"].ToString();
					inSpedizione4 = null;
					text2 = "COMMITTENTE=" + associaOrdineASpedizioneArgs3.InOrdine.Committente + ";DATA=" + associaOrdineASpedizioneArgs3.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + associaOrdineASpedizioneArgs3.InOrdine.Ordine + ";IDVIAGGIO=" + associaOrdineASpedizioneArgs3.InSpedizione.Codice;
					this.WriteLog(text2);
					Result result = _WMSService.DeAssociaOrdineDaSpedizione(sender, associaOrdineASpedizioneArgs3);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.DisassociaSpedizioneAViaggioChiuso:
				{
					AssociaOrdineASpedizioneArgs associaOrdineASpedizioneArgs2 = new AssociaOrdineASpedizioneArgs();
					associaOrdineASpedizioneArgs2.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine3 = associaOrdineASpedizioneArgs2.InOrdine;
					inOrdine3.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine3.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine3.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine3 = null;
					associaOrdineASpedizioneArgs2.InSpedizione = new Spedizione();
					Spedizione inSpedizione2 = associaOrdineASpedizioneArgs2.InSpedizione;
					inSpedizione2.Codice = _InputInfo["ViaggioCodice"].ToString();
					inSpedizione2 = null;
					text2 = "COMMITTENTE=" + associaOrdineASpedizioneArgs2.InOrdine.Committente + ";DATA=" + associaOrdineASpedizioneArgs2.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + associaOrdineASpedizioneArgs2.InOrdine.Ordine + ";IDVIAGGIO=" + associaOrdineASpedizioneArgs2.InSpedizione.Codice;
					this.WriteLog(text2);
					Result result = _WMSService.DeAssociaOrdineDaSpedizione(sender, associaOrdineASpedizioneArgs2);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CalcolaNumeroPalletSagomeViaggio:
				{
					CalcolaNumeroPalletSagomeSpedizioneArgs calcolaNumeroPalletSagomeSpedizioneArgs = new CalcolaNumeroPalletSagomeSpedizioneArgs();
					calcolaNumeroPalletSagomeSpedizioneArgs.InSpedizioneCodice = _InputInfo["ViaggioCodice"].ToString();
					text2 = "IDVIAGGIO=" + calcolaNumeroPalletSagomeSpedizioneArgs.InSpedizioneCodice;
					this.WriteLog(text2);
					Result result = _WMSService.CalcolaNumeroPalletSagomeSpedizione(sender, calcolaNumeroPalletSagomeSpedizioneArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CalcolaNumeroPalletSagome:
				{
					CalcolaNumeroPalletSagomeArgs calcolaNumeroPalletSagomeArgs = new CalcolaNumeroPalletSagomeArgs();
					calcolaNumeroPalletSagomeArgs.InBatchCodice = _InputInfo["BatchCodice"].ToString();
					text2 = "IDBATCH=" + calcolaNumeroPalletSagomeArgs.InBatchCodice;
					this.WriteLog(text2);
					Result result = _WMSService.CalcolaNumeroPalletSagome(sender, calcolaNumeroPalletSagomeArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CreazioneBatch:
				{
					CreazioneBatchArgs creazioneBatchArgs = new CreazioneBatchArgs();
					creazioneBatchArgs.InBatch = new Batch();
					Batch inBatch3 = creazioneBatchArgs.InBatch;
					inBatch3.Codice = _InputInfo["BatchCodice"].ToString();
					inBatch3.DataeOraPreparazione = Conversions.ToDate(_InputInfo["BatchDataOraPreparazione"]);
					inBatch3.DescrizioneBatch = _InputInfo["BatchDescrizione"].ToString();
					inBatch3.DescrizioneZonaSpedizione = _InputInfo["BatchZonaSpedizioneDescrizione"].ToString();
					inBatch3.Tipologia = _InputInfo["BatchTipo"].ToString();
					inBatch3.ZonaSpedizione = _InputInfo["BatchZonaSpedizione"].ToString();
					if (Operators.CompareString(inBatch3.DescrizioneBatch, "", false) == 0)
					{
						inBatch3.DescrizioneBatch = inBatch3.ZonaSpedizione + "-" + inBatch3.DataeOraPreparazione.ToString("dd/MM/yyyy");
					}
					text2 = "IDBATCH=" + inBatch3.Codice + ";ZONA=" + inBatch3.ZonaSpedizione + ";TIPO=" + inBatch3.Tipologia + ";DATA=" + inBatch3.DataeOraPreparazione.ToString("dd/MM/yyyy");
					this.WriteLog(text2);
					inBatch3 = null;
					Result result = _WMSService.CreazioneBatch(sender, creazioneBatchArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.DisassociaSpedizioneABatch:
				{
					AggregazioneOrdineBatchArgs aggregazioneOrdineBatchArgs2 = new AggregazioneOrdineBatchArgs();
					Batch inBatch2 = aggregazioneOrdineBatchArgs2.InBatch;
					inBatch2.Codice = _InputInfo["BatchCodice"].ToString();
					inBatch2 = null;
					TestataOrdine inOrdine7 = aggregazioneOrdineBatchArgs2.InOrdine;
					inOrdine7.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine7.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine7.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine7 = null;
					text2 = "COMMITTENTE=" + aggregazioneOrdineBatchArgs2.InOrdine.Committente + ";DATA=" + aggregazioneOrdineBatchArgs2.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + aggregazioneOrdineBatchArgs2.InOrdine.Ordine + ";IDBATCH=" + aggregazioneOrdineBatchArgs2.InBatch.Codice;
					this.WriteLog(text2);
					Result result = _WMSService.DeAggregazioneOrdineBatch(sender, aggregazioneOrdineBatchArgs2);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.AggiornaQuantitaSpedizione:
				{
					GetInfoOrdineArgs args = new GetInfoOrdineArgs();
					args.Ordine = new TestataOrdine();
					TestataOrdine ordine = args.Ordine;
					ordine.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					ordine.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					ordine.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					text2 = "COMMITTENTE=" + ordine.Committente + ";DATA=" + ordine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + ordine.Ordine;
					this.WriteLog(text2);
					ordine = null;
					Result result = _WMSService.GetInfoOrdine(sender, ref args);
					if (result.Good)
					{
						_OutputInfo.Add("Colli", args.Ordine.Colli);
						_OutputInfo.Add("Pallet", args.Ordine.Pallet);
						if (Operators.CompareString(WMSMessageConfig.WmsUMPeso, "KG", false) == 0)
						{
							_OutputInfo.Add("Peso", args.Ordine.Peso);
						}
						else
						{
							Dictionary<string, object> outputInfo = _OutputInfo;
							decimal d = 1000m;
							decimal? peso = args.Ordine.Peso;
							decimal? obj;
							if (!peso.HasValue)
							{
								obj = null;
							}
							else
							{
								decimal? num2 = decimal.Divide(peso.GetValueOrDefault(), d);
								obj = num2;
							}
							outputInfo.Add("Peso", obj);
						}
						if (Operators.CompareString(WMSMessageConfig.WmsUMVolume, "M3", false) == 0)
						{
							_OutputInfo.Add("Volume", args.Ordine.Volume);
						}
						else
						{
							Dictionary<string, object> outputInfo2 = _OutputInfo;
							decimal d = 1000000m;
							decimal? num2 = args.Ordine.Volume;
							decimal? obj2;
							if (!num2.HasValue)
							{
								obj2 = null;
							}
							else
							{
								decimal? peso = decimal.Divide(num2.GetValueOrDefault(), d);
								obj2 = peso;
							}
							outputInfo2.Add("Volume", obj2);
						}
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.AssociaSpedizioneALinea:
				{
					AssociaOrdineALineaArgs associaOrdineALineaArgs2 = new AssociaOrdineALineaArgs();
					associaOrdineALineaArgs2.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine6 = associaOrdineALineaArgs2.InOrdine;
					inOrdine6.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine6.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine6.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					inOrdine6 = null;
					associaOrdineALineaArgs2.InLinea = new Linea();
					Linea inLinea = associaOrdineALineaArgs2.InLinea;
					inLinea.Giro = _InputInfo["Giro"].ToString();
					inLinea.Codice = Conversions.ToInteger(_InputInfo["IdLinea"]);
					inLinea.DataPreparazione = Conversions.ToDate(_InputInfo["DataLinea"]);
					inLinea = null;
					text2 = "COMMITTENTE=" + associaOrdineALineaArgs2.InOrdine.Committente + ";DATA=" + associaOrdineALineaArgs2.InOrdine.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + associaOrdineALineaArgs2.InOrdine.Ordine + ";IDLINEA=" + Conversions.ToString(associaOrdineALineaArgs2.InLinea.Codice) + ";GIRO=" + associaOrdineALineaArgs2.InLinea.Giro + ";DATAPREP=" + associaOrdineALineaArgs2.InLinea.DataPreparazione.ToString("dd/MM/yyyy HH:mm");
					this.WriteLog(text2);
					Result result = _WMSService.AssociaOrdineALinea(sender, associaOrdineALineaArgs2);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.DisassociaSpedizioneALinea:
				{
					AssociaOrdineALineaArgs associaOrdineALineaArgs = new AssociaOrdineALineaArgs();
					associaOrdineALineaArgs.InOrdine = new TestataOrdine();
					TestataOrdine inOrdine5 = associaOrdineALineaArgs.InOrdine;
					inOrdine5.Committente = _InputInfo["SpedizioneCommittente"].ToString();
					inOrdine5.Data = Conversions.ToDate(_InputInfo["SpedizioneData"]);
					inOrdine5.Ordine = _InputInfo["SpedizioneOrdine"].ToString();
					text2 = "COMMITTENTE=" + inOrdine5.Committente + ";DATA=" + inOrdine5.Data.ToString("dd/MM/yyyy") + ";ORDINE=" + inOrdine5.Ordine;
					this.WriteLog(text2);
					inOrdine5 = null;
					Result result = _WMSService.DeAssociaOrdineDaLinea(sender, associaOrdineALineaArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.CreaViaggio_AssociaSpedizioniAViaggio:
				{
					AssociaOrdiniASpedizioneArgs associaOrdiniASpedizioneArgs = new AssociaOrdiniASpedizioneArgs();
					associaOrdiniASpedizioneArgs.InSpedizione = new Spedizione();
					Dictionary<string, object> dictionary = (Dictionary<string, object>)_InputInfo["OggettoViaggio"];
					Spedizione inSpedizione3 = associaOrdiniASpedizioneArgs.InSpedizione;
					inSpedizione3.AltezzaMezzo = Conversions.ToInteger(dictionary["ViaggioAltezzaMezzo"]);
					inSpedizione3.Codice = dictionary["ViaggioCodice"].ToString();
					inSpedizione3.DataRiferimento = Conversions.ToDate(dictionary["ViaggioDataRiferimento"]);
					inSpedizione3.Vettore = dictionary["ViaggioVettore"].ToString();
					text2 = "IDVIAGGIO=" + inSpedizione3.Codice + ";ORDINE=";
					inSpedizione3 = null;
					List<Dictionary<string, object>> list3 = (List<Dictionary<string, object>>)_InputInfo["OrdiniListObject"];
					List<TestataOrdine> list4 = new List<TestataOrdine>();
					foreach (Dictionary<string, object> item in list3)
					{
						TestataOrdine testataOrdine3 = new TestataOrdine();
						TestataOrdine testataOrdine4 = testataOrdine3;
						testataOrdine4.Committente = item["SpedizioneCommittente"].ToString();
						testataOrdine4.Data = Conversions.ToDate(item["SpedizioneData"]);
						testataOrdine4.Ordine = item["SpedizioneOrdine"].ToString();
						testataOrdine4.InSequenzaConsegna = Conversions.ToInteger(item["SequenzaConsegna"]);
						text2 = text2 + testataOrdine4.Ordine + ",";
						testataOrdine4 = null;
						list4.Add(testataOrdine3);
					}
					associaOrdiniASpedizioneArgs.InOrdini = list4.ToArray();
					this.WriteLog(text2);
					Result result = _WMSService.AssociaOrdiniASpedizione(sender, associaOrdiniASpedizioneArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				case WMSMessageType.RichiesteVolumetrichePerRaggruppamentoOrdini:
				{
					RaggruppamentoOrdiniArgs raggruppamentoOrdiniArgs = new RaggruppamentoOrdiniArgs();
					raggruppamentoOrdiniArgs.CodiceRaggruppamento = _InputInfo["IdRaggruppamentoOrdini"].ToString();
					int num = Convert.ToInt32(decimal.Multiply(Conversions.ToDecimal(_InputInfo["ViaggioAltezzaMezzo"]), 100m));
					if (num > 0)
					{
						raggruppamentoOrdiniArgs.AltezzaMezzo = num;
					}
					List<Dictionary<string, object>> list = (List<Dictionary<string, object>>)_InputInfo["OrdiniListObject"];
					List<TestataOrdine> list2 = new List<TestataOrdine>();
					text2 = "ORDINI=";
					foreach (Dictionary<string, object> item2 in list)
					{
						TestataOrdine testataOrdine = new TestataOrdine();
						TestataOrdine testataOrdine2 = testataOrdine;
						testataOrdine2.Committente = item2["SpedizioneCommittente"].ToString();
						testataOrdine2.Data = Conversions.ToDate(item2["SpedizioneData"]);
						testataOrdine2.Ordine = item2["SpedizioneOrdine"].ToString();
						text2 = text2 + testataOrdine2.Ordine + ",";
						testataOrdine2 = null;
						list2.Add(testataOrdine);
					}
					raggruppamentoOrdiniArgs.InOrdini = list2.ToArray();
					this.WriteLog(text2);
					Result result = _WMSService.RichiesteVolumetrichePerRaggruppamentoOrdini(sender, raggruppamentoOrdiniArgs);
					if (result.Good)
					{
						goto default;
					}
					rsmess = this.TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", new string[2]
					{
						_WMSMessageType.ToString(),
						result.Reason
					});
					goto end_IL_000a;
				}
				default:
					this.WriteLog("AFTER " + _WMSMessageType.ToString() + ": OK");
					break;
				}
			}
			val2 = (FXRETURN)0;
			end_IL_000a:;
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
			if ((int)val2 != 0 && Operators.CompareString(rsmess, "", false) != 0)
			{
				this.WriteLog("AFTER " + _WMSMessageType.ToString() + ": " + rsmess);
			}
			try
			{
				if (_WMSService != null)
				{
					((ClientBase<IwmsServiceForTMS>)_WMSService).Close();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			this.CallStackRemove();
			result2 = val2;
		}
		return result2;
	}
}
