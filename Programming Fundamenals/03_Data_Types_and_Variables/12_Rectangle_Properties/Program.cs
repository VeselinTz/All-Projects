using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine(a * 2 + b * 2);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt(a*a + b*b));

        }
    }
}
