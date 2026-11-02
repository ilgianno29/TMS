using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Incasbo.Web.Compat;

namespace Incasbo.Web.Host.Asmx;

/// <summary>Descrizione (via reflection) dei metodi [WebMethod] di un servizio ASMX.</summary>
public sealed class AsmxServiceDescription
{
	public sealed class Operation
	{
		public string Name { get; init; }

		public string Description { get; init; }

		public MethodInfo Method { get; init; }

		public ParameterInfo[] Parameters { get; init; }

		/// <summary>Parametri ByRef: in ASMX sono sia in ingresso sia in uscita.</summary>
		public ParameterInfo[] OutParameters => Parameters.Where(p => p.ParameterType.IsByRef).ToArray();

		public Type ReturnType => Method.ReturnType;
	}

	public AsmxServiceDescription(Type serviceType)
	{
		ServiceType = serviceType;
		WebServiceAttribute ws = serviceType.GetCustomAttribute<WebServiceAttribute>(inherit: true);
		Namespace = ws?.Namespace ?? "http://tempuri.org/";
		Name = ws?.Name ?? serviceType.Name;
		Dictionary<string, Operation> operations = new Dictionary<string, Operation>(StringComparer.Ordinal);
		foreach (MethodInfo method in serviceType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
		{
			if (method.IsAbstract)
			{
				continue;
			}
			// L'attributo puo' stare sulla dichiarazione astratta/virtuale della classe base
			WebMethodAttribute attribute = (WebMethodAttribute)Attribute.GetCustomAttribute(method, typeof(WebMethodAttribute), inherit: true);
			if (attribute == null)
			{
				continue;
			}
			string name = string.IsNullOrEmpty(attribute.MessageName) ? method.Name : attribute.MessageName;
			operations[name] = new Operation
			{
				Name = name,
				Description = attribute.Description ?? "",
				Method = method,
				Parameters = method.GetParameters()
			};
		}
		Operations = operations;
	}

	public Type ServiceType { get; }

	public string Namespace { get; }

	public string Name { get; }

	public IReadOnlyDictionary<string, Operation> Operations { get; }

	/// <summary>SOAPAction di ASMX: namespace + "/" + nome del metodo.</summary>
	public string SoapAction(string operation) => Namespace + (Namespace.EndsWith("/", StringComparison.Ordinal) ? "" : "/") + operation;
}
