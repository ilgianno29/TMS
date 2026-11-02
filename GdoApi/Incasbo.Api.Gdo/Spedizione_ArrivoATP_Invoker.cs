using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ArrivoATP_Invoker : Api_Invoker
{
	protected static Spedizione_ArrivoATP_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_ArrivoATP_Invoker Instance
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
					_instance = new Spedizione_ArrivoATP_Invoker();
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

	protected Spedizione_ArrivoATP_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, bool ApplyQuery, ref string RetQueryToApply, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_ArrivoATP spedizione_ArrivoATP = (Spedizione_ArrivoATP)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("SequenzaEffettiva", SequenzaEffettiva);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Data", Data);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("NoteEsterne", NoteEsterne);
			((AppAbstractApi)spedizione_ArrivoATP).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)spedizione_ArrivoATP).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)spedizione_ArrivoATP).ParametersOut["RetQueryToApply"].ToString();
				Warning = ((AppAbstractApi)spedizione_ArrivoATP).ParametersOut["Warning"].ToString();
				val2 = (FXRETURN)0;
			}
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, int SequenzaEffettiva, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, bool ApplyQuery, ref string RetQueryToApply, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, "", SequenzaEffettiva, Data, Autista, Motrice, Rimorchio, Contenitore, Terminale, Latitudine, Longitudine, KmGps, DataGPS, KmManuali, Localita, Indirizzo, Cap, Provincia, Nazione, NoteInterne, NoteEsterne, ApplyQuery, ref RetQueryToApply, ref Warning, ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, DateTime? Data, string NoteInterne, string NoteEsterne, bool ApplyQuery, ref string RetQueryToApply, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, Unibol, CodiceEvento, 0, Data, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", NoteInterne, NoteEsterne, ApplyQuery, ref RetQueryToApply, ref Warning, ref rsmess);
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
