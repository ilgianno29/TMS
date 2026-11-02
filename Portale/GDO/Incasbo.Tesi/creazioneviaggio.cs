using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using Incasbo.My;

namespace Incasbo.Tesi;

[GeneratedCode("System.Web.Services", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "creazioneviaggioSoap11Binding", Namespace = "http://webservices")]
[XmlInclude(typeof(CFComponentSkeleton))]
public class creazioneviaggio : SoapHttpClientProtocol
{
	private SendOrPostCallback lookupOperationCompleted;

	private SendOrPostCallback push_actionOperationCompleted;

	private bool useDefaultCredentialsSetExplicitly;

	public string Url
	{
		get
		{
			return ((WebClientProtocol)this).Url;
		}
		set
		{
			if (IsLocalFileSystemWebService(((WebClientProtocol)this).Url) && !useDefaultCredentialsSetExplicitly && !IsLocalFileSystemWebService(value))
			{
				((WebClientProtocol)this).UseDefaultCredentials = false;
			}
			((WebClientProtocol)this).Url = value;
		}
	}

	public bool UseDefaultCredentials
	{
		get
		{
			return ((WebClientProtocol)this).UseDefaultCredentials;
		}
		set
		{
			((WebClientProtocol)this).UseDefaultCredentials = value;
			useDefaultCredentialsSetExplicitly = true;
		}
	}

	public event lookupCompletedEventHandler lookupCompleted;

	public event push_actionCompletedEventHandler push_actionCompleted;

	public creazioneviaggio()
	{
		Url = Incasbo.My.MySettings.Default.GDO_Tesi_creazioneviaggio;
		if (IsLocalFileSystemWebService(Url))
		{
			UseDefaultCredentials = true;
			useDefaultCredentialsSetExplicitly = false;
		}
		else
		{
			useDefaultCredentialsSetExplicitly = true;
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement(Namespace = "http://webservices", IsNullable = true)]
	public Response lookup()
	{
		object[] array = this.Invoke("lookup", new object[0]);
		return (Response)array[0];
	}

	public void lookupAsync()
	{
		lookupAsync(null);
	}

	public void lookupAsync(object userState)
	{
		if (lookupOperationCompleted == null)
		{
			lookupOperationCompleted = OnlookupOperationCompleted;
		}
		this.InvokeAsync("lookup", new object[0], lookupOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
	}

	private void OnlookupOperationCompleted(object arg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (lookupCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			lookupCompleted?.Invoke(this, new lookupCompletedEventArgs(val.Results, ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, RuntimeHelpers.GetObjectValue(((AsyncCompletedEventArgs)(object)val).UserState)));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement(Namespace = "http://webservices", IsNullable = true)]
	public Response push_action([XmlElement(Namespace = "http://webservices", IsNullable = true)] Transports transports)
	{
		object[] array = this.Invoke("push_action", new object[1] { transports });
		return (Response)array[0];
	}

	public void push_actionAsync(Transports transports)
	{
		push_actionAsync(transports, null);
	}

	public void push_actionAsync(Transports transports, object userState)
	{
		if (push_actionOperationCompleted == null)
		{
			push_actionOperationCompleted = Onpush_actionOperationCompleted;
		}
		this.InvokeAsync("push_action", new object[1] { transports }, push_actionOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
	}

	private void Onpush_actionOperationCompleted(object arg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (push_actionCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			push_actionCompleted?.Invoke(this, new push_actionCompletedEventArgs(val.Results, ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, RuntimeHelpers.GetObjectValue(((AsyncCompletedEventArgs)(object)val).UserState)));
		}
	}

	public void CancelAsync(object userState)
	{
		this.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
	}

	private bool IsLocalFileSystemWebService(string url)
	{
		if (url == null || (object)url == string.Empty)
		{
			return false;
		}
		Uri uri = new Uri(url);
		if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		return false;
	}
}
