using System.Collections.Specialized;
using Incasbo.Api.App;

namespace Incasbo.Web.WFI;

public class WFIDupInfo
{
	public string Id;

	public string DetailTable;

	public string SqlWhereForeignKey;

	public FieldsDictionary CampiDaSostituire;

	public StringCollection CampiDaEscludere;

	public WFIDupInfo(string Id, string DetailTable, string SqlWhereForeignKey)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		this.Id = "";
		this.DetailTable = "";
		this.SqlWhereForeignKey = "";
		CampiDaSostituire = new FieldsDictionary();
		CampiDaEscludere = new StringCollection();
		this.Id = Id;
		this.DetailTable = DetailTable;
		this.SqlWhereForeignKey = SqlWhereForeignKey;
	}

	public WFIDupInfo(string DetailTable, string SqlWhereForeignKey)
		: this(DetailTable, DetailTable, SqlWhereForeignKey)
	{
	}
}
