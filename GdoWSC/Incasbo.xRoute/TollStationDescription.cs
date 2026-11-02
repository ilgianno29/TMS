using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class TollStationDescription : TransientVO
{
	private TollManoeuvreType manoeuvreTypeField;

	private int routeListIndexField;

	private string timeField;

	private InfoNodeType tollLocationTypeField;

	private int tollStationIDField;

	private string tollStationNameField;

	[XmlAttribute]
	public TollManoeuvreType manoeuvreType
	{
		get
		{
			return manoeuvreTypeField;
		}
		set
		{
			manoeuvreTypeField = value;
			RaisePropertyChanged("manoeuvreType");
		}
	}

	[XmlAttribute]
	public int routeListIndex
	{
		get
		{
			return routeListIndexField;
		}
		set
		{
			routeListIndexField = value;
			RaisePropertyChanged("routeListIndex");
		}
	}

	[XmlAttribute]
	public string time
	{
		get
		{
			return timeField;
		}
		set
		{
			timeField = value;
			RaisePropertyChanged("time");
		}
	}

	[XmlAttribute]
	public InfoNodeType tollLocationType
	{
		get
		{
			return tollLocationTypeField;
		}
		set
		{
			tollLocationTypeField = value;
			RaisePropertyChanged("tollLocationType");
		}
	}

	[XmlAttribute]
	public int tollStationID
	{
		get
		{
			return tollStationIDField;
		}
		set
		{
			tollStationIDField = value;
			RaisePropertyChanged("tollStationID");
		}
	}

	[XmlAttribute]
	public string tollStationName
	{
		get
		{
			return tollStationNameField;
		}
		set
		{
			tollStationNameField = value;
			RaisePropertyChanged("tollStationName");
		}
	}
}
