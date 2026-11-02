using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Incasbo.Web.Library;

public class CsvFileParser : StreamReader
{
	protected string _LastLine;

	protected string _TempLastLine;

	protected bool _EndOfData;

	public FieldType TextFieldType { get; set; }

	public string[] Delimiters { get; set; }

	public bool HasFieldsEnclosedInQuotes { get; set; }

	public string LastLine => _LastLine;

	public bool EndOfData
	{
		get
		{
			if (!_EndOfData)
			{
				_TempLastLine = ReadLine();
				_EndOfData = _TempLastLine == null;
			}
			return _EndOfData;
		}
	}

	public CsvFileParser(string path)
		: base(path)
	{
		_LastLine = "";
		_TempLastLine = "";
		_EndOfData = false;
	}

	public string[] ReadFields()
	{
		_LastLine = _TempLastLine;
		return ParseLine();
	}

	protected virtual byte[] StrToByteArray(string str)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return uTF8Encoding.GetBytes(str);
	}

	protected string[] ParseLine()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		string[] array = null;
		string[] result;
		try
		{
			TextFieldParser val = new TextFieldParser((Stream)new MemoryStream(StrToByteArray(_LastLine)));
			val.TextFieldType = TextFieldType;
			val.Delimiters = Delimiters;
			val.HasFieldsEnclosedInQuotes = HasFieldsEnclosedInQuotes;
			array = val.ReadFields();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = array;
		}
		return result;
	}
}
