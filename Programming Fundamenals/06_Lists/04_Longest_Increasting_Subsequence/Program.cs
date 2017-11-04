using System;
using System.Collections.Generic;
using System.Linq;
namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
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
            for (int i = 0; i <maxCounter; i++)
                Console.Write($"{maxSequence} ");
        }
    }
}
