using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IncasReflection
{
	public static object InstantiateClass(string vsClassName, ref string CallerAssemblyName)
	{
		Assembly CallerAssembly;
		if (Operators.CompareString(CallerAssemblyName, "", false) == 0)
		{
			CallerAssembly = Assembly.GetCallingAssembly();
		}
		else
		{
			string text = CallerAssemblyName;
			text = text.Replace("\\\\", "\\");
			CallerAssembly = Assembly.LoadFile(text);
		}
		return InstantiateClass(vsClassName, ref CallerAssembly);
	}

	public static object InstantiateClass(string vsClassName, ref string CallerAssemblyName, object[] ObjConstructor)
	{
		Assembly CallerAssembly;
		if (Operators.CompareString(CallerAssemblyName, "", false) == 0)
		{
			CallerAssembly = Assembly.GetCallingAssembly();
		}
		else
		{
			string text = CallerAssemblyName;
			text = text.Replace("\\\\", "\\");
			CallerAssembly = Assembly.LoadFile(text);
		}
		return InstantiateClass(vsClassName, ref CallerAssembly, ObjConstructor);
	}

	public static object InstantiateClass(string vsClassName, ref Assembly CallerAssembly)
	{
		object result = null;
		Type type = CallerAssembly.GetType(vsClassName);
		if ((object)type != null)
		{
			Type[] types = new Type[0];
			ConstructorInfo constructor = type.GetConstructor(types);
			if ((object)constructor != null)
			{
				result = RuntimeHelpers.GetObjectValue(constructor.Invoke(new object[0]));
			}
		}
		return result;
	}

	public static object InstantiateClass(string vsClassName, ref Assembly CallerAssembly, object[] ObjConstructor)
	{
		object result = null;
		Type type = CallerAssembly.GetType(vsClassName);
		checked
		{
			if ((object)type != null)
			{
				Type[] array = new Type[0];
				int num = 0;
				for (int i = 0; i < ObjConstructor.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(ObjConstructor[i]);
					array = (Type[])Utils.CopyArray((Array)array, (Array)new Type[num + 1]);
					array[num] = objectValue.GetType();
					num++;
				}
				ConstructorInfo constructor = type.GetConstructor(array);
				if ((object)constructor != null)
				{
					result = RuntimeHelpers.GetObjectValue(constructor.Invoke(ObjConstructor));
				}
			}
			return result;
		}
	}

	public static object GetPropertyValue(object objTarget, string sNomeCampo)
	{
		PropertyInfo property = objTarget.GetType().GetProperty(sNomeCampo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		return property.GetValue(RuntimeHelpers.GetObjectValue(objTarget), null);
	}

	public static void SetPropertyValue(object objTarget, string sNomeCampo, object objValore)
	{
		Type type = objTarget.GetType();
		PropertyInfo property = type.GetProperty(sNomeCampo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		Type propertyType = property.PropertyType;
		Type type2 = (IsNullableType(property.PropertyType) ? Nullable.GetUnderlyingType(property.PropertyType) : property.PropertyType);
		if ((Operators.CompareString(type2.BaseType.ToString().ToUpper(), "SYSTEM.VALUETYPE", false) != 0) | (Operators.CompareString(type2.BaseType.ToString().ToUpper(), "SYSTEM.VALUETYPE", false) == 0 && objValore != null))
		{
			objValore = RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(objValore), type2));
			property.SetValue(RuntimeHelpers.GetObjectValue(objTarget), RuntimeHelpers.GetObjectValue(objValore), null);
		}
	}

	protected static bool IsNullableType(Type type)
	{
		if (!type.IsGenericType || !type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
		{
			return false;
		}
		return true;
	}

	public static object GetFieldValue(object objTarget, string sNomeCampo)
	{
		FieldInfo field = objTarget.GetType().GetField(sNomeCampo);
		return field.GetValue(RuntimeHelpers.GetObjectValue(objTarget));
	}

	public static void SetFieldValue(object objTarget, string sNomeCampo, object objValore)
	{
		Type type = objTarget.GetType();
		FieldInfo field = type.GetField(sNomeCampo, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		Type fieldType = field.FieldType;
		Type conversionType = (IsNullableType(field.FieldType) ? Nullable.GetUnderlyingType(field.FieldType) : field.FieldType);
		objValore = RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(objValore), conversionType));
		field.SetValue(RuntimeHelpers.GetObjectValue(objTarget), RuntimeHelpers.GetObjectValue(objValore));
	}

	public static FieldInfo[] GetPublicFields(object val)
	{
		Type type = val.GetType();
		return type.GetFields(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
	}

	public static PropertyInfo[] GetPublicProperties(object val)
	{
		Type type = val.GetType();
		return type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
	}

	public static Dictionary<string, object> GetCustomListAttributes(object val)
	{
		Type type = val.GetType();
		object[] customAttributes = type.GetCustomAttributes(typeof(CustomListAttributes), inherit: true);
		if (customAttributes.Count() == 0)
		{
			return new Dictionary<string, object>();
		}
		return ((CustomListAttributes)customAttributes[0]).Dictionary;
	}

	public static Dictionary<string, object> GetCustomListAttributesForProperties(PropertyInfo val)
	{
		Dictionary<string, object> result;
		try
		{
			if (val.GetCustomAttributes(inherit: false).Count() > 0)
			{
				CustomListAttributes customListAttributes = (CustomListAttributes)val.GetCustomAttributes(inherit: false)[0];
				result = customListAttributes.Dictionary;
			}
			else
			{
				result = new Dictionary<string, object>();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = new Dictionary<string, object>();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void CopyValuesOfPublicProperty(object objSource, object objDestination)
	{
		PropertyInfo[] publicProperties = GetPublicProperties(RuntimeHelpers.GetObjectValue(objSource));
		PropertyInfo[] publicProperties2 = GetPublicProperties(RuntimeHelpers.GetObjectValue(objDestination));
		PropertyInfo[] array = publicProperties;
		foreach (PropertyInfo propertyInfo in array)
		{
			PropertyInfo[] array2 = publicProperties2;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				if (Operators.CompareString(propertyInfo.Name.ToUpper(), propertyInfo2.Name.ToUpper(), false) == 0)
				{
					try
					{
						propertyInfo2.SetValue(RuntimeHelpers.GetObjectValue(objDestination), RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(objSource), null)), null);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
		}
	}
}
