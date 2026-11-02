using System;
using System.IO;
using System.Reflection;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Api_Invoker
{
	protected bool _IsCustomized;

	protected virtual string ClassName { get; set; }

	protected virtual string ClassNameCustom { get; set; }

	public Api_Invoker()
	{
		ClassName = GetType().FullName.Replace("_Invoker", "");
		ClassNameCustom = GetType().FullName.Replace("_Invoker", "").Replace("Incasbo.Api.Gdo", "Incasbo.CustomApi.Gdo");
		_IsCustomized = true;
	}

	protected virtual AppAbstractApi InstantiateApi(ref AppApiContext objApiContext, string ClassName, string ClassNameCustom)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
		string text = localPath + "\\GdoApiCustom.dll";
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
