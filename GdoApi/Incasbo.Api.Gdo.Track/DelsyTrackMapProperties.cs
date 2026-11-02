using System;
using System.Collections.Generic;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo.Track;

public class DelsyTrackMapProperties : AppAbstractApi
{
	protected string _Tipologia;

	protected string _Proprieta;

	public DelsyTrackMapProperties(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Tipologia = "";
		_Proprieta = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Tipologia"].ToString(), "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Obbligatorio specificare la tipologia");
			}
			else
			{
				_Tipologia = ((AppAbstractApi)this).ParametersIn["Tipologia"].ToString();
				if (Operators.CompareString(((AppAbstractApi)this).ParametersIn["Proprieta"].ToString(), "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Obbligatorio specificare la Proprieta");
				}
				else
				{
					_Proprieta = ((AppAbstractApi)this).ParametersIn["Proprieta"].ToString();
					((AppAbstractApi)this).ParametersOut.Add("Valore", null);
					val2 = (FXRETURN)0;
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Proprieta FROM MapProperties WHERE Codice=" + this._DbConn.SQLFormatString(_Tipologia) + " ";
			val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				Dictionary<string, string> sRetColl = null;
				val = MyParser(objRes.ToString(), ref sRetColl, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (sRetColl.ContainsKey(_Proprieta))
					{
						base._ParametersOut["Valore"] = sRetColl[_Proprieta];
					}
					val2 = (FXRETURN)0;
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

	private FXRETURN MyParser(string sComando, ref Dictionary<string, string> sRetColl, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		FXRETURN result;
		try
		{
			string[] array = Strings.Split(sComando, ";", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					string[] array3 = Strings.Split(text, "=", -1, (CompareMethod)0);
					dictionary.Add(array3[0], array3[1]);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			dictionary = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			sRetColl = dictionary;
			result = val;
		}
		return result;
	}
}
