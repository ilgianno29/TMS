using System;
using System.Data;
using System.Linq;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class PassiveShippingGroupedDocumentLoader : DocumentLoader
{
	protected ShippingGroupedDocument ShippingGroupedDocument => (ShippingGroupedDocument)base.Document;

	public PassiveShippingGroupedDocumentLoader(AppApiContext objApiContext)
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
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SpParameter[] robjParams = new SpParameter[3]
			{
				new SpParameter(),
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
			robjParams[1].Name = "UnibolRaggru";
			robjParams[1].Value = ShippingGroupedDocument.Unibol;
			robjParams[2] = new SpParameter();
			robjParams[2].DataType = SpParameterDataType.Varchar;
			robjParams[2].Direction = SpParameterDirection.Out;
			robjParams[2].Name = "RetOut";
			robjParams[2].DataVarcharLength = 4000;
			robjParams[2].Value = "";
			val = ((AppBaseClass)this).DbConn.StoredProcedureExecute("TAR_PAS_DestinationGrouper", ref robjParams, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = robjParams[2].Value.ToString();
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
							PassiveShippingDocumentLoader passiveShippingDocumentLoader = new PassiveShippingDocumentLoader(this._ApiContext);
							passiveShippingDocumentLoader.Document = shippingDocument;
							val = passiveShippingDocumentLoader.Load(ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
							shippingDocument = (ShippingDocument)passiveShippingDocumentLoader.Document;
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
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("SELECT ");
		stringBuilder.Append("MAX(S.Unibol) ID,");
		stringBuilder.Append("'SPEDIZIONI_RAGGRUPPAMENTO' TipoDocumento,");
		stringBuilder.Append("MAX(%TRUNC%(S.DATINS)) DataDocumento, ");
		stringBuilder.Append("MAX(S.Cliente) SoggettoAttivo,");
		stringBuilder.Append("MAX(CL.FatturaA) SoggettoFatturazioneAttiva,");
		stringBuilder.Append("MAX(S.Trasportatore) SoggettoPassivo,");
		stringBuilder.Append("MAX(TR.FatturaA) SoggettoFatturazionePassiva, ");
		stringBuilder.Append("MAX(S.TipoSpedizione) TipoSpedizioneAttivo,");
		stringBuilder.Append("MAX(ISNULL(S.TipoSpedizionePassivo,S.TipoSpedizione)) TipoSpedizionePassivo,");
		stringBuilder.Append("'*ALL' TipoMezzo,");
		stringBuilder.Append("MAX(S.ZonaPartenzaTariffaAttiva) ZonaPartenzaAttiva, ");
		stringBuilder.Append("MAX(ZPA.CodiceZonaMacro) ZonaPartenzaAttivaMacro,");
		stringBuilder.Append("MAX(S.ZonaArrivoTariffaAttiva) ZonaArrivoAttiva, ");
		stringBuilder.Append("MAX(ZAA.CodiceZonaMacro) ZonaArrivoAttivaMacro, ");
		stringBuilder.Append("MAX(S.ZonaPartenzaTariffaPassiva) ZonaPartenzaPassiva, ");
		stringBuilder.Append("NULL ZonaPartenzaPassivaMacro, ");
		stringBuilder.Append("MAX(S.ZonaArrivoTariffaPassiva) ZonaArrivoPassiva, ");
		stringBuilder.Append("MAX(ZAP.CodiceZonaMacro) ZonaArrivoPassivaMacro, ");
		stringBuilder.Append("MAX(S.PCSPartenza) PCSPartenza,");
		stringBuilder.Append("MAX(PP.GruppoTariffa) GruppoTariffarioPartenza,");
		stringBuilder.Append("MAX(S.PCSDestinazione) PCSArrivo,");
		stringBuilder.Append("MAX(PA.GruppoTariffa) GruppoTariffarioArrivo,");
		stringBuilder.Append("MAX(S.Cliente) Cliente,");
		stringBuilder.Append("MAX(S.DataCompetenzaAttiva) DataCompetenzaAttiva,");
		stringBuilder.Append("MAX(S.DataCompetenzaPassiva) DataCompetenzaPassiva,");
		stringBuilder.Append("MAX(CL.DatFat) CampoDataCompetenzaAttiva,");
		stringBuilder.Append("MAX(TR.DataPerFatturazione) CampoDataCompetenzaPassiva,");
		stringBuilder.Append("SUM(S.Peso) Peso, ");
		stringBuilder.Append("SUM(S.Colli) Colli,");
		stringBuilder.Append("SUM(S.Pallet) Pallet,");
		stringBuilder.Append("SUM(S.Volume) Volume, ");
		stringBuilder.Append("SUM(S.TassatoAttivo) TassatoAttivo,");
		stringBuilder.Append("SUM(S.TassatoAttivo) TassatoAttivoSomma,");
		stringBuilder.Append("SUM(S.TassatoPassivo) TassatoPassivo,");
		stringBuilder.Append("SUM(S.TassatoPassivo) TassatoPassivoSomma, ");
		stringBuilder.Append("SUM(S.Contrassegno) Contrassegno,");
		stringBuilder.Append("SUM(S.CampoCalcolo1) CampoCalcolo1,");
		stringBuilder.Append("SUM(S.CampoCalcolo2) CampoCalcolo2,");
		stringBuilder.Append("SUM(S.CampoCalcolo3) CampoCalcolo3,");
		stringBuilder.Append("SUM(S.CampoCalcolo4) CampoCalcolo4,");
		stringBuilder.Append("SUM(S.CampoCalcolo5) CampoCalcolo5,");
		stringBuilder.Append("SUM(S.CampoCalcolo6) CampoCalcolo6,");
		stringBuilder.Append("SUM(S.CampoCalcolo7) CampoCalcolo7,");
		stringBuilder.Append("SUM(S.CampoCalcolo8) CampoCalcolo8,");
		stringBuilder.Append("SUM(S.CampoCalcolo9) CampoCalcolo9,");
		stringBuilder.Append("SUM(S.CampoCalcolo10) CampoCalcolo10, ");
		stringBuilder.Append("1 Forfait,");
		stringBuilder.Append("'S' CalcolaTariffaAttiva, ");
		stringBuilder.Append("'N' CancellaRicavi, ");
		stringBuilder.Append("'S' AddebitaRicavi,");
		stringBuilder.Append("'S' CalcolaTariffaPassiva, ");
		stringBuilder.Append("'N' CancellaCosti, ");
		stringBuilder.Append("'S' AccreditaCosti,");
		stringBuilder.Append("MAX(TS.RaggruppataAttiva) RaggruppataAttiva,");
		stringBuilder.Append("MAX(TS.RaggruppataPassiva) RaggruppataPassiva, ");
		stringBuilder.Append("MAX(S.Unibol) Unibol,");
		stringBuilder.Append("MAX(S.UnibolParent) UnibolParent,");
		stringBuilder.Append("MAX(S.UnibolMaster) UnibolMaster, ");
		stringBuilder.Append("MAX(S.Barcode) Barcode,");
		stringBuilder.Append("MAX(S.ProgressivoConsegna) ProgressivoConsegna,");
		stringBuilder.Append("MAX(S.Stato) Stato, ");
		stringBuilder.Append("MAX(S.Note) Note,");
		stringBuilder.Append("MAX(S.Prebolla) Prebolla,");
		stringBuilder.Append("MAX(S.TipoServizio) TipoServizio, ");
		stringBuilder.Append("MAX(S.Mittente) Mittente,");
		stringBuilder.Append("MAX(S.MittenteRagioneSociale) MittenteRagioneSociale,");
		stringBuilder.Append("MAX(S.ClienteFatturazione) ClienteFatturazione,");
		stringBuilder.Append("MAX(S.NumeroBolla) NumeroBolla,");
		stringBuilder.Append("MAX(S.DataBolla) DataBolla,");
		stringBuilder.Append("MAX(S.NumeroOrdine) NumeroOrdine,");
		stringBuilder.Append("MAX(S.DataOrdine) DataOrdine,");
		stringBuilder.Append("MAX(S.NumeroOrdineCliente) NumeroOrdineCliente,");
		stringBuilder.Append("MAX(S.DataOrdineCliente) DataOrdineCliente,");
		stringBuilder.Append("MAX(S.TipoSpedizione) TipoSpedizione,");
		stringBuilder.Append("MAX(S.TipoMerce) TipoMerce, ");
		stringBuilder.Append("MAX(S.PCSDestinazione) PCSDestinazione,");
		stringBuilder.Append("MAX(S.PCSDestinazione_RagSoc) PCSDestinazione_RagSoc,");
		stringBuilder.Append("MAX(S.PCSDestinazione_Indirizzo) PCSDestinazione_Indirizzo,");
		stringBuilder.Append("MAX(S.PCSDestinazione_Cap) PCSDestinazione_Cap,");
		stringBuilder.Append("MAX(S.PCSDestinazione_Localita) PCSDestinazione_Localita,");
		stringBuilder.Append("MAX(S.PCSDestinazione_Provincia) PCSDestinazione_Provincia,");
		stringBuilder.Append("MAX(S.PCSDestinazione_Nazione) PCSDestinazione_Nazione,");
		stringBuilder.Append("MAX(S.DestinazioneCliente) DestinazioneCliente,");
		stringBuilder.Append("MAX(S.Destinatario) Destinatario,");
		stringBuilder.Append("MAX(S.DestinatarioCliente) DestinatarioCliente,");
		stringBuilder.Append("MAX(S.ZonaSpedizione) ZonaSpedizione,");
		stringBuilder.Append("MAX(S.ZonaPartenzaTariffaAttiva) ZonaPartenzaTariffaAttiva,");
		stringBuilder.Append("MAX(S.ZonaArrivoTariffaAttiva) ZonaArrivoTariffaAttiva,");
		stringBuilder.Append("MAX(S.ZonaPartenzaTariffaPassiva) ZonaPartenzaTariffaPassiva,");
		stringBuilder.Append("MAX(S.ZonaArrivoTariffaPassiva) ZonaArrivoTariffaPassiva,");
		stringBuilder.Append("MAX(S.DataConsegnaPrevista1) DataConsegnaPrevista1,");
		stringBuilder.Append("MAX(S.DataConsegnaPrevista2) DataConsegnaPrevista2,");
		stringBuilder.Append("MAX(S.NoteConsegnaPrevista) NoteConsegnaPrevista,");
		stringBuilder.Append("MAX(S.DataConsegnaConcordata) DataConsegnaConcordata,");
		stringBuilder.Append("MAX(S.OraConsegnaConcordata1) OraConsegnaConcordata1,");
		stringBuilder.Append("MAX(S.OraConsegnaConcordata2) OraConsegnaConcordata2,");
		stringBuilder.Append("MAX(S.NoteConsegnaConcordata) NoteConsegnaConcordata,");
		stringBuilder.Append("MAX(S.CausaleConsegnaConcordata) CausaleConsegnaConcordata,");
		stringBuilder.Append("MAX(S.Corrispondente) Corrispondente,");
		stringBuilder.Append("MAX(S.Trasportatore) Trasportatore,");
		stringBuilder.Append("MAX(S.DataOraPartenzaPianificata) DataOraPartenzaPianificata,");
		stringBuilder.Append("MAX(S.DataOraPartenzaEffettiva) DataOraPartenzaEffettiva,");
		stringBuilder.Append("MAX(S.DataOraArrivoPianificata) DataOraArrivoPianificata,");
		stringBuilder.Append("MAX(S.DataOraArrivoEffettiva) DataOraArrivoEffettiva,");
		stringBuilder.Append("MAX(S.KmPianificati) KmPianificati,");
		stringBuilder.Append("MAX(S.KmGPS) KmGPS,");
		stringBuilder.Append("MAX(S.KmManuali) KmManuali,");
		stringBuilder.Append("MAX(S.KmRicalcolati) KmRicalcolati,");
		stringBuilder.Append("MAX(S.IdFatturaAttiva) IdFatturaAttiva,");
		stringBuilder.Append("MAX(S.IdFatturaPassiva) IdFatturaPassiva,");
		stringBuilder.Append("MAX(S.IdViaggio) IdViaggio,");
		stringBuilder.Append("MAX(S.FillerAlfa1) FillerAlfa1,");
		stringBuilder.Append("MAX(S.FillerAlfa2) FillerAlfa2,");
		stringBuilder.Append("MAX(S.FillerAlfa3) FillerAlfa3,");
		stringBuilder.Append("MAX(S.FillerAlfa4) FillerAlfa4,");
		stringBuilder.Append("MAX(S.FillerAlfa5) FillerAlfa5,");
		stringBuilder.Append("MAX(S.FillerAlfa6) FillerAlfa6,");
		stringBuilder.Append("MAX(S.FillerAlfa7) FillerAlfa7,");
		stringBuilder.Append("MAX(S.FillerAlfa8) FillerAlfa8,");
		stringBuilder.Append("MAX(S.FillerAlfa9) FillerAlfa9,");
		stringBuilder.Append("MAX(S.FillerAlfa10) FillerAlfa10,");
		stringBuilder.Append("MAX(S.FillerData1) FillerData1,");
		stringBuilder.Append("MAX(S.FillerData2) FillerData2,");
		stringBuilder.Append("MAX(S.FillerData3) FillerData3,");
		stringBuilder.Append("MAX(S.FillerData4) FillerData4,");
		stringBuilder.Append("MAX(S.FillerData5) FillerData5,");
		stringBuilder.Append("MAX(S.BatchID) BatchID,");
		stringBuilder.Append("MAX(S.DataSpedizione) DataSpedizione,");
		stringBuilder.Append("MAX(S.StatoWMS) StatoWMS,");
		stringBuilder.Append("MAX(S.StatoSpuntaUscita) StatoSpuntaUscita,");
		stringBuilder.Append("MAX(S.BloccoAmministrativo) BloccoAmministrativo,");
		stringBuilder.Append("MAX(S.BloccaRicavi) BloccaRicavi, ");
		stringBuilder.Append("MAX(S.BloccaCosti) BloccaCosti, ");
		stringBuilder.Append("MAX(S.Evento_CodiceEsito) Evento_CodiceEsito,");
		stringBuilder.Append("MAX(S.Evento_DataOraEsito) Evento_DataOraEsito,");
		stringBuilder.Append("MAX(S.Evento_NoteInterne) Evento_NoteInterne,");
		stringBuilder.Append("MAX(S.Evento_NoteEsterne) Evento_NoteEsterne,");
		stringBuilder.Append("MAX(S.Evento_TipoEsito) Evento_TipoEsito,");
		stringBuilder.Append("MAX(TS.TransitoDeposito) TransitoDeposito, ");
		stringBuilder.Append("MAX(TS.Is_Consegna) Is_Consegna,");
		stringBuilder.Append("MAX(TS.Is_AB) Is_AB,");
		stringBuilder.Append("MAX(TS.Is_Reso) Is_Reso,");
		stringBuilder.Append("MAX(TS.Is_Ritiro) Is_Ritiro, ");
		stringBuilder.Append("%TRUNC%(%ISNULL%(MAX(V.DataPartenzaEffettiva),MAX(V.DataPartenzaPianificata))) DataViaggio, ");
		stringBuilder.Append("'S' AbilitaRaggruppamento ");
		stringBuilder.Append("FROM VW_SPEDIZIONI S ");
		stringBuilder.Append("INNER JOIN PCS PP ON PP.Codice = S.PCSPartenza ");
		stringBuilder.Append("INNER JOIN PCS PA ON PA.Codice = S.PCSDestinazione ");
		stringBuilder.Append("LEFT JOIN Viaggi V ON V.IdViaggio=S.IdViaggio ");
		stringBuilder.Append("LEFT JOIN Zone ZPA ON ZPA.Codice = S.ZonaPartenzaTariffaAttiva ");
		stringBuilder.Append("LEFT JOIN Zone ZAA ON ZAA.Codice = S.ZonaArrivoTariffaAttiva ");
		stringBuilder.Append("LEFT JOIN Zone ZAP ON ZAP.Codice = S.ZonaArrivoTariffaPassiva ");
		stringBuilder.Append("LEFT JOIN Clienti CL ON CL.Codice=S.Cliente ");
		stringBuilder.Append("LEFT JOIN Trasportatori TR ON TR.Codice=S.Trasportatore ");
		stringBuilder.Append("LEFT JOIN TipiServizi TS ON TS.Codice=S.TipoServizio ");
		stringBuilder.Append("WHERE UniBol in (%ELENCO_UNIBOL%) ");
		string text = ((AppBaseClass)this).DbConn.SqlConvertForServer(stringBuilder.ToString());
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
