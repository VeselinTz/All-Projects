using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int calories = 0;
            string product; 

            int productCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productCount; i++) 
            {
                product = Console.ReadLine().ToLower();
                switch(product)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
