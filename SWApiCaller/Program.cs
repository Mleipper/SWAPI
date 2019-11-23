using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = "https://swapi.co/api/starships/13/";

            var jSONGetter = new JSONGetter();

            var result = jSONGetter.MakeRequest(endpoint);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
