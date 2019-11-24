using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var vehicles = new vehiclesAPI();

            var Nullvehicle = vehicles.GetSingleVehicleByInt(3);

            //var vehiclesList = vehicles.GetVehicleModels();

            //Console.WriteLine(vehiclesList);
            Console.WriteLine(Nullvehicle);

           // await vehicles.SaveAllVehicles(vehiclesList);

            Console.ReadKey();
        }
    }
}
