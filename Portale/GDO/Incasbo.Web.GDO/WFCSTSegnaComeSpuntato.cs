using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFCSTSegnaComeSpuntato : WFIDialogPage
{
	protected string _Mode;

	protected DataTable _dtDettaglio;

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

	[field: AccessedThroughProperty("lblNumeroFattFornitore")]
	protected virtual IboWebLabel lblNumeroFattFornitore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumeroFattForn")]
	protected virtual IboWebNumericTlk NumeroFattForn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFatturaFornitore")]
	protected virtual IboWebLabel lblDataFatturaFornitore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataFattForn")]
	protected virtual IboWebDate2 DataFattForn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFCSTSegnaComeSpuntato()
	{
		_Mode = "";
		_dtDettaglio = null;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.CST.SPUNTATO";
		_Title = base.Translator.Translate("XXX", "Spunta dettagli fattura", new string[0]);
		if (((Page)this).IsPostBack)
		{
			_dtDettaglio = (DataTable)_SessionVariable["DTDETTAGLIO"];
		}
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
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = base.CheckData(ref rsMess);
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
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if ((Operators.CompareString(NumeroFattForn.Text, "", false) == 0) | (Operators.CompareString(DataFattForn.Text, "", false) == 0))
			{
				rsMess = TranslateMessage("XXX", "Inserire Numero e Data Fattura Fornitore");
				goto IL_00b8;
			}
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				goto IL_00b8;
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
			CallStackRemove();
			result = val;
		}
		result = base.AfterCheckData(ref rsMess);
		goto IL_00b8;
		IL_00b8:
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Invalid comparison between Unknown and I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Invalid comparison between Unknown and I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			FunctionArguments functionArguments = (FunctionArguments)_SessionVariable["PARAMS_FUNCARGS"];
			string text2 = "";
			if (functionArguments.Data.Count > 0)
			{
				text2 = functionArguments.Data.GetAllElementSqlWhere();
				text2 = "SELECT * FROM Fatture_Passive_Dettaglio WHERE 1=1 " + text2;
				val2 = base.DbConn.OpenDataTable(text2, ref _dtDettaglio, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					_SessionVariable["DTDETTAGLIO"] = _dtDettaglio;
					int num = 0;
					int num2 = checked(_dtDettaglio.Rows.Count - 1);
					num = 0;
					while (true)
					{
						if (num <= num2)
						{
							if (Operators.CompareString(_dtDettaglio.Rows[num]["Unibol"].ToString(), "", false) == 0)
							{
								DBConnection dbConn = base.DbConn;
								int num3 = Conversions.ToInteger(_dtDettaglio.Rows[num]["IdViaggio"]);
								text = "SELECT * from CST_VIAGGI WHERE idViaggio = " + dbConn.SQLFormatNumber(ref num3) + " ";
								text += "AND NumeroFattForn <> '' ";
								val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
									break;
								}
								if (dataTable.Rows.Count > 0)
								{
									rsMess = TranslateMessage("XXX", "Uno o più record risultano già spuntati");
									break;
								}
							}
							else
							{
								text = "SELECT * from CST_SPEDIZIONI WHERE UNIBOL = " + base.DbConn.SQLFormatString(_dtDettaglio.Rows[num]["Unibol"].ToString()) + " ";
								text += "AND NumeroFattForn <> '' ";
								val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
									break;
								}
								if (dataTable.Rows.Count > 0)
								{
									rsMess = TranslateMessage("XXX", "Uno o più record risultano già spuntati");
									break;
								}
							}
							num = checked(num + 1);
							continue;
						}
						val2 = base.AfterLoadData(ref rsMess);
						if ((int)val2 <= 0)
						{
							val = (FXRETURN)0;
						}
						break;
					}
				}
			}
			else
			{
				rsMess = TranslateMessage("XXX", "Selezionare almeno un record");
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
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		int num = 0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			checked
			{
				int num2 = _dtDettaglio.Rows.Count - 1;
				for (num = 0; num <= num2; num++)
				{
					if (Operators.CompareString(_dtDettaglio.Rows[num]["Unibol"].ToString(), "", false) == 0)
					{
						text = text + "UPDATE CST_VIAGGI SET NumeroFattForn = " + base.DbConn.SQLFormatString(NumeroFattForn.Text) + ", ";
						text = text + "DataFattForn = " + base.DbConn.SQLFormatDate((eTipoData)2, DataFattForn.Text);
						string text2 = text;
						DBConnection dbConn = base.DbConn;
						int num3 = Conversions.ToInteger(_dtDettaglio.Rows[num]["IdViaggio"]);
						text = text2 + " WHERE idViaggio = " + dbConn.SQLFormatNumber(ref num3) + ";\r\n";
					}
					else
					{
						text = text + "UPDATE CST_SPEDIZIONI SET NumeroFattForn = " + base.DbConn.SQLFormatString(NumeroFattForn.Text) + ", ";
						text = text + "DataFattForn = " + base.DbConn.SQLFormatDate((eTipoData)2, DataFattForn.Text);
						text = text + " WHERE Unibol = " + base.DbConn.SQLFormatString(_dtDettaglio.Rows[num]["Unibol"].ToString()) + ";\r\n";
					}
				}
				val2 = base.DbConn.SqlExec(text, ref rsMess);
			}
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
			result = val;
		}
		return result;
	}
}
