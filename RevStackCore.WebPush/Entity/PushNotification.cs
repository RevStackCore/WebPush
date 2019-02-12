using System;
using System.Collections.Generic;

namespace RevStackCore.WebPush
{

	//Reference: https://firebase.google.com/docs/cloud-messaging/http-server-ref#table1
	public class PushNotitificationBase
    {
        private int _defaultTimeToLive = 604800; //7 days default
		public string To { get; set; }
		public IEnumerable<string> RegistrationIds { get; set; }
		public string Condition { get; set; }
		public string CollapseKey { get; set; }
		public string Priority { get; set; }
		public bool ContentAvailable { get; set; }
		public int TimeToLive { get; set; }
		public string RestrictedPackageName { get; set; }

        public PushNotitificationBase()
        {
            TimeToLive = _defaultTimeToLive;
            Priority = "high";
            ContentAvailable = true;
        }

        public PushNotitificationBase(string to)
        {
            To = to;
            TimeToLive = _defaultTimeToLive;
            Priority = "high";
            ContentAvailable = true;
        }

		public PushNotitificationBase(string to, int timeToLive)
		{
			To = to;
            TimeToLive = timeToLive;
            Priority = "high";
            ContentAvailable = true;
		}

		public PushNotitificationBase(string to, string priority)
		{
			To = to;
            TimeToLive = _defaultTimeToLive;
			ContentAvailable = true;
			Priority = priority;
		}

		public PushNotitificationBase(string to, int timeToLive, string priority)
		{
			To = to;
			TimeToLive = timeToLive;
            ContentAvailable = true;
			Priority = priority;
		}

		public PushNotitificationBase(string to, int timeToLive, bool contentAvailable)
		{
			To = to;
			TimeToLive = timeToLive;
            ContentAvailable = contentAvailable;
			Priority = "high";
		}

		public PushNotitificationBase(string to, int timeToLive, string priority, bool contentAvailable)
		{
			To = to;
			TimeToLive = timeToLive;
            ContentAvailable = contentAvailable;
			Priority = priority;
		}

		public PushNotitificationBase(string to, int timeToLive, string priority, bool contentAvailable, string condition, string collapseKey)
		{
			To = to;
			TimeToLive = timeToLive;
			ContentAvailable = contentAvailable;
			Priority = priority;
            Condition = condition;
            CollapseKey = collapseKey;
		}


        public PushNotitificationBase(IEnumerable<string> registrationIds)
        {
            RegistrationIds = registrationIds;
            TimeToLive = _defaultTimeToLive;
            Priority = "high";
            ContentAvailable = true;
        }

		public PushNotitificationBase(IEnumerable<string> registrationIds, int timeToLive)
		{
            RegistrationIds = registrationIds;
			TimeToLive = timeToLive;
			Priority = "high";
			ContentAvailable = true;
		}

		public PushNotitificationBase(IEnumerable<string> registrationIds, string priority)
		{
			RegistrationIds = registrationIds;
            TimeToLive = _defaultTimeToLive;
			Priority = priority;
			ContentAvailable = true;
		}

		public PushNotitificationBase(IEnumerable<string> registrationIds, int timeToLive, string priority)
		{
			RegistrationIds = registrationIds;
			TimeToLive = timeToLive;
            Priority = priority;
			ContentAvailable = true;
		}

		public PushNotitificationBase(IEnumerable<string> registrationIds, int timeToLive, bool contentAvailable)
		{
			RegistrationIds = registrationIds;
			TimeToLive = timeToLive;
			Priority = "high";
            ContentAvailable = contentAvailable;
		}

		public PushNotitificationBase(IEnumerable<string> registrationIds, int timeToLive,string priority, bool contentAvailable)
		{
			RegistrationIds = registrationIds;
			TimeToLive = timeToLive;
			Priority = priority;
			ContentAvailable = contentAvailable;
		}

		public PushNotitificationBase(IEnumerable<string> registrationIds, int timeToLive, string priority, bool contentAvailable,string condition, string collapseKey)
		{
			RegistrationIds = registrationIds;
			TimeToLive = timeToLive;
			Priority = priority;
			ContentAvailable = contentAvailable;
			Condition = condition;
			CollapseKey = collapseKey;
		}

    }

    public class PushNotification : PushNotitificationBase
    {
		public PushNotification() : base(){}

        public PushNotification(string to) : base(to){}

        public PushNotification(string to, int timeToLive) : base(to,timeToLive){}

        public PushNotification(string to, string priority) : base(to,priority){}

        public PushNotification(string to, int timeToLive, string priority) : base(to,timeToLive,priority){}

        public PushNotification(string to, int timeToLive, bool contentAvailable) : base(to,timeToLive,contentAvailable){}

        public PushNotification(string to, int timeToLive, string priority, bool contentAvailable) : base(to,timeToLive,priority,contentAvailable){}

        public PushNotification(string to, int timeToLive, string priority, bool contentAvailable, string condition, string collapseKey)
            :base(to,timeToLive,priority,contentAvailable,condition,collapseKey){}

        public PushNotification(IEnumerable<string> registrationIds) : base(registrationIds){}

        public PushNotification(IEnumerable<string> registrationIds, int timeToLive) : base(registrationIds,timeToLive){}

        public PushNotification(IEnumerable<string> registrationIds, string priority) : base(registrationIds,priority){}

        public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority) : base(registrationIds,timeToLive,priority){}

        public PushNotification(IEnumerable<string> registrationIds, int timeToLive, bool contentAvailable) : base(registrationIds,timeToLive,contentAvailable){}

        public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority, bool contentAvailable)
            :base(registrationIds,timeToLive,priority,contentAvailable){}

        public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority, bool contentAvailable, string condition, string collapseKey)
            :base(registrationIds,timeToLive,priority,contentAvailable,condition,collapseKey){}
        

        public NotificationPayload Notification { get; set; }

    }

    public class PushNotification<TEntity> : PushNotitificationBase where TEntity: class, INotificationPayload
    {
		public PushNotification() : base() { }

		public PushNotification(string to) : base(to) { }

		public PushNotification(string to, int timeToLive) : base(to, timeToLive) { }

		public PushNotification(string to, string priority) : base(to, priority) { }

		public PushNotification(string to, int timeToLive, string priority) : base(to, timeToLive, priority) { }

		public PushNotification(string to, int timeToLive, bool contentAvailable) : base(to, timeToLive, contentAvailable) { }

		public PushNotification(string to, int timeToLive, string priority, bool contentAvailable) : base(to, timeToLive, priority, contentAvailable) { }

		public PushNotification(string to, int timeToLive, string priority, bool contentAvailable, string condition, string collapseKey)
			: base(to, timeToLive, priority, contentAvailable, condition, collapseKey) { }

		public PushNotification(IEnumerable<string> registrationIds) : base(registrationIds) { }

		public PushNotification(IEnumerable<string> registrationIds, int timeToLive) : base(registrationIds, timeToLive) { }

		public PushNotification(IEnumerable<string> registrationIds, string priority) : base(registrationIds, priority) { }

		public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority) : base(registrationIds, timeToLive, priority) { }

		public PushNotification(IEnumerable<string> registrationIds, int timeToLive, bool contentAvailable) : base(registrationIds, timeToLive, contentAvailable) { }

		public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority, bool contentAvailable)
			: base(registrationIds, timeToLive, priority, contentAvailable) { }

		public PushNotification(IEnumerable<string> registrationIds, int timeToLive, string priority, bool contentAvailable, string condition, string collapseKey)
			: base(registrationIds, timeToLive, priority, contentAvailable, condition, collapseKey) { }


        public TEntity Data { get; set; }

    }
}
