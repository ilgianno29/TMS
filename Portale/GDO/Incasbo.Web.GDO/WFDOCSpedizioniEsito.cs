using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using Incasbo.Api.Gdo;
using Incasbo.Web.Components;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Telerik.Web.UI;

namespace Incasbo.Web.GDO;

public class WFDOCSpedizioniEsito : WFIDialogPage
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnVisualizza")]
	private IboWebButton _btnVisualizza;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EventoTipo")]
	private IboDropDownList _EventoTipo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Evento")]
	private IboWebComboTlk _Evento;

	protected const string kEsitoOK = "SPEDIZIONE.ESITO.OK";

	protected const string kEsitoKO = "SPEDIZIONE.ESITO.KO";

	protected const string kEsitoPARZ = "SPEDIZIONE.ESITO.PARZ";

	protected string _TipoEventoDefault;

	protected bool _WithOverrideGeneraRiconsegna;

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

	[field: AccessedThroughProperty("cpEstremi_Title")]
	protected virtual Panel cpEstremi_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEstremi_Title_Caption")]
	protected virtual IboWebLabel cpEstremi_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	protected virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumeroSpedizioni")]
	protected virtual IboWebLabel lblNumeroSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumeroSpedizioni")]
	protected virtual IboWebLabel NumeroSpedizioni
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebButton btnVisualizza
	{
		[CompilerGenerated]
		get
		{
			return _btnVisualizza;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnVisualizza_Click;
			IboWebButton val = _btnVisualizza;
			if (val != null)
			{
				((Button)val).Click -= eventHandler;
			}
			_btnVisualizza = value;
			val = _btnVisualizza;
			if (val != null)
			{
				((Button)val).Click += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("cpEsitazione_Title")]
	protected virtual Panel cpEsitazione_Title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEsitazione_Title_Caption")]
	protected virtual IboWebLabel cpEsitazione_Title_Caption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cpEstremi_Body")]
	protected virtual Panel cpEstremi_Body
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDataOra")]
	protected virtual IboWebLabel lblDataOra
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEsito")]
	protected virtual IboWebDate2 DataEsito
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEventoTipo")]
	protected virtual IboWebLabel lblEventoTipo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboDropDownList EventoTipo
	{
		[CompilerGenerated]
		get
		{
			return _EventoTipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = EventoTipo_SelectedIndexChanged;
			IboDropDownList eventoTipo = _EventoTipo;
			if (eventoTipo != null)
			{
				((ListControl)eventoTipo).SelectedIndexChanged -= eventHandler;
			}
			_EventoTipo = value;
			eventoTipo = _EventoTipo;
			if (eventoTipo != null)
			{
				((ListControl)eventoTipo).SelectedIndexChanged += eventHandler;
			}
		}
	}

	[field: AccessedThroughProperty("lblEvento")]
	protected virtual IboWebLabel lblEvento
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual IboWebComboTlk Evento
	{
		[CompilerGenerated]
		get
		{
			return _Evento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RadComboBoxSelectedIndexChangedEventHandler val = new RadComboBoxSelectedIndexChangedEventHandler(Evento_SelectedIndexChanged);
			IboWebComboTlk evento = _Evento;
			if (evento != null)
			{
				((RadComboBox)evento).SelectedIndexChanged -= val;
			}
			_Evento = value;
			evento = _Evento;
			if (evento != null)
			{
				((RadComboBox)evento).SelectedIndexChanged += val;
			}
		}
	}

	[field: AccessedThroughProperty("lblGeneraRiconsegna")]
	protected virtual IboWebLabel lblGeneraRiconsegna
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkGeneraRiconsegna")]
	protected virtual IboWebCheckBox chkGeneraRiconsegna
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

	[field: AccessedThroughProperty("Note")]
	protected virtual IboWebTextBox Note
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WFDOCSpedizioniEsito()
	{
		_TipoEventoDefault = "OK";
		_WithOverrideGeneraRiconsegna = false;
	}

	protected override FXRETURN InitializedPage(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			_Context = "DM.DOC.SPEDIZIONI#ESITO";
			_TipoEventoDefault = base.ApplicationDefault.TipoEsito_Default();
			if (Operators.CompareString(_TipoEventoDefault, "", false) == 0)
			{
				_TipoEventoDefault = "OK";
			}
			_WithOverrideGeneraRiconsegna = Operators.CompareString(base.ApplicationDefault.Esito_OverrideGeneraRiconsegna(), "S", false) == 0;
			_Title = base.Translator.Translate("XXX", "Esitazione Spedizioni", new string[0]);
			val2 = base.InitializedPage(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				base.btnAnnulla = btnAnnulla;
				base.btnConferma = btnConferma;
				base.lblDataAccessMode = lblDataAccessMode;
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
			val2 = base.BeforeLoadData(ref rsMess);
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

	protected override FXRETURN LoadData(ref string rsMess)
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
			val2 = base.LoadData(ref rsMess);
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

	protected override FXRETURN AfterLoadData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (((List<string>)_SessionVariable["UNIBOL"]).Count == 0)
			{
				rsMess = TranslateMessage("XXX", "Non esistono spedizioni da esitare");
			}
			else
			{
				val2 = base.AfterLoadData(ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(_TipoEventoDefault, "KO", false) == 0)
					{
						EventoTipo.ObjValue = "SPEDIZIONE.ESITO.KO";
					}
					else if (Operators.CompareString(_TipoEventoDefault, "PARZ", false) == 0)
					{
						EventoTipo.ObjValue = "SPEDIZIONE.ESITO.PARZ";
					}
					else
					{
						EventoTipo.ObjValue = "SPEDIZIONE.ESITO.OK";
					}
					text = "SELECT EVENTODEFAULT FROM EVENTI_TIPI WHERE CODICE = " + base.DbConn.SQLFormatString(EventoTipo.ObjValue.ToString());
					val2 = base.DbConn.DoSql(text, (object)"", ref obj, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						if (Operators.CompareString(Conversions.ToString(obj), "", false) != 0)
						{
							Evento.ObjValue = Conversions.ToString(obj);
						}
						if (Operators.CompareString(_TipoEventoDefault, "KO", false) == 0)
						{
							Evento.SqlQueryWhere = "TIPOEVENTO='SPEDIZIONE.ESITO.KO'";
							lblGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
							chkGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
						}
						else if (Operators.CompareString(_TipoEventoDefault, "PARZ", false) == 0)
						{
							Evento.SqlQueryWhere = "TIPOEVENTO='SPEDIZIONE.ESITO.PARZ'";
							lblGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
							chkGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
						}
						else
						{
							Evento.SqlQueryWhere = "TIPOEVENTO='SPEDIZIONE.ESITO.OK'";
							lblGeneraRiconsegna.Visible = false;
							chkGeneraRiconsegna.Visible = false;
						}
						NumeroSpedizioni.Text = ((List<string>)_SessionVariable["UNIBOL"]).Count.ToString();
						val = (FXRETURN)0;
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

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			val2 = base.CheckData(ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				string Warning = "";
				val2 = CheckDateEsitoSpedizione(ref Warning, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (Operators.CompareString(Warning, "", false) != 0)
					{
						_AreYouSureBlockedMessageType = WFIUserMessage.TipoMessageBox.YesNo;
						_AreYouSureBlockedMessageTitle = "Attenzione! Anomalie nella data di esitazione. Continuare con l'esitazione?";
						_AreYouSureBlockedMessage = Warning;
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

	protected override FXRETURN SaveData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between Unknown and I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Invalid comparison between Unknown and I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(EventoTipo.ObjValue.ToString(), "SPEDIZIONE.ESITO.OK", false) == 0)
			{
				foreach (string item in (List<string>)_SessionVariable["UNIBOL"])
				{
					val2 = Spedizione_ConsegnaOk_Invoker.Instance.RunProc(CreateApiContext(), item, Evento.ObjValue.ToString(), DataEsito.getDateValue, Note.ObjValue.ToString(), "", ref rsMess);
					if ((int)val2 > 0)
					{
						text += TranslateMessage("XXX", "Spedizione Id='{0}' non esitata: {1}", item, rsMess);
					}
				}
			}
			else if (Operators.CompareString(EventoTipo.ObjValue.ToString(), "SPEDIZIONE.ESITO.KO", false) == 0)
			{
				foreach (string item2 in (List<string>)_SessionVariable["UNIBOL"])
				{
					if (_WithOverrideGeneraRiconsegna)
					{
						val2 = Spedizione_ConsegnaKO_Invoker.Instance.RunProc(CreateApiContext(), item2, Evento.ObjValue.ToString(), ((CheckBox)chkGeneraRiconsegna).Checked, DataEsito.getDateValue, Note.ObjValue.ToString(), "", ref rsMess);
						if ((int)val2 > 0)
						{
							text += TranslateMessage("XXX", "Spedizione Id='{0}' non esitata: {1}", item2, rsMess);
						}
					}
					else
					{
						val2 = Spedizione_ConsegnaKO_Invoker.Instance.RunProc(CreateApiContext(), item2, Evento.ObjValue.ToString(), DataEsito.getDateValue, Note.ObjValue.ToString(), "", ref rsMess);
						if ((int)val2 > 0)
						{
							text += TranslateMessage("XXX", "Spedizione Id='{0}' non esitata: {1}", item2, rsMess);
						}
					}
				}
			}
			else if (Operators.CompareString(EventoTipo.ObjValue.ToString(), "SPEDIZIONE.ESITO.PARZ", false) == 0)
			{
				foreach (string item3 in (List<string>)_SessionVariable["UNIBOL"])
				{
					if (_WithOverrideGeneraRiconsegna)
					{
						val2 = Spedizione_ConsegnaParziale_Invoker.Instance.RunProc(CreateApiContext(), item3, Evento.ObjValue.ToString(), ((CheckBox)chkGeneraRiconsegna).Checked, DataEsito.getDateValue, Note.ObjValue.ToString(), "", ref rsMess);
						if ((int)val2 > 0)
						{
							text += TranslateMessage("XXX", "Spedizione Id='{0}' non esitata: {1}", item3, rsMess);
						}
					}
					else
					{
						val2 = Spedizione_ConsegnaParziale_Invoker.Instance.RunProc(CreateApiContext(), item3, Evento.ObjValue.ToString(), DataEsito.getDateValue, Note.ObjValue.ToString(), "", ref rsMess);
						if ((int)val2 > 0)
						{
							text += TranslateMessage("XXX", "Spedizione Id='{0}' non esitata: {1}", item3, rsMess);
						}
					}
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
			result = val;
			if (Operators.CompareString(text, "", false) != 0)
			{
				WriteErrorMessageWithReturnToCaller("Spedizioni non esitate", text);
			}
		}
		return result;
	}

	private void btnVisualizza_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			CallStackAdd();
			foreach (string item in (List<string>)_SessionVariable["UNIBOL"])
			{
				text = ((Operators.CompareString(text, "", false) != 0) ? (text + " OR (UNIBOL=" + base.DbConn.SQLFormatString(item) + ")") : (text + "(UNIBOL=" + base.DbConn.SQLFormatString(item) + ")"));
			}
			OpenGridOnlyForViewInIFrame("DM.DOC.SPEDIZIONI#ESITO_VIS", TranslateMessage("XXX", "Spedizioni da Esitare"), text, WFIMaster.IFrameDimension.IFrameContainer90Percent);
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

	private void EventoTipo_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		object obj = null;
		try
		{
			CallStackAdd();
			text = "TIPOEVENTO = " + base.DbConn.SQLFormatString(EventoTipo.ObjValue.ToString()) + " ";
			IboWebComboTlk evento = Evento;
			string sFilter = text;
			string rsMess2 = "";
			ComboSetFilter((IIboDropdownList)(object)evento, sFilter, "", ref rsMess2);
			text2 = "SELECT EVENTODEFAULT FROM EVENTI_TIPI WHERE CODICE = " + base.DbConn.SQLFormatString(EventoTipo.ObjValue.ToString());
			val2 = base.DbConn.DoSql(text2, (object)"", ref obj, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			if (Operators.CompareString(Conversions.ToString(obj), "", false) != 0)
			{
				val2 = ComboSelectedItem((IIboDropdownList)(object)Evento, Conversions.ToString(obj), ref rsMess);
				if ((int)val2 > 0)
				{
					return;
				}
				Evento_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), null);
			}
			if (Operators.CompareString(EventoTipo.ObjValue.ToString(), "SPEDIZIONE.ESITO.KO", false) == 0)
			{
				lblGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
				chkGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
			}
			else if (Operators.CompareString(EventoTipo.ObjValue.ToString(), "SPEDIZIONE.ESITO.PARZ", false) == 0)
			{
				lblGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
				chkGeneraRiconsegna.Visible = true & _WithOverrideGeneraRiconsegna;
			}
			else
			{
				lblGeneraRiconsegna.Visible = false;
				chkGeneraRiconsegna.Visible = false;
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private void Evento_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		try
		{
			CallStackAdd();
			if (Operators.CompareString(Evento.ObjValue.ToString(), "", false) == 0)
			{
				chkGeneraRiconsegna.ObjValue = "N";
			}
			else
			{
				text = "SELECT GeneraRiconsegna FROM Eventi WHERE Codice=" + base.DbConn.SQLFormatString(Evento.ObjValue.ToString());
				object obj = null;
				val2 = base.DbConn.DoSql(text, (object)"N", ref obj, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				chkGeneraRiconsegna.ObjValue = obj.ToString();
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
			if ((int)val > 0)
			{
				WriteErrorMessage(rsMess);
			}
			CallStackRemove();
		}
	}

	private FXRETURN CheckDateEsitoSpedizione(ref string Warning, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			Warning = "";
			if (!base.SessionEnvironment.ApplicationParams.DoCheckDateEsitoSpedizione())
			{
				goto IL_03c6;
			}
			text = "SELECT Unibol,DataConsegnaPrevista1, DataConsegnaPrevista2, DataConsegnaConcordata FROM Spedizioni WHERE 1=2 ";
			foreach (string item in (List<string>)_SessionVariable["UNIBOL"])
			{
				text = text + "OR (UNIBOL = " + base.DbConn.SQLFormatString(item) + ")";
			}
			val = base.DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
			if ((int)val <= 0)
			{
				checked
				{
					int num = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Information.IsDate((object)dataTable.Rows[i]["DataConsegnaConcordata"].ToString()))
						{
							if (DateTime.Compare(Conversions.ToDate(dataTable.Rows[i]["DataConsegnaConcordata"]).Date, DataEsito.getDateValue.Date) != 0)
							{
								Warning = Warning + TranslateMessage("XXX", "La spedizione {0} ha una data di consegna concordata {1} diversa da quella di esito {2}", dataTable.Rows[i]["Unibol"].ToString(), Conversions.ToDate(dataTable.Rows[i]["DataConsegnaConcordata"]).Date.ToShortDateString(), DataEsito.getDateValue.Date.ToShortDateString()) + "\r\n";
							}
						}
						else if (((Operators.CompareString(dataTable.Rows[i]["DataConsegnaPrevista1"].ToString(), "", false) != 0) & (Operators.CompareString(dataTable.Rows[i]["DataConsegnaPrevista2"].ToString(), "", false) != 0)) && !((DateTime.Compare(Conversions.ToDate(dataTable.Rows[i]["DataConsegnaPrevista1"]).Date, DataEsito.getDateValue.Date) <= 0) & (DateTime.Compare(Conversions.ToDate(dataTable.Rows[i]["DataConsegnaPrevista2"]).Date, DataEsito.getDateValue.Date) >= 0)))
						{
							Warning = Warning + TranslateMessage("XXX", "La spedizione {0} ha una data di esito {1} non compresa tra le date di prevista consegna {2} - {3}", dataTable.Rows[i]["Unibol"].ToString(), DataEsito.getDateValue.Date.ToShortDateString(), Conversions.ToDate(dataTable.Rows[i]["DataConsegnaPrevista1"]).Date.ToShortDateString(), Conversions.ToDate(dataTable.Rows[i]["DataConsegnaPrevista2"]).Date.ToShortDateString()) + "\r\n";
						}
					}
					goto IL_03c6;
				}
			}
			val2 = val;
			goto end_IL_000e;
			IL_03c6:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
}
