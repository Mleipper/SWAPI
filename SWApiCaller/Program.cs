using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {


            var vehicles = new vehiclesAPI();



            var result = vehicles.GetEntityByInt(30);

            Console.WriteLine(result);

            Console.WriteLine("This is the Second lot of Data");

            var result2 = vehicles.GetAllEntities();

            Console.WriteLine(result2);


            Console.ReadKey();
        }
    }
}
