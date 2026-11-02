using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Esita : ContrassegniAbstractApi
{
	protected int _IdContrassegno;

	protected string _CausaleEsito;

	protected DataTable _dtContrassegno;

	protected DataTable _dtSpedizione;

	protected DataTable _dtEvento;

	protected DateTime? _dataEsito;

	protected string _TipoIncasso;

	protected string _NoteIncasso;

	protected string _Note1;

	protected string _Note2;

	protected string _Note3;

	protected string _NoteEsito;

	protected string _UnibolChiusura;

	protected bool _ApplyQuery;

	public Contrassegno_Esita(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_CausaleEsito = "";
		_dtContrassegno = null;
		_dtSpedizione = null;
		_dtEvento = null;
		_TipoIncasso = "";
		_NoteIncasso = "";
		_Note1 = "";
		_Note2 = "";
		_Note3 = "";
		_NoteEsito = "";
		_UnibolChiusura = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdContrassegno = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["IdContrassegno"]);
			_CausaleEsito = ((AppAbstractApi)this).ParametersIn["CausaleEsito"].ToString();
			_dataEsito = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEsito"];
			if (!_dataEsito.HasValue)
			{
				_dataEsito = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("NoteEsito"))
			{
				_NoteEsito = Conversions.ToString(((AppAbstractApi)this).ParametersIn["NoteEsito"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoIncasso"))
			{
				_TipoIncasso = Conversions.ToString(((AppAbstractApi)this).ParametersIn["TipoIncasso"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("NoteIncasso"))
			{
				_NoteIncasso = Conversions.ToString(((AppAbstractApi)this).ParametersIn["NoteIncasso"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note1"))
			{
				_Note1 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note1"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note2"))
			{
				_Note2 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note2"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note3"))
			{
				_Note3 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note3"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			val = CheckContrassegno(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckCausaleEsito(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = FindSpedizioneChiusura(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
						val2 = (FXRETURN)0;
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
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Invalid comparison between Unknown and I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			int pNumero;
			DateTime? vsData = default(DateTime?);
			if (Operators.CompareString(_dtEvento.Rows[0]["TipoEvento"].ToString(), EventoContrassegnoTipo.ContrassegnoIncassato, false) == 0)
			{
				if (Operators.CompareString(_dtContrassegno.Rows[0]["Corrispondente"].ToString(), "", false) == 0)
				{
					pNumero = 30;
					vsData = _dataEsito.Value.Date;
				}
				else
				{
					pNumero = 20;
				}
			}
			else
			{
				pNumero = 99;
			}
			text = "UPDATE Contrassegni SET CausaleEsito=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CausaleEsito) + ", ";
			text = text + "DataEsito=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _dataEsito) + ", ";
			text = text + "NoteEsito=" + ((AppBaseClass)this).DbConn.SQLFormatString(_NoteEsito) + ", ";
			text = text + "Stato=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
			text = text + "UnibolChiusura=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UnibolChiusura) + ", ";
			text = text + "DataIncasso=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, vsData) + ", ";
			text = text + "DataCompetenzaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, vsData) + ", ";
			text = text + "DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, vsData) + ", ";
			if (Operators.CompareString(_TipoIncasso, "", false) != 0)
			{
				text = text + "TipoIncasso=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoIncasso) + ", ";
			}
			if (Operators.CompareString(_NoteIncasso, "", false) != 0)
			{
				text = text + "NoteIncasso=" + ((AppBaseClass)this).DbConn.SQLFormatString(_NoteIncasso) + ", ";
			}
			if (Operators.CompareString(_Note1, "", false) != 0)
			{
				text = text + "Note1=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Note1) + ", ";
			}
			if (Operators.CompareString(_Note2, "", false) != 0)
			{
				text = text + "Note2=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Note2) + ", ";
			}
			if (Operators.CompareString(_Note3, "", false) != 0)
			{
				text = text + "Note3=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Note3) + ", ";
			}
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + "; ";
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			if (!_ApplyQuery)
			{
				goto IL_0388;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0388;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0388:
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

	protected virtual FXRETURN FindSpedizioneChiusura(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DataTable rObjDataTable = null;
			text = "SELECT S.unibol FROM Spedizioni S ";
			text = text + "WHERE S.IdContrassegno = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + " ";
			text += "ORDER BY S.ProgressivoConsegna DESC";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_UnibolChiusura = rObjDataTable.Rows[0]["Unibol"].ToString();
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

	protected virtual FXRETURN CheckContrassegno(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT * FROM Contrassegni ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + " ";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtContrassegno, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtContrassegno.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La pratica di contrassegno con Id {0} non esiste", new string[1] { _IdContrassegno.ToString() });
			}
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) != 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta già esitata", new string[1] { _IdContrassegno.ToString() });
			}
			else
			{
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

	protected virtual FXRETURN CheckCausaleEsito(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT * FROM Eventi ";
			text = text + "WHERE Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CausaleEsito) + " ";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEvento, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtEvento.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La causale di esito {0} non esiste", new string[1] { _CausaleEsito });
			}
			else if ((Operators.CompareString(_dtEvento.Rows[0]["TipoEvento"].ToString(), EventoContrassegnoTipo.ContrassegnoIncassato, false) != 0) & (Operators.CompareString(_dtEvento.Rows[0]["TipoEvento"].ToString(), EventoContrassegnoTipo.ContrassegnoNonIncassato, false) != 0))
			{
				rsmess = this.TranslateMessage("XXX", "La causale di esito {0} non è una causale valida per i contrassegni", new string[1] { _CausaleEsito });
			}
			else
			{
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
}
