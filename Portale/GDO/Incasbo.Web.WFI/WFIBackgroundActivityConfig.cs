using System;
using System.Collections.Generic;

namespace Incasbo.Web.WFI;

public class WFIBackgroundActivityConfig
{
	public class WFIBackgroundActivityConfig_Period
	{
		public TimeSpan From { get; set; }

		public TimeSpan To { get; set; }
	}

	public string BackgroundActivityTypeName { get; set; }

	public int BackgroundActivityTimerLoop { get; set; }

	public bool BackgroundActivityEnabled { get; set; }

	public List<WFIBackgroundActivityConfig_Period> BackgroundActivityPeriods { get; set; }

	public WFIBackgroundActivityConfig()
	{
		BackgroundActivityTypeName = "Incasbo.Web.GDO.GdoBackgroundActivity";
		BackgroundActivityTimerLoop = 60000;
		BackgroundActivityEnabled = true;
	}
}
