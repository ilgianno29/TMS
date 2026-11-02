namespace Incasbo.Web.WFI;

public class WFITranslationConfig
{
	public bool FormTranslationSave { get; set; }

	public bool TranslationIsActive { get; set; }

	public WFITranslationConfig()
	{
		FormTranslationSave = false;
		TranslationIsActive = false;
	}
}
