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

public class SML_CreaSessione_Invoker : Api_Invoker
{
	protected static SML_CreaSessione_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static SML_CreaSessione_Invoker Instance
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
					_instance = new SML_CreaSessione_Invoker();
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

	protected SML_CreaSessione_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, StringCollection IdGiri, StringCollection PCSLiberi, DateTime? Data, string Descrizione, ref int IdSessione, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SML_CreaSessione sML_CreaSessione = (SML_CreaSessione)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("IdGiri", IdGiri);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("PCSLiberi", PCSLiberi);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("Data", Data);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("Descrizione", Descrizione);
			val = ((AppAbstractApi)sML_CreaSessione).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (((AppAbstractApi)sML_CreaSessione).ParametersOut["IdSessione"] != null)
				{
					IdSessione = Conversions.ToInteger(((AppAbstractApi)sML_CreaSessione).ParametersOut["IdSessione"]);
				}
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

	public FXRETURN RunProc(AppApiContext objApiContext, StringCollection IdGiri, StringCollection PCSLiberi, DateTime? Data, string Descrizione, DateTime? OraDisponibilitaInizio, DateTime? OraDisponibilitaFine, ref int IdSessione, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			SML_CreaSessione sML_CreaSessione = (SML_CreaSessione)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("IdGiri", IdGiri);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("PCSLiberi", PCSLiberi);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("Data", Data);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("Descrizione", Descrizione);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("OraDisponibilitaInizio", OraDisponibilitaInizio);
			((AppAbstractApi)sML_CreaSessione).ParametersIn.Add("OraDisponibilitaFine", OraDisponibilitaFine);
			val = ((AppAbstractApi)sML_CreaSessione).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (((AppAbstractApi)sML_CreaSessione).ParametersOut["IdSessione"] != null)
				{
					IdSessione = Conversions.ToInteger(((AppAbstractApi)sML_CreaSessione).ParametersOut["IdSessione"]);
				}
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
