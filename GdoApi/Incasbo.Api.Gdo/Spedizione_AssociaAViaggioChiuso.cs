using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_AssociaAViaggioChiuso : AppAbstractApi
{
	protected string _IdViaggio;

	protected List<string> _ListOfUnibol;

	protected DateTime? _DataEvento;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	public Spedizione_AssociaAViaggioChiuso(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_DataEvento = null;
		_dtViaggio = null;
		_dtSpedizioni = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
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
			_DataEvento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEvento"];
			if (!_DataEvento.HasValue)
			{
				_DataEvento = DateAndTime.Now;
			}
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
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Invalid comparison between Unknown and I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Invalid comparison between Unknown and I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
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
				text = text + "UPDATE Spedizioni SET IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ", SequenzaPianificata=0, CostoViaggioRipartito=0, CostoViaggioRipartitoNolo=0, RicavoViaggioRipartito=0, RicavoViaggioRipartitoNolo=0 WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
				string RetQueryToApply = "";
				val = EventoSpedizione_AssociaAViaggio.RunProc(this._ApiContext, item, _DataEvento, _IdViaggio, ViaggioChiuso: true, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += RetQueryToApply;
					int num = 0;
					num = ((Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) == 20) ? 30 : ((Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) != 30) ? 40 : 40));
					text = text + "UPDATE Spedizioni SET Stato=" + num + " WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ";";
					val = EventoSpedizione_Pianificata.RunProc(this._ApiContext, item, _DataEvento, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += RetQueryToApply;
						if (num != 40)
						{
							continue;
						}
						val = EventoSpedizione_InConsegna.RunProc(this._ApiContext, item, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
						if ((int)val <= 0)
						{
							text += RetQueryToApply;
							continue;
						}
						val2 = val;
					}
				}
				goto end_IL_000b;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_0341;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = Viaggio_VerificaVincoliDiTipoViaggio_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, ref rsmess);
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
							goto IL_02e0;
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(RetQueryToApply2, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_02e0;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_000b;
			IL_02e0:
			foreach (string item2 in _ListOfUnibol)
			{
				val = WMS_Spedizione_AssociaAViaggioChiuso_Invoker.Instance.RunProc(this._ApiContext, item2, _IdViaggio, ref rsmess);
				if ((int)val <= 0)
				{
					continue;
				}
				val2 = val;
				goto end_IL_000b;
			}
			goto IL_0341;
			IL_0341:
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

	protected FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT V.IdViaggio,V.Stato,TV.SpedizioniInsSeChiuso, V.TipoViaggio FROM Viaggi V INNER JOIN VIAGGI_TipiViaggio TV ON V.TipoViaggio=TV.CODICE WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else if ((Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) <= 10) | (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) >= 40))
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} risulta in uno stato (Stato={1}) che non permette l'associazione di una spedizione", new string[2]
				{
					_IdViaggio,
					_dtViaggio.Rows[0]["Stato"].ToString()
				});
			}
			else if (Operators.CompareString(_dtViaggio.Rows[0]["SpedizioniInsSeChiuso"].ToString().ToUpper(), "S", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} appartiene al tipo viaggio '{1}' che non consente l'inserimento di spedizioni a viaggio chiuso", new string[2]
				{
					_IdViaggio,
					_dtViaggio.Rows[0]["TipoViaggio"].ToString()
				});
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

	protected FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_0219;
			}
			string text2 = "";
			foreach (string item in _ListOfUnibol)
			{
				text2 = text2 + ((AppBaseClass)this).DbConn.SQLFormatString(item) + ",";
			}
			text2 = Strings.Left(text2, checked(Strings.Len(text2) - 1));
			text = "SELECT * FROM Spedizioni WHERE Unibol IN (" + text2 + ")";
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
					else if (Operators.CompareString(array[0]["IdViaggio"].ToString(), "", false) != 0)
					{
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} risulta già associata al viaggio {1}", new string[2]
						{
							item2,
							array[0]["IdViaggio"].ToString()
						});
					}
					else
					{
						if (Conversions.ToInteger(array[0]["Stato"]) == 20)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permetta l'associazione ad un viaggio (Stato attuale della spedizione={1})", new string[2]
						{
							item2,
							array[0]["Stato"].ToString()
						});
					}
					goto end_IL_000b;
				}
				goto IL_0219;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0219:
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
