using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeAndRonConversationAPI
{
    public class Quotes
    {
        public Quotes()
        {

        }

        private HttpClient _client;

        public Quotes(HttpClient client)
        {
            _client = client;
        }

        public string Kanye()
        {
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string Ron()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }
    }
}
