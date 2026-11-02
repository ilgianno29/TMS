using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveCrea_Invoker : Api_Invoker
{
	protected static FattureAttiveCrea_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static FattureAttiveCrea_Invoker Instance
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
					_instance = new FattureAttiveCrea_Invoker();
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

	protected FattureAttiveCrea_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Cliente, string Sezionale, DateTime? Data, string TipoPagamento, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			FattureAttiveCrea fattureAttiveCrea = (FattureAttiveCrea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Sezionale", Sezionale);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Data", Data);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
			val = ((AppAbstractApi)fattureAttiveCrea).Run(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	public FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Cliente, string Sezionale, DateTime? Data, string TipoPagamento, ref string IdFattura, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			FattureAttiveCrea fattureAttiveCrea = (FattureAttiveCrea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Sezionale", Sezionale);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Data", Data);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
			val = ((AppAbstractApi)fattureAttiveCrea).Run(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				IdFattura = ((AppAbstractApi)fattureAttiveCrea).ParametersOut["IdFattura"].ToString();
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

	public FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Cliente, string Sezionale, DateTime? Data, string TipoPagamento, DateTime? DataScadenza1, DateTime? DataScadenza2, DateTime? DataScadenza3, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			FattureAttiveCrea fattureAttiveCrea = (FattureAttiveCrea)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Sezionale", Sezionale);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("Data", Data);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("DataScadenza1", DataScadenza1);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("DataScadenza2", DataScadenza2);
			((AppAbstractApi)fattureAttiveCrea).ParametersIn.Add("DataScadenza3", DataScadenza3);
			val = ((AppAbstractApi)fattureAttiveCrea).Run(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
