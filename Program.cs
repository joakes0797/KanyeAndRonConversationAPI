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
            var client = new HttpClient();
            var quote = new Quotes(client);

            Console.WriteLine("Kanye West and Ron Swanson walk into a bar...");
            Console.WriteLine();
            Thread.Sleep(2000);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye says:  \"{quote.Kanye()}\"");
                Console.WriteLine();
                Thread.Sleep(4000);

                Console.WriteLine($"Then Ron says:  {quote.Ron()}");
                Console.WriteLine();
                Thread.Sleep(4000);
            }

            Console.WriteLine();
            Console.WriteLine("                     ...yeesh.");
            Thread.Sleep(2000);
        }
    }
}
