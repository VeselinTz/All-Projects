﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());
            
            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++) 
                    if (i!=magicLetter && j!=magicLetter && k!=magicLetter)
                        Console.Write($"{i}{j}{k} ");
                }
            }  
        }
    }
}
