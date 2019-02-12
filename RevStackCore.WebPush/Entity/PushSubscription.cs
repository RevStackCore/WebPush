using System;

namespace RevStackCore.WebPush
{
	public class PushSubscription
	{
		public string Endpoint { get; set; }
		public string P256DH { get; set; }
		public string Auth { get; set; }
		public bool Subscribed { get; set; }
		public DateTime? DateSubscribed { get; set; }
		public DateTime? DateUnsubscribed { get; set; }

		public PushSubscription()
		{
			Subscribed = true;
		}

		public PushSubscription(string endpoint, string p256dh, string auth)
		{
			Endpoint = endpoint;
			P256DH = p256dh;
			Auth = auth;
			Subscribed = true;
		}
	}
}
