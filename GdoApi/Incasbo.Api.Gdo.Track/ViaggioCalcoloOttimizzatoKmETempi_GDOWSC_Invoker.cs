using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker : Api_Invoker
{
	protected static ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker Instance
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
					_instance = new ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker();
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

	protected ViaggioCalcoloOttimizzatoKmETempi_GDOWSC_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string ServiceUser, string ServicePassword, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			ViaggioCalcoloOttimizzatoKmETempi_GDOWSC viaggioCalcoloOttimizzatoKmETempi_GDOWSC = (ViaggioCalcoloOttimizzatoKmETempi_GDOWSC)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("ServiceUser", ServiceUser);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("ServicePassword", ServicePassword);
			val = ((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).Run(ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, int TempoCaricoScarico, string ServiceUser, string ServicePassword, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			ViaggioCalcoloOttimizzatoKmETempi_GDOWSC viaggioCalcoloOttimizzatoKmETempi_GDOWSC = (ViaggioCalcoloOttimizzatoKmETempi_GDOWSC)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("TempoCaricoScarico", TempoCaricoScarico);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("ServiceUser", ServiceUser);
			((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).ParametersIn.Add("ServicePassword", ServicePassword);
			val = ((AppAbstractApi)viaggioCalcoloOttimizzatoKmETempi_GDOWSC).Run(ref rsmess);
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
