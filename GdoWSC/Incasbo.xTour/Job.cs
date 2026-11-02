using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class Job : TransientVO
{
	private JobProgress progressField;

	private int elapsedTimeField;

	private string idField;

	private JobStatus statusField;

	[XmlElement(IsNullable = true, Order = 0)]
	public JobProgress progress
	{
		get
		{
			return progressField;
		}
		set
		{
			progressField = value;
			RaisePropertyChanged("progress");
		}
	}

	[XmlAttribute]
	public int elapsedTime
	{
		get
		{
			return elapsedTimeField;
		}
		set
		{
			elapsedTimeField = value;
			RaisePropertyChanged("elapsedTime");
		}
	}

	[XmlAttribute]
	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
		}
	}

	[XmlAttribute]
	public JobStatus status
	{
		get
		{
			return statusField;
		}
		set
		{
			statusField = value;
			RaisePropertyChanged("status");
		}
	}
}
