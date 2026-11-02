namespace Incasbo.Api.Gdo;

public class EventoSpedizioneTipo
{
	public static string SpedizioneInserimentoManuale => "SPEDIZIONE.INSERIMENTO.MAN";

	public static string SpedizioneInserimentoAuto => "SPEDIZIONE.INSERIMENTO.AUTO";

	public static string SpedizioneInserimentoRiconsegna => "SPEDIZIONE.INSERIMENTO.RIC";

	public static string SpedizioneAnnullamento => "SPEDIZIONE.ANNULLA";

	public static string SpedizioneCambioDataConsegna => "SPEDIZIONE.CAMBIODATA";

	public static string SpedizioneEliminaCorrispondente => "SPEDIZIONE.CORRISP.TOG";

	public static string SpedizioneAggiungiCorrispondente => "SPEDIZIONE.CORRISP.AGG";

	public static string SpedizionePianificata => "SPEDIZIONE.PIANIFICATA";

	public static string SpedizioneRipianifica => "SPEDIZIONE.RIPIANIFICA";

	public static string SpedizioneEsito => "SPEDIZIONE.ESITO.OK";

	public static string SpedizioneEsitoParziale => "SPEDIZIONE.ESITO.PARZ";

	public static string SpedizioneEsitoKo => "SPEDIZIONE.ESITO.KO";

	public static string SpedizioneArrivoATP => "SPEDIZIONE.ATP";

	public static string UdsEsitoOk => "UDS.ESITO.OK";

	public static string UdsEsitoKo => "UDS.ESITO.KO";

	public static string UdsNonCaricata => "UDS.ESITO.NONCARICATA";

	public static string UdsCaricata => "UDS.ESITO.CARICATA";

	public static string SpedizioneAssociaAViaggio => "SPEDIZIONE.ASSOCIAAVIAGGIO";

	public static string SpedizioneRimuoviDaViaggio => "SPEDIZIONE.RIMUOVIDAVIAGGIO";

	public static string SpedizioneAttivazione => "SPEDIZIONE.ATTIVAZIONE";

	public static string SpedizioneDisattivazione => "SPEDIZIONE.DISATTIVAZIONE";

	public static string SpedizioneInConsegna => "SPEDIZIONE.INCONSEGNA";

	public static string SpedizioneCertifica => "SPEDIZIONE.CERTIFICA";

	public static string SpedizioneAnnullaCertificazione => "SPEDIZIONE.ANNULLA.CERTIFICA";

	public static string SpedizionePrelevataDaWMS => "SPEDIZIONE.WMS.PRELEVATA";

	public static string SpedizioneInPrelievoDaWMS => "SPEDIZIONE.WMS.INPRELIEVO";

	public static string SpedizioneSpuntaUDSUscita => "SPEDIZIONE.SPUNTAUDS.USCITA";

	public static string SpedizioneStampaDDT => "SPEDIZIONE.STAMPADDT";

	public static string SpedizioneAssociaALinea => "SPEDIZIONE.ASSOCIAALINEA";

	public static string SpedizioneRimuoviDaLinea => "SPEDIZIONE.RIMUOVIDALINEA";
}
