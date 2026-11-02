using System;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using Incasbo.Web.Components;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class Info : WFIPage
{
	[field: AccessedThroughProperty("pnlMainContent")]
	protected virtual Panel pnlMainContent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgLogoApplicazione")]
	protected virtual Image imgLogoApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloApplicazione")]
	protected virtual IboWebLabel lblTitoloApplicazione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTitoloModuloSoftware")]
	protected virtual IboWebLabel lblTitoloModuloSoftware
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtVersione")]
	protected virtual IboWebLabel txtVersione
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtIncas")]
	protected virtual IboWebLabel txtIncas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSessioniAperte")]
	protected virtual IboWebLabel lblSessioniAperte
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSessioniAperte")]
	protected virtual IboWebLabel txtSessioniAperte
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSessioniChiuse")]
	protected virtual IboWebLabel lblSessioniChiuse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSessioniChiuse")]
	protected virtual IboWebLabel txtSessioniChiuse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSessioniCorrenti")]
	protected virtual IboWebLabel lblSessioniCorrenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSessioniCorrenti")]
	protected virtual IboWebLabel txtSessioniCorrenti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblConteggioRichieste")]
	protected virtual IboWebLabel lblConteggioRichieste
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtConteggioRichieste")]
	protected virtual IboWebLabel txtConteggioRichieste
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgLogoDitta")]
	protected virtual Image imgLogoDitta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("imgLogoIncas")]
	protected virtual Image imgLogoIncas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Info()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			txtSessioniAperte.Text = GlobalModule.StartedSessions.ToString();
			txtSessioniChiuse.Text = GlobalModule.EndedSessions.ToString();
			txtSessioniCorrenti.Text = GlobalModule.CurrentSessions.ToString();
			txtConteggioRichieste.Text = GlobalModule.RequestCount.ToString();
			imgLogoApplicazione.ImageUrl = base.SessionEnvironment.WFIConfig.ApplicationConfig.LogoApplicazione;
			imgLogoIncas.ImageUrl = base.SessionEnvironment.WFIConfig.ApplicationConfig.LogoIncas;
			if (Operators.CompareString(base.SessionEnvironment.WFIConfig.ApplicationConfig.LogoDitta, "", false) == 0)
			{
				((Control)imgLogoDitta).Visible = false;
			}
			else
			{
				((Control)imgLogoDitta).Visible = true;
				imgLogoDitta.ImageUrl = base.SessionEnvironment.WFIConfig.ApplicationConfig.LogoDitta;
			}
			lblTitoloApplicazione.Text = base.SessionEnvironment.WebApplicationTitle;
			lblTitoloModuloSoftware.Text = base.SessionEnvironment.WebSoftwareModuleTitle;
			IboWebLabel val;
			(val = txtVersione).Text = val.Text + " " + base.SessionEnvironment.WebApplicationVersion.ToString();
			txtIncas.Text = base.SessionEnvironment.WFIConfig.ApplicationConfig.InfoIncas;
		}
	}
}
