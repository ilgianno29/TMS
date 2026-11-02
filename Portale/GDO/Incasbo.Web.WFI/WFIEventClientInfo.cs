using System;
using Microsoft.VisualBasic;

namespace Incasbo.Web.WFI;

public class WFIEventClientInfo
{
	public string Id { get; set; }

	public string Message1 { get; set; }

	public string Message2 { get; set; }

	public string Message3 { get; set; }

	public int RefreshInterval { get; set; }

	public bool StopTask { get; set; }

	public DateTime StartDateTime { get; set; }

	public DateTime EndDateTime { get; set; }

	public WFIEventClientInfo()
	{
		Id = "";
		Message1 = "";
		Message2 = "";
		Message3 = "";
		RefreshInterval = 5000;
		StopTask = false;
		StartDateTime = DateAndTime.Now;
		EndDateTime = DateAndTime.Now;
	}
}
