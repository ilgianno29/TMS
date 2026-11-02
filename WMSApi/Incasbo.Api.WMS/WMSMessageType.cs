namespace Incasbo.Api.WMS;

public enum WMSMessageType
{
	UnKnown,
	AssegnaSequenzaConsegnaOrdine,
	AssociaSpedizioneABatch,
	AssociaSpedizioneAViaggio,
	AssociaSpedizioneAViaggioChiuso,
	CalcolaNumeroPalletSagome,
	CreazioneBatch,
	CreazioneViaggio,
	CancellazioneViaggio,
	RiapriViaggio,
	DisassociaSpedizioneABatch,
	DisassociaSpedizioneAViaggio,
	DisassociaSpedizioneAViaggioChiuso,
	AggiornaQuantitaSpedizione,
	CalcolaNumeroPalletSagomeViaggio,
	AssociaSpedizioneALinea,
	DisassociaSpedizioneALinea,
	CreaViaggio_AssociaSpedizioniAViaggio,
	RichiesteVolumetrichePerRaggruppamentoOrdini,
	ExtendedFunction1,
	ExtendedFunction2,
	ExtendedFunction3,
	ExtendedFunction4,
	ExtendedFunction5
}
