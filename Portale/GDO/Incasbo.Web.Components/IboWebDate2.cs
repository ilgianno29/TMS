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

public class IboWebDate2 : UserControl, IIboWebComponent
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
	[AccessedThroughProperty("IboWebTime_txtInput")]
	private IboWebTextBox _IboWebTime_txtInput;

	private eAlignement _ContainerAlignement;

	protected string _FormatoData;

	protected string _FormatoOra;

	protected IboWebDateType _ControlType;

	protected int _Ore;

	protected int _Minuti;

	protected int _Secondi;

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

	[field: AccessedThroughProperty("TableCell1")]
	protected virtual TableCell TableCell1
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

	[field: AccessedThroughProperty("TableCell2")]
	protected virtual TableCell TableCell2
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

	[field: AccessedThroughProperty("AllTimeSection")]
	protected virtual TableRow AllTimeSection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AllTimeSectionR1C1")]
	protected virtual TableCell AllTimeSectionR1C1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebTextBox IboWebTime_txtInput
	{
		[CompilerGenerated]
		get
		{
			return _IboWebTime_txtInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = IboWebTime_txtInput_TextChanged;
			IboWebTextBox iboWebTime_txtInput = _IboWebTime_txtInput;
			if (iboWebTime_txtInput != null)
			{
				((TextBox)iboWebTime_txtInput).TextChanged -= eventHandler;
			}
			_IboWebTime_txtInput = value;
			iboWebTime_txtInput = _IboWebTime_txtInput;
			if (iboWebTime_txtInput != null)
			{
				((TextBox)iboWebTime_txtInput).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("meeInputTime")]
	protected virtual MaskedEditExtender meeInputTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mevInputTime")]
	protected virtual MaskedEditValidator mevInputTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public string InternalClientID
	{
		get
		{
			if (ControlType == IboWebDateType.TimeOnly)
			{
				return ((Control)IboWebTime_txtInput).ClientID;
			}
			return ((Control)IboWebDate_txtInput).ClientID;
		}
	}

	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue("HH:mm:ss")]
	[Description("Formato dell'ora da visualizzare")]
	public string FormatoOra
	{
		get
		{
			return _FormatoOra;
		}
		set
		{
			_FormatoOra = value;
			if (Strings.Len(value) == 5)
			{
				meeInputTime.Mask = "99:99";
				meeInputTime.AutoCompleteValue = "00:00";
			}
			else if (Strings.Len(value) == 8)
			{
				meeInputTime.Mask = "99:99:99";
				meeInputTime.AutoCompleteValue = "00:00:99";
			}
		}
	}

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
	[Description("Larghezza della casella di testo del controllo (data)")]
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
	[DefaultValue(60)]
	[Description("Larghezza della casella di testo del controllo (Time)")]
	public Unit TimeControlWidth
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			Width = ((WebControl)IboWebTime_txtInput).Width;
			Unit result = default(Unit);
			return result;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			((WebControl)IboWebTime_txtInput).Width = value;
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

	public string TimeControlCSSClass
	{
		get
		{
			return IboWebTime_txtInput.CssClass;
		}
		set
		{
			if (!IboWebTime_txtInput.CssClass.Contains(value))
			{
				IboWebTextBox iboWebTime_txtInput;
				(iboWebTime_txtInput = IboWebTime_txtInput).CssClass = iboWebTime_txtInput.CssClass + " " + value;
			}
		}
	}

	public string Text
	{
		get
		{
			string result = "";
			if (_ControlType == IboWebDateType.DateOnly)
			{
				result = IboWebDate_txtInput.Text;
			}
			else if (_ControlType == IboWebDateType.DateAndTime)
			{
				if (Operators.CompareString(IboWebDate_txtInput.Text, "", false) != 0)
				{
					ImpostaOra();
					result = IboWebDate_txtInput.Text;
					result += " ";
					result = result + _Ore.ToString().PadLeft(2, '0') + ":" + _Minuti.ToString().PadLeft(2, '0') + ":" + _Secondi.ToString().PadLeft(2, '0');
				}
				else
				{
					result = "";
				}
			}
			else if (_ControlType == IboWebDateType.TimeOnly)
			{
				if (Operators.CompareString(IboWebTime_txtInput.Text, "", false) != 0)
				{
					ImpostaOra();
					result = _Ore.ToString().PadLeft(2, '0') + ":" + _Minuti.ToString().PadLeft(2, '0') + ":" + _Secondi.ToString().PadLeft(2, '0');
				}
				else
				{
					result = "";
				}
			}
			return result;
		}
		set
		{
			value = value.Trim();
			if (_ControlType == IboWebDateType.DateOnly)
			{
				if (Operators.CompareString(_FormatoData, "", false) != 0)
				{
					IboWebDate_txtInput.Text = Strings.Left(value, Strings.Len(_FormatoData));
				}
				else
				{
					IboWebDate_txtInput.Text = value;
				}
			}
			else if (_ControlType == IboWebDateType.DateAndTime)
			{
				string text = "";
				string text2 = "";
				if (Operators.CompareString(value, "", false) == 0)
				{
					IboWebDate_txtInput.Text = "";
					IboWebTime_txtInput.Text = "";
				}
				else
				{
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
					if (Operators.CompareString(_FormatoOra, "", false) != 0)
					{
						IboWebTime_txtInput.Text = Strings.Left(text2.Trim(), Strings.Len(_FormatoOra));
					}
					else
					{
						IboWebTime_txtInput.Text = text2.Trim();
					}
					ImpostaOra();
				}
			}
			else if (_ControlType == IboWebDateType.TimeOnly)
			{
				string text3 = value;
				if (Operators.CompareString(text3, "", false) == 0)
				{
					IboWebTime_txtInput.Text = "";
				}
				else
				{
					string[] array2 = text3.Split(new char[1] { ' ' });
					if (array2.Count() > 1)
					{
						text3 = array2[1];
					}
					text3 = text3.Trim().Replace(".", ":").Replace(" ", ":");
					string[] array3 = text3.Split(new char[1] { ':' });
					if (Operators.CompareString(_FormatoOra, "HH:mm", false) == 0)
					{
						IboWebTime_txtInput.Text = array3[0] + ":" + array3[1];
					}
					else if (Operators.CompareString(_FormatoOra, "HH:mm:ss", false) == 0)
					{
						IboWebTime_txtInput.Text = array3[0] + ":" + array3[1] + ":" + array3[2];
					}
					ImpostaOra();
				}
			}
			((BaseValidator)mevInput).Validate();
			((BaseValidator)mevInputTime).Validate();
		}
	}

	public bool IsValid
	{
		get
		{
			((BaseValidator)mevInputTime).Validate();
			((BaseValidator)mevInput).Validate();
			return ((BaseValidator)mevInputTime).IsValid & ((BaseValidator)mevInput).IsValid;
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
				return DateTime.ParseExact(Text, "HH:mm:ss", CultureInfo.CurrentCulture);
			}
			if (ControlType == IboWebDateType.DateAndTime)
			{
				return DateTime.ParseExact(Text, _FormatoData + " HH:mm:ss", CultureInfo.CurrentCulture);
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
			ImpostaOra();
			return _Ore;
		}
		set
		{
			ImpostaOra();
			_Ore = value;
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
			ImpostaOra();
			return _Minuti;
		}
		set
		{
			ImpostaOra();
			_Minuti = value;
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
			ImpostaOra();
			return _Minuti;
		}
		set
		{
			ImpostaOra();
			_Secondi = value;
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
			IboWebTime_txtInput.ToolTip = value;
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
			IboWebTime_txtInput.ReadOnly = value;
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
			IboWebTime_txtInput.Enabled = value;
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

	public IboWebDate2()
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
		if (ControlType == IboWebDateType.TimeOnly)
		{
			((Control)IboWebTime_txtInput).Focus();
		}
		else
		{
			((Control)IboWebDate_txtInput).Focus();
		}
	}

	protected void ImpostaOra()
	{
		if (Operators.CompareString(IboWebTime_txtInput.Text, "", false) == 0)
		{
			IboWebTime_txtInput.Text = meeInputTime.AutoCompleteValue;
		}
		_Ore = 0;
		_Minuti = 0;
		_Secondi = 0;
		string[] array = IboWebTime_txtInput.Text.Split(new char[1] { ':' });
		if (array.Count() > 0)
		{
			_Ore = Conversions.ToInteger(array[0]);
		}
		if (array.Count() > 1)
		{
			_Minuti = Conversions.ToInteger(array[1]);
		}
		if (array.Count() > 2)
		{
			_Secondi = Conversions.ToInteger(array[2]);
		}
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
			ObjValue = Strings.Format((object)DateAndTime.Now, _FormatoData + " " + _FormatoOra);
		}
		else if (_ControlType == IboWebDateType.TimeOnly)
		{
			ObjValue = Strings.Format((object)DateAndTime.Now, _FormatoOra);
		}
	}

	private void Page_Load(object sender, EventArgs e)
	{
		if ((ControlType == IboWebDateType.DateAndTime) | (ControlType == IboWebDateType.DateOnly))
		{
			((TextBox)IboWebDate_txtInput).AutoPostBack = AutoPostBack;
			((TextBox)IboWebTime_txtInput).AutoPostBack = false;
		}
		else
		{
			((TextBox)IboWebDate_txtInput).AutoPostBack = false;
			((TextBox)IboWebTime_txtInput).AutoPostBack = AutoPostBack;
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

	private void IboWebTime_txtInput_TextChanged(object sender, EventArgs e)
	{
		if (ControlType == IboWebDateType.TimeOnly)
		{
			DateTimeChanged?.Invoke(this, new EventArgs());
		}
	}
}
