using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace _12_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  File.ReadAllText("input.txt")
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int leftSum = 0;
            int rifhtSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    leftSum += numbers[j];
                for (int j = i + 1; j < numbers.Length; j++)
                    rifhtSum += numbers[j];
                if (leftSum == rifhtSum)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    return;
                }
                else
                {
                    leftSum = 0;
                    rifhtSum = 0;
                }
            }
            File.WriteAllText("output.txt", "no");
        }
    }
}
