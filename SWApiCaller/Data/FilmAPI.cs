using SWApiCaller.JSONModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using SWApiCaller.DBModels;

namespace SWApiCaller.Data
{
    public class FilmAPI: APICaller<JsonListModel<FilmModel>, FilmModel>
    {
        public FilmAPI() : base("films/")
        { 
        
        }

        protected override async Task SaveModel(FilmModel Film)
        {
            await SaveFilm(Film);
        }

        public async Task SaveFilm(FilmModel Film)
        {
            if (_dbContext.Films.Any(f => f.Url == Film.Url)) return;
            Films film1 = new Films() { 
                Created = Film.Created,
                Director = Film.Director,
                Edited = Film.Edited,
                Episode_id = Film.Episode_id,
                Opening_crawl = Film.Opening_crawl,
                Producer = Film.Producer,
                Release_date = Film.Release_date,
                Title = Film.Title,
                Url = Film.Url
            };
            await _dbContext.AddAsync(film1);

            _dbContext.SaveChanges();
        }
    }
}
