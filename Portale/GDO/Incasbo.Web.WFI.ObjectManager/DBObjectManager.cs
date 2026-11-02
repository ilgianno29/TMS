using Incasbo.Web.Library;

namespace Incasbo.Web.WFI.ObjectManager;

public class DBObjectManager : DefaultObjectManager
{
	public DBObjectManager()
	{
		_ObjectManagerName = "DB";
		_RedirectTo = "";
	}

	public DBObjectManager(string vsObjectManagerName)
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
}
