using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Races
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<double> zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<double> fuels = new List<double>();
            for (int i = 0; i < names.Count; i++)
                fuels.Add(Convert.ToInt32(names[i][0]));
            for (int i = 0; i < names.Count; i++)
            {
                for (int j = 0; j < zones.Count; j++)
                {
                    if (indexes.Contains(j))
                        fuels[i] += zones[j];
                    else fuels[i] -= zones[j];
                    if (fuels[i] < 0)
                    {
                        Console.WriteLine($"{names[i]} - reached {j}");
                        break;
                    }
                    if(j==zones.Count-1)
                        Console.WriteLine($"{names[i]} - fuel left {fuels[i]:F2}");
                }              
            }
        }
    }
}
