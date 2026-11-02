using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class WMS_RaggruppamentiOrdiniArgs
{
	[DataMember]
	public List<WMS_RaggruppamentoOrdiniArgs> Raggruppamenti;
}
