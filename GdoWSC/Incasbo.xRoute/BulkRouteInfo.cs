using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
public class BulkRouteInfo : TransientVO
{
	private BulkRouteInfoResult[] wrappedBulkRouteInfoResultField;

	[XmlArray(IsNullable = true, Order = 0)]
	public BulkRouteInfoResult[] wrappedBulkRouteInfoResult
	{
		get
		{
			return wrappedBulkRouteInfoResultField;
		}
		set
		{
			wrappedBulkRouteInfoResultField = value;
			RaisePropertyChanged("wrappedBulkRouteInfoResult");
		}
	}
}
