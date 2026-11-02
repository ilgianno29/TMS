using System;
using System.IO;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSCWCF;

internal class IncasWCFInternal : IncasWCFStandardAuth
{
	[SpecialName]
	private bool _0024STATIC_0024BackgroundEventApplicationLog_002420218E_0024done;

	protected override string WSApplicationLog => WSApplicationLogDir + WSApplicationName + "_Internal.LOG";

	public IncasWCFInternal()
	{
		_EmbeddedUser = "ENGINE";
		_EmbeddedPassword = Incasbo.Web.WSCWCF.TechnicalUsers.InternalPassword; // prima: password fissa nel codice
	}

	protected FXRETURN AutenticazioneUtente(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = AutenticazioneUtente(_EmbeddedUser, _EmbeddedPassword, ref rsmess);
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

	public override bool TestDBConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool result;
		try
		{
			rsMess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsMess) && base.TestDBConnection(ref rsMess))
			{
				val = (FXRETURN)0;
			}
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
			string rsmess = "";
			LogOut(ref rsmess);
			result = (int)val == 0;
		}
		return result;
	}

	protected override string ServiceName()
	{
		return "IncasWCFInternal";
	}

	public FXRETURN Manutenzione(string ServiceName, int BackgroundThreadCicleNumber, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			bool flag = false;
			if (LogIn(_EmbeddedUser, _EmbeddedPassword, ref rsMess))
			{
				BackgroundEventApplicationLog(BackgroundThreadCicleNumber, "HEART BEAT - " + ServiceName);
				string sEvento = "PULIZIA SESSIONI SERVIZIO " + ServiceName;
				string rsmess = "";
				LogEventiMem(sEvento, "", "", ref rsmess);
				string text = "";
				if (SessionEnvironment.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
				{
					text = text + "DELETE FROM " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " WHERE DataInizio <= GETDATE()-" + SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceInLog + " AND ROWNUM<=2000;";
				}
				else if (SessionEnvironment.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
				{
					text = text + "DELETE TOP(2000) FROM " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " WHERE DataInizio <= GETDATE()-" + SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceInLog + ";";
				}
				if (SessionEnvironment.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
				{
					text = text + "DELETE FROM " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " WHERE Data <= GETDATE()-" + SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceInLog + " AND ROWNUM<=20000;";
				}
				else if (SessionEnvironment.DbMain.ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
				{
					text = text + "DELETE TOP(20000) FROM " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " WHERE Data <= GETDATE()-" + SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceInLog + ";";
				}
				val2 = SessionEnvironment.DbMain.SqlExec(text, ref rsMess);
				if ((int)val2 != 0)
				{
					BackgroundEventApplicationLog(BackgroundThreadCicleNumber, rsMess);
				}
				else
				{
					BackgroundEventApplicationLog(BackgroundThreadCicleNumber, "PULIZIA LOG SERVIZIO " + ServiceName + ":OK");
				}
				string sEvento2 = "PULIZIA FILE DI LOG SERVIZIO " + ServiceName;
				rsmess = "";
				LogEventiMem(sEvento2, "", "", ref rsmess);
				if (SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceOfFile > 0 && (int)EliminaFileVecchi(WSApplicationLogDir, DateAndTime.DateAdd((DateInterval)4, (double)checked(-SessionEnvironment.WSCConfig.LogConfig.DayOfPermanenceOfFile), DateAndTime.Now), "*.*", ref rsMess) != 0)
				{
					BackgroundEventApplicationLog(BackgroundThreadCicleNumber, rsMess);
				}
				val = (FXRETURN)0;
			}
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
			string rsmess = "";
			LogOut(ref rsmess);
			result = val;
		}
		return result;
	}

	protected void BackgroundEventApplicationLog(int BackgroundThreadCicleNumber, string sMessaggio)
	{
		try
		{
			if (BackgroundThreadCicleNumber == 1 && !_0024STATIC_0024BackgroundEventApplicationLog_002420218E_0024done)
			{
				string contents = Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH.mm.ss") + ": " + BackgroundThreadCicleNumber + " - INIZIO THREAD\r\n";
				File.AppendAllText(WSApplicationLog, contents);
				_0024STATIC_0024BackgroundEventApplicationLog_002420218E_0024done = true;
			}
			string contents2 = Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH.mm.ss") + ": " + BackgroundThreadCicleNumber + " - " + sMessaggio + "\r\n";
			File.AppendAllText(WSApplicationLog, contents2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
