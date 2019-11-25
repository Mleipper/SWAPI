using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SWApiCaller.DbLayer;
using SWApiCaller.JSONModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWApiCaller.Data
{
    public abstract class APICaller<T, TModel> where TModel : class, new() where T : JsonListModel<TModel>
    {
        private string _baseUri = "https://swapi.co/api/";

        private JSONGetter _jsonGetter = new JSONGetter();

        private string _fullUri;

        protected ApplicationDbContext _dbContext;

        public APICaller(string endpoint)
        {
            _fullUri = _baseUri + endpoint;

            _dbContext = new ApplicationDbContext();
        }

        public string GetAllEntities()
        {
            return _jsonGetter.MakeRequest(_fullUri);
        }

        public string GetEntityByInt(int Number)
        {
            return _jsonGetter.MakeRequest($"{_fullUri}{Number}/");
        }

        public TModel GetSingleModelByInt(int num)
        {
            TModel model;
            try
            {
                string response = GetEntityByInt(num);

                model = JsonConvert.DeserializeObject<TModel>(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                model = new TModel();
            }
            return model;
        }

        public IEnumerable<TModel> GetModels()
        {
            string response = GetAllEntities();

            var jsonList = JsonConvert.DeserializeObject<T>(response);

            return jsonList.results;
        }

        protected abstract Task SaveModel(TModel model);

        public async Task SaveAllModels(IEnumerable<TModel> models)
        {
            foreach (var model in models)
            {
                await SaveModel(model);
            }
        }


    }
}
