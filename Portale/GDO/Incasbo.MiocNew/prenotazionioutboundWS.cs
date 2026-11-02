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

namespace Incasbo.MiocNew;

[GeneratedCode("System.Web.Services", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "prenotazionioutboundWSSoap11Binding", Namespace = "http://webservices")]
[XmlInclude(typeof(CFComponentSkeleton))]
public class prenotazionioutboundWS : SoapHttpClientProtocol
{
	private SendOrPostCallback setPrenotazioneOutboundOperationCompleted;

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

	public event setPrenotazioneOutboundCompletedEventHandler setPrenotazioneOutboundCompleted;

	public prenotazionioutboundWS()
	{
		Url = Incasbo.My.MySettings.Default.GDO_MiocNew_prenotazionioutboundWS;
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
	public Response setPrenotazioneOutbound([XmlElement(Namespace = "http://webservices", IsNullable = true)] PrenotazioneOutbound prenotazione)
	{
		object[] array = this.Invoke("setPrenotazioneOutbound", new object[1] { prenotazione });
		return (Response)array[0];
	}

	public void setPrenotazioneOutboundAsync(PrenotazioneOutbound prenotazione)
	{
		setPrenotazioneOutboundAsync(prenotazione, null);
	}

	public void setPrenotazioneOutboundAsync(PrenotazioneOutbound prenotazione, object userState)
	{
		if (setPrenotazioneOutboundOperationCompleted == null)
		{
			setPrenotazioneOutboundOperationCompleted = OnsetPrenotazioneOutboundOperationCompleted;
		}
		this.InvokeAsync("setPrenotazioneOutbound", new object[1] { prenotazione }, setPrenotazioneOutboundOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
	}

	private void OnsetPrenotazioneOutboundOperationCompleted(object arg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (setPrenotazioneOutboundCompleted != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)arg;
			setPrenotazioneOutboundCompleted?.Invoke(this, new setPrenotazioneOutboundCompletedEventArgs(val.Results, ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, RuntimeHelpers.GetObjectValue(((AsyncCompletedEventArgs)(object)val).UserState)));
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
