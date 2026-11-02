using Incasbo.Web.Library;

namespace Incasbo.Api.App;

public class CRWConfiguration
{
	public string DB_Provider { get; set; }

	public string DB_Server { get; set; }

	public DBFormatFunctions.eServerType DB_ServerType { get; set; }

	public string DB_Database { get; set; }

	public string DB_Username { get; set; }

	public string DB_Password { get; set; }

	public bool DB_UseIntegratedSecurity { get; set; }

	public int DB_TimeOut { get; set; }

	public string DB_Sistema { get; set; }

	public CRWConfiguration()
	{
		string dB_Provider = "";
		DB_Provider = dB_Provider;
		dB_Provider = "";
		DB_Server = dB_Provider;
		dB_Provider = "";
		DB_Database = dB_Provider;
		dB_Provider = "";
		DB_Username = dB_Provider;
		dB_Provider = "";
		DB_Password = dB_Provider;
		bool dB_UseIntegratedSecurity = false;
		DB_UseIntegratedSecurity = dB_UseIntegratedSecurity;
		int dB_TimeOut = 60;
		DB_TimeOut = dB_TimeOut;
		dB_Provider = "";
		DB_Sistema = dB_Provider;
	}
}
