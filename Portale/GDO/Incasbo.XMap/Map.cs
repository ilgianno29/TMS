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
public class Map : TransientVO
{
	private Image imageField;

	private ObjectInfos[] wrappedObjectsField;

	private VisibleSection visibleSectionField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Image image
	{
		get
		{
			return imageField;
		}
		set
		{
			imageField = value;
			RaisePropertyChanged("image");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public ObjectInfos[] wrappedObjects
	{
		get
		{
			return wrappedObjectsField;
		}
		set
		{
			wrappedObjectsField = value;
			RaisePropertyChanged("wrappedObjects");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public VisibleSection visibleSection
	{
		get
		{
			return visibleSectionField;
		}
		set
		{
			visibleSectionField = value;
			RaisePropertyChanged("visibleSection");
		}
	}
}
