using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contestazione_Crea_Invoker : Api_Invoker
{
	protected static Contestazione_Crea_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Contestazione_Crea_Invoker Instance
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
					_instance = new Contestazione_Crea_Invoker();
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

	protected Contestazione_Crea_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string NumeroDocumento, DateTime? DataDocumento, string NoteDocumento, string TipoContestazione, DateTime? DataApertura, string Note1, string Note2, string Note3, bool ApplyQuery, ref int? IdContestazione, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Contestazione_Crea contestazione_Crea = (Contestazione_Crea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("DataApertura", DataApertura);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("NumeroDocumento", NumeroDocumento);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("DataDocumento", DataDocumento);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("NoteDocumento", NoteDocumento);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("TipoContestazione", TipoContestazione);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("Note1", Note1);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("Note2", Note2);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("Note3", Note3);
			((AppAbstractApi)contestazione_Crea).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)contestazione_Crea).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdContestazione = Conversions.ToInteger(((AppAbstractApi)contestazione_Crea).ParametersOut["IdContestazione"]);
				RetQueryToApply = ((AppAbstractApi)contestazione_Crea).ParametersOut["RetQueryToApply"].ToString();
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
