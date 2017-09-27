using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Miles_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            double kilometers = mile * 1.60934;
            Console.WriteLine(kilometers.ToString("##.0#"));
        }
    }
}
