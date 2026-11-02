using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsOutArgs
{
	[DataMember]
	public List<Api_Uds> ListOfUds { get; set; }

	[DataMember]
	public Api_UdsSommatorie Viaggio { get; set; }

	public Api_UdsOutArgs()
	{
		List<Api_Uds> listOfUds = null;
		ListOfUds = listOfUds;
		Api_UdsSommatorie viaggio = null;
		Viaggio = viaggio;
	}
}
