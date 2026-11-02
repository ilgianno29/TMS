using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_DocumentoInserisci_Invoker : Api_Invoker
{
	protected static Spedizione_DocumentoInserisci_Invoker _instance;

	protected static readonly object _lock = RuntimeHelpers.GetObjectValue(new object());

	public static Spedizione_DocumentoInserisci_Invoker Instance
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
					_instance = new Spedizione_DocumentoInserisci_Invoker();
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

	protected Spedizione_DocumentoInserisci_Invoker()
	{
	}

	public FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string TipoDocumento, string FileName, string NumeroDocumento, DateTime? DataDocumento, string Note, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			string localPath = AssemblyLocation.DirectoryOf(Assembly.GetExecutingAssembly());
			Spedizione_DocumentoInserisci spedizione_DocumentoInserisci = (Spedizione_DocumentoInserisci)(object)InstantiateApi(ref objApiContext, ClassName, ClassNameCustom);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("FileName", FileName);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("TipoDocumento", TipoDocumento);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("NumeroDocumento", NumeroDocumento);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("DataDocumento", DataDocumento);
			((AppAbstractApi)spedizione_DocumentoInserisci).ParametersIn.Add("Note", Note);
			val = ((AppAbstractApi)spedizione_DocumentoInserisci).Run(ref rsmess);
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
