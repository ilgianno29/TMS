using System.Collections.Generic;
using System.ServiceModel;

namespace Incasbo;

[ServiceContract(SessionMode = SessionMode.Allowed, Namespace = "http://www.incasgroup.com/bologna/GdoApiService")]
public interface ITMSApiService
{
	[OperationContract]
	bool TestDBConnection(ref string rsMess);

	[OperationContract]
	string GetVersion();

	[OperationContract]
	string TestPing(string sStringa);

	[OperationContract]
	Result SpedizioneConfermaPrebolla(Sender sender, SpedizioneConfermaPrebollaArgs Args);

	[OperationContract]
	Result SpedizioneAggiornaQuantita(Sender sender, SpedizioneAggiornaQuantitaArgs Args);

	[OperationContract]
	Result SpedizioneInserimento(Sender sender, ref SpedizioneInserimentoArgs Args);

	[OperationContract]
	Result SpedizioneInserimentoEAttivazione(Sender sender, ref SpedizioneInserimentoArgs Args);

	[OperationContract]
	Result ViaggioCrea(Sender sender, ref Api_ViaggioInserisciArgs Args);

	[OperationContract]
	Result ViaggioChiudi(Sender sender, Api_ViaggioChiudiArgs Args);

	[OperationContract]
	Result ViaggioRiapri(Sender sender, Api_ViaggioRiapriArgs Args);

	[OperationContract]
	Result ViaggioPartenza(Sender sender, Api_ViaggioPartenzaFineArgs Args);

	[OperationContract]
	Result ViaggioFine(Sender sender, Api_ViaggioPartenzaFineArgs Args);

	[OperationContract]
	Result ViaggioElimina(Sender sender, Api_ViaggioEliminaArgs Args);

	[OperationContract]
	Result ViaggioApertoRecupera(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result ViaggioRecuperaUDS(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result ViaggioLineaRecupera(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref List<Api_ViaggioLineaRecuperaOutArgs> OutArgs);

	[OperationContract]
	Result ViaggioLineaRecuperaUDS(Sender sender, Api_ViaggioLineaRecuperaInArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result UdsSpuntaUscita(Sender sender, Api_UdsSpuntaUscitaInArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result UdsSpuntaUscitaAnnulla(Sender sender, Api_UdsSpuntaUscitaAnnullaInArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result UdsSpuntaUscitaMancanti(Sender sender, Api_ViaggioArgs InArgs, ref Api_UdsOutArgs OutArgs);

	[OperationContract]
	Result UdsAssociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args);

	[OperationContract]
	Result UdsRiassociaUdt(Sender sender, Api_UdsAssociaUdtArgs Args);

	[OperationContract]
	Result SpedizioneImport(Sender sender, Api_SpedizioneImportArgs InArgs, ref SpedizioneBaseArgs OutArgs);
}
