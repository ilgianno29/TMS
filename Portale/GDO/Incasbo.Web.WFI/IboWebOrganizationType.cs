using System;
using System.Linq;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebOrganizationType : IboWebUserOrganizationType
{
	public IboWebOrganizationType(string sCodice, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
		: base(sCodice, ref rObjCallStackHandler, ref rObjLogHandling, ref rObjDbMain, ref rObjParam, ref rObjWfiConfig)
	{
	}

	public override FXRETURN Load(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = base.Load(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(_objWebUserInfo.Attivo, "N", false) == 0)
				{
					rsMess = $"Organization type {_objWebUserInfo.Codice} is inactive";
				}
				else if (Operators.CompareString(_objWebUserInfo.Attivo, "B", false) == 0)
				{
					rsMess = $"Organization type {_objWebUserInfo.Codice} is blocked";
				}
				else
				{
					_objWebUserInfo.Gruppo = "";
					_objWebUserInfo.Organizzazione = "";
					_objWebUserInfo.OrganizzazioneTipoSoggetto = "";
					_objWebUserInfo.CampoFiltroSoggetto = "";
					_objWebUserInfo.CampoFiltroSoggetto2 = "";
					_objWebUserInfo.CampoFiltroSoggetto3 = "";
					string[] array = _objWebUserInfo.Filtro.Split(new char[1] { ';' });
					if (array.Count() > 0)
					{
						_objWebUserInfo.CampoFiltroSoggetto = array[0];
					}
					if (array.Count() > 1)
					{
						_objWebUserInfo.CampoFiltroSoggetto2 = array[1];
					}
					if (array.Count() > 2)
					{
						_objWebUserInfo.CampoFiltroSoggetto3 = array[2];
					}
					_objWebUserInfo.Filtro = "";
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
