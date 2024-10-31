using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace DxBlazorApp1.Components.Pages
{

    public partial class PFURegistrationContact
    {


        [Inject] public NavigationManager NavigationManager { get; set; } = default!;

        protected RegistrationDto UserRegistration { get; set; } = new();

        protected EditContext? EditContext;

        public List<string> ListLegalStructure = new();

        public List<string> ListProvince = new();
        public IEnumerable<string> AtecoCodes = [];

        public bool VisStep1 { get; set; } = true;

        public bool VisStep2 { get; set; } = true;

        public bool VisStep3 { get; set; } = true;




        protected override void OnInitialized()
        {
            LoadBasicData();
        }



        private void LoadBasicData()
        {
            ListProvince = ["Padova", "Venezia"];
            ListLegalStructure = ["SRL", "SPA"];
            AtecoCodes = ["123", "ADF"];
        }



    }
}
