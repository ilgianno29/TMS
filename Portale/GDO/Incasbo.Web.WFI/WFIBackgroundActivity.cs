using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Web;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIBackgroundActivity
{
	protected class _WFIBackgroundActivity : IIboWFIBackgroundActivity
	{
		private static int Cicle = 0;

		public void Start(HttpApplication MyHttpApplication)
		{
			try
			{
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\SQL\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\SQL\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\Oracle\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\Oracle\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Documenti\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Documenti\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Download\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Download\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Stampe\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Stampe\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				if (!Directory.Exists(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Labels\\", "\\\\", "\\", 1, -1, (CompareMethod)0)))
				{
					Directory.CreateDirectory(Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Labels\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			ImAliveNotification();
			checked
			{
				Cicle++;
				if (Cicle > 9)
				{
					Cicle = 1;
					try
					{
						GC.Collect();
						GC.Collect();
						GC.Collect();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					try
					{
						PulisciCartellaDownload(MyHttpApplication);
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
					try
					{
						PulisciCartellaLog(MyHttpApplication);
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					ApplyAsyncQuery(MyHttpApplication);
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ProjectData.ClearProjectError();
				}
				try
				{
					ApplyWFIQuery((WFIConfig)MyHttpApplication.Application["WFIConfig"], MyHttpApplication);
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					ProjectData.ClearProjectError();
				}
				try
				{
					ConfigurationScriptApply((WFIConfig)MyHttpApplication.Application["WFIConfig"], MyHttpApplication, Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\WFI\\ConfigurationScript\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				catch (Exception ex13)
				{
					ProjectData.SetProjectError(ex13);
					Exception ex14 = ex13;
					ProjectData.ClearProjectError();
				}
				try
				{
					ConfigurationScriptApply((WFIConfig)MyHttpApplication.Application["WFIConfig"], MyHttpApplication, Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigurationScript\\", "\\\\", "\\", 1, -1, (CompareMethod)0));
				}
				catch (Exception ex15)
				{
					ProjectData.SetProjectError(ex15);
					Exception ex16 = ex15;
					ProjectData.ClearProjectError();
				}
			}
		}

		void IIboWFIBackgroundActivity.Start(HttpApplication MyHttpApplication)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Start
			this.Start(MyHttpApplication);
		}

		protected void ConfigurationScriptApply(WFIConfig WFIConfig, HttpApplication MyHttpApplication, string Path)
		{
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Invalid comparison between Unknown and I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Invalid comparison between Unknown and I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Invalid comparison between Unknown and I4
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Invalid comparison between Unknown and I4
			DBConnection val = null;
			StringCollection stringCollection = new StringCollection();
			IboDictionaryCollection<string, object> iboDictionaryCollection = null;
			try
			{
				iboDictionaryCollection = ((IboApplicationVariables)MyHttpApplication.Application["WFIApplicationVariables"])["WFIAPP"];
				if (iboDictionaryCollection == null)
				{
					return;
				}
				if (iboDictionaryCollection.ContainsKey("DBCONN"))
				{
					val = (DBConnection)iboDictionaryCollection["DBCONN"];
					DBConnection obj = val;
					string text = "";
					if ((int)obj.OpenConnection(ref text) != 0)
					{
						return;
					}
					Path = (((int)val.ServerType == 0) ? (Path + "SQL\\") : (((int)val.ServerType != 1) ? "" : (Path + "Oracle\\")));
					if (Operators.CompareString(Path, "", false) == 0 || !Directory.Exists(Path))
					{
						return;
					}
					string[] files = Directory.GetFiles(Path, "*.*");
					string[] array = files;
					foreach (string text2 in array)
					{
						stringCollection.Clear();
						if (text2.Contains(".done") || text2.Contains(".error") || text2.Contains("TextFile1.txt"))
						{
							continue;
						}
						stringCollection.Add(File.ReadAllText(text2));
						StringEnumerator enumerator = stringCollection.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							DBConnection obj2 = val;
							text = "";
							if ((int)obj2.SqlExec(current, ref text) > 0)
							{
								File.Move(text2, text2 + "." + Strings.Format((object)DateAndTime.Now, "yyyyMMddHHmmss") + ".error");
							}
							else
							{
								File.Move(text2, text2 + "." + Strings.Format((object)DateAndTime.Now, "yyyyMMddHHmmss") + ".done");
							}
						}
					}
				}
				else
				{
					stringCollection.Clear();
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
				try
				{
					if (val != null)
					{
						DBConnection obj3 = val;
						string text = "";
						obj3.CloseConnection(ref text);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}

		protected virtual void PulisciCartellaDownload(HttpApplication MyHttpApplication)
		{
			checked
			{
				try
				{
					string path = Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Download\\", "\\\\", "\\", 1, -1, (CompareMethod)0);
					string value = "3";
					string text = "";
					string[] files = Directory.GetFiles(path, "*.*", (SearchOption)Interaction.IIf(Operators.CompareString(text, "SUB", false) == 0, (object)SearchOption.AllDirectories, (object)SearchOption.TopDirectoryOnly));
					if (files.Length == 0)
					{
						return;
					}
					int num = files.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if ((!files[i].ToUpper().Contains("TEXTFILE1.TXT") & !files[i].ToUpper().Contains("IDLE.TXT")) && DateTime.Compare(File.GetLastWriteTime(files[i]), DateAndTime.Now.AddDays(-1 * Convert.ToInt32(value))) < 0)
						{
							File.Delete(files[i]);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		protected virtual void PulisciCartellaLog(HttpApplication MyHttpApplication)
		{
			checked
			{
				try
				{
					string path = Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Log\\", "\\\\", "\\", 1, -1, (CompareMethod)0);
					string value = "15";
					string text = "";
					string[] files = Directory.GetFiles(path, "*.*", (SearchOption)Interaction.IIf(Operators.CompareString(text, "SUB", false) == 0, (object)SearchOption.AllDirectories, (object)SearchOption.TopDirectoryOnly));
					if (files.Length == 0)
					{
						return;
					}
					int num = files.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if ((!files[i].ToUpper().Contains("TEXTFILE1.TXT") & !files[i].ToUpper().Contains("IDLE.TXT")) && DateTime.Compare(File.GetLastWriteTime(files[i]), DateAndTime.Now.AddDays(-1 * Convert.ToInt32(value))) < 0)
						{
							File.Delete(files[i]);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		protected virtual void ImAliveNotification()
		{
			try
			{
				string text = Strings.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Log\\", "\\\\", "\\", 1, -1, (CompareMethod)0);
				File.AppendAllText(text + "BackgroundActivityHeartBeat.log", DateAndTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		protected virtual void ApplyAsyncQuery(HttpApplication MyHttpApplication)
		{
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Invalid comparison between Unknown and I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Invalid comparison between Unknown and I4
			DBConnection val = null;
			IboDictionaryCollection<string, object> iboDictionaryCollection = null;
			StringCollection stringCollection = null;
			try
			{
				iboDictionaryCollection = ((IboApplicationVariables)MyHttpApplication.Application["WFIApplicationVariables"])["WFIAPP"];
				if (iboDictionaryCollection == null || !iboDictionaryCollection.ContainsKey("ASYNCQUERY"))
				{
					return;
				}
				stringCollection = (StringCollection)iboDictionaryCollection["ASYNCQUERY"];
				if (stringCollection.Count <= 0)
				{
					return;
				}
				if (iboDictionaryCollection.ContainsKey("DBCONN"))
				{
					val = (DBConnection)iboDictionaryCollection["DBCONN"];
					DBConnection obj = val;
					string text = "";
					if ((int)obj.OpenConnection(ref text) != 0)
					{
						return;
					}
					int num = 0;
					do
					{
						num = checked(num + 1);
						try
						{
							string text2 = stringCollection[0];
							val.BeginTransaction();
							DBConnection obj2 = val;
							text = "";
							if ((int)obj2.SqlExec(text2, ref text) > 0)
							{
								val.RollbackTransaction();
							}
							else
							{
								val.CommitTransaction();
							}
							stringCollection.Remove(text2);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					while (!(stringCollection.Count == 0 || num == 200));
				}
				else
				{
					stringCollection.Clear();
				}
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
						string text = "";
						obj3.CloseConnection(ref text);
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

		protected virtual void ApplyWFIQuery(WFIConfig WFIConfig, HttpApplication MyHttpApplication)
		{
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Invalid comparison between Unknown and I4
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Invalid comparison between Unknown and I4
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
				string text = "DELETE FROM WFI_MENU_UTILIZZO2 WHERE DATINS<=" + val.GetDate() + "-15; ";
				text = text + "DELETE FROM WFI_MENU_UTILIZZO WHERE DATAULTIMOUTILIZZO<=" + val.GetDate() + "-15; ";
				stringCollection.Add(text);
				text = "DELETE FROM WFI_DebugInfo WHERE Data<=" + val.GetDate() + "-15; ";
				stringCollection.Add(text);
				text = "UPDATE WFI_UTenti SET IsLoggedOn='N' WHERE IsLoggedOn='S' AND LASTACTIVITY < " + val.SQLFormatDate((eTipoData)2, DateAndTime.Now.AddHours(-2.0)) + ";";
				stringCollection.Add(text);
				if (Cicle == 1)
				{
					string text2 = "";
					string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
					text2 = text2 + "DELETE FROM WFI_VersioniModuli WHERE Applicazione=" + val.SQLFormatString(Assembly.GetExecutingAssembly().GetName().Name.ToUpper()) + " AND ISTANZA=" + val.SQLFormatString(baseDirectory) + "; ";
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly in assemblies)
					{
						string text3 = "";
						try
						{
							string text4 = "Version=" + assembly.GetName().Version.ToString() + ", ReleaseDate=" + File.GetLastWriteTime(assembly.Location);
							text3 += "INSERT INTO WFI_VersioniModuli(Applicazione, Istanza, Modulo, Descrizione, Versione, Percorso) VALUES (";
							text3 = text3 + val.SQLFormatString(Assembly.GetExecutingAssembly().GetName().Name.ToUpper()) + ", ";
							text3 = text3 + val.SQLFormatString(baseDirectory) + ", ";
							text3 = text3 + val.SQLFormatString(assembly.GetName().Name.ToUpper()) + ", ";
							text3 = text3 + val.SQLFormatString(Assembly.GetExecutingAssembly().GetName().Name.ToUpper() + " ISTANZA '" + baseDirectory + "' " + assembly.GetName().Name.ToUpper()) + ", ";
							text3 = text3 + val.SQLFormatString(text4) + ", ";
							text3 = text3 + val.SQLFormatString(assembly.GetName().CodeBase) + "); ";
							text2 += text3;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					text2 += "INSERT INTO WFI_VersioniModuli(Applicazione, Istanza, Modulo, Descrizione, Versione) VALUES (";
					text2 = text2 + val.SQLFormatString(Assembly.GetExecutingAssembly().GetName().Name.ToUpper()) + ", ";
					text2 = text2 + val.SQLFormatString(baseDirectory) + ", ";
					text2 = text2 + "'WFI', 'WFI Core Module', " + val.SQLFormatString(WFIConfig.WFIVersion.ToString) + "); ";
					stringCollection.Add(text2);
				}
				DBConnection obj = val;
				string text5 = "";
				if ((int)obj.OpenConnection(ref text5) != 0)
				{
					return;
				}
				int num = 0;
				do
				{
					num = checked(num + 1);
					try
					{
						string text6 = stringCollection[0];
						val.BeginTransaction();
						DBConnection obj2 = val;
						text5 = "";
						if ((int)obj2.SqlExec(text6, ref text5) > 0)
						{
							val.RollbackTransaction();
						}
						else
						{
							val.CommitTransaction();
						}
						stringCollection.Remove(text6);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				while (!(stringCollection.Count == 0 || num == 100));
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				string text7 = "";
				ProjectData.ClearProjectError();
			}
			finally
			{
				try
				{
					if (val != null)
					{
						DBConnection obj3 = val;
						string text5 = "";
						obj3.CloseConnection(ref text5);
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void Start(HttpApplication MyHttpApplication)
	{
		Thread.Sleep(10000);
		while (true)
		{
			try
			{
				WFIBackgroundActivityConfig backgroundActivityConfig = ((WFIConfig)MyHttpApplication.Application["WFIConfig"]).BackgroundActivityConfig;
				if (backgroundActivityConfig.BackgroundActivityEnabled)
				{
					bool flag = false;
					foreach (WFIBackgroundActivityConfig.WFIBackgroundActivityConfig_Period backgroundActivityPeriod in backgroundActivityConfig.BackgroundActivityPeriods)
					{
						if ((DateAndTime.Now.TimeOfDay >= backgroundActivityPeriod.From) & (DateAndTime.Now.TimeOfDay < backgroundActivityPeriod.To))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						_WFIBackgroundActivity wFIBackgroundActivity = new _WFIBackgroundActivity();
						wFIBackgroundActivity.Start(MyHttpApplication);
						string backgroundActivityTypeName = backgroundActivityConfig.BackgroundActivityTypeName;
						if (Operators.CompareString(backgroundActivityTypeName.Trim(), "", false) != 0)
						{
							IIboWFIBackgroundActivity iboWFIBackgroundActivity = (IIboWFIBackgroundActivity)BaseFunctions.InstantiateClass(backgroundActivityTypeName);
							iboWFIBackgroundActivity.Start(MyHttpApplication);
						}
					}
				}
				Thread.Sleep(backgroundActivityConfig.BackgroundActivityTimerLoop);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Thread.Sleep(60000);
				ProjectData.ClearProjectError();
			}
		}
	}
}
