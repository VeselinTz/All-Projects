using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Game_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    counter++;
                    if (i+j==magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {i+j}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
