using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public interface IIboProxyApiFunctions
{
	FXRETURN CallApiFunction(string sFunctionName, ref FunctionArguments robjFunctionArguments, ref IboSessionEnvironment rObjSessionEnvironment, ref WFIPage _Page, ref string rsWarning, ref bool ReturnToCaller, ref string rsMess);
}
