using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioniRicavi : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtQuantitaTassata")]
	private IboWebNumericTlk _txtQuantitaTassata;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtImportoUnitario")]
	private IboWebNumericTlk _txtImportoUnitario;

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

	[field: AccessedThroughProperty("cpTestata_Title")]
	protected virtual Panel cpTestata_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Title_Caption")]
	protected virtual IboWebLabel cpTestata_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpTestata_Body")]
	protected virtual Panel cpTestata_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibol")]
	protected virtual IboWebLabel lblUnibol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibolValue")]
	protected virtual IboWebLabel lblUnibolValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBollaCaption")]
	protected virtual IboWebLabel lblNumeroBollaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroBollaValue")]
	protected virtual IboWebLabel lblNumeroBollaValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineCaption")]
	protected virtual IboWebLabel lblNumeroOrdineCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroOrdineValue")]
	protected virtual IboWebLabel lblNumeroOrdineValue
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

	[field: AccessedThroughProperty("lblClienteValue")]
	protected virtual IboWebLabel lblClienteValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizione")]
	protected virtual IboWebLabel lblTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneValue")]
	protected virtual IboWebLabel lblTipoSpedizioneValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerce")]
	protected virtual IboWebLabel lblTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceValue")]
	protected virtual IboWebLabel lblTipoMerceValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazione")]
	protected virtual IboWebLabel lblDestinazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazioneValue")]
	protected virtual IboWebLabel lblDestinazioneValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazioneLocalita")]
	protected virtual IboWebLabel lblDestinazioneLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDestinazioneLocalitaValue")]
	protected virtual IboWebLabel lblDestinazioneLocalitaValue
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

	[field: AccessedThroughProperty("up_cpRicavi")]
	protected virtual UpdatePanel up_cpRicavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVoce")]
	protected virtual IboWebLabel lblVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbVoce")]
	protected virtual IboWebComboTlk cmbVoce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblQuantitaOriginale")]
	protected virtual IboWebLabel lblQuantitaOriginale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebNumericTlk txtQuantitaTassata
	{
		[CompilerGenerated]
		get
		{
			return _txtQuantitaTassata;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtQuantitaTassata_TextChanged;
			IboWebNumericTlk val = _txtQuantitaTassata;
			if (val != null)
			{
				((RadInputControl)val).TextChanged -= eventHandler;
			}
			_txtQuantitaTassata = value;
			val = _txtQuantitaTassata;
			if (val != null)
			{
				((RadInputControl)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblImportoUnitario")]
	protected virtual IboWebLabel lblImportoUnitario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebNumericTlk txtImportoUnitario
	{
		[CompilerGenerated]
		get
		{
			return _txtImportoUnitario;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = txtImportoUnitario_TextChanged;
			IboWebNumericTlk val = _txtImportoUnitario;
			if (val != null)
			{
				((RadInputControl)val).TextChanged -= eventHandler;
			}
			_txtImportoUnitario = value;
			val = _txtImportoUnitario;
			if (val != null)
			{
				((RadInputControl)val).TextChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblImportoTotale")]
	protected virtual IboWebLabel lblImportoTotale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtImportoArrotondato")]
	protected virtual IboWebNumericTlk txtImportoArrotondato
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

	[field: AccessedThroughProperty("txtUnibol")]
	protected virtual IboWebTextBox txtUnibol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRecordZZ")]
	protected virtual IboWebTextBox txtRecordZZ
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTipoCalcolo")]
	protected virtual IboWebTextBox txtTipoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdRaggruppamento")]
	protected virtual IboWebTextBox txtIdRaggruppamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCampoCalcolo")]
	protected virtual IboWebTextBox txtCampoCalcolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUtenteForzatura")]
	protected virtual IboWebTextBox txtUtenteForzatura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEstremiTariffa")]
	protected virtual IboWebTextBox txtEstremiTariffa
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

	[field: AccessedThroughProperty("txtQuantitaArrotondata")]
	protected virtual IboWebNumericTlk txtQuantitaArrotondata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtQuantitaOriginale")]
	protected virtual IboWebNumericTlk txtQuantitaOriginale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtImportoOriginale")]
	protected virtual IboWebNumericTlk txtImportoOriginale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.SPEDIZIONI.RICAVI";
		_Title = base.Translator.Translate("XXX", "Ricavo Spedizione", new string[0]);
		try
		{
			((RadNumericTextBox)txtImportoArrotondato).Value = Math.Abs(((RadNumericTextBox)txtImportoArrotondato).Value.Value);
			((RadNumericTextBox)txtImportoUnitario).Value = Math.Abs(((RadNumericTextBox)txtImportoUnitario).Value.Value);
			txtImportoOriginale.ObjValue = Math.Abs(((RadNumericTextBox)txtImportoArrotondato).Value.Value);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
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
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				text = "SELECT S.Cliente Cliente, C1.RagioneSociale ClienteDescrizione, ";
				text += "S.TipoSpedizione TipoSpedizione, TS.Descrizione TipoSpedizioneDescrizione, ";
				text += "S.TipoMerce TipoMerce, TM.Descrizione TipoMerceDescrizione, ";
				text += "S.PCSDestinazione Destinazione, S.PCSDestinazione_RagSoc DestinazioneDescrizione, ";
				text += "S.PCSDestinazione_Localita DestinazioneLocalita, PCSDestinazione_Nazione DestinazioneNazione, ";
				text += "S.NumeroBolla, S.NumeroOrdine, S.DataBolla, S.DataOrdine ";
				text += "FROM SPEDIZIONI S ";
				text += "INNER JOIN CLIENTI C1 On C1.Codice=S.Cliente ";
				text += "INNER JOIN TIPISPEDIZIONE TS On TS.Codice=S.TipoSpedizione ";
				text += "LEFT JOIN TIPIMERCE TM On TM.Codice=S.TipoMerce ";
				text = text + "WHERE S.Unibol=" + base.DbConn.SQLFormatString(txtUnibol.ObjValue.ToString()) + " ";
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable.Rows.Count == 0)
				{
					rsMess = base.Translator.Translate("XXX", "Spedizione non trovata", new string[0]);
				}
				else
				{
					lblUnibolValue.Text = Strings.Left(txtUnibol.ObjValue.ToString(), 60);
					lblClienteValue.Text = Strings.Left(dataTable.Rows[0]["Cliente"].ToString() + " - " + dataTable.Rows[0]["ClienteDescrizione"].ToString(), 60);
					lblTipoSpedizioneValue.Text = Strings.Left(dataTable.Rows[0]["TipoSpedizione"].ToString() + " - " + dataTable.Rows[0]["TipoSpedizioneDescrizione"].ToString(), 60);
					lblTipoMerceValue.Text = Strings.Left(dataTable.Rows[0]["TipoMerce"].ToString() + " - " + dataTable.Rows[0]["TipoMerceDescrizione"].ToString(), 60);
					if (Operators.CompareString(dataTable.Rows[0]["Destinazione"].ToString(), "", false) != 0)
					{
						lblDestinazioneValue.Text = Strings.Left(dataTable.Rows[0]["Destinazione"].ToString() + " - " + dataTable.Rows[0]["DestinazioneDescrizione"].ToString(), 60);
						lblDestinazioneLocalitaValue.Text = Strings.Left(dataTable.Rows[0]["DestinazioneLocalita"].ToString() + " (" + dataTable.Rows[0]["DestinazioneNazione"].ToString() + ")", 60);
					}
					lblNumeroBollaValue.ObjValue = dataTable.Rows[0]["NumeroBolla"].ToString();
					lblNumeroOrdineValue.ObjValue = dataTable.Rows[0]["NumeroOrdine"].ToString();
					txtTipoCalcolo.ObjValue = "MAN";
					if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
					{
						txtRecordZZ.ObjValue = "N";
						txtCampoCalcolo.ObjValue = "FORFAIT";
					}
					if (Operators.CompareString(txtRecordZZ.ObjValue.ToString(), "N", false) != 0)
					{
						rsMess = TranslateMessage("XXX", "Impossibile Inserire/Modificare un ricavo di raggruppamento");
					}
					else
					{
						txtIdRaggruppamento.ObjValue = txtUnibol.ObjValue.ToString();
						txtUtenteForzatura.ObjValue = base.SessionEnvironment.WebUser.WebUserInfo.Codice;
						val = (FXRETURN)0;
					}
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
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
				string text = "SELECT TipoVoce FROM Voci WHERE Codice=" + base.DbConn.SQLFormatString(cmbVoce.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, (object)"A", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					int num = ((Operators.CompareString(obj.ToString(), "S", false) != 0) ? 1 : (-1));
					((RadNumericTextBox)txtImportoArrotondato).Value = (double)num * ((RadNumericTextBox)txtImportoArrotondato).Value;
					((RadNumericTextBox)txtImportoUnitario).Value = (double)num * ((RadNumericTextBox)txtImportoUnitario).Value;
					txtQuantitaOriginale.ObjValue = ((RadNumericTextBox)txtQuantitaTassata).Value;
					txtQuantitaArrotondata.ObjValue = ((RadNumericTextBox)txtQuantitaTassata).Value;
					txtImportoOriginale.ObjValue = ((RadNumericTextBox)txtImportoArrotondato).Value;
					txtEstremiTariffa.ObjValue = "";
					txtNote.ObjValue = "";
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

	private void txtImportoUnitario_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double rdTotale = 0.0;
		string rsMess = "";
		try
		{
			val2 = AggiornamentoImportoTotale(ref rdTotale, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			txtImportoArrotondato.ObjValue = rdTotale;
			SetIncasFocusToControl((Control)(object)txtImportoArrotondato);
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
			if ((int)val == 0)
			{
				up_cpRicavi.Update();
			}
		}
	}

	private void txtQuantitaTassata_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		double rdTotale = 0.0;
		string rsMess = "";
		try
		{
			val2 = AggiornamentoImportoTotale(ref rdTotale, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			txtImportoArrotondato.ObjValue = rdTotale;
			SetIncasFocusToControl((Control)(object)txtImportoUnitario);
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
			if ((int)val == 0)
			{
				up_cpRicavi.Update();
			}
		}
	}

	private FXRETURN AggiornamentoImportoTotale(ref double rdTotale, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		double num = 0.0;
		double num2 = 0.0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rdTotale = 0.0;
			rsMess = "";
			try
			{
				num2 = Conversions.ToDouble(txtImportoUnitario.ObjValue);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				num = Conversions.ToDouble(txtQuantitaTassata.ObjValue);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			rdTotale = num2 * num;
			val = (FXRETURN)0;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception objEx = ex5;
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
