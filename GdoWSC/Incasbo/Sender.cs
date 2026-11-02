using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Sender
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public string Password { get; set; }

	[DataMember]
	public ProfileEnum Profile { get; set; }

	public Sender()
	{
		string name = "";
		Name = name;
		name = "";
		Password = name;
		ProfileEnum profile = ProfileEnum.Batch;
		Profile = profile;
	}
}
