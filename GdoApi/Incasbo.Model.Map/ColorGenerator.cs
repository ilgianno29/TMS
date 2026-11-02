using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic;

namespace Incasbo.Model.Map;

public class ColorGenerator
{
	private class ColorPart
	{
		public byte Red { get; set; }

		public byte Green { get; set; }

		public byte Blue { get; set; }

		public decimal CARed { get; set; }

		public decimal CAGreen { get; set; }

		public decimal CABlue { get; set; }

		public ColorPart(byte _Red, byte _green, byte _blue, decimal _CARed, decimal _CAGreen, decimal _CABlue)
		{
			CARed = 1m;
			CAGreen = 1m;
			CABlue = 1m;
			Red = _Red;
			Green = _green;
			Blue = _blue;
			CARed = _CARed;
			CAGreen = _CAGreen;
			CABlue = _CABlue;
		}

		public ColorPart(ColorPart _col)
		{
			CARed = 1m;
			CAGreen = 1m;
			CABlue = 1m;
			Red = _col.Red;
			Green = _col.Green;
			Blue = _col.Blue;
			CARed = _col.CARed;
			CAGreen = _col.CAGreen;
			CABlue = _col.CABlue;
		}

		public override string ToString()
		{
			return Conversion.Hex(Red).PadLeft(2, '0') + Conversion.Hex(Green).PadLeft(2, '0') + Conversion.Hex(Blue).PadLeft(2, '0');
		}

		public ColorPart ToComplementaryColor()
		{
			ColorPart colorPart = new ColorPart(this);
			checked
			{
				colorPart.Red = (byte)(255 - colorPart.Red);
				colorPart.Green = (byte)(255 - colorPart.Green);
				colorPart.Blue = (byte)(255 - colorPart.Blue);
				return colorPart;
			}
		}
	}

	private int _RequestCounter;

	private ColorPart _RedColor;

	private ColorPart _YellowColor;

	private ColorPart _GreenColor;

	private ColorPart _CyanColor;

	private ColorPart _BlueColor;

	private ColorPart _MagentaColor;

	private ColorPart _Gray;

	private ColorPart _White;

	private ColorPart _Black;

	private ColorPart[] _ExaColor;

	private ColorPart _LastColor;

	private byte _offset;

	private byte _MinDistance;

	private bool _HasReset;

	private int _Conflict;

	private Dictionary<string, ColorPart> _ColorCollection;

	public int MaxNumberOfColor { get; set; }

	public bool HasReset => _HasReset;

	public int CornerCount => _ExaColor.Count();

	public ColorGenerator(byte Offset, byte MinDistance)
	{
		_RequestCounter = 0;
		_RedColor = new ColorPart(byte.MaxValue, 0, 0, -1m, 0m, 0m);
		_YellowColor = new ColorPart(byte.MaxValue, byte.MaxValue, 0, -1m, -1m, 0m);
		_GreenColor = new ColorPart(50, byte.MaxValue, 50, 0m, -1m, 0m);
		_CyanColor = new ColorPart(0, byte.MaxValue, byte.MaxValue, 0m, -1m, -1m);
		_BlueColor = new ColorPart(50, 50, byte.MaxValue, 0m, 0m, -1m);
		_MagentaColor = new ColorPart(byte.MaxValue, 0, byte.MaxValue, -1m, 0m, -1m);
		_Gray = new ColorPart(190, 190, 190, -1m, -1m, -1m);
		_White = new ColorPart(byte.MaxValue, byte.MaxValue, byte.MaxValue, -1m, -1m, -1m);
		_Black = new ColorPart(0, 0, 0, 1m, 1m, 1m);
		_ExaColor = new ColorPart[6] { _RedColor, _GreenColor, _CyanColor, _BlueColor, _MagentaColor, _Gray };
		_offset = 32;
		_MinDistance = 20;
		_HasReset = false;
		_Conflict = 0;
		MaxNumberOfColor = 30;
		_ColorCollection = new Dictionary<string, ColorPart>();
		_offset = Offset;
		_MinDistance = MinDistance;
	}

	public ColorGenerator(byte Offset, byte MinDistance, int MaxNumberOfCol)
	{
		_RequestCounter = 0;
		_RedColor = new ColorPart(byte.MaxValue, 0, 0, -1m, 0m, 0m);
		_YellowColor = new ColorPart(byte.MaxValue, byte.MaxValue, 0, -1m, -1m, 0m);
		_GreenColor = new ColorPart(50, byte.MaxValue, 50, 0m, -1m, 0m);
		_CyanColor = new ColorPart(0, byte.MaxValue, byte.MaxValue, 0m, -1m, -1m);
		_BlueColor = new ColorPart(50, 50, byte.MaxValue, 0m, 0m, -1m);
		_MagentaColor = new ColorPart(byte.MaxValue, 0, byte.MaxValue, -1m, 0m, -1m);
		_Gray = new ColorPart(190, 190, 190, -1m, -1m, -1m);
		_White = new ColorPart(byte.MaxValue, byte.MaxValue, byte.MaxValue, -1m, -1m, -1m);
		_Black = new ColorPart(0, 0, 0, 1m, 1m, 1m);
		_ExaColor = new ColorPart[6] { _RedColor, _GreenColor, _CyanColor, _BlueColor, _MagentaColor, _Gray };
		_offset = 32;
		_MinDistance = 20;
		_HasReset = false;
		_Conflict = 0;
		MaxNumberOfColor = 30;
		_ColorCollection = new Dictionary<string, ColorPart>();
		_offset = Offset;
		_MinDistance = MinDistance;
		MaxNumberOfColor = MaxNumberOfCol;
	}

	public Color GetColor()
	{
		_HasReset = false;
		if (_RequestCounter == MaxNumberOfColor)
		{
			_ColorCollection.Clear();
			_RequestCounter = 0;
			_HasReset = true;
			_Conflict = 0;
		}
		checked
		{
			_RequestCounter++;
			byte b = (byte)unchecked(checked(_RequestCounter - 1) % _ExaColor.Count());
			byte b2 = (byte)unchecked(checked(_RequestCounter - 1) / _ExaColor.Count());
			ColorPart colorPart = new ColorPart(_ExaColor[b]);
			int num = 1;
			int num2 = 0;
			while (true)
			{
				colorPart.Red = ToValidValue(colorPart.Red + unchecked(checked(Convert.ToInt32(colorPart.CARed) * (b2 + num2) * _offset) % 255));
				colorPart.Green = ToValidValue(colorPart.Green + unchecked(checked(Convert.ToInt32(colorPart.CAGreen) * (b2 + num2) * _offset) % 255));
				colorPart.Blue = ToValidValue(colorPart.Blue + unchecked(checked(Convert.ToInt32(colorPart.CABlue) * (b2 + num2) * _offset) % 255));
				bool flag = true;
				if (!_ColorCollection.ContainsKey(colorPart.ToString()))
				{
					foreach (ColorPart value in _ColorCollection.Values)
					{
						if (DistanceBetweenColor(value, colorPart) < _MinDistance)
						{
							flag = false;
							break;
						}
					}
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
				num++;
				_Conflict++;
				num2++;
				if (num2 == 10)
				{
					_ColorCollection.Clear();
					num2 = 0;
					_RequestCounter = 1;
					b2 = 0;
					b = 0;
					colorPart = _ExaColor[b];
					_HasReset = true;
					_Conflict = 0;
				}
			}
			_ColorCollection.Add(colorPart.ToString(), colorPart);
			_LastColor = colorPart;
			Color color = default(Color);
			return Color.FromArgb(colorPart.Red, colorPart.Green, colorPart.Blue);
		}
	}

	public string GetLastColorRGB()
	{
		return _LastColor.ToString();
	}

	public string GetLastcomplementaryColorRGB()
	{
		return _LastColor.ToComplementaryColor().ToString();
	}

	public Color GetLastcomplementaryColor()
	{
		return Color.FromArgb(_LastColor.ToComplementaryColor().Red, _LastColor.ToComplementaryColor().Green, _LastColor.ToComplementaryColor().Blue);
	}

	public override string ToString()
	{
		string text = "";
		text = text + "Richieste: " + _RequestCounter + "\r\n";
		return text + "Conflitti: " + _Conflict + "\r\n";
	}

	private byte ToValidValue(int i)
	{
		if (i > 255)
		{
			return byte.MaxValue;
		}
		if (i < 0)
		{
			return 0;
		}
		return checked((byte)i);
	}

	private int DistanceBetweenColor(ColorPart c1, ColorPart c2)
	{
		return checked(Math.Abs(c1.Red - c2.Red) + Math.Abs(c1.Green - c2.Green) + Math.Abs(c1.Blue - c2.Blue));
	}
}
