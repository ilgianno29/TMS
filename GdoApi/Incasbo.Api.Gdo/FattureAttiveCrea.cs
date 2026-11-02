using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveCrea : AppAbstractApi
{
	protected string _TipoDocumento;

	protected string _Cliente;

	protected string _Sezionale;

	protected DateTime? _Data;

	protected string _TipoPagamento;

	protected DateTime? _DataScadenza1;

	protected DateTime? _DataScadenza2;

	protected DateTime? _DataScadenza3;

	public FattureAttiveCrea(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TipoDocumento = "";
		_Cliente = "";
		_Sezionale = "";
		_TipoPagamento = "";
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Invalid comparison between Unknown and I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!((AppAbstractApi)this).ParametersIn.ContainsKey("TipoDocumento"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Tipo Documento non specificato", new string[0]);
			}
			else
			{
				_TipoDocumento = ((AppAbstractApi)this).ParametersIn["TipoDocumento"].ToString();
				if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Cliente"))
				{
					rsMess = this._Translator.TranslateMessage("XXX", "Cliente non specificato", new string[0]);
				}
				else
				{
					_Cliente = ((AppAbstractApi)this).ParametersIn["Cliente"].ToString();
					if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Sezionale"))
					{
						rsMess = this._Translator.TranslateMessage("XXX", "Sezionale non specificato", new string[0]);
					}
					else
					{
						_Sezionale = ((AppAbstractApi)this).ParametersIn["Sezionale"].ToString();
						if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Data"))
						{
							rsMess = this._Translator.TranslateMessage("XXX", "Data non specificata", new string[0]);
						}
						else
						{
							_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
							if (!((AppAbstractApi)this).ParametersIn.ContainsKey("TipoPagamento"))
							{
								rsMess = this._Translator.TranslateMessage("XXX", "Tipo Pagamento non specificato", new string[0]);
							}
							else
							{
								_TipoPagamento = ((AppAbstractApi)this).ParametersIn["TipoPagamento"].ToString();
								if (Operators.CompareString(_TipoPagamento, "", false) != 0)
								{
									goto IL_027d;
								}
								object objRes = "";
								string sSql = "SELECT CODICEPAGAMENTO FROM CLIENTI WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente);
								val = ((AppBaseClass)this).DbConn.DoSql(sSql, "", ref objRes, ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									_TipoPagamento = Conversions.ToString(objRes);
									if (Operators.CompareString(_TipoPagamento, "", false) != 0)
									{
										goto IL_027d;
									}
									rsMess = this.TranslateMessage("XXX", "Codice Pagamento non presente per il cliente {0}", new string[1] { _Cliente });
								}
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_027d:
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataScadenza1"))
			{
				_DataScadenza1 = (DateTime?)((AppAbstractApi)this).ParametersIn["DataScadenza1"];
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataScadenza2"))
			{
				_DataScadenza2 = (DateTime?)((AppAbstractApi)this).ParametersIn["DataScadenza2"];
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataScadenza3"))
			{
				_DataScadenza3 = (DateTime?)((AppAbstractApi)this).ParametersIn["DataScadenza3"];
			}
			base._ParametersOut.Add("IdFattura", "");
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
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Invalid comparison between Unknown and I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.FAT.FATTUREATTIVE.TESTATA", vbStartTrans: false, ref rlReturnValue, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "INSERT INTO Fatture_Attive_Testata (IdFattura, TipoDocumento, Sezionale, Data, Cliente, TipoPagamento, ";
				text += "DataScadenza1, DataScadenza2, DataScadenza3) VALUES ( ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale) + ", ";
				text = ((!_Data.HasValue) ? (text + "NULL, ") : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data.Value) + ", "));
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Cliente) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoPagamento) + ",";
				text = ((!_DataScadenza1.HasValue) ? (text + "NULL, ") : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataScadenza1.Value) + ", "));
				text = ((!_DataScadenza2.HasValue) ? (text + "NULL, ") : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataScadenza2.Value) + ", "));
				text = ((!_DataScadenza3.HasValue) ? (text + "NULL) ") : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataScadenza3.Value) + ") "));
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					base._ParametersOut["IdFattura"] = rlReturnValue;
					val2 = (FXRETURN)0;
				}
			}
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
