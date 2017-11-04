using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainData = Console.ReadLine()
                .Split(new char[] { '|' })
                .ToArray();

            var Dict = new Dictionary<string, Dictionary<string, long>>();

            while (mainData[0] != "report")
            {
                string city = mainData[0];
                string country = mainData[1];
                long population = Convert.ToInt64(mainData[2]);

                if (!Dict.ContainsKey(country))
                {
                    Dict.Add(country, new Dictionary<string, long>());
                    Dict[country].Add(city, population);
                }
                else
                    if (!Dict[country].ContainsKey(city))
                    Dict[country].Add(city, population);

                mainData = Console.ReadLine()
                .Split(new char[] { '|' })
                .ToArray();
            }
            foreach (var country in Dict.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
