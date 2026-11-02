using System.Runtime.InteropServices;

namespace Incasbo.Web.Library;

internal class Win32API
{
	public const short FILE_ATTRIBUTE_NORMAL = 128;

	public const short INVALID_HANDLE_VALUE = -1;

	public const long GENERIC_READ = -2147483648L;

	public const uint GENERIC_WRITE = 1073741824u;

	public const uint CREATE_NEW = 1u;

	public const uint CREATE_ALWAYS = 2u;

	public const uint OPEN_EXISTING = 3u;

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "CreateFileA", ExactSpelling = true, SetLastError = true)]
	public static extern int CreateFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long CloseHandle(long hObject);
}
