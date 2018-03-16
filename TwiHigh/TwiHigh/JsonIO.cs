using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace TwiHigh
{
    public class JsonIO
    {
        public static async Task<OAuthData> JsonReadAsync(string path)
        {
            var assembly = typeof(JsonIO).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(path);

            if(stream == null)
            {
                Debug.Print("File not Found.");
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }

            OAuthData res;

            using (var reader = new StreamReader(stream))
            {
                var json = await reader.ReadToEndAsync();
                res = JsonConvert.DeserializeObject<OAuthData>(json);
            }

            return new OAuthData
            {
                ConsumerKey = res.ConsumerKey,
                ConsumerSecret = res.ConsumerSecret,
                AccessToken = res.AccessToken,
                AccessTokenSecret = res.AccessTokenSecret,
                CallbackURL = res.CallbackURL,
            };
        }
    }

    [DataContract]
    public struct OAuthData
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
