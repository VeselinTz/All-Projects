using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient;
            int counter=0;
            for(int i=0;i<20;i++) 
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
                else break;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
