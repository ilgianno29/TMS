using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class IboGridConfigList : Dictionary<string, IboWebGridConfig>
{
	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IboWebUserInfo _ObjWebUserInfo;

	protected IncasTranslator _Translator;

	protected DBConnection _dbMain;

	public IboGridConfigList(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_dbMain = rObjDbMain;
		_ObjWebUserInfo = rObjWebUserInfo;
		_Translator = rObjTranslator;
	}

	public FXRETURN Add(string sNomRif, ref IboGridInfo rObjGridInfo, ref IboGridView rObjGridView, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali, ref IboWebGridConfig robjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebGridConfig iboWebGridConfig = null;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (ContainsKey(sNomRif))
			{
				iboWebGridConfig = base[sNomRif];
				iboWebGridConfig.Reinit(ref rObjGridInfo, ref rObjGridView, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali);
			}
			else
			{
				iboWebGridConfig = new IboWebGridConfig(ref rObjGridInfo, ref rObjGridView, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _dbMain, ref _Translator, ref _ObjWebUserInfo);
				Add(sNomRif, iboWebGridConfig);
			}
			robjGridConfig = iboWebGridConfig;
			val = (FXRETURN)0;
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

	public FXRETURN Add(string sNomRif, ref IboGridInfo rObjGridInfo, ref RadGrid rObjGridViewTlk, ref IboWebLabel rObjGridTitleLabel, ref IboWebLabel rObjGridFilterLabel, ref IboWebLabel rObjNumeroRecordTotali, ref IboWebGridConfigTlk robjGridConfig, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebGridConfigTlk iboWebGridConfigTlk = null;
		FXRETURN result;
		try
		{
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (ContainsKey(sNomRif))
			{
				iboWebGridConfigTlk = (IboWebGridConfigTlk)base[sNomRif];
				iboWebGridConfigTlk.Reinit(ref rObjGridInfo, ref rObjGridViewTlk, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali);
			}
			else
			{
				iboWebGridConfigTlk = new IboWebGridConfigTlk(ref rObjGridInfo, ref rObjGridViewTlk, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _dbMain, ref _Translator, ref _ObjWebUserInfo);
				Add(sNomRif, iboWebGridConfigTlk);
			}
			robjGridConfig = iboWebGridConfigTlk;
			val = (FXRETURN)0;
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

	public void VerifyUsage()
	{
		try
		{
			int num = 300;
			StringCollection stringCollection = new StringCollection();
			foreach (string key in base.Keys)
			{
				IboWebGridConfig iboWebGridConfig = base[key];
				if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, DateTime.Now, iboWebGridConfig.LastUsage, (FirstDayOfWeek)1, (FirstWeekOfYear)1)) > num)
				{
					stringCollection.Add(key);
				}
			}
			if (stringCollection.Count <= 0)
			{
				return;
			}
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string current2 = enumerator2.Current;
				try
				{
					base[current2].DataTableSource.Dispose();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				try
				{
					base[current2].LastDataTableSource.Dispose();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				Remove(current2);
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}
}
