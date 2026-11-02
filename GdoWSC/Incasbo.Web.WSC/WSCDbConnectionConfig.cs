namespace Incasbo.Web.WSC;

public class WSCDbConnectionConfig
{
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

	public WSCDbConnectionConfig()
	{
		string dB_Provider = "";
		DB_Provider = dB_Provider;
		dB_Provider = "SQL";
		DB_ServerType = dB_Provider;
		bool dB_UseIntegratedSecurity = false;
		DB_UseIntegratedSecurity = dB_UseIntegratedSecurity;
		int dB_TimeOut = 60;
		DB_TimeOut = dB_TimeOut;
		dB_Provider = "SQLCLIENT";
		DB_ProviderType = dB_Provider;
		dB_Provider = "";
		DB_Username = dB_Provider;
		dB_Provider = "";
		DB_Server = dB_Provider;
		dB_Provider = "";
		DB_Password = dB_Provider;
		dB_Provider = "";
		DB_Database = dB_Provider;
		dB_Provider = "";
		DB_Description = dB_Provider;
	}
}
