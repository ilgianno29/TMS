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
public class SearchOption : SearchOptionBase
{
	private SearchParameter paramField;

	[XmlAttribute]
	public SearchParameter param
	{
		get
		{
			return paramField;
		}
		set
		{
			paramField = value;
			RaisePropertyChanged("param");
		}
	}
}
