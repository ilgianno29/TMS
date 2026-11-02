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
public class BulkRouteInfoResult : TransientVO
{
	private RouteInfo routeInfoField;

	private ErrorCode errorCodeField;

	private string errorDescriptionField;

	[XmlElement(IsNullable = true, Order = 0)]
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
	public ErrorCode errorCode
	{
		get
		{
			return errorCodeField;
		}
		set
		{
			errorCodeField = value;
			RaisePropertyChanged("errorCode");
		}
	}

	[XmlAttribute]
	public string errorDescription
	{
		get
		{
			return errorDescriptionField;
		}
		set
		{
			errorDescriptionField = value;
			RaisePropertyChanged("errorDescription");
		}
	}
}
