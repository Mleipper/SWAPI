using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SWApiCaller.JSONModels;
using SWApiCaller.DBModels;
using System.Linq;

namespace SWApiCaller.Data
{
    public class VehiclesAPI : APICaller<JsonListModel<VehicleModel>, VehicleModel>
    {
        public VehiclesAPI() : base("vehicles/")
        {

        }
               
        protected override async Task SaveModel(VehicleModel vehicle)
        {
            await SaveVehicle(vehicle);
        }

        public async Task SaveVehicle(VehicleModel vehicle)
        {
            if (!string.IsNullOrEmpty(vehicle.Url))
            {
                if (_dbContext.vehicles.Any(V => V.Url == vehicle.Url)) return;
                Vehicle vehicle1 = new Vehicle()
                {
                    Cargo_capacity = vehicle.Cargo_capacity,
                    Consumables = vehicle.Consumables,
                    Cost_in_credits = vehicle.Cost_in_credits,
                    Vehicle_class = vehicle.Vehicle_class,
                    Created = vehicle.Created,
                    Crew = vehicle.Crew,
                    Edited = vehicle.Edited,
                    Length = vehicle.Length,
                    Manufacturer = vehicle.Manufacturer,
                    Max_atmosphering_speed = vehicle.Max_atmosphering_speed,
                    Model = vehicle.Model,
                    Name = vehicle.Name,
                    Passengers = vehicle.Passengers,
                    Url = vehicle.Url

                };

                await _dbContext.AddAsync(vehicle1);

                _dbContext.SaveChanges();

            }
        }

    }
}
