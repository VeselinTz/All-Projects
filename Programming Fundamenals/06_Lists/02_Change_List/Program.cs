using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                
                if (command[0] == "Delete")
                    numbersList.RemoveAll(x => x  == Convert.ToInt32(command[1]));
                if(command[0] == "Insert")
                    numbersList.Insert(Convert.ToInt32(command[2]), Convert.ToInt32(command[1]));
                command = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            }

            if (command[0] == "Odd")
                for (int i = 0; i < numbersList.Count; i++)
                    if (numbersList[i] % 2 != 0)
                        Console.Write(numbersList[i] + " ");
            if (command[0] == "Even")
                for (int i = 0; i < numbersList.Count; i++)
                    if (numbersList[i] % 2 == 0)
                        Console.Write(numbersList[i] + " ");
        }
    }
}
