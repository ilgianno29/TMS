using System.Runtime.CompilerServices;

// L'host .NET 8 esegue la manutenzione periodica (IncasWCFInternal), come faceva Global.asax
[assembly: InternalsVisibleTo("GdoWSC.Host")]
[assembly: InternalsVisibleTo("Delsy.Tests")]
