using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class PoiResultAddress : ResultAddress
{
	private DatabaseFieldBase[] wrappedDatabaseFieldsField;

	private string poiNameField;

	private string poiTypeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public DatabaseFieldBase[] wrappedDatabaseFields
	{
		get
		{
			return wrappedDatabaseFieldsField;
		}
		set
		{
			wrappedDatabaseFieldsField = value;
			RaisePropertyChanged("wrappedDatabaseFields");
		}
	}

	[XmlAttribute]
	public string poiName
	{
		get
		{
			return poiNameField;
		}
		set
		{
			poiNameField = value;
			RaisePropertyChanged("poiName");
		}
	}

	[XmlAttribute]
	public string poiType
	{
		get
		{
			return poiTypeField;
		}
		set
		{
			poiTypeField = value;
			RaisePropertyChanged("poiType");
		}
	}
}
