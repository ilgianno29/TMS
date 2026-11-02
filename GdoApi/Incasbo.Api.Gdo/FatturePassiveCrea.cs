using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FatturePassiveCrea : AppAbstractApi
{
	protected string _TipoDocumento;

	protected string _Trasportatore;

	protected string _Sezionale;

	protected DateTime? _Data;

	protected string _TipoPagamento;

	protected DateTime? _DataScadenza1;

	protected DateTime? _DataScadenza2;

	protected DateTime? _DataScadenza3;

	public FatturePassiveCrea(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TipoDocumento = "";
		_Trasportatore = "";
		_Sezionale = "";
		_TipoPagamento = "";
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		int num = 0;
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
				if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Trasportatore"))
				{
					rsMess = this._Translator.TranslateMessage("XXX", "Trasportatore non specificato", new string[0]);
				}
				else
				{
					_Trasportatore = ((AppAbstractApi)this).ParametersIn["Trasportatore"].ToString();
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
								if (Operators.CompareString(_TipoPagamento, "", false) == 0)
								{
									rsMess = this.TranslateMessage("XXX", "Codice Pagamento non presente per il Trasportatore {0}", new string[1] { _Trasportatore });
								}
								else
								{
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
								}
							}
						}
					}
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
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.FATTUREPASSIVE.TESTATA", vbStartTrans: false, ref rlReturnValue, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "INSERT INTO Fatture_Passive_Testata (IdFattura, TipoDocumento, Trasportatore, Sezionale, Data, TipoPagamento, ";
				text += "DataScadenza1, DataScadenza2, DataScadenza3) VALUES ( ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Trasportatore) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Sezionale) + ", ";
				text = ((!_Data.HasValue) ? (text + "NULL, ") : (text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Data.Value) + ", "));
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Trasportatore, string Sezionale, DateTime? Data, string TipoPagamento, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FatturePassiveCrea fatturePassiveCrea = new FatturePassiveCrea(objApiContext);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Trasportatore", Trasportatore);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Sezionale", Sezionale);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Data", Data);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
		return ((AppAbstractApi)fatturePassiveCrea).Run(ref rsMess);
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Trasportatore, string Sezionale, DateTime? Data, string TipoPagamento, ref string sIdFattura, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FatturePassiveCrea fatturePassiveCrea = new FatturePassiveCrea(objApiContext);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Trasportatore", Trasportatore);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Sezionale", Sezionale);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Data", Data);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
		val = ((AppAbstractApi)fatturePassiveCrea).Run(ref rsMess);
		if ((int)val == 0)
		{
			sIdFattura = ((AppAbstractApi)fatturePassiveCrea).ParametersOut["IdFattura"].ToString();
		}
		return val;
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, string TipoDocumento, string Cliente, string Sezionale, DateTime? Data, string TipoPagamento, DateTime? DataScadenza1, DateTime? DataScadenza2, DateTime? DataScadenza3, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FatturePassiveCrea fatturePassiveCrea = new FatturePassiveCrea(objApiContext);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoDocumento", TipoDocumento);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Cliente", Cliente);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Sezionale", Sezionale);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("Data", Data);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("TipoPagamento", TipoPagamento);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("DataScadenza1", DataScadenza1);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("DataScadenza2", DataScadenza2);
		((AppAbstractApi)fatturePassiveCrea).ParametersIn.Add("DataScadenza3", DataScadenza3);
		return ((AppAbstractApi)fatturePassiveCrea).Run(ref rsMess);
	}
}
