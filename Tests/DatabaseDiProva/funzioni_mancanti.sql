-- SOLO DATABASE DI PROVA: funzioni non presenti nello script.
-- TRUNC/lpad/FORMATDATE/FORMATTIME implementate; le altre sono segnaposto che restituiscono NULL.
CREATE OR ALTER FUNCTION dbo.TRUNC(@d datetime) RETURNS datetime AS BEGIN RETURN CAST(CAST(@d AS date) AS datetime) END
GO
CREATE OR ALTER FUNCTION dbo.lpad(@s varchar(4000), @n int, @c char(1)) RETURNS varchar(4000) AS BEGIN RETURN RIGHT(REPLICATE(@c, @n) + ISNULL(@s, ''), @n) END
GO
CREATE OR ALTER FUNCTION dbo.FORMATDATE(@d datetime) RETURNS varchar(10) AS BEGIN RETURN CONVERT(varchar(10), @d, 103) END
GO
CREATE OR ALTER FUNCTION dbo.FORMATTIME(@d datetime) RETURNS varchar(8) AS BEGIN RETURN CONVERT(varchar(8), @d, 108) END
GO
CREATE OR ALTER FUNCTION dbo.CST_XML_ReplaceChar(@s nvarchar(4000)) RETURNS nvarchar(4000) AS BEGIN RETURN @s END
GO
CREATE OR ALTER FUNCTION dbo.HumanReadableTimeInterval(@a int) RETURNS varchar(100) AS BEGIN RETURN NULL END
GO
-- Ricostruzione di prova: somme delle spedizioni di un viaggio (la versione reale va presa dal database Delsy)
CREATE OR ALTER FUNCTION dbo.GetViaggioSommatorie(@IdViaggio int) RETURNS TABLE AS RETURN
SELECT @IdViaggio IdViaggio,
       SUM(Peso) Peso, SUM(Colli) Colli, SUM(Pallet) pallet, SUM(Volume) Volume, SUM(Contrassegno) Contrassegno,
       SUM(CampoCalcolo1) CampoCalcolo1, SUM(CampoCalcolo2) CampoCalcolo2, SUM(CampoCalcolo3) CampoCalcolo3, SUM(CampoCalcolo4) CampoCalcolo4,
       SUM(CampoCalcolo5) CampoCalcolo5, SUM(CampoCalcolo6) CampoCalcolo6, SUM(CampoCalcolo7) CampoCalcolo7, SUM(CampoCalcolo8) CampoCalcolo8,
       SUM(CampoCalcolo9) CampoCalcolo9, SUM(CampoCalcolo10) CampoCalcolo10,
       COUNT(*) NumeroSpedizioni, COUNT(DISTINCT PCSDestinazione) NumeroConsegne, COUNT(DISTINCT PCSPartenza) NumeroPCSPart
FROM dbo.Spedizioni WHERE IdViaggio = @IdViaggio
GO
-- Ricostruzione di prova: ultimo evento non annullato di una spedizione (la versione reale va presa dal database Delsy)
CREATE OR ALTER FUNCTION dbo.getSpedizioneEvento(@Dummy varchar(15), @TipoEvento varchar(15), @Unibol varchar(10)) RETURNS TABLE AS RETURN
SELECT TOP 1 SE.* FROM dbo.Spedizioni_Eventi SE WHERE SE.Unibol = @Unibol AND SE.Annullato = 'N' ORDER BY SE.DataOraEvento DESC, SE.Id DESC
GO
