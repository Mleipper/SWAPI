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

            var vehiclesList = vehicles.GetVehicleModels();

            Console.WriteLine(vehiclesList);

            await vehicles.SaveAllVehicles(vehiclesList);

            Console.ReadKey();
        }
    }
}
