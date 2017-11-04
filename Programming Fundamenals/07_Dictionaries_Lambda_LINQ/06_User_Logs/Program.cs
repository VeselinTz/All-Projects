using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            var dict = new Dictionary<string, int>();
            List<string> NamesList = new List<string>();
            string IpCharRefined;
            List<char> IpChar = new List<char>();

            string NameCharRefined;
            List<char> NameChar = new List<char>();

            while (data[0]!= "end")
            {
                // Converts IP to list
                IpChar = data[0].Skip(3).ToList();
                // Extracts IP               
                IpCharRefined = String.Concat(
                IpChar.Where(c => IpChar.Contains(c));
                // Imports IP to dictionary with it's count
                if (!dict.ContainsKey(IpCharRefined))
                    dict.Add(IpCharRefined, 1);
                else dict[IpCharRefined]++;

                // Converts NAME to list
                NameChar = data[2].Skip(5).ToList();
                // Extracts NAME chars and puts them into new list
                NameCharRefined = string.Join(" ", NameChar);

                // Adds the name and extracted IP to the List of names
                if(!NamesList.Contains(NameCharRefined))
                NamesList.Add(NameCharRefined);

                // Clears all lists 
                data.Clear();
                IpChar.Clear();
                NameChar.Clear();

                // Reads a new line of data
                data = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
            }
            for (int i = 0; i < NamesList.Count; i++)
            {
                Console.WriteLine($"{NamesList[i]}:");
                foreach (var index in dict)
                    Console.Write($"{index.Key} => {index.Value}, ");
            }
        }
    }
}
