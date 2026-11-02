using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFFTPAgentFolders : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipo")]
	private IboDropDownList _cmbTipo;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodice")]
	protected virtual IboWebLabel lblCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCodice")]
	protected virtual IboWebTextBox txtCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttivo")]
	protected virtual IboWebLabel lblAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAttivo")]
	protected virtual IboWebCheckBox chkAttivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizione")]
	protected virtual IboWebLabel lblDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescrizione")]
	protected virtual IboWebTextBox txtDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upnlTipo")]
	protected virtual UpdatePanel upnlTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipo")]
	protected virtual IboWebLabel lblTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbTipo
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmbTipo_SelectedIndexChanged;
			IboDropDownList val = _cmbTipo;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbTipo = value;
			val = _cmbTipo;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlLocalPath")]
	protected virtual Panel pnlLocalPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLocalPath")]
	protected virtual IboWebLabel lblLocalPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLocalPath")]
	protected virtual IboWebTextBox txtLocalPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFTPServer")]
	protected virtual Panel pnlFTPServer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPServer")]
	protected virtual IboWebLabel lblFTPServer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPServer")]
	protected virtual IboWebTextBox txtFTPServer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPPorta")]
	protected virtual IboWebLabel lblFTPPorta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPPorta")]
	protected virtual IboWebNumericTlk txtFTPPorta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPUseSSL")]
	protected virtual IboWebLabel lblFTPUseSSL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFTPUseSSL")]
	protected virtual IboWebCheckBox chkFTPUseSSL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPMode")]
	protected virtual IboWebLabel lblFTPMode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbFTPMode")]
	protected virtual IboDropDownList cmbFTPMode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPUser")]
	protected virtual IboWebLabel lblFTPUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPUser")]
	protected virtual IboWebTextBox txtFTPUser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPPassword")]
	protected virtual IboWebLabel lblFTPPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPPassword")]
	protected virtual IboWebTextBox txtFTPPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPBinary")]
	protected virtual IboWebLabel lblFTPBinary
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optFTPBinary")]
	protected virtual IboWebRadioButtonList optFTPBinary
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPPath")]
	protected virtual IboWebLabel lblFTPPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPPath")]
	protected virtual IboWebTextBox txtFTPPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFTPTimeout")]
	protected virtual IboWebLabel lblFTPTimeout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFTPTimeout")]
	protected virtual IboWebNumericTlk txtFTPTimeout
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.FTP.FOLDERS";
		_Title = base.Translator.Translate("XXX", "FTP Folders", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(cmbTipo.ObjValue.ToString(), "R", false) == 0)
				{
					((Control)pnlFTPServer).Visible = false;
					((Control)pnlLocalPath).Visible = true;
				}
				else
				{
					((Control)pnlFTPServer).Visible = true;
					((Control)pnlLocalPath).Visible = false;
				}
				if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
				{
					cmbFTPMode.ObjValue = "P";
					cmbTipo.ObjValue = "F";
					txtFTPPorta.ObjValue = 21;
					txtFTPTimeout.ObjValue = 30000;
				}
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Invalid comparison between Unknown and I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(cmbTipo.ObjValue.ToString(), "F", false) == 0)
			{
				if (Operators.CompareString(txtFTPPath.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Se il tipo è FTP Server il campo Path FTP deve contenere il percorso");
				}
				else if (Operators.CompareString(txtFTPPorta.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(txtFTPPorta.ObjValue) <= 0)
				{
					rsMess = TranslateMessage("XXX", "Se il tipo è FTP Server il campo Porta deve contenere un valore maggiore di zero");
				}
				else if (Operators.CompareString(txtFTPTimeout.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(txtFTPTimeout.ObjValue) <= 0)
				{
					rsMess = TranslateMessage("XXX", "Se il tipo è FTP Server il campo Timeout deve contenere un valore maggiore di zero");
				}
				else
				{
					if (Operators.CompareString(txtFTPServer.ObjValue.ToString(), "", false) != 0)
					{
						txtLocalPath.ObjValue = "";
						goto IL_026b;
					}
					rsMess = TranslateMessage("XXX", "Se il tipo è FTP Server il campo FTP Server deve contenere il nome o l'indirizzo IP del server");
				}
			}
			else
			{
				if (Operators.CompareString(txtLocalPath.ObjValue.ToString(), "", false) != 0)
				{
					if (!txtLocalPath.ObjValue.ToString().EndsWith("\\"))
					{
						txtLocalPath.ObjValue = txtLocalPath.ObjValue.ToString() + "\\";
					}
					if (Operators.CompareString(txtFTPPorta.ObjValue.ToString(), "", false) == 0 || Conversions.ToInteger(txtFTPPorta.ObjValue) < 0)
					{
						txtFTPPorta.ObjValue = 0;
					}
					txtFTPPath.ObjValue = "";
					txtFTPTimeout.ObjValue = 0;
					goto IL_026b;
				}
				rsMess = TranslateMessage("XXX", "Se il tipo è Rete il campo Path locale deve contenere il percorso");
			}
			goto end_IL_0005;
			IL_026b:
			val2 = base.BeforeCheckData(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			end_IL_0005:;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			if (Operators.CompareString(cmbTipo.ObjValue.ToString(), "R", false) == 0)
			{
				((Control)pnlFTPServer).Visible = false;
				((Control)pnlLocalPath).Visible = true;
			}
			else
			{
				((Control)pnlFTPServer).Visible = true;
				((Control)pnlLocalPath).Visible = false;
			}
			((Page)this).SetFocus((Control)(object)cmbTipo);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}
}
