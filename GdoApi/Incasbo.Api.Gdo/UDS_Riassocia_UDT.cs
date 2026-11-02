using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_Riassocia_UDT : GdoAbstractApi
{
	protected string[] _Unibols;

	protected string[] _CodiceUds;

	protected string _UdsMaster;

	protected bool _ApplyQuery;

	protected StringCollection _ViaggiLinea;

	protected Dictionary<string, bool> _UdsToAssociate;

	public UDS_Riassocia_UDT(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibols = new string[0];
		_CodiceUds = new string[0];
		_UdsMaster = "";
		_ApplyQuery = true;
		_ViaggiLinea = new StringCollection();
		_UdsToAssociate = new Dictionary<string, bool>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_CodiceUds = (string[])this._ParametersIn["CodiceUds"];
			_Unibols = (string[])this._ParametersIn["Unibols"];
			_UdsMaster = this._ParametersIn["UdsMaster"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			this._ParametersOut.Add("RetQueryToApply", "");
			val = CheckUds(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckUdt(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			checked
			{
				int num = _CodiceUds.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (_UdsToAssociate[_CodiceUds[i]])
					{
						text += "UPDATE SPEDIZIONIUDS SET ";
						text = ((Operators.CompareString(_UdsMaster, "", false) == 0) ? (text + "UdsMaster = CODICE, ") : (text + "UdsMaster = " + ((AppBaseClass)this).DbConn.SQLFormatString(_UdsMaster) + ", "));
						text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + ", ";
						text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + " ";
						text = text + "WHERE CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_CodiceUds[i]) + " ";
						if (Operators.CompareString(_Unibols[i] ?? "", "", false) != 0)
						{
							text = text + "AND UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibols[i]) + " ";
						}
						text += ";";
					}
				}
				if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
				{
					goto IL_01b5;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			}
			if ((int)val <= 0)
			{
				goto IL_01b5;
			}
			val2 = val;
			goto end_IL_0005;
			IL_01b5:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
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

	protected virtual FXRETURN CheckUds(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Invalid comparison between Unknown and I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			DataTable dataTable = null;
			int num = checked(_CodiceUds.Count() - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					bool value = true;
					text = "SELECT U.*, S.IDVIAGGIOLINEA, S.StatoSpuntaUscita FROM SPEDIZIONIUDS U INNER JOIN Spedizioni S ON S.Unibol=U.Unibol ";
					text += "WHERE S.Stato<40 AND ";
					text = text + "U.CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CodiceUds[num2]) + " ";
					if (Operators.CompareString(_Unibols[num2] ?? "", "", false) != 0)
					{
						text = text + "AND U.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibols[num2]) + " ";
					}
					dataTable = null;
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					if (dataTable.Rows.Count == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Uds {0} non presente a sistema", new string[1] { _CodiceUds[num2] });
						break;
					}
					if (dataTable.Rows.Count > 1)
					{
						rsmess = this.TranslateMessage("XXX", "Uds {0} non univoca presente a sistema", new string[1] { _CodiceUds[num2] });
						break;
					}
					if (Operators.CompareString(dataTable.Rows[0]["Codice"].ToString(), dataTable.Rows[0]["UdsMaster"].ToString(), false) != 0 && Operators.CompareString(dataTable.Rows[0]["UdsMaster"].ToString().ToUpper(), _UdsMaster.ToUpper(), false) == 0)
					{
						value = false;
					}
					if (Operators.CompareString(dataTable.Rows[0]["IDVIAGGIOLINEA"].ToString(), "", false) != 0 && !_ViaggiLinea.Contains(dataTable.Rows[0]["IDVIAGGIOLINEA"].ToString()))
					{
						_ViaggiLinea.Add(dataTable.Rows[0]["IDVIAGGIOLINEA"].ToString());
					}
					_UdsToAssociate.Add(_CodiceUds[num2], value);
					num2 = checked(num2 + 1);
					continue;
				}
				text = "SELECT U.*, S.IDVIAGGIOLINEA FROM SPEDIZIONIUDS U INNER JOIN Spedizioni S ON S.Unibol=U.Unibol ";
				text += "WHERE S.Stato<40 AND ";
				text = text + "U.UDSMaster=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UdsMaster) + " ";
				dataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
					break;
				}
				foreach (DataRow row in dataTable.Rows)
				{
					if (Operators.CompareString(row["IDVIAGGIOLINEA"].ToString(), "", false) != 0 && !_ViaggiLinea.Contains(row["IDVIAGGIOLINEA"].ToString()))
					{
						_ViaggiLinea.Add(row["IDVIAGGIOLINEA"].ToString());
					}
				}
				if (_ViaggiLinea.Count > 1)
				{
					rsmess = this.TranslateMessage("XXX", "Le Uds spuntate appartengono a due linee diverse. Impossibile spuntare.");
				}
				else
				{
					val2 = (FXRETURN)0;
				}
				break;
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

	protected virtual FXRETURN CheckUdt(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sSql = "SELECT COUNT(*) FROM SpedizioniUds WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UdsMaster) + " AND DatIns >= %GETDATE%-30";
			object objRes = null;
			sSql = ((AppBaseClass)this).DbConn.SqlConvertForServer(sSql);
			val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Conversions.ToInteger(objRes) > 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il codice UDT che si vuole associare è già usato per una UDS. E' necessario usare un nuovo codice per l'UDT.");
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
}
