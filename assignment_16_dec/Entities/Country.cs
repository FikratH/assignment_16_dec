using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16_dec.Entities
{
    internal class Country
    {
        public string Name;
        public long TotalPopulation;
        City[] _cities;

        public City[] cities
        {
            get
            {
                return _cities;
            }
            set
            {
                _cities = value;
            }
        }

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
        public void ChangeCityCount()
        {

            Array.Resize(ref _cities, cities.Length + 1);
        }
    }
}
