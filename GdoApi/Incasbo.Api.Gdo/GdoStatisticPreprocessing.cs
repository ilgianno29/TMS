using System;
using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Api.Statistics;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class GdoStatisticPreprocessing : StatisticPreprocessing
{
	public GdoStatisticPreprocessing(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public override FXRETURN StartPreProcessing(Statistic stat, ref List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			this.CallStackAdd();
			FileNameOutput = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			this.CallStackRemove();
		}
		return result;
	}
}
