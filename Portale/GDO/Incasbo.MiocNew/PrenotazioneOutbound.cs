using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.MiocNew;

[Serializable]
[GeneratedCode("System.Xml", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://beans.inbound.webservices.cfc.lucart/xsd")]
public class PrenotazioneOutbound : CFComponentSkeleton
{
	private string d_dataprenotazioneField;

	private string n_pesoField;

	private string v_idviaggioField;

	private string v_merceField;

	private string v_mezzoField;

	private string v_stabilimentoField;

	private string v_udmField;

	private string v_vettoreField;

	[XmlElement(IsNullable = true)]
	public string d_dataprenotazione
	{
		get
		{
			return d_dataprenotazioneField;
		}
		set
		{
			d_dataprenotazioneField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string n_peso
	{
		get
		{
			return n_pesoField;
		}
		set
		{
			n_pesoField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_idviaggio
	{
		get
		{
			return v_idviaggioField;
		}
		set
		{
			v_idviaggioField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_merce
	{
		get
		{
			return v_merceField;
		}
		set
		{
			v_merceField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_mezzo
	{
		get
		{
			return v_mezzoField;
		}
		set
		{
			v_mezzoField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_stabilimento
	{
		get
		{
			return v_stabilimentoField;
		}
		set
		{
			v_stabilimentoField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_udm
	{
		get
		{
			return v_udmField;
		}
		set
		{
			v_udmField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string v_vettore
	{
		get
		{
			return v_vettoreField;
		}
		set
		{
			v_vettoreField = value;
		}
	}
}
