using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public interface IGridExporter
{
	string GetExportFileCompletePath { get; }

	string GetExportFileName { get; }

	void Init(ref IboSessionEnvironment robjSessionEnv, ref IboGridInfo rObjDataGrid);

	FXRETURN Execute(eGridExporterOutputFormat veOutputFormat, string Title, ref string rsMess);

	eGridExporterOutputFormat ConvertStringToOutputFormat(string vsStringValue);
}
