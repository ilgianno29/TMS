using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class DataKeyFieldValues
{
	private string _FieldName;

	private string _FieldType;

	private object[] _FieldValues;

	private int _FieldValuesCount;

	public string FieldName
	{
		get
		{
			return _FieldName;
		}
		set
		{
			_FieldName = value;
		}
	}

	public string FieldType
	{
		get
		{
			return _FieldType;
		}
		set
		{
			_FieldType = value;
		}
	}

	public int FieldValuesCount => _FieldValuesCount;

// Proprieta' VB con parametro, convertita in metodi
	public object get_FieldValues(int viIndex)
	{
		object result = null;
		if (viIndex < _FieldValuesCount)
		{
			result = RuntimeHelpers.GetObjectValue(_FieldValues[viIndex]);
		}
		return result;
	}


	public DataKeyFieldValues(string vsFieldName, string vsFieldType)
	{
		_FieldName = vsFieldName;
		_FieldType = vsFieldType;
	}

	public void FieldValuesAdd(object vobjValue)
	{
		ref object[] fieldValues = ref _FieldValues;
		checked
		{
			fieldValues = (object[])Utils.CopyArray((Array)fieldValues, (Array)new object[_FieldValuesCount + 1]);
			_FieldValues[_FieldValuesCount] = RuntimeHelpers.GetObjectValue(vobjValue);
			_FieldValuesCount++;
		}
	}

	public void Reset()
	{
		_FieldValuesCount = 0;
		_FieldValues = new object[1];
	}
}
