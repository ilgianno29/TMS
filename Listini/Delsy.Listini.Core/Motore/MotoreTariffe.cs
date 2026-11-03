using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;

namespace Delsy.Listini.Motore;

/// <summary>
/// Contesto per eseguire il motore tariffe originale di Delsy (GdoApi) da .NET 8,
/// costruito come fa GdoWSC (WSC_SessionEnvironment.CreateApiContext).
/// Ogni istanza ha la sua connessione: va usata da un solo thread e poi chiusa.
/// </summary>
public sealed class MotoreTariffe : IDisposable
{
	private readonly DBConnection _db;

	public AppApiContext Contesto { get; }

	private MotoreTariffe(DBConnection db, AppApiContext contesto)
	{
		_db = db;
		Contesto = contesto;
	}

	/// <param name="connectionString">Stringa di connessione SQL Server al database Delsy.</param>
	/// <param name="utente">Utente registrato da Delsy come autore dei calcoli (UteIns/UteAgg).</param>
	/// <param name="cartellaLog">Cartella in cui il motore scrive i propri log.</param>
	public static MotoreTariffe Apri(string connectionString, string utente, string cartellaLog)
	{
		Directory.CreateDirectory(cartellaLog);
		IboAppCallStackHandling callStack = new IboAppCallStackHandling();
		IboAppLogHandling log = new IboAppLogHandling();
		IncasTranslator translator = new IncasTranslator("IT");
		string mess = "";
		string sep = Path.DirectorySeparatorChar.ToString();
		log.Init("DelsyListini", utente, cartellaLog + sep + "DelsyListini.LOG", cartellaLog + sep + "DelsyListini.ERR", 2097152L, 2097152L, true, ref callStack, ref mess);

		DBConnection db = new DBConnection(connectionString, DBFormatFunctions.eServerType.SQL, 120, callStack, ref log, ref translator);
		if ((int)db.OpenConnection(ref mess) != 0)
		{
			throw new InvalidOperationException("Connessione al database Delsy non riuscita: " + mess);
		}
		IboWebParam parametrica = new IboWebParam(ref db, ref callStack, ref log, ref translator);

		AppApiContext ctx = new AppApiContext
		{
			DbConn = db,
			CallStackHandler = callStack,
			LogHandler = log,
			Parametrica = parametrica,
			Translator = translator,
			User = utente,
			Group = "",
			Organization = "",
			AppName = "DelsyListini",
			AppSessionId = Guid.NewGuid().ToString("N"),
			ApplicationRootDir = AppContext.BaseDirectory,
			DownloadDir = "Download" + sep,
			LogDir = "Log" + sep
		};
		ctx.AppDefault = new ApplicationDefault(ctx);
		ctx.AppParams = new ApplicationParams(ctx);
		return new MotoreTariffe(db, ctx);
	}

	public void Dispose()
	{
		string mess = "";
		try
		{
			_db.CloseConnection(ref mess);
		}
		finally
		{
			_db.Dispose();
		}
	}
}
