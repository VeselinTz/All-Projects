using System;
using System.Collections.Generic;
using System.IO;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            string[] input = File.ReadAllLines("input.txt");
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < input.Length-1; i++) 
            {
                if (i % 2 == 0)
                {
                    if (!dict.ContainsKey(input[i]))
                        dict.Add(input[i], Convert.ToInt32(input[i + 1]));
                    else
                        dict[input[i + 1]] += Convert.ToInt32(i);
                    File.AppendAllText("output.txt", $"{input[i]} -> {input[i + 1]}" + Environment.NewLine);
                }
            }
        }
    }
}
