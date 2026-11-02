using System;
using System.Data;
using System.IO;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_DocumentoInserisci : GdoAbstractApi
{
	protected string _Unibol;

	protected string _FileName;

	protected string _TipoDocumento;

	protected string _NumeroDocumento;

	protected DateTime? _DataDocumento;

	protected string _Note;

	public Spedizione_DocumentoInserisci(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_FileName = "";
		_TipoDocumento = "";
		_NumeroDocumento = "";
		_Note = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_FileName = ((AppAbstractApi)this).ParametersIn["FileName"].ToString();
			_TipoDocumento = ((AppAbstractApi)this).ParametersIn["TipoDocumento"].ToString();
			if (((AppAbstractApi)this).ParametersIn["NumeroDocumento"] != null)
			{
				_NumeroDocumento = ((AppAbstractApi)this).ParametersIn["NumeroDocumento"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn["DataDocumento"] != null)
			{
				_DataDocumento = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DataDocumento"]);
			}
			if (((AppAbstractApi)this).ParametersIn["Note"] != null)
			{
				_Note = ((AppAbstractApi)this).ParametersIn["Note"].ToString();
			}
			val = CheckDocumento(ref rsmess);
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
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			long rlReturnValue = 0L;
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SPEDIZIONI.DOCUMENTI", vbStartTrans: false, ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "INSERT INTO DOCUMENTI (IdDocumento, Documento, DocumentoEstensione, UteIns, UteAgg) VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ", ";
				text += " :1 ,";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(Path.GetExtension(_FileName).Replace(".", "")) + ",";
				text = text + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + ")";
				string[] vsFileName = new string[1] { _FileName };
				val = ((AppBaseClass)this).DbConn.SqlExecBlobHelper(text, vsFileName, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text = "INSERT INTO Spedizioni_Documenti (Unibol,TipoDocumento,Prg,IdDocumento,Numero,Data,Note) VALUES (";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ",";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento) + ",";
					text = text + "(SELECT ISNULL(MAX(Prg),0) + 1 FROM Spedizioni_Documenti WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + "),";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref rlReturnValue) + ",";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_NumeroDocumento) + ",";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataDocumento) + ",";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Note) + ")";
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	protected FXRETURN CheckDocumento(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between Unknown and I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) == 0)
			{
				goto IL_01e4;
			}
			text = "SELECT Unibol, NumeroBolla, DataBolla FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else
			{
				if (Operators.CompareString(_TipoDocumento, "DDT", false) == 0 && ((Operators.CompareString(_NumeroDocumento.ToString(), "", false) == 0) | !_DataDocumento.HasValue))
				{
					_NumeroDocumento = rObjDataTable.Rows[0]["NumeroBolla"].ToString();
					_DataDocumento = Conversions.ToDate(rObjDataTable.Rows[0]["DataBolla"]);
				}
				text = "SELECT * FROM Spedizioni_Documenti WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
				text = text + " AND TipoDocumento=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoDocumento);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (rObjDataTable.Rows.Count == 0)
					{
						goto IL_01e4;
					}
					rsmess = this.TranslateMessage("XXX", "Documento di tipo {0} già presente per la spedizione con Id {0}", new string[2] { _TipoDocumento, _Unibol });
				}
			}
			goto end_IL_000e;
			IL_01e4:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
