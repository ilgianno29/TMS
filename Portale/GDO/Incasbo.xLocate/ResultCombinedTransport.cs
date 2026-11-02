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
public class ResultCombinedTransport : TransientVO
{
	private AdditionalField[] wrappedCombinedTransportFieldsField;

	private CombinedTransportLocation destinationField;

	private CombinedTransportLocation startField;

	private double distanceField;

	private int durationField;

	private string idField;

	private string nameField;

	private int typeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public AdditionalField[] wrappedCombinedTransportFields
	{
		get
		{
			return wrappedCombinedTransportFieldsField;
		}
		set
		{
			wrappedCombinedTransportFieldsField = value;
			RaisePropertyChanged("wrappedCombinedTransportFields");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public CombinedTransportLocation destination
	{
		get
		{
			return destinationField;
		}
		set
		{
			destinationField = value;
			RaisePropertyChanged("destination");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public CombinedTransportLocation start
	{
		get
		{
			return startField;
		}
		set
		{
			startField = value;
			RaisePropertyChanged("start");
		}
	}

	[XmlAttribute]
	public double distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
			RaisePropertyChanged("distance");
		}
	}

	[XmlAttribute]
	public int duration
	{
		get
		{
			return durationField;
		}
		set
		{
			durationField = value;
			RaisePropertyChanged("duration");
		}
	}

	[XmlAttribute]
	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
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

	[XmlAttribute]
	public int type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
			RaisePropertyChanged("type");
		}
	}
}
