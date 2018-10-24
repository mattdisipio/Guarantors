using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Guarantors
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();

            Console.ReadLine();
           
        }

        private static async void DoWork()
        {
            var client = new HttpClient();


            var json = "{\"numbers\":[3,2,1]}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await client.PostAsync("https://research.theguarantors.com/qa-test/ ", content);

            var responseString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseString);
        }
    }
}
