using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Incasbo.ServiceModel;
using Xunit;

namespace Delsy.Tests;

// I test modificano un registro statico: niente esecuzione in parallelo
[CollectionDefinition("WcfEndpoints", DisableParallelization = true)]
public class WcfEndpointsCollection { }

[Collection("WcfEndpoints")]
public class WcfEndpointsTests : IDisposable
{
    public WcfEndpointsTests() => WcfEndpoints.Clear();
    public void Dispose() => WcfEndpoints.Clear();

    private const string WebConfig = """
        <?xml version="1.0" encoding="utf-8"?>
        <configuration>
          <system.serviceModel>
            <bindings>
              <basicHttpBinding>
                <binding name="WmsBinding" maxReceivedMessageSize="1048576" sendTimeout="00:02:00" />
              </basicHttpBinding>
            </bindings>
            <client>
              <endpoint address="http://wms-server/TmsService.svc" binding="basicHttpBinding"
                        bindingConfiguration="WmsBinding" contract="WMSService.IwmsServiceForTMS" name="BasicHttpBinding_IwmsServiceForTMS" />
              <endpoint address="https://ptv-server/xlocate/ws/XLocate" binding="basicHttpBinding"
                        contract="xLocate.XLocateWS" name="XLocateWSPort" />
            </client>
          </system.serviceModel>
        </configuration>
        """;

    private static string WriteConfig(string xml)
    {
        string path = Path.Combine(Path.GetTempPath(), "delsy-test-" + Guid.NewGuid() + ".config");
        File.WriteAllText(path, xml);
        return path;
    }

    [Fact]
    public void Carica_gli_endpoint_dal_vecchio_web_config()
    {
        string path = WriteConfig(WebConfig);
        try
        {
            Assert.Equal(2, WcfEndpoints.LoadFromConfigFile(path));

            // costruttore senza parametri: ricerca per contratto (come faceva WCF con il web.config)
            using var wms = new Incasbo.WMSService.IwmsServiceForTMSClient();
            Assert.Equal("http://wms-server/TmsService.svc", wms.Endpoint.Address.Uri.ToString());
            var wmsBinding = Assert.IsType<BasicHttpBinding>(wms.Endpoint.Binding);
            Assert.Equal(1048576, wmsBinding.MaxReceivedMessageSize);
            Assert.Equal(TimeSpan.FromMinutes(2), wmsBinding.SendTimeout);
            Assert.Equal(BasicHttpSecurityMode.None, wmsBinding.Security.Mode);

            // costruttore con nome endpoint, come in LocateManager: new XLocateWSClient("XLocateWSPort")
            using var locate = new Incasbo.xLocate.XLocateWSClient("XLocateWSPort");
            Assert.Equal("https://ptv-server/xlocate/ws/XLocate", locate.Endpoint.Address.Uri.ToString());
            Assert.Equal(BasicHttpSecurityMode.Transport, Assert.IsType<BasicHttpBinding>(locate.Endpoint.Binding).Security.Mode);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void Endpoint_mancante_da_errore_chiaro()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => new Incasbo.WMSService.IwmsServiceForTMSClient());
        Assert.Contains("WMSService.IwmsServiceForTMS", ex.Message);
    }

    [Fact]
    public void Binding_non_supportato_da_errore_chiaro()
    {
        string path = WriteConfig(WebConfig.Replace("binding=\"basicHttpBinding\"", "binding=\"wsHttpBinding\""));
        try
        {
            Assert.Throws<NotSupportedException>(() => WcfEndpoints.LoadFromConfigFile(path));
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public async Task Chiamata_SOAP_reale_al_servizio_WMS()
    {
        // Finto servizio WMS locale che risponde a BeginTransaction
        int port = FreePort();
        using var listener = new HttpListener();
        listener.Prefixes.Add($"http://localhost:{port}/wms/");
        listener.Start();

        string? receivedAction = null;
        string? receivedBody = null;
        Task server = Task.Run(async () =>
        {
            var ctx = await listener.GetContextAsync();
            receivedAction = ctx.Request.Headers["SOAPAction"];
            using (var reader = new StreamReader(ctx.Request.InputStream)) receivedBody = await reader.ReadToEndAsync();
            byte[] response = Encoding.UTF8.GetBytes("""
                <s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
                  <s:Body>
                    <BeginTransactionResponse xmlns="http://tempuri.org/">
                      <BeginTransactionResult xmlns:a="http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms">
                        <a:Good>true</a:Good>
                        <a:Reason>ok dal WMS</a:Reason>
                      </BeginTransactionResult>
                    </BeginTransactionResponse>
                  </s:Body>
                </s:Envelope>
                """);
            ctx.Response.ContentType = "text/xml; charset=utf-8";
            await ctx.Response.OutputStream.WriteAsync(response);
            ctx.Response.Close();
        });

        WcfEndpoints.Register(null, "WMSService.IwmsServiceForTMS", $"http://localhost:{port}/wms/");
        var client = new Incasbo.WMSService.IwmsServiceForTMSClient();
        var result = await Task.Run(() => client.BeginTransaction());
        client.Close();
        await server;

        Assert.Equal("\"http://tempuri.org/IwmsServiceForTMS/BeginTransaction\"", receivedAction);
        Assert.Contains("<BeginTransaction xmlns=\"http://tempuri.org/\"", receivedBody);
        Assert.True(result.Good);
        Assert.Equal("ok dal WMS", result.Reason);
    }

    private static int FreePort()
    {
        var l = new TcpListener(IPAddress.Loopback, 0);
        l.Start();
        int port = ((IPEndPoint)l.LocalEndpoint).Port;
        l.Stop();
        return port;
    }
}
