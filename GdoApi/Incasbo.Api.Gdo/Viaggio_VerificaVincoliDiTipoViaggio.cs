using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_VerificaVincoliDiTipoViaggio : GdoAbstractApi
{
	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected bool _CheckCampiObbligatori;

	protected bool _CheckCoerenzaCampiSpedizioni;

	protected bool _CheckSpedizioniObbligatorie;

	public Viaggio_VerificaVincoliDiTipoViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_CheckCampiObbligatori = false;
		_CheckCoerenzaCampiSpedizioni = false;
		_CheckSpedizioniObbligatorie = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_CheckCampiObbligatori = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["CheckCampiObbligatori"]);
			_CheckCoerenzaCampiSpedizioni = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["CheckCoerenzaCampiSpedizioni"]);
			_CheckSpedizioniObbligatorie = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["CheckSpedizioniObbligatorie"]);
			val = CheckViaggio(ref rsmess);
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
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Invalid comparison between Unknown and I4
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Invalid comparison between Unknown and I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_CheckCampiObbligatori)
			{
				if (Operators.CompareString(_dtViaggio.Rows[0]["TV_CampiObbligatori"].ToString(), "", false) != 0)
				{
					string[] array = _dtViaggio.Rows[0]["TV_CampiObbligatori"].ToString().Split(new char[1] { ';' });
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (Operators.CompareString(text, "", false) == 0)
						{
							continue;
						}
						string[] array3 = text.Split(new char[1] { '=' });
						string text2 = array3[0];
						string text3 = array3[1].ToUpper();
						bool flag = false;
						if (Operators.CompareString(text3, "S", false) != 0)
						{
							continue;
						}
						if ((object)_dtViaggio.Columns[text2].GetType() == typeof(DateTime))
						{
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtViaggio.Rows[0][text2])))
							{
								flag = true;
							}
						}
						else if (Operators.CompareString(_dtViaggio.Rows[0][text2].ToString(), "", false) == 0)
						{
							flag = true;
						}
						if (!flag)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "E' obbligatorio specificare il campo '{0}' per il viaggio {1}", new string[2] { text2, _IdViaggio });
						goto end_IL_0005;
					}
				}
				if (Operators.CompareString(_dtViaggio.Rows[0]["TV_CampiCondizioni"].ToString(), "", false) != 0)
				{
					string[] array4 = _dtViaggio.Rows[0]["TV_CampiCondizioni"].ToString().Split(new char[1] { ';' });
					string[] array5 = array4;
					foreach (string text4 in array5)
					{
						if (Operators.CompareString(text4, "", false) == 0)
						{
							continue;
						}
						string[] array6 = text4.Split(new char[1] { '#' });
						string filterExpression = array6[0];
						string text5 = array6[1];
						DataRow[] source = _dtViaggio.Select(filterExpression);
						if (source.Count() != 0)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "Condizione non rispettata per il viaggio Id={0}. " + text5, new string[1] { _IdViaggio });
						goto end_IL_0005;
					}
				}
			}
			if (!_CheckCoerenzaCampiSpedizioni || !((Operators.CompareString(_dtViaggio.Rows[0]["TV_CoerenzaTipoSpedizione"].ToString(), "S", false) == 0) | (Operators.CompareString(_dtViaggio.Rows[0]["TV_CoerenzaTipoMerce"].ToString(), "S", false) == 0)))
			{
				goto IL_0676;
			}
			string text6 = _dtViaggio.Rows[0]["TipoSpedizione"].ToString();
			if (Operators.CompareString(text6, "", false) == 0)
			{
				text6 = "___";
			}
			string text7 = _dtViaggio.Rows[0]["TipoMerce"].ToString();
			if (Operators.CompareString(text7, "", false) == 0)
			{
				text7 = "___";
			}
			string text8 = "SELECT %ISNULL%(SUM(TipoSpedizioneCount),0) TipoSpedizioneCount, %ISNULL%(SUM(TipoMerceCount),0) TipoMerceCount, ";
			text8 += "%ISNULL%(SUM(Cont),0) SpedizioniCont ";
			text8 = text8 + "FROM ( SELECT CASE WHEN TipoSpedizione=" + ((AppBaseClass)this).DbConn.SQLFormatString(text6) + " THEN 1 ELSE 0 END TipoSpedizioneCount,";
			text8 = text8 + "CASE WHEN TipoMerce=" + ((AppBaseClass)this).DbConn.SQLFormatString(text7) + " THEN 1 ELSE 0 END TipoMerceCount, 1 as Cont ";
			text8 = text8 + "FROM Spedizioni WHERE idviaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ") T";
			text8 = ((AppBaseClass)this).DbConn.SqlConvertForServer(text8);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text8, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count <= 0)
				{
					goto IL_05f9;
				}
				if (((Operators.CompareString(_dtViaggio.Rows[0]["TV_CoerenzaTipoSpedizione"].ToString(), "S", false) == 0) & (Operators.CompareString(text6, "___", false) != 0)) && Conversions.ToInteger(rObjDataTable.Rows[0]["TipoSpedizioneCount"]) != Conversions.ToInteger(rObjDataTable.Rows[0]["SpedizioniCont"]))
				{
					rsmess = this.TranslateMessage("XXX", "Tipo spedizione non coerente tra viaggio e spedizioni associate");
				}
				else
				{
					if (!((Operators.CompareString(_dtViaggio.Rows[0]["TV_CoerenzaTipoMerce"].ToString(), "S", false) == 0) & (Operators.CompareString(text7, "___", false) != 0)) || Conversions.ToInteger(rObjDataTable.Rows[0]["TipoMerceCount"]) == Conversions.ToInteger(rObjDataTable.Rows[0]["SpedizioniCont"]))
					{
						goto IL_05f9;
					}
					rsmess = this.TranslateMessage("XXX", "Tipo merce non coerente tra viaggio e spedizioni associate");
				}
			}
			goto end_IL_0005;
			IL_05f9:
			if (!(_CheckSpedizioniObbligatorie & (Operators.CompareString(_dtViaggio.Rows[0]["TV_SpedizioniObbligatorie"].ToString(), "S", false) == 0)) || rObjDataTable.Rows.Count != 0)
			{
				goto IL_0676;
			}
			rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non possiede Spedizioni associate", new string[1] { _IdViaggio });
			goto end_IL_0005;
			IL_0676:
			if (!(_CheckSpedizioniObbligatorie & (Operators.CompareString(_dtViaggio.Rows[0]["TV_SpedizioniObbligatorie"].ToString(), "S", false) == 0)))
			{
				goto IL_0730;
			}
			string text9 = "SELECT COUNT(*) ";
			text9 = text9 + "FROM Spedizioni WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(text9, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(objRes) != 0)
				{
					goto IL_0730;
				}
				rsmess = this.TranslateMessage("XXX", "Il viaggio {0} non possiede Spedizioni associate", new string[1] { _IdViaggio });
			}
			goto end_IL_0005;
			IL_0730:
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT V.*, TV.Descrizione TV_Descrizione, ";
			text += "CASE WHEN V.Stato=10 THEN TV.CampiObbligatori ELSE TV.CampiObbligatori_Partenza END AS TV_CampiObbligatori, ";
			text += "TV.CoerenzaTipoSpedizione TV_CoerenzaTipoSpedizione, ";
			text += "TV.CoerenzaTipoMerce TV_CoerenzaTipoMerce, TV.OpzioniAggiuntive TV_OpzioniAggiuntive, ";
			text += "CASE WHEN V.Stato=10 THEN TV.CampiCondizioni ELSE TV.CampiCondizioni_Partenza END AS TV_CampiCondizioni, ";
			text += "TV.SpedizioniObbligatorie TV_SpedizioniObbligatorie ";
			text = text + "FROM Viaggi V INNER JOIN Viaggi_TipiViaggio TV ON V.TipoViaggio=TV.CODICE WHERE V.IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
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
