using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class UrbanManoeuvre : TransientVO
{
	private int additionalUrbanIdxField;

	private bool additionalUrbanIdxFieldSpecified;

	private int urbanIdxField;

	[XmlAttribute]
	public int additionalUrbanIdx
	{
		get
		{
			return additionalUrbanIdxField;
		}
		set
		{
			additionalUrbanIdxField = value;
			RaisePropertyChanged("additionalUrbanIdx");
		}
	}

	[XmlIgnore]
	public bool additionalUrbanIdxSpecified
	{
		get
		{
			return additionalUrbanIdxFieldSpecified;
		}
		set
		{
			additionalUrbanIdxFieldSpecified = value;
			RaisePropertyChanged("additionalUrbanIdxSpecified");
		}
	}

	[XmlAttribute]
	public int urbanIdx
	{
		get
		{
			return urbanIdxField;
		}
		set
		{
			urbanIdxField = value;
			RaisePropertyChanged("urbanIdx");
		}
	}
}
