﻿namespace DxBlazorApp1.Services
{
    public static class MenuItems
    {
        private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
        {
            List<MenuItemGroup> groups = [
                new MenuItemGroup("Dashboard", "icon-nav icon-dashboard", "images/Home.svg", "dashboard"),
                new MenuItemGroup("ShowCase", "icon-nav icon-dashboard", "images/Home.svg", "showcase"),
                new MenuItemGroup("Logistica", "icon-nav icon-logistica", "images/Logistica.svg", "#",
                     [
                        new("Richiesta ritiro", "", "", "richiesta-ritiro"),
                        new("Richieste di trattamento", "", "", "#"),
                        new("Archivio richieste", "", "", "archivio-richieste"),
                     ]),
                new MenuItemGroup("Documenti", "icon-nav icon-doc", "images/Documenti.svg", "#",
                     [
                        new("Documenti generali", "", "", "#"),
                        new("Archivio FIR", "", "", "archivio-fir"),
                     ]),

            ];
            return groups;
        });
        public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
    }
}