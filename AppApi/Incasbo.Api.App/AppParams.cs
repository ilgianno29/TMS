using System;
using System.Reflection;

namespace Incasbo.Api.App;

public class AppParams : AppBaseClass
{
	public AppParams(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public object GetParams(string Metodo)
	{
		Type type = GetType();
		MethodInfo method = type.GetMethod(Metodo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		return method.Invoke(this, new object[0]);
	}
}
