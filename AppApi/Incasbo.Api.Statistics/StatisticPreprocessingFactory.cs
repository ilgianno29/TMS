using System;
using System.IO;
using System.Reflection;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Statistics;

internal class StatisticPreprocessingFactory
{
	public static StatisticPreprocessing GetInstance(string ClassNameParam, AppApiContext objApiContext)
	{
		string text = "";
		string text2 = "";
		if (ClassNameParam.Contains(";"))
		{
			string[] array = ClassNameParam.Split(new char[1] { ';' });
			text = array[0];
			text2 = array[1];
			if (Operators.CompareString(text, "", false) == 0)
			{
				return null;
			}
			string text3 = "";
			text3 = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			text3 = text3 + "\\" + text;
			return (StatisticPreprocessing)IncasReflection.InstantiateClass(text2, ref text3, new object[1] { objApiContext });
		}
		return new StatisticPreprocessing(objApiContext);
	}
}
