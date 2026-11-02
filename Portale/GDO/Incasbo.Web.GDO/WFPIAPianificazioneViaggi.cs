using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFPIAPianificazioneViaggi : WFIDBPageMasterDetail
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
	[AccessedThroughProperty("btnGotoPreviousDateViaggio")]
	private IboWebButton _btnGotoPreviousDateViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoNextDateViaggio")]
	private IboWebButton _btnGotoNextDateViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoPreviousDateDa")]
	private IboWebButton _btnGotoPreviousDateDa;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoNextDateDa")]
	private IboWebButton _btnGotoNextDateDa;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoPreviousDateA")]
	private IboWebButton _btnGotoPreviousDateA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnGotoNextDateA")]
	private IboWebButton _btnGotoNextDateA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdViaggi")]
	private IboGridView _grdViaggi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoSpedizioniViaggioCaption")]
	private IboWebLinkButton _lnkElencoSpedizioniViaggioCaption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoConsengeViaggioCaption")]
	private IboWebLinkButton _lnkElencoConsengeViaggioCaption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioniViaggio")]
	private IboGridView _grdSpedizioniViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioniRaggruViaggio")]
	private IboGridView _grdSpedizioniRaggruViaggio;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoConsegneCaption")]
	private IboWebLinkButton _lnkElencoConsegneCaption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoDestinazioniCaption")]
	private IboWebLinkButton _lnkElencoDestinazioniCaption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioni")]
	private IboGridView _grdSpedizioni;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoSpedizioniCaption")]
	private IboWebLinkButton _lnkElencoSpedizioniCaption;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoDestinazioniCaption2")]
	private IboWebLinkButton _lnkElencoDestinazioniCaption2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioniRaggru")]
	private IboGridView _grdSpedizioniRaggru;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoSpedizioniCaption2")]
	private IboWebLinkButton _lnkElencoSpedizioniCaption2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lnkElencoConsegneCaption2")]
	private IboWebLinkButton _lnkElencoConsegneCaption2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("grdSpedizioniRaggru2")]
	private IboGridView _grdSpedizioniRaggru2;

	protected string _Filtro;

	protected DateTime _DaData;

	protected DateTime _AData;

	protected DateTime? _DataVia;

	protected string _FiltroQueryString;

	protected string _FiltroUtente;

	protected string _CaptionQueryString;

	protected DataKeyFieldCollection _ZoneSelezionate;

	protected bool _AutoSelect;

	protected int _TopSelect;

	private const string ZonaMacroNonDefinita = "*XXX*";

	private const string ZonaMacroDescrizioneNonDefinita = "NON DEFINITA";

	protected string kFormatoSommaPeso;

	protected string kFormatoSommaVolume;

	protected string kFormatoSommaCC;

	protected PlanGridFilter _FilterViaggi;

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

	[field: AccessedThroughProperty("lblDataViaggio")]
	protected virtual IboWebLabel lblDataViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataViaggio")]
	protected virtual IboWebLabel DataViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGotoPreviousDateViaggio
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoPreviousDateViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoPreviousDateViaggio_Click;
			IboWebButton val = _btnGotoPreviousDateViaggio;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoPreviousDateViaggio = value;
			val = _btnGotoPreviousDateViaggio;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnGotoNextDateViaggio
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoNextDateViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoNextDateViaggio_Click;
			IboWebButton val = _btnGotoNextDateViaggio;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoNextDateViaggio = value;
			val = _btnGotoNextDateViaggio;
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

	[field: AccessedThroughProperty("lblDataSpedizioneDaCaption")]
	protected virtual IboWebLabel lblDataSpedizioneDaCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataSpedizioneDa")]
	protected virtual IboWebLabel DataSpedizioneDa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGotoPreviousDateDa
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoPreviousDateDa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoPreviousDate_Click;
			IboWebButton val = _btnGotoPreviousDateDa;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoPreviousDateDa = value;
			val = _btnGotoPreviousDateDa;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnGotoNextDateDa
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoNextDateDa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoNextDateDa_Click;
			IboWebButton val = _btnGotoNextDateDa;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoNextDateDa = value;
			val = _btnGotoNextDateDa;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("IboWebLabel2")]
	protected virtual IboWebLabel IboWebLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataSpedizioneA")]
	protected virtual IboWebLabel DataSpedizioneA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnGotoPreviousDateA
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoPreviousDateA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoPreviousDateA_Click;
			IboWebButton val = _btnGotoPreviousDateA;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoPreviousDateA = value;
			val = _btnGotoPreviousDateA;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebButton btnGotoNextDateA
	{
		[CompilerGenerated]
		get
		{
			return _btnGotoNextDateA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnGotoNextDateA_Click;
			IboWebButton val = _btnGotoNextDateA;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnGotoNextDateA = value;
			val = _btnGotoNextDateA;
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

	[field: AccessedThroughProperty("upElencoViaggi")]
	protected virtual UpdatePanel upElencoViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DivGrdElencoViaggi")]
	protected virtual Panel DivGrdElencoViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblViaggiCaption")]
	protected virtual IboWebLabel lblViaggiCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbElencoViaggi")]
	protected virtual IboWebToolbar tlbElencoViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gridFilterPanelViaggi")]
	protected virtual Panel gridFilterPanelViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFilterActiveFieldViaggi")]
	protected virtual IboWebLabel lblFilterActiveFieldViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ddlFilterOperatorViaggi")]
	protected virtual IboDropDownList ddlFilterOperatorViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterTextViaggi")]
	protected virtual IboWebTextBox FilterTextViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterDateViaggi")]
	protected virtual IboWebDate2 FilterDateViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilterNumberViaggi")]
	protected virtual IboWebNumericTlk FilterNumberViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterOkViaggi")]
	protected virtual ImageButton btnFilterOkViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnFilterResetViaggi")]
	protected virtual ImageButton btnFilterResetViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoViaggi")]
	protected virtual IboWebPanel cpGrdElencoViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoViaggi")]
	protected virtual IboWebPanel pnlElencoViaggi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hdnIdViaggioSelezionato")]
	protected virtual HiddenField hdnIdViaggioSelezionato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdViaggi
	{
		[CompilerGenerated]
		get
		{
			return _grdViaggi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdViaggi_MultiSelectChanged);
			IboGridView val2 = _grdViaggi;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdViaggi = value;
			val2 = _grdViaggi;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
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

	[field: AccessedThroughProperty("upElencoSpedizioniViaggio")]
	protected virtual UpdatePanel upElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DivGrdElencoSpedizioniViaggio")]
	protected virtual Panel DivGrdElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkElencoSpedizioniViaggioCaption
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoSpedizioniViaggioCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoSpedizioniViaggioCaption_Click;
			IboWebLinkButton val = _lnkElencoSpedizioniViaggioCaption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoSpedizioniViaggioCaption = value;
			val = _lnkElencoSpedizioniViaggioCaption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebLinkButton lnkElencoConsengeViaggioCaption
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoConsengeViaggioCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsengeViaggioCaption_Click;
			IboWebLinkButton val = _lnkElencoConsengeViaggioCaption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoConsengeViaggioCaption = value;
			val = _lnkElencoConsengeViaggioCaption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("tlbElencoSpedizioniViaggio")]
	protected virtual IboWebToolbar tlbElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tlbElencoSpedizioniRaggruViaggio")]
	protected virtual IboWebToolbar tlbElencoSpedizioniRaggruViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpGrdElencoSpedizioniViaggio")]
	protected virtual IboWebPanel cpGrdElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioniViaggio")]
	protected virtual IboWebPanel pnlElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdSpedizioniViaggio
	{
		[CompilerGenerated]
		get
		{
			return _grdSpedizioniViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdSpedizioniViaggio_MultiSelectChanged);
			IboGridView val2 = _grdSpedizioniViaggio;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdSpedizioniViaggio = value;
			val2 = _grdSpedizioniViaggio;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("cpGrdElencoSpedizioniRaggruViaggio")]
	protected virtual IboWebPanel cpGrdElencoSpedizioniRaggruViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioniRaggruViaggio")]
	protected virtual IboWebPanel pnlElencoSpedizioniRaggruViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboGridView grdSpedizioniRaggruViaggio
	{
		[CompilerGenerated]
		get
		{
			return _grdSpedizioniRaggruViaggio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdSpedizioniRaggruViaggio_MultiSelectChanged);
			IboGridView val2 = _grdSpedizioniRaggruViaggio;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdSpedizioniRaggruViaggio = value;
			val2 = _grdSpedizioniRaggruViaggio;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("footerElencoSpedizioniViaggio")]
	protected virtual Panel footerElencoSpedizioniViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Colli_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Colli_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Pallet_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Pallet_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Volume_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Volume_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Peso_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Peso_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo1_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo1_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo1_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo1_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo2_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo2_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo2_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo2_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo3_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo3_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo3_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo3_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo4_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo4_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo4_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo4_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo5_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo5_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo5_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo5_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo6_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo6_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo6_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo6_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo7_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo7_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo7_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo7_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo8_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo8_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo8_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo8_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo9_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo9_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo9_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo9_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo10_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo10_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_CampoCalcolo10_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_CampoCalcolo10_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Spedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_Spedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_TotSpedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniViaggio_TotSpedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniViaggio_TotSpedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniViaggio_TotSpedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerElencoSpedizioniRaggruViaggio")]
	protected virtual Panel footerElencoSpedizioniRaggruViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Colli_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Colli_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Colli_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Colli_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Pallet_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Pallet_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Pallet_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Pallet_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Volume_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Volume_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Volume_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Volume_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Peso_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Peso_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Peso_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Peso_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo1_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo1_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo1_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo1_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo2_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo2_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo2_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo2_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo3_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo3_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo3_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo3_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo4_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo4_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo4_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo4_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo5_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo5_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo5_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo5_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo6_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo6_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo6_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo6_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo7_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo7_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo7_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo7_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo8_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo8_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo8_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo8_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo9_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo9_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo9_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo9_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo10_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo10_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_CampoCalcolo10_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_CampoCalcolo10_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Spedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Spedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_Spedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_Spedizioni_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_TotSpedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_TotSpedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggruViaggio_TotSpedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggruViaggio_TotSpedizioni_Value
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

	[field: AccessedThroughProperty("lblElencoSpedizioniCaption")]
	protected virtual IboWebLabel lblElencoSpedizioniCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkElencoConsegneCaption
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoConsegneCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoConsegneCaption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoConsegneCaption = value;
			val = _lnkElencoConsegneCaption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebLinkButton lnkElencoDestinazioniCaption
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoDestinazioniCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoDestinazioniCaption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoDestinazioniCaption = value;
			val = _lnkElencoDestinazioniCaption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
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
	protected virtual IboWebPanel cpGrdElencoSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnlElencoSpedizioni")]
	protected virtual IboWebPanel pnlElencoSpedizioni
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
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdSpedizioni_MultiSelectChanged);
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

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo1_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo1_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo1_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo1_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo2_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo2_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo2_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo2_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo3_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo3_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo3_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo3_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo4_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo4_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo4_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo4_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo5_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo5_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo5_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo5_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo6_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo6_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo6_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo6_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo7_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo7_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo7_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo7_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo8_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo8_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo8_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo8_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo9_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo9_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo9_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo9_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo10_Caption")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo10_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_CampoCalcolo10_Value")]
	protected virtual IboWebLabel footerSpedizioni_CampoCalcolo10_Value
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

	[field: AccessedThroughProperty("footerSpedizioni_TotSpedizioni_Caption")]
	protected virtual IboWebLabel footerSpedizioni_TotSpedizioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioni_TotSpedizioni_Value")]
	protected virtual IboWebLabel footerSpedizioni_TotSpedizioni_Value
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

	protected virtual IboWebLinkButton lnkElencoSpedizioniCaption
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoSpedizioniCaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoSpedizioniCaption;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoSpedizioniCaption = value;
			val = _lnkElencoSpedizioniCaption;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblElencoConsegneCaption")]
	protected virtual IboWebLabel lblElencoConsegneCaption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebLinkButton lnkElencoDestinazioniCaption2
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoDestinazioniCaption2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoDestinazioniCaption2;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoDestinazioniCaption2 = value;
			val = _lnkElencoDestinazioniCaption2;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
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
	protected virtual IboWebPanel cpGrdElencoSpedizioniRaggru
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

	protected virtual IboGridView grdSpedizioniRaggru
	{
		[CompilerGenerated]
		get
		{
			return _grdSpedizioniRaggru;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdSpedizioni_MultiSelectChanged);
			IboGridView val2 = _grdSpedizioniRaggru;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdSpedizioniRaggru = value;
			val2 = _grdSpedizioniRaggru;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
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

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo1_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo1_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo1_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo1_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo2_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo2_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo2_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo2_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo3_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo3_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo3_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo3_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo4_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo4_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo4_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo4_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo5_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo5_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo5_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo5_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo6_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo6_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo6_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo6_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo7_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo7_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo7_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo7_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo8_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo8_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo8_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo8_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo9_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo9_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo9_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo9_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo10_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo10_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_CampoCalcolo10_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_CampoCalcolo10_Value
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

	[field: AccessedThroughProperty("footerSpedizioniRaggru_TotConsegne_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru_TotConsegne_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru_TotConsegne_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru_TotConsegne_Value
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

	protected virtual IboWebLinkButton lnkElencoSpedizioniCaption2
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoSpedizioniCaption2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoSpedizioniCaption2;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoSpedizioniCaption2 = value;
			val = _lnkElencoSpedizioniCaption2;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	protected virtual IboWebLinkButton lnkElencoConsegneCaption2
	{
		[CompilerGenerated]
		get
		{
			return _lnkElencoConsegneCaption2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = lnkElencoConsegneSpedizioniCaption_Click;
			IboWebLinkButton val = _lnkElencoConsegneCaption2;
			if (val != null)
			{
				((LinkButton)val).Click -= eventHandler;
			}
			_lnkElencoConsegneCaption2 = value;
			val = _lnkElencoConsegneCaption2;
			if (val != null)
			{
				((LinkButton)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblElencoDestinazioniCaption")]
	protected virtual IboWebLabel lblElencoDestinazioniCaption
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
	protected virtual IboWebPanel cpGrdElencoSpedizioniRaggru2
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

	protected virtual IboGridView grdSpedizioniRaggru2
	{
		[CompilerGenerated]
		get
		{
			return _grdSpedizioniRaggru2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			IboGridView.MultiSelectChangedEventHandler val = new IboGridView.MultiSelectChangedEventHandler(grdSpedizioni_MultiSelectChanged);
			IboGridView val2 = _grdSpedizioniRaggru2;
			if (val2 != null)
			{
				val2.MultiSelectChanged -= val;
			}
			_grdSpedizioniRaggru2 = value;
			val2 = _grdSpedizioniRaggru2;
			if (val2 != null)
			{
				val2.MultiSelectChanged += val;
			}
		}
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

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo1_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo1_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo1_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo1_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo2_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo2_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo2_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo2_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo3_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo3_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo3_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo3_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo4_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo4_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo4_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo4_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo5_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo5_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo5_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo5_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo6_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo6_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo6_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo6_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo7_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo7_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo7_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo7_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo8_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo8_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo8_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo8_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo9_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo9_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo9_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo9_Value
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo10_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo10_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_CampoCalcolo10_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_CampoCalcolo10_Value
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

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_TotDestinazioni_Caption")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_TotDestinazioni_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("footerSpedizioniRaggru2_TotDestinazioni_Value")]
	protected virtual IboWebLabel footerSpedizioniRaggru2_TotDestinazioni_Value
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

	[field: AccessedThroughProperty("lblDataViaggioCambia")]
	protected virtual IboWebLabel lblDataViaggioCambia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataViaggioCambia")]
	protected virtual IboWebDate2 DataViaggioCambia
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataSpedizioneCambiaDa")]
	protected virtual IboWebLabel lblDataSpedizioneCambiaDa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataSpedizioneCambiaDa")]
	protected virtual IboWebDate2 DataSpedizioneCambiaDa
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataSpedizioneCambiaA")]
	protected virtual IboWebLabel lblDataSpedizioneCambiaA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataSpedizioneCambiaA")]
	protected virtual IboWebDate2 DataSpedizioneCambiaA
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

	[field: AccessedThroughProperty("lblTipoViaggio")]
	protected virtual IboWebLabel lblTipoViaggio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TipoViaggio")]
	protected virtual IboWebComboTlk TipoViaggio
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

	[field: AccessedThroughProperty("TipoSpedizione")]
	protected virtual IboWebComboTlk TipoSpedizione
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

	[field: AccessedThroughProperty("TipoMerce")]
	protected virtual IboWebComboTlk TipoMerce
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

	[field: AccessedThroughProperty("lblMotricePianificata")]
	protected virtual IboWebLabel lblMotricePianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MotricePianificata")]
	protected virtual IboWebComboTlk MotricePianificata
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblContenitore1Pianificato")]
	protected virtual IboWebLabel lblContenitore1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Contenitore1Pianificato")]
	protected virtual IboWebComboTlk Contenitore1Pianificato
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected PlanGridFilter FilterViaggi => _FilterViaggi;

	protected PlanGridFilter FilterSpedizioni => _FilterSpedizioni;

	protected PlanGridFilter FilterSpedizioniRaggru => _FilterSpedizioniRaggru;

	protected PlanGridFilter FilterSpedizioniRaggru2 => _FilterSpedizioniRaggru2;

	public WFPIAPianificazioneViaggi()
	{
		_Filtro = "";
		_FiltroQueryString = "";
		_FiltroUtente = "";
		_CaptionQueryString = "";
		_AutoSelect = false;
		_TopSelect = 999;
		kFormatoSommaPeso = "0";
		kFormatoSommaVolume = "0";
		kFormatoSommaCC = "0.00";
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		_Context = "PIANIFICAZIONE_VIAGGI";
		_Tabella = "";
		_PersistedSessionVariableEnabled = true;
		_Title = TranslateMessage("XXX", "Cruscotto Viaggi");
		if (!((Page)this).IsPostBack)
		{
			string text = ((Page)this).Request.QueryString["ResetSelection"] ?? "";
			if (Operators.CompareString(text, "S", false) == 0)
			{
				_PersistedSessionVariable["FILTROVIAGGI"] = (object)"";
				_PersistedSessionVariable["VIAGGI_SELECTEDITEMS"] = (object)"";
			}
			if (_PersistedSessionVariable.ContainsKey("DATAVIAGGIO"))
			{
				_DataVia = (DateTime?)_PersistedSessionVariable["DATAVIAGGIO"];
			}
			_SessionVariable["DATAVIAGGIO"] = (object)_DataVia;
			text = ((Page)this).Request.QueryString["DaData"] ?? "";
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = "0";
			}
			if (_PersistedSessionVariable.ContainsKey("DA_DATA"))
			{
				if (Information.IsDate(RuntimeHelpers.GetObjectValue(_PersistedSessionVariable["DA_DATA"])))
				{
					_DaData = Conversions.ToDate(_PersistedSessionVariable["DA_DATA"]);
				}
				else
				{
					_DaData = DateAndTime.DateAdd((DateInterval)4, (double)Conversions.ToInteger(text), DateAndTime.Now.Date);
				}
			}
			else
			{
				_DaData = DateAndTime.DateAdd((DateInterval)4, (double)Conversions.ToInteger(text), DateAndTime.Now.Date);
			}
			_SessionVariable["DA_DATA"] = (object)_DaData;
			text = ((Page)this).Request.QueryString["aData"] ?? "";
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = "2";
			}
			if (_PersistedSessionVariable.ContainsKey("A_DATA"))
			{
				if (Information.IsDate(RuntimeHelpers.GetObjectValue(_PersistedSessionVariable["A_DATA"])))
				{
					_AData = Conversions.ToDate(_PersistedSessionVariable["A_DATA"]);
				}
				else
				{
					_AData = DateAndTime.DateAdd((DateInterval)4, (double)Conversions.ToInteger(text), DateAndTime.Now.Date);
				}
			}
			else
			{
				_AData = DateAndTime.DateAdd((DateInterval)4, (double)Conversions.ToInteger(text), DateAndTime.Now.Date);
			}
			_SessionVariable["A_DATA"] = (object)_AData;
			_Filtro = GeneraFiltroData();
			_FiltroQueryString = ((Page)this).Request.QueryString["Filter"] ?? "";
			_FiltroUtente = (((Page)this).Request.QueryString["UserFilter"] ?? "").ToUpper();
			_CaptionQueryString = ((Page)this).Request.QueryString["Caption"] ?? "";
			_AutoSelect = Operators.CompareString(((Page)this).Request.QueryString["AutoSelect"] ?? "", "S", false) == 0;
			if (Operators.CompareString(((Page)this).Request.QueryString["TopSelect"] ?? "", "", false) == 0)
			{
				_TopSelect = 200;
			}
			else
			{
				_TopSelect = Conversions.ToInteger(((Page)this).Request.QueryString["TopSelect"] ?? "");
			}
			_SessionVariable["FILTRO_QUERYSTRING"] = (object)_FiltroQueryString;
			_SessionVariable["FILTRO_UTENTE"] = (object)_FiltroUtente;
			_SessionVariable["CAPTION_QUERYSTRING"] = (object)_CaptionQueryString;
			_SessionVariable["TOP_SELECT"] = (object)_TopSelect;
			_SessionVariable["AUTOSELECT"] = (object)_AutoSelect;
			if (Operators.CompareString(_FiltroQueryString, "", false) != 0)
			{
				ref string filtro = ref _Filtro;
				filtro = filtro + " AND (" + _FiltroQueryString + ") ";
			}
			if (Operators.CompareString(_FiltroUtente, "S", false) == 0 && Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro ?? "", "", false) != 0)
			{
				ref string filtro2 = ref _Filtro;
				filtro2 = filtro2 + " AND (" + base.SessionEnvironment.WebUser.WebUserInfo.Filtro + ") ";
			}
			if (Operators.CompareString(_CaptionQueryString, "", false) != 0)
			{
				ref string title = ref _Title;
				title = title + " (" + _CaptionQueryString + ")";
			}
			_SessionVariable["FILTRO"] = (object)_Filtro;
		}
		else
		{
			_Filtro = _SessionVariable["FILTRO"].ToString();
			_DaData = Conversions.ToDate(_SessionVariable["DA_DATA"]);
			_AData = Conversions.ToDate(_SessionVariable["A_DATA"]);
			_DataVia = (DateTime?)_SessionVariable["DATAVIAGGIO"];
			_FiltroQueryString = _SessionVariable["FILTRO_QUERYSTRING"].ToString();
			_FiltroUtente = _SessionVariable["FILTRO_UTENTE"].ToString().ToUpper();
			_CaptionQueryString = _SessionVariable["CAPTION_QUERYSTRING"].ToString();
			_AutoSelect = Conversions.ToBoolean(_SessionVariable["AUTOSELECT"]);
			_TopSelect = Conversions.ToInteger(_SessionVariable["TOP_SELECT"]);
		}
		if (_DataVia.HasValue)
		{
			DataViaggio.ObjValue = Strings.Format((object)_DataVia, "dd/MM/yyyy");
			btnGotoNextDateViaggio.Visible = true;
			btnGotoPreviousDateViaggio.Visible = true;
		}
		else
		{
			DataViaggio.ObjValue = "non definita";
			btnGotoNextDateViaggio.Visible = false;
			btnGotoPreviousDateViaggio.Visible = false;
		}
		DataSpedizioneDa.ObjValue = Strings.Format((object)_DaData, "dd/MM/yyyy");
		DataSpedizioneA.ObjValue = Strings.Format((object)_AData, "dd/MM/yyyy");
		if (!((Page)this).IsPostBack)
		{
			string text2 = ((Page)this).Request.QueryString["InitialGrid"] ?? "";
			if (Operators.CompareString(text2, "C", false) == 0)
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
		InitGridFilterSystemViaggi();
		InitGridFilterSystem();
		InitGridFilterSystemRaggru();
		InitGridFilterSystemRaggru2();
		FXRETURN result = base.InitializedPage(ref rsMess);
		((GridView)grdViaggi).Sorting += new GridViewSortEventHandler(grdViaggi_Sorting);
		((GridView)grdSpedizioni).Sorting += new GridViewSortEventHandler(grdSpedizioni_Sorting);
		((GridView)grdSpedizioniRaggru).Sorting += new GridViewSortEventHandler(grdSpedizioniRaggru_Sorting);
		((GridView)grdSpedizioniRaggru2).Sorting += new GridViewSortEventHandler(grdSpedizioniRaggru2_Sorting);
		base.btnAnnulla = btnAnnulla;
		base.btnConferma = btnConferma;
		base.lblDataAccessMode = lblDataAccessMode;
		return result;
	}

	protected override FXRETURN InitializeInternalGrid(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Invalid comparison between Unknown and I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
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
			IboGridView objGridView = grdViaggi;
			iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
			grdViaggi = objGridView;
			text = GeneraQueryViaggi();
			iboInternalGridConfig.Build("DM.DOC.VIAGGI#PV", text, "", "", ((Control)grdViaggi).ID, ((Control)tlbElencoViaggi).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig3 = iboInternalGridConfig;
			StateBag myViewState2 = base.MyViewState;
			objGridView = grdSpedizioniViaggio;
			iboInternalGridConfig3.InitUi(myViewState2, ref objGridView);
			grdSpedizioniViaggio = objGridView;
			string ssqlFiltroViaggi = "";
			if (_PersistedSessionVariable.ContainsKey("FILTROVIAGGI"))
			{
				ssqlFiltroViaggi = _PersistedSessionVariable["FILTROVIAGGI"].ToString();
			}
			text = GeneraQuerySpedizioniViaggio(ssqlFiltroViaggi);
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PV_VIA", text, "", "", ((Control)grdSpedizioniViaggio).ID, ((Control)tlbElencoSpedizioniViaggio).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig4 = iboInternalGridConfig;
			StateBag myViewState3 = base.MyViewState;
			objGridView = grdSpedizioniRaggruViaggio;
			iboInternalGridConfig4.InitUi(myViewState3, ref objGridView);
			grdSpedizioniRaggruViaggio = objGridView;
			text = GeneraQuerySpedizioniRaggruViaggio("'000'");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PV_VIA_RAGGR", text, "", "", ((Control)grdSpedizioniRaggruViaggio).ID, ((Control)tlbElencoSpedizioniRaggruViaggio).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig5 = iboInternalGridConfig;
			StateBag myViewState4 = base.MyViewState;
			objGridView = grdSpedizioni;
			iboInternalGridConfig5.InitUi(myViewState4, ref objGridView);
			grdSpedizioni = objGridView;
			ssqlFiltroViaggi = "";
			text = GeneraQuerySpedizioni(ssqlFiltroViaggi);
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PV", text, "", "", ((Control)grdSpedizioni).ID, ((Control)tlbElencoSpedizioni).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig6 = iboInternalGridConfig;
			StateBag myViewState5 = base.MyViewState;
			objGridView = grdSpedizioniRaggru;
			iboInternalGridConfig6.InitUi(myViewState5, ref objGridView);
			grdSpedizioniRaggru = objGridView;
			text = GeneraQuerySpedizioniRaggru("1=1");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PV_RAGGRU", text, "", "", ((Control)grdSpedizioniRaggru).ID, ((Control)tlbElencoSpedizioniRaggru).ID);
			GridConfigList.Add(iboInternalGridConfig);
			iboInternalGridConfig = new IboInternalGridConfig();
			IboInternalGridConfig iboInternalGridConfig7 = iboInternalGridConfig;
			StateBag myViewState6 = base.MyViewState;
			objGridView = grdSpedizioniRaggru2;
			iboInternalGridConfig7.InitUi(myViewState6, ref objGridView);
			grdSpedizioniRaggru2 = objGridView;
			text = GeneraQuerySpedizioniRaggru2("1=1");
			iboInternalGridConfig.Build("DM.DOC.SPEDIZIONI#PV_RAGGRU2", text, "", "", ((Control)grdSpedizioniRaggru2).ID, ((Control)tlbElencoSpedizioniRaggru2).ID);
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
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			PerformanceLogAppend("PRERENDERPAGE BEGIN");
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
			Init_GridFooters();
			val = base.PreRenderPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				PerformanceLogAppend("PRERENDERPAGE END");
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

	protected override FXRETURN UnloadPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.UnloadPage(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_SessionVariable != null)
				{
					_PersistedSessionVariable["DA_DATA"] = RuntimeHelpers.GetObjectValue(_SessionVariable["DA_DATA"]);
					_PersistedSessionVariable["A_DATA"] = RuntimeHelpers.GetObjectValue(_SessionVariable["A_DATA"]);
					_PersistedSessionVariable["DATAVIAGGIO"] = RuntimeHelpers.GetObjectValue(_SessionVariable["DATAVIAGGIO"]);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val = base.AfterLoadData(ref rsMess);
			IboInternalGridConfig iboInternalGridConfig;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				iboInternalGridConfig = new IboInternalGridConfig();
				IboInternalGridConfig iboInternalGridConfig2 = iboInternalGridConfig;
				StateBag myViewState = base.MyViewState;
				IboGridView objGridView = grdSpedizioniViaggio;
				iboInternalGridConfig2.InitUi(myViewState, ref objGridView);
				grdSpedizioniViaggio = objGridView;
				if (!_PersistedSessionVariable.ContainsKey("FILTROVIAGGI") || Operators.CompareString(_PersistedSessionVariable["FILTROVIAGGI"].ToString(), "", false) == 0)
				{
					goto IL_00ca;
				}
				val = SelezionaViaggio(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AggiornaTotaliGriglia(ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_00ca;
					}
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_00ca:
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			if (iboInternalGridConfig.DataTable != null)
			{
				footerSpedizioni_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
			}
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			if (iboInternalGridConfig.DataTable != null)
			{
				footerSpedizioniRaggru_TotConsegne_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
			}
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
			if (iboInternalGridConfig.DataTable != null)
			{
				footerSpedizioniRaggru2_TotDestinazioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
			}
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniViaggio).ID];
			if (iboInternalGridConfig.DataTable != null)
			{
				footerSpedizioniViaggio_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
			}
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID];
			if (iboInternalGridConfig.DataTable != null)
			{
				footerSpedizioniRaggruViaggio_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
			}
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void grdSpedizioni_MultiSelectChanged(object sender, EventArgs e)
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

	private void grdSpedizioniRaggruViaggio_MultiSelectChanged(object sender, EventArgs e)
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

	private void grdViaggi_MultiSelectChanged(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		DataKeyFieldCollection robjData = new DataKeyFieldCollection();
		DataKeyFieldValues[] robjKey = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdViaggi).ID];
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
			string text2 = "";
			hdnIdViaggioSelezionato.Value = "";
			checked
			{
				if (robjData.Count > 0)
				{
					hdnIdViaggioSelezionato.Value = robjData.Item(0).get_FieldValues(0).ToString();
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (i < robjData[0].FieldValuesCount - 1)
						{
							text = text + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString()) + ",";
							text2 = text2 + robjData.Item(0).get_FieldValues(i).ToString() + ",";
						}
						else
						{
							text += base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString());
							text2 += robjData.Item(0).get_FieldValues(i).ToString();
						}
					}
				}
				_PersistedSessionVariable["FILTROVIAGGI"] = (object)text;
				_PersistedSessionVariable["VIAGGI_SELECTEDITEMS"] = (object)text2;
				upElencoSpedizioniViaggio.Update();
				val = AggiornaElencoSpedizioniViaggio(ref rsMess);
			}
			if ((int)val > 0)
			{
				val2 = val;
				return;
			}
			if (_AutoSelect)
			{
				grdSpedizioniViaggio.SelectAllRows();
			}
			val2 = (FXRETURN)0;
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

	private void grdViaggi_Sorting(object sender, GridViewSortEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string text = "";
		try
		{
			lblFilterActiveFieldViaggi.ObjValue = "";
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdViaggi).ID];
			string text2 = "System." + iboInternalGridConfig.GridInfo.CampoAttivoTipo;
			if ((Operators.CompareString(text2, typeof(int).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(long).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(short).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(double).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(float).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(decimal).ToString(), false) == 0))
			{
				ddlFilterOperatorViaggi.ObjValue = "gt";
				FilterDateViaggi.Visible = false;
				FilterTextViaggi.Visible = false;
				FilterNumberViaggi.Visible = true;
			}
			else if ((Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0) | (Operators.CompareString(text2, typeof(DateTime).ToString(), false) == 0))
			{
				ddlFilterOperatorViaggi.ObjValue = "=";
				FilterDateViaggi.Visible = true;
				FilterTextViaggi.Visible = false;
				FilterNumberViaggi.Visible = false;
			}
			else
			{
				ddlFilterOperatorViaggi.ObjValue = "LIKE";
				FilterDateViaggi.Visible = false;
				FilterTextViaggi.Visible = true;
				FilterNumberViaggi.Visible = false;
			}
			FilterViaggi.SaveContext(iboInternalGridConfig.GridInfo.CampoAttivo, iboInternalGridConfig.GridInfo.CampoAttivoDescrizione, iboInternalGridConfig.GridInfo.CampoAttivoTipo);
			lblFilterActiveFieldViaggi.ObjValue = iboInternalGridConfig.GridInfo.CampoAttivoDescrizione;
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsmess = "";
		try
		{
			val2 = Aggiorna(ref rsmess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
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
			CallStackRemove();
			if ((int)val > 0)
			{
				WriteErrorMessage(rsmess);
			}
		}
	}

	private void btnCambiaDataSpedizione_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (_DataVia.HasValue)
			{
				DataViaggioCambia.DateValue = _DataVia.Value;
			}
			DataSpedizioneCambiaDa.DateValue = _DaData;
			DataSpedizioneCambiaA.DateValue = _AData;
			DataViaggioCambia.Focus();
			MasterPopupFormOpen("Cambia Date", (Control)(object)pnlCambiaData, "CAMBIADATA");
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

	private void btnGotoNextDateDa_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = CambiaData(_DaData.AddDays(1.0), _AData, ref rsMess);
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
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = CambiaData(_DaData.AddDays(-1.0), _AData, ref rsMess);
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

	private void btnGotoNextDateA_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = CambiaData(_DaData, _AData.AddDays(1.0), ref rsMess);
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

	private void btnGotoPreviousDateA_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			val2 = CambiaData(_DaData, _AData.AddDays(-1.0), ref rsMess);
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

	private void btnGotoPreviousDateViaggio_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (_DataVia.HasValue)
			{
				val2 = CambiaDataViaggi(_DataVia.Value.AddDays(-1.0), ref rsMess);
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

	private void btnGotoNextDateViaggio_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			if (_DataVia.HasValue)
			{
				val2 = CambiaDataViaggi(_DataVia.Value.AddDays(1.0), ref rsMess);
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

	private void grdSpedizioniViaggio_MultiSelectChanged(object sender, EventArgs e)
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

	private void lnkElencoConsengeViaggioCaption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			rsMess = "";
			lnkElencoConsengeViaggioCaption.Enabled = false;
			lnkElencoSpedizioniViaggioCaption.Enabled = true;
			((Control)cpGrdElencoSpedizioniRaggruViaggio).Visible = true;
			((Control)cpGrdElencoSpedizioniViaggio).Visible = false;
			((Control)tlbElencoSpedizioniViaggio).Visible = false;
			((Control)tlbElencoSpedizioniRaggruViaggio).Visible = true;
			((Control)footerElencoSpedizioniRaggruViaggio).Visible = true;
			((Control)footerElencoSpedizioniViaggio).Visible = false;
			val = AggiornaElencoSpedizioniViaggio(ref rsMess);
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
			CallStackRemove();
		}
	}

	private void lnkElencoSpedizioniViaggioCaption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			CallStackAdd();
			rsMess = "";
			lnkElencoConsengeViaggioCaption.Enabled = true;
			lnkElencoSpedizioniViaggioCaption.Enabled = false;
			((Control)cpGrdElencoSpedizioniRaggruViaggio).Visible = false;
			((Control)cpGrdElencoSpedizioniViaggio).Visible = true;
			((Control)tlbElencoSpedizioniViaggio).Visible = true;
			((Control)tlbElencoSpedizioniRaggruViaggio).Visible = false;
			((Control)footerElencoSpedizioniRaggruViaggio).Visible = false;
			((Control)footerElencoSpedizioniViaggio).Visible = true;
			val = AggiornaElencoSpedizioniViaggio(ref rsMess);
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
			CallStackRemove();
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
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(((Control)tlb).ID, ((Control)tlbElencoViaggi).ID, false) == 0)
			{
				object objParams = "";
				val2 = CancellaViaggio(ref objParams, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0077;
				}
				val = val2;
			}
			else
			{
				val2 = base.InternalGridCancella(ref tlb, ref objInternalGridConfig, ref funcArg, ref e, ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_0077;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_0077:
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
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Invalid comparison between Unknown and I4
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Invalid comparison between Unknown and I4
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Invalid comparison between Unknown and I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Invalid comparison between Unknown and I4
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_0633;
				}
				if (Operators.CompareString(text, "GESTISCISEQUENZA", false) == 0)
				{
					if (Operators.CompareString(hdnIdViaggioSelezionato.Value, "", false) == 0)
					{
						goto IL_0633;
					}
					Viaggio_DeterminaSequenzaSpedizioni_Invoker instance = Viaggio_DeterminaSequenzaSpedizioni_Invoker.Instance;
					AppApiContext objApiContext = CreateApiContext();
					string value = hdnIdViaggioSelezionato.Value;
					string RetQueryToApply = "";
					val2 = instance.RunProc(objApiContext, value, ApplyQuery: true, ref RetQueryToApply, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						string[] CampiChiave = new string[1] { "IdViaggio" };
						object[] ValoriCampiChiave = new object[1] { hdnIdViaggioSelezionato.Value };
						val2 = OpenDbPageInIFrame(ref CampiChiave, ref ValoriCampiChiave, "GESTISCISEQUENZA", base.Translator.Translate("XXX", "Gestione della sequenza delle spedizioni (Viaggio: " + hdnIdViaggioSelezionato.Value + ")", new string[0]), WFIMaster.IFrameDimension.IFrameContainerCustomDefinition, "IFrameDimension_GestioneSequenza", "DM.DOC.GESTIONE_SEQUENZA", "MODIFICA", ref rsMess);
						if ((int)val2 <= 0)
						{
							SetIframeHeightAutoResize();
							goto IL_0633;
						}
						val = val2;
					}
				}
				else
				{
					if (((Operators.CompareString(objInternalGridConfig.Id, ((Control)grdViaggi).ID, false) == 0) & (Operators.CompareString(text, "CREAVIAGGIO", false) == 0)) || funcArg.Data.Count != 0)
					{
						switch (text)
						{
						case "AGGIUNGITRANSITPOINT":
						{
							IboWebComboTlk corrispondente = Corrispondente;
							string RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)corrispondente, "", ref RetQueryToApply);
							if ((Operators.CompareString(objInternalGridConfig.Id, ((Control)grdSpedizioniViaggio).ID, false) == 0) | (Operators.CompareString(objInternalGridConfig.Id, ((Control)grdSpedizioniRaggruViaggio).ID, false) == 0))
							{
								MasterPopupFormOpen("Aggiungi Transit Point", (Control)(object)pnlCorrispondente, "AGGIUNGITRANSITPOINT_VIA");
							}
							else
							{
								MasterPopupFormOpen("Aggiungi Transit Point", (Control)(object)pnlCorrispondente, "AGGIUNGITRANSITPOINT");
							}
							break;
						}
						case "ELIMINATRANSITPOINT":
						{
							object obj = null;
							obj = ((!((Operators.CompareString(objInternalGridConfig.Id, ((Control)grdSpedizioniViaggio).ID, false) == 0) | (Operators.CompareString(objInternalGridConfig.Id, ((Control)grdSpedizioniRaggruViaggio).ID, false) == 0))) ? "SPE" : "VIA");
							val2 = EliminaTransitPoint(ref obj, ref rsMess);
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
							string RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)zonaSpedizione, "", ref RetQueryToApply);
							MasterPopupFormOpen("Cambia Zona Spedizione", (Control)(object)pnlZonaSpedizione, "CAMBIAZONASPEDIZIONE");
							break;
						}
						case "CREAVIAGGIO":
						{
							IboWebComboTlk vettore = Vettore;
							string RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)vettore, "", ref RetQueryToApply);
							IboWebComboTlk pCSPartenza = PCSPartenza;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)pCSPartenza, "", ref RetQueryToApply);
							IboWebComboTlk pCSArrivo = PCSArrivo;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)pCSArrivo, "", ref RetQueryToApply);
							IboWebComboTlk tipoSpedizione = TipoSpedizione;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)tipoSpedizione, "", ref RetQueryToApply);
							IboWebComboTlk tipoMerce = TipoMerce;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)tipoMerce, "", ref RetQueryToApply);
							IboWebComboTlk tipoViaggio = TipoViaggio;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)tipoViaggio, "", ref RetQueryToApply);
							IboWebComboTlk contenitore1Pianificato = Contenitore1Pianificato;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)contenitore1Pianificato, "", ref RetQueryToApply);
							IboWebComboTlk motricePianificata = MotricePianificata;
							RetQueryToApply = "";
							ComboSelectedItem((IIboDropdownList)(object)motricePianificata, "", ref RetQueryToApply);
							if (_DataVia.HasValue)
							{
								DataPartenzaPianificata.DateValue = _DataVia.Value;
							}
							if (Operators.CompareString(objInternalGridConfig.Id, ((Control)grdViaggi).ID, false) == 0)
							{
								MasterPopupFormOpen(TranslateMessage("XXX", "Crea Viaggio"), (Control)(object)pnlViaggio, "CREAVIAGGIO");
							}
							else
							{
								MasterPopupFormOpen(TranslateMessage("XXX", "Crea Viaggio"), (Control)(object)pnlViaggio, "CREAVIAGGIO_SPED");
							}
							break;
						}
						case "ASSOCIAVIAGGIO":
						{
							object objParams = "";
							val2 = AssociaSpedizioni(ref objParams, ref rsMess);
							if ((int)val2 <= 0)
							{
								break;
							}
							val = val2;
							goto end_IL_0012;
						}
						case "DISASSOCIA":
						{
							object objParams = "";
							val2 = DisassociaSpedizioni(ref objParams, ref rsMess);
							if ((int)val2 <= 0)
							{
								break;
							}
							val = val2;
							goto end_IL_0012;
						}
						}
						goto IL_0633;
					}
					rsMess = TranslateMessage("XXX", "Selezionare almeno 1 record");
				}
			}
			goto end_IL_0012;
			IL_0633:
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

	private FXRETURN AggiornaTutteLeGriglie(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = AggiornaElencoViaggi(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = AggiornaElencoSpedizioniViaggio(ref rsMess);
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
							val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
						}
					}
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

	private FXRETURN AggiornaElencoViaggi(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdViaggi).ID];
			text = GeneraQueryViaggi();
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				upElencoViaggi.Update();
				bool flag = false;
				int num = default(int);
				foreach (DataRow row in objInternalGridConfig.DataTable.Rows)
				{
					if (Operators.CompareString(row["IdViaggio"].ToString(), hdnIdViaggioSelezionato.Value, false) == 0)
					{
						flag = true;
						break;
					}
					num = checked(num + 1);
				}
				if (flag)
				{
					grdViaggi.SelectRow(num);
				}
				else
				{
					hdnIdViaggioSelezionato.Value = "";
					_PersistedSessionVariable["FILTROVIAGGI"] = (object)"";
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

	private FXRETURN AggiornaElencoSpedizioniViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string ssqlFiltroViaggi = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (_PersistedSessionVariable.ContainsKey("FILTROVIAGGI"))
			{
				ssqlFiltroViaggi = _PersistedSessionVariable["FILTROVIAGGI"].ToString();
			}
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniViaggio).ID];
			objInternalGridConfig.SqlOriginalStatement = GeneraQuerySpedizioniViaggio(ssqlFiltroViaggi);
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (objInternalGridConfig.DataTable != null)
				{
					footerSpedizioniViaggio_TotSpedizioni_Value.ObjValue = objInternalGridConfig.DataTable.Rows.Count;
				}
				objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID];
				objInternalGridConfig.SqlOriginalStatement = GeneraQuerySpedizioniRaggruViaggio(ssqlFiltroViaggi);
				val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (objInternalGridConfig.DataTable != null)
					{
						footerSpedizioniRaggruViaggio_TotSpedizioni_Value.ObjValue = objInternalGridConfig.DataTable.Rows.Count;
					}
					upElencoSpedizioniViaggio.Update();
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

	private FXRETURN AggiornaElencoSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string ssqlFiltroZone = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioni BEGIN");
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
			text = GeneraQuerySpedizioni(ssqlFiltroZone);
			objInternalGridConfig.SqlOriginalStatement = text;
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (_AutoSelect)
				{
					grdSpedizioni.SelectAllRows();
				}
				upElencoSpedizioni.Update();
				objInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
				if (objInternalGridConfig.DataTable != null)
				{
					footerSpedizioni_TotSpedizioni_Value.ObjValue = objInternalGridConfig.DataTable.Rows.Count;
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
			PerformanceLogAppend("AggiornaElencoSpedizioni END");
			CallStackRemove();
			result = val;
		}
		return result;
	}

	private FXRETURN AggiornaElencoSpedizioniRaggru(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru BEGIN");
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
			text = GeneraQuerySpedizioniRaggru("1=1");
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (_AutoSelect)
				{
					grdSpedizioniRaggru.SelectAllRows();
				}
				upElencoSpedizioni.Update();
				if (objInternalGridConfig.DataTable != null)
				{
					footerSpedizioniRaggru_TotConsegne_Value.ObjValue = objInternalGridConfig.DataTable.Rows.Count;
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
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			CallStackAdd();
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru2 BEGIN");
			IboInternalGridConfig objInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
			text = GeneraQuerySpedizioniRaggru2("1=1");
			objInternalGridConfig.SqlOriginalStatement = text;
			string rsMess2 = "";
			val2 = InternalGridAggiornaSingola(ref objInternalGridConfig, ref rsMess2);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (_AutoSelect)
				{
					grdSpedizioniRaggru2.SelectAllRows();
				}
				upElencoSpedizioni.Update();
				if (objInternalGridConfig.DataTable != null)
				{
					footerSpedizioniRaggru2_TotDestinazioni_Value.ObjValue = objInternalGridConfig.DataTable.Rows.Count;
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
			PerformanceLogAppend("AggiornaElencoSpedizioniRaggru2 END");
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public override FXRETURN Aggiorna(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			val = AggiornaElencoViaggi(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				upElencoViaggi.Update();
				val = AggiornaElencoSpedizioniViaggio(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					upElencoSpedizioniViaggio.Update();
					val = SelezionaViaggio(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = AggiornaElencoSpedizioni(ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							val = AggiornaElencoSpedizioniRaggru(ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								val = AggiornaElencoSpedizioniRaggru2(ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
								}
								else
								{
									upElencoSpedizioni.Update();
									val = AggiornaTotaliGriglia(ref rsmess);
									val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private FXRETURN SelezionaViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			string[] source = new string[0];
			if (_PersistedSessionVariable.ContainsKey("VIAGGI_SELECTEDITEMS"))
			{
				source = _PersistedSessionVariable["VIAGGI_SELECTEDITEMS"].ToString().ToUpper()
					.Split(new char[1] { ',' });
			}
			IboInternalGridConfig iboInternalGridConfig = GridConfigList[((Control)grdViaggi).ID];
			List<int> list = new List<int>();
			int num = 0;
			foreach (DataRow row in iboInternalGridConfig.DataTable.Rows)
			{
				if (source.Contains(row["IdViaggio"].ToString().ToUpper()))
				{
					list.Add(num);
				}
				num = checked(num + 1);
			}
			foreach (int item in list)
			{
				grdViaggi.SelectRow(item);
			}
			upElencoViaggi.Update();
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected FXRETURN FindUnibolFromGrdConsegne(DataKeyFieldCollection objData, ref List<string> ListOfUnibol, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (ListOfUnibol == null)
			{
				ListOfUnibol = new List<string>();
			}
			int num = checked(objData[0].FieldValuesCount - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					string[] array = objData.Item(0).get_FieldValues(num2).ToString()
						.Split(new char[1] { ';' });
					string text = "";
					DataTable dataTable = null;
					text = "SELECT Unibol FROM Spedizioni WHERE IdViaggio=" + base.DbConn.SQLFormatString(array[0]) + " ";
					text = text + "AND SequenzaPianificata=" + base.DbConn.SQLFormatNumber(ref array[3]);
					val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
						break;
					}
					foreach (DataRow row in dataTable.Rows)
					{
						ListOfUnibol.Add(row["Unibol"].ToString());
					}
					num2 = checked(num2 + 1);
					continue;
				}
				val2 = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	public void InitGridFilterSystemViaggi()
	{
		if (!_SessionVariable.ContainsKey("FILTERVIAGGI"))
		{
			ddlFilterOperator.ObjValue = "LIKE";
			_FilterViaggi = new PlanGridFilter(base.DbConn);
			_FilterViaggi.Id = ((Control)grdSpedizioni).ID;
			_SessionVariable.Add("FILTERVIAGGI", _FilterViaggi);
		}
		else
		{
			_FilterViaggi = (PlanGridFilter)_SessionVariable["FILTERVIAGGI"];
		}
		if (!((Page)this).IsPostBack)
		{
			ddlFilterOperatorViaggi.ObjValue = "LIKE";
			lblFilterActiveFieldViaggi.ObjValue = "Id Viaggio";
			FilterDateViaggi.Visible = false;
			FilterTextViaggi.Visible = true;
			FilterNumberViaggi.Visible = false;
			FilterViaggi.SaveContext("IdViaggio", "Id Viaggio", typeof(string).ToString());
		}
	}

	protected void GridSearchViaggi(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Invalid comparison between Unknown and I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			if (FilterTextViaggi.Visible)
			{
				if (!ddlFilterOperatorViaggi.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterTextViaggi.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterViaggi.AddFilter(ddlFilterOperatorViaggi.ObjValue.ToString(), FilterTextViaggi.ObjValue.ToString());
			}
			else if (FilterDateViaggi.Visible)
			{
				if (!ddlFilterOperatorViaggi.ObjValue.ToString().Contains("NULL") && !Information.IsDate(RuntimeHelpers.GetObjectValue(FilterDateViaggi.ObjValue)))
				{
					return;
				}
				FilterViaggi.AddFilter(ddlFilterOperatorViaggi.ObjValue.ToString(), FilterDateViaggi.ObjValue.ToString());
			}
			else if (FilterNumberViaggi.Visible)
			{
				if (!ddlFilterOperatorViaggi.ObjValue.ToString().Contains("NULL") && Operators.CompareString(FilterNumberViaggi.ObjValue.ToString(), "", false) == 0)
				{
					return;
				}
				FilterViaggi.AddFilter(ddlFilterOperatorViaggi.ObjValue.ToString(), RuntimeHelpers.GetObjectValue(FilterNumberViaggi.ObjValue));
			}
			FilterTextViaggi.ToolTip = FilterViaggi.FilterExpressionHR;
			FilterDateViaggi.Tooltip = FilterViaggi.FilterExpressionHR;
			FilterNumberViaggi.ToolTip = FilterViaggi.FilterExpressionHR;
			val = AggiornaElencoViaggi(ref rsMess);
			if ((int)val <= 0)
			{
				val = AggiornaElencoSpedizioniViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					FilterTextViaggi.Clear();
					FilterDateViaggi.Clear();
					FilterNumberViaggi.ObjValue = 0;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
		}
	}

	protected void GridFilterResetViaggi(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		try
		{
			FilterViaggi.Reset();
			FilterTextViaggi.ToolTip = FilterViaggi.FilterExpressionHR;
			FilterDateViaggi.Tooltip = FilterViaggi.FilterExpressionHR;
			FilterNumberViaggi.ToolTip = FilterViaggi.FilterExpressionHR;
			val2 = AggiornaElencoViaggi(ref rsMess);
			if ((int)val > 0)
			{
				val = val2;
				return;
			}
			val2 = AggiornaElencoSpedizioniViaggio(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			FilterTextViaggi.Clear();
			FilterDateViaggi.Clear();
			FilterNumberViaggi.ObjValue = 0;
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
		}
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
				FilterSpedizioni.AddFilter(ddlFilterOperator.ObjValue.ToString(), FilterDate.ObjValue.ToString());
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
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Invalid comparison between Unknown and I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Invalid comparison between Unknown and I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Invalid comparison between Unknown and I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_0332;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "AGGIUNGITRANSITPOINT", false) == 0)
			{
				val = AggiungiTransitPoint("SPE", Corrispondente.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0332;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "AGGIUNGITRANSITPOINT_VIA", false) == 0)
			{
				val = AggiungiTransitPoint("VIA", Corrispondente.ObjValue.ToString(), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0332;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO", false) == 0)
			{
				val = CreaViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0332;
				}
				val2 = val;
			}
			else if (Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO_SPED", false) == 0)
			{
				val = CreaViaggioConSpedizioni(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0332;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(objPopupInfo.Tag, "CAMBIADATA", false) != 0)
				{
					goto IL_0332;
				}
				if ((Operators.CompareString(DataSpedizioneCambiaDa.ObjValue.ToString(), "", false) == 0) | (Operators.CompareString(DataSpedizioneCambiaA.ObjValue.ToString(), "", false) == 0))
				{
					rsMess = TranslateMessage("XXX", "Inserire un intervallo di date finito");
				}
				else if (DateTime.Compare(DataSpedizioneCambiaDa.getDateValue, DataSpedizioneCambiaA.getDateValue) > 0)
				{
					rsMess = TranslateMessage("XXX", "Inserire un intervallo di date corretto");
				}
				else
				{
					val = CambiaData(DataSpedizioneCambiaDa.getDateValue, DataSpedizioneCambiaA.getDateValue, ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (Operators.CompareString(DataViaggioCambia.ObjValue.ToString(), "", false) != 0)
					{
						val = CambiaDataViaggi(DataViaggioCambia.getDateValue, ref rsMess);
						if ((int)val <= 0)
						{
							btnGotoNextDateViaggio.Visible = true;
							btnGotoPreviousDateViaggio.Visible = true;
							goto IL_0332;
						}
						val2 = val;
					}
					else
					{
						val = CambiaDataViaggi(DataViaggioCambia.getDateValue2, ref rsMess);
						if ((int)val <= 0)
						{
							DataViaggio.ObjValue = "non definita";
							btnGotoNextDateViaggio.Visible = false;
							btnGotoPreviousDateViaggio.Visible = false;
							goto IL_0332;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0007;
			IL_0332:
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

	public override FXRETURN MasterPopupFormCheckData(ref WFIPopupFormInfo objPopupInfo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
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
			else if (((Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO", false) == 0) | (Operators.CompareString(objPopupInfo.Tag, "CREAVIAGGIO_SPED", false) == 0)) && (_DataVia.HasValue & (Operators.CompareString(DataViaggioCambia.ObjValue.ToString(), "", false) != 0)) && DateTime.Compare(_DataVia.Value, DataViaggioCambia.getDateValue.Date) != 0)
			{
				rsMess = TranslateMessage("XXX", "Data partenza pianificata non congruente con la data di filtro dei viaggi");
			}
			else
			{
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

	private FXRETURN AggiungiTransitPoint(string Tipo, string Corrispondente, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Invalid comparison between Unknown and I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Invalid comparison between Unknown and I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Invalid comparison between Unknown and I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Invalid comparison between Unknown and I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
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
			if (Operators.CompareString(Tipo, "VIA", false) == 0)
			{
				iboInternalGridConfig = ((!((Control)grdSpedizioniViaggio).Visible) ? GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID] : GridConfigList[((Control)grdSpedizioniViaggio).ID]);
			}
			else if (((Control)DivGrdElencoSpedizioni).Visible)
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
			List<string> ListOfUnibol;
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (robjData.Count <= 0)
				{
					goto IL_0384;
				}
				ListOfUnibol = new List<string>();
				checked
				{
					if (Operators.CompareString(((Control)iboInternalGridConfig.GridView).ID, ((Control)grdSpedizioniRaggruViaggio).ID, false) != 0)
					{
						int num = robjData[0].FieldValuesCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniViaggio).ID, false) == 0))
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
						goto IL_02cf;
					}
					val = FindUnibolFromGrdConsegne(robjData, ref ListOfUnibol, ref rsMess);
				}
				if ((int)val <= 0)
				{
					goto IL_02cf;
				}
				val2 = val;
			}
			goto end_IL_000e;
			IL_0384:
			val2 = (FXRETURN)0;
			goto end_IL_000e;
			IL_02cf:
			val = Spedizione_AggiungiTransitPoint.RunProc(CreateApiContext(), ListOfUnibol, Corrispondente, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Operators.CompareString(Tipo, "VIA", false) == 0)
			{
				val = AggiornaElencoSpedizioniViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					upElencoSpedizioniViaggio.Update();
					goto IL_0384;
				}
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
							goto IL_0384;
						}
						val2 = val;
					}
				}
			}
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
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
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
				base.SessionEnvironment.UserMessage.Parameters = RuntimeHelpers.GetObjectValue(objParams);
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Elimina Transit Point");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi l'eliminazione del Transit Point?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "EliminaTransitPoint";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_0189;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_0189;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_0189;
			}
			string tipo = base.SessionEnvironment.UserMessage.Parameters.ToString();
			base.SessionEnvironment.UserMessage.Reset();
			val2 = _EliminaTransitPoint(tipo, ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_0189;
			}
			val = val2;
			goto end_IL_0005;
			IL_0189:
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

	protected FXRETURN _EliminaTransitPoint(string Tipo, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Invalid comparison between Unknown and I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Invalid comparison between Unknown and I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Invalid comparison between Unknown and I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Invalid comparison between Unknown and I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Invalid comparison between Unknown and I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
			IboInternalGridConfig iboInternalGridConfig = null;
			if (Operators.CompareString(Tipo, "VIA", false) == 0)
			{
				iboInternalGridConfig = ((!((Control)grdSpedizioniViaggio).Visible) ? GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID] : GridConfigList[((Control)grdSpedizioniViaggio).ID]);
				goto IL_0136;
			}
			if (Operators.CompareString(Tipo, "SPE", false) == 0)
			{
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
				goto IL_0136;
			}
			rsMess = TranslateMessage("XXX", "Tipologia non riconosciuta");
			goto end_IL_0005;
			IL_03b4:
			val = (FXRETURN)0;
			goto end_IL_0005;
			IL_0300:
			List<string> ListOfUnibol;
			val2 = Spedizione_EliminaTransitPoint.RunProc(CreateApiContext(), ListOfUnibol, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(Tipo, "VIA", false) == 0)
			{
				val2 = AggiornaElencoSpedizioniViaggio(ref rsMess);
				if ((int)val2 <= 0)
				{
					upElencoSpedizioniViaggio.Update();
					goto IL_03b4;
				}
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
							goto IL_03b4;
						}
						val = val2;
					}
				}
			}
			goto end_IL_0005;
			IL_0136:
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
					goto IL_03b4;
				}
				ListOfUnibol = new List<string>();
				checked
				{
					if (Operators.CompareString(((Control)iboInternalGridConfig.GridView).ID, ((Control)grdSpedizioniRaggruViaggio).ID, false) != 0)
					{
						int num = robjData[0].FieldValuesCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniViaggio).ID, false) == 0))
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
						goto IL_0300;
					}
					val2 = FindUnibolFromGrdConsegne(robjData, ref ListOfUnibol, ref rsMess);
				}
				if ((int)val2 <= 0)
				{
					goto IL_0300;
				}
				val = val2;
			}
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

	protected FXRETURN DisassociaSpedizioni(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
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
				base.SessionEnvironment.UserMessage.Parameters = RuntimeHelpers.GetObjectValue(objParams);
				base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
				base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Disassocia spedizioni");
				base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi la disassociazione delle spedizioni selezionate dal viaggio corrente?");
				base.SessionEnvironment.UserMessage.NeedToRefresh = true;
				base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
				base.SessionEnvironment.UserMessage.CallBackFunctionName = "DisassociaSpedizioni";
				WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
				IboMessageBox(ref UserMess);
				goto IL_016d;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
			{
				base.SessionEnvironment.UserMessage.Reset();
				goto IL_016d;
			}
			if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
			{
				goto IL_016d;
			}
			base.SessionEnvironment.UserMessage.Reset();
			val2 = _DisassociaSpedizioni(ref rsMess);
			if ((int)val2 <= 0)
			{
				goto IL_016d;
			}
			val = val2;
			goto end_IL_0005;
			IL_016d:
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

	protected FXRETURN _DisassociaSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between Unknown and I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string text = "";
			DataKeyFieldCollection dataKeyFieldCollection = new DataKeyFieldCollection();
			DataKeyFieldValues[] array = null;
			IboInternalGridConfig iboInternalGridConfig = null;
			if (Operators.CompareString(hdnIdViaggioSelezionato.Value, "", false) == 0)
			{
				goto IL_01d4;
			}
			text = hdnIdViaggioSelezionato.Value;
			dataKeyFieldCollection = new DataKeyFieldCollection();
			array = null;
			iboInternalGridConfig = ((!((Control)grdSpedizioniViaggio).Visible) ? GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID] : GridConfigList[((Control)grdSpedizioniViaggio).ID]);
			IboInternalGridConfig iboInternalGridConfig2;
			IboGridView grdGriglia = (iboInternalGridConfig2 = iboInternalGridConfig).GridView;
			IboInternalGridConfig iboInternalGridConfig3;
			IboGridInfo objGridInfo = (iboInternalGridConfig3 = iboInternalGridConfig).GridInfo;
			FXRETURN keyDataFromGrid = GetKeyDataFromGrid(ref grdGriglia, ref objGridInfo, ref dataKeyFieldCollection, ref array, bSelezioneObbligatoria: true, ref rsMess);
			iboInternalGridConfig3.GridInfo = objGridInfo;
			iboInternalGridConfig2.GridView = grdGriglia;
			val2 = keyDataFromGrid;
			List<string> ListOfUnibol;
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				if (dataKeyFieldCollection.Count <= 0)
				{
					goto IL_01d4;
				}
				ListOfUnibol = new List<string>();
				checked
				{
					if (Operators.CompareString(((Control)iboInternalGridConfig.GridView).ID, ((Control)grdSpedizioniRaggruViaggio).ID, false) != 0)
					{
						int num = dataKeyFieldCollection[0].FieldValuesCount - 1;
						for (int i = 0; i <= num; i++)
						{
							ListOfUnibol.Add(dataKeyFieldCollection.Item(0).get_FieldValues(i).ToString());
						}
						goto IL_0195;
					}
					val2 = FindUnibolFromGrdConsegne(dataKeyFieldCollection, ref ListOfUnibol, ref rsMess);
				}
				if ((int)val2 <= 0)
				{
					goto IL_0195;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_01d4:
			val = (FXRETURN)0;
			goto end_IL_0005;
			IL_0195:
			val2 = Spedizione_DisassociaDaViaggio_Invoker.Instance.RunProc(CreateApiContext(), ListOfUnibol, text, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = AggiornaTutteLeGriglie(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_01d4;
				}
				val = val2;
			}
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

	protected FXRETURN AssociaSpedizioni(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(hdnIdViaggioSelezionato.Value, "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun viaggio corrente selezionato");
			}
			else
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
				{
					base.SessionEnvironment.UserMessage.Reset();
					base.SessionEnvironment.UserMessage.Parameters = RuntimeHelpers.GetObjectValue(objParams);
					base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
					base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Associa spedizioni");
					base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi l'associazione delle spedizioni selezionate al viaggio corrente?");
					base.SessionEnvironment.UserMessage.NeedToRefresh = true;
					base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
					base.SessionEnvironment.UserMessage.CallBackFunctionName = "AssociaSpedizioni";
					WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref UserMess);
					goto IL_01a4;
				}
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
					goto IL_01a4;
				}
				if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
				{
					goto IL_01a4;
				}
				base.SessionEnvironment.UserMessage.Reset();
				val2 = _AssociaSpedizioni(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_01a4;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_01a4:
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

	protected FXRETURN _AssociaSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Invalid comparison between Unknown and I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Invalid comparison between Unknown and I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string value = hdnIdViaggioSelezionato.Value;
			DataKeyFieldCollection robjData = new DataKeyFieldCollection();
			DataKeyFieldValues[] robjKey = null;
			IboInternalGridConfig iboInternalGridConfig = null;
			if (Operators.CompareString(value, "", false) == 0)
			{
				goto IL_0293;
			}
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
					goto IL_0293;
				}
				List<string> list = new List<string>();
				checked
				{
					int num = robjData[0].FieldValuesCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if ((Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioni).ID, false) == 0) | (Operators.CompareString(iboInternalGridConfig.Id, ((Control)grdSpedizioniViaggio).ID, false) == 0))
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
					val2 = Spedizione_AssociaAViaggio_Invoker.Instance.RunProc(CreateApiContext(), list, value, null, ref rsMess);
				}
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = AggiornaTutteLeGriglie(ref rsMess);
					if ((int)val2 <= 0)
					{
						goto IL_0293;
					}
					val = val2;
				}
			}
			goto end_IL_0005;
			IL_0293:
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

	protected FXRETURN CancellaViaggio(ref object objParams, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(hdnIdViaggioSelezionato.Value, "", false) == 0)
			{
				rsMess = TranslateMessage("XXX", "Nessun viaggio corrente selezionato");
			}
			else
			{
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Undefined)
				{
					base.SessionEnvironment.UserMessage.Reset();
					base.SessionEnvironment.UserMessage.Parameters = RuntimeHelpers.GetObjectValue(objParams);
					base.SessionEnvironment.UserMessage.MessageBoxImageType = WFIUserMessage.MessageBoxImage.Question;
					base.SessionEnvironment.UserMessage.Message1 = TranslateMessage("XXX", "Cancellazione viaggio");
					base.SessionEnvironment.UserMessage.Message2 = TranslateMessage("XXX", "Confermi la cancellazione definitiva del viaggio {0} ?", hdnIdViaggioSelezionato.Value);
					base.SessionEnvironment.UserMessage.NeedToRefresh = true;
					base.SessionEnvironment.UserMessage.Tipo = WFIUserMessage.TipoMessageBox.ConfermaAnnulla;
					base.SessionEnvironment.UserMessage.CallBackFunctionName = "CancellaViaggio";
					WFIUserMessage UserMess = base.SessionEnvironment.UserMessage;
					IboMessageBox(ref UserMess);
					goto IL_01b8;
				}
				if (base.SessionEnvironment.UserMessage.UserChoice == WFIUserMessage.MessageUserChoice.Annulla)
				{
					base.SessionEnvironment.UserMessage.Reset();
					goto IL_01b8;
				}
				if (base.SessionEnvironment.UserMessage.UserChoice != WFIUserMessage.MessageUserChoice.Conferma)
				{
					goto IL_01b8;
				}
				base.SessionEnvironment.UserMessage.Reset();
				val2 = _CancellaViaggio(ref rsMess);
				if ((int)val2 <= 0)
				{
					goto IL_01b8;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_01b8:
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

	protected FXRETURN _CancellaViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			string value = hdnIdViaggioSelezionato.Value;
			if (Operators.CompareString(value, "", false) == 0)
			{
				goto IL_00e1;
			}
			value = hdnIdViaggioSelezionato.Value;
			val2 = Viaggio_Cancella_Invoker.Instance.RunProc(CreateApiContext(), value, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = AggiornaElencoViaggi(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					val2 = AggiornaElencoSpedizioniViaggio(ref rsMess);
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
									goto IL_00e1;
								}
								val = val2;
							}
						}
					}
				}
			}
			goto end_IL_0005;
			IL_00e1:
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
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Invalid comparison between Unknown and I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Invalid comparison between Unknown and I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_0242;
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
					val = Aggiorna(ref rsMess);
					if ((int)val <= 0)
					{
						goto IL_0242;
					}
					val2 = val;
				}
			}
			goto end_IL_000e;
			IL_0242:
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

	private FXRETURN CreaViaggioConSpedizioni(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Invalid comparison between Unknown and I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
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
					goto IL_0353;
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
					viaggio.TipoViaggio = TipoViaggio.ObjValue.ToString();
					viaggio.TipoSpedizione = TipoSpedizione.ObjValue.ToString();
					viaggio.TipoMerce = TipoMerce.ObjValue.ToString();
					viaggio.Contenitore1Pianificato = Contenitore1Pianificato.ObjValue.ToString();
					viaggio.MotricePianificata = MotricePianificata.ObjValue.ToString();
					viaggio = null;
					val = Viaggio_InserisciConSpedizioni_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref ListOfUnibol, ref rsMess);
				}
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = Aggiorna(ref rsMess);
					if ((int)val <= 0)
					{
						WriteInfoMessage(TranslateMessage("XXX", "Generato il viaggio {0}", Viaggio.IdViaggio), ShowAsNotification: true);
						goto IL_0353;
					}
					val2 = val;
				}
			}
			goto end_IL_000e;
			IL_0353:
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

	private FXRETURN CreaViaggio(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			Viaggio Viaggio = new Viaggio();
			Viaggio viaggio = Viaggio;
			viaggio.DataPartenzaPianificata = DataPartenzaPianificata.getDateValue;
			viaggio.Vettore = Vettore.ObjValue.ToString();
			viaggio.PCSPartenza = PCSPartenza.ObjValue.ToString();
			viaggio.PCSArrivo = PCSArrivo.ObjValue.ToString();
			viaggio.TipoViaggio = TipoViaggio.ObjValue.ToString();
			viaggio.TipoSpedizione = TipoSpedizione.ObjValue.ToString();
			viaggio.TipoMerce = TipoMerce.ObjValue.ToString();
			viaggio.Contenitore1Pianificato = Contenitore1Pianificato.ObjValue.ToString();
			viaggio.MotricePianificata = MotricePianificata.ObjValue.ToString();
			viaggio = null;
			val = Viaggio_Inserisci_Invoker.Instance.RunProc(CreateApiContext(), ref Viaggio, ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = AggiornaElencoViaggi(ref rsMess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = AggiornaElencoSpedizioniViaggio(ref rsMess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						WriteInfoMessage(TranslateMessage("XXX", "Generato il viaggio {0}", Viaggio.IdViaggio), ShowAsNotification: true);
						val2 = (FXRETURN)0;
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
					iboInternalGridConfig = GridConfigList[((Control)grdViaggi).ID];
					InternalGridAggiornaSingola(ref iboInternalGridConfig, ref rsMess);
					upElencoViaggi.Update();
					AggiornaElencoSpedizioniViaggio(ref rsMess);
					upElencoSpedizioniViaggio.Update();
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

	private FXRETURN CambiaData(DateTime DaData, DateTime aData, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_DaData = DaData;
			_AData = aData;
			_Filtro = " (" + GeneraFiltroData() + ") ";
			if (Operators.CompareString(_FiltroQueryString, "", false) != 0)
			{
				ref string filtro = ref _Filtro;
				filtro = filtro + " AND (" + _FiltroQueryString + ") ";
			}
			if (Operators.CompareString(_FiltroUtente, "S", false) == 0 && Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro ?? "", "", false) != 0)
			{
				ref string filtro2 = ref _Filtro;
				filtro2 = filtro2 + " AND (" + base.SessionEnvironment.WebUser.WebUserInfo.Filtro + ") ";
			}
			_SessionVariable["FILTRO"] = (object)_Filtro;
			_SessionVariable["DA_DATA"] = (object)_DaData;
			_SessionVariable["A_DATA"] = (object)_AData;
			DataSpedizioneDa.ObjValue = Strings.Format((object)_DaData, "dd/MM/yyyy");
			DataSpedizioneA.ObjValue = Strings.Format((object)_AData, "dd/MM/yyyy");
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
					val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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

	private FXRETURN CambiaDataViaggi(DateTime? Data, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_DataVia = Data;
			_SessionVariable["DATAVIAGGIO"] = (object)_DataVia;
			if (_DataVia.HasValue)
			{
				DataViaggio.ObjValue = Strings.Format((object)_DataVia, "dd/MM/yyyy");
			}
			upButton.Update();
			val = AggiornaElencoViaggi(ref rsMess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = AggiornaElencoSpedizioniViaggio(ref rsMess);
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private string GeneraQueryViaggi()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between Unknown and I4
		string text = "";
		bool flag = false;
		if (_SessionVariable.ContainsKey("CST_GRD_PV_VIAGGI"))
		{
			flag = (bool)_SessionVariable["CST_GRD_PV_VIAGGI"];
		}
		else
		{
			DBConnection dbConn = base.DbConn;
			string text2 = "";
			dbConn.TableOrViewExists("CST_GRD_PV_VIAGGI", ref flag, ref text2);
			_SessionVariable["CST_GRD_PV_VIAGGI"] = flag;
		}
		text = "SELECT * FROM ";
		text = ((!flag) ? (text + "GRD_PV_VIAGGI") : (text + "CST_GRD_PV_VIAGGI"));
		text += " WHERE 1=1 ";
		if (_DataVia.HasValue)
		{
			text = text + "AND %TRUNC%(DATAPARTENZAPIANIFICATA) =" + base.DbConn.SQLFormatDate((eTipoData)1, _DataVia.Value);
		}
		if (!Information.IsNothing((object)FilterViaggi) && Operators.CompareString(FilterViaggi.FilterExpression, "", false) != 0)
		{
			text = text + " AND (" + FilterViaggi.FilterExpression + ")";
		}
		text = (((int)base.DbConn.ServerType != 1) ? ("SELECT TOP " + _TopSelect + " * FROM (" + text + ") T ") : ("SELECT * FROM (" + text + ") T WHERE ROWNUM<=" + _TopSelect));
		return base.DbConn.SqlConvertForServer(text);
	}

	private string GeneraQuerySpedizioniViaggio(string ssqlFiltroViaggi)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		if (_SessionVariable.ContainsKey("CST_GRD_PV_Spedizioni_Viaggio"))
		{
			flag = (bool)_SessionVariable["CST_GRD_PV_Spedizioni_Viaggio"];
		}
		else
		{
			DBConnection dbConn = base.DbConn;
			string text2 = "";
			dbConn.TableOrViewExists("CST_GRD_PV_Spedizioni_Viaggio", ref flag, ref text2);
			_SessionVariable["CST_GRD_PV_Spedizioni_Viaggio"] = flag;
		}
		text = "SELECT * FROM ";
		text = ((!flag) ? (text + "GRD_PV_Spedizioni_Viaggio") : (text + "CST_GRD_PV_Spedizioni_Viaggio"));
		text += " WHERE 1=1 ";
		text = ((Operators.CompareString(ssqlFiltroViaggi, "", false) == 0) ? (text + "AND 1=2 ") : (text + "AND IDVIAGGIO IN (" + ssqlFiltroViaggi + ") "));
		return base.DbConn.SqlConvertForServer(text);
	}

	private string GeneraQuerySpedizioniRaggruViaggio(string ssqlFiltroViaggi)
	{
		if (Operators.CompareString(ssqlFiltroViaggi, "", false) == 0)
		{
			ssqlFiltroViaggi = "'000'";
		}
		string text = "";
		text += "SELECT T.*, CAST(T.IdViaggio AS VARCHAR(10)) %+% ';' %+% T.Tipo %+% ';' %+% T.PCSDESTINAZIONE %+% ';' %+% CAST(T.SequenzaPianificata AS VARCHAR(10)) %+% ';' %+% T.PCSPARTENZA WFIKey, ";
		text += "CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
		text += "SELECT T1.*, CASE WHEN CORRISP_CODICE IS NULL THEN 'D' ELSE 'C' END Tipo, ";
		text += "%ISNULL%(CORRISP_CODICE,TMP_PCSDESTINAZIONE) PCSDESTINAZIONE,";
		text += "%ISNULL%(CORRISP_RAGSOC,TMP_PCSDESTINAZIONE_RAGSOC) PCSDESTINAZIONE_RAGSOC,";
		text += "%ISNULL%(CORRISP_INDIRIZZO,TMP_PCSDESTINAZIONE_INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
		text += "%ISNULL%(CORRISP_CAP,TMP_PCSDESTINAZIONE_CAP) PCSDESTINAZIONE_CAP,";
		text += "%ISNULL%(CORRISP_LOCALITA,TMP_PCSDESTINAZIONE_LOCALITA) PCSDESTINAZIONE_LOCALITA,";
		text += "%ISNULL%(CORRISP_PROVINCIA,TMP_PCSDESTINAZIONE_PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
		text += "%ISNULL%(CORRISP_NAZIONE,TMP_PCSDESTINAZIONE_NAZIONE) PCSDESTINAZIONE_NAZIONE ";
		text += "FROM (";
		text += "SELECT  S.IdViaggio, ";
		text += "MAX(S.SequenzaPianificata) SequenzaPianificata,";
		text += "COUNT(*) Numero_Spedizioni,";
		text += "MAX(S.DESTINAZIONECLIENTE) DESTINAZIONECLIENTE,";
		text += "MAX(S.PCSDESTINAZIONE) TMP_PCSDESTINAZIONE,";
		text += "MAX(S.PCSDESTINAZIONE_RAGSOC) TMP_PCSDESTINAZIONE_RAGSOC,";
		text += "MAX(S.PCSDESTINAZIONE_INDIRIZZO) TMP_PCSDESTINAZIONE_INDIRIZZO,";
		text += "MAX(S.PCSDESTINAZIONE_CAP) TMP_PCSDESTINAZIONE_CAP,";
		text += "MAX(S.PCSDESTINAZIONE_LOCALITA) TMP_PCSDESTINAZIONE_LOCALITA,";
		text += "MAX(S.PCSDESTINAZIONE_PROVINCIA) TMP_PCSDESTINAZIONE_PROVINCIA,";
		text += "MAX(S.PCSDESTINAZIONE_NAZIONE) TMP_PCSDESTINAZIONE_NAZIONE,";
		text += "MAX(S.PCSPARTENZA) PCSPARTENZA,";
		text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
		text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
		text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
		text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
		text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
		text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
		text += "MAX(S.CORRISPONDENTE) CORRISP_CODICE,";
		text += "MAX(C.RAGIONESOCIALE) CORRISP_RAGSOC,";
		text += "MAX(C.INDIRIZZO) CORRISP_INDIRIZZO,";
		text += "MAX(C.CAP) CORRISP_CAP,";
		text += "MAX(C.LOCALITA) CORRISP_LOCALITA,";
		text += "MAX(C.PROVINCIA) CORRISP_PROVINCIA,";
		text += "MAX(C.NAZIONE) CORRISP_NAZIONE,";
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
		text += "FROM SPEDIZIONI S LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
		text = text + "WHERE S.IdViaggio = " + ssqlFiltroViaggi + " ";
		text += "GROUP BY S.IdViaggio, S.SequenzaPianificata";
		text += ") T1 ";
		text += ") T";
		return base.DbConn.SqlConvertForServer(text);
	}

	private string GeneraQuerySpedizioni(string ssqlFiltroZone)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		PerformanceLogAppend("GeneraQuerySpedizioni BEGIN");
		if (_SessionVariable.ContainsKey("CST_GRD_PV_Spedizioni"))
		{
			flag = (bool)_SessionVariable["CST_GRD_PV_Spedizioni"];
		}
		else
		{
			DBConnection dbConn = base.DbConn;
			string text2 = "";
			dbConn.TableOrViewExists("CST_GRD_PV_Spedizioni", ref flag, ref text2);
			_SessionVariable["CST_GRD_PV_Spedizioni"] = flag;
		}
		text = "SELECT * FROM ";
		text = ((!flag) ? (text + "GRD_PV_Spedizioni") : (text + "CST_GRD_PV_Spedizioni"));
		text += " WHERE 1=1 ";
		if (Operators.CompareString(_Filtro, "", false) != 0)
		{
			text = text + "AND " + _Filtro + " ";
		}
		if (!Information.IsNothing((object)FilterSpedizioni) && Operators.CompareString(FilterSpedizioni.FilterExpression, "", false) != 0)
		{
			text = text + " AND (" + FilterSpedizioni.FilterExpression + ")";
		}
		string result = text;
		PerformanceLogAppend("GeneraQuerySpedizioni END");
		return result;
	}

	private string GeneraQuerySpedizioniRaggru(string ssqlFiltroZone)
	{
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Invalid comparison between Unknown and I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Invalid comparison between Unknown and I4
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru BEGIN");
		if (!base.ApplicationParams.RaggruppaConPCSPartenza())
		{
			text = "SELECT T.*";
			text += ", CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
			text += "SELECT 'D' Tipo,";
			text += "COUNT(*) Numero_Spedizioni,";
			text += "1 Numero_Scarichi,";
			if ((int)base.DbConn.ServerType == 0)
			{
				text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NULL AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
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
			text += "MAX(S.PCSPARTENZA) PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
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
				text += "FROM VW_PV_Spedizioni TEMP ";
				text += "WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE ";
				text += "FOR XML PATH('') ),1,1,'') AS ListaUnibol, ";
				text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' + ";
				text += "REPLACE(REPLACE((SELECT '%lt%tr%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_ragsoc) + ' %lt%/td%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_localita) + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') + ' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Colli) AS VARCHAR) + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Pallet) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Volume) AS VARCHAR) + '%lt%/td%gt%%lt%/tr%gt%' ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione ";
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
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione), ',%%%', ' '), '%%%', '')), '%gt%', '>'), '%lt%', '<') || '</table>' AS ListaDestinazioni, ";
			}
			text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
			text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
			text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
			text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
			text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
			text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
			text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,";
			text += "MAX(S.PCSPARTENZA) PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
			text += "LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
			text += "WHERE <%FILTRO%> ";
			text += "AND S.CORRISPONDENTE IS NOT NULL ";
			text += "GROUP BY S.CORRISPONDENTE ) T ";
		}
		else
		{
			text = "SELECT T.*";
			text += ", CASE WHEN T.TIPO='D' THEN 'Destinazione' ELSE 'Hub' END Tipo_Descrizione FROM (";
			text += "SELECT 'D' Tipo,";
			text += "COUNT(*) Numero_Spedizioni,";
			text += "1 Numero_Scarichi,";
			if ((int)base.DbConn.ServerType == 0)
			{
				text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NULL AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE AND TEMP.PCSPARTENZA = S.PCSPARTENZA ";
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
			text += "S.PCSPARTENZA PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
			text += "WHERE <%FILTRO%> ";
			text += "AND S.CORRISPONDENTE IS NULL ";
			text += "GROUP BY S.PCSPARTENZA, S.PCSDESTINAZIONE ";
			text += " UNION ";
			text += "SELECT 'C' Tipo,";
			text += "COUNT(*) Numero_Spedizioni,";
			text += "COUNT(DISTINCT(S.PCSDESTINAZIONE)) Numero_Scarichi,";
			if ((int)base.DbConn.ServerType == 0)
			{
				text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
				text += "FROM VW_PV_Spedizioni TEMP ";
				text += "WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE AND TEMP.PCSPARTENZA = S.PCSPARTENZA ";
				text += "FOR XML PATH('') ),1,1,'') AS ListaUnibol, ";
				text += "'<table class=''TooltipTable''><tr><th>Destinazione</th><th>Località</th><th>Pr</th><th>Naz</th><th>Peso</th><th>Colli</th><th>Plt</th><th>Vol</th></tr>' + ";
				text += "REPLACE(REPLACE((SELECT '%lt%tr%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_ragsoc) + ' %lt%/td%gt%%lt%td%gt%' + MAX(TEMP.pcsdestinazione_localita) + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Provincia), ' ') + ' %lt%/td%gt%%lt%td%gt%' + ISNULL(MAX(TEMP.pcsdestinazione_Nazione), ' ') + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + CAST(CAST(SUM(TEMP.Peso) AS DECIMAL(18,2)) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Colli) AS VARCHAR) + ";
				text += "' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Pallet) AS VARCHAR) + ' %lt%/td%gt%%lt%td%gt%' + CAST(SUM(TEMP.Volume) AS VARCHAR) + '%lt%/td%gt%%lt%/tr%gt%' ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione ";
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
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.CORRISPONDENTE IS NOT NULL AND TEMP.CORRISPONDENTE = S.CORRISPONDENTE GROUP BY pcsdestinazione), ',%%%', ' '), '%%%', '')), '%gt%', '>'), '%lt%', '<') || '</table>' AS ListaDestinazioni, ";
			}
			text += "S.CORRISPONDENTE PCSDESTINAZIONE,";
			text += "MAX(C.RAGIONESOCIALE) PCSDESTINAZIONE_RAGSOC,";
			text += "MAX(C.INDIRIZZO) PCSDESTINAZIONE_INDIRIZZO,";
			text += "MAX(C.CAP) PCSDESTINAZIONE_CAP,";
			text += "MAX(C.LOCALITA) PCSDESTINAZIONE_LOCALITA,";
			text += "MAX(C.PROVINCIA) PCSDESTINAZIONE_PROVINCIA,";
			text += "MAX(C.NAZIONE) PCSDESTINAZIONE_NAZIONE,";
			text += "S.PCSPARTENZA PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
			text += "LEFT JOIN PCS C ON S.CORRISPONDENTE=C.CODICE ";
			text += "WHERE <%FILTRO%> ";
			text += "AND S.CORRISPONDENTE IS NOT NULL ";
			text += "GROUP BY S.PCSPARTENZA, S.CORRISPONDENTE ) T ";
		}
		if (Operators.CompareString(ssqlFiltroZone, "", false) != 0)
		{
			text2 = text2 + ssqlFiltroZone + " ";
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

	private string GeneraQuerySpedizioniRaggru2(string ssqlFiltroZone)
	{
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		string text = "";
		string text2 = "";
		PerformanceLogAppend("GeneraQuerySpedizioniRaggru2 BEGIN");
		if (!base.ApplicationParams.RaggruppaConPCSPartenza())
		{
			text = "SELECT MAX(S.CORRISPONDENTE) CORRISPONDENTECODICE, ";
			text += "MAX(CORRISPONDENTERAGIONESOCIALE) CORRISPONDENTE_RAGSOC,";
			text += "COUNT(*) Numero_Spedizioni,";
			text += "1 Numero_Scarichi,";
			if ((int)base.DbConn.ServerType == 0)
			{
				text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE ";
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
			text += "MAX(S.PCSPARTENZA) PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
			text += "WHERE <%FILTRO%> ";
			text += "GROUP BY S.PCSDESTINAZIONE ";
		}
		else
		{
			text = "SELECT MAX(S.CORRISPONDENTE) CORRISPONDENTECODICE, ";
			text += "MAX(CORRISPONDENTERAGIONESOCIALE) CORRISPONDENTE_RAGSOC,";
			text += "COUNT(*) Numero_Spedizioni,";
			text += "1 Numero_Scarichi,";
			if ((int)base.DbConn.ServerType == 0)
			{
				text += "STUFF((SELECT DISTINCT ',' + TEMP.Unibol ";
				text += "FROM VW_PV_Spedizioni TEMP WHERE <%FILTRO%> AND TEMP.PCSDESTINAZIONE = S.PCSDESTINAZIONE AND TEMP.PCSPARTENZA = S.PCSPARTENZA ";
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
			text += "S.PCSPARTENZA PCSPARTENZA,";
			text += "MAX(S.PCSPARTENZA_RAGSOC) PCSPARTENZA_RAGSOC,";
			text += "MAX(S.PCSPARTENZA_INDIRIZZO) PCSPARTENZA_INDIRIZZO,";
			text += "MAX(S.PCSPARTENZA_CAP) PCSPARTENZA_CAP,";
			text += "MAX(S.PCSPARTENZA_LOCALITA) PCSPARTENZA_LOCALITA,";
			text += "MAX(S.PCSPARTENZA_PROVINCIA) PCSPARTENZA_PROVINCIA,";
			text += "MAX(S.PCSPARTENZA_NAZIONE) PCSPARTENZA_NAZIONE,";
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
			text += "FROM VW_PV_Spedizioni S ";
			text += "WHERE <%FILTRO%> ";
			text += "GROUP BY S.PCSPARTENZA, S.PCSDESTINAZIONE ";
		}
		if (Operators.CompareString(ssqlFiltroZone, "", false) != 0)
		{
			text2 = text2 + ssqlFiltroZone + " ";
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
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Invalid comparison between Unknown and I4
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Invalid comparison between Unknown and I4
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Invalid comparison between Unknown and I4
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f0: Invalid comparison between Unknown and I4
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
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
			PerformanceLogAppend("AggiornaTotaliGriglia - INIZIO");
			text = "";
			IboInternalGridConfig iboInternalGridConfig = null;
			iboInternalGridConfig = GridConfigList[((Control)grdSpedizioni).ID];
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
				decimal num = default(decimal);
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
				decimal num13 = default(decimal);
				decimal num14 = default(decimal);
				decimal num15 = default(decimal);
				decimal num16 = default(decimal);
				footerSpedizioni_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
				checked
				{
					if (robjData.Count > 0)
					{
						text += " Unibol IN (";
						int num17 = robjData[0].FieldValuesCount - 1;
						for (int i = 0; i <= num17; i++)
						{
							text += base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(i).ToString());
							text = ((i >= robjData[0].FieldValuesCount - 1) ? (text + ")") : (text + ","));
						}
						text = "(" + text + ")";
					}
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = "1=2";
					}
					DataRow[] array = iboInternalGridConfig.DataTable.Select(text);
					num = default(decimal);
					num2 = default(decimal);
					num3 = default(decimal);
					num4 = default(decimal);
					num15 = default(decimal);
					num5 = default(decimal);
					num6 = default(decimal);
					num7 = default(decimal);
					num8 = default(decimal);
					num9 = default(decimal);
					num10 = default(decimal);
					num11 = default(decimal);
					num12 = default(decimal);
					num13 = default(decimal);
					num14 = default(decimal);
					DataRow[] array2 = array;
					foreach (DataRow dataRow in array2)
					{
						num = decimal.Add(num, Conversions.ToDecimal(dataRow["Peso"]));
						num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow["Volume"]));
						num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow["Colli"]));
						num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow["Pallet"]));
						num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow["CampoCalcolo1"]));
						num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow["CampoCalcolo2"]));
						num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow["CampoCalcolo3"]));
						num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow["CampoCalcolo4"]));
						num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow["CampoCalcolo5"]));
						num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow["CampoCalcolo6"]));
						num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow["CampoCalcolo7"]));
						num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow["CampoCalcolo8"]));
						num13 = decimal.Add(num13, Conversions.ToDecimal(dataRow["CampoCalcolo9"]));
						num14 = decimal.Add(num14, Conversions.ToDecimal(dataRow["CampoCalcolo10"]));
						num15 = decimal.Add(num15, 1m);
					}
					footerSpedizioni_Colli_Value.ObjValue = Convert.ToInt32(num3);
					footerSpedizioni_Pallet_Value.ObjValue = Convert.ToInt32(num4);
					footerSpedizioni_Peso_Value.ObjValue = Strings.Format((object)num, kFormatoSommaPeso);
					footerSpedizioni_Volume_Value.ObjValue = Strings.Format((object)num2, kFormatoSommaVolume);
					footerSpedizioni_Spedizioni_Value.ObjValue = Convert.ToInt32(num15);
					footerSpedizioni_CampoCalcolo1_Value.ObjValue = Strings.Format((object)num5, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo2_Value.ObjValue = Strings.Format((object)num6, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo3_Value.ObjValue = Strings.Format((object)num7, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo4_Value.ObjValue = Strings.Format((object)num8, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo5_Value.ObjValue = Strings.Format((object)num9, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo6_Value.ObjValue = Strings.Format((object)num10, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo7_Value.ObjValue = Strings.Format((object)num11, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo8_Value.ObjValue = Strings.Format((object)num12, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo9_Value.ObjValue = Strings.Format((object)num13, kFormatoSommaCC);
					footerSpedizioni_CampoCalcolo10_Value.ObjValue = Strings.Format((object)num14, kFormatoSommaCC);
					text = "";
					iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru).ID];
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
							int num18 = robjData[0].FieldValuesCount - 1;
							for (int k = 0; k <= num18; k++)
							{
								text = text + " (ListaUnibol = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(k).ToString()) + " ) ";
								if (k < robjData[0].FieldValuesCount - 1)
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
						if (iboInternalGridConfig.DataTable != null)
						{
							footerSpedizioniRaggru_TotConsegne_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
						}
						array = iboInternalGridConfig.DataTable.Select(text);
						num = default(decimal);
						num2 = default(decimal);
						num3 = default(decimal);
						num4 = default(decimal);
						num15 = default(decimal);
						num5 = default(decimal);
						num6 = default(decimal);
						num7 = default(decimal);
						num8 = default(decimal);
						num9 = default(decimal);
						num10 = default(decimal);
						num11 = default(decimal);
						num12 = default(decimal);
						num13 = default(decimal);
						num14 = default(decimal);
						DataRow[] array3 = array;
						foreach (DataRow dataRow2 in array3)
						{
							num = decimal.Add(num, Conversions.ToDecimal(dataRow2["Peso"]));
							num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow2["Volume"]));
							num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow2["Colli"]));
							num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow2["Pallet"]));
							num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow2["CampoCalcolo1"]));
							num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow2["CampoCalcolo2"]));
							num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow2["CampoCalcolo3"]));
							num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow2["CampoCalcolo4"]));
							num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow2["CampoCalcolo5"]));
							num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow2["CampoCalcolo6"]));
							num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow2["CampoCalcolo7"]));
							num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow2["CampoCalcolo8"]));
							num13 = decimal.Add(num13, Conversions.ToDecimal(dataRow2["CampoCalcolo9"]));
							num14 = decimal.Add(num14, Conversions.ToDecimal(dataRow2["CampoCalcolo10"]));
							num15 = decimal.Add(num15, new decimal(Conversions.ToInteger(dataRow2["Numero_Spedizioni"])));
						}
						footerSpedizioniRaggru_Colli_Value.ObjValue = Convert.ToInt32(num3);
						footerSpedizioniRaggru_Pallet_Value.ObjValue = Convert.ToInt32(num4);
						footerSpedizioniRaggru_Peso_Value.ObjValue = Strings.Format((object)num, kFormatoSommaPeso);
						footerSpedizioniRaggru_Volume_Value.ObjValue = Strings.Format((object)num2, kFormatoSommaVolume);
						footerSpedizioniRaggru_CampoCalcolo1_Value.ObjValue = Strings.Format((object)num5, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo2_Value.ObjValue = Strings.Format((object)num6, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo3_Value.ObjValue = Strings.Format((object)num7, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo4_Value.ObjValue = Strings.Format((object)num8, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo5_Value.ObjValue = Strings.Format((object)num9, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo6_Value.ObjValue = Strings.Format((object)num10, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo7_Value.ObjValue = Strings.Format((object)num11, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo8_Value.ObjValue = Strings.Format((object)num12, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo9_Value.ObjValue = Strings.Format((object)num13, kFormatoSommaCC);
						footerSpedizioniRaggru_CampoCalcolo10_Value.ObjValue = Strings.Format((object)num14, kFormatoSommaCC);
						footerSpedizioniRaggru_Spedizioni_Value.ObjValue = Convert.ToInt32(num15);
						text = "";
						iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggru2).ID];
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
								int num19 = robjData[0].FieldValuesCount - 1;
								for (int m = 0; m <= num19; m++)
								{
									text = text + " (ListaUnibol = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(m).ToString()) + " ) ";
									if (m < robjData[0].FieldValuesCount - 1)
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
							if (iboInternalGridConfig.DataTable != null)
							{
								footerSpedizioniRaggru2_Colli_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
							}
							array = iboInternalGridConfig.DataTable.Select(text);
							num = default(decimal);
							num2 = default(decimal);
							num3 = default(decimal);
							num4 = default(decimal);
							num5 = default(decimal);
							num6 = default(decimal);
							num7 = default(decimal);
							num8 = default(decimal);
							num9 = default(decimal);
							num10 = default(decimal);
							num11 = default(decimal);
							num12 = default(decimal);
							num13 = default(decimal);
							num14 = default(decimal);
							num15 = default(decimal);
							DataRow[] array4 = array;
							foreach (DataRow dataRow3 in array4)
							{
								num = decimal.Add(num, Conversions.ToDecimal(dataRow3["Peso"]));
								num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow3["Volume"]));
								num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow3["Colli"]));
								num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow3["Pallet"]));
								num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow3["CampoCalcolo1"]));
								num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow3["CampoCalcolo2"]));
								num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow3["CampoCalcolo3"]));
								num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow3["CampoCalcolo4"]));
								num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow3["CampoCalcolo5"]));
								num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow3["CampoCalcolo6"]));
								num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow3["CampoCalcolo7"]));
								num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow3["CampoCalcolo8"]));
								num13 = decimal.Add(num13, Conversions.ToDecimal(dataRow3["CampoCalcolo9"]));
								num14 = decimal.Add(num14, Conversions.ToDecimal(dataRow3["CampoCalcolo10"]));
								num15 = decimal.Add(num15, new decimal(Conversions.ToInteger(dataRow3["Numero_Spedizioni"])));
							}
							footerSpedizioniRaggru2_Colli_Value.ObjValue = Convert.ToInt32(num3);
							footerSpedizioniRaggru2_Pallet_Value.ObjValue = Convert.ToInt32(num4);
							footerSpedizioniRaggru2_Peso_Value.ObjValue = Strings.Format((object)num, kFormatoSommaPeso);
							footerSpedizioniRaggru2_Volume_Value.ObjValue = Strings.Format((object)num2, kFormatoSommaVolume);
							footerSpedizioniRaggru2_Spedizioni_Value.ObjValue = Convert.ToInt32(num15);
							footerSpedizioniRaggru2_CampoCalcolo1_Value.ObjValue = Strings.Format((object)num5, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo2_Value.ObjValue = Strings.Format((object)num6, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo3_Value.ObjValue = Strings.Format((object)num7, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo4_Value.ObjValue = Strings.Format((object)num8, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo5_Value.ObjValue = Strings.Format((object)num9, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo6_Value.ObjValue = Strings.Format((object)num10, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo7_Value.ObjValue = Strings.Format((object)num11, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo8_Value.ObjValue = Strings.Format((object)num12, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo9_Value.ObjValue = Strings.Format((object)num13, kFormatoSommaCC);
							footerSpedizioniRaggru2_CampoCalcolo10_Value.ObjValue = Strings.Format((object)num14, kFormatoSommaCC);
							text = "";
							iboInternalGridConfig = ((!((Control)cpGrdElencoSpedizioniViaggio).Visible) ? GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID] : GridConfigList[((Control)grdSpedizioniViaggio).ID]);
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
									if (((Control)cpGrdElencoSpedizioniViaggio).Visible)
									{
										int num20 = robjData[0].FieldValuesCount - 1;
										for (int num21 = 0; num21 <= num20; num21++)
										{
											text = text + " (Unibol = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num21).ToString()) + " ) ";
											if (num21 < robjData[0].FieldValuesCount - 1)
											{
												text += " OR ";
											}
										}
									}
									else
									{
										int num22 = robjData[0].FieldValuesCount - 1;
										for (int num23 = 0; num23 <= num22; num23++)
										{
											text = text + " (WFIKey = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num23).ToString()) + " ) ";
											if (num23 < robjData[0].FieldValuesCount - 1)
											{
												text += " OR ";
											}
										}
									}
									text = "(" + text + ")";
								}
								if (Operators.CompareString(text, "", false) == 0)
								{
									text = "1=2";
								}
								if (iboInternalGridConfig.DataTable != null)
								{
									footerSpedizioniViaggio_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
								}
								array = iboInternalGridConfig.DataTable.Select(text);
								num = default(decimal);
								num2 = default(decimal);
								num3 = default(decimal);
								num4 = default(decimal);
								num15 = default(decimal);
								num5 = default(decimal);
								num6 = default(decimal);
								num7 = default(decimal);
								num8 = default(decimal);
								num9 = default(decimal);
								num10 = default(decimal);
								num11 = default(decimal);
								num12 = default(decimal);
								num13 = default(decimal);
								num14 = default(decimal);
								DataRow[] array5 = array;
								foreach (DataRow dataRow4 in array5)
								{
									num = decimal.Add(num, Conversions.ToDecimal(dataRow4["Peso"]));
									num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow4["Volume"]));
									num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow4["Colli"]));
									num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow4["Pallet"]));
									num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow4["CampoCalcolo1"]));
									num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow4["CampoCalcolo2"]));
									num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow4["CampoCalcolo3"]));
									num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow4["CampoCalcolo4"]));
									num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow4["CampoCalcolo5"]));
									num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow4["CampoCalcolo6"]));
									num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow4["CampoCalcolo7"]));
									num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow4["CampoCalcolo8"]));
									num13 = decimal.Add(num13, Conversions.ToDecimal(dataRow4["CampoCalcolo9"]));
									num14 = decimal.Add(num14, Conversions.ToDecimal(dataRow4["CampoCalcolo10"]));
									num15 = decimal.Add(num15, 1m);
								}
								footerSpedizioniViaggio_Colli_Value.ObjValue = Convert.ToInt32(num3);
								footerSpedizioniViaggio_Pallet_Value.ObjValue = Convert.ToInt32(num4);
								footerSpedizioniViaggio_Peso_Value.ObjValue = Strings.Format((object)num, kFormatoSommaPeso);
								footerSpedizioniViaggio_Volume_Value.ObjValue = Strings.Format((object)num2, kFormatoSommaVolume);
								footerSpedizioniViaggio_Spedizioni_Value.ObjValue = Convert.ToInt32(num15);
								footerSpedizioniViaggio_CampoCalcolo1_Value.ObjValue = Strings.Format((object)num5, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo2_Value.ObjValue = Strings.Format((object)num6, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo3_Value.ObjValue = Strings.Format((object)num7, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo4_Value.ObjValue = Strings.Format((object)num8, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo5_Value.ObjValue = Strings.Format((object)num9, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo6_Value.ObjValue = Strings.Format((object)num10, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo7_Value.ObjValue = Strings.Format((object)num11, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo8_Value.ObjValue = Strings.Format((object)num12, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo9_Value.ObjValue = Strings.Format((object)num13, kFormatoSommaCC);
								footerSpedizioniViaggio_CampoCalcolo10_Value.ObjValue = Strings.Format((object)num14, kFormatoSommaCC);
								text = "";
								iboInternalGridConfig = GridConfigList[((Control)grdSpedizioniRaggruViaggio).ID];
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
										int num25 = robjData[0].FieldValuesCount - 1;
										for (int num26 = 0; num26 <= num25; num26++)
										{
											text = text + " (WFIKey = " + base.DbConn.SQLFormatString(robjData.Item(0).get_FieldValues(num26).ToString()) + " ) ";
											if (num26 < robjData[0].FieldValuesCount - 1)
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
									if (iboInternalGridConfig.DataTable != null)
									{
										footerSpedizioniRaggruViaggio_TotSpedizioni_Value.ObjValue = iboInternalGridConfig.DataTable.Rows.Count;
									}
									array = iboInternalGridConfig.DataTable.Select(text);
									num = default(decimal);
									num2 = default(decimal);
									num3 = default(decimal);
									num4 = default(decimal);
									num15 = default(decimal);
									num5 = default(decimal);
									num6 = default(decimal);
									num7 = default(decimal);
									num8 = default(decimal);
									num9 = default(decimal);
									num10 = default(decimal);
									num11 = default(decimal);
									num12 = default(decimal);
									num13 = default(decimal);
									num14 = default(decimal);
									DataRow[] array6 = array;
									foreach (DataRow dataRow5 in array6)
									{
										num = decimal.Add(num, Conversions.ToDecimal(dataRow5["Peso"]));
										num2 = decimal.Add(num2, Conversions.ToDecimal(dataRow5["Volume"]));
										num3 = decimal.Add(num3, Conversions.ToDecimal(dataRow5["Colli"]));
										num4 = decimal.Add(num4, Conversions.ToDecimal(dataRow5["Pallet"]));
										num5 = decimal.Add(num5, Conversions.ToDecimal(dataRow5["CampoCalcolo1"]));
										num6 = decimal.Add(num6, Conversions.ToDecimal(dataRow5["CampoCalcolo2"]));
										num7 = decimal.Add(num7, Conversions.ToDecimal(dataRow5["CampoCalcolo3"]));
										num8 = decimal.Add(num8, Conversions.ToDecimal(dataRow5["CampoCalcolo4"]));
										num9 = decimal.Add(num9, Conversions.ToDecimal(dataRow5["CampoCalcolo5"]));
										num10 = decimal.Add(num10, Conversions.ToDecimal(dataRow5["CampoCalcolo6"]));
										num11 = decimal.Add(num11, Conversions.ToDecimal(dataRow5["CampoCalcolo7"]));
										num12 = decimal.Add(num12, Conversions.ToDecimal(dataRow5["CampoCalcolo8"]));
										num13 = decimal.Add(num13, Conversions.ToDecimal(dataRow5["CampoCalcolo9"]));
										num14 = decimal.Add(num14, Conversions.ToDecimal(dataRow5["CampoCalcolo10"]));
										num15 = decimal.Add(num15, 1m);
									}
									footerSpedizioniRaggruViaggio_Colli_Value.ObjValue = Convert.ToInt32(num3);
									footerSpedizioniRaggruViaggio_Pallet_Value.ObjValue = Convert.ToInt32(num4);
									footerSpedizioniRaggruViaggio_Peso_Value.ObjValue = Strings.Format((object)num, kFormatoSommaPeso);
									footerSpedizioniRaggruViaggio_Volume_Value.ObjValue = Strings.Format((object)num2, kFormatoSommaVolume);
									footerSpedizioniRaggruViaggio_Spedizioni_Value.ObjValue = Convert.ToInt32(num15);
									footerSpedizioniRaggruViaggio_CampoCalcolo1_Value.ObjValue = Strings.Format((object)num5, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo2_Value.ObjValue = Strings.Format((object)num6, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo3_Value.ObjValue = Strings.Format((object)num7, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo4_Value.ObjValue = Strings.Format((object)num8, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo5_Value.ObjValue = Strings.Format((object)num9, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo6_Value.ObjValue = Strings.Format((object)num10, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo7_Value.ObjValue = Strings.Format((object)num11, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo8_Value.ObjValue = Strings.Format((object)num12, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo9_Value.ObjValue = Strings.Format((object)num13, kFormatoSommaCC);
									footerSpedizioniRaggruViaggio_CampoCalcolo10_Value.ObjValue = Strings.Format((object)num14, kFormatoSommaCC);
									PerformanceLogAppend("AggiornaTotaliGriglia - FINE");
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

	private string GeneraFiltroData()
	{
		string text = "";
		text = "(%TRUNC%(DATASPEDIZIONE) >= " + base.DbConn.SQLFormatDate((eTipoData)1, _DaData) + " AND %TRUNC%(DATASPEDIZIONE) <= " + base.DbConn.SQLFormatDate((eTipoData)1, _AData) + ")";
		return base.DbConn.SqlConvertForServer(text);
	}

	private string GeneraFiltroDataViaggio()
	{
		string text = "";
		text = "(%TRUNC%(DataPartenzaPianificata) = " + base.DbConn.SQLFormatDate((eTipoData)1, _DataVia) + ")";
		return base.DbConn.SqlConvertForServer(text);
	}

	private void Init_GridFooters()
	{
		if (!((Page)this).IsPostBack)
		{
			footerSpedizioni_CampoCalcolo1_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "TEXT", "CC1");
			footerSpedizioni_CampoCalcolo2_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "TEXT", "CC2");
			footerSpedizioni_CampoCalcolo3_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "TEXT", "CC3");
			footerSpedizioni_CampoCalcolo4_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "TEXT", "CC4");
			footerSpedizioni_CampoCalcolo5_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "TEXT", "CC5");
			footerSpedizioni_CampoCalcolo6_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "TEXT", "CC6");
			footerSpedizioni_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
			footerSpedizioni_CampoCalcolo8_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "TEXT", "CC8");
			footerSpedizioni_CampoCalcolo9_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "TEXT", "CC9");
			footerSpedizioni_CampoCalcolo10_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "TEXT", "CC10");
			footerSpedizioniRaggru_CampoCalcolo1_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "TEXT", "CC1");
			footerSpedizioniRaggru_CampoCalcolo2_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "TEXT", "CC2");
			footerSpedizioniRaggru_CampoCalcolo3_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "TEXT", "CC3");
			footerSpedizioniRaggru_CampoCalcolo4_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "TEXT", "CC4");
			footerSpedizioniRaggru_CampoCalcolo5_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "TEXT", "CC5");
			footerSpedizioniRaggru_CampoCalcolo6_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "TEXT", "CC6");
			footerSpedizioniRaggru_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
			footerSpedizioniRaggru_CampoCalcolo8_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "TEXT", "CC8");
			footerSpedizioniRaggru_CampoCalcolo9_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "TEXT", "CC9");
			footerSpedizioniRaggru_CampoCalcolo10_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "TEXT", "CC10");
			footerSpedizioniRaggru2_CampoCalcolo1_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "TEXT", "CC1");
			footerSpedizioniRaggru2_CampoCalcolo2_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "TEXT", "CC2");
			footerSpedizioniRaggru2_CampoCalcolo3_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "TEXT", "CC3");
			footerSpedizioniRaggru2_CampoCalcolo4_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "TEXT", "CC4");
			footerSpedizioniRaggru2_CampoCalcolo5_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "TEXT", "CC5");
			footerSpedizioniRaggru2_CampoCalcolo6_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "TEXT", "CC6");
			footerSpedizioniRaggru2_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
			footerSpedizioniRaggru2_CampoCalcolo8_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "TEXT", "CC8");
			footerSpedizioniRaggru2_CampoCalcolo9_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "TEXT", "CC9");
			footerSpedizioniRaggru2_CampoCalcolo10_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "TEXT", "CC10");
			footerSpedizioniViaggio_CampoCalcolo1_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "TEXT", "CC1");
			footerSpedizioniViaggio_CampoCalcolo2_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "TEXT", "CC2");
			footerSpedizioniViaggio_CampoCalcolo3_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "TEXT", "CC3");
			footerSpedizioniViaggio_CampoCalcolo4_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "TEXT", "CC4");
			footerSpedizioniViaggio_CampoCalcolo5_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "TEXT", "CC5");
			footerSpedizioniViaggio_CampoCalcolo6_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "TEXT", "CC6");
			footerSpedizioniViaggio_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
			footerSpedizioniViaggio_CampoCalcolo8_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "TEXT", "CC8");
			footerSpedizioniViaggio_CampoCalcolo9_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "TEXT", "CC9");
			footerSpedizioniViaggio_CampoCalcolo10_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "TEXT", "CC10");
			footerSpedizioniRaggruViaggio_CampoCalcolo1_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "TEXT", "CC1");
			footerSpedizioniRaggruViaggio_CampoCalcolo2_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "TEXT", "CC2");
			footerSpedizioniRaggruViaggio_CampoCalcolo3_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "TEXT", "CC3");
			footerSpedizioniRaggruViaggio_CampoCalcolo4_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "TEXT", "CC4");
			footerSpedizioniRaggruViaggio_CampoCalcolo5_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "TEXT", "CC5");
			footerSpedizioniRaggruViaggio_CampoCalcolo6_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "TEXT", "CC6");
			footerSpedizioniRaggruViaggio_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
			footerSpedizioniRaggruViaggio_CampoCalcolo8_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "TEXT", "CC8");
			footerSpedizioniRaggruViaggio_CampoCalcolo9_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "TEXT", "CC9");
			footerSpedizioniRaggruViaggio_CampoCalcolo10_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "TEXT", "CC10");
		}
		footerSpedizioni_Peso_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PESO", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioni_Peso_Caption.Visible = footerSpedizioni_Peso_Value.Visible;
		footerSpedizioni_Colli_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "COLLI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioni_Colli_Caption.Visible = footerSpedizioni_Colli_Value.Visible;
		footerSpedizioni_Volume_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "VOLUME", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioni_Volume_Caption.Visible = footerSpedizioni_Volume_Value.Visible;
		footerSpedizioni_Pallet_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PALLET", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioni_Pallet_Caption.Visible = footerSpedizioni_Pallet_Value.Visible;
		footerSpedizioni_Spedizioni_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "SPEDIZIONI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioni_Spedizioni_Caption.Visible = footerSpedizioni_Spedizioni_Value.Visible;
		footerSpedizioni_CampoCalcolo1_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo1_Caption.Visible = footerSpedizioni_CampoCalcolo1_Value.Visible;
		footerSpedizioni_CampoCalcolo2_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo2_Caption.Visible = footerSpedizioni_CampoCalcolo2_Value.Visible;
		footerSpedizioni_CampoCalcolo3_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo3_Caption.Visible = footerSpedizioni_CampoCalcolo3_Value.Visible;
		footerSpedizioni_CampoCalcolo4_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo4_Caption.Visible = footerSpedizioni_CampoCalcolo4_Value.Visible;
		footerSpedizioni_CampoCalcolo5_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo5_Caption.Visible = footerSpedizioni_CampoCalcolo5_Value.Visible;
		footerSpedizioni_CampoCalcolo6_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo6_Caption.Visible = footerSpedizioni_CampoCalcolo6_Value.Visible;
		footerSpedizioni_CampoCalcolo7_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo7_Caption.Visible = footerSpedizioni_CampoCalcolo7_Value.Visible;
		footerSpedizioni_CampoCalcolo7_Caption.Text = base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "TEXT", "CC7");
		footerSpedizioni_CampoCalcolo8_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo8_Caption.Visible = footerSpedizioni_CampoCalcolo8_Value.Visible;
		footerSpedizioni_CampoCalcolo9_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo9_Caption.Visible = footerSpedizioni_CampoCalcolo9_Value.Visible;
		footerSpedizioni_CampoCalcolo10_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioni_CampoCalcolo10_Caption.Visible = footerSpedizioni_CampoCalcolo10_Value.Visible;
		footerSpedizioniRaggru_Peso_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PESO", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru_Peso_Caption.Visible = footerSpedizioniRaggru_Peso_Value.Visible;
		footerSpedizioniRaggru_Colli_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "COLLI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru_Colli_Caption.Visible = footerSpedizioniRaggru_Colli_Value.Visible;
		footerSpedizioniRaggru_Volume_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "VOLUME", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru_Volume_Caption.Visible = footerSpedizioniRaggru_Volume_Value.Visible;
		footerSpedizioniRaggru_Pallet_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PALLET", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru_Pallet_Caption.Visible = footerSpedizioniRaggru_Pallet_Value.Visible;
		footerSpedizioniRaggru_Spedizioni_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "SPEDIZIONI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru_Spedizioni_Caption.Visible = footerSpedizioniRaggru_Spedizioni_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo1_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo1_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo1_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo2_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo2_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo2_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo3_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo3_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo3_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo4_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo4_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo4_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo5_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo5_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo5_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo6_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo6_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo6_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo7_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo7_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo7_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo8_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo8_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo8_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo9_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo9_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo9_Value.Visible;
		footerSpedizioniRaggru_CampoCalcolo10_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru_CampoCalcolo10_Caption.Visible = footerSpedizioniRaggru_CampoCalcolo10_Value.Visible;
		footerSpedizioniRaggru2_Peso_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PESO", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru2_Peso_Caption.Visible = footerSpedizioniRaggru2_Peso_Value.Visible;
		footerSpedizioniRaggru2_Colli_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "COLLI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru2_Colli_Caption.Visible = footerSpedizioniRaggru2_Colli_Value.Visible;
		footerSpedizioniRaggru2_Volume_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "VOLUME", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru2_Volume_Caption.Visible = footerSpedizioniRaggru2_Volume_Value.Visible;
		footerSpedizioniRaggru2_Pallet_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PALLET", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru2_Pallet_Caption.Visible = footerSpedizioniRaggru2_Pallet_Value.Visible;
		footerSpedizioniRaggru2_Spedizioni_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "SPEDIZIONI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggru2_Spedizioni_Caption.Visible = footerSpedizioniRaggru2_Spedizioni_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo1_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo1_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo1_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo2_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo2_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo2_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo3_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo3_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo3_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo4_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo4_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo4_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo5_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo5_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo5_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo6_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo6_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo6_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo7_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo7_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo7_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo8_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo8_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo8_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo9_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo9_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo9_Value.Visible;
		footerSpedizioniRaggru2_CampoCalcolo10_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggru2_CampoCalcolo10_Caption.Visible = footerSpedizioniRaggru2_CampoCalcolo10_Value.Visible;
		footerSpedizioniViaggio_Peso_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PESO", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniViaggio_Peso_Caption.Visible = footerSpedizioniViaggio_Peso_Value.Visible;
		footerSpedizioniViaggio_Colli_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "COLLI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniViaggio_Colli_Caption.Visible = footerSpedizioniViaggio_Colli_Value.Visible;
		footerSpedizioniViaggio_Volume_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "VOLUME", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniViaggio_Volume_Caption.Visible = footerSpedizioniViaggio_Volume_Value.Visible;
		footerSpedizioniViaggio_Pallet_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PALLET", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniViaggio_Pallet_Caption.Visible = footerSpedizioniViaggio_Pallet_Value.Visible;
		footerSpedizioniViaggio_Spedizioni_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "SPEDIZIONI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniViaggio_Spedizioni_Caption.Visible = footerSpedizioniViaggio_Spedizioni_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo1_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo1_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo1_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo2_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo2_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo2_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo3_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo3_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo3_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo4_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo4_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo4_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo5_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo5_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo5_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo6_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo6_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo6_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo7_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo7_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo7_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo8_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo8_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo8_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo9_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo9_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo9_Value.Visible;
		footerSpedizioniViaggio_CampoCalcolo10_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniViaggio_CampoCalcolo10_Caption.Visible = footerSpedizioniViaggio_CampoCalcolo10_Value.Visible;
		footerSpedizioniRaggruViaggio_Peso_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PESO", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_Peso_Caption.Visible = footerSpedizioniRaggruViaggio_Peso_Value.Visible;
		footerSpedizioniRaggruViaggio_Colli_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "COLLI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_Colli_Caption.Visible = footerSpedizioniRaggruViaggio_Colli_Value.Visible;
		footerSpedizioniRaggruViaggio_Volume_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "VOLUME", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_Volume_Caption.Visible = footerSpedizioniRaggruViaggio_Volume_Value.Visible;
		footerSpedizioniRaggruViaggio_Pallet_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "PALLET", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_Pallet_Caption.Visible = footerSpedizioniRaggruViaggio_Pallet_Value.Visible;
		footerSpedizioniRaggruViaggio_Spedizioni_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "SPEDIZIONI", "VISIBLE", "S"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_Spedizioni_Caption.Visible = footerSpedizioniRaggruViaggio_Spedizioni_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo1_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC1", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo1_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo1_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo2_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC2", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo2_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo2_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo3_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC3", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo3_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo3_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo4_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC4", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo4_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo4_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo5_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC5", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo5_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo5_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo6_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC6", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo6_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo6_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo7_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC7", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo7_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo7_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo8_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC8", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo8_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo8_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo9_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC9", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo9_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo9_Value.Visible;
		footerSpedizioniRaggruViaggio_CampoCalcolo10_Value.Visible = Operators.CompareString(base.ApplicationParams.UIComponentGetProperty("PIANIFICAZIONE_VIAGGI", "CC10", "VISIBLE", "N"), "S", false) == 0;
		footerSpedizioniRaggruViaggio_CampoCalcolo10_Caption.Visible = footerSpedizioniRaggruViaggio_CampoCalcolo10_Value.Visible;
	}

	public override FXRETURN IFrameClosed(string Tag, object objRet, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(Tag, "GESTISCISEQUENZA", false) == 0)
			{
				val = AggiornaElencoSpedizioniViaggio(ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0061;
				}
				val2 = val;
			}
			else
			{
				val = base.IFrameClosed(Tag, RuntimeHelpers.GetObjectValue(objRet), ref rsMess);
				if ((int)val <= 0)
				{
					goto IL_0061;
				}
				val2 = val;
			}
			goto end_IL_0005;
			IL_0061:
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
			CallStackRemove();
			result = val2;
		}
		return result;
	}

	private void lnkElencoConsegneSpedizioniCaption_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		LinkButton val = (LinkButton)sender;
		switch (val.CommandArgument)
		{
		case "SPEDIZIONI":
			((Control)DivGrdElencoSpedizioni).Visible = true;
			((Control)DivGrdElencoSpedizioniRaggru).Visible = false;
			((Control)DivGrdElencoSpedizioniRaggru2).Visible = false;
			break;
		case "CONSEGNE":
			((Control)DivGrdElencoSpedizioni).Visible = false;
			((Control)DivGrdElencoSpedizioniRaggru).Visible = true;
			((Control)DivGrdElencoSpedizioniRaggru2).Visible = false;
			break;
		case "DESTINAZIONI":
			((Control)DivGrdElencoSpedizioni).Visible = false;
			((Control)DivGrdElencoSpedizioniRaggru).Visible = false;
			((Control)DivGrdElencoSpedizioniRaggru2).Visible = true;
			break;
		}
	}
}
