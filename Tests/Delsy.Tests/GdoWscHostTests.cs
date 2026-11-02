using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using Xunit;

namespace Delsy.Tests;

/// <summary>
/// Verifica che i servizi WCF ospitati in .NET 8 (CoreWCF) parlino lo stesso protocollo
/// dei servizi originali: stessi indirizzi, namespace, SOAP 1.1 / SOAP 1.2 + WS-Addressing.
/// </summary>
/// <summary>Avvia il vero host (GdoWSC.Host.dll) su Kestrel, come in produzione.</summary>
public sealed class GdoWscHostFixture : IDisposable
{
    private readonly Process _process;
    public HttpClient Client { get; }

    public GdoWscHostFixture()
    {
        var l = new TcpListener(IPAddress.Loopback, 0);
        l.Start();
        int port = ((IPEndPoint)l.LocalEndpoint).Port;
        l.Stop();

        string dll = Path.Combine(AppContext.BaseDirectory, "GdoWSC.Host.dll");
        var psi = new ProcessStartInfo("dotnet", $"\"{dll}\" --urls http://localhost:{port} --GdoWSC:BackgroundMaintenanceEnabled=false")
        {
            WorkingDirectory = AppContext.BaseDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false
        };
        _process = Process.Start(psi)!;
        _process.OutputDataReceived += (_, _) => { };
        _process.ErrorDataReceived += (_, _) => { };
        _process.BeginOutputReadLine();
        _process.BeginErrorReadLine();

        Client = new HttpClient { BaseAddress = new Uri($"http://localhost:{port}") };
        var deadline = DateTime.UtcNow.AddSeconds(60);
        while (true)
        {
            try
            {
                if (Client.GetAsync("/TMSApiService.svc?wsdl").Result.IsSuccessStatusCode) break;
            }
            catch (Exception) when (DateTime.UtcNow < deadline) { }
            if (_process.HasExited) throw new InvalidOperationException("GdoWSC.Host terminato all'avvio");
            if (DateTime.UtcNow > deadline) throw new TimeoutException("GdoWSC.Host non risponde");
            System.Threading.Thread.Sleep(250);
        }
    }

    public void Dispose()
    {
        Client.Dispose();
        if (!_process.HasExited) _process.Kill(entireProcessTree: true);
        _process.Dispose();
    }
}

public class GdoWscHostTests : IClassFixture<GdoWscHostFixture>
{
    private readonly HttpClient _client;

    public GdoWscHostTests(GdoWscHostFixture fixture)
    {
        _client = fixture.Client;
    }

    [Theory]
    [InlineData("/TMSApiService.svc", "http://www.incasgroup.com/bologna/GdoApiService", "soap:binding")]
    [InlineData("/TMSServiceForWMS.svc", "http://www.incasgroup.com/bologna/GdoWSCWCF", "soap12:binding")]
    [InlineData("/TMSServiceForMap.svc", "http://www.incasgroup.com/bologna/TMSServiceForMap", "soap12:binding")]
    public async Task Pubblica_il_WSDL_con_namespace_e_binding_originali(string path, string ns, string binding)
    {
        string wsdl = await _client.GetStringAsync(path + "?wsdl");
        Assert.Contains(ns, wsdl);
        Assert.Contains(binding, wsdl);
    }

    [Theory]
    [InlineData("/TMSServiceForWMS.svc", 26)]
    [InlineData("/TMSApiService.svc", 23)]
    [InlineData("/TMSServiceForMap.svc", 5)]
    public async Task WSDL_contiene_tutte_le_operazioni(string path, int expected)
    {
        string wsdl = await _client.GetStringAsync(path + "?wsdl");
        // ogni operazione compare una volta nel portType (con wsdl:input ... message=)
        var names = new System.Collections.Generic.HashSet<string>();
        foreach (Match m in Regex.Matches(wsdl, "<wsdl:operation name=\"([A-Za-z_]+)\""))
        {
            names.Add(m.Groups[1].Value);
        }
        Assert.Equal(expected, names.Count);
    }

    [Fact]
    public async Task TMSApiService_risponde_in_SOAP_11()
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "/TMSApiService.svc")
        {
            Content = new StringContent(
                "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\"><s:Body>" +
                "<TestPing xmlns=\"http://www.incasgroup.com/bologna/GdoApiService\"><sStringa>ciao</sStringa></TestPing>" +
                "</s:Body></s:Envelope>", Encoding.UTF8, "text/xml")
        };
        request.Headers.Add("SOAPAction", "\"http://www.incasgroup.com/bologna/GdoApiService/ITMSApiService/TestPing\"");

        var response = await _client.SendAsync(request);
        string body = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("<TestPingResult>RISPOSTA: ciao - ", body);
    }

    [Theory]
    [InlineData("/TMSServiceForWMS.svc", "http://www.incasgroup.com/bologna/GdoWSCWCF", "ITMSServiceForWMS")]
    [InlineData("/TMSServiceForMap.svc", "http://www.incasgroup.com/bologna/TMSServiceForMap", "ITMSServiceForMap")]
    public async Task Servizi_wsHttp_rispondono_in_SOAP_12_con_WS_Addressing(string path, string ns, string contract)
    {
        string action = $"{ns}/{contract}/TestPing";
        string envelope =
            "<s:Envelope xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:a=\"http://www.w3.org/2005/08/addressing\"><s:Header>" +
            $"<a:Action s:mustUnderstand=\"1\">{action}</a:Action>" +
            "<a:MessageID>urn:uuid:11111111-2222-3333-4444-555555555555</a:MessageID>" +
            "<a:ReplyTo><a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address></a:ReplyTo>" +
            $"<a:To s:mustUnderstand=\"1\">http://localhost{path}</a:To></s:Header><s:Body>" +
            $"<TestPing xmlns=\"{ns}\"><sStringa>ciao</sStringa></TestPing></s:Body></s:Envelope>";
        var content = new StringContent(envelope, Encoding.UTF8);
        content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse(
            $"application/soap+xml; charset=utf-8; action=\"{action}\"");

        var response = await _client.PostAsync(path, content);
        string body = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains($"{action}Response</a:Action>", body);
        Assert.Contains("<a:RelatesTo>urn:uuid:11111111-2222-3333-4444-555555555555</a:RelatesTo>", body);
        Assert.Contains("<TestPingResult>RISPOSTA: ciao - ", body);
    }

    [Fact]
    public async Task GdoWSC_asmx_pubblica_il_WSDL_con_le_7_operazioni()
    {
        string wsdl = await _client.GetStringAsync("/GdoWSC.asmx?WSDL");
        foreach (string op in new[] { "LogIn", "LogOut", "isAuthenticate", "GetDateTime", "TestDBConnection", "GetVersion", "TestPing" })
        {
            Assert.Contains($"soapAction=\"http://www.incasgroup.com/bologna/GdoWSC/{op}\"", wsdl);
        }
    }

    [Fact]
    public async Task GdoWSC_asmx_TestPing_e_isAuthenticate_con_sessione()
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "/GdoWSC.asmx")
        {
            Content = new StringContent(
                "<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body>" +
                "<TestPing xmlns=\"http://www.incasgroup.com/bologna/GdoWSC\"><sStringa>ciao</sStringa></TestPing>" +
                "</soap:Body></soap:Envelope>", Encoding.UTF8, "text/xml")
        };
        request.Headers.Add("SOAPAction", "\"http://www.incasgroup.com/bologna/GdoWSC/TestPing\"");
        var response = await _client.SendAsync(request);
        string body = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("<TestPingResult>RISPOSTA: ciao - ", body);
        Assert.Contains(response.Headers.GetValues("Set-Cookie"), c => c.StartsWith("ASP.NET_SessionId="));

        var auth = new HttpRequestMessage(HttpMethod.Post, "/GdoWSC.asmx")
        {
            Content = new StringContent(
                "<soap12:Envelope xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"><soap12:Body>" +
                "<isAuthenticate xmlns=\"http://www.incasgroup.com/bologna/GdoWSC\" /></soap12:Body></soap12:Envelope>", Encoding.UTF8)
        };
        auth.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse(
            "application/soap+xml; charset=utf-8; action=\"http://www.incasgroup.com/bologna/GdoWSC/isAuthenticate\"");
        string authBody = await (await _client.SendAsync(auth)).Content.ReadAsStringAsync();
        Assert.Contains("<isAuthenticateResult>false</isAuthenticateResult>", authBody);
    }
}
