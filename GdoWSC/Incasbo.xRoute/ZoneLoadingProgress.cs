using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class ZoneLoadingProgress : JobProgress
{
	private string actionField;

	private int optimizationProgressField;

	[XmlAttribute]
	public string action
	{
		get
		{
			return actionField;
		}
		set
		{
			actionField = value;
			RaisePropertyChanged("action");
		}
	}

	[XmlAttribute]
	public int optimizationProgress
	{
		get
		{
			return optimizationProgressField;
		}
		set
		{
			optimizationProgressField = value;
			RaisePropertyChanged("optimizationProgress");
		}
	}
}
