using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://baseservices.service.jabba.ptvag.com")]
public class CallerContext : TransientVO
{
	private CallerContextProperty[] wrappedPropertiesField;

	private string log1Field;

	private string log2Field;

	private string log3Field;

	[XmlArray(IsNullable = true, Order = 0)]
	public CallerContextProperty[] wrappedProperties
	{
		get
		{
			return wrappedPropertiesField;
		}
		set
		{
			wrappedPropertiesField = value;
			RaisePropertyChanged("wrappedProperties");
		}
	}

	[XmlAttribute]
	public string log1
	{
		get
		{
			return log1Field;
		}
		set
		{
			log1Field = value;
			RaisePropertyChanged("log1");
		}
	}

	[XmlAttribute]
	public string log2
	{
		get
		{
			return log2Field;
		}
		set
		{
			log2Field = value;
			RaisePropertyChanged("log2");
		}
	}

	[XmlAttribute]
	public string log3
	{
		get
		{
			return log3Field;
		}
		set
		{
			log3Field = value;
			RaisePropertyChanged("log3");
		}
	}
}
