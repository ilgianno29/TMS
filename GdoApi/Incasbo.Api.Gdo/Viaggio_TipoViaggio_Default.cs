using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_TipoViaggio_Default : GdoAbstractApi
{
	protected string _TipoViaggio;

	protected DataTable _dtTipoViaggio;

	protected Dictionary<string, string> _DictionaryDefault;

	public Viaggio_TipoViaggio_Default(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_TipoViaggio = "";
		_dtTipoViaggio = null;
		_DictionaryDefault = new Dictionary<string, string>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_TipoViaggio = ((AppAbstractApi)this).ParametersIn["TipoViaggio"].ToString();
			((AppAbstractApi)this).ParametersOut.Add("DictionaryDefault", _DictionaryDefault);
			val = CheckTipoViaggio(ref rsmess);
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_TipoViaggio, "", false) != 0 && Operators.CompareString(_dtTipoViaggio.Rows[0]["CampiDefault"].ToString(), "", false) != 0)
			{
				string[] array = _dtTipoViaggio.Rows[0]["CampiDefault"].ToString().Split(new char[1] { ';' });
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (Operators.CompareString(text, "", false) != 0)
					{
						string[] array3 = text.Split(new char[1] { '=' });
						string key = array3[0];
						string value = array3[1];
						if (!_DictionaryDefault.ContainsKey(key))
						{
							_DictionaryDefault.Add(key, value);
						}
					}
				}
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string TipoViaggio, ref Dictionary<string, string> DictionaryDefault, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			Viaggio_TipoViaggio_Default viaggio_TipoViaggio_Default = new Viaggio_TipoViaggio_Default(objApiContext);
			((AppAbstractApi)viaggio_TipoViaggio_Default).ParametersIn.Add("TipoViaggio", TipoViaggio);
			val = ((AppAbstractApi)viaggio_TipoViaggio_Default).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				DictionaryDefault = (Dictionary<string, string>)((AppAbstractApi)viaggio_TipoViaggio_Default).ParametersOut["DictionaryDefault"];
				val2 = (FXRETURN)0;
			}
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

	protected virtual FXRETURN CheckTipoViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_TipoViaggio, "", false) == 0)
			{
				goto IL_0117;
			}
			text = "SELECT * FROM Viaggi_TipiViaggio WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtTipoViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtTipoViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il tipo viaggio viaggio {0} non esiste", new string[1] { _TipoViaggio });
			}
			else
			{
				if (Operators.CompareString(_dtTipoViaggio.Rows[0]["Attivo"].ToString().ToUpper(), "N", false) != 0)
				{
					goto IL_0117;
				}
				rsmess = this.TranslateMessage("XXX", "Il tipo viaggio viaggio {0} non è attivo e quindi non può essere utilizzato", new string[1] { _TipoViaggio });
			}
			goto end_IL_000b;
			IL_0117:
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
