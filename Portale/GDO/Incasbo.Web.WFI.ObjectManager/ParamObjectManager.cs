namespace Incasbo.Web.WFI.ObjectManager;

public class ParamObjectManager : GenericObjectManager
{
	public ParamObjectManager()
	{
		_ObjectManagerName = "PARAMETRICA";
		_ObjectTableName = "PARAMETRICA";
		_RedirectTo = "WFParametrica.aspx";
	}
}
