using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public class IboWebUserUser : IboGenericWebUser
{
	public IboWebUserUser(string sCodice, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
		: base(sCodice, ref rObjCallStackHandler, ref rObjLogHandling, ref rObjDbMain, ref rObjParam, ref rObjWfiConfig)
	{
		NomeTabella = "VW_WFI_UTENTI";
	}
}
