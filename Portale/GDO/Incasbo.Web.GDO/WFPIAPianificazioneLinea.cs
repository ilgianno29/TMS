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
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFPIAPianificazioneLinea : WFIDBPageMasterDetail
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAggiorna")]
	private IboWebButton _btnAggiorna;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCambiaDataSpedizione")]
	private IboWebButton _btnCambiaDataSpedizione;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoPreviousDate")]
	private IboWebButton _btnGotoPreviousDate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoNextDate")]
	private IboWebButton _btnGotoNextDate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdElencoZone")]
	private IboGridView _grdElencoZone;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdElencoLinee")]
	private IboGridView _grdElencoLinee;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioni")]
	private IboGridView _grdSpedizioni;

	protected string _Filtro;

	protected string _FiltroHR;

	protected DataKeyFieldCollection _LineeSelezionate;

	protected PlanGridFilter _FilterSpedizioni;

	protected PlanGridFilter _FilterSpedizioniRaggru;

	[field: AccessedThroughProperty("pnlMainContainer")]
	protected virtual Panel pnlMainContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlMainBody")]
	protected virtual Panel pnlMainBody
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

	[field: AccessedThroughProperty("Bottoni")]
	protected virtual Panel Bottoni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upButton")]
	protected virtual UpdatePanel upButton
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnAggiorna
	{
		[CompilerGenerated]
		get
		{
			return _btnAggiorna;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnAggiorna_Click;
			IboWebButton val = _btnAggiorna;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnAggiorna = value;
			val = _btnAggiorna;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnCambiaDataSpedizione
	{
		[CompilerGenerated]
		get
		{
			return _btnCambiaDataSpedizione;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCambiaDataSpedizione_Click;
			IboWebButton val = _btnCambiaDataSpedizione;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCambiaDataSpedizione = value;
			val = _btnCambiaDataSpedizione;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblDataSpedizione")]
	protected virtual IboWebLabel lblDataSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Linea_DataPartenzaPianificata")]
	protected virtual IboWebLabel Linea_DataPartenzaPianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGotoPreviousDate
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoPreviousDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoPreviousDate_Click;
			IboWebButton val = _btnGotoPreviousDate;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoPreviousDate = value;
			val = _btnGotoPreviousDate;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnGotoNextDate
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoNextDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoNextDate_Click;
			IboWebButton val = _btnGotoNextDate;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoNextDate = value;
			val = _btnGotoNextDate;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("cpInfoGen_Body")]
	protected virtual Panel cpInfoGen_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlSplitter")]
	protected virtual Panel pnlSplitter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitter1")]
	protected virtual RadSplitter MainBodySplitter1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitterBottom")]
	protected virtual RadPane MainBodySplitterBottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitter3")]
	protected virtual RadSplitter MainBodySplitter3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitterBottom1")]
	protected virtual RadPane MainBodySplitterBottom1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upElencoZone")]
	protected virtual UpdatePanel upElencoZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoZone")]
	protected virtual IboWebPanel cpGrdElencoZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoZone")]
	protected virtual Panel pnlElencoZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdElencoZone
	{
		[CompilerGenerated]
		get
		{
			return _grdElencoZone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdElencoZone_MultiSelectChanged);
			IboGridView val2 = _grdElencoZone;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdElencoZone = value;
			val2 = _grdElencoZone;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("footerGrdElencoZone")]
	protected virtual Panel footerGrdElencoZone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Colli_Caption")]
	protected virtual IboWebLabel footerZone_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Colli_Value")]
	protected virtual IboWebLabel footerZone_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Pallet_Caption")]
	protected virtual IboWebLabel footerZone_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Pallet_Value")]
	protected virtual IboWebLabel footerZone_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Volume_Caption")]
	protected virtual IboWebLabel footerZone_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Volume_Value")]
	protected virtual IboWebLabel footerZone_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Peso_Caption")]
	protected virtual IboWebLabel footerZone_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Peso_Value")]
	protected virtual IboWebLabel footerZone_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Spedizioni_Caption")]
	protected virtual IboWebLabel footerZone_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerZone_Spedizioni_Value")]
	protected virtual IboWebLabel footerZone_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadSplitBar3")]
	protected virtual RadSplitBar RadSplitBar3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitterBottom2")]
	protected virtual RadPane MainBodySplitterBottom2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upElencoLinee")]
	protected virtual UpdatePanel upElencoLinee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoLinee")]
	protected virtual Panel cpGrdElencoLinee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoLinee")]
	protected virtual Panel pnlElencoLinee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdElencoLinee
	{
		[CompilerGenerated]
		get
		{
			return _grdElencoLinee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdElencoLinee_MultiSelectChanged);
			IboGridView val2 = _grdElencoLinee;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdElencoLinee = value;
			val2 = _grdElencoLinee;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("footerElencoLinee")]
	protected virtual Panel footerElencoLinee
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Colli_Caption")]
	protected virtual IboWebLabel footerLinee_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Colli_Value")]
	protected virtual IboWebLabel footerLinee_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Pallet_Caption")]
	protected virtual IboWebLabel footerLinee_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Pallet_Value")]
	protected virtual IboWebLabel footerLinee_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Volume_Caption")]
	protected virtual IboWebLabel footerLinee_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Volume_Value")]
	protected virtual IboWebLabel footerLinee_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Peso_Caption")]
	protected virtual IboWebLabel footerLinee_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Peso_Value")]
	protected virtual IboWebLabel footerLinee_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Spedizioni_Caption")]
	protected virtual IboWebLabel footerLinee_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerLinee_Spedizioni_Value")]
	protected virtual IboWebLabel footerLinee_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitterBar1")]
	protected virtual RadSplitBar MainBodySplitterBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainBodySplitterTop")]
	protected virtual RadPane MainBodySplitterTop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("upElencoSpedizioni")]
	protected virtual UpdatePanel upElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DivGrdElencoSpedizioni")]
	protected virtual Panel DivGrdElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbElencoSpedizioni")]
	protected virtual IboWebToolbar tlbElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gridFilterPanel")]
	protected virtual Panel gridFilterPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFilterActiveField")]
	protected virtual IboWebLabel lblFilterActiveField
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFilterOperator")]
	protected virtual IboDropDownList ddlFilterOperator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterText")]
	protected virtual IboWebTextBox FilterText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterDate")]
	protected virtual IboWebDate2 FilterDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterNumber")]
	protected virtual IboWebNumericTlk FilterNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterOk")]
	protected virtual ImageButton btnFilterOk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterReset")]
	protected virtual ImageButton btnFilterReset
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoSpedizioni")]
	protected virtual Panel cpGrdElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioni")]
	protected virtual Panel pnlElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdSpedizioni
	{
		[CompilerGenerated]
		get
		{
			return _grdSpedizioni;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdElencoSpedizioni_MultiSelectChanged);
			IboGridView val2 = _grdSpedizioni;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdSpedizioni = value;
			val2 = _grdSpedizioni;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("footerElencoSpedizioni")]
	protected virtual Panel footerElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Colli_Caption")]
	protected virtual IboWebLabel footerSpedizioni_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Colli_Value")]
	protected virtual IboWebLabel footerSpedizioni_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Pallet_Caption")]
	protected virtual IboWebLabel footerSpedizioni_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Pallet_Value")]
	protected virtual IboWebLabel footerSpedizioni_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Volume_Caption")]
	protected virtual IboWebLabel footerSpedizioni_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Volume_Value")]
	protected virtual IboWebLabel footerSpedizioni_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Peso_Caption")]
	protected virtual IboWebLabel footerSpedizioni_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Peso_Value")]
	protected virtual IboWebLabel footerSpedizioni_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Spedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioni_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_Spedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioni_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DivGrdElencoSpedizioniRaggru")]
	protected virtual Panel DivGrdElencoSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbElencoSpedizioniRaggru")]
	protected virtual IboWebToolbar tlbElencoSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gridFilterPanelRaggru")]
	protected virtual Panel gridFilterPanelRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFilterActiveFieldRaggru")]
	protected virtual IboWebLabel lblFilterActiveFieldRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFilterOperatorRaggru")]
	protected virtual IboDropDownList ddlFilterOperatorRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterTextRaggru")]
	protected virtual IboWebTextBox FilterTextRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterDateRaggru")]
	protected virtual IboWebDate2 FilterDateRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterNumberRaggru")]
	protected virtual IboWebNumericTlk FilterNumberRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterOkRaggru")]
	protected virtual ImageButton btnFilterOkRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterResetRaggru")]
	protected virtual ImageButton btnFilterResetRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoSpedizioniRaggru")]
	protected virtual Panel cpGrdElencoSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioniRaggru")]
	protected virtual Panel pnlElencoSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdSpedizioniRaggru")]
	protected virtual IboGridView grdSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerElencoSpedizioniRaggru")]
	protected virtual Panel footerElencoSpedizioniRaggru
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Colli_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Colli_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Pallet_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Pallet_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Volume_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Volume_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Peso_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Peso_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Spedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_Spedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCambiaData")]
	protected virtual Panel pnlCambiaData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataSpedizioneCambia")]
	protected virtual IboWebLabel lblDataSpedizioneCambia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataPartenzaCambia")]
	protected virtual IboWebDate2 DataPartenzaCambia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlZonaSpedizione")]
	protected virtual Panel pnlZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblZona")]
	protected virtual IboWebLabel lblZona
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZonaSpedizione")]
	protected virtual IboWebComboTlk ZonaSpedizione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlCorrispondente")]
	protected virtual Panel pnlCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCorrispondente")]
	protected virtual IboWebLabel lblCorrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Corrispondente")]
	protected virtual IboWebComboTlk Corrispondente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlViaggio")]
	protected virtual Panel pnlViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IboWebLabel1")]
	protected virtual IboWebLabel IboWebLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataPartenzaPianificata")]
	protected virtual IboWebDate2 DataPartenzaPianificata
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

	[field: AccessedThroughProperty("Vettore")]
	protected virtual IboWebComboTlk Vettore
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

	[field: AccessedThroughProperty("PCSPartenza")]
	protected virtual IboWebComboTlk PCSPartenza
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

	[field: AccessedThroughProperty("PCSArrivo")]
	protected virtual IboWebComboTlk PCSArrivo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlAssociaViaggio")]
	protected virtual Panel pnlAssociaViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAnnbor")]
	protected virtual IboWebLabel lblAnnbor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AssociaViaggio_IdViaggio")]
	protected virtual IboWebComboTlk AssociaViaggio_IdViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected PlanGridFilter FilterSpedizioni => _FilterSpedizioni;

	protected PlanGridFilter FilterSpedizioniRaggru => _FilterSpedizioniRaggru;

	public WFPIAPianificazioneLinea()
	{
		_Filtro = "";
		_FiltroHR = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		_Context = "PIANIFICAZIONE";
		_Tabella = "";
		_Title = TranslateMessage("XXX", "Visualizza per zona/linea");
		if (_SessionVariable.ContainsKey("FILTRO"))
		{
			_Filtro = _SessionVariable["FILTRO"].ToString();
			if (_SessionVariable.ContainsKey("FILTROHR"))
			{
				_FiltroHR = _SessionVariable["FILTROHR"].ToString();
			}
			else
			{
				_SessionVariable["FILTROHR"] = (object)DateAndTime.Now.ToShortDateString();
				_FiltroHR = _SessionVariable["FILTROHR"].ToString();
			}
		}
		else
		{
			_Filtro = " (" + base.DbConn.DateTrunc("DataPartenzaPianificata") + " = " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ") ";
			_FiltroHR = DateAndTime.Now.ToShortDateString();
			if (!((Page)this).IsPostBack)
			{
				string text = ((Page)this).Request.QueryString["Filter"] ?? "";
				string text2 = ((Page)this).Request.QueryString["Caption"] ?? "";
				_SessionVariable["FILTRO_QUERYSTRING"] = (object)text;
				if (Operators.CompareString(text, "", false) != 0)
				{
					ref string filtro = ref _Filtro;
					filtro = filtro + " AND (" + text + ") ";
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					ref string title = ref _Title;
					title = title + " (" + text2 + ")";
				}
			}
			_SessionVariable["FILTRO"] = (object)_Filtro;
			_SessionVariable["FILTROHR"] = (object)_FiltroHR;
		}
		if (Information.IsDate((object)_FiltroHR))
		{
			_FiltroHR = Strings.Format((object)Conversions.ToDate(_FiltroHR), "dd/MM/yyyy");
			Linea_DataPartenzaPianificata.ObjValue = _FiltroHR;
		}
		if (!((Page)this).IsPostBack)
		{
			string text3 = ((Page)this).Request.QueryString["InitialGrid"] ?? "";
			if (Operators.CompareString(text3, "C", false) == 0)
			{
				((Control)DivGrdElencoSpedizioni).Visible = false;
				((Control)DivGrdElencoSpedizioniRaggru).Visible = true;
			}
			else
			{
				((Control)DivGrdElencoSpedizioni).Visible = true;
				((Control)DivGrdElencoSpedizioniRaggru).Visible = false;
			}
			base.ToolbarMenuVisible = false;
			base.TitleInTopPanel = _Title;
			base.PanelTopHeaderVisible = false;
		}
		((Page)this).Title = base.TitleInTopPanel;
		InitGridFilterSystem();
		InitGridFilterSystemRaggru();
		FXRETURN result = base.InitializedPage(ref rsMess);
		((GridView)grdSpedizioni).Sorting += new GridViewSortEventHandler(grdSpedizioni_Sorting);
		((GridView)grdSpedizioniRaggru).Sorting += new GridViewSortEventHandler(grdSpedizioniRaggru_Sorting);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
			StateBag myViewState = base.MyViewState;
			IboGridView objGridView = grdElencoZone;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdElencoZone = objGridView;
			text = GeneraQueryZone();
			iboInternalGridConfig.Build("DM.PIA.ZONE", text, "", "", ((Control)grdElencoZone).ID, "");
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdElencoLinee;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdElencoLinee = objGridView;
			text = GeneraQueryLinee("");
			iboInternalGridConfig.Build("DM.PIA.LINEA", text, "", "", ((Control)grdElencoLinee).ID, "");
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdSpedizioni;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdSpedizioni = objGridView;
			text = GeneraQuerySpedizioni("");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PIA_LINEA", text, "", "", ((Control)grdSpedizioni).ID, ((Control)tlbElencoSpedizioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdSpedizioniRaggru;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdSpedizioniRaggru = objGridView;
			text = GeneraQuerySpedizioniRaggru("");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PIA_RAGGRU", text, "", "", ((Control)grdSpedizioniRaggru).ID, ((Control)tlbElencoSpedizioniRaggru).ID);
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

	protected override FXRETURN CheckData(ref string rsMess)
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
			val2 = base.CheckData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			grdElencoZone.SelectFirstRow();
			grdElencoZone_MultiSelectChanged(grdElencoZone, new EventArgs());
			grdElencoLinee_MultiSelectChanged(grdElencoLinee, new EventArgs());
			val2 = base.AfterLoadData(ref rsMess);
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

	protected override FXRETURN ContextCheck(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (FXRETURN)0;
	}

	protected override FXRETURN ContextGet(ref string rsMess)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
		DataKeyFieldValues[] array = new DataKeyFieldValues[1];
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.ContextGet(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (!((Page)this).IsPostBack)
				{
					array[0] = new DataKeyFieldValues("Pianificazione", "String");
					dataKeyFieldCollection.Add(array[0]);
					dataKeyFieldCollection.Item(0).FieldValuesAdd("");
					_objFunctionArguments.Keys = array;
					_objFunctionArguments.Data = dataKeyFieldCollection;
					_objFunctionArguments.Name = "MODIFICA";
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN AfterLoadPage(ref string rsMess)
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
			val2 = base.AfterLoadPage(ref rsMess);
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

	protected override void ReturnToCaller()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			rsMess = "";
			IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
			IboWebUserInfo webUserInfo;
			string sUrl = (webUserInfo = base.SessionEnvironment.WebUser.WebUserInfo).PaginaIniziale;
			IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
			webUserInfo.PaginaIniziale = sUrl;
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
		}
	}

	protected override FXRETURN PreRenderPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Unit val3 = checked(base.MasterPage.PanelTopHeaderVisible ? Unit.Pixel(base.SessionEnvironment.WindowHeight - 160) : Unit.Pixel(base.SessionEnvironment.WindowHeight - 85));
			if (!((WebControl)base.MasterPage.PanelMainMaster).CssClass.Contains("PageWithoutMaxHeght"))
			{
				Panel panelMainMaster;
				((WebControl)(panelMainMaster = base.MasterPage.PanelMainMaster)).CssClass = ((WebControl)panelMainMaster).CssClass + " PageWithoutMaxHeght";
			}
			if (((WebControl)pnlSplitter).Height != val3)
			{
				((WebControl)pnlSplitter).Height = val3;
				base.MasterPage.ContentUpdatePanel.Update();
			}
			val = base.PreRenderPage(ref rsMess);
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void grdElencoSpedizioni_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
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
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			val = AggiornaTotaliGriglia(ref rsMess);
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void grdElencoZone_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Invalid comparison between Unknown and I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoZone).ID];
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			checked
			{
				if (robjData.Count > 0)
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						text = ((i >= robjData[0].FieldValuesCount - 1) ? (text + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString())) : (text + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString()) + ","));
					}
				}
				_SessionVariable["FILTROZONE"] = (object)text;
				upElencoLinee.Update();
				val = AggiornaElencoLinee(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			text = "";
			iboInternalGridConfig = GridConfigList[((Control)grdElencoLinee).ID];
			grdGriglia = (iboInternalGridConfig3 = iboInternalGridConfig).GridView;
			objGridInfo = (iboInternalGridConfig2 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig2.GridInfo = objGridInfo;
			iboInternalGridConfig3.GridView = grdGriglia;
			val = keyDataFromGrid2;
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			checked
			{
				if (robjData.Count > 0)
				{
					int num2 = robjData[0].FieldValuesCount - 1;
					for (int j = 0; j <= num2; j++)
					{
						text = text + " (IDVIAGGIOLINEA = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(j).ToString()) + ") ";
						if (j < robjData[0].FieldValuesCount - 1)
						{
							text += " OR ";
						}
					}
					text = "(" + text + ")";
				}
				_SessionVariable["FILTROLINEE"] = (object)text;
				upElencoSpedizioni.Update();
				val = AggiornaElencoSpedizioni(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			val = AggiornaElencoSpedizioniRaggru(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			val = AggiornaTotaliGriglia(ref rsMess);
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void grdElencoLinee_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Invalid comparison between Unknown and I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Invalid comparison between Unknown and I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Invalid comparison between Unknown and I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoLinee).ID];
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			FunctionArguments functionArguments = new FunctionArguments(robjData);
			functionArguments.Keys = robjKey;
			checked
			{
				if (functionArguments.Data.Count > 0)
				{
					int num = functionArguments.Data[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						text = text + "(IDVIAGGIOLINEA = " + base.DbConn.SQLFormatString(functionArguments.Data.Item(0).get_FieldValues(i).ToString()) + ") ";
						if (i < functionArguments.Data[0].FieldValuesCount - 1)
						{
							text += " OR ";
						}
					}
					text = "(" + text + ")";
				}
				_SessionVariable["FILTROLINEE"] = (object)text;
				upElencoSpedizioni.Update();
				val = AggiornaElencoSpedizioni(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			val = AggiornaElencoSpedizioniRaggru(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			val = AggiornaTotaliGriglia(ref rsMess);
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
			if ((int)val2 > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void grdSpedizioni_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			lblFilterActiveField.ObjValue = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			string text2 = "System." + iboInternalGridConfig.GridInfo.CampoAttivoTipo;
			if ((Operators.CompareString(text2, typeof(int).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(long).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(short).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(double).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(float).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(decimal).ToString(), false) == 0))
			{
				ddlFilterOperator.ObjValue = "gt";
				FilterDate.Visible = false;
				FilterText.Visible = false;
				FilterNumber.Visible = true;
			}
			else if ((Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0))
			{
				ddlFilterOperator.ObjValue = "=";
				FilterDate.Visible = true;
				FilterText.Visible = false;
				FilterNumber.Visible = false;
			}
			else
			{
				ddlFilterOperator.ObjValue = "LIKE";
				FilterDate.Visible = false;
				FilterText.Visible = true;
				FilterNumber.Visible = false;
			}
			FilterSpedizioni.SaveContext(iboInternalGridConfig.GridInfo.CampoAttivo, iboInternalGridConfig.GridInfo.CampoAttivoDescrizione, iboInternalGridConfig.GridInfo.CampoAttivoTipo);
			lblFilterActiveField.ObjValue = iboInternalGridConfig.GridInfo.CampoAttivoDescrizione;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	private void grdSpedizioniRaggru_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			lblFilterActiveFieldRaggru.ObjValue = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			string text2 = "System." + iboInternalGridConfig.GridInfo.CampoAttivoTipo;
			if ((Operators.CompareString(text2, typeof(int).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(long).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(short).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(double).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(float).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(decimal).ToString(), false) == 0))
			{
				ddlFilterOperatorRaggru.ObjValue = "gt";
				FilterDateRaggru.Visible = false;
				FilterTextRaggru.Visible = false;
				FilterNumberRaggru.Visible = true;
			}
			else if ((Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0))
			{
				ddlFilterOperatorRaggru.ObjValue = "=";
				FilterDateRaggru.Visible = true;
				FilterTextRaggru.Visible = false;
				FilterNumberRaggru.Visible = false;
			}
			else
			{
				ddlFilterOperatorRaggru.ObjValue = "LIKE";
				FilterDateRaggru.Visible = false;
				FilterTextRaggru.Visible = true;
				FilterNumberRaggru.Visible = false;
			}
			FilterSpedizioniRaggru.SaveContext(iboInternalGridConfig.GridInfo.CampoAttivo, iboInternalGridConfig.GridInfo.CampoAttivoDescrizione, iboInternalGridConfig.GridInfo.CampoAttivoTipo);
			lblFilterActiveFieldRaggru.ObjValue = iboInternalGridConfig.GridInfo.CampoAttivoDescrizione;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	private void btnAggiorna_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			_SessionVariable["FILTROZONE"] = (object)"";
			_SessionVariable["FILTROLINEE"] = (object)"";
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			upElencoZone.Update();
			grdElencoZone_MultiSelectChanged(grdElencoZone, new EventArgs());
			upElencoLinee.Update();
			grdElencoLinee_MultiSelectChanged(grdElencoLinee, new EventArgs());
			upElencoSpedizioni.Update();
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

	private void btnCambiaDataSpedizione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (Information.IsDate((object)_FiltroHR))
			{
				Linea_DataPartenzaPianificata.ObjValue = _FiltroHR;
				DataPartenzaCambia.ObjValue = _FiltroHR;
			}
			MasterPopupFormOpen("Cambia Data Spedizione", (Control)(object)pnlCambiaData, "CAMBIADATA");
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

	private void btnGotoNextDate_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string[] array = Linea_DataPartenzaPianificata.ObjValue.ToString().Split(new char[1] { '/' });
			DateTime data = new DateTime(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0])).AddDays(1.0);
			val2 = CambiaDataPartenza(data, ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	private void btnGotoPreviousDate_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string[] array = Linea_DataPartenzaPianificata.ObjValue.ToString().Split(new char[1] { '/' });
			DateTime data = new DateTime(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0])).AddDays(-1.0);
			val2 = CambiaDataPartenza(data, ref rsMess);
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected override FXRETURN InternalGridVisualizza(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridVisualizza(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridInserisci(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridInserisci(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridModifica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridModifica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCancella(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridDuplica(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridDuplica(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	protected override FXRETURN InternalGridCallFunction(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridCallFunction(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				_RunAfterEvent = false;
				text = e.CommandName.ToString().ToUpper();
				if ((Operators.CompareString(text, "VISUALIZZACONSEGNE", false) == 0) | (Operators.CompareString(text, "VISUALIZZASPEDIZIONI", false) == 0))
				{
					((Control)DivGrdElencoSpedizioni).Visible = !((Control)DivGrdElencoSpedizioni).Visible;
					((Control)DivGrdElencoSpedizioniRaggru).Visible = !((Control)DivGrdElencoSpedizioniRaggru).Visible;
					goto IL_02bb;
				}
				if (funcArg.Data.Count != 0)
				{
					switch (text)
					{
					case "AGGIUNGITRANSITPOINT":
					{
						IboWebComboTlk corrispondente = Corrispondente;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)corrispondente, "", ref rsMess2);
						MasterPopupFormOpen("Aggiungi Transit Point", (Control)(object)pnlCorrispondente, "AGGIUNGITRANSITPOINT");
						break;
					}
					case "ELIMINATRANSITPOINT":
					{
						object objParams = null;
						val2 = EliminaTransitPoint(ref objParams, ref rsMess);
						if ((int)val2 <= 0)
						{
							break;
						}
						val = val2;
						goto end_IL_0012;
					}
					case "CAMBIAZONASPEDIZIONE":
					{
						IboWebComboTlk zonaSpedizione = ZonaSpedizione;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)zonaSpedizione, "", ref rsMess2);
						MasterPopupFormOpen("Cambia Zona Spedizione", (Control)(object)pnlZonaSpedizione, "CAMBIAZONASPEDIZIONE");
						break;
					}
					case "CREAVIAGGIO":
					{
						IboWebComboTlk vettore = Vettore;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)vettore, "", ref rsMess2);
						IboWebComboTlk pCSPartenza = PCSPartenza;
						rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)pCSPartenza, "", ref rsMess2);
						IboWebComboTlk pCSArrivo = PCSArrivo;
						rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)pCSArrivo, "", ref rsMess2);
						DataPartenzaPianificata.DateValue = DateAndTime.Now.Date;
						MasterPopupFormOpen(TranslateMessage("XXX", "Crea Viaggio"), (Control)(object)pnlViaggio, "CREAVIAGGIO");
						break;
					}
					case "ASSOCIAVIAGGIO":
					{
						IboWebComboTlk associaViaggio_IdViaggio = AssociaViaggio_IdViaggio;
						string rsMess2 = "";
						ComboSelectedItem((IIboDropdownList)(object)associaViaggio_IdViaggio, "", ref rsMess2);
						MasterPopupFormOpen(TranslateMessage("XXX", "Associa a Viaggio"), (Control)(object)pnlAssociaViaggio, "ASSOCIAVIAGGIO");
						break;
					}
					}
					goto IL_02bb;
				}
				rsMess = TranslateMessage("XXX", "Selezionare almeno 1 record");
			}
			goto end_IL_0012;
			IL_02bb:
			val = (FXRETURN)0;
			end_IL_0012:;
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

	protected override FXRETURN InternalGridAggiorna(ref IboWebToolbar tlb, ref IboInternalGridConfig objInternalGridConfig, ref FunctionArguments funcArg, ref IboWebToolbarEventArgs e, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.InternalGridAggiorna(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
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

	private FXRETURN AggiornaElencoZone(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdElencoZone).ID];
			text = GeneraQueryZone();
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				grdElencoZone.SelectFirstRow();
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
		}
		return result;
	}

	private FXRETURN AggiornaElencoLinee(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string ssqlFiltroZone = "";
		FXRETURN result;
		try
		{
			if (_SessionVariable.ContainsKey("FILTROZONE"))
			{
				ssqlFiltroZone = _SessionVariable["FILTROZONE"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdElencoLinee).ID];
			objInternalGridConfig.SqlOriginalStatement = GeneraQueryLinee(ssqlFiltroZone);
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				grdElencoLinee.SelectFirstRow();
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
		}
		return result;
	}

	private FXRETURN AggiornaElencoSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroLinee = "";
		FXRETURN result;
		try
		{
			if (_SessionVariable.ContainsKey("FILTROLINEE"))
			{
				ssqlFiltroLinee = _SessionVariable["FILTROLINEE"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			text = GeneraQuerySpedizioni(ssqlFiltroLinee);
			objInternalGridConfig.SqlOriginalStatement = text;
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				grdSpedizioni.SelectAllRows();
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
		}
		return result;
	}

	private FXRETURN AggiornaElencoSpedizioniRaggru(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroLinee = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru BEGIN");
			if (_SessionVariable.ContainsKey("FILTROLINEE"))
			{
				ssqlFiltroLinee = _SessionVariable["FILTROLINEE"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			text = GeneraQuerySpedizioniRaggru(ssqlFiltroLinee);
			objInternalGridConfig.SqlOriginalStatement = text;
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				grdSpedizioniRaggru.SelectAllRows();
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
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru END");
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public void InitGridFilterSystem()
	{
		if (!_SessionVariable.ContainsKey("FILTERSPEDIZIONI"))
		{
			ddlFilterOperator.ObjValue = "LIKE";
			_FilterSpedizioni = new PlanGridFilter(base.DbConn);
			_FilterSpedizioni.Id = ((Control)grdSpedizioni).ID;
			_SessionVariable.Add("FILTERSPEDIZIONI", _FilterSpedizioni);
		}
		else
		{
			_FilterSpedizioni = (PlanGridFilter)_SessionVariable["FILTERSPEDIZIONI"];
		}
		if (!((Page)this).IsPostBack)
		{
			ddlFilterOperator.ObjValue = "LIKE";
			lblFilterActiveField.ObjValue = "Numero Ordine";
			FilterDate.Visible = false;
			FilterText.Visible = true;
			FilterNumber.Visible = false;
			FilterSpedizioni.SaveContext("NumeroOrdine", "Numero Ordine", typeof(string).ToString());
		}
	}

	protected void GridSearch(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (FilterText.Visible)
			{
				if (!ddlFilterOperator.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterText.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioni.AddFilter(ddlFilterOperator.ObjValue.ToString(), FilterText.ObjValue.ToString());
			}
			else if (FilterDate.Visible)
			{
				if (!ddlFilterOperator.ObjValue.ToString().Contains("NULL") && !Information.IsDate(RuntimeHelpers.GetObjectValue(FilterDate.ObjValue)))
				{
					return;
				}
				FilterSpedizioni.AddFilter(ddlFilterOperator.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterDate.ObjValue));
			}
			else if (FilterNumber.Visible)
			{
				if (!ddlFilterOperator.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterNumber.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioni.AddFilter(ddlFilterOperator.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterNumber.ObjValue));
			}
			FilterText.ToolTip = FilterSpedizioni.FilterExpressionHR;
			FilterDate.Tooltip = FilterSpedizioni.FilterExpressionHR;
			FilterNumber.ToolTip = FilterSpedizioni.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioni(ref rsMess);
			if ((int)val <= 0)
			{
				FilterText.Clear();
				FilterDate.Clear();
				FilterNumber.ObjValue = 0;
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
		}
	}

	protected void GridFilterReset(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			FilterSpedizioni.Reset();
			FilterText.ToolTip = FilterSpedizioni.FilterExpressionHR;
			FilterDate.Tooltip = FilterSpedizioni.FilterExpressionHR;
			FilterNumber.ToolTip = FilterSpedizioni.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioni(ref rsMess);
			if ((int)val <= 0)
			{
				FilterText.Clear();
				FilterDate.Clear();
				FilterNumber.ObjValue = 0;
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
		}
	}

	public void InitGridFilterSystemRaggru()
	{
		if (!_SessionVariable.ContainsKey("FILTERSPEDIZIONIRAGGRU"))
		{
			ddlFilterOperatorRaggru.ObjValue = "LIKE";
			_FilterSpedizioniRaggru = new PlanGridFilter(base.DbConn);
			_FilterSpedizioniRaggru.Id = ((Control)grdSpedizioniRaggru).ID;
			_SessionVariable.Add("FILTERSPEDIZIONIRAGGRU", _FilterSpedizioniRaggru);
		}
		else
		{
			_FilterSpedizioniRaggru = (PlanGridFilter)_SessionVariable["FILTERSPEDIZIONIRAGGRU"];
		}
		if (!((Page)this).IsPostBack)
		{
			ddlFilterOperatorRaggru.ObjValue = "LIKE";
			lblFilterActiveFieldRaggru.ObjValue = "Numero Ordine";
			FilterDateRaggru.Visible = false;
			FilterTextRaggru.Visible = true;
			FilterNumberRaggru.Visible = false;
			FilterSpedizioniRaggru.SaveContext("NumeroOrdine", "Numero Ordine", typeof(string).ToString());
		}
	}

	protected void GridSearchRaggru(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (FilterTextRaggru.Visible)
			{
				if (!ddlFilterOperatorRaggru.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterTextRaggru.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioniRaggru.AddFilter(ddlFilterOperatorRaggru.ObjValue.ToString(), FilterTextRaggru.ObjValue.ToString());
			}
			else if (FilterDateRaggru.Visible)
			{
				if (!ddlFilterOperatorRaggru.ObjValue.ToString().Contains("NULL") && !Information.IsDate(RuntimeHelpers.GetObjectValue(FilterDateRaggru.ObjValue)))
				{
					return;
				}
				FilterSpedizioniRaggru.AddFilter(ddlFilterOperatorRaggru.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterDateRaggru.ObjValue));
			}
			else if (FilterNumberRaggru.Visible)
			{
				if (!ddlFilterOperatorRaggru.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterNumberRaggru.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioniRaggru.AddFilter(ddlFilterOperatorRaggru.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterNumberRaggru.ObjValue));
			}
			FilterTextRaggru.ToolTip = FilterSpedizioniRaggru.FilterExpressionHR;
			FilterDateRaggru.Tooltip = FilterSpedizioniRaggru.FilterExpressionHR;
			FilterNumberRaggru.ToolTip = FilterSpedizioniRaggru.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioniRaggru(ref rsMess);
			if ((int)val <= 0)
			{
				FilterTextRaggru.Clear();
				FilterDateRaggru.Clear();
				FilterNumberRaggru.ObjValue = 0;
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
		}
	}

	protected void GridFilterResetRaggru(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			FilterSpedizioniRaggru.Reset();
			FilterTextRaggru.ToolTip = FilterSpedizioniRaggru.FilterExpressionHR;
			FilterDateRaggru.Tooltip = FilterSpedizioniRaggru.FilterExpressionHR;
			FilterNumberRaggru.ToolTip = FilterSpedizioniRaggru.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioniRaggru(ref rsMess);
			if ((int)val <= 0)
			{
				FilterTextRaggru.Clear();
				FilterDateRaggru.Clear();
				FilterNumberRaggru.ObjValue = 0;
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
		}
	}

	public override FXRETURN MasterPopupFormOkClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormOkClick(ref objPopupInfo, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CAMBIAZONASPEDIZIONE", false) == 0)
			{
				val = CambiaZonaSpedizione(ZonaSpedizione.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_01e7;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "AGGIUNGITRANSITPOINT", false) == 0)
			{
				val = AggiungiTransitPoint(Corrispondente.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_01e7;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO", false) == 0)
			{
				val = CreaViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_01e7;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "ASSOCIAVIAGGIO", false) == 0)
			{
				if (Operators.CompareString(AssociaViaggio_IdViaggio.ObjValue.ToString(), "", false) == 0)
				{
					goto IL_01e7;
				}
				val = AssociaAViaggio(AssociaViaggio_IdViaggio.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_01e7;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "CAMBIADATA", false) != 0)
				{
					goto IL_01e7;
				}
				if (Operators.CompareString(DataPartenzaCambia.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire Data Spedizione");
				}
				else
				{
					val = CambiaDataPartenza(DataPartenzaCambia.getDateValue, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_01e7;
					}
					val2 = val;
				}
			}
			goto end_IL_0007;
			IL_01e7:
			val2 = (FXRETURN)0;
			end_IL_0007:;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public override FXRETURN MasterPopupFormAnnullaClick(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		IboInternalGridConfig iboInternalGridConfig = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.MasterPopupFormAnnullaClick(ref objPopupInfo, ref rsMess);
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN AggiungiTransitPoint(string Corrispondente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Invalid comparison between Unknown and I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Invalid comparison between Unknown and I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = null;
			if (((Control)DivGrdElencoSpedizioni).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			}
			else if (((Control)DivGrdElencoSpedizioniRaggru).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			}
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_0215;
				}
				List<string> list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							list.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0)
						{
							string[] array = robjData.Item(0).get_FieldValues(i).ToString()
								.Split(new char[1] { ',' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								list.Add(item);
							}
						}
					}
					val = Spedizione_AggiungiTransitPoint.RunProc(CreateApiContext(), list, Corrispondente, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AggiornaElencoSpedizioni(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = AggiornaElencoSpedizioniRaggru(ref rsMess);
						if ((int)val <= 0)
						{
							upElencoSpedizioni.Update();
							goto IL_0215;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_000e;
			IL_0215:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN EliminaTransitPoint(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Invalid comparison between Unknown and I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Invalid comparison between Unknown and I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Invalid comparison between Unknown and I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Invalid comparison between Unknown and I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Elimina Transit Point");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi l'eliminazione del Transit Point?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "EliminaTransitPoint";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_034d;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_034d;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_034d;
			}
			base.SessionEnvironment.UserMessage.Reset();
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
			IboInternalGridConfig iboInternalGridConfig = null;
			if (((Control)DivGrdElencoSpedizioni).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			}
			else if (((Control)DivGrdElencoSpedizioniRaggru).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			}
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val2 = keyDataFromGrid;
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_034d;
				}
				List<string> list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							list.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0)
						{
							string[] array = robjData.Item(0).get_FieldValues(i).ToString()
								.Split(new char[1] { ',' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								list.Add(item);
							}
						}
					}
					val2 = Spedizione_EliminaTransitPoint.RunProc(CreateApiContext(), list, ref rsMess);
				}
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = AggiornaElencoSpedizioni(ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						val2 = AggiornaElencoSpedizioniRaggru(ref rsMess);
						if ((int)val2 <= 0)
						{
							upElencoSpedizioni.Update();
							goto IL_034d;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0005;
			IL_034d:
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

	private FXRETURN CambiaZonaSpedizione(string ZonaSpedizione, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Invalid comparison between Unknown and I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Invalid comparison between Unknown and I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Invalid comparison between Unknown and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Invalid comparison between Unknown and I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = null;
			if (((Control)DivGrdElencoSpedizioni).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			}
			else if (((Control)DivGrdElencoSpedizioniRaggru).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			}
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_0295;
				}
				List<string> list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							list.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0)
						{
							string[] array = robjData.Item(0).get_FieldValues(i).ToString()
								.Split(new char[1] { ',' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								list.Add(item);
							}
						}
					}
					val = Spedizione_CambiaZonaSpedizione_Invoker.Instance.RunProc(CreateApiContext(), list, ZonaSpedizione, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					_SessionVariable["FILTROZONE"] = (object)"";
					_SessionVariable["FILTROLINEE"] = (object)"";
					val = AggiornaElencoZone(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						upElencoZone.Update();
						val = AggiornaElencoLinee(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoLinee.Update();
							val = AggiornaElencoSpedizioni(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru(ref rsMess);
								if ((int)val <= 0)
								{
									upElencoSpedizioni.Update();
									goto IL_0295;
								}
								val2 = val;
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_0295:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
			if ((int)val2 > 0)
			{
				string rsMess2 = "";
				WFIRollbackTransaction(ref rsMess2);
			}
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN CambiaDataPartenza(DateTime Data, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			_SessionVariable["FILTROZONE"] = (object)"";
			_SessionVariable["FILTROLINEE"] = (object)"";
			_SessionVariable["FILTRO"] = (object)(" (" + base.DbConn.DateTrunc("DATAPARTENZAPIANIFICATA") + "=" + base.DbConn.SQLFormatDate((eTipoData)1, Data) + ") ");
			_Filtro = _SessionVariable["FILTRO"].ToString();
			_SessionVariable["FILTROHR"] = (object)Data.ToShortDateString();
			_FiltroHR = _SessionVariable["FILTROHR"].ToString();
			if (Operators.CompareString(_SessionVariable["FILTRO_QUERYSTRING"].ToString(), "", false) != 0)
			{
				ref string filtro = ref _Filtro;
				filtro = filtro + " AND (" + _SessionVariable["FILTRO_QUERYSTRING"].ToString() + ")";
			}
			if (Information.IsDate((object)_FiltroHR))
			{
				Linea_DataPartenzaPianificata.ObjValue = _FiltroHR;
			}
			upButton.Update();
			val = AggiornaElencoZone(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				upElencoZone.Update();
				grdElencoZone_MultiSelectChanged(grdElencoZone, new EventArgs());
				grdElencoLinee_MultiSelectChanged(grdElencoLinee, new EventArgs());
				upElencoLinee.Update();
				upElencoSpedizioni.Update();
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
			if ((int)val2 > 0)
			{
				string rsMess2 = "";
				WFIRollbackTransaction(ref rsMess2);
			}
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN CreaViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Invalid comparison between Unknown and I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between Unknown and I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Invalid comparison between Unknown and I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Invalid comparison between Unknown and I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Invalid comparison between Unknown and I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = null;
			if (((Control)DivGrdElencoSpedizioni).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			}
			else if (((Control)DivGrdElencoSpedizioniRaggru).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			}
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_037a;
				}
				List<string> ListOfUnibol = new List<string>();
				Viaggio Viaggio;
				object obj;
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							ListOfUnibol.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0)
						{
							string[] array = robjData.Item(0).get_FieldValues(i).ToString()
								.Split(new char[1] { ',' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								ListOfUnibol.Add(item);
							}
						}
					}
					Viaggio = new Viaggio();
					Viaggio viaggio = Viaggio;
					viaggio.DataPartenzaPianificata = DataPartenzaPianificata.getDateValue;
					viaggio.Vettore = Vettore.ObjValue.ToString();
					viaggio.PCSPartenza = PCSPartenza.ObjValue.ToString();
					viaggio.PCSArrivo = PCSArrivo.ObjValue.ToString();
					viaggio = null;
					obj = null;
					string text = "SELECT IdViaggioLinea FROM Spedizioni WHERE Unibol=" + base.DbConn.SQLFormatString(ListOfUnibol[0]);
					val = base.DbConn.DoSql(text, ref obj, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref ListOfUnibol, obj.ToString(), ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						_SessionVariable["FILTROZONE"] = (object)"";
						_SessionVariable["FILTROLINEE"] = (object)"";
						val = AggiornaElencoZone(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoZone.Update();
							val = AggiornaElencoLinee(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								upElencoLinee.Update();
								val = AggiornaElencoSpedizioni(ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = AggiornaElencoSpedizioniRaggru(ref rsMess);
									if ((int)val <= 0)
									{
										upElencoSpedizioni.Update();
										WriteInfoMessage(TranslateMessage("XXX", "Generato il viaggio {0}", Viaggio.IdViaggio), ShowAsNotification: true);
										goto IL_037a;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_037a:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN CreaViaggio2(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Invalid comparison between Unknown and I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
			{
				base.SessionEnvironment.UserMessage.Reset();
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Creazione Viaggio");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Creare il Viaggio e associarvi le spedizioni selezionate?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "CreaViaggio";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_02dd;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_02dd;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_02dd;
			}
			base.SessionEnvironment.UserMessage.Reset();
			List<string> list = new List<string>();
			IboInternalGridConfig iboInternalGridConfig = GridConfigList.get_GetItemByToolbarId(((Control)tlbElencoSpedizioni).ID);
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
			Viaggio Viaggio = new Viaggio();
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val2 = keyDataFromGrid;
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_02dd;
				}
				list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						list.Add(robjData.Item(0).get_FieldValues(i).ToString());
					}
					val2 = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref list, ref rsMess);
				}
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					iboInternalGridConfig = GridConfigList[((Control)grdElencoZone).ID];
					InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
					upElencoZone.Update();
					AggiornaElencoLinee(ref rsMess);
					upElencoLinee.Update();
					AggiornaElencoSpedizioni(ref rsMess);
					val2 = AggiornaElencoSpedizioniRaggru(ref rsMess);
					if ((int)val2 <= 0)
					{
						upElencoSpedizioni.Update();
						WriteInfoMessage(TranslateMessage("XXX", "Generato il viaggio {0}", Viaggio.IdViaggio));
						goto IL_02dd;
					}
					val = val2;
				}
			}
			goto end_IL_0005;
			IL_02dd:
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

	private FXRETURN AssociaAViaggio(string IdViaggio, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Invalid comparison between Unknown and I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Invalid comparison between Unknown and I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between Unknown and I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Invalid comparison between Unknown and I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = null;
			if (((Control)DivGrdElencoSpedizioni).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			}
			else if (((Control)DivGrdElencoSpedizioniRaggru).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			}
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_02d7;
				}
				List<string> list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							list.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0)
						{
							string[] array = robjData.Item(0).get_FieldValues(i).ToString()
								.Split(new char[1] { ',' });
							string[] array2 = array;
							foreach (string item in array2)
							{
								list.Add(item);
							}
						}
					}
					val = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, IdViaggio, null, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					_SessionVariable["FILTROZONE"] = (object)"";
					_SessionVariable["FILTROLINEE"] = (object)"";
					val = AggiornaElencoZone(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						upElencoZone.Update();
						val = AggiornaElencoLinee(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoLinee.Update();
							val = AggiornaElencoSpedizioni(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru(ref rsMess);
								if ((int)val <= 0)
								{
									upElencoSpedizioni.Update();
									WriteInfoMessage(TranslateMessage("XXX", "{0} spedizioni associate al viaggio '{1}'", list.Count.ToString(), IdViaggio), ShowAsNotification: true);
									goto IL_02d7;
								}
								val2 = val;
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_02d7:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private string GeneraQueryZone()
	{
		string text = "";
		text = "SELECT T.ZonaSpedizione, Z.Descrizione As ZonaSpedizioneDescrizione,";
		text += "SUM(T.COLLI) AS Colli,";
		text += "SUM(T.PALLET) AS Pallet,";
		text += "SUM(T.VOLUME) AS Volume,";
		text += "SUM(T.PESO) AS Peso,";
		text += "SUM(T.CAMPOCALCOLO1) AS CampoCalcolo1,";
		text += "SUM(T.CAMPOCALCOLO2) AS CampoCalcolo2,";
		text += "SUM(T.CAMPOCALCOLO3) AS CampoCalcolo3,";
		text += "SUM(T.CAMPOCALCOLO4) AS CampoCalcolo4,";
		text += "SUM(T.CAMPOCALCOLO5) AS CampoCalcolo5,";
		text += "SUM(T.CAMPOCALCOLO6) AS CampoCalcolo6,";
		text += "SUM(T.CAMPOCALCOLO7) AS CampoCalcolo7,";
		text += "SUM(T.CAMPOCALCOLO7) AS CampoCalcolo8,";
		text += "SUM(T.CAMPOCALCOLO9) AS CampoCalcolo9,";
		text += "SUM(T.CAMPOCALCOLO10) AS CampoCalcolo10,";
		text += "COUNT(*) AS TotaleSpedizioni ";
		text += "FROM (";
		text += "SELECT S.* ";
		text += "FROM SPEDIZIONI S ";
		text += "WHERE STATO = 20 AND IDVIAGGIO IS NULL ";
		text += "AND IDVIAGGIOLINEA IS NOT NULL ";
		text += "AND IDVIAGGIOLINEA IN (";
		text += "SELECT V.Id ";
		text += "FROM VIAGGI_LINEA V ";
		text += "WHERE V.STATO < 30 ";
		if (Operators.CompareString(_Filtro, "", false) != 0)
		{
			text = text + "AND " + _Filtro + " ";
		}
		text += ")";
		text += ") T ";
		text += "INNER JOIN VIAGGI_LINEA V ON V.ID = T.IDVIAGGIOLINEA ";
		text += "INNER JOIN ZONE Z ON Z.CODICE = T.ZONASPEDIZIONE ";
		text += "WHERE V.STATO < 30 ";
		return text + "GROUP BY T.ZONASPEDIZIONE,Z.Descrizione ";
	}

	private string GeneraQueryLinee(string ssqlFiltroZone)
	{
		string text = "";
		text = "SELECT V.*, Z.Descrizione As ZonaSpedizioneDescrizione, ";
		text += "(SELECT SUM(COLLI) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) Colli, ";
		text += "(SELECT SUM(Pallet) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) Pallet, ";
		text += "(SELECT SUM(VOLUME) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) VOLUME, ";
		text += "(SELECT SUM(Peso) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) Peso, ";
		text += "(SELECT SUM(CampoCalcolo1) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo1, ";
		text += "(SELECT SUM(CampoCalcolo2) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo2, ";
		text += "(SELECT SUM(CampoCalcolo3) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo3, ";
		text += "(SELECT SUM(CampoCalcolo4) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo4, ";
		text += "(SELECT SUM(CampoCalcolo5) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo5, ";
		text += "(SELECT SUM(CampoCalcolo6) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo6, ";
		text += "(SELECT SUM(CampoCalcolo7) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo7, ";
		text += "(SELECT SUM(CampoCalcolo8) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo8, ";
		text += "(SELECT SUM(CampoCalcolo9) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo9, ";
		text += "(SELECT SUM(CampoCalcolo10) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) CampoCalcolo10, ";
		text += "(SELECT COUNT(*) FROM Spedizioni S WHERE S.IdViaggioLinea=V.Id AND IdViaggio IS NULL) TotaleSpedizioni ";
		text += "FROM VIAGGI_LINEA V INNER JOIN ZONE Z ON Z.CODICE = V.ZONASPEDIZIONE ";
		text += "WHERE V.STATO < 30 ";
		if (Operators.CompareString(_Filtro, "", false) != 0)
		{
			text = text + "AND " + _Filtro + " ";
		}
		if (Operators.CompareString(ssqlFiltroZone, "", false) != 0)
		{
			return text + "AND V.ZONASPEDIZIONE IN (" + ssqlFiltroZone + ") ";
		}
		return text + "AND 1=2 ";
	}

	private string GeneraQuerySpedizioni(string ssqlFiltroLinee)
	{
		string text = "";
		text = "SELECT * FROM GRD_PIA_SPEDIZIONI_LINEE WHERE ";
		if (Operators.CompareString(ssqlFiltroLinee, "", false) != 0)
		{
			text = text + ssqlFiltroLinee + " ";
			if (!Information.IsNothing((object)FilterSpedizioni) && Operators.CompareString(FilterSpedizioni.FilterExpression, "", false) != 0)
			{
				text = text + " AND (" + FilterSpedizioni.FilterExpression + ")";
			}
		}
		else
		{
			text += "1=2";
		}
		return text;
	}

	private string GeneraQuerySpedizioniRaggru(string ssqlFiltroLinee)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru BEGIN");
		text = "SELECT T.*";
		text += ", CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
		text += "SELECT 'D' Tipo,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "1 Numero_Scarichi,";
		if ((int)base.DbConn.ServerType == 0)
		{
			text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
			text += "FROM VW_PIA_SPEDIZIONI_LINEE TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NULL AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
			text += "FOR XML PATH('')),1,1,'') AS ListaUnibol, ";
		}
		else if ((int)base.DbConn.ServerType == 1)
		{
			text += "CAST(wm_concat (DISTINCT S.Unibol) AS VARCHAR2(4000)) AS ListaUnibol, ";
		}
		text += "NULL AS ListaDestinazioni, ";
		text += "S.PCSDESTINAZIONE PCSDESTINAZIONE,";
		text += "MAX(S.PCSDESTINAZIONE_RAGSOC) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(S.PCSDESTINAZIONE_INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(S.PCSDESTINAZIONE_CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(S.PCSDESTINAZIONE_LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(S.PCSDESTINAZIONE_PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(S.PCSDESTINAZIONE_NAZIONE) PCSDESTINAZIONE_NAZIONE,";
		text += "SUM(S.PESO) PESO,";
		text += "SUM(S.COLLI) COLLI,";
		text += "SUM(S.PALLET) PALLET,";
		text += "SUM(S.VOLUME) VOLUME,";
		text += "SUM(S.CAMPOCALCOLO1) CAMPOCALCOLO1,";
		text += "SUM(S.CAMPOCALCOLO2) CAMPOCALCOLO2,";
		text += "SUM(S.CAMPOCALCOLO3) CAMPOCALCOLO3,";
		text += "SUM(S.CAMPOCALCOLO4) CAMPOCALCOLO4,";
		text += "SUM(S.CAMPOCALCOLO5) CAMPOCALCOLO5,";
		text += "SUM(S.CAMPOCALCOLO6) CAMPOCALCOLO6,";
		text += "SUM(S.CAMPOCALCOLO7) CAMPOCALCOLO7,";
		text += "SUM(S.CAMPOCALCOLO8) CAMPOCALCOLO8,";
		text += "SUM(S.CAMPOCALCOLO9) CAMPOCALCOLO9,";
		text += "SUM(S.CAMPOCALCOLO10) CAMPOCALCOLO10,";
		text += "SUM(S.CONTRASSEGNO) CONTRASSEGNO ";
		text += "FROM VW_PIA_SPEDIZIONI_LINEE S ";
		text += "WHERE <%FILTRO%> ";
		text += "AND S.CORRISPONDENTE IS NULL ";
		text += "GROUP BY S.PCSDESTINAZIONE ";
		text += " UNION ";
		text += "SELECT 'C' Tipo,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "COUNT(DISTINCT(S.PCSDESTINAZIONE)) Numero_Scarichi,";
		if ((int)base.DbConn.ServerType == 0)
		{
			text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
			text += "FROM VW_PIA_SPEDIZIONI_LINEE TEMP ";
			text += "WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE ";
			text += "FOR XML PATH('') ),1,1,'') AS ListaUnibol, ";
			text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' + ";
			text += "REPLACE(REPLACE((SELECT '%lt%tr%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_ragsoc) + ' %lt%/td%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_localita) + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') + ' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Colli) AS VARCHAR) + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Pallet) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Volume) AS VARCHAR) + '%lt%/td%gt%%lt%/tr%gt%' ";
			text += "FROM VW_PIA_SPEDIZIONI_LINEE TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione ";
			text += "FOR XML PATH('') ), '%gt%', '>'), '%lt%', '<') ";
			text += "+ '</table>' AS ListaDestinazioni, ";
		}
		else if ((int)base.DbConn.ServerType == 1)
		{
			text += "CAST(wm_concat (DISTINCT S.Unibol) AS VARCHAR2(4000)) AS ListaUnibol, ";
			text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' || ";
			text += "REPLACE(REPLACE((REPLACE(REPLACE((SELECT wm_concat('%%%'|| '%lt%tr%gt%%lt%td%gt%' || MAX(TEMP.pcsdestinazione_ragsoc) || ' %lt%/td%gt%%lt%td%gt%' || MAX(TEMP.pcsdestinazione_localita) || ";
			text += "' %lt%/td%gt%%lt%td%gt%' || ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') || ' %lt%/td%gt%%lt%td%gt%' || ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') || ";
			text += "' %lt%/td%gt%%lt%td%gt%' || CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR2(4000)) || ' %lt%/td%gt%%lt%td%gt%' || CAST(SUM(TEMP.Colli) AS VARCHAR2(4000)) || ";
			text += "' %lt%/td%gt%%lt%td%gt%' || CAST(SUM(TEMP.Pallet) AS VARCHAR2(4000)) || ' %lt%/td%gt%%lt%td%gt%' || CAST(SUM(TEMP.Volume) AS VARCHAR2(4000)) || '%lt%/td%gt%%lt%/tr%gt%') ";
			text += "FROM VW_PIA_SPEDIZIONI_LINEE TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione), ',%%%', ' '), '%%%', '')), '%gt%', '>'), '%lt%', '<') || '</table>' AS ListaDestinazioni, ";
		}
		text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
		text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,        ";
		text += "SUM(S.PESO) PESO,";
		text += "SUM(S.COLLI) COLLI,";
		text += "SUM(S.PALLET) PALLET,";
		text += "SUM(S.VOLUME) VOLUME,";
		text += "SUM(S.CAMPOCALCOLO1) CAMPOCALCOLO1,";
		text += "SUM(S.CAMPOCALCOLO2) CAMPOCALCOLO2,";
		text += "SUM(S.CAMPOCALCOLO3) CAMPOCALCOLO3,";
		text += "SUM(S.CAMPOCALCOLO4) CAMPOCALCOLO4,";
		text += "SUM(S.CAMPOCALCOLO5) CAMPOCALCOLO5,";
		text += "SUM(S.CAMPOCALCOLO6) CAMPOCALCOLO6,";
		text += "SUM(S.CAMPOCALCOLO7) CAMPOCALCOLO7,";
		text += "SUM(S.CAMPOCALCOLO8) CAMPOCALCOLO8,";
		text += "SUM(S.CAMPOCALCOLO9) CAMPOCALCOLO9,";
		text += "SUM(S.CAMPOCALCOLO10) CAMPOCALCOLO10,";
		text += "SUM(S.CONTRASSEGNO) CONTRASSEGNO ";
		text += "FROM VW_PIA_SPEDIZIONI_LINEE S ";
		text += "LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
		text += "WHERE <%FILTRO%> ";
		text += "AND S.CORRISPONDENTE IS NOT NULL ";
		text += "GROUP BY S.CORRISPONDENTE ) T";
		if (Operators.CompareString(ssqlFiltroLinee, "", false) != 0)
		{
			text2 = text2 + ssqlFiltroLinee + " ";
			if (!Information.IsNothing((object)FilterSpedizioniRaggru) && Operators.CompareString(FilterSpedizioniRaggru.FilterExpression, "", false) != 0)
			{
				text2 = text2 + " AND (" + FilterSpedizioniRaggru.FilterExpression + ")";
			}
		}
		else
		{
			text2 += "1=2";
		}
		string result = text.Replace("<%FILTRO%>", text2);
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru END");
		return result;
	}

	private FXRETURN AggiornaTotaliGriglia(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Invalid comparison between Unknown and I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Invalid comparison between Unknown and I4
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Invalid comparison between Unknown and I4
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoZone).ID];
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val = keyDataFromGrid;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				checked
				{
					if (robjData.Count > 0)
					{
						text = "ZonaSpedizione IN (";
						int num = robjData[0].FieldValuesCount - 1;
						for (int i = 0; i <= num; i++)
						{
							text = ((i >= robjData[0].FieldValuesCount - 1) ? (text + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString())) : (text + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString()) + ","));
						}
						text += ")";
					}
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = "1=2";
					}
					DataRow[] array = iboInternalGridConfig.DataTable.Select(text);
					decimal num2 = default(decimal);
					decimal num3 = default(decimal);
					decimal num4 = default(decimal);
					decimal num5 = default(decimal);
					decimal num6 = default(decimal);
					decimal num7 = default(decimal);
					DataRow[] array2 = array;
					foreach (DataRow dataRow in array2)
					{
						num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow["Peso"]));
						num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow["Volume"]));
						num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow["Colli"]));
						num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow["Pallet"]));
						num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow["TotaleSpedizioni"]));
					}
					footerZone_Colli_Value.ObjValue = Convert.ToInt32(num4);
					footerZone_Pallet_Value.ObjValue = Convert.ToInt32(num5);
					footerZone_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
					footerZone_Volume_Value.ObjValue = Strings.Format((object)num3, "0.00000");
					footerZone_Spedizioni_Value.ObjValue = Convert.ToInt32(num6);
					text = "";
					iboInternalGridConfig = GridConfigList[((Control)grdElencoLinee).ID];
					grdGriglia = (iboInternalGridConfig3 = iboInternalGridConfig).GridView;
					objGridInfo = (iboInternalGridConfig2 = iboInternalGridConfig).GridInfo;
					FXRETURN keyDataFromGrid2 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
					iboInternalGridConfig2.GridInfo = objGridInfo;
					iboInternalGridConfig3.GridView = grdGriglia;
					val = keyDataFromGrid2;
					if (unchecked((int)val) > 0)
					{
						val2 = val;
					}
					else
					{
						if (robjData.Count > 0)
						{
							int num8 = robjData[0].FieldValuesCount - 1;
							for (int k = 0; k <= num8; k++)
							{
								text = text + " " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(k).ToString());
								if (k < robjData[0].FieldValuesCount - 1)
								{
									text += ",";
								}
							}
							text = "ID IN (" + text + ")";
						}
						if (Operators.CompareString(text, "", false) == 0)
						{
							text = "1=2";
						}
						array = iboInternalGridConfig.DataTable.Select(text);
						num2 = default(decimal);
						num3 = default(decimal);
						num4 = default(decimal);
						num5 = default(decimal);
						num6 = default(decimal);
						num7 = default(decimal);
						DataRow[] array3 = array;
						foreach (DataRow dataRow2 in array3)
						{
							num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow2["Peso"]));
							num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow2["Volume"]));
							num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow2["Colli"]));
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Pallet"])))
							{
								num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow2["Pallet"]));
							}
							num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow2["TotaleSpedizioni"]));
						}
						footerLinee_Colli_Value.ObjValue = Convert.ToInt32(num4);
						footerLinee_Pallet_Value.ObjValue = Convert.ToInt32(num5);
						footerLinee_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
						footerLinee_Volume_Value.ObjValue = Strings.Format((object)num3, "0.00000");
						footerLinee_Spedizioni_Value.ObjValue = Convert.ToInt32(num6);
						text = "";
						iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
						grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
						objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
						FXRETURN keyDataFromGrid3 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
						iboInternalGridConfig3.GridInfo = objGridInfo;
						iboInternalGridConfig2.GridView = grdGriglia;
						val = keyDataFromGrid3;
						if (unchecked((int)val) > 0)
						{
							val2 = val;
						}
						else
						{
							if (robjData.Count > 0)
							{
								int num9 = robjData[0].FieldValuesCount - 1;
								for (int m = 0; m <= num9; m++)
								{
									text = text + " " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(m).ToString());
									if (m < robjData[0].FieldValuesCount - 1)
									{
										text += ",";
									}
								}
								text = " UNIBOL IN (" + text + ")";
							}
							if (Operators.CompareString(text, "", false) == 0)
							{
								text = "1=2";
							}
							array = iboInternalGridConfig.DataTable.Select(text);
							num2 = default(decimal);
							num3 = default(decimal);
							num4 = default(decimal);
							num5 = default(decimal);
							num6 = default(decimal);
							DataRow[] array4 = array;
							foreach (DataRow dataRow3 in array4)
							{
								num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow3["Peso"]));
								num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow3["Volume"]));
								num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow3["Colli"]));
								num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow3["Pallet"]));
								num6 = decimal.Add(num6, 1m);
							}
							footerSpedizioni_Colli_Value.ObjValue = Convert.ToInt32(num4);
							footerSpedizioni_Pallet_Value.ObjValue = Convert.ToInt32(num5);
							footerSpedizioni_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
							footerSpedizioni_Volume_Value.ObjValue = Strings.Format((object)num3, "0.00000");
							footerSpedizioni_Spedizioni_Value.ObjValue = Convert.ToInt32(num6);
							text = "";
							iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
							grdGriglia = (iboInternalGridConfig3 = iboInternalGridConfig).GridView;
							objGridInfo = (iboInternalGridConfig2 = iboInternalGridConfig).GridInfo;
							FXRETURN keyDataFromGrid4 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
							iboInternalGridConfig2.GridInfo = objGridInfo;
							iboInternalGridConfig3.GridView = grdGriglia;
							val = keyDataFromGrid4;
							if (unchecked((int)val) > 0)
							{
								val2 = val;
							}
							else
							{
								if (robjData.Count > 0)
								{
									int num10 = robjData[0].FieldValuesCount - 1;
									for (int num11 = 0; num11 <= num10; num11++)
									{
										text = text + " " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num11).ToString());
										if (num11 < robjData[0].FieldValuesCount - 1)
										{
											text += ",";
										}
									}
									text = "LISTAUNIBOL IN (" + text + ")";
								}
								if (Operators.CompareString(text, "", false) == 0)
								{
									text = "1=2";
								}
								array = iboInternalGridConfig.DataTable.Select(text);
								num2 = default(decimal);
								num3 = default(decimal);
								num4 = default(decimal);
								num5 = default(decimal);
								num6 = default(decimal);
								DataRow[] array5 = array;
								foreach (DataRow dataRow4 in array5)
								{
									num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow4["Peso"]));
									num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow4["Volume"]));
									num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow4["Colli"]));
									num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow4["Pallet"]));
									num6 = decimal.Add(num6, new decimal(Conversions.ToInteger(dataRow4["Numero_Spedizioni"])));
								}
								footerSpedizioniRaggru_Colli_Value.ObjValue = Convert.ToInt32(num4);
								footerSpedizioniRaggru_Pallet_Value.ObjValue = Convert.ToInt32(num5);
								footerSpedizioniRaggru_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
								footerSpedizioniRaggru_Volume_Value.ObjValue = Strings.Format((object)num3, "0.00000");
								footerSpedizioniRaggru_Spedizioni_Value.ObjValue = Convert.ToInt32(num6);
								val2 = (FXRETURN)0;
							}
						}
					}
				}
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}
}
