using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class OrdinePrelevatoArgs : OrdineArgs
{
	[DataMember]
	public decimal PercentualeQtaPrelevata;

	public OrdinePrelevatoArgs()
	{
		PercentualeQtaPrelevata = default(decimal);
	}
}
