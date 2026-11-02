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

public class SpedizioniAgganciaTariffaPassiva_Invoker : Api_Invoker
{
	protected static SpedizioniAgganciaTariffaPassiva_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static SpedizioniAgganciaTariffaPassiva_Invoker Instance
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
					_instance = new SpedizioniAgganciaTariffaPassiva_Invoker();
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

	protected SpedizioniAgganciaTariffaPassiva_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, StringCollection ListOfUnibol, ref string Warning, ref string rsmess)
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
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SpedizioniAgganciaTariffaPassiva spedizioniAgganciaTariffaPassiva = (SpedizioniAgganciaTariffaPassiva)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersIn.Add("ListOfUnibol", ListOfUnibol);
			val = ((AppAbstractApi)spedizioniAgganciaTariffaPassiva).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersOut["_Warning"].ToString();
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SpedizioniAgganciaTariffaPassiva spedizioniAgganciaTariffaPassiva = (SpedizioniAgganciaTariffaPassiva)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			StringCollection stringCollection = new StringCollection();
			stringCollection.Add(Unibol);
			((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersIn.Add("ListOfUnibol", stringCollection);
			val = ((AppAbstractApi)spedizioniAgganciaTariffaPassiva).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffaPassiva).ParametersOut["_Warning"].ToString();
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
