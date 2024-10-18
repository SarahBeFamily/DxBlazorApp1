using DevExpress.Blazor;

namespace DxBlazorApp1.Components.Elements
{
    /// <summary>
    /// Bottoni standard da aggiungere alla Toolbar
    /// </summary>
    public static class ToolbarItemHelper
    {
        public const string AddKey = "add";
        public const string SaveKey = "save";
        public const string BackKey = "back";
        public const string CloseKey = "close";
        public const string DeleteKey = "delete";
        public const string CsvKey = "csv";
        public const string XlsKey = "xls";


        public static ToolbarItem AddButton() => new()
        {
            Icon = "oi oi-plus",
            Alignment = ToolbarItemAlignment.Left,
            Key = AddKey,
        };

        public static ToolbarItem SaveButton() => new()
        {
            Icon = "oi oi-circle-check",
            Alignment = ToolbarItemAlignment.Right,
            Key = SaveKey,
            SubmitForm = true
        };

        public static ToolbarItem BackButton() => new()
        {
            Icon = "oi oi-action-undo",
            Alignment = ToolbarItemAlignment.Left,
            Key = BackKey,
        };

        public static ToolbarItem CloseButton() => new()
        {
            Icon = "oi oi-x",
            Alignment = ToolbarItemAlignment.Right,
            Key = CloseKey,
        };

        public static ToolbarItem DeleteButton() => new()
        {
            Icon = "oi oi-trash",
            Alignment = ToolbarItemAlignment.Right,
            Key = DeleteKey,
        };

        public static ToolbarItem ExpCsvButton() => new()
        {
            Icon = "oi oi-file",
            Alignment = ToolbarItemAlignment.Right,
            Key = CsvKey,
        };
        public static ToolbarItem ExpXlsButton() => new()
        {
            Icon = "oi oi-spreadsheet",
            Alignment = ToolbarItemAlignment.Right,
            Key = XlsKey,
        };

    }
}