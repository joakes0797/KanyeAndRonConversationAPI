using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading;

namespace KanyeAndRonConversationAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kanyeURL = "https://api.kanye.rest";
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var ronResponse = client.GetStringAsync(ronURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            //Console.WriteLine(ronQuote);

            Console.WriteLine("Kanye West and Ron Swanson walk into a bar...");
            Thread.Sleep(3000);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye says:  {kanyeQuote}");
                Thread.Sleep(3000);

                Console.WriteLine($"Then Ron says:  {ronQuote}");
                Thread.Sleep(3000);
            }
            Console.WriteLine("----------");
        }
    }
}
