using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods_Debugging_Troubleshooting
{
    class Program
    {
        static void Name()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            Name();
        }
    }
}
