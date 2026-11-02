using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class TariffeTrasportoPassiveSpedizioniEngine : TariffeEngine
{
	public TariffeTrasportoPassiveSpedizioniEngine(AppApiContext objApiContext, string Unibol)
		: base(objApiContext)
	{
		Document = new ShippingDocument();
		Document.ID = Unibol;
		DocLoader = new PassiveShippingDocumentLoader(objApiContext);
		DocLoader.Document = Document;
		_ViewTestataTariffa = "TAR_TariffePassiveTestata";
		_ViewVociTariffa = "TAR_TariffePassiveVoci";
		_ViewVociTariffaWhere = "Voce_Spedizione = 'S'";
		_ViewFasceTariffa = "TAR_TariffePassiveFasce";
		_ViewSoggetto = "Trasportatori";
		_TableCostiRicaviKeyName = "Unibol";
		_TipoTariffaEngine = TipoTariffeEngine.Passiva;
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
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between Unknown and I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "DELETE FROM Spedizioni_Costi WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + " ";
			switch (Modalita)
			{
			case CancellazioneCostiRicaviModalita.SoloCalcolati:
				text += " AND TipoCalcolo NOT IN ('MAN', 'VET') ";
				break;
			case CancellazioneCostiRicaviModalita.AssenzaDelSoggetto:
				text += " AND TipoCalcolo NOT IN ('MAN', 'VET') AND ";
				text = text + "(SELECT BloccaCosti FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ")='N' AND ";
				text = text + "(SELECT IdFatturaPassiva FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ") IS NULL";
				break;
			}
			text += ";UPDATE SPEDIZIONI SET TipoContrattoPassivoApplicato='N', ";
			if (Modalita == CancellazioneCostiRicaviModalita.AssenzaDelSoggetto)
			{
				text += "DataCompetenzaPassiva=NULL, ";
			}
			else
			{
				string text2 = "DataBolla";
				DateTime? dateTime = null;
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSoggetto.Rows[0]["DataPerFatturazione"])))
				{
					text2 = _dtSoggetto.Rows[0]["DataPerFatturazione"].ToString();
				}
				DataRow itemDataRow = Document.ItemDataRow;
				if (modGeneral.ExistsFieldInDatarow(ref itemDataRow, text2) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(Document.ItemDataRow[text2])))
				{
					dateTime = Conversions.ToDate(Document.ItemDataRow[text2]);
				}
				if (dateTime.HasValue)
				{
					text = text + "DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, dateTime.Value) + ", ";
				}
			}
			text += "ErroreTariffaPassiva=NULL ";
			text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ";";
			if (TransactionManage)
			{
				((AppBaseClass)this).DbConn.BeginTransaction();
				flag = true;
			}
			val2 = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (flag)
				{
					((AppBaseClass)this).DbConn.CommitTransaction();
				}
				val = (FXRETURN)0;
			}
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
			if (flag)
			{
				((AppBaseClass)this).DbConn.RollbackTransaction();
			}
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSave(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				CostiRicavi ricavi = _Ricavi;
			}
			else
			{
				CostiRicavi ricavi = _Costi;
			}
			val2 = base.BeforeSave(ref rsmess);
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

	protected override FXRETURN OnCalcExit(FXRETURN CalcResult, string ErrorMessage, string WarningMessage, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			string text2 = "";
			if (Operators.CompareString(ErrorMessage, "", false) != 0)
			{
				text2 = ErrorMessage;
			}
			else if (Operators.CompareString(WarningMessage, "", false) != 0)
			{
				text2 = WarningMessage;
			}
			text2 = text2.Trim();
			if (Operators.CompareString(text2, "", false) != 0)
			{
				text = "UPDATE SPEDIZIONI SET ERRORETARIFFAPASSIVA=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
				text = text + "WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID);
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				string vsSQLClause = text;
				string rsMess = "";
				dbConn.SqlExec(vsSQLClause, ref rsMess);
			}
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
