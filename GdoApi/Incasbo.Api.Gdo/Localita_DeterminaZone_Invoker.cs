using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Localita_DeterminaZone_Invoker : Api_Invoker
{
	protected static Localita_DeterminaZone_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Localita_DeterminaZone_Invoker Instance
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
					_instance = new Localita_DeterminaZone_Invoker();
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

	protected Localita_DeterminaZone_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string TipoMerce, string Localita, string Provincia, string Cap, string Nazione, ref string ZonaSpedizione, ref string ZonaTariffaAttiva, ref string ZonaTariffaPassiva, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Localita_DeterminaZone localita_DeterminaZone = (Localita_DeterminaZone)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)localita_DeterminaZone).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)localita_DeterminaZone).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)localita_DeterminaZone).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)localita_DeterminaZone).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)localita_DeterminaZone).ParametersIn.Add("Nazione", Nazione);
			val = ((AppAbstractApi)localita_DeterminaZone).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ZonaSpedizione = ((AppAbstractApi)localita_DeterminaZone).ParametersOut["ZonaSpedizione"].ToString();
				ZonaTariffaAttiva = ((AppAbstractApi)localita_DeterminaZone).ParametersOut["ZonaTariffaAttiva"].ToString();
				ZonaTariffaPassiva = ((AppAbstractApi)localita_DeterminaZone).ParametersOut["ZonaTariffaPassiva"].ToString();
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
