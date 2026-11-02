#if !NETFRAMEWORK
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace Incasbo.ServiceModel;

/// <summary>
/// Registro degli endpoint per i client WCF/SOAP su .NET 8.
/// <para>
/// Su .NET Framework i client generati leggono indirizzo e binding dalla sezione
/// &lt;system.serviceModel&gt;&lt;client&gt; del web.config/app.config; su .NET 8 questo non e' piu'
/// possibile. Questa classe fornisce lo stesso risultato: si puo' caricare la vecchia sezione
/// con <see cref="LoadFromConfigFile"/> oppure registrare gli endpoint con <see cref="Register"/>.
/// </para>
/// Gli endpoint si cercano per nome (attributo name) e, in mancanza, per contratto
/// (attributo contract, es. "WMSService.IwmsServiceForTMS").
/// </summary>
public static class WcfEndpoints
{
	private sealed class Entry
	{
		public string Address;
		public Func<Binding> BindingFactory;
	}

	private static readonly ConcurrentDictionary<string, Entry> _byName = new ConcurrentDictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);

	private static readonly ConcurrentDictionary<string, Entry> _byContract = new ConcurrentDictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);

	/// <summary>Registra un endpoint. Se <paramref name="binding"/> e' null si usa <see cref="CreateDefaultBinding"/>.</summary>
	public static void Register(string name, string contract, string address, Func<Binding> binding = null)
	{
		if (string.IsNullOrWhiteSpace(address))
		{
			throw new ArgumentException("Indirizzo dell'endpoint mancante.", nameof(address));
		}
		Entry entry = new Entry
		{
			Address = address,
			BindingFactory = binding ?? (() => CreateDefaultBinding(new Uri(address)))
		};
		if (!string.IsNullOrWhiteSpace(name))
		{
			_byName[name] = entry;
		}
		if (!string.IsNullOrWhiteSpace(contract))
		{
			_byContract[contract] = entry;
		}
	}

	/// <summary>Rimuove tutti gli endpoint registrati (usato nei test).</summary>
	public static void Clear()
	{
		_byName.Clear();
		_byContract.Clear();
	}

	/// <summary>
	/// Carica gli endpoint dalla sezione &lt;system.serviceModel&gt; di un web.config/app.config esistente.
	/// Supporta basicHttpBinding (con security mode None/Transport e maxReceivedMessageSize, timeout).
	/// Restituisce il numero di endpoint caricati.
	/// </summary>
	public static int LoadFromConfigFile(string path)
	{
		XDocument doc = XDocument.Load(path);
		XElement serviceModel = doc.Root?.Element("system.serviceModel");
		if (serviceModel == null)
		{
			return 0;
		}
		int count = 0;
		foreach (XElement endpoint in serviceModel.Element("client")?.Elements("endpoint") ?? Enumerable.Empty<XElement>())
		{
			string address = (string)endpoint.Attribute("address");
			if (string.IsNullOrWhiteSpace(address))
			{
				continue;
			}
			string bindingType = (string)endpoint.Attribute("binding") ?? "basicHttpBinding";
			string bindingConfiguration = (string)endpoint.Attribute("bindingConfiguration");
			XElement bindingElement = serviceModel.Element("bindings")?.Element(bindingType)?.Elements("binding")
				.FirstOrDefault(b => string.Equals((string)b.Attribute("name"), bindingConfiguration, StringComparison.Ordinal));
			if (!string.Equals(bindingType, "basicHttpBinding", StringComparison.OrdinalIgnoreCase))
			{
				throw new NotSupportedException("Binding '" + bindingType + "' dell'endpoint '" + (string)endpoint.Attribute("name") + "' non supportato su .NET 8: usare WcfEndpoints.Register.");
			}
			Uri uri = new Uri(address);
			Register((string)endpoint.Attribute("name"), (string)endpoint.Attribute("contract"), address, () => CreateBasicHttpBinding(uri, bindingElement));
			count++;
		}
		return count;
	}

	/// <summary>Binding usato quando non e' specificato altro: BasicHttpBinding, con HTTPS se l'indirizzo e' https.</summary>
	public static Binding CreateDefaultBinding(Uri address)
	{
		return CreateBasicHttpBinding(address, null);
	}

	private static Binding CreateBasicHttpBinding(Uri address, XElement config)
	{
		bool https = string.Equals(address.Scheme, "https", StringComparison.OrdinalIgnoreCase);
		string securityMode = (string)config?.Element("security")?.Attribute("mode");
		BasicHttpBinding binding = new BasicHttpBinding((https || string.Equals(securityMode, "Transport", StringComparison.OrdinalIgnoreCase)) ? BasicHttpSecurityMode.Transport : BasicHttpSecurityMode.None);
		// Valori generosi: le risposte di PTV/WMS possono essere grandi
		binding.MaxReceivedMessageSize = ParseLong(config, "maxReceivedMessageSize", int.MaxValue);
		binding.MaxBufferSize = (int)Math.Min(binding.MaxReceivedMessageSize, int.MaxValue);
		binding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
		binding.OpenTimeout = ParseTime(config, "openTimeout", TimeSpan.FromMinutes(1));
		binding.CloseTimeout = ParseTime(config, "closeTimeout", TimeSpan.FromMinutes(1));
		binding.SendTimeout = ParseTime(config, "sendTimeout", TimeSpan.FromMinutes(10));
		binding.ReceiveTimeout = ParseTime(config, "receiveTimeout", TimeSpan.FromMinutes(10));
		return binding;
	}

	private static long ParseLong(XElement config, string attribute, long fallback)
	{
		string value = (string)config?.Attribute(attribute);
		return long.TryParse(value, out long result) ? result : fallback;
	}

	private static TimeSpan ParseTime(XElement config, string attribute, TimeSpan fallback)
	{
		string value = (string)config?.Attribute(attribute);
		return TimeSpan.TryParse(value, System.Globalization.CultureInfo.InvariantCulture, out TimeSpan result) ? result : fallback;
	}

	private static Entry Find(string endpointName, string contract)
	{
		if (!string.IsNullOrEmpty(endpointName) && _byName.TryGetValue(endpointName, out Entry byName))
		{
			return byName;
		}
		if (_byContract.TryGetValue(contract, out Entry byContract))
		{
			return byContract;
		}
		throw new InvalidOperationException("Endpoint WCF non configurato per '" + (endpointName ?? contract) + "'. Configurarlo con WcfEndpoints.LoadFromConfigFile o WcfEndpoints.Register.");
	}

	/// <summary>Binding per il client (cerca per nome endpoint, poi per contratto).</summary>
	public static Binding GetBinding(string endpointName, string contract)
	{
		return Find(endpointName, contract).BindingFactory();
	}

	/// <summary>Indirizzo per il client; <paramref name="remoteAddress"/>, se indicato, ha la precedenza.</summary>
	public static EndpointAddress GetAddress(string endpointName, string contract, string remoteAddress = null)
	{
		return new EndpointAddress(string.IsNullOrEmpty(remoteAddress) ? Find(endpointName, contract).Address : remoteAddress);
	}
}
#endif
