using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] second = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();              ;
            int lenght = Math.Min(first.Length, second.Length);
            for (int i = 0; i < lenght; i++) 
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                    return;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                    return;
                }
            }
            if (first.Length < second.Length)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
        }
    }
}
