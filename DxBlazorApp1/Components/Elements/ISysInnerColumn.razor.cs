﻿using Microsoft.AspNetCore.Components;

/// <summary>
/// Colonna interna di un layout a colonne
/// Scegliere la larghezza della colonna da 1 a 5
/// </summary>

namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysInnerColumn
    {
        [Parameter] public string? CssClass { get; set; }
        [Parameter] public bool ColumnWidth1 { get; set; }
		[Parameter] public bool ColumnWidth2 { get; set; }
		[Parameter] public bool ColumnWidth3 { get; set; }
		[Parameter] public bool ColumnWidth4 { get; set; }
		[Parameter] public bool ColumnWidth5 { get; set; }
		[Parameter] public required RenderFragment ChildContent { get; set; }
    }
}