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
public class ExpansionDescription : TransientVO
{
	private int[] wrappedHorizonsField;

	private ExpansionType expansionTypeField;

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
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
