using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker : Api_Invoker
{
	protected static SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker Instance
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
					_instance = new SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker();
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

	protected SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			SpedizioniAgganciaTariffaPassivaRaggruppata spedizioniAgganciaTariffaPassivaRaggruppata = (SpedizioniAgganciaTariffaPassivaRaggruppata)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioniAgganciaTariffaPassivaRaggruppata).ParametersIn.Add("IdViaggio", IdViaggio);
			val = ((AppAbstractApi)spedizioniAgganciaTariffaPassivaRaggruppata).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffaPassivaRaggruppata).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffaPassivaRaggruppata).ParametersOut["_Warning"].ToString();
			}
			else
			{
				Warning = "";
			}
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, bool TariffaAttiva, bool TariffaPassiva, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			SpedizioniAgganciaTariffa spedizioniAgganciaTariffa = (SpedizioniAgganciaTariffa)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			StringCollection stringCollection = new StringCollection();
			stringCollection.Add(Unibol);
			((AppAbstractApi)spedizioniAgganciaTariffa).ParametersIn.Add("ListOfUnibol", stringCollection);
			((AppAbstractApi)spedizioniAgganciaTariffa).ParametersIn.Add("TariffaAttiva", TariffaAttiva);
			((AppAbstractApi)spedizioniAgganciaTariffa).ParametersIn.Add("TariffaPassiva", TariffaPassiva);
			val = ((AppAbstractApi)spedizioniAgganciaTariffa).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffa).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffa).ParametersOut["_Warning"].ToString();
			}
			else
			{
				Warning = "";
			}
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
