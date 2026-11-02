using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class CalcoloKmETempiArgsIn
{
	[DataMember]
	public List<Map_GPSPoint> GPSPoints;

	[DataMember]
	public Map_RoutingOptions RoutingOptions;
}
