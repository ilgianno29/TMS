using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Model.Map;

[Serializable]
public class Mappa
{
	private decimal[] _BoundingRectMappa;

	private bool _MustCalculateBoundingRect;

	private bool _Updating;

	public List<Viaggio> Viaggi { get; set; }

	public decimal[] BoundingRectMappa => _BoundingRectMappa;

	public bool BoundingRectMappaIsChanged { get; set; }

	public string LastUpdate { get; set; }

	public bool viewTourGPS { get; set; }

	public bool viewTourRouting { get; set; }

	public bool viewTourRoutingPianificato { get; set; }

	public bool viewTourLine { get; set; }

	public bool viewTourLinePianificato { get; set; }

	public bool viewUltimaPosizioneMezzi { get; set; }

	public bool viewTourTemp { get; set; }

	public Mappa()
	{
		_BoundingRectMappa = new decimal[4];
		_MustCalculateBoundingRect = false;
		LastUpdate = "";
		_Updating = false;
		viewTourGPS = false;
		viewTourRouting = false;
		viewTourRoutingPianificato = false;
		viewTourLine = true;
		viewTourLinePianificato = false;
		viewUltimaPosizioneMezzi = false;
		viewTourTemp = false;
		Viaggi = new List<Viaggio>();
	}

	public Mappa(List<Viaggio> Myviaggi)
	{
		_BoundingRectMappa = new decimal[4];
		_MustCalculateBoundingRect = false;
		LastUpdate = "";
		_Updating = false;
		viewTourGPS = false;
		viewTourRouting = false;
		viewTourRoutingPianificato = false;
		viewTourLine = true;
		viewTourLinePianificato = false;
		viewUltimaPosizioneMezzi = false;
		viewTourTemp = false;
		Viaggi = Myviaggi;
	}

	public void AggiungiViaggio(Viaggio viaggio)
	{
		Viaggi.Add(viaggio);
	}

	public void RimuoviTuttiViaggi()
	{
		Viaggi = new List<Viaggio>();
	}

	public void RimuoviSingoloViaggio(string ID)
	{
		foreach (Viaggio item in Viaggi)
		{
			if (Operators.CompareString(item.ID, ID, false) == 0)
			{
				Viaggi.Remove(item);
			}
		}
	}

	public Viaggio GetViaggioById(string IdViaggio)
	{
		Viaggio result = default(Viaggio);
		foreach (Viaggio item in Viaggi)
		{
			if (Operators.CompareString(item.ID, IdViaggio, false) == 0)
			{
				result = item;
				return result;
			}
		}
		return result;
	}

	private void _CalculateBoundingRectMappa()
	{
		Viaggio viaggio = null;
		_BoundingRectMappa[0] = 99999m;
		_BoundingRectMappa[1] = 99999m;
		_BoundingRectMappa[2] = -99999m;
		_BoundingRectMappa[3] = -99999m;
		if (!Information.IsNothing((object)Viaggi))
		{
			foreach (Viaggio item in Viaggi)
			{
				if (item.Visibile | item.Selezionato)
				{
					_BoundingRectMappa[0] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_BoundingRectMappa[0]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[0]), 5)));
					_BoundingRectMappa[1] = Convert.ToDecimal(Math.Min(Math.Round(Convert.ToDouble(_BoundingRectMappa[1]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[1]), 5)));
					_BoundingRectMappa[2] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_BoundingRectMappa[2]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[2]), 5)));
					_BoundingRectMappa[3] = Convert.ToDecimal(Math.Max(Math.Round(Convert.ToDouble(_BoundingRectMappa[3]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[3]), 5)));
				}
			}
		}
		BoundingRectMappaIsChanged = true;
		_MustCalculateBoundingRect = false;
	}

	private void _CalculateBoundingRect()
	{
		if (_MustCalculateBoundingRect)
		{
			_CalculateBoundingRectMappa();
		}
	}

	public void calculateBoundingRectMappa()
	{
		_BoundingRectMappa[0] = 99999m;
		_BoundingRectMappa[1] = 99999m;
		_BoundingRectMappa[2] = default(decimal);
		_BoundingRectMappa[3] = default(decimal);
		foreach (Viaggio item in Viaggi)
		{
			_BoundingRectMappa[0] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_BoundingRectMappa[0]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[0]), 5)));
			_BoundingRectMappa[1] = new decimal(Math.Min(Math.Round(Convert.ToDouble(_BoundingRectMappa[1]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[1]), 5)));
			_BoundingRectMappa[2] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_BoundingRectMappa[2]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[2]), 5)));
			_BoundingRectMappa[3] = new decimal(Math.Max(Math.Round(Convert.ToDouble(_BoundingRectMappa[3]), 5), Math.Round(Convert.ToDouble(item.BoundingRect[3]), 5)));
		}
	}

	public void BeginUpdate(bool MustCalculateBoundingRect)
	{
		_Updating = true;
		_MustCalculateBoundingRect = MustCalculateBoundingRect;
	}

	public void EndUpdate()
	{
		if (_Updating)
		{
			LastUpdate = Strings.Format((object)DateAndTime.Now, "yyyyMMddHHmmssfff");
			_CalculateBoundingRect();
			_Updating = false;
		}
	}
}
