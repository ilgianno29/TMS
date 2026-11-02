using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using static Incasbo.Web.Library.modGeneral;
namespace Incasbo.Web.Library;

public class DBConnection : IDisposable, ICloneable
{
	private string kDatab0003;

	private string kDatab0002;

	private string kDatab0001;

	private string kDatab0004;

	protected IDbConnection _Connection;

	protected DBConnection _Conn;

	protected IDbTransaction _Transaction;

	protected bool _InTrans;

	protected string _ConnectionString;

	protected string _Server;

	protected string _Database;

	protected string _User;

	protected string _Password;

	protected bool _UseIntegratedSecurity;

	protected DBFormatFunctions.eServerType eServerType;

	protected DBFormatFunctions.eProviderType _ProviderType;

	protected bool _ConnectionOpen;

	protected int _TimeOut;

	protected string _Provider;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected IncasTranslator _Translator;

	private bool disposed;

	public DBFormatFunctions.eProviderType ProviderType => _ProviderType;

	public string Provider => _Provider;

	public string Server => _Server;

	public DBFormatFunctions.eServerType ServerType => eServerType;

	public string DataBase => _Database;

	public string User => _User;

	public string Password => _Password;

	public bool UseIntegratedSecurity => _UseIntegratedSecurity;

	public int TimeOut => _TimeOut;

	public IDbConnection ConnectionObject => _Connection;

	public bool TransactionOpen => _InTrans;

	public IDbTransaction TransactionObject
	{
		get
		{
			CheckIfDisposed();
			return _Transaction;
		}
	}

	public DBFormatFunctions.eServerType ServerTypeConnection => eServerType;

	public bool ConnectionOpen => _ConnectionOpen;

	public string ConnectionString => _ConnectionString;

	public string DBMSLanguage { get; set; }

	private DBConnection(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
	{
		kDatab0003 = "";
		kDatab0002 = "";
		kDatab0001 = "";
		kDatab0004 = "";
		_ConnectionString = "";
		_Server = "";
		_Database = "";
		_User = "";
		_Password = "";
		_UseIntegratedSecurity = false;
		_ProviderType = DBFormatFunctions.eProviderType.OleDb;
		_ConnectionOpen = false;
		_Provider = "";
		disposed = false;
		string dBMSLanguage = "";
		DBMSLanguage = dBMSLanguage;
		_Translator = rObjTranslator;
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		ConfigureMessage();
	}

	public DBConnection(string v_ConnectionString, DBFormatFunctions.eServerType veServerType, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
		: this(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjTranslator)
	{
		_ConnectionString = v_ConnectionString;
		eServerType = veServerType;
		_TimeOut = 60;
	}

	public DBConnection(string v_ConnectionString, DBFormatFunctions.eServerType veServerType, int v_TimeOut, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
		: this(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjTranslator)
	{
		_ConnectionString = v_ConnectionString;
		eServerType = veServerType;
		_TimeOut = v_TimeOut;
		if (_TimeOut == 0)
		{
			_TimeOut = 60;
		}
	}

	public DBConnection(string vsServer, DBFormatFunctions.eServerType veServerType, string vsDataBase, string vsUser, string vsPassword, bool bUseIntegratedSecurity, int v_TimeOut, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
		: this("", vsServer, veServerType, vsDataBase, vsUser, vsPassword, bUseIntegratedSecurity, v_TimeOut, rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjTranslator)
	{
	}

	public DBConnection(string vsProvider, string vsServer, DBFormatFunctions.eServerType veServerType, string vsDataBase, string vsUser, string vsPassword, bool bUseIntegratedSecurity, int v_TimeOut, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
		: this(DBFormatFunctions.eProviderType.OleDb, vsProvider, vsServer, veServerType, vsDataBase, vsUser, vsPassword, bUseIntegratedSecurity, v_TimeOut, rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjTranslator)
	{
	}

	public DBConnection(DBFormatFunctions.eProviderType veProviderType, string vsProvider, string vsServer, DBFormatFunctions.eServerType veServerType, string vsDataBase, string vsUser, string vsPassword, bool bUseIntegratedSecurity, int v_TimeOut, IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref IncasTranslator rObjTranslator)
		: this(ref rObjCallStackHandler, ref rObjIboAppLogHandling, ref rObjTranslator)
	{
		string connectionString = "";
		_ProviderType = veProviderType;
		_Provider = vsProvider;
		eServerType = veServerType;
		_Server = vsServer;
		_Database = vsDataBase;
		_User = vsUser;
		_Password = vsPassword;
		_UseIntegratedSecurity = bUseIntegratedSecurity;
		if (eServerType == DBFormatFunctions.eServerType.AS400)
		{
			_ProviderType = DBFormatFunctions.eProviderType.Odbc;
			_UseIntegratedSecurity = false;
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			_ProviderType = DBFormatFunctions.eProviderType.SQLiteClient;
			_UseIntegratedSecurity = false;
		}
		if (_ProviderType == DBFormatFunctions.eProviderType.OleDb)
		{
			if ((Operators.CompareString(_Provider.Trim(), "", false) == 0) & (eServerType == DBFormatFunctions.eServerType.Oracle))
			{
				_Provider = "MSDAORA.1";
			}
			else if ((Operators.CompareString(_Provider.Trim(), "", false) == 0) & (eServerType == DBFormatFunctions.eServerType.SQL))
			{
				_Provider = "SQLOLEDB";
			}
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType == DBFormatFunctions.eServerType.Oracle)
			{
				connectionString = "Provider=" + _Provider + ";User ID=" + _User + ";Data Source=" + _Server + ";Password=" + _Password + ";";
			}
			else
			{
				if (eServerType != 0)
				{
					string message = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
					throw new Exception(message);
				}
				connectionString = ((!_UseIntegratedSecurity) ? ("Provider=" + _Provider + ";Persist Security Info=False;User ID=" + _User + ";Password=" + _Password + ";Initial Catalog=" + _Database + ";Server=" + _Server + ";Connect Timeout=" + _TimeOut + ";") : ("Provider=" + _Provider + ";Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=" + _Database + ";Server=" + _Server + ";Connect Timeout=" + _TimeOut + ";"));
			}
		}
		else if (_ProviderType == DBFormatFunctions.eProviderType.Odbc)
		{
			if ((Operators.CompareString(_Provider.Trim(), "", false) == 0) & (eServerType == DBFormatFunctions.eServerType.Oracle))
			{
				_Provider = "{Oracle Home}";
			}
			else if ((Operators.CompareString(_Provider.Trim(), "", false) == 0) & (eServerType == DBFormatFunctions.eServerType.SQL))
			{
				_Provider = "{SQL Server}";
			}
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType == DBFormatFunctions.eServerType.Oracle)
			{
				connectionString = "DRIVER=<%ODBCName%>;SERVER=<%ServerNome%>;DBQ=<%ServerNome%>;UID=<%ServerUtente%>;PWD=<%ServerPassword%>;APP=<%AppTitle%>;";
			}
			else if (eServerType == DBFormatFunctions.eServerType.SQL)
			{
				connectionString = "DRIVER=<%ODBCName%>;SERVER=<%ServerNome%>;DATABASE=<%ServerDB%>;UID=<%ServerUtente%>;PWD=<%ServerPassword%>;APP=<%AppTitle%>;";
				if (_UseIntegratedSecurity)
				{
					connectionString += "INTEGRATED SECURITY=SSPI;";
				}
			}
			else
			{
				if (eServerType != DBFormatFunctions.eServerType.AS400)
				{
					string message2 = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
					throw new Exception(message2);
				}
				connectionString = "Dsn=<%ServerNome%>;uid=<%ServerUtente%>;pwd=<%ServerPassword%>;";
			}
			connectionString = Strings.Replace(connectionString, "<%ODBCName%>", _Provider, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerNome%>", _Server, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerDB%>", _Database, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerUtente%>", _User, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerPassword%>", _Password, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%AppTitle%>", "", 1, -1, (CompareMethod)0);
		}
		else if (_ProviderType == DBFormatFunctions.eProviderType.SqlClient)
		{
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType != 0)
			{
				string message3 = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
				throw new Exception(message3);
			}
			connectionString = "Data Source=<%ServerNome%>;Initial Catalog=<%ServerDB%>;User ID=<%ServerUtente%>;Password=<%ServerPassword%>;Application Name=<%AppTitle%>;";
			connectionString = Strings.Replace(connectionString, "<%ServerNome%>", _Server, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerDB%>", _Database, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerUtente%>", _User, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerPassword%>", _Password, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%AppTitle%>", "", 1, -1, (CompareMethod)0);
		}
		else if (_ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
		{
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType != DBFormatFunctions.eServerType.Oracle)
			{
				string message4 = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
				throw new Exception(message4);
			}
			connectionString = "Data Source=<%ServerNome%>;";
			connectionString += "User ID=<%ServerUtente%>;";
			connectionString += "Password=<%ServerPassword%>;";
			connectionString = Strings.Replace(connectionString, "<%ServerNome%>", _Server, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerDB%>", _Database, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerUtente%>", _User, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerPassword%>", _Password, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%AppTitle%>", "", 1, -1, (CompareMethod)0);
		}
		else if (_ProviderType == DBFormatFunctions.eProviderType.OracleClient)
		{
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType != DBFormatFunctions.eServerType.Oracle)
			{
				string message5 = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
				throw new Exception(message5);
			}
			connectionString = "Data Source=<%ServerNome%>;";
			connectionString += "User ID=<%ServerUtente%>;";
			connectionString += "Password=<%ServerPassword%>;";
			connectionString = Strings.Replace(connectionString, "<%ServerNome%>", _Server, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerDB%>", _Database, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerUtente%>", _User, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerPassword%>", _Password, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%AppTitle%>", "", 1, -1, (CompareMethod)0);
		}
		else if (_ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
		{
			_TimeOut = v_TimeOut;
			if (_TimeOut == 0)
			{
				_TimeOut = 60;
			}
			if (eServerType != DBFormatFunctions.eServerType.SQLite)
			{
				string message6 = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0004, new string[0]);
				throw new Exception(message6);
			}
			connectionString = "Data Source=<%ServerDB%>;Version=3;Pooling=True;Max Pool Size=100;BinaryGUID=False;";
			if (Operators.CompareString(_Password, "", false) != 0)
			{
				connectionString += "Password=<%ServerPassword%>;";
			}
			connectionString = Strings.Replace(connectionString, "<%ServerNome%>", _Server, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerDB%>", _Database, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerUtente%>", _User, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%ServerPassword%>", _Password, 1, -1, (CompareMethod)0);
			connectionString = Strings.Replace(connectionString, "<%AppTitle%>", "", 1, -1, (CompareMethod)0);
		}
		_ConnectionString = connectionString;
	}

	protected void EnsureConnectionOpen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		string rsMess = "";
		OpenConnection(ref rsMess);
	}

	public FXRETURN OpenConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_ConnectionOpen)
			{
				val = (FXRETURN)0;
			}
			else
			{
				val2 = DBConnectionObjectCreate(ref rsMess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else
				{
					val2 = dbConnOpen(ref rsMess);
					if ((int)val2 != 0)
					{
						val = val2;
					}
					else
					{
						_ConnectionOpen = true;
						switch (eServerType)
						{
						case DBFormatFunctions.eServerType.SQL:
							if (Operators.CompareString(DBMSLanguage, "", false) == 0)
							{
								DBMSLanguage = "us_english";
							}
							text = "SET LANGUAGE " + DBMSLanguage + "; SET DATEFORMAT mdy;";
							if ((int)SqlExec(text, ref rsMess) == 0)
							{
								break;
							}
							goto end_IL_000a;
						case DBFormatFunctions.eServerType.Oracle:
							text = "ALTER SESSION SET NLS_NUMERIC_CHARACTERS = '.,' NLS_LANGUAGE='AMERICAN' NLS_TERRITORY='AMERICA' NLS_DATE_FORMAT='YYYY-MM-DD HH24:MI:SS' NLS_SORT='BINARY'";
							if ((int)SqlExec(text, ref rsMess) == 0)
							{
								break;
							}
							goto end_IL_000a;
						}
						val = (FXRETURN)0;
					}
				}
			}
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN CloseConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			_ObjCallStackHandler.CallStackAdd();
			if (disposed || !_ConnectionOpen)
			{
				goto IL_0044;
			}
			val2 = dbConnClose(ref rsMess);
			if ((int)val2 == 0)
			{
				_ConnectionOpen = false;
				_InTrans = false;
				goto IL_0044;
			}
			val = val2;
			goto end_IL_0004;
			IL_0044:
			val = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN TestConnection(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (ServerTypeConnection == DBFormatFunctions.eServerType.AS400)
			{
				text = "select * from sysibm.sysdummy1";
			}
			else
			{
				text = "SELECT 1 ";
				if (ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
				{
					text += " FROM DUAL";
				}
			}
			string sSql = text;
			int num = default(int);
			object objRes = num;
			FXRETURN val3 = DoSql(sSql, ref objRes, ref rsMess);
			num = Conversions.ToInteger(objRes);
			val2 = val3;
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN TestAndReconnect(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			val2 = TestConnection(ref rsMess);
			if ((int)val2 == 0)
			{
				goto IL_004e;
			}
			string rsMess2 = "";
			CloseConnection(ref rsMess2);
			val2 = OpenConnection(ref rsMess);
			if ((int)val2 == 0)
			{
				goto IL_004e;
			}
			val = val2;
			goto end_IL_000a;
			IL_004e:
			val = (FXRETURN)0;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN OpenDataReader(string vsSQLClause, ref IDataReader robjOutputDataReader, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val2 = dbExecuteReader(vsSQLClause, ref robjOutputDataReader, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlRead(string vsSQLClause, ref IDataReader robjOutputDataReader, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val2 = dbExecuteReader(vsSQLClause, ref robjOutputDataReader, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlKeyTable(string sTabella, ref string[] sKeys, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dtSchema = null;
		string[] array = new string[0];
		int num = 0;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsmess = "";
			EnsureConnectionOpen();
			val2 = dbSchemaTable("SELECT * FROM " + sTabella + " WHERE 1=2", ref dtSchema, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				checked
				{
					foreach (DataRow row in dtSchema.Rows)
					{
						if (Conversions.ToBoolean(row["IsKey"]))
						{
							array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
							array[num] = row["ColumnName"].ToString();
							num++;
						}
					}
					sKeys = array;
					val = (FXRETURN)0;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlSchemaTable(ref DataTable dtSchema, string vsSQLClause, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val = dbSchemaTable(vsSQLClause, ref dtSchema, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExec(string vsSQLClause, ref int riAffectedRows, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val2 = dbExecuteNonQuery(vsSQLClause, ref riAffectedRows, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExec(string vsSQLClause, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			int riAffectedRows = default(int);
			val2 = dbExecuteNonQuery(vsSQLClause, ref riAffectedRows, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExecBlobHelper(string vsSQLClause, string[] vsFileName, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				CheckIfDisposed();
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				EnsureConnectionOpen();
				int num = 1;
				int num2 = 0;
				IDbDataParameter[] array = new IDbDataParameter[0];
				foreach (string path in vsFileName)
				{
					if (File.Exists(path))
					{
						byte[] value = File.ReadAllBytes(path);
						array = (IDbDataParameter[])Utils.CopyArray((Array)array, (Array)new IDbDataParameter[num2 + 1]);
						array[num2] = DBParameterObjectCreate();
						array[num2].DbType = DbType.Binary;
						array[num2].Direction = ParameterDirection.Input;
						if (ProviderType == DBFormatFunctions.eProviderType.SqlClient)
						{
							array[num2].ParameterName = "@p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(":" + num, "@p" + Conversions.ToString(num2));
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
						{
							array[num2].ParameterName = ":p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(":" + num, ":p" + Conversions.ToString(num2));
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.OracleClient)
						{
							array[num2].ParameterName = ":p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(":" + num, ":p" + Conversions.ToString(num2));
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
						{
							array[num2].ParameterName = "@p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(":" + num, "@p" + Conversions.ToString(num2));
						}
						else
						{
							array[num2].ParameterName = "p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(":" + num, "?");
						}
						array[num2].Value = value;
					}
					else
					{
						vsSQLClause = vsSQLClause.Replace(":" + num, "NULL");
					}
					num++;
					num2++;
				}
				IDbCommand dbCommand = _Connection.CreateCommand();
				dbCommand.CommandText = vsSQLClause;
				dbCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					dbCommand.Transaction = _Transaction;
				}
				IDbDataParameter[] array2 = array;
				foreach (IDbDataParameter value2 in array2)
				{
					dbCommand.Parameters.Add(value2);
				}
				int num3 = dbCommand.ExecuteNonQuery();
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
				_ObjCallStackHandler.CallStackRemove();
			}
			return result;
		}
	}

	public FXRETURN SqlExecBlobHelper(string vsSQLClause, List<byte[]> vsFile, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				CheckIfDisposed();
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				EnsureConnectionOpen();
				int num = 1;
				int num2 = 0;
				IDbDataParameter[] array = new IDbDataParameter[0];
				foreach (byte[] item in vsFile)
				{
					if (item.Count() > 0)
					{
						byte[] value = item;
						array = (IDbDataParameter[])Utils.CopyArray((Array)array, (Array)new IDbDataParameter[num2 + 1]);
						array[num2] = DBParameterObjectCreate();
						array[num2].DbType = DbType.Binary;
						array[num2].Direction = ParameterDirection.Input;
						if (ProviderType == DBFormatFunctions.eProviderType.SqlClient)
						{
							array[num2].ParameterName = "@p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " @p" + Conversions.ToString(num2) + " ");
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
						{
							array[num2].ParameterName = ":p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " :p" + Conversions.ToString(num2) + " ");
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.OracleClient)
						{
							array[num2].ParameterName = ":p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " :p" + Conversions.ToString(num2) + " ");
						}
						else if (ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
						{
							array[num2].ParameterName = "@p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " @p" + Conversions.ToString(num2) + " ");
						}
						else
						{
							array[num2].ParameterName = "p" + Conversions.ToString(num2);
							vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " ? ");
						}
						array[num2].Value = value;
					}
					else
					{
						vsSQLClause = vsSQLClause.Replace(" :" + num + " ", " NULL ");
					}
					num++;
					num2++;
				}
				IDbCommand dbCommand = _Connection.CreateCommand();
				dbCommand.CommandText = vsSQLClause;
				dbCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					dbCommand.Transaction = _Transaction;
				}
				IDbDataParameter[] array2 = array;
				foreach (IDbDataParameter value2 in array2)
				{
					dbCommand.Parameters.Add(value2);
				}
				int num3 = dbCommand.ExecuteNonQuery();
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
				_ObjCallStackHandler.CallStackRemove();
			}
			return result;
		}
	}

	public FXRETURN SqlExec(StringCollection vsSQLClause, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			StringBuilder stringBuilder = new StringBuilder();
			StringEnumerator enumerator = vsSQLClause.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (Operators.CompareString(current.Trim(), "", false) != 0)
				{
					stringBuilder.Append(current);
					stringBuilder.Append(";");
				}
			}
			val2 = SqlExec(stringBuilder.ToString(), ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExec(StringCollection vsSQLClause, int iQueryGroupCount, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringEnumerator enumerator = vsSQLClause.GetEnumerator();
			while (true)
			{
				if (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (Operators.CompareString(current.Trim(), "", false) != 0)
					{
						stringBuilder.Append(current);
						stringBuilder.Append(";");
					}
					if (num == 10)
					{
						if (Operators.CompareString(stringBuilder.ToString(), "", false) != 0)
						{
							val2 = SqlExec(stringBuilder.ToString(), ref rsMess);
							if ((int)val2 != 0)
							{
								val = val2;
								break;
							}
						}
						num = 0;
						stringBuilder = new StringBuilder();
					}
					num = checked(num + 1);
					continue;
				}
				if (Operators.CompareString(stringBuilder.ToString(), "", false) != 0)
				{
					val2 = SqlExec(stringBuilder.ToString(), ref rsMess);
					if ((int)val2 != 0)
					{
						val = val2;
						break;
					}
				}
				val = (FXRETURN)0;
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExec(string vsSQLClause, int viMinAffectedRows, int viMaxAffectedRows, ref int riAffectedRows, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			riAffectedRows = 0;
			EnsureConnectionOpen();
			val2 = dbExecuteNonQuery(vsSQLClause, ref riAffectedRows, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (riAffectedRows < viMinAffectedRows)
				{
					rsMess = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0003, new string[0]);
					val = (FXRETURN)5;
				}
				else if (viMaxAffectedRows > riAffectedRows)
				{
					rsMess = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0002, new string[0]);
					val = (FXRETURN)5;
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN SqlExec(string vsSQLClause, int viMinAffectedRows, int viMaxAffectedRows, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		int riAffectedRows = 0;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			FXRETURN val2 = SqlExec(vsSQLClause, viMinAffectedRows, viMaxAffectedRows, ref riAffectedRows, ref rsMess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN DoSql(string sSql, ref object objRes, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			FXRETURN val2 = dbExecuteScalar(sSql, ref objRes, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (objRes == null)
			{
				val = (FXRETURN)14;
				rsMess = _Translator.TranslateMessage(Assembly.GetExecutingAssembly().GetName().FullName, kDatab0001, new string[1] { sSql });
			}
			else
			{
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN DoSql(string sSql, object vObjDefault, ref object objRes, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			FXRETURN val2 = dbExecuteScalar(sSql, ref objRes, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (objRes == null)
				{
					objRes = RuntimeHelpers.GetObjectValue(vObjDefault);
				}
				else if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(objRes)))
				{
					objRes = RuntimeHelpers.GetObjectValue(vObjDefault);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public virtual FXRETURN GetLastIdentity(ref decimal? ret, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsMess = "";
			ret = null;
			object objRes = null;
			string sSql = "";
			EnsureConnectionOpen();
			if (ServerTypeConnection == DBFormatFunctions.eServerType.SQL)
			{
				sSql = "SELECT @@IDENTITY LASTIdentity";
			}
			else if (ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
			{
				sSql = "SELECT GetLastId LASTIdentity FROM DUAL";
			}
			else if (ServerTypeConnection == DBFormatFunctions.eServerType.AS400)
			{
				sSql = "SELECT IDENTITY_VAL_LOCAL() FROM SYSIBM.SYSDUMMY1";
			}
			else if (ServerTypeConnection == DBFormatFunctions.eServerType.SQLite)
			{
				sSql = "Select last_insert_rowid()";
			}
			val2 = DoSql(sSql, "", ref objRes, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (Operators.CompareString(objRes.ToString(), "", false) != 0)
				{
					ret = Conversions.ToDecimal(objRes);
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN OpenDataTable(string vsSQLClause, ref DataTable rObjDataTable, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val = dbReturnDataTable(vsSQLClause, ref rObjDataTable, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN OpenDataTable(string vsSQLClause, ref DataSet robjDataSet, ref DataTable rObjDataTable, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val = dbReturnDataTable(vsSQLClause, ref robjDataSet, ref rObjDataTable, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN OpenDataSet(string vsSQLClause, ref DataSet rObjDataSet, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			EnsureConnectionOpen();
			val = dbReturnDataSet(vsSQLClause, ref rObjDataSet, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN OpenDataSet(StringCollection vsSQLClause, ref DataSet rObjDataSet, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			StringBuilder stringBuilder = new StringBuilder();
			StringEnumerator enumerator = vsSQLClause.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (Operators.CompareString(current.Trim(), "", false) != 0)
				{
					stringBuilder.Append(current);
					stringBuilder.Append(";");
				}
			}
			val = OpenDataSet(stringBuilder.ToString(), ref rObjDataSet, ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public FXRETURN StoredProcedureExecute(string vsStoredProcedureName, ref SpParameter[] robjParams, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		IDbCommand dbCommand = null;
		FXRETURN val = (FXRETURN)3;
		checked
		{
			FXRETURN result;
			try
			{
				_ObjCallStackHandler.CallStackAdd();
				rsMess = "";
				EnsureConnectionOpen();
				dbCommand = _Connection.CreateCommand();
				dbCommand.CommandType = CommandType.StoredProcedure;
				dbCommand.CommandText = vsStoredProcedureName;
				dbCommand.CommandTimeout = _TimeOut;
				int i = default(int);
				for (; i < robjParams.Length; i++)
				{
					IDbDataParameter dbDataParameter = DBParameterObjectCreate();
					switch (robjParams[i].DataType)
					{
					case SpParameterDataType.Datetime:
						dbDataParameter.DbType = DbType.Date;
						dbDataParameter.Size = 10;
						break;
					case SpParameterDataType.Decimal:
						dbDataParameter.DbType = DbType.Decimal;
						dbDataParameter.Size = 18;
						dbDataParameter.Precision = 5;
						break;
					case SpParameterDataType.Integer:
						dbDataParameter.DbType = DbType.Int32;
						break;
					default:
						dbDataParameter.DbType = DbType.String;
						dbDataParameter.Size = robjParams[i].DataVarcharLength;
						break;
					}
					dbDataParameter.ParameterName = robjParams[i].Name;
					dbDataParameter.Value = RuntimeHelpers.GetObjectValue(robjParams[i].Value);
					dbCommand.Parameters.Add(dbDataParameter);
					if (robjParams[i].Direction == SpParameterDirection.InOut)
					{
						NewLateBinding.LateSetComplex(dbCommand.Parameters[i], (Type)null, "Direction", new object[1] { ParameterDirection.InputOutput }, (string[])null, (Type[])null, false, true);
					}
					else if (robjParams[i].Direction == SpParameterDirection.Out)
					{
						NewLateBinding.LateSetComplex(dbCommand.Parameters[i], (Type)null, "Direction", new object[1] { ParameterDirection.Output }, (string[])null, (Type[])null, false, true);
					}
				}
				if (_InTrans)
				{
					dbCommand.Transaction = _Transaction;
				}
				dbCommand.ExecuteNonQuery();
				for (i = 0; i < robjParams.Length; i++)
				{
					if (robjParams[i].Direction != 0)
					{
						robjParams[i].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(dbCommand.Parameters[robjParams[i].Name], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				val = (FXRETURN)0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val = _ObjIboAppLogHandling.HandleError(ref ex2, vsStoredProcedureName, ref rsMess);
				ProjectData.ClearProjectError();
			}
			finally
			{
				result = val;
				dbCommand.Dispose();
				_ObjCallStackHandler.CallStackRemove();
			}
			return result;
		}
	}

	public void BeginTransaction()
	{
		CheckIfDisposed();
		if (!_InTrans)
		{
			EnsureConnectionOpen();
			_Transaction = _Connection.BeginTransaction();
			_InTrans = true;
		}
	}

	public void CommitTransaction()
	{
		CheckIfDisposed();
		if (_InTrans)
		{
			EnsureConnectionOpen();
			_Transaction.Commit();
			_InTrans = false;
		}
	}

	public void RollbackTransaction()
	{
		CheckIfDisposed();
		if (_InTrans)
		{
			EnsureConnectionOpen();
			_Transaction.Rollback();
			_InTrans = false;
		}
	}

	public FXRETURN TableOrViewExists(string sTableOrViewName, ref bool bExists, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			bExists = false;
			EnsureConnectionOpen();
			text = "SELECT COUNT(*) FROM ElencoTabelle WHERE UPPER(TABLE_NAME)=" + SQLFormatString(sTableOrViewName.ToUpper());
			val2 = DoSql(text, 0, ref objRes, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				if (Conversions.ToInteger(objRes) > 0)
				{
					bExists = true;
				}
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public bool TableOrViewExists(string sTableOrViewName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		bool bExists = false;
		string rsMess = "";
		CheckIfDisposed();
		val = TableOrViewExists(sTableOrViewName, ref bExists, ref rsMess);
		if ((int)val != 0)
		{
			throw new Exception(rsMess);
		}
		return bExists;
	}

	public FXRETURN ExistsFieldInTable(string sTableOrViewName, string sFieldName, ref bool bExists, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			bExists = false;
			EnsureConnectionOpen();
			text = "SELECT * FROM " + sTableOrViewName + " WHERE 1=2";
			val2 = OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				bExists = modGeneral.ExistsFieldInDatatable(ref rObjDataTable, sFieldName);
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
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

	~DBConnection()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!disposed && disposing)
			{
				if (_InTrans)
				{
					try
					{
						_Transaction.Rollback();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				string rsMess = "";
				dbConnClose(ref rsMess);
				_Connection.Dispose();
				_Transaction = null;
				_Connection = null;
				_ObjCallStackHandler = null;
				_ObjIboAppLogHandling = null;
				_Translator = null;
			}
			disposed = true;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	protected void CheckIfDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().ToString(), "This object has been disposed.");
		}
	}

	protected FXRETURN DBConnectionObjectCreate(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_Connection == null)
			{
				if (_ProviderType == DBFormatFunctions.eProviderType.OleDb)
				{
					_Connection = (IDbConnection)new OleDbConnection(_ConnectionString);
				}
				else if (_ProviderType == DBFormatFunctions.eProviderType.Odbc)
				{
					_Connection = (IDbConnection)new OdbcConnection(_ConnectionString);
				}
				else if (_ProviderType == DBFormatFunctions.eProviderType.SqlClient)
				{
					_Connection = (IDbConnection)new SqlConnection(_ConnectionString);
				}
				else if (_ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
				{
					_Connection = (IDbConnection)new OracleConnection(_ConnectionString);
				}
				else if (_ProviderType == DBFormatFunctions.eProviderType.OracleClient)
				{
					_Connection = (IDbConnection)new OracleConnection(_ConnectionString);
				}
				else if (_ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
				{
					_Connection = (IDbConnection)new SQLiteConnection(_ConnectionString);
				}
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public IDbDataParameter DBParameterObjectCreate()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		if (_Connection != null)
		{
			if (_ProviderType == DBFormatFunctions.eProviderType.OleDb)
			{
				return (IDbDataParameter)new OleDbParameter();
			}
			if (_ProviderType == DBFormatFunctions.eProviderType.Odbc)
			{
				return (IDbDataParameter)new OdbcParameter();
			}
			if (_ProviderType == DBFormatFunctions.eProviderType.SqlClient)
			{
				return (IDbDataParameter)new SqlParameter();
			}
			if (_ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
			{
				return (IDbDataParameter)new OracleParameter();
			}
			if (_ProviderType == DBFormatFunctions.eProviderType.OracleClient)
			{
				return (IDbDataParameter)new OracleParameter();
			}
			if (_ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
			{
				return (IDbDataParameter)new SQLiteParameter();
			}
		}
		return null;
	}

	protected FXRETURN dbConnOpen(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_Connection.Open();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbConnClose(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			_Connection.Close();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbExecuteScalar(string vsSQLClause, ref object robjResult, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		IDbCommand dbCommand = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			dbCommand = _Connection.CreateCommand();
			dbCommand.CommandText = vsSQLClause;
			dbCommand.CommandTimeout = _TimeOut;
			if (_InTrans)
			{
				dbCommand.Transaction = _Transaction;
			}
			robjResult = RuntimeHelpers.GetObjectValue(dbCommand.ExecuteScalar());
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			dbCommand.Dispose();
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbReturnDataTable(string vsSQLClause, ref DataTable rObjDataTable, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		IDbDataAdapter objDa = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataSet dataSet = null;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			rObjDataTable = null;
			val2 = DbDataAdapterOpen(vsSQLClause, ref objDa, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				objDa.SelectCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					objDa.SelectCommand.Transaction = _Transaction;
				}
				dataSet = new DataSet();
				objDa.Fill(dataSet);
				rObjDataTable = dataSet.Tables[0];
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			if (!Information.IsNothing((object)objDa))
			{
				if (objDa is IDisposable)
				{
					((IDisposable)objDa).Dispose();
				}
				objDa = null;
			}
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbReturnDataTable(string vsSQLClause, ref DataSet robjDataSet, ref DataTable rObjDataTable, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		IDbDataAdapter objDa = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			rObjDataTable = null;
			val2 = DbDataAdapterOpen(vsSQLClause, ref objDa, ref rsMess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				objDa.SelectCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					objDa.SelectCommand.Transaction = _Transaction;
				}
				if (robjDataSet == null)
				{
					robjDataSet = new DataSet();
				}
				objDa.Fill(robjDataSet);
				rObjDataTable = robjDataSet.Tables[checked(robjDataSet.Tables.Count - 1)];
				val = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			if (!Information.IsNothing((object)objDa))
			{
				if (objDa is IDisposable)
				{
					((IDisposable)objDa).Dispose();
				}
				objDa = null;
			}
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN DbDataAdapterOpen(string vsSQLClause, ref IDbDataAdapter objDa, ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (_ProviderType == DBFormatFunctions.eProviderType.OleDb)
			{
				objDa = (IDbDataAdapter)new OleDbDataAdapter(vsSQLClause, (OleDbConnection)_Connection);
			}
			else if (_ProviderType == DBFormatFunctions.eProviderType.Odbc)
			{
				objDa = (IDbDataAdapter)new OdbcDataAdapter(vsSQLClause, (OdbcConnection)_Connection);
			}
			else if (_ProviderType == DBFormatFunctions.eProviderType.SqlClient)
			{
				objDa = (IDbDataAdapter)new SqlDataAdapter(vsSQLClause, (SqlConnection)_Connection);
			}
			else if (_ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
			{
				objDa = (IDbDataAdapter)new OracleDataAdapter(vsSQLClause, (OracleConnection)_Connection);
			}
			else if (_ProviderType == DBFormatFunctions.eProviderType.OracleClient)
			{
				objDa = (IDbDataAdapter)new OracleDataAdapter(vsSQLClause, (OracleConnection)_Connection);
			}
			else if (_ProviderType == DBFormatFunctions.eProviderType.SQLiteClient)
			{
				objDa = (IDbDataAdapter)new SQLiteDataAdapter(vsSQLClause, (SQLiteConnection)_Connection);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			_ObjCallStackHandler.CallStackRemove();
		}
		FXRETURN result = default(FXRETURN);
		return result;
	}

	protected FXRETURN dbReturnDataSet(string vsSQLClause, ref DataSet rObjDataSet, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		IDbDataAdapter objDa = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (rObjDataSet == null)
			{
				rObjDataSet = new DataSet();
			}
			if (ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
			{
				string[] array = vsSQLClause.Trim().Split(new char[1] { ';' });
				int num = 0;
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (Operators.CompareString(text, "", false) == 0)
					{
						continue;
					}
					DataTable rObjDataTable = null;
					val2 = OpenDataTable(text, ref rObjDataSet, ref rObjDataTable, ref rsMess);
					if ((int)val2 == 0)
					{
						rObjDataTable.TableName = "table" + Conversions.ToString(num);
						num = checked(num + 1);
						continue;
					}
					val = val2;
					goto end_IL_0006;
				}
				goto IL_0107;
			}
			val2 = DbDataAdapterOpen(vsSQLClause, ref objDa, ref rsMess);
			if ((int)val2 == 0)
			{
				objDa.SelectCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					objDa.SelectCommand.Transaction = _Transaction;
				}
				objDa.Fill(rObjDataSet);
				goto IL_0107;
			}
			val = val2;
			goto end_IL_0006;
			IL_0107:
			val = (FXRETURN)0;
			end_IL_0006:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val;
			if (!Information.IsNothing((object)objDa))
			{
				if (objDa is IDisposable)
				{
					((IDisposable)objDa).Dispose();
				}
				objDa = null;
			}
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbExecuteNonQuery(string vsSQLClause, ref int riAffectedRows, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		IDbCommand dbCommand = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(vsSQLClause.Trim(), "", false) != 0)
			{
				if (ServerTypeConnection == DBFormatFunctions.eServerType.Oracle)
				{
					vsSQLClause = vsSQLClause.Trim();
					if (vsSQLClause.StartsWith("SELECT") | vsSQLClause.StartsWith("INSERT") | vsSQLClause.StartsWith("DELETE") | vsSQLClause.StartsWith("UPDATE"))
					{
						vsSQLClause = "BEGIN " + vsSQLClause;
						if (Operators.CompareString(Strings.Right(Strings.Trim(vsSQLClause), 1), ";", false) != 0)
						{
							vsSQLClause += ";";
						}
						vsSQLClause += "END;";
					}
					if (ProviderType == DBFormatFunctions.eProviderType.MSOracleClient)
					{
						vsSQLClause = vsSQLClause.Replace(";\r\n", "; ");
						vsSQLClause = vsSQLClause.Replace("; \r\n", "; ");
						vsSQLClause = vsSQLClause.Replace(";  \r\n", "; ");
					}
				}
				dbCommand = _Connection.CreateCommand();
				dbCommand.CommandText = vsSQLClause;
				dbCommand.CommandTimeout = _TimeOut;
				if (_InTrans)
				{
					dbCommand.Transaction = _Transaction;
				}
				riAffectedRows = dbCommand.ExecuteNonQuery();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (!Information.IsNothing((object)dbCommand))
			{
				dbCommand.Dispose();
			}
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbExecuteReader(string vsSQLClause, ref IDataReader objOutputDataReader, ref string rsMess)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		IDbCommand dbCommand = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			dbCommand = _Connection.CreateCommand();
			dbCommand.CommandText = vsSQLClause;
			dbCommand.CommandTimeout = _TimeOut;
			if (_InTrans)
			{
				dbCommand.Transaction = _Transaction;
			}
			objOutputDataReader = dbCommand.ExecuteReader();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (!Information.IsNothing((object)dbCommand))
			{
				dbCommand.Dispose();
			}
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	protected FXRETURN dbSchemaTable(string vsSQLClause, ref DataTable dtSchema, ref string rsMess)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		IDbCommand dbCommand = null;
		IDataReader dataReader = null;
		FXRETURN val = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CheckIfDisposed();
			_ObjCallStackHandler.CallStackAdd();
			rsMess = "";
			dbCommand = _Connection.CreateCommand();
			dbCommand.CommandText = vsSQLClause;
			dbCommand.CommandTimeout = _TimeOut;
			if (_InTrans)
			{
				dbCommand.Transaction = _Transaction;
			}
			dataReader = dbCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo);
			dtSchema = dataReader.GetSchemaTable();
			dataReader.Close();
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val = _ObjIboAppLogHandling.HandleError(ref ex2, vsSQLClause, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (!Information.IsNothing((object)dbCommand))
			{
				dbCommand.Dispose();
			}
			result = val;
			_ObjCallStackHandler.CallStackRemove();
		}
		return result;
	}

	public string SQLFormat(object objValue)
	{
		return DBFormatFunctions.SQLFormat(eServerType, RuntimeHelpers.GetObjectValue(objValue));
	}

	public string SQLFormat(string vsValue, eTipoDati veTipo)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return DBFormatFunctions.SQLFormat(eServerType, vsValue, veTipo);
	}

	public string SQLFormatDate(eTipoData vTipoData, string vsData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return DBFormatFunctions.SQLFormatDate(eServerType, vTipoData, vsData);
	}

	public string SQLFormatDate(eTipoData vTipoData, DateTime vsData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return DBFormatFunctions.SQLFormatDate(eServerType, vTipoData, vsData);
	}

	public string SQLFormatDate(eTipoData vTipoData, DateTime? vsData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return DBFormatFunctions.SQLFormatDate(eServerType, vTipoData, vsData);
	}

	public string SQLFormatDate(eTipoData vTipoData, object vsData)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		DateTime? vData = null;
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(vsData)) && Operators.CompareString(vsData.ToString(), "", false) != 0)
		{
			vData = Conversions.ToDate(vsData);
		}
		return DBFormatFunctions.SQLFormatDate(eServerType, vTipoData, vData);
	}

	public string SQLFormatString(string vsStringa)
	{
		return DBFormatFunctions.SQLFormatString(eServerType, vsStringa);
	}

	public string SQLFormatNumber(ref string pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref int pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref int? pNumero)
	{
		if (pNumero.HasValue)
		{
			return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero.Value);
		}
		return DBFormatFunctions.SQLFormatNumber(eServerType, "");
	}

	public string SQLFormatNumber(ref long pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref long? pNumero)
	{
		if (pNumero.HasValue)
		{
			return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero.Value);
		}
		return DBFormatFunctions.SQLFormatNumber(eServerType, "");
	}

	public string SQLFormatNumber(ref float pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref float? pNumero)
	{
		if (pNumero.HasValue)
		{
			return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero.Value);
		}
		return DBFormatFunctions.SQLFormatNumber(eServerType, "");
	}

	public string SQLFormatNumber(ref double pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref double? pNumero)
	{
		if (pNumero.HasValue)
		{
			return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero.Value);
		}
		return DBFormatFunctions.SQLFormatNumber(eServerType, "");
	}

	public string SQLFormatNumber(ref decimal pNumero)
	{
		return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero);
	}

	public string SQLFormatNumber(ref decimal? pNumero)
	{
		if (pNumero.HasValue)
		{
			return DBFormatFunctions.SQLFormatNumber(eServerType, pNumero.Value);
		}
		return DBFormatFunctions.SQLFormatNumber(eServerType, "");
	}

	protected void CallStackAdd_()
	{
		if (_ObjCallStackHandler != null)
		{
			_ObjCallStackHandler.CallStackAdd();
		}
	}

	protected void CallStackRemove_()
	{
		if (_ObjCallStackHandler != null)
		{
			_ObjCallStackHandler.CallStackRemove();
		}
	}

	private void ConfigureMessage()
	{
		try
		{
			kDatab0003 = "Numero di record coinvolti minore di quello previsto.";
			kDatab0002 = "Numero di record coinvolti maggiore di quello previsto.";
			kDatab0001 = "La query non ha restituito nessun valore. Query={0}";
			kDatab0004 = "Tipo DB server sconosciuto";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public object Clone()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		DBConnection dBConnection = new DBConnection(_ProviderType, _Provider, _Server, eServerType, _Database, _User, _Password, _UseIntegratedSecurity, _TimeOut, _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _Translator);
		string rsMess = "";
		dBConnection.DBConnectionObjectCreate(ref rsMess);
		return dBConnection;
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clone
		return this.Clone();
	}

	public virtual string StringConcatenateOperator()
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "||";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "+";
		}
		else if (ServerType == DBFormatFunctions.eServerType.AS400)
		{
			result = "CONCAT";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "||";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "+";
		}
		return result;
	}

	public virtual string DateTrunc(string Field)
	{
		string text = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			text = "TRUNC";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			text = "dbo.trunc";
		}
		else if (ServerType == DBFormatFunctions.eServerType.AS400)
		{
			text = "TRUNC_TIMESTAMP";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			text = "date";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			text = "TRUNC";
		}
		return text + "(" + Field + ")";
	}

	public virtual string IsNullFunc(string Value, string ValueIfNull)
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "NVL(" + Value + ", " + ValueIfNull + ")";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "ISNULL(" + Value + ", " + ValueIfNull + ")";
		}
		else if (ServerType == DBFormatFunctions.eServerType.AS400)
		{
			result = "COALESCE(" + Value + ", " + ValueIfNull + ")";
		}
		else if (ServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "ifnull(" + Value + ", " + ValueIfNull + ")";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "ISNULL(" + Value + ", " + ValueIfNull + ")";
		}
		return result;
	}

	public virtual string FromDual()
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "FROM DUAL";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "";
		}
		else if (eServerType == DBFormatFunctions.eServerType.AS400)
		{
			result = "FROM sysibm.sysdummy1";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "";
		}
		return result;
	}

	public virtual string FormatDateFunc(string Field, string Formato, string Sep)
	{
		string text = "";
		Formato = Formato.ToUpper();
		if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			text = "dbo.FORMATDATE(%Field%, '%Formato%','%Sep%')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			switch (Formato)
			{
			case "YYYYMMDD":
				Formato = "YYYY%s%MM%s%DD";
				break;
			case "YYMMDD":
				Formato = "YY%s%MM%s%DD";
				break;
			case "DDMMYY":
				Formato = "DD%s%MM%s%YY";
				break;
			case "DDMMYYYY":
				Formato = "DD%s%MM%s%YYYY";
				break;
			}
			Formato = Formato.Replace("%s%", Sep);
			text = "TO_CHAR(%Field%, '%Formato%')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.AS400)
		{
			text = "VARCHAR_FORMAT(%Field%, '%Formato%')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			text = "strftime('%d%Sep%%m%Sep%%Y', %Field%)";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			text = "dbo.FORMATDATE(%Field%, '%Formato%','%Sep%')";
		}
		return text.Replace("%Field%", Field).Replace("%Formato%", Formato).Replace("%Sep%", Sep);
	}

	public virtual string ConvertToVarbinary(string Exadecimal)
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "HEXTORAW('" + Exadecimal + "')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "CONVERT(VARBINARY(MAX), '0x" + Exadecimal + "',1)";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "X'" + Exadecimal + "'";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "CONVERT(VARBINARY(MAX), '0x" + Exadecimal + "',1)";
		}
		return result;
	}

	public virtual string GetTimestamp()
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "LOCALTIMESTAMP(6)";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "GETDATE()";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "datetime(current_timestamp,'localtime')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.AS400)
		{
			result = "SYSDATE";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "GETDATE()";
		}
		return result;
	}

	public virtual string GetDate()
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = "SYSDATE";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "GETDATE()";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = "datetime('now','localtime')";
		}
		else if (eServerType == DBFormatFunctions.eServerType.AS400)
		{
			result = "SYSDATE";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = "GETDATE()";
		}
		return result;
	}

	public virtual DateTime GetServerDateTime()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		object objRes = null;
		text = "SELECT " + GetTimestamp() + " " + FromDual();
		string sSql = text;
		string rsMess = "";
		DoSql(sSql, ref objRes, ref rsMess);
		if (objRes != null)
		{
			return Convert.ToDateTime(RuntimeHelpers.GetObjectValue(objRes));
		}
		DateTime result = default(DateTime);
		return result;
	}

	public virtual string CallServerFunction(string Func, string Parameters)
	{
		string result = "";
		if (eServerType == DBFormatFunctions.eServerType.Oracle)
		{
			result = Func + "(" + Parameters + ")";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQL)
		{
			result = "dbo." + Func + "(" + Parameters + ")";
		}
		else if (eServerType == DBFormatFunctions.eServerType.SQLite)
		{
			result = Func + "(" + Parameters + ")";
		}
		else if (eServerType == DBFormatFunctions.eServerType.UnKnown)
		{
			result = Func + "(" + Parameters + ")";
		}
		return result;
	}

	public virtual string SqlConvertForServer(string sSql)
	{
		string text = "";
		if (ServerType == DBFormatFunctions.eServerType.SQL)
		{
			return sSql.Replace("%ISNULL%", "ISNULL").Replace("%+%", "+").Replace("%GETDATE%", "GETDATE()")
				.Replace("%TIMESTAMP%", "GETDATE()")
				.Replace("%FROMDUAL%", "")
				.Replace("%TRUNC%", "dbo.trunc")
				.Replace("%TOP100PERCENT%", "TOP 100 PERCENT")
				.Replace("%CHAR%", "CHAR")
				.Replace("%HOURS%", "dbo.Hours")
				.Replace("%MINUTES%", "dbo.Minutes")
				.Replace("%SECONDS%", "dbo.Seconds")
				.Replace("%VARCHAR%", "VARCHAR");
		}
		if (ServerType == DBFormatFunctions.eServerType.Oracle)
		{
			return sSql.Replace("%ISNULL%", "NVL").Replace("%+%", "||").Replace("%GETDATE%", "SYSDATE")
				.Replace("%TIMESTAMP%", "LOCALTIMESTAMP(6)")
				.Replace("%FROMDUAL%", "FROM DUAL")
				.Replace("%TRUNC%", "TRUNC")
				.Replace("%TOP100PERCENT%", "")
				.Replace("%CHAR%", "CHR")
				.Replace("%HOURS%", "HOURS")
				.Replace("%MINUTES%", "MINUTES")
				.Replace("%SECONDS%", "SECONDS")
				.Replace("%VARCHAR%", "VARCHAR2");
		}
		if (ServerType == DBFormatFunctions.eServerType.SQLite)
		{
			text = sSql.Replace("%ISNULL%", "ifnull").Replace("%+%", "||").Replace("%GETDATE%", "datetime('now','localtime')")
				.Replace("%TIMESTAMP%", "datetime(CURRENT_TIMESTAMP,'localtime')")
				.Replace("%FROMDUAL%", "")
				.Replace("%TRUNC%", "date")
				.Replace("%TOP100PERCENT%", "TOP 9999999")
				.Replace("%CHAR%", "CHAR");
			text = text.Replace("%HOURS% (", "%HOURS%(");
			text = text.Replace("%HOURS%(", "strftime('%H',");
			text = text.Replace("%MINUTES% (", "%MINUTES%(");
			text = text.Replace("%MINUTES%(", "strftime('%M',");
			text = text.Replace("%SECONDS% (", "%SECONDS%(");
			text = text.Replace("%SECONDS%(", "strftime('%S',");
			return text.Replace("%VARCHAR%", "VARCHAR");
		}
		throw new NotImplementedException("Not implemented for this DB server!");
	}
}
