# Delsy Manager 9.1 – sorgenti ricostruiti

Codice C# ricostruito dalle DLL originali (VB.NET, .NET Framework 4.0) tramite ILSpy.
Tutti i 12 progetti compilano (`dotnet build Delsy.sln`) senza errori, con target ancora net40.

## Modifiche manuali rispetto al decompilato grezzo
- Riferimenti tra DLL convertiti in ProjectReference; soluzione `Delsy.sln`.
- I "Module" VB (modGeneral, DBFormatFunctions) importati con `global using static`.
- ~4.000 righe `((AppBaseClass)this).X` -> `this.X` (accesso a membri protected).
- `switch (enum - 1)` -> `switch ((int)enum - 1)` (IboDbLib, GdoWSC).
- Finalizer di DBConnection riscritto come distruttore C#.
- `Calendario_Crea` (GdoApi) eredita esplicitamente da `Incasbo.Api.App.Calendario_Crea`.
- `Contrassegno.Contrassegno` rinominata `ImportoContrassegno` (C# non ammette membro = nome classe).
  **DA VERIFICARE** il mapping ORM verso la colonna `Contrassegno`.
- Lambda mancante in `GdoWsc_CalcoloOttimizzatoKmETempi_DEPOT` ricostruita dall'IL.
- `RawPrinterHelper.SendStringToPrinterVB6` rimosso (VB6 PowerPacks, mai chiamato).
- **Crystal Reports**: `AppApi/Incasbo.Api.App/IboCRW.cs` escluso dalla build e sostituito
  da un segnaposto (`IboCRW.Stub.cs`) che lancia NotSupportedException. Da sostituire.

## Fase 1 – Librerie di base su .NET 8

- **IboClassLib, IboDbLib, IboWebParam, AppApi** compilano per `net48` **e** `net8.0-windows`.
  Gli altri progetti passano da .NET 4.0 a **.NET 4.8** e continuano a usare la versione net48.
- **Solo SQL Server**, sempre tramite `Microsoft.Data.SqlClient` (rimossi OleDb, ODBC,
  System.Data.OracleClient, SQLite). Usare un altro tipo di server genera un errore esplicito.
  - Le stringhe di connessione si costruiscono con `SqlConnectionStringBuilder`
    (password con `;` o apici non rompono più la connessione).
  - Ora vengono rispettati *Sicurezza integrata* e *Timeout* anche con provider `SQLCLIENT`
    (prima venivano ignorati).
  - Le vecchie stringhe in formato OLE DB (`Provider=SQLOLEDB;...`) vengono convertite in automatico.
  - Cifratura: come prima, **non obbligatoria**. Per attivarla aggiungere `Encrypt=True`.
- Gestione errori DB (`IboAppLogHandling`): legge direttamente l'eccezione ricevuta invece di
  `Information.Err()`.
- `StatisticsManager`: `JavaScriptSerializer` sostituito da `LegacyJson` (stesso formato JSON).
- Rimosso il codice "My" generato da VB (non usato).
- Solo in net48 (API non presenti su .NET 8, non usate nella soluzione):
  `Incasbo.Security.Impersonator`, `Incasbo.IboMailerPEC` (da rifare con MailKit se servono).
- Test: `dotnet test Tests/Delsy.Tests` (20 test).

## Fase 2 – Logica di business su .NET 8

- **GdoApi, GdoApiCustom, WMSApi, WMSApiCustom, GdoParamsDefault(+Custom), IboLabel** compilano
  per `net48` e `net8.0-windows`. Solo **GdoWSC** (servizi web) resta su net48: è la fase 3.
- **Client WCF/SOAP** (WMS, PTV xLocate/xRoute/xTour, TMSServiceForMap): su .NET 8 non leggono
  più il web.config. Indirizzi e binding si configurano con `Incasbo.ServiceModel.WcfEndpoints`:
  - `WcfEndpoints.LoadFromConfigFile("web.config")` legge la **stessa** sezione
    `<system.serviceModel><client>` usata oggi (supporta basicHttpBinding);
  - oppure `WcfEndpoints.Register(nome, contratto, indirizzo)`.
  Su net48 i client si comportano esattamente come prima.
- `Assembly.CodeBase` (188 punti) sostituito da `AssemblyLocation.DirectoryOf(...)`:
  su net48 resta CodeBase (necessario con lo shadow copy di IIS), su .NET 8 usa Location.
- `Encoding.Default` sostituito da `LegacyEncoding.Ansi`: su .NET 8 Encoding.Default è UTF-8,
  mentre i file esportati e le email devono restare in ANSI (Windows-1252) come prima.
- Cartella etichette in `GdoAbstractApi`: non usa più il codice "My" di VB.
- Test: 26 (incluso una vera chiamata SOAP al client WMS su .NET 8 verso un server finto).
