using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Incasbo.TMSServiceForMap;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class TMSServiceForMapClient : ClientBase<ITMSServiceForMap>, ITMSServiceForMap
{
	public TMSServiceForMapClient()
	{
	}

	public TMSServiceForMapClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public TMSServiceForMapClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public TMSServiceForMapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public TMSServiceForMapClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	public bool TestDBConnection(ref string rsMess)
	{
		return base.Channel.TestDBConnection(ref rsMess);
	}

	bool ITMSServiceForMap.TestDBConnection(ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestDBConnection
		return this.TestDBConnection(ref rsMess);
	}

	public string GetVersion()
	{
		return base.Channel.GetVersion();
	}

	string ITMSServiceForMap.GetVersion()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetVersion
		return this.GetVersion();
	}

	public string TestPing(string sStringa)
	{
		return base.Channel.TestPing(sStringa);
	}

	string ITMSServiceForMap.TestPing(string sStringa)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestPing
		return this.TestPing(sStringa);
	}

	public Result CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg)
	{
		return base.Channel.CalcoloKmETempi(sender, InArg, ref OutArg);
	}

	Result ITMSServiceForMap.CalcoloKmETempi(Sender sender, CalcoloKmETempiArgsIn InArg, ref CalcoloKmETempiArgsOut OutArg)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcoloKmETempi
		return this.CalcoloKmETempi(sender, InArg, ref OutArg);
	}

	public Result CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg)
	{
		return base.Channel.CalcoloOttimizzatoKmETempi_DEPOT(sender, InArg, ref OutArg);
	}

	Result ITMSServiceForMap.CalcoloOttimizzatoKmETempi_DEPOT(Sender sender, CalcoloOttimizzatoKmETempiArgsIn InArg, ref CalcoloOttimizzatoKmETempiArgsOut OutArg)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcoloOttimizzatoKmETempi_DEPOT
		return this.CalcoloOttimizzatoKmETempi_DEPOT(sender, InArg, ref OutArg);
	}
}
