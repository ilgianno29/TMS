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

public class Spedizioni_DeterminaElencoCorrispondentiDaSpedizione_Invoker : Api_Invoker
{
	protected static Spedizioni_DeterminaElencoCorrispondentiDaSpedizione_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizioni_DeterminaElencoCorrispondentiDaSpedizione_Invoker Instance
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
					_instance = new Spedizioni_DeterminaElencoCorrispondentiDaSpedizione_Invoker();
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

	protected Spedizioni_DeterminaElencoCorrispondentiDaSpedizione_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string unibol, ref StringCollection ListOfCorrispondenti, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizioni_DeterminaElencoCorrispondentiDaSpedizione spedizioni_DeterminaElencoCorrispondentiDaSpedizione = (Spedizioni_DeterminaElencoCorrispondentiDaSpedizione)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizioni_DeterminaElencoCorrispondentiDaSpedizione).ParametersIn.Add("unibol", unibol);
			val = ((AppAbstractApi)spedizioni_DeterminaElencoCorrispondentiDaSpedizione).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ListOfCorrispondenti = (StringCollection)((AppAbstractApi)spedizioni_DeterminaElencoCorrispondentiDaSpedizione).ParametersOut["ListOfCorrispondenti"];
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
