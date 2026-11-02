using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Security;

public sealed class NetworkShare
{
	[StructLayout(LayoutKind.Sequential)]
	private class NETRESOURCE
	{
		public int dwScope;

		public int dwType;

		public int dwDisplayType;

		public int dwUsage;

		public string lpLocalName;

		public string lpRemoteName;

		public string lpComment;

		public string lpProvider;

		public NETRESOURCE()
		{
			dwScope = 0;
			dwType = 0;
			dwDisplayType = 0;
			dwUsage = 0;
			lpLocalName = "";
			lpRemoteName = "";
			lpComment = "";
			lpProvider = "";
		}
	}

	private struct ErrorClass
	{
		public int num;

		public string message;

		public ErrorClass(int num, string message)
		{
			this = default(ErrorClass);
			this.num = num;
			this.message = message;
		}
	}

	private const int RESOURCETYPE_DISK = 1;

	private const int CONNECT_UPDATE_PROFILE = 1;

	private const int NO_ERROR = 0;

	private const int ERROR_ACCESS_DENIED = 5;

	private const int ERROR_ALREADY_ASSIGNED = 85;

	private const int ERROR_BAD_DEVICE = 1200;

	private const int ERROR_BAD_NET_NAME = 67;

	private const int ERROR_BAD_PROVIDER = 1204;

	private const int ERROR_CANCELLED = 1223;

	private const int ERROR_EXTENDED_ERROR = 1208;

	private const int ERROR_INVALID_ADDRESS = 487;

	private const int ERROR_INVALID_PARAMETER = 87;

	private const int ERROR_INVALID_PASSWORD = 1216;

	private const int ERROR_MORE_DATA = 234;

	private const int ERROR_NO_MORE_ITEMS = 259;

	private const int ERROR_NO_NET_OR_BAD_PATH = 1203;

	private const int ERROR_NO_NETWORK = 1222;

	private const int ERROR_SESSION_CREDENTIAL_CONFLICT = 1219;

	private const int ERROR_BAD_PROFILE = 1206;

	private const int ERROR_CANNOT_OPEN_PROFILE = 1205;

	private const int ERROR_DEVICE_IN_USE = 2404;

	private const int ERROR_NOT_CONNECTED = 2250;

	private const int ERROR_OPEN_FILES = 2401;

	private static ErrorClass[] ERROR_LIST;

	static NetworkShare()
	{
		ErrorClass[] array = new ErrorClass[21];
		ref ErrorClass reference = ref array[0];
		ErrorClass errorClass = new ErrorClass(5, "Error: Access Denied");
		reference = errorClass;
		ref ErrorClass reference2 = ref array[1];
		ErrorClass errorClass2 = new ErrorClass(85, "Error: Already Assigned");
		reference2 = errorClass2;
		ref ErrorClass reference3 = ref array[2];
		ErrorClass errorClass3 = new ErrorClass(1200, "Error: Bad Device");
		reference3 = errorClass3;
		ref ErrorClass reference4 = ref array[3];
		ErrorClass errorClass4 = new ErrorClass(67, "Error: Bad Net Name");
		reference4 = errorClass4;
		ref ErrorClass reference5 = ref array[4];
		ErrorClass errorClass5 = new ErrorClass(1204, "Error: Bad Provider");
		reference5 = errorClass5;
		ref ErrorClass reference6 = ref array[5];
		ErrorClass errorClass6 = new ErrorClass(1223, "Error: Cancelled");
		reference6 = errorClass6;
		ref ErrorClass reference7 = ref array[6];
		ErrorClass errorClass7 = new ErrorClass(1208, "Error: Extended Error");
		reference7 = errorClass7;
		ref ErrorClass reference8 = ref array[7];
		ErrorClass errorClass8 = new ErrorClass(487, "Error: Invalid Address");
		reference8 = errorClass8;
		ref ErrorClass reference9 = ref array[8];
		ErrorClass errorClass9 = new ErrorClass(87, "Error: Invalid Parameter");
		reference9 = errorClass9;
		ref ErrorClass reference10 = ref array[9];
		ErrorClass errorClass10 = new ErrorClass(1216, "Error: Invalid Password");
		reference10 = errorClass10;
		ref ErrorClass reference11 = ref array[10];
		ErrorClass errorClass11 = new ErrorClass(234, "Error: More Data");
		reference11 = errorClass11;
		ref ErrorClass reference12 = ref array[11];
		ErrorClass errorClass12 = new ErrorClass(259, "Error: No More Items");
		reference12 = errorClass12;
		ref ErrorClass reference13 = ref array[12];
		ErrorClass errorClass13 = new ErrorClass(1203, "Error: No Net Or Bad Path");
		reference13 = errorClass13;
		ref ErrorClass reference14 = ref array[13];
		ErrorClass errorClass14 = new ErrorClass(1222, "Error: No Network");
		reference14 = errorClass14;
		ref ErrorClass reference15 = ref array[14];
		ErrorClass errorClass15 = new ErrorClass(1206, "Error: Bad Profile");
		reference15 = errorClass15;
		ref ErrorClass reference16 = ref array[15];
		ErrorClass errorClass16 = new ErrorClass(1205, "Error: Cannot Open Profile");
		reference16 = errorClass16;
		ref ErrorClass reference17 = ref array[16];
		ErrorClass errorClass17 = new ErrorClass(2404, "Error: Device In Use");
		reference17 = errorClass17;
		ref ErrorClass reference18 = ref array[17];
		ErrorClass errorClass18 = new ErrorClass(1208, "Error: Extended Error");
		reference18 = errorClass18;
		ref ErrorClass reference19 = ref array[18];
		ErrorClass errorClass19 = new ErrorClass(2250, "Error: Not Connected");
		reference19 = errorClass19;
		ref ErrorClass reference20 = ref array[19];
		ErrorClass errorClass20 = new ErrorClass(2401, "Error: Open Files");
		reference20 = errorClass20;
		ref ErrorClass reference21 = ref array[20];
		ErrorClass errorClass21 = new ErrorClass(1219, "Error: Credential Conflict");
		reference21 = errorClass21;
		ERROR_LIST = array;
	}

	private NetworkShare()
	{
	}

	public static string ConnectToShare(string uri, string username, string password)
	{
		NETRESOURCE nETRESOURCE = new NETRESOURCE();
		nETRESOURCE.dwType = 1;
		nETRESOURCE.lpRemoteName = uri;
		int num = WNetUseConnection(IntPtr.Zero, nETRESOURCE, password, username, 0, null, null, null);
		if (num == 0)
		{
			return null;
		}
		return GetError(num);
	}

	public static string DisconnectFromShare(string uri, bool force)
	{
		int num = WNetCancelConnection(uri, force);
		if (num == 0)
		{
			return null;
		}
		return GetError(num);
	}

	[DllImport("Mpr.dll")]
	private static extern int WNetUseConnection(IntPtr hwndOwner, NETRESOURCE lpNetResource, string lpPassword, string lpUserID, int dwFlags, string lpAccessName, string lpBufferSize, string lpResult);

	[DllImport("Mpr.dll")]
	private static extern int WNetCancelConnection(string lpName, bool fForce);

	private static string GetError(int errNum)
	{
		ErrorClass[] eRROR_LIST = ERROR_LIST;
		for (int i = 0; i < eRROR_LIST.Length; i = checked(i + 1))
		{
			ErrorClass errorClass = eRROR_LIST[i];
			if (errorClass.num == errNum)
			{
				return errorClass.message;
			}
		}
		return "Error: Unknown, " + Conversions.ToString(errNum);
	}
}
