using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualBasic;

namespace Incasbo.Model.Map;

public class Viaggio
{
	private decimal[] _boundingRect;

	public string ID { get; set; }

	public bool Selezionato { get; set; }

	public List<PuntoSuMappa> Punti { get; set; }

	public List<PuntoSuMappa> PuntiPianificati { get; set; }

	public List<PuntoSuMappaGPS> PuntiGPS { get; set; }

	public List<PuntoSuMappaTemperatura> PuntiTemperature { get; set; }

	public List<Punto> PuntiPercorsoPianificato { get; set; }

	public List<Punto> PuntiPercorsoReale { get; set; }

	public bool ViaggioManuale { get; set; }

	public bool Visibile { get; set; }

	public Color Colore { get; set; }

	public string Mezzo { get; set; }

	public Color ColoreLineeSelezionato { get; set; }

	public Color ColoreTourSelezionato { get; set; }

	public Color ColoreLineeSelezionatoPianificato { get; set; }

	public Color ColoreTourSelezionatoPianificato { get; set; }

	public string TargaMezzo { get; set; }

	public List<Ordine> Ordini { get; set; }

	public string Autista { get; set; }

	public decimal[] BoundingRect => _boundingRect;

	public Viaggio(string ID, List<PuntoSuMappa> Punti, List<PuntoSuMappaGPS> PuntiGps, List<PuntoSuMappaTemperatura> PuntiTemperature, List<Punto> PuntiPercorsoPianificato, List<Punto> PuntiPercorsoReale, bool Selezionato)
	{
		_boundingRect = new decimal[4];
		this.ID = ID;
		this.Punti = Punti;
		PuntiGPS = PuntiGps;
		this.PuntiTemperature = PuntiTemperature;
		this.PuntiPercorsoPianificato = PuntiPercorsoPianificato;
		this.PuntiPercorsoReale = PuntiPercorsoReale;
		this.Selezionato = Selezionato;
		calculateBoundingRect();
	}

	public Viaggio(string ID, List<PuntoSuMappa> Punti, List<PuntoSuMappaGPS> PuntiGps, List<Punto> PuntiPercorsoPianificato, List<Punto> PuntiPercorsoReale)
	{
		_boundingRect = new decimal[4];
		this.ID = ID;
		this.Punti = Punti;
		PuntiGPS = PuntiGps;
		this.PuntiPercorsoPianificato = PuntiPercorsoPianificato;
		this.PuntiPercorsoReale = PuntiPercorsoReale;
		Selezionato = false;
		Visibile = true;
		calculateBoundingRect();
	}

	public Viaggio(string ID, List<PuntoSuMappa> Punti, List<PuntoSuMappa> PuntiPianificati)
	{
		_boundingRect = new decimal[4];
		this.ID = ID;
		this.Punti = Punti;
		this.PuntiPianificati = PuntiPianificati;
		PuntiGPS = null;
		PuntiTemperature = null;
		PuntiPercorsoPianificato = null;
		PuntiPercorsoReale = null;
		Selezionato = false;
		calculateBoundingRect();
	}

	public Viaggio(string ID, List<PuntoSuMappa> Punti, List<PuntoSuMappa> PuntiPianificati, bool Visibile, bool ViaggioManuale)
	{
		_boundingRect = new decimal[4];
		this.ID = ID;
		this.Punti = Punti;
		this.PuntiPianificati = PuntiPianificati;
		PuntiGPS = null;
		PuntiTemperature = null;
		PuntiPercorsoPianificato = null;
		PuntiPercorsoReale = null;
		Selezionato = false;
		this.Visibile = Visibile;
		this.ViaggioManuale = ViaggioManuale;
		calculateBoundingRect();
	}

	public void calculateBoundingRect()
	{
		_boundingRect[0] = 99999m;
		_boundingRect[1] = 99999m;
		_boundingRect[2] = -99999m;
		_boundingRect[3] = -99999m;
		if (!Information.IsNothing((object)Punti))
		{
			foreach (PuntoSuMappa item in Punti)
			{
				_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item.Longitudine), 5)));
				_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item.Latitudine), 5)));
				_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item.Longitudine), 5)));
				_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item.Latitudine), 5)));
			}
		}
		if (!Information.IsNothing((object)PuntiPianificati))
		{
			foreach (PuntoSuMappa item2 in PuntiPianificati)
			{
				_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item2.Longitudine), 5)));
				_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item2.Latitudine), 5)));
				_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item2.Longitudine), 5)));
				_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item2.Latitudine), 5)));
			}
		}
		if (!Information.IsNothing((object)PuntiGPS))
		{
			foreach (PuntoSuMappaGPS puntiGP in PuntiGPS)
			{
				_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(puntiGP.Longitudine), 5)));
				_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(puntiGP.Latitudine), 5)));
				_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(puntiGP.Longitudine), 5)));
				_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(puntiGP.Latitudine), 5)));
			}
		}
		if (!Information.IsNothing((object)PuntiTemperature))
		{
			foreach (PuntoSuMappaTemperatura item3 in PuntiTemperature)
			{
				_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item3.Longitudine), 5)));
				_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item3.Latitudine), 5)));
				_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item3.Longitudine), 5)));
				_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item3.Latitudine), 5)));
			}
		}
		if (!Information.IsNothing((object)PuntiPercorsoPianificato))
		{
			foreach (Punto item4 in PuntiPercorsoPianificato)
			{
				_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item4.Longitudine), 5)));
				_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item4.Latitudine), 5)));
				_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item4.Longitudine), 5)));
				_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item4.Latitudine), 5)));
			}
		}
		if (Information.IsNothing((object)PuntiPercorsoReale))
		{
			return;
		}
		foreach (Punto item5 in PuntiPercorsoReale)
		{
			_boundingRect[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item5.Longitudine), 5)));
			_boundingRect[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item5.Latitudine), 5)));
			_boundingRect[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item5.Longitudine), 5)));
			_boundingRect[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item5.Latitudine), 5)));
		}
	}

	public void calculateBoundingRectGPS()
	{
		_boundingRect[0] = 99999m;
		_boundingRect[1] = 99999m;
		_boundingRect[2] = default(decimal);
		_boundingRect[3] = default(decimal);
		foreach (PuntoSuMappa item in Punti)
		{
			_boundingRect[0] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(item.Longitudine), 5)));
			_boundingRect[1] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(item.Latitudine), 5)));
			_boundingRect[2] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(item.Longitudine), 5)));
			_boundingRect[3] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(item.Latitudine), 5)));
		}
		foreach (PuntoSuMappaGPS puntiGP in PuntiGPS)
		{
			_boundingRect[0] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[0]), 5), Math.Round(Convert.ToDouble(puntiGP.Longitudine), 5)));
			_boundingRect[1] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_boundingRect[1]), 5), Math.Round(Convert.ToDouble(puntiGP.Latitudine), 5)));
			_boundingRect[2] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[2]), 5), Math.Round(Convert.ToDouble(puntiGP.Longitudine), 5)));
			_boundingRect[3] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_boundingRect[3]), 5), Math.Round(Convert.ToDouble(puntiGP.Latitudine), 5)));
		}
	}
}
