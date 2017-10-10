using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void fibunacci(int N)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            for(int i=0;i<N;i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fibunacci(n);
        }
    }
}
