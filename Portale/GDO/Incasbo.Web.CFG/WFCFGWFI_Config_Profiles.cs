using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.CFG;

public class WFCFGWFI_Config_Profiles : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCreaDesktop")]
	private IboWebButton _btnCreaDesktop;

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

	[field: AccessedThroughProperty("lblId")]
	protected virtual IboWebLabel lblId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebTextBox txtId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdDaDuplicare")]
	protected virtual IboWebHidden IdDaDuplicare
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

	[field: AccessedThroughProperty("lblMenu")]
	protected virtual IboWebLabel lblMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkMenu")]
	protected virtual IboWebCheckBox chkMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDesktop")]
	protected virtual IboWebLabel lblDesktop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkDesktop")]
	protected virtual IboWebCheckBox chkDesktop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGrid")]
	protected virtual IboWebLabel lblGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkGrid")]
	protected virtual IboWebCheckBox chkGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DuplicaMenuCaption")]
	protected virtual IboWebLabel DuplicaMenuCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DuplicaMenu")]
	protected virtual IboWebCheckBox DuplicaMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DuplicaDesktopCaption")]
	protected virtual IboWebLabel DuplicaDesktopCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DuplicaDesktop")]
	protected virtual IboWebCheckBox DuplicaDesktop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen")]
	protected virtual CollapsiblePanelExtender cpInfoGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnCreaDesktop
	{
		[CompilerGenerated]
		get
		{
			return _btnCreaDesktop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCreaDesktop_Click;
			IboWebButton val = _btnCreaDesktop;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCreaDesktop = value;
			val = _btnCreaDesktop;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "WFI.PROF.PROFILO_CONFIG";
		_Title = base.Translator.Translate("XXX", "Profilo di Configurazione", new string[0]);
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)
				{
					IdDaDuplicare.ObjValue = txtId.ObjValue.ToString();
					DuplicaMenuCaption.Visible = true;
					DuplicaMenu.Visible = true;
					DuplicaDesktopCaption.Visible = true;
					DuplicaDesktop.Visible = true;
				}
				else if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
					btnCreaDesktop.Visible = true;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) != 0)
				{
					goto IL_00f8;
				}
				if (!((CheckBox)DuplicaMenu).Checked)
				{
					goto IL_00a7;
				}
				val2 = DuplicaConfigurazione(IdDaDuplicare.ObjValue.ToString(), txtId.ObjValue.ToString(), "M", ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00a7;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_00a7:
			if (!((CheckBox)DuplicaDesktop).Checked)
			{
				goto IL_00f8;
			}
			val2 = DuplicaConfigurazione(IdDaDuplicare.ObjValue.ToString(), txtId.ObjValue.ToString(), "D", ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_00f8;
			}
			val = val2;
			goto end_IL_000b;
			IL_00f8:
			val = (FXRETURN)0;
			end_IL_000b:;
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeSaveData(ref rsMess);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeLoadData(ref rsMess);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadPage(ref rsMess);
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	private void btnCreaDesktop_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			object obj = null;
			string text = "SELECT COUNT(*) FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Conversions.ToInteger(obj) > 0)
			{
				object objParams = null;
				val2 = CreaConfigurazioneDesktop(ref objParams, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
			else
			{
				val2 = DuplicaConfigurazione(txtId.ObjValue.ToString(), txtId.ObjValue.ToString(), "E", ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
			val = (FXRETURN)0;
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
				WriteErrorMessage(rsMess);
			}
		}
	}

	private FXRETURN DuplicaConfigurazione(string ProfileIdToClone, string ProfileIdNew, string Tipo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Invalid comparison between Unknown and I4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Invalid comparison between Unknown and I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Invalid comparison between Unknown and I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Invalid comparison between Unknown and I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Invalid comparison between Unknown and I4
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Invalid comparison between Unknown and I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Invalid comparison between Unknown and I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Invalid comparison between Unknown and I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Invalid comparison between Unknown and I4
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		object obj = null;
		DataTable dataTable = null;
		DataTable dataTable2 = null;
		DataTable dataTable3 = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		decimal? num4 = null;
		decimal? num5 = null;
		string text4 = "";
		string text5 = "";
		string text6 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text7 = "";
			string text8 = "";
			switch (Tipo)
			{
			case "M":
				text7 = "WFI_Menu_TREE";
				text8 = "WFI_Menu_TREE";
				break;
			case "D":
				text7 = "WFI_Desktop_TREE";
				text8 = "WFI_Desktop_TREE";
				break;
			case "E":
				text7 = "WFI_Menu_TREE";
				text8 = "WFI_Desktop_TREE";
				break;
			default:
				rsMess = TranslateMessage("XXX", "Tipologia non riconosciuta");
				goto end_IL_0053;
			}
			text3 = "SELECT COUNT(*) FROM " + text8 + " WHERE ConfigProfileId = " + base.DbConn.SQLFormatString(ProfileIdNew);
			val2 = base.DbConn.DoSql(text3, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				base.DbConn.BeginTransaction();
				if (Conversions.ToInteger(obj) != 0)
				{
					if (Operators.CompareString(Tipo, "C", false) != 0)
					{
					}
					goto IL_079f;
				}
				text3 = "SELECT * FROM " + text7 + " WHERE PARENTID IS NULL ";
				text3 = text3 + "AND ConfigProfileId = " + base.DbConn.SQLFormatString(ProfileIdToClone) + " ";
				text3 += "ORDER BY ORDINE";
				val2 = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (dataTable.Rows.Count > 0)
					{
						int num6 = checked(dataTable.Rows.Count - 1);
						for (num = 0; num <= num6; num = checked(num + 1))
						{
							text4 = dataTable.Rows[num]["ID"].ToString();
							text2 = "INSERT INTO " + text8 + " (ConfigProfileId, Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, UteIns, UteAgg) ";
							text2 = text2 + "SELECT " + base.DbConn.SQLFormatString(ProfileIdNew) + " , Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, ";
							text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
							text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
							text2 = text2 + "FROM " + text7 + " ";
							text2 = text2 + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref text4);
							val2 = base.DbConn.SqlExec(text2, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								text3 = "SELECT * FROM " + text7 + " WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref text4) + " ";
								text3 = text3 + "AND ConfigProfileId = " + base.DbConn.SQLFormatString(ProfileIdToClone) + " ";
								text3 += "ORDER BY ORDINE";
								val2 = base.DbConn.OpenDataTable(text3, ref dataTable2, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									if (dataTable2.Rows.Count <= 0)
									{
										continue;
									}
									val2 = base.DbConn.GetLastIdentity(ref num4, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										if (!Information.IsNothing((object)num4))
										{
											int num7 = checked(dataTable2.Rows.Count - 1);
											for (num2 = 0; num2 <= num7; num2 = checked(num2 + 1))
											{
												text5 = dataTable2.Rows[num2]["ID"].ToString();
												text2 = "INSERT INTO " + text8 + " ";
												text2 += "(ConfigProfileId, Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, ParentID, UteIns, UteAgg) ";
												text2 = text2 + "SELECT " + base.DbConn.SQLFormatString(ProfileIdNew) + ", Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, ";
												text2 = text2 + base.DbConn.SQLFormatNumber(ref num4) + ",";
												text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
												text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
												text2 = text2 + "FROM " + text7 + " ";
												text2 = text2 + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref text5);
												val2 = base.DbConn.SqlExec(text2, ref rsMess);
												if ((int)val2 > 0)
												{
													val = val2;
												}
												else
												{
													text3 = "SELECT * FROM " + text7 + " WHERE PARENTID = " + base.DbConn.SQLFormatNumber(ref text5) + " ";
													text3 = text3 + "AND ConfigProfileId = " + base.DbConn.SQLFormatString(ProfileIdToClone) + " ";
													text3 += "ORDER BY ORDINE";
													val2 = base.DbConn.OpenDataTable(text3, ref dataTable3, ref rsMess);
													if ((int)val2 > 0)
													{
														val = val2;
													}
													else
													{
														if (dataTable3.Rows.Count <= 0)
														{
															continue;
														}
														val2 = base.DbConn.GetLastIdentity(ref num5, ref rsMess);
														if ((int)val2 > 0)
														{
															val = val2;
														}
														else
														{
															if (!Information.IsNothing((object)((Page)this).ID))
															{
																int num8 = checked(dataTable3.Rows.Count - 1);
																num3 = 0;
																while (num3 <= num8)
																{
																	text6 = dataTable3.Rows[num3]["ID"].ToString();
																	text2 = "INSERT INTO " + text8 + " ";
																	text2 += "(ConfigProfileId, Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, ParentID,  UteIns, UteAgg) ";
																	text2 = text2 + "SELECT " + base.DbConn.SQLFormatString(ProfileIdNew) + ", Voce, Descrizione, Ordine, Separa, Visibile, Text, ToolTip, AdditionalText, Peso, ";
																	text2 = text2 + base.DbConn.SQLFormatNumber(ref num5) + ",";
																	text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ",";
																	text2 = text2 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + " ";
																	text2 = text2 + "FROM " + text7 + " ";
																	text2 = text2 + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref text6);
																	val2 = base.DbConn.SqlExec(text2, ref rsMess);
																	if ((int)val2 <= 0)
																	{
																		num3 = checked(num3 + 1);
																		continue;
																	}
																	val = val2;
																	goto end_IL_0053;
																}
																continue;
															}
															rsMess = TranslateMessage("XXX", "ERRORE IRREVERSIBILE!!");
														}
													}
												}
												goto end_IL_0053;
											}
											continue;
										}
										rsMess = TranslateMessage("XXX", "ERRORE IRREVERSIBILE!!");
									}
								}
							}
							goto end_IL_0053;
						}
					}
					goto IL_079f;
				}
				val = val2;
			}
			goto end_IL_0053;
			IL_079f:
			base.DbConn.CommitTransaction();
			val = (FXRETURN)0;
			end_IL_0053:;
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
			base.DbConn.RollbackTransaction();
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN CreaConfigurazioneDesktop(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Invalid comparison between Unknown and I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Creazione Configurazione Desktop");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Configurazione del Desktop già presente. Sovrascriverla con quella del Menù?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "CreaConfigurazioneDesktop";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_01e9;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_01e9;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_01e9;
			}
			base.SessionEnvironment.UserMessage.Reset();
			val2 = SavingProcess(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string text = "";
				text = "DELETE FROM WFI_DESKTOP_TREE WHERE CONFIGPROFILEID = " + base.DbConn.SQLFormatString(txtId.ObjValue.ToString());
				val2 = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = DuplicaConfigurazione(txtId.ObjValue.ToString(), txtId.ObjValue.ToString(), "E", ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_01e9;
					}
					val = val2;
				}
			}
			goto end_IL_0005;
			IL_01e9:
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
			result = val;
		}
		return result;
	}
}
