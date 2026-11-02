/*
  Delsy - Sicurezza 3: password utenti salvate come hash PBKDF2
  ---------------------------------------------------------------
  L'hash occupa fino a 100 caratteri: la colonna WFI_UTENTI.PASSWORD (in origine 30) va allargata.
  Da eseguire PRIMA di installare la nuova versione del portale e di GdoWSC.
  Lo script e' ripetibile: se la colonna e' gia' abbastanza larga non fa nulla.
  Mantiene il tipo (varchar/nvarchar) e la nullabilita' esistenti.
*/
SET NOCOUNT ON;

DECLARE @tipo sysname, @lunghezza int, @nullabile bit, @sql nvarchar(400);

SELECT @tipo = t.name,
       @lunghezza = CASE WHEN t.name IN ('nvarchar', 'nchar') THEN c.max_length / 2 ELSE c.max_length END,
       @nullabile = c.is_nullable
FROM sys.columns c
JOIN sys.types t ON t.user_type_id = c.user_type_id
WHERE c.object_id = OBJECT_ID(N'dbo.WFI_UTENTI') AND c.name = N'PASSWORD';

IF @tipo IS NULL
BEGIN
    RAISERROR(N'Colonna dbo.WFI_UTENTI.PASSWORD non trovata.', 16, 1);
    RETURN;
END

IF @lunghezza <> -1 AND @lunghezza < 128
BEGIN
    SET @sql = N'ALTER TABLE dbo.WFI_UTENTI ALTER COLUMN PASSWORD '
             + CASE WHEN @tipo IN ('nvarchar', 'nchar') THEN N'nvarchar(128)' ELSE N'varchar(128)' END
             + CASE WHEN @nullabile = 1 THEN N' NULL' ELSE N' NOT NULL' END + N';';
    PRINT N'Eseguo: ' + @sql;
    EXEC sp_executesql @sql;
END
ELSE
    PRINT N'Colonna PASSWORD gia'' adeguata (' + @tipo + N', ' + CAST(@lunghezza AS nvarchar(10)) + N').';

-- Riepilogo: quante password sono gia' nel nuovo formato
SELECT COUNT(*) AS Utenti,
       SUM(CASE WHEN PASSWORD LIKE 'PBKDF2-SHA256$%' THEN 1 ELSE 0 END) AS GiaConvertite
FROM dbo.WFI_UTENTI;
