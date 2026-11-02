using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_EliminaTransitPoint : AppAbstractApi
{
	protected List<string> _ListOfUnibol;

	protected DataTable _dtSpedizioni;

	public Spedizione_EliminaTransitPoint(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtSpedizioni = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_ListOfUnibol = (List<string>)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			val = CheckSpedizioni(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between Unknown and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			foreach (string item in _ListOfUnibol)
			{
				text = text + "UPDATE Spedizioni SET CORRISPONDENTE=NULL,TRASPORTATORE=NULL WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				text = text + "DELETE FROM Spedizioni_Costi WHERE (Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ") AND (TipoCalcolo NOT IN ('MAN', 'VET')) AND (";
				text = text + "(SELECT BloccaCosti FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ")='N') AND ";
				text = text + "(SELECT IdFatturaPassiva FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ") IS NULL; ";
				string RetQueryToApply = "";
				val = EventoSpedizione_EliminaCorrispondente.RunProc(this._ApiContext, item, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val <= 0)
				{
					text += RetQueryToApply;
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_013f;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_013f;
			}
			val2 = val;
			goto end_IL_000b;
			IL_013f:
			StringCollection stringCollection = new StringCollection();
			foreach (string item2 in _ListOfUnibol)
			{
				DataRow[] array = _dtSpedizioni.Select("UNIBOL='" + item2 + "'");
				if (Operators.CompareString(array[0]["IdViaggio"].ToString(), "", false) == 0 || stringCollection.Contains(array[0]["IdViaggio"].ToString()))
				{
					continue;
				}
				string RetQueryToApply2 = "";
				val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, array[0]["IdViaggio"].ToString(), ApplyQuery: false, ref RetQueryToApply2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(RetQueryToApply2, "", false) == 0)
					{
						goto IL_0246;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(RetQueryToApply2, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0246;
					}
					val2 = val;
				}
				goto end_IL_000b;
				IL_0246:
				stringCollection.Add(array[0]["IdViaggio"].ToString());
			}
			val2 = (FXRETURN)0;
			end_IL_000b:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, List<string> ListOfUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Spedizione_EliminaTransitPoint spedizione_EliminaTransitPoint = new Spedizione_EliminaTransitPoint(objApiContext);
			((AppAbstractApi)spedizione_EliminaTransitPoint).ParametersIn.Add("ListOfUnibol", ListOfUnibol);
			val = ((AppAbstractApi)spedizione_EliminaTransitPoint).Run(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	protected FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_ListOfUnibol.Count <= 0)
			{
				goto IL_01b9;
			}
			string text2 = "";
			foreach (string item in _ListOfUnibol)
			{
				text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ",";
			}
			text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
			text = "SELECT Unibol,Stato,IdViaggio FROM Spedizioni WHERE Unibol IN (" + text2 + ")";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val <= 0)
			{
				foreach (string item2 in _ListOfUnibol)
				{
					DataRow[] array = _dtSpedizioni.Select("UNIBOL='" + item2 + "'");
					if (array.Count() == 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { item2 });
					}
					else
					{
						if (Conversions.ToInteger(array[0]["Stato"]) < 30)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permetta la disassociazione ad un corrispondente (Stato attuale della spedizione={1})", new string[2]
						{
							item2,
							array[0]["Stato"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_01b9;
			}
			val2 = val;
			goto end_IL_000b;
			IL_01b9:
			val2 = (FXRETURN)0;
			end_IL_000b:;
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
