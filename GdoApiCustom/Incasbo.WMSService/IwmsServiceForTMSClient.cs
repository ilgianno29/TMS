using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
#if !NETFRAMEWORK
using Incasbo.ServiceModel;
#endif

namespace Incasbo.WMSService;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class IwmsServiceForTMSClient : ClientBase<IwmsServiceForTMS>, IwmsServiceForTMS
{
#if NETFRAMEWORK
	public IwmsServiceForTMSClient()
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

#else
	// .NET 8: indirizzo e binding da Incasbo.ServiceModel.WcfEndpoints (non piu' dal web.config)
	public IwmsServiceForTMSClient()
		: base(WcfEndpoints.GetBinding(null, "WMSService.IwmsServiceForTMS"), WcfEndpoints.GetAddress(null, "WMSService.IwmsServiceForTMS"))
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "WMSService.IwmsServiceForTMS"), WcfEndpoints.GetAddress(endpointConfigurationName, "WMSService.IwmsServiceForTMS"))
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName, string remoteAddress)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "WMSService.IwmsServiceForTMS"), WcfEndpoints.GetAddress(endpointConfigurationName, "WMSService.IwmsServiceForTMS", remoteAddress))
	{
	}

	public IwmsServiceForTMSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "WMSService.IwmsServiceForTMS"), remoteAddress)
	{
	}

#endif
	public IwmsServiceForTMSClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	public Result BeginTransaction()
	{
		return base.Channel.BeginTransaction();
	}

	Result IwmsServiceForTMS.BeginTransaction()
	{
		//ILSpy generated this explicit interface implementation from .override directive in BeginTransaction
		return this.BeginTransaction();
	}

	public Result CommitTransaction()
	{
		return base.Channel.CommitTransaction();
	}

	Result IwmsServiceForTMS.CommitTransaction()
	{
		//ILSpy generated this explicit interface implementation from .override directive in CommitTransaction
		return this.CommitTransaction();
	}

	public Result Rollbackransaction()
	{
		return base.Channel.Rollbackransaction();
	}

	Result IwmsServiceForTMS.Rollbackransaction()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Rollbackransaction
		return this.Rollbackransaction();
	}

	public Result CreazioneBatch(Sender sender, CreazioneBatchArgs args)
	{
		return base.Channel.CreazioneBatch(sender, args);
	}

	Result IwmsServiceForTMS.CreazioneBatch(Sender sender, CreazioneBatchArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreazioneBatch
		return this.CreazioneBatch(sender, args);
	}

	public Result AggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args)
	{
		return base.Channel.AggregazioneOrdineBatch(sender, args);
	}

	Result IwmsServiceForTMS.AggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AggregazioneOrdineBatch
		return this.AggregazioneOrdineBatch(sender, args);
	}

	public Result DeAggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args)
	{
		return base.Channel.DeAggregazioneOrdineBatch(sender, args);
	}

	Result IwmsServiceForTMS.DeAggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeAggregazioneOrdineBatch
		return this.DeAggregazioneOrdineBatch(sender, args);
	}

	public Result CreazioneSpedizione(Sender sender, CreazioneSpedizioneArgs args)
	{
		return base.Channel.CreazioneSpedizione(sender, args);
	}

	Result IwmsServiceForTMS.CreazioneSpedizione(Sender sender, CreazioneSpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CreazioneSpedizione
		return this.CreazioneSpedizione(sender, args);
	}

	public Result AssociaOrdineASpedizione(Sender sender, AssociaOrdineASpedizioneArgs args)
	{
		return base.Channel.AssociaOrdineASpedizione(sender, args);
	}

	Result IwmsServiceForTMS.AssociaOrdineASpedizione(Sender sender, AssociaOrdineASpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AssociaOrdineASpedizione
		return this.AssociaOrdineASpedizione(sender, args);
	}

	public Result AssegnaSequenzaConsegnaOrdine(Sender sender, AssegnaSequenzaArgs args)
	{
		return base.Channel.AssegnaSequenzaConsegnaOrdine(sender, args);
	}

	Result IwmsServiceForTMS.AssegnaSequenzaConsegnaOrdine(Sender sender, AssegnaSequenzaArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AssegnaSequenzaConsegnaOrdine
		return this.AssegnaSequenzaConsegnaOrdine(sender, args);
	}

	public Result CalcolaNumeroPalletSagome(Sender sender, CalcolaNumeroPalletSagomeArgs args)
	{
		return base.Channel.CalcolaNumeroPalletSagome(sender, args);
	}

	Result IwmsServiceForTMS.CalcolaNumeroPalletSagome(Sender sender, CalcolaNumeroPalletSagomeArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcolaNumeroPalletSagome
		return this.CalcolaNumeroPalletSagome(sender, args);
	}
}
