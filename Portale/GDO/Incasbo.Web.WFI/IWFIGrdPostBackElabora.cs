using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public interface IWFIGrdPostBackElabora
{
	FXRETURN WFIPostbackRun_Elabora(WFIPage frm, string CommandName, string CommandArgument, ref bool Elaborato, ref string rsMess);
}
