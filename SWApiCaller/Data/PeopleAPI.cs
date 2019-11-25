using SWApiCaller.DBModels;
using SWApiCaller.JSONModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWApiCaller.Data
{
    public class PeopleAPI : APICaller<JsonListModel<PeopleModel>, PeopleModel>
    {
        public PeopleAPI() : base("people/")
        { 
        }

        protected override async Task SaveModel(PeopleModel people)
        {
            await SavePeople(people);
        }

        public async Task SavePeople(PeopleModel person)
        {
            if (_dbContext.people.Any(p => p.Url == person.Url)) return;
            People people1 = new People()
            {
                Birth_year = person.Birth_year,
                Created = person.Created,
                Edited = person.Edited,
                Eye_color = person.Eye_color,
                Gender = person.Gender,
                Hair_color = person.Hair_color,
                Height = person.Height,
                Homeworld = person.Homeworld,
                Mass = person.Mass,
                Name = person.Name,
                Skin_color = person.Skin_color,
                Url = person.Url 
            };

            await _dbContext.AddAsync(people1);

            _dbContext.SaveChanges();

        }

    }
}
