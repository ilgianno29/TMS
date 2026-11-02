using System.Text.RegularExpressions;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;

namespace Incasbo.Web.WFI;

public class WFILoginPage : WFIPage
{
	public enum LoginMode
	{
		Login,
		ChangePassword,
		PasswordExpired,
		RequestChangePassword,
		LoginAnnulla,
		LoginForAssistance
	}

	protected FunctionArguments _objFunctionArguments;

	protected LoginMode _LoginMode;

	public WFILoginPage()
	{
		_objFunctionArguments = null;
		_LoginMode = LoginMode.Login;
	}

	protected virtual bool ValidatePassword(string pwd)
	{
		int minumumPasswordLength = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinumumPasswordLength;
		int minimumUpperCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters;
		int minimumLowerCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters;
		int minimumNumericCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters;
		int minimumSymbolCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumSymbolCharacters;
		Regex regex = new Regex("[A-Z]");
		Regex regex2 = new Regex("[a-z]");
		Regex regex3 = new Regex("[0-9]");
		Regex regex4 = new Regex("[^a-zA-Z0-9]");
		if (Strings.Len(pwd) < minumumPasswordLength)
		{
			return false;
		}
		if (regex.Matches(pwd).Count < minimumUpperCaseCharacters)
		{
			return false;
		}
		if (regex2.Matches(pwd).Count < minimumLowerCaseCharacters)
		{
			return false;
		}
		if (regex3.Matches(pwd).Count < minimumNumericCharacters)
		{
			return false;
		}
		if (regex4.Matches(pwd).Count < minimumSymbolCharacters)
		{
			return false;
		}
		return true;
	}

	protected virtual void SetMode()
	{
	}

	protected override void ReturnToCaller()
	{
		string text = "";
		text = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
		text = base.BaseFunctions.FindFormDirMember(text);
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref text);
	}

	protected virtual string WriteTooltipForPasswordRules()
	{
		string text = TranslateMessage("XXX", "La {0}password{1} deve avere le seguenti caratteristiche{2}{2}", "<b>", "</b>", "<br />");
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} numero{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere maiuscolo{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere minuscoli{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere speciali{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumSymbolCharacters.ToString(), "<br />");
		}
		return text + TranslateMessage("XXX", "Deve avere una lunghezza compresa tra {0} e 15 caratteri{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinumumPasswordLength.ToString(), "<br />");
	}
}
