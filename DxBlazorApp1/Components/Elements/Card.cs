using DevExpress.Blazor.Internal;
using DevExpress.Emf;
using DxBlazorApp1.Components.Elements;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Html;
using System;

namespace DxBlazorApp1.Components.Elements;
public class Card
{
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? Text { get; set; }
    public string? MainData { get; set; }
    public string? Percentage { get; set; }
    public int? Year { get; set; }
    public string? AltText { get; set; }
    public string Classes { get; set; } = "";
    public string? Link { get; set; }
    public string? LinkText { get; set; }
    public RenderFragment? ChildContent { get; set; }

}