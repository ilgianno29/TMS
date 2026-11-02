using System;

namespace Incasbo.Web.GDO.Foglione;

public class MezzoLibero
{
	public string Mezzo { get; set; }

	public string Targa { get; set; }

	public DateTime Data { get; set; }

	public string Note { get; set; }

	public string Indisponibile { get; set; }

	public string TipoMezzo { get; set; }

	public string DiProprieta { get; set; }

	public string Trasportatore { get; set; }

	public string Trasportatore_RagSoc { get; set; }

	public MezzoLibero()
	{
		Mezzo = "";
		Targa = "";
		Note = "";
		Indisponibile = "";
		TipoMezzo = "";
		DiProprieta = "";
		Trasportatore = "";
		Trasportatore_RagSoc = "";
	}
}
