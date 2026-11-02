using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic;

namespace Incasbo.Web.Library;

public class PerformanceLog : LogFileFlushed
{
	protected Stopwatch _Watch;

	public PerformanceLog(string vsLogFileName, int vi32LogMaxLengthInByte)
		: base(vsLogFileName, vi32LogMaxLengthInByte, vbConData: false, vbUcase: false)
	{
		_Watch = new Stopwatch();
		_Watch.Start();
	}

	public virtual void StopWatch()
	{
		_Watch.Stop();
	}

	protected override void Append(string vsText)
	{
		DateTime now = DateAndTime.Now;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[");
		stringBuilder.Append(Strings.Format((object)now, "dd/MM/yyyy HH:mm:ss:fff"));
		stringBuilder.Append("][");
		stringBuilder.Append(_Watch.ElapsedMilliseconds.ToString().PadLeft(5, ' '));
		stringBuilder.Append("][");
		stringBuilder.Append(_Watch.ElapsedTicks.ToString().PadLeft(8, ' '));
		stringBuilder.Append("] ");
		stringBuilder.Append(vsText);
		_TextLogFile.Append(stringBuilder.ToString() + _Terminator);
	}
}
