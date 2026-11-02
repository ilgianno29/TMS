namespace Incasbo.Api.App;

public class SendSMSInfo
{
	public int Tipo;

	public string Number;

	public string Text;

	public SendSMSInfo()
	{
		Tipo = 1;
		Number = "";
		Text = "";
	}

	public SendSMSInfo(string vsNumber, string vsText)
	{
		Tipo = 1;
		Number = "";
		Text = "";
		Number = vsNumber;
		Text = vsText;
	}
}
