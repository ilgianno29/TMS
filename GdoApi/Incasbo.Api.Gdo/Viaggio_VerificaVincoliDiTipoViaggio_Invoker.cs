using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_VerificaVincoliDiTipoViaggio_Invoker : Api_Invoker
{
	protected static Viaggio_VerificaVincoliDiTipoViaggio_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Viaggio_VerificaVincoliDiTipoViaggio_Invoker Instance
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
					_instance = new Viaggio_VerificaVincoliDiTipoViaggio_Invoker();
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

	protected Viaggio_VerificaVincoliDiTipoViaggio_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, bool CheckCampiObbligatori, bool CheckSpedizioniObbligatorie, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_VerificaVincoliDiTipoViaggio viaggio_VerificaVincoliDiTipoViaggio = (Viaggio_VerificaVincoliDiTipoViaggio)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckCampiObbligatori", CheckCampiObbligatori);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckCoerenzaCampiSpedizioni", true);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckSpedizioniObbligatorie", CheckSpedizioniObbligatorie);
			val = ((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).Run(ref rsmess);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Viaggio_VerificaVincoliDiTipoViaggio viaggio_VerificaVincoliDiTipoViaggio = (Viaggio_VerificaVincoliDiTipoViaggio)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckCampiObbligatori", true);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckCoerenzaCampiSpedizioni", true);
			((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).ParametersIn.Add("CheckSpedizioniObbligatorie", true);
			val = ((AppAbstractApi)viaggio_VerificaVincoliDiTipoViaggio).Run(ref rsmess);
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
