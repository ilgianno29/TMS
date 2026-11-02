using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class CalcoloOttimizzatoKmETempiArgsIn
{
	[DataMember]
	public int IdViaggio;

	[DataMember]
	public Map_GPSPoint GPSPoints_Partenza;

	[DataMember]
	public List<Map_GPSPoint> GPSPoints;

	[DataMember]
	public Map_GPSPoint GPSPoints_Arrivo;

	[DataMember]
	public Map_Mezzo Veicolo;
}
