using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Model.Map;

public class PuntoSuMappaGPS : PuntoSuMappa, IEquatable<PuntoSuMappaGPS>
{
	public decimal Direzione { get; set; }

	public decimal Velocita { get; set; }

	public decimal Km { get; set; }

	public PuntoSuMappaGPS(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string IconaSelezionato, string Tooltip, string ColoreFixTooltip, string FixTooltip, bool Selezionato, decimal direzione, decimal velocita, decimal Km)
		: base(longitudine, latitudine, ID, tipologia, Icona, IconaSelezionato, Tooltip, "", FixTooltip, ColoreFixTooltip, Selezionato)
	{
		Velocita = velocita;
		Direzione = direzione;
		this.Km = Km;
	}

	public PuntoSuMappaGPS(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string Tooltip, string FixTooltip, string ColoreFixTooltip, decimal direzione, decimal velocita, decimal Km)
		: base(longitudine, latitudine, ID, tipologia, Icona, "", Tooltip, "", FixTooltip, ColoreFixTooltip, Selezionato: false)
	{
		Velocita = velocita;
		Direzione = direzione;
		this.Km = Km;
	}

	public bool Equals(PuntoSuMappaGPS other)
	{
		if (Operators.CompareString(base.ID, other.ID, false) == 0)
		{
			return true;
		}
		return false;
	}

	bool IEquatable<PuntoSuMappaGPS>.Equals(PuntoSuMappaGPS other)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Equals
		return this.Equals(other);
	}
}
