using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class LogFile
{
	protected string _LogFileName;

	protected int _LogFileMaxLengthInByte;

	protected bool _WriteLogWithDate;

	protected bool _WriteLogInUpperCase;

	protected StreamWriter swLog;

	public string LogFileName => _LogFileName;

	public int LogFileMaxLengthInByte => _LogFileMaxLengthInByte;

	public bool WriteLogWithDate => _WriteLogWithDate;

	public bool WriteLogInUpperCase => _WriteLogInUpperCase;

	public LogFile(string vsLogFileName)
		: this(vsLogFileName, 10240, vbConData: false, vbUcase: false)
	{
	}

	public LogFile(string vsLogFileName, int vi32LogMaxLengthInByte)
		: this(vsLogFileName, vi32LogMaxLengthInByte, vbConData: false, vbUcase: false)
	{
	}

	public LogFile(string vsLogFileName, int vi32LogMaxLengthInByte, bool vbConData)
		: this(vsLogFileName, vi32LogMaxLengthInByte, vbConData, vbUcase: false)
	{
	}

	public LogFile(string vsLogFileName, int vi32LogMaxLengthInByte, bool vbConData, bool vbUcase)
	{
		_LogFileName = "";
		_LogFileMaxLengthInByte = 10240;
		_WriteLogWithDate = false;
		_WriteLogInUpperCase = false;
		_LogFileName = vsLogFileName;
		_LogFileMaxLengthInByte = vi32LogMaxLengthInByte;
		_WriteLogWithDate = vbConData;
		_WriteLogInUpperCase = vbUcase;
	}

	public virtual bool Archive()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		bool result = default(bool);
		try
		{
			FileInfo fileInfo = new FileInfo(_LogFileName);
			text = fileInfo.DirectoryName + "\\";
			text3 = fileInfo.Extension;
			text2 = fileInfo.Name.Replace(".", "_");
			fileInfo.MoveTo(text + text2 + "_" + Strings.Format((object)DateAndTime.Now, "yyyyMMdd_HHmmss") + DateAndTime.Now.Millisecond.ToString().PadLeft(3, '0') + ".OLD");
			result = true;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected virtual bool Check()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(_LogFileName);
			if (fileInfo.Length >= _LogFileMaxLengthInByte)
			{
				Archive();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	protected virtual void Append(string vsText)
	{
		swLog = File.AppendText(_LogFileName);
		if (_WriteLogWithDate)
		{
			vsText = "[" + Strings.Format((object)DateAndTime.Now, "dd/MM/yyyy HH:mm:ss") + "] " + vsText;
		}
		if (_WriteLogInUpperCase)
		{
			vsText = vsText.ToUpper();
		}
		swLog.WriteLine(vsText);
		swLog.Close();
		swLog.Dispose();
	}

	public virtual void Write(string vsMessage)
	{
		Check();
		Append(vsMessage);
	}

	public virtual void WriteLineSeparator()
	{
		Write(new string('-', 100));
	}

	public virtual void WriteLineSeparator(char CharSep)
	{
		Write(new string(CharSep, 100));
	}

	public virtual void WriteLineSeparator(char CharSep, int Count)
	{
		Write(new string(CharSep, Count));
	}

	public virtual void OverWriteFile(string vsMessage)
	{
		try
		{
			File.Delete(_LogFileName);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Append(vsMessage);
	}

	public virtual void DeleteFile()
	{
		try
		{
			File.Delete(_LogFileName);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
