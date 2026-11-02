using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDLGRicalcoloDocumenti : WFIDialogPage
{
	private string _istanza;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
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

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
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

	[field: AccessedThroughProperty("tblCliente")]
	protected virtual HtmlTable tblCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCliente")]
	protected virtual IboWebLabel lblCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCliente")]
	protected virtual IboWebComboTlk cmbCliente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tblTrasportatore")]
	protected virtual HtmlTable tblTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTrasportatore")]
	protected virtual IboWebLabel lblTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTrasportatore")]
	protected virtual IboWebComboTlk cmbTrasportatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDaData")]
	protected virtual IboWebLabel lblDaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtdaData")]
	protected virtual IboWebDate2 txtdaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAData")]
	protected virtual IboWebLabel lblAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAData")]
	protected virtual IboWebDate2 txtAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicalcolaSpedizioni")]
	protected virtual IboWebLabel lblRicalcolaSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkSpedizioni")]
	protected virtual IboWebCheckBox chkSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRicalcolaViaggi")]
	protected virtual IboWebLabel lblRicalcolaViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkViaggi")]
	protected virtual IboWebCheckBox chkViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFDLGRicalcoloDocumenti()
	{
		_istanza = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.FAT.RICALCOLO";
		if (Operators.CompareString(_objFunctionArguments.Name.ToUpper(), "ATTIVO", false) == 0)
		{
			_Title = base.Translator.Translate("XXX", "Ricalcolo attivo", new string[0]);
		}
		else
		{
			if (Operators.CompareString(_objFunctionArguments.Name.ToUpper(), "PASSIVO", false) != 0)
			{
				rsMess = base.Translator.Translate("XXX", "Modalità non prevista", new string[0]);
				return (FXRETURN)16;
			}
			_Title = base.Translator.Translate("XXX", "Ricalcolo passivo", new string[0]);
		}
		_istanza = _SessionVariable["ISTANZA"].ToString() ?? "";
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (DateTime.Compare(txtdaData.DateValue, txtAData.DateValue) > 0)
				{
					rsMess = TranslateMessage("XXX", "Date non congruenti");
					txtdaData.Focus();
				}
				else if (Math.Abs(DateAndTime.DateDiff((DateInterval)4, txtdaData.DateValue, txtAData.DateValue, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > 31)
				{
					rsMess = TranslateMessage("XXX", "L'intervallo selezionato è troppo ampio (MAX 31 giorni)");
					txtdaData.Focus();
				}
				else
				{
					val = (FXRETURN)0;
				}
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				txtAData.DateValue = DateAndTime.Now.Date.AddDays(-1.0);
				txtdaData.DateValue = DateAndTime.Now.Date.AddDays(-8.0);
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
			val2 = base.AfterSaveData(ref rsMess);
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
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

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name.ToUpper(), "ATTIVO", false) == 0)
			{
				((Control)tblCliente).Visible = true;
				((Control)tblTrasportatore).Visible = false;
				cmbCliente.Required = false;
				cmbTrasportatore.Required = false;
			}
			else if (Operators.CompareString(_objFunctionArguments.Name.ToUpper(), "PASSIVO", false) == 0)
			{
				((Control)tblCliente).Visible = false;
				((Control)tblTrasportatore).Visible = true;
				cmbCliente.Required = false;
				cmbTrasportatore.Required = false;
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Invalid comparison between Unknown and I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.SaveData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text = "INSERT INTO DELSYTASKS_Triggers(Istanza, Task, Applicazione, Argomenti) VALUES (";
				text = text + base.DbConn.SQLFormatString(_istanza) + ", ";
				text += "%TASK%, ";
				text += "'DSI', ";
				text += "%ARGOMENTI%)";
				if (Operators.CompareString(_objFunctionArguments.Name.ToUpper(), "ATTIVO", false) == 0)
				{
					text = text.Replace("%TASK%", base.DbConn.SQLFormatString("CALCOLOATTIVO"));
					string text2 = "";
					text2 = text2 + "WHERE_SPED=DATABOLLA>%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtdaData.ObjValue)) + " AND DATABOLLA<%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtAData.ObjValue));
					if (Operators.CompareString(cmbCliente.ObjValue.ToString(), "", false) != 0)
					{
						text2 = text2 + " AND CLIENTE%EQ%" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString());
					}
					text2 += ";";
					text2 = text2 + "WHERE_VIAGGI=DATAPARTENZAEFFETTIVA>%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtdaData.ObjValue)) + " AND DATAPARTENZAEFFETTIVA<" + base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(txtAData.ObjValue).AddDays(1.0)) + " AND CLIENTE%EQ%" + base.DbConn.SQLFormatString(cmbCliente.ObjValue.ToString()) + ";";
					text2 = text2 + "SPEDIZIONI=" + (((CheckBox)chkSpedizioni).Checked ? "S" : "N") + ";";
					text2 = text2 + "VIAGGI=" + (((CheckBox)chkViaggi).Checked ? "S" : "N") + ";";
					text = text.Replace("%ARGOMENTI%", base.DbConn.SQLFormatString(text2));
				}
				else
				{
					text = text.Replace("%TASK%", base.DbConn.SQLFormatString("CALCOLOPASSIVO"));
					string text3 = "";
					text3 = text3 + "WHERE_SPED=DATABOLLA>%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtdaData.ObjValue)) + " AND DATABOLLA<%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtAData.ObjValue));
					if (Operators.CompareString(cmbTrasportatore.ObjValue.ToString(), "", false) != 0)
					{
						text3 = text3 + " AND TRASPORTATORE%EQ%" + base.DbConn.SQLFormatString(cmbTrasportatore.ObjValue.ToString());
					}
					text3 += ";";
					text3 = text3 + "WHERE_VIAGGI=DATAPARTENZAEFFETTIVA>%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtdaData.ObjValue)) + " AND DATAPARTENZAEFFETTIVA<" + base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(txtAData.ObjValue).AddDays(1.0)) + " AND VETTORE%EQ%" + base.DbConn.SQLFormatString(cmbTrasportatore.ObjValue.ToString()) + ";";
					text3 = text3 + "WHERE_SPED_VETT=DATABOLLA>%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtdaData.ObjValue)) + " AND DATABOLLA<%EQ%" + base.DbConn.SQLFormatDate((eTipoData)1, RuntimeHelpers.GetObjectValue(txtAData.ObjValue)) + " AND VETTORE%EQ%" + base.DbConn.SQLFormatString(cmbTrasportatore.ObjValue.ToString()) + ";";
					text3 = text3 + "SPEDIZIONI=" + (((CheckBox)chkSpedizioni).Checked ? "S" : "N") + ";";
					text3 = text3 + "VIAGGI=" + (((CheckBox)chkViaggi).Checked ? "S" : "N") + ";";
					text = text.Replace("%ARGOMENTI%", base.DbConn.SQLFormatString(text3));
				}
				val2 = base.DbConn.SqlExec(text, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					_WarningMessageNotification = "Richiesta di calcolo ai servizi Delsy effettuata";
					val = (FXRETURN)0;
				}
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
}
