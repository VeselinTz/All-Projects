using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = first; i >= 1; i--)
            {
                for (int j = 1; j <= second; j++)
                {
                    sum += 3 * (i * j);
                    counter++;
                    if (sum >= max)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return ;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
