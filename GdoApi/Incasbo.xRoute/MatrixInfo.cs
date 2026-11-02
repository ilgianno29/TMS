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
public class MatrixInfo : TransientVO
{
	private RouteInfo[] wrappedMatrixInfoField;

	[XmlArray(IsNullable = true, Order = 0)]
	public RouteInfo[] wrappedMatrixInfo
	{
		get
		{
			return wrappedMatrixInfoField;
		}
		set
		{
			wrappedMatrixInfoField = value;
			RaisePropertyChanged("wrappedMatrixInfo");
		}
	}
}
