using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackGeneraViaggi_Invoker : Api_Invoker
{
	protected static DelsyTrackGeneraViaggi_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static DelsyTrackGeneraViaggi_Invoker Instance
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
					_instance = new DelsyTrackGeneraViaggi_Invoker();
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

	protected DelsyTrackGeneraViaggi_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, TipologiaMappa Tipologia, string Filtro, bool SoloEffettivi, ref List<Incasbo.Model.Map.Viaggio> ElencoViaggi, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			DelsyTrackGeneraViaggi delsyTrackGeneraViaggi = (DelsyTrackGeneraViaggi)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)delsyTrackGeneraViaggi).ParametersIn.Add("Filtro", Filtro);
			((AppAbstractApi)delsyTrackGeneraViaggi).ParametersIn.Add("SoloEffettivi", SoloEffettivi);
			((AppAbstractApi)delsyTrackGeneraViaggi).ParametersIn.Add("Tipologia", Tipologia);
			val = ((AppAbstractApi)delsyTrackGeneraViaggi).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ElencoViaggi = (List<Incasbo.Model.Map.Viaggio>)((AppAbstractApi)delsyTrackGeneraViaggi).ParametersOut["Viaggi"];
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
