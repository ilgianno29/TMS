using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ConsegnaOk_Invoker : Api_Invoker
{
	protected static Spedizione_ConsegnaOk_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_ConsegnaOk_Invoker Instance
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
					_instance = new Spedizione_ConsegnaOk_Invoker();
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

	protected Spedizione_ConsegnaOk_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Invalid comparison between Unknown and I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_ConsegnaOk spedizione_ConsegnaOk = (Spedizione_ConsegnaOk)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("SequenzaEffettiva", SequenzaEffettiva);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Data", Data);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)spedizione_ConsegnaOk).ParametersIn.Add("NoteEsterne", NoteEsterne);
			val = ((AppAbstractApi)spedizione_ConsegnaOk).Run(ref rsmess);
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
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, DateTime? Data, string NoteInterne, string NoteEsterne, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, CodiceEvento, 0, Data, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", NoteInterne, NoteEsterne, ref rsmess);
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
