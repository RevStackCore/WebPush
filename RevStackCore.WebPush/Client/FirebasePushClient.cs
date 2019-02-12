using System;
using System.Threading.Tasks;
using RevStackCore.Extensions.Serialization.SnakeCase;
using RevStackCore.Net;

namespace RevStackCore.WebPush
{
    public class FirebasePushClientBase
    {
        private string _url = "https://fcm.googleapis.com/fcm/send";
        protected int OK = 200;
        public string ServerKey { get; set; }
		public string SenderId { get; set; }
		public string Url { get; set; }

		public FirebasePushClientBase()
		{
            Url = _url;
		}
		public FirebasePushClientBase(string serverKey, string senderId)
		{
            Url = _url;
            ServerKey =serverKey;
            SenderId = senderId;
		}

		public FirebasePushClientBase(string serverKey, string senderId, string url)
		{
			Url = url;
			ServerKey = serverKey;
			SenderId = senderId;
		}
    }

    public class FirebasePushClient : FirebasePushClientBase
    {
        public FirebasePushClient() : base(){}

        public FirebasePushClient(string serverKey, string senderId) : base(serverKey,senderId){}

        public FirebasePushClient(string serverKey, string senderId, string url) : base(serverKey,senderId,url){}

		/// <summary>
		/// Sends the push notification async.
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="notification">Notification.</param>
		public async Task<ResponseType<string>> SendAsync(PushNotification notification)
		{
            var json = Json.SerializeObject(notification);
			var client = new HttpClient(Url);
			client.Request.Headers["Authorization"] = "key=" + ServerKey;
			client.Request.Headers["Sender"] = "id=" + SenderId;
			var response = await client.SendAsync(json, HttpMethod.Post);
            return response;
		}
    }

    public class FirebasePushClient<TEntity> : FirebasePushClientBase where TEntity : class, INotificationPayload
    {
		public FirebasePushClient() : base() { }

		public FirebasePushClient(string serverKey, string senderId) : base(serverKey, senderId) { }

		public FirebasePushClient(string serverKey, string senderId, string url) : base(serverKey, senderId, url) { }
       

		/// <summary>
		/// Sends the generic push notification async.
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="entity">Entity</param>
        public async Task<ResponseType<string>> SendAsync(PushNotification<TEntity> entity)
		{
			var json = Json.SerializeObject(entity);
			var client = new HttpClient(Url);
			client.Request.Headers["Authorization"] = "key=" + ServerKey;
			client.Request.Headers["Sender"] = "id=" + SenderId;
			var response = await client.SendAsync(json, HttpMethod.Post);
            return response;
		}

    }
}
