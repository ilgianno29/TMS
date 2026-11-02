using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class DistanceMatrixProgress : JobProgress
{
	private int currentRowIndexField;

	private int lastRowIndexField;

	[XmlAttribute]
	public int currentRowIndex
	{
		get
		{
			return currentRowIndexField;
		}
		set
		{
			currentRowIndexField = value;
			RaisePropertyChanged("currentRowIndex");
		}
	}

	[XmlAttribute]
	public int lastRowIndex
	{
		get
		{
			return lastRowIndexField;
		}
		set
		{
			lastRowIndexField = value;
			RaisePropertyChanged("lastRowIndex");
		}
	}
}
