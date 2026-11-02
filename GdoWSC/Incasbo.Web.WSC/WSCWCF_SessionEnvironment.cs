namespace Incasbo.Web.WSC;

public class WSCWCF_SessionEnvironment : WSC_SessionEnvironment
{
	public string SessionID { get; set; }

	public WSCWCF_SessionEnvironment()
	{
		string sessionID = "";
		SessionID = sessionID;
	}
}
