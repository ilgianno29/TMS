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

public class UDS_ElencoSpuntaUscitaAnnulla_Invoker : Api_Invoker
{
	protected static UDS_ElencoSpuntaUscitaAnnulla_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static UDS_ElencoSpuntaUscitaAnnulla_Invoker Instance
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
					_instance = new UDS_ElencoSpuntaUscitaAnnulla_Invoker();
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

	protected UDS_ElencoSpuntaUscitaAnnulla_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, string UdsMaster, string IdViaggio, string IdViaggioLinea, ref List<UDS> ListOfUDS, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			UDS_ElencoSpuntaUscitaAnnulla uDS_ElencoSpuntaUscitaAnnulla = (UDS_ElencoSpuntaUscitaAnnulla)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersIn.Add("Codice", Codice);
			((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersIn.Add("UdsMaster", UdsMaster);
			((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersIn.Add("IdViaggioLinea", IdViaggioLinea);
			val = ((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ListOfUDS = (List<UDS>)((AppAbstractApi)uDS_ElencoSpuntaUscitaAnnulla).ParametersOut["ListOfUDS"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string IdViaggio, ref List<UDS> ListOfUDS, ref string rsmess)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return RunProc(objApiContext, Codice, "", "", IdViaggio, "", ref ListOfUDS, ref rsmess);
	}
}
