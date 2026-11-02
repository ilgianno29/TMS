using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIGridDoPostbackManager
{
	public FXRETURN RunEvent(WFIPage frm, string CommandName, string CommandArgument, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			bool Elaborato = false;
			IWFIGrdPostBackElabora iWFIGrdPostBackElabora = null;
			try
			{
				string text = "";
				iWFIGrdPostBackElabora = (IWFIGrdPostBackElabora)IncasReflection.InstantiateClass("Incasbo.Web.WFICustom.WFIGridPostBackElaboraApp", ref text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (iWFIGrdPostBackElabora == null)
			{
				goto IL_006e;
			}
			val2 = iWFIGrdPostBackElabora.WFIPostbackRun_Elabora(frm, CommandName, CommandArgument, ref Elaborato, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_006e;
			}
			val = val2;
			goto end_IL_0005;
			IL_006e:
			if (Elaborato)
			{
				goto IL_00d6;
			}
			iWFIGrdPostBackElabora = null;
			try
			{
				string text = "";
				iWFIGrdPostBackElabora = (IWFIGrdPostBackElabora)IncasReflection.InstantiateClass("Incasbo.Web.WFICustom.WFIGridPostBackElaboraCustom", ref text);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			if (iWFIGrdPostBackElabora == null)
			{
				goto IL_00d6;
			}
			val2 = iWFIGrdPostBackElabora.WFIPostbackRun_Elabora(frm, CommandName, CommandArgument, ref Elaborato, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_00d6;
			}
			val = val2;
			goto end_IL_0005;
			IL_00d6:
			val = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			rsMess = ex6.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	private FXRETURN HandleError(Exception ex, string rsMess)
	{
		throw new NotImplementedException();
	}
}
