namespace Incasbo.Api.App;

public class GenericIncasObserver : IIncasObserver
{
	public delegate void NotifyEventEventHandler(ref object Notification);

	public event NotifyEventEventHandler NotifyEvent;

	public void Notify(ref object Notification)
	{
		NotifyEvent?.Invoke(ref Notification);
	}

	void IIncasObserver.Notify(ref object Notification)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Notify
		this.Notify(ref Notification);
	}
}
