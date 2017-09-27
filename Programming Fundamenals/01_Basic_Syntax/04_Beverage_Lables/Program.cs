using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Beverage_Lables
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

           
            Console.WriteLine(volume + "ml " + name + ":");

            double energy = volume / 100 * energyContent;
            double sugar = volume / 100 * sugarContent;

            Console.WriteLine($"{energy}kcal, {sugar}g sugars");

        }
    }
}
