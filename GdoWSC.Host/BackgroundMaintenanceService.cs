using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Incasbo.Web.WSCWCF;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Incasbo.Web.Host;

/// <summary>
/// Manutenzione periodica dei servizi WCF: stessa logica di Global.asax
/// (BackgroundEventApplication), un ciclo ogni 60 secondi per i tre servizi.
/// </summary>
public sealed class BackgroundMaintenanceService : BackgroundService
{
	private readonly GdoWscOptions _options;
	private readonly ILogger<BackgroundMaintenanceService> _logger;

	public BackgroundMaintenanceService(IOptions<GdoWscOptions> options, ILogger<BackgroundMaintenanceService> logger)
	{
		_options = options.Value;
		_logger = logger;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		if (!_options.BackgroundMaintenanceEnabled)
		{
			return;
		}
		TimeSpan interval = TimeSpan.FromSeconds(Math.Max(1, _options.BackgroundMaintenanceIntervalSeconds));
		// Global.asax partiva dopo un primo timer di 5 secondi
		await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
		int cycle = 0;
		while (!stoppingToken.IsCancellationRequested)
		{
			cycle++;
			if (!Debugger.IsAttached)
			{
				RunMaintenance("TMSServiceForWMS", null, null, cycle);
				RunMaintenance("TMSApiService", "WCFDBConfig_Api.ini", "WSCWCFConfig_Api.ini", cycle);
				RunMaintenance("TMSServiceMap", "WCFDBConfig_TMSServiceMap.ini", "WSCWCFConfig_TMSServiceMap.ini", cycle);
			}
			await Task.Delay(interval, stoppingToken);
		}
	}

	private void RunMaintenance(string serviceName, string dbConfigFile, string appConfigFile, int cycle)
	{
		try
		{
			using IncasWCFInternal maintenance = new IncasWCFInternal();
			if (dbConfigFile != null)
			{
				maintenance.WSDBConfigFile = dbConfigFile;
			}
			if (appConfigFile != null)
			{
				maintenance.WSAppConfigFile = appConfigFile;
			}
			string rsMess = "";
			maintenance.Manutenzione(serviceName, cycle, ref rsMess);
			if (!string.IsNullOrEmpty(rsMess))
			{
				_logger.LogWarning("Manutenzione {Service}: {Message}", serviceName, rsMess);
			}
		}
		catch (Exception ex)
		{
			// Come in Global.asax un errore non deve fermare il ciclo, ma ora viene registrato
			_logger.LogError(ex, "Errore nella manutenzione di {Service}", serviceName);
		}
	}
}
