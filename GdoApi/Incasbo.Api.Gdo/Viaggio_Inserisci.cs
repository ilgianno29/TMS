using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Inserisci : GdoAbstractApi
{
	protected Viaggio _Viaggio;

	protected string _IdViaggioLinea;

	protected DataTable _dtViaggioLinea;

	protected DateTime? _DataEvento;

	public Viaggio_Inserisci(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggioLinea = "";
		_dtViaggioLinea = null;
		_DataEvento = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Viaggio = (Viaggio)this._ParametersIn["Viaggio"];
			this._ParametersOut.Add("Viaggio", _Viaggio);
			if (this._ParametersIn.ContainsKey("IdViaggioLinea"))
			{
				_IdViaggioLinea = this._ParametersIn["IdViaggioLinea"].ToString();
			}
			if (this._ParametersIn.ContainsKey("DataEvento"))
			{
				_DataEvento = (DateTime?)this._ParametersIn["DataEvento"];
			}
			val = CheckLinea(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckRiferimenti(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = CheckVettore(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = CheckCliente(ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = CheckPCS(ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = CheckDefault(ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									_Viaggio.UteAgg = this._User;
									_Viaggio.UteIns = this._User;
									val2 = (FXRETURN)0;
								}
							}
						}
					}
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
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sQuery = "";
			val = CreateQuery(_Viaggio, ref sQuery, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_Viaggio.IdViaggio = _Viaggio.IdViaggio.Trim();
				if (!((Operators.CompareString(_Viaggio.IdViaggio, "", false) == 0) | _Viaggio.IdViaggio.Contains("%IDVIAGGIO%")))
				{
					goto IL_00f4;
				}
				long rlReturnValue = default(long);
				val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.VIAGGI", ref rlReturnValue, ref rsmess);
				if ((int)val <= 0)
				{
					sQuery = sQuery.Replace("%IDVIAGGIO%", rlReturnValue.ToString());
					_Viaggio.IdViaggio = _Viaggio.IdViaggio.ToString().Replace("%IDVIAGGIO%", rlReturnValue.ToString());
					goto IL_00f4;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_00f4:
			string RetQueryToApply = "";
			val = EventoViaggio_Inserimento.RunProc(this._ApiContext, _Viaggio.IdViaggio, _DataEvento, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				sQuery += RetQueryToApply;
				val = ((AppBaseClass)this).DbConn.SqlExec(sQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = WMS_Viaggio_Crea_Invoker.Instance.RunProc(this._ApiContext, _Viaggio.IdViaggio, ref rsmess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
				}
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

	protected virtual FXRETURN CheckCliente(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Viaggio.Cliente, "", false) == 0)
			{
				goto IL_0365;
			}
			string text2 = ((Operators.CompareString(_Viaggio.MotriceEffettiva, "", false) != 0) ? _Viaggio.MotriceEffettiva : _Viaggio.MotricePianificata);
			string text3 = ((Operators.CompareString(_Viaggio.Rimorchio1Effettivo, "", false) != 0) ? _Viaggio.MotriceEffettiva : _Viaggio.Rimorchio1Pianificato);
			string text4 = ((Operators.CompareString(_Viaggio.Contenitore1Effettivo, "", false) != 0) ? _Viaggio.MotriceEffettiva : _Viaggio.Contenitore1Pianificato);
			string text5 = ((Operators.CompareString(_Viaggio.Rimorchio2Effettivo, "", false) != 0) ? _Viaggio.MotriceEffettiva : _Viaggio.Rimorchio2Pianificato);
			string text6 = ((Operators.CompareString(_Viaggio.Contenitore2Effettivo, "", false) != 0) ? _Viaggio.MotriceEffettiva : _Viaggio.Contenitore2Pianificato);
			StringCollection stringCollection = new StringCollection();
			if (Operators.CompareString(text2, "", false) != 0)
			{
				stringCollection.Add(text2);
			}
			if (Operators.CompareString(text3, "", false) != 0)
			{
				stringCollection.Add(text3);
			}
			if (Operators.CompareString(text4, "", false) != 0)
			{
				stringCollection.Add(text4);
			}
			if (Operators.CompareString(text5, "", false) != 0)
			{
				stringCollection.Add(text5);
			}
			if (Operators.CompareString(text6, "", false) != 0)
			{
				stringCollection.Add(text6);
			}
			DataTable rObjDataTable = null;
			text = "SELECT Codice, Cliente FROM MEZZI WHERE CODICE IN (";
			string text7 = "";
			StringEnumerator enumerator = stringCollection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				text7 = text7 + ((AppBaseClass)this).DbConn.SQLFormatString(current) + ",";
			}
			text7 = Strings.Left(text7, checked(Strings.Len(text7) - 1));
			text = text + text7 + ")";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (DataRow row in rObjDataTable.Rows)
				{
					if (Operators.CompareString(row["Cliente"].ToString(), "", false) == 0 || Operators.CompareString(row["Cliente"].ToString(), _Viaggio.Cliente, false) == 0)
					{
						continue;
					}
					rsmess = this.TranslateMessage("XXX", "Il mezzo {0} appartiene al cliente {1} e non al cliente {2}", new string[3]
					{
						row["Codice"].ToString(),
						row["Cliente"].ToString(),
						_Viaggio.Cliente
					});
					goto end_IL_000b;
				}
				goto IL_0365;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0365:
			val2 = (FXRETURN)0;
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

	protected virtual FXRETURN CheckPCS(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Invalid comparison between Unknown and I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Invalid comparison between Unknown and I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdViaggioLinea, "", false) != 0)
			{
				if (Operators.CompareString(_Viaggio.PCSPartenza, "", false) == 0)
				{
					_Viaggio.PCSPartenza = _dtViaggioLinea.Rows[0]["PCSPartenza"].ToString();
				}
				if (Operators.CompareString(_Viaggio.PCSArrivo, "", false) == 0)
				{
					_Viaggio.PCSArrivo = _dtViaggioLinea.Rows[0]["PCSArrivo"].ToString();
				}
				if (Operators.CompareString(_Viaggio.ZonaArrivoTariffaAttiva, "", false) == 0)
				{
					_Viaggio.ZonaArrivoTariffaAttiva = _dtViaggioLinea.Rows[0]["ZonaTariffaAttiva"].ToString();
				}
				if (Operators.CompareString(_Viaggio.ZonaArrivo, "", false) == 0)
				{
					_Viaggio.ZonaArrivo = _dtViaggioLinea.Rows[0]["ZonaTariffaPassiva"].ToString();
				}
			}
			string text = ((Operators.CompareString(_Viaggio.PCSPartenzaEffettivo, "", false) != 0) ? _Viaggio.PCSPartenzaEffettivo : _Viaggio.PCSPartenza);
			string text2 = ((Operators.CompareString(_Viaggio.PCSArrivoEffettivo, "", false) != 0) ? _Viaggio.PCSArrivoEffettivo : _Viaggio.PCSArrivo);
			string ZonaTariffaPassiva = "";
			string ZonaTariffaAttiva = "";
			string ZonaTariffaPassiva2 = "";
			string ZonaTariffaAttiva2 = "";
			if (!((Operators.CompareString(_Viaggio.ZonaPartenza, "", false) == 0) | (Operators.CompareString(_Viaggio.ZonaPartenzaTariffaAttiva, "", false) == 0)) || Operators.CompareString(text, "", false) == 0)
			{
				goto IL_02d3;
			}
			AppApiContext apiContext = this._ApiContext;
			string tipoMerce = _Viaggio.TipoMerce;
			string ZonaSpedizione = "";
			val = PCS_DeterminaZone.RunProc(apiContext, text, tipoMerce, ref ZonaSpedizione, ref ZonaTariffaAttiva, ref ZonaTariffaPassiva, ref rsmess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(_Viaggio.ZonaPartenza, "", false) == 0)
				{
					_Viaggio.ZonaPartenza = ZonaTariffaPassiva;
				}
				if (Operators.CompareString(_Viaggio.ZonaPartenzaTariffaAttiva, "", false) == 0)
				{
					_Viaggio.ZonaPartenzaTariffaAttiva = ZonaTariffaAttiva;
				}
				goto IL_02d3;
			}
			val2 = val;
			goto end_IL_0005;
			IL_02d3:
			if (!((Operators.CompareString(_Viaggio.ZonaArrivo, "", false) == 0) | (Operators.CompareString(_Viaggio.ZonaArrivoTariffaAttiva, "", false) == 0)) || Operators.CompareString(text2, "", false) == 0)
			{
				goto IL_03c3;
			}
			AppApiContext apiContext2 = this._ApiContext;
			string tipoMerce2 = _Viaggio.TipoMerce;
			ZonaSpedizione = "";
			val = PCS_DeterminaZone.RunProc(apiContext2, text2, tipoMerce2, ref ZonaSpedizione, ref ZonaTariffaAttiva2, ref ZonaTariffaPassiva2, ref rsmess);
			if ((int)val <= 0)
			{
				if (Operators.CompareString(_Viaggio.ZonaArrivo, "", false) == 0)
				{
					_Viaggio.ZonaArrivo = ZonaTariffaPassiva2;
				}
				if (Operators.CompareString(_Viaggio.ZonaArrivoTariffaAttiva, "", false) == 0)
				{
					_Viaggio.ZonaArrivoTariffaAttiva = ZonaTariffaAttiva2;
				}
				goto IL_03c3;
			}
			val2 = val;
			goto end_IL_0005;
			IL_03c3:
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

	protected virtual FXRETURN CheckVettore(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Invalid comparison between Unknown and I4
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Invalid comparison between Unknown and I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Invalid comparison between Unknown and I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdViaggioLinea, "", false) != 0)
			{
				if (Operators.CompareString(_Viaggio.MotricePianificata, "", false) == 0)
				{
					_Viaggio.MotricePianificata = _dtViaggioLinea.Rows[0]["Mezzo"].ToString();
				}
				if (Operators.CompareString(_Viaggio.Vettore, "", false) == 0)
				{
					_Viaggio.Vettore = _dtViaggioLinea.Rows[0]["Vettore"].ToString();
				}
				if (Operators.CompareString(_Viaggio.Autista1Pianificato, "", false) == 0)
				{
					_Viaggio.Autista1Pianificato = _dtViaggioLinea.Rows[0]["Autista"].ToString();
				}
			}
			string text2 = _Viaggio.MotriceEffettiva;
			if (Operators.CompareString(text2, "", false) == 0)
			{
				text2 = _Viaggio.MotricePianificata;
			}
			if (Operators.CompareString(base.ApplicationParams.ViaggiDipendenzaTrasportatore(), "M", false) == 0)
			{
				if ((Operators.CompareString(_Viaggio.Vettore, "", false) != 0) & (Operators.CompareString(text2, "", false) == 0))
				{
					goto IL_05d6;
				}
				if ((Operators.CompareString(_Viaggio.Vettore, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0))
				{
					object objRes = null;
					text = "SELECT Trasportatore FROM Mezzi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2);
					val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(objRes.ToString(), "", false) == 0 || Operators.CompareString(objRes.ToString().ToUpper(), _Viaggio.Vettore, false) == 0)
						{
							goto IL_05d6;
						}
						rsmess = this.TranslateMessage("XXX", "Impossibile assegnare il viaggio al vettore {0} in quanto la motrice {1} non gli appartiene", new string[2] { _Viaggio.Vettore, text2 });
					}
				}
				else
				{
					if (!((Operators.CompareString(_Viaggio.Vettore, "", false) == 0) & (Operators.CompareString(text2, "", false) != 0)))
					{
						if (!((Operators.CompareString(_Viaggio.Vettore, "", false) == 0) & (Operators.CompareString(text2, "", false) == 0)))
						{
						}
						goto IL_05d6;
					}
					object objRes2 = null;
					text = "SELECT Trasportatore FROM Mezzi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2);
					val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes2, ref rsmess);
					if ((int)val <= 0)
					{
						if (Operators.CompareString(objRes2.ToString(), "", false) != 0)
						{
							_Viaggio.Vettore = objRes2.ToString();
						}
						goto IL_05d6;
					}
					val2 = val;
				}
			}
			else
			{
				if (Operators.CompareString(base.ApplicationParams.ViaggiDipendenzaTrasportatore(), "A", false) != 0 || ((Operators.CompareString(_Viaggio.Vettore, "", false) != 0) & (Operators.CompareString(_Viaggio.Autista1Pianificato, "", false) == 0)))
				{
					goto IL_05d6;
				}
				if ((Operators.CompareString(_Viaggio.Vettore, "", false) != 0) & (Operators.CompareString(_Viaggio.Autista1Pianificato, "", false) != 0))
				{
					object objRes3 = null;
					text = "SELECT Trasportatore FROM Autisti WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.Autista1Pianificato);
					val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes3, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (Operators.CompareString(objRes3.ToString(), "", false) == 0 || Operators.CompareString(objRes3.ToString().ToUpper(), _Viaggio.Autista1Pianificato, false) == 0)
						{
							goto IL_05d6;
						}
						rsmess = this.TranslateMessage("XXX", "Impossibile assegnare il viaggio al vettore {0} in quanto l'autista {1} non gli appartiene", new string[2] { _Viaggio.Vettore, _Viaggio.Autista1Pianificato });
					}
				}
				else
				{
					if (!((Operators.CompareString(_Viaggio.Vettore, "", false) == 0) & (Operators.CompareString(_Viaggio.Autista1Pianificato, "", false) != 0)))
					{
						if (!((Operators.CompareString(_Viaggio.Vettore, "", false) == 0) & (Operators.CompareString(_Viaggio.Autista1Pianificato, "", false) == 0)))
						{
						}
						goto IL_05d6;
					}
					object objRes4 = null;
					text = "SELECT Trasportatore FROM Autisti WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Viaggio.Autista1Pianificato);
					val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes4, ref rsmess);
					if ((int)val <= 0)
					{
						if (Operators.CompareString(objRes4.ToString(), "", false) != 0)
						{
							_Viaggio.Vettore = objRes4.ToString();
						}
						goto IL_05d6;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_05d6:
			val2 = (FXRETURN)0;
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

	protected virtual FXRETURN CheckRiferimenti(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Viaggio.IdViaggio, "", false) == 0)
			{
				_Viaggio.IdViaggio = "%IDVIAGGIO%";
			}
			if (Operators.CompareString(_Viaggio.TipoViaggio, "", false) == 0 && Operators.CompareString(_IdViaggioLinea, "", false) != 0)
			{
				_Viaggio.TipoViaggio = _dtViaggioLinea.Rows[0]["TipoViaggio"].ToString();
			}
			if (Operators.CompareString(_Viaggio.TipoViaggio, "", false) == 0)
			{
				_Viaggio.TipoViaggio = base.ApplicationDefault.TipoViaggio_Default();
			}
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

	protected virtual FXRETURN CheckDefault(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Viaggio.TipoViaggio, "", false) == 0)
			{
				goto IL_00ff;
			}
			Dictionary<string, string> DictionaryDefault = null;
			val = Viaggio_TipoViaggio_Default.RunProc(this._ApiContext, _Viaggio.TipoViaggio, ref DictionaryDefault, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (string key in DictionaryDefault.Keys)
				{
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(IncasReflection.GetPropertyValue((object)_Viaggio, key));
						if (objectValue == null || Operators.CompareString(objectValue.ToString(), "", false) == 0)
						{
							IncasReflection.SetPropertyValue((object)_Viaggio, key, (object)DictionaryDefault[key]);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				goto IL_00ff;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00ff:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			val2 = this.HandleError(ref ex4, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual FXRETURN CreateQuery(object obj, ref string sQuery, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			sQuery = "INSERT INTO %TABLENAME% (";
			PropertyInfo[] publicProperties = IncasReflection.GetPublicProperties(RuntimeHelpers.GetObjectValue(obj));
			PropertyInfo[] array = publicProperties;
			foreach (PropertyInfo propertyInfo in array)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue != null)
				{
					sQuery = sQuery + propertyInfo.Name + ",";
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1));
			sQuery += ") VALUES (";
			PropertyInfo[] array2 = publicProperties;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(propertyInfo2.GetValue(RuntimeHelpers.GetObjectValue(obj), null));
				if (objectValue2 != null)
				{
					eTipoDati val3 = modGeneral.DataTypeToBaseType(objectValue2.GetType());
					if ((int)val3 == 0)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
					else if ((int)val3 == 3)
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, Conversions.ToDate(objectValue2)) + ",";
					}
					else if ((int)val3 == 2 || (int)val3 == 1)
					{
						string obj2 = sQuery;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						decimal pNumero = Conversions.ToDecimal(objectValue2);
						sQuery = obj2 + dbConn.SQLFormatNumber(ref pNumero) + ",";
					}
					else
					{
						sQuery = sQuery + ((AppBaseClass)this).DbConn.SQLFormatString(objectValue2.ToString()) + ",";
					}
				}
			}
			sQuery = Strings.Left(sQuery, checked(Strings.Len(sQuery) - 1)) + ");";
			Dictionary<string, object> customListAttributes = IncasReflection.GetCustomListAttributes(RuntimeHelpers.GetObjectValue(obj));
			if (customListAttributes.ContainsKey("TableName"))
			{
				sQuery = sQuery.Replace("%TABLENAME%", customListAttributes["TableName"].ToString());
			}
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

	protected virtual FXRETURN CheckLinea(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdViaggioLinea, "", false) == 0)
			{
				goto IL_01cb;
			}
			string vsSQLClause = "SELECT * FROM Viaggi_Linea WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggioLinea);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtViaggioLinea, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_dtViaggioLinea.Rows.Count != 0)
				{
					if (Operators.CompareString(_Viaggio.TipoSpedizione, "", false) == 0)
					{
						_Viaggio.TipoSpedizione = _dtViaggioLinea.Rows[0]["TipoSpedizione"].ToString();
					}
					if (Operators.CompareString(_Viaggio.TipoMerce, "", false) == 0)
					{
						_Viaggio.TipoMerce = _dtViaggioLinea.Rows[0]["TipoMerce"].ToString();
					}
					if (!_Viaggio.DataPartenzaPianificata.HasValue && Information.IsDate(RuntimeHelpers.GetObjectValue(_dtViaggioLinea.Rows[0]["DataPartenzaPianificata"])))
					{
						_Viaggio.DataPartenzaPianificata = Conversions.ToDate(_dtViaggioLinea.Rows[0]["DataPartenzaPianificata"]);
					}
					goto IL_01cb;
				}
				rsmess = this.TranslateMessage("XXX", "Linea {0} non trovata", new string[1] { _IdViaggioLinea });
			}
			goto end_IL_0005;
			IL_01cb:
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
}
