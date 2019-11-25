using SWApiCaller.JSONModels;
using System;
using System.Collections.Generic;
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

        public async Task SavePeople(PeopleModel people)
        {
            throw new NotImplementedException();
        }

    }
}
