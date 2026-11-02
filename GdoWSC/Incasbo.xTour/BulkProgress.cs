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
public class BulkProgress : JobProgress
{
	private int failedField;

	private int remainingField;

	private int successfulField;

	[XmlAttribute]
	public int failed
	{
		get
		{
			return failedField;
		}
		set
		{
			failedField = value;
			RaisePropertyChanged("failed");
		}
	}

	[XmlAttribute]
	public int remaining
	{
		get
		{
			return remainingField;
		}
		set
		{
			remainingField = value;
			RaisePropertyChanged("remaining");
		}
	}

	[XmlAttribute]
	public int successful
	{
		get
		{
			return successfulField;
		}
		set
		{
			successfulField = value;
			RaisePropertyChanged("successful");
		}
	}
}
