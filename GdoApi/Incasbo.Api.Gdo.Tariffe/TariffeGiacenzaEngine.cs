using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class TariffeGiacenzaEngine : TariffeEngine
{
	public TariffeGiacenzaEngine(AppApiContext objApiContext, string IdGiacenza)
		: base(objApiContext)
	{
		Document = new StockDocument();
		Document.ID = IdGiacenza;
		_NoloRequired = false;
		_Ricavi = new Giacenze_Ricavi();
		_Costi = new Giacenze_Costi();
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

	protected override FXRETURN InitialUpdate(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			decimal num = default(decimal);
			if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
			{
				num = Conversions.ToDecimal(Document.ItemDataRow["TassatoAttivo"]);
			}
			else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
			{
				num = Conversions.ToDecimal(Document.ItemDataRow["TassatoPassivo"]);
			}
			if (Operators.CompareString(Document.DocumentTable, "", false) != 0)
			{
				text = "UPDATE " + Document.DocumentTable + " ";
				if (_TipoTariffaEngine == TipoTariffeEngine.Attiva)
				{
					text = text + "SET TipoContrattoAttivoApplicato=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContrattoApplicato) + " ";
					text += ",ErroreTariffaAttiva=NULL ";
				}
				else if (_TipoTariffaEngine == TipoTariffeEngine.Passiva)
				{
					text = text + "SET TipoContrattoPassivoApplicato=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContrattoApplicato) + " ";
					text += ",ErroreTariffaPassiva=NULL ";
				}
				if (Document.UpdateDataCompentenzaAttiva && Document.DataCompentenzaAttiva.HasValue)
				{
					text = text + ",DataCompetenzaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Document.DataCompentenzaAttiva.Value);
				}
				if (Document.UpdateDataCompentenzaPassiva && Document.DataCompentenzaPassiva.HasValue)
				{
					text = text + ",DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Document.DataCompentenzaPassiva.Value);
				}
				text = text + " WHERE " + Document.KeyFieldName + " = " + ((AppBaseClass)this).DbConn.SQLFormatString(Document.ID);
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
}
