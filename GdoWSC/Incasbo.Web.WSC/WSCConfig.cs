using System;
using System.IO;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSC;

public class WSCConfig
{
	public WSCDebugConfig DebugConfig { get; set; }

	public WSCApplicationConfig ApplicationConfig { get; set; }

	public WSCBackgroundActivityConfig BackgroundActivityConfig { get; set; }

	public bool ExistsConfig { get; set; }

	public bool Initialized { get; set; }

	public WSCDbConnectionConfig DefaultDBConnectionConfig { get; set; }

	public WSCLogConfig LogConfig { get; set; }

	public WSCTablesConfig TablesConfig { get; set; }

	public WFILoginManagerConfig LoginManagerConfig { get; set; }

	public WSCConfig()
	{
		bool existsConfig = false;
		ExistsConfig = existsConfig;
		existsConfig = false;
		Initialized = existsConfig;
		DebugConfig = new WSCDebugConfig();
		ApplicationConfig = new WSCApplicationConfig();
		BackgroundActivityConfig = new WSCBackgroundActivityConfig();
		DefaultDBConnectionConfig = new WSCDbConnectionConfig();
		LogConfig = new WSCLogConfig();
		TablesConfig = new WSCTablesConfig();
		LoginManagerConfig = new WFILoginManagerConfig();
	}

	public void Init(string AppIniFile, string AppDbIniFile)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		try
		{
			string text = "";
			if (File.Exists(AppIniFile))
			{
				IniFile val = new IniFile();
				val.Load(AppIniFile, false);
				text = val.GetKeyValue("Debug", "DebugMode");
				if (text != null)
				{
					DebugConfig.DebugMode = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val.GetKeyValue("Debug", "UserDebug");
				if (text != null)
				{
					DebugConfig.UserDebug = text.Trim().ToUpper();
				}
				text = val.GetKeyValue("Debug", "InterfaceMode");
				if (text != null)
				{
					DebugConfig.InterfaceMode = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val.GetKeyValue("BackGroundActivity", "BackgroundActivityTypeName");
				if (text != null)
				{
					BackgroundActivityConfig.BackgroundActivityTypeName = text;
				}
				text = val.GetKeyValue("Application", "LogoApplicazione");
				if (text != null)
				{
					ApplicationConfig.LogoApplicazione = text.Trim();
				}
				text = val.GetKeyValue("Application", "LogoDitta");
				if (text != null)
				{
					ApplicationConfig.LogoDitta = text.Trim();
				}
				text = val.GetKeyValue("Application", "LogoIncas");
				if (text != null)
				{
					ApplicationConfig.LogoIncas = text.Trim();
				}
				text = val.GetKeyValue("Application", "TitoloApplicazione");
				if (text != null)
				{
					ApplicationConfig.TitoloApplicazione = text.Trim();
				}
				text = val.GetKeyValue("Application", "InfoIncas");
				if (text != null)
				{
					ApplicationConfig.InfoIncas = text.Trim();
				}
				text = val.GetKeyValue("Application", "InfoIncas");
				if (text != null)
				{
					ApplicationConfig.InfoIncas = text.Trim();
				}
				text = val.GetKeyValue("Application", "TitoloModuloSoftware");
				if (text != null)
				{
					ApplicationConfig.TitoloModuloSoftware = text.Trim();
				}
				text = val.GetKeyValue("Application", "TitoloModuloSoftwareAcronimo");
				if (text != null)
				{
					ApplicationConfig.TitoloModuloSoftwareAcronimo = text.Trim();
				}
				text = val.GetKeyValue("Log", "SQLLeftLength");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					LogConfig.SQLLeftLength = Conversions.ToInteger(text.Trim());
				}
				text = val.GetKeyValue("Log", "DayOfPermanenceInLog");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					LogConfig.DayOfPermanenceInLog = Conversions.ToInteger(text.Trim());
				}
				text = val.GetKeyValue("Log", "DayOfPermanenceOfFile");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					LogConfig.DayOfPermanenceOfFile = Conversions.ToInteger(text.Trim());
				}
				text = val.GetKeyValue("Tables", "SessionTable");
				if (text != null)
				{
					TablesConfig.SessionTable = text.Trim();
				}
				text = val.GetKeyValue("Tables", "EventLogTable");
				if (text != null)
				{
					TablesConfig.EventLogTable = text.Trim();
				}
				text = val.GetKeyValue("Tables", "UserTable");
				if (text != null)
				{
					TablesConfig.UserTable = text.Trim();
				}
				text = val.GetKeyValue("LoginManager", "CryptographyEnable");
				if (text != null)
				{
					text = text.Trim();
					if (Operators.CompareString(text, "", false) != 0)
					{
						LoginManagerConfig.CryptographyEnable = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
					}
				}
				ExistsConfig = true;
			}
			if (File.Exists(AppDbIniFile))
			{
				IniFile val2 = new IniFile();
				val2.Load(AppDbIniFile, false);
				string text2 = "Main";
				text = val2.GetKeyValue("Default", "DefaultConnectionName");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					text2 = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_Provider");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Provider = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_ServerType");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_ServerType = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_UseIntegratedSecurity");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_UseIntegratedSecurity = Operators.CompareString(text.Trim().ToUpper(), "TRUE", false) == 0;
				}
				text = val2.GetKeyValue(text2, "DB_TimeOut");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_TimeOut = Conversions.ToInteger(text.Trim());
				}
				text = val2.GetKeyValue(text2, "DB_ProviderType");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_ProviderType = text.Trim().ToUpper();
				}
				text = val2.GetKeyValue(text2, "DB_Username");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Username = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_Server");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Server = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_Password");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Password = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_Database");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Database = text.Trim();
				}
				text = val2.GetKeyValue(text2, "DB_Description");
				if (text != null && Operators.CompareString(text.Trim(), "", false) != 0)
				{
					DefaultDBConnectionConfig.DB_Description = text.Trim();
				}
			}
			Initialized = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
