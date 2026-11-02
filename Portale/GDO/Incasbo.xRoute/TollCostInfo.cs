using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class TollCostInfo : TransientVO
{
	private TollStationDescription tollStationFromField;

	private TollStationDescription tollStationToField;

	private Currency currencyField;

	private string currencyNameField;

	private string streetNameField;

	private int tollDistanceField;

	private int tollPriceField;

	private int tollProviderIDField;

	private string tollProviderNameField;

	private int tollSectionIDField;

	private string tollSectionNameField;

	private TollType tollTypeField;

	private int vehicleTarifIDField;

	private bool vehicleTarifIDFieldSpecified;

	private int waypointIndexField;

	private bool waypointIndexFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public TollStationDescription tollStationFrom
	{
		get
		{
			return tollStationFromField;
		}
		set
		{
			tollStationFromField = value;
			RaisePropertyChanged("tollStationFrom");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public TollStationDescription tollStationTo
	{
		get
		{
			return tollStationToField;
		}
		set
		{
			tollStationToField = value;
			RaisePropertyChanged("tollStationTo");
		}
	}

	[XmlAttribute]
	public Currency currency
	{
		get
		{
			return currencyField;
		}
		set
		{
			currencyField = value;
			RaisePropertyChanged("currency");
		}
	}

	[XmlAttribute]
	public string currencyName
	{
		get
		{
			return currencyNameField;
		}
		set
		{
			currencyNameField = value;
			RaisePropertyChanged("currencyName");
		}
	}

	[XmlAttribute]
	public string streetName
	{
		get
		{
			return streetNameField;
		}
		set
		{
			streetNameField = value;
			RaisePropertyChanged("streetName");
		}
	}

	[XmlAttribute]
	public int tollDistance
	{
		get
		{
			return tollDistanceField;
		}
		set
		{
			tollDistanceField = value;
			RaisePropertyChanged("tollDistance");
		}
	}

	[XmlAttribute]
	public int tollPrice
	{
		get
		{
			return tollPriceField;
		}
		set
		{
			tollPriceField = value;
			RaisePropertyChanged("tollPrice");
		}
	}

	[XmlAttribute]
	public int tollProviderID
	{
		get
		{
			return tollProviderIDField;
		}
		set
		{
			tollProviderIDField = value;
			RaisePropertyChanged("tollProviderID");
		}
	}

	[XmlAttribute]
	public string tollProviderName
	{
		get
		{
			return tollProviderNameField;
		}
		set
		{
			tollProviderNameField = value;
			RaisePropertyChanged("tollProviderName");
		}
	}

	[XmlAttribute]
	public int tollSectionID
	{
		get
		{
			return tollSectionIDField;
		}
		set
		{
			tollSectionIDField = value;
			RaisePropertyChanged("tollSectionID");
		}
	}

	[XmlAttribute]
	public string tollSectionName
	{
		get
		{
			return tollSectionNameField;
		}
		set
		{
			tollSectionNameField = value;
			RaisePropertyChanged("tollSectionName");
		}
	}

	[XmlAttribute]
	public TollType tollType
	{
		get
		{
			return tollTypeField;
		}
		set
		{
			tollTypeField = value;
			RaisePropertyChanged("tollType");
		}
	}

	[XmlAttribute]
	public int vehicleTarifID
	{
		get
		{
			return vehicleTarifIDField;
		}
		set
		{
			vehicleTarifIDField = value;
			RaisePropertyChanged("vehicleTarifID");
		}
	}

	[XmlIgnore]
	public bool vehicleTarifIDSpecified
	{
		get
		{
			return vehicleTarifIDFieldSpecified;
		}
		set
		{
			vehicleTarifIDFieldSpecified = value;
			RaisePropertyChanged("vehicleTarifIDSpecified");
		}
	}

	[XmlAttribute]
	public int waypointIndex
	{
		get
		{
			return waypointIndexField;
		}
		set
		{
			waypointIndexField = value;
			RaisePropertyChanged("waypointIndex");
		}
	}

	[XmlIgnore]
	public bool waypointIndexSpecified
	{
		get
		{
			return waypointIndexFieldSpecified;
		}
		set
		{
			waypointIndexFieldSpecified = value;
			RaisePropertyChanged("waypointIndexSpecified");
		}
	}
}
