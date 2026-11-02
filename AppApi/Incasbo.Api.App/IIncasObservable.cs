namespace Incasbo.Api.App;

public interface IIncasObservable
{
	void RegisterObserver(IIncasObserver Observer);

	void UnregisterObserver(IIncasObserver Observer);

	void NotifyObservers(object Notification);
}
