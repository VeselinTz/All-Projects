using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var first =  int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third =  int.Parse(Console.ReadLine());
            var forth =  int.Parse(Console.ReadLine());

            Console.WriteLine(first.ToString("0000") + " " + second.ToString("0000") + " " + third.ToString("0000") + " " + forth.ToString("0000"));
        }
    }
}
