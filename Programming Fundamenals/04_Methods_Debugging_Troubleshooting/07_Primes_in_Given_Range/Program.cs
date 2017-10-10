using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Primes_in_Given_Range
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

        static  List<int> primeInRange(int begining, int ending)
        {
            var retList = new List<int>();

            for (int current = begining; current <= ending; current++)
                if (isPrime(current) == true)
                    retList.Add(current);

            return retList;

        }

        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int ending = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(", ", primeInRange(begining, ending)));
        }
    }
}
