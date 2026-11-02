using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class GMB_MovimentoCancella : GdoAbstractApi
{
	protected string _idMovimento;

	protected DataTable _dtMovimento;

	protected GMB_Movimento _GMB_Movimento;

	public GMB_MovimentoCancella(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_idMovimento = "";
		_dtMovimento = null;
		_GMB_Movimento = new GMB_Movimento();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_idMovimento = ((AppAbstractApi)this).ParametersIn["IDMovimento"].ToString();
			val = CheckMovimento(ref rsmess);
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Invalid comparison between Unknown and I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "DELETE FROM BancaliMovimenti WHERE Id=" + _idMovimento + "; ";
			string QueryToApply = "";
			val = GiacenzaAggiorna(_dtMovimento.Rows[0]["TipoSoggetto1"].ToString(), _dtMovimento.Rows[0]["Soggetto1"].ToString(), _dtMovimento.Rows[0]["Segno1"].ToString(), _dtMovimento.Rows[0]["TipoBancale"].ToString(), _dtMovimento.Rows[0]["Cliente"].ToString(), Conversions.ToInteger(_dtMovimento.Rows[0]["Quantita"]), ref QueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += QueryToApply;
				QueryToApply = "";
				val = GiacenzaAggiorna(_dtMovimento.Rows[0]["TipoSoggetto2"].ToString(), _dtMovimento.Rows[0]["Soggetto2"].ToString(), _dtMovimento.Rows[0]["Segno2"].ToString(), _dtMovimento.Rows[0]["TipoBancale"].ToString(), _dtMovimento.Rows[0]["Cliente"].ToString(), Conversions.ToInteger(_dtMovimento.Rows[0]["Quantita"]), ref QueryToApply, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += QueryToApply;
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
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

	protected FXRETURN CheckMovimento(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause = "SELECT * FROM BancaliMovimenti WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_idMovimento);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtMovimento, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtMovimento.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Movimento non trovato");
			}
			else
			{
				val = CreaStrutturaMovimento(_dtMovimento.Rows[0], ref rsmess);
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

	protected FXRETURN GiacenzaAggiorna(string TipoSoggetto, string Soggetto, string Segno, string TipoBancale, string Cliente, int Quantita, ref string QueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			QueryToApply = "";
			if ((Operators.CompareString(TipoSoggetto, "", false) != 0) & (Operators.CompareString(Soggetto, "", false) != 0) & (Operators.CompareString(Segno, "", false) != 0))
			{
				Segno = ((Operators.CompareString(Segno, "+", false) != 0) ? "+" : "-");
				text = "UPDATE BancaliGiacenze ";
				text = text + "SET Giacenza=Giacenza " + Segno + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref Quantita) + ", ";
				text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + " ";
				text = text + "WHERE TipoSoggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(TipoSoggetto) + " ";
				text = text + "AND Soggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(Soggetto) + " ";
				text = text + "AND TipoBancale=" + ((AppBaseClass)this).DbConn.SQLFormatString(TipoBancale) + " ";
				text = text + "AND Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(Cliente) + "; ";
			}
			QueryToApply += text;
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

	protected FXRETURN MovimentoCancella(ref string QueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			QueryToApply = "";
			string text = "DELETE FROM BancaliMovimenti ";
			QueryToApply = text;
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

	protected FXRETURN CreaStrutturaMovimento(DataRow drMovimento, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			GMB_Movimento gMB_Movimento = new GMB_Movimento();
			gMB_Movimento.Id = _idMovimento;
			gMB_Movimento.Data = Conversions.ToDate(drMovimento["Data"]);
			gMB_Movimento.Causale = drMovimento["Causale"].ToString();
			gMB_Movimento.TipoSoggetto1 = ConvertTipoSoggettoFromString(drMovimento["TipoSoggetto1"].ToString());
			gMB_Movimento.Soggetto1 = drMovimento["Soggetto1"].ToString();
			gMB_Movimento.Segno1 = ConvertSegnoFromString(drMovimento["Segno1"].ToString());
			gMB_Movimento.TipoSoggetto2 = ConvertTipoSoggettoFromString(drMovimento["TipoSoggetto2"].ToString());
			gMB_Movimento.Soggetto2 = drMovimento["Soggetto2"].ToString();
			gMB_Movimento.Segno2 = ConvertSegnoFromString(drMovimento["Segno2"].ToString());
			gMB_Movimento.TipoBancale = drMovimento["TipoBancale"].ToString();
			gMB_Movimento.Quantita = Conversions.ToInteger(drMovimento["Quantita"]);
			gMB_Movimento.Cliente = drMovimento["Cliente"].ToString();
			_GMB_Movimento = gMB_Movimento;
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

	protected GMB_TipoSoggetto ConvertTipoSoggettoFromString(string ts)
	{
		GMB_TipoSoggetto result = GMB_TipoSoggetto.NotDefined;
		switch (ts)
		{
		case "C":
			result = GMB_TipoSoggetto.Cliente;
			break;
		case "H":
			result = GMB_TipoSoggetto.Corrispondente;
			break;
		case "D":
			result = GMB_TipoSoggetto.Destinatario;
			break;
		case "F":
			result = GMB_TipoSoggetto.Filiale;
			break;
		case "V":
			result = GMB_TipoSoggetto.Vettore;
			break;
		}
		return result;
	}

	protected GMB_Segno ConvertSegnoFromString(string ts)
	{
		GMB_Segno result = GMB_Segno.NotDefined;
		if (Operators.CompareString(ts, "-", false) != 0)
		{
			if (Operators.CompareString(ts, "+", false) == 0)
			{
				result = GMB_Segno.Plus;
			}
		}
		else
		{
			result = GMB_Segno.Minus;
		}
		return result;
	}
}
