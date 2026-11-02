using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker : Api_Invoker
{
	protected static SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker Instance
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
					_instance = new SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker();
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

	protected SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker()
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
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SpedizioniAgganciaTariffaAttivaRaggruppata spedizioniAgganciaTariffaAttivaRaggruppata = (SpedizioniAgganciaTariffaAttivaRaggruppata)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersIn.Add("IdViaggio", IdViaggio);
			val = ((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersOut["_Warning"].ToString();
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string Cliente, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SpedizioniAgganciaTariffaAttivaRaggruppata spedizioniAgganciaTariffaAttivaRaggruppata = (SpedizioniAgganciaTariffaAttivaRaggruppata)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersIn.Add("Cliente", Cliente);
			val = ((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).Run(ref rsmess);
			if (((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)spedizioniAgganciaTariffaAttivaRaggruppata).ParametersOut["_Warning"].ToString();
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
