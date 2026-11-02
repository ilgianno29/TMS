using System;
using System.Web;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI.ObjectManager;

public class DB2ObjectManager : DefaultObjectManager
{
	public DB2ObjectManager()
	{
		_ObjectManagerName = "DB2";
		_RedirectTo = "";
	}

	public DB2ObjectManager(string vsObjectManagerName)
	{
		_ObjectManagerName = vsObjectManagerName.ToUpper();
	}

	public override void Init(ref IboSessionEnvironment robjSessionEnvironment)
	{
		IboAppCallStackHandling rObjCallStackHandler = robjSessionEnvironment.CallStackHandler;
		IboAppLogHandling rObjIboAppLogHandling = robjSessionEnvironment.LogHandling;
		DBConnection rObjDbMain = robjSessionEnvironment.DbConn;
		IncasTranslator rObjTranslator = robjSessionEnvironment.Translator;
		IboWebUserInfo rObjWebUserInfo = robjSessionEnvironment.WebUser.WebUserInfo;
		Init(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo);
	}

	public override void Init(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		base.Init(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo);
	}

	public override FXRETURN Cancella(ref FunctionArguments robjFunctionArguments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (robjFunctionArguments.Data.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Dati insufficienti al completamento dell'operazione.");
			}
			else if (Operators.CompareString(_ObjectTableName, "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Tabella di riferimento non identificata per le operazioni di cancellazione.");
			}
			else
			{
				robjFunctionArguments.Context = _ObjectManagerName;
				robjFunctionArguments.Name = "CANCELLAZIONE";
				robjFunctionArguments.ObjectManager = this;
				HttpContext.Current.Session.Add("FunctionArgs", (object)robjFunctionArguments);
				string sUrl = RedirectToDel;
				if (Operators.CompareString(sUrl, "", false) == 0)
				{
					sUrl = RedirectTo;
				}
				if (Operators.CompareString(sUrl, "", false) != 0)
				{
					if (!robjFunctionArguments.OpenInIFrame)
					{
						robjFunctionArguments.Target = sUrl;
						BaseFunctions.IboResponseRedirect(ref _ObjCallStackHandler, ref sUrl);
					}
					else
					{
						sUrl = ((Strings.InStr(sUrl, "?", (CompareMethod)0) <= 0) ? (sUrl + "?IsInIFrame=S") : (sUrl + "&IsInIFrame=S"));
						sUrl = Strings.Replace(sUrl, "~/", ((IboSessionEnvironment)HttpContext.Current.Session["SessionEnvironment"]).AppApplicationRootUrl, 1, -1, (CompareMethod)0);
						string title = "";
						if (robjFunctionArguments.Argomento1 != null)
						{
							title = robjFunctionArguments.Argomento1.ToString();
							robjFunctionArguments.Argomento1 = null;
						}
						WFIMaster.IFrameDimension frameDimension = WFIMaster.IFrameDimension.Standard;
						if (robjFunctionArguments.Argomento2 != null)
						{
							frameDimension = (WFIMaster.IFrameDimension)robjFunctionArguments.Argomento2;
							robjFunctionArguments.Argomento2 = null;
						}
						string iFrameCSSCustomClass = "";
						if (robjFunctionArguments.Argomento3 != null)
						{
							if (Operators.CompareString(robjFunctionArguments.Argomento3.ToString(), "", false) != 0)
							{
								iFrameCSSCustomClass = robjFunctionArguments.Argomento3.ToString();
							}
							robjFunctionArguments.Argomento3 = null;
						}
						if (robjFunctionArguments.Argomento4 != null && Operators.CompareString(robjFunctionArguments.Argomento4.ToString(), "", false) != 0)
						{
							sUrl = sUrl + "&IsInIFrameBodyClass=" + robjFunctionArguments.Argomento4.ToString();
						}
						if (frameDimension == WFIMaster.IFrameDimension.IFrameContainerCustomDefinition)
						{
							robjFunctionArguments.WFIPage.OpenIframe(sUrl, robjFunctionArguments.IFrameTag, title, iFrameCSSCustomClass);
						}
						else
						{
							robjFunctionArguments.WFIPage.OpenIframe(sUrl, robjFunctionArguments.IFrameTag, title, frameDimension);
						}
						robjFunctionArguments.WFIPage = null;
					}
				}
				val = (FXRETURN)0;
			}
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
}
