using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Chose_A_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price;
            switch (proffesion)
            {
                case "Athlete":
                    price = quantity * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1.00;
                    break;
                case "SoftUni Student":
                    price = quantity * 1.70;
                    break;
                default:
                    price = quantity * 1.20;
                    break;
            }
            Console.WriteLine($"The {proffesion} has to pay {string.Format("{0:0.00}",price)}.");
        }
    }
}
