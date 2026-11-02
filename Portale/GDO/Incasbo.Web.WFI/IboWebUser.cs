using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebUser : IboWebUserUser
{
	protected IboWebGroup _objGroup;

	protected IboWebOrganization _objOrganization;

	public IboWebGroup Group => _objGroup;

	public IboWebOrganization Organization => _objOrganization;

	public IboWebUser(string sCodice, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
		: base(sCodice, ref rObjCallStackHandler, ref rObjLogHandling, ref rObjDbMain, ref rObjParam, ref rObjWfiConfig)
	{
	}

	public override FXRETURN Load(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
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
					rsMess = $"User {_objWebUserInfo.Codice} is inactive";
				}
				else if (Operators.CompareString(_objWebUserInfo.Attivo, "B", false) == 0)
				{
					rsMess = $"User {_objWebUserInfo.Codice} is blocked";
				}
				else
				{
					if (Operators.CompareString(_objWebUserInfo.Gruppo, "", false) == 0)
					{
						goto IL_0625;
					}
					_objGroup = new IboWebGroup(_objWebUserInfo.Gruppo, _objCallStackHandler, ref _objLogHandling, ref _dbMain, ref _objParam, ref _wfiConfig);
					if ((int)_objGroup.Load(ref rsMess) <= 0)
					{
						_objOrganization = _objGroup.Organization;
						_objWebUserInfo.CodiciSoggetti = _objGroup.WebUserInfo.CodiciSoggetti;
						if (Operators.CompareString(_objWebUserInfo.PaginaIniziale, "", false) == 0)
						{
							_objWebUserInfo.PaginaIniziale = _objGroup.WebUserInfo.PaginaIniziale;
							if (Operators.CompareString(_objWebUserInfo.PaginaIniziale, "", false) == 0)
							{
								_objWebUserInfo.PaginaIniziale = _objOrganization.WebUserInfo.PaginaIniziale;
								if (Operators.CompareString(_objWebUserInfo.PaginaIniziale, "", false) == 0)
								{
									_objWebUserInfo.PaginaIniziale = "~\\WFI\\Form\\WFIDesktop2.aspx";
								}
							}
						}
						_objWebUserInfo.Peso = Math.Max(Math.Max(_objWebUserInfo.Peso, _objGroup.WebUserInfo.Peso), _objOrganization.WebUserInfo.Peso);
						if (Operators.CompareString(_objWebUserInfo.FilialeDefault, "", false) == 0)
						{
							_objWebUserInfo.FilialeDefault = _objGroup.WebUserInfo.FilialeDefault;
							if (Operators.CompareString(_objWebUserInfo.FilialeDefault, "", false) == 0)
							{
								_objWebUserInfo.FilialeDefault = _objOrganization.WebUserInfo.FilialeDefault;
							}
						}
						if (_objOrganization != null)
						{
							_objWebUserInfo.Organizzazione = _objGroup.WebUserInfo.Organizzazione;
							_objWebUserInfo.OrganizzazioneInternaEsterna = _objOrganization.WebUserInfo.OrganizzazioneInternaEsterna;
							_objWebUserInfo.OrganizzazioneTipoSoggetto = _objOrganization.WebUserInfo.OrganizzazioneTipoSoggetto;
							_objWebUserInfo.CampoFiltroSoggetto = _objOrganization.WebUserInfo.CampoFiltroSoggetto;
							_objWebUserInfo.CampoFiltroSoggetto2 = _objOrganization.WebUserInfo.CampoFiltroSoggetto2;
							_objWebUserInfo.CampoFiltroSoggetto3 = _objOrganization.WebUserInfo.CampoFiltroSoggetto3;
							_objWebUserInfo.FiltroSoggetto = _objOrganization.WebUserInfo.FiltroSoggetto;
						}
						if (Operators.CompareString(_objWebUserInfo.AbilitazioneFiltroUtente, "X", false) == 0)
						{
							if (Operators.CompareString(_objGroup.WebUserInfo.AbilitazioneFiltroUtente, "S", false) == 0)
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "S";
							}
							else
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "N";
							}
						}
						if (Operators.CompareString(_objWebUserInfo.AbilitazioneFiltroUtente, "S", false) == 0)
						{
							_objWebUserInfo.FiltroUtente = "WFIUtente=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice);
						}
						string text2 = "";
						if (Operators.CompareString(_objWebUserInfo.FiltroUtente, "", false) != 0)
						{
							text2 = "(" + _objWebUserInfo.FiltroUtente + ")";
						}
						if (Operators.CompareString(_objWebUserInfo.Filtro, "", false) != 0)
						{
							if (Operators.CompareString(text2, "", false) != 0)
							{
								text2 += " AND ";
							}
							text2 = "(" + _objWebUserInfo.Filtro + ")";
						}
						if (Operators.CompareString(_objGroup.WebUserInfo.Filtro, "", false) != 0)
						{
							if (Operators.CompareString(text2, "", false) != 0)
							{
								text2 += " AND ";
							}
							text2 = text2 + "(" + _objGroup.WebUserInfo.Filtro + ")";
						}
						if (Operators.CompareString(_objOrganization.WebUserInfo.Filtro, "", false) != 0)
						{
							if (Operators.CompareString(text2, "", false) != 0)
							{
								text2 += " AND ";
							}
							text2 = text2 + "(" + _objOrganization.WebUserInfo.Filtro + ")";
						}
						text2 = text2.Replace("<%UTENTE%>", _objWebUserInfo.Codice);
						text2 = text2.Replace("<%GRUPPO%>", _objWebUserInfo.Gruppo);
						text2 = text2.Replace("<%ORGANIZZAZIONE%>", _objWebUserInfo.Organizzazione);
						_objWebUserInfo.Filtro = text2;
						goto IL_0625;
					}
				}
			}
			goto end_IL_000b;
			IL_0625:
			if (Operators.CompareString(_objWebUserInfo.MenuProfileID, "", false) == 0 && _objGroup != null)
			{
				if (Operators.CompareString(_objGroup.WebUserInfo.MenuProfileID, "", false) != 0)
				{
					_objWebUserInfo.MenuProfileID = _objGroup.WebUserInfo.MenuProfileID;
				}
				else if (_objOrganization != null)
				{
					if (Operators.CompareString(_objOrganization.WebUserInfo.MenuProfileID, "", false) != 0)
					{
						_objWebUserInfo.MenuProfileID = _objOrganization.WebUserInfo.MenuProfileID;
					}
					else if (_objOrganization.OrganizationType != null && Operators.CompareString(_objOrganization.OrganizationType.WebUserInfo.MenuProfileID, "", false) != 0)
					{
						_objWebUserInfo.MenuProfileID = _objOrganization.OrganizationType.WebUserInfo.MenuProfileID;
					}
				}
			}
			if (Operators.CompareString(_objWebUserInfo.MenuProfileID, "", false) == 0)
			{
				if (Operators.CompareString(_objWebUserInfo.OrganizzazioneInternaEsterna, "I", false) == 0)
				{
					_objWebUserInfo.MenuProfileID = "XXX";
				}
				else
				{
					_objWebUserInfo.MenuProfileID = "YYY";
				}
			}
			if (Operators.CompareString(_objWebUserInfo.DesktopProfileID, "", false) == 0 && _objGroup != null)
			{
				if (Operators.CompareString(_objGroup.WebUserInfo.DesktopProfileID, "", false) != 0)
				{
					_objWebUserInfo.DesktopProfileID = _objGroup.WebUserInfo.DesktopProfileID;
				}
				else if (_objOrganization != null)
				{
					if (Operators.CompareString(_objOrganization.WebUserInfo.DesktopProfileID, "", false) != 0)
					{
						_objWebUserInfo.DesktopProfileID = _objOrganization.WebUserInfo.DesktopProfileID;
					}
					else if (_objOrganization.OrganizationType != null && Operators.CompareString(_objOrganization.OrganizationType.WebUserInfo.DesktopProfileID, "", false) != 0)
					{
						_objWebUserInfo.DesktopProfileID = _objOrganization.OrganizationType.WebUserInfo.DesktopProfileID;
					}
				}
			}
			if (Operators.CompareString(_objWebUserInfo.DesktopProfileID, "", false) == 0)
			{
				if (Operators.CompareString(_objWebUserInfo.OrganizzazioneInternaEsterna, "I", false) == 0)
				{
					_objWebUserInfo.DesktopProfileID = "XXX";
				}
				else
				{
					_objWebUserInfo.DesktopProfileID = "YYY";
				}
			}
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!disposedValue)
		{
			if (disposing)
			{
			}
			_objGroup.Dispose();
			_objGroup = null;
		}
		disposedValue = true;
	}
}
