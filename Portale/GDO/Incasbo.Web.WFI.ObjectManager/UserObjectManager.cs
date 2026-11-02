namespace Incasbo.Web.WFI.ObjectManager;

public class UserObjectManager : GenericObjectManager
{
	public UserObjectManager()
	{
		_ObjectManagerName = "UTENTI";
		_ObjectTableName = "WFI_UTENTI";
		_RedirectTo = "WFUtenti.aspx";
	}
}
