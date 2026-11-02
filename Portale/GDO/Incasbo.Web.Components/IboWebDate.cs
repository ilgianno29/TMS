using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Components;

public class IboWebDate : UserControl, IIboWebComponent
{
	public delegate void DateTimeChangedEventHandler(object sender, EventArgs e);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IboWebDate_txtInput")]
	private IboWebTextBox _IboWebDate_txtInput;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("imgToday")]
	private ImageButton _imgToday;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Ore")]
	private DropDownList _Ore;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Minuti")]
	private DropDownList _Minuti;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Secondi")]
	private DropDownList _Secondi;

	private eAlignement _ContainerAlignement;

	protected string _FormatoData;

	protected string _FormatoOra;

	protected IboWebDateType _ControlType;

	protected IboWebComponentDataType _FieldDataType;

	[field: AccessedThroughProperty("pnlComponent")]
	protected virtual Panel pnlComponent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlContainer")]
	protected virtual Panel pnlContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPIWD")]
	protected virtual UpdatePanel UPIWD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTable")]
	protected virtual Table DateTable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableCell2")]
	protected virtual TableCell TableCell2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebTextBox IboWebDate_txtInput
	{
		[CompilerGenerated]
		get
		{
			return _IboWebDate_txtInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboWebDate_txtInput_TextChanged;
			IboWebTextBox iboWebDate_txtInput = _IboWebDate_txtInput;
			if (iboWebDate_txtInput != null)
			{
				((TextBox)iboWebDate_txtInput).TextChanged -= eventHandler;
			}
			_IboWebDate_txtInput = value;
			iboWebDate_txtInput = _IboWebDate_txtInput;
			if (iboWebDate_txtInput != null)
			{
				((TextBox)iboWebDate_txtInput).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("meeInput")]
	protected virtual MaskedEditExtender meeInput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mevInput")]
	protected virtual MaskedEditValidator mevInput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cexInput")]
	protected virtual CalendarExtender cexInput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableCell1")]
	protected virtual TableCell TableCell1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imbCal")]
	protected virtual ImageButton imbCal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableCell3")]
	protected virtual TableCell TableCell3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual ImageButton imgToday
	{
		[CompilerGenerated]
		get
		{
			return _imgToday;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			ImageClickEventHandler val = new ImageClickEventHandler(imgToday_Click);
			ImageButton val2 = _imgToday;
			if (val2 != null)
			{
				val2.Click -= val;
			}
			_imgToday = value;
			val2 = _imgToday;
			if (val2 != null)
			{
				val2.Click += val;
			}
		}
	}

	[field: AccessedThroughProperty("TimeTable")]
	protected virtual Table TimeTable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TimeSectionR1")]
	protected virtual TableRow TimeSectionR1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TimeSectionR1C1")]
	protected virtual TableCell TimeSectionR1C1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DropDownList Ore
	{
		[CompilerGenerated]
		get
		{
			return _Ore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ore_SelectedIndexChanged;
			DropDownList ore = _Ore;
			if (ore != null)
			{
				((ListControl)ore).SelectedIndexChanged -= eventHandler;
			}
			_Ore = value;
			ore = _Ore;
			if (ore != null)
			{
				((ListControl)ore).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("TimeSectionR1C2")]
	protected virtual TableCell TimeSectionR1C2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DropDownList Minuti
	{
		[CompilerGenerated]
		get
		{
			return _Minuti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ore_SelectedIndexChanged;
			DropDownList minuti = _Minuti;
			if (minuti != null)
			{
				((ListControl)minuti).SelectedIndexChanged -= eventHandler;
			}
			_Minuti = value;
			minuti = _Minuti;
			if (minuti != null)
			{
				((ListControl)minuti).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("TimeSectionR1C3")]
	protected virtual TableCell TimeSectionR1C3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DropDownList Secondi
	{
		[CompilerGenerated]
		get
		{
			return _Secondi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ore_SelectedIndexChanged;
			DropDownList secondi = _Secondi;
			if (secondi != null)
			{
				((ListControl)secondi).SelectedIndexChanged -= eventHandler;
			}
			_Secondi = value;
			secondi = _Secondi;
			if (secondi != null)
			{
				((ListControl)secondi).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(false)]
	[Description("Indica se attivare o meno l'autopostback del controllo")]
	public bool AutoPostBack { get; set; }

	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(false)]
	[Description("Indica se mostrare o meno il pulsante today")]
	public bool ShowTodayButton { get; set; }

	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(true)]
	[Description("Indica se il calendario è visibile quando il controllo è disattivato")]
	public bool CalendarVisibleIfDisabled { get; set; }

	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(typeof(IboWebDate), "DateOnly")]
	[Description("Indica il tipo di controllo da visualizzare")]
	public IboWebDateType ControlType
	{
		get
		{
			return _ControlType;
		}
		set
		{
			_ControlType = value;
		}
	}

	public string InternalClientID => ((Control)IboWebDate_txtInput).ClientID;

	public string TooltipForButton
	{
		get
		{
			return ((WebControl)imbCal).ToolTip;
		}
		set
		{
			((WebControl)imbCal).ToolTip = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(80)]
	[Description("Larghezza della casella di testo del controllo")]
	public Unit Width
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			return ((WebControl)IboWebDate_txtInput).Width;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			((WebControl)IboWebDate_txtInput).Width = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Larghezza del contenitore del controllo")]
	public Unit ContainerWidth
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			return ((WebControl)pnlComponent).Width;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			((WebControl)pnlComponent).Width = value;
		}
	}

	public eAlignement ContainerAlignement
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return _ContainerAlignement;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected I4, but got Unknown
			_ContainerAlignement = value;
			try
			{
				((WebControl)pnlComponent).Style.Remove("align-text");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			switch ((int)value)
			{
			case 2:
				((WebControl)pnlComponent).Style.Add("align-text", "center");
				break;
			case 0:
				((WebControl)pnlComponent).Style.Add("align-text", "left");
				break;
			case 1:
				((WebControl)pnlComponent).Style.Add("align-text", "right");
				break;
			}
		}
	}

	public string DateControlCSSClass
	{
		get
		{
			return IboWebDate_txtInput.CssClass;
		}
		set
		{
			if (!IboWebDate_txtInput.CssClass.Contains(value))
			{
				IboWebTextBox iboWebDate_txtInput;
				(iboWebDate_txtInput = IboWebDate_txtInput).CssClass = iboWebDate_txtInput.CssClass + " " + value;
			}
		}
	}

	public string Text
	{
		get
		{
			string text = "";
			if (_ControlType == IboWebDateType.DateOnly)
			{
				text = IboWebDate_txtInput.Text;
			}
			else if (_ControlType == IboWebDateType.DateAndTime)
			{
				text = IboWebDate_txtInput.Text;
				if ((Operators.CompareString(((ListControl)Ore).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Minuti).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Secondi).Text, "", false) != 0))
				{
					text += " ";
					text = text + Interaction.IIf(Operators.CompareString(((ListControl)Ore).Text, "", false) == 0, (object)"00", (object)((ListControl)Ore).Text).ToString() + ":" + Interaction.IIf(Operators.CompareString(((ListControl)Minuti).Text, "", false) == 0, (object)"00", (object)((ListControl)Minuti).Text).ToString() + ":" + Interaction.IIf(Operators.CompareString(((ListControl)Secondi).Text, "", false) == 0, (object)"00", (object)((ListControl)Secondi).Text).ToString();
				}
			}
			else if (_ControlType == IboWebDateType.TimeOnly && ((Operators.CompareString(((ListControl)Ore).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Minuti).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Secondi).Text, "", false) != 0)))
			{
				text = Interaction.IIf(Operators.CompareString(((ListControl)Ore).Text, "", false) == 0, (object)"00", (object)((ListControl)Ore).Text).ToString() + ":" + Interaction.IIf(Operators.CompareString(((ListControl)Minuti).Text, "", false) == 0, (object)"00", (object)((ListControl)Minuti).Text).ToString() + ":" + Interaction.IIf(Operators.CompareString(((ListControl)Secondi).Text, "", false) == 0, (object)"00", (object)((ListControl)Secondi).Text).ToString();
			}
			return text;
		}
		set
		{
			if (_ControlType == IboWebDateType.DateOnly)
			{
				if (Operators.CompareString(_FormatoData, "", false) != 0)
				{
					IboWebDate_txtInput.Text = Strings.Left(value.Trim(), Strings.Len(_FormatoData));
				}
				else
				{
					IboWebDate_txtInput.Text = value.Trim();
				}
			}
			else if (_ControlType == IboWebDateType.DateAndTime)
			{
				string text = "";
				string text2 = "";
				string[] array = Strings.Split(value, " ", -1, (CompareMethod)0);
				if (array.Count() > 0)
				{
					text = array[0];
				}
				if (array.Count() > 1)
				{
					text2 = array[1];
				}
				if (Operators.CompareString(_FormatoData, "", false) != 0)
				{
					IboWebDate_txtInput.Text = Strings.Left(text.Trim(), Strings.Len(_FormatoData));
				}
				else
				{
					IboWebDate_txtInput.Text = text.Trim();
				}
				text2 = Strings.Replace(text2, ".", ":", 1, -1, (CompareMethod)0);
				string[] array2 = Strings.Split(text2, ":", -1, (CompareMethod)0);
				if (array2.Count() > 0)
				{
					((ListControl)Ore).Text = array2[0];
				}
				else
				{
					((ListControl)Ore).Text = "";
				}
				if (array2.Count() > 1)
				{
					((ListControl)Minuti).Text = array2[1];
				}
				else
				{
					((ListControl)Minuti).Text = "";
				}
				if (array2.Count() > 2)
				{
					((ListControl)Secondi).Text = array2[2];
				}
				else
				{
					((ListControl)Secondi).Text = "";
				}
				if ((Operators.CompareString(((ListControl)Ore).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Minuti).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Secondi).Text, "", false) != 0) | (Operators.CompareString(IboWebDate_txtInput.Text, "", false) != 0))
				{
					if (Operators.CompareString(((ListControl)Ore).Text, "", false) == 0)
					{
						((ListControl)Ore).Text = "00";
					}
					if (Operators.CompareString(((ListControl)Minuti).Text, "", false) == 0)
					{
						((ListControl)Minuti).Text = "00";
					}
					if (Operators.CompareString(((ListControl)Secondi).Text, "", false) == 0)
					{
						((ListControl)Secondi).Text = "00";
					}
				}
			}
			else if (_ControlType == IboWebDateType.TimeOnly)
			{
				string text3 = value;
				if (Operators.CompareString(text3, "", false) == 0)
				{
					IboWebDate_txtInput.Text = "";
					((ListControl)Ore).Text = "";
					((ListControl)Minuti).Text = "";
					((ListControl)Secondi).Text = "";
				}
				else
				{
					string[] array3 = text3.Split(new char[1] { ' ' });
					if (array3.Count() > 1)
					{
						text3 = array3[1];
					}
					text3 = Strings.Replace(text3, ".", ":", 1, -1, (CompareMethod)0);
					string[] array4 = Strings.Split(text3, ":", -1, (CompareMethod)0);
					if (array4.Count() > 0)
					{
						((ListControl)Ore).Text = array4[0];
					}
					else
					{
						((ListControl)Ore).Text = "";
					}
					if (array4.Count() > 1)
					{
						((ListControl)Minuti).Text = array4[1];
					}
					else
					{
						((ListControl)Minuti).Text = "";
					}
					if (array4.Count() > 2)
					{
						((ListControl)Secondi).Text = array4[2];
					}
					else
					{
						((ListControl)Secondi).Text = "";
					}
					if ((Operators.CompareString(((ListControl)Ore).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Minuti).Text, "", false) != 0) | (Operators.CompareString(((ListControl)Secondi).Text, "", false) != 0))
					{
						if (Operators.CompareString(((ListControl)Ore).Text, "", false) == 0)
						{
							((ListControl)Ore).Text = "00";
						}
						if (Operators.CompareString(((ListControl)Minuti).Text, "", false) == 0)
						{
							((ListControl)Minuti).Text = "00";
						}
						if (Operators.CompareString(((ListControl)Secondi).Text, "", false) == 0)
						{
							((ListControl)Secondi).Text = "00";
						}
					}
				}
			}
			((BaseValidator)mevInput).Validate();
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore di tipo oggetto del controllo")]
	public object ObjValue
	{
		get
		{
			return Text;
		}
		set
		{
			Text = value.ToString();
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore di tipo date del controllo (sola lettura)")]
	public DateTime getDateValue
	{
		get
		{
			if (Operators.CompareString(Text, "", false) == 0)
			{
				return DateTime.MinValue;
			}
			if (ControlType == IboWebDateType.DateOnly)
			{
				return DateTime.ParseExact(Text, _FormatoData, CultureInfo.CurrentCulture);
			}
			if (ControlType == IboWebDateType.TimeOnly)
			{
				return DateTime.ParseExact(Text, _FormatoOra, CultureInfo.CurrentCulture);
			}
			if (ControlType == IboWebDateType.DateAndTime)
			{
				return DateTime.ParseExact(Text, _FormatoData + " " + _FormatoOra, CultureInfo.CurrentCulture);
			}
			DateTime result = default(DateTime);
			return result;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore di tipo Nullable of date del controllo (sola lettura)")]
	public DateTime? getDateValue2
	{
		get
		{
			DateTime? result = default(DateTime?);
			if (Operators.CompareString(Text, "", false) == 0)
			{
				result = null;
			}
			else if (ControlType == IboWebDateType.DateOnly)
			{
				result = DateTime.ParseExact(Text, _FormatoData, CultureInfo.CurrentCulture);
			}
			else if (ControlType == IboWebDateType.TimeOnly)
			{
				result = DateTime.ParseExact(Text, "HH:mm:ss", CultureInfo.CurrentCulture);
			}
			else if (ControlType == IboWebDateType.DateAndTime)
			{
				result = DateTime.ParseExact(Text, _FormatoData + " HH:mm:ss", CultureInfo.CurrentCulture);
			}
			return result;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore di tipo date del controllo (lettura e scrittura)")]
	public DateTime DateValue
	{
		get
		{
			return getDateValue;
		}
		set
		{
			if (ControlType == IboWebDateType.DateOnly)
			{
				Text = Strings.Format((object)value, _FormatoData);
			}
			else if (ControlType == IboWebDateType.TimeOnly)
			{
				Text = Strings.Format((object)value, _FormatoOra);
			}
			else if (ControlType == IboWebDateType.DateAndTime)
			{
				Text = Strings.Format((object)value, _FormatoData + " " + _FormatoOra);
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore di tipo Nullable of date del controllo (lettura e scrittura)")]
	public DateTime? DateValue2
	{
		get
		{
			return getDateValue2;
		}
		set
		{
			if (!value.HasValue)
			{
				Text = "";
			}
			else if (ControlType == IboWebDateType.DateOnly)
			{
				Text = Strings.Format((object)value, _FormatoData);
			}
			else if (ControlType == IboWebDateType.TimeOnly)
			{
				Text = Strings.Format((object)value, _FormatoOra);
			}
			else if (ControlType == IboWebDateType.DateAndTime)
			{
				Text = Strings.Format((object)value, _FormatoData + " " + _FormatoOra);
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Restituisce o setta il valore delle ore")]
	public int HoursValue
	{
		get
		{
			if (_ControlType == IboWebDateType.DateOnly)
			{
				return 0;
			}
			return Conversions.ToInteger(Interaction.IIf(Operators.CompareString(((ListControl)Ore).Text, "", false) == 0, (object)0, (object)Conversions.ToInteger(((ListControl)Ore).Text)));
		}
		set
		{
			if (_ControlType != 0)
			{
				((ListControl)Ore).SelectedValue = value.ToString();
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Restituisce o setta il valore dei minuti")]
	public int MinutesValue
	{
		get
		{
			if (_ControlType == IboWebDateType.DateOnly)
			{
				return 0;
			}
			return Conversions.ToInteger(Interaction.IIf(Operators.CompareString(((ListControl)Minuti).Text, "", false) == 0, (object)0, (object)Conversions.ToInteger(((ListControl)Minuti).Text)));
		}
		set
		{
			if (_ControlType != 0)
			{
				((ListControl)Minuti).SelectedValue = value.ToString();
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Restituisce o setta il valore dei secondi")]
	public int SecondsValue
	{
		get
		{
			if (_ControlType == IboWebDateType.DateOnly)
			{
				return 0;
			}
			return Conversions.ToInteger(Interaction.IIf(Operators.CompareString(((ListControl)Secondi).Text, "", false) == 0, (object)0, (object)Conversions.ToInteger(((ListControl)Secondi).Text)));
		}
		set
		{
			if (_ControlType != 0)
			{
				((ListControl)Secondi).SelectedValue = value.ToString();
			}
		}
	}

	public bool IsValid
	{
		get
		{
			((BaseValidator)mevInput).Validate();
			return ((BaseValidator)mevInput).IsValid;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Definisce se il controllo è chiave di una tabella")]
	public virtual bool IsKey
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["IsKey"]);
			if (obj == null)
			{
				obj = false;
			}
			return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(obj));
		}
		set
		{
			this.ViewState["IsKey"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Trim automatico degli spazi iniziali e finali del campo")]
	public bool AutoTrim
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["AutoTrim"]);
			if (obj == null)
			{
				obj = false;
			}
			return Conversions.ToBoolean(obj);
		}
		set
		{
			this.ViewState["AutoTrim"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Identifica l'abilitazione del controllo al multilingua")]
	public virtual bool Translate
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["Translate"]);
			if (obj == null)
			{
				obj = true;
			}
			return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(obj));
		}
		set
		{
			this.ViewState["Translate"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Tag generico")]
	public virtual string IncasTag
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["IncasTag"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["IncasTag"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Indica l'obbligatorietà del campo")]
	public virtual bool Required
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["Required"]);
			if (obj == null)
			{
				obj = false;
			}
			return Conversions.ToBoolean(obj);
		}
		set
		{
			this.ViewState["Required"] = value;
		}
	}

	public string CssClass
	{
		get
		{
			return ((WebControl)pnlComponent).CssClass;
		}
		set
		{
			((WebControl)pnlComponent).CssClass = value;
		}
	}

	public string Tooltip
	{
		get
		{
			return IboWebDate_txtInput.ToolTip;
		}
		set
		{
			IboWebDate_txtInput.ToolTip = value;
			((WebControl)Ore).ToolTip = value;
			((WebControl)Minuti).ToolTip = value;
			((WebControl)Secondi).ToolTip = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Id del pannello a cui appartiene il campo. Lasciare vuota se il campo gestisce un campo del master record")]
	public string DetailPanelId
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["DetailPanelId"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["DetailPanelId"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Nome del campo")]
	public string FieldName
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["FieldName"]);
			if (obj == null)
			{
				obj = ((Operators.CompareString(Strings.Left(((Control)this).ID, 3).ToUpper(), "TXT", false) != 0) ? "" : ((Control)this).ID.Substring(3));
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["FieldName"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Descrizione del campo")]
	public string FieldDescription
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["FieldDescription"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["FieldDescription"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Rende il componente in sola lettura")]
	public virtual bool ReadOnly
	{
		get
		{
			return IboWebDate_txtInput.ReadOnly;
		}
		set
		{
			IboWebDate_txtInput.ReadOnly = value;
			((WebControl)Ore).Enabled = !value;
			((WebControl)Minuti).Enabled = !value;
			((WebControl)Secondi).Enabled = !value;
			if (CalendarVisibleIfDisabled)
			{
				imbCal.Enabled = !value;
				imgToday.Enabled = !value;
			}
			else if (value)
			{
				((Control)imbCal).Visible = false;
				((Control)imgToday).Visible = false;
			}
			else
			{
				imbCal.Enabled = !value;
				imgToday.Enabled = !value;
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(true)]
	[Localizable(true)]
	[Description("Abilitazione del controllo")]
	public bool Enabled
	{
		get
		{
			return IboWebDate_txtInput.Enabled;
		}
		set
		{
			IboWebDate_txtInput.Enabled = value;
			((WebControl)Ore).Enabled = value;
			((WebControl)Minuti).Enabled = value;
			((WebControl)Secondi).Enabled = value;
			if (CalendarVisibleIfDisabled)
			{
				imbCal.Enabled = value;
				imgToday.Enabled = value;
			}
			else if (!value)
			{
				((Control)imbCal).Visible = false;
				((Control)imgToday).Visible = false;
			}
			else
			{
				imbCal.Enabled = value;
				imgToday.Enabled = value;
			}
		}
	}

	public override bool Visible
	{
		get
		{
			return ((Control)this).Visible;
		}
		set
		{
			((Control)this).Visible = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(typeof(ValidationRulesType), "None")]
	[Localizable(true)]
	[Description("Regole di validazione")]
	public virtual ValidationRulesType ValidationRules
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["ValidationRules"]);
			if (obj == null)
			{
				obj = (object)(ValidationRulesType)0;
			}
			return (ValidationRulesType)obj;
		}
		set
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			this.ViewState["ValidationRules"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue("")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Valore iniziale del controllo (al primo caricamento di pagina)")]
	public object InitialValue
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["InitialValue"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["InitialValue"] = value.ToString();
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(true)]
	[Localizable(true)]
	[Description("Indica se il controllo anche se renderizzato debba essere o meno visibile sul client")]
	public virtual bool Display
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["Display"]);
			if (obj == null)
			{
				obj = true;
			}
			return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(obj));
		}
		set
		{
			this.ViewState["Display"] = value;
			Enabled = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(true)]
	[Localizable(true)]
	[Description("Indica se il controllo anche se renderizzato debba essere o meno visibile sul client lasciando comunque lo spazio per il suo posto (visibility=hidden")]
	public virtual bool ClientVisibility
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["ClientVisibility"]);
			if (obj == null)
			{
				obj = true;
			}
			return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(obj));
		}
		set
		{
			this.ViewState["ClientVisibility"] = value;
			Enabled = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(typeof(IboWebComponentDataType), "Date")]
	[Localizable(true)]
	[Description("Tipo di dato gestito dal controllo")]
	public IboWebComponentDataType FieldDataType
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return _FieldDataType;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_FieldDataType = value;
		}
	}

	[Bindable(true)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Formattazione del valore che viene applicata in fase di assegnamento della proprietà objValue")]
	public virtual string FormatString
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["FormatString"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["FormatString"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Query di lookup per la trascodifica del valore")]
	public virtual string SqlQueryLookup
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["SqlQueryLookup"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["SqlQueryLookup"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Campo della Query di lookup per la trascodifica del valore")]
	public virtual string SqlQueryLookupField
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["SqlQueryLookupField"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["SqlQueryLookupField"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Custom Tag generico")]
	public virtual string CustomTag
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["CustomTag"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["CustomTag"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Id del Tooltip")]
	public virtual string TitleId
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["TitleId"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["TitleId"] = value;
		}
	}

	public event DateTimeChangedEventHandler DateTimeChanged;

	public IboWebDate()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Load += Page_Load;
		((Control)this).PreRender += Page_PreRender;
		_FormatoData = "dd/MM/yyyy";
		_FormatoOra = "HH:mm:ss";
		_ControlType = IboWebDateType.DateOnly;
		AutoPostBack = false;
		ShowTodayButton = false;
		CalendarVisibleIfDisabled = true;
		_FieldDataType = (IboWebComponentDataType)2;
	}

	public override void Focus()
	{
		((Control)this).Focus();
		((Control)IboWebDate_txtInput).Focus();
	}

	public override void RenderControl(HtmlTextWriter writer)
	{
		((Control)this).RenderControl(writer);
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Svuota il valore del controllo")]
	public void Clear()
	{
		ObjValue = "";
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Ripristina il valore del controllo al valore iniziale")]
	public void ToInitialValue()
	{
		ObjValue = RuntimeHelpers.GetObjectValue(InitialValue);
	}

	private void imgToday_Click(object sender, ImageClickEventArgs e)
	{
		if (_ControlType == IboWebDateType.DateOnly)
		{
			ObjValue = Strings.Format((object)DateAndTime.Now.Date, _FormatoData);
		}
		else if (_ControlType == IboWebDateType.DateAndTime)
		{
			ObjValue = Strings.Format((object)DateAndTime.Now.Date, _FormatoData);
			((ListControl)Ore).Text = DateAndTime.Now.Hour.ToString().PadLeft(2, '0');
			((ListControl)Minuti).Text = DateAndTime.Now.Minute.ToString().PadLeft(2, '0');
			((ListControl)Secondi).Text = DateAndTime.Now.Second.ToString().PadLeft(2, '0');
		}
		else if (_ControlType == IboWebDateType.TimeOnly)
		{
			((ListControl)Ore).Text = DateAndTime.Now.Hour.ToString().PadLeft(2, '0');
			((ListControl)Minuti).Text = DateAndTime.Now.Minute.ToString().PadLeft(2, '0');
			((ListControl)Secondi).Text = DateAndTime.Now.Second.ToString().PadLeft(2, '0');
		}
	}

	private void Page_Load(object sender, EventArgs e)
	{
		if ((ControlType == IboWebDateType.DateAndTime) | (ControlType == IboWebDateType.DateOnly))
		{
			((TextBox)IboWebDate_txtInput).AutoPostBack = AutoPostBack;
			((ListControl)Ore).AutoPostBack = false;
			((ListControl)Minuti).AutoPostBack = false;
			((ListControl)Secondi).AutoPostBack = false;
		}
		else
		{
			((TextBox)IboWebDate_txtInput).AutoPostBack = false;
			((ListControl)Ore).AutoPostBack = AutoPostBack;
			((ListControl)Minuti).AutoPostBack = AutoPostBack;
			((ListControl)Secondi).AutoPostBack = AutoPostBack;
		}
	}

	private void Page_PreRender(object sender, EventArgs e)
	{
		try
		{
			if (!Display)
			{
				((WebControl)pnlComponent).Style.Add("display", "none");
			}
			if (!ClientVisibility)
			{
				((WebControl)pnlComponent).Style.Add("visibility", "hidden");
			}
			if (!Enabled | ReadOnly)
			{
				if (CalendarVisibleIfDisabled)
				{
					imbCal.Enabled = false;
					imgToday.Enabled = false;
				}
				else
				{
					((Control)imbCal).Visible = false;
					((Control)imgToday).Visible = false;
				}
			}
			if (!ShowTodayButton)
			{
				((Control)imgToday).Visible = false;
			}
			else
			{
				((Control)imgToday).Visible = true;
			}
			((WebControl)pnlContainer).CssClass = ((WebControl)pnlContainer).CssClass.Replace("DateAndTime", "");
			((WebControl)pnlContainer).CssClass = ((WebControl)pnlContainer).CssClass.Replace("TimeOnly", "");
			((WebControl)pnlContainer).CssClass = ((WebControl)pnlContainer).CssClass.Replace("DateOnly", "");
			((WebControl)pnlContainer).CssClass = ((WebControl)pnlContainer).CssClass.Trim();
			if (_ControlType == IboWebDateType.DateOnly)
			{
				((Control)DateTable).Visible = true;
				((Control)TimeTable).Visible = false;
				Panel val;
				((WebControl)(val = pnlContainer)).CssClass = ((WebControl)val).CssClass + " DateOnly";
			}
			else if (_ControlType == IboWebDateType.DateAndTime)
			{
				((Control)DateTable).Visible = true;
				((Control)TimeTable).Visible = true;
				Panel val;
				((WebControl)(val = pnlContainer)).CssClass = ((WebControl)val).CssClass + " DateAndTime";
			}
			else if (_ControlType == IboWebDateType.TimeOnly)
			{
				((Control)DateTable).Visible = false;
				((Control)TimeTable).Visible = true;
				Panel val;
				((WebControl)(val = pnlContainer)).CssClass = ((WebControl)val).CssClass + " TimeOnly";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void IboWebDate_txtInput_TextChanged(object sender, EventArgs e)
	{
		if ((ControlType == IboWebDateType.DateOnly) | (ControlType == IboWebDateType.DateAndTime))
		{
			DateTimeChanged?.Invoke(this, new EventArgs());
		}
	}

	private void Ore_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ControlType == IboWebDateType.TimeOnly)
		{
			DateTimeChanged?.Invoke(this, new EventArgs());
		}
	}
}
