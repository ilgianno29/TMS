using System;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveCalcoloIva : AppAbstractApi
{
	protected long _IdFattura;

	public FattureAttiveCalcoloIva(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["IdFattura"].ToString(), "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Obbligatorio inserire IdFattura");
			}
			else
			{
				_IdFattura = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["IdFattura"]));
				text = "SELECT COUNT(*) FROM Fatture_Attive_Testata WHERE IDFATTURA = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (Conversions.ToInteger(objRes) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Fattura {0} non trovata", new string[1] { Conversions.ToString(_IdFattura) });
				}
				else
				{
					val2 = (FXRETURN)0;
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "DELETE FROM Fatture_Attive_Iva WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ";";
			text += "INSERT INTO Fatture_Attive_Iva (IdFattura, CodiceIva, Imponibile, Aliquota, Imposta, UteIns, DatIns, UteAgg, DatAgg) ";
			text += "SELECT IdFattura, CodiceIva, Imponibile, I.PercentualeIva, Round(I.PercentualeIva * (Imponibile / 100.0000), 2), ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", GETDATE(), ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", GETDATE() ";
			text += "FROM ";
			text += "(SELECT IdFattura, FAD.CodiceIva, SUM(ImportoArrotondato) AS Imponibile ";
			text = text + "FROM Fatture_Attive_Dettaglio FAD INNER JOIN VOCI V ON FAD.VOCE = V.CODICE WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + " ";
			text += "AND ((RECORDZZ='N' AND TipoCalcolo in ('STD','MAN')) OR (RECORDZZ='S')) ";
			text += "GROUP BY IdFattura, FAD.CodiceIva) F ";
			text += "INNER JOIN CodiciIva I ON F.CodiceIva = I.Codice AND I.Attivo = 'S'";
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
}
