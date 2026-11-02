using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFICustom;

public class WFIGridPostBackElaboraApp : AppBaseClass, IWFIGrdPostBackElabora
{
	public FXRETURN WFIPostbackRun_Elabora(WFIPage frm, string CommandName, string CommandArgument, ref bool Elaborato, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			((AppBaseClass)this).Init(frm.CreateApiContext());
			this.CallStackAdd();
			Elaborato = false;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	FXRETURN IWFIGrdPostBackElabora.WFIPostbackRun_Elabora(WFIPage frm, string CommandName, string CommandArgument, ref bool Elaborato, ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in WFIPostbackRun_Elabora
		return this.WFIPostbackRun_Elabora(frm, CommandName, CommandArgument, ref Elaborato, ref rsMess);
	}
}
