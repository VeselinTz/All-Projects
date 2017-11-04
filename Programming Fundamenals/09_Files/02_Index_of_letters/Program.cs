using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace _02_Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            char[] input = File.ReadAllText("input.txt").ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                var output = $"{input[i]} -> {input[i] - 97}" + Environment.NewLine;
                File.AppendAllText("оutput.txt", output);
            }              
        }
    }
}
