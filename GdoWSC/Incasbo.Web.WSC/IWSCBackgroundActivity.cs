using System.Web;

namespace Incasbo.Web.WSC;

public interface IWSCBackgroundActivity
{
	void Start(HttpApplication MyHttpApplication);
}
