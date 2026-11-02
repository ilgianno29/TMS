using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO.Foglione;

public class FoglioneManager : AppBaseClass
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__21_002D0
	{
		public Appointment _0024VB_0024Local_apnt;

		public _Closure_0024__21_002D0(_Closure_0024__21_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_apnt = arg0._0024VB_0024Local_apnt;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(Autista MyAutisti)
		{
			return Operators.CompareString(MyAutisti.Codice, _0024VB_0024Local_apnt.Autista, false) == 0;
		}

		[SpecialName]
		internal bool _Lambda_0024__2(Mezzo MyMezzi)
		{
			return Operators.CompareString(MyMezzi.Codice, _0024VB_0024Local_apnt.Mezzo, false) == 0;
		}

		[SpecialName]
		internal bool _Lambda_0024__4(Viaggio MyViaggi)
		{
			return (Operators.CompareString(MyViaggi.AutistaRiferimento, _0024VB_0024Local_apnt.Autista, false) == 0) & ((DateTime.Compare(MyViaggi.DataRiferimentoInizio, _0024VB_0024Local_apnt.Data) <= 0) & (DateTime.Compare(MyViaggi.DataRiferimentoFine, _0024VB_0024Local_apnt.Data) >= 0));
		}
	}

	protected FoglioneModel _Model;

	protected FoglioneFilter _Filter;

	protected string _QueryFilterViaggi;

	protected string _QueryFilterMezzi;

	protected string _QueryFilterSpedizioni;

	protected string _QueryFilterAppointment;

	protected string _QueryFilterAutisti;

	public FoglioneModel Model => _Model;

	public FoglioneFilter Filter => _Filter;

	public FoglioneManager(AppApiContext objApiContext, FoglioneModel Model, FoglioneFilter Filter)
		: base(objApiContext)
	{
		_QueryFilterViaggi = "";
		_QueryFilterMezzi = "";
		_QueryFilterSpedizioni = "";
		_QueryFilterAppointment = "";
		_QueryFilterAutisti = "";
		_Model = Model;
		_Filter = Filter;
		_QueryFilterViaggi = CreateQueryFilterViaggi();
		_QueryFilterMezzi = CreateQueryFilterMezzi();
		_QueryFilterSpedizioni = CreateQueryFilterSpedizioni();
		_QueryFilterAppointment = CreateQueryFilterAppointments();
		_QueryFilterAutisti = CreateQueryFilterAutisti();
	}

	private string CreateQueryFilterViaggi()
	{
		string text = "";
		string result;
		try
		{
			text = "(AUTISTA1PIANIFICATO IS NULL AND STATO <30 ";
			if (Operators.CompareString(_Filter.PCSPartena, "", false) != 0)
			{
				text = text + "AND PCSPARTENZA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.PCSPartena) + " ";
			}
			if (Operators.CompareString(_Filter.TipoMerce, "", false) != 0)
			{
				text = text + "AND TIPOMERCE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.TipoMerce) + " ";
			}
			if (Operators.CompareString(_Filter.TipoSpedizione, "", false) != 0)
			{
				text = text + "AND TIPOSPEDIZIONE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.TipoSpedizione) + " ";
			}
			if (Operators.CompareString(_Filter.ZonaPartenza, "", false) != 0)
			{
				text = text + "AND ZONAPARTENZA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.ZonaPartenza) + " ";
			}
			text += ") ";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	private string CreateQueryFilterMezzi()
	{
		string text = "";
		string result;
		try
		{
			text = "1=1 ";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	private string CreateQueryFilterSpedizioni()
	{
		string text = "";
		string result;
		try
		{
			text = "1=1 ";
			if (Operators.CompareString(_Filter.PCSPartena, "", false) != 0)
			{
				text = text + "AND PCSPARTENZA = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.PCSPartena) + " ";
			}
			if (Operators.CompareString(_Filter.TipoMerce, "", false) != 0)
			{
				text = text + "AND TIPOMERCE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.TipoMerce) + " ";
			}
			if (Operators.CompareString(_Filter.TipoSpedizione, "", false) != 0)
			{
				text = text + "AND TIPOSPEDIZIONE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.TipoSpedizione) + " ";
			}
			text = text + "AND DATARIFERIMENTO >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Filter.DataRiferimento);
			text = text + "AND DATARIFERIMENTO <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DateAndTime.DateAdd((DateInterval)4, 2.0, _Filter.DataRiferimento)) + " ";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	private string CreateQueryFilterAppointments()
	{
		string text = "";
		string result;
		try
		{
			text = "DATARIFERIMENTO >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Filter.DataRiferimento);
			text = text + "AND DATARIFERIMENTO <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DateAndTime.DateAdd((DateInterval)4, 2.0, _Filter.DataRiferimento)) + " ";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	private string CreateQueryFilterAutisti()
	{
		string text = "";
		string result;
		try
		{
			text = "1=1 ";
			if ((Operators.CompareString(_Filter.Pianificatore, "", false) != 0) & !_Filter.Admin)
			{
				text = text + "AND PIANIFICATORE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Filter.Pianificatore) + " ";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = text;
		}
		return result;
	}

	public FXRETURN LoadModel(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			List<Autista> ListOfAutisti = new List<Autista>();
			val2 = LoadAutisti(ref ListOfAutisti, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				Model.Autisti = ListOfAutisti;
				List<PlanningDate> ListOfPlanningDates = new List<PlanningDate>();
				val2 = LoadPlanningDates(ref ListOfPlanningDates, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					Model.PlanningDates = ListOfPlanningDates;
					List<Viaggio> ListOfViaggi = new List<Viaggio>();
					val2 = LoadViaggi(ref ListOfViaggi, ref rsMess);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						Model.Viaggi = ListOfViaggi;
						List<Mezzo> ListOfMezzi = new List<Mezzo>();
						val2 = LoadMezzi(ref ListOfMezzi, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							Model.Mezzi = ListOfMezzi;
							ListOfSpedizioni ListOfSpedizioni = null;
							val2 = LoadSpedizioni(ref ListOfSpedizioni, ref rsMess);
							if ((int)val2 > 0)
							{
								val = val2;
							}
							else
							{
								Model.Spedizioni = ListOfSpedizioni;
								List<MezzoLibero> ListOfMezziLiberi = new List<MezzoLibero>();
								val2 = LoadMezziLiberi(ref ListOfMezziLiberi, ref rsMess);
								if ((int)val2 > 0)
								{
									val = val2;
								}
								else
								{
									Model.MezziLiberi = ListOfMezziLiberi;
									List<Appointment> ListOfAppointments = new List<Appointment>();
									val2 = LoadAppointments(ref ListOfAppointments, ref rsMess);
									if ((int)val2 > 0)
									{
										val = val2;
									}
									else
									{
										Model.Appointments = ListOfAppointments;
										val = (FXRETURN)0;
									}
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
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadAutisti(ref List<Autista> ListOfAutisti, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		int num = 1;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM VW_FGL_AUTISTI WHERE " + _QueryFilterAutisti;
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				modGeneral.ConvertDataTableToList<Autista>(dataTable, ref ListOfAutisti);
				foreach (Autista item in ListOfAutisti)
				{
					item.Ordinale = num;
					num = checked(num + 1);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadPlanningDates(ref List<PlanningDate> ListOfPlanningDates, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			ListOfPlanningDates = new List<PlanningDate>
			{
				new PlanningDate
				{
					Data = _Filter.DataRiferimento
				},
				new PlanningDate
				{
					Data = _Filter.DataRiferimento.AddDays(1.0)
				},
				new PlanningDate
				{
					Data = _Filter.DataRiferimento.AddDays(2.0)
				}
			};
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadViaggi(ref List<Viaggio> ListOfViaggi, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM VW_FGL_VIAGGI WHERE (";
			text = text + "(DATARIFERIMENTOINIZIO >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Filter.DataRiferimento);
			text = text + "AND DATARIFERIMENTOINIZIO <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DateAndTime.DateAdd((DateInterval)4, 2.0, _Filter.DataRiferimento)) + ") ";
			text += "OR ";
			text = text + "(DATARIFERIMENTOFINE >= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Filter.DataRiferimento);
			text = text + "AND DATARIFERIMENTOFINE <= " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, DateAndTime.DateAdd((DateInterval)4, 2.0, _Filter.DataRiferimento)) + ") ";
			text += ") ";
			text = text + "AND (" + _QueryFilterViaggi + " OR ";
			text += "(1=2 ";
			foreach (Autista item in Model.Autisti)
			{
				text = text + "OR AUTISTARIFERIMENTO = " + ((AppBaseClass)this).DbConn.SQLFormatString(item.Codice) + " ";
			}
			text += "))";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				modGeneral.ConvertDataTableToList<Viaggio>(dataTable, ref ListOfViaggi);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadAppointments(ref List<Appointment> ListOfAppointments, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		int num = 1;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM VW_FGL_APPOINTMENTS WHERE " + _QueryFilterAppointment;
			text += "AND (1=2 ";
			foreach (Autista item in Model.Autisti)
			{
				text = text + "OR AUTISTA = " + ((AppBaseClass)this).DbConn.SQLFormatString(item.Codice) + " ";
			}
			text += ")";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				modGeneral.ConvertDataTableToList<Appointment>(dataTable, ref ListOfAppointments);
				using (List<Appointment>.Enumerator enumerator2 = ListOfAppointments.GetEnumerator())
				{
					_Closure_0024__21_002D0 closure_0024__21_002D = default(_Closure_0024__21_002D0);
					while (enumerator2.MoveNext())
					{
						closure_0024__21_002D = new _Closure_0024__21_002D0(closure_0024__21_002D);
						closure_0024__21_002D._0024VB_0024Local_apnt = enumerator2.Current;
						closure_0024__21_002D._0024VB_0024Local_apnt.Id = num;
						num = checked(num + 1);
						IEnumerable<Autista> source = from MyAutisti in Model.Autisti.Where(closure_0024__21_002D._Lambda_0024__0)
							select (MyAutisti);
						if (source.Count() > 0)
						{
							closure_0024__21_002D._0024VB_0024Local_apnt.objAutista = source.First();
							IEnumerable<Mezzo> source2 = from MyMezzi in Model.Mezzi.Where(closure_0024__21_002D._Lambda_0024__2)
								select (MyMezzi);
							if (source2.Count() > 0)
							{
								closure_0024__21_002D._0024VB_0024Local_apnt.objMezzo = source2.First();
							}
							IEnumerable<Viaggio> source3 = from MyViaggi in Model.Viaggi.Where(closure_0024__21_002D._Lambda_0024__4)
								orderby MyViaggi.Stato
								select (MyViaggi);
							if (source3.Count() > 0)
							{
								closure_0024__21_002D._0024VB_0024Local_apnt.objViaggi = source3.ToList();
							}
							continue;
						}
						rsMess = this.TranslateMessage("XXX", "Autista {0} non presente in anagrafica", new string[1] { closure_0024__21_002D._0024VB_0024Local_apnt.Autista });
						goto end_IL_0011;
					}
				}
				val = (FXRETURN)0;
			}
			end_IL_0011:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadSpedizioni(ref ListOfSpedizioni ListOfSpedizioni, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM VW_FGL_SPEDIZIONI WHERE " + _QueryFilterSpedizioni + " ";
			text += "UNION ";
			text += "SELECT * FROM VW_FGL_SPEDIZIONI WHERE 1=2";
			foreach (Viaggio item in Model.Viaggi)
			{
				text = text + " OR IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(item.IdViaggio.ToString()) + " ";
			}
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				List<Spedizione> o = new List<Spedizione>();
				modGeneral.ConvertDataTableToList<Spedizione>(dataTable, ref o);
				ListOfSpedizioni = new ListOfSpedizioni(o);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadMezzi(ref List<Mezzo> ListOfMezzi, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			List<string> list = new List<string>();
			text = "SELECT * FROM VW_FGL_MEZZI WHERE " + _QueryFilterMezzi;
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				modGeneral.ConvertDataTableToList<Mezzo>(dataTable, ref ListOfMezzi);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected FXRETURN LoadMezziLiberi(ref List<MezzoLibero> ListOfMezziLiberi, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			text = "EXEC sp_FGL_MezziLiberi " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Filter.DataRiferimento);
			DataSet dataSet = null;
			val2 = ((AppBaseClass)this).DbConn.OpenDataSet(text, ref dataSet, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				dataTable = dataSet.Tables[0];
				modGeneral.ConvertDataTableToList<MezzoLibero>(dataTable, ref ListOfMezziLiberi);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}
}
