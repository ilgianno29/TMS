using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Components;

public class IboWebImage : UserControl, IIboWebComponent
{
	public enum IboWebImage_DataType
	{
		Blob,
		Link
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Canc")]
	private IboWebButton _Canc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mod")]
	private IboWebButton _mod;

	protected int _MaxBytes;

	protected IboWebComponentDataType _FieldDataType;

	[field: AccessedThroughProperty("pnlUP")]
	protected virtual UpdatePanel pnlUP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnl")]
	protected virtual Panel pnl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Main")]
	protected virtual Table Main
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TrImg")]
	protected virtual TableRow TrImg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HL")]
	protected virtual HyperLink HL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Img")]
	protected virtual System.Web.UI.WebControls.Image Img
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebImage_MsgDiv")]
	protected virtual Panel IboWebImage_MsgDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Mess")]
	protected virtual IboWebLabel Mess
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmd1")]
	protected virtual TableRow cmd1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton Canc
	{
		[CompilerGenerated]
		get
		{
			return _Canc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Canc_Click;
			IboWebButton canc = _Canc;
			if (canc != null)
			{
				((Button)canc).Click -= eventHandler;
			}
			_Canc = value;
			canc = _Canc;
			if (canc != null)
			{
				((Button)canc).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton mod
	{
		[CompilerGenerated]
		get
		{
			return _mod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = mod_Click;
			IboWebButton val = _mod;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_mod = value;
			val = _mod;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("FU")]
	protected virtual FileUpload FU
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmd2")]
	protected virtual TableCell cmd2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual string InternalClientID => ((Control)this).ClientID;

	public virtual string ImageUrl
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["ImageUrl"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			this.ViewState["ImageUrl"] = value;
			if ((Operators.CompareString(Path.GetExtension(value).ToUpper(), ".TIF", false) == 0) | (Operators.CompareString(Path.GetExtension(value).ToUpper(), ".TIFF", false) == 0))
			{
				try
				{
					string text = ((UserControl)this).MapPath(value);
					string text2 = Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(text) + ".jpg";
					string imageUrl = Path.GetDirectoryName(value) + "\\" + Path.GetFileNameWithoutExtension(value) + ".jpg";
					Bitmap val = new Bitmap(text);
					val = (Bitmap)System.Drawing.Image.FromFile(text);
					((System.Drawing.Image)val).Save(text2, ImageFormat.Jpeg);
					IboSessionEnvironment sessionEnvironment = MyWFIPage.SessionEnvironment;
					string rsMess = "";
					sessionEnvironment.AddFileToDelete(text2, ref rsMess);
					Img.ImageUrl = imageUrl;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (Operators.CompareString(Path.GetExtension(value).ToUpper(), ".PDF", false) == 0)
			{
				Img.ImageUrl = "~\\WFI\\Images\\PdfDocument.jpg";
			}
			else
			{
				Img.ImageUrl = value;
			}
		}
	}

	public virtual ImageAlign ImageAlign
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return Img.ImageAlign;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			Img.ImageAlign = value;
		}
	}

	public virtual string AlternateText
	{
		get
		{
			return Img.AlternateText;
		}
		set
		{
			Img.AlternateText = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(typeof(IboWebImage_DataType), "Blob")]
	[Localizable(true)]
	[Description("Definisce il tipo di dato gestito dal controllo")]
	public virtual IboWebImage_DataType DataType { get; set; }

	[Bindable(false)]
	[Browsable(false)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue("")]
	[Description("Url originario (Usato per before image)")]
	public virtual string OriginalImageUrl
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["OriginalImageUrl"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["OriginalImageUrl"] = value;
		}
	}

	protected WFIPage MyWFIPage => (WFIPage)(object)((Control)this).Page;

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue(102400)]
	[Description("Numero massimo di bytes accettati per l'immagine")]
	public virtual int MaxBytes
	{
		get
		{
			return _MaxBytes;
		}
		set
		{
			_MaxBytes = value;
		}
	}

	[Bindable(false)]
	[Browsable(false)]
	[Category("Incas")]
	[Localizable(true)]
	[DefaultValue("JPG")]
	[Description("Estensione del file immagine")]
	public virtual string FileExtension
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["FileExtension"]);
			if (obj == null)
			{
				obj = "JPG";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["FileExtension"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Nome del campo in cui è contenuta l'estensione del file")]
	public string FieldNameExtension
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["FieldNameExtension"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["FieldNameExtension"] = value;
		}
	}

	[Category("Appearance")]
	[Description("Abilita o meno l'autopostback durante la selezione dell'immagine")]
	[DefaultValue(true)]
	public bool AutoPostBack
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.ViewState["AutoPostBack"]);
			if (objectValue == null)
			{
				return true;
			}
			return (bool)objectValue;
		}
		set
		{
			this.ViewState["AutoPostBack"] = value;
		}
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[DefaultValue(true)]
	[Localizable(true)]
	[Description("Abilitazione del controllo")]
	public virtual bool Enabled
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["Enabled"]);
			if (obj == null)
			{
				obj = true;
			}
			return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(obj));
		}
		set
		{
			this.ViewState["Enabled"] = value;
			if (!value)
			{
				((Control)cmd1).Visible = false;
				((Control)cmd2).Visible = false;
			}
			else
			{
				((Control)cmd1).Visible = true;
				((Control)cmd2).Visible = true;
			}
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
			return false;
		}
		set
		{
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

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Classe CSS")]
	public string CssClass
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(this.ViewState["CssClass"]);
			if (obj == null)
			{
				obj = "";
			}
			return obj.ToString();
		}
		set
		{
			this.ViewState["CssClass"] = value;
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
			return ((WebControl)Img).ToolTip;
		}
		set
		{
			((WebControl)Img).ToolTip = value;
		}
	}

	public string Text
	{
		get
		{
			return "";
		}
		set
		{
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
			if (DataType == IboWebImage_DataType.Blob)
			{
				if (Operators.CompareString(ImageUrl, "", false) != 0)
				{
					string path = ((UserControl)this).MapPath(ImageUrl);
					if (File.Exists(path))
					{
						return File.ReadAllBytes(path);
					}
					return null;
				}
				return null;
			}
			if (DataType == IboWebImage_DataType.Link)
			{
				NotImplementedException ex = new NotImplementedException("Modalità IboWebImage_DataType.Link non implementata");
				throw ex;
			}
			object result = default(object);
			return result;
		}
		set
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			if (DataType == IboWebImage_DataType.Blob)
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) && value != null)
				{
					if (value is byte[] bytes)
					{
						string text = Guid.NewGuid().ToString() + "." + FileExtension;
						File.WriteAllBytes(MyWFIPage.SessionEnvironment.WebApplicationDownloadDir + text, bytes);
						IboSessionEnvironment sessionEnvironment = MyWFIPage.SessionEnvironment;
						string sNomeFile = MyWFIPage.SessionEnvironment.WebApplicationDownloadDir + text;
						string rsMess = "";
						sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess);
						ImageUrl = "~\\" + Strings.Replace(MyWFIPage.SessionEnvironment.WebApplicationDownloadDir, MyWFIPage.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + text;
						((Control)Img).Visible = true;
					}
				}
				else
				{
					ImageUrl = "";
					((Control)Img).Visible = true;
				}
			}
			else if (DataType == IboWebImage_DataType.Link)
			{
				NotImplementedException ex = new NotImplementedException("Modalità IboWebImage_DataType.Link non implementata");
				throw ex;
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
				obj = "";
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
			return !Enabled;
		}
		set
		{
			Enabled = !value;
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
			return null;
		}
		set
		{
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
	[DefaultValue(typeof(IboWebComponentDataType), "Blob")]
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

	public IboWebImage()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).PreRender += iwnTxtInput_PreRender;
		_MaxBytes = 512000;
		_FieldDataType = (IboWebComponentDataType)3;
	}

	public override void Focus()
	{
		((Control)this).Focus();
	}

	[Bindable(false)]
	[Browsable(true)]
	[Category("Incas")]
	[Localizable(true)]
	[Description("Svuota il valore del controllo")]
	public void Clear()
	{
		ObjValue = null;
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
		string text = "IboWebImage";
		if (Operators.CompareString(CssClass, "", false) != 0)
		{
			text = text + " " + CssClass;
		}
		((WebControl)pnl).CssClass = text;
		if (Operators.CompareString(Img.ImageUrl, "", false) == 0)
		{
			((Control)Img).Visible = false;
			Mess.Visible = true;
			((Control)IboWebImage_MsgDiv).Visible = true;
		}
		else
		{
			((Control)Img).Visible = true;
			Mess.Visible = false;
			((Control)IboWebImage_MsgDiv).Visible = false;
		}
		HL.NavigateUrl = ImageUrl;
		HL.Target = "_blank";
		if (!Display)
		{
			((WebControl)pnl).Style.Add("display", "none");
		}
		if (!ClientVisibility)
		{
			((WebControl)pnl).Style.Add("visibility", "hidden");
		}
		if (AutoPostBack)
		{
			string text2 = "document.getElementById('" + ((Control)mod).ClientID + "').click();";
			((WebControl)FU).Attributes["onchange"] = text2;
		}
	}

	private void mod_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataType == IboWebImage_DataType.Blob)
			{
				if (FU.HasFile)
				{
					if (FU.FileBytes.Count() > _MaxBytes)
					{
						MyWFIPage.WriteErrorMessage(MyWFIPage.TranslateMessage("XXX", "File troppo grande. Il numero massimo di bytes accettati è " + _MaxBytes));
						return;
					}
					FileInfo fileInfo = new FileInfo(FU.FileName);
					FileExtension = Strings.Replace(fileInfo.Extension, ".", "", 1, -1, (CompareMethod)0).ToUpper();
					ObjValue = FU.FileBytes;
				}
			}
			else if (DataType == IboWebImage_DataType.Link)
			{
				NotImplementedException ex = new NotImplementedException("Modalità IboWebImage_DataType.Link non implementata");
				throw ex;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void Canc_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataType == IboWebImage_DataType.Blob)
			{
				ObjValue = null;
			}
			else if (DataType == IboWebImage_DataType.Link)
			{
				NotImplementedException ex = new NotImplementedException("Modalità IboWebImage_DataType.Link non implementata");
				throw ex;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}
}
