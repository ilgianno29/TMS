using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class ProductIncompatibility : TransientVO
{
	private ProductIncompatibilityType incompatibilityTypeField;

	private int productId1Field;

	private int productId2Field;

	[XmlAttribute]
	public ProductIncompatibilityType incompatibilityType
	{
		get
		{
			return incompatibilityTypeField;
		}
		set
		{
			incompatibilityTypeField = value;
			RaisePropertyChanged("incompatibilityType");
		}
	}

	[XmlAttribute]
	public int productId1
	{
		get
		{
			return productId1Field;
		}
		set
		{
			productId1Field = value;
			RaisePropertyChanged("productId1");
		}
	}

	[XmlAttribute]
	public int productId2
	{
		get
		{
			return productId2Field;
		}
		set
		{
			productId2Field = value;
			RaisePropertyChanged("productId2");
		}
	}
}
