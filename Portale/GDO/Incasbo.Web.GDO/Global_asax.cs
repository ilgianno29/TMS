using System;
using System.Runtime.CompilerServices;
using System.Web;
using Incasbo.Web.WFI;

namespace Incasbo.Web.GDO;

public class Global_asax : HttpApplication
{
	protected static WFIHttpApplicationEventHandler _WfiHttpApplicationEventHandler;

	public override void Init()
	{
		((HttpApplication)this).Init();
	}

	public void Application_Start(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler = new WFIHttpApplicationEventHandler();
		_WfiHttpApplicationEventHandler.Init((HttpApplication)(object)this);
		((HttpApplication)this).Application["WFIApplicationVariables"] = new IboApplicationVariables();
	}

	public void Session_Start(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Session_Start(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_BeginRequest(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_BeginRequest(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_EndRequest(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_EndRequest(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_PreRequestHandlerExecute(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_PreRequestHandlerExecute(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_PostRequestHandlerExecute(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_PostRequestHandlerExecute(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_AuthenticateRequest(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_AuthenticateRequest(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_Error(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_Error(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Session_End(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Session_End(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void Application_End(object sender, EventArgs e)
	{
		_WfiHttpApplicationEventHandler.Application_End(RuntimeHelpers.GetObjectValue(sender), e);
		_WfiHttpApplicationEventHandler = null;
	}
}
