using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace Incasbo;

public class RPT_FATT_PAS_01 : ReportClass
{
	public override string ResourceName
	{
		get
		{
			return "RPT_FATT_PAS_01.rpt";
		}
		set
		{
		}
	}

	public override bool NewGenerator
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public override string FullResourceName
	{
		get
		{
			return "Incasbo.RPT_FATT_PAS_01.rpt";
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section1 => ((ReportDocument)this).ReportDefinition.Sections[0];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section2 => ((ReportDocument)this).ReportDefinition.Sections[1];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section GroupHeaderSection1 => ((ReportDocument)this).ReportDefinition.Sections[2];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section3 => ((ReportDocument)this).ReportDefinition.Sections[3];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section GroupFooterSection1 => ((ReportDocument)this).ReportDefinition.Sections[4];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section4 => ((ReportDocument)this).ReportDefinition.Sections[5];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section Section5 => ((ReportDocument)this).ReportDefinition.Sections[6];
}
