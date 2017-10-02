using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            
            if (Convert.ToBoolean(n) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
