using System.ServiceModel;

namespace Incasbo;

[ServiceContract(/*Could not decode attribute arguments.*/)]
public interface ITMSServiceForWMS
{
	[OperationContract]
	bool TestDBConnection(ref string rsMess);

	[OperationContract]
	string GetVersion();

	[OperationContract]
	string TestPing(string sStringa);

	[OperationContract]
	Result NotificaNumeroPalletSagome(Sender sender, NotificaPalletSagomeArgs Args);

	[OperationContract]
	Result AttivazioneBatch(Sender sender, BatchArgs Args);

	[OperationContract]
	Result NotificaOrdinePrelevato(Sender sender, OrdinePrelevatoArgs Args);

	[OperationContract]
	Result NotificaOrdineInizioPrelievo(Sender sender, OrdineArgs Args);

	[OperationContract]
	Result NotificaUdsSpuntata(Sender sender, UdsSpuntataArgs Args);

	[OperationContract]
	Result NotificaUds(Sender sender, WMS_UdsArgs Args);

	[OperationContract]
	Result NotificaInizioFormazioneSagome(Sender sender, ViaggioArgs Args);

	[OperationContract]
	Result NotificaFineFormazioneSagome(Sender sender, ViaggioPalletSagomeArgs Args);

	[OperationContract]
	Result NotificaOrdineSpuntato(Sender sender, OrdineArgs Args);

	[OperationContract]
	Result NotificaInizioSpuntaSagome(Sender sender, ViaggioArgs Args);

	[OperationContract]
	Result NotificaFineSpuntaSagome(Sender sender, ViaggioPalletSagomeArgs Args);

	[OperationContract]
	Result NotificaNumeroPalletSagomeAViaggio(Sender sender, ViaggioPalletSagomeArgs Args);

	[OperationContract]
	Result AnnullamentoOrdine(Sender sender, OrdineArgs Args);

	[OperationContract]
	Result FineLavorazioneOrdine(Sender sender, OrdineArgs Args);

	[OperationContract]
	Result FineLavorazioneBatch(Sender sender, BatchArgs Args);

	[OperationContract]
	Result FineLavorazioneViaggio(Sender sender, ViaggioArgs Args);

	[OperationContract]
	Result SpedizioneAggiornaRiferimentiDDT(Sender sender, DDTArgs Args);

	[OperationContract]
	Result NotificaOrdineDataSpedizione(Sender sender, OrdineArgs Args);

	[OperationContract]
	Result FinePrelievoBatch(Sender sender, BatchArgs Args);

	[OperationContract]
	Result NotificaSagomeVolumetrichePerRaggruppamentoOrdini(Sender sender, WMS_RaggruppamentiOrdiniArgs Args);

	[OperationContract]
	Result SpedizioneDeterminaCorrispondenteMigliore(Sender sender, ref CorrispondenteMiglioreArgs Args);

	[OperationContract]
	Result ChiusuraViaggioDaWms(Sender sender, ViaggioArgs Args);

	[OperationContract]
	Result OrdineTrasferimentoDaWms(Sender sender, WMS_OrdTrasfArgs Args);
}
