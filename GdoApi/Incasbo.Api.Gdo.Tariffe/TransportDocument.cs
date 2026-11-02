using System;
using System.Collections.Generic;
using System.Data;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class TransportDocument
{
	protected Costi _Costi;

	protected Ricavi _Ricavi;

	protected List<TransportDocument> _SubDocuments;

	public virtual string TipoDocumento { get; set; }

	public virtual string ID { get; set; }

	public virtual DateTime DataDocumento { get; set; }

	public virtual int Stato { get; set; }

	public virtual string TipoSpedizioneAttivo { get; set; }

	public virtual string TipoSpedizionePassivo { get; set; }

	public virtual string TipoMerce { get; set; }

	public virtual string TipoMezzo { get; set; }

	public virtual string Mittente { get; set; }

	public virtual string SoggettoAttivo { get; set; }

	public virtual string SoggettoFatturazioneAttiva { get; set; }

	public virtual string SoggettoPassivo { get; set; }

	public virtual string SoggettoFatturazionePassiva { get; set; }

	public virtual string PCSPartenza { get; set; }

	public virtual string GruppoTariffarioPartenza { get; set; }

	public virtual string ZonaArrivoAttiva { get; set; }

	public virtual string ZonaArrivoAttivaMacro { get; set; }

	public virtual string ZonaArrivoPassiva { get; set; }

	public virtual string ZonaArrivoPassivaMacro { get; set; }

	public virtual string PCSArrivo { get; set; }

	public virtual string GruppoTariffarioArrivo { get; set; }

	public virtual string DocumentView { get; set; }

	public virtual string DocumentTable { get; set; }

	public virtual string KeyFieldName { get; set; }

	public virtual string Cliente { get; set; }

	public virtual DateTime? DataCompentenzaAttiva { get; set; }

	public virtual bool UpdateDataCompentenzaAttiva { get; set; }

	public virtual DateTime? DataCompentenzaPassiva { get; set; }

	public virtual bool UpdateDataCompentenzaPassiva { get; set; }

	public virtual DataTable ItemDataTable { get; set; }

	public virtual string IdSubDocument { get; set; }

	public virtual List<TransportDocument> SubDocuments => _SubDocuments;

	public virtual DataRow ItemDataRow
	{
		get
		{
			if (ItemDataTable != null)
			{
				return ItemDataTable.Rows[0];
			}
			return null;
		}
	}

	public virtual decimal Peso { get; set; }

	public virtual decimal Colli { get; set; }

	public virtual decimal Pallet { get; set; }

	public virtual decimal Volume { get; set; }

	public virtual decimal TassatoAttivo { get; set; }

	public virtual decimal TassatoPassivo { get; set; }

	public virtual decimal Contrassegno { get; set; }

	public virtual decimal CampoCalcolo1 { get; set; }

	public virtual decimal CampoCalcolo2 { get; set; }

	public virtual decimal CampoCalcolo3 { get; set; }

	public virtual decimal CampoCalcolo4 { get; set; }

	public virtual decimal CampoCalcolo5 { get; set; }

	public virtual decimal CampoCalcolo6 { get; set; }

	public virtual decimal CampoCalcolo7 { get; set; }

	public virtual decimal CampoCalcolo8 { get; set; }

	public virtual decimal CampoCalcolo9 { get; set; }

	public virtual decimal CampoCalcolo10 { get; set; }

	public virtual decimal Forfait { get; set; }

	public virtual bool CalcolaTariffaAttiva { get; set; }

	public virtual bool CalcolaTariffaPassiva { get; set; }

	public virtual bool CancellaCosti { get; set; }

	public virtual bool CancellaRicavi { get; set; }

	public virtual bool AbilitaRaggruppamento { get; set; }

	public virtual int? DurataServizio { get; set; }

	public virtual int? DurataServizioAlNettoDellaFranchigia { get; set; }

	public virtual Costi CostiList => _Costi;

	public virtual Ricavi RicaviList => _Ricavi;

	public TransportDocument()
	{
		TipoDocumento = "";
		ID = "";
		TipoSpedizioneAttivo = "";
		TipoSpedizionePassivo = "";
		TipoMerce = "";
		TipoMezzo = "";
		Mittente = "";
		SoggettoAttivo = "";
		SoggettoFatturazioneAttiva = "";
		SoggettoPassivo = "";
		SoggettoFatturazionePassiva = "";
		PCSPartenza = "";
		GruppoTariffarioPartenza = "";
		ZonaArrivoAttiva = "";
		ZonaArrivoAttivaMacro = "";
		ZonaArrivoPassiva = "";
		ZonaArrivoPassivaMacro = "";
		PCSArrivo = "";
		GruppoTariffarioArrivo = "";
		DocumentView = "";
		DocumentTable = "";
		KeyFieldName = "";
		Cliente = "";
		DataCompentenzaAttiva = null;
		UpdateDataCompentenzaAttiva = false;
		DataCompentenzaPassiva = null;
		UpdateDataCompentenzaPassiva = false;
		ItemDataTable = null;
		IdSubDocument = "";
		_SubDocuments = new List<TransportDocument>();
	}
}
