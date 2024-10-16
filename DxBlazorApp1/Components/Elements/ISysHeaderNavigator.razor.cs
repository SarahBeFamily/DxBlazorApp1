using Microsoft.AspNetCore.Components;

namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysHeaderNavigator
    {
        [Parameter] public RenderFragment Tabs { get; set; }
        [Parameter] public RenderFragment Filters { get; set; }
        [Parameter] public RenderFragment Content { get; set; }

        [Parameter] public bool ShowFilterRow { get; set; }
        [Parameter] public EventCallback<bool> ShowFilterRowChanged { get; set; }
        [Parameter] public string? SearchText { get; set; }
        [Parameter] public EventCallback<string?> SearchTextChanged { get; set; }

        protected ViewModel Model = new();

        private void ToggleFilter()
        {
            Model.ShowFilterRow = !Model.ShowFilterRow;
            ShowFilterRowChanged.InvokeAsync(Model.ShowFilterRow);
        }

        private void OnSearchTextChange(string? e)
        {
            Model.SearchText = e;
            SearchTextChanged.InvokeAsync(e);
        }

        protected class ViewModel
        {
            public bool ShowFilterRow { get; set; }
            public string? SearchText { get; set; }
        }
    }
}
