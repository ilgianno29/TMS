using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Api.App;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFFiltroStampaRifornimenti : WFIDialogPage
{
	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMezzo")]
	protected virtual IboWebLabel lblMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMezzo")]
	protected virtual IboWebComboTlk cmbMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRifInizio")]
	protected virtual IboWebLabel lblDataRifInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataRifInizio")]
	protected virtual IboWebDate DataRifInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataRifFine")]
	protected virtual IboWebLabel lblDataRifFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataRifFine")]
	protected virtual IboWebDate DataRifFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen")]
	protected virtual CollapsiblePanelExtender cpInfoGen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		_Context = "FILTROSTAMPARIFORNIMENTI";
		_Title = base.Translator.Translate("XXX", "Filtro Stampa Rifornimenti", new string[0]);
		_ReturnToCallerAfterConfirm = false;
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		base.TransactionManage = false;
		return result;
	}

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneInternaEsterna, "E", false) != 0)
				{
					goto IL_00a9;
				}
				cmbMezzo.SqlQueryFilter = base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto;
				IboWebComboTlk objCombo = cmbMezzo;
				FXRETURN val3 = LoadSingleCombo(ref objCombo, ref rsMess);
				cmbMezzo = objCombo;
				val = val3;
				if ((int)val2 <= 0)
				{
					goto IL_00a9;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_00a9:
			val = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Invalid comparison between Unknown and I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (((Operators.CompareString(DataRifInizio.ObjValue.ToString(), "", false) != 0) & (Operators.CompareString(DataRifFine.ObjValue.ToString(), "", false) == 0)) | ((Operators.CompareString(DataRifInizio.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(DataRifFine.ObjValue.ToString(), "", false) != 0)))
			{
				rsMess = TranslateMessage("XXX", "Inserire Data Riferimento");
			}
			else if (DateTime.Compare(Conversions.ToDate(DataRifFine.ObjValue.ToString()), Conversions.ToDate(DataRifInizio.ObjValue.ToString())) < 0)
			{
				rsMess = TranslateMessage("XXX", "Inserire Data Fine successiva a Data Inizio");
			}
			else
			{
				text = "SELECT COUNT(*) FROM VW_MEZZI_RIFORNIMENTI ";
				text = text + "WHERE " + base.DbConn.DateTrunc("DATAORA") + " >= " + base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(DataRifInizio.ObjValue.ToString())) + " ";
				text = text + "AND " + base.DbConn.DateTrunc("DATAORA") + " <= " + base.DbConn.SQLFormatDate((eTipoData)1, Conversions.ToDate(DataRifFine.ObjValue.ToString())) + " ";
				if (Operators.CompareString(cmbMezzo.ObjValue.ToString(), "", false) != 0)
				{
					text = text + "AND MEZZO = " + base.DbConn.SQLFormatString(cmbMezzo.ObjValue.ToString());
				}
				else if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneInternaEsterna, "E", false) == 0)
				{
					text = text + "AND " + base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto;
				}
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Conversions.ToInteger(obj) == 0)
				{
					rsMess = TranslateMessage("XXX", "Nessun rifornimento trovato per i parametri selezionati");
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Invalid comparison between Unknown and I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		ReportLaunchParametersCollection val3 = new ReportLaunchParametersCollection();
		ReportLaunchParameters val4 = new ReportLaunchParameters();
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val4 = new ReportLaunchParameters();
			val4.NomeReport = "MEZZIRIFORNIMENTI.rpt";
			text2 = "{RPT_RIFORNIMENTI_DETT.DATASTRINGA} >= '" + Strings.Format((object)Conversions.ToDate(DataRifInizio.ObjValue.ToString()), "yyyyMMdd") + "'";
			text2 = text2 + " AND {RPT_RIFORNIMENTI_DETT.DATASTRINGA} <= '" + Strings.Format((object)Conversions.ToDate(DataRifFine.ObjValue.ToString()), "yyyyMMdd") + "'";
			if (Operators.CompareString(cmbMezzo.ObjValue.ToString(), "", false) != 0)
			{
				text2 = text2 + " AND {RPT_RIFORNIMENTI_DETT.Mezzo}= '" + cmbMezzo.ObjValue.ToString() + "'";
			}
			else if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneInternaEsterna, "E", false) == 0)
			{
				text2 += " AND  ( ";
				StringEnumerator enumerator = base.SessionEnvironment.WebUser.WebUserInfo.CodiciSoggetti.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					text3 = ((Operators.CompareString(text3, "", false) != 0) ? (text3 + "OR {RPT_RIFORNIMENTI_DETT.Trasportatore} = " + base.DbConn.SQLFormatString(current) + " ") : ("{RPT_RIFORNIMENTI_DETT.Trasportatore} = " + base.DbConn.SQLFormatString(current) + " "));
				}
				text2 = text2 + text3 + ")";
			}
			val4.SelectionFormula = text2;
			val4.HumanReadableSelectionFormula = "Dal: " + Strings.Format((object)Conversions.ToDate(DataRifInizio.ObjValue.ToString()), "dd/MM/yyyy") + " al: " + Strings.Format((object)Conversions.ToDate(DataRifFine.ObjValue.ToString()), "dd/MM/yyyy");
			((List<ReportLaunchParameters>)(object)val3).Add(val4);
			string PdfFile = "";
			val2 = AvviaStampa(val3, VisualizzaStampa: true, ref PdfFile, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			result = val;
		}
		return result;
	}
}
