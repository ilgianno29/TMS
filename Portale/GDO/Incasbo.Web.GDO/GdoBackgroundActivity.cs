using System;
using System.Collections.Specialized;
using System.Web;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.GDO;

public class GdoBackgroundActivity : IIboWFIBackgroundActivity
{
	private static int Cicle = 0;

	public void Start(HttpApplication MyHttpApplication)
	{
		checked
		{
			Cicle++;
			if (Cicle > 9)
			{
				Cicle = 1;
			}
			try
			{
				ApplyAppQuery((WFIConfig)MyHttpApplication.Application["WFIConfig"], MyHttpApplication);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	void IIboWFIBackgroundActivity.Start(HttpApplication MyHttpApplication)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Start
		this.Start(MyHttpApplication);
	}

	protected virtual void ApplyAppQuery(WFIConfig WFIConfig, HttpApplication MyHttpApplication)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		DBConnection val = null;
		StringCollection stringCollection = null;
		IboDictionaryCollection<string, object> iboDictionaryCollection = null;
		try
		{
			iboDictionaryCollection = ((IboApplicationVariables)MyHttpApplication.Application["WFIApplicationVariables"])["WFIAPP"];
			if (iboDictionaryCollection == null || !iboDictionaryCollection.ContainsKey("DBCONN"))
			{
				return;
			}
			val = (DBConnection)iboDictionaryCollection["DBCONN"];
			stringCollection = new StringCollection();
			string text = "";
			if (Cicle == 1)
			{
			}
			if (stringCollection.Count <= 0)
			{
				return;
			}
			DBConnection obj = val;
			string text2 = "";
			if ((int)obj.OpenConnection(ref text2) != 0)
			{
				return;
			}
			int num = 0;
			do
			{
				num = checked(num + 1);
				try
				{
					string text3 = stringCollection[0];
					val.BeginTransaction();
					DBConnection obj2 = val;
					text2 = "";
					if ((int)obj2.SqlExec(text3, ref text2) > 0)
					{
						val.RollbackTransaction();
					}
					else
					{
						val.CommitTransaction();
					}
					stringCollection.Remove(text3);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			while (!(stringCollection.Count == 0 || num == 100));
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		finally
		{
			try
			{
				if (val != null)
				{
					DBConnection obj3 = val;
					string text2 = "";
					obj3.CloseConnection(ref text2);
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}
}
