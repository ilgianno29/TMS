using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class GMB_MovimentoInserisci : GdoAbstractApi
{
	protected GMB_Documento _GMBDocumento;

	protected List<GMB_Movimento> _GMBMovimenti;

	protected DataTable _dtCausale;

	public GMB_MovimentoInserisci(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_GMBMovimenti = new List<GMB_Movimento>();
		_dtCausale = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_GMBDocumento = (GMB_Documento)((AppAbstractApi)this).ParametersIn["GMB_Documento"];
			val = CheckDocumento(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("GMB_Movimenti", null);
				val2 = (FXRETURN)0;
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
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreaStrutturaMovimenti(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "";
				foreach (GMB_Movimento item in _GMBMovimenti)
				{
					string QueryToApply = "";
					val = MovimentoInserisci(item, ref QueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += QueryToApply;
						QueryToApply = "";
						val = GiacenzaAggiorna(item, ref QueryToApply, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							text += QueryToApply;
							QueryToApply = "";
							val = GMB_AggiornaMovimentazioneBancaliPerData.RunProc(this._ApiContext, item, ref QueryToApply, ref rsmess);
							if ((int)val <= 0)
							{
								text += QueryToApply;
								continue;
							}
							val2 = val;
						}
					}
					goto end_IL_000b;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					((AppAbstractApi)this).ParametersOut["GMB_Movimenti"] = _GMBMovimenti;
					val2 = (FXRETURN)0;
				}
			}
			end_IL_000b:;
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

	protected FXRETURN CheckDocumento(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Invalid comparison between Unknown and I4
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Invalid comparison between Unknown and I4
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Invalid comparison between Unknown and I4
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause;
			if (Operators.CompareString(_GMBDocumento.Causale, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Causale del movimento non definita");
			}
			else if (!_GMBDocumento.Data.HasValue)
			{
				rsmess = this.TranslateMessage("XXX", "Data del movimento non definita");
			}
			else
			{
				vsSQLClause = "SELECT * FROM BancaliCausali WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GMBDocumento.Causale);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtCausale, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (_dtCausale.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "La Causale '{0}' non esiste", new string[1] { _GMBDocumento.Causale });
				}
				else if (Operators.CompareString(_dtCausale.Rows[0]["Attivo"].ToString(), "S", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La Causale '{0}' non è attiva", new string[1] { _GMBDocumento.Causale });
				}
				else if (_GMBDocumento.TipoSoggetto1 == GMB_TipoSoggetto.NotDefined)
				{
					rsmess = this.TranslateMessage("XXX", "Tipologia del soggetto 1 del movimento non definito");
				}
				else if (Operators.CompareString(_GMBDocumento.Soggetto1, "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Codice del soggetto 1 del movimento non definito");
				}
				else if (_GMBDocumento.Segno1 == GMB_Segno.NotDefined)
				{
					rsmess = this.TranslateMessage("XXX", "Segno 1 del movimento non definito");
				}
				else if (Operators.CompareString(ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto1), _dtCausale.Rows[0]["TipoSoggetto1"].ToString(), false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Tipologia del soggetto 1 del movimento non congruente con la causale impostata");
				}
				else
				{
					if (Operators.CompareString(_dtCausale.Rows[0]["TipoCausale"].ToString(), "D", false) != 0)
					{
						goto IL_0372;
					}
					if (_GMBDocumento.TipoSoggetto2 == GMB_TipoSoggetto.NotDefined)
					{
						rsmess = this.TranslateMessage("XXX", "Tipologia del soggetto 2 del movimento non definita");
					}
					else if (Operators.CompareString(_GMBDocumento.Soggetto2, "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Codice del soggetto 2 del movimento non definito");
					}
					else if (_GMBDocumento.Segno2 == GMB_Segno.NotDefined)
					{
						rsmess = this.TranslateMessage("XXX", "Segno 2 del movimento non definito");
					}
					else
					{
						if (Operators.CompareString(ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto2), _dtCausale.Rows[0]["TipoSoggetto2"].ToString(), false) == 0)
						{
							goto IL_0372;
						}
						rsmess = this.TranslateMessage("XXX", "Tipologia del soggetto 2 del movimento non congruente con la causale impostata");
					}
				}
			}
			goto end_IL_0005;
			IL_06ee:
			if (_GMBDocumento.Bancali.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Nessun tipo bancale da movimentare definito");
			}
			else
			{
				val2 = (FXRETURN)0;
			}
			goto end_IL_0005;
			IL_0560:
			if (Operators.CompareString(_GMBDocumento.Cliente, "", false) == 0)
			{
				_GMBDocumento.Cliente = "*ALL";
			}
			if (!_GMBDocumento.DatIns.HasValue)
			{
				_GMBDocumento.DatIns = DateAndTime.Now;
			}
			if (!_GMBDocumento.DatAgg.HasValue)
			{
				_GMBDocumento.DatAgg = DateAndTime.Now;
			}
			if (Operators.CompareString(_GMBDocumento.UteIns, "", false) == 0)
			{
				_GMBDocumento.UteIns = this._User;
			}
			if (Operators.CompareString(_GMBDocumento.UteAgg, "", false) == 0)
			{
				_GMBDocumento.UteAgg = this._User;
			}
			if (Operators.CompareString(_GMBDocumento.NumeroBuono, "", false) == 0)
			{
				goto IL_06ee;
			}
			object objRes = null;
			vsSQLClause = "SELECT COUNT(*) FROM BANCALIMOVIMENTI WHERE NUMEROBUONO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_GMBDocumento.NumeroBuono);
			val = ((AppBaseClass)this).DbConn.DoSql(vsSQLClause, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(objRes) <= 0)
				{
					goto IL_06ee;
				}
				rsmess = this.TranslateMessage("XXX", "Numero buono già presente nei movimenti effettuati");
			}
			goto end_IL_0005;
			IL_0469:
			if (Operators.CompareString(_GMBDocumento.Soggetto2, "", false) == 0)
			{
				goto IL_0560;
			}
			object objRes2 = null;
			vsSQLClause = "SELECT COUNT(*) FROM VW_GMB_SOGGETTI ";
			vsSQLClause = vsSQLClause + "WHERE TIPOANAGRAFICA = " + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto2)) + " AND CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_GMBDocumento.Soggetto2);
			val = ((AppBaseClass)this).DbConn.DoSql(vsSQLClause, ref objRes2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(objRes2) != 0)
				{
					goto IL_0560;
				}
				rsmess = this.TranslateMessage("XXX", "Il codice soggetto {0} di tipo {1} non esiste nel sistema", new string[2]
				{
					_GMBDocumento.Soggetto2,
					ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto2)
				});
			}
			goto end_IL_0005;
			IL_0372:
			if (Operators.CompareString(_GMBDocumento.Soggetto1, "", false) == 0)
			{
				goto IL_0469;
			}
			object objRes3 = null;
			vsSQLClause = "SELECT COUNT(*) FROM VW_GMB_SOGGETTI ";
			vsSQLClause = vsSQLClause + "WHERE TIPOANAGRAFICA = " + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto1)) + " AND CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_GMBDocumento.Soggetto1);
			val = ((AppBaseClass)this).DbConn.DoSql(vsSQLClause, ref objRes3, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(objRes3) != 0)
				{
					goto IL_0469;
				}
				rsmess = this.TranslateMessage("XXX", "Il codice soggetto {0} di tipo {1} non esiste nel sistema", new string[2]
				{
					_GMBDocumento.Soggetto1,
					ConvertTipoSoggettoToString(_GMBDocumento.TipoSoggetto1)
				});
			}
			end_IL_0005:;
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

	protected FXRETURN CreaStrutturaMovimenti(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			long rlReturnValue = default(long);
			foreach (GMB_MovimentoBancale item in _GMBDocumento.Bancali)
			{
				GMB_Movimento gMB_Movimento = new GMB_Movimento();
				val = this._ApiContext.Parametrica.LeggiContatore("DM.GMB.IDMOVIMENTO", ref rlReturnValue, ref rsmess);
				if ((int)val <= 0)
				{
					gMB_Movimento.Id = rlReturnValue.ToString();
					gMB_Movimento.Data = _GMBDocumento.Data;
					gMB_Movimento.Causale = _GMBDocumento.Causale;
					gMB_Movimento.TipoSoggetto1 = _GMBDocumento.TipoSoggetto1;
					gMB_Movimento.Soggetto1 = _GMBDocumento.Soggetto1;
					gMB_Movimento.Segno1 = _GMBDocumento.Segno1;
					gMB_Movimento.TipoSoggetto2 = _GMBDocumento.TipoSoggetto2;
					gMB_Movimento.Soggetto2 = _GMBDocumento.Soggetto2;
					gMB_Movimento.Segno2 = _GMBDocumento.Segno2;
					gMB_Movimento.TipoBancale = item.TipoBancale;
					gMB_Movimento.Quantita = item.Quantita;
					gMB_Movimento.Cliente = _GMBDocumento.Cliente;
					gMB_Movimento.IdRiferimento1 = _GMBDocumento.IdRiferimento1;
					gMB_Movimento.DataRiferimento1 = _GMBDocumento.DataRiferimento1;
					gMB_Movimento.IdRiferimento2 = _GMBDocumento.IdRiferimento2;
					gMB_Movimento.DataRiferimento2 = _GMBDocumento.DataRiferimento2;
					gMB_Movimento.Note = _GMBDocumento.Note;
					gMB_Movimento.NumeroBuono = _GMBDocumento.NumeroBuono;
					gMB_Movimento.Filler1 = _GMBDocumento.Filler1;
					gMB_Movimento.Filler2 = _GMBDocumento.Filler2;
					gMB_Movimento.Filler3 = _GMBDocumento.Filler3;
					gMB_Movimento.Filler4 = _GMBDocumento.Filler4;
					gMB_Movimento.Filler5 = _GMBDocumento.Filler5;
					gMB_Movimento.DatAgg = _GMBDocumento.DatAgg;
					gMB_Movimento.UteAgg = _GMBDocumento.UteAgg;
					gMB_Movimento.DatIns = _GMBDocumento.DatIns;
					gMB_Movimento.UteIns = _GMBDocumento.UteIns;
					_GMBMovimenti.Add(gMB_Movimento);
					continue;
				}
				val2 = val;
				goto end_IL_0005;
			}
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	protected FXRETURN GiacenzaAggiorna(GMB_Movimento mov, ref string QueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			QueryToApply = "";
			int num = 1;
			while (true)
			{
				string text2 = "";
				GMB_TipoSoggetto gMB_TipoSoggetto;
				GMB_Segno gMB_Segno;
				if (num == 1)
				{
					gMB_TipoSoggetto = mov.TipoSoggetto1;
					text2 = mov.Soggetto1;
					gMB_Segno = mov.Segno1;
				}
				else
				{
					gMB_TipoSoggetto = mov.TipoSoggetto2;
					text2 = mov.Soggetto2;
					gMB_Segno = mov.Segno2;
				}
				if (((gMB_TipoSoggetto != GMB_TipoSoggetto.NotDefined) & (Operators.CompareString(text2, "", false) != 0)) && gMB_Segno != GMB_Segno.NotDefined)
				{
					text = "SELECT COUNT(*) FROM BancaliGiacenze ";
					text = text + "WHERE TipoSoggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(gMB_TipoSoggetto)) + " ";
					text = text + "AND Soggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
					text = text + "AND TipoBancale=" + ((AppBaseClass)this).DbConn.SQLFormatString(mov.TipoBancale) + " ";
					text = text + "AND Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Cliente) + " ";
					object objRes = null;
					val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (Conversions.ToInteger(objRes) == 0)
					{
						text = "INSERT INTO BancaliGiacenze(TipoSoggetto,Soggetto,TipoBancale,Cliente,Giacenza,UteAgg,UteIns) VALUES (";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(gMB_TipoSoggetto)) + ", ";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", ";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.TipoBancale) + ", ";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Cliente) + ", ";
						int pNumero = mov.Quantita;
						if (gMB_Segno == GMB_Segno.Minus)
						{
							pNumero = checked(-pNumero);
						}
						text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
						text = text + this.DbConn.SQLFormatString(this._User) + ", ";
						text = text + this.DbConn.SQLFormatString(this._User) + "); ";
					}
					else
					{
						text = "UPDATE BancaliGiacenze ";
						string[] obj = new string[5]
						{
							text,
							"SET Giacenza=Giacenza ",
							ConvertSegnoToString(gMB_Segno),
							null,
							null
						};
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						GMB_Movimento gMB_Movimento;
						int pNumero2 = (gMB_Movimento = mov).Quantita;
						string text3 = dbConn.SQLFormatNumber(ref pNumero2);
						gMB_Movimento.Quantita = pNumero2;
						obj[3] = text3;
						obj[4] = ", ";
						text = string.Concat(obj);
						text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + ", ";
						text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + " ";
						text = text + "WHERE TipoSoggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(gMB_TipoSoggetto)) + " ";
						text = text + "AND Soggetto=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + " ";
						text = text + "AND TipoBancale=" + ((AppBaseClass)this).DbConn.SQLFormatString(mov.TipoBancale) + " ";
						text = text + "AND Cliente=" + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Cliente) + "; ";
					}
					QueryToApply += text;
				}
				num = checked(num + 1);
				if (num > 2)
				{
					val2 = (FXRETURN)0;
					break;
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

	protected FXRETURN MovimentoInserisci(GMB_Movimento mov, ref string QueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			QueryToApply = "";
			string text = "INSERT INTO BancaliMovimenti (Id,Data,Causale,TipoSoggetto1,Soggetto1,Segno1,TipoSoggetto2,Soggetto2,Segno2,Quantita,TipoBancale,Cliente,IdRiferimento1,DataRiferimento1,";
			text += "IdRiferimento2,DataRiferimento2,Note,NumeroBuono,FILLER1,FILLER2,FILLER3,FILLER4,FILLER5,UteAgg,UteIns) VALUES (";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Id) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, mov.Data) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Causale) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(mov.TipoSoggetto1)) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Soggetto1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertSegnoToString(mov.Segno1)) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(mov.TipoSoggetto2)) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Soggetto2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertSegnoToString(mov.Segno2)) + ", ";
			string text2 = text;
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			GMB_Movimento gMB_Movimento;
			int pNumero = (gMB_Movimento = mov).Quantita;
			string text3 = dbConn.SQLFormatNumber(ref pNumero);
			gMB_Movimento.Quantita = pNumero;
			text = text2 + text3 + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.TipoBancale) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Cliente) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.IdRiferimento1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, mov.DataRiferimento1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.IdRiferimento2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, mov.DataRiferimento2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Note) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.NumeroBuono) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Filler1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Filler2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Filler3) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Filler4) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(mov.Filler5) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + "); ";
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

	protected string ConvertTipoSoggettoToString(GMB_TipoSoggetto ts)
	{
		string result = "";
		switch (ts)
		{
		case GMB_TipoSoggetto.Cliente:
			result = "C";
			break;
		case GMB_TipoSoggetto.Corrispondente:
			result = "H";
			break;
		case GMB_TipoSoggetto.Destinatario:
			result = "D";
			break;
		case GMB_TipoSoggetto.Filiale:
			result = "F";
			break;
		case GMB_TipoSoggetto.Vettore:
			result = "V";
			break;
		}
		return result;
	}

	protected string ConvertSegnoToString(GMB_Segno ts)
	{
		string result = "";
		switch (ts)
		{
		case GMB_Segno.Minus:
			result = "-";
			break;
		case GMB_Segno.Plus:
			result = "+";
			break;
		}
		return result;
	}
}
