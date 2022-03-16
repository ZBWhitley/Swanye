using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Swanye
{
    internal class QuoteGen
    {
        private HttpClient _client;

        public QuoteGen(HttpClient client)
        {
            _client = client;
        }

        public string Kanye()
        {
            //API Url
            var yeezy = "https://api.kanye.rest";

            //Stores the JSON repsonse in a variable
            var yeezyResponse = _client.GetStringAsync(yeezy).Result;

            //Parses through the response we received to get the value associated with
            //the NAME "quote"
            var yeezyQuote = JObject.Parse(yeezyResponse).GetValue("quote").ToString();

            return yeezyQuote;
        }

        public string RonSwanson()
        {
            //Ron Swanson URL
            var ronSon = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronSonResponse = _client.GetStringAsync(ronSon).Result;
            var ronSonQuote = JArray.Parse(ronSonResponse);

            return ronSonQuote[0].ToString();
        }
    }
}
