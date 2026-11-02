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
public class CustomLayer : Layer
{
	private Bitmaps[] wrappedBitmapsField;

	private Lines[] wrappedLinesField;

	private Texts[] wrappedTextsField;

	private bool centerObjectsField;

	private int drawPriorityField;

	private ObjectInfoType objectInfosField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Bitmaps[] wrappedBitmaps
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

	[XmlArray(IsNullable = true, Order = 1)]
	public Lines[] wrappedLines
	{
		get
		{
			return wrappedLinesField;
		}
		set
		{
			wrappedLinesField = value;
			RaisePropertyChanged("wrappedLines");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public Texts[] wrappedTexts
	{
		get
		{
			return wrappedTextsField;
		}
		set
		{
			wrappedTextsField = value;
			RaisePropertyChanged("wrappedTexts");
		}
	}

	[XmlAttribute]
	public bool centerObjects
	{
		get
		{
			return centerObjectsField;
		}
		set
		{
			centerObjectsField = value;
			RaisePropertyChanged("centerObjects");
		}
	}

	[XmlAttribute]
	public int drawPriority
	{
		get
		{
			return drawPriorityField;
		}
		set
		{
			drawPriorityField = value;
			RaisePropertyChanged("drawPriority");
		}
	}

	[XmlAttribute]
	public ObjectInfoType objectInfos
	{
		get
		{
			return objectInfosField;
		}
		set
		{
			objectInfosField = value;
			RaisePropertyChanged("objectInfos");
		}
	}
}
