using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.Library;

public class IboWebParam
{
	private DataTable ParametriFiliale;

	private DataTable ParametriTotali;

	private bool CaricamentoAvvenuto;

	private DBConnection _objDbConnection;

	private IboAppCallStackHandling _objCallStackHandler;

	private IboAppLogHandling _objLogHandling;

	private IncasTranslator _objTranslator;

	public IboWebParam(ref DBConnection rObjDbConnection, ref IboAppCallStackHandling robjCallStackHandler, ref IboAppLogHandling robjLogHandling, ref IncasTranslator robjTranslator)
	{
		CaricamentoAvvenuto = false;
		_objDbConnection = rObjDbConnection;
		_objCallStackHandler = robjCallStackHandler;
		_objLogHandling = robjLogHandling;
		_objTranslator = robjTranslator;
	}

	private void CallStackAdd()
	{
		_objCallStackHandler.CallStackAdd();
	}

	private void CallStackRemove()
	{
		_objCallStackHandler.CallStackRemove();
	}

	public IboWebParam Clone(DBConnection dbConn)
	{
		IboWebParam result;
		try
		{
			IboWebParam iboWebParam = new IboWebParam(ref dbConn, ref _objCallStackHandler, ref _objLogHandling, ref _objTranslator);
			modGeneral.CloneDataTable(ParametriFiliale, ref iboWebParam.ParametriFiliale);
			modGeneral.CloneDataTable(ParametriTotali, ref iboWebParam.ParametriTotali);
			iboWebParam.CaricamentoAvvenuto = CaricamentoAvvenuto;
			result = iboWebParam;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public FXRETURN CaricaParametri(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		CallStackAdd();
		rsMess = "";
		FXRETURN result;
		try
		{
			if (CaricamentoAvvenuto)
			{
				goto IL_006c;
			}
			ParametriFiliale = null;
			ParametriTotali = null;
			string vsSQLClause = "SELECT * FROM VW_WFI_PARAMETRICA WHERE TipoDato<>'CONT'";
			val = _objDbConnection.OpenDataTable(vsSQLClause, ref ParametriFiliale, ref rsMess);
			if ((int)val == 0)
			{
				vsSQLClause = "SELECT * FROM WFI_PARAMETRICA WHERE TipoDato<>'CONT'";
				val = _objDbConnection.OpenDataTable(vsSQLClause, ref ParametriTotali, ref rsMess);
				if ((int)val == 0)
				{
					CaricamentoAvvenuto = true;
					goto IL_006c;
				}
			}
			goto end_IL_000f;
			IL_006c:
			val = (FXRETURN)0;
			end_IL_000f:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public string ValoreParametro(string vsNome, ref FXRETURN nRes, ref string rsMess)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		string text = "";
		CallStackAdd();
		nRes = (FXRETURN)3;
		rsMess = "";
		string result;
		try
		{
			if (CaricamentoAvvenuto || (int)CaricaParametri(ref rsMess) == 0)
			{
				DataRow[] array = ParametriFiliale.Select("Nome='" + vsNome + "'");
				if (array.Length == 1)
				{
					text = Conversions.ToString(array[0]["Valore"]);
					nRes = (FXRETURN)0;
				}
				else
				{
					rsMess = _objTranslator.TranslateMessage("001", "La chiave {0} non esiste in parametrica.", new string[1] { vsNome });
					nRes = (FXRETURN)14;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			nRes = (FXRETURN)(int)_objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
			CallStackRemove();
		}
		return result;
	}

	public string ValoreParametro(string vsNome)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN nRes = (FXRETURN)0;
		string rsMess = "";
		return ValoreParametro(vsNome, ref nRes, ref rsMess);
	}

	public string ValoreParametro(string vsNome, string vsFiliale)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN nRes = (FXRETURN)0;
		string rsMess = "";
		return ValoreParametro(vsNome, vsFiliale, ref nRes, ref rsMess);
	}

	public string ValoreParametro(string vsNome, string vsFiliale, ref FXRETURN nRes, ref string rsMess)
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected I4, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		CallStackAdd();
		nRes = (FXRETURN)3;
		rsMess = "";
		string result;
		try
		{
			if (CaricamentoAvvenuto || (int)CaricaParametri(ref rsMess) == 0)
			{
				text = ((!((Operators.CompareString(vsFiliale.Trim(), "", false) == 0) | (Operators.CompareString(vsFiliale, "XXX", false) == 0))) ? ("Filiale='" + vsFiliale + "'") : "(Filiale='XXX' OR Filiale=' ')");
				DataRow[] array = ParametriTotali.Select(text + " AND Nome='" + vsNome + "'");
				if (array.Length == 1)
				{
					text2 = Conversions.ToString(array[0]["Valore"]);
					nRes = (FXRETURN)0;
				}
				else if (array.Length > 1)
				{
					rsMess = _objTranslator.TranslateMessage("005", "La chiave {0} per la filiale {1} non è univoca.", new string[2] { vsNome, vsFiliale });
					nRes = (FXRETURN)15;
				}
				else
				{
					rsMess = _objTranslator.TranslateMessage("002", "La chiave {0} per la filiale {1} non esiste in parametrica.", new string[2] { vsNome, vsFiliale });
					nRes = (FXRETURN)14;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			nRes = (FXRETURN)(int)_objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text2;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN RicaricaParametri(ref string rsMess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		CaricamentoAvvenuto = false;
		return CaricaParametri(ref rsMess);
	}

	public FXRETURN LeggiContatore(string vsNomeParametro, bool vbStartTrans, ref long rlReturnValue, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		bool flag = false;
		CallStackAdd();
		rsMess = "";
		FXRETURN result;
		try
		{
			text = "SELECT Valore, Descrizione, Filiale, Tree FROM VW_WFI_PARAMETRICA  WHERE Nome = '" + vsNomeParametro + "' AND TipoDato = 'CONT'";
			if ((int)_objDbConnection.OpenDataTable(text, ref rObjDataTable, ref rsMess) != 0)
			{
				rsMess = _objTranslator.TranslateMessage("004", "Errore nell'accesso ai dati. {0}", new string[1] { rsMess });
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsMess = _objTranslator.TranslateMessage("003", "Contatore {0} non trovato in Parametrica.", new string[1] { vsNomeParametro });
			}
			else
			{
				if (vbStartTrans)
				{
					_objDbConnection.BeginTransaction();
					flag = true;
				}
				text = "UPDATE WFI_PARAMETRICA SET NOME = '" + vsNomeParametro + "' ";
				text = text + " WHERE NOME = '" + vsNomeParametro + "' ";
				text = text + " AND FILIALE = '" + rObjDataTable.Rows[0]["Filiale"].ToString() + "'";
				if ((int)_objDbConnection.SqlExec(text, 1, 1, ref rsMess) != 0)
				{
					rsMess = _objTranslator.TranslateMessage("006", "Errore nell'aggiornamento di {0}. {1}", new string[2] { vsNomeParametro, rsMess });
					val = (FXRETURN)2;
				}
				else
				{
					text = "SELECT Valore, Descrizione, Filiale, Tree FROM VW_WFI_PARAMETRICA  WHERE Nome = '" + vsNomeParametro + "' AND TipoDato = 'CONT'";
					if ((int)_objDbConnection.OpenDataTable(text, ref rObjDataTable, ref rsMess) != 0)
					{
						rsMess = _objTranslator.TranslateMessage("004", "Errore nell'accesso ai dati. {0}", new string[1] { rsMess });
						val = (FXRETURN)2;
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsMess = _objTranslator.TranslateMessage("003", "Contatore {0} non trovato in Parametrica.", new string[1] { vsNomeParametro });
						val = (FXRETURN)14;
					}
					else
					{
						long num = Conversions.ToLong(Operators.AddObject(rObjDataTable.Rows[0]["Valore"], (object)1));
						text = "UPDATE WFI_PARAMETRICA SET Valore = '" + num + "'";
						text = text + " WHERE Nome = '" + vsNomeParametro + "' AND Filiale = '" + rObjDataTable.Rows[0]["Filiale"].ToString() + "'";
						if ((int)_objDbConnection.SqlExec(text, 1, 1, ref rsMess) != 0)
						{
							rsMess = _objTranslator.TranslateMessage("006", "Errore nell'aggiornamento di {0}. {1}", new string[2] { vsNomeParametro, rsMess });
							val = (FXRETURN)2;
						}
						else
						{
							rlReturnValue = num;
							if (flag)
							{
								_objDbConnection.CommitTransaction();
								flag = false;
							}
							val = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag)
			{
				_objDbConnection.RollbackTransaction();
				flag = false;
			}
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LeggiContatore(string vsNomeParametro, ref long rlReturnValue, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LeggiContatore(vsNomeParametro, !_objDbConnection.TransactionOpen, ref rlReturnValue, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LeggiContatore(string vsNomeParametro, string vsFiliale, bool vbStartTrans, ref long rlReturnValue, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Invalid comparison between Unknown and I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Invalid comparison between Unknown and I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		bool flag = false;
		CallStackAdd();
		rsMess = "";
		FXRETURN result;
		try
		{
			text = "SELECT Valore, Descrizione, Filiale, Tree FROM WFI_PARAMETRICA ";
			text = text + " WHERE Nome = '" + vsNomeParametro + "'";
			text = text + " AND Filiale = '" + vsFiliale + "'";
			text += " AND TipoDato = 'CONT'";
			if ((int)_objDbConnection.OpenDataTable(text, ref rObjDataTable, ref rsMess) != 0)
			{
				rsMess = _objTranslator.TranslateMessage("004", "Errore nell'accesso ai dati. {0}", new string[1] { rsMess });
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsMess = _objTranslator.TranslateMessage("007", "Contatore {0} per la filiale {1} non trovato in Parametrica.", new string[2] { vsNomeParametro, vsFiliale });
			}
			else
			{
				if (vbStartTrans)
				{
					_objDbConnection.BeginTransaction();
					flag = true;
				}
				text = "UPDATE WFI_PARAMETRICA SET NOME = '" + vsNomeParametro + "' ";
				text = text + " WHERE NOME = '" + vsNomeParametro + "' ";
				text = text + " AND FILIALE = '" + vsFiliale + "'";
				if ((int)_objDbConnection.SqlExec(text, 1, 1, ref rsMess) != 0)
				{
					rsMess = _objTranslator.TranslateMessage("008", "Errore nell'aggiornamento di {0} per la filiale {1}. {2}", new string[3] { vsNomeParametro, vsFiliale, rsMess });
				}
				else
				{
					text = "SELECT Valore, Descrizione, Filiale, Tree FROM WFI_PARAMETRICA ";
					text = text + " WHERE Nome = '" + vsNomeParametro + "'";
					text = text + " AND Filiale = '" + vsFiliale + "'";
					text += " AND TipoDato = 'CONT'";
					if ((int)_objDbConnection.OpenDataTable(text, ref rObjDataTable, ref rsMess) != 0)
					{
						rsMess = _objTranslator.TranslateMessage("004", "Errore nell'accesso ai dati. {0}", new string[1] { rsMess });
					}
					else if (rObjDataTable.Rows.Count == 0)
					{
						rsMess = _objTranslator.TranslateMessage("007", "Contatore {0} per la filiale {1} non trovato in Parametrica.", new string[2] { vsNomeParametro, vsFiliale });
						val = (FXRETURN)14;
					}
					else
					{
						long num = Conversions.ToLong(Operators.AddObject(rObjDataTable.Rows[0]["Valore"], (object)1));
						text = "UPDATE WFI_PARAMETRICA SET Valore = '" + num + "'";
						text = text + " WHERE Nome = '" + vsNomeParametro + "' AND Filiale = '" + vsFiliale + "'";
						DBConnection objDbConnection = _objDbConnection;
						string vsSQLClause = text;
						int riAffectedRows = 1;
						if ((int)objDbConnection.SqlExec(vsSQLClause, ref riAffectedRows, ref rsMess) != 0)
						{
							rsMess = _objTranslator.TranslateMessage("008", "Errore nell'aggiornamento di {0} per la filiale {1}. {2}", new string[3] { vsNomeParametro, vsFiliale, rsMess });
						}
						else
						{
							rlReturnValue = num;
							if (flag)
							{
								_objDbConnection.CommitTransaction();
								flag = false;
							}
							val = (FXRETURN)0;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag)
			{
				_objDbConnection.RollbackTransaction();
				flag = false;
			}
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN LeggiContatore(string vsNomeParametro, string vsFiliale, ref long rlReturnValue, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LeggiContatore(vsNomeParametro, vsFiliale, !_objDbConnection.TransactionOpen, ref rlReturnValue, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public string LeggiParametro(string vsNomeParametro, ref FXRETURN rnRes, ref string rsMess)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I4, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		DataTable rObjDataTable = null;
		CallStackAdd();
		rnRes = (FXRETURN)3;
		rsMess = "";
		string result;
		try
		{
			text2 = "SELECT Valore FROM VW_WFI_PARAMETRICA ";
			text2 = text2 + " WHERE Nome = '" + vsNomeParametro + "'";
			if ((int)_objDbConnection.OpenDataTable(text2, ref rObjDataTable, ref rsMess) != 0)
			{
				rsMess = _objTranslator.TranslateMessage("004", "Errore nell'accesso ai dati. {0}", new string[1] { rsMess });
			}
			else if (rObjDataTable.Rows.Count == 1)
			{
				text = Conversions.ToString(rObjDataTable.Rows[0]["Valore"]);
				rnRes = (FXRETURN)0;
			}
			else if (rObjDataTable.Rows.Count > 1)
			{
				rsMess = _objTranslator.TranslateMessage("009", "La chiave {0} non è univoca.", new string[1] { vsNomeParametro });
				rnRes = (FXRETURN)15;
			}
			else
			{
				rsMess = _objTranslator.TranslateMessage("010", "La chiave {0} non esiste in parametrica.", new string[1] { vsNomeParametro });
				rnRes = (FXRETURN)14;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rnRes = (FXRETURN)(int)_objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
			CallStackRemove();
		}
		return result;
	}
}
