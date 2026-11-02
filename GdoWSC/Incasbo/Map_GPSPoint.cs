using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Map_GPSPoint
{
	[DataMember]
	public string Latitudine;

	[DataMember]
	public string Longitudine;

	[DataMember]
	public string Codice;

	[DataMember]
	public string IdOrdine;

	[DataMember]
	public decimal Km;

	[DataMember]
	public DateTime? DataPartenza;

	[DataMember]
	public DateTime? DataArrivo;

	[DataMember]
	public int SecondiCaricoScarico;

	[DataMember]
	public string Descrizione;

	public Map_GPSPoint()
	{
		Latitudine = "";
		Longitudine = "";
		Codice = "";
		IdOrdine = "";
		Km = default(decimal);
		SecondiCaricoScarico = 0;
		Descrizione = "";
	}
}
