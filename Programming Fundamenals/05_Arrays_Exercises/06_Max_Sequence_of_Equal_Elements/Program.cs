using System;
using System.Linq;
namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;
            int maxCounter = 0;
            int[] sequentialNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        for (int j = 0; j < maxCounter+1; j++)
                            sequentialNumbers[j] = numbers[i];
                    }
                }
                else counter = 0;
            }
            for (int i = 0; i < numbers.Length; i++) 
                if(sequentialNumbers[i]!=0)
            Console.Write($"{sequentialNumbers[i]} ");
        }
    }
}
