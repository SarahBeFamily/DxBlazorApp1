using Microsoft.AspNetCore.Components;

namespace DxBlazorApp1.Components.Elements
{
	public partial class ISysBtn
	{
		[Parameter] public string Text { get; set; }
		[Parameter] public string CssClass { get; set; }
		[Parameter] public string RenderStyle { get; set; }
		[Parameter] public EventCallback OnClick { get; set; }
	}
}