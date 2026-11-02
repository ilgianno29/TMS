using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCGestioneSequenza : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdViaggiSpedizioniRaggruForDD")]
	private IboGridView _grdViaggiSpedizioniRaggruForDD;

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

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
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

	[field: AccessedThroughProperty("txtIdViaggio")]
	protected virtual IboWebTextBox txtIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlOrdinaSpedizioni")]
	protected virtual Panel pnlOrdinaSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiSpedizioniRaggruForDD")]
	protected virtual IboWebPanel pnlViaggiSpedizioniRaggruForDD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdViaggiSpedizioniRaggruForDD
	{
		[CompilerGenerated]
		get
		{
			return _grdViaggiSpedizioniRaggruForDD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.RowSortedByDragAndDropEventHandler val = new IboGridView.RowSortedByDragAndDropEventHandler(grdViaggiSpedizioniRaggruForDD_RowSortedByDragAndDrop);
			IboGridView val2 = _grdViaggiSpedizioniRaggruForDD;
			if (val2 != null)
			{
				val2.RowSortedByDragAndDrop -= val;
			}
			_grdViaggiSpedizioniRaggruForDD = value;
			val2 = _grdViaggiSpedizioniRaggruForDD;
			if (val2 != null)
			{
				val2.RowSortedByDragAndDrop += val;
			}
		}
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.GESTIONE_SEQUENZA";
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.CheckData(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdViaggiSpedizioniRaggruForDD;
			iboInternalGridConfig.InitUi(myViewState, ref objGridView);
			grdViaggiSpedizioniRaggruForDD = objGridView;
			string sSqlStatement = CreateQueryForSpedizioniRaggruDD("0");
			iboInternalGridConfig.Build("DM.DOC.CONSEGNE.SEQUENZA", sSqlStatement, "", "", ((Control)grdViaggiSpedizioniRaggruForDD).ID, "");
			GridConfigList.Add(iboInternalGridConfig);
			grdViaggiSpedizioniRaggruForDD.RowSortable = true;
			val = base.InitializeInternalGrid(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = AggiornaGrigliaSpedizioniRaggruppateForDD(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = base.AfterLoadData(ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
				val = (FXRETURN)0;
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

	protected virtual string CreateQueryForSpedizioniRaggruDD(string IdViaggio)
	{
		string text = "";
		text += "SELECT T.*, CAST(T.IdViaggio AS VARCHAR(10)) %+% ';' %+% T.Tipo %+% ';' %+% T.PCSDESTINAZIONE %+% ';' %+% CAST(T.SequenzaPianificata AS VARCHAR(10)) WFIKey, ";
		text += "CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
		text += "SELECT T1.*, CASE WHEN CORRISP_CODICE IS NULL THEN 'D' ELSE 'C' END Tipo, ";
		text += "%ISNULL%(CORRISP_CODICE,TMP_PCSDESTINAZIONE) PCSDESTINAZIONE,";
		text += "%ISNULL%(CORRISP_RAGSOC,TMP_PCSDESTINAZIONE_RAGSOC) PCSDESTINAZIONE_RAGSOC,";
		text += "%ISNULL%(CORRISP_INDIRIZZO,TMP_PCSDESTINAZIONE_INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "%ISNULL%(CORRISP_CAP,TMP_PCSDESTINAZIONE_CAP) PCSDESTINAZIONE_CAP,";
		text += "%ISNULL%(CORRISP_LOCALITA,TMP_PCSDESTINAZIONE_LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "%ISNULL%(CORRISP_PROVINCIA,TMP_PCSDESTINAZIONE_PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "%ISNULL%(CORRISP_NAZIONE,TMP_PCSDESTINAZIONE_NAZIONE) PCSDESTINAZIONE_NAZIONE ";
		text += "FROM (";
		text += "SELECT  S.IdViaggio, ";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "MAX(S.DESTINAZIONECLIENTE) DESTINAZIONECLIENTE,";
		text += "MAX(S.PCSDESTINAZIONE) TMP_PCSDESTINAZIONE,";
		text += "MAX(S.PCSDESTINAZIONE_RAGSOC) TMP_PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(S.PCSDESTINAZIONE_INDIRIZZO) TMP_PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(S.PCSDESTINAZIONE_CAP) TMP_PCSDESTINAZIONE_CAP,";
		text += "MAX(S.PCSDESTINAZIONE_LOCALITA) TMP_PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(S.PCSDESTINAZIONE_PROVINCIA) TMP_PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(S.PCSDESTINAZIONE_NAZIONE) TMP_PCSDESTINAZIONE_NAZIONE,";
		text += "MAX(S.PCSPARTENZA) PCSPARTENZA,";
		text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
		text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
		text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
		text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
		text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
		text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
		text += "MAX(S.CORRISPONDENTE) CORRISP_CODICE,";
		text += "MAX(C.RAGIONESOCIALE) CORRISP_RAGSOC,";
		text += "MAX(C.INDIRIZZO) CORRISP_INDIRIZZO,";
		text += "MAX(C.CAP) CORRISP_CAP,";
		text += "MAX(C.LOCALITA) CORRISP_LOCALITA,";
		text += "MAX(C.PROVINCIA) CORRISP_PROVINCIA,";
		text += "MAX(C.NAZIONE) CORRISP_NAZIONE,";
		text += "SUM(S.PESO) PESO,";
		text += "SUM(S.COLLI) COLLI,";
		text += "SUM(S.PALLET) PALLET,";
		text += "SUM(S.VOLUME) VOLUME,";
		text += "SUM(S.CAMPOCALCOLO1) CAMPOCALCOLO1,";
		text += "SUM(S.CAMPOCALCOLO2) CAMPOCALCOLO2,";
		text += "SUM(S.CAMPOCALCOLO3) CAMPOCALCOLO3,";
		text += "SUM(S.CAMPOCALCOLO4) CAMPOCALCOLO4,";
		text += "SUM(S.CAMPOCALCOLO5) CAMPOCALCOLO5,";
		text += "SUM(S.CAMPOCALCOLO6) CAMPOCALCOLO6,";
		text += "SUM(S.CAMPOCALCOLO7) CAMPOCALCOLO7,";
		text += "SUM(S.CAMPOCALCOLO8) CAMPOCALCOLO8,";
		text += "SUM(S.CAMPOCALCOLO9) CAMPOCALCOLO9,";
		text += "SUM(S.CAMPOCALCOLO10) CAMPOCALCOLO10,";
		text += "SUM(S.CONTRASSEGNO) CONTRASSEGNO ";
		text += "FROM SPEDIZIONI S LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
		text = text + "WHERE S.IdViaggio='" + IdViaggio + "' ";
		text += "GROUP BY S.IdViaggio, S.SequenzaPianificata";
		text += ") T1 ";
		text += ") T";
		return base.DbConn.SqlConvertForServer(text);
	}

	private FXRETURN AggiornaGrigliaSpedizioniRaggruppateForDD(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggruForDD).ID];
			string sqlStatement = (objInternalGridConfig.SqlOriginalStatement = CreateQueryForSpedizioniRaggruDD("<%IDVIAGGIO%>"));
			objInternalGridConfig.SqlStatement = sqlStatement;
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
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
			result = val;
		}
		return result;
	}

	private void grdViaggiSpedizioniRaggruForDD_RowSortedByDragAndDrop(object sender, RowSortedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Invalid comparison between Unknown and I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Invalid comparison between Unknown and I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			string[] array = e.Stop_Rowkey.Split(new char[1] { ';' });
			string text = array[0];
			string text2 = array[1];
			string text3 = array[2];
			int num = Conversions.ToInteger(array[3]);
			int num2 = Conversions.ToInteger(array[3]);
			string[] array2 = new string[0];
			string text4 = "";
			string text5 = "";
			string text6 = "";
			int num3 = default(int);
			if (Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0)
			{
				array2 = e.Stop_RowkeyAfter.Split(new char[1] { ';' });
				text4 = array2[0];
				text5 = array2[1];
				text6 = array2[2];
				num3 = Conversions.ToInteger(array2[3]);
			}
			string[] array3 = new string[0];
			string text7 = "";
			string text8 = "";
			string text9 = "";
			int num4 = default(int);
			if (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0)
			{
				array3 = e.Stop_RowkeyPrevious.Split(new char[1] { ';' });
				text7 = array3[0];
				text8 = array3[1];
				text9 = array3[2];
				num4 = Conversions.ToInteger(array3[3]);
			}
			checked
			{
				if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0))
				{
					num2 = (int)Math.Round((double)(num4 + num3) / 2.0);
				}
				else if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) == 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) != 0))
				{
					num2 = num4 + 10;
				}
				else if ((Operators.CompareString(e.Stop_RowkeyAfter, "", false) != 0) & (Operators.CompareString(e.Stop_RowkeyPrevious, "", false) == 0))
				{
					num2 = 1;
				}
				string text10 = "";
				text10 = "UPDATE SPEDIZIONI SET SEQUENZAPIANIFICATA=" + base.DbConn.SQLFormatNumber(ref num2) + " ";
				text10 = text10 + "WHERE IdViaggio=" + base.DbConn.SQLFormatString(text) + " ";
				text10 += "AND SEQUENZAPIANIFICATA = 0";
				base.DbConn.BeginTransaction();
				val2 = base.DbConn.SqlExec(text10, ref rsmess);
			}
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			Viaggio_DeterminaSequenzaSpedizioni_Invoker instance = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance;
			AppApiContext objApiContext = CreateApiContext();
			string RetQueryToApply = "";
			val2 = instance.RunProc(objApiContext, text, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			base.DbConn.CommitTransaction();
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioniRaggruForDD).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsmess);
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			base.DbConn.RollbackTransaction();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}
}
