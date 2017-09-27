using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Restaurant_Discounts
{
    class Program
    {
        static void Main(string[] args)
        {
            int gSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0;
            string hallName;
            if (gSize <= 120)
            {
                if (gSize <= 50)
                {
                    hallName = "Small Hall";
                    price += 2500;
                }
                else if (gSize <= 100)
                {
                    hallName = "Terrace";
                    price += 5000;
                }
                else 
                {
                    hallName = "Great Hall";
                    price += 7500;
                }


                if (package == "Normal")
                {
                    price += 500;
                    price -= 0.05 * price;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    price -= 0.1*price;
                }
                else
                {
                    price += 1000;
                    price -= 0.15 * price;
                }

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {string.Format("{0:0.00}", price/gSize)}$");

            }
            else
                Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
