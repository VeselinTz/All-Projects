using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_Search_For_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            List<int> commandList = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();
            List<int> resltList = new List<int>(numbersList.Take(commandList[0]));
            resltList.RemoveRange(0,commandList[1]);
            if (resltList.Contains(commandList[2]))
                Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
