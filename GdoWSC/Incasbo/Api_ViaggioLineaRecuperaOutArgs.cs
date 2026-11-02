using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioLineaRecuperaOutArgs
{
	[DataMember]
	public string Id { get; set; }

	[DataMember]
	public string TipoViaggio { get; set; }

	[DataMember]
	public int Stato { get; set; }

	[DataMember]
	public DateTime? DataPartenzaPianificata { get; set; }

	[DataMember]
	public string Giro { get; set; }

	[DataMember]
	public string RiferimentoEsterno { get; set; }

	[DataMember]
	public string Descrizione { get; set; }

	[DataMember]
	public string Mezzo { get; set; }

	[DataMember]
	public string TipoMezzo { get; set; }

	[DataMember]
	public string Vettore { get; set; }

	[DataMember]
	public string Autista { get; set; }

	[DataMember]
	public string TipoSpedizione { get; set; }

	[DataMember]
	public string TipoMerce { get; set; }

	[DataMember]
	public string ZonaSpedizione { get; set; }

	[DataMember]
	public string ZonaTariffaAttiva { get; set; }

	[DataMember]
	public string ZonaTariffaPassiva { get; set; }

	[DataMember]
	public string PCSPartenza { get; set; }

	[DataMember]
	public string PCSArrivo { get; set; }

	[DataMember]
	public string Note { get; set; }

	public Api_ViaggioLineaRecuperaOutArgs()
	{
		string id = "";
		Id = id;
		id = "";
		TipoViaggio = id;
		int stato = 10;
		Stato = stato;
		id = "";
		Giro = id;
		id = "";
		RiferimentoEsterno = id;
		id = "";
		Descrizione = id;
		id = "";
		Mezzo = id;
		id = "";
		TipoMezzo = id;
		id = "";
		Vettore = id;
		id = "";
		Autista = id;
		id = "";
		TipoSpedizione = id;
		id = "";
		TipoMerce = id;
		id = "";
		ZonaSpedizione = id;
		id = "";
		ZonaTariffaAttiva = id;
		id = "";
		ZonaTariffaPassiva = id;
		id = "";
		PCSPartenza = id;
		id = "";
		PCSArrivo = id;
		id = "";
		Note = id;
	}
}
