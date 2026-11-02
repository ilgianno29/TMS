namespace Incasbo.Web.WSC;

public abstract class WSCStateless : IncasServiceFormsAuth
{
	protected override string ServiceName()
	{
		return "IncasWebServiceStateless";
	}
}
