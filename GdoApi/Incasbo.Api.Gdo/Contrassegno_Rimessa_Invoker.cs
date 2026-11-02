using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Rimessa_Invoker : Api_Invoker
{
	protected static Contrassegno_Rimessa_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Contrassegno_Rimessa_Invoker Instance
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
					_instance = new Contrassegno_Rimessa_Invoker();
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

	protected Contrassegno_Rimessa_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, List<int> IdContrassegni, DateTime? DataRimessa, string Cliente, string Note1, string Note2, string Note3, ref int? IdRimessa, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			Contrassegno_Rimessa contrassegno_Rimessa = (Contrassegno_Rimessa)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("IdContrassegni", IdContrassegni);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("DataRimessa", DataRimessa);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)contrassegno_Rimessa).ParametersIn.Add("Note3", Note3);
			val = ((AppAbstractApi)contrassegno_Rimessa).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdRimessa = (int?)((AppAbstractApi)contrassegno_Rimessa).ParametersOut["IdRimessa"];
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
