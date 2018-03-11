using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CoreTweet;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TwiHigh
{
    public partial class OAuth
    {
        public static async Task<OAuthData> JsonReadAsync(string path)
        {
            var assembly = typeof(JsonIO).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(path);

            OAuthData res;

            using (var reader = new StreamReader(stream))
            {
                var json = await reader.ReadToEndAsync();
                res = JsonConvert.DeserializeObject<OAuthData>(json);
            }

            return res;
        }

        public static async Task<Tokens> Authentication()
        {
            var Data = await JsonReadAsync("TwiHigh.AppsSetting,json");

            return Tokens.Create(Data.ConsumerKey, Data.ConsumerSecret, Data.AccessToken, Data.AccessTokenSecret);
        }

        public static async Task<string> ShowLoginUserNameAsync()
        {
            var User = await Authentication();

            return User.ScreenName;
        }
    }


    public class OAuthData
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }
        public string CallbackURL { get; set; }
    }
}
