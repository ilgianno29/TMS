using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

[StandardModule]
internal sealed class GlobalModule
{
	public static long StartedSessions;

	public static long EndedSessions;

	public static long CurrentSessions;

	public static long RequestCount;
}
