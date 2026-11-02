using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class TariffeTrasportoAttiveSpedizioniRaggruEngine : TariffeEngine
{
	public ShippingGroupedDocument GroupedDocument => (ShippingGroupedDocument)Document;

	public TariffeTrasportoAttiveSpedizioniRaggruEngine(AppApiContext objApiContext, string IdViaggio, string MaxUnibol)
		: base(objApiContext)
	{
		Document = new ShippingGroupedDocument();
		ShippingGroupedDocument shippingGroupedDocument = (ShippingGroupedDocument)Document;
		shippingGroupedDocument.Unibol = MaxUnibol;
		shippingGroupedDocument.IdViaggio = IdViaggio;
		DocLoader = new ActiveShippingGroupedDocumentLoader(objApiContext);
		DocLoader.Document = Document;
		_ViewTestataTariffa = "TAR_TariffeAttiveTestata";
		_ViewVociTariffa = "TAR_TariffeAttiveRaggruVoci";
		_ViewVociTariffaWhere = "Voce_Spedizione = 'S'";
		_ViewFasceTariffa = "TAR_TariffeAttiveFasce";
		_ViewSoggetto = "Clienti";
		_TableCostiRicaviKeyName = "Unibol";
		_TipoTariffaEngine = TipoTariffeEngine.Attiva;
		_Ricavi = new Spedizioni_Ricavi();
		_Costi = new Spedizioni_Costi();
		_TariffaRaggruppata = true;
	}

	protected override FXRETURN InitEngine(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = base.InitEngine(ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN CancellaCostiRicavi(CancellazioneCostiRicaviModalita Modalita, ref string rsmess)
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
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSave(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsmess = "";
			this.CallStackAdd();
			foreach (CostoRicavo ricavi in Document.RicaviList)
			{
				if (Operators.CompareString(ricavi.StatoRecord, "I", false) == 0)
				{
					ricavi.RecordZZ = "S";
					ricavi.TipoCalcolo = "RAG";
					if (Operators.CompareString(_dtContrattoTariffa.Rows[0]["IncludiMittente"].ToString(), "S", false) == 0)
					{
						ricavi.TipoCalcolo += "S";
					}
					else
					{
						ricavi.TipoCalcolo += "N";
					}
					ricavi.IdRaggruppamento = GroupedDocument.ID;
				}
			}
			foreach (CostoRicavo ricavi2 in Document.RicaviList)
			{
				if (Operators.CompareString(ricavi2.StatoRecord, "I", false) != 0)
				{
					continue;
				}
				foreach (ShippingDocument shippingDocument in GroupedDocument.ShippingDocuments)
				{
					CostoRicavo costoRicavo;
					if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
					{
						costoRicavo = new Ricavo();
						costoRicavo.Voce = ricavi2.Voce;
					}
					else
					{
						costoRicavo = new Costo();
						costoRicavo.Voce = ricavi2.Voce;
					}
					costoRicavo.IdDocumento = shippingDocument.ID;
					costoRicavo.CampoCalcolo = ricavi2.CampoCalcolo;
					costoRicavo.TipoCalcolo = ricavi2.TipoCalcolo;
					costoRicavo.RecordZZ = "N";
					decimal num;
					decimal num2;
					if (Operators.CompareString(ricavi2.TipoRipartizione, "N", false) == 0)
					{
						num = 1m;
						num2 = decimal.Divide(ricavi2.ImportoArrotondato, new decimal(GroupedDocument.ShippingDocuments.Count));
					}
					else
					{
						num = Conversions.ToDecimal(shippingDocument.ItemDataRow[ricavi2.CampoCalcolo]);
						num2 = decimal.Multiply(decimal.Divide(ricavi2.ImportoArrotondato, ricavi2.QuantitaOriginale), num);
					}
					if (decimal.Compare(num, 0m) > 0)
					{
						costoRicavo.QuantitaOriginale = num;
						costoRicavo.QuantitaArrotondata = num;
						costoRicavo.QuantitaTassata = num;
						costoRicavo.ImportoOriginale = num2;
						costoRicavo.ImportoArrotondato = num2;
						costoRicavo.ImportoUnitario = decimal.Divide(num2, num);
						costoRicavo.UtenteForzatura = "";
						costoRicavo.IdRaggruppamento = ricavi2.IdRaggruppamento;
						costoRicavo.NoteDiCalcolo = "";
						costoRicavo.IdFasceElenco = new int[0];
						costoRicavo.EstremiTariffa = ricavi2.EstremiTariffa;
						costoRicavo.FlagNolo = ricavi2.FlagNolo;
						shippingDocument.RicaviList.Add(costoRicavo);
					}
				}
			}
			foreach (CostoRicavo ricavi3 in Document.RicaviList)
			{
				text = "DELETE FROM " + Document.RicaviList.TableName + " ";
				text = text + "WHERE " + _TableCostiRicaviKeyName + " IN (" + GroupedDocument.SqlElencoUnibol + ") ";
				text = text + "AND Voce=" + ((AppBaseClass)this).DbConn.SQLFormatString(ricavi3.Voce) + " ";
				text += "AND UtenteForzatura IS NULL";
				SqlElencoSave.Add(text);
			}
			Ricavi[] array = new Ricavi[2]
			{
				new Spedizioni_Ricavi(),
				null
			};
			foreach (CostoRicavo ricavi4 in Document.RicaviList)
			{
				if (Operators.CompareString(ricavi4.StatoRecord, "I", false) == 0)
				{
					array[0].Add(ricavi4);
				}
			}
			array[1] = new Spedizioni_RicaviRipartiti();
			foreach (ShippingDocument shippingDocument2 in GroupedDocument.ShippingDocuments)
			{
				foreach (CostoRicavo ricavi5 in shippingDocument2.RicaviList)
				{
					array[1].Add(ricavi5);
				}
			}
			Ricavi[] array2 = array;
			for (int i = 0; i < array2.Length; i = checked(i + 1))
			{
				Spedizioni_Ricavi spedizioni_Ricavi = (Spedizioni_Ricavi)array2[i];
				foreach (Ricavo item in spedizioni_Ricavi)
				{
					text = "INSERT INTO " + array[0].TableName + " (";
					text = text + _TableCostiRicaviKeyName + ",Voce,RecordZZ,TipoCalcolo,CampoCalcolo,";
					text += "QuantitaOriginale,QuantitaArrotondata,QuantitaTassata,";
					text += "ImportoOriginale,ImportoArrotondato,ImportoUnitario,";
					text += "IdRaggruppamento,EstremiTariffa,Note,";
					text += "DatIns,UteIns,DatAgg,UteAgg) SELECT ";
					string text2 = "";
					text2 = ((Operators.CompareString(item.RecordZZ, "S", false) != 0) ? item.IdDocumento : item.IdRaggruppamento);
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.Voce) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.RecordZZ) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.TipoCalcolo) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.CampoCalcolo) + ", ";
					string text3 = text;
					DBConnection dbConn = ((AppBaseClass)this).DbConn;
					Ricavo ricavo2;
					decimal pNumero = (ricavo2 = item).QuantitaOriginale;
					string text4 = dbConn.SQLFormatNumber(ref pNumero);
					ricavo2.QuantitaOriginale = pNumero;
					text = text3 + text4 + ", ";
					string text5 = text;
					DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
					pNumero = (ricavo2 = item).QuantitaArrotondata;
					string text6 = dbConn2.SQLFormatNumber(ref pNumero);
					ricavo2.QuantitaArrotondata = pNumero;
					text = text5 + text6 + ", ";
					string text7 = text;
					DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
					pNumero = (ricavo2 = item).QuantitaTassata;
					string text8 = dbConn3.SQLFormatNumber(ref pNumero);
					ricavo2.QuantitaTassata = pNumero;
					text = text7 + text8 + ", ";
					string text9 = text;
					DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
					pNumero = (ricavo2 = item).ImportoOriginale;
					string text10 = dbConn4.SQLFormatNumber(ref pNumero);
					ricavo2.ImportoOriginale = pNumero;
					text = text9 + text10 + ", ";
					string text11 = text;
					DBConnection dbConn5 = ((AppBaseClass)this).DbConn;
					pNumero = ArrotondaValore(item.ImportoArrotondato, _Arrotondamento);
					text = text11 + dbConn5.SQLFormatNumber(ref pNumero) + ", ";
					string text12 = text;
					DBConnection dbConn6 = ((AppBaseClass)this).DbConn;
					pNumero = (ricavo2 = item).ImportoUnitario;
					string text13 = dbConn6.SQLFormatNumber(ref pNumero);
					ricavo2.ImportoUnitario = pNumero;
					text = text12 + text13 + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.IdRaggruppamento) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(item.EstremiTariffa) + ", ";
					text = ((((AppBaseClass)this).DbConn.ServerType != 0) ? ((((AppBaseClass)this).DbConn.ServerType != DBFormatFunctions.eServerType.Oracle) ? (text + Strings.Replace(((AppBaseClass)this).DbConn.SQLFormatString(Strings.Left(item.NoteDiCalcolo, 512)), "\r\n", "' +CHAR(13)+CHAR(10)+ '", 1, -1, (CompareMethod)0) + ", ") : (text + Strings.Replace(((AppBaseClass)this).DbConn.SQLFormatString(Strings.Left(item.NoteDiCalcolo, 512)), "\r\n", "' || CHR(13) || CHR(10) || '", 1, -1, (CompareMethod)0) + ", ")) : (text + Strings.Replace(((AppBaseClass)this).DbConn.SQLFormatString(Strings.Left(item.NoteDiCalcolo, 512)), "\r\n", "' +CHAR(13)+CHAR(10)+ '", 1, -1, (CompareMethod)0) + ", "));
					text = text + "GETDATE(), " + this.DbConn.SQLFormatString(this._User) + ", ";
					text = text + "GETDATE(), " + this.DbConn.SQLFormatString(this._User) + " ";
					text = text + ((AppBaseClass)this).DbConn.FromDual() + " ";
					text = text + "WHERE NOT EXISTS (SELECT 1 FROM " + array[0].TableName + " WHERE " + _TableCostiRicaviKeyName + "=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
					text = text + "AND Voce=" + ((AppBaseClass)this).DbConn.SQLFormatString(item.Voce) + " ";
					text = text + "AND RecordZZ=" + ((AppBaseClass)this).DbConn.SQLFormatString(item.RecordZZ) + ") ";
					SqlElencoSave.Add(text);
				}
			}
			foreach (ShippingDocument shippingDocument3 in GroupedDocument.ShippingDocuments)
			{
				text = "UPDATE " + Document.DocumentTable + " SET IdRaggruppamentoAttivo=<%ID_RAGGRU%> ";
				text = text + "WHERE " + Document.KeyFieldName + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(shippingDocument3.ID) + " ";
				text = ((array[0].Count <= 0) ? Strings.Replace(text, "<%ID_RAGGRU%>", "NULL", 1, -1, (CompareMethod)0) : Strings.Replace(text, "<%ID_RAGGRU%>", ((AppBaseClass)this).DbConn.SQLFormatString(GroupedDocument.Unibol), 1, -1, (CompareMethod)0));
				SqlElencoSave.Add(text);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN OnCalcExit(FXRETURN CalcResult, string ErrorMessage, string WarningMessage, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsmess = "";
			this.CallStackAdd();
			val2 = base.OnCalcExit(CalcResult, ErrorMessage, WarningMessage, ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}
}
