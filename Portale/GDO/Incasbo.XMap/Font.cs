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
public class Font : TransientVO
{
	private bool boldField;

	private bool frameField;

	private bool italicField;

	private string nameField;

	private int sizeField;

	private bool underlineField;

	[XmlAttribute]
	public bool bold
	{
		get
		{
			return boldField;
		}
		set
		{
			boldField = value;
			RaisePropertyChanged("bold");
		}
	}

	[XmlAttribute]
	public bool frame
	{
		get
		{
			return frameField;
		}
		set
		{
			frameField = value;
			RaisePropertyChanged("frame");
		}
	}

	[XmlAttribute]
	public bool italic
	{
		get
		{
			return italicField;
		}
		set
		{
			italicField = value;
			RaisePropertyChanged("italic");
		}
	}

	[XmlAttribute]
	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
			RaisePropertyChanged("name");
		}
	}

	[XmlAttribute]
	public int size
	{
		get
		{
			return sizeField;
		}
		set
		{
			sizeField = value;
			RaisePropertyChanged("size");
		}
	}

	[XmlAttribute]
	public bool underline
	{
		get
		{
			return underlineField;
		}
		set
		{
			underlineField = value;
			RaisePropertyChanged("underline");
		}
	}
}
