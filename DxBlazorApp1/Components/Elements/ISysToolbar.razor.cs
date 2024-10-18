using Microsoft.AspNetCore.Components;

namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysToolbar
    {

        /// <summary>
        /// Lista dei bottoni da mostrare
        /// </summary>
        [Parameter] public List<ToolbarItem> ToolbarItems { get; set; } = new();

        /// <summary>
        /// Notifica quando un bottone viene premuto
        /// </summary>
        [Parameter] public EventCallback<ToolbarItem> ItemClicked { get; set; }

        /// <summary>
        /// Indica se mostrare la casella di ricerca
        /// </summary>
        [Parameter] public bool ShowSearchBox { get; set; }

        /// <summary>
        /// Notifica la modifica del testo di ricerca
        /// </summary>
        [Parameter] public EventCallback<string> OnTextChanged { get; set; }

        /// <summary>
        /// Testo immesso nella casella di ricerca
        /// </summary>
        protected string? SearchText { get; set; }
    }
}
