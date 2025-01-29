using Microsoft.AspNetCore.Components;



namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysBadge
    {
        [Parameter, EditorRequired] public string? Label { get; set; } = "";
        [Parameter] public string? Color { get; set; } = Gray;


        public static string Gray = "gray";
        public static string Green = "green";
        public static string Red = "red";
        public static string Yellow = "yellow";
        public static string Orange = "orange";
        public static string Black = "black";
        public static string White = "white";
    }
}