using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IboAppCallStackHandling
{
	private string sStackTrace;

	public string CallStack => sStackTrace;

	public IboAppCallStackHandling()
	{
		sStackTrace = "";
		sStackTrace = "";
	}

	public void CallStackAdd()
	{
		StackTrace stackTrace = new StackTrace();
		string text = sStackTrace;
		checked
		{
			int num = stackTrace.FrameCount - 1;
			int i;
			for (i = 0; i <= num && Operators.CompareString(stackTrace.GetFrame(i).GetMethod().Name.ToUpper(), "CALLSTACKADD", false) == 0; i++)
			{
			}
			text = stackTrace.GetFrame(i).GetMethod().ReflectedType.Name + "." + stackTrace.GetFrame(i).GetMethod().Name + "\\" + text;
			stackTrace = null;
			sStackTrace = text;
		}
	}

	public void CallStackRemove()
	{
		string text = sStackTrace;
		text = text.Remove(0, checked(text.IndexOf("\\") + 1));
		sStackTrace = text;
	}

	public void CallStackReset()
	{
		sStackTrace = "";
	}
}
