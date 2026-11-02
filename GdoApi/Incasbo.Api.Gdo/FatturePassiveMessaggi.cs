using System;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FatturePassiveMessaggi : AppAbstractApi
{
	public enum FatturePassiveLogTipoMessaggio
	{
		Info,
		Errore,
		Warning
	}

	protected long _IdFattura;

	protected FatturePassiveLogTipoMessaggio _TipoMessaggio;

	protected string _Messaggio;

	public FatturePassiveMessaggi(AppApiContext objApiContext)
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
				_TipoMessaggio = (FatturePassiveLogTipoMessaggio)((AppAbstractApi)this).ParametersIn["TipoMessaggio"];
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
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "INSERT INTO Fatture_Passive_Messaggi (IdFattura, TipoMessaggio, Messaggio, UteIns, UteAgg) VALUES (";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdFattura) + ", ";
			text = text + "'" + Interaction.IIf(_TipoMessaggio == FatturePassiveLogTipoMessaggio.Errore, (object)"E", (object)"I").ToString() + "', ";
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

	public static FXRETURN RunProc(AppApiContext objApiContext, long IdFattura, FatturePassiveLogTipoMessaggio TipoMessaggio, string Messaggio, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FatturePassiveMessaggi fatturePassiveMessaggi = new FatturePassiveMessaggi(objApiContext);
		((AppAbstractApi)fatturePassiveMessaggi).ParametersIn.Add("IdFattura", IdFattura);
		((AppAbstractApi)fatturePassiveMessaggi).ParametersIn.Add("TipoMessaggio", TipoMessaggio);
		((AppAbstractApi)fatturePassiveMessaggi).ParametersIn.Add("Messaggio", Messaggio);
		((AppAbstractApi)fatturePassiveMessaggi).TransactionManage = false;
		return ((AppAbstractApi)fatturePassiveMessaggi).Run(ref rsMess);
	}
}
