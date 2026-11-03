/*
  Dati di PROVA per il modulo Listini (database di test, NON produzione).
  Ricalcano il listino BENNATO 2024 mostrato nel portale: record VIAGGIO a COSTO ZERO
  per gli stabilimenti e record SPEDIZIONE dal magazzino di Diecimo per zona di arrivo.
*/
SET NOCOUNT ON;

-- Anagrafiche
INSERT INTO Trasportatori (Codice, RagioneSociale) VALUES ('BENNATO', 'Bennato Trasporti'), ('TROSSI', 'Trasporti Rossi Srl');
UPDATE Trasportatori SET FatturaA = Codice;
INSERT INTO PCS (Codice, RagioneSociale) VALUES
 ('STTMOSTO', 'STABILIMENTO TORRE DI MOSTO'), ('STDIECIMO', 'STABILIMENTO DIECIMO'), ('COALTOPA', 'C/O LUCART ALTOPASCIO'),
 ('CL0001', 'CLIENTE CORTINA'), ('CL0002', 'CLIENTE TOLMEZZO'), ('CL0003', 'CLIENTE CROVIANA'), ('CL0004', 'CLIENTE IMPERIA');
INSERT INTO ZoneMacro (Codice, Descrizione) VALUES ('NE', 'NORD EST'), ('NO', 'NORD OVEST');
INSERT INTO Zone (Codice, Descrizione, ZonaSpedizione, ZonaTariffaAttiva, ZonaTariffaPassiva, CodiceZonaMacro, Sequenza, Attivo, ZonaSpedizioneIsDefault, ZonaTariffaAttivaIsDefault, ZonaTariffaPassivaIsDefault, UteIns, UteAgg) VALUES
 ('AGORD', 'LA VALLE AGORDINA', 'S', 'S', 'S', 'NE', 1, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA'),
 ('CORTI', 'CORTINA D''AMPEZZO', 'S', 'S', 'S', 'NE', 2, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA'),
 ('MOGGI', 'MOGGIO UDINESE', 'S', 'S', 'S', 'NE', 3, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA'),
 ('TOLME', 'TOLMEZZO', 'S', 'S', 'S', 'NE', 4, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA'),
 ('CROVI', 'CROVIANA', 'S', 'S', 'S', 'NE', 5, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA'),
 ('LIGPO', 'LIGURIA PONENTE', 'S', 'S', 'S', 'NO', 6, 'S', 'N', 'N', 'N', 'PROVA', 'PROVA');
INSERT INTO TipiSpedizione (Codice, Descrizione) VALUES ('CZ', 'COSTO ZERO'), ('STD', 'STANDARD');
INSERT INTO TipiMezzo (Codice, Descrizione, Categoria, ProfiloVelocita) VALUES ('GEN', 'GENERICO - NON SPECIFICATO', 'GEN', 'STD'), ('BIL', 'BILICO', 'BIL', 'STD');
INSERT INTO TipiMerce (Codice, Descrizione) VALUES ('CARTA', 'CARTA');
INSERT INTO Mezzi (Codice, Descrizione, Targa, TipoMezzo, PuntoPartenza) VALUES ('M001', 'MOTRICE BENNATO', 'AB123CD', 'GEN', 'STTMOSTO'), ('M002', 'BILICO ROSSI', 'EF456GH', 'BIL', 'STDIECIMO');
INSERT INTO Voci (Codice, Descrizione, CodiceIva, TipoVoce, FlagNolo) VALUES ('NOLO', 'NOLO', '22', 'P', 'S'), ('FUEL', 'FUEL SURCHARGE', '22', 'P', 'N');
INSERT INTO TariffeTipiDocumento (Codice, Descrizione, Spedizione, Viaggio, TariffaAttiva, TariffaPassiva, Attivo, Contrassegno, Giacenza) VALUES
 ('VIAGGIO', 'VIAGGIO', 'N', 'S', 'S', 'S', 'S', 'N', 'N'), ('SPEDIZIONE', 'SPEDIZIONE', 'S', 'N', 'S', 'S', 'S', 'N', 'N');
INSERT INTO Viaggi_TipiViaggio (Codice, Descrizione, TariffaPassiva, TariffaAttiva) VALUES ('NORM', 'NORMALE', 'S', 'S'), ('CZ', 'COSTO ZERO', 'S', 'S');

-- Contratti
INSERT INTO TariffeContratti (Codice, AttivaPassiva, Trasportatore, Descrizione, DataInizioValidita, DataFineValidita, ArrotondamentoImporti, UteIns, UteAgg) VALUES
 ('BENNATO 2024', 'P', 'BENNATO', 'BENNATO 2024', '2024-01-01', '2026-12-31', 0.01, 'PROVA', 'PROVA'),
 ('TROSSI 2026', 'P', 'TROSSI', 'TRASPORTI ROSSI 2026', '2026-01-01', '2026-12-31', 0.50, 'PROVA', 'PROVA');

-- Tariffe (testata): viaggi a COSTO ZERO e spedizioni per zona
INSERT INTO TariffePassiveTestata (IdTariffa, Contratto, TipoDocumento, TipoSpedizione, TipoMerce, TipoMezzo, Cliente, GruppoTariffarioPartenza, PCSPartenza, MacroZonaArrivo, ZonaArrivo, GruppoTariffarioArrivo, PCSArrivo, UteIns, UteAgg) VALUES
 (123130, 'BENNATO 2024', 'VIAGGIO', 'CZ', '*ALL', 'GEN', '*ALL', '*ALL', 'STTMOSTO', '*ALL', '*ALL', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123131, 'BENNATO 2024', 'VIAGGIO', 'CZ', '*ALL', 'GEN', '*ALL', '*ALL', 'COALTOPA', '*ALL', '*ALL', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123133, 'BENNATO 2024', 'SPEDIZIONE', '*ALL', '*ALL', '*ALL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'AGORD', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123134, 'BENNATO 2024', 'SPEDIZIONE', '*ALL', '*ALL', '*ALL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'CORTI', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123135, 'BENNATO 2024', 'SPEDIZIONE', '*ALL', '*ALL', '*ALL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'MOGGI', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123136, 'BENNATO 2024', 'SPEDIZIONE', '*ALL', '*ALL', '*ALL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'TOLME', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (123137, 'BENNATO 2024', 'SPEDIZIONE', '*ALL', '*ALL', '*ALL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'CROVI', '*ALL', '*ALL', 'PROVA', 'PROVA'),
 (200001, 'TROSSI 2026', 'VIAGGIO', '*ALL', '*ALL', 'BIL', '*ALL', '*ALL', 'STDIECIMO', '*ALL', 'CORTI', '*ALL', '*ALL', 'PROVA', 'PROVA');

-- Voci: NOLO a forfait per i viaggi, NOLO per bancale per le spedizioni
INSERT INTO TariffePassiveVoci (IdVoce, IdTariffa, Voce, CampoCalcolo, UteIns, UteAgg) VALUES
 (500130, 123130, 'NOLO', 'FORFAIT', 'PROVA', 'PROVA'), (500131, 123131, 'NOLO', 'FORFAIT', 'PROVA', 'PROVA'),
 (500133, 123133, 'NOLO', 'Pallet', 'PROVA', 'PROVA'), (500134, 123134, 'NOLO', 'Pallet', 'PROVA', 'PROVA'),
 (500135, 123135, 'NOLO', 'Pallet', 'PROVA', 'PROVA'), (500136, 123136, 'NOLO', 'Pallet', 'PROVA', 'PROVA'),
 (500137, 123137, 'NOLO', 'Pallet', 'PROVA', 'PROVA'), (600001, 200001, 'NOLO', 'FORFAIT', 'PROVA', 'PROVA');

-- Fasce
INSERT INTO TariffePassiveFasce (IdFascia, IdVoce, FasciaInferiore, FasciaSuperiore, Fisso, Variabile, Percentuale, UteIns, UteAgg) VALUES
 (900130, 500130, 0, 999999999, 0, 0, 0, 'PROVA', 'PROVA'),
 (900131, 500131, 0, 999999999, 0, 0, 0, 'PROVA', 'PROVA'),
 (900001, 600001, 0, 999999999, 760, 0, 0, 'PROVA', 'PROVA');
DECLARE @v TABLE (IdVoce int, p1 decimal(18,5), p2 decimal(18,5), p3 decimal(18,5), p4 decimal(18,5));
INSERT INTO @v VALUES (500133, 38, 34, 30, 27), (500134, 44, 39, 35, 31), (500135, 36, 32, 28.5, 25.5), (500136, 35, 31, 27.5, 24.5), (500137, 41, 36.5, 32.5, 29);
INSERT INTO TariffePassiveFasce (IdFascia, IdVoce, FasciaInferiore, FasciaSuperiore, Fisso, Variabile, Percentuale, UteIns, UteAgg)
SELECT IdVoce * 10 + n, IdVoce, lo, hi, 0, v, 0, 'PROVA', 'PROVA'
FROM @v CROSS APPLY (VALUES (1, 0, 5, p1), (2, 5, 10, p2), (3, 10, 20, p3), (4, 20, 33, p4)) f(n, lo, hi, v);

-- Contatori come nel portale
INSERT INTO Parametrica (Nome, Filiale, Valore, TipoDato) VALUES
 ('COUNTERS.TRA.TARIFFEPASSIVE.TESTATA', ' ', '200001', 'CONT'),
 ('COUNTERS.TRA.TARIFFEPASSIVE.VOCI', ' ', '600001', 'CONT'),
 ('COUNTERS.TRA.TARIFFEPASSIVE.FASCE', ' ', '9999999', 'CONT');

-- Viaggi: 1856 costo zero con 3 spedizioni; 1851 verso una zona senza tariffa
INSERT INTO Viaggi (IdViaggio, TipoViaggio, Vettore, TipoSpedizione, TipoMerce, PCSPartenza, ZonaArrivo, MotricePianificata, DataPartenzaPianificata, DataPartenzaEffettiva, Cliente)
VALUES (1856, 'CZ', 'BENNATO', 'CZ', 'CARTA', 'STTMOSTO', NULL, 'M001', '2026-10-30T06:00:00', '2026-10-30T06:20:00', 'LUCART'),
       (1851, 'NORM', 'TROSSI', 'STD', 'CARTA', 'STDIECIMO', 'LIGPO', 'M002', '2026-10-30T07:00:00', '2026-10-30T07:10:00', 'LUCART');
INSERT INTO Spedizioni (UniBol, UnibolParent, UnibolMaster, TipoServizio, Cliente, ClienteFatturazione, TipoSpedizione, TipoMerce, PCSPartenza, PCSDestinazione, ZonaSpedizione, ZonaPartenzaTariffaAttiva, ZonaArrivoTariffaAttiva, ZonaArrivoTariffaPassiva, IdViaggio, Pallet, Peso, Colli)
VALUES ('77120', '77120', '77120', 'STD', 'CL0001', 'CL0001', 'STD', 'CARTA', 'STDIECIMO', 'CL0001', 'CORTI', 'CORTI', 'CORTI', 'CORTI', 1856, 12, 6400, 12),
       ('77125', '77125', '77125', 'STD', 'CL0002', 'CL0002', 'STD', 'CARTA', 'STDIECIMO', 'CL0002', 'TOLME', 'TOLME', 'TOLME', 'TOLME', 1856, 9, 4700, 9),
       ('77131', '77131', '77131', 'STD', 'CL0003', 'CL0003', 'STD', 'CARTA', 'STDIECIMO', 'CL0003', 'CROVI', 'CROVI', 'CROVI', 'CROVI', 1856, 8, 4100, 8),
       ('77140', '77140', '77140', 'STD', 'CL0004', 'CL0004', 'STD', 'CARTA', 'STDIECIMO', 'CL0004', 'LIGPO', 'LIGPO', 'LIGPO', 'LIGPO', 1851, 18, 9200, 18);
PRINT 'Dati di prova caricati.';

-- Parametri letti dal motore tariffe (in produzione sono già configurati)
INSERT INTO Parametrica (Nome, Filiale, Valore, TipoDato) VALUES ('PARAMS.VIAGGI.SOGLIA_VETTORI_MIGLIORI', ' ', '10', 'NUM');

-- Transit Point: PCS deposito gestito da un trasportatore (vista Corrispondenti); le spedizioni del viaggio CZ transitano da qui
INSERT INTO PCS (Codice, RagioneSociale, PuntoDiDeposito, IsFiliale, CodiceTrasportatore) VALUES ('TPBELLUNO', 'TRANSIT POINT BELLUNO', 'S', 'N', 'BENNATO');
UPDATE Spedizioni SET Corrispondente = 'TPBELLUNO', Trasportatore = 'BENNATO' WHERE IdViaggio = 1856;
