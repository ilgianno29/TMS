using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class OvernightParams : StandardParams
{
	private bool[] wrappedOvernightStayPatternField;

	private double costPerOvernightStayField;

	private double costPerUnplannedCustomerField;

	private int maximumNumberOfAllowedOvernightStaysField;

	[XmlArrayItem("Boolean", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
	public bool[] wrappedOvernightStayPattern
	{
		get
		{
			return wrappedOvernightStayPatternField;
		}
		set
		{
			wrappedOvernightStayPatternField = value;
			RaisePropertyChanged("wrappedOvernightStayPattern");
		}
	}

	[XmlAttribute]
	public double costPerOvernightStay
	{
		get
		{
			return costPerOvernightStayField;
		}
		set
		{
			costPerOvernightStayField = value;
			RaisePropertyChanged("costPerOvernightStay");
		}
	}

	[XmlAttribute]
	public double costPerUnplannedCustomer
	{
		get
		{
			return costPerUnplannedCustomerField;
		}
		set
		{
			costPerUnplannedCustomerField = value;
			RaisePropertyChanged("costPerUnplannedCustomer");
		}
	}

	[XmlAttribute]
	public int maximumNumberOfAllowedOvernightStays
	{
		get
		{
			return maximumNumberOfAllowedOvernightStaysField;
		}
		set
		{
			maximumNumberOfAllowedOvernightStaysField = value;
			RaisePropertyChanged("maximumNumberOfAllowedOvernightStays");
		}
	}
}
