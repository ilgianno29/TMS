namespace Incasbo.Api.Gdo.Tariffe;

public abstract class Costi : CostiRicavi
{
	public virtual string FornitoreFieldName { get; set; }

	protected Costi()
	{
		FornitoreFieldName = "Trasportatore";
	}
}
