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
public class ExpansionDescription : TransientVO
{
	private int[] wrappedHorizonsField;

	private ExpansionType expansionTypeField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedHorizons
	{
		get
		{
			return wrappedHorizonsField;
		}
		set
		{
			wrappedHorizonsField = value;
			RaisePropertyChanged("wrappedHorizons");
		}
	}

	[XmlAttribute]
	public ExpansionType expansionType
	{
		get
		{
			return expansionTypeField;
		}
		set
		{
			expansionTypeField = value;
			RaisePropertyChanged("expansionType");
		}
	}
}
