using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IboCrypt
{
	protected string EncryptionKey;

	public IboCrypt()
	{
		EncryptionKey = "74incasbo04";
	}

	public IboCrypt(string sEncryptionKey)
	{
		EncryptionKey = "74incasbo04";
		EncryptionKey = sEncryptionKey;
	}

	public string EncryptString128Bit(string vstrTextToBeEncrypted)
	{
		byte[] inArray = new byte[0];
		byte[] rgbIV = new byte[16]
		{
			121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
			45, 78, 14, 211, 22, 62
		};
		MemoryStream memoryStream = new MemoryStream();
		vstrTextToBeEncrypted = StripNullCharacters(vstrTextToBeEncrypted);
		byte[] bytes = Encoding.ASCII.GetBytes(vstrTextToBeEncrypted.ToCharArray());
		int num = Strings.Len(EncryptionKey);
		if (num >= 32)
		{
			EncryptionKey = Strings.Left(EncryptionKey, 32);
		}
		else
		{
			num = Strings.Len(EncryptionKey);
			int num2 = checked(32 - num);
			EncryptionKey += Strings.StrDup(num2, "X");
		}
		byte[] bytes2 = Encoding.ASCII.GetBytes(EncryptionKey.ToCharArray());
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		try
		{
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes2, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			memoryStream = null;
			cryptoStream = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return Convert.ToBase64String(inArray);
	}

	public string DecryptString128Bit(string vstrStringToBeDecrypted)
	{
		byte[] rgbIV = new byte[16]
		{
			121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
			45, 78, 14, 211, 22, 62
		};
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		string empty = string.Empty;
		vstrStringToBeDecrypted = Strings.Replace(vstrStringToBeDecrypted, " ", "+", 1, -1, (CompareMethod)0);
		byte[] array = Convert.FromBase64String(vstrStringToBeDecrypted);
		int num = Strings.Len(EncryptionKey);
		checked
		{
			if (num >= 32)
			{
				EncryptionKey = Strings.Left(EncryptionKey, 32);
			}
			else
			{
				num = Strings.Len(EncryptionKey);
				int num2 = 32 - num;
				EncryptionKey += Strings.StrDup(num2, "X");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(EncryptionKey.ToCharArray());
			byte[] array2 = new byte[array.Length + 1];
			MemoryStream memoryStream = new MemoryStream(array);
			try
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
				cryptoStream.Read(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				cryptoStream.Close();
				memoryStream = null;
				cryptoStream = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return StripNullCharacters(Encoding.ASCII.GetString(array2));
		}
	}

	public string StripNullCharacters(string vstrStringWithNulls)
	{
		int num = 1;
		string text = vstrStringWithNulls;
		while (num > 0)
		{
			num = Strings.InStr(num, vstrStringWithNulls, "\0", (CompareMethod)0);
			if (num > 0)
			{
				text = checked(Strings.Left(text, num - 1) + Strings.Right(text, Strings.Len(text) - num));
			}
			if (num > text.Length)
			{
				break;
			}
		}
		return text;
	}
}
