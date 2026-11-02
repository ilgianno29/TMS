namespace Incasbo.Web.WSC;

public class WSCLogConfig
{
	public int SQLLeftLength { get; set; }

	public int DayOfPermanenceInLog { get; set; }

	public int DayOfPermanenceOfFile { get; set; }

	public WSCLogConfig()
	{
		int sQLLeftLength = 255;
		SQLLeftLength = sQLLeftLength;
		sQLLeftLength = 7;
		DayOfPermanenceInLog = sQLLeftLength;
		sQLLeftLength = 7;
		DayOfPermanenceOfFile = sQLLeftLength;
	}
}
