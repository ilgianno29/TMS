using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCViaggiAssociaBC : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InputConferma")]
	private IboWebButton _InputConferma;

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

	[field: AccessedThroughProperty("cpViaggio_Title")]
	protected virtual Panel cpViaggio_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggio_Title_Caption")]
	protected virtual IboWebLabel cpViaggio_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggio_Body")]
	protected virtual Panel cpViaggio_Body
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

	[field: AccessedThroughProperty("lblVettore")]
	protected virtual IboWebLabel lblVettore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVettoreCodice")]
	protected virtual IboWebLabel lblVettoreCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVettoreDescrizione")]
	protected virtual IboWebLabel lblVettoreDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizione")]
	protected virtual IboWebLabel lblTipoSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneCodice")]
	protected virtual IboWebLabel lblTipoSpedizioneCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoSpedizioneDescrizione")]
	protected virtual IboWebLabel lblTipoSpedizioneDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerce")]
	protected virtual IboWebLabel lblTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceCodice")]
	protected virtual IboWebLabel lblTipoMerceCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoMerceDescrizione")]
	protected virtual IboWebLabel lblTipoMerceDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenza")]
	protected virtual IboWebLabel lblPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaCodice")]
	protected virtual IboWebLabel lblPCSPartenzaCodice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSPartenzaDescrizione")]
	protected virtual IboWebLabel lblPCSPartenzaDescrizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Input")]
	protected virtual UpdatePanel up_Input
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggiInput_Title")]
	protected virtual Panel cpViaggiInput_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInput_Title_Caption")]
	protected virtual IboWebLabel cpInput_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpInput_Body")]
	protected virtual Panel cpInput_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInputBarcode")]
	protected virtual IboWebLabel lblInputBarcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputBarcode")]
	protected virtual IboWebTextBox InputBarcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputOptions")]
	protected virtual IboWebRadioButtonList InputOptions
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputErrorMessage")]
	protected virtual IboWebLabel InputErrorMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputOkMessage")]
	protected virtual IboWebLabel InputOkMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton InputConferma
	{
		[CompilerGenerated]
		get
		{
			return _InputConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = InputConferma_Click;
			IboWebButton inputConferma = _InputConferma;
			if (inputConferma != null)
			{
				((Button)inputConferma).Click -= eventHandler;
			}
			_InputConferma = value;
			inputConferma = _InputConferma;
			if (inputConferma != null)
			{
				((Button)inputConferma).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblTotPeso")]
	protected virtual IboWebLabel lblTotPeso
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotPesoValue")]
	protected virtual IboWebLabel lblTotPesoValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotColli")]
	protected virtual IboWebLabel lblTotColli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotColliValue")]
	protected virtual IboWebLabel lblTotColliValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotVolume")]
	protected virtual IboWebLabel lblTotVolume
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotVolumeValue")]
	protected virtual IboWebLabel lblTotVolumeValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotPallet")]
	protected virtual IboWebLabel lblTotPallet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotPalletValue")]
	protected virtual IboWebLabel lblTotPalletValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumDdt")]
	protected virtual IboWebLabel lblNumDdt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumDdtValue")]
	protected virtual IboWebLabel lblNumDdtValue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_Spedizioni")]
	protected virtual UpdatePanel up_Spedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggiSpedizioni_Title")]
	protected virtual Panel cpViaggiSpedizioni_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggiSpedizioni_Title_Caption")]
	protected virtual IboWebLabel cpViaggiSpedizioni_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpViaggiSpedizioni_Body")]
	protected virtual Panel cpViaggiSpedizioni_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggiSpedizioni")]
	protected virtual Panel pnlViaggiSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdViaggiSpedizioni")]
	protected virtual IboGridView grdViaggiSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN PreRenderPage(ref string rsMess)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SetIncasFocusToControl((Control)(object)InputBarcode);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return base.PreRenderPage(ref rsMess);
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.VIAGGI";
		_RaiseIFrameCloseOnDiscard = true;
		_Title = base.Translator.Translate("XXX", "Associazione spedizioni a viaggi per barcode", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.AfterLoadData(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CaricaDatiViaggio(ref rsMess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (FXRETURN)0;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboWebToolbar iboWebToolbar = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdViaggiSpedizioni;
			iboInternalGridConfig.InitUi(myViewState, ref objGridView);
			grdViaggiSpedizioni = objGridView;
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#VIAGGI", "SELECT * FROM GRD_DOC_Viaggi_Spedizioni WHERE IdViaggio='<%IDVIAGGIO%>'", "", "", ((Control)grdViaggiSpedizioni).ID, null);
			GridConfigList.Add(iboInternalGridConfig);
			val = base.InitializeInternalGrid(ref rsMess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}

	protected void InputConferma_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Invalid comparison between Unknown and I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Invalid comparison between Unknown and I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		string rsmess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		string text2 = "";
		try
		{
			CallStackAdd();
			InputErrorMessage.Visible = false;
			InputOkMessage.Visible = false;
			InputErrorMessage.ObjValue = "";
			text = InputBarcode.ObjValue.ToString();
			if (text.Length > 0)
			{
				string text3 = "SELECT <%TOP%> Unibol, IdViaggio, Stato FROM Spedizioni ";
				text3 = text3 + "WHERE Barcode = " + base.DbConn.SQLFormatString(text) + " AND ";
				text3 += "Stato = 20";
				if ((int)base.DbConn.ServerType == 1)
				{
					text3 += " AND ROWNUM <= 1";
					text3 = text3.Replace("<%TOP%>", "");
				}
				else
				{
					text3 = text3.Replace("<%TOP%>", "TOP 1");
				}
				text3 += " ORDER BY UNIBOL DESC";
				val2 = base.DbConn.OpenDataTable(text3, ref dataTable, ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				if (dataTable.Rows.Count == 0)
				{
					rsmess = TranslateMessage("", "Spedizione non trovata tra le attive per il barcode {0}.", InputBarcode.ObjValue.ToString());
					return;
				}
				text2 = dataTable.Rows[0]["Unibol"].ToString();
				if (Operators.CompareString(InputOptions.ObjValue.ToString(), "A", false) == 0)
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["IdViaggio"])))
					{
						rsmess = ((Operators.CompareString(dataTable.Rows[0]["IdViaggio"].ToString(), txtIdViaggio.ObjValue.ToString(), false) != 0) ? TranslateMessage("", "Al barcode {0} corrisponde la spedizione {1} già associata al viaggio {1}.", InputBarcode.ObjValue.ToString(), text2, dataTable.Rows[0]["IdViaggio"].ToString()) : TranslateMessage("", "Al barcode {0} corrisponde la spedizione {1} già associata a questo viaggio.", InputBarcode.ObjValue.ToString(), text2));
						return;
					}
					List<string> list = null;
					list = new List<string>();
					list.Add(text2);
					val2 = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, txtIdViaggio.ObjValue.ToString(), DateAndTime.Now, ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
				}
				else
				{
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["IdViaggio"])))
					{
						rsmess = TranslateMessage("", "Al barcode {0} corrisponde la spedizione {1} non associata ad alcun viaggio.", InputBarcode.ObjValue.ToString(), text2);
						return;
					}
					if (Operators.CompareString(dataTable.Rows[0]["IdViaggio"].ToString(), txtIdViaggio.ObjValue.ToString(), false) != 0)
					{
						rsmess = TranslateMessage("", "Al barcode {0} corrisponde la spedizione {1} associata ad altro viaggio ({2}).", InputBarcode.ObjValue.ToString(), text2, dataTable.Rows[0]["IdViaggio"].ToString());
						return;
					}
					List<string> list2 = null;
					list2 = new List<string>();
					list2.Add(dataTable.Rows[0]["Unibol"].ToString());
					val2 = Spedizione_DisassociaDaViaggio_Invoker.Instance.RunProc(CreateApiContext(), list2, txtIdViaggio.ObjValue.ToString(), ref rsmess);
					if ((int)val2 > 0)
					{
						val = val2;
						return;
					}
				}
				IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggiSpedizioni).ID];
				string rsMess = "";
				InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
				up_Spedizioni.Update();
				val2 = CaricaDatiViaggio(ref rsmess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			try
			{
				InputBarcode.ObjValue = "";
				up_Input.Update();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
			if ((int)val > 0)
			{
				InputErrorMessage.ObjValue = rsmess;
				InputErrorMessage.Visible = true;
			}
			else
			{
				InputOkMessage.ObjValue = text2 + " OK";
				InputOkMessage.Visible = true;
			}
			CallStackRemove();
		}
	}

	protected FXRETURN CaricaDatiViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text = "SELECT SUM(Peso) AS Peso, SUM(Colli) as Colli, SUM(Volume) as Volume, SUM(Pallet) as Pallet, COUNT(Unibol) AS NumeroDDT, IdViaggio ";
			text += "FROM Spedizioni ";
			string text2 = text;
			DBConnection dbConn = base.DbConn;
			string text3 = txtIdViaggio.ObjValue.ToString();
			text = text2 + "WHERE IdViaggio = " + dbConn.SQLFormatNumber(ref text3) + " ";
			text += "GROUP BY IdViaggio";
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (dataTable.Rows.Count == 0)
				{
					lblTotPesoValue.ObjValue = 0.0.ToString("#,##0.#0");
					lblNumDdtValue.ObjValue = 0.ToString("#,##0");
					lblTotColliValue.ObjValue = 0.ToString("#,##0");
					lblTotVolumeValue.ObjValue = 0.ToString("#,##0.###0");
					lblTotPalletValue.ObjValue = 0.ToString("#,##0");
				}
				else
				{
					lblTotPesoValue.ObjValue = Conversions.ToDouble(dataTable.Rows[0]["Peso"]).ToString("#,##0.#0");
					lblNumDdtValue.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["NumeroDDT"]).ToString("#,##0");
					lblTotColliValue.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["Colli"]).ToString("#,##0");
					lblTotPalletValue.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["Pallet"]).ToString("#,##0");
					lblTotVolumeValue.ObjValue = Conversions.ToInteger(dataTable.Rows[0]["Volume"]).ToString("#,##0.###0");
				}
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
			CallStackRemove();
		}
		return result;
	}
}
