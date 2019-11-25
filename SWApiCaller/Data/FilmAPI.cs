using SWApiCaller.JSONModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWApiCaller.Data
{
    public class FilmAPI: APICaller<JsonListModel<FilmModel>, FilmModel>
    {
        public FilmAPI() : base("films/")
        { 
        
        }

        protected override Task SaveModel(FilmModel model)
        {
            throw new NotImplementedException();
        }
    }
}
