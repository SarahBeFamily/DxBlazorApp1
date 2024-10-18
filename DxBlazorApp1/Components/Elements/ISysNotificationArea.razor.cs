using Microsoft.AspNetCore.Components;

namespace DxBlazorApp1.Components.Elements
{
    public partial class ISysNotificationArea
    {
        [Parameter] public bool IsNotificationsOpen { get; set; } = false;
        [Parameter] public EventCallback<bool> IsNotificationsChanged { get; set; }

        protected ViewModel Model = new();

        private void OpenNotifications()
        {
            Model.IsNotificationsOpen = !Model.IsNotificationsOpen;
            IsNotificationsChanged.InvokeAsync(Model.IsNotificationsOpen);
        }

        protected class ViewModel
        {
            public bool IsNotificationsOpen { get; set; }
        }
    }
}
