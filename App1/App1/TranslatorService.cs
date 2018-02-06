using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using App1.Model;

namespace App1
{
    class TranslatorService
    {
        private readonly Uri _dataMarketUri = new Uri("https://datamarket.accesscontrol.windows.net/v2/OAuth2-13");

        private readonly HttpClient _client = new HttpClient();


        static string host = "https://api.microsofttranslator.com";
        static string path = "/V2/Http.svc/Translate";

        // NOTE: Replace your Azore key with a valid subscription key.
        static string key = "xxxxxxxxxxxxxxxxxxxx";

        public async Task<string> TranslateString(string strSource, string language)
        {
            String result;
            var content = "";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);

            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string> (strSource, language)

            };

            foreach (KeyValuePair<string, string> i in list)
            {
                string uri = host + path + "?to=" + i.Value + "&text=" + System.Net.WebUtility.UrlEncode(i.Key);

                HttpResponseMessage response = await client.GetAsync(uri);

                result = await response.Content.ReadAsStringAsync();
                // NOTE: A successful response is returned in XML. You can extract the contents of the XML as follows.
                content = XElement.Parse(result).Value;

            }

            return content;
        }
    }
}
