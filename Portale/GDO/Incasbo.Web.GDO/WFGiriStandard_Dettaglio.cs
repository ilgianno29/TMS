using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFGiriStandard_Dettaglio : WFIDBPage
{
	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain_Dettaglio")]
	protected virtual Panel pnlMain_Dettaglio
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

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
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

	[field: AccessedThroughProperty("lblIdGiro")]
	protected virtual IboWebLabel lblIdGiro
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

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebHidden txtId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlIniziale")]
	protected virtual Panel pnlIniziale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiTestata")]
	protected virtual Panel pnlDatiTestata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatiTestataCaption")]
	protected virtual IboWebLabel lblDatiTestataCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimentoEsterno1")]
	protected virtual IboWebLabel lblRiferimentoEsterno1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRiferimentoEsterno")]
	protected virtual IboWebLabel lblRiferimentoEsterno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescrizione1")]
	protected virtual IboWebLabel lblDescrizione1
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

	[field: AccessedThroughProperty("lblDescGiornoPartenza1")]
	protected virtual IboWebLabel lblDescGiornoPartenza1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescGiornoPartenza")]
	protected virtual IboWebLabel lblDescGiornoPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescGiornoCutOff1")]
	protected virtual IboWebLabel lblDescGiornoCutOff1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDescGiornoCutOff")]
	protected virtual IboWebLabel lblDescGiornoCutOff
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerce1")]
	protected virtual IboWebLabel lblTipoMerce1
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

	[field: AccessedThroughProperty("lblTipoSpedizione1")]
	protected virtual IboWebLabel lblTipoSpedizione1
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

	[field: AccessedThroughProperty("lblDepositoPartenza1")]
	protected virtual IboWebLabel lblDepositoPartenza1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDepositoPartenza")]
	protected virtual IboWebLabel lblDepositoPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDepositoArrivo1")]
	protected virtual IboWebLabel lblDepositoArrivo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDepositoArrivo")]
	protected virtual IboWebLabel lblDepositoArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlIniziale1")]
	protected virtual Panel pnlIniziale1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDatiDettaglio")]
	protected virtual Panel pnlDatiDettaglio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDatiDettaglioCaption")]
	protected virtual IboWebLabel lblDatiDettaglioCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPcs")]
	protected virtual IboWebLabel lblPcs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPcs")]
	protected virtual IboWebComboTlk cmbPcs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblOraConsegna")]
	protected virtual IboWebLabel lblOraConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtOraConsegna")]
	protected virtual IboWebDate2 txtOraConsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSequenza")]
	protected virtual IboWebLabel lblSequenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSequenza")]
	protected virtual IboWebTextBox txtSequenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondente")]
	protected virtual IboWebLabel lblCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbCorrispondente")]
	protected virtual IboWebComboTlk cmbCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		object obj = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		_Context = "DM.GIRISTANDARD_DETTAGLI";
		_Title = base.Translator.Translate("XXX", "Gestione Giri Standard Dettaglio", new string[0]);
		val2 = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return val2;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
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
				val2 = LookupQueryDecode((Control)(object)pnlDatiTestata, ref rsMess);
				if ((int)val2 <= 0)
				{
					if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
					{
						cmbPcs.Enabled = false;
					}
					text2 = txtCodice.ObjValue.ToString();
					if ((int)base.DbConn.ServerTypeConnection == 1)
					{
						text = "SELECT GT.*, isnull(P.ragionesociale, '') || ' - ' || isnull(P.localita, '') DepositoPartenza,  isnull(P1.ragionesociale, '') || ' - ' || isnull(P1.localita, '') DepositoArrivo FROM GiriStandard_Testata GT";
						text += " left join Pcs P ON P.CODICE=GT.DepositoPartenza";
						text = text + " left join Pcs P1 ON P1.CODICE=GT.DepositoArrivo WHERE GT.Codice = " + base.DbConn.SQLFormatString(text2);
					}
					else if ((int)base.DbConn.ServerTypeConnection == 0)
					{
						text = "SELECT GT.*, isnull(P.ragionesociale, '') + ' - ' + isnull(P.localita, '') DepositoPartenza,  isnull(P1.ragionesociale, '') + ' - ' + isnull(P1.localita, '') DepositoArrivo FROM GiriStandard_Testata GT";
						text += " left join Pcs P ON P.CODICE=GT.DepositoPartenza";
						text = text + " left join Pcs P1 ON P1.CODICE=GT.DepositoArrivo WHERE GT.Codice = " + base.DbConn.SQLFormatString(text2);
					}
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						lblRiferimentoEsterno.ObjValue = dataTable.Rows[0]["RiferimentoEsterno"].ToString();
						lblDescrizione.ObjValue = dataTable.Rows[0]["Descrizione"].ToString();
						if (Operators.CompareString(dataTable.Rows[0]["GiornoPartenza"].ToString(), "", false) != 0)
						{
							string text3 = dataTable.Rows[0]["GiornoPartenza"].ToString();
							if (Operators.CompareString(text3.ToString(), "", false) != 0)
							{
								switch (text3)
								{
								case "1":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Lunedì");
									break;
								case "2":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Martedì");
									break;
								case "3":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Mercoledì");
									break;
								case "4":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Giovedì");
									break;
								case "5":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Venerdì");
									break;
								case "6":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Sabato");
									break;
								case "7":
									lblDescGiornoPartenza.ObjValue = TranslateMessage("XXX", "Domenica");
									break;
								}
							}
						}
						if (Operators.CompareString(dataTable.Rows[0]["GiornoCutOff"].ToString(), "", false) != 0)
						{
							string text4 = dataTable.Rows[0]["GiornoCutOff"].ToString();
							if (Operators.CompareString(text4.ToString(), "", false) != 0)
							{
								switch (text4)
								{
								case "1":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Lunedì");
									break;
								case "2":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Martedì");
									break;
								case "3":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Mercoledì");
									break;
								case "4":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Giovedì");
									break;
								case "5":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Venerdì");
									break;
								case "6":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Sabato");
									break;
								case "7":
									lblDescGiornoCutOff.ObjValue = TranslateMessage("XXX", "Domenica");
									break;
								}
							}
						}
						lblDepositoPartenza.ObjValue = dataTable.Rows[0]["DepositoPartenza"].ToString();
						lblDepositoArrivo.ObjValue = dataTable.Rows[0]["DepositoArrivo"].ToString();
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
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
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
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0)
				{
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		object obj2 = null;
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (!((Operators.CompareString(_objFunctionArguments.Name, "INSERIMENTO", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "DUPLICAZIONE", false) == 0)))
				{
					goto IL_0118;
				}
				string text2 = "SELECT COUNT(*) FROM GiriStandard_Dettagli ";
				text2 = text2 + "WHERE Codice = " + base.DbConn.SQLFormatString(txtCodice.ObjValue.ToString());
				text2 = text2 + "AND PCS=" + base.DbConn.SQLFormatString(cmbPcs.ObjValue.ToString());
				val2 = base.DbConn.DoSql(text2, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Conversions.ToInteger(obj) <= 0)
					{
						goto IL_0118;
					}
					rsMess = TranslateMessage("XXX", "Il PCS risulta già inserito nel giro");
				}
			}
			goto end_IL_0014;
			IL_0118:
			val = (FXRETURN)0;
			end_IL_0014:;
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
