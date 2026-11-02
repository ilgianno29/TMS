namespace Incasbo.Web.WFI;

public class IboInternalGridConfig2 : IboInternalGridConfig
{
	protected string _DetailPanelId;

	public string DetailPanelId
	{
		get
		{
			return _DetailPanelId;
		}
		set
		{
			_DetailPanelId = value;
		}
	}

	public IboInternalGridConfig2()
	{
		_DetailPanelId = "";
	}

	public override void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle, string sActionControlId)
	{
		Build(sNomRif, sSqlOriginalStatement, sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, sTitle, "", "");
	}

	public override void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle)
	{
		Build(sNomRif, sSqlOriginalStatement, sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, sTitle, "");
	}

	public void Build(string sNomRif, string sSqlOriginalStatement, string sOrderByField, string sOrderByDirection, string sIdGrid, string sIdToolBar, string sTitle, string sActionControlId, string sDetailPanelId)
	{
		base.Build(sNomRif, sSqlOriginalStatement, sOrderByField, sOrderByDirection, sIdGrid, sIdToolBar, sTitle, sActionControlId);
		_DetailPanelId = sDetailPanelId;
	}
}
