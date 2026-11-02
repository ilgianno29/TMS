using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Crea_Invoker : Api_Invoker
{
	protected static Contrassegno_Crea_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Contrassegno_Crea_Invoker Instance
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
					_instance = new Contrassegno_Crea_Invoker();
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

	protected Contrassegno_Crea_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, DateTime? Data, string Note1, string Note2, string Note3, bool ApplyQuery, ref int? IdContrassegno, ref string RetQueryToApply, ref string rsmess)
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
			Contrassegno_Crea contrassegno_Crea = (Contrassegno_Crea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("Data", Data);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("Note3", Note3);
			((AppAbstractApi)contrassegno_Crea).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)contrassegno_Crea).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdContrassegno = Conversions.ToInteger(((AppAbstractApi)contrassegno_Crea).ParametersOut["IdContrassegno"]);
				RetQueryToApply = ((AppAbstractApi)contrassegno_Crea).ParametersOut["RetQueryToApply"].ToString();
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
