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

        protected override Task SaveModel(PeopleModel model)
        {
            throw new NotImplementedException();
        }
    }
}
