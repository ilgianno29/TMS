using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;

namespace Incasbo.Web.WFI;

public class IboEmptyDataTemplate : ITemplate
{
	protected string _PrefissoId;

	public IboEmptyDataTemplate(string sPrefissoId)
	{
		_PrefissoId = "";
		_PrefissoId = sPrefissoId;
	}

	protected IboEmptyDataTemplate()
	{
		_PrefissoId = "";
	}

	public void InstantiateIn(Control container)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Table val = new Table();
		TableRow val2 = new TableRow();
		TableCell val3 = new TableCell();
		Panel val4 = new Panel();
		IboWebLabel val5 = new IboWebLabel();
		val2.Cells.Add(val3);
		val.Rows.Add(val2);
		((WebControl)val).Attributes.Add("id", _PrefissoId + "_EmptyDataTemplateContainerID");
		((WebControl)val).Attributes.Add("class", "EmptyDataTemplateContainer");
		((WebControl)val4).Attributes.Add("id", _PrefissoId + "_EmptyDataTemplateContainerInternoID");
		((WebControl)val4).Attributes.Add("class", "EmptyDataTemplateContainerInterno");
		val5.CssClass = "lblEmptyDataTemplate";
		((Control)val5).ID = _PrefissoId + "_lblEmptyDataTemplate";
		val5.Translate = true;
		val5.Text = "Nessun dato trovato";
		((Control)val4).Controls.Add((Control)(object)val5);
		((Control)val3).Controls.Add((Control)(object)val4);
		container.Controls.Add((Control)(object)val);
	}
}
