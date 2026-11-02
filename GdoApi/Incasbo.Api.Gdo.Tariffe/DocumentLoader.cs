using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class DocumentLoader : AppBaseClass
{
	public TransportDocument Document { get; set; }

	public DocumentLoader(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public virtual FXRETURN Load(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = _SetDocument(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = _Load(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = _AfterLoad(ref rsmess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN _Load(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dtDoc = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(Document.DocumentView, "", false) != 0)
			{
				text = "SELECT * FROM " + Document.DocumentView + " WHERE ID=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dtDoc, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (dtDoc.Rows.Count != 0)
					{
						goto IL_00f7;
					}
					rsmess = this.TranslateMessage("XXX", "Il documento con ID '{0}' non è stato trovato", new string[1] { Document.ID });
					val2 = (FXRETURN)14;
				}
			}
			else
			{
				val = _CustomLoad(ref dtDoc, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_00f7;
				}
				val2 = val;
			}
			goto end_IL_000e;
			IL_00f7:
			if (dtDoc == null)
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile caricare il documento da calcolare");
			}
			else
			{
				Document.ItemDataTable = dtDoc;
				Document.TipoDocumento = Document.ItemDataRow["TipoDocumento"].ToString();
				Document.SoggettoAttivo = Document.ItemDataRow["SoggettoAttivo"].ToString();
				Document.SoggettoFatturazioneAttiva = Document.ItemDataRow["SoggettoFatturazioneAttiva"].ToString();
				Document.SoggettoPassivo = Document.ItemDataRow["SoggettoPassivo"].ToString();
				Document.SoggettoFatturazionePassiva = Document.ItemDataRow["SoggettoFatturazionePassiva"].ToString();
				if (Document.ItemDataRow.Table.Columns.Contains("Mittente"))
				{
					Document.Mittente = Document.ItemDataRow["Mittente"].ToString();
				}
				else
				{
					Document.Mittente = "";
				}
				Document.ID = Document.ItemDataRow["ID"].ToString();
				Document.DataDocumento = Conversions.ToDate(Document.ItemDataRow["DataDocumento"]);
				Document.TipoSpedizioneAttivo = Document.ItemDataRow["TipoSpedizioneAttivo"].ToString();
				Document.TipoSpedizionePassivo = Document.ItemDataRow["TipoSpedizionePassivo"].ToString();
				Document.TipoMerce = Document.ItemDataRow["TipoMerce"].ToString();
				Document.TipoMezzo = Document.ItemDataRow["TipoMezzo"].ToString();
				Document.ZonaArrivoAttiva = Document.ItemDataRow["ZonaArrivoAttiva"].ToString();
				Document.ZonaArrivoAttivaMacro = Document.ItemDataRow["ZonaArrivoAttivaMacro"].ToString();
				if (Operators.CompareString(Document.ZonaArrivoAttivaMacro, "", false) == 0)
				{
					Document.ZonaArrivoAttivaMacro = "*ALL";
				}
				Document.ZonaArrivoPassiva = Document.ItemDataRow["ZonaArrivoPassiva"].ToString();
				Document.ZonaArrivoPassivaMacro = Document.ItemDataRow["ZonaArrivoPassivaMacro"].ToString();
				if (Operators.CompareString(Document.ZonaArrivoPassivaMacro, "", false) == 0)
				{
					Document.ZonaArrivoPassivaMacro = "*ALL";
				}
				Document.PCSPartenza = Document.ItemDataRow["PCSPartenza"].ToString();
				Document.GruppoTariffarioPartenza = Document.ItemDataRow["GruppoTariffarioPartenza"].ToString();
				if (Operators.CompareString(Document.GruppoTariffarioPartenza, "", false) == 0)
				{
					Document.GruppoTariffarioPartenza = "*ALL";
				}
				Document.PCSArrivo = Document.ItemDataRow["PCSArrivo"].ToString();
				Document.GruppoTariffarioArrivo = Document.ItemDataRow["GruppoTariffarioArrivo"].ToString();
				if (Operators.CompareString(Document.GruppoTariffarioArrivo, "", false) == 0)
				{
					Document.GruppoTariffarioArrivo = "*ALL";
				}
				Document.Cliente = Document.ItemDataRow["Cliente"].ToString();
				if (Operators.CompareString(Document.Cliente, "", false) == 0)
				{
					Document.Cliente = "*ALL";
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Document.ItemDataRow["DataCompetenzaAttiva"])))
				{
					try
					{
						if (Operators.CompareString(Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString(), "", false) != 0 && Information.IsDate(RuntimeHelpers.GetObjectValue(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString()])))
						{
							Document.DataCompentenzaAttiva = Conversions.ToDate(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString()]);
							Document.UpdateDataCompentenzaAttiva = true;
						}
						else
						{
							Document.DataCompentenzaAttiva = Document.DataDocumento;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Document.DataCompentenzaAttiva = Document.DataDocumento;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					Document.DataCompentenzaAttiva = Conversions.ToDate(Document.ItemDataRow["DataCompetenzaAttiva"]);
					if (Operators.CompareString(Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString(), "", false) != 0 && Information.IsDate(RuntimeHelpers.GetObjectValue(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString()])))
					{
						DateTime dateTime = Conversions.ToDate(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaAttiva"].ToString()]);
						DateTime t = dateTime;
						DateTime? dataCompentenzaAttiva = Document.DataCompentenzaAttiva;
						if ((dataCompentenzaAttiva.HasValue ? new bool?(DateTime.Compare(t, dataCompentenzaAttiva.GetValueOrDefault()) != 0) : null).GetValueOrDefault())
						{
							Document.DataCompentenzaAttiva = dateTime;
							Document.UpdateDataCompentenzaAttiva = true;
						}
					}
				}
				Document.DataCompentenzaAttiva = Document.DataCompentenzaAttiva.Value.Date;
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Document.ItemDataRow["DataCompetenzaPassiva"])))
				{
					try
					{
						if (Operators.CompareString(Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString(), "", false) != 0 && Information.IsDate(RuntimeHelpers.GetObjectValue(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString()])))
						{
							Document.DataCompentenzaPassiva = Conversions.ToDate(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString()]);
							Document.UpdateDataCompentenzaPassiva = true;
						}
						else
						{
							Document.DataCompentenzaPassiva = Document.DataDocumento;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Document.DataCompentenzaPassiva = Document.DataDocumento;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					Document.DataCompentenzaPassiva = Conversions.ToDate(Document.ItemDataRow["DataCompetenzaPassiva"]);
					if (Operators.CompareString(Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString(), "", false) != 0 && Information.IsDate(RuntimeHelpers.GetObjectValue(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString()])))
					{
						DateTime dateTime2 = Conversions.ToDate(Document.ItemDataRow[Document.ItemDataRow["CampoDataCompetenzaPassiva"].ToString()]);
						DateTime t = dateTime2;
						DateTime? dataCompentenzaAttiva = Document.DataCompentenzaPassiva;
						if ((dataCompentenzaAttiva.HasValue ? new bool?(DateTime.Compare(t, dataCompentenzaAttiva.GetValueOrDefault()) != 0) : null).GetValueOrDefault())
						{
							Document.DataCompentenzaPassiva = dateTime2;
							Document.UpdateDataCompentenzaPassiva = true;
						}
					}
				}
				Document.DataCompentenzaPassiva = Document.DataCompentenzaPassiva.Value.Date;
				Document.Peso = Conversions.ToDecimal(Document.ItemDataRow["Peso"]);
				Document.Colli = new decimal(Conversions.ToInteger(Document.ItemDataRow["Colli"]));
				Document.Pallet = new decimal(Conversions.ToInteger(Document.ItemDataRow["Pallet"]));
				Document.Volume = Conversions.ToDecimal(Document.ItemDataRow["Volume"]);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Document.ItemDataRow["TassatoAttivo"])))
				{
					Document.TassatoAttivo = 0m;
				}
				else
				{
					Document.TassatoAttivo = Conversions.ToDecimal(Document.ItemDataRow["TassatoAttivo"]);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(Document.ItemDataRow["TassatoPassivo"])))
				{
					Document.TassatoPassivo = 0m;
				}
				else
				{
					Document.TassatoPassivo = Conversions.ToDecimal(Document.ItemDataRow["TassatoPassivo"]);
				}
				Document.Contrassegno = Conversions.ToDecimal(Document.ItemDataRow["Contrassegno"]);
				Document.CampoCalcolo1 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo1"]);
				Document.CampoCalcolo2 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo2"]);
				Document.CampoCalcolo3 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo3"]);
				Document.CampoCalcolo4 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo4"]);
				Document.CampoCalcolo5 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo5"]);
				Document.CampoCalcolo6 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo6"]);
				Document.CampoCalcolo7 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo7"]);
				Document.CampoCalcolo8 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo8"]);
				Document.CampoCalcolo9 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo9"]);
				Document.CampoCalcolo10 = Conversions.ToDecimal(Document.ItemDataRow["CampoCalcolo10"]);
				Document.Forfait = Conversions.ToDecimal(Document.ItemDataRow["Forfait"]);
				Document.CalcolaTariffaAttiva = Operators.CompareString(Document.ItemDataRow["CalcolaTariffaAttiva"].ToString(), "S", false) == 0;
				Document.CalcolaTariffaPassiva = Operators.CompareString(Document.ItemDataRow["CalcolaTariffaPassiva"].ToString(), "S", false) == 0;
				DataRow itemDataRow = Document.ItemDataRow;
				if (modGeneral.ExistsFieldInDatarow2(ref itemDataRow, "CancellaCosti"))
				{
					Document.CancellaCosti = Operators.CompareString(Document.ItemDataRow["CancellaCosti"].ToString(), "S", false) == 0;
				}
				else
				{
					Document.CancellaCosti = false;
				}
				itemDataRow = Document.ItemDataRow;
				if (modGeneral.ExistsFieldInDatarow2(ref itemDataRow, "CancellaRicavi"))
				{
					Document.CancellaRicavi = Operators.CompareString(Document.ItemDataRow["CancellaRicavi"].ToString(), "S", false) == 0;
				}
				else
				{
					Document.CancellaRicavi = false;
				}
				itemDataRow = Document.ItemDataRow;
				if (modGeneral.ExistsFieldInDatarow2(ref itemDataRow, "AbilitaRaggruppamento"))
				{
					Document.AbilitaRaggruppamento = Operators.CompareString(Document.ItemDataRow["AbilitaRaggruppamento"].ToString(), "S", false) == 0;
				}
				itemDataRow = Document.ItemDataRow;
				if (modGeneral.ExistsFieldInDatarow2(ref itemDataRow, "DurataServizio") && Operators.CompareString(Document.ItemDataRow["DurataServizio"].ToString(), "", false) != 0)
				{
					Document.DurataServizio = Conversions.ToInteger(Document.ItemDataRow["DurataServizio"]);
				}
				val2 = (FXRETURN)0;
			}
			end_IL_000e:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			val2 = this.HandleError(ref ex6, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN _CustomLoad(ref DataTable dtDoc, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN _AfterLoad(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected abstract FXRETURN _SetDocument(ref string rsmess);
}
