#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Web.Services.Protocols;

namespace Incasbo.Web.WSC.SOAPExtensionsLib;

public class IncomingSOAPMessageInterceptExtension : SoapExtension
{
	public override Stream ChainStream(Stream stream)
	{
		return stream;
	}

	public override object GetInitializer(Type serviceType)
	{
		return null;
	}

	public override object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute)
	{
		return null;
	}

	public override void Initialize(object initializer)
	{
	}

	public override void ProcessMessage(SoapMessage message)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		switch ((int)message.Stage - 1)
		{
		case 3:
			LogMessageFromStream(message.Stream);
			break;
		case 7:
			break;
		case 0:
			break;
		case 1:
		case 2:
		case 4:
		case 5:
		case 6:
			break;
		}
	}

	private void LogMessageFromStream(Stream stream)
	{
		string message = string.Empty;
		if (stream.CanRead && stream.CanSeek)
		{
			stream.Position = 0L;
			StreamReader streamReader = new StreamReader(stream);
			message = streamReader.ReadToEnd();
			stream.Position = 0L;
		}
		Trace.WriteLine(message);
	}
}
