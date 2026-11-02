using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIField
{
	protected string _DBName;

	public string Name { get; set; }

	public string DBName
	{
		get
		{
			if (Operators.CompareString(_DBName, "", false) == 0)
			{
				return Name;
			}
			return _DBName;
		}
		set
		{
			_DBName = value;
		}
	}

	public Type DataType { get; set; }

	public WFITable Table { get; set; }

	public WFIField(string Name, string DBName, Type Type)
	{
		_DBName = "";
		this.Name = "";
		DataType = typeof(string);
		this.Name = Name;
		this.DBName = DBName;
		DataType = Type;
	}
}
