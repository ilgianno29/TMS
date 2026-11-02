using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_AttivaLibera_Esita : GdoAbstractApi
{
	protected string _Unibol;

	protected string _Esito;

	protected string _CodiceEvento;

	protected DateTime? _DataEvento;

	protected DataTable _dtSpedizione;

	protected string _Viaggio_TipoViaggio;

	public Spedizione_AttivaLibera_Esita(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_Esito = "";
		_CodiceEvento = "";
		_Viaggio_TipoViaggio = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Esito = ((AppAbstractApi)this).ParametersIn["Esito"].ToString();
			_CodiceEvento = ((AppAbstractApi)this).ParametersIn["CodiceEvento"].ToString();
			_DataEvento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEvento"];
			if (!_DataEvento.HasValue)
			{
				_DataEvento = DateAndTime.Now;
			}
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if ((Operators.CompareString(_Esito, "OK", false) != 0) & (Operators.CompareString(_Esito, "KO", false) != 0))
			{
				rsmess = this.TranslateMessage("", "Esito non previsto.");
			}
			else
			{
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Viaggio_TipoViaggio = base.ApplicationDefault.TipoViaggio_FermoDeposito();
			if (Operators.CompareString(_Viaggio_TipoViaggio, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Tipo viaggio di fermo deposito non configurato");
			}
			else
			{
				Viaggio Viaggio = new Viaggio();
				Viaggio.TipoViaggio = _Viaggio_TipoViaggio;
				List<string> ListOfUnibol = new List<string>();
				ListOfUnibol.Add(_Unibol);
				val = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(this._ApiContext, ref Viaggio, ref ListOfUnibol, "", _DataEvento, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Viaggio_Chiudi_Invoker.Instance.RunProc(this._ApiContext, Viaggio.IdViaggio, _DataEvento, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = Viaggio_Partenza_Invoker.Instance.RunProc(this._ApiContext, Viaggio.IdViaggio, _DataEvento, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							string esito = _Esito;
							if (Operators.CompareString(esito, "OK", false) != 0)
							{
								if (Operators.CompareString(esito, "KO", false) == 0)
								{
									val = Spedizione_ConsegnaKO_Invoker.Instance.RunProc(this._ApiContext, _Unibol, _CodiceEvento, _DataEvento, "", "", ref rsmess);
								}
							}
							else
							{
								val = Spedizione_ConsegnaOk_Invoker.Instance.RunProc(this._ApiContext, _Unibol, _CodiceEvento, _DataEvento, "", "", ref rsmess);
							}
							val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
						}
					}
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.* FROM Spedizioni S ";
			text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else
			{
				DataRow dataRow = _dtSpedizione.Rows[0];
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IdViaggio"])))
				{
					rsmess = this.TranslateMessage("", "La spedizione con Id {0} risulta associata al viaggio {1}.", new string[2]
					{
						_Unibol,
						dataRow["IdViaggio"].ToString()
					});
				}
				else if (Conversions.ToInteger(dataRow["Stato"]) != 20)
				{
					rsmess = this.TranslateMessage("", "La spedizione con Id {0} non è in stato 'Attiva'", new string[1] { _Unibol });
				}
				else
				{
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
