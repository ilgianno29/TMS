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

public class WFDOCViaggiRicavi : WFIDBPage
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
	protected virtual Label cpTestata_Title_Caption
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

	[field: AccessedThroughProperty("lblViaggio")]
	protected virtual IboWebLabel lblViaggio
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

	[field: AccessedThroughProperty("lblViaggioValue")]
	protected virtual IboWebLabel lblViaggioValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVettore2")]
	protected virtual IboWebLabel lblVettore2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVettoreValue")]
	protected virtual IboWebLabel lblVettoreValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMezzo")]
	protected virtual IboWebLabel lblMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMezzoValue")]
	protected virtual IboWebLabel lblMezzoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRimorchio")]
	protected virtual IboWebLabel lblRimorchio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRimorchioValue")]
	protected virtual IboWebLabel lblRimorchioValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista1")]
	protected virtual IboWebLabel lblAutista1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista1Value")]
	protected virtual IboWebLabel lblAutista1Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista2")]
	protected virtual IboWebLabel lblAutista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAutista2Value")]
	protected virtual IboWebLabel lblAutista2Value
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

	[field: AccessedThroughProperty("up_cpCosti")]
	protected virtual UpdatePanel up_cpCosti
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

	[field: AccessedThroughProperty("IdViaggio")]
	protected virtual IboWebTextBox IdViaggio
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
		_Context = "DM.DOC.VIAGGI.RICAVI";
		_Title = base.Translator.Translate("XXX", "Ricavo Viaggio", new string[0]);
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
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
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
				text = "SELECT V.IDVIAGGIO,";
				text += "ISNULL(V.MOTRICEEFFETTIVA,V.MOTRICEPIANIFICATA) MEZZO, M.TARGA MEZZODESCRIZIONE, ";
				text += "ISNULL(V.Rimorchio1Effettivo,V.Rimorchio1Pianificato) RIMORCHIO, M1.TARGA RIMORCHIODESCRIZIONE, ";
				text += "ISNULL(V.Autista1Effettivo,V.Autista1Pianificato) AUTISTA1, A.RagioneSociale AUTISTA1Descrizione, ";
				text += "V.Autista2Effettivo AUTISTA2, A1.RagioneSociale AUTISTA2Descrizione, ";
				text += "V.VETTORE VETTORE, T.RagioneSociale VETTOREDescrizione ";
				text += "FROM VIAGGI V ";
				text += "LEFT JOIN MEZZI M On ISNULL(V.MOTRICEEFFETTIVA,V.MOTRICEPIANIFICATA) = M.CODICE ";
				text += "LEFT JOIN MEZZI M1 On ISNULL(V.Rimorchio1Effettivo,V.Rimorchio1Pianificato) = M1.Codice ";
				text += "LEFT JOIN AUTISTI A On ISNULL(V.Autista1Effettivo,V.Autista1Pianificato) = A.Codice ";
				text += "LEFT JOIN AUTISTI A1 On V.Autista2Effettivo = A1.Codice ";
				text += "LEFT JOIN TRASPORTATORI T On T.Codice=V.VETTORE ";
				text = text + "WHERE V.IDVIAGGIO=" + base.DbConn.SQLFormatString(IdViaggio.ObjValue.ToString());
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable.Rows.Count == 0)
				{
					rsMess = base.Translator.Translate("XXX", "Viaggio non trovato", new string[0]);
				}
				else
				{
					lblViaggioValue.ObjValue = Strings.Left(dataTable.Rows[0]["IDVIAGGIO"].ToString(), 60);
					lblVettoreValue.ObjValue = Strings.Left(dataTable.Rows[0]["VETTORE"].ToString() + " - " + dataTable.Rows[0]["VETTOREDescrizione"].ToString(), 60);
					if (Operators.CompareString(dataTable.Rows[0]["MEZZO"].ToString(), "", false) != 0)
					{
						lblMezzoValue.ObjValue = Strings.Left(dataTable.Rows[0]["MEZZO"].ToString() + " - " + dataTable.Rows[0]["MEZZODESCRIZIONE"].ToString(), 60);
					}
					if (Operators.CompareString(dataTable.Rows[0]["RIMORCHIO"].ToString(), "", false) != 0)
					{
						lblRimorchioValue.ObjValue = Strings.Left(dataTable.Rows[0]["RIMORCHIO"].ToString() + " - " + dataTable.Rows[0]["RIMORCHIODescrizione"].ToString(), 60);
					}
					if (Operators.CompareString(dataTable.Rows[0]["AUTISTA1"].ToString(), "", false) != 0)
					{
						lblAutista1Value.ObjValue = Strings.Left(dataTable.Rows[0]["AUTISTA1"].ToString() + " - " + dataTable.Rows[0]["AUTISTA1Descrizione"].ToString(), 60);
					}
					if (Operators.CompareString(dataTable.Rows[0]["AUTISTA2"].ToString(), "", false) != 0)
					{
						lblAutista2Value.ObjValue = Strings.Left(dataTable.Rows[0]["AUTISTA2"].ToString() + " - " + dataTable.Rows[0]["AUTISTA2Descrizione"].ToString(), 60);
					}
					txtTipoCalcolo.ObjValue = "MAN";
					if (Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0)
					{
						txtRecordZZ.ObjValue = "N";
						txtCampoCalcolo.ObjValue = "FORFAIT";
					}
					if (Operators.CompareString(txtRecordZZ.ObjValue.ToString(), "N", false) != 0)
					{
						rsMess = TranslateMessage("XXX", "Impossibile Inserire/Modificare un costo di raggruppamento");
					}
					else
					{
						txtIdRaggruppamento.ObjValue = IdViaggio.ObjValue.ToString();
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
				up_cpCosti.Update();
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
				up_cpCosti.Update();
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
