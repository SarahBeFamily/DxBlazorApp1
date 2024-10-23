using DevExpress.Blazor;
using DxBlazorApp1.Components.Elements;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;

namespace DxBlazorApp1.Components.Pages
{
    public partial class UploadFir
    {
        [Inject] private IJSRuntime JS { get; set; }

        [Parameter][EditorRequired] public Guid ViaggioDettaglioId { get; set; }
        [Parameter][EditorRequired] public Guid ViaggioId { get; set; }
        [Parameter] public EventCallback Saved { get; set; }

        protected List<ToolbarItem> ToolbarEditItems = new();

        private bool UploadVisible = false;
        private ViewModel Model { get; set; } = new();


        bool PanelLoadVisible { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetRecords();
            BuildToolbar();
        }

        private void BuildToolbar()
        {
            ToolbarEditItems.Add(ToolbarItemHelper.SaveButton());
            ToolbarEditItems.Add(new ToolbarItem()
            {
                Key = "analyze",
                Alignment = ToolbarItemAlignment.Right,
                SubmitForm = false,
                Text = "Analizza AI"
            });
            ToolbarEditItems.Add(new ToolbarItem()
            {
                Key = "approva",
                Alignment = ToolbarItemAlignment.Right,
                SubmitForm = false,
                Text = "Approva"
            });

            ToolbarEditItems.Add(new ToolbarItem()
            {
                Key = "rifiuta",
                Alignment = ToolbarItemAlignment.Right,
                SubmitForm = false,
                Text = "Rifiuta"
            });

        }

        private async Task GetRecords()
        {

            //Model.QtaReal = viaggio.QtaReal;
            //Model.DriverName = viaggio.DriverName;
            //Model.TractorPlate = viaggio.TractorPlate;
            //Model.TrailerPlate = viaggio.TrailerPlate;
            //Model.NumeroDocumento = viaggio.NumeroDocumento;
            //Model.DataDocumento = viaggio.DocumentDate;
            //Model.DataInizioTrasporto = viaggio.StartMovementDate;
            //Model.DataFineTrasporto = viaggio.StopMovementDate;
            //Model.WasteDestinationId = viaggio.WasteDestinationId;
            //Model.NumeroColli = viaggio.NumberOfPackages;
            //Model.ContactLocationIdDestination = viaggio.ContactLocationIdDestination;
            //Model.ConveyorContactId = viaggio.ConveyorContactId;
            //Model.MotivazioneRifiuto = viaggio.MotivazioneRifiuto;

        }



        private async Task LoadTempFirDocument(string fileName)
        {
            //try
            //{
            //    var responseFile = await SdkClient.SendUploadRequestAsync(c => c.GetTempFileAsync(fileName));
            //    if (responseFile.IsSuccess)
            //    {
            //        Model.ActiveTabIndex = 0;
            //        StateHasChanged();
            //        using var streamRef = new DotNetStreamReference(stream: responseFile.Value.Stream);
            //        await JS.InvokeVoidAsync("createPdfObjectUrl", streamRef, "pdfIframe");
            //    }
            //}
            //finally
            //{
            //    PanelLoadVisible = false;
            //    StateHasChanged();
            //}
        }

        private async Task LoadTempRettificaFirDocument(string fileName)
        {
            //try
            //{
            //    var responseFile = await SdkClient.SendUploadRequestAsync(c => c.GetTempFileAsync(fileName));
            //    if (responseFile.IsSuccess)
            //    {
            //        Model.TabRettificaVisible = true;
            //        Model.ActiveTabIndex = 1;
            //        StateHasChanged();
            //        using var streamRef = new DotNetStreamReference(stream: responseFile.Value.Stream);
            //        await JS.InvokeVoidAsync("createPdfObjectUrl", streamRef, "rettificaFirFrame");
            //    }
            //}
            //finally
            //{
            //    PanelLoadVisible = false;
            //    StateHasChanged();
            //}
        }

        private async void OnFileUploadStart(FileUploadStartEventArgs args)
        {
            PanelLoadVisible = true;
            await JS.InvokeVoidAsync("HideUploadButtons");
        }

        protected async void OnFileUploaded(FileUploadEventArgs args)
        {
            //Model.FirAttachmentDto = new FirAttachmentDto()
            //{
            //    Description = "",
            //    FileName = args.FileInfo.Guid,
            //    OriginalFileName = args.FileInfo.Name,
            //    MovementsId = Model.Viaggio.MovementId,
            //};
            //Model.FileName = args.FileInfo.Name;
            //await LoadTempFirDocument(args.FileInfo.Guid);
        }

        protected async void OnRettificaFirFileUploaded(FileUploadEventArgs args)
        {
            //Model.RettificaFirAttachmentDto = new FirAttachmentDto()
            //{
            //    Description = "",
            //    FileName = args.FileInfo.Guid,
            //    OriginalFileName = args.FileInfo.Name,
            //    MovementsId = Model.Viaggio.MovementId,
            //};
            //Model.RettificaFirFileName = args.FileInfo.Name;
            //await LoadTempRettificaFirDocument(args.FileInfo.Guid);
        }

        private void OnFileUploadError(FileUploadErrorEventArgs obj)
        {
            //PanelLoadVisible = false;
            //var msg = new Message();
            //msg.SetAsError("Upload", obj.RequestInfo.Status.ToString(), obj.RequestInfo.ResponseText);
            //StateService.Notify(msg);
        }

        private async Task LoadFirDocument(Guid movementId, Guid attachmentId)
        {
            //var responseFile = await SdkClient.SendCommonRequestAsync(c => c.GetFirBytesAsync(attachmentId));
            //if (responseFile.IsSuccess)
            //{
            //    Model.ActiveTabIndex = 0;
            //    StateHasChanged();
            //    using var streamRef = new DotNetStreamReference(stream: responseFile.Value.Stream);
            //    await JS.InvokeVoidAsync("createPdfObjectUrl", streamRef, "pdfIframe");
            //}
        }

        private async Task LoadRettificaFirDocument(Guid movementId, Guid attachmentId)
        {
            //var responseFile = await SdkClient.SendCommonRequestAsync(c => c.GetFirBytesAsync(attachmentId));
            //if (responseFile.IsSuccess)
            //{
            //    Model.TabRettificaVisible = true;
            //    Model.ActiveTabIndex = 1;
            //    StateHasChanged();
            //    using var streamRef = new DotNetStreamReference(stream: responseFile.Value.Stream);
            //    await JS.InvokeVoidAsync("createPdfObjectUrl", streamRef, "rettificaFirFrame");
            //}
        }

        private async Task Save()
        {
            await Saved.InvokeAsync();
        }

        protected class ViewModel
        {
            public IEnumerable<string> MyLocations { get; set; } = [];
            public IEnumerable<string> MyConveyors { get; set; } = [];
            public IEnumerable<string> Motrici { get; set; } = [];
            public IEnumerable<string> Rimorchi { get; set; } = [];
            public IEnumerable<string> WasteDestinations { get; set; } = [];
            public bool PopupVisible { get; set; }

            [Range(1, double.PositiveInfinity)]
            public decimal QtaReal { get; set; }

            [Required]
            public string? FileName { get; set; }

            public string? RettificaFirFileName { get; set; }

            [StringLength(50)]
            public string? DriverName { get; set; }

            [Required]
            [StringLength(20)]
            public string? TractorPlate { get; set; }

            [StringLength(20)]
            public string? TrailerPlate { get; set; }

            [Required]
            public string? NumeroDocumento { get; set; }

            [Required]
            public DateTime? DataDocumento { get; set; }

            public DateTime? DataInizioTrasporto { get; set; }

            [Required]
            public DateTime? DataFineTrasporto { get; set; }

            [Required]
            public Guid? WasteDestinationId { get; set; }

            public int NumeroColli { get; set; }

            [Required]
            public Guid? ContactLocationIdDestination { get; set; }

            [Required]
            public Guid? ConveyorContactId { get; set; }




            public string Produttore
            {
                get => $"Ragione Sociale, Via roma 234, Padova";
                set {/* ignorato bind*/ }
            }
            public string? MotivazioneRifiuto { get; set; }
            public string? MediatorCompanyName { get; set; }
            public string? ArticleDescription { get; set; }
            public decimal QtaPlanned { get; set; } = 6520;




            public int ActiveTabIndex { get; set; } = 0;
            public bool TabRettificaVisible { get; set; }
            public Guid MovementId { get; set; }
            public bool ShowFirViewer { get; set; }
        }
    }
}

