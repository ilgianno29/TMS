using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Incasbo.MiocNew;

[GeneratedCode("System.Web.Services", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class setPrenotazioneOutboundCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public Response Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (Response)results[0];
		}
	}

	internal setPrenotazioneOutboundCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
	{
		this.results = results;
	}
}
