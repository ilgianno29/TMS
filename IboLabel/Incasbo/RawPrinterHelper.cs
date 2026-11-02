using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo;

public class RawPrinterHelper
{
	public struct PRINTER_DEFAULTS
	{
		public IntPtr pDatatype;

		public IntPtr pDevMode;

		public int DesiredAccess;
	}

	public struct OpenPrinterAccessCodes
	{
		public const int DELETE = 65536;

		public const int READ_CONTROL = 131072;

		public const int WRITE_DAC = 262144;

		public const int WRITE_OWNER = 524288;

		public const int SERVER_ACCESS_ADMINISTER = 1;

		public const int SERVER_ACCESS_ENUMERATE = 2;

		public const int PRINTER_ACCESS_ADMINISTER = 4;

		public const int PRINTER_ACCESS_USE = 8;

		public const int STANDARD_RIGHTS_REQUIRED = 983040;

		public const int PRINTER_ALL_ACCESS = 983052;

		public const int SERVER_ALL_ACCESS = 983043;

		public const int MAX_PORTNAME_LEN = 64;

		public const int MAX_NETWORKNAME_LEN = 49;

		public const int MAX_SNMP_COMMUNITY_STR_LEN = 33;

		public const int MAX_QUEUENAME_LEN = 33;

		public const int MAX_IPADDR_STR_LEN = 16;

		public const int ERROR_INSUFFICIENT_BUFFER = 122;

		public const int ERROR_INVALID_FLAGS = 1004;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DOCINFOW
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pDocName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pOutputFile;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pDataType;
	}

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "OpenPrinterW", ExactSpelling = true, SetLastError = true)]
	private static extern bool OpenPrinter(string pPrinterName, ref IntPtr hPrinter, ref PRINTER_DEFAULTS pDefault);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern bool ClosePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "StartDocPrinterW", ExactSpelling = true, SetLastError = true)]
	public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFOW pDI);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndDocPrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern bool StartPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndPagePrinter(IntPtr hPrinter);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, ref int dwWritten);

	public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
	{
		DOCINFOW pDI = default(DOCINFOW);
		pDI.pDocName = "Delsy RAW Document";
		pDI.pDataType = "RAW";
		bool flag = false;
		PRINTER_DEFAULTS pDefault = default(PRINTER_DEFAULTS);
		pDefault.pDatatype = default(IntPtr);
		pDefault.pDevMode = IntPtr.Zero;
		pDefault.DesiredAccess = 8;
		IntPtr hPrinter = default(IntPtr);
		if (OpenPrinter(szPrinterName, ref hPrinter, ref pDefault))
		{
			if (StartDocPrinter(hPrinter, 1, ref pDI))
			{
				if (StartPagePrinter(hPrinter))
				{
					int dwWritten = default(int);
					flag = WritePrinter(hPrinter, pBytes, dwCount, ref dwWritten);
					EndPagePrinter(hPrinter);
				}
				EndDocPrinter(hPrinter);
			}
			ClosePrinter(hPrinter);
		}
		if (!flag)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
		}
		return flag;
	}

	public static bool SendFileToPrinter(string szPrinterName, string szFileName)
	{
		FileStream fileStream = new FileStream(szFileName, FileMode.Open);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		checked
		{
			byte[] array = new byte[(int)fileStream.Length + 1];
			array = binaryReader.ReadBytes((int)fileStream.Length);
			IntPtr intPtr = Marshal.AllocCoTaskMem((int)fileStream.Length);
			Marshal.Copy(array, 0, intPtr, (int)fileStream.Length);
			bool result = SendBytesToPrinter(szPrinterName, intPtr, (int)fileStream.Length);
			Marshal.FreeCoTaskMem(intPtr);
			return result;
		}
	}

	public static void SendStringToPrinter(string szPrinterName, string szString)
	{
		int length = szString.Length;
		IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(szString);
		SendBytesToPrinter(szPrinterName, intPtr, length);
		Marshal.FreeCoTaskMem(intPtr);
	}

	// SendStringToPrinterVB6 rimosso: usava la libreria VB6 PowerPacks (obsoleta) e non era chiamato da nessuna parte.
}
