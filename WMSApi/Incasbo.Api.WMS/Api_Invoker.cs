using System;
using System.IO;
using System.Reflection;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

public class Api_Invoker
{
	protected bool _IsCustomized;

	protected virtual string ClassName { get; set; }

	protected virtual string ClassNameCustom { get; set; }

	public Api_Invoker()
	{
		string className = GetType().FullName.Replace("_Invoker", "");
		ClassName = className;
		className = GetType().FullName.Replace("_Invoker", "").Replace("Incasbo.Api.WMS", "Incasbo.CustomApi.WMS");
		ClassNameCustom = className;
		_IsCustomized = true;
	}

	protected virtual AppAbstractApi InstantiateApi(ref AppApiContext objApiContext, string ClassName, string ClassNameCustom)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
		string text = localPath + "\\WMSApiCustom.dll";
		AppAbstractApi val = null;
		if (_IsCustomized)
		{
			try
			{
				val = (AppAbstractApi)IncasReflection.InstantiateClass(ClassNameCustom, ref text, new object[1] { objApiContext });
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (val == null)
		{
			_IsCustomized = false;
			string text2 = "";
			val = (AppAbstractApi)IncasReflection.InstantiateClass(ClassName, ref text2, new object[1] { objApiContext });
		}
		else
		{
			_IsCustomized = true;
		}
		return val;
	}
}
