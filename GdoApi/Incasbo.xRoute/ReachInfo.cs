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
public class ReachInfo : TransientVO
{
	private UniqueGeoID branchNodeField;

	private RouteInfo routeInfoField;

	private bool reachableField;

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

	[XmlAttribute]
	public bool reachable
	{
		get
		{
			return reachableField;
		}
		set
		{
			reachableField = value;
			RaisePropertyChanged("reachable");
		}
	}
}
