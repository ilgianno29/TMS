using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI.ObjectManager;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.WFI;

public class WFStandardGrid : WFIPage
{
	protected enum GridMode
	{
		Standard,
		Combo,
		OnlyView,
		Details,
		Test
	}

	protected enum GridSortMode
	{
		DbSort,
		DataTableSort
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnClosePrintingMode")]
	private IboWebButton _btnClosePrintingMode;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkAutoUpdate")]
	private CheckBox _chkAutoUpdate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdGriglia")]
	private IboGridView _grdGriglia;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSelezionaTutto")]
	private IboWebButton _btnSelezionaTutto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDeselezionaTutto")]
	private IboWebButton _btnDeselezionaTutto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAnnulla")]
	private IboWebButton _btnAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConferma")]
	private IboWebButton _btnConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnButtonBack")]
	private IboWebButton _btnButtonBack;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ddlFiltroCampo")]
	private IboDropDownList _ddlFiltroCampo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Aggiungi")]
	private IboWebButton _btnFiltro_Aggiungi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Aggiungi2")]
	private IboWebButton _btnFiltro_Aggiungi2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Elimina")]
	private IboWebButton _btnFiltro_Elimina;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroAnnulla")]
	private IboWebButton _btnFiltroAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroConferma")]
	private IboWebButton _btnFiltroConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ddlFiltroSalvato_V2")]
	private IboDropDownList _ddlFiltroSalvato_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroSalva")]
	private IboWebButton _btnFiltroSalva;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroCancella")]
	private IboWebButton _btnFiltroCancella;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ddlFiltroCampo_V2")]
	private IboDropDownList _ddlFiltroCampo_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Aggiungi_V2")]
	private IboWebButton _btnFiltro_Aggiungi_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Aggiungi2_V2")]
	private IboWebButton _btnFiltro_Aggiungi2_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltro_Elimina_V2")]
	private IboWebButton _btnFiltro_Elimina_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroAnnulla_V2")]
	private IboWebButton _btnFiltroAnnulla_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnFiltroConferma_V2")]
	private IboWebButton _btnFiltroConferma_V2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExportAnnulla")]
	private IboWebButton _btnExportAnnulla;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExportConferma")]
	private IboWebButton _btnExportConferma;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tmrUpdate")]
	private Timer _tmrUpdate;

	protected IboGridInfo _GridInfo;

	protected IboWebToolbarInfo _ToolbarInfo;

	protected IboWebGridConfig _GridConfig;

	protected IboWebToolbarConfig _ToolbarConfig;

	protected string sNomRif;

	protected string _Utente;

	protected bool _ResetGridInfoList;

	protected bool _ReturnToSelectedRecord;

	protected GridMode _Mode;

	protected GridSortMode _SortMode;

	protected bool _SendExportedFile;

	protected string _FilterVersion;

	[field: AccessedThroughProperty("pnlMain")]
	protected virtual Panel pnlMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlDataGridPrint")]
	protected virtual Panel pnlDataGridPrint
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnPrint")]
	protected virtual IboWebButton btnPrint
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnClosePrintingMode
	{
		[CompilerGenerated]
		get
		{
			return _btnClosePrintingMode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnClosePrintingMode_Click;
			IboWebButton val = _btnClosePrintingMode;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnClosePrintingMode = value;
			val = _btnClosePrintingMode;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlMainGrid_Intestazione")]
	protected virtual Panel pnlMainGrid_Intestazione
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

	[field: AccessedThroughProperty("lblFilter")]
	protected virtual IboWebLabel lblFilter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroRecordTotali")]
	protected virtual IboWebLabel lblNumeroRecordTotali
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMainGrid_Griglia")]
	protected virtual Panel pnlMainGrid_Griglia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlgrd")]
	protected virtual Panel pnlgrd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeader")]
	protected virtual Panel GridHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderTable")]
	protected virtual Table GridHeaderTable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderTableRow")]
	protected virtual TableRow GridHeaderTableRow
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellTitle")]
	protected virtual TableCell GridHeaderCellTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellInfo")]
	protected virtual ImageButton GridHeaderCellInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellAction")]
	protected virtual ImageButton GridHeaderCellAction
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellLegendContainer")]
	protected virtual Panel GridHeaderCellLegendContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellLegend")]
	protected virtual ImageButton GridHeaderCellLegend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hme_GridHeaderCellLegend")]
	protected virtual HoverMenuExtender hme_GridHeaderCellLegend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LegendPopupMenu")]
	protected virtual Panel LegendPopupMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LegendCaption")]
	protected virtual IboWebLabel LegendCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LegendContentPopupMenu")]
	protected virtual Panel LegendContentPopupMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LegendContentPopupMenu2")]
	protected virtual Panel LegendContentPopupMenu2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCaption")]
	protected virtual IboWebLabel GridHeaderCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderIdleCell")]
	protected virtual TableCell GridHeaderIdleCell
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual CheckBox chkAutoUpdate
	{
		[CompilerGenerated]
		get
		{
			return _chkAutoUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = chkAutoUpdate_CheckedChanged;
			CheckBox val = _chkAutoUpdate;
			if (val != null)
			{
				val.CheckedChanged -= eventHandler;
			}
			_chkAutoUpdate = value;
			val = _chkAutoUpdate;
			if (val != null)
			{
				val.CheckedChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("GridHeaderCellSearchText")]
	protected virtual TableCell GridHeaderCellSearchText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GridHeaderCellSearchTextPanel")]
	protected virtual Panel GridHeaderCellSearchTextPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPagerSearchText")]
	protected virtual IboWebLabel lblPagerSearchText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPagerSearchText")]
	protected virtual IboWebTextBox txtPagerSearchText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnPagerSearchText")]
	protected virtual ImageButton btnPagerSearchText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnPagerSearchSvuotaFiltro")]
	protected virtual ImageButton btnPagerSearchSvuotaFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("up_grdGriglia")]
	protected virtual UpdatePanel up_grdGriglia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdGriglia
	{
		[CompilerGenerated]
		get
		{
			return _grdGriglia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			GridViewPageEventHandler val = new GridViewPageEventHandler(grdGriglia_PageIndexChanging);
			GridViewRowEventHandler val2 = new GridViewRowEventHandler(grdGriglia_RowDataBound);
			EventHandler eventHandler = grdGriglia_PreRender;
			GridViewSortEventHandler val3 = new GridViewSortEventHandler(grdGriglia_Sorting);
			IboGridView val4 = _grdGriglia;
			if (val4 != null)
			{
				((GridView)val4).PageIndexChanging -= val;
				((GridView)val4).RowDataBound -= val2;
				((Control)val4).PreRender -= eventHandler;
				((GridView)val4).Sorting -= val3;
			}
			_grdGriglia = value;
			val4 = _grdGriglia;
			if (val4 != null)
			{
				((GridView)val4).PageIndexChanging += val;
				((GridView)val4).RowDataBound += val2;
				((Control)val4).PreRender += eventHandler;
				((GridView)val4).Sorting += val3;
			}
		}
	}

	[field: AccessedThroughProperty("pnlCommands")]
	protected virtual Panel pnlCommands
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnSelezionaTutto
	{
		[CompilerGenerated]
		get
		{
			return _btnSelezionaTutto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSelezionaTutto_Click;
			IboWebButton val = _btnSelezionaTutto;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnSelezionaTutto = value;
			val = _btnSelezionaTutto;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnDeselezionaTutto
	{
		[CompilerGenerated]
		get
		{
			return _btnDeselezionaTutto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnDeselezionaTutto_Click;
			IboWebButton val = _btnDeselezionaTutto;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnDeselezionaTutto = value;
			val = _btnDeselezionaTutto;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAnnulla_Click;
			IboWebButton val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAnnulla = value;
			val = _btnAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnConferma_Click;
			IboWebButton val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnConferma = value;
			val = _btnConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("pnlBackButton")]
	protected virtual Panel pnlBackButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnButtonBack
	{
		[CompilerGenerated]
		get
		{
			return _btnButtonBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnButtonBack_Click;
			IboWebButton val = _btnButtonBack;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnButtonBack = value;
			val = _btnButtonBack;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("UP_pnlFiltroContainer")]
	protected virtual UpdatePanel UP_pnlFiltroContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro")]
	protected virtual IboWebPanel pnlFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro1")]
	protected virtual Panel pnlFiltro1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroTitolo")]
	protected virtual IboWebLabel lblFiltroTitolo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPpnlFiltro")]
	protected virtual UpdatePanel UPpnlFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroCampoDesc")]
	protected virtual IboWebLabel lblFiltroCampoDesc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList ddlFiltroCampo
	{
		[CompilerGenerated]
		get
		{
			return _ddlFiltroCampo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ddlFiltroCampo_SelectedIndexChanged;
			IboDropDownList val = _ddlFiltroCampo;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_ddlFiltroCampo = value;
			val = _ddlFiltroCampo;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroOperatore")]
	protected virtual IboWebLabel lblFiltroOperatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFiltroOperatore")]
	protected virtual IboDropDownList ddlFiltroOperatore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroVal")]
	protected virtual IboWebLabel lblFiltroVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlAddCondition")]
	protected virtual Panel pnlAddCondition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroNumericVal")]
	protected virtual IboWebNumericTlk txtFiltroNumericVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroDateVal")]
	protected virtual IboWebDate2 txtFiltroDateVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroStringVal")]
	protected virtual IboWebTextBox txtFiltroStringVal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro_Aggiungi
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Aggiungi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Aggiungi_Click;
			IboWebButton val = _btnFiltro_Aggiungi;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Aggiungi = value;
			val = _btnFiltro_Aggiungi;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnFiltro_Aggiungi2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Aggiungi2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Aggiungi_Click;
			IboWebButton val = _btnFiltro_Aggiungi2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Aggiungi2 = value;
			val = _btnFiltro_Aggiungi2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroTot")]
	protected virtual IboWebLabel lblFiltroTot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lstFiltroTot")]
	protected virtual ListBox lstFiltroTot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro_Elimina
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Elimina;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Elimina_Click;
			IboWebButton val = _btnFiltro_Elimina;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Elimina = value;
			val = _btnFiltro_Elimina;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("Ibowebbutton1Idle")]
	protected virtual IboWebButton Ibowebbutton1Idle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltroAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroAnnulla_Click;
			IboWebButton val = _btnFiltroAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroAnnulla = value;
			val = _btnFiltroAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnFiltroConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroConferma_Click;
			IboWebButton val = _btnFiltroConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroConferma = value;
			val = _btnFiltroConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("popFiltro")]
	protected virtual ModalPopupExtender popFiltro
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForModalPopup")]
	protected virtual Button hiddenTargetControlForModalPopup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_pnlFiltroContainerV2")]
	protected virtual UpdatePanel UP_pnlFiltroContainerV2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro_V2")]
	protected virtual IboWebPanel pnlFiltro_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlFiltro1_V2")]
	protected virtual Panel pnlFiltro1_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroTitolo_V2")]
	protected virtual IboWebLabel lblFiltroTitolo_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UPpnlFiltro_V2")]
	protected virtual UpdatePanel UPpnlFiltro_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroSalvato")]
	protected virtual IboWebLabel lblFiltroSalvato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList ddlFiltroSalvato_V2
	{
		[CompilerGenerated]
		get
		{
			return _ddlFiltroSalvato_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ddlFiltroSalvato_V2_SelectedIndexChanged;
			IboDropDownList val = _ddlFiltroSalvato_V2;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_ddlFiltroSalvato_V2 = value;
			val = _ddlFiltroSalvato_V2;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnFiltroSalva
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroSalva;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroSalva_Click;
			IboWebButton val = _btnFiltroSalva;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroSalva = value;
			val = _btnFiltroSalva;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroDescrizione_V2")]
	protected virtual IboWebLabel lblFiltroDescrizione_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroDescrizione_V2")]
	protected virtual IboWebTextBox txtFiltroDescrizione_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltroCancella
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroCancella;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroCancella_Click;
			IboWebButton val = _btnFiltroCancella;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroCancella = value;
			val = _btnFiltroCancella;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroCampoDesc_V2")]
	protected virtual IboWebLabel lblFiltroCampoDesc_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList ddlFiltroCampo_V2
	{
		[CompilerGenerated]
		get
		{
			return _ddlFiltroCampo_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ddlFiltroCampo_V2_SelectedIndexChanged;
			IboDropDownList val = _ddlFiltroCampo_V2;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged -= eventHandler;
			}
			_ddlFiltroCampo_V2 = value;
			val = _ddlFiltroCampo_V2;
			if (val != null)
			{
				((ListControl)val).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroOperatore_V2")]
	protected virtual IboWebLabel lblFiltroOperatore_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFiltroOperatore_V2")]
	protected virtual IboDropDownList ddlFiltroOperatore_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFiltroVal_V2")]
	protected virtual IboWebLabel lblFiltroVal_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlAddCondition_V2")]
	protected virtual Panel pnlAddCondition_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroNumericVal_V2")]
	protected virtual IboWebNumericTlk txtFiltroNumericVal_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroDateVal_V2")]
	protected virtual IboWebDate2 txtFiltroDateVal_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFiltroStringVal_V2")]
	protected virtual IboWebTextBox txtFiltroStringVal_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro_Aggiungi_V2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Aggiungi_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Aggiungi_V2_Click;
			IboWebButton val = _btnFiltro_Aggiungi_V2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Aggiungi_V2 = value;
			val = _btnFiltro_Aggiungi_V2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnFiltro_Aggiungi2_V2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Aggiungi2_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Aggiungi_V2_Click;
			IboWebButton val = _btnFiltro_Aggiungi2_V2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Aggiungi2_V2 = value;
			val = _btnFiltro_Aggiungi2_V2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblFiltroTot_V2")]
	protected virtual IboWebLabel lblFiltroTot_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lstFiltroTot_V2")]
	protected virtual ListBox lstFiltroTot_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltro_Elimina_V2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltro_Elimina_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltro_Elimina_V2_Click;
			IboWebButton val = _btnFiltro_Elimina_V2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltro_Elimina_V2 = value;
			val = _btnFiltro_Elimina_V2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("Ibowebbutton1Idle_V2")]
	protected virtual IboWebButton Ibowebbutton1Idle_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnFiltroAnnulla_V2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroAnnulla_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroAnnulla_V2_Click;
			IboWebButton val = _btnFiltroAnnulla_V2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroAnnulla_V2 = value;
			val = _btnFiltroAnnulla_V2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnFiltroConferma_V2
	{
		[CompilerGenerated]
		get
		{
			return _btnFiltroConferma_V2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFiltroConferma_Click;
			IboWebButton val = _btnFiltroConferma_V2;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnFiltroConferma_V2 = value;
			val = _btnFiltroConferma_V2;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("popFiltro_V2")]
	protected virtual ModalPopupExtender popFiltro_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForModalPopup_V2")]
	protected virtual Button hiddenTargetControlForModalPopup_V2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UP_pnlExport")]
	protected virtual UpdatePanel UP_pnlExport
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlExport")]
	protected virtual IboWebPanel pnlExport
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlExport2")]
	protected virtual Panel pnlExport2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblExportTitle")]
	protected virtual IboWebLabel lblExportTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rdbExportFormat")]
	protected virtual IboWebRadioButtonList rdbExportFormat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnExportAnnulla
	{
		[CompilerGenerated]
		get
		{
			return _btnExportAnnulla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnExportAnnulla_Click;
			IboWebButton val = _btnExportAnnulla;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnExportAnnulla = value;
			val = _btnExportAnnulla;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnExportConferma
	{
		[CompilerGenerated]
		get
		{
			return _btnExportConferma;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnExportConferma_Click;
			IboWebButton val = _btnExportConferma;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnExportConferma = value;
			val = _btnExportConferma;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("popExport")]
	protected virtual ModalPopupExtender popExport
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hiddenTargetControlForModalPopup2")]
	protected virtual Button hiddenTargetControlForModalPopup2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hidToolbarVisible")]
	protected virtual HiddenField hidToolbarVisible
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnShortCuts")]
	protected virtual HiddenField hdnShortCuts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnShortCutsWithCTRL")]
	protected virtual HiddenField hdnShortCutsWithCTRL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual Timer tmrUpdate
	{
		[CompilerGenerated]
		get
		{
			return _tmrUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler<EventArgs> eventHandler = tmrUpdate_Tick;
			Timer val = _tmrUpdate;
			if (val != null)
			{
				val.Tick -= eventHandler;
			}
			_tmrUpdate = value;
			val = _tmrUpdate;
			if (val != null)
			{
				val.Tick += eventHandler;
			}
		}
	}

	public override string EntryPoint
	{
		get
		{
			if (Operators.CompareString(sNomRif, "", false) == 0)
			{
				sNomRif = ((Page)this).Request.QueryString["NomRif"].ToUpper();
			}
			return PageName.ToUpper() + "." + sNomRif.ToUpper();
		}
	}

	public IboWebGridConfig GridConfig => _GridConfig;

	public IboGridInfo GridInfo => _GridInfo;

	protected int ScrollHeight
	{
		get
		{
			if (_GridInfo != null)
			{
				return _GridInfo.ScrollHeight;
			}
			return 0;
		}
	}

	public GridView DataGrid => (GridView)(object)grdGriglia;

	public IboWebLabel CaptionLabel => lblTitle;

	public IboWebLabel FilterLabel => lblFilter;

	public IboWebLabel NumeroRecordTotali => lblNumeroRecordTotali;

	public override string ToolbarResourceName => "SYSTEM." + base.SessionEnvironment.WebApplicationName.ToUpper() + "." + Strings.UCase(Strings.Replace(PageName.ToUpper(), ".ASPX", "", 1, -1, (CompareMethod)0)) + sNomRif.ToUpper() + ".TOOLBAR.";

	public WFStandardGrid()
	{
		((Control)this).Init += Page_Init1;
		((Control)this).Load += Page_Load;
		((Control)this).PreRender += Page_PreRender;
		_GridInfo = null;
		_ToolbarInfo = null;
		_GridConfig = null;
		_ToolbarConfig = null;
		sNomRif = "";
		_Utente = "";
		_ResetGridInfoList = false;
		_ReturnToSelectedRecord = false;
		_Mode = GridMode.Standard;
		_SortMode = GridSortMode.DataTableSort;
		_SendExportedFile = false;
		_FilterVersion = "";
	}

	private void Page_Init1(object sender, EventArgs e)
	{
		_EnableWFIPostbackData = true;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1647: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_166c: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Invalid comparison between Unknown and I4
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Invalid comparison between Unknown and I4
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Invalid comparison between Unknown and I4
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Invalid comparison between Unknown and I4
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Invalid comparison between Unknown and I4
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Invalid comparison between Unknown and I4
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Invalid comparison between Unknown and I4
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Invalid comparison between Unknown and I4
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected O, but got Unknown
		//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Invalid comparison between Unknown and I4
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Invalid comparison between Unknown and I4
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1395: Expected O, but got Unknown
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		bool flag = false;
		string text6 = "";
		string text7 = "";
		try
		{
			CallStackAdd();
			PerformanceLogAppend("BEGIN WFStandardGridPage.aspx Load event");
			string rsMess2 = "";
			SendExportedFile(ref rsMess2);
			if (!_SendExportedFile)
			{
				sNomRif = ((Page)this).Request.QueryString["NomRif"].ToUpper();
				text = ((Page)this).Request.QueryString["WA"] ?? "";
				if (Operators.CompareString(text, "", false) == 0 && base.SessionEnvironment.SessionVariables.ContainsKey(EntryPoint) && base.SessionEnvironment.SessionVariables[EntryPoint].ContainsKey("WA"))
				{
					text = base.SessionEnvironment.SessionVariables[EntryPoint]["WA"].ToString();
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = "(" + text + ")";
				}
				text3 = ((Page)this).Request.QueryString["DESC"] ?? "";
				if (Operators.CompareString(text3, "", false) != 0)
				{
					text3 = "(" + text3 + ")";
				}
				text4 = ((Page)this).Request.QueryString["TOP"] ?? "";
				text5 = ((Page)this).Request.QueryString["CAPT"] ?? "";
				flag = Operators.CompareString(((Page)this).Request.QueryString["ForceResetFilter"] ?? "", "S", false) == 0;
				_ResetGridInfoList = Operators.CompareString(((Page)this).Request.QueryString["ResetGridInfoList"] ?? "", "S", false) == 0;
				_FilterVersion = ((Page)this).Request.QueryString["FilterVer"] ?? "";
				if (Operators.CompareString(_FilterVersion, "", false) == 0)
				{
					_FilterVersion = base.SessionEnvironment.WFIConfig.StandardGrigManager.FilterVersion;
				}
				if (Operators.CompareString((((Page)this).Request.QueryString["GridMode"] ?? "").ToUpper(), "COMBO", false) == 0)
				{
					_Mode = GridMode.Combo;
					((Control)pnlCommands).Parent.Controls.Remove((Control)(object)pnlCommands);
					((Control)base.MasterPage.GetToolbarPanelRight).Controls.Add((Control)(object)pnlCommands);
				}
				else if (Operators.CompareString((((Page)this).Request.QueryString["GridMode"] ?? "").ToUpper(), "ONLYVIEW", false) == 0)
				{
					_Mode = GridMode.OnlyView;
					((Control)pnlCommands).Parent.Controls.Remove((Control)(object)pnlCommands);
					((Control)base.MasterPage.GetToolbarPanelRight).Controls.Add((Control)(object)pnlCommands);
				}
				else if ((Operators.CompareString((((Page)this).Request.QueryString["GridMode"] ?? "").ToUpper(), "DETAILS", false) == 0) | (Operators.CompareString((((Page)this).Request.QueryString["GridMode"] ?? "").ToUpper(), "TEST", false) == 0))
				{
					if (Operators.CompareString((((Page)this).Request.QueryString["GridMode"] ?? "").ToUpper(), "DETAILS", false) == 0)
					{
						_Mode = GridMode.Details;
					}
					else
					{
						_Mode = GridMode.Test;
					}
					((Control)pnlBackButton).Parent.Controls.Remove((Control)(object)pnlBackButton);
					((Control)base.MasterPage.GetToolbarPanelRight).Controls.Add((Control)(object)pnlBackButton);
					if (!base.SessionEnvironment.SessionVariables.ContainsKey(EntryPoint))
					{
						base.SessionEnvironment.SessionVariables.Add(EntryPoint, new IboDictionaryCollection<string, object>());
						base.SessionEnvironment.SessionVariables[EntryPoint].Add("PageToReturn", "");
					}
					else if (!base.SessionEnvironment.SessionVariables[EntryPoint].ContainsKey("PageToReturn"))
					{
						base.SessionEnvironment.SessionVariables[EntryPoint].Add("PageToReturn", "");
					}
					if (Operators.CompareString(base.SessionEnvironment.SessionVariables[EntryPoint]["PageToReturn"].ToString(), "", false) == 0)
					{
						base.SessionEnvironment.SessionVariables[EntryPoint]["PageToReturn"] = (object)base.SessionEnvironment.LastWfiPages.LastOrDefault();
					}
					btnButtonBack.IncasTag = base.SessionEnvironment.SessionVariables[EntryPoint]["PageToReturn"].ToString();
					if (_Mode == GridMode.Test)
					{
						IboWebButton val3;
						(val3 = btnButtonBack).IncasTag = val3.IncasTag + "&ReturnToSelectedRecord=S";
					}
				}
				_ReturnToSelectedRecord = Operators.CompareString(((Page)this).Request.QueryString["ReturnToSelectedRecord"] ?? "", "S", false) == 0;
				if (!_ReturnToSelectedRecord && _SessionVariable.ContainsKey("ReturnToSelectedRecord"))
				{
					_ReturnToSelectedRecord = Operators.CompareString(_SessionVariable["ReturnToSelectedRecord"].ToString() ?? "", "S", false) == 0;
					_SessionVariable.Remove("ReturnToSelectedRecord");
				}
				string text8 = ((Page)this).Request.QueryString["SortMode"] ?? "";
				if (Operators.CompareString(text8, "DB", false) == 0)
				{
					_SortMode = GridSortMode.DbSort;
				}
				if (!((Page)this).IsPostBack)
				{
					base.SessionEnvironment.GridConfigList.VerifyUsage();
				}
				PerformanceLogAppend("Load event (1)");
				if (_Mode == GridMode.Test && base.SessionEnvironment.GridInfoList.ContainsKey(sNomRif))
				{
					base.SessionEnvironment.GridInfoList.Remove(sNomRif);
				}
				val = base.SessionEnvironment.GridInfoList.Add(sNomRif, ref _GridInfo, ref rsMess);
				if ((int)val > 0)
				{
					return;
				}
				_Utente = _GridInfo.Utente;
				PerformanceLogAppend("Load event (2)");
				if (_ReturnToSelectedRecord && _GridInfo.FunctionArgs == null)
				{
					_ReturnToSelectedRecord = false;
				}
				if (_GridInfo.Prefiltro && Operators.CompareString(((Page)this).Request.QueryString["Returning"], (string)null, false) == 0 && (int)_GridInfo.Reset_SqlPrefilterOnly(ref rsMess) > 0)
				{
					return;
				}
				IboAppCallStackHandling robjCallStackHandler;
				if (_GridInfo.Prefiltro & (((Page)this).Request.QueryString["Returning"] == null || !Conversions.ToBoolean(((Page)this).Request.QueryString["Returning"])))
				{
					AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName);
					string filterPage = manager.FilterPage;
					string text9 = Strings.Replace(filterPage, "%APPNAME%", "Custom", 1, -1, (CompareMethod)0);
					try
					{
						if (!File.Exists(HttpContext.Current.Server.MapPath(text9)))
						{
							text9 = Strings.Replace(filterPage, "%APPNAME%", base.SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text9 = Strings.Replace(filterPage, "%APPNAME%", base.SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
						ProjectData.ClearProjectError();
					}
					filterPage = text9;
					filterPage = filterPage + "?Nomrif=" + sNomRif;
					if (Operators.CompareString(manager.FilterPageParameters, "", false) != 0)
					{
						filterPage = filterPage + "&" + manager.FilterPageParameters;
					}
					string key = RedirectToOnlyAspxPageName(manager.FilterPage);
					base.SessionEnvironment.SessionVariables.Remove(key);
					base.SessionEnvironment.SessionVariables.Add(key, new IboDictionaryCollection<string, object>());
					base.SessionEnvironment.SessionVariables[key]["CONTEXT"] = (object)"GRIDFILTER";
					FunctionArguments functionArguments = new FunctionArguments("", "GRIDFILTER");
					((Page)this).Session["FunctionArgs"] = functionArguments;
					functionArguments.Argomento1 = "MS";
					functionArguments.Argomento2 = ((Page)this).Request.QueryString;
					functionArguments.Argomento3 = text;
					filterPage = base.BaseFunctions.FindFormDirMember(filterPage);
					robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref filterPage);
					val2 = (FXRETURN)0;
					return;
				}
				if (((_Mode == GridMode.Standard) | (_Mode == GridMode.Test)) && (!_GridInfo.Prefiltro & (_GridInfo.GridFilterTable.Rows.Count > 0)))
				{
					if (((Page)this).Request.QueryString["Returning"] == null || !Conversions.ToBoolean(((Page)this).Request.QueryString["Returning"]))
					{
						string text10 = "";
						text10 = "~/WFI/FORM/WFGrdPreFilter.aspx";
						string key2 = "WFGrdPreFilter.aspx";
						base.SessionEnvironment.SessionVariables.Remove(key2);
						base.SessionEnvironment.SessionVariables.Add(key2, new IboDictionaryCollection<string, object>());
						base.SessionEnvironment.SessionVariables[key2]["CONTEXT"] = (object)"GRID.PREFILTER";
						FunctionArguments functionArguments2 = new FunctionArguments("", "GRID.PREFILTER");
						((Page)this).Session["FunctionArgs"] = functionArguments2;
						functionArguments2.Argomento1 = "MS";
						functionArguments2.Argomento2 = sNomRif;
						functionArguments2.Argomento3 = ((Page)this).Request.Url.PathAndQuery;
						string[] array = Strings.Split(base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale, "?", -1, (CompareMethod)0);
						functionArguments2.CallerPath = array[0];
						if (array.Count() > 1)
						{
							functionArguments2.CallerQueryString = array[1];
						}
						robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
						IboResponseRedirect(ref robjCallStackHandler, ref text10);
						val2 = (FXRETURN)0;
						return;
					}
					text2 = ((Page)this).Request.QueryString["WA2"] ?? "";
					text7 = ((Page)this).Request.QueryString["FilterDescription"] ?? "";
					text = ((Operators.CompareString(text, "", false) == 0) ? ("(" + text2 + ")") : (text + " AND (" + text2 + ")"));
				}
				PerformanceLogAppend("Load event (3)");
				if (_GridInfo.FiltroUtenteObbligatorio)
				{
					if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro, "", false) != 0)
					{
						text = ((Operators.CompareString(text, "", false) == 0) ? base.SessionEnvironment.WebUser.WebUserInfo.Filtro : (text + " AND " + base.SessionEnvironment.WebUser.WebUserInfo.Filtro));
					}
					if (Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto, "", false) != 0)
					{
						text = ((Operators.CompareString(text, "", false) == 0) ? base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto : (text + " AND " + base.SessionEnvironment.WebUser.WebUserInfo.FiltroSoggetto));
					}
				}
				if (Versioned.IsNumeric((object)text4))
				{
					_GridInfo.TopClauseUI = Conversions.ToInteger(text4);
				}
				IboGridConfigList gridConfigList = base.SessionEnvironment.GridConfigList;
				string text11 = sNomRif;
				ref IboGridInfo gridInfo = ref _GridInfo;
				IboGridView rObjGridView = grdGriglia;
				IboWebLabel rObjGridTitleLabel = CaptionLabel;
				IboWebLabel rObjGridFilterLabel = FilterLabel;
				IboWebLabel rObjNumeroRecordTotali = NumeroRecordTotali;
				FXRETURN val4 = gridConfigList.Add(text11, ref gridInfo, ref rObjGridView, ref rObjGridTitleLabel, ref rObjGridFilterLabel, ref rObjNumeroRecordTotali, ref _GridConfig, ref rsMess);
				grdGriglia = rObjGridView;
				val = val4;
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				PerformanceLogAppend("Load event (4)");
				val = base.SessionEnvironment.ToolbarInfoList.Add(sNomRif, _GridInfo.Utente, ref _ToolbarInfo, ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
				ref IboWebToolbarInfo toolbarInfo = ref _ToolbarInfo;
				IboWebToolbar rObjWebToolbar = _MasterPage.WebToolbar;
				robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboAppLogHandling rObjIboAppLogHandling = base.SessionEnvironment.LogHandling;
				DBConnection rObjDbMain = base.SessionEnvironment.DbConn;
				IncasTranslator rObjTranslator = base.SessionEnvironment.Translator;
				IboWebUserInfo rObjWebUserInfo = base.SessionEnvironment.WebUser.WebUserInfo;
				_ToolbarConfig = new IboWebToolbarConfig(ref toolbarInfo, ref rObjWebToolbar, ref robjCallStackHandler, ref rObjIboAppLogHandling, ref rObjDbMain, ref rObjTranslator, ref rObjWebUserInfo);
				PerformanceLogAppend("Load event (5)");
				if (!((Control)this).Page.IsPostBack)
				{
					AutoUpdateImposta();
					AutoUpdateImpostaVisibilita();
					if (Operators.CompareString(_GridInfo.WhereAggiuntiva, text, false) != 0)
					{
						_GridInfo.WhereAggiuntiva = text;
						_GridInfo.WhereAggiuntivaReadable = text3;
						val = _GridInfo.Reset_SqlSelect(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
							return;
						}
					}
					if (flag && (int)_GridInfo.Reset_SqlSelect(ref rsMess) > 0)
					{
						return;
					}
					PerformanceLogAppend("Load event (6)");
					if ((int)_GridConfig.ApplyConfig(ForceRequery: true, ref rsMess) > 0)
					{
						return;
					}
					PerformanceLogAppend("Load event (7)");
					if (Operators.CompareString(_GridInfo.FastFilterType, "N", false) == 0)
					{
						((Control)GridHeaderCellSearchTextPanel).Visible = false;
					}
					else if (Operators.CompareString(_GridInfo.FastFilterType, "A", false) == 0)
					{
						txtPagerSearchText.ToolTip = TranslateMessage("XXX", "Cerca su tutte le colonne della griglia.{0}SHIFT-Q per posizionarsi sulla casella di testo.{0}SHIFT-X per annullare il filtro.", "<br />");
						((WebControl)btnPagerSearchText).ToolTip = txtPagerSearchText.ToolTip;
					}
					else if (Operators.CompareString(_GridInfo.FastFilterType, "S", false) == 0)
					{
						txtPagerSearchText.ToolTip = TranslateMessage("XXX", "Cerca sulla colonna attiva della griglia.{0}SHIFT-Q per posizionarsi sulla casella di testo.{0}SHIFT-X per annullare il filtro", "<br />");
						((WebControl)btnPagerSearchText).ToolTip = txtPagerSearchText.ToolTip;
					}
					if ((int)CaricaOperatori(ref rsMess) > 0)
					{
						return;
					}
					if (Operators.CompareString(text5, "", false) != 0)
					{
						CaptionLabel.Text = Strings.Replace(text5, "%CAPTION%", CaptionLabel.Text, 1, -1, (CompareMethod)0);
					}
					if (Operators.CompareString(text7, "", false) != 0)
					{
						(rObjNumeroRecordTotali = CaptionLabel).Text = rObjNumeroRecordTotali.Text + " (" + text7 + ")";
					}
					((Page)this).Title = CaptionLabel.Text;
					((WebControl)GridHeaderCellAction).ToolTip = TranslateMessage("GRDMS", "Visualizza il menu azioni");
					if (!base.SessionEnvironment.WFIConfig.StandardGrigManager.ShowMenuActionButton)
					{
						((Control)GridHeaderCellAction).Visible = false;
					}
					if (_GridInfo.AllGrdStylesetTable.Rows.Count > 0)
					{
						((Control)GridHeaderCellLegendContainer).Visible = true;
					}
					else
					{
						((Control)GridHeaderCellLegendContainer).Visible = false;
					}
				}
				PerformanceLogAppend("Load event (8)");
				if ((int)_ToolbarConfig.LoadButtons(ref rsMess) > 0)
				{
					return;
				}
				PerformanceLogAppend("Load event (9)");
				if (!((Control)this).Page.IsPostBack)
				{
					hdnShortCuts.Value = _ToolbarConfig.GetToolbarObject.GetShortcutSHIFTInfo;
					hdnShortCutsWithCTRL.Value = _ToolbarConfig.GetToolbarObject.GetShortcutCTRLInfo;
					((Control)GridHeaderCellInfo).Visible = (Operators.CompareString(hdnShortCuts.Value, "", false) != 0) | (Operators.CompareString(hdnShortCutsWithCTRL.Value, "", false) != 0);
				}
				ContextMenuControlTarget val5 = new ContextMenuControlTarget();
				val5.ControlID = ((Control)grdGriglia).ID;
				base.MasterPage.ToolBarObject.ContextMenuTlk.Targets.Add((ContextMenuTarget)(object)val5);
				ContextMenuControlTarget val6 = new ContextMenuControlTarget();
				val6.ControlID = ((Control)GridHeaderCellAction).ID;
				base.MasterPage.ToolBarObject.ContextMenuTlk.Targets.Add((ContextMenuTarget)(object)val6);
				base.MasterPage.UpdatePanelToolBar.Update();
				grdGriglia.SelectByRightClickMode = base.SessionEnvironment.WFIConfig.StandardGrigManager.SelectByRightClickMode;
				if (((Control)GridHeaderCellLegendContainer).Visible)
				{
					foreach (DataRow row in _GridInfo.AllGrdStylesetTable.Rows)
					{
						HtmlGenericControl val7 = new HtmlGenericControl();
						string text12 = "<div class=\"LegendItem <%LegendItem%>\" style=\"<%Style%>\"><%Descrizione%></div>";
						text12 = text12.Replace("<%Descrizione%>", row["DescrizioneStato"].ToString());
						string text13 = "";
						if (Operators.CompareString(row["BackColor"].ToString(), "", false) != 0)
						{
							text13 = text13 + "background-color:#" + row["BackColor"].ToString() + ";";
						}
						if (Operators.CompareString(row["ForColor"].ToString(), "", false) != 0)
						{
							text13 = text13 + "color:#" + row["ForColor"].ToString() + ";";
						}
						if (Operators.CompareString(row["FontBold"].ToString(), "S", false) == 0)
						{
							text13 += "font-weight:bold;";
						}
						else if (Operators.CompareString(row["FontBold"].ToString(), "N", false) == 0)
						{
							text13 += "font-weight:normal;";
						}
						if ((Operators.CompareString(row["Image"].ToString(), "", false) != 0) & (Operators.CompareString(row["TipoStyleset"].ToString(), "C", false) == 0))
						{
							text13 = text13 + "background-image:url('" + row["Image"].ToString().Replace("~", "../..") + "');";
							text13 += "background-repeat:no-repeat;";
							text12 = text12.Replace("<%LegendItem%>", "LegendItemWithImage");
						}
						else
						{
							text12 = text12.Replace("<%LegendItem%>", "");
						}
						text12 = text12.Replace("<%Style%>", text13);
						((HtmlContainerControl)val7).InnerHtml = text12;
						((Control)LegendContentPopupMenu2).Controls.Add((Control)(object)val7);
					}
				}
				val = AutoApplyFilter(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
					return;
				}
			}
			if (base.MasterPage.PanelTopHeaderVisible)
			{
				up_grdGriglia.Attributes["class"] = "up_grdGriglia PanelTopHeaderVisible";
			}
			else
			{
				up_grdGriglia.Attributes["class"] = "up_grdGriglia NotPanelTopHeaderVisible";
			}
			val2 = (FXRETURN)0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
			val2 = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			PerformanceLogAppend("END WFStandardGridPage.aspx Load event");
			if ((int)val2 > 0 && !_SendExportedFile)
			{
				WriteErrorMessageWithReturnToCaller("", "Si è verificato un errore in fase di caricamento griglia", rsMess);
			}
		}
	}

	private void Page_PreRender(object sender, EventArgs e)
	{
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected O, but got Unknown
		checked
		{
			try
			{
				PerformanceLogAppend("BEGIN Page_PreRender");
				if (_ResetGridInfoList)
				{
					base.SessionEnvironment.GridInfoList.GridInfoListMode = IboGridInfoList.IboGridInfoListMode.Standard;
					base.SessionEnvironment.GridInfoList.WebUserInfo = base.SessionEnvironment.WebUser.WebUserInfo;
				}
				ReturnToSelectedRecord();
				((Control)pnlCommands).Visible = false;
				((Control)pnlBackButton).Visible = false;
				if (!_GridInfo.EnableMultiSelection)
				{
					btnSelezionaTutto.Visible = false;
					btnDeselezionaTutto.Visible = false;
				}
				else
				{
					btnSelezionaTutto.Visible = true;
					btnDeselezionaTutto.Visible = true;
				}
				if (_Mode == GridMode.Combo)
				{
					((Control)pnlCommands).Visible = true;
				}
				else if (_Mode == GridMode.OnlyView)
				{
					((Control)pnlCommands).Visible = true;
					((Control)base.MasterPage.ToolBarContainerPanel).Visible = false;
					((Control)btnPagerSearchSvuotaFiltro).Visible = true;
					((Control)GridHeaderCellAction).Visible = false;
				}
				else if ((_Mode == GridMode.Details) | (_Mode == GridMode.Test))
				{
					((Control)pnlBackButton).Visible = true;
				}
				if (Operators.CompareString(((WebControl)pnlBackButton).ToolTip, "PRINT", false) == 0)
				{
					((WebControl)pnlBackButton).ToolTip = "";
					((Control)pnlBackButton).Visible = false;
				}
				if (Operators.CompareString(((WebControl)pnlCommands).ToolTip, "PRINT", false) == 0)
				{
					((WebControl)pnlCommands).ToolTip = "";
					((Control)pnlCommands).Visible = false;
				}
				GridHeaderCaption.Text = lblTitle.Text;
				GridHeaderCaption.ToolTip = lblTitle.ToolTip;
				WebControl val = (WebControl)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellGotoFirst");
				((Control)val).Visible = true;
				val.Enabled = true;
				WebControl val2 = (WebControl)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellGotoPrevious");
				((Control)val2).Visible = true;
				val2.Enabled = true;
				WebControl val3 = (WebControl)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellGotoNext");
				((Control)val3).Visible = true;
				val3.Enabled = true;
				WebControl val4 = (WebControl)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellGotoLast");
				((Control)val4).Visible = true;
				val4.Enabled = true;
				if (((GridView)grdGriglia).PageIndex == 0)
				{
					val.Enabled = false;
					WebControl val5;
					(val5 = val).CssClass = val5.CssClass + " WFIDisabled";
					val2.Enabled = false;
					(val5 = val2).CssClass = val5.CssClass + " WFIDisabled";
				}
				if (((GridView)grdGriglia).PageIndex == ((GridView)grdGriglia).PageCount - 1)
				{
					val3.Enabled = false;
					WebControl val5;
					(val5 = val3).CssClass = val5.CssClass + " WFIDisabled";
					val4.Enabled = false;
					(val5 = val4).CssClass = val5.CssClass + " WFIDisabled";
				}
				if (((GridView)grdGriglia).PageCount > 1)
				{
					((Control)(DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerNumberOfPage")).Visible = true;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPage")).Visible = true;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPageOf")).Visible = true;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPageTotalPage")).Visible = true;
					((ListControl)(DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerNumberOfPage")).Items.Clear();
					int pageCount = ((GridView)grdGriglia).PageCount;
					for (int i = 1; i <= pageCount; i++)
					{
						((ListControl)(DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerNumberOfPage")).Items.Add(i.ToString());
					}
					((DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerNumberOfPage")).SelectedIndex = ((GridView)grdGriglia).PageIndex;
					((Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPageTotalPage")).Text = ((GridView)grdGriglia).PageCount.ToString();
					((Control)(DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerMaxRecord")).Visible = true;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerMaxRecord")).Visible = true;
				}
				else
				{
					((Control)(DropDownList)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("ddlPagerNumberOfPage")).Visible = false;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPage")).Visible = false;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPageOf")).Visible = false;
					((Control)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerNumberOfPageTotalPage")).Visible = false;
					((Control)(DropDownList)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("ddlPagerMaxRecord")).Visible = false;
					((Control)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerMaxRecord")).Visible = false;
				}
				((Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerTotalRecord")).Text = lblNumeroRecordTotali.Text;
				((WebControl)(Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("lblPagerTotalRecord")).ToolTip = lblNumeroRecordTotali.ToolTip;
				((WebControl)(Table)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("pagerTemplateTable")).CssClass = "IboWebGridView_PagerTop";
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellTotalRecord")).CssClass = "PagerTemplateCellTotalRecordTop";
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellSearchText")).CssClass = "PagerTemplateCellSearchTextTop";
				((Label)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateTitleGrid")).Text = lblTitle.Text;
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("PagerTemplateCellTitle")).CssClass = "PagerTemplateCellTitleTop";
				val = (WebControl)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellGotoFirst");
				((Control)val).Visible = true;
				val.Enabled = true;
				val2 = (WebControl)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellGotoPrevious");
				((Control)val2).Visible = true;
				val2.Enabled = true;
				val3 = (WebControl)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellGotoNext");
				((Control)val3).Visible = true;
				val3.Enabled = true;
				val4 = (WebControl)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellGotoLast");
				((Control)val4).Visible = true;
				val4.Enabled = true;
				if (((GridView)grdGriglia).PageIndex == 0)
				{
					val.Enabled = false;
					WebControl val5;
					(val5 = val).CssClass = val5.CssClass + " WFIDisabled";
					val2.Enabled = false;
					(val5 = val2).CssClass = val5.CssClass + " WFIDisabled";
				}
				if (((GridView)grdGriglia).PageIndex == ((GridView)grdGriglia).PageCount - 1)
				{
					val3.Enabled = false;
					WebControl val5;
					(val5 = val3).CssClass = val5.CssClass + " WFIDisabled";
					val4.Enabled = false;
					(val5 = val4).CssClass = val5.CssClass + " WFIDisabled";
				}
				((Control)(DropDownList)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("ddlPagerNumberOfPage")).Visible = true;
				((Control)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerNumberOfPage")).Visible = true;
				((Control)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerNumberOfPageOf")).Visible = true;
				((Control)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerNumberOfPageTotalPage")).Visible = true;
				DropDownList val6 = (DropDownList)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("ddlPagerNumberOfPage");
				((ListControl)val6).Items.Clear();
				int pageCount2 = ((GridView)grdGriglia).PageCount;
				for (int j = 1; j <= pageCount2; j++)
				{
					((ListControl)val6).Items.Add(j.ToString());
				}
				((DropDownList)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("ddlPagerNumberOfPage")).SelectedIndex = ((GridView)grdGriglia).PageIndex;
				((Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerNumberOfPageTotalPage")).Text = ((GridView)grdGriglia).PageCount.ToString();
				val6 = (DropDownList)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("ddlPagerMaxRecord");
				((Control)val6).Visible = _GridInfo.MaxRecordSelectorVisible;
				if (((ListControl)val6).Items.FindByValue(_GridInfo.TopClause.ToString()) == null)
				{
					((ListControl)val6).Items.Add(new ListItem(_GridInfo.TopClause.ToString(), _GridInfo.TopClause.ToString()));
				}
				((ListControl)val6).SelectedValue = _GridInfo.TopClause.ToString();
				base.BaseFunctions.SortNumberedDropDownList(val6);
				((Control)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerMaxRecord")).Visible = _GridInfo.MaxRecordSelectorVisible;
				((Control)((GridView)grdGriglia).BottomPagerRow).Visible = true;
				((Control)((GridView)grdGriglia).TopPagerRow).Visible = true;
				((Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerTotalRecord")).Text = lblNumeroRecordTotali.Text;
				((WebControl)(Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("lblPagerTotalRecord")).ToolTip = lblNumeroRecordTotali.ToolTip;
				((WebControl)(Table)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("pagerTemplateTable")).CssClass = "IboWebGridView_PagerBottom";
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellTotalRecord")).CssClass = "PagerTemplateCellTotalRecordBottom";
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellSearchText")).CssClass = "PagerTemplateCellSearchTextBottom";
				((Label)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateTitleGrid")).Text = lblTitle.Text;
				((WebControl)(TableCell)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("PagerTemplateCellTitle")).CssClass = "PagerTemplateCellTitleBottom";
				((Control)((GridView)grdGriglia).TopPagerRow).Visible = false;
				PerformanceLogAppend("END Page_PreRender");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void grdGriglia_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			((GridView)grdGriglia).PageIndex = e.NewPageIndex;
			if ((int)_GridConfig.Carica_Dati(ForceRequery: false, ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	public void btnSearch2_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Invalid comparison between Unknown and I4
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Invalid comparison between Unknown and I4
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string vsReadableExpression = "";
		string text2 = "";
		try
		{
			text2 = txtPagerSearchText.Text.Trim();
			txtPagerSearchText.Text = "";
			string fastFilterType = _GridInfo.FastFilterType;
			if (Operators.CompareString(text2, "", false) != 0)
			{
				if (Operators.CompareString(fastFilterType, "A", false) == 0)
				{
					text = " ((1=2) ";
					foreach (DataRow row in _GridInfo.TabGrdTable.Rows)
					{
						if (Operators.CompareString(row["VISIBILE"].ToString(), "S", false) != 0)
						{
							continue;
						}
						bool flag = true;
						if (row.Table.Columns.Contains("VisibleInFilter"))
						{
							flag = Operators.CompareString(row["VisibleInFilter"].ToString(), "S", false) == 0;
						}
						if (flag)
						{
							if (Operators.CompareString(row["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "STRING", false) == 0)
							{
								text = text + " OR (" + row["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%') ";
							}
							else if (Operators.CompareString(row["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "DATETIME", false) == 0)
							{
								text = text + " OR (" + base.DbConn.FormatDateFunc(row["NOMCAM"].ToString(), "DDMMYYYY", "/") + " LIKE '%" + text2.Replace("'", "''") + "%') ";
							}
							else if (Operators.CompareString(row["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "BYTE[]", false) != 0)
							{
								text = text + " OR (" + row["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%') ";
							}
						}
					}
					text += " ) ";
					_GridInfo.SqlStatement.AddWhere(text, TranslateMessage("GRDMS", "Qualunque campo contiene") + " '" + text2 + "'", vbCanBeDeleted: true);
				}
				else if (Operators.CompareString(fastFilterType, "S", false) == 0)
				{
					foreach (DataRow row2 in _GridInfo.TabGrdTable.Rows)
					{
						if (Operators.CompareString(row2["VISIBILE"].ToString(), "S", false) != 0)
						{
							continue;
						}
						bool flag2 = true;
						if (row2.Table.Columns.Contains("VisibleInFilter"))
						{
							flag2 = Operators.CompareString(row2["VisibleInFilter"].ToString(), "S", false) == 0;
						}
						if (flag2 && Operators.CompareString(_GridInfo.CampoAttivo.ToUpper(), row2["NOMCAM"].ToString().ToUpper(), false) == 0)
						{
							if (Operators.CompareString(row2["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "STRING", false) == 0)
							{
								text = "(" + row2["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%')";
								vsReadableExpression = "(" + TranslateMessage("GRDMS", row2["DESCAM"].ToString()) + " " + TranslateMessage("GRDMS", "contiene") + " '" + text2 + "')";
							}
							else if (Operators.CompareString(row2["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "DATETIME", false) == 0)
							{
								text = "(" + base.DbConn.FormatDateFunc(row2["NOMCAM"].ToString(), "DDMMYYYY", "/") + " LIKE '%" + text2.Replace("'", "''") + "%')";
								vsReadableExpression = "(" + TranslateMessage("GRDMS", row2["DESCAM"].ToString()) + " " + TranslateMessage("GRDMS", "contiene") + " '" + text2 + "')";
							}
							else if (Operators.CompareString(row2["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "BYTE[]", false) != 0)
							{
								text = "(" + row2["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%')";
								vsReadableExpression = "(" + TranslateMessage("GRDMS", row2["DESCAM"].ToString()) + " " + TranslateMessage("GRDMS", "contiene") + " '" + text2 + "')";
							}
							break;
						}
					}
					if (Operators.CompareString(text, "", false) != 0)
					{
						_GridInfo.SqlStatement.AddWhere(text, vsReadableExpression, vbCanBeDeleted: true);
					}
				}
			}
			if (_GridConfig.DataTableSource != null)
			{
				_GridConfig.DataTableSource.Dispose();
				_GridConfig.DataTableSource = null;
			}
			val2 = _GridConfig.Aggiorna(ref rsMess);
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
		}
	}

	public void btnSvuotaFiltro_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			val2 = AnnullaFiltri(ref rsMess);
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
		}
	}

	public void btnSearch_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Invalid comparison between Unknown and I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string vsWhere = "";
		string text = "";
		string text2 = "";
		try
		{
			text2 = ((TextBox)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("txtPagerSearchText")).Text.Trim();
			if (Operators.CompareString(text2, "", false) == 0)
			{
				text2 = ((TextBox)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("txtPagerSearchText")).Text.Trim();
			}
			((TextBox)((Control)((GridView)grdGriglia).TopPagerRow).FindControl("txtPagerSearchText")).Text = "";
			((TextBox)((Control)((GridView)grdGriglia).BottomPagerRow).FindControl("txtPagerSearchText")).Text = "";
			if (Operators.CompareString(text2, "", false) != 0)
			{
				vsWhere = " ((1=2) ";
				foreach (DataRow row in _GridInfo.TabGrdTable.Rows)
				{
					if (Operators.CompareString(row["VISIBILE"].ToString(), "S", false) == 0)
					{
						bool flag = true;
						if (row.Table.Columns.Contains("VisibleInFilter"))
						{
							flag = Operators.CompareString(row["VisibleInFilter"].ToString(), "S", false) == 0;
						}
						if (flag)
						{
							vsWhere = ((Operators.CompareString(row["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "STRING", false) != 0) ? ((Operators.CompareString(row["INTERNAL_USE_DATATYPE"].ToString().ToUpper(), "DATETIME", false) != 0) ? (vsWhere + " OR (" + row["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%') ") : (vsWhere + " OR (" + base.DbConn.FormatDateFunc(row["NOMCAM"].ToString(), "DDMMYYYY", "/") + " LIKE '%" + text2 + "%') ")) : (vsWhere + " OR (" + row["NOMCAM"].ToString() + " LIKE '%" + text2.Replace("'", "''") + "%') "));
						}
					}
				}
				vsWhere += " ) ";
			}
			_GridInfo.SqlStatement.AddWhere(vsWhere, TranslateMessage("GRDMS", "Qualunque campo contiene") + " '" + text2 + "'", vbCanBeDeleted: true);
			val2 = _GridConfig.Aggiorna(ref rsMess);
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
		}
	}

	private void grdGriglia_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected O, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		try
		{
			if ((int)e.Row.RowType != 2)
			{
				return;
			}
			checked
			{
				if (_GridInfo.AllGrdStylesetTable != null && _GridInfo.AllGrdStylesetTable.Rows.Count > 0)
				{
					DataRowView dataRowView = (DataRowView)e.Row.DataItem;
					string text = dataRowView["Styleset"].ToString();
					if (Operators.CompareString(text, "", false) != 0)
					{
						DataRow[] array = _GridInfo.AllGrdStylesetTable.Select("StyleName='" + text + "'");
						if (array.Count() > 0)
						{
							TableItemStyle val = (TableItemStyle)_GridConfig.AllgrdStylesets[text];
							if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "R", false) == 0)
							{
								((WebControl)e.Row).BackColor = ((Style)val).BackColor;
								((WebControl)e.Row).ForeColor = ((Style)val).ForeColor;
								((WebControl)e.Row).Font.Bold = ((Style)val).Font.Bold;
								((WebControl)e.Row).Font.Italic = ((Style)val).Font.Italic;
								((WebControl)e.Row).Font.Name = ((Style)val).Font.Name;
								((WebControl)e.Row).Font.Underline = ((Style)val).Font.Underline;
								((WebControl)e.Row).Font.Size = ((Style)val).Font.Size;
								((WebControl)e.Row).BorderColor = ((Style)val).BorderColor;
								((WebControl)e.Row).BorderWidth = ((Style)val).BorderWidth;
								if (Operators.CompareString(((Style)val).CssClass, "", false) != 0)
								{
									((WebControl)e.Row).CssClass = ((WebControl)e.Row).CssClass + " " + ((Style)val).CssClass;
								}
								e.Row.RowState = (DataControlRowState)0;
								((WebControl)e.Row).Attributes.Add("data-style-name", text);
							}
							else if (Operators.CompareString(array[0]["TipoStyleset"].ToString(), "C", false) == 0)
							{
								int num = ((TableRow)e.Row).Cells.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									if (Operators.CompareString(((BoundField)((DataControlFieldCell)((TableRow)e.Row).Cells[i]).ContainingField).DataField.ToUpper(), "STYLESET", false) != 0)
									{
										continue;
									}
									DataControlFieldCell val2 = (DataControlFieldCell)((TableRow)e.Row).Cells[i];
									((WebControl)val2).BackColor = ((Style)val).BackColor;
									((WebControl)val2).ForeColor = ((Style)val).ForeColor;
									((WebControl)val2).Font.Bold = ((Style)val).Font.Bold;
									((WebControl)val2).Font.Italic = ((Style)val).Font.Italic;
									((WebControl)val2).Font.Name = ((Style)val).Font.Name;
									((WebControl)val2).Font.Underline = ((Style)val).Font.Underline;
									((WebControl)val2).Font.Size = ((Style)val).Font.Size;
									((WebControl)val2).BorderColor = ((Style)val).BorderColor;
									((WebControl)val2).BorderWidth = ((Style)val).BorderWidth;
									if (Operators.CompareString(((Style)val).CssClass, "", false) != 0)
									{
										((WebControl)val2).CssClass = ((Style)val).CssClass;
									}
									((TableCell)val2).Text = "";
									((WebControl)val2).ToolTip = array[0]["DescrizioneStato"].ToString();
									DataControlFieldCell val3;
									((WebControl)(val3 = val2)).CssClass = ((WebControl)val3).CssClass + " Styleset";
									if (_GridInfo.CanSelect)
									{
										if (!((Style)((GridView)grdGriglia).Columns[i - 1].HeaderStyle).CssClass.Contains("Styleset"))
										{
											TableItemStyle headerStyle;
											((Style)(headerStyle = ((GridView)grdGriglia).Columns[i - 1].HeaderStyle)).CssClass = ((Style)headerStyle).CssClass + " Styleset";
										}
									}
									else if (!((Style)((GridView)grdGriglia).Columns[i].HeaderStyle).CssClass.Contains("Styleset"))
									{
										TableItemStyle headerStyle;
										((Style)(headerStyle = ((GridView)grdGriglia).Columns[i].HeaderStyle)).CssClass = ((Style)headerStyle).CssClass + " Styleset";
									}
									if (Operators.CompareString(array[0]["Image"].ToString(), "", false) == 0)
									{
										continue;
									}
									Panel val4 = new Panel();
									((Control)val4).ID = "pnlImgStyleset";
									((WebControl)val4).CssClass = "pnlImgStyleset";
									System.Web.UI.WebControls.Image val5 = new System.Web.UI.WebControls.Image();
									((WebControl)val5).CssClass = "ImgStyleset";
									val5.ImageUrl = array[0]["Image"].ToString();
									((Control)val4).Controls.Add((Control)(object)val5);
									if (dataRowView.Row.Table.Columns.Contains("StylesetText"))
									{
										string text2 = dataRowView["StylesetText"].ToString();
										if (Operators.CompareString(text2, "", false) != 0)
										{
											Label val6 = new Label();
											((Control)val6).ID = "lblImgStyleset";
											((WebControl)val6).CssClass = "lblImgStyleset";
											val6.Text = text2;
											((Control)val4).Controls.Add((Control)(object)val6);
										}
									}
									((TableCell)val2).Text = "";
									((Control)val2).Controls.Add((Control)(object)val4);
								}
							}
						}
					}
				}
				int num2 = ((TableRow)e.Row).Cells.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					try
					{
						string dataField = ((BoundField)((DataControlFieldCell)((TableRow)e.Row).Cells[j]).ContainingField).DataField;
						int index = ((GridView)grdGriglia).PageIndex * ((GridView)grdGriglia).PageSize + e.Row.RowIndex;
						if (Operators.CompareString(dataField, "", false) == 0)
						{
							continue;
						}
						object objectValue = RuntimeHelpers.GetObjectValue(_GridConfig.LastDataTableSource.Rows[index][dataField]);
						if ((object)objectValue.GetType() != typeof(byte[]))
						{
							continue;
						}
						DataControlFieldCell val7 = (DataControlFieldCell)((TableRow)e.Row).Cells[j];
						((TableCell)val7).Text = "Image not ready";
						byte[] array2 = (byte[])objectValue;
						if (array2 == null)
						{
							continue;
						}
						string text3 = _GridConfig.LastDataTableSource.Rows[index][dataField + "Estensione"].ToString();
						string text4 = Guid.NewGuid().ToString() + "." + text3;
						string PercorsImmagineRidimensionata = "";
						File.WriteAllBytes(base.SessionEnvironment.WebApplicationDownloadDir + text4, array2);
						IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
						string sNomeFile = base.SessionEnvironment.WebApplicationDownloadDir + text4;
						string rsMess = "";
						sessionEnvironment.AddFileToDelete(sNomeFile, ref rsMess);
						if (Operators.CompareString(text3.ToUpper(), "PDF", false) == 0)
						{
							((TableCell)val7).Text = "";
							System.Web.UI.WebControls.Image val8 = new System.Web.UI.WebControls.Image();
							((WebControl)val8).CssClass = "BlobField " + dataField;
							if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\PdfDocumentCustom.png")))
							{
								val8.ImageUrl = "~\\WFI\\Images\\PdfDocumentCustom.png";
							}
							else if (File.Exists(((Page)this).Server.MapPath("~\\WFI\\Images\\Grid_PdfDocument.png")))
							{
								val8.ImageUrl = "~\\WFI\\Images\\Grid_PdfDocument.png";
							}
							else
							{
								val8.ImageUrl = "~\\WFI\\Images\\PdfDocument.jpg";
							}
							((Control)val8).Visible = true;
							((WebControl)val8).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
							HyperLink val9 = new HyperLink();
							((WebControl)val9).CssClass = "BlobFieldLink " + dataField;
							val9.NavigateUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text4);
							((Control)val9).Controls.Add((Control)(object)val8);
							val9.Target = "_blank";
							((Control)val7).Controls.Add((Control)(object)val9);
							continue;
						}
						if ((Operators.CompareString(text3.ToUpper(), "TIF", false) == 0) | (Operators.CompareString(text3.ToUpper(), "TIFF", false) == 0))
						{
							try
							{
								string text5 = base.SessionEnvironment.WebApplicationDownloadDir + text4;
								string text6 = Path.GetDirectoryName(text5) + "\\" + Path.GetFileNameWithoutExtension(text5) + ".jpg";
								Bitmap val10 = new Bitmap(text5);
								val10 = (Bitmap)System.Drawing.Image.FromFile(text5);
								((System.Drawing.Image)val10).Save(text6, ImageFormat.Jpeg);
								IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
								rsMess = "";
								sessionEnvironment2.AddFileToDelete(text6, ref rsMess);
								text3 = "jpg";
								text4 = Path.GetFileName(text6);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
						base.BaseFunctions.ResizeImage(base.SessionEnvironment.WebApplicationDownloadDir + text4, 100, ref PercorsImmagineRidimensionata);
						IboSessionEnvironment sessionEnvironment3 = base.SessionEnvironment;
						string sNomeFile2 = base.SessionEnvironment.WebApplicationDownloadDir + text4;
						rsMess = "";
						sessionEnvironment3.AddFileToDelete(sNomeFile2, ref rsMess);
						IboSessionEnvironment sessionEnvironment4 = base.SessionEnvironment;
						string sNomeFile3 = PercorsImmagineRidimensionata;
						rsMess = "";
						sessionEnvironment4.AddFileToDelete(sNomeFile3, ref rsMess);
						((TableCell)val7).Text = "";
						System.Web.UI.WebControls.Image val11 = new System.Web.UI.WebControls.Image();
						((WebControl)val11).CssClass = "BlobField " + dataField + " WFI-gallery-items";
						val11.ImageUrl = "~\\" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(PercorsImmagineRidimensionata);
						((Control)val11).Visible = true;
						((WebControl)val11).Attributes.Add("data-high-res-src", Strings.Replace("../../" + Strings.Replace(base.SessionEnvironment.WebApplicationDownloadDir, base.SessionEnvironment.WebApplicationRoot, "", 1, -1, (CompareMethod)0) + Path.GetFileName(base.SessionEnvironment.WebApplicationDownloadDir + text4), "\\", "/", 1, -1, (CompareMethod)0));
						((WebControl)val11).ToolTip = TranslateMessage("XXX", "Clicca per aprire il documento");
						HyperLink val12 = new HyperLink();
						((WebControl)val12).CssClass = "BlobFieldLink " + dataField;
						val12.NavigateUrl = "#";
						((Control)val12).Controls.Add((Control)(object)val11);
						((Control)val7).Controls.Add((Control)(object)val12);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}

	private void btnClosePrintingMode_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			((GridView)grdGriglia).AllowSorting = _GridInfo.AllowSorting;
			((GridView)grdGriglia).AllowPaging = _GridInfo.AllowPaging;
			grdGriglia.AutoGenerateCheckBoxColumn = _GridInfo.AutoGenerateCheckBoxColumn;
			if ((int)_GridConfig.Aggiorna(ref rsMess) <= 0)
			{
				((Control)pnlDataGridPrint).Visible = false;
				base.ToolbarVisible = true;
				((Control)chkAutoUpdate).Visible = true;
				tmrUpdate.Enabled = chkAutoUpdate.Checked;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnExportAnnulla_Click(object sender, EventArgs e)
	{
		((Control)pnlExport2).Visible = false;
		popExport.Hide();
	}

	private void btnExportConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		GridExporter gridExporter = null;
		try
		{
			CallStackAdd();
			gridExporter = new GridExporter();
			GridExporter gridExporter2 = gridExporter;
			IboSessionEnvironment robjSessionEnv = base.SessionEnvironment;
			gridExporter2.Init(ref robjSessionEnv, ref _GridInfo);
			if ((int)gridExporter.Execute(gridExporter.ConvertStringToOutputFormat(((ListControl)rdbExportFormat).SelectedValue), CaptionLabel.Text, ref rsMess) <= 0)
			{
				if (!_SessionVariable.ContainsKey("FileToExportCompletePath"))
				{
					_SessionVariable.Add("FileToExportCompletePath", "");
				}
				if (!_SessionVariable.ContainsKey("FileNameToExport"))
				{
					_SessionVariable.Add("FileNameToExport", "");
				}
				_SessionVariable["FileToExportCompletePath"] = (object)gridExporter.GetExportFileCompletePath;
				_SessionVariable["FileNameToExport"] = (object)gridExporter.GetExportFileName;
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string getExportFileCompletePath = gridExporter.GetExportFileCompletePath;
				string rsMess2 = "";
				sessionEnvironment.AddFileToDelete(getExportFileCompletePath, ref rsMess2);
				Client_JavascriptEvalAfterTimeout("__doPostBack('', 'SEND_EXPORTED_FILE')", 500);
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
			gridExporter = null;
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			else
			{
				((Control)pnlExport2).Visible = false;
				popExport.Hide();
			}
			CallStackRemove();
		}
	}

	protected void tmrUpdate_Tick(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string rsMess = "";
			Aggiorna(ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public override void IboMessageBox_cmdAnnulla01_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			base.SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Annulla;
			FuncToCallAfterConfirm delegateCallBack = base.SessionEnvironment.UserMessage.DelegateCallBack;
			if (delegateCallBack == null || (int)delegateCallBack(ref rsMess) <= 0)
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
			base.SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	public override void IboSelectBox_CancelButtonClick(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		string sMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			base.SessionEnvironment.UserSelect.UserDialogResult = WFIUserSelect.SelectUserDialogResult.Annulla;
			FuncToCallAfterSelectConfirm delegateCallBack = base.SessionEnvironment.UserSelect.DelegateCallBack;
			if ((int)delegateCallBack(ref sMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	public override void IboSelectBox_ConfirmButtonClick(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		string sMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			base.SessionEnvironment.UserSelect.UserDialogResult = WFIUserSelect.SelectUserDialogResult.Conferma;
			FuncToCallAfterSelectConfirm delegateCallBack = base.SessionEnvironment.UserSelect.DelegateCallBack;
			if ((int)delegateCallBack(ref sMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref sMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(sMess);
			}
		}
	}

	protected void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
	{
		AutoUpdateImposta(chkAutoUpdate.Checked);
	}

	private void btnFiltro_Aggiungi_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		string rsmess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			val2 = FiltroCondizioneAggiungi(ddlFiltroCampo, ddlFiltroOperatore, lstFiltroTot, txtFiltroNumericVal, txtFiltroStringVal, txtFiltroDateVal, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			foreach (ListItem item in ((ListControl)lstFiltroTot).Items)
			{
				ListItem val3 = item;
				if (_GridInfo.SqlStatement.SqlWhere.ContainsKey(val3.Value) && !_GridInfo.SqlStatement.SqlWhere[val3.Value].CanBeDeleted)
				{
					val3.Attributes["Disabled"] = "True";
				}
			}
			if (Operators.CompareString(((Button)sender).CommandArgument, "CONFERMA", false) == 0)
			{
				btnFiltroConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}

	private void btnFiltro_Aggiungi_V2_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		string rsmess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			val2 = FiltroCondizioneAggiungi(ddlFiltroCampo_V2, ddlFiltroOperatore_V2, lstFiltroTot_V2, txtFiltroNumericVal_V2, txtFiltroStringVal_V2, txtFiltroDateVal_V2, ref rsmess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			foreach (ListItem item in ((ListControl)lstFiltroTot_V2).Items)
			{
				ListItem val3 = item;
				if (_GridInfo.SqlStatement.SqlWhere.ContainsKey(val3.Value) && !_GridInfo.SqlStatement.SqlWhere[val3.Value].CanBeDeleted)
				{
					val3.Attributes["Disabled"] = "True";
				}
			}
			if (Operators.CompareString(((Button)sender).CommandArgument, "CONFERMA", false) == 0)
			{
				btnFiltroConferma_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			val = (FXRETURN)0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}

	private void ddlFiltroCampo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Invalid comparison between Unknown and I4
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		string vsMessaggio = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			string text = ddlFiltroCampo.SelectedValue.Substring(0, ddlFiltroCampo.SelectedValue.LastIndexOf("$"));
			string text2 = ddlFiltroCampo.SelectedValue.Substring(checked(ddlFiltroCampo.SelectedValue.LastIndexOf("$") + 1));
			txtFiltroNumericVal.Visible = false;
			txtFiltroDateVal.Visible = false;
			txtFiltroStringVal.Visible = false;
			switch (text2)
			{
			case "Int16":
			case "Int32":
			case "Int64":
				txtFiltroNumericVal.DecimalDigits = 0;
				txtFiltroNumericVal.Text = "";
				txtFiltroNumericVal.Visible = true;
				((RadInputControl)txtFiltroNumericVal).Focus();
				ddlFiltroOperatore.ObjValue = "UGUALE";
				((ListControl)ddlFiltroOperatore).Items.FindByValue("CONTENUTO_IN").Enabled = false;
				((ListControl)ddlFiltroOperatore).Items.FindByValue("NON_CONTENUTO_IN").Enabled = false;
				break;
			case "Single":
			case "Double":
			case "Numeric":
			case "Decimal":
				txtFiltroNumericVal.DecimalDigits = 5;
				txtFiltroNumericVal.Text = "";
				txtFiltroNumericVal.Visible = true;
				((RadInputControl)txtFiltroNumericVal).Focus();
				ddlFiltroOperatore.ObjValue = "UGUALE";
				((ListControl)ddlFiltroOperatore).Items.FindByValue("CONTENUTO_IN").Enabled = false;
				((ListControl)ddlFiltroOperatore).Items.FindByValue("NON_CONTENUTO_IN").Enabled = false;
				break;
			case "DateTime":
				txtFiltroDateVal.Text = "";
				txtFiltroDateVal.Visible = true;
				txtFiltroDateVal.Focus();
				ddlFiltroOperatore.ObjValue = "UGUALE";
				break;
			default:
				txtFiltroStringVal.Text = "";
				txtFiltroStringVal.Visible = true;
				ddlFiltroOperatore.ObjValue = "CONTIENE";
				((Control)txtFiltroStringVal).Focus();
				((ListControl)ddlFiltroOperatore).Items.FindByValue("CONTENUTO_IN").Enabled = true;
				((ListControl)ddlFiltroOperatore).Items.FindByValue("NON_CONTENUTO_IN").Enabled = true;
				break;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			vsMessaggio = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(vsMessaggio);
			}
		}
	}

	private void ddlFiltroCampo_V2_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Invalid comparison between Unknown and I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			string text = ddlFiltroCampo_V2.SelectedValue.Substring(0, ddlFiltroCampo_V2.SelectedValue.LastIndexOf("$"));
			string text2 = ddlFiltroCampo_V2.SelectedValue.Substring(checked(ddlFiltroCampo_V2.SelectedValue.LastIndexOf("$") + 1));
			txtFiltroNumericVal_V2.Visible = false;
			txtFiltroDateVal_V2.Visible = false;
			txtFiltroStringVal_V2.Visible = false;
			switch (text2)
			{
			case "Int16":
			case "Int32":
			case "Int64":
				txtFiltroNumericVal_V2.DecimalDigits = 0;
				txtFiltroNumericVal_V2.Text = "";
				txtFiltroNumericVal_V2.Visible = true;
				((RadInputControl)txtFiltroNumericVal_V2).Focus();
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("CONTENUTO_IN").Enabled = false;
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("NON_CONTENUTO_IN").Enabled = false;
				break;
			case "Single":
			case "Double":
			case "Numeric":
			case "Decimal":
				txtFiltroNumericVal_V2.DecimalDigits = 5;
				txtFiltroNumericVal_V2.Text = "";
				txtFiltroNumericVal_V2.Visible = true;
				((RadInputControl)txtFiltroNumericVal_V2).Focus();
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("CONTENUTO_IN").Enabled = false;
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("NON_CONTENUTO_IN").Enabled = false;
				break;
			case "DateTime":
				txtFiltroDateVal_V2.Text = "";
				txtFiltroDateVal_V2.Visible = true;
				txtFiltroDateVal_V2.Focus();
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("CONTENUTO_IN").Enabled = false;
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("NON_CONTENUTO_IN").Enabled = false;
				break;
			default:
				txtFiltroStringVal_V2.Text = "";
				txtFiltroStringVal_V2.Visible = true;
				ddlFiltroOperatore_V2.ObjValue = "CONTIENE";
				((Control)txtFiltroStringVal_V2).Focus();
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("CONTENUTO_IN").Enabled = true;
				((ListControl)ddlFiltroOperatore_V2).Items.FindByValue("NON_CONTENUTO_IN").Enabled = true;
				break;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnFiltro_Elimina_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		try
		{
			if (((ListControl)lstFiltroTot).SelectedIndex >= 0)
			{
				((ListControl)lstFiltroTot).Items.RemoveAt(((ListControl)lstFiltroTot).SelectedIndex);
			}
			foreach (ListItem item in ((ListControl)lstFiltroTot).Items)
			{
				ListItem val = item;
				if (!_GridInfo.SqlStatement.SqlWhere[val.Value].CanBeDeleted)
				{
					val.Attributes["Disabled"] = "True";
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btnFiltro_Elimina_V2_Click(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		try
		{
			if (((ListControl)lstFiltroTot_V2).SelectedIndex >= 0)
			{
				((ListControl)lstFiltroTot_V2).Items.RemoveAt(((ListControl)lstFiltroTot_V2).SelectedIndex);
			}
			foreach (ListItem item in ((ListControl)lstFiltroTot_V2).Items)
			{
				ListItem val = item;
				if (!_GridInfo.SqlStatement.SqlWhere[val.Value].CanBeDeleted)
				{
					val.Attributes["Disabled"] = "True";
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void btnFiltroAnnulla_Click(object sender, EventArgs e)
	{
		((Control)pnlFiltro1).Visible = false;
		popFiltro.Hide();
	}

	protected void btnFiltroAnnulla_V2_Click(object sender, EventArgs e)
	{
		((Control)pnlFiltro1_V2).Visible = false;
		popFiltro_V2.Hide();
	}

	protected void btnFiltroConferma_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Invalid comparison between Unknown and I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		try
		{
			CallStackAdd();
			IboDropDownList val3 = null;
			IboDropDownList val4 = null;
			ListBox val5 = null;
			Panel val6 = null;
			IboWebTextBox val7 = null;
			IboWebNumericTlk val8 = null;
			IboWebDate2 iboWebDate = null;
			ModalPopupExtender val9;
			if (!Conversions.ToBoolean(base.UserApplicationVariables["WFI_Allgrd_UserFilter.Exists"]) | (Operators.CompareString(_FilterVersion, "1", false) == 0))
			{
				val3 = ddlFiltroCampo;
				val4 = ddlFiltroOperatore;
				val5 = lstFiltroTot;
				val6 = pnlFiltro1;
				val9 = popFiltro;
				val7 = txtFiltroStringVal;
				val8 = txtFiltroNumericVal;
				iboWebDate = txtFiltroDateVal;
			}
			else
			{
				val3 = ddlFiltroCampo_V2;
				val4 = ddlFiltroOperatore_V2;
				val5 = lstFiltroTot_V2;
				val6 = pnlFiltro1_V2;
				val9 = popFiltro_V2;
				val7 = txtFiltroStringVal_V2;
				val8 = txtFiltroNumericVal_V2;
				iboWebDate = txtFiltroDateVal_V2;
			}
			IboDropDownList ddlCampo = val3;
			IboDropDownList ddlOperatore = val4;
			ListBox lsFiltro = val5;
			IboWebNumericTlk txtNumero = val8;
			IboWebTextBox txtStringa = val7;
			IboWebDate2 txtData = iboWebDate;
			string rsmess = "";
			FiltroCondizioneAggiungi(ddlCampo, ddlOperatore, lsFiltro, txtNumero, txtStringa, txtData, ref rsmess);
			StringCollection stringCollection = new StringCollection();
			foreach (ListItem item in ((ListControl)val5).Items)
			{
				ListItem val10 = item;
				if (_GridInfo.SqlStatement.SqlWhere.ContainsKey(val10.Value) && !_GridInfo.SqlStatement.SqlWhere[val10.Value].CanBeDeleted)
				{
					stringCollection.Add(val10.Value);
				}
			}
			_GridInfo.SqlStatement.ClearUserVisibleWhere();
			foreach (ListItem item2 in ((ListControl)val5).Items)
			{
				ListItem val11 = item2;
				text = val11.Value;
				text2 = val11.Text;
				if (stringCollection.Contains(text))
				{
					_GridInfo.SqlStatement.AddWhere(text, text2, vbCanBeDeleted: false);
				}
				else
				{
					_GridInfo.SqlStatement.AddWhere(text, text2, vbCanBeDeleted: true);
				}
			}
			_GridConfig.DataTableSource = null;
			val2 = _GridConfig.Aggiorna(ref rsMess);
			if ((int)val2 <= 0)
			{
				((Control)val6).Visible = false;
				val9.Hide();
				base.MasterPage.ContentUpdatePanel.Update();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void ddlFiltroSalvato_V2_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			string selectedValue = ddlFiltroSalvato_V2.SelectedValue;
			btnFiltroCancella.Visible = true;
			btnFiltroSalva.Visible = true;
			if (Operators.CompareString(selectedValue, "0", false) != 0)
			{
				((ListControl)lstFiltroTot_V2).Items.Clear();
				val2 = _GridConfig.AnnullaFiltri(ref rsMess);
				if ((int)val2 > 0)
				{
					return;
				}
				foreach (KeyValuePair<string, WhereCondition> item in _GridInfo.SqlStatement.SqlWhere)
				{
					if (item.Value.UserVisible)
					{
						ListItem val3 = new ListItem(item.Value.ReadableExpression, item.Value.SqlExpression);
						if (!item.Value.CanBeDeleted)
						{
							val3.Attributes["Disabled"] = "True";
						}
						((ListControl)lstFiltroTot_V2).Items.Add(val3);
					}
				}
				DataRow dataRow = _GridInfo.UserFilterTable.Select("Id=" + selectedValue, "")[0];
				string[] array = dataRow["SQLHRFilter"].ToString().Split(new char[1] { ';' });
				string[] array2 = dataRow["SQLFilter"].ToString().Split(new char[1] { ';' });
				if (Operators.CompareString(dataRow["UtenteFiltro"].ToString().ToUpper(), base.WFIUser.ToUpper(), false) != 0)
				{
					btnFiltroCancella.Visible = false;
					btnFiltroSalva.Visible = false;
				}
				checked
				{
					int num = array2.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(array2[i], "", false) != 0)
						{
							ListItem val4 = new ListItem(array[i], array2[i]);
							((ListControl)lstFiltroTot_V2).Items.Add(val4);
						}
					}
					txtFiltroDescrizione_V2.ObjValue = dataRow["Descrizione"].ToString();
				}
			}
			else
			{
				txtFiltroDescrizione_V2.ObjValue = "";
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnFiltroSalva_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Invalid comparison between Unknown and I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			txtFiltroDescrizione_V2.ObjValue = txtFiltroDescrizione_V2.ObjValue.ToString().Trim();
			if (Operators.CompareString(txtFiltroDescrizione_V2.ObjValue.ToString(), "", false) == 0)
			{
				rsMess = TranslateMessage("GRDMS", "Inserire una descrizione del filtro");
				((Control)txtFiltroDescrizione_V2).Focus();
				return;
			}
			if (((ListControl)lstFiltroTot_V2).Items.Count == 0)
			{
				rsMess = TranslateMessage("GRDMS", "Inserire almeno una condizione di filtro");
				((Control)ddlFiltroCampo_V2).Focus();
				return;
			}
			string text = "";
			string selectedValue = ddlFiltroSalvato_V2.SelectedValue;
			string text2 = "";
			string text3 = "";
			foreach (ListItem item in ((ListControl)lstFiltroTot_V2).Items)
			{
				ListItem val3 = item;
				if (val3.Enabled)
				{
					text2 = text2 + val3.Value + ";";
					text3 = text3 + val3.Text + ";";
				}
			}
			if ((Operators.CompareString(selectedValue, "0", false) == 0) | (Operators.CompareString(selectedValue, "", false) == 0))
			{
				text = "INSERT INTO WFI_Allgrd_UserFilter (NomRif, Utente, UtenteFiltro, Descrizione, SqlFilter, SqlHRFilter) VALUES (";
				text = text + base.DbConn.SQLFormatString(sNomRif) + ", ";
				text = text + base.DbConn.SQLFormatString(_Utente) + ", ";
				text = text + base.DbConn.SQLFormatString(base.WFIUser) + ", ";
				text = text + base.DbConn.SQLFormatString(txtFiltroDescrizione_V2.ObjValue.ToString()) + ", ";
				text = text + base.DbConn.SQLFormatString(text2) + ", ";
				text = text + base.DbConn.SQLFormatString(text3) + ");";
			}
			else
			{
				text = "UPDATE WFI_Allgrd_UserFilter SET Descrizione=" + base.DbConn.SQLFormatString(txtFiltroDescrizione_V2.ObjValue.ToString()) + ", ";
				text = text + "SqlFilter=" + base.DbConn.SQLFormatString(text2) + ", ";
				text = text + "SqlHRFilter=" + base.DbConn.SQLFormatString(text3) + ", ";
				text = text + "DatAgg=" + base.DbConn.GetDate() + ", UteAgg=" + base.DbConn.SQLFormatString(base.WFIUser) + " ";
				text = text + "WHERE Id=" + selectedValue + ";";
			}
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			IboGridInfo gridInfo = _GridInfo;
			string rsMess2 = "";
			gridInfo.Update_UserFilter(ref rsMess2);
			PopolaFiltriSalvati();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnFiltroCancella_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			string text = "";
			string selectedValue = ddlFiltroSalvato_V2.SelectedValue;
			if ((Operators.CompareString(selectedValue, "0", false) == 0) | (Operators.CompareString(selectedValue, "", false) == 0))
			{
				rsMess = TranslateMessage("GRDMS", "Selezionare il filtro da cancellare");
				((Control)ddlFiltroSalvato_V2).Focus();
				return;
			}
			text = "DELETE FROM WFI_Allgrd_UserFilter ";
			text = text + "WHERE Id=" + selectedValue + ";";
			val2 = base.DbConn.SqlExec(text, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			IboGridInfo gridInfo = _GridInfo;
			string rsMess2 = "";
			gridInfo.Update_UserFilter(ref rsMess2);
			PopolaFiltriSalvati();
			txtFiltroDescrizione_V2.ObjValue = "";
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void PopolaFiltriSalvati()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		((ListControl)ddlFiltroSalvato_V2).Items.Clear();
		ListItem val = new ListItem();
		val.Text = TranslateMessage("XXX", "<Nuovo filtro>");
		val.Value = "0";
		val.Selected = true;
		((ListControl)ddlFiltroSalvato_V2).Items.Add(val);
		foreach (DataRow row in _GridInfo.UserFilterTable.Rows)
		{
			val = new ListItem();
			val.Text = row["Descrizione"].ToString();
			val.Value = row["Id"].ToString();
			val.Selected = false;
			((ListControl)ddlFiltroSalvato_V2).Items.Add(val);
		}
	}

	private void btnConferma_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		try
		{
			CallStackAdd();
			IboGridView val3 = grdGriglia;
			DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: true, ref rsMess);
			grdGriglia = val3;
			if ((int)keyDataFromGrid <= 0)
			{
				ReturnFromIFrame(robjData);
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				string sUrl = "~/WFI/Form/IdlePage.aspx";
				IboResponseRedirect(ref robjCallStackHandler, ref sUrl, RegisterPageInQueue: false);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnAnnulla_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			ReturnFromIFrame(null);
			IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
			string sUrl = "~/WFI/Form/IdlePage.aspx";
			IboResponseRedirect(ref robjCallStackHandler, ref sUrl, RegisterPageInQueue: false);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void btnButtonBack_Click(object sender, EventArgs e)
	{
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboWebButton val;
		string sUrl = (val = btnButtonBack).IncasTag;
		IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
		val.IncasTag = sUrl;
	}

	private void btnSelezionaTutto_Click(object sender, EventArgs e)
	{
		try
		{
			grdGriglia.SelectAllRows();
			up_grdGriglia.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btnDeselezionaTutto_Click(object sender, EventArgs e)
	{
		try
		{
			grdGriglia.UnselectAllRows();
			up_grdGriglia.Update();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void GridHeaderCellInfo_Click(object sender, ImageClickEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		try
		{
			CallStackAdd();
			WriteInfoMessage("Elenco shortcut da tastiera", _ToolbarConfig.GetToolbarObject.GetShortcutInfoHtml, ShowAsNotification: false);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	public override FXRETURN Visualizza(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboGridView val2 = grdGriglia;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val2, ref _GridInfo, ref robjData, ref rsMess);
			grdGriglia = val2;
			if ((int)keyDataFromGrid <= 0)
			{
				_GridInfo.GridPage = ((GridView)grdGriglia).PageIndex;
				_SessionVariable.Add("ReturnToSelectedRecord", "S");
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData);
				robjFunctionArguments.WFIPage = this;
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Visualizza(ref _GridInfo, ref robjFunctionArguments, ref rsMess) <= 0)
				{
					robjFunctionArguments.WFIPage = null;
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
			robjData = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Inserisci(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboGridView val2 = grdGriglia;
			DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val2, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			grdGriglia = val2;
			if ((int)keyDataFromGrid <= 0)
			{
				_GridInfo.GridPage = ((GridView)grdGriglia).PageIndex;
				_SessionVariable.Add("ReturnToSelectedRecord", "S");
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Inserisci(ref _GridInfo, ref robjFunctionArguments, ref rsMess) <= 0)
				{
					robjFunctionArguments.WFIPage = null;
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Modifica(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboGridView val2 = grdGriglia;
			DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val2, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: true, ref rsMess);
			grdGriglia = val2;
			if ((int)keyDataFromGrid <= 0)
			{
				_GridInfo.GridPage = ((GridView)grdGriglia).PageIndex;
				_SessionVariable.Add("ReturnToSelectedRecord", "S");
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Modifica(ref _GridInfo, ref robjFunctionArguments, ref rsMess) <= 0)
				{
					robjFunctionArguments.WFIPage = null;
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
			robjData = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN _CallFunction(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Invalid comparison between Unknown and I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		IboWebToolbarEventArgs iboWebToolbarEventArgs = null;
		string text = "";
		FunctionArguments robjFunctionArguments = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			iboWebToolbarEventArgs = (IboWebToolbarEventArgs)((object[])objParams)[0];
			dataKeyFieldCollection = (DataKeyFieldCollection)((object[])objParams)[1];
			DataKeyFieldValues[] rKeys = (DataKeyFieldValues[])((object[])objParams)[2];
			text = ((object[])objParams)[3].ToString();
			if (iboWebToolbarEventArgs.CommandName.ToUpper().StartsWith("GOTOWITHMSG") | iboWebToolbarEventArgs.CommandName.ToUpper().StartsWith("PRNETI"))
			{
				if (!((base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma) | (Operators.CompareString(text, "N", false) == 0)))
				{
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
					goto IL_030d;
				}
				base.SessionEnvironment.UserMessage.Reset();
				robjFunctionArguments = new FunctionArguments(dataKeyFieldCollection, rKeys);
				robjFunctionArguments.Parameters.Add("CallerPage", this);
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).CallFunction(ref robjFunctionArguments, iboWebToolbarEventArgs, ref rsMess) <= 0)
				{
					goto IL_030d;
				}
			}
			else
			{
				if (!iboWebToolbarEventArgs.CommandName.ToUpper().StartsWith("SQLEXEC"))
				{
					goto IL_030d;
				}
				if (!((base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Conferma) | (Operators.CompareString(text, "N", false) == 0)))
				{
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
					goto IL_0230;
				}
				base.SessionEnvironment.UserMessage.Reset();
				robjFunctionArguments = new FunctionArguments(dataKeyFieldCollection, rKeys);
				robjFunctionArguments.Parameters.Add("CallerPage", this);
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).CallFunction(ref robjFunctionArguments, iboWebToolbarEventArgs, ref rsMess) <= 0)
				{
					goto IL_0230;
				}
			}
			goto end_IL_0016;
			IL_030d:
			val = (FXRETURN)0;
			goto end_IL_0016;
			IL_0230:
			if (robjFunctionArguments.Parameters.ContainsKey("_warningMessage"))
			{
				if (Operators.CompareString(robjFunctionArguments.Parameters["_warningMessage"].ToString(), "", false) != 0)
				{
					WriteInfoMessage(robjFunctionArguments.Parameters["_warningMessage"].ToString(), ShowAsNotification: true);
				}
				robjFunctionArguments.Parameters.Remove("_warningMessage");
			}
			if (robjFunctionArguments.Parameters.ContainsKey("_RefreshGrid"))
			{
				if (Operators.CompareString(robjFunctionArguments.Parameters["_RefreshGrid"].ToString(), "S", false) == 0)
				{
					string rsMess2 = "";
					Aggiorna(ref rsMess2);
				}
				robjFunctionArguments.Parameters.Remove("_RefreshGrid");
			}
			goto IL_030d;
			end_IL_0016:;
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
			if (iboWebToolbarEventArgs.CommandName.ToUpper().StartsWith("PRNETI"))
			{
				robjFunctionArguments.Parameters["CallerPage"] = null;
				robjFunctionArguments.Parameters.Remove("CallerPage");
			}
			dataKeyFieldCollection = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN CallFunction(IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Invalid comparison between Unknown and I4
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Invalid comparison between Unknown and I4
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Invalid comparison between Unknown and I4
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Invalid comparison between Unknown and I4
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Invalid comparison between Unknown and I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Invalid comparison between Unknown and I4
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Invalid comparison between Unknown and I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Invalid comparison between Unknown and I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Invalid comparison between Unknown and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Invalid comparison between Unknown and I4
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
			if (e.CommandName.ToUpper().StartsWith("GOTOWITHMSG"))
			{
				base.SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref robjKey, e.CommandName.ToUpper().StartsWith("GOTOWITHMSG;S") | e.CommandName.ToUpper().StartsWith("GOTOWITHMSG;M") | e.CommandName.ToUpper().StartsWith("GOTOWITHMSG;2"), ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid <= 0)
				{
					if (e.CommandName.ToUpper().StartsWith("GOTOWITHMSG;M"))
					{
						if (robjData.Item(0).FieldValuesCount >= 2)
						{
							goto IL_0155;
						}
						rsMess = TranslateMessage("GRDMS", "Selezionare almeno due record");
					}
					else
					{
						if (!e.CommandName.ToUpper().StartsWith("GOTOWITHMSG;2") || robjData.Item(0).FieldValuesCount == 2)
						{
							goto IL_0155;
						}
						rsMess = TranslateMessage("GRDMS", "Selezionare esattamente due record");
					}
				}
			}
			else if (e.CommandName.ToUpper().StartsWith("PRNETI"))
			{
				base.SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref robjKey, e.CommandName.ToUpper().StartsWith("PRNETI;S") | e.CommandName.ToUpper().StartsWith("PRNETI;M"), ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid2 <= 0)
				{
					if (e.CommandName.ToUpper().StartsWith("PRNETI;M") && robjData.Item(0).FieldValuesCount < 2)
					{
						rsMess = TranslateMessage("GRDMS", "Selezionare almeno due record");
					}
					else
					{
						Hashtable sRetColl = null;
						val2 = base.BaseFunctions.StandardParser(e.CommandArguments, ref sRetColl, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (Operators.CompareString(sRetColl["ChiediConferma"].ToString(), "S", false) == 0)
							{
								base.SessionEnvironment.UserMessage.Reset();
								base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
								base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("GRDMS", sRetColl["Msg1"].ToString());
								base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("GRDMS", sRetColl["Msg2"].ToString());
								base.SessionEnvironment.UserMessage.NeedToRefresh = true;
								base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
								base.SessionEnvironment.UserMessage.CallBackType = WFIUserMessage.CallBackTypeEnum.CallByNameFunction;
								base.SessionEnvironment.UserMessage.CallBackFunctionName = "_CallFunction";
								base.SessionEnvironment.UserMessage.Parameters = new object[4] { e, robjData, robjKey, "S" };
								WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
								IboMessageBox(ref UserMess);
								goto IL_0810;
							}
							object objParams = new object[4] { e, robjData, robjKey, "N" };
							val2 = _CallFunction(ref objParams, ref rsMess);
							if ((int)val2 <= 0)
							{
								goto IL_0810;
							}
							val = val2;
						}
					}
				}
			}
			else if (e.CommandName.ToUpper().StartsWith("SQLEXEC"))
			{
				base.SessionEnvironment.UserMessage.UserChoice = WFIUserMessage.MessageUserChoice.Undefined;
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid3 = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: true, ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid3 <= 0)
				{
					Hashtable sRetColl2 = null;
					val2 = base.BaseFunctions.StandardParser(e.CommandArguments, ref sRetColl2, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Operators.CompareString(sRetColl2["ChiediConferma"].ToString(), "S", false) == 0)
						{
							base.SessionEnvironment.UserMessage.Reset();
							base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
							base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("GRDMS", sRetColl2["Msg1"].ToString());
							base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("GRDMS", sRetColl2["Msg2"].ToString());
							base.SessionEnvironment.UserMessage.NeedToRefresh = true;
							base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
							base.SessionEnvironment.UserMessage.CallBackType = WFIUserMessage.CallBackTypeEnum.CallByNameFunction;
							base.SessionEnvironment.UserMessage.CallBackFunctionName = "_CallFunction";
							base.SessionEnvironment.UserMessage.Parameters = new object[4] { e, robjData, robjKey, "S" };
							WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
							IboMessageBox(ref UserMess);
							goto IL_0810;
						}
						object objParams = new object[4] { e, robjData, robjKey, "N" };
						val2 = _CallFunction(ref objParams, ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_0810;
						}
						val = val2;
					}
				}
			}
			else
			{
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid4 = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid4 <= 0)
				{
					FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
					robjFunctionArguments.Parameters.Add("CallerPage", this);
					if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).CallFunction(ref _GridInfo, ref robjFunctionArguments, e, ref rsMess) <= 0 && (int)Aggiorna(ref rsMess) <= 0)
					{
						goto IL_0810;
					}
				}
			}
			goto end_IL_000b;
			IL_0155:
			Hashtable sRetColl3 = null;
			val2 = base.BaseFunctions.StandardParser(e.CommandArguments, ref sRetColl3, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(sRetColl3["ChiediConferma"].ToString(), "S", false) == 0)
				{
					base.SessionEnvironment.UserMessage.Reset();
					base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
					base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("GRDMS", sRetColl3["Msg1"].ToString());
					base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("GRDMS", sRetColl3["Msg2"].ToString());
					base.SessionEnvironment.UserMessage.NeedToRefresh = true;
					base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
					base.SessionEnvironment.UserMessage.CallBackType = WFIUserMessage.CallBackTypeEnum.CallByNameFunction;
					base.SessionEnvironment.UserMessage.CallBackFunctionName = "_CallFunction";
					base.SessionEnvironment.UserMessage.Parameters = new object[4] { e, robjData, robjKey, "S" };
					WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref UserMess);
					goto IL_0810;
				}
				object objParams = new object[4] { e, robjData, robjKey, "N" };
				val2 = _CallFunction(ref objParams, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0810;
				}
				val = val2;
			}
			goto end_IL_000b;
			IL_0810:
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
			robjData = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public FXRETURN CancellaDelegate(ref object objParams, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return Cancella(ref rsMess);
	}

	public override FXRETURN Cancella(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Invalid comparison between Unknown and I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Invalid comparison between Unknown and I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName);
			if (Operators.CompareString(manager.Tipo, "DB3", false) == 0)
			{
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid <= 0)
				{
					FunctionArguments robjFunctionArguments = new FunctionArguments(robjData);
					if ((int)manager.Cancella(ref robjFunctionArguments, ref rsMess) <= 0)
					{
						goto IL_0297;
					}
				}
			}
			else if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid2 <= 0)
				{
					base.SessionEnvironment.UserMessage.Reset();
					base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
					base.SessionEnvironment.UserMessage.Message1 = "Attenzione!!!";
					base.SessionEnvironment.UserMessage.Message2 = "Confermare l'eliminazione dei record selezionati?";
					base.SessionEnvironment.UserMessage.NeedToRefresh = true;
					base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
					base.SessionEnvironment.UserMessage.CallBackFunctionName = "CancellaDelegate";
					WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref UserMess);
					goto IL_0297;
				}
			}
			else
			{
				if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
				{
					if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
					{
						base.SessionEnvironment.UserMessage.Reset();
					}
					goto IL_0297;
				}
				bool needToRefresh = base.SessionEnvironment.UserMessage.NeedToRefresh;
				object obj = RuntimeHelpers.GetObjectValue(base.SessionEnvironment.UserMessage.Parameters);
				base.SessionEnvironment.UserMessage.Reset();
				IboGridView val3 = grdGriglia;
				FXRETURN keyDataFromGrid3 = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, ref rsMess);
				grdGriglia = val3;
				if ((int)keyDataFromGrid3 <= 0)
				{
					FunctionArguments robjFunctionArguments = new FunctionArguments(robjData);
					if ((int)manager.Cancella(ref robjFunctionArguments, ref rsMess) <= 0)
					{
						if (!needToRefresh)
						{
							goto IL_0297;
						}
						val2 = Aggiorna(ref obj, ref rsMess);
						if ((int)val2 <= 0)
						{
							goto IL_0297;
						}
						val = val2;
					}
				}
			}
			goto end_IL_000b;
			IL_0297:
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
			robjData = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Duplica(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboGridView val2 = grdGriglia;
			DataKeyFieldValues[] robjKey = default(DataKeyFieldValues[]);
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val2, ref _GridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: true, ref rsMess);
			grdGriglia = val2;
			if ((int)keyDataFromGrid <= 0)
			{
				_GridInfo.GridPage = ((GridView)grdGriglia).PageIndex;
				_SessionVariable.Add("ReturnToSelectedRecord", "S");
				FunctionArguments robjFunctionArguments = new FunctionArguments(robjData, robjKey);
				robjFunctionArguments.WFIPage = this;
				if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Duplica(ref _GridInfo, ref robjFunctionArguments, ref rsMess) <= 0)
				{
					robjFunctionArguments.WFIPage = null;
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN Stampa(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
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
			val2 = _Stampa(ref rsMess);
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected virtual FXRETURN _Stampa(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Invalid comparison between Unknown and I4
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Invalid comparison between Unknown and I4
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Invalid comparison between Unknown and I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Invalid comparison between Unknown and I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Invalid comparison between Unknown and I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Invalid comparison between Unknown and I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		string text = "";
		DataTable dataTable = null;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			int i = default(int);
			while (true)
			{
				flag = false;
				flag3 = true;
				if (flag2)
				{
					base.SessionEnvironment.UserSelect.Reset();
					base.SessionEnvironment.UserSelect.Title = TranslateMessage("GRDMS", "Stampa report");
					base.SessionEnvironment.UserSelect.Subtitle = TranslateMessage("GRDMS", "Elenco dei report disponibili");
					base.SessionEnvironment.UserSelect.NeedToRefresh = true;
					base.SessionEnvironment.UserSelect.Type = WFIUserSelect.SelectUserDialogType.DropDownList;
					base.SessionEnvironment.UserSelect.DelegateCallBack = _Stampa;
					base.SessionEnvironment.UserSelect.Values = text2;
					WFIUserSelect UserSel = base.SessionEnvironment.UserSelect;
					IboSelectBox(ref UserSel);
					flag3 = false;
					base.MasterPage.MasterUpdateProgress.DisplayAfter = 60000;
				}
				if (base.SessionEnvironment.UserSelect.UserDialogResult == WFIUserSelect.SelectUserDialogResult.Conferma)
				{
					text = base.SessionEnvironment.UserSelect.Selected;
					base.SessionEnvironment.UserSelect.Reset();
					flag = true;
				}
				else if (base.SessionEnvironment.UserSelect.UserDialogResult == WFIUserSelect.SelectUserDialogResult.Annulla)
				{
					base.SessionEnvironment.UserSelect.Reset();
					flag3 = false;
				}
				if (flag3)
				{
					MasterUpdateProgressConfig(Visibile: false, 2000);
					string text3 = "SELECT T2.* FROM WFI_ALLGRD_TABREP T1 INNER JOIN WFI_TABREP T2 ";
					text3 += "ON T1.NOMREP=T2.NOMREP ";
					text3 = text3 + "WHERE T1.NomRif=" + base.DbConn.SQLFormatString(sNomRif) + " ";
					text3 = text3 + "AND T1.Utente=" + base.DbConn.SQLFormatString(_Utente) + " ";
					if (Operators.CompareString(text, "", false) != 0)
					{
						text3 = text3 + "AND T2.NOMREP = " + base.DbConn.SQLFormatString(text);
					}
					text3 += " ORDER BY T1.Ordine";
					val2 = base.SessionEnvironment.DbConn.OpenDataTable(text3, ref dataTable, ref rsMess);
					if ((int)val2 > 0)
					{
						break;
					}
					if (dataTable.Rows.Count == 0)
					{
						rsMess = TranslateMessage("GRDMS", "Non è disponibile nessuna stampa per la griglia {0}", sNomRif);
						break;
					}
					if (dataTable.Rows.Count == 1)
					{
						IboGridView val3 = grdGriglia;
						FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref val3, ref _GridInfo, ref robjData, bSelezioneObbligatoria: true, ref rsMess);
						grdGriglia = val3;
						if ((int)keyDataFromGrid > 0)
						{
							break;
						}
						FunctionArguments robjFunctionArguments = new FunctionArguments(sNomRif, robjData);
						((Page)this).Session["FunctionArgsReportPage"] = robjFunctionArguments;
						if (dataTable.Rows[0]["NomRep"].ToString().ToLower().Contains("#"))
						{
							string[] array = dataTable.Rows[0]["NomRep"].ToString().Split(new char[1] { '#' });
							StringCollection stringCollection = new StringCollection();
							int num = 0;
							DataTable dataTable2 = null;
							val2 = base.DbConn.OpenDataTable("SELECT * FROM WFI_TABREP_STAMPEAUTOMATICHE WHERE NOMREP=" + base.DbConn.SQLFormatString(dataTable.Rows[0]["NomRep"].ToString()), ref dataTable2, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
								break;
							}
							string[] array2 = array;
							int num2 = 0;
							while (true)
							{
								if (num2 < array2.Length)
								{
									string nomeReport = array2[num2];
									string NomeFileCompletoGenerato = "";
									string text4 = sNomRif;
									string utente = _Utente;
									FunctionArguments objFunctionArguments = robjFunctionArguments;
									DataTable lastDataTableSource = _GridConfig.LastDataTableSource;
									bool StampaAsincrona = false;
									val2 = AvviaStampa(text4, utente, objFunctionArguments, lastDataTableSource, nomeReport, "", "", "", "N", ref NomeFileCompletoGenerato, ref StampaAsincrona, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
										break;
									}
									stringCollection.Add(NomeFileCompletoGenerato);
									num2 = checked(num2 + 1);
									continue;
								}
								bool flag4 = false;
								flag4 = dataTable2.Rows.Count != 0 && Operators.CompareString(dataTable2.Rows[0]["StampaAsincrona"].ToString(), "S", false) == 0;
								string PdfMergedFile = "";
								val2 = PdfMerge(stringCollection, SegnaFileComeDaCancellare: true, ref PdfMergedFile, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
									break;
								}
								if (!flag4)
								{
									string nomeFilePDF = PdfMergedFile;
									string rsMess2 = "";
									VisualizzaStampa(nomeFilePDF, ref rsMess2);
								}
								else
								{
									text3 = "INSERT INTO WFI_PrintQueue (NomRep,Utente,SelectionFormula,HumanSelectionFormula,ContentToPrint,ContentExtension,Printer,ContentCreationDate,UteIns,UteAgg) VALUES ( ";
									text3 = text3 + base.DbConn.SQLFormatString(dataTable.Rows[0]["NomRep"].ToString()) + ", ";
									text3 = text3 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
									text3 = text3 + base.DbConn.SQLFormatString("") + ", ";
									text3 = text3 + base.DbConn.SQLFormatString("") + ", ";
									byte[] array3 = File.ReadAllBytes(PdfMergedFile);
									text3 = text3 + base.DbConn.ConvertToVarbinary(modGeneral.ByteArrayToString(array3)) + ", ";
									text3 = text3 + base.DbConn.SQLFormatString("PDF") + ", ";
									text3 = text3 + base.DbConn.SQLFormatString(dataTable2.Rows[0]["Stampante"].ToString()) + ", ";
									text3 = text3 + base.DbConn.GetDate() + ", ";
									text3 = text3 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
									text3 = text3 + base.DbConn.SQLFormatString(base.SessionEnvironment.WebUser.WebUserInfo.Codice) + ") ";
									val2 = base.DbConn.SqlExec(text3, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
										break;
									}
								}
								flag = false;
								goto IL_0870;
							}
							break;
						}
						if (dataTable.Rows[0]["NomRep"].ToString().ToLower().EndsWith(".rpt"))
						{
							robjFunctionArguments.Name = sNomRif;
							robjFunctionArguments.Argomento1 = sNomRif + "@" + _Utente;
							robjFunctionArguments.Argomento2 = dataTable.Rows[0]["NomRep"].ToString();
							robjFunctionArguments.Argomento3 = dataTable.Rows[0]["Tipo"].ToString().ToUpper();
							robjFunctionArguments.Argomento6 = _GridConfig.LastDataTableSource;
							if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Stampa(ref robjFunctionArguments, ref rsMess) > 0)
							{
								break;
							}
						}
						else if ((int)base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName).Stampa(ref robjFunctionArguments, ref rsMess) > 0)
						{
							break;
						}
					}
					else
					{
						for (; i < dataTable.Rows.Count; i = checked(i + 1))
						{
							if (text2.Length > 0)
							{
								text2 += ";";
							}
							text2 = text2 + dataTable.Rows[i]["DesRep"].ToString() + ";" + dataTable.Rows[i]["NomRep"].ToString();
						}
						flag = true;
						flag2 = true;
					}
				}
				goto IL_0870;
				IL_0870:
				if (!flag)
				{
					val = (FXRETURN)0;
					break;
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
			if (dataTable != null)
			{
				dataTable.Dispose();
				dataTable = null;
			}
			robjData = null;
			result = val;
			CallStackRemove();
		}
		return result;
	}

	public override FXRETURN EsportazioneDati(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			((Control)pnlExport2).Visible = true;
			((Control)rdbExportFormat).Focus();
			popExport.Show();
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
		return result;
	}

	public override FXRETURN StampaVeloce(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			((GridView)grdGriglia).AllowSorting = false;
			((GridView)grdGriglia).AllowPaging = false;
			grdGriglia.AutoGenerateCheckBoxColumn = false;
			val2 = _GridConfig.Aggiorna(ref rsMess);
			if ((int)val2 <= 0)
			{
				((Control)pnlDataGridPrint).Visible = true;
				base.ToolbarVisible = false;
				((Control)chkAutoUpdate).Visible = false;
				((WebControl)pnlBackButton).ToolTip = "PRINT";
				((WebControl)pnlCommands).ToolTip = "PRINT";
				tmrUpdate.Enabled = false;
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	private FXRETURN AutoApplyFilter(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).Request.Form["__EVENTARGUMENT"] == null)
			{
				goto IL_0494;
			}
			string[] array = ((Page)this).Request.Form["__EVENTARGUMENT"].ToString().Split(new char[1] { ';' });
			if (Operators.CompareString(array[0].ToUpper(), "APPLYFILTER", false) != 0)
			{
				if (Operators.CompareString(array[0], "SELECT_ALL", false) == 0)
				{
					if (_GridInfo.CanSelect && _GridInfo.EnableMultiSelection)
					{
						grdGriglia.SelectAllRows();
					}
				}
				else if (Operators.CompareString(array[0], "DESELECT_ALL", false) == 0 && _GridInfo.CanSelect)
				{
					grdGriglia.UnselectAllRows();
				}
				goto IL_0494;
			}
			checked
			{
				string text = _GridInfo.TabGrd[Conversions.ToInteger(array[2]) - 1]["NomCam"].ToString();
				string text2 = _GridInfo.TabGrd[Conversions.ToInteger(array[2]) - 1]["DesCam"].ToString();
				if ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(DateTime))
				{
					if (Operators.CompareString(_GridInfo.TabGrd[Conversions.ToInteger(array[2]) - 1]["ForCam"].ToString().ToUpper(), "{0:dd/MM/yy}".ToUpper(), false) == 0 && Strings.Len(array[1]) > 0)
					{
						int num = Conversions.ToInteger(Strings.Left(array[1], 2));
						int num2 = Conversions.ToInteger(Strings.Mid(array[1], 4, 2));
						int num3 = Conversions.ToInteger(Strings.Left(DateAndTime.Now.Year.ToString(), 2) + Conversions.ToInteger(Strings.Right(array[1], 2)));
						array[1] = num + "/" + num2 + "/" + num3;
					}
					text = text + "=" + base.DbConn.SQLFormatDate((eTipoData)2, array[1]);
					text2 = text2 + "=" + base.DbConn.SQLFormatDate((eTipoData)2, array[1]);
				}
				else if (((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(short)) | ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(int)) | ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(long)) | ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(decimal)) | ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(float)) | ((object)_GridConfig.LastDataTableSource.Columns[text].DataType == typeof(double)))
				{
					string text3 = text;
					DBConnection dbConn = base.DbConn;
					decimal num4 = Conversions.ToDecimal(array[1]);
					text = text3 + "=" + dbConn.SQLFormatNumber(ref num4);
					string text4 = text2;
					DBConnection dbConn2 = base.DbConn;
					num4 = Conversions.ToDecimal(array[1]);
					text2 = text4 + "=" + dbConn2.SQLFormatNumber(ref num4);
				}
				else
				{
					text = text + "=" + base.DbConn.SQLFormatString(array[1]);
					text2 = text2 + "=" + base.DbConn.SQLFormatString(array[1]);
				}
				_GridInfo.SqlStatement.AddWhere(text, text2, vbCanBeDeleted: true);
				val2 = _GridConfig.Aggiorna(ref rsMess);
			}
			if ((int)val2 <= 0)
			{
				goto IL_0494;
			}
			goto end_IL_0005;
			IL_0494:
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	private string RedirectToOnlyAspxPageName(string aspxPage)
	{
		string result;
		try
		{
			string text = Strings.Replace(aspxPage, "/", "\\", 1, -1, (CompareMethod)0);
			if (Strings.InStrRev(text, "\\", -1, (CompareMethod)0) >= 0)
			{
				text = Strings.Mid(text, checked(Strings.InStrRev(text, "\\", -1, (CompareMethod)0) + 1));
			}
			result = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void grdGriglia_PreRender(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		string text = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			GridView val2 = (GridView)(IboGridView)sender;
			checked
			{
				foreach (GridViewRow row in val2.Rows)
				{
					GridViewRow val3 = row;
					int num = 0;
					if (_GridInfo.CanSelect)
					{
						num = 1;
					}
					int num2 = 0;
					foreach (DataControlField item in (StateManagedCollection)val2.Columns)
					{
						DataControlField val4 = item;
						BoundField val5 = (BoundField)(object)((val4 is BoundField) ? val4 : null);
						if (val5 == null)
						{
							continue;
						}
						int num3 = num2;
						int num4 = _GridInfo.TabGrd.Count - 1;
						for (int i = num3; i <= num4; i++)
						{
							DataRow dataRow = _GridInfo.TabGrd[i];
							if (Operators.CompareString(dataRow["NOMCAM"].ToString().ToUpper(), val5.DataField.ToUpper(), false) != 0)
							{
								continue;
							}
							num2++;
							if (Operators.CompareString(dataRow["VISIBILE"].ToString(), "S", false) != 0)
							{
								break;
							}
							int num5 = 0;
							if (Operators.CompareString(dataRow["MAXCHAR"].ToString(), "", false) != 0 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dataRow["MAXCHAR"])))
							{
								num5 = Conversions.ToInteger(dataRow["MAXCHAR"]);
							}
							if (Operators.CompareString(((TableRow)val3).Cells[num].Text, "", false) != 0)
							{
								((TableRow)val3).Cells[num].Text = modGeneral.TrimDoubleSpace(((TableRow)val3).Cells[num].Text);
							}
							if (unchecked(((TableRow)val3).Cells[num].Text.Length > num5 && num5 > 0))
							{
								try
								{
									if (!((TableRow)val3).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
									{
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = ((TableRow)val3).Cells[num].Text;
										((TableRow)val3).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip.Substring(0, num5).Trim() + "...", 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TITLE%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%CSSSTYLE%>", dataRow["NOMCAM"].ToString().ToUpper(), 1, -1, (CompareMethod)0);
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = "";
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								if (Operators.CompareString(dataRow["NOMCAMTOOLTIP"].ToString(), "", false) == 0)
								{
									break;
								}
								if (dataRow["NOMCAMTOOLTIP"].ToString().ToUpper().StartsWith("AJAX:"))
								{
									string columnName = Strings.Mid(dataRow["NOMCAMTOOLTIP"].ToString(), 6);
									string text2 = Strings.Trim(((DataTable)((BaseDataBoundControl)val2).DataSource).Rows[val3.DataItemIndex][columnName].ToString());
									if (Operators.CompareString(text2, "", false) != 0)
									{
										IboCrypt val6 = new IboCrypt();
										string text3 = val6.EncryptString128Bit(text2);
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = ((TableRow)val3).Cells[num].Text;
										((TableRow)val3).Cells[num].Text = "<a class=\"WFIAjaxHtmlTooltip\"><input type=\"hidden\" id=\"TooltipSelect\" value=\"<%SSQL%>\"><%TEXT%></a>";
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%SSQL%>", text3, 1, -1, (CompareMethod)0);
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = "";
									}
									break;
								}
								try
								{
									string text4 = dataRow["NOMCAMTOOLTIP"].ToString();
									string text5 = Strings.Trim(((DataTable)((BaseDataBoundControl)val2).DataSource).Rows[val3.DataItemIndex][text4].ToString());
									if (Operators.CompareString(text5, "", false) != 0 && !((TableRow)val3).Cells[num].Text.StartsWith("<a class=\"htmltooltip\" rel=\"htmltooltip\""))
									{
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = ((TableRow)val3).Cells[num].Text;
										((TableRow)val3).Cells[num].Text = "<a class=\"htmltooltip\" rel=\"htmltooltip\" href=\"javascript:void(0)\"><%TEXT%></a><div class=\"htmltooltip <%CSSSTYLE%>\"><%TITLE%></div>";
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TEXT%>", ((WebControl)((TableRow)val3).Cells[num]).ToolTip, 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%TITLE%>", text5, 1, -1, (CompareMethod)0);
										((TableRow)val3).Cells[num].Text = Strings.Replace(((TableRow)val3).Cells[num].Text, "<%CSSSTYLE%>", text4, 1, -1, (CompareMethod)0);
										((WebControl)((TableRow)val3).Cells[num]).ToolTip = "";
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ProjectData.ClearProjectError();
								}
							}
							break;
						}
						num++;
					}
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = ex6.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val <= 0)
			{
			}
		}
	}

	private void grdGriglia_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between Unknown and I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			PerformanceLogAppend("BEGIN grdGriglia_Sorting event");
			sqlSelect.OrderBySortOrder orderBySortOrder = (_GridInfo.SqlStatement.ExistsOrderByField(e.SortExpression) ? ((_GridInfo.SqlStatement.ItemOrderByField(e.SortExpression).SortOrder == sqlSelect.OrderBySortOrder.Ascending) ? sqlSelect.OrderBySortOrder.Descending : sqlSelect.OrderBySortOrder.Ascending) : (((int)e.SortDirection != 0) ? sqlSelect.OrderBySortOrder.Descending : sqlSelect.OrderBySortOrder.Ascending));
			((GridView)grdGriglia).PageIndex = 0;
			_GridInfo.SqlStatement.ClearOrderByField();
			_GridInfo.SqlOriginalStatement.ClearOrderByField();
			_GridInfo.SqlStatement.AddOrderByField(e.SortExpression, orderBySortOrder);
			_GridInfo.SqlOriginalStatement.AddOrderByField(e.SortExpression, orderBySortOrder);
			_GridInfo.CampiOrdinantiAttuali = e.SortExpression;
			_GridInfo.CampiOrdinantiAttualiDirezione = Interaction.IIf(orderBySortOrder == sqlSelect.OrderBySortOrder.Ascending, (object)"ASC", (object)"DESC").ToString();
			_GridInfo.CampoAttivo = e.SortExpression;
			if (_SortMode == GridSortMode.DataTableSort)
			{
				_GridConfig.LastDataTableSource.DefaultView.Sort = e.SortExpression + " " + Interaction.IIf(orderBySortOrder == sqlSelect.OrderBySortOrder.Ascending, (object)"ASC", (object)"DESC").ToString();
				_GridConfig.DataTableSource = _GridConfig.LastDataTableSource.DefaultView.ToTable();
				if ((int)_GridConfig.Carica_Dati(ref rsMess) > 0)
				{
					return;
				}
			}
			else if ((int)_GridConfig.Carica_Dati(ref rsMess) > 0)
			{
				return;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("END grdGriglia_Sorting event");
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	public override FXRETURN Aggiorna(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.Aggiorna(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_GridConfig.DataTableSource != null)
				{
					_GridConfig.DataTableSource.Dispose();
					_GridConfig.DataTableSource = null;
				}
				val2 = _GridConfig.Aggiorna(ref rsMess);
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

	public override FXRETURN AnnullaFiltri(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = _GridConfig.AnnullaFiltri(ref rsMess);
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

	public override FXRETURN AnnullaPrefiltri(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = _GridConfig.AnnullaPrefiltri(ref rsMess);
			if ((int)val2 <= 0)
			{
				if (_GridInfo.Prefiltro & !_GridInfo.PrefiltroImpostato)
				{
					AbstractObjectManager manager = base.SessionEnvironment.ObjManagerFactory.GetManager(_GridInfo.ObjectManagerName);
					string filterPage = manager.FilterPage;
					string text = Strings.Replace(filterPage, "%APPNAME%", "Custom", 1, -1, (CompareMethod)0);
					try
					{
						if (!File.Exists(HttpContext.Current.Server.MapPath(text)))
						{
							text = Strings.Replace(filterPage, "%APPNAME%", base.SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text = Strings.Replace(filterPage, "%APPNAME%", base.SessionEnvironment.WebApplicationName, 1, -1, (CompareMethod)0);
						ProjectData.ClearProjectError();
					}
					filterPage = text;
					filterPage = filterPage + "?Nomrif=" + sNomRif;
					if (Operators.CompareString(manager.FilterPageParameters, "", false) != 0)
					{
						filterPage = filterPage + "&" + manager.FilterPageParameters;
					}
					filterPage = base.BaseFunctions.FindFormDirMember(filterPage);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref filterPage);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	public override FXRETURN Ricerca(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (!base.UserApplicationVariables.ContainsKey("WFI_Allgrd_UserFilter.Exists"))
			{
				bool flag = false;
				DBConnection dbConn = base.DbConn;
				string text = "";
				dbConn.TableOrViewExists("WFI_Allgrd_UserFilter", ref flag, ref text);
				base.UserApplicationVariables.Add("WFI_Allgrd_UserFilter.Exists", flag);
			}
			if (!Conversions.ToBoolean(base.UserApplicationVariables["WFI_Allgrd_UserFilter.Exists"]) | (Operators.CompareString(_FilterVersion, "1", false) == 0))
			{
				val2 = _Ricerca_V1(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00ca;
				}
				val = val2;
			}
			else
			{
				val2 = _Ricerca_V2(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_00ca;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_00ca:
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

	protected virtual FXRETURN _Ricerca_V1(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			txtFiltroDateVal.Visible = false;
			txtFiltroNumericVal.Visible = false;
			txtFiltroStringVal.Visible = false;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Codice", typeof(string));
			dataTable.Columns.Add("Descrizione", typeof(string));
			foreach (DataRow item in _GridInfo.TabGrd)
			{
				if (Operators.CompareString(item["Visibile"].ToString(), "S", false) != 0)
				{
					continue;
				}
				bool flag = true;
				if (item.Table.Columns.Contains("VisibleInFilter"))
				{
					flag = Operators.CompareString(item["VisibleInFilter"].ToString(), "S", false) == 0;
				}
				if (flag)
				{
					if (Operators.CompareString(item["ExtendedDesCam"].ToString(), "", false) != 0)
					{
						dataTable.Rows.Add(item["NomCam"].ToString() + "$" + item["INTERNAL_USE_DATATYPE"].ToString(), TranslateMessage("", item["ExtendedDesCam"].ToString()));
					}
					else
					{
						dataTable.Rows.Add(item["NomCam"].ToString() + "$" + item["INTERNAL_USE_DATATYPE"].ToString(), TranslateMessage("", item["DesCam"].ToString()));
					}
				}
			}
			ddlFiltroCampo.DataTextField = "Descrizione";
			ddlFiltroCampo.DataValueField = "Codice";
			ddlFiltroCampo.DataSource = dataTable;
			ddlFiltroCampo.DataBind();
			string text = _GridInfo.CampoAttivo + "$" + _GridInfo.CampoAttivoTipo;
			if (ddlFiltroCampo.ItemExist(text))
			{
				ddlFiltroCampo.SelectedValue = text;
			}
			else
			{
				try
				{
					((DropDownList)ddlFiltroCampo).SelectedIndex = 0;
					ddlFiltroCampo.ObjValue = ((ListControl)ddlFiltroCampo).SelectedItem.Value;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			string text2 = ddlFiltroCampo.ObjValue.ToString().Split(new char[1] { '$' })[1];
			((ListControl)lstFiltroTot).Items.Clear();
			foreach (KeyValuePair<string, WhereCondition> item2 in _GridInfo.SqlStatement.SqlWhere)
			{
				if (item2.Value.UserVisible)
				{
					ListItem val2 = new ListItem(item2.Value.ReadableExpression, item2.Value.SqlExpression);
					if (!item2.Value.CanBeDeleted)
					{
						val2.Attributes["Disabled"] = "True";
					}
					((ListControl)lstFiltroTot).Items.Add(val2);
				}
			}
			switch (text2)
			{
			case "String":
				txtFiltroStringVal.Text = "";
				txtFiltroStringVal.Visible = true;
				ddlFiltroOperatore.ObjValue = "CONTIENE";
				SetIncasFocusToControl((Control)(object)txtFiltroStringVal);
				break;
			case "Int16":
			case "Int32":
			case "Int64":
				txtFiltroNumericVal.DecimalDigits = 0;
				txtFiltroNumericVal.Text = "";
				txtFiltroNumericVal.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroNumericVal);
				ddlFiltroOperatore.ObjValue = "UGUALE";
				break;
			case "Numeric":
			case "Decimal":
			case "Single":
			case "Double":
				txtFiltroNumericVal.DecimalDigits = 5;
				txtFiltroNumericVal.Text = "";
				txtFiltroNumericVal.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroNumericVal);
				ddlFiltroOperatore.ObjValue = "UGUALE";
				break;
			case "DateTime":
				txtFiltroDateVal.Text = "";
				txtFiltroDateVal.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroDateVal);
				ddlFiltroOperatore.ObjValue = "UGUALE";
				break;
			default:
				rsMess = TranslateMessage("MESSAGE_CODE", "Tipo non riconosciuto:{0}.", _GridInfo.CampoAttivoTipo);
				goto end_IL_0003;
			}
			((Control)pnlFiltro1).Visible = true;
			popFiltro.Show();
			val = (FXRETURN)0;
			end_IL_0003:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	protected virtual FXRETURN _Ricerca_V2(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			txtFiltroDateVal_V2.Visible = false;
			txtFiltroNumericVal_V2.Visible = false;
			txtFiltroStringVal_V2.Visible = false;
			txtFiltroDescrizione_V2.ObjValue = "";
			((ListControl)ddlFiltroSalvato_V2).Items.Clear();
			ListItem val2 = new ListItem();
			val2.Text = TranslateMessage("XXX", "<Nuovo filtro>");
			val2.Value = "0";
			val2.Selected = true;
			((ListControl)ddlFiltroSalvato_V2).Items.Add(val2);
			foreach (DataRow row in _GridInfo.UserFilterTable.Rows)
			{
				val2 = new ListItem();
				val2.Text = row["Descrizione"].ToString();
				val2.Value = row["Id"].ToString();
				val2.Selected = false;
				((ListControl)ddlFiltroSalvato_V2).Items.Add(val2);
			}
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Codice", typeof(string));
			dataTable.Columns.Add("Descrizione", typeof(string));
			foreach (DataRow item in _GridInfo.TabGrd)
			{
				if (Operators.CompareString(item["Visibile"].ToString(), "S", false) != 0)
				{
					continue;
				}
				bool flag = true;
				if (item.Table.Columns.Contains("VisibleInFilter"))
				{
					flag = Operators.CompareString(item["VisibleInFilter"].ToString(), "S", false) == 0;
				}
				if (flag)
				{
					if (Operators.CompareString(item["ExtendedDesCam"].ToString(), "", false) != 0)
					{
						dataTable.Rows.Add(item["NomCam"].ToString() + "$" + item["INTERNAL_USE_DATATYPE"].ToString(), TranslateMessage("", item["ExtendedDesCam"].ToString()));
					}
					else
					{
						dataTable.Rows.Add(item["NomCam"].ToString() + "$" + item["INTERNAL_USE_DATATYPE"].ToString(), TranslateMessage("", item["DesCam"].ToString()));
					}
				}
			}
			ddlFiltroCampo_V2.DataTextField = "Descrizione";
			ddlFiltroCampo_V2.DataValueField = "Codice";
			ddlFiltroCampo_V2.DataSource = dataTable;
			ddlFiltroCampo_V2.DataBind();
			string text = _GridInfo.CampoAttivo + "$" + _GridInfo.CampoAttivoTipo;
			if (ddlFiltroCampo_V2.ItemExist(text))
			{
				ddlFiltroCampo_V2.SelectedValue = text;
			}
			else
			{
				try
				{
					((DropDownList)ddlFiltroCampo_V2).SelectedIndex = 0;
					ddlFiltroCampo_V2.ObjValue = ((ListControl)ddlFiltroCampo_V2).SelectedItem.Value;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			string text2 = ddlFiltroCampo_V2.ObjValue.ToString().Split(new char[1] { '$' })[1];
			((ListControl)lstFiltroTot_V2).Items.Clear();
			foreach (KeyValuePair<string, WhereCondition> item2 in _GridInfo.SqlStatement.SqlWhere)
			{
				if (item2.Value.UserVisible)
				{
					ListItem val3 = new ListItem(item2.Value.ReadableExpression, item2.Value.SqlExpression);
					if (!item2.Value.CanBeDeleted)
					{
						val3.Attributes["Disabled"] = "True";
					}
					((ListControl)lstFiltroTot_V2).Items.Add(val3);
				}
			}
			switch (text2)
			{
			case "String":
				txtFiltroStringVal_V2.Text = "";
				txtFiltroStringVal_V2.Visible = true;
				ddlFiltroOperatore_V2.ObjValue = "CONTIENE";
				SetIncasFocusToControl((Control)(object)txtFiltroStringVal_V2);
				break;
			case "Int16":
			case "Int32":
			case "Int64":
				txtFiltroNumericVal_V2.DecimalDigits = 0;
				txtFiltroNumericVal_V2.Text = "";
				txtFiltroNumericVal_V2.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroNumericVal_V2);
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				break;
			case "Numeric":
			case "Decimal":
			case "Single":
			case "Double":
				txtFiltroNumericVal_V2.DecimalDigits = 5;
				txtFiltroNumericVal_V2.Text = "";
				txtFiltroNumericVal_V2.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroNumericVal_V2);
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				break;
			case "DateTime":
				txtFiltroDateVal_V2.Text = "";
				txtFiltroDateVal_V2.Visible = true;
				SetIncasFocusToControl((Control)(object)txtFiltroDateVal_V2);
				ddlFiltroOperatore_V2.ObjValue = "UGUALE";
				break;
			default:
				rsMess = TranslateMessage("MESSAGE_CODE", "Tipo di dato non riconosciuto:{0}.", _GridInfo.CampoAttivoTipo);
				goto end_IL_0003;
			}
			((Control)pnlFiltro1_V2).Visible = true;
			popFiltro_V2.Show();
			val = (FXRETURN)0;
			end_IL_0003:;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception objEx = ex3;
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

	private FXRETURN CaricaOperatori(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboDropDownList[] array = (IboDropDownList[])(object)new IboDropDownList[2] { ddlFiltroOperatore, ddlFiltroOperatore_V2 };
			foreach (IboDropDownList val2 in array)
			{
				((ListControl)val2).Items.Clear();
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Contiene"), "CONTIENE"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Uguale"), "UGUALE"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Maggiore/Uguale"), "MAGGIOREUGUALE"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Minore/Uguale"), "MINOREUGUALE"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Inizia per"), "INIZIAPER"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Finisce per"), "FINISCEPER"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Non inizia per"), "NONINIZIAPER"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Non finisce per"), "NONFINISCEPER"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Diverso da"), "DIVERSODA"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "E' vuoto"), "VUOTO"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Non è vuoto"), "NONVUOTO"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Contenuto in"), "CONTENUTO_IN"));
				((ListControl)val2).Items.Add(new ListItem(TranslateMessage("Oper", "Non contenuto in"), "NON_CONTENUTO_IN"));
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	private void AutoUpdateImposta(bool? SetAutoUpdate = null)
	{
		try
		{
			if (SetAutoUpdate.HasValue)
			{
				_GridInfo.AutoUpdate = SetAutoUpdate.Value;
			}
			if (_GridInfo.AutoUpdate)
			{
				chkAutoUpdate.Checked = true;
				tmrUpdate.Enabled = true;
				if (Conversions.ToInteger(_GridInfo.AllGrd["TimerUpdate"]) == 0)
				{
					tmrUpdate.Interval = 30000;
				}
				else
				{
					tmrUpdate.Interval = checked(Conversions.ToInteger(_GridInfo.AllGrd["TimerUpdate"]) * 1000);
				}
			}
			else
			{
				tmrUpdate.Enabled = false;
				tmrUpdate.Interval = 60000;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void AutoUpdateImpostaVisibilita()
	{
		try
		{
			if (!_GridInfo.AutoUpdateVisible)
			{
				((WebControl)chkAutoUpdate).Style.Add("visibility", "hidden");
				return;
			}
			((WebControl)chkAutoUpdate).ToolTip = TranslateMessage("XXX", "Aggiornamento automatico ogni {0} secondi", _GridInfo.AllGrd["TimerUpdate"].ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ddlPagerNumberOfPage_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			((GridView)grdGriglia).PageIndex = ((DropDownList)sender).SelectedIndex;
			if ((int)_GridConfig.Carica_Dati(ForceRequery: false, ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	public void ddlPagerMaxRecord_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		FXRETURN val = (FXRETURN)3;
		try
		{
			_GridInfo.TopClauseUI = Conversions.ToInteger(((ListControl)(DropDownList)sender).SelectedValue);
			if ((int)Aggiorna(ref rsMess) <= 0)
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsMess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void ReturnToSelectedRecord()
	{
		try
		{
			if (!_ReturnToSelectedRecord)
			{
				return;
			}
			DataRow[] array = _GridConfig.LastDataTableSource.Select(" 1=1 " + _GridInfo.FunctionArgs.Data.GetFirstElementSqlWhere());
			if (array.Count() > 0)
			{
				FieldInfo field = array[0].GetType().GetField("_rowID", BindingFlags.Instance | BindingFlags.NonPublic);
				int num = Conversions.ToInteger(field.GetValue(array[0]));
				int num2 = num / ((GridView)grdGriglia).PageSize;
				int num3 = num % ((GridView)grdGriglia).PageSize;
				checked
				{
					if (num3 == 0)
					{
						((GridView)grdGriglia).PageIndex = num2 - 1;
						((GridView)grdGriglia).SelectedIndex = ((GridView)grdGriglia).PageSize - 1;
						((GridView)grdGriglia).DataBind();
					}
					else
					{
						((GridView)grdGriglia).PageIndex = num2;
						((GridView)grdGriglia).SelectedIndex = num3 - 1;
						((GridView)grdGriglia).DataBind();
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private FXRETURN FiltroCondizioneAggiungi(IboDropDownList ddlCampo, IboDropDownList ddlOperatore, ListBox lsFiltro, IboWebNumericTlk txtNumero, IboWebTextBox txtStringa, IboWebDate2 txtData, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		checked
		{
			FXRETURN result;
			try
			{
				CallStackAdd();
				rsmess = "";
				string text5 = "";
				string text6 = "";
				text6 = ddlCampo.SelectedValue.Substring(ddlCampo.SelectedValue.LastIndexOf("$") + 1);
				text5 = ddlCampo.SelectedValue.Substring(0, ddlCampo.SelectedValue.LastIndexOf("$"));
				text3 = text5;
				text4 = ((ListControl)ddlCampo).SelectedItem.Text;
				switch (text6)
				{
				case "Int16":
				case "Int32":
				case "Int64":
				case "Single":
				case "Double":
				case "Numeric":
				case "Decimal":
					try
					{
						text = Convert.ToString(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(txtNumero.ObjValue)));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text = "";
						ProjectData.ClearProjectError();
					}
					text2 = "N";
					txtNumero.ObjValue = "";
					break;
				case "DateTime":
					text = txtData.Text;
					text2 = "D";
					txtData.ObjValue = "";
					break;
				default:
					text = txtStringa.Text;
					text2 = "S";
					txtStringa.ObjValue = "";
					break;
				}
				if ((text.Length == 0) & (Operators.CompareString(ddlOperatore.ObjValue.ToString(), "VUOTO", false) != 0) & (Operators.CompareString(ddlOperatore.ObjValue.ToString(), "NONVUOTO", false) != 0))
				{
					rsmess = TranslateMessage("GRDMS", "Occorre specificare un valore per l'operatore selezionato.");
				}
				else
				{
					if (Operators.CompareString(ddlOperatore.ObjValue.ToString(), "", false) == 0)
					{
						ddlOperatore.ObjValue = "UGUALE";
					}
					switch (ddlOperatore.ObjValue.ToString())
					{
					case "MAGGIOREUGUALE":
						text3 += " >= ";
						text4 += " >= <%VALUE%>";
						break;
					case "CONTIENE":
						text3 += " LIKE ";
						text = "%" + text + "%";
						text4 += " CONTIENE <%VALUE%>";
						break;
					case "UGUALE":
						text3 += " = ";
						text4 += " = <%VALUE%>";
						break;
					case "MINOREUGUALE":
						text3 += " <= ";
						text4 += " <= <%VALUE%>";
						break;
					case "INIZIAPER":
						text3 += " LIKE ";
						text4 = text4 + " INIZIA PER '" + text + "'";
						text += "%";
						break;
					case "FINISCEPER":
						text3 += " LIKE ";
						text4 = text4 + " FINISCE PER '" + text + "'";
						text = "%" + text;
						break;
					case "NONINIZIAPER":
						text3 += " NOT LIKE ";
						text4 = text4 + " NON INIZIA PER '" + text + "'";
						text += "%";
						break;
					case "NONFINISCEPER":
						text3 += " NOT LIKE ";
						text4 = text4 + " NON FINISCE PER '" + text + "'";
						text = "%" + text;
						break;
					case "DIVERSODA":
						text3 += " <> ";
						text4 += " <> <%VALUE%>";
						break;
					case "VUOTO":
						text3 += " IS NULL";
						text4 += " E' VUOTO ";
						text = "";
						break;
					case "NONVUOTO":
						text3 += " IS NOT NULL";
						text4 += " NON E' VUOTO";
						text = "";
						break;
					case "CONTENUTO_IN":
					{
						text3 += " IN (";
						text4 += " IN (";
						string[] array3 = text.Split(new char[1] { ',' });
						string[] array4 = array3;
						foreach (string text8 in array4)
						{
							text3 = text3 + "'" + text8.Replace("'", "''") + "',";
							text4 = text4 + "'" + text8.Replace("'", "''") + "',";
						}
						text3 = text3.Substring(0, text3.Length - 1) + ")";
						text4 = text4.Substring(0, text4.Length - 1) + ")";
						text = "";
						break;
					}
					case "NON_CONTENUTO_IN":
					{
						text3 += " NOT IN (";
						text4 += " NON IN (";
						string[] array = text.Split(new char[1] { ',' });
						string[] array2 = array;
						foreach (string text7 in array2)
						{
							text3 = text3 + "'" + text7.Replace("'", "''") + "',";
							text4 = text4 + "'" + text7.Replace("'", "''") + "',";
						}
						text3 = text3.Substring(0, text3.Length - 1) + ")";
						text4 = text4.Substring(0, text4.Length - 1) + ")";
						text = "";
						break;
					}
					}
					if (Operators.CompareString(text, "", false) != 0)
					{
						switch (text2)
						{
						case "D":
							text = base.DbConn.SQLFormatDate((eTipoData)2, text);
							break;
						case "N":
							text = base.DbConn.SQLFormatNumber(ref text);
							break;
						case "S":
							text = base.DbConn.SQLFormatString(text);
							break;
						}
					}
					text3 += text;
					text4 = Strings.Replace(text4, "<%VALUE%>", text, 1, -1, (CompareMethod)0);
					ListItem val3 = new ListItem(text4, text3);
					((ListControl)lsFiltro).Items.Add(val3);
					val = (FXRETURN)0;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception objEx = ex3;
				val = HandleError(ref objEx, ref rsmess);
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

	private FXRETURN SendExportedFile(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FileStream fileStream = null;
		StreamReader streamReader = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((Page)this).Request.Form["__EVENTARGUMENT"] != null && Operators.CompareString(((Control)this).Page.Request.Params.Get("__EVENTARGUMENT").ToUpper(), "SEND_EXPORTED_FILE", false) == 0 && Operators.CompareString(_SessionVariable["FileNameToExport"].ToString(), "", false) != 0)
			{
				_SendExportedFile = true;
				HttpContext.Current.Response.Clear();
				HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
				HttpContext.Current.Response.Buffer = true;
				HttpContext.Current.Response.Cache.SetCacheability((HttpCacheability)1);
				HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + _SessionVariable["FileNameToExport"].ToString() + ".zip");
				HttpContext.Current.Response.WriteFile(_SessionVariable["FileToExportCompletePath"].ToString());
				_SessionVariable["FileNameToExport"] = (object)"";
				_SessionVariable["FileToExportCompletePath"] = (object)"";
				HttpContext.Current.Response.End();
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
			result = val;
			CallStackRemove();
		}
		return result;
	}


	protected override FXRETURN WFIPostbackRun_Elabora(string CommandName, string CommandArgument, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			WFIGridDoPostbackManager wFIGridDoPostbackManager = new WFIGridDoPostbackManager();
			val2 = wFIGridDoPostbackManager.RunEvent(this, CommandName, CommandArgument, ref rsMess);
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

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			bool flag = false;
			if (Operators.CompareString(objRet.ToString(), "ANNULLA", false) != 0)
			{
				switch (Tag)
				{
				case "MODIFICA":
					flag = true;
					break;
				case "INSERIMENTO":
					flag = true;
					break;
				case "DUPLICAZIONE":
					flag = true;
					break;
				case "CANCELLAZIONE":
					flag = true;
					break;
				default:
					if (Operators.CompareString(objRet.ToString(), "CONFERMA", false) == 0)
					{
						flag = true;
					}
					break;
				case "VISUALIZZAZIONE":
					break;
				}
			}
			if (flag)
			{
				string rsMess2 = "";
				Aggiorna(ref rsMess2);
				getParentUpdatePanel((Control)(object)grdGriglia).Update();
				goto IL_011c;
			}
			if ((int)_GridConfig.Carica_Dati(ForceRequery: false, ref rsMess) <= 0)
			{
				goto IL_011c;
			}
			goto end_IL_0005;
			IL_011c:
			val2 = (FXRETURN)0;
			end_IL_0005:;
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
