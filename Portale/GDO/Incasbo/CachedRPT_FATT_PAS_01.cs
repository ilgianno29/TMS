using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace Incasbo;

[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedRPT_FATT_PAS_01 : Component, ICachedReport
{
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool IsCacheable
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool ShareDBLogonInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual TimeSpan CacheTimeOut
	{
		get
		{
			return CachedReportConstants.DEFAULT_TIMEOUT;
		}
		set
		{
		}
	}

	public virtual ReportDocument CreateReport()
	{
		RPT_FATT_PAS_01 rPT_FATT_PAS_ = new RPT_FATT_PAS_01();
		((ReportDocument)rPT_FATT_PAS_).Site = Site;
		return (ReportDocument)(object)rPT_FATT_PAS_;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		return null;
	}
}
