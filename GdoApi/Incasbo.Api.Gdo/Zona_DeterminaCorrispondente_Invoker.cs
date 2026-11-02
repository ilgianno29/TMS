using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Zona_DeterminaCorrispondente_Invoker : Api_Invoker
{
	protected static Zona_DeterminaCorrispondente_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Zona_DeterminaCorrispondente_Invoker Instance
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
					_instance = new Zona_DeterminaCorrispondente_Invoker();
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

	protected Zona_DeterminaCorrispondente_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string ZonaSpedizione, string TipoSpedizione, string TipoMerce, decimal SogliaPeso, decimal SogliaVolume, ref string Corrispondente, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Zona_DeterminaCorrispondente zona_DeterminaCorrispondente = (Zona_DeterminaCorrispondente)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)zona_DeterminaCorrispondente).ParametersIn.Add("ZonaSpedizione", ZonaSpedizione);
			((AppAbstractApi)zona_DeterminaCorrispondente).ParametersIn.Add("TipoSpedizione", TipoSpedizione);
			((AppAbstractApi)zona_DeterminaCorrispondente).ParametersIn.Add("TipoMerce", TipoMerce);
			((AppAbstractApi)zona_DeterminaCorrispondente).ParametersIn.Add("SogliaPeso", SogliaPeso);
			((AppAbstractApi)zona_DeterminaCorrispondente).ParametersIn.Add("SogliaVolume", SogliaVolume);
			val = ((AppAbstractApi)zona_DeterminaCorrispondente).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Corrispondente = ((AppAbstractApi)zona_DeterminaCorrispondente).ParametersOut["Corrispondente"].ToString();
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
