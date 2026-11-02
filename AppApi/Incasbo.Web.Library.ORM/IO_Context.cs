using System.Collections.Generic;

namespace Incasbo.Web.Library.ORM;

public class IO_Context
{
	public string Name { get; set; }

	public List<IO_Table> Tables { get; set; }

	public IO_Context()
	{
		string name = "DEFAULT";
		Name = name;
		List<IO_Table> tables = new List<IO_Table>();
		Tables = tables;
	}
}
