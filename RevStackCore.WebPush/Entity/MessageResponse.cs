using System;
using System.Collections.Generic;

namespace RevStackCore.Extensions.WebPush.Firebase
{
    public class MessageResponse
    {
        public float MultiCastId { get; set; }
        public int Success { get; set; }
        public int Failure { get; set; }
        public int CanonicalIds { get; set; }
        public IEnumerable<MessageResponseResult> Results { get; set; }
    }

    public class MessageResponseResult
    {
        public string MessageId { get; set; }
        public string RegistrationId { get; set; }
        public string Error { get; set; }
    }
}
