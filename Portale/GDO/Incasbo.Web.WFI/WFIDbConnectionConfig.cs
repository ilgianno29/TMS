namespace Incasbo.Web.WFI;

public class WFIDbConnectionConfig
{
	public string DB_Key { get; set; }

	public string DB_Provider { get; set; }

	public string DB_ServerType { get; set; }

	public bool DB_UseIntegratedSecurity { get; set; }

	public int DB_TimeOut { get; set; }

	public string DB_ProviderType { get; set; }

	public string DB_Username { get; set; }

	public string DB_Server { get; set; }

	public string DB_Password { get; set; }

	public string DB_Database { get; set; }

	public string DB_Description { get; set; }

	public WFIDbConnectionConfig()
	{
		DB_Key = "";
		DB_Provider = "";
		DB_ServerType = "SQL";
		DB_UseIntegratedSecurity = false;
		DB_TimeOut = 60;
		DB_ProviderType = "SQLCLIENT";
		DB_Username = "";
		DB_Server = "";
		DB_Password = "";
		DB_Database = "";
		DB_Description = "";
	}
}
