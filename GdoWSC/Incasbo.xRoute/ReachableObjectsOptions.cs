using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class ReachableObjectsOptions : TransientVO
{
	private ReachableObjectDescr[] wrappedAdditionalObjectsField;

	private ExpansionDescription expansionDescField;

	private int boundingBoxCountField;

	private bool boundingBoxCountFieldSpecified;

	private string geodatasourceLayerField;

	private LinkType linkTypeField;

	private RoutingDirectionType routingDirectionField;

	[XmlArray(IsNullable = true, Order = 0)]
	public ReachableObjectDescr[] wrappedAdditionalObjects
	{
		get
		{
			return wrappedAdditionalObjectsField;
		}
		set
		{
			wrappedAdditionalObjectsField = value;
			RaisePropertyChanged("wrappedAdditionalObjects");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public ExpansionDescription expansionDesc
	{
		get
		{
			return expansionDescField;
		}
		set
		{
			expansionDescField = value;
			RaisePropertyChanged("expansionDesc");
		}
	}

	[XmlAttribute]
	public int boundingBoxCount
	{
		get
		{
			return boundingBoxCountField;
		}
		set
		{
			boundingBoxCountField = value;
			RaisePropertyChanged("boundingBoxCount");
		}
	}

	[XmlIgnore]
	public bool boundingBoxCountSpecified
	{
		get
		{
			return boundingBoxCountFieldSpecified;
		}
		set
		{
			boundingBoxCountFieldSpecified = value;
			RaisePropertyChanged("boundingBoxCountSpecified");
		}
	}

	[XmlAttribute]
	public string geodatasourceLayer
	{
		get
		{
			return geodatasourceLayerField;
		}
		set
		{
			geodatasourceLayerField = value;
			RaisePropertyChanged("geodatasourceLayer");
		}
	}

	[XmlAttribute]
	public LinkType linkType
	{
		get
		{
			return linkTypeField;
		}
		set
		{
			linkTypeField = value;
			RaisePropertyChanged("linkType");
		}
	}

	[XmlAttribute]
	public RoutingDirectionType routingDirection
	{
		get
		{
			return routingDirectionField;
		}
		set
		{
			routingDirectionField = value;
			RaisePropertyChanged("routingDirection");
		}
	}
}
