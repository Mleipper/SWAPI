using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWApiCaller.DBModels
{
    public class People
    {
        //public People()
        //{
        //    this.Films = new HashSet<Films>();
        //    this.Vehicles = new HashSet<Vehicle>();
        //}
        [Key]
        public string Url { get; set; }

        public string Name { get; set; }

        public string Height { get; set; }

        public string Mass { get; set; }

        public string Hair_color { get; set; }

        public string Skin_color { get; set; }

        public string Eye_color { get; set; }

        public string Birth_year { get; set; }

        public string Gender { get; set; }

        public string Homeworld { get; set; }

       // public virtual ICollection<Films> Films { get; set; }

        //public List<string> Species { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }

        //public List<string> Starships { get; set; }

        public DateTime Created { get; set; }

        public DateTime Edited { get; set; }

        
    }
}
