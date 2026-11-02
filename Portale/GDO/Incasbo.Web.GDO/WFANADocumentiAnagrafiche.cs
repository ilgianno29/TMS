using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFANADocumentiAnagrafiche : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbTipoDocumento")]
	private IboWebComboTlk _cmbTipoDocumento;

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

	[field: AccessedThroughProperty("cpGeneralita_Title")]
	protected virtual Panel cpGeneralita_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeneralita_Title_Caption")]
	protected virtual Label cpGeneralita_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeneralita_Body")]
	protected virtual Panel cpGeneralita_Body
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

	[field: AccessedThroughProperty("lblNumero2")]
	protected virtual IboWebLabel lblNumero2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumero")]
	protected virtual IboWebLabel lblNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumero")]
	protected virtual IboWebTextBox txtNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRilascio")]
	protected virtual IboWebLabel lblDataRilascio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataRilascio")]
	protected virtual IboWebDate txtDataRilascio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataInizioValidita")]
	protected virtual IboWebLabel lblDataInizioValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataInizioValidita")]
	protected virtual IboWebDate txtDataInizioValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFineValidita")]
	protected virtual IboWebLabel lblDataFineValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataFineValidita")]
	protected virtual IboWebDate txtDataFineValidita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumento")]
	protected virtual IboWebLabel lblTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk cmbTipoDocumento
	{
		[CompilerGenerated]
		get
		{
			return _cmbTipoDocumento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(cmbTipoDocumento_SelectedIndexChanged);
			IboWebComboTlk val2 = _cmbTipoDocumento;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged -= val;
			}
			_cmbTipoDocumento = value;
			val2 = _cmbTipoDocumento;
			if (val2 != null)
			{
				((RadComboBox)val2).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblAttributo1")]
	protected virtual IboWebLabel lblAttributo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo1")]
	protected virtual IboWebTextBox txtAttributo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo2")]
	protected virtual IboWebLabel lblAttributo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo2")]
	protected virtual IboWebTextBox txtAttributo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo3")]
	protected virtual IboWebLabel lblAttributo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo3")]
	protected virtual IboWebTextBox txtAttributo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo4")]
	protected virtual IboWebLabel lblAttributo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo4")]
	protected virtual IboWebTextBox txtAttributo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo5")]
	protected virtual IboWebLabel lblAttributo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo5")]
	protected virtual IboWebTextBox txtAttributo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo6")]
	protected virtual IboWebLabel lblAttributo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo6")]
	protected virtual IboWebTextBox txtAttributo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo7")]
	protected virtual IboWebLabel lblAttributo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo7")]
	protected virtual IboWebTextBox txtAttributo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo8")]
	protected virtual IboWebLabel lblAttributo8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo8")]
	protected virtual IboWebTextBox txtAttributo8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo9")]
	protected virtual IboWebLabel lblAttributo9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo9")]
	protected virtual IboWebTextBox txtAttributo9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAttributo10")]
	protected virtual IboWebLabel lblAttributo10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAttributo10")]
	protected virtual IboWebTextBox txtAttributo10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote")]
	protected virtual IboWebLabel lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	protected virtual IboWebTextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title")]
	protected virtual Panel cpFoto_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title_Caption")]
	protected virtual IboWebLabel cpFoto_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Body")]
	protected virtual Panel cpFoto_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImmagine1")]
	protected virtual IboWebLabel lblImmagine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine1")]
	protected virtual IboWebImage imgImmagine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImmagine2")]
	protected virtual IboWebLabel lblImmagine2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine2")]
	protected virtual IboWebImage imgImmagine2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImmagine3")]
	protected virtual IboWebLabel lblImmagine3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgImmagine3")]
	protected virtual IboWebImage imgImmagine3
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
		_Context = "DM.ANA.DOCUMENTIANA";
		_Title = base.Translator.Translate("XXX", "Documenti", new string[0]);
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
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(cmbTipoDocumento.ObjValue.ToString(), "", false) == 0)
				{
					goto IL_0514;
				}
				text2 = "SELECT * FROM TipiDocumentoAnagrafiche WHERE Codice = " + base.DbConn.SQLFormatString(cmbTipoDocumento.SelectedValue.ToString());
				val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (dataTable.Rows.Count == 1)
					{
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo1"].ToString(), "", false) != 0)
						{
							lblAttributo1.Text = dataTable.Rows[0]["DescrizioneAttributo1"].ToString();
						}
						else
						{
							lblAttributo1.Text = "Attributo1";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo2"].ToString(), "", false) != 0)
						{
							lblAttributo2.Text = dataTable.Rows[0]["DescrizioneAttributo2"].ToString();
						}
						else
						{
							lblAttributo2.Text = "Attributo2";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo3"].ToString(), "", false) != 0)
						{
							lblAttributo3.Text = dataTable.Rows[0]["DescrizioneAttributo3"].ToString();
						}
						else
						{
							lblAttributo3.Text = "Attributo3";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo4"].ToString(), "", false) != 0)
						{
							lblAttributo4.Text = dataTable.Rows[0]["DescrizioneAttributo4"].ToString();
						}
						else
						{
							lblAttributo4.Text = "Attributo4";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo5"].ToString(), "", false) != 0)
						{
							lblAttributo5.Text = dataTable.Rows[0]["DescrizioneAttributo5"].ToString();
						}
						else
						{
							lblAttributo5.Text = "Attributo5";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo6"].ToString(), "", false) != 0)
						{
							lblAttributo6.Text = dataTable.Rows[0]["DescrizioneAttributo6"].ToString();
						}
						else
						{
							lblAttributo6.Text = "Attributo6";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo7"].ToString(), "", false) != 0)
						{
							lblAttributo7.Text = dataTable.Rows[0]["DescrizioneAttributo7"].ToString();
						}
						else
						{
							lblAttributo7.Text = "Attributo7";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo8"].ToString(), "", false) != 0)
						{
							lblAttributo8.Text = dataTable.Rows[0]["DescrizioneAttributo8"].ToString();
						}
						else
						{
							lblAttributo8.Text = "Attributo8";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo9"].ToString(), "", false) != 0)
						{
							lblAttributo9.Text = dataTable.Rows[0]["DescrizioneAttributo9"].ToString();
						}
						else
						{
							lblAttributo9.Text = "Attributo9";
						}
						if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo10"].ToString(), "", false) != 0)
						{
							lblAttributo10.Text = dataTable.Rows[0]["DescrizioneAttributo10"].ToString();
						}
						else
						{
							lblAttributo10.Text = "Attributo10";
						}
					}
					goto IL_0514;
				}
				val = val2;
			}
			goto end_IL_0015;
			IL_0514:
			val = (FXRETURN)0;
			end_IL_0015:;
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
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Invalid comparison between Unknown and I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_02ff;
			}
			if (Operators.CompareString(TipoSoggetto.Value, "CARICATORI", false) == 0)
			{
				text = "INSERT INTO CaricatoriDocumenti (Caricatore, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "AUTISTI", false) == 0)
			{
				text = "INSERT INTO AutistiDocumenti (Autista, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "MEZZI", false) == 0)
			{
				text = "INSERT INTO MezziDocumenti (Mezzo, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "CLIENTI", false) == 0)
			{
				text = "INSERT INTO ClientiDocumenti (Cliente, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "TRASPORTATORI", false) == 0)
			{
				text = "INSERT INTO TrasportatoriDocumenti (Trasportatore, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			else if (Operators.CompareString(TipoSoggetto.Value, "PCS", false) == 0)
			{
				text = "INSERT INTO PCS_Documenti (PCS, IDDocumento) VALUES (";
				text = text + base.DbConn.SQLFormatString(lblCodiceSoggettoValue.Text) + ", ";
				text = text + txtId.Text + ") ";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_02ff;
			}
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_02ff;
			}
			val = val2;
			goto end_IL_000b;
			IL_02ff:
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

	protected void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Invalid comparison between Unknown and I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		string rsMess = "";
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(cmbTipoDocumento.ObjValue.ToString(), "", false) != 0)
			{
				text = "SELECT * FROM TipiDocumentoAnagrafiche WHERE Codice = " + base.DbConn.SQLFormatString(cmbTipoDocumento.SelectedValue.ToString());
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				if (dataTable.Rows.Count == 1)
				{
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo1"].ToString(), "", false) != 0)
					{
						lblAttributo1.Text = dataTable.Rows[0]["DescrizioneAttributo1"].ToString();
					}
					else
					{
						lblAttributo1.Text = "Attributo1";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo2"].ToString(), "", false) != 0)
					{
						lblAttributo2.Text = dataTable.Rows[0]["DescrizioneAttributo2"].ToString();
					}
					else
					{
						lblAttributo2.Text = "Attributo2";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo3"].ToString(), "", false) != 0)
					{
						lblAttributo3.Text = dataTable.Rows[0]["DescrizioneAttributo3"].ToString();
					}
					else
					{
						lblAttributo3.Text = "Attributo3";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo4"].ToString(), "", false) != 0)
					{
						lblAttributo4.Text = dataTable.Rows[0]["DescrizioneAttributo4"].ToString();
					}
					else
					{
						lblAttributo4.Text = "Attributo4";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo5"].ToString(), "", false) != 0)
					{
						lblAttributo5.Text = dataTable.Rows[0]["DescrizioneAttributo5"].ToString();
					}
					else
					{
						lblAttributo5.Text = "Attributo5";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo6"].ToString(), "", false) != 0)
					{
						lblAttributo6.Text = dataTable.Rows[0]["DescrizioneAttributo6"].ToString();
					}
					else
					{
						lblAttributo6.Text = "Attributo6";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo7"].ToString(), "", false) != 0)
					{
						lblAttributo7.Text = dataTable.Rows[0]["DescrizioneAttributo7"].ToString();
					}
					else
					{
						lblAttributo7.Text = "Attributo7";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo8"].ToString(), "", false) != 0)
					{
						lblAttributo8.Text = dataTable.Rows[0]["DescrizioneAttributo8"].ToString();
					}
					else
					{
						lblAttributo8.Text = "Attributo8";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo9"].ToString(), "", false) != 0)
					{
						lblAttributo9.Text = dataTable.Rows[0]["DescrizioneAttributo9"].ToString();
					}
					else
					{
						lblAttributo9.Text = "Attributo9";
					}
					if (Operators.CompareString(dataTable.Rows[0]["DescrizioneAttributo10"].ToString(), "", false) != 0)
					{
						lblAttributo10.Text = dataTable.Rows[0]["DescrizioneAttributo10"].ToString();
					}
					else
					{
						lblAttributo10.Text = "Attributo10";
					}
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
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}
}
