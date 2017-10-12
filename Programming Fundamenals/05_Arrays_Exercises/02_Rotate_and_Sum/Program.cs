using System;
using System.Linq;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] tempArr = new int[numArr.Length];
            int[] sumArr = new int[numArr.Length];

            for (int i = 0; i < k; i++)
            {
                Array.Reverse(numArr);
                Array.Reverse(numArr, 1, numArr.Length-1); 
                for (int j = 0; j < numArr.Length; j++)                   
                    sumArr[j] += numArr[j];               
            }
            Console.WriteLine($"{string.Join(" ", sumArr)}");

        }

    }
}
