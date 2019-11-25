using System;
using SWApiCaller.Data;

namespace SWApiCaller
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var vehicles = new VehiclesAPI();

            //var Nullvehicle = vehicles.GetSingleModelByInt(3);
            var singleVehicle = vehicles.GetSingleModelByInt(4);

            //var vehiclesList = vehicles.GetModels();

            Console.WriteLine(singleVehicle.Url);
            //Console.WriteLine(Nullvehicle);

             //await vehicles.SaveAllModels(vehiclesList);

            Console.ReadKey();
        }
    }
}
