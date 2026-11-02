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
