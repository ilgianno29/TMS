using System.IO;
using System.Text;
using Microsoft.VisualBasic;

namespace Incasbo.Web.Library;

public class LogFileFlushed : LogFile
{
	protected StringBuilder _TextLogFile;

	protected string _Terminator;

	public LogFileFlushed(string vsLogFileName)
		: base(vsLogFileName)
	{
		_TextLogFile = new StringBuilder();
		_Terminator = "\r\n";
	}

	public LogFileFlushed(string vsLogFileName, int vi32LogMaxLengthInByte)
		: base(vsLogFileName, vi32LogMaxLengthInByte)
	{
		_TextLogFile = new StringBuilder();
		_Terminator = "\r\n";
	}

	public LogFileFlushed(string vsLogFileName, int vi32LogMaxLengthInByte, bool vbConData)
		: base(vsLogFileName, vi32LogMaxLengthInByte, vbConData)
	{
		_TextLogFile = new StringBuilder();
		_Terminator = "\r\n";
	}

	public LogFileFlushed(string vsLogFileName, int vi32LogMaxLengthInByte, bool vbConData, bool vbUcase)
		: base(vsLogFileName, vi32LogMaxLengthInByte, vbConData, vbUcase)
	{
		_TextLogFile = new StringBuilder();
		_Terminator = "\r\n";
	}

	protected override void Append(string vsText)
	{
		if (_WriteLogWithDate)
		{
			vsText = "[" + Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH:mm:ss") + "] " + vsText;
		}
		if (_WriteLogInUpperCase)
		{
			vsText = vsText.ToUpper();
		}
		_TextLogFile.Append(vsText + _Terminator);
	}

	public virtual void Flush()
	{
		Check();
		swLog = File.AppendText(_LogFileName);
		swLog.WriteLine(_TextLogFile.ToString());
		swLog.Close();
		swLog.Dispose();
		swLog = null;
		_TextLogFile.Clear();
	}

	public override void Write(string vsMessage)
	{
		Append(vsMessage);
	}
}
