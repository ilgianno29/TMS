using System.Collections.Specialized;

namespace Incasbo.Web.WFI;

public class WFILoginManagerConfig
{
	public string RememberMe { get; set; }

	public bool CryptographyEnable { get; set; }

	public int PasswordValidationAlgorithm { get; set; }

	public int PreferredPasswordLength { get; set; }

	public int MinumumPasswordLength { get; set; }

	public int MinimumNumericCharacters { get; set; }

	public int MinimumSymbolCharacters { get; set; }

	public int MinimumUpperCaseCharacters { get; set; }

	public int MinimumLowerCaseCharacters { get; set; }

	public int PasswordValidityTime { get; set; }

	public bool EnableIdentityChange { get; set; }

	public StringCollection IdentityChangeUserList { get; set; }

	public int PasswordErrorBlockUserAfter { get; set; }

	public WFILoginManagerConfig()
	{
		RememberMe = "N";
		CryptographyEnable = true;
		PasswordValidationAlgorithm = 1;
		PreferredPasswordLength = 8;
		MinumumPasswordLength = 6;
		MinimumNumericCharacters = 1;
		MinimumSymbolCharacters = 1;
		MinimumUpperCaseCharacters = 1;
		MinimumLowerCaseCharacters = 1;
		PasswordValidityTime = 90;
		EnableIdentityChange = false;
		IdentityChangeUserList = new StringCollection();
		PasswordErrorBlockUserAfter = 5;
	}
}
