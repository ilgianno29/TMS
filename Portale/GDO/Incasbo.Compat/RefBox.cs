namespace Incasbo.Compat;

/// <summary>
/// Permette di passare per riferimento (ref) un valore calcolato, ad esempio
/// nell'inizializzatore di un costruttore (": base(ref RefBox.Of(x))").
/// Serve per i costruttori VB che preparavano gli argomenti prima di chiamare MyBase.New:
/// eventuali assegnazioni del costruttore chiamato finiscono nel contenitore, come
/// accadeva con la variabile locale del codice originale.
/// </summary>
internal static class RefBox
{
	public static ref T Of<T>(T value)
	{
		T[] box = new T[] { value };
		return ref box[0];
	}
}
