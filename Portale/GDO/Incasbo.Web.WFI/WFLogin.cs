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

public class WFLogin : WFIPage
{
	public enum LoginMode
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

	protected FunctionArguments _objFunctionArguments;

	protected LoginMode _LoginMode;

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

	public WFLogin()
	{
		((Control)this).Load += Page_Load;
		_objFunctionArguments = null;
		_LoginMode = LoginMode.Login;
	}

	protected virtual bool ValidatePassword(string pwd)
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

	protected virtual void SetMode()
	{
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		if ((_LoginMode == LoginMode.ChangePassword) | (_LoginMode == LoginMode.RequestChangePassword))
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
		else if (_LoginMode == LoginMode.PasswordExpired)
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
		else if ((_LoginMode == LoginMode.Login) | (_LoginMode == LoginMode.LoginForAssistance))
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
		if (_LoginMode == LoginMode.LoginForAssistance)
		{
			lblIdentityUser.Visible = true;
			txtIdentityUser.Visible = true;
			((Control)tr_IdentityUser).Visible = true;
			lblRicorda.Visible = false;
			RememberMe.Visible = false;
			((Control)tr_RememberMe).Visible = false;
		}
		if ((_LoginMode == LoginMode.PasswordExpired) | (_LoginMode == LoginMode.ChangePassword) | (_LoginMode == LoginMode.RequestChangePassword))
		{
			((WebControl)imageInfo).ToolTip = WriteTooltipForPasswordRules();
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

	protected virtual string WriteTooltipForPasswordRules()
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

	protected virtual void Page_Load(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = LoadPage(ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				ErroreCaricamento(bWithReturnToCaller: true, rsMess);
			}
			CallStackRemove();
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
			if ((_LoginMode != LoginMode.ChangePassword) & (_LoginMode != LoginMode.PasswordExpired))
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
						if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable)
						{
							IboCrypt val3 = new IboCrypt();
							text = val3.EncryptString128Bit(text);
						}
					}
					else
					{
						text = "__DO_NOT_VERIFY__";
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
				if (Operators.CompareString(txtNuovaPassword1.Text, base.SessionEnvironment.WebUser.WebUserInfo.Password, false) == 0)
				{
					rsMess = TranslateMessage("XXX", "La nuova password non può essere uguare alla vecchia");
					txtNuovaPassword1.Text = "";
					txtNuovaPassword2.Text = "";
					return;
				}
				if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.PasswordValidationAlgorithm == 1 && !ValidatePassword(txtNuovaPassword1.Text))
				{
					rsMess = TranslateMessage("XXX", "La nuova password non rispetta i requisiti minimi di sicurezza<br />" + WriteTooltipForPasswordRules());
					return;
				}
				string text2 = "";
				if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable)
				{
					IboCrypt val4 = new IboCrypt();
					text2 = val4.EncryptString128Bit(txtNuovaPassword1.Text);
				}
				else
				{
					text2 = txtNuovaPassword1.Text;
				}
				val = base.SessionEnvironment.WebUser.ModificaPassword(txtUser.Text, text2, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				val = base.SessionEnvironment.WebUser.Check(base.SessionEnvironment.WebUser.WebUserInfo.Password, ref rsMess);
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
				_LoginMode = LoginMode.PasswordExpired;
				SetMode();
				flag = false;
			}
			if ((int)val2 == 0)
			{
				if (((_LoginMode == LoginMode.Login) | (_LoginMode == LoginMode.LoginForAssistance) | (_LoginMode == LoginMode.ChangePassword) | (_LoginMode == LoginMode.PasswordExpired) | (_LoginMode == LoginMode.LoginAnnulla)) && flag)
				{
					bool flag2 = Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "S", false) == 0;
					if ((Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "U", false) == 0) & (Operators.CompareString(RememberMe.ObjValue.ToString(), "S", false) == 0))
					{
						flag2 = true;
					}
					if (_LoginMode == LoginMode.Login && ddlSistema.Visible)
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
			_LoginMode = LoginMode.LoginAnnulla;
			btnConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			ReturnToCaller();
		}
	}

	private void btnCambioPsw_Click(object sender, EventArgs e)
	{
		_LoginMode = LoginMode.RequestChangePassword;
		btnConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
		if (!Information.IsNothing((object)base.SessionEnvironment.WebUser))
		{
			if ((base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.Authenticated) | (base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.PasswordExpired))
			{
				((Page)this).Session["Login.Modalita"] = "ModPwd";
				_LoginMode = LoginMode.ChangePassword;
				SetMode();
			}
			else if (base.SessionEnvironment.WebUser.WebUserInfo.Authenticated != IboWebUserInfo.AuthenticationState.PasswordNotCorrected)
			{
			}
		}
	}

	protected virtual FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = InitializedPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (((Control)this).Page.IsPostBack)
				{
					goto IL_00a7;
				}
				val = BeforeLoadData(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					PerformanceLogAppend("DBPage LoadData");
					val = LoadData(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						PerformanceLogAppend("DBPage AfterLoadData");
						val = AfterLoadData(ref rsMess);
						if ((int)val <= 0)
						{
							goto IL_00a7;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0005;
			IL_00a7:
			val = AfterLoadPage(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			end_IL_0005:;
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
			PerformanceLogAppend("DBPage End LoadPage");
			if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) == 0 && (int)val2 == 0)
			{
				ReturnToCaller();
			}
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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
				_LoginMode = LoginMode.Login;
			}
			else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "Assistenza".ToUpper(), false) == 0)
			{
				_LoginMode = LoginMode.LoginForAssistance;
			}
			else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "ModPwd".ToUpper(), false) == 0)
			{
				_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				_LoginMode = LoginMode.ChangePassword;
			}
			else if (Operators.CompareString(((Page)this).Session["Login.Modalita"].ToString().ToUpper(), "ExpPwd".ToUpper(), false) == 0)
			{
				_objFunctionArguments = (FunctionArguments)((Page)this).Session["FunctionArgs"];
				_LoginMode = LoginMode.PasswordExpired;
			}
			SetMode();
			if (!((Control)this).Page.IsPostBack)
			{
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
					btnConferma_Click(btnConferma, new EventArgs());
				}
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN BeforeLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN AfterLoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
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
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN LoginConferma(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Invalid comparison between Unknown and I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Invalid comparison between Unknown and I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Invalid comparison between Unknown and I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess2 = "";
		bool flag = true;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			try
			{
				txtUser.Text = txtUser.Text.Trim();
				string text;
				if ((_LoginMode != LoginMode.ChangePassword) & (_LoginMode != LoginMode.PasswordExpired))
				{
					if (base.SessionEnvironment.Initialized)
					{
						goto IL_045f;
					}
					text = txtPassword.Text;
					if (Operators.CompareString(txtPassword.CustomTag, "*", false) == 0)
					{
						text = "__DO_NOT_VERIFY__";
						txtPassword.CustomTag = "";
						goto IL_0144;
					}
					if (Operators.CompareString(txtUser.Text, "", false) == 0)
					{
						rsMess2 = "Username is required";
					}
					else
					{
						if (Operators.CompareString(txtPassword.Text, "", false) != 0)
						{
							if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable)
							{
								IboCrypt val3 = new IboCrypt();
								text = val3.EncryptString128Bit(text);
							}
							goto IL_0144;
						}
						rsMess2 = "Password is required";
					}
				}
				else
				{
					txtNuovaPassword1.Text = txtNuovaPassword1.Text.Trim();
					txtNuovaPassword2.Text = txtNuovaPassword2.Text.Trim();
					if (Operators.CompareString(txtNuovaPassword1.Text, txtNuovaPassword2.Text, false) != 0)
					{
						rsMess2 = TranslateMessage("XXX", "Le due password devono coincidere");
						txtNuovaPassword1.Text = "";
						txtNuovaPassword2.Text = "";
					}
					else if (Operators.CompareString(txtNuovaPassword1.Text.Trim(), "", false) == 0)
					{
						rsMess2 = TranslateMessage("XXX", "La nuova password non può essere vuota");
						txtNuovaPassword1.Text = "";
						txtNuovaPassword2.Text = "";
					}
					else if (Operators.CompareString(txtNuovaPassword1.Text, base.SessionEnvironment.WebUser.WebUserInfo.Password, false) == 0)
					{
						rsMess2 = TranslateMessage("XXX", "La nuova password non può essere uguare alla vecchia");
						txtNuovaPassword1.Text = "";
						txtNuovaPassword2.Text = "";
					}
					else if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.PasswordValidationAlgorithm == 1 && !ValidatePassword(txtNuovaPassword1.Text))
					{
						rsMess2 = TranslateMessage("XXX", "La nuova password non rispetta i requisiti minimi di sicurezza<br />" + WriteTooltipForPasswordRules());
					}
					else
					{
						string text2 = "";
						if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable)
						{
							IboCrypt val4 = new IboCrypt();
							text2 = val4.EncryptString128Bit(txtNuovaPassword1.Text);
						}
						else
						{
							text2 = txtNuovaPassword1.Text;
						}
						val = base.SessionEnvironment.WebUser.ModificaPassword(txtUser.Text, text2, ref rsMess2);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = base.SessionEnvironment.WebUser.Check(base.SessionEnvironment.WebUser.WebUserInfo.Password, ref rsMess2);
							if ((int)val <= 0)
							{
								goto IL_045f;
							}
							val2 = val;
						}
					}
				}
				goto end_IL_001d;
				IL_0144:
				string dBConfigSection = "";
				if (ddlSistema.Visible)
				{
					dBConfigSection = ((ListControl)ddlSistema).SelectedItem.Value;
				}
				val = base.SessionEnvironment.Init(txtUser.Text, text, txtIdentityUser.ObjValue.ToString(), base.SessionEnvironment.Session["ConfigFile"].ToString(), base.SessionEnvironment.Session["DBConfigFile"].ToString(), dBConfigSection, ref rsMess2);
				if ((int)val <= 0)
				{
					goto IL_045f;
				}
				val2 = val;
				goto end_IL_001d;
				IL_045f:
				val2 = (FXRETURN)0;
				goto IL_0691;
				end_IL_001d:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception objEx = ex;
				val2 = HandleError(ref objEx, ref rsMess2);
				ProjectData.ClearProjectError();
				goto IL_0691;
			}
			finally
			{
				CallStackRemove();
				if (base.SessionEnvironment.WebUser != null && base.SessionEnvironment.WebUser.WebUserInfo.Authenticated == IboWebUserInfo.AuthenticationState.PasswordExpired)
				{
					((Page)this).Session["Login.Modalita"] = "ExpPwd";
					_LoginMode = LoginMode.PasswordExpired;
					SetMode();
					flag = false;
				}
				if ((int)val2 == 0)
				{
					if (((_LoginMode == LoginMode.Login) | (_LoginMode == LoginMode.LoginForAssistance) | (_LoginMode == LoginMode.ChangePassword) | (_LoginMode == LoginMode.PasswordExpired) | (_LoginMode == LoginMode.LoginAnnulla)) && flag)
					{
						bool flag2 = Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "S", false) == 0;
						if ((Operators.CompareString(base.SessionEnvironment.WFIConfig.LoginManagerConfig.RememberMe, "U", false) == 0) & (Operators.CompareString(RememberMe.ObjValue.ToString(), "S", false) == 0))
						{
							flag2 = true;
						}
						if (_LoginMode == LoginMode.Login && ddlSistema.Visible)
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
					WriteErrorMessage(rsMess2);
				}
			}
			goto end_IL_000e;
			IL_0691:
			val2 = (FXRETURN)0;
			end_IL_000e:;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception objEx2 = ex2;
			val2 = HandleError(ref objEx2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}
}
