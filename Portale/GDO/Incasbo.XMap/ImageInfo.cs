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
public class ImageInfo : TransientVO
{
	private ImageFileFormat formatField;

	private int heightField;

	private string imageParameterField;

	private int widthField;

	[XmlAttribute]
	public ImageFileFormat format
	{
		get
		{
			return formatField;
		}
		set
		{
			formatField = value;
			RaisePropertyChanged("format");
		}
	}

	[XmlAttribute]
	public int height
	{
		get
		{
			return heightField;
		}
		set
		{
			heightField = value;
			RaisePropertyChanged("height");
		}
	}

	[XmlAttribute]
	public string imageParameter
	{
		get
		{
			return imageParameterField;
		}
		set
		{
			imageParameterField = value;
			RaisePropertyChanged("imageParameter");
		}
	}

	[XmlAttribute]
	public int width
	{
		get
		{
			return widthField;
		}
		set
		{
			widthField = value;
			RaisePropertyChanged("width");
		}
	}
}
