using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class CorrispondenteMiglioreArgs : OrdineArgs
{
	[DataMember]
	public StringCollection ListOfCorrispondenti;

	[DataMember]
	public bool DoUpdate;

	[DataMember]
	public string CorrispondenteMigliore;

	public CorrispondenteMiglioreArgs()
	{
		ListOfCorrispondenti = null;
		DoUpdate = false;
		CorrispondenteMigliore = "";
	}
}
