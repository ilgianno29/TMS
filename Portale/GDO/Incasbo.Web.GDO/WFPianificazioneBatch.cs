using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.WMS;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFPianificazioneBatch : WFIDBPageMasterDetail
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
	[AccessedThroughProperty("btnCalcolaPalletSagome")]
	private IboWebButton _btnCalcolaPalletSagome;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnModificaDataBatch")]
	private IboWebButton _btnModificaDataBatch;

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
	[AccessedThroughProperty("grdElencoBatch")]
	private IboGridView _grdElencoBatch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioni")]
	private IboGridView _grdSpedizioni;

	protected string _Filtro;

	protected string _FiltroHR;

	protected DataKeyFieldCollection _BatchSelezionati;

	protected PlanGridFilter _FilterSpedizioni;

	protected PlanGridFilter _FilterSpedizioniRaggru;

	protected PlanGridFilter _FilterSpedizioniRaggru2;

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

	protected virtual IboWebButton btnCalcolaPalletSagome
	{
		[CompilerGenerated]
		get
		{
			return _btnCalcolaPalletSagome;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCalcolaPalletSagome_Click;
			IboWebButton val = _btnCalcolaPalletSagome;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnCalcolaPalletSagome = value;
			val = _btnCalcolaPalletSagome;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnModificaDataBatch
	{
		[CompilerGenerated]
		get
		{
			return _btnModificaDataBatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnModificaDataBatch_Click;
			IboWebButton val = _btnModificaDataBatch;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnModificaDataBatch = value;
			val = _btnModificaDataBatch;
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

	[field: AccessedThroughProperty("DataSpedizione")]
	protected virtual IboWebLabel DataSpedizione
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

	[field: AccessedThroughProperty("upElencoBatch")]
	protected virtual UpdatePanel upElencoBatch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoBatch")]
	protected virtual Panel cpGrdElencoBatch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoBatch")]
	protected virtual Panel pnlElencoBatch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdElencoBatch
	{
		[CompilerGenerated]
		get
		{
			return _grdElencoBatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdElencoBatch_MultiSelectChanged);
			IboGridView val2 = _grdElencoBatch;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdElencoBatch = value;
			val2 = _grdElencoBatch;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("footerElencoBatch")]
	protected virtual Panel footerElencoBatch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Spedizioni_Caption")]
	protected virtual IboWebLabel footerBatch_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Spedizioni_Value")]
	protected virtual IboWebLabel footerBatch_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Colli_Caption")]
	protected virtual IboWebLabel footerBatch_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Colli_Value")]
	protected virtual IboWebLabel footerBatch_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Peso_Caption")]
	protected virtual IboWebLabel footerBatch_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_Peso_Value")]
	protected virtual IboWebLabel footerBatch_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_PalletTeo_Caption")]
	protected virtual IboWebLabel footerBatch_PalletTeo_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_PalletTeo_Value")]
	protected virtual IboWebLabel footerBatch_PalletTeo_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_PalletEff_Caption")]
	protected virtual IboWebLabel footerBatch_PalletEff_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_PalletEff_Value")]
	protected virtual IboWebLabel footerBatch_PalletEff_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_VolumeTeo_Caption")]
	protected virtual IboWebLabel footerBatch_VolumeTeo_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_VolumeTeo_Value")]
	protected virtual IboWebLabel footerBatch_VolumeTeo_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_VolumeEff_Caption")]
	protected virtual IboWebLabel footerBatch_VolumeEff_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_VolumeEff_Value")]
	protected virtual IboWebLabel footerBatch_VolumeEff_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_SagomeTeo_Caption")]
	protected virtual IboWebLabel footerBatch_SagomeTeo_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_SagomeTeo_Value")]
	protected virtual IboWebLabel footerBatch_SagomeTeo_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_SagomeEff_Caption")]
	protected virtual IboWebLabel footerBatch_SagomeEff_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerBatch_SagomeEff_Value")]
	protected virtual IboWebLabel footerBatch_SagomeEff_Value
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

	[field: AccessedThroughProperty("DivGrdElencoSpedizioniRaggru2")]
	protected virtual Panel DivGrdElencoSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbElencoSpedizioniRaggru2")]
	protected virtual IboWebToolbar tlbElencoSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gridFilterPanelRaggru2")]
	protected virtual Panel gridFilterPanelRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFilterActiveFieldRaggru2")]
	protected virtual IboWebLabel lblFilterActiveFieldRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFilterOperatorRaggru2")]
	protected virtual IboDropDownList ddlFilterOperatorRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterTextRaggru2")]
	protected virtual IboWebTextBox FilterTextRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterDateRaggru2")]
	protected virtual IboWebDate2 FilterDateRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterNumberRaggru2")]
	protected virtual IboWebNumericTlk FilterNumberRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterOkRaggru2")]
	protected virtual ImageButton btnFilterOkRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterResetRaggru2")]
	protected virtual ImageButton btnFilterResetRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoSpedizioniRaggru2")]
	protected virtual Panel cpGrdElencoSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioniRaggru2")]
	protected virtual Panel pnlElencoSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grdSpedizioniRaggru2")]
	protected virtual IboGridView grdSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerElencoSpedizioniRaggru2")]
	protected virtual Panel footerElencoSpedizioniRaggru2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Colli_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Colli_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Pallet_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Pallet_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Volume_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Volume_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Peso_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Peso_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Spedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_Spedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_Spedizioni_Value
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

	[field: AccessedThroughProperty("DataSpedizioneCambia")]
	protected virtual IboWebDate2 DataSpedizioneCambia
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

	protected PlanGridFilter FilterSpedizioniRaggru2 => _FilterSpedizioniRaggru2;

	public WFPianificazioneBatch()
	{
		_Filtro = "";
		_FiltroHR = "";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		_Context = "PIANIFICAZIONE";
		_Tabella = "";
		_Title = TranslateMessage("XXX", "Visualizza per zona/batch");
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
			_Filtro = " (" + base.DbConn.DateTrunc("DATASPEDIZIONE") + " = " + base.DbConn.SQLFormatDate((eTipoData)1, DateAndTime.Now) + ") ";
			_FiltroHR = DateAndTime.Now.ToShortDateString();
			if (!((Page)this).IsPostBack)
			{
				string text = ((Page)this).Request.QueryString["Filter"] ?? "";
				string text2 = (((Page)this).Request.QueryString["UserFilter"] ?? "").ToUpper();
				string text3 = ((Page)this).Request.QueryString["Caption"] ?? "";
				_SessionVariable["FILTRO_QUERYSTRING"] = (object)text;
				_SessionVariable["FILTRO_UTENTE"] = (object)text2;
				if (Operators.CompareString(text, "", false) != 0)
				{
					ref string filtro = ref _Filtro;
					filtro = filtro + " AND (" + text + ") ";
				}
				if (Operators.CompareString(text2, "S", false) == 0 && Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro ?? "", "", false) != 0)
				{
					ref string filtro2 = ref _Filtro;
					filtro2 = filtro2 + " AND (" + base.SessionEnvironment.WebUser.WebUserInfo.Filtro + ") ";
				}
				if (Operators.CompareString(text3, "", false) != 0)
				{
					ref string title = ref _Title;
					title = title + " (" + text3 + ")";
				}
			}
			_SessionVariable["FILTRO"] = (object)_Filtro;
			_SessionVariable["FILTROHR"] = (object)_FiltroHR;
		}
		if (Information.IsDate((object)_FiltroHR))
		{
			_FiltroHR = Strings.Format((object)Conversions.ToDate(_FiltroHR), "dd/MM/yyyy");
			DataSpedizione.ObjValue = _FiltroHR;
		}
		if (!((Page)this).IsPostBack)
		{
			string text4 = ((Page)this).Request.QueryString["InitialGrid"] ?? "";
			if (Operators.CompareString(text4, "C", false) == 0)
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
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
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
			objGridView = grdElencoBatch;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdElencoBatch = objGridView;
			text = GeneraQueryBatch("");
			iboInternalGridConfig.Build("DM.PIA.BATCH", text, "", "", ((Control)grdElencoBatch).ID, "");
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdSpedizioni;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdSpedizioni = objGridView;
			text = GeneraQuerySpedizioni("");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PIA", text, "", "", ((Control)grdSpedizioni).ID, ((Control)tlbElencoSpedizioni).ID);
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
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
			StateBag myViewState5 = base.MyViewState;
			objGridView = grdSpedizioniRaggru2;
			iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
			grdSpedizioniRaggru2 = objGridView;
			text = GeneraQuerySpedizioniRaggru2("");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PIA_RAGGRU2", text, "", "", ((Control)grdSpedizioniRaggru2).ID, ((Control)tlbElencoSpedizioniRaggru2).ID);
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
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Invalid comparison between Unknown and I4
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
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Invalid comparison between Unknown and I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Invalid comparison between Unknown and I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Invalid comparison between Unknown and I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
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
				upElencoBatch.Update();
				val = AggiornaElencoBatch(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			grdElencoBatch.SelectAllRows();
			text = "";
			iboInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
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
						if (j < robjData[0].FieldValuesCount - 1)
						{
							text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(j).ToString()) + " ";
							text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(robjData.Item(1).get_FieldValues(j).ToString()) + ") OR ";
						}
						else
						{
							text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(j).ToString()) + " ";
							text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(robjData.Item(1).get_FieldValues(j).ToString()) + ")";
						}
					}
					text = "(" + text + ")";
				}
				_SessionVariable["FILTROBATCH"] = (object)text;
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
			val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
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

	private void grdElencoBatch_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Invalid comparison between Unknown and I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Invalid comparison between Unknown and I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
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
						if (i < functionArguments.Data[0].FieldValuesCount - 1)
						{
							text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(functionArguments.Data.Item(0).get_FieldValues(i).ToString()) + " ";
							text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(functionArguments.Data.Item(1).get_FieldValues(i).ToString()) + ") OR ";
						}
						else
						{
							text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(functionArguments.Data.Item(0).get_FieldValues(i).ToString()) + " ";
							text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(functionArguments.Data.Item(1).get_FieldValues(i).ToString()) + ")";
						}
					}
					text = "(" + text + ")";
				}
				_SessionVariable["FILTROBATCH"] = (object)text;
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
			val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
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
			_SessionVariable["FILTROBATCH"] = (object)"";
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			upElencoZone.Update();
			grdElencoZone_MultiSelectChanged(grdElencoZone, new EventArgs());
			upElencoBatch.Update();
			grdElencoBatch_MultiSelectChanged(grdElencoBatch, new EventArgs());
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
				DataSpedizione.ObjValue = _FiltroHR;
				DataSpedizioneCambia.ObjValue = _FiltroHR;
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

	private void btnCalcolaPalletSagome_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
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
				return;
			}
			if (robjData.Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Selezionare almeno un batch");
				return;
			}
			int num = checked(robjData[0].FieldValuesCount - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				Dictionary<string, object> dictionary = null;
				string text = robjData.Item(1).get_FieldValues(i).ToString();
				val2 = WMSMessage_PrepareData_Invoker.Instance.RunProc(CreateApiContext(), (WMSMessageType)5, (object)text, (object)null, (object)null, (object)null, (object)null, (object)null, (object)null, (object)null, (object)null, (object)null, ref dictionary, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				WMSMessage_Send_Invoker instance = WMSMessage_Send_Invoker.Instance;
				AppApiContext obj = CreateApiContext();
				Dictionary<string, object> dictionary2 = dictionary;
				Dictionary<string, object> dictionary3 = null;
				val2 = instance.RunProc(obj, (WMSMessageType)5, dictionary2, ref dictionary3, ref rsMess);
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
			string[] array = DataSpedizione.ObjValue.ToString().Split(new char[1] { '/' });
			DateTime data = new DateTime(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0])).AddDays(1.0);
			val2 = CambiaDataSpedizione(data, ref rsMess);
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
			string[] array = DataSpedizione.ObjValue.ToString().Split(new char[1] { '/' });
			DateTime data = new DateTime(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0])).AddDays(-1.0);
			val2 = CambiaDataSpedizione(data, ref rsMess);
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

	private void btnModificaDataBatch_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			DataSpedizioneCambia.ObjValue = "";
			MasterPopupFormOpen("Modifica Data Spedizione Batch", (Control)(object)pnlCambiaData, "MODIFICADATABATCH");
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

	private void grdSpedizioniRaggru2_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			lblFilterActiveFieldRaggru2.ObjValue = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
			string text2 = "System." + iboInternalGridConfig.GridInfo.CampoAttivoTipo;
			if ((Operators.CompareString(text2, typeof(int).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(long).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(short).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(double).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(float).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(decimal).ToString(), false) == 0))
			{
				ddlFilterOperatorRaggru2.ObjValue = "gt";
				FilterDateRaggru2.Visible = false;
				FilterTextRaggru2.Visible = false;
				FilterNumberRaggru2.Visible = true;
			}
			else if ((Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0))
			{
				ddlFilterOperatorRaggru2.ObjValue = "=";
				FilterDateRaggru2.Visible = true;
				FilterTextRaggru2.Visible = false;
				FilterNumberRaggru2.Visible = false;
			}
			else
			{
				ddlFilterOperatorRaggru2.ObjValue = "LIKE";
				FilterDateRaggru2.Visible = false;
				FilterTextRaggru2.Visible = true;
				FilterNumberRaggru2.Visible = false;
			}
			FilterSpedizioniRaggru2.SaveContext(iboInternalGridConfig.GridInfo.CampoAttivo, iboInternalGridConfig.GridInfo.CampoAttivoDescrizione, iboInternalGridConfig.GridInfo.CampoAttivoTipo);
			lblFilterActiveFieldRaggru2.ObjValue = iboInternalGridConfig.GridInfo.CampoAttivoDescrizione;
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
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Invalid comparison between Unknown and I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
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
				if ((Operators.CompareString(text, "VISUALIZZACONSEGNE", false) == 0) | (Operators.CompareString(text, "VISUALIZZASPEDIZIONI", false) == 0) | (Operators.CompareString(text, "VISUALIZZADESTINAZIONI", false) == 0))
				{
					switch (text)
					{
					case "VISUALIZZASPEDIZIONI":
						((Control)DivGrdElencoSpedizioni).Visible = true;
						((Control)DivGrdElencoSpedizioniRaggru).Visible = false;
						((Control)DivGrdElencoSpedizioniRaggru2).Visible = false;
						break;
					case "VISUALIZZACONSEGNE":
						((Control)DivGrdElencoSpedizioni).Visible = false;
						((Control)DivGrdElencoSpedizioniRaggru).Visible = true;
						((Control)DivGrdElencoSpedizioniRaggru2).Visible = false;
						break;
					case "VISUALIZZADESTINAZIONI":
						((Control)DivGrdElencoSpedizioni).Visible = false;
						((Control)DivGrdElencoSpedizioniRaggru).Visible = false;
						((Control)DivGrdElencoSpedizioniRaggru2).Visible = true;
						break;
					}
					goto IL_0346;
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
					goto IL_0346;
				}
				rsMess = TranslateMessage("XXX", "Selezionare almeno 1 record");
			}
			goto end_IL_0012;
			IL_0346:
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
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
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
		}
		return result;
	}

	private FXRETURN AggiornaElencoBatch(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
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
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
			objInternalGridConfig.SqlOriginalStatement = GeneraQueryBatch(ssqlFiltroZone);
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
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
		}
		return result;
	}

	private FXRETURN AggiornaElencoSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroBatch = "";
		FXRETURN result;
		try
		{
			if (_SessionVariable.ContainsKey("FILTROBATCH"))
			{
				ssqlFiltroBatch = _SessionVariable["FILTROBATCH"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			text = GeneraQuerySpedizioni(ssqlFiltroBatch);
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroBatch = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru BEGIN");
			if (_SessionVariable.ContainsKey("FILTROBATCH"))
			{
				ssqlFiltroBatch = _SessionVariable["FILTROBATCH"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			text = GeneraQuerySpedizioniRaggru(ssqlFiltroBatch);
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
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

	private FXRETURN AggiornaElencoSpedizioniRaggru2(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroBatch = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru2 BEGIN");
			if (_SessionVariable.ContainsKey("FILTROBATCH"))
			{
				ssqlFiltroBatch = _SessionVariable["FILTROBATCH"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
			text = GeneraQuerySpedizioniRaggru2(ssqlFiltroBatch);
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				grdSpedizioniRaggru2.SelectAllRows();
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
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru2 END");
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

	public void InitGridFilterSystemRaggru2()
	{
		if (!_SessionVariable.ContainsKey("FILTERSPEDIZIONIRAGGRU2"))
		{
			ddlFilterOperatorRaggru2.ObjValue = "LIKE";
			_FilterSpedizioniRaggru2 = new PlanGridFilter(base.DbConn);
			_FilterSpedizioniRaggru2.Id = ((Control)grdSpedizioniRaggru2).ID;
			_SessionVariable.Add("FILTERSPEDIZIONIRAGGRU2", _FilterSpedizioniRaggru2);
		}
		else
		{
			_FilterSpedizioniRaggru2 = (PlanGridFilter)_SessionVariable["FILTERSPEDIZIONIRAGGRU2"];
		}
		if (!((Page)this).IsPostBack)
		{
			ddlFilterOperatorRaggru2.ObjValue = "LIKE";
			lblFilterActiveFieldRaggru2.ObjValue = "Numero Ordine";
			FilterDateRaggru2.Visible = false;
			FilterTextRaggru2.Visible = true;
			FilterNumberRaggru2.Visible = false;
			FilterSpedizioniRaggru2.SaveContext("NumeroOrdine", "Numero Ordine", typeof(string).ToString());
		}
	}

	protected void GridSearchRaggru2(object sender, EventArgs e)
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
			if (FilterTextRaggru2.Visible)
			{
				if (!ddlFilterOperatorRaggru2.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterTextRaggru2.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioniRaggru2.AddFilter(ddlFilterOperatorRaggru2.ObjValue.ToString(), FilterTextRaggru2.ObjValue.ToString());
			}
			else if (FilterDateRaggru2.Visible)
			{
				if (!ddlFilterOperatorRaggru2.ObjValue.ToString().Contains("NULL") && !Information.IsDate(RuntimeHelpers.GetObjectValue(FilterDateRaggru2.ObjValue)))
				{
					return;
				}
				FilterSpedizioniRaggru2.AddFilter(ddlFilterOperatorRaggru2.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterDateRaggru2.ObjValue));
			}
			else if (FilterNumberRaggru2.Visible)
			{
				if (!ddlFilterOperatorRaggru2.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterNumberRaggru2.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterSpedizioniRaggru2.AddFilter(ddlFilterOperatorRaggru2.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterNumberRaggru2.ObjValue));
			}
			FilterTextRaggru2.ToolTip = FilterSpedizioniRaggru2.FilterExpressionHR;
			FilterDateRaggru2.Tooltip = FilterSpedizioniRaggru2.FilterExpressionHR;
			FilterNumberRaggru2.ToolTip = FilterSpedizioniRaggru2.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
			if ((int)val <= 0)
			{
				FilterTextRaggru2.Clear();
				FilterDateRaggru2.Clear();
				FilterNumberRaggru2.ObjValue = 0;
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

	protected void GridFilterResetRaggru2(object sender, EventArgs e)
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
			FilterSpedizioniRaggru2.Reset();
			FilterTextRaggru2.ToolTip = FilterSpedizioniRaggru2.FilterExpressionHR;
			FilterDateRaggru2.Tooltip = FilterSpedizioniRaggru2.FilterExpressionHR;
			FilterNumberRaggru2.ToolTip = FilterSpedizioniRaggru2.FilterExpressionHR;
			upElencoSpedizioni.Update();
			val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
			if ((int)val <= 0)
			{
				FilterTextRaggru2.Clear();
				FilterDateRaggru2.Clear();
				FilterNumberRaggru2.ObjValue = 0;
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
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_0269;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "AGGIUNGITRANSITPOINT", false) == 0)
			{
				val = AggiungiTransitPoint(Corrispondente.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0269;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO", false) == 0)
			{
				val = CreaViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0269;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "ASSOCIAVIAGGIO", false) == 0)
			{
				if (Operators.CompareString(AssociaViaggio_IdViaggio.ObjValue.ToString(), "", false) == 0)
				{
					goto IL_0269;
				}
				val = AssociaAViaggio(AssociaViaggio_IdViaggio.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0269;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CAMBIADATA", false) == 0)
			{
				if (Operators.CompareString(DataSpedizioneCambia.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire Data Spedizione");
				}
				else
				{
					val = CambiaDataSpedizione(DataSpedizioneCambia.getDateValue, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_0269;
					}
					val2 = val;
				}
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "MODIFICADATABATCH", false) != 0)
				{
					goto IL_0269;
				}
				if (Operators.CompareString(DataSpedizioneCambia.ObjValue.ToString(), "", false) == 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire la Data Spedizione");
				}
				else
				{
					val = ModificaDataSpedizioneBatch(DataSpedizioneCambia.getDateValue, ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_0269;
					}
					val2 = val;
				}
			}
			goto end_IL_0007;
			IL_0269:
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
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Invalid comparison between Unknown and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((Control)DivGrdElencoSpedizioniRaggru2).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
					goto IL_027a;
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
						else if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru2).ID, false) == 0))
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
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
							if ((int)val <= 0)
							{
								upElencoSpedizioni.Update();
								goto IL_027a;
							}
							val2 = val;
						}
					}
				}
			}
			goto end_IL_000e;
			IL_027a:
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
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Invalid comparison between Unknown and I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Invalid comparison between Unknown and I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Invalid comparison between Unknown and I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
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
				goto IL_03b2;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_03b2;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_03b2;
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
			else if (((Control)DivGrdElencoSpedizioniRaggru2).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
					goto IL_03b2;
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
						else if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru2).ID, false) == 0))
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
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							val2 = AggiornaElencoSpedizioniRaggru2(ref rsMess);
							if ((int)val2 <= 0)
							{
								upElencoSpedizioni.Update();
								goto IL_03b2;
							}
							val = val2;
						}
					}
				}
			}
			goto end_IL_0005;
			IL_03b2:
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
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Invalid comparison between Unknown and I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Invalid comparison between Unknown and I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Invalid comparison between Unknown and I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Invalid comparison between Unknown and I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((Control)DivGrdElencoSpedizioniRaggru2).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
					goto IL_02fa;
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
						else if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru2).ID, false) == 0))
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
					_SessionVariable["FILTROBATCH"] = (object)"";
					val = AggiornaElencoZone(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						upElencoZone.Update();
						val = AggiornaElencoBatch(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoBatch.Update();
							val = AggiornaElencoSpedizioni(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru(ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
									if ((int)val <= 0)
									{
										upElencoSpedizioni.Update();
										goto IL_02fa;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_02fa:
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

	private FXRETURN CambiaDataSpedizione(DateTime Data, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Invalid comparison between Unknown and I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Invalid comparison between Unknown and I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Invalid comparison between Unknown and I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Invalid comparison between Unknown and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			_SessionVariable["FILTROZONE"] = (object)"";
			_SessionVariable["FILTROBATCH"] = (object)"";
			_Filtro = " (" + base.DbConn.DateTrunc("DATASPEDIZIONE") + "=" + base.DbConn.SQLFormatDate((eTipoData)1, Data) + ") ";
			_SessionVariable["FILTROHR"] = (object)Data.ToShortDateString();
			_FiltroHR = _SessionVariable["FILTROHR"].ToString();
			if (Operators.CompareString(_SessionVariable["FILTRO_QUERYSTRING"].ToString(), "", false) != 0)
			{
				ref string filtro = ref _Filtro;
				filtro = filtro + " AND (" + _SessionVariable["FILTRO_QUERYSTRING"].ToString() + ")";
			}
			if (Operators.CompareString(_SessionVariable["FILTRO_UTENTE"].ToString(), "S", false) == 0 && Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro ?? "", "", false) != 0)
			{
				ref string filtro2 = ref _Filtro;
				filtro2 = filtro2 + " AND (" + base.SessionEnvironment.WebUser.WebUserInfo.Filtro + ") ";
			}
			_SessionVariable["FILTRO"] = (object)_Filtro;
			if (Information.IsDate((object)_FiltroHR))
			{
				DataSpedizione.ObjValue = _FiltroHR;
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
				val = AggiornaElencoBatch(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					upElencoBatch.Update();
					val = AggiornaElencoSpedizioni(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = AggiornaElencoSpedizioniRaggru(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								upElencoSpedizioni.Update();
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

	private FXRETURN ModificaDataSpedizioneBatch(DateTime Data, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Invalid comparison between Unknown and I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Invalid comparison between Unknown and I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
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
					goto IL_0262;
				}
				List<string> list = new List<string>();
				string text;
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						list.Add(robjData.Item(1).get_FieldValues(i).ToString());
					}
					text = "";
				}
				foreach (string item in list)
				{
					val = BatchModificaData_Invoker.Instance.RunProc(CreateApiContext(), item, DataSpedizioneCambia.getDateValue, ref rsMess);
					if ((int)val <= 0)
					{
						text = text + TranslateMessage("XXX", "Batch ID {0} aggiornato correttamente.", item) + "\r\n";
						continue;
					}
					if ((int)val == 14 || (int)val == 4)
					{
						text = text + rsMess + "\r\n";
						continue;
					}
					val2 = val;
					goto end_IL_0005;
				}
				val = AggiornaElencoZone(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					upElencoZone.Update();
					val = AggiornaElencoBatch(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						grdElencoBatch.SelectAllRows();
						upElencoBatch.Update();
						val = AggiornaElencoSpedizioni(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = AggiornaElencoSpedizioniRaggru(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
								if ((int)val <= 0)
								{
									upElencoSpedizioni.Update();
									WriteInfoMessage(TranslateMessage("XXX", text), ShowAsNotification: true);
									goto IL_0262;
								}
								val2 = val;
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_0262:
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
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Invalid comparison between Unknown and I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Invalid comparison between Unknown and I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Invalid comparison between Unknown and I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Invalid comparison between Unknown and I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Invalid comparison between Unknown and I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((Control)DivGrdElencoSpedizioniRaggru2).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
					goto IL_0393;
				}
				List<string> ListOfUnibol = new List<string>();
				Viaggio Viaggio;
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0)
						{
							ListOfUnibol.Add(robjData.Item(0).get_FieldValues(i).ToString());
						}
						else if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru2).ID, false) == 0))
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
					val = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref ListOfUnibol, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					_SessionVariable["FILTROZONE"] = (object)"";
					_SessionVariable["FILTROBATCH"] = (object)"";
					val = AggiornaElencoZone(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						upElencoZone.Update();
						val = AggiornaElencoBatch(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoBatch.Update();
							val = AggiornaElencoSpedizioni(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru(ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
									if ((int)val <= 0)
									{
										upElencoSpedizioni.Update();
										WriteInfoMessage(TranslateMessage("XXX", "Generato il viaggio {0}", Viaggio.IdViaggio), ShowAsNotification: true);
										goto IL_0393;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_0393:
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
					AggiornaElencoBatch(ref rsMess);
					upElencoBatch.Update();
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
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Invalid comparison between Unknown and I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Invalid comparison between Unknown and I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Invalid comparison between Unknown and I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Invalid comparison between Unknown and I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((Control)DivGrdElencoSpedizioniRaggru2).Visible)
			{
				iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
					goto IL_033c;
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
						else if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniRaggru2).ID, false) == 0))
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
					_SessionVariable["FILTROBATCH"] = (object)"";
					val = AggiornaElencoZone(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						upElencoZone.Update();
						val = AggiornaElencoBatch(ref rsMess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							upElencoBatch.Update();
							val = AggiornaElencoSpedizioni(ref rsMess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru(ref rsMess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									val = AggiornaElencoSpedizioniRaggru2(ref rsMess);
									if ((int)val <= 0)
									{
										upElencoSpedizioni.Update();
										WriteInfoMessage(TranslateMessage("XXX", "{0} spedizioni associate al viaggio '{1}'", list.Count.ToString(), IdViaggio), ShowAsNotification: true);
										goto IL_033c;
									}
									val2 = val;
								}
							}
						}
					}
				}
			}
			goto end_IL_000e;
			IL_033c:
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
		text += "AND BATCHID IS NOT NULL ";
		if (Operators.CompareString(_Filtro, "", false) != 0)
		{
			text = text + "AND " + _Filtro + " ";
		}
		text += ") T ";
		text += "INNER JOIN SPEDIZIONI_BATCH B ON B.ID = T.BATCHID ";
		text += "INNER JOIN ZONE Z ON Z.CODICE = T.ZONASPEDIZIONE ";
		text += "WHERE B.STATO IN (10,20,25,30) ";
		return text + "GROUP BY T.ZONASPEDIZIONE,Z.Descrizione ";
	}

	private string GeneraQueryBatch(string ssqlFiltroZone)
	{
		string text = "";
		text = "SELECT T.ZonaSpedizione, Z.Descrizione As ZonaSpedizioneDescrizione, BatchId, B.DataCreazione, ";
		text += "B.Stato, CASE B.Stato WHEN 10 THEN 'DA ATTIVARE' WHEN 20 THEN 'ATTIVATO' WHEN 25 THEN 'FINE PRELIEVO' WHEN 30 THEN 'CHIUSO' ELSE ' ' END Stato_Descrizione, ";
		text += "MAX(B.PALLET) BATCH_PALLET, MAX(B.SAGOME) BATCH_SAGOME, MAX(B.VOLUME) BATCH_VOLUME, ";
		text += "MAX(B.PALLETEFFETTIVI) BATCH_PALLETEFFETTIVI, MAX(B.SAGOMEEFFETTIVE) BATCH_SAGOMEEFFETTIVE, MAX(B.VOLUMEEFFETTIVO) BATCH_VOLUMEEFFETTIVO, ";
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
		text += "AND BATCHID IS NOT NULL ";
		if (Operators.CompareString(_Filtro, "", false) != 0)
		{
			text = text + "AND " + _Filtro + " ";
		}
		text = ((Operators.CompareString(ssqlFiltroZone, "", false) == 0) ? (text + "AND 1=2 ") : (text + "AND ZONASPEDIZIONE IN (" + ssqlFiltroZone + ") "));
		text += ") T ";
		text += "INNER JOIN SPEDIZIONI_BATCH B ON B.ID = T.BATCHID ";
		text += "INNER JOIN ZONE Z ON Z.CODICE = T.ZONASPEDIZIONE ";
		text += "WHERE B.STATO IN (10,20,25,30) ";
		return text + "GROUP BY T.ZONASPEDIZIONE,Z.Descrizione,T.BATCHID,B.DATACREAZIONE,B.STATO ";
	}

	private string GeneraQuerySpedizioni(string ssqlFiltroBatch)
	{
		string text = "";
		text = "SELECT * FROM GRD_PIA_SPEDIZIONI WHERE ";
		if (Operators.CompareString(ssqlFiltroBatch, "", false) != 0)
		{
			text = text + ssqlFiltroBatch + " ";
			if (Operators.CompareString(_Filtro, "", false) != 0)
			{
				text = text + "AND " + _Filtro + " ";
			}
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

	private string GeneraQuerySpedizioniRaggru(string ssqlFiltroBatch)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Invalid comparison between Unknown and I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Invalid comparison between Unknown and I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Invalid comparison between Unknown and I4
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
			text += "FROM VW_PIA_Zone_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NULL AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
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
		text += "FROM VW_PIA_Zone_Spedizioni S ";
		text += "WHERE <%FILTRO%> ";
		text += "AND S.CORRISPONDENTE IS NULL ";
		text += "GROUP BY S.PCSDESTINAZIONE ";
		if ((int)base.DbConn.ServerType == 0)
		{
			text += " UNION ";
		}
		else if ((int)base.DbConn.ServerType == 1)
		{
			text += " UNION ALL ";
		}
		text += "SELECT 'C' Tipo,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "COUNT(DISTINCT(S.PCSDESTINAZIONE)) Numero_Scarichi,";
		if ((int)base.DbConn.ServerType == 0)
		{
			text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
			text += "FROM VW_PIA_Zone_Spedizioni TEMP ";
			text += "WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE ";
			text += "FOR XML PATH('') ),1,1,'') AS ListaUnibol, ";
			text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' + ";
			text += "REPLACE(REPLACE((SELECT '%lt%tr%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_ragsoc) + ' %lt%/td%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_localita) + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') + ' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Colli) AS VARCHAR) + ";
			text += "' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Pallet) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Volume) AS VARCHAR) + '%lt%/td%gt%%lt%/tr%gt%' ";
			text += "FROM VW_PIA_Zone_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione ";
			text += "FOR XML PATH('') ), '%gt%', '>'), '%lt%', '<') ";
			text += "+ '</table>' AS ListaDestinazioni, ";
		}
		else if ((int)base.DbConn.ServerType == 1)
		{
			text += "CAST(wm_concat (DISTINCT S.Unibol) AS VARCHAR2(4000)) AS ListaUnibol, ";
			text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' || ";
			text += "REPLACE(REPLACE((REPLACE(REPLACE((SELECT wm_concat('%%%'|| '<tr><td>' || MAX(TEMP.pcsdestinazione_ragsoc) || '</td><td>' || MAX(TEMP.pcsdestinazione_localita) || ";
			text += "'</td><td>' || ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') || '</td><td>' || ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') || ";
			text += "'</td><td>' || CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR2(4000)) || '</td><td>' || CAST(SUM(TEMP.Colli) AS VARCHAR2(4000)) || ";
			text += "'</td><td>' || CAST(SUM(TEMP.Pallet) AS VARCHAR2(4000)) || '</td><td>' || CAST(SUM(TEMP.Volume) AS VARCHAR2(4000)) || '</td></tr>') ";
			text += "FROM VW_PIA_Zone_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione), ',%%%', ' '), '%%%', '')), '>', '>'), '<', '<') || '</table>' AS ListaDestinazioni, ";
		}
		text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
		text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
		text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,";
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
		text += "FROM VW_PIA_Zone_Spedizioni S ";
		text += "LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
		text += "WHERE <%FILTRO%> ";
		text += "AND S.CORRISPONDENTE IS NOT NULL ";
		text += "GROUP BY S.CORRISPONDENTE ) T";
		if (Operators.CompareString(ssqlFiltroBatch, "", false) != 0)
		{
			text2 = text2 + ssqlFiltroBatch + " ";
			if (Operators.CompareString(_Filtro, "", false) != 0)
			{
				text2 = text2 + "AND " + _Filtro + " ";
			}
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

	private string GeneraQuerySpedizioniRaggru2(string ssqlFiltroBatch)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru2 BEGIN");
		text = "SELECT MAX(S.CORRISPONDENTE) CORRISPONDENTECODICE, ";
		text += "MAX(CORRISPONDENTERAGIONESOCIALE) CORRISPONDENTE_RAGSOC,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "1 Numero_Scarichi,";
		if ((int)base.DbConn.ServerType == 0)
		{
			text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
			text += "FROM VW_PIA_Zone_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
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
		text += "FROM VW_PIA_Zone_Spedizioni S ";
		text += "WHERE <%FILTRO%> ";
		text += "GROUP BY S.PCSDESTINAZIONE";
		if (Operators.CompareString(ssqlFiltroBatch, "", false) != 0)
		{
			text2 = text2 + ssqlFiltroBatch + " ";
			if (Operators.CompareString(_Filtro, "", false) != 0)
			{
				text2 = text2 + "AND " + _Filtro + " ";
			}
			if (!Information.IsNothing((object)FilterSpedizioniRaggru2) && Operators.CompareString(FilterSpedizioniRaggru2.FilterExpression, "", false) != 0)
			{
				text2 = text2 + " AND (" + FilterSpedizioniRaggru2.FilterExpression + ")";
			}
		}
		else
		{
			text2 += "1=2";
		}
		string result = text.Replace("<%FILTRO%>", text2);
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru2 END");
		return result;
	}

	private FXRETURN AggiornaTotaliGriglia(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_1056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Invalid comparison between Unknown and I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Invalid comparison between Unknown and I4
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Invalid comparison between Unknown and I4
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Invalid comparison between Unknown and I4
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
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
					decimal num8 = default(decimal);
					decimal num9 = default(decimal);
					decimal num10 = default(decimal);
					decimal num11 = default(decimal);
					decimal num12 = default(decimal);
					DataRow[] array2 = array;
					foreach (DataRow dataRow in array2)
					{
						num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow["Peso"]));
						num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow["Volume"]));
						num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow["Colli"]));
						num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow["Pallet"]));
						num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow["TotaleSpedizioni"]));
					}
					footerZone_Colli_Value.ObjValue = Convert.ToInt32(num6);
					footerZone_Pallet_Value.ObjValue = Convert.ToInt32(num8);
					footerZone_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
					footerZone_Volume_Value.ObjValue = Strings.Format((object)num4, "0.00000");
					footerZone_Spedizioni_Value.ObjValue = Convert.ToInt32(num10);
					text = "";
					iboInternalGridConfig = GridConfigList[((Control)grdElencoBatch).ID];
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
							int num13 = robjData[0].FieldValuesCount - 1;
							for (int k = 0; k <= num13; k++)
							{
								if (k < robjData[0].FieldValuesCount - 1)
								{
									text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(k).ToString()) + " ";
									text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(robjData.Item(1).get_FieldValues(k).ToString()) + ") OR ";
								}
								else
								{
									text = text + "(ZONASPEDIZIONE = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(k).ToString()) + " ";
									text = text + "AND BATCHID = " + base.DbConn.SQLFormatString(robjData.Item(1).get_FieldValues(k).ToString()) + ")";
								}
							}
							text = "(" + text + ")";
						}
						if (Operators.CompareString(text, "", false) == 0)
						{
							text = "1=2";
						}
						array = iboInternalGridConfig.DataTable.Select(text);
						num2 = default(decimal);
						num4 = default(decimal);
						num5 = default(decimal);
						num3 = default(decimal);
						num6 = default(decimal);
						num8 = default(decimal);
						num9 = default(decimal);
						num7 = default(decimal);
						num10 = default(decimal);
						num11 = default(decimal);
						num12 = default(decimal);
						DataRow[] array3 = array;
						foreach (DataRow dataRow2 in array3)
						{
							num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow2["Peso"]));
							num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow2["Volume"]));
							num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow2["Colli"]));
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_PALLET"])))
							{
								num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow2["BATCH_PALLET"]));
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_PALLETEFFETTIVI"])))
							{
								num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow2["BATCH_PALLETEFFETTIVI"]));
							}
							num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow2["TotaleSpedizioni"]));
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_SAGOME"])))
							{
								num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow2["BATCH_SAGOME"]));
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_SAGOMEEFFETTIVE"])))
							{
								num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow2["BATCH_SAGOMEEFFETTIVE"]));
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_VOLUME"])))
							{
								num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow2["BATCH_VOLUME"]));
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BATCH_VOLUMEEFFETTIVO"])))
							{
								num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow2["BATCH_VOLUMEEFFETTIVO"]));
							}
						}
						footerBatch_Colli_Value.ObjValue = Convert.ToInt32(num6);
						footerBatch_PalletTeo_Value.ObjValue = Convert.ToInt32(num7);
						footerBatch_PalletEff_Value.ObjValue = Convert.ToInt32(num9);
						footerBatch_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
						footerBatch_VolumeTeo_Value.ObjValue = Strings.Format((object)num3, "0.00000");
						footerBatch_VolumeEff_Value.ObjValue = Strings.Format((object)num5, "0.00000");
						footerBatch_Spedizioni_Value.ObjValue = Convert.ToInt32(num10);
						footerBatch_SagomeTeo_Value.ObjValue = Convert.ToInt32(num11);
						footerBatch_SagomeEff_Value.ObjValue = Convert.ToInt32(num12);
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
								text += " Unibol IN (";
								int num14 = robjData[0].FieldValuesCount - 1;
								for (int m = 0; m <= num14; m++)
								{
									text += base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(m).ToString());
									text = ((m >= robjData[0].FieldValuesCount - 1) ? (text + ")") : (text + ","));
								}
								text = "(" + text + ")";
							}
							if (Operators.CompareString(text, "", false) == 0)
							{
								text = "1=2";
							}
							array = iboInternalGridConfig.DataTable.Select(text);
							num2 = default(decimal);
							num4 = default(decimal);
							num5 = default(decimal);
							num3 = default(decimal);
							num6 = default(decimal);
							num8 = default(decimal);
							num9 = default(decimal);
							num7 = default(decimal);
							num10 = default(decimal);
							num11 = default(decimal);
							num12 = default(decimal);
							DataRow[] array4 = array;
							foreach (DataRow dataRow3 in array4)
							{
								num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow3["Peso"]));
								num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow3["Volume"]));
								num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow3["Colli"]));
								num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow3["Pallet"]));
								num10 = decimal.Add(num10, 1m);
							}
							footerSpedizioni_Colli_Value.ObjValue = Convert.ToInt32(num6);
							footerSpedizioni_Pallet_Value.ObjValue = Convert.ToInt32(num8);
							footerSpedizioni_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
							footerSpedizioni_Volume_Value.ObjValue = Strings.Format((object)num4, "0.00000");
							footerSpedizioni_Spedizioni_Value.ObjValue = Convert.ToInt32(num10);
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
									int num15 = robjData[0].FieldValuesCount - 1;
									for (int num16 = 0; num16 <= num15; num16++)
									{
										text = text + " (ListaUnibol = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num16).ToString()) + " ) ";
										if (num16 < robjData[0].FieldValuesCount - 1)
										{
											text += " OR ";
										}
									}
									text = "(" + text + ")";
								}
								if (Operators.CompareString(text, "", false) == 0)
								{
									text = "1=2";
								}
								array = iboInternalGridConfig.DataTable.Select(text);
								num2 = default(decimal);
								num4 = default(decimal);
								num5 = default(decimal);
								num3 = default(decimal);
								num6 = default(decimal);
								num8 = default(decimal);
								num9 = default(decimal);
								num7 = default(decimal);
								num10 = default(decimal);
								num11 = default(decimal);
								num12 = default(decimal);
								DataRow[] array5 = array;
								foreach (DataRow dataRow4 in array5)
								{
									num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow4["Peso"]));
									num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow4["Volume"]));
									num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow4["Colli"]));
									num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow4["Pallet"]));
									num10 = decimal.Add(num10, new decimal(Conversions.ToInteger(dataRow4["Numero_Spedizioni"])));
								}
								footerSpedizioniRaggru_Colli_Value.ObjValue = Convert.ToInt32(num6);
								footerSpedizioniRaggru_Pallet_Value.ObjValue = Convert.ToInt32(num8);
								footerSpedizioniRaggru_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
								footerSpedizioniRaggru_Volume_Value.ObjValue = Strings.Format((object)num4, "0.00000");
								footerSpedizioniRaggru_Spedizioni_Value.ObjValue = Convert.ToInt32(num10);
								text = "";
								iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
								grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
								objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
								FXRETURN keyDataFromGrid5 = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref robjData, ref robjKey, bSelezioneObbligatoria: false, ref rsMess);
								iboInternalGridConfig3.GridInfo = objGridInfo;
								iboInternalGridConfig2.GridView = grdGriglia;
								val = keyDataFromGrid5;
								if (unchecked((int)val) > 0)
								{
									val2 = val;
								}
								else
								{
									if (robjData.Count > 0)
									{
										int num18 = robjData[0].FieldValuesCount - 1;
										for (int num19 = 0; num19 <= num18; num19++)
										{
											text = text + " (ListaUnibol = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num19).ToString()) + " ) ";
											if (num19 < robjData[0].FieldValuesCount - 1)
											{
												text += " OR ";
											}
										}
										text = "(" + text + ")";
									}
									if (Operators.CompareString(text, "", false) == 0)
									{
										text = "1=2";
									}
									array = iboInternalGridConfig.DataTable.Select(text);
									num2 = default(decimal);
									num4 = default(decimal);
									num6 = default(decimal);
									num8 = default(decimal);
									num10 = default(decimal);
									DataRow[] array6 = array;
									foreach (DataRow dataRow5 in array6)
									{
										num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow5["Peso"]));
										num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow5["Volume"]));
										num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow5["Colli"]));
										num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow5["Pallet"]));
										num10 = decimal.Add(num10, new decimal(Conversions.ToInteger(dataRow5["Numero_Spedizioni"])));
									}
									footerSpedizioniRaggru2_Colli_Value.ObjValue = Convert.ToInt32(num6);
									footerSpedizioniRaggru2_Pallet_Value.ObjValue = Convert.ToInt32(num8);
									footerSpedizioniRaggru2_Peso_Value.ObjValue = Strings.Format((object)num2, "0.00");
									footerSpedizioniRaggru2_Volume_Value.ObjValue = Strings.Format((object)num4, "0.00000");
									footerSpedizioniRaggru2_Spedizioni_Value.ObjValue = Convert.ToInt32(num10);
									val2 = (FXRETURN)0;
								}
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
