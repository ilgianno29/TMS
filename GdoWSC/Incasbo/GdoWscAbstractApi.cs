using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;

namespace Incasbo;

public abstract class GdoWscAbstractApi : AppAbstractApi
{
	protected ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)this._ApiContext.AppDefault;

	protected ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public GdoWscAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}
}
