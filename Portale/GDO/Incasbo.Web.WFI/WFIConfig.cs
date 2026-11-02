using System;
using System.Collections.Generic;
using System.IO;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIConfig
{
	public WFINotificationMessageConfig NotificationMessageConfig { get; set; }

	public WFIDebugConfig DebugConfig { get; set; }

	public WFITranslationConfig TranslationConfig { get; set; }

	public WFIApplicationConfig ApplicationConfig { get; set; }

	public WFIMasterPageConfig MasterPageConfig { get; set; }

	public WFIBackgroundActivityConfig BackgroundActivityConfig { get; set; }

	public WFIMenuManagerConfig MenuManagerConfig { get; set; }

	public WFIStandardGridManager StandardGrigManager { get; set; }

	public WFIPageConfig WFIPageConfig { get; set; }

	public bool ExistsConfig { get; set; }

	public bool Initialized { get; set; }

	public WFIDbConnectionConfig DefaultDBConnectionConfig { get; set; }

	public Dictionary<string, WFIDbConnectionConfig> DBConnectionListConfig { get; set; }

	public WFIAutoTooltipifyConfig AutoTooltipifyConfig { get; set; }

	public WFILoginManagerConfig LoginManagerConfig { get; set; }

	/// <summary>
	/// Utente di servizio con cui il portale chiama i servizi GdoWSC (calcolo km/tempi, ecc.),
	/// sezione [ServizioGdoWSC] di WFIConfig.ini. Prima si usava la password decifrata dell'utente collegato.
	/// Lato GdoWSC l'utente va configurato in IniConfig\UtentiTecnici.ini con l'hash della password.
	/// </summary>
	public string ServizioGdoWSCUtente { get; set; } = "";

	/// <summary>[AutoLogin] ConsentiPasswordInUrl: vecchio autologin con password nell'indirizzo (default False).</summary>
	public bool AutoLoginConsentiPasswordInUrl { get; set; }

	public string ServizioGdoWSCPassword { get; set; } = "";

	public WFICookiesConfig CookiesConfig { get; set; }

	public WFIVersion WFIVersion { get; set; }

	public WFIConfig()
	{
		ExistsConfig = false;
		Initialized = false;
		NotificationMessageConfig = new WFINotificationMessageConfig();
		DebugConfig = new WFIDebugConfig();
		TranslationConfig = new WFITranslationConfig();
		ApplicationConfig = new WFIApplicationConfig();
		MasterPageConfig = new WFIMasterPageConfig();
		BackgroundActivityConfig = new WFIBackgroundActivityConfig();
		MenuManagerConfig = new WFIMenuManagerConfig();
		StandardGrigManager = new WFIStandardGridManager();
		WFIPageConfig = new WFIPageConfig();
		DefaultDBConnectionConfig = new WFIDbConnectionConfig();
		DBConnectionListConfig = new Dictionary<string, WFIDbConnectionConfig>();
		AutoTooltipifyConfig = new WFIAutoTooltipifyConfig();
		LoginManagerConfig = new WFILoginManagerConfig();
		CookiesConfig = new WFICookiesConfig();
		WFIVersion = new WFIVersion();
	}

	public void Init(string WFIIniFile, string AppIniFile, string WFIDbIniFile, string AppDbIniFile)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_1fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Expected O, but got Unknown
		//IL_454d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4556: Expected O, but got Unknown
		//IL_4776: Unknown result type (might be due to invalid IL or missing references)
		//IL_477f: Expected O, but got Unknown
		try
		{
			string text = "";
			if (File.Exists(WFIIniFile))
			{
				FileInfo fileInfo = new FileInfo(WFIIniFile);
				string text2 = fileInfo.DirectoryName + "\\WFIVersion.ini";
				if (File.Exists(text2))
				{
					IniFile val = new IniFile();
					val.Load(text2, false);
					text = val.GetKeyValue("WFI", "Version");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
					{
						WFIVersion.Version = text.Trim();
					}
					text = val.GetKeyValue("WFI", "ReleaseDate");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
					{
						WFIVersion.ReleaseDate = text.Trim();
					}
					text = val.GetKeyValue("WFI", "Patch");
					if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
					{
						WFIVersion.Patch = text.Trim();
					}
				}
			}
			if (File.Exists(WFIIniFile))
			{
				IniFile val2 = new IniFile();
				val2.Load(WFIIniFile, false);
				text = val2.GetKeyValue("NotificationMessage", "Width");
				if (text != null)
				{
					NotificationMessageConfig.Width = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("NotificationMessage", "Height");
				if (text != null)
				{
					if (Operators.CompareString(text.ToUpper().Trim(), "AUTO", false) == 0)
					{
						NotificationMessageConfig.Height = null;
					}
					else
					{
						NotificationMessageConfig.Height = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("NotificationMessage", "Animation");
				if (text != null)
				{
					NotificationMessageConfig.Animation = text;
				}
				text = val2.GetKeyValue("NotificationMessage", "EnableRoundedCorners");
				if (text != null)
				{
					NotificationMessageConfig.EnableRoundedCorners = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("NotificationMessage", "EnableShadow");
				if (text != null)
				{
					NotificationMessageConfig.EnableShadow = Operators.CompareString(text.Trim().ToUpper(), "FALSE", false) != 0;
				}
				text = val2.GetKeyValue("NotificationMessage", "Position");
				if (text != null)
				{
					NotificationMessageConfig.Position = text;
				}
				text = val2.GetKeyValue("NotificationMessage", "AutoCloseDelay");
				if (text != null)
				{
					NotificationMessageConfig.AutoCloseDelay = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("NotificationMessage", "ContentScrolling");
				if (text != null)
				{
					NotificationMessageConfig.ContentScrolling = text;
				}
				text = val2.GetKeyValue("Debug", "DebugMode");
				if (text != null)
				{
					DebugConfig.DebugMode = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("Debug", "UserDebug");
				if (text != null)
				{
					DebugConfig.UserDebug = text.Trim().ToUpper();
				}
				text = val2.GetKeyValue("Debug", "ConfigMode");
				if (text != null)
				{
					DebugConfig.ConfigMode = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("Debug", "ConfigUser");
				if (text != null)
				{
					DebugConfig.ConfigUser = text.Trim().ToUpper();
				}
				text = val2.GetKeyValue("Translation", "FormTranslationSave");
				if (text != null)
				{
					TranslationConfig.FormTranslationSave = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("Translation", "TranslationIsActive");
				if (text != null)
				{
					TranslationConfig.TranslationIsActive = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("MasterPage", "PanelTopHeaderVisible");
				if (text != null)
				{
					MasterPageConfig.PanelTopHeaderVisible = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("MasterPage", "EnableEventValidation");
				if (text != null)
				{
					MasterPageConfig.EnableEventValidation = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("MasterPage", "StandardHeaderUserVisible");
				if (text != null)
				{
					MasterPageConfig.StandardHeaderUserVisible = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("MasterPage", "StandardHeaderFilialeVisible");
				if (text != null)
				{
					MasterPageConfig.StandardHeaderFilialeVisible = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("MasterPage", "StandardHeaderOrganizationVisible");
				if (text != null)
				{
					MasterPageConfig.StandardHeaderOrganizationVisible = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("BackGroundActivity", "BackgroundActivityTypeName");
				if (text != null)
				{
					BackgroundActivityConfig.BackgroundActivityTypeName = text;
				}
				text = val2.GetKeyValue("BackGroundActivity", "BackgroundActivityTimerLoop");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
				{
					BackgroundActivityConfig.BackgroundActivityTimerLoop = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("BackgroundActivity", "BackgroundActivityEnabled");
				if (text != null)
				{
					BackgroundActivityConfig.BackgroundActivityEnabled = Operators.CompareString(text.Trim().ToUpper(), "N", false) != 0;
				}
				text = val2.GetKeyValue("BackgroundActivity", "BackgroundActivityPeriods");
				BackgroundActivityConfig.BackgroundActivityPeriods = new List<WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period>();
				if (text != null)
				{
					text = text.Trim().Replace(":", ".").Replace(" ", "");
					string[] array = text.Split(new char[1] { ';' });
					string[] array2 = array;
					foreach (string text3 in array2)
					{
						WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period wFIBackgroundActivityConfig_Period = new WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period();
						string[] array3 = text3.Split(new char[1] { '-' });
						string[] array4 = array3[0].Split(new char[1] { '.' });
						string[] array5 = array3[1].Split(new char[1] { '.' });
						wFIBackgroundActivityConfig_Period.From = new TimeSpan(Conversions.ToInteger(array4[0]), Conversions.ToInteger(array4[1]), Conversions.ToInteger(array4[2]));
						wFIBackgroundActivityConfig_Period.To = new TimeSpan(Conversions.ToInteger(array5[0]), Conversions.ToInteger(array5[1]), Conversions.ToInteger(array5[2]));
						BackgroundActivityConfig.BackgroundActivityPeriods.Add(wFIBackgroundActivityConfig_Period);
					}
				}
				if (BackgroundActivityConfig.BackgroundActivityPeriods.Count == 0)
				{
					WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period wFIBackgroundActivityConfig_Period2 = new WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period();
					wFIBackgroundActivityConfig_Period2.From = new TimeSpan(0, 0, 0);
					wFIBackgroundActivityConfig_Period2.To = new TimeSpan(23, 59, 59);
					BackgroundActivityConfig.BackgroundActivityPeriods.Add(wFIBackgroundActivityConfig_Period2);
				}
				text = val2.GetKeyValue("Application", "LogoApplicazione");
				if (text != null)
				{
					ApplicationConfig.LogoApplicazione = text.Trim();
				}
				text = val2.GetKeyValue("Application", "LogoDitta");
				if (text != null)
				{
					ApplicationConfig.LogoDitta = text.Trim();
				}
				text = val2.GetKeyValue("Application", "LogoIncas");
				if (text != null)
				{
					ApplicationConfig.LogoIncas = text.Trim();
				}
				text = val2.GetKeyValue("Application", "TitoloApplicazione");
				if (text != null)
				{
					ApplicationConfig.TitoloApplicazione = text.Trim();
				}
				text = val2.GetKeyValue("Application", "InfoIncas");
				if (text != null)
				{
					ApplicationConfig.InfoIncas = text.Trim();
				}
				text = val2.GetKeyValue("Application", "InfoIncas");
				if (text != null)
				{
					ApplicationConfig.InfoIncas = text.Trim();
				}
				text = val2.GetKeyValue("Application", "TitoloModuloSoftware");
				if (text != null)
				{
					ApplicationConfig.TitoloModuloSoftware = text.Trim();
				}
				text = val2.GetKeyValue("Application", "TitoloModuloSoftwareAcronimo");
				if (text != null)
				{
					ApplicationConfig.TitoloModuloSoftwareAcronimo = text.Trim();
				}
				text = val2.GetKeyValue("MenuManager", "UseVersion");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					MenuManagerConfig.UseVersion = text.Trim();
				}
				text = val2.GetKeyValue("MenuManager", "DesktopGenericIcon");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					MenuManagerConfig.DesktopGenericIcon = text.Trim();
				}
				text = val2.GetKeyValue("MenuManager", "FolderGenericIcon");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					MenuManagerConfig.FolderGenericIcon = text.Trim();
				}
				text = val2.GetKeyValue("MenuManager", "DesktopRepeatColumns");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					MenuManagerConfig.DesktopRepeatColumns = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("StandardGridManager", "SelectByRightClickMode");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					StandardGrigManager.SelectByRightClickMode = text.Trim();
				}
				text = val2.GetKeyValue("StandardGridManager", "ShowMenuActionButton");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					StandardGrigManager.ShowMenuActionButton = Operators.CompareString(text.Trim(), "S", false) == 0;
				}
				text = val2.GetKeyValue("StandardGridManager", "FilterVersion");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					StandardGrigManager.FilterVersion = text.Trim();
				}
				text = val2.GetKeyValue("WFIPageConfig", "ViewStateSaveMode");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					WFIPageConfig.ViewStateSaveMode = text.Trim();
				}
				text = val2.GetKeyValue("WFIPageConfig", "ViewStateSaveModePages");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					string[] array6 = text.Split(new char[1] { ',' });
					string[] array7 = array6;
					foreach (string text4 in array7)
					{
						WFIPageConfig.ViewStateSaveModePages.Add(text4.ToUpper());
					}
				}
				text = val2.GetKeyValue("WFIPageConfig", "DebugAsyncTimeout");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
				{
					WFIPageConfig.DebugAsyncTimeout = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("WFIPageConfig", "ReleaseAsyncTimeout");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
				{
					WFIPageConfig.ReleaseAsyncTimeout = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("WFIPageConfig", "LastActivityRealTime");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					WFIPageConfig.LastActivityRealTime = Operators.CompareString(text.Trim(), "S", false) == 0;
				}
				text = val2.GetKeyValue("WFIPageConfig", "LastActivityRealTimeInterval");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
				{
					WFIPageConfig.LastActivityRealTimeInterval = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("WFIPageConfig", "KeepAliveFrequency");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text.Trim()))
				{
					WFIPageConfig.KeepAliveFrequency = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue("AutoTooltipify", "Enable");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Enable = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("AutoTooltipify", "Type");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Type = text.ToUpper();
				}
				text = val2.GetKeyValue("AutoTooltipify", "RelativeTo");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.RelativeTo = text;
				}
				text = val2.GetKeyValue("AutoTooltipify", "Position");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Position = text;
				}
				text = val2.GetKeyValue("AutoTooltipify", "ContentScrolling");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.ContentScrolling = text;
				}
				text = val2.GetKeyValue("AutoTooltipify", "Animation");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Animation = text;
				}
				text = val2.GetKeyValue("AutoTooltipify", "AnimationDuration");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text))
				{
					AutoTooltipifyConfig.AnimationDuration = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("AutoTooltipify", "Width");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text))
				{
					AutoTooltipifyConfig.Width = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("AutoTooltipify", "Height");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text))
				{
					AutoTooltipifyConfig.Height = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("AutoTooltipify", "ShowCallout");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.ShowCallout = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("AutoTooltipify", "AutoCloseDelay");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text))
				{
					AutoTooltipifyConfig.AutoCloseDelay = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("AutoTooltipify", "NotCloseIfHover");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.NotCloseIfHover = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("AutoTooltipify", "ShowDelay");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text))
				{
					AutoTooltipifyConfig.ShowDelay = Conversions.ToInteger(text);
				}
				text = val2.GetKeyValue("AutoTooltipify", "NotCloseIfHover");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.TooltipByIdEnabled = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("AutoLogin", "ConsentiPasswordInUrl");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					AutoLoginConsentiPasswordInUrl = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue("ServizioGdoWSC", "Utente");
				if (text != null)
				{
					ServizioGdoWSCUtente = text.Trim();
				}
				text = val2.GetKeyValue("ServizioGdoWSC", "Password");
				if (text != null)
				{
					ServizioGdoWSCPassword = text.Trim();
				}
				text = val2.GetKeyValue("LoginManager", "RememberMe");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						LoginManagerConfig.RememberMe = text;
					}
				}
				text = val2.GetKeyValue("LoginManager", "CryptographyEnable");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						LoginManagerConfig.CryptographyEnable = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("LoginManager", "PasswordValidationAlgorithm");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.PasswordValidationAlgorithm = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "PreferredPasswordLength");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.PreferredPasswordLength = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "MinumumPasswordLength");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.MinumumPasswordLength = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "MinimumNumericCharacters");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.MinimumNumericCharacters = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "MinimumSymbolCharacters");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.MinimumSymbolCharacters = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "MinimumUpperCaseCharacters");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.MinimumUpperCaseCharacters = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "MinimumLowerCaseCharacters");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.MinimumLowerCaseCharacters = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "PasswordValidityTime");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.PasswordValidityTime = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("LoginManager", "EnableIdentityChange");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						LoginManagerConfig.EnableIdentityChange = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("LoginManager", "IdentityChangeUserList");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						string[] array8 = text.Split(new char[1] { ',' });
						string[] array9 = array8;
						foreach (string value in array9)
						{
							LoginManagerConfig.IdentityChangeUserList.Add(value);
						}
					}
				}
				text = val2.GetKeyValue("LoginManager", "PasswordErrorBlockUserAfter");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						LoginManagerConfig.PasswordErrorBlockUserAfter = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "Enabled");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.enabled = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "Message");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.message = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "AcceptButton");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.acceptButton = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "AcceptText");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.acceptText = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "DeclineButton");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.declineButton = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "DeclineText");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.declineText = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "PolicyButton");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.policyButton = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "PolicyText");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.policyText = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "PolicyURL");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.policyURL = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "AutoEnable");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.autoEnable = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "AcceptOnContinue");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.acceptOnContinue = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "AcceptOnScroll");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.acceptOnScroll = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "AcceptAnyClick");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.acceptAnyClick = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "ExpireDays");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0 && Versioned.IsNumeric((object)text))
					{
						CookiesConfig.expireDays = Conversions.ToInteger(text);
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "RenewOnVisit");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.renewOnVisit = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "ForceShow");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.forceShow = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "Effect");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.effect = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "Element");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					CookiesConfig.element = text;
				}
				text = val2.GetKeyValue("Cookiesbar", "Append");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.append = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "Fixed");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.@fixed = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text = val2.GetKeyValue("Cookiesbar", "Bottom");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						CookiesConfig.bottom = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				ExistsConfig = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			string text5 = "";
			if (File.Exists(AppIniFile))
			{
				IniFile val3 = new IniFile();
				val3.Load(AppIniFile, false);
				text5 = val3.GetKeyValue("NotificationMessage", "Width");
				if (text5 != null)
				{
					NotificationMessageConfig.Width = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("NotificationMessage", "Height");
				if (text5 != null)
				{
					if (Operators.CompareString(text5.ToUpper().Trim(), "AUTO", false) == 0)
					{
						NotificationMessageConfig.Height = null;
					}
					else
					{
						NotificationMessageConfig.Height = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("NotificationMessage", "Animation");
				if (text5 != null)
				{
					NotificationMessageConfig.Animation = text5;
				}
				text5 = val3.GetKeyValue("NotificationMessage", "EnableRoundedCorners");
				if (text5 != null)
				{
					NotificationMessageConfig.EnableRoundedCorners = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("NotificationMessage", "EnableShadow");
				if (text5 != null)
				{
					NotificationMessageConfig.EnableShadow = Operators.CompareString(text5.Trim().ToUpper(), "FALSE", false) != 0;
				}
				text5 = val3.GetKeyValue("NotificationMessage", "Position");
				if (text5 != null)
				{
					NotificationMessageConfig.Position = text5;
				}
				text5 = val3.GetKeyValue("NotificationMessage", "AutoCloseDelay");
				if (text5 != null)
				{
					NotificationMessageConfig.AutoCloseDelay = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("NotificationMessage", "ContentScrolling");
				if (text5 != null)
				{
					NotificationMessageConfig.ContentScrolling = text5;
				}
				text5 = val3.GetKeyValue("Debug", "DebugMode");
				if (text5 != null)
				{
					DebugConfig.DebugMode = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("Debug", "UserDebug");
				if (text5 != null)
				{
					DebugConfig.UserDebug = text5.Trim().ToUpper();
				}
				text5 = val3.GetKeyValue("Debug", "ConfigMode");
				if (text5 != null)
				{
					DebugConfig.ConfigMode = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("Debug", "ConfigUser");
				if (text5 != null)
				{
					DebugConfig.ConfigUser = text5.Trim().ToUpper();
				}
				text5 = val3.GetKeyValue("Translation", "FormTranslationSave");
				if (text5 != null)
				{
					TranslationConfig.FormTranslationSave = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("Translation", "TranslationIsActive");
				if (text5 != null)
				{
					TranslationConfig.TranslationIsActive = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("MasterPage", "PanelTopHeaderVisible");
				if (text5 != null)
				{
					MasterPageConfig.PanelTopHeaderVisible = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("MasterPage", "EnableEventValidation");
				if (text5 != null)
				{
					MasterPageConfig.EnableEventValidation = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("MasterPage", "StandardHeaderUserVisible");
				if (text5 != null)
				{
					MasterPageConfig.StandardHeaderUserVisible = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("MasterPage", "StandardHeaderFilialeVisible");
				if (text5 != null)
				{
					MasterPageConfig.StandardHeaderFilialeVisible = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("MasterPage", "StandardHeaderOrganizationVisible");
				if (text5 != null)
				{
					MasterPageConfig.StandardHeaderOrganizationVisible = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("BackGroundActivity", "BackgroundActivityTypeName");
				if (text5 != null)
				{
					BackgroundActivityConfig.BackgroundActivityTypeName = text5;
				}
				text5 = val3.GetKeyValue("BackGroundActivity", "BackgroundActivityTimerLoop");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5.Trim()))
				{
					BackgroundActivityConfig.BackgroundActivityTimerLoop = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("BackGroundActivity", "BackgroundActivityEnabled");
				if (text5 != null)
				{
					BackgroundActivityConfig.BackgroundActivityEnabled = Operators.CompareString(text5.Trim().ToUpper(), "N", false) != 0;
				}
				text5 = val3.GetKeyValue("BackGroundActivity", "BackgroundActivityPeriods");
				if (text5 != null)
				{
					text5 = text5.Trim().Replace(":", ".").Replace(" ", "");
					if (Operators.CompareString(text5, "", false) != 0)
					{
						BackgroundActivityConfig.BackgroundActivityPeriods.Clear();
						string[] array10 = text5.Split(new char[1] { ';' });
						string[] array11 = array10;
						foreach (string text6 in array11)
						{
							WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period wFIBackgroundActivityConfig_Period3 = new WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period();
							string[] array12 = text6.Split(new char[1] { '-' });
							string[] array13 = array12[0].Split(new char[1] { '.' });
							string[] array14 = array12[1].Split(new char[1] { '.' });
							wFIBackgroundActivityConfig_Period3.From = new TimeSpan(Conversions.ToInteger(array13[0]), Conversions.ToInteger(array13[1]), Conversions.ToInteger(array13[2]));
							wFIBackgroundActivityConfig_Period3.To = new TimeSpan(Conversions.ToInteger(array14[0]), Conversions.ToInteger(array14[1]), Conversions.ToInteger(array14[2]));
							BackgroundActivityConfig.BackgroundActivityPeriods.Add(wFIBackgroundActivityConfig_Period3);
						}
					}
				}
				if (BackgroundActivityConfig.BackgroundActivityPeriods.Count == 0)
				{
					WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period wFIBackgroundActivityConfig_Period4 = new WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period();
					wFIBackgroundActivityConfig_Period4.From = new TimeSpan(0, 0, 0);
					wFIBackgroundActivityConfig_Period4.To = new TimeSpan(23, 59, 59);
					BackgroundActivityConfig.BackgroundActivityPeriods.Add(wFIBackgroundActivityConfig_Period4);
				}
				text5 = val3.GetKeyValue("Application", "LogoApplicazione");
				if (text5 != null)
				{
					ApplicationConfig.LogoApplicazione = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "LogoDitta");
				if (text5 != null)
				{
					ApplicationConfig.LogoDitta = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "LogoIncas");
				if (text5 != null)
				{
					ApplicationConfig.LogoIncas = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "TitoloApplicazione");
				if (text5 != null)
				{
					ApplicationConfig.TitoloApplicazione = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "InfoIncas");
				if (text5 != null)
				{
					ApplicationConfig.InfoIncas = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "InfoIncas");
				if (text5 != null)
				{
					ApplicationConfig.InfoIncas = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "TitoloModuloSoftware");
				if (text5 != null)
				{
					ApplicationConfig.TitoloModuloSoftware = text5.Trim();
				}
				text5 = val3.GetKeyValue("Application", "TitoloModuloSoftwareAcronimo");
				if (text5 != null)
				{
					ApplicationConfig.TitoloModuloSoftwareAcronimo = text5.Trim();
				}
				text5 = val3.GetKeyValue("MenuManager", "UseVersion");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					MenuManagerConfig.UseVersion = text5.Trim();
				}
				text5 = val3.GetKeyValue("MenuManager", "DesktopGenericIcon");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					MenuManagerConfig.DesktopGenericIcon = text5.Trim();
				}
				text5 = val3.GetKeyValue("MenuManager", "FolderGenericIcon");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					MenuManagerConfig.FolderGenericIcon = text5.Trim();
				}
				text5 = val3.GetKeyValue("MenuManager", "DesktopRepeatColumns");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					MenuManagerConfig.DesktopRepeatColumns = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("StandardGridManager", "SelectByRightClickMode");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					StandardGrigManager.SelectByRightClickMode = text5.Trim();
				}
				text5 = val3.GetKeyValue("StandardGridManager", "ShowMenuActionButton");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					StandardGrigManager.ShowMenuActionButton = Operators.CompareString(text5.Trim(), "S", false) == 0;
				}
				text5 = val3.GetKeyValue("StandardGridManager", "FilterVersion");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					StandardGrigManager.FilterVersion = text5.Trim();
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "ViewStateSaveMode");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					WFIPageConfig.ViewStateSaveMode = text5.Trim();
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "ViewStateSaveModePages");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					string[] array15 = text5.Split(new char[1] { ',' });
					string[] array16 = array15;
					foreach (string text7 in array16)
					{
						WFIPageConfig.ViewStateSaveModePages.Add(text7.ToUpper());
					}
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "DebugAsyncTimeout");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5.Trim()))
				{
					WFIPageConfig.DebugAsyncTimeout = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "ReleaseAsyncTimeout");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5.Trim()))
				{
					WFIPageConfig.ReleaseAsyncTimeout = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "LastActivityRealTime");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					WFIPageConfig.LastActivityRealTime = Operators.CompareString(text5.Trim(), "S", false) == 0;
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "LastActivityRealTimeInterval");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5.Trim()))
				{
					WFIPageConfig.LastActivityRealTimeInterval = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("WFIPageConfig", "KeepAliveFrequency");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5.Trim()))
				{
					WFIPageConfig.KeepAliveFrequency = Conversions.ToInteger(text5.Trim());
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Enable");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Enable = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Type");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Type = text5.ToUpper();
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "RelativeTo");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.RelativeTo = text5;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Position");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Position = text5;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "ContentScrolling");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.ContentScrolling = text5;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Animation");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.Animation = text5;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "AnimationDuration");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5))
				{
					AutoTooltipifyConfig.AnimationDuration = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Width");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5))
				{
					AutoTooltipifyConfig.Width = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "Height");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5))
				{
					AutoTooltipifyConfig.Height = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "ShowCallout");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.ShowCallout = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "AutoCloseDelay");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5))
				{
					AutoTooltipifyConfig.AutoCloseDelay = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "NotCloseIfHover");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.NotCloseIfHover = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "ShowDelay");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0 && Versioned.IsNumeric((object)text5))
				{
					AutoTooltipifyConfig.ShowDelay = Conversions.ToInteger(text5);
				}
				text5 = val3.GetKeyValue("AutoTooltipify", "NotCloseIfHover");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					AutoTooltipifyConfig.TooltipByIdEnabled = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text5 = val3.GetKeyValue("LoginManager", "RememberMe");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						LoginManagerConfig.RememberMe = text5;
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "CryptographyEnable");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						LoginManagerConfig.CryptographyEnable = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "PasswordValidationAlgorithm");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.PasswordValidationAlgorithm = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "PreferredPasswordLength");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.PreferredPasswordLength = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "MinumumPasswordLength");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.MinumumPasswordLength = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "MinimumNumericCharacters");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.MinimumNumericCharacters = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "MinimumSymbolCharacters");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.MinimumSymbolCharacters = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "MinimumUpperCaseCharacters");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.MinimumUpperCaseCharacters = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "MinimumLowerCaseCharacters");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.MinimumLowerCaseCharacters = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "PasswordValidityTime");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.PasswordValidityTime = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "EnableIdentityChange");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						LoginManagerConfig.EnableIdentityChange = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "IdentityChangeUserList");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						string[] array17 = text5.Split(new char[1] { ',' });
						string[] array18 = array17;
						foreach (string value2 in array18)
						{
							LoginManagerConfig.IdentityChangeUserList.Add(value2);
						}
					}
				}
				text5 = val3.GetKeyValue("LoginManager", "PasswordErrorBlockUserAfter");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						LoginManagerConfig.PasswordErrorBlockUserAfter = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Enabled");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.enabled = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Message");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.message = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AcceptButton");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.acceptButton = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AcceptText");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.acceptText = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "DeclineButton");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.declineButton = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "DeclineText");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.declineText = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "PolicyButton");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.policyButton = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "PolicyText");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.policyText = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "PolicyURL");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.policyURL = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AutoEnable");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.autoEnable = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AcceptOnContinue");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.acceptOnContinue = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AcceptOnScroll");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.acceptOnScroll = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "AcceptAnyClick");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.acceptAnyClick = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "ExpireDays");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0 && Versioned.IsNumeric((object)text5))
					{
						CookiesConfig.expireDays = Conversions.ToInteger(text5);
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "RenewOnVisit");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.renewOnVisit = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "ForceShow");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.forceShow = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Effect");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.effect = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Element");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					CookiesConfig.element = text5;
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Append");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.append = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Fixed");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.@fixed = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				text5 = val3.GetKeyValue("Cookiesbar", "Bottom");
				if (text5 != null)
				{
					text5 = text5.Trim();
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CookiesConfig.bottom = Operators.CompareString(text5.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				ExistsConfig = true;
			}
			if (File.Exists(WFIDbIniFile))
			{
				IniFile val4 = new IniFile();
				val4.Load(WFIDbIniFile, false);
				string text8 = "";
				string text9 = "";
				text5 = val4.GetKeyValue("Default", "DefaultConnectionName");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					text8 = text5.Trim();
				}
				string connectionName = text8;
				WFIDbConnectionConfig DBConfig = DefaultDBConnectionConfig;
				GetDBConfigurationFromINI(val4, connectionName, ref DBConfig);
				DefaultDBConnectionConfig = DBConfig;
				text5 = val4.GetKeyValue("Default", "ConnectionList");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					text9 = text5.Trim();
				}
				if (Operators.CompareString(text9, "", false) != 0)
				{
					string[] array19 = text9.Split(new char[1] { ',' });
					foreach (string text10 in array19)
					{
						if (!DBConnectionListConfig.ContainsKey(text10))
						{
							WFIDbConnectionConfig DBConfig2 = new WFIDbConnectionConfig();
							GetDBConfigurationFromINI(val4, text10, ref DBConfig2);
							DBConnectionListConfig.Add(text10, DBConfig2);
						}
					}
				}
			}
			if (File.Exists(AppDbIniFile))
			{
				IniFile val5 = new IniFile();
				val5.Load(AppDbIniFile, false);
				string text11 = "";
				string text12 = "";
				text5 = val5.GetKeyValue("Default", "DefaultConnectionName");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					text11 = text5.Trim();
				}
				string connectionName2 = text11;
				WFIDbConnectionConfig DBConfig = DefaultDBConnectionConfig;
				GetDBConfigurationFromINI(val5, connectionName2, ref DBConfig);
				DefaultDBConnectionConfig = DBConfig;
				text5 = val5.GetKeyValue("Default", "ConnectionList");
				if (text5 != null && Operators.CompareString(text5.Trim(), "", false) != 0)
				{
					text12 = text5.Trim();
				}
				if (Operators.CompareString(text12, "", false) != 0)
				{
					string[] array20 = text12.Split(new char[1] { ',' });
					foreach (string text13 in array20)
					{
						if (DBConnectionListConfig.ContainsKey(text13))
						{
							DBConnectionListConfig.Remove(text13);
						}
						WFIDbConnectionConfig DBConfig3 = new WFIDbConnectionConfig();
						GetDBConfigurationFromINI(val5, text13, ref DBConfig3);
						DBConnectionListConfig.Add(text13, DBConfig3);
					}
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		Initialized = true;
	}

	protected void GetDBConfigurationFromINI(IniFile iniF, string ConnectionName, ref WFIDbConnectionConfig DBConfig)
	{
		string text = "";
		if (Operators.CompareString(ConnectionName, "", false) != 0)
		{
			DBConfig.DB_Key = ConnectionName;
			text = iniF.GetKeyValue(ConnectionName, "DB_Provider");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Provider = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_ServerType");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_ServerType = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_UseIntegratedSecurity");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_UseIntegratedSecurity = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_TimeOut");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_TimeOut = Conversions.ToInteger(text.Trim());
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_ProviderType");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_ProviderType = text.Trim().ToUpper();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_Username");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Username = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_Server");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Server = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_Password");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Password = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_Database");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Database = text.Trim();
			}
			text = iniF.GetKeyValue(ConnectionName, "DB_Description");
			if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
			{
				DBConfig.DB_Description = text.Trim();
			}
		}
	}
}
