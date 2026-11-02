using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;
using Incasbo.Web.WSCWCF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

#if NETFRAMEWORK
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
#else
[CoreWCF.ServiceBehavior(InstanceContextMode = CoreWCF.InstanceContextMode.PerSession)]
#endif
public class TMSApiService : IncasWCFStandardAuth, ITMSApiService
{
	protected DBConnection DBConn => SessionEnvironment.DbMain;

	public TMSApiService()
	{
		_WSDBConfigFile = "WCFDBConfig_Api.ini";
		_WSAppConfigFile = "WSCWCFConfig_Api.ini";
	}

	public override string GetVersion()
	{
		return base.GetVersion();
	}

	string ITMSApiService.GetVersion()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetVersion
		return this.GetVersion();
	}

	public override bool TestDBConnection(ref string rsMess)
	{
		return base.TestDBConnection(ref rsMess);
	}

	bool ITMSApiService.TestDBConnection(ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestDBConnection
		return this.TestDBConnection(ref rsMess);
	}

	public override string TestPing(string sStringa)
	{
		return base.TestPing(sStringa);
	}

	string ITMSApiService.TestPing(string sStringa)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestPing
		return this.TestPing(sStringa);
	}

	public Result SpedizioneConfermaPrebolla(Sender sender, SpedizioneConfermaPrebollaArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string sNote = "UNIBOL=" + Args.Unibol;
				string rsmess2 = "";
				LogEventiMem("CONFERMA PREBOLLA", sNote, "", ref rsmess2);
				val2 = _SpedizioneConfermaPrebolla(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "UNIBOL=" + Args.Unibol;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("CONFERMA PREBOLLA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.SpedizioneConfermaPrebolla(Sender sender, SpedizioneConfermaPrebollaArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneConfermaPrebolla
		return this.SpedizioneConfermaPrebolla(sender, Args);
	}

	public Result SpedizioneAggiornaQuantita(Sender sender, SpedizioneAggiornaQuantitaArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string sNote = "UNIBOL=" + Args.Unibol;
				string rsmess2 = "";
				LogEventiMem("MODIFICA QTA BOLLA", sNote, "", ref rsmess2);
				val2 = _SpedizioneAggiornaQuantita(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "UNIBOL=" + Args.Unibol;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("MODIFICA QTA BOLLA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.SpedizioneAggiornaQuantita(Sender sender, SpedizioneAggiornaQuantitaArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneAggiornaQuantita
		return this.SpedizioneAggiornaQuantita(sender, Args);
	}

	public Result SpedizioneInserimento(Sender sender, ref SpedizioneInserimentoArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(Args.NumeroBolla + "", "", false) != 0)
				{
					if (!Args.DataBolla.HasValue)
					{
						Args.DataBolla = DateAndTime.Now.Date;
					}
					text = "NUMEROBOLLA=" + Args.NumeroBolla + " CLIENTE=" + Args.Cliente + " DATA=" + Args.DataBolla.Value.ToString("dd/MM/yyyy");
				}
				else if (Operators.CompareString(Args.NumeroOrdine + "", "", false) != 0 && !Args.DataOrdine.HasValue)
				{
					Args.DataOrdine = DateAndTime.Now.Date;
					text = "NUMEROORDINE=" + Args.NumeroOrdine + " CLIENTE=" + Args.Cliente + " DATA=" + Args.DataOrdine.Value.ToString("dd/MM/yyyy");
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("INSERIMENTO SPEDIZIONE", sNote, "", ref rsmess2);
				val2 = _SpedizioneInserimento(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("INSERIMENTO SPEDIZIONE", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.SpedizioneInserimento(Sender sender, ref SpedizioneInserimentoArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneInserimento
		return this.SpedizioneInserimento(sender, ref Args);
	}

	public Result SpedizioneInserimentoEAttivazione(Sender sender, ref SpedizioneInserimentoArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(Args.NumeroBolla + "", "", false) != 0)
				{
					if (!Args.DataBolla.HasValue)
					{
						Args.DataBolla = DateAndTime.Now.Date;
					}
					text = "NUMEROBOLLA=" + Args.NumeroBolla + " CLIENTE=" + Args.Cliente + " DATA=" + Args.DataBolla.Value.ToString("dd/MM/yyyy");
				}
				else if (Operators.CompareString(Args.NumeroOrdine + "", "", false) != 0 && !Args.DataOrdine.HasValue)
				{
					Args.DataOrdine = DateAndTime.Now.Date;
					text = "NUMEROORDINE=" + Args.NumeroOrdine + " CLIENTE=" + Args.Cliente + " DATA=" + Args.DataOrdine.Value.ToString("dd/MM/yyyy");
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("INSERIMENTO SPEDIZIONE", sNote, "", ref rsmess2);
				val2 = _SpedizioneInserimentoEAttivazione(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("INSERIMENTO SPEDIZIONE", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.SpedizioneInserimentoEAttivazione(Sender sender, ref SpedizioneInserimentoArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneInserimentoEAttivazione
		return this.SpedizioneInserimentoEAttivazione(sender, ref Args);
	}

	public Result SpedizioneImport(Sender sender, Api_SpedizioneImportArgs InArgs, ref SpedizioneBaseArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Invalid comparison between Unknown and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(InArgs.NumeroBolla + "", "", false) != 0)
				{
					if (!InArgs.DataBolla.HasValue)
					{
						InArgs.DataBolla = DateAndTime.Now.Date;
					}
					text = "NUMEROBOLLA=" + InArgs.NumeroBolla + " CLIENTE=" + InArgs.Cliente + " DATA=" + InArgs.DataBolla.Value.ToString("dd/MM/yyyy");
				}
				else if (Operators.CompareString(InArgs.NumeroOrdine + "", "", false) != 0 && !InArgs.DataOrdine.HasValue)
				{
					InArgs.DataOrdine = DateAndTime.Now.Date;
					text = "NUMEROORDINE=" + InArgs.NumeroOrdine + " CLIENTE=" + InArgs.Cliente + " DATA=" + InArgs.DataOrdine.Value.ToString("dd/MM/yyyy");
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("IMPORT SPEDIZIONE", sNote, "", ref rsmess2);
				val2 = _SpedizioneImport(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("IMPORT SPEDIZIONE", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.SpedizioneImport(Sender sender, Api_SpedizioneImportArgs InArgs, ref SpedizioneBaseArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneImport
		return this.SpedizioneImport(sender, InArgs, ref OutArgs);
	}

	public Result ViaggioCrea(Sender sender, ref Api_ViaggioInserisciArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = "TERMINALE=" + Args.Terminale + " ";
				}
				if (Operators.CompareString(Args.Autista1Pianificato + "", "", false) != 0)
				{
					text = text + "AUTISTA=" + Args.Autista1Pianificato + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO CREA", sNote, "", ref rsmess2);
				val2 = _ViaggioCrea(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO CREA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioCrea(Sender sender, ref Api_ViaggioInserisciArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioCrea
		return this.ViaggioCrea(sender, ref Args);
	}

	public Result ViaggioChiudi(Sender sender, Api_ViaggioChiudiArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "IDVIAGGIO=" + Args.IdViaggio + " ";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = text + "TERMINALE=" + Args.Terminale + " ";
				}
				if (Operators.CompareString(Args.Autista + "", "", false) != 0)
				{
					text = text + "AUTISTA=" + Args.Autista + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO CHIUDI", sNote, "", ref rsmess2);
				val2 = _ViaggioChiudi(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO CHIUDI", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioChiudi(Sender sender, Api_ViaggioChiudiArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioChiudi
		return this.ViaggioChiudi(sender, Args);
	}

	public Result ViaggioRiapri(Sender sender, Api_ViaggioRiapriArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "IDVIAGGIO=" + Args.IdViaggio + " ";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = text + "TERMINALE=" + Args.Terminale + " ";
				}
				if (Operators.CompareString(Args.Autista + "", "", false) != 0)
				{
					text = text + "AUTISTA=" + Args.Autista + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO RIAPRI", sNote, "", ref rsmess2);
				val2 = _ViaggioRiapri(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO RIAPRI", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioRiapri(Sender sender, Api_ViaggioRiapriArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioRiapri
		return this.ViaggioRiapri(sender, Args);
	}

	public Result ViaggioElimina(Sender sender, Api_ViaggioEliminaArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "IDVIAGGIO=" + Args.IdViaggio + " ";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = text + "TERMINALE=" + Args.Terminale + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO ELIMINA", sNote, "", ref rsmess2);
				val2 = _ViaggioElimina(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO ELIMINA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioElimina(Sender sender, Api_ViaggioEliminaArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioElimina
		return this.ViaggioElimina(sender, Args);
	}

	public Result ViaggioApertoRecupera(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string sNote = "VIAGGIO= " + InArgs.IdViaggio + " ";
				string rsmess2 = "";
				LogEventiMem("VIAGGIO APERTO RECUPERA", sNote, "", ref rsmess2);
				val2 = _ViaggioApertoRecupera(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO APERTO RECUPERA", sNote, sNote2, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioApertoRecupera(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioApertoRecupera
		return this.ViaggioApertoRecupera(sender, InArgs, ref OutArgs);
	}

	public Result ViaggioRecuperaUDS(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string sNote = "IDVIAGGIO=" + InArgs.IdViaggio;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO RECUPERA UDS", sNote, "", ref rsmess2);
				val2 = _ViaggioRecuperaUDS(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO RECUPERA UDS", sNote, sNote2, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioRecuperaUDS(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioRecuperaUDS
		return this.ViaggioRecuperaUDS(sender, InArgs, ref OutArgs);
	}

	public Result ViaggioLineaRecupera(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref List<Api_ViaggioLineaRecuperaOutArgs> OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "ID=" + InArgs.Id + " GIRO=" + InArgs.Giro;
				if (InArgs.DataPartenzaPianificata.HasValue)
				{
					text = text + " DATA=" + InArgs.DataPartenzaPianificata.Value.ToString("dd/MM/yyyy");
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO LINEA RECUPERA", sNote, "", ref rsmess2);
				val2 = _ViaggioLineaRecupera(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO LINEA RECUPERA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioLineaRecupera(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref List<Api_ViaggioLineaRecuperaOutArgs> OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioLineaRecupera
		return this.ViaggioLineaRecupera(sender, InArgs, ref OutArgs);
	}

	public Result ViaggioLineaRecuperaUDS(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "ID=" + InArgs.Id + " GIRO=" + InArgs.Giro;
				if (InArgs.DataPartenzaPianificata.HasValue)
				{
					text = text + " DATA=" + InArgs.DataPartenzaPianificata.Value.ToString("dd/MM/yyyy");
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO LINEA RECUPERA UDS", sNote, "", ref rsmess2);
				val2 = _ViaggioLineaRecuperaUDS(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO LINEA RECUPERA UDS", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioLineaRecuperaUDS(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioLineaRecuperaUDS
		return this.ViaggioLineaRecuperaUDS(sender, InArgs, ref OutArgs);
	}

	public Result ViaggioPartenza(Sender sender, Api_ViaggioPartenzaFineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "IDVIAGGIO=" + Args.IdViaggio + " ";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = "TERMINALE=" + Args.Terminale + " ";
				}
				if (Operators.CompareString(Args.AutistaEffettivo + "", "", false) != 0)
				{
					text = text + "AUTISTA=" + Args.AutistaEffettivo + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO PARTENZA", sNote, "", ref rsmess2);
				val2 = _ViaggioPartenza(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO PARTENZA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioPartenza(Sender sender, Api_ViaggioPartenzaFineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioPartenza
		return this.ViaggioPartenza(sender, Args);
	}

	public Result ViaggioFine(Sender sender, Api_ViaggioPartenzaFineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "IDVIAGGIO=" + Args.IdViaggio + " ";
				if (Operators.CompareString(Args.Terminale + "", "", false) != 0)
				{
					text = text + "TERMINALE=" + Args.Terminale + " ";
				}
				if (Operators.CompareString(Args.AutistaEffettivo + "", "", false) != 0)
				{
					text = text + "AUTISTA=" + Args.AutistaEffettivo + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("VIAGGIO FINE", sNote, "", ref rsmess2);
				val2 = _ViaggioPartenza(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("VIAGGIO FINE", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.ViaggioFine(Sender sender, Api_ViaggioPartenzaFineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ViaggioFine
		return this.ViaggioFine(sender, Args);
	}

	public Result UdsSpuntaUscita(Sender sender, Api_UdsSpuntaUscitaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(InArgs.Codice, "", false) != 0)
				{
					text = text + "CODICE= " + InArgs.Codice + " ";
				}
				if (Operators.CompareString(InArgs.Unibol, "", false) != 0)
				{
					text = text + "UNIBOL= " + InArgs.Unibol + " ";
				}
				if (Operators.CompareString(InArgs.UdsMaster, "", false) != 0)
				{
					text = text + "UDSMASTER= " + InArgs.UdsMaster + " ";
				}
				if (Operators.CompareString(InArgs.IdViaggio, "", false) != 0)
				{
					text = text + "VIAGGIO= " + InArgs.IdViaggio + " ";
				}
				if (Operators.CompareString(InArgs.IdViaggioLinea, "", false) != 0)
				{
					text = text + "VIAGGIO LINEA= " + InArgs.IdViaggioLinea + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("UDS SPUNTA USCITA", sNote, "", ref rsmess2);
				val2 = _UdsSpuntaUscita(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("UDS SPUNTA USCITA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.UdsSpuntaUscita(Sender sender, Api_UdsSpuntaUscitaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UdsSpuntaUscita
		return this.UdsSpuntaUscita(sender, InArgs, ref OutArgs);
	}

	public Result UdsSpuntaUscitaAnnulla(Sender sender, Api_UdsSpuntaUscitaAnnullaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				if (Operators.CompareString(InArgs.Codice, "", false) != 0)
				{
					text = text + "CODICE= " + InArgs.Codice + " ";
				}
				if (Operators.CompareString(InArgs.Unibol, "", false) != 0)
				{
					text = text + "UNIBOL= " + InArgs.Unibol + " ";
				}
				if (Operators.CompareString(InArgs.UdsMaster, "", false) != 0)
				{
					text = text + "UDSMASTER= " + InArgs.UdsMaster + " ";
				}
				if (Operators.CompareString(InArgs.IdViaggio, "", false) != 0)
				{
					text = text + "VIAGGIO= " + InArgs.IdViaggio + " ";
				}
				if (Operators.CompareString(InArgs.IdViaggioLinea, "", false) != 0)
				{
					text = text + "VIAGGIO LINEA= " + InArgs.IdViaggioLinea + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("UDS SPUNTA USCITA ANNULLA", sNote, "", ref rsmess2);
				val2 = _UdsSpuntaUscitaAnnulla(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("UDS SPUNTA USCITA ANNULLA", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.UdsSpuntaUscitaAnnulla(Sender sender, Api_UdsSpuntaUscitaAnnullaInArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UdsSpuntaUscitaAnnulla
		return this.UdsSpuntaUscitaAnnulla(sender, InArgs, ref OutArgs);
	}

	public Result UdsSpuntaUscitaMancanti(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string sNote = "VIAGGIO= " + InArgs.IdViaggio + " ";
				string rsmess2 = "";
				LogEventiMem("UDS SPUNTA USCITA MANCANTI", sNote, "", ref rsmess2);
				val2 = _UdsSpuntaUscitaMancanti(InArgs, ref OutArgs, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = rsmess;
					rsmess2 = "";
					LogEventiMem("UDS SPUNTA USCITA MANCANTI", sNote, sNote2, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.UdsSpuntaUscitaMancanti(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UdsSpuntaUscitaMancanti
		return this.UdsSpuntaUscitaMancanti(sender, InArgs, ref OutArgs);
	}

	public Result UdsRiassociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				checked
				{
					int num = Args.CodiceUds.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(Args.CodiceUds[i], "", false) != 0)
						{
							text = text + "UDS= " + Args.CodiceUds[i] + " ";
						}
						if (Operators.CompareString(Args.UdsMaster, "", false) != 0)
						{
							text = text + "UDSMASTER= " + Args.UdsMaster + " ";
						}
					}
					string sNote = text;
					string rsmess2 = "";
					LogEventiMem("UDS DISASSOCIA A UDT", sNote, "", ref rsmess2);
					val2 = _UdsRiassociaUdt(Args, ref rsmess);
				}
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					string rsmess2 = "";
					LogEventiMem("UDS DISASSOCIA A UDT", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.UdsRiassociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UdsRiassociaUdt
		return this.UdsRiassociaUdt(sender, Args);
	}

	public Result UdsAssociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(sender.Name, sender.Password, ref rsmess))
			{
				string text = "";
				checked
				{
					int num = Args.CodiceUds.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(Args.CodiceUds[i], "", false) != 0)
						{
							text = text + "UDS= " + Args.CodiceUds[i] + " ";
						}
						if (Operators.CompareString(Args.UdsMaster, "", false) != 0)
						{
							text = text + "UDSMASTER= " + Args.UdsMaster + " ";
						}
					}
					string sNote = text;
					string rsmess2 = "";
					LogEventiMem("UDS ASSOCIA A UDT", sNote, "", ref rsmess2);
					val2 = _UdsAssociaUdt(Args, ref rsmess);
				}
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					string rsmess2 = "";
					LogEventiMem("UDS ASSOCIA A UDT", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSApiService.UdsAssociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in UdsAssociaUdt
		return this.UdsAssociaUdt(sender, Args);
	}

	protected FXRETURN _SpedizioneConfermaPrebolla(SpedizioneConfermaPrebollaArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Invalid comparison between Unknown and I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Invalid comparison between Unknown and I4
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			SpedizioneBaseArgs Spedizione = Args;
			val2 = _IdentificaSpedizione(ref Spedizione, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				DBConn.BeginTransaction();
				string text = "";
				text = "UPDATE SPEDIZIONI SET UteAgg=" + DBConn.SQLFormatString(Username) + ", ";
				text += "DatAgg=GETDATE() ";
				if (Operators.CompareString(Args.NumeroBolla, "", false) != 0)
				{
					text = text + ",NUMEROBOLLA=" + DBConn.SQLFormatString(Args.NumeroBolla) + " ";
				}
				if (Args.DataBolla.HasValue)
				{
					text = text + ",DATABOLLA=" + DBConn.SQLFormatDate((eTipoData)1, Args.DataBolla.Value) + " ";
				}
				if (Args.Colli.HasValue)
				{
					string text2 = text;
					DBConnection dBConn = DBConn;
					int pNumero = Args.Colli.Value;
					text = text2 + ",COLLI=" + dBConn.SQLFormatNumber(ref pNumero) + " ";
				}
				if (Args.Peso.HasValue)
				{
					string text3 = text;
					DBConnection dBConn2 = DBConn;
					decimal pNumero2 = Args.Peso.Value;
					text = text3 + ",PESO=" + dBConn2.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.Pallet.HasValue)
				{
					string text4 = text;
					DBConnection dBConn3 = DBConn;
					int pNumero = Args.Pallet.Value;
					text = text4 + ",PALLET=" + dBConn3.SQLFormatNumber(ref pNumero) + " ";
				}
				if (Args.Volume.HasValue)
				{
					string text5 = text;
					DBConnection dBConn4 = DBConn;
					decimal pNumero2 = Args.Volume.Value;
					text = text5 + ",VOLUME=" + dBConn4.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text6 = text;
					DBConnection dBConn5 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo1.Value;
					text = text6 + ",CAMPOCALCOLO1=" + dBConn5.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo2.HasValue)
				{
					string text7 = text;
					DBConnection dBConn6 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo2.Value;
					text = text7 + ",CAMPOCALCOLO2=" + dBConn6.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo3.HasValue)
				{
					string text8 = text;
					DBConnection dBConn7 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo3.Value;
					text = text8 + ",CAMPOCALCOLO3=" + dBConn7.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text9 = text;
					DBConnection dBConn8 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo4.Value;
					text = text9 + ",CAMPOCALCOLO4=" + dBConn8.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text10 = text;
					DBConnection dBConn9 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo5.Value;
					text = text10 + ",CAMPOCALCOLO5=" + dBConn9.SQLFormatNumber(ref pNumero2) + " ";
				}
				text = text + " WHERE UNIBOL=" + DBConn.SQLFormatString(Args.Unibol);
				val2 = DBConn.SqlExec(text, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					val2 = Spedizione_ConfermaPrebolla_Invoker.Instance.RunProc(CreateApiContext(), Args.Unibol, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						DBConn.CommitTransaction();
						val = (FXRETURN)0;
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _SpedizioneAggiornaQuantita(SpedizioneAggiornaQuantitaArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			SpedizioneBaseArgs Spedizione = Args;
			val2 = _IdentificaSpedizione(ref Spedizione, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				DBConn.BeginTransaction();
				string text = "";
				text = "UPDATE SPEDIZIONI SET UteAgg=" + DBConn.SQLFormatString(Username) + ", ";
				text += "DatAgg=GETDATE() ";
				if (Args.Colli.HasValue)
				{
					string text2 = text;
					DBConnection dBConn = DBConn;
					int pNumero = Args.Colli.Value;
					text = text2 + ",COLLI=" + dBConn.SQLFormatNumber(ref pNumero) + " ";
				}
				if (Args.Peso.HasValue)
				{
					string text3 = text;
					DBConnection dBConn2 = DBConn;
					decimal pNumero2 = Args.Peso.Value;
					text = text3 + ",PESO=" + dBConn2.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.Pallet.HasValue)
				{
					string text4 = text;
					DBConnection dBConn3 = DBConn;
					int pNumero = Args.Pallet.Value;
					text = text4 + ",PALLET=" + dBConn3.SQLFormatNumber(ref pNumero) + " ";
				}
				if (Args.Volume.HasValue)
				{
					string text5 = text;
					DBConnection dBConn4 = DBConn;
					decimal pNumero2 = Args.Volume.Value;
					text = text5 + ",VOLUME=" + dBConn4.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text6 = text;
					DBConnection dBConn5 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo1.Value;
					text = text6 + ",CAMPOCALCOLO1=" + dBConn5.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo2.HasValue)
				{
					string text7 = text;
					DBConnection dBConn6 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo2.Value;
					text = text7 + ",CAMPOCALCOLO2=" + dBConn6.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo3.HasValue)
				{
					string text8 = text;
					DBConnection dBConn7 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo3.Value;
					text = text8 + ",CAMPOCALCOLO3=" + dBConn7.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text9 = text;
					DBConnection dBConn8 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo4.Value;
					text = text9 + ",CAMPOCALCOLO4=" + dBConn8.SQLFormatNumber(ref pNumero2) + " ";
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					string text10 = text;
					DBConnection dBConn9 = DBConn;
					decimal pNumero2 = Args.CampoCalcolo5.Value;
					text = text10 + ",CAMPOCALCOLO5=" + dBConn9.SQLFormatNumber(ref pNumero2) + " ";
				}
				text = text + " WHERE UNIBOL=" + DBConn.SQLFormatString(Args.Unibol);
				val2 = DBConn.SqlExec(text, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					DBConn.CommitTransaction();
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _SpedizioneInserimento(SpedizioneInserimentoArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Invalid comparison between Unknown and I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Spedizione Spedizione = new Spedizione();
			Spedizione.NumeroOrdine = Args.NumeroOrdine;
			Spedizione.DataOrdine = Args.DataOrdine;
			Spedizione.NumeroBolla = Args.NumeroBolla;
			Spedizione.DataBolla = Args.DataBolla;
			Spedizione.NumeroOrdineCliente = Args.NumeroOrdineCliente;
			Spedizione.DataOrdineCliente = Args.DataOrdineCliente;
			Spedizione.TipoServizio = Args.TipoServizio;
			Spedizione.Cliente = Args.Cliente;
			Spedizione.Mittente = Args.Mittente;
			Spedizione.MittenteRagioneSociale = Args.MittenteRagioneSociale;
			Spedizione.TipoSpedizione = Args.TipoSpedizione;
			Spedizione.TipoSpedizionePassivo = Args.TipoSpedizionePassivo;
			Spedizione.TipoMerce = Args.TipoMerce;
			Spedizione.Prebolla = "S";
			Spedizione.PCSPartenza = Args.PCSPartenza;
			Spedizione.PCSDestinazione = Args.PCSDestinazione;
			Spedizione.ZonaSpedizione = Args.ZonaSpedizione;
			Spedizione.ZonaPartenzaTariffaAttiva = Args.ZonaPartenzaTariffaAttiva;
			Spedizione.ZonaArrivoTariffaAttiva = Args.ZonaArrivoTariffaAttiva;
			Spedizione.ZonaPartenzaTariffaPassiva = Args.ZonaPartenzaTariffaPassiva;
			Spedizione.ZonaArrivoTariffaPassiva = Args.ZonaArrivoTariffaPassiva;
			Spedizione.DataConsegnaPrevista1 = Args.DataConsegnaPrevista1;
			Spedizione.DataConsegnaPrevista2 = Args.DataConsegnaPrevista2;
			Spedizione.NoteConsegnaPrevista = Args.NoteConsegnaPrevista;
			Spedizione.DataRitiroPrevista1 = Args.DataRitiroPrevista1;
			Spedizione.DataRitiroPrevista2 = Args.DataRitiroPrevista2;
			Spedizione.NoteRitiroPrevisto = Args.NoteRitiroPrevisto;
			Spedizione.Corrispondente = Args.Corrispondente;
			Spedizione.Peso = Args.Peso;
			Spedizione.Colli = Args.Colli;
			Spedizione.Pallet = Args.Pallet;
			Spedizione.Volume = Args.Volume;
			Spedizione.CampoCalcolo1 = Args.CampoCalcolo1;
			Spedizione.CampoCalcolo2 = Args.CampoCalcolo2;
			Spedizione.CampoCalcolo3 = Args.CampoCalcolo3;
			Spedizione.CampoCalcolo4 = Args.CampoCalcolo4;
			Spedizione.CampoCalcolo5 = Args.CampoCalcolo5;
			Spedizione.CampoCalcolo6 = Args.CampoCalcolo6;
			Spedizione.CampoCalcolo7 = Args.CampoCalcolo7;
			Spedizione.CampoCalcolo8 = Args.CampoCalcolo8;
			Spedizione.CampoCalcolo9 = Args.CampoCalcolo9;
			Spedizione.CampoCalcolo10 = Args.CampoCalcolo10;
			Spedizione.Flag1 = Args.Flag1;
			Spedizione.Flag2 = Args.Flag2;
			Spedizione.Flag3 = Args.Flag3;
			Spedizione.Flag4 = Args.Flag4;
			Spedizione.Flag5 = Args.Flag5;
			Spedizione.Flag6 = Args.Flag6;
			Spedizione.Flag7 = Args.Flag7;
			Spedizione.Flag8 = Args.Flag8;
			Spedizione.Flag9 = Args.Flag9;
			Spedizione.Flag10 = Args.Flag10;
			Spedizione.BloccoAmministrativo = Args.BloccoAmministrativo;
			Spedizione.Contrassegno = Args.Contrassegno;
			Spedizione.Note = Args.Note;
			Spedizione.FillerAlfa1 = Args.FillerAlfa1;
			Spedizione.FillerAlfa2 = Args.FillerAlfa2;
			Spedizione.FillerAlfa3 = Args.FillerAlfa3;
			Spedizione.FillerAlfa4 = Args.FillerAlfa4;
			Spedizione.FillerAlfa5 = Args.FillerAlfa5;
			Spedizione.FillerAlfa6 = Args.FillerAlfa6;
			Spedizione.FillerAlfa7 = Args.FillerAlfa7;
			Spedizione.FillerAlfa8 = Args.FillerAlfa8;
			Spedizione.FillerAlfa9 = Args.FillerAlfa9;
			Spedizione.FillerAlfa10 = Args.FillerAlfa10;
			Spedizione.FillerData1 = Args.FillerData1;
			Spedizione.FillerData2 = Args.FillerData2;
			Spedizione.FillerData3 = Args.FillerData3;
			Spedizione.FillerData4 = Args.FillerData4;
			Spedizione.FillerData5 = Args.FillerData5;
			Spedizione.DataSpedizione = Args.DataSpedizione;
			val2 = Spedizione_Inserisci_Invoker.Instance.RunProc(CreateApiContext(), ref Spedizione, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				Args.Unibol = Spedizione.UniBol;
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _SpedizioneInserimentoEAttivazione(SpedizioneInserimentoArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = _SpedizioneInserimento(Args, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				val2 = Spedizione_Attiva_Invoker.Instance.RunProc(CreateApiContext(), Args.Unibol, "", ref rsmess);
				val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _IdentificaSpedizione(ref SpedizioneBaseArgs Spedizione, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			rsmess = "";
			if (Operators.CompareString(Spedizione.Unibol, "", false) == 0)
			{
				string text = "SELECT Unibol FROM Spedizioni WHERE ";
				text = text + "Cliente = " + DBConn.SQLFormatString(Spedizione.Cliente) + " AND ";
				text = text + "((NumeroOrdine = " + DBConn.SQLFormatString(Spedizione.NumeroOrdine) + " AND ";
				text = text + "DataOrdine = " + DBConn.SQLFormatDate((eTipoData)1, Spedizione.DataOrdine) + ")  ";
				text = text + "OR (NumeroBolla = " + DBConn.SQLFormatString(Spedizione.NumeroBolla) + " AND ";
				text = text + "DataBolla = " + DBConn.SQLFormatDate((eTipoData)1, Spedizione.DataBolla) + "))  ";
				text += "AND ProgressivoConsegna = 0";
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (rObjDataTable.Rows.Count == 1)
					{
						Spedizione.Unibol = rObjDataTable.Rows[0][0].ToString();
						goto IL_01ee;
					}
					if (rObjDataTable.Rows.Count == 0)
					{
						rsmess = TranslateMessage("TMSAPISERVICE", "Spedizione non trovata");
						val = (FXRETURN)14;
					}
					else
					{
						rsmess = TranslateMessage("TMSAPISERVICE", "Spedizione non identificata in maniera univoca");
						val = (FXRETURN)15;
					}
				}
			}
			else
			{
				string text = "SELECT Unibol FROM Spedizioni WHERE ";
				text = text + "UNIBOL = " + DBConn.SQLFormatString(Spedizione.Unibol) + " ";
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (rObjDataTable.Rows.Count != 0)
					{
						goto IL_01ee;
					}
					rsmess = TranslateMessage("TMSAPISERVICE", "Spedizione non trovata");
					val = (FXRETURN)14;
				}
			}
			goto end_IL_0006;
			IL_01ee:
			val = (FXRETURN)0;
			end_IL_0006:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioCrea(ref Api_ViaggioInserisciArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Invalid comparison between Unknown and I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Viaggio Viaggio = new Viaggio();
			Viaggio viaggio = Viaggio;
			viaggio.Terminale = Args.Terminale;
			viaggio.TipoViaggio = Args.TipoViaggio;
			viaggio.Autista1Pianificato = Args.Autista1Pianificato;
			viaggio.Cliente = Args.Cliente;
			viaggio.PCSPartenza = Args.PCSPartenza;
			viaggio.PCSArrivo = Args.PCSArrivo;
			viaggio.DataPartenzaPianificata = Args.DataPartenzaPianificata;
			viaggio.DataArrivoPianificata = Args.DataArrivoPianificata;
			viaggio.IdViaggioOBC = Args.IdViaggioOBC;
			viaggio.MotricePianificata = Args.MotricePianificata;
			viaggio.Rimorchio1Pianificato = Args.Rimorchio1Pianificato;
			viaggio.Rimorchio2Pianificato = Args.Rimorchio2Pianificato;
			viaggio.Contenitore1Pianificato = Args.Contenitore1Pianificato;
			viaggio.Contenitore2Pianificato = Args.Contenitore2Pianificato;
			viaggio.TipoMerce = Args.TipoMerce;
			viaggio.TipoSpedizione = Args.TipoSpedizione;
			viaggio.TipoSpedizioneAttiva = Args.TipoSpedizioneAttiva;
			viaggio.TipoUnitaViaggiante = Args.TipoUnitaViaggiante;
			viaggio.Vettore = Args.Vettore;
			viaggio.ZonaArrivo = Args.ZonaArrivo;
			viaggio.ZonaArrivoTariffaAttiva = Args.ZonaArrivoTariffaAttiva;
			viaggio.ZonaPartenza = Args.ZonaPartenza;
			viaggio.ZonaPartenzaTariffaAttiva = Args.ZonaPartenzaTariffaAttiva;
			viaggio.ColliAttivo = Args.ColliAttivo;
			viaggio.PalletAttivo = Args.PalletAttivo;
			viaggio.PesoAttivo = Args.PesoAttivo;
			viaggio.VolumeAttivo = Args.VolumeAttivo;
			viaggio.CampoCalcolo1Attivo = Args.CampoCalcolo1Attivo;
			viaggio.CampoCalcolo2Attivo = Args.CampoCalcolo2Attivo;
			viaggio.CampoCalcolo3Attivo = Args.CampoCalcolo3Attivo;
			viaggio.CampoCalcolo4Attivo = Args.CampoCalcolo4Attivo;
			viaggio.CampoCalcolo5Attivo = Args.CampoCalcolo5Attivo;
			viaggio.CampoCalcolo6Attivo = Args.CampoCalcolo6Attivo;
			viaggio.CampoCalcolo7Attivo = Args.CampoCalcolo7Attivo;
			viaggio.CampoCalcolo8Attivo = Args.CampoCalcolo8Attivo;
			viaggio.CampoCalcolo9Attivo = Args.CampoCalcolo9Attivo;
			viaggio.CampoCalcolo10Attivo = Args.CampoCalcolo10Attivo;
			viaggio.ColliPassivo = Args.ColliPassivo;
			viaggio.PalletPassivo = Args.PalletPassivo;
			viaggio.PesoPassivo = Args.PesoPassivo;
			viaggio.VolumePassivo = Args.VolumePassivo;
			viaggio.CampoCalcolo1Passivo = Args.CampoCalcolo1Passivo;
			viaggio.CampoCalcolo2Passivo = Args.CampoCalcolo2Passivo;
			viaggio.CampoCalcolo3Passivo = Args.CampoCalcolo3Passivo;
			viaggio.CampoCalcolo4Passivo = Args.CampoCalcolo4Passivo;
			viaggio.CampoCalcolo5Passivo = Args.CampoCalcolo5Passivo;
			viaggio.CampoCalcolo6Passivo = Args.CampoCalcolo6Passivo;
			viaggio.CampoCalcolo7Passivo = Args.CampoCalcolo7Passivo;
			viaggio.CampoCalcolo8Passivo = Args.CampoCalcolo8Passivo;
			viaggio.CampoCalcolo9Passivo = Args.CampoCalcolo9Passivo;
			viaggio.CampoCalcolo10Passivo = Args.CampoCalcolo10Passivo;
			viaggio.Flag1 = Args.Flag1;
			viaggio.Flag2 = Args.Flag2;
			viaggio.Flag3 = Args.Flag3;
			viaggio.Flag4 = Args.Flag4;
			viaggio.Flag5 = Args.Flag5;
			viaggio.Flag6 = Args.Flag6;
			viaggio.Flag7 = Args.Flag7;
			viaggio.Flag8 = Args.Flag8;
			viaggio.Flag9 = Args.Flag9;
			viaggio.Flag10 = Args.Flag10;
			viaggio.Note1 = Args.Note1;
			viaggio.Note2 = Args.Note2;
			viaggio = null;
			val2 = Viaggio_Inserisci_Invoker.Instance.RunProc(CreateApiContext(), Args.IdViaggioLinea, ref Viaggio, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				Api_ViaggioInserisciArgs api_ViaggioInserisciArgs = Args;
				api_ViaggioInserisciArgs.IdViaggio = Viaggio.IdViaggio;
				api_ViaggioInserisciArgs.Terminale = Viaggio.Terminale;
				api_ViaggioInserisciArgs.TipoViaggio = Viaggio.TipoViaggio;
				api_ViaggioInserisciArgs.Autista1Pianificato = Viaggio.Autista1Pianificato;
				api_ViaggioInserisciArgs.Cliente = Viaggio.Cliente;
				api_ViaggioInserisciArgs.PCSPartenza = Viaggio.PCSPartenza;
				api_ViaggioInserisciArgs.PCSArrivo = Viaggio.PCSArrivo;
				api_ViaggioInserisciArgs.DataArrivoPianificata = Viaggio.DataPartenzaPianificata;
				api_ViaggioInserisciArgs.DataArrivoPianificata = Viaggio.DataArrivoPianificata;
				api_ViaggioInserisciArgs.IdViaggioOBC = Viaggio.IdViaggioOBC;
				api_ViaggioInserisciArgs.MotricePianificata = Viaggio.MotricePianificata;
				api_ViaggioInserisciArgs.Rimorchio1Pianificato = Viaggio.Rimorchio1Pianificato;
				api_ViaggioInserisciArgs.Rimorchio2Pianificato = Viaggio.Rimorchio2Pianificato;
				api_ViaggioInserisciArgs.Contenitore1Pianificato = Viaggio.Contenitore1Pianificato;
				api_ViaggioInserisciArgs.Contenitore2Pianificato = Viaggio.Contenitore2Pianificato;
				api_ViaggioInserisciArgs.TipoMerce = Viaggio.TipoMerce;
				api_ViaggioInserisciArgs.TipoSpedizione = Viaggio.TipoSpedizione;
				api_ViaggioInserisciArgs.TipoSpedizioneAttiva = Viaggio.TipoSpedizioneAttiva;
				api_ViaggioInserisciArgs.TipoUnitaViaggiante = Viaggio.TipoUnitaViaggiante;
				api_ViaggioInserisciArgs.Vettore = Viaggio.Vettore;
				api_ViaggioInserisciArgs.ZonaArrivo = Viaggio.ZonaArrivo;
				api_ViaggioInserisciArgs.ZonaArrivoTariffaAttiva = Viaggio.ZonaArrivoTariffaAttiva;
				api_ViaggioInserisciArgs.ZonaPartenza = Viaggio.ZonaPartenza;
				api_ViaggioInserisciArgs.ZonaPartenzaTariffaAttiva = Viaggio.ZonaPartenzaTariffaAttiva;
				api_ViaggioInserisciArgs.ColliAttivo = Viaggio.ColliAttivo;
				api_ViaggioInserisciArgs.PalletAttivo = Viaggio.PalletAttivo;
				api_ViaggioInserisciArgs.PesoAttivo = Viaggio.PesoAttivo;
				api_ViaggioInserisciArgs.VolumeAttivo = Viaggio.VolumeAttivo;
				api_ViaggioInserisciArgs.CampoCalcolo1Attivo = Viaggio.CampoCalcolo1Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo2Attivo = Viaggio.CampoCalcolo2Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo3Attivo = Viaggio.CampoCalcolo3Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo4Attivo = Viaggio.CampoCalcolo4Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo5Attivo = Viaggio.CampoCalcolo5Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo6Attivo = Viaggio.CampoCalcolo6Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo7Attivo = Viaggio.CampoCalcolo7Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo8Attivo = Viaggio.CampoCalcolo8Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo9Attivo = Viaggio.CampoCalcolo9Attivo;
				api_ViaggioInserisciArgs.CampoCalcolo10Attivo = Viaggio.CampoCalcolo10Attivo;
				api_ViaggioInserisciArgs.ColliPassivo = Viaggio.ColliPassivo;
				api_ViaggioInserisciArgs.PalletPassivo = Viaggio.PalletPassivo;
				api_ViaggioInserisciArgs.PesoPassivo = Viaggio.PesoPassivo;
				api_ViaggioInserisciArgs.VolumePassivo = Viaggio.VolumePassivo;
				api_ViaggioInserisciArgs.CampoCalcolo1Passivo = Viaggio.CampoCalcolo1Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo2Passivo = Viaggio.CampoCalcolo2Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo3Passivo = Viaggio.CampoCalcolo3Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo4Passivo = Viaggio.CampoCalcolo4Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo5Passivo = Viaggio.CampoCalcolo5Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo6Passivo = Viaggio.CampoCalcolo6Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo7Passivo = Viaggio.CampoCalcolo7Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo8Passivo = Viaggio.CampoCalcolo8Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo9Passivo = Viaggio.CampoCalcolo9Passivo;
				api_ViaggioInserisciArgs.CampoCalcolo10Passivo = Viaggio.CampoCalcolo10Passivo;
				api_ViaggioInserisciArgs.Flag1 = Viaggio.Flag1;
				api_ViaggioInserisciArgs.Flag2 = Viaggio.Flag2;
				api_ViaggioInserisciArgs.Flag3 = Viaggio.Flag3;
				api_ViaggioInserisciArgs.Flag4 = Viaggio.Flag4;
				api_ViaggioInserisciArgs.Flag5 = Viaggio.Flag5;
				api_ViaggioInserisciArgs.Flag6 = Viaggio.Flag6;
				api_ViaggioInserisciArgs.Flag7 = Viaggio.Flag7;
				api_ViaggioInserisciArgs.Flag8 = Viaggio.Flag8;
				api_ViaggioInserisciArgs.Flag9 = Viaggio.Flag9;
				api_ViaggioInserisciArgs.Flag10 = Viaggio.Flag10;
				api_ViaggioInserisciArgs.Note1 = Viaggio.Note1;
				api_ViaggioInserisciArgs.Note2 = Viaggio.Note2;
				api_ViaggioInserisciArgs = null;
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioChiudi(Api_ViaggioChiudiArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = Viaggio_Chiudi_Invoker.Instance.RunProc(CreateApiContext(), Args.IdViaggio, Args.DataChiusura, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioRiapri(Api_ViaggioRiapriArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = Viaggio_Riapri_Invoker.Instance.RunProc(CreateApiContext(), Args.IdViaggio, Args.DataRiapertura, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioPartenza(Api_ViaggioPartenzaFineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = Viaggio_Partenza_Invoker.Instance.RunProc(CreateApiContext(), Args.IdViaggio, Args.DataPartenzaEffettiva, Args.AutistaEffettivo, Args.MotriceEffettivo, Args.RimorchioEffettivo, Args.ContenitoreEffettivo, Args.Terminale, Args.Latitudine, Args.Longitudine, Args.KmGPS, Args.DataGPS, Args.KmManuali, Args.Localita, Args.Indirizzo, Args.Cap, Args.Provincia, Args.Nazione, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioFine(Api_ViaggioPartenzaFineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Viaggio_Fine_Invoker instance = Viaggio_Fine_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string idViaggio = Args.IdViaggio;
			DateTime? dataArrivoEffettiva = Args.DataArrivoEffettiva;
			string autistaEffettivo = Args.AutistaEffettivo;
			string motriceEffettivo = Args.MotriceEffettivo;
			string rimorchioEffettivo = Args.RimorchioEffettivo;
			string contenitoreEffettivo = Args.ContenitoreEffettivo;
			string terminale = Args.Terminale;
			string latitudine = Args.Latitudine;
			string longitudine = Args.Longitudine;
			decimal? kmGPS = Args.KmGPS;
			DateTime? dataGPS = Args.DataGPS;
			decimal? kmManuali = Args.KmManuali;
			string localita = Args.Localita;
			string indirizzo = Args.Indirizzo;
			string cap = Args.Cap;
			string provincia = Args.Provincia;
			string nazione = Args.Nazione;
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, idViaggio, dataArrivoEffettiva, autistaEffettivo, motriceEffettivo, rimorchioEffettivo, contenitoreEffettivo, terminale, latitudine, longitudine, kmGPS, dataGPS, kmManuali, localita, indirizzo, cap, provincia, nazione, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioElimina(Api_ViaggioEliminaArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = Viaggio_Cancella_Invoker.Instance.RunProc(CreateApiContext(), Args.IdViaggio, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioApertoRecupera(Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			DataTable rObjDataTable = null;
			string vsSQLClause = "SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIO = " + DBConn.SQLFormatString(InArgs.IdViaggio);
			val2 = DBConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				List<UDS> elencoUds = new List<UDS>();
				modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
				val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
				val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioRecuperaUDS(Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string text = "";
			DBConnection dBConn = DBConn;
			string pNumero = InArgs.IdViaggio;
			string text2 = dBConn.SQLFormatNumber(ref pNumero);
			InArgs.IdViaggio = pNumero;
			text = "SELECT * FROM VIAGGI WHERE IDViaggio = " + text2;
			DataTable rObjDataTable = null;
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (rObjDataTable.Rows.Count > 0)
			{
				text = "SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE S.IDVIAGGIO=" + DBConn.SQLFormatString(InArgs.IdViaggio);
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					List<UDS> elencoUds = new List<UDS>();
					modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
					val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
					val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
				}
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Il viaggio {0} non esiste", InArgs.IdViaggio);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioLineaRecupera(Api_ViaggioLineaRecuperaInArgs InArgs, ref List<Api_ViaggioLineaRecuperaOutArgs> OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string text = "";
			text = "SELECT * FROM VIAGGI_LINEA WHERE STATO = 20";
			if (Operators.CompareString(InArgs.Id, "", false) != 0)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				Api_ViaggioLineaRecuperaInArgs api_ViaggioLineaRecuperaInArgs = InArgs;
				string pNumero = api_ViaggioLineaRecuperaInArgs.Id;
				string text3 = dBConn.SQLFormatNumber(ref pNumero);
				api_ViaggioLineaRecuperaInArgs.Id = pNumero;
				text = text2 + " AND ID = " + text3;
			}
			if (Operators.CompareString(InArgs.Giro, "", false) != 0)
			{
				text = text + " AND GIRO = " + DBConn.SQLFormatString(InArgs.Giro);
			}
			if (Operators.CompareString(InArgs.RiferimentoEsterno, "", false) != 0)
			{
				string text4 = text;
				DBConnection dBConn2 = DBConn;
				Api_ViaggioLineaRecuperaInArgs api_ViaggioLineaRecuperaInArgs = InArgs;
				string pNumero = api_ViaggioLineaRecuperaInArgs.RiferimentoEsterno;
				string text5 = dBConn2.SQLFormatNumber(ref pNumero);
				api_ViaggioLineaRecuperaInArgs.RiferimentoEsterno = pNumero;
				text = text4 + " AND RIFERIMENTOESTERNO = " + text5;
			}
			if (InArgs.DataPartenzaPianificata.HasValue)
			{
				text = text + " AND " + DBConn.DateTrunc("DATAPARTENZAPIANIFICATA") + " = " + DBConn.SQLFormatDate((eTipoData)1, InArgs.DataPartenzaPianificata.Value);
			}
			DataTable rObjDataTable = null;
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (rObjDataTable.Rows.Count > 0)
			{
				OutArgs = new List<Api_ViaggioLineaRecuperaOutArgs>();
				foreach (DataRow row in rObjDataTable.Rows)
				{
					Api_ViaggioLineaRecuperaOutArgs api_ViaggioLineaRecuperaOutArgs = new Api_ViaggioLineaRecuperaOutArgs();
					Api_ViaggioLineaRecuperaOutArgs api_ViaggioLineaRecuperaOutArgs2 = api_ViaggioLineaRecuperaOutArgs;
					api_ViaggioLineaRecuperaOutArgs2.Id = row["Id"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Stato = Conversions.ToInteger(row["Stato"].ToString());
					api_ViaggioLineaRecuperaOutArgs2.TipoViaggio = row["TipoViaggio"].ToString();
					if (Information.IsDate((object)row["DataPartenzaPianificata"].ToString()))
					{
						api_ViaggioLineaRecuperaOutArgs2.DataPartenzaPianificata = Conversions.ToDate(row["DataPartenzaPianificata"].ToString());
					}
					api_ViaggioLineaRecuperaOutArgs2.Giro = row["Giro"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.RiferimentoEsterno = row["RiferimentoEsterno"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Descrizione = row["Descrizione"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Mezzo = row["Mezzo"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.TipoMezzo = row["TipoMezzo"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Vettore = row["Vettore"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Autista = row["Autista"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.TipoSpedizione = row["TipoSpedizione"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.TipoMerce = row["TipoMerce"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.ZonaSpedizione = row["ZonaSpedizione"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.ZonaTariffaAttiva = row["ZonaTariffaAttiva"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.ZonaTariffaPassiva = row["ZonaTariffaPassiva"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.PCSPartenza = row["PCSPartenza"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.PCSArrivo = row["PCSArrivo"].ToString();
					api_ViaggioLineaRecuperaOutArgs2.Note = row["PCSArrivo"].ToString();
					api_ViaggioLineaRecuperaOutArgs2 = null;
					OutArgs.Add(api_ViaggioLineaRecuperaOutArgs);
				}
				val = (FXRETURN)0;
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Nessun Viaggio di linea trovato");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _ViaggioLineaRecuperaUDS(Api_ViaggioLineaRecuperaInArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Invalid comparison between Unknown and I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Invalid comparison between Unknown and I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string text = "";
			text = "SELECT * FROM VIAGGI_LINEA WHERE STATO = 20";
			if (Operators.CompareString(InArgs.Id, "", false) != 0)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				Api_ViaggioLineaRecuperaInArgs api_ViaggioLineaRecuperaInArgs = InArgs;
				string pNumero = api_ViaggioLineaRecuperaInArgs.Id;
				string text3 = dBConn.SQLFormatNumber(ref pNumero);
				api_ViaggioLineaRecuperaInArgs.Id = pNumero;
				text = text2 + " AND ID = " + text3;
			}
			if (Operators.CompareString(InArgs.Giro, "", false) != 0)
			{
				text = text + " AND GIRO = " + DBConn.SQLFormatString(InArgs.Giro);
			}
			if (Operators.CompareString(InArgs.RiferimentoEsterno, "", false) != 0)
			{
				string text4 = text;
				DBConnection dBConn2 = DBConn;
				Api_ViaggioLineaRecuperaInArgs api_ViaggioLineaRecuperaInArgs = InArgs;
				string pNumero = api_ViaggioLineaRecuperaInArgs.RiferimentoEsterno;
				string text5 = dBConn2.SQLFormatNumber(ref pNumero);
				api_ViaggioLineaRecuperaInArgs.RiferimentoEsterno = pNumero;
				text = text4 + " AND RIFERIMENTOESTERNO = " + text5;
			}
			if (InArgs.DataPartenzaPianificata.HasValue)
			{
				text = text + " AND DATAPARTENZAPIANIFICATA = " + DBConn.SQLFormatDate((eTipoData)1, InArgs.DataPartenzaPianificata.Value);
			}
			DataTable rObjDataTable = null;
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (rObjDataTable.Rows.Count > 0)
			{
				string text6 = "";
				foreach (DataRow row in rObjDataTable.Rows)
				{
					text6 = ((Operators.CompareString(text6, "", false) != 0) ? (text6 + "," + DBConn.SQLFormatString(row["ID"].ToString())) : (text6 + DBConn.SQLFormatString(row["ID"].ToString())));
				}
				text = "SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIOLINEA IN (" + text6 + ") AND IDVIAGGIO IS NULL";
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					List<UDS> elencoUds = new List<UDS>();
					modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
					val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
					val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
				}
			}
			else
			{
				rsmess = TranslateMessage("XXX", "Nessun Viaggio di linea trovato");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _UdsSpuntaUscita(Api_UdsSpuntaUscitaInArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Invalid comparison between Unknown and I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Invalid comparison between Unknown and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Invalid comparison between Unknown and I4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			if (InArgs.AssociaViaggio & (Operators.CompareString(InArgs.IdViaggio, "", false) == 0))
			{
				InArgs.AssociaViaggio = false;
			}
			if (!InArgs.DataSpunta.HasValue)
			{
				InArgs.DataSpunta = DateAndTime.Now;
			}
			if (Operators.CompareString(InArgs.UtenteSpunta + "", "", false) == 0)
			{
				InArgs.UtenteSpunta = Username;
			}
			DBConn.BeginTransaction();
			List<UDS> ListOfUDS = new List<UDS>();
			val2 = UDS_ElencoSpuntaUscita_Invoker.Instance.RunProc(CreateApiContext(), InArgs.Codice, InArgs.Unibol, InArgs.UdsMaster, InArgs.IdViaggio, InArgs.IdViaggioLinea, InArgs.UtenteSpunta, InArgs.DataSpunta, InArgs.AssociaViaggio, ref ListOfUDS, ref rsmess);
			string text;
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				text = "";
				if (!InArgs.AssociaViaggio)
				{
					goto IL_0235;
				}
				List<string> list = new List<string>();
				foreach (UDS item in ListOfUDS)
				{
					text = "";
					if (list.Contains(item.Unibol))
					{
						continue;
					}
					object objRes = null;
					text = "SELECT IDVIAGGIO FROM SPEDIZIONI WHERE UNIBOL = " + DBConn.SQLFormatString(item.Unibol);
					val2 = DBConn.DoSql(text, "", ref objRes, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						if (Operators.CompareString(objRes.ToString(), "", false) == 0)
						{
							list.Add(item.Unibol);
							continue;
						}
						if (Operators.CompareString(objRes.ToString(), InArgs.IdViaggio, false) == 0)
						{
							continue;
						}
						rsmess = TranslateMessage("XXX", "Spedizioni {0} già associata al viaggio {1}. Impossibile associarla al viaggio {2}", InArgs.Unibol, objRes.ToString(), InArgs.IdViaggio);
					}
					goto end_IL_0004;
				}
				if (list.Count <= 0)
				{
					goto IL_0235;
				}
				val2 = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, InArgs.IdViaggio, InArgs.DataSpunta, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_0235;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_0235:
			DataTable rObjDataTable = null;
			text = (InArgs.AssociaViaggio ? ("SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIO =" + DBConn.SQLFormatString(InArgs.IdViaggio)) : ((Operators.CompareString(InArgs.IdViaggioLinea, "", false) == 0) ? "SELECT * FROM SPEDIZIONIUDS WHERE 1=2" : ("SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIOLINEA =" + DBConn.SQLFormatString(InArgs.IdViaggioLinea))));
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count <= 0)
				{
					goto IL_02ed;
				}
				List<UDS> elencoUds = new List<UDS>();
				modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
				val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
				if ((int)val2 == 0)
				{
					OutArgs.ListOfUds.Clear();
					goto IL_02ed;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_02ed:
			DBConn.CommitTransaction();
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _UdsSpuntaUscitaAnnulla(Api_UdsSpuntaUscitaAnnullaInArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			if (InArgs.DisassociaViaggio & (Operators.CompareString(InArgs.IdViaggio, "", false) == 0))
			{
				InArgs.DisassociaViaggio = false;
			}
			List<UDS> ListOfUDS = new List<UDS>();
			val2 = UDS_ElencoSpuntaUscitaAnnulla_Invoker.Instance.RunProc(CreateApiContext(), InArgs.Codice, InArgs.Unibol, InArgs.UdsMaster, InArgs.IdViaggio, InArgs.IdViaggioLinea, ref ListOfUDS, ref rsmess);
			string text;
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				text = "";
				if (!InArgs.DisassociaViaggio)
				{
					goto IL_0162;
				}
				List<string> list = new List<string>();
				foreach (UDS item in ListOfUDS)
				{
					if (list.Contains(item.Unibol))
					{
						continue;
					}
					object objRes = null;
					text = "SELECT IDVIAGGIO FROM SPEDIZIONI WHERE UNIBOL = " + DBConn.SQLFormatString(item.Unibol);
					val2 = DBConn.DoSql(text, "", ref objRes, ref rsmess);
					if ((int)val2 == 0)
					{
						if (Operators.CompareString(objRes.ToString(), "", false) != 0)
						{
							list.Add(item.Unibol);
						}
						continue;
					}
					val = val2;
					goto end_IL_0004;
				}
				if (list.Count <= 0)
				{
					goto IL_0162;
				}
				val2 = Spedizione_DisassociaDaViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, InArgs.IdViaggio, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_0162;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_0162:
			DataTable rObjDataTable = null;
			text = (InArgs.DisassociaViaggio ? ("SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIO =" + DBConn.SQLFormatString(InArgs.IdViaggio)) : ((Operators.CompareString(InArgs.IdViaggioLinea, "", false) == 0) ? "SELECT * FROM SPEDIZIONIUDS WHERE 1=2" : ("SELECT U.* FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON U.UNIBOL = S.UNIBOL WHERE IDVIAGGIOLINEA =" + DBConn.SQLFormatString(InArgs.IdViaggioLinea))));
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count <= 0)
				{
					goto IL_020e;
				}
				List<UDS> elencoUds = new List<UDS>();
				modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
				val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_020e;
				}
				val = val2;
			}
			goto end_IL_0004;
			IL_020e:
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _UdsSpuntaUscitaMancanti(Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string sSql = "SELECT COUNT(*) FROM Viaggi WHERE IDVIAGGIO = " + DBConn.SQLFormatString(InArgs.IdViaggio);
			object objRes = null;
			val2 = DBConn.DoSql(sSql, ref objRes, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Conversions.ToInteger(objRes) == 0)
			{
				rsmess = "Il viaggio " + InArgs.IdViaggio + " non esiste";
			}
			else
			{
				DataTable rObjDataTable = null;
				sSql = "SELECT * FROM SPEDIZIONIUDS WHERE Unibol IN ";
				sSql = sSql + "(SELECT Unibol FROM SPEDIZIONI WHERE IDVIAGGIO = " + DBConn.SQLFormatString(InArgs.IdViaggio) + ") ";
				sSql += "AND SpuntaDataUscita IS NULL";
				val2 = DBConn.OpenDataTable(sSql, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					List<UDS> elencoUds = new List<UDS>();
					modGeneral.ConvertDataTableToList<UDS>(rObjDataTable, ref elencoUds);
					val2 = Genera_Api_UdsOut(elencoUds, ref OutArgs, ref rsmess);
					val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN Genera_Api_UdsOut(List<UDS> ElencoUds, ref Api_UdsOutArgs Out, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				rsMess = "";
				List<Api_Uds> list = new List<Api_Uds>();
				Api_UdsSommatorie api_UdsSommatorie = new Api_UdsSommatorie();
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>();
				List<string> list4 = new List<string>();
				List<string> list5 = new List<string>();
				decimal d = default(decimal);
				int num = 0;
				int num2 = 0;
				decimal d2 = default(decimal);
				decimal d3 = default(decimal);
				decimal d4 = default(decimal);
				decimal num3 = default(decimal);
				decimal num4 = default(decimal);
				decimal num5 = default(decimal);
				decimal num6 = default(decimal);
				decimal num7 = default(decimal);
				decimal num8 = default(decimal);
				decimal num9 = default(decimal);
				decimal num10 = default(decimal);
				decimal num11 = default(decimal);
				decimal num12 = default(decimal);
				foreach (UDS ElencoUd in ElencoUds)
				{
					Api_Uds api_Uds = new Api_Uds();
					Api_Uds api_Uds2 = api_Uds;
					api_Uds2.Id = ElencoUd.Id.ToString();
					api_Uds2.Codice = ElencoUd.Codice;
					api_Uds2.Unibol = ElencoUd.Unibol;
					api_Uds2.TipoUds = ElencoUd.TipoUds;
					api_Uds2.Descrizione = ElencoUd.Descrizione;
					api_Uds2.SpuntaDataUscita = ElencoUd.SpuntaDataUscita;
					api_Uds2.SpuntaOperatoreUscita = ElencoUd.SpuntaOperatoreUscita;
					api_Uds2.SpuntaDataIngresso = ElencoUd.SpuntaDataIngresso;
					api_Uds2.SpuntaOperatoreIngresso = ElencoUd.SpuntaOperatoreIngresso;
					api_Uds2.PesoLordo = ElencoUd.PesoLordo;
					api_Uds2.Colli = ElencoUd.Colli;
					api_Uds2.Pallet = ElencoUd.Pallet;
					api_Uds2.Volume = ElencoUd.Volume;
					api_Uds2.PalletVolumetrici = ElencoUd.PalletVolumetrici;
					api_Uds2.ValoreMerce = ElencoUd.ValoreMerce;
					api_Uds2.CampoCalcolo1 = ElencoUd.CampoCalcolo1;
					api_Uds2.CampoCalcolo2 = ElencoUd.CampoCalcolo2;
					api_Uds2.CampoCalcolo3 = ElencoUd.CampoCalcolo3;
					api_Uds2.CampoCalcolo4 = ElencoUd.CampoCalcolo4;
					api_Uds2.CampoCalcolo5 = ElencoUd.CampoCalcolo5;
					api_Uds2.CampoCalcolo6 = ElencoUd.CampoCalcolo6;
					api_Uds2.CampoCalcolo7 = ElencoUd.CampoCalcolo7;
					api_Uds2.CampoCalcolo8 = ElencoUd.CampoCalcolo8;
					api_Uds2.CampoCalcolo9 = ElencoUd.CampoCalcolo9;
					api_Uds2.CampoCalcolo10 = ElencoUd.CampoCalcolo10;
					api_Uds2.Altezza = ElencoUd.Altezza;
					api_Uds2.Larghezza = ElencoUd.Larghezza;
					api_Uds2.Profondita = ElencoUd.Profondita;
					api_Uds2.InConsegna = ElencoUd.InConsegna;
					api_Uds2.UdsMaster = ElencoUd.UdsMaster;
					api_Uds2.Filler1 = ElencoUd.Filler1;
					api_Uds2.Filler2 = ElencoUd.Filler2;
					api_Uds2.Filler3 = ElencoUd.Filler3;
					api_Uds2.Filler4 = ElencoUd.Filler4;
					api_Uds2.Filler5 = ElencoUd.Filler5;
					api_Uds2.Filler6 = ElencoUd.Filler6;
					api_Uds2.Filler7 = ElencoUd.Filler7;
					api_Uds2.Filler8 = ElencoUd.Filler8;
					api_Uds2.Filler9 = ElencoUd.Filler9;
					api_Uds2.Filler10 = ElencoUd.Filler10;
					api_Uds2.UteIns = ElencoUd.UteIns;
					api_Uds2.UteAgg = ElencoUd.UteAgg;
					api_Uds2.DatIns = ElencoUd.DatIns;
					api_Uds2.DatAgg = ElencoUd.DatAgg;
					api_Uds2 = null;
					list.Add(api_Uds);
					if (ElencoUd.PesoLordo.HasValue)
					{
						d = decimal.Add(d, (decimal)ElencoUd.PesoLordo);
					}
					if (ElencoUd.Colli.HasValue)
					{
						num += (int)ElencoUd.Colli;
					}
					if (ElencoUd.Pallet.HasValue)
					{
						num2 += (int)ElencoUd.Pallet;
					}
					if (ElencoUd.PalletVolumetrici.HasValue)
					{
						d2 = decimal.Add(d2, (decimal)ElencoUd.PalletVolumetrici);
					}
					if (ElencoUd.ValoreMerce.HasValue)
					{
						d3 = decimal.Add(d3, (decimal)ElencoUd.ValoreMerce);
					}
					if (ElencoUd.Volume.HasValue)
					{
						d4 = decimal.Add(d4, (decimal)ElencoUd.Volume);
					}
					if (!list2.Contains(ElencoUd.Unibol))
					{
						list2.Add(ElencoUd.Unibol);
					}
					if (Operators.CompareString(ElencoUd.UdsMaster, ElencoUd.Codice, false) != 0 && !list3.Contains(ElencoUd.UdsMaster))
					{
						list3.Add(ElencoUd.UdsMaster);
					}
					if (Operators.CompareString(ElencoUd.SpuntaOperatoreUscita, "", false) != 0)
					{
						if (!list4.Contains(ElencoUd.Codice))
						{
							list4.Add(ElencoUd.Codice);
						}
						if (Operators.CompareString(ElencoUd.UdsMaster, ElencoUd.Codice, false) != 0 && !list5.Contains(ElencoUd.UdsMaster))
						{
							list5.Add(ElencoUd.UdsMaster);
						}
					}
				}
				api_UdsSommatorie.Colli = num;
				api_UdsSommatorie.Pallet = num2;
				api_UdsSommatorie.NumeroSpedizioni = list2.Count;
				api_UdsSommatorie.TotaleUds = ElencoUds.Count;
				api_UdsSommatorie.TotaleUdt = list3.Count;
				api_UdsSommatorie.TotaleUdsSpuntate = list4.Count;
				api_UdsSommatorie.TotaleUdtSpuntate = list5.Count;
				Out = new Api_UdsOutArgs();
				Out.ListOfUds = list;
				Out.Viaggio = api_UdsSommatorie;
				val = (FXRETURN)0;
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
	}

	protected FXRETURN _SpedizioneImport(Api_SpedizioneImportArgs InArgs, ref SpedizioneBaseArgs OutArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string Unibol = "";
			val2 = GdoWsc_ImportSpedizioni.RunProc(CreateApiContext(), InArgs, ImportaPCSPartenza: true, ImportaPCSDestino: true, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				OutArgs = new SpedizioneBaseArgs();
				OutArgs.Cliente = InArgs.Cliente;
				OutArgs.NumeroBolla = InArgs.NumeroBolla;
				OutArgs.DataBolla = InArgs.DataBolla;
				OutArgs.NumeroOrdine = InArgs.NumeroOrdine;
				OutArgs.DataOrdine = InArgs.DataOrdine;
				OutArgs.Unibol = Unibol;
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _UdsAssociaUdt(Api_UdsAssociaUdtArgs InArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			UDS_Associa_UDT_Invoker instance = UDS_Associa_UDT_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string[] codiceUds = InArgs.CodiceUds;
			string[] unibols = InArgs.Unibols;
			string udsMaster = InArgs.UdsMaster;
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, codiceUds, unibols, udsMaster, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _UdsRiassociaUdt(Api_UdsAssociaUdtArgs InArgs, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			UDS_Riassocia_UDT_Invoker instance = UDS_Riassocia_UDT_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string[] codiceUds = InArgs.CodiceUds;
			string[] unibols = InArgs.Unibols;
			string udsMaster = InArgs.UdsMaster;
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, codiceUds, unibols, udsMaster, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}
}
