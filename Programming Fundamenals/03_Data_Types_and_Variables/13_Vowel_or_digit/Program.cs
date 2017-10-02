using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vowel_or_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());

            if (n >= '0' && n <= '9')
                Console.WriteLine("digit");
            else if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
                Console.WriteLine("vowel");
            else Console.WriteLine("other");

        }
    }
}
