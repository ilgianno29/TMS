using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveConferma : AppAbstractApi
{
	protected long _IdFattura;

	protected long? _Numero;

	protected string _Sezionale;

	protected DateTime _Data;

	protected DataTable _dtfattura;

	protected bool _Contabilizza;

	public FattureAttiveConferma(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Sezionale = "";
		_dtfattura = null;
		_Contabilizza = false;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Invalid comparison between Unknown and I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!((AppAbstractApi)this).ParametersIn.ContainsKey("IdFattura"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Id Fattura non specificato", new string[0]);
			}
			else
			{
				_IdFattura = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["IdFattura"]));
				if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Sezionale"))
				{
					rsMess = this._Translator.TranslateMessage("XXX", "Sezionale non specificato", new string[0]);
				}
				else
				{
					_Sezionale = ((AppAbstractApi)this).ParametersIn["Sezionale"].ToString();
					if (((AppAbstractApi)this).ParametersIn.ContainsKey("Data"))
					{
						_Data = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["Data"]));
					}
					else
					{
						_Data = DateAndTime.Now.Date;
					}
					if (((AppAbstractApi)this).ParametersIn.ContainsKey("Numero"))
					{
						_Numero = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["Numero"]));
					}
					if (((AppAbstractApi)this).ParametersIn.ContainsKey("Contabilizza"))
					{
						_Contabilizza = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["Contabilizza"]);
					}
					((AppAbstractApi)this).ParametersOut.Add("Numero", null);
					string vsSQLClause = "SELECT * FROM FATTURE_ATTIVE_TESTATA WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtfattura, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (_dtfattura.Rows.Count == 0)
					{
						rsMess = this.TranslateMessage("xxx", "Fattura {0} non trovata.", new string[1] { _IdFattura.ToString() });
						val2 = (FXRETURN)5;
					}
					else if (Convert.ToInt64(RuntimeHelpers.GetObjectValue(_dtfattura.Rows[0]["Numero"])) != 0)
					{
						rsMess = this.TranslateMessage("xxx", "La fattura {0} risulta già definitiva.", new string[1] { _IdFattura.ToString() });
						val2 = (FXRETURN)4;
					}
					else
					{
						if (!_Numero.HasValue)
						{
							goto IL_0362;
						}
						vsSQLClause = "SELECT COUNT(*) FROM FATTURE_ATTIVE_TESTATA WHERE Numero = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _Numero) + " ";
						vsSQLClause = vsSQLClause + "AND Sezionale=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale) + " ";
						string text = vsSQLClause;
						DBConnection dbConn = ((AppBaseClass)this).DbConn;
						int pNumero = DateAndTime.Year(_Data);
						vsSQLClause = text + "AND YEAR(Data)=" + dbConn.SQLFormatNumber(ref pNumero) + " ";
						object objRes = null;
						val = ((AppBaseClass)this).DbConn.DoSql(vsSQLClause, ref objRes, ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (Conversions.ToInteger(objRes) <= 0)
							{
								goto IL_0362;
							}
							rsMess = this.TranslateMessage("xxx", "Il numero fattura {0} risulta già utilizzato.", new string[1] { _Numero.ToString() });
						}
					}
				}
			}
			goto end_IL_0005;
			IL_0362:
			val2 = (FXRETURN)0;
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between Unknown and I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			DateTime? Data = default(DateTime?);
			DateTime? Data2 = default(DateTime?);
			DateTime? Data3 = default(DateTime?);
			val = FattureCalcolaDateScadenza_Invoker.Instance.RunProc(this._ApiContext, _IdFattura, Conversions.ToString(_dtfattura.Rows[0]["TipoPagamento"]), _Data, ref Data, ref Data2, ref Data3, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_Numero.HasValue)
				{
					goto IL_012a;
				}
				text = "UPDATE Sezionali SET Numeratore = Numeratore + 1 WHERE ";
				text = text + "Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale);
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					object objRes = null;
					text = "SELECT Numeratore FROM Sezionali WHERE ";
					text = text + "Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale);
					val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsMess);
					if ((int)val <= 0)
					{
						_Numero = Convert.ToInt64(RuntimeHelpers.GetObjectValue(objRes));
						goto IL_012a;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_02ab:
			((AppAbstractApi)this).ParametersOut["Numero"] = _Numero;
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_012a:
			text = "UPDATE Fatture_Attive_Testata SET DatAgg=GETDATE(), UteAgg=" + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + "Data = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data) + ", ";
			text = text + "Sezionale = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale) + ", ";
			if (Data.HasValue)
			{
				text = text + "DataScadenza1 = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Data) + ", ";
			}
			if (Data2.HasValue)
			{
				text = text + "DataScadenza2 = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Data2) + ", ";
			}
			if (Data3.HasValue)
			{
				text = text + "DataScadenza3 = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, Data3) + ",  ";
			}
			text = text + "Numero = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _Numero) + " ";
			text = text + "WHERE IdFattura = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura);
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (!_Contabilizza)
				{
					goto IL_02ab;
				}
				val = FatturePassiveEsporta_Invoker.Instance.RunProc(this._ApiContext, _IdFattura, ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_02ab;
				}
				val2 = val;
			}
			end_IL_000b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
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
