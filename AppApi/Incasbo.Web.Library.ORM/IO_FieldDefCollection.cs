using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library.ORM;

public class IO_FieldDefCollection : List<IO_FieldDef>
{
	public IO_FieldDef GetFieldByName(string paramName)
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

	public IO_FieldDef GetFieldByDBName(string paramDBName)
	{
		IO_FieldDef result = null;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IO_FieldDef current = enumerator.Current;
				if (Operators.CompareString(current.DBName.ToUpper(), paramDBName.ToUpper(), false) == 0)
				{
					result = current;
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

	public List<IO_FieldDef> GetKeyFields(string paramDBName)
	{
		List<IO_FieldDef> list = new List<IO_FieldDef>();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			IO_FieldDef current = enumerator.Current;
			if (current.IsKey)
			{
				list.Add(current);
			}
		}
		return list;
	}
}
