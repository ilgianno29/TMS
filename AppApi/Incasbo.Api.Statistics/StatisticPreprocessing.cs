using System;
using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Statistics;

public class StatisticPreprocessing : AppBaseClass
{
	public StatisticPreprocessing(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected new void Init(AppApiContext objApiContext)
	{
		base.Init(objApiContext);
	}

	protected new void Init(ref DBConnection objDbConn, ref IncasTranslator objTranslator, ref IboAppCallStackHandling objCallStackHandler, ref IboAppLogHandling objLogHandler, ref IboWebParam objParametrica, string sAppUser, string sAppGroup, string sAppOrganization, string sAppOrganizationType, string sAppOrganizationInternalExternal)
	{
		base.Init(ref objDbConn, ref objTranslator, ref objCallStackHandler, ref objLogHandler, ref objParametrica, sAppUser, sAppGroup, sAppOrganization, sAppOrganizationType, sAppOrganizationInternalExternal);
	}

	public virtual modGeneral.FXRETURN StartPreProcessing(Statistic stat, ref List<StatisticRunningFilter> FilterToApply, ref string FileNameOutput, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			FileNameOutput = "";
			fXRETURN = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = fXRETURN;
			CallStackRemove();
		}
		return result;
	}
}
