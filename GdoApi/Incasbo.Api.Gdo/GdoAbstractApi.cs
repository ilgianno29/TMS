using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

public abstract class GdoAbstractApi : AppAbstractApi
{
	private static IboLabel _objIboLabel = null;


	/// <summary>
	/// Cartella dell'applicazione (come My.Application.Info.DirectoryPath di VB):
	/// cartella dell'eseguibile, oppure di questa DLL quando gira dentro IIS.
	/// </summary>
	protected static string ApplicationDirectory
	{
		get
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetEntryAssembly() ?? typeof(GdoAbstractApi).Assembly;
			return System.IO.Path.GetDirectoryName(assembly.Location);
		}
	}

	protected IboLabel objIboLabel
	{
		get
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			if (_objIboLabel == null)
			{
				_objIboLabel = new IboLabel(this._ApiContext);
				IboLabel iboLabel = _objIboLabel;
				string fileDir = ApplicationDirectory + "\\Labels\\";
				string fileCustomDir = ApplicationDirectory + "\\Custom\\Labels\\";
				string rsmess = "";
				iboLabel.LoadConfig(fileDir, fileCustomDir, ref rsmess);
			}
			return _objIboLabel;
		}
	}

	protected ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)this._ApiContext.AppDefault;

	protected ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public GdoAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}
}
