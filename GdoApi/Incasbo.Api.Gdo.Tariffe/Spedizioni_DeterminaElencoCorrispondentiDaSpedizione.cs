using System;
using System.Collections.Specialized;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_DeterminaElencoCorrispondentiDaSpedizione : AppAbstractApi
{
	protected string _unibol;

	protected DataTable _dtSpedizione;

	protected StringCollection _ListOfCorrispondenti;

	public Spedizioni_DeterminaElencoCorrispondentiDaSpedizione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_unibol = "";
		_dtSpedizione = null;
		_ListOfCorrispondenti = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			string sSql = "SELECT unibol, %ISNULL%(%ISNULL%(DataBolla,DataSpedizione),%TRUNC%(datins)) DataRiferimento FROM Spedizioni WHERE unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_unibol);
			sSql = ((AppBaseClass)this).DbConn.SqlConvertForServer(sSql);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(sSql, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} non esiste", new string[1] { _unibol });
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("ListOfCorrispondenti", "");
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
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfCorrispondenti = new StringCollection();
			DateTime vsData = Conversions.ToDate(_dtSpedizione.Rows[0]["DataRiferimento"]);
			string text = "SELECT CODICE FROM Corrispondenti WHERE CodiceTrasportatore IN (SELECT Codice FROM Trasportatori WHERE Attivo='S' AND Codice IN (";
			text += "SELECT TRASPORTATORE FROM TariffeContratti WHERE AttivaPassiva='P' AND Attivo='S' ";
			text += "AND Trasportatore IS NOT NULL ";
			text = text + "AND DataInizioValidita <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + " ";
			text = text + "AND DataFineValidita >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, vsData) + ") ";
			text += "AND CODICE IN (";
			text += "SELECT CodiceTrasportatore FROM Corrispondenti WHERE Attivo='S'))";
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
					_ListOfCorrispondenti.Add(row["Codice"].ToString());
				}
				if (_ListOfCorrispondenti.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Non è possibile determinare nessun corrispondente attivo con Contratto valido in data {0}", new string[1] { vsData.ToString("dd/MM/yyyy") });
				}
				else
				{
					((AppAbstractApi)this).ParametersOut["ListOfCorrispondenti"] = _ListOfCorrispondenti;
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
