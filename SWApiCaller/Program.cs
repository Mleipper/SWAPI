using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {


            var people = new PeopleAPI();



            var result = people.GetEntityByInt(1);

            Console.WriteLine(result);

            Console.WriteLine("This is the Second lot of Data");

            var result2 = people.GetAllEntities();

            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }
}
