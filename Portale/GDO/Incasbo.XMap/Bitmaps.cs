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
public class Bitmaps : TransientVO
{
	private BasicBitmap[] wrappedBitmapsField;

	private BitmapOptions optionsField;

	[XmlArray(IsNullable = true, Order = 0)]
	public BasicBitmap[] wrappedBitmaps
	{
		get
		{
			return wrappedBitmapsField;
		}
		set
		{
			wrappedBitmapsField = value;
			RaisePropertyChanged("wrappedBitmaps");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public BitmapOptions options
	{
		get
		{
			return optionsField;
		}
		set
		{
			optionsField = value;
			RaisePropertyChanged("options");
		}
	}
}
