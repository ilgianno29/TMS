using System;
using System.ComponentModel;
using System.Web.Services;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSC;

[WebService(Namespace = "http://www.incasgroup.com/bologna/GdoWSC")]
[ToolboxItem(false)]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class GdoWSC : WSCStateWith
{
	protected override string ServiceName()
	{
		return "GdoWSC";
	}

	protected override FXRETURN LoginComplete(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			val2 = base.LoginComplete(ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN LogoutComplete(ref string rsMess)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN result = default(FXRETURN);
		return result;
	}

	protected override FXRETURN LogoutBegin(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return base.LogoutBegin(ref rsmess);
	}

	protected override FXRETURN AutenticazioneUtente(string sUtente, string sPassword, ref string rsmess)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return base.AutenticazioneUtente(sUtente, sPassword, ref rsmess);
	}
}
