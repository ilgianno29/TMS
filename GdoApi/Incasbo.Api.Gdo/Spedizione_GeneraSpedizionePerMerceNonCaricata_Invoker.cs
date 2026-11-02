using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker : Api_Invoker
{
	protected static Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker Instance
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
					_instance = new Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker();
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

	protected Spedizione_GeneraSpedizionePerMerceNonCaricata_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_GeneraSpedizionePerMerceNonCaricata spedizione_GeneraSpedizionePerMerceNonCaricata = (Spedizione_GeneraSpedizionePerMerceNonCaricata)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_GeneraSpedizionePerMerceNonCaricata).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_GeneraSpedizionePerMerceNonCaricata).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)spedizione_GeneraSpedizionePerMerceNonCaricata).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)spedizione_GeneraSpedizionePerMerceNonCaricata).ParametersOut["RetQueryToApply"].ToString();
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
