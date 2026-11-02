using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffaAttivaRaggruppata : GdoAbstractApi
{
	protected string _IdViaggio;

	protected string _Cliente;

	protected TariffeEngine _TariffaEngine;

	public SpedizioniAgganciaTariffaAttivaRaggruppata(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_Cliente = "";
		_TariffaEngine = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Cliente"))
			{
				_Cliente = ((AppAbstractApi)this).ParametersIn["Cliente"].ToString();
			}
			val2 = (FXRETURN)0;
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

	protected override void BeginTransaction()
	{
	}

	protected override void CommitTransaction()
	{
	}

	protected override void RollbackTransaction()
	{
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (base.ApplicationParams.ACTMode())
			{
				goto IL_033d;
			}
			SpParameter[] robjParams = new SpParameter[4]
			{
				new SpParameter(),
				null,
				null,
				null
			};
			robjParams[0].DataType = SpParameterDataType.Varchar;
			robjParams[0].Direction = SpParameterDirection.In;
			robjParams[0].Name = "InIdViaggio";
			robjParams[0].Value = _IdViaggio;
			robjParams[1] = new SpParameter();
			robjParams[1].DataType = SpParameterDataType.Varchar;
			robjParams[1].Direction = SpParameterDirection.In;
			robjParams[1].Name = "InCliente";
			robjParams[1].Value = _Cliente;
			robjParams[2] = new SpParameter();
			robjParams[2].DataType = SpParameterDataType.Varchar;
			robjParams[2].Direction = SpParameterDirection.In;
			robjParams[2].Name = "UnibolRaggru";
			robjParams[2].Value = "";
			robjParams[3] = new SpParameter();
			robjParams[3].DataType = SpParameterDataType.Varchar;
			robjParams[3].Direction = SpParameterDirection.Out;
			robjParams[3].Name = "RetOut";
			robjParams[3].DataVarcharLength = 4000;
			robjParams[3].Value = "";
			val = ((AppBaseClass)this).DbConn.StoredProcedureExecute("TAR_ATT_DestinationGrouper", ref robjParams, ref rsmess);
			if ((int)val <= 0)
			{
				string text = robjParams[3].Value.ToString();
				if (Operators.CompareString(text, "", false) != 0)
				{
					string[] array = text.Split(new char[1] { ';' });
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						if (Operators.CompareString(text2.Trim(), "", false) != 0)
						{
							string[] array3 = text2.Split(new char[1] { '=' });
							string text3 = array3[0];
							_TariffaEngine = new TariffeTrasportoAttiveSpedizioniRaggruEngine(this._ApiContext, _IdViaggio, text3);
							_TariffaEngine.TransactionManage = ((AppAbstractApi)this).TransactionManage;
							string Warning = "";
							string rsmess2 = "";
							val = _TariffaEngine.Run(ref Warning, ref rsmess2);
							if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
							{
								this._Warning += this.TranslateMessage("XXX", "Id raggruppamento attivo {0}: ", new string[1] { text3 });
							}
							if (Operators.CompareString(Warning, "", false) != 0)
							{
								ref string warning = ref this._Warning;
								warning = warning + Warning + " ";
							}
							if (Operators.CompareString(rsmess2, "", false) != 0)
							{
								this._Warning += rsmess2;
							}
							if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
							{
								this._Warning += "\r\n";
							}
						}
					}
				}
				goto IL_033d;
			}
			val2 = val;
			goto end_IL_0005;
			IL_033d:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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
