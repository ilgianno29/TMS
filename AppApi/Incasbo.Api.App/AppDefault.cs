using System;
using System.Reflection;

namespace Incasbo.Api.App;

public abstract class AppDefault : AppBaseClass
{
	public AppDefault(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public object GetDefault(string Metodo)
	{
		Type type = GetType();
		MethodInfo method = type.GetMethod(Metodo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		return method.Invoke(this, new object[0]);
	}
}
