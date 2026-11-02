using System.Collections.Generic;

namespace Incasbo.Web.Library.ORM;

public class IO_Table
{
	public string Table { get; set; }

	public List<IO_FieldCollection> Records { get; set; }

	public List<IO_FieldDefCollection> FieldsDef { get; set; }

	public IO_Table(string paramTable)
	{
		string table = "";
		Table = table;
		List<IO_FieldCollection> records = new List<IO_FieldCollection>();
		Records = records;
		List<IO_FieldDefCollection> fieldsDef = new List<IO_FieldDefCollection>();
		FieldsDef = fieldsDef;
		Table = paramTable;
	}
}
