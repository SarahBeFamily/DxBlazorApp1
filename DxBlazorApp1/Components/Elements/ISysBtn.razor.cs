using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DxBlazorApp1.Components.Elements
{
	public partial class ISysBtn
	{
		[Parameter] public string? Text { get; set; }
		[Parameter] public string? CssClass { get; set; }
        [Parameter] public string? Icon { get; set; }
		[Parameter] public bool Flyout { get; set; } = false;
		[Parameter] public required string RenderStyle { get; set; }
		[Parameter] public EventCallback OnClick { get; set; }

    }
}