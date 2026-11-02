using System;
using Microsoft.VisualBasic;

namespace Incasbo.Web.WFI;

public class WFIProgressbarClientInfo
{
	public string Title { get; set; }

	public string MainMessage { get; set; }

	public string DetailMessage { get; set; }

	public decimal Percentage { get; set; }

	public bool PercentageVisible { get; set; }

	public DateTime StartDateTime { get; set; }

	public int TimeElapsed { get; set; }

	public WFIProgressbarType ProgressbarType { get; set; }

	public WFIProgressbarClientInfo()
	{
		Title = "";
		MainMessage = "";
		DetailMessage = "";
		Percentage = 0m;
		PercentageVisible = true;
		StartDateTime = DateAndTime.Now;
		TimeElapsed = 0;
		ProgressbarType = WFIProgressbarType.ProgressbarWithPercentage;
	}
}
