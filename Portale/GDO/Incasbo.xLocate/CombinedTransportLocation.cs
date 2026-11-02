using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class CombinedTransportLocation : TransientVO
{
	private Point coordinateField;

	private string countryField;

	private string nameField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point coordinate
	{
		get
		{
			return coordinateField;
		}
		set
		{
			coordinateField = value;
			RaisePropertyChanged("coordinate");
		}
	}

	[XmlAttribute]
	public string country
	{
		get
		{
			return countryField;
		}
		set
		{
			countryField = value;
			RaisePropertyChanged("country");
		}
	}

	[XmlAttribute]
	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
			RaisePropertyChanged("name");
		}
	}
}
