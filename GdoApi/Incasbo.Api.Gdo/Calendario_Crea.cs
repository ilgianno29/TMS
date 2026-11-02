using Incasbo.Api.App;

namespace Incasbo.Api.Gdo;

public class Calendario_Crea : Incasbo.Api.App.Calendario_Crea
{
	public Calendario_Crea(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override void DeterminaFestivita()
	{
		((Calendario_Crea)this).DeterminaFestivita();
	}
}
