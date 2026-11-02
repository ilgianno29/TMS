using System;

namespace Incasbo.Model.Map;

public class Ordine
{
	private decimal[] _boundingRect;

	public string unibol { get; set; }

	public PuntoSuMappa puntoA { get; set; }

	public PuntoSuMappa puntoB { get; set; }

	public EsitoOrdine EsitoOrdine { get; set; }

	public string tipoOrdine { get; set; }

	public bool previouslySelected { get; set; }

	public bool currentlySelected { get; set; }

	public decimal[] boundingRect => _boundingRect;

	public Ordine(PuntoSuMappa puntoA, PuntoSuMappa puntoB, string unibol, string tipoOrdine)
	{
		_boundingRect = new decimal[4];
		this.puntoA = puntoA;
		this.puntoB = puntoB;
		this.unibol = unibol;
		this.tipoOrdine = tipoOrdine;
		previouslySelected = false;
		currentlySelected = false;
		calculateBoundingRect();
	}

	public Ordine(PuntoSuMappa puntoA, PuntoSuMappa puntoB, string unibol, string tipoOrdine, EsitoOrdine EsitoOrdine)
	{
		_boundingRect = new decimal[4];
		this.puntoA = puntoA;
		this.puntoB = puntoB;
		this.unibol = unibol;
		this.tipoOrdine = tipoOrdine;
		this.EsitoOrdine = EsitoOrdine;
		previouslySelected = false;
		currentlySelected = false;
		calculateBoundingRect();
	}

	private void calculateBoundingRect()
	{
		_boundingRect[0] = 99999m;
		_boundingRect[1] = 99999m;
		_boundingRect[2] = default(decimal);
		_boundingRect[3] = default(decimal);
		_boundingRect[0] = new decimal(Math.Min(Math.Round(Convert.ToDouble(puntoA.Longitudine), 5), Math.Round(Convert.ToDouble(puntoB.Longitudine), 5)));
		_boundingRect[1] = new decimal(Math.Min(Math.Round(Convert.ToDouble(puntoA.Latitudine), 5), Math.Round(Convert.ToDouble(puntoB.Latitudine), 5)));
		_boundingRect[2] = new decimal(Math.Max(Math.Round(Convert.ToDouble(puntoA.Longitudine), 5), Math.Round(Convert.ToDouble(puntoB.Longitudine), 5)));
		_boundingRect[3] = new decimal(Math.Max(Math.Round(Convert.ToDouble(puntoA.Latitudine), 5), Math.Round(Convert.ToDouble(puntoB.Latitudine), 5)));
	}
}
