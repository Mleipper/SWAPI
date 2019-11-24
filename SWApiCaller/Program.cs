using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var vehicles = new vehiclesAPI();

            //var result2 = vehicles.GetSingleVehicleByInt(4);

            var results2 = vehicles.GetVehicleModels();

            Console.WriteLine(results2);

            await vehicles.SaveAllVehicles(results2);

            Console.ReadKey();
        }
    }
}
