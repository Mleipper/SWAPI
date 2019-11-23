using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWApiCaller.DBModels
{
    public class Films
    {
        //public Films()
        //{
        //    this.Vehicles = new HashSet<Vehicle>();
        //    this.Characters = new HashSet<People>();
        //}
        [Key]
        public string Url { get; set; }

        public string Title { get; set; }

        public int Episode_id { get; set; }

        public string Opening_crawl { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }

        public string Release_date { get; set; }

        //public virtual ICollection<People> Characters { get; set; }

        // public List<string> Planets { get; set; }

        //public List<string> Starships { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }

        //public List<string> Species { get; set; }

        public DateTime Created { get; set; }

        public DateTime Edited { get; set; }

        
    }
}
