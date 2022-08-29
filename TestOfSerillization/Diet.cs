using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace TestOfSerillization
{
    internal class Diet
    {
        //public Diet(string name, string author, string code, List<Ingridient> ingridients)
        //{

        //}

        public string Name { get; set; }

        public string Author { get; set; }
       [JsonIgnore]
        public string Code { get; set; }
        public Ingridient Ingridients { get; set; }

    }
}
