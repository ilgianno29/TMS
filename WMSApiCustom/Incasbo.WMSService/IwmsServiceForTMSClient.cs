using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Incasbo.WMSService;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
public class IwmsServiceForTMSClient : ClientBase<IwmsServiceForTMS>, IwmsServiceForTMS
{
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

	public Result RollbackTransaction()
	{
		return base.Channel.RollbackTransaction();
	}

	Result IwmsServiceForTMS.RollbackTransaction()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RollbackTransaction
		return this.RollbackTransaction();
	}

	public Result AssociaOrdiniASpedizione(Sender sender, AssociaOrdiniASpedizioneArgs args)
	{
		return base.Channel.AssociaOrdiniASpedizione(sender, args);
	}

	Result IwmsServiceForTMS.AssociaOrdiniASpedizione(Sender sender, AssociaOrdiniASpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AssociaOrdiniASpedizione
		return this.AssociaOrdiniASpedizione(sender, args);
	}

	public Result AssociaOrdineALinea(Sender sender, AssociaOrdineALineaArgs args)
	{
		return base.Channel.AssociaOrdineALinea(sender, args);
	}

	Result IwmsServiceForTMS.AssociaOrdineALinea(Sender sender, AssociaOrdineALineaArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in AssociaOrdineALinea
		return this.AssociaOrdineALinea(sender, args);
	}

	public Result DeAssociaOrdineDaLinea(Sender sender, AssociaOrdineALineaArgs args)
	{
		return base.Channel.DeAssociaOrdineDaLinea(sender, args);
	}

	Result IwmsServiceForTMS.DeAssociaOrdineDaLinea(Sender sender, AssociaOrdineALineaArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeAssociaOrdineDaLinea
		return this.DeAssociaOrdineDaLinea(sender, args);
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

	public Result EliminazioneSpedizione(Sender sender, EliminazioneSpedizioneArgs args)
	{
		return base.Channel.EliminazioneSpedizione(sender, args);
	}

	Result IwmsServiceForTMS.EliminazioneSpedizione(Sender sender, EliminazioneSpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in EliminazioneSpedizione
		return this.EliminazioneSpedizione(sender, args);
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

	public Result DeAssociaOrdineDaSpedizione(Sender sender, AssociaOrdineASpedizioneArgs args)
	{
		return base.Channel.DeAssociaOrdineDaSpedizione(sender, args);
	}

	Result IwmsServiceForTMS.DeAssociaOrdineDaSpedizione(Sender sender, AssociaOrdineASpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DeAssociaOrdineDaSpedizione
		return this.DeAssociaOrdineDaSpedizione(sender, args);
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

	public Result CalcolaNumeroPalletSagomeSpedizione(Sender sender, CalcolaNumeroPalletSagomeSpedizioneArgs args)
	{
		return base.Channel.CalcolaNumeroPalletSagomeSpedizione(sender, args);
	}

	Result IwmsServiceForTMS.CalcolaNumeroPalletSagomeSpedizione(Sender sender, CalcolaNumeroPalletSagomeSpedizioneArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CalcolaNumeroPalletSagomeSpedizione
		return this.CalcolaNumeroPalletSagomeSpedizione(sender, args);
	}

	public Result GetInfoOrdine(Sender sender, ref GetInfoOrdineArgs args)
	{
		return base.Channel.GetInfoOrdine(sender, ref args);
	}

	Result IwmsServiceForTMS.GetInfoOrdine(Sender sender, ref GetInfoOrdineArgs args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetInfoOrdine
		return this.GetInfoOrdine(sender, ref args);
	}

	public Result RichiesteVolumetrichePerRaggruppamentoOrdini(Sender sender, RaggruppamentoOrdiniArgs Args)
	{
		return base.Channel.RichiesteVolumetrichePerRaggruppamentoOrdini(sender, Args);
	}

	Result IwmsServiceForTMS.RichiesteVolumetrichePerRaggruppamentoOrdini(Sender sender, RaggruppamentoOrdiniArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RichiesteVolumetrichePerRaggruppamentoOrdini
		return this.RichiesteVolumetrichePerRaggruppamentoOrdini(sender, Args);
	}

	public Result ConcludiImportazioneOrdine(Sender sender, ConcludiImportazioneOrdineArgs Args)
	{
		return base.Channel.ConcludiImportazioneOrdine(sender, Args);
	}

	Result IwmsServiceForTMS.ConcludiImportazioneOrdine(Sender sender, ConcludiImportazioneOrdineArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ConcludiImportazioneOrdine
		return this.ConcludiImportazioneOrdine(sender, Args);
	}

	public Result SpedizionePartenza(Sender sender, SpedizionePartenzaArgs Args)
	{
		return base.Channel.SpedizionePartenza(sender, Args);
	}

	Result IwmsServiceForTMS.SpedizionePartenza(Sender sender, SpedizionePartenzaArgs Args)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SpedizionePartenza
		return this.SpedizionePartenza(sender, Args);
	}
}
