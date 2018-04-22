using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TwiHigh
{
    [DataContract]
    public class OAuthData
    {
        [DataMember(Name = "consumer_key")]
        public string ConsumerKey { get; set; }

        [DataMember(Name = "consumer_secret")]
        public string ConsumerSecret { get; set; }

        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "access_token_secret")]
        public string AccessTokenSecret { get; set; }

        [DataMember(Name = "callback_url")]
        public string CallbackURL { get; set; }
    }
}
