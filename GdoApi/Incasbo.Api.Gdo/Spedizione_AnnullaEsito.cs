using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_AnnullaEsito : AppAbstractApi
{
	protected string _Unibol;

	protected string _IdViaggio;

	protected DataTable _dtSpedizione;

	protected DataTable _dtViaggio;

	public Spedizione_AnnullaEsito(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_IdViaggio = "";
		_dtSpedizione = null;
		_dtViaggio = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckViaggio(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string sQuery = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = AnnullaEsitoUds(ref sQuery, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += sQuery;
				val = AggiornaSpedizione(ref sQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += sQuery;
					val = AggiornaViaggio(ref sQuery, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += sQuery;
						val = GestionePraticheAssociate(ref sQuery, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							text += sQuery;
							if (Operators.CompareString(text, "", false) == 0)
							{
								goto IL_00e5;
							}
							val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
							if ((int)val <= 0)
							{
								goto IL_00e5;
							}
							val2 = val;
						}
					}
				}
			}
			goto end_IL_0012;
			IL_00e5:
			val2 = (FXRETURN)0;
			end_IL_0012:;
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.Stato, S.UnibolSpedizioneCompleta, S.CountOfSubSpedizioni, S.Corrispondente, S.IdFatturaAttiva, S.IdFatturaPassiva, S.IdViaggio, S.IdGiacenza, S.Unibol ";
			text += "FROM VW_Spedizioni S INNER JOIN TipiServizi TS ON TS.Codice=S.TipoServizio ";
			text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND S.Stato < 90";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non è presente a sistema", new string[1] { _Unibol });
			}
			else
			{
				int num = Conversions.ToInteger(_dtSpedizione.Rows[0]["STATO"]);
				if (num < 50)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta in stato esitato", new string[1] { _Unibol });
				}
				else if (num >= 60)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già certificata", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdFatturaAttiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già presente in una fattura attiva", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdFatturaPassiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già presente in una fattura passiva", new string[1] { _Unibol });
				}
				else
				{
					_IdViaggio = _dtSpedizione.Rows[0]["IdViaggio"].ToString();
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT V.Stato, V.IdFatturaAttiva, V.IdFatturaPassiva, V.IdViaggio ";
			text += "FROM Viaggi V ";
			text = text + "WHERE IdViaggio = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id={0} non è presente a sistema", new string[1] { _IdViaggio });
			}
			else
			{
				int num = Conversions.ToInteger(_dtViaggio.Rows[0]["STATO"]);
				if (num < 40)
				{
					rsmess = this.TranslateMessage("XXX", "Il viaggio con Id={0}, a cui appartiene la spedizione, non risulta partito", new string[1] { _IdViaggio });
				}
				else if (num >= 50)
				{
					rsmess = this.TranslateMessage("XXX", "Il viaggio con Id={0}, a cui appartiene la spedizione, risulta già certificato", new string[1] { _IdViaggio });
				}
				else if (Operators.CompareString(_dtViaggio.Rows[0]["IdFatturaAttiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il viaggio con Id={0}, a cui appartiene la spedizione, risulta già presente in una fattura attiva", new string[1] { _IdViaggio });
				}
				else if (Operators.CompareString(_dtViaggio.Rows[0]["IdFatturaPassiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Il viaggio con Id={0}, a cui appartiene la spedizione, risulta già presente in una fattura passiva", new string[1] { _IdViaggio });
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

	protected virtual FXRETURN AnnullaEsitoUds(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "";
			text = "UPDATE SpedizioniUds SET Esito=NULL, ";
			text += "DataEsito=NULL ";
			text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			sQuery = text;
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

	protected virtual FXRETURN AggiornaSpedizione(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "";
			text = "UPDATE Spedizioni SET Stato=CASE WHEN Corrispondente IS NOT NULL THEN 48 ELSE 40 END, ";
			text += "DataOraArrivoEffettiva = NULL, ";
			text += "DataOraPartenzaEffettiva = NULL, ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			sQuery = text;
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

	protected virtual FXRETURN AggiornaViaggio(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "";
			if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) == 40)
			{
				text = "UPDATE Viaggi SET Stato=30, DatAgg=%GETDATE%, UteAgg=" + this.DbConn.SQLFormatString(this._User) + " WHERE IdViaggio=" + this.DbConn.SQLFormatString(_IdViaggio) + ";";
				text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			}
			sQuery = text;
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

	protected virtual FXRETURN GestionePraticheAssociate(ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "";
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
}
