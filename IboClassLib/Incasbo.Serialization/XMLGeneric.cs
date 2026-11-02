using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Incasbo.Web.Library;

namespace Incasbo.Serialization;

public class XMLGeneric
{
	public static string XMLSerialize(object obj)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		XmlSerializer val = new XmlSerializer(obj.GetType());
		MemoryStream memoryStream = new MemoryStream();
		val.Serialize((Stream)memoryStream, RuntimeHelpers.GetObjectValue(obj));
		memoryStream.Flush();
		memoryStream.Close();
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}

	public static object XMLDeserialize(ref string ser, Type objType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		XmlSerializer val = new XmlSerializer(objType);
		return RuntimeHelpers.GetObjectValue(val.Deserialize(modGeneral.StringToStream(ser, Encoding.UTF8)));
	}
}
