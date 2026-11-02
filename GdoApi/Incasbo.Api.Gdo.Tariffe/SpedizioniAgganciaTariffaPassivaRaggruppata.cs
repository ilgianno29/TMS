using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Tariffe;

public class SpedizioniAgganciaTariffaPassivaRaggruppata : AppAbstractApi
{
	protected string _IdViaggio;

	protected TariffeEngine _TariffaEngine;

	public SpedizioniAgganciaTariffaPassivaRaggruppata(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_TariffaEngine = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
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
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SpParameter[] robjParams = new SpParameter[3]
			{
				new SpParameter(),
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
			robjParams[1].Name = "UnibolRaggru";
			robjParams[1].Value = "";
			robjParams[2] = new SpParameter();
			robjParams[2].DataType = SpParameterDataType.Varchar;
			robjParams[2].Direction = SpParameterDirection.Out;
			robjParams[2].Name = "RetOut";
			robjParams[2].DataVarcharLength = 4000;
			robjParams[2].Value = "";
			val = ((AppBaseClass)this).DbConn.StoredProcedureExecute("TAR_PAS_DestinationGrouper", ref robjParams, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = robjParams[2].Value.ToString();
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
							_TariffaEngine = new TariffeTrasportoPassiveSpedizioniRaggruEngine(this._ApiContext, _IdViaggio, text3);
							_TariffaEngine.TransactionManage = ((AppAbstractApi)this).TransactionManage;
							string Warning = "";
							string rsmess2 = "";
							val = _TariffaEngine.Run(ref Warning, ref rsmess2);
							if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
							{
								base._Warning += this.TranslateMessage("XXX", "Id raggruppamento passivo {0}: ", new string[1] { text3 });
							}
							if (Operators.CompareString(Warning, "", false) != 0)
							{
								ref string warning = ref base._Warning;
								warning = warning + Warning + " ";
							}
							if (Operators.CompareString(rsmess2, "", false) != 0)
							{
								base._Warning += rsmess2;
							}
							if ((Operators.CompareString(Warning, "", false) != 0) | (Operators.CompareString(rsmess2, "", false) != 0))
							{
								base._Warning += "\r\n";
							}
						}
					}
				}
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
