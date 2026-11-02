using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public abstract class GiacenzeAbstractApi : GdoAbstractApi
{
	public GiacenzeAbstractApi(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected FXRETURN CreateQueryINSERT(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "INSERT INTO %TABLENAME% (";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			PropertyInfo[] array = publicProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
					if (objectValue != null)
					{
						sQuery = sQuery + propertyInfo.Name + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1));
			sQuery += ") VALUES (";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				Dictionary<string, object> customListAttributesForProperties2 = IncasReflection.GetCustomListAttributesForProperties(propertyInfo2);
				bool flag2 = true;
				if (customListAttributesForProperties2.ContainsKey("Bind"))
				{
					flag2 = Conversions.ToBoolean(customListAttributesForProperties2["Bind"]);
				}
				if (!flag2)
				{
					continue;
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(propertyInfo2.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue2 != null)
				{
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue2.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue2)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue2);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + ")";
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			else
			{
				sQuery = sQuery.Replace("%TABLENAME%", obj.GetType().Name);
			}
			sQuery += ";";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CreateQueryUPDATE(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			StringCollection stringCollection = new StringCollection();
			if (customListAttributes.ContainsKey("Key"))
			{
				string[] array = (string[])customListAttributes["Key"];
				foreach (string text in array)
				{
					stringCollection.Add(text.ToUpper());
				}
			}
			sQuery = "UPDATE %TABLENAME% SET ";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo in array2)
			{
				Dictionary<string, object> customListAttributesForProperties = IncasReflection.GetCustomListAttributesForProperties(propertyInfo);
				bool flag = true;
				if (customListAttributesForProperties.ContainsKey("Bind"))
				{
					flag = Conversions.ToBoolean(customListAttributesForProperties["Bind"]);
				}
				if (!flag)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue != null && !stringCollection.Contains(propertyInfo.Name.ToUpper()))
				{
					sQuery = sQuery + propertyInfo.Name + "=";
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + " ";
			sQuery += "WHERE 1=1 ";
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
			else
			{
				sQuery = sQuery.Replace("%TABLENAME%", obj.GetType().Name);
			}
			StringEnumerator enumerator = stringCollection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				sQuery = sQuery + " AND " + current + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(IncasReflection.GetPropertyValue(RuntimeHelpers.GetObjectValue(obj), current).ToString()) + " ";
			}
			sQuery += ";";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
