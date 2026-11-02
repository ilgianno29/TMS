using System;
using System.Collections.Generic;

namespace Incasbo.Web.GDO.Foglione;

public class Appointment
{
	public int Id { get; set; }

	public string Autista { get; set; }

	public DateTime Data { get; set; }

	public string Mezzo { get; set; }

	public Autista objAutista { get; set; }

	public Mezzo objMezzo { get; set; }

	public List<Viaggio> objViaggi { get; set; }

	public bool Selezionato { get; set; }

	public Appointment()
	{
		Id = 0;
		Autista = "";
		Mezzo = "";
		Selezionato = false;
	}
}
