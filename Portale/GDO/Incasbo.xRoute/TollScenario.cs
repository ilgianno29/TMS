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
public class TollScenario : TransientVO
{
	private int iuCodeField;

	private int scenarioIdField;

	[XmlAttribute]
	public int iuCode
	{
		get
		{
			return iuCodeField;
		}
		set
		{
			iuCodeField = value;
			RaisePropertyChanged("iuCode");
		}
	}

	[XmlAttribute]
	public int scenarioId
	{
		get
		{
			return scenarioIdField;
		}
		set
		{
			scenarioIdField = value;
			RaisePropertyChanged("scenarioId");
		}
	}
}
