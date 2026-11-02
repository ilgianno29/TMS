using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Sosta_Fine_Invoker : Api_Invoker
{
	protected static Viaggio_Sosta_Fine_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Viaggio_Sosta_Fine_Invoker Instance
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
					_instance = new Viaggio_Sosta_Fine_Invoker();
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

	protected Viaggio_Sosta_Fine_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val = RunProc(objApiContext, IdViaggio, DateAndTime.Now, "", "", "", "", "", "", "", null, null, null, "", "", "", "", "", ApplyQuery, ref RetQueryToApply, ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_Sosta_Fine viaggio_Sosta_Fine = (Viaggio_Sosta_Fine)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Data", Data);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)viaggio_Sosta_Fine).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)viaggio_Sosta_Fine).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)viaggio_Sosta_Fine).ParametersOut["RetQueryToApply"].ToString();
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
}
