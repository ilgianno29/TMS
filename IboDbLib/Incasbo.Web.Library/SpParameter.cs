using System.Runtime.CompilerServices;

namespace Incasbo.Web.Library;

public class SpParameter
{
	protected string _sName;

	protected object _objValue;

	protected SpParameterDirection _eDirection;

	protected SpParameterDataType _eDataType;

	public string Name
	{
		get
		{
			return _sName;
		}
		set
		{
			_sName = value;
		}
	}

	public object Value
	{
		get
		{
			return RuntimeHelpers.GetObjectValue(_objValue);
		}
		set
		{
			_objValue = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public SpParameterDirection Direction
	{
		get
		{
			return _eDirection;
		}
		set
		{
			_eDirection = value;
		}
	}

	public SpParameterDataType DataType
	{
		get
		{
			return _eDataType;
		}
		set
		{
			_eDataType = value;
		}
	}

	public int DataVarcharLength { get; set; }

	public SpParameter()
	{
		_sName = "";
		int dataVarcharLength = 1000;
		DataVarcharLength = dataVarcharLength;
	}

	public SpParameter(string vsName, SpParameterDataType veDataType, object vobjValue, SpParameterDirection veDirection)
	{
		_sName = "";
		int dataVarcharLength = 1000;
		DataVarcharLength = dataVarcharLength;
		_sName = vsName;
		_eDataType = veDataType;
		_objValue = RuntimeHelpers.GetObjectValue(vobjValue);
		_eDirection = veDirection;
	}
}
