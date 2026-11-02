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

public class UDS_ElencoSpuntaUscita_Invoker : Api_Invoker
{
	protected static UDS_ElencoSpuntaUscita_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static UDS_ElencoSpuntaUscita_Invoker Instance
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
					_instance = new UDS_ElencoSpuntaUscita_Invoker();
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

	protected UDS_ElencoSpuntaUscita_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string Unibol, string UdsMaster, string IdViaggio, string IdViaggioLinea, string UtenteSpunta, DateTime? DataSpunta, bool AssociaViaggio, ref List<UDS> ListOfUDS, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			UDS_ElencoSpuntaUscita uDS_ElencoSpuntaUscita = (UDS_ElencoSpuntaUscita)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("Codice", Codice);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("UdsMaster", UdsMaster);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("IdViaggioLinea", IdViaggioLinea);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("UtenteSpunta", UtenteSpunta);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("DataSpunta", DataSpunta);
			((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersIn.Add("AssociaViaggio", AssociaViaggio);
			val = ((AppAbstractApi)uDS_ElencoSpuntaUscita).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				ListOfUDS = (List<UDS>)((AppAbstractApi)uDS_ElencoSpuntaUscita).ParametersOut["ListOfUDS"];
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

	public FXRETURN RunProc(AppApiContext objApiContext, string Codice, string IdViaggioLinea, string UtenteSpunta, DateTime? DataSpunta, ref List<UDS> ListOfUDS, ref string rsmess)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		return RunProc(objApiContext, Codice, "", "", "", IdViaggioLinea, UtenteSpunta, DataSpunta, AssociaViaggio: false, ref ListOfUDS, ref rsmess);
	}
}
