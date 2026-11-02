using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Delsy;

public class WFFATFatturePassiveTestataConferma : WFIDialogPage
{
	private List<int> _ListOfId;

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

	[field: AccessedThroughProperty("lblLabelTrasportatore")]
	protected virtual IboWebLabel lblLabelTrasportatore
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

	[field: AccessedThroughProperty("lblTrasportatoreRagioneSociale")]
	protected virtual IboWebLabel lblTrasportatoreRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelTipoDocumento")]
	protected virtual IboWebLabel lblLabelTipoDocumento
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

	[field: AccessedThroughProperty("lblTipoDocumentoDescrizione")]
	protected virtual IboWebLabel lblTipoDocumentoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelTipoPagamento")]
	protected virtual IboWebLabel lblLabelTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPagamento")]
	protected virtual IboWebLabel lblTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPagamentoDescrizione")]
	protected virtual IboWebLabel lblTipoPagamentoDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLabelData")]
	protected virtual IboWebLabel lblLabelData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOut")]
	protected virtual IboWebLabel lblDataOut
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body_2")]
	protected virtual Panel cpInfoGen_Body_2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroFatture")]
	protected virtual IboWebLabel lblNumeroFatture
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumeroFatture")]
	protected virtual IboWebLabel NumeroFatture
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioni_Title")]
	protected virtual Panel cpOpzioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioni_Title_Caption")]
	protected virtual Label cpOpzioni_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpOpzioni_Body")]
	protected virtual Panel cpOpzioni_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSezionale")]
	protected virtual IboWebLabel lblSezionale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbSezionale")]
	protected virtual IboWebComboTlk cmbSezionale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblData")]
	protected virtual IboWebLabel lblData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtData")]
	protected virtual IboWebDate2 txtData
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
	protected virtual IboWebNumericTlk txtNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContabilizza")]
	protected virtual IboWebLabel lblContabilizza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkContabilizza")]
	protected virtual IboWebCheckBox chkContabilizza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hidIdFattura")]
	protected virtual HiddenField hidIdFattura
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFFATFatturePassiveTestataConferma()
	{
		_ListOfId = null;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.FAT.FATTUREPASSIVE_TESTATA";
		_Title = base.Translator.Translate("XXX", " Conferma Fattura Passiva", new string[0]);
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
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
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
			val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Invalid comparison between Unknown and I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Invalid comparison between Unknown and I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(_SessionVariable["ListOfId"])))
			{
				_ListOfId = new List<int>();
			}
			else
			{
				_ListOfId = (List<int>)_SessionVariable["ListOfId"];
			}
			checked
			{
				int num = _objFunctionArguments.Data.Item("IdFattura").FieldValuesCount - 1;
				for (int i = 0; i <= num; i++)
				{
					_ListOfId.Add(Conversions.ToInteger(_objFunctionArguments.Data.Item("IdFattura").get_FieldValues(i).ToString()));
				}
				_SessionVariable.Add("ListOfId", _ListOfId);
			}
			if (_ListOfId.Count == 1)
			{
				((Control)cpInfoGen_Body_2).Visible = false;
				((Control)cpInfoGen_Body).Visible = true;
				lblNumero.Visible = true;
				txtNumero.Visible = true;
				cmbSezionale.ReadOnly = false;
				hidIdFattura.Value = _objFunctionArguments.Data[0].get_FieldValues(0).ToString();
				text = "SELECT F.Trasportatore, F.Data, F.TipoDocumento, F.Numero, F.Sezionale, F.TipoPagamento,";
				text += "TD.Descrizione AS TipoDocumentoDescrizione, ";
				text += "T.RagioneSociale AS TrasportatoreRagioneSociale, ";
				text += "CP.Descrizione AS TipoPagamentoDescrizione ";
				text += "FROM Fatture_Passive_Testata F ";
				text += "INNER JOIN Trasportatori T ON T.Codice = F.Trasportatore ";
				text += "INNER JOIN CBO_FAT_FATTUREPASSIVE_TIPIDOC TD ON TD.Codice = F.TipoDocumento ";
				text += "INNER JOIN CodiciPagamento CP ON CP.Codice = F.TipoPagamento ";
				string text2 = text;
				DBConnection dbConn = base.DbConn;
				HiddenField val3;
				string value = (val3 = hidIdFattura).Value;
				string text3 = dbConn.SQLFormatNumber(ref value);
				val3.Value = value;
				text = text2 + "WHERE IdFattura = " + text3;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable.Rows.Count == 0)
				{
					rsMess = TranslateMessage("XXX", "Documento inesistente.");
					val = (FXRETURN)5;
				}
				else if (Convert.ToInt64(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Numero"])) != 0)
				{
					rsMess = TranslateMessage("XXX", "Impossibile confermare un documento già confermato.");
					val = (FXRETURN)4;
				}
				else
				{
					lblTrasportatore.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Trasportatore"]);
					lblTrasportatoreRagioneSociale.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TrasportatoreRagioneSociale"]);
					lblTipoDocumento.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoDocumento"]);
					lblTipoDocumentoDescrizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoDocumentoDescrizione"]);
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Data"])))
					{
						lblDataOut.ObjValue = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Data"])).ToShortDateString();
						txtData.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Data"]);
					}
					lblTipoPagamento.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoPagamento"]);
					lblTipoPagamentoDescrizione.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["TipoPagamentoDescrizione"]);
					cmbSezionale.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Sezionale"]);
					lblDataAccessMode.Text = "Conferma Fattura " + dataTable.Rows[0]["Numero"].ToString();
					object obj = null;
					DBConnection dbConn2 = base.DbConn;
					value = (val3 = hidIdFattura).Value;
					string text4 = dbConn2.SQLFormatNumber(ref value);
					val3.Value = value;
					text = "SELECT NumeroEsterno FROM CTRL_Fatture_Passive_Testata WHERE IDFATTURAINTERNO = " + text4;
					val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
					if ((int)val2 <= 0)
					{
						if (Operators.CompareString(obj.ToString(), "", false) != 0)
						{
							txtNumero.ObjValue = obj.ToString();
							txtNumero.ReadOnly = true;
						}
						else
						{
							txtData.ReadOnly = false;
						}
						goto IL_07b5;
					}
					val = val2;
				}
			}
			else
			{
				DataTable dataTable2 = null;
				text = "SELECT IDFATTURA,NUMERO,SEZIONALE,DATA FROM Fatture_Passive_Testata WHERE IdFattura IN (-1";
				foreach (int item in _ListOfId)
				{
					int current = item;
					text = text + "," + base.DbConn.SQLFormatNumber(ref current);
				}
				text += ")";
				val2 = base.DbConn.OpenDataTable(text, ref dataTable2, ref rsMess);
				if ((int)val2 <= 0)
				{
					List<string> list = new List<string>();
					List<DateTime> list2 = new List<DateTime>();
					bool flag = true;
					foreach (DataRow row in dataTable2.Rows)
					{
						if (Convert.ToInt64(RuntimeHelpers.GetObjectValue(row["Numero"])) != 0)
						{
							rsMess = TranslateMessage("XXX", "Impossibile confermare un documento già confermato. Id Fattura {0}", row["IdFattura"].ToString());
							val = (FXRETURN)4;
						}
						else
						{
							if (list.Contains(row["SEZIONALE"].ToString()))
							{
								goto IL_0679;
							}
							list.Add(row["SEZIONALE"].ToString());
							if (list.Count <= 1)
							{
								goto IL_0679;
							}
							rsMess = TranslateMessage("XXX", "Impossibile confermare i documenti selezionati in quanto hanno sezionali differenti");
							val = (FXRETURN)4;
						}
						goto end_IL_000e;
						IL_0679:
						if (Information.IsDate((object)row["DATA"].ToString()) && flag)
						{
							if (!list2.Contains(Conversions.ToDate(row["DATA"].ToString())))
							{
								list2.Add(Conversions.ToDate(row["DATA"].ToString()));
							}
						}
						else
						{
							flag = false;
						}
					}
					if (flag & (list2.Count == 1))
					{
						txtData.ObjValue = list2[0];
					}
					cmbSezionale.ObjValue = list[0];
					cmbSezionale.ReadOnly = true;
					((Control)cpInfoGen_Body_2).Visible = true;
					NumeroFatture.Text = _ListOfId.Count.ToString();
					((Control)cpInfoGen_Body).Visible = false;
					lblNumero.Visible = false;
					txtNumero.Visible = false;
					goto IL_07b5;
				}
				val = val2;
			}
			goto end_IL_000e;
			IL_07b5:
			val = (FXRETURN)0;
			end_IL_000e:;
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
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_ListOfId = (List<int>)_SessionVariable["ListOfId"];
			foreach (int item in _ListOfId)
			{
				int current = item;
				int num = 0;
				object obj = null;
				text = "SELECT NumeroEsterno FROM CTRL_Fatture_Passive_Testata WHERE IDFATTURAINTERNO = " + base.DbConn.SQLFormatNumber(ref current);
				val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					num = ((Operators.CompareString(obj.ToString(), "", false) == 0) ? Conversions.ToInteger(txtNumero.ObjValue.ToString()) : Conversions.ToInteger(obj.ToString()));
					FatturePassiveConferma_Invoker instance = FatturePassiveConferma_Invoker.Instance;
					AppApiContext objApiContext = CreateApiContext();
					long idFattura = current;
					string? sezionale = cmbSezionale.ObjValue.ToString();
					DateTime getDateValue = txtData.getDateValue;
					long? Numero = Convert.ToInt64(num);
					bool Contabilizza = Operators.CompareString(chkContabilizza.ObjValue.ToString(), "S", false) == 0;
					val2 = instance.RunProc(objApiContext, idFattura, sezionale, getDateValue, ref Numero, ref Contabilizza, ref rsMess);
					if ((int)val2 <= 0)
					{
						continue;
					}
					val = val2;
				}
				goto end_IL_000b;
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
}
