using System.Web;

namespace Incasbo.Web.WFI;

public interface IIboWFIBackgroundActivity
{
	void Start(HttpApplication MyHttpApplication);
}
