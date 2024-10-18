using DevExpress.Blazor;

namespace DxBlazorApp1.Components.Elements
{
    public class ToolbarItem
    {
        /// <summary>
        /// Icona del bottone nella sintassi oi oi-circle-check
        /// </summary>
        public string Icon { get; set; } = string.Empty;

        /// <summary>
        /// Allineamento del bottone
        /// </summary>
        public ToolbarItemAlignment Alignment { get; set; }

        /// <summary>
        /// Chiave restituita all'evento di click
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// Invio automatico del form alla pressione del tasto Invio
        /// </summary>
        public bool SubmitForm { get; set; }

        /// <summary>
        /// Testo localizzato in alternativa all'icona
        /// </summary>
        public string? Text { get; set; }
    }
}
