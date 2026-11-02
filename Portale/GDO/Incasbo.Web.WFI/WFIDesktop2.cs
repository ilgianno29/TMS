using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIDesktop2 : WFIPage
{
	protected class DesktopItem
	{
		public string Id { get; set; }

		public string ParentId { get; set; }

		public string Ordine { get; set; }

		public string Formula { get; set; }

		public string Image { get; set; }

		public string Voce { get; set; }

		public string Text { get; set; }

		public string AdditionalText { get; set; }

		public string AdditionalTextFormula { get; set; }

		public string TopRightText { get; set; }

		public string TopLeftText { get; set; }

		public string TipoNodo { get; set; }

		public string Funzione { get; set; }

		public int Level { get; set; }

		public DesktopItem ParentDesktopItem { get; set; }

		public List<DesktopItem> ChildDesktopItem { get; set; }

		public DesktopItem()
		{
			Id = "";
			ParentId = "";
			Ordine = "";
			Formula = "";
			Image = "";
			Voce = "";
			Text = "";
			AdditionalText = "";
			AdditionalTextFormula = "";
			TopRightText = "";
			TopLeftText = "";
			TipoNodo = "";
			Funzione = "";
			ChildDesktopItem = new List<DesktopItem>();
		}
	}

	protected class DesktopInfo
	{
		public DesktopItem DesktopTree { get; set; }

		public string Parent { get; set; }

		public string ParentPrevious { get; set; }

		public string Title { get; set; }

		public string[] LinkCollection { get; set; }

		public NameValueCollection SqlCollection { get; set; }

		public int Level { get; set; }

		public DateTime LastDateTime { get; set; }

		public int CacheTime { get; set; }

		public DesktopItem ActualItem { get; set; }

		public DesktopInfo()
		{
			Parent = "";
			ParentPrevious = "";
			Title = "HOME\\";
			LinkCollection = new string[0];
			SqlCollection = new NameValueCollection();
			Level = 0;
			CacheTime = 300;
			ActualItem = null;
		}

		public void Reset()
		{
			Parent = "";
			ParentPrevious = "";
			Title = "HOME\\";
			LinkCollection = null;
			Level = 0;
			ActualItem = null;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dlDesktop")]
	private DataList _dlDesktop;

	private char kTipoNodoFunzione;

	private char kTipoNodoParent;

	private char kTipoNodoNavigate;

	private char kTipoNodoExtended;

	private char kTipoNodoCaption;

	private DesktopInfo _DesktopInfo;

	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DesktopContainer")]
	protected virtual Panel DesktopContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected virtual DataList dlDesktop
	{
		[CompilerGenerated]
		get
		{
			return _dlDesktop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			EventHandler eventHandler = dlDesktop_Init;
			DataListCommandEventHandler val = new DataListCommandEventHandler(dlDesktop_ItemCommand);
			DataListItemEventHandler val2 = new DataListItemEventHandler(dlDesktop_ItemDataBound);
			DataList val3 = _dlDesktop;
			if (val3 != null)
			{
				((Control)val3).Init -= eventHandler;
				val3.ItemCommand -= val;
				val3.ItemDataBound -= val2;
			}
			_dlDesktop = value;
			val3 = _dlDesktop;
			if (val3 != null)
			{
				((Control)val3).Init += eventHandler;
				val3.ItemCommand += val;
				val3.ItemDataBound += val2;
			}
		}
	}

	public WFIDesktop2()
	{
		((Control)this).Load += Page_Load;
		kTipoNodoFunzione = 'F';
		kTipoNodoParent = 'P';
		kTipoNodoNavigate = 'N';
		kTipoNodoExtended = 'X';
		kTipoNodoCaption = 'C';
		_DesktopInfo = null;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_IsSessionVariablePersistent = true;
			if (!_SessionVariable.ContainsKey("DesktopInfo".ToUpper()))
			{
				_DesktopInfo = new DesktopInfo();
				_SessionVariable.Remove("DesktopInfo".ToUpper());
				_SessionVariable.Add("DesktopInfo".ToUpper(), _DesktopInfo);
			}
			else
			{
				_DesktopInfo = (DesktopInfo)_SessionVariable["DesktopInfo".ToUpper()];
			}
			if (!((Page)this).IsPostBack)
			{
				_DesktopInfo.Reset();
			}
			string rsmess = "";
			LoadData(ref rsmess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected FXRETURN LoadData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Invalid comparison between Unknown and I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			CallStackAdd();
			bool flag = false;
			if (_DesktopInfo.DesktopTree == null)
			{
				_DesktopInfo.DesktopTree = new DesktopItem();
				_DesktopInfo.DesktopTree.Id = "HOME";
				_DesktopInfo.DesktopTree.Text = "HOME";
				_DesktopInfo.DesktopTree.Level = 0;
				_DesktopInfo.LastDateTime = DateAndTime.Now;
				flag = true;
			}
			else if (Math.Abs(DateAndTime.DateDiff((DateInterval)9, _DesktopInfo.LastDateTime, DateAndTime.Now, (Microsoft.VisualBasic.FirstDayOfWeek)1, (FirstWeekOfYear)1)) > _DesktopInfo.CacheTime)
			{
				_DesktopInfo.DesktopTree = new DesktopItem();
				_DesktopInfo.SqlCollection.Clear();
				_DesktopInfo.DesktopTree.Id = "HOME";
				_DesktopInfo.DesktopTree.Text = "HOME";
				_DesktopInfo.DesktopTree.Level = 0;
				_DesktopInfo.LastDateTime = DateAndTime.Now;
				flag = true;
			}
			dlDesktop.RepeatColumns = base.SessionEnvironment.WFIConfig.MenuManagerConfig.DesktopRepeatColumns;
			((WebControl)DesktopContainer).CssClass = "DesktopContainer" + dlDesktop.RepeatColumns;
			if (!flag)
			{
				if (!((Page)this).IsPostBack)
				{
					ListDataBind(_DesktopInfo.DesktopTree);
				}
				goto IL_01f4;
			}
			DesktopInfo desktopInfo;
			DesktopItem Node = (desktopInfo = _DesktopInfo).DesktopTree;
			FXRETURN val3 = CreateTree(ref Node, ref rsmess);
			desktopInfo.DesktopTree = Node;
			val2 = val3;
			if ((int)val2 <= 0)
			{
				ListDataBind(_DesktopInfo.DesktopTree);
				goto IL_01f4;
			}
			val = val2;
			goto end_IL_0005;
			IL_01f4:
			val = (FXRETURN)0;
			end_IL_0005:;
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
			result = val;
			CallStackRemove();
		}
		return result;
	}

	protected void LinkPath_Click(object sender, EventArgs e)
	{
	}

	protected FXRETURN CreateTree(ref DesktopItem Node, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Invalid comparison between Unknown and I4
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			DataTable dtDesktopItem = null;
			val2 = ((Operators.CompareString(Node.Id, "HOME", false) != 0) ? base.SessionEnvironment.BuildDesktop(Node.Id, ref dtDesktopItem, ref rsMess) : base.SessionEnvironment.BuildDesktop("", ref dtDesktopItem, ref rsMess));
			if ((int)val2 > 0)
			{
				val = val2;
			}
			else
			{
				checked
				{
					foreach (DataRow row in dtDesktopItem.Rows)
					{
						if (Node.Level > 0 && Node.ChildDesktopItem.Count == 0)
						{
							DesktopItem desktopItem = new DesktopItem();
							DesktopItem desktopItem2 = desktopItem;
							desktopItem2.Id = Node.Id + "_back";
							desktopItem2.Image = "~/images/Toolbar/96/backArrow.png";
							desktopItem2.Text = TranslateMessage("XXX", "Indietro");
							desktopItem2.AdditionalText = TranslateMessage("XXX", "Menù Precedente");
							desktopItem2.TipoNodo = "X";
							desktopItem2.Funzione = "GOTLEV;" + Node.ParentDesktopItem.Id;
							desktopItem2.Level = Node.Level + 1;
							desktopItem2.ParentDesktopItem = Node;
							desktopItem2 = null;
							Node.ChildDesktopItem.Add(desktopItem);
						}
						DesktopItem Node2 = new DesktopItem();
						DesktopItem desktopItem3 = Node2;
						desktopItem3.Id = row["MnuId"].ToString();
						desktopItem3.Image = row["DesktopImage"].ToString();
						desktopItem3.Text = row["Text"].ToString();
						desktopItem3.AdditionalText = row["AdditionalText"].ToString();
						desktopItem3.AdditionalTextFormula = row["AdditionalTextFormula"].ToString();
						desktopItem3.TipoNodo = row["TIPONODO"].ToString();
						desktopItem3.Funzione = row["FUNZIONE"].ToString();
						desktopItem3.Voce = row["MNUCODICE"].ToString();
						desktopItem3.Level = Node.Level + 1;
						desktopItem3.ParentDesktopItem = Node;
						if (Operators.CompareString(desktopItem3.Voce, "SYS.MOSTUSED", false) == 0)
						{
							desktopItem3.Id = "SYS.MOSTUSED";
						}
						if (Operators.CompareString(desktopItem3.Image, "", false) == 0)
						{
							if (((Operators.CompareString(desktopItem3.TipoNodo, Conversions.ToString(kTipoNodoNavigate), false) == 0) & (Operators.CompareString(desktopItem3.Funzione, "", false) == 0)) | (Operators.CompareString(desktopItem3.TipoNodo, Conversions.ToString(kTipoNodoParent), false) == 0))
							{
								desktopItem3.Image = base.SessionEnvironment.WFIConfig.MenuManagerConfig.FolderGenericIcon;
							}
							else
							{
								desktopItem3.Image = base.SessionEnvironment.WFIConfig.MenuManagerConfig.DesktopGenericIcon;
							}
						}
						string funzione = "";
						string tipoNodo = desktopItem3.TipoNodo;
						if (Operators.CompareString(tipoNodo, Conversions.ToString(kTipoNodoExtended), false) == 0)
						{
							funzione = desktopItem3.Funzione;
						}
						else if (Operators.CompareString(tipoNodo, Conversions.ToString(kTipoNodoFunzione), false) == 0)
						{
							funzione = desktopItem3.Funzione;
						}
						else if (Operators.CompareString(tipoNodo, Conversions.ToString(kTipoNodoCaption), false) == 0)
						{
							funzione = "";
						}
						else if (Operators.CompareString(tipoNodo, Conversions.ToString(kTipoNodoNavigate), false) == 0)
						{
							funzione = ((Operators.CompareString(desktopItem3.Funzione, "", false) == 0) ? ("GOTLEV;" + desktopItem3.Id) : ((Operators.CompareString(Strings.Left(desktopItem3.Funzione, 6).ToUpper(), "GOTPAG", false) == 0) ? desktopItem3.Funzione : ("GOTPAG;" + desktopItem3.Funzione)));
						}
						else if (Operators.CompareString(tipoNodo, Conversions.ToString(kTipoNodoParent), false) == 0)
						{
							funzione = "GOTLEV;" + desktopItem3.Id;
						}
						desktopItem3.Funzione = funzione;
						desktopItem3 = null;
						Node.ChildDesktopItem.Add(Node2);
						if (Operators.CompareString(Node2.AdditionalText, "", false) == 0 && ((Operators.CompareString(Node2.TipoNodo, "N", false) == 0) | (Operators.CompareString(Node2.TipoNodo, "P", false) == 0) | (Operators.CompareString(Node2.TipoNodo, "F", false) == 0)))
						{
							string additionalTextFormula = Node2.AdditionalTextFormula;
							additionalTextFormula = additionalTextFormula.Replace("%USER%", base.SessionEnvironment.WebUser.WebUserInfo.Codice);
							additionalTextFormula = additionalTextFormula.Replace("%UTENTE%", base.SessionEnvironment.WebUser.WebUserInfo.Codice);
							additionalTextFormula = additionalTextFormula.Replace("%GROUP%", base.SessionEnvironment.WebUser.WebUserInfo.Gruppo);
							additionalTextFormula = additionalTextFormula.Replace("%GRUPPO%", base.SessionEnvironment.WebUser.WebUserInfo.Gruppo);
							additionalTextFormula = additionalTextFormula.Replace("%FILIALE%", base.SessionEnvironment.WebUser.WebUserInfo.Filiale);
							additionalTextFormula = additionalTextFormula.Replace("%ORGANIZZAZIONE%", base.SessionEnvironment.WebUser.WebUserInfo.Organizzazione);
							additionalTextFormula = additionalTextFormula.Replace("%ORGANIZATION%", base.SessionEnvironment.WebUser.WebUserInfo.Organizzazione);
							if (additionalTextFormula.Contains("%USER.FILTER%"))
							{
								additionalTextFormula = ((Operators.CompareString(base.SessionEnvironment.WebUser.WebUserInfo.Filtro, "", false) == 0) ? (Strings.Replace(additionalTextFormula, "%USER.FILTER%", "1=1", 1, -1, (CompareMethod)0) + " ") : (Strings.Replace(additionalTextFormula, "%USER.FILTER%", base.SessionEnvironment.WebUser.WebUserInfo.Filtro, 1, -1, (CompareMethod)0) + " "));
							}
							if (Operators.CompareString(additionalTextFormula, "", false) != 0)
							{
								if (_DesktopInfo.SqlCollection.AllKeys.Contains<string>(additionalTextFormula))
								{
									Node2.AdditionalText = _DesktopInfo.SqlCollection[additionalTextFormula];
								}
								else
								{
									object obj = "";
									DBConnection dbConn = base.DbConn;
									string text = additionalTextFormula;
									string text2 = "";
									dbConn.DoSql(text, (object)"", ref obj, ref text2);
									Node2.AdditionalText = obj.ToString();
									_DesktopInfo.SqlCollection.Add(additionalTextFormula, obj.ToString());
								}
							}
						}
						val2 = CreateTree(ref Node2, ref rsMess);
						if (unchecked((int)val2) <= 0)
						{
							continue;
						}
						val = val2;
						goto end_IL_0005;
					}
					if (((Node.ChildDesktopItem.Count > 0) & (Node.ChildDesktopItem.Count < 6)) | ((Node.ParentDesktopItem == null) & (Node.ChildDesktopItem.Count >= 0) & (Node.ChildDesktopItem.Count < 6)))
					{
						int count = dtDesktopItem.Rows.Count;
						for (int i = count; i <= 6; i++)
						{
							DesktopItem desktopItem4 = new DesktopItem();
							desktopItem4.Funzione = "IDLE";
							desktopItem4.Level = Node.Level + 1;
							desktopItem4.TipoNodo = "I";
							Node.ChildDesktopItem.Add(desktopItem4);
						}
					}
					val = (FXRETURN)0;
				}
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

	protected FXRETURN SearchNodeById(ref string NodeID, ref DesktopItem StartNode, ref DesktopItem FindNode, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (Operators.CompareString(StartNode.Id.ToUpper(), NodeID.ToUpper(), false) != 0)
			{
				DesktopItem FindNode2 = default(DesktopItem);
				foreach (DesktopItem item in StartNode.ChildDesktopItem)
				{
					DesktopItem StartNode2 = item;
					val2 = SearchNodeById(ref NodeID, ref StartNode2, ref FindNode2, ref rsMess);
					if ((int)val2 <= 0)
					{
						if (FindNode2 != null)
						{
							FindNode = FindNode2;
							break;
						}
						continue;
					}
					val = val2;
					goto end_IL_0005;
				}
			}
			else
			{
				FindNode = StartNode;
			}
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

	private void dlDesktop_Init(object sender, EventArgs e)
	{
	}

	private void dlDesktop_ItemCommand(object source, DataListCommandEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Invalid comparison between Unknown and I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Invalid comparison between Unknown and I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string rsMess = "";
		string text = "";
		string text2 = "";
		string sRedirect = "";
		IboResourceManager iboResourceManager = new IboResourceManager();
		string rsMess2 = "";
		try
		{
			CallStackAdd();
			string NodeID = ((CommandEventArgs)e).CommandArgument.ToString();
			DesktopInfo desktopInfo;
			DesktopItem StartNode = (desktopInfo = _DesktopInfo).DesktopTree;
			DesktopItem FindNode = default(DesktopItem);
			FXRETURN val3 = SearchNodeById(ref NodeID, ref StartNode, ref FindNode, ref rsMess2);
			desktopInfo.DesktopTree = StartNode;
			val2 = val3;
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			string[] array = _DesktopInfo.Title.Split(new char[1] { '\\' });
			array = (string[])Utils.CopyArray((Array)array, (Array)new string[checked(_DesktopInfo.Level + 1)]);
			string text3 = "";
			string[] array2 = array;
			foreach (string text4 in array2)
			{
				if (Operators.CompareString(text4, "", false) != 0)
				{
					text3 = text3 + text4 + "\\";
				}
			}
			val2 = iboResourceManager.Resource_Check(MenuResourceName + FindNode.Voce, ref rsMess);
			if ((int)val2 > 0)
			{
				val = val2;
				return;
			}
			switch (Strings.Left(FindNode.Funzione.ToUpper(), 6))
			{
			case "LOGOFF":
			{
				string sUrl = "";
				if (base.SessionEnvironment.Session["PageRedirectAfterLogOff"] != null)
				{
					sUrl = base.SessionEnvironment.Session["PageRedirectAfterLogOff"].ToString();
				}
				if (Operators.CompareString(sUrl, "", false) == 0)
				{
					sUrl = "~/WFI/Form/Redirector.aspx";
				}
				IboSessionEnvironment sessionEnvironment = base.SessionEnvironment;
				string sRisorsa = base.SessionEnvironment.WebApplicationName.ToUpper();
				NodeID = "";
				sessionEnvironment.LogRisorseAzioneInserisci(sRisorsa, "LOGOUT", "UI", "", "", ref NodeID);
				LogOff();
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				break;
			}
			case "CALFUN":
			{
				string vsFunction = Strings.Left(Strings.Mid(FindNode.Funzione.ToUpper(), 8), 6);
				sRedirect = Strings.Mid(FindNode.Funzione.ToUpper(), 15);
				FunctionArguments functionArguments2 = new FunctionArguments("CALLFUNC", vsFunction);
				((Page)this).Session["FunctionArgs"] = functionArguments2;
				IboSessionEnvironment sessionEnvironment3 = base.SessionEnvironment;
				string voce2 = FindNode.Voce;
				NodeID = "";
				sessionEnvironment3.UpdateMenuUsage(voce2, ref NodeID);
				sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
				break;
			}
			case "NEWGRD":
			{
				text = FindNode.Funzione;
				val2 = NewGridParser(text, ref sRedirect, ref rsMess);
				if ((int)val2 > 0)
				{
					return;
				}
				IboSessionEnvironment sessionEnvironment4 = base.SessionEnvironment;
				string voce3 = FindNode.Voce;
				NodeID = "";
				sessionEnvironment4.UpdateMenuUsage(voce3, ref NodeID);
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
				break;
			}
			case "GOTLEV":
			{
				DesktopItem FindNode2 = null;
				ref string nodeID = ref FindNode.Funzione.Split(new char[1] { ';' })[1];
				StartNode = (desktopInfo = _DesktopInfo).DesktopTree;
				FXRETURN val4 = SearchNodeById(ref nodeID, ref StartNode, ref FindNode2, ref rsMess2);
				desktopInfo.DesktopTree = StartNode;
				val2 = val4;
				if ((int)val2 > 0)
				{
					val = val2;
					return;
				}
				ListDataBind(FindNode2);
				break;
			}
			case "GOTPAG":
			{
				IboSessionEnvironment sessionEnvironment6 = base.SessionEnvironment;
				string voce5 = FindNode.Voce;
				NodeID = "";
				sessionEnvironment6.UpdateMenuUsage(voce5, ref NodeID);
				sRedirect = Strings.Mid(FindNode.Funzione.ToUpper(), 8);
				sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
				break;
			}
			case "GOTOSF":
			{
				text = Strings.Mid(FindNode.Funzione.ToUpper(), 8);
				string[] array3 = Strings.Split(text, ";", -1, (CompareMethod)0);
				checked
				{
					string text6 = BaseFunctions.OnlyAspxPageName(array3[array3.Count() - 1].ToUpper()).ToUpper();
					text6 = text6.Split(new char[1] { '?' })[0];
					base.SessionEnvironment.SessionVariables.Remove(text6);
					base.SessionEnvironment.SessionVariables.Add(text6, new IboDictionaryCollection<string, object>());
					int num2 = array3.Count() - 2;
					for (int k = 0; k <= num2; k++)
					{
						string[] array4 = Strings.Split(array3[k], "=", -1, (CompareMethod)0);
						base.SessionEnvironment.SessionVariables[text6][array4[0].ToUpper()] = (object)array4[1];
					}
					FunctionArguments functionArguments3 = new FunctionArguments("", "");
					if (base.SessionEnvironment.SessionVariables[text6].ContainsKey("CONTEXT"))
					{
						functionArguments3.Context = base.SessionEnvironment.SessionVariables[text6]["CONTEXT"].ToString();
					}
					sRedirect = array3[array3.Count() - 1];
					((Page)this).Session.Add("FunctionArgs", (object)functionArguments3);
					IboSessionEnvironment sessionEnvironment5 = base.SessionEnvironment;
					string voce4 = FindNode.Voce;
					NodeID = "";
					sessionEnvironment5.UpdateMenuUsage(voce4, ref NodeID);
					sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
			}
			case "GOTOPF":
			{
				text = Strings.Mid(FindNode.Funzione.ToUpper(), 8);
				string[] array3 = Strings.Split(text, ";", -1, (CompareMethod)0);
				checked
				{
					string text5 = BaseFunctions.OnlyAspxPageName(array3[array3.Count() - 1].ToUpper()).ToUpper();
					text5 = text5.Split(new char[1] { '?' })[0];
					base.SessionEnvironment.SessionVariables.Remove(text5);
					base.SessionEnvironment.SessionVariables.Add(text5, new IboDictionaryCollection<string, object>());
					int num = array3.Count() - 2;
					for (int j = 0; j <= num; j++)
					{
						string[] array4 = Strings.Split(array3[j], "=", -1, (CompareMethod)0);
						base.SessionEnvironment.SessionVariables[text5][array4[0].ToUpper()] = (object)array4[1];
					}
					FunctionArguments functionArguments = new FunctionArguments("", "");
					functionArguments.Context = "PRINTFILTER";
					if (base.SessionEnvironment.SessionVariables[text5].ContainsKey("CONTEXT"))
					{
						functionArguments.Context = base.SessionEnvironment.SessionVariables[text5]["CONTEXT"].ToString();
					}
					else
					{
						base.SessionEnvironment.SessionVariables[text5]["CONTEXT"] = (object)functionArguments.Context;
					}
					if (!base.SessionEnvironment.SessionVariables[text5].ContainsKey("FORMMODE"))
					{
						base.SessionEnvironment.SessionVariables[text5]["FORMMODE"] = (object)"";
					}
					sRedirect = array3[array3.Count() - 1];
					sRedirect = ((!sRedirect.Contains("?")) ? (sRedirect + "?NomRep=" + base.SessionEnvironment.SessionVariables[text5]["REPORT"].ToString()) : (sRedirect + "&NomRep=" + base.SessionEnvironment.SessionVariables[text5]["REPORT"].ToString()));
					((Page)this).Session.Add("FunctionArgs", (object)functionArguments);
					IboSessionEnvironment sessionEnvironment2 = base.SessionEnvironment;
					string voce = FindNode.Voce;
					NodeID = "";
					sessionEnvironment2.UpdateMenuUsage(voce, ref NodeID);
					sRedirect = get_RedirectSelectCustomOrStandard(sRedirect);
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboResponseRedirect(ref robjCallStackHandler, ref sRedirect);
					break;
				}
			}
			default:
				if (Operators.CompareString(((CommandEventArgs)e).CommandName, "CLICK_TO_LINK", false) == 0)
				{
					ListDataBind(FindNode);
				}
				break;
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

	protected void ListDataBind(DesktopItem i)
	{
		_DesktopInfo.ActualItem = i;
		_DesktopInfo.Level = i.Level;
		_DesktopInfo.LinkCollection = new string[checked(i.Level + 1)];
		_DesktopInfo.LinkCollection[i.Level] = i.Id;
		DesktopItem desktopItem = i;
		while (desktopItem.ParentDesktopItem != null)
		{
			_DesktopInfo.LinkCollection[desktopItem.ParentDesktopItem.Level] = desktopItem.ParentDesktopItem.Id;
			desktopItem = desktopItem.ParentDesktopItem;
		}
		((BaseDataList)dlDesktop).DataSource = i.ChildDesktopItem;
		((BaseDataList)dlDesktop).DataBind();
	}

	private void dlDesktop_ItemDataBound(object sender, DataListItemEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((int)e.Item.ItemType == 0)
			{
				int num = 1;
				string[] linkCollection = _DesktopInfo.LinkCollection;
				checked
				{
					for (int i = 0; i < linkCollection.Length; i++)
					{
						string NodeID = linkCollection[i];
						LinkButton val = (LinkButton)GetControlByName((Control)(object)dlDesktop, "LinkPath" + num);
						if (Operators.CompareString(NodeID, "", false) == 0)
						{
							val.Text = "HOME\\";
						}
						else
						{
							DesktopItem FindNode = null;
							DesktopInfo desktopInfo;
							DesktopItem StartNode = (desktopInfo = _DesktopInfo).DesktopTree;
							string rsMess = "";
							SearchNodeById(ref NodeID, ref StartNode, ref FindNode, ref rsMess);
							desktopInfo.DesktopTree = StartNode;
							if (FindNode != null)
							{
								val.Text = FindNode.Text.ToUpper() + "\\";
							}
						}
						val.CommandName = "CLICK_TO_LINK";
						val.CommandArgument = NodeID;
						num++;
					}
				}
			}
			else if (((int)e.Item.ItemType == 2) | ((int)e.Item.ItemType == 3))
			{
				DesktopItem desktopItem = (DesktopItem)e.Item.DataItem;
				Panel val2 = (Panel)((Control)e.Item).FindControl("ItemContainer");
				if (Operators.CompareString(desktopItem.Funzione, "IDLE", false) == 0)
				{
					((WebControl)val2).CssClass = "ItemContainerInvisible ItemTipoNodo_" + desktopItem.TipoNodo + " " + Strings.Replace(desktopItem.Voce, ".", "_", 1, -1, (CompareMethod)0);
				}
				else
				{
					((WebControl)val2).CssClass = "ItemContainer ItemTipoNodo_" + desktopItem.TipoNodo + " " + Strings.Replace(desktopItem.Voce, ".", "_", 1, -1, (CompareMethod)0);
				}
				Image val3 = (Image)((Control)e.Item).FindControl("ItemImage");
				val3.ImageUrl = desktopItem.Image;
				Label val4 = (Label)((Control)e.Item).FindControl("ItemText");
				val4.Text = desktopItem.Text;
				Label val5 = (Label)((Control)e.Item).FindControl("ItemAdditionalText");
				val5.Text = desktopItem.AdditionalText;
				LinkButton val6 = (LinkButton)((Control)e.Item).FindControl("ItemLink");
				val6.CommandName = "CLICK_TO_TILE";
				val6.CommandArgument = desktopItem.Id;
				Panel val7 = (Panel)((Control)e.Item).FindControl("ItemTopRightPanel");
				Literal val8 = (Literal)((Control)e.Item).FindControl("ltItemTopRightValue");
				val8.Text = desktopItem.TopRightText;
				((Control)val7).Visible = Operators.CompareString(val8.Text, "", false) != 0;
				Panel val9 = (Panel)((Control)e.Item).FindControl("ItemTopLeftPanel");
				Literal val10 = (Literal)((Control)e.Item).FindControl("ltItemTopLeftValue");
				val10.Text = desktopItem.TopLeftText;
				((Control)val9).Visible = Operators.CompareString(val10.Text, "", false) != 0;
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
