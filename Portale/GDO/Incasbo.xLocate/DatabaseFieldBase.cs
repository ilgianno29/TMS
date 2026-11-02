using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(DatabaseFieldInteger))]
[XmlInclude(typeof(DatabaseFieldBlob))]
[XmlInclude(typeof(DatabaseFieldFloat))]
[XmlInclude(typeof(DatabaseFieldString))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public abstract class DatabaseFieldBase : TransientVO
{
	private string fieldField;

	[XmlAttribute]
	public string field
	{
		get
		{
			return fieldField;
		}
		set
		{
			fieldField = value;
			RaisePropertyChanged("field");
		}
	}
}
