using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class Lines : TransientVO
{
	private LineString[] wrappedLinesField;

	private LineOptions optionsField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem(Namespace = "http://common.xserver.ptvag.com")]
	public LineString[] wrappedLines
	{
		get
		{
			return wrappedLinesField;
		}
		set
		{
			wrappedLinesField = value;
			RaisePropertyChanged("wrappedLines");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public LineOptions options
	{
		get
		{
			return optionsField;
		}
		set
		{
			optionsField = value;
			RaisePropertyChanged("options");
		}
	}
}
