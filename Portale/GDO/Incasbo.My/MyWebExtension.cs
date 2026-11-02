using System.ComponentModel.Design;
using System.Diagnostics;
using System.Web;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;

namespace Incasbo.My;

[StandardModule]
[HideModuleName]
internal sealed class MyWebExtension
{
	private static Incasbo.My.MyProject.ThreadSafeObjectProvider<ServerComputer> s_Computer = new Incasbo.My.MyProject.ThreadSafeObjectProvider<ServerComputer>();

	private static Incasbo.My.MyProject.ThreadSafeObjectProvider<WebUser> s_User = new Incasbo.My.MyProject.ThreadSafeObjectProvider<WebUser>();

	private static Incasbo.My.MyProject.ThreadSafeObjectProvider<AspLog> s_Log = new Incasbo.My.MyProject.ThreadSafeObjectProvider<AspLog>();

	internal static ServerComputer Computer => s_Computer.GetInstance;

	internal static WebUser User => s_User.GetInstance;

	[HelpKeyword("My.Request")]
	internal static HttpRequest Request
	{
		[DebuggerHidden]
		get
		{
			HttpContext current = HttpContext.Current;
			if (current != null)
			{
				return current.Request;
			}
			return null;
		}
	}

	[HelpKeyword("My.Response")]
	internal static HttpResponse Response
	{
		[DebuggerHidden]
		get
		{
			HttpContext current = HttpContext.Current;
			if (current != null)
			{
				return current.Response;
			}
			return null;
		}
	}

	internal static AspLog Log => s_Log.GetInstance;
}
