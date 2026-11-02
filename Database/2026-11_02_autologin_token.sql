/*
  Delsy - Sicurezza 4: token di autologin per dispositivi (totem, monitor)
  ------------------------------------------------------------------------
  Sostituisce WFIAutoLogin.aspx?u=UTENTE&p=PASSWORD con WFIAutoLogin.aspx?t=TOKEN.
  Nel database si salva solo l'hash SHA-256 del token. Script ripetibile.
  Gestione: DelsyPassword autologin-crea / autologin-elenca / autologin-revoca
*/
SET NOCOUNT ON;

IF OBJECT_ID(N'dbo.WFI_AUTOLOGIN_TOKEN', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.WFI_AUTOLOGIN_TOKEN
    (
        Id          int IDENTITY(1,1) NOT NULL CONSTRAINT PK_WFI_AUTOLOGIN_TOKEN PRIMARY KEY,
        TokenHash   char(64)      NOT NULL CONSTRAINT UQ_WFI_AUTOLOGIN_TOKEN_Hash UNIQUE,
        Utente      varchar(15)   NOT NULL,
        Descrizione varchar(100)  NOT NULL,
        Pagina      varchar(512)  NULL,        -- pagina iniziale (solo indirizzi interni, es. ~/wfi/Form/...)
        Attivo      char(1)       NOT NULL CONSTRAINT DF_WFI_AUTOLOGIN_TOKEN_Attivo DEFAULT ('S'),
        Scadenza    datetime      NULL,        -- NULL = nessuna scadenza
        UltimoUso   datetime      NULL,
        UltimoIP    varchar(64)   NULL,
        DatIns      datetime      NOT NULL CONSTRAINT DF_WFI_AUTOLOGIN_TOKEN_DatIns DEFAULT (GETDATE()),
        UteIns      varchar(15)   NOT NULL,
        CONSTRAINT FK_WFI_AUTOLOGIN_TOKEN_Utente FOREIGN KEY (Utente) REFERENCES dbo.WFI_UTENTI (CODICE),
        CONSTRAINT CK_WFI_AUTOLOGIN_TOKEN_Attivo CHECK (Attivo IN ('S', 'N'))
    );
    PRINT N'Tabella WFI_AUTOLOGIN_TOKEN creata.';
END
ELSE
    PRINT N'Tabella WFI_AUTOLOGIN_TOKEN gia'' presente.';
