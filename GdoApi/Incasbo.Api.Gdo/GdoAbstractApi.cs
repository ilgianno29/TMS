using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.My;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.ApplicationServices;

namespace Incasbo.Api.Gdo;

public abstract class GdoAbstractApi : AppAbstractApi
{
	private static IboLabel _objIboLabel = null;

	protected IboLabel objIboLabel
	{
		get
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			if (_objIboLabel == null)
			{
				_objIboLabel = new IboLabel(this._ApiContext);
				IboLabel iboLabel = _objIboLabel;
				string fileDir = ((ApplicationBase)Incasbo.My.MyProject.Application).Info.DirectoryPath + "\\Labels\\";
				string fileCustomDir = ((ApplicationBase)Incasbo.My.MyProject.Application).Info.DirectoryPath + "\\Custom\\Labels\\";
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
