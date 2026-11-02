using System.Runtime.CompilerServices;

namespace Incasbo.Web.Library.ORM;

public class IO_Field : IO_FieldDef
{
	[CompilerGenerated]
	private object _Value;

	public object Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public IO_Field(string paramName, string paramDBName, object paramValue, modGeneral.eTipoDati veTipo, bool paramIsKey)
		: base(paramDBName, paramDBName, veTipo, paramIsKey)
	{
		Value = RuntimeHelpers.GetObjectValue(paramValue);
	}

	public IO_Field(string paramName, object paramValue, modGeneral.eTipoDati veTipo)
		: this(paramName, "", RuntimeHelpers.GetObjectValue(paramValue), veTipo, paramIsKey: false)
	{
	}

	public IO_Field(string paramName, string paramDBName, object paramValue, modGeneral.eTipoDati veTipo)
		: this(paramName, paramDBName, RuntimeHelpers.GetObjectValue(paramValue), veTipo, paramIsKey: false)
	{
	}
}
