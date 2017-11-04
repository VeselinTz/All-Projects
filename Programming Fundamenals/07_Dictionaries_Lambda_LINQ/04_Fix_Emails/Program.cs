using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email;
            while (name != "stop") 
            {
                email = Console.ReadLine();
                if(email[email.Length-1]!='k' 
                    && email[email.Length-1] != 's'
                    && email[email.Length-2] != 'u')
                {
                    dict.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var index in dict)

                Console.WriteLine($"{index.Key} -> {index.Value}");
        }
    }
}
