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
            int frequentSP = numbers[0];
            int frequentCER = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == frequentSP)
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        frequentCER = frequentSP;
                    }
                }
                else
                {
                    counter = 0;
                    frequentSP = numbers[i];
                }
            }
            Console.WriteLine(frequentCER);
        }
    }
}
