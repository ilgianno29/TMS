namespace Incasbo.Api.App;

public interface IIncasObserver
{
	void Notify(ref object Notification);
}
