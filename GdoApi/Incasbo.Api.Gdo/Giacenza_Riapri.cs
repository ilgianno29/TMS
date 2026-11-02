using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Giacenza_Riapri : GiacenzeAbstractApi
{
	protected string _Unibol;

	protected int _IdGiacenza;

	protected DataTable _dtSpedizione;

	protected DataTable _dtGiacenza;

	protected DateTime? _dataRiapertura;

	protected bool _ApplyQuery;

	public Giacenza_Riapri(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_dtGiacenza = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdGiacenza = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["IdGiacenza"]);
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataRiapertura"))
			{
				_dataRiapertura = (DateTime?)((AppAbstractApi)this).ParametersIn["DataRiapertura"];
			}
			if (!_dataRiapertura.HasValue)
			{
				_dataRiapertura = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			val = CheckGiacenza(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizione(ref rsmess);
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "UPDATE Giacenze SET Stato=10, DataChiusura=NULL, ";
			text += "GiorniGiacenza=0, ";
			text += "UnibolChiusura=NULL, ";
			text += "ProgressivoChiusura=NULL, ";
			text += "CausaleChiusura=NULL, ";
			text += "NoteChiusura=NULL, ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdGiacenza) + "; ";
			string RetQueryToApply = "";
			val = EventoSpedizione_RiapriGiacenza.RunProc(this._ApiContext, _Unibol, _dataRiapertura, _IdGiacenza.ToString(), this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
				if (!_ApplyQuery)
				{
					goto IL_0144;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0144;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0144:
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.* FROM VW_Spedizioni S WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else
			{
				DataRow dataRow = _dtSpedizione.Rows[0];
				if ((Conversions.ToInteger(dataRow["Stato"]) <= 40) | (Conversions.ToInteger(dataRow["Stato"]) >= 60))
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette la riapertura di una giacenza. La spedizione deve essere esitata o arrivata a TP.", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non ha associato nessun documento di giacenza.", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), _IdGiacenza.ToString(), false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} ha associato un altro documento di giacenza.", new string[1] { _Unibol });
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

	protected virtual FXRETURN CheckGiacenza(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT * FROM Giacenze ";
			text = text + "WHERE ID = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdGiacenza);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtGiacenza, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtGiacenza.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La giacenza con Id {0} non esiste", new string[1] { _IdGiacenza.ToString() });
			}
			else
			{
				DataRow dataRow = _dtGiacenza.Rows[0];
				if (Conversions.ToInteger(dataRow["Stato"]) <= 10)
				{
					rsmess = this.TranslateMessage("XXX", "La giacenza con Id {0} risulta già aperta", new string[1] { _IdGiacenza.ToString() });
				}
				else if (Operators.CompareString(dataRow["IdFatturaAttiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Impossibile riaprire la giacenza con Id {0} in quanto risulta già fatturata attivamente (Id Fattura={1})", new string[2]
					{
						_IdGiacenza.ToString(),
						dataRow["IdFatturaAttiva"].ToString()
					});
				}
				else if (Operators.CompareString(dataRow["IdFatturaPassiva"].ToString(), "", false) != 0)
				{
					rsmess = this.TranslateMessage("XXX", "Impossibile riaprire la giacenza con Id {0} in quanto risulta già fatturata passivamente (Id Fattura={1})", new string[2]
					{
						_IdGiacenza.ToString(),
						dataRow["IdFatturaPassiva"].ToString()
					});
				}
				else
				{
					_Unibol = dataRow["UnibolChiusura"].ToString();
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
}
