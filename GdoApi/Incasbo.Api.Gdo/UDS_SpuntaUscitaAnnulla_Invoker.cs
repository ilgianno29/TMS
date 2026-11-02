using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_SpuntaUscitaAnnulla_Invoker : Api_Invoker
{
	protected static UDS_SpuntaUscitaAnnulla_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static UDS_SpuntaUscitaAnnulla_Invoker Instance
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
					_instance = new UDS_SpuntaUscitaAnnulla_Invoker();
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

	protected UDS_SpuntaUscitaAnnulla_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, string IdViaggio, bool ApplyQuery, ref string RetQueryToApply, ref UDS UDS, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			UDS_SpuntaUscitaAnnulla uDS_SpuntaUscitaAnnulla = (UDS_SpuntaUscitaAnnulla)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersIn.Add("Codice", Codice);
			((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)uDS_SpuntaUscitaAnnulla).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersOut["RetQueryToApply"].ToString();
				UDS = (UDS)((AppAbstractApi)uDS_SpuntaUscitaAnnulla).ParametersOut["UDS"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, ref string rsmess)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		string RetQueryToApply = "";
		UDS UDS = null;
		return RunProc(objApiContext, Codice, Unibol, "", ApplyQuery: true, ref RetQueryToApply, ref UDS, ref rsmess);
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, ref string rsmess)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		string RetQueryToApply = "";
		UDS UDS = null;
		return RunProc(objApiContext, "", "", IdViaggio, ApplyQuery: true, ref RetQueryToApply, ref UDS, ref rsmess);
	}
}
