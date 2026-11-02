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
public class Interval : TransientVO
{
	private DateTime fromField;

	private bool fromFieldSpecified;

	private DateTime tillField;

	private bool tillFieldSpecified;

	[XmlAttribute]
	public DateTime from
	{
		get
		{
			return fromField;
		}
		set
		{
			fromField = value;
			RaisePropertyChanged("from");
		}
	}

	[XmlIgnore]
	public bool fromSpecified
	{
		get
		{
			return fromFieldSpecified;
		}
		set
		{
			fromFieldSpecified = value;
			RaisePropertyChanged("fromSpecified");
		}
	}

	[XmlAttribute]
	public DateTime till
	{
		get
		{
			return tillField;
		}
		set
		{
			tillField = value;
			RaisePropertyChanged("till");
		}
	}

	[XmlIgnore]
	public bool tillSpecified
	{
		get
		{
			return tillFieldSpecified;
		}
		set
		{
			tillFieldSpecified = value;
			RaisePropertyChanged("tillSpecified");
		}
	}
}
