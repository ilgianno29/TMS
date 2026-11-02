using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FeatureDescription : TransientVO
{
	private string descriptionField;

	private string themeIdField;

	private string timeDomainField;

	[XmlAttribute]
	public string description
	{
		get
		{
			return descriptionField;
		}
		set
		{
			descriptionField = value;
			RaisePropertyChanged("description");
		}
	}

	[XmlAttribute]
	public string themeId
	{
		get
		{
			return themeIdField;
		}
		set
		{
			themeIdField = value;
			RaisePropertyChanged("themeId");
		}
	}

	[XmlAttribute]
	public string timeDomain
	{
		get
		{
			return timeDomainField;
		}
		set
		{
			timeDomainField = value;
			RaisePropertyChanged("timeDomain");
		}
	}
}
