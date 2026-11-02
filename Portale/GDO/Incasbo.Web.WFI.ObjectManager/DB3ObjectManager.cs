namespace Incasbo.Web.WFI.ObjectManager;

public class DB3ObjectManager : DB2ObjectManager
{
	public DB3ObjectManager()
	{
		_ObjectManagerName = "DB3";
		_RedirectTo = "";
	}

	public DB3ObjectManager(string vsObjectManagerName)
	{
		_ObjectManagerName = vsObjectManagerName.ToUpper();
	}
}
