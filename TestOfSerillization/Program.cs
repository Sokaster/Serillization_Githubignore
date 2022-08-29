using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestOfSerillization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Diet diet = new Diet();

            diet.Name = "ALOBANSKAYA";
            diet.Author = "LOMEIKO";
            diet.Code = "ALPHA1";
            

            Ingridient ingridient = new Ingridient();

            ingridient.Name = new List<string>()
            {
                "moloko",
                "kokos",
                "banana"
            };
            ingridient.Manufacturer = "PALMOLIVE";
            ingridient.EnergyCost = 1992.7;
            ingridient.Price = 300;

            diet.Ingridients = ingridient;
            var dietserialaize = JsonConvert.SerializeObject(diet, Formatting.Indented);
            Console.WriteLine(dietserialaize);

        }
    }
}
