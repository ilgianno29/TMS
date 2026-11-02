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
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class RequestOptions : TransientVO
{
	private GeometryEncoding[] wrappedResponseGeometryField;

	private CoordFormat coordFormatField;

	private string profileField;

	private string profileXMLSnippetField;

	private string srIdField;

	[XmlArray(IsNullable = true, Order = 0)]
	public GeometryEncoding[] wrappedResponseGeometry
	{
		get
		{
			return wrappedResponseGeometryField;
		}
		set
		{
			wrappedResponseGeometryField = value;
			RaisePropertyChanged("wrappedResponseGeometry");
		}
	}

	[XmlAttribute]
	public CoordFormat coordFormat
	{
		get
		{
			return coordFormatField;
		}
		set
		{
			coordFormatField = value;
			RaisePropertyChanged("coordFormat");
		}
	}

	[XmlAttribute]
	public string profile
	{
		get
		{
			return profileField;
		}
		set
		{
			profileField = value;
			RaisePropertyChanged("profile");
		}
	}

	[XmlAttribute]
	public string profileXMLSnippet
	{
		get
		{
			return profileXMLSnippetField;
		}
		set
		{
			profileXMLSnippetField = value;
			RaisePropertyChanged("profileXMLSnippet");
		}
	}

	[XmlAttribute]
	public string srId
	{
		get
		{
			return srIdField;
		}
		set
		{
			srIdField = value;
			RaisePropertyChanged("srId");
		}
	}
}
