using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class SortOption : TransientVO
{
	private ResultField fieldField;

	private SortOrder orderField;

	[XmlAttribute]
	public ResultField field
	{
		get
		{
			return fieldField;
		}
		set
		{
			fieldField = value;
			RaisePropertyChanged("field");
		}
	}

	[XmlAttribute]
	public SortOrder order
	{
		get
		{
			return orderField;
		}
		set
		{
			orderField = value;
			RaisePropertyChanged("order");
		}
	}
}
