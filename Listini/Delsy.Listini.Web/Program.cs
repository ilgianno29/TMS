using System.Security.Claims;
using Delsy.Listini.Accesso;
using Delsy.Listini.Bozze;
using Delsy.Listini.Web;
using Delsy.Listini.Dati;
using Delsy.Listini.Listini;
using Delsy.Listini.Motore;
using Delsy.Listini.Registro;
using Delsy.Listini.Spiegazione;
using Delsy.Listini.Web.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// La stringa di connessione non sta nel repository: appsettings.Production.json, variabile
// d'ambiente ConnectionStrings__Delsy oppure "dotnet user-secrets" in sviluppo.
string connectionString = builder.Configuration.GetConnectionString("Delsy") is { Length: > 0 } cs
	? cs
	: throw new InvalidOperationException("Manca la stringa di connessione ConnectionStrings:Delsy.");
bool cryptographyEnable = builder.Configuration.GetValue("Listini:CryptographyEnable", true);
string cartellaLog = Path.Combine(builder.Environment.ContentRootPath, builder.Configuration["Listini:CartellaLog"] ?? "log");

builder.Services.AddSingleton(new Db(connectionString));
builder.Services.AddSingleton(sp => new ServizioAccesso(sp.GetRequiredService<Db>(), cryptographyEnable));
builder.Services.AddSingleton<ServizioListini>();
builder.Services.AddSingleton<RegistroListini>();
builder.Services.AddSingleton<ServizioAnagrafiche>();
builder.Services.AddSingleton<ServizioBozze>();
builder.Services.AddHostedService<AttivazioneListini>();
builder.Services.AddScoped(sp => new ServizioSpiegazione(sp.GetRequiredService<Db>(),
	() => MotoreTariffe.Apri(connectionString, Utente(sp), cartellaLog)));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(o =>
	{
		o.LoginPath = "/accesso";
		o.LogoutPath = "/esci";
		o.ReturnUrlParameter = "ritorno";
		o.ExpireTimeSpan = TimeSpan.FromHours(10);
		o.SlidingExpiration = true;
		o.Cookie.Name = "DelsyListini";
		o.Cookie.HttpOnly = true;
		o.Cookie.SameSite = SameSiteMode.Lax;
		o.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
	});
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapPost("/esci", async (HttpContext ctx) =>
{
	await ctx.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
	return Results.LocalRedirect("/accesso");
});

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();

// Nei circuiti interattivi HttpContext non è disponibile: l'utente viene dallo stato di autenticazione (già risolto)
static string Utente(IServiceProvider sp) =>
	sp.GetRequiredService<AuthenticationStateProvider>().GetAuthenticationStateAsync().GetAwaiter().GetResult()
		.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "LISTINI";

/// <summary>Esposto per i test di integrazione.</summary>
public partial class Program;
