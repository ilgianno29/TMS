using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Incasbo.Tesi;

[GeneratedCode("System.Web.Services", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class lookupCompletedEventArgs : AsyncCompletedEventArgs
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

	internal lookupCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
	{
		this.results = results;
	}
}
