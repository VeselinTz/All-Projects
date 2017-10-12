using System;
using System.Linq;

namespace _10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int dif = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == dif)
                        counter++;
                }
            }
            Console.Write(counter);
        }
    }
}
