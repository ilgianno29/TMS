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

public class Viaggio_InserisciConSpedizioni_Invoker : Api_Invoker
{
	protected static Viaggio_InserisciConSpedizioni_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Viaggio_InserisciConSpedizioni_Invoker Instance
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
					_instance = new Viaggio_InserisciConSpedizioni_Invoker();
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

	protected Viaggio_InserisciConSpedizioni_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, ref Viaggio Viaggio, ref List<string> ListOfUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_InserisciConSpedizioni viaggio_InserisciConSpedizioni = (Viaggio_InserisciConSpedizioni)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("Viaggio", Viaggio);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("ElencoUnibol", ListOfUnibol);
			val = ((AppAbstractApi)viaggio_InserisciConSpedizioni).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Viaggio = (Viaggio)((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersOut["Viaggio"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, ref Viaggio Viaggio, ref List<string> ListOfUnibol, string IdViaggioLinea, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_InserisciConSpedizioni viaggio_InserisciConSpedizioni = (Viaggio_InserisciConSpedizioni)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("Viaggio", Viaggio);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("ElencoUnibol", ListOfUnibol);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("IdViaggioLinea", IdViaggioLinea);
			val = ((AppAbstractApi)viaggio_InserisciConSpedizioni).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Viaggio = (Viaggio)((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersOut["Viaggio"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, ref Viaggio Viaggio, ref List<string> ListOfUnibol, string IdViaggioLinea, DateTime? DataEvento, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_InserisciConSpedizioni viaggio_InserisciConSpedizioni = (Viaggio_InserisciConSpedizioni)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("Viaggio", Viaggio);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("ElencoUnibol", ListOfUnibol);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("IdViaggioLinea", IdViaggioLinea);
			((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersIn.Add("DataEvento", DataEvento);
			val = ((AppAbstractApi)viaggio_InserisciConSpedizioni).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Viaggio = (Viaggio)((AppAbstractApi)viaggio_InserisciConSpedizioni).ParametersOut["Viaggio"];
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
