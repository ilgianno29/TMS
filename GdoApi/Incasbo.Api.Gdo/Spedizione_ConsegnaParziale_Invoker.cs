using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ConsegnaParziale_Invoker : Api_Invoker
{
	protected static Spedizione_ConsegnaParziale_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_ConsegnaParziale_Invoker Instance
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
					_instance = new Spedizione_ConsegnaParziale_Invoker();
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

	protected Spedizione_ConsegnaParziale_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, bool? ForzaGenerazioneRiconsegna, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_ConsegnaParziale spedizione_ConsegnaParziale = (Spedizione_ConsegnaParziale)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("SequenzaEffettiva", SequenzaEffettiva);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Data", Data);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("NoteEsterne", NoteEsterne);
			if (ForzaGenerazioneRiconsegna.HasValue)
			{
				((AppAbstractApi)spedizione_ConsegnaParziale).ParametersIn.Add("ForzaGenerazioneRiconsegna", ForzaGenerazioneRiconsegna);
			}
			val = ((AppAbstractApi)spedizione_ConsegnaParziale).Run(ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, "", null, SequenzaEffettiva, Data, Autista, Motrice, Rimorchio, Contenitore, Terminale, Latitudine, Longitudine, KmGps, DataGPS, KmManuali, Localita, Indirizzo, Cap, Provincia, Nazione, NoteInterne, NoteEsterne, ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, DateTime? Data, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, CodiceEvento, null, 0, Data, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", NoteInterne, NoteEsterne, ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, bool? ForzaGenerazioneRiconsegna, DateTime? Data, string NoteInterne, string NoteEsterne, ref string rsmess)
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
			val = RunProc(objApiContext, Unibol, CodiceEvento, ForzaGenerazioneRiconsegna, 0, Data, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", NoteInterne, NoteEsterne, ref rsmess);
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
