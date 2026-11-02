using System;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Viaggi_DeterminaElencoVettoriDaViaggio : AppAbstractApi
{
	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected StringCollection _ListOfVettori;

	public Viaggi_DeterminaElencoVettoriDaViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_ListOfVettori = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			string vsSQLClause = "SELECT IdViaggio, Stato, Vettore, DataPartenzaPianificata FROM VIAGGI WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Operators.CompareString(_dtViaggio.Rows[0]["DataPartenzaPianificata"].ToString(), "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non ha la data di partenza pianificata valorizzata", new string[1] { _IdViaggio });
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("ListOfVettori", "");
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

	protected override void BeginTransaction()
	{
	}

	protected override void CommitTransaction()
	{
	}

	protected override void RollbackTransaction()
	{
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfVettori = new StringCollection();
			DateTime vsData = Conversions.ToDate(_dtViaggio.Rows[0]["DataPartenzaPianificata"]);
			string text = "SELECT Codice FROM Trasportatori WHERE Attivo='S' AND Codice IN (";
			text += "SELECT TRASPORTATORE FROM TariffeContratti WHERE AttivaPassiva='P' AND Attivo='S' ";
			text += "AND Trasportatore IS NOT NULL ";
			text = text + "AND DataInizioValidita <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + " ";
			text = text + "AND DataFineValidita >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ") ";
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in rObjDataTable.Rows)
				{
					_ListOfVettori.Add(row["Codice"].ToString());
				}
				if (_ListOfVettori.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Non è possibile determinare nessun vettore attivo con Contratto valido in data {0}", new string[1] { vsData.ToString("dd/MM/yyyy") });
				}
				else
				{
					((AppAbstractApi)this).ParametersOut["ListOfVettori"] = _ListOfVettori;
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
