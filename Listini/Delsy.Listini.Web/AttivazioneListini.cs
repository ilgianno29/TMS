using Delsy.Listini.Bozze;

namespace Delsy.Listini.Web;

/// <summary>Applica, ogni ora, le bozze approvate la cui data di applicazione è arrivata.</summary>
public sealed class AttivazioneListini(ServizioBozze bozze, ILogger<AttivazioneListini> log) : BackgroundService
{
	protected override async Task ExecuteAsync(CancellationToken stop)
	{
		using PeriodicTimer timer = new(TimeSpan.FromHours(1));
		do
		{
			try
			{
				foreach (string esito in bozze.ApplicaInAttesa(DateTime.Today))
				{
					log.LogInformation("{Esito}", esito);
				}
			}
			catch (Exception e)
			{
				log.LogError(e, "Applicazione delle bozze in attesa non riuscita");
			}
		}
		while (await timer.WaitForNextTickAsync(stop));
	}
}
