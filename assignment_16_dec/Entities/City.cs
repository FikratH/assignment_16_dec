using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16_dec.Entities
{
    internal class City
    {
        public string Name;
        public long Population;

        public City(string name, long population, Country country)
        {
            Name = name;
            Population = population;
            country.TotalPopulation += population;
            Array.Resize(ref country.cities, country.cities.Length+1);
            country.cities[country.cities.Length - 1] = this;
        }
        public override string ToString()
        {
            return $"City: {Name}; Population: {Population}";
        }
    }
}
