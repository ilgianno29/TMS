/*
  Delsy Listini - bozze, approvazione e registro modifiche
  ---------------------------------------------------------
  Le modifiche ai listini (manuali, da template Excel, da file del vettore, rinnovi) NON vanno
  direttamente nelle tabelle usate dal motore (TariffeContratti, TariffePassiveTestata/Voci/Fasce):
  restano in TAR_Bozze / TAR_BozzeRighe finché non vengono approvate.
  Ogni azione viene scritta in TAR_Registro, che non si può modificare né cancellare.
  Script ripetibile.
*/
SET NOCOUNT ON;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

IF OBJECT_ID(N'dbo.TAR_Bozze', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TAR_Bozze
    (
        IdBozza          int IDENTITY(1,1) NOT NULL CONSTRAINT PK_TAR_Bozze PRIMARY KEY,
        Codice           AS ('B-' + RIGHT('0000' + CAST(IdBozza AS varchar(10)), 4)) PERSISTED,
        AttivaPassiva    char(1)        NOT NULL CONSTRAINT DF_TAR_Bozze_AP DEFAULT ('P'),
        Contratto        varchar(15)    NULL,     -- contratto esistente da modificare; NULL se la bozza ne crea uno nuovo
        ContrattoNuovo   varchar(15)    NULL,     -- codice del contratto creato dalla bozza (rinnovo, nuovo listino)
        Trasportatore    varchar(15)    NULL,
        Titolo           nvarchar(200)  NOT NULL,
        Origine          varchar(20)    NOT NULL, -- MANUALE, TEMPLATE, FILE_VETTORE, RINNOVO
        FileOrigine      nvarchar(260)  NULL,
        Stato            varchar(20)    NOT NULL CONSTRAINT DF_TAR_Bozze_Stato DEFAULT ('BOZZA'),
                                                  -- BOZZA, VALIDAZIONE, APPROVATA (in attesa), APPLICATA, RIFIUTATA, ANNULLATA
        ApplicaDal       date           NULL,     -- per modifiche a contratti in corso: data da cui applicarle
        Note             nvarchar(1000) NULL,
        CreataDa         varchar(15)    NOT NULL,
        CreataIl         datetime2(0)   NOT NULL CONSTRAINT DF_TAR_Bozze_CreataIl DEFAULT (SYSDATETIME()),
        InviataDa        varchar(15)    NULL,
        InviataIl        datetime2(0)   NULL,
        DecisaDa         varchar(15)    NULL,
        DecisaIl         datetime2(0)   NULL,
        NotaDecisione    nvarchar(1000) NULL,
        ApplicataIl      datetime2(0)   NULL,
        Versione         rowversion     NOT NULL, -- per evitare che due utenti decidano la stessa bozza insieme
        CONSTRAINT CK_TAR_Bozze_Stato CHECK (Stato IN ('BOZZA', 'VALIDAZIONE', 'APPROVATA', 'APPLICATA', 'RIFIUTATA', 'ANNULLATA')),
        CONSTRAINT CK_TAR_Bozze_Origine CHECK (Origine IN ('MANUALE', 'TEMPLATE', 'FILE_VETTORE', 'RINNOVO')),
        CONSTRAINT CK_TAR_Bozze_AP CHECK (AttivaPassiva IN ('A', 'P')),
        CONSTRAINT CK_TAR_Bozze_Rifiuto CHECK (Stato <> 'RIFIUTATA' OR LEN(LTRIM(ISNULL(NotaDecisione, N''))) > 0)
    );
    CREATE INDEX IX_TAR_Bozze_Stato ON dbo.TAR_Bozze (Stato, ApplicaDal);
    PRINT N'Tabella TAR_Bozze creata.';
END

IF OBJECT_ID(N'dbo.TAR_BozzeRighe', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TAR_BozzeRighe
    (
        IdRiga       int IDENTITY(1,1) NOT NULL CONSTRAINT PK_TAR_BozzeRighe PRIMARY KEY,
        IdBozza      int            NOT NULL CONSTRAINT FK_TAR_BozzeRighe_Bozza REFERENCES dbo.TAR_Bozze (IdBozza) ON DELETE CASCADE,
        Ordine       int            NOT NULL,
        Oggetto      varchar(10)    NOT NULL, -- CONTRATTO, TESTATA, VOCE, FASCIA
        Operazione   varchar(10)    NOT NULL, -- NUOVA, MODIFICA, ELIMINA
        IdOriginale  int            NULL,     -- IdTariffa / IdVoce / IdFascia esistente (MODIFICA, ELIMINA)
        RifPadre     int            NULL,     -- riga della stessa bozza a cui appartiene (voce di una testata nuova, ecc.)
        Descrizione  nvarchar(400)  NOT NULL, -- es. "STDIECIMO > CORTINA D'AMPEZZO · NOLO · 6-10 bancali"
        DatiPrima    nvarchar(max)  NULL,     -- JSON dei valori attuali
        DatiDopo     nvarchar(max)  NULL,     -- JSON dei valori proposti
        RifFile      nvarchar(200)  NULL,     -- da dove viene il valore (es. "pag. 2 riga 3", "Tariffe!D7")
        Esito        varchar(15)    NOT NULL CONSTRAINT DF_TAR_BozzeRighe_Esito DEFAULT ('OK'), -- OK, DA_SISTEMARE
        Messaggio    nvarchar(400)  NULL,
        CONSTRAINT CK_TAR_BozzeRighe_Oggetto CHECK (Oggetto IN ('CONTRATTO', 'TESTATA', 'VOCE', 'FASCIA')),
        CONSTRAINT CK_TAR_BozzeRighe_Operazione CHECK (Operazione IN ('NUOVA', 'MODIFICA', 'ELIMINA')),
        CONSTRAINT CK_TAR_BozzeRighe_Esito CHECK (Esito IN ('OK', 'DA_SISTEMARE')),
        CONSTRAINT CK_TAR_BozzeRighe_Json CHECK ((DatiPrima IS NULL OR ISJSON(DatiPrima) = 1) AND (DatiDopo IS NULL OR ISJSON(DatiDopo) = 1))
    );
    CREATE INDEX IX_TAR_BozzeRighe_Bozza ON dbo.TAR_BozzeRighe (IdBozza, Ordine);
    PRINT N'Tabella TAR_BozzeRighe creata.';
END

IF OBJECT_ID(N'dbo.TAR_Registro', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TAR_Registro
    (
        IdRegistro  bigint IDENTITY(1,1) NOT NULL CONSTRAINT PK_TAR_Registro PRIMARY KEY,
        DataOra     datetime2(3)   NOT NULL CONSTRAINT DF_TAR_Registro_DataOra DEFAULT (SYSDATETIME()),
        Utente      varchar(15)    NOT NULL,
        Azione      varchar(40)    NOT NULL, -- es. BOZZA_CREATA, MODIFICA, IMPORT_TEMPLATE, IMPORT_FILE, INVIATA, APPROVATA, RIFIUTATA, APPLICATA
        Contratto   varchar(15)    NULL,
        IdBozza     int            NULL,
        Descrizione nvarchar(1000) NOT NULL,
        Dettaglio   nvarchar(max)  NULL,     -- JSON con valori prima/dopo, file, ecc.
        Postazione  nvarchar(100)  NULL,     -- indirizzo IP o nome della postazione
        CONSTRAINT CK_TAR_Registro_Json CHECK (Dettaglio IS NULL OR ISJSON(Dettaglio) = 1)
    );
    CREATE INDEX IX_TAR_Registro_Contratto ON dbo.TAR_Registro (Contratto, DataOra DESC);
    CREATE INDEX IX_TAR_Registro_Bozza ON dbo.TAR_Registro (IdBozza);
    PRINT N'Tabella TAR_Registro creata.';
END
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Il registro si può solo scrivere: modifiche e cancellazioni vengono rifiutate per chiunque
CREATE OR ALTER TRIGGER dbo.TR_TAR_Registro_SoloInserimento ON dbo.TAR_Registro
INSTEAD OF UPDATE, DELETE
AS
BEGIN
    RAISERROR (N'Il registro modifiche dei listini non può essere modificato né cancellato.', 16, 1);
    ROLLBACK TRANSACTION;
END
GO

PRINT N'Bozze e registro listini pronti.';
