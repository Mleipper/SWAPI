using System;
using System.Collections.Generic;
using System.Text;

namespace SWApiCaller.DBModels
{
    class VehicleTable
    {
        public class VehicleModel
        {
            public VehicleModel()
            {
                this.Pilots = new HashSet<Pilots>();
                this.Films = new HashSet<Films>();
            }
            
            public string Url { get; set; }

            public string Name { get; set; }

            public string Model { get; set; }

            public string Manufacturer { get; set; }

            public string Cost_in_credits { get; set; }

            public string Length { get; set; }

            public string Max_atmosphering_speed { get; set; }

            public string Crew { get; set; }

            public string Passengers { get; set; }

            public string Cargo_capacity { get; set; }

            public string Consumables { get; set; }

            public string Vehicle_class { get; set; }

            public virtual ICollection<Pilots> Pilots { get; set;}

            public ICollection<Films> Films { get; set; }

            public DateTime Created { get; set; }

            public DateTime Edited { get; set; }

            
        }
    }
}
