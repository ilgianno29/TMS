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

## Fase 3a – Servizi WCF su .NET 8 (GdoWSC.Host)

Nuovo progetto **GdoWSC.Host** (ASP.NET Core + CoreWCF, .NET 8) che espone i 3 servizi WCF
con **gli stessi indirizzi, namespace e binding** del Web.config originale:

| Servizio | Indirizzo | Binding | Namespace |
|---|---|---|---|
| TMSServiceForWMS | `/TMSServiceForWMS.svc` | wsHttpBinding, security None (SOAP 1.2 + WS-Addressing) | `http://www.incasgroup.com/bologna/GdoWSCWCF` |
| TMSApiService | `/TMSApiService.svc` | basicHttpBinding, security None (SOAP 1.1) | `http://www.incasgroup.com/bologna/GdoApiService` |
| TMSServiceForMap | `/TMSServiceForMap.svc` | wsHttpBinding, security None, timeout 10 min | `http://www.incasgroup.com/bologna/TMSServiceForMap` |

- WSDL disponibile con `?wsdl`, come prima (`serviceMetadata httpGetEnabled="true"`).
- La manutenzione periodica che girava in `Global.asax` (ogni 60 s, per i tre servizi)
  è ora `BackgroundMaintenanceService`; gli errori finiscono nel log invece di essere ignorati.
- Gli attributi `[ServiceContract]`/`[ServiceBehavior]` che il decompilatore non aveva ricostruito
  sono stati recuperati dall'IL originale (namespace, SessionMode, InstanceContextMode).
- Il servizio ASMX `GdoWSC.asmx` è nella fase 3b (sotto).

### Configurazione (`GdoWSC.Host/appsettings.json`, sezione `GdoWSC`)
- `ApplicationRoot`: cartella con `IniConfig\` e `Log\` (vuoto = cartella del sito).
- `TMSServiceForWMSPath`, `TMSApiServicePath`, `TMSServiceForMapPath`: indirizzi dei servizi.
- `WcfClientConfigFile`: file con la sezione `<system.serviceModel>` del **vecchio Web.config**
  (indirizzi di WMS e PTV). Default `IniConfig\WcfClients.config`.

### Installazione su IIS (Windows Server)
1. Installare l'**ASP.NET Core 8 Hosting Bundle** sul server.
2. `dotnet publish GdoWSC.Host -c Release -o <cartella>`.
3. In IIS: nuovo sito/applicazione sulla cartella; **Application Pool con ".NET CLR version = No Managed Code"**.
4. Copiare in `<cartella>` le cartelle `IniConfig\` (DBConfig.ini, WSCConfig.ini, ecc.) e `Log\`
   del sito attuale; copiare il vecchio Web.config come `IniConfig\WcfClients.config`.
5. Verificare `http://server/.../TMSServiceForWMS.svc?wsdl` e confrontarlo con quello del sito attuale.
- Test: 35 (le chiamate SOAP reali ai tre servizi avviano il vero host su Kestrel).

## Fase 3b – GdoWSC.asmx (login del portale) su .NET 8

`GdoWSC.Host` espone anche **`/GdoWSC.asmx`**, eseguendo **il codice originale** del servizio
(`Incasbo.Web.WSC.GdoWSC`: LogIn, LogOut, isAuthenticate, GetDateTime, TestDBConnection, GetVersion, TestPing).

- **Protocollo come ASMX**: SOAP 1.1 e SOAP 1.2 document/literal, `SOAPAction = http://www.incasgroup.com/bologna/GdoWSC/<metodo>`,
  parametri `ref` restituiti nella risposta, errori come SOAP fault, WSDL con `?WSDL`.
- **Sessione** come `<sessionState mode="InProc" timeout="10">`: cookie `ASP.NET_SessionId`, dati in memoria,
  `WSC_SessionEnvironment` creato all'inizio (Session_Start) e distrutto alla scadenza (Session_End),
  **richieste della stessa sessione eseguite una alla volta** come in ASP.NET.
- **Login** come `<forms name="GdoWSC" timeout="10">`: cookie `GdoWSC` cifrato e firmato (ASP.NET Core Data Protection),
  rinnovo automatico a metà durata.
- Il codice originale compila su .NET 8 grazie a `Incasbo.Web.Compat` (sostituti minimi di `WebService`, `Session`,
  `FormsAuthentication`, `HttpContext.Current`): nessuna riscrittura della logica di login.
- Configurazione in `appsettings.json`, sezione `GdoWSC:Asmx`.

**Da sapere al passaggio in produzione**
- I cookie emessi dal vecchio sito non sono validi sul nuovo: gli utenti collegati dovranno **rifare il login una volta**.
- Con più server (web farm) o riavvii: le sessioni sono in memoria come prima (InProc); per condividere il cookie di login
  tra più server va configurata una cartella comune per le chiavi di Data Protection.

Test: 48 (login/logout, cookie manomesso, sessione, parametri ref, fault, richieste concorrenti, chiamate reali al vero host).

## Portale (DelsyManager92) nel repository

- `Portale/Web`: contenuto del sito (pagine `.aspx`/`.ascx`, script, stili, immagini, report `.rpt`).
  **Esclusi**: `bin`, `Log`, `Download`, `aspnet_client` (runtime Crystal), `wfi.db`, tutti i `.ini`.
  I `.ini` sono sostituiti da modelli `*.ini.esempio` **senza password** (`Portale/Web/IniConfig`,
  `Portale/Web/WFI/IniConfig`, `GdoWSC.Host/IniConfig`).
- `Portale/GDO`: codice delle pagine ricostruito da `GDO.dll` (.NET Framework 4.8; WebForms non esiste su .NET 8).
  Verificato: **API pubblica identica all'originale** (34.431 tipi/metodi confrontati) e tutte le 227 pagine
  trovano la propria classe (tranne `WFI/Form/WFStandardPrint.aspx`, la cui classe mancava già nella DLL originale).
- `lib/Portale`: librerie di terze parti (Telerik, AjaxControlToolkit, SharpZipLib, iTextSharp) e componenti web
  interni già compilati (IboWebComponents, IboGridView, IboPDF, ContextMenu, IboColorPicker, GridViewResizeExtender).
- **Crystal Reports**: per una build installabile copiare in `lib/Crystal` le DLL reali (13.0.2000.0) dalla GAC di un
  server con il runtime Crystal:
  `CrystalDecisions.CrystalReports.Engine`, `.Shared`, `.Web`, `.ReportSource`.
  Senza di esse si compila con `CrystalStubs` (solo verifica: la build avvisa e la DLL **non** va installata).

Correzioni al codice decompilato (solo differenze VB → C#, nessun cambio di logica): proprietà VB con parametri
convertite in metodi `get_X/set_X`, indicizzatori, costruttori che chiamavano `MyBase.New` dopo altro codice
(`Incasbo.Compat.RefBox`), nomi ambigui (`Image`, `FirstDayOfWeek`, `Table`), proprietà passate `ByRef`.

## Sicurezza 2 – Utenti tecnici senza password fissa

Prima i servizi GdoWSC accettavano da **chiunque** gli utenti `EU_INCAS`, `ES`, `ENGINE` con una password
scritta nel codice (la stessa usata come chiave di cifratura delle password utenti).

- **Chiamate interne** (il servizio che fa login da solo, la manutenzione): usano un segreto casuale
  generato all'avvio (`TechnicalUsers.InternalPassword`), che non esce mai dal processo.
- **Chiamate esterne** con un utente tecnico (il WMS con `ES`): accettate **solo** se l'utente è configurato in
  `IniConfig\UtentiTecnici.ini` con l'**hash** della password (PBKDF2-SHA256, 600.000 iterazioni).
  Utente non configurato = rifiutato. Modello: `GdoWSC.Host/IniConfig/UtentiTecnici.ini.esempio`.
- Strumento `Strumenti/DelsyPassword`: `DelsyPassword genera` crea una password robusta e il suo hash;
  `DelsyPassword hash` calcola l'hash di una password scelta.

**Passaggio in produzione (coordinare con il WMS)**
1. `DelsyPassword genera` → si ottengono password e `PasswordHash=...`.
2. Inserire `PasswordHash` nella sezione `[ES]` di `IniConfig\UtentiTecnici.ini` di GdoWSC.
3. Configurare la nuova password nel WMS (credenziali `Sender` verso TMSServiceForWMS).
Finché il WMS invia la vecchia password, le sue chiamate che richiedono credenziali vengono rifiutate.

## Sicurezza 3 – Password utenti con hash

Prima le password in `WFI_UTENTI.PASSWORD` erano **cifrate in modo reversibile** con una chiave fissa
(o in chiaro con `CryptographyEnable=False`): chi leggeva il database o la DLL poteva recuperarle tutte.

- Ora si salva l'**hash PBKDF2-SHA256** (`Incasbo.Security.UserPasswords`), non reversibile.
- **Conversione automatica al primo accesso**: al login (portale, GdoWSC.asmx, servizi WCF) una password nel
  vecchio formato viene verificata e riscritta come hash. Nessun utente deve cambiare password.
- **Conversione di tutte le password subito**: `DelsyPassword migra-utenti --connessione "..." [--esegui]`
  (senza `--esegui` è una prova che mostra solo i numeri).
- Cambio password e creazione utenti salvano direttamente l'hash.
- Rimossa la parola magica `__DO_NOT_VERIFY__`: con `CryptographyEnable=False` permetteva di entrare con
  qualsiasi utente digitandola come password. Ora gli utenti "ricordati" usano un token casuale di processo.
- **Utente di servizio**: le chiamate dal portale a GdoWSC (calcolo km/tempi, PCS più lontano) non usano più
  la password decifrata dell'utente collegato ma un utente di servizio, sezione `[ServizioGdoWSC]` di
  `WFIConfig.ini` del portale; in GdoWSC lo stesso utente va in `IniConfig\UtentiTecnici.ini` (solo hash,
  nessuna scadenza password).
- Corretti due difetti originali del cambio password: il controllo "nuova uguale alla vecchia" non funzionava
  con la cifratura attiva; il ricontrollo dopo il cambio usava il valore salvato invece della password.

**Ordine di installazione**
1. `Database/2026-11_01_password_hash.sql` (allarga `PASSWORD` da 30 a 128 caratteri).
2. Nuova versione di portale e GdoWSC; configurare `[ServizioGdoWSC]` e `[SVC_PORTALE]`.
3. (Facoltativo, consigliato) `DelsyPassword migra-utenti ... --esegui` per convertire tutti subito.
Dopo la conversione completa, le password non sono più recuperabili: un utente che la dimentica va reimpostato.

## Sicurezza 4 – SQL dal browser, autologin con token, redirect, XSS, file di configurazione

- **SQL eseguito su richiesta del browser (critico)**: i tooltip AJAX delle griglie mettevano nella pagina la
  query SQL cifrata con la chiave fissa; `getWFIAjaxTooltipContent` la decifrava ed eseguiva qualsiasi testo con
  "SELECT ". Con la chiave nota, ogni utente collegato poteva eseguire SQL arbitrario. Ora la query resta in
  sessione sul server (`TooltipQueryStore`) e la pagina riceve solo un identificativo casuale.
- **Autologin con token**: `WFIAutoLogin.aspx?t=TOKEN` al posto di `?u=UTENTE&p=PASSWORD`.
  Token casuali (256 bit), nel database solo l'hash (`WFI_AUTOLOGIN_TOKEN`), revocabili, con scadenza facoltativa,
  registrazione di ultimo uso e IP. La vecchia modalità è disattivata (`[AutoLogin] ConsentiPasswordInUrl=False`).
  Gestione: `DelsyPassword autologin-crea | autologin-elenca | autologin-revoca`.
- **Reindirizzamenti**: il parametro `r` dell'autologin accetta solo pagine interne (`SafeRedirect`).
- **XSS**: il messaggio d'errore dell'autologin è codificato prima di essere inserito nella pagina.
- **File di configurazione**: i parametri `CF` e `DBCFG` dell'indirizzo accettano solo nomi semplici
  (prima `..\..\` permetteva di far caricare altri file `.ini` del server).

**Installazione**
1. `Database/2026-11_02_autologin_token.sql`.
2. Per ogni totem: `DelsyPassword autologin-crea --connessione "..." --utente TOTEM --descrizione "Totem 1" --url http://server/WFI/Form/WFIAutoLogin.aspx`
   e aggiornare l'indirizzo nella pagina del totem (`Autologin.htm`, `Autologin2.htm`).

## Listini – modulo web per listini vettori e costi viaggio (`Listini/`)

Nuova applicazione .NET 8 (Blazor) che lavora sullo **stesso database** e usa lo **stesso motore tariffe** di Delsy
(`GdoApi`, `Incasbo.Api.Gdo.Tariffe`): i costi che mostra sono quelli che calcolerebbe Delsy.

- `Delsy.Listini.Core` – logica senza interfaccia:
  - `Motore/MotoreTariffe` apre il contesto applicativo Delsy (connessione, parametri, log) per eseguire il motore;
  - `Spiegazione/ServizioSpiegazione` – «Perché questo costo?»: per un viaggio (e per le spedizioni che passano da un
    corrispondente/Transit Point) mostra dati usati, contratto scelto e perché, tariffa applicata criterio per criterio
    oppure, se non ne trova, le tariffe più vicine e il criterio che non torna. Gli importi vengono dal motore in
    **simulazione**: non viene salvato nulla;
  - `Listini/ServizioListini` – contratti passivi, testate, voci e fasce in vigore;
  - `Registro/RegistroListini` – registro modifiche (`TAR_Registro`), solo inserimento;
  - `Accesso/ServizioAccesso` – accesso con gli utenti del portale (`WFI_UTENTI`), stesse regole password (hash, conversione al primo accesso).
- `Delsy.Listini.Web` – interfaccia: accesso, *Listini vettori*, dettaglio contratto, *Perché questo costo?*, *Registro modifiche*.

Database: eseguire `Database/2026-11_03_listini_bozze_registro.sql` (tabelle `TAR_Bozze`, `TAR_BozzeRighe`, `TAR_Registro`;
il registro rifiuta modifiche e cancellazioni). Ripetibile.

Configurazione (`appsettings.json`): la stringa di connessione **non** va nel repository; impostarla in
`appsettings.Production.json` sul server, oppure con la variabile d'ambiente `ConnectionStrings__Delsy`.
`Listini:CryptographyEnable` deve avere lo stesso valore di `LoginManager/CryptographyEnable` del portale.
Su IIS si pubblica come GdoWSC.Host (ASP.NET Core Module, pool senza codice gestito).

Prova in locale con il database di prova (`Tests/DatabaseDiProva`, vedi sotto):

```
cd Listini/Delsy.Listini.Web
ConnectionStrings__Delsy="Server=localhost,14330;Database=DELSYLOG91_LUCART;User ID=sa;Password=Delsy!Prova2026;TrustServerCertificate=True" dotnet run
```

### Database di prova

`python3 Tests/DatabaseDiProva/prepara_database.py` crea in Docker un SQL Server con lo schema Delsy e dati di esempio
(contratti BENNATO e TROSSI, costo zero via Transit Point TPBELLUNO). I test di integrazione si attivano con la
variabile `DELSY_TEST_DB` (stessa stringa di connessione); senza, vengono saltati.
