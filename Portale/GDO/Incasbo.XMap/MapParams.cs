using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class MapParams : TransientVO
{
	private string languageField;

	private string referenceTimeField;

	private bool showScaleField;

	private bool useMilesField;

	[XmlAttribute]
	public string language
	{
		get
		{
			return languageField;
		}
		set
		{
			languageField = value;
			RaisePropertyChanged("language");
		}
	}

	[XmlAttribute]
	public string referenceTime
	{
		get
		{
			return referenceTimeField;
		}
		set
		{
			referenceTimeField = value;
			RaisePropertyChanged("referenceTime");
		}
	}

	[XmlAttribute]
	public bool showScale
	{
		get
		{
			return showScaleField;
		}
		set
		{
			showScaleField = value;
			RaisePropertyChanged("showScale");
		}
	}

	[XmlAttribute]
	public bool useMiles
	{
		get
		{
			return useMilesField;
		}
		set
		{
			useMilesField = value;
			RaisePropertyChanged("useMiles");
		}
	}
}
