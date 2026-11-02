namespace Incasbo.Web.WSC;

public class WFILoginManagerConfig
{
	public bool CryptographyEnable { get; set; }

	public WFILoginManagerConfig()
	{
		bool cryptographyEnable = true;
		CryptographyEnable = cryptographyEnable;
	}
}
