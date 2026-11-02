using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class WFFATFattureAttivePilota : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro")]
	private IboWebButton _btnFiltro;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiungi")]
	private IboWebButton _btnAggiungi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTogli")]
	private IboWebButton _btnTogli;

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

	[field: AccessedThroughProperty("cpByQuery_Title")]
	protected virtual Panel cpByQuery_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Title_Caption")]
	protected virtual Label cpByQuery_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpByQuery_Body")]
	protected virtual Panel cpByQuery_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_pnlClienti")]
	protected virtual UpdatePanel up_pnlClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClienti")]
	protected virtual Panel pnlClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlClientiDisponibili")]
	protected virtual Panel pnlClientiDisponibili
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClientiDisponibili")]
	protected virtual IboWebLabel lblClientiDisponibili
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoClientiFiltro")]
	protected virtual IboWebTextBox ElencoClientiFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Click;
			IboWebButton val = _btnFiltro;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro = value;
			val = _btnFiltro;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("ElencoClienti")]
	protected virtual ListBox ElencoClienti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSposta")]
	protected virtual Panel pnlSposta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiungi
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiungi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiungi_Click;
			IboWebButton val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiungi = value;
			val = _btnAggiungi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnTogli
	{
		[CompilerGenerated]
		get
		{
			return _btnTogli;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnTogli_Click;
			IboWebButton val = _btnTogli;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnTogli = value;
			val = _btnTogli;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlElencoClientiDaFatturare")]
	protected virtual Panel pnlElencoClientiDaFatturare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblElencoClientiSelezionati")]
	protected virtual IboWebLabel lblElencoClientiSelezionati
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ElencoClientiDaFatturare")]
	protected virtual ListBox ElencoClientiDaFatturare
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlComandi")]
	protected virtual Panel pnlComandi
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

	[field: AccessedThroughProperty("lblDataInizio")]
	protected virtual IboWebLabel lblDataInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataInizio")]
	protected virtual IboWebDate txtDataInizio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataFine")]
	protected virtual IboWebLabel lblDataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDataFine")]
	protected virtual IboWebDate txtDataFine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFatturaViaggi")]
	protected virtual IboWebLabel lblFatturaViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFatturaViaggi")]
	protected virtual IboWebCheckBox chkFatturaViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFatturaSpedizioni")]
	protected virtual IboWebLabel lblFatturaSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFatturaSpedizioni")]
	protected virtual IboWebCheckBox chkFatturaSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFatturaContrassegni")]
	protected virtual IboWebLabel lblFatturaContrassegni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFatturaContrassegni")]
	protected virtual IboWebCheckBox chkFatturaContrassegni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFatturaGiacenze")]
	protected virtual IboWebLabel lblFatturaGiacenze
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFatturaGiacenze")]
	protected virtual IboWebCheckBox chkFatturaGiacenze
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

	[field: AccessedThroughProperty("txtDataDocumento")]
	protected virtual IboWebDate txtDataDocumento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSezionale")]
	protected virtual IboWebLabel lblSezionale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbSezionale")]
	protected virtual IboWebComboTlk cmbSezionale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTipoPagamento")]
	protected virtual IboWebLabel lblTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbTipoPagamento")]
	protected virtual IboWebComboTlk cmbTipoPagamento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClienteOperativo")]
	protected virtual IboWebLabel lblClienteOperativo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbClienteOperativo")]
	protected virtual IboWebComboTlk cmbClienteOperativo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblMittente")]
	protected virtual IboWebLabel lblMittente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbMittente")]
	protected virtual IboWebComboTlk cmbMittente
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

	[field: AccessedThroughProperty("cmbTipoSpedizione")]
	protected virtual IboWebComboTlk cmbTipoSpedizione
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

	[field: AccessedThroughProperty("cmbTipoMerce")]
	protected virtual IboWebComboTlk cmbTipoMerce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZonaArrivo")]
	protected virtual IboWebLabel lblZonaArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbZonaArrivo")]
	protected virtual IboWebComboTlk cmbZonaArrivo
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

	[field: AccessedThroughProperty("cmbPCSPartenza")]
	protected virtual IboWebComboTlk cmbPCSPartenza
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPCSArrivo")]
	protected virtual IboWebLabel lblPCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbPCSArrivo")]
	protected virtual IboWebComboTlk cmbPCSArrivo
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
		_Context = "DM.FAT.FATTUREATTIVE_TESTATA";
		_Title = base.Translator.Translate("XXX", "Generazione fatture attive", new string[0]);
		FXRETURN result = base.InitializedPage(ref rsMess);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN LoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = LoadTables("", ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = base.LoadData(ref rsMess);
				if ((int)val2 <= 0)
				{
					val = (FXRETURN)0;
				}
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
				string text = cmbSezionale.SqlQuery + " WHERE " + cmbSezionale.SqlQueryFilter;
				DataTable dataTable = null;
				val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (dataTable.Rows.Count == 1)
					{
						cmbSezionale.ObjValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["Codice"]);
					}
					else if (Operators.CompareString(base.ApplicationDefault.SezionaleAttivoDefault(), "", false) != 0)
					{
						cmbSezionale.ObjValue = base.ApplicationDefault.SezionaleAttivoDefault();
					}
					val = (FXRETURN)0;
				}
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

	protected override FXRETURN AfterSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.AfterSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected override FXRETURN BeforeSaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeSaveData(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected override FXRETURN BeforeLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.BeforeLoadData(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected override FXRETURN LoadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.LoadPage(ref rsMess);
			if ((int)val2 <= 0)
			{
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((ListControl)ElencoClientiDaFatturare).Items.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Non è stato selezionato nessun cliente da fatturare");
				((Control)ElencoClientiDaFatturare).Focus();
				val = (FXRETURN)4;
			}
			else
			{
				val2 = base.CheckData(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else if (DateTime.Compare(txtDataInizio.getDateValue, txtDataFine.getDateValue) > 0)
				{
					rsMess = TranslateMessage("XXX", "Valori data non validi");
					txtDataInizio.Focus();
					val = (FXRETURN)4;
				}
				else
				{
					val = (FXRETURN)0;
				}
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Invalid comparison between Unknown and I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			foreach (ListItem item in ((ListControl)ElencoClientiDaFatturare).Items)
			{
				ListItem val3 = item;
				text += "INSERT INTO  Fatture_Attive_Pilota (Cliente, FatturaViaggi, FatturaSpedizioni, FatturaContrassegni, FatturaGiacenze, DataInizio, DataFine, DataDocumento, Sezionale, ";
				text += "TipoPagamento, ClienteOperativo, Mittente, TipoSpedizione, TipoMerce, ZonaArrivo, PCSPartenza, PCSArrivo) VALUES (";
				text = text + base.DbConn.SQLFormatString(val3.Value.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(chkFatturaViaggi.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(chkFatturaSpedizioni.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(chkFatturaContrassegni.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(chkFatturaGiacenze.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatDate((eTipoData)1, txtDataInizio.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatDate((eTipoData)1, txtDataFine.ObjValue.ToString()) + ",";
				text = ((Operators.CompareString(txtDataDocumento.ObjValue.ToString(), "", false) == 0) ? (text + "NULL,") : (text + base.DbConn.SQLFormatDate((eTipoData)1, txtDataDocumento.ObjValue.ToString()) + ","));
				text = text + base.DbConn.SQLFormatString(cmbSezionale.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbTipoPagamento.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbClienteOperativo.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbMittente.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbTipoSpedizione.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbTipoMerce.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbZonaArrivo.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbPCSPartenza.ObjValue.ToString()) + ",";
				text = text + base.DbConn.SQLFormatString(cmbPCSArrivo.ObjValue.ToString()) + ");";
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_037f;
			}
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_037f;
			}
			val = val2;
			goto end_IL_000b;
			IL_037f:
			val = (FXRETURN)0;
			end_IL_000b:;
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

	private void btnFiltro_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = LoadTables(ElencoClientiFiltro.ObjValue.ToString(), ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnAggiungi_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			foreach (ListItem item in ((ListControl)ElencoClienti).Items)
			{
				ListItem val3 = item;
				if (val3.Selected && !((ListControl)ElencoClientiDaFatturare).Items.Contains(val3))
				{
					((ListControl)ElencoClientiDaFatturare).Items.Add(new ListItem(val3.Text, val3.Value));
				}
			}
			val2 = LoadTables(ElencoClientiFiltro.ObjValue.ToString(), ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnTogli_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			StringCollection stringCollection = new StringCollection();
			foreach (ListItem item in ((ListControl)ElencoClientiDaFatturare).Items)
			{
				ListItem val3 = item;
				if (val3.Selected)
				{
					stringCollection.Add(val3.Value);
				}
			}
			StringEnumerator enumerator2 = stringCollection.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string current = enumerator2.Current;
				((ListControl)ElencoClientiDaFatturare).Items.Remove(((ListControl)ElencoClientiDaFatturare).Items.FindByValue(current));
			}
			val2 = LoadTables(ElencoClientiFiltro.ObjValue.ToString(), ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	protected FXRETURN LoadTables(string Filtro, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "SELECT * FROM VW_CLIENTI_FATTURAZIONE WHERE 1=1 ";
			if (Operators.CompareString(Filtro, "", false) != 0)
			{
				text = text + " AND DESCRIZIONE LIKE '%" + Filtro.Replace("'", "''") + "%'";
			}
			if (((ListControl)ElencoClientiDaFatturare).Items.Count > 0)
			{
				text += " AND CODICE NOT IN (";
			}
			foreach (ListItem item in ((ListControl)ElencoClientiDaFatturare).Items)
			{
				ListItem val3 = item;
				text = text + base.DbConn.SQLFormatString(val3.Value) + ",";
			}
			if (((ListControl)ElencoClientiDaFatturare).Items.Count > 0)
			{
				text = Strings.Left(text, checked(Strings.Len(text) - 1));
				text += ")";
			}
			text += " ORDER BY DESCRIZIONE";
			DataTable dataTable = null;
			val2 = base.DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				((ListControl)ElencoClienti).Items.Clear();
				foreach (DataRow row in dataTable.Rows)
				{
					((ListControl)ElencoClienti).Items.Add(new ListItem(row["DESCRIZIONE"].ToString(), row["CODICE"].ToString()));
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

	private FXRETURN DecodificaCliente(string vsCodice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			text2 = "SELECT CODICEPAGAMENTO FROM CLIENTI WHERE CODICE = " + base.DbConn.SQLFormatString(vsCodice);
			val2 = base.DbConn.OpenDataTable(text2, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataTable.Rows.Count == 1 && Operators.CompareString(cmbTipoPagamento.ObjValue.ToString(), "", false) == 0)
				{
					ComboSelectedItem((IIboDropdownList)(object)cmbTipoPagamento, dataTable.Rows[0]["CODICEPAGAMENTO"].ToString(), ref rsMess);
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
}
