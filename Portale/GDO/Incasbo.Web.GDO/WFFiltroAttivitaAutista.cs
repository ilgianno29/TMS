using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFFiltroAttivitaAutista : WFIGridFilterPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DataAttivita")]
	private IboWebComboTlk _DataAttivita;

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

	[field: AccessedThroughProperty("cmbAutista")]
	protected virtual IboWebComboTlk cmbAutista
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblData")]
	protected virtual IboWebLabel lblData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk DataAttivita
	{
		[CompilerGenerated]
		get
		{
			return _DataAttivita;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(DataAttivita_SelectedIndexChanged);
			IboWebComboTlk dataAttivita = _DataAttivita;
			if (dataAttivita != null)
			{
				((RadComboBox)dataAttivita).SelectedIndexChanged -= val;
			}
			_DataAttivita = value;
			dataAttivita = _DataAttivita;
			if (dataAttivita != null)
			{
				((RadComboBox)dataAttivita).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblDaData")]
	protected virtual IboWebLabel lblDaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DaData")]
	protected virtual IboWebDate DaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAData")]
	protected virtual IboWebLabel lblAData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AData")]
	protected virtual IboWebDate AData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GiornoCorrente")]
	protected virtual IboWebDate GiornoCorrente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MeseCorrente")]
	protected virtual IboWebDate MeseCorrente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ultimi10Giorni")]
	protected virtual IboWebDate Ultimi10Giorni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ultimi20Giorni")]
	protected virtual IboWebDate Ultimi20Giorni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ultimi30Giorni")]
	protected virtual IboWebDate Ultimi30Giorni
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
		_Context = "DM.DOC.AUTISTI.ATTIVITA#GG";
		_Title = base.Translator.Translate("XXX", "Filtro Attività Autista Giornaliera", new string[0]);
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
				cmbAutista.SqlQueryFilter = base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto;
				IboWebComboTlk objCombo = cmbAutista;
				FXRETURN val3 = LoadSingleCombo(ref objCombo, ref rsMess);
				cmbAutista = objCombo;
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
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlWhere = "";
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
			else if ((Operators.CompareString(DataAttivita.ObjValue.ToString(), "", false) == 0) & (Operators.CompareString(cmbAutista.ObjValue.ToString(), "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire almeno 1 tra Data e Autista");
			}
			else
			{
				if (Operators.CompareString(DataAttivita.ObjValue.ToString(), "50", false) != 0)
				{
					goto IL_017f;
				}
				if (Operators.CompareString(DaData.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire Da Data");
				}
				else if (Operators.CompareString(AData.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire A Data");
				}
				else
				{
					if (DateTime.Compare(Conversions.ToDate(AData.ObjValue), Conversions.ToDate(DaData.ObjValue)) >= 0)
					{
						goto IL_017f;
					}
					rsMess = TranslateMessage("XXX", "Data di fine minore della data di inizio");
				}
			}
			goto end_IL_0015;
			IL_017f:
			val2 = GeneraWhere(ref ssqlWhere, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				text = "SELECT COUNT(*) FROM GRD_DOC_Autisti_Attivita_GG WHERE 1=1 ";
				if (Operators.CompareString(cmbAutista.ObjValue.ToString(), "", false) != 0)
				{
					text = text + "AND AUTISTA = " + base.DbConn.SQLFormatString(cmbAutista.ObjValue.ToString()) + " ";
				}
				else if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.OrganizzazioneInternaEsterna, "E", false) == 0)
				{
					text = text + "AND " + base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto + " ";
				}
				text += ssqlWhere;
				val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Conversions.ToInteger(obj) == 0)
				{
					rsMess = TranslateMessage("XXX", "Nessuna Attività Autista trovata per i parametri selezionati");
				}
				else
				{
					val = (FXRETURN)0;
				}
			}
			end_IL_0015:;
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

	protected void DataAttivita_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Invalid comparison between Unknown and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string vsMessaggio = "";
		try
		{
			DaData.ObjValue = "";
			AData.ObjValue = "";
			GiornoCorrente.ObjValue = "";
			MeseCorrente.ObjValue = "";
			Ultimi10Giorni.ObjValue = "";
			Ultimi20Giorni.ObjValue = "";
			Ultimi30Giorni.ObjValue = "";
			switch (DataAttivita.ObjValue.ToString())
			{
			case "1":
				GiornoCorrente.ObjValue = DateAndTime.Now;
				break;
			case "10":
				Ultimi10Giorni.ObjValue = DateAndTime.Now;
				break;
			case "20":
				Ultimi20Giorni.ObjValue = DateAndTime.Now;
				break;
			case "30":
				Ultimi30Giorni.ObjValue = DateAndTime.Now;
				break;
			case "40":
				MeseCorrente.ObjValue = DateAndTime.Now;
				break;
			}
			if (Operators.CompareString(DataAttivita.ObjValue.ToString(), "50", false) == 0)
			{
				lblDaData.Visible = true;
				DaData.Visible = true;
				lblAData.Visible = true;
				AData.Visible = true;
				SetIncasFocusToControl((Control)(object)DaData);
			}
			else
			{
				lblDaData.Visible = false;
				DaData.Visible = false;
				lblAData.Visible = false;
				AData.Visible = false;
				((Page)this).SetFocus((Control)(object)DataAttivita);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			vsMessaggio = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(vsMessaggio);
			}
		}
	}

	private FXRETURN GeneraWhere(ref string ssqlWhere, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			ssqlWhere = "";
			rsMess = "";
			switch (DataAttivita.ObjValue.ToString())
			{
			case "1":
				ssqlWhere = "AND DATA = " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + " ";
				break;
			case "10":
				ssqlWhere = "AND DATA >= " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now.AddDays(-10.0)) + " ";
				break;
			case "20":
				ssqlWhere = "AND DATA >= " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now.AddDays(-20.0)) + " ";
				break;
			case "30":
				ssqlWhere = "AND DATA >= " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now.AddDays(-30.0)) + " ";
				break;
			case "40":
				ssqlWhere = "AND MONTH(DATA)=" + Conversions.ToString(DateAndTime.Now.Date.Month) + " AND YEAR(DATA)=" + Conversions.ToString(DateAndTime.Now.Date.Year) + " ";
				break;
			case "50":
				ssqlWhere = "AND (DATA >= " + base.DbConn.SQLFormatDate((eTipoData)1, DaData.ObjValue.ToString()) + " ";
				ssqlWhere = ssqlWhere + "AND DATA <= " + base.DbConn.SQLFormatDate((eTipoData)1, AData.ObjValue.ToString()) + ") ";
				break;
			}
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
			result = val;
		}
		return result;
	}
}
