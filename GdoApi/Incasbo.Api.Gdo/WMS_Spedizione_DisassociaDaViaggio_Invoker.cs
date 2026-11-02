using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class WMS_Spedizione_DisassociaDaViaggio_Invoker : Api_Invoker
{
	protected static WMS_Spedizione_DisassociaDaViaggio_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static WMS_Spedizione_DisassociaDaViaggio_Invoker Instance
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
					_instance = new WMS_Spedizione_DisassociaDaViaggio_Invoker();
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

	protected WMS_Spedizione_DisassociaDaViaggio_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string IdViaggio, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			WMS_Spedizione_DisassociaDaViaggio wMS_Spedizione_DisassociaDaViaggio = (WMS_Spedizione_DisassociaDaViaggio)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)wMS_Spedizione_DisassociaDaViaggio).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)wMS_Spedizione_DisassociaDaViaggio).ParametersIn.Add("IdViaggio", IdViaggio);
			val = wMS_Spedizione_DisassociaDaViaggio.Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
