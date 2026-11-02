using System;
using System.Collections.Generic;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public abstract class AppAbstractApiObservable : AppAbstractApi, IIncasObservable
{
	protected List<IIncasObserver> _Observers;

	public AppAbstractApiObservable(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Observers = new List<IIncasObserver>();
	}

	protected abstract override modGeneral.FXRETURN CheckData(ref string rsmess);

	protected abstract override modGeneral.FXRETURN Core(ref string rsmess);

	public void NotifyObservers(object Notification)
	{
		try
		{
			foreach (IIncasObserver observer in _Observers)
			{
				observer.Notify(ref Notification);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	void IIncasObservable.NotifyObservers(object Notification)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotifyObservers
		this.NotifyObservers(Notification);
	}

	public void RegisterObserver(IIncasObserver Observer)
	{
		try
		{
			_Observers.Add(Observer);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	void IIncasObservable.RegisterObserver(IIncasObserver Observer)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RegisterObserver
		this.RegisterObserver(Observer);
	}

	public void UnregisterObserver(IIncasObserver Observer)
	{
		try
		{
			_Observers.Remove(Observer);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	void IIncasObservable.UnregisterObserver(IIncasObserver Observer)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UnregisterObserver
		this.UnregisterObserver(Observer);
	}
}
