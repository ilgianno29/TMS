using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebGroup : IboWebUserGroup
{
	protected IboWebOrganization _objOrganization;

	public IboWebOrganization Organization => _objOrganization;

	public IboWebGroup(string sCodice, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
		: base(sCodice, ref rObjCallStackHandler, ref rObjLogHandling, ref rObjDbMain, ref rObjParam, ref rObjWfiConfig)
	{
	}

	public override FXRETURN Load(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
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
				_objWebUserInfo.Gruppo = "";
				if (Operators.CompareString(_objWebUserInfo.Attivo, "N", false) == 0)
				{
					rsMess = $"Group {_objWebUserInfo.Codice} is inactive";
				}
				else if (Operators.CompareString(_objWebUserInfo.Attivo, "B", false) == 0)
				{
					rsMess = $"Group {_objWebUserInfo.Codice} is blocked";
				}
				else
				{
					if (Operators.CompareString(_objWebUserInfo.Organizzazione, "", false) == 0)
					{
						goto IL_0274;
					}
					_objOrganization = new IboWebOrganization(_objWebUserInfo.Organizzazione, _objCallStackHandler, ref _objLogHandling, ref _dbMain, ref _objParam, ref _wfiConfig);
					if ((int)_objOrganization.Load(ref rsMess) <= 0)
					{
						if (_objOrganization != null)
						{
							_objWebUserInfo.OrganizzazioneInternaEsterna = _objOrganization.WebUserInfo.OrganizzazioneInternaEsterna;
							_objWebUserInfo.OrganizzazioneTipoSoggetto = _objOrganization.WebUserInfo.OrganizzazioneTipoSoggetto;
							_objWebUserInfo.CampoFiltroSoggetto = _objOrganization.WebUserInfo.CampoFiltroSoggetto;
							_objWebUserInfo.CampoFiltroSoggetto2 = _objOrganization.WebUserInfo.CampoFiltroSoggetto2;
							_objWebUserInfo.CampoFiltroSoggetto3 = _objOrganization.WebUserInfo.CampoFiltroSoggetto3;
							_objWebUserInfo.FiltroSoggetto = _objOrganization.WebUserInfo.FiltroSoggetto;
							_objWebUserInfo.CodiciSoggetti = _objOrganization.WebUserInfo.CodiciSoggetti;
						}
						if (Operators.CompareString(_objWebUserInfo.AbilitazioneFiltroUtente, "X", false) == 0)
						{
							if (Operators.CompareString(_objOrganization.WebUserInfo.AbilitazioneFiltroUtente, "S", false) == 0)
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "S";
							}
							else
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "N";
							}
						}
						goto IL_0274;
					}
				}
			}
			goto end_IL_000b;
			IL_0274:
			val = (FXRETURN)0;
			end_IL_000b:;
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
