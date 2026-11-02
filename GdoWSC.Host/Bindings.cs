using System;
using CoreWCF;
using CoreWCF.Channels;

namespace Incasbo.Web.Host;

/// <summary>
/// Binding identici a quelli del Web.config originale, cosi' i client esistenti
/// (WMS, mappe, integrazioni API) continuano a funzionare senza modifiche.
/// </summary>
public static class Bindings
{
	/// <summary>TMSServiceForWMS: wsHttpBinding "bindingConf1", security mode None.</summary>
	public static WSHttpBinding TMSServiceForWMS() => new WSHttpBinding(SecurityMode.None);

	/// <summary>TMSApiService: basicHttpBinding "bindingConf2", security mode None.</summary>
	public static BasicHttpBinding TMSApiService() => new BasicHttpBinding(BasicHttpSecurityMode.None);

	/// <summary>TMSServiceForMap: wsHttpBinding "bindingConf3", security None, timeout 10 minuti.</summary>
	public static WSHttpBinding TMSServiceForMap()
	{
		WSHttpBinding binding = new WSHttpBinding(SecurityMode.None);
		binding.ReceiveTimeout = TimeSpan.FromMinutes(10);
		binding.SendTimeout = TimeSpan.FromMinutes(10);
		return binding;
	}
}
