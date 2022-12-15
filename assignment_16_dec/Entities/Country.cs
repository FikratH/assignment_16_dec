using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16_dec.Entities
{
    internal class Country
    {
        public string Name;
        public long TotalPopulation;
        public City[] cities;

        public Country(string name)
        {
            Name = name;
            TotalPopulation = 0;
            cities = new City[0];
        }

        public void FindAllByPopulation(int min, int max)
        {
            Console.WriteLine($"Cities of {Name} [Population: {TotalPopulation}] with the population between {min} and {max}:\n");
            foreach (City city in cities)
            {
                if (city.Population >= min && city.Population <= max)
                {
                    Console.WriteLine(city);
                }
            }
            Console.WriteLine(" ");
        }
    }
}
