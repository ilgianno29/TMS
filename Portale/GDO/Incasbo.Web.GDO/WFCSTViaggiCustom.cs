using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI.WebControls;
using Incasbo.MiocNew;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFCSTViaggiCustom : WFIDBPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnInvioRichiesta")]
	private IboWebButton _btnInvioRichiesta;

	[field: AccessedThroughProperty("DetailFormMainDiv")]
	protected virtual Panel DetailFormMainDiv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitle")]
	protected virtual IboWebLabel lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgModalita")]
	protected virtual Image imgModalita
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title")]
	protected virtual Panel cpInfoGen_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Title_Caption")]
	protected virtual Label cpInfoGen_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblIdViaggio")]
	protected virtual IboWebLabel lblIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdViaggio")]
	protected virtual IboWebTextBox txtIdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnInvioRichiesta
	{
		[CompilerGenerated]
		get
		{
			return _btnInvioRichiesta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnInvioRichiesta_Click;
			IboWebButton val = _btnInvioRichiesta;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnInvioRichiesta = value;
			val = _btnInvioRichiesta;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblMiocPrenotazione")]
	protected virtual IboWebLabel lblMiocPrenotazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMiocPrenotazione")]
	protected virtual IboWebTextBox txtMiocPrenotazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMiocRichiesta")]
	protected virtual IboWebLabel lblMiocRichiesta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkMiocRichiesta")]
	protected virtual IboWebCheckBox chkMiocRichiesta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataArrivoTP")]
	protected virtual IboWebLabel lblDataArrivoTP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataArrivoTP")]
	protected virtual IboWebDate2 DataArrivoTP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrenotazioneMerce")]
	protected virtual IboWebTextBox txtPrenotazioneMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrenotazioneVettore")]
	protected virtual IboWebTextBox txtPrenotazioneVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrenotazioneStabilimento")]
	protected virtual IboWebTextBox txtPrenotazioneStabilimento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrenotazioneMezzo")]
	protected virtual IboWebTextBox txtPrenotazioneMezzo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrenotazioneData")]
	protected virtual IboWebTextBox txtPrenotazioneData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (FXRETURN)0;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.VIAGGI";
		_TabellaLoad = "CST_VW_VIAGGICUSTOM";
		_TabellaSave = "CST_VIAGGI";
		_objFunctionArguments.Name = "MODIFICA";
		_Title = base.Translator.Translate("XXX", "Campi Custom Viaggi", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN AfterCheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterCheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				goto IL_005f;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		result = base.AfterCheckData(ref rsMess);
		goto IL_005f;
		IL_005f:
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (Operators.CompareString(chkMiocRichiesta.ObjValue.ToString(), "S", false) == 0)
				{
					btnInvioRichiesta.Visible = false;
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private void btnInvioRichiesta_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Invalid comparison between Unknown and I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Invalid comparison between Unknown and I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Invalid comparison between Unknown and I4
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Invalid comparison between Unknown and I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Invalid comparison between Unknown and I4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		object obj = null;
		object obj2 = null;
		int num = 0;
		int num2 = 0;
		object obj3 = null;
		object obj4 = null;
		DataTable dataTable = null;
		try
		{
			CallStackAdd();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			prenotazionioutboundWS prenotazionioutboundWS = new prenotazionioutboundWS();
			prenotazionioutboundWS.Url = base.ApplicationParams.Custom.MiocUrlNew();
			PrenotazioneOutbound prenotazioneOutbound = new PrenotazioneOutbound();
			StreamWriter streamWriter = null;
			string text = "C:\\Temp\\";
			string text2 = "LogPrenotazioni.txt";
			streamWriter = new StreamWriter(text + text2, append: true, Encoding.Default);
			string text3 = "SELECT count(UNIBOL) AS Unibol FROM Spedizioni ";
			string text4 = text3;
			DBConnection dbConn = base.DbConn;
			long num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
			text3 = text4 + "WHERE IdViaggio = " + dbConn.SQLFormatNumber(ref num3);
			val2 = base.DbConn.DoSql(text3, ref obj3, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(obj3));
			if (num == 1)
			{
				text3 = "SELECT SUM(Peso) AS Peso FROM Spedizioni S INNER JOIN Viaggi V ON V.IdViaggio = S.IdViaggio AND V.PCSPartenza = S.PCSPartenza ";
				string text5 = text3;
				DBConnection dbConn2 = base.DbConn;
				num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
				text3 = text5 + "WHERE V.IdViaggio = " + dbConn2.SQLFormatNumber(ref num3);
				val2 = base.DbConn.DoSql(text3, ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				DBConnection dbConn3 = base.DbConn;
				num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
				string text6 = "SELECT PCSPARTENZA FROM Viaggi WHERE IdViaggio = " + dbConn3.SQLFormatNumber(ref num3);
				val2 = base.DbConn.DoSql(text6, ref obj2, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				prenotazioneOutbound.v_merce = txtPrenotazioneMerce.ObjValue.ToString();
				prenotazioneOutbound.v_mezzo = txtPrenotazioneMezzo.ObjValue.ToString();
				if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtPrenotazioneData.ObjValue)))
				{
					prenotazioneOutbound.d_dataprenotazione = Conversions.ToDate(txtPrenotazioneData.ObjValue).ToString("yyyy-MM-dd");
				}
				if (Operators.CompareString(Conversions.ToString(obj2), "D", false) == 0)
				{
					prenotazioneOutbound.v_stabilimento = "2";
				}
				else if (Operators.CompareString(Conversions.ToString(obj2), "G", false) == 0)
				{
					prenotazioneOutbound.v_stabilimento = "3";
				}
				else
				{
					prenotazioneOutbound.v_stabilimento = txtPrenotazioneStabilimento.ObjValue.ToString();
				}
				prenotazioneOutbound.v_vettore = txtPrenotazioneVettore.ObjValue.ToString();
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
				{
					prenotazioneOutbound.n_peso = "0";
				}
				else
				{
					prenotazioneOutbound.n_peso = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(obj)).ToString(CultureInfo.InvariantCulture);
				}
				prenotazioneOutbound.v_udm = "KG";
				prenotazioneOutbound.v_idviaggio = Conversions.ToString(txtIdViaggio.ObjValue);
			}
			else
			{
				text3 = "SELECT count(PCSPARTENZA) AS NPCSP FROM Spedizioni ";
				string text7 = text3;
				DBConnection dbConn4 = base.DbConn;
				num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
				text3 = text7 + "WHERE IdViaggio = " + dbConn4.SQLFormatNumber(ref num3);
				val2 = base.DbConn.DoSql(text3, ref obj4, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(obj4));
				if (num2 == 1)
				{
					text3 = "SELECT SUM(Peso) AS Peso FROM Spedizioni S INNER JOIN Viaggi V ON V.IdViaggio = S.IdViaggio AND V.PCSPartenza = S.PCSPartenza ";
					string text8 = text3;
					DBConnection dbConn5 = base.DbConn;
					num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
					text3 = text8 + "WHERE V.IdViaggio = " + dbConn5.SQLFormatNumber(ref num3);
					val2 = base.DbConn.DoSql(text3, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					DBConnection dbConn6 = base.DbConn;
					num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
					string text6 = "SELECT PCSPARTENZA FROM Viaggi WHERE IdViaggio = " + dbConn6.SQLFormatNumber(ref num3);
					val2 = base.DbConn.DoSql(text6, ref obj2, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					prenotazioneOutbound.v_merce = txtPrenotazioneMerce.ObjValue.ToString();
					prenotazioneOutbound.v_mezzo = txtPrenotazioneMezzo.ObjValue.ToString();
					if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtPrenotazioneData.ObjValue)))
					{
						prenotazioneOutbound.d_dataprenotazione = Conversions.ToDate(txtPrenotazioneData.ObjValue).ToString("yyyy-MM-dd");
					}
					if (Operators.CompareString(Conversions.ToString(obj2), "D", false) == 0)
					{
						prenotazioneOutbound.v_stabilimento = "2";
					}
					else if (Operators.CompareString(Conversions.ToString(obj2), "G", false) == 0)
					{
						prenotazioneOutbound.v_stabilimento = "3";
					}
					else
					{
						prenotazioneOutbound.v_stabilimento = txtPrenotazioneStabilimento.ObjValue.ToString();
					}
					prenotazioneOutbound.v_vettore = txtPrenotazioneVettore.ObjValue.ToString();
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
					{
						prenotazioneOutbound.n_peso = "0";
					}
					else
					{
						prenotazioneOutbound.n_peso = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(obj)).ToString(CultureInfo.InvariantCulture);
					}
					prenotazioneOutbound.v_udm = "KG";
					prenotazioneOutbound.v_idviaggio = Conversions.ToString(txtIdViaggio.ObjValue);
				}
				else
				{
					text3 = "SELECT SUM(Peso) AS Peso FROM Spedizioni S INNER JOIN Viaggi V ON V.IdViaggio = S.IdViaggio AND V.PCSPartenza = S.PCSPartenza ";
					string text9 = text3;
					DBConnection dbConn7 = base.DbConn;
					num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
					text3 = text9 + "WHERE V.IdViaggio = " + dbConn7.SQLFormatNumber(ref num3);
					val2 = base.DbConn.DoSql(text3, ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					string text6 = "SELECT (spedizioni.PCSPARTENZA) AS PCSPARTENZA, min(spedizioni.sequenzapianificata) sequenzapianificata ";
					text6 += "FROM Viaggi inner join spedizioni on viaggi.idviaggio = spedizioni.idviaggio ";
					string text10 = text6;
					DBConnection dbConn8 = base.DbConn;
					num3 = Conversions.ToLong(txtIdViaggio.ObjValue);
					text6 = text10 + "WHERE viaggi.IdViaggio = " + dbConn8.SQLFormatNumber(ref num3) + " ";
					text6 += "group by spedizioni.PCSPARTENZA, spedizioni.SequenzaPianificata order by spedizioni.SequenzaPianificata";
					val2 = base.DbConn.OpenDataTable(text6, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
					prenotazioneOutbound.v_merce = txtPrenotazioneMerce.ObjValue.ToString();
					prenotazioneOutbound.v_mezzo = txtPrenotazioneMezzo.ObjValue.ToString();
					if (Information.IsDate(RuntimeHelpers.GetObjectValue(txtPrenotazioneData.ObjValue)))
					{
						prenotazioneOutbound.d_dataprenotazione = Conversions.ToDate(txtPrenotazioneData.ObjValue).ToString("yyyy-MM-dd");
					}
					prenotazioneOutbound.v_vettore = txtPrenotazioneVettore.ObjValue.ToString();
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
					{
						prenotazioneOutbound.n_peso = "0";
					}
					else
					{
						prenotazioneOutbound.n_peso = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(obj)).ToString(CultureInfo.InvariantCulture);
					}
					prenotazioneOutbound.v_udm = "KG";
					prenotazioneOutbound.v_idviaggio = Conversions.ToString(txtIdViaggio.ObjValue);
					string text11 = "";
					int num4 = 0;
					foreach (DataRow row in dataTable.Rows)
					{
						if (num4 > 0)
						{
							text11 += "_";
						}
						text11 = ((Operators.CompareString(row["PCSPARTENZA"].ToString(), "D", false) != 0) ? ((Operators.CompareString(row["PCSPARTENZA"].ToString(), "G", false) != 0) ? (text11 + txtPrenotazioneStabilimento.ObjValue.ToString()) : (text11 + "3")) : (text11 + "2"));
						num4 = checked(num4 + 1);
					}
					prenotazioneOutbound.v_stabilimento = text11;
				}
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)))
			{
				try
				{
					Response response = prenotazionioutboundWS.setPrenotazioneOutbound(prenotazioneOutbound);
					if (response == null || !Conversions.ToBoolean(response.@return.esito))
					{
						rsMess = ((response != null) ? response.@return.messaggio : "Nessuna risposta dal web service.");
						val = (FXRETURN)4;
						return;
					}
					txtMiocPrenotazione.ObjValue = response.@return.messaggio;
					streamWriter.Write(prenotazioneOutbound.v_stabilimento.ToString() + Environment.NewLine);
					streamWriter.Write("******" + Environment.NewLine);
					streamWriter.Write(response.@return.messaggio + Environment.NewLine);
					streamWriter.Close();
					streamWriter = null;
				}
				catch (TimeoutException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					TimeoutException ex2 = ex;
					rsMess = "Timeout nella comunicazione con il web service.";
					val = (FXRETURN)4;
					ProjectData.ClearProjectError();
					return;
				}
				catch (WebException ex3)
				{
					ProjectData.SetProjectError((Exception)ex3);
					WebException ex4 = ex3;
					rsMess = "Errore di rete durante la chiamata al web service: " + ex4.Message;
					val = (FXRETURN)4;
					ProjectData.ClearProjectError();
					return;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					rsMess = "Errore imprevisto durante la richiesta: " + ex6.Message;
					val = (FXRETURN)4;
					ProjectData.ClearProjectError();
					return;
				}
				chkMiocRichiesta.ObjValue = "S";
				btnInvioRichiesta.Visible = false;
				val2 = SaveData(ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
			else
			{
				rsMess = "Il campo PESO e' obbligatorio! PCS diversi.";
				val = (FXRETURN)4;
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception objEx = ex7;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}
}
