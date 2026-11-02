// SEGNAPOSTO TEMPORANEO: l'originale (IboCRW.cs) dipende da Crystal Reports,
// non disponibile in questo ambiente e non supportato su .NET moderno.
using System;
using System.Collections.Generic;
using Incasbo.Web.Library;

namespace Incasbo.Api.App;

public class IboCRW
{
	public IboCRW(ref AppApiContext ApiContext) { }

	public virtual modGeneral.FXRETURN CrystalReportToPDF(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, Dictionary<string, object> ReportParams, ref string rsNomeFileCompletoGenerato, ref bool StampaAsincrona, ref string rsMess)
		=> throw new NotSupportedException("Crystal Reports da sostituire");

	public virtual modGeneral.FXRETURN ViewToCsvFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, string Title, string SubTitle, bool IncludeColumnsName, ref string rsNomeFileCompletoGenerato, ref string rsMess)
		=> throw new NotSupportedException("Crystal Reports da sostituire");

	public virtual modGeneral.FXRETURN ViewToHtmlFile(string vsNomeReport, string vsNomeFileExport, string vsSelectionFormula, string vsHumanReadableSelectionFormula, string Title, string SubTitle, bool IncludeColumnsName, ref string rsNomeFileCompletoGenerato, ref string rsMess)
		=> throw new NotSupportedException("Crystal Reports da sostituire");
}
