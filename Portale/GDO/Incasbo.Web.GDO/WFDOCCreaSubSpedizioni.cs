using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Globalization;
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
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCCreaSubSpedizioni : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NumeroSubSpedizioni")]
	private DropDownList _NumeroSubSpedizioni;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rp_Tratte")]
	private Repeater _rp_Tratte;

	protected List<Spedizione_Tratta> _Tratte;

	protected StringCollection _TipiServiziSubSpedizioni;

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

	[field: AccessedThroughProperty("HF_TipoServizio")]
	protected virtual IboWebHidden HF_TipoServizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HF_Corrispondente")]
	protected virtual IboWebHidden HF_Corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFCountOfSubSpedizioni")]
	protected virtual IboWebHidden HFCountOfSubSpedizioni
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

	[field: AccessedThroughProperty("lblDataBollaCaption")]
	protected virtual IboWebLabel lblDataBollaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataBollaValue")]
	protected virtual IboWebLabel lblDataBollaValue
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

	[field: AccessedThroughProperty("lblDataOrdineCaption")]
	protected virtual IboWebLabel lblDataOrdineCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOrdineValue")]
	protected virtual IboWebLabel lblDataOrdineValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaCaption")]
	protected virtual IboWebLabel lblDataConsegnaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFDataConsegnaPrevista2")]
	protected virtual IboWebHidden HFDataConsegnaPrevista2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HFDataConsegnaConcordata")]
	protected virtual IboWebHidden HFDataConsegnaConcordata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataConsegnaValue")]
	protected virtual IboWebLabel lblDataConsegnaValue
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

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteRagioneSociale")]
	protected virtual IboWebLabel lblClienteRagioneSociale
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

	[field: AccessedThroughProperty("lblTipoSpedizioneDescrizione")]
	protected virtual IboWebLabel lblTipoSpedizioneDescrizione
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

	[field: AccessedThroughProperty("lblTipoMerceDescrizione")]
	protected virtual IboWebLabel lblTipoMerceDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenza")]
	protected virtual IboWebLabel lblPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaValue")]
	protected virtual IboWebLabel lblPartenzaValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaRagioneSociale")]
	protected virtual IboWebLabel lblPartenzaRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel16")]
	protected virtual IboWebLabel IboWebLabel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaLocalita")]
	protected virtual IboWebLabel lblPartenzaLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel18")]
	protected virtual IboWebLabel IboWebLabel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaProvincia")]
	protected virtual IboWebLabel lblPartenzaProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel20")]
	protected virtual IboWebLabel IboWebLabel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPartenzaNazione")]
	protected virtual IboWebLabel lblPartenzaNazione
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

	[field: AccessedThroughProperty("lblPCSDestinazione_RagSoc")]
	protected virtual IboWebLabel lblPCSDestinazione_RagSoc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel6")]
	protected virtual IboWebLabel IboWebLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazione_Localita")]
	protected virtual IboWebLabel lblPCSDestinazione_Localita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel10")]
	protected virtual IboWebLabel IboWebLabel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazione_Provincia")]
	protected virtual IboWebLabel lblPCSDestinazione_Provincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel11")]
	protected virtual IboWebLabel IboWebLabel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSDestinazione_Nazione")]
	protected virtual IboWebLabel lblPCSDestinazione_Nazione
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

	[field: AccessedThroughProperty("lblCorrispondenteValue")]
	protected virtual IboWebLabel lblCorrispondenteValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondenteRagioneSociale")]
	protected virtual IboWebLabel lblCorrispondenteRagioneSociale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel2")]
	protected virtual IboWebLabel IboWebLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondenteLocalita")]
	protected virtual IboWebLabel lblCorrispondenteLocalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel3")]
	protected virtual IboWebLabel IboWebLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondenteProvincia")]
	protected virtual IboWebLabel lblCorrispondenteProvincia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel4")]
	protected virtual IboWebLabel IboWebLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondenteNazione")]
	protected virtual IboWebLabel lblCorrispondenteNazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGenerazioneTratte_Title")]
	protected virtual Panel cpGenerazioneTratte_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGenerazioneTratte_Title_Caption")]
	protected virtual IboWebLabel cpGenerazioneTratte_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGenerazioneTratte_Body")]
	protected virtual Panel cpGenerazioneTratte_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlNumeroSubSpedizioni")]
	protected virtual Panel pnlNumeroSubSpedizioni
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

	[field: AccessedThroughProperty("up_NumeroSubSpedizioni")]
	protected virtual UpdatePanel up_NumeroSubSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DropDownList NumeroSubSpedizioni
	{
		[CompilerGenerated]
		get
		{
			return _NumeroSubSpedizioni;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = NumeroSubSpedizioni_SelectedIndexChanged;
			DropDownList numeroSubSpedizioni = _NumeroSubSpedizioni;
			if (numeroSubSpedizioni != null)
			{
				((ListControl)numeroSubSpedizioni).SelectedIndexChanged -= eventHandler;
			}
			_NumeroSubSpedizioni = value;
			numeroSubSpedizioni = _NumeroSubSpedizioni;
			if (numeroSubSpedizioni != null)
			{
				((ListControl)numeroSubSpedizioni).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("up_rp_Tratte")]
	protected virtual UpdatePanel up_rp_Tratte
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Repeater rp_Tratte
	{
		[CompilerGenerated]
		get
		{
			return _rp_Tratte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RepeaterItemEventHandler val = new RepeaterItemEventHandler(rp_Tratte_ItemDataBound);
			Repeater val2 = _rp_Tratte;
			if (val2 != null)
			{
				val2.ItemDataBound -= val;
			}
			_rp_Tratte = value;
			val2 = _rp_Tratte;
			if (val2 != null)
			{
				val2.ItemDataBound += val;
			}
		}
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.SPEDIZIONI";
		_Title = base.Translator.Translate("XXX", "Gestione delle sub-spedizioni", new string[0]);
		if (_SessionVariable.ContainsKey("Tratte"))
		{
			_Tratte = (List<Spedizione_Tratta>)_SessionVariable["Tratte"];
		}
		else
		{
			_Tratte = new List<Spedizione_Tratta>();
			_SessionVariable.Add("Tratte", _Tratte);
		}
		if (_SessionVariable.ContainsKey("TipiServiziSubSpedizioni"))
		{
			_TipiServiziSubSpedizioni = (StringCollection)_SessionVariable["TipiServiziSubSpedizioni"];
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
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Invalid comparison between Unknown and I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) != 0)
			{
				rsMess = TranslateMessage("XXX", "Modalità di accesso non consentita");
			}
			else
			{
				val2 = base.AfterLoadData(ref rsMess);
				if ((int)val2 <= 0)
				{
					object obj = null;
					string text = "SELECT COUNT(*) FROM Spedizioni_SubSpedizioni WHERE Unibol_Spedizione=" + base.DbConn.SQLFormatString(lblUnibolValue.ObjValue.ToString());
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						HFCountOfSubSpedizioni.ObjValue = obj.ToString();
						if (Conversions.ToInteger(obj) > 0)
						{
							_SessionVariable["InsUpd"] = (object)"M";
						}
						else
						{
							_SessionVariable["InsUpd"] = (object)"I";
						}
						if (Operators.CompareString(HFDataConsegnaConcordata.ObjValue.ToString(), "", false) != 0)
						{
							lblDataConsegnaValue.ObjValue = HFDataConsegnaConcordata.ObjValue.ToString();
						}
						else
						{
							lblDataConsegnaValue.ObjValue = HFDataConsegnaPrevista2.ObjValue.ToString();
						}
						text = "SELECT * FROM TipiServizi WHERE CODICE=" + base.DbConn.SQLFormatString(HF_TipoServizio.ObjValue.ToString());
						DataTable dataTable = null;
						val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else if (dataTable.Rows.Count == 0)
						{
							rsMess = TranslateMessage("Impossibile determinare il tipo servizio della spedizione madre");
						}
						else if (Operators.CompareString(dataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString().Trim(), "", false) == 0)
						{
							rsMess = TranslateMessage("Il tipo servizio della spedizione madre non prevede la generazione delle sub-spedizioni");
						}
						else
						{
							string[] array = dataTable.Rows[0]["SubSpedizioni_TipiServizio"].ToString().Split(new char[1] { ',' });
							_TipiServiziSubSpedizioni = new StringCollection();
							string[] array2 = array;
							foreach (string value in array2)
							{
								_TipiServiziSubSpedizioni.Add(value);
							}
							_SessionVariable["TipiServiziSubSpedizioni"] = (object)_TipiServiziSubSpedizioni;
							if (Operators.CompareString(_SessionVariable["InsUpd"].ToString(), "M", false) != 0)
							{
								int num = 3;
								if (Operators.CompareString(((Page)this).Request.QueryString["NumeroSubSpedizioni"], "", false) != 0 && Versioned.IsNumeric((object)((Page)this).Request.QueryString["NumeroSubSpedizioni"]))
								{
									num = Conversions.ToInteger(((Page)this).Request.QueryString["NumeroSubSpedizioni"]);
								}
								if (num > 4)
								{
									num = 4;
								}
								if (num < 2)
								{
									num = 2;
								}
								((ListControl)NumeroSubSpedizioni).SelectedValue = num.ToString();
								GeneraTratte(num);
								goto IL_05f7;
							}
							text = "SELECT S.*, SS.Sequenza SS_Sequenza FROM Spedizioni S INNER JOIN Spedizioni_SubSpedizioni SS ON SS.Unibol_SubSpedizione=S.UNIBOL WHERE SS.Unibol_Spedizione=" + base.DbConn.SQLFormatString(lblUnibolValue.ObjValue.ToString()) + " ORDER BY SS.Sequenza";
							dataTable = null;
							val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
							if ((int)val2 <= 0)
							{
								int num2 = 1;
								_Tratte.Clear();
								foreach (DataRow row in dataTable.Rows)
								{
									Spedizione_Tratta spedizione_Tratta = new Spedizione_Tratta();
									spedizione_Tratta.IdSpedizioneMadre = lblUnibolValue.ObjValue.ToString();
									spedizione_Tratta.IdSubSpedizione = row["Unibol"].ToString();
									spedizione_Tratta.Sequenza = Conversions.ToInteger(row["SS_Sequenza"]);
									spedizione_Tratta.TipoServizio = row["TipoServizio"].ToString();
									spedizione_Tratta.Partenza = row["PCSPartenza"].ToString();
									spedizione_Tratta.Arrivo = row["PCSDestinazione"].ToString();
									spedizione_Tratta.Corrispondente = row["Corrispondente"].ToString();
									spedizione_Tratta.TotaleTratte = dataTable.Rows.Count;
									if (num2 == 1)
									{
										spedizione_Tratta.Descrizione = TranslateMessage("Prima Tratta");
									}
									if (num2 == 2)
									{
										spedizione_Tratta.Descrizione = TranslateMessage("Seconda Tratta");
									}
									if (num2 == 3)
									{
										spedizione_Tratta.Descrizione = TranslateMessage("Terza Tratta");
									}
									if (num2 == 4)
									{
										spedizione_Tratta.Descrizione = TranslateMessage("Quarta Tratta");
									}
									if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["DataConsegnaPrevista2"])))
									{
										spedizione_Tratta.DataConsegna = Conversions.ToDate(row["DataConsegnaPrevista2"]);
									}
									_Tratte.Add(spedizione_Tratta);
									num2 = checked(num2 + 1);
								}
								((Control)pnlNumeroSubSpedizioni).Visible = false;
								goto IL_05f7;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_05f7:
			RepeaterDataBind();
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

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Invalid comparison between Unknown and I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (RepeaterItem item in rp_Tratte.Items)
			{
				RepeaterItem val3 = item;
				IboWebComboTlk val4 = (IboWebComboTlk)GetControlByName((Control)(object)val3, "rp_TipoServizio_value");
				IboWebComboTlk val5 = (IboWebComboTlk)GetControlByName((Control)(object)val3, "rp_Corrispondente_value");
				IboWebDate2 iboWebDate = (IboWebDate2)(object)GetControlByName((Control)(object)val3, "rp_DataConsegna_value");
				_Tratte[val3.ItemIndex].TipoServizio = val4.ObjValue.ToString();
				_Tratte[val3.ItemIndex].Corrispondente = val5.ObjValue.ToString();
				_Tratte[val3.ItemIndex].DataConsegna = iboWebDate.getDateValue2;
			}
			DateTime t = DateTime.MinValue;
			checked
			{
				foreach (Spedizione_Tratta item2 in _Tratte)
				{
					if (Operators.CompareString(item2.TipoServizio, "", false) == 0)
					{
						((RadComboBox)(IboWebComboTlk)GetControlByName((Control)(object)rp_Tratte.Items[item2.Sequenza - 1], "rp_TipoServizio_value")).Focus();
						rsMess = TranslateMessage("E' obbligatorio specificare il Tipo servizio");
					}
					else if (Operators.CompareString(item2.Partenza, "", false) == 0)
					{
						rsMess = TranslateMessage("E' obbligatorio specificare il punto di partenza");
					}
					else if (Operators.CompareString(item2.Arrivo, "", false) == 0)
					{
						((RadComboBox)(IboWebComboTlk)GetControlByName((Control)(object)rp_Tratte.Items[item2.Sequenza - 1], "rp_Arrivo_Value")).Focus();
						rsMess = TranslateMessage("E' obbligatorio specificare il punto di Arrivo");
					}
					else
					{
						if (!item2.DataConsegna.HasValue)
						{
							continue;
						}
						DateTime? dataConsegna = item2.DataConsegna;
						if ((dataConsegna.HasValue ? new bool?(DateTime.Compare(dataConsegna.GetValueOrDefault(), t) < 0) : null).GetValueOrDefault())
						{
							((IboWebDate2)(object)GetControlByName((Control)(object)rp_Tratte.Items[item2.Sequenza - 1], "rp_DataConsegna_Value")).Focus();
							rsMess = TranslateMessage("Date di consegna non coerenti");
						}
						else
						{
							dataConsegna = item2.DataConsegna;
							DateTime? dataConsegna2 = _Tratte[item2.TotaleTratte - 1].DataConsegna;
							if (!((dataConsegna.HasValue & dataConsegna2.HasValue) ? new bool?(DateTime.Compare(dataConsegna.GetValueOrDefault(), dataConsegna2.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
							{
								t = item2.DataConsegna.Value;
								continue;
							}
							((IboWebDate2)(object)GetControlByName((Control)(object)rp_Tratte.Items[item2.Sequenza - 1], "rp_DataConsegna_Value")).Focus();
							rsMess = TranslateMessage("Date di consegna non coerenti");
						}
					}
					goto end_IL_0005;
				}
				val2 = base.AfterCheckData(ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
			}
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(_SessionVariable["InsUpd"].ToString(), "I", false) == 0)
			{
				Spedizione_CreaSubSpedizioni_Invoker instance = Spedizione_CreaSubSpedizioni_Invoker.Instance;
				AppApiContext objApiContext = CreateApiContext();
				string Unibol = lblUnibolValue.ObjValue.ToString();
				val = instance.RunProc(objApiContext, ref Unibol, _Tratte, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_00b8;
				}
				val2 = val;
			}
			else
			{
				Spedizione_ModificaSubSpedizioni_Invoker instance2 = Spedizione_ModificaSubSpedizioni_Invoker.Instance;
				AppApiContext objApiContext2 = CreateApiContext();
				string Unibol = lblUnibolValue.ObjValue.ToString();
				val = instance2.RunProc(objApiContext2, ref Unibol, _Tratte, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_00b8;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_00b8:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected void RepeaterDataBind()
	{
		try
		{
			rp_Tratte.DataSource = _Tratte;
			rp_Tratte.DataBind();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public string TrascodificaPCS(string PCS)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(PCS, "", false) == 0)
		{
			return "";
		}
		string text = "SELECT RagioneSociale %+% ' - ' %+% Localita %+% ' - ' %+% Provincia Descrizione FROM PCS WHERE CODICE=" + base.DbConn.SQLFormatString(PCS);
		text = base.DbConn.SqlConvertForServer(text);
		object obj = null;
		DBConnection dbConn = base.DbConn;
		string text2 = text;
		string text3 = "";
		dbConn.DoSql(text2, (object)"", ref obj, ref text3);
		return obj.ToString();
	}

	private void GeneraTratte(int NumeroSubSpedizioni)
	{
		_Tratte.Clear();
		if (NumeroSubSpedizioni > 0)
		{
			for (int i = 1; i <= NumeroSubSpedizioni; i = checked(i + 1))
			{
				Spedizione_Tratta spedizione_Tratta = new Spedizione_Tratta();
				spedizione_Tratta.IdSpedizioneMadre = lblUnibolValue.ObjValue.ToString();
				spedizione_Tratta.Sequenza = i;
				spedizione_Tratta.TotaleTratte = NumeroSubSpedizioni;
				if (i == 1)
				{
					spedizione_Tratta.Partenza = lblPartenzaValue.ObjValue.ToString();
					spedizione_Tratta.Descrizione = TranslateMessage("Prima Tratta");
				}
				if (i == 2)
				{
					spedizione_Tratta.Descrizione = TranslateMessage("Seconda Tratta");
				}
				if (i == 3)
				{
					spedizione_Tratta.Descrizione = TranslateMessage("Terza Tratta");
				}
				if (i == 4)
				{
					spedizione_Tratta.Descrizione = TranslateMessage("Quarta Tratta");
				}
				if (i == NumeroSubSpedizioni)
				{
					spedizione_Tratta.Arrivo = lblDestinazioneValue.ObjValue.ToString();
					if (Operators.CompareString(HF_Corrispondente.ObjValue.ToString(), "", false) != 0)
					{
						spedizione_Tratta.Corrispondente = HF_Corrispondente.ObjValue.ToString();
					}
					spedizione_Tratta.DataConsegna = DateTime.ParseExact(lblDataConsegnaValue.ObjValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
				}
				_Tratte.Add(spedizione_Tratta);
			}
		}
		RepeaterDataBind();
		up_rp_Tratte.Update();
	}

	private void NumeroSubSpedizioni_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(((ListControl)NumeroSubSpedizioni).SelectedValue, "", false) != 0)
			{
				GeneraTratte(Conversions.ToInteger(((ListControl)NumeroSubSpedizioni).SelectedValue));
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

	protected void rp_Arrivo_Value_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			IIboWebComponent val3 = (IIboWebComponent)sender;
			Spedizione_Tratta spedizione_Tratta = _Tratte[checked(Conversions.ToInteger(val3.CustomTag) - 1)];
			spedizione_Tratta.Arrivo = val3.ObjValue.ToString();
			Spedizione_Tratta spedizione_Tratta2 = _Tratte[Conversions.ToInteger(val3.CustomTag)];
			spedizione_Tratta2.Partenza = spedizione_Tratta.Arrivo;
			RepeaterItem parent = rp_Tratte.Items[Conversions.ToInteger(val3.CustomTag)];
			IIboWebComponent val4 = (IIboWebComponent)GetControlByName((Control)(object)parent, "rp_Partenza_Value_ReadOnly");
			val4.ObjValue = TrascodificaPCS(spedizione_Tratta2.Partenza);
			getParentUpdatePanel((Control)val4).Update();
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

	private void rp_Tratte_ItemDataBound(object sender, RepeaterItemEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				Spedizione_Tratta spedizione_Tratta = (Spedizione_Tratta)e.Item.DataItem;
				IboWebComboTlk objCombo = (IboWebComboTlk)GetControlByName((Control)(object)e.Item, "rp_TipoServizio_value");
				IIboWebComponent val = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "rp_Partenza_Value_ReadOnly");
				IIboWebComponent val2 = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "rp_Arrivo_Value_ReadOnly");
				IboWebComboTlk objCombo2 = (IboWebComboTlk)GetControlByName((Control)(object)e.Item, "rp_Arrivo_Value");
				IIboWebComponent val3 = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "TrattaTitle");
				IboWebComboTlk objCombo3 = (IboWebComboTlk)GetControlByName((Control)(object)e.Item, "rp_Corrispondente_value");
				IIboWebComponent val4 = (IIboWebComponent)GetControlByName((Control)(object)e.Item, "rp_Corrispondente_Caption");
				IboWebDate2 iboWebDate = (IboWebDate2)(object)GetControlByName((Control)(object)e.Item, "rp_DataConsegna_value");
				string text = "(1=2";
				StringEnumerator enumerator = _TipiServiziSubSpedizioni.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					text = text + " OR Codice=" + base.DbConn.SQLFormatString(current) + " ";
				}
				text += ")";
				objCombo.SqlQueryFilter = text;
				if (_TipiServiziSubSpedizioni.Count == 1 && Operators.CompareString(spedizione_Tratta.TipoServizio, "", false) == 0)
				{
					spedizione_Tratta.TipoServizio = _TipiServiziSubSpedizioni[0];
				}
				string rsMess = "";
				LoadSingleCombo(ref objCombo, ref rsMess);
				rsMess = "";
				LoadSingleCombo(ref objCombo2, ref rsMess);
				IboWebComboTlk objCombo4 = objCombo2;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo4, "", ref rsMess);
				rsMess = "";
				LoadSingleCombo(ref objCombo3, ref rsMess);
				objCombo2.CustomTag = spedizione_Tratta.Sequenza.ToString();
				IboWebComboTlk objCombo5 = objCombo;
				string tipoServizio = spedizione_Tratta.TipoServizio;
				rsMess = "";
				ComboSelectedItem((IIboDropdownList)(object)objCombo5, tipoServizio, ref rsMess);
				val3.ObjValue = spedizione_Tratta.Descrizione;
				objCombo3.Visible = false;
				val4.Visible = false;
				iboWebDate.Enabled = true;
				if (Operators.CompareString(_SessionVariable["InsUpd"].ToString(), "M", false) == 0)
				{
					objCombo.ReadOnly = true;
				}
				if (Operators.CompareString(_SessionVariable["InsUpd"].ToString(), "M", false) == 0 && spedizione_Tratta.Sequenza < spedizione_Tratta.TotaleTratte)
				{
					IboWebComboTlk objCombo6 = objCombo2;
					string arrivo = spedizione_Tratta.Arrivo;
					rsMess = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo6, arrivo, ref rsMess);
					iboWebDate.DateValue2 = spedizione_Tratta.DataConsegna;
				}
				if (spedizione_Tratta.Sequenza == 1)
				{
					val.Visible = true;
					val.ObjValue = TrascodificaPCS(spedizione_Tratta.Partenza);
					val2.Visible = false;
					objCombo2.Visible = true;
				}
				else if (spedizione_Tratta.Sequenza < spedizione_Tratta.TotaleTratte)
				{
					val.Visible = true;
					Spedizione_Tratta spedizione_Tratta2 = _Tratte[spedizione_Tratta.Sequenza - 2];
					val.ObjValue = TrascodificaPCS(spedizione_Tratta2.Arrivo);
					val2.Visible = false;
					objCombo2.Visible = true;
				}
				else if (spedizione_Tratta.Sequenza == spedizione_Tratta.TotaleTratte)
				{
					val.Visible = true;
					Spedizione_Tratta spedizione_Tratta3 = _Tratte[spedizione_Tratta.Sequenza - 2];
					val.ObjValue = TrascodificaPCS(spedizione_Tratta3.Arrivo);
					val2.Visible = true;
					objCombo2.Visible = false;
					val2.ObjValue = TrascodificaPCS(spedizione_Tratta.Arrivo);
					objCombo3.Visible = true;
					val4.Visible = true;
					if (Operators.CompareString(((HiddenField)HF_Corrispondente).Value, "", false) != 0)
					{
						spedizione_Tratta.Corrispondente = ((HiddenField)HF_Corrispondente).Value;
						objCombo3.Enabled = false;
					}
					IboWebComboTlk objCombo7 = objCombo3;
					string corrispondente = spedizione_Tratta.Corrispondente;
					rsMess = "";
					ComboSelectedItem((IIboDropdownList)(object)objCombo7, corrispondente, ref rsMess);
					iboWebDate.Enabled = false;
					iboWebDate.DateValue2 = spedizione_Tratta.DataConsegna;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
