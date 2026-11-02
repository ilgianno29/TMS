using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.ServiceModel;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Incasbo.Web.WSCWCF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

[ServiceBehavior(/*Could not decode attribute arguments.*/)]
public class TMSServiceForWMS : IncasWCFEasystorAuth, ITMSServiceForWMS
{
	protected DBConnection DBConn => SessionEnvironment.DbMain;

	public Result AnnullamentoOrdine(Sender sender, OrdineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("ANNULLAMENTO ORDINE", sNote, "", ref rsmess2);
				val2 = _AnnullamentoOrdine(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("ANNULLAMENTO ORDINE", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.AnnullamentoOrdine(Sender sender, OrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AnnullamentoOrdine
		return this.AnnullamentoOrdine(sender, Args);
	}

	public Result AttivazioneBatch(Sender sender, BatchArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("ATTIVAZIONE BATCH", sNote, "", ref rsmess2);
				val2 = _AttivazioneBatch(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("ATTIVAZIONE BATCH", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.AttivazioneBatch(Sender sender, BatchArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AttivazioneBatch
		return this.AttivazioneBatch(sender, Args);
	}

	public Result FineLavorazioneBatch(Sender sender, BatchArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("CHIUSURA BATCH", sNote, "", ref rsmess2);
				val2 = _FineLavorazioneBatch(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("CHIUSURA BATCH", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.FineLavorazioneBatch(Sender sender, BatchArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in FineLavorazioneBatch
		return this.FineLavorazioneBatch(sender, Args);
	}

	public Result FineLavorazioneOrdine(Sender sender, OrdineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("FINE LAVORAZIONE ORDINE", sNote, "", ref rsmess2);
				val2 = _FineLavorazioneOrdine(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("FINE LAVORAZIONE ORDINE", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.FineLavorazioneOrdine(Sender sender, OrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in FineLavorazioneOrdine
		return this.FineLavorazioneOrdine(sender, Args);
	}

	public Result FineLavorazioneViaggio(Sender sender, ViaggioArgs Args)
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
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("FINE LAVORAZIONE VIAGGIO", sNote, "", ref rsmess2);
				val2 = _FineLavorazioneViaggio(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("FINE LAVORAZIONE VIAGGIO", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.FineLavorazioneViaggio(Sender sender, ViaggioArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in FineLavorazioneViaggio
		return this.FineLavorazioneViaggio(sender, Args);
	}

	public override string GetVersion()
	{
		return base.GetVersion();
	}

	string ITMSServiceForWMS.GetVersion()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetVersion
		return this.GetVersion();
	}

	public Result NotificaFineFormazioneSagome(Sender sender, ViaggioPalletSagomeArgs Args)
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
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("FINE FORMAZIONE SAGOME", sNote, "", ref rsmess2);
				val2 = _NotificaFineFormazioneSagome(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("FINE FORMAZIONE SAGOME", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaFineFormazioneSagome(Sender sender, ViaggioPalletSagomeArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaFineFormazioneSagome
		return this.NotificaFineFormazioneSagome(sender, Args);
	}

	public Result NotificaNumeroPalletSagomeAViaggio(Sender sender, ViaggioPalletSagomeArgs Args)
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
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("NOTIFICA PALLET E SAGOME A VIAGGIO", sNote, "", ref rsmess2);
				val2 = _NotificaNumeroPalletSagomeAViaggio(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("NOTIFICA PALLET E SAGOME A VIAGGIO", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaNumeroPalletSagomeAViaggio(Sender sender, ViaggioPalletSagomeArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaNumeroPalletSagomeAViaggio
		return this.NotificaNumeroPalletSagomeAViaggio(sender, Args);
	}

	public Result NotificaFineSpuntaSagome(Sender sender, ViaggioPalletSagomeArgs Args)
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
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("FINE SPUNTA SAGOME", sNote, "", ref rsmess2);
				val2 = _NotificaFineSpuntaSagome(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("FINE SPUNTA SAGOME", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaFineSpuntaSagome(Sender sender, ViaggioPalletSagomeArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaFineSpuntaSagome
		return this.NotificaFineSpuntaSagome(sender, Args);
	}

	public Result NotificaInizioFormazioneSagome(Sender sender, ViaggioArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("INIZIO FORMAZIONE SAGOME", sNote, "", ref rsmess2);
				val2 = _NotificaInizioFormazioneSagome(ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("INIZIO FORMAZIONE SAGOME", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaInizioFormazioneSagome(Sender sender, ViaggioArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaInizioFormazioneSagome
		return this.NotificaInizioFormazioneSagome(sender, Args);
	}

	public Result NotificaInizioSpuntaSagome(Sender sender, ViaggioArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("INIZIO SPUNTA SAGOME", sNote, "", ref rsmess2);
				val2 = _NotificaInizioSpuntaSagome(ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("INIZIO SPUNTA SAGOME", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaInizioSpuntaSagome(Sender sender, ViaggioArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaInizioSpuntaSagome
		return this.NotificaInizioSpuntaSagome(sender, Args);
	}

	public Result NotificaNumeroPalletSagome(Sender sender, NotificaPalletSagomeArgs Args)
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
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID BATCH=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("NOTIFICA NUM PALLET SAGOME", sNote, "", ref rsmess2);
				val2 = _NotificaNumeroPalletSagome(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID BATCH=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("NOTIFICA NUM PALLET SAGOME", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaNumeroPalletSagome(Sender sender, NotificaPalletSagomeArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaNumeroPalletSagome
		return this.NotificaNumeroPalletSagome(sender, Args);
	}

	public Result NotificaOrdinePrelevato(Sender sender, OrdinePrelevatoArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("PRELIEVO ORDINE", sNote, "", ref rsmess2);
				val2 = _NotificaOrdinePrelevato(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("PRELIEVO ORDINE", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaOrdinePrelevato(Sender sender, OrdinePrelevatoArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaOrdinePrelevato
		return this.NotificaOrdinePrelevato(sender, Args);
	}

	public Result NotificaOrdineSpuntato(Sender sender, OrdineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("ORDINE SPUNTATO", sNote, "", ref rsmess2);
				val2 = _NotificaOrdineSpuntato(Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("ORDINE SPUNTATO", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaOrdineSpuntato(Sender sender, OrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaOrdineSpuntato
		return this.NotificaOrdineSpuntato(sender, Args);
	}

	public Result NotificaUdsSpuntata(Sender sender, UdsSpuntataArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "UDS: " + Args.CodiceUds + " NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("SPUNTA UDS", sNote, "", ref rsmess2);
				val2 = _NotificaUdsSpuntata(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "UDS: " + Args.CodiceUds + " NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("SPUNTA UDS", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaUdsSpuntata(Sender sender, UdsSpuntataArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaUdsSpuntata
		return this.NotificaUdsSpuntata(sender, Args);
	}

	public Result NotificaUds(Sender sender, WMS_UdsArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "UDS: " + Args.CodiceUds + " NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("NOTIFICA UDS", sNote, "", ref rsmess2);
				val2 = _NotificaUds(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "UDS: " + Args.CodiceUds + " NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("NOTIFICA UDS", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaUds(Sender sender, WMS_UdsArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaUds
		return this.NotificaUds(sender, Args);
	}

	public override bool TestDBConnection(ref string rsMess)
	{
		return base.TestDBConnection(ref rsMess);
	}

	bool ITMSServiceForWMS.TestDBConnection(ref string rsMess)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestDBConnection
		return this.TestDBConnection(ref rsMess);
	}

	public override string TestPing(string sStringa)
	{
		return base.TestPing(sStringa);
	}

	string ITMSServiceForWMS.TestPing(string sStringa)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TestPing
		return this.TestPing(sStringa);
	}

	public Result SpedizioneAggiornaRiferimentiDDT(Sender sender, DDTArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("AGGIORNA DDT", sNote, "", ref rsmess2);
				val2 = _SpedizioneAggiornaRiferimentiDDT(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("AGGIORNA DDT", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.SpedizioneAggiornaRiferimentiDDT(Sender sender, DDTArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneAggiornaRiferimentiDDT
		return this.SpedizioneAggiornaRiferimentiDDT(sender, Args);
	}

	public Result NotificaOrdineDataSpedizione(Sender sender, OrdineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("ORDINE DATA SPEDIZIONE", sNote, "", ref rsmess2);
				val2 = _NotificaOrdineDataSpedizione(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("ORDINE DATA SPEDIZIONE", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaOrdineDataSpedizione(Sender sender, OrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaOrdineDataSpedizione
		return this.NotificaOrdineDataSpedizione(sender, Args);
	}

	public Result NotificaOrdineInizioPrelievo(Sender sender, OrdineArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("ORDINE INIZIO PRELIEVO", sNote, "", ref rsmess2);
				val2 = _NotificaOrdineInizioPrelievo(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("ORDINE INIZIO PRELIEVO", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaOrdineInizioPrelievo(Sender sender, OrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaOrdineInizioPrelievo
		return this.NotificaOrdineInizioPrelievo(sender, Args);
	}

	public Result FinePrelievoBatch(Sender sender, BatchArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("FINE PRELIEVO BATCH", sNote, "", ref rsmess2);
				val2 = _FinePrelievoBatch(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("FINE PRELIEVO BATCH", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.FinePrelievoBatch(Sender sender, BatchArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in FinePrelievoBatch
		return this.FinePrelievoBatch(sender, Args);
	}

	public Result NotificaSagomeVolumetrichePerRaggruppamentoOrdini(Sender sender, WMS_RaggruppamentiOrdiniArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string text = "";
				foreach (WMS_RaggruppamentoOrdiniArgs item in Args.Raggruppamenti)
				{
					text = text + "COD.RAGGR: " + item.CodiceRaggruppamento + " ";
				}
				string sNote = text;
				string rsmess2 = "";
				LogEventiMem("NOTIFICA SAGOME VOLUMETRICHE PER RAGGRUPPAMENTO", sNote, "", ref rsmess2);
				val2 = _NotificaSagomeVolumetrichePerRaggruppamentoOrdini(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = text;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("NOTIFICA SAGOME VOLUMETRICHE PER RAGGRUPPAMENTO", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.NotificaSagomeVolumetrichePerRaggruppamentoOrdini(Sender sender, WMS_RaggruppamentiOrdiniArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in NotificaSagomeVolumetrichePerRaggruppamentoOrdini
		return this.NotificaSagomeVolumetrichePerRaggruppamentoOrdini(sender, Args);
	}

	public Result SpedizioneDeterminaCorrispondenteMigliore(Sender sender, ref CorrispondenteMiglioreArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
				string rsmess2 = "";
				LogEventiMem("DETERMINA CORRISPONDENTE MIGLIORE", sNote, "", ref rsmess2);
				val2 = _SpedizioneDeterminaCorrispondenteMigliore(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "NUM.ORD=" + Args.NumeroOrdine + " DATA ORD=" + Args.DataOrdine.ToString("dd/MM/yyyy") + " CLIENTE=" + Args.Committente;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("DETERMINA CORRISPONDENTE MIGLIORE", sNote2, sNote3, ref rsmess2);
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

	Result ITMSServiceForWMS.SpedizioneDeterminaCorrispondenteMigliore(Sender sender, ref CorrispondenteMiglioreArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizioneDeterminaCorrispondenteMigliore
		return this.SpedizioneDeterminaCorrispondenteMigliore(sender, ref Args);
	}

	protected FXRETURN _IdentificaSpedizione(string Cliente, string NumeroOrdine, DateTime DataOrdine, ref string Unibol, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			Unibol = "";
			string text = "SELECT Unibol, DataOrdine FROM Spedizioni WHERE ";
			text = text + "Cliente = " + DBConn.SQLFormatString(Cliente) + " AND ";
			text = text + "NumeroOrdine = " + DBConn.SQLFormatString(NumeroOrdine) + " AND ";
			text += "Stato<=40 AND ProgressivoConsegna = 0";
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count == 1)
				{
					Unibol = rObjDataTable.Rows[0]["Unibol"].ToString();
				}
				else if (rObjDataTable.Rows.Count > 1)
				{
					foreach (DataRow row in rObjDataTable.Rows)
					{
						if (DateTime.Compare(Conversions.ToDate(row["DataOrdine"]).Date, DataOrdine.Date) == 0)
						{
							Unibol = row["Unibol"].ToString();
							break;
						}
					}
				}
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

	protected FXRETURN _AnnullamentoOrdine(ref OrdineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Invalid comparison between Unknown and I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Invalid comparison between Unknown and I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				val = (FXRETURN)0;
			}
			else
			{
				string text2 = "UPDATE Spedizioni SET Stato=Stato ";
				text2 = text2 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
				val2 = DBConn.SqlExec(text2, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					text2 = "SELECT Unibol, Stato, IdViaggio FROM Spedizioni WHERE ";
					text2 = text2 + "Unibol = " + DBConn.SQLFormatString(Unibol);
					val2 = DBConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsmess = TranslateMessage("XXX", "Ordine {0} non trovato.", text);
					}
					else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) >= 40)
					{
						rsmess = TranslateMessage("XXX", "Lo stato dell'ordine {0} non ne consente l'annullamento.", text);
					}
					else
					{
						text2 = "UPDATE Spedizioni SET Stato='99', IdViaggio=NULL WHERE Unibol = " + DBConn.SQLFormatString(Unibol) + ";";
						string RetQueryToApply = "";
						string note = "";
						if (Operators.CompareString(rObjDataTable.Rows[0]["IdViaggio"].ToString(), "", false) != 0)
						{
							note = "ANNULLAMENTO ORDINE APPARTENENTE A VIAGGIO " + rObjDataTable.Rows[0]["IdViaggio"].ToString();
						}
						val2 = EventoSpedizione_Annullamento.RunProc(CreateApiContext(), Unibol, "ANNWMS", note, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							text2 += RetQueryToApply;
							val2 = DBConn.SqlExec(text2, ref rsmess);
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

	protected FXRETURN _AttivazioneBatch(ref BatchArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Spedizioni_Batch SET Stato = Stato ";
			text = text + "WHERE Id = " + DBConn.SQLFormatString(Args.Id);
			val2 = DBConn.SqlExec(text, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				text = "SELECT * FROM Spedizioni_Batch ";
				text = text + " WHERE Id = " + DBConn.SQLFormatString(Args.Id);
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Batch {0} non trovato.", Args.Id);
				}
				else
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) != 10)
					{
						goto IL_015a;
					}
					text = "UPDATE Spedizioni_Batch SET Stato=20, DataAttivazione=GETDATE() WHERE Id = " + DBConn.SQLFormatString(Args.Id) + ";";
					text = text + "UPDATE Spedizioni SET StatoWMS=20 WHERE BATCHID=" + DBConn.SQLFormatString(Args.Id) + ";";
					val2 = DBConn.SqlExec(text, ref rsmess);
					if ((int)val2 == 0)
					{
						goto IL_015a;
					}
					val = val2;
				}
			}
			goto end_IL_0006;
			IL_015a:
			DBConn.CommitTransaction();
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
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _NotificaUdsSpuntata(ref UdsSpuntataArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Invalid comparison between Unknown and I4
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			DBConn.BeginTransaction();
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} con data {1} e committente {2} oppure ordine in stato maggiore di 30", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			}
			else
			{
				if (Args.TipoUds == null)
				{
					Args.TipoUds = "";
				}
				if (Operators.CompareString(Args.TipoUds, "", false) == 0)
				{
					Args.TipoUds = ApplicationDefault.TipoUds_Default();
				}
				if (Operators.CompareString(Args.TipoUds, "", false) == 0)
				{
					rsmess = "Tipo UDS di default non codificata";
				}
				else
				{
					if (Args.OperatoreDiSpunta == null)
					{
						Args.OperatoreDiSpunta = "";
					}
					if (Operators.CompareString(Args.OperatoreDiSpunta, "", false) == 0)
					{
						Args.OperatoreDiSpunta = "WMS";
					}
					if (Args.UdsMaster == null)
					{
						Args.UdsMaster = "";
					}
					if (Operators.CompareString(Args.UdsMaster, "", false) == 0)
					{
						Args.UdsMaster = Args.CodiceUds;
					}
					string text = "UPDATE SpedizioniUds SET Unibol=Unibol ";
					text = text + "WHERE Codice=" + DBConn.SQLFormatString(Args.CodiceUds) + " AND ";
					text = text + "Unibol=" + DBConn.SQLFormatString(Unibol);
					val2 = DBConn.SqlExec(text, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						string text2 = "SELECT * FROM SpedizioniUds ";
						text2 = text2 + "WHERE Codice=" + DBConn.SQLFormatString(Args.CodiceUds) + " AND ";
						text2 = text2 + "Unibol=" + DBConn.SQLFormatString(Unibol);
						val2 = DBConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							if (rObjDataTable.Rows.Count == 0)
							{
								text = "INSERT INTO SpedizioniUds (";
								text += "Codice, Unibol, TipoUds, ";
								if (Args.Descrizione != null)
								{
									text += "Descrizione, ";
								}
								if (Args.EffettuaSpunta)
								{
									text += "SpuntaDataUscita, SpuntaOperatoreUscita, ";
								}
								if (Args.Peso.HasValue)
								{
									text += "PesoLordo, ";
								}
								if (Args.Colli.HasValue)
								{
									text += "Colli, ";
								}
								if (Args.Volume.HasValue)
								{
									text += "Volume, ";
								}
								if (Args.Altezza.HasValue)
								{
									text += "Altezza, ";
								}
								if (Args.Larghezza.HasValue)
								{
									text += "Larghezza, ";
								}
								if (Args.Profondita.HasValue)
								{
									text += "Profondita, ";
								}
								text += "UdsMaster, DatIns, DatAgg, UteAgg, UteIns";
								text += ") VALUES (";
								text = text + DBConn.SQLFormatString(Args.CodiceUds) + ", ";
								text = text + DBConn.SQLFormatString(Unibol) + ", ";
								text = text + DBConn.SQLFormatString(Args.TipoUds) + ", ";
								if (Args.Descrizione != null)
								{
									text = text + DBConn.SQLFormatString(Args.Descrizione) + ", ";
								}
								if (Args.EffettuaSpunta)
								{
									text = text + DBConn.GetDate() + ", ";
									text = text + DBConn.SQLFormatString(Strings.Left(Args.OperatoreDiSpunta, 15)) + ", ";
								}
								if (Args.Peso.HasValue)
								{
									if (Operators.CompareString(ApplicationParams.WmsGetParams("UMPeso").ToString(), "KG", false) == 0)
									{
										text = text + DBConn.SQLFormatNumber(ref Args.Peso) + ", ";
									}
									else
									{
										string text3 = text;
										DBConnection dBConn = DBConn;
										decimal d = 1000m;
										decimal? peso = Args.Peso;
										decimal? obj;
										if (!peso.HasValue)
										{
											obj = null;
										}
										else
										{
											decimal? num = decimal.Divide(peso.GetValueOrDefault(), d);
											obj = num;
										}
										decimal? pNumero = obj;
										text = text3 + dBConn.SQLFormatNumber(ref pNumero) + ", ";
									}
								}
								if (Args.Colli.HasValue)
								{
									text = text + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
								}
								if (Args.Volume.HasValue)
								{
									string text4 = text;
									DBConnection dBConn2 = DBConn;
									decimal d = 1000000m;
									decimal? num = Args.Volume;
									decimal? obj2;
									if (!num.HasValue)
									{
										obj2 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj2 = peso;
									}
									decimal? pNumero = obj2;
									text = text4 + dBConn2.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Altezza.HasValue)
								{
									string text5 = text;
									DBConnection dBConn3 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Altezza;
									decimal? obj3;
									if (!num.HasValue)
									{
										obj3 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj3 = peso;
									}
									decimal? pNumero = obj3;
									text = text5 + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Larghezza.HasValue)
								{
									string text6 = text;
									DBConnection dBConn4 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Larghezza;
									decimal? obj4;
									if (!num.HasValue)
									{
										obj4 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj4 = peso;
									}
									decimal? pNumero = obj4;
									text = text6 + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Profondita.HasValue)
								{
									string text7 = text;
									DBConnection dBConn5 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Profondita;
									decimal? obj5;
									if (!num.HasValue)
									{
										obj5 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj5 = peso;
									}
									decimal? pNumero = obj5;
									text = text7 + dBConn5.SQLFormatNumber(ref pNumero) + ", ";
								}
								text = text + DBConn.SQLFormatString(Args.UdsMaster) + ", ";
								text = text + DBConn.GetDate() + ", ";
								text = text + DBConn.GetDate() + ", ";
								text = text + DBConn.SQLFormatString(_EmbeddedUser) + ", ";
								text = text + DBConn.SQLFormatString(_EmbeddedUser) + ");";
							}
							else
							{
								text = "UPDATE SpedizioniUds SET ";
								text = text + "TipoUds = " + DBConn.SQLFormatString(Args.TipoUds) + ", ";
								if (Args.Descrizione != null)
								{
									text = text + "Descrizione = " + DBConn.SQLFormatString(Args.Descrizione) + ", ";
								}
								if (Args.EffettuaSpunta)
								{
									text = text + "SpuntaDataUscita = " + DBConn.GetDate() + ", ";
									text = text + "SpuntaOperatoreUscita = " + DBConn.SQLFormatString(Strings.Left(Args.OperatoreDiSpunta, 15)) + ", ";
								}
								if (Args.Peso.HasValue)
								{
									string text8 = text;
									DBConnection dBConn6 = DBConn;
									decimal d = 1000m;
									decimal? num = Args.Peso;
									decimal? obj6;
									if (!num.HasValue)
									{
										obj6 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj6 = peso;
									}
									decimal? pNumero = obj6;
									text = text8 + "PesoLordo = " + dBConn6.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Colli.HasValue)
								{
									text = text + "Colli = " + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
								}
								if (Args.Volume.HasValue)
								{
									string text9 = text;
									DBConnection dBConn7 = DBConn;
									decimal d = 1000000m;
									decimal? num = Args.Volume;
									decimal? obj7;
									if (!num.HasValue)
									{
										obj7 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj7 = peso;
									}
									decimal? pNumero = obj7;
									text = text9 + "Volume = " + dBConn7.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Altezza.HasValue)
								{
									string text10 = text;
									DBConnection dBConn8 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Altezza;
									decimal? obj8;
									if (!num.HasValue)
									{
										obj8 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj8 = peso;
									}
									decimal? pNumero = obj8;
									text = text10 + "Altezza = " + dBConn8.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Larghezza.HasValue)
								{
									string text11 = text;
									DBConnection dBConn9 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Larghezza;
									decimal? obj9;
									if (!num.HasValue)
									{
										obj9 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj9 = peso;
									}
									decimal? pNumero = obj9;
									text = text11 + "Larghezza = " + dBConn9.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Profondita.HasValue)
								{
									string text12 = text;
									DBConnection dBConn10 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Profondita;
									decimal? obj10;
									if (!num.HasValue)
									{
										obj10 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj10 = peso;
									}
									decimal? pNumero = obj10;
									text = text12 + "Profondita = " + dBConn10.SQLFormatNumber(ref pNumero) + ", ";
								}
								text = text + "UdsMaster = " + DBConn.SQLFormatString(Args.UdsMaster) + ", ";
								text = text + "DatAgg = " + DBConn.GetDate() + ", ";
								text = text + "Uteagg = " + DBConn.SQLFormatString(_EmbeddedUser);
								string text13 = text;
								DBConnection dBConn11 = DBConn;
								long pNumero2 = Conversions.ToLong(rObjDataTable.Rows[0]["Id"]);
								text = text13 + " WHERE Id = " + dBConn11.SQLFormatNumber(ref pNumero2) + ";";
							}
							text = text + "UPDATE Spedizioni SET STATOSPUNTAUSCITA=20 WHERE UNIBOL=" + DBConn.SQLFormatString(Unibol) + " AND STATOSPUNTAUSCITA < 20;";
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

	protected FXRETURN _NotificaUds(ref WMS_UdsArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Invalid comparison between Unknown and I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Invalid comparison between Unknown and I4
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			DBConn.BeginTransaction();
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} con data {1} e committente {2} oppure ordine in stato maggiore di 30", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			}
			else
			{
				if (Args.TipoUds == null)
				{
					Args.TipoUds = "";
				}
				if (Operators.CompareString(Args.TipoUds, "", false) == 0)
				{
					Args.TipoUds = ApplicationDefault.TipoUds_Default();
				}
				if (Operators.CompareString(Args.TipoUds, "", false) == 0)
				{
					rsmess = "Tipo UDS di default non codificata";
				}
				else
				{
					if (Args.OperatoreDiSpunta == null)
					{
						Args.OperatoreDiSpunta = "";
					}
					if (Args.UdsMaster == null)
					{
						Args.UdsMaster = "";
					}
					if (Operators.CompareString(Args.UdsMaster, "", false) == 0)
					{
						Args.UdsMaster = Args.CodiceUds;
					}
					string text = "UPDATE SpedizioniUds SET Unibol=Unibol ";
					text = text + "WHERE Codice=" + DBConn.SQLFormatString(Args.CodiceUds) + " AND ";
					text = text + "Unibol=" + DBConn.SQLFormatString(Unibol);
					val2 = DBConn.SqlExec(text, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						string text2 = "SELECT * FROM SpedizioniUds ";
						text2 = text2 + "WHERE Codice=" + DBConn.SQLFormatString(Args.CodiceUds) + " AND ";
						text2 = text2 + "Unibol=" + DBConn.SQLFormatString(Unibol);
						val2 = DBConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							if (rObjDataTable.Rows.Count == 0)
							{
								text = "INSERT INTO SpedizioniUds (";
								text += "Codice, Unibol, TipoUds, ";
								if (Args.Descrizione != null)
								{
									text += "Descrizione, ";
								}
								if (Args.Peso.HasValue)
								{
									text += "PesoLordo, ";
								}
								if (Args.Colli.HasValue)
								{
									text += "Colli, ";
								}
								if (Args.Volume.HasValue)
								{
									text += "Volume, ";
								}
								if (Args.Altezza.HasValue)
								{
									text += "Altezza, ";
								}
								if (Args.Larghezza.HasValue)
								{
									text += "Larghezza, ";
								}
								if (Args.Profondita.HasValue)
								{
									text += "Profondita, ";
								}
								text += "UdsMaster, DatIns, DatAgg, UteAgg, UteIns";
								text += ") VALUES (";
								text = text + DBConn.SQLFormatString(Args.CodiceUds) + ", ";
								text = text + DBConn.SQLFormatString(Unibol) + ", ";
								text = text + DBConn.SQLFormatString(Args.TipoUds) + ", ";
								if (Args.Descrizione != null)
								{
									text = text + DBConn.SQLFormatString(Args.Descrizione) + ", ";
								}
								if (Args.Peso.HasValue)
								{
									if (Operators.CompareString(ApplicationParams.WmsGetParams("UMPeso").ToString(), "KG", false) == 0)
									{
										text = text + DBConn.SQLFormatNumber(ref Args.Peso) + ", ";
									}
									else
									{
										string text3 = text;
										DBConnection dBConn = DBConn;
										decimal d = 1000m;
										decimal? peso = Args.Peso;
										decimal? obj;
										if (!peso.HasValue)
										{
											obj = null;
										}
										else
										{
											decimal? num = decimal.Divide(peso.GetValueOrDefault(), d);
											obj = num;
										}
										decimal? pNumero = obj;
										text = text3 + dBConn.SQLFormatNumber(ref pNumero) + ", ";
									}
								}
								if (Args.Colli.HasValue)
								{
									text = text + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
								}
								if (Args.Volume.HasValue)
								{
									string text4 = text;
									DBConnection dBConn2 = DBConn;
									decimal d = 1000000m;
									decimal? num = Args.Volume;
									decimal? obj2;
									if (!num.HasValue)
									{
										obj2 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj2 = peso;
									}
									decimal? pNumero = obj2;
									text = text4 + dBConn2.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Altezza.HasValue)
								{
									string text5 = text;
									DBConnection dBConn3 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Altezza;
									decimal? obj3;
									if (!num.HasValue)
									{
										obj3 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj3 = peso;
									}
									decimal? pNumero = obj3;
									text = text5 + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Larghezza.HasValue)
								{
									string text6 = text;
									DBConnection dBConn4 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Larghezza;
									decimal? obj4;
									if (!num.HasValue)
									{
										obj4 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj4 = peso;
									}
									decimal? pNumero = obj4;
									text = text6 + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Profondita.HasValue)
								{
									string text7 = text;
									DBConnection dBConn5 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Profondita;
									decimal? obj5;
									if (!num.HasValue)
									{
										obj5 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj5 = peso;
									}
									decimal? pNumero = obj5;
									text = text7 + dBConn5.SQLFormatNumber(ref pNumero) + ", ";
								}
								text = text + DBConn.SQLFormatString(Args.UdsMaster) + ", ";
								text = text + DBConn.GetDate() + ", ";
								text = text + DBConn.GetDate() + ", ";
								text = text + DBConn.SQLFormatString(_EmbeddedUser) + ", ";
								text = text + DBConn.SQLFormatString(_EmbeddedUser) + ");";
							}
							else
							{
								text = "UPDATE SpedizioniUds SET ";
								text = text + "TipoUds = " + DBConn.SQLFormatString(Args.TipoUds) + ", ";
								if (Args.Descrizione != null)
								{
									text = text + "Descrizione = " + DBConn.SQLFormatString(Args.Descrizione) + ", ";
								}
								if (Args.Peso.HasValue)
								{
									string text8 = text;
									DBConnection dBConn6 = DBConn;
									decimal d = 1000m;
									decimal? num = Args.Peso;
									decimal? obj6;
									if (!num.HasValue)
									{
										obj6 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj6 = peso;
									}
									decimal? pNumero = obj6;
									text = text8 + "PesoLordo = " + dBConn6.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Colli.HasValue)
								{
									text = text + "Colli = " + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
								}
								if (Args.Volume.HasValue)
								{
									string text9 = text;
									DBConnection dBConn7 = DBConn;
									decimal d = 1000000m;
									decimal? num = Args.Volume;
									decimal? obj7;
									if (!num.HasValue)
									{
										obj7 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj7 = peso;
									}
									decimal? pNumero = obj7;
									text = text9 + "Volume = " + dBConn7.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Altezza.HasValue)
								{
									string text10 = text;
									DBConnection dBConn8 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Altezza;
									decimal? obj8;
									if (!num.HasValue)
									{
										obj8 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj8 = peso;
									}
									decimal? pNumero = obj8;
									text = text10 + "Altezza = " + dBConn8.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Larghezza.HasValue)
								{
									string text11 = text;
									DBConnection dBConn9 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Larghezza;
									decimal? obj9;
									if (!num.HasValue)
									{
										obj9 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj9 = peso;
									}
									decimal? pNumero = obj9;
									text = text11 + "Larghezza = " + dBConn9.SQLFormatNumber(ref pNumero) + ", ";
								}
								if (Args.Profondita.HasValue)
								{
									string text12 = text;
									DBConnection dBConn10 = DBConn;
									decimal d = 100m;
									decimal? num = Args.Profondita;
									decimal? obj10;
									if (!num.HasValue)
									{
										obj10 = null;
									}
									else
									{
										decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
										obj10 = peso;
									}
									decimal? pNumero = obj10;
									text = text12 + "Profondita = " + dBConn10.SQLFormatNumber(ref pNumero) + ", ";
								}
								text = text + "UdsMaster = " + DBConn.SQLFormatString(Args.UdsMaster) + ", ";
								text = text + "DatAgg = " + DBConn.GetDate() + ", ";
								text = text + "Uteagg = " + DBConn.SQLFormatString(_EmbeddedUser);
								string text13 = text;
								DBConnection dBConn11 = DBConn;
								long pNumero2 = Conversions.ToLong(rObjDataTable.Rows[0]["Id"]);
								text = text13 + " WHERE Id = " + dBConn11.SQLFormatNumber(ref pNumero2) + ";";
							}
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

	protected FXRETURN _NotificaOrdineSpuntato(OrdineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Invalid comparison between Unknown and I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Unibol = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} con data {1} e committente {2} oppure ordine in stato maggiore di 30", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			}
			else
			{
				string text = "UPDATE Spedizioni SET STATOSPUNTAUSCITA=30 ";
				if (Args.Peso.HasValue)
				{
					string text2 = text;
					DBConnection dBConn = DBConn;
					decimal d = 1000m;
					decimal? peso = Args.Peso;
					decimal? obj;
					if (!peso.HasValue)
					{
						obj = null;
					}
					else
					{
						decimal? num = decimal.Divide(peso.GetValueOrDefault(), d);
						obj = num;
					}
					decimal? pNumero = obj;
					text = text2 + ",Peso = " + dBConn.SQLFormatNumber(ref pNumero);
				}
				if (Args.Colli.HasValue)
				{
					text = text + ",Colli = " + DBConn.SQLFormatNumber(ref Args.Colli);
				}
				if (Args.Volume.HasValue)
				{
					string text3 = text;
					DBConnection dBConn2 = DBConn;
					decimal d = 1000000m;
					decimal? num = Args.Volume;
					decimal? obj2;
					if (!num.HasValue)
					{
						obj2 = null;
					}
					else
					{
						decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
						obj2 = peso;
					}
					decimal? pNumero = obj2;
					text = text3 + ",Volume = " + dBConn2.SQLFormatNumber(ref pNumero);
				}
				if (Args.Pallet.HasValue)
				{
					text = text + ",Pallet = " + DBConn.SQLFormatNumber(ref Args.Pallet);
				}
				if (Args.CampoCalcolo1.HasValue)
				{
					text = text + ",CampoCalcolo1 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo1);
				}
				if (Args.CampoCalcolo2.HasValue)
				{
					text = text + ",CampoCalcolo2 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo2);
				}
				if (Args.CampoCalcolo3.HasValue)
				{
					text = text + ",CampoCalcolo3 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo3);
				}
				if (Args.CampoCalcolo4.HasValue)
				{
					text = text + ",CampoCalcolo4 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo4);
				}
				if (Args.CampoCalcolo5.HasValue)
				{
					text = text + ",CampoCalcolo5 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo5);
				}
				if (Args.CampoCalcolo6.HasValue)
				{
					text = text + ",CampoCalcolo6 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo6);
				}
				if (Args.CampoCalcolo7.HasValue)
				{
					text = text + ",CampoCalcolo7 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo7);
				}
				if (Args.CampoCalcolo8.HasValue)
				{
					text = text + ",CampoCalcolo8 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo8);
				}
				if (Args.CampoCalcolo9.HasValue)
				{
					text = text + ",CampoCalcolo9 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo9);
				}
				if (Args.CampoCalcolo10.HasValue)
				{
					text = text + ",CampoCalcolo10 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo10);
				}
				if (Args.Contrassegno.HasValue)
				{
					text = text + ",Contrassegno = " + DBConn.SQLFormatNumber(ref Args.Contrassegno);
				}
				text = text + ",DatAgg=" + DBConn.GetDate();
				text = text + ",UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser);
				text = text + " WHERE UNIBOL=" + DBConn.SQLFormatString(Unibol) + ";";
				string RetQueryToApply = "";
				val2 = EventoSpedizione_SpuntaUdsUscita.RunProc(CreateApiContext(), Unibol, _EmbeddedUser, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					text += RetQueryToApply;
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

	protected FXRETURN _NotificaOrdinePrelevato(ref OrdinePrelevatoArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Invalid comparison between Unknown and I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Invalid comparison between Unknown and I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} oppure ordine in stato maggiore di 30", text);
			}
			else
			{
				string text2 = "UPDATE Spedizioni SET Note=Note ";
				text2 = text2 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
				val2 = DBConn.SqlExec(text2, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					string text3 = "SELECT * FROM Spedizioni ";
					text3 = text3 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
					val2 = DBConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsmess = TranslateMessage("XXX", "Spedizione {0} non trovata.", Unibol);
					}
					else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) > 30)
					{
						rsmess = TranslateMessage("XXX", "Lo stato della spedizione {0} corrispondente all'ordine {1} non ne consente l'avanzamento.", Unibol, text);
					}
					else
					{
						text2 = "UPDATE Spedizioni SET StatoWMS=30 ";
						if (Args.Peso.HasValue)
						{
							string text4 = text2;
							DBConnection dBConn = DBConn;
							decimal d = 1000m;
							decimal? peso = Args.Peso;
							decimal? obj;
							if (!peso.HasValue)
							{
								obj = null;
							}
							else
							{
								decimal? num = decimal.Divide(peso.GetValueOrDefault(), d);
								obj = num;
							}
							decimal? pNumero = obj;
							text2 = text4 + ",Peso = " + dBConn.SQLFormatNumber(ref pNumero);
						}
						if (Args.Colli.HasValue)
						{
							text2 = text2 + ",Colli = " + DBConn.SQLFormatNumber(ref Args.Colli);
						}
						if (Args.Volume.HasValue)
						{
							string text5 = text2;
							DBConnection dBConn2 = DBConn;
							decimal d = 1000000m;
							decimal? num = Args.Volume;
							decimal? obj2;
							if (!num.HasValue)
							{
								obj2 = null;
							}
							else
							{
								decimal? peso = decimal.Divide(num.GetValueOrDefault(), d);
								obj2 = peso;
							}
							decimal? pNumero = obj2;
							text2 = text5 + ",Volume = " + dBConn2.SQLFormatNumber(ref pNumero);
						}
						if (Args.Pallet.HasValue)
						{
							text2 = text2 + ",Pallet = " + DBConn.SQLFormatNumber(ref Args.Pallet);
						}
						if (Args.CampoCalcolo1.HasValue)
						{
							text2 = text2 + ",CampoCalcolo1 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo1);
						}
						if (Args.CampoCalcolo2.HasValue)
						{
							text2 = text2 + ",CampoCalcolo2 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo2);
						}
						if (Args.CampoCalcolo3.HasValue)
						{
							text2 = text2 + ",CampoCalcolo3 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo3);
						}
						if (Args.CampoCalcolo4.HasValue)
						{
							text2 = text2 + ",CampoCalcolo4 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo4);
						}
						if (Args.CampoCalcolo5.HasValue)
						{
							text2 = text2 + ",CampoCalcolo5 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo5);
						}
						if (Args.CampoCalcolo6.HasValue)
						{
							text2 = text2 + ",CampoCalcolo6 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo6);
						}
						if (Args.CampoCalcolo7.HasValue)
						{
							text2 = text2 + ",CampoCalcolo7 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo7);
						}
						if (Args.CampoCalcolo8.HasValue)
						{
							text2 = text2 + ",CampoCalcolo8 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo8);
						}
						if (Args.CampoCalcolo9.HasValue)
						{
							text2 = text2 + ",CampoCalcolo9 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo9);
						}
						if (Args.CampoCalcolo10.HasValue)
						{
							text2 = text2 + ",CampoCalcolo10 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo10);
						}
						if (Args.Contrassegno.HasValue)
						{
							text2 = text2 + ",Contrassegno = " + DBConn.SQLFormatNumber(ref Args.Contrassegno);
						}
						text2 = text2 + ",DatAgg=" + DBConn.GetDate();
						text2 = text2 + ",UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser);
						text2 = text2 + " WHERE Unibol=" + DBConn.SQLFormatString(Unibol) + ";";
						string RetQueryToApply = "";
						val2 = EventoSpedizione_WMSPrelevato.RunProc(CreateApiContext(), Unibol, _EmbeddedUser, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							text2 += RetQueryToApply;
							val2 = DBConn.SqlExec(text2, ref rsmess);
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

	protected FXRETURN _NotificaFineSpuntaSagome(ViaggioPalletSagomeArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Viaggi SET ";
			if (Args.NumeroPallet.HasValue)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				int pNumero = Args.NumeroPallet.Value;
				text = text2 + "PalletPassivo=" + dBConn.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagome.HasValue)
			{
				text = text + "Sagome=" + DBConn.SQLFormatNumber(ref Args.NumeroSagome) + ", ";
			}
			if (Args.Volume.HasValue)
			{
				string text3 = text;
				DBConnection dBConn2 = DBConn;
				decimal pNumero2 = Args.Volume.Value;
				text = text3 + "VolumePassivo=" + dBConn2.SQLFormatNumber(ref pNumero2) + ", ";
			}
			if (Args.NumeroPalletEffettivi.HasValue)
			{
				string text4 = text;
				DBConnection dBConn3 = DBConn;
				int pNumero = Args.NumeroPalletEffettivi.Value;
				text = text4 + "PalletEffettivi=" + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagomeEffettive.HasValue)
			{
				string text5 = text;
				DBConnection dBConn4 = DBConn;
				int pNumero = Args.NumeroSagomeEffettive.Value;
				text = text5 + "SagomeEffettive=" + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.VolumeEffettivo.HasValue)
			{
				string text6 = text;
				DBConnection dBConn5 = DBConn;
				decimal pNumero2 = Args.VolumeEffettivo.Value;
				text = text6 + "VolumeEffettivo=" + dBConn5.SQLFormatNumber(ref pNumero2) + ", ";
			}
			text = text + "DatAgg = " + DBConn.GetDate() + ", ";
			text = text + "UteAgg = " + DBConn.SQLFormatString(_EmbeddedUser) + " ";
			text = text + "WHERE IdViaggio=" + DBConn.SQLFormatString(Args.Id);
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

	protected FXRETURN _NotificaNumeroPalletSagomeAViaggio(ViaggioPalletSagomeArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Viaggi SET ";
			if (Args.NumeroPallet.HasValue)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				int pNumero = Args.NumeroPallet.Value;
				text = text2 + "PalletPassivo=" + dBConn.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagome.HasValue)
			{
				text = text + "Sagome=" + DBConn.SQLFormatNumber(ref Args.NumeroSagome) + ", ";
			}
			if (Args.Volume.HasValue)
			{
				string text3 = text;
				DBConnection dBConn2 = DBConn;
				decimal pNumero2 = Args.Volume.Value;
				text = text3 + "VolumePassivo=" + dBConn2.SQLFormatNumber(ref pNumero2) + ", ";
			}
			if (Args.NumeroPalletEffettivi.HasValue)
			{
				string text4 = text;
				DBConnection dBConn3 = DBConn;
				int pNumero = Args.NumeroPalletEffettivi.Value;
				text = text4 + "PalletEffettivi=" + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagomeEffettive.HasValue)
			{
				string text5 = text;
				DBConnection dBConn4 = DBConn;
				int pNumero = Args.NumeroSagomeEffettive.Value;
				text = text5 + "SagomeEffettive=" + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.VolumeEffettivo.HasValue)
			{
				string text6 = text;
				DBConnection dBConn5 = DBConn;
				decimal pNumero2 = Args.VolumeEffettivo.Value;
				text = text6 + "VolumeEffettivo=" + dBConn5.SQLFormatNumber(ref pNumero2) + ", ";
			}
			text = text + "DatAgg = " + DBConn.GetDate() + ", ";
			text = text + "UteAgg = " + DBConn.SQLFormatString(_EmbeddedUser) + " ";
			text = text + "WHERE IdViaggio=" + DBConn.SQLFormatString(Args.Id);
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

	protected FXRETURN _FineLavorazioneOrdine(OrdineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Unibol = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} con data {1} e committente {2} oppure ordine in stato maggiore di 30", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			}
			else
			{
				string text = "UPDATE Spedizioni SET STATOSPUNTAUSCITA=40 ";
				text = text + ",DatAgg=" + DBConn.GetDate();
				text = text + ",UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser);
				text = text + " WHERE UNIBOL=" + DBConn.SQLFormatString(Unibol) + ";";
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

	protected FXRETURN _NotificaInizioSpuntaSagome(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val = (FXRETURN)0;
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

	protected FXRETURN _NotificaNumeroPalletSagome(NotificaPalletSagomeArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Spedizioni_Batch SET ";
			if (Args.NumeroPallet.HasValue)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				int pNumero = Args.NumeroPallet.Value;
				text = text2 + "Pallet=" + dBConn.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagome.HasValue)
			{
				text = text + "Sagome=" + DBConn.SQLFormatNumber(ref Args.NumeroSagome) + ", ";
			}
			if (Args.Volume.HasValue)
			{
				string text3 = text;
				DBConnection dBConn2 = DBConn;
				decimal pNumero2 = Args.Volume.Value;
				text = text3 + "Volume=" + dBConn2.SQLFormatNumber(ref pNumero2) + ", ";
			}
			if (Args.NumeroPalletEffettivi.HasValue)
			{
				string text4 = text;
				DBConnection dBConn3 = DBConn;
				int pNumero = Args.NumeroPalletEffettivi.Value;
				text = text4 + "PalletEffettivi=" + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagomeEffettive.HasValue)
			{
				string text5 = text;
				DBConnection dBConn4 = DBConn;
				int pNumero = Args.NumeroSagomeEffettive.Value;
				text = text5 + "SagomeEffettive=" + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.VolumeEffettivo.HasValue)
			{
				string text6 = text;
				DBConnection dBConn5 = DBConn;
				decimal pNumero2 = Args.VolumeEffettivo.Value;
				text = text6 + "VolumeEffettivo=" + dBConn5.SQLFormatNumber(ref pNumero2) + ", ";
			}
			text = text + "DatAgg = " + DBConn.GetDate() + ", ";
			text = text + "UteAgg = " + DBConn.SQLFormatString(_EmbeddedUser) + " ";
			text = text + "WHERE Id=" + DBConn.SQLFormatString(Args.Id);
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

	protected FXRETURN _NotificaFineFormazioneSagome(ViaggioPalletSagomeArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Viaggi SET ";
			if (Args.NumeroPallet.HasValue)
			{
				string text2 = text;
				DBConnection dBConn = DBConn;
				int pNumero = Args.NumeroPallet.Value;
				text = text2 + "PalletPassivo=" + dBConn.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagome.HasValue)
			{
				text = text + "Sagome=" + DBConn.SQLFormatNumber(ref Args.NumeroSagome) + ", ";
			}
			if (Args.Volume.HasValue)
			{
				string text3 = text;
				DBConnection dBConn2 = DBConn;
				decimal pNumero2 = Args.Volume.Value;
				text = text3 + "VolumePassivo=" + dBConn2.SQLFormatNumber(ref pNumero2) + ", ";
			}
			if (Args.NumeroPalletEffettivi.HasValue)
			{
				string text4 = text;
				DBConnection dBConn3 = DBConn;
				int pNumero = Args.NumeroPalletEffettivi.Value;
				text = text4 + "PalletEffettivi=" + dBConn3.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.NumeroSagomeEffettive.HasValue)
			{
				string text5 = text;
				DBConnection dBConn4 = DBConn;
				int pNumero = Args.NumeroSagomeEffettive.Value;
				text = text5 + "SagomeEffettive=" + dBConn4.SQLFormatNumber(ref pNumero) + ", ";
			}
			if (Args.VolumeEffettivo.HasValue)
			{
				string text6 = text;
				DBConnection dBConn5 = DBConn;
				decimal pNumero2 = Args.VolumeEffettivo.Value;
				text = text6 + "VolumeEffettivo=" + dBConn5.SQLFormatNumber(ref pNumero2) + ", ";
			}
			text = text + "DatAgg = " + DBConn.GetDate() + ", ";
			text = text + "UteAgg = " + DBConn.SQLFormatString(_EmbeddedUser) + " ";
			text = text + "WHERE IdViaggio=" + DBConn.SQLFormatString(Args.Id);
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

	protected FXRETURN _NotificaInizioFormazioneSagome(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val = (FXRETURN)0;
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

	protected FXRETURN _FineLavorazioneBatch(ref BatchArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = "UPDATE Spedizioni_Batch SET Stato = Stato ";
			text = text + "WHERE Id = " + DBConn.SQLFormatString(Args.Id);
			val2 = DBConn.SqlExec(text, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				DataTable rObjDataTable = null;
				text = "SELECT * FROM Spedizioni_Batch ";
				text = text + " WHERE Id = " + DBConn.SQLFormatString(Args.Id);
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Batch {0} non trovato.", Args.Id);
				}
				else
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) > 25)
					{
						goto IL_012f;
					}
					text = "UPDATE Spedizioni_Batch SET Stato = '30', DataChiusura=GETDATE() WHERE Id = " + DBConn.SQLFormatString(Args.Id);
					val2 = DBConn.SqlExec(text, ref rsmess);
					if ((int)val2 == 0)
					{
						goto IL_012f;
					}
					val = val2;
				}
			}
			goto end_IL_000a;
			IL_012f:
			DBConn.CommitTransaction();
			val = (FXRETURN)0;
			end_IL_000a:;
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

	protected FXRETURN _FinePrelievoBatch(ref BatchArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = "UPDATE Spedizioni_Batch SET Stato = Stato ";
			text = text + "WHERE Id = " + DBConn.SQLFormatString(Args.Id);
			val2 = DBConn.SqlExec(text, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				DataTable rObjDataTable = null;
				text = "SELECT * FROM Spedizioni_Batch ";
				text = text + " WHERE Id = " + DBConn.SQLFormatString(Args.Id);
				val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Batch {0} non trovato.", Args.Id);
				}
				else
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) > 20)
					{
						goto IL_012f;
					}
					text = "UPDATE Spedizioni_Batch SET Stato = '25', DataFinePrelievo=GETDATE() WHERE Id = " + DBConn.SQLFormatString(Args.Id);
					val2 = DBConn.SqlExec(text, ref rsmess);
					if ((int)val2 == 0)
					{
						goto IL_012f;
					}
					val = val2;
				}
			}
			goto end_IL_000a;
			IL_012f:
			DBConn.CommitTransaction();
			val = (FXRETURN)0;
			end_IL_000a:;
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

	protected FXRETURN _FineLavorazioneViaggio(ViaggioArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			string text = "UPDATE Viaggi SET FLAG1='S', ";
			text = text + "DatAgg = " + DBConn.GetDate() + ", ";
			text = text + "UteAgg = " + DBConn.SQLFormatString(_EmbeddedUser) + " ";
			text = text + "WHERE IdViaggio=" + DBConn.SQLFormatString(Args.Id);
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

	protected FXRETURN _SpedizioneAggiornaRiferimentiDDT(ref DDTArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Invalid comparison between Unknown and I4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Invalid comparison between Unknown and I4
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Invalid comparison between Unknown and I4
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			string sSql;
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} oppure ordine in stato maggiore di 30", text);
			}
			else
			{
				if (Operators.CompareString(Args.Corrispondente, "", false) == 0)
				{
					goto IL_0164;
				}
				sSql = "SELECT COUNT(*) FROM Corrispondenti WHERE Attivo='S' AND Codice=" + DBConn.SQLFormatString(Args.Corrispondente);
				object objRes = null;
				val2 = DBConn.DoSql(sSql, ref objRes, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (objRes != null && Conversions.ToInteger(objRes) != 0)
					{
						goto IL_0164;
					}
					rsmess = TranslateMessage("XXX", "Corrispondente {0} non esistente.", Args.Corrispondente);
				}
			}
			goto end_IL_0014;
			IL_0680:
			DBConn.CommitTransaction();
			val = (FXRETURN)0;
			goto end_IL_0014;
			IL_0164:
			sSql = "UPDATE Spedizioni SET Note=Note ";
			sSql = sSql + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
			val2 = DBConn.SqlExec(sSql, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				string text2 = "SELECT * FROM Spedizioni ";
				text2 = text2 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
				val2 = DBConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Spedizione {0} non trovata.", Unibol);
				}
				else if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) >= 40)
				{
					rsmess = TranslateMessage("XXX", "Lo stato della spedizione {0} corrispondente all'ordine {1} non ne consente l'aggiornamento dei riferimenti DDT.", Unibol, text);
				}
				else
				{
					sSql = "UPDATE Spedizioni SET NumeroBolla=" + DBConn.SQLFormatString(Args.NumeroDDT) + ", ";
					sSql = sSql + "DataBolla=" + DBConn.SQLFormatDate((eTipoData)1, Args.DataDDT) + ", ";
					if (Args.Peso.HasValue)
					{
						sSql = sSql + "Peso=" + DBConn.SQLFormatNumber(ref Args.Peso) + ", ";
					}
					if (Args.Volume.HasValue)
					{
						sSql = sSql + "Volume=" + DBConn.SQLFormatNumber(ref Args.Volume) + ", ";
					}
					if (Args.Colli.HasValue)
					{
						sSql = sSql + "Colli=" + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
					}
					if (Args.Pallet.HasValue)
					{
						sSql = sSql + "Pallet=" + DBConn.SQLFormatNumber(ref Args.Pallet);
					}
					if (Args.CampoCalcolo1.HasValue)
					{
						sSql = sSql + ",CampoCalcolo1 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo1);
					}
					if (Args.CampoCalcolo2.HasValue)
					{
						sSql = sSql + ",CampoCalcolo2 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo2);
					}
					if (Args.CampoCalcolo3.HasValue)
					{
						sSql = sSql + ",CampoCalcolo3 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo3);
					}
					if (Args.CampoCalcolo4.HasValue)
					{
						sSql = sSql + ",CampoCalcolo4 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo4);
					}
					if (Args.CampoCalcolo5.HasValue)
					{
						sSql = sSql + ",CampoCalcolo5 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo5);
					}
					if (Args.CampoCalcolo6.HasValue)
					{
						sSql = sSql + ",CampoCalcolo6 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo6);
					}
					if (Args.CampoCalcolo7.HasValue)
					{
						sSql = sSql + ",CampoCalcolo7 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo7);
					}
					if (Args.CampoCalcolo8.HasValue)
					{
						sSql = sSql + ",CampoCalcolo8 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo8);
					}
					if (Args.CampoCalcolo9.HasValue)
					{
						sSql = sSql + ",CampoCalcolo9 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo9);
					}
					if (Args.CampoCalcolo10.HasValue)
					{
						sSql = sSql + ",CampoCalcolo10 = " + DBConn.SQLFormatNumber(ref Args.CampoCalcolo10);
					}
					if (Args.Contrassegno.HasValue)
					{
						sSql = sSql + ",Contrassegno = " + DBConn.SQLFormatNumber(ref Args.Contrassegno);
					}
					sSql += ", PreBolla='N', ";
					sSql = sSql + "DatAgg=" + DBConn.GetDate() + ", ";
					sSql = sSql + "UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser) + " ";
					sSql = sSql + "WHERE Unibol=" + DBConn.SQLFormatString(Unibol) + ";";
					string RetQueryToApply = "";
					val2 = EventoSpedizione_StampaDDT.RunProc(CreateApiContext(), Unibol, _EmbeddedUser, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						sSql += RetQueryToApply;
						val2 = DBConn.SqlExec(sSql, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							if (Operators.CompareString(Args.Corrispondente, "", false) == 0)
							{
								goto IL_0680;
							}
							List<string> list = new List<string>();
							list.Add(Unibol);
							val2 = Spedizione_AggiungiTransitPoint.RunProc(CreateApiContext(), list, Args.Corrispondente, ref rsmess);
							if ((int)val2 == 0)
							{
								goto IL_0680;
							}
							val = val2;
						}
					}
				}
			}
			end_IL_0014:;
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

	protected FXRETURN _NotificaOrdineDataSpedizione(ref OrdineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Invalid comparison between Unknown and I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			string text2;
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} oppure ordine in stato maggiore di 30", text);
			}
			else
			{
				text2 = "UPDATE Spedizioni SET Note=Note ";
				text2 = text2 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
				val2 = DBConn.SqlExec(text2, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					string text3 = "SELECT * FROM Spedizioni ";
					text3 = text3 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol);
					val2 = DBConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsmess = TranslateMessage("XXX", "Spedizione {0} non trovata.", Unibol);
					}
					else if (Args.DataSpedizione.HasValue)
					{
						if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) <= 10 || DateTime.Compare(Conversions.ToDate(rObjDataTable.Rows[0]["DataSpedizione"]), Args.DataSpedizione.Value) == 0)
						{
							goto IL_0260;
						}
						rsmess = TranslateMessage("XXX", "Lo stato della spedizione {0} corrispondente all'ordine {1} non consente l'aggiornamento della data spedizione.", Unibol, text);
					}
					else
					{
						if (Conversions.ToInteger(rObjDataTable.Rows[0]["Stato"]) <= 10)
						{
							goto IL_0260;
						}
						rsmess = TranslateMessage("XXX", "Lo stato della spedizione {0} corrispondente all'ordine {1} non consente l'aggiornamento della data spedizione.", Unibol, text);
					}
				}
			}
			goto end_IL_0014;
			IL_0260:
			text2 = "UPDATE Spedizioni SET DataSpedizione=" + DBConn.SQLFormatDate((eTipoData)1, Args.DataSpedizione) + " ";
			text2 = text2 + ",DatAgg=" + DBConn.GetDate();
			text2 = text2 + ",UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser);
			text2 = text2 + " WHERE Unibol=" + DBConn.SQLFormatString(Unibol);
			val2 = DBConn.SqlExec(text2, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				DBConn.CommitTransaction();
				val = (FXRETURN)0;
			}
			end_IL_0014:;
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

	protected FXRETURN _NotificaOrdineInizioPrelievo(ref OrdineArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			DBConn.BeginTransaction();
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} oppure ordine in stato maggiore di 30", text);
			}
			else
			{
				text2 += "UPDATE Spedizioni SET StatoWMS=20 ";
				text2 = text2 + ",DatAgg=" + DBConn.GetDate();
				text2 = text2 + ",UteAgg=" + DBConn.SQLFormatString(_EmbeddedUser);
				text2 = text2 + " WHERE Unibol=" + DBConn.SQLFormatString(Unibol);
				val2 = DBConn.SqlExec(text2, ref rsmess);
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

	protected FXRETURN _NotificaSagomeVolumetrichePerRaggruppamentoOrdini(ref WMS_RaggruppamentiOrdiniArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Invalid comparison between Unknown and I4
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			foreach (WMS_RaggruppamentoOrdiniArgs item in Args.Raggruppamenti)
			{
				bool flag = false;
				if (item.CodiceRaggruppamento == null)
				{
					item.CodiceRaggruppamento = "";
				}
				if (item.Ordini == null)
				{
					if (Operators.CompareString(item.CodiceRaggruppamento, "", false) != 0)
					{
						flag = true;
					}
				}
				else if (item.Ordini.Count == 0 && Operators.CompareString(item.CodiceRaggruppamento, "", false) != 0)
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_022f;
				}
				string[] array = item.CodiceRaggruppamento.Split(new char[1] { '-' });
				string vsStringa = array[0];
				string text2 = array[1];
				string vsStringa2 = array[2];
				string text3 = "SELECT Unibol, NumeroOrdine, DataOrdine, Cliente FROM Spedizioni WHERE IdViaggio=" + DBConn.SQLFormatString(vsStringa) + " ";
				if (Operators.CompareString(text2, "D", false) == 0)
				{
					text3 = text3 + "AND PCSDestinazione=" + DBConn.SQLFormatString(vsStringa2) + " ";
					text3 += "AND Corrispondente IS NULL";
				}
				else if (Operators.CompareString(text2, "C", false) == 0)
				{
					text3 = text3 + "AND Corrispondente=" + DBConn.SQLFormatString(vsStringa2) + " ";
					text3 += "AND Corrispondente IS NOT NULL";
				}
				DataTable rObjDataTable = null;
				val2 = DBConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
				if ((int)val2 == 0)
				{
					item.Ordini = new List<OrdineArgs>();
					foreach (DataRow row in rObjDataTable.Rows)
					{
						OrdineArgs ordineArgs = new OrdineArgs();
						ordineArgs.NumeroOrdine = row["NumeroOrdine"].ToString();
						ordineArgs.Committente = row["Cliente"].ToString();
						ordineArgs.DataOrdine = Conversions.ToDate(row["DataOrdine"]);
						item.Ordini.Add(ordineArgs);
					}
					goto IL_022f;
				}
				val = val2;
				goto end_IL_000a;
				IL_022f:
				string text4 = " (1=2) ";
				foreach (OrdineArgs item2 in item.Ordini)
				{
					text4 = text4 + " OR (NumeroOrdine=" + DBConn.SQLFormatString(item2.NumeroOrdine) + " ";
					text4 = text4 + "AND DataOrdine=" + DBConn.SQLFormatDate((eTipoData)1, item2.DataOrdine) + " ";
					text4 = text4 + "AND Cliente=" + DBConn.SQLFormatString(item2.Committente) + " ";
					text4 += "AND ProgressivoConsegna=0) ";
				}
				text += "UPDATE Spedizioni SET Unibol=Unibol ";
				if (item.SagomeVolumetriche.HasValue)
				{
					text += ",CampoCalcolo10=0";
				}
				if (item.CampoCalcolo1.HasValue)
				{
					text += ",CampoCalcolo1=0";
				}
				if (item.CampoCalcolo2.HasValue)
				{
					text += ",CampoCalcolo2=0";
				}
				if (item.CampoCalcolo3.HasValue)
				{
					text += ",CampoCalcolo3=0";
				}
				if (item.CampoCalcolo4.HasValue)
				{
					text += ",CampoCalcolo4=0";
				}
				if (item.CampoCalcolo5.HasValue)
				{
					text += ",CampoCalcolo5=0";
				}
				if (item.CampoCalcolo6.HasValue)
				{
					text += ",CampoCalcolo6=0";
				}
				if (item.CampoCalcolo7.HasValue)
				{
					text += ",CampoCalcolo7=0";
				}
				if (item.CampoCalcolo8.HasValue)
				{
					text += ",CampoCalcolo8=0";
				}
				if (item.CampoCalcolo9.HasValue)
				{
					text += ",CampoCalcolo9=0";
				}
				if (item.Colli.HasValue)
				{
					text += ",Colli=0";
				}
				if (item.Pallet.HasValue)
				{
					text += ",Pallet=0";
				}
				if (item.Volume.HasValue)
				{
					text += ",Volume=0";
				}
				if (item.Peso.HasValue)
				{
					text += ",Peso=0";
				}
				text = text + " WHERE " + text4 + ";";
				text4 = "";
				text4 = text4 + "NumeroOrdine=" + DBConn.SQLFormatString(item.Ordini[0].NumeroOrdine) + " ";
				text4 = text4 + "AND DataOrdine=" + DBConn.SQLFormatDate((eTipoData)1, item.Ordini[0].DataOrdine) + " ";
				text4 = text4 + "AND Cliente=" + DBConn.SQLFormatString(item.Ordini[0].Committente) + " ";
				text4 += "AND ProgressivoConsegna=0 ";
				text += "UPDATE Spedizioni SET Unibol=Unibol ";
				if (item.SagomeVolumetriche.HasValue)
				{
					string text5 = text;
					DBConnection dBConn = DBConn;
					decimal pNumero = item.SagomeVolumetriche.Value;
					text = text5 + ",CampoCalcolo10=" + dBConn.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo1.HasValue)
				{
					string text6 = text;
					DBConnection dBConn2 = DBConn;
					decimal pNumero = item.CampoCalcolo1.Value;
					text = text6 + ",CampoCalcolo1=" + dBConn2.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo2.HasValue)
				{
					string text7 = text;
					DBConnection dBConn3 = DBConn;
					decimal pNumero = item.CampoCalcolo2.Value;
					text = text7 + ",CampoCalcolo2=" + dBConn3.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo3.HasValue)
				{
					string text8 = text;
					DBConnection dBConn4 = DBConn;
					decimal pNumero = item.CampoCalcolo3.Value;
					text = text8 + ",CampoCalcolo3=" + dBConn4.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo4.HasValue)
				{
					string text9 = text;
					DBConnection dBConn5 = DBConn;
					decimal pNumero = item.CampoCalcolo4.Value;
					text = text9 + ",CampoCalcolo4=" + dBConn5.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo5.HasValue)
				{
					string text10 = text;
					DBConnection dBConn6 = DBConn;
					decimal pNumero = item.CampoCalcolo5.Value;
					text = text10 + ",CampoCalcolo5=" + dBConn6.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo6.HasValue)
				{
					string text11 = text;
					DBConnection dBConn7 = DBConn;
					decimal pNumero = item.CampoCalcolo6.Value;
					text = text11 + ",CampoCalcolo6=" + dBConn7.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo7.HasValue)
				{
					string text12 = text;
					DBConnection dBConn8 = DBConn;
					decimal pNumero = item.CampoCalcolo7.Value;
					text = text12 + ",CampoCalcolo7=" + dBConn8.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo8.HasValue)
				{
					string text13 = text;
					DBConnection dBConn9 = DBConn;
					decimal pNumero = item.CampoCalcolo8.Value;
					text = text13 + ",CampoCalcolo8=" + dBConn9.SQLFormatNumber(ref pNumero);
				}
				if (item.CampoCalcolo9.HasValue)
				{
					string text14 = text;
					DBConnection dBConn10 = DBConn;
					decimal pNumero = item.CampoCalcolo9.Value;
					text = text14 + ",CampoCalcolo9=" + dBConn10.SQLFormatNumber(ref pNumero);
				}
				if (item.Colli.HasValue)
				{
					string text15 = text;
					DBConnection dBConn11 = DBConn;
					int pNumero2 = item.Colli.Value;
					text = text15 + ",Colli=" + dBConn11.SQLFormatNumber(ref pNumero2);
				}
				if (item.Pallet.HasValue)
				{
					string text16 = text;
					DBConnection dBConn12 = DBConn;
					int pNumero2 = item.Pallet.Value;
					text = text16 + ",Pallet=" + dBConn12.SQLFormatNumber(ref pNumero2);
				}
				if (item.Volume.HasValue)
				{
					string text17 = text;
					DBConnection dBConn13 = DBConn;
					decimal pNumero = item.Volume.Value;
					text = text17 + ",Volume=" + dBConn13.SQLFormatNumber(ref pNumero);
				}
				if (item.Peso.HasValue)
				{
					string text18 = text;
					DBConnection dBConn14 = DBConn;
					decimal pNumero = item.Peso.Value;
					text = text18 + ",Peso=" + dBConn14.SQLFormatNumber(ref pNumero);
				}
				text = text + " WHERE " + text4 + ";";
			}
			DBConn.BeginTransaction();
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
			end_IL_000a:;
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

	protected FXRETURN _SpedizioneDeterminaCorrispondenteMigliore(ref CorrispondenteMiglioreArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Invalid comparison between Unknown and I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string Unibol = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			text = TranslateMessage("XXX", "Numero {0} - Data {1} - Cliente {2}", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			val2 = _IdentificaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			StringCollection stringCollection;
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Unibol, "", false) == 0)
			{
				rsmess = TranslateMessage("XXX", "Nessuna spedizione corrispondente all'ordine {0} oppure ordine in stato maggiore di 30", text);
			}
			else
			{
				stringCollection = null;
				if (Args.ListOfCorrispondenti != null && Args.ListOfCorrispondenti.Count > 0)
				{
					stringCollection = Args.ListOfCorrispondenti;
					goto IL_0256;
				}
				string text2 = "SELECT Tc.Trasportatore ";
				text2 += "FROM TariffeContratti TC ";
				text2 += "WHERE TC.ContrattoTrasporto='S' ";
				text2 += "AND TC.AttivaPassiva='P' ";
				text2 = text2 + "AND TC.DataInizioValidita <= " + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now.Date) + " ";
				text2 = text2 + "AND TC.DataFineValidita >= " + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now.Date) + " ";
				text2 += "AND TC.Attivo = 'S' ";
				text2 += "AND TC.Trasportatore IN (SELECT CodiceTrasportatore FROM Corrispondenti) ";
				val2 = DBConn.OpenDataTable(text2, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (rObjDataTable.Rows.Count != 0)
					{
						stringCollection = new StringCollection();
						foreach (DataRow row in rObjDataTable.Rows)
						{
							if (!stringCollection.Contains(row["Trasportatore"].ToString()))
							{
								stringCollection.Add(row["Trasportatore"].ToString());
							}
						}
						goto IL_0256;
					}
					rsmess = TranslateMessage("XXX", "Non esistono corrispondenti con un contratto valido ad oggi.");
				}
			}
			goto end_IL_0014;
			IL_0256:
			string CorrispondenteMigliore = "";
			val2 = Spedizioni_DeterminaCorrispondenteMigliore_Invoker.Instance.RunProc(CreateApiContext(), Unibol, stringCollection, Args.DoUpdate, ref CorrispondenteMigliore, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				Args.CorrispondenteMigliore = CorrispondenteMigliore;
				val = (FXRETURN)0;
			}
			end_IL_0014:;
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

	public Result ChiusuraViaggioDaWms(Sender sender, ViaggioArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		string text = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "ID VIAGGIO=" + Args.Id;
				string rsmess2 = "";
				LogEventiMem("CHIUSURA VIAGGIO DA WMS", sNote, "", ref rsmess2);
				val2 = Viaggio_Chiudi_da_Wms_Invoker.Instance.RunProc(CreateApiContext(), Args.Id.ToString(), DateAndTime.Now, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "ID VIAGGIO=" + Args.Id;
					string sNote3 = rsmess;
					rsmess2 = "";
					LogEventiMem("CHIUSURA VIAGGIO DA WMS", sNote2, sNote3, ref rsmess2);
					val = val2;
				}
				else
				{
					val2 = Viaggio_Partenza_Invoker.Instance.RunProc(CreateApiContext(), Args.Id.ToString(), ref rsmess);
					if ((int)val2 != 0)
					{
						string sNote4 = "ID VIAGGIO=" + Args.Id;
						string sNote5 = rsmess;
						rsmess2 = "";
						LogEventiMem("PARTENZA VIAGGIO CHIUSO DA WMS", sNote4, sNote5, ref rsmess2);
						val = val2;
					}
					else
					{
						string sNote6 = "ID VIAGGIO=" + Args.Id;
						rsmess2 = "";
						LogEventiMem("PARTENZA VIAGGIO CHIUSO DA WMS", sNote6, "", ref rsmess2);
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
			string rsmess2 = "";
			LogOut(ref rsmess2);
			result = new Result(rsmess);
		}
		return result;
	}

	Result ITMSServiceForWMS.ChiusuraViaggioDaWms(Sender sender, ViaggioArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ChiusuraViaggioDaWms
		return this.ChiusuraViaggioDaWms(sender, Args);
	}

	public Result OrdineTrasferimentoDaWms(Sender sender, WMS_OrdTrasfArgs Args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		Result result;
		try
		{
			rsmess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsmess))
			{
				string sNote = "SPEDIZIONE: " + Args.NumeroOrdine + " CLIENTE=" + Args.Committente + " DATA=" + Args.DataOrdine.ToString("dd/MM/yyyy");
				string rsmess2 = "";
				LogEventiMem("INSERIMENTO SPEDIZIONE", sNote, "", ref rsmess2);
				val2 = _OrdineTrasferimentoDaWms(ref Args, ref rsmess);
				if ((int)val2 != 0)
				{
					string sNote2 = "SPEDIZIONE: " + Args.NumeroOrdine + " CLIENTE=" + Args.Committente + " DATA=" + Args.DataOrdine.ToString("dd/MM/yyyy");
					rsmess2 = "";
					LogEventiMem("INSERIMENTO SPEDIZIONE", sNote2, "", ref rsmess2);
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

	Result ITMSServiceForWMS.OrdineTrasferimentoDaWms(Sender sender, WMS_OrdTrasfArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in OrdineTrasferimentoDaWms
		return this.OrdineTrasferimentoDaWms(sender, Args);
	}

	protected FXRETURN _OrdineTrasferimentoDaWms(ref WMS_OrdTrasfArgs Args, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_1645: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Unknown result type (might be due to invalid IL or missing references)
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Invalid comparison between Unknown and I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Invalid comparison between Unknown and I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Invalid comparison between Unknown and I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Invalid comparison between Unknown and I4
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Invalid comparison between Unknown and I4
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f18: Invalid comparison between Unknown and I4
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Invalid comparison between Unknown and I4
		//IL_12c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Invalid comparison between Unknown and I4
		//IL_137d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_1384: Unknown result type (might be due to invalid IL or missing references)
		//IL_1387: Invalid comparison between Unknown and I4
		//IL_1348: Unknown result type (might be due to invalid IL or missing references)
		//IL_134a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cd: Invalid comparison between Unknown and I4
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Invalid comparison between Unknown and I4
		//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Invalid comparison between Unknown and I4
		//IL_1570: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Unknown result type (might be due to invalid IL or missing references)
		//IL_1577: Unknown result type (might be due to invalid IL or missing references)
		//IL_157a: Invalid comparison between Unknown and I4
		//IL_154d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1553: Unknown result type (might be due to invalid IL or missing references)
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN rnRes = (FXRETURN)3;
		string Unibol = "";
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		DataTable rObjDataTable = null;
		DataTable rObjDataTable2 = null;
		DataTable rObjDataTable3 = null;
		DataTable rObjDataTable4 = null;
		string vsStringa = "";
		string vsStringa2 = "";
		string vsStringa3 = "";
		string vsStringa4 = "";
		string vsStringa5 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		StreamWriter streamWriter = null;
		FXRETURN result;
		try
		{
			text7 = Parametrica.LeggiParametro("CST.PARAMS.WRTLOG", ref rnRes, ref rsmess);
			if ((int)rnRes == 0)
			{
				if (Operators.CompareString(text7, "S", false) != 0)
				{
					goto IL_0150;
				}
				text5 = Parametrica.LeggiParametro("CST.PARAMS.DIRLOGTEST.OUT", ref rnRes, ref rsmess);
				if ((int)rnRes == 0)
				{
					if (!text5.EndsWith(Conversions.ToString(Path.DirectorySeparatorChar)))
					{
						text5 += Conversions.ToString(Path.DirectorySeparatorChar);
					}
					text6 = Parametrica.LeggiParametro("CST.PARAMS.DIRLOGTEST.FILENAME", ref rnRes, ref rsmess);
					if ((int)rnRes == 0)
					{
						text6 = text6.Replace("*", Args.NumeroOrdine.ToString() + "_" + DateAndTime.Now.ToString("yyyyMMddHHmmssfff"));
						streamWriter = new StreamWriter(text5 + text6, append: true, LegacyEncoding.Ansi);
						goto IL_0150;
					}
				}
			}
			goto end_IL_006d;
			IL_0150:
			rsmess = "";
			CallStackAdd();
			DBConn.BeginTransaction();
			rnRes = _VerificaEsistenzaSpedizione(Args.Committente, Args.NumeroOrdine, Args.DataOrdine, ref Unibol, ref rsmess);
			if ((int)rnRes != 0)
			{
				val = rnRes;
			}
			else if (Operators.CompareString(Unibol, "", false) != 0)
			{
				rsmess = TranslateMessage("XXX", "Esiste già una spedizione corrispondente all'ordine {0} con data {1} e committente {2} .", Args.NumeroOrdine, Args.DataOrdine.ToString("dd/MM/yyyy"), Args.Committente);
			}
			else
			{
				text4 = "SELECT * FROM PCS WHERE FillerAlfa10 = " + DBConn.SQLFormatString(Args.MagArrivo).ToString() + " AND PuntoDiDestino='S'";
				rnRes = DBConn.OpenDataTable(text4, ref rObjDataTable2, ref rsmess);
				if (Operators.CompareString(text7, "S", false) == 0)
				{
					streamWriter.WriteLine("Magazzino di Arrivo");
					streamWriter.WriteLine(text4);
				}
				if ((int)rnRes != 0)
				{
					val = rnRes;
				}
				else if (rObjDataTable2.Rows.Count == 0)
				{
					rsmess = TranslateMessage("XXX", "Il Punto di destino {0} non esiste", Args.MagArrivo);
					if (Operators.CompareString(text7, "S", false) == 0)
					{
						streamWriter.WriteLine(rsmess);
					}
					val = (FXRETURN)14;
				}
				else if (Operators.CompareString(rObjDataTable2.Rows[0]["Attivo"].ToString(), "S", false) != 0)
				{
					rsmess = TranslateMessage("XXX", "Il Punto di destino {0} non è attivo", Args.MagArrivo);
					if (Operators.CompareString(text7, "S", false) == 0)
					{
						streamWriter.WriteLine(rsmess);
					}
					val = (FXRETURN)16;
				}
				else
				{
					text3 = "SELECT * FROM PCS WHERE FillerAlfa10 = " + DBConn.SQLFormatString(Args.MagPartenza).ToString() + " AND PuntoDiCarico='S'";
					rnRes = DBConn.OpenDataTable(text3, ref rObjDataTable, ref rsmess);
					if (Operators.CompareString(text7, "S", false) == 0)
					{
						streamWriter.WriteLine("Magazzino di Partenza");
						streamWriter.WriteLine(text3);
					}
					if ((int)rnRes != 0)
					{
						val = rnRes;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsmess = TranslateMessage("XXX", "Il Punto di carico {0} non esiste", Args.MagPartenza);
						if (Operators.CompareString(text7, "S", false) == 0)
						{
							streamWriter.WriteLine(rsmess);
						}
						val = (FXRETURN)14;
					}
					else if (Operators.CompareString(rObjDataTable.Rows[0]["Attivo"].ToString(), "S", false) != 0)
					{
						rsmess = TranslateMessage("XXX", "Il Punto di carico {0} non è attivo", Args.MagPartenza);
						if (Operators.CompareString(text7, "S", false) == 0)
						{
							streamWriter.WriteLine(rsmess);
						}
						val = (FXRETURN)16;
					}
					else
					{
						text = "SELECT * from (";
						text += "SELECT PCS,Z.TIPOMERCE,ZonaSpedizione,ZonaTariffaAttiva,ZonaTariffaPassiva, ";
						text += "CASE WHEN TipoMerce<>'*ALL' THEN 100 ELSE 0 END Peso ";
						text += "FROM PCS_Zone Z INNER JOIN TIPIMERCE TM ON TM.CODICE = Z.TIPOMERCE ";
						text = text + "WHERE Z.TipoMerce IN ('*ALL', " + DBConn.SQLFormatString(Args.TipoMerce) + ") AND ";
						text += "TM.Attivo='S' AND Z.ATTIVO = 'S') Temp ";
						text += "INNER JOIN ZONE Z1 ON Z1.CODICE = Temp.ZonaSpedizione ";
						text += "INNER JOIN ZONE Z2 ON Z2.CODICE = Temp.ZonaTariffaAttiva ";
						text += "INNER JOIN ZONE Z3 ON Z3.CODICE = Temp.ZonaTariffaPassiva ";
						text = text + "WHERE PCS = " + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Codice"].ToString()) + " ";
						text += "ORDER BY Peso DESC ";
						rnRes = DBConn.OpenDataTable(text, ref rObjDataTable4, ref rsmess);
						if (Operators.CompareString(text7, "S", false) == 0)
						{
							streamWriter.WriteLine("Zone tariffarie PCSArrivo");
							streamWriter.WriteLine(text);
						}
						if ((int)rnRes != 0)
						{
							val = rnRes;
						}
						else if (rObjDataTable4.Rows.Count == 0)
						{
							rsmess = TranslateMessage("XXX", "Zone non configurate per il punto di arrivo {0}", DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Codice"].ToString()));
							val = (FXRETURN)14;
						}
						else
						{
							if (rObjDataTable4.Rows.Count > 0)
							{
								vsStringa = rObjDataTable4.Rows[0]["ZonaSpedizione"].ToString();
								vsStringa2 = rObjDataTable4.Rows[0]["ZonaTariffaAttiva"].ToString();
								vsStringa3 = rObjDataTable4.Rows[0]["ZonaTariffaPassiva"].ToString();
							}
							text = "SELECT Z.*, CASE WHEN TipoMerce='*ALL' THEN 1 ELSE 10 END Peso ";
							text = text + "FROM PCS_ZONE Z WHERE PCS=" + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Codice"].ToString()) + " ";
							text = text + "AND TipoMerce in (" + DBConn.SQLFormatString(Args.TipoMerce) + ", '*ALL') ORDER By Peso DESC";
							rnRes = DBConn.OpenDataTable(text, ref rObjDataTable3, ref rsmess);
							if (Operators.CompareString(text7, "S", false) == 0)
							{
								streamWriter.WriteLine("Zone tariffarie PCSPartenza");
								streamWriter.WriteLine(text);
							}
							if ((int)rnRes != 0)
							{
								val = rnRes;
							}
							else if (rObjDataTable3.Rows.Count == 0)
							{
								rsmess = TranslateMessage("XXX", "Zone non configurate per il punto di partenza {0}", DBConn.SQLFormatString(rObjDataTable.Rows[0]["Codice"].ToString()));
								val = (FXRETURN)14;
							}
							else
							{
								if (rObjDataTable3.Rows.Count > 0)
								{
									vsStringa4 = rObjDataTable3.Rows[0]["ZonaTariffaAttiva"].ToString();
									vsStringa5 = rObjDataTable3.Rows[0]["ZonaTariffaPassiva"].ToString();
								}
								long rlReturnValue = default(long);
								rnRes = Parametrica.LeggiContatore("COUNTERS.SPEDIZIONI", vbStartTrans: false, ref rlReturnValue, ref rsmess);
								if ((int)rnRes != 0)
								{
									val = rnRes;
								}
								else
								{
									string text8 = ((ApplicationParams)(object)CreateApiContext().AppParams).Spedizioni_FormatoUnibol();
									Unibol = ((Operators.CompareString(text8, "", false) == 0) ? rlReturnValue.ToString() : Strings.Format((object)rlReturnValue, text8));
									text = "INSERT INTO Spedizioni (";
									text += "Unibol, UnibolParent, UnibolMaster, ProgressivoConsegna, Barcode, Stato, Prebolla, TipoServizio, Cliente, Clientefatturazione, ";
									text += "NumeroBolla, DataBolla, NumeroOrdine, DataOrdine, TipoSpedizione, TipoSpedizionePassivo, TipoMerce, ";
									text += "PCSPartenza, PCSPartenza_RagSoc, PCSPartenza_Indirizzo, PCSPartenza_Cap, PCSPartenza_Localita, PCSPartenza_Provincia, PCSPartenza_Nazione, ";
									text += "PCSDestinazione, PCSDestinazione_RagSoc, PCSDestinazione_Indirizzo, PCSDestinazione_Cap, PCSDestinazione_Localita, PCSDestinazione_Provincia, PCSDestinazione_Nazione, ";
									text += "DataConsegnaPrevista1, DataConsegnaPrevista2, Peso, Colli, Pallet, Volume, SequenzaPianificata, DataSpedizione, ";
									text += "ZonaSpedizione, ZonaPartenzaTariffaAttiva, ZonaArrivoTariffaAttiva, ZonaArrivoTariffaPassiva, DatIns, DatAgg, UteIns, UteAgg ";
									text += ") VALUES (";
									text = text + DBConn.SQLFormatString(Unibol) + ", ";
									text = text + DBConn.SQLFormatString(Unibol) + ", ";
									text = text + DBConn.SQLFormatString(Unibol) + ", ";
									text += "0, ";
									text = text + DBConn.SQLFormatString(Unibol) + ", ";
									text += "20, ";
									text = text + DBConn.SQLFormatString("N") + ",";
									text = text + DBConn.SQLFormatString("NAVETT") + ",";
									text = text + DBConn.SQLFormatString(Args.Committente) + ", ";
									text = text + DBConn.SQLFormatString(Args.Committente) + ", ";
									text = text + DBConn.SQLFormatString(Args.NumeroOrdine) + ", ";
									text = text + DBConn.SQLFormatDate((eTipoData)1, Args.DataOrdine) + ", ";
									text = text + DBConn.SQLFormatString(Args.NumeroOrdine) + ", ";
									text = text + DBConn.SQLFormatDate((eTipoData)1, Args.DataOrdine) + ", ";
									text = text + DBConn.SQLFormatString("TRFST") + ",";
									text = text + DBConn.SQLFormatString("TRFST") + ",";
									text = text + DBConn.SQLFormatString(Args.TipoMerce) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Codice"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["RagioneSociale"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Indirizzo"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Cap"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Localita"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Provincia"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Nazione"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Codice"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["RagioneSociale"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Indirizzo"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Cap"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Localita"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Provincia"].ToString()) + ", ";
									text = text + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Nazione"].ToString()) + ", ";
									text = text + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ", ";
									text = text + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ", ";
									text = text + DBConn.SQLFormatNumber(ref Args.Peso) + ", ";
									text = text + DBConn.SQLFormatNumber(ref Args.Colli) + ", ";
									text = text + DBConn.SQLFormatNumber(ref Args.Pallet) + ", ";
									text = text + DBConn.SQLFormatNumber(ref Args.Volume) + ", ";
									text += "0, ";
									text = text + DBConn.SQLFormatDate((eTipoData)1, Args.DataOrdine) + ", ";
									text = text + DBConn.SQLFormatString(vsStringa) + ", ";
									text = text + DBConn.SQLFormatString(vsStringa4) + ", ";
									text = text + DBConn.SQLFormatString(vsStringa2) + ", ";
									text = text + DBConn.SQLFormatString(vsStringa3) + ", ";
									text = text + DBConn.GetDate() + ", ";
									text = text + DBConn.GetDate() + ", ";
									text = text + DBConn.SQLFormatString(_EmbeddedUser) + ", ";
									text = text + DBConn.SQLFormatString(_EmbeddedUser) + ");";
									if (Operators.CompareString(text7, "S", false) == 0)
									{
										streamWriter.WriteLine("Inserimento Spedizione");
										streamWriter.WriteLine(text);
									}
									rnRes = DBConn.SqlExec(text, ref rsmess);
									if ((int)rnRes != 0)
									{
										val = rnRes;
									}
									else
									{
										if (Operators.CompareString(text7, "S", false) == 0)
										{
											streamWriter.WriteLine("Numero Ordine");
											streamWriter.WriteLine(Args.NumeroOrdine);
										}
										int num = 0;
										num = Conversions.ToInteger(Args.NumeroOrdine);
										if (Operators.CompareString(text7, "S", false) == 0)
										{
											streamWriter.WriteLine("Reperimento Viaggio");
											streamWriter.WriteLine(num);
											streamWriter.WriteLine("Vettore Viaggio");
											streamWriter.WriteLine(Args.Vettore);
										}
										text2 = "INSERT INTO VIAGGI (";
										text2 += "IdViaggio, Stato, TipoViaggio, DataPartenzaPianificata, Vettore, Contenitore1Pianificato, TipoSpedizione, MotricePianificata, TipoMerce, ZonaPartenza, ZonaArrivo, ";
										text2 += "ZonaPartenzaTariffaAttiva, ZonaArrivoTariffaAttiva, PCSPartenza, PCSArrivo, PCSArrivoEffettivo, DataCompetenzaAttiva, DataCompetenzaPassiva, DatIns, DatAgg, UteIns, UteAgg ";
										text2 += ") VALUES (";
										text2 = text2 + DBConn.SQLFormatNumber(ref num) + ", ";
										text2 += "10, ";
										text2 = text2 + DBConn.SQLFormatString("NAVETT") + ",";
										text2 = text2 + DBConn.SQLFormatDate((eTipoData)1, Args.DataOrdine) + ", ";
										text2 = text2 + DBConn.SQLFormatString(Args.Vettore) + ", ";
										text2 = text2 + DBConn.SQLFormatString("WMS") + ",";
										text2 = text2 + DBConn.SQLFormatString("TRFST") + ",";
										text2 = text2 + DBConn.SQLFormatString("BIL33") + ",";
										text2 = text2 + DBConn.SQLFormatString(Args.TipoMerce) + ", ";
										text2 = text2 + DBConn.SQLFormatString(vsStringa5) + ", ";
										text2 = text2 + DBConn.SQLFormatString(vsStringa3) + ", ";
										text2 = text2 + DBConn.SQLFormatString(vsStringa5) + ", ";
										text2 = text2 + DBConn.SQLFormatString(vsStringa3) + ", ";
										text2 = text2 + DBConn.SQLFormatString(rObjDataTable.Rows[0]["Codice"].ToString()) + ", ";
										text2 = text2 + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Codice"].ToString()) + ", ";
										text2 = text2 + DBConn.SQLFormatString(rObjDataTable2.Rows[0]["Codice"].ToString()) + ", ";
										text2 = text2 + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ", ";
										text2 = text2 + DBConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ", ";
										text2 = text2 + DBConn.GetDate() + ", ";
										text2 = text2 + DBConn.GetDate() + ", ";
										text2 = text2 + DBConn.SQLFormatString(_EmbeddedUser) + ", ";
										text2 = text2 + DBConn.SQLFormatString(_EmbeddedUser) + ");";
										if (Operators.CompareString(text7, "S", false) == 0)
										{
											streamWriter.WriteLine("Inserimento Viaggio");
											streamWriter.WriteLine(text2);
										}
										rnRes = DBConn.SqlExec(text2, ref rsmess);
										if ((int)rnRes != 0)
										{
											val = rnRes;
										}
										else
										{
											string text9 = "";
											text9 = "UPDATE Spedizioni SET IdViaggio = " + DBConn.SQLFormatNumber(ref num) + " ";
											text9 = text9 + "WHERE Unibol = " + DBConn.SQLFormatString(Unibol) + ";";
											if (Operators.CompareString(text7, "S", false) == 0)
											{
												streamWriter.WriteLine("Aggiornamento Spedizione con Id Viaggio");
												streamWriter.WriteLine(text9);
											}
											rnRes = DBConn.SqlExec(text9, ref rsmess);
											if ((int)rnRes != 0)
											{
												val = rnRes;
											}
											else
											{
												DataTable rObjDataTable5 = null;
												text = "SELECT UNIBOL FROM Spedizioni WHERE IdViaggio = " + DBConn.SQLFormatNumber(ref num) + " ";
												rnRes = DBConn.OpenDataTable(text, ref rObjDataTable5, ref rsmess);
												if ((int)rnRes != 0)
												{
													val = rnRes;
												}
												else
												{
													AppApiContext objApiContext = CreateApiContext();
													string Warning = "";
													string text10 = "";
													string text11 = "";
													rnRes = SpedizioniAgganciaTariffa_Invoker.Instance.RunProc(objApiContext, Unibol.ToString(), TariffaAttiva: true, TariffaPassiva: true, ref Warning, ref rsmess);
													text10 = (((int)rnRes != 0) ? (text10 + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text10 + Warning)));
													if (Operators.CompareString(text10, "", false) != 0)
													{
														text10 += "\r\n";
													}
													text11 += text10;
													string text12 = DBConn.SQLFormatNumber(ref num);
													Warning = "";
													text10 = "";
													rnRes = ViaggiAgganciaTariffa_Invoker.Instance.RunProc(objApiContext, text12.ToString(), TariffaAttiva: false, TariffaPassiva: true, ref Warning, ref rsmess);
													text10 = (((int)rnRes != 0) ? (text10 + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text10 + Warning)));
													if (Operators.CompareString(text10, "", false) != 0)
													{
														text10 += "\r\n";
													}
													text11 += text10;
													DBConn.CommitTransaction();
													string sNote = "ID VIAGGIO=" + DBConn.SQLFormatNumber(ref num);
													string rsmess2 = "";
													LogEventiMem("CHIUSURA VIAGGIO DA WMS", sNote, "", ref rsmess2);
													rnRes = Viaggio_Chiudi_Trasf_Wms_Invoker.Instance.RunProc(CreateApiContext(), num.ToString(), DateAndTime.Now, ref rsmess);
													if ((int)rnRes != 0)
													{
														string sNote2 = "ID VIAGGIO=" + DBConn.SQLFormatNumber(ref num);
														string sNote3 = rsmess;
														rsmess2 = "";
														LogEventiMem("CHIUSURA VIAGGIO DA WMS", sNote2, sNote3, ref rsmess2);
														val = rnRes;
													}
													else
													{
														rnRes = Viaggio_Partenza_Invoker.Instance.RunProc(CreateApiContext(), num.ToString(), ref rsmess);
														if ((int)rnRes != 0)
														{
															string sNote4 = "ID VIAGGIO=" + DBConn.SQLFormatNumber(ref num);
															string sNote5 = rsmess;
															rsmess2 = "";
															LogEventiMem("PARTENZA VIAGGIO CHIUSO DA WMS", sNote4, sNote5, ref rsmess2);
															val = rnRes;
														}
														else
														{
															string sNote6 = "ID VIAGGIO=" + DBConn.SQLFormatNumber(ref num);
															rsmess2 = "";
															LogEventiMem("PARTENZA VIAGGIO CHIUSO DA WMS", sNote6, "", ref rsmess2);
															val = (FXRETURN)0;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			end_IL_006d:;
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
			if (Operators.CompareString(text7, "S", false) == 0)
			{
				streamWriter.WriteLine("Fine File");
				streamWriter.Flush();
				streamWriter.Close();
				streamWriter = null;
			}
			DBConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN _VerificaEsistenzaSpedizione(string Cliente, string NumeroOrdine, DateTime DataOrdine, ref string Unibol, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			Unibol = "";
			string text = "SELECT Unibol, DataOrdine FROM Spedizioni WHERE ";
			text = text + "Cliente = " + DBConn.SQLFormatString(Cliente) + " AND ";
			text = text + "NumeroOrdine = " + DBConn.SQLFormatString(NumeroOrdine) + " AND ";
			text += "ProgressivoConsegna = 0";
			val2 = DBConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					if (rObjDataTable.Rows.Count == 1)
					{
						Unibol = rObjDataTable.Rows[0]["Unibol"].ToString();
					}
					else if (rObjDataTable.Rows.Count > 1)
					{
						foreach (DataRow row in rObjDataTable.Rows)
						{
							if (DateTime.Compare(Conversions.ToDate(row["DataOrdine"]).Date, DataOrdine.Date) == 0)
							{
								Unibol = row["Unibol"].ToString();
								break;
							}
						}
					}
				}
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
}
