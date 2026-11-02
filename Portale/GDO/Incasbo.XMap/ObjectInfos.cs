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
public class ObjectInfos : TransientVO
{
	private LayerObject[] wrappedObjectsField;

	private string nameField;

	[XmlArray(IsNullable = true, Order = 0)]
	public LayerObject[] wrappedObjects
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
}
