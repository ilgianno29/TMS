using System;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class ActiveShippingGroupedDocumentLoader : DocumentLoader
{
	protected ShippingGroupedDocument ShippingGroupedDocument => (ShippingGroupedDocument)base.Document;

	public ActiveShippingGroupedDocumentLoader(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN _AfterLoad(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = base._AfterLoad(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ShippingGroupedDocument.IdRaggruppamento = ShippingGroupedDocument.Unibol;
				val2 = (FXRETURN)0;
			}
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

	protected override FXRETURN _SetDocument(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			base.Document.DocumentTable = "SPEDIZIONI";
			base.Document.DocumentView = "";
			base.Document.KeyFieldName = "UNIBOL";
			val2 = (FXRETURN)0;
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

	protected override FXRETURN _CustomLoad(ref DataTable dtDoc, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between Unknown and I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SpParameter[] robjParams = new SpParameter[4]
			{
				new SpParameter(),
				null,
				null,
				null
			};
			robjParams[0].DataType = SpParameterDataType.Varchar;
			robjParams[0].Direction = SpParameterDirection.In;
			robjParams[0].Name = "InIdViaggio";
			robjParams[0].Value = ShippingGroupedDocument.IdViaggio;
			robjParams[1] = new SpParameter();
			robjParams[1].DataType = SpParameterDataType.Varchar;
			robjParams[1].Direction = SpParameterDirection.In;
			robjParams[1].Name = "InCliente";
			robjParams[1].Value = "";
			robjParams[2] = new SpParameter();
			robjParams[2].DataType = SpParameterDataType.Varchar;
			robjParams[2].Direction = SpParameterDirection.In;
			robjParams[2].Name = "UnibolRaggru";
			robjParams[2].Value = ShippingGroupedDocument.Unibol;
			robjParams[3] = new SpParameter();
			robjParams[3].DataType = SpParameterDataType.Varchar;
			robjParams[3].Direction = SpParameterDirection.Out;
			robjParams[3].DataVarcharLength = 4000;
			robjParams[3].Name = "RetOut";
			robjParams[3].Value = "";
			val = ((AppBaseClass)this).DbConn.StoredProcedureExecute("TAR_ATT_DestinationGrouper", ref robjParams, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = robjParams[3].Value.ToString();
				text = text.Split(new char[1] { ';' })[0];
				string text2 = text.Split(new char[1] { '=' })[1];
				if (text2.EndsWith(","))
				{
					text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
				}
				ShippingGroupedDocument.ElencoUnibol = text2.Split(new char[1] { ',' });
				string documentQuery = GetDocumentQuery(ShippingGroupedDocument.ElencoUnibol);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(documentQuery, ref dtDoc, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					string[] elencoUnibol = ShippingGroupedDocument.ElencoUnibol;
					int num = 0;
					while (true)
					{
						if (num < elencoUnibol.Length)
						{
							string iD = elencoUnibol[num];
							ShippingDocument shippingDocument = new ShippingDocument();
							shippingDocument = new ShippingDocument();
							shippingDocument.ID = iD;
							ActiveShippingDocumentLoader activeShippingDocumentLoader = new ActiveShippingDocumentLoader(this._ApiContext);
							activeShippingDocumentLoader.Document = shippingDocument;
							val = activeShippingDocumentLoader.Load(ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
							shippingDocument = (ShippingDocument)activeShippingDocumentLoader.Document;
							ShippingGroupedDocument.ShippingDocuments.Add(shippingDocument);
							num = checked(num + 1);
							continue;
						}
						val2 = (FXRETURN)0;
						break;
					}
				}
			}
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

	protected string GetDocumentQuery(string[] Unibols)
	{
		string text = null;
		if (text == null)
		{
			text += "SELECT ";
			text += "MAX(S.Unibol) ID,";
			text += "'SPEDIZIONI_RAGGRUPPAMENTO' TipoDocumento,";
			text += "MAX(%TRUNC%(S.DATINS)) DataDocumento, ";
			text += "MAX(S.Cliente) SoggettoAttivo,";
			text += "MAX(CL.FatturaA) SoggettoFatturazioneAttiva,";
			text += "NULL SoggettoPassivo,";
			text += "NULL SoggettoFatturazionePassiva, ";
			text += "MAX(S.TipoSpedizione) TipoSpedizioneAttivo,";
			text += "MAX(ISNULL(S.TipoSpedizionePassivo,S.TipoSpedizione)) TipoSpedizionePassivo,";
			text += "'*ALL' TipoMezzo,";
			text += "MAX(S.ZonaPartenzaTariffaAttiva) ZonaPartenzaAttiva, ";
			text += "MAX(ZPA.CodiceZonaMacro) ZonaPartenzaAttivaMacro,";
			text += "MAX(S.ZonaArrivoTariffaAttiva) ZonaArrivoAttiva, ";
			text += "MAX(ZAA.CodiceZonaMacro) ZonaArrivoAttivaMacro, ";
			text += "MAX(S.ZonaPartenzaTariffaPassiva) ZonaPartenzaPassiva, ";
			text += "NULL ZonaPartenzaPassivaMacro, ";
			text += "MAX(S.ZonaArrivoTariffaPassiva) ZonaArrivoPassiva, ";
			text += "MAX(ZAP.CodiceZonaMacro) ZonaArrivoPassivaMacro, ";
			text += "MAX(S.PCSPartenza) PCSPartenza,";
			text += "MAX(PP.GruppoTariffa) GruppoTariffarioPartenza,";
			text += "MAX(S.PCSDestinazione) PCSArrivo,";
			text += "MAX(PA.GruppoTariffa) GruppoTariffarioArrivo,";
			text += "'*ALL' Cliente,";
			text += "MAX(S.DataCompetenzaAttiva) DataCompetenzaAttiva,";
			text += "MAX(S.DataCompetenzaPassiva) DataCompetenzaPassiva,";
			text += "MAX(CL.DatFat) CampoDataCompetenzaAttiva,";
			text += "NULL CampoDataCompetenzaPassiva,";
			text += "SUM(S.Peso) Peso, ";
			text += "SUM(S.Colli) Colli,";
			text += "SUM(S.Pallet) Pallet,";
			text += "SUM(S.Volume) Volume, ";
			text += "SUM(S.TassatoAttivo) TassatoAttivo,";
			text += "SUM(S.TassatoAttivo) TassatoAttivoSomma,";
			text += "SUM(S.TassatoPassivo) TassatoPassivo,";
			text += "SUM(S.TassatoPassivo) TassatoPassivoSomma, ";
			text += "SUM(S.Contrassegno) Contrassegno,";
			text += "SUM(S.CampoCalcolo1) CampoCalcolo1,";
			text += "SUM(S.CampoCalcolo2) CampoCalcolo2,";
			text += "SUM(S.CampoCalcolo3) CampoCalcolo3,";
			text += "SUM(S.CampoCalcolo4) CampoCalcolo4,";
			text += "SUM(S.CampoCalcolo5) CampoCalcolo5,";
			text += "SUM(S.CampoCalcolo6) CampoCalcolo6,";
			text += "SUM(S.CampoCalcolo7) CampoCalcolo7,";
			text += "SUM(S.CampoCalcolo8) CampoCalcolo8,";
			text += "SUM(S.CampoCalcolo9) CampoCalcolo9,";
			text += "SUM(S.CampoCalcolo10) CampoCalcolo10, ";
			text += "1 Forfait,";
			text += "'S' CalcolaTariffaAttiva, ";
			text += "'N' CancellaRicavi, ";
			text += "'S' AddebitaRicavi,";
			text += "'S' CalcolaTariffaPassiva, ";
			text += "'N' CancellaCosti, ";
			text += "'S' AccreditaCosti,";
			text += "MAX(TS.RaggruppataAttiva) RaggruppataAttiva,";
			text += "MAX(TS.RaggruppataPassiva) RaggruppataPassiva, ";
			text += "MAX(S.Unibol) Unibol,";
			text += "MAX(S.UnibolParent) UnibolParent,";
			text += "MAX(S.UnibolMaster) UnibolMaster, ";
			text += "MAX(S.Barcode) Barcode,";
			text += "MAX(S.ProgressivoConsegna) ProgressivoConsegna,";
			text += "MAX(S.Stato) Stato, ";
			text += "MAX(S.Note) Note,";
			text += "MAX(S.Prebolla) Prebolla,";
			text += "MAX(S.TipoServizio) TipoServizio, ";
			text += "MAX(S.Mittente) Mittente,";
			text += "MAX(S.MittenteRagioneSociale) MittenteRagioneSociale,";
			text += "MAX(S.ClienteFatturazione) ClienteFatturazione,";
			text += "MAX(S.NumeroBolla) NumeroBolla,";
			text += "MAX(S.DataBolla) DataBolla,";
			text += "MAX(S.NumeroOrdine) NumeroOrdine,";
			text += "MAX(S.DataOrdine) DataOrdine,";
			text += "MAX(S.NumeroOrdineCliente) NumeroOrdineCliente,";
			text += "MAX(S.DataOrdineCliente) DataOrdineCliente,";
			text += "MAX(S.TipoSpedizione) TipoSpedizione,";
			text += "MAX(S.TipoMerce) TipoMerce, ";
			text += "MAX(S.PCSDestinazione) PCSDestinazione,";
			text += "MAX(S.PCSDestinazione_RagSoc) PCSDestinazione_RagSoc,";
			text += "MAX(S.PCSDestinazione_Indirizzo) PCSDestinazione_Indirizzo,";
			text += "MAX(S.PCSDestinazione_Cap) PCSDestinazione_Cap,";
			text += "MAX(S.PCSDestinazione_Localita) PCSDestinazione_Localita,";
			text += "MAX(S.PCSDestinazione_Provincia) PCSDestinazione_Provincia,";
			text += "MAX(S.PCSDestinazione_Nazione) PCSDestinazione_Nazione,";
			text += "MAX(S.DestinazioneCliente) DestinazioneCliente,";
			text += "MAX(S.Destinatario) Destinatario,";
			text += "MAX(S.DestinatarioCliente) DestinatarioCliente,";
			text += "MAX(S.ZonaSpedizione) ZonaSpedizione,";
			text += "MAX(S.ZonaPartenzaTariffaAttiva) ZonaPartenzaTariffaAttiva,";
			text += "MAX(S.ZonaArrivoTariffaAttiva) ZonaArrivoTariffaAttiva,";
			text += "MAX(S.ZonaPartenzaTariffaPassiva) ZonaPartenzaTariffaPassiva,";
			text += "MAX(S.ZonaArrivoTariffaPassiva) ZonaArrivoTariffaPassiva,";
			text += "MAX(S.DataConsegnaPrevista1) DataConsegnaPrevista1,";
			text += "MAX(S.DataConsegnaPrevista2) DataConsegnaPrevista2,";
			text += "MAX(S.NoteConsegnaPrevista) NoteConsegnaPrevista,";
			text += "MAX(S.DataConsegnaConcordata) DataConsegnaConcordata,";
			text += "MAX(S.OraConsegnaConcordata1) OraConsegnaConcordata1,";
			text += "MAX(S.OraConsegnaConcordata2) OraConsegnaConcordata2,";
			text += "MAX(S.NoteConsegnaConcordata) NoteConsegnaConcordata,";
			text += "MAX(S.CausaleConsegnaConcordata) CausaleConsegnaConcordata,";
			text += "MAX(S.Corrispondente) Corrispondente,";
			text += "MAX(S.Trasportatore) Trasportatore,";
			text += "MAX(S.DataOraPartenzaPianificata) DataOraPartenzaPianificata,";
			text += "MAX(S.DataOraPartenzaEffettiva) DataOraPartenzaEffettiva,";
			text += "MAX(S.DataOraArrivoPianificata) DataOraArrivoPianificata,";
			text += "MAX(S.DataOraArrivoEffettiva) DataOraArrivoEffettiva,";
			text += "MAX(S.KmPianificati) KmPianificati,";
			text += "MAX(S.KmGPS) KmGPS,";
			text += "MAX(S.KmManuali) KmManuali,";
			text += "MAX(S.KmRicalcolati) KmRicalcolati,";
			text += "MAX(S.IdFatturaAttiva) IdFatturaAttiva,";
			text += "MAX(S.IdFatturaPassiva) IdFatturaPassiva,";
			text += "MAX(S.IdViaggio) IdViaggio,";
			text += "MAX(S.FillerAlfa1) FillerAlfa1,";
			text += "MAX(S.FillerAlfa2) FillerAlfa2,";
			text += "MAX(S.FillerAlfa3) FillerAlfa3,";
			text += "MAX(S.FillerAlfa4) FillerAlfa4,";
			text += "MAX(S.FillerAlfa5) FillerAlfa5,";
			text += "MAX(S.FillerAlfa6) FillerAlfa6,";
			text += "MAX(S.FillerAlfa7) FillerAlfa7,";
			text += "MAX(S.FillerAlfa8) FillerAlfa8,";
			text += "MAX(S.FillerAlfa9) FillerAlfa9,";
			text += "MAX(S.FillerAlfa10) FillerAlfa10,";
			text += "MAX(S.FillerData1) FillerData1,";
			text += "MAX(S.FillerData2) FillerData2,";
			text += "MAX(S.FillerData3) FillerData3,";
			text += "MAX(S.FillerData4) FillerData4,";
			text += "MAX(S.FillerData5) FillerData5,";
			text += "MAX(S.BatchID) BatchID,";
			text += "MAX(S.DataSpedizione) DataSpedizione,";
			text += "MAX(S.StatoWMS) StatoWMS,";
			text += "MAX(S.StatoSpuntaUscita) StatoSpuntaUscita,";
			text += "MAX(S.BloccoAmministrativo) BloccoAmministrativo,";
			text += "MAX(S.BloccaRicavi) BloccaRicavi, ";
			text += "MAX(S.BloccaCosti) BloccaCosti, ";
			text += "MAX(S.Evento_CodiceEsito) Evento_CodiceEsito,";
			text += "MAX(S.Evento_DataOraEsito) Evento_DataOraEsito,";
			text += "MAX(S.Evento_NoteInterne) Evento_NoteInterne,";
			text += "MAX(S.Evento_NoteEsterne) Evento_NoteEsterne,";
			text += "MAX(S.Evento_TipoEsito) Evento_TipoEsito,";
			text += "MAX(TS.TransitoDeposito) TransitoDeposito, ";
			text += "MAX(TS.Is_Consegna) Is_Consegna,";
			text += "MAX(TS.Is_AB) Is_AB,";
			text += "MAX(TS.Is_Reso) Is_Reso,";
			text += "MAX(TS.Is_Ritiro) Is_Ritiro, ";
			text += "%TRUNC%(%ISNULL%(MAX(V.DataPartenzaEffettiva),MAX(V.DataPartenzaPianificata))) DataViaggio, ";
			text += "'S' AbilitaRaggruppamento ";
			text += "FROM VW_SPEDIZIONI S ";
			text += "INNER JOIN PCS PP ON PP.Codice = S.PCSPartenza ";
			text += "INNER JOIN PCS PA ON PA.Codice = S.PCSDestinazione ";
			text += "LEFT JOIN Viaggi V ON V.IdViaggio=S.IdViaggio ";
			text += "LEFT JOIN Zone ZPA ON ZPA.Codice = S.ZonaPartenzaTariffaAttiva ";
			text += "LEFT JOIN Zone ZAA ON ZAA.Codice = S.ZonaArrivoTariffaAttiva ";
			text += "LEFT JOIN Zone ZAP ON ZAP.Codice = S.ZonaArrivoTariffaPassiva ";
			text += "LEFT JOIN Clienti CL ON CL.Codice=S.Cliente ";
			text += "LEFT JOIN TipiServizi TS ON TS.Codice=S.TipoServizio ";
			text += "WHERE UniBol in (%ELENCO_UNIBOL%) ";
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
		}
		if (Unibols.Count() == 0)
		{
			return "";
		}
		string text2 = "";
		foreach (string vsStringa in Unibols)
		{
			text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + " ";
		}
		text2 = text2.Trim().Replace(" ", ",");
		return text.Replace("%ELENCO_UNIBOL%", text2);
	}
}
