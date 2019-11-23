using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWApiCaller.DBModels
{
    public class Vehicle
    {
        
        
            public Vehicle()
            {
                this.Pilots = new HashSet<People>();
                this.Films = new HashSet<Films>();
            }
            [Key]
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

            public virtual ICollection<People> Pilots { get; set;}

            public virtual ICollection<Films> Films { get; set; }

            public DateTime Created { get; set; }

            public DateTime Edited { get; set; }

            
        
    }
}
