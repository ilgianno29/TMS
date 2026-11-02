using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIDesktopIframe : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesktopContainer")]
	protected virtual Panel DesktopContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesktopIFrame")]
	protected virtual HtmlGenericControl DesktopIFrame
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private ListOfItem GetListOfItem => (ListOfItem)_SessionVariable["ListOfItem"];

	public WFIDesktopIframe()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		try
		{
			if (!((Page)this).IsPostBack)
			{
				ListOfItem listOfItem = new ListOfItem();
				IframeItem iframeItem = new IframeItem();
				iframeItem.Id = "1";
				iframeItem.Width = 400;
				iframeItem.Height = 280;
				iframeItem.Url = "http://www.repubblica.it";
				iframeItem.Title = "Repubblica";
				listOfItem.Add(iframeItem);
				IframeItem iframeItem2 = new IframeItem();
				iframeItem2.Id = "1";
				iframeItem2.Width = 400;
				iframeItem2.Height = 280;
				iframeItem2.Url = "http://msdn.microsoft.com";
				iframeItem2.Title = "Msdn";
				listOfItem.Add(iframeItem2);
				_SessionVariable.Add("ListOfItem", listOfItem);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
