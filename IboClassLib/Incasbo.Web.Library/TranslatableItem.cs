namespace Incasbo.Web.Library;

public class TranslatableItem
{
	public string Language { get; set; }

	public string Contesto { get; set; }

	public string Text { get; set; }

	public string TranslatedText { get; set; }

	public TranslatableItem()
	{
		string language = "";
		Language = language;
		language = "";
		Contesto = language;
		language = "";
		Text = language;
		language = "";
		TranslatedText = language;
	}
}
