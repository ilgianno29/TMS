using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Incasbo.Web.WFI;

public class WFIProgressbarMessage
{
	public string Title { get; set; }

	public string MainMessage { get; set; }

	public decimal Percentage { get; set; }

	public bool PercentageVisible { get; set; }

	public string DetailMessage { get; set; }

	public int RefreshInterval { get; set; }

	public bool StopTask { get; set; }

	public WFIProgressbarType ProgressbarType { get; set; }

	public DateTime StartDateTime { get; set; }

	public Dictionary<string, object> OtherInfo { get; set; }

	public WFIProgressbarMessage()
	{
		Title = "";
		MainMessage = "";
		Percentage = 0m;
		PercentageVisible = true;
		DetailMessage = "";
		RefreshInterval = 1000;
		StopTask = false;
		ProgressbarType = WFIProgressbarType.ProgressbarWithPercentage;
		StartDateTime = DateAndTime.Now;
		OtherInfo = new Dictionary<string, object>();
	}

	public void Reset()
	{
		Title = "";
		MainMessage = "";
		Percentage = 0m;
		DetailMessage = "";
		RefreshInterval = 1000;
		StopTask = false;
		PercentageVisible = true;
		ProgressbarType = WFIProgressbarType.ProgressbarWithPercentage;
		StartDateTime = DateAndTime.Now;
		OtherInfo = new Dictionary<string, object>();
	}
}
