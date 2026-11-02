using System.Web;

namespace Incasbo.Web.WSC;

public class CustomBackgroundActivity : IWSCBackgroundActivity
{
	public void Start(HttpApplication MyHttpApplication)
	{
	}

	void IWSCBackgroundActivity.Start(HttpApplication MyHttpApplication)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Start
		this.Start(MyHttpApplication);
	}
}
