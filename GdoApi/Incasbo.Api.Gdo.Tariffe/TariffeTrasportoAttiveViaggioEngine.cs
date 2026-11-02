using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class TariffeTrasportoAttiveViaggioEngine : TariffeEngine
{
	public TariffeTrasportoAttiveViaggioEngine(AppApiContext objApiContext, string IdViaggio)
		: base(objApiContext)
	{
		Document = new TourDocument();
		Document.ID = IdViaggio;
		DocLoader = new ActiveTourDocumentLoader(objApiContext);
		DocLoader.Document = Document;
		_ViewTestataTariffa = "TAR_TariffeAttiveTestata";
		_ViewVociTariffa = "TAR_TariffeAttiveVoci";
		_ViewVociTariffaWhere = "Voce_Viaggio = 'S'";
		_ViewFasceTariffa = "TAR_TariffeAttiveFasce";
		_ViewSoggetto = "Clienti";
		_TableCostiRicaviKeyName = "IdViaggio";
		_TipoTariffaEngine = TipoTariffeEngine.Attiva;
	}

	protected override FXRETURN InitEngine(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
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
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "DELETE FROM Viaggi_Ricavi WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + " ";
			switch (Modalita)
			{
			case CancellazioneCostiRicaviModalita.SoloCalcolati:
				text += " AND TipoCalcolo<>'MAN'";
				break;
			case CancellazioneCostiRicaviModalita.AssenzaDelSoggetto:
				text += " AND TipoCalcolo<>'MAN'";
				text = text + "(SELECT BloccaRicavi FROM Viaggi WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ")='N' AND ";
				text = text + "(SELECT IdFatturaAttiva FROM Viaggi WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ") IS NULL";
				break;
			}
			text += ";UPDATE VIAGGI SET TipoContrattoAttivoApplicato='N', ";
			text += "ErroreTariffaAttiva=NULL ";
			text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID) + ";";
			if (TransactionManage && !((AppBaseClass)this).DbConn.TransactionOpen)
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
				text = "UPDATE VIAGGI SET ERRORETARIFFAATTIVA=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
				text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID);
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
