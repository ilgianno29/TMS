using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Simulation_SpedizioniAgganciaTariffaPassiva_Invoker : Api_Invoker
{
	protected static Simulation_SpedizioniAgganciaTariffaPassiva_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Simulation_SpedizioniAgganciaTariffaPassiva_Invoker Instance
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
					_instance = new Simulation_SpedizioniAgganciaTariffaPassiva_Invoker();
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

	protected Simulation_SpedizioniAgganciaTariffaPassiva_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, StringCollection ListOfCorrispondenti, ref Dictionary<string, Simulation_Result> SimulationResult, ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			Simulation_SpedizioniAgganciaTariffaPassiva simulation_SpedizioniAgganciaTariffaPassiva = (Simulation_SpedizioniAgganciaTariffaPassiva)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).ParametersIn.Add("ListOfCorrispondenti", ListOfCorrispondenti);
			((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).ParametersIn.Add("Unibol", Unibol);
			val = ((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).Run(ref rsmess);
			if (((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).ParametersOut.ContainsKey("_Warning"))
			{
				Warning = ((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).ParametersOut["_Warning"].ToString();
			}
			else
			{
				Warning = "";
			}
			SimulationResult = (Dictionary<string, Simulation_Result>)((AppAbstractApi)simulation_SpedizioniAgganciaTariffaPassiva).ParametersOut["SimulationResult"];
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
