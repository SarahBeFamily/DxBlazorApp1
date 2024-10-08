using DevExpress.Blazor;

namespace DxBlazorApp1.Components.Pages
{
    public partial class Showcase
    {
        bool isXSmallScreen { get; set; }
        bool PopupVisible { get; set; } = false;
        string? SearchText { get; set; }
        DateTime DateTimeValue { get; set; } = DateTime.Now;
        string? Ticket { get; set; }
        private decimal Quantita { get; set; }
        bool Selezionato { get; set; }

        IEnumerable<FIR> FIRs { get; set; }
        IEnumerable<Location> Locations { get; set; }
        Location Trasportatore { get; set; }
        IGrid GridFir;

        void OpenPopup()
        {
            PopupVisible = true;
        }

        protected override void OnInitialized()
        {
            BuildFir();
            BuildLocation();
        }

        private void BuildFir()
        {
            FIRs = new List<FIR>
            {
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                }
            };
        }

        private void BuildLocation()
        {
            Locations = new List<Location>()
            {
                new Location() { RagioneSociale = "Bartolini", Citta = "Bergamo", Indirizzo = "Via Ugo Foscolo 4" },
                new Location() { RagioneSociale = "SDA", Citta = "Padova", Indirizzo = "Via Aprilia 4" },
                new Location() { RagioneSociale = "DHL", Citta = "Torino", Indirizzo = "Via Galvani 456" }
            };
        }

        public class FIR
        {
            public string Ticket { get; set; }
            public DateTime DataRichiesta { get; set; }
            public DateTime DataRitiro { get; set; }
            public int Qty { get; set; }
            public string Indirizzo { get; set; }
            public string Trasportatore { get; set; }
        }

        public class Location
        {
            public string RagioneSociale { get; set; }
            public string Indirizzo { get; set; }
            public string Citta { get; set; }
        }
    }
}
