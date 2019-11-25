using System;
using System.Collections.Generic;
using System.Text;

namespace SWApiCaller.JSONModels
{
    public class JsonListModel<T> where T : class
    {
        public int count { get; set; }

        public string next { get; set; }

        public object previous { get; set; }

        public List<T> results { get; set; }
    }
}
