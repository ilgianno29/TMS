using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_Attiva : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected string _Note;

	protected int _Stato;

	public Spedizione_Attiva(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizione = null;
		_Note = "";
		_Stato = 20;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Note = ((AppAbstractApi)this).ParametersIn["Note"].ToString();
			if (base.ApplicationParams.GiriStandardPresenti())
			{
				_Stato = 18;
			}
			val = CheckSpedizione(ref rsmess);
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
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Invalid comparison between Unknown and I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Invalid comparison between Unknown and I4
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DateTime DataConsegnaDa = DateAndTime.Now.Date;
			DateTime DataConsegnaA = DateAndTime.Now.Date;
			DateTime DataUscitaMagazzino = DateAndTime.Now.Date;
			string text2 = "DATINS";
			if (_dtSpedizione.Columns.Contains(base.ApplicationParams.CampoDataRiferimentoPerTempiResa()))
			{
				text2 = base.ApplicationParams.CampoDataRiferimentoPerTempiResa();
			}
			DateTime? dataRiferimento = (((Operators.CompareString(text2.ToUpper(), "DATATT", false) == 0) | (Operators.CompareString(text2.ToUpper(), "DATAATTIVAZIONE", false) == 0)) ? new DateTime?(DateAndTime.Now) : (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0][text2])) ? new DateTime?(Conversions.ToDate(_dtSpedizione.Rows[0]["DATINS"])) : new DateTime?(Conversions.ToDate(_dtSpedizione.Rows[0][text2]))));
			val = TempiResa_CalcolaDate_Invoker.Instance.RunProc(this._ApiContext, _dtSpedizione.Rows[0]["Cliente"].ToString(), _dtSpedizione.Rows[0]["TipoServizio"].ToString(), _dtSpedizione.Rows[0]["TipoSpedizione"].ToString(), _dtSpedizione.Rows[0]["TipoMerce"].ToString(), _dtSpedizione.Rows[0]["PCSPartenza"].ToString(), _dtSpedizione.Rows[0]["ZonaSpedizione"].ToString(), dataRiferimento, ref DataConsegnaDa, ref DataConsegnaA, ref DataUscitaMagazzino, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "UPDATE Spedizioni SET STATO=" + _Stato + ", BARCODE=%ISNULL%(BARCODE, UNIBOL), ";
				text = text + "DataConsegnaPrevista1=%ISNULL%(DataConsegnaPrevista1," + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DataConsegnaDa) + "), ";
				text = text + "DataConsegnaPrevista2=%ISNULL%(DataConsegnaPrevista2," + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DataConsegnaA) + "), ";
				text = text + "DataSpedizione=%ISNULL%(DataSpedizione," + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DataUscitaMagazzino) + ") ";
				text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
				text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
				string RetQueryToApply = "";
				string text3 = "";
				val = EventoSpedizione_Attivazione.RunProc(CodiceEvento: (Operators.CompareString(this._User, "DSI", false) != 0) ? "SPEATTMAN" : "SPEATTAUTO", objApiContext: this._ApiContext, Unibol: _Unibol, Note: _Note, Utente: "", ApplyQuery: false, RetQueryToApply: ref RetQueryToApply, rsmess: ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += RetQueryToApply;
					if (Operators.CompareString(text, "", false) == 0)
					{
						goto IL_037a;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_037a;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_037a:
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) == 0)
			{
				goto IL_035b;
			}
			text = "SELECT S.*, TS.ObbligoCampiAttivazione, TS.CondizioniAttivazione FROM Spedizioni S INNER JOIN TipiServizi TS ON S.TipoServizio=TS.Codice WHERE S.Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
			}
			else
			{
				DataRow dataRow = _dtSpedizione.Rows[0];
				if (Conversions.ToInteger(dataRow["Stato"]) == 10)
				{
					string text2 = dataRow["ObbligoCampiAttivazione"].ToString();
					string[] array = text2.Split(new char[1] { ';' });
					string[] array2 = array;
					int num = 0;
					while (true)
					{
						if (num >= array2.Length)
						{
							string text3 = dataRow["CondizioniAttivazione"].ToString();
							string[] array3 = text3.Split(new char[1] { ';' });
							string[] array4 = array3;
							foreach (string text4 in array4)
							{
								if (Operators.CompareString(text4, "", false) == 0)
								{
									continue;
								}
								string[] array5 = text4.Split(new char[1] { '#' });
								string filterExpression = array5[0];
								string text5 = array5[1];
								DataRow[] source = _dtSpedizione.Select(filterExpression);
								if (source.Count() != 0)
								{
									continue;
								}
								rsmess = this.TranslateMessage("XXX", "Condizione di attivazione non rispettata per la spedizione Id={0}. " + text5, new string[1] { _Unibol });
								goto end_IL_000b;
							}
							break;
						}
						string text6 = array2[num];
						if (Operators.CompareString(text6, "", false) == 0)
						{
							goto IL_026d;
						}
						string[] array6 = text6.Split(new char[1] { '=' });
						string text7 = array6[0];
						string text8 = array6[1].ToUpper();
						bool flag = false;
						if (Operators.CompareString(text8, "S", false) != 0)
						{
							goto IL_026d;
						}
						if ((object)_dtSpedizione.Columns[text7].GetType() == typeof(DateTime))
						{
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(_dtSpedizione.Rows[0][text7])))
							{
								flag = true;
							}
						}
						else if (Operators.CompareString(_dtSpedizione.Rows[0][text7].ToString(), "", false) == 0)
						{
							flag = true;
						}
						if (!flag)
						{
							goto IL_026d;
						}
						rsmess = this.TranslateMessage("XXX", "E' obbligatorio specificare il campo '{0}' per la spedizione {1}", new string[2] { text7, _Unibol });
						goto end_IL_000b;
						IL_026d:
						num = checked(num + 1);
					}
					goto IL_035b;
				}
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette l'attivazione", new string[1] { _Unibol });
			}
			goto end_IL_000b;
			IL_035b:
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
