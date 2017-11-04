using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var dict = new Dictionary<string, string>();
            var sortDict = new SortedDictionary<string, string>();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "A":
                        {
                            if (dict.ContainsKey(command[1]))
                                dict[command[1]] = command[2];
                            else
                                dict.Add(command[1], command[2]);
                            break;
                        }
                    case "S":
                        {
                            if (!dict.ContainsKey(command[1]))
                                Console.WriteLine($"Contact {command[1]} does not exist.");
                            else
                                Console.WriteLine($"{command[1]} -> {dict[command[1]]}");
                            break;
                        }
                    case "ListAll":
                        {
                            sortDict.Clear();
                            foreach(var index in dict)
                                sortDict.Add(index.Key, index.Value);
                            foreach (var index in sortDict)
                                Console.WriteLine($"{index.Key} -> {index.Value}");
                            break;
                        }
                }
                command.Clear();
                command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
        }
    }
}
