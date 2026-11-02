using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_DisassociaDaViaggioChiuso : AppAbstractApi
{
	protected string _IdViaggio;

	protected List<string> _ListOfUnibol;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	protected bool _TrasmettiAWMS;

	public Spedizione_DisassociaDaViaggioChiuso(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtSpedizioni = null;
		_TrasmettiAWMS = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_ListOfUnibol = (List<string>)((AppAbstractApi)this).ParametersIn["ListOfUnibol"];
			_TrasmettiAWMS = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["TrasmettiAWMS"]);
			val = CheckSpedizioni(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckViaggio(ref rsmess);
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
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Invalid comparison between Unknown and I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
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
				string RetQueryToApply = "";
				text = text + "UPDATE Spedizioni SET IDViaggio=NULL, Stato=20, SequenzaPianificata=0, CostoViaggioRipartito=0, CostoViaggioRipartitoNolo=0, RicavoViaggioRipartito=0, RicavoViaggioRipartitoNolo=0 WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				text = text + "UPDATE SpedizioniUds SET Esito=NULL, DataEsito=NULL, NoteEsito=NULL WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				val = EventoSpedizione_Ripianifica.RunProc(this._ApiContext, item, DateAndTime.Now, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += RetQueryToApply;
					val = EventoSpedizione_DisassociaDaViaggio.RunProc(this._ApiContext, item, _IdViaggio, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val <= 0)
					{
						text += RetQueryToApply;
						continue;
					}
					val2 = val;
				}
				goto end_IL_000b;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_0224;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string RetQueryToApply2 = "";
				val = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ApplyQuery: false, ref RetQueryToApply2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(RetQueryToApply2, "", false) == 0)
					{
						goto IL_01b4;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(RetQueryToApply2, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_01b4;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_01b4:
			if (_TrasmettiAWMS)
			{
				foreach (string item2 in _ListOfUnibol)
				{
					val = WMS_Spedizione_DisassociaDaViaggioChiuso_Invoker.Instance.RunProc(this._ApiContext, item2, _IdViaggio, ref rsmess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
			}
			goto IL_0224;
			IL_0224:
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM Viaggi WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) != 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} risulta in uno stato che non permette la disassociazione di una spedizione da un viaggio chiuso", new string[1] { _IdViaggio });
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

	protected virtual FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_020d;
			}
			string text2 = "";
			foreach (string item in _ListOfUnibol)
			{
				text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ",";
			}
			text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
			text = "SELECT Unibol,IdViaggio,Stato FROM Spedizioni WHERE Unibol IN (" + text2 + ")";
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
					else if (Operators.CompareString(array[0]["IdViaggio"].ToString(), _IdViaggio, false) != 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non risulta associata al viaggio {1}", new string[2] { item2, _IdViaggio });
					}
					else
					{
						if (Conversions.ToInteger(array[0]["Stato"]) == 30)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permetta la disassociazione dal viaggio chiuso (Stato attuale della spedizione={1})", new string[2]
						{
							item2,
							array[0]["Stato"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_020d;
			}
			val2 = val;
			goto end_IL_000b;
			IL_020d:
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
