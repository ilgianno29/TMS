using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Incasbo.WMSService;

[ServiceContract(ConfigurationName = "WMSService.IwmsServiceForTMS")]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public interface IwmsServiceForTMS
{
	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/BeginTransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/BeginTransactionResponse")]
	Result BeginTransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CommitTransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CommitTransactionResponse")]
	Result CommitTransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/RollbackTransaction", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/RollbackTransactionResponse")]
	Result RollbackTransaction();

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdiniASpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdiniASpedizioneResponse")]
	Result AssociaOrdiniASpedizione(Sender sender, AssociaOrdiniASpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineALinea", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineALineaResponse")]
	Result AssociaOrdineALinea(Sender sender, AssociaOrdineALineaArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/DeAssociaOrdineDaLinea", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/DeAssociaOrdineDaLineaResponse")]
	Result DeAssociaOrdineDaLinea(Sender sender, AssociaOrdineALineaArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CreazioneBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CreazioneBatchResponse")]
	Result CreazioneBatch(Sender sender, CreazioneBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AggregazioneOrdineBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AggregazioneOrdineBatchResponse")]
	Result AggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/DeAggregazioneOrdineBatch", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/DeAggregazioneOrdineBatchResponse")]
	Result DeAggregazioneOrdineBatch(Sender sender, AggregazioneOrdineBatchArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CreazioneSpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CreazioneSpedizioneResponse")]
	Result CreazioneSpedizione(Sender sender, CreazioneSpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/EliminazioneSpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/EliminazioneSpedizioneResponse")]
	Result EliminazioneSpedizione(Sender sender, EliminazioneSpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineASpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssociaOrdineASpedizioneResponse")]
	Result AssociaOrdineASpedizione(Sender sender, AssociaOrdineASpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/DeAssociaOrdineDaSpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/DeAssociaOrdineDaSpedizioneResponse")]
	Result DeAssociaOrdineDaSpedizione(Sender sender, AssociaOrdineASpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/AssegnaSequenzaConsegnaOrdine", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/AssegnaSequenzaConsegnaOrdineResponse")]
	Result AssegnaSequenzaConsegnaOrdine(Sender sender, AssegnaSequenzaArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagome", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagomeResponse")]
	Result CalcolaNumeroPalletSagome(Sender sender, CalcolaNumeroPalletSagomeArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagomeSpedizione", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/CalcolaNumeroPalletSagomeSpedizioneResponse")]
	Result CalcolaNumeroPalletSagomeSpedizione(Sender sender, CalcolaNumeroPalletSagomeSpedizioneArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/GetInfoOrdine", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/GetInfoOrdineResponse")]
	Result GetInfoOrdine(Sender sender, ref GetInfoOrdineArgs args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/RichiesteVolumetrichePerRaggruppamentoOrdini", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/RichiesteVolumetrichePerRaggruppamentoOrdiniResponse")]
	Result RichiesteVolumetrichePerRaggruppamentoOrdini(Sender sender, RaggruppamentoOrdiniArgs Args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/ConcludiImportazioneOrdine", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/ConcludiImportazioneOrdineResponse")]
	Result ConcludiImportazioneOrdine(Sender sender, ConcludiImportazioneOrdineArgs Args);

	[OperationContract(Action = "http://tempuri.org/IwmsServiceForTMS/SpedizionePartenza", ReplyAction = "http://tempuri.org/IwmsServiceForTMS/SpedizionePartenzaResponse")]
	Result SpedizionePartenza(Sender sender, SpedizionePartenzaArgs Args);
}
