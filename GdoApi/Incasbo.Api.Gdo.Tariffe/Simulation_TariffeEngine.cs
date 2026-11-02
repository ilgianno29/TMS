using Incasbo.Api.App;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class Simulation_TariffeEngine : TariffeEngine
{
	public Costi Costi => _Costi;

	public Ricavi Ricavi => _Ricavi;

	public Simulation_TariffeEngine(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_SimulationMode = true;
	}
}
