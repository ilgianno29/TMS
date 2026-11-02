using System.Collections.Generic;

namespace Incasbo.Api.Gdo.Tariffe;

public class ShippingGroupedDocument : ShippingDocument
{
	public virtual string[] ElencoUnibol { get; set; }

	public virtual List<ShippingDocument> ShippingDocuments { get; set; }

	public virtual string IdRaggruppamento { get; set; }

	public virtual string IdViaggio { get; set; }

	public string SqlElencoUnibol
	{
		get
		{
			string text = "";
			string[] elencoUnibol = ElencoUnibol;
			foreach (string text2 in elencoUnibol)
			{
				text = text + "'" + text2 + "' ";
			}
			return text.Trim().Replace(" ", ",");
		}
	}

	public ShippingGroupedDocument()
	{
		ShippingDocuments = new List<ShippingDocument>();
		IdRaggruppamento = "";
		IdViaggio = "";
	}
}
