using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Map_RoutingOptions
{
	[DataMember]
	public int? Optimization;

	[DataMember]
	public int? Avoid_TollRoads;

	[DataMember]
	public int? Avoid_Highways;

	[DataMember]
	public int? Avoid_Ferries;

	[DataMember]
	public int? Avoid_Residents_Only;

	[DataMember]
	public int? Avoid_Urban_Areas;

	[DataMember]
	public int? Avoid_Ramps;

	[DataMember]
	public int? Avoid_VignetteRoads;

	[DataMember]
	public int? Avoid_Low_Emission_Zones;

	[DataMember]
	public string Route_Language;

	[DataMember]
	public string Speed_Profile;

	[DataMember]
	public int? TempoCaricoScarico;

	[DataMember]
	public int? MaximumDistanceToSegment;

	public Map_RoutingOptions()
	{
		Route_Language = "";
		Speed_Profile = "";
	}
}
