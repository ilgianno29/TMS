using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioniDocumenti : WFIDBPage
{
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

	[field: AccessedThroughProperty("cpGeneralita_Title")]
	protected virtual Panel cpGeneralita_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeneralita_Title_Caption")]
	protected virtual Label cpGeneralita_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGeneralita_Body")]
	protected virtual Panel cpGeneralita_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblUnibolCaption")]
	protected virtual IboWebLabel lblUnibolCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoSoggetto")]
	protected virtual HiddenField TipoSoggetto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUnibol")]
	protected virtual IboWebLabel txtUnibol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtId")]
	protected virtual IboWebTextBox txtId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIdDocumento")]
	protected virtual IboWebTextBox txtIdDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumero2")]
	protected virtual IboWebLabel lblNumero2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumero")]
	protected virtual IboWebLabel lblNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNumero")]
	protected virtual IboWebTextBox txtNumero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataDocumento")]
	protected virtual IboWebLabel lblDataDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtData")]
	protected virtual IboWebDate txtData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPrg")]
	protected virtual IboWebLabel lblPrg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPrg")]
	protected virtual IboWebNumericTlk txtPrg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoDocumento")]
	protected virtual IboWebLabel lblTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoDocumento")]
	protected virtual IboWebComboTlk cmbTipoDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNote")]
	protected virtual IboWebLabel lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNote")]
	protected virtual IboWebTextBox txtNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title")]
	protected virtual Panel cpFoto_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Title_Caption")]
	protected virtual IboWebLabel cpFoto_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpFoto_Body")]
	protected virtual Panel cpFoto_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblImmagine1")]
	protected virtual IboWebLabel lblImmagine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Documento")]
	protected virtual IboWebImage Documento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		_Context = "DM.DOC.SPEDIZIONI.DOCUMENTI";
		_Title = base.Translator.Translate("XXX", "Documenti di spedizione", new string[0]);
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
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!((Operators.CompareString(_objFunctionArguments.Name, "MODIFICA", false) == 0) | (Operators.CompareString(_objFunctionArguments.Name, "VISUALIZZAZIONE", false) == 0)))
			{
				goto IL_0112;
			}
			string text = "SELECT * FROM Documenti WHERE IdDocumento=" + base.DbConn.SQLFormatString(txtIdDocumento.ObjValue.ToString());
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 <= 0)
			{
				if (dataTable.Rows.Count > 0)
				{
					IboWebImage documento = Documento;
					documento.FileExtension = dataTable.Rows[0]["DocumentoEstensione"].ToString();
					documento.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Documento"]);
					documento.OriginalImageUrl = documento.ImageUrl;
				}
				goto IL_0112;
			}
			val = val2;
			goto end_IL_0005;
			IL_0112:
			val = (FXRETURN)0;
			end_IL_0005:;
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
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
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Invalid comparison between Unknown and I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Invalid comparison between Unknown and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			List<byte[]> list = new List<byte[]>();
			string text = "SELECT COUNT(*) FROM Documenti WHERE IdDocumento=" + base.DbConn.SQLFormatString(txtIdDocumento.ObjValue.ToString());
			object obj = null;
			val2 = base.DbConn.DoSql(text, ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (Conversions.ToInteger(obj) > 0)
			{
				IboWebImage documento = Documento;
				if (documento.ObjValue != null)
				{
					list.Add((byte[])documento.ObjValue);
				}
				text = "UPDATE DOCUMENTI SET Documento = :1 , ";
				text = text + "DocumentoEstensione = " + base.DbConn.SQLFormatString(documento.FileExtension) + ", ";
				text = text + "UteAgg = " + base.DbConn.SQLFormatString(base.WFIUser) + ", ";
				text = text + "DatAgg = " + base.DbConn.GetDate() + " ";
				string text2 = text;
				DBConnection dbConn = base.DbConn;
				int num = Conversions.ToInteger(txtIdDocumento.ObjValue);
				text = text2 + "WHERE IdDocumento = " + dbConn.SQLFormatNumber(ref num);
				val2 = base.DbConn.SqlExecBlobHelper(text, list, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_028e;
				}
				val = val2;
			}
			else
			{
				if (Documento.ObjValue == null)
				{
					goto IL_028e;
				}
				text = "INSERT INTO DOCUMENTI (IdDocumento, Documento, DocumentoEstensione, UteIns, UteAgg) VALUES (";
				string text3 = text;
				DBConnection dbConn2 = base.DbConn;
				int num = Conversions.ToInteger(txtIdDocumento.ObjValue);
				text = text3 + dbConn2.SQLFormatNumber(ref num) + ", ";
				IboWebImage documento2 = Documento;
				text += " :1 ,";
				if (documento2.ObjValue != null)
				{
					list.Add((byte[])documento2.ObjValue);
				}
				if (Operators.CompareString(documento2.FileExtension, "", false) != 0)
				{
					text = text + base.DbConn.SQLFormatString(documento2.FileExtension) + ",";
				}
				text = text + base.DbConn.SQLFormatString(base.WFIUser) + ", ";
				text = text + base.DbConn.SQLFormatString(base.WFIUser) + ")";
				val2 = base.DbConn.SqlExecBlobHelper(text, list, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_028e;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_028e:
			val2 = base.BeforeSaveData(ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			end_IL_0005:;
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
}
