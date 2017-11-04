using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            int quantity;
            while (resource != "stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resource))
                    dict.Add(resource, 0);
                    dict[resource] += quantity;
                resource = Console.ReadLine();              
            }
            foreach (var index in dict)
                Console.WriteLine($"{index.Key} -> {index.Value}");
        }
    }
}
