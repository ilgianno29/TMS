using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

public class WMSMessage_PrepareData_Invoker : Api_Invoker
{
	protected static WMSMessage_PrepareData_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static WMSMessage_PrepareData_Invoker Instance
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
					_instance = new WMSMessage_PrepareData_Invoker();
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

	protected WMSMessage_PrepareData_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, WMSMessageType TipoMessaggio, object Param1, object Param2, object Param3, object Param4, object Param5, object Param6, object Param7, object Param8, object Param9, object Param10, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			WMSAbstractApi wMSAbstractApi = (WMSAbstractApi)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("TipoMessaggio", TipoMessaggio);
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param1", RuntimeHelpers.GetObjectValue(Param1));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param2", RuntimeHelpers.GetObjectValue(Param2));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param3", RuntimeHelpers.GetObjectValue(Param3));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param4", RuntimeHelpers.GetObjectValue(Param4));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param5", RuntimeHelpers.GetObjectValue(Param5));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param6", RuntimeHelpers.GetObjectValue(Param6));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param7", RuntimeHelpers.GetObjectValue(Param7));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param8", RuntimeHelpers.GetObjectValue(Param8));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param9", RuntimeHelpers.GetObjectValue(Param9));
			((AppAbstractApi)wMSAbstractApi).ParametersIn.Add("Param10", RuntimeHelpers.GetObjectValue(Param10));
			val = ((AppAbstractApi)wMSAbstractApi).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMSAbstractApi).ParametersOut["DataInfo"];
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
