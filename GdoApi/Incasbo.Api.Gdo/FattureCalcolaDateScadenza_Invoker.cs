using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureCalcolaDateScadenza_Invoker : Api_Invoker
{
	protected static FattureCalcolaDateScadenza_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static FattureCalcolaDateScadenza_Invoker Instance
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
					_instance = new FattureCalcolaDateScadenza_Invoker();
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

	protected FattureCalcolaDateScadenza_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, long IdFattura, string TipoPagamento, DateTime DataFattura, ref DateTime? Data1, ref DateTime? Data2, ref DateTime? Data3, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			FattureCalcolaDateScadenza fattureCalcolaDateScadenza = (FattureCalcolaDateScadenza)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)fattureCalcolaDateScadenza).ParametersIn.Add("IdFattura", IdFattura);
			((AppAbstractApi)fattureCalcolaDateScadenza).ParametersIn.Add("TipoPagamento", TipoPagamento);
			((AppAbstractApi)fattureCalcolaDateScadenza).ParametersIn.Add("DataFattura", DataFattura);
			val = ((AppAbstractApi)fattureCalcolaDateScadenza).Run(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Data1 = (DateTime?)((AppAbstractApi)fattureCalcolaDateScadenza).ParametersOut["Data1"];
				Data2 = (DateTime?)((AppAbstractApi)fattureCalcolaDateScadenza).ParametersOut["Data2"];
				Data3 = (DateTime?)((AppAbstractApi)fattureCalcolaDateScadenza).ParametersOut["Data3"];
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
