using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_SpuntaUscita_Invoker : Api_Invoker
{
	protected static UDS_SpuntaUscita_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static UDS_SpuntaUscita_Invoker Instance
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
					_instance = new UDS_SpuntaUscita_Invoker();
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

	protected UDS_SpuntaUscita_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, string UtenteSpunta, DateTime? DataSpunta, bool ApplyQuery, ref string RetQueryToApply, ref UDS UDS, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			UDS_SpuntaUscita uDS_SpuntaUscita = (UDS_SpuntaUscita)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)uDS_SpuntaUscita).ParametersIn.Add("Codice", Codice);
			((AppAbstractApi)uDS_SpuntaUscita).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)uDS_SpuntaUscita).ParametersIn.Add("UtenteSpunta", UtenteSpunta);
			((AppAbstractApi)uDS_SpuntaUscita).ParametersIn.Add("DataSpunta", DataSpunta);
			((AppAbstractApi)uDS_SpuntaUscita).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)uDS_SpuntaUscita).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)uDS_SpuntaUscita).ParametersOut["RetQueryToApply"].ToString();
				UDS = (UDS)((AppAbstractApi)uDS_SpuntaUscita).ParametersOut["UDS"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, string UtenteSpunta, DateTime? DataSpunta, ref string rsmess)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		string RetQueryToApply = "";
		UDS UDS = null;
		return RunProc(objApiContext, Codice, Unibol, UtenteSpunta, DataSpunta, ApplyQuery: true, ref RetQueryToApply, ref UDS, ref rsmess);
	}
}
