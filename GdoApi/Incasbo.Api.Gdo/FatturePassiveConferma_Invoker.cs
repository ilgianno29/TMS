using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FatturePassiveConferma_Invoker : Api_Invoker
{
	protected static FatturePassiveConferma_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static FatturePassiveConferma_Invoker Instance
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
					_instance = new FatturePassiveConferma_Invoker();
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

	protected FatturePassiveConferma_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, long IdFattura, string Sezionale, DateTime Data, ref long? Numero, ref bool Contabilizza, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string localPath = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
			FatturePassiveConferma fatturePassiveConferma = (FatturePassiveConferma)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)fatturePassiveConferma).ParametersIn.Add("IdFattura", IdFattura);
			((AppAbstractApi)fatturePassiveConferma).ParametersIn.Add("Sezionale", Sezionale);
			((AppAbstractApi)fatturePassiveConferma).ParametersIn.Add("Data", Data);
			((AppAbstractApi)fatturePassiveConferma).ParametersIn.Add("Contabilizza", Contabilizza);
			if (Numero.HasValue && Numero.Value != 0)
			{
				((AppAbstractApi)fatturePassiveConferma).ParametersIn.Add("Numero", Numero);
			}
			val = ((AppAbstractApi)fatturePassiveConferma).Run(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Numero = (long?)((AppAbstractApi)fatturePassiveConferma).ParametersOut["Numero"];
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}
}
