using System;
using System.Linq;

namespace _04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n + 1];
            for (int i = 0; i <= n; i++)
                arr[i] = true;
            arr[0] = arr[1] = false;

            int p = 0;
            for (int i = 2; i <= n; i++) 
            {
                if(arr[i] == true)
                {
                    p = i;
                    Console.Write(p + " ");
                    for (int j = 2; j <= n / 2; j++) 
                    {
                        if (p * j > n) break;
                        else arr[p * j] = false;
                    }
                    
                }
            }
        }
    }
}
