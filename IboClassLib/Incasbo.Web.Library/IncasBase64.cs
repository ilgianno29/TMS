using System;

namespace Incasbo.Web.Library;

public class IncasBase64
{
	private static char[] b64e = new char[64]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
		'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
		'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
		'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
		'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
		'y', 'z', '+', '/'
	};

	public static string b64ConvertInt(uint value, int length)
	{
		return checked(length switch
		{
			5 => new string(new char[5]
			{
				b64e[(int)((value & 0x3F000000) >> 24)],
				b64e[(int)((value & 0xFC0000) >> 18)],
				b64e[(int)((value & 0x3F000) >> 12)],
				b64e[(int)((value & 0xFC0) >> 6)],
				b64e[(int)(value & 0x3Fu)]
			}), 
			4 => new string(new char[4]
			{
				b64e[(int)((value & 0xFC0000) >> 18)],
				b64e[(int)((value & 0x3F000) >> 12)],
				b64e[(int)((value & 0xFC0) >> 6)],
				b64e[(int)(value & 0x3Fu)]
			}), 
			3 => new string(new char[3]
			{
				b64e[(int)((value & 0x3F000) >> 12)],
				b64e[(int)((value & 0xFC0) >> 6)],
				b64e[(int)(value & 0x3Fu)]
			}), 
			2 => new string(new char[2]
			{
				b64e[(int)((value & 0xFC0) >> 6)],
				b64e[(int)(value & 0x3Fu)]
			}), 
			_ => Convert.ToString(b64e[(int)(value & 0x3Fu)]), 
		});
	}

	public static string b64ConvertInt(int value, int length)
	{
		return length switch
		{
			5 => new string(new char[5]
			{
				b64e[(value & 0x3F000000) >> 24],
				b64e[(value & 0xFC0000) >> 18],
				b64e[(value & 0x3F000) >> 12],
				b64e[(value & 0xFC0) >> 6],
				b64e[value & 0x3F]
			}), 
			4 => new string(new char[4]
			{
				b64e[(value & 0xFC0000) >> 18],
				b64e[(value & 0x3F000) >> 12],
				b64e[(value & 0xFC0) >> 6],
				b64e[value & 0x3F]
			}), 
			3 => new string(new char[3]
			{
				b64e[(value & 0x3F000) >> 12],
				b64e[(value & 0xFC0) >> 6],
				b64e[value & 0x3F]
			}), 
			2 => new string(new char[2]
			{
				b64e[(value & 0xFC0) >> 6],
				b64e[value & 0x3F]
			}), 
			_ => Convert.ToString(b64e[value & 0x3F]), 
		};
	}
}
