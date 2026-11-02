using System;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureAttiveMessaggi : AppAbstractApi
{
	public enum FattureAttiveLogTipoMessaggio
	{
		Info,
		Errore,
		Warning
	}

	protected long _IdFattura;

	protected FattureAttiveLogTipoMessaggio _TipoMessaggio;

	protected string _Messaggio;

	public FattureAttiveMessaggi(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!((AppAbstractApi)this).ParametersIn.ContainsKey("IdFattura"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Id Fattura non specificato", new string[0]);
			}
			else if (!((AppAbstractApi)this).ParametersIn.ContainsKey("TipoMessaggio"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Tipo messaggio non specificato", new string[0]);
			}
			else if (!((AppAbstractApi)this).ParametersIn.ContainsKey("Messaggio"))
			{
				rsMess = this._Translator.TranslateMessage("XXX", "Messaggio non specificato", new string[0]);
			}
			else
			{
				_IdFattura = Convert.ToInt64(RuntimeHelpers.GetObjectValue(((AppAbstractApi)this).ParametersIn["IdFattura"]));
				_TipoMessaggio = (FattureAttiveLogTipoMessaggio)((AppAbstractApi)this).ParametersIn["TipoMessaggio"];
				_Messaggio = ((AppAbstractApi)this).ParametersIn["Messaggio"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			string text2 = "I";
			if (_TipoMessaggio == FattureAttiveLogTipoMessaggio.Errore)
			{
				text2 = "E";
			}
			else if (_TipoMessaggio == FattureAttiveLogTipoMessaggio.Warning)
			{
				text2 = "W";
			}
			else if (_TipoMessaggio == FattureAttiveLogTipoMessaggio.Info)
			{
				text2 = "I";
			}
			text = "INSERT INTO Fatture_Attive_Messaggi (IdFattura, TipoMessaggio, Messaggio, UteIns, UteAgg) VALUES (";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
			text = text + "'" + text2 + "', ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(Strings.Left(_Messaggio, 1000)) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + ")";
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, long IdFattura, FattureAttiveLogTipoMessaggio TipoMessaggio, string Messaggio, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FattureAttiveMessaggi fattureAttiveMessaggi = new FattureAttiveMessaggi(objApiContext);
		((AppAbstractApi)fattureAttiveMessaggi).ParametersIn.Add("IdFattura", IdFattura);
		((AppAbstractApi)fattureAttiveMessaggi).ParametersIn.Add("TipoMessaggio", TipoMessaggio);
		((AppAbstractApi)fattureAttiveMessaggi).ParametersIn.Add("Messaggio", Messaggio);
		((AppAbstractApi)fattureAttiveMessaggi).TransactionManage = false;
		return ((AppAbstractApi)fattureAttiveMessaggi).Run(ref rsMess);
	}
}
