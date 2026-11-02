using System;
using System.Collections.Generic;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboWebToolbarInfoList : Dictionary<string, IboWebToolbarInfo>
{
	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected bool _AlwaysInit;

	protected string _UserReInit;

	protected IboWebToolbarInfoList()
	{
		_UserReInit = "";
	}

	public IboWebToolbarInfoList(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo, bool vbAlwaysInit, string UserReinit)
	{
		_UserReInit = "";
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_dbMain = rObjDbMain;
		_ObjWebUserInfo = rObjWebUserInfo;
		_Translator = rObjTranslator;
		_AlwaysInit = vbAlwaysInit;
		_UserReInit = UserReinit;
	}

	public FXRETURN Add(string sNomRif, string sUtente, ref IboWebToolbarInfo rObjWebToolbarInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbarInfo iboWebToolbarInfo = null;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (ContainsKey(sNomRif + "-" + sUtente))
			{
				iboWebToolbarInfo = base[sNomRif + "-" + sUtente];
				if (!_AlwaysInit || !((Operators.CompareString(_UserReInit.ToUpper(), "", false) == 0) | (Operators.CompareString(_UserReInit.ToUpper(), _ObjWebUserInfo.Codice.ToUpper(), false) == 0)))
				{
					goto IL_010c;
				}
				val2 = iboWebToolbarInfo.Init(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_010c;
				}
			}
			else
			{
				iboWebToolbarInfo = new IboWebToolbarInfo(sNomRif, sUtente, ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _dbMain, ref _Translator, ref _ObjWebUserInfo);
				val2 = iboWebToolbarInfo.Init(ref rsMess);
				if ((int)val2 <= 0)
				{
					Add(sNomRif + "-" + sUtente, iboWebToolbarInfo);
					goto IL_010c;
				}
			}
			goto end_IL_0007;
			IL_010c:
			rObjWebToolbarInfo = iboWebToolbarInfo;
			val = (FXRETURN)0;
			end_IL_0007:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}
}
