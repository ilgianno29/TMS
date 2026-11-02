using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFITable
{
	protected string _DBName;

	protected WFIFields _Fields;

	protected WFIFields _PrimaryKey;

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

	public WFIFields Fields => _Fields;

	public WFIFields PrimaryKey => _PrimaryKey;

	public WFIForeignKeys ForeignKey { get; set; }

	public WFITable(string Name, string DBName)
	{
		_DBName = "";
		this.Name = "";
		this.Name = Name;
		this.DBName = DBName;
		_PrimaryKey = new WFIFields();
		_Fields = new WFIFields();
		ForeignKey = new WFIForeignKeys();
	}

	public WFITable(string Name)
		: this(Name, "")
	{
	}

	public WFIField AddField(string Name, string DBName, Type Type)
	{
		WFIField wFIField = new WFIField(Name, DBName, Type);
		_Fields.Add(wFIField);
		wFIField.Table = this;
		return wFIField;
	}

	public WFIField AddField(string Name, Type Type)
	{
		return AddField(Name, "", Type);
	}

	public WFIField AddPrimaryKeyField(string Name, string DBName, Type Type)
	{
		WFIField wFIField = new WFIField(Name, DBName, Type);
		_PrimaryKey.Add(wFIField);
		_Fields.Add(wFIField);
		wFIField.Table = this;
		return wFIField;
	}

	public WFIField AddPrimaryKeyField(string Name, Type Type)
	{
		return AddPrimaryKeyField(Name, "", Type);
	}
}
