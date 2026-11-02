using System;
using System.IO;
using System.Web;
using System.Web.Services.Protocols;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSC.SOAPExtensionsLib;

public class IncomingOutgoingSOAPMessageInterceptExtension : SoapExtension
{
	private Stream _originalStream;

	private Stream _workingStream;

	public override Stream ChainStream(Stream stream)
	{
		if (Operators.CompareString(stream.GetType().Name.ToUpper(), "SoapExtensionStream".ToUpper(), false) == 0)
		{
			_originalStream = stream;
			_workingStream = new MemoryStream();
			return _workingStream;
		}
		return ((SoapExtension)this).ChainStream(stream);
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		switch ((int)message.Stage - 1)
		{
		case 3:
			break;
		case 7:
			break;
		case 0:
			break;
		case 1:
			LogMessageFromStream(_workingStream);
			Copy(_workingStream, _originalStream);
			try
			{
				int bytesInviati = checked((int)message.Stream.Length);
				IncasServiceFormsAuth incasServiceFormsAuth = (IncasServiceFormsAuth)HttpContext.Current.Session["WSC.WebServiceInstance"];
				string rsmess = "";
				incasServiceFormsAuth.LogEventiFlush(bytesInviati, ref rsmess);
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				break;
			}
		case 2:
		case 4:
		case 5:
		case 6:
			break;
		}
	}

	private void LogMessageFromStream(Stream stream)
	{
		string empty = string.Empty;
		if (stream.CanRead && stream.CanSeek)
		{
			stream.Position = 0L;
			StreamReader streamReader = new StreamReader(stream);
			empty = streamReader.ReadToEnd();
			stream.Position = 0L;
		}
	}

	private void Copy(Stream from, Stream to)
	{
		TextReader textReader = new StreamReader(from);
		TextWriter textWriter = new StreamWriter(to);
		textWriter.Write(textReader.ReadToEnd());
		textWriter.Flush();
	}
}
