namespace Incasbo.Web.WFI.ObjectManager;

public class UserAdminObjectManager : GenericObjectManager
{
	public UserAdminObjectManager()
	{
		_ObjectManagerName = "UTENTIADMIN";
		_ObjectTableName = "WFI_UTENTI";
		_RedirectTo = "WFUtentiAdmin.aspx";
	}
}
