using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Incasbo.TMSServiceForMap;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://www.incasgroup.com/bologna/TMSServiceForMap", ConfigurationName = "TMSServiceForMap.ITMSServiceForMap")]
public interface ITMSServiceForMap
{
	[OperationContract(Action = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/TestDBConnection", ReplyAction = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/TestDBConnectionResponse")]
	bool TestDBConnection(ref string rsMess);

	[OperationContract(Action = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/GetVersion", ReplyAction = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/GetVersionResponse")]
	string GetVersion();

	[OperationContract(Action = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/TestPing", ReplyAction = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/TestPingResponse")]
	string TestPing(string sStringa);

	[OperationContract(Action = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/CalcoloKmETempi", ReplyAction = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/CalcoloKmETempiResponse")]
	Result CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg);

	[OperationContract(Action = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/CalcoloOttimizzatoKmETempi_DEPOT", ReplyAction = "http://www.incasgroup.com/bologna/TMSServiceForMap/ITMSServiceForMap/CalcoloOttimizzatoKmETempi_DEPOTResponse")]
	Result CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg);
}
