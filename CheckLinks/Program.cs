using System;
using System.Linq;
using System.Net.Http;

namespace CheckLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            var site = "https://github.com/g0t4/pluralsight-dotnet-core-xplat-apps";
            var client = new HttpClient();
            var body = client.GetStringAsync(site);
            Console.WriteLine(body.Result);

            Console.WriteLine();
            Console.WriteLine("Links");
            var links = LinkChecker.GetLinks(body.Result);
            links.ToList().ForEach(Console.WriteLine);
        }
    }
}
