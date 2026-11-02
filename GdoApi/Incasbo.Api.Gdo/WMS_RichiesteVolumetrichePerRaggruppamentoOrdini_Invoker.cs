using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker : Api_Invoker
{
	protected static WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker Instance
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
					_instance = new WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker();
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

	protected WMS_RichiesteVolumetrichePerRaggruppamentoOrdini_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, StringCollection Unibols, string CodiceRaggruppamento, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			WMS_RichiesteVolumetrichePerRaggruppamentoOrdini wMS_RichiesteVolumetrichePerRaggruppamentoOrdini = (WMS_RichiesteVolumetrichePerRaggruppamentoOrdini)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)wMS_RichiesteVolumetrichePerRaggruppamentoOrdini).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)wMS_RichiesteVolumetrichePerRaggruppamentoOrdini).ParametersIn.Add("CodiceRaggruppamento", CodiceRaggruppamento);
			((AppAbstractApi)wMS_RichiesteVolumetrichePerRaggruppamentoOrdini).ParametersIn.Add("Unibols", Unibols);
			val = wMS_RichiesteVolumetrichePerRaggruppamentoOrdini.Run(ref rsmess);
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
