using System;
using System.Web;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI.ObjectManager;

public class MultiviewObjectManager : DefaultObjectManager
{
	public MultiviewObjectManager()
	{
		_ObjectManagerName = "Default";
		_RedirectTo = "";
	}

	public MultiviewObjectManager(string vsObjectManagerName)
	{
		_ObjectManagerName = vsObjectManagerName.ToUpper();
	}

	public override FXRETURN Cancella(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Duplica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "DUPLICAZIONE";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (Operators.CompareString(_RedirectTo, "", false) != 0)
			{
				robjFunctionArguments.Argomento1 = _RedirectTo;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Inserisci(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "INSERIMENTO";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (Operators.CompareString(_RedirectTo, "", false) != 0)
			{
				robjFunctionArguments.Argomento1 = _RedirectTo;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Modifica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "MODIFICA";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (Operators.CompareString(_RedirectTo, "", false) != 0)
			{
				robjFunctionArguments.Argomento1 = _RedirectTo;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Visualizza(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			robjFunctionArguments.Context = _ObjectManagerName;
			robjFunctionArguments.Name = "VISUALIZZAZIONE";
			robjFunctionArguments.ObjectManager = this;
			HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
			if (objGridInfo != null)
			{
				objGridInfo.FunctionArgs = robjFunctionArguments;
			}
			if (Operators.CompareString(_RedirectTo, "", false) != 0)
			{
				robjFunctionArguments.Argomento1 = _RedirectTo;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected override string FindFormDir(string url)
	{
		return url;
	}
}
