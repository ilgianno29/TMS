using System;
using System.Web;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboResourceManager
{
	protected IboSessionEnvironment SessionEnvironment;

	public IboResourceManager()
	{
		SessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
	}

	public FXRETURN Resource_Check(IIboResource ObjResource, ref string rsMess)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		return Resource_Check(ObjResource.ResourceName, SessionEnvironment.WebUser.WebUserInfo.Codice, SessionEnvironment.WebUser.WebUserInfo.Gruppo, "XXX", "XXX", ref rsMess);
	}

	public FXRETURN Resource_Check(string sNomeRisorsa, ref string rsMess)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		return Resource_Check(sNomeRisorsa, SessionEnvironment.WebUser.WebUserInfo.Codice, SessionEnvironment.WebUser.WebUserInfo.Gruppo, "XXX", "XXX", ref rsMess);
	}

	public FXRETURN Resource_Check(string sNomeRisorsa, string sUtente, string sGruppo, string sDitta, string sFiliale, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		object obj = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			SessionEnvironment.CallStackHandler.CallStackAdd();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = SessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			SessionEnvironment.CallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
