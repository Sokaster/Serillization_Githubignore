using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfSerillization
{
    internal class Ingridient
    {
        //public Ingridient(string name, double price, double energyCost, string manufacturer)
        //{
        //    name = Name;
        //    price = Price;
        //    energyCost = EnergyCost;
        //    manufacturer = Manufacturer;
        //}

        public List<string> Name { get; set; }

        public string Manufacturer { get; set; }
        public double Price { get; set; }
        [JsonProperty("Energy")]
        public double EnergyCost { get; set; }
        



    }
}
