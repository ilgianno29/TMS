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

public class Viaggi_DeterminaVettoreMigliore_Invoker : Api_Invoker
{
	protected static Viaggi_DeterminaVettoreMigliore_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Viaggi_DeterminaVettoreMigliore_Invoker Instance
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
					_instance = new Viaggi_DeterminaVettoreMigliore_Invoker();
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

	protected Viaggi_DeterminaVettoreMigliore_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, StringCollection ListOfVettori, ref string VettoreMigliore, ref List<Simulation_Result> VettoriMigliori, ref string rsmess)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return RunProc(objApiContext, IdViaggio, ListOfVettori, doUpdate: false, ref VettoreMigliore, ref VettoriMigliori, ref rsmess);
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, StringCollection ListOfVettori, bool doUpdate, ref string VettoreMigliore, ref List<Simulation_Result> VettoriMigliori, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggi_DeterminaVettoreMigliore viaggi_DeterminaVettoreMigliore = (Viaggi_DeterminaVettoreMigliore)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggi_DeterminaVettoreMigliore).ParametersIn.Add("ListOfVettori", ListOfVettori);
			((AppAbstractApi)viaggi_DeterminaVettoreMigliore).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggi_DeterminaVettoreMigliore).ParametersIn.Add("doUpdate", doUpdate);
			val = ((AppAbstractApi)viaggi_DeterminaVettoreMigliore).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				VettoreMigliore = ((AppAbstractApi)viaggi_DeterminaVettoreMigliore).ParametersOut["VettoreMigliore"].ToString();
				VettoriMigliori = (List<Simulation_Result>)((AppAbstractApi)viaggi_DeterminaVettoreMigliore).ParametersOut["ListOfVettoriMigliori"];
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
