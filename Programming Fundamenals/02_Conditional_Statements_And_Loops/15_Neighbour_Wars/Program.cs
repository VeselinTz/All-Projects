using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int roundCounter = 1;
            int pHP = 100;
            int gHP = 100;

            int pDMG = int.Parse(Console.ReadLine());
            int gDMG = int.Parse(Console.ReadLine());

            while(true)
            {
               


                if (roundCounter % 2 != 0)
                {
                    if(gHP - pDMG <= 0)
                    {
                        Console.WriteLine($"Pesho won in {roundCounter}th round.");
                        break;
                    }
                    gHP -= pDMG;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gHP} health.");
                }
                else
                {
                    if (pHP - gDMG <= 0)
                    {
                        Console.WriteLine($"Gosho won in {roundCounter}th round.");
                        break;
                    }
                    pHP -= gDMG;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pHP} health.");
                }
                if (roundCounter % 3 == 0)
                {
                    gHP += 10;
                    pHP += 10;
                }

                roundCounter++;
            }
        }
    }
}
