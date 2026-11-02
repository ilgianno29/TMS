using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class StandardParser
{
	protected char _SeparatoreDiIstruzione;

	protected char _SeparatoreDiAssegnamento;

	protected string _EscapeStringForSeparatoreDiAssegnamento;

	protected Dictionary<string, string> _Result;

	public Dictionary<string, string> Result => _Result;

	public StandardParser(char SeparatoreDiIstruzione, char SeparatoreDiAssegnamento)
		: this()
	{
		_SeparatoreDiAssegnamento = SeparatoreDiAssegnamento;
		_SeparatoreDiIstruzione = SeparatoreDiIstruzione;
	}

	public StandardParser()
	{
		_SeparatoreDiIstruzione = ';';
		_SeparatoreDiAssegnamento = '=';
		_EscapeStringForSeparatoreDiAssegnamento = "%eq%";
		_Result = new Dictionary<string, string>();
	}

	public Dictionary<string, string> Parse(string StringToParse)
	{
		if (Operators.CompareString(StringToParse, "", false) != 0)
		{
			string[] array = StringToParse.Split(new char[1] { _SeparatoreDiIstruzione });
			string[] array2 = array;
			foreach (string text in array2)
			{
				string key = "";
				string value = "";
				string[] array3 = text.Split(new char[1] { _SeparatoreDiAssegnamento });
				if (array3.GetUpperBound(0) >= 0)
				{
					key = array3[0];
				}
				if (array3.GetUpperBound(0) >= 1)
				{
					value = array3[1].Replace(_EscapeStringForSeparatoreDiAssegnamento, _SeparatoreDiAssegnamento.ToString());
				}
				if (!_Result.ContainsKey(key))
				{
					_Result.Add(key, value);
				}
			}
		}
		return _Result;
	}
}
