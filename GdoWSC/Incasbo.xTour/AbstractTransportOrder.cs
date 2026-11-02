using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(SequencingTransportOrder))]
[DebuggerStepThrough]
[XmlInclude(typeof(TransportAB))]
[XmlInclude(typeof(SequencingTransportDepot))]
[DesignerCategory("code")]
[XmlInclude(typeof(TransportDepot))]
[XmlInclude(typeof(SequencingTransportAB))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[XmlInclude(typeof(TransportOrder))]
public abstract class AbstractTransportOrder : TransientVO
{
	private int idField;

	private int priorityField;

	private bool priorityFieldSpecified;

	private int productIdField;

	private bool productIdFieldSpecified;

	[XmlAttribute]
	public int id
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
	public int priority
	{
		get
		{
			return priorityField;
		}
		set
		{
			priorityField = value;
			RaisePropertyChanged("priority");
		}
	}

	[XmlIgnore]
	public bool prioritySpecified
	{
		get
		{
			return priorityFieldSpecified;
		}
		set
		{
			priorityFieldSpecified = value;
			RaisePropertyChanged("prioritySpecified");
		}
	}

	[XmlAttribute]
	public int productId
	{
		get
		{
			return productIdField;
		}
		set
		{
			productIdField = value;
			RaisePropertyChanged("productId");
		}
	}

	[XmlIgnore]
	public bool productIdSpecified
	{
		get
		{
			return productIdFieldSpecified;
		}
		set
		{
			productIdFieldSpecified = value;
			RaisePropertyChanged("productIdSpecified");
		}
	}
}
