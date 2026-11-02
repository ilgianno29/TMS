using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Incasbo.xRoute;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackCalcolaPercorsoViaggio_Invoker : Api_Invoker
{
	protected static DelsyTrackCalcolaPercorsoViaggio_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static DelsyTrackCalcolaPercorsoViaggio_Invoker Instance
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
					_instance = new DelsyTrackCalcolaPercorsoViaggio_Invoker();
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

	protected DelsyTrackCalcolaPercorsoViaggio_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, XRouteWSClient inXRouteWS, Incasbo.Model.Map.Viaggio inViaggio, bool inCheckTruckAttributes, bool inCheckEnableRoadEditor, string Tipologia, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			DelsyTrackCalcolaPercorsoViaggio delsyTrackCalcolaPercorsoViaggio = (DelsyTrackCalcolaPercorsoViaggio)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).ParametersIn.Add("inXRouteWS", inXRouteWS);
			((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).ParametersIn.Add("inViaggio", inViaggio);
			((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).ParametersIn.Add("Tipologia", Tipologia);
			((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).ParametersIn.Add("inCheckTruckAttributes", inCheckTruckAttributes);
			((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).ParametersIn.Add("inCheckEnableRoadEditor", inCheckEnableRoadEditor);
			val = ((AppAbstractApi)delsyTrackCalcolaPercorsoViaggio).Run(ref rsmess);
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
