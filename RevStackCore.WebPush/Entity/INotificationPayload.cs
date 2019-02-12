using System;
namespace RevStackCore.WebPush
{
    public interface INotificationPayload
    {
        string Body { get; set; }
        string Title { get; set; }
        string Icon { get; set; }
        string ClickAction { get; set; }
        string Sound { get; set; }

    }
}
