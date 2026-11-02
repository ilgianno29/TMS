using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFLogin2 : WFIPage
{
	public enum LoginModalita
	{
		Login,
		ChangePassword,
		PasswordExpired,
		RequestChangePassword,
		LoginAnnulla,
		LoginForAssistance
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAnnulla")]
	private IboWebButton _btnAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCambioPsw")]
	private IboWebButton _btnCambioPsw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConferma")]
	private IboWebButton _btnConferma;

	private FunctionArguments _objFunctionArguments;

	private LoginModalita Modalita;

	[field: AccessedThroughProperty("Master_DummyButton")]
	protected virtual Button Master_DummyButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloApplicazione")]
	protected virtual Label lblTitoloApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloModuloSoftware")]
	protected virtual Label lblTitoloModuloSoftware
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgLogoApplicazione")]
	protected virtual Image imgLogoApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlLogin")]
	protected virtual Panel pnlLogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMessaggioErroreLogin")]
	protected virtual Panel pnlMessaggioErroreLogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMessaggioErroreLogin")]
	protected virtual Label lblMessaggioErroreLogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlTitolo")]
	protected virtual Panel pnlTitolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloLogin")]
	protected virtual Label lblTitoloLogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloDBDescription")]
	protected virtual Label lblTitoloDBDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMsg")]
	protected virtual IboWebLabel lblMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSistema")]
	protected virtual IboWebLabel lblSistema
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlSistema")]
	protected virtual IboDropDownList ddlSistema
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUser")]
	protected virtual IboWebLabel lblUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUser")]
	protected virtual IboWebTextBox txtUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPassword")]
	protected virtual IboWebLabel lblPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassword")]
	protected virtual IboWebTextBox txtPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tr_IdentityUser")]
	protected virtual HtmlTableRow tr_IdentityUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdentityUser")]
	protected virtual IboWebLabel lblIdentityUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdentityUser")]
	protected virtual IboWebTextBox txtIdentityUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tr_RememberMe")]
	protected virtual HtmlTableRow tr_RememberMe
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicorda")]
	protected virtual IboWebLabel lblRicorda
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RememberMe")]
	protected virtual IboWebCheckBox RememberMe
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel2")]
	protected virtual IboWebLabel IboWebLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInserisciPassword")]
	protected virtual IboWebLabel lblInserisciPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNuovaPassword1")]
	protected virtual IboWebTextBox txtNuovaPassword1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imageInfo")]
	protected virtual Image imageInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordStrength")]
	protected virtual PasswordStrength PasswordStrength
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblConfermaPassword")]
	protected virtual IboWebLabel lblConfermaPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNuovaPassword2")]
	protected virtual IboWebTextBox txtNuovaPassword2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	protected virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAnnulla_Click;
			IboWebButton val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAnnulla = value;
			val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnCambioPsw
	{
		[CompilerGenerated]
		get
		{
			return _btnCambioPsw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCambioPsw_Click;
			IboWebButton val = _btnCambioPsw;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCambioPsw = value;
			val = _btnCambioPsw;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnConferma_Click;
			IboWebButton val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnConferma = value;
			val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblVersione")]
	protected virtual Label lblVersione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFLogin2()
	{
		((Control)this).Load += Page_Load;
		_objFunctionArguments = null;
		Modalita = LoginModalita.Login;
	}

	protected bool ValidatePassword(string pwd)
	{
		int minumumPasswordLength = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinumumPasswordLength;
		int minimumUpperCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters;
		int minimumLowerCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters;
		int minimumNumericCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters;
		int minimumSymbolCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumSymbolCharacters;
		Regex regex = new Regex("[A-Z]");
		Regex regex2 = new Regex("[a-z]");
		Regex regex3 = new Regex("[0-9]");
		Regex regex4 = new Regex("[^a-zA-Z0-9]");
		if (Strings.Len(pwd) < minumumPasswordLength)
		{
			return false;
		}
		if (regex.Matches(pwd).Count < minimumUpperCaseCharacters)
		{
			return false;
		}
		if (regex2.Matches(pwd).Count < minimumLowerCaseCharacters)
		{
			return false;
		}
		if (regex3.Matches(pwd).Count < minimumNumericCharacters)
		{
			return false;
		}
		if (regex4.Matches(pwd).Count < minimumSymbolCharacters)
		{
			return false;
		}
		return true;
	}

	protected void ImpostaModalita()
	{
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		if ((Modalita == LoginModalita.ChangePassword) | (Modalita == LoginModalita.RequestChangePassword))
		{
			lblSistema.Visible = false;
			ddlSistema.Visible = false;
			txtNuovaPassword1.Visible = true;
			((Control)imageInfo).Visible = true;
			lblInserisciPassword.Visible = true;
			txtNuovaPassword2.Visible = true;
			lblConfermaPassword.Visible = true;
			lblUser.Visible = true;
			lblPassword.Visible = true;
			txtUser.Visible = true;
			txtUser.Enabled = false;
			lblPassword.Enabled = false;
			lblPassword.Visible = false;
			txtPassword.Visible = false;
			lblIdentityUser.Visible = false;
			txtIdentityUser.Visible = false;
			((Control)tr_IdentityUser).Visible = false;
			lblRicorda.Visible = false;
			RememberMe.Visible = false;
			((Control)tr_RememberMe).Visible = false;
			SetIncasFocusToControl((Control)(object)txtNuovaPassword1);
			lblTitoloLogin.Text = "Modifica Password";
			((Control)lblTitoloLogin).Visible = true;
			((Control)lblTitoloDBDescription).Visible = false;
			btnAnnulla.Visible = true;
			btnCambioPsw.Visible = false;
			((Control)pnlMessaggioErroreLogin).Visible = false;
			lblMessaggioErroreLogin.Text = "";
			if (base.SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Enable)
			{
				ToolTipManagerEnable();
			}
		}
		else if (Modalita == LoginModalita.PasswordExpired)
		{
			lblSistema.Visible = false;
			ddlSistema.Visible = false;
			txtNuovaPassword1.Visible = true;
			((Control)imageInfo).Visible = true;
			lblInserisciPassword.Visible = true;
			txtNuovaPassword2.Visible = true;
			lblConfermaPassword.Visible = true;
			lblUser.Visible = true;
			lblPassword.Visible = true;
			txtUser.Visible = true;
			txtUser.Enabled = false;
			lblPassword.Enabled = false;
			lblPassword.Visible = false;
			txtPassword.Visible = false;
			lblIdentityUser.Visible = false;
			txtIdentityUser.Visible = false;
			((Control)tr_IdentityUser).Visible = false;
			lblRicorda.Visible = false;
			RememberMe.Visible = false;
			((Control)tr_RememberMe).Visible = false;
			SetIncasFocusToControl((Control)(object)txtNuovaPassword1);
			lblTitoloLogin.Text = "Modifica Password";
			((Control)lblTitoloLogin).Visible = true;
			((Control)lblTitoloDBDescription).Visible = false;
			btnAnnulla.Visible = false;
			btnCambioPsw.Visible = false;
			((Control)pnlMessaggioErroreLogin).Visible = true;
			lblMessaggioErroreLogin.Text = "Password scaduta";
			if (base.SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Enable)
			{
				ToolTipManagerEnable();
			}
		}
		else if ((Modalita == LoginModalita.Login) | (Modalita == LoginModalita.LoginForAssistance))
		{
			txtNuovaPassword1.Visible = false;
			((Control)imageInfo).Visible = false;
			lblInserisciPassword.Visible = false;
			txtNuovaPassword2.Visible = false;
			lblConfermaPassword.Visible = false;
			lblUser.Visible = true;
			lblPassword.Enabled = true;
			lblPassword.Visible = true;
			txtUser.Visible = true;
			txtUser.Enabled = true;
			txtPassword.Visible = true;
			lblIdentityUser.Visible = false;
			txtIdentityUser.Visible = false;
			((Control)tr_IdentityUser).Visible = false;
			if (Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "U", false) == 0)
			{
				lblRicorda.Visible = true;
				RememberMe.Visible = true;
				((Control)tr_RememberMe).Visible = true;
			}
			else
			{
				lblRicorda.Visible = false;
				RememberMe.Visible = false;
				((Control)tr_RememberMe).Visible = false;
			}
			SetIncasFocusToControl((Control)(object)txtUser);
			lblTitoloLogin.Text = "Login";
			((Control)lblTitoloLogin).Visible = true;
			((Control)lblTitoloDBDescription).Visible = true;
			if (Operators.CompareString(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Description, "", false) != 0)
			{
				lblTitoloDBDescription.Text = "(" + base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Description + ")";
				((WebControl)lblTitoloDBDescription).ToolTip = lblTitoloDBDescription.Text;
			}
			btnAnnulla.Visible = false;
			btnCambioPsw.Visible = true;
			((Control)pnlMessaggioErroreLogin).Visible = false;
			lblMessaggioErroreLogin.Text = "";
			if (base.SessionEnvironment.WFIConfig.AutoTooltipifyConfig.Enable)
			{
				ToolTipManagerDisable();
			}
			if (!((Page)this).IsPostBack && Operators.CompareString(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig.DB_Key, "", false) == 0)
			{
				lblSistema.Visible = true;
				ddlSistema.Visible = true;
				if (((ListControl)ddlSistema).Items.Count == 0)
				{
					foreach (KeyValuePair<string, WFIDbConnectionConfig> item in base.SessionEnvironment.WFIConfig.DBConnectionListConfig)
					{
						((ListControl)ddlSistema).Items.Add(new ListItem(item.Value.DB_Description, item.Key));
					}
				}
			}
		}
		if (Modalita == LoginModalita.LoginForAssistance)
		{
			lblIdentityUser.Visible = true;
			txtIdentityUser.Visible = true;
			((Control)tr_IdentityUser).Visible = true;
			lblRicorda.Visible = false;
			RememberMe.Visible = false;
			((Control)tr_RememberMe).Visible = false;
		}
		if ((Modalita == LoginModalita.PasswordExpired) | (Modalita == LoginModalita.ChangePassword) | (Modalita == LoginModalita.RequestChangePassword))
		{
			((WebControl)imageInfo).ToolTip = ComponiTooltipPerRegolePassword();
			PasswordStrength.MinimumLowerCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters;
			PasswordStrength.MinimumUpperCaseCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters;
			PasswordStrength.MinimumSymbolCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumSymbolCharacters;
			PasswordStrength.MinimumNumericCharacters = base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters;
			PasswordStrength.PreferredPasswordLength = base.SessionEnvironment.WFIConfig.LoginManagerConfig.PreferredPasswordLength;
		}
	}

	protected override void ReturnToCaller()
	{
		string text = "";
		text = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
		text = base.BaseFunctions.FindFormDirMember(text);
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref text);
	}

	protected string ComponiTooltipPerRegolePassword()
	{
		string text = TranslateMessage("XXX", "La {0}password{1} deve avere le seguenti caratteristiche{2}{2}", "<b>", "</b>", "<br />");
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} numero{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumNumericCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere maiuscolo{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumUpperCaseCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere minuscoli{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters.ToString(), "<br />");
		}
		if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumLowerCaseCharacters > 0)
		{
			text += TranslateMessage("XXX", "Deve contenere almeno {0} carattere speciali{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinimumSymbolCharacters.ToString(), "<br />");
		}
		return text + TranslateMessage("XXX", "Deve avere una lunghezza compresa tra {0} e 15 caratteri{1}", base.SessionEnvironment.WFIConfig.LoginManagerConfig.MinumumPasswordLength.ToString(), "<br />");
	}

	private void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			if (base.SessionEnvironment.Initialized && base.SessionEnvironment.WebUser.WebUserInfo.Codice.Length > 0)
			{
				txtUser.Text = base.SessionEnvironment.WebUser.WebUserInfo.Codice;
				txtUser.ReadOnly = true;
			}
			if (((Page)this).Session["Login.Modalita"] == null)
			{
				((Page)this).Session["Login.Modalita"] = "Login";
				if (((Page)this).Request.QueryString["Mod"] != null && Operators.CompareString(((Page)this).Request.QueryString["Mod"].ToString().ToUpper(), "ASSISTENZA", false) == 0)
				{
					((Page)this).Session["Login.Modalita"] = "Assistenza";
				}
			}
			base.MasterPage.LogoIncasVisible(bVisible: true);
			imgLogoApplicazione.ImageUrl = base.SessionEnvironment.WFIConfig.ApplicationConfig.LogoApplicazione;
			lblTitoloApplicazione.Text = base.SessionEnvironment.WebApplicationTitle;
			lblTitoloModuloSoftware.Text = base.SessionEnvironment.WebSoftwareModuleTitle;
			string text = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString();
			lblVersione.Text = "Ver: " + base.SessionEnvironment.WebApplicationVersion.ToString() + " del " + text;
			if (((Page)this).Session["Login.msg"] != null && Operators.CompareString(((Page)this).Session["Login.msg"].ToString().ToUpper(), "Timeout".ToUpper(), false) == 0)
			{
				if (Operators.CompareString(Conversions.ToString(((Page)this).Application["SESSIONID." + base.SessionEnvironment.WebSessionId]) ?? "", ".", false) == 0)
				{
					lblMsg.ObjValue = "";
					((Page)this).Application.Remove("SESSIONID." + base.SessionEnvironment.WebSessionId);
				}
				else
				{
					lblMsg.ObjValue = "Sessione scaduta";
					((Page)this).Session.Remove("Login.msg");
				}
			}
		}
		if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString(), "Login", false) == 0)
		{
			Modalita = LoginModalita.Login;
		}
		else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "Assistenza".ToUpper(), false) == 0)
		{
			Modalita = LoginModalita.LoginForAssistance;
		}
		else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "ModPwd".ToUpper(), false) == 0)
		{
			_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
			Modalita = LoginModalita.ChangePassword;
		}
		else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "ExpPwd".ToUpper(), false) == 0)
		{
			_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
			Modalita = LoginModalita.PasswordExpired;
		}
		ImpostaModalita();
		if (((Control)this).Page.IsPostBack)
		{
			return;
		}
		if (((Page)this).Request.Cookies.AllKeys.Contains("WFI.System"))
		{
			try
			{
				ddlSistema.SelectedValue = ((Page)this).Request.Cookies["WFI.System"].Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(HttpContext.Current.User.Identity.Name, "", false) != 0)
		{
			txtUser.Text = HttpContext.Current.User.Identity.Name;
			txtPassword.CustomTag = "*";
			btnConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	protected void btnConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Invalid comparison between Unknown and I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Invalid comparison between Unknown and I4
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Invalid comparison between Unknown and I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		bool flag = true;
		try
		{
			CallStackAdd();
			txtUser.Text = txtUser.Text.Trim();
			if ((Modalita != LoginModalita.ChangePassword) & (Modalita != LoginModalita.PasswordExpired))
			{
				if (!base.SessionEnvironment.Initialized)
				{
					string text = txtPassword.Text;
					if (Operators.CompareString(txtPassword.CustomTag, "*", false) != 0)
					{
						if (Operators.CompareString(txtUser.Text, "", false) == 0)
						{
							rsMess = "Username is required";
							return;
						}
						if (Operators.CompareString(txtPassword.Text, "", false) == 0)
						{
							rsMess = "Password is required";
							return;
						}
						// La password resta in chiaro fino alla verifica (hash PBKDF2 o vecchio formato): vedi UserPasswords
					}
					else
					{
						text = TrustedLogin.Token;
						txtPassword.CustomTag = "";
					}
					string dBConfigSection = "";
					if (ddlSistema.Visible)
					{
						dBConfigSection = ((ListControl)ddlSistema).SelectedItem.Value;
					}
					val = base.SessionEnvironment.Init(txtUser.Text, text, txtIdentityUser.ObjValue.ToString(), base.SessionEnvironment.Session["ConfigFile"].ToString(), base.SessionEnvironment.Session["DBConfigFile"].ToString(), dBConfigSection, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
						return;
					}
				}
			}
			else
			{
				txtNuovaPassword1.Text = txtNuovaPassword1.Text.Trim();
				txtNuovaPassword2.Text = txtNuovaPassword2.Text.Trim();
				if (Operators.CompareString(txtNuovaPassword1.Text, txtNuovaPassword2.Text, false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Le due password devono coincidere");
					txtNuovaPassword1.Text = "";
					txtNuovaPassword2.Text = "";
					return;
				}
				if (Operators.CompareString(txtNuovaPassword1.Text.Trim(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "La nuova password non può essere vuota");
					txtNuovaPassword1.Text = "";
					txtNuovaPassword2.Text = "";
					return;
				}
				if (Incasbo.Security.UserPasswords.Verify(txtNuovaPassword1.Text, base.SessionEnvironment.WebUser.WebUserInfo.Password, base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable, out _))
				{
					rsMess = TranslateMessage("XXX", "La nuova password non può essere uguare alla vecchia");
					txtNuovaPassword1.Text = "";
					txtNuovaPassword2.Text = "";
					return;
				}
				if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.PasswordValidationAlgorithm == 1 && !ValidatePassword(txtNuovaPassword1.Text))
				{
					rsMess = TranslateMessage("XXX", "La nuova password non rispetta i requisiti minimi di sicurezza<br />" + ComponiTooltipPerRegolePassword());
					return;
				}
				// ModificaPassword salva l\'hash della password (UserPasswords.ForStorage)
				string text2 = txtNuovaPassword1.Text;
				val = base.SessionEnvironment.WebUser.ModificaPassword(txtUser.Text, text2, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				val = base.SessionEnvironment.WebUser.Check(txtNuovaPassword1.Text, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			if (base.SessionEnvironment.WebUser != null && base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.PasswordExpired)
			{
				((Page)this).Session["Login.Modalita"] = "ExpPwd";
				Modalita = LoginModalita.PasswordExpired;
				ImpostaModalita();
				flag = false;
			}
			if ((int)val2 == 0)
			{
				if (((Modalita == LoginModalita.Login) | (Modalita == LoginModalita.LoginForAssistance) | (Modalita == LoginModalita.ChangePassword) | (Modalita == LoginModalita.PasswordExpired) | (Modalita == LoginModalita.LoginAnnulla)) && flag)
				{
					bool flag2 = Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "S", false) == 0;
					if ((Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "U", false) == 0) & (Operators.CompareString(RememberMe.ObjValue.ToString(), "S", false) == 0))
					{
						flag2 = true;
					}
					if (Modalita == LoginModalita.Login && ddlSistema.Visible)
					{
						if (((Page)this).Response.Cookies.AllKeys.Contains("WFI.System"))
						{
							((Page)this).Response.Cookies.Remove("WFI.System");
						}
						HttpCookie val5 = new HttpCookie("WFI.System", ((ListControl)ddlSistema).SelectedItem.Value);
						val5.Expires = DateAndTime.DateAdd((DateInterval)4, 15.0, DateAndTime.Now.Date);
						((Page)this).Response.Cookies.Add(val5);
					}
					FormsAuthentication.RedirectFromLoginPage(base.SessionEnvironment.WebUser.WebUserInfo.Codice, flag2);
				}
			}
			else
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnAnnulla_Click(object sender, EventArgs e)
	{
		if (base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.Authenticated)
		{
			Modalita = LoginModalita.LoginAnnulla;
			btnConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			ReturnToCaller();
		}
	}

	private void btnCambioPsw_Click(object sender, EventArgs e)
	{
		Modalita = LoginModalita.RequestChangePassword;
		btnConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
		if (!Information.IsNothing((object)base.SessionEnvironment.WebUser))
		{
			if ((base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.Authenticated) | (base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.PasswordExpired))
			{
				((Page)this).Session["Login.Modalita"] = "ModPwd";
				Modalita = LoginModalita.ChangePassword;
				ImpostaModalita();
			}
			else if (base.SessionEnvironment.WebUser.WebUserInfo.Authenticated != IboWebUserInfo.AuthenticationState.PasswordNotCorrected)
			{
			}
		}
	}
}
