using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SML_Sessioni", "Key", new string[] { "IdSessione" })]
public class SML_Sessione
{
	public int IdSessione { get; set; }

	public string Descrizione { get; set; }

	public DateTime Data { get; set; }

	public string Utente { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public SML_Sessione()
	{
		Descrizione = "";
		Utente = "";
		UteAgg = "";
		UteIns = "";
	}
}
