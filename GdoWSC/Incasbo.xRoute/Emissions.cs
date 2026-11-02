using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(EmissionsHBEFA31))]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlInclude(typeof(EmissionsHBEFA32))]
public class Emissions : TransientVO
{
	private double ammoniaField;

	private double benzeneField;

	private double carbonDioxideField;

	private double carbonMonoxideField;

	private double fuelField;

	private double hydrocarbonsField;

	private double hydrocarbonsExMethaneField;

	private double leadField;

	private double methaneField;

	private double nitrogenOxidesField;

	private double nitrousOxideField;

	private double particlesField;

	private double sulphurDioxideField;

	private double tolueneField;

	private double xyleneField;

	[XmlAttribute]
	public double ammonia
	{
		get
		{
			return ammoniaField;
		}
		set
		{
			ammoniaField = value;
			RaisePropertyChanged("ammonia");
		}
	}

	[XmlAttribute]
	public double benzene
	{
		get
		{
			return benzeneField;
		}
		set
		{
			benzeneField = value;
			RaisePropertyChanged("benzene");
		}
	}

	[XmlAttribute]
	public double carbonDioxide
	{
		get
		{
			return carbonDioxideField;
		}
		set
		{
			carbonDioxideField = value;
			RaisePropertyChanged("carbonDioxide");
		}
	}

	[XmlAttribute]
	public double carbonMonoxide
	{
		get
		{
			return carbonMonoxideField;
		}
		set
		{
			carbonMonoxideField = value;
			RaisePropertyChanged("carbonMonoxide");
		}
	}

	[XmlAttribute]
	public double fuel
	{
		get
		{
			return fuelField;
		}
		set
		{
			fuelField = value;
			RaisePropertyChanged("fuel");
		}
	}

	[XmlAttribute]
	public double hydrocarbons
	{
		get
		{
			return hydrocarbonsField;
		}
		set
		{
			hydrocarbonsField = value;
			RaisePropertyChanged("hydrocarbons");
		}
	}

	[XmlAttribute]
	public double hydrocarbonsExMethane
	{
		get
		{
			return hydrocarbonsExMethaneField;
		}
		set
		{
			hydrocarbonsExMethaneField = value;
			RaisePropertyChanged("hydrocarbonsExMethane");
		}
	}

	[XmlAttribute]
	public double lead
	{
		get
		{
			return leadField;
		}
		set
		{
			leadField = value;
			RaisePropertyChanged("lead");
		}
	}

	[XmlAttribute]
	public double methane
	{
		get
		{
			return methaneField;
		}
		set
		{
			methaneField = value;
			RaisePropertyChanged("methane");
		}
	}

	[XmlAttribute]
	public double nitrogenOxides
	{
		get
		{
			return nitrogenOxidesField;
		}
		set
		{
			nitrogenOxidesField = value;
			RaisePropertyChanged("nitrogenOxides");
		}
	}

	[XmlAttribute]
	public double nitrousOxide
	{
		get
		{
			return nitrousOxideField;
		}
		set
		{
			nitrousOxideField = value;
			RaisePropertyChanged("nitrousOxide");
		}
	}

	[XmlAttribute]
	public double particles
	{
		get
		{
			return particlesField;
		}
		set
		{
			particlesField = value;
			RaisePropertyChanged("particles");
		}
	}

	[XmlAttribute]
	public double sulphurDioxide
	{
		get
		{
			return sulphurDioxideField;
		}
		set
		{
			sulphurDioxideField = value;
			RaisePropertyChanged("sulphurDioxide");
		}
	}

	[XmlAttribute]
	public double toluene
	{
		get
		{
			return tolueneField;
		}
		set
		{
			tolueneField = value;
			RaisePropertyChanged("toluene");
		}
	}

	[XmlAttribute]
	public double xylene
	{
		get
		{
			return xyleneField;
		}
		set
		{
			xyleneField = value;
			RaisePropertyChanged("xylene");
		}
	}
}
