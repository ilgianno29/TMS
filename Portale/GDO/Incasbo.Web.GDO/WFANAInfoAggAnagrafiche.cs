using System;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFANAInfoAggAnagrafiche : WFIDBPage
{
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

	[field: AccessedThroughProperty("cp01_Title")]
	protected virtual Panel cp01_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cp01_Title_Caption")]
	protected virtual IboWebLabel cp01_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cp01_Body")]
	protected virtual Panel cp01_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceSoggettoCaption")]
	protected virtual IboWebLabel lblCodiceSoggettoCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoSoggetto")]
	protected virtual HiddenField TipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCodiceSoggettoValue")]
	protected virtual IboWebLabel lblCodiceSoggettoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneSoggettoCaption")]
	protected virtual IboWebLabel lblDescrizioneSoggettoCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizioneSoggettoValue")]
	protected virtual IboWebLabel lblDescrizioneSoggettoValue
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

	[field: AccessedThroughProperty("lblTipoInfo2")]
	protected virtual IboWebLabel lblTipoInfo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoInfo")]
	protected virtual IboWebLabel lblTipoInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoInfo")]
	protected virtual IboWebComboTlk cmbTipoInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInfo")]
	protected virtual IboWebLabel lblInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtInfo")]
	protected virtual IboWebTextBox txtInfo
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
		_Context = "DM.ANA.INFOAGGANAGRAFICHE";
		_Title = base.Translator.Translate("XXX", "Informazioni aggiuntive", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Invalid comparison between Unknown and I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Invalid comparison between Unknown and I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)) || Operators.CompareString(lblCodiceSoggettoValue.Text, "", false) == 0)
			{
				goto IL_029b;
			}
			if (Operators.CompareString(TipoSoggetto.Value, "AUTISTI", false) == 0)
			{
				text = "INSERT INTO AutistiInfoAggiuntive (Autista, IDInfo) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "MEZZI", false) == 0)
			{
				text = "INSERT INTO MezziInfoAggiuntive (Mezzo, IDInfo) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "CLIENTI", false) == 0)
			{
				text = "INSERT INTO ClientiInfoAggiuntive (Cliente, IDInfo) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "TRASPORTATORI", false) == 0)
			{
				text = "INSERT INTO TrasportatoriInfoAggiuntive (Trasportatore, IDInfo) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "PCS", false) == 0)
			{
				text = "INSERT INTO PCS_InfoAggiuntive (PCS, IDInfo) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_029b;
			}
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_029b;
			}
			val = val2;
			goto end_IL_000b;
			IL_029b:
			val2 = base.AfterSaveData(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
}
