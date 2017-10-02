using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Print_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
