using DevExpress.Blazor;

namespace DxBlazorApp1.Components.Pages
{
    public partial class Showcase
    {
        public bool isXSmallScreen { get; set; }
        bool PopupVisible { get; set; } = false;
        string? SearchText { get; set; }

        public IEnumerable<FIR> FIRs { get; set; }
        IGrid GridFir;
        void OpenPopup()
        {
            PopupVisible = true;
        }

        protected override void OnInitialized() => FIRs = new List<FIR>
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

        public class FIR
        {
            public string Ticket { get; set; }
            public DateTime DataRichiesta { get; set; }
            public DateTime DataRitiro { get; set; }
            public int Qty { get; set; }
            public string Indirizzo { get; set; }
            public string Trasportatore { get; set; }
        }
    }
}
