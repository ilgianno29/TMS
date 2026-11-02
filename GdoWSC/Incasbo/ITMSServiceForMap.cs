using System.ServiceModel;

namespace Incasbo;

[ServiceContract(/*Could not decode attribute arguments.*/)]
public interface ITMSServiceForMap
{
	[OperationContract]
	bool TestDBConnection(ref string rsMess);

	[OperationContract]
	string GetVersion();

	[OperationContract]
	string TestPing(string sStringa);

	[OperationContract]
	Result CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg);

	[OperationContract]
	Result CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg);
}
