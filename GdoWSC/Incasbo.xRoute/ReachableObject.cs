using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class ReachableObject : TransientVO
{
	private UniqueGeoID branchNodeField;

	private ReachableObjectDescr objectField;

	private RouteInfo routeInfoField;

	[XmlElement(IsNullable = true, Order = 0)]
	public UniqueGeoID branchNode
	{
		get
		{
			return branchNodeField;
		}
		set
		{
			branchNodeField = value;
			RaisePropertyChanged("branchNode");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public ReachableObjectDescr @object
	{
		get
		{
			return objectField;
		}
		set
		{
			objectField = value;
			RaisePropertyChanged("object");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public RouteInfo routeInfo
	{
		get
		{
			return routeInfoField;
		}
		set
		{
			routeInfoField = value;
			RaisePropertyChanged("routeInfo");
		}
	}
}
