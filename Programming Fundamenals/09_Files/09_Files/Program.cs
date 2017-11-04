using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            var dict = new Dictionary<string, string>();
            string[] input = File.ReadAllLines("input.txt");
            for (int i = 1; i < input.Length; i++) 
            {
                if(i%2!=0)
                if(!input[i].EndsWith("uk") && !input[i].EndsWith("us"))
                {
                        var output = $"{input[i - 1]} -> {input[i]}"+ Environment.NewLine;
                        File.AppendAllText("output.txt", output);
                }
            }
        }
    }
}


