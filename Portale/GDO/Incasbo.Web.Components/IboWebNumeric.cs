using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Components;

public class IboWebNumeric : UserControl, IIboWebComponent
{
	public enum eMasking
	{
		IntegerMask,
		DoubleMask,
		FreeMask
	}

	public delegate void TextChangedEventHandler(object sender, EventArgs e);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("iwnTxtInput")]
	private IboWebTextBox _iwnTxtInput;

	protected string _Text;

	protected eMasking _MaskType;

	protected eAlignement _ContainerAlignement;

	protected eAlignement _TextAlignement;

	protected bool _EnableClientValidator;

	private string kIntegerMask;

	private string kDoubleMask;

	private string kFreeMask;

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

	protected virtual IboWebTextBox iwnTxtInput
	{
		[CompilerGenerated]
		get
		{
			return _iwnTxtInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = iwnTxtInput_PreRender;
			EventHandler eventHandler2 = iwnTxtInput_TextChanged;
			IboWebTextBox val = _iwnTxtInput;
			if (val != null)
			{
				((Control)val).PreRender -= eventHandler;
				((TextBox)val).TextChanged -= eventHandler2;
			}
			_iwnTxtInput = value;
			val = _iwnTxtInput;
			if (val != null)
			{
				((Control)val).PreRender += eventHandler;
				((TextBox)val).TextChanged += eventHandler2;
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

	public string InternalClientID => ((Control)iwnTxtInput).ClientID;

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(false)]
	[Localizable(true)]
	[Description("Determina se abilitare o meno l'auto postback del controllo")]
	public bool AutoPostBack
	{
		get
		{
			return ((TextBox)iwnTxtInput).AutoPostBack;
		}
		set
		{
			((TextBox)iwnTxtInput).AutoPostBack = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(99999999)]
	[Localizable(true)]
	[Description("Valore massimo che può assumere il controllo")]
	public double MaxValue
	{
		get
		{
			return Conversions.ToDouble(mevInput.MaximumValue);
		}
		set
		{
			mevInput.MaximumValue = Conversions.ToString(value);
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(0)]
	[Localizable(true)]
	[Description("Valore minimo che può assumere il controllo")]
	public double MinValue
	{
		get
		{
			return Conversions.ToDouble(mevInput.MinimumValue);
		}
		set
		{
			mevInput.MinimumValue = Conversions.ToString(value);
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("999999.99")]
	[Localizable(true)]
	[Description("Maschera per l'inserimento dei dati nel controllo")]
	public string Mask
	{
		get
		{
			return meeInput.Mask;
		}
		set
		{
			if (_MaskType == eMasking.FreeMask && Versioned.IsNumeric((object)Strings.Format((object)"0", value)))
			{
				meeInput.Mask = value;
			}
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(typeof(eMasking), "FreeMask")]
	[Localizable(true)]
	[Description("Tipo della maschera")]
	public eMasking MaskType
	{
		get
		{
			return _MaskType;
		}
		set
		{
			switch (value)
			{
			case eMasking.DoubleMask:
				meeInput.Mask = kDoubleMask;
				break;
			case eMasking.IntegerMask:
				meeInput.Mask = kIntegerMask;
				break;
			case eMasking.FreeMask:
				if (Operators.CompareString(meeInput.Mask, "", false) == 0)
				{
					meeInput.Mask = kFreeMask;
				}
				break;
			}
			_MaskType = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Abilita la validazione lato client")]
	public virtual bool EnableClientValidator
	{
		get
		{
			return _EnableClientValidator;
		}
		set
		{
			_EnableClientValidator = value;
		}
	}

	public string ValidationErrorMessage
	{
		get
		{
			return mevInput.ErrorMessage;
		}
		set
		{
			mevInput.ErrorMessage = value;
			mevInput.MaximumValueBlurredMessage = value;
			mevInput.MinimumValueBlurredText = value;
			mevInput.MaximumValueMessage = value;
			mevInput.MinimumValueMessage = value;
		}
	}

	public string ValidationTooltipMessage
	{
		get
		{
			return mevInput.TooltipMessage;
		}
		set
		{
			mevInput.TooltipMessage = value;
		}
	}

	public string ValidationEmptyValueMessage
	{
		get
		{
			return mevInput.EmptyValueMessage;
		}
		set
		{
			mevInput.EmptyValueMessage = value;
		}
	}

	public string OnFocusCssClass
	{
		get
		{
			return meeInput.OnFocusCssClass;
		}
		set
		{
			meeInput.OnFocusCssClass = value;
		}
	}

	public string OnInvalidCssClass
	{
		get
		{
			return meeInput.OnInvalidCssClass;
		}
		set
		{
			meeInput.OnInvalidCssClass = value;
		}
	}

	public TextBox ControlInput => (TextBox)(object)iwnTxtInput;

	public MaskedEditValidator ControlValidator => mevInput;

	public Unit Width
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return ((WebControl)iwnTxtInput).Width;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			((WebControl)iwnTxtInput).Width = value;
		}
	}

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

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(typeof(eAlignement), "Right")]
	[Localizable(true)]
	[Description("Allineamento del testo all'interno della casella")]
	public eAlignement TextAlignement
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return _TextAlignement;
		}
		set
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			_TextAlignement = value;
		}
	}

	public string ContainerCSSClass
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

	public bool Enabled
	{
		get
		{
			return iwnTxtInput.Enabled;
		}
		set
		{
			iwnTxtInput.Enabled = value;
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
	[DefaultValue(true)]
	[Localizable(true)]
	[Description("Indica l'obbligatorietà del campo")]
	public virtual bool Required
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["Required"]);
			if (obj == null)
			{
				obj = true;
			}
			return Conversions.ToBoolean(obj);
		}
		set
		{
			this.ViewState["Required"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Classe CSS")]
	public string CssClass
	{
		get
		{
			return iwnTxtInput.CssClass;
		}
		set
		{
			iwnTxtInput.CssClass = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Tooltip")]
	public string Tooltip
	{
		get
		{
			return iwnTxtInput.ToolTip;
		}
		set
		{
			iwnTxtInput.ToolTip = value;
		}
	}

	public string Text
	{
		get
		{
			return iwnTxtInput.Text;
		}
		set
		{
			iwnTxtInput.Text = value;
			_Text = value;
		}
	}

	public decimal? Value
	{
		get
		{
			return (Operators.CompareString(iwnTxtInput.Text.Trim(), "", false) != 0) ? new decimal?(Convert.ToDecimal(iwnTxtInput.Text)) : null;
		}
		set
		{
			if (value.HasValue)
			{
				string mask = Mask;
				string[] array = Strings.Split(mask, ".", -1, (CompareMethod)0);
				mask = ((array.Count() <= 1) ? "9" : ("9." + array[1]));
				iwnTxtInput.Text = Strings.Format((object)value, Strings.Replace(mask, "9", "0", 1, -1, (CompareMethod)0));
			}
			else
			{
				iwnTxtInput.Text = "";
			}
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
			decimal? value = Value;
			if (value.HasValue)
			{
				return value.Value;
			}
			return "";
		}
		set
		{
			if (Operators.CompareString(value.ToString(), "", false) == 0)
			{
				Value = null;
			}
			else
			{
				Value = Conversions.ToDecimal(value);
			}
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
			return iwnTxtInput.ReadOnly;
		}
		set
		{
			iwnTxtInput.ReadOnly = value;
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
				obj = 0;
			}
			if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)))
			{
				return Conversions.ToDecimal(obj);
			}
			return "";
		}
		set
		{
			if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(value)))
			{
				this.ViewState["InitialValue"] = Conversions.ToDecimal(value);
			}
			else
			{
				this.ViewState["InitialValue"] = "";
			}
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
	[DefaultValue(typeof(IboWebComponentDataType), "Number")]
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

	public event TextChangedEventHandler TextChanged;

	public IboWebNumeric()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		_Text = "";
		_MaskType = eMasking.FreeMask;
		_TextAlignement = (eAlignement)1;
		_EnableClientValidator = false;
		kIntegerMask = "999999";
		kDoubleMask = "999999.99";
		kFreeMask = "999999.99";
		_FieldDataType = (IboWebComponentDataType)1;
	}

	public override void Focus()
	{
		((Control)this).Focus();
		((Control)iwnTxtInput).Focus();
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Svuota il valore del controllo")]
	public void Clear()
	{
		ObjValue = 0;
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

	private void iwnTxtInput_PreRender(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		try
		{
			((WebControl)iwnTxtInput).Style.Remove("align-text");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		eAlignement textAlignement = TextAlignement;
		switch ((int)textAlignement)
		{
		case 2:
			((WebControl)iwnTxtInput).Style.Add("text-align", "center");
			break;
		case 0:
			((WebControl)iwnTxtInput).Style.Add("text-align", "left");
			break;
		case 1:
			((WebControl)iwnTxtInput).Style.Add("text-align", "right");
			break;
		}
		if (EnableClientValidator)
		{
			((Control)mevInput).Visible = true;
		}
		else
		{
			((Control)mevInput).Visible = false;
		}
		if (!Display)
		{
			((WebControl)pnlComponent).Style.Add("display", "none");
		}
		if (!ClientVisibility)
		{
			((WebControl)pnlComponent).Style.Add("visibility", "hidden");
		}
	}

	private void iwnTxtInput_TextChanged(object sender, EventArgs e)
	{
		TextChanged?.Invoke(this, e);
	}
}
