using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_UdsNonCaricata_Invoker : Api_Invoker
{
	protected static Spedizione_UdsNonCaricata_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_UdsNonCaricata_Invoker Instance
	{
		get
		{
			object @lock = _lock;
			ObjectFlowControl.CheckForSyncLockOnValueType(@lock);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(@lock, ref lockTaken);
				if (_instance == null)
				{
					_instance = new Spedizione_UdsNonCaricata_Invoker();
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(@lock);
				}
			}
			return _instance;
		}
	}

	protected Spedizione_UdsNonCaricata_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceUds, string CodiceEvento, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Invalid comparison between Unknown and I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_UdsNonCaricata spedizione_UdsNonCaricata = (Spedizione_UdsNonCaricata)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("CodiceUds", CodiceUds);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("SequenzaEffettiva", SequenzaEffettiva);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Data", Data);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)spedizione_UdsNonCaricata).ParametersIn.Add("NoteEsterne", NoteEsterne);
			val = ((AppAbstractApi)spedizione_UdsNonCaricata).Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceUds, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, "", SequenzaEffettiva, Data, Autista, Motrice, Rimorchio, Contenitore, Terminale, Latitudine, Longitudine, KmGps, DataGPS, KmManuali, Localita, Indirizzo, Cap, Provincia, Nazione, NoteInterne, NoteEsterne, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceUds, string CodiceEvento, DateTime? Data, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, CodiceUds, CodiceEvento, 0, Data, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", NoteInterne, NoteEsterne, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}
}
