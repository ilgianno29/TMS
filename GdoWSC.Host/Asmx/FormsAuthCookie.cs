using System;
using System.Globalization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Incasbo.Web.Host.Asmx;

/// <summary>
/// Cookie di login come &lt;authentication mode="Forms"&gt;: nome "GdoWSC", scadenza 10 minuti
/// con rinnovo automatico (slidingExpiration) quando e' passata piu' di meta' della durata.
/// Il contenuto e' cifrato e firmato con ASP.NET Core Data Protection.
/// </summary>
public sealed class FormsAuthCookie
{
	private readonly IDataProtector _protector;
	private readonly AsmxOptions _options;

	public FormsAuthCookie(IDataProtectionProvider provider, IOptions<AsmxOptions> options)
	{
		_protector = provider.CreateProtector("GdoWSC.FormsAuthentication.v1");
		_options = options.Value;
	}

	/// <summary>Legge l'utente dal cookie (null se assente, non valido o scaduto) e lo rinnova se serve.</summary>
	public string Read(HttpContext http)
	{
		if (!http.Request.Cookies.TryGetValue(_options.AuthCookieName, out string value) || string.IsNullOrEmpty(value))
		{
			return null;
		}
		try
		{
			string[] parts = _protector.Unprotect(value).Split('\n');
			string user = parts[0];
			DateTime issued = new DateTime(long.Parse(parts[1], CultureInfo.InvariantCulture), DateTimeKind.Utc);
			DateTime expires = new DateTime(long.Parse(parts[2], CultureInfo.InvariantCulture), DateTimeKind.Utc);
			bool persistent = parts.Length > 3 && parts[3] == "1";
			DateTime now = DateTime.UtcNow;
			if (now >= expires)
			{
				return null;
			}
			if (now - issued > (expires - issued) / 2)
			{
				Write(http, user, persistent);
			}
			return user;
		}
		catch (Exception)
		{
			// Cookie manomesso o emesso da un altro server: come se non ci fosse
			return null;
		}
	}

	public void Write(HttpContext http, string user, bool persistent)
	{
		DateTime issued = DateTime.UtcNow;
		DateTime expires = issued + _options.AuthTimeout;
		string payload = string.Join("\n", user ?? "", issued.Ticks.ToString(CultureInfo.InvariantCulture), expires.Ticks.ToString(CultureInfo.InvariantCulture), persistent ? "1" : "0");
		CookieOptions cookie = new CookieOptions
		{
			HttpOnly = true,
			Path = _options.AuthCookiePath,
			Secure = http.Request.IsHttps,
			SameSite = SameSiteMode.Lax
		};
		if (persistent)
		{
			cookie.Expires = expires;
		}
		http.Response.Cookies.Append(_options.AuthCookieName, _protector.Protect(payload), cookie);
	}

	public void Delete(HttpContext http)
	{
		http.Response.Cookies.Delete(_options.AuthCookieName, new CookieOptions { Path = _options.AuthCookiePath });
	}
}
