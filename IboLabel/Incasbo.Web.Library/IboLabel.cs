using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Incasbo.Api.App;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace Incasbo.Web.Library;

public class IboLabel : AppBaseClass, IDisposable
{
	protected class ItemToPrint
	{
		public string Stampante { get; set; }

		public bool ManageAsFile { get; set; }

		public string Asincrona { get; set; }

		public string StringToSend { get; set; }

		public string File { get; set; }

		public DataTable Dati { get; set; }

		public DataRow EtichetteStampantiRow { get; set; }

		public ItemToPrint()
		{
			string stampante = "";
			Stampante = stampante;
			bool manageAsFile = false;
			ManageAsFile = manageAsFile;
			stampante = "";
			Asincrona = stampante;
			stampante = "";
			StringToSend = stampante;
			stampante = "";
			File = stampante;
			DataTable dati = null;
			Dati = dati;
			DataRow etichetteStampantiRow = null;
			EtichetteStampantiRow = etichetteStampantiRow;
		}
	}

	protected class ItemsToPrint : Dictionary<string, ItemToPrint>
	{
	}

	protected bool _Loaded;

	protected DataTable _dtEtichette;

	protected DataTable _dtEtichetteStampanti;

	protected DataTable _dtEtichetteFile;

	protected DataTable _dtEtichetteCampi;

	protected string _FileDir;

	protected string _FileCustomDir;

	protected Dictionary<string, string> _File;

	protected DataRow _EtichettaRow;

	protected string _Etichetta;

	protected string _Filtro;

	protected DataTable _dtDati;

	protected ItemToPrint[] _ItemsToPrint;

	private bool disposedValue;

	public IboLabel(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Loaded = false;
		_dtEtichette = null;
		_dtEtichetteStampanti = null;
		_dtEtichetteFile = null;
		_dtEtichetteCampi = null;
		_FileDir = "";
		_FileCustomDir = "";
		_File = new Dictionary<string, string>();
		_EtichettaRow = null;
		_Etichetta = "";
		_Filtro = "";
		_dtDati = null;
	}

	public virtual FXRETURN LoadConfig(string FileDir, string FileCustomDir, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_FileDir = FileDir;
			if (!Directory.Exists(_FileDir))
			{
				rsmess = this.TranslateMessage("XXX", "Il direttorio {0} non esiste", new string[1] { _FileDir });
			}
			else
			{
				if (Operators.CompareString(FileCustomDir, "", false) == 0)
				{
					_FileCustomDir = "";
					goto IL_00af;
				}
				_FileCustomDir = FileCustomDir;
				if (Directory.Exists(_FileCustomDir))
				{
					goto IL_00af;
				}
				rsmess = this.TranslateMessage("XXX", "Il direttorio {0} non esiste", new string[1] { _FileCustomDir });
			}
			goto end_IL_000a;
			IL_00af:
			text = "SELECT * FROM WFI_Etichette";
			val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEtichette, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				text = "SELECT * FROM WFI_EtichetteStampanti WHERE Etichetta IN (SELECT Codice FROM WFI_Etichette)";
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEtichetteStampanti, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					text = "SELECT * FROM WFI_EtichetteFile WHERE Etichetta IN (SELECT Codice FROM WFI_Etichette)";
					val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEtichetteFile, ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						text = "SELECT * FROM WFI_EtichetteCampi WHERE Etichetta IN (SELECT Codice FROM WFI_Etichette)";
						val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEtichetteCampi, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							_Loaded = true;
							val = (FXRETURN)0;
						}
					}
				}
			}
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN LoadConfig(string FileDir, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = LoadConfig(FileDir, "", ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Destroy(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (_dtEtichette != null)
			{
				_dtEtichette.Dispose();
				_dtEtichette = null;
			}
			if (_dtEtichetteStampanti != null)
			{
				_dtEtichetteStampanti.Dispose();
				_dtEtichetteStampanti = null;
			}
			if (_dtEtichetteFile != null)
			{
				_dtEtichetteFile.Dispose();
				_dtEtichetteFile = null;
			}
			if (_dtEtichetteCampi != null)
			{
				_dtEtichetteCampi.Dispose();
				_dtEtichetteCampi = null;
			}
			_Loaded = false;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Stampa(string Etichetta, string Filtro, bool DisabilitaStampaAsincrona, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_EtichettaRow = null;
			_Etichetta = Etichetta;
			_Filtro = Filtro;
			_ItemsToPrint = null;
			val2 = TrovaEtichetta(ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_EtichettaRow["Attiva"].ToString(), "S", false) != 0)
				{
					goto IL_0128;
				}
				text = "SELECT * FROM " + _EtichettaRow["NomeVista"].ToString() + " WHERE 1=1 AND " + _Filtro;
				val2 = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtDati, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (_dtDati.Rows.Count <= 0)
					{
						goto IL_0128;
					}
					val2 = CreateItemsToPrint(ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						val2 = TrovaStampanti(ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							val2 = TrovaFile(ref rsmess);
							if ((int)val2 != 0)
							{
								val = val2;
							}
							else
							{
								val2 = ProduciStampa(ref rsmess);
								if ((int)val2 != 0)
								{
									val = val2;
								}
								else
								{
									val2 = IndirizzaStampa(DisabilitaStampaAsincrona, ref rsmess);
									if ((int)val2 == 0)
									{
										goto IL_0128;
									}
									val = val2;
								}
							}
						}
					}
				}
			}
			goto end_IL_000a;
			IL_0128:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (_dtDati != null)
			{
				_dtDati.Dispose();
				_dtDati = null;
			}
			string rsmess2 = "";
			DestroyItemToPrint(ref rsmess2);
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Stampa(string Etichetta, DataTable dtDataToPrint, bool DisabilitaStampaAsincrona, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_EtichettaRow = null;
			_Etichetta = Etichetta;
			_Filtro = "";
			_ItemsToPrint = null;
			val2 = TrovaEtichetta(ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(_EtichettaRow["Attiva"].ToString(), "S", false) != 0)
				{
					goto IL_00df;
				}
				_dtDati = dtDataToPrint;
				if (_dtDati.Rows.Count <= 0)
				{
					goto IL_00df;
				}
				val2 = CreateItemsToPrint(ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					val2 = TrovaStampanti(ref rsmess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						val2 = TrovaFile(ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else
						{
							val2 = ProduciStampa(ref rsmess);
							if ((int)val2 != 0)
							{
								val = val2;
							}
							else
							{
								val2 = IndirizzaStampa(DisabilitaStampaAsincrona, ref rsmess);
								if ((int)val2 == 0)
								{
									goto IL_00df;
								}
								val = val2;
							}
						}
					}
				}
			}
			goto end_IL_000a;
			IL_00df:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			string rsmess2 = "";
			DestroyItemToPrint(ref rsmess2);
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Stampa(string Etichetta, string Filtro, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val2 = Stampa(Etichetta, Filtro, DisabilitaStampaAsincrona: false, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN StampaDiretta(string Stampante, string StringToSend, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			bool ManageAsFile = false;
			val2 = VerificaEsistenzaStampante(Stampante, ref ManageAsFile, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (!ManageAsFile)
				{
					RawPrinterHelper.SendStringToPrinter(Stampante, StringToSend);
				}
				else
				{
					WriteToGenericFile(ref Stampante, ref StringToSend);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN StampaDiretta(string Stampante, byte[] BytesToSend, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			bool ManageAsFile = false;
			val2 = VerificaEsistenzaStampante(Stampante, ref ManageAsFile, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (!ManageAsFile)
				{
					RawPrinterHelper.SendStringToPrinter(Stampante, ByteArrayToStr(BytesToSend));
				}
				else
				{
					string sText = ByteArrayToStr(BytesToSend);
					WriteToGenericFile(ref Stampante, ref sText);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected void WriteToGenericFile(ref string sPortOrFile, ref string sText)
	{
		long value = Win32API.CreateFile(ref sPortOrFile, 1073741824, 0, 0, 2, 0, 0);
		IntPtr preexistingHandle = new IntPtr(value);
		SafeFileHandle safeFileHandle = new SafeFileHandle(preexistingHandle, ownsHandle: true);
		FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
		fileStream.Flush();
		StreamWriter streamWriter = new StreamWriter(fileStream);
		streamWriter.Write(sText);
		fileStream.Flush();
		streamWriter.Close();
		fileStream.Close();
		safeFileHandle.Close();
	}

	public virtual FXRETURN ExistsLabel(string CodiceEtichetta, ref bool bExists, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DataRow[] array = _dtEtichette.Select("Codice='" + CodiceEtichetta + "'");
			if (array.Count() == 0)
			{
				bExists = false;
			}
			else if (Operators.CompareString(array[0]["Attiva"].ToString(), "S", false) == 0)
			{
				bExists = true;
			}
			else
			{
				bExists = false;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN TrovaEtichetta(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DataRow[] array = _dtEtichette.Select("Codice='" + _Etichetta + "'");
			if (array.Count() == 0)
			{
				rsmess = this.TranslateMessage("XXX", "L'etichetta {0} non risulta configurata", new string[1] { _Etichetta });
			}
			else
			{
				_EtichettaRow = array[0];
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN TrovaStampanti(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringCollection stringCollection = new StringCollection();
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ItemToPrint[] itemsToPrint = _ItemsToPrint;
			foreach (ItemToPrint itemToPrint in itemsToPrint)
			{
				stringCollection.Clear();
				stringCollection.Add(base._User);
				stringCollection.Add(base._Group);
				stringCollection.Add(base._Organization);
				stringCollection.Add("XXX");
				stringCollection.Add("*ALL");
				flag = false;
				StringEnumerator enumerator = stringCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					DataRow[] array = _dtEtichetteStampanti.Select("Utente=" + ((AppBaseClass)this).DbConn.SQLFormatString(current), "Condizione ASC");
					DataRow[] array2 = array;
					foreach (DataRow dataRow in array2)
					{
						if (Operators.CompareString(dataRow["Condizione"].ToString(), "", false) == 0)
						{
							flag = true;
							itemToPrint.EtichetteStampantiRow = dataRow;
							break;
						}
						if (itemToPrint.Dati.Select(dataRow["Condizione"].ToString()).Count() > 0)
						{
							flag = true;
							itemToPrint.EtichetteStampantiRow = dataRow;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (itemToPrint.EtichetteStampantiRow != null)
				{
					itemToPrint.Stampante = itemToPrint.EtichetteStampantiRow["Stampante"].ToString();
					itemToPrint.Asincrona = itemToPrint.EtichetteStampantiRow["Asincrona"].ToString();
				}
				if (Operators.CompareString(itemToPrint.Stampante, "", false) == 0)
				{
					itemToPrint.Stampante = _EtichettaRow["StampanteDefault"].ToString();
				}
				if (Operators.CompareString(itemToPrint.Asincrona, "", false) == 0)
				{
					itemToPrint.Asincrona = _EtichettaRow["Asincrona"].ToString();
				}
				if (Operators.CompareString(itemToPrint.Asincrona, "", false) == 0)
				{
					itemToPrint.Asincrona = "N";
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN CreateItemsToPrint(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				this.CallStackAdd();
				rsmess = "";
				_ItemsToPrint = null;
				int num = 0;
				foreach (DataRow row in _dtDati.Rows)
				{
					ItemToPrint itemToPrint = new ItemToPrint();
					DataTable dataTable = _dtDati.Clone();
					dataTable.ImportRow(row);
					itemToPrint.Dati = dataTable;
					_ItemsToPrint = (ItemToPrint[])Utils.CopyArray((Array)_ItemsToPrint, (Array)new ItemToPrint[num + 1]);
					_ItemsToPrint[num] = itemToPrint;
					num++;
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = this.HandleError(ref ex2, ref rsmess);
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

	protected virtual FXRETURN TrovaFile(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ItemToPrint[] itemsToPrint = _ItemsToPrint;
			int num = 0;
			while (true)
			{
				if (num < itemsToPrint.Length)
				{
					ItemToPrint itemToPrint = itemsToPrint[num];
					DataRow[] array = _dtEtichetteFile.Select("Etichetta=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Etichetta) + " AND Stampante=" + ((AppBaseClass)this).DbConn.SQLFormatString(itemToPrint.Stampante));
					if (array.Count() == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Impossibile determinare il nome del file di configurazione dell'etichetta {0}", new string[1] { _Etichetta });
						break;
					}
					itemToPrint.File = array[0]["NomeFile"].ToString();
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN ProduciStampa(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		string text3 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ItemToPrint[] itemsToPrint = _ItemsToPrint;
			int num = 0;
			while (true)
			{
				if (num < itemsToPrint.Length)
				{
					ItemToPrint itemToPrint = itemsToPrint[num];
					if (_File.ContainsKey(itemToPrint.File))
					{
						text3 = _File[itemToPrint.File];
					}
					else
					{
						string text4 = _FileDir + itemToPrint.File;
						string text5 = "";
						string path = "";
						if (Operators.CompareString(_FileCustomDir, "", false) != 0)
						{
							text5 = _FileCustomDir + itemToPrint.File;
						}
						bool flag = true;
						if (Operators.CompareString(text5, "", false) != 0)
						{
							if (!File.Exists(text5))
							{
								if (!File.Exists(text4))
								{
									flag = false;
								}
								else
								{
									path = text4;
								}
							}
							else
							{
								path = text5;
							}
						}
						else if (!File.Exists(text4))
						{
							flag = false;
						}
						else
						{
							path = text4;
						}
						if (!flag)
						{
							rsmess = this.TranslateMessage("XXX", "Il file {0} non esiste", new string[1] { itemToPrint.File });
							break;
						}
						text3 = File.ReadAllText(path);
						_File.Add(itemToPrint.File, text3);
					}
					DataRow[] array = _dtEtichetteCampi.Select("Etichetta=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Etichetta));
					text2 = "";
					foreach (DataRow row in itemToPrint.Dati.Rows)
					{
						DataRow dataRow = row;
						text = text3;
						DataRow[] array2 = array;
						foreach (DataRow dataRow2 in array2)
						{
							string newValue = "";
							if (modGeneral.ExistsFieldInDatarow(ref dataRow, dataRow2["Campo"].ToString()))
							{
								newValue = ((Operators.CompareString(dataRow2["Formattazione"].ToString(), "", false) != 0) ? ((Operators.CompareString(dataRow[dataRow2["Campo"].ToString()].ToString(), "", false) == 0) ? "" : Strings.Format(RuntimeHelpers.GetObjectValue(dataRow[dataRow2["Campo"].ToString()]), dataRow2["Formattazione"].ToString())) : dataRow[dataRow2["Campo"].ToString()].ToString());
							}
							text = text.Replace(dataRow2["Segnaposto"].ToString().ToUpper(), newValue);
						}
						text2 += text;
					}
					itemToPrint.StringToSend = text2;
					num = checked(num + 1);
					continue;
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN IndirizzaStampa(bool DisabilitaStampaAsincrona, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Invalid comparison between Unknown and I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		ItemsToPrint itemsToPrint = new ItemsToPrint();
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ItemToPrint[] itemsToPrint2 = _ItemsToPrint;
			foreach (ItemToPrint itemToPrint in itemsToPrint2)
			{
				string key = itemToPrint.Stampante + "-" + itemToPrint.Asincrona;
				ItemToPrint itemToPrint2;
				if (itemsToPrint.ContainsKey(key))
				{
					itemToPrint2 = itemsToPrint[key];
				}
				else
				{
					itemToPrint2 = new ItemToPrint();
					itemToPrint2.Stampante = itemToPrint.Stampante;
					itemToPrint2.Asincrona = itemToPrint.Asincrona;
					itemsToPrint.Add(key, itemToPrint2);
				}
				itemToPrint2.StringToSend += itemToPrint.StringToSend;
			}
			foreach (ItemToPrint value in itemsToPrint.Values)
			{
				string stampante = value.Stampante;
				ItemToPrint itemToPrint3 = value;
				bool ManageAsFile = itemToPrint3.ManageAsFile;
				FXRETURN val3 = VerificaEsistenzaStampante(stampante, ref ManageAsFile, ref rsmess);
				itemToPrint3.ManageAsFile = ManageAsFile;
				val2 = val3;
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					if (DisabilitaStampaAsincrona)
					{
						value.Asincrona = "N";
					}
					if (Operators.CompareString(value.Asincrona, "S", false) != 0)
					{
						if (value.ManageAsFile)
						{
							itemToPrint3 = value;
							string sPortOrFile = itemToPrint3.Stampante;
							ItemToPrint itemToPrint4 = value;
							string sText = itemToPrint4.StringToSend;
							WriteToGenericFile(ref sPortOrFile, ref sText);
							itemToPrint4.StringToSend = sText;
							itemToPrint3.Stampante = sPortOrFile;
						}
						else
						{
							RawPrinterHelper.SendStringToPrinter(value.Stampante, value.StringToSend);
						}
						continue;
					}
					text = "INSERT INTO WFI_EtichetteQueue (NomEti,Utente,Filtro,ContentToPrint,ContentExtension,Printer,ContentCreationDate,UteIns,UteAgg) VALUES (";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Etichetta) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(base._User) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Filtro) + ", ";
					byte[] ba = StrToByteArray(value.StringToSend);
					text = text + ((AppBaseClass)this).DbConn.ConvertToVarbinary(ByteArrayToHexString(ba)) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString("TXT") + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(value.Stampante) + ", ";
					text = text + ((AppBaseClass)this).DbConn.GetDate() + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(base._User) + ", ";
					text = text + ((AppBaseClass)this).DbConn.SQLFormatString(base._User) + ")";
					val2 = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val2 == 0)
					{
						continue;
					}
					val = val2;
				}
				goto end_IL_0011;
			}
			val = (FXRETURN)0;
			end_IL_0011:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected string ByteArrayToHexString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	protected string ByteArrayToStr(byte[] dBytes)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return uTF8Encoding.GetString(dBytes);
	}

	protected byte[] StrToByteArray(string str)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return uTF8Encoding.GetBytes(str);
	}

	protected virtual FXRETURN DestroyItemToPrint(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ItemToPrint[] itemsToPrint = _ItemsToPrint;
			foreach (ItemToPrint itemToPrint in itemsToPrint)
			{
				itemToPrint.Dati.Dispose();
				itemToPrint.Dati = null;
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN VerificaEsistenzaStampante(string Stampante, ref bool ManageAsFile, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		bool flag = false;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ManageAsFile = false;
			PrinterSettings.StringCollection installedPrinters = PrinterSettings.InstalledPrinters;
			foreach (object item in installedPrinters)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(item);
				if (Operators.CompareString(objectValue.ToString().ToUpper(), Stampante.ToUpper(), false) == 0)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				goto IL_00b6;
			}
			if (Operators.CompareString(Strings.Left(Stampante, 2), "\\\\", false) == 0)
			{
				ManageAsFile = true;
				goto IL_00b6;
			}
			rsmess = this.TranslateMessage("XXX", "La stampante {0} non esiste tra l'elenco delle stampanti installate", new string[1] { Stampante });
			goto end_IL_0006;
			IL_00b6:
			val = (FXRETURN)0;
			end_IL_0006:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual void Dispose(bool disposing)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!disposedValue && disposing)
		{
			string rsmess = "";
			Destroy(ref rsmess);
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
