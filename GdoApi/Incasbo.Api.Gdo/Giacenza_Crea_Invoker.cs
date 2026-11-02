using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Giacenza_Crea_Invoker : Api_Invoker
{
	protected static Giacenza_Crea_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Giacenza_Crea_Invoker Instance
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
					_instance = new Giacenza_Crea_Invoker();
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

	protected Giacenza_Crea_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, DateTime? DataApertura, string Note1, string Note2, string Note3, Giacenza Giacenza, bool ApplyQuery, ref int? IdGiacenza, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Giacenza_Crea giacenza_Crea = (Giacenza_Crea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Data", DataApertura);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note3", Note3);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Giacenza", Giacenza);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)giacenza_Crea).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdGiacenza = Conversions.ToInteger(((AppAbstractApi)giacenza_Crea).ParametersOut["IdGiacenza"]);
				RetQueryToApply = ((AppAbstractApi)giacenza_Crea).ParametersOut["RetQueryToApply"].ToString();
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, DateTime? DataApertura, string Note1, string Note2, string Note3, bool ApplyQuery, ref int? IdGiacenza, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Giacenza_Crea giacenza_Crea = (Giacenza_Crea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("DataApertura", DataApertura);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("Note3", Note3);
			((AppAbstractApi)giacenza_Crea).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)giacenza_Crea).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdGiacenza = Conversions.ToInteger(((AppAbstractApi)giacenza_Crea).ParametersOut["IdGiacenza"]);
				RetQueryToApply = ((AppAbstractApi)giacenza_Crea).ParametersOut["RetQueryToApply"].ToString();
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
