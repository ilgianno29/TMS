using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioPartenzaFineArgs : Api_ViaggioArgs
{
	[DataMember]
	public DateTime? DataPartenzaEffettiva { get; set; }

	[DataMember]
	public DateTime? DataArrivoEffettiva { get; set; }

	[DataMember]
	public string AutistaEffettivo { get; set; }

	[DataMember]
	public string MotriceEffettivo { get; set; }

	[DataMember]
	public string RimorchioEffettivo { get; set; }

	[DataMember]
	public string ContenitoreEffettivo { get; set; }

	[DataMember]
	public string PCSPartenzaEffettivo { get; set; }

	[DataMember]
	public string PCSArrivoEffettivo { get; set; }

	[DataMember]
	public string Terminale { get; set; }

	[DataMember]
	public decimal? KmManuali { get; set; }

	[DataMember]
	public decimal? KmGPS { get; set; }

	[DataMember]
	public DateTime? DataGPS { get; set; }

	[DataMember]
	public string Latitudine { get; set; }

	[DataMember]
	public string Longitudine { get; set; }

	[DataMember]
	public string Localita { get; set; }

	[DataMember]
	public string Indirizzo { get; set; }

	[DataMember]
	public string Cap { get; set; }

	[DataMember]
	public string Provincia { get; set; }

	[DataMember]
	public string Nazione { get; set; }

	public Api_ViaggioPartenzaFineArgs()
	{
		string autistaEffettivo = "";
		AutistaEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		MotriceEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		RimorchioEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		ContenitoreEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		PCSPartenzaEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		PCSArrivoEffettivo = autistaEffettivo;
		autistaEffettivo = "";
		Terminale = autistaEffettivo;
		autistaEffettivo = "";
		Latitudine = autistaEffettivo;
		autistaEffettivo = "";
		Longitudine = autistaEffettivo;
		autistaEffettivo = "";
		Localita = autistaEffettivo;
		autistaEffettivo = "";
		Indirizzo = autistaEffettivo;
		autistaEffettivo = "";
		Cap = autistaEffettivo;
		autistaEffettivo = "";
		Provincia = autistaEffettivo;
		autistaEffettivo = "";
		Nazione = autistaEffettivo;
	}
}
