using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Incasbo.Security;

public class Impersonator : IDisposable
{
	private const int LOGON32_LOGON_INTERACTIVE = 2;

	private const int LOGON32_PROVIDER_DEFAULT = 0;

	private WindowsImpersonationContext impersonationContext;

	private bool disposedValue;

	public Impersonator(string userName, string domainName, string password)
	{
		impersonationContext = null;
		disposedValue = false;
		_impersonateValidUser(userName, domainName, password);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern int LogonUser(string lpszUserName, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int DuplicateToken(IntPtr hToken, int impersonationLevel, ref IntPtr hNewToken);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool RevertToSelf();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern bool CloseHandle(IntPtr handle);

	private void _impersonateValidUser(string userName, string domain, string password)
	{
		WindowsIdentity windowsIdentity = null;
		IntPtr phToken = IntPtr.Zero;
		IntPtr hNewToken = IntPtr.Zero;
		try
		{
			if (RevertToSelf())
			{
				if (LogonUser(userName, domain, password, 2, 0, ref phToken) != 0)
				{
					if (DuplicateToken(phToken, 2, ref hNewToken) != 0)
					{
						windowsIdentity = new WindowsIdentity(hNewToken);
						impersonationContext = windowsIdentity.Impersonate();
						return;
					}
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		finally
		{
			if (phToken != IntPtr.Zero)
			{
				CloseHandle(phToken);
			}
			if (hNewToken != IntPtr.Zero)
			{
				CloseHandle(hNewToken);
			}
		}
	}

	private void _undoImpersonation()
	{
		if (impersonationContext != null)
		{
			impersonationContext.Undo();
			impersonationContext = null;
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue && disposing)
		{
			_undoImpersonation();
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
