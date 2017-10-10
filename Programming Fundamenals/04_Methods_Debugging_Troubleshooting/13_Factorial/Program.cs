using System;
using System.Numerics;

namespace _13_Factorial
{
    class Program
    {
        static void factorial(int n)
        {          
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            int timesZero = 0;
            for (int power5 = 5; power5 <= n; power5 *= 5)
                timesZero += n / power5;
            Console.Write(timesZero);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            factorial(n);
        }
    }
}
