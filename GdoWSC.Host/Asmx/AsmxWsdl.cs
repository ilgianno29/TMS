using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Incasbo.Web.Host.Asmx;

/// <summary>WSDL nello stesso stile di quello generato da ASMX (document/literal, SOAP 1.1 e 1.2).</summary>
public static class AsmxWsdl
{
	private static readonly Dictionary<Type, string> XsdTypes = new Dictionary<Type, string>
	{
		[typeof(string)] = "s:string",
		[typeof(bool)] = "s:boolean",
		[typeof(int)] = "s:int",
		[typeof(long)] = "s:long",
		[typeof(short)] = "s:short",
		[typeof(decimal)] = "s:decimal",
		[typeof(double)] = "s:double",
		[typeof(float)] = "s:float",
		[typeof(DateTime)] = "s:dateTime",
		[typeof(Guid)] = "s1:guid"
	};

	public static string Generate(AsmxServiceDescription service, string location)
	{
		XmlWriterSettings settings = new XmlWriterSettings { Indent = true, Encoding = new UTF8Encoding(false) };
		StringBuilder sb = new StringBuilder();
		using (XmlWriter w = XmlWriter.Create(sb, settings))
		{
			const string wsdl = "http://schemas.xmlsoap.org/wsdl/";
			string tns = service.Namespace;
			w.WriteStartElement("wsdl", "definitions", wsdl);
			w.WriteAttributeString("xmlns", "soap", null, "http://schemas.xmlsoap.org/wsdl/soap/");
			w.WriteAttributeString("xmlns", "soap12", null, "http://schemas.xmlsoap.org/wsdl/soap12/");
			w.WriteAttributeString("xmlns", "s", null, "http://www.w3.org/2001/XMLSchema");
			w.WriteAttributeString("xmlns", "tns", null, tns);
			w.WriteAttributeString("targetNamespace", tns);

			// types
			w.WriteStartElement("wsdl", "types", wsdl);
			w.WriteStartElement("s", "schema", "http://www.w3.org/2001/XMLSchema");
			w.WriteAttributeString("elementFormDefault", "qualified");
			w.WriteAttributeString("targetNamespace", tns);
			foreach (AsmxServiceDescription.Operation op in service.Operations.Values)
			{
				WriteElement(w, op.Name, op.Parameters, null, null);
				WriteElement(w, op.Name + "Response", op.OutParameters, op.ReturnType == typeof(void) ? null : op.Name + "Result", op.ReturnType);
			}
			w.WriteEndElement();
			w.WriteEndElement();

			// messages
			foreach (AsmxServiceDescription.Operation op in service.Operations.Values)
			{
				foreach (string suffix in new[] { "SoapIn", "SoapOut" })
				{
					w.WriteStartElement("wsdl", "message", wsdl);
					w.WriteAttributeString("name", op.Name + suffix);
					w.WriteStartElement("wsdl", "part", wsdl);
					w.WriteAttributeString("name", "parameters");
					w.WriteAttributeString("element", "tns:" + op.Name + (suffix == "SoapIn" ? "" : "Response"));
					w.WriteEndElement();
					w.WriteEndElement();
				}
			}

			// portType
			w.WriteStartElement("wsdl", "portType", wsdl);
			w.WriteAttributeString("name", service.Name + "Soap");
			foreach (AsmxServiceDescription.Operation op in service.Operations.Values)
			{
				w.WriteStartElement("wsdl", "operation", wsdl);
				w.WriteAttributeString("name", op.Name);
				if (!string.IsNullOrEmpty(op.Description))
				{
					w.WriteElementString("wsdl", "documentation", wsdl, op.Description);
				}
				w.WriteStartElement("wsdl", "input", wsdl);
				w.WriteAttributeString("message", "tns:" + op.Name + "SoapIn");
				w.WriteEndElement();
				w.WriteStartElement("wsdl", "output", wsdl);
				w.WriteAttributeString("message", "tns:" + op.Name + "SoapOut");
				w.WriteEndElement();
				w.WriteEndElement();
			}
			w.WriteEndElement();

			// bindings SOAP 1.1 e 1.2
			foreach ((string suffix, string prefix, string ns) in new[] { ("Soap", "soap", "http://schemas.xmlsoap.org/wsdl/soap/"), ("Soap12", "soap12", "http://schemas.xmlsoap.org/wsdl/soap12/") })
			{
				w.WriteStartElement("wsdl", "binding", wsdl);
				w.WriteAttributeString("name", service.Name + suffix);
				w.WriteAttributeString("type", "tns:" + service.Name + "Soap");
				w.WriteStartElement(prefix, "binding", ns);
				w.WriteAttributeString("transport", "http://schemas.xmlsoap.org/soap/http");
				w.WriteEndElement();
				foreach (AsmxServiceDescription.Operation op in service.Operations.Values)
				{
					w.WriteStartElement("wsdl", "operation", wsdl);
					w.WriteAttributeString("name", op.Name);
					w.WriteStartElement(prefix, "operation", ns);
					w.WriteAttributeString("soapAction", service.SoapAction(op.Name));
					w.WriteAttributeString("style", "document");
					w.WriteEndElement();
					foreach (string io in new[] { "input", "output" })
					{
						w.WriteStartElement("wsdl", io, wsdl);
						w.WriteStartElement(prefix, "body", ns);
						w.WriteAttributeString("use", "literal");
						w.WriteEndElement();
						w.WriteEndElement();
					}
					w.WriteEndElement();
				}
				w.WriteEndElement();
			}

			// service
			w.WriteStartElement("wsdl", "service", wsdl);
			w.WriteAttributeString("name", service.Name);
			foreach ((string suffix, string prefix, string ns) in new[] { ("Soap", "soap", "http://schemas.xmlsoap.org/wsdl/soap/"), ("Soap12", "soap12", "http://schemas.xmlsoap.org/wsdl/soap12/") })
			{
				w.WriteStartElement("wsdl", "port", wsdl);
				w.WriteAttributeString("name", service.Name + suffix);
				w.WriteAttributeString("binding", "tns:" + service.Name + suffix);
				w.WriteStartElement(prefix, "address", ns);
				w.WriteAttributeString("location", location);
				w.WriteEndElement();
				w.WriteEndElement();
			}
			w.WriteEndElement();
			w.WriteEndElement();
		}
		return sb.ToString();
	}

	private static void WriteElement(XmlWriter w, string name, System.Reflection.ParameterInfo[] parameters, string resultName, Type resultType)
	{
		w.WriteStartElement("s", "element", "http://www.w3.org/2001/XMLSchema");
		w.WriteAttributeString("name", name);
		w.WriteStartElement("s", "complexType", "http://www.w3.org/2001/XMLSchema");
		w.WriteStartElement("s", "sequence", "http://www.w3.org/2001/XMLSchema");
		if (resultName != null)
		{
			WriteParticle(w, resultName, resultType);
		}
		foreach (System.Reflection.ParameterInfo p in parameters)
		{
			WriteParticle(w, p.Name, p.ParameterType.IsByRef ? p.ParameterType.GetElementType() : p.ParameterType);
		}
		w.WriteEndElement();
		w.WriteEndElement();
		w.WriteEndElement();
	}

	private static void WriteParticle(XmlWriter w, string name, Type type)
	{
		w.WriteStartElement("s", "element", "http://www.w3.org/2001/XMLSchema");
		// Come XmlSerializer: i tipi valore sono obbligatori, i riferimenti (string) facoltativi
		w.WriteAttributeString("minOccurs", type.IsValueType ? "1" : "0");
		w.WriteAttributeString("maxOccurs", "1");
		w.WriteAttributeString("name", name);
		w.WriteAttributeString("type", XsdTypes.TryGetValue(type, out string xsd) ? xsd : "s:string");
		w.WriteEndElement();
	}
}
