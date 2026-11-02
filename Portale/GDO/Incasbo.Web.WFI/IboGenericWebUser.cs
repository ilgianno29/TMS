using System;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public abstract class IboGenericWebUser : IDisposable, IIboResource
{
	protected string NomeTabella;

	protected string NomeTabellaUtentiFiliali;

	protected IboAppCallStackHandling _objCallStackHandler;

	protected IboAppLogHandling _objLogHandling;

	protected DBConnection _dbMain;

	protected IboWebParam _objParam;

	protected bool disposedValue;

	protected IboWebUserInfo _objWebUserInfo;

	protected WFIConfig _wfiConfig;

	public virtual IboWebUserInfo WebUserInfo => _objWebUserInfo;

	public string ResourceName => "SYSTEM.WFI.SECURITY.USER";

	public IboGenericWebUser(string sCodice, ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjLogHandling, ref DBConnection rObjDbMain, ref IboWebParam rObjParam, ref WFIConfig rObjWfiConfig)
	{
		NomeTabella = "";
		NomeTabellaUtentiFiliali = "";
		disposedValue = false;
		_objWebUserInfo = new IboWebUserInfo(sCodice);
		_objCallStackHandler = rObjCallStackHandler;
		_objLogHandling = rObjLogHandling;
		_dbMain = rObjDbMain;
		_objParam = rObjParam;
		NomeTabellaUtentiFiliali = "WFI_UtentiFiliali";
		_wfiConfig = rObjWfiConfig;
	}

	public virtual FXRETURN Load(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Invalid comparison between Unknown and I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Invalid comparison between Unknown and I4
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable dataTable = null;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "SELECT * FROM " + NomeTabella + " WHERE CODICE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice) + " ";
			val2 = _dbMain.OpenDataTable(text, ref _objWebUserInfo.dtUtente, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else if (_objWebUserInfo.dtUtente.Rows.Count == 0)
			{
				rsMess = "Username or group " + _objWebUserInfo.Codice + " doesn't exist";
			}
			else
			{
				_objWebUserInfo.Descrizione = _objWebUserInfo.dtUtente.Rows[0]["Descrizione"].ToString();
				_objWebUserInfo.Password = _objWebUserInfo.dtUtente.Rows[0]["Password"].ToString();
				_objWebUserInfo.Filtro = _objWebUserInfo.dtUtente.Rows[0]["Filtro"].ToString();
				_objWebUserInfo.AbilitazioneFiltroUtente = _objWebUserInfo.dtUtente.Rows[0]["FiltroUtente"].ToString();
				_objWebUserInfo.FiltroUtente = "";
				_objWebUserInfo.Attivo = _objWebUserInfo.dtUtente.Rows[0]["Attivo"].ToString();
				_objWebUserInfo.Tipo = _objWebUserInfo.dtUtente.Rows[0]["Tipo"].ToString();
				_objWebUserInfo.Gruppo = _objWebUserInfo.dtUtente.Rows[0]["Gruppo"].ToString();
				_objWebUserInfo.Organizzazione = _objWebUserInfo.dtUtente.Rows[0]["Organizzazione"].ToString();
				_objWebUserInfo.OrganizzazioneInternaEsterna = _objWebUserInfo.dtUtente.Rows[0]["OrganizzazioneInternaEsterna"].ToString();
				_objWebUserInfo.OrganizzazioneTipoSoggetto = _objWebUserInfo.dtUtente.Rows[0]["OrganizzazioneTipoSoggetto"].ToString();
				_objWebUserInfo.PaginaIniziale = _objWebUserInfo.dtUtente.Rows[0]["PaginaIniziale"].ToString();
				_objWebUserInfo.Peso = Convert.ToInt32(RuntimeHelpers.GetObjectValue(_objWebUserInfo.dtUtente.Rows[0]["Peso"]));
				_objWebUserInfo.ScadenzaPassword = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(_objWebUserInfo.dtUtente.Rows[0]["ScadenzaPassword"]));
				_objWebUserInfo.Lingua = _objWebUserInfo.dtUtente.Rows[0]["Lingua"].ToString();
				_objWebUserInfo.Nome = _objWebUserInfo.dtUtente.Rows[0]["Nome"].ToString();
				_objWebUserInfo.Cognome = _objWebUserInfo.dtUtente.Rows[0]["Cognome"].ToString();
				_objWebUserInfo.Indirizzo = _objWebUserInfo.dtUtente.Rows[0]["Indirizzo"].ToString();
				_objWebUserInfo.Localita = _objWebUserInfo.dtUtente.Rows[0]["Localita"].ToString();
				_objWebUserInfo.Provincia = _objWebUserInfo.dtUtente.Rows[0]["Provincia"].ToString();
				_objWebUserInfo.CAP = _objWebUserInfo.dtUtente.Rows[0]["CAP"].ToString();
				_objWebUserInfo.Telefono = _objWebUserInfo.dtUtente.Rows[0]["Telefono"].ToString();
				_objWebUserInfo.Cellulare = _objWebUserInfo.dtUtente.Rows[0]["Cellulare"].ToString();
				_objWebUserInfo.EMail = _objWebUserInfo.dtUtente.Rows[0]["EMail"].ToString();
				_objWebUserInfo.Cliente = _objWebUserInfo.dtUtente.Rows[0]["Cliente"].ToString();
				_objWebUserInfo.GiorniValidPwd = Convert.ToInt32(RuntimeHelpers.GetObjectValue(_objWebUserInfo.dtUtente.Rows[0]["GiorniValiditaPwd"]));
				_objWebUserInfo.MenuProfileID = _objWebUserInfo.dtUtente.Rows[0]["MenuProfileId"].ToString();
				_objWebUserInfo.DesktopProfileID = _objWebUserInfo.dtUtente.Rows[0]["DesktopProfileID"].ToString();
				_objWebUserInfo.FilialeDefault = "";
				_objWebUserInfo.Filiale = "";
				if (Operators.CompareString(NomeTabellaUtentiFiliali, "", false) == 0)
				{
					goto IL_0846;
				}
				bool flag = false;
				val2 = _dbMain.TableOrViewExists(NomeTabellaUtentiFiliali, ref flag, ref rsMess);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					if (!flag)
					{
						_objWebUserInfo.FilialeDefault = "NON_APPLICABILE";
						goto IL_0846;
					}
					string text2 = "";
					string filialeDescrizione = "";
					int num = 0;
					text = "SELECT UF.FILIALE, UF.IsDefault, F.Descrizione FROM " + NomeTabellaUtentiFiliali + " UF INNER JOIN WFI_Filiali F ON F.CODICE=UF.FILIALE WHERE UF.UTENTE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice);
					val2 = _dbMain.OpenDataTable(text, ref dataTable, ref rsMess);
					if ((int)val2 <= 0)
					{
						checked
						{
							string[] array = default(string[]);
							string[] array2 = default(string[]);
							foreach (DataRow row in dataTable.Rows)
							{
								if (Operators.CompareString(row["IsDefault"].ToString(), "S", false) == 0)
								{
									text2 = row["Filiale"].ToString();
									filialeDescrizione = row["Descrizione"].ToString();
								}
								array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
								array[num] = row["Filiale"].ToString();
								array2 = (string[])Utils.CopyArray((Array)array2, (Array)new string[num + 1]);
								array2[num] = row["Descrizione"].ToString();
								num++;
							}
							_objWebUserInfo.FilialeDefault = text2;
							_objWebUserInfo.Filiale = text2;
							_objWebUserInfo.FilialeDescrizione = filialeDescrizione;
							_objWebUserInfo.Filiali = array;
							_objWebUserInfo.FilialiDescrizione = array2;
							goto IL_0846;
						}
					}
					val = val2;
				}
			}
			goto end_IL_000e;
			IL_0846:
			val = (FXRETURN)0;
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN ModificaPassword(string vsCodice, string vsPassword, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "UPDATE " + NomeTabella + " SET ";
			// Si salva sempre l'hash PBKDF2 della nuova password (vsPassword arriva in chiaro)
			text = text + "PASSWORD=" + _dbMain.SQLFormatString(Incasbo.Security.UserPasswords.ForStorage(vsPassword)) + ", ";
			text = (((int)_dbMain.ServerTypeConnection != 1) ? (text + "SCADENZAPASSWORD=dateadd(d, GIORNIVALIDITAPWD, " + _dbMain.GetDate() + "), ") : (text + "SCADENZAPASSWORD=dateadd('d', GIORNIVALIDITAPWD, " + _dbMain.GetDate() + "), "));
			text = text + "UTEAGG=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice.ToUpper()) + ", ";
			text = text + "DATAGG=" + _dbMain.GetDate() + " ";
			text = text + "WHERE CODICE=" + _dbMain.SQLFormatString(vsCodice.ToUpper());
			val2 = _dbMain.SqlExec(text, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				val2 = Load(ref rsMess);
				val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN Delete(string vsCodice, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			text = "DELETE FROM " + NomeTabella + " ";
			text = text + "WHERE CODICE=" + _dbMain.SQLFormatString(vsCodice.ToUpper());
			val2 = _dbMain.SqlExec(text, ref rsMess);
			val = (((int)val2 <= 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
	}

	/// <summary>
	/// Verifica la password inserita (in chiaro) contro quella salvata: hash PBKDF2 oppure vecchio formato
	/// (cifrato con IboCrypt o in chiaro). Se e' nel vecchio formato e la verifica riesce, la riscrive come hash:
	/// ogni utente viene cosi' convertito al primo accesso.
	/// </summary>
	protected virtual bool VerificaPassword(string vsPassword)
	{
		bool cryptographyEnable = _wfiConfig != null && _wfiConfig.LoginManagerConfig.CryptographyEnable;
		if (!Incasbo.Security.UserPasswords.Verify(vsPassword, _objWebUserInfo.Password, cryptographyEnable, out bool needsUpgrade))
		{
			return false;
		}
		if (needsUpgrade)
		{
			try
			{
				string hash = Incasbo.Security.UserPasswords.ForStorage(vsPassword);
				string sql = "UPDATE " + NomeTabella + " SET PASSWORD=" + _dbMain.SQLFormatString(hash) + " WHERE CODICE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice.ToUpper());
				string rsMess = "";
				if ((int)_dbMain.SqlExec(sql, ref rsMess) <= 0)
				{
					_objWebUserInfo.Password = hash;
				}
			}
			catch (Exception)
			{
				// La conversione fallita (es. colonna ancora corta) non deve impedire l'accesso:
				// verra' ritentata al prossimo login.
			}
		}
		return true;
	}

	public FXRETURN Check(string vsPassword, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			_objCallStackHandler.CallStackAdd();
			rsMess = "";
			_objWebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.Unknown;
			if (_objWebUserInfo.dtUtente == null)
			{
				rsMess = "Username " + _objWebUserInfo.Codice + " not loaded ";
				_objWebUserInfo.AuthenticationError = rsMess;
			}
			else if (!TrustedLogin.IsToken(vsPassword) && !VerificaPassword(vsPassword))
			{
				_objWebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.PasswordNotCorrected;
				_objWebUserInfo.AuthenticationError = "Password errata";
				string text = "UPDATE WFI_UTENTI SET TentativiAccesso=%ISNULL%(TentativiAccesso,0) + 1, ATTIVO=CASE WHEN %ISNULL%(TentativiAccesso,0) + 1 > " + _wfiConfig.LoginManagerConfig.PasswordErrorBlockUserAfter + " THEN 'B' ELSE Attivo END WHERE CODICE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice);
				text = _dbMain.SqlConvertForServer(text);
				DBConnection dbMain = _dbMain;
				string text2 = text;
				string text3 = "";
				val2 = dbMain.SqlExec(text2, ref text3);
				if ((int)val2 > 0)
				{
					val = val2;
				}
				else
				{
					LogRisorseAzioni logRisorseAzioni = new LogRisorseAzioni();
					string resourceName = ResourceName;
					text3 = "";
					val2 = logRisorseAzioni.Inserisci(resourceName, "CHECKPASSWORD", "USERSMANAGER", "WRONG PASSWORD", "", ref text3);
					if ((int)val2 > 0)
					{
						val = val2;
					}
					else
					{
						object obj = null;
						text = "SELECT Attivo FROM WFI_UTENTI WHERE CODICE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice) + ";";
						val2 = _dbMain.DoSql(text, ref obj, ref rsMess);
						if ((int)val2 > 0)
						{
							val = val2;
						}
						else
						{
							if (Operators.CompareString(obj.ToString(), "B", false) != 0)
							{
								goto IL_02c3;
							}
							string resourceName2 = ResourceName;
							text3 = "";
							val2 = logRisorseAzioni.Inserisci(resourceName2, "USERBLOCKED", "USERSMANAGER", "USER HAS BEEN BLOCKED DUE TOO MANY WRONG PASSWORD ERRORS", "", ref text3);
							if ((int)val2 <= 0)
							{
								goto IL_02c3;
							}
							val = val2;
						}
					}
				}
			}
			else
			{
				if (DateTime.Compare(_objWebUserInfo.ScadenzaPassword, DateTime.Now) < 0)
				{
					_objWebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.PasswordExpired;
					_objWebUserInfo.AuthenticationError = "Password scaduta";
					goto IL_02c3;
				}
				_objWebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.Authenticated;
				_objWebUserInfo.AuthenticationError = "";
				string text4 = "UPDATE WFI_UTENTI SET TentativiAccesso=0 WHERE CODICE=" + _dbMain.SQLFormatString(_objWebUserInfo.Codice) + " AND TentativiAccesso>0";
				DBConnection dbMain2 = _dbMain;
				string text3 = "";
				val2 = dbMain2.SqlExec(text4, ref text3);
				if ((int)val2 <= 0)
				{
					LogRisorseAzioni logRisorseAzioni2 = new LogRisorseAzioni();
					goto IL_02c3;
				}
				val = val2;
			}
			goto end_IL_0005;
			IL_033c:
			val = (FXRETURN)0;
			goto end_IL_0005;
			IL_02c3:
			if (Operators.CompareString(_objWebUserInfo.FilialeDefault, "NON_APPLICABILE", false) == 0)
			{
				_objWebUserInfo.FilialeDefault = "";
				_objWebUserInfo.Filiale = "";
				goto IL_033c;
			}
			if (Operators.CompareString(_objWebUserInfo.FilialeDefault, "", false) != 0)
			{
				goto IL_033c;
			}
			_objWebUserInfo.Authenticated = IboWebUserInfo.AuthenticationState.Unknown;
			rsMess = "Nessuna filiale configurata per l'utente";
			end_IL_0005:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _objLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_objCallStackHandler.CallStackRemove();
			result = val;
		}
		return result;
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

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
			}
			_objCallStackHandler = null;
			_objWebUserInfo.dtUtente = null;
			_dbMain = null;
		}
		disposedValue = true;
	}
}
