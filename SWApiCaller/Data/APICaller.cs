﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWApiCaller.Data
{
    public abstract class APICaller
    {
        private string _baseUri = "https://swapi.co/api/";

        private JSONGetter _jsonGetter = new JSONGetter();

        private string _fullUri;

        public APICaller(string endpoint)
        {
            _fullUri = _baseUri + endpoint;
        }

        public string GetAllEntities()
        {

            return _jsonGetter.MakeRequest(_fullUri);
  

        }

        public string GetEntityByInt(int Number)
        {
            return _jsonGetter.MakeRequest($"{_fullUri}{Number}/");
        }

    }
}