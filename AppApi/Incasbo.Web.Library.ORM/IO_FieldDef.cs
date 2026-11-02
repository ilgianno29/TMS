using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library.ORM;

public class IO_FieldDef
{
	public readonly string Name;

	public readonly string DBName;

	public readonly bool IsKey;

	public readonly modGeneral.eTipoDati Tipo;

	public IO_FieldDef(string paramName, string paramDBName, modGeneral.eTipoDati veTipo, bool paramIsKey)
	{
		IsKey = false;
		Name = paramName;
		if (Operators.CompareString(paramDBName, "", false) == 0)
		{
			DBName = paramName;
		}
		else
		{
			DBName = paramDBName;
		}
		Tipo = veTipo;
		IsKey = paramIsKey;
	}

	public IO_FieldDef(string paramName, modGeneral.eTipoDati veTipo)
		: this(paramName, "", veTipo, paramIsKey: false)
	{
	}

	public IO_FieldDef(string paramName, string paramDBName, modGeneral.eTipoDati veTipo)
		: this(paramName, paramDBName, veTipo, paramIsKey: false)
	{
	}
}
