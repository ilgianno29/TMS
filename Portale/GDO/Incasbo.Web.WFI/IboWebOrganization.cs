using System;
using System.Data;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebOrganization : IboWebUserOrganization
{
	protected IboWebOrganizationType _objOrganizationType;

	public IboWebOrganizationType OrganizationType => _objOrganizationType;

	public IboWebOrganization(string sCodice, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
		: base(sCodice, ref rObjCallStackHandler, ref rObjLogHandling, ref rObjDbMain, ref rObjParam, ref rObjWfiConfig)
	{
	}

	public override FXRETURN Load(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Invalid comparison between Unknown and I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
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
					rsMess = $"Organization {_objWebUserInfo.Codice} is inactive";
				}
				else if (Operators.CompareString(_objWebUserInfo.Attivo, "B", false) == 0)
				{
					rsMess = $"Organization {_objWebUserInfo.Codice} is blocked";
				}
				else
				{
					if (Operators.CompareString(_objWebUserInfo.OrganizzazioneTipoSoggetto, "", false) == 0)
					{
						_objWebUserInfo.OrganizzazioneTipoSoggetto = "XXX";
					}
					_objOrganizationType = new IboWebOrganizationType(_objWebUserInfo.OrganizzazioneTipoSoggetto, _objCallStackHandler, ref _objLogHandling, ref _dbMain, ref _objParam, ref _wfiConfig);
					if ((int)_objOrganizationType.Load(ref rsMess) <= 0)
					{
						_objWebUserInfo.Gruppo = "";
						_objWebUserInfo.Organizzazione = "";
						_objWebUserInfo.CampoFiltroSoggetto = _objOrganizationType.WebUserInfo.CampoFiltroSoggetto;
						_objWebUserInfo.CampoFiltroSoggetto2 = _objOrganizationType.WebUserInfo.CampoFiltroSoggetto2;
						_objWebUserInfo.CampoFiltroSoggetto3 = _objOrganizationType.WebUserInfo.CampoFiltroSoggetto3;
						_objWebUserInfo.FiltroSoggetto = "";
						if (Operators.CompareString(_objWebUserInfo.AbilitazioneFiltroUtente, "X", false) == 0)
						{
							if (Operators.CompareString(_objOrganizationType.WebUserInfo.AbilitazioneFiltroUtente, "S", false) == 0)
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "S";
							}
							else
							{
								_objWebUserInfo.AbilitazioneFiltroUtente = "N";
							}
						}
						if (Operators.CompareString(_objWebUserInfo.CampoFiltroSoggetto, "", false) == 0)
						{
							goto IL_04d2;
						}
						bool flag = default(bool);
						val2 = _dbMain.TableOrViewExists("WFI_Utenti_Soggetti", ref flag, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (!flag)
							{
								goto IL_04d2;
							}
							text = "SELECT * FROM WFI_Utenti_Soggetti WHERE Utente=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice) + " ";
							val2 = _dbMain.OpenDataTable(text, ref dataTable, ref rsMess);
							if ((int)val2 <= 0)
							{
								string text2 = "";
								string text3 = "";
								foreach (DataRow row in dataTable.Rows)
								{
									text2 = text2 + _dbMain.SQLFormatString(row["CodiceSoggetto"].ToString()) + ",";
									if (!_objWebUserInfo.CodiciSoggetti.Contains(row["CodiceSoggetto"].ToString()))
									{
										_objWebUserInfo.CodiciSoggetti.Add(row["CodiceSoggetto"].ToString());
									}
								}
								if (Operators.CompareString(text2, "", false) != 0)
								{
									text2 = Strings.Mid(text2, 1, checked(Strings.Len(text2) - 1));
									text3 = "(" + _objWebUserInfo.CampoFiltroSoggetto + " IN (" + text2 + "))";
									if (Operators.CompareString(_objWebUserInfo.CampoFiltroSoggetto2, "", false) != 0)
									{
										text3 = text3 + " OR (" + _objWebUserInfo.CampoFiltroSoggetto2 + " IN (" + text2 + "))";
									}
									if (Operators.CompareString(_objWebUserInfo.CampoFiltroSoggetto3, "", false) != 0)
									{
										text3 = text3 + " OR (" + _objWebUserInfo.CampoFiltroSoggetto3 + " IN (" + text2 + "))";
									}
									_objWebUserInfo.FiltroSoggetto = "(" + text3 + ")";
								}
								goto IL_04d2;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_000e;
			IL_04d2:
			val = (FXRETURN)0;
			end_IL_000e:;
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
