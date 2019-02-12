using System;
using RevStackCore.Pattern;
using RevStackCore.Extensions.GeoLocation;

namespace RevStackCore.WebPush
{
	public class GeoSpatialPushSubscription : PushSubscription, IEntity<string>
	{
		public string Id { get; set; }
		public string AppId { get; set; }
		public string ApiKey { get; set; }
		public string TargetId { get; set; }
		public string Token { get; set; }
		public GeoCoordinate Coordinates { get; set; }
		public string IpAddress { get; set; }
		public string UserAgent { get; set; }
		public string UserIdentity { get; set; }
		public string EmailAddress { get; set; }
		public DeviceType? DeviceType { get; set; }
		public OsType? OsType { get; set; }
		public BrowserType? BrowserType { get; set; }
		public bool IsFirebase { get; set; }

		public GeoSpatialPushSubscription() : base()
		{
			Id = Guid.NewGuid().ToString();
		}

		public GeoSpatialPushSubscription(string id)
		{
			Id = id;
			Subscribed = true;
		}

		public GeoSpatialPushSubscription(string appId, string token)
		{
			Id = Guid.NewGuid().ToString();
			AppId = appId;
			Token = token;
			Subscribed = true;

		}


		public GeoSpatialPushSubscription(string endpoint, string p256dh, string auth) : base(endpoint, p256dh, auth) { }

	}

}
