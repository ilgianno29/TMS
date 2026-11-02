using System;
using System.IO;
using CoreWCF.Configuration;
using CoreWCF.Description;
using Incasbo;
using Incasbo.ServiceModel;
using Incasbo.Web.Host;
using Incasbo.Web.Host.Asmx;
using Incasbo.Web.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<GdoWscOptions>(builder.Configuration.GetSection("GdoWSC"));
GdoWscOptions options = builder.Configuration.GetSection("GdoWSC").Get<GdoWscOptions>() ?? new GdoWscOptions();

// Cartella dell'applicazione (IniConfig\, Log\): prima era la cartella del sito IIS
string applicationRoot = string.IsNullOrWhiteSpace(options.ApplicationRoot) ? builder.Environment.ContentRootPath : options.ApplicationRoot;
WscHosting.Initialize(applicationRoot);

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<CoreWCF.Description.IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();
builder.Services.AddHostedService<BackgroundMaintenanceService>();

// GdoWSC.asmx: sessione InProc e cookie di login come in ASP.NET classico
builder.Services.Configure<AsmxOptions>(builder.Configuration.GetSection("GdoWSC:Asmx"));
builder.Services.AddDataProtection();
builder.Services.AddSingleton<AsmxSessionStore>();
builder.Services.AddSingleton<FormsAuthCookie>();
builder.Services.AddSingleton<AsmxSoapEndpoint<Incasbo.Web.WSC.GdoWSC>>();
builder.Services.AddHostedService<AsmxSessionCleanupService>();

WebApplication app = builder.Build();

// Client WCF verso WMS e PTV: stessi indirizzi del vecchio Web.config
string clientConfig = Path.Combine(WscHosting.ApplicationRoot, options.WcfClientConfigFile ?? "");
if (!string.IsNullOrWhiteSpace(options.WcfClientConfigFile) && File.Exists(clientConfig))
{
	int count = WcfEndpoints.LoadFromConfigFile(clientConfig);
	app.Logger.LogInformation("Caricati {Count} endpoint client WCF da {File}", count, clientConfig);
}
else
{
	app.Logger.LogWarning("File di configurazione dei client WCF non trovato: {File}", clientConfig);
}

app.UseServiceModel(serviceBuilder =>
{
	serviceBuilder.AddService<TMSServiceForWMS>(o => o.DebugBehavior.IncludeExceptionDetailInFaults = false);
	serviceBuilder.AddServiceEndpoint<TMSServiceForWMS, ITMSServiceForWMS>(Bindings.TMSServiceForWMS(), options.TMSServiceForWMSPath);

	serviceBuilder.AddService<TMSApiService>(o => o.DebugBehavior.IncludeExceptionDetailInFaults = false);
	serviceBuilder.AddServiceEndpoint<TMSApiService, ITMSApiService>(Bindings.TMSApiService(), options.TMSApiServicePath);

	// Nel Web.config originale includeExceptionDetailInFaults="true" solo per questo servizio
	serviceBuilder.AddService<TMSServiceForMap>(o => o.DebugBehavior.IncludeExceptionDetailInFaults = true);
	serviceBuilder.AddServiceEndpoint<TMSServiceForMap, ITMSServiceForMap>(Bindings.TMSServiceForMap(), options.TMSServiceForMapPath);
});

// Servizio ASMX (login del portale)
AsmxOptions asmxOptions = app.Services.GetRequiredService<IOptions<AsmxOptions>>().Value;
app.Map(asmxOptions.Path, branch => branch.Run(http => http.RequestServices.GetRequiredService<AsmxSoapEndpoint<Incasbo.Web.WSC.GdoWSC>>().HandleAsync(http)));

// WSDL via HTTP GET (?wsdl), come serviceMetadata httpGetEnabled="true"
ServiceMetadataBehavior metadata = app.Services.GetRequiredService<ServiceMetadataBehavior>();
metadata.HttpGetEnabled = true;

app.Run();

/// <summary>Esposto per i test di integrazione.</summary>
public partial class Program { }
