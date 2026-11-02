using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveGeneraDettagli_Invoker : Api_Invoker
{
	protected static FattureAttiveGeneraDettagli_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static FattureAttiveGeneraDettagli_Invoker Instance
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
					_instance = new FattureAttiveGeneraDettagli_Invoker();
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

	protected FattureAttiveGeneraDettagli_Invoker()
	{
	}

	public FXRETURN CreateAPI(AppApiContext objApiContext, ref FattureAttiveGeneraDettagli APIInstance, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			APIInstance = null;
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			FattureAttiveGeneraDettagli fattureAttiveGeneraDettagli = (FattureAttiveGeneraDettagli)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			APIInstance = fattureAttiveGeneraDettagli;
			val2 = (FXRETURN)0;
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
