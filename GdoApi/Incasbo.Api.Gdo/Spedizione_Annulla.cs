using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_Annulla : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected string _Note;

	public Spedizione_Annulla(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_Note = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Note = ((AppAbstractApi)this).ParametersIn["Note"].ToString();
			val = CheckSpedizione(ref rsmess);
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
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = text + "UPDATE Spedizioni SET STATO=99, IdViaggio=NULL, CostoViaggioRipartito=0, CostoViaggioRipartitoNolo=0, RicavoViaggioRipartito=0, RicavoViaggioRipartitoNolo=0 WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			string RetQueryToApply = "";
			string codiceEvento = "";
			val = EventoSpedizione_Annullamento.RunProc(this._ApiContext, _Unibol, codiceEvento, _Note, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				if (Operators.CompareString(text, "", false) == 0)
				{
					goto IL_00b8;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_00b8;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_00b8:
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

	protected FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Unibol,Stato,StatoWMS FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
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
				if (Conversions.ToInteger(dataRow["Stato"]) != 10)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette l'annullamento", new string[1] { _Unibol });
				}
				else if (Operators.CompareString(base.ApplicationParams.WmsEnabled(), "S", false) == 0 && ((Conversions.ToInteger(dataRow["StatoWMS"]) != 0) & (Conversions.ToInteger(dataRow["StatoWMS"]) != 99)))
				{
					rsmess = this.TranslateMessage("XXX", "Impossibile annullare la spedizione con Id {0} in quanto in gestione a WMS", new string[1] { _Unibol });
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
}
