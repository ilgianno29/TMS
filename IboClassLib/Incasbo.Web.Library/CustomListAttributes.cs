using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Incasbo.Web.Library;

public class CustomListAttributes : Attribute
{
	protected Dictionary<string, object> _Dictionary;

	public Dictionary<string, object> Dictionary => _Dictionary;

	public CustomListAttributes(string Key1, object Value1)
	{
		_Dictionary = new Dictionary<string, object>();
		_Dictionary.Add(Key1, RuntimeHelpers.GetObjectValue(Value1));
	}

	public CustomListAttributes(string Key1, object Value1, string Key2, object Value2)
	{
		_Dictionary = new Dictionary<string, object>();
		_Dictionary.Add(Key1, RuntimeHelpers.GetObjectValue(Value1));
		_Dictionary.Add(Key2, RuntimeHelpers.GetObjectValue(Value2));
	}

	public CustomListAttributes(string Key1, object Value1, string Key2, object Value2, string Key3, object Value3)
	{
		_Dictionary = new Dictionary<string, object>();
		_Dictionary.Add(Key1, RuntimeHelpers.GetObjectValue(Value1));
		_Dictionary.Add(Key2, RuntimeHelpers.GetObjectValue(Value2));
		_Dictionary.Add(Key3, RuntimeHelpers.GetObjectValue(Value3));
	}
}
