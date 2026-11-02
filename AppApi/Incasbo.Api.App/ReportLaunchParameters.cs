using System.Collections.Generic;

namespace Incasbo.Api.App;

public class ReportLaunchParameters
{
	public string NomeReport { get; set; }

	public string SelectionFormula { get; set; }

	public string HumanReadableSelectionFormula { get; set; }

	public Dictionary<string, object> ReportParams { get; set; }

	public ReportLaunchParameters()
	{
		string nomeReport = "";
		NomeReport = nomeReport;
		nomeReport = "";
		SelectionFormula = nomeReport;
		nomeReport = "";
		HumanReadableSelectionFormula = nomeReport;
	}
}
