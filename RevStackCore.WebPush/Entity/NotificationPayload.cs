using System;

namespace RevStackCore.WebPush
{
    public class NotificationPayload : INotificationPayload
    {
		public string Body { get; set; }
		public string Title { get; set; }
		public string Icon { get; set; }
        public string ClickAction { get; set; }
        public string Sound { get; set; }

        public NotificationPayload()
        {
            Sound = "default";
        }
    }
}


