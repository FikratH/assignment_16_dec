using assignment_16_dec.Entities;

namespace assignment_16_dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Azerbaijan = new Country("Azerbaijan");
            Country Russia = new Country("Russia");
            City Baku = new City("Baku", 2000000, Azerbaijan);
            City Ganja = new City("Ganja", 330000, Azerbaijan);
            City Moscow = new City("Moscow",12000000,Russia);
            City Petersburg = new City("St. Petersburg", 5000000, Russia);
            Azerbaijan.FindAllByPopulation(100000, 3000000);
            Russia.FindAllByPopulation(1000000, 13000000);
        }
    }
}