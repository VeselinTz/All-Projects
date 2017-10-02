using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());

            byte c = a;
            a = b;
            b = c;

            Console.WriteLine($"Before:\n a = {b}\n b = {a}\n After:\n a = {a}\n b = {b}");
        }
    }
}
