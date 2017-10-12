using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Foulded_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int k = numbers.Length/4;
            int[] result = new int[k * 2];
            int[] left = numbers.Take(k).ToArray();
            int[] mid = numbers.Skip(k).Take(k*2).ToArray();
            int[] right = numbers.Skip(k*3).Take(k).ToArray();

            Array.Reverse(right);
            Array.Reverse(left);

            for (int i = 0; i < k; i++) 
            {
                result[i] = left[i] + mid[i];
                result[i + k] = mid[i + k] + right[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
