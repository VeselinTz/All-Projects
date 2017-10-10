using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static int GetMax (int a, int b)
        {
            if (a > b)
                return a;
            else return b;
        }
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(first, second),GetMax(second, third)));
        }
    }
}
