using System;
using System.Web;
using Incasbo.Web.Components;
using Incasbo.Web.Library;

namespace Incasbo.Web.WFI.ObjectManager;

public abstract class AbstractObjectManager
{
	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected DBConnection _ObjDbMain;

	protected IncasTranslator _ObjTranslator;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected bool _Handled;

	protected IboSessionEnvironment _SessionEnvironment;

	public string Tipo { get; set; }

	public abstract string ObjectManagerName { get; }

	public abstract string RedirectTo { get; }

	public abstract string RedirectToIns { get; }

	public abstract string RedirectToDup { get; }

	public abstract string RedirectToMod { get; }

	public abstract string RedirectToVis { get; }

	public abstract string RedirectToDel { get; }

	public abstract string ObjectTableName { get; }

	public abstract string EntityName { get; }

	public abstract string FilterPage { get; }

	public abstract string FilterPageParameters { get; }

	protected string CallStack => _ObjCallStackHandler.CallStack;

	protected AbstractObjectManager()
	{
		Tipo = "";
	}

	public abstract FXRETURN Cancella(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Duplica(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Duplica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Inserisci(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Inserisci(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Modifica(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Modifica(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Stampa(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN CallFunction(ref FunctionArguments robjFunctionArguments, IboWebToolbarEventArgs e, ref string rsMess);

	public abstract FXRETURN CallFunction(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, IboWebToolbarEventArgs e, ref string rsMess);

	public abstract FXRETURN Visualizza(ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public abstract FXRETURN Visualizza(ref IboGridInfo objGridInfo, ref FunctionArguments robjFunctionArguments, ref string rsMess);

	public virtual void Init(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_ObjDbMain = rObjDbMain;
		_ObjTranslator = rObjTranslator;
		_ObjWebUserInfo = rObjWebUserInfo;
		_SessionEnvironment = (IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"];
	}

	public virtual void Init(ref IboSessionEnvironment robjSessionEnvironment)
	{
		_ObjCallStackHandler = robjSessionEnvironment.CallStackHandler;
		_ObjIboAppLogHandling = robjSessionEnvironment.LogHandling;
		_ObjDbMain = robjSessionEnvironment.DbConn;
		_ObjTranslator = robjSessionEnvironment.Translator;
		_ObjWebUserInfo = robjSessionEnvironment.WebUser.WebUserInfo;
		_SessionEnvironment = robjSessionEnvironment;
	}

	protected string TranslateMessage(string vsID, string vsDefault, params string[] vParametri)
	{
		return _ObjTranslator.TranslateMessage(vsID, vsDefault, vParametri);
	}

	protected string TranslateMessage(string vsID, string vsDefault)
	{
		return _ObjTranslator.TranslateMessage(vsID, vsDefault, new string[0]);
	}

	protected void CallStackAdd()
	{
		_ObjCallStackHandler.CallStackAdd();
	}

	protected void CallStackReset()
	{
		_ObjCallStackHandler.CallStackReset();
	}

	protected void CallStackRemove()
	{
		_ObjCallStackHandler.CallStackRemove();
	}

	protected FXRETURN HandleError(ref Exception objEx, ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return _ObjIboAppLogHandling.HandleError(ref objEx, ref rsMess);
	}

	protected FXRETURN HandleError(ref Exception objEx, string vsMessage, ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return _ObjIboAppLogHandling.HandleError(ref objEx, vsMessage, ref rsMess);
	}
}
