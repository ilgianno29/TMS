using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class ViaggioRicalcolaKmETempi_GDOWSC_Invoker : Api_Invoker
{
	protected static ViaggioRicalcolaKmETempi_GDOWSC_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static ViaggioRicalcolaKmETempi_GDOWSC_Invoker Instance
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
					_instance = new ViaggioRicalcolaKmETempi_GDOWSC_Invoker();
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

	protected ViaggioRicalcolaKmETempi_GDOWSC_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, Dictionary<string, string> RoutingOptions, string ServiceUser, string ServicePassword, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			ViaggioRicalcolaKmETempi_GDOWSC viaggioRicalcolaKmETempi_GDOWSC = (ViaggioRicalcolaKmETempi_GDOWSC)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("RoutingOptions", RoutingOptions);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("ServiceUser", ServiceUser);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("ServicePassword", ServicePassword);
			val = ((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).Run(ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, Dictionary<string, string> RoutingOptions, int TempoCaricoScarico, string ServiceUser, string ServicePassword, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			ViaggioRicalcolaKmETempi_GDOWSC viaggioRicalcolaKmETempi_GDOWSC = (ViaggioRicalcolaKmETempi_GDOWSC)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("RoutingOptions", RoutingOptions);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("TempoCaricoScarico", TempoCaricoScarico);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("ServiceUser", ServiceUser);
			((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).ParametersIn.Add("ServicePassword", ServicePassword);
			val = ((AppAbstractApi)viaggioRicalcolaKmETempi_GDOWSC).Run(ref rsmess);
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
