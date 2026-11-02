using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class MultiPoint : EncodedGeometry
{
	private PlainMultiPoint multiPointField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainMultiPoint multiPoint
	{
		get
		{
			return multiPointField;
		}
		set
		{
			multiPointField = value;
			RaisePropertyChanged("multiPoint");
		}
	}
}
