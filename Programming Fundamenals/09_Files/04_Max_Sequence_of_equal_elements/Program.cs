﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            int[] numbersArr = File.ReadAllText("input.txt")
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            List<int> numbersList = new List<int>(numbersArr);
            int counter = 0;
            int maxCounter = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] == numbersList[i + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxSequence = numbersList[i];
                    }
                }
                else counter = 0;
            }
            for (int i = 0; i <= maxCounter; i++)
                File.AppendAllText("output.txt", $"{maxSequence.ToString()} ");
        }
    }
}
