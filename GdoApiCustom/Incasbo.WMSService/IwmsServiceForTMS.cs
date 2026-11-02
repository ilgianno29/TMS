using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Incasbo.WMSService;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(ConfigurationName = "WMSService.IwmsServiceForTMS")]
public interface IwmsServiceForTMS
{
	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/BeginTransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/BeginTransactionResponse")]
	Result BeginTransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CommitTransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CommitTransactionResponse")]
	Result CommitTransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/Rollbackransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/RollbackransactionResponse")]
	Result Rollbackransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CreazioneBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CreazioneBatchResponse")]
	Result CreazioneBatch(Sender sender, CreazioneBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AggregazioneOrdineBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AggregazioneOrdineBatchResponse")]
	Result AggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/DeAggregazioneOrdineBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/DeAggregazioneOrdineBatchResponse")]
	Result DeAggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CreazioneSpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CreazioneSpedizioneResponse")]
	Result CreazioneSpedizione(Sender sender, CreazioneSpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineASpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineASpedizioneResponse")]
	Result AssociaOrdineASpedizione(Sender sender, AssociaOrdineASpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssegnaSequenzaConsegnaOrdine", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssegnaSequenzaConsegnaOrdineResponse")]
	Result AssegnaSequenzaConsegnaOrdine(Sender sender, AssegnaSequenzaArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagome", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagomeResponse")]
	Result CalcolaNumeroPalletSagome(Sender sender, CalcolaNumeroPalletSagomeArgs args);
}
