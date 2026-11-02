using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo.Tariffe;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo;

public class ViaggiUI : WFIDBPageMasterDetail
{
	[field: AccessedThroughProperty("txtIdViaggio")]
	protected virtual IboWebTextBox txtIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Peso")]
	protected virtual IboWebNumericTlk Peso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Volume")]
	protected virtual IboWebNumericTlk Volume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Pallet")]
	protected virtual IboWebNumericTlk Pallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Colli")]
	protected virtual IboWebNumericTlk Colli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Contrassegno")]
	protected virtual IboWebNumericTlk Contrassegno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo1")]
	protected virtual IboWebNumericTlk CampoCalcolo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo2")]
	protected virtual IboWebNumericTlk CampoCalcolo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo3")]
	protected virtual IboWebNumericTlk CampoCalcolo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo4")]
	protected virtual IboWebNumericTlk CampoCalcolo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo5")]
	protected virtual IboWebNumericTlk CampoCalcolo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo6")]
	protected virtual IboWebNumericTlk CampoCalcolo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo7")]
	protected virtual IboWebNumericTlk CampoCalcolo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo8")]
	protected virtual IboWebNumericTlk CampoCalcolo8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo9")]
	protected virtual IboWebNumericTlk CampoCalcolo9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CampoCalcolo10")]
	protected virtual IboWebNumericTlk CampoCalcolo10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumSpedizioni")]
	protected virtual IboWebNumericTlk NumSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumConsegne")]
	protected virtual IboWebNumericTlk NumConsegne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CostiPrimari")]
	protected virtual IboWebNumericTlk CostiPrimari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Ricavi")]
	protected virtual IboWebNumericTlk Ricavi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CostiSecondari")]
	protected virtual IboWebNumericTlk CostiSecondari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Margine")]
	protected virtual IboWebNumericTlk Margine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Immagine")]
	protected virtual Image Immagine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			CostiPrimari.WFIMinValue = 0.0 - CostiPrimari.WFIMaxValue;
			((RadNumericTextBox)CostiPrimari).MinValue = 0.0 - ((RadNumericTextBox)CostiPrimari).MaxValue;
			CostiSecondari.WFIMinValue = 0.0 - CostiSecondari.WFIMaxValue;
			((RadNumericTextBox)CostiSecondari).MinValue = 0.0 - ((RadNumericTextBox)CostiSecondari).MaxValue;
			Ricavi.WFIMinValue = 0.0 - Ricavi.WFIMaxValue;
			((RadNumericTextBox)Ricavi).MinValue = 0.0 - ((RadNumericTextBox)Ricavi).MaxValue;
			Margine.WFIMinValue = 0.0 - Margine.WFIMaxValue;
			((RadNumericTextBox)Margine).MinValue = 0.0 - ((RadNumericTextBox)Margine).MaxValue;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		FXRETURN val = base.InitializedPage(ref rsMess);
		FXRETURN result = default(FXRETURN);
		return result;
	}

	protected override FXRETURN InternalGridAfterCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = CalcolaTotaleCostiRicavi(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = base.InternalGridAfterCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected FXRETURN CheckModificaCostiRicavi(string Id, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT IDFATTURAPASSIVA,TIPOCALCOLO FROM VIAGGI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile modificare il costo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_023d;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_023d;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO FROM VIAGGI_RICAVI VR INNER JOIN VIAGGI V ON V.IDVIAGGIO = VR.IDVIAGGIO WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) != 0)
				{
					rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile modificare il ricavo");
				}
				else
				{
					if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						goto IL_023d;
					}
					rsMess = TranslateMessage("XXX", "Tipo calcolo non manuale o standard impossibile modificare il ricavo");
				}
			}
			goto end_IL_000e;
			IL_023d:
			val = (FXRETURN)0;
			end_IL_000e:;
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

	protected FXRETURN CheckCancellazioneCostiRicavi(string Id, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Invalid comparison between Unknown and I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Invalid comparison between Unknown and I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		string text2 = "";
		string text3 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT IDFATTURAPASSIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM VIAGGI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (dataTable.Rows.Count != 1)
				{
					rsMess = TranslateMessage("XXX", "Impossibile recuperare il record da eliminare.");
				}
				else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
				{
					if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAPASSIVA"].ToString(), "", false) == 0)
					{
						text2 = "DELETE FROM VIAGGI_COSTI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
						goto IL_0450;
					}
					rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile cancellare il costo");
				}
				else
				{
					text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
					text = "SELECT COUNT(*) FROM VIAGGI_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
					text += "AND IDFATTURAPASSIVA IS NOT NULL";
					val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Conversions.ToInteger(obj) <= 0)
						{
							text2 = "DELETE FROM VIAGGI_COSTI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
							goto IL_0450;
						}
						rsMess = TranslateMessage("XXX", "Impossibile cancellare il costo, presente costo già fatturato nel raggruppamento {0}", text3);
					}
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_0450;
				}
				text = "SELECT IDFATTURAATTIVA,TIPOCALCOLO,IDRAGGRUPPAMENTO FROM VIAGGI_RICAVI VR ";
				text += "INNER JOIN VIAGGI V ON V.IDVIAGGIO = VR.IDVIAGGIO ";
				text = text + "WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else if ((Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "MAN", false) == 0) | (Operators.CompareString(dataTable.Rows[0]["TIPOCALCOLO"].ToString(), "STD", false) == 0))
					{
						if (Operators.CompareString(dataTable.Rows[0]["IDFATTURAATTIVA"].ToString(), "", false) == 0)
						{
							text2 = "DELETE FROM VIAGGI_RICAVI WHERE ID = " + base.DbConn.SQLFormatNumber(ref Id);
							goto IL_0450;
						}
						rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile cancellare il ricavo");
					}
					else
					{
						text3 = dataTable.Rows[0]["IDRAGGRUPPAMENTO"].ToString();
						text = "SELECT COUNT(*) FROM VIAGGI_RICAVI VR ";
						text += "INNER JOIN VIAGGI V ON V.IDVIAGGIO = VR.IDVIAGGIO ";
						text = text + "WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3) + " ";
						text += "AND IDFATTURAATTIVA IS NOT NULL";
						val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (Conversions.ToInteger(obj) <= 0)
							{
								text2 = "DELETE FROM VIAGGI_RICAVI WHERE IDRAGGRUPPAMENTO = " + base.DbConn.SQLFormatString(text3);
								goto IL_0450;
							}
							rsMess = TranslateMessage("XXX", "Impossibile cancellare il ricavo, presente consegna già fatturata nel raggruppamento {0}", text3);
						}
					}
				}
			}
			goto end_IL_001f;
			IL_0485:
			val = (FXRETURN)0;
			goto end_IL_001f;
			IL_0450:
			if (Operators.CompareString(text2, "", false) == 0)
			{
				goto IL_0485;
			}
			val2 = base.DbConn.SqlExec(text2, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0485;
			}
			val = val2;
			end_IL_001f:;
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

	protected FXRETURN CheckInserimentoCostiRicavi(string IdViaggio, string Tipologia, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		object obj = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tipologia, "C", false) == 0)
			{
				text = "SELECT IDFATTURAPASSIVA  FROM VIAGGI WHERE IDVIAGGIO = " + base.DbConn.SQLFormatString(IdViaggio);
				val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0)
					{
						goto IL_012c;
					}
					rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile inserire il costo");
				}
			}
			else
			{
				if (Operators.CompareString(Tipologia, "R", false) != 0)
				{
					goto IL_012c;
				}
				text = "SELECT IDFATTURAATTIVA FROM VIAGGI WHERE IDVIAGGIO = " + base.DbConn.SQLFormatString(IdViaggio);
				val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0)
					{
						goto IL_012c;
					}
					rsMess = TranslateMessage("XXX", "Il viaggio è fatturato, non è possibile inserire il ricavo");
				}
			}
			goto end_IL_000e;
			IL_012c:
			val = (FXRETURN)0;
			end_IL_000e:;
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

	protected FXRETURN CalcolaTotaleCostiRicavi(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Invalid comparison between Unknown and I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (!(!Information.IsNothing((object)CostiPrimari) & !Information.IsNothing((object)Ricavi) & !Information.IsNothing((object)CostiSecondari) & !Information.IsNothing((object)Margine) & !Information.IsNothing((object)Immagine)))
			{
				goto IL_04c5;
			}
			string text = "";
			DataTable dataTable = null;
			text = "SELECT ";
			text = text + "(SELECT SUM(VC.ImportoArrotondato) FROM Viaggi_Costi VC WHERE VC.RecordZZ='N' AND VC.IdViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + ") AS CostiViaggio, ";
			text = text + "(SELECT SUM(VR.ImportoArrotondato) FROM Viaggi_Ricavi VR WHERE VR.RecordZZ='N' AND VR.IdViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + ") AS RicaviViaggio, ";
			text = text + "(SELECT SUM(RC.ImportoArrotondato) FROM Spedizioni_Ricavi RC WHERE RC.RecordZZ='N' AND RC.Unibol IN (SELECT Unibol FROM Spedizioni S WHERE S.IdViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + ")) AS RicaviSpedizioni, ";
			text = text + "(SELECT SUM(SC.ImportoArrotondato) FROM Spedizioni_Costi SC WHERE SC.RecordZZ='N' AND SC.Unibol IN (SELECT Unibol FROM Spedizioni S WHERE S.IdViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + ")) AS CostiSpedizioni ";
			text += base.DbConn.FromDual();
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val <= 0)
			{
				if (dataTable.Rows.Count == 1)
				{
					decimal num = default(decimal);
					decimal num2 = default(decimal);
					if (Operators.CompareString(dataTable.Rows[0]["CostiViaggio"].ToString(), "", false) != 0)
					{
						CostiPrimari.ObjValue = Conversions.ToDecimal(dataTable.Rows[0]["CostiViaggio"]);
					}
					if (Operators.CompareString(dataTable.Rows[0]["RicaviViaggio"].ToString(), "", false) != 0)
					{
						num = Conversions.ToDecimal(dataTable.Rows[0]["RicaviViaggio"]);
					}
					if (Operators.CompareString(dataTable.Rows[0]["RicaviSpedizioni"].ToString(), "", false) != 0)
					{
						num2 = Conversions.ToDecimal(dataTable.Rows[0]["RicaviSpedizioni"]);
					}
					Ricavi.ObjValue = decimal.Add(num, num2);
					Ricavi.ToolTip = "Ricavi Viaggio: " + Conversions.ToString(num) + " - Ricavi Spedizioni: " + Conversions.ToString(num2);
					if (Operators.CompareString(dataTable.Rows[0]["CostiSpedizioni"].ToString(), "", false) != 0)
					{
						CostiSecondari.ObjValue = Conversions.ToDecimal(dataTable.Rows[0]["CostiSpedizioni"]);
					}
				}
				checked
				{
					Margine.ObjValue = Conversions.ToInteger(Ricavi.ObjValue) - (Conversions.ToInteger(CostiPrimari.ObjValue) + Conversions.ToInteger(CostiSecondari.ObjValue));
					if (Conversions.ToInteger(Margine.ObjValue) < 0)
					{
						Immagine.ImageUrl = "../images/Circle_Red.png";
						((Control)Immagine).Visible = true;
					}
					else
					{
						decimal d = default(decimal);
						if (Conversions.ToInteger(Ricavi.ObjValue) != 0)
						{
							d = new decimal((double)(Conversions.ToInteger(Margine.ObjValue) * 100) / (double)Conversions.ToInteger(Ricavi.ObjValue));
						}
						int value = base.ApplicationParams.MargineSogliaInferiore();
						int value2 = base.ApplicationParams.MargineSogliaSuperiore();
						if (decimal.Compare(d, new decimal(value2)) > 0)
						{
							Immagine.ImageUrl = "../images/Circle_Green.png";
							((Control)Immagine).Visible = true;
						}
						else if ((decimal.Compare(d, new decimal(value2)) <= 0) & (decimal.Compare(d, new decimal(value)) >= 0))
						{
							Immagine.ImageUrl = "../images/Circle_Orange.png";
							((Control)Immagine).Visible = true;
						}
						else
						{
							Immagine.ImageUrl = "../images/Circle_Red.png";
							((Control)Immagine).Visible = true;
						}
					}
					goto IL_04c5;
				}
			}
			val2 = val;
			goto end_IL_0005;
			IL_04c5:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CalcolaTariffe(string Cliente, string Vettore, ref string UserMessage, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Invalid comparison between Unknown and I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Invalid comparison between Unknown and I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string Warning = "";
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			UserMessage = "";
			AppApiContext objApiContext = CreateApiContext();
			DataTable dataTable = null;
			string text2 = "SELECT UNIBOL FROM Spedizioni WHERE IdViaggio=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString());
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				foreach (DataRow row in dataTable.Rows)
				{
					val2 = SpedizioniAgganciaTariffa_Invoker.Instance.RunProc(objApiContext, row["Unibol"].ToString(), TariffaAttiva: true, TariffaPassiva: true, ref Warning, ref rsmess);
					text = (((int)val2 > 0) ? (text + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text + Warning)));
					if (Operators.CompareString(text, "", false) != 0)
					{
						text += "\r\n";
					}
					UserMessage += text;
				}
				Warning = "";
				text = "";
				val2 = ViaggiAgganciaTariffa_Invoker.Instance.RunProc(objApiContext, txtIdViaggio.ObjValue.ToString(), Operators.CompareString(Cliente, "", false) != 0, Operators.CompareString(Vettore, "", false) != 0, ref Warning, ref rsmess);
				text = (((int)val2 > 0) ? (text + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text + Warning)));
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += "\r\n";
				}
				UserMessage += text;
				val2 = SpedizioniAgganciaTariffaAttivaRaggruppata_Invoker.Instance.RunProc(objApiContext, txtIdViaggio.ObjValue.ToString(), ref Warning, ref rsmess);
				text = (((int)val2 > 0) ? (text + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text + Warning)));
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += "\r\n";
				}
				UserMessage += text;
				val2 = SpedizioniAgganciaTariffaPassivaRaggruppata_Invoker.Instance.RunProc(objApiContext, txtIdViaggio.ObjValue.ToString(), ref Warning, ref rsmess);
				text = (((int)val2 > 0) ? (text + rsmess) : ((Operators.CompareString(Warning, "", false) == 0) ? "" : (text + Warning)));
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += "\r\n";
				}
				UserMessage += text;
				val2 = CalcolaTotaleCostiRicavi(ref rsmess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
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
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN CheckVettoreMotrice(string Motrice, ref string Vettore, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if ((Operators.CompareString(Vettore, "", false) != 0) & (Operators.CompareString(Motrice, "", false) == 0))
			{
				goto IL_01cb;
			}
			if ((Operators.CompareString(Vettore, "", false) != 0) & (Operators.CompareString(Motrice, "", false) != 0))
			{
				object obj = null;
				text = "SELECT Trasportatore FROM Mezzi WHERE CODICE=" + base.DbConn.SQLFormatString(Motrice);
				val = base.DbConn.DoSql(text, (object)"", ref obj, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0 || Operators.CompareString(obj.ToString().ToUpper(), Vettore, false) == 0)
					{
						goto IL_01cb;
					}
					rsmess = TranslateMessage("XXX", "Impossibile assegnare il viaggio al vettore {0} in quanto la motrice {1} non gli appartiene", Vettore, Motrice);
				}
			}
			else
			{
				if (!((Operators.CompareString(Vettore, "", false) == 0) & (Operators.CompareString(Motrice, "", false) != 0)))
				{
					if (!((Operators.CompareString(Vettore, "", false) == 0) & (Operators.CompareString(Motrice, "", false) == 0)))
					{
					}
					goto IL_01cb;
				}
				object obj2 = null;
				text = "SELECT Trasportatore FROM Mezzi WHERE CODICE=" + base.DbConn.SQLFormatString(Motrice);
				val = base.DbConn.DoSql(text, (object)"", ref obj2, ref rsmess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(obj2.ToString(), "", false) != 0)
					{
						Vettore = obj2.ToString();
					}
					goto IL_01cb;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_01cb:
			val2 = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CheckVettoreAutista(string Autista, ref string Vettore, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if ((Operators.CompareString(Vettore, "", false) != 0) & (Operators.CompareString(Autista, "", false) == 0))
			{
				goto IL_01cb;
			}
			if ((Operators.CompareString(Vettore, "", false) != 0) & (Operators.CompareString(Autista, "", false) != 0))
			{
				object obj = null;
				text = "SELECT Trasportatore FROM Autisti WHERE CODICE=" + base.DbConn.SQLFormatString(Autista);
				val = base.DbConn.DoSql(text, (object)"", ref obj, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(obj.ToString(), "", false) == 0 || Operators.CompareString(obj.ToString().ToUpper(), Vettore, false) == 0)
					{
						goto IL_01cb;
					}
					rsmess = TranslateMessage("XXX", "Impossibile assegnare il viaggio al vettore {0} in quanto l'autista {1} non gli appartiene", Vettore, Autista);
				}
			}
			else
			{
				if (!((Operators.CompareString(Vettore, "", false) == 0) & (Operators.CompareString(Autista, "", false) != 0)))
				{
					if (!((Operators.CompareString(Vettore, "", false) == 0) & (Operators.CompareString(Autista, "", false) == 0)))
					{
					}
					goto IL_01cb;
				}
				object obj2 = null;
				text = "SELECT Trasportatore FROM Autisti WHERE CODICE=" + base.DbConn.SQLFormatString(Autista);
				val = base.DbConn.DoSql(text, (object)"", ref obj2, ref rsmess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(obj2.ToString(), "", false) != 0)
					{
						Vettore = obj2.ToString();
					}
					goto IL_01cb;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_01cb:
			val2 = (FXRETURN)0;
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN AggiornaTotaliDiViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			text = "SELECT T1.*,";
			text += "(SELECT SUM (PortataPeso) FROM Mezzi WHERE(Codice = MotricePianificata) OR (Codice = Contenitore1Pianificato) OR (Codice = Contenitore2Pianificato)) AS PortataPeso, ";
			text += "(SELECT SUM (PortataVolume) FROM Mezzi WHERE(Codice = MotricePianificata) OR (Codice = Contenitore1Pianificato) OR (Codice = Contenitore2Pianificato)) AS PortataVolume, ";
			text += "(SELECT SUM (PortataColli) FROM Mezzi WHERE(Codice = MotricePianificata) OR (Codice = Contenitore1Pianificato) OR (Codice = Contenitore2Pianificato)) AS PortataColli, ";
			text += "(SELECT SUM (PortataPallet) FROM Mezzi WHERE(Codice = MotricePianificata) OR (Codice = Contenitore1Pianificato) OR (Codice = Contenitore2Pianificato)) AS PortataPallet ";
			text += "FROM (";
			text += "SELECT %ISNULL%(SUM(PESO * SEGNO),0) AS PESO, %ISNULL%(SUM(COLLI * SEGNO),0) AS COLLI, %ISNULL%(SUM(PALLET * SEGNO),0) AS PALLET, %ISNULL%(SUM(VOLUME * SEGNO),0) AS VOLUME, ";
			text += "%ISNULL%(SUM(CAMPOCALCOLO1 * SEGNO),0) AS CAMPOCALCOLO1, %ISNULL%(SUM(CAMPOCALCOLO2 * SEGNO),0) AS CAMPOCALCOLO2, %ISNULL%(SUM(CAMPOCALCOLO3 * SEGNO),0) AS CAMPOCALCOLO3, ";
			text += "%ISNULL%(SUM(CAMPOCALCOLO4 * SEGNO),0) AS CAMPOCALCOLO4, %ISNULL%(SUM(CAMPOCALCOLO5 * SEGNO),0) AS CAMPOCALCOLO5, %ISNULL%(SUM(CAMPOCALCOLO6 * SEGNO),0) AS CAMPOCALCOLO6, ";
			text += "%ISNULL%(SUM(CAMPOCALCOLO7 * SEGNO),0) AS CAMPOCALCOLO7, %ISNULL%(SUM(CAMPOCALCOLO8 * SEGNO),0) AS CAMPOCALCOLO8, %ISNULL%(SUM(CAMPOCALCOLO9 * SEGNO),0) AS CAMPOCALCOLO9, ";
			text += "%ISNULL%(SUM(CAMPOCALCOLO10 * SEGNO),0) AS CAMPOCALCOLO10, %ISNULL%(SUM(CONTRASSEGNO),0) AS CONTRASSEGNO, ";
			text += "COUNT(UNIBOL) NumeroSpedizioni,";
			text += "COUNT(DISTINCT %ISNULL%(CAST(Corrispondente AS %VARCHAR%(30)),CAST('D-' %+% PCSDestinazione AS %VARCHAR%(30)))) NumeroConsegne ";
			text += ", MAX(T.MotricePianificata) AS MotricePianificata ";
			text += ", MAX(T.Contenitore1Pianificato) AS Contenitore1Pianificato ";
			text += ", MAX(T.Contenitore2pianificato) AS Contenitore2pianificato ";
			text += "FROM (SELECT S.*, V.MotricePianificata, V.Contenitore1Pianificato, V.Contenitore2pianificato, CASE when TS.Is_Consegna='S' THEN +1 WHEN TS.Is_ritiro='S' THEN 0 ELSE 0 END SEGNO ";
			text += "FROM SPEDIZIONI S INNER JOIN Viaggi V ON S.IdViaggio=V.IdViaggio LEFT JOIN TipiServizi TS ON S.Tiposervizio=TS.Codice ";
			text = text + "WHERE S.IDVIAGGIO=" + base.DbConn.SQLFormatString(txtIdViaggio.ObjValue.ToString()) + ") T";
			text += ") T1 ";
			text = base.DbConn.SqlConvertForServer(text);
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count > 0)
				{
					if (!Information.IsNothing((object)Peso))
					{
						decimal? num = null;
						if (Operators.CompareString(dataTable.Rows[0]["PortataPeso"].ToString(), "", false) != 0)
						{
							num = Conversions.ToDecimal(dataTable.Rows[0]["PortataPeso"]);
						}
						Peso.CssClass = "";
						if (!Information.IsNothing((object)num))
						{
							decimal d = Conversions.ToDecimal(dataTable.Rows[0]["PESO"]);
							if ((num.HasValue ? new bool?(decimal.Compare(d, num.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
							{
								Peso.CssClass = "PortataErrore";
							}
						}
						Peso.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["PESO"]);
					}
					if (!Information.IsNothing((object)Volume))
					{
						decimal? num2 = null;
						if (Operators.CompareString(dataTable.Rows[0]["PortataVolume"].ToString(), "", false) != 0)
						{
							num2 = Conversions.ToDecimal(dataTable.Rows[0]["PortataVolume"]);
						}
						Volume.CssClass = "";
						if (!Information.IsNothing((object)num2))
						{
							decimal d = Conversions.ToDecimal(dataTable.Rows[0]["VOLUME"]);
							if ((num2.HasValue ? new bool?(decimal.Compare(d, num2.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
							{
								Volume.CssClass = "PortataErrore";
							}
						}
						Volume.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["VOLUME"]);
					}
					if (!Information.IsNothing((object)Pallet))
					{
						decimal? num3 = null;
						if (Operators.CompareString(dataTable.Rows[0]["PortataPallet"].ToString(), "", false) != 0)
						{
							num3 = Conversions.ToDecimal(dataTable.Rows[0]["PortataPallet"]);
						}
						Pallet.CssClass = "";
						if (!Information.IsNothing((object)num3))
						{
							decimal d = Conversions.ToDecimal(dataTable.Rows[0]["PALLET"]);
							if ((num3.HasValue ? new bool?(decimal.Compare(d, num3.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
							{
								Pallet.CssClass = "PortataErrore";
							}
						}
						Pallet.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["PALLET"]);
					}
					if (!Information.IsNothing((object)Colli))
					{
						decimal? num4 = null;
						if (Operators.CompareString(dataTable.Rows[0]["PortataColli"].ToString(), "", false) != 0)
						{
							num4 = Conversions.ToDecimal(dataTable.Rows[0]["PortataColli"]);
						}
						Colli.CssClass = "";
						if (!Information.IsNothing((object)num4))
						{
							decimal d = Conversions.ToDecimal(dataTable.Rows[0]["COLLI"]);
							if ((num4.HasValue ? new bool?(decimal.Compare(d, num4.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
							{
								Colli.CssClass = "PortataErrore";
							}
						}
						Colli.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["COLLI"]);
					}
					if (!Information.IsNothing((object)Contrassegno))
					{
						Contrassegno.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CONTRASSEGNO"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo1))
					{
						CampoCalcolo1.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO1"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo2))
					{
						CampoCalcolo2.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO2"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo3))
					{
						CampoCalcolo3.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO3"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo4))
					{
						CampoCalcolo4.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO4"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo5))
					{
						CampoCalcolo5.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO5"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo6))
					{
						CampoCalcolo6.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO6"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo7))
					{
						CampoCalcolo7.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO7"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo8))
					{
						CampoCalcolo8.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO8"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo9))
					{
						CampoCalcolo9.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO9"]);
					}
					if (!Information.IsNothing((object)CampoCalcolo10))
					{
						CampoCalcolo10.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["CAMPOCALCOLO10"]);
					}
					if (!Information.IsNothing((object)NumSpedizioni))
					{
						NumSpedizioni.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["NumeroSpedizioni"]);
					}
					if (!Information.IsNothing((object)NumConsegne))
					{
						NumConsegne.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["NumeroConsegne"]);
					}
				}
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

	protected virtual string CreateQueryForSpedizioniRaggru(string IdViaggio)
	{
		string text = "";
		text += "SELECT T.*, CAST(T.IdViaggio AS VARCHAR(10)) %+% ';' %+% T.Tipo %+% ';' %+% T.PCSDESTINAZIONE %+% ';' %+% CAST(T.SequenzaPianificata AS VARCHAR(10)) %+% ';' %+% T.PCSPARTENZA WFIKey, ";
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

	protected virtual string CreateQueryForSpedizioniRaggru_old(string IdViaggio)
	{
		string text = "";
		text += "SELECT T.*, CAST(T.IdViaggio AS VARCHAR(10)) %+% ';' %+% T.Tipo %+% ';' %+% T.PCSDESTINAZIONE %+% ';' %+% CAST(T.SequenzaPianificata AS VARCHAR(10)) WFIKey, ";
		text += "CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
		text += "SELECT  S.IdViaggio,'D' Tipo,";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "S.PCSDESTINAZIONE PCSDESTINAZIONE,";
		text += "MAX(S.DESTINAZIONECLIENTE) DESTINAZIONECLIENTE,";
		text += "MAX(S.PCSDESTINAZIONE_RAGSOC) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(S.PCSDESTINAZIONE_INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(S.PCSDESTINAZIONE_CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(S.PCSDESTINAZIONE_LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(S.PCSDESTINAZIONE_PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(S.PCSDESTINAZIONE_NAZIONE) PCSDESTINAZIONE_NAZIONE,";
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
		text += "FROM SPEDIZIONI S ";
		text = text + "WHERE S.IdViaggio='" + IdViaggio + "' ";
		text += "AND S.CORRISPONDENTE IS NULL ";
		text += "GROUP BY S.IdViaggio, S.PCSDESTINAZIONE ";
		text += " UNION ";
		text += "SELECT  S.IdViaggio,'C' Tipo,";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
		text += "NULL DESTINAZIONECLIENTE,";
		text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,        ";
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
		text += "AND S.CORRISPONDENTE IS NOT NULL ";
		text += "GROUP BY S.IdViaggio, S.CORRISPONDENTE ) T";
		return base.DbConn.SqlConvertForServer(text);
	}

	protected FXRETURN FindUnibolFromGrdConsegne(DataKeyFieldCollection objData, ref List<string> ListOfUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			string[] array = objData.Item(0).get_FieldValues(0).ToString()
				.Split(new char[1] { ';' });
			string text = "";
			DataTable dataTable = null;
			text = "SELECT Unibol FROM Spedizioni WHERE IdViaggio=" + base.DbConn.SQLFormatString(array[0]) + " ";
			text = text + "AND SequenzaPianificata=" + base.DbConn.SQLFormatNumber(ref array[3]);
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in dataTable.Rows)
				{
					ListOfUnibol.Add(row["Unibol"].ToString());
				}
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}
}
