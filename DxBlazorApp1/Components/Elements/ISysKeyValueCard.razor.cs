using Microsoft.AspNetCore.Components;

namespace DxBlazorApp1.Components.Elements
{

    /// <summary>
    /// Card orizzontale che visualizza coppia di valori affiancati, con l'ultimo valore separato da barra verticale
    /// </summary>
    public partial class ISysKeyValueCard
    {
        [Parameter] public IEnumerable<KeyValuePair<string, string>> Valori { get; set; } = [];

    }
}
