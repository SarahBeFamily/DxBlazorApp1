using Microsoft.AspNetCore.Components;

/// <summary>
/// Layout a Colonne (max 5 colonne)
/// </summary>

namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysLayoutColumns
    {
        [Parameter] public string? Subtitle { get; set; }
        [Parameter] public string? CssClass { get; set; }
        [Parameter] public RenderFragment? ChildContent { get; set; }
    }
}