using System;

namespace Incasbo.Api.Statistics;

/// <summary>
/// Serializzazione JSON compatibile con il vecchio JavaScriptSerializer (System.Web.Extensions),
/// che non esiste su .NET 8. Il JSON finisce nella tabella WFI_Statistiche_Queue e viene letto
/// da altri processi: per questo il formato (nomi proprieta', enum numerici, date "\/Date(ms)\/")
/// resta identico.
/// </summary>
internal static class LegacyJson
{
	public static string Serialize(object value)
	{
#if NETFRAMEWORK
		return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(value);
#else
		System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions();
		options.Converters.Add(new MicrosoftDateTimeConverter());
		return System.Text.Json.JsonSerializer.Serialize(value, value?.GetType() ?? typeof(object), options);
#endif
	}

#if !NETFRAMEWORK
	private sealed class MicrosoftDateTimeConverter : System.Text.Json.Serialization.JsonConverter<DateTime>
	{
		public override DateTime Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
		{
			string s = reader.GetString() ?? "";
			if (s.StartsWith("/Date(", StringComparison.Ordinal))
			{
				long ms = long.Parse(s.Substring(6, s.IndexOf(')') - 6));
				return DateTimeOffset.FromUnixTimeMilliseconds(ms).UtcDateTime;
			}
			return DateTime.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
		}

		public override void Write(System.Text.Json.Utf8JsonWriter writer, DateTime value, System.Text.Json.JsonSerializerOptions options)
		{
			// JavaScriptSerializer converte in UTC e scrive i millisecondi dal 1/1/1970
			long ms = new DateTimeOffset(value.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(value, DateTimeKind.Local) : value).ToUnixTimeMilliseconds();
			writer.WriteRawValue("\"\\/Date(" + ms + ")\\/\"", skipInputValidation: true);
		}
	}
#endif
}
