using Incasbo.Api.App;

namespace Incasbo.CustomApi.Gdo;

public class CST_SendMailInfo : SendMailInfo
{
	public string MittenteNome { get; set; }

	public string MittenteEmail { get; set; }

	public string SMTPEnableSSL { get; set; }

	public CST_SendMailInfo()
	{
		MittenteNome = "";
		MittenteEmail = "";
		SMTPEnableSSL = "";
	}
}
