using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        static bool isPrime(long number)
        {
            bool answer = true;
            if (number == 0 || number == 1)
                answer = false;
            for (int i = 2; i <= Math.Sqrt(number); i++) 
            {
                if (number % i == 0) 
                {
                    answer = false;
                    break;
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(number));
        }
    }
}
