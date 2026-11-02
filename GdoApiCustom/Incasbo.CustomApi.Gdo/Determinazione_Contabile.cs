using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.Gdo;

public class Determinazione_Contabile : GdoAbstractApi
{
	protected string _Unibol;

	protected string _TipoMerce;

	protected string _TipoSpedizione;

	protected string _PcsPartenza;

	protected string _PcsArrivo;

	protected string _Voce;

	protected string _Tipologia;

	protected string _Modo;

	protected string _Msg;

	public Determinazione_Contabile(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Msg, "", false) != 0)
			{
				_Msg = "";
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Voce = ((AppAbstractApi)this).ParametersIn["Voce"].ToString();
			_Tipologia = ((AppAbstractApi)this).ParametersIn["Tipologia"].ToString();
			_Modo = ((AppAbstractApi)this).ParametersIn["Modo"].ToString();
			if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString(), "", false) != 0)
			{
				_TipoMerce = ((AppAbstractApi)this).ParametersIn["TipoMerce"].ToString();
				_TipoSpedizione = ((AppAbstractApi)this).ParametersIn["TipoSpedizione"].ToString();
				_PcsPartenza = ((AppAbstractApi)this).ParametersIn["PcsPartenza"].ToString();
				_PcsArrivo = ((AppAbstractApi)this).ParametersIn["PcsArrivo"].ToString();
				goto IL_0213;
			}
			DataTable rObjDataTable = null;
			text = "SELECT TipoMerce, TipoSpedizione, PcsPartenza, PcsDestinazione FROM Spedizioni WHERE unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val <= 0)
			{
				_TipoMerce = rObjDataTable.Rows[0]["TipoMerce"].ToString();
				_TipoSpedizione = rObjDataTable.Rows[0]["TipoSpedizione"].ToString();
				_PcsPartenza = rObjDataTable.Rows[0]["PcsPartenza"].ToString();
				_PcsArrivo = rObjDataTable.Rows[0]["PcsDestinazione"].ToString();
				goto IL_0213;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0213:
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Invalid comparison between Unknown and I4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "DELETE FROM CST_CHECK_DETERM_CONT WHERE ";
			text = text + "Tipologia = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipologia) + " ";
			text = text + "AND unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
			text = text + "AND Voce = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Voce) + " ";
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				DataTable rObjDataTable = null;
				text = "SELECT * FROM CST_VW_Voci_CentroDiCosto_Peso WHERE ";
				text = text + "TipoSpedizione IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoSpedizione) + ") ";
				text = text + "AND TipoMerce IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoMerce) + ") ";
				text = text + "AND PCSPartenza IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PcsPartenza) + ") ";
				text = text + "AND PCSArrivo IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_PcsArrivo) + ") ";
				text = text + "AND Voce IN ('*ALL', " + ((AppBaseClass)this).DbConn.SQLFormatString(_Voce) + ") ";
				text += "ORDER BY Peso DESC";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					DataTable rObjDataTable2 = null;
					text = "SELECT * FROM CST_SPEDIZIONI WHERE UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text = "INSERT INTO CST_CHECK_DETERM_CONT (Tipologia, Unibol,Voce,Cdc,ClasseCoge,Errore) VALUES (";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipologia) + ", ";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ", ";
						text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Voce) + ", ";
						if (rObjDataTable.Rows.Count == 0)
						{
							text2 = this.TranslateMessage("XXX", "Nessuna Combinazione Contabile trovata per la spedizione {0} con voce {1}", new string[2] { _Unibol, _Voce });
							text = text + "'',''," + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ")";
						}
						else
						{
							text = ((Operators.CompareString(rObjDataTable2.Rows[0]["CentroDiCosto"].ToString(), "", false) != 0) ? (text + ((AppBaseClass)this).DbConn.SQLFormatString(rObjDataTable2.Rows[0]["CentroDiCosto"].ToString()) + ", ") : (text + ((AppBaseClass)this).DbConn.SQLFormatString(rObjDataTable.Rows[0]["CentroDiCosto"].ToString()) + ", "));
							text = text + ((AppBaseClass)this).DbConn.SQLFormatString(rObjDataTable.Rows[0]["ClasseCoge"].ToString()) + ", ";
							text += "'OK')";
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(_Modo, "T", false) != 0)
							{
								if (Operators.CompareString(text2, "", false) != 0)
								{
									_Msg = text2;
								}
								else
								{
									_Msg = this.TranslateMessage("XXX", "OK - Combinazione Contabile trovata per la spedizione {0} con voce {1}", new string[2] { _Unibol, _Voce });
								}
							}
							val2 = (FXRETURN)0;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string unibol, string tipoMerce, string tipoSpedizione, string pcsPartenza, string pcsArrivo, string Voce, string Tipologia, string Modo, ref string rsWarn, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Determinazione_Contabile determinazione_Contabile = new Determinazione_Contabile(objApiContext);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("Unibol", unibol);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("TipoMerce", tipoMerce);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("TipoSpedizione", tipoSpedizione);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("PcsPartenza", pcsPartenza);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("PcsArrivo", pcsArrivo);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("Voce", Voce);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("Tipologia", Tipologia);
		((AppAbstractApi)determinazione_Contabile).ParametersIn.Add("Modo", Modo);
		val = ((AppAbstractApi)determinazione_Contabile).Run(ref rsMess);
		rsWarn = determinazione_Contabile._Msg;
		return val;
	}
}
