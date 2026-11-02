using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI.ObjectManager;

public class ObjectManagerFactory
{
	protected ObjectManagerCollection _ObjectManagerCollection;

	protected IboAppCallStackHandling _ObjCallStackHandler;

	protected IboAppLogHandling _ObjIboAppLogHandling;

	protected DBConnection _ObjDbMain;

	protected IncasTranslator _ObjTranslator;

	protected IboWebUserInfo _ObjWebUserInfo;

	public ObjectManagerFactory(ref IboAppCallStackHandling rObjCallStackHandler, ref IboAppLogHandling rObjIboAppLogHandling, ref DBConnection rObjDbMain, ref IncasTranslator rObjTranslator, ref IboWebUserInfo rObjWebUserInfo)
	{
		_ObjCallStackHandler = rObjCallStackHandler;
		_ObjIboAppLogHandling = rObjIboAppLogHandling;
		_ObjDbMain = rObjDbMain;
		_ObjTranslator = rObjTranslator;
		_ObjWebUserInfo = rObjWebUserInfo;
		Init();
	}

	public ObjectManagerFactory(ref IboSessionEnvironment robjSessionEnvironment)
		: this(ref Incasbo.Compat.RefBox.Of(robjSessionEnvironment.CallStackHandler), ref Incasbo.Compat.RefBox.Of(robjSessionEnvironment.LogHandling), ref Incasbo.Compat.RefBox.Of(robjSessionEnvironment.DbConn), ref Incasbo.Compat.RefBox.Of(robjSessionEnvironment.Translator), ref Incasbo.Compat.RefBox.Of(robjSessionEnvironment.WebUser.WebUserInfo))
	{
	}

	private void Init()
	{
		_ObjectManagerCollection = new ObjectManagerCollection();
		_ObjectManagerCollection.Clear();
		_ObjectManagerCollection.Add(new DefaultObjectManager());
		_ObjectManagerCollection["Default"].Init(ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _ObjDbMain, ref _ObjTranslator, ref _ObjWebUserInfo);
	}

	public AbstractObjectManager GetManager(string vsObjectManagerName)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		AbstractObjectManager abstractObjectManager = null;
		if (_ObjectManagerCollection.Contains(vsObjectManagerName.ToUpper()))
		{
			abstractObjectManager = _ObjectManagerCollection[vsObjectManagerName.ToUpper()];
		}
		else
		{
			string text = vsObjectManagerName.ToUpper();
			if (Operators.CompareString(text, "Utenti".ToUpper(), false) == 0)
			{
				abstractObjectManager = new UserObjectManager();
			}
			else if (Operators.CompareString(text, "UtentiAdmin".ToUpper(), false) == 0)
			{
				abstractObjectManager = new UserAdminObjectManager();
			}
			else if (Operators.CompareString(text, "Parametrica".ToUpper(), false) == 0)
			{
				abstractObjectManager = new ParamObjectManager();
			}
			else
			{
				string text2 = "SELECT TIPO FROM WFI_OBJECTMANAGER WHERE CODICE=" + _ObjDbMain.SQLFormatString(vsObjectManagerName);
				object obj = null;
				string text3 = "";
				FXRETURN val = _ObjDbMain.DoSql(text2, (object)"", ref obj, ref text3);
				if ((int)val > 0)
				{
					throw new Exception("Errore in fase di creazione dell'Object Manager: " + text3);
				}
				if (Operators.CompareString(obj.ToString(), "DB", false) == 0)
				{
					abstractObjectManager = new DBObjectManager(vsObjectManagerName.ToUpper());
				}
				else if (Operators.CompareString(obj.ToString(), "DB2", false) == 0)
				{
					abstractObjectManager = new DB2ObjectManager(vsObjectManagerName.ToUpper());
				}
				else if (Operators.CompareString(obj.ToString(), "DB3", false) == 0)
				{
					abstractObjectManager = new DB3ObjectManager(vsObjectManagerName.ToUpper());
				}
				else if (Operators.CompareString(obj.ToString(), "DT", false) == 0)
				{
					abstractObjectManager = new DTObjectManager(vsObjectManagerName.ToUpper());
				}
				else if (Operators.CompareString(obj.ToString(), "STD", false) == 0)
				{
					abstractObjectManager = new DefaultObjectManager(vsObjectManagerName.ToUpper());
				}
				else if (Operators.CompareString(obj.ToString(), "EF", false) != 0)
				{
					if (Operators.CompareString(obj.ToString(), "MV", false) == 0)
					{
						abstractObjectManager = new MultiviewObjectManager(vsObjectManagerName.ToUpper());
					}
					else
					{
						if (Operators.CompareString(obj.ToString(), "", false) != 0)
						{
							throw new Exception("Errore in fase di creazione dell'Object Manager: Tipo Object Manager non conosciuto");
						}
						abstractObjectManager = new DefaultObjectManager(vsObjectManagerName.ToUpper());
					}
				}
				abstractObjectManager.Tipo = obj.ToString();
			}
			if (abstractObjectManager != null)
			{
				_ObjectManagerCollection.Add(abstractObjectManager);
				abstractObjectManager.Init(ref _ObjCallStackHandler, ref _ObjIboAppLogHandling, ref _ObjDbMain, ref _ObjTranslator, ref _ObjWebUserInfo);
			}
			else
			{
				abstractObjectManager = _ObjectManagerCollection["Default"];
			}
		}
		return abstractObjectManager;
	}
}
