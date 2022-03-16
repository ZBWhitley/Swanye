using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Swanye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGen(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("So Yeezy was all like");
                Console.WriteLine($"Yeezy: {quote.Kanye()}");
                Console.WriteLine("and then RonSon was all like");
                Console.WriteLine($"RonSon: {quote.RonSwanson()}");

            }
        }
    }
}
