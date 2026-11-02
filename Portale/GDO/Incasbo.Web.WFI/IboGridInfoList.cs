using System;
using System.Collections.Generic;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboGridInfoList : Dictionary<string, IboGridInfo>
{
	public enum IboGridInfoListMode
	{
		Standard,
		AlwaysInit,
		Cfg
	}

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	protected IboGridInfoListMode _GridInfoListMode;

	public IboWebUserInfo WebUserInfo
	{
		get
		{
			return _ObjWebUserInfo;
		}
		set
		{
			if (Operators.CompareString(_ObjWebUserInfo.Codice.ToUpper(), value.Codice.ToUpper(), false) != 0)
			{
				Clear();
			}
			_ObjWebUserInfo = value;
		}
	}

	public IboGridInfoListMode GridInfoListMode
	{
		get
		{
			return _GridInfoListMode;
		}
		set
		{
			if (_GridInfoListMode != value)
			{
				Clear();
			}
			_GridInfoListMode = value;
		}
	}

	public IboGridInfoList(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo, IboGridInfoListMode vbGridInfoListMode)
	{
		_GridInfoListMode = IboGridInfoListMode.Standard;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_dbMain = rObjDbMain;
		_ObjWebUserInfo = rObjWebUserInfo;
		_Translator = rObjTranslator;
		_GridInfoListMode = vbGridInfoListMode;
	}

	public FXRETURN Add(string sNomRif, ref IboGridInfo robjGridInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboGridInfo iboGridInfo = null;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_GridInfoListMode == IboGridInfoListMode.Cfg && ContainsKey(sNomRif))
			{
				Remove(sNomRif);
			}
			if (ContainsKey(sNomRif))
			{
				iboGridInfo = base[sNomRif];
				if (_GridInfoListMode != IboGridInfoListMode.AlwaysInit)
				{
					goto IL_00c9;
				}
				val2 = iboGridInfo.ReInit(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00c9;
				}
			}
			else
			{
				iboGridInfo = new IboGridInfo(sNomRif, ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _dbMain, ref _Translator, ref _ObjWebUserInfo);
				val2 = iboGridInfo.Init(ref rsMess);
				if ((int)val2 <= 0)
				{
					Add(sNomRif, iboGridInfo);
					goto IL_00c9;
				}
			}
			goto end_IL_0007;
			IL_00c9:
			robjGridInfo = iboGridInfo;
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
