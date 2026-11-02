namespace Incasbo.Web.WFI;

public class WFIForeignKey
{
	public WFIFields MasterTableFields { get; set; }

	public WFIFields DetailsTableFields { get; set; }

	public WFITable DetailsTable
	{
		get
		{
			if (DetailsTableFields.Count > 0)
			{
				return DetailsTableFields[0].Table;
			}
			return null;
		}
	}

	public WFITable MasterTable
	{
		get
		{
			if (MasterTableFields.Count > 0)
			{
				return MasterTableFields[0].Table;
			}
			return null;
		}
	}

	public WFIForeignKey()
	{
		MasterTableFields = new WFIFields();
		DetailsTableFields = new WFIFields();
	}
}
