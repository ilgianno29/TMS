using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Model.Map;

public class PuntoSuMappa : Punto, IEquatable<PuntoSuMappa>
{
	public string ID { get; set; }

	public Tipologia Tipologia { get; set; }

	public string Icona { get; set; }

	public string IconaSelezionato { get; set; }

	public string Tooltip { get; set; }

	public string Descrizione { get; set; }

	public string FixTooltip { get; set; }

	public bool Selezionato { get; set; }

	public string ColoreFixTooltip { get; set; }

	public EsitoOrdine Esito { get; set; }

	public string Icona_TMP { get; set; }

	public string IconaSel_TMP { get; set; }

	public int ZOrder { get; set; }

	public PuntoSuMappa(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string IconaSelezionato, string Tooltip, string Descrizione, string FixTooltip, string ColoreFixTooltip)
		: base(longitudine, latitudine)
	{
		Icona_TMP = "";
		IconaSel_TMP = "";
		ZOrder = 0;
		this.ID = ID;
		Tipologia = tipologia;
		this.Icona = Icona;
		this.IconaSelezionato = IconaSelezionato;
		this.FixTooltip = FixTooltip;
		this.ColoreFixTooltip = ColoreFixTooltip;
		this.Tooltip = Tooltip;
		this.Descrizione = Descrizione;
		Selezionato = false;
	}

	public PuntoSuMappa(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string IconaSelezionato, string Tooltip, string Descrizione, string FixTooltip, string ColoreFixTooltip, EsitoOrdine Esito)
		: base(longitudine, latitudine)
	{
		Icona_TMP = "";
		IconaSel_TMP = "";
		ZOrder = 0;
		this.ID = ID;
		Tipologia = tipologia;
		this.Icona = Icona;
		this.IconaSelezionato = IconaSelezionato;
		this.FixTooltip = FixTooltip;
		this.ColoreFixTooltip = ColoreFixTooltip;
		this.Tooltip = Tooltip;
		this.Descrizione = Descrizione;
		Selezionato = false;
		this.Esito = Esito;
	}

	public PuntoSuMappa(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string IconaSelezionato, string Tooltip, string FixTooltip, string Descrizione, string ColoreFixTooltip, bool Selezionato)
		: base(longitudine, latitudine)
	{
		Icona_TMP = "";
		IconaSel_TMP = "";
		ZOrder = 0;
		this.ID = ID;
		Tipologia = tipologia;
		this.Icona = Icona;
		this.IconaSelezionato = IconaSelezionato;
		this.FixTooltip = FixTooltip;
		this.ColoreFixTooltip = ColoreFixTooltip;
		this.Tooltip = Tooltip;
		this.Descrizione = Descrizione;
		this.Selezionato = Selezionato;
	}

	public PuntoSuMappa(string id)
		: base(0m, 0m)
	{
		Icona_TMP = "";
		IconaSel_TMP = "";
		ZOrder = 0;
		ID = id;
	}

	public bool Equals(PuntoSuMappa other)
	{
		if (Operators.CompareString(ID, other.ID, false) == 0)
		{
			return true;
		}
		return false;
	}

	bool IEquatable<PuntoSuMappa>.Equals(PuntoSuMappa other)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Equals
		return this.Equals(other);
	}
}
