using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class Tariffe_RevisioneImporti : AppAbstractApi
{
	protected List<string> _Id;

	protected string _AttivoPassivo;

	protected string _TipoVariazione;

	protected bool _Percentuale;

	protected bool _Fisso;

	protected bool _Variabile;

	protected string _Variazione;

	protected decimal _Valore;

	protected string _ViewFasceTariffa;

	protected string _ViewVociTariffa;

	public Tariffe_RevisioneImporti(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Id = null;
		_AttivoPassivo = "";
		_TipoVariazione = "";
		_Percentuale = false;
		_Fisso = false;
		_Variabile = false;
		_Variazione = "";
		_Valore = default(decimal);
		_ViewFasceTariffa = "";
		_ViewVociTariffa = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Id = (List<string>)((AppAbstractApi)this).ParametersIn["Id"];
			_AttivoPassivo = ((AppAbstractApi)this).ParametersIn["AttivoPassivo"].ToString();
			if (Operators.CompareString(_AttivoPassivo, "A", false) == 0)
			{
				_ViewVociTariffa = "TariffeAttiveVoci";
				_ViewFasceTariffa = "TariffeAttiveFasce";
			}
			else
			{
				_ViewVociTariffa = "TariffePassiveVoci";
				_ViewFasceTariffa = "TariffePassiveFasce";
			}
			if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["TipoVariazione"].ToString(), "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Obbligatorio inserire Tipo Variazione (Aumento\\Diminuzione)");
			}
			else
			{
				_TipoVariazione = ((AppAbstractApi)this).ParametersIn["TipoVariazione"].ToString();
				_Percentuale = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["Percentuale"]);
				_Fisso = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["Fisso"]);
				_Variabile = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["Variabile"]);
				if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Variazione"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Obbligatorio inserire Variazione");
				}
				else
				{
					_Variazione = ((AppAbstractApi)this).ParametersIn["Variazione"].ToString();
					_Valore = Conversions.ToDecimal(((AppAbstractApi)this).ParametersIn["Valore"]);
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Invalid comparison between Unknown and I4
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Invalid comparison between Unknown and I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Invalid comparison between Unknown and I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		DataTable rObjDataTable = null;
		decimal num = default(decimal);
		decimal NuovoValoreFascia = default(decimal);
		StringBuilder stringBuilder = new StringBuilder();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			IEnumerator enumerator2 = default(IEnumerator);
			foreach (string item in _Id)
			{
				text = "SELECT IDFASCIA,FISSO,PERCENTUALE,VARIABILE FROM  " + _ViewFasceTariffa + " F INNER JOIN " + _ViewVociTariffa + " V ON V.IDVOCE = F.IDVOCE ";
				text = text + "WHERE IDTARIFFA = " + ((AppBaseClass)this).DbConn.SQLFormatString(item);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val <= 0)
				{
					if (rObjDataTable.Rows.Count <= 0)
					{
						continue;
					}
					{
						enumerator2 = rObjDataTable.Rows.GetEnumerator();
						try
						{
							DataRow dataRow;
							string text2;
							DBConnection dbConn;
							string pNumero;
							for (; enumerator2.MoveNext(); text2 = text, dbConn = ((AppBaseClass)this).DbConn, pNumero = dataRow["IDFASCIA"].ToString(), text = text2 + "WHERE IDFASCIA = " + dbConn.SQLFormatNumber(ref pNumero) + ";", stringBuilder.Append(text))
							{
								dataRow = (DataRow)enumerator2.Current;
								text = "UPDATE " + _ViewFasceTariffa + "  SET ";
								text = text + "UTEAGG = " + this.DbConn.SQLFormatString(this._User) + " ";
								if (!(_Fisso & (decimal.Compare(Conversions.ToDecimal(dataRow["FISSO"].ToString()), 0m) > 0)))
								{
									goto IL_01c0;
								}
								text += ",FISSO = ";
								num = Conversions.ToDecimal(dataRow["FISSO"].ToString());
								val = CalcolaValore(num, ref NuovoValoreFascia, ref rsmess);
								if ((int)val <= 0)
								{
									text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref NuovoValoreFascia) + " ";
									goto IL_01c0;
								}
								val2 = val;
								goto end_IL_0028;
								IL_024d:
								if (!(_Variabile & (decimal.Compare(Conversions.ToDecimal(dataRow["VARIABILE"].ToString()), 0m) > 0)))
								{
									continue;
								}
								text += " ,VARIABILE = ";
								num = Conversions.ToDecimal(dataRow["VARIABILE"].ToString());
								val = CalcolaValore(num, ref NuovoValoreFascia, ref rsmess);
								if ((int)val <= 0)
								{
									text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref NuovoValoreFascia) + " ";
									continue;
								}
								val2 = val;
								goto end_IL_0028;
								IL_01c0:
								if (!(_Percentuale & (decimal.Compare(Conversions.ToDecimal(dataRow["PERCENTUALE"].ToString()), 0m) > 0)))
								{
									goto IL_024d;
								}
								text += ",PERCENTUALE = ";
								num = Conversions.ToDecimal(dataRow["PERCENTUALE"].ToString());
								val = CalcolaValore(num, ref NuovoValoreFascia, ref rsmess);
								if ((int)val <= 0)
								{
									text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref NuovoValoreFascia) + " ";
									goto IL_024d;
								}
								val2 = val;
								goto end_IL_0028;
							}
						}
						finally
						{
							IDisposable disposable = enumerator2 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					continue;
				}
				val2 = val;
				goto end_IL_0028;
			}
			if (stringBuilder.Length <= 0)
			{
				goto IL_0397;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0397;
			}
			val2 = val;
			goto end_IL_0028;
			IL_0397:
			val2 = (FXRETURN)0;
			end_IL_0028:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, List<string> Id, string AttivoPassivo, string TipoVariazione, bool Percentuale, bool Fisso, bool Variabile, string Variazione, decimal Valore, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Tariffe_RevisioneImporti tariffe_RevisioneImporti = new Tariffe_RevisioneImporti(objApiContext);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Id", Id);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("AttivoPassivo", AttivoPassivo);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("TipoVariazione", TipoVariazione);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Percentuale", Percentuale);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Fisso", Fisso);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Variabile", Variabile);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Variazione", Variazione);
		((AppAbstractApi)tariffe_RevisioneImporti).ParametersIn.Add("Valore", Valore);
		return ((AppAbstractApi)tariffe_RevisioneImporti).Run(ref rsmess);
	}

	private FXRETURN CalcolaValore(decimal ValoreFascia, ref decimal NuovoValoreFascia, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		decimal num = default(decimal);
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Variazione, "A", false) == 0)
			{
				if (Operators.CompareString(_TipoVariazione, "A", false) == 0)
				{
					num = decimal.Add(ValoreFascia, _Valore);
				}
				else if (Operators.CompareString(_TipoVariazione, "D", false) == 0)
				{
					num = decimal.Subtract(ValoreFascia, _Valore);
				}
			}
			else if (Operators.CompareString(_Variazione, "P", false) == 0)
			{
				if (Operators.CompareString(_TipoVariazione, "A", false) == 0)
				{
					num = decimal.Add(ValoreFascia, decimal.Multiply(decimal.Divide(ValoreFascia, 100m), _Valore));
				}
				else if (Operators.CompareString(_TipoVariazione, "D", false) == 0)
				{
					num = decimal.Subtract(ValoreFascia, decimal.Multiply(decimal.Divide(ValoreFascia, 100m), _Valore));
				}
			}
			if (decimal.Compare(num, 0m) < 0)
			{
				rsmess = this.TranslateMessage("XXX", "Impossibile Variare gli importi. Valore Negativo");
			}
			else
			{
				NuovoValoreFascia = num;
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
}
