using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Giacenza_Chiudi_Invoker : Api_Invoker
{
	protected static Giacenza_Chiudi_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Giacenza_Chiudi_Invoker Instance
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
					_instance = new Giacenza_Chiudi_Invoker();
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

	protected Giacenza_Chiudi_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, int IdGiacenza, string UnibolChiusura, DateTime? DataChiusura, string CausaleChiusura, string NoteChiusura, int? GiorniGiacenza, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			Giacenza_Chiudi giacenza_Chiudi = (Giacenza_Chiudi)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("UnibolChiusura", UnibolChiusura);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("IdGiacenza", IdGiacenza);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("DataChiusura", DataChiusura);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("CausaleChiusura", CausaleChiusura);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("NoteChiusura", NoteChiusura);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("GiorniGiacenza", GiorniGiacenza);
			((AppAbstractApi)giacenza_Chiudi).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)giacenza_Chiudi).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)giacenza_Chiudi).ParametersOut["RetQueryToApply"].ToString();
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
