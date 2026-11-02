using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;

namespace Incasbo.Web.WFI;

public class MultiviewInternalGridConfig : IboInternalGridConfig
{
	protected string _IdViewDataTable;

	public string IdViewDataTable
	{
		get
		{
			return _IdViewDataTable;
		}
		set
		{
			_IdViewDataTable = value;
		}
	}

	public string IdView
	{
		get
		{
			string result = "";
			for (Control parent = ((Control)base.GridView).Parent; parent != null; parent = parent.Parent)
			{
				if (parent is View)
				{
					result = parent.ID;
					break;
				}
			}
			return result;
		}
	}

	public MultiviewInternalGridConfig()
	{
		_IdViewDataTable = "";
	}

	public new void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle)
	{
		_NomRif = sNomRif;
		_SqlStatement = sSqlOriginalStatement;
		_SqlOriginalStatement = sSqlOriginalStatement;
		_OrderByField = sOrderByField;
		_OrderByDirection = sOrderByDirection;
		_Id = sIdGrid;
		_ToolbarId = sIdToolBar;
		_Title = sTitle;
		_IdViewDataTable = "";
	}

	protected new void Build(string sNomRif, string sSqlStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar)
	{
	}

	public new void InitUi(StateBag ObjViewState, ref IboGridView objGridView, ref IboWebLabel objTitle)
	{
		base.InitUi(ObjViewState, ref objGridView, ref objTitle);
	}
}
