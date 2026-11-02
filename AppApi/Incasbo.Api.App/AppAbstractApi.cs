using System;
using System.Collections.Generic;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public abstract class AppAbstractApi : AppBaseClass
{
	public delegate void BeforeRunEventEventHandler(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref modGeneral.FXRETURN nRes, ref string rsmess);

	public delegate void AfterRunEventEventHandler(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref modGeneral.FXRETURN nRes, ref string rsmess);

	public delegate void AfterCheckDataEventEventHandler(ref Dictionary<string, object> ParametersIn, ref Dictionary<string, object> ParametersOut, ref modGeneral.FXRETURN nRes, ref string rsmess);

	protected Dictionary<string, object> _ParametersIn;

	protected Dictionary<string, object> _ParametersOut;

	protected string _Warning;

	public Dictionary<string, object> ParametersIn => _ParametersIn;

	public Dictionary<string, object> ParametersOut => _ParametersOut;

	public bool TransactionManage { get; set; }

	public event BeforeRunEventEventHandler BeforeRunEvent;

	public event AfterRunEventEventHandler AfterRunEvent;

	public event AfterCheckDataEventEventHandler AfterCheckDataEvent;

	public AppAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ParametersIn = new Dictionary<string, object>(new ApiParametersComparer());
		_ParametersOut = new Dictionary<string, object>(new ApiParametersComparer());
		_Warning = null;
		bool transactionManage = true;
		TransactionManage = transactionManage;
		if (objApiContext.DbConn.TransactionOpen)
		{
			TransactionManage = false;
		}
		else
		{
			TransactionManage = true;
		}
	}

	protected abstract modGeneral.FXRETURN CheckData(ref string rsmess);

	protected abstract modGeneral.FXRETURN Core(ref string rsmess);

	public virtual modGeneral.FXRETURN Run(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			PerformanceLogAppend("CHECKDATA");
			WriteLog("BEGIN API");
			fXRETURN = CheckData(ref rsmess);
			if (fXRETURN != 0)
			{
				fXRETURN2 = fXRETURN;
			}
			else
			{
				PerformanceLogAppend("BEFORE AFTERCHECKDATA");
				fXRETURN = AfterCheckData(ref rsmess);
				if (fXRETURN != 0)
				{
					fXRETURN2 = fXRETURN;
				}
				else
				{
					BeginTransaction();
					PerformanceLogAppend("BEFORE RUN");
					fXRETURN = BeforeRun(ref rsmess);
					if (fXRETURN != 0)
					{
						fXRETURN2 = fXRETURN;
					}
					else
					{
						PerformanceLogAppend("CORE");
						fXRETURN = Core(ref rsmess);
						if (fXRETURN != 0)
						{
							fXRETURN2 = fXRETURN;
						}
						else
						{
							PerformanceLogAppend("AFTER RUN");
							fXRETURN = AfterRun(ref rsmess);
							if (fXRETURN != 0)
							{
								fXRETURN2 = fXRETURN;
							}
							else
							{
								CommitTransaction();
								fXRETURN2 = modGeneral.FXRETURN.OK;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (fXRETURN2 != 0)
			{
				RollbackTransaction();
			}
			if (Operators.CompareString(rsmess, "", false) != 0)
			{
				WriteLog("ERROR API: " + rsmess.Replace("\r\n", " ").Replace("\r", " "));
			}
			WriteLog("END API");
			if (_Warning != null && !_ParametersOut.ContainsKey("_Warning"))
			{
				_ParametersOut.Add("_Warning", _Warning);
			}
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN BeforeRun(ref string rsmess)
	{
		modGeneral.FXRETURN nRes = modGeneral.FXRETURN.OK;
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			BeforeRunEvent?.Invoke(ref _ParametersIn, ref _ParametersOut, ref nRes, ref rsmess);
			fXRETURN = ((nRes != 0) ? nRes : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN;
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN AfterCheckData(ref string rsmess)
	{
		modGeneral.FXRETURN nRes = modGeneral.FXRETURN.OK;
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			AfterCheckDataEvent?.Invoke(ref _ParametersIn, ref _ParametersOut, ref nRes, ref rsmess);
			fXRETURN = ((nRes != 0) ? nRes : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN;
		}
		return result;
	}

	protected virtual modGeneral.FXRETURN AfterRun(ref string rsmess)
	{
		modGeneral.FXRETURN nRes = modGeneral.FXRETURN.OK;
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			AfterRunEvent?.Invoke(ref _ParametersIn, ref _ParametersOut, ref nRes, ref rsmess);
			fXRETURN = ((nRes != 0) ? nRes : modGeneral.FXRETURN.OK);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN;
		}
		return result;
	}

	protected virtual void BeginTransaction()
	{
		if (TransactionManage)
		{
			DbConn.BeginTransaction();
		}
	}

	protected virtual void CommitTransaction()
	{
		if (TransactionManage)
		{
			DbConn.CommitTransaction();
		}
	}

	protected virtual void RollbackTransaction()
	{
		if (TransactionManage)
		{
			DbConn.RollbackTransaction();
		}
	}
}
