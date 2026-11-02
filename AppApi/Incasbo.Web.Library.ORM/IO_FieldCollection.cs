using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library.ORM;

public class IO_FieldCollection : List<IO_FieldDef>
{
	public IO_Field GetFieldByName(string paramName)
	{
		IO_Field result = null;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IO_Field iO_Field = (IO_Field)enumerator.Current;
				if (Operators.CompareString(iO_Field.Name.ToUpper(), paramName.ToUpper(), false) == 0)
				{
					result = iO_Field;
					break;
				}
			}
		}
		return result;
	}

	public bool ExistsFieldByName(string paramName)
	{
		return GetFieldByName(paramName) != null;
	}

	public IO_Field GetFieldByDBName(string paramDBName)
	{
		IO_Field result = null;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IO_Field iO_Field = (IO_Field)enumerator.Current;
				if (Operators.CompareString(iO_Field.DBName.ToUpper(), paramDBName.ToUpper(), false) == 0)
				{
					result = iO_Field;
					break;
				}
			}
		}
		return result;
	}

	public bool ExistsFieldByDBName(string paramDBName)
	{
		return GetFieldByDBName(paramDBName) != null;
	}

	public List<IO_Field> GetKeyFields(string paramDBName)
	{
		List<IO_Field> list = new List<IO_Field>();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			IO_Field iO_Field = (IO_Field)enumerator.Current;
			if (iO_Field.IsKey)
			{
				list.Add(iO_Field);
			}
		}
		return list;
	}
}
