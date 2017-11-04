using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace _04_Longest_Increasting_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = File.ReadAllText("input.txt")
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;
            int maxCounter = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbersArr.Length - 1; i++)
            {
                for (int j = i; j < numbersArr.Length - 1; j++)
                    if (numbersArr[i] == numbersArr[j])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxSequence = numbersArr[i];
                        }
                    }
                counter = 0;
            }
            File.WriteAllText("output.txt", maxSequence.ToString());
        }
    }
}
