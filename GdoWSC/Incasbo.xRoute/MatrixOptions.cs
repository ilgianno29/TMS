using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class MatrixOptions : TransientVO
{
	private ExceptionPath[] wrappedExceptionPathsField;

	private int[] wrappedNcFilterField;

	private bool tollField;

	private bool travelTrendDepartureTimeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public ExceptionPath[] wrappedExceptionPaths
	{
		get
		{
			return wrappedExceptionPathsField;
		}
		set
		{
			wrappedExceptionPathsField = value;
			RaisePropertyChanged("wrappedExceptionPaths");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 1)]
	public int[] wrappedNcFilter
	{
		get
		{
			return wrappedNcFilterField;
		}
		set
		{
			wrappedNcFilterField = value;
			RaisePropertyChanged("wrappedNcFilter");
		}
	}

	[XmlAttribute]
	public bool toll
	{
		get
		{
			return tollField;
		}
		set
		{
			tollField = value;
			RaisePropertyChanged("toll");
		}
	}

	[XmlAttribute]
	public bool travelTrendDepartureTime
	{
		get
		{
			return travelTrendDepartureTimeField;
		}
		set
		{
			travelTrendDepartureTimeField = value;
			RaisePropertyChanged("travelTrendDepartureTime");
		}
	}
}
