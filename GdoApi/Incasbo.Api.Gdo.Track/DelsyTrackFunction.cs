using System;
using Incasbo.Api.App;
using Incasbo.Model.Map;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

[StandardModule]
internal sealed class DelsyTrackFunction
{
	public static Tipologia GetTipologiaPunto(string Tipo)
	{
		if (Operators.CompareString(Tipo, "1", false) != 0)
		{
			if (Operators.CompareString(Tipo, "2", false) == 0)
			{
				return Tipologia.DEPOSITO;
			}
			return Tipologia.NONDEFINITO;
		}
		return Tipologia.DESTINAZIONE;
	}

	public static EsitoOrdine GetEsitoPunto(string Esito)
	{
		return Esito switch
		{
			"OK" => EsitoOrdine.OK, 
			"KO_CONSEGNA" => EsitoOrdine.KO_CONSEGNA, 
			"KO_NOCONSEGNA" => EsitoOrdine.KO_NOCONSEGNA, 
			_ => EsitoOrdine.OK, 
		};
	}

	public static FXRETURN GetIconaPuntoGPS(AppApiContext objApiContext, decimal Velocita, decimal Direzione, ref string Icona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between Unknown and I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			Icona = "";
			text = ((decimal.Compare(Velocita, 5m) < 0) ? "Path0" : ((decimal.Compare(Direzione, 23m) < 0) ? "Path1" : ((decimal.Compare(Direzione, 68m) < 0) ? "Path2" : ((decimal.Compare(Direzione, 113m) < 0) ? "Path3" : ((decimal.Compare(Direzione, 158m) < 0) ? "Path4" : ((decimal.Compare(Direzione, 203m) < 0) ? "Path5" : ((decimal.Compare(Direzione, 248m) < 0) ? "Path6" : ((decimal.Compare(Direzione, 293m) < 0) ? "Path7" : ((decimal.Compare(Direzione, 338m) < 0) ? "Path8" : ((decimal.Compare(Direzione, 361m) >= 0) ? "Path0" : "Path1"))))))))));
			val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOGPS", text, ref Icona, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	public static FXRETURN GetIconePuntoSuMappa(AppApiContext objApiContext, Tipologia Tipologia, ref string icona, ref string IconaSelezionata, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Valore = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			switch (Tipologia)
			{
			case Tipologia.DEPOSITO:
				val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.DEPOSITO", "Path", ref Valore, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					icona = Valore;
					Valore = "";
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.DEPOSITO", "PathSel", ref Valore, ref rsMess);
					if ((int)val2 <= 0)
					{
						IconaSelezionata = Valore;
						break;
					}
					val = val2;
				}
				goto end_IL_000b;
			case Tipologia.DESTINAZIONE:
				val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOCONSEGNA", "Path", ref Valore, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					icona = Valore;
					Valore = "";
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOCONSEGNA", "PathSel", ref Valore, ref rsMess);
					if ((int)val2 <= 0)
					{
						IconaSelezionata = Valore;
						break;
					}
					val = val2;
				}
				goto end_IL_000b;
			default:
			{
				Tipologia tipologia = Tipologia.NONDEFINITO;
				break;
			}
			}
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	public static FXRETURN GetIconePuntoSuMappa(AppApiContext objApiContext, Tipologia Tipologia, EsitoOrdine Esito, ref string icona, ref string IconaSelezionata, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Valore = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			switch (Tipologia)
			{
			case Tipologia.DEPOSITO:
				val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.DEPOSITO", "Path", ref Valore, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					icona = Valore;
					Valore = "";
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.DEPOSITO", "PathSel", ref Valore, ref rsMess);
					if ((int)val2 <= 0)
					{
						IconaSelezionata = Valore;
						break;
					}
					val = val2;
				}
				goto end_IL_000b;
			case Tipologia.DESTINAZIONE:
				if (Esito == EsitoOrdine.KO_NOCONSEGNA)
				{
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOCONSEGNA", "PathKoNoConsegna", ref Valore, ref rsMess);
					if ((int)val2 <= 0)
					{
						icona = Valore;
						goto IL_00ff;
					}
					val = val2;
				}
				else
				{
					val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOCONSEGNA", "Path", ref Valore, ref rsMess);
					if ((int)val2 <= 0)
					{
						icona = Valore;
						goto IL_00ff;
					}
					val = val2;
				}
				goto end_IL_000b;
			default:
				{
					Tipologia tipologia = Tipologia.NONDEFINITO;
					break;
				}
				IL_00ff:
				Valore = "";
				val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOCONSEGNA", "PathSel", ref Valore, ref rsMess);
				if ((int)val2 <= 0)
				{
					IconaSelezionata = Valore;
					break;
				}
				val = val2;
				goto end_IL_000b;
			}
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}

	public static FXRETURN GetIconaPuntoTemperatura(AppApiContext objApiContext, decimal Temperatura, ref string Icona, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			Icona = "";
			text = ((decimal.Compare(Temperatura, 5m) < 0) ? "Path0" : ((decimal.Compare(Temperatura, 23m) < 0) ? "Path1" : ((decimal.Compare(Temperatura, 68m) >= 0) ? "Path0" : "Path2")));
			val2 = DelsyTrackMapProperties_Invoker.Instance.RunProc(objApiContext, "ICONA.PUNTOTEMP", text, ref Icona, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
		}
		return result;
	}
}
