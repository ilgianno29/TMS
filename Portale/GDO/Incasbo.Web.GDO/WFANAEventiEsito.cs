using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAEventiEsito : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbBuonFine")]
	private IboDropDownList _cmbBuonFine;

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

	[field: AccessedThroughProperty("up_BuonFine")]
	protected virtual UpdatePanel up_BuonFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblBuonFine")]
	protected virtual IboWebLabel lblBuonFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList cmbBuonFine
	{
		[CompilerGenerated]
		get
		{
			return _cmbBuonFine;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = optBuonFine_SelectedIndexChanged;
			IboDropDownList val = _cmbBuonFine;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_cmbBuonFine = value;
			val = _cmbBuonFine;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("hdnTipoEvento")]
	protected virtual IboWebHidden hdnTipoEvento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTentativoEffettuato")]
	protected virtual IboWebLabel lblTentativoEffettuato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkTentativoEffettuato")]
	protected virtual IboWebCheckBox chkTentativoEffettuato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAnnullamento")]
	protected virtual IboWebLabel lblAnnullamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkAnnullamento")]
	protected virtual IboWebCheckBox chkAnnullamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGeneraRiconsegna")]
	protected virtual IboWebLabel lblGeneraRiconsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGeneraRiconsegna")]
	protected virtual IboDropDownList cmbGeneraRiconsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCreaGiacenza")]
	protected virtual IboWebLabel lblCreaGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCreaGiacenza")]
	protected virtual IboDropDownList cmbCreaGiacenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCreaContestazione")]
	protected virtual IboWebLabel lblCreaContestazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCreaContestazione")]
	protected virtual IboDropDownList cmbCreaContestazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAddebitaRicavi")]
	protected virtual IboWebLabel lblAddebitaRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optAddebitaRicavi")]
	protected virtual IboWebRadioButtonList optAddebitaRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAccreditaCosti")]
	protected virtual IboWebLabel lblAccreditaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optAccreditaCosti")]
	protected virtual IboWebRadioButtonList optAccreditaCosti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVisibile")]
	protected virtual IboWebLabel lblVisibile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optVisibile")]
	protected virtual IboWebRadioButtonList optVisibile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEventoDefault")]
	protected virtual IboWebLabel lblEventoDefault
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EventoDefault")]
	protected virtual IboWebRadioButtonList EventoDefault
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
		_Context = "DM.ANA.EVENTIESITO";
		_Title = base.Translator.Translate("XXX", "Evento di esito", new string[0]);
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
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
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
				EventoDefault.ObjValue = "N";
				object obj = null;
				if (!((Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)))
				{
					goto IL_0113;
				}
				string text2 = "SELECT EventoDefault FROM Eventi_Tipi WHERE Codice=(SELECT TipoEvento FROM Eventi Where Codice=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ")";
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 <= 0)
				{
					EventoDefault.ObjValue = ((Operators.CompareString(obj.ToString().ToUpper(), txtCodice.ObjValue.ToString().ToUpper(), false) == 0) ? "S" : "N");
					goto IL_0113;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0113:
			if (Operators.CompareString(cmbBuonFine.ObjValue.ToString(), "N", false) == 0)
			{
				lblTentativoEffettuato.Visible = true;
				chkTentativoEffettuato.Visible = true;
				lblAnnullamento.Visible = true;
				chkAnnullamento.Visible = true;
			}
			else
			{
				lblTentativoEffettuato.Visible = false;
				chkTentativoEffettuato.Visible = false;
				lblAnnullamento.Visible = false;
				chkAnnullamento.Visible = false;
			}
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if ((Operators.CompareString(cmbBuonFine.ObjValue.ToString(), "S", false) == 0) | (Operators.CompareString(cmbBuonFine.ObjValue.ToString(), "P", false) == 0))
				{
					chkAnnullamento.ObjValue = "N";
					chkTentativoEffettuato.ObjValue = "S";
				}
				if (Operators.CompareString(_objFunctionArguments.Name, "CANCELLAZIONE", false) != 0)
				{
					goto IL_0164;
				}
				object obj = null;
				string text = "SELECT EventoDefault FROM Eventi_Tipi WHERE Codice=(SELECT TipoEvento FROM Eventi Where Codice=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ")";
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(obj.ToString().ToUpper(), txtCodice.ObjValue.ToString().ToUpper(), false) != 0)
					{
						goto IL_0164;
					}
					rsMess = TranslateMessage("XXX", "Il codice di esito {0} è impostato come default per il relativo tipo evento", txtCodice.ObjValue.ToString());
				}
			}
			goto end_IL_0005;
			IL_0164:
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
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
				switch (cmbBuonFine.ObjValue.ToString())
				{
				case "S":
					hdnTipoEvento.ObjValue = "SPEDIZIONE.ESITO.OK";
					break;
				case "N":
					hdnTipoEvento.ObjValue = "SPEDIZIONE.ESITO.KO";
					break;
				case "P":
					hdnTipoEvento.ObjValue = "SPEDIZIONE.ESITO.PARZ";
					break;
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
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
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
				string text2 = "";
				if (Operators.CompareString(EventoDefault.ObjValue.ToString(), "S", false) == 0)
				{
					text2 = "UPDATE Eventi_Tipi SET EventoDefault=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + " WHERE Codice=(SELECT TipoEvento FROM Eventi Where Codice=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ")";
					val2 = base.DbConn.SqlExec(text2, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_015a;
					}
					val = val2;
				}
				else
				{
					text2 = "UPDATE Eventi_Tipi SET EventoDefault=NULL WHERE Codice=(SELECT TipoEvento FROM Eventi Where Codice=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString()) + ")";
					text2 = text2 + " AND EventoDefault=" + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
					val2 = base.DbConn.SqlExec(text2, ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_015a;
					}
					val = val2;
				}
			}
			goto end_IL_000b;
			IL_015a:
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

	protected void optBuonFine_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmbBuonFine.ObjValue.ToString(), "N", false) == 0)
		{
			lblTentativoEffettuato.Visible = true;
			chkTentativoEffettuato.Visible = true;
			lblAnnullamento.Visible = true;
			chkAnnullamento.Visible = true;
		}
		else
		{
			lblTentativoEffettuato.Visible = false;
			chkTentativoEffettuato.Visible = false;
			lblAnnullamento.Visible = false;
			chkAnnullamento.Visible = false;
		}
	}
}
