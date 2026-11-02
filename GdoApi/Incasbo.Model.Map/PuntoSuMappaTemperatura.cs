namespace Incasbo.Model.Map;

public class PuntoSuMappaTemperatura : PuntoSuMappa
{
	public decimal Temperatura { get; set; }

	public PuntoSuMappaTemperatura(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string IconaSelezionato, string Tooltip, string FixTooltip, string ColoreFixTooltip, bool Selezionato, decimal Temperatura)
		: base(longitudine, latitudine, ID, tipologia, Icona, IconaSelezionato, Tooltip, "", FixTooltip, ColoreFixTooltip, Selezionato)
	{
		this.Temperatura = Temperatura;
	}

	public PuntoSuMappaTemperatura(decimal longitudine, decimal latitudine, string ID, Tipologia tipologia, string Icona, string Tooltip, string FixTooltip, string ColoreFixTooltip, decimal Temperatura)
		: base(longitudine, latitudine, ID, tipologia, Icona, "", Tooltip, "", FixTooltip, ColoreFixTooltip, Selezionato: false)
	{
		this.Temperatura = Temperatura;
	}
}
