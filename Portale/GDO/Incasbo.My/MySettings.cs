using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static Incasbo.My.MySettings defaultInstance = (Incasbo.My.MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Incasbo.My.MySettings());

	public static Incasbo.My.MySettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Incasbo.EFModels.DELSYEntities")]
	public string EntitiesTypeName => Conversions.ToString(((ApplicationSettingsBase)this)["EntitiesTypeName"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~\\bin\\DelsyEntities.csdl")]
	public string EntitiesCsdlFileName => Conversions.ToString(((ApplicationSettingsBase)this)["EntitiesCsdlFileName"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~\\bin\\DelsyEntities.ssdl")]
	public string EntitiesSsdlFileName => Conversions.ToString(((ApplicationSettingsBase)this)["EntitiesSsdlFileName"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~\\bin\\DelsyEntities.msl")]
	public string EntitiesMslFileName => Conversions.ToString(((ApplicationSettingsBase)this)["EntitiesMslFileName"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("DelsyEntities")]
	public string EntitiesAssemblyName => Conversions.ToString(((ApplicationSettingsBase)this)["EntitiesAssemblyName"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.WebServiceUrl)]
	[DefaultSettingValue("http://www.mioc.it/index.php")]
	public string GDO_Mioc_server => Conversions.ToString(((ApplicationSettingsBase)this)["GDO_Mioc_server"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://sbotest01:50010")]
	public string xMap_Server => Conversions.ToString(((ApplicationSettingsBase)this)["xMap_Server"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.WebServiceUrl)]
	[DefaultSettingValue("http://lucart-platform-qa.tesisquare.com:80/webservices/prenotazionioutbound.cfc")]
	public string GDO_MiocNew_prenotazionioutboundWS => Conversions.ToString(((ApplicationSettingsBase)this)["GDO_MiocNew_prenotazionioutboundWS"]);

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.WebServiceUrl)]
	[DefaultSettingValue("http://lucart-platform-qa.tesisquare.com:80/webservices/creazioneviaggio.cfc")]
	public string GDO_Tesi_creazioneviaggio => Conversions.ToString(((ApplicationSettingsBase)this)["GDO_Tesi_creazioneviaggio"]);
}
